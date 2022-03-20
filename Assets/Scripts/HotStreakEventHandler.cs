using UnityEngine;
public class HotStreakEventHandler : WGEventHandler
{
    // Fields
    private static HotStreakEventHandler _instance;
    public const string HOT_STREAK_ID = "HotStreak";
    private System.Collections.Generic.Dictionary<string, object> myEventData;
    private int lastLevelShowAt;
    private int lastLevelCollectedAt;
    private int currentStreak;
    private bool inStreak;
    private int currentStreakGoal;
    private int levelsLapsedSinceLastShown;
    private GameplayMode lastModeShowAt;
    private string lastModeSecondaryId;
    private int levelInterval;
    private int knobStreakGoal;
    private int streakKnobLess;
    private int streakKnobMore;
    private int streakMinValue;
    private int streakMaxValue;
    private int reward;
    
    // Properties
    public static HotStreakEventHandler Instance { get; }
    public GameEventV2 getEvent { get; }
    public int getCurrentStreakGoal { get; }
    private static int LastProgressTimestampPref { get; set; }
    public override bool IsEventHidden { get; }
    
    // Methods
    public static HotStreakEventHandler get_Instance()
    {
    
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    public int get_getCurrentStreakGoal()
    {
        return (int)this.knobStreakGoal;
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1192304592, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1192304592, value:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_4 = 35636312;
        mem[1152921512004733272] = eventV2;
        HotStreakEventHandler.HOT_STREAK_ID = this;
        if(eventV2.eventData != 0)
        {
                HotStreakEventHandler.__il2cppRuntimeField_static_fields = this;
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
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        goto typeof(HotStreakEventHandler).__il2cppRuntimeField_12C;
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        if(eventData == 0)
        {
                return;
        }
        
        35636313 = 1152921510367987632;
        if(eventData.Count == 0)
        {
                return;
        }
        
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_3 = eventData.Item[-1554533760];
        if(eventData == 0)
        {
                return;
        }
        
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                eventData = 0;
        }
    
    }
    private bool CheckNeedsNewData(GameEventV2 eventData)
    {
        if((CPlayerPrefs.HasKey(key:  -1191827568)) == false)
        {
                return true;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -1191827568);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1191827568);
        if("hotStreakData" == 0)
        {
                return true;
        }
        
        if(null != null)
        {
                "hotStreakData" = 0;
        }
        
        if(null != null)
        {
                return true;
        }
        
        if("hotStreakData".Count == 0)
        {
                return true;
        }
        
        if(("hotStreakData".ContainsKey(key:  1624646480)) == false)
        {
                return true;
        }
        
        string val_6 = "hotStreakData".Item[1624646480];
        string val_7 = this.lastModeSecondaryId.ToString();
        return System.String.op_Inequality(a:  null, b:  this.lastModeSecondaryId);
    }
    private void GenerateNewData()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  13152256);
        Add(key:  -1191711376, value:  13152256);
        Add(key:  -1191711280, value:  13152256);
        Add(key:  -1191711184, value:  13152256);
        Add(key:  -1462994448, value:  8945664);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        CPlayerPrefs.SetString(key:  -1191827568, val:  78753792);
        CPlayerPrefs.Save();
        this.LoadPersistantData();
    }
    private void LoadPersistantData()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        string val_16;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_17;
        string val_1 = CPlayerPrefs.GetString(key:  -1191827568);
        object val_2 = MiniJSON.Json.Deserialize(json:  -1191827568);
        val_11 = 0;
        if("hotStreakData" != 0)
        {
                val_11 = 0;
            if(null != null)
        {
                "hotStreakData" = 0;
        }
        
            val_11 = "hotStreakData";
        }
        
        this.myEventData = val_11;
        val_12 = 1152921511298504864;
        object val_3 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  0, key:  -1191711376, defaultValue:  13152256);
        val_13 = null;
        val_14 = val_11;
        val_14.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.lastLevelShowAt = 1179403647;
        object val_4 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -1191711184, defaultValue:  13152256);
        val_13 = null;
        val_14 = this.myEventData;
        val_14.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.lastLevelCollectedAt = null;
        object val_5 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -1191711280, defaultValue:  13152256);
        val_13 = null;
        val_14 = this.myEventData;
        val_14.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.levelsLapsedSinceLastShown = null;
        object val_6 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -1191586800, defaultValue:  13152256);
        val_14 = this.myEventData;
        val_15 = null;
        val_14.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.lastModeShowAt = null;
        val_16 = 0;
        if((this.myEventData.ContainsKey(key:  -1191582608)) != false)
        {
                val_17 = this.myEventData;
            val_12 = 1152921510385703632;
            object val_8 = val_17.Item[-1191582608];
            if(val_17 != 0)
        {
                object val_9 = this.myEventData.Item[-1191582608];
            string val_10 = this.myEventData.ToString();
            val_16 = this.myEventData;
        }
        
        }
        
        this.lastModeSecondaryId = val_16;
    }
    private void SaveData()
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1191711376, newValue:  13152256);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1191711184, newValue:  13152256);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1191711280, newValue:  13152256);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1191586800, newValue:  13152256);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1191582608, newValue:  this.lastModeSecondaryId);
        string val_1 = MiniJSON.Json.Serialize(obj:  this.myEventData);
        CPlayerPrefs.SetString(key:  -1191827568, val:  this.myEventData);
        CPlayerPrefs.Save();
    }
    public bool CanEngageWithEvent()
    {
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge == true)
        {
                return false;
        }
        
        return false;
    }
    public bool IsCurrentModeEqualsModeWithExistingStreak()
    {
        var val_7;
        var val_8;
        val_7 = 0;
        val_8 = 1152921504982192128;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        if(0 != this.lastModeShowAt)
        {
                return (bool)val_7;
        }
        
        val_8 = 0;
        GameplayMode val_2 = PlayingLevel.CurrentGameplayMode;
        val_7 = 1;
        if(0 != 4)
        {
                return (bool)val_7;
        }
        
        val_7 = 0;
        if((System.Int32.TryParse(s:  this.lastModeSecondaryId, result: out  int val_3 = -1191128028)) == false)
        {
                return (bool)val_7;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = ((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8 - val_8)) >> 5;
        return (bool)val_7;
    }
    public override void OnGameSceneInit()
    {
        int val_27;
        int val_28;
        var val_29;
        int val_30;
        if(this.CanEngageWithEvent() == false)
        {
                return;
        }
        
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
        
        if((this.myEventData.ContainsKey(key:  -1191015712)) == false)
        {
            goto label_14;
        }
        
        object val_6 = this.myEventData.Item[-1191015712];
        if(this.myEventData == 0)
        {
            goto label_14;
        }
        
        object val_7 = this.myEventData.Item[-1191015712];
        string val_8 = this.myEventData.ToString();
        val_27 = this.currentStreakGoal;
        if((System.Int32.TryParse(s:  this.myEventData, result: out  val_27)) == true)
        {
            goto label_17;
        }
        
        label_14:
        Player val_11 = App.Player;
        int val_27 = this.streakKnobLess;
        int val_28 = this.streakKnobMore;
        val_27 = val_27 + 23;
        val_28 = val_28 + 23;
        int val_12 = UnityEngine.Random.Range(min:  val_27, max:  val_28);
        this.currentStreakGoal = val_12;
        val_28 = this.streakMinValue;
        val_27 = this.currentStreakGoal;
        this.currentStreakGoal = UnityEngine.Mathf.Clamp(value:  val_12, min:  val_28, max:  this.streakMaxValue);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1191015712, newValue:  13152256);
        label_17:
        val_29 = mem[this.currentStreakGoal];
        val_29 = val_27;
        WordRegion val_14 = WordRegion.instance;
        var val_29 = 0;
        val_29 = val_29 - 1;
        if(val_29 <= val_29)
        {
            goto label_28;
        }
        
        this.inStreak = false;
        this.currentStreak = false;
        return;
        label_10:
        UnityEngine.Debug.LogError(message:  -1191003328);
        return;
        label_28:
        this.currentStreak = 0;
        this.inStreak = 0;
        if(this.lastLevelShowAt != PlayingLevel.GetCurrentPlayerLevelNumber())
        {
                val_30 = 0;
            this.lastLevelShowAt = PlayingLevel.GetCurrentPlayerLevelNumber();
            this.levelsLapsedSinceLastShown = val_30;
            GameplayMode val_17 = PlayingLevel.CurrentGameplayMode;
            this.lastModeShowAt = 0;
            if(0 == 4)
        {
                twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_20 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8).ToString();
            val_30 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        }
        
            this.lastModeSecondaryId = val_30;
            this.SaveData();
        }
        
        val_28 = 1152921504615792640;
        val_27 = "eventPrompted";
        object val_21 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -1462994448, defaultValue:  8945664);
        this.myEventData.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(null == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_23 = ShowUGUIMonolith<System.Object>(showNext:  false);
            EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1462994448, newValue:  8945664);
            this.SaveData();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_29 = 0;
        object val_25 = ShowUGUIMonolith<System.Object>(showNext:  false);
        string val_26 = Localization.Localize(key:  -1190992960, defaultValue:  -1190992832, useSingularKey:  false);
        SetupMessage(message:  -1190992960, displaySeconds:  null, startAction:  1077936128);
    }
    public override void OnValidWordSubmitted(string word)
    {
        if(this.CanEngageWithEvent() == false)
        {
                return;
        }
        
        if((this.currentStreak < this.currentStreakGoal) && (this.inStreak != false))
        {
                int val_2 = PlayingLevel.GetCurrentPlayerLevelNumber();
            if(this.lastLevelCollectedAt != val_2)
        {
                val_2 = this.currentStreak;
            val_2 = val_2 + 1;
            this.currentStreak = val_2;
        }
        
        }
        
        this.inStreak = true;
        if(this.lastLevelCollectedAt == PlayingLevel.GetCurrentPlayerLevelNumber())
        {
                return;
        }
        
        if(this.currentStreak < this.currentStreakGoal)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = 35636322;
        if((this.IsCurrentModeEqualsModeWithExistingStreak() != false) && (PlayingLevel.GetCurrentPlayerLevelNumber() == this.lastLevelShowAt))
        {
                val_5 = this.myEventData;
            if((val_5.ContainsKey(key:  -1191015712)) != false)
        {
                val_5 = this.myEventData;
            bool val_4 = val_5.Remove(key:  -1191015712);
        }
        
        }
        
        int val_5 = this.levelsLapsedSinceLastShown;
        val_5 = val_5 + levelsProgressed;
        this.levelsLapsedSinceLastShown = val_5;
        this.SaveData();
    }
    public override void OnInvalidWordSubmitted()
    {
        if(this.CanEngageWithEvent() == false)
        {
                return;
        }
        
        mem2[0] = 0;
        if((R4 + 28) < (R4 + 36))
        {
                mem2[0] = 0;
        }
        
        goto R4 + 380;
    }
    public override void BreakStreak()
    {
        goto typeof(HotStreakEventHandler).__il2cppRuntimeField_324;
    }
    public override bool IsRewardReadyToCollect()
    {
        if(this.CanEngageWithEvent() == false)
        {
                return false;
        }
        
        int val_2 = PlayingLevel.GetCurrentPlayerLevelNumber();
        if(val_2 != this.lastLevelCollectedAt)
        {
                val_2 = this.currentStreakGoal;
        }
        
        if(val_2 == 0)
        {
                return false;
        }
        
        if(this.currentStreak >= val_2)
        {
                0 = 1;
        }
        
        if(this.currentStreak != 0)
        {
                this.currentStreak = 1;
        }
        
        return true;
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1190270448, defaultValue:  -1190270544, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        if(this.CanEngageWithEvent() == false)
        {
                return;
        }
        
        string val_2 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1190270448, defaultValue:  -1190270544, useSingularKey:  false);
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
    public override int LastProgressTimestamp()
    {
        return HotStreakEventHandler.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        HotStreakEventHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        var val_6;
        float val_7;
        if(this.CanEngageWithEvent() != false)
        {
                string val_2 = System.String.Format(format:  -1189482240, arg0:  13152256, arg1:  13152256);
            val_6 = "STREAKS {0}/{1}";
        }
        else
        {
                val_6 = "-/-";
        }
        
        if(this.CanEngageWithEvent() != false)
        {
                val_7 = (float)this.currentStreak / (float)this.currentStreakGoal;
        }
        else
        {
                val_7 = 0f;
        }
        
        TheLibraryMainScreen val_4 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override string GetHackPanelEventData()
    {
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        typeof(System.Object[]).__il2cppRuntimeField_10 = "last level shown at ";
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = " inside mode ";
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = " (secondary id: ";
        typeof(System.Object[]).__il2cppRuntimeField_24 = this.lastModeSecondaryId;
        typeof(System.Object[]).__il2cppRuntimeField_28 = ")";
        string val_2 = +472754880;
        System.Text.StringBuilder val_3 = AppendLine(value:  472754880);
        string val_5 = this.CanEngageWithEvent().ToString();
        string val_6 = -1189360512(-1189360512) + -1189347829(-1189347829);
        System.Text.StringBuilder val_7 = AppendLine(value:  -1189360512);
        if(this.CanEngageWithEvent() != true)
        {
                string val_9 = -1189360400(-1189360400) + 13152256;
            System.Text.StringBuilder val_10 = AppendLine(value:  -1189360400);
            string val_11 = -1189360288(-1189360288) + 13152256;
            System.Text.StringBuilder val_12 = AppendLine(value:  -1189360288);
        }
        
        string val_13 = -1189360160(-1189360160) + 13152256;
        System.Text.StringBuilder val_14 = AppendLine(value:  -1189360160);
        Player val_15 = App.Player;
        string val_16 = -1189360032(-1189360032) + 13152256;
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_17 = AppendLine(value:  -1189360032);
        }
        else
        {
                System.Text.StringBuilder val_18 = AppendLine(value:  -1189360032);
        }
        
        System.Text.StringBuilder val_19 = AppendLine(value:  -1189359888);
        string val_20 = PrettyPrint.printJSON(obj:  "current lifetime largest streak ".__il2cppRuntimeField_48, types:  false, singleLineOutput:  false);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_21 = AppendLine(value:  "current lifetime largest streak ".__il2cppRuntimeField_48);
            return;
        }
        
        System.Text.StringBuilder val_22 = AppendLine(value:  "current lifetime largest streak ".__il2cppRuntimeField_48);
    }
    public override bool get_IsEventHidden()
    {
        if(R4 != 0)
        {
                return (bool)R4 + 62;
        }
        
        return (bool)R4 + 62;
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        int val_3;
        var val_4;
        val_3 = 35636332;
        if(this.IsCurrentModeEqualsModeWithExistingStreak() == false)
        {
                return;
        }
        
        val_3 = this.lastLevelShowAt;
        val_4 = 0;
        if(val_3 != PlayingLevel.GetCurrentPlayerLevelNumber())
        {
                return;
        }
        
        if(this.currentStreak >= this.currentStreakGoal)
        {
                val_4 = 1;
        }
        
        currentData.Add(key:  -1189127680, value:  8945664);
    }
    public int GetCoinReward()
    {
        return (int)this.reward;
    }
    public void CollectReward()
    {
        this.lastLevelCollectedAt = PlayingLevel.GetCurrentPlayerLevelNumber();
        decimal val_2 = System.Decimal.op_Implicit(value:  -1188887464);
        CurrencyController.CreditBalance(value:  new System.Decimal(), source:  "hot streak event", externalParams:  0, animated:  false);
        this.SaveData();
    }
    public HotStreakEventHandler()
    {
        this.lastLevelShowAt = 9999;
        this.levelsLapsedSinceLastShown = 9999;
        this.lastModeShowAt = 1;
    }

}
