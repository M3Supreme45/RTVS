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
    using System.Reflection;
    
    
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.R.Host.Broker.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Username or password is invalid..
        /// </summary>
        internal static string Error_AuthBadInput {
            get {
                return ResourceManager.GetString("Error_AuthBadInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication failed with Error: {0}.
        /// </summary>
        internal static string Error_AuthFailed {
            get {
                return ResourceManager.GetString("Error_AuthFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication initialization failed..
        /// </summary>
        internal static string Error_AuthInitFailed {
            get {
                return ResourceManager.GetString("Error_AuthInitFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No input to authenticate..
        /// </summary>
        internal static string Error_AuthNoInput {
            get {
                return ResourceManager.GetString("Error_AuthNoInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Profile dirctory could not be found..
        /// </summary>
        internal static string Error_NoProfileDir {
            get {
                return ResourceManager.GetString("Error_NoProfileDir", resourceCulture);
            }
        }
    }
}
