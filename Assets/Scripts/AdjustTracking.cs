using UnityEngine;
public class AdjustTracking : Tracker, PluginObserver
{
    // Fields
    private bool initialized;
    private System.Collections.Generic.Dictionary<string, string> eventTokens;
    
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
        if(this.initialized != false)
        {
                if(R1 == 0)
        {
                "Event Tracking is working correctly. " = "Event Tracking is not being used. ";
        }
        
            string val_1 = -1988223120(-1988223120) + -1988223008(-1988223008);
            val_2 = "Plugin initialized. ";
            val_3 = null;
            val_3 = null;
            if(PluginObserverManager.isPurchaseValidationWorking != true)
        {
                return;
        }
        
            return -1988223120(-1988223120) + -1988222720(-1988222720);
        }
        
        val_2 = "Not initialized!";
    }
    public bool isWorking()
    {
        return (bool)this;
    }
    public bool isInitialized()
    {
        return (bool)this.initialized;
    }
    public AdjustTracking(string appToken)
    {
        if(this.initialized == true)
        {
                return;
        }
        
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        AddObserver(observer:  R4);
        com.adjust.sdk.AdjustConfig val_2 = AdjustPlugin.BuildAdjustConfig(appToken:  R5);
        com.adjust.sdk.Adjust.start(adjustConfig:  R5);
        UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  -1905759088);
        object val_4 = AddComponent<System.Object>();
        UnityEngine.Object.DontDestroyOnLoad(target:  157720576);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        mem2[0] = 1;
        mem2[0] = null;
    }
    public void AddEventToken(string eventName, string eventToken)
    {
        var val_6;
        var val_7;
        var val_8;
        if((this.eventTokens.ContainsKey(key:  eventName)) != false)
        {
                string val_2 = System.String.Format(format:  -1901978240, arg0:  eventName);
            UnityEngine.Debug.LogError(message:  -1901978240);
            return;
        }
        
        if((System.String.op_Equality(a:  eventToken, b:  1339790624)) != false)
        {
                string val_4 = -1901977952(-1901977952) + eventName + -1901978096(-1901978096);
            UnityEngine.Debug.LogWarning(message:  -1901977952);
            return;
        }
        
        val_6 = 1152921504891457536;
        val_7 = null;
        val_7 = null;
        if((System.String.op_Equality(a:  eventName, b:  Events.REVENUE_IAP)) != false)
        {
                val_6 = 10905924 + 24729661;
            if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
            val_8 = null;
            val_8 = null;
            AdjustPlugin.type = eventToken;
        }
        
        this.eventTokens.Add(key:  eventName, value:  eventToken);
    }
    public override void trackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> data)
    {
        string val_1 = -1901837184(-1901837184) + eventName;
        UnityEngine.Debug.Log(message:  -1901837184);
    }
    public override void trackEvent(string eventName, string propertyName, string propertyValue)
    {
        string val_17;
        System.Collections.Generic.Dictionary<System.String, System.String> val_18;
        System.Collections.Generic.Dictionary<System.String, System.String> val_19;
        string val_1 = eventName.ToLower();
        string val_2 = eventName.Replace(oldValue:  1297836560, newValue:  2144339952);
        val_17 = eventName;
        if((System.String.op_Equality(a:  val_17, b:  -1901704592)) == false)
        {
            goto label_3;
        }
        
        string val_4 = -1901704496(-1901704496) + propertyValue;
        val_18 = this;
        val_17 = "level_up_";
        val_19 = this.eventTokens;
        if((val_19.ContainsKey(key:  -1901700304)) == false)
        {
            goto label_5;
        }
        
        string val_6 = val_19.Item[-1901700304];
        val_19 = val_19;
        System.Collections.Generic.Dictionary<System.String, System.String> val_7 = getParams(addPropertyName:  -1988561632, addPropertyValue:  propertyValue);
        com.adjust.sdk.AdjustEvent val_8 = new com.adjust.sdk.AdjustEvent(eventToken:  val_19);
        com.adjust.sdk.AdjustEvent val_9 = AdjustPlugin.BuildEvent(eventToken:  val_19, eventParams:  "level");
        com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_19);
        goto label_10;
        label_3:
        val_18 = this.eventTokens;
        goto label_10;
        label_5:
        UnityEngine.Debug.LogError(message:  -1901700208);
        label_10:
        if((val_19.ContainsKey(key:  -1901704496)) != false)
        {
                string val_11 = val_19.Item[-1901704496];
            System.Collections.Generic.Dictionary<System.String, System.String> val_12 = getParams(addPropertyName:  1098586544, addPropertyValue:  1098586544);
            com.adjust.sdk.AdjustEvent val_13 = AdjustPlugin.BuildEvent(eventToken:  val_19, eventParams:  "");
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_19);
            string val_14 = -1901699984(-1901699984) + -1901704496(-1901704496);
            this.Log(message:  -1901699984);
            mem[1152921511295105924] = 1;
            return;
        }
        
        if((IndexOf(value:  -1901700304)) > 1)
        {
                return;
        }
        
        string val_16 = System.String.Format(format:  -1901699840, arg0:  -1901704496);
        UnityEngine.Debug.LogError(message:  -1901699840);
    }
    public override void trackCharge(string amount, System.Collections.Generic.Dictionary<string, object> options)
    {
        string val_1 = -1901563104(-1901563104) + amount;
        this.Log(message:  -1901563104);
        com.adjust.sdk.AdjustEvent val_3 = AdjustPlugin.BuildTrackChargeEvent(amount:  System.Convert.ToDouble(value:  amount), transactionId:  amount);
        com.adjust.sdk.Adjust.trackEvent(adjustEvent:  amount);
        mem[1152921511295242676] = 1;
    }
    private System.Collections.Generic.Dictionary<string, string> getParams(string addPropertyName = "", string addPropertyValue = "")
    {
        var val_9;
        string val_1 = DeviceProperties.DeviceModel;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 32;
        System.String[] val_2 = 0.Split(separator:  478563824);
        if(0 != 0)
        {
                string val_3 = DeviceProperties.DeviceModel;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 32;
            System.String[] val_4 = 0.Split(separator:  478563824);
            val_9 = 0 + 16;
        }
        else
        {
                val_9 = "mobile";
        }
        
        string val_5 = DeviceProperties.DeviceModel;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1901434464, value:  -1901434544);
        string val_7 = UnityEngine.WWW.EscapeURL(s:  null);
        Add(key:  -1928947152, value:  0);
        if((System.String.IsNullOrEmpty(value:  addPropertyName)) == true)
        {
                return;
        }
        
        Add(key:  addPropertyName, value:  addPropertyValue);
    }
    public override void increment(string eventName, string eventValue)
    {
    
    }
    public override void peopleIncrement(string eventName, string eventValue)
    {
    
    }
    public override void peopleProperty(string propertyName, string propertyValue)
    {
    
    }
    public override void superProperty(string propertyName, string propertyValue)
    {
    
    }
    public override void identify(string id)
    {
    
    }

}
