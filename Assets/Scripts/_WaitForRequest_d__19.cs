using UnityEngine;
private sealed class ApiRequester.<WaitForRequest>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.WWW urlToCall;
    public ApiRequester <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ApiRequester.<WaitForRequest>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        int val_7;
        var val_8;
        Request val_9;
        val_6 = this;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            val_7 = 1;
            this.<>1__state = val_7;
            this.<>2__current = this.urlToCall;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        string val_1 = this.urlToCall.error;
        if(this.urlToCall != 0)
        {
                val_7 = 0;
            string val_2 = this.urlToCall.error;
            string val_3 = -1920673984(-1920673984) + this.urlToCall;
            UnityEngine.Debug.Log(message:  -1920673984);
            return (bool)val_7;
        }
        
        val_6 = 0;
        string val_4 = this.urlToCall.text;
        object val_5 = MiniJSON.Json.Deserialize(json:  this.urlToCall);
        val_8 = this.urlToCall;
        if(val_8 != 0)
        {
                if(((UnityEngine.WWW.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_8 = 0;
        }
        
            val_6 = val_8;
        }
        
        this.<>4__this.onRequestResponse.Invoke(method:  this.<>4__this.currentRequest.method, response:  0);
        this.<>4__this.currentRequest = 0;
        if((this.<>4__this.requests) < 1)
        {
            goto label_17;
        }
        
        val_7 = 0;
        val_9 = 0;
        if((this.<>4__this.requests) == 0)
        {
            goto label_22;
        }
        
        val_9 = 0;
        goto label_22;
        label_17:
        val_7 = false;
        this.<>4__this.executing = val_7;
        return (bool)val_7;
        label_22:
        this.<>4__this.execute(request:  null);
        return (bool)val_7;
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
