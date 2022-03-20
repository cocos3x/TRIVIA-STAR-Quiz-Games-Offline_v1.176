using UnityEngine;
private sealed class JSONClass.<get_Childs>d__14 : IEnumerable<com.adjust.sdk.JSONNode>, IEnumerable, IEnumerator<com.adjust.sdk.JSONNode>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private com.adjust.sdk.JSONNode <>2__current;
    private int <>l__initialThreadId;
    public com.adjust.sdk.JSONClass <>4__this;
    private System.Collections.Generic.Dictionary.Enumerator<string, com.adjust.sdk.JSONNode> <>7__wrap1;
    
    // Properties
    private com.adjust.sdk.JSONNode System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONClass.<get_Childs>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
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
            mem[1152921514550777496] = val_3;
            mem[1152921514550777500] = val_2;
        }
        else
        {
                val_6 = this.<>7__wrap1;
        }
        
        this.<>1__state = 2;
        bool val_4 = val_6.MoveNext();
        if(val_4 != false)
        {
                val_5 = 1;
            this.<>1__state = val_5;
            this.<>2__current = val_4;
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
    private com.adjust.sdk.JSONNode System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }
    private System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode> System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>.GetEnumerator()
    {
        int val_4;
        var val_5;
        if((this.<>1__state) == 2)
        {
                val_4 = this.<>l__initialThreadId;
            if(val_4 == System.Environment.CurrentManagedThreadId)
        {
                this.<>1__state = 0;
            val_5 = this;
            return;
        }
        
        }
        
        object val_2 = null;
        val_5 = val_2;
        val_4 = 0;
        val_2 = new System.Object();
        typeof(JSONClass.<get_Childs>d__14).__il2cppRuntimeField_8 = val_4;
        typeof(JSONClass.<get_Childs>d__14).__il2cppRuntimeField_10 = System.Environment.CurrentManagedThreadId;
        typeof(JSONClass.<get_Childs>d__14).__il2cppRuntimeField_14 = this.<>4__this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>.GetEnumerator();
    }

}
