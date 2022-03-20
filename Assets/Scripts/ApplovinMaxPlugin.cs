using UnityEngine;
public class ApplovinMaxPlugin : MonoSingleton<ApplovinMaxPlugin>
{
    // Fields
    private ApplovinMaxPlugin.BannerState currentBannerState;
    private ApplovinMaxPlugin.BannerState setBannerState;
    private static int frameSkipValue;
    private bool forceRefresh;
    private static string bannerAdUnitId;
    private static string rewardedAdUnitId;
    private static string interstitialAdUnitId;
    private static bool adUnitsSet;
    private static bool initialized;
    public System.Action<bool> BannerAdsStateChanged;
    public System.Action<bool> RewardVideoLoaded;
    private static bool bannersFetched;
    private UnityEngine.Rect bannerDimenions;
    public System.Action<bool> IncentivizedVideoCallback;
    private HeyZapAdTag currentVideoAdTag;
    private bool hack_noVideoAdsAvailable;
    private System.Action<bool> InterstitialCallback;
    
    // Properties
    private static int RetryLoadAd { get; }
    private float tabletBannerHeight { get; }
    private float phoneBannerHeight { get; }
    public UnityEngine.Rect BannerDimensions { get; }
    
    // Methods
    private static int get_RetryLoadAd()
    {
        return 2;
    }
    private float get_tabletBannerHeight()
    {
        float val_2 = (float)UnityEngine.Screen.height;
        val_2 = val_2 * 0.092f;
        return (float)val_2;
    }
    private float get_phoneBannerHeight()
    {
        float val_2 = (float)UnityEngine.Screen.height;
        val_2 = val_2 * 0.092f;
        return (float)val_2;
    }
    public override void InitMonoSingleton()
    {
        this.InitMonoSingleton();
        this.AddBannerConsumer();
        System.Collections.IEnumerator val_1 = this.InitializeSDK();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1873479856);
    }
    private void InitializeMediation()
    {
        System.Collections.IEnumerator val_1 = this.InitializeSDK();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1873367856);
    }
    private System.Collections.IEnumerator InitializeSDK()
    {
        object val_1 = new System.Object();
        typeof(ApplovinMaxPlugin.<InitializeSDK>d__18).__il2cppRuntimeField_8 = 0;
        typeof(ApplovinMaxPlugin.<InitializeSDK>d__18).__il2cppRuntimeField_10 = this;
    }
    private void AddBannerConsumer()
    {
        var val_5;
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1873140784, method:  new IntPtr(2421799440));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.UI.LayoutElement val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1873140784);
        val_5 = null;
        val_5 = null;
        this.forceRefresh = ApplovinMaxPlugin.frameSkipValue;
        System.Action val_4 = new System.Action(object:  -1873140784, method:  new IntPtr(2421801488));
        this.BannerAdsStateChanged = null;
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        this.forceRefresh = true;
    }
    private void ConsumeBannerState()
    {
        if(this.currentBannerState == this.setBannerState)
        {
                this.currentBannerState = this.forceRefresh;
        }
        
        if(this.currentBannerState == false)
        {
                return;
        }
        
        this.currentBannerState = this.setBannerState;
        if(this.setBannerState == 1)
        {
                this.ShowBannerFromMediation();
        }
        else
        {
                this.setBannerState.HideBannerFromMediation(destroy:  false);
        }
        
        this.forceRefresh = false;
    }
    private void OnSDKInitialized(MaxSdkBase.SdkConfiguration obj)
    {
        MaxSdkAndroid.SetHasUserConsent(hasUserConsent:  true);
        System.Collections.IEnumerator val_1 = this.InitializeInterstitials();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1872776112);
        System.Collections.IEnumerator val_3 = this.InitializeBanners();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -1872776112);
        System.Collections.IEnumerator val_5 = this.InitializeRewardedVideos();
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -1872776112);
    }
    private void SetFANTrackingFlag(MaxSdkBase.SdkConfiguration obj)
    {
    
    }
    private void SetupAdUnits()
    {
        var val_4;
        AppConfigs val_1 = App.Configuration;
        val_4 = null;
        val_4 = null;
        ApplovinMaxPlugin.bannerAdUnitId = .__il2cppRuntimeField_4C + 64;
        AppConfigs val_2 = App.Configuration;
        ApplovinMaxPlugin.interstitialAdUnitId = ApplovinMaxPlugin.interstitialAdUnitId + 76 + 72;
        AppConfigs val_3 = App.Configuration;
        ApplovinMaxPlugin.rewardedAdUnitId = mem[ApplovinMaxPlugin.interstitialAdUnitId + 76 + 72 + 76] + 68;
        ApplovinMaxPlugin.adUnitsSet = true;
    }
    private void PauseAudio(bool pause)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2114052032) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ToggleMute(mute:  pause);
    }
    public void ShowAdMediationSuite()
    {
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        MaxSdkAndroid.ShowMediationDebugger();
    }
    public UnityEngine.Rect get_BannerDimensions()
    {
        var val_1 = R1 + 32;
        return new UnityEngine.Rect();
    }
    public void ShowBanner()
    {
        this.setBannerState = 1;
    }
    private void ShowBannerFromMediation()
    {
        var val_1;
        var val_3;
        val_1 = null;
        val_1 = null;
        if(ApplovinMaxPlugin.initialized == false)
        {
                return;
        }
        
        if(ApplovinMaxPlugin.adUnitsSet == false)
        {
                return;
        }
        
        this.ResizeBannerAndNotify();
        val_3 = null;
        val_3 = null;
        if(ApplovinMaxPlugin.bannersFetched != true)
        {
                MaxSdkAndroid.CreateBanner(adUnitIdentifier:  ApplovinMaxPlugin.bannerAdUnitId, bannerPosition:  7);
            val_3 = null;
            ApplovinMaxPlugin.bannersFetched = true;
        }
        
        val_3 = null;
        MaxSdkAndroid.ShowBanner(adUnitIdentifier:  ApplovinMaxPlugin.bannerAdUnitId);
    }
    private void ResizeBannerAndNotify()
    {
        float val_3;
        float val_4;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        bool val_2 = IsTablet();
        float val_8 = (float)UnityEngine.Screen.height;
        val_8 = val_8 * 0.092f;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_8, y:  val_1.y);
        UnityEngine.Rect val_7 = new UnityEngine.Rect(position:  new UnityEngine.Vector2() {x = val_3, y = val_4}, size:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
        if(this.BannerAdsStateChanged == 0)
        {
                return;
        }
        
        this.BannerAdsStateChanged.Invoke(obj:  true);
    }
    private bool IsTablet()
    {
        var val_8;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 == 11)
        {
            goto label_1;
        }
        
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 8)
        {
            goto label_2;
        }
        
        label_1:
        float val_4 = UnityEngine.Screen.dpi;
        float val_6 = UnityEngine.Screen.dpi;
        uint val_8 = 0;
        val_8 = ((float)UnityEngine.Screen.height / val_8) * ((float)UnityEngine.Screen.height / val_8);
        float val_9 = (float)UnityEngine.Screen.width;
        val_9 = val_9 / 0;
        if(UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished < 0)
        {
                val_8 = 0;
        }
        
        return (bool)val_8;
        label_2:
        val_8 = 0;
        return (bool)val_8;
    }
    public void HideBanner()
    {
        this.setBannerState = 2;
    }
    private void HideBannerFromMediation(bool destroy = False)
    {
        var val_2;
        var val_4;
        var val_5;
        var val_6;
        val_2 = null;
        val_2 = null;
        if(ApplovinMaxPlugin.initialized == false)
        {
                return;
        }
        
        if(ApplovinMaxPlugin.adUnitsSet == false)
        {
                return;
        }
        
        if(DeviceIdPlugin.IsEmulator() == true)
        {
                return;
        }
        
        val_4 = mem[R5];
        val_4 = R5;
        var val_2 = R5 + 186;
        val_2 = val_2 & 512;
        if(R4 != 0)
        {
                if((val_2 != 0) && ((R5 + 116) == 0))
        {
                val_5 = mem[R5];
            val_5 = R5;
        }
        
            MaxSdkAndroid.DestroyBanner(adUnitIdentifier:  R5 + 92 + 4);
            return;
        }
        
        if((val_2 != 0) && ((R5 + 116) == 0))
        {
                val_6 = mem[R5];
            val_6 = R5;
        }
        
        MaxSdkAndroid.HideBanner(adUnitIdentifier:  R5 + 92 + 4);
    }
    private System.Collections.IEnumerator InitializeBanners()
    {
        object val_1 = new System.Object();
        typeof(ApplovinMaxPlugin.<InitializeBanners>d__39).__il2cppRuntimeField_8 = 0;
        typeof(ApplovinMaxPlugin.<InitializeBanners>d__39).__il2cppRuntimeField_10 = this;
    }
    private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        TrackAdRevenuePaid(revenue:  null, adType:  adUnitId);
    }
    private void MaxSdkCallbacks_OnBannerAdLoadedEvent(string obj)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_2 = 26320662;
        val_2 = 9304876 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = null;
        val_3 = null;
        App.trackerManager.track(eventName:  Events.AD_SEEN_NON_REWARDED);
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        App.trackerManager.track(eventName:  Events.AD_SEEN_ALL);
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        App.trackerManager.track(eventName:  Events.AD_SEEN_BANNER);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1871191072, value:  -1871315440);
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        App.trackerManager.track(eventName:  -1871190992, data:  78753792);
    }
    private void MaxSdkCallbacks_OnBannerAdExpandedEvent(string obj)
    {
    
    }
    private void MaxSdkCallbacks_OnBannerAdCollapsedEvent(string obj)
    {
    
    }
    private void MaxSdkCallbacks_OnBannerAdClickedEvent(string obj)
    {
        var val_4;
        var val_5;
        var val_6;
        TrackingComponent.CurrentIntent = 3;
        WGGenericNotificationsManager.SendPostAdNotification(QAHACK_Force:  false);
        Player val_1 = App.Player;
        if(null != 0)
        {
                val_4 = null;
            val_5 = public System.Int32 UnityEngine.Object::GetHashCode();
        }
        else
        {
                val_4 = 204;
            val_5 = 4;
        }
        
        mem[204] = 5;
        Player val_2 = App.Player;
        if(5 <= 0)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  -1870830320, value:  1);
        }
        
        TrackAdsClicked();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1871191072, value:  -1871315440);
        var val_4 = 26319526;
        val_4 = 9306012 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        App.trackerManager.track(eventName:  -1870830224, data:  78753792);
    }
    private void MaxSdkCallbacks_OnBannerAdLoadFailedEvent(string arg1, int arg2)
    {
        this.setBannerState = 2;
        if(this.BannerAdsStateChanged == 0)
        {
                return;
        }
        
        this.BannerAdsStateChanged.Invoke(obj:  false);
    }
    public void SetIncentivizedVideoCallback(System.Action<bool> callback)
    {
        this.IncentivizedVideoCallback = callback;
    }
    public bool ShowVideo(HeyZapAdTag heyZapAdTag)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_5 = 0;
        if(this.hack_noVideoAdsAvailable == true)
        {
                return (bool)val_5;
        }
        
        this.currentVideoAdTag = heyZapAdTag;
        val_6 = 1152921504895930368;
        val_7 = null;
        val_7 = null;
        val_8 = 1152921504855195648;
        val_5 = 0;
        if((MaxSdkAndroid.IsRewardedAdReady(adUnitIdentifier:  ApplovinMaxPlugin.rewardedAdUnitId)) != false)
        {
                TrackingComponent.CurrentIntent = 3;
            this.PauseAudio(pause:  true);
            val_9 = null;
            val_9 = null;
            MaxSdkAndroid.ShowRewardedAd(adUnitIdentifier:  ApplovinMaxPlugin.rewardedAdUnitId);
            val_6 = 1152921504892043264;
            float val_5 = 5.347204E-38f;
            val_5 = 9308592 + val_5;
            if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_10 = null;
            val_10 = null;
            val_11 = null;
            val_11 = null;
            App.trackerManager.track(eventName:  Events.AD_SEEN_ALL);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1871191072, value:  -1870461360);
            HeyZapAdTag val_3 = this.currentVideoAdTag | 2;
            if(val_3 != 3)
        {
                this.currentVideoAdTag = this.currentVideoAdTag - 2;
        }
        
            if(val_3 != 3)
        {
                1 = this.currentVideoAdTag >> 5;
        }
        
            string val_4 = 1.ToString();
            Add(key:  -1870461280, value:  -1870449125);
            val_8 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511326344532] = ;
            Add(key:  -1870461184, value:  289402880);
            if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_12 = null;
            val_12 = null;
            App.trackerManager.track(eventName:  -1871190992, data:  78753792);
            val_5 = 1;
            return (bool)val_5;
        }
        
        mem[1152921511326344532] = val_5;
        return (bool)val_5;
    }
    public bool IsVideoAvailable()
    {
        null = null;
        bool val_1 = MaxSdkAndroid.IsRewardedAdReady(adUnitIdentifier:  ApplovinMaxPlugin.rewardedAdUnitId);
        if(val_1 == false)
        {
                val_1.LoadRewardedVideo();
        }
        
        return val_1;
    }
    public void Hack_NoVideoAdsAvailable()
    {
        bool val_1 = this.hack_noVideoAdsAvailable;
        val_1 = val_1 ^ 1;
        this.hack_noVideoAdsAvailable = val_1;
    }
    private System.Collections.IEnumerator InitializeRewardedVideos()
    {
        object val_1 = new System.Object();
        typeof(ApplovinMaxPlugin.<InitializeRewardedVideos>d__53).__il2cppRuntimeField_8 = 0;
        typeof(ApplovinMaxPlugin.<InitializeRewardedVideos>d__53).__il2cppRuntimeField_10 = this;
    }
    private void OnVideoRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adinfo)
    {
        TrackAdRevenuePaid(revenue:  null, adType:  adUnitId);
    }
    private void TrackAdRevenuePaid(double revenue, string adType)
    {
        WordPets.WPTPetTile val_1;
        var val_3;
        var val_4;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1869876416, value:  val_1);
        Add(key:  -1869876320, value:  10489856);
        Add(key:  -1869876224, value:  10489856);
        Add(key:  -1869876128, value:  13152256);
        Add(key:  1610240448, value:  10489856);
        var val_3 = 26321006;
        val_3 = 9304532 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        val_4 = null;
        val_4 = null;
        App.trackerManager.track(eventName:  Events.AD_REVENUE, data:  78753792);
    }
    private void LoadRewardedVideo()
    {
        null = null;
        MaxSdkAndroid.LoadRewardedAd(adUnitIdentifier:  ApplovinMaxPlugin.rewardedAdUnitId);
    }
    private void MaxSdkCallbacks_OnRewardedAdDisplayedEvent(string obj)
    {
    
    }
    private void OnVideoLoaded(string adUnitId)
    {
        if(this.RewardVideoLoaded == 0)
        {
                return;
        }
        
        this.RewardVideoLoaded.Invoke(obj:  true);
    }
    private void OnVideoHidden(string adUnitId)
    {
        this.LoadRewardedVideo();
        this.PauseAudio(pause:  false);
    }
    private void OnVideoLoadFailed(string adUnitId, int errorCode)
    {
        if(this.RewardVideoLoaded != 0)
        {
                this.RewardVideoLoaded.Invoke(obj:  false);
        }
        
        this.Invoke(methodName:  1675591632, time:  null);
    }
    private void OnVideoFailedToShow(string adUnitId, int errorCode)
    {
        this.LoadRewardedVideo();
    }
    private void OnVideoClicked(string adUnitId)
    {
        var val_4;
        var val_5;
        var val_6;
        TrackingComponent.CurrentIntent = 3;
        WGGenericNotificationsManager.SendPostAdNotification(QAHACK_Force:  false);
        Player val_1 = App.Player;
        if(null != 0)
        {
                val_4 = null;
            val_5 = public System.Int32 UnityEngine.Object::GetHashCode();
        }
        else
        {
                val_4 = 204;
            val_5 = 4;
        }
        
        mem[204] = 5;
        Player val_2 = App.Player;
        if(5 <= 0)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  -1870830320, value:  1);
        }
        
        TrackAdsClicked();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1871191072, value:  -1870461360);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        Add(key:  -1870461184, value:  289402880);
        var val_4 = 26314770;
        val_4 = 9310768 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        App.trackerManager.track(eventName:  -1870830224, data:  78753792);
    }
    private void OnVideoRewardReceived(string adUnitId, MaxSdkBase.Reward reward)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        if(this.IncentivizedVideoCallback != 0)
        {
                this.IncentivizedVideoCallback.Invoke(obj:  true);
        }
        
        var val_2 = 26314446;
        val_2 = 9311092 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = null;
        val_3 = null;
        App.trackerManager.track(eventName:  Events.AD_SEEN_REW_VID);
        Player val_1 = App.Player;
        val_4 = mem[App.trackerManager + 44];
        val_4 = App.trackerManager + 44;
        if(val_4 != 0)
        {
                val_5 = mem[App.trackerManager + 44 + 92];
            val_5 = App.trackerManager + 44 + 92;
        }
        else
        {
                val_4 = 92;
            val_5 = 0;
        }
        
        mem[92] = 1;
        this.LoadRewardedVideo();
        this.PauseAudio(pause:  false);
        this.TrackRewardVidsSeen();
    }
    public void SetInterstitialCallback(System.Action<bool> action)
    {
        this.InterstitialCallback = action;
    }
    public void CheckInterstitialAvailable()
    {
        var val_3;
        if(DeviceIdPlugin.IsEmulator() == true)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        bool val_2 = MaxSdkAndroid.IsInterstitialReady(adUnitIdentifier:  ApplovinMaxPlugin.interstitialAdUnitId);
        if(val_2 != false)
        {
                return;
        }
        
        val_2.LoadInterstitial();
    }
    public bool ShowInterstitial(InterstitialContext context = 2)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_7 = 0;
        if(DeviceIdPlugin.IsEmulator() == true)
        {
                return (bool)val_7;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = 0;
        if((MaxSdkAndroid.IsInterstitialReady(adUnitIdentifier:  ApplovinMaxPlugin.interstitialAdUnitId)) == false)
        {
                return (bool)val_7;
        }
        
        float val_7 = 5.343648E-38f;
        val_7 = 9314936 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = null;
        val_10 = null;
        App.trackerManager.track(eventName:  Events.AD_SEEN_ALL);
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        App.trackerManager.track(eventName:  Events.AD_SEEN_NON_REWARDED);
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        App.trackerManager.track(eventName:  Events.AD_SEEN_INT);
        App.trackerManager.PauseAudio(pause:  true);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1871191072, value:  -1868545728);
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        App.trackerManager.track(eventName:  -1871190992, data:  78753792);
        TrackingComponent.CurrentIntent = 3;
        Player val_4 = App.Player;
        if(3 <= 29)
        {
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_14 = null;
            val_14 = null;
            AdInfo val_6 = MaxSdkAndroid.GetAdInfo(adUnitIdentifier:  ApplovinMaxPlugin.interstitialAdUnitId);
            Add(key:  -1868545632, value:  ApplovinMaxPlugin.interstitialAdUnitId + 24);
            if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
            val_15 = null;
            val_15 = null;
            App.trackerManager.track(eventName:  -1868545536, data:  78753792);
        }
        
        val_16 = null;
        val_16 = null;
        MaxSdkAndroid.ShowInterstitial(adUnitIdentifier:  ApplovinMaxPlugin.interstitialAdUnitId);
        val_7 = 1;
        return (bool)val_7;
    }
    private System.Collections.IEnumerator InitializeInterstitials()
    {
        object val_1 = new System.Object();
        typeof(ApplovinMaxPlugin.<InitializeInterstitials>d__68).__il2cppRuntimeField_8 = 0;
        typeof(ApplovinMaxPlugin.<InitializeInterstitials>d__68).__il2cppRuntimeField_10 = this;
    }
    private void LoadInterstitial()
    {
        if(ApplovinMaxPlugin.initialized == false)
        {
                return;
        }
        
        null = null;
        if(ApplovinMaxPlugin.adUnitsSet == false)
        {
                return;
        }
        
        MaxSdkAndroid.LoadInterstitial(adUnitIdentifier:  ApplovinMaxPlugin.interstitialAdUnitId);
    }
    private void OnInterstitialLoaded(string adUnit)
    {
    
    }
    private void OnInterstitialFailed(string adUnit, int errorCode)
    {
        this.Invoke(methodName:  -1868081040, time:  null);
    }
    private void OnInterstitialFailedToDisplay(string adUnit, int errorCode)
    {
        this.Invoke(methodName:  -1868081040, time:  null);
        this.InterstitialCallback.Invoke(obj:  false);
    }
    private void OnInterstitialHidden(string adUnit)
    {
        this.Invoke(methodName:  -1868081040, time:  null);
        this.PauseAudio(pause:  false);
        this.InterstitialCallback.Invoke(obj:  false);
    }
    private void OnInterstitialDisplayedEvent(string adUnit)
    {
        this.InterstitialCallback.Invoke(obj:  true);
    }
    private void OnInterstitialClicked(string adUnitClicked)
    {
        var val_4;
        var val_5;
        var val_6;
        TrackingComponent.CurrentIntent = 3;
        WGGenericNotificationsManager.SendPostAdNotification(QAHACK_Force:  false);
        Player val_1 = App.Player;
        if(null != 0)
        {
                val_4 = null;
            val_5 = public System.Int32 UnityEngine.Object::GetHashCode();
        }
        else
        {
                val_4 = 204;
            val_5 = 4;
        }
        
        mem[204] = 5;
        Player val_2 = App.Player;
        if(5 <= 0)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  -1870830320, value:  1);
        }
        
        TrackAdsClicked();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1871191072, value:  -1868545728);
        var val_4 = 26308190;
        val_4 = 9317348 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        App.trackerManager.track(eventName:  -1870830224, data:  78753792);
    }
    private void OnInterstitialAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        TrackAdRevenuePaid(revenue:  null, adType:  adUnitId);
    }
    private void TrackAdsClicked()
    {
        var val_15;
        var val_16;
        TrackerManager val_17;
        string val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        Player val_1 = App.Player;
        if((public System.Int32 UnityEngine.Object::GetHashCode()) == 5)
        {
                var val_14 = 26319178;
            val_14 = 9306360 + val_14;
            if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
            val_15 = null;
            val_15 = null;
            val_16 = null;
            val_17 = App.trackerManager;
            val_16 = null;
            val_18 = Events.AD_CLICK_05;
        }
        else
        {
                Player val_3 = App.Player;
            if((public System.Int32 UnityEngine.Object::GetHashCode()) == 10)
        {
                var val_15 = 26318938;
            val_15 = 9306600 + val_15;
            if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
            val_19 = null;
            val_19 = null;
            val_20 = null;
            val_17 = App.trackerManager;
            val_20 = null;
            val_18 = Events.AD_CLICK_10;
        }
        else
        {
                Player val_5 = App.Player;
            if((public System.Int32 UnityEngine.Object::GetHashCode()) == 15)
        {
                var val_16 = 26318698;
            val_16 = 9306840 + val_16;
            if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
            val_21 = null;
            val_21 = null;
            val_22 = null;
            val_17 = App.trackerManager;
            val_22 = null;
            val_18 = Events.AD_CLICK_15;
        }
        else
        {
                Player val_7 = App.Player;
            if((public System.Int32 UnityEngine.Object::GetHashCode()) == 20)
        {
                var val_17 = 26318458;
            val_17 = 9307080 + val_17;
            if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
            val_23 = null;
            val_23 = null;
            val_24 = null;
            val_17 = App.trackerManager;
            val_24 = null;
            val_18 = Events.AD_CLICK_20;
        }
        else
        {
                Player val_9 = App.Player;
            if((public System.Int32 UnityEngine.Object::GetHashCode()) == 30)
        {
                var val_18 = 26318218;
            val_18 = 9307320 + val_18;
            if(val_18 == 0)
        {
                mem2[0] = 1;
        }
        
            val_25 = null;
            val_25 = null;
            val_26 = null;
            val_17 = App.trackerManager;
            val_26 = null;
            val_18 = Events.AD_CLICK_30;
        }
        else
        {
                Player val_11 = App.Player;
            if((public System.Int32 UnityEngine.Object::GetHashCode()) == 50)
        {
                var val_19 = 26317978;
            val_19 = 9307560 + val_19;
            if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
            val_27 = null;
            val_27 = null;
            val_28 = null;
            val_17 = App.trackerManager;
            val_28 = null;
            val_18 = Events.AD_CLICK_50;
        }
        else
        {
                Player val_13 = App.Player;
            if((public System.Int32 UnityEngine.Object::GetHashCode()) != 100)
        {
                return;
        }
        
            var val_20 = 26317742;
            val_20 = 9307796 + val_20;
            if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
            val_29 = mem[R5];
            val_29 = R5;
            if((((R5 + 187) & 2) == 0) && ((R5 + 116) == 0))
        {
                val_29 = mem[R5];
            val_29 = R5;
        }
        
            val_30 = null;
            val_17 = mem[R5 + 92 + 60];
            val_17 = R5 + 92 + 60;
            val_30 = null;
            val_18 = Events.AD_CLICK_100;
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        val_17.track(eventName:  val_18);
    }
    private void TrackRewardVidsSeen()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        Player val_1 = App.Player;
        var val_10 = 26313990;
        val_10 = 9311548 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = null;
        val_11 = null;
        App.trackerManager.track(eventName:  Events.REW_VID_05);
        Player val_2 = App.Player;
        var val_11 = 26313706;
        val_11 = 9311832 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = null;
        val_13 = null;
        App.trackerManager.track(eventName:  Events.REW_VID_10);
        Player val_3 = App.Player;
        var val_12 = 26313422;
        val_12 = 9312116 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = null;
        val_15 = null;
        App.trackerManager.track(eventName:  Events.REW_VID_15);
        Player val_4 = App.Player;
        var val_13 = 26313138;
        val_13 = 9312400 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = null;
        val_17 = null;
        App.trackerManager.track(eventName:  Events.REW_VID_20);
        Player val_5 = App.Player;
        var val_14 = 26312854;
        val_14 = 9312684 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_18 = null;
        val_18 = null;
        val_19 = null;
        val_19 = null;
        App.trackerManager.track(eventName:  Events.REW_VID_25);
        Player val_6 = App.Player;
        var val_15 = 26312570;
        val_15 = 9312968 + val_15;
        if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        val_20 = null;
        val_20 = null;
        val_21 = null;
        val_21 = null;
        App.trackerManager.track(eventName:  Events.REW_VID_50);
        Player val_7 = App.Player;
        var val_16 = 26312286;
        val_16 = 9313252 + val_16;
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = null;
        val_23 = null;
        App.trackerManager.track(eventName:  Events.REW_VID_100);
        Player val_8 = App.Player;
        var val_17 = 26312002;
        val_17 = 9313536 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_24 = null;
        val_24 = null;
        val_25 = null;
        val_25 = null;
        App.trackerManager.track(eventName:  Events.REW_VID_250);
        Player val_9 = App.Player;
        var val_18 = 26311718;
        val_18 = 9313820 + val_18;
        if(val_18 == 0)
        {
                mem2[0] = 1;
        }
        
        val_26 = null;
        val_26 = null;
        val_27 = null;
        val_27 = null;
        App.trackerManager.track(eventName:  Events.REW_VID_500);
    }
    public ApplovinMaxPlugin()
    {
        float val_3;
        this.currentBannerState = 2;
        this.setBannerState = 2;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
        UnityEngine.Rect val_4 = new UnityEngine.Rect(position:  new UnityEngine.Vector2(), size:  new UnityEngine.Vector2() {x = val_3});
    }
    private static ApplovinMaxPlugin()
    {
        ApplovinMaxPlugin.frameSkipValue = 90;
        ApplovinMaxPlugin.bannerAdUnitId = "";
        ApplovinMaxPlugin.rewardedAdUnitId = "";
        ApplovinMaxPlugin.interstitialAdUnitId = "";
        ApplovinMaxPlugin.adUnitsSet = false;
        ApplovinMaxPlugin.initialized = false;
        ApplovinMaxPlugin.bannersFetched = false;
    }

}
