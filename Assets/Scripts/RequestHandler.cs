using UnityEngine;
public sealed class ApiRequester.RequestHandler : MulticastDelegate
{
    // Methods
    public ApiRequester.RequestHandler(object object, IntPtr method)
    {
        mem[1152921511275381768] = method;
        mem[1152921511275381776] = object;
        mem[1152921511275381780] = method;
    }
    public virtual void Invoke(string method, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        if(this != 0)
        {
                if(method == null)
        {
                return;
        }
        
            val_13 = 1152921511275506064;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = response - 8;
        var val_21 = 0;
        string val_2 = method - 8;
        goto label_49;
        label_44:
        val_14 = R7;
        if(val_14 == 0)
        {
            goto label_4;
        }
        
        if(R7 == 0)
        {
            goto label_5;
        }
        
        val_15 = response;
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_16 = method;
        goto label_43;
        label_4:
        val_14 = mem[R7 + 40];
        val_14 = R7 + 40;
        if(R7 == 0)
        {
            goto label_10;
        }
        
        Spine.Animation val_3 = R7.Current;
        val_17 = 0;
        val_17 = val_17 + 1;
        val_18 = method;
        goto label_14;
        label_5:
        var val_13 = R7 + 40;
        val_13 = 1152921504622235648 + (val_13 << 3);
        goto label_43;
        label_10:
        string val_4 = 1152921504622235648 + (val_14 << 3);
        goto label_43;
        label_37:
        val_15 = mem[R7 + 40];
        val_15 = R7 + 40;
        if(method == null)
        {
            goto label_17;
        }
        
        Spine.Animation val_5 = R7.Current;
        var val_19 = val_14;
        if((R7 + 40 + 178) == 0)
        {
            goto label_18;
        }
        
        var val_14 = 0;
        label_20:
        if((R7 + 40 + 88 + 0) == R7)
        {
            goto label_19;
        }
        
        val_14 = val_14 + 1;
        if(((uint)val_14 & 65535) < (R7 + 40 + 178))
        {
            goto label_20;
        }
        
        label_18:
        val_19 = val_14;
        goto label_43;
        label_38:
        var val_15 = (0 + 1) + 40;
        val_15 = val_14 + (val_15 << 3);
        goto label_43;
        label_17:
        var val_16 = val_14;
        val_16 = val_16 + (val_15 << 3);
        goto label_43;
        label_14:
        string val_17 = method;
        goto label_43;
        label_40:
        val_17 = val_17 + (response << 3);
        goto label_43;
        label_19:
        var val_9 = (R7 + 40 + 88) + 0;
        var val_18 = (R7 + 40 + 88 + 0) + 4;
        val_18 = val_18 + val_15;
        val_19 = val_19 + (val_18 << 3);
        val_19 = val_19 + 188;
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
        
        var val_20 = 0;
        label_41:
        if((R6 + 88 + 0) == (R7 + 12))
        {
            goto label_40;
        }
        
        val_20 = val_20 + 1;
        if(((uint)val_20 & 65535) < (R6 + 178))
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
        
        Spine.Animation val_10 = R7.Current;
        if(R7 == 0)
        {
            goto label_48;
        }
        
        goto label_48;
        label_33:
        Spine.Animation val_11 = R7.Current;
        label_48:
        label_43:
        val_21 = val_21 + 1;
        if(val_21 != 1)
        {
            goto label_49;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(string method, System.Collections.Generic.Dictionary<string, object> response, System.AsyncCallback callback, object object)
    {
    
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
