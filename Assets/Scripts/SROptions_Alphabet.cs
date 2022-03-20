using UnityEngine;
public class SROptions_Alphabet : SuperLuckySROptionsParent<SROptions_Alphabet>, INotifyPropertyChanged
{
    // Properties
    public bool AlwaysPostLevel { get; set; }
    public string CurrentTile { get; }
    public string CurrentBox { get; }
    public string CurrentProg { get; }
    public string CurrentLang { get; }
    public string CurrentCollectionIndex { get; }
    public string CurrentLevelIndex { get; }
    
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
    public void GetLetterTile()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHACK_GetTile();
        SROptions_Alphabet.NotifyPropertyChanged(propertyName:  -1569337360);
    }
    public void AddLetterTile()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHACK_AddTile();
        SROptions_Alphabet.NotifyPropertyChanged(propertyName:  -1569225264);
    }
    public void GetFullBox()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHACK_FillBoxAndCollect();
        SROptions_Alphabet.NotifyPropertyChanged(propertyName:  -1569337360);
    }
    public void GetFullCollection()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHACK_CompleteCurrentCollection();
        SROptions_Alphabet.NotifyPropertyChanged(propertyName:  -1569001168);
    }
    public bool get_AlwaysPostLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance()) != 0)
        {
                return (bool)public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_60;
        }
        
        return (bool)public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_60;
    }
    public void set_AlwaysPostLevel(bool value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_60 = value;
        SROptions_Alphabet.NotifyPropertyChanged(propertyName:  -1568777072);
    }
    public void RunSample()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHACK_SampleTileCollection();
    }
    public string get_CurrentTile()
    {
        var val_9;
        var val_10;
        val_9 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_2 = GetCurrentCollectionLetter;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = GetCurrentCollectionLetter;
        if((System.String.IsNullOrEmpty(value:  -2100700048)) != false)
        {
                val_10 = "None";
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Rarity val_7 = GetCurrentRarity();
            val_9 = null;
            val_10 = val_9;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        }
        
        string val_8 = System.String.Format(format:  -1568552960, arg0:  -2100700048, arg1:  306335744);
    }
    public string get_CurrentBox()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_2 = GetCurrentCollectionBox;
        return PrettyPrint.printJSON(obj:  -2100700048, types:  false, singleLineOutput:  false);
    }
    public string get_CurrentProg()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_2 = GetCurrentCollectionProgress;
        return PrettyPrint.printJSON(obj:  -2100700048, types:  false, singleLineOutput:  false);
    }
    public string get_CurrentLang()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    public string get_CurrentCollectionIndex()
    {
        Player val_1 = App.Player;
        return 2621448 + 264.ToString();
    }
    public string get_CurrentLevelIndex()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = GetLevelTracking();
        return PrettyPrint.printJSON(obj:  -2100700048, types:  false, singleLineOutput:  false);
    }
    public SROptions_Alphabet()
    {
    
    }

}
