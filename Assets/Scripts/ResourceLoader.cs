using UnityEngine;
public class ResourceLoader : MonoSingletonSelfGenerating<ResourceLoader>
{
    // Fields
    private bool initialized;
    private System.Collections.Generic.Dictionary<string, object> cachedAssets;
    
    // Methods
    public UnityEngine.GameObject GetPrefabFromBundle(string bundleName, string prefabName)
    {
        object val_8;
        var val_9;
        var val_10;
        if((this.CacheHasAsset(bundleName:  bundleName, assetName:  prefabName)) == false)
        {
            goto label_1;
        }
        
        object val_2 = this.GetObjectFromCache(bundleName:  bundleName, assetName:  prefabName);
        if(this == 0)
        {
            goto label_2;
        }
        
        if(null != null)
        {
                val_8 = 0;
        }
        
        return;
        label_1:
        float val_8 = 5.967528E-38f;
        val_8 = 8206360 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if((App.dlcManager.IsAssetAvailable(bundleName:  bundleName, version:  0)) == false)
        {
            goto label_10;
        }
        
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        UnityEngine.AssetBundle val_4 = App.dlcManager.GetBundle(bundleName:  bundleName);
        object val_5 = App.dlcManager.LoadAsset<System.Object>(name:  prefabName);
        val_8 = App.dlcManager;
        this.PutAssetInCache(bundleName:  bundleName, assetName:  prefabName, toPutInCache:  val_8);
        return;
        label_2:
        val_8 = 0;
        return;
        label_10:
        string val_6 = +477709520;
        UnityEngine.UnityException val_7 = new UnityEngine.UnityException(message:  477709520);
    }
    public UnityEngine.Font GetFontFromBundle(string bundleName, string fontName)
    {
        object val_8;
        var val_9;
        var val_10;
        if((this.CacheHasAsset(bundleName:  bundleName, assetName:  fontName)) == false)
        {
            goto label_1;
        }
        
        object val_2 = this.GetObjectFromCache(bundleName:  bundleName, assetName:  fontName);
        if(this == 0)
        {
            goto label_2;
        }
        
        if(null != null)
        {
                val_8 = 0;
        }
        
        return;
        label_1:
        float val_8 = 5.966761E-38f;
        val_8 = 8207728 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if((App.dlcManager.IsAssetAvailable(bundleName:  bundleName, version:  0)) == false)
        {
            goto label_10;
        }
        
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        UnityEngine.AssetBundle val_4 = App.dlcManager.GetBundle(bundleName:  bundleName);
        object val_5 = App.dlcManager.LoadAsset<System.Object>(name:  fontName);
        val_8 = App.dlcManager;
        this.PutAssetInCache(bundleName:  bundleName, assetName:  fontName, toPutInCache:  val_8);
        return;
        label_2:
        val_8 = 0;
        return;
        label_10:
        string val_6 = +477709520;
        UnityEngine.UnityException val_7 = new UnityEngine.UnityException(message:  477709520);
    }
    public UnityEngine.Sprite GetSpriteFromBundle(string bundleName, string spriteName)
    {
        object val_8;
        var val_9;
        var val_10;
        if((this.CacheHasAsset(bundleName:  bundleName, assetName:  spriteName)) == false)
        {
            goto label_1;
        }
        
        object val_2 = this.GetObjectFromCache(bundleName:  bundleName, assetName:  spriteName);
        if(this == 0)
        {
            goto label_2;
        }
        
        if(null != null)
        {
                val_8 = 0;
        }
        
        return;
        label_1:
        float val_8 = 5.966261E-38f;
        val_8 = 8208620 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if((App.dlcManager.IsAssetAvailable(bundleName:  bundleName, version:  0)) == false)
        {
            goto label_10;
        }
        
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        UnityEngine.AssetBundle val_4 = App.dlcManager.GetBundle(bundleName:  bundleName);
        object val_5 = App.dlcManager.LoadAsset<System.Object>(name:  spriteName);
        val_8 = App.dlcManager;
        this.PutAssetInCache(bundleName:  bundleName, assetName:  spriteName, toPutInCache:  val_8);
        return;
        label_2:
        val_8 = 0;
        return;
        label_10:
        string val_6 = +477709520;
        UnityEngine.UnityException val_7 = new UnityEngine.UnityException(message:  477709520);
    }
    public UnityEngine.Texture GetTextureFromBundle(string bundleName, string textureName)
    {
        var val_8;
        object val_9;
        var val_10;
        var val_11;
        val_8 = this;
        if((this.CacheHasAsset(bundleName:  bundleName, assetName:  textureName)) != false)
        {
                object val_2 = this.GetObjectFromCache(bundleName:  bundleName, assetName:  textureName);
            val_9 = 0;
            if(val_8 == 0)
        {
                return;
        }
        
            if(((ResourceLoader.__il2cppRuntimeField_typeHierarchy + (UnityEngine.Texture.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_8 = 0;
        }
        
            val_9 = val_8;
            return;
        }
        
        float val_8 = 5.965743E-38f;
        val_8 = 8209544 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        if((App.dlcManager.IsAssetAvailable(bundleName:  bundleName, version:  0)) != false)
        {
                if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_11 = null;
            val_11 = null;
            UnityEngine.AssetBundle val_4 = App.dlcManager.GetBundle(bundleName:  bundleName);
            object val_5 = App.dlcManager.LoadAsset<System.Object>(name:  textureName);
            val_9 = App.dlcManager;
            this.PutAssetInCache(bundleName:  bundleName, assetName:  textureName, toPutInCache:  val_9);
            return;
        }
        
        string val_6 = +477709520;
        UnityEngine.UnityException val_7 = new UnityEngine.UnityException(message:  477709520);
    }
    public UnityEngine.AudioClip GetSoundFromBundle(string bundleName, string audioClipName)
    {
        object val_8;
        var val_9;
        var val_10;
        if((this.CacheHasAsset(bundleName:  bundleName, assetName:  audioClipName)) == false)
        {
            goto label_1;
        }
        
        object val_2 = this.GetObjectFromCache(bundleName:  bundleName, assetName:  audioClipName);
        if(this == 0)
        {
            goto label_2;
        }
        
        if(null != null)
        {
                val_8 = 0;
        }
        
        return;
        label_1:
        float val_8 = 5.965248E-38f;
        val_8 = 8210428 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if((App.dlcManager.IsAssetAvailable(bundleName:  bundleName, version:  0)) == false)
        {
            goto label_10;
        }
        
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        UnityEngine.AssetBundle val_4 = App.dlcManager.GetBundle(bundleName:  bundleName);
        object val_5 = App.dlcManager.LoadAsset<System.Object>(name:  audioClipName);
        val_8 = App.dlcManager;
        this.PutAssetInCache(bundleName:  bundleName, assetName:  audioClipName, toPutInCache:  val_8);
        return;
        label_2:
        val_8 = 0;
        return;
        label_10:
        string val_6 = +477709520;
        UnityEngine.UnityException val_7 = new UnityEngine.UnityException(message:  477709520);
    }
    private bool CacheHasAsset(string bundleName, string assetName)
    {
        string val_1 = bundleName + 2144339952 + assetName;
        if(this.cachedAssets != 0)
        {
                return this.cachedAssets.ContainsKey(key:  bundleName);
        }
        
        return this.cachedAssets.ContainsKey(key:  bundleName);
    }
    private object GetObjectFromCache(string bundleName, string assetName)
    {
        string val_1 = bundleName + 2144339952 + assetName;
        if(this.cachedAssets != 0)
        {
                return this.cachedAssets.Item[bundleName];
        }
        
        return this.cachedAssets.Item[bundleName];
    }
    private void PutAssetInCache(string bundleName, string assetName, object toPutInCache)
    {
        string val_1 = bundleName + 2144339952 + assetName;
        this.cachedAssets.Add(key:  bundleName, value:  toPutInCache);
    }
    private void Init()
    {
        this.initialized = true;
    }
    public ResourceLoader()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.cachedAssets = null;
    }

}
