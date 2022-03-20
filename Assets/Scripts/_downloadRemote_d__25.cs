using UnityEngine;
private sealed class ImageRequest.<downloadRemote>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string url;
    public twelvegigs.net.ImageRequest <>4__this;
    private UnityEngine.WWW <getter>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ImageRequest.<downloadRemote>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        UnityEngine.WWW val_11;
        System.Byte[] val_12;
        var val_13;
        if((this.<>1__state) != 1)
        {
                val_10 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
            this.<>1__state = 0;
            UnityEngine.WWW val_1 = null;
            val_11 = val_1;
            val_1 = new UnityEngine.WWW(url:  this.url);
            val_10 = 1;
            this.<getter>5__2 = val_11;
            this.<>1__state = val_10;
            this.<>2__current = val_11;
            return (bool)val_10;
        }
        
        val_11 = this.<getter>5__2;
        this.<>1__state = 0;
        string val_2 = val_11.error;
        if(val_11 != 0)
        {
            goto label_5;
        }
        
        UnityEngine.Texture2D val_3 = this.<getter>5__2.texture;
        val_11 = this.<getter>5__2;
        if(val_11 != 0)
        {
            goto label_9;
        }
        
        label_5:
        if((this.<>4__this) != 0)
        {
                this.<>4__this.error = true;
        }
        else
        {
                mem[136] = 1;
        }
        
        mem2[0] = 1;
        val_10 = 0;
        return (bool)val_10;
        label_9:
        UnityEngine.Texture2D val_5 = this.<getter>5__2.texture;
        if((this.<>4__this) != 0)
        {
                this.<>4__this.imageTexture = this.<getter>5__2;
            System.Byte[] val_6 = UnityEngine.ImageConversion.EncodeToPNG(tex:  this.<getter>5__2);
            this.<>4__this.lnFile = this.<getter>5__2;
            val_12 = this.<>4__this.lnFile;
        }
        else
        {
                mem[132] = this.<getter>5__2;
            System.Byte[] val_7 = UnityEngine.ImageConversion.EncodeToPNG(tex:  mem[132]);
            val_12 = 144;
            mem[144] = mem[132];
        }
        
        if((this.<>4__this._save) != false)
        {
                val_13 = mem[null + 264];
            if((new System.IO.DirectoryInfo(path:  this.<>4__this._path)) == 0)
        {
                val_13 = 0;
            Create();
        }
        
            string val_9 = this.<>4__this._path(this.<>4__this._path) + null;
            System.IO.File.WriteAllBytes(path:  this.<>4__this._path, bytes:  val_12);
        }
        
        this.<>4__this.fireOnComplete();
        mem2[0] = 1;
        this.<getter>5__2.Dispose();
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
