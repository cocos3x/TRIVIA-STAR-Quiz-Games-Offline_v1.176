using UnityEngine;
public class AdsManager : MonoSingletonSelfGenerating<AdsManager>
{
    // Fields
    private AdConfig videoConfig;
    private AdConfig bannerConfig;
    private AdConfig interstitialConfig;
    public static int playerLevel_gotd;
    private int cooldownMonths;
    private int cooldownHours;
    private int requiredVideos;
    private int nonClickerThreshold;
    private bool _offersEnabled;
    private bool _surveysEnabled;
    private int _surveyRequestLevel;
    private int _offerwallRequestLevel;
    private int _applovinRefreshRate;
    private bool rewVidCapInitd;
    private int _rewardedVideoCap;
    private int _videosWatchedToday;
    private System.DateTime lastCheckedVideoCap;
    private bool initialized;
    private const string KEY_INTERSTITIAL_LEVEL = "PP_tu6zxj0";
    private const string KEY_VIDEO_LEVEL = "PP_myzp291";
    private const string KEY_BANNER_LEVEL = "PP_93k016x";
    private const string ADS_UNLOCK_LVL = "25";
    private const string ADS_WATCHED_COUNT_PREF = "wg_ads_watched_count";
    private const string ADS_WATCHED_COOLDOWN_PREF = "wg_ads_watched_cooldown";
    private int ads_watched_count;
    private System.DateTime ads_watched_cooldown_end;
    private System.Collections.Generic.List<string> AdsEventsList;
    
    // Properties
    public static int CooldownMonths { get; }
    public static int CooldownHours { get; }
    public static int RequiredVideos { get; }
    public static int getNonClickerThreshold { get; }
    public static int noAdsStartLevel { get; set; }
    public static bool offersEnabled { get; }
    public static bool surveysEnabled { get; }
    public static int SurveyRequestLevel { get; }
    public static int OfferwallRequestLevel { get; }
    public static int ApplovinRefreshRate { get; }
    public int rewardedVideoCap { get; }
    private int pstTimeOffet { get; }
    public System.DateTime offsetServerTime { get; }
    public bool rewardVideoCapReached { get; }
    public int InterstitialSeconds { get; }
    public static bool isInPurchaseCooldown { get; }
    public static System.DateTime LastPurchaseCooldownEnd { get; }
    public static bool isInVideoCooldown { get; }
    public static System.DateTime AdsCooldownEnd { get; }
    public static bool AdsCanShow { get; }
    public static bool AdsAllowedByScene { get; }
    private int AdsWatchedCount { get; set; }
    public static int AdsWatched { get; set; }
    public System.DateTime AdsWatchedCooldownEnd { get; set; }
    public System.Collections.Generic.List<string> AdsEventsFromAPI { get; }
    
    // Methods
    public static int get_CooldownMonths()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_18;
        }
        
        return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_18;
    }
    public static int get_CooldownHours()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_1C;
        }
        
        return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_1C;
    }
    public static int get_RequiredVideos()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_20;
        }
        
        return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_20;
    }
    public static int get_getNonClickerThreshold()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_24;
        }
        
        return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_24;
    }
    public static int get_noAdsStartLevel()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1900232464, defaultValue:  0);
    }
    public static void set_noAdsStartLevel(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1900232464, value:  value);
    }
    public static bool get_offersEnabled()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return (bool)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_28;
        }
        
        return (bool)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_28;
    }
    public static bool get_surveysEnabled()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return (bool)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_29;
        }
        
        return (bool)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_29;
    }
    public static int get_SurveyRequestLevel()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_2C;
        }
        
        return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_2C;
    }
    public static int get_OfferwallRequestLevel()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_30;
        }
        
        return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_30;
    }
    public static int get_ApplovinRefreshRate()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_34;
        }
        
        return (int)public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_34;
    }
    public int get_rewardedVideoCap()
    {
        return (int)this._rewardedVideoCap;
    }
    private int get_pstTimeOffet()
    {
        return 17;
    }
    public System.DateTime get_offsetServerTime()
    {
        var val_8;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                val_8 = 0;
            System.DateTime val_3 = DateTimeCheat.UtcNow;
        }
        else
        {
                val_8 = 0;
            System.DateTime val_4 = ServerHandler.ServerTime;
        }
        
        System.DateTime val_7 = this.AddHours(value:  null);
        return new System.DateTime() {dateData = val_7.dateData};
    }
    public bool get_rewardVideoCapReached()
    {
        ulong val_6;
        ulong val_8;
        if(this._rewardedVideoCap == 1)
        {
                return true;
        }
        
        System.DateTime val_1 = Date;
        System.DateTime val_2 = offsetServerTime;
        System.DateTime val_5 = Date;
        if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = val_8}, d2:  new System.DateTime() {dateData = val_6})) != false)
        {
                this._videosWatchedToday = 0;
            System.DateTime val_11 = offsetServerTime;
            this.lastCheckedVideoCap = val_8;
            this.SaveWatchedVideos();
        }
        
        if(this._videosWatchedToday >= this._rewardedVideoCap)
        {
                0 = 1;
        }
        
        return true;
    }
    public int get_InterstitialSeconds()
    {
        if(this.interstitialConfig != 0)
        {
                return (int)this.interstitialConfig.InterstitialSeconds;
        }
        
        return (int)this.interstitialConfig.InterstitialSeconds;
    }
    private void Awake()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1898833536, name:  -2037002944);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1898833536, name:  -1898880160);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1898833536, name:  2128120864);
        CompanyDevices val_4 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396087232));
        MaxSdkCallbacks.add_OnSdkInitializedEvent(value:  7401472);
        System.Action val_7 = new System.Action(object:  -1898833536, method:  new IntPtr(2396089280));
        MaxSdkCallbacks.add_OnVariablesUpdatedEvent(value:  7454720);
        System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396090304));
        MaxSdkCallbacks.add_OnBannerAdLoadedEvent(value:  7401472);
        System.Action<System.String, System.Int32> val_9 = new System.Action<System.String, System.Int32>(object:  -1898833536, method:  new IntPtr(2396091328));
        MaxSdkCallbacks.add_OnBannerAdLoadFailedEvent(value:  7507968);
        System.Action<twelvegigs.storage.JsonDictionary> val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396092352));
        MaxSdkCallbacks.add_OnBannerAdClickedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_11 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396093376));
        MaxSdkCallbacks.add_OnBannerAdExpandedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_12 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396094400));
        MaxSdkCallbacks.add_OnBannerAdCollapsedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_13 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396095424));
        MaxSdkCallbacks.add_OnInterstitialLoadedEvent(value:  7401472);
        System.Action<System.String, System.Int32> val_14 = new System.Action<System.String, System.Int32>(object:  -1898833536, method:  new IntPtr(2396096448));
        MaxSdkCallbacks.add_OnInterstitialLoadFailedEvent(value:  7507968);
        System.Action<twelvegigs.storage.JsonDictionary> val_15 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396097472));
        MaxSdkCallbacks.add_OnInterstitialHiddenEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_16 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396098496));
        MaxSdkCallbacks.add_OnInterstitialDisplayedEvent(value:  7401472);
        System.Action<System.String, System.Int32> val_17 = new System.Action<System.String, System.Int32>(object:  -1898833536, method:  new IntPtr(2396099520));
        MaxSdkCallbacks.add_OnInterstitialAdFailedToDisplayEvent(value:  7507968);
        System.Action<twelvegigs.storage.JsonDictionary> val_18 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396100544));
        MaxSdkCallbacks.add_OnInterstitialClickedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_19 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396101568));
        MaxSdkCallbacks.add_OnRewardedAdLoadedEvent(value:  7401472);
        System.Action<System.String, System.Int32> val_20 = new System.Action<System.String, System.Int32>(object:  -1898833536, method:  new IntPtr(2396102592));
        MaxSdkCallbacks.add_OnRewardedAdLoadFailedEvent(value:  7507968);
        System.Action<twelvegigs.storage.JsonDictionary> val_21 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396103616));
        MaxSdkCallbacks.add_OnRewardedAdDisplayedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_22 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396104640));
        MaxSdkCallbacks.add_OnRewardedAdHiddenEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_23 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1898833536, method:  new IntPtr(2396105664));
        MaxSdkCallbacks.add_OnRewardedAdClickedEvent(value:  7401472);
        System.Action<System.String, System.Int32> val_24 = new System.Action<System.String, System.Int32>(object:  -1898833536, method:  new IntPtr(2396106688));
        MaxSdkCallbacks.add_OnRewardedAdFailedToDisplayEvent(value:  7507968);
        System.Action<System.String, Reward> val_25 = new System.Action<System.String, Reward>(object:  -1898833536, method:  new IntPtr(2396107712));
        MaxSdkCallbacks.add_OnRewardedAdReceivedRewardEvent(value:  7507968);
    }
    private void OnDeferredReady()
    {
        this.ReadFromKnobs();
    }
    private void OnServerSync()
    {
        this.ReadFromKnobs();
        this.InitVideoCap();
    }
    private void Initialize()
    {
        if(this.initialized == true)
        {
                return;
        }
        
        R4.ReadFromKnobs();
        mem2[0] = 1;
    }
    private void ReadFromKnobs()
    {
        AdsManager val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        val_48 = this;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1898409536, defaultValue:  -2040381152);
        object val_2 = MiniJSON.Json.Deserialize(json:  -1898409536);
        if("ad_display" != 0)
        {
                if(null == null)
        {
            goto label_28;
        }
        
        }
        
        label_28:
        Dictionary.KeyCollection<TKey, TValue> val_3 = 0.Keys;
        if(0.Count < 2)
        {
            goto label_5;
        }
        
        if((0.ContainsKey(key:  -1898408416)) != false)
        {
                string val_6 = 0.Item[-1898408416];
            val_49 = null;
            val_49 = null;
            bool val_8 = System.Int32.TryParse(s:  null, result: out  int val_7 = 288555008);
        }
        
        if((0.ContainsKey(key:  -1898408288)) != false)
        {
                string val_10 = 0.Item[-1898408288];
            bool val_12 = System.Int32.TryParse(s:  null, result: out  this.nonClickerThreshold);
        }
        
        if((0.ContainsKey(key:  -1898408160)) != false)
        {
                string val_14 = 0.Item[-1898408160];
            bool val_16 = System.Int32.TryParse(s:  null, result: out  this._applovinRefreshRate);
        }
        
        object val_17 = AdSegmentation.GetSegementedConfig(key:  -1898408080, knobs:  0, addSegment:  true);
        if("banner_ads" == 0)
        {
            goto label_20;
        }
        
        if(null == null)
        {
            goto label_22;
        }
        
        string val_18 = 0.Item[-1987367680];
        if(0 != 0)
        {
                string val_19 = 0.Item[-1987367680];
            val_50 = 0;
        }
        else
        {
                val_50 = "true";
        }
        
        this.bannerConfig.Enabled = System.Boolean.Parse(value:  1295406192);
        string val_21 = 0.Item[-1988561632];
        if(0 != 0)
        {
                string val_22 = 0.Item[-1988561632];
            val_48 = val_48;
            val_51 = 0;
        }
        else
        {
                val_48 = val_48;
            val_51 = "1";
        }
        
        this.bannerConfig.UnlockLevel = System.Int32.Parse(s:  1633189168, style:  511);
        label_20:
        object val_24 = AdSegmentation.GetSegementedConfig(key:  -1898403888, knobs:  0, addSegment:  true);
        if("interstitial_ads" == 0)
        {
            goto label_89;
        }
        
        if(null == null)
        {
            goto label_41;
        }
        
        string val_25 = 0.Item[-1898403776];
        if(0 != 0)
        {
                string val_26 = 0.Item[-1898403776];
            val_52 = 0;
        }
        else
        {
                val_52 = "true";
        }
        
        string val_28 = 0.Item[-1898403680];
        if(0 != 0)
        {
                string val_29 = 0.Item[-1898403680];
            val_53 = 0;
        }
        else
        {
                val_53 = "true";
        }
        
        string val_31 = 0.Item[-1898403584];
        string val_32 = 0.Item[-1987367680];
        if(0 != 0)
        {
                string val_33 = 0.Item[-1987367680];
            val_54 = 0;
        }
        else
        {
                val_54 = "true";
        }
        
        string val_35 = 0.Item[-1988561632];
        if(0 != 0)
        {
                string val_36 = 0.Item[-1988561632];
            val_55 = 0;
        }
        else
        {
                val_55 = "8";
        }
        
        mem2[0] = System.Int32.Parse(s:  1635473616, style:  511);
        string val_38 = 0.Item[-1898403488];
        if(0 != 0)
        {
                string val_39 = 0.Item[-1898403488];
            val_48 = val_48;
            val_56 = 0;
        }
        else
        {
                val_48 = val_48;
            val_56 = "60";
        }
        
        mem2[0] = System.Int32.Parse(s:  -1898403392, style:  511);
        System.Collections.Generic.List<WordPets.WordPetType> val_41 = new System.Collections.Generic.List<WordPets.WordPetType>();
        mem2[0] = null;
        if((System.Boolean.Parse(value:  1295406192)) != false)
        {
                mem[1152921511298408516] + 32.Add(item:  3);
        }
        
        if((System.Boolean.Parse(value:  1295406192)) != false)
        {
                mem[1152921511298408516] + 32.Add(item:  1);
        }
        
        if((System.Boolean.Parse(value:  1295406192)) != false)
        {
                mem[1152921511298408516] + 32.Add(item:  2);
        }
        
        label_89:
        object val_42 = AdSegmentation.GetSegementedConfig(key:  -1898401264, knobs:  0, addSegment:  true);
        if("video_ads" != 0)
        {
                if(null != null)
        {
                string val_43 = 0.Item[-1987367680];
            if(0 != 0)
        {
                string val_44 = 0.Item[-1987367680];
            val_57 = 0;
        }
        else
        {
                val_57 = "true";
        }
        
            mem2[0] = System.Boolean.Parse(value:  1295406192);
            string val_46 = 0.Item[-1988561632];
            if(0 != 0)
        {
                string val_47 = 0.Item[-1988561632];
            if(0 != 0)
        {
            goto label_108;
        }
        
        }
        
        }
        
        }
    
    }
    private void InitVideoCap()
    {
        var val_6;
        System.DateTime val_14;
        ulong val_21;
        ulong val_23;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_27;
        var val_28;
        if(this.rewVidCapInitd == true)
        {
                return;
        }
        
        this.rewVidCapInitd = true;
        this.CalculateCurrentVideoCap();
        val_27 = null;
        val_27 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if((CPlayerPrefs.HasKey(key:  -1898276880)) != false)
        {
                val_27 = 0;
            string val_3 = CPlayerPrefs.GetString(key:  -1898276880);
            object val_4 = MiniJSON.Json.Deserialize(json:  -1898276880);
            if("rewVidCap" != 0)
        {
                if(null != null)
        {
                "rewVidCap" = 0;
        }
        
            val_27 = "rewVidCap";
        }
        
        }
        
        System.DateTime val_5 = offsetServerTime;
        string val_8 = val_6.ToString();
        object val_9 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  0, key:  -1898276784, defaultValue:  -1898263632);
        val_28 = val_27;
        System.DateTime val_10 = System.DateTime.UtcNow;
        System.DateTime val_13 = SLCDateTime.Parse(dateTime:  -1898263656, defaultValue:  new System.DateTime());
        System.DateTime val_16 = Date;
        System.DateTime val_17 = offsetServerTime;
        System.DateTime val_20 = Date;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_23}, d2:  new System.DateTime() {dateData = val_21})) != false)
        {
                val_6 = 0;
            object val_26 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  0, key:  -1898275680, defaultValue:  13152256);
            val_28 = null;
            val_27.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this._videosWatchedToday = 1179403647;
        }
        else
        {
                this._videosWatchedToday = 0;
        }
        
        this.lastCheckedVideoCap = val_14;
    }
    private void CalculateCurrentVideoCap()
    {
        var val_11;
        var val_12;
        int val_13;
        Player val_1 = App.Player;
        if(188 == 0)
        {
            goto label_4;
        }
        
        Player val_3 = App.Player;
        if(188 != 1)
        {
            goto label_12;
        }
        
        Player val_4 = App.Player;
        if(0 >= 0)
        {
            goto label_12;
        }
        
        GameEcon val_5 = App.getGameEcon;
        val_11 = 0;
        val_12 = 1140;
        goto label_24;
        label_12:
        Player val_6 = App.Player;
        if(188 != 1)
        {
            goto label_20;
        }
        
        GameEcon val_8 = App.getGameEcon;
        val_11 = 0;
        val_12 = 1144;
        goto label_24;
        label_4:
        GameEcon val_9 = App.getGameEcon;
        val_13 = 1136;
        goto label_28;
        label_20:
        GameEcon val_10 = App.getGameEcon;
        val_11 = 0;
        val_12 = 1148;
        label_24:
        val_13 = val_11 + 1148;
        label_28:
        this._rewardedVideoCap = val_13;
    }
    private void SaveWatchedVideos()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.DateTime val_2 = offsetServerTime;
        Add(key:  -1898276784, value:  9904128);
        Add(key:  -1898275680, value:  13152256);
        string val_5 = MiniJSON.Json.Serialize(obj:  78753792);
        CPlayerPrefs.SetString(key:  -1898276880, val:  78753792);
        CPlayerPrefs.Save();
    }
    public bool InterstitialEnabled()
    {
        var val_7;
        AdConfig val_8;
        var val_9;
        val_7 = 0;
        if(this.AdsAllowed() == false)
        {
                return (bool)val_7;
        }
        
        val_8 = this.interstitialConfig;
        if(this.interstitialConfig.Enabled == false)
        {
                return (bool)val_7;
        }
        
        val_9 = 1152921504892043264;
        GameBehavior val_2 = App.getBehavior;
        val_8 = 0;
        val_7 = 0;
        if(0 < this.interstitialConfig.UnlockLevel)
        {
                return (bool)val_7;
        }
        
        if(AdsManager.noAdsStartLevel >= 0)
        {
                Player val_4 = App.Player;
            val_8 = AdsManager.noAdsStartLevel;
            val_7 = 0;
            GameEcon val_6 = App.getGameEcon;
            val_9 = 0;
            var val_7 = 136;
            val_7 = val_7 + val_8;
            if(0 < val_7)
        {
                return (bool)val_7;
        }
        
        }
        
        AdsManager.noAdsStartLevel = 0;
        val_7 = 1;
        return (bool)val_7;
    }
    public bool InterstitialContextEnabled(InterstitialContext context)
    {
        ulong val_5;
        var val_8;
        InterstitialContext val_12;
        var val_13;
        val_12 = context;
        val_13 = 0;
        if(this.InterstitialEnabled() == false)
        {
                return (bool)val_13;
        }
        
        if((this.interstitialConfig.AllowedContext.Contains(item:  val_12)) == false)
        {
                return (bool)val_13;
        }
        
        if(DeviceIdPlugin.IsEmulator() == false)
        {
                val_13 = 1;
        }
        
        if(val_12 != 2)
        {
                return (bool)val_13;
        }
        
        System.DateTime val_4 = ServerHandler.ServerTime;
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511299007912}, d2:  new System.DateTime() {dateData = val_5});
        double val_10 = val_8.TotalSeconds;
        if(this.interstitialConfig < 0)
        {
                return (bool)val_13;
        }
        
        System.DateTime val_11 = ServerHandler.ServerTime;
        this.interstitialConfig.LastInterstitial = val_5;
        return (bool)val_13;
    }
    public bool VideoEnabledAndUnlocked()
    {
        if(this.videoConfig.Enabled == false)
        {
                return false;
        }
        
        return this.VideoAllowedAndUnlocked();
    }
    private bool VideoAllowedAndUnlocked()
    {
        var val_5;
        var val_6;
        val_5 = 0;
        if(this.VideoAdsAllowed() == false)
        {
                return (bool)val_5;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                val_5 = 1;
            if((WADPetsManager.GetUnlockedPetByAbility(ability:  4)) == true)
        {
                return (bool)val_5;
        }
        
        }
        
        var val_5 = 24697327;
        val_5 = 10928460 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = 1;
        if(App.game == 20)
        {
                return (bool)val_5;
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 >= this.videoConfig.UnlockLevel)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool BannerEnabled()
    {
        var val_9;
        AdConfig val_10;
        var val_11;
        val_9 = 0;
        if(this.AdsAllowed() == false)
        {
                return (bool)val_9;
        }
        
        val_10 = this.bannerConfig;
        if(this.bannerConfig.Enabled == false)
        {
                return (bool)val_9;
        }
        
        val_11 = 1152921504892043264;
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
                GameBehavior val_3 = App.getBehavior;
            val_10 = 0;
            val_9 = 0;
            if(0 < this.bannerConfig.UnlockLevel)
        {
                return (bool)val_9;
        }
        
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 == 0)
        {
                if(AdsManager.noAdsStartLevel >= 0)
        {
                Player val_6 = App.Player;
            val_10 = AdsManager.noAdsStartLevel;
            val_9 = 0;
            GameEcon val_8 = App.getGameEcon;
            val_11 = 0;
            var val_9 = 136;
            val_9 = val_9 + val_10;
            if(0 < val_9)
        {
                return (bool)val_9;
        }
        
        }
        
        }
        
        AdsManager.noAdsStartLevel = 0;
        val_9 = 1;
        return (bool)val_9;
    }
    public bool AdsAllowed()
    {
        var val_11;
        var val_12;
        val_11 = 0;
        Player val_1 = App.Player;
        if(0.RemovedAds == true)
        {
                return (bool)val_11;
        }
        
        val_12 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = 0;
            if(hasAnySubscription() == true)
        {
                return (bool)val_11;
        }
        
        }
        
        val_11 = 0;
        if(DeviceIdPlugin.IsEmulator() == true)
        {
                return (bool)val_11;
        }
        
        val_12 = 1152921511213660528;
        WGBonusRewardsHandler val_8 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((-1983121040) != 0)
        {
                WGBonusRewardsHandler val_10 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        }
        
        val_11 = 1;
        return (bool)val_11;
    }
    private bool VideoAdsAllowed()
    {
        if(DeviceIdPlugin.IsEmulator() == true)
        {
                return (bool)0;
        }
        
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((-1983121040) != 0)
        {
                WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        }
        
        0 = 1;
        return (bool)0;
    }
    private bool AnyAdsLevelReached()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 >= (UnityEngine.Mathf.Min(a:  this.interstitialConfig.UnlockLevel, b:  this.bannerConfig.UnlockLevel)))
        {
                0 = 1;
        }
        
        return true;
    }
    public bool AdsControlEnabled()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return false;
        }
        
        if(this.AdsAllowed() == false)
        {
                return false;
        }
        
        return this.AnyAdsLevelReached();
    }
    public static void AddNoAdsCooldown(double seconds)
    {
        var val_6;
        var val_7;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        Player val_1 = App.Player;
        val_12 = 0;
        if(AdsManager.isInPurchaseCooldown != false)
        {
                Player val_3 = App.Player;
            val_12 = 0;
            var val_4 = 2621448 + 144;
            System.DateTime val_5 = AddSeconds(value:  seconds);
            val_13 = val_6;
            val_14 = val_7;
        }
        else
        {
                System.DateTime val_8 = ServerHandler.ServerTime;
            System.DateTime val_9 = AddSeconds(value:  seconds);
            val_13 = val_10;
            val_14 = val_11;
        }
        
        WordPets.WPTDataParser val_12 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        CalculateCurrentVideoCap();
    }
    public static void HandlePurchase()
    {
        var val_6;
        var val_7;
        var val_12;
        var val_13;
        Player val_1 = App.Player;
        if(AdsManager.isInPurchaseCooldown != false)
        {
                Player val_3 = App.Player;
            int val_12 = 2621448;
            val_12 = val_12 + 144;
            int val_4 = AdsManager.CooldownMonths;
            System.DateTime val_5 = AddMonths(months:  val_12);
            val_12 = val_6;
            val_13 = val_7;
        }
        else
        {
                System.DateTime val_8 = ServerHandler.ServerTime;
            int val_9 = AdsManager.CooldownMonths;
            System.DateTime val_10 = AddMonths(months:  -1896690880);
        }
        
        WordPets.WPTDataParser val_11 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        CalculateCurrentVideoCap();
    }
    public static bool get_isInPurchaseCooldown()
    {
        ulong val_6;
        Player val_1 = App.Player;
        CompanyDevices val_2 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                System.DateTime val_4 = DateTimeCheat.UtcNow;
        }
        else
        {
                System.DateTime val_5 = ServerHandler.ServerTime;
        }
        
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = static_value_00280098}, t2:  new System.DateTime() {dateData = val_6})) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static System.DateTime get_LastPurchaseCooldownEnd()
    {
        Player val_1 = App.Player;
        mem2[0] = static_value_00280098;
        return new System.DateTime() {dateData = static_value_00280098};
    }
    public static bool get_isInVideoCooldown()
    {
        ulong val_4;
        ulong val_6;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.DateTime val_2 = AdsWatchedCooldownEnd;
        System.DateTime val_3 = ServerHandler.ServerTime;
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_6}, t2:  new System.DateTime() {dateData = val_4})) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static System.DateTime get_AdsCooldownEnd()
    {
        var val_5;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(2124574416 == 0)
        {
                val_5 = null;
            val_5 = null;
            mem2[0] = System.DateTime.MinValue;
            return new System.DateTime() {dateData = System.DateTime.MinValue};
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.DateTime val_4 = this.AdsWatchedCooldownEnd;
        return new System.DateTime() {dateData = val_4.dateData};
    }
    public static bool get_AdsCanShow()
    {
        var val_10;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_10 = 0;
        if(AdsAllowed() == false)
        {
                return (bool)val_10;
        }
        
        if(AdsManager.isInPurchaseCooldown == true)
        {
                return (bool)val_10;
        }
        
        if(AdsManager.isInVideoCooldown == true)
        {
                return (bool)val_10;
        }
        
        val_10 = 0;
        Player val_5 = App.Player;
        if(0.networkPurchaserExcludedFromAds == true)
        {
                return (bool)val_10;
        }
        
        Player val_7 = App.Player;
        val_10 = 2621448.ShouldShowGdprConsent() ^ 1;
        return (bool)val_10;
    }
    public static bool ShowAdsControlButtons(bool fromSettings = False)
    {
        if(fromSettings != false)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(AdsControlEnabled() == false)
        {
                return false;
        }
        
            if(AdsManager.isInPurchaseCooldown == true)
        {
                return false;
        }
        
            Player val_5 = App.Player;
            if(0.networkPurchaserExcludedFromAds == true)
        {
                return false;
        }
        
            Player val_7 = App.Player;
            GameEcon val_8 = App.getGameEcon;
            return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  0);
        }
        
        WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(AdsControlEnabled() == false)
        {
                return false;
        }
        
        if(AdsManager.isInPurchaseCooldown == true)
        {
                return false;
        }
        
        Player val_12 = App.Player;
        if(0.networkPurchaserExcludedFromAds != false)
        {
                return false;
        }
        
        Player val_14 = App.Player;
        GameEcon val_15 = App.getGameEcon;
        return GameEcon.IsEnabledAndLevelNotExeeded(playerLevel:  0, knobValue:  4);
    }
    public static bool ShowAdsControlMenuItem()
    {
        var val_7;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_7 = 0;
        if(AdsControlEnabled() == false)
        {
                return (bool)val_7;
        }
        
        if(AdsManager.isInPurchaseCooldown == true)
        {
                return (bool)val_7;
        }
        
        Player val_4 = App.Player;
        val_7 = 0.networkPurchaserExcludedFromAds ^ 1;
        return (bool)val_7;
    }
    public static bool get_AdsAllowedByScene()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private int get_AdsWatchedCount()
    {
        int val_3 = this.ads_watched_count;
        if(val_3 != 1)
        {
                return val_3;
        }
        
        val_3 = 0;
        if((CPlayerPrefs.HasKey(key:  -1895694848)) != false)
        {
                val_3 = CPlayerPrefs.GetInt(key:  -1895694848);
        }
        
        this.ads_watched_count = val_3;
        return val_3;
    }
    private void set_AdsWatchedCount(int value)
    {
        int val_9;
        string val_10;
        var val_12;
        var val_13;
        val_9 = value;
        val_10 = 35635282;
        this.ads_watched_count = val_9;
        if(this.requiredVideos == val_9)
        {
                this.ads_watched_count = 0;
            if(AdsManager.isInVideoCooldown != false)
        {
                System.DateTime val_2 = AdsWatchedCooldownEnd;
        }
        else
        {
                System.DateTime val_5 = ServerHandler.ServerTime;
        }
        
            System.DateTime val_6 = AddHours(value:  null);
            this.AdsWatchedCooldownEnd = new System.DateTime() {dateData = 1152921511301210800};
            var val_9 = 24690002;
            val_9 = 10935536 + val_9;
            if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
            val_12 = null;
            val_12 = null;
            val_13 = null;
            val_13 = null;
            val_10 = Events.ADS_DISABLED_REW;
            App.trackerManager.track(eventName:  val_10);
            val_9 = this.ads_watched_count;
        }
        
        CPlayerPrefs.SetInt(key:  -1895694848, val:  val_9);
    }
    public static int get_AdsWatched()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance()) != 0)
        {
                return AdsWatchedCount;
        }
        
        return AdsWatchedCount;
    }
    public static void set_AdsWatched(int value)
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        AdsWatchedCount = value;
    }
    public System.DateTime get_AdsWatchedCooldownEnd()
    {
        var val_5;
        var val_6;
        ulong val_10;
        var val_11;
        var val_12;
        string val_13;
        val_10 = mem[R1 + 88];
        val_10 = R1 + 88;
        val_11 = null;
        val_12 = mem[R1 + 88 + 4];
        val_12 = R1 + 88 + 4;
        val_11 = null;
        val_13 = val_12;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_10}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                val_12 = 1152921504882458624;
            val_10 = "wg_ads_watched_cooldown";
            if((CPlayerPrefs.HasKey(key:  -1895246736)) != false)
        {
                string val_3 = CPlayerPrefs.GetString(key:  -1895246736);
            System.DateTime val_4 = SLCDateTime.Parse(dateTime:  -1895234648);
            val_13 = val_5;
            mem2[0] = val_6;
        }
        else
        {
                System.DateTime val_7 = ServerHandler.ServerTime;
            mem2[0] = val_6;
            string val_8 = R1 + 88;
            string val_9 = val_8.ToString();
            val_13 = val_8;
            CPlayerPrefs.SetString(key:  -1895246736, val:  val_13);
        }
        
        }
        
        this = R1 + 88;
        return new System.DateTime() {dateData = R1 + 88};
    }
    public void set_AdsWatchedCooldownEnd(System.DateTime value)
    {
        this.ads_watched_cooldown_end = R2;
        mem[1152921511301671052] = R3;
        string val_1 = this.ads_watched_cooldown_end.ToString();
        CPlayerPrefs.SetString(key:  -1895246736, val:  -1895110520);
    }
    public static void AddAdsWatchedFromVersionUpdate()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(AdsManager.isInVideoCooldown != false)
        {
                WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.DateTime val_4 = AdsWatchedCooldownEnd;
        }
        else
        {
                System.DateTime val_5 = ServerHandler.ServerTime;
        }
        
        int val_8 = AdsManager.CooldownMonths;
        System.DateTime val_9 = AddMonths(months:  -1895010640);
        AdsWatchedCooldownEnd = new System.DateTime() {dateData = 1152921511301770928};
    }
    public static void AddPurchaseCooldownFromVersionUpdate()
    {
        ulong val_5;
        ulong val_7;
        Player val_1 = App.Player;
        int val_22 = 0;
        val_22 = val_22 + 168;
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.DateTime val_3 = AddMonths(months:  val_22);
        System.DateTime val_4 = ServerHandler.ServerTime;
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_7}, t2:  new System.DateTime() {dateData = val_5})) < 1)
        {
                return;
        }
        
        Player val_10 = App.Player;
        1152921504892043264 = 2621448;
        System.DateTime val_11 = ServerHandler.ServerTime;
        Player val_12 = App.Player;
        int val_23 = 0;
        val_23 = val_23 + 168;
        WordPets.WPTDataParser val_13 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.DateTime val_14 = AddMonths(months:  val_23);
        System.DateTime val_15 = ServerHandler.ServerTime;
        System.TimeSpan val_16 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511301882888}, d2:  new System.DateTime());
        System.DateTime val_19 = Add(value:  new System.TimeSpan() {_ticks = 1152921511301882920});
    }
    public void OnVideoResponse(Notification notif)
    {
        string val_1 = notif.data.ToString();
        if((System.Boolean.Parse(value:  notif.data)) == false)
        {
                return;
        }
        
        int val_3 = this._videosWatchedToday;
        val_3 = val_3 + 1;
        this._videosWatchedToday = val_3;
        this.SaveWatchedVideos();
    }
    public void HackResetAdsWatchedCoolDown()
    {
        if(AdsManager.isInVideoCooldown == false)
        {
                return;
        }
        
        System.DateTime val_2 = ServerHandler.ServerTime;
        System.DateTime val_5 = AddMinutes(value:  null);
        this.AdsWatchedCooldownEnd = new System.DateTime() {dateData = 1152921511302123320};
    }
    public System.Collections.Generic.List<string> get_AdsEventsFromAPI()
    {
    
    }
    private void AddAdsEvent(string eventName)
    {
        this.AdsEventsList.Add(item:  eventName);
    }
    public int HackAdsWatchedToday(int increment)
    {
        int val_1 = this._videosWatchedToday;
        val_1 = val_1 + increment;
        this._videosWatchedToday = val_1;
        this.SaveWatchedVideos();
        return (int)this._videosWatchedToday;
    }
    public AdsManager()
    {
        var val_5;
        this.videoConfig = new AdConfig();
        this.bannerConfig = new AdConfig();
        this.interstitialConfig = new AdConfig();
        this._rewardedVideoCap = 0;
        this.ads_watched_count = 0;
        val_5 = null;
        val_5 = null;
        this.ads_watched_cooldown_end = System.DateTime.MinValue;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.AdsEventsList = null;
    }
    private static AdsManager()
    {
        AdsManager.ADS_WATCHED_COOLDOWN_PREF = 12;
    }
    private void <Awake>b__48_0(MaxSdkBase.SdkConfiguration <p0>)
    {
        this.AddAdsEvent(eventName:  1706734016);
    }
    private void <Awake>b__48_1()
    {
        this.AddAdsEvent(eventName:  1706974512);
    }
    private void <Awake>b__48_2(string <p0>)
    {
        this.AddAdsEvent(eventName:  1707455552);
    }
    private void <Awake>b__48_3(string <p0>, int <p1>)
    {
        this.AddAdsEvent(eventName:  1707696048);
    }
    private void <Awake>b__48_4(string <p0>)
    {
        this.AddAdsEvent(eventName:  1707936560);
    }
    private void <Awake>b__48_5(string <p0>)
    {
        this.AddAdsEvent(eventName:  1708177056);
    }
    private void <Awake>b__48_6(string <p0>)
    {
        this.AddAdsEvent(eventName:  1708417568);
    }
    private void <Awake>b__48_7(string <p0>)
    {
        this.AddAdsEvent(eventName:  1709860576);
    }
    private void <Awake>b__48_8(string <p0>, int <p1>)
    {
        this.AddAdsEvent(eventName:  1710101088);
    }
    private void <Awake>b__48_9(string <p0>)
    {
        this.AddAdsEvent(eventName:  1710341600);
    }
    private void <Awake>b__48_10(string <p0>)
    {
        this.AddAdsEvent(eventName:  1710582112);
    }
    private void <Awake>b__48_11(string <p0>, int <p1>)
    {
        this.AddAdsEvent(eventName:  1710822624);
    }
    private void <Awake>b__48_12(string <p0>)
    {
        this.AddAdsEvent(eventName:  1711063152);
    }
    private void <Awake>b__48_13(string <p0>)
    {
        this.AddAdsEvent(eventName:  1711303664);
    }
    private void <Awake>b__48_14(string <p0>, int <p1>)
    {
        this.AddAdsEvent(eventName:  1711544176);
    }
    private void <Awake>b__48_15(string <p0>)
    {
        this.AddAdsEvent(eventName:  1711784688);
    }
    private void <Awake>b__48_16(string <p0>)
    {
        this.AddAdsEvent(eventName:  1712025200);
    }
    private void <Awake>b__48_17(string <p0>)
    {
        this.AddAdsEvent(eventName:  1712265712);
    }
    private void <Awake>b__48_18(string <p0>, int <p1>)
    {
        this.AddAdsEvent(eventName:  1712506224);
    }
    private void <Awake>b__48_19(string <p0>, MaxSdkBase.Reward <p1>)
    {
        this.AddAdsEvent(eventName:  1712746752);
    }

}
