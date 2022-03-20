using UnityEngine;
private sealed class BetterList.<GetEnumerator>d__2<T> : IEnumerator<T>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private T <>2__current;
    public BetterList<T> <>4__this;
    private int <i>5__2;
    
    // Properties
    private T System.Collections.Generic.IEnumerator<T>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BetterList.<GetEnumerator>d__2<T>(int <>1__state)
    {
        mem[1152921510696327880] = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        var val_3;
        BetterList.<GetEnumerator>d__2<T> val_4;
        var val_5;
        val_3 = 0;
        if(this != 1)
        {
                if(this != 0)
        {
                return (bool)val_3;
        }
        
            mem[1152921510696551880] = 0;
            if((R6 + 8) == 0)
        {
                return (bool)val_3;
        }
        
            val_4 = 0;
            val_5 = this;
            mem[1152921510696551892] = val_4;
        }
        else
        {
                val_5 = this;
            val_4 = 1152921510696551873;
            mem[1152921510696551880] = 0;
            mem[1152921510696551892] = val_4;
        }
        
        if(val_4 >= (R6 + 12))
        {
                return (bool)val_3;
        }
        
        val_2 = mem[R6 + 8];
        val_2 = R6 + 8;
        var val_1 = val_2 + 2883983108;
        val_3 = 1;
        mem[1152921510696551880] = val_3;
        mem[1152921510696551884] = (R6 + 8 + 2883983108) + 16;
        return (bool)val_3;
    }
    private T System.Collections.Generic.IEnumerator<T>.get_Current()
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
