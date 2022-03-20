using UnityEngine;
public class SROptions_Theme : SuperLuckySROptionsParent<SROptions_Theme>, INotifyPropertyChanged
{
    // Properties
    public string CurrentTheme { get; }
    
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
    public string get_CurrentTheme()
    {
        AppConfigs val_1 = App.Configuration;
        if(0 == 0)
        {
                return;
        }
        
        ThemesHandler val_2 = App.ThemesHandler;
        if(0 != 0)
        {
                return 0.CurrentThemeName;
        }
        
        return 0.CurrentThemeName;
    }
    public void Theme_skeumorphic()
    {
        AppConfigs val_1 = App.Configuration;
        if(0 == 0)
        {
                return;
        }
        
        ThemesHandler val_2 = App.ThemesHandler;
        0.SwapTheme(swapTo:  1);
        SROptions_Theme.NotifyPropertyChanged(propertyName:  -823169552);
    }
    public void Theme_nut()
    {
        AppConfigs val_1 = App.Configuration;
        if(0 == 0)
        {
                return;
        }
        
        ThemesHandler val_2 = App.ThemesHandler;
        0.SwapTheme(swapTo:  6);
        SROptions_Theme.NotifyPropertyChanged(propertyName:  -823169552);
    }
    public SROptions_Theme()
    {
    
    }

}
