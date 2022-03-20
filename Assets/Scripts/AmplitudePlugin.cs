using UnityEngine;
public class AmplitudePlugin : Tracker, PluginObserver
{
    // Fields
    private static bool initialized;
    private System.Collections.Generic.Dictionary<string, object> loadedData;
    
    // Methods
    public PluginObserverManager.ObserverType getType()
    {
    
    }
    public string pluginName()
    {
    
    }
    public string errorMessage()
    {
        var val_2;
        var val_3;
        var val_4;
        var val_2 = 26390592;
        val_2 = 9241516 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(AmplitudePlugin.initialized != false)
        {
                if(AmplitudePlugin.__il2cppRuntimeField_cctor_finished == 0)
        {
                "Event Tracking is working correctly. " = "Event Tracking is not being used. ";
        }
        
            string val_1 = -1988223120(-1988223120) + -1988223008(-1988223008);
            val_3 = "Plugin initialized. ";
            val_4 = null;
            val_4 = null;
            if(PluginObserverManager.isPurchaseValidationWorking != true)
        {
                return;
        }
        
            return -1988223120(-1988223120) + -1988222720(-1988222720);
        }
        
        val_3 = "Not initialized!";
    }
    public bool isWorking()
    {
        return (bool)this;
    }
    public bool isInitialized()
    {
        null = null;
        return (bool)AmplitudePlugin.initialized;
    }
    public static bool TrackingEnabled(string eventName)
    {
        var val_10 = 1;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1877313984)) == false)
        {
                return (bool)val_10;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1877313984);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1877313984);
        if("amplitude" != 0)
        {
                if(null == null)
        {
            goto label_23;
        }
        
        }
        
        label_23:
        string val_4 = 0.Item[-1987367680];
        val_10 = 0;
        if((System.Boolean.Parse(value:  null)) == false)
        {
                return (bool)val_10;
        }
        
        string val_6 = eventName.Replace(oldValue:  1297836560, newValue:  2144339952);
        string val_7 = eventName.ToLower();
        typeof(System.Object[]).__il2cppRuntimeField_10 = eventName;
        UnityEngine.Debug.LogWarningFormat(format:  -1877313888, args:  472754880);
        val_10 = 1;
        if((0.ContainsKey(key:  eventName)) == false)
        {
                return (bool)val_10;
        }
        
        string val_9 = 0.Item[eventName];
        return System.Boolean.Parse(value:  null);
    }
    public AmplitudePlugin()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        AddObserver(observer:  -1877173680);
    }
    public AmplitudePlugin(string apiKey, string deviceId)
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        AddObserver(observer:  -1877053488);
        Amplitude val_2 = Amplitude.Instance;
        mem[12] = 1;
        Amplitude val_3 = Amplitude.Instance;
        0.init(apiKey:  apiKey, userId:  deviceId);
        val_4 = null;
        val_4 = null;
        AmplitudePlugin.initialized = true;
    }
    public override void increment(string eventName, string eventValue)
    {
    
    }
    public override void peopleIncrement(string eventName, string eventValue)
    {
    
    }
    public override void superProperty(string propertyName, string propertyValue)
    {
        string val_1 = -1876692336(-1876692336) + propertyName;
        this.Log(message:  -1876692336);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  propertyName, value:  propertyValue);
        Amplitude val_3 = Amplitude.Instance;
        0.setUserProperties(properties:  78753792);
    }
    public override void peopleProperty(string propertyName, string propertyValue)
    {
        goto typeof(AmplitudePlugin).__il2cppRuntimeField_10C;
    }
    public override void trackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_11;
        var val_12;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_13;
        var val_14;
        val_11 = data;
        val_12 = 35631892;
        if((AmplitudePlugin.TrackingEnabled(eventName:  eventName)) == false)
        {
                return;
        }
        
        if(val_11 == 0)
        {
                val_13 = null;
            val_13 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            string val_3 = -1876435440(-1876435440) + eventName + -1876435312(-1876435312);
            UnityEngine.Debug.LogError(message:  -1876435440);
        }
        
        Player val_4 = App.Player;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        AmplitudePluginHelper.InjectRegularGlobals(eventName:  288923648, globals:  78753792);
        AmplitudePluginHelper.InjectFeatureGlobals(eventName:  eventName, globals:  78753792);
        AmplitudePluginHelper.InjectMetaData(eventName:  eventName, data:  78753792);
        AmplitudePluginHelper.InjectMetaBehaviorProperties(eventName:  eventName, globals: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = -1876423072, data: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = -1876423068);
        Amplitude val_8 = Amplitude.Instance;
        0.setUserProperties(properties:  78753792);
        Amplitude val_9 = Amplitude.Instance;
        val_14 = val_13;
        val_12 = 0;
        val_12.logEvent(evt:  eventName, properties:  78753792);
        mem[1152921511320370564] = 1;
        string val_10 = -1876435200(-1876435200) + eventName;
        this.Log(message:  -1876435200);
    }
    public override void trackEvent(string eventName, string propertyName, string propertyValue)
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = "Amplitude trackEvent ";
        typeof(System.String[]).__il2cppRuntimeField_14 = eventName;
        typeof(System.String[]).__il2cppRuntimeField_18 = " {";
        typeof(System.String[]).__il2cppRuntimeField_1C = propertyName;
        typeof(System.String[]).__il2cppRuntimeField_20 = ": ";
        typeof(System.String[]).__il2cppRuntimeField_24 = propertyValue;
        typeof(System.String[]).__il2cppRuntimeField_28 = "}";
        string val_1 = +477709520;
        this.Log(message:  477709520);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  propertyName, value:  propertyValue);
        goto typeof(AmplitudePlugin).__il2cppRuntimeField_E4;
    }
    public override void identify(string userId)
    {
        string val_1 = -1876173984(-1876173984) + userId;
        this.Log(message:  -1876173984);
        Amplitude val_2 = Amplitude.Instance;
        0.setUserId(userId:  userId);
    }
    public override void trackCharge(string amount, System.Collections.Generic.Dictionary<string, object> options)
    {
        string val_18;
        var val_19;
        var val_20;
        var val_21;
        val_18 = amount;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        object val_2 = options.Item[-1987121728];
        if(options != 0)
        {
                object val_3 = options.Item[-1987121728];
            if(options != 0)
        {
                val_19 = null;
            val_19 = null;
            if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (NativePurchase.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_19)
        {
                options = 0;
        }
        
        }
        
            0.AddStoreSpecificDataForValidation(postParams: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = -1876037256);
        }
        
        val_20 = 0;
        val_21 = "signature";
        string val_6 = Item[1470913968];
        if(null == 0)
        {
                return;
        }
        
        string val_7 = Item[1470913968];
        string val_8 = ToString();
        if((System.String.IsNullOrEmpty(value:  78753792)) == true)
        {
                return;
        }
        
        Amplitude val_10 = Amplitude.Instance;
        string val_11 = Item[-1876049584];
        string val_12 = ToString();
        val_18 = null;
        string val_13 = Item[-1876049488];
        string val_14 = ToString();
        string val_15 = Item[1470913968];
        string val_16 = ToString();
        val_20 = 0;
        val_21 = null;
        val_20.logRevenue(productId:  78753792, quantity:  1, price:  System.Convert.ToDouble(value:  val_18), receipt:  null, receiptSignature:  val_18);
        string val_17 = -1876049392(-1876049392) + val_18;
        this.Log(message:  -1876049392);
    }
    private void TrackWebglCharge(string amount, string webProductId)
    {
    
    }
    private static AmplitudePlugin()
    {
    
    }

}
