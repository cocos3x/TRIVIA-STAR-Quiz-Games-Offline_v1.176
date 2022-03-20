using UnityEngine;

namespace Helpshift
{
    public class HelpshiftAndroid
    {
        // Fields
        private UnityEngine.AndroidJavaClass jc;
        private UnityEngine.AndroidJavaObject currentActivity;
        private UnityEngine.AndroidJavaObject application;
        private UnityEngine.AndroidJavaClass hsHelpshiftClass;
        
        // Methods
        public HelpshiftAndroid()
        {
            var val_5;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1282230784);
            this.jc = null;
            object val_2 = GetStatic<System.Object>(fieldName:  1282231936);
            this.currentActivity = null;
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_5 == 1)
            {
                    val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1890614784, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            this.application = null;
            UnityEngine.AndroidJavaClass val_4 = new UnityEngine.AndroidJavaClass(className:  502433136);
            this.hsHelpshiftClass = null;
        }
        public void install(string apiKey, string domain, string appId, System.Collections.Generic.Dictionary<string, object> configMap)
        {
            string val_1 = Json.Serializer.Serialize(obj:  configMap);
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.application;
            typeof(System.Object[]).__il2cppRuntimeField_14 = apiKey;
            typeof(System.Object[]).__il2cppRuntimeField_18 = domain;
            typeof(System.Object[]).__il2cppRuntimeField_1C = appId;
            typeof(System.Object[]).__il2cppRuntimeField_20 = configMap;
            this.hsHelpshiftClass.CallStatic(methodName:  502569856, args:  472754880);
            string val_2 = 502570048 + domain + 502569952 + configMap;
            Helpshift.HelpshiftInternalLogger.d(message:  502570048);
        }
        public void requestUnreadMessagesCount(bool isAsync)
        {
            string val_1 = isAsync.ToString();
            string val_2 = 502706752 + 502723111;
            Helpshift.HelpshiftInternalLogger.d(message:  502706752);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            this.hsHelpshiftClass.CallStatic(methodName:  502711008, args:  472754880);
        }
        public void setNameAndEmail(string userName, string email)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = userName;
            typeof(System.Object[]).__il2cppRuntimeField_14 = email;
            this.hsHelpshiftClass.CallStatic(methodName:  502839520, args:  472754880);
        }
        public void setUserIdentifier(string identifier)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = identifier;
            this.hsHelpshiftClass.CallStatic(methodName:  502972112, args:  472754880);
        }
        public void registerDeviceToken(string deviceToken)
        {
            string val_1 = 503096512 + deviceToken;
            Helpshift.HelpshiftInternalLogger.d(message:  503096512);
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.currentActivity;
            typeof(System.Object[]).__il2cppRuntimeField_14 = deviceToken;
            this.hsHelpshiftClass.CallStatic(methodName:  503104832, args:  472754880);
        }
        public void leaveBreadCrumb(string breadCrumb)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = breadCrumb;
            this.hsHelpshiftClass.CallStatic(methodName:  503237424, args:  472754880);
        }
        public void clearBreadCrumbs()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            this.hsHelpshiftClass.CallStatic(methodName:  503361824, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public void login(string identifier, string userName, string email)
        {
            string val_1 = 503490320 + userName;
            Helpshift.HelpshiftInternalLogger.d(message:  503490320);
            typeof(System.Object[]).__il2cppRuntimeField_10 = identifier;
            typeof(System.Object[]).__il2cppRuntimeField_14 = userName;
            typeof(System.Object[]).__il2cppRuntimeField_18 = email;
            this.hsHelpshiftClass.CallStatic(methodName:  -1987367488, args:  472754880);
        }
        public void login(Helpshift.HelpshiftUser helpshiftUser)
        {
            string val_1 = 503490320 + helpshiftUser.name;
            Helpshift.HelpshiftInternalLogger.d(message:  503490320);
            string val_2 = jsonifyHelpshiftUser(helpshiftUser:  helpshiftUser);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            this.hsHelpshiftClass.CallStatic(methodName:  503635200, args:  472754880);
        }
        public void clearAnonymousUser()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            this.hsHelpshiftClass.CallStatic(methodName:  503763696, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public void logout()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            this.hsHelpshiftClass.CallStatic(methodName:  -220247120, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        private string serializeApiConfig(System.Collections.Generic.Dictionary<string, object> configMap)
        {
            if(configMap == 0)
            {
                    this = 0;
                return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = this.cleanConfig(configMap:  configMap);
            return Json.Serializer.Serialize(obj:  0);
        }
        public void showConversation(System.Collections.Generic.Dictionary<string, object> configMap)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.currentActivity;
            string val_1 = this.serializeApiConfig(configMap:  configMap);
            typeof(System.Object[]).__il2cppRuntimeField_14 = this;
            this.hsHelpshiftClass.CallStatic(methodName:  504132576, args:  472754880);
        }
        public void showFAQSection(string sectionPublishId, System.Collections.Generic.Dictionary<string, object> configMap)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.currentActivity;
            typeof(System.Object[]).__il2cppRuntimeField_14 = sectionPublishId;
            string val_1 = this.serializeApiConfig(configMap:  configMap);
            typeof(System.Object[]).__il2cppRuntimeField_18 = this;
            this.hsHelpshiftClass.CallStatic(methodName:  504273360, args:  472754880);
        }
        public void showSingleFAQ(string questionPublishId, System.Collections.Generic.Dictionary<string, object> configMap)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.currentActivity;
            typeof(System.Object[]).__il2cppRuntimeField_14 = questionPublishId;
            string val_1 = this.serializeApiConfig(configMap:  configMap);
            typeof(System.Object[]).__il2cppRuntimeField_18 = this;
            this.hsHelpshiftClass.CallStatic(methodName:  504418240, args:  472754880);
        }
        public void showFAQs(System.Collections.Generic.Dictionary<string, object> configMap)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.currentActivity;
            string val_1 = this.serializeApiConfig(configMap:  configMap);
            typeof(System.Object[]).__il2cppRuntimeField_14 = this;
            this.hsHelpshiftClass.CallStatic(methodName:  504559024, args:  472754880);
        }
        public void updateMetaData(System.Collections.Generic.Dictionary<string, object> metaData)
        {
            string val_1 = Json.Serializer.Serialize(obj:  metaData);
            typeof(System.Object[]).__il2cppRuntimeField_10 = metaData;
            this.hsHelpshiftClass.CallStatic(methodName:  504691600, args:  472754880);
        }
        private System.Collections.Generic.Dictionary<string, object> cleanConfig(System.Collections.Generic.Dictionary<string, object> configMap)
        {
            if((configMap.ContainsKey(key:  504815984)) == false)
            {
                    return;
            }
            
            object val_2 = configMap.Item[504815984];
            if(configMap != 0)
            {
                    configMap.set_Item(key:  504816096, value:  configMap);
            }
            else
            {
                    configMap.set_Item(key:  504816096, value:  configMap);
            }
            
            bool val_3 = configMap.Remove(key:  504815984);
        }
        public void handlePushNotification(System.Collections.Generic.Dictionary<string, object> pushNotificationData)
        {
            string val_1 = pushNotificationData.ToString();
            string val_2 = 504936400 + pushNotificationData;
            Helpshift.HelpshiftInternalLogger.d(message:  504936400);
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.currentActivity;
            string val_3 = Json.Serializer.Serialize(obj:  pushNotificationData);
            typeof(System.Object[]).__il2cppRuntimeField_14 = pushNotificationData;
            this.hsHelpshiftClass.CallStatic(methodName:  504944736, args:  472754880);
        }
        public void showAlertToRateAppWithURL(string url)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = url;
            this.hsHelpshiftClass.CallStatic(methodName:  505077312, args:  472754880);
        }
        public void registerDelegates()
        {
            var val_1;
            Helpshift.HelpshiftInternalLogger.d(message:  505197616);
            val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            this.hsHelpshiftClass.CallStatic(methodName:  505201824, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public void setSDKLanguage(string locale)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = locale;
            this.hsHelpshiftClass.CallStatic(methodName:  505326224, args:  472754880);
        }
        public void setTheme(string themeResourceName)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = themeResourceName;
            this.hsHelpshiftClass.CallStatic(methodName:  505454704, args:  472754880);
        }
        public void showDynamicForm(string title, System.Collections.Generic.Dictionary<string, object>[] flows)
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = this.currentActivity;
            typeof(System.Object[]).__il2cppRuntimeField_14 = title;
            string val_1 = Json.Serializer.Serialize(obj:  flows);
            typeof(System.Object[]).__il2cppRuntimeField_18 = flows;
            this.hsHelpshiftClass.CallStatic(methodName:  505624144, args:  472754880);
        }
        public void checkIfConversationActive()
        {
            var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            this.hsHelpshiftClass.CallStatic(methodName:  505789520, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public void onApplicationQuit()
        {
            Helpshift.HelpshiftInternalLogger.d(message:  505905744);
        }
        private string jsonifyHelpshiftUser(Helpshift.HelpshiftUser helpshiftUser)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1785499968, value:  helpshiftUser.identifier);
            Add(key:  -1931027184, value:  helpshiftUser.email);
            Add(key:  1679334848, value:  helpshiftUser.name);
            Add(key:  506038336, value:  helpshiftUser.authToken);
            return Json.Serializer.Serialize(obj:  78753792);
        }
    
    }

}
