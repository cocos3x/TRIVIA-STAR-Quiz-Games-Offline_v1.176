using UnityEngine;
private sealed class NetworkThreadingHandler.<Start>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public NetworkThreadingHandler <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkThreadingHandler.<Start>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        var val_11;
        int val_12;
        var val_13;
        System.Collections.IEnumerator val_14;
        object val_15;
        val_10 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
        this.<>1__state = 0;
        val_11 = null;
        val_11 = null;
        if(NetworkThreadingHandler.HackThrottle == false)
        {
            goto label_6;
        }
        
        int val_1 = UnityEngine.Random.Range(min:  3, max:  4);
        if((this.<>4__this) == 0)
        {
            goto label_7;
        }
        
        this.<>4__this.delayRequest = val_1;
        val_12 = UnityEngine.Random.Range(min:  3, max:  4);
        goto label_8;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.CleanupRequest();
        return (bool)val_10;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_11;
        }
        
        System.Collections.IEnumerator val_3 = this.<>4__this.ExecuteRequest();
        val_13 = this.<>4__this;
        goto label_12;
        label_6:
        if((this.<>4__this) != 0)
        {
            goto label_13;
        }
        
        System.Collections.IEnumerator val_4 = 0.SitIdle();
        val_14 = 0;
        goto label_14;
        label_11:
        System.Collections.IEnumerator val_5 = 0.ExecuteRequest();
        val_13 = 0;
        label_12:
        val_15 = this.<>4__this;
        UnityEngine.Coroutine val_6 = val_15.StartCoroutine(routine:  0);
        val_10 = 1;
        this.<>1__state = 2;
        goto label_15;
        label_7:
        mem[20] = val_1;
        val_12 = UnityEngine.Random.Range(min:  3, max:  4);
        label_8:
        this.<>4__this.delayResponse = val_12;
        label_13:
        System.Collections.IEnumerator val_8 = this.<>4__this.SitIdle();
        val_14 = this.<>4__this;
        label_14:
        val_15 = this.<>4__this;
        UnityEngine.Coroutine val_9 = val_15.StartCoroutine(routine:  val_14);
        val_10 = 1;
        this.<>1__state = val_10;
        label_15:
        this.<>2__current = val_15;
        return (bool)val_10;
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
