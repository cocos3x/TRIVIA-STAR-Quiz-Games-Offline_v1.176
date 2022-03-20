using UnityEngine;
private sealed class JSONClass.<GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public com.adjust.sdk.JSONClass <>4__this;
    private System.Collections.Generic.Dictionary.Enumerator<string, com.adjust.sdk.JSONNode> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONClass.<GetEnumerator>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 3)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        var val_2;
        var val_3;
        int val_5;
        Dictionary.Enumerator<System.String, com.adjust.sdk.JSONNode> val_6;
        val_5 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            mem[1152921514551827476] = val_3;
            mem[1152921514551827480] = val_2;
        }
        else
        {
                val_6 = this.<>7__wrap1;
        }
        
        this.<>1__state = 2;
        if(val_6.MoveNext() != false)
        {
                val_5 = 1;
            this.<>1__state = val_5;
            this.<>2__current = null;
            return (bool)val_5;
        }
        
        this.<>m__Finally1();
        val_5 = 0;
        mem2[0] = val_5;
        mem2[0] = val_5;
        return (bool)val_5;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Dispose();
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
