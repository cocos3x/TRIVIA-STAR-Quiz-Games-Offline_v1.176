using UnityEngine;
public class SuperStreakEventHandler : WGEventHandler
{
    // Fields
    private static SuperStreakEventHandler _superStreakEventHandler;
    public const string SUPER_STREAK_ID = "SuperStreak";
    private const string SUPER_STREAK_TRACKING_ID = "Super Streak Weekend";
    private System.Collections.Generic.Dictionary<string, object> myEventData;
    private const string EVENT_DATAKEY_LEVELS_LAPSED = "levelsLapsed";
    private const int DEFAULT_LEVELS_LAPSED = -999;
    private const string EVENT_DATAKEY_LAST_GAME_MODE = "modeShown";
    private const string EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE = "modeSecondaryShown";
    private int currentStreak;
    private int currentTier;
    private int currentTierLevelReq;
    private bool inStreak;
    private int levelsCompletedThisTier;
    private int levelInterval;
    private int knobStreakGoal;
    private int currentStreakGoal;
    private int curPriorityOffset;
    private int priorityOffset;
    private bool hasSeenBreakFtux;
    private bool shouldSeeFtux;
    private System.Collections.Generic.List<object> tierData;
    
    // Properties
    public static SuperStreakEventHandler Instance { get; }
    public GameEventV2 getEvent { get; }
    private int levelsLapsedSinceLastShown { get; set; }
    private GameplayMode lastShownGameMode { get; set; }
    private string lastShownSecondaryGameMode { get; set; }
    private int lastLevelShowAt { get; set; }
    public int getCurrentTierReq { get; }
    public int getCurrentStreakGoal { get; }
    private static int LastProgressTimestampPref { get; set; }
    
    // Methods
    public static SuperStreakEventHandler get_Instance()
    {
    
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    private int get_levelsLapsedSinceLastShown()
    {
        object val_1 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -1191711280, defaultValue:  13152256);
        this.myEventData.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        return (int)null;
    }
    private void set_levelsLapsedSinceLastShown(int value)
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1191711280, newValue:  13152256);
    }
    private GameplayMode get_lastShownGameMode()
    {
        object val_1 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -993982512, defaultValue:  13152256);
        this.myEventData.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    }
    private void set_lastShownGameMode(GameplayMode value)
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -993982512, newValue:  13152256);
    }
    private string get_lastShownSecondaryGameMode()
    {
        object val_1 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -993737936, defaultValue:  0);
        if(this.myEventData == 0)
        {
                return;
        }
        
        string val_2 = this.myEventData.ToString();
    }
    private void set_lastShownSecondaryGameMode(string value)
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -993737936, newValue:  value);
    }
    private int get_lastLevelShowAt()
    {
        object val_1 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -1191711376, defaultValue:  13152256);
        this.myEventData.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        return (int)null;
    }
    private void set_lastLevelShowAt(int value)
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1191711376, newValue:  13152256);
    }
    public int get_getCurrentTierReq()
    {
        return (int)this.currentTierLevelReq;
    }
    public int get_getCurrentStreakGoal()
    {
        return (int)this.knobStreakGoal;
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -993024864, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -993024864, value:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_4 = 35625963;
        mem[1152921512204013000] = eventV2;
        SuperStreakEventHandler.EVENT_DATAKEY_LAST_SECONDARY_GAME_MODE = this;
        if(eventV2.eventData != 0)
        {
                SuperStreakEventHandler.__il2cppRuntimeField_static_fields = this;
            this.ParseEventData(eventData:  eventV2.eventData);
        }
        
        if((this.CheckNeedsNewData(eventData:  eventV2.eventData)) != false)
        {
                this.GenerateNewData();
        }
        else
        {
                this.LoadPersistantData();
        }
        
        this.CalculateCurrentTierReq();
        GameBehavior val_2 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        goto typeof(SuperStreakEventHandler).__il2cppRuntimeField_12C;
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_40 = eventData;
        if(val_40 == 0)
        {
                return;
        }
        
        if((val_40.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_2 = val_40.Item[-1554533760];
        if(val_40 == 0)
        {
                return;
        }
        
        val_40 = val_40;
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_40 = 0;
        }
        
        return;
        label_64:
        if(MoveNext() == false)
        {
            goto label_45;
        }
        
        if(((0.Count == 0) || ((0.ContainsKey(key:  -1640018224)) == false)) || ((0.ContainsKey(key:  -992667952)) == false))
        {
            goto label_65;
        }
        
        string val_31 = 0.Item[-992667952];
        if((0 == 0) || (0.Count == 0))
        {
            goto label_65;
        }
        
        if((0.ContainsKey(key:  -1318762160)) != true)
        {
                if((0.ContainsKey(key:  -1318762064)) != true)
        {
                if((0.ContainsKey(key:  -1987496016)) == false)
        {
            goto label_65;
        }
        
        }
        
        }
        
        if((0.ContainsKey(key:  -1987496016)) == false)
        {
            goto label_64;
        }
        
        string val_37 = 0.Item[-1987496016];
        bool val_39 = System.Int32.TryParse(s:  null, result: out  int val_38 = -992655708);
        if(0 != 0)
        {
            goto label_64;
        }
        
        label_65:
        Dispose();
        UnityEngine.Debug.LogError(message:  -992667872);
        return;
        label_45:
        Dispose();
        this.tierData = ;
    }
    private bool CheckNeedsNewData(GameEventV2 eventData)
    {
        if((CPlayerPrefs.HasKey(key:  -992547456)) == false)
        {
                return true;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -992547456);
        object val_3 = MiniJSON.Json.Deserialize(json:  -992547456);
        if("superStreakData" == 0)
        {
                return true;
        }
        
        if(null != null)
        {
                "superStreakData" = 0;
        }
        
        if(null != null)
        {
                return true;
        }
        
        if("superStreakData".Count == 0)
        {
                return true;
        }
        
        if(("superStreakData".ContainsKey(key:  1624646480)) == false)
        {
                return true;
        }
        
        string val_6 = "superStreakData".Item[1624646480];
        string val_7 = this.currentStreakGoal.ToString();
        return System.String.op_Inequality(a:  null, b:  this.currentStreakGoal);
    }
    private void GenerateNewData()
    {
        this.inStreak = false;
        this.currentStreak = false;
        this.currentStreakGoal = false;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  13152256);
        Add(key:  -1191711376, value:  13152256);
        Add(key:  -1191711280, value:  13152256);
        Add(key:  -992431248, value:  13152256);
        Add(key:  -992431152, value:  13152256);
        Add(key:  -1462994448, value:  8945664);
        Add(key:  -992431040, value:  13152256);
        Add(key:  -992430944, value:  8945664);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        CPlayerPrefs.SetString(key:  -992547456, val:  78753792);
        CPlayerPrefs.Save();
        this.LoadPersistantData();
    }
    private void LoadPersistantData()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_18 = 0;
        string val_1 = CPlayerPrefs.GetString(key:  -992547456);
        object val_2 = MiniJSON.Json.Deserialize(json:  -992547456);
        if("superStreakData" != 0)
        {
                if(null != null)
        {
                "superStreakData" = 0;
        }
        
            val_18 = "superStreakData";
        }
        
        this.myEventData = val_18;
        val_19 = public static System.Object EnumerableExtentions::GetOrDefault<System.String, System.Object>(System.Collections.Generic.Dictionary<T, U> dic, System.String key, System.Object defaultValue);
        object val_3 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  0, key:  -1191711280, defaultValue:  13152256);
        val_20 = null;
        val_21 = val_18;
        val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.levelsLapsedSinceLastShown = 1179403647;
        if((this.myEventData.ContainsKey(key:  -993982512)) != false)
        {
                object val_5 = this.myEventData.Item[-993982512];
            val_22 = this.myEventData;
            string val_6 = val_22.ToString();
        }
        else
        {
                string val_7 = 1.ToString();
        }
        
        if((System.Int32.TryParse(s:  -992278216, result: out  int val_8 = -992278212)) != false)
        {
                val_23 = 1;
        }
        else
        {
                val_23 = 1;
        }
        
        this.lastShownGameMode = 1;
        val_19 = public static System.Object EnumerableExtentions::GetOrDefault<System.String, System.Object>(System.Collections.Generic.Dictionary<T, U> dic, System.String key, System.Object defaultValue);
        object val_10 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -1191711376, defaultValue:  13152256);
        val_20 = null;
        val_21 = this.myEventData;
        val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.lastLevelShowAt = 78753792;
        val_19 = public static System.Object EnumerableExtentions::GetOrDefault<System.String, System.Object>(System.Collections.Generic.Dictionary<T, U> dic, System.String key, System.Object defaultValue);
        object val_11 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -992431248, defaultValue:  13152256);
        val_20 = null;
        val_21 = this.myEventData;
        val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.currentTier = null;
        val_19 = public static System.Object EnumerableExtentions::GetOrDefault<System.String, System.Object>(System.Collections.Generic.Dictionary<T, U> dic, System.String key, System.Object defaultValue);
        object val_12 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -992431152, defaultValue:  13152256);
        val_20 = null;
        val_21 = this.myEventData;
        val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.levelsCompletedThisTier = null;
        if((this.myEventData.ContainsKey(key:  -992430944)) == false)
        {
                return;
        }
        
        object val_14 = this.myEventData.Item[-992430944];
        string val_15 = this.myEventData.ToString();
        bool val_17 = System.Boolean.TryParse(value:  this.myEventData, result: out  this.hasSeenBreakFtux);
    }
    private void SaveData()
    {
        int val_1 = this.levelsLapsedSinceLastShown;
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1191711280, newValue:  13152256);
        GameplayMode val_2 = this.lastShownGameMode;
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -993982512, newValue:  375291904);
        string val_3 = this.lastShownSecondaryGameMode;
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -993737936, newValue:  -992092736);
        int val_4 = this.lastLevelShowAt;
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1191711376, newValue:  13152256);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -992431248, newValue:  13152256);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -992431152, newValue:  13152256);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -992430944, newValue:  8945664);
        string val_5 = MiniJSON.Json.Serialize(obj:  this.myEventData);
        CPlayerPrefs.SetString(key:  -992547456, val:  this.myEventData);
        CPlayerPrefs.Save();
    }
    public bool CanEngageWithEvent()
    {
        if(this.currentTier >= true)
        {
                return (bool)0;
        }
        
        0 = 1;
        if(this.levelsLapsedSinceLastShown >= this.levelInterval)
        {
                return (bool)0;
        }
        
        if(this.IsCurrentModeEqualsModeWithStreak() != false)
        {
                if(this.lastLevelShowAt == PlayingLevel.GetCurrentPlayerLevelNumber())
        {
                return (bool)0;
        }
        
        }
        
        GameBehavior val_5 = App.getBehavior;
        if(0 != 0)
        {
                return false;
        }
        
        return false;
    }
    private bool WasPlayingEvent()
    {
        if(this.IsCurrentModeEqualsModeWithStreak() == false)
        {
                return false;
        }
        
        if((this.lastLevelShowAt + 1) != PlayingLevel.GetCurrentPlayerLevelNumber())
        {
                1 = 0;
        }
        
        return (bool)1;
    }
    public bool IsCurrentModeEqualsModeWithStreak()
    {
        var val_9;
        var val_10;
        val_9 = 0;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        val_10 = 0;
        GameplayMode val_2 = this.lastShownGameMode;
        if(val_10 != this)
        {
                return (bool)val_9;
        }
        
        val_10 = 0;
        GameplayMode val_3 = PlayingLevel.CurrentGameplayMode;
        val_9 = 1;
        if(0 != 4)
        {
                return (bool)val_9;
        }
        
        string val_4 = this.lastShownSecondaryGameMode;
        val_9 = 0;
        if((System.Int32.TryParse(s:  -991715776, result: out  int val_5 = -991727804)) == false)
        {
                return (bool)val_9;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = ((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8 - val_10)) >> 5;
        return (bool)val_9;
    }
    private void CalculateCurrentTierReq()
    {
        if(this.currentTier >= true)
        {
                return;
        }
        
        if(true <= this.currentTier)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + (this.currentTier << 2);
        this.tierData = 1;
        if((0.ContainsKey(key:  -1640018224)) == false)
        {
                return;
        }
        
        string val_2 = 0.Item[-1640018224];
        bool val_4 = System.Int32.TryParse(s:  null, result: out  this.currentTierLevelReq);
    }
    private void UpdateProgressWithOffset(int offset = 0)
    {
        this.curPriorityOffset = offset;
        goto typeof(SuperStreakEventHandler).__il2cppRuntimeField_17C;
    }
    public override void OnGameSceneInit()
    {
        var val_24;
        bool val_25;
        var val_26;
        var val_27;
        if(this.CanEngageWithEvent() == false)
        {
            goto label_1;
        }
        
        val_24 = 1152921504886931456;
        WordRegion val_2 = WordRegion.instance;
        if(0 == 0)
        {
            goto label_10;
        }
        
        WordRegion val_4 = WordRegion.instance;
        if(0 == 0)
        {
            goto label_10;
        }
        
        WordRegion val_5 = WordRegion.instance;
        val_25 = false;
        this.currentStreakGoal = System.Math.Min(val1:  this.knobStreakGoal, val2:  -1);
        this.currentStreak = this.GetStreak();
        this.inStreak = val_25;
        this.curPriorityOffset = this.priorityOffset;
        this.lastLevelShowAt = PlayingLevel.GetCurrentPlayerLevelNumber();
        this.levelsLapsedSinceLastShown = 0;
        GameplayMode val_9 = PlayingLevel.CurrentGameplayMode;
        this.lastShownGameMode = 0;
        GameplayMode val_10 = this.lastShownGameMode;
        if(this == 4)
        {
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_13 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8).ToString();
            val_25 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        }
        
        this.lastShownSecondaryGameMode = val_25;
        object val_14 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -1462994448, defaultValue:  8945664);
        val_26 = null;
        val_27 = this.myEventData;
        val_27.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(null == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_16 = ShowUGUIMonolith<System.Object>(showNext:  false);
            EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1462994448, newValue:  8945664);
        }
        
        this.SaveData();
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_18 = ShowUGUIMonolith<System.Object>(showNext:  false);
        string val_19 = Localization.Localize(key:  -991377152, defaultValue:  -991377040, useSingularKey:  false);
        string val_20 = Localization.Localize(key:  -991376928, defaultValue:  -991376816, useSingularKey:  false);
        string val_21 = System.String.Format(format:  -1826949520, arg0:  -991377152, arg1:  -991376928);
        SetupMessage(message:  -1826949520, displaySeconds:  null, startAction:  1077936128);
        return;
        label_1:
        int val_23 = this.priorityOffset;
        val_23 = 0 - val_23;
        this.curPriorityOffset = val_23;
        goto typeof(SuperStreakEventHandler).__il2cppRuntimeField_17C;
        label_10:
        var val_22 = FP - 24;
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        levelsProgressed = this.levelsLapsedSinceLastShown + levelsProgressed;
        this.levelsLapsedSinceLastShown = levelsProgressed;
        if(this.WasPlayingEvent() == false)
        {
                return;
        }
        
        if(this.currentStreak < this.currentStreakGoal)
        {
            goto label_2;
        }
        
        int val_8 = this.levelsCompletedThisTier;
        val_8 = val_8 + 1;
        this.levelsCompletedThisTier = val_8;
        if(val_8 >= this.currentTierLevelReq)
        {
            goto label_3;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        string val_5 = Localization.Localize(key:  -991256336, defaultValue:  -991256208, useSingularKey:  false);
        35625974 = "super_streak_completed_exc";
        SetupMessage(message:  -991256336, displaySeconds:  null, startAction:  1077936128);
        label_2:
        this.SaveData();
        return;
        label_3:
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void OnValidWordSubmitted(string word)
    {
        if(this.CanEngageWithEvent() == false)
        {
                return;
        }
        
        if((R4 + 20) < (R4 + 48))
        {
                if((R4 + 32) != 0)
        {
                R4 + 20 = (R4 + 20) + 1;
            mem2[0] = R4 + 20;
        }
        
        }
        
        mem2[0] = 0;
        mem2[0] = 1;
        R4.UpdateStreakData();
    }
    public override void OnInvalidWordSubmitted()
    {
        bool val_8;
        if(this.CanEngageWithEvent() == false)
        {
                return;
        }
        
        this.inStreak = false;
        if(((this.currentStreak >= 1) && (this.shouldSeeFtux != false)) && (this.hasSeenBreakFtux != true))
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = PlaceGameObject<System.Object>(loc:  0);
            object val_4 = UnityEngine.Object.FindObjectOfType<System.Object>();
            val_8 = public static WGEventButton_Game UnityEngine.Object::FindObjectOfType<WGEventButton_Game>();
            if((-1535185296) != 0)
        {
                UnityEngine.GameObject val_6 = public static WGEventButton_Game UnityEngine.Object::FindObjectOfType<WGEventButton_Game>().__il2cppRuntimeField_14.gameObject;
            string val_7 = Localization.Localize(key:  -991023888, defaultValue:  -991023760, useSingularKey:  false);
            val_8 = true;
            ShowToolTip(objToToolTip:  public static WGEventButton_Game UnityEngine.Object::FindObjectOfType<WGEventButton_Game>().__il2cppRuntimeField_14, text:  -991023888, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1073741824, showGotItButton:  false, gotItCallback:  0, showPick:  false, maxFontSize:  0);
            this.hasSeenBreakFtux = val_8;
        }
        
        }
        
        if(this.currentStreak < this.currentStreakGoal)
        {
                this.currentStreak = 0;
            this.currentStreak = this.currentStreak;
        }
        
        this.curPriorityOffset = 0;
        this.UpdateStreakData();
    }
    public override bool IsRewardReadyToCollect()
    {
        if(this.levelsCompletedThisTier >= this.currentTierLevelReq)
        {
                0 = 1;
        }
        
        return true;
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -990799472, defaultValue:  -990799568, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        if(this.CanEngageWithEvent() == false)
        {
                return;
        }
        
        string val_2 = Localization.Localize(key:  -990687360, defaultValue:  -990687264, useSingularKey:  false);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "streak_upper";
        string val_3 = System.Environment.NewLine;
        typeof(System.Object[]).__il2cppRuntimeField_14 = 0;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_4 = System.String.Format(format:  -990687184, args:  472754880);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -990799472, defaultValue:  -990799568, useSingularKey:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override bool EventCompleted()
    {
        if(this.currentTier >= R1)
        {
                0 = 1;
        }
        
        return true;
    }
    public override int LastProgressTimestamp()
    {
        return SuperStreakEventHandler.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        int val_1 = ServerHandler.UnixServerTime;
        val_1 = this.curPriorityOffset + val_1;
        SuperStreakEventHandler.LastProgressTimestampPref = val_1;
        this.UpdateProgress();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        string val_1 = this.levelsCompletedThisTier.ToString();
        string val_2 = this.currentTierLevelReq.ToString();
        string val_3 = System.String.Format(format:  1629069648, arg0:  this.levelsCompletedThisTier, arg1:  this.currentTierLevelReq);
        float val_5 = (float)this.currentTierLevelReq;
        val_5 = (float)this.levelsCompletedThisTier / val_5;
        TheLibraryMainScreen val_4 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader == 0)
        {
            
        }
    
    }
    public override string GetHackPanelEventData()
    {
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        typeof(System.Object[]).__il2cppRuntimeField_10 = "last level shown at ";
        int val_2 = this.lastLevelShowAt;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = " inside mode ";
        GameplayMode val_3 = this.lastShownGameMode;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = " (secondary id: ";
        string val_4 = this.lastShownSecondaryGameMode;
        typeof(System.Object[]).__il2cppRuntimeField_24 = this;
        typeof(System.Object[]).__il2cppRuntimeField_28 = ")";
        string val_5 = +472754880;
        System.Text.StringBuilder val_6 = AppendLine(value:  472754880);
        string val_7 = this.levelsCompletedThisTier.ToString();
        string val_8 = -989773680(-989773680) + this.levelsCompletedThisTier;
        System.Text.StringBuilder val_9 = AppendLine(value:  -989773680);
        string val_10 = -989773552(-989773552) + 13152256;
        System.Text.StringBuilder val_11 = AppendLine(value:  -989773552);
        int val_22 = this.currentTier;
        val_22 = val_22 + 1;
        string val_12 = -989773424(-989773424) + 13152256;
        System.Text.StringBuilder val_13 = AppendLine(value:  -989773424);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "current streak ";
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = " current goal ";
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_14 = +472754880;
        System.Text.StringBuilder val_15 = AppendLine(value:  472754880);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_16 = AppendLine(value:  System.Object[].__il2cppRuntimeField_events);
        }
        else
        {
                System.Text.StringBuilder val_17 = AppendLine(value:  System.Object[].__il2cppRuntimeField_events);
        }
        
        System.Text.StringBuilder val_18 = AppendLine(value:  -1189359888);
        string val_19 = PrettyPrint.printJSON(obj:  System.Object[].__il2cppRuntimeField_events + 72, types:  false, singleLineOutput:  false);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_20 = AppendLine(value:  System.Object[].__il2cppRuntimeField_events + 72);
            return;
        }
        
        System.Text.StringBuilder val_21 = AppendLine(value:  System.Object[].__il2cppRuntimeField_events + 72);
    }
    public override void BreakStreak()
    {
        goto typeof(SuperStreakEventHandler).__il2cppRuntimeField_324;
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        if(this.CanEngageWithEvent() != false)
        {
                if(this.currentStreak >= this.currentStreakGoal)
        {
                0 = 1;
        }
        
        }
        
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  currentData, key:  -989545104, newValue:  8945664);
    }
    public GameEventRewardType GetRewardType()
    {
        int val_7;
        var val_8;
        val_7 = this.currentTier;
        val_8 = 0;
        if(val_7 > true)
        {
                return;
        }
        
        val_7 = this.currentTier;
        if(true <= val_7)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + (val_7 << 2);
        if(((0 + (this.currentTier) << 2) + 16) == 0)
        {
                return;
        }
        
        val_8 = 0;
        if((((0 + (this.currentTier) << 2) + 16 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                (0 + (this.currentTier) << 2) + 16 = val_8;
        }
    
    }
    public int GetCoinRewardForTier()
    {
        var val_8;
        int val_9;
        val_8 = 0;
        GameEventRewardType val_1 = this.GetRewardType();
        if(this != 1)
        {
                return (int)val_8;
        }
        
        val_9 = this.currentTier;
        if(this <= val_9)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (val_9 << 2);
        if(((0 + (this.currentTier) << 2) + 16) == 0)
        {
                return (int)val_8;
        }
        
        val_9 = 1152921504685600768;
        val_8 = 0;
        if((((0 + (this.currentTier) << 2) + 16 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                (0 + (this.currentTier) << 2) + 16 = val_8;
        }
        
        return (int)val_8;
    }
    public void CollectReward()
    {
        if(this.TryCollect() != false)
        {
                int val_4 = this.currentTier;
            this.levelsCompletedThisTier = 0;
            val_4 = val_4 + 1;
            this.currentTier = val_4;
            this.CalculateCurrentTierReq();
            this.SaveData();
            return;
        }
        
        GameEventRewardType val_2 = this.GetRewardType();
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_3 = -989180384(-989180384) + 321617920;
        UnityEngine.Debug.LogError(message:  -989180384);
    }
    private bool TryCollect()
    {
        var val_8 = 0;
        if(this.levelsCompletedThisTier < this.currentTierLevelReq)
        {
                return (bool)val_8;
        }
        
        GameEventRewardType val_1 = this.GetRewardType();
        if(this == 4)
        {
            goto label_2;
        }
        
        if(this == 3)
        {
            goto label_3;
        }
        
        if(this != 1)
        {
                return (bool)val_8;
        }
        
        if(this.GetCoinRewardForTier() == 0)
        {
                return (bool)val_8;
        }
        
        decimal val_3 = System.Decimal.op_Implicit(value:  -989056112);
        CurrencyController.CreditBalance(value:  new System.Decimal(), source:  "Super Streak Weekend", externalParams:  0, animated:  false);
        val_8 = 1;
        return (bool)val_8;
        label_2:
        GameBehavior val_4 = App.getBehavior;
        val_8 = 1;
        mem[64] = "Super Streak Weekend";
        return (bool)val_8;
        label_3:
        GameBehavior val_6 = App.getBehavior;
        val_8 = 1;
        mem[12] = "Super Streak Weekend";
        return (bool)val_8;
    }
    private void UpdateStreakData()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1;
        var val_2;
        if(this.currentStreak != 0)
        {
                if(this.currentStreak < this.currentStreakGoal)
        {
                return;
        }
        
            val_1 = this.myEventData;
            val_2 = 1152921504619999232;
        }
        else
        {
                val_1 = this.myEventData;
            val_2 = 1152921504619999232;
        }
        
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  val_1, key:  -992431040, newValue:  13152256);
    }
    private int GetStreak()
    {
        var val_8;
        var val_9;
        val_8 = this.lastLevelShowAt;
        val_9 = 0;
        if(val_8 == PlayingLevel.GetCurrentPlayerLevelNumber())
        {
                val_8 = "lastStreak";
            if((this.myEventData.ContainsKey(key:  -992431040)) == false)
        {
                return (int)val_9;
        }
        
            object val_4 = this.myEventData.Item[-992431040];
            string val_5 = this.myEventData.ToString();
            bool val_7 = System.Int32.TryParse(s:  this.myEventData, result: out  int val_6 = -988807532);
            val_9 = 0;
            return (int)val_9;
        }
        
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -992431040, newValue:  13152256);
        return (int)val_9;
    }
    public SuperStreakEventHandler()
    {
        this.currentTierLevelReq = 3;
        this.levelInterval = 5;
        this.knobStreakGoal = 5;
        this.priorityOffset = 600;
        this.shouldSeeFtux = true;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1640018224, value:  13152256);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1987496016, value:  13152256);
        Add(key:  -992667952, value:  78753792);
        Add(item:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1640018224, value:  13152256);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1987496016, value:  13152256);
        Add(key:  -992667952, value:  78753792);
        Add(item:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1640018224, value:  13152256);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1987496016, value:  13152256);
        Add(key:  -992667952, value:  78753792);
        Add(item:  78753792);
        this.tierData = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }

}
