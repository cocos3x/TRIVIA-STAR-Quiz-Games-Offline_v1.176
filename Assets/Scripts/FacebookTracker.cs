using UnityEngine;
public class FacebookTracker : Tracker, PluginObserver
{
    // Methods
    public PluginObserverManager.ObserverType getType()
    {
    
    }
    public string pluginName()
    {
    
    }
    public string errorMessage()
    {
        var val_3;
        var val_4;
        if(this.isInitialized() != false)
        {
                if(R1 == 0)
        {
                "Event Tracking is working correctly. " = "Event Tracking is not being used. ";
        }
        
            string val_2 = -1988223120(-1988223120) + -1988223008(-1988223008);
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
        return Facebook.Unity.FB.IsInitialized;
    }
    public FacebookTracker()
    {
        UnityEngine.Debug.Log(message:  -1987886464);
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        AddObserver(observer:  -1987861312);
    }
    public override void trackEvent(string eventName, string propertyName, string propertyValue)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  propertyName, value:  propertyValue);
        goto typeof(FacebookTracker).__il2cppRuntimeField_E4;
    }
    public override void trackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> data)
    {
        if(Facebook.Unity.FB.IsInitialized == false)
        {
                return;
        }
        
        string val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>().getEventName(eventName:  eventName);
        new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>().addingGlobalProperties(eventName:  eventName, globals: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = data, data: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = -1987616580);
        System.Nullable<System.Single> val_6 = new System.Nullable<System.Single>(value:  null);
        Facebook.Unity.FB.LogAppEvent(logEvent:  new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>() = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>(), valueToSum:  new System.Nullable<System.Single>() {HasValue = val_6.HasValue}, parameters:  0);
        mem[1152921511209177060] = 1;
    }
    private void addingGlobalProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> globals, ref System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_9;
        Player val_1 = App.Player;
        val_9 = null;
        val_9 = null;
        if((System.String.op_Equality(a:  eventName, b:  Events.CURRENT_LEVEL)) != false)
        {
                object val_3 = data.Item[-1987496192];
            data.Add(key:  -1987496112, value:  data);
        }
        
        if((data.ContainsKey(key:  -1987496016)) != true)
        {
                var val_5 = 0 + 60;
            string val_6 = ToString();
            data.Add(key:  -1987496016, value:  -1987483992);
        }
        
        if((data.ContainsKey(key:  -1988561632)) == true)
        {
                return;
        }
        
        string val_8 = 0.ToString();
        data.Add(key:  -1988561632, value:  -1987483996);
    }
    private bool TrackingEnabled(string eventName)
    {
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        val_21 = 1;
        if((UnityEngine.PlayerPrefs.HasKey(key:  1657992336)) == false)
        {
                return (bool)val_21;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  1657992336);
        object val_3 = MiniJSON.Json.Deserialize(json:  1657992336);
        if("facebook" != 0)
        {
                if(null == null)
        {
            goto label_23;
        }
        
        }
        
        label_23:
        string val_4 = 0.Item[-1987367680];
        val_22 = 0;
        val_21 = 0;
        if((System.Boolean.Parse(value:  null)) == false)
        {
                return (bool)val_21;
        }
        
        val_23 = 1;
        if((0.ContainsKey(key:  -1987367584)) != false)
        {
                string val_7 = 0.Item[-1987367584];
            val_23 = System.Boolean.Parse(value:  null);
        }
        
        string val_9 = eventName.ToLower();
        val_22 = eventName;
        if(val_23 != false)
        {
                return val_22.Contains(value:  -1987367488);
        }
        
        if((val_22.Contains(value:  -1987367408)) == false)
        {
            goto label_18;
        }
        
        label_37:
        val_21 = 1;
        label_42:
        if((0.ContainsKey(key:  -1987367328)) == false)
        {
                return (bool)val_21;
        }
        
        val_24 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        val_25 = "spins";
        goto label_22;
        label_18:
        string val_12 = eventName.ToLower();
        val_22 = "freecredits";
        if((eventName.Contains(value:  -1987367248)) == false)
        {
            goto label_26;
        }
        
        val_21 = 1;
        if((0.ContainsKey(key:  -1987367248)) == false)
        {
                return (bool)val_21;
        }
        
        val_24 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        val_25 = "freecredits";
        label_22:
        string val_15 = 0.Item[-1987367248];
        return System.Boolean.Parse(value:  null);
        label_26:
        string val_16 = eventName.ToLower();
        if((eventName.Contains(value:  -1987367152)) == false)
        {
            goto label_35;
        }
        
        if(1 == 0)
        {
            goto label_37;
        }
        
        goto label_37;
        label_35:
        string val_18 = eventName.ToLower();
        val_21 = 1;
        if((eventName.Contains(value:  -1987366976)) == false)
        {
                return (bool)val_21;
        }
        
        bool val_20 = 0.ContainsKey(key:  -1987366896);
        goto label_42;
    }
    private string getEventName(string eventName)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_7 = null;
        val_7 = null;
        string val_1 = -1987246624(-1987246624) + Events.APP_LAUNCHED;
        if((System.String.op_Equality(a:  eventName, b:  -1987246624)) != false)
        {
                val_8 = "fb_mobile_activate_app";
            return;
        }
        
        val_9 = null;
        val_9 = null;
        if((System.String.op_Equality(a:  eventName, b:  Events.CURRENT_LEVEL)) != false)
        {
                val_8 = "fb_mobile_level_achieved";
            return;
        }
        
        val_10 = null;
        val_10 = null;
        if((System.String.op_Equality(a:  eventName, b:  Events.PURCHASE_INTENT)) != false)
        {
                val_8 = "fb_mobile_initiated_checkout";
            return;
        }
        
        val_11 = null;
        val_11 = null;
        if((System.String.op_Equality(a:  eventName, b:  Events.BUY_BUTTON)) != false)
        {
                val_8 = "fb_mobile_custom_buy_button";
            return;
        }
        
        val_12 = null;
        val_12 = null;
        if((System.String.op_Equality(a:  eventName, b:  Events.GAME_INITIATED_FTUX)) == false)
        {
                "fb_mobile_custom_game_initiated_ftux" = eventName;
        }
    
    }
    public override void trackCharge(string amount, System.Collections.Generic.Dictionary<string, object> options)
    {
        var val_9;
        var val_10;
        if(Facebook.Unity.FB.IsInitialized == false)
        {
                return;
        }
        
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15282176)});
        object val_3 = System.Convert.ChangeType(value:  amount, conversionType:  15282176);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        amount.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if((options.ContainsKey(key:  -1987121728)) != false)
        {
                object val_6 = options.Item[-1987121728];
            val_9 = 1152921504846835712;
            if(options != 0)
        {
                val_10 = null;
        }
        
            val_10 = null;
            if(0 == val_10)
        {
                16 = options + 16;
        }
        
            Add(key:  -1987121632, value:  78753792);
        }
        else
        {
                amount.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_9 = 1152921504846835712;
        }
        
        Facebook.Unity.FB.LogPurchase(logPurchase:  null, currency:  15388672, parameters:  1597871760);
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
