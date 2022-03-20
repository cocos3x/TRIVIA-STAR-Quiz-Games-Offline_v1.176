using UnityEngine;
private sealed class DLCManager.<Execute>d__29 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DLCManager <>4__this;
    private int <desiredVersion>5__2;
    private UnityEngine.WWW <loadingClass>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DLCManager.<Execute>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action<UnityEngine.AssetBundle> val_15;
        bool val_16;
        float val_17;
        var val_18;
        var val_19;
        string val_20;
        var val_21;
        var val_22;
        val_15 = this;
        val_16 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_16;
        }
        
        this.<>1__state = 0;
        this.<desiredVersion>5__2 = this.<>4__this.currentAssetVersion;
        val_17 = 1152921504887943168;
        val_18 = null;
        val_18 = null;
        if((DLCManager.NOTIFICATION_ASSET_LOADED.ContainsKey(key:  this.<>4__this.currentAssetToLoad)) == false)
        {
            goto label_7;
        }
        
        val_19 = null;
        val_15 = this.<>4__this.currentOnDownloadedCallback;
        val_19 = null;
        val_20 = DLCManager.NOTIFICATION_ASSET_LOADED;
        string val_2 = val_20.Item[this.<>4__this.currentAssetToLoad];
        val_15.Invoke(obj:  val_20);
        goto label_12;
        label_1:
        this.<>1__state = 0;
        string val_3 = this.<loadingClass>5__3.error;
        if((this.<loadingClass>5__3) == 0)
        {
            goto label_14;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = "DLCManager :: Error loading: ";
        string val_4 = this.<loadingClass>5__3.url;
        typeof(System.String[]).__il2cppRuntimeField_14 = this.<loadingClass>5__3;
        typeof(System.String[]).__il2cppRuntimeField_18 = "  (";
        typeof(System.String[]).__il2cppRuntimeField_1C = this.<>4__this.currentAssetToLoad;
        typeof(System.String[]).__il2cppRuntimeField_20 = "): ";
        string val_5 = this.<loadingClass>5__3.error;
        typeof(System.String[]).__il2cppRuntimeField_24 = this.<loadingClass>5__3;
        typeof(System.String[]).__il2cppRuntimeField_28 = " desiredVersion: ";
        string val_6 = this.<desiredVersion>5__2.ToString();
        typeof(System.String[]).__il2cppRuntimeField_2C = this.<desiredVersion>5__2;
        string val_7 = +477709520;
        UnityEngine.Debug.Log(message:  477709520);
        goto label_59;
        label_7:
        val_16 = true;
        val_20 = this.<>4__this.baseString;
        this.<>4__this.executing = val_16;
        string val_8 = System.String.Format(format:  val_20, arg0:  this.<>4__this.currentAssetPath, arg1:  13152256);
        string val_9 = val_20 + this.<>4__this.currentAssetToLoad(this.<>4__this.currentAssetToLoad) + this.<>4__this.fileExtension(this.<>4__this.fileExtension);
        UnityEngine.WWW val_10 = UnityEngine.WWW.LoadFromCacheOrDownload(url:  val_20, version:  this.<desiredVersion>5__2);
        this.<loadingClass>5__3 = val_20;
        this.<>1__state = val_16;
        this.<>2__current = val_20;
        return (bool)val_16;
        label_14:
        val_17 = 1152921504887943168;
        val_21 = null;
        val_21 = null;
        if((DLCManager.NOTIFICATION_ASSET_LOADED.ContainsKey(key:  this.<>4__this.currentAssetToLoad)) != true)
        {
                val_22 = null;
            val_22 = null;
            val_17 = this.<>4__this.currentAssetToLoad;
            UnityEngine.AssetBundle val_12 = this.<loadingClass>5__3.assetBundle;
            DLCManager.NOTIFICATION_ASSET_LOADED.Add(key:  val_17, value:  this.<loadingClass>5__3);
        }
        
        if((this.<>4__this.SavedAssetsMap.ContainsKey(key:  this.<>4__this.currentAssetToLoad)) != true)
        {
                val_17 = this.<>4__this.currentAssetToLoad;
            this.<>4__this.SavedAssetsMap.Add(key:  val_17, value:  this.<>4__this.currentAssetVersion);
        }
        
        this.<>4__this.SaveAlreadySavedAssets();
        if((this.<>4__this.currentOnDownloadedCallback) != 0)
        {
                UnityEngine.AssetBundle val_14 = this.<loadingClass>5__3.assetBundle;
            this.<>4__this.currentOnDownloadedCallback.Invoke(obj:  this.<loadingClass>5__3);
        }
        
        label_59:
        val_20 = 0;
        this.<loadingClass>5__3.Dispose();
        this.<loadingClass>5__3 = val_20;
        label_12:
        this.<>4__this.Dequeue();
        return (bool)val_16;
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
