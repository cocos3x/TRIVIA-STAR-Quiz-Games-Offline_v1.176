using UnityEngine;
public class WGSettingsMiniPopup : MonoBehaviour
{
    // Fields
    private UGUINetworkedButton Button_FbConnect;
    private UGUINetworkedButton Button_FbShare;
    private UGUINetworkedButton Button_AppleConnect;
    private UnityEngine.GameObject FbConnectRewardGroup;
    private UnityEngine.UI.Text FbConnectRewardAmount;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private UnityEngine.UI.VerticalLayoutGroup buttons_v;
    private float verticalSpacing;
    private UnityEngine.UI.Button languageButton;
    private UGUINetworkedButton restoreTransactionsButton;
    protected UnityEngine.Transform transform_button_toggles_parent;
    private bool isFbCherry;
    private bool pnEnabled;
    private const float DEFAULT_BUTTON_SPACING = 0;
    
    // Methods
    private void Awake()
    {
        var val_22;
        float val_23;
        string val_24;
        System.Delegate val_25;
        UGUINetworkedButton val_26;
        float val_27;
        var val_28;
        var val_29;
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  50135088, method:  new IntPtr(50058736));
        this.Button_FbConnect.OnConnectionClick = null;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  50135088, method:  new IntPtr(50063856));
        this.Button_FbShare.OnConnectionClick = null;
        if((UnityEngine.Object.op_Implicit(exists:  this.Button_AppleConnect)) != false)
        {
                System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  50135088, method:  new IntPtr(50073072));
            this.Button_AppleConnect.OnConnectionClick = null;
        }
        
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  50135088, name:  -2005054624);
        GameBehavior val_6 = App.getBehavior;
        if((0 != 0) && (this.languageButton != 0))
        {
                UnityEngine.GameObject val_8 = this.languageButton.gameObject;
            this.languageButton.SetActive(value:  true);
            UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  50135088, method:  new IntPtr(50090480));
            this.languageButton.m_OnClick.AddListener(call:  162246656);
        }
        else
        {
                if(this.languageButton != 0)
        {
                UnityEngine.GameObject val_11 = this.languageButton.gameObject;
            this.languageButton.SetActive(value:  false);
        }
        
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = 1152921504898433024;
        PostProcessPurchaseDelegate val_12 = new PostProcessPurchaseDelegate(object:  50135088, method:  new IntPtr(50099696));
        System.Delegate val_13 = System.Delegate.Combine(a:  PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS, b:  291586048);
        val_24 = 0;
        if(PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS != null)
        {
                if(null != null)
        {
                val_24 = 0;
        }
        else
        {
                val_24 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        }
        
        }
        
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_24;
        System.Action<twelvegigs.storage.JsonDictionary> val_14 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  50135088, method:  new IntPtr(50100720));
        val_25 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_15 = System.Delegate.Combine(a:  val_25, b:  7401472);
        val_26 = 1152921504765685760;
        if(val_25 == 0)
        {
            goto label_33;
        }
        
        val_27 = 1152921504614248448;
        val_28 = 1152921504892043264;
        val_29 = 1152921504866058240;
        if(null == null)
        {
            goto label_35;
        }
        
        val_25 = 0;
        goto label_35;
        label_33:
        val_25 = 0;
        val_27 = 1152921504614248448;
        val_28 = 1152921504892043264;
        val_29 = 1152921504866058240;
        label_35:
        PurchasesHandler.OnPurchaseCompleted = val_25;
        NotificationCenter val_16 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  50135088, name:  50101744);
        if((UnityEngine.Object.op_Implicit(exists:  this.restoreTransactionsButton)) != false)
        {
                val_26 = this.restoreTransactionsButton;
            val_27 = new System.Action<System.Boolean>(object:  50135088, method:  new IntPtr(50110064));
            this.restoreTransactionsButton.OnConnectionClick = val_27;
        }
        
        GameBehavior val_19 = App.getBehavior;
        if(0 != 0)
        {
            
        }
        else
        {
                var val_20 = FP - 28;
        }
    
    }
    protected virtual void LoadToggleButtons()
    {
        UnityEngine.Transform val_10;
        UnityEngine.GameObject val_1 = PrefabLoader.LoadPrefab(featureName:  50272352, prefabName:  50272240);
        if(50272352 != 0)
        {
                val_10 = this.transform_button_toggles_parent;
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  50272352, parent:  val_10);
        }
        
        UnityEngine.GameObject val_4 = PrefabLoader.LoadPrefab(featureName:  50272352, prefabName:  50276544);
        if(50272352 != 0)
        {
                val_10 = this.transform_button_toggles_parent;
            object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  50272352, parent:  val_10);
        }
        
        UnityEngine.GameObject val_7 = PrefabLoader.LoadPrefab(featureName:  50272352, prefabName:  50280752);
        if(50272352 == 0)
        {
                return;
        }
        
        object val_9 = UnityEngine.Object.Instantiate<System.Object>(original:  50272352, parent:  this.transform_button_toggles_parent);
    }
    private void OnProcessPurchase(ref PurchaseModel purchase)
    {
    
    }
    private void OnPurchaseCompleted(PurchaseModel obj)
    {
        if((obj.id.Contains(value:  -1825930800)) == false)
        {
                return;
        }
        
        Player val_2 = App.Player;
        0.RemovedAds = true;
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        this.OnRestoreTransactionsSuccess();
    }
    private void OnEnable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.restoreTransactionsButton)) != false)
        {
                UnityEngine.GameObject val_2 = this.restoreTransactionsButton.gameObject;
            this.restoreTransactionsButton.SetActive(value:  false);
        }
        
        this.SetFacebookButtons();
        System.Collections.IEnumerator val_3 = this.UpdateLayout();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  50689872);
        this.pnEnabled = twelvegigs.plugins.LocalNotificationsPlugin.IsNotificationEnabled();
        this.AdjustButtonsSpacing();
    }
    private void AdjustButtonsSpacing()
    {
        if(this.buttons_v == 0)
        {
                return;
        }
        
        object val_2 = this.buttons_v.GetComponent<System.Object>();
        this.buttons_v.spacing = null;
    }
    public void SetFacebookButtons()
    {
        bool val_22;
        bool val_23;
        var val_24;
        UnityEngine.GameObject val_1 = this.Button_FbConnect.gameObject;
        this.Button_FbConnect.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.Button_FbShare.gameObject;
        this.Button_FbShare.SetActive(value:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this.Button_AppleConnect)) != false)
        {
                UnityEngine.GameObject val_4 = this.Button_AppleConnect.gameObject;
            this.Button_AppleConnect.SetActive(value:  false);
        }
        
        Player val_5 = App.Player;
        this.isFbCherry = System.String.IsNullOrEmpty(value:  static_value_0028001C);
        GameBehavior val_7 = App.getBehavior;
        val_22 = 0;
        if(0 != 0)
        {
                val_22 = FacebookPlugin.TaskAvailable(taskToCheck:  1);
        }
        
        GameBehavior val_9 = App.getBehavior;
        val_23 = 0;
        if(0 != 0)
        {
                val_23 = FacebookPlugin.IsLoggedIn;
        }
        
        val_24 = 0;
        UnityEngine.GameObject val_11 = this.Button_FbConnect.gameObject;
        this.Button_FbConnect.SetActive(value:  val_22);
        if(val_22 != false)
        {
                if(this.isFbCherry == true)
        {
                val_24 = 1;
        }
        
        }
        
        this.FbConnectRewardGroup.SetActive(value:  true);
        GameEcon val_12 = App.getGameEcon;
        var val_22 = 0;
        val_22 = val_22 + 360;
        GameEcon val_13 = App.getGameEcon;
        string val_14 = val_22.ToString(format:  null);
        UnityEngine.GameObject val_15 = this.Button_FbShare.gameObject;
        this.Button_FbShare.SetActive(value:  val_23);
        UnityEngine.GameObject val_16 = this.Button_FbConnect.gameObject;
        if(this.Button_FbConnect.activeSelf == true)
        {
                return;
        }
        
        UnityEngine.GameObject val_18 = this.Button_FbShare.gameObject;
        if(this.Button_FbShare.activeSelf != false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_20 = this.UpdateLayout();
        UnityEngine.Coroutine val_21 = this.StartCoroutine(routine:  50979408);
    }
    private void OnFacebookPluginUpdate(Notification notification)
    {
        int val_8;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_8;
        GridCoinCollectAnimationInstantiator val_9;
        int val_10;
        int val_11;
        int val_12;
        int val_13;
        int val_14;
        if((this.isFbCherry != false) && (FacebookPlugin.IsLoggedIn != false))
        {
                this.isFbCherry = false;
            val_8 = 0;
            GameEcon val_2 = App.getGameEcon;
            var val_3 = 0 + 360;
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = mem[(0 + 360) + (0)], hi = mem[(0 + 360) + (4)], lo = mem[(0 + 360) + (8)], mid = mem[(0 + 360) + (12)]}, source:  "FB Connect Bonus", externalParams:  val_8, animated:  false);
            if(this.coinsAnim != 0)
        {
                Player val_5 = App.Player;
            var val_9 = 0;
            val_9 = val_9 + 64;
            val_14 = mem[(0 + 64) + (4)];
            val_13 = mem[(0 + 64) + (0)];
            decimal val_6 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 51132716, hi = 52, lo = val_13, mid = val_14}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)], hi = mem[(0 + 360) + (0)], lo = mem[(0 + 360) + (4)], mid = mem[(0 + 360) + (8)]});
            Player val_7 = App.Player;
            val_8 = 7.286752E-44f;
            val_9 = this.coinsAnim;
            val_9.Play(fromValue:  new System.Decimal() {mid = val_8}, toValue:  new System.Decimal() {flags = 52, hi = val_10, lo = val_11, mid = val_12}, textTickTime:  null, delayBeforeComplete:  null);
        }
        
        }
        
        this.SetFacebookButtons();
    }
    private System.Collections.IEnumerator UpdateLayout()
    {
        object val_1 = new System.Object();
        typeof(WGSettingsMiniPopup.<UpdateLayout>d__22).__il2cppRuntimeField_8 = 0;
        typeof(WGSettingsMiniPopup.<UpdateLayout>d__22).__il2cppRuntimeField_10 = this;
    }
    private void OnClick_FbConnect(bool result)
    {
        var val_12;
        System.Func<System.Boolean> val_14;
        var val_15;
        var val_17;
        System.Action val_19;
        if(result != false)
        {
                if(this.isFbCherry == true)
        {
                this.isFbCherry = 1;
        }
        
            this.FbConnectRewardGroup.SetActive(value:  true);
            if((FacebookPlugin.TaskAvailable(taskToCheck:  1)) == false)
        {
                return;
        }
        
            TrackingComponent.CurrentIntent = 4;
            FacebookPlugin.PerformTask(task:  1);
            return;
        }
        
        object val_2 = this.GetComponent<System.Object>();
        this.Button_AppleConnect = 0;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_12 = null;
        val_12 = null;
        val_14 = WGSettingsMiniPopup.<>c.<>9__23_0;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<System.Boolean>(object:  WGSettingsMiniPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(51361152));
            WGSettingsMiniPopup.<>c.<>9__23_0 = val_14;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_14;
        val_15 = null;
        val_15 = null;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        }
        else
        {
                SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        }
        
        object val_9 = GetComponent<System.Object>();
        val_17 = null;
        val_17 = null;
        val_19 = WGSettingsMiniPopup.<>c.<>9__23_1;
        if(val_19 == 0)
        {
                val_19 = null;
            val_19 = new System.Action(object:  WGSettingsMiniPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(51362176));
            WGSettingsMiniPopup.<>c.<>9__23_1 = val_19;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_19;
        UnityEngine.GameObject val_11 = this.gameObject;
        SLCWindow.CloseWindow(window:  51387200, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_FbShare(bool result)
    {
        var val_12;
        System.Func<System.Boolean> val_14;
        var val_15;
        var val_17;
        System.Action val_19;
        if(result != false)
        {
                WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            ShareDefault();
            return;
        }
        
        object val_2 = this.GetComponent<System.Object>();
        this.Button_AppleConnect = 0;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_12 = null;
        val_12 = null;
        val_14 = WGSettingsMiniPopup.<>c.<>9__24_0;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<System.Boolean>(object:  WGSettingsMiniPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(51479296));
            WGSettingsMiniPopup.<>c.<>9__24_0 = val_14;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_14;
        val_15 = null;
        val_15 = null;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        }
        else
        {
                SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        }
        
        object val_9 = GetComponent<System.Object>();
        val_17 = null;
        val_17 = null;
        val_19 = WGSettingsMiniPopup.<>c.<>9__24_1;
        if(val_19 == 0)
        {
                val_19 = null;
            val_19 = new System.Action(object:  WGSettingsMiniPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(51480320));
            WGSettingsMiniPopup.<>c.<>9__24_1 = val_19;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_19;
        UnityEngine.GameObject val_11 = this.gameObject;
        SLCWindow.CloseWindow(window:  51505344, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_AppleConnect(bool result)
    {
        if(result == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        LogIn();
    }
    private void OnClick_Languages()
    {
        object val_1 = new System.Object();
        object val_2 = this.GetComponent<System.Object>();
        System.Action val_3 = new System.Action(object:  this.Button_AppleConnect, method:  new IntPtr(2791752480));
        typeof(WGSettingsMiniPopup.<>c__DisplayClass26_0).__il2cppRuntimeField_8 = null;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_6 = GetComponent<System.Object>();
        System.Action val_7 = new System.Action(object:  393449472, method:  new IntPtr(51709440));
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = null;
        object val_8 = this.GetComponent<System.Object>();
        this.Button_AppleConnect = 0;
        UnityEngine.GameObject val_9 = this.gameObject;
        SLCWindow.CloseWindow(window:  51734464, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_RetoreTransaction(bool result)
    {
        var val_1;
        UnityEngine.Debug.LogError(message:  51826560);
        var val_1 = 28602457;
        val_1 = 7023600 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        App.inAppPurchasesManager.RestorePreviousPurchases();
    }
    private void OnRestoreTransactionsSuccess()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                Player val_2 = App.Player;
            0.RemovedAds = true;
        }
        
        Player val_3 = App.Player;
        0.RestoredTransactions = true;
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
        UnityEngine.GameObject val_5 = this.restoreTransactionsButton.gameObject;
        this.restoreTransactionsButton.SetActive(value:  false);
        this.AdjustButtonsSpacing();
        UnityEngine.GameObject val_6 = this.gameObject;
        SLCWindow.CloseWindow(window:  51966784, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnDisable()
    {
        var val_7;
        string val_8;
        System.Delegate val_9;
        val_7 = null;
        val_7 = null;
        PostProcessPurchaseDelegate val_1 = new PostProcessPurchaseDelegate(object:  52082880, method:  new IntPtr(50099696));
        System.Delegate val_2 = System.Delegate.Remove(source:  PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS, value:  291586048);
        val_8 = 0;
        if(PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS != null)
        {
                if(null != null)
        {
                val_8 = 0;
        }
        else
        {
                val_8 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        }
        
        }
        
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_8;
        System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  52082880, method:  new IntPtr(50100720));
        val_9 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_4 = System.Delegate.Remove(source:  val_9, value:  7401472);
        if(val_9 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_9 = 0;
        label_7:
        PurchasesHandler.OnPurchaseCompleted = val_9;
        if(this.pnEnabled == true)
        {
                this.pnEnabled = 1;
        }
        
        bool val_5 = twelvegigs.plugins.LocalNotificationsPlugin.IsNotificationEnabled();
        val_5 = 1 ^ val_5;
        if(val_5 != true)
        {
                return;
        }
        
        WGBonusRewardsHandler val_6 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  52194880, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGSettingsMiniPopup()
    {
        this.verticalSpacing = 20f;
    }

}
