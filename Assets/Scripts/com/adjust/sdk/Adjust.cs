using UnityEngine;

namespace com.adjust.sdk
{
    public class Adjust : MonoBehaviour
    {
        // Fields
        private const string errorMsgEditor = "[Adjust]: SDK can not be used in Editor.";
        private const string errorMsgStart = "[Adjust]: SDK not started. Start it manually using the \'start\' method.";
        private const string errorMsgPlatform = "[Adjust]: SDK can only be used in Android, iOS, Windows Phone 8.1, Windows Store or Universal Windows apps.";
        public bool startManually;
        public bool eventBuffering;
        public bool sendInBackground;
        public bool launchDeferredDeeplink;
        public string appToken;
        public com.adjust.sdk.AdjustLogLevel logLevel;
        public com.adjust.sdk.AdjustEnvironment environment;
        
        // Methods
        private void Awake()
        {
            var val_6;
            bool val_7;
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  1365940128);
            if(this.startManually != false)
            {
                    return;
            }
            
            com.adjust.sdk.AdjustConfig val_5 = new com.adjust.sdk.AdjustConfig(appToken:  this.appToken, environment:  this.environment, allowSuppressLogLevel:  (this.logLevel - 7) >> 5);
            setLogLevel(logLevel:  this.logLevel);
            if(this.sendInBackground == true)
            {
                    this.sendInBackground = 1;
            }
            
            setSendInBackground(sendInBackground:  true);
            if(null != 0)
            {
                    if(this.eventBuffering == true)
            {
                    val_6 = 1;
            }
            
                setEventBufferingEnabled(eventBufferingEnabled:  true);
                val_7 = this.launchDeferredDeeplink;
            }
            else
            {
                    if(this.eventBuffering == true)
            {
                    val_6 = 1;
            }
            
                setEventBufferingEnabled(eventBufferingEnabled:  true);
                val_7 = this.launchDeferredDeeplink;
            }
            
            typeof(com.adjust.sdk.AdjustConfig).__il2cppRuntimeField_8A = val_7;
            com.adjust.sdk.Adjust.start(adjustConfig:  471031808);
        }
        private void OnApplicationPause(bool pauseStatus)
        {
            if(pauseStatus != false)
            {
                    com.adjust.sdk.AdjustAndroid.OnPause();
                return;
            }
            
            com.adjust.sdk.AdjustAndroid.OnResume();
        }
        public static void start(com.adjust.sdk.AdjustConfig adjustConfig)
        {
            if(adjustConfig != 0)
            {
                    com.adjust.sdk.AdjustAndroid.Start(adjustConfig:  adjustConfig);
                return;
            }
            
            UnityEngine.Debug.Log(message:  1366160608);
        }
        public static void trackEvent(com.adjust.sdk.AdjustEvent adjustEvent)
        {
            if(adjustEvent != 0)
            {
                    com.adjust.sdk.AdjustAndroid.TrackEvent(adjustEvent:  adjustEvent);
                return;
            }
            
            UnityEngine.Debug.Log(message:  1366280944);
        }
        public static void setEnabled(bool enabled)
        {
            com.adjust.sdk.AdjustAndroid.SetEnabled(enabled:  enabled);
        }
        public static bool isEnabled()
        {
            return com.adjust.sdk.AdjustAndroid.IsEnabled();
        }
        public static void setOfflineMode(bool enabled)
        {
            com.adjust.sdk.AdjustAndroid.SetOfflineMode(enabled:  enabled);
        }
        public static void setDeviceToken(string deviceToken)
        {
            com.adjust.sdk.AdjustAndroid.SetDeviceToken(deviceToken:  deviceToken);
        }
        public static void gdprForgetMe()
        {
            com.adjust.sdk.AdjustAndroid.GdprForgetMe();
        }
        public static void disableThirdPartySharing()
        {
            com.adjust.sdk.AdjustAndroid.DisableThirdPartySharing();
        }
        public static void appWillOpenUrl(string url)
        {
            com.adjust.sdk.AdjustAndroid.AppWillOpenUrl(url:  url);
        }
        public static void sendFirstPackages()
        {
            com.adjust.sdk.AdjustAndroid.SendFirstPackages();
        }
        public static void addSessionPartnerParameter(string key, string value)
        {
            com.adjust.sdk.AdjustAndroid.AddSessionPartnerParameter(key:  key, value:  value);
        }
        public static void addSessionCallbackParameter(string key, string value)
        {
            com.adjust.sdk.AdjustAndroid.AddSessionCallbackParameter(key:  key, value:  value);
        }
        public static void removeSessionPartnerParameter(string key)
        {
            com.adjust.sdk.AdjustAndroid.RemoveSessionPartnerParameter(key:  key);
        }
        public static void removeSessionCallbackParameter(string key)
        {
            com.adjust.sdk.AdjustAndroid.RemoveSessionCallbackParameter(key:  key);
        }
        public static void resetSessionPartnerParameters()
        {
            com.adjust.sdk.AdjustAndroid.ResetSessionPartnerParameters();
        }
        public static void resetSessionCallbackParameters()
        {
            com.adjust.sdk.AdjustAndroid.ResetSessionCallbackParameters();
        }
        public static void trackAdRevenue(string source, string payload)
        {
            com.adjust.sdk.AdjustAndroid.TrackAdRevenue(source:  source, payload:  payload);
        }
        public static void trackAppStoreSubscription(com.adjust.sdk.AdjustAppStoreSubscription subscription)
        {
            UnityEngine.Debug.Log(message:  1368163200);
        }
        public static void trackPlayStoreSubscription(com.adjust.sdk.AdjustPlayStoreSubscription subscription)
        {
            com.adjust.sdk.AdjustAndroid.TrackPlayStoreSubscription(subscription:  subscription);
        }
        public static void trackThirdPartySharing(com.adjust.sdk.AdjustThirdPartySharing thirdPartySharing)
        {
            com.adjust.sdk.AdjustAndroid.TrackThirdPartySharing(thirdPartySharing:  thirdPartySharing);
        }
        public static void trackMeasurementConsent(bool measurementConsent)
        {
            com.adjust.sdk.AdjustAndroid.TrackMeasurementConsent(measurementConsent:  measurementConsent);
        }
        public static void requestTrackingAuthorizationWithCompletionHandler(System.Action<int> statusCallback, string sceneName = "Adjust")
        {
            UnityEngine.Debug.Log(message:  1368640096);
        }
        public static void updateConversionValue(int conversionValue)
        {
            UnityEngine.Debug.Log(message:  1368760528);
        }
        public static int getAppTrackingAuthorizationStatus()
        {
            UnityEngine.Debug.Log(message:  1368872768);
            return 0;
        }
        public static string getAdid()
        {
            return com.adjust.sdk.AdjustAndroid.GetAdid();
        }
        public static com.adjust.sdk.AdjustAttribution getAttribution()
        {
            return com.adjust.sdk.AdjustAndroid.GetAttribution();
        }
        public static string getWinAdid()
        {
            UnityEngine.Debug.Log(message:  1369209008);
        }
        public static string getIdfa()
        {
            UnityEngine.Debug.Log(message:  1369321232);
        }
        public static string getSdkVersion()
        {
            return com.adjust.sdk.AdjustAndroid.GetSdkVersion();
        }
        public static void setReferrer(string referrer)
        {
            com.adjust.sdk.AdjustAndroid.SetReferrer(referrer:  referrer);
        }
        public static void getGoogleAdId(System.Action<string> onDeviceIdsRead)
        {
            com.adjust.sdk.AdjustAndroid.GetGoogleAdId(onDeviceIdsRead:  onDeviceIdsRead);
        }
        public static string getAmazonAdId()
        {
            return com.adjust.sdk.AdjustAndroid.GetAmazonAdId();
        }
        private static bool IsEditor()
        {
            return false;
        }
        public static void SetTestOptions(System.Collections.Generic.Dictionary<string, string> testOptions)
        {
            com.adjust.sdk.AdjustAndroid.SetTestOptions(testOptions:  testOptions);
        }
        public Adjust()
        {
            this.launchDeferredDeeplink = true;
            this.startManually = true;
            this.appToken = "{Your App Token}";
            this.logLevel = 3;
        }
    
    }

}
