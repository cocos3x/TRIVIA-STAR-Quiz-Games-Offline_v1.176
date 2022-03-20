using UnityEngine;
public class SROptions_WordIQ : SuperLuckySROptionsParent<SROptions_WordIQ>, INotifyPropertyChanged
{
    // Properties
    public string Level { get; }
    public string SetLevel { get; set; }
    
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
    public void IQGameplayHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3483587920));
        SLCHUDWindow.SetupHUD(name:  -811378352, callbackfunc:  7667712);
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
    public void IQLogicHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3483701056));
        SLCHUDWindow.SetupHUD(name:  -811265216, callbackfunc:  7667712);
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
    public void PopulatedHistoryHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3483814176));
        SLCHUDWindow.SetupHUD(name:  -811152096, callbackfunc:  7667712);
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
    public void ActualHistoryHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3483927312));
        SLCHUDWindow.SetupHUD(name:  -811038960, callbackfunc:  7667712);
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
    public string get_Level()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_2 = PlayerIQ;
        string val_3 = public static WordIQManager MonoSingleton<WordIQManager>::get_Instance().ToString();
    }
    public void AddPlayerIQ_0005()
    {
        this.AddIQPoints(iqPoints:  null);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public void AddPlayerIQ_001()
    {
        this.AddIQPoints(iqPoints:  null);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public void AddPlayerIQ_01()
    {
        this.AddIQPoints(iqPoints:  null);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public void AddPlayerIQ_1()
    {
        this.AddIQPoints(iqPoints:  null);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public void AddPlayerIQ_10()
    {
        this.AddIQPoints(iqPoints:  null);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public void AddPlayerIQ_n0005()
    {
        this.AddIQPoints(iqPoints:  null);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public void AddPlayerIQ_n001()
    {
        this.AddIQPoints(iqPoints:  null);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public void AddPlayerIQ_n01()
    {
        this.AddIQPoints(iqPoints:  null);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public void AddPlayerIQ_n1()
    {
        this.AddIQPoints(iqPoints:  null);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public void AddPlayerIQ_n10()
    {
        this.AddIQPoints(iqPoints:  null);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public void set_SetLevel(string value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_2 = PlayerIQ;
        if((System.Single.TryParse(s:  value, result: out  float val_3 = -6.351358E+09f)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_6 = PlayerIQ;
        if((public static WordIQManager MonoSingleton<WordIQManager>::get_Instance()) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_SetIQ(points:  3361248464);
        string val_8 = -809690672(-809690672) + 15282176;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -809690672, displayTime:  3361248464);
        SROptions_WordIQ.NotifyPropertyChanged(propertyName:  -810814864);
    }
    public string get_SetLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_2 = PlayerIQ;
        string val_3 = public static WordIQManager MonoSingleton<WordIQManager>::get_Instance().ToString();
    }
    private void AddIQPoints(float iqPoints)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_AddIQ(points:  iqPoints);
    }
    public SROptions_WordIQ()
    {
    
    }

}
