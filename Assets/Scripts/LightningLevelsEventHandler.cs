using UnityEngine;
public class LightningLevelsEventHandler : WGEventHandler
{
    // Fields
    public const string LIGHTNING_LEVELS_EVENT_ID = "LightningLevels";
    private static LightningLevelsEventHandler <Instance>k__BackingField;
    private int <CacheOverallEventProgress>k__BackingField;
    public LightningLevelsEcon Econ;
    protected LightningLevelsEventPrgress eventProgress;
    protected LightningLevelsLevelProgress levelProgress;
    private SceneType previousScene;
    private bool isLevelClearSuccessful;
    
    // Properties
    public static LightningLevelsEventHandler Instance { get; set; }
    public override int PointsCollected { get; }
    public override int PointsRequired { get; }
    public int CacheOverallEventProgress { get; set; }
    protected virtual LightingEventProgress EventProgress { get; }
    protected virtual LightningLevelProgress LevelProgress { get; }
    
    // Methods
    public static LightningLevelsEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(LightningLevelsEventHandler value)
    {
        LightningLevelsEventHandler.<Instance>k__BackingField = value;
    }
    public override int get_PointsCollected()
    {
        if(this.eventProgress != 0)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    public override int get_PointsRequired()
    {
        if(this.Econ != 0)
        {
                return (int)this.Econ.RequiredLevels;
        }
        
        return (int)this.Econ.RequiredLevels;
    }
    public int get_CacheOverallEventProgress()
    {
        return (int)this.<CacheOverallEventProgress>k__BackingField;
    }
    protected void set_CacheOverallEventProgress(int value)
    {
        this.<CacheOverallEventProgress>k__BackingField = value;
    }
    protected virtual LightingEventProgress get_EventProgress()
    {
    
    }
    protected virtual LightningLevelProgress get_LevelProgress()
    {
    
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_4;
        var val_4 = 23718483;
        val_4 = 11918828 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        LightningLevelsEventHandler.<Instance>k__BackingField = this;
        mem[1152921512010770920] = eventV2;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1186010656, method:  new IntPtr(3108923424));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_7;
        }
        
        }
        
        val_4 = 0;
        label_7:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
        this.<CacheOverallEventProgress>k__BackingField = this;
    }
    private void OnSceneLoaded(SceneType sType)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                this.previousScene = sType;
        }
    
    }
    public override bool ShowEventUI(EventButtonPanel.LayoutType layoutType, EventButtonPanel.DisplayContext context)
    {
        var val_4;
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        val_5 = 0;
        if(PlayingChallenge == true)
        {
                return (bool)R6;
        }
        
        if(context == 5)
        {
                if(this.isLevelClearSuccessful == true)
        {
                val_5 = 1;
        }
        
            return (bool)R6;
        }
        
        val_5 = 1;
        if(this != 0)
        {
                return (bool)R6;
        }
        
        val_5 = 0;
        if(this < 1)
        {
                return (bool)R6;
        }
        
        goto typeof(LightningLevelsEventHandler).__il2cppRuntimeField_454;
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        if(this != 0)
        {
                return;
        }
        
        if(this >= 0)
        {
            goto R4 + 1116;
        }
    
    }
    public override void OnEventEnded()
    {
        LightningLevelsEventHandler.<Instance>k__BackingField = 0;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public override void OnGameSceneInit()
    {
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(this.InExpireInterval() == true)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        if(this >= 0)
        {
                return;
        }
        
        if((this >= 1) && (this != 0))
        {
            
        }
        else
        {
                if(this == 0)
        {
                return;
        }
        
            if(CategoryPacksManager.IsPlaying == true)
        {
                1 = 4;
        }
        
            mem2[0] = 4;
            val_8 = 0;
            if(CategoryPacksManager.IsPlaying != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = mem[public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8];
            val_8 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8;
        }
        
            mem2[0] = val_8;
            mem2[0] = 1;
        }
    
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        LightningLevelsEventPrgress val_3;
        int val_4;
        LightningLevelsEventPrgress val_5;
        var val_6;
        LightningLevelsEventPrgress val_7;
        val_3 = this.eventProgress;
        if(val_3 != 0)
        {
                val_4 = this.eventProgress.CurrentInterval;
        }
        else
        {
                val_3 = 28;
            val_4 = 52;
        }
        
        mem[28] = 53;
        if(this != 0)
        {
                val_5 = this.eventProgress;
            if(val_5 != 0)
        {
            
        }
        else
        {
                val_5 = 12;
            val_6 = 0;
        }
        
            mem[12] = 1;
            this.isLevelClearSuccessful = true;
            mem2[0] = 0;
            val_4 = this.levelProgress;
            mem2[0] = 0;
        }
        
        if(this.InExpireInterval() == true)
        {
                return;
        }
        
        val_7 = this.eventProgress;
        if(this.eventProgress != 0)
        {
            goto label_9;
        }
        
        val_7 = this.eventProgress;
        if(val_7 == 0)
        {
            goto label_10;
        }
        
        label_9:
        if(this.eventProgress.CurrentInterval != this.eventProgress.DefinedInterval)
        {
                return;
        }
        
        mem2[0] = 0;
        goto typeof(LightningLevelsEventHandler).__il2cppRuntimeField_44C;
        label_10:
    }
    protected virtual void ExecuteLevelCompleteSuccessAction()
    {
        if()
        {
                return;
        }
        
        goto R4 + 1116;
    }
    public override bool EventCompleted()
    {
        if(this.eventProgress != 0)
        {
                return (bool)this;
        }
        
        return (bool)this;
    }
    public override bool IsChallengeCompleted()
    {
        goto typeof(LightningLevelsEventHandler).__il2cppRuntimeField_29C;
    }
    public override void MarkEventRewarded()
    {
        var val_9 = this;
        if(this.Econ.RewardType != 1)
        {
            goto label_2;
        }
        
        label_28:
        mem2[0] = 1;
        if(this.eventProgress != 0)
        {
            goto typeof(LightningLevelsEventHandler).__il2cppRuntimeField_17C;
        }
        
        goto typeof(LightningLevelsEventHandler).__il2cppRuntimeField_17C;
        label_2:
        if((R4 + 20 + 12) != 3)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = GetWindow<System.Object>();
        if((2119322896 == 0) || (enabled == false))
        {
            goto label_28;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_10 = 0;
        goto label_28;
        label_6:
        if((R4 + 20 + 12) != 4)
        {
            goto label_28;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_6 = GetWindow<System.Object>();
        if((2119322896 == 0) || (enabled == false))
        {
            goto label_28;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_44 = 0;
        goto label_28;
    }
    public override int LastProgressTimestamp()
    {
        if(this.eventProgress != 0)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    public override void UpdateProgress()
    {
        mem2[0] = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override bool IsRewardReadyToCollect()
    {
        if()
        {
                return (bool)0;
        }
        
        0 = 0;
        return (bool)0;
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_1;
        if(this != 0)
        {
                return;
        }
        
        var val_1 = 23702755;
        val_1 = 11923036 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 73;
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_1;
        if(this != 0)
        {
                return;
        }
        
        var val_1 = 23702495;
        val_1 = 11923296 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 74;
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = System.String.Format(format:  -1183992800, arg0:  -1183992672, arg1:  -1183968592, arg2:  -1183968592);
    }
    public override string GetGameButtonText()
    {
        goto typeof(LightningLevelsEventHandler).__il2cppRuntimeField_424;
    }
    public override string GetEventDisplayName()
    {
        goto typeof(LightningLevelsEventHandler).__il2cppRuntimeField_4AC;
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader == 0)
        {
            
        }
    
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        currentData.Add(key:  -1183531360, value:  8945664);
    }
    public override System.Collections.IEnumerator DoLevelCompleteEventProgressAnimation(WGEventButtonV2 eventButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(LightningLevelsEventHandler.<DoLevelCompleteEventProgressAnimation>d__43).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(LightningLevelsEventHandler.<DoLevelCompleteEventProgressAnimation>d__43).__il2cppRuntimeField_14 = this;
            typeof(LightningLevelsEventHandler.<DoLevelCompleteEventProgressAnimation>d__43).__il2cppRuntimeField_18 = eventButton;
        }
        else
        {
                mem[20] = this;
            mem[24] = eventButton;
        }
        
        typeof(LightningLevelsEventHandler.<DoLevelCompleteEventProgressAnimation>d__43).__il2cppRuntimeField_10 = eventProgressUI;
    }
    public bool IsLightningStrikenLevel()
    {
        if(this.levelProgress == 0)
        {
                this.levelProgress = 0;
            return (bool)this.levelProgress;
        }
        
        if(36 != 0)
        {
                36 = 1;
        }
        
        return true;
    }
    public virtual string GetLightningEventProgress(bool spaced = False)
    {
        if(spaced == true)
        {
                "/" = " / ";
        }
        
        string val_1 = System.String.Format(format:  -1183154368, arg0:  13152256, arg1:  -1316508080, arg2:  13152256);
    }
    public virtual float GetEventProgressValue()
    {
        float val_1 = (float)this.Econ.RequiredLevels;
        val_1 = (-1.182998E+09f) / val_1;
        return (float)val_1;
    }
    public virtual System.TimeSpan GetLightningElapsed()
    {
        System.DateTime val_1 = DateTimeCheat.Now;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512013903968}, d2:  new System.DateTime() {dateData = R1 + 28 + 24});
        return new System.TimeSpan() {_ticks = val_4._ticks};
    }
    public virtual void PauseTimer()
    {
        double val_1 = ???.TotalSeconds;
        if(this.levelProgress == 0)
        {
                3112197864 = 3112197864;
        }
        
        var val_2 = S0;
        val_2 = val_2 + 1;
        mem2[0] = val_2;
        if(this.levelProgress != 0)
        {
                return;
        }
    
    }
    public virtual void ResumeTimer()
    {
        var val_6;
        System.DateTime val_1 = DateTimeCheat.Now;
        System.DateTime val_4 = AddSeconds(value:  null);
        mem2[0] = val_6;
    }
    public virtual void ResetTimer()
    {
        mem2[0] = 0;
        if(this.levelProgress == 0)
        {
            
        }
    
    }
    public virtual bool IsPlayingLightningLevel()
    {
        LightningLevelsLevelProgress val_5;
        var val_6;
        if(true == 0)
        {
                return false;
        }
        
        bool val_1 = CategoryPacksManager.IsPlaying;
        val_5 = this.levelProgress;
        if(val_1 == true)
        {
                1 = 4;
        }
        
        if(val_1 == true)
        {
                val_6 = val_1 - 4;
            return (bool)((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance() - public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28) >> 5;
        }
        
        val_5 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return (bool)((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance() - public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28) >> 5;
    }
    public virtual void ShowLightningPopup()
    {
        var val_8;
        var val_9;
        val_8 = 1152921504901095424;
        val_9 = 1152921511021137168;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) != 0)
        {
                GameBehavior val_3 = App.getBehavior;
            if(0 != 0)
        {
            goto (1179403647 + (public WGLightningLevelsPopup MetaGameBehavior::ShowUGUIFlyOut<WGLightningLevelsPopup>().__il2cppRuntimeField_28) << 3) + 192;
        }
        
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = R6.ShowUGUIMonolith<System.Object>(showNext:  false);
        }
    
    }
    public virtual void ShowLightningProgressInGamePopup()
    {
        GameBehavior val_1 = App.getBehavior;
        0.SetUp(handler:  -1182121632, onCLoseCallback:  0);
    }
    public bool IsLightningPeriod()
    {
        goto typeof(LightningLevelsEventHandler).__il2cppRuntimeField_46C;
    }
    public string GetEventRemainingTime()
    {
        var val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512014875984}, d2:  new System.DateTime() {dateData = this.previousScene});
        int val_8 = UnityEngine.Mathf.Max(a:  val_5.Days, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_10 = UnityEngine.Mathf.Max(a:  val_5.Hours, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_12 = UnityEngine.Mathf.Max(a:  val_5.Minutes, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_14 = UnityEngine.Mathf.Max(a:  val_5.Seconds, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_15 = System.String.Format(format:  -1515309312, args:  472754880);
    }
    public void ShowInternetRequiredPopup()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_6 = null;
        val_6 = null;
        0.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    public bool HasValidQueuedWindows()
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if(HasQueuedWindows() == false)
        {
                return (bool)val_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = GetWindow<System.Object>();
        val_6 = isActiveAndEnabled ^ 1;
        return (bool)val_6;
    }
    public bool InExpireInterval()
    {
        ulong val_4;
        var val_11;
        ulong val_12;
        var val_14;
        val_11 = R6;
        if(R6 == 0)
        {
                if(val_11 == 0)
        {
            goto label_2;
        }
        
        }
        
        val_12 = mem[R6 + 40];
        val_12 = R6 + 40;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = R6 + 32}, d2:  new System.DateTime() {dateData = val_12})) != false)
        {
                System.DateTime val_3 = DateTimeCheat.UtcNow;
            bool val_6 = System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = this.previousScene});
        }
        else
        {
                System.DateTime val_7 = DateTimeCheat.UtcNow;
            val_12 = mem[R6 + 44 + 32];
            val_12 = R6 + 44 + 32;
            val_14 = 0;
            if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = val_12})) == false)
        {
                return (bool)val_14;
        }
        
            System.DateTime val_9 = DateTimeCheat.UtcNow;
        }
        
        val_14 = System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = 1152921512015233248});
        return (bool)val_14;
        label_2:
    }
    protected virtual bool IsLightningValidAndSuccess()
    {
        var val_3 = 0;
        bool val_1 = this.InExpireInterval();
        if(val_1 == true)
        {
                return (bool)val_3;
        }
        
        val_3 = 0;
        double val_2 = ???.TotalSeconds;
        if(val_1 < false)
        {
                return (bool)val_3;
        }
        
        val_3 = this;
        return (bool)val_3;
    }
    protected virtual void StartTimer()
    {
        var val_8;
        int val_9 = this.Econ.SecondsPerWord;
        WordRegion val_1 = WordRegion.instance;
        val_9 = 0 * val_9;
        mem2[0] = val_9;
        System.DateTime val_2 = DateTimeCheat.Now;
        int val_3 = val_9 + 1;
        System.DateTime val_6 = AddSeconds(value:  null);
        mem2[0] = val_8;
        if(this.levelProgress != 0)
        {
                return;
        }
    
    }
    protected virtual void ShowLightningUI()
    {
        var val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this.eventProgress != 0)
        {
                val_3 = 1;
        }
        
        if((public static LightningLevelsUIController MonoSingleton<LightningLevelsUIController>::get_Instance()) == 0)
        {
                return;
        }
        
        mem2[0] = 0;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    protected virtual bool IsReady()
    {
        LightningLevelsEventPrgress val_1;
        var val_2;
        if(this.eventProgress.CurrentInterval == 1)
        {
                return true;
        }
        
        val_1 = this.eventProgress;
        if(this.eventProgress != 0)
        {
            goto label_2;
        }
        
        val_1 = this.eventProgress;
        if(val_1 == 0)
        {
            goto label_3;
        }
        
        label_2:
        val_2 = 0;
        if(this.eventProgress.CurrentInterval != this.eventProgress.DefinedInterval)
        {
                return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
        label_3:
    }
    protected virtual void ResetInterval()
    {
        LightningLevelsEcon val_2;
        this.eventProgress.CurrentInterval = 0;
        val_2 = this.Econ;
        if(this.Econ != 0)
        {
            goto label_1;
        }
        
        val_2 = this.Econ;
        if(val_2 == 0)
        {
            goto label_2;
        }
        
        label_1:
        int val_2 = this.Econ.IntervalMax;
        val_2 = val_2 + 1;
        int val_1 = UnityEngine.Random.Range(min:  this.Econ.IntervalMin, max:  val_2);
        val_1 = val_1 + 1;
        this.eventProgress.DefinedInterval = val_1;
        if(this.eventProgress != 0)
        {
            goto typeof(LightningLevelsEventPrgress).__il2cppRuntimeField_E4;
        }
        
        goto typeof(LightningLevelsEventPrgress).__il2cppRuntimeField_E4;
        label_2:
    }
    protected virtual void RefreshEventData(System.Collections.Generic.Dictionary<string, object> data)
    {
        LightningLevelsEcon val_8;
        LightningLevelsEventPrgress val_9;
        LightningLevelsEventPrgress val_10;
        if((System.String.op_Inequality(a:  mem[35637335], b:  -1266462304)) != false)
        {
                string val_2 = -1322383584(-1322383584) + -1266462304(-1266462304);
            UnityEngine.Debug.LogError(message:  -1322383584);
            return;
        }
        
        if(this != 0)
        {
                val_8 = this;
            val_9 = this.eventProgress;
            val_10 = mem[R7 + 8];
            val_10 = R7 + 8;
            mem2[0] = val_10;
        }
        else
        {
                if((data.ContainsKey(key:  -1472372400)) != false)
        {
                object val_4 = data.Item[-1472372400];
            string val_5 = data.ToString();
            bool val_6 = System.Boolean.Parse(value:  data);
            val_10 = this.eventProgress;
            val_6 = val_6 >> 5;
            if(val_10 != 0)
        {
                val_10 = this.eventProgress;
            mem2[0] = val_6;
        }
        
        }
        
            val_9 = this.levelProgress;
            val_8 = val_9;
        }
        
        LightningLevelsEcon val_7 = val_8.ParseEventEcon(data:  data);
        this.Econ = val_8;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    protected virtual bool IsEventNewCycle()
    {
        var val_1 = R6 + 8;
        val_1 = this - val_1;
        if(R6 != 0)
        {
                val_1 = 1;
        }
        
        return true;
    }
    protected virtual void ResetEventProgress()
    {
        this.levelProgress = new LightningLevelsLevelProgress();
        typeof(LightningLevelsEventPrgress).__il2cppRuntimeField_C = 0;
        typeof(LightningLevelsEventPrgress).__il2cppRuntimeField_8 = 1;
        typeof(LightningLevelsEventPrgress).__il2cppRuntimeField_10 = 0;
        this.eventProgress = new EventProgression();
    }
    protected virtual string GetLightningEventNameLoc()
    {
        return Localization.Localize(key:  -1180346096, defaultValue:  -1180346208, useSingularKey:  false);
    }
    protected virtual void UpdateRewardStatus()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1472372400, value:  8945664);
        this.UpdateToServer(data:  78753792);
    }
    protected void UpdateToServer(System.Collections.Generic.Dictionary<string, object> data)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -1180093888, data:  data);
    }
    private LightningLevelsEcon ParseEventEcon(System.Collections.Generic.Dictionary<string, object> data)
    {
        string val_9;
        var val_31;
        var val_32;
        var val_33;
        float val_34;
        var val_35;
        var val_36;
        var val_37;
        typeof(LightningLevelsEcon).__il2cppRuntimeField_18 = 7;
        typeof(LightningLevelsEcon).__il2cppRuntimeField_1C = 15;
        null = new System.Object();
        if(data == 0)
        {
                return;
        }
        
        val_33 = "economy";
        if((data.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        val_34 = 1152921510385703632;
        object val_3 = data.Item[-1554533760];
        if(data == 0)
        {
                return;
        }
        
        val_35 = data;
        val_33 = 1152921504685600768;
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_35 = 0;
        }
        
        if((val_35.ContainsKey(key:  -1605526400)) == false)
        {
            goto label_7;
        }
        
        string val_5 = val_35.Item[-1605526400];
        val_36 = 0;
        Dictionary.Enumerator<TKey, TValue> val_6 = GetEnumerator();
        label_23:
        if(0.MoveNext() == false)
        {
            goto label_15;
        }
        
        bool val_11 = System.Int32.TryParse(s:  val_9, result: out  int val_10 = -1179985476);
        if((0 < 1) || (0 != 1))
        {
            goto label_23;
        }
        
        string val_12 = 0.Trim();
        string val_13 = 0.ToLower();
        if((System.String.Compare(strA:  null, strB:  -1987496016)) == 0)
        {
            goto label_21;
        }
        
        if((System.String.Compare(strA:  null, strB:  -1318762160)) == 0)
        {
            goto label_22;
        }
        
        if((System.String.Compare(strA:  null, strB:  -1318762064)) != 0)
        {
            goto label_23;
        }
        
        val_37 = 4;
        goto label_26;
        label_15:
        val_31 = 0;
        val_37 = 0;
        goto label_25;
        label_21:
        val_37 = 1;
        goto label_26;
        label_22:
        val_37 = 3;
        label_26:
        val_31 = 0;
        label_25:
        val_34 = 1152921510385703632;
        val_33 = 1152921504685600768;
        0.Dispose();
        if(val_37 != 0)
        {
                typeof(LightningLevelsEcon).__il2cppRuntimeField_C = val_37;
        }
        else
        {
                val_31 = 200;
            typeof(LightningLevelsEcon).__il2cppRuntimeField_C = 1;
        }
        
        LightningLevelsEcon.__il2cppRuntimeField_name.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = val_31;
        label_7:
        val_32 = 1152921510392296080;
        if((val_35.ContainsKey(key:  -1179997696)) != false)
        {
                string val_18 = val_35.Item[-1179997696];
            typeof(LightningLevelsEcon).__il2cppRuntimeField_10 = System.Int32.Parse(s:  null);
        }
        
        if((val_35.ContainsKey(key:  -1179997600)) != false)
        {
                string val_21 = val_35.Item[-1179997600];
            val_31 = 0;
            val_33 = 1;
            if((val_31.ContainsKey(key:  -1306409504)) != false)
        {
                string val_23 = val_31.Item[-1306409504];
            typeof(LightningLevelsEcon).__il2cppRuntimeField_14 = System.Int32.Parse(s:  null);
        }
        
            if((val_31.ContainsKey(key:  -1605531600)) != false)
        {
                string val_26 = val_31.Item[-1605531600];
            typeof(LightningLevelsEcon).__il2cppRuntimeField_18 = System.Int32.Parse(s:  null);
        }
        
        }
        
        if((val_35.ContainsKey(key:  -1179997504)) == false)
        {
                return;
        }
        
        string val_29 = val_35.Item[-1179997504];
        typeof(LightningLevelsEcon).__il2cppRuntimeField_1C = System.Int32.Parse(s:  null);
    }
    public LightningLevelsEventHandler()
    {
        typeof(LightningLevelsEventPrgress).__il2cppRuntimeField_C = 0;
        typeof(LightningLevelsEventPrgress).__il2cppRuntimeField_8 = 1;
        typeof(LightningLevelsEventPrgress).__il2cppRuntimeField_10 = 0;
        this.eventProgress = new EventProgression();
        this.levelProgress = new LightningLevelsLevelProgress();
    }

}
