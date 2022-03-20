using UnityEngine;
private sealed class SubscriptionHandler.<RetryValidation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SubscriptionHandler <>4__this;
    public System.Collections.Generic.Dictionary<string, object> purchaseData;
    private SubscriptionHandler.<>c__DisplayClass49_0 <>8__1;
    private string <subscriptonsPath>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SubscriptionHandler.<RetryValidation>d__49(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        SubscriptionHandler.<>c__DisplayClass49_0 val_5;
        object val_6;
        var val_7;
        SubscriptionHandler.<>c__DisplayClass49_0 val_8;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            this.<>8__1 = new System.Object();
            typeof(SubscriptionHandler.<>c__DisplayClass49_0).__il2cppRuntimeField_8 = this.<>4__this;
            val_5 = this.<>8__1;
            this.<>8__1.purchaseData = this.purchaseData;
            var val_4 = 29416948;
            val_4 = 6208884 + val_4;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            this.<subscriptonsPath>5__2 = "/api/subscriptions";
            UnityEngine.WaitForSeconds val_2 = null;
            val_6 = val_2;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_4 = 1;
            this.<>1__state = val_4;
            this.<>2__current = val_6;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        var val_5 = 29417014;
        val_5 = 6209044 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        val_6 = App.networkManager;
        val_8 = this.<>8__1;
        if((this.<>8__1) == 0)
        {
                val_8 = this.<>8__1;
        }
        
        val_5 = null;
        val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  val_8, method:  new IntPtr(2485918688));
        val_4 = 0;
        val_6.DoPost(path:  this.<subscriptonsPath>5__2, postBody:  this.<>8__1.purchaseData, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  val_4);
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
