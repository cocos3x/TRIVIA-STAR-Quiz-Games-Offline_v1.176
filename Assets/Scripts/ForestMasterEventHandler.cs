using UnityEngine;
public class ForestMasterEventHandler : WGEventHandler
{
    // Fields
    public const string FOREST_MASTER_EVENT_ID = "ForestMaster";
    public const string EVENT_TRACKING_ID = "Forest Master";
    private ForestMasterEcon econ;
    private ForestMasterProgress progressData;
    private bool isEventInitialized;
    private static ForestMasterEventHandler <Instance>k__BackingField;
    private bool <IsRewardAvailable>k__BackingField;
    
    // Properties
    public static bool IsEventActive { get; }
    public ForestMasterEcon Econ { get; }
    public ForestMasterProgress ProgressData { get; }
    public static ForestMasterEventHandler Instance { get; set; }
    public int PlayerLevel { get; }
    public override int UnlockLevel { get; }
    public System.DateTime TimeExpire { get; }
    public bool IsRewardAvailable { get; set; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static bool get_IsEventActive()
    {
        if((ForestMasterEventHandler.<Instance>k__BackingField) == 0)
        {
                return false;
        }
        
        goto typeof(ForestMasterEventHandler).__il2cppRuntimeField_274;
    }
    public ForestMasterEcon get_Econ()
    {
    
    }
    public ForestMasterProgress get_ProgressData()
    {
    
    }
    public static ForestMasterEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(ForestMasterEventHandler value)
    {
        ForestMasterEventHandler.<Instance>k__BackingField = value;
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
    public bool get_IsRewardAvailable()
    {
        return (bool)this.<IsRewardAvailable>k__BackingField;
    }
    private void set_IsRewardAvailable(bool value)
    {
        this.<IsRewardAvailable>k__BackingField = value;
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
        
        0 = 1152921511771121425;
        return (bool)0;
    }
    public override void PreInit(GameEventV2 eventV2)
    {
        this.econ = new ForestMasterEcon(eventDataDict:  eventV2.eventData);
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921511771365912] = eventV2;
        ForestMasterEventHandler.<Instance>k__BackingField = this;
        this.SetupEvent();
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        if((System.String.op_Inequality(a:  eventV2.type, b:  -1425319472)) != false)
        {
                return;
        }
        
        this.SetupEvent();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1425194992, defaultValue:  -1425195088, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WordForest.WFOForestManager MonoSingleton<WordForest.WFOForestManager>::get_Instance()) <= 0)
        {
                return Localization.Localize(key:  -1425194992, defaultValue:  -1425195088, useSingularKey:  false);
        }
        
        float val_8 = 100f;
        val_8 = ((float)CurrentForestGrowth / (float)CurrentMaxGrowth) * val_8;
        int val_6 = UnityEngine.Mathf.RoundToInt(f:  val_8);
        string val_7 = System.String.Format(format:  2124591920, arg0:  13152256);
    }
    public override string GetGameButtonText()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_8 = 100f;
        val_8 = ((float)CurrentForestGrowth / (float)CurrentMaxGrowth) * val_8;
        int val_6 = UnityEngine.Mathf.RoundToInt(f:  val_8);
        string val_7 = System.String.Format(format:  2124591920, arg0:  13152256);
    }
    public override bool EventCompleted()
    {
        var val_5;
        var val_6;
        bool val_1 = this.IsEventExpired();
        val_5 = 1;
        if(val_1 == true)
        {
                return (bool)val_5;
        }
        
        val_6 = val_1.PlayerLevel;
        if(this.econ.unlockPlayerLevel == 1)
        {
                return (bool)val_5;
        }
        
        if(val_6 < this.econ.unlockPlayerLevel)
        {
                return (bool)val_5;
        }
        
        val_6 = PlayerLevel;
        GameBehavior val_4 = App.getBehavior;
        if(val_6 >= 0)
        {
                false = this.<IsRewardAvailable>k__BackingField;
        }
        
        if(val_6 >= 0)
        {
                val_5 = false >> 5;
        }
        
        return (bool)val_5;
    }
    public override bool get_IsEventValid()
    {
        if(this.PlayerLevel >= this)
        {
                0 = 1;
        }
        
        if(this != 1)
        {
                1152921511772067905 = 1;
        }
        
        return true;
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_9 = 100f;
        val_9 = ((float)CurrentForestGrowth / (float)CurrentMaxGrowth) * val_9;
        int val_6 = UnityEngine.Mathf.RoundToInt(f:  val_9);
        string val_7 = System.String.Format(format:  2124591920, arg0:  13152256);
        TheLibraryMainScreen val_8 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override void OnEventEnded()
    {
        this.progressData = new EventProgression();
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
    public override void OnForestComplete(int levelsProgressed = 1)
    {
        this.<IsRewardAvailable>k__BackingField = true;
        goto typeof(ForestMasterEventHandler).__il2cppRuntimeField_17C;
    }
    public override void OnForestUpdated()
    {
        goto typeof(ForestMasterEventHandler).__il2cppRuntimeField_17C;
    }
    public override System.Collections.IEnumerator DoLevelCompleteEventProgressAnimation(WGEventButtonV2 eventButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        object val_1 = new System.Object();
        typeof(ForestMasterEventHandler.<DoLevelCompleteEventProgressAnimation>d__43).__il2cppRuntimeField_8 = 0;
        typeof(ForestMasterEventHandler.<DoLevelCompleteEventProgressAnimation>d__43).__il2cppRuntimeField_10 = eventButton;
    }
    public decimal GetCoinReward(bool showCurrentLevel = True)
    {
        int val_10;
        var val_11;
        var val_13;
        var val_14;
        if(R2 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_10 = CurrentForestLevel;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_10 = CurrentForestLevel - 1;
        }
        
        System.Collections.Generic.List<RESEventRewardData> val_6 = showCurrentLevel + 16.GetRewardsList(playerLevel:  val_10);
        if((showCurrentLevel + 16) != 0)
        {
                val_11 = null;
            val_11 = null;
            val_10 = ForestMasterEventHandler.<>c.<>9__44_0;
            if(val_10 == 0)
        {
                val_10 = null;
            val_10 = new System.Predicate<ZooTile>(object:  ForestMasterEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2871391616));
            ForestMasterEventHandler.<>c.<>9__44_0 = val_10;
        }
        
            val_13 = val_10;
            var val_9 = showCurrentLevel + 16;
            object val_8 = val_9.Find(match:  8040448);
            if(val_9 != 0)
        {
                val_9 = val_9 + 16;
            return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
    }
    public int GetAcornReward(bool showCurrentLevel = True)
    {
        int val_14;
        var val_15;
        System.Predicate<RESEventRewardData> val_17;
        var val_18;
        var val_19;
        var val_20;
        int val_21;
        var val_22;
        if(showCurrentLevel != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_14 = CurrentForestLevel;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_14 = CurrentForestLevel - 1;
        }
        
        System.Collections.Generic.List<RESEventRewardData> val_6 = this.econ.GetRewardsList(playerLevel:  val_14);
        if(this.econ == 0)
        {
                return 0;
        }
        
        val_15 = null;
        val_15 = null;
        val_17 = ForestMasterEventHandler.<>c.<>9__45_0;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Predicate<ZooTile>(object:  ForestMasterEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2871510784));
            ForestMasterEventHandler.<>c.<>9__45_0 = val_17;
        }
        
        object val_8 = this.econ.Find(match:  8040448);
        if(this.econ != 0)
        {
                val_18 = this.econ + 28;
            val_19 = this.econ + 24;
            val_20 = this.econ + 20;
            val_21 = this.econ + 16;
            val_22 = null;
            return (int)System.Decimal.ToInt32(d:  new System.Decimal() {flags = val_21, hi = mem[1152921504617021448], lo = mem[1152921504617021452], mid = mem[1152921504617021456]});
        }
        
        val_22 = null;
        val_22 = null;
        val_18 = 1152921504617021456;
        val_19 = 1152921504617021452;
        val_20 = 1152921504617021448;
        val_21 = 1152921504617021444;
        return (int)System.Decimal.ToInt32(d:  new System.Decimal() {flags = val_21, hi = mem[1152921504617021448], lo = mem[1152921504617021452], mid = mem[1152921504617021456]});
    }
    public void ShowRewardCollection()
    {
        this.<IsRewardAvailable>k__BackingField = false;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private bool IsEventExpired()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R7 + 40})) == false)
        {
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921511773579200});
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
    private void SetupEvent()
    {
        if(true != 0)
        {
                true = 67108865;
            goto label_1;
        }
        
        label_15:
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
        
        this.progressData.eventId = R6 + 48;
        this.isEventInitialized = true;
        return;
        label_1:
        if((true.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_15;
        }
        
        string val_5 = mem[35639090].Item[-1554533760];
        if(mem[35639090] == 0)
        {
            goto label_15;
        }
        
        this.econ = new ForestMasterEcon(eventDataDict:  mem[35639090] + 72);
        goto label_15;
    }
    private void ShowPopup(bool firstTime = False)
    {
        var val_10 = this;
        if(firstTime != false)
        {
                if(this.progressData.hasSeenPopup == true)
        {
                return;
        }
        
        }
        
        if(R4 == 1)
        {
                return;
        }
        
        if(this.progressData.hasSeenPopup.PlayerLevel < R4)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) != 0)
        {
                GameBehavior val_5 = App.getBehavior;
            if(0 != 0)
        {
            goto label_17;
        }
        
        }
        else
        {
                GameBehavior val_7 = App.getBehavior;
        }
        
        label_17:
        mem2[0] = 1;
    }
    public void ResetEventProgress()
    {
        this.progressData = new EventProgression();
    }
    private string GetPlatformId()
    {
    
    }
    public override string GetHackPanelEventData()
    {
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        System.Text.StringBuilder val_2 = AppendLine(value:  -1544784160);
        string val_3 = this.econ.unlockPlayerLevel.ToString();
        string val_4 = System.String.Format(format:  -1544779920, arg0:  this.econ.unlockPlayerLevel);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_5 = AppendLine(value:  -1544779920);
        }
        else
        {
                System.Text.StringBuilder val_6 = AppendLine(value:  -1544779920);
        }
        
        System.Text.StringBuilder val_7 = AppendLine(value:  -1544779600);
        int val_8 = PlayerLevel;
        string val_9 = System.String.Format(format:  -1422499072, arg0:  13152256);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_10 = AppendLine(value:  -1422499072);
            return;
        }
        
        System.Text.StringBuilder val_11 = AppendLine(value:  -1422499072);
    }
    public ForestMasterEventHandler()
    {
        this.econ = new ForestMasterEcon(eventDataDict:  0);
        this.progressData = new EventProgression();
    }

}
