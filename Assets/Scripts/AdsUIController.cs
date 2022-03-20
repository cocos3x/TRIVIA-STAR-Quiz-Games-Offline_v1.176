using UnityEngine;
public class AdsUIController : MonoSingleton<AdsUIController>
{
    // Fields
    private bool showAdsOnDataReady;
    private bool toggleAdsOnSceneChange;
    private AdsUIController_BannerAds bannerController;
    private AdsUIController_Gameplay gameplayController;
    private const string Pref_SeenAdsControl = "seen_adscontrol";
    private const string Pref_SeenAdsControlDate = "seen_ads_date";
    private const string Pref_SeenFreeHint = "seen_freehint";
    private const string Pref_SeenPostLevelOffer = "seen_postlevel";
    private int bannerAdsUnblocked;
    public const string OnVideoResponse = "OnVideoResponse";
    public const string Event_OnCanvasResized = "OnCanvasResized";
    public const string OnInterstitialResponse = "OnInterstitialResponse";
    public UnityEngine.Events.UnityEvent onAdToggled;
    
    // Properties
    public UnityEngine.GameObject HintButtonGroup { get; }
    public UnityEngine.GameObject MegaHintButtonGroup { get; }
    public UnityEngine.GameObject PickerHintButtonGroup { get; }
    public UnityEngine.GameObject FreeHintButtonGroup { get; }
    public UnityEngine.GameObject ShuffleButtonGroup { get; }
    public bool BannerAdsUnblocked { set; }
    public bool BannerAdsBlockedByUI { get; }
    public static bool AdsAllowed { get; }
    public bool BannerAdsAllowed { get; }
    private bool InterstitialAdsAllowed { get; }
    public bool VideoAdsAllowed { get; }
    
    // Methods
    public UnityEngine.GameObject get_HintButtonGroup()
    {
        if(this.gameplayController == 0)
        {
                return;
        }
        
        0 = this.gameplayController.hintButtonGroup;
    }
    public UnityEngine.GameObject get_MegaHintButtonGroup()
    {
        if(this.gameplayController == 0)
        {
                return;
        }
        
        0 = this.gameplayController.megaHintButtonGroup;
    }
    public UnityEngine.GameObject get_PickerHintButtonGroup()
    {
        if(this.gameplayController == 0)
        {
                return;
        }
        
        0 = this.gameplayController.pickerHintButtonGroup;
    }
    public UnityEngine.GameObject get_FreeHintButtonGroup()
    {
        if(this.gameplayController == 0)
        {
                return;
        }
        
        0 = this.gameplayController.incentivizedButton;
    }
    public UnityEngine.GameObject get_ShuffleButtonGroup()
    {
        if(this.gameplayController == 0)
        {
                return;
        }
        
        0 = this.gameplayController.shuffleButtonGroup;
    }
    public void set_BannerAdsUnblocked(bool value)
    {
        if(value == true)
        {
                1 = 0;
        }
        
        this.bannerAdsUnblocked = this.bannerAdsUnblocked + 1;
    }
    public bool get_BannerAdsBlockedByUI()
    {
        if(this.bannerAdsUnblocked > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static bool get_AdsAllowed()
    {
        return AdsManager.AdsCanShow;
    }
    public bool get_BannerAdsAllowed()
    {
        var val_5;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_5 = 0;
        if(BannerEnabled() == false)
        {
                return true;
        }
        
        if(AdsManager.AdsCanShow == false)
        {
                return true;
        }
        
        if(AdsManager.AdsAllowedByScene == false)
        {
                return true;
        }
        
        if(this.bannerAdsUnblocked < 1)
        {
                val_5 = 1;
        }
        
        return true;
    }
    private bool get_InterstitialAdsAllowed()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(InterstitialEnabled() == false)
        {
                return false;
        }
        
        if(AdsManager.AdsCanShow == false)
        {
                return false;
        }
        
        return AdsManager.AdsAllowedByScene;
    }
    private bool InterstitialAdsAllowedByContext(InterstitialContext context)
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((InterstitialContextEnabled(context:  context)) == false)
        {
                return false;
        }
        
        if(AdsManager.AdsCanShow == false)
        {
                return false;
        }
        
        return AdsManager.AdsAllowedByScene;
    }
    public bool get_VideoAdsAllowed()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return VideoEnabledAndUnlocked();
        }
        
        return VideoEnabledAndUnlocked();
    }
    public override void InitMonoSingleton()
    {
        var val_9;
        var val_10;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -781925152, name:  -2037002944);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -781925152, name:  -1898880160);
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_4 = new System.Action<Result>(object:  -781925152, method:  new IntPtr(3513017120));
        System.Delegate val_5 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_9 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_10;
        }
        
        }
        
        val_9 = 0;
        label_10:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_9;
        WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_7 = new System.Action<Result>(object:  -781925152, method:  new IntPtr(3513017120));
        System.Delegate val_8 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, b:  7401472);
        val_10 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_14;
        }
        
        }
        
        val_10 = 0;
        label_14:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_10;
    }
    private void Start()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -781811104, method:  new IntPtr(3513130144));
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_30 = null;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  -781811104, method:  new IntPtr(3513131168));
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_3C = null;
    }
    public void OnSceneChanged(SceneType type)
    {
        this.ToggleIncentivizedButton();
        if(this.toggleAdsOnSceneChange == false)
        {
                return;
        }
        
        if(this.bannerController == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745532016) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HideBanner();
            return;
        }
        
        }
        
        this.bannerController.ShowOrHideBanner();
    }
    private void OnDeferredReady()
    {
        this.ReadyOrServerSyncy();
    }
    private void OnServerSync()
    {
        this.ReadyOrServerSyncy();
    }
    private void ReadyOrServerSyncy()
    {
        this.ToggleIncentivizedButton();
        if(this.showAdsOnDataReady == false)
        {
                return;
        }
        
        if(this.bannerController == 0)
        {
                return;
        }
        
        R4 + 16.ShowOrHideBanner();
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        var val_4;
        var val_5;
        var val_6;
        this.ToggleIncentivizedButton();
        if(pauseStatus != false)
        {
                var val_4 = 24681112;
            val_4 = 10944676 + val_4;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            val_4 = null;
            val_4 = null;
            if(TrackingComponent.lastIntent != 3)
        {
                return;
        }
        
            WGGenericNotificationsManager.SendPostAdNotification(QAHACK_Force:  false);
            return;
        }
        
        var val_5 = System.Void System.Collections.Generic.Dictionary<System.Int32Enum, System.Single>::System.Collections.ICollection.CopyTo(System.Array array, int index);
        val_5 = 10944852 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if(TrackingComponent.lastIntent == 3)
        {
                WGGenericNotificationsManager.CancelPostAdNotification();
            val_5 = null;
        }
        
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(TrackingComponent.lastIntent != 0)
        {
                return;
        }
        
        var val_6 = 24681190;
        val_6 = 10945120 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        if((InAppPurchasesManager.<inPurchaseIntent>k__BackingField) == true)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                mem[1179404903] = 1;
            bool val_3 = this.ShowInterstitial(context:  1);
        }
    
    }
    public void ToggleIncentivizedButton()
    {
        if(this.gameplayController == 0)
        {
                return;
        }
        
        R4 + 20.ToggleIncentivizedButton();
    }
    private void OnDestroy()
    {
        var val_8;
        var val_9;
        if((MonoSingletonSelfGenerating<WordLevelGen>.InstanceExists) == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_3 = new System.Action<Result>(object:  -780986144, method:  new IntPtr(3513017120));
        System.Delegate val_4 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_9;
        }
        
        }
        
        val_8 = 0;
        label_9:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_6 = new System.Action<Result>(object:  -780986144, method:  new IntPtr(3513017120));
        System.Delegate val_7 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, value:  7401472);
        val_9 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_13;
        }
        
        }
        
        val_9 = 0;
        label_13:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_9;
    }
    public void ShowOrHideBanner()
    {
        if(this.bannerController == 0)
        {
                return;
        }
        
        R4 + 16.ShowOrHideBanner();
    }
    public float GetBannerAdHeight()
    {
        if(this.bannerController == 0)
        {
                return (float)S0;
        }
        
        if(this.bannerController != 0)
        {
                return this.bannerController.GetBannerHeight();
        }
        
        return this.bannerController.GetBannerHeight();
    }
    public float GetBannerAdCanvasHeight()
    {
        if(this.bannerController == 0)
        {
                return (float)S0;
        }
        
        if(this.bannerController != 0)
        {
                return this.bannerController.GetBannerCanvasHeight();
        }
        
        return this.bannerController.GetBannerCanvasHeight();
    }
    public bool ShowInterstitial(InterstitialContext context)
    {
        if((this.InterstitialAdsAllowedByContext(context:  context)) == false)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance()) != 0)
        {
                return ShowInterstitial(context:  2);
        }
        
        return ShowInterstitial(context:  2);
    }
    public bool ShowIncentivizedVideo(HeyZapAdTag tag, bool adCapExempt = False)
    {
        if(this.VideoAdsAllowed == false)
        {
                return false;
        }
        
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        35635335 = public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance();
        if((rewardVideoCapReached != false) && (adCapExempt != true))
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance()) != 0)
        {
                return ShowVideo(heyZapAdTag:  tag);
        }
        
        return ShowVideo(heyZapAdTag:  tag);
    }
    public void OnVideoAdWatched(bool success)
    {
        this.ToggleIncentivizedButton();
        System.Collections.Hashtable val_1 = new System.Collections.Hashtable();
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -780256800, aName:  2128120864, aData:  75878400);
    }
    public void OnInterstitialDisplayed(bool displayed)
    {
        System.Collections.Hashtable val_1 = new System.Collections.Hashtable();
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -780144592, aName:  -780168704, aData:  75878400);
    }
    public void HandlePurchase()
    {
        if(AdsUIController.AdsAllowed != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HideBanner();
        }
        
        this.ToggleIncentivizedButton();
    }
    public void AdControlVideoWatched()
    {
        if(AdsUIController.AdsAllowed == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HideBanner();
    }
    public void CheckOrFetchInterstitial()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CheckInterstitialAvailable();
    }
    public static HeyZapAdTag GetTagForPurchasePoint(TrackerPurchasePoints entryPoint)
    {
        TrackerPurchasePoints val_1 = entryPoint - 20;
        if(val_1 <= 24)
        {
                var val_2 = 10950216 + (10950216 + ((entryPoint - 20)) << 2);
            if(val_1 == 24)
        {
                15 = R8 * 15;
            15 = 15 & ((IP) << 1);
            15 = 15 * 15;
            15 = 15 & (((R4) << (32-as. 
            
        
        
        
        
        
           
        )) | ((R4) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 & (((R4) << (32-as. 
            
        
        
        
        
        
           
        )) | ((R4) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 & (((R4) << (32-as. 
            
        
        
        
        
        
           
        )) | ((R4) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 * 15;
            15 = 15 * 15;
            15 = 15 & (((R4) << (32-as. 
            
        
        
        
        
        
           
        )) | ((R4) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 & (((R4) << (32-as. 
            
        
        
        
        
        
           
        )) | ((R4) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 & (((R4) << (32-as. 
            
        
        
        
        
        
           
        )) | ((R4) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 * 15;
            15 = 15 * 15;
            15 = 15 * 15;
            15 = 15 * 15;
            15 = 15 * 15;
            15 = 15 * 15;
            15 = 15 * 15;
            15 = 15 * 15;
            15 = 15 & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
            15 = 15 & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
        }
        
            return;
        }
        
        if(entryPoint == 111)
        {
                entryPoint = 44;
            return;
        }
        
        if(entryPoint != 112)
        {
                return;
        }
    
    }
    public static string GetFreeCoinsEventForPurchasePoint(TrackerPurchasePoints entryPoint)
    {
        var val_3;
        var val_4;
        TrackerPurchasePoints val_1 = entryPoint - 20;
        if(val_1 <= 10)
        {
                var val_2 = 10950456 + (10950456 + ((entryPoint - 20)) << 2);
            if(val_1 == 10)
        {
                mem2[0] = 10950456 + ((entryPoint - 20)) << 2 + entryPoint;
            (10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1)) = ((10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1))) & (((IP) << (32-(10950456 + ((entryPoint - 20)) << 2 + entryPoint & ((IP) << (32-1)) | ((IP) << 1)))) | ((IP) << (10950456 + ((entryPoint - 20)) << 2 + entryPoint & ((IP) << (32-1)) | ((IP) << 1))));
            (10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1)) = ((10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1))) & ((IP) >> 32);
            (10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1)) = ((10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1))) & ((IP) >> 32);
            (10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1)) = ((10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1))) & ((IP) >> 32);
            (10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1)) = ((10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1))) & (entryPoint >> 2);
            (10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1)) = ((10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1))) & (((10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1))) >> 10950456);
            (10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1)) = ((10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1))) & ((IP) >> 32);
            (10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1)) = ((10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1))) & ((IP) >> 32);
            (10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1)) = ((10950456 + ((entryPoint - 20)) << 2 + entryPoint) & (((IP) << (32-1)) | ((IP) << 1))) & ((IP) >> 32);
        }
        
            val_3 = null;
            val_3 = null;
            return;
        }
        
        if(entryPoint == 121)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
    }
    public static CurrencyRewardType GetCurrencyRewardForPurchasePoint(TrackerPurchasePoints entryPoint)
    {
        entryPoint = entryPoint - 76;
        entryPoint = entryPoint >> 5;
    }
    public void TryShowPromptVideo(TrackerPurchasePoints entryPoint = 0, bool showAsFlyout = False)
    {
        var val_12;
        var val_13;
        var val_14;
        val_12 = 35635342;
        if(this.VideoAdsAllowed == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_12 = public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance();
        if(rewardVideoCapReached == true)
        {
                return;
        }
        
        if(showAsFlyout != false)
        {
                GameBehavior val_5 = App.getBehavior;
            val_13 = 0;
        }
        else
        {
                GameBehavior val_7 = App.getBehavior;
            val_13 = 0;
        }
        
        HeyZapAdTag val_9 = AdsUIController.GetTagForPurchasePoint(entryPoint:  entryPoint);
        string val_10 = AdsUIController.GetFreeCoinsEventForPurchasePoint(entryPoint:  entryPoint);
        var val_12 = 24674732;
        val_12 = 10951328 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        TrackerPurchasePoints val_13 = PurchaseProxy.currentPurchasePoint;
        val_13 = val_13 - 76;
        TrackerPurchasePoints val_11 = val_13 >> 5;
    }
    public bool CanShowAdsControlPopup(bool adWaterfallOn = False)
    {
        var val_13;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return this.CanShowAdsControlV2();
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
                return false;
        }
        
        GameBehavior val_3 = App.getBehavior;
        GameEcon val_4 = App.getGameEcon;
        val_13 = 0;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0)) == false)
        {
                return false;
        }
        
        val_13 = 1152921511026388688;
        WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(InterstitialEnabled() != true)
        {
                WordPets.WPTDataParser val_8 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(BannerEnabled() == false)
        {
                return false;
        }
        
        }
        
        if(AdsManager.AdsCanShow == false)
        {
                return false;
        }
        
        if(adWaterfallOn != true)
        {
                if((UnityEngine.PlayerPrefs.HasKey(key:  -779238368)) != false)
        {
                return false;
        }
        
        }
        
        GameBehavior val_12 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private bool CanShowAdsControlV2()
    {
        ulong val_24;
        ulong val_26;
        var val_29;
        var val_30;
        var val_31;
        GameBehavior val_1 = App.getBehavior;
        val_29 = 0;
        if(0 == 0)
        {
                return (bool)val_29;
        }
        
        GameBehavior val_2 = App.getBehavior;
        GameEcon val_3 = App.getGameEcon;
        val_30 = 0;
        val_29 = 0;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0)) == false)
        {
                return (bool)val_29;
        }
        
        val_30 = 1152921504901201920;
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(InterstitialEnabled() != true)
        {
                WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(BannerEnabled() == false)
        {
                return (bool)val_29;
        }
        
        }
        
        if(AdsManager.AdsCanShow == false)
        {
                return (bool)val_29;
        }
        
        val_29 = 0;
        Player val_10 = App.Player;
        if(0.RemovedAds == true)
        {
                return (bool)val_29;
        }
        
        val_29 = 0;
        GameEcon val_13 = App.getGameEcon;
        val_30 = 0;
        if((UnityEngine.PlayerPrefs.GetInt(key:  -779238368, defaultValue:  0)) >= 20)
        {
                return (bool)val_29;
        }
        
        string val_14 = UnityEngine.PlayerPrefs.GetString(key:  -779126256, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -779126256)) != false)
        {
                val_29 = 1;
            return (bool)val_29;
        }
        
        val_31 = null;
        val_31 = null;
        System.DateTime val_16 = SLCDateTime.ParseInvariant(dateTime:  -779114216, defaultValue:  new System.DateTime() {dateData = 1152921512417655312});
        System.DateTime val_19 = Date;
        System.DateTime val_20 = DateTimeCheat.UtcNow;
        System.DateTime val_23 = Date;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_26}, d2:  new System.DateTime() {dateData = val_24})) == false)
        {
                val_29 = 1;
        }
        
        return (bool)val_29;
    }
    public void SawAdsControl()
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -779238368, value:  (UnityEngine.PlayerPrefs.GetInt(key:  -779238368, defaultValue:  0)) + 1);
        UnityEngine.PlayerPrefs.Save();
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        string val_4 = SLCDateTime.SerializeInvariant(dateTime:  new System.DateTime());
        UnityEngine.PlayerPrefs.SetString(key:  -779126256, value:  R0);
    }
    public bool CanShowFreeHintPopup()
    {
        var val_20;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                GameEcon val_3 = App.getGameEcon;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            bool val_4 = SceneDictator.IsInGameScene();
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            GameBehavior val_5 = App.getBehavior;
            GameEcon val_6 = App.getGameEcon;
            bool val_7 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0);
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            Player val_8 = App.Player;
            if(0 <= 0)
        {
                val_20 = 1;
        }
        
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            bool val_9 = UnityEngine.PlayerPrefs.HasKey(key:  -778902160);
            val_9 = val_9 ^ 1;
            typeof(System.Object[]).__il2cppRuntimeField_20 = null;
            WordPets.WPTDataParser val_10 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            bool val_11 = rewardVideoCapReached;
            val_11 = val_11 ^ 1;
            typeof(System.Object[]).__il2cppRuntimeField_24 = null;
            UnityEngine.Debug.LogFormat(format:  -778902064, args:  472754880);
        }
        
        if(SceneDictator.IsInGameScene() == false)
        {
                return false;
        }
        
        val_20 = 1152921504892043264;
        GameBehavior val_13 = App.getBehavior;
        GameEcon val_14 = App.getGameEcon;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0)) == false)
        {
                return false;
        }
        
        Player val_16 = App.Player;
        if(0 > 0)
        {
                return false;
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -778902160)) != false)
        {
                return false;
        }
        
        WordPets.WPTDataParser val_18 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(rewardVideoCapReached == true)
        {
                1 = 0;
        }
        
        return false;
    }
    public void SawFreeHint()
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -778902160, value:  1);
    }
    public bool CanShowPostLevelOffer()
    {
        GameEcon val_2 = App.getGameEcon;
        GameEcon val_3 = App.getGameEcon;
        Player val_6 = App.Player;
        if(0 >= ((UnityEngine.Random.Range(min:  5611899, max:  54 + 1)) + (UnityEngine.PlayerPrefs.GetInt(key:  -778677888, defaultValue:  0))))
        {
                0 = 1;
        }
        
        return true;
    }
    public bool CanShowPostLevelRewardedVideo(int playerLevel)
    {
        var val_7;
        var val_8;
        GameEcon val_1 = App.getGameEcon;
        val_7 = 0;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  playerLevel, knobValue:  516)) == false)
        {
                return true;
        }
        
        val_7 = 0;
        Player val_3 = App.Player;
        if(0 > 0)
        {
                return true;
        }
        
        val_7 = 0;
        Player val_4 = App.Player;
        bool val_5 = 0.networkPurchaserExcludedFromAds;
        if(val_5 == true)
        {
                return true;
        }
        
        if(val_5.VideoAdsAllowed == false)
        {
                return true;
        }
        
        var val_7 = 24671165;
        val_7 = 10956260 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE != null)
        {
                val_7 = 1;
        }
        
        return true;
    }
    public void SawPostLevelOffer()
    {
        Player val_1 = App.Player;
        UnityEngine.PlayerPrefs.SetInt(key:  -778677888, value:  0);
    }
    public bool CanShowPostLevelAdsControlOffer(int playerLevel)
    {
        var val_12;
        var val_13;
        val_12 = 1152921504892043264;
        val_13 = 0;
        Player val_1 = App.Player;
        if(0.RemovedAds == true)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_13 = 0;
        if((hasSubscription(subPackage:  0)) == true)
        {
                return true;
        }
        
        int val_5 = AdsManager.noAdsStartLevel;
        if(val_5 > 1)
        {
                return true;
        }
        
        if(val_5.VideoAdsAllowed == false)
        {
                return true;
        }
        
        val_13 = 0;
        Player val_7 = App.Player;
        if(0 > 0)
        {
                return true;
        }
        
        val_13 = 0;
        Player val_8 = App.Player;
        if(0.networkPurchaserExcludedFromAds == true)
        {
                return true;
        }
        
        Player val_10 = App.Player;
        GameEcon val_11 = App.getGameEcon;
        val_12 = 0;
        if(0 >= 786450)
        {
                val_13 = 1;
        }
        
        return true;
    }
    public AdsUIController()
    {
        this.showAdsOnDataReady = true;
        this.toggleAdsOnSceneChange = true;
        this.onAdToggled = new UnityEngine.Events.UnityEvent();
    }

}
