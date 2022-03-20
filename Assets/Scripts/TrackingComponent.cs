using UnityEngine;
public class TrackingComponent : AppComponent
{
    // Fields
    private static bool hasFinishedInitializing;
    public static System.Action finishedInitializingCallback;
    private string _gameObjectName;
    protected AmplitudePlugin amplitude;
    protected AdjustTracking adjustTracking;
    protected FacebookTracker facebookTracker;
    protected FirebasePlugin firebase;
    private static System.DateTime started;
    private static TrackingComponent.AppPauseIntent currentIntent;
    private static TrackingComponent.AppPauseIntent lastIntent;
    
    // Properties
    public static bool wasInit { get; }
    public override bool RunInMainThread { get; }
    protected virtual string EconomyVersion { get; }
    protected virtual int GamesToShowAds { get; }
    public AdjustTracking Adjust { get; }
    public AmplitudePlugin Amplitude { get; }
    public static TrackingComponent.AppPauseIntent CurrentIntent { get; set; }
    public static TrackingComponent.AppPauseIntent LastIntent { get; }
    
    // Methods
    public static bool get_wasInit()
    {
        null = null;
        return (bool)TrackingComponent.hasFinishedInitializing;
    }
    public override bool get_RunInMainThread()
    {
        return true;
    }
    public TrackingComponent(string gameName, string gameObjectName)
    {
        mem[1152921511248351888] = "TrackingComponent";
        this._gameObjectName = gameObjectName;
    }
    protected virtual string get_EconomyVersion()
    {
        return DeviceIdPlugin.GetClientVersion();
    }
    protected virtual void postTrackerLogic()
    {
    
    }
    protected virtual int get_GamesToShowAds()
    {
        return 10;
    }
    protected virtual bool GameSpecificAdLogic()
    {
        return true;
    }
    public AdjustTracking get_Adjust()
    {
    
    }
    public AmplitudePlugin get_Amplitude()
    {
    
    }
    public override void initializeOnMainThread()
    {
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 == 11)
        {
                int val_2 = UnityEngine.AndroidJNI.AttachCurrentThread();
        }
        
        this.initializeTrackers();
        this.initializeGeneralEvents();
        this.addTrackers();
        var val_33 = 28294874;
        val_33 = 7330664 + val_33;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_33 = null;
        val_33 = null;
        string val_3 = DeviceIdPlugin.GetDeviceId();
        App.trackerManager.identify(id:  null);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1947645120, value:  1633189168);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_34 = null;
        val_34 = null;
        val_35 = null;
        val_35 = null;
        App.trackerManager.track(eventName:  Events.APP_LAUNCHED, data:  78753792);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_36 = null;
        val_36 = null;
        Player val_5 = App.Player;
        App.trackerManager.superProperty(propertyName:  Events.BUCKET, propertyValue:  33449456);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_37 = null;
        val_37 = null;
        Player val_6 = App.Player;
        App.trackerManager.peopleProperty(propertyName:  Events.BUCKET, propertyValue:  33449456);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_38 = null;
        val_38 = null;
        string val_7 = UnityEngine.SystemInfo.processorType;
        App.trackerManager.superProperty(propertyName:  Events.PROCESSOR_TYPE, propertyValue:  null);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_39 = null;
        val_39 = null;
        string val_8 = UnityEngine.SystemInfo.processorType;
        App.trackerManager.peopleProperty(propertyName:  Events.PROCESSOR_TYPE, propertyValue:  null);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_40 = null;
        val_40 = null;
        string val_10 = UnityEngine.SystemInfo.processorCount.ToString();
        App.trackerManager.superProperty(propertyName:  Events.PROCESSOR_COUNT, propertyValue:  -1947632760);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_41 = null;
        val_41 = null;
        string val_12 = UnityEngine.SystemInfo.processorCount.ToString();
        App.trackerManager.peopleProperty(propertyName:  Events.PROCESSOR_COUNT, propertyValue:  -1947632760);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_42 = null;
        val_42 = null;
        string val_14 = UnityEngine.SystemInfo.systemMemorySize.ToString();
        App.trackerManager.superProperty(propertyName:  Events.SYSTEM_MEMORY_SIZE, propertyValue:  -1947632760);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_43 = null;
        val_43 = null;
        string val_16 = UnityEngine.SystemInfo.systemMemorySize.ToString();
        App.trackerManager.peopleProperty(propertyName:  Events.SYSTEM_MEMORY_SIZE, propertyValue:  -1947632760);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_44 = null;
        val_44 = null;
        string val_18 = UnityEngine.SystemInfo.graphicsMemorySize.ToString();
        App.trackerManager.superProperty(propertyName:  Events.GRAPHICS_MEMORY_SIZE, propertyValue:  -1947632760);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_45 = null;
        val_45 = null;
        string val_20 = UnityEngine.SystemInfo.graphicsMemorySize.ToString();
        App.trackerManager.peopleProperty(propertyName:  Events.GRAPHICS_MEMORY_SIZE, propertyValue:  -1947632760);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_46 = null;
        val_46 = null;
        string val_21 = UnityEngine.SystemInfo.graphicsDeviceName;
        App.trackerManager.superProperty(propertyName:  Events.GRAPHICS_DEVICE_NAME, propertyValue:  null);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_47 = null;
        val_47 = null;
        string val_22 = UnityEngine.SystemInfo.graphicsDeviceName;
        App.trackerManager.peopleProperty(propertyName:  Events.GRAPHICS_DEVICE_NAME, propertyValue:  null);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_48 = null;
        val_48 = null;
        string val_23 = UnityEngine.SystemInfo.graphicsDeviceVendor;
        App.trackerManager.superProperty(propertyName:  Events.GRAPHICS_DEVICE_VENDOR, propertyValue:  null);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_49 = null;
        val_49 = null;
        string val_24 = UnityEngine.SystemInfo.graphicsDeviceVendor;
        App.trackerManager.peopleProperty(propertyName:  Events.GRAPHICS_DEVICE_VENDOR, propertyValue:  null);
        WordPets.WPTDataParser val_25 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        AppConfigs val_26 = App.Configuration;
        string val_27 = 0.Key(key:  -1947645040);
        AppConfigs val_28 = App.Configuration;
        string val_29 = 0.Key(key:  -1947644928);
        AppConfigs val_30 = App.Configuration;
        string val_31 = 0.Key(key:  -1947644816);
        HelpshiftPlugin.CurrencyDelegate val_32 = new HelpshiftPlugin.CurrencyDelegate(object:  -1947620720, method:  typeof(TrackingComponent).__il2cppRuntimeField_138);
        Init(gameObject:  -1992759600, apiKey:  null, domain:  null, appId:  0, currencies:  null);
        val_50 = null;
        val_50 = null;
        TrackingComponent.hasFinishedInitializing = true;
        if(TrackingComponent.finishedInitializingCallback == 0)
        {
                return;
        }
        
        0.Invoke();
        TrackingComponent.finishedInitializingCallback = 0;
    }
    public virtual string getPlayerVirtualCurrencies()
    {
    
    }
    private void initializeTrackers()
    {
        AppConfigs val_1 = App.Configuration;
        string val_2 = DeviceIdPlugin.GetDeviceId();
        this.amplitude = new AmplitudePlugin(apiKey:  2621448, deviceId:  null);
        AppConfigs val_4 = App.Configuration;
        string val_5 = 0.Key(key:  -1947420720);
        this.adjustTracking = new AdjustTracking(appToken:  null);
        this.firebase = new FirebasePlugin();
    }
    private void addTrackers()
    {
        var val_1;
        var val_2;
        var val_3;
        var val_1 = 28281770;
        val_1 = 7343768 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        App.trackerManager.addTracker(t:  this.amplitude);
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        App.trackerManager.addTracker(t:  this.adjustTracking);
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        App.trackerManager.addTracker(t:  this.firebase);
    }
    private void initializeGeneralEvents()
    {
        if(mem[35628213] != true)
        {
            
        }
    
    }
    protected virtual void initializeSpecificEvents()
    {
    
    }
    public override void onInitialServerUpdate()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        Player val_1 = App.Player;
        if(0 != 0)
        {
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1946947968, value:  -1946948048);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1947645120, value:  1633189168);
            var val_8 = 28280990;
            val_8 = 7344548 + val_8;
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_9 = null;
            GameBehavior val_4 = App.getBehavior;
            string val_5 = 0.ToString();
            App.trackerManager.superProperty(propertyName:  Events.CURRENT_LEVEL, propertyValue:  -1946935908);
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_10 = null;
            val_10 = null;
            GameBehavior val_6 = App.getBehavior;
            string val_7 = 0.ToString();
            App.trackerManager.peopleProperty(propertyName:  Events.CURRENT_LEVEL, propertyValue:  -1946935908);
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_11 = null;
            val_11 = null;
            App.trackerManager.flush();
            return;
        }
        
        var val_9 = 28280402;
        val_9 = 7345136 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        App.trackerManager.clearCache();
    }
    public override void onServerUpdate()
    {
        var val_1;
        var val_1 = 28280126;
        val_1 = 7345412 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        App.trackerManager.flush();
    }
    public override void onApplicationPause(bool pauseStatus)
    {
        this.onApplicationPause(pauseStatus:  pauseStatus);
        if(pauseStatus == false)
        {
                return;
        }
        
        TrackingComponent.TrackSession(sessionEnded:  true, quitButton:  false);
    }
    public static void TrackSession(bool sessionEnded, bool quitButton = False)
    {
        var val_7;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_21;
        var val_22;
        var val_23;
        val_12 = 7345828 + 28281065;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        if(App.isQuitting == true)
        {
                return;
        }
        
        val_14 = "End Session";
        if(sessionEnded == true)
        {
                "Start Session" = val_14;
        }
        
        val_12 = null;
        val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if((System.String.op_Equality(a:  -1946611872, b:  -1946611872)) == false)
        {
            goto label_7;
        }
        
        if(quitButton == false)
        {
            goto label_8;
        }
        
        val_15 = null;
        val_16 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
        val_17 = "Quit Button";
        goto label_10;
        label_7:
        System.DateTime val_3 = System.DateTime.UtcNow;
        val_18 = null;
        val_18 = null;
        TrackingComponent.started = 1;
        return;
        label_8:
        val_15 = null;
        val_16 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
        val_17 = "Minimize App";
        label_10:
        Add(key:  -1946611584, value:  8945664);
        System.DateTime val_5 = System.DateTime.UtcNow;
        val_19 = null;
        val_19 = null;
        System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511250182280}, d2:  new System.DateTime() {dateData = 1});
        double val_9 = val_7.TotalSeconds;
        string val_10 = val_7.ToString(format:  -1946611488);
        Add(key:  -1946611408, value:  -1946599272);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        TrackingComponent.currentIntent = ;
        Add(key:  -1946611296, value:  286261248);
        GameBehavior val_11 = App.getBehavior;
        val_21 = null;
        val_21 = null;
        App.trackerManager.track(eventName:  -1946611872, data:  78753792);
        TrackingComponent.lastIntent = TrackingComponent.currentIntent;
        TrackingComponent.currentIntent = 0;
        val_12 = 7346964 + 28281511;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        val_14 = 1;
        DeeplinkComponent.OnDeeplinkShowScene.Consumed = true;
        if(val_12 == 0)
        {
                mem2[0] = val_14;
        }
        
        val_23 = null;
        val_23 = null;
        DeeplinkComponent.OnDeeplinkShowScene.Flush();
    }
    public static void TrackLogin(string fromDeeplink = "", string notificationType = "")
    {
        WordPets.WPTPetTile val_23;
        var val_24;
        var val_25;
        float val_26;
        var val_27;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        val_23 = "";
        if((System.String.IsNullOrEmpty(value:  notificationType)) == false)
        {
            goto label_1;
        }
        
        if((System.String.IsNullOrEmpty(value:  fromDeeplink)) == false)
        {
            goto label_2;
        }
        
        string val_3 = DeeplinkPlugin.GetMoreGamesReferal();
        if((System.String.IsNullOrEmpty(value:  null)) == true)
        {
            goto label_45;
        }
        
        string val_5 = DeeplinkPlugin.GetMoreGamesReferal();
        if((0.Contains(value:  -1946491024)) == false)
        {
            goto label_5;
        }
        
        if(0 == 0)
        {
            goto label_6;
        }
        
        val_24 = 0.IndexOf(value:  -1946491024);
        goto label_7;
        label_1:
        val_25 = 2;
        val_23 = notificationType;
        goto label_48;
        label_2:
        val_25 = 3;
        val_23 = fromDeeplink;
        label_48:
        label_45:
        val_26 = 1152921504892043264;
        var val_23 = 28277918;
        val_23 = 7347620 + val_23;
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        val_27 = null;
        val_27 = null;
        val_28 = null;
        val_28 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.DateTime val_9 = System.DateTime.Now;
        string val_10 = ???.ToString();
        Add(key:  -1946490928, value:  -1946478368);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(val_28 != 0)
        {
                Add(key:  -1946490832, value:  286208000);
        }
        else
        {
                Add(key:  -1946490832, value:  286208000);
        }
        
        Add(key:  -1946490736, value:  val_23);
        val_29 = 1152921504893001728;
        val_30 = null;
        val_30 = null;
        string val_11 = ToString();
        Add(key:  -1946490624, value:  286158856);
        App.trackerManager.track(eventName:  -1946611776, data:  78753792);
        if( == 2)
        {
                var val_24 = 28277286;
            val_24 = 7348252 + val_24;
            if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
            val_26 = val_29;
            string val_12 = -1946490528(-1946490528) + val_23;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_13 = null;
            val_28 = val_13;
            val_13 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1947645120, value:  13152256);
            App.trackerManager.track(eventName:  -1946490528, data:  78753792);
            val_29 = val_26;
        }
        
        var val_25 = 28279931;
        val_25 = 7348544 + val_25;
        if(val_25 == 0)
        {
                mem2[0] = 1;
        }
        
        val_31 = null;
        val_31 = null;
        DeeplinkComponent.OnDeeplinkShowScene.Flush();
        System.DateTime val_14 = System.DateTime.UtcNow;
        val_32 = null;
        TrackingComponent.started = 1;
        return;
        label_6:
        val_24 = 0.IndexOf(value:  -1946491024);
        label_7:
        string val_17 = 0.Substring(startIndex:  val_24 + 12);
        label_5:
        if((0.Contains(value:  -1946490416)) == false)
        {
            goto label_45;
        }
        
        if(0 != 0)
        {
                val_33 = 0.LastIndexOf(value:  -1946490416);
        }
        else
        {
                val_33 = 0.LastIndexOf(value:  -1946490416);
        }
        
        string val_22 = 0.Substring(startIndex:  val_33 + 13);
        goto label_48;
    }
    public static TrackingComponent.AppPauseIntent get_CurrentIntent()
    {
        null = null;
    }
    public static void set_CurrentIntent(TrackingComponent.AppPauseIntent value)
    {
        null = null;
        TrackingComponent.lastIntent = value;
        TrackingComponent.currentIntent = value;
    }
    public static TrackingComponent.AppPauseIntent get_LastIntent()
    {
        null = null;
    }
    private static TrackingComponent()
    {
        TrackingComponent.hasFinishedInitializing = false;
        TrackingComponent.finishedInitializingCallback = false;
        System.DateTime val_1 = System.DateTime.UtcNow;
        TrackingComponent.started = new System.DateTime();
        TrackingComponent.currentIntent = false;
        TrackingComponent.lastIntent = false;
    }

}
