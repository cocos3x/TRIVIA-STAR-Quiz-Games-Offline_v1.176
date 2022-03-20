using UnityEngine;
public class ForestFrenzyEventHandler : WGEventHandler
{
    // Fields
    public const string EVENT_ID = "ForestFrenzy";
    private const string ECONOMY = "economy";
    private int track_ShovelsEarnedThisLevel;
    private static ForestFrenzyEventHandler <Instance>k__BackingField;
    
    // Properties
    private static int LastProgressTimestampPref { get; set; }
    public static ForestFrenzyEventHandler Instance { get; set; }
    public override bool SupportsGoldenApples { get; }
    
    // Methods
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1400216592, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1400216592, value:  value);
    }
    public static ForestFrenzyEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(ForestFrenzyEventHandler value)
    {
        ForestFrenzyEventHandler.<Instance>k__BackingField = value;
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_1 = 28428325;
        mem[1152921511797053480] = eventV2;
        val_1 = 7199632 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        ForestFrenzyEventHandler.<Instance>k__BackingField = this;
        ForestFrenzyEventProgress.Init(gameEventV2:  eventV2);
        eventV2.ParseEventData(data:  eventV2.eventData);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        this.ParseEventData(data:  eventV2.eventData);
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -1401236896);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowForestScene();
    }
    public override void OnGameButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowForestScene();
    }
    public override void OnAppleAwarded(int appleAwarded)
    {
        int val_9;
        int val_10;
        var val_11;
        val_9 = appleAwarded;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        val_10 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_11 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            if(PlayingChallenge == true)
        {
                return;
        }
        
        }
        
        if(this != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_11 = public static ForestFrenzyManager MonoSingleton<ForestFrenzyManager>::get_Instance();
        val_10 = UnityEngine.Mathf.Max(a:  0, b:  val_9);
        AddCurrency(amount:  val_10);
        int val_8 = this.track_ShovelsEarnedThisLevel;
        val_8 = val_8 + val_9;
        this.track_ShovelsEarnedThisLevel = val_8;
        if(val_9 < 1)
        {
                return;
        }
        
        goto typeof(ForestFrenzyEventHandler).__il2cppRuntimeField_17C;
    }
    public override bool get_SupportsGoldenApples()
    {
        return true;
    }
    public override string GetMainMenuButtonText()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_2 = CurrentForestGrowth;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_4 = CurrentMaxGrowth;
        string val_5 = System.String.Format(format:  -1399054496, arg0:  -1399030400, arg1:  13152256, arg2:  13152256);
    }
    public override string GetGameButtonText()
    {
    
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1398830304, defaultValue:  -1398830400, useSingularKey:  false);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_5 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        float val_7 = (float)CurrentForestGrowth;
        val_7 = val_7 / (float)CurrentMaxGrowth;
        TheLibraryMainScreen val_6 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        var val_8;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            if(PlayingChallenge == true)
        {
                return;
        }
        
        }
        
        if(this != 0)
        {
                return;
        }
        
        this.OnLevelComplete(levelsProgressed:  levelsProgressed);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_7 = TryShowForestBeforeLevelComplete();
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        var val_6;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            if(PlayingChallenge == true)
        {
                return;
        }
        
        }
        
        if(this != 0)
        {
                return;
        }
        
        val_6 = null;
        currentData.Add(key:  -1398480960, value:  13152256);
        this.track_ShovelsEarnedThisLevel = 0;
    }
    public override bool ShouldShowInDailyChallenge(bool dailyChallengeState)
    {
        bool val_1 = CategoryPacksManager.IsPlaying;
        val_1 = val_1 | dailyChallengeState;
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public override bool EventCompleted()
    {
        var val_1;
        var val_1 = 28424066;
        val_1 = 7203892 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        return (bool)ForestFrenzyEventProgress.hasRewarded;
    }
    public override int LastProgressTimestamp()
    {
        return ForestFrenzyEventHandler.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        ForestFrenzyEventHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        if(data == 0)
        {
                return;
        }
        
        if((data.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_2 = data.Item[-1554533760];
        if(data == 0)
        {
                return;
        }
        
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                data = 0;
        }
        
        if((data.ContainsKey(key:  -1397912752)) != false)
        {
                string val_4 = data.Item[-1397912752];
            System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
            val_15;
            decimal val_6 = System.Decimal.Parse(s:  -1397900528, provider:  0);
            val_16 = null;
            val_16 = null;
        }
        
        if((data.ContainsKey(key:  -1397912656)) != false)
        {
                string val_8 = data.Item[-1397912656];
            val_15 = 1152921504923566080;
            val_17 = null;
            val_17 = null;
            bool val_10 = System.Int32.TryParse(s:  null, result: out  int val_9 = 316723204);
        }
        
        if((data.ContainsKey(key:  -1397912560)) == false)
        {
                return;
        }
        
        string val_12 = data.Item[-1397912560];
        val_18 = null;
        val_18 = null;
        bool val_14 = System.Int32.TryParse(s:  null, result: out  int val_13 = 316723208);
    }
    public ForestFrenzyEventHandler()
    {
    
    }

}
