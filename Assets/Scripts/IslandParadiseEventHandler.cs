using UnityEngine;
public class IslandParadiseEventHandler : WGEventHandler
{
    // Fields
    public const string EVENT_ID = "IslandParadiseSymbol";
    public const string PURCHASE_ID_BASE = "id_keyPack";
    public const string KEY_TO_RICHES_EVENT_REWARD = "Key to Riches Event RESEventRewardData";
    public System.Action OnKeyBalanceChanged;
    private static IslandParadiseEventHandler _Instance;
    private IslandParadiseEventHandler.IslandParadiseProgress progressData;
    private bool isEventInitialized;
    private UnityEngine.GameObject eventButtonGO;
    private int <ProgressLabelPoints>k__BackingField;
    private int <PointsEarnedInLevel>k__BackingField;
    private bool <NeedToShowProgress>k__BackingField;
    
    // Properties
    public static bool IsEventActive { get; }
    public static IslandParadiseEventHandler Instance { get; }
    public GameEventV2 getEvent { get; }
    public UnityEngine.GameObject EventButtonGO { get; }
    public override int PointsCollected { get; set; }
    public override int PointsRequired { get; }
    public int ProgressLevel { get; set; }
    public int ProgressLabelPoints { get; set; }
    public int PointsEarnedInLevel { get; set; }
    public bool NeedToShowProgress { get; set; }
    public int ForestLevel { get; }
    public int UnlockForestLevel { get; }
    public override int UnlockLevel { get; }
    public virtual System.DateTime TimeExpire { get; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static bool get_IsEventActive()
    {
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return false;
        }
        
        goto typeof(IslandParadiseEventHandler).__il2cppRuntimeField_274;
    }
    public static IslandParadiseEventHandler get_Instance()
    {
    
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    public UnityEngine.GameObject get_EventButtonGO()
    {
    
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
        if(this == 0)
        {
                return 1;
        }
        
        if(this != 0)
        {
                return (int)this;
        }
        
        return (int)this;
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
        if(this.progressData == 0)
        {
            
        }
    
    }
    public int get_ProgressLabelPoints()
    {
        return (int)this.<ProgressLabelPoints>k__BackingField;
    }
    public void set_ProgressLabelPoints(int value)
    {
        this.<ProgressLabelPoints>k__BackingField = value;
    }
    public int get_PointsEarnedInLevel()
    {
        return (int)this.<PointsEarnedInLevel>k__BackingField;
    }
    public void set_PointsEarnedInLevel(int value)
    {
        this.<PointsEarnedInLevel>k__BackingField = value;
    }
    public bool get_NeedToShowProgress()
    {
        return (bool)this.<NeedToShowProgress>k__BackingField;
    }
    public void set_NeedToShowProgress(bool value)
    {
        this.<NeedToShowProgress>k__BackingField = value;
    }
    public int get_ForestLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public int get_UnlockForestLevel()
    {
        null = null;
        return (int)IslandParadiseEventHandler.Econ.unlockForestLevel;
    }
    public override int get_UnlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 983057;
        }
        
        return 983057;
    }
    public virtual System.DateTime get_TimeExpire()
    {
        this = R1 + 8 + 40;
        return new System.DateTime() {dateData = R1 + 8 + 40};
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921511819398168] = eventV2;
        IslandParadiseEventHandler._Instance = this;
        this.SetupEvent();
    }
    public override bool ShowEventUI(EventButtonPanel.LayoutType layoutType, EventButtonPanel.DisplayContext context)
    {
        if(this != 0)
        {
                return (bool)0;
        }
        
        if(layoutType != 1)
        {
                return true;
        }
        
        if(context == 3)
        {
                return (bool)0;
        }
        
        if(context == 5)
        {
                this = this.<ProgressLabelPoints>k__BackingField;
        }
        
        if(this != 0)
        {
                0 = 1;
        }
        
        return (bool)0;
    }
    public override bool ActivelyPlayingGameMode()
    {
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = 0;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = PlayingChallenge;
        }
        
        if(this.EventUnlocked() == false)
        {
                return false;
        }
        
        if(this.IsCurrentEventInCycle() == false)
        {
                return false;
        }
        
        IslandParadiseEventHandler val_8 = 1152921511819642641;
        val_8 = val_8 ^ 1 & val_8;
        return (bool)val_8;
    }
    public bool EventUnlocked()
    {
        var val_4 = null;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  this.ForestLevel, knobValue:  IslandParadiseEventHandler.Econ.unlockForestLevel)) == false)
        {
                return false;
        }
        
        Player val_3 = App.Player;
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  -1377026928);
    }
    public override bool EventCompleted()
    {
        if(this.EventUnlocked() == false)
        {
                return true;
        }
        
        if(this.IsEventExpired() == false)
        {
                return this.HasCollectedAllRewards();
        }
        
        return true;
    }
    public bool HasCollectedAllRewards()
    {
        var val_2;
        var val_3;
        val_2 = 0;
        if(this.EventUnlocked() == false)
        {
                return true;
        }
        
        val_3 = null;
        val_3 = null;
        if(this.progressData.rewardProgressLevel >= (IslandParadiseEventHandler.Econ.rewards + 12))
        {
                val_2 = 1;
        }
        
        return true;
    }
    public override bool get_IsEventValid()
    {
        return this.EventUnlocked();
    }
    public override RESEventRewardData GetCurrentReward()
    {
        var val_9;
        RESEventRewardData val_1 = IslandParadiseEventHandler.Econ.GetCurrentRewardData(progress:  this.progressData.rewardProgressLevel);
        if(this.progressData.rewardProgressLevel == 0)
        {
                return;
        }
        
        if((this.progressData.rewardProgressLevel + 8) != 3)
        {
                return;
        }
        
        if(((this.progressData.rewardProgressLevel + 32) != 0) && ((this.progressData.rewardProgressLevel + 32.ContainsKey(key:  -1376590640)) != false))
        {
                string val_3 = this.progressData.rewardProgressLevel + 32.Item[-1376590640];
            this.progressData.rewardProgressLevel + 32.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_9 = mem[this.progressData.rewardProgressLevel + 32];
            val_9 = this.progressData.rewardProgressLevel + 32;
        }
        else
        {
                val_9 = 0;
            string val_4 = -1376586464(-1376586464) + 13152256;
            UnityEngine.Debug.LogWarning(message:  -1376586464);
        }
        
        int val_6 = IslandParadiseEventHandler.Econ.GetAcornTierReward(level:  ForestLevel, tier:  0);
        decimal val_7 = System.Decimal.op_Implicit(value:  -1376574192);
        int val_8 = this.progressData.rewardProgressLevel + 16;
    }
    public override bool IsRewardReadyToCollect()
    {
        if(this == 0)
        {
                return false;
        }
        
        if(this >= typeof(IslandParadiseEventHandler).__il2cppRuntimeField_3D8)
        {
                0 = 1;
        }
        
        return true;
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
        this.<ProgressLabelPoints>k__BackingField = 0;
        this.<PointsEarnedInLevel>k__BackingField = 0;
    }
    public override void OnGameSceneBegan()
    {
        this.ShowPopup(firstTime:  true);
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        this.ApplyPointsEarnedInLevel();
    }
    public override void OnNewForestShown()
    {
        this.ShowPopup(firstTime:  true);
    }
    public override void OnMysteryChestCollected()
    {
        if((this.<PointsEarnedInLevel>k__BackingField) < 1)
        {
                return;
        }
        
        this.ShowNewSymbolAnimation();
    }
    public override string GetEventDisplayName()
    {
    
    }
    public override string GetMainMenuButtonText()
    {
        if(this.progressData.rewardProgressLevel == 0)
        {
                if(this == 0)
        {
                return;
        }
        
        }
        
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    public override string GetGameButtonText()
    {
        string val_1 = this.<ProgressLabelPoints>k__BackingField.ToString();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        TheLibraryMainScreen val_2 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        loader.SetupSlider(hasCollectedAllRewards:  this.HasCollectedAllRewards(), sliderText:  1629069648, sliderValue:  2919882768, currentReward:  1f);
    }
    public int GetTotalCollectableRewards()
    {
        var val_1;
        System.Collections.Generic.List<RESEventRewardData> val_2;
        val_1 = null;
        val_1 = null;
        val_2 = IslandParadiseEventHandler.Econ.rewards;
        if(val_2 == 0)
        {
                return 0;
        }
        
        val_2 = IslandParadiseEventHandler.Econ.rewards;
        if(val_2 != 0)
        {
                return (int)IslandParadiseEventHandler.Econ.rewards + 12;
        }
    
    }
    public void RewardPointsFromSymbols(int symbolAmount)
    {
        int val_1 = this.GetPointsFromSymbols(symbolAmount:  symbolAmount);
        val_1 = (this.<PointsEarnedInLevel>k__BackingField) + val_1;
        this.<PointsEarnedInLevel>k__BackingField = val_1;
        this.UpdateProgressToServer();
    }
    public void ApplyPointsEarnedInLevel()
    {
        int val_1 = (this.<PointsEarnedInLevel>k__BackingField) + this;
        this.UpdateProgressToServer();
    }
    public int GetPointsFromSymbols(int symbolAmount)
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        if(symbolAmount == 3)
        {
            goto label_1;
        }
        
        if(symbolAmount == 2)
        {
            goto label_2;
        }
        
        val_1 = 0;
        if(symbolAmount != 1)
        {
                return (int)val_3;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = 1152921504925007876;
        return (int)val_3;
        label_1:
        val_4 = null;
        val_4 = null;
        val_3 = 1152921504925007884;
        return (int)val_3;
        label_2:
        val_5 = null;
        val_5 = null;
        val_3 = 1152921504925007880;
        return (int)val_3;
    }
    public void ProcessRewardCollected()
    {
        if(this == 0)
        {
                return;
        }
        
        var val_1 = R4 - R4;
        R4.ProgressLevel = (R4 + 20 + 16) + 1;
        R4.UpdateProgressToServer();
    }
    public void UpdateProgressToServer()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1548147264, value:  13152256);
        Add(key:  -1548147152, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -1374404336, data:  78753792);
    }
    public void ShowNewSymbolAnimation()
    {
        GameBehavior val_1 = App.getBehavior;
        System.Action val_3 = new System.Action(object:  -1374286192, method:  new IntPtr(2920656080));
        0.Setup(type:  2, points:  this.<PointsEarnedInLevel>k__BackingField, initialPoints:  this.<ProgressLabelPoints>k__BackingField, _onComplete:  null);
    }
    public void OnPointGainComplete()
    {
        int val_1 = this.<ProgressLabelPoints>k__BackingField;
        val_1 = (this.<PointsEarnedInLevel>k__BackingField) + val_1;
        this.<ProgressLabelPoints>k__BackingField = val_1;
    }
    public void ShowPopup(bool firstTime = False)
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = this;
        val_10 = 35636401;
        if(firstTime != false)
        {
                if(this.progressData.hasSeenPopup == true)
        {
                return;
        }
        
        }
        
        if(R4.EventUnlocked() == false)
        {
                return;
        }
        
        val_10 = 1152921504901095424;
        val_11 = 1152921511021137168;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) != 0)
        {
                GameBehavior val_4 = App.getBehavior;
            if(0 != 0)
        {
            goto label_14;
        }
        
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        label_14:
        mem2[0] = 1;
    }
    public void ShowRewardCollection()
    {
        GameBehavior val_1 = App.getBehavior;
        System.Action val_3 = new System.Action(object:  -1373936768, method:  new IntPtr(2921004368));
        System.Action val_4 = new System.Action(object:  -1373936768, method:  new IntPtr(2921005392));
        0.InitReward(title:  -1375457952, reward:  -1373936768, source:  -1373960880, onCollectClicked:  null, onClose:  null);
        this.<NeedToShowProgress>k__BackingField = true;
    }
    public override System.Collections.IEnumerator DoLevelCompleteEventProgressAnimation(WGEventButtonV2 eventButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(IslandParadiseEventHandler.<DoLevelCompleteEventProgressAnimation>d__79).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
            
        }
        else
        {
                mem[20] = this;
            mem[16] = eventButton;
            mem[24] = eventProgressUI;
        }
        
        typeof(IslandParadiseEventHandler.<DoLevelCompleteEventProgressAnimation>d__79).__il2cppRuntimeField_1C = popup;
    }
    private System.Collections.IEnumerator PlayPointCollectionSequence(int startValue, int points, WGEventButtonV2_IslandParadise islandParadiseButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(IslandParadiseEventHandler.<PlayPointCollectionSequence>d__80).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(IslandParadiseEventHandler.<PlayPointCollectionSequence>d__80).__il2cppRuntimeField_10 = islandParadiseButton;
            typeof(IslandParadiseEventHandler.<PlayPointCollectionSequence>d__80).__il2cppRuntimeField_14 = this;
            typeof(IslandParadiseEventHandler.<PlayPointCollectionSequence>d__80).__il2cppRuntimeField_18 = eventProgressUI;
            typeof(IslandParadiseEventHandler.<PlayPointCollectionSequence>d__80).__il2cppRuntimeField_1C = startValue;
            typeof(IslandParadiseEventHandler.<PlayPointCollectionSequence>d__80).__il2cppRuntimeField_20 = points;
        }
        else
        {
                mem[20] = this;
            mem[28] = startValue;
            mem[32] = points;
            mem[16] = islandParadiseButton;
            mem[24] = eventProgressUI;
        }
        
        typeof(IslandParadiseEventHandler.<PlayPointCollectionSequence>d__80).__il2cppRuntimeField_28 = popup;
    }
    private System.Collections.IEnumerator RewardSequence(WGEventButtonV2_IslandParadise islandParadiseButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(IslandParadiseEventHandler.<RewardSequence>d__81).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(IslandParadiseEventHandler.<RewardSequence>d__81).__il2cppRuntimeField_10 = this;
            typeof(IslandParadiseEventHandler.<RewardSequence>d__81).__il2cppRuntimeField_14 = islandParadiseButton;
        }
        else
        {
                mem[16] = this;
            mem[20] = islandParadiseButton;
        }
        
        typeof(IslandParadiseEventHandler.<RewardSequence>d__81).__il2cppRuntimeField_18 = popup;
    }
    private void SetupEvent()
    {
        if(this.IsEventExpired() != true)
        {
                if(this.IsCurrentEventInCycle() == true)
        {
            goto label_4;
        }
        
        }
        
        this.progressData = new EventProgression();
        this.UpdateProgressToServer();
        label_4:
        bool val_4 = this.IsEventExpired();
        if(val_4 == true)
        {
                return;
        }
        
        val_4.ParseEventEcon(eventData:  318230528);
        this.ParsePlayerProgressFromServer(eventData:  318230528);
        this.progressData.eventId = R6 + 48;
        if((this.HasCollectedAllRewards() != true) && (this >= this))
        {
                this.ShowPopup(firstTime:  false);
        }
        
        this.isEventInitialized = true;
    }
    private void ParseEventEcon(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        var val_13;
        float val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        if(eventData == 0)
        {
                return;
        }
        
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        val_13 = 1152921510385703632;
        object val_2 = eventData.Item[-1554533760];
        val_14 = 1152921504685600768;
        val_15 = 0;
        val_16 = 1;
        if((val_15.ContainsKey(key:  -1554533504)) != false)
        {
                string val_4 = val_15.Item[-1554533504];
            val_17 = val_15;
            val_18 = null;
            val_18 = null;
            val_20 = null;
            val_17.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            IslandParadiseEventHandler.Econ.unlockForestLevel = 1179403647;
            val_13 = 1152921510385703632;
        }
        
        if((val_15.ContainsKey(key:  -1554533664)) == false)
        {
                return;
        }
        
        string val_6 = val_15.Item[-1554533664];
        val_15 = 0;
        val_19 = 1;
        if((val_15.ContainsKey(key:  -1373290176)) != false)
        {
                val_14 = val_13;
            string val_8 = val_15.Item[-1373290176];
            val_17 = val_15;
            val_21 = null;
            val_21 = null;
            val_20 = null;
            val_17.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_13 = val_14;
            IslandParadiseEventHandler.Econ.points1Symbol = 1179403647;
        }
        
        if((val_15.ContainsKey(key:  -1373290096)) != false)
        {
                val_14 = val_13;
            string val_10 = val_15.Item[-1373290096];
            val_17 = val_15;
            val_22 = null;
            val_22 = null;
            val_20 = null;
            val_17.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_13 = val_14;
            IslandParadiseEventHandler.Econ.points2Symbol = 1179403647;
        }
        
        if((val_15.ContainsKey(key:  -1373290016)) == false)
        {
                return;
        }
        
        string val_12 = val_15.Item[-1373290016];
        val_15 = val_15;
        val_23 = null;
        val_23 = null;
        val_17 = null;
        val_15.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        IslandParadiseEventHandler.Econ.points3Symbol = 1179403647;
    }
    private void ParsePlayerProgressFromServer(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        if(eventData == 0)
        {
                return;
        }
        
        if((eventData.ContainsKey(key:  -1545439648)) == false)
        {
                return;
        }
        
        object val_2 = eventData.Item[-1545439648];
        if((0.ContainsKey(key:  -1548147264)) != false)
        {
                string val_4 = 0.Item[-1548147264];
            if((System.Int32.TryParse(s:  null, result: out  int val_5 = -1373157780)) != false)
        {
                this.ProgressLevel = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -1548147152)) == false)
        {
                return;
        }
        
        string val_8 = 0.Item[-1548147152];
        if((System.Int32.TryParse(s:  null, result: out  int val_9 = -1373157784)) == false)
        {
                return;
        }
    
    }
    private bool IsEventExpired()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R7 + 40})) == false)
        {
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = this.<ProgressLabelPoints>k__BackingField});
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
    public void HackProgressLevel(int progress)
    {
        this.ProgressLevel = UnityEngine.Mathf.Max(a:  0, b:  progress);
        this.UpdateProgressToServer();
    }
    public void HackPointsCollected(int points)
    {
        int val_1 = UnityEngine.Mathf.Max(a:  0, b:  points);
        this.UpdateProgressToServer();
    }
    public void ResetEventProgress()
    {
        this.ProgressLevel = 0;
        this.UpdateProgressToServer();
    }
    public IslandParadiseEventHandler()
    {
        this.progressData = new EventProgression();
    }
    private void <ShowRewardCollection>b__78_0()
    {
        this.ProcessRewardCollected();
    }
    private void <ShowRewardCollection>b__78_1()
    {
        this.ShowPopup(firstTime:  false);
    }

}
