using UnityEngine;
public class WPTHackBehavior : HackBehavior
{
    // Methods
    public override SROptions GetGameSpecificSROptions()
    {
        return SuperLuckySROptionsParent<System.Object>.Instance;
    }
    public override void Hack_CompleteLevelBehavior()
    {
        DebugMessageDisplay.DisplayMessage(msgTxt:  -691568336, displayTime:  null);
    }
    public override void Hack_CompleteChapterBehavior()
    {
        DebugMessageDisplay.DisplayMessage(msgTxt:  -691568336, displayTime:  null);
    }
    public override void Hack_RestartLevel()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordPets.WPTGameMode val_2 = currentGame;
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_6;
        }
        
        var val_5 = 0;
        label_8:
        if((mem[1179403735] + 0) == null)
        {
            goto label_7;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < mem[1179403825])
        {
            goto label_8;
        }
        
        label_6:
        val_5 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_7:
        var val_4 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_5 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public override void AppendGameLevelInfo(ref System.Text.StringBuilder builder)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        System.Text.StringBuilder val_3 = builder.AppendFormat(format:  -691228192, arg0:  13152256);
        GameBehavior val_4 = App.getBehavior;
        if(0 <= WordPets.WPTDataParser.PREDETERMINED_LEVELS)
        {
                0 = 1;
        }
        
        System.Text.StringBuilder val_6 = builder.AppendFormat(format:  -691228016, arg0:  8945664);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordPets.WPTGameMode val_8 = currentGame;
        System.Text.StringBuilder val_9 = builder.AppendFormat(format:  -691227888, arg0:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordPets.WPTGameMode val_11 = currentGame;
        System.Text.StringBuilder val_12 = builder.AppendFormat(format:  -691227744, arg0:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordPets.WPTGameMode val_14 = currentGame;
        1152921504892043264 = null;
        System.Text.StringBuilder val_15 = builder.AppendFormat(format:  -691227616, arg0:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordPets.WPTGameMode val_17 = currentGame;
        int val_18 = public static WordPets.WordPetsController MonoSingleton<WordPets.WordPetsController>::get_Instance().__il2cppRuntimeField_C.petsRequired;
        System.Text.StringBuilder val_19 = builder.AppendFormat(format:  -691227488, arg0:  13152256);
    }
    public WPTHackBehavior()
    {
    
    }

}
