using UnityEngine;
public class AdjustPlugin
{
    // Fields
    private const string CURRENCY = "USD";
    private static string REVENUE_TOKEN;
    private const AdjustPlugin.AmountTrackingType type = 0;
    private static string <clickLabelInstall>k__BackingField;
    private static string <Attribution_network>k__BackingField;
    private static string <Attribution_adgroup>k__BackingField;
    private static string <Attribution_campaign>k__BackingField;
    private static string <Attribution_trackerName>k__BackingField;
    private static string <Attribution_trackerToken>k__BackingField;
    private static string <Attribution_latestMessage>k__BackingField;
    public static bool consumedAdjustInstall;
    
    // Properties
    private static double DeductionFactor { get; }
    public static string clickLabelInstall { get; set; }
    public static string Attribution_network { get; set; }
    public static string Attribution_adgroup { get; set; }
    public static string Attribution_campaign { get; set; }
    public static string Attribution_trackerName { get; set; }
    public static string Attribution_trackerToken { get; set; }
    public static string Attribution_latestMessage { get; set; }
    
    // Methods
    public static com.adjust.sdk.AdjustConfig BuildAdjustConfig(string appToken)
    {
        var val_9;
        System.Action<System.String> val_11;
        string val_1 = -1905762272(-1905762272) + appToken;
        UnityEngine.Debug.Log(message:  -1905762272);
        CompanyDevices val_2 = CompanyDevices.Instance;
        setLogLevel(logLevel:  1);
        System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  0, method:  new IntPtr(2389205136));
        if((new com.adjust.sdk.AdjustConfig(appToken:  appToken, environment:  0.CompanyDevice() ^ 1)) != 0)
        {
                typeof(com.adjust.sdk.AdjustConfig).__il2cppRuntimeField_C0 = null;
        }
        else
        {
                mem[192] = null;
        }
        
        typeof(com.adjust.sdk.AdjustConfig).__il2cppRuntimeField_8A = 1;
        val_9 = null;
        val_9 = null;
        val_11 = AdjustPlugin.<>c.<>9__4_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  AdjustPlugin.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2389207184));
            AdjustPlugin.<>c.<>9__4_0 = val_11;
        }
        
        setDeferredDeeplinkDelegate(deferredDeeplinkDelegate:  7401472, sceneName:  -1905759088);
        System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  0, method:  new IntPtr(2389208288));
        setAttributionChangedDelegate(attributionChangedDelegate:  7401472, sceneName:  -1905759088);
    }
    public static void AddRevenueEventToken(string token)
    {
        null = null;
        AdjustPlugin.type = token;
    }
    public static com.adjust.sdk.AdjustEvent BuildEvent(string eventToken, System.Collections.Generic.Dictionary<string, string> eventParams)
    {
        string val_6;
        string val_8 = eventToken;
        com.adjust.sdk.AdjustEvent val_1 = new com.adjust.sdk.AdjustEvent(eventToken:  val_8 = eventToken);
        if(eventParams == 0)
        {
                return;
        }
        
        if(eventParams.Count < 1)
        {
                return;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_3 = eventParams.Keys;
        val_8 = eventParams;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        string val_7 = eventParams.Item[val_6];
        addPartnerParameter(key:  val_6, value:  eventParams);
        goto label_6;
        label_4:
        Dispose();
    }
    public static com.adjust.sdk.AdjustEvent BuildTrackChargeEvent(double amount, string transactionId)
    {
        null = null;
        com.adjust.sdk.AdjustEvent val_1 = new com.adjust.sdk.AdjustEvent(eventToken:  AdjustPlugin.type);
        if(R2 != 0)
        {
                typeof(com.adjust.sdk.AdjustEvent).__il2cppRuntimeField_14 = R2;
        }
        
        setRevenue(amount:  amount, currency:  null);
    }
    private static double get_DeductionFactor()
    {
        return (double)D0;
    }
    public static void logDelegate(string message)
    {
        var val_1;
        var val_1 = 24727774;
        val_1 = 10907804 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AdjustPlugin.<Attribution_latestMessage>k__BackingField = message;
    }
    public static string get_clickLabelInstall()
    {
        null = null;
    }
    public static void set_clickLabelInstall(string value)
    {
        null = null;
        AdjustPlugin.<clickLabelInstall>k__BackingField = value;
    }
    public static void attributionChangedDelegate(com.adjust.sdk.AdjustAttribution attribution)
    {
        var val_1;
        string val_2;
        var val_3;
        var val_1 = 24727307;
        val_1 = 10908272 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AdjustPlugin.<Attribution_network>k__BackingField = attribution.<network>k__BackingField;
        val_1 = null;
        val_1 = null;
        AdjustPlugin.<Attribution_adgroup>k__BackingField = attribution.<adgroup>k__BackingField;
        val_1 = null;
        val_1 = null;
        AdjustPlugin.<Attribution_campaign>k__BackingField = attribution.<campaign>k__BackingField;
        val_1 = null;
        val_1 = null;
        AdjustPlugin.<Attribution_trackerName>k__BackingField = attribution.<trackerName>k__BackingField;
        val_2 = attribution.<trackerToken>k__BackingField;
        val_1 = null;
        val_1 = null;
        AdjustPlugin.<Attribution_trackerToken>k__BackingField = val_2;
        if((attribution.<clickLabel>k__BackingField) == null)
        {
                return;
        }
        
        val_2 = 10908768 + 24726816;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        AdjustPlugin.<clickLabelInstall>k__BackingField = attribution.<clickLabel>k__BackingField;
    }
    public static string get_Attribution_network()
    {
        null = null;
    }
    public static void set_Attribution_network(string value)
    {
        null = null;
        AdjustPlugin.<Attribution_network>k__BackingField = value;
    }
    public static string get_Attribution_adgroup()
    {
        null = null;
    }
    private static void set_Attribution_adgroup(string value)
    {
        null = null;
        AdjustPlugin.<Attribution_adgroup>k__BackingField = value;
    }
    public static string get_Attribution_campaign()
    {
        null = null;
    }
    private static void set_Attribution_campaign(string value)
    {
        null = null;
        AdjustPlugin.<Attribution_campaign>k__BackingField = value;
    }
    public static string get_Attribution_trackerName()
    {
        null = null;
    }
    private static void set_Attribution_trackerName(string value)
    {
        null = null;
        AdjustPlugin.<Attribution_trackerName>k__BackingField = value;
    }
    public static string get_Attribution_trackerToken()
    {
        null = null;
    }
    private static void set_Attribution_trackerToken(string value)
    {
        null = null;
        AdjustPlugin.<Attribution_trackerToken>k__BackingField = value;
    }
    public static string get_Attribution_latestMessage()
    {
        null = null;
    }
    private static void set_Attribution_latestMessage(string value)
    {
        null = null;
        AdjustPlugin.<Attribution_latestMessage>k__BackingField = value;
    }
    public AdjustPlugin()
    {
    
    }
    private static AdjustPlugin()
    {
    
    }

}
