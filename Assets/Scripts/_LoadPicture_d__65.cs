using UnityEngine;
private sealed class CUtils.<LoadPicture>d__65 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string url;
    public bool useCached;
    public System.Action<UnityEngine.Texture2D> callback;
    public int width;
    public int height;
    private string <localPath>5__2;
    private UnityEngine.WWW <www>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CUtils.<LoadPicture>d__65(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        System.Action<UnityEngine.Texture2D> val_11;
        string val_12;
        int val_13;
        if((this.<>1__state) != 1)
        {
                val_10 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
            this.<>1__state = 0;
            val_11 = 1152921504882511872;
            string val_1 = CUtils.GetLocalPath(url:  this.url);
            val_12 = this.url;
            this.<localPath>5__2 = val_12;
            if(this.useCached != false)
        {
                val_11 = this.callback;
            val_13 = this.height;
            if((CUtils.LoadFromLocal(callback:  val_11, localPath:  val_12, width:  this.width, height:  val_13)) == true)
        {
                return (bool)val_10;
        }
        
        }
        
            UnityEngine.WWW val_3 = null;
            val_12 = val_3;
            val_3 = new UnityEngine.WWW(url:  this.url);
            val_10 = 1;
            this.<www>5__3 = val_12;
            this.<>1__state = val_10;
            this.<>2__current = val_12;
            return (bool)val_10;
        }
        
        this.<>1__state = 0;
        if((this.<www>5__3.isDone) == false)
        {
            goto label_13;
        }
        
        string val_5 = this.<www>5__3.error;
        if((System.String.IsNullOrEmpty(value:  this.<www>5__3)) == false)
        {
            goto label_13;
        }
        
        UnityEngine.Texture2D val_7 = this.<www>5__3.texture;
        this.callback.Invoke(obj:  this.<www>5__3);
        val_12 = this.<www>5__3;
        System.Byte[] val_8 = val_12.bytes;
        System.IO.File.WriteAllBytes(path:  this.<localPath>5__2, bytes:  val_12);
        goto label_17;
        label_13:
        val_11 = this.callback;
        val_13 = this.width;
        val_12 = this.height;
        bool val_9 = CUtils.LoadFromLocal(callback:  val_11, localPath:  this.<localPath>5__2, width:  val_13, height:  val_12);
        label_17:
        val_10 = 0;
        this.<www>5__3 = val_10;
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
