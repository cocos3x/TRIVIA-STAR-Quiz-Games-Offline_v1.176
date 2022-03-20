using UnityEngine;
private sealed class CUtils.<ConnectUrl>d__60 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string url;
    public System.Action<int> connectionListener;
    private UnityEngine.WWW <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CUtils.<ConnectUrl>d__60(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        var val_6;
        var val_7;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            UnityEngine.WWW val_1 = new UnityEngine.WWW(url:  this.url);
            val_5 = 1;
            this.<www>5__2 = val_1;
            this.<>1__state = val_5;
            this.<>2__current = val_1;
            return (bool)val_5;
        }
        
        this.<>1__state = 0;
        string val_2 = this.<www>5__2.error;
        if((this.<www>5__2) == 0)
        {
            goto label_5;
        }
        
        val_6 = 1;
        val_7 = public System.Void System.Action<System.Int32>::Invoke(System.Int32 obj);
        goto label_7;
        label_5:
        string val_3 = this.<www>5__2.text;
        val_7 = public System.Void System.Action<System.Int32>::Invoke(System.Int32 obj);
        if((System.String.IsNullOrEmpty(value:  this.<www>5__2)) == false)
        {
            goto label_10;
        }
        
        val_6 = 2;
        label_7:
        this.connectionListener.Invoke(obj:  2);
        val_5 = 0;
        return (bool)val_5;
        label_10:
        this.connectionListener.Invoke(obj:  0);
        return (bool)val_5;
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
