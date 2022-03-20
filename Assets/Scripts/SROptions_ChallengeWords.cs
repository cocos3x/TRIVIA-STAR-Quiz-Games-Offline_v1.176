using UnityEngine;
public class SROptions_ChallengeWords : SuperLuckySROptionsParent<SROptions_ChallengeWords>, INotifyPropertyChanged
{
    // Properties
    public bool PlayChallengeWords { get; set; }
    public bool IsChallengeLevel { get; }
    public bool IsPlaying { get; }
    public int NextChallengeLevel { get; }
    public string LastChallengeWord { get; }
    public int Cooldown { get; }
    public int Chance { get; }
    
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
    public bool get_PlayChallengeWords()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance()) != 0)
        {
                return (bool)public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_11;
        }
        
        return (bool)public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_11;
    }
    public void set_PlayChallengeWords(bool value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_11 = value;
    }
    public bool get_IsChallengeLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance()) != 0)
        {
                return (bool)public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_18;
        }
        
        return (bool)public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_18;
    }
    public bool get_IsPlaying()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance()) != 0)
        {
                return IsPlaying;
        }
        
        return IsPlaying;
    }
    public int get_NextChallengeLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance()) != 0)
        {
                return QAHACK_getProgressLevel;
        }
        
        return QAHACK_getProgressLevel;
    }
    public string get_LastChallengeWord()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance()) != 0)
        {
                return;
        }
    
    }
    public int get_Cooldown()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 32290913;
        }
        
        return 32290913;
    }
    public int get_Chance()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 12;
        }
        
        return 12;
    }
    public SROptions_ChallengeWords()
    {
    
    }

}
