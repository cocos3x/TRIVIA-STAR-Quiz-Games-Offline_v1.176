using UnityEngine;
private sealed class JSONArray.<GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public com.adjust.sdk.JSONArray <>4__this;
    private System.Collections.Generic.List.Enumerator<com.adjust.sdk.JSONNode> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONArray.<GetEnumerator>d__14(int <>1__state)
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
        int val_3;
        List.Enumerator<com.adjust.sdk.JSONNode> val_4;
        val_3 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            List.Enumerator<T> val_1 = GetEnumerator();
            this.<>1__state = 2;
        }
        else
        {
                val_4 = this.<>7__wrap1;
            this.<>1__state = 2;
        }
        
        bool val_2 = val_4.MoveNext();
        if(val_2 != false)
        {
                val_3 = 1;
            this.<>1__state = val_3;
            this.<>2__current = val_2;
            return (bool)val_3;
        }
        
        this.<>m__Finally1();
        return (bool)val_3;
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
