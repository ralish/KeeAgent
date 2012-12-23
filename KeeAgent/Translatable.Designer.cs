﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeeAgent {
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
    internal class Translatable {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Translatable() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KeeAgent.Translatable", typeof(Translatable).Assembly);
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
        ///   Looks up a localized string similar to Lock.
        /// </summary>
        internal static string ButtonLock {
            get {
                return ResourceManager.GetString("ButtonLock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unlock.
        /// </summary>
        internal static string ButtonUnlock {
            get {
                return ResourceManager.GetString("ButtonUnlock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Another application is requesting SSH key &apos;{0}&apos;. Do you want to allow this?.
        /// </summary>
        internal static string ConfirmKeyFetch {
            get {
                return ResourceManager.GetString("ConfirmKeyFetch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pageant is already running. KeeAgent plugin will not be loaded..
        /// </summary>
        internal static string ErrPageantRunning {
            get {
                return ResourceManager.GetString("ErrPageantRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while loading key from entry &apos;{0}&apos; in group &apos;{1}&apos; in database &apos;{2}&apos;.
        /// </summary>
        internal static string ErrParsingKey {
            get {
                return ResourceManager.GetString("ErrParsingKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error &apos;{0}&apos; occured while parsing file &apos;{1}&apos;.
        /// </summary>
        internal static string ErrPpkFileException {
            get {
                return ResourceManager.GetString("ErrPpkFileException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Error.
        /// </summary>
        internal static string ErrUnknown {
            get {
                return ResourceManager.GetString("ErrUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KeeAgent.
        /// </summary>
        internal static string KeeAgent {
            get {
                return ResourceManager.GetString("KeeAgent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage....
        /// </summary>
        internal static string ManageKeeAgentMenuItem {
            get {
                return ResourceManager.GetString("ManageKeeAgentMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SSH key &apos;{0}&apos; was fetched by another application..
        /// </summary>
        internal static string NotifyKeyFetched {
            get {
                return ResourceManager.GetString("NotifyKeyFetched", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KeeAgent is now locked.
        /// </summary>
        internal static string NotifyLocked {
            get {
                return ResourceManager.GetString("NotifyLocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KeeAgent is now unlocked.
        /// </summary>
        internal static string NotifyUnlocked {
            get {
                return ResourceManager.GetString("NotifyUnlocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Agent.
        /// </summary>
        internal static string OptionAgentModeAgent {
            get {
                return ResourceManager.GetString("OptionAgentModeAgent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Auto.
        /// </summary>
        internal static string OptionAgentModeAuto {
            get {
                return ResourceManager.GetString("OptionAgentModeAuto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client.
        /// </summary>
        internal static string OptionAgentModeClient {
            get {
                return ResourceManager.GetString("OptionAgentModeClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Always require confirmation when client requests to use key.
        /// </summary>
        internal static string OptionAlwaysConfirm {
            get {
                return ResourceManager.GetString("OptionAlwaysConfirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable Debug Logging.
        /// </summary>
        internal static string OptionLoggingEnabled {
            get {
                return ResourceManager.GetString("OptionLoggingEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show notification balloon when key is used by client.
        /// </summary>
        internal static string OptionShowBalloon {
            get {
                return ResourceManager.GetString("OptionShowBalloon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options....
        /// </summary>
        internal static string OptionsMenuItem {
            get {
                return ResourceManager.GetString("OptionsMenuItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KeeAgent Is Locked.
        /// </summary>
        internal static string StatusLocked {
            get {
                return ResourceManager.GetString("StatusLocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KeeAgent is Unlocked.
        /// </summary>
        internal static string StatusUnlocked {
            get {
                return ResourceManager.GetString("StatusUnlocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  - Agent Mode.
        /// </summary>
        internal static string TitleSuffixAgentMode {
            get {
                return ResourceManager.GetString("TitleSuffixAgentMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  - Client Mode.
        /// </summary>
        internal static string TitleSuffixClientMode {
            get {
                return ResourceManager.GetString("TitleSuffixClientMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Algorithm.
        /// </summary>
        internal static string UnknownAlgorithm {
            get {
                return ResourceManager.GetString("UnknownAlgorithm", resourceCulture);
            }
        }
    }
}
