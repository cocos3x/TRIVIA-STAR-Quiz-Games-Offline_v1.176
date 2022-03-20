using UnityEngine;
public class WGTimelineTracker : MonoBehaviour
{
    // Fields
    protected const string timelineKey = "level_gen_timeline";
    protected const string startStampKey = "level_gen_start_stamp";
    protected const string versionKey = "level_gen_version";
    protected bool enabled;
    private System.DateTime <startStamp>k__BackingField;
    protected System.DateTime previousEventAt;
    protected System.Collections.Generic.List<TimelineEvent> timeline;
    protected string levelWord;
    protected string levelWords;
    protected string currentLanguage;
    protected string deviceId;
    protected MainController.GameModeForTracking currentGameMode;
    protected twelvegigs.net.JsonApiRequester apiRequester;
    private string levelGenerationUrl;
    private string railsGameName;
    private static WGTimelineTracker _instance;
    
    // Properties
    public static bool IsLoaded { get; }
    public System.DateTime startStamp { get; set; }
    protected virtual int LevelGenerationVersion { get; }
    public string LevelGenerationUrl { get; }
    public string RailsGameName { get; }
    public static WGTimelineTracker Instance { get; }
    
    // Methods
    public static bool get_IsLoaded()
    {
        return false;
    }
    public System.DateTime get_startStamp()
    {
        this = R1 + 16;
        return new System.DateTime() {dateData = 1152921513270744560};
    }
    protected void set_startStamp(System.DateTime value)
    {
        this.<startStamp>k__BackingField = new System.DateTime();
        mem[1152921513270856580] = R3;
    }
    protected virtual int get_LevelGenerationVersion()
    {
        return 2;
    }
    private void Start()
    {
        AppConfigs val_1 = App.Configuration;
        this.enabled = false;
        string val_2 = this.LevelGenerationUrl;
        System.Action val_3 = new System.Action(object:  74300016, method:  new IntPtr(74274992));
        this.apiRequester = new twelvegigs.net.JsonApiRequester(ServerURL:  74300016, dequeueHandler:  7454720, logStuff:  false, adminServerURL:  0, throwExceptionsOnRequestFailures:  false);
        string val_5 = DeviceIdPlugin.GetDeviceId();
        this.deviceId = 0;
        this.LoadData();
    }
    public virtual void LevelStarted(string levelword, string levelWords, MainController.GameModeForTracking gameMode, string levelLanguage)
    {
        System.DateTime val_3;
        System.DateTime val_1 = System.DateTime.Now;
        this.<startStamp>k__BackingField = val_3;
        this.currentGameMode = gameMode;
        this.levelWord = levelword;
        this.levelWords = levelWords;
        this.currentLanguage = levelLanguage;
    }
    public virtual void WordSpelled(string word)
    {
        bool val_1 = this.levelWord.Equals(value:  word);
    }
    public virtual void ExtraWordSpelled(string word)
    {
    
    }
    public virtual void LevelCompleted()
    {
    
    }
    public virtual void HintUsed()
    {
    
    }
    protected virtual void SetDropoff()
    {
    
    }
    protected virtual void AddEvent(TimelineEvent te)
    {
        Type val_1;
        var val_2;
        System.DateTime val_5;
        System.Collections.Generic.List<TimelineEvent> val_6;
        Type val_7;
        var val_8;
        bool val_9;
        double val_10;
        string val_11;
        val_6 = 35633660;
        if(this.enabled == false)
        {
                return;
        }
        
        val_6 = this.timeline;
        val_7 = val_1;
        val_8 = val_2;
        val_9 = te.isLevelWord;
        val_10 = te.stamp;
        val_11 = te.language;
        if(val_6 == 0)
        {
                val_11 = te.language;
            val_10 = te.stamp;
            val_9 = te.isLevelWord;
            val_8 = val_2;
            val_7 = val_1;
        }
        
        val_6.Add(item:  new TimelineEvent() {type = val_7, gameMode = te.gameMode, word = te.word, levelWord = te.levelWord, levelWords = te.levelWords, language = val_11, stamp = val_10, delta = te.delta, isLevelWord = te.delta});
        System.DateTime val_3 = System.DateTime.Now;
        this.previousEventAt = val_5;
        this.Flush();
    }
    protected virtual TimelineEvent CreateEvent(TimelineEvent.Type t, string w, bool isLevelWord = False)
    {
        string val_3;
        var val_5;
        string val_12;
        System.DateTime val_1 = System.DateTime.Now;
        System.TimeSpan val_4 = Subtract(value:  new System.DateTime() {dateData = 1152921513272040280});
        double val_7 = val_5.TotalMilliseconds;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
        {
                75258704 = 75258704;
        }
        
        if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = 1152921513272040272}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                0 = 0;
            System.DateTime val_9 = System.DateTime.Now;
            System.TimeSpan val_10 = Subtract(value:  new System.DateTime() {dateData = 1152921513272040280});
            double val_11 = val_5.TotalMilliseconds;
            if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
        {
                75258704 = 75258704;
        }
        
        }
        
        mem[1152921513272052344] = isLevelWord;
        this.previousEventAt = new System.DateTime();
        this.timeline = 75258704;
        this.levelWords = val_12;
        return new TimelineEvent() {type = 75270809, gameMode = 75258720, word = 7, levelWord = isLevelWord, levelWords = val_3, isLevelWord = false};
    }
    protected bool ShouldFlush()
    {
        if(R1 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    protected void Flush()
    {
        if(this.ShouldFlush() == true)
        {
            goto label_1;
        }
        
        return;
        label_6:
        if((R4 + 32 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = (R4 + 32 + 8) + 32;
        mem2[0] = R4 + 32 + 8 + 16;
        mem2[0] = R4 + 32 + 8 + 20;
        mem2[0] = R4 + 32 + 8 + 24;
        mem2[0] = R4 + 32 + 8 + 28;
        mem2[0] = R4 + 32 + 8 + 44;
        R4 + 32.RemoveAt(index:  0);
        label_1:
        if((R4 + 32 + 12) > 0)
        {
            goto label_6;
        }
        
        var val_3 = FP - 28;
    }
    protected virtual void Track(TimelineEvent te)
    {
        var val_2;
        string val_9 = te.levelWords;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_4 = App.Player;
        if(null == 0)
        {
                val_9 = val_9;
        }
        
        Add(key:  75600176, value:  13152256);
        Add(key:  75600272, value:  val_9);
        Add(key:  75600352, value:  te.language);
        Add(key:  75600448, value:  10489856);
        if(val_2 != 0)
        {
                val_2 = 1;
        }
        
        Add(key:  75600544, value:  8945664);
        if(null != 0)
        {
                set_Item(key:  -1898403488, value:  10489856);
        }
        
        if((System.String.IsNullOrEmpty(value:  te.levelWord)) != true)
        {
                set_Item(key:  -2085463936, value:  te.levelWord);
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1470926528, value:  13152256);
        string val_7 = this.RailsGameName;
        Add(key:  -233819456, value:  75632832);
        int val_8 = ServerHandler.UnixServerTime;
        Add(key:  -1898276784, value:  13152256);
        Add(key:  -1824276416, value:  this.deviceId);
        Add(key:  -1176122288, value:  278806528);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        Add(key:  1350676976, value:  394674176);
        if(null != 0)
        {
                Add(key:  -184943744, value:  te.stamp);
        }
        else
        {
                Add(key:  -184943744, value:  te.stamp);
        }
        
        Add(key:  -184943568, value:  78753792);
        this.apiRequester.DoPut(path:  System.String.alignConst, postBody:  78753792, onCompleteFunction:  0, timeout:  20, destroy:  false, immediate:  false);
    }
    private void LoadData()
    {
        System.DateTime val_7;
        var val_14;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_17 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  75729024)) != false)
        {
                val_17 = UnityEngine.PlayerPrefs.GetInt(key:  75729024);
        }
        
        val_18 = "level_gen_start_stamp";
        if(val_17 == this)
        {
                if((UnityEngine.PlayerPrefs.HasKey(key:  75729136)) != false)
        {
                string val_4 = UnityEngine.PlayerPrefs.GetString(key:  75729136);
            val_19 = null;
            val_19 = null;
            System.DateTime val_5 = SLCDateTime.Parse(dateTime:  75742328, defaultValue:  new System.DateTime() {dateData = 1152921513272510704});
            this.<startStamp>k__BackingField = val_7;
        }
        
            if((UnityEngine.PlayerPrefs.HasKey(key:  75729248)) != false)
        {
                string val_9 = UnityEngine.PlayerPrefs.GetString(key:  75729248);
            object val_10 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  75729248);
            this.timeline = "level_gen_timeline";
        }
        
            val_20 = null;
            val_20 = null;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = this.<startStamp>k__BackingField}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) == true)
        {
                return;
        }
        
            System.DateTime val_12 = System.DateTime.Now;
            System.TimeSpan val_13 = Subtract(value:  new System.DateTime() {dateData = 1152921513272523912});
            double val_16 = val_14.TotalDays;
            return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  75729136);
        UnityEngine.PlayerPrefs.DeleteKey(key:  75729248);
    }
    public void SaveData()
    {
        var val_4;
        if(0 >= 1)
        {
                string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.timeline);
            UnityEngine.PlayerPrefs.SetString(key:  75729248, value:  this.timeline);
        }
        
        val_4 = null;
        val_4 = null;
        if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = this.<startStamp>k__BackingField}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                string val_3 = this.<startStamp>k__BackingField.ToString();
            UnityEngine.PlayerPrefs.SetString(key:  75729136, value:  75862536);
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  75729024, value:  75874576);
    }
    public string get_LevelGenerationUrl()
    {
        if((System.String.IsNullOrEmpty(value:  this.levelGenerationUrl)) == false)
        {
                return;
        }
        
        this.levelGenerationUrl = "https://level-gen.12gigs.com";
    }
    private string GetLevelGenerationUrl()
    {
    
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
    public static WGTimelineTracker get_Instance()
    {
    
    }
    private void Awake()
    {
        if(WGTimelineTracker._instance != 0)
        {
                UnityEngine.Object.Destroy(obj:  76587664);
            return;
        }
        
        WGTimelineTracker._instance = this;
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  76587664);
    }
    public WGTimelineTracker()
    {
        System.Collections.Generic.List<TimelineEvent> val_1 = new System.Collections.Generic.List<TimelineEvent>();
        this.timeline = null;
        this.levelWord = System.String.alignConst;
        this.levelWords = System.String.alignConst;
        this.currentLanguage = System.String.alignConst;
        this.deviceId = System.String.alignConst;
    }
    private void <Start>b__20_0()
    {
        this.apiRequester.Dequeue();
    }

}
