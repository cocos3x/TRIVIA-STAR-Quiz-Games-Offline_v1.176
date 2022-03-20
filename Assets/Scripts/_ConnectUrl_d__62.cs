using UnityEngine;
private sealed class CUtils.<ConnectUrl>d__62 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string url;
    public System.Action onDisconnected;
    private UnityEngine.WWW <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CUtils.<ConnectUrl>d__62(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WWW val_7;
        int val_8;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 6623232 + (6623232 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                6623232 + (this.<>1__state) << 2 = (6623232 + (this.<>1__state) << 2) & ((6623232 + (this.<>1__state) << 2) << (6623232 + (this.<>1__state) << 2));
            6623232 + (this.<>1__state) << 2 = (6623232 + (this.<>1__state) << 2) & (this >> (6623232 + (this.<>1__state) << 2));
            mem2[0] = ((6623232 + (this.<>1__state) << 2 & (6623232 + (this.<>1__state) << 2) << 6623232 + (this.<>1__state) << 2) & ((int)this) >> (6623232 + (this.<>1__state) << 2 & (6623232 + (this.<>1__state) << 2) <<  + R8;
            mem2[0] = ((6623232 + (this.<>1__state) << 2 & (6623232 + (this.<>1__state) << 2) << 6623232 + (this.<>1__state) << 2) & ((int)this) >> (6623232 + (this.<>1__state) << 2 & (6623232 + (this.<>1__state) << 2) <<  + R8 + IP;
        }
        
            this.<>1__state = 0;
            UnityEngine.WWW val_2 = null;
            val_7 = val_2;
            val_2 = new UnityEngine.WWW(url:  this.url);
            val_8 = 1;
            this.<www>5__2 = val_7;
            this.<>1__state = val_8;
        }
        else
        {
                val_8 = 0;
            return (bool);
        }
        
        this.<>2__current = ;
        return (bool);
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
