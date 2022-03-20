using UnityEngine;
public class SeasonalSkinsManager : MonoSingleton<SeasonalSkinsManager>
{
    // Fields
    private System.Collections.Generic.Dictionary<SeasonSkinnedFeature, System.Collections.Generic.List<SeasonalSkin>> parsedSkinsForFeatures;
    
    // Methods
    public UnityEngine.Texture GetTexture(string assetName)
    {
        if((twelvegigs.net.ImageRequest.ImageInLocal(imgPath:  assetName)) == false)
        {
                return;
        }
        
        UnityEngine.Texture2D val_2 = twelvegigs.net.ImageRequest.LoadLocally(remoteURL:  null, fileName:  assetName);
        0 = 0;
    }
    public SeasonalSkin IsSkinActive(SeasonSkinnedFeature feature)
    {
        var val_5;
        var val_7;
        var val_8;
        val_7 = this;
        val_8 = 0;
        if((this.parsedSkinsForFeatures.ContainsKey(key:  feature)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<SeasonalSkin> val_2 = this.parsedSkinsForFeatures.Item[feature];
        List.Enumerator<T> val_3 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        val_7 = val_5;
        if(val_7.Active() == false)
        {
            goto label_7;
        }
        
        goto label_8;
        label_5:
        val_7 = 0;
        label_8:
        Dispose();
        val_8 = val_7;
    }
    public override void InitMonoSingleton()
    {
        this.InitMonoSingleton();
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1039954208, method:  new IntPtr(3254988064));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        this.ParseKnobs();
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode modo)
    {
        this.ParseKnobs();
    }
    private void ParseKnobs()
    {
        var val_12;
        var val_19;
        string val_29;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_31 = 27824207;
        val_31 = 7803208 + val_31;
        if(val_31 == 0)
        {
                mem2[0] = 1;
        }
        
        val_31 = null;
        val_31 = null;
        twelvegigs.storage.JsonDictionary val_1 = getWordGameplayKnobs();
        if(App.storageManager.knobsModel == 0)
        {
                return;
        }
        
        if((Contains(key:  -1039746016)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_3 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        mem[1152921512157063916] = null;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = getDictionary(key:  -1039746016);
        Dictionary.Enumerator<TKey, TValue> val_5 = GetEnumerator();
        var val_34 = 0;
        label_61:
        if(0.MoveNext() == false)
        {
            goto label_11;
        }
        
        SeasonSkinnedFeature val_8 = this.KnobToFeature(key:  1179403647);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if( != 0)
        {
                val_32 = null;
        }
        
        if( != 0)
        {
                val_32 = null;
            val_33 = 0;
            if(((mem[1768188873] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_32)
        {
                 = 0;
        }
        
            val_33 = ;
        }
        else
        {
                val_33 = 0;
        }
        
        List.Enumerator<T> val_10 = GetEnumerator();
        label_51:
        if(MoveNext() == false)
        {
            goto label_18;
        }
        
        val_34 = 0;
        if(val_12 != 0)
        {
                if(((val_12 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_12 = 0;
        }
        
            val_34 = val_12;
        }
        
        string val_14 = val_34.Item[-1605007504];
        typeof(SeasonalSkin).__il2cppRuntimeField_18 = System.Int32.Parse(s:  null, style:  511);
        string val_16 = val_34.Item[-1039743872];
        typeof(System.Char[]).__il2cppRuntimeField_10 = 47;
        System.String[] val_17 = val_34.Split(separator:  478563824);
        System.DateTime val_18 = DateTimeCheat.Now;
        System.DateTime val_24 = new System.DateTime(year:  val_19.Year, month:  System.Int32.Parse(s:  2621443, style:  511), day:  System.Int32.Parse(s:  1, style:  511));
        typeof(SeasonalSkin).__il2cppRuntimeField_10 = val_24.dateData;
        string val_25 = val_34.Item[-1125089920];
        typeof(SeasonalSkin).__il2cppRuntimeField_8 = val_34;
        var val_32 = val_34;
        string val_26 = val_34.Item[-1039743792];
        if(val_34 != 0)
        {
                val_35 = null;
        }
        
        if(val_34 != 0)
        {
                val_35 = null;
            val_36 = 0;
            if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_35)
        {
                val_34 = 0;
        }
        
            val_36 = val_34;
        }
        else
        {
                val_36 = 0;
        }
        
        List.Enumerator<T> val_27 = GetEnumerator();
        label_46:
        if(MoveNext() == false)
        {
            goto label_43;
        }
        
        string val_30 = GetAssetName(textureId:  val_29);
        DownloadAsset(assetPath:  332001280);
        goto label_46;
        label_43:
        val_32 = val_32 + 1;
        mem2[0] = 367;
        Dispose();
        if(val_32 != 1)
        {
                if(val_32 > 1)
        {
                0 = 1;
        }
        
            var val_33 = -1039729848 + ((0 + 1)) << 2;
            val_33 = val_33 - 367;
            val_33 = val_33 >> 5;
            val_33 = 1 & val_33;
            val_32 = val_32 - val_33;
        }
        
        Add(item:  332001280);
        goto label_51;
        label_18:
        val_34 = val_34 + 1;
        mem2[0] = 404;
        Dispose();
        if(val_34 != 1)
        {
                if(val_34 > 1)
        {
                0 = 1;
        }
        
            var val_35 = -1039729848 + ((0 + 1)) << 2;
            val_35 = val_35 - 404;
            val_35 = val_35 >> 5;
            val_35 = 1 & val_35;
            val_34 = val_34 - val_35;
        }
        
        set_Item(key:  0, value:  80883712);
        goto label_61;
        label_11:
        0.Dispose();
    }
    private void DownloadAsset(string assetPath)
    {
        if((twelvegigs.net.ImageRequest.ImageInLocal(imgPath:  assetPath)) != false)
        {
                return;
        }
        
        string val_2 = System.String.Format(format:  -1039625568, arg0:  assetPath);
        twelvegigs.net.ImageRequest val_3 = new twelvegigs.net.ImageRequest(url:  -1039625568, filename:  assetPath, imgComplete:  0, imgError:  0, showErrors:  true, destroy:  false, cached:  true, save:  true);
        if(null == 0)
        {
            
        }
    
    }
    private SeasonSkinnedFeature KnobToFeature(string key)
    {
        if((System.String.op_Equality(a:  key, b:  -1039505232)) != false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  key, b:  -1039505152)) == true)
        {
                return;
        }
        
        string val_3 = -1039505072(-1039505072) + R4 + -1977566752(-1977566752);
        System.Exception val_4 = new System.Exception(message:  -1039505072);
    }
    public SeasonalSkinsManager()
    {
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        this.parsedSkinsForFeatures = null;
    }

}
