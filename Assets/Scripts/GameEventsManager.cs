using UnityEngine;
public class GameEventsManager : MonoSingleton<GameEventsManager>
{
    // Fields
    private bool initialized;
    private string prefkey;
    private string timeCheatStampKey;
    private const string ApiUrl = "/api/game_events";
    public const string Notification_OnGameEventDataReceived = "OnGameEventDataReceived";
    public const string Notification_OnGameEventPutResponse = "OnGameEventDataPutResponse";
    public const string Notification_OnGameEventDownloaded = "OnGameEventDataDownloaded";
    public const string Notificaiton_OnResetHack = "OnResetHack";
    public const string Notification_OnAlmostCompleteHack = "OnAlmostCompleteHack";
    public const string Notification_OnAddEventCurrency = "OnAddEventCurrency";
    private bool <cheating>k__BackingField;
    private System.TimeSpan _serverOffsetTime;
    private float timeToUpdate;
    private static string lastEventsResponse;
    private System.Collections.Generic.List<GameEventV2> eventList;
    private bool isAsynching;
    private static System.DateTime lastServerUpdate;
    private static int secondsToLastUpdate;
    private bool synching;
    
    // Properties
    private string VersionString { get; }
    public bool cheating { get; set; }
    public bool isAvailable { get; }
    public System.DateTime ServerTime { get; }
    public System.Collections.Generic.List<GameEventV2> getGameEvents { get; }
    
    // Methods
    private string get_VersionString()
    {
        var val_1 = 22495935;
        val_1 = 13129852 + val_1;
        if(val_1 != 0)
        {
                return;
        }
        
        mem2[0] = 1;
    }
    public bool get_cheating()
    {
        return (bool)this.<cheating>k__BackingField;
    }
    protected void set_cheating(bool value)
    {
        this.<cheating>k__BackingField = value;
    }
    public bool get_isAvailable()
    {
        if(this.initialized == false)
        {
                this = 0;
        }
        
        if(this.initialized == true)
        {
                this = 0;
        }
        
        if(this.initialized == true)
        {
                this = 0;
        }
        
        return (bool)this;
    }
    public System.DateTime get_ServerTime()
    {
        long val_2;
        System.DateTime val_1 = System.DateTime.UtcNow;
        System.DateTime val_4 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921511811951856}, t:  new System.TimeSpan() {_ticks = val_2});
        return new System.DateTime() {dateData = val_4.dateData};
    }
    public static string GetLastEventsResponseDebug()
    {
        null = null;
    }
    public System.Collections.Generic.List<GameEventV2> get_getGameEvents()
    {
    
    }
    public override void InitMonoSingleton()
    {
        var val_5;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1384484496, method:  new IntPtr(2910457776));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_5 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_6;
        }
        
        }
        
        val_5 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_5;
        this.<cheating>k__BackingField = false;
        this.DoAsync();
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1384484496, name:  1799422256);
    }
    private void OnDestroy()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1384372496, method:  new IntPtr(2910457776));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
    }
    private void OnApplicationPaused(bool paused)
    {
        if(paused == true)
        {
                return;
        }
        
        this.storeData();
    }
    private void DoAsync()
    {
        if(this.isAsynching == true)
        {
                return;
        }
        
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action val_2 = new System.Action(object:  R4, method:  new IntPtr(2910794800));
        Async(callback:  7454720, when:  null);
        mem2[0] = 1;
    }
    private void OnSceneLoaded(SceneType sceneType)
    {
        sceneType = sceneType - 1;
        if(sceneType > 1)
        {
                return;
        }
        
        if(this.synching == true)
        {
                return;
        }
        
        if(this.initialized == false)
        {
                return;
        }
        
        if((this.<cheating>k__BackingField) != false)
        {
                return;
        }
        
        this.RequestServerEvents();
    }
    private void OnLocalize()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        val_3 = null;
        val_3 = null;
        GameEventsManager.lastServerUpdate = System.DateTime.MinValue;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.eventList = null;
        if(this.initialized == false)
        {
                return;
        }
        
        if((this.<cheating>k__BackingField) == true)
        {
                return;
        }
        
        R4.RequestServerEvents();
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        uint val_3 = 0;
        val_3 = this.timeToUpdate - val_3;
        this.timeToUpdate = val_3;
        if()
        {
                return;
        }
        
        System.Collections.Generic.List<GameEventV2> val_2 = this.PurgeExpiredList(_eventList:  this.eventList);
        this.timeToUpdate = 1f;
    }
    private System.Collections.Generic.List<GameEventV2> PurgeExpiredList(System.Collections.Generic.List<GameEventV2> _eventList)
    {
        twelvegigs.sweepstakes.Distribution val_4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_8:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        System.DateTime val_5 = DateTimeCheat.UtcNow;
        if((val_4 + 40.CompareTo(value:  new System.DateTime())) < 0)
        {
            goto label_8;
        }
        
        Add(item:  val_4);
        goto label_8;
        label_2:
        Dispose();
    }
    private void init()
    {
        var val_6;
        var val_9;
        var val_10;
        System.Collections.Generic.List<GameEventV2> val_11;
        var val_12;
        if(this.initialized == true)
        {
                return;
        }
        
        this.<cheating>k__BackingField = false;
        if((UnityEngine.PlayerPrefs.HasKey(key:  this.prefkey)) == false)
        {
            goto label_36;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  this.prefkey);
        object val_3 = MiniJSON.Json.Deserialize(json:  this.prefkey);
        if(this.prefkey != null)
        {
                val_9 = 0;
        }
        else
        {
                val_9 = 0;
        }
        
        List.Enumerator<T> val_4 = GetEnumerator();
        label_16:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        val_10 = 0;
        if(val_6 != 0)
        {
                val_10 = val_6;
            if(val_6 == 0)
        {
                val_10 = 0;
        }
        
        }
        
        GameEventV2 val_7 = new GameEventV2();
        Deserialize(data:  0);
        this.eventList.Add(item:  317624320);
        goto label_16;
        label_11:
        Dispose();
        if(0 != 0)
        {
                val_11 = 0;
        }
        
        System.Collections.Generic.List<GameEventV2> val_8 = this.PurgeExpiredList(_eventList:  this.eventList);
        this.eventList = val_11;
        label_36:
        this.initialized = true;
        this.synching = true;
        this.RequestServerEvents();
        this.isAsynching = false;
        return;
        label_37:
        val_12 = (System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4;
        if(null != 1)
        {
            goto label_32;
        }
        
        if(null == 0)
        {
            goto label_33;
        }
        
        UnityEngine.Debug.LogWarning(message:  -1383565392);
        goto label_36;
        label_33:
        mem[4] = val_12;
        goto label_37;
        label_32:
    }
    public void CheckAndRequestServerEvents()
    {
        if(this.synching == true)
        {
                return;
        }
        
        if(this.initialized == false)
        {
                return;
        }
        
        if((this.<cheating>k__BackingField) != false)
        {
                return;
        }
        
        this.RequestServerEvents();
    }
    private void RequestServerEvents()
    {
        ulong val_2;
        var val_5;
        System.Action<System.Threading.Tasks.Task, System.Object> val_15;
        var val_16;
        var val_17;
        var val_19;
        var val_20;
        val_15 = 1152921504616751104;
        System.DateTime val_1 = System.DateTime.UtcNow;
        val_16 = 1152921504924577792;
        val_17 = null;
        val_17 = null;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511813469912}, d2:  new System.DateTime() {dateData = val_2});
        double val_7 = val_5.TotalSeconds;
        System.DateTime val_8 = System.DateTime.UtcNow;
        val_19 = null;
        val_19 = null;
        GameEventsManager.lastServerUpdate = val_2;
        var val_15 = 22493938;
        val_15 = 13132120 + val_15;
        if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        val_20 = null;
        val_20 = null;
        val_15 = null;
        val_15 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1383299600, method:  new IntPtr(2911642480));
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_16 = 1152921510535002416;
        Add(key:  -1383323792, value:  -1953384624);
        string val_11 = VersionString;
        Add(key:  -1953212128, value:  78753792);
        string val_12 = DeviceIdPlugin.GetClientVersion();
        Add(key:  -1931031472, value:  0);
        Player val_13 = App.Player;
        Add(key:  -1824276800, value:  33449456);
        Player val_14 = App.Player;
        Add(key:  1618311216, value:  1835037);
        App.networkManager.DoGet(path:  -1383323712, onCompleteFunction:  7507968, destroy:  false, immediate:  false, getParams:  null, timeout:  20);
    }
    private void requestResponse(string method, System.Collections.Generic.Dictionary<string, object> data)
    {
        ulong val_12;
        var val_13;
        System.TimeSpan val_19;
        var val_22;
        var val_23;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_22 = 1152921504891777024;
        val_23 = null;
        val_23 = null;
        if(Logger.GameEvents != false)
        {
                UnityEngine.Debug.Log(message:  -1383203408);
        }
        
        string val_1 = PrettyPrint.printJSON(obj:  data, types:  false, singleLineOutput:  false);
        val_24 = data;
        val_25 = null;
        val_25 = null;
        GameEventsManager.lastEventsResponse = val_24;
        val_26 = null;
        val_26 = null;
        if(Logger.GameEvents != false)
        {
                val_27 = null;
            val_27 = null;
            string val_2 = -1383203248(-1383203248) + GameEventsManager.lastEventsResponse;
            val_24 = "LATEST EVENTS RESPONSE : ";
            UnityEngine.Debug.LogWarning(message:  -1383203248);
        }
        
        this.synching = false;
        if(data == 0)
        {
                return;
        }
        
        val_24 = "success";
        if((data.ContainsKey(key:  1616271776)) == false)
        {
                return;
        }
        
        object val_4 = data.Item[1616271776];
        val_24 = data;
        val_22 = null;
        val_24.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(null == 0)
        {
                return;
        }
        
        if((data.ContainsKey(key:  -1383203120)) == false)
        {
                return;
        }
        
        if((data.ContainsKey(key:  -1823911136)) != false)
        {
                object val_7 = data.Item[-1823911136];
            string val_8 = data.ToString();
            decimal val_9 = System.Decimal.Parse(s:  -1383190948);
            System.DateTime val_11 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1383190960});
            val_24 = val_12;
            val_22 = val_13;
            System.DateTime val_14 = System.DateTime.UtcNow;
            System.TimeSpan val_17 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511813590592}, d2:  new System.DateTime() {dateData = val_24});
            this._serverOffsetTime = val_19;
        }
        
        object val_20 = data.Item[-1383203120];
        val_28 = 0;
        if(data != 0)
        {
                val_24 = null;
            val_28 = data;
            if(data == 0)
        {
                val_28 = 0;
        }
        
        }
        
        this.loadDescs(descs:  0);
        NotificationCenter val_21 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1383178896, aName:  -1383203024);
    }
    public void GetCustomData(int eventId, string urlSubPath, System.Collections.Generic.Dictionary<string, object> data, System.Action<System.Collections.Generic.Dictionary<string, object>> onResponse)
    {
        var val_6;
        var val_7;
        object val_1 = new System.Object();
        typeof(GameEventsManager.<>c__DisplayClass43_0).__il2cppRuntimeField_8 = onResponse;
        if((System.String.IsNullOrEmpty(value:  urlSubPath)) != false)
        {
                val_6 = "{0}/{1}";
            string val_3 = System.String.Format(format:  1629069648, arg0:  -1383323712, arg1:  13152256);
        }
        else
        {
                val_6 = "{0}/{1}/{2}";
            string val_4 = System.String.Format(format:  -1383070416, arg0:  -1383323712, arg1:  13152256, arg2:  urlSubPath);
        }
        
        var val_6 = 22489170;
        val_6 = 13136888 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  317784064, method:  new IntPtr(2911896976));
        App.networkManager.DoGet(path:  -1383070416, onCompleteFunction:  7507968, destroy:  false, immediate:  false, getParams:  data, timeout:  20);
    }
    public void PostCustomData(int eventId, string urlSubPath, System.Collections.Generic.Dictionary<string, object> data, System.Action<System.Collections.Generic.Dictionary<string, object>> onResponse)
    {
        var val_6;
        var val_7;
        object val_1 = new System.Object();
        typeof(GameEventsManager.<>c__DisplayClass44_0).__il2cppRuntimeField_8 = onResponse;
        if((System.String.IsNullOrEmpty(value:  urlSubPath)) != false)
        {
                val_6 = "{0}/{1}";
            string val_3 = System.String.Format(format:  1629069648, arg0:  -1383323712, arg1:  13152256);
        }
        else
        {
                val_6 = "{0}/{1}/{2}";
            string val_4 = System.String.Format(format:  -1383070416, arg0:  -1383323712, arg1:  13152256, arg2:  urlSubPath);
        }
        
        var val_6 = 22488586;
        val_6 = 13137472 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  317837312, method:  new IntPtr(2912034576));
        App.networkManager.DoPost(path:  -1383070416, postBody:  data, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    public void PutUpdate(int eventID, System.Collections.Generic.Dictionary<string, object> data)
    {
        this.syncEvent(eventId:  eventID, data:  data, POST:  false);
    }
    private void syncEvent(int eventId, System.Collections.Generic.Dictionary<string, object> data, bool POST = False)
    {
        var val_8;
        var val_9;
        data.Add(key:  -1383323792, value:  -1953384624);
        string val_1 = data.VersionString;
        data.Add(key:  -1953212128, value:  data);
        string val_2 = DeviceIdPlugin.GetClientVersion();
        data.Add(key:  -1931031472, value:  0);
        Player val_3 = App.Player;
        data.Add(key:  1618311216, value:  1835037);
        if(POST != false)
        {
                var val_8 = 22487854;
            val_8 = 13138204 + val_8;
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_8 = null;
            val_8 = null;
            System.Action<System.Threading.Tasks.Task, System.Object> val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1382658096, method:  new IntPtr(2912284176));
            App.networkManager.DoPost(path:  -1383323712, postBody:  data, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
            return;
        }
        
        var val_9 = 22487610;
        val_9 = 13138448 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        string val_6 = System.String.Format(format:  1629069648, arg0:  -1383323712, arg1:  13152256);
        System.Action<System.Threading.Tasks.Task, System.Object> val_7 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1382658096, method:  new IntPtr(2912284176));
        App.networkManager.DoPut(path:  1629069648, postBody:  data, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false);
    }
    private void putResponse(string method, System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        if(Logger.GameEvents != false)
        {
                string val_1 = PrettyPrint.printJSON(obj:  data, types:  false, singleLineOutput:  false);
            string val_2 = -1382557808(-1382557808) + data;
            val_9 = "EVENT PUT RESPONSE : ";
            UnityEngine.Debug.LogWarning(message:  -1382557808);
        }
        
        this.synching = false;
        if(data == 0)
        {
                return;
        }
        
        val_9 = "success";
        if((data.ContainsKey(key:  1616271776)) == false)
        {
                return;
        }
        
        object val_4 = data.Item[1616271776];
        val_9 = data;
        val_10 = null;
        val_9.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(null == 0)
        {
                return;
        }
        
        if((data.ContainsKey(key:  1624646480)) != false)
        {
                this.updateDesc(desc:  data);
        }
        
        NotificationCenter val_6 = NotificationCenter.DefaultCenter;
        val_9 = 0;
        System.Collections.Hashtable val_7 = null;
        val_10 = val_7;
        val_7 = new System.Collections.Hashtable(d:  data);
        val_9.PostNotification(aSender:  -1382533568, aName:  -1382557696, aData:  75878400);
    }
    private void storeData()
    {
        twelvegigs.sweepstakes.Distribution val_4;
        if(this.initialized == false)
        {
                return;
        }
        
        if((this.<cheating>k__BackingField) == true)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = val_4.Serialize();
        Add(item:  val_4);
        goto label_7;
        label_4:
        Dispose();
        string val_6 = MiniJSON.Json.Serialize(obj:  80883712);
        UnityEngine.PlayerPrefs.SetString(key:  this.prefkey, value:  80883712);
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        string val_8 = ???.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  this.timeCheatStampKey, value:  -1382413144);
    }
    private void loadDescs(System.Collections.IList descs)
    {
        var val_7;
        var val_8;
        float val_9;
        float val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_7 = 0;
        val_7 = val_7 + 1;
        val_8 = descs;
        val_9 = 1152921504683417600;
        val_10 = 1152921504683257856;
        label_19:
        val_7 = 0;
        val_7 = val_7 + 1;
        val_11 = descs;
        if(descs == 0)
        {
            goto label_11;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_12 = descs;
        val_13 = 0;
        if(descs != 0)
        {
                val_13 = descs;
            if(val_13 == 0)
        {
                val_13 = 0;
        }
        
        }
        
        this.updateDesc(desc:  0);
        goto label_19;
        label_11:
        val_14 = 0;
        val_15 = 1152921504619679744;
        if(descs != 0)
        {
                val_7 = 0;
            val_15 = 0;
            val_7 = val_7 + 1;
            val_15 = (uint)val_7 & 65535;
            val_16 = descs;
        }
        
        var val_5 = FP - 28;
    }
    private void updateDesc(System.Collections.IDictionary desc)
    {
        var val_4;
        init(desc:  desc);
        if(new GameEventV2() == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = GetEnumerator();
        if(MoveNext() != false)
        {
                Dispose();
            val_4.update(data:  desc);
            return;
        }
        
        Dispose();
        this.eventList.Add(item:  317624320);
    }
    public GameEventsManager()
    {
        this.prefkey = "GameEventsDataV2";
        System.TimeSpan val_1 = new System.TimeSpan(hours:  0, minutes:  0, seconds:  0);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.eventList = null;
    }
    private static GameEventsManager()
    {
        var val_1;
        GameEventsManager.lastEventsResponse = "no response ever";
        val_1 = null;
        val_1 = null;
        GameEventsManager.lastServerUpdate = System.DateTime.MinValue;
        GameEventsManager.lastEventsResponse.__il2cppRuntimeField_C = System.DateTime.DateDataField.__il2cppRuntimeField_C;
        GameEventsManager.secondsToLastUpdate = 20;
    }

}
