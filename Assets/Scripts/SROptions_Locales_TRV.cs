using UnityEngine;
public class SROptions_TRV.SROptions_Locales_TRV : SuperLuckySROptionsParent<SROptions_TRV.SROptions_Locales_TRV>, INotifyPropertyChanged
{
    // Properties
    public string LocaleFromDevice { get; }
    public string LocaleFromEcon { get; }
    public string LangFromLoc { get; }
    public string SupportedLocaleDisplay { get; }
    
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
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        var val_9 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_8 = 0;
        label_4:
        val_8 = 0;
        val_9 = mem[mem[1179403735] + 0];
        val_9 = mem[1179403735] + 0;
        if(val_9 == null)
        {
            goto label_3;
        }
        
        val_8 = val_8 + 1;
        val_8 = (uint)val_8 & 65535;
        if(val_8 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_10 = 0;
        goto label_5;
        label_3:
        var val_2 = mem[1179403735] + 0;
        val_9 = val_9 + (((mem[1179403735] + 0) + 4) << 3);
        val_10 = val_9 + 332;
        label_5:
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        var val_11 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        var val_10 = 0;
        label_9:
        val_8 = 0;
        val_9 = mem[mem[1179403735] + 0];
        val_9 = mem[1179403735] + 0;
        if(val_9 == null)
        {
            goto label_8;
        }
        
        val_10 = val_10 + 1;
        val_8 = (uint)val_10 & 65535;
        if(val_8 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_11 = 0;
        goto label_10;
        label_8:
        var val_4 = mem[1179403735] + 0;
        val_11 = val_11 + (((mem[1179403735] + 0) + 4) << 3);
        val_11 = val_11 + 292;
        label_10:
        SRDebugger.Services.IDebugService val_5 = SRDebug.Instance;
        object val_6 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_12 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_12;
        }
        
        val_8 = 0;
        label_14:
        val_9 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_13;
        }
        
        val_8 = val_8 + 1;
        val_9 = (uint)val_8 & 65535;
        if(val_9 < mem[1179403825])
        {
            goto label_14;
        }
        
        label_12:
        val_12 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 284);
        label_13:
        var val_7 = mem[1179403735] + 0;
        val_12 = val_12 + (((mem[1179403735] + 0) + 4) << 3);
        val_12 = val_12 + 284;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 284);
    }
    public string get_LocaleFromDevice()
    {
        return DeviceProperties.LocaleFromDevice;
    }
    public string get_LocaleFromEcon()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance()) != 0)
        {
                return QAHACK_getCurrentCagetoryEconLocale;
        }
        
        return QAHACK_getCurrentCagetoryEconLocale;
    }
    public string get_LangFromLoc()
    {
        if(Localization.GAME_NAME != null)
        {
                return;
        }
    
    }
    public void HackLocale()
    {
        string val_1 = this.LocaleFromEcon;
        string val_2 = 0.Replace(oldValue:  1359327184, newValue:  2144339952);
        bool val_4 = System.Enum.TryParse<SupportedLocales>(value:  null, result: out  SupportedLocales val_3 = -827376500);
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(357240832)});
        System.Array val_6 = System.Enum.GetValues(enumType:  357240832);
        var val_10 = Length;
        val_10 = 0 - val_10;
        if(null != 0)
        {
                val_10 = 1;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_9 = Replace(oldValue:  2144339952, newValue:  1359327184);
        QAHACK_setCurrentCategoryEcon(formattedLanguageAndLocale:  357240832);
        SROptions_TRV.SROptions_Locales_TRV.NotifyPropertyChanged(propertyName:  -889691632);
    }
    public string get_SupportedLocaleDisplay()
    {
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(357240832)});
        System.String[] val_2 = System.Enum.GetNames(enumType:  357240832);
        return PrettyPrint.printJSON(obj:  357240832, types:  false, singleLineOutput:  false);
    }
    public SROptions_TRV.SROptions_Locales_TRV()
    {
    
    }

}
