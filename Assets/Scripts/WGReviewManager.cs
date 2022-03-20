using UnityEngine;
public class WGReviewManager : MonoSingleton<WGReviewManager>
{
    // Fields
    private const string prefTime = "prefs_review_time";
    private const string prefDidNot = "prefs_did_not_review";
    public const string REVIEW_FREE_TRIAL = "reviewtrial";
    public static int ReviewPopupLevel;
    public static int ReviewFiveStarDelay;
    private int _freeNoAdsDuration;
    private int _freeTrialDuration;
    public int selectedRating;
    private static bool _declinedReview;
    private static System.DateTime _NextReviewTime;
    private const string GOOGLE_API_REVIEW_PREF = "google_api_review_pref";
    private Google.Play.Review.ReviewManager reviewManager;
    private bool initializingRManager;
    private Google.Play.Review.PlayReviewInfo _playReviewInfo;
    
    // Properties
    public int freeNoAdsDuration { get; }
    public int feeTrialDuration { get; }
    private static bool IsAvailable { get; }
    private static bool IsDelayedUntilLaterLevel { get; }
    public static bool CanShow { get; }
    private static bool TimeToShow { get; }
    private static bool DeclinedReview { get; set; }
    public static System.DateTime NextReviewTime { get; set; }
    
    // Methods
    public int get_freeNoAdsDuration()
    {
        return (int)this._freeNoAdsDuration;
    }
    public int get_feeTrialDuration()
    {
        return (int)this._freeTrialDuration;
    }
    private static bool get_IsAvailable()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        val_2 = null;
        val_2 = null;
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  WGReviewManager.GOOGLE_API_REVIEW_PREF);
    }
    private static bool get_IsDelayedUntilLaterLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_4 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  ReviewPromptLevel);
        val_4 = val_4 ^ 1;
        return (bool)val_4;
    }
    public static bool get_CanShow()
    {
        if(WGReviewManager.IsAvailable == false)
        {
                return (bool)0;
        }
        
        0 = 1;
        if(WGReviewManager.TimeToShow == false)
        {
                return WGReviewManager.DeclinedReview;
        }
        
        return (bool)0;
    }
    private static bool get_TimeToShow()
    {
        var val_2;
        System.DateTime val_1 = DateTimeCheat.ServerNow;
        System.DateTime val_4 = WGReviewManager.NextReviewTime;
        if((val_2.CompareTo(value:  new System.DateTime() {dateData = WGReviewManager.__il2cppRuntimeField_cctor_finished})) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    private static bool get_DeclinedReview()
    {
        var val_2 = null;
        WGReviewManager._declinedReview = CPlayerPrefs.GetBool(key:  -307285200, defaultValue:  false);
        return (bool)WGReviewManager._declinedReview;
    }
    private static void set_DeclinedReview(bool value)
    {
        null = null;
        WGReviewManager._declinedReview = value;
        if(WGReviewManager._declinedReview == true)
        {
                WGReviewManager._declinedReview = 1;
        }
        
        CPlayerPrefs.SetBool(key:  -307285200, value:  true);
    }
    public static System.DateTime get_NextReviewTime()
    {
        System.DateTime val_3;
        var val_7;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        if(WGReviewManager.IsAvailable != false)
        {
                System.DateTime val_2 = DateTimeCheat.ServerNow;
            System.DateTime val_5 = AddDays(value:  null);
            val_11 = val_7;
            val_12;
        }
        else
        {
                val_13 = null;
            val_13 = null;
        }
        
        string val_8 = System.DateTime.MinValue.ToString();
        string val_9 = CPlayerPrefs.GetString(key:  -307061088, defaultValue:  -307049008);
        System.DateTime val_10 = SLCDateTime.Parse(dateTime:  -307049016);
        val_14 = null;
        val_14 = null;
        WGReviewManager._NextReviewTime = val_3;
        mem2[0] = WGReviewManager._NextReviewTime;
        return new System.DateTime() {dateData = WGReviewManager._NextReviewTime};
    }
    public static void set_NextReviewTime(System.DateTime value)
    {
        null = null;
        WGReviewManager._NextReviewTime = value.dateData;
        string val_1 = WGReviewManager._NextReviewTime.ToString();
        CPlayerPrefs.SetString(key:  -307061088, val:  373272592);
    }
    public override void InitMonoSingleton()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -306812976, name:  -2037002944);
    }
    private void OnDeferredReady()
    {
        System.DateTime val_1 = WGReviewManager.NextReviewTime;
        WGReviewManager.NextReviewTime = new System.DateTime();
        if(WGReviewManager.CanShow == false)
        {
                return;
        }
        
        this.LoadAppReview();
    }
    public bool CheckAvailable()
    {
        var val_9;
        var val_10;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                var val_9 = 28668201;
            val_9 = 6959224 + val_9;
            if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
            val_9 = null;
            val_9 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            bool val_3 = WGReviewManager.IsAvailable;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            bool val_4 = WGReviewManager.TimeToShow;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            bool val_5 = WGReviewManager.IsDelayedUntilLaterLevel;
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            UnityEngine.Debug.LogFormat(format:  -306612976, args:  472754880);
        }
        
        var val_10 = 28667557;
        val_10 = 6959868 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
        {
                return false;
        }
        
        if(WGReviewManager.IsAvailable == false)
        {
                return false;
        }
        
        if(WGReviewManager.TimeToShow == false)
        {
                return false;
        }
        
        bool val_8 = WGReviewManager.IsDelayedUntilLaterLevel;
        val_8 = val_8 ^ 1;
        return (bool)val_8;
    }
    public void HandleReviewSelected(int rating, bool forceTracking = False)
    {
        ulong val_8;
        double val_12;
        var val_14;
        WGReviewManager.DeclinedReview = false;
        GameBehavior val_1 = App.getBehavior;
        int val_2 = rating - 1;
        if(val_2 <= 4)
        {
                var val_3 = 6960436 + (6960436 + ((rating - 1)) << 2);
            if(val_2 == 4)
        {
                6960436 + ((rating - 1)) << 2 = (6960436 + ((rating - 1)) << 2) & (0 << (6960436 + ((rating - 1)) << 2));
            6960436 + ((rating - 1)) << 2 = (6960436 + ((rating - 1)) << 2) & ((IP) << 1);
            6960436 + ((rating - 1)) << 2 = (6960436 + ((rating - 1)) << 2) & (((int)IP) >> 32);
            6960436 + ((rating - 1)) << 2 = (6960436 + ((rating - 1)) << 2) & (0 >> (6960436 + ((rating - 1)) << 2));
            6960436 + ((rating - 1)) << 2 = (6960436 + ((rating - 1)) << 2) & (((int)IP) >> ((((6960436 + ((rating - 1)) << 2 & (0) << 6960436 + ((rating - 1)) << 2) & (IP) << 1) & ((int)IP) >> 32) & ((int)0) >> (((6960436 + ((rating - 1)) << 2 & (0) << 6960436 + ((rating - 1)) << 2) & (IP) );
        }
        
            val_12 = 21;
        }
        else
        {
                WGReviewManager.DeclinedReview = true;
            val_12 = 1;
        }
        
        System.DateTime val_4 = DateTimeCheat.ServerNow;
        System.DateTime val_7 = AddDays(value:  null);
        WGReviewManager.NextReviewTime = new System.DateTime() {dateData = val_8};
        this.selectedRating = rating;
        AggregateEventCalculator val_10 = new AggregateEventCalculator(name:  -306500768);
        val_14 = null;
        val_14 = null;
        Calculate(valueToAggregate:  new System.Decimal() {flags = System.Decimal.One, hi = R4, lo = R8, mid = ???}, autoFlush:  false);
        if(rating >= 0)
        {
                bool val_12 = forceTracking;
            val_12 = 0 | val_12;
            int val_11 = rating - 5;
            val_11 = val_11 >> 5;
            if(rating == 0)
        {
                return;
        }
        
        }
        
        this.DoAmpTracking(optionSelected:  1098586544);
    }
    public void DoAmpTracking(string optionSelected = "")
    {
        string val_13;
        var val_14;
        var val_15;
        val_13 = optionSelected;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        int val_13 = this.selectedRating;
        val_13 = 1 ^ (val_13 >> 31);
        Add(key:  -306384576, value:  8945664);
        Add(key:  -306384480, value:  13152256);
        AggregateEventCalculator val_2 = new AggregateEventCalculator(name:  -306500768);
        Add(key:  -306384400, value:  10170368);
        string val_3 = Player.GetLevelForTracking();
        if((System.String.op_Inequality(a:  null, b:  -750621232)) != false)
        {
                string val_5 = Player.GetLevelForTracking();
            Add(key:  -2100706208, value:  0);
        }
        
        string val_6 = Player.GetLevelNameForTracking();
        if((System.String.op_Inequality(a:  null, b:  -750621232)) != false)
        {
                string val_8 = Player.GetLevelNameForTracking();
            Add(key:  -2100706112, value:  0);
        }
        
        GameBehavior val_9 = App.getBehavior;
        val_14 = 0;
        if(val_14 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_11 = PlayingChallenge;
            val_14 = null;
            Add(key:  -2100705808, value:  8945664);
        }
        
        if(this.selectedRating == 5)
        {
            goto label_26;
        }
        
        if((System.String.op_Equality(a:  val_13, b:  1098586544)) != true)
        {
                if(this.selectedRating > 1)
        {
            goto label_28;
        }
        
        }
        
        val_13 = "None";
        label_28:
        Add(key:  -306384288, value:  -1927030208);
        label_26:
        var val_14 = 28663442;
        val_14 = 6962096 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        App.trackerManager.track(eventName:  -306384192, data:  78753792);
    }
    public void GrantNoAdTime()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.DateTime val_3 = AdsWatchedCooldownEnd;
        System.DateTime val_6 = AddDays(value:  null);
        AdsWatchedCooldownEnd = new System.DateTime() {dateData = 1152921512890525536};
    }
    public void TryGrantFreeTrial()
    {
        GameBehavior val_1 = App.getBehavior;
        WGSubscriptionManager._subEntryPoint = 0;
    }
    public void LoadAppReview()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -306044000)) == true)
        {
                return;
        }
        
        if((R4 + 24) == 0)
        {
                mem2[0] = new Google.Play.Review.ReviewManager();
        }
        
        if((R4 + 32) == 0)
        {
                R4 + 32 = mem[R4 + 28];
            R4 + 32 = R4 + 28;
            goto label_2;
        }
        
        return;
        label_2:
        System.Collections.IEnumerator val_3 = R4.InitReviewManager();
        UnityEngine.Coroutine val_4 = R4.StartCoroutine(routine:  R4);
    }
    public void ShowInAppReview()
    {
        TrackingComponent.CurrentIntent = 6;
        if(this._playReviewInfo != 0)
        {
                if((UnityEngine.PlayerPrefs.HasKey(key:  -306044000)) == false)
        {
            goto label_4;
        }
        
        }
        
        UnityEngine.Debug.Log(message:  -305927792);
        AppConfigs val_2 = App.Configuration;
        string val_3 = 0.Key(key:  -305927568);
        twelvegigs.plugins.SharePlugin.OpenURL(url:  null);
        return;
        label_4:
        System.Collections.IEnumerator val_4 = this.LaunchAppReview();
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -305903472);
    }
    private System.Collections.IEnumerator InitReviewManager()
    {
        object val_1 = new System.Object();
        typeof(WGReviewManager.<InitReviewManager>d__41).__il2cppRuntimeField_8 = 0;
        typeof(WGReviewManager.<InitReviewManager>d__41).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator LaunchAppReview()
    {
        object val_1 = new System.Object();
        typeof(WGReviewManager.<LaunchAppReview>d__42).__il2cppRuntimeField_8 = 0;
        typeof(WGReviewManager.<LaunchAppReview>d__42).__il2cppRuntimeField_10 = this;
    }
    public WGReviewManager()
    {
        this._freeNoAdsDuration = 3;
        this._freeTrialDuration = 3;
        this.selectedRating = 0;
    }
    private static WGReviewManager()
    {
        var val_1;
        var val_2;
        WGReviewManager.GOOGLE_API_REVIEW_PREF = 15;
        val_1 = null;
        WGReviewManager.ReviewFiveStarDelay = 16;
        WGReviewManager._declinedReview = false;
        val_2 = null;
        val_2 = null;
        val_1 = 1152921504980115548;
        WGReviewManager._NextReviewTime = System.DateTime.MinValue;
        WGReviewManager.GOOGLE_API_REVIEW_PREF.__il2cppRuntimeField_14 = System.DateTime.DateDataField.__il2cppRuntimeField_C;
    }

}
