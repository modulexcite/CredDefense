﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CredDefense.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("x86\\EasyPasswordFilter.dll")]
        public string EasyPasswordFilterDllLocationx86 {
            get {
                return ((string)(this["EasyPasswordFilterDllLocationx86"]));
            }
            set {
                this["EasyPasswordFilterDllLocationx86"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("x64\\EasyPasswordFilter.dll")]
        public string EasyPasswordFilterDllLocationx64 {
            get {
                return ((string)(this["EasyPasswordFilterDllLocationx64"]));
            }
            set {
                this["EasyPasswordFilterDllLocationx64"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("epf")]
        public string EpfFilesPath {
            get {
                return ((string)(this["EpfFilesPath"]));
            }
            set {
                this["EpfFilesPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("rsguardcd")]
        public string ResponderGuardTask {
            get {
                return ((string)(this["ResponderGuardTask"]));
            }
            set {
                this["ResponderGuardTask"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("cdevtxparse")]
        public string CDEventParseTask {
            get {
                return ((string)(this["CDEventParseTask"]));
            }
            set {
                this["CDEventParseTask"] = value;
            }
        }
    }
}
