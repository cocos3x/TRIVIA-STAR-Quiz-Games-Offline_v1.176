using UnityEngine;
private sealed class NetworkThreadingHandler.<SitIdle>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public NetworkThreadingHandler <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkThreadingHandler.<SitIdle>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.Request) == 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.delayRequest);
        val_2 = 1;
        return (bool)val_2;
        label_1:
        val_2 = 0;
        if((this.<>1__state) != 2)
        {
                return (bool)val_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.Request) != 0)
        {
                return (bool)val_2;
        }
        
        return (bool)val_2;
        label_3:
        val_2 = 1;
        this.<>1__state = val_2;
        this.<>2__current = 0;
        return (bool)val_2;
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
