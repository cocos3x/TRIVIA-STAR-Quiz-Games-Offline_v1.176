using UnityEngine;
public sealed class AnimationState.TrackEntryEventDelegate : MulticastDelegate
{
    // Methods
    public AnimationState.TrackEntryEventDelegate(object object, IntPtr method)
    {
        mem[1152921510774166504] = method;
        mem[1152921510774166512] = object;
        mem[1152921510774166516] = method;
    }
    public virtual void Invoke(Spine.TrackEntry trackEntry, Spine.Event e)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        if(this != 0)
        {
                if(trackEntry == 0)
        {
                return;
        }
        
            val_14 = 1152921510774290800;
        }
        
        Spine.Event val_1 = e - 8;
        var val_22 = 0;
        Spine.TrackEntry val_2 = trackEntry - 8;
        goto label_49;
        label_44:
        val_15 = R7;
        if(val_15 == 0)
        {
            goto label_4;
        }
        
        if(R7 == 0)
        {
            goto label_5;
        }
        
        val_16 = e;
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_17 = trackEntry;
        goto label_43;
        label_4:
        val_15 = mem[R7 + 40];
        val_15 = R7 + 40;
        if(R7 == 0)
        {
            goto label_10;
        }
        
        Spine.Animation val_3 = R7.Current;
        val_18 = 0;
        val_18 = val_18 + 1;
        val_19 = trackEntry;
        goto label_14;
        label_5:
        var val_14 = R7 + 40;
        val_14 = 1152921504870105088 + (val_14 << 3);
        goto label_43;
        label_10:
        Spine.TrackEntry val_4 = 1152921504870105088 + (val_15 << 3);
        goto label_43;
        label_37:
        val_16 = mem[R7 + 40];
        val_16 = R7 + 40;
        if((trackEntry.Equals(obj:  e)) == false)
        {
            goto label_17;
        }
        
        Spine.Animation val_6 = R7.Current;
        var val_20 = val_15;
        if((R7 + 40 + 178) == 0)
        {
            goto label_18;
        }
        
        var val_15 = 0;
        label_20:
        if((R7 + 40 + 88 + 0) == R7)
        {
            goto label_19;
        }
        
        val_15 = val_15 + 1;
        if(((uint)val_15 & 65535) < (R7 + 40 + 178))
        {
            goto label_20;
        }
        
        label_18:
        val_20 = val_15;
        goto label_43;
        label_38:
        var val_16 = (0 + 1) + 40;
        val_16 = val_15 + (val_16 << 3);
        goto label_43;
        label_17:
        var val_17 = val_15;
        val_17 = val_17 + (val_16 << 3);
        goto label_43;
        label_14:
        Spine.TrackEntry val_18 = trackEntry;
        goto label_43;
        label_40:
        val_18 = val_18 + (e << 3);
        goto label_43;
        label_19:
        var val_10 = (R7 + 40 + 88) + 0;
        var val_19 = (R7 + 40 + 88 + 0) + 4;
        val_19 = val_19 + val_16;
        val_20 = val_20 + (val_19 << 3);
        val_20 = val_20 + 188;
        goto label_43;
        label_49:
        if(R7 == 0)
        {
            goto label_29;
        }
        
        if((R7 + 42) == 2)
        {
            goto label_48;
        }
        
        goto label_43;
        label_29:
        if((R7 + 42) != 2)
        {
            goto label_32;
        }
        
        if(R6 == 0)
        {
            goto label_33;
        }
        
        if((((R7 + 40) == 65535) || ((R6 + 157) != 1)) || ((R6 + 157) == 0))
        {
            goto label_43;
        }
        
        if(R7 == 0)
        {
            goto label_37;
        }
        
        if(R7 == 0)
        {
            goto label_38;
        }
        
        if((R6 + 178) == 0)
        {
            goto label_43;
        }
        
        var val_21 = 0;
        label_41:
        if((R6 + 88 + 0) == (R7 + 12))
        {
            goto label_40;
        }
        
        val_21 = val_21 + 1;
        if(((uint)val_21 & 65535) < (R6 + 178))
        {
            goto label_41;
        }
        
        goto label_43;
        label_32:
        if((R7 + 40) != 0)
        {
            goto label_44;
        }
        
        if(R6 != 0)
        {
            goto label_48;
        }
        
        Spine.Animation val_11 = R7.Current;
        if(R7 == 0)
        {
            goto label_48;
        }
        
        goto label_48;
        label_33:
        Spine.Animation val_12 = R7.Current;
        label_48:
        label_43:
        val_22 = val_22 + 1;
        if(val_22 != 1)
        {
            goto label_49;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(Spine.TrackEntry trackEntry, Spine.Event e, System.AsyncCallback callback, object object)
    {
    
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
