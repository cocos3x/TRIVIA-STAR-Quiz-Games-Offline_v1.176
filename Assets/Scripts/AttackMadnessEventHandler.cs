using UnityEngine;
public class AttackMadnessEventHandler : WGEventHandler
{
    // Fields
    public const string ATTACK_MADNESS_EVENT_ID = "AttackMadness";
    public const string EVENT_TRACKING_ID = "Attack Madness";
    private AttackMadnessEcon econ;
    private AttackMadnessProgress progressData;
    protected bool suppressRewardCollectionPopup;
    protected bool isEventInitialized;
    private static AttackMadnessEventHandler <Instance>k__BackingField;
    private bool <NeedToShowProgress>k__BackingField;
    
    // Properties
    public static bool IsEventActive { get; }
    public AttackMadnessEcon Econ { get; }
    public AttackMadnessProgress ProgressData { get; }
    public static AttackMadnessEventHandler Instance { get; set; }
    public int PlayerTier { get; set; }
    public int ProgressLevel { get; set; }
    public int PlayerLevel { get; }
    public override int UnlockLevel { get; }
    public System.DateTime TimeExpire { get; }
    public override bool IsPointCollection { get; }
    public override int PointsCollected { get; set; }
    public int PointsCollectedInLevel { get; }
    public override int PointsRequired { get; }
    public bool NeedToShowProgress { get; set; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static bool get_IsEventActive()
    {
        if((AttackMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return false;
        }
        
        goto typeof(AttackMadnessEventHandler).__il2cppRuntimeField_274;
    }
    public AttackMadnessEcon get_Econ()
    {
    
    }
    public AttackMadnessProgress get_ProgressData()
    {
    
    }
    public static AttackMadnessEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(AttackMadnessEventHandler value)
    {
        AttackMadnessEventHandler.<Instance>k__BackingField = value;
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
        goto r2;
    }
    public override int get_UnlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        return UnityEngine.Mathf.Max(a:  typeof(App).__il2cppRuntimeField_3EC, b:  this.econ.unlockPlayerLevel);
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
    public int get_PointsCollectedInLevel()
    {
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        return EnumerableExtentions.GetOrDefault<System.Int32Enum, System.Int32>(dic:  this.progressData.pointsCollectedDuringGameLevel, key:  0, defaultValue:  0);
    }
    public override int get_PointsRequired()
    {
        if(this != 0)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    public bool get_NeedToShowProgress()
    {
        return (bool)this.<NeedToShowProgress>k__BackingField;
    }
    public void set_NeedToShowProgress(bool value)
    {
        this.<NeedToShowProgress>k__BackingField = value;
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
        this.econ = new AttackMadnessEcon(eventDataDict:  eventV2.eventData);
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_3 = 26300775;
        mem[1152921511646576216] = eventV2;
        val_3 = 9331336 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        AttackMadnessEventHandler.<Instance>k__BackingField = this;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1550205360, method:  typeof(AttackMadnessEventHandler).__il2cppRuntimeField_418);
        AddAttackCompletedListener(listener:  7401472);
        this.SetupEvent();
    }
    public override void Dispose()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1550089264, method:  typeof(AttackMadnessEventHandler).__il2cppRuntimeField_418);
        RemoveAttackCompletedListener(listener:  7401472);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        if((System.String.op_Inequality(a:  eventV2.type, b:  -1549997168)) != false)
        {
                return;
        }
        
        this.SetupEvent();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1549872688, defaultValue:  -1549872784, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        if(this.progressData.totalPointsCollected >= 1)
        {
                string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            return;
        }
        
        string val_2 = Localization.Localize(key:  -1549756400, defaultValue:  -1549756480, useSingularKey:  false);
        return System.String.Format(format:  -1549756304, arg0:  -1549756400);
    }
    public override string GetGameButtonText()
    {
        if(this.HasCollectedAllRewards() != false)
        {
                string val_2 = Localization.Localize(key:  -1549640032, defaultValue:  -1549640128, useSingularKey:  false);
            return;
        }
        
        string val_4 = this.PointsCollectedInLevel.ToString();
    }
    public bool HasCollectedAllRewards()
    {
        AttackMadnessEcon val_4;
        var val_5;
        AttackMadnessProgress val_6;
        val_4 = this;
        val_5 = 0;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  this.PlayerLevel, knobValue:  -1549442496)) == false)
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
        val_4 = this.econ;
        int val_3 = val_4.GetTotalCollectableRewards(playerTier:  this.progressData.playerTierAtEventStart);
        val_5 = 1;
        if(this.progressData.rewardProgressLevel >= val_3)
        {
                return true;
        }
        
        val_4 = this.econ;
        if(this.progressData.playerTierAtEventStart > val_3)
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
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  this.PlayerLevel, knobValue:  -1549045056);
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
        loader.SetupSlider(sliderText:  1629069648, sliderValue:  -1.548928E+09f, eventCompleted:  1f, rewardData:  this.HasCollectedAllRewards());
    }
    public override void OnEventEnded()
    {
        this.progressData = new AttackMadnessProgress();
    }
    public override void OnMenuLoaded()
    {
        GameBehavior val_1 = App.getBehavior;
        if(App.__il2cppRuntimeField_namespaze != 5)
        {
                return;
        }
        
        R4.ShowPopup(firstTime:  true);
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
        PutUpdate(eventID:  -1548122016, data:  78753792);
    }
    public override void OnSpinBetUpdate()
    {
    
    }
    public override void OnSpinStarted()
    {
    
    }
    public override void OnSpinEnded()
    {
    
    }
    public override RESEventRewardData GetCurrentReward()
    {
        AttackMadnessProgress val_2;
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
    public decimal GetGrandPrizeSpinAmount()
    {
        decimal val_1 = this.GetGrandPrizeSpinAmount(playerTier:  R1 + 16);
        return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
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
        if(this.progressData.pointsCollectedDuringGameLevel == 0)
        {
                return;
        }
        
        int val_1 = this.PointsCollectedInLevel;
        currentData.Add(key:  -1547267888, value:  13152256);
    }
    public override System.Collections.IEnumerator DoLevelCompleteEventProgressAnimation(WGEventButtonV2 eventButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(AttackMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__69).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(AttackMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__69).__il2cppRuntimeField_10 = this;
            typeof(AttackMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__69).__il2cppRuntimeField_14 = eventButton;
            typeof(AttackMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__69).__il2cppRuntimeField_18 = eventProgressUI;
        }
        else
        {
                mem[16] = this;
            mem[20] = eventButton;
            mem[24] = eventProgressUI;
        }
        
        typeof(AttackMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__69).__il2cppRuntimeField_1C = popup;
    }
    public override bool ShowEventUI(EventButtonPanel.LayoutType layoutType, EventButtonPanel.DisplayContext context)
    {
        var val_2 = 0;
        if(this != 0)
        {
                return (bool)val_2;
        }
        
        if(layoutType == 1)
        {
                if(context == 3)
        {
                return (bool)val_2;
        }
        
            if(context == 5)
        {
                if(this.PointsCollectedInLevel >= 1)
        {
                val_2 = 1;
        }
        
            return (bool)val_2;
        }
        
        }
        
        val_2 = 1;
        return (bool)val_2;
    }
    public override void OnMysteryChestCollected()
    {
        if(this.PointsCollectedInLevel < 1)
        {
                return;
        }
        
        this.ShowNewSymbolAnimation();
    }
    private System.Collections.IEnumerator PlayNextRewardSequence(WGEventButtonV2 eventButton)
    {
        typeof(AttackMadnessEventHandler.<PlayNextRewardSequence>d__72).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(AttackMadnessEventHandler.<PlayNextRewardSequence>d__72).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(AttackMadnessEventHandler.<PlayNextRewardSequence>d__72).__il2cppRuntimeField_14 = eventButton;
    }
    private System.Collections.IEnumerator PlayPointCollectionSequence(int startValue, int points, WGEventButtonV2_AttackMadness attackMadnessButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(AttackMadnessEventHandler.<PlayPointCollectionSequence>d__73).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(AttackMadnessEventHandler.<PlayPointCollectionSequence>d__73).__il2cppRuntimeField_10 = attackMadnessButton;
            typeof(AttackMadnessEventHandler.<PlayPointCollectionSequence>d__73).__il2cppRuntimeField_14 = this;
            typeof(AttackMadnessEventHandler.<PlayPointCollectionSequence>d__73).__il2cppRuntimeField_18 = eventProgressUI;
            typeof(AttackMadnessEventHandler.<PlayPointCollectionSequence>d__73).__il2cppRuntimeField_1C = startValue;
            typeof(AttackMadnessEventHandler.<PlayPointCollectionSequence>d__73).__il2cppRuntimeField_20 = points;
        }
        else
        {
                mem[20] = this;
            mem[28] = startValue;
            mem[32] = points;
            mem[16] = attackMadnessButton;
            mem[24] = eventProgressUI;
        }
        
        typeof(AttackMadnessEventHandler.<PlayPointCollectionSequence>d__73).__il2cppRuntimeField_28 = popup;
    }
    private System.Collections.IEnumerator RewardSequence(WGEventButtonV2_AttackMadness attackMadnessButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(AttackMadnessEventHandler.<RewardSequence>d__74).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(AttackMadnessEventHandler.<RewardSequence>d__74).__il2cppRuntimeField_10 = attackMadnessButton;
            typeof(AttackMadnessEventHandler.<RewardSequence>d__74).__il2cppRuntimeField_18 = this;
        }
        else
        {
                mem[24] = this;
            mem[16] = attackMadnessButton;
        }
        
        typeof(AttackMadnessEventHandler.<RewardSequence>d__74).__il2cppRuntimeField_14 = popup;
    }
    protected virtual void ShowRewardCollection(System.Action onCollectionClose)
    {
        GameBehavior val_1 = App.getBehavior;
        System.Action val_3 = new System.Action(object:  -1546343008, method:  new IntPtr(2748599152));
        InitReward(title:  -1549872784, reward:  -1546343008, source:  -1546367120, onCollectClicked:  null, onClose:  onCollectionClose);
        this.<NeedToShowProgress>k__BackingField = true;
    }
    public void ShowNewSymbolAnimation()
    {
        GameBehavior val_1 = App.getBehavior;
        Setup(type:  0, points:  this.PointsCollectedInLevel, initialPoints:  0, _onComplete:  0);
    }
    protected virtual void OnAttackCompleted(bool isSuccess)
    {
        AttackMadnessProgress val_9;
        int val_10;
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
        
        if(this.econ.pointsGainPerAttack < 1)
        {
                return;
        }
        
        if(this.progressData.pointsCollectedDuringGameLevel == 0)
        {
                System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_2 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            this.progressData.pointsCollectedDuringGameLevel = null;
        }
        
        GameplayMode val_3 = PlayingLevel.CurrentGameplayMode;
        GameplayMode val_5 = PlayingLevel.CurrentGameplayMode;
        EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Int32>(dic:  this.progressData.pointsCollectedDuringGameLevel, key:  0, newValue:  (EnumerableExtentions.GetOrDefault<System.Int32Enum, System.Int32>(dic:  this.progressData.pointsCollectedDuringGameLevel, key:  0, defaultValue:  0)) + this.econ.pointsGainPerAttack);
        val_9 = this.progressData;
        if(val_9 != 0)
        {
                val_10 = this.progressData.totalPointsCollected;
        }
        else
        {
                val_9 = 36;
            val_10 = 83886592;
        }
        
        mem[36] = val_10 + this.econ.pointsGainPerAttack;
        AttackMadnessEventHandler val_8 = this + this.econ.pointsGainPerAttack;
        this.UpdateProgressToServer();
    }
    protected virtual void UpdatePointsFlow(int ptsToAdd, int ptsMaxLimit, bool onlyAnimateProgressBar)
    {
        System.Action val_6;
        GameBehavior val_1 = App.getBehavior;
        val_6 = 0;
        SetHandler(handler:  -1545916896);
        SetProgressBarValue(pointsCollected:  this - ptsToAdd, pointsRequired:  ptsMaxLimit, animated:  false);
        if(ptsToAdd >= ptsMaxLimit)
        {
                this.suppressRewardCollectionPopup = true;
            val_6 = null;
            val_6 = new System.Action(object:  -1545916896, method:  new IntPtr(2749025376));
        }
        
        ShowPointGainAnimation(fromQty:  this - ptsToAdd, toQty:  -1545916896, maxQty:  ptsMaxLimit, onAnimationComplete:  val_6, onlyAnimateProgressBar:  onlyAnimateProgressBar, showBackground:  true, showBrownFlyout:  false);
    }
    protected virtual void OnCurrentRewardCollected()
    {
        int val_4;
        AttackMadnessProgress val_5;
        AttackMadnessProgress val_6;
        val_4 = 0;
        val_5 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_3;
        }
        
        val_5 = this.progressData;
        if(val_5 == 0)
        {
            goto label_6;
        }
        
        label_3:
        val_4 = this.progressData.rewardProgressLevel + 1;
        this.progressData.rewardProgressLevel = val_4;
        if(this.HasCollectedAllRewards() == true)
        {
                UnityEngine.Mathf.Max(a:  0, b:  0) = 0;
        }
        
        val_6 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_5;
        }
        
        val_6 = this.progressData;
        if(val_6 == 0)
        {
            goto label_6;
        }
        
        label_5:
        RESEventRewardData val_3 = this.econ.GetEventReward(playerTier:  this.progressData.playerTierAtEventStart, rewardProgressLevel:  this.progressData.rewardProgressLevel);
        this.progressData.currentRewardData = this.econ;
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
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921511651129632});
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
        AttackMadnessProgress val_15;
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
            if((System.Int32.TryParse(s:  null, result: out  int val_5 = -1545419400)) != false)
        {
                val_15 = this.progressData;
            this.progressData.playerTierAtEventStart = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -1548147264)) != false)
        {
                string val_8 = 0.Item[-1548147264];
            if((System.Int32.TryParse(s:  null, result: out  int val_9 = -1545419404)) != false)
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
        if((System.Int32.TryParse(s:  null, result: out  int val_13 = -1545419408)) == false)
        {
                return;
        }
    
    }
    private void SetupEvent()
    {
        if(true != 0)
        {
                true = 67108865;
            goto label_1;
        }
        
        label_16:
        if(this.IsEventExpired() != true)
        {
                if(this.IsCurrentEventInCycle() == true)
        {
            goto label_5;
        }
        
        }
        
        this.ResetEventProgress();
        label_5:
        if(this.IsEventExpired() == true)
        {
                return;
        }
        
        this.ParsePlayerProgressFromServer(eventDataDict:  typeof(AttackMadnessProgress).__il2cppRuntimeField_E0);
        this.progressData.eventId = R6 + 48;
        this.isEventInitialized = true;
        return;
        label_1:
        if((true.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_16;
        }
        
        string val_5 = mem[35632149].Item[-1554533760];
        if(mem[35632149] == 0)
        {
            goto label_16;
        }
        
        this.econ = new AttackMadnessEcon(eventDataDict:  mem[35632149] + 72);
        goto label_16;
    }
    private void ShowPopup(bool firstTime = False)
    {
        var val_6 = this;
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
        
        GameBehavior val_3 = App.getBehavior;
        mem2[0] = 1;
    }
    public void ResetEventProgress()
    {
        var val_3;
        this.progressData = new AttackMadnessProgress();
        var val_3 = 26286163;
        val_3 = 9339624 + val_3;
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
    public AttackMadnessEventHandler()
    {
        this.econ = new AttackMadnessEcon(eventDataDict:  0);
        this.progressData = new AttackMadnessProgress();
    }
    private void <ShowRewardCollection>b__75_0()
    {
        goto typeof(AttackMadnessEventHandler).__il2cppRuntimeField_424;
    }
    private void <UpdatePointsFlow>b__78_0()
    {
        this.suppressRewardCollectionPopup = false;
        goto typeof(AttackMadnessEventHandler).__il2cppRuntimeField_40C;
    }

}
