using UnityEngine;
public class ServerRequestTracker : MonoSingleton<ServerRequestTracker>
{
    // Fields
    private const string RequestEventsKey = "request_events_key";
    private const int EventsPerRequests = 5;
    private twelvegigs.net.JsonApiRequester apiRequester;
    private bool trackerEnabled;
    private string deviceId;
    private System.Collections.Generic.List<RequestEvent> requestEvents;
    private string railsGameName;
    private string loggerUrl;
    
    // Properties
    public static bool IsLoaded { get; }
    public string RailsGameName { get; }
    public string LoggerUrl { get; }
    
    // Methods
    public static bool get_IsLoaded()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return UnityEngine.Object.op_Inequality(x:  -202710272, y:  0);
    }
    private void Start()
    {
    
    }
    public void OnServerResponded()
    {
        var val_6;
        var val_7;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -202461152, name:  -1976323520);
        var val_6 = 27787011;
        val_6 = 7840404 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        twelvegigs.storage.JsonDictionary val_2 = getGameplayKnobs();
        if((Contains(key:  -202485248)) == false)
        {
                return;
        }
        
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        twelvegigs.storage.JsonDictionary val_4 = getGameplayKnobs();
        this.trackerEnabled = getBool(key:  -202485248);
    }
    public void TrackResponse(twelvegigs.net.JsonRequestStats stats, System.Collections.Generic.Dictionary<string, object> response)
    {
        bool val_8;
        string val_11;
        System.Net.HttpStatusCode val_12;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_13;
        bool val_14;
        bool val_15;
        val_11 = stats.duration;
        val_12 = stats.responseCode;
        if((System.String.op_Equality(a:  stats.url, b:  1466316768)) != true)
        {
                if((System.String.op_Equality(a:  stats.url, b:  1466317088)) == false)
        {
            goto label_4;
        }
        
        }
        
        System.Uri val_5 = new System.Uri(uriString:  val_11);
        string val_6 = GetLeftPart(part:  2);
        val_11 = val_5;
        string val_7 = ParseGetParams(uri:  103514112);
        val_13 = val_5;
        goto label_6;
        label_4:
        val_13 = response;
        label_6:
        val_14 = val_8;
        val_15 = 0;
        if(val_14 != 0)
        {
                val_12 = "success";
            if((val_14.ContainsKey(key:  1616271776)) != false)
        {
                string val_10 = val_14.Item[1616271776];
            val_12 = null;
            val_14.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_15 = mem[val_8];
            val_15 = val_14;
            val_14 = val_8;
        }
        
        }
        
        this.AddEvent(te:  new RequestEvent() {method = stats.url, url = val_11, jsonParams = val_13, duration_ms = System.Convert.ToInt32(value:  null), responseCode = stats.jsonParams, success = val_15});
        this.LogDynamicError(response:  val_14);
    }
    private void LogDynamicError(System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_5;
        if(response == 0)
        {
                return;
        }
        
        val_5 = "error_message";
        if((response.ContainsKey(key:  1622701360)) == false)
        {
                return;
        }
        
        System.Collections.Hashtable val_2 = new System.Collections.Hashtable();
        object val_3 = response.Item[1622701360];
        val_5 = 0;
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -343337056, aData:  75878400);
    }
    private string ParseGetParams(System.Uri uri)
    {
        string val_1 = uri.Query;
        if((System.String.IsNullOrEmpty(value:  uri)) == true)
        {
                return;
        }
        
        if(uri.m_String == 1)
        {
                return;
        }
        
        string val_3 = uri.Substring(startIndex:  1);
        System.Collections.Generic.Dictionary<System.String, System.String> val_4 = twelvegigs.net.JsonApiRequester.GetHashFromQuery(query:  uri);
        return MiniJSON.Json.Serialize(obj:  uri);
    }
    private void AddEvent(RequestEvent te)
    {
        string val_1;
        string val_2;
        string val_3;
        string val_4;
        string val_5;
        val_1 = te.jsonParams;
        val_2 = te.url;
        val_3 = te.method;
        val_4 = val_2;
        val_5 = val_1;
        if(this.trackerEnabled == false)
        {
                return;
        }
        
        if(this.requestEvents == 0)
        {
                val_1 = val_5;
            val_2 = val_4;
            val_3 = val_3;
            val_4 = val_2;
            val_5 = val_1;
        }
        
        this.requestEvents.Add(item:  new RequestEvent() {method = val_3, url = val_4, jsonParams = val_5, duration_ms = te.duration_ms, responseCode = te.responseCode, success = te.success});
        this.Flush();
    }
    private bool ShouldFlush()
    {
        if(R1 > 5)
        {
                0 = 1;
        }
        
        return true;
    }
    private void Flush()
    {
        if(this.ShouldFlush() == false)
        {
                return;
        }
        
        int val_2 = System.Math.Min(val1:  this.requestEvents, val2:  5);
        System.Collections.Generic.List<T> val_3 = this.requestEvents.GetRange(index:  0, count:  val_2);
        T[] val_4 = this.requestEvents.ToArray();
        this.requestEvents.RemoveRange(index:  0, count:  val_2);
        this.Track(events:  this.requestEvents);
    }
    private void Track(RequestEvent[] events)
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4;
        var val_6;
        val_4 = null;
        val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_6 = 0;
        goto label_1;
        label_17:
        R7.Add(key:  1373043792, value:  -979723824);
        R7.Add(key:  1614311920, value:  -979723824);
        R7.Add(key:  -201586464, value:  -979723824);
        R7.Add(key:  -201586384, value:  13152256);
        val_4 = val_4;
        R7.Add(key:  -201586288, value:  13152256);
        RequestEvent val_4 = events[20];
        R7.Add(key:  1616271776, value:  8945664);
        R7.Add(key:  -201586192, value:  mem[1152921512995219492]);
        Add(item:  R7);
        val_6 = 1;
        label_1:
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_6 < mem[1152921512995219492])
        {
            goto label_17;
        }
        
        string val_3 = this.RailsGameName;
        if(null != 0)
        {
                Add(key:  -233819456, value:  -201562096);
        }
        else
        {
                Add(key:  -233819456, value:  -201562096);
        }
        
        Add(key:  1956399680, value:  80883712);
        mem[1152921512995219484].DoPost(path:  System.String.alignConst, postBody:  78753792, onCompleteFunction:  0, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    private void responseComplete(string url, System.Collections.Generic.Dictionary<string, object> obj)
    {
        if(obj == 0)
        {
                return;
        }
        
        if((obj.ContainsKey(key:  1622701360)) == false)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = url;
        string val_2 = PrettyPrint.printJSON(obj:  obj, types:  false, singleLineOutput:  false);
        typeof(System.Object[]).__il2cppRuntimeField_14 = obj;
        UnityEngine.Debug.LogErrorFormat(format:  -201429040, args:  472754880);
    }
    private void SaveData()
    {
        if(true >= 1)
        {
                string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.requestEvents);
            UnityEngine.PlayerPrefs.SetString(key:  -201300544, value:  this.requestEvents);
            return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  -201300544);
    }
    private void LoadData()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -201300544)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  R5);
        object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  R5);
        mem2[0] = R5;
    }
    private string GetRequestTrackerUrl()
    {
        return this.LoggerUrl;
    }
    public string get_RailsGameName()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.railsGameName);
        if(val_1 == false)
        {
                return;
        }
        
        string val_2 = val_1.GetGameRailsName();
        this.railsGameName = val_1;
    }
    private string GetGameRailsName()
    {
        AppConfigs val_1 = App.Configuration;
        string val_2 = 5.Replace(oldValue:  1359327184, newValue:  2144339952);
        string val_3 = 5.Replace(oldValue:  -200826832, newValue:  1098586544);
        if(5 != 0)
        {
                return 5.Replace(oldValue:  -200826736, newValue:  1098586544);
        }
        
        return 5.Replace(oldValue:  -200826736, newValue:  1098586544);
    }
    public string get_LoggerUrl()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.loggerUrl);
        if(val_1 == false)
        {
                return;
        }
        
        string val_2 = val_1.ServerRequestLoggerUrl();
        this.loggerUrl = val_1;
    }
    private string ServerRequestLoggerUrl()
    {
        AppConfigs val_1 = App.Configuration;
        if(5 != 0)
        {
                return 5.Replace(oldValue:  -200586112, newValue:  -200586240);
        }
        
        return 5.Replace(oldValue:  -200586112, newValue:  -200586240);
    }
    public ServerRequestTracker()
    {
        this.trackerEnabled = true;
        System.Collections.Generic.List<RequestEvent> val_1 = new System.Collections.Generic.List<RequestEvent>();
        this.requestEvents = null;
    }
    private void <Start>b__8_0()
    {
        this.apiRequester.Dequeue();
    }

}
