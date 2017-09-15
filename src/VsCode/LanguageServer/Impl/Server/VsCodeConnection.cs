﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Based on https://github.com/CXuesong/LanguageServer.NET

using System;
using System.IO;
using System.Reflection;
using JsonRpc.Standard.Client;
using JsonRpc.Standard.Contracts;
using JsonRpc.Standard.Server;
using JsonRpc.Streams;
using LanguageServer.VsCode;
using Microsoft.Common.Core;
using Microsoft.Common.Core.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace Microsoft.R.LanguageServer.Server {
    /// <summary>
    /// Represents connection to VsCode.
    /// Listens on stdin/stdout for the language protocol JSON RPC
    /// </summary>
    internal sealed class VsCodeConnection {
        public void Connect(IServiceContainer services, bool debugMode) {
            var logWriter = CreateLogWriter(debugMode);

            using (logWriter)
            using (var cin = Console.OpenStandardInput())
            using (var bcin = new BufferedStream(cin))
            using (var cout = Console.OpenStandardOutput())
            using (var reader = new PartwiseStreamMessageReader(bcin))
            using (var writer = new PartwiseStreamMessageWriter(cout)) {
                var contractResolver = new JsonRpcContractResolver {
                    NamingStrategy = new CamelCaseJsonRpcNamingStrategy(),
                    ParameterValueConverter = new CamelCaseJsonValueConverter(),
                };
                var clientHandler = new StreamRpcClientHandler();
                var client = new JsonRpcClient(clientHandler);
                if (debugMode) {
                    // We want to capture log all the LSP server-to-client calls as well
                    clientHandler.MessageSending += (_, e) => {
                        lock (logWriter) {
                            logWriter.WriteLine("<C{0}", e.Message);
                        }
                    };
                    clientHandler.MessageReceiving += (_, e) => {
                        lock (logWriter) {
                            logWriter.WriteLine(">C{0}", e.Message);
                        }
                    };
                }
                // Configure & build service host
                var session = new LanguageServerSession(client, contractResolver);
                var host = BuildServiceHost(logWriter, contractResolver, debugMode);
                var serverHandler = new StreamRpcServerHandler(host,
                    StreamRpcServerHandlerOptions.ConsistentResponseSequence |
                    StreamRpcServerHandlerOptions.SupportsRequestCancellation);
                serverHandler.DefaultFeatures.Set(session);

                // If we want server to stop, just stop the "source"
                using (serverHandler.Attach(reader, writer))
                using (clientHandler.Attach(reader, writer))
                using (var rConnection = new RConnection()) {
                    rConnection.ConnectAsync(services).DoNotWait();
                    // Wait for the "stop" request.
                    session.CancellationToken.WaitHandle.WaitOne();
                }
                logWriter?.WriteLine("Exited");
            }
        }

        private static IJsonRpcServiceHost BuildServiceHost(TextWriter logWriter,
            IJsonRpcContractResolver contractResolver, bool debugMode) {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new DebugLoggerProvider(null));

            var builder = new JsonRpcServiceHostBuilder {
                ContractResolver = contractResolver,
                LoggerFactory = loggerFactory
            };

            builder.UseCancellationHandling();
            builder.Register(typeof(Program).GetTypeInfo().Assembly);

            if (debugMode) {
                // Log all the client-to-server calls.
                builder.Intercept(async (context, next) => {
                    lock (logWriter) {
                        logWriter.WriteLine("> {0}", context.Request);
                    }

                    await next();

                    lock (logWriter) {
                        logWriter.WriteLine("< {0}", context.Response);
                    }
                });
            }
            return builder.Build();
        }

        private static StreamWriter CreateLogWriter(bool debugMode) {
            StreamWriter logWriter = null;
            if (debugMode) {
                var tempPath = Path.GetTempPath();
                var fileName = "VSCode_R_JsonRPC-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";
                logWriter = File.CreateText(Path.Combine(tempPath, fileName));
                logWriter.AutoFlush = true;
            }
            return logWriter;
        }
    }
}
