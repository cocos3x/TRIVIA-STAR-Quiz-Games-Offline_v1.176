using UnityEngine;
public class HelpshiftPlugin : MonoSingletonSelfGenerating<HelpshiftPlugin>
{
    // Fields
    private static HelpshiftPlugin instance;
    private Helpshift.HelpshiftSdk help;
    private bool initialized;
    private string gameObjectName;
    private System.Collections.Generic.Dictionary<string, object> configMap;
    private System.Collections.Generic.Dictionary<string, object> metadata;
    private HelpshiftPlugin.CurrencyDelegate currencyCalculator;
    private bool fromFeedbackButton;
    
    // Properties
    private float iOSVersion { get; }
    
    // Methods
    private float get_iOSVersion()
    {
        return (float)S0;
    }
    public void Init(string gameObject, string apiKey, string domain, string appId, HelpshiftPlugin.CurrencyDelegate currencies)
    {
        var val_21;
        object val_22;
        val_21 = 35641688;
        if(this.initialized == true)
        {
                return;
        }
        
        Helpshift.HelpshiftSdk val_1 = Helpshift.HelpshiftSdk.getInstance();
        this.help = null;
        this.gameObjectName = gameObject;
        this.currencyCalculator = currencies;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.metadata = null;
        Player val_3 = App.Player;
        Add(key:  -1848111600, value:  52);
        Player val_4 = App.Player;
        this.metadata.Add(key:  -1857215008, value:  6);
        string val_5 = DeviceIdPlugin.GetClientVersion();
        this.metadata.Add(key:  -1848103312, value:  0);
        this.metadata.Add(key:  -1848099120, value:  1726392512);
        string val_6 = UnityEngine.SystemInfo.deviceModel;
        this.metadata.Add(key:  -1848094928, value:  0);
        string val_7 = this.currencyCalculator.Invoke();
        this.metadata.Add(key:  -1848086640, value:  this.currencyCalculator);
        GameBehavior val_8 = App.getBehavior;
        string val_9 = 0.ToString();
        this.metadata.Add(key:  -1988561632, value:  -1848020616);
        Player val_10 = App.Player;
        this.metadata.Add(key:  -1848078352, value:  8945664);
        Player val_11 = App.Player;
        val_22 = 0;
        if(val_22 != 0)
        {
                Player val_12 = App.Player;
            val_22 = this.metadata;
            val_22.Add(key:  -1848074160, value:  1879048193);
        }
        
        System.String[] val_13 = val_22.GetTags();
        this.metadata.Add(key:  -1848069968, value:  val_22);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_14 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.configMap = null;
        Add(key:  -1848065776, value:  this.gameObjectName);
        this.configMap.Add(key:  -1848061488, value:  -1848061568);
        this.configMap.Add(key:  -1848057264, value:  -1848061568);
        this.help.install(apiKey:  apiKey, domainName:  domain, appId:  appId, config:  this.configMap);
        this.help.updateMetaData(metaData:  this.metadata);
        Player val_15 = App.Player;
        val_21 = 6;
        object val_16 = new System.Object();
        typeof(HelpshiftUser.Builder).__il2cppRuntimeField_8 = val_21;
        typeof(HelpshiftUser.Builder).__il2cppRuntimeField_C = "";
        Helpshift.HelpshiftUser val_17 = build();
        this.help.login(helpshiftUser:  422256640);
        this.help.requestUnreadMessagesCount(isAsync:  true);
        this.initialized = true;
        UnityEngine.GameObject val_18 = this.gameObject;
        UnityEngine.Transform val_19 = this.transform;
        this.SetParent(p:  0);
        UnityEngine.GameObject val_20 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -1848008576);
    }
    public void ShowSupport(string prefillText = "")
    {
        if(this.initialized == false)
        {
                return;
        }
        
        TrackingComponent.CurrentIntent = 1;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1847818096, value:  -1847818176);
        if((System.String.IsNullOrEmpty(value:  prefillText)) != true)
        {
                Add(key:  -1847817968, value:  prefillText);
        }
        
        this.help.showConversation(configMap:  78753792);
    }
    public void ShowFAQs()
    {
        TrackingComponent.CurrentIntent = 1;
        if(this.initialized == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.help.showFAQs(configMap:  78753792);
    }
    public void UpdateMetadata()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.ToString();
        this.metadata.set_Item(key:  -1988561632, value:  -1847536732);
        string val_3 = this.currencyCalculator.Invoke();
        this.metadata.set_Item(key:  -1848086640, value:  this.currencyCalculator);
        System.String[] val_4 = this.metadata.GetTags();
        this.metadata.set_Item(key:  -1847556976, value:  this.metadata);
        this.help.updateMetaData(metaData:  this.metadata);
    }
    public bool UpdateDeviceToken()
    {
        if(this.help == 0)
        {
                return (bool)0;
        }
        
        string val_1 = DeviceProperties.notificationToken;
        if((System.String.IsNullOrEmpty(value:  null)) == true)
        {
                return (bool)0;
        }
        
        this.help.registerDeviceToken(deviceToken:  null);
        0 = 1;
        return (bool)0;
    }
    public void handleRemoteNotification(string issueId)
    {
    
    }
    private static string formatDeviceToken(byte[] token)
    {
        float val_10;
        var val_11;
        val_10 = "";
        string val_1 = System.BitConverter.ToString(value:  token);
        string val_2 = token.Replace(oldValue:  1359327184, newValue:  System.String.alignConst);
        val_11 = 0;
        string val_3 = token.ToLower();
        System.Char[] val_4 = token.ToCharArray();
        goto label_6;
        label_10:
        string val_5 = null.ToString();
        string val_6 = 1098586544 + -1847114566(-1847114566);
        val_10 = val_10;
        if(1 == 8)
        {
                var val_10 = 0;
            string val_7 = 1098586544 + 1297836560;
            val_10 = val_10;
        }
        
        val_11 = 1;
        val_10 = val_10 + 1;
        label_6:
        if(val_11 < val_10)
        {
            goto label_10;
        }
        
        string val_8 = Trim();
        string val_9 = -1847126688(-1847126688) + 1098586544 + -1847126608(-1847126608);
    }
    private string[] GetTags()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Player val_2 = App.Player;
        if(0 > 0)
        {
                Add(item:  -1846977664);
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  -1992995984, defaultValue:  0)) >= 1)
        {
                Add(item:  -1846977568);
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  -1857874240, defaultValue:  0)) >= 1)
        {
                Add(item:  -1857874240);
        }
        
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public void getNotifsCount()
    {
        this.help.requestUnreadMessagesCount(isAsync:  true);
    }
    public HelpshiftPlugin()
    {
    
    }

}
