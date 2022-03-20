using UnityEngine;
private sealed class CircularBuffer.<GetEnumerator>d__17<T> : IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private T <>2__current;
    public SRDebugger.CircularBuffer<T> <>4__this;
    private System.ArraySegment<T>[] <>7__wrap1;
    private int <>7__wrap2;
    private System.ArraySegment<T> <segment>5__4;
    private int <i>5__5;
    
    // Properties
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CircularBuffer.<GetEnumerator>d__17<T>(int <>1__state)
    {
        mem[1152921513609733752] = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        CircularBuffer.<GetEnumerator>d__17<T> val_11;
        var val_12;
        val_5 = __RuntimeMethodHiddenParam;
        if(__RuntimeMethodHiddenParam == 1)
        {
            goto label_0;
        }
        
        val_6 = 0;
        if(__RuntimeMethodHiddenParam != 0)
        {
                return (bool)val_6;
        }
        
        mem[1152921513609957752] = 0;
        val_7 = __RuntimeMethodHiddenParam + 12 + 96;
        var val_1 = val_7 + 16;
        var val_2 = val_7 + 28;
        val_8 = 0;
        val_9 = this;
        mem[1152921513609957800] = val_8;
        val_5 = 1152921513609957800;
        mem[1152921513609957796] = val_7;
        goto label_8;
        label_0:
        val_11 = 1152921513609957745;
        val_12 = 1152921513609957804;
        mem[1152921513609957752] = 0;
        mem[1152921513609957816] = val_11;
        goto label_9;
        label_14:
        var val_3 = R7 + (R7 << 1);
        val_11 = 0;
        val_3 = val_5 + (val_3 << 2);
        val_10 = mem[(__RuntimeMethodHiddenParam + ((R7 + (R7) << 1)) << 2) + 24];
        val_10 = (__RuntimeMethodHiddenParam + ((R7 + (R7) << 1)) << 2) + 24;
        val_12 = this;
        mem[1152921513609957804] = (__RuntimeMethodHiddenParam + ((R7 + (R7) << 1)) << 2) + 16;
        mem[1152921513609957808] = (__RuntimeMethodHiddenParam + ((R7 + (R7) << 1)) << 2) + 20;
        mem[1152921513609957812] = val_10;
        mem[1152921513609957816] = val_11;
        label_9:
        if(val_11 < val_10)
        {
            goto label_12;
        }
        
        val_5 = this;
        mem[1152921513609957808] = 0;
        mem[1152921513609957804] = 0;
        mem[1152921513609957812] = 0;
        val_9 = 1152921513609957796;
        val_8 = 1;
        mem[1152921513609957800] = val_8;
        label_8:
        if(val_8 < 0)
        {
            goto label_14;
        }
        
        val_6 = 0;
        mem[1152921513609957796] = val_6;
        return (bool)val_6;
        label_12:
        val_11 = val_5 + val_11;
        var val_4 = val_5 + (val_11 << 5);
        val_4 = val_4 + 16;
        val_6 = 1;
        mem[1152921513609957752] = val_6;
        return (bool)val_6;
    }
    private T System.Collections.Generic.IEnumerator<T>.get_Current()
    {
        var val_1 = __RuntimeMethodHiddenParam + 16;
        __RuntimeMethodHiddenParam = __RuntimeMethodHiddenParam + 32;
        return new SRDebugger.Services.ProfilerFrame();
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
