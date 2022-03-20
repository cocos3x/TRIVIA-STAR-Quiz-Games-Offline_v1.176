using UnityEngine;

namespace twelvegigs.plugins
{
    public class SharePlugin
    {
        // Fields
        private static UnityEngine.AndroidJavaObject plugin;
        
        // Methods
        public static void Share(string text, string url, string subject, string emailBody, string imgPath)
        {
            twelvegigs.plugins.SharePlugin.AndroidShare(text:  text, url:  url, subject:  subject, emailBody:  emailBody, imgPath:  imgPath);
        }
        public static void SendEmail(string subject, string emailBody, string url, string imgPath)
        {
            twelvegigs.plugins.SharePlugin.AndroidSendEmail(subject:  subject, emaiBody:  emailBody, url:  url, imgPath:  imgPath);
        }
        public static void ShareTwitter(string message, string url)
        {
            if(message.m_stringLength > 280)
            {
                    UnityEngine.Debug.LogWarning(message:  1150800640);
            }
            
            string val_1 = UnityEngine.WWW.EscapeURL(s:  message);
            string val_2 = message.Replace(oldValue:  -1467947360, newValue:  1150800832);
            string val_3 = UnityEngine.WWW.EscapeURL(s:  url);
            string val_4 = url.Replace(oldValue:  -1467947360, newValue:  1150800832);
            string val_5 = System.String.Format(format:  1150800912, arg0:  message, arg1:  url);
            UnityEngine.Application.OpenURL(url:  1150800912);
        }
        public static void OpenURL(string url)
        {
            UnityEngine.Application.OpenURL(url:  url);
        }
        public static void SendSMS(string text, string url)
        {
            twelvegigs.plugins.SharePlugin.AndroidSendSMS(text:  text, url:  url);
        }
        public static void SendWhatsApp(string text)
        {
            string val_1 = UnityEngine.WWW.EscapeURL(s:  text);
            string val_2 = text.Replace(oldValue:  -1467947360, newValue:  1150800832);
            string val_3 = 1151173952 + text;
            UnityEngine.Application.OpenURL(url:  1151173952);
        }
        public static void CopyToClipBoard(string text, string label = "")
        {
            twelvegigs.plugins.SharePlugin.AndroidCopyToClipboard(text:  text, label:  label);
        }
        private static UnityEngine.AndroidJavaObject getPlugin()
        {
            var val_2;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1151418544);
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            if(null != 0)
            {
                    return CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            }
            
            return CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        private static void AndroidShare(string text, string url, string subject, string emailBody, string imgPath)
        {
            bool val_2 = static_value_022034DA;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = twelvegigs.plugins.SharePlugin.getPlugin();
            twelvegigs.plugins.SharePlugin.plugin = val_2;
            if(twelvegigs.plugins.SharePlugin.plugin == 0)
            {
                    return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = text;
            typeof(System.Object[]).__il2cppRuntimeField_14 = url;
            typeof(System.Object[]).__il2cppRuntimeField_18 = subject;
            typeof(System.Object[]).__il2cppRuntimeField_1C = emailBody;
            typeof(System.Object[]).__il2cppRuntimeField_20 = imgPath;
            twelvegigs.plugins.SharePlugin.plugin.Call(methodName:  1151551168, args:  472754880);
        }
        private static void AndroidCopyToClipboard(string text, string label)
        {
            bool val_2 = static_value_022034DB;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = twelvegigs.plugins.SharePlugin.getPlugin();
            twelvegigs.plugins.SharePlugin.plugin = val_2;
            if(twelvegigs.plugins.SharePlugin.plugin == 0)
            {
                    return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = label;
            typeof(System.Object[]).__il2cppRuntimeField_14 = text;
            twelvegigs.plugins.SharePlugin.plugin.Call(methodName:  1151691936, args:  472754880);
        }
        private static void AndroidSendEmail(string subject, string emaiBody, string url, string imgPath)
        {
            bool val_2 = static_value_022034DC;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = twelvegigs.plugins.SharePlugin.getPlugin();
            twelvegigs.plugins.SharePlugin.plugin = val_2;
            if(twelvegigs.plugins.SharePlugin.plugin == 0)
            {
                    return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = subject;
            typeof(System.Object[]).__il2cppRuntimeField_14 = emaiBody;
            typeof(System.Object[]).__il2cppRuntimeField_18 = url;
            typeof(System.Object[]).__il2cppRuntimeField_1C = imgPath;
            twelvegigs.plugins.SharePlugin.plugin.Call(methodName:  1151828624, args:  472754880);
        }
        private static void AndroidSendSMS(string text, string url)
        {
            bool val_2 = static_value_022034DD;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            UnityEngine.AndroidJavaObject val_1 = twelvegigs.plugins.SharePlugin.getPlugin();
            twelvegigs.plugins.SharePlugin.plugin = val_2;
            if(twelvegigs.plugins.SharePlugin.plugin == 0)
            {
                    return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = text;
            typeof(System.Object[]).__il2cppRuntimeField_14 = url;
            twelvegigs.plugins.SharePlugin.plugin.Call(methodName:  1151965296, args:  472754880);
        }
        public SharePlugin()
        {
        
        }
    
    }

}
