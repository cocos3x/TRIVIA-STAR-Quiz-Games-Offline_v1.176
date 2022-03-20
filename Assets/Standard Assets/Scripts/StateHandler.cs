using UnityEngine;
private sealed class Lexer.StateHandler : MulticastDelegate
{
    // Methods
    public Lexer.StateHandler(object object, IntPtr method)
    {
        mem[1152921510998289032] = method;
        mem[1152921510998289040] = object;
        mem[1152921510998289044] = method;
    }
    public virtual bool Invoke(LitJson.FsmContext ctx)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        object val_19;
        var val_20;
        var val_21;
        if(this == 0)
        {
            goto label_0;
        }
        
        if(R8 == 0)
        {
            goto label_1;
        }
        
        val_14 = 1152921510998409232;
        goto label_2;
        label_0:
        val_13 = 1;
        label_2:
        var val_18 = 0;
        LitJson.FsmContext val_1 = ctx - 8;
        goto label_47;
        label_35:
        Spine.Animation val_2 = R7.Current;
        if(R7 == 0)
        {
            goto label_32;
        }
        
        goto label_32;
        label_46:
        val_15 = R7;
        if(val_15 == 0)
        {
            goto label_6;
        }
        
        if(R7 == 0)
        {
            goto label_7;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_16 = ctx;
        goto label_26;
        label_6:
        val_15 = mem[R7 + 40];
        val_15 = R7 + 40;
        if(R7 == 0)
        {
            goto label_12;
        }
        
        Spine.Animation val_3 = R7.Current;
        val_17 = 0;
        val_17 = val_17 + 1;
        val_18 = ctx;
        goto label_16;
        label_7:
        var val_13 = R7 + 40;
        val_13 = 1152921504879050752 + (val_13 << 3);
        val_19 = mem[(1152921504879050752 + (R7 + 40) << 3) + 192];
        goto label_45;
        label_12:
        LitJson.FsmContext val_4 = 1152921504879050752 + (val_15 << 3);
        val_19 = mem[(1152921504879050752 + (R7 + 40) << 3) + 192];
        goto label_45;
        label_39:
        if((ctx.Equals(obj:  val_19)) == false)
        {
            goto label_19;
        }
        
        Spine.Animation val_6 = R7.Current;
        if((R7 + 40 + 178) == 0)
        {
            goto label_20;
        }
        
        val_17 = 0;
        label_22:
        if((R7 + 40 + 88 + 0) == R7)
        {
            goto label_21;
        }
        
        val_17 = val_17 + 1;
        if(((uint)val_17 & 65535) < (R7 + 40 + 178))
        {
            goto label_22;
        }
        
        label_20:
        val_21 = val_15;
        goto label_23;
        label_40:
        var val_14 = (val_17 + 1) + 40;
        val_14 = val_15 + (val_14 << 3);
        goto label_24;
        label_19:
        var val_15 = val_15;
        val_15 = val_15 + ((R7 + 40) << 3);
        label_24:
        val_20 = val_15;
        goto label_45;
        label_16:
        label_26:
        val_20 = ctx;
        goto label_45;
        label_21:
        var val_11 = (R7 + 40 + 88) + 0;
        var val_16 = (R7 + 40 + 88 + 0) + 4;
        val_16 = val_16 + (R7 + 40);
        val_16 = val_15 + (val_16 << 3);
        val_21 = val_16 + 188;
        label_23:
        label_28:
        val_20 = val_15;
        goto label_45;
        label_47:
        if(R7 == 0)
        {
            goto label_31;
        }
        
        if((R7 + 42) == 1)
        {
            goto label_32;
        }
        
        goto label_38;
        label_31:
        if((R7 + 42) != 1)
        {
            goto label_34;
        }
        
        if(R6 == 0)
        {
            goto label_35;
        }
        
        if((((R7 + 40) == 65535) || ((R6 + 157) != 1)) || ((R6 + 157) == 0))
        {
            goto label_38;
        }
        
        if(R7 == 0)
        {
            goto label_39;
        }
        
        if(R7 == 0)
        {
            goto label_40;
        }
        
        if((R6 + 178) == 0)
        {
            goto label_28;
        }
        
        var val_17 = 0;
        do
        {
            if((R6 + 88 + 0) == (R7 + 12))
        {
            goto label_28;
        }
        
            val_17 = val_17 + 1;
        }
        while(((uint)val_17 & 65535) < (R6 + 178));
        
        goto label_28;
        label_38:
        val_20 = R6;
        goto label_45;
        label_34:
        if((R7 + 40) != 0)
        {
            goto label_46;
        }
        
        label_32:
        val_20 = ctx;
        label_45:
        val_18 = val_18 + 1;
        if(val_18 != val_13)
        {
            goto label_47;
        }
        
        return (bool)val_20;
        label_1:
        val_20 = 0;
        return (bool)val_20;
    }
    public virtual System.IAsyncResult BeginInvoke(LitJson.FsmContext ctx, System.AsyncCallback callback, object object)
    {
    
    }
    public virtual bool EndInvoke(System.IAsyncResult result)
    {
        result.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        return (bool)null;
    }

}
