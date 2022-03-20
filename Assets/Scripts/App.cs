using UnityEngine;
public class App : MonoBehaviour
{
    // Fields
    protected static bool initialServerCallDone;
    protected static bool appStarted;
    protected static System.Collections.Generic.List<float> sceneLoadingTimes;
    protected static float sceneStartedLoading;
    public static System.Action onAppQuitAction;
    private static WordGames.GameNames game;
    public const string KNOBS = "knobs";
    public const string USERS = "users";
    public static readonly int SecondsToDimScreen;
    private static GameBehavior myBehavior;
    private static GameEcon myGameEcon;
    protected static System.Collections.Generic.List<AppComponent> components;
    private AppConfigs appConfigs;
    protected static AppConfigs config;
    private UnityEngine.Texture2D warningBackground;
    private UnityEngine.GUIStyle warningStyle;
    private float warningHeight;
    private static string iOSLoadingTime;
    public static bool created;
    private bool isFistSceneLoad;
    protected static UnityEngine.GameObject objectContainer;
    private static twelvegigs.storage.StorageManager storageManager;
    private static twelvegigs.net.JsonApiRequester networkManager;
    private static TrackerManager trackerManager;
    private static InAppPurchasesManager inAppPurchasesManager;
    private static DLCManager dlcManager;
    private static ThemesHandler themesHandler;
    private Player playerData;
    private static Player player;
    private static bool isQuitting;
    
    // Properties
    public static bool HasAppStarted { get; }
    public static WordGames.GameNames Game { get; set; }
    public static GameBehavior getBehavior { get; }
    public static GameEcon getGameEcon { get; }
    public virtual bool LogServer { get; }
    public virtual System.Collections.Generic.List<System.Type> GameComponents { get; }
    public virtual object[] GameComponentArguments { get; }
    public static AppConfigs Configuration { get; }
    public static string IOSLoadingTime { get; }
    public static twelvegigs.storage.StorageManager Storage { get; }
    public static twelvegigs.net.JsonApiRequester ApiRequester { get; }
    public static TrackerManager Tracker { get; }
    public static InAppPurchasesManager Purchases { get; }
    public static DLCManager DLC { get; }
    public static ThemesHandler ThemesHandler { get; }
    public static Player Player { get; }
    public static bool IsQuitting { get; }
    
    // Methods
    public static bool get_HasAppStarted()
    {
        null = null;
        return (bool)App.appStarted;
    }
    public static WordGames.GameNames get_Game()
    {
        null = null;
    }
    public static void set_Game(WordGames.GameNames value)
    {
        null = null;
        App.game = value;
    }
    public static GameBehavior get_getBehavior()
    {
        var val_4;
        var val_5;
        GameBehavior val_7;
        val_4 = 0;
        val_5 = null;
        val_4 = (App.__il2cppRuntimeField_BA & 512);
        val_7 = App.myBehavior;
        if(val_7 != 0)
        {
                val_7 = App.myBehavior;
            return;
        }
        
        GameBehavior val_2 = null;
        val_7 = val_2;
        val_2 = new GameBehavior(name:  App.game);
        App.myBehavior = val_7;
    }
    public static GameEcon get_getGameEcon()
    {
        var val_12;
        var val_13;
        GameEcon val_15;
        GameNames val_16;
        var val_17;
        val_12 = 0;
        val_13 = null;
        val_12 = (App.__il2cppRuntimeField_BA & 512);
        val_15 = App.myGameEcon;
        if(val_15 != 0)
        {
                val_15 = App.myGameEcon;
            return;
        }
        
        val_13 = null;
        val_16 = App.game;
        if(val_16 == 12)
        {
                WordPets.WPTGameEcon val_2 = null;
            val_15 = val_2;
            val_2 = new WordPets.WPTGameEcon();
        }
        else
        {
                val_13 = null;
            val_16 = App.game;
            if(val_16 == 16)
        {
                BlockPuzzleMagic.BestBlocksGameEcon val_3 = null;
            val_15 = val_3;
            val_3 = new BlockPuzzleMagic.BestBlocksGameEcon();
        }
        else
        {
                val_13 = null;
            val_16 = App.game;
            if(val_16 == 17)
        {
                TRVEcon val_4 = null;
            val_15 = val_4;
            val_4 = new TRVEcon();
        }
        else
        {
                val_13 = null;
            val_16 = App.game;
            if(val_16 == 18)
        {
                WordForest.WFOGameEcon val_5 = null;
            val_15 = val_5;
            val_5 = new WordForest.WFOGameEcon();
        }
        else
        {
                val_13 = null;
            val_16 = App.game;
            if(val_16 == 99)
        {
                SLC.Wordlicious.WOLGameEcon val_6 = null;
            val_15 = val_6;
            val_6 = new SLC.Wordlicious.WOLGameEcon();
        }
        else
        {
                val_13 = null;
            val_16 = App.game;
            if(val_16 == 19)
        {
                FPHEcon val_7 = null;
            val_15 = val_7;
            val_7 = new FPHEcon();
        }
        else
        {
                val_13 = null;
            val_16 = App.game;
            if(val_16 == 20)
        {
                RestaurantRivals.RESGameEcon val_8 = null;
            val_15 = val_8;
            val_8 = new RestaurantRivals.RESGameEcon();
        }
        else
        {
                val_16 = App.game;
            if(val_16 == 21)
        {
                SLC.MatchyPics.MPIGameEcon val_9 = null;
            val_15 = val_9;
            val_9 = new SLC.MatchyPics.MPIGameEcon();
        }
        else
        {
                GameEcon val_10 = null;
            val_15 = val_10;
            val_10 = new GameEcon();
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        val_17 = null;
        val_17 = null;
        App.myGameEcon = val_15;
    }
    public static T GetGameSepeciticEcon<T>()
    {
        var val_3;
        GameEcon val_4;
        var val_5;
        GameEcon val_6;
        var val_7;
        val_3 = null;
        val_3 = null;
        val_4 = App.myGameEcon;
        if(val_4 == 0)
        {
            goto label_3;
        }
        
        val_4 = App.myGameEcon;
        val_5 = null;
        if(val_4 != 0)
        {
            goto label_7;
        }
        
        label_3:
        val_3 = null;
        val_6 = App.myGameEcon;
        if(val_6 != 0)
        {
                val_6 = App.myGameEcon;
            System.Type val_1 = val_6.GetType();
            string val_2 = -1977686256(-1977686256) + val_6;
            UnityEngine.Debug.LogError(message:  -1977686256);
        }
        
        val_7 = null;
        val_7 = null;
        App.myGameEcon = __RuntimeMethodHiddenParam + 24 + 4;
        label_7:
        val_7 = null;
        if(App.myGameEcon == 0)
        {
                return;
        }
        
        if(App.myGameEcon == 0)
        {
                return;
        }
    
    }
    public static AppComponent GetComponent(System.Type tipo)
    {
        System.Type val_3;
        var val_9;
        System.Collections.Generic.List<AppComponent> val_10;
        var val_11;
        System.Type val_12;
        System.Type val_13;
        var val_14;
        var val_15;
        val_9 = null;
        val_9 = null;
        val_10 = App.components;
        if(val_10 == 0)
        {
            goto label_7;
        }
        
        val_10 = App.components;
        if(val_10 == 0)
        {
            goto label_45;
        }
        
        if((App.components + 12) == 0)
        {
            goto label_7;
        }
        
        val_11 = null;
        val_11 = null;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_18:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        val_12 = val_3;
        System.Type val_4 = val_12.GetType();
        val_13 = val_12;
        if((System.Type.op_Equality(left:  val_13, right:  tipo)) == true)
        {
            goto label_15;
        }
        
        System.Type val_6 = val_12.GetType();
        val_13 = val_12;
        if(val_13 == 0)
        {
            goto label_18;
        }
        
        label_15:
        Dispose();
        return;
        label_7:
        val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_14 == 1)
        {
                val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        val_12 = 0;
        label_37:
        D.LogClientError(developer:  -1977566992, filter:  1788750208, context:  0, strings:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        return;
        label_11:
        Dispose();
        label_48:
        string val_7 = -1977566864(-1977566864) + tipo + -1977566752(-1977566752);
        val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_15 != 1)
        {
            goto label_37;
        }
        
        val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        goto label_37;
        label_45:
        if(val_10 != 1)
        {
            goto label_46;
        }
        
        Dispose();
        if(App.USERS == null)
        {
            goto label_48;
        }
        
        goto label_48;
        label_46:
    }
    public virtual bool get_LogServer()
    {
        return true;
    }
    public virtual System.Collections.Generic.List<System.Type> get_GameComponents()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }
    public virtual object[] get_GameComponentArguments()
    {
    
    }
    public static AppConfigs get_Configuration()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        if(App.config == 0)
        {
                object val_2 = UnityEngine.Object.FindObjectOfType<System.Object>();
            val_5 = null;
            val_5 = null;
            App.config = null;
        }
        else
        {
                val_5 = null;
        }
        
        val_5 = null;
        if(App.config == 0)
        {
                UnityEngine.Debug.LogError(message:  -1977113536);
        }
        
        val_6 = null;
        val_6 = null;
    }
    public static string get_IOSLoadingTime()
    {
        null = null;
    }
    protected void initMainModules()
    {
        var val_24;
        var val_25;
        var val_26;
        System.Action val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        AppConfigs val_1 = App.Configuration;
        val_24 = 1152921504765685760;
        if(285196288 == 0)
        {
                UnityEngine.Debug.LogError(message:  -1976889440);
        }
        
        val_25 = null;
        val_25 = null;
        if(App.networkManager == 0)
        {
                AppConfigs val_3 = App.Configuration;
            val_26 = null;
            val_26 = null;
            val_28 = App.<>c.<>9__39_0;
            if(val_28 == 0)
        {
                val_28 = null;
            val_28 = new System.Action(object:  App.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2318078032));
            App.<>c.<>9__39_0 = val_28;
        }
        
            AppConfigs val_5 = App.Configuration;
            string val_6 = GetAdminURL();
            twelvegigs.net.JsonApiRequester val_7 = new twelvegigs.net.JsonApiRequester(ServerURL:  .__il2cppRuntimeField_6C, dequeueHandler:  7454720, logStuff:  true, adminServerURL:  App.__il2cppRuntimeField_namespaze, throwExceptionsOnRequestFailures:  true);
            val_25 = null;
            App.networkManager = null;
            val_24 = 1152921504765685760;
        }
        
        val_25 = null;
        if(App.storageManager == 0)
        {
                AppConfigs val_8 = App.Configuration;
            AppConfigs val_9 = App.Configuration;
            val_28 = val_25;
            string val_10 = System.String.Format(format:  1629069648, arg0:  .__il2cppRuntimeField_70, arg1:  .__il2cppRuntimeField_10);
            App.storageManager = new twelvegigs.storage.StorageManager(resourcesPath:  1629069648);
            initialize();
            val_25 = null;
        }
        
        val_25 = null;
        if(App.trackerManager == 0)
        {
                TrackerManager val_12 = TrackerManager.Instance;
            val_25 = null;
            val_25 = null;
            App.trackerManager = 0;
        }
        
        val_25 = null;
        if(App.inAppPurchasesManager == 0)
        {
                InAppPurchasesManager val_13 = InAppPurchasesManager.Instance;
            val_29 = null;
            val_29 = null;
            App.inAppPurchasesManager = 0;
        }
        
        WGBonusRewardsHandler val_14 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((-1976888240) == 0)
        {
                UnityEngine.Debug.LogError(message:  -1976887216);
        }
        
        WGBonusRewardsHandler val_16 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((-1976887008) == 0)
        {
                UnityEngine.Debug.LogError(message:  -1976885984);
        }
        
        val_30 = null;
        val_30 = null;
        if(App.dlcManager == 0)
        {
                UnityEngine.GameObject val_19 = this.gameObject;
            object val_20 = this.AddComponent<System.Object>();
            val_31 = null;
            val_31 = null;
            App.dlcManager = this;
        }
        else
        {
                val_31 = null;
        }
        
        val_31 = null;
        if(App.themesHandler == 0)
        {
                UnityEngine.GameObject val_22 = this.gameObject;
            object val_23 = this.AddComponent<System.Object>();
            val_32 = null;
            val_32 = null;
            App.themesHandler = this;
        }
        
        UnityEngine.Application.targetFrameRate = 60;
        UnityEngine.Screen.sleepTimeout = 1;
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        var val_11;
        InAppPurchasesManager val_12;
        var val_13;
        var val_14;
        val_11 = null;
        val_11 = null;
        if(App.appStarted == false)
        {
                return;
        }
        
        if(pauseStatus != false)
        {
                Player val_1 = App.Player;
            System.DateTime val_2 = System.DateTime.UtcNow;
            string val_3 = ???.ToString(format:  -1976771728);
            typeof(UnityEngine.MonoBehaviour).__il2cppRuntimeField_88 = ;
            Player val_4 = App.Player;
            ???.SaveState();
        }
        else
        {
                WGBonusRewardsHandler val_5 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            RequestDataFlush(immediate:  false, reset:  false);
        }
        
        App.pauseComponents(pauseStatus:  pauseStatus);
        if(pauseStatus == true)
        {
                return;
        }
        
        Player val_6 = App.Player;
        if(285196288 != 0)
        {
                Player val_8 = App.Player;
            typeof(App).__il2cppRuntimeField_C = 0;
        }
        
        AppConfigs val_9 = App.Configuration;
        string val_10 = 0.Key(key:  -1976771616);
        val_13 = null;
        val_13 = null;
        val_12 = App.inAppPurchasesManager;
        if(App.inAppPurchasesManager.initialized != true)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        App.inAppPurchasesManager.Init(key:  null);
    }
    public virtual void startApp()
    {
    
    }
    public virtual void initCustomBackend()
    {
    
    }
    public virtual void OnServerUpdatedData()
    {
    
    }
    private void Awake()
    {
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        if(App.created != false)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            val_8 = null;
            val_8 = null;
            if((-1976297360) == App.objectContainer)
        {
                return;
        }
        
            UnityEngine.GameObject val_3 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  -1976297360);
            return;
        }
        
        this.Persist();
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1976297360, name:  -1976323520);
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_5 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1976297360, method:  new IntPtr(2318643888));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        System.Action val_6 = new System.Action(object:  0, method:  new IntPtr(2318644912));
        UnityEngine.Application.add_quitting(value:  7454720);
    }
    private void Start()
    {
        UnityEngine.Debug.Log(message:  -1976209360);
        Player val_1 = App.Player;
        if(285196288 == 0)
        {
                UnityEngine.Debug.Log(message:  -1976209264);
        }
        
        this.initMainModules();
        this.awakeApp();
        WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
    }
    private void Persist()
    {
        var val_4;
        UnityEngine.Transform val_1 = this.transform;
        this.parent = 0;
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -1976073152);
        val_4 = null;
        val_4 = null;
        App.created = true;
        UnityEngine.GameObject val_3 = this.gameObject;
        App.objectContainer = this;
    }
    public void OnServerResponded(Notification notif)
    {
        goto typeof(App).__il2cppRuntimeField_104;
    }
    private void awakeApp()
    {
        System.Type val_5;
        var val_11;
        var val_13;
        var val_14;
        var val_15;
        val_11 = 1152921504892043264;
        val_13 = null;
        val_13 = null;
        if(App.components != 0)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        App.components = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_11 = this;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_16:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        object val_6 = System.Activator.CreateInstance(type:  val_5, args:  -1975837888);
        val_15 = val_5;
        val_15 = 0;
        if(val_15 == 0)
        {
            goto label_11;
        }
        
        Add(item:  0);
        goto label_16;
        label_11:
        System.Threading.ThreadStart val_7 = new System.Threading.ThreadStart(object:  0, method:  new IntPtr(2319104384));
        System.Threading.Thread val_8 = new System.Threading.Thread(start:  41746432);
        Start();
        Join();
        goto label_16;
        label_7:
        Dispose();
        System.Collections.IEnumerator val_9 = LoadComponentsInMT(componentsInMT:  80883712);
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -1975849944);
    }
    private System.Collections.IEnumerator LoadComponentsInMT(System.Collections.Generic.List<AppComponent> componentsInMT)
    {
        object val_1 = new System.Object();
        typeof(App.<LoadComponentsInMT>d__50).__il2cppRuntimeField_8 = 0;
        typeof(App.<LoadComponentsInMT>d__50).__il2cppRuntimeField_10 = componentsInMT;
    }
    public static void AddComponent(AppComponent component)
    {
        null = null;
        App.components.Add(item:  component);
    }
    public static void UpdateComponents()
    {
        var val_3;
        var val_4;
        val_4 = null;
        val_4 = null;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        if(val_3 != 0)
        {
            goto label_6;
        }
        
        goto label_6;
        label_4:
        Dispose();
    }
    public static void InitialUpdateComponents()
    {
        var val_3;
        var val_4;
        val_4 = null;
        val_4 = null;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        if(val_3 != 0)
        {
            goto label_6;
        }
        
        goto label_6;
        label_4:
        Dispose();
    }
    public static void startComponents()
    {
        var val_3;
        var val_4;
        val_4 = null;
        val_4 = null;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        if(val_3 != 0)
        {
            goto label_6;
        }
        
        goto label_6;
        label_4:
        Dispose();
    }
    public static void pauseComponents(bool pauseStatus)
    {
        var val_3;
        var val_4;
        System.Collections.Generic.List<AppComponent> val_5;
        val_4 = null;
        val_4 = null;
        val_5 = App.components;
        if(val_5 == 0)
        {
                return;
        }
        
        val_5 = App.components;
        if(val_5 == 0)
        {
                val_5 = 0;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        if(val_3 != 0)
        {
            goto label_9;
        }
        
        goto label_9;
        label_7:
        Dispose();
    }
    private void SceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        if(this.isFistSceneLoad == true)
        {
                this.isFistSceneLoad = false;
            this.isFistSceneLoad = this.isFistSceneLoad;
            return;
        }
        
        Player val_1 = App.Player;
        SaveState();
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
        App.RecordLoadingTime();
    }
    protected static void RecordLoadingTime()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(App.sceneLoadingTimes == 0)
        {
                System.Collections.Generic.List<System.Single> val_1 = new System.Collections.Generic.List<System.Single>();
            val_5 = null;
            val_5 = null;
            App.sceneLoadingTimes = null;
        }
        
        val_5 = null;
        float val_2 = UnityEngine.Time.time;
        val_6 = null;
        val_6 = null;
        float val_3 = UnityEngine.Time.time;
        Add(item:  0 - App.sceneStartedLoading);
        App.sceneStartedLoading = 0f;
    }
    public static System.Collections.Generic.List<float> GetLoadingTimes()
    {
        null = null;
    }
    public static void StartSceneLoadingTimer()
    {
        var val_2;
        float val_1 = UnityEngine.Time.time;
        val_2 = null;
        val_2 = null;
        App.sceneStartedLoading = 0;
    }
    public static twelvegigs.storage.StorageManager get_Storage()
    {
        null = null;
    }
    public static twelvegigs.net.JsonApiRequester get_ApiRequester()
    {
        null = null;
    }
    public static TrackerManager get_Tracker()
    {
        null = null;
    }
    public static InAppPurchasesManager get_Purchases()
    {
        null = null;
    }
    public static DLCManager get_DLC()
    {
        null = null;
    }
    public static ThemesHandler get_ThemesHandler()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = null;
        val_2 = null;
    }
    public static Player get_Player()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = null;
        val_5 = null;
        if(App.player == 0)
        {
                object val_2 = UnityEngine.Object.FindObjectOfType<System.Object>();
            System.Type val_3 = public static App UnityEngine.Object::FindObjectOfType<App>().__il2cppRuntimeField_20.GetType();
            UnityEngine.ScriptableObject val_4 = UnityEngine.ScriptableObject.CreateInstance(type:  public static App UnityEngine.Object::FindObjectOfType<App>().__il2cppRuntimeField_20);
            val_6 = mem[public static App UnityEngine.Object::FindObjectOfType<App>().__il2cppRuntimeField_20 + 180];
            val_6 = public static App UnityEngine.Object::FindObjectOfType<App>().__il2cppRuntimeField_20 + 180;
            public static App UnityEngine.Object::FindObjectOfType<App>().__il2cppRuntimeField_20 = 0;
            0.Initialize();
            val_7 = null;
            val_7 = null;
            App.player = public static App UnityEngine.Object::FindObjectOfType<App>().__il2cppRuntimeField_20;
        }
        else
        {
                val_7 = null;
        }
        
        val_7 = null;
    }
    public static void FlushConfigs()
    {
        bool val_1 = UnityEngine.Application.isEditor;
    }
    public static bool get_IsQuitting()
    {
        null = null;
        return (bool)App.isQuitting;
    }
    public static void Quit_event()
    {
        var val_1;
        System.Action val_2;
        TrackingComponent.TrackSession(sessionEnded:  true, quitButton:  false);
        val_1 = null;
        val_1 = null;
        App.isQuitting = true;
        val_2 = App.onAppQuitAction;
        if(val_2 == 0)
        {
                return;
        }
        
        val_2 = App.onAppQuitAction;
        if(val_2 == 0)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    public static void Quit()
    {
        var val_1;
        TrackingComponent.TrackSession(sessionEnded:  true, quitButton:  true);
        val_1 = null;
        val_1 = null;
        App.isQuitting = true;
        UnityEngine.Application.Quit();
    }
    public App()
    {
        float val_2 = (float)UnityEngine.Screen.height;
        this.isFistSceneLoad = true;
        val_2 = val_2 * 0.06f;
        this.warningHeight = val_2;
    }
    private static App()
    {
        App.USERS = 0;
        App.appStarted = 0;
        App.onAppQuitAction = 0;
        App.SecondsToDimScreen = 25;
        App.config = 0;
        App.iOSLoadingTime = "0";
        App.created = 0;
        App.player = 0;
        App.isQuitting = 0;
    }

}
