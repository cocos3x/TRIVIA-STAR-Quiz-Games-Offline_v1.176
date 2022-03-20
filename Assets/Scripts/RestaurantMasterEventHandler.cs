using UnityEngine;
public class RestaurantMasterEventHandler : WGEventHandler
{
    // Fields
    public const string RESTAURANT_MASTER_EVENT_ID = "RestaurantMaster";
    public const string EVENT_TRACKING_ID = "Restaurant Master";
    private RestaurantMasterEcon econ;
    private RestaurantMasterProgress progressData;
    private static RestaurantMasterEventHandler <Instance>k__BackingField;
    
    // Properties
    public static bool IsEventActive { get; }
    public RestaurantMasterEcon Econ { get; }
    public RestaurantMasterProgress ProgressData { get; }
    public static RestaurantMasterEventHandler Instance { get; set; }
    public override int UnlockLevel { get; }
    public System.DateTime TimeExpire { get; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static bool get_IsEventActive()
    {
        if((RestaurantMasterEventHandler.<Instance>k__BackingField) == 0)
        {
                return false;
        }
        
        goto typeof(RestaurantMasterEventHandler).__il2cppRuntimeField_274;
    }
    public RestaurantMasterEcon get_Econ()
    {
    
    }
    public RestaurantMasterProgress get_ProgressData()
    {
    
    }
    public static RestaurantMasterEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(RestaurantMasterEventHandler value)
    {
        RestaurantMasterEventHandler.<Instance>k__BackingField = value;
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
        
        0 = 1152921512135182577;
        return (bool)0;
    }
    public override void PreInit(GameEventV2 eventV2)
    {
        this.econ = new RestaurantMasterEcon(eventDataDict:  eventV2.eventData);
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921512135427064] = eventV2;
        RestaurantMasterEventHandler.<Instance>k__BackingField = this;
        this.SetupEvent();
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        if((System.String.op_Inequality(a:  eventV2.type, b:  -1298908384)) != false)
        {
                return;
        }
        
        this.SetupEvent();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1061133920, defaultValue:  -1061134032, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1061133920, defaultValue:  -1061134032, useSingularKey:  false);
    }
    public override bool EventCompleted()
    {
        Player val_1 = App.Player;
        bool val_2 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  this.econ.unlockPlayerLevel);
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    public override bool get_IsEventValid()
    {
        Player val_1 = App.Player;
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  -1060765600);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
    
    }
    public override void OnEventEnded()
    {
        this.progressData = new EventProgression();
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
        0.SetupView();
    }
    public override void OnGameButtonPressed(bool connected)
    {
        GameBehavior val_1 = App.getBehavior;
        0.SetupView();
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        this.ShowRewardCollection();
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
    
    }
    public decimal GetCoinReward(bool showNextLevel = True)
    {
        var val_7;
        System.Predicate<RESEventRewardData> val_8;
        var val_9;
        var val_11;
        var val_12;
        if(R2 != 0)
        {
                Player val_2 = App.Player;
            val_8 = 1;
        }
        else
        {
                Player val_3 = App.Player;
            val_8 = 0;
        }
        
        System.Collections.Generic.List<RESEventRewardData> val_4 = showNextLevel + 16.GetRewardsList(playerLevel:  0);
        if((showNextLevel + 16) != 0)
        {
                val_9 = null;
            val_9 = null;
            val_8 = RestaurantMasterEventHandler.<>c.<>9__38_0;
            if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Predicate<ZooTile>(object:  RestaurantMasterEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3235539104));
            RestaurantMasterEventHandler.<>c.<>9__38_0 = val_8;
        }
        
            val_11 = val_8;
            val_7 = public RESEventRewardData System.Collections.Generic.List<RESEventRewardData>::Find(System.Predicate<T> match);
            var val_7 = showNextLevel + 16;
            object val_6 = val_7.Find(match:  8040448);
            if(val_7 != 0)
        {
                val_7 = val_7 + 16;
            return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = mem[1179403867]};
        }
        
        }
        
        val_12 = null;
        val_12 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = mem[1179403867]};
    }
    public int GetSpinReward(bool showNextLevel = True)
    {
        var val_9;
        var val_10;
        var val_11;
        System.Predicate<RESEventRewardData> val_13;
        val_9 = 35629968;
        if(showNextLevel != false)
        {
                Player val_2 = App.Player;
            val_10 = 1;
        }
        else
        {
                Player val_3 = App.Player;
            val_10 = 0;
        }
        
        System.Collections.Generic.List<RESEventRewardData> val_4 = this.econ.GetRewardsList(playerLevel:  0);
        if(this.econ == 0)
        {
                return 0;
        }
        
        val_11 = null;
        val_11 = null;
        val_13 = RestaurantMasterEventHandler.<>c.<>9__39_0;
        if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new System.Predicate<ZooTile>(object:  RestaurantMasterEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3235656224));
            RestaurantMasterEventHandler.<>c.<>9__39_0 = val_13;
        }
        
        object val_6 = this.econ.Find(match:  8040448);
        if(this.econ == 0)
        {
                return 0;
        }
        
        RestaurantMasterEcon val_7 = this.econ + 16;
        return (int)System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[(this.econ + 16) + (0)], hi = mem[(this.econ + 16) + (4)], lo = mem[(this.econ + 16) + (8)], mid = mem[(this.econ + 16) + (12)]});
    }
    private void ShowRewardCollection()
    {
        var val_1;
        var val_1 = 27406523;
        val_1 = 8219264 + val_1;
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
        
        App.game.ShowRewardCollection_RRV();
    }
    private void ShowRewardCollection_RRV()
    {
        GameBehavior val_1 = App.getBehavior;
        0.SetupCollect();
    }
    private bool IsEventExpired()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R7 + 40})) == false)
        {
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921512137835616});
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
        var val_7 = this;
        if(true != 0)
        {
                true = 67108865;
            goto label_1;
        }
        
        label_14:
        if(this.IsEventExpired() != true)
        {
                if(this.IsCurrentEventInCycle() == true)
        {
            goto label_4;
        }
        
        }
        
        this.ResetEventProgress();
        label_4:
        if(this.IsEventExpired() != false)
        {
                return;
        }
        
        this.progressData.eventId = R6 + 48;
        if(this.progressData != 0)
        {
            goto typeof(RestaurantMasterProgress).__il2cppRuntimeField_E4;
        }
        
        goto typeof(RestaurantMasterProgress).__il2cppRuntimeField_E4;
        label_1:
        if((this.progressData.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_14;
        }
        
        string val_5 = R4 + 8 + 72.Item[-1554533760];
        if((R4 + 8 + 72) == 0)
        {
            goto label_14;
        }
        
        mem2[0] = new RestaurantMasterEcon(eventDataDict:  R4 + 8 + 72);
        goto label_14;
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
        Player val_8 = App.Player;
        string val_9 = System.String.Format(format:  -1422499072, arg0:  13152256);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_10 = AppendLine(value:  -1422499072);
            return;
        }
        
        System.Text.StringBuilder val_11 = AppendLine(value:  -1422499072);
    }
    public RestaurantMasterEventHandler()
    {
        this.econ = new RestaurantMasterEcon(eventDataDict:  0);
        this.progressData = new EventProgression();
    }

}
