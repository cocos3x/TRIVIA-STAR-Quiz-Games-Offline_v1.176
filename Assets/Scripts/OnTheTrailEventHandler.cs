using UnityEngine;
public class OnTheTrailEventHandler : WGEventHandler
{
    // Fields
    public const string ON_THE_TRAIL_EVENT_ID = "OnTheTrail";
    public OnTheTrailEventEcon Econ;
    private OnTheTrailEventProgress eventProgress;
    private static OnTheTrailEventHandler <Instance>k__BackingField;
    
    // Properties
    public static OnTheTrailEventHandler Instance { get; set; }
    private System.Collections.Generic.List<bool> DaysRewarded { get; }
    private OnTheTrailDayProgress SavedDayProgress { get; }
    private OnTheTrailDayProgress WagonBrokenDayProgress { get; set; }
    
    // Methods
    public static OnTheTrailEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(OnTheTrailEventHandler value)
    {
        OnTheTrailEventHandler.<Instance>k__BackingField = value;
    }
    private System.Collections.Generic.List<bool> get_DaysRewarded()
    {
        if(this.eventProgress != 0)
        {
                return;
        }
    
    }
    private OnTheTrailDayProgress get_SavedDayProgress()
    {
        if(this.eventProgress != 0)
        {
                return;
        }
    
    }
    private OnTheTrailDayProgress get_WagonBrokenDayProgress()
    {
        if(this.eventProgress != 0)
        {
                return;
        }
    
    }
    private void set_WagonBrokenDayProgress(OnTheTrailDayProgress value)
    {
        this.eventProgress.WagonBrokenDayProgress = value;
    }
    public override void Init(GameEventV2 eventV2)
    {
        OnTheTrailEventHandler.<Instance>k__BackingField = this;
        mem[1152921512053212808] = eventV2;
        if(this != 0)
        {
                return;
        }
        
        this.RefreshEventData(data:  eventV2.eventData);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        if(this != 0)
        {
                return;
        }
        
        R4.RefreshEventData(data:  R5 + 72);
    }
    public override void OnGameSceneInit()
    {
        var val_9;
        var val_10;
        int val_11;
        OnTheTrailEventEcon val_12;
        if(this != 0)
        {
                return;
        }
        
        if(this.eventProgress.IsFtuxSeen != true)
        {
                return;
        }
        
        if(this.eventProgress.IsWagonBroken == false)
        {
            goto label_5;
        }
        
        object val_1 = null;
        val_9 = val_1;
        val_1 = new System.Object();
        int val_2 = this.GetCurrentDay();
        if(val_9 == 0)
        {
            goto label_6;
        }
        
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_8 = val_2;
        System.TimeSpan val_3 = GetTimeLeftUntilEndOfDay(day:  -1143234176);
        goto label_7;
        label_5:
        object val_4 = null;
        val_9 = val_4;
        val_4 = new System.Object();
        int val_5 = this.GetCurrentDay();
        if(val_9 == 0)
        {
            goto label_8;
        }
        
        val_10 = val_9;
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_8 = val_5;
        System.TimeSpan val_6 = GetTimeLeftUntilEndOfDay(day:  -1143234176);
        goto label_9;
        label_6:
        mem[8] = val_2;
        System.TimeSpan val_7 = GetTimeLeftUntilEndOfDay(day:  -1143234176);
        label_7:
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_10 = ???;
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_18 = this.eventProgress.DaysRewarded;
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_1C = this.Econ.Rewards;
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_20 = this.eventProgress.WagonBrokenDayProgress.CompletedLevels;
        val_11 = this.eventProgress.WagonBrokenDayProgress.DayIndex;
        if(this.eventProgress.WagonBrokenDayProgress.CompletedLevels <= val_11)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + (val_11 << 2);
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_24 = (0 + (this.eventProgress.WagonBrokenDayProgress.DayIndex) << 2) + 16;
        val_12 = this.Econ;
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_28 = this.Econ.FixPrice;
        goto label_20;
        label_8:
        val_10 = 8;
        mem[8] = val_5;
        System.TimeSpan val_8 = GetTimeLeftUntilEndOfDay(day:  -1143234176);
        label_9:
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_10 = ???;
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_18 = this.eventProgress.DaysRewarded;
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_1C = this.Econ.Rewards;
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_20 = this.eventProgress.SavedDayProgress.CompletedLevels;
        val_12 = this.Econ.Goals;
        val_11 = val_10 - 1;
        if(this.eventProgress.SavedDayProgress.CompletedLevels <= val_11)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + (val_11 << 2);
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_24 = (0 + ((val_5 - 1)) << 2) + 16;
        label_20:
        (0 + ((val_5 - 1)) << 2) + 16.ShowOnTheTrailPopup(param:  433385472);
        this.eventProgress.IsFtuxSeen = true;
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        int val_17;
        int val_18;
        int val_19;
        var val_20;
        OnTheTrailEventProgress val_21;
        OnTheTrailDayProgress val_22;
        var val_23;
        var val_25;
        OnTheTrailEventProgress val_26;
        val_17 = levelsProgressed;
        val_18 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_19 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_19 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            if(PlayingChallenge == true)
        {
                return;
        }
        
        }
        
        if(this.IsEventExpired() == true)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        if(this.eventProgress.IsWagonBroken == true)
        {
                return;
        }
        
        if(this.eventProgress.DaysRewarded <= this.eventProgress.SavedDayProgress.DayIndex)
        {
            goto label_18;
        }
        
        val_20 = this.eventProgress;
        if(this.eventProgress != 0)
        {
            goto label_19;
        }
        
        val_21 = this.eventProgress;
        if(val_21 == 0)
        {
            goto label_68;
        }
        
        label_19:
        val_19 = this.eventProgress.SavedDayProgress.DayIndex;
        if(val_21 <= val_19)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + val_19;
        if(((0 + this.eventProgress.SavedDayProgress.DayIndex) + 16) != 0)
        {
                return;
        }
        
        label_18:
        int val_6 = this.eventProgress.SavedDayProgress.DayIndex + 1;
        System.TimeSpan val_7 = GetTimeLeftUntilEndOfDay(day:  -1142864128);
        double val_8 = ???.TotalSeconds;
        if(this.eventProgress.SavedDayProgress == 0)
        {
                3152091128 = 3152091128;
        }
        
        if(S0 <= 1)
        {
            goto label_27;
        }
        
        val_22 = this.eventProgress.SavedDayProgress;
        if(val_22 == 0)
        {
            goto label_29;
        }
        
        val_19 = this.eventProgress.SavedDayProgress.CompletedLevels;
        goto label_30;
        label_27:
        int val_10 = this.GetCurrentDay() - this.eventProgress.SavedDayProgress.DayIndex;
        if(val_10 >= 2)
        {
                this.eventProgress.IsWagonBroken = true;
        }
        
        val_19 = this.eventProgress.SavedDayProgress;
        if(val_19 == 0)
        {
            goto label_36;
        }
        
        val_18 = this.eventProgress.SavedDayProgress.DayIndex;
        goto label_37;
        label_29:
        val_22 = 12;
        val_19 = 0;
        label_30:
        mem[12] = val_19 + val_17;
        if(this == 0)
        {
                return;
        }
        
        object val_12 = new System.Object();
        int val_13 = this.GetCurrentDay();
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_8 = val_13;
        System.TimeSpan val_14 = GetTimeLeftUntilEndOfDay(day:  -1142864128);
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_10 = ???;
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_18 = this.eventProgress.DaysRewarded;
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_1C = this.Econ.Rewards;
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_20 = this.eventProgress.SavedDayProgress.CompletedLevels;
        val_17 = val_13 - 1;
        if(this.Econ.Goals <= val_17)
        {
            goto label_48;
        }
        
        val_23 = val_17;
        if(this.eventProgress.SavedDayProgress.CompletedLevels > val_17)
        {
            goto label_55;
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_23 = val_17;
        goto label_55;
        label_48:
        val_23 = this.Econ.Goals - 1;
        if(this.eventProgress.SavedDayProgress.CompletedLevels <= val_23)
        {
                var val_17 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        label_55:
        val_17 = val_17 + (val_23 << 2);
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_24 = (0 + ((this.Econ.Goals - 1)) << 2) + 16;
        val_18 = this.Econ.Rewards;
        if(this.Econ.Rewards > val_17)
        {
                if(val_18 != 0)
        {
            goto label_61;
        }
        
        }
        else
        {
                val_17 = this.Econ.Rewards - 1;
        }
        
        label_61:
        if(((0 + ((this.Econ.Goals - 1)) << 2) + 16) <= val_17)
        {
                var val_18 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_18 = val_18 + (val_17 << 2);
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_28 = (0 + ((this.Econ.Rewards - 1)) << 2) + 16;
        (0 + ((this.Econ.Rewards - 1)) << 2) + 16.ShowOnTheTrailPopup(param:  433491968);
        return;
        label_36:
        val_19 = 8;
        val_18 = 0;
        label_37:
        mem[8] = val_18 + val_10;
        val_25 = this.eventProgress;
        if(this.eventProgress != 0)
        {
            goto label_67;
        }
        
        val_26 = this.eventProgress;
        if(val_26 == 0)
        {
            goto label_68;
        }
        
        label_67:
        if(this.eventProgress.IsWagonBroken == true)
        {
                val_17 = 0;
        }
        
        this.eventProgress.SavedDayProgress.CompletedLevels = val_17;
        return;
        label_68:
    }
    public override void OnEventEnded()
    {
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public override bool EventCompleted()
    {
        OnTheTrailDayProgress val_2;
        int val_2 = this.GetEventDurationInDays();
        val_2 = this.eventProgress.SavedDayProgress;
        val_2 = val_2 - 1;
        if(this.eventProgress.SavedDayProgress.DayIndex == val_2)
        {
                val_2 = this.eventProgress.DaysRewarded;
            if(this.eventProgress.SavedDayProgress.DayIndex <= val_2)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_3 = val_3 + val_2;
            if((((0 + (val_1 - 1)) + 16) & 1) == 0)
        {
                return true;
        }
        
        }
        
        if(this.eventProgress.IsEventCompleted == true)
        {
                this.eventProgress.IsEventCompleted = 1;
        }
        
        return true;
    }
    public override bool IsChallengeCompleted()
    {
        goto typeof(OnTheTrailEventHandler).__il2cppRuntimeField_29C;
    }
    public override int LastProgressTimestamp()
    {
        if(this.eventProgress != 0)
        {
                return (int)this.eventProgress.LastProgressTimestamp;
        }
        
        return (int)this.eventProgress.LastProgressTimestamp;
    }
    public override void UpdateProgress()
    {
        this.eventProgress.LastProgressTimestamp = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override bool IsRewardReadyToCollect()
    {
        System.Collections.Generic.List<System.Int32> val_1;
        var val_2;
        OnTheTrailEventProgress val_3;
        val_1 = this.Econ.Goals;
        if(true <= this.eventProgress.SavedDayProgress.DayIndex)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (this.eventProgress.SavedDayProgress.DayIndex << 2);
        val_2 = 0;
        if(this.eventProgress.SavedDayProgress.CompletedLevels != ((0 + (this.eventProgress.SavedDayProgress.DayIndex) << 2) + 16))
        {
                return (bool)val_2;
        }
        
        val_3 = this.eventProgress;
        if(this.eventProgress != 0)
        {
            goto label_9;
        }
        
        val_3 = this.eventProgress;
        if(val_3 == 0)
        {
            goto label_10;
        }
        
        label_9:
        val_1 = this.eventProgress.SavedDayProgress;
        if(val_3 <= this.eventProgress.SavedDayProgress.DayIndex)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + this.eventProgress.SavedDayProgress.DayIndex;
        val_2 = ((0 + this.eventProgress.SavedDayProgress.DayIndex) + 16) >> 5;
        return (bool)val_2;
        label_10:
    }
    public override string GetMainMenuButtonText()
    {
        bool val_3 = static_value_021FCD11;
        if(val_3 != true)
        {
                val_3 = true;
        }
        
        string val_1 = this.GetEventNameLoc();
        string val_2 = this.GetTodaysProgressText();
        return System.String.Format(format:  1592589744, arg0:  1, arg1:  -1141768832);
    }
    public override string GetGameButtonText()
    {
        return this.GetTodaysProgressText();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1141568736, defaultValue:  -1141568832, useSingularKey:  false);
    }
    public override string GetCustomizedEventListItemTimerText()
    {
        var val_3;
        int val_1 = this.GetCurrentDay();
        System.TimeSpan val_2 = GetTimeLeftUntilEndOfDay(day:  -1141432336);
        string val_5 = Localization.Localize(key:  -1141456624, defaultValue:  -1141456528, useSingularKey:  false);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "day_upper";
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_7 = UnityEngine.Mathf.Max(a:  val_3.Hours, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_9 = UnityEngine.Mathf.Max(a:  val_3.Minutes, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_10 = System.String.Format(format:  -1141456448, args:  472754880);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_3;
        var val_4;
        val_3 = this;
        if(this.IsEventExpired() != true)
        {
                if(val_3 != 0)
        {
            
        }
        else
        {
                var val_2 = 22833679;
            val_2 = 12792112 + val_2;
            if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
            val_4 = null;
            val_4 = null;
            AmplitudePluginHelper.lastFeatureAccessPoint = 75;
            R4.OnEventButtonPressed();
        }
        
        }
    
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_5;
        var val_6;
        val_5 = this;
        if(this.IsEventExpired() != true)
        {
                if(val_5 != 0)
        {
            
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge == true)
        {
                76 = 77;
        }
        
            var val_4 = 22832223;
            val_4 = 12793568 + val_4;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            val_6 = null;
            val_6 = null;
            AmplitudePluginHelper.lastFeatureAccessPoint = 77;
            R4.OnEventButtonPressed();
        }
        
        }
    
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        OnTheTrailEventProgress val_7;
        float val_8;
        float val_9;
        float val_10;
        var val_11;
        var val_12;
        System.Collections.Generic.List<System.Int32> val_13;
        OnTheTrailDayProgress val_14;
        if(this.IsEventExpired() == true)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        this.RefreshLatestProgress(day:  this.GetCurrentDay());
        val_7 = this.eventProgress;
        if(this.eventProgress == 0)
        {
                val_7 = this.eventProgress;
        }
        
        if(this.eventProgress.IsWagonBroken != false)
        {
                if(this.eventProgress.IsWagonBroken <= this.eventProgress.WagonBrokenDayProgress.DayIndex)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_7 = val_7 + (this.eventProgress.WagonBrokenDayProgress.DayIndex << 2);
            val_8 = mem[(0 + (this.eventProgress.WagonBrokenDayProgress.DayIndex) << 2) + 16];
            val_8 = (0 + (this.eventProgress.WagonBrokenDayProgress.DayIndex) << 2) + 16;
            val_9 = (float)this.eventProgress.WagonBrokenDayProgress.CompletedLevels;
            val_10 = (float)val_8;
            val_11 = 1152921504619999232;
            val_12 = null;
            val_13 = this.Econ.Goals;
            val_14 = this.eventProgress.WagonBrokenDayProgress;
        }
        else
        {
                if(this.eventProgress.IsWagonBroken <= this.eventProgress.SavedDayProgress.DayIndex)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_8 = val_8 + (this.eventProgress.SavedDayProgress.DayIndex << 2);
            val_8 = mem[(0 + (this.eventProgress.SavedDayProgress.DayIndex) << 2) + 16];
            val_8 = (0 + (this.eventProgress.SavedDayProgress.DayIndex) << 2) + 16;
            val_9 = (float)this.eventProgress.SavedDayProgress.CompletedLevels;
            val_10 = val_8;
            val_11 = 1152921504619999232;
            val_12 = null;
            val_13 = this.Econ.Goals;
            val_14 = this.eventProgress.SavedDayProgress;
        }
        
        if(null <= this.eventProgress.SavedDayProgress.DayIndex)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 / val_10;
        val_9 = val_9 + (this.eventProgress.SavedDayProgress.DayIndex << 2);
        string val_3 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        string val_4 = Localization.Localize(key:  -1141017856, defaultValue:  -1141017936, useSingularKey:  false);
        string val_5 = System.String.Format(format:  -1826949520, arg0:  1629069648, arg1:  -1141017856);
        TheLibraryMainScreen val_6 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(this.eventProgress.IsWagonBroken == true)
        {
                this.eventProgress.IsWagonBroken = 1;
        }
        
        loader.Setup(progress:  val_8, progressText:  val_9, isWagonBroken:  true);
    }
    public System.Collections.Generic.KeyValuePair<int, System.TimeSpan> GetDayTimeInfo()
    {
        long val_3;
        System.TimeSpan val_2 = GetTimeLeftUntilEndOfDay(day:  R1);
        this = new System.Collections.Generic.KeyValuePair<System.Int32, System.TimeSpan>(key:  R1.GetCurrentDay(), value:  new System.TimeSpan() {_ticks = val_3});
        return new System.Collections.Generic.KeyValuePair<System.Int32, System.TimeSpan>() {Value = new System.TimeSpan() {_ticks = this}};
    }
    private void RefreshEventData(System.Collections.Generic.Dictionary<string, object> data)
    {
        OnTheTrailEventProgress val_17;
        int val_18;
        OnTheTrailEventEcon val_19;
        var val_20;
        bool val_21;
        int val_22;
        if((System.String.op_Inequality(a:  static_value_021FCD50, b:  -1266462096)) != false)
        {
                return;
        }
        
        if(data == 0)
        {
            goto label_3;
        }
        
        val_18 = 1152921510392296080;
        if((data.ContainsKey(key:  -1472372400)) != false)
        {
                object val_3 = data.Item[-1472372400];
            string val_4 = data.ToString();
            if((System.Boolean.Parse(value:  data)) != false)
        {
                this.eventProgress.IsEventCompleted = true;
            return;
        }
        
        }
        
        this.Econ = new OnTheTrailEventEcon();
        val_17 = "economy";
        if((data.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_14;
        }
        
        val_19 = data;
        object val_8 = val_19.Item[-1554533760];
        val_20 = 0;
        if(val_19 != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_19 = 0;
        }
        
            val_20 = val_19;
        }
        
        OnTheTrailEventEcon val_9 = this.ParseEventEcon(econData:  0);
        this.Econ = val_19;
        goto label_14;
        label_3:
        this.Econ = new OnTheTrailEventEcon();
        label_14:
        bool val_11 = this.IsEventNewCycle();
        if(val_11 == true)
        {
                val_11 = this;
            this.ResetEventProgress();
        }
        
        int val_12 = this.GetCurrentDay();
        int val_13 = val_12 - 1;
        int val_14 = val_13 - this.eventProgress.SavedDayProgress.DayIndex;
        if(val_14 <= 0)
        {
            goto label_18;
        }
        
        label_27:
        val_17 = this.eventProgress;
        if(this.eventProgress.IsInitialized == false)
        {
            goto label_20;
        }
        
        val_18 = val_12 - 2;
        if(this.eventProgress.IsInitialized <= val_18)
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 + val_18;
        val_21 = ((0 + (val_12 - 2)) + 16) ^ 1;
        goto label_24;
        label_18:
        if(this.eventProgress.IsInitialized == true)
        {
            goto label_26;
        }
        
        goto label_27;
        label_20:
        val_21 = false;
        label_24:
        this.eventProgress.IsWagonBroken = val_21;
        if(this.eventProgress.IsWagonBroken == false)
        {
            goto label_29;
        }
        
        val_17 = this.eventProgress.WagonBrokenDayProgress;
        if(val_14 >= 2)
        {
            goto label_31;
        }
        
        val_22 = this.eventProgress.SavedDayProgress.DayIndex;
        val_18 = this.eventProgress.SavedDayProgress.CompletedLevels;
        if(val_17 != 0)
        {
            goto label_37;
        }
        
        goto label_37;
        label_31:
        val_22 = val_12 - 2;
        val_18 = 0;
        label_37:
        this.eventProgress.WagonBrokenDayProgress.DayIndex = val_22;
        this.eventProgress.WagonBrokenDayProgress.CompletedLevels = val_18;
        label_29:
        this.eventProgress.SavedDayProgress.DayIndex = val_13;
        this.eventProgress.SavedDayProgress.CompletedLevels = 0;
        this.eventProgress.IsInitialized = true;
        label_26:
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    private OnTheTrailEventEcon ParseEventEcon(System.Collections.Generic.Dictionary<string, object> econData)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_16;
        var val_17;
        var val_18;
        var val_19;
        float val_20;
        int val_21;
        var val_22;
        int val_23;
        val_16 = econData;
        OnTheTrailEventEcon val_1 = new OnTheTrailEventEcon();
        if(val_16 == 0)
        {
                return;
        }
        
        val_17 = 1152921510392296080;
        if((val_16.ContainsKey(key:  -1140401184)) == false)
        {
            goto label_42;
        }
        
        System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
        typeof(OnTheTrailEventEcon).__il2cppRuntimeField_8 = null;
        object val_4 = val_16.Item[-1140401184];
        val_18 = 0;
        List.Enumerator<T> val_5 = GetEnumerator();
        val_19 = 1152921510382894416;
        val_20 = 1152921510720759024;
        label_15:
        if(MoveNext() == false)
        {
            goto label_10;
        }
        
        val_21 = 0;
        Add(item:  null);
        goto label_15;
        label_10:
        Dispose();
        val_16 = val_16;
        val_17 = 1152921510392296080;
        label_42:
        val_22 = "golden_rew";
        if((val_16.ContainsKey(key:  -1140401088)) == false)
        {
            goto label_39;
        }
        
        System.Collections.Generic.List<System.Int32> val_9 = new System.Collections.Generic.List<System.Int32>();
        typeof(OnTheTrailEventEcon).__il2cppRuntimeField_C = null;
        string val_10 = val_16.Item[-1140401088];
        val_22 = 0;
        List.Enumerator<T> val_11 = GetEnumerator();
        val_19 = 1152921510382894416;
        val_20 = 1152921510720759024;
        label_29:
        if(MoveNext() == false)
        {
            goto label_24;
        }
        
        val_23 = 0;
        Add(item:  null);
        goto label_29;
        label_24:
        Dispose();
        val_16 = val_16;
        val_17 = 1152921510392296080;
        label_39:
        if((val_16.ContainsKey(key:  -1140400992)) == false)
        {
                return;
        }
        
        string val_14 = val_16.Item[-1140400992];
        typeof(OnTheTrailEventEcon).__il2cppRuntimeField_10 = System.Int32.Parse(s:  val_16);
    }
    private bool IsEventNewCycle()
    {
        var val_1 = R6 + 8;
        val_1 = this.eventProgress.Timestamp - val_1;
        if(R6 != 0)
        {
                val_1 = 1;
        }
        
        return true;
    }
    private void ResetEventProgress()
    {
        this.eventProgress = new OnTheTrailEventProgress();
        typeof(OnTheTrailEventProgress).__il2cppRuntimeField_18 = R6 + 8;
        int val_2 = this.GetEventDurationInDays();
        System.Collections.Generic.List<System.Boolean> val_3 = new System.Collections.Generic.List<System.Boolean>(collection:  1054454320);
        this.eventProgress.DaysRewarded = null;
    }
    private void UpdateRewardStatusToServer()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1472372400, value:  8945664);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -1140020416, data:  78753792);
    }
    private bool IsEventExpired()
    {
        ulong val_4;
        bool val_11;
        var val_12;
        ulong val_13;
        var val_15;
        val_11 = static_value_021FCD1C;
        if(val_11 != true)
        {
                val_11 = true;
        }
        
        val_12 = R6;
        if(R6 == 0)
        {
                if(val_12 == 0)
        {
            goto label_2;
        }
        
        }
        
        val_13 = mem[R6 + 40];
        val_13 = R6 + 40;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = R6 + 32}, d2:  new System.DateTime() {dateData = val_13})) != false)
        {
                System.DateTime val_3 = DateTimeCheat.UtcNow;
            bool val_6 = System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = 1152921512056873152});
        }
        else
        {
                System.DateTime val_7 = DateTimeCheat.UtcNow;
            val_13 = mem[R6 + 44 + 32];
            val_13 = R6 + 44 + 32;
            val_15 = 0;
            if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = val_13})) == false)
        {
                return (bool)val_15;
        }
        
            System.DateTime val_9 = DateTimeCheat.UtcNow;
        }
        
        val_15 = System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = 1152921512056873152});
        return (bool)val_15;
        label_2:
    }
    private int GetCurrentDay()
    {
        var val_3;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_2 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512056973112}, d2:  new System.DateTime());
        double val_5 = val_3.TotalDays;
        return (int)UnityEngine.Mathf.CeilToInt(f:  null);
    }
    private System.TimeSpan GetTimeLeftUntilEndOfDay(int day)
    {
        var val_1 = (day + 8) + 24;
        var val_5 = day + 16 + 20;
        val_5 = val_5 * R2;
        System.DateTime val_2 = AddSeconds(value:  null);
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512057097152}, d2:  new System.DateTime());
        return new System.TimeSpan() {_ticks = val_4._ticks};
    }
    private int GetEventDurationInDays()
    {
        var val_2;
        if(35638559 == 0)
        {
                if(35638559 == 0)
        {
            goto label_2;
        }
        
        }
        
        System.TimeSpan val_1 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512057197112}, d2:  new System.DateTime() {dateData = static_value_021FCD3F});
        double val_4 = val_2.TotalDays;
        return (int)UnityEngine.Mathf.CeilToInt(f:  null);
        label_2:
    }
    private string GetTodaysProgressText()
    {
        if(null <= this.eventProgress.SavedDayProgress.DayIndex)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (this.eventProgress.SavedDayProgress.DayIndex << 2);
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    private string GetEventNameLoc()
    {
        return Localization.Localize(key:  -1141568736, defaultValue:  -1141568832, useSingularKey:  false);
    }
    private void ShowOnTheTrailPopup(OnTheTrailEvent.PopupUIParameters_Basic param)
    {
        var val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = GetWindow<System.Object>();
        if(isActiveAndEnabled != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            object val_6 = GetWindow<System.Object>();
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  true);
        }
        
        Setup(param:  param);
    }
    private void RefreshLatestProgress(int day)
    {
        int val_3;
        OnTheTrailEventProgress val_4;
        int val_5;
        int val_1 = day - 1;
        val_3 = val_1 - this.eventProgress.SavedDayProgress.DayIndex;
        if(val_3 < 1)
        {
                return;
        }
        
        val_4 = this.eventProgress;
        val_5 = day - 2;
        if(this.eventProgress.SavedDayProgress.DayIndex <= val_5)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + val_5;
        bool val_3 = (0 + (day - 2)) + 16;
        val_3 = val_3 ^ 1;
        this.eventProgress.IsWagonBroken = val_3;
        if(this.eventProgress.IsWagonBroken != false)
        {
                val_4 = this.eventProgress.WagonBrokenDayProgress;
            if(val_3 < 2)
        {
                val_5 = this.eventProgress.SavedDayProgress.DayIndex;
            val_3 = this.eventProgress.SavedDayProgress.CompletedLevels;
        }
        else
        {
                val_3 = 0;
        }
        
            this.eventProgress.WagonBrokenDayProgress.DayIndex = val_5;
            this.eventProgress.WagonBrokenDayProgress.CompletedLevels = val_3;
        }
        
        this.eventProgress.SavedDayProgress.DayIndex = val_1;
        this.eventProgress.SavedDayProgress.CompletedLevels = 0;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public void FixWagon()
    {
        int val_4;
        Player val_1 = App.Player;
        int val_2 = 0 - this.Econ.FixPrice;
        decimal val_3 = System.Decimal.op_Implicit(value:  -1138838000);
        0.AddCredits(amount:  new System.Decimal() {mid = val_4}, source:  "Wagon Fix", subSource:  0, externalParams:  0, doTrack:  true);
        this.eventProgress.IsWagonBroken = false;
        if(this.eventProgress != 0)
        {
                return;
        }
    
    }
    public void CollectReward(int rewardAmount)
    {
        OnTheTrailEventProgress val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_4 = this.eventProgress.SavedDayProgress.DayIndex;
        val_4 = val_4 + 1;
        string val_2 = System.String.Format(format:  -1138717472, arg0:  13152256);
        val_4 = this.eventProgress;
        if(this.eventProgress != 0)
        {
            goto label_6;
        }
        
        val_4 = this.eventProgress;
        if(val_4 == 0)
        {
            goto label_7;
        }
        
        label_6:
        this.eventProgress.DaysRewarded.set_Item(index:  this.eventProgress.SavedDayProgress.DayIndex, value:  true);
        int val_3 = this.GetEventDurationInDays();
        val_3 = val_3 - 1;
        if(this.eventProgress.SavedDayProgress.DayIndex == val_3)
        {
                this.eventProgress.IsEventCompleted = true;
            this.UpdateRewardStatusToServer();
        }
        
        if(this.eventProgress != 0)
        {
                return;
        }
        
        return;
        label_7:
    }
    public void OnEventButtonPressed()
    {
        var val_3;
        var val_9;
        int val_10;
        object val_11;
        int val_1 = this.GetCurrentDay();
        System.TimeSpan val_2 = GetTimeLeftUntilEndOfDay(day:  -1138376560);
        this.RefreshLatestProgress(day:  val_1);
        if(this.eventProgress.IsWagonBroken == false)
        {
            goto label_2;
        }
        
        object val_5 = null;
        val_9 = val_5;
        val_5 = new System.Object();
        if(val_9 == 0)
        {
            goto label_3;
        }
        
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_8 = val_1;
        goto label_4;
        label_2:
        val_10 = val_1 - 1;
        if(this.eventProgress.IsWagonBroken <= val_10)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + val_10;
        if(((0 + (val_1 - 1)) + 16) == 0)
        {
            goto label_8;
        }
        
        val_11 = 1152921505040285696;
        goto label_9;
        label_3:
        mem[8] = val_1;
        label_4:
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_10 = val_3;
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_18 = this.eventProgress.DaysRewarded;
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_1C = this.Econ.Rewards;
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_20 = this.eventProgress.WagonBrokenDayProgress.CompletedLevels;
        val_10 = this.eventProgress.WagonBrokenDayProgress.DayIndex;
        if(this.eventProgress.WagonBrokenDayProgress.CompletedLevels <= val_10)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (val_10 << 2);
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_24 = (0 + (this.eventProgress.WagonBrokenDayProgress.DayIndex) << 2) + 16;
        typeof(OnTheTrailEvent.PopupUIParameters_BrokenWagon).__il2cppRuntimeField_28 = this.Econ.FixPrice;
        goto label_20;
        label_8:
        if(this.eventProgress.SavedDayProgress.CompletedLevels <= val_10)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + (val_10 << 2);
        if(this.eventProgress.SavedDayProgress.CompletedLevels != ((0 + ((val_1 - 1)) << 2) + 16))
        {
            goto label_26;
        }
        
        if(new System.Object() == 0)
        {
            goto label_27;
        }
        
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_8 = val_1;
        goto label_28;
        label_26:
        val_11 = 1152921505040232448;
        label_9:
        val_9 = val_11;
        val_11 = new System.Object();
        if(val_9 != 0)
        {
                typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_8 = val_1;
        }
        else
        {
                mem[8] = val_1;
        }
        
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_10 = val_3;
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_18 = this.eventProgress.DaysRewarded;
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_1C = this.Econ.Rewards;
        label_43:
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_20 = this.eventProgress.SavedDayProgress.CompletedLevels;
        if(this.eventProgress.SavedDayProgress.CompletedLevels <= val_10)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + (val_10 << 2);
        typeof(OnTheTrailEvent.PopupUIParameters_DayInProgress).__il2cppRuntimeField_24 = (0 + ((val_1 - 1)) << 2) + 16;
        label_20:
        (0 + ((val_1 - 1)) << 2) + 16.ShowOnTheTrailPopup(param:  433385472);
        return;
        label_27:
        mem[8] = val_1;
        label_28:
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_10 = val_3;
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_18 = this.eventProgress.DaysRewarded;
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_1C = this.Econ.Rewards;
        if(this.Econ.Rewards <= val_10)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + (val_10 << 2);
        typeof(OnTheTrailEvent.PopupUIParameters_RewardAvailable).__il2cppRuntimeField_28 = (0 + ((val_1 - 1)) << 2) + 16;
        goto label_43;
    }
    public OnTheTrailEventHandler()
    {
        this.Econ = new OnTheTrailEventEcon();
        this.eventProgress = new OnTheTrailEventProgress();
    }

}
