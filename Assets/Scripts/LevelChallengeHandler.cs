using UnityEngine;
public class LevelChallengeHandler : WGEventHandler
{
    // Fields
    public const string LEVEL_CHALLENGE_EVENT_ID = "LevelChallenge";
    private static LevelChallengeHandler _Instance;
    private const int ECON_DEFAULT_NUMWINNERS = 100;
    private const int ECON_DEFAULT_LEVELSREQUIRED = 100;
    private const int ECON_DEFAULT_REWARD = 225;
    private const int ECON_DEFAULT_REWARD_GOLDENCURRENCY = 50;
    private const int WINS_REMAINING_INIT = 97;
    private const string WINS_REMAINING_COUNTER_START_TIME = "";
    private const int WINS_REMAINING_COUNTER_INTERVAL_INIT = 0;
    private const int WINS_REMAINING_COUNTER_INTERVAL_IN_SECONDS_MIN = 90;
    private const int WINS_REMAINING_COUNTER_INTERVAL_IN_SECONDS_MAX = 240;
    private const int COMPLETED_LEVELS_INIT = 0;
    private const string LEVEL_CHALLENGE_EVENT_END_TIME_INIT = "";
    private const string NUM_WINNERS_KEY = "LevelChallenge_NumWinners";
    private const string REQUIRED_LEVELS_KEY = "LevelChallenge_RequiredLevels";
    private const string REWARD_KEY = "LevelChallenge_Reward";
    private const string REWARD_GOLDENCURRENCY_KEY = "LevelChallenge_Reward_GoldCurrency";
    private const string COMPLETED_LEVELS_KEY = "LevelChallenge_CompletedLevels";
    private const string LAST_PROGRESS_STAMP_KEY = "LevelChallenge_LastProgressTimestamp";
    private const string WINS_REMAINING_KEY = "LevelChallenge_WinsRemaining";
    private const string WINS_REMAINING_COUNTER_INTERVAL_KEY = "LevelChallenge_WinsRemainingCounterInterval";
    private const string WINS_REMAINING_COUNTER_INTERVAL_MIN_KEY = "LevelChallenge_WinsRemainingCounterIntervalMin";
    private const string WINS_REMAINING_COUNTER_INTERVAL_MAX_KEY = "LevelChallenge_WinsRemainingCounterIntervalMax";
    private const string WINS_REMAINING_COUNTER_START_TIME_KEY = "LevelChallenge_WinsRemainingCounterStartTime";
    private const string CHALLENGE_COMPLETED_KEY = "LevelChallenge_ChallengeCompleted";
    private const string LEVEL_CHALLENGE_POPUP_SHOWN_KEY = "LevelChallengePopupShown";
    private const string LEVEL_CHALLENGE_EVENT_TIME_STAMP_KEY = "LevelChallengeEventEndTime";
    private const string ECONOMY = "economy";
    private const string NUMWINNERS = "num_winners";
    private const string BUCKETS = "buckets";
    private const string LEVELSREQUIRED = "levels_required";
    private const string REWARD = "reward";
    private const string REWARD_GOLDENCURRENCY = "golden_currency_reward";
    private const string WINSREMAINING = "num_prizes_remaining";
    private const string CD_MIN = "cd_min";
    private const string CD_MAX = "cd_max";
    private const string MAIN_MENU_BUTTON_TEXT = "LEVEL CHALLENGE";
    private const string GAME_BUTTON_TEXT = "EVENT";
    private const int TRUE = 1;
    private const int FALSE = 0;
    
    // Properties
    public static LevelChallengeHandler Instance { get; }
    public static bool InGame { get; }
    public static int NumWinners { get; set; }
    public static int RequiredLevels { get; set; }
    public static int Reward { get; set; }
    public static int RewardGoldenCurrency { get; set; }
    public static int WinsRemaining { get; set; }
    public static int CompletedLevels { get; set; }
    private static string LevelChallengEventTimeStamp { get; set; }
    private static int WinsRemainingCounterInterval { get; set; }
    private static int WinsRemainingCounterIntervalMin { get; set; }
    private static int WinsRemainingCounterIntervalMax { get; set; }
    private static string WinsRemainingCounterStartTime { get; set; }
    private static int ChallengeCompleted { get; set; }
    private static int LevelChallengePopupShown { get; set; }
    private static int LastProgressTimestampPref { get; set; }
    
    // Methods
    public static LevelChallengeHandler get_Instance()
    {
    
    }
    public static bool get_InGame()
    {
        return SceneDictator.IsInGameScene();
    }
    public static int get_NumWinners()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1327925152, defaultValue:  100);
    }
    public static void set_NumWinners(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1327925152, value:  value);
    }
    public static int get_RequiredLevels()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1327701024, defaultValue:  100);
    }
    public static void set_RequiredLevels(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1327701024, value:  value);
    }
    public static int get_Reward()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1327476896, defaultValue:  225);
    }
    public static void set_Reward(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1327476896, value:  value);
    }
    public static int get_RewardGoldenCurrency()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1327252784, defaultValue:  50);
    }
    public static void set_RewardGoldenCurrency(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1327252784, value:  value);
    }
    public static int get_WinsRemaining()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1327028640, defaultValue:  97);
    }
    public static void set_WinsRemaining(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1327028640, value:  value);
    }
    public static int get_CompletedLevels()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1326804512, defaultValue:  0);
    }
    public static void set_CompletedLevels(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1326804512, value:  value);
    }
    private static string get_LevelChallengEventTimeStamp()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1326580384, defaultValue:  1098586544);
    }
    private static void set_LevelChallengEventTimeStamp(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1326580384, value:  value);
    }
    private static int get_WinsRemainingCounterInterval()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1326348064, defaultValue:  0);
    }
    private static void set_WinsRemainingCounterInterval(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1326348064, value:  value);
    }
    private static int get_WinsRemainingCounterIntervalMin()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1326123904, defaultValue:  90);
    }
    private static void set_WinsRemainingCounterIntervalMin(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1326123904, value:  value);
    }
    private static int get_WinsRemainingCounterIntervalMax()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1325899744, defaultValue:  240);
    }
    private static void set_WinsRemainingCounterIntervalMax(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1325899744, value:  value);
    }
    private static string get_WinsRemainingCounterStartTime()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1325675584, defaultValue:  1098586544);
    }
    private static void set_WinsRemainingCounterStartTime(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1325675584, value:  value);
    }
    private static int get_ChallengeCompleted()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1325443232, defaultValue:  0);
    }
    private static void set_ChallengeCompleted(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1325443232, value:  value);
    }
    private static int get_LevelChallengePopupShown()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1325219088, defaultValue:  0);
    }
    private static void set_LevelChallengePopupShown(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1325219088, value:  value);
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1324994960, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1324994960, value:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        LevelChallengeHandler.FALSE = this;
        this.RefreshLevelChallengeInfo(eventV2:  eventV2);
    }
    public override void OnGameSceneBegan()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                return;
        }
        
        int val_3 = LevelChallengeHandler.GetWinsRemaining();
        if(val_3 == 0)
        {
                val_3 = 1;
            LevelChallengeHandler.ChallengeCompleted = 1;
        }
        
        if(LevelChallengeHandler.LevelChallengePopupShown == 0)
        {
                if(this == 0)
        {
            goto label_6;
        }
        
        }
        
        if(this != 0)
        {
                return;
        }
        
        LevelChallengeHandler.ShowLevelChallengeCompletePopup();
        return;
        label_6:
        this.ShowLevelChallengePopup();
        LevelChallengeHandler.LevelChallengePopupShown = 1;
    }
    public override void OnMenuLoaded()
    {
        if(LevelChallengeHandler.GetWinsRemaining() != 0)
        {
                return;
        }
        
        LevelChallengeHandler.ChallengeCompleted = 1;
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1324426512, defaultValue:  -1324426624, useSingularKey:  false);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1324426512, defaultValue:  -1324426624, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        string val_2 = LevelChallengeHandler.CompletedLevels.ToString();
        string val_4 = LevelChallengeHandler.RequiredLevels.ToString();
        string val_5 = -1324190420(-1324190420) + 1115175264 + -1324190420(-1324190420);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_1;
        var val_1 = 23732147;
        val_1 = 11893644 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 25;
        AmplitudePluginHelper.lastFeatureAccessPoint.ShowLevelChallengePopup();
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                26 = 27;
        }
        
        var val_3 = 23731835;
        val_3 = 11893956 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 27;
        AmplitudePluginHelper.lastFeatureAccessPoint.ShowLevelChallengePopup();
    }
    public override bool IsChallengeCompleted()
    {
        int val_1 = LevelChallengeHandler.ChallengeCompleted;
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public override bool IsEventEndedOffline()
    {
        var val_2;
        System.DateTime val_1 = System.Convert.ToDateTime(value:  new System.DateTime() {dateData = 1152921511873039128});
        System.DateTime val_4 = DateTimeCheat.UtcNow;
        int val_7 = val_2.CompareTo(value:  new System.DateTime());
        val_7 = val_7 >> 31;
        LevelChallengeHandler.ChallengeCompleted = val_7;
        int val_8 = LevelChallengeHandler.ChallengeCompleted;
        val_8 = val_8 - 1;
        val_8 = val_8 >> 5;
        return (bool)val_8;
    }
    public override void OnEventEnded()
    {
        this.DeletePlayerPrefs();
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        this.RefreshLevelChallengeInfo(eventV2:  eventV2);
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        int val_1 = LevelChallengeHandler.CompletedLevels;
        val_1 = val_1 + 1;
        LevelChallengeHandler.CompletedLevels = val_1;
        if(LevelChallengeHandler.CompletedLevels >= LevelChallengeHandler.RequiredLevels)
        {
                return;
        }
        
        int val_4 = LevelChallengeHandler.GetWinsRemaining();
        if(val_4 < 1)
        {
                return;
        }
        
        val_4.ShowLevelChallengeProgressPopup();
    }
    public override int LastProgressTimestamp()
    {
        return LevelChallengeHandler.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        LevelChallengeHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override bool IsRewardReadyToCollect()
    {
        if(LevelChallengeHandler.CompletedLevels != LevelChallengeHandler.RequiredLevels)
        {
                return (bool)0;
        }
        
        if(LevelChallengeHandler.GetWinsRemaining() < 1)
        {
                return (bool)0;
        }
        
        0 = LevelChallengeHandler.ChallengeCompleted >> 5;
        return (bool)0;
    }
    public override bool EventCompleted()
    {
        int val_1 = LevelChallengeHandler.ChallengeCompleted;
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        string val_2 = LevelChallengeHandler.CompletedLevels.ToString();
        string val_4 = LevelChallengeHandler.RequiredLevels.ToString();
        string val_5 = System.String.Format(format:  -1322846112, arg0:  -1322833020, arg1:  -1322833020);
        float val_9 = (float)LevelChallengeHandler.CompletedLevels;
        val_9 = val_9 / (float)LevelChallengeHandler.RequiredLevels;
        TheLibraryMainScreen val_8 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public static void ShowLevelChallengeCompletePopup()
    {
        if(LevelChallengeHandler.CompletedLevels != LevelChallengeHandler.RequiredLevels)
        {
                return;
        }
        
        if(LevelChallengeHandler.GetWinsRemaining() < 1)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
        LevelChallengeHandler.ChallengeCompleted = 1;
    }
    public static int GetWinsRemaining()
    {
        var val_4;
        var val_5;
        var val_17;
        int val_33;
        var val_34;
        var val_35;
        string val_1 = LevelChallengeHandler.WinsRemainingCounterStartTime;
        if((System.String.op_Equality(a:  null, b:  1098586544)) != false)
        {
                System.DateTime val_3 = DateTimeCheat.UtcNow;
            string val_6 = val_4.ToString();
            LevelChallengeHandler.WinsRemainingCounterStartTime = -1322603920;
        }
        
        if(LevelChallengeHandler.WinsRemainingCounterInterval == 0)
        {
                LevelChallengeHandler.WinsRemainingCounterInterval = UnityEngine.Random.Range(min:  LevelChallengeHandler.WinsRemainingCounterIntervalMin, max:  LevelChallengeHandler.WinsRemainingCounterIntervalMax);
        }
        
        string val_11 = LevelChallengeHandler.WinsRemainingCounterStartTime;
        val_33 = 0;
        System.DateTime val_12 = System.Convert.ToDateTime(value:  -1322603936);
        val_34 = val_4;
        val_35 = val_5;
        val_34 = val_34;
        val_35 = val_35;
        System.DateTime val_13 = DateTimeCheat.UtcNow;
        System.TimeSpan val_16 = Subtract(value:  new System.DateTime() {dateData = 1152921511874177648});
        int val_20 = LevelChallengeHandler.WinsRemaining;
        if(val_20 <= 0)
        {
                return (int)LevelChallengeHandler.WinsRemaining;
        }
        
        float val_22 = S16 - (float)LevelChallengeHandler.WinsRemainingCounterInterval;
        if(val_20 >= 0)
        {
                int val_23 = LevelChallengeHandler.WinsRemaining;
            val_23 = val_23 - 1;
            LevelChallengeHandler.WinsRemaining = val_23;
            int val_24 = LevelChallengeHandler.WinsRemainingCounterInterval;
            System.DateTime val_25 = AddSeconds(value:  val_17.TotalSeconds);
            string val_26 = val_4.ToString();
            LevelChallengeHandler.WinsRemainingCounterStartTime = -1322603920;
            val_33 = LevelChallengeHandler.WinsRemainingCounterIntervalMin;
            LevelChallengeHandler.WinsRemainingCounterInterval = UnityEngine.Random.Range(min:  val_33, max:  LevelChallengeHandler.WinsRemainingCounterIntervalMax);
            bool val_30 = PrefsSerializationManager.SavePlayerPrefs();
        }
        
        return (int)LevelChallengeHandler.WinsRemaining;
    }
    private bool IsLastCycleEnded()
    {
        string val_1 = LevelChallengeHandler.LevelChallengEventTimeStamp;
        string val_2 = ToString();
        return System.String.op_Inequality(a:  -1322479872, b:  -1322479864);
    }
    private void RefreshLevelChallengeInfo(GameEventV2 eventV2)
    {
        mem[1152921511874426280] = eventV2;
        if(eventV2 == 0)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  eventV2.type, b:  -1322387776)) != false)
        {
                string val_2 = eventV2.ToString();
            string val_3 = -1322383584(-1322383584) + eventV2;
            UnityEngine.Debug.LogError(message:  -1322383584);
            return;
        }
        
        if(this.IsLastCycleEnded() == false)
        {
                return;
        }
        
        this.InitLevelChallengeInfo(data:  eventV2.eventData);
        string val_5 = mem[1152921511874426280].ToString();
        LevelChallengeHandler.LevelChallengEventTimeStamp = -1322355288;
    }
    private void InitLevelChallengeInfo(System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_24;
        var val_25;
        bool val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        Player val_1 = App.Player;
        if((data.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_5;
        }
        
        object val_3 = data.Item[-1554533760];
        val_24 = 0;
        val_25 = 0;
        if(data != 0)
        {
                val_25 = 0;
            if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                data = 0;
        }
        
            val_25 = data;
        }
        
        if(val_25 != 0)
        {
            goto label_9;
        }
        
        label_5:
        val_25 = 0;
        val_24 = 1;
        label_9:
        if((val_25.ContainsKey(key:  -1322250912)) != false)
        {
                string val_5 = val_25.Item[-1322250912];
            val_27 = val_25;
            val_26 = null;
            val_27.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            LevelChallengeHandler.NumWinners = 1179403647;
        }
        
        val_28 = "buckets";
        if((val_25.ContainsKey(key:  -1322250816)) == false)
        {
            goto label_15;
        }
        
        string val_7 = val_25.Item[-1322250816];
        val_29 = 0;
        val_30 = 0;
        if(val_25 != 0)
        {
                val_30 = 0;
            val_26 = mem[1179403827];
            if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_25 = 0;
        }
        
            val_30 = val_25;
        }
        
        if(val_30 != 0)
        {
            goto label_19;
        }
        
        label_15:
        val_30 = 0;
        val_29 = 1;
        label_19:
        if((val_30.ContainsKey(key:  33449456)) == false)
        {
            goto label_20;
        }
        
        string val_9 = val_30.Item[33449456];
        val_31 = 0;
        val_24 = 0;
        if(val_30 != 0)
        {
                val_24 = 0;
            val_26 = mem[1179403827];
            if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_30 = 0;
        }
        
            val_24 = val_30;
        }
        
        if(val_24 != 0)
        {
            goto label_24;
        }
        
        label_20:
        val_24 = 0;
        val_31 = 1;
        label_24:
        if((val_24.ContainsKey(key:  -1322250720)) != false)
        {
                string val_11 = val_24.Item[-1322250720];
            val_25 = val_24;
            val_32 = null;
            val_25.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            LevelChallengeHandler.RequiredLevels = 1179403647;
        }
        
        if((val_24.ContainsKey(key:  -1470584448)) != false)
        {
                string val_13 = val_24.Item[-1470584448];
            val_25 = val_24;
            val_32 = null;
            val_25.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            LevelChallengeHandler.Reward = 1179403647;
        }
        
        if((val_24.ContainsKey(key:  -1322250608)) != false)
        {
                string val_15 = val_24.Item[-1322250608];
            val_25 = val_24;
            val_32 = null;
            val_25.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            LevelChallengeHandler.RewardGoldenCurrency = 1179403647;
        }
        
        if((val_24.ContainsKey(key:  -1322250496)) != false)
        {
                string val_17 = val_24.Item[-1322250496];
            val_25 = val_24;
            val_28 = UnityEngine.Random.Range(min:  2, max:  3);
            val_26 = null;
            val_25.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            int val_24 = 1179403647;
            val_24 = val_24 + val_28;
            LevelChallengeHandler.WinsRemaining = val_24;
        }
        
        if((val_24.ContainsKey(key:  -1322250384)) != false)
        {
                string val_20 = val_24.Item[-1322250384];
            val_25 = val_24;
            val_32 = null;
            val_25.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            LevelChallengeHandler.WinsRemainingCounterIntervalMin = 1179403647;
        }
        
        if((val_24.ContainsKey(key:  -1322250304)) != false)
        {
                string val_22 = val_24.Item[-1322250304];
            val_24 = val_24;
            val_25 = null;
            val_24.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            LevelChallengeHandler.WinsRemainingCounterIntervalMax = 1179403647;
        }
        
        bool val_23 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private void ShowLevelChallengePopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void ShowLevelChallengeProgressPopup()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void DeletePlayerPrefs()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1327925152)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1327925152);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1327701024)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1327701024);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1327476896)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1327476896);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1326804512)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1326804512);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1327028640)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1327028640);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1326348064)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1326348064);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1326123904)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1326123904);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1325899744)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1325899744);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1325675584)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1325675584);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1325443232)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1325443232);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1325219088)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1325219088);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1326580384)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1326580384);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1324994960)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    public LevelChallengeHandler()
    {
    
    }

}
