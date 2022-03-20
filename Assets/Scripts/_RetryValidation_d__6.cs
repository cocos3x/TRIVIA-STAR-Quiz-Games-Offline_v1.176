using UnityEngine;
private sealed class TrackingHandler.<RetryValidation>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TrackingHandler <>4__this;
    public System.Collections.Generic.Dictionary<string, object> eventData;
    private TrackingHandler.<>c__DisplayClass6_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TrackingHandler.<RetryValidation>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        TrackingHandler.<>c__DisplayClass6_0 val_5;
        var val_6;
        TrackingHandler.<>c__DisplayClass6_0 val_7;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            this.<>8__1 = new System.Object();
            typeof(TrackingHandler.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = this.<>4__this;
            val_5 = this.<>8__1;
            this.<>8__1.eventData = this.eventData;
            UnityEngine.WaitForSeconds val_2 = null;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_4 = 1;
            this.<>1__state = val_4;
            this.<>2__current = val_2;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        var val_4 = 28255642;
        val_4 = 7370416 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = this.<>8__1;
        if((this.<>8__1) == 0)
        {
                val_7 = this.<>8__1;
        }
        
        val_5 = null;
        val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  val_7, method:  new IntPtr(2476629088));
        val_4 = 0;
        App.networkManager.DoPost(path:  -1820661680, postBody:  this.<>8__1.eventData, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  val_4);
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
