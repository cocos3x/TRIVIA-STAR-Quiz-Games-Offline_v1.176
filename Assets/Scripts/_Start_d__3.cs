using UnityEngine;
private sealed class RemoteResourcesLoadingRequestHandler.<Start>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RemoteResourcesLoadingRequestHandler <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RemoteResourcesLoadingRequestHandler.<Start>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        var val_5;
        val_4 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_0;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_2;
        }
        
        System.Collections.IEnumerator val_1 = this.<>4__this.ExecuteRequest();
        val_5 = this.<>4__this;
        goto label_3;
        label_0:
        this.<>1__state = 0;
        this.<>4__this.CleanupRequest();
        return (bool)val_4;
        label_2:
        System.Collections.IEnumerator val_2 = 0.ExecuteRequest();
        val_5 = 0;
        label_3:
        UnityEngine.Coroutine val_3 = this.<>4__this.StartCoroutine(routine:  0);
        val_4 = 1;
        this.<>1__state = val_4;
        this.<>2__current = this.<>4__this;
        return (bool)val_4;
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
