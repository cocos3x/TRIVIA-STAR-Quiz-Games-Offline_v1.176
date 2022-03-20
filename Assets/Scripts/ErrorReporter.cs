using UnityEngine;
public class ErrorReporter : MonoSingleton<ErrorReporter>
{
    // Fields
    private int totalMaximumErrors;
    public bool enableMockErrors;
    private System.Collections.Generic.Dictionary<string, object> errorJsonObject;
    private int currentError;
    private int frameSkipper;
    private int currentFrame;
    private int timesSent;
    private int maxSent;
    private int hasResumed;
    private bool sending;
    private static string lastError;
    private static string lastStackTrace;
    public static bool IgnoreMaxSent;
    private string color;
    
    // Properties
    public static string LastError { get; }
    public static string LastStackTrace { get; }
    
    // Methods
    public static string get_LastError()
    {
        null = null;
    }
    public static string get_LastStackTrace()
    {
        null = null;
    }
    private void OnEnable()
    {
        Application.LogCallback val_1 = new Application.LogCallback(object:  -1858199728, method:  new IntPtr(2436742544));
        UnityEngine.Application.add_logMessageReceived(value:  150691840);
        this.FlushErrorDefinition();
    }
    private void OnDisable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1858111728) != (-1858086704))
        {
                return;
        }
        
        Application.LogCallback val_3 = new Application.LogCallback(object:  R4, method:  new IntPtr(2436742544));
        UnityEngine.Application.remove_logMessageReceived(value:  150691840);
    }
    private void Update()
    {
        var val_7;
        var val_8;
        int val_7 = this.currentFrame;
        val_7 = val_7 + 1;
        this.currentFrame = val_7;
        if(this.enableMockErrors != false)
        {
                if(val_7 == 0)
        {
                int val_1 = UnityEngine.Random.Range(min:  1, max:  5);
            val_1 = val_1 - 1;
            if(val_1 <= 3)
        {
                var val_2 = 8858860 + (8858860 + ((val_1 - 1)) << 2);
            if(val_1 == 3)
        {
                8858860 + ((val_1 - 1)) << 2 = (8858860 + ((val_1 - 1)) << 2) & ((8858860 + ((val_1 - 1)) << 2) << (8858860 + ((val_1 - 1)) << 2));
            8858860 + ((val_1 - 1)) << 2 = (8858860 + ((val_1 - 1)) << 2) & (this >> (8858860 + ((val_1 - 1)) << 2));
            8858860 + ((val_1 - 1)) << 2 = (8858860 + ((val_1 - 1)) << 2) & 579018240;
        }
        
            val_7 = public System.Void System.Collections.Generic.Dictionary<System.String, System.String>::Add(System.String key, System.String value);
            val_8 = "lol";
            Add(key:  -1857998704, value:  -1857998704);
        }
        
        }
        
        }
        
        if(this.currentFrame >= 201)
        {
                this.currentFrame = 0;
            this.currentFrame = this.currentFrame;
        }
    
    }
    private void HandleLog(string logString, string stackTrace, UnityEngine.LogType logType)
    {
        twelvegigs.net.JsonApiRequester val_18;
        string val_19;
        System.Action<System.Threading.Tasks.Task, System.Object> val_20;
        var val_21;
        string val_22;
        var val_23;
        var val_24;
        var val_25;
        val_18 = logType;
        val_19 = stackTrace;
        val_20 = 35631099;
        if((val_18 | 4) != 4)
        {
                return;
        }
        
        if((this.OldError(logString:  logString, stackTrace:  val_19)) == true)
        {
                return;
        }
        
        val_18 = 1152921504896462848;
        val_21 = null;
        val_21 = null;
        if(ErrorReporter.IgnoreMaxSent != true)
        {
                if(this.timesSent >= this.maxSent)
        {
                return;
        }
        
        }
        
        int val_18 = this.currentError;
        val_18 = val_18 + 1;
        this.currentError = val_18;
        if(val_18 > this.totalMaximumErrors)
        {
                this.enabled = false;
            return;
        }
        
        CompanyDevices val_3 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.Handheld.Vibrate();
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  -1857874240, value:  1);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_6 = DeviceIdPlugin.GetClientVersion();
        string val_7 = 289509376 + -1857874144(-1857874144) + logString;
        val_22 = null;
        CompanyDevices val_8 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                string val_10 = -1857874048(-1857874048) + 289509376;
            val_22 = "[DEV]";
        }
        
        if(null != 0)
        {
                Add(key:  -1857873968, value:  -1857874048);
        }
        else
        {
                Add(key:  -1857873968, value:  -1857874048);
        }
        
        Add(key:  -1857873872, value:  val_19);
        string val_11 = UnityEngine.Application.loadedLevelName;
        string val_12 = null + 1098586544;
        if(null != 0)
        {
                Add(key:  -1953384464, value:  0);
        }
        else
        {
                Add(key:  -1953384464, value:  0);
        }
        
        Add(key:  -1857873792, value:  1098586544);
        float val_13 = UnityEngine.Time.timeSinceLevelLoad;
        string val_14 = 0.ToString();
        Add(key:  1956820704, value:  -1857850088);
        string val_15 = this.hasResumed.ToString();
        Add(key:  -1857873696, value:  this.hasResumed);
        val_23 = null;
        val_23 = null;
        ErrorReporter.lastError = val_22;
        ErrorReporter.lastStackTrace = val_19;
        object val_16 = this.errorJsonObject.Item[-1857869504];
        if(this.errorJsonObject != 0)
        {
                val_24 = null;
            val_24 = null;
            if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_24)
        {
                this.errorJsonObject = 0;
        }
        
        }
        
        0.Add(item:  78753792);
        var val_19 = 26765498;
        val_19 = 8860560 + val_19;
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        val_25 = null;
        val_25 = null;
        val_19 = this.errorJsonObject;
        val_18 = App.networkManager;
        val_20 = null;
        val_20 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1857838048, method:  new IntPtr(2437103008));
        val_18.DoPost(path:  -1857862240, postBody:  val_19, onCompleteFunction:  7507968, timeout:  20, destroy:  true, immediate:  false, serverType:  0);
        int val_20 = this.timesSent;
        this.currentError = 0;
        val_20 = val_20 + 1;
        this.currentFrame = 0;
        this.timesSent = val_20;
        SLCDebug.Log(logMessage:  -1857874048, colorHash:  -1857862144, isError:  true);
    }
    private void OnApplicationPause(bool pauseStatus)
    {
        this.hasResumed = 1;
    }
    private bool OldError(string logString, string stackTrace)
    {
        var val_5;
        var val_10;
        var val_11;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        System.String[] val_1 = stackTrace.Split(separator:  478563824);
        object val_2 = this.errorJsonObject.Item[-1857869504];
        val_10 = 0;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_19:
        if(MoveNext() == false)
        {
            goto label_13;
        }
        
        val_10 = val_5;
        string val_6 = val_10.Item[-1857873968];
        if((val_10.IndexOf(value:  logString)) < 0)
        {
            goto label_19;
        }
        
        string val_8 = val_10.Item[-1857873872];
        if((val_10.IndexOf(value:  -1857578208)) < 0)
        {
            goto label_19;
        }
        
        val_11 = 1;
        goto label_20;
        label_13:
        val_11 = 0;
        label_20:
        Dispose();
        return (bool)val_11;
    }
    private void onCompleteFunction(string request, System.Collections.Generic.Dictionary<string, object> returnData)
    {
        this.FlushErrorDefinition();
        this.sending = false;
    }
    private bool ReachedMaximumErrors()
    {
        var val_5;
        var val_6;
        var val_7;
        if(this.errorJsonObject == 0)
        {
                return false;
        }
        
        val_5 = "errorLog";
        if((this.errorJsonObject.ContainsKey(key:  -1857869504)) == false)
        {
                return false;
        }
        
        object val_2 = this.errorJsonObject.Item[-1857869504];
        if(this.errorJsonObject != 0)
        {
                val_6 = null;
            val_6 = null;
            val_7 = 0;
            if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_6)
        {
                this.errorJsonObject = 0;
        }
        
            val_7 = this.errorJsonObject;
        }
        else
        {
                val_7 = 0;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_3 = val_7.Keys;
        int val_4 = val_7.Count;
        val_4 = val_4 - this.totalMaximumErrors;
        val_4 = val_4 >> 5;
        return (bool)val_4;
    }
    private void FlushErrorDefinition()
    {
        var val_13;
        var val_14;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.errorJsonObject = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(key:  -1857869504, value:  80883712);
        string val_3 = DeviceIdPlugin.GetDeviceId();
        this.errorJsonObject.Add(key:  -1857215008, value:  289509376);
        string val_4 = DeviceIdPlugin.GetClientVersion();
        this.errorJsonObject.Add(key:  -1857210816, value:  this.errorJsonObject);
        string val_5 = DeviceIdPlugin.GetMacAddress();
        this.errorJsonObject.Add(key:  -1857206624, value:  this.errorJsonObject);
        this.errorJsonObject.Add(key:  -1928946992, value:  1726392512);
        val_13 = "free";
        this.errorJsonObject.Add(key:  1470926528, value:  -1857198336);
        GameBehavior val_6 = App.getBehavior;
        string val_7 = 0.GetCurrentLanguage();
        if(0 != 0)
        {
                GameBehavior val_8 = App.getBehavior;
            string val_9 = 0.GetCurrentLanguage();
            val_13 = 0;
            this.errorJsonObject.Add(key:  -2085433328, value:  0);
        }
        
        var val_13 = 26769395;
        val_13 = 8858020 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        if(App.storageManager != 0)
        {
                Player val_10 = App.Player;
            if(0 != 0)
        {
                Player val_12 = App.Player;
            val_13 = 1835037;
            this.errorJsonObject.Add(key:  1618311216, value:  1835037);
        }
        
        }
        
        this.currentError = 0;
    }
    private string GetPlatform()
    {
    
    }
    private string GetVersion()
    {
    
    }
    public ErrorReporter()
    {
        this.frameSkipper = 60;
        this.totalMaximumErrors = 7;
        this.maxSent = 5;
        this.color = "[#ffffff]";
    }
    private static ErrorReporter()
    {
        ErrorReporter.lastError = "";
        ErrorReporter.lastStackTrace = "";
        ErrorReporter.IgnoreMaxSent = false;
    }

}
