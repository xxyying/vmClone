﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vm_Clone.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string VmosoUsername {
            get {
                return ((string)(this["VmosoUsername"]));
            }
            set {
                this["VmosoUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string VmosoPassword {
            get {
                return ((string)(this["VmosoPassword"]));
            }
            set {
                this["VmosoPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.vmoso.com")]
        public string VmosoHost {
            get {
                return ((string)(this["VmosoHost"]));
            }
            set {
                this["VmosoHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CID-ebe77e0f-923a-4a75-b419-13242b8d1bbd")]
        public string VmosoCid {
            get {
                return ((string)(this["VmosoCid"]));
            }
            set {
                this["VmosoCid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RememberMe {
            get {
                return ((bool)(this["RememberMe"]));
            }
            set {
                this["RememberMe"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{0}: {1}<{2}@{3}>")]
        public string EmailLink {
            get {
                return ((string)(this["EmailLink"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<a href=\'{0}\'>{1}{2}</a>")]
        public string ReferenceLink {
            get {
                return ((string)(this["ReferenceLink"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int CachedFilesPerType {
            get {
                return ((int)(this["CachedFilesPerType"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<a class=\"mention_cke\" data-ownerkey=\"{0}\" data-tag=\"{1}\" data-type=\"@\" href=\"{2}" +
            "\" title=\"{3}\">{4}</a>")]
        public string EditorUserLink {
            get {
                return ((string)(this["EditorUserLink"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<a class=\"rmevtag_cke\" data-cid=\"{0}\" data-listkey=\"{1}\" data-ownerkey=\"{2}\" data" +
            "-parentkey=\"{3}\" data-pid=\"{4}\" data-tag=\"{5}\" data-type=\"#\" href=\"{6}\" title=\"{" +
            "7}\">{8}</a>")]
        public string EditorCommentLink {
            get {
                return ((string)(this["EditorCommentLink"]));
            }
        }
    }
}
