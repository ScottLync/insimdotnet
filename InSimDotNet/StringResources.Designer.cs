﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InSimDotNet {
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
    internal class StringResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StringResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("InSimDotNet.StringResources", typeof(StringResources).Assembly);
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
        ///   Looks up a localized string similar to InSim is already connected.
        /// </summary>
        internal static string InSimConnectedMessage {
            get {
                return ResourceManager.GetString("InSimConnectedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lost connection to InSim..
        /// </summary>
        internal static string InSimConnectionLostMessage {
            get {
                return ResourceManager.GetString("InSimConnectionLostMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not connect to InSim.
        /// </summary>
        internal static string InSimCouldNotConnectMessage {
            get {
                return ResourceManager.GetString("InSimCouldNotConnectMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid InSim version.
        /// </summary>
        internal static string InSimInvalidVersionMessage {
            get {
                return ResourceManager.GetString("InSimInvalidVersionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InSim is not connected.
        /// </summary>
        internal static string InSimNotConnectedMessage {
            get {
                return ResourceManager.GetString("InSimNotConnectedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot connect to InSim Relay with UDP.
        /// </summary>
        internal static string InSimRelayUdpErrorMessage {
            get {
                return ResourceManager.GetString("InSimRelayUdpErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IS_AXM more than max 30 objects set.
        /// </summary>
        internal static string IsAxmInfoErrorMessage {
            get {
                return ResourceManager.GetString("IsAxmInfoErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IS_REO more than max 32 PLIDs set.
        /// </summary>
        internal static string IsReoPlidErrorMessage {
            get {
                return ResourceManager.GetString("IsReoPlidErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Packet size was not a multiple of four.
        /// </summary>
        internal static string PacketSizeErrorMessage {
            get {
                return ResourceManager.GetString("PacketSizeErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TCP Receive Error: {0}.
        /// </summary>
        internal static string TcpSocketDebugErrorMessage {
            get {
                return ResourceManager.GetString("TcpSocketDebugErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UDP Receive Error: {0}.
        /// </summary>
        internal static string UdpSocketDebugErrorMessage {
            get {
                return ResourceManager.GetString("UdpSocketDebugErrorMessage", resourceCulture);
            }
        }
    }
}
