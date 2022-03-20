using UnityEngine;
public sealed class WordGameEventsController.ProxyEventTrackingDelegate : MulticastDelegate
{
    // Methods
    public WordGameEventsController.ProxyEventTrackingDelegate(object object, IntPtr method)
    {
        mem[1152921511930965384] = method;
        mem[1152921511930965392] = object;
        mem[1152921511930965396] = method;
    }
    public virtual object Invoke(ref System.Collections.Generic.Dictionary<string, object> trackingData)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        if(this != 0)
        {
                if(R4 == 0)
        {
                return;
        }
        
            val_7 = 1152921511931085504;
        }
        else
        {
                val_6 = 1;
        }
        
        var val_10 = 0;
        goto label_29;
        label_21:
        if(1152921511931117480 == 0)
        {
            goto label_4;
        }
        
        Spine.Animation val_1 = R6.Current;
        if((R7 + 178) == 0)
        {
            goto label_5;
        }
        
        val_8 = 0;
        label_7:
        if((R7 + 88 + 0) == R6)
        {
            goto label_6;
        }
        
        val_8 = val_8 + 1;
        if(((uint)val_8 & 65535) < (R7 + 178))
        {
            goto label_7;
        }
        
        label_5:
        val_9 = R7;
        goto label_27;
        label_22:
        var val_5 = (val_8 + 1) + 40;
        val_5 = R7 + (val_5 << 3);
        val_10 = mem[(R7 + ((val_8 + 1) + 40) << 3) + 192];
        val_10 = (R7 + ((val_8 + 1) + 40) << 3) + 192;
        goto label_27;
        label_4:
        var val_6 = R7;
        val_6 = val_6 + ((R6 + 40) << 3);
        goto label_27;
        label_24:
        var val_2 = R5 + (((R7 + (R6 + 40) << 3) + 188) << 3);
        var val_7 = (R5 + ((R7 + (R6 + 40) << 3) + 188) << 3) + 4;
        val_7 = val_7 + (R6 + 40);
        val_7 = ((R7 + (R6 + 40) << 3) + 192) + (val_7 << 3);
        val_7 = val_7 + 188;
        label_26:
        val_10 = mem[(((R7 + (R6 + 40) << 3) + 192 + (((R5 + ((R7 + (R6 + 40) << 3) + 188) << 3) + 4 + R6 + 40)) << 3) + 188) + 4];
        val_10 = (((R7 + (R6 + 40) << 3) + 192 + (((R5 + ((R7 + (R6 + 40) << 3) + 188) << 3) + 4 + R6 + 40)) << 3) + 188) + 4;
        goto label_27;
        label_6:
        var val_3 = (R7 + 88) + 0;
        var val_8 = (R7 + 88 + 0) + 4;
        val_8 = val_8 + (R6 + 40);
        val_8 = R7 + (val_8 << 3);
        val_9 = val_8 + 188;
        goto label_27;
        label_29:
        val_8 = mem[1152921511931085508];
        if(val_8 == 0)
        {
            goto label_14;
        }
        
        if((mem[1152921511931085508] + 42) != 1)
        {
            goto label_27;
        }
        
        goto label_28;
        label_14:
        if(mem[1152921511931085504] == 0)
        {
            goto label_17;
        }
        
        if((((mem[1152921511931085508] + 40) == 65535) || ((mem[1152921511931085504] + 157) != 1)) || (mem[1152921511931085500] == 0))
        {
            goto label_27;
        }
        
        if(val_8 == 0)
        {
            goto label_21;
        }
        
        if(val_8 == 0)
        {
            goto label_22;
        }
        
        if((mem[1152921511931085504] + 178) == 0)
        {
            goto label_26;
        }
        
        var val_9 = 0;
        label_25:
        if((mem[1152921511931085504] + 88 + 0) == (mem[1152921511931085508] + 12))
        {
            goto label_24;
        }
        
        val_9 = val_9 + 1;
        if(((uint)val_9 & 65535) < (mem[1152921511931085504] + 178))
        {
            goto label_25;
        }
        
        goto label_26;
        label_17:
        Spine.Animation val_4 = val_8.Current;
        label_28:
        label_27:
        val_10 = val_10 + 1;
        if(val_10 != val_6)
        {
            goto label_29;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(ref System.Collections.Generic.Dictionary<string, object> trackingData, System.AsyncCallback callback, object object)
    {
    
    }
    public virtual object EndInvoke(ref System.Collections.Generic.Dictionary<string, object> trackingData, System.IAsyncResult result)
    {
    
    }

}
