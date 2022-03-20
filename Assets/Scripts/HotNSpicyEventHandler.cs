using UnityEngine;
public class HotNSpicyEventHandler : WGEventHandler
{
    // Fields
    public const string HOTNSPICY_EVENT_ID = "HotNSpicy";
    public const string EVENT_TRACKING_ID = "Hot N Spicy";
    private HotNSpicyEcon econ;
    private HotNSpicyProgress progressData;
    private bool suppressRewardCollectionPopup;
    private bool isInitialized;
    private static HotNSpicyEventHandler <Instance>k__BackingField;
    
    // Properties
    public static bool IsEventActive { get; }
    public HotNSpicyEcon Econ { get; }
    public HotNSpicyProgress ProgressData { get; }
    public static HotNSpicyEventHandler Instance { get; set; }
    public int PlayerTier { get; set; }
    public int ProgressLevel { get; set; }
    public override int UnlockLevel { get; }
    public System.DateTime TimeExpire { get; }
    public override bool IsPointCollection { get; }
    public override int PointsCollected { get; set; }
    public override int PointsRequired { get; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static bool get_IsEventActive()
    {
        if((HotNSpicyEventHandler.<Instance>k__BackingField) == 0)
        {
                return false;
        }
        
        goto typeof(HotNSpicyEventHandler).__il2cppRuntimeField_274;
    }
    public HotNSpicyEcon get_Econ()
    {
    
    }
    public HotNSpicyProgress get_ProgressData()
    {
    
    }
    public static HotNSpicyEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(HotNSpicyEventHandler value)
    {
        HotNSpicyEventHandler.<Instance>k__BackingField = value;
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
        
        0 = 1152921511997605825;
        return (bool)0;
    }
    public override void PreInit(GameEventV2 eventV2)
    {
        this.econ = new HotNSpicyEcon(eventDataDict:  eventV2.eventData);
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_7 = 21167055;
        mem[1152921511997853384] = eventV2;
        val_7 = 14474768 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        HotNSpicyEventHandler.<Instance>k__BackingField = this;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1198928192, method:  new IntPtr(3096012032));
        AddAttackCompletedListener(listener:  7401472);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  -1198928192, method:  new IntPtr(3096013056));
        AddRaidCompletedListener(listener:  7401472);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Int32> val_6 = new System.Action<System.Int32>(object:  -1198928192, method:  new IntPtr(3096014080));
        AddEventIconCollectedListener(listener:  7401472);
        this.SetupEvent();
    }
    public override void Dispose()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1198812096, method:  new IntPtr(3096012032));
        RemoveAttackCompletedListener(listener:  7401472);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  -1198812096, method:  new IntPtr(3096013056));
        RemoveRaidCompletedListener(listener:  7401472);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Int32> val_6 = new System.Action<System.Int32>(object:  -1198812096, method:  new IntPtr(3096014080));
        RemoveEventIconCollectedListener(listener:  7401472);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        if((System.String.op_Inequality(a:  eventV2.type, b:  -1298907680)) != false)
        {
                return;
        }
        
        this.SetupEvent();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1198595616, defaultValue:  -1198595712, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1198595616, defaultValue:  -1198483504, useSingularKey:  false);
    }
    public bool HasCollectedAllRewards()
    {
        int val_4;
        var val_5;
        HotNSpicyProgress val_6;
        Player val_1 = App.Player;
        val_4 = this;
        val_5 = 0;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  -1198335120)) == false)
        {
                return true;
        }
        
        val_6 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_7;
        }
        
        val_6 = this.progressData;
        if(val_6 == 0)
        {
            goto label_8;
        }
        
        label_7:
        val_4 = this.progressData.rewardProgressLevel;
        if(val_4 >= (this.econ.GetTotalCollectableRewards(playerTier:  this.progressData.playerTierAtEventStart)))
        {
                val_5 = 1;
        }
        
        return true;
        label_8:
    }
    public override bool EventCompleted()
    {
        int val_4;
        var val_5;
        HotNSpicyProgress val_6;
        Player val_1 = App.Player;
        val_4 = this;
        val_5 = 1;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  -1198198544)) == false)
        {
                return true;
        }
        
        val_6 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_7;
        }
        
        val_6 = this.progressData;
        if(val_6 == 0)
        {
            goto label_8;
        }
        
        label_7:
        val_4 = this.progressData.rewardProgressLevel;
        if(val_4 >= (this.econ.GetTotalCollectableRewards(playerTier:  this.progressData.playerTierAtEventStart)))
        {
                val_5 = 1;
        }
        
        return true;
        label_8:
    }
    public override bool IsChallengeCompleted()
    {
        return this.HasCollectedAllRewards();
    }
    public override bool get_IsEventValid()
    {
        Player val_1 = App.Player;
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  -1197962256);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
    
    }
    public override void OnEventEnded()
    {
        this.progressData = new HotNSpicyProgress();
    }
    public override void OnMenuLoaded()
    {
    
    }
    public override void OnGameSceneBegan()
    {
    
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        if(this != 0)
        {
                return;
        }
        
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override void OnGameButtonPressed(bool connected)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void UpdateProgressToServer()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1548151456, value:  13152256);
        Add(key:  -1548147264, value:  13152256);
        Add(key:  -1548147152, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -1197152656, data:  78753792);
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        HotNSpicyRewardData val_1 = HotNSpicyEconDataHelper.ParseCSV();
        this.econ.rewardData = this;
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
    public override void OnAllReelsStopped()
    {
        int val_5;
        var val_6;
        HotNSpicyProgress val_7;
        int val_8;
        float val_9;
        float val_10;
        var val_12;
        val_5 = 14479180 + 21146607;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(App.game != 20)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = this.progressData;
        if(val_7 != 0)
        {
                val_8 = this.progressData.totalSpinResourceSpent;
        }
        else
        {
                val_7 = 36;
            val_8 = 83886592;
        }
        
        mem[36] = (val_8 + public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 8);
        val_5 = this.progressData.playerTierAtEventStart;
        if(val_5 == 3)
        {
            goto label_15;
        }
        
        if(val_5 == 2)
        {
            goto label_16;
        }
        
        if(val_5 != 1)
        {
            goto label_17;
        }
        
        val_9 = this.econ.avgPointPerSpinTier1;
        goto label_19;
        label_15:
        val_9 = this.econ.avgPointPerSpinTier3;
        goto label_19;
        label_16:
        val_9 = this.econ.avgPointPerSpinTier2;
        label_19:
        val_10 = mem[this.econ.avgPointPerSpinTier2];
        val_10 = val_9;
        goto label_20;
        label_17:
        val_10 = -1f;
        label_20:
        float val_3 = this.progressData.AveragePointPerSpin;
        if(this.progressData > 0)
        {
                if(this.progressData <= 0)
        {
            goto label_24;
        }
        
        }
        
        if((this.progressData > 0) || (this.progressData <= 0))
        {
            goto label_27;
        }
        
        val_12 = 3;
        goto label_30;
        label_24:
        val_12 = 4;
        label_30:
        RestaurantRivals.RESSpin.SwapSlotOutcomeResults(resultsId:  4);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RecalcSession();
        label_27:
        this.progressData.prevAvgPointPerSpin = this.progressData;
    }
    public override RESEventRewardData GetCurrentReward()
    {
        HotNSpicyProgress val_2;
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
    private void ShowRewardCollection()
    {
        var val_1;
        if(this.suppressRewardCollectionPopup == true)
        {
                return;
        }
        
        var val_1 = 21145551;
        val_1 = 14480236 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(App.game != 20)
        {
                return;
        }
        
        R4.ShowRewardCollection_RRV();
    }
    private void OnAttackCompleted(bool isSuccess)
    {
        var val_1;
        if(this != 0)
        {
                return;
        }
        
        if(isSuccess == true)
        {
                20 = 16;
        }
        
        var val_1 = 21144647;
        val_1 = 14481140 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(this.econ.pointsGainPerAttack < 1)
        {
                return;
        }
        
        if(App.game != 20)
        {
                return;
        }
        
        this.AddPointsCollected_RRV(ptsCollected:  this.econ.pointsGainPerAttack);
    }
    private void OnRaidCompleted(bool isRaidPerfect)
    {
        var val_1;
        if(this != 0)
        {
                return;
        }
        
        if(isRaidPerfect == true)
        {
                24 = 28;
        }
        
        var val_1 = 21143903;
        val_1 = 14481884 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(this.econ.pointsGainPerRaidPerfect < 1)
        {
                return;
        }
        
        if(App.game != 20)
        {
                return;
        }
        
        this.AddPointsCollected_RRV(ptsCollected:  this.econ.pointsGainPerRaidPerfect);
    }
    private void OnEventIconCollected(int amtCollected)
    {
        var val_1;
        if(this != 0)
        {
                return;
        }
        
        var val_1 = 21143631;
        val_1 = 14482156 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(amtCollected < 1)
        {
                return;
        }
        
        if(App.game != 20)
        {
                return;
        }
        
        this.AddPointsCollected_RRV(ptsCollected:  amtCollected);
    }
    private void AddPointsCollected_RRV(int ptsCollected)
    {
        HotNSpicyProgress val_6;
        int val_7;
        int val_6 = ptsCollected;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = SpinBet * val_6;
        val_6 = this.progressData;
        if(val_6 != 0)
        {
                val_7 = this.progressData.totalPointsCollected;
        }
        else
        {
                val_6 = 32;
            val_7 = 35615780;
        }
        
        mem[32] = val_7 + val_6;
        HotNSpicyEventHandler val_4 = this + val_6;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        IncrementInterruptCounterPostSpin1();
        this.UpdatePointsFlow_RRV(ptsToAdd:  val_6, ptsMaxLimit:  0, onlyAnimateProgressBar:  false);
        this.UpdateProgressToServer();
    }
    private void UpdatePointsFlow_RRV(int ptsToAdd, int ptsMaxLimit, bool onlyAnimateProgressBar)
    {
        var val_4;
        System.Action val_5;
        var val_6;
        val_4 = this;
        if(ptsToAdd < ptsMaxLimit)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance();
            val_5 = null;
            val_6 = 1152921511659091264;
        }
        else
        {
                this.suppressRewardCollectionPopup = true;
            val_5 = null;
            val_6 = 1152921512001344944;
        }
        
        val_5 = new System.Action(object:  -1195411600, method:  new IntPtr(3099530672));
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20.QueuePointGainAnimation(qty:  ptsToAdd, onAnimationComplete:  7454720, onlyAnimateProgressBar:  onlyAnimateProgressBar);
    }
    private void ShowRewardCollection_RRV()
    {
        var val_8;
        GameBehavior val_1 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_4 = new System.Action(object:  -1537803328, method:  new IntPtr(2757276992));
        val_8 = 0;
        System.Delegate val_5 = System.Delegate.Combine(a:  0, b:  7454720);
        if(val_8 != 0)
        {
                if(1179403647 == null)
        {
            goto label_9;
        }
        
        }
        
        val_8 = 0;
        label_9:
        mem[12] = val_8;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  -1195298448);
        System.Action val_7 = new System.Action(object:  -1195298448, method:  new IntPtr(3099643696));
        0.InitReward(_rewardDataList:  80883712, onCollectClicked:  7454720, source:  -1195322576);
    }
    private void OnCurrentRewardCollected()
    {
        var val_5;
        var val_6;
        HotNSpicyProgress val_7;
        HotNSpicyEcon val_8;
        var val_9;
        HotNSpicyProgress val_10;
        var val_11;
        val_5 = UnityEngine.Mathf.Max(a:  0, b:  0);
        val_6 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_3;
        }
        
        val_7 = this.progressData;
        if(val_7 == 0)
        {
            goto label_6;
        }
        
        label_3:
        int val_5 = this.progressData.rewardProgressLevel;
        val_5 = val_5 + 1;
        this.progressData.rewardProgressLevel = val_5;
        val_8 = this.econ;
        if(this.HasCollectedAllRewards() == true)
        {
                val_5 = 0;
        }
        
        val_9 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_5;
        }
        
        val_10 = this.progressData;
        if(val_10 == 0)
        {
            goto label_6;
        }
        
        label_5:
        RESEventRewardData val_3 = val_8.GetEventReward(playerTier:  this.progressData.playerTierAtEventStart, rewardProgressLevel:  this.progressData.rewardProgressLevel);
        this.progressData.currentRewardData = val_8;
        this.UpdateProgressToServer();
        if(this != 0)
        {
                return;
        }
        
        if(this.HasCollectedAllRewards() == true)
        {
                return;
        }
        
        if(this < this)
        {
                return;
        }
        
        val_8 = 14483160 + 21142627;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        if(App.game != 20)
        {
                return;
        }
        
        this.UpdatePointsFlow_RRV(ptsToAdd:  -1195165968, ptsMaxLimit:  -1195165968, onlyAnimateProgressBar:  true);
        return;
        label_6:
    }
    private bool IsEventExpired()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R7 + 40})) == false)
        {
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921512001748080});
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
        HotNSpicyProgress val_15;
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
            if((System.Int32.TryParse(s:  null, result: out  int val_5 = -1194801048)) != false)
        {
                val_15 = this.progressData;
            this.progressData.playerTierAtEventStart = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -1548147264)) != false)
        {
                string val_8 = 0.Item[-1548147264];
            if((System.Int32.TryParse(s:  null, result: out  int val_9 = -1194801052)) != false)
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
        if((System.Int32.TryParse(s:  null, result: out  int val_13 = -1194801056)) == false)
        {
                return;
        }
    
    }
    private void SetupEvent()
    {
        var val_10;
        if(true != 0)
        {
                true = 67108865;
            goto label_1;
        }
        
        label_32:
        if(this.IsEventExpired() != true)
        {
                if(this.IsCurrentEventInCycle() == true)
        {
            goto label_4;
        }
        
        }
        
        this.progressData = new HotNSpicyProgress();
        label_4:
        if(this.IsEventExpired() == true)
        {
                return;
        }
        
        this.ParsePlayerProgressFromServer(eventDataDict:  325099520);
        if(this.progressData.playerTierAtEventStart <= 0)
        {
                var val_10 = 21150243;
            val_10 = 14475544 + val_10;
            if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
            val_10 = null;
            val_10 = null;
            if(App.game == 20)
        {
                this.progressData.playerTierAtEventStart = RestaurantRivals.CommonEventEconDataHelper.GetPlayerTier();
        }
        
        }
        
        this.progressData.eventId = this.progressData;
        if(this == 0)
        {
                if(this >= this)
        {
                this = this;
            this.ShowRewardCollection();
        }
        
        }
        
        if(this.isInitialized != true)
        {
                RestaurantRivals.RESSpin.SwapSlotOutcomeResults(resultsId:  3);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RecalcSession();
        }
        
        this.isInitialized = true;
        return;
        label_1:
        if((true.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_32;
        }
        
        string val_8 = static_value_021FDA1F.Item[-1554533760];
        this.econ = new HotNSpicyEcon(eventDataDict:  static_value_021FDA1F + 72);
        goto label_32;
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
        
        Player val_1 = App.Player;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  R4)) == false)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        mem2[0] = 1;
    }
    public void ResetEventProgress()
    {
        this.progressData = new HotNSpicyProgress();
    }
    private string GetPlatformId()
    {
    
    }
    public override string GetHackPanelEventData()
    {
        var val_29;
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
        float val_19 = this.progressData.AveragePointPerSpin;
        string val_20 = System.String.Format(format:  -1544762736, arg0:  15282176);
        System.Text.StringBuilder val_21 = AppendLine(value:  -1544762736);
        val_29 = null;
        val_29 = null;
        string val_22 = System.String.Format(format:  -1544762624, arg0:  429871104);
        System.Text.StringBuilder val_23 = AppendLine(value:  -1544762624);
        string val_24 = System.String.Format(format:  -1544758384, arg0:  13152256);
        System.Text.StringBuilder val_25 = AppendLine(value:  -1544758384);
        string val_26 = System.String.Format(format:  -1544754160, arg0:  13152256);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_27 = AppendLine(value:  -1544754160);
            return;
        }
        
        System.Text.StringBuilder val_28 = AppendLine(value:  -1544754160);
    }
    public HotNSpicyEventHandler()
    {
        this.econ = new HotNSpicyEcon(eventDataDict:  0);
        this.progressData = new HotNSpicyProgress();
    }
    private void <UpdatePointsFlow_RRV>b__65_0()
    {
        this.suppressRewardCollectionPopup = false;
        this.ShowRewardCollection_RRV();
    }

}
