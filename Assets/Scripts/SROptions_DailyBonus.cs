using UnityEngine;
public class SROptions_DailyBonus : SuperLuckySROptionsParent<SROptions_DailyBonus>, INotifyPropertyChanged
{
    // Fields
    private System.DateTime daily_bonus_last_collect_time;
    
    // Properties
    public string LastCollect_LocalTime { get; }
    
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
    public string get_LastCollect_LocalTime()
    {
        System.DateTime val_5;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = this.daily_bonus_last_collect_time}, d2:  new System.DateTime())) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.DateTime val_3 = GetLastCollectTime();
            this.daily_bonus_last_collect_time = val_5;
        }
        
        string val_6 = this.daily_bonus_last_collect_time.ToString();
    }
    public void ForceUpdateLastCollectTime()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1146476848) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        1152921504901095424 = this.daily_bonus_last_collect_time;
        ForceUpdateLastCollectTime(time:  new System.DateTime() {dateData = MonoSingleton<T>.__il2cppRuntimeField_cctor_finished});
    }
    public void Add1Day()
    {
        this.AddDays(amount:  1);
    }
    public void Sub1Day()
    {
        this.AddDays(amount:  0);
    }
    public void Add1h()
    {
        this.AddSeconds(amount:  3600);
    }
    public void SubSeconds1h()
    {
        this.AddSeconds(amount:  -3600);
    }
    public void AddSeconds10m()
    {
        this.AddSeconds(amount:  600);
    }
    public void SubSeconds10m()
    {
        this.AddSeconds(amount:  -600);
    }
    private void AddDays(int amount)
    {
        System.DateTime val_3;
        System.DateTime val_1 = AddDays(value:  null);
        this.daily_bonus_last_collect_time = val_3;
        SROptions_DailyBonus.NotifyPropertyChanged(propertyName:  -899281104);
    }
    private void AddSeconds(int amount)
    {
        System.DateTime val_3;
        System.DateTime val_1 = AddSeconds(value:  null);
        this.daily_bonus_last_collect_time = val_3;
        SROptions_DailyBonus.NotifyPropertyChanged(propertyName:  -899281104);
    }
    public SROptions_DailyBonus()
    {
    
    }

}
