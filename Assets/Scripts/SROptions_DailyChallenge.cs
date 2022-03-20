using UnityEngine;
public class SROptions_DailyChallenge : SuperLuckySROptionsParent<SROptions_DailyChallenge>, INotifyPropertyChanged
{
    // Fields
    private int days;
    private int lastPlayedDays;
    
    // Properties
    public string SetStars { get; set; }
    public int Days { get; set; }
    public bool OverrideServerTime { get; set; }
    public string LastPlayedDate { get; }
    public int DaysSincePlayed { get; set; }
    
    // Methods
    public static void NotifyPropertyChanged(string propertyName)
    {
        if((SuperLuckySROptionsParent<T>._Instance) == 0)
        {
                return;
        }
        
        goto typeof(T).__il2cppRuntimeField_EC;
    }
    public void Back()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        var val_6 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_5 = 0;
        label_4:
        val_5 = 0;
        val_6 = mem[mem[1179403735] + 0];
        val_6 = mem[1179403735] + 0;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_5 = val_5 + 1;
        val_5 = (uint)val_5 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_7 = 0;
        goto label_5;
        label_3:
        var val_2 = mem[1179403735] + 0;
        val_6 = val_6 + (((mem[1179403735] + 0) + 4) << 3);
        val_7 = val_6 + 332;
        label_5:
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_5 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_5 = (uint)val_6 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_8 = 0;
        goto label_10;
        label_8:
        var val_4 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 292;
        label_10:
        SuperLuckySROptionsController.OpenGameSpecificOptionsController();
    }
    public void set_SetStars(string value)
    {
        Player val_1 = App.Player;
        if((System.Int32.TryParse(s:  value, result: out  int val_2 = -898695708)) != false)
        {
                Player val_4 = App.Player;
            mem[132] = 2165608;
            Player val_5 = App.Player;
            0.SaveState();
        }
        
        SROptions_DailyChallenge.NotifyPropertyChanged(propertyName:  -1616768464);
    }
    public string get_SetStars()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return 132.ToString();
        }
        
        return 132.ToString();
    }
    public void Add100Stars()
    {
        var val_2;
        var val_3;
        Player val_1 = App.Player;
        if(0 != 0)
        {
                val_2 = 0;
            val_3 = 2165608;
        }
        else
        {
                val_2 = 132;
            val_3 = 2165608;
        }
        
        mem[132] = 2165708;
        SROptions_DailyChallenge.NotifyPropertyChanged(propertyName:  -1616768464);
    }
    public void Add10Stars()
    {
        var val_2;
        var val_3;
        Player val_1 = App.Player;
        if(0 != 0)
        {
                val_2 = 0;
            val_3 = 2165608;
        }
        else
        {
                val_2 = 132;
            val_3 = 2165608;
        }
        
        mem[132] = 2165618;
        SROptions_DailyChallenge.NotifyPropertyChanged(propertyName:  -1616768464);
    }
    public void ResetStars()
    {
        Player val_1 = App.Player;
        mem[132] = 0;
        SROptions_DailyChallenge.NotifyPropertyChanged(propertyName:  -1616768464);
    }
    public void Minus10Stars()
    {
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        var val_4 = 2165608;
        val_4 = val_4 - 10;
        if(val_4 >= 0)
        {
                Player val_3 = App.Player;
            0 = 2165608 - 10;
        }
        
        mem[132] = 0;
        SROptions_DailyChallenge.NotifyPropertyChanged(propertyName:  -1616768464);
    }
    public void Minute100Stars()
    {
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        var val_4 = 2165608;
        val_4 = val_4 - 100;
        if(val_4 >= 0)
        {
                Player val_3 = App.Player;
            0 = 2165608 - 100;
        }
        
        mem[132] = 0;
        SROptions_DailyChallenge.NotifyPropertyChanged(propertyName:  -1616768464);
    }
    public void GrantSunMoonWord()
    {
        var val_2;
        var val_3;
        val_2 = 0;
        WordRegion val_1 = WordRegion.instance;
        if(0 != 0)
        {
                val_3 = null;
            val_3 = null;
            val_2 = 0;
            if(((mem[1179403747] + (WGDailyChallengeWordRegion.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_3)
        {
                0 = 0;
        }
        
            val_2 = 0;
        }
        
        val_2.Hack_GrantSunMoonWord();
    }
    public void CheckLevelInfoHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3397159712));
        SLCHUDWindow.SetupHUD(name:  -897806560, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_4;
        }
        
        var val_5 = 0;
        label_6:
        if((mem[1179403735] + 0) == null)
        {
            goto label_5;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < mem[1179403825])
        {
            goto label_6;
        }
        
        label_4:
        val_5 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_5:
        var val_4 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_5 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void CheckTilesInfoHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3397272864));
        SLCHUDWindow.SetupHUD(name:  -897693408, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_4;
        }
        
        var val_5 = 0;
        label_6:
        if((mem[1179403735] + 0) == null)
        {
            goto label_5;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < mem[1179403825])
        {
            goto label_6;
        }
        
        label_4:
        val_5 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_5:
        var val_4 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_5 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public int get_Days()
    {
        return (int)this.days;
    }
    public void set_Days(int value)
    {
        this.days = value;
        SROptions_DailyChallenge.NotifyPropertyChanged(propertyName:  -897469280);
    }
    public void CompleteWithFullStars()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_FillStars(days:  this.days);
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_5;
        }
        
        var val_4 = 0;
        label_7:
        if((mem[1179403735] + 0) == null)
        {
            goto label_6;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_7;
        }
        
        label_5:
        val_4 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_6:
        var val_3 = mem[1179403735] + 0;
        var val_5 = (mem[1179403735] + 0) + 4;
        val_5 = 1179403647 + (val_5 << 3);
        val_4 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void ResetMonthTile()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_ResetMonthTileOnServer();
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_5;
        }
        
        var val_4 = 0;
        label_7:
        if((mem[1179403735] + 0) == null)
        {
            goto label_6;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_7;
        }
        
        label_5:
        val_4 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_6:
        var val_3 = mem[1179403735] + 0;
        var val_5 = (mem[1179403735] + 0) + 4;
        val_5 = 1179403647 + (val_5 << 3);
        val_4 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void HackMonthTileCollection()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_MonthTileCollection();
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_5;
        }
        
        var val_4 = 0;
        label_7:
        if((mem[1179403735] + 0) == null)
        {
            goto label_6;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_7;
        }
        
        label_5:
        val_4 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_6:
        var val_3 = mem[1179403735] + 0;
        var val_5 = (mem[1179403735] + 0) + 4;
        val_5 = 1179403647 + (val_5 << 3);
        val_4 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void HackThisMonthStars()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_CompleteMonthStars();
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_5;
        }
        
        var val_4 = 0;
        label_7:
        if((mem[1179403735] + 0) == null)
        {
            goto label_6;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_7;
        }
        
        label_5:
        val_4 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_6:
        var val_3 = mem[1179403735] + 0;
        var val_5 = (mem[1179403735] + 0) + 4;
        val_5 = 1179403647 + (val_5 << 3);
        val_4 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void HackThisWeekStars()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_CompleteWeekStars();
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_5;
        }
        
        var val_4 = 0;
        label_7:
        if((mem[1179403735] + 0) == null)
        {
            goto label_6;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_7;
        }
        
        label_5:
        val_4 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_6:
        var val_3 = mem[1179403735] + 0;
        var val_5 = (mem[1179403735] + 0) + 4;
        val_5 = 1179403647 + (val_5 << 3);
        val_4 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public bool get_OverrideServerTime()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = 0;
        if((-2116505760) == 0)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_80) != 0)
        {
                val_4 = 1;
        }
        
        return true;
    }
    public void set_OverrideServerTime(bool value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_80 = value;
    }
    public void ResetDailyChallenge()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_ResetDailyChallenge();
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_5;
        }
        
        var val_4 = 0;
        label_7:
        if((mem[1179403735] + 0) == null)
        {
            goto label_6;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_7;
        }
        
        label_5:
        val_4 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_6:
        var val_3 = mem[1179403735] + 0;
        var val_5 = (mem[1179403735] + 0) + 4;
        val_5 = 1179403647 + (val_5 << 3);
        val_4 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public string get_LastPlayedDate()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_2 = LastPlayedDailyChallenge;
        string val_3 = ???.ToString();
    }
    public int get_DaysSincePlayed()
    {
        return (int)this.lastPlayedDays;
    }
    public void set_DaysSincePlayed(int value)
    {
        this.lastPlayedDays = value;
        SROptions_DailyChallenge.NotifyPropertyChanged(propertyName:  -896237200);
    }
    public void SetLastPlayedTime()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_2 = DateTimeCheat.Now;
        System.DateTime val_5 = AddDays(value:  null);
        LastPlayedDailyChallenge = new System.DateTime() {dateData = 1152921512300668544};
        SROptions_DailyChallenge.NotifyPropertyChanged(propertyName:  -896125088);
    }
    public void ResetLastPlayTime()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_ResetLastPlayedTime();
        SROptions_DailyChallenge.NotifyPropertyChanged(propertyName:  -896125088);
    }
    public SROptions_DailyChallenge()
    {
        this.days = 7;
        this.lastPlayedDays = 29;
    }

}
