using UnityEngine;
public class WGAdsControlPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject main_group;
    private UnityEngine.GameObject sorry_group;
    private UnityEngine.GameObject unavailable_group;
    private UnityEngine.GameObject noAdsGroup;
    protected UGUINetworkedButton purchaseButton;
    private UGUINetworkedButton watchButton;
    private UGUINetworkedButton watchAnotherButton;
    private UnityEngine.UI.Text noAdsButtonTextTop;
    private UnityEngine.UI.Text noAdsButtonPriceText;
    private UnityEngine.UI.Text xMonthNoAds;
    private UnityEngine.UI.Text xHoursNoAds;
    private UnityEngine.UI.Text watchButtonText;
    private UnityEngine.UI.Text watchButtonText2ndLine;
    private UnityEngine.UI.Text noAdsTimer;
    protected GridCoinCollectAnimationInstantiator coinsAnimControl;
    protected GemsCollectAnimationInstantiator gemAnimControl;
    protected CurrencyCollectAnimationInstantiator spinAnimControl;
    private FrameSkipper frameSkipper;
    private HeyZapAdTag initTag;
    protected PurchaseModel noAdsPackage;
    private TrackerPurchasePoints currentEntryPoint;
    public System.Action Action_OnClose;
    
    // Methods
    private void Awake()
    {
        var val_20;
        string val_21;
        System.Delegate val_22;
        var val_23;
        System.Action<twelvegigs.storage.JsonDictionary> val_24;
        System.Action<twelvegigs.storage.JsonDictionary> val_25;
        System.Delegate val_26;
        if((UnityEngine.Object.op_Implicit(exists:  this.coinsAnimControl)) != false)
        {
                System.Action val_2 = new System.Action(object:  -129636368, method:  new IntPtr(4165263920));
            this.coinsAnimControl.OnCompleteCallback = null;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.gemAnimControl)) != false)
        {
                System.Action val_4 = new System.Action(object:  -129636368, method:  new IntPtr(4165263920));
            mem2[0] = null;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.spinAnimControl)) != false)
        {
                System.Action val_6 = new System.Action(object:  -129636368, method:  new IntPtr(4165263920));
            this.spinAnimControl.OnCompleteCallback = null;
        }
        
        val_20 = null;
        val_20 = null;
        PostProcessPurchaseDelegate val_7 = new PostProcessPurchaseDelegate(object:  -129636368, method:  new IntPtr(4165281328));
        System.Delegate val_8 = System.Delegate.Combine(a:  PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS, b:  291586048);
        val_21 = 0;
        if(PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS != null)
        {
                if(null != null)
        {
                val_21 = 0;
        }
        else
        {
                val_21 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        }
        
        }
        
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_21;
        System.Action<twelvegigs.storage.JsonDictionary> val_9 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -129636368, method:  new IntPtr(4165282352));
        val_22 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_10 = System.Delegate.Combine(a:  val_22, b:  7401472);
        val_23 = null;
        val_24 = null;
        if(val_22 == 0)
        {
            goto label_18;
        }
        
        if(null == val_24)
        {
            goto label_19;
        }
        
        val_23 = 1152921504898486364;
        val_24 = null;
        label_18:
        val_22 = 0;
        label_19:
        PurchasesHandler.OnPurchaseCompleted = val_22;
        val_25 = val_24;
        val_25 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -129636368, method:  new IntPtr(4165283376));
        val_26 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_12 = System.Delegate.Combine(a:  val_26, b:  7401472);
        if(val_26 != 0)
        {
                if(null == null)
        {
            goto label_21;
        }
        
        }
        
        val_26 = 0;
        label_21:
        PurchasesHandler.OnPurchaseFailure = val_26;
        if((UnityEngine.Object.op_Implicit(exists:  this.watchButton)) != false)
        {
                val_25 = this.watchButton;
            System.Action<System.Boolean> val_14 = new System.Action<System.Boolean>(object:  -129636368, method:  new IntPtr(4165292592));
            this.watchButton.OnConnectionClick = null;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.watchAnotherButton)) != false)
        {
                val_25 = this.watchAnotherButton;
            System.Action<System.Boolean> val_16 = new System.Action<System.Boolean>(object:  -129636368, method:  new IntPtr(4165301808));
            this.watchAnotherButton.OnConnectionClick = null;
        }
        
        if(this.frameSkipper == 0)
        {
                UnityEngine.GameObject val_18 = this.gameObject;
            object val_19 = this.AddComponent<System.Object>();
            this.frameSkipper = this;
        }
        
        this.FetchNoAdsPackage();
    }
    private void OnPurchaseFailure(PurchaseModel obj)
    {
        bool val_1 = obj.id.Contains(value:  -1825930800);
    }
    private void OnPurchaseCompleted(PurchaseModel obj)
    {
        var val_5 = 35630367;
        if((obj.id.Contains(value:  -1825930800)) == false)
        {
                return;
        }
        
        Player val_2 = App.Player;
        0.RemovedAds = true;
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        goto typeof(WGAdsControlPopup).__il2cppRuntimeField_DC;
    }
    private void OnProcessPurchase(ref PurchaseModel purchase)
    {
    
    }
    private void OnEnable()
    {
        System.Action val_6;
        if(this.purchaseButton != 0)
        {
                System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -129075888, method:  new IntPtr(4165848976));
            this.purchaseButton.OnConnectionClick = null;
        }
        
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -129075888, name:  2128120864);
        this.ActivateMainGroup();
        this.watchButton.interactable = true;
        this.watchAnotherButton.interactable = true;
        this.UpdateUI();
        System.Action val_4 = new System.Action(object:  -129075888, method:  new IntPtr(4165866384));
        System.Delegate val_5 = System.Delegate.Combine(a:  this.frameSkipper.updateLogic, b:  7454720);
        val_6 = this.frameSkipper.updateLogic;
        if(val_6 != 0)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        val_6 = 0;
        label_13:
        this.frameSkipper.updateLogic = val_6;
        this.SetSubscriptionEntryPoint();
        this.SetPopupSeen();
    }
    public WGAdsControlPopup InitEntryTag(HeyZapAdTag tag)
    {
        this.initTag = tag;
        this.SetPurchaseEntryByInitTag();
    }
    public void OnVideoResponse(Notification notif)
    {
        string val_7;
        var val_8;
        var val_9;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_10;
        var val_11;
        val_7 = 35630369;
        string val_1 = notif.data.ToString();
        if((System.Boolean.Parse(value:  notif.data)) != false)
        {
                int val_3 = AdsManager.AdsWatched;
            val_3 = val_3 + 1;
            AdsManager.AdsWatched = val_3;
            if(AdsManager.AdsWatched == 0)
        {
                var val_7 = 27214107;
            val_7 = 8411680 + val_7;
            if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
            val_9 = null;
            val_9 = null;
            val_10 = 0;
            if(App.game == 20)
        {
                val_10 = null;
            val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_8 = "Ads Control Time";
            Add(key:  1297334992, value:  -128834928);
        }
        
            val_11 = null;
            val_11 = null;
            val_7 = "Ads Control Time From Ads";
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = System.Decimal.Zero}, source:  val_7, externalParams:  val_10, animated:  false);
        }
        
            this.ActivateMainGroup();
            this.UpdateUI();
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AdControlVideoWatched();
        }
        else
        {
                this.ActivateSorryGroup();
            this.watchAnotherButton.interactable = true;
        }
        
        this.watchButton.interactable = true;
    }
    public void DoOnCloseAction()
    {
        if(this.Action_OnClose == 0)
        {
                return;
        }
        
        this.Action_OnClose.Invoke();
    }
    protected void FetchNoAdsPackage()
    {
        var val_13;
        PurchaseModel val_14;
        PurchaseModel val_15;
        var val_16;
        System.Func<PurchaseModel, System.Boolean> val_18;
        var val_19;
        System.Func<PurchaseModel, System.Boolean> val_21;
        val_13 = 1152921504901201920;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<PurchaseModel> val_2 = RetrievePurchasePacks();
        val_14 = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance();
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            goto label_8;
        }
        
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_15 = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance();
        System.Collections.Generic.List<PurchaseModel> val_5 = RetrieveGemPurchasePacks();
        goto label_12;
        label_8:
        GameBehavior val_6 = App.getBehavior;
        if(0 == 0)
        {
            goto label_17;
        }
        
        WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_15 = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance();
        System.Collections.Generic.List<PurchaseModel> val_8 = RetrieveSpinPurchasePacks();
        label_12:
        val_14 = val_15;
        label_17:
        val_16 = null;
        val_16 = null;
        val_18 = WGAdsControlPopup.<>c.<>9__30_0;
        if(val_18 == 0)
        {
                val_18 = null;
            val_18 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGAdsControlPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4166389376));
            WGAdsControlPopup.<>c.<>9__30_0 = val_18;
        }
        
        object val_10 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -1261146960, predicate:  7720960);
        this.noAdsPackage = val_14;
        if(val_14 != 0)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  -128576896);
        val_19 = null;
        val_19 = null;
        val_21 = WGAdsControlPopup.<>c.<>9__30_1;
        if(val_21 == 0)
        {
                val_21 = null;
            val_21 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGAdsControlPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4166390624));
            WGAdsControlPopup.<>c.<>9__30_1 = val_21;
        }
        
        object val_12 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -1261146960, predicate:  7720960);
        this.noAdsPackage = val_14;
    }
    protected void SetPopupSeen()
    {
        if((CPlayerPrefs.GetInt(key:  -1055927136, defaultValue:  0)) != 0)
        {
                return;
        }
        
        CPlayerPrefs.SetInt(key:  R5, val:  1);
        CPlayerPrefs.Save();
    }
    private void SetPurchaseEntryByInitTag()
    {
        TrackerPurchasePoints val_1;
        if(this.initTag <= 2)
        {
            goto label_0;
        }
        
        if(this.initTag == 3)
        {
            goto label_1;
        }
        
        if(this.initTag == 30)
        {
            goto label_2;
        }
        
        if(this.initTag != 13)
        {
            goto label_6;
        }
        
        val_1 = 16;
        goto label_10;
        label_0:
        if(this.initTag == 1)
        {
            goto label_5;
        }
        
        if(this.initTag != 2)
        {
            goto label_6;
        }
        
        val_1 = 15;
        goto label_10;
        label_1:
        val_1 = 18;
        goto label_10;
        label_2:
        val_1 = 90;
        goto label_10;
        label_5:
        val_1 = 17;
        goto label_10;
        label_6:
        val_1 = 0;
        label_10:
        this.currentEntryPoint = val_1;
    }
    private void UpdateUI()
    {
        float val_41;
        var val_42;
        UnityEngine.UI.Text val_43;
        var val_44;
        PurchaseModel val_45;
        var val_46;
        var val_47;
        UnityEngine.UI.Text val_48;
        string val_1 = Localization.Localize(key:  -128231456, defaultValue:  -128231344, useSingularKey:  false);
        val_41 = 1152921504895397888;
        val_42 = 1152921504892043264;
        GameEcon val_3 = App.getGameEcon;
        string val_4 = AdsManager.CooldownHours.ToString(format:  null);
        string val_5 = System.String.Format(format:  -128231456, arg0:  -128149208);
        if((UnityEngine.Object.op_Implicit(exists:  this.watchButtonText2ndLine)) != false)
        {
                string val_7 = Localization.Localize(key:  -128222912, defaultValue:  -128223040, useSingularKey:  false);
            GameEcon val_9 = App.getGameEcon;
            string val_10 = AdsManager.RequiredVideos.ToString(format:  null);
            string val_12 = AdsManager.AdsWatched.ToString();
            GameEcon val_14 = App.getGameEcon;
            string val_15 = AdsManager.RequiredVideos.ToString(format:  null);
            string val_16 = System.String.Format(format:  -128222912, arg0:  -128149208, arg1:  -128149208, arg2:  -128149208);
            val_42 = 1152921504892043264;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
            System.String[] val_17 = Split(separator:  478563824);
            val_43 = this.watchButtonText2ndLine;
            val_44 = 1152921504765685760;
            val_45 = 1152921504892043264;
            if(val_43 != 0)
        {
            goto label_24;
        }
        
        }
        else
        {
                val_46 = "WATCH {0} VIDEOS\n{1}/{2}";
            val_47 = "watch_#_videos_n_#/#_upper";
            val_48 = this.watchButtonText;
            string val_19 = Localization.Localize(key:  -128222912, defaultValue:  -128223040, useSingularKey:  false);
            GameEcon val_21 = App.getGameEcon;
            val_41 = 0;
            string val_22 = AdsManager.RequiredVideos.ToString(format:  null);
            string val_24 = AdsManager.AdsWatched.ToString();
            GameEcon val_26 = App.getGameEcon;
            string val_27 = AdsManager.RequiredVideos.ToString(format:  null);
            string val_28 = System.String.Format(format:  -128222912, arg0:  -128149208, arg1:  -128149208, arg2:  -128149208);
            val_43 = ;
            val_44 = 1152921504765685760;
            val_45 = 1152921504892043264;
        }
        
        label_24:
        if(this.noAdsGroup != 0)
        {
                this.noAdsGroup.SetActive(value:  true);
        }
        
        if(this.noAdsButtonTextTop != 0)
        {
                GameBehavior val_31 = App.getBehavior;
            if(0 != 0)
        {
                val_45 = this.noAdsPackage;
            decimal val_32 = Gems;
        }
        else
        {
                GameBehavior val_33 = App.getBehavior;
            val_45 = this.noAdsPackage;
            if(0 != 0)
        {
                decimal val_34 = Spins;
        }
        else
        {
                decimal val_35 = Credits;
        }
        
        }
        
            string val_36 = Localization.Localize(key:  -128177728, defaultValue:  -128177632, useSingularKey:  false);
            string val_37 = System.String.Format(format:  -1102017232, arg0:  10170368, arg1:  -128177728);
            val_43 = "{0} + {1}";
        }
        
        if(this.noAdsButtonPriceText != 0)
        {
                string val_39 = this.noAdsPackage.LocalPrice;
            val_43 = this.noAdsPackage;
        }
        
        string val_40 = Localization.Localize(key:  -652536416, defaultValue:  -652536528, useSingularKey:  false);
        if(this.xMonthNoAds != 0)
        {
                return;
        }
    
    }
    private void ActivateMainGroup()
    {
        this.main_group.SetActive(value:  true);
        this.sorry_group.SetActive(value:  false);
        this.unavailable_group.SetActive(value:  false);
    }
    private void ActivateSorryGroup()
    {
        this.main_group.SetActive(value:  false);
        this.sorry_group.SetActive(value:  true);
        this.unavailable_group.SetActive(value:  false);
    }
    private void ActivateUnavailableGroup()
    {
        this.main_group.SetActive(value:  false);
        this.sorry_group.SetActive(value:  false);
        this.unavailable_group.SetActive(value:  true);
    }
    protected void SetSubscriptionEntryPoint()
    {
        TrackerPurchasePoints val_1;
        var val_2;
        if(this.initTag > 2)
        {
            goto label_0;
        }
        
        if(this.initTag == 1)
        {
            goto label_1;
        }
        
        if(this.initTag != 2)
        {
                return;
        }
        
        val_1 = 36;
        val_2 = 35627124;
        goto label_7;
        label_0:
        if(this.initTag == 3)
        {
            goto label_4;
        }
        
        if(this.initTag != 13)
        {
                return;
        }
        
        val_1 = 37;
        val_2 = 35627124;
        goto label_7;
        label_1:
        val_1 = 33;
        val_2 = 8410900 + 27216224;
        goto label_7;
        label_4:
        val_1 = 38;
        val_2 = 8410916 + 27216208;
        label_7:
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        WGSubscriptionManager._subEntryPoint = val_1;
    }
    private void FrameSkip_UpdateLogic()
    {
        long val_4;
        long val_8;
        var val_13;
        long val_14;
        long val_18;
        var val_36;
        long val_38;
        var val_39;
        var val_41;
        long val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        val_36 = null;
        val_36 = null;
        System.DateTime val_1 = AdsManager.LastPurchaseCooldownEnd;
        System.DateTime val_2 = ServerHandler.ServerTime;
        System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513069344056}, d2:  new System.DateTime());
        val_38 = val_4;
        val_39 = null;
        if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_38}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                val_39 = null;
            val_38 = System.TimeSpan.Zero;
        }
        
        System.TimeSpan val_7 = System.TimeSpan.op_Addition(t1:  new System.TimeSpan() {_ticks = 1152921513069344072}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero});
        System.DateTime val_10 = AdsManager.AdsCooldownEnd;
        System.DateTime val_11 = ServerHandler.ServerTime;
        System.TimeSpan val_12 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513069344048}, d2:  new System.DateTime());
        val_41 = val_13;
        val_42 = val_14;
        val_43 = null;
        if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_42}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                val_43 = null;
        }
        
        System.TimeSpan val_16 = System.TimeSpan.op_Addition(t1:  new System.TimeSpan() {_ticks = 1152921513069344072}, t2:  new System.TimeSpan() {_ticks = val_8});
        System.TimeSpan val_17 = System.TimeSpan.FromDays(value:  null);
        if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_8}, t2:  new System.TimeSpan() {_ticks = val_18})) == false)
        {
            goto label_25;
        }
        
        val_44 = mem[1152921513069356192];
        val_45 = 1152921504619999232;
        val_8 = val_8.Days;
        val_46 = null;
        val_18 = val_8.Hours;
        val_47 = null;
        val_48 = "{0}d {1}h";
        goto label_30;
        label_25:
        System.TimeSpan val_23 = System.TimeSpan.FromHours(value:  null);
        if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_8}, t2:  new System.TimeSpan() {_ticks = val_8})) == false)
        {
            goto label_29;
        }
        
        val_44 = mem[1152921513069356192];
        val_45 = 1152921504619999232;
        val_8 = val_8.Hours;
        val_46 = null;
        val_18 = val_8.Minutes;
        val_47 = null;
        val_48 = "{0}h {1}m";
        goto label_30;
        label_29:
        System.TimeSpan val_27 = System.TimeSpan.FromMinutes(value:  null);
        if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_8}, t2:  new System.TimeSpan() {_ticks = val_8})) == false)
        {
            goto label_33;
        }
        
        val_44 = mem[1152921513069356192];
        val_45 = 1152921504619999232;
        val_8 = val_8.Minutes;
        val_46 = null;
        val_18 = val_8.Seconds;
        val_47 = null;
        val_48 = "{0}m {1}s";
        label_30:
        string val_31 = System.String.Format(format:  -1086509984, arg0:  13152256, arg1:  13152256);
        label_39:
        if(val_44 != 0)
        {
                return;
        }
        
        return;
        label_33:
        System.TimeSpan val_32 = System.TimeSpan.FromSeconds(value:  null);
        if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_8}, t2:  new System.TimeSpan() {_ticks = val_8})) != false)
        {
                val_8 = val_8.Seconds;
            val_49 = null;
        }
        else
        {
                val_49 = "0";
        }
        
        string val_35 = System.String.Format(format:  -127449520, arg0:  1254115712);
        goto label_39;
    }
    protected void OnClick_NoAds(bool result)
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        if(this.currentEntryPoint != 0)
        {
                var val_12 = 27211817;
            val_12 = 8414244 + val_12;
            if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
            val_12 = null;
            val_12 = null;
            PurchaseProxy.currentPurchasePoint = this.currentEntryPoint;
        }
        
        if(result == false)
        {
            goto label_7;
        }
        
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -127303200, method:  new IntPtr(4167633952));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10, b:  7507968);
        val_13 = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10;
        if(val_13 != 0)
        {
                if(val_13 == null)
        {
            goto label_13;
        }
        
        }
        
        val_13 = 0;
        label_13:
        public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10 = val_13;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        Purchase(purchase:  this.noAdsPackage);
        return;
        label_7:
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_6 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_7 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_8 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_9 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        System.Func<System.Boolean> val_10 = new System.Func<System.Boolean>(object:  -127303200, method:  new IntPtr(4167639072));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_14 = null;
        val_15 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_11 = this.gameObject;
        SLCWindow.CloseWindow(window:  -127303200, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected virtual void OnPurchaseNoAdsPackSuccess()
    {
        int val_5;
        int val_6;
        int val_18;
        int val_19;
        int val_20;
        int val_21;
        int val_26;
        GemsCollectAnimationInstantiator val_30;
        int val_31;
        int val_32;
        var val_34;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            goto label_5;
        }
        
        val_30 = this.gemAnimControl;
        Player val_2 = App.Player;
        val_31 = 0;
        decimal val_3 = System.Decimal.op_Implicit(value:  -127170484);
        decimal val_4 = Gems;
        decimal val_7 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -127170516}, d2:  new System.Decimal() {flags = val_5, hi = val_6});
        val_32 = System.Decimal.op_Explicit(value:  new System.Decimal());
        Player val_9 = App.Player;
        if(0 != 0)
        {
            goto label_13;
        }
        
        goto label_13;
        label_5:
        GameBehavior val_10 = App.getBehavior;
        if(0 == 0)
        {
            goto label_18;
        }
        
        val_30 = this.spinAnimControl;
        RestaurantRivals.RESPlayer val_11 = RestaurantRivals.RESPlayer.Instance;
        val_31 = 0;
        decimal val_12 = System.Decimal.op_Implicit(value:  -127170484);
        decimal val_13 = Spins;
        decimal val_14 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -127170516}, d2:  new System.Decimal() {flags = val_5, hi = val_6});
        val_32 = System.Decimal.op_Explicit(value:  new System.Decimal());
        RestaurantRivals.RESPlayer val_16 = RestaurantRivals.RESPlayer.Instance;
        label_13:
        decimal val_17 = System.Decimal.op_Implicit(value:  -127170532);
        val_30.Play(fromValue:  val_32, toValue:  new System.Decimal() {flags = val_19, hi = val_20, lo = val_21, mid = val_18}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        goto label_25;
        label_18:
        val_30 = this.coinsAnimControl;
        Player val_22 = App.Player;
        decimal val_23 = Credits;
        decimal val_24 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -127170500, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_25 = App.Player;
        val_30.Play(fromValue:  new System.Decimal() {mid = val_26}, toValue:  new System.Decimal() {mid = val_31}, textTickTime:  null, delayBeforeComplete:  null);
        label_25:
        WordPets.WPTDataParser val_27 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<System.Threading.Tasks.Task, System.Object> val_28 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -127158432, method:  new IntPtr(4167633952));
        System.Delegate val_29 = System.Delegate.Remove(source:  public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10, value:  7507968);
        val_34 = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10;
        if(val_34 != 0)
        {
                if(val_34 == null)
        {
            goto label_39;
        }
        
        }
        
        val_34 = 0;
        label_39:
        public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10 = val_34;
    }
    protected void OnPurchaseNoAdsPackFailed(string title, string message)
    {
        var val_9;
        var val_10;
        var val_11;
        GameBehavior val_1 = App.getBehavior;
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_3 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
        System.Func<System.Boolean> val_4 = new System.Func<System.Boolean>(object:  -127012640, method:  new IntPtr(4167929632));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_9 = null;
        val_10 = 0;
        val_10.SetupMessage(titleTxt:  title, messageTxt:  message, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -127012640, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<System.Threading.Tasks.Task, System.Object> val_7 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -127012640, method:  new IntPtr(4167633952));
        System.Delegate val_8 = System.Delegate.Remove(source:  public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10, value:  7507968);
        val_11 = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10;
        if(val_11 != 0)
        {
                if(val_11 == null)
        {
            goto label_27;
        }
        
        }
        
        val_11 = 0;
        label_27:
        public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10 = val_11;
    }
    private void OnCoinAnimFinished()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -126892448, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Store(bool result)
    {
        var val_4;
        var val_5;
        TrackerPurchasePoints val_6;
        if(this.initTag > 2)
        {
            goto label_1;
        }
        
        if(this.initTag == 1)
        {
            goto label_2;
        }
        
        if(this.initTag != 2)
        {
            goto label_9;
        }
        
        val_4 = 1152921504899551232;
        var val_4 = 27207853;
        val_4 = 8418208 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_6 = 3;
        goto label_17;
        label_1:
        if(this.initTag == 3)
        {
            goto label_8;
        }
        
        if(this.initTag != 13)
        {
            goto label_9;
        }
        
        val_4 = 1152921504899551232;
        var val_5 = 27207741;
        val_5 = 8418320 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_6 = 16;
        goto label_17;
        label_2:
        val_4 = 1152921504899551232;
        var val_6 = 27207645;
        val_6 = 8418416 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_6 = 10;
        goto label_17;
        label_8:
        val_4 = 1152921504899551232;
        var val_7 = 27207549;
        val_7 = 8418512 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_6 = 7;
        label_17:
        PurchaseProxy.currentPurchasePoint = val_6;
        label_9:
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -126776352, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_WatchAnotherVideo(bool result)
    {
        this.ActivateMainGroup();
        this.OnClick_WatchVideo(result:  false);
    }
    private void OnClick_WatchVideo(bool result)
    {
        var val_17;
        var val_18;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745532016) == 0)
        {
            goto label_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsVideoAvailable() == false)
        {
            goto label_9;
        }
        
        label_5:
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_6 = ShowIncentivizedVideo(tag:  this.initTag, adCapExempt:  true);
        return;
        label_9:
        System.Func<System.Boolean> val_7 = new System.Func<System.Boolean>(object:  -126541088, method:  new IntPtr(4168399136));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        object val_8 = this.GetComponent<System.Object>();
        if((-126541088) == 0)
        {
                UnityEngine.GameObject val_10 = this.gameObject;
            object val_11 = this.AddComponent<System.Object>();
        }
        
        GameBehavior val_12 = App.getBehavior;
        string val_14 = Localization.Localize(key:  -598573744, defaultValue:  -598573648, useSingularKey:  false);
        string val_15 = Localization.Localize(key:  -598573536, defaultValue:  -598573408, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_16 = Localization.Localize(key:  -598573280, defaultValue:  -1663756496, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_17 = null;
        val_18 = 0;
        if( == 0)
        {
                val_18 = 0;
        }
        
        val_18.SetupMessage(titleTxt:  -598573744, messageTxt:  -598573536, shownButtons:  1054454320, buttonTexts:  null, showClose:  true, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    private void OnDisable()
    {
        var val_10;
        string val_11;
        System.Delegate val_12;
        var val_13;
        System.Action<twelvegigs.storage.JsonDictionary> val_14;
        System.Delegate val_15;
        val_10 = null;
        val_10 = null;
        PostProcessPurchaseDelegate val_1 = new PostProcessPurchaseDelegate(object:  -126419872, method:  new IntPtr(4165281328));
        System.Delegate val_2 = System.Delegate.Remove(source:  PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS, value:  291586048);
        val_11 = 0;
        if(PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS != null)
        {
                if(null != null)
        {
                val_11 = 0;
        }
        else
        {
                val_11 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        }
        
        }
        
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_11;
        System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -126419872, method:  new IntPtr(4165282352));
        val_12 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_4 = System.Delegate.Remove(source:  val_12, value:  7401472);
        val_13 = null;
        val_14 = null;
        if(val_12 == 0)
        {
            goto label_6;
        }
        
        if(null == val_14)
        {
            goto label_7;
        }
        
        val_14 = null;
        val_13 = 1152921504898486364;
        label_6:
        val_12 = 0;
        label_7:
        PurchasesHandler.OnPurchaseCompleted = val_12;
        val_14 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -126419872, method:  new IntPtr(4165283376));
        val_15 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_6 = System.Delegate.Remove(source:  val_15, value:  7401472);
        if(val_15 != 0)
        {
                if(null == null)
        {
            goto label_9;
        }
        
        }
        
        val_15 = 0;
        label_9:
        PurchasesHandler.OnPurchaseFailure = val_15;
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -126419872, name:  2128120864);
        object val_8 = this.GetComponent<System.Object>();
        if((UnityEngine.Object.op_Implicit(exists:  -126419872)) == true)
        {
                return;
        }
        
        if(this.Action_OnClose == 0)
        {
                return;
        }
        
        this.Action_OnClose.Invoke();
    }
    public WGAdsControlPopup()
    {
    
    }
    private bool <OnClick_NoAds>b__39_0()
    {
        var val_7;
        HeyZapAdTag val_8;
        var val_9;
        System.Action val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = 1152921511082038080;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_8 = this.initTag;
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_54 = val_8;
        SetPurchaseEntryByInitTag();
        if(this.initTag != 2)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_54 = this.initTag;
            SetPurchaseEntryByInitTag();
        }
        else
        {
                mem[84] = this.initTag;
            SetPurchaseEntryByInitTag();
        }
        
        object val_5 = GetComponent<System.Object>();
        val_8 = 1152921504991404032;
        val_9 = null;
        val_9 = null;
        val_11 = WGAdsControlPopup.<>c.<>9__39_1;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Action(object:  WGAdsControlPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4168763808));
            WGAdsControlPopup.<>c.<>9__39_1 = val_11;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_11;
        return true;
    }
    private bool <OnPurchaseNoAdsPackFailed>b__41_0()
    {
        GameBehavior val_1 = App.getBehavior;
        mem[84] = this.initTag;
        this.SetPurchaseEntryByInitTag();
        return true;
    }
    private bool <OnClick_WatchVideo>b__45_0()
    {
        this.OnClick_WatchVideo(result:  false);
        return true;
    }

}
