﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.R.Host.Broker {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.R.Host.Broker.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested to write server.urls to pipe &apos;{0}&apos;, but it is not a valid pipe handle.
        /// </summary>
        internal static string Critical_InvalidPipeHandle {
            get {
                return ResourceManager.GetString("Critical_InvalidPipeHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TLS certificate not found: {0}.
        /// </summary>
        internal static string Critical_NoTlsCertificate {
            get {
                return ResourceManager.GetString("Critical_NoTlsCertificate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested to write server.urls to pipe &apos;{0}&apos;, but timed out while trying to connect to pipe.
        /// </summary>
        internal static string Critical_PipeConnectTimeOut {
            get {
                return ResourceManager.GetString("Critical_PipeConnectTimeOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timed out waiting for graceful shutdown.
        /// </summary>
        internal static string Critical_TimeOutShutdown {
            get {
                return ResourceManager.GetString("Critical_TimeOutShutdown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command Line or Config File error: {0}.
        /// </summary>
        internal static string Error_ConfigFailed {
            get {
                return ResourceManager.GetString("Error_ConfigFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server port {0} is already in use..
        /// </summary>
        internal static string Error_ConfiguredPortNotAvailable {
            get {
                return ResourceManager.GetString("Error_ConfiguredPortNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to get user profile directory for user {0} with WIN32 error code 0x{1}.
        /// </summary>
        internal static string Error_GetUserProfileDirectory {
            get {
                return ResourceManager.GetString("Error_GetUserProfileDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log on failed for user: {0}.
        /// </summary>
        internal static string Error_LogOnFailed {
            get {
                return ResourceManager.GetString("Error_LogOnFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile creation failed for user {0} with WIN32 error code 0x{1}.
        /// </summary>
        internal static string Error_ProfileCreationFailed {
            get {
                return ResourceManager.GetString("Error_ProfileCreationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile creation failed for user {0} with invalid response from the {1} service..
        /// </summary>
        internal static string Error_ProfileCreationFailedInvalidResponse {
            get {
                return ResourceManager.GetString("Error_ProfileCreationFailedInvalidResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User name parsing failed for user {0} with WIN32 error code 0x{1}.
        /// </summary>
        internal static string Error_UserNameParse {
            get {
                return ResourceManager.GetString("Error_UserNameParse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided identity must be a {0}.
        /// </summary>
        internal static string Exception_InvalidIdentityType {
            get {
                return ResourceManager.GetString("Exception_InvalidIdentityType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Broker name &apos;{0}&apos; assigned.
        /// </summary>
        internal static string Info_BrokerName {
            get {
                return ResourceManager.GetString("Info_BrokerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile already exists for user: {0}.
        /// </summary>
        internal static string Info_ProfileAlreadyExists {
            get {
                return ResourceManager.GetString("Info_ProfileAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile created for user: {0}.
        /// </summary>
        internal static string Info_ProfileCreated {
            get {
                return ResourceManager.GetString("Info_ProfileCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft.R.Host.UserProfile.
        /// </summary>
        internal static string Info_UserProfileServiceName {
            get {
                return ResourceManager.GetString("Info_UserProfileServiceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creates and manages R Host (Microsoft.R.Host.exe) sessions..
        /// </summary>
        internal static string Text_ServiceDescription {
            get {
                return ResourceManager.GetString("Text_ServiceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to R Remote Service.
        /// </summary>
        internal static string Text_ServiceDisplayName {
            get {
                return ResourceManager.GetString("Text_ServiceDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RRemoteService.
        /// </summary>
        internal static string Text_ServiceName {
            get {
                return ResourceManager.GetString("Text_ServiceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} = {1}.
        /// </summary>
        internal static string Trace_EnvironmentVariable {
            get {
                return ResourceManager.GetString("Trace_EnvironmentVariable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating user environment variables for user {0} with profile directory {1}.
        /// </summary>
        internal static string Trace_EnvironmentVariableCreationBegin {
            get {
                return ResourceManager.GetString("Trace_EnvironmentVariableCreationBegin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log on succeeded for user: {0}.
        /// </summary>
        internal static string Trace_LogOnSuccess {
            get {
                return ResourceManager.GetString("Trace_LogOnSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting log on for user: {0}.
        /// </summary>
        internal static string Trace_LogOnUserBegin {
            get {
                return ResourceManager.GetString("Trace_LogOnUserBegin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Writing server.urls to pipe &apos;{0}&apos;:{1}{2}.
        /// </summary>
        internal static string Trace_ServerUrlsToPipeBegin {
            get {
                return ResourceManager.GetString("Trace_ServerUrlsToPipeBegin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrote server.urls to pipe &apos;{0}&apos;.
        /// </summary>
        internal static string Trace_ServerUrlsToPipeDone {
            get {
                return ResourceManager.GetString("Trace_ServerUrlsToPipeDone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to create profile for user: {0}.
        /// </summary>
        internal static string Trace_UserProfileCreation {
            get {
                return ResourceManager.GetString("Trace_UserProfileCreation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User {0} profile directory: {1}.
        /// </summary>
        internal static string Trace_UserProfileDirectory {
            get {
                return ResourceManager.GetString("Trace_UserProfileDirectory", resourceCulture);
            }
        }
    }
}
