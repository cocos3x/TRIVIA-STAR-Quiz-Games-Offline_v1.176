using UnityEngine;
public sealed class AnimationState.TrackEntryDelegate : MulticastDelegate
{
    // Methods
    public AnimationState.TrackEntryDelegate(object object, IntPtr method)
    {
        mem[1152921510773669352] = method;
        mem[1152921510773669360] = object;
        mem[1152921510773669364] = method;
    }
    public virtual void Invoke(Spine.TrackEntry trackEntry)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        object val_19;
        var val_20;
        if(this != 0)
        {
                if(R8 == 0)
        {
                return;
        }
        
            val_14 = 1152921510773789552;
        }
        else
        {
                val_13 = 1;
        }
        
        var val_18 = 0;
        Spine.TrackEntry val_1 = trackEntry - 8;
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
        val_16 = trackEntry;
        goto label_45;
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
        val_18 = trackEntry;
        goto label_45;
        label_7:
        var val_13 = R7 + 40;
        val_13 = 1152921504870105088 + (val_13 << 3);
        val_19 = mem[(1152921504870105088 + (R7 + 40) << 3) + 192];
        goto label_45;
        label_12:
        Spine.TrackEntry val_4 = 1152921504870105088 + (val_15 << 3);
        val_19 = mem[(1152921504870105088 + (R7 + 40) << 3) + 192];
        goto label_45;
        label_39:
        if((trackEntry.Equals(obj:  val_19)) == false)
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
        val_20 = val_15;
        goto label_45;
        label_40:
        var val_14 = (val_17 + 1) + 40;
        val_14 = val_15 + (val_14 << 3);
        goto label_45;
        label_19:
        var val_15 = val_15;
        val_15 = val_15 + ((R7 + 40) << 3);
        goto label_45;
        label_21:
        var val_11 = (R7 + 40 + 88) + 0;
        var val_16 = (R7 + 40 + 88 + 0) + 4;
        val_16 = val_16 + (R7 + 40);
        val_16 = val_15 + (val_16 << 3);
        val_20 = val_16 + 188;
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
        
        goto label_45;
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
            goto label_45;
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
            goto label_45;
        }
        
        var val_17 = 0;
        do
        {
            if((R6 + 88 + 0) == (R7 + 12))
        {
            goto label_45;
        }
        
            val_17 = val_17 + 1;
        }
        while(((uint)val_17 & 65535) < (R6 + 178));
        
        goto label_45;
        label_34:
        if((R7 + 40) != 0)
        {
            goto label_46;
        }
        
        label_32:
        label_45:
        val_18 = val_18 + 1;
        if(val_18 != val_13)
        {
            goto label_47;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(Spine.TrackEntry trackEntry, System.AsyncCallback callback, object object)
    {
    
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
