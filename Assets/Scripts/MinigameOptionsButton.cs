using UnityEngine;
public class MinigameOptionsButton : SuperLuckySROptionsParent<MinigameOptionsButton>, INotifyPropertyChanged
{
    // Methods
    public void MinigamesHacks()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_10 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_9 = 0;
        label_4:
        val_9 = 0;
        val_10 = mem[mem[1179403735] + 0];
        val_10 = mem[1179403735] + 0;
        if(val_10 == null)
        {
            goto label_3;
        }
        
        val_9 = val_9 + 1;
        val_9 = (uint)val_9 & 65535;
        if(val_9 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_11 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_10 = val_10 + (((mem[1179403735] + 0) + 4) << 3);
        val_11 = val_10 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_11 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_10 = 0;
        label_9:
        val_9 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_10 = val_10 + 1;
        val_9 = (uint)val_10 & 65535;
        if(val_9 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_12 = 0;
        goto label_10;
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_11 = val_11 + (((mem[1179403735] + 0) + 4) << 3);
        val_12 = val_11 + 292;
        label_10:
        SRDebugger.Services.IDebugService val_6 = SRDebug.Instance;
        object val_7 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_12 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_12;
        }
        
        val_9 = 0;
        label_14:
        val_10 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_13;
        }
        
        val_9 = val_9 + 1;
        val_10 = (uint)val_9 & 65535;
        if(val_10 < mem[1179403825])
        {
            goto label_14;
        }
        
        label_12:
        val_13 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_13:
        var val_8 = mem[1179403735] + 0;
        val_12 = val_12 + (((mem[1179403735] + 0) + 4) << 3);
        val_13 = val_12 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public MinigameOptionsButton()
    {
    
    }

}
