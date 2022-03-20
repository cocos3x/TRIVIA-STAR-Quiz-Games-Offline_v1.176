using UnityEngine;
public class SuperLuckySROptionsController
{
    // Methods
    public static void OpenGameSpecificOptionsController()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        GameBehavior val_2 = App.getBehavior;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_6;
        }
        
        val_8 = 0;
        label_8:
        val_9 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_7;
        }
        
        val_8 = val_8 + 1;
        val_9 = (uint)val_8 & 65535;
        if(val_9 < mem[1179403825])
        {
            goto label_8;
        }
        
        label_6:
        val_10 = 0;
        goto label_9;
        label_7:
        var val_3 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_10 = val_8 + 284;
        label_9:
        AppConfigs val_4 = App.Configuration;
        if((mem[83886604] + 12) < 1)
        {
                return;
        }
        
        SRDebugger.Services.IDebugService val_5 = SRDebug.Instance;
        MinigameOptionsButton val_6 = new MinigameOptionsButton();
        var val_9 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_15;
        }
        
        val_9 = 0;
        label_17:
        val_8 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_16;
        }
        
        val_9 = val_9 + 1;
        val_8 = (uint)val_9 & 65535;
        if(val_8 < mem[1179403825])
        {
            goto label_17;
        }
        
        label_15:
        val_11 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 284);
        label_16:
        var val_7 = mem[1179403735] + 0;
        val_9 = val_9 + (((mem[1179403735] + 0) + 4) << 3);
        val_11 = val_9 + 284;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 284);
    }
    public SuperLuckySROptionsController()
    {
    
    }

}
