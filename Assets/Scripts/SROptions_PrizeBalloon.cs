using UnityEngine;
public class SROptions_PrizeBalloon : SuperLuckySROptionsParent<SROptions_PrizeBalloon>, INotifyPropertyChanged
{
    // Properties
    public bool UseNetworkPurchaser { get; set; }
    public bool ForceToShowBalloon { get; set; }
    
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
    public bool get_UseNetworkPurchaser()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGPrizeBalloonManager MonoSingleton<WGPrizeBalloonManager>::get_Instance()) != 0)
        {
                return (bool)public static WGPrizeBalloonManager MonoSingleton<WGPrizeBalloonManager>::get_Instance().__il2cppRuntimeField_C;
        }
        
        return (bool)public static WGPrizeBalloonManager MonoSingleton<WGPrizeBalloonManager>::get_Instance().__il2cppRuntimeField_C;
    }
    public void set_UseNetworkPurchaser(bool value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGPrizeBalloonManager MonoSingleton<WGPrizeBalloonManager>::get_Instance().__il2cppRuntimeField_C = value;
    }
    public bool get_ForceToShowBalloon()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGPrizeBalloonManager MonoSingleton<WGPrizeBalloonManager>::get_Instance()) != 0)
        {
                return (bool)public static WGPrizeBalloonManager MonoSingleton<WGPrizeBalloonManager>::get_Instance().__il2cppRuntimeField_D;
        }
        
        return (bool)public static WGPrizeBalloonManager MonoSingleton<WGPrizeBalloonManager>::get_Instance().__il2cppRuntimeField_D;
    }
    public void set_ForceToShowBalloon(bool value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGPrizeBalloonManager MonoSingleton<WGPrizeBalloonManager>::get_Instance().__il2cppRuntimeField_D = value;
    }
    public void CheckEligibility()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3453274960));
        SLCHUDWindow.SetupHUD(name:  -841691312, callbackfunc:  7667712);
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
    public SROptions_PrizeBalloon()
    {
    
    }

}
