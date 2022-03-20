using UnityEngine;
public class Amplitude
{
    // Fields
    private static readonly string UnityLibraryName;
    private static readonly string UnityLibraryVersion;
    private static System.Collections.Generic.Dictionary<string, Amplitude> instances;
    private static readonly object instanceLock;
    private static readonly string androidPluginName;
    private UnityEngine.AndroidJavaClass pluginClass;
    public bool logging;
    private string instanceName;
    
    // Properties
    public static Amplitude Instance { get; }
    
    // Methods
    public static Amplitude getInstance()
    {
        return Amplitude.getInstance(instanceName:  null);
    }
    public static Amplitude getInstance(string instanceName)
    {
        var val_7;
        var val_8;
        System.Collections.Generic.Dictionary<System.String, Amplitude> val_9;
        var val_10;
        val_7 = null;
        if((System.String.IsNullOrEmpty(value:  instanceName)) == false)
        {
                "$default_instance" = instanceName;
        }
        
        val_7 = null;
        System.Threading.Monitor.Enter(obj:  Amplitude.instanceLock, lockTaken: ref  bool val_2 = true);
        val_8 = null;
        val_8 = null;
        if(Amplitude.instances == 0)
        {
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_8 = null;
            val_8 = null;
            Amplitude.instances = null;
        }
        
        val_8 = null;
        val_9 = Amplitude.instances;
        if((TryGetValue(key:  "$default_instance", value: out  UnityEngine.Material val_4 = -1891213320)) != true)
        {
                Amplitude val_6 = null;
            val_9 = val_6;
            val_6 = new Amplitude(instanceName:  instanceName);
            val_10 = null;
            val_10 = null;
            val_9 = val_9;
            Add(key:  "$default_instance", value:  288763904);
        }
        
        if(0 != 0)
        {
                System.Threading.Monitor.Exit(obj:  Amplitude.instanceLock);
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public static Amplitude get_Instance()
    {
        return Amplitude.getInstance();
    }
    public Amplitude(string instanceName)
    {
        UnityEngine.AndroidJavaClass val_3;
        var val_4;
        var val_5;
        val_3 = 35635500;
        this.instanceName = instanceName;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 == 11)
        {
                UnityEngine.Debug.Log(message:  -1890993088);
            val_4 = null;
            val_4 = null;
            UnityEngine.AndroidJavaClass val_2 = null;
            val_3 = val_2;
            val_2 = new UnityEngine.AndroidJavaClass(className:  Amplitude.androidPluginName);
            this.pluginClass = val_3;
        }
        
        val_5 = null;
        val_5 = null;
        this.setLibraryName(libraryName:  Amplitude.UnityLibraryName);
        this.setLibraryVersion(libraryVersion:  Amplitude.UnityLibraryVersion);
    }
    protected void Log(string message)
    {
        if(this.logging == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  message);
    }
    protected void Log<T>(string message, string property, System.Collections.Generic.IEnumerable<T> array)
    {
        var val_4;
        typeof(System.Object[]).__il2cppRuntimeField_10 = message;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        val_4 = mem[public static T[] System.Array::Empty<System.Char>().__il2cppRuntimeField_18 + 186];
        val_4 = public static T[] System.Array::Empty<System.Char>().__il2cppRuntimeField_18 + 186;
        if(val_4 == 1)
        {
                val_4 = mem[public static T[] System.Array::Empty<System.Char>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Char>().__il2cppRuntimeField_18 + 186;
        }
        
        System.String[] val_1 = array.Split(separator:  public static T[] System.Array::Empty<System.Char>().__il2cppRuntimeField_18 + 92);
        string val_2 = System.String.Join(separator:  1370307136, value:  array);
        typeof(System.Object[]).__il2cppRuntimeField_1C = ", ";
        string val_3 = System.String.Format(format:  -1890743376, args:  472754880);
        this.Log(message:  -1890743376);
    }
    public void init(string apiKey)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_11 = this;
        string val_1 = System.String.Format(format:  -1890614880, arg0:  apiKey);
        this.Log(message:  -1890614880);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
            goto label_66;
        }
        
        UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  1282230784);
        object val_4 = GetStatic<System.Object>(fieldName:  1282231936);
        val_12 = null;
        val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_13 == 1)
        {
                val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_5 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1890614784, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_14 = val_12;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_12;
        typeof(System.Object[]).__il2cppRuntimeField_18 = apiKey;
        this.pluginClass.CallStatic(methodName:  -1890606496, args:  472754880);
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_14;
        val_15 = 0;
        this.pluginClass.CallStatic(methodName:  -1890598224, args:  472754880);
        if(val_14 == 0)
        {
            goto label_29;
        }
        
        UnityEngine.AndroidJavaClass val_10 = null;
        if((mem[null + 178]) == 0)
        {
            goto label_30;
        }
        
        val_11 = 0;
        label_32:
        if((mem[null + 88] + 0) == null)
        {
            goto label_31;
        }
        
        val_11 = val_11 + 1;
        if(((uint)val_11 & 65535) < (mem[null + 178]))
        {
            goto label_32;
        }
        
        label_30:
        val_16 = val_14;
        goto label_33;
        label_31:
        var val_6 = (mem[null + 88]) + 0;
        val_10 = val_10 + (((mem[null + 88] + 0) + 4) << 3);
        label_33:
        label_29:
        if(val_12 == 0)
        {
            goto label_35;
        }
        
        UnityEngine.AndroidJavaClass val_11 = null;
        if((mem[null + 178]) == 0)
        {
            goto label_36;
        }
        
        val_11 = 0;
        label_38:
        val_15 = 0;
        if((mem[null + 88] + 0) == null)
        {
            goto label_37;
        }
        
        val_11 = val_11 + 1;
        val_15 = (uint)val_11 & 65535;
        if(val_15 < (mem[null + 178]))
        {
            goto label_38;
        }
        
        label_36:
        val_17 = val_12;
        goto label_39;
        label_37:
        var val_7 = (mem[null + 88]) + 0;
        val_11 = val_11 + (((mem[null + 88] + 0) + 4) << 3);
        label_39:
        label_35:
        val_18 = 0;
        if(0 != 0)
        {
                val_19 = null;
        }
        else
        {
                val_19 = null;
        }
        
        if(val_19 == 0)
        {
            goto label_61;
        }
        
        UnityEngine.AndroidJavaClass val_12 = null;
        if((mem[null + 178]) == 0)
        {
            goto label_62;
        }
        
        val_11 = 0;
        label_64:
        val_15 = 0;
        if((mem[null + 88] + 0) == null)
        {
            goto label_63;
        }
        
        val_11 = val_11 + 1;
        val_15 = (uint)val_11 & 65535;
        if(val_15 < (mem[null + 178]))
        {
            goto label_64;
        }
        
        label_62:
        val_20 = val_19;
        goto label_65;
        label_63:
        var val_8 = (mem[null + 88]) + 0;
        val_12 = val_12 + (((mem[null + 88] + 0) + 4) << 3);
        label_65:
        label_61:
        label_66:
        var val_9 = FP - 28;
    }
    public void init(string apiKey, string userId)
    {
        var val_11;
        object val_12;
        var val_13;
        float val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_11 = this;
        val_12 = userId;
        string val_1 = System.String.Format(format:  -1890457424, arg0:  apiKey, arg1:  val_12);
        this.Log(message:  -1890457424);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
            goto label_49;
        }
        
        UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  1282230784);
        object val_4 = GetStatic<System.Object>(fieldName:  1282231936);
        val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_13 == 1)
        {
                val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_5 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1890614784, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_12 = null;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        val_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_14;
        typeof(System.Object[]).__il2cppRuntimeField_18 = apiKey;
        typeof(System.Object[]).__il2cppRuntimeField_1C = val_12;
        this.pluginClass.CallStatic(methodName:  -1890606496, args:  472754880);
        val_15 = null;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_12;
        val_16 = 0;
        this.pluginClass.CallStatic(methodName:  -1890598224, args:  472754880);
        if(val_12 == 0)
        {
            goto label_32;
        }
        
        UnityEngine.AndroidJavaClass val_11 = null;
        if((mem[null + 178]) == 0)
        {
            goto label_33;
        }
        
        var val_10 = 0;
        label_35:
        val_12 = mem[mem[null + 88] + 0];
        val_12 = mem[null + 88] + 0;
        if(val_12 == null)
        {
            goto label_34;
        }
        
        val_10 = val_10 + 1;
        if(((uint)val_10 & 65535) < (mem[null + 178]))
        {
            goto label_35;
        }
        
        label_33:
        val_17 = val_12;
        val_18 = val_12;
        goto label_36;
        label_34:
        var val_6 = (mem[null + 88]) + 0;
        val_18 = val_12;
        val_11 = val_11 + (((mem[null + 88] + 0) + 4) << 3);
        label_36:
        label_32:
        if(val_14 == 0)
        {
            goto label_38;
        }
        
        UnityEngine.AndroidJavaClass val_12 = null;
        if((mem[null + 178]) == 0)
        {
            goto label_39;
        }
        
        val_16 = 0;
        label_41:
        val_12 = 0;
        if((mem[null + 88] + 0) == null)
        {
            goto label_40;
        }
        
        val_16 = val_16 + 1;
        val_12 = (uint)val_16 & 65535;
        if(val_12 < (mem[null + 178]))
        {
            goto label_41;
        }
        
        label_39:
        val_19 = val_14;
        goto label_42;
        label_40:
        var val_7 = (mem[null + 88]) + 0;
        val_12 = val_12 + (((mem[null + 88] + 0) + 4) << 3);
        label_42:
        label_38:
        if(val_15 == 0)
        {
            goto label_44;
        }
        
        UnityEngine.AndroidJavaClass val_13 = null;
        if((mem[null + 178]) == 0)
        {
            goto label_45;
        }
        
        val_16 = 0;
        label_47:
        val_12 = 0;
        if((mem[null + 88] + 0) == null)
        {
            goto label_46;
        }
        
        val_16 = val_16 + 1;
        val_12 = (uint)val_16 & 65535;
        if(val_12 < (mem[null + 178]))
        {
            goto label_47;
        }
        
        label_45:
        val_20 = val_15;
        goto label_48;
        label_46:
        var val_8 = (mem[null + 88]) + 0;
        val_13 = val_13 + (((mem[null + 88] + 0) + 4) << 3);
        label_48:
        label_44:
        label_49:
        var val_9 = FP - 28;
    }
    public void setTrackingOptions(System.Collections.Generic.IDictionary<string, bool> trackingOptions)
    {
        if(trackingOptions == 0)
        {
                return;
        }
        
        string val_1 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  trackingOptions);
        string val_2 = System.String.Format(format:  -1890300240, arg0:  trackingOptions);
        this.Log(message:  -1890300240);
        UnityEngine.RuntimePlatform val_3 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = trackingOptions;
        this.pluginClass.CallStatic(methodName:  -1890291904, args:  472754880);
    }
    public void logEvent(string evt)
    {
        string val_1 = System.String.Format(format:  -1890163408, arg0:  evt);
        this.Log(message:  -1890163408);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = evt;
        this.pluginClass.CallStatic(methodName:  1673410272, args:  472754880);
    }
    public void logEvent(string evt, System.Collections.Generic.IDictionary<string, object> properties)
    {
        System.Collections.Generic.IDictionary<System.String, System.Object> val_5 = properties;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        }
        
        string val_2 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  78753792);
        string val_3 = System.String.Format(format:  -1890022624, arg0:  evt, arg1:  78753792);
        this.Log(message:  -1890022624);
        UnityEngine.RuntimePlatform val_4 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = evt;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_5;
        this.pluginClass.CallStatic(methodName:  1673410272, args:  472754880);
    }
    public void logEvent(string evt, System.Collections.Generic.IDictionary<string, object> properties, bool outOfSession)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5;
        var val_6;
        val_5 = properties;
        val_6 = 35635507;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        }
        
        string val_2 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  78753792);
        string val_3 = System.String.Format(format:  -1889877712, arg0:  evt, arg1:  78753792, arg2:  8945664);
        this.Log(message:  -1889877712);
        UnityEngine.RuntimePlatform val_4 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_6 = null;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = evt;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_5;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        this.pluginClass.CallStatic(methodName:  1673410272, args:  472754880);
    }
    public void setOffline(bool offline)
    {
        string val_3;
        bool val_4;
        val_3 = this;
        val_4 = offline;
        string val_1 = System.String.Format(format:  -1889740944, arg0:  8945664);
        this.Log(message:  -1889740944);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        this.pluginClass.CallStatic(methodName:  -1889732640, args:  472754880);
    }
    public void setUserId(string userId)
    {
        string val_1 = System.String.Format(format:  -1889608256, arg0:  userId);
        this.Log(message:  -1889608256);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = userId;
        this.pluginClass.CallStatic(methodName:  1692905504, args:  472754880);
    }
    public void setUserProperties(System.Collections.Generic.IDictionary<string, object> properties)
    {
        System.Collections.Generic.IDictionary<System.String, System.Object> val_5 = properties;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        }
        
        string val_2 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  78753792);
        string val_3 = System.String.Format(format:  -1889471568, arg0:  78753792);
        this.Log(message:  -1889471568);
        UnityEngine.RuntimePlatform val_4 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_5;
        this.pluginClass.CallStatic(methodName:  -1889463248, args:  472754880);
    }
    public void setOptOut(bool enabled)
    {
        string val_3;
        bool val_4;
        val_3 = this;
        val_4 = enabled;
        string val_1 = System.String.Format(format:  -1889338848, arg0:  8945664);
        this.Log(message:  -1889338848);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        this.pluginClass.CallStatic(methodName:  -1889330544, args:  472754880);
    }
    public void setMinTimeBetweenSessionsMillis(long minTimeBetweenSessionsMillis)
    {
        string val_1 = System.String.Format(format:  -1889210256, arg0:  13205504);
        this.Log(message:  -1889210256);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        this.pluginClass.CallStatic(methodName:  -1889201920, args:  472754880);
    }
    public void setDeviceId(string deviceId)
    {
        string val_1 = System.String.Format(format:  -1889077488, arg0:  deviceId);
        this.Log(message:  -1889077488);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = deviceId;
        this.pluginClass.CallStatic(methodName:  -1889069184, args:  472754880);
    }
    public void enableCoppaControl()
    {
        this.Log(message:  -1888944800);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        this.pluginClass.CallStatic(methodName:  -1888936496, args:  472754880);
    }
    public void disableCoppaControl()
    {
        var val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_1 = System.String.Format(format:  -1888816192, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        this.Log(message:  -1888816192);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        this.pluginClass.CallStatic(methodName:  -1888807888, args:  472754880);
    }
    public void setServerUrl(string serverUrl)
    {
        var val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_1 = System.String.Format(format:  -1888683488, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        this.Log(message:  -1888683488);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = serverUrl;
        this.pluginClass.CallStatic(methodName:  -1888675184, args:  472754880);
    }
    public void setGlobalUserProperties(System.Collections.Generic.IDictionary<string, object> properties)
    {
        this.setUserProperties(properties:  properties);
    }
    public void logRevenue(double amount)
    {
        string val_1 = System.String.Format(format:  -1888430608, arg0:  10489856);
        this.Log(message:  -1888430608);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        this = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = this;
        this.pluginClass.CallStatic(methodName:  -1888422304, args:  472754880);
    }
    public void logRevenue(string productId, int quantity, double price)
    {
        string val_2 = System.String.Format(format:  -1888297920, arg0:  productId, arg1:  13152256, arg2:  10489856);
        this.Log(message:  -1888297920);
        UnityEngine.RuntimePlatform val_3 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = productId;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        this.pluginClass.CallStatic(methodName:  -1888422304, args:  472754880);
    }
    public void logRevenue(string productId, int quantity, double price, string receipt, string receiptSignature)
    {
        var val_3;
        var val_4;
        string val_1 = System.String.Format(format:  -1888153024, arg0:  productId, arg1:  13152256, arg2:  10489856);
        this.Log(message:  -1888153024);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = productId;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        quantity = val_4;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_3;
        typeof(System.Object[]).__il2cppRuntimeField_24 = quantity;
        this.pluginClass.CallStatic(methodName:  -1888422304, args:  472754880);
    }
    public void logRevenue(string productId, int quantity, double price, string receipt, string receiptSignature, string revenueType, System.Collections.Generic.IDictionary<string, object> eventProperties)
    {
        var val_1;
        var val_4;
        var val_7;
        System.Collections.Generic.IDictionary<System.String, System.Object> val_8;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_9;
        string val_10;
        val_8 = this;
        val_9 = val_1;
        val_10 = productId;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        }
        
        string val_3 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  78753792);
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_10;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = val_4;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_9;
        string val_5 = System.String.Format(format:  -1887991712, args:  472754880);
        this.Log(message:  -1887991712);
        UnityEngine.RuntimePlatform val_6 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_10;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        val_8 = eventProperties;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        val_10 = val_7;
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_8;
        typeof(System.Object[]).__il2cppRuntimeField_24 = val_10;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_4;
        typeof(System.Object[]).__il2cppRuntimeField_2C = val_9;
        this.pluginClass.CallStatic(methodName:  -1888422304, args:  472754880);
    }
    public string getDeviceId()
    {
        string val_3;
        var val_4;
        val_3 = this;
        val_4 = 0;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        UnityEngine.AndroidJavaObject val_2 = this.pluginClass.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1887834480, args:  472754880);
        val_4 = this.pluginClass;
    }
    public void regenerateDeviceId()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        this.pluginClass.CallStatic(methodName:  -1887706000, args:  472754880);
    }
    public void useAdvertisingIdForDeviceId()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        this.pluginClass.CallStatic(methodName:  -1887577504, args:  472754880);
    }
    public void trackSessionEvents(bool enabled)
    {
        string val_3;
        bool val_4;
        val_3 = this;
        val_4 = enabled;
        string val_1 = System.String.Format(format:  -1887457184, arg0:  8945664);
        this.Log(message:  -1887457184);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        this.pluginClass.CallStatic(methodName:  -1887448864, args:  472754880);
    }
    public long getSessionId()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return 0;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        if(this.pluginClass != 0)
        {
                return this.pluginClass.CallStatic<System.Int64>(methodName:  -1887319344, args:  472754880);
        }
        
        return this.pluginClass.CallStatic<System.Int64>(methodName:  -1887319344, args:  472754880);
    }
    public void uploadEvents()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        this.pluginClass.CallStatic(methodName:  -1887190864, args:  472754880);
    }
    public void clearUserProperties()
    {
        var val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_1 = System.String.Format(format:  -1887070576, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        this.Log(message:  -1887070576);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        this.pluginClass.CallStatic(methodName:  -1887062272, args:  472754880);
    }
    public void unsetUserProperty(string property)
    {
        string val_1 = System.String.Format(format:  -1886937872, arg0:  property);
        this.Log(message:  -1886937872);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        this.pluginClass.CallStatic(methodName:  -1886929552, args:  472754880);
    }
    public void setOnceUserProperty(string property, bool value)
    {
        string val_1 = System.String.Format(format:  -1886801056, arg0:  property, arg1:  8945664);
        this.Log(message:  -1886801056);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, double value)
    {
        string val_3;
        object val_4;
        val_3 = this;
        val_4 = property;
        string val_1 = System.String.Format(format:  -1886801056, arg0:  val_4, arg1:  10489856);
        this.Log(message:  -1886801056);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_4;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, float value)
    {
        string val_3;
        object val_4;
        val_3 = this;
        val_4 = property;
        string val_1 = System.String.Format(format:  -1886801056, arg0:  val_4, arg1:  15282176);
        this.Log(message:  -1886801056);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_4;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, int value)
    {
        string val_1 = System.String.Format(format:  -1886801056, arg0:  property, arg1:  13152256);
        this.Log(message:  -1886801056);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, long value)
    {
        string val_1 = System.String.Format(format:  -1886801056, arg0:  property, arg1:  13205504);
        this.Log(message:  -1886801056);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        this = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, string value)
    {
        string val_1 = System.String.Format(format:  -1886801056, arg0:  property, arg1:  value);
        this.Log(message:  -1886801056);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = value;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, System.Collections.Generic.IDictionary<string, object> values)
    {
        if(values == 0)
        {
                return;
        }
        
        string val_1 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  values);
        string val_2 = System.String.Format(format:  -1886801056, arg0:  property, arg1:  values);
        this.Log(message:  -1886801056);
        UnityEngine.RuntimePlatform val_3 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = values;
        this.pluginClass.CallStatic(methodName:  -1885960864, args:  472754880);
    }
    public void setOnceUserProperty<T>(string property, System.Collections.Generic.IList<T> values)
    {
        if(values == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1351975056, value:  values);
        string val_2 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  78753792);
        string val_3 = System.String.Format(format:  -1886801056, arg0:  property, arg1:  78753792);
        35643271 = "C# setOnceUserProperty {0}, {1}";
        this.Log(message:  -1886801056);
        UnityEngine.RuntimePlatform val_4 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1885815968, args:  472754880);
    }
    public void setOnceUserProperty(string property, bool[] array)
    {
        this.Log<System.Boolean>(message:  -1885646496, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, double[] array)
    {
        this.Log<System.Double>(message:  -1885646496, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, float[] array)
    {
        this.Log<System.Single>(message:  -1885646496, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, int[] array)
    {
        this.Log<System.Int32>(message:  -1885646496, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, long[] array)
    {
        this.Log<System.Int64>(message:  -1885646496, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setOnceUserProperty(string property, string[] array)
    {
        this.Log<System.String>(message:  -1885646496, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1886792720, args:  472754880);
    }
    public void setUserProperty(string property, bool value)
    {
        string val_1 = System.String.Format(format:  -1884415280, arg0:  property, arg1:  8945664);
        this.Log(message:  -1884415280);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, double value)
    {
        string val_3;
        object val_4;
        val_3 = this;
        val_4 = property;
        string val_1 = System.String.Format(format:  -1884415280, arg0:  val_4, arg1:  10489856);
        this.Log(message:  -1884415280);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_4;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, float value)
    {
        string val_3;
        object val_4;
        val_3 = this;
        val_4 = property;
        string val_1 = System.String.Format(format:  -1884415280, arg0:  val_4, arg1:  15282176);
        this.Log(message:  -1884415280);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_4;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, int value)
    {
        string val_1 = System.String.Format(format:  -1884415280, arg0:  property, arg1:  13152256);
        this.Log(message:  -1884415280);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, long value)
    {
        string val_1 = System.String.Format(format:  -1884415280, arg0:  property, arg1:  13205504);
        this.Log(message:  -1884415280);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        this = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, string value)
    {
        string val_1 = System.String.Format(format:  -1884415280, arg0:  property, arg1:  value);
        this.Log(message:  -1884415280);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = value;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, System.Collections.Generic.IDictionary<string, object> values)
    {
        if(values == 0)
        {
                return;
        }
        
        string val_1 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  values);
        string val_2 = System.String.Format(format:  -1884415280, arg0:  property, arg1:  values);
        this.Log(message:  -1884415280);
        UnityEngine.RuntimePlatform val_3 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = values;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty<T>(string property, System.Collections.Generic.IList<T> values)
    {
        if(values == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1351975056, value:  values);
        string val_2 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  78753792);
        string val_3 = System.String.Format(format:  -1884415280, arg0:  property, arg1:  78753792);
        35643272 = "C# setUserProperty {0}, {1}";
        this.Log(message:  -1884415280);
        UnityEngine.RuntimePlatform val_4 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1883430336, args:  472754880);
    }
    public void setUserProperty(string property, bool[] array)
    {
        this.Log<System.Boolean>(message:  -1883260880, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, double[] array)
    {
        this.Log<System.Double>(message:  -1883260880, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, float[] array)
    {
        this.Log<System.Single>(message:  -1883260880, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, int[] array)
    {
        this.Log<System.Int32>(message:  -1883260880, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, long[] array)
    {
        this.Log<System.Int64>(message:  -1883260880, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void setUserProperty(string property, string[] array)
    {
        this.Log<System.String>(message:  -1883260880, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1884406960, args:  472754880);
    }
    public void addUserProperty(string property, double value)
    {
        string val_3;
        object val_4;
        val_3 = this;
        val_4 = property;
        string val_1 = System.String.Format(format:  -1882035808, arg0:  val_4, arg1:  10489856);
        this.Log(message:  -1882035808);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_4;
        this.pluginClass.CallStatic(methodName:  -1882027488, args:  472754880);
    }
    public void addUserProperty(string property, float value)
    {
        string val_3;
        object val_4;
        val_3 = this;
        val_4 = property;
        string val_1 = System.String.Format(format:  -1882035808, arg0:  val_4, arg1:  15282176);
        this.Log(message:  -1882035808);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_4;
        this.pluginClass.CallStatic(methodName:  -1882027488, args:  472754880);
    }
    public void addUserProperty(string property, int value)
    {
        string val_1 = System.String.Format(format:  -1882035808, arg0:  property, arg1:  13152256);
        this.Log(message:  -1882035808);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1882027488, args:  472754880);
    }
    public void addUserProperty(string property, long value)
    {
        string val_1 = System.String.Format(format:  -1882035808, arg0:  property, arg1:  13205504);
        this.Log(message:  -1882035808);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        this = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1882027488, args:  472754880);
    }
    public void addUserProperty(string property, string value)
    {
        string val_1 = System.String.Format(format:  -1882035808, arg0:  property, arg1:  value);
        this.Log(message:  -1882035808);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = value;
        this.pluginClass.CallStatic(methodName:  -1882027488, args:  472754880);
    }
    public void addUserProperty(string property, System.Collections.Generic.IDictionary<string, object> values)
    {
        if(values == 0)
        {
                return;
        }
        
        string val_1 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  values);
        string val_2 = System.String.Format(format:  -1882035808, arg0:  property, arg1:  values);
        this.Log(message:  -1882035808);
        UnityEngine.RuntimePlatform val_3 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = values;
        this.pluginClass.CallStatic(methodName:  -1881332208, args:  472754880);
    }
    public void appendUserProperty(string property, bool value)
    {
        string val_1 = System.String.Format(format:  -1881199616, arg0:  property, arg1:  8945664);
        this.Log(message:  -1881199616);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, double value)
    {
        string val_3;
        object val_4;
        val_3 = this;
        val_4 = property;
        string val_1 = System.String.Format(format:  -1881199616, arg0:  val_4, arg1:  10489856);
        this.Log(message:  -1881199616);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_4;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, float value)
    {
        string val_3;
        object val_4;
        val_3 = this;
        val_4 = property;
        string val_1 = System.String.Format(format:  -1881199616, arg0:  val_4, arg1:  15282176);
        this.Log(message:  -1881199616);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        val_3 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_4;
        val_4 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_4;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, int value)
    {
        string val_1 = System.String.Format(format:  -1881199616, arg0:  property, arg1:  13152256);
        this.Log(message:  -1881199616);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, long value)
    {
        string val_1 = System.String.Format(format:  -1881199616, arg0:  property, arg1:  13205504);
        this.Log(message:  -1881199616);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        this = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, string value)
    {
        string val_1 = System.String.Format(format:  -1881199616, arg0:  property, arg1:  value);
        this.Log(message:  -1881199616);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = value;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, System.Collections.Generic.IDictionary<string, object> values)
    {
        if(values == 0)
        {
                return;
        }
        
        string val_1 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  values);
        string val_2 = System.String.Format(format:  -1881199616, arg0:  property, arg1:  values);
        this.Log(message:  -1881199616);
        UnityEngine.RuntimePlatform val_3 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = values;
        this.pluginClass.CallStatic(methodName:  -1880359440, args:  472754880);
    }
    public void appendUserProperty<T>(string property, System.Collections.Generic.IList<T> values)
    {
        if(values == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1351975056, value:  values);
        string val_2 = AmplitudeNS.MiniJSON.Json.Serialize(obj:  78753792);
        string val_3 = System.String.Format(format:  -1881199616, arg0:  property, arg1:  78753792);
        35643270 = "C# appendUserProperty {0}, {1}";
        this.Log(message:  -1881199616);
        UnityEngine.RuntimePlatform val_4 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        this.pluginClass.CallStatic(methodName:  -1880214560, args:  472754880);
    }
    public void appendUserProperty(string property, bool[] array)
    {
        this.Log<System.Boolean>(message:  -1880045104, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, double[] array)
    {
        this.Log<System.Double>(message:  -1880045104, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, float[] array)
    {
        this.Log<System.Single>(message:  -1880045104, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, int[] array)
    {
        this.Log<System.Int32>(message:  -1880045104, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, long[] array)
    {
        this.Log<System.Int64>(message:  -1880045104, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    public void appendUserProperty(string property, string[] array)
    {
        this.Log<System.String>(message:  -1880045104, property:  property, array:  array);
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = property;
        typeof(System.Object[]).__il2cppRuntimeField_18 = array;
        this.pluginClass.CallStatic(methodName:  -1881191296, args:  472754880);
    }
    private void setLibraryName(string libraryName)
    {
        string val_1 = System.String.Format(format:  -1878820032, arg0:  libraryName);
        this.Log(message:  -1878820032);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = libraryName;
        this.pluginClass.CallStatic(methodName:  -1878811728, args:  472754880);
    }
    private void setLibraryVersion(string libraryVersion)
    {
        string val_1 = System.String.Format(format:  -1878683248, arg0:  libraryVersion);
        this.Log(message:  -1878683248);
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.instanceName;
        typeof(System.Object[]).__il2cppRuntimeField_14 = libraryVersion;
        this.pluginClass.CallStatic(methodName:  -1878674928, args:  472754880);
    }
    public void startSession()
    {
    
    }
    public void endSession()
    {
    
    }
    private static Amplitude()
    {
        Amplitude.UnityLibraryName = "amplitude-unity";
        Amplitude.UnityLibraryVersion = "1.6.0";
        Amplitude.instanceLock = new System.Object();
        Amplitude.androidPluginName = "com.amplitude.unity.plugins.AmplitudePlugin";
    }

}
