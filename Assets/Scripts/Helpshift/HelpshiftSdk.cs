using UnityEngine;

namespace Helpshift
{
    public class HelpshiftSdk
    {
        // Fields
        public const string HS_RATE_ALERT_CLOSE = "HS_RATE_ALERT_CLOSE";
        public const string HS_RATE_ALERT_FEEDBACK = "HS_RATE_ALERT_FEEDBACK";
        public const string HS_RATE_ALERT_SUCCESS = "HS_RATE_ALERT_SUCCESS";
        public const string HS_RATE_ALERT_FAIL = "HS_RATE_ALERT_FAIL";
        public const string HSTAGSKEY = "hs-tags";
        public const string HSCUSTOMMETADATAKEY = "hs-custom-metadata";
        public const string UNITY_GAME_OBJECT = "unityGameObject";
        public const string ENABLE_IN_APP_NOTIFICATION = "enableInAppNotification";
        public const string ENABLE_DEFAULT_FALLBACK_LANGUAGE = "enableDefaultFallbackLanguage";
        public const string ENABLE_LOGGING = "enableLogging";
        public const string ENABLE_INBOX_POLLING = "enableInboxPolling";
        public const string ENABLE_AUTOMATIC_THEME_SWITCHING = "enableAutomaticThemeSwitching";
        public const string DISABLE_ENTRY_EXIT_ANIMATIONS = "disableEntryExitAnimations";
        public const string DISABLE_ERROR_REPORTING = "disableErrorReporting";
        public const string HSCUSTOMISSUEFIELDKEY = "hs-custom-issue-field";
        public const string HSTAGSMATCHINGKEY = "withTagsMatching";
        public const string CONTACT_US_ALWAYS = "always";
        public const string CONTACT_US_NEVER = "never";
        public const string CONTACT_US_AFTER_VIEWING_FAQS = "after_viewing_faqs";
        public const string CONTACT_US_AFTER_MARKING_ANSWER_UNHELPFUL = "after_marking_answer_unhelpful";
        public const string HSUserAcceptedTheSolution = "User accepted the solution";
        public const string HSUserRejectedTheSolution = "User rejected the solution";
        public const string HSUserSentScreenShot = "User sent a screenshot";
        public const string HSUserReviewedTheApp = "User reviewed the app";
        public const string HsFlowTypeDefault = "defaultFlow";
        public const string HsFlowTypeConversation = "conversationFlow";
        public const string HsFlowTypeFaqs = "faqsFlow";
        public const string HsFlowTypeFaqSection = "faqSectionFlow";
        public const string HsFlowTypeSingleFaq = "singleFaqFlow";
        public const string HsFlowTypeNested = "dynamicFormFlow";
        public const string HsCustomContactUsFlows = "customContactUsFlows";
        public const string HsFlowType = "type";
        public const string HsFlowConfig = "config";
        public const string HsFlowData = "data";
        public const string HsFlowTitle = "title";
        private static Helpshift.HelpshiftSdk instance;
        private static Helpshift.HelpshiftAndroid nativeSdk;
        
        // Methods
        private HelpshiftSdk()
        {
        
        }
        public static Helpshift.HelpshiftSdk getInstance()
        {
            object val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(Helpshift.HelpshiftSdk.instance == 0)
            {
                    val_3 = new System.Object();
                val_4 = null;
                val_4 = null;
                Helpshift.HelpshiftSdk.instance = val_3;
                val_3 = null;
                Helpshift.HelpshiftSdk.nativeSdk = new Helpshift.HelpshiftAndroid();
            }
            
            val_3 = null;
        }
        public void install(string apiKey, string domainName, string appId, System.Collections.Generic.Dictionary<string, object> config)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3;
            var val_4;
            var val_5;
            val_3 = config;
            val_4 = 0;
            if(val_3 == 0)
            {
                    val_3 = null;
                val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                if(val_3 == 0)
            {
                    val_3 = 0;
                val_4 = 1;
            }
            
            }
            
            val_3.Add(key:  507277344, value:  1139625344);
            val_3.Add(key:  507277440, value:  -800140768);
            string val_2 = UnityEngine.Application.unityVersion;
            val_3.Add(key:  507277536, value:  0);
            val_5 = null;
            val_5 = null;
            Helpshift.HelpshiftSdk.nativeSdk.install(apiKey:  apiKey, domain:  domainName, appId:  appId, configMap:  val_3);
        }
        public void requestUnreadMessagesCount(bool isAsync)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.requestUnreadMessagesCount(isAsync:  isAsync);
        }
        public void setNameAndEmail(string userName, string email)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.setNameAndEmail(userName:  userName, email:  email);
        }
        public void setUserIdentifier(string identifier)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.setUserIdentifier(identifier:  identifier);
        }
        public void login(string identifier, string name, string email)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.login(identifier:  identifier, userName:  name, email:  email);
        }
        public void login(Helpshift.HelpshiftUser helpshiftUser)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.login(helpshiftUser:  helpshiftUser);
        }
        public void clearAnonymousUser()
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.clearAnonymousUser();
        }
        public void logout()
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.logout();
        }
        public void registerDeviceToken(string deviceToken)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.registerDeviceToken(deviceToken:  deviceToken);
        }
        public void leaveBreadCrumb(string breadCrumb)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.leaveBreadCrumb(breadCrumb:  breadCrumb);
        }
        public void clearBreadCrumbs()
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.clearBreadCrumbs();
        }
        public void showConversation(System.Collections.Generic.Dictionary<string, object> configMap)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.showConversation(configMap:  configMap);
        }
        public void showFAQSection(string sectionPublishId, System.Collections.Generic.Dictionary<string, object> configMap)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.showFAQSection(sectionPublishId:  sectionPublishId, configMap:  configMap);
        }
        public void showSingleFAQ(string questionPublishId, System.Collections.Generic.Dictionary<string, object> configMap)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.showSingleFAQ(questionPublishId:  questionPublishId, configMap:  configMap);
        }
        public void showFAQs(System.Collections.Generic.Dictionary<string, object> configMap)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.showFAQs(configMap:  configMap);
        }
        public void updateMetaData(System.Collections.Generic.Dictionary<string, object> metaData)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.updateMetaData(metaData:  metaData);
        }
        public void handlePushNotification(System.Collections.Generic.Dictionary<string, object> pushNotificationData)
        {
            var val_5;
            string val_8;
            var val_10;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            label_5:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(val_5 != 0)
            {
                goto label_5;
            }
            
            Add(item:  0);
            goto label_5;
            label_2:
            0.Dispose();
            List.Enumerator<T> val_6 = GetEnumerator();
            label_9:
            if(MoveNext() == false)
            {
                goto label_7;
            }
            
            bool val_9 = pushNotificationData.Remove(key:  val_8);
            goto label_9;
            label_7:
            Dispose();
            val_10 = null;
            val_10 = null;
            Helpshift.HelpshiftSdk.nativeSdk.handlePushNotification(pushNotificationData:  pushNotificationData);
        }
        public void showAlertToRateAppWithURL(string url)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.showAlertToRateAppWithURL(url:  url);
        }
        public void setSDKLanguage(string locale)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.setSDKLanguage(locale:  locale);
        }
        public void setTheme(string themeName)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.setTheme(themeResourceName:  themeName);
        }
        public void registerDelegates()
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.registerDelegates();
        }
        public void showDynamicForm(string title, System.Collections.Generic.Dictionary<string, object>[] flows)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.showDynamicForm(title:  title, flows:  flows);
        }
        public void showDynamicForm(string title, System.Collections.Generic.Dictionary<string, object>[] flows, System.Collections.Generic.Dictionary<string, object> configMap)
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.showDynamicForm(title:  title, flows:  flows);
        }
        public void onApplicationQuit()
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.onApplicationQuit();
        }
        public void checkIfConversationActive()
        {
            null = null;
            Helpshift.HelpshiftSdk.nativeSdk.checkIfConversationActive();
        }
        private static HelpshiftSdk()
        {
        
        }
    
    }

}
