using UnityEngine;
public class SROPtions_Languages : SuperLuckySROptionsParent<SROPtions_Languages>, INotifyPropertyChanged
{
    // Properties
    public string Language { get; }
    
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
    public string get_Language()
    {
        return Localization.Localize(key:  -856466640, defaultValue:  1098586544, useSingularKey:  false);
    }
    public void en()
    {
        SROPtions_Languages.LanguageClicked(sender:  1800251696);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void hi()
    {
        SROPtions_Languages.LanguageClicked(sender:  -856242560);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void eses()
    {
        SROPtions_Languages.LanguageClicked(sender:  -856130480);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void fr()
    {
        SROPtions_Languages.LanguageClicked(sender:  -1655001248);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void id()
    {
        SROPtions_Languages.LanguageClicked(sender:  1624646480);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void tr()
    {
        SROPtions_Languages.LanguageClicked(sender:  -855794400);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void tl()
    {
        SROPtions_Languages.LanguageClicked(sender:  -855682320);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void ptbr()
    {
        SROPtions_Languages.LanguageClicked(sender:  -855570240);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void de()
    {
        SROPtions_Languages.LanguageClicked(sender:  -1655001408);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void es()
    {
        SROPtions_Languages.LanguageClicked(sender:  -2101987568);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void ko()
    {
        SROPtions_Languages.LanguageClicked(sender:  -1844968560);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void pl()
    {
        SROPtions_Languages.LanguageClicked(sender:  -855122160);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void pt()
    {
        SROPtions_Languages.LanguageClicked(sender:  -855010080);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void zhTW()
    {
        SROPtions_Languages.LanguageClicked(sender:  -1844968240);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void nl()
    {
        SROPtions_Languages.LanguageClicked(sender:  -854786000);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void ru()
    {
        SROPtions_Languages.LanguageClicked(sender:  -854673920);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void ms()
    {
        SROPtions_Languages.LanguageClicked(sender:  -1778655264);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void it()
    {
        SROPtions_Languages.LanguageClicked(sender:  -854449840);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void ja()
    {
        SROPtions_Languages.LanguageClicked(sender:  -1844968640);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void th()
    {
        SROPtions_Languages.LanguageClicked(sender:  -1774524256);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public void zhCN()
    {
        SROPtions_Languages.LanguageClicked(sender:  -1844968320);
        SROPtions_Languages.NotifyPropertyChanged(propertyName:  1798542544);
    }
    public static void LanguageClicked(string sender)
    {
        var val_3 = 24918131;
        val_3 = 10709292 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(Localization.GAME_NAME == 0)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  1798542544, value:  sender);
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(Localization.GAME_NAME != null)
        {
                Localization.GAME_NAME.__unknownFiledOffset_1C = sender;
        }
        else
        {
                Localization.GAME_NAME.__unknownFiledOffset_1C = sender;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        Localization.GAME_NAME.currentLanguage = sender;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        GameBehavior val_2 = App.getBehavior;
        Localization.GAME_NAME.setLocalizedCurrency(currencyKey:  null);
    }
    public static SROPtions_Languages.Languages LanguageStringToEnum(string lang)
    {
        if((System.String.IsNullOrEmpty(value:  lang)) == true)
        {
                return;
        }
        
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(340254720)});
        object val_3 = System.Enum.Parse(enumType:  340254720, value:  lang, ignoreCase:  true);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        0 = ;
    }
    public SROPtions_Languages()
    {
    
    }

}
