using UnityEngine;
public class WGDailyChallengeManager : MonoSingleton<WGDailyChallengeManager>
{
    // Fields
    private const float data_request_cooldown = 1;
    public const string DAILY_CHALLENGE_DATA_UPDATE = "OnDailyChallengeDataUpdate";
    public const int REQUIRED_STARS = 3;
    public const int DAILY_CHALLENGE_UNLOCK_LEVEL = 6;
    private readonly double EPSILON;
    private bool isRequesting;
    private bool dcRevamp;
    private int lastKnownCheatSeconds;
    private System.DateTime lastRequestSuccessTime;
    private System.Action<bool> currentRequestCallback;
    private System.Collections.Generic.List<ZooTile> monthZooTileCollection;
    private DailyChallenge_MonthHistory monthHistory;
    private DailyChallengeProgress todaysProgress;
    private DailyChallenge_WeekHistory weekHistory;
    private System.DateTime lastWeekRewardCollected;
    private System.DateTime lastMonthRewardCollected;
    public System.Action<int> OnStarsEarned;
    public System.Action OnZooTileEarned;
    public System.Action OnMissedPoint;
    public System.Action OnWeeklyMonthlyRewardCollected;
    private DailyChallengeStatus <Status>k__BackingField;
    private DailyChallengeEconomy <Econ>k__BackingField;
    public bool PlayingMorning;
    public bool PlayingEvening;
    private System.DateTime _LastPlayedDailyChallenge;
    private bool <IsDataReady>k__BackingField;
    private int <RecentStarGained>k__BackingField;
    private bool <HackDateTime>k__BackingField;
    private DailyChallengeGameLevel missedChallengeLevel;
    private static System.DateTime lastServerCall;
    private static int secondsUntilNextRequest;
    private bool isRunningDelayedRequest;
    private System.Collections.Generic.List<string> answers;
    private System.Collections.Generic.List<string> extraWords;
    private System.Collections.Generic.List<int> actualWordsCount;
    
    // Properties
    public int Version { get; }
    public DailyChallengeStatus Status { get; set; }
    public DailyChallengeEconomy Econ { get; set; }
    public DailyChallengeProgress TodaysProgress { get; set; }
    public DailyChallenge_MonthHistory MonthHistory { get; set; }
    public DailyChallenge_WeekHistory WeekHistory { get; set; }
    public System.Collections.Generic.List<ZooTile> ZooTileCollection { get; }
    public DailyChallengeGameLevel CurrentLevel { get; set; }
    public bool PlayingChallenge { get; set; }
    public System.DateTime LastPlayedDailyChallenge { get; set; }
    public bool IsDataReady { get; set; }
    public int RecentStarGained { get; set; }
    public bool HackDateTime { get; set; }
    public bool FeatureAvailable { get; }
    
    // Methods
    public int get_Version()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public DailyChallengeStatus get_Status()
    {
    
    }
    private void set_Status(DailyChallengeStatus value)
    {
        this.<Status>k__BackingField = value;
    }
    public DailyChallengeEconomy get_Econ()
    {
    
    }
    private void set_Econ(DailyChallengeEconomy value)
    {
        this.<Econ>k__BackingField = value;
    }
    public DailyChallengeProgress get_TodaysProgress()
    {
    
    }
    private void set_TodaysProgress(DailyChallengeProgress value)
    {
        this.todaysProgress = value;
    }
    public DailyChallenge_MonthHistory get_MonthHistory()
    {
    
    }
    private void set_MonthHistory(DailyChallenge_MonthHistory value)
    {
        this.monthHistory = value;
    }
    public DailyChallenge_WeekHistory get_WeekHistory()
    {
    
    }
    private void set_WeekHistory(DailyChallenge_WeekHistory value)
    {
        this.weekHistory = value;
    }
    public System.Collections.Generic.List<ZooTile> get_ZooTileCollection()
    {
        System.Collections.Generic.List<ZooTile> val_7;
        var val_8;
        var val_9;
        System.Predicate<ZooTile> val_11;
        var val_12;
        System.Func<ZooTile, System.String> val_14;
        val_7 = null;
        val_7 = new System.Collections.Generic.List<ZooTile>(collection:  this.monthZooTileCollection);
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        val_11 = WGDailyChallengeManager.<>c.<>9__40_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Predicate<ZooTile>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4204520240));
            WGDailyChallengeManager.<>c.<>9__40_0 = val_11;
        }
        
        System.Collections.Generic.List<T> val_3 = ZooTilePool.LifetimeZooTiles.FindAll(match:  8040448);
        if(val_7 != 0)
        {
                AddRange(collection:  ZooTilePool.LifetimeZooTiles);
        }
        else
        {
                AddRange(collection:  ZooTilePool.LifetimeZooTiles);
        }
        
        val_12 = null;
        val_12 = null;
        val_14 = WGDailyChallengeManager.<>c.<>9__40_1;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<ZooTile, System.String>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4204523312));
            WGDailyChallengeManager.<>c.<>9__40_1 = val_14;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_5 = System.Linq.Enumerable.OrderBy<System.Object, System.Object>(source:  80883712, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.Object>(source:  80883712);
        val_7 = val_7;
    }
    public DailyChallengeGameLevel get_CurrentLevel()
    {
        DailyChallengeGameLevel val_1;
        if((this.<Status>k__BackingField.playingPersistentLevel) != false)
        {
                val_1 = this.todaysProgress.currentLevel;
            return;
        }
        
        val_1 = this.missedChallengeLevel;
    }
    public void set_CurrentLevel(DailyChallengeGameLevel value)
    {
        if((this.<Status>k__BackingField.playingPersistentLevel) != false)
        {
                this.todaysProgress.currentLevel = value;
            return;
        }
        
        this.missedChallengeLevel = value;
    }
    public bool get_PlayingChallenge()
    {
        if(this.PlayingMorning == true)
        {
                return true;
        }
        
        if(this.PlayingEvening == true)
        {
                this.PlayingEvening = 1;
        }
        
        return true;
    }
    public void set_PlayingChallenge(bool value)
    {
        DailyChallengeStatus val_4;
        this.PlayingMorning = false;
        this.PlayingEvening = false;
        if(value == false)
        {
                return;
        }
        
        if((this.<Status>k__BackingField) == 0)
        {
            goto label_2;
        }
        
        this.PlayingMorning = this.<Status>k__BackingField.playingDayMorning;
        val_4 = this.<Status>k__BackingField;
        goto label_3;
        label_2:
        val_4 = this.<Status>k__BackingField;
        this.PlayingMorning = this.<Status>k__BackingField.playingDayMorning;
        if(val_4 == 0)
        {
            goto label_4;
        }
        
        label_3:
        bool val_4 = this.<Status>k__BackingField.playingDayMorning;
        val_4 = val_4 ^ 1;
        this.PlayingEvening = val_4;
        System.DateTime val_1 = DateTimeCheat.Now;
        this.LastPlayedDailyChallenge = new System.DateTime();
        return;
        label_4:
    }
    public System.DateTime get_LastPlayedDailyChallenge()
    {
        var val_6;
        var val_7;
        ulong val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = mem[R1 + 112];
        val_8 = R1 + 112;
        val_9 = null;
        val_9 = null;
        val_10 = R1 + 112 + 4;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_8}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                val_10 = 0;
            val_8 = "last_dc_play_time";
            if((UnityEngine.PlayerPrefs.HasKey(key:  -89818448)) != false)
        {
                val_11 = null;
            val_11 = null;
            string val_3 = System.DateTime.MinValue.ToString();
            string val_4 = UnityEngine.PlayerPrefs.GetString(key:  -89818448, defaultValue:  -89806376);
            System.DateTime val_5 = SLCDateTime.Parse(dateTime:  -89806384);
            val_10 = val_6;
            mem2[0] = val_7;
        }
        
        }
        
        this = R1 + 112;
        return new System.DateTime() {dateData = R1 + 112};
    }
    public void set_LastPlayedDailyChallenge(System.DateTime value)
    {
        this._LastPlayedDailyChallenge = R2;
        mem[1152921513107099348] = R3;
        string val_1 = this._LastPlayedDailyChallenge.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -89818448, value:  -89682224);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public bool get_IsDataReady()
    {
        return (bool)this.<IsDataReady>k__BackingField;
    }
    private void set_IsDataReady(bool value)
    {
        this.<IsDataReady>k__BackingField = value;
    }
    public int get_RecentStarGained()
    {
        return (int)this.<RecentStarGained>k__BackingField;
    }
    private void set_RecentStarGained(int value)
    {
        this.<RecentStarGained>k__BackingField = value;
    }
    public bool get_HackDateTime()
    {
        return (bool)this.<HackDateTime>k__BackingField;
    }
    public void set_HackDateTime(bool value)
    {
        this.<HackDateTime>k__BackingField = value;
    }
    public bool get_FeatureAvailable()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 > 5)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool CurrentLanguageSupported()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        bool val_3 = System.String.op_Inequality(a:  null, b:  1800251696);
        val_3 = val_3 ^ 1;
        return (bool)val_3;
    }
    public override void InitMonoSingleton()
    {
        System.Delegate val_14;
        Player val_1 = App.Player;
        string val_2 = -88698336(-88698336) + 1835037;
        SLCDebug.Log(logMessage:  -88698336, colorHash:  -1835139200, isError:  false);
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        System.Action<System.Int32> val_4 = new System.Action<System.Int32>(object:  -88672096, method:  new IntPtr(4206269152));
        val_14 = GoldenApplesManager.OnAppleAwarded;
        System.Delegate val_5 = System.Delegate.Combine(a:  val_14, b:  7401472);
        if(val_14 != 0)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        val_14 = 0;
        label_10:
        GoldenApplesManager.OnAppleAwarded = val_14;
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_6 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -88672096, method:  new IntPtr(4206270176));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -88672096, name:  -1976323520);
        NotificationCenter val_8 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -88672096, name:  1799422256);
        this.monthHistory = new DailyChallenge_MonthHistory();
        this.weekHistory = new DailyChallenge_WeekHistory();
        this.<Status>k__BackingField = new DailyChallengeStatus(isMorning:  WGDailyChallengeManagerHelper.MorningChallengeAvailableNow());
        this.todaysProgress = new DailyChallengeProgress();
        this.RequestChallengeData(firstTimeNewIdRequest:  false);
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode sceneMode)
    {
        this.RequestDataInLobby();
    }
    private void RequestDataInLobby()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 1)
        {
                return;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        R4.RequestChallengeData(firstTimeNewIdRequest:  false);
    }
    private void OnServerResponded()
    {
        this.RequestChallengeData(firstTimeNewIdRequest:  false);
    }
    public void OnSceneChanged(UnityEngine.SceneManagement.Scene current, UnityEngine.SceneManagement.Scene next)
    {
        this.TrackChallengeProgress();
        this.SavePersistentProgress();
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  -88215904, method:  new IntPtr(4201336000));
        UnityEngine.SceneManagement.SceneManager.remove_activeSceneChanged(value:  162459648);
    }
    private void SavePersistentProgress()
    {
        DailyChallengeStatus val_7;
        if((this.<Status>k__BackingField.playingPersistentLevel) == false)
        {
            goto label_2;
        }
        
        val_7 = this.<Status>k__BackingField;
        if((this.<Status>k__BackingField) != 0)
        {
            goto label_3;
        }
        
        val_7 = this.<Status>k__BackingField;
        if(val_7 == 0)
        {
            goto label_4;
        }
        
        label_3:
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        DailyChallengeGameLevel val_2 = this.CurrentLevel;
        if((this.<Status>k__BackingField.playingDayMorning) == true)
        {
                this.<Status>k__BackingField.playingDayMorning = 1;
        }
        
        DailyChallengeLastPlayedLevel val_4 = new DailyChallengeLastPlayedLevel(day:  this.<Status>k__BackingField.playingDay, isMorning:  true, levelId:  R6 + 48, stars:  ???, progress:  this.GetProgressPercentage(), done:  true, isPersistentLevel:  false);
        this.<Status>k__BackingField.lastPlayedLevel = null;
        if((this.<Status>k__BackingField) != 0)
        {
            goto typeof(DailyChallengeStatus).__il2cppRuntimeField_E4;
        }
        
        goto typeof(DailyChallengeStatus).__il2cppRuntimeField_E4;
        label_2:
        var val_5 = FP - 28;
        return;
        label_4:
    }
    private void PauseTimer()
    {
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        this.OnZooTileEarned = UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Time.time);
    }
    private void ResumeTimer()
    {
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        DailyChallengeGameLevel val_4 = this.CurrentLevel;
        System.Action val_6 = this.OnZooTileEarned;
        val_6 = ((UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Time.time)) + this.OnMissedPoint) - val_6;
        this.OnMissedPoint = val_6;
    }
    private int GetTimeSpent()
    {
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        DailyChallengeGameLevel val_4 = this.CurrentLevel;
        DailyChallengeGameLevel val_6 = this.CurrentLevel;
        DailyChallengeGameLevel val_9 = this.CurrentLevel;
        int val_10 = (UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Time.time)) + this.lastWeekRewardCollected;
        val_10 = val_10 - SL;
        val_10 = val_10 + (UnityEngine.Mathf.Max(a:  0, b:  DateTimeCheat.Seconds - this.OnStarsEarned));
        val_10 = val_10 - this.OnMissedPoint;
        this.lastWeekRewardCollected = val_10;
        DailyChallengeGameLevel val_11 = this.CurrentLevel;
        if(this != 0)
        {
                return (int)this.lastWeekRewardCollected;
        }
        
        return (int)this.lastWeekRewardCollected;
    }
    private void TrackChallengeProgress()
    {
        System.DateTime val_3;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.DateTime val_2 = DateTimeCheat.Now;
        string val_5 = val_3.ToString();
        val_19 = null;
        if(null == 0)
        {
                val_19 = null;
        }
        
        Add(key:  -1898276784, value:  -87589344);
        string val_6 = this.GetLevelForTracking();
        val_20 = val_19;
        if(val_19 == 0)
        {
                val_20 = null;
        }
        
        Add(key:  -2085463936, value:  -87577296);
        Add(key:  -87614368, value:  13152256);
        DailyChallengeGameLevel val_7 = this.CurrentLevel;
        Add(key:  -2100067936, value:  13152256);
        DailyChallengeGameLevel val_8 = this.CurrentLevel;
        Add(key:  -2100067840, value:  13152256);
        DailyChallengeGameLevel val_9 = this.CurrentLevel;
        Add(key:  -87610176, value:  8945664);
        Add(key:  -1598580112, value:  8945664);
        if((this.<Status>k__BackingField.playingPersistentLevel) != false)
        {
                DailyChallengeGameLevel val_10 = this.CurrentLevel;
            val_3 = this.lastMonthRewardCollected;
            Add(key:  -87606000, value:  8945664);
        }
        
        DailyChallengeGameLevel val_11 = this.CurrentLevel;
        DailyChallengeGameLevel val_12 = this.CurrentLevel;
        System.DateTime val_19 = this.EPSILON + 12;
        val_19 = this.lastMonthRewardCollected - val_19;
        val_3 = val_19;
        Add(key:  -87605888, value:  13152256);
        int val_13 = this.GetTimeSpent();
        val_21 = null;
        if(null == 0)
        {
                val_21 = null;
        }
        
        Add(key:  -87605776, value:  13152256);
        DailyChallengeGameLevel val_14 = this.CurrentLevel;
        Add(key:  -87605680, value:  13152256);
        DailyChallengeGameLevel val_15 = this.CurrentLevel;
        Add(key:  -87605584, value:  13152256);
        DailyChallengeGameLevel val_16 = this.CurrentLevel;
        Add(key:  -87601392, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AppendDailyChallengeCompleteData(curData: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_18 = -87589332);
        var val_20 = 26689854;
        val_20 = 8935684 + val_20;
        if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        App.trackerManager.track(eventName:  -1942282592, data:  78753792);
    }
    public void ResetLastRequestSuccessTime()
    {
        var val_1 = null;
        this.lastRequestSuccessTime = System.DateTime.MinValue;
    }
    private void RequestChallengeData(bool firstTimeNewIdRequest = False)
    {
        ulong val_3;
        var val_6;
        if(this.FeatureAvailable == false)
        {
                return;
        }
        
        if(firstTimeNewIdRequest != true)
        {
                35631245 = 0;
            System.DateTime val_2 = DateTimeCheat.Now;
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513109428504}, d2:  new System.DateTime() {dateData = val_3});
            double val_8 = val_6.TotalSeconds;
            if(this.lastKnownCheatSeconds == DateTimeCheat.Seconds)
        {
                return;
        }
        
            NotificationCenter val_10 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  -87341008, aName:  -106451056);
            return;
        }
        
        if(this.isRunningDelayedRequest != true)
        {
                Player val_11 = App.Player;
            if((System.String.op_Equality(a:  1835037, b:  1297836560)) != false)
        {
                System.Collections.IEnumerator val_13 = this.RequestValidIdDelayed();
            UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  -87341008);
            return;
        }
        
        }
        
        this.DoRequest();
    }
    private void DoRequest()
    {
        var val_10;
        var val_11;
        if(this.isRequesting == false)
        {
            goto label_1;
        }
        
        label_8:
        this.FireRequestCallback(status:  false);
        return;
        label_1:
        var val_10 = 26689805;
        val_10 = 8937620 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
        {
            goto label_8;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_2 = App.Player;
        Add(key:  1618311216, value:  1835037);
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() == true)
        {
                "e" = "m";
        }
        
        Add(key:  -87253008, value:  -1125089760);
        Add(key:  1470926528, value:  13152256);
        int val_5 = DeviceIdPlugin.GetTimeZone();
        Add(key:  -1928946720, value:  13152256);
        if((this.<HackDateTime>k__BackingField) != false)
        {
                System.DateTime val_6 = DateTimeCheat.Now;
            string val_8 = Version.ToString();
            Add(key:  -87252928, value:  -87239720);
        }
        
        this.isRequesting = true;
        var val_11 = 26687746;
        val_11 = 8938312 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_9 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -87227680, method:  new IntPtr(4207714464));
        App.networkManager.DoGet(path:  -87251808, onCompleteFunction:  7507968, destroy:  false, immediate:  false, getParams:  null, timeout:  20);
    }
    public void RequestServerUpdate(System.Action<bool> callback)
    {
        this.currentRequestCallback = callback;
        this.DoRequest();
    }
    public void UnregisterRequestCallback(System.Action<bool> callback)
    {
        if((System.Delegate.op_Equality(d1:  this.currentRequestCallback, d2:  callback)) == true)
        {
                this.currentRequestCallback = 0;
        }
    
    }
    public string GetMonthTileName()
    {
        var val_5;
        ulong val_9;
        var val_37;
        float val_38;
        int val_39;
        var val_40;
        var val_41;
        string val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        val_37 = null;
        val_37 = null;
        System.Collections.Generic.IEnumerable<TSource> val_1 = System.Linq.Enumerable.Except<System.Object>(first:  ZooTilePool.MonthlyZooTiles, second:  this.monthZooTileCollection);
        System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<System.Object>(source:  ZooTilePool.MonthlyZooTiles);
        if((ZooTilePool.MonthlyZooTiles + 12) == 0)
        {
            goto label_4;
        }
        
        val_38 = 0;
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -86885984, defaultValue:  1098586544);
        val_39 = "dc_month_tile_last_saved_time";
        System.DateTime val_4 = DateTimeCheat.Now;
        System.DateTime val_8 = DateTimeCheat.Now;
        val_40 = 1;
        System.DateTime val_12 = new System.DateTime(year:  val_5.Year, month:  val_9.Month, day:  1);
        if((System.String.IsNullOrEmpty(value:  -86885984)) != true)
        {
                val_38 = 0;
            System.DateTime val_14 = AddMonths(months:  -86868688);
            System.DateTime val_15 = SLCDateTime.Parse(dateTime:  -86868720, defaultValue:  new System.DateTime() {dateData = 1152921513109895584});
            val_40 = (System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_9}, t2:  new System.DateTime() {dateData = val_12.dateData})) >> 5;
        }
        
        val_41 = 0;
        string val_17 = UnityEngine.PlayerPrefs.GetString(key:  -86885856, defaultValue:  1098586544);
        val_42 = "dc_month_tile";
        if(val_40 != 0)
        {
                if((System.String.IsNullOrEmpty(value:  -86885984)) == false)
        {
                return;
        }
        
        }
        
        System.DateTime val_19 = new System.DateTime(year:  2019, month:  10, day:  1);
        System.DateTime val_20 = DateTimeCheat.Now;
        var val_37 = val_19.dateData.Year;
        System.DateTime val_23 = DateTimeCheat.Now;
        int val_24 = val_5.Year - val_37;
        val_37 = val_24 + (val_24 << 1);
        val_37 = val_9.Month + (val_37 << 2);
        int val_27 = val_37 + (~val_19.dateData.Month);
        if(val_27 < 0)
        {
            goto label_14;
        }
        
        val_43 = null;
        val_43 = null;
        var val_38 = ZooTilePool.MonthlyZooTiles + 12;
        val_38 = val_38 - 1;
        if(val_27 > val_38)
        {
                val_44 = 0;
        }
        
        goto label_20;
        label_4:
        val_42 = "";
        return;
        label_14:
        val_44 = 0;
        goto label_20;
        label_39:
        val_45 = null;
        val_45 = null;
        if((ZooTilePool.MonthlyZooTiles + 12) <= val_44)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_39 = ZooTilePool.MonthlyZooTiles + 8;
        val_39 = val_39 + 0;
        if((this.monthZooTileCollection.Contains(item:  (ZooTilePool.MonthlyZooTiles + 8 + 0) + 16)) == true)
        {
            goto label_26;
        }
        
        val_46 = null;
        val_46 = null;
        if((ZooTilePool.MonthlyZooTiles + 12) <= val_44)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_40 = ZooTilePool.MonthlyZooTiles + 8;
        val_40 = val_40 + 0;
        if((System.String.op_Equality(a:  -86885856, b:  (ZooTilePool.MonthlyZooTiles + 8 + 0) + 16 + 8)) == false)
        {
            goto label_32;
        }
        
        label_26:
        val_47 = null;
        val_47 = null;
        var val_41 = ZooTilePool.MonthlyZooTiles + 12;
        val_41 = val_41 - 1;
        val_41 = val_44 - val_41;
        if(ZooTilePool.MonthlyZooTiles != 0)
        {
                val_41 = 1;
        }
        
        val_44 = val_41;
        label_20:
        val_48 = null;
        val_48 = null;
        if(val_44 < (ZooTilePool.MonthlyZooTiles + 12))
        {
            goto label_39;
        }
        
        val_41 = "dc_month_tile_last_saved_time";
        val_49 = "dc_month_tile";
        val_38 = val_44;
        goto label_40;
        label_32:
        val_41 = "dc_month_tile_last_saved_time";
        val_49 = "dc_month_tile";
        label_40:
        val_50 = null;
        val_50 = null;
        if((ZooTilePool.MonthlyZooTiles + 12) <= val_44)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_42 = ZooTilePool.MonthlyZooTiles + 8;
        val_42 = val_42 + 0;
        val_42 = mem[(ZooTilePool.MonthlyZooTiles + 8 + 0) + 16 + 8];
        val_42 = (ZooTilePool.MonthlyZooTiles + 8 + 0) + 16 + 8;
        UnityEngine.PlayerPrefs.SetString(key:  -86885856, value:  val_42);
        System.DateTime val_30 = DateTimeCheat.Now;
        val_39 = val_5.Year;
        System.DateTime val_32 = DateTimeCheat.Now;
        System.DateTime val_34 = new System.DateTime(year:  val_39, month:  val_9.Month, day:  1);
        string val_35 = val_34.dateData.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -86885984, value:  -86868696);
        bool val_36 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public ZooTile GetNextLifetimeTile()
    {
        var val_2;
        var val_3;
        System.Func<ZooTile, System.Boolean> val_5;
        val_2 = null;
        val_2 = null;
        val_3 = null;
        val_3 = null;
        val_5 = WGDailyChallengeManager.<>c.<>9__87_0;
        if(val_5 != 0)
        {
                return System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  ZooTilePool.LifetimeZooTiles, predicate:  7720960);
        }
        
        val_5 = null;
        val_5 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4208206848));
        WGDailyChallengeManager.<>c.<>9__87_0 = val_5;
        return System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  ZooTilePool.LifetimeZooTiles, predicate:  7720960);
    }
    private void OnApplicationPause(bool paused)
    {
        paused = paused ^ 1;
        this.HandleApplicationBackToFocus(isInFocus:  paused);
    }
    private void OnApplicationFocus(bool focus)
    {
        this.HandleApplicationBackToFocus(isInFocus:  focus);
    }
    private void OnLocalize()
    {
        if(this.PlayingMorning == false)
        {
                this.PlayingMorning = this.PlayingEvening;
            return;
        }
        
        this.HandleLevelCompletion();
        this.Play();
    }
    private void HandleApplicationBackToFocus(bool isInFocus)
    {
        if(this.PlayingMorning == false)
        {
                this.PlayingMorning = this.PlayingEvening;
            return;
        }
        
        if(isInFocus != false)
        {
                this.ResumeTimer();
            this.RequestDataInLobby();
            return;
        }
        
        this.PauseTimer();
    }
    private void OnApplicationQuit()
    {
        if(this.PlayingMorning == false)
        {
                this.PlayingMorning = this.PlayingEvening;
            return;
        }
        
        int val_1 = this.GetTimeSpent();
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private System.Collections.IEnumerator RequestValidIdDelayed()
    {
        object val_1 = new System.Object();
        typeof(WGDailyChallengeManager.<RequestValidIdDelayed>d__94).__il2cppRuntimeField_8 = 0;
        typeof(WGDailyChallengeManager.<RequestValidIdDelayed>d__94).__il2cppRuntimeField_10 = this;
    }
    private void OnDailyChallengeRequest(string apiCall, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_8;
        this.CheckAndHandleRollover();
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_8 = 0;
        if(val_8.CompanyDevice() != false)
        {
                string val_3 = PrettyPrint.printJSON(obj:  response, types:  false, singleLineOutput:  false);
            string val_4 = apiCall + 1269544832 + response;
            UnityEngine.Debug.Log(message:  apiCall);
        }
        
        if(response != 0)
        {
                object val_5 = response.Item[1616271776];
            val_8 = null;
            response.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null != 0)
        {
                this.UpdateDataFromServer(response:  response);
            return;
        }
        
        }
        
        string val_6 = MiniJSON.Json.Serialize(obj:  response);
        string val_7 = -85965184(-85965184) + response;
        UnityEngine.Debug.LogError(message:  -85965184);
        this.isRequesting = false;
        this.FireRequestCallback(status:  false);
    }
    private void UpdateDataFromServer(System.Collections.Generic.Dictionary<string, object> response)
    {
        DailyChallengeSimplifiedLevel val_19;
        DailyChallenge_MonthHistory val_20;
        val_19 = "economy";
        if((response.ContainsKey(key:  -1554533760)) != false)
        {
                object val_2 = response.Item[-1554533760];
            if(response != 0)
        {
                val_19 = response;
        }
        
        }
        
        if((this.<Econ>k__BackingField) != 0)
        {
                val_20 = this;
            DailyChallenge_MonthHistory val_3 = this.ParseMonthProgress(data:  response);
            this.monthHistory = val_20;
            if(this.dcRevamp != false)
        {
                val_20 = this;
            DailyChallenge_WeekHistory val_4 = this.ParseWeekProgress(data:  response);
            this.weekHistory = val_20;
        }
        
            System.Collections.Generic.List<ZooTile> val_5 = this.ParseMonthZooTileCollection(data:  response);
            this.monthZooTileCollection = val_20;
            if((System.String.IsNullOrEmpty(value:  this.monthHistory.tile)) != false)
        {
                string val_7 = this.GetMonthTileName();
            this.monthHistory.tile = this;
        }
        
            System.DateTime val_8 = DateTimeCheat.Now;
            string val_10 = ???.Day.ToString();
            val_19;
            if((this.monthHistory.progress.ContainsKey(key:  -85779324)) != false)
        {
                System.DateTime val_12 = DateTimeCheat.Now;
            string val_14 = ???.Day.ToString();
            DailyChallenge_DayProgress val_15 = this.monthHistory.progress.Item[-85779324];
            mem2[0] = ???;
            val_19 = this.todaysProgress.eveningChallenge;
            mem2[0] = this.monthHistory.progress;
        }
        
            System.DateTime val_16 = DateTimeCheat.Now;
            this.lastRequestSuccessTime = new System.DateTime();
            this.lastKnownCheatSeconds = DateTimeCheat.Seconds;
            this.<IsDataReady>k__BackingField = true;
            this.FireRequestCallback(status:  true);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -85791600, context:  -85767280);
    }
    private void CheckChallengeRollover()
    {
        DailyChallengeStatus val_2;
        if((this.<Status>k__BackingField.lastPlayedLevel) != 0)
        {
                this.<Status>k__BackingField.lastPlayedLevel.isPersistentLevel = true;
        }
        else
        {
                mem[29] = 1;
        }
        
        val_2 = this.<Status>k__BackingField;
        if((this.<Status>k__BackingField.playingPersistentLevel) == false)
        {
                return;
        }
        
        val_2 = this.<Status>k__BackingField;
        if((this.<Status>k__BackingField.lastPlayedLevel) != 0)
        {
                this.<Status>k__BackingField.lastPlayedLevel = 1;
        }
        
        if((this.<Status>k__BackingField.playingDayMorning) == true)
        {
                this.<Status>k__BackingField.playingDayMorning = 1;
        }
        
        if(1 == 1)
        {
                return;
        }
        
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        mem[1152921513111195957] = 0;
        PlayingLevel.CompleteLevel(mode:  2, parameters:  0);
    }
    public void Play()
    {
        DailyChallengeStatus val_9;
        this.CheckChallengeRollover();
        if((this.<Status>k__BackingField.playingPersistentLevel) == false)
        {
                2 = 3;
        }
        
        this.GetLevel(mode:  3);
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        if(this != 0)
        {
                DailyChallengeGameLevel val_2 = this.CurrentLevel;
            this.lastMonthRewardCollected = 1;
            val_9 = this.<Status>k__BackingField;
            if(val_9 != 0)
        {
            goto label_6;
        }
        
        }
        else
        {
                this.ResetProgress();
            DailyChallengeGameLevel val_4 = this.CurrentLevel;
            DailyChallengeGameLevel val_5 = this.CurrentLevel;
            DailyChallengeLastPlayedLevel val_7 = new DailyChallengeLastPlayedLevel(day:  this.<Status>k__BackingField.playingDay, isMorning:  WGDailyChallengeManagerHelper.MorningChallengeAvailableNow(), levelId:  this.monthHistory, stars:  ???, progress:  this.GetProgressPercentage(), done:  true, isPersistentLevel:  false);
            this.<Status>k__BackingField.lastPlayedLevel = null;
            val_9 = this.<Status>k__BackingField;
        }
        
        label_6:
        this.ResetSessionTracking();
        this.PlayingChallenge = true;
        GameBehavior val_8 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void ResetProgress()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ResetDCProgress();
        DailyChallengeGameLevel val_2 = this.CurrentLevel;
        this.ResetPointer();
        ExtraWord.ClearEventExtraWordProgress(gameTypeId:  -2094123920);
    }
    private void GetLevel(GameplayMode mode)
    {
        bool val_20;
        DailyChallengeStatus val_21;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1448559232) == 0)
        {
            goto label_9;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_5 = GetDailyChallengeGameLevel();
        this.CurrentLevel = -1448559232;
        DailyChallengeGameLevel val_6 = this.CurrentLevel;
        GameLevel val_7 = this.GenerateOrLoadLevel(levelName:  1098586544, tries:  0, mode:  mode);
        mem[1152921513111622140] = this;
        DailyChallengeGameLevel val_8 = this.CurrentLevel;
        this.<Status>k__BackingField = new DailyChallengeStatus(isMorning:  WGDailyChallengeManagerHelper.MorningChallengeAvailableNow());
        val_20 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow();
        typeof(DailyChallengeStatus).__il2cppRuntimeField_10 = val_20;
        this.<Status>k__BackingField.playingDay = 0;
        val_21 = this.<Status>k__BackingField;
        if(val_21 != 0)
        {
            goto typeof(WGDailyChallengeManager).__il2cppRuntimeField_E4;
        }
        
        goto typeof(WGDailyChallengeManager).__il2cppRuntimeField_E4;
        label_9:
        DailyChallengeGameLevel val_12 = new DailyChallengeGameLevel();
        this.CurrentLevel = 370020352;
        DailyChallengeGameLevel val_13 = this.CurrentLevel;
        GameplayMode val_14 = mode - 2;
        val_14 = val_14 >> 5;
        mem[1152921513111622136] = val_14;
        if(this == 0)
        {
                if((this.<Status>k__BackingField.lastPlayedLevel.done) != false)
        {
                DailyChallengeGameLevel val_15 = new DailyChallengeGameLevel();
            this.CurrentLevel = 370020352;
        }
        else
        {
                DailyChallengeGameLevel val_16 = this.CurrentLevel;
        }
        
        }
        
        DailyChallengeGameLevel val_17 = this.CurrentLevel;
        val_20 = this;
        GameLevel val_18 = this.GenerateOrLoadLevel(levelName:  -85183536, tries:  0, mode:  mode);
        mem[1152921513111622140] = this;
        DailyChallengeGameLevel val_19 = this.CurrentLevel;
        val_21 = this;
        goto typeof(WGDailyChallengeManager).__il2cppRuntimeField_E4;
    }
    private void ResetSessionTracking()
    {
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        mem[1152921513111758780] = UnityEngine.Mathf.RoundToInt(f:  UnityEngine.Time.time);
        DailyChallengeGameLevel val_4 = this.CurrentLevel;
        this.OnStarsEarned = DateTimeCheat.Seconds;
        DailyChallengeGameLevel val_6 = this.CurrentLevel;
        this.OnMissedPoint = 0;
        DailyChallengeGameLevel val_7 = this.CurrentLevel;
        this.OnZooTileEarned = 0;
        DailyChallengeGameLevel val_8 = this.CurrentLevel;
        DailyChallengeGameLevel val_9 = this.CurrentLevel;
        mem[1152921513111758772] = this;
    }
    private bool IsChallengeDifferent()
    {
        if((this.<Status>k__BackingField.lastPlayedLevel) != 0)
        {
                this.<Status>k__BackingField.lastPlayedLevel = 1;
        }
        
        bool val_1 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow();
        val_1 = 1 ^ val_1;
        return (bool)val_1;
    }
    private void HandleChallengeSwitch()
    {
        SLCDebug.Log(logMessage:  -84806480, colorHash:  -1835139200, isError:  false);
        PlayingLevel.CompleteLevel(mode:  2, parameters:  0);
        this.<Status>k__BackingField.lastPlayedLevel = new DailyChallengeLastPlayedLevel(isMorning:  false);
    }
    private void FireRequestCallback(bool status)
    {
        if(this.currentRequestCallback != 0)
        {
                this.currentRequestCallback.Invoke(obj:  status);
        }
        
        this.currentRequestCallback = 0;
    }
    public void HandleStarProgress()
    {
        var val_5;
        var val_6;
        var val_7;
        System.DateTime val_8;
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        if(this != 0)
        {
                val_5 = this;
        }
        else
        {
                val_5 = 20;
            val_6 = 1;
        }
        
        mem[20] = 2;
        DailyChallengeGameLevel val_2 = this.CurrentLevel;
        if(this != 0)
        {
                val_7 = this;
            val_8 = this.lastRequestSuccessTime;
        }
        else
        {
                val_7 = 32;
            val_8 = 35615780;
        }
        
        mem[32] = 35615781;
        DailyChallengeGameLevel val_3 = this.CurrentLevel;
        if(this.OnStarsEarned == 0)
        {
                return;
        }
        
        DailyChallengeGameLevel val_4 = this.CurrentLevel;
        this.OnStarsEarned.Invoke(obj:  typeof(WGDailyChallengeManager).__il2cppRuntimeField_E8);
    }
    public float GetProgressPercentage()
    {
        float val_4;
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        if(this.lastMonthRewardCollected != 0)
        {
                DailyChallengeGameLevel val_2 = this.CurrentLevel;
            DailyChallengeGameLevel val_3 = this.CurrentLevel;
            val_4 = (float)this.isRequesting / (float)this.lastMonthRewardCollected;
            return val_4;
        }
        
        val_4 = 0f;
        return val_4;
    }
    public float GetNextProgressTarget()
    {
        twelvegigs.sweepstakes.Distribution val_4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        Add(item:  val_4);
        goto label_6;
        label_4:
        Dispose();
        Add(item:  13152256);
        DailyChallengeGameLevel val_5 = this.CurrentLevel;
        DailyChallengeGameLevel val_6 = this.CurrentLevel;
        this.lastRequestSuccessTime = UnityEngine.Mathf.Min(a:  1094062063, b:  this.lastRequestSuccessTime);
        DailyChallengeGameLevel val_8 = this.CurrentLevel;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (this.lastRequestSuccessTime) << 2) + 16.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        float val_9 = (float)(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (this.lastRequestSuccessTime) << 2) + 16;
        val_9 = val_9 / 100f;
        return (float)val_9;
    }
    public void OnChallengeCompleted()
    {
        var val_9;
        DailyChallengeStatus val_10;
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  -84152560, method:  new IntPtr(4201336000));
        UnityEngine.SceneManagement.SceneManager.remove_activeSceneChanged(value:  162459648);
        this.TrackChallengeComplete();
        if((UnityEngine.PlayerPrefs.HasKey(key:  -84197152)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -84197152);
        }
        
        if((this.<Status>k__BackingField.playingPersistentLevel) != false)
        {
                val_9 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() ^ ((this.<Status>k__BackingField.playingDayMorning) >> 5);
        }
        else
        {
                val_9 = 0;
        }
        
        val_10 = this.<Status>k__BackingField;
        if((this.<Status>k__BackingField) != 0)
        {
            goto label_8;
        }
        
        val_10 = this.<Status>k__BackingField;
        if(val_10 == 0)
        {
            goto label_9;
        }
        
        label_8:
        DailyChallengeGameLevel val_5 = this.CurrentLevel;
        DailyChallengeGameLevel val_6 = this.CurrentLevel;
        if((this.<Status>k__BackingField.playingDayMorning) == true)
        {
                this.<Status>k__BackingField.playingDayMorning = 1;
        }
        
        DailyChallengeLastPlayedLevel val_8 = new DailyChallengeLastPlayedLevel(day:  this.<Status>k__BackingField.playingDay, isMorning:  true, levelId:  R6 + 48, stars:  ???, progress:  this.GetProgressPercentage(), done:  true, isPersistentLevel:  true);
        this.<Status>k__BackingField.lastPlayedLevel = null;
        this.UpdateMonthHistory();
        this.HandleLevelCompletion();
        this.ShowLevelComplete();
        return;
        label_9:
    }
    private void HandleLevelCompletion()
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((-1448559232) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        if((this.<Status>k__BackingField) != 0)
        {
                DailyChallengeGameLevel val_4 = this.CurrentLevel;
            mem[1152921513112765621] = 0;
            PlayingLevel.CompleteLevel(mode:  2, parameters:  0);
        }
        
        DailyChallengeGameLevel val_5 = this.CurrentLevel;
        if(this == 0)
        {
            
        }
    
    }
    private void UpdateMonthHistory()
    {
        var val_19;
        float val_36;
        string val_37;
        System.Collections.Generic.List<ZooTile> val_38;
        bool val_39;
        var val_40;
        var val_41;
        DailyChallenge_MonthHistory val_42;
        int val_43;
        DailyChallenge_WeekHistory val_44;
        int val_45;
        var val_46;
        DailyChallengeSimplifiedLevel val_47;
        var val_48;
        DailyChallengeSimplifiedLevel val_49;
        var val_51;
        var val_52;
        var val_53;
        val_36 = 0;
        string val_1 = this.<Status>k__BackingField.playingDay.ToString();
        val_37 = this.<Status>k__BackingField.playingDay;
        bool val_2 = this.monthHistory.progress.ContainsKey(key:  val_37);
        val_38 = val_2;
        if(val_2 != false)
        {
                val_39 = this.PlayingMorning;
            val_37 = this.monthHistory.progress;
            string val_3 = this.<Status>k__BackingField.playingDay.ToString();
            DailyChallenge_DayProgress val_4 = val_37.Item[this.<Status>k__BackingField.playingDay];
            if(val_39 == false)
        {
                8 = 12;
        }
        
        }
        
        DailyChallengeGameLevel val_5 = this.CurrentLevel;
        if(this <= val_36)
        {
                return;
        }
        
        DailyChallengeGameLevel val_6 = this.CurrentLevel;
        Player val_7 = App.Player;
        if(0 != 0)
        {
                val_40 = 0;
            val_41 = 2165608;
        }
        else
        {
                val_40 = 132;
            val_41 = 2165608;
        }
        
        mem[132] = val_41 + 1152921513113036416;
        val_42 = this.monthHistory;
        if(val_42 != 0)
        {
                val_43 = this.monthHistory.stars;
        }
        else
        {
                val_42 = 8;
            val_43 = 0;
        }
        
        mem[8] = val_43 + 1152921513113036416;
        if((this.dcRevamp != false) && (this.PlayingCurrentWeek() != false))
        {
                val_44 = this.weekHistory;
            if(val_44 != 0)
        {
                val_45 = this.weekHistory.stars;
        }
        else
        {
                val_44 = 8;
            val_45 = mem[8];
        }
        
            mem[8] = val_45 + 1152921513113036416;
        }
        
        this.<RecentStarGained>k__BackingField = 1152921513113036416;
        if(val_38 != false)
        {
                string val_12 = this.<Status>k__BackingField.playingDay.ToString();
            DailyChallenge_DayProgress val_13 = this.monthHistory.progress.Item[this.<Status>k__BackingField.playingDay];
            val_46 = this.monthHistory.progress;
        }
        else
        {
                DailyChallenge_DayProgress val_14 = null;
            val_46 = val_14;
            val_14 = new DailyChallenge_DayProgress();
        }
        
        DailyChallengeGameLevel val_15 = this.CurrentLevel;
        if(this.PlayingMorning == false)
        {
                8 = 12;
        }
        
        typeof(DailyChallenge_DayProgress).__il2cppRuntimeField_C = this;
        string val_16 = this.<Status>k__BackingField.playingDay.ToString();
        if(val_38 != false)
        {
                this.monthHistory.progress.set_Item(key:  this.<Status>k__BackingField.playingDay, value:  370126848);
        }
        else
        {
                this.monthHistory.progress.Add(key:  this.<Status>k__BackingField.playingDay, value:  370126848);
        }
        
        if((this.dcRevamp != false) && (this.PlayingCurrentWeek() != false))
        {
                System.DateTime val_18 = DateTimeCheat.Today;
            System.DayOfWeek val_21 = val_19.DayOfWeek;
            System.DateTime val_22 = DateTimeCheat.Today;
            int val_38 = this.<Status>k__BackingField.playingDay;
            val_38 = ( - (???.Day)) + val_38;
            string val_25 = val_38.ToString();
            if((this.weekHistory.progress.ContainsKey(key:  -83757204)) != false)
        {
                this.weekHistory.progress.set_Item(key:  -83757204, value:  370126848);
        }
        else
        {
                this.weekHistory.progress.Add(key:  -83757204, value:  370126848);
        }
        
        }
        
        if(this.IsPlayingTodaysLevel() != false)
        {
                if(this.PlayingMorning != false)
        {
                this.todaysProgress.morningChallenge.done = true;
            val_47 = this.todaysProgress.morningChallenge;
            val_48 = null;
            val_49 = this.todaysProgress.morningChallenge;
        }
        else
        {
                this.todaysProgress.eveningChallenge.done = true;
            val_47 = this.todaysProgress.eveningChallenge;
            val_48 = null;
            val_49 = this.todaysProgress.eveningChallenge;
        }
        
            typeof(System.Int32[]).__il2cppRuntimeField_10 = val_46;
            typeof(System.Int32[]).__il2cppRuntimeField_14 = val_36;
            DailyChallengeGameLevel val_28 = this.CurrentLevel;
            typeof(System.Int32[]).__il2cppRuntimeField_18 = this;
            mem2[0] = UnityEngine.Mathf.Max(values:  478302960);
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_30 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        DailyChallengeGameLevel val_31 = this.CurrentLevel;
        val_19 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::.ctor();
        val_36 = 1152921510535002416;
        Add(key:  -1930648688, value:  13152256);
        Add(key:  -1144798864, value:  13152256);
        val_38 = 1152921504994172928;
        val_51 = null;
        val_51 = null;
        val_37 = ZooTilePool.MonthlyZooTiles;
        val_39 = null;
        val_39 = new System.Predicate<ZooTile>(object:  -83745152, method:  new IntPtr(4211176528));
        ZooTile val_33 = val_37.Find(match:  8040448);
        if(val_37 != 0)
        {
                val_39 = this.monthZooTileCollection;
            val_37 = val_37;
            if((val_39.Contains(item:  val_37)) != true)
        {
                val_52 = null;
            val_52 = null;
            val_38 = ZooTilePool.MonthlyZooTiles;
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_35 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  -83745152, method:  new IntPtr(4211185744));
            System.Collections.Generic.IEnumerable<TSource> val_36 = System.Linq.Enumerable.Where<System.Object>(source:  val_38, predicate:  7720960);
            object val_37 = System.Linq.Enumerable.First<System.Object>(source:  val_38);
            val_39 = val_38;
            if(this.monthHistory.stars >= (ZooTilePool.MonthlyZooTiles + 12))
        {
                val_53 = null;
            val_53 = null;
            WGDailyChallengeV2Popup.newZooTile = val_37;
            val_39 = this.monthZooTileCollection;
            val_39.Add(item:  val_37);
            val_37 = mem[ZooTilePool.MonthlyZooTiles + 8];
            val_37 = ZooTilePool.MonthlyZooTiles + 8;
            Add(key:  -83773360, value:  val_37);
            if(this.OnZooTileEarned != 0)
        {
                this.OnZooTileEarned.Invoke();
        }
        
        }
        
        }
        
        }
        
        this.UpdateToSever(parameters:  78753792);
    }
    public bool IsMorningChallengePerfectCompletion()
    {
        if(this.todaysProgress.morningChallenge != 0)
        {
                return false;
        }
        
        return false;
    }
    public bool IsEveningChallengePerfectCompletion()
    {
        if(this.todaysProgress.eveningChallenge != 0)
        {
                return false;
        }
        
        return false;
    }
    public bool PlayingCurrentWeek()
    {
        var val_2;
        var val_10;
        ulong val_14;
        DailyChallengeStatus val_17;
        System.DateTime val_1 = DateTimeCheat.Now;
        val_17 = this.<Status>k__BackingField;
        if((this.<Status>k__BackingField) != 0)
        {
            goto label_3;
        }
        
        val_17 = this.<Status>k__BackingField;
        if(val_17 == 0)
        {
            goto label_4;
        }
        
        label_3:
        System.DateTime val_5 = new System.DateTime(year:  val_2.Year, month:  this.<Status>k__BackingField.playingMonth, day:  this.<Status>k__BackingField.playingDay);
        System.DateTime val_6 = DateTimeCheat.Today;
        System.DateTime val_9 = DateTimeCheat.Today;
        System.DayOfWeek val_12 = val_10.DayOfWeek;
        System.DateTime val_13 = AddDays(value:  null);
        return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_5.dateData}, t2:  new System.DateTime() {dateData = val_14});
        label_4:
    }
    private void UpdateToSever(System.Collections.Generic.Dictionary<string, object> parameters)
    {
        var val_11;
        Add(key:  1470926528, value:  13152256);
        Player val_3 = App.Player;
        Add(key:  1618311216, value:  1835037);
        int val_4 = DeviceIdPlugin.GetTimeZone();
        Add(key:  -1928946720, value:  13152256);
        if(this.PlayingMorning == false)
        {
                "m" = "e";
        }
        
        Add(key:  -87253008, value:  1368917616);
        if((this.<HackDateTime>k__BackingField) != false)
        {
                System.DateTime val_5 = DateTimeCheat.Now;
            string val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>().Version.ToString();
            Add(key:  -87252928, value:  -83107472);
        }
        
        Dictionary.Enumerator<TKey, TValue> val_8 = 0.GetEnumerator();
        label_17:
        if(0.MoveNext() == false)
        {
            goto label_15;
        }
        
        Add(key:  R4, value:  0);
        goto label_17;
        label_15:
        0.Dispose();
        var val_11 = 26665910;
        val_11 = 8960148 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_10 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -83095424, method:  new IntPtr(4211846848));
        App.networkManager.DoPut(path:  -87251808, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false);
    }
    private bool IsToday(int day)
    {
        System.DateTime val_1 = DateTimeCheat.Now;
        int val_2 = ???.Day;
        val_2 = val_2 - day;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    private void OnPutResponse(string method, System.Collections.Generic.Dictionary<string, object> response)
    {
        if(response != 0)
        {
                35631268 = "success";
            if((response.ContainsKey(key:  1616271776)) != false)
        {
                object val_2 = response.Item[1616271776];
            if(response != 0)
        {
                this.UpdateDataFromServer(response:  response);
            return;
        }
        
        }
        
        }
        
        UnityEngine.Debug.LogError(message:  -82883136);
    }
    private DailyChallenge_MonthHistory ParseMonthProgress(System.Collections.Generic.Dictionary<string, object> data)
    {
        float val_5;
        WGDailyChallengeManager val_40;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_41;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        val_40 = this;
        val_41 = data;
        DailyChallenge_MonthHistory val_1 = new DailyChallenge_MonthHistory();
        if((val_41.ContainsKey(key:  -82758704)) == false)
        {
            goto label_65;
        }
        
        object val_3 = val_41.Item[-82758704];
        if(val_41 == 0)
        {
            goto label_65;
        }
        
        val_42 = val_41;
        Dictionary.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        label_62:
        if(0.MoveNext() == false)
        {
            goto label_7;
        }
        
        System.Type val_7 = SB.GetType();
        System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(78753792)});
        if((System.Type.op_Equality(left:  SB, right:  78753792)) == false)
        {
            goto label_62;
        }
        
        DailyChallenge_DayProgress val_10 = new DailyChallenge_DayProgress();
        val_43 = 1;
        if((0.ContainsKey(key:  -1125089760)) != false)
        {
                string val_12 = 0.Item[-1125089760];
            val_43 = val_43;
            if((System.Int32.TryParse(s:  null, result: out  int val_13 = -82746564)) != false)
        {
                val_44 = 0;
            if(val_10 == 0)
        {
                val_44 = 0;
        }
        
            var val_40 = 0;
            typeof(DailyChallenge_DayProgress).__il2cppRuntimeField_8 = 0;
            val_40 = val_44 + val_40;
            int val_15 = System.Int32.Parse(s:  null);
            val_43 = val_43;
            if((val_15.IsToday(day:  val_15)) != false)
        {
                mem2[0] = 1;
            DailyChallengeGameLevel val_17 = this.CurrentLevel;
            if((mem[1152921513114047109] != true) && (((this.IsToday(day:  mem[1152921513114047168] + 12)) != false) && ((mem[1152921513114047168] + 17) != 0)))
        {
                mem2[0] = 1;
            mem2[0] = 1;
            val_45 = 0;
            if((mem[1152921513114047168] + 24) == 0)
        {
                val_45 = val_45;
        }
        
            mem2[0] = val_45;
        }
        
            val_43 = val_43;
        }
        
        }
        
        }
        
        if((0.ContainsKey(key:  1368917616)) != false)
        {
                string val_20 = 0.Item[1368917616];
            if((System.Int32.TryParse(s:  null, result: out  int val_21 = -82746568)) != false)
        {
                val_46 = 0;
            if(val_10 == 0)
        {
                val_46 = 0;
        }
        
            var val_41 = val_40;
            typeof(DailyChallenge_DayProgress).__il2cppRuntimeField_C = 0;
            val_41 = val_46 + val_41;
            int val_23 = System.Int32.Parse(s:  null);
            if((val_23.IsToday(day:  val_23)) != false)
        {
                mem2[0] = 1;
            DailyChallengeGameLevel val_25 = this.CurrentLevel;
            if(mem[1152921513114047109] != true)
        {
                if(((mem[1152921513114047109].IsToday(day:  mem[1152921513114047168] + 12)) != false) && ((mem[1152921513114047168] + 17) != 0))
        {
                mem2[0] = 1;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        
        }
        
        }
        
        }
        
        }
        
        DailyChallenge_MonthHistory.__il2cppRuntimeField_byval_arg.Add(key:  0, value:  370126848);
        goto label_62;
        label_7:
        0.Dispose();
        val_40 = val_40;
        val_41 = val_42;
        typeof(DailyChallenge_MonthHistory).__il2cppRuntimeField_8 = val_41;
        if((val_41.ContainsKey(key:  -82758608)) != false)
        {
                string val_28 = val_41.Item[-82758608];
            val_41 = 1152921513114047144;
            bool val_29 = System.DateTime.TryParse(s:  val_41, result: out  new System.DateTime() {dateData = 1152921513114047144});
        }
        
        label_65:
        if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
                return;
        }
        
        if((mem[1152921513114047124] + 20 + 8) == 0)
        {
                return;
        }
        
        System.DateTime val_31 = DateTimeCheat.Now;
        string val_34 = val_5.Day.ToString();
        val_41;
        if((DailyChallenge_MonthHistory.__il2cppRuntimeField_byval_arg.ContainsKey(key:  -82746580)) != true)
        {
                DailyChallenge_DayProgress val_36 = new DailyChallenge_DayProgress();
            DailyChallenge_MonthHistory.__il2cppRuntimeField_byval_arg.Add(key:  -82746580, value:  370126848);
        }
        
        val_42 = 1152921511744995872;
        string val_37 = DailyChallenge_MonthHistory.__il2cppRuntimeField_byval_arg.Item[-82746580];
        string val_38 = DailyChallenge_MonthHistory.__il2cppRuntimeField_byval_arg.Item[-82746580];
        typeof(DailyChallenge_MonthHistory).__il2cppRuntimeField_8 = ((val_46 + (val_44 + 0)) - DailyChallenge_MonthHistory.__il2cppRuntimeField_byval_arg + 8);
        typeof(DailyChallenge_MonthHistory).__il2cppRuntimeField_8 = (mem[1152921513114047124] + 20 + 8 + ((val_46 + (val_44 + 0)) - DailyChallenge_MonthHistory.__il2cppRuntimeField_byval_arg + 8));
        string val_39 = DailyChallenge_MonthHistory.__il2cppRuntimeField_byval_arg.Item[-82746580];
        DailyChallenge_MonthHistory.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_8 = mem[1152921513114047124] + 20 + 8;
    }
    private DailyChallenge_WeekHistory ParseWeekProgress(System.Collections.Generic.Dictionary<string, object> data)
    {
        float val_5;
        WGDailyChallengeManager val_32;
        var val_33;
        var val_34;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_35;
        var val_36;
        var val_37;
        var val_38;
        val_32 = this;
        DailyChallenge_WeekHistory val_1 = new DailyChallenge_WeekHistory();
        val_34 = "week_data";
        if((data.ContainsKey(key:  -82638304)) == false)
        {
            goto label_31;
        }
        
        object val_3 = data.Item[-82638304];
        if(data == 0)
        {
            goto label_31;
        }
        
        val_35 = data;
        Dictionary.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        label_28:
        if(0.MoveNext() == false)
        {
            goto label_7;
        }
        
        System.Type val_7 = SB.GetType();
        System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(78753792)});
        if((System.Type.op_Equality(left:  SB, right:  78753792)) == false)
        {
            goto label_28;
        }
        
        DailyChallenge_DayProgress val_10 = new DailyChallenge_DayProgress();
        val_36 = 1;
        if((0.ContainsKey(key:  -1125089760)) != false)
        {
                string val_12 = 0.Item[-1125089760];
            val_36 = val_36;
            if((System.Int32.TryParse(s:  null, result: out  int val_13 = -82626164)) != false)
        {
                val_37 = 0;
            if(val_10 == 0)
        {
                val_37 = 0;
        }
        
            typeof(DailyChallenge_DayProgress).__il2cppRuntimeField_8 = 0;
            val_36 = val_36;
            var val_32 = 0;
            val_32 = val_37 + val_32;
        }
        
        }
        
        if((0.ContainsKey(key:  1368917616)) != false)
        {
                string val_16 = 0.Item[1368917616];
            if((System.Int32.TryParse(s:  null, result: out  int val_17 = -82626168)) != false)
        {
                val_38 = 0;
            if(val_10 == 0)
        {
                val_38 = 0;
        }
        
            var val_33 = val_32;
            typeof(DailyChallenge_DayProgress).__il2cppRuntimeField_C = 0;
            val_33 = val_38 + val_33;
        }
        
        }
        
        Add(key:  0, value:  370126848);
        goto label_28;
        label_7:
        0.Dispose();
        val_32 = val_32;
        val_34 = 1152921510385703632;
        val_35 = val_35;
        typeof(DailyChallenge_WeekHistory).__il2cppRuntimeField_8 = val_33;
        if((val_35.ContainsKey(key:  -82638208)) != false)
        {
                string val_20 = val_35.Item[-82638208];
            val_34 = 1152921513114167536;
            bool val_21 = System.DateTime.TryParse(s:  val_35, result: out  new System.DateTime() {dateData = 1152921513114167536});
        }
        
        label_31:
        if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
                return;
        }
        
        if((mem[1152921513114167524] + 20 + 8) == 0)
        {
                return;
        }
        
        System.DateTime val_23 = DateTimeCheat.Today;
        System.DayOfWeek val_25 = val_5.DayOfWeek;
        string val_26 = val_5.ToString();
        if((ContainsKey(key:  -82626180)) != true)
        {
                DailyChallenge_DayProgress val_28 = new DailyChallenge_DayProgress();
            Add(key:  -82626180, value:  370126848);
        }
        
        val_33 = 1152921511744995872;
        string val_29 = Item[-82626180];
        val_35 = mem[mem[1152921513114167524] + 20];
        val_35 = mem[1152921513114167524] + 20;
        string val_30 = Item[-82626180];
        typeof(DailyChallenge_WeekHistory).__il2cppRuntimeField_8 = ((val_38 + (val_37 + 0)) - .__il2cppRuntimeField_8);
        typeof(DailyChallenge_WeekHistory).__il2cppRuntimeField_8 = (mem[1152921513114167524] + 20 + 8 + ((val_38 + (val_37 + 0)) - .__il2cppRuntimeField_8));
        string val_31 = Item[-82626180];
        val_34 = mem[mem[1152921513114167524] + 20 + 8];
        val_34 = mem[1152921513114167524] + 20 + 8;
        .__il2cppRuntimeField_8 = val_34;
    }
    private System.Collections.Generic.List<ZooTile> ParseMonthZooTileCollection(System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_9;
        var val_12;
        var val_14;
        float val_15;
        var val_16;
        val_12 = data;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_14 = "zoo_tile_data";
        if((val_12.ContainsKey(key:  -82516880)) == false)
        {
                return;
        }
        
        val_15 = 1152921510385703632;
        object val_3 = val_12.Item[-82516880];
        if(val_12 == 0)
        {
                return;
        }
        
        val_12 = val_12;
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_12 = 0;
        }
        
        if((val_12.ContainsKey(key:  1920624704)) == false)
        {
                return;
        }
        
        string val_5 = val_12.Item[1920624704];
        val_14 = 1152921504687730688;
        val_12 = 0;
        List.Enumerator<T> val_6 = GetEnumerator();
        val_15 = 1152921513113007184;
        label_22:
        if(MoveNext() == false)
        {
            goto label_16;
        }
        
        object val_8 = new System.Object();
        typeof(WGDailyChallengeManager.<>c__DisplayClass122_0).__il2cppRuntimeField_8 = val_9;
        val_16 = null;
        val_16 = null;
        System.Predicate<ZooTile> val_10 = new System.Predicate<ZooTile>(object:  386527232, method:  new IntPtr(4212450512));
        ZooTile val_11 = ZooTilePool.MonthlyZooTiles.Find(match:  8040448);
        Add(item:  ZooTilePool.MonthlyZooTiles);
        goto label_22;
        label_16:
        Dispose();
    }
    private void CheckAndHandleRollover()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 1)
        {
                return;
        }
        
        if(R4.IsDayRollover() != false)
        {
                R4.HandleDayRollover();
            return;
        }
        
        if(R4.IsChallengeDifferent() == false)
        {
                return;
        }
        
        R4.HandleChallengeSwitch();
    }
    private bool IsDayRollover()
    {
        System.DateTime val_1 = DateTimeCheat.Today;
        double val_2 = ???.ToOADate();
        double val_4 = System.Math.Abs(4212695696 - (this.<Status>k__BackingField.oa_date));
        if(System.Math.__il2cppRuntimeField_cctor_finished > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public void HandleDayRollover()
    {
        PlayingLevel.CompleteLevel(mode:  2, parameters:  0);
        System.DateTime val_1 = DateTimeCheat.Today;
        double val_2 = ???.ToOADate();
        this.<Status>k__BackingField.oa_date = 4212828176;
        this.<Status>k__BackingField.lastPlayedLevel = new DailyChallengeLastPlayedLevel(isMorning:  WGDailyChallengeManagerHelper.MorningChallengeAvailableNow());
        this.todaysProgress = new DailyChallengeProgress();
        if(this.todaysProgress != 0)
        {
                return;
        }
    
    }
    public void OnPointsGained(string word)
    {
        double val_4;
        bool val_5;
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        if(this != 0)
        {
                val_4 = this;
            val_5 = this.isRequesting;
        }
        else
        {
                val_4 = 24;
            val_5 = 0;
        }
        
        mem[24] = val_5 + 1;
        if(word != null)
        {
                DailyChallengeGameLevel val_3 = this.CurrentLevel;
            val_4 = this.EPSILON;
            val_4.Add(item:  word);
        }
        
        DailyChallengeGameLevel val_4 = this.CurrentLevel;
        if(this == 0)
        {
            
        }
    
    }
    public bool IsWeekRewardAvailable()
    {
        var val_5;
        ulong val_9;
        System.DateTime val_1 = DateTimeCheat.Today;
        System.DateTime val_4 = DateTimeCheat.Today;
        System.DayOfWeek val_7 = val_5.DayOfWeek;
        System.DateTime val_8 = AddDays(value:  null);
        return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_9}, t2:  new System.DateTime() {dateData = this.lastWeekRewardCollected});
    }
    public bool IsMonthRewardAvailable()
    {
        var val_5;
        ulong val_9;
        System.DateTime val_1 = DateTimeCheat.Today;
        System.DateTime val_4 = DateTimeCheat.Today;
        int val_7 = val_5.Day;
        val_7 = 0 - val_7;
        System.DateTime val_8 = AddDays(value:  null);
        return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_9}, t2:  new System.DateTime() {dateData = this.lastMonthRewardCollected});
    }
    public bool IsPlayingPersistentLevel()
    {
        if((this.<Status>k__BackingField) != 0)
        {
                return (bool)this.<Status>k__BackingField.playingPersistentLevel;
        }
        
        return (bool)this.<Status>k__BackingField.playingPersistentLevel;
    }
    public bool IsPlayingTodaysLevel()
    {
        System.DateTime val_1 = DateTimeCheat.Now;
        int val_2 = ???.Day;
        val_2 = (this.<Status>k__BackingField.playingDay) - val_2;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    public bool CurrentChallengeComplete()
    {
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        if(this != 0)
        {
                return (bool)this.monthZooTileCollection;
        }
        
        return (bool)this.monthZooTileCollection;
    }
    public void ShowLevelComplete()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public DailyChallengeLastPlayedLevel GetLastPlayedLevel()
    {
        if((this.<Status>k__BackingField) != 0)
        {
                return;
        }
    
    }
    public bool IsPlayingValid()
    {
        System.DateTime val_1 = DateTimeCheat.Now;
        int val_2 = ???.Month;
        val_2 = (this.<Status>k__BackingField.playingMonth) - val_2;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    private void OnAppleAwarded(int appleAwarded)
    {
        var val_11;
        var val_12;
        DailyChallengeProgress val_13;
        val_11 = 35631281;
        if(this.PlayingMorning == false)
        {
                this.PlayingMorning = this.PlayingEvening;
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = GetWindow<System.Object>();
        val_11 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        if(isActiveAndEnabled != false)
        {
                return;
        }
        
        DailyChallengeGameLevel val_4 = this.CurrentLevel;
        if(this != 0)
        {
                val_12 = this;
            val_13 = this.todaysProgress;
        }
        else
        {
                val_12 = 52;
            val_13 = 6;
        }
        
        mem[52] = val_13 + appleAwarded;
        DailyChallengeGameLevel val_6 = this.CurrentLevel;
        DailyChallengeGameLevel val_8 = this.CurrentLevel;
        this.monthHistory = UnityEngine.Mathf.Max(a:  WordStreak.LargestStreak, b:  this.monthHistory);
        DailyChallengeGameLevel val_10 = this.CurrentLevel;
        if(this == 0)
        {
            
        }
    
    }
    private void RunLevelGenerationPrep()
    {
        float val_13;
        var val_15;
        var val_23;
        var val_24;
        var val_25;
        System.Func<StarTier, System.Int32, __f__AnonymousType0__value_j__TPar, _index_j__TPar_<StarTier, System.Int32>> val_27;
        var val_28;
        System.Func<__f__AnonymousType0__value_j__TPar, _index_j__TPar_<StarTier, System.Int32>, System.Boolean> val_30;
        var val_31;
        System.Func<__f__AnonymousType0__value_j__TPar, _index_j__TPar_<StarTier, System.Int32>, System.Int32> val_33;
        var val_34;
        DailyChallengeDefinition val_35;
        var val_36;
        WGDailyChallengeManager val_37;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Single>, System.Single> val_39;
        int val_40;
        var val_41;
        DailyChallengeEconomy val_42;
        var val_43;
        DailyChallengeEconomy val_44;
        var val_45;
        DailyChallengeEconomy val_46;
        val_24 = 1152921504993267712;
        val_25 = null;
        val_25 = null;
        val_27 = WGDailyChallengeManager.<>c.<>9__136_0;
        if(val_27 == 0)
        {
                val_27 = null;
            val_27 = new System.Func<System.Object, System.Int32, System.Object>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4214151632));
            WGDailyChallengeManager.<>c.<>9__136_0 = val_27;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_3 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  this.<Econ>k__BackingField.StarTiers.Tiers, selector:  7774208);
        val_28 = null;
        val_28 = null;
        val_30 = WGDailyChallengeManager.<>c.<>9__136_1;
        if(val_30 == 0)
        {
                val_30 = null;
            val_24 = 1152921504993267712;
            val_30 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4214154704));
            WGDailyChallengeManager.<>c.<>9__136_1 = val_30;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_5 = System.Linq.Enumerable.Where<System.Object>(source:  this.<Econ>k__BackingField.StarTiers.Tiers, predicate:  7720960);
        val_31 = null;
        val_33 = WGDailyChallengeManager.<>c.<>9__136_2;
        if(val_33 == 0)
        {
                val_33 = null;
            val_33 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4214157776));
            WGDailyChallengeManager.<>c.<>9__136_2 = val_33;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_7 = System.Linq.Enumerable.Select<System.Object, System.Int32>(source:  this.<Econ>k__BackingField.StarTiers.Tiers, selector:  7720960);
        bool val_8 = System.Linq.Enumerable.Any<System.Int32>(source:  this.<Econ>k__BackingField.StarTiers.Tiers);
        if(val_8 == false)
        {
            goto label_18;
        }
        
        val_34 = System.Linq.Enumerable.First<System.Int32>(source:  this.<Econ>k__BackingField.StarTiers.Tiers);
        if((this.<Econ>k__BackingField.StarTiers.Tiers) != 0)
        {
            goto label_20;
        }
        
        goto label_20;
        label_18:
        val_34 = val_8 - 1;
        label_20:
        if(val_8 <= val_34)
        {
                var val_23 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_23 = val_23 + (val_34 << 2);
        DailyChallengeGameLevel val_10 = this.CurrentLevel;
        if(this <= val_34)
        {
                var val_24 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_24 = val_24 + (val_34 << 2);
        this.<Status>k__BackingField = (0 + ((val_8 - 1)) << 2) + 16;
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_11 = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
        Dictionary.Enumerator<TKey, TValue> val_12 = GetEnumerator();
        float val_25 = 0f;
        label_29:
        if(0.MoveNext() == false)
        {
            goto label_27;
        }
        
        val_25 = val_25 + val_15;
        Add(key:  0, value:  null);
        goto label_29;
        label_27:
        0.Dispose();
        label_56:
        val_35 = new System.Object();
        val_36 = null;
        val_37 = this;
        val_39 = WGDailyChallengeManager.<>c.<>9__136_3;
        if(val_39 == 0)
        {
                val_39 = null;
            val_39 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Single>, System.Single>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4214165968));
            WGDailyChallengeManager.<>c.<>9__136_3 = val_39;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_17 = System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Int32, System.Single>, System.Single>(source:  78753792, keySelector:  7720960);
        float val_18 = UnityEngine.Random.Range(min:  null, max:  null);
        float val_26 = 100f;
        val_26 = 0 / val_26;
        typeof(WGDailyChallengeManager.<>c__DisplayClass136_0).__il2cppRuntimeField_8 = val_26;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Single>, System.Boolean> val_19 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Single>, System.Boolean>(object:  386580480, method:  new IntPtr(4214169040));
        val_40 = null;
        val_41 = null;
        System.Collections.Generic.KeyValuePair<System.Int32, System.Single> val_20 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<System.Int32, System.Single>>(source:  -80754600, predicate:  78753792);
        this.<Econ>k__BackingField.ChallengeDefinition.LettersLength = val_13;
        val_42 = this.<Econ>k__BackingField;
        val_43 = val_42;
        if(val_42 == 0)
        {
                val_44 = this.<Econ>k__BackingField;
            if(val_44 == 0)
        {
            goto label_53;
        }
        
        }
        
        val_35 = this.<Econ>k__BackingField.ChallengeDefinition;
        val_40 = val_13;
        val_23 = 1152921511702058544;
        val_41 = public System.Collections.Generic.List<System.Int32> System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.Int32>>::get_Item(System.Int32 key);
        System.Collections.Generic.List<System.Int32> val_21 = this.<Econ>k__BackingField.ChallengeDefinition.LettersWordCount.Item[val_40];
        if((this.<Econ>k__BackingField.ChallengeDefinition.LettersWordCount) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.<Econ>k__BackingField.ChallengeDefinition.MaxRequiredWordsAmount = 1;
        val_42 = this.<Econ>k__BackingField;
        val_45 = val_42;
        if(val_42 == 0)
        {
                val_46 = this.<Econ>k__BackingField;
            if(val_46 == 0)
        {
            goto label_53;
        }
        
        }
        
        System.Collections.Generic.List<System.Int32> val_22 = this.<Econ>k__BackingField.ChallengeDefinition.LettersWordCount.Item[val_13];
        if((this.<Econ>k__BackingField.ChallengeDefinition.LettersWordCount) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.<Econ>k__BackingField.ChallengeDefinition.MinRequiredWordsAmount = 2621443;
        return;
        label_53:
        if(val_40 != 1)
        {
            goto label_54;
        }
        
        0.Dispose();
        if(null == 0)
        {
            goto label_56;
        }
        
        goto label_56;
        label_54:
    }
    private GameLevel GenerateOrLoadLevel(string levelName, int tries = 0, GameplayMode mode = 2)
    {
        int val_15;
        var val_16;
        var val_17;
        DailyChallengeDefinition val_18;
        var val_19;
        val_15 = this;
        int val_16 = tries;
        val_16 = 1152921504982192128;
        label_45:
        var val_15 = 26679599;
        val_15 = 8951684 + val_15;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1448559232) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        GameLevel val_4 = PlayingLevel.GetCurrentDailyChallengeLevel();
        if(0 != 0)
        {
                val_17 = 0;
            0 = mode;
        }
        
        if(0 != 3)
        {
            goto label_12;
        }
        
        label_46:
        this.RunLevelGenerationPrep();
        int val_6 = UnityEngine.Random.Range(min:  this.<Econ>k__BackingField.ChallengeDefinition.MinRequiredWordsAmount, max:  (this.<Econ>k__BackingField.ChallengeDefinition.MaxRequiredWordsAmount) + 1);
        GameBehavior val_7 = App.getBehavior;
        if(0 != 0)
        {
            goto label_21;
        }
        
        if(new DynamicLevelBuildParams() != 0)
        {
                typeof(DynamicLevelBuildParams).__il2cppRuntimeField_20 = this.<Econ>k__BackingField.ChallengeDefinition.LettersLength;
        }
        else
        {
                mem[32] = this.<Econ>k__BackingField.ChallengeDefinition.LettersLength;
        }
        
        typeof(DynamicLevelBuildParams).__il2cppRuntimeField_8 = val_6;
        typeof(DynamicLevelBuildParams).__il2cppRuntimeField_C = this.<Econ>k__BackingField.ChallengeDefinition.MinRequiredLength;
        typeof(DynamicLevelBuildParams).__il2cppRuntimeField_10 = this.<Econ>k__BackingField.ChallengeDefinition.MinRequiredLength;
        typeof(DynamicLevelBuildParams).__il2cppRuntimeField_1E = 0;
        typeof(DynamicLevelBuildParams).__il2cppRuntimeField_14 = this.<Econ>k__BackingField.ChallengeDefinition.MinRequiredLength;
        typeof(DynamicLevelBuildParams).__il2cppRuntimeField_1C = 1;
        WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        GameLevel val_10 = GetDynamicDailyChallengeLevel(param:  384184320);
        val_17 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance();
        val_18 = this.<Econ>k__BackingField.ChallengeDefinition;
        if(val_16 <= 19)
        {
            goto label_39;
        }
        
        goto label_54;
        label_39:
        val_16 = val_16 + 1;
        goto label_45;
        label_12:
        if(8 != 0)
        {
            goto label_46;
        }
        
        return;
        label_21:
        WordPets.WPTDataParser val_11 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_15 = this.<Econ>k__BackingField.ChallengeDefinition.LettersLength;
        GameLevel val_12 = GetDynamicDailyChallengeLevel(wordLength:  val_15, wordCount:  val_6, maxWordCount:  val_6);
        val_17 = public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance();
        if((public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance()) == 0)
        {
                val_17 = 0;
        }
        
        label_54:
        val_19 = 0;
        levelName = levelName;
        PlayingLevel.SetLevel(currentMode:  mode, level:  -2101986464, parameters:  0, skipSaving:  false);
    }
    public int GetGoldenAppleReward()
    {
        var val_4;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 1152921512824079784;
            return (int)val_4;
        }
        
        DailyChallengeGameLevel val_3 = this.CurrentLevel;
        if(this <= R6)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + ((R6) << 2);
        val_4 = (0 + (R6) << 2) + 16;
        val_4.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        return (int)val_4;
    }
    public int GetMatchingDayDistance()
    {
        var val_20;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, DailyChallenge_DayProgress>, System.Int32> val_22;
        var val_23;
        var val_24;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, DailyChallenge_DayProgress>, System.Boolean> val_26;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, DailyChallenge_DayProgress>, System.Int32> val_27;
        var val_28;
        var val_30;
        object val_1 = new System.Object();
        typeof(WGDailyChallengeManager.<>c__DisplayClass139_0).__il2cppRuntimeField_8 = this.<Status>k__BackingField.todayOnCalendar;
        System.Func<System.Collections.Generic.KeyValuePair<TRVExpert, TRVExpertDisplay>, System.Boolean> val_2 = new System.Func<System.Collections.Generic.KeyValuePair<TRVExpert, TRVExpertDisplay>, System.Boolean>(object:  386633728, method:  new IntPtr(4214778448));
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  this.monthHistory.progress, predicate:  7720960);
        val_20 = null;
        val_20 = null;
        val_22 = WGDailyChallengeManager.<>c.<>9__139_1;
        if(val_22 == 0)
        {
                val_22 = null;
            val_22 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, DailyChallenge_DayProgress>, System.Int32>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4214781520));
            WGDailyChallengeManager.<>c.<>9__139_1 = val_22;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_5 = System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Object, System.Object>, System.Int32>(source:  this.monthHistory.progress, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  this.monthHistory.progress);
        object val_7 = new System.Object();
        val_23 = val_1;
        typeof(WGDailyChallengeManager.<>c__DisplayClass139_1).__il2cppRuntimeField_8 = 1;
        System.Func<System.Collections.Generic.KeyValuePair<TRVExpert, TRVExpertDisplay>, System.Boolean> val_8 = new System.Func<System.Collections.Generic.KeyValuePair<TRVExpert, TRVExpertDisplay>, System.Boolean>(object:  386686976, method:  new IntPtr(4214786640));
        if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.String, DailyChallenge_DayProgress>>(source:  this.monthHistory.progress, predicate:  7720960)) != true)
        {
                string val_10 = typeof(WGDailyChallengeManager.<>c__DisplayClass139_1).__il2cppRuntimeField_8.ToString();
            DailyChallenge_DayProgress val_11 = new DailyChallenge_DayProgress();
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_12 = new System.Collections.Generic.KeyValuePair<System.String, System.String>(key:  386686984, value:  370126848);
            this.monthHistory.progress.Add(item:  new System.Collections.Generic.KeyValuePair<System.String, DailyChallenge_DayProgress>() {Value = val_12.Value});
            val_23 = val_1;
        }
        
        WGDailyChallengeManager.<>c__DisplayClass139_1.__il2cppRuntimeField_name.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = (typeof(WGDailyChallengeManager.<>c__DisplayClass139_1).__il2cppRuntimeField_8 + 1);
        val_24 = null;
        val_24 = null;
        val_26 = WGDailyChallengeManager.<>c.<>9__139_2;
        if(val_26 == 0)
        {
                val_26 = null;
            val_26 = new System.Func<System.Collections.Generic.KeyValuePair<TRVExpert, TRVExpertDisplay>, System.Boolean>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4214789712));
            WGDailyChallengeManager.<>c.<>9__139_2 = val_26;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_14 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  this.monthHistory.progress, predicate:  7720960);
        System.Collections.Generic.List<TSource> val_15 = System.Linq.Enumerable.ToList<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  this.monthHistory.progress);
        val_27 = this.monthHistory.progress;
        if(this.monthHistory.progress != 0)
        {
                val_28 = null;
            val_28 = null;
            val_27 = WGDailyChallengeManager.<>c.<>9__139_3;
            if(val_27 == 0)
        {
                val_27 = null;
            val_27 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, DailyChallenge_DayProgress>, System.Int32>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4214790736));
            WGDailyChallengeManager.<>c.<>9__139_3 = val_27;
        }
        
            System.Linq.IOrderedEnumerable<TSource> val_17 = System.Linq.Enumerable.OrderByDescending<System.Collections.Generic.KeyValuePair<System.Object, System.Object>, System.Int32>(source:  this.monthHistory.progress, keySelector:  7720960);
            System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_18 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  -80161536);
            int val_19 = System.Int32.Parse(s:  val_12.Value);
            return (int)val_30;
        }
        
        val_30 = 0;
        return (int)val_30;
    }
    public System.Collections.Generic.List<ZooTile> GetLifetimeMonthlyZootiles()
    {
        var val_3;
        System.Collections.Generic.List<ZooTile> val_1 = this.ZooTileCollection;
        val_3 = null;
        val_3 = null;
        System.Collections.Generic.IEnumerable<TSource> val_2 = System.Linq.Enumerable.Except<System.Object>(first:  -80025200, second:  ZooTilePool.LifetimeZooTiles);
        return System.Linq.Enumerable.ToList<System.Object>(source:  -80025200);
    }
    public bool IsTooltipReadyToShow()
    {
        int val_5;
        DailyChallengeStatus val_6;
        var val_7;
        val_5 = 1152921504901095424;
        val_6 = 1152921511748222336;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1448559232) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = 0;
        }
        
        val_7 = 0;
        if(SceneDictator.IsInGameScene() == false)
        {
                return true;
        }
        
        val_6 = this.<Status>k__BackingField;
        val_5 = this.<Status>k__BackingField.lastPlayedLevel.day;
        if(val_5 != (this.<Status>k__BackingField.todayOnCalendar))
        {
                return true;
        }
        
        if((this.<Status>k__BackingField.lastPlayedLevel.done) == true)
        {
                val_7 = 1;
        }
        
        return true;
    }
    public decimal GetRetryCost()
    {
        if((R1 + 96 + 17) == 0)
        {
                8 = 12;
        }
        
        decimal val_1 = System.Decimal.op_Implicit(value:  -79760240);
        return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
    }
    public void CollectWeeklyReward()
    {
        var val_6;
        if(this.IsWeekRewardAvailable() == false)
        {
            goto label_1;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
            goto label_6;
        }
        
        0.Setup(rewardSource:  10);
        goto label_7;
        label_1:
        SLCDebug.Log(logMessage:  -79672240, colorHash:  -1835139200, isError:  true);
        return;
        label_6:
        0.Setup(rewardSource:  10);
        label_7:
        System.Action val_4 = new System.Action(object:  -79646976, method:  new IntPtr(4215295296));
        System.Delegate val_5 = System.Delegate.Combine(a:  52, b:  7454720);
        val_6 = 52;
        if(val_6 != 0)
        {
                if(6 == null)
        {
            goto label_12;
        }
        
        }
        
        val_6 = 0;
        label_12:
        mem[28] = val_6;
    }
    public void CollectMonthlyReward()
    {
        var val_6;
        if(this.IsMonthRewardAvailable() == false)
        {
            goto label_1;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
            goto label_6;
        }
        
        0.Setup(rewardSource:  11);
        goto label_7;
        label_1:
        SLCDebug.Log(logMessage:  -79558976, colorHash:  -1835139200, isError:  true);
        return;
        label_6:
        0.Setup(rewardSource:  11);
        label_7:
        System.Action val_4 = new System.Action(object:  -79533712, method:  new IntPtr(4215408560));
        System.Delegate val_5 = System.Delegate.Combine(a:  52, b:  7454720);
        val_6 = 52;
        if(val_6 != 0)
        {
                if(6 == null)
        {
            goto label_12;
        }
        
        }
        
        val_6 = 0;
        label_12:
        mem[28] = val_6;
    }
    private void OnWeeklyRewardCollected()
    {
        System.DateTime val_1 = DateTimeCheat.Now;
        this.lastWeekRewardCollected = new System.DateTime();
        if(this.OnWeeklyMonthlyRewardCollected != 0)
        {
                this.OnWeeklyMonthlyRewardCollected.Invoke();
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_3 = this.lastWeekRewardCollected.ToString();
        Add(key:  -82638208, value:  this.lastWeekRewardCollected);
        this.UpdateToSever(parameters:  78753792);
    }
    private void OnMonthlyRewardCollected()
    {
        System.DateTime val_1 = DateTimeCheat.Now;
        this.lastMonthRewardCollected = new System.DateTime();
        if(this.OnWeeklyMonthlyRewardCollected != 0)
        {
                this.OnWeeklyMonthlyRewardCollected.Invoke();
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_3 = this.lastMonthRewardCollected.ToString();
        Add(key:  -82758608, value:  this.lastMonthRewardCollected);
        this.UpdateToSever(parameters:  78753792);
    }
    private void TrackChallengeComplete()
    {
        System.DateTime val_4;
        var val_37;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_38;
        var val_39;
        var val_40;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_41;
        var val_42;
        val_37 = this;
        string val_1 = this.GetLevelForTracking();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.DateTime val_3 = DateTimeCheat.Now;
        string val_6 = val_4.ToString();
        val_38 = null;
        if(null == 0)
        {
                val_38 = null;
        }
        
        Add(key:  -1898276784, value:  -79172672);
        val_39 = val_38;
        if(val_38 == 0)
        {
                val_39 = null;
        }
        
        Add(key:  -2085463936, value:  -79160624);
        Add(key:  -87614368, value:  13152256);
        DailyChallengeGameLevel val_7 = this.CurrentLevel;
        Add(key:  -2100067936, value:  13152256);
        DailyChallengeGameLevel val_8 = this.CurrentLevel;
        Add(key:  -2100067840, value:  13152256);
        DailyChallengeGameLevel val_9 = this.CurrentLevel;
        Add(key:  -487709632, value:  13152256);
        DailyChallengeGameLevel val_10 = this.CurrentLevel;
        Add(key:  -87610176, value:  8945664);
        Add(key:  -1598580112, value:  8945664);
        if((this.<Status>k__BackingField.playingPersistentLevel) != false)
        {
                DailyChallengeGameLevel val_11 = this.CurrentLevel;
            val_4 = this.lastMonthRewardCollected;
            Add(key:  -87606000, value:  8945664);
        }
        
        DailyChallengeGameLevel val_12 = this.CurrentLevel;
        DailyChallengeGameLevel val_13 = this.CurrentLevel;
        System.DateTime val_37 = this.EPSILON + 12;
        val_37 = this.lastMonthRewardCollected - val_37;
        val_4 = val_37;
        Add(key:  -87605888, value:  13152256);
        int val_14 = this.GetTimeSpent();
        val_40 = null;
        if(null == 0)
        {
                val_40 = null;
        }
        
        Add(key:  -87605776, value:  13152256);
        DailyChallengeGameLevel val_15 = this.CurrentLevel;
        Add(key:  -87605680, value:  13152256);
        val_41 = 1152921504892043264;
        GameBehavior val_16 = App.getBehavior;
        if(0 != 0)
        {
                DailyChallengeGameLevel val_17 = this.CurrentLevel;
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.monthHistory = null;
        }
        
        DailyChallengeGameLevel val_19 = this.CurrentLevel;
        val_4 = this.monthHistory;
        Add(key:  -79193040, value:  13152256);
        GameBehavior val_20 = App.getBehavior;
        if(0 != 0)
        {
                DailyChallengeGameLevel val_21 = this.CurrentLevel;
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.todaysProgress = null;
        }
        
        DailyChallengeGameLevel val_23 = this.CurrentLevel;
        val_4 = this.todaysProgress;
        Add(key:  -79188832, value:  13152256);
        DailyChallengeGameLevel val_24 = this.CurrentLevel;
        Add(key:  -87601392, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AppendDailyChallengeCompleteData(curData: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_26 = -79172664);
        var val_38 = 26670002;
        val_38 = 8955536 + val_38;
        if(val_38 == 0)
        {
                mem2[0] = 1;
        }
        
        val_42 = null;
        val_42 = null;
        App.trackerManager.track(eventName:  -1942282592, data:  78753792);
        if(WordStreak.ApplesFromStreak >= 1)
        {
                val_37 = val_41;
            Player val_28 = App.Player;
            val_38 = 0;
            val_4 = WordStreak.LargestStreak;
            string val_30 = -276665680(-276665680) + 13152256;
            int val_31 = WordStreak.ApplesFromStreak;
            string val_32 = val_31.ToString();
            0.TrackNonCoinReward(source:  -1644596640, subSource:  -276665680, rewardType:  -1238435648, rewardAmount:  val_31, additionalParams:  val_38);
            val_41 = val_37;
        }
        
        if(ExtraWord.ApplesFromExtra < 1)
        {
                return;
        }
        
        val_41 = 0;
        Player val_34 = App.Player;
        int val_35 = ExtraWord.ApplesFromExtra;
        string val_36 = val_35.ToString();
        0.TrackNonCoinReward(source:  -2092882720, subSource:  null, rewardType:  -1238435648, rewardAmount:  val_35, additionalParams:  val_41);
    }
    public string GetStageForTracking()
    {
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() == true)
        {
                "e" = "m";
        }
    
    }
    public string GetLevelForTracking()
    {
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        if(this.monthHistory != 0)
        {
                return this.monthHistory.Replace(oldValue:  -2100450224, newValue:  1098586544);
        }
        
        return this.monthHistory.Replace(oldValue:  -2100450224, newValue:  1098586544);
    }
    public void OnStarsSaved()
    {
        var val_3;
        System.Action val_4;
        DailyChallengeGameLevel val_1 = this.CurrentLevel;
        if(this != 0)
        {
                val_3 = this;
            val_4 = this.OnWeeklyMonthlyRewardCollected;
        }
        else
        {
                val_3 = 92;
            val_4 = 0;
        }
        
        mem[92] = 1;
        DailyChallengeGameLevel val_2 = this.CurrentLevel;
        if(this == 0)
        {
            
        }
    
    }
    public string Hack_GetTileInfo()
    {
        var val_16;
        var val_17;
        System.Func<ZooTile, System.String> val_19;
        var val_20;
        System.Func<ZooTile, System.String> val_22;
        var val_23;
        System.Text.StringBuilder val_2 = AppendFormat(format:  -78691568, arg0:  this.monthHistory.tile);
        val_16 = null;
        val_16 = null;
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Except<System.Object>(first:  ZooTilePool.MonthlyZooTiles, second:  this.monthZooTileCollection);
        val_17 = null;
        val_17 = null;
        val_19 = WGDailyChallengeManager.<>c.<>9__151_0;
        if(val_19 == 0)
        {
                val_19 = null;
            val_19 = new System.Func<ZooTile, System.String>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4216280192));
            WGDailyChallengeManager.<>c.<>9__151_0 = val_19;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_5 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  ZooTilePool.MonthlyZooTiles, selector:  7720960);
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.Object>(source:  ZooTilePool.MonthlyZooTiles);
        string val_7 = MiniJSON.Json.Serialize(obj:  ZooTilePool.MonthlyZooTiles);
        System.Text.StringBuilder val_8 = AppendFormat(format:  -78687296, arg0:  ZooTilePool.MonthlyZooTiles);
        System.Collections.Generic.List<ZooTile> val_9 = this.ZooTileCollection;
        val_20 = null;
        val_20 = null;
        val_22 = WGDailyChallengeManager.<>c.<>9__151_1;
        val_23 = "All Tile Collection: <color=#77BB66>{0}</color>\n\n";
        if(val_22 == 0)
        {
                val_22 = null;
            val_22 = new System.Func<ZooTile, System.String>(object:  WGDailyChallengeManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4216282416));
            val_23 = val_23;
            WGDailyChallengeManager.<>c.<>9__151_1 = val_22;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_11 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  -78659856, selector:  7720960);
        System.Collections.Generic.List<TSource> val_12 = System.Linq.Enumerable.ToList<System.Object>(source:  -78659856);
        string val_13 = MiniJSON.Json.Serialize(obj:  -78659856);
        if(new System.Text.StringBuilder() != 0)
        {
                System.Text.StringBuilder val_14 = AppendFormat(format:  -78685056, arg0:  -78659856);
        }
        else
        {
                System.Text.StringBuilder val_15 = AppendFormat(format:  -78685056, arg0:  -78659856);
        }
    
    }
    public string Hack_GetLevelInfo()
    {
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        DailyChallengeGameLevel val_2 = this.CurrentLevel;
        System.Text.StringBuilder val_3 = AppendFormat(format:  -731768320, arg0:  this.monthHistory);
        DailyChallengeGameLevel val_4 = this.CurrentLevel;
        System.Text.StringBuilder val_5 = AppendFormat(format:  -731768176, arg0:  this.todaysProgress);
        DailyChallengeGameLevel val_6 = this.CurrentLevel;
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_7 = AppendFormat(format:  -731768032, arg0:  this.weekHistory);
        }
        else
        {
                System.Text.StringBuilder val_8 = AppendFormat(format:  -731768032, arg0:  this.weekHistory);
        }
        
        System.Text.StringBuilder val_9 = Append(value:  '
        ');
        DailyChallengeGameLevel val_10 = this.CurrentLevel;
        if((this.<Status>k__BackingField) != 0)
        {
                DailyChallengeGameLevel val_11 = this.CurrentLevel;
            string val_12 = this.<Status>k__BackingField.ToJSON();
            System.Text.StringBuilder val_13 = AppendFormat(format:  -78539088, arg0:  this.<Status>k__BackingField);
        }
        
        System.Text.StringBuilder val_14 = AppendFormat(format:  -78530736, arg0:  13152256);
        System.Text.StringBuilder val_15 = AppendFormat(format:  -78522384, arg0:  13152256);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_16 = AppendFormat(format:  -78514032, arg0:  13152256);
            return;
        }
        
        System.Text.StringBuilder val_17 = AppendFormat(format:  -78514032, arg0:  13152256);
    }
    public void Hack_ResetMonthTileOnServer()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -78356816, value:  8945664);
        this.UpdateToSever(parameters:  78753792);
    }
    public void Hack_FillStars(int days)
    {
        var val_4;
        var val_5;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_2 = App.Player;
        if(0 != 0)
        {
                val_4 = 0;
            val_5 = 2165608;
        }
        else
        {
                val_4 = 132;
            val_5 = 2165608;
        }
        
        int val_3 = days + (days << 1);
        val_3 = val_5 + (val_3 << 1);
        mem[132] = val_3;
        Add(key:  -78244704, value:  13152256);
        this.UpdateToSever(parameters:  78753792);
    }
    public void Hack_ResetDailyChallenge()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -78132608, value:  8945664);
        this.UpdateToSever(parameters:  78753792);
        this.Hack_ResetLastPlayedTime();
    }
    public void Hack_MonthTileCollection()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -78020512, value:  8945664);
        this.UpdateToSever(parameters:  78753792);
    }
    public void Hack_CompleteMonthStars()
    {
        var val_4;
        var val_8;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_2 = App.Player;
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        int val_11 = System.DateTime.DaysInMonth(year:  val_4.Year, month:  val_8.Month);
        val_11 = val_11 + (val_11 << 1);
        val_11 = (3.034663E-39f) + (val_11 << 1);
        mem[132] = val_11;
        Add(key:  -77908400, value:  8945664);
        this.UpdateToSever(parameters:  78753792);
    }
    public void Hack_CompleteWeekStars()
    {
        var val_3;
        var val_4;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_2 = App.Player;
        if(0 != 0)
        {
                val_3 = 0;
            val_4 = 2165608;
        }
        else
        {
                val_3 = 132;
            val_4 = 2165608;
        }
        
        mem[132] = 2165650;
        Add(key:  -77796288, value:  8945664);
        this.UpdateToSever(parameters:  78753792);
    }
    public void Hack_ResetLastPlayedTime()
    {
        var val_2;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -89818448)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -89818448);
        }
        
        val_2 = null;
        val_2 = null;
        this._LastPlayedDailyChallenge = System.DateTime.MinValue;
    }
    public WGDailyChallengeManager()
    {
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        this.dcRevamp = false;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.monthZooTileCollection = null;
        this.monthHistory = new DailyChallenge_MonthHistory();
        this.todaysProgress = new DailyChallengeProgress();
        this.weekHistory = new DailyChallenge_WeekHistory();
        val_10 = null;
        val_10 = null;
        this._LastPlayedDailyChallenge = System.DateTime.MinValue;
        this.missedChallengeLevel = new DailyChallengeGameLevel();
        this.answers = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.extraWords = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<System.Int32> val_9 = new System.Collections.Generic.List<System.Int32>();
        this.actualWordsCount = null;
    }
    private static WGDailyChallengeManager()
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        WGDailyChallengeManager.lastServerCall = new System.DateTime();
        WGDailyChallengeManager.secondsUntilNextRequest = 30;
    }
    private bool <UpdateMonthHistory>b__113_0(ZooTile x)
    {
        if(this.monthHistory != 0)
        {
                return System.String.op_Equality(a:  x.name, b:  this.monthHistory.tile);
        }
        
        return System.String.op_Equality(a:  x.name, b:  this.monthHistory.tile);
    }
    private bool <UpdateMonthHistory>b__113_1(ZooTile x)
    {
        if(this.monthHistory != 0)
        {
                return System.String.op_Equality(a:  x.name, b:  this.monthHistory.tile);
        }
        
        return System.String.op_Equality(a:  x.name, b:  this.monthHistory.tile);
    }

}
