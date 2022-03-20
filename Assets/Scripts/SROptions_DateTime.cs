using UnityEngine;
public class SROptions_DateTime : SuperLuckySROptionsParent<SROptions_DateTime>, INotifyPropertyChanged
{
    // Properties
    public string SimulatedDate { get; }
    public float CurrentTimeScale { get; }
    
    // Methods
    public static void NotifyPropertyChanged(string propertyName)
    {
        if((propertyName.Equals(value:  -2037903248)) == false)
        {
                return;
        }
        
        SLCDateTimeDisplay.UpdateDateTimeDisplay();
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
    public string get_SimulatedDate()
    {
        System.DateTime val_1 = DateTimeCheat.GetSimulatedDateTime();
        string val_2 = ???.ToString();
    }
    public void Add21()
    {
        this.AddDays(amount:  21);
    }
    public void Add14()
    {
        this.AddDays(amount:  14);
    }
    public void Add1()
    {
        this.AddDays(amount:  1);
    }
    public void Sub21()
    {
        this.AddDays(amount:  20);
    }
    public void Sub14()
    {
        this.AddDays(amount:  13);
    }
    public void Sub1()
    {
        this.AddDays(amount:  0);
    }
    public void ResetDate()
    {
        DateTimeCheat.ResetDateStatic();
    }
    public void AddSeconds1h()
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
    public void AddSeconds15()
    {
        this.AddSeconds(amount:  15);
    }
    public void SubSeconds15()
    {
        this.AddSeconds(amount:  14);
    }
    private void AddDays(int amount)
    {
        DateTimeCheat.AddDaysStatic(daysCount:  amount, postNotification:  true);
        SROptions_DateTime.NotifyPropertyChanged(propertyName:  -2037903248);
    }
    private void AddSeconds(int amount)
    {
        DateTimeCheat.AddSecondsStatic(secondsCount:  amount, postNotification:  true);
        SROptions_DateTime.NotifyPropertyChanged(propertyName:  -2037903248);
    }
    public float get_CurrentTimeScale()
    {
        return UnityEngine.Time.timeScale;
    }
    public void TimeScale025()
    {
        UnityEngine.Time.timeScale = null;
        SROptions_DateTime.NotifyPropertyChanged(propertyName:  -893186272);
    }
    public void TimeScale05()
    {
        UnityEngine.Time.timeScale = null;
        SROptions_DateTime.NotifyPropertyChanged(propertyName:  -893186272);
    }
    public void TimeScale075()
    {
        UnityEngine.Time.timeScale = null;
        SROptions_DateTime.NotifyPropertyChanged(propertyName:  -893186272);
    }
    public void TimeScale1()
    {
        UnityEngine.Time.timeScale = null;
        SROptions_DateTime.NotifyPropertyChanged(propertyName:  -893186272);
    }
    public void TimeScale15()
    {
        UnityEngine.Time.timeScale = null;
        SROptions_DateTime.NotifyPropertyChanged(propertyName:  -893186272);
    }
    public void TimeScale2()
    {
        UnityEngine.Time.timeScale = null;
        SROptions_DateTime.NotifyPropertyChanged(propertyName:  -893186272);
    }
    public SROptions_DateTime()
    {
    
    }

}
