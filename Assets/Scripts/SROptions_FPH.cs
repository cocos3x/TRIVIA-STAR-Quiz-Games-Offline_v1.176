using UnityEngine;
public class SROptions_FPH : SuperLuckySROptionsParent<SROptions_FPH>, INotifyPropertyChanged
{
    // Fields
    private bool isDebugBannerShown;
    
    // Properties
    public bool DisplayCardValue { get; set; }
    public bool Show { get; set; }
    
    // Methods
    public static void NotifyPropertyChanged(string propertyName)
    {
        if((SuperLuckySROptionsParent<T>._Instance) == 0)
        {
                return;
        }
        
        goto typeof(T).__il2cppRuntimeField_EC;
    }
    public bool get_DisplayCardValue()
    {
        return CPlayerPrefs.GetBool(key:  -1626825024, defaultValue:  false);
    }
    public void set_DisplayCardValue(bool value)
    {
        CPlayerPrefs.SetBool(key:  -1626825024, value:  value);
    }
    public void CompleteLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void CompleteChapter()
    {
        GameBehavior val_1 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void RestartLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void General()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void PlayerCheats()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void DateTime()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void Store()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void Ads()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void DailyBonus()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void DisplayLevelInfo()
    {
        var val_6;
        System.Func<TRVQuizProgress> val_7;
        var val_8;
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_6 == 1)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_1 = System.String.Format(format:  -902550224, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3392418208));
        SLCHUDWindow.SetupHUD(name:  -902550224, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_10;
        }
        
        val_7 = 0;
        label_12:
        if((mem[1179403735] + 0) == null)
        {
            goto label_11;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < mem[1179403825])
        {
            goto label_12;
        }
        
        label_10:
        val_8 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_11:
        var val_5 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_8 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void ShowEventHacks()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void GenericUIs()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public bool get_Show()
    {
        return (bool)this.isDebugBannerShown;
    }
    public void set_Show(bool value)
    {
        this.isDebugBannerShown = value;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -901875952);
    }
    public void Locales()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public SROptions_FPH()
    {
        this.isDebugBannerShown = true;
    }

}
