﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LTZN.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>坐料回慢风</string>
  <string>炉况难行</string>
  <string>控料速</string>
  <string>提Si</string>
  <string>铁罐晚点</string>
  <string>休风复慢风</string>
  <string>出不净</string>
  <string>设备慢风</string>
  <string>备休</string>
  <string>待料</string>
  <string>铁口浅</string>
  <string>淹铁道</string>
  <string>其它</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection 慢风分类 {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["慢风分类"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>抢修</string>
  <string>设备计划检修</string>
  <string>非计划检修</string>
  <string>风渣口</string>
  <string>其它易损件</string>
  <string>工艺操作故障</string>
  <string>生产事故</string>
  <string>机械故障</string>
  <string>电气故障</string>
  <string>其它设备故障</string>
  <string>其它内因</string>
  <string>动力原因</string>
  <string>运输原因</string>
  <string>待料</string>
  <string>其它外因</string>
  <string>生产计划休风</string>
  <string>生产非计划</string>
  <string>大修</string>
  <string>中修</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection 休风分类 {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["休风分类"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>其它熟料</string>
  <string>黄石球</string>
  <string>秘鲁球</string>
  <string>巴西球</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection 熟料分类 {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["熟料分类"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>其它生料</string>
  <string>武安矿</string>
  <string>宣化矿</string>
  <string>黄石矿</string>
  <string>巴西矿</string>
  <string>澳矿</string>
  <string>冷球</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection 生料分类 {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["生料分类"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("取消")]
        public string 取消 {
            get {
                return ((string)(this["取消"]));
            }
            set {
                this["取消"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("密码")]
        public string 密码 {
            get {
                return ((string)(this["密码"]));
            }
            set {
                this["密码"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("用户名")]
        public string 用户名 {
            get {
                return ((string)(this["用户名"]));
            }
            set {
                this["用户名"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("192.168.38.28")]
        public string 服务器 {
            get {
                return ((string)(this["服务器"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("马保良")]
        public string 负责人 {
            get {
                return ((string)(this["负责人"]));
            }
            set {
                this["负责人"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("刘红芬")]
        public string 制表人 {
            get {
                return ((string)(this["制表人"]));
            }
            set {
                this["制表人"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LIANTIE;Persist Security Info=True;User ID=LF;Password=LF;Unicode=Tru" +
            "e")]
        public string ltznConnectionString {
            get {
                return ((string)(this["ltznConnectionString"]));
            }
        }
    }
}
