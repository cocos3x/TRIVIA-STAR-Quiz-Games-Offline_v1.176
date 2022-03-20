using UnityEngine;
private sealed class AsyncExecution.<MultiAsync>d__4<T> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Collections.Generic.IEnumerable<T> collection;
    public int batchSize;
    public AsyncExecution <>4__this;
    public System.Action<T> collectionAction;
    private int <maxLoadBatches>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AsyncExecution.<MultiAsync>d__4<T>(int <>1__state)
    {
        mem[1152921511407021992] = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        AsyncExecution.<MultiAsync>d__4<T> val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        AsyncExecution.<MultiAsync>d__4<T> val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_13 = this;
        val_15 = 0;
        if(__RuntimeMethodHiddenParam == 1)
        {
            goto label_1;
        }
        
        if(__RuntimeMethodHiddenParam != 0)
        {
                return (bool)val_15;
        }
        
        mem[1152921511407245992] = 0;
        bool val_13 = static_value_02202835;
        var val_12 = 0;
        val_16 = 0;
        val_12 = val_12 + 1;
        val_16 = (uint)val_12 & 65535;
        val_17 = 35661877;
        goto label_8;
        label_1:
        mem[1152921511407245992] = 0;
        val_18 = 1152921511407246016;
        val_19 = R2 + 1;
        goto label_9;
        label_8:
        val_20 = 0;
        goto label_10;
        label_22:
        bool val_15 = static_value_02202835;
        var val_14 = 0;
        val_16 = 0;
        val_14 = val_14 + 1;
        val_16 = (uint)val_14 & 65535;
        val_21 = 35661877;
        val_20 = 1;
        label_10:
        bool val_16 = static_value_02202835;
        val_16 = 0;
        val_16 = val_16 + 1;
        val_22 = 35661877;
        if(35661877 != 0)
        {
            goto label_22;
        }
        
        val_23 = 0;
        if(35661877 != 0)
        {
                bool val_18 = static_value_02202835;
            var val_17 = 0;
            val_16 = 0;
            val_17 = val_17 + 1;
            val_16 = (uint)val_17 & 65535;
            val_24 = 35661877;
            val_23 = val_23;
        }
        
        if(0 != 1)
        {
                if(0 > 1)
        {
                0 = 1;
        }
        
            var val_19 = 0;
            val_19 = 0 - val_19;
            val_25 = val_19 + 1;
        }
        else
        {
                val_25 = 0;
        }
        
        mem[1152921511407246004] = System.Math.Max(val1:  mem[1152921511407246004], val2:  1);
        mem[1152921511407246016] = System.Math.Max(val1:  1, val2:  1);
        var val_21 = mem[1152921511407246000];
        if((mem[1152921511407246000] + 178) == 0)
        {
            goto label_35;
        }
        
        var val_20 = 0;
        label_37:
        val_16 = 0;
        if((mem[1152921511407246000] + 88 + 0) == (__RuntimeMethodHiddenParam + 12 + 96))
        {
            goto label_36;
        }
        
        val_20 = val_20 + 1;
        val_16 = (uint)val_20 & 65535;
        if(val_16 < (mem[1152921511407246000] + 178))
        {
            goto label_37;
        }
        
        label_35:
        val_26 = mem[1152921511407246000];
        goto label_38;
        label_36:
        var val_7 = (mem[1152921511407246000] + 88) + 0;
        val_21 = val_21 + (((mem[1152921511407246000] + 88 + 0) + 4) << 3);
        val_26 = val_21 + 188;
        label_38:
        val_27 = mem[1152921511407246000];
        val_14 = 0;
        val_28 = 0;
        goto label_39;
        label_53:
        var val_23 = val_27;
        if((mem[1152921511407246000] + 178) == 0)
        {
            goto label_42;
        }
        
        var val_22 = 0;
        label_44:
        if((mem[1152921511407246000] + 88 + 0) == (__RuntimeMethodHiddenParam + 12 + 96 + 4))
        {
            goto label_43;
        }
        
        val_22 = val_22 + 1;
        if(((uint)val_22 & 65535) < (mem[1152921511407246000] + 178))
        {
            goto label_44;
        }
        
        label_42:
        val_29 = val_27;
        goto label_45;
        label_43:
        var val_8 = (mem[1152921511407246000] + 88) + 0;
        val_23 = val_23 + (((mem[1152921511407246000] + 88 + 0) + 4) << 3);
        val_29 = val_23 + 188;
        label_45:
        val_16 = val_27;
        UnityEngine.Coroutine val_9 = ???.StartCoroutine(routine:  ???);
        val_28 = 1;
        val_27 = mem[1152921511407246000];
        val_14 = mem[1152921511407246016];
        label_39:
        var val_24 = val_27;
        if((mem[1152921511407246000] + 178) == 0)
        {
            goto label_49;
        }
        
        val_16 = 0;
        label_51:
        if((mem[1152921511407246000] + 88 + 0) == null)
        {
            goto label_50;
        }
        
        val_16 = val_16 + 1;
        if(((uint)val_16 & 65535) < (mem[1152921511407246000] + 178))
        {
            goto label_51;
        }
        
        label_49:
        val_30 = val_27;
        goto label_52;
        label_50:
        var val_10 = (mem[1152921511407246000] + 88) + 0;
        val_24 = val_24 + (((mem[1152921511407246000] + 88 + 0) + 4) << 3);
        val_30 = val_24 + 188;
        label_52:
        if(val_27 != 0)
        {
            goto label_53;
        }
        
        if(val_27 == 0)
        {
            goto label_54;
        }
        
        var val_25 = val_27;
        if((mem[1152921511407246000] + 178) == 0)
        {
            goto label_55;
        }
        
        val_16 = 0;
        label_57:
        if((mem[1152921511407246000] + 88 + 0) == null)
        {
            goto label_56;
        }
        
        val_16 = val_16 + 1;
        if(((uint)val_16 & 65535) < (mem[1152921511407246000] + 178))
        {
            goto label_57;
        }
        
        label_55:
        val_31 = val_27;
        goto label_58;
        label_56:
        var val_11 = (mem[1152921511407246000] + 88) + 0;
        val_25 = val_25 + (((mem[1152921511407246000] + 88 + 0) + 4) << 3);
        val_31 = val_25 + 188;
        label_58:
        label_54:
        val_13 = val_13;
        val_19 = 0;
        val_15 = 0;
        val_18 = 1152921511407246016;
        label_9:
        mem[1152921511407246020] = val_19;
        val_18 = val_18 + 1;
        if(val_19 >= val_18)
        {
                return (bool)val_15;
        }
        
        val_15 = 1;
        mem[1152921511407245992] = val_15;
        mem[1152921511407245996] = 0;
        return (bool)val_15;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
