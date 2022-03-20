using UnityEngine;
public class DLCManager : MonoBehaviour
{
    // Fields
    private string currentAssetToLoad;
    private string currentAssetPath;
    private int currentAssetVersion;
    private bool executing;
    private bool dlc_loaded;
    private string baseString;
    private const string PP_SavedDLC = "PP_SavedDLC";
    private System.Collections.Generic.Dictionary<string, int> SavedAssetsMap;
    private System.Action<UnityEngine.AssetBundle> currentOnDownloadedCallback;
    private System.Collections.Generic.List<DLCManager.DLCRequest> RequestsQueue;
    private static System.Collections.Generic.Dictionary<string, UnityEngine.AssetBundle> LoadedAssets;
    public const string NOTIFICATION_ASSET_LOADED = "OnAssetLoaded";
    private bool hasCheckedVersion;
    private string fileExtension;
    
    // Properties
    private static char slash { get; }
    
    // Methods
    public void DownloadResource(string bundlePath, string bundleName, int bundleVersion, System.Action<UnityEngine.AssetBundle> onDownloadedCallback)
    {
        if(this.executing != false)
        {
                this.EnqueueRequest(assetToLoad:  bundleName, assetPath:  bundlePath, assetVersion:  bundleVersion, onDownloadedCallback:  onDownloadedCallback);
            return;
        }
        
        this.currentAssetToLoad = bundleName;
        this.currentAssetPath = bundlePath;
        this.currentAssetVersion = bundleVersion;
        this.currentOnDownloadedCallback = onDownloadedCallback;
        System.Collections.IEnumerator val_1 = this.Execute();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -2041295312);
    }
    public UnityEngine.AssetBundle GetBundle(string bundleName)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((DLCManager.NOTIFICATION_ASSET_LOADED.ContainsKey(key:  bundleName)) == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        string val_2 = DLCManager.NOTIFICATION_ASSET_LOADED.Item[bundleName];
    }
    public bool IsAssetAvailable(string bundleName, int version = -1)
    {
        null = null;
        if(DLCManager.NOTIFICATION_ASSET_LOADED != null)
        {
                return DLCManager.NOTIFICATION_ASSET_LOADED.ContainsKey(key:  bundleName);
        }
        
        return DLCManager.NOTIFICATION_ASSET_LOADED.ContainsKey(key:  bundleName);
    }
    public static string DLCPath()
    {
        var val_4;
        string val_1 = UnityEngine.Application.dataPath;
        var val_4 = 21488404;
        val_4 = 14152952 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        string val_2 = System.IO.Path.DirectorySeparatorChar.ToString();
        string val_3 = null + -2040940530(-2040940530) + -2040952592(-2040952592);
    }
    private void Awake()
    {
        this.Initialize();
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -2040815488, method:  new IntPtr(2254126784));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        this.LoadAssets();
    }
    private void Initialize()
    {
        this.fileExtension = "";
        AppConfigs val_1 = App.Configuration;
        this.currentAssetVersion = 23;
        this.LoadAlreadySavedAssets();
        this.LoadAssets();
    }
    private void LoadAssets()
    {
        string val_4;
        AppConfigs val_1 = App.Configuration;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_8:
        bool val_3 = MoveNext();
        if(val_3 == false)
        {
            goto label_6;
        }
        
        if((val_3.IsAssetAvailable(bundleName:  val_4, version:  1989547712)) == true)
        {
            goto label_8;
        }
        
        System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -2040469152, method:  new IntPtr(2254473120));
        this.DownloadResource(bundlePath:  -2040495296, bundleName:  val_4, bundleVersion:  this.currentAssetVersion, onDownloadedCallback:  null);
        goto label_8;
        label_6:
        Dispose();
    }
    private void LoadAlreadySavedAssets()
    {
        string val_7;
        var val_12;
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_1 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        this.SavedAssetsMap = null;
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -2040381072, defaultValue:  -2040381152);
        object val_3 = MiniJSON.Json.Deserialize(json:  -2040381072);
        if("PP_SavedDLC" != 0)
        {
                if(null == null)
        {
            goto label_16;
        }
        
        }
        
        if("PP_SavedDLC" != 0)
        {
                label_16:
        }
        
        val_12 = 0;
        Dictionary.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        label_12:
        if(0.MoveNext() == false)
        {
            goto label_7;
        }
        
        if((this.SavedAssetsMap.ContainsKey(key:  null)) == true)
        {
            goto label_12;
        }
        
        this.SavedAssetsMap.Add(key:  null, value:  System.Int32.Parse(s:  val_7, style:  511));
        goto label_12;
        label_7:
        0.Dispose();
        Dictionary.Enumerator<TKey, TValue> val_10 = 0.GetEnumerator();
        label_15:
        if(0.MoveNext() == false)
        {
            goto label_14;
        }
        
        this.DownloadResource(bundlePath:  -2040495296, bundleName:  null, bundleVersion:  0, onDownloadedCallback:  0);
        goto label_15;
        label_14:
        0.Dispose();
    }
    private void SaveAlreadySavedAssets()
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  this.SavedAssetsMap);
        UnityEngine.PlayerPrefs.SetString(key:  -2040381072, value:  this.SavedAssetsMap);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private void CheckAllAssetsLoaded(UnityEngine.AssetBundle loaded)
    {
        UnityEngine.Material val_4;
        UnityEngine.Material val_6;
        var val_7;
        if(this.dlc_loaded == true)
        {
                return;
        }
        
        AppConfigs val_1 = App.Configuration;
        val_6 = 34776364;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        val_7 = null;
        val_6 = val_4;
        val_7 = null;
        if((DLCManager.NOTIFICATION_ASSET_LOADED.ContainsKey(key:  val_6)) == true)
        {
            goto label_11;
        }
        
        Dispose();
        return;
        label_7:
        Dispose();
        this.dlc_loaded = true;
    }
    private void EnqueueRequest(string assetToLoad, string assetPath, int assetVersion, System.Action<UnityEngine.AssetBundle> onDownloadedCallback)
    {
        if((this.AlreadyQueued(assetToLoad:  assetToLoad)) != false)
        {
                return;
        }
        
        object val_2 = new System.Object();
        typeof(DLCManager.DLCRequest).__il2cppRuntimeField_8 = assetToLoad;
        typeof(DLCManager.DLCRequest).__il2cppRuntimeField_C = assetPath;
        typeof(DLCManager.DLCRequest).__il2cppRuntimeField_10 = assetVersion;
        typeof(DLCManager.DLCRequest).__il2cppRuntimeField_14 = onDownloadedCallback;
        this.RequestsQueue.Add(item:  281149440);
    }
    private bool AlreadyQueued(string assetToLoad)
    {
        var val_5;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((System.String.op_Equality(a:  val_3 + 8, b:  assetToLoad)) == false)
        {
            goto label_4;
        }
        
        val_5 = 1;
        goto label_5;
        label_2:
        val_5 = 0;
        label_5:
        Dispose();
        return (bool)val_5;
    }
    private static char get_slash()
    {
        null = null;
        return (char)System.IO.Path.DirectorySeparatorChar;
    }
    private System.Collections.IEnumerator Execute()
    {
        object val_1 = new System.Object();
        typeof(DLCManager.<Execute>d__29).__il2cppRuntimeField_8 = 0;
        typeof(DLCManager.<Execute>d__29).__il2cppRuntimeField_10 = this;
    }
    private void Dequeue()
    {
        if(true < 1)
        {
            goto label_2;
        }
        
        if(true == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.RequestsQueue.RemoveAt(index:  0);
        if(2621443 == 0)
        {
            goto label_6;
        }
        
        this.currentAssetToLoad = 406886400;
        this.currentAssetPath = static_value_0028000F;
        this.currentAssetVersion = 406887424;
        goto label_7;
        label_2:
        this.executing = false;
        return;
        label_6:
        this.currentAssetToLoad = 0;
        this.currentAssetPath = 0;
        this.currentAssetVersion = 2621443;
        label_7:
        this.currentOnDownloadedCallback = 5890;
        System.Collections.IEnumerator val_1 = this.Execute();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -2039462384);
    }
    public DLCManager()
    {
        this.currentAssetVersion = 1;
        this.baseString = "https://cdn.12gigs.com/{0}/v{1}/";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.RequestsQueue = null;
        this.fileExtension = "";
    }
    private static DLCManager()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        DLCManager.NOTIFICATION_ASSET_LOADED = null;
    }

}
