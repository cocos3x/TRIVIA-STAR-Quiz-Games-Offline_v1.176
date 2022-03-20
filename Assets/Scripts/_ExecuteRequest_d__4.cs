using UnityEngine;
private sealed class RemoteResourcesLoadingRequestHandler.<ExecuteRequest>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RemoteResourcesLoadingRequestHandler <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RemoteResourcesLoadingRequestHandler.<ExecuteRequest>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RemoteResourcesLoadingRequestHandler val_8;
        int val_9;
        System.Byte[] val_10;
        var val_11;
        var val_12;
        val_8 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_9 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
            this.<>1__state = 0;
            this.<>4__this.req.timeout = 30;
            UnityEngine.Networking.UnityWebRequestAsyncOperation val_1 = this.<>4__this.req.SendWebRequest();
            val_9 = 1;
            this.<>1__state = val_9;
            this.<>2__current = this.<>4__this.req;
            return (bool)val_9;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.req.isNetworkError) == true)
        {
            goto label_9;
        }
        
        val_9 = 0;
        if((this.<>4__this.req.isHttpError) == false)
        {
            goto label_11;
        }
        
        label_9:
        val_9 = 0;
        string val_4 = this.<>4__this.req.error;
        string val_5 = -224212224(-224212224) + this.<>4__this.req(this.<>4__this.req);
        UnityEngine.Debug.LogWarning(message:  -224212224);
        if((this.<>4__this.callback) == 0)
        {
                return (bool)val_9;
        }
        
        val_9 = 0;
        val_10 = 0;
        val_11 = public System.Void System.Action<System.Boolean, System.Byte[]>::Invoke(System.Boolean arg1, System.Byte[] arg2);
        val_12 = 0;
        goto label_16;
        label_11:
        if((this.<>4__this.callback) == 0)
        {
                return (bool)val_9;
        }
        
        val_9 = 0;
        UnityEngine.Networking.DownloadHandler val_6 = this.<>4__this.req.downloadHandler;
        val_8 = this.<>4__this.req;
        System.Byte[] val_7 = val_8.data;
        val_10 = val_8;
        val_12 = 1;
        val_11 = public System.Void System.Action<System.Boolean, System.Byte[]>::Invoke(System.Boolean arg1, System.Byte[] arg2);
        label_16:
        this.<>4__this.callback.Invoke(arg1:  true, arg2:  val_10);
        return (bool)val_9;
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
