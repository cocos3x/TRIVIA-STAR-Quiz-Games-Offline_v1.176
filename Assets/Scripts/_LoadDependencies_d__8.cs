using UnityEngine;
private sealed class SRDependencyServiceBase.<LoadDependencies>d__8<T> : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SRF.Service.SRDependencyServiceBase<T> <>4__this;
    private System.Type[] <>7__wrap1;
    private int <>7__wrap2;
    private SRF.Service.IAsyncService <a>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SRDependencyServiceBase.<LoadDependencies>d__8<T>(int <>1__state)
    {
        mem[1152921513597351400] = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SRDependencyServiceBase.<LoadDependencies>d__8<T> val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_7 = this;
        if(true == 1)
        {
            goto label_1;
        }
        
        val_8 = 0;
        if(true != 0)
        {
                return (bool)val_8;
        }
        
        mem[1152921513597575560] = 0;
        val_9 = null;
        val_9 = null;
        int val_7 = SRF.Service.SRServiceManager.LoadingCount;
        val_7 = val_7 + 1;
        SRF.Service.SRServiceManager.LoadingCount = val_7;
        val_10 = val_7;
        val_11 = 0;
        mem[1152921513597575572] = R5;
        val_12 = R5;
        val_13 = 1152921513597575572;
        mem[1152921513597575576] = val_11;
        goto label_6;
        label_1:
        val_14 = val_7;
        mem[1152921513597575560] = 0;
        if(val_7 != 0)
        {
            goto label_7;
        }
        
        val_15 = 0;
        goto label_8;
        label_24:
        var val_1 = SL + (R7 << 2);
        if((SRF.Service.SRServiceManager.HasService(t:  (SL + (R7) << 2) + 16)) == true)
        {
            goto label_13;
        }
        
        object val_3 = SRF.Service.SRServiceManager.GetService(t:  (SL + (R7) << 2) + 16);
        if(((SL + (R7) << 2) + 16) == 0)
        {
            goto label_16;
        }
        
        val_14 = val_7;
        mem[1152921513597575580] = (SL + (R7) << 2) + 16;
        if(((SL + (R7) << 2) + 16) == 0)
        {
            goto label_29;
        }
        
        val_7 = (SL + (R7) << 2) + 16;
        label_7:
        val_15 = val_7;
        label_8:
        if(((SL + (R7) << 2) + 16 + 178) == 0)
        {
            goto label_21;
        }
        
        val_13 = mem[(SL + (R7) << 2) + 16 + 88];
        val_13 = (SL + (R7) << 2) + 16 + 88;
        var val_8 = 0;
        label_20:
        if(((SL + (R7) << 2) + 16 + 88 + 0) == null)
        {
            goto label_19;
        }
        
        val_8 = val_8 + 1;
        if(((uint)val_8 & 65535) < ((SL + (R7) << 2) + 16 + 178))
        {
            goto label_20;
        }
        
        goto label_21;
        label_19:
        var val_4 = val_13 + 0;
        var val_9 = ((SL + (R7) << 2) + 16 + 88 + 0) + 4;
        val_9 = val_15 + (val_9 << 3);
        val_15 = val_9 + 188;
        label_21:
        if(val_7 == 0)
        {
            goto label_22;
        }
        
        val_7 = val_7;
        val_10 = 1152921513597575572;
        val_13 = 1152921513597575576;
        label_29:
        mem[1152921513597575580] = 0;
        label_13:
        val_11 = mem[1152921513597575576] + 1;
        mem[1152921513597575576] = val_11;
        val_12 = mem[1152921513597575572];
        label_6:
        if(val_11 < (R5 + 12))
        {
            goto label_24;
        }
        
        mem[1152921513597575572] = 0;
        mem2[0] = 1;
        val_16 = null;
        val_16 = null;
        int val_10 = SRF.Service.SRServiceManager.LoadingCount;
        val_10 = val_10 - 1;
        SRF.Service.SRServiceManager.LoadingCount = val_10;
        val_8 = 0;
        return (bool)val_8;
        label_22:
        val_8 = 1;
        mem[1152921513597575560] = val_8;
        mem[1152921513597575564] = new UnityEngine.WaitForEndOfFrame();
        return (bool)val_8;
        label_16:
        typeof(System.Object[]).__il2cppRuntimeField_10 = (SL + (R7) << 2) + 16;
        string val_6 = SRF.SRFStringExtensions.Fmt(formatString:  400769824, args:  472754880);
        val_8 = 0;
        UnityEngine.Debug.LogError(message:  400769824);
        ???.enabled = false;
        return (bool)val_8;
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
