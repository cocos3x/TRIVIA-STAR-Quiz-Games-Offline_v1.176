using UnityEngine;
public class SRDebuggerShortcuts : MonoBehaviour
{
    // Fields
    private static SRDebuggerShortcuts.PinnedCheats pinnedCheats;
    
    // Methods
    public static void AddDebug()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-902550112) != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  -793099424);
        object val_4 = AddComponent<System.Object>();
    }
    public static void ShowDebugPanel()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        var val_7 = 1179403647;
        val_7 = 1152921505026121728;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        val_8 = mem[1179403735];
        var val_6 = 0;
        label_4:
        val_9 = 0;
        val_10 = mem[mem[1179403735] + 0];
        val_10 = mem[1179403735] + 0;
        if(val_10 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_9 = (uint)val_6 & 65535;
        if(val_9 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_11 = 0;
        goto label_5;
        label_3:
        var val_2 = val_8 + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_11 = val_7 + 196;
        label_5:
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        val_12 = 0;
        val_13 = 1179403647;
        if(0 == 0)
        {
            goto label_7;
        }
        
        if(mem[1179403825] == 0)
        {
            goto label_8;
        }
        
        val_8 = mem[1179403735];
        val_14 = 0;
        label_10:
        val_15 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_9;
        }
        
        val_14 = val_14 + 1;
        val_15 = (uint)val_14 & 65535;
        if(val_15 < mem[1179403825])
        {
            goto label_10;
        }
        
        label_8:
        val_16 = val_12;
        goto label_11;
        label_7:
        if(mem[1179403825] == 0)
        {
            goto label_12;
        }
        
        val_8 = mem[1179403735];
        val_17 = 0;
        label_14:
        val_18 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_13;
        }
        
        val_17 = val_17 + 1;
        val_18 = (uint)val_17 & 65535;
        if(val_18 < mem[1179403825])
        {
            goto label_14;
        }
        
        label_12:
        val_19 = val_12;
        goto ((val_13 + ((mem[1179403735] + (R7) << 3) + 4) << 3) + 252);
        label_9:
        var val_4 = val_8 + 0;
        val_13 = val_13 + (((mem[1179403735] + 0) + 4) << 3);
        val_16 = val_13 + 268;
        label_11:
        val_13 = val_12;
        goto ((val_13 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_13:
        var val_5 = val_8 + ((R7) << 3);
        val_13 = val_13 + (((mem[1179403735] + (R7) << 3) + 4) << 3);
        val_19 = val_13 + 252;
        goto ((val_13 + ((mem[1179403735] + (R7) << 3) + 4) << 3) + 252);
    }
    public static void ToggleAllReelCheats()
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        float val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        val_19 = 1152921504948805632;
        val_20 = null;
        val_20 = null;
        if(SRDebuggerShortcuts.pinnedCheats == 0)
        {
            goto label_3;
        }
        
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        var val_19 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_5;
        }
        
        var val_18 = 0;
        label_7:
        val_21 = 0;
        val_22 = mem[mem[1179403735] + 0];
        val_22 = mem[1179403735] + 0;
        if(val_22 == null)
        {
            goto label_6;
        }
        
        val_18 = val_18 + 1;
        val_22 = (uint)val_18 & 65535;
        if(val_22 < mem[1179403825])
        {
            goto label_7;
        }
        
        label_5:
        val_23 = 0;
        goto label_8;
        label_3:
        UnityEngine.Debug.Log(message:  -792874240);
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        val_24 = 0;
        object val_3 = SuperLuckySROptionsParent<System.Object>.Instance;
        val_25 = public static SuperLuckySROptionsMain SuperLuckySROptionsParent<SuperLuckySROptionsMain>::get_Instance();
        val_26 = 1179403647;
        val_27 = 1152921505026121728;
        if(mem[1179403825] == 0)
        {
            goto label_12;
        }
        
        val_28 = mem[1179403735];
        val_29 = 0;
        label_14:
        val_30 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_13;
        }
        
        val_29 = val_29 + 1;
        val_30 = (uint)val_29 & 65535;
        if(val_30 < mem[1179403825])
        {
            goto label_14;
        }
        
        label_12:
        val_31 = val_24;
        goto label_15;
        label_6:
        var val_4 = mem[1179403735] + 0;
        val_19 = val_19 + (((mem[1179403735] + 0) + 4) << 3);
        val_23 = val_19 + 332;
        label_8:
        val_32 = null;
        val_32 = null;
        SRDebuggerShortcuts.pinnedCheats = 0;
        SRDebugger.Services.IDebugService val_5 = SRDebug.Instance;
        object val_6 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_20 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_19;
        }
        
        val_21 = 0;
        label_21:
        val_22 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_20;
        }
        
        val_21 = val_21 + 1;
        val_22 = (uint)val_21 & 65535;
        if(val_22 < mem[1179403825])
        {
            goto label_21;
        }
        
        label_19:
        val_33 = 0;
        goto label_22;
        label_20:
        var val_7 = mem[1179403735] + 0;
        val_20 = val_20 + (((mem[1179403735] + 0) + 4) << 3);
        val_33 = val_20 + 292;
        label_22:
        SRDebugger.Services.IDebugService val_8 = SRDebug.Instance;
        object val_9 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_21 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_24;
        }
        
        val_22 = 0;
        label_26:
        val_21 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_25;
        }
        
        val_22 = val_22 + 1;
        val_21 = (uint)val_22 & 65535;
        if(val_21 < mem[1179403825])
        {
            goto label_26;
        }
        
        label_24:
        val_34 = 0;
        goto label_27;
        label_25:
        var val_10 = mem[1179403735] + 0;
        val_21 = val_21 + (((mem[1179403735] + 0) + 4) << 3);
        val_34 = val_21 + 284;
        label_27:
        val_28 = mem[((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 284)];
        val_28 = val_34;
        val_26 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 284);
        label_13:
        var val_11 = val_28 + ((R7) << 3);
        val_26 = val_26 + (((((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 284) + (R7) << 3) + 4) << 3);
        val_31 = val_26 + 292;
        label_15:
        SRDebugger.Services.IDebugService val_12 = SRDebug.Instance;
        object val_13 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_22 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_29;
        }
        
        val_29 = 0;
        label_31:
        val_30 = 0;
        if((mem[1179403735] + 0) == SB)
        {
            goto label_30;
        }
        
        val_29 = val_29 + 1;
        val_30 = (uint)val_29 & 65535;
        if(val_30 < mem[1179403825])
        {
            goto label_31;
        }
        
        label_29:
        val_35 = 0;
        goto label_32;
        label_30:
        var val_14 = mem[1179403735] + 0;
        val_22 = val_22 + (((mem[1179403735] + 0) + 4) << 3);
        val_35 = val_22 + 284;
        label_32:
        SRDebugger.Services.IDebugService val_15 = SRDebug.Instance;
        var val_23 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_34;
        }
        
        val_30 = 0;
        label_36:
        val_29 = 0;
        if((mem[1179403735] + 0) == SB)
        {
            goto label_35;
        }
        
        val_30 = val_30 + 1;
        val_29 = (uint)val_30 & 65535;
        if(val_29 < mem[1179403825])
        {
            goto label_36;
        }
        
        label_34:
        val_36 = 0;
        goto label_37;
        label_35:
        var val_16 = mem[1179403735] + 0;
        val_23 = val_23 + (((mem[1179403735] + 0) + 4) << 3);
        val_36 = val_23 + 300;
        label_37:
        val_37 = mem[R8];
        val_37 = R8;
        if((((R8 + 187) & 2) == 0) && ((R8 + 116) == 0))
        {
                val_37 = mem[R8];
            val_37 = R8;
        }
        
        mem2[0] = 2;
        var val_17 = FP - 28;
    }
    public SRDebuggerShortcuts()
    {
    
    }
    private static SRDebuggerShortcuts()
    {
    
    }

}
