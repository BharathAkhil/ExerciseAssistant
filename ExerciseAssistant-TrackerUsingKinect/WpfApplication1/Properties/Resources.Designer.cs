﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication1.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WpfApplication1.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Type {0} does not support event: {1}.
        /// </summary>
        internal static string CommandOnEventException {
            get {
                return ResourceManager.GetString("CommandOnEventException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To get started
        ///Lift your hand.
        /// </summary>
        internal static string EngagementHandoffGetStarted {
            get {
                return ResourceManager.GetString("EngagementHandoffGetStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lift your hand
        ///to keep control.
        /// </summary>
        internal static string EngagementHandoffKeepControl {
            get {
                return ResourceManager.GetString("EngagementHandoffKeepControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied Uri {0} points to a invalid content.
        /// </summary>
        internal static string InvalidPanningContent {
            get {
                return ResourceManager.GetString("InvalidPanningContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kinect Controller is invalid.
        /// </summary>
        internal static string KinectControllerInvalid {
            get {
                return ResourceManager.GetString("KinectControllerInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have selected {0}.
        /// </summary>
        internal static string ScrollingListSelectionMessage {
            get {
                return ResourceManager.GetString("ScrollingListSelectionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This sample was designed 1920 x 1080 screen resolution.
        ///Running it in a lower resolution may result in incorrect layout and reduced functionality.
        ///Do you wish to continue?.
        /// </summary>
        internal static string SuboptimalScreenResolutionMessage {
            get {
                return ResourceManager.GetString("SuboptimalScreenResolutionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Suboptimal Screen Resolution.
        /// </summary>
        internal static string SuboptimalScreenResolutionTitle {
            get {
                return ResourceManager.GetString("SuboptimalScreenResolutionTitle", resourceCulture);
            }
        }
    }
}
