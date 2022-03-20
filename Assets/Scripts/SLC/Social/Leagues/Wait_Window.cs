using UnityEngine;

namespace SLC.Social.Leagues
{
    public class Wait_Window : WGMessagePopup
    {
        // Fields
        private SLC.Social.Leagues.LeaguesNotifyType waitForNotificationtype;
        
        // Methods
        protected void Start()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  893181808, name:  442544128);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  893181808, name:  442544128);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  893181808, name:  442544128);
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  893181808, name:  442544128);
            NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  893181808, name:  824288032);
        }
        public void ShowError(string message, string title, SLC.Social.Leagues.LeaguesNotifyType notificationType = 8)
        {
            var val_1;
            typeof(System.String[]).__il2cppRuntimeField_10 = "";
            typeof(System.String[]).__il2cppRuntimeField_14 = "";
            val_1 = null;
            val_1 = null;
            this.SetupMessage(titleTxt:  title, messageTxt:  message, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
            this.waitForNotificationtype = notificationType;
        }
        private void HideAndReset()
        {
            this.waitForNotificationtype = 8;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  893430384, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void DisplayLeaguesErrorPopup()
        {
            this.waitForNotificationtype = 8;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  893542384, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnDataUpdate()
        {
            if(this.waitForNotificationtype != 0)
            {
                    return;
            }
            
            this.waitForNotificationtype = 8;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  893658480, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnGuildMembersUpdate()
        {
            if(this.waitForNotificationtype != 3)
            {
                    return;
            }
            
            this.waitForNotificationtype = 8;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  893778672, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnMyGuildUpdate()
        {
            if(this.waitForNotificationtype != 2)
            {
                    return;
            }
            
            this.waitForNotificationtype = 8;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  893898864, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnMyProfileUpdate()
        {
            if(this.waitForNotificationtype != 1)
            {
                    return;
            }
            
            this.waitForNotificationtype = 8;
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  894019056, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public Wait_Window()
        {
            this.waitForNotificationtype = 8;
        }
    
    }

}
