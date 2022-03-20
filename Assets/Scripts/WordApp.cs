using UnityEngine;
public class WordApp : App
{
    // Fields
    public const string NATIVE_CALLBACKS = "NativeCallbacks";
    public const string ON_DEFERRED_READY = "OnDeferredReady";
    public const string ON_SERVER_DATA_SYNC = "OnServerSync";
    public static System.Action DeferredServerDataReady;
    public static UnityEngine.Events.UnityEvent DeferredGameUIReadyEvent;
    private static bool deferredEventHasFired;
    public const string CACHED_LEVEL_GEN_VERSION_KEY = "c_lgv";
    public const string LEVEL_GEN_VERSION_KEY = "lgv";
    public const int MIN_LEVEL_GEN_VERSION = 1;
    public const int MAX_LEVEL_GEN_VERSION = 2;
    public const int DEFAULT_LEVEL_GEN_VERSION = 2;
    public static int CurrentlyLoadedLevelGenVersion;
    
    // Properties
    public static bool DeferredEventHasFired { get; }
    public static string GamePathName { get; }
    public override System.Collections.Generic.List<System.Type> GameComponents { get; }
    public override object[] GameComponentArguments { get; }
    public static int LevelGenVersionToUse { get; }
    
    // Methods
    public static bool get_DeferredEventHasFired()
    {
        null = null;
        return (bool)WordApp.deferredEventHasFired;
    }
    public static string get_GamePathName()
    {
        return WordApp.GetGamePathName();
    }
    public static AppConfigs getConfig()
    {
        return App.Configuration;
    }
    public override System.Collections.Generic.List<System.Type> get_GameComponents()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(286101504)});
        Add(item:  286101504);
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(285143040)});
        Add(item:  285143040);
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(371245056)});
        Add(item:  371245056);
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(285622272)});
        Add(item:  285622272);
        System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(285888512)});
        Add(item:  285888512);
        System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(286314496)});
        Add(item:  286314496);
        System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(285782016)});
        Add(item:  285782016);
        System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(286367744)});
        Add(item:  286367744);
        System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(383066112)});
        Add(item:  383066112);
    }
    public override object[] get_GameComponentArguments()
    {
        AppConfigs val_1 = App.Configuration;
        typeof(System.Object[]).__il2cppRuntimeField_10 = 0;
        typeof(System.Object[]).__il2cppRuntimeField_14 = "NativeCallbacks";
    }
    public override void OnServerUpdatedData()
    {
        var val_3;
        var val_4;
        this.UpdateData();
        val_3 = 0;
        val_4 = null;
        val_3 = (App.__il2cppRuntimeField_BA & 512);
        if(App.USERS != null)
        {
                App.UpdateComponents();
            return;
        }
        
        App.USERS = 1;
        App.InitialUpdateComponents();
    }
    private void UpdateData()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -1898880160);
        GameEcon val_2 = App.getGameEcon;
        WordApp.CheckLevelGenMode();
        System.Collections.IEnumerator val_3 = SendDeferredServerDataReadyCallback();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  370978816);
    }
    private System.Collections.IEnumerator SendDeferredServerDataReadyCallback()
    {
        object val_1 = new System.Object();
        typeof(WordApp.<SendDeferredServerDataReadyCallback>d__17).__il2cppRuntimeField_8 = 0;
    }
    public override void startApp()
    {
        var val_8;
        var val_9;
        var val_7 = 25224643;
        val_7 = 10401144 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        WordGames.currentGame = App.game;
        AppConfigs val_1 = App.Configuration;
        Localization.SetGameName(gameName:  null);
        if(App.appStarted == true)
        {
                return;
        }
        
        val_9 = (R6 + 92) + 1;
        mem2[0] = 1;
        GameEcon val_2 = App.getGameEcon;
        System.Collections.IEnumerator val_3 = this.SendDeferredAppStartNotification();
        UnityEngine.Coroutine val_4 = R4.StartCoroutine(routine:  0);
        System.Collections.IEnumerator val_5 = R4.PingForDeeplink();
        UnityEngine.Coroutine val_6 = R4.StartCoroutine(routine:  R4);
        Logger.Init();
        UnityEngine.Screen.sleepTimeout = 0;
    }
    private System.Collections.IEnumerator PingForDeeplink()
    {
        object val_1 = new System.Object();
        typeof(WordApp.<PingForDeeplink>d__19).__il2cppRuntimeField_8 = 0;
    }
    private System.Collections.IEnumerator SendDeferredAppStartNotification()
    {
        object val_1 = new System.Object();
        typeof(WordApp.<SendDeferredAppStartNotification>d__20).__il2cppRuntimeField_8 = 0;
    }
    public override void initCustomBackend()
    {
        this.initCustomBackend();
    }
    private static string GetGamePathName()
    {
        AppConfigs val_1 = App.Configuration;
        if(0 != 0)
        {
                return;
        }
    
    }
    public static WordGames.GameNames GetGameEnum(string game)
    {
        var val_8;
        var val_9;
        var val_10;
        WordGames.GameNames val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(295313408)});
        System.Array val_2 = System.Enum.GetValues(enumType:  295313408);
        System.Collections.IEnumerator val_3 = GetEnumerator();
        label_21:
        WordGames.GameNames val_9 = ;
        if(( + 178) == 0)
        {
            goto label_7;
        }
        
        var val_8 = 0;
        label_9:
        val_8 = 0;
        if(( + 88 + 0) == null)
        {
            goto label_8;
        }
        
        val_8 = val_8 + 1;
        val_8 = (uint)val_8 & 65535;
        if(val_8 < ( + 178))
        {
            goto label_9;
        }
        
        label_7:
        val_9 = null;
        goto label_10;
        label_8:
        var val_4 = ( + 88) + 0;
        val_9 = val_9 + ((( + 88 + 0) + 4) << 3);
        label_10:
        if(null == 0)
        {
            goto label_11;
        }
        
        WordGames.GameNames val_11 = ;
        if(( + 178) == 0)
        {
            goto label_13;
        }
        
        var val_10 = 0;
        label_15:
        if(( + 88 + 0) == null)
        {
            goto label_14;
        }
        
        val_10 = val_10 + 1;
        if(((uint)val_10 & 65535) < ( + 178))
        {
            goto label_15;
        }
        
        label_13:
        val_10 = null;
        goto label_16;
        label_14:
        var val_5 = ( + 88) + 0;
        val_11 = val_11 + ((( + 88 + 0) + 4) << 3);
        label_16:
        val_11 = 0;
        val_8 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if((System.String.op_Equality(a:  295313408, b:  game)) == false)
        {
            goto label_21;
        }
        
        val_12 = -336844520;
        val_13 = 89;
        val_14 = 0;
        val_15 = 0;
        goto label_22;
        label_11:
        val_12 = -336844520;
        val_13 = 87;
        val_14 = 0;
        val_15 = 0;
        label_22:
        val_16 = 1152921504619679744;
        if(null == 0)
        {
            goto label_23;
        }
        
        WordGames.GameNames val_12 = ;
        if(( + 178) == 0)
        {
            goto label_24;
        }
        
        val_16 = 0;
        label_26:
        val_8 = 0;
        if(( + 88 + 0) == null)
        {
            goto label_25;
        }
        
        val_16 = val_16 + 1;
        val_8 = (uint)val_16 & 65535;
        if(val_8 < ( + 178))
        {
            goto label_26;
        }
        
        label_24:
        val_17 = null;
        goto label_27;
        label_25:
        var val_7 = ( + 88) + 0;
        val_12 = val_12 + ((( + 88 + 0) + 4) << 3);
        label_27:
        label_23:
        if(val_14 != 1)
        {
                if(val_13 != 89)
        {
                val_18 = 1;
        }
        
            return;
        }
        
        val_18 = 1;
    }
    public static int get_LevelGenVersionToUse()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        val_6 = 1;
        if((System.String.op_Inequality(a:  null, b:  1800251696)) == true)
        {
                return (int)val_6;
        }
        
        val_6 = 2;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -336740368)) == false)
        {
                return (int)val_6;
        }
        
        int val_5 = UnityEngine.PlayerPrefs.GetInt(key:  -336740368);
        if(val_5 > 2)
        {
                return (int)val_6;
        }
        
        if(val_5 < 1)
        {
                val_5 = 2;
        }
        
        val_6 = 2;
        return (int)val_6;
    }
    private static void CheckLevelGenMode()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_13;
        var val_14;
        var val_15;
        var val_16;
        int val_17;
        var val_18;
        int val_20;
        var val_21;
        val_13 = null;
        val_13 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        var val_14 = 25227691;
        val_14 = 10399724 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = 0;
        twelvegigs.storage.JsonDictionary val_2 = getWordGameplayKnobs();
        if(App.storageManager.knobsModel == 0)
        {
            goto label_8;
        }
        
        if(null == null)
        {
            goto label_49;
        }
        
        goto label_12;
        label_8:
        if(val_13 != 0)
        {
            goto label_49;
        }
        
        label_12:
        val_13 = 0;
        val_15 = 1;
        label_49:
        if((val_13.ContainsKey(key:  -336628288)) != false)
        {
                string val_4 = val_13.Item[-336628288];
            bool val_6 = System.Int32.TryParse(s:  null, result: out  int val_5 = -336616244);
        }
        
        GameBehavior val_7 = App.getBehavior;
        string val_8 = 0.GetCurrentLanguage();
        bool val_9 = System.String.op_Inequality(a:  null, b:  1800251696);
        if(val_9 == true)
        {
                val_9 = 1;
        }
        
        GameBehavior val_10 = App.getBehavior;
        if(0 == 0)
        {
                mem[1179404111] = 1;
        }
        
        if(0 != 0)
        {
                mem[1179404111] = mem[1179404111];
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  -336740368, value:  1);
        val_16 = null;
        val_16 = null;
        val_17 = WordApp.CurrentlyLoadedLevelGenVersion;
        if(val_17 == 1)
        {
                return;
        }
        
        val_16 = null;
        val_17 = WordApp.CurrentlyLoadedLevelGenVersion;
        if(mem[1179404111] < 1)
        {
                mem[1179404111] = 2;
        }
        
        if(val_17 == 2)
        {
                return;
        }
        
        if(mem[1179404111] == 1)
        {
                WordPets.WPTDataParser val_11 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            CallEmptyMethod();
            val_18 = null;
            val_18 = null;
            val_20 = 1;
        }
        else
        {
                if(mem[1179404111] != 2)
        {
                if((mem[1179404111] - 1) < 2)
        {
                return;
        }
        
        }
        
            WordPets.WPTDataParser val_13 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            CallEmptyMethod();
            val_21 = null;
            val_21 = null;
            val_20 = 2;
        }
        
        WordApp.CurrentlyLoadedLevelGenVersion = val_20;
    }
    public static int SanitizeLevelGenVersion(int input)
    {
        if(input > 2)
        {
                input = 2;
            return (int)input;
        }
        
        if(input < 1)
        {
                input = 2;
        }
        
        return 2;
    }
    public static void LanguageChanged()
    {
        WordApp.CheckLevelGenMode();
    }
    public WordApp()
    {
    
    }
    private static WordApp()
    {
        WordApp.DEFAULT_LEVEL_GEN_VERSION = 0;
        WordApp.DeferredGameUIReadyEvent = new UnityEngine.Events.UnityEvent();
        WordApp.deferredEventHasFired = 0;
        WordApp.CurrentlyLoadedLevelGenVersion = 0;
    }

}
