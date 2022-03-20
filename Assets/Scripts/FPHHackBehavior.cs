using UnityEngine;
public class FPHHackBehavior : HackBehavior
{
    // Methods
    public override SROptions GetGameSpecificSROptions()
    {
        return SuperLuckySROptionsParent<System.Object>.Instance;
    }
    public override void AppendGameLevelInfo(ref System.Text.StringBuilder builder)
    {
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        if(303034368 != 0)
        {
                FPHGameplayController val_3 = FPHGameplayController.Instance;
            GameEcon val_4 = App.getGameEcon;
            FPHPlayer val_5 = FPHPlayer.Instance;
            FPHGameplayController val_6 = FPHGameplayController.Instance;
            System.Text.StringBuilder val_7 = builder.Append(value:  -770981136);
            string val_8 = 0.SuccessPercentageStandardModeString;
            System.Text.StringBuilder val_9 = builder.AppendFormat(format:  -770981024, arg0:  0);
            GameBehavior val_10 = App.getBehavior;
            System.Text.StringBuilder val_11 = builder.AppendFormat(format:  -770980896, arg0:  13152256);
            System.Text.StringBuilder val_12 = builder.AppendFormat(format:  -770980736, arg0:  .__il2cppRuntimeField_8 + 8);
            System.Text.StringBuilder val_13 = builder.AppendFormat(format:  -770980624, arg0:  .__il2cppRuntimeField_8 + 16);
            System.Text.StringBuilder val_14 = builder.AppendFormat(format:  -770980512, arg0:  .__il2cppRuntimeField_8 + 20);
            System.Text.StringBuilder val_15 = builder.AppendFormat(format:  -770980400, arg0:  13152256);
            return;
        }
        
        System.Text.StringBuilder val_16 = builder.AppendLine(value:  -770980256);
    }
    public override void Hack_CompleteLevelBehavior()
    {
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
            goto label_5;
        }
        
        FPHGameplayController val_2 = FPHGameplayController.Instance;
        Hack_CompleteLevel();
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_10;
        }
        
        var val_5 = 0;
        label_12:
        if((mem[1179403735] + 0) == null)
        {
            goto label_11;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < mem[1179403825])
        {
            goto label_12;
        }
        
        label_10:
        val_5 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_5:
        UnityEngine.Debug.Log(message:  -903446352);
        return;
        label_11:
        var val_4 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_5 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public override void Hack_CompleteChapterBehavior()
    {
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
            goto label_5;
        }
        
        FPHGameplayController val_2 = FPHGameplayController.Instance;
        Hack_CompleteChapter();
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_10;
        }
        
        var val_5 = 0;
        label_12:
        if((mem[1179403735] + 0) == null)
        {
            goto label_11;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < mem[1179403825])
        {
            goto label_12;
        }
        
        label_10:
        val_5 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_5:
        UnityEngine.Debug.Log(message:  -903446352);
        return;
        label_11:
        var val_4 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_5 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public FPHHackBehavior()
    {
    
    }

}
