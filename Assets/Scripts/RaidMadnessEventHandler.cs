using UnityEngine;
public class RaidMadnessEventHandler : WGEventHandler
{
    // Fields
    public const string RAID_MADNESS_EVENT_ID = "RaidMadness";
    public const string EVENT_TRACKING_ID = "Raid Madness";
    private RaidMadnessEcon econ;
    private RaidMadnessProgress progressData;
    protected bool suppressRewardCollectionPopup;
    protected bool isEventInitialized;
    private static RaidMadnessEventHandler <Instance>k__BackingField;
    private int <ProgressDisplayPoints>k__BackingField;
    private int <EventButtonDisplayPoints>k__BackingField;
    
    // Properties
    public static bool IsEventActive { get; }
    public RaidMadnessEcon Econ { get; }
    public RaidMadnessProgress ProgressData { get; }
    public static RaidMadnessEventHandler Instance { get; set; }
    public int PlayerTier { get; set; }
    public int ProgressLevel { get; set; }
    public int PlayerLevel { get; }
    public override int UnlockLevel { get; }
    public System.DateTime TimeExpire { get; }
    public override bool IsPointCollection { get; }
    public override int PointsCollected { get; set; }
    public override int PointsRequired { get; }
    public int PointsCollectedForCurrentLevel { get; set; }
    public int ProgressDisplayPoints { get; set; }
    public int EventButtonDisplayPoints { get; set; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static bool get_IsEventActive()
    {
        if((RaidMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return false;
        }
        
        goto typeof(RaidMadnessEventHandler).__il2cppRuntimeField_274;
    }
    public RaidMadnessEcon get_Econ()
    {
    
    }
    public RaidMadnessProgress get_ProgressData()
    {
    
    }
    public static RaidMadnessEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(RaidMadnessEventHandler value)
    {
        RaidMadnessEventHandler.<Instance>k__BackingField = value;
    }
    public int get_PlayerTier()
    {
        if(this.progressData != 0)
        {
                return (int)this.progressData.playerTierAtEventStart;
        }
        
        return (int)this.progressData.playerTierAtEventStart;
    }
    protected void set_PlayerTier(int value)
    {
        this.progressData.playerTierAtEventStart = value;
    }
    public int get_ProgressLevel()
    {
        if(this.progressData != 0)
        {
                return (int)this.progressData.rewardProgressLevel;
        }
        
        return (int)this.progressData.rewardProgressLevel;
    }
    protected void set_ProgressLevel(int value)
    {
        this.progressData.rewardProgressLevel = value;
    }
    public int get_PlayerLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override int get_UnlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        return UnityEngine.Mathf.Max(a:  983057, b:  this.econ.unlockPlayerLevel);
    }
    public System.DateTime get_TimeExpire()
    {
        this = R1 + 8 + 40;
        return new System.DateTime() {dateData = R1 + 8 + 40};
    }
    public override bool get_IsPointCollection()
    {
        return true;
    }
    public override int get_PointsCollected()
    {
        if(this.progressData != 0)
        {
                return (int)this.progressData.pointsCollected;
        }
        
        return (int)this.progressData.pointsCollected;
    }
    public override void set_PointsCollected(int value)
    {
        this.progressData.pointsCollected = value;
        if(this.progressData == 0)
        {
            
        }
    
    }
    public override int get_PointsRequired()
    {
        if(this != 0)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    public int get_PointsCollectedForCurrentLevel()
    {
        if(this.progressData.pointsCollectedDuringGameLevel == 0)
        {
                System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_1 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            this.progressData.pointsCollectedDuringGameLevel = null;
        }
        
        GameplayMode val_2 = PlayingLevel.CurrentGameplayMode;
        return EnumerableExtentions.GetOrDefault<System.Int32Enum, System.Int32>(dic:  this.progressData.pointsCollectedDuringGameLevel, key:  0, defaultValue:  0);
    }
    protected void set_PointsCollectedForCurrentLevel(int value)
    {
        if(this.progressData.pointsCollectedDuringGameLevel == 0)
        {
                this.progressData = null;
            this.progressData = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            this.progressData.pointsCollectedDuringGameLevel = this.progressData;
        }
        
        GameplayMode val_2 = PlayingLevel.CurrentGameplayMode;
        EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Int32>(dic:  this.progressData.pointsCollectedDuringGameLevel, key:  0, newValue:  value);
    }
    public int get_ProgressDisplayPoints()
    {
        return (int)this.<ProgressDisplayPoints>k__BackingField;
    }
    protected void set_ProgressDisplayPoints(int value)
    {
        this.<ProgressDisplayPoints>k__BackingField = value;
    }
    public int get_EventButtonDisplayPoints()
    {
        return (int)this.<EventButtonDisplayPoints>k__BackingField;
    }
    protected void set_EventButtonDisplayPoints(int value)
    {
        this.<EventButtonDisplayPoints>k__BackingField = value;
    }
    public override bool ActivelyPlayingGameMode()
    {
        if(this.IsCurrentEventInCycle() == false)
        {
                return (bool)0;
        }
        
        if(this.IsEventExpired() == true)
        {
                return (bool)0;
        }
        
        0 = this.HasCollectedAllRewards() ^ 1;
        return (bool)0;
    }
    public override void PreInit(GameEventV2 eventV2)
    {
        this.econ = new RaidMadnessEcon(eventDataDict:  eventV2.eventData);
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_3 = 27451913;
        mem[1152921512123051896] = eventV2;
        val_3 = 8178088 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        RaidMadnessEventHandler.<Instance>k__BackingField = this;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1073729680, method:  typeof(RaidMadnessEventHandler).__il2cppRuntimeField_410);
        AddRaidCompletedListener(listener:  7401472);
        this.SetupEvent();
        this.<EventButtonDisplayPoints>k__BackingField = this;
    }
    public override void Dispose()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1073613584, method:  typeof(RaidMadnessEventHandler).__il2cppRuntimeField_410);
        RemoveRaidCompletedListener(listener:  7401472);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        if((System.String.op_Inequality(a:  eventV2.type, b:  -1298907488)) != false)
        {
                return;
        }
        
        this.SetupEvent();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1073397104, defaultValue:  -1073397200, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        if(this.progressData.totalPointsCollected >= 1)
        {
                string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            return;
        }
        
        string val_2 = Localization.Localize(key:  -1114329152, defaultValue:  -1114329232, useSingularKey:  false);
        return System.String.Format(format:  -1549756304, arg0:  -1114329152);
    }
    public override string GetGameButtonText()
    {
        if(this.HasCollectedAllRewards() != false)
        {
                string val_2 = Localization.Localize(key:  -1549640032, defaultValue:  -1549640128, useSingularKey:  false);
            return;
        }
        
        string val_3 = this.<ProgressDisplayPoints>k__BackingField.ToString();
    }
    public override bool ShowEventUI(EventButtonPanel.LayoutType layoutType, EventButtonPanel.DisplayContext context)
    {
        LayoutType val_1 = layoutType - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public bool HasCollectedAllRewards()
    {
        int val_4;
        var val_5;
        RaidMadnessProgress val_6;
        val_4 = this;
        val_5 = 0;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  this.PlayerLevel, knobValue:  -1072888128)) == false)
        {
                return true;
        }
        
        val_6 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_4;
        }
        
        val_6 = this.progressData;
        if(val_6 == 0)
        {
            goto label_5;
        }
        
        label_4:
        val_4 = this.progressData.rewardProgressLevel;
        if(val_4 >= (this.econ.GetTotalCollectableRewards(playerTier:  this.progressData.playerTierAtEventStart)))
        {
                val_5 = 1;
        }
        
        return true;
        label_5:
    }
    public override bool EventCompleted()
    {
        if(this.IsEventExpired() == false)
        {
                return this.HasCollectedAllRewards();
        }
        
        return true;
    }
    public override bool IsChallengeCompleted()
    {
        return this.HasCollectedAllRewards();
    }
    public override bool get_IsEventValid()
    {
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  this.PlayerLevel, knobValue:  -1072539840);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        float val_6;
        var val_7;
        if(this.HasCollectedAllRewards() != false)
        {
                val_6 = 1f;
        }
        else
        {
                val_6 = 1f;
        }
        
        if(this.HasCollectedAllRewards() != false)
        {
                val_7 = "COMPLETED!";
        }
        else
        {
                string val_3 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            val_7 = "{0}/{1}";
        }
        
        TheLibraryMainScreen val_4 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        loader.SetupSlider(sliderText:  1629069648, sliderValue:  -1.072423E+09f, eventCompleted:  1f, rewardData:  this.HasCollectedAllRewards());
    }
    public override void OnEventEnded()
    {
        this.progressData = new RaidMadnessProgress();
    }
    public override void OnMenuLoaded()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 5)
        {
                return;
        }
        
        R4.ShowPopup(firstTime:  true);
    }
    public override void OnGameSceneInit()
    {
        this.<ProgressDisplayPoints>k__BackingField = this.PointsCollectedForCurrentLevel;
    }
    public override void OnGameSceneBegan()
    {
        this.ShowPopup(firstTime:  true);
    }
    public override void OnNewForestShown()
    {
        this.ShowPopup(firstTime:  true);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        if(this != 0)
        {
                return;
        }
        
        R4.ShowPopup(firstTime:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        this.ShowPopup(firstTime:  false);
    }
    public void UpdateProgressToServer()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1548151456, value:  13152256);
        Add(key:  -1548147264, value:  13152256);
        Add(key:  -1548147152, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -1071506240, data:  78753792);
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        this.suppressRewardCollectionPopup = true;
        this.ApplyPointsEarnedInLevel();
        RaidMadnessRewardData val_1 = RaidMadnessEconDataHelper.ParseCSV();
        this.econ.rewardData = this;
    }
    public override System.Collections.IEnumerator DoLevelCompleteEventProgressAnimation(WGEventButtonV2 eventButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(RaidMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__70).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(RaidMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__70).__il2cppRuntimeField_10 = this;
            typeof(RaidMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__70).__il2cppRuntimeField_14 = eventProgressUI;
            typeof(RaidMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__70).__il2cppRuntimeField_18 = eventButton;
        }
        else
        {
                mem[16] = this;
            mem[24] = eventButton;
            mem[20] = eventProgressUI;
        }
        
        typeof(RaidMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__70).__il2cppRuntimeField_20 = popup;
    }
    private System.Collections.IEnumerator DoRewardSequence(WGEventButtonV2 eventButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(RaidMadnessEventHandler.<DoRewardSequence>d__71).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(RaidMadnessEventHandler.<DoRewardSequence>d__71).__il2cppRuntimeField_10 = eventProgressUI;
            typeof(RaidMadnessEventHandler.<DoRewardSequence>d__71).__il2cppRuntimeField_18 = eventButton;
        }
        else
        {
                mem[24] = eventButton;
            mem[16] = eventProgressUI;
        }
        
        typeof(RaidMadnessEventHandler.<DoRewardSequence>d__71).__il2cppRuntimeField_14 = popup;
    }
    public override RESEventRewardData GetCurrentReward()
    {
        RaidMadnessProgress val_2;
        if(this.progressData.currentRewardData != 0)
        {
            goto label_1;
        }
        
        val_2 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_2;
        }
        
        val_2 = this.progressData;
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        label_2:
        RESEventRewardData val_1 = this.econ.GetEventReward(playerTier:  this.progressData.playerTierAtEventStart, rewardProgressLevel:  this.progressData.rewardProgressLevel);
        this.progressData.currentRewardData = this.econ;
        label_1:
        if(this.progressData != 0)
        {
                return;
        }
        
        return;
        label_3:
    }
    public RESEventRewardData GetFinalPrize()
    {
        if(this.econ != 0)
        {
                return this.econ.GetFinalPrize(playerTier:  this.progressData.playerTierAtEventStart);
        }
        
        return this.econ.GetFinalPrize(playerTier:  this.progressData.playerTierAtEventStart);
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        int val_1 = this.PointsCollectedForCurrentLevel;
        currentData.Add(key:  -1070714960, value:  13152256);
    }
    private void OnPointGainComplete()
    {
        if(this.IsRewardReadyToCollect() != true)
        {
                WordRegion val_2 = WordRegion.instance;
            0.RemoveLevelCompleteBlocker(blocker:  3);
        }
        
        this.<ProgressDisplayPoints>k__BackingField = this.PointsCollectedForCurrentLevel;
        this.UpdateProgress();
    }
    public override void OnMysteryChestCollected()
    {
        if(this.PointsCollectedForCurrentLevel <= (this.<ProgressDisplayPoints>k__BackingField))
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        System.Action val_6 = new System.Action(object:  -1070461808, method:  new IntPtr(3224480464));
        0.Setup(type:  1, points:  this.PointsCollectedForCurrentLevel - (this.<ProgressDisplayPoints>k__BackingField), initialPoints:  this.<ProgressDisplayPoints>k__BackingField, _onComplete:  null);
        WordRegion val_7 = WordRegion.instance;
        0.AddLevelCompleteBlocker(blocker:  3);
    }
    protected virtual void OnRaidCompleted(bool isRaidPerfect)
    {
        if(this != 0)
        {
                return;
        }
        
        if(this.HasCollectedAllRewards() == true)
        {
                return;
        }
        
        if(this == 0)
        {
                return;
        }
        
        if(this.econ.pointsGainPerRaid < 1)
        {
                return;
        }
        
        this.PointsCollectedForCurrentLevel = this.econ.pointsGainPerRaid + this.PointsCollectedForCurrentLevel;
    }
    protected void ApplyPointsEarnedInLevel()
    {
        RaidMadnessProgress val_5;
        int val_6;
        var val_7;
        val_5 = this.progressData;
        if(val_5 != 0)
        {
                val_6 = this.progressData.totalPointsCollected;
            val_7 = this.PointsCollectedForCurrentLevel;
        }
        else
        {
                val_5 = 36;
            val_6 = 83886592;
            int val_2 = this.PointsCollectedForCurrentLevel;
            val_7 = val_2;
        }
        
        val_2 = val_6 + val_7;
        mem[36] = val_2;
        int val_4 = this.PointsCollectedForCurrentLevel + this;
        this.PointsCollectedForCurrentLevel = 0;
        this.UpdateProgressToServer();
    }
    protected virtual UnityEngine.GameObject ShowRewardCollection()
    {
        var val_8;
        if(this.suppressRewardCollectionPopup != false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) != 0)
        {
                GameBehavior val_3 = App.getBehavior;
            val_8 = 0;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        System.Action val_7 = new System.Action(object:  -1070100096, method:  typeof(RaidMadnessEventHandler).__il2cppRuntimeField_420);
        if(val_8 != 0)
        {
                InitReward(title:  -1070100096, reward:  -1070100096, source:  -1070124208, onCollectClicked:  null, onClose:  0);
            return gameObject;
        }
        
        0.InitReward(title:  -1070100096, reward:  -1070100096, source:  -1070124208, onCollectClicked:  null, onClose:  0);
        return gameObject;
    }
    protected virtual void OnCurrentRewardCollected()
    {
        RaidMadnessProgress val_3;
        RaidMadnessProgress val_4;
        int val_1 = UnityEngine.Mathf.Max(a:  0, b:  0);
        val_3 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_3;
        }
        
        val_3 = this.progressData;
        if(val_3 == 0)
        {
            goto label_6;
        }
        
        label_3:
        int val_3 = this.progressData.rewardProgressLevel;
        val_3 = val_3 + 1;
        this.progressData.rewardProgressLevel = val_3;
        val_4 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_5;
        }
        
        val_4 = this.progressData;
        if(val_4 == 0)
        {
            goto label_6;
        }
        
        label_5:
        RESEventRewardData val_2 = this.econ.GetEventReward(playerTier:  this.progressData.playerTierAtEventStart, rewardProgressLevel:  this.progressData.rewardProgressLevel);
        this.progressData.currentRewardData = this.econ;
        this.<EventButtonDisplayPoints>k__BackingField = this;
        this.UpdateProgressToServer();
        return;
        label_6:
    }
    private bool IsEventExpired()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R7 + 40})) == false)
        {
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = this.<EventButtonDisplayPoints>k__BackingField});
        }
        
        return true;
    }
    private bool IsCurrentEventInCycle()
    {
        var val_1 = R6 + 48;
        val_1 = this.progressData.eventId - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    private void ParsePlayerProgressFromServer(System.Collections.Generic.Dictionary<string, object> eventDataDict)
    {
        RaidMadnessProgress val_15;
        if(eventDataDict == 0)
        {
                return;
        }
        
        if((eventDataDict.ContainsKey(key:  -1545439648)) == false)
        {
                return;
        }
        
        object val_2 = eventDataDict.Item[-1545439648];
        if((0.ContainsKey(key:  -1548151456)) != false)
        {
                string val_4 = 0.Item[-1548151456];
            if((System.Int32.TryParse(s:  null, result: out  int val_5 = -1069602696)) != false)
        {
                val_15 = this.progressData;
            this.progressData.playerTierAtEventStart = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -1548147264)) != false)
        {
                string val_8 = 0.Item[-1548147264];
            if((System.Int32.TryParse(s:  null, result: out  int val_9 = -1069602700)) != false)
        {
                val_15 = this.progressData;
            this.progressData.rewardProgressLevel = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -1548147152)) == false)
        {
                return;
        }
        
        string val_12 = 0.Item[-1548147152];
        if((System.Int32.TryParse(s:  null, result: out  int val_13 = -1069602704)) == false)
        {
                return;
        }
    
    }
    private void SetupEvent()
    {
        RaidMadnessProgress val_9;
        var val_10;
        if(true != 0)
        {
                true = 67108865;
            goto label_1;
        }
        
        label_24:
        if(this.IsEventExpired() != true)
        {
                if(this.IsCurrentEventInCycle() == true)
        {
            goto label_12;
        }
        
        }
        
        this.progressData = new RaidMadnessProgress();
        val_9 = 8178624 + 27447163;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        if(App.game == 20)
        {
                val_9 = this.progressData;
            this.progressData.playerTierAtEventStart = RestaurantRivals.CommonEventEconDataHelper.GetPlayerTier();
        }
        
        label_12:
        if(this.IsEventExpired() == true)
        {
                return;
        }
        
        this.ParsePlayerProgressFromServer(eventDataDict:  val_4 + 72);
        val_9 = this.progressData.hasSeenPopup;
        this.progressData.eventId = val_9;
        this.isEventInitialized = true;
        return;
        label_1:
        if((true.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_24;
        }
        
        string val_7 = mem[35629968].Item[-1554533760];
        if(mem[35629968] == 0)
        {
            goto label_24;
        }
        
        this.econ = new RaidMadnessEcon(eventDataDict:  mem[35629968] + 72);
        goto label_24;
    }
    private void ShowPopup(bool firstTime = False)
    {
        var val_11 = this;
        if(firstTime != false)
        {
                if(this.progressData.hasSeenPopup == true)
        {
                return;
        }
        
        }
        
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  this.progressData.hasSeenPopup.PlayerLevel, knobValue:  R4)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) != 0)
        {
                GameBehavior val_6 = App.getBehavior;
            if(0 != 0)
        {
            goto label_16;
        }
        
        }
        else
        {
                GameBehavior val_8 = App.getBehavior;
        }
        
        label_16:
        mem2[0] = 1;
    }
    public void ResetEventProgress()
    {
        var val_3;
        this.progressData = new RaidMadnessProgress();
        var val_3 = 27439943;
        val_3 = 8185844 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        if(App.game != 20)
        {
                return;
        }
        
        this.progressData.playerTierAtEventStart = RestaurantRivals.CommonEventEconDataHelper.GetPlayerTier();
    }
    private string GetPlatformId()
    {
    
    }
    public override string GetHackPanelEventData()
    {
        var val_28;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        if(this.progressData.playerTierAtEventStart == 1)
        {
                "ffffff" = "ff9200";
        }
        
        string val_2 = System.String.Format(format:  -1670416656, arg0:  -1544804800, arg1:  15282176);
        if(this.progressData.playerTierAtEventStart == 2)
        {
                "ffffff" = "ff9200";
        }
        
        string val_3 = System.String.Format(format:  -1670416656, arg0:  -1544804800, arg1:  15282176);
        if(this.progressData.playerTierAtEventStart == 3)
        {
                "ffffff" = "ff9200";
        }
        
        string val_4 = System.String.Format(format:  -1670416656, arg0:  -1544804800, arg1:  15282176);
        System.Text.StringBuilder val_5 = AppendLine(value:  -1544784160);
        string val_6 = this.econ.unlockPlayerLevel.ToString();
        string val_7 = System.String.Format(format:  -1544779920, arg0:  this.econ.unlockPlayerLevel);
        System.Text.StringBuilder val_8 = AppendLine(value:  -1544779920);
        string val_9 = System.String.Format(format:  -1544779792, arg0:  -1670416656, arg1:  -1670416656, arg2:  -1670416656);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_10 = AppendLine(value:  -1544779792);
        }
        else
        {
                System.Text.StringBuilder val_11 = AppendLine(value:  -1544779792);
        }
        
        System.Text.StringBuilder val_12 = AppendLine(value:  -1544779600);
        string val_13 = System.String.Format(format:  -1544775360, arg0:  13152256);
        System.Text.StringBuilder val_14 = AppendLine(value:  -1544775360);
        string val_15 = System.String.Format(format:  -1544771152, arg0:  13152256);
        System.Text.StringBuilder val_16 = AppendLine(value:  -1544771152);
        string val_17 = System.String.Format(format:  -1544766944, arg0:  13152256);
        System.Text.StringBuilder val_18 = AppendLine(value:  -1544766944);
        float val_28 = (float)this.progressData.totalPointsCollected;
        val_28 = val_28 / (float)this.progressData.totalSpinResourceSpent;
        string val_19 = System.String.Format(format:  -1544762736, arg0:  15282176);
        System.Text.StringBuilder val_20 = AppendLine(value:  -1544762736);
        val_28 = null;
        val_28 = null;
        string val_21 = System.String.Format(format:  -1544762624, arg0:  429871104);
        System.Text.StringBuilder val_22 = AppendLine(value:  -1544762624);
        string val_23 = System.String.Format(format:  -1544758384, arg0:  13152256);
        System.Text.StringBuilder val_24 = AppendLine(value:  -1544758384);
        string val_25 = System.String.Format(format:  -1544754160, arg0:  13152256);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_26 = AppendLine(value:  -1544754160);
            return;
        }
        
        System.Text.StringBuilder val_27 = AppendLine(value:  -1544754160);
    }
    public RaidMadnessEventHandler()
    {
        this.econ = new RaidMadnessEcon(eventDataDict:  0);
        this.progressData = new RaidMadnessProgress();
    }

}
