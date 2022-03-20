using UnityEngine;
private sealed class CUtils.<CachePicture>d__67 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string url;
    public System.Action<bool> result;
    private string <localPath>5__2;
    private UnityEngine.WWW <www>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CUtils.<CachePicture>d__67(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        UnityEngine.WWW val_8;
        var val_9;
        var val_10;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            string val_1 = CUtils.GetLocalPath(url:  this.url);
            this.<localPath>5__2 = this.url;
            UnityEngine.WWW val_2 = null;
            val_8 = val_2;
            val_2 = new UnityEngine.WWW(url:  this.url);
            val_7 = 1;
            this.<www>5__3 = val_8;
            this.<>1__state = val_7;
            this.<>2__current = val_8;
            return (bool)val_7;
        }
        
        val_8 = this.<www>5__3;
        this.<>1__state = 0;
        val_7 = 0;
        if(val_8.isDone == false)
        {
            goto label_9;
        }
        
        val_8 = this.<www>5__3;
        string val_4 = val_8.error;
        if((System.String.IsNullOrEmpty(value:  val_8)) == false)
        {
            goto label_9;
        }
        
        val_8 = this.<localPath>5__2;
        val_7 = 0;
        System.Byte[] val_6 = this.<www>5__3.bytes;
        System.IO.File.WriteAllBytes(path:  val_8, bytes:  this.<www>5__3);
        if(this.result == 0)
        {
                return (bool)val_7;
        }
        
        val_9 = public System.Void System.Action<System.Boolean>::Invoke(System.Boolean obj);
        val_10 = 1;
        goto label_12;
        label_9:
        if(this.result == 0)
        {
                return (bool)val_7;
        }
        
        val_7 = 0;
        val_9 = public System.Void System.Action<System.Boolean>::Invoke(System.Boolean obj);
        val_10 = 0;
        label_12:
        this.result.Invoke(obj:  false);
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
