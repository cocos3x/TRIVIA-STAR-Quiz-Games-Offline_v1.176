using UnityEngine;
private sealed class JSONNode.<get_Childs>d__17 : IEnumerable<com.adjust.sdk.JSONNode>, IEnumerable, IEnumerator<com.adjust.sdk.JSONNode>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private com.adjust.sdk.JSONNode <>2__current;
    private int <>l__initialThreadId;
    
    // Properties
    private com.adjust.sdk.JSONNode System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONNode.<get_Childs>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) == 0)
        {
                this.<>1__state = 0;
            this.<>1__state = this.<>1__state;
        }
        
        return false;
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
        if((this.<>1__state) == 2)
        {
                if((this.<>l__initialThreadId) == System.Environment.CurrentManagedThreadId)
        {
                this.<>1__state = 0;
            return;
        }
        
        }
        
        object val_2 = null;
        this = val_2;
        val_2 = new System.Object();
        typeof(JSONNode.<get_Childs>d__17).__il2cppRuntimeField_8 = 0;
        typeof(JSONNode.<get_Childs>d__17).__il2cppRuntimeField_10 = System.Environment.CurrentManagedThreadId;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>.GetEnumerator();
    }

}
