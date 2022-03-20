using UnityEngine;
public class GameOfTheDay : MonoSingleton<GameOfTheDay>
{
    // Fields
    private static string current_promo_key;
    private static string INSTALLED;
    private static string NON_INSTALLED;
    private System.Collections.Generic.Dictionary<string, object> currentPromoData;
    private string <promoPackageName>k__BackingField;
    private string <promoName>k__BackingField;
    private string <promoIconImageUrl>k__BackingField;
    private decimal <installedReward>k__BackingField;
    public static string currentStatus;
    private bool _isAvailable;
    
    // Properties
    public string promoPackageName { get; set; }
    public string promoName { get; set; }
    public string promoIconImageUrl { get; set; }
    public decimal installedReward { get; set; }
    private bool canShow { get; }
    public bool isAvailable { get; }
    public bool isAvailableAndMustShow { get; }
    
    // Methods
    public string get_promoPackageName()
    {
    
    }
    protected void set_promoPackageName(string value)
    {
        this.<promoPackageName>k__BackingField = value;
    }
    public string get_promoName()
    {
    
    }
    protected void set_promoName(string value)
    {
        this.<promoName>k__BackingField = value;
    }
    public string get_promoIconImageUrl()
    {
    
    }
    protected void set_promoIconImageUrl(string value)
    {
        this.<promoIconImageUrl>k__BackingField = value;
    }
    public decimal get_installedReward()
    {
        return new System.Decimal() {flags = -271414464, hi = R1 + 28};
    }
    protected void set_installedReward(decimal value)
    {
    
    }
    private bool get_canShow()
    {
        var val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        Player val_4 = App.Player;
        System.DateTime val_6 = AddHours(value:  null);
        if((val_2.CompareTo(value:  new System.DateTime() {dateData = 2621448 + 208})) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool get_isAvailable()
    {
        return (bool)this._isAvailable;
    }
    public bool get_isAvailableAndMustShow()
    {
        var val_2;
        var val_3;
        if(this.canShow == false)
        {
                return false;
        }
        
        var val_2 = 29184372;
        val_2 = 6442200 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(twelvegigs.plugins.InstalledAppsPlugin.fetched == false)
        {
                return false;
        }
        
        var val_3 = 29184249;
        val_3 = 6442324 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        this.CheckAvailableAndPrepare(networkPromos:  twelvegigs.plugins.InstalledAppsPlugin.<NetworkPromos>k__BackingField);
        return (bool)this._isAvailable;
    }
    public override void InitMonoSingleton()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -270853440, method:  new IntPtr(4024088832));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
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
    private void OnDestroy()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -270741440, method:  new IntPtr(4024088832));
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
    private void OnSceneLoaded(SceneType sceneType)
    {
    
    }
    public void JustShown()
    {
        Player val_1 = App.Player;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        Player val_3 = App.Player;
        2621448.Save(writePrefs:  true);
    }
    public void CheckAvailableAndPrepare(System.Collections.Generic.List<object> networkPromos)
    {
        var val_5;
        System.Collections.Generic.List<System.Object> val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_34;
        System.DateTime val_35;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_36;
        var val_37;
        var val_38;
        this._isAvailable = false;
        GameBehavior val_1 = App.getBehavior;
        val_26 = 0;
        val_27 = 1152921504895397888;
        val_28 = null;
        val_28 = null;
        if(val_26 < AdsManager.ADS_WATCHED_COOLDOWN_PREF)
        {
                return;
        }
        
        val_26 = 1152921505065738240;
        val_27 = 6442748 + 29183825;
        if(val_27 == 0)
        {
                mem2[0] = 1;
        }
        
        val_29 = null;
        val_29 = null;
        if((twelvegigs.plugins.InstalledAppsPlugin.<NetworkPromos>k__BackingField) == 0)
        {
                return;
        }
        
        if(val_27 == 0)
        {
                mem2[0] = 1;
        }
        
        val_30 = null;
        val_30 = null;
        val_26 = twelvegigs.plugins.InstalledAppsPlugin.<NetworkPromos>k__BackingField;
        if((twelvegigs.plugins.InstalledAppsPlugin.<NetworkPromos>k__BackingField + 12) == 0)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        if((System.String.op_Equality(a:  GameOfTheDay.currentStatus, b:  -270417152)) == true)
        {
                return;
        }
        
        val_32 = null;
        val_32 = null;
        if((System.String.op_Equality(a:  GameOfTheDay.currentStatus, b:  -270417056)) == true)
        {
                return;
        }
        
        this.CheckPromoAndFlag();
        System.DateTime val_4 = DateTimeCheat.UtcNow;
        Player val_7 = App.Player;
        val_26 = 2621448;
        if((val_5.CompareTo(value:  new System.DateTime() {dateData = App.__il2cppRuntimeField_cctor_finished})) < 0)
        {
                return;
        }
        
        Player val_9 = App.Player;
        val_26 = 2621448;
        val_34 = null;
        val_34 = null;
        val_35 = System.DateTime.MinValue;
        val_36 = this;
        object val_10 = this.TryPickAPromo(networkPromos:  networkPromos);
        if(val_36 == 0)
        {
            goto label_40;
        }
        
        val_36 = 0;
        this.currentPromoData = val_36;
        this.PersistCurrentPromo(networkPromoData:  0);
        twelvegigs.storage.JsonDictionary val_11 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  this.currentPromoData);
        val_27 = "";
        string val_12 = getString(key:  -1830072288, defaultValue:  1098586544);
        string val_13 = Trim();
        this.<promoPackageName>k__BackingField = val_11;
        if(val_11 == 0)
        {
            goto label_45;
        }
        
        string val_14 = getString(key:  1679334848, defaultValue:  1098586544);
        this.<promoName>k__BackingField = val_11;
        goto label_46;
        label_40:
        UnityEngine.Debug.Log(message:  -270412848);
        return;
        label_45:
        string val_15 = getString(key:  1679334848, defaultValue:  1098586544);
        this.<promoName>k__BackingField = val_11;
        label_46:
        string val_16 = getString(key:  -270412704, defaultValue:  1098586544);
        this.<promoIconImageUrl>k__BackingField = val_11;
        Player val_17 = App.Player;
        System.Collections.Generic.Dictionary<System.String, System.String> val_18 = 0.PromotedGames;
        if((0.ContainsKey(key:  this.<promoPackageName>k__BackingField)) != false)
        {
                Player val_21 = App.Player;
            System.Collections.Generic.Dictionary<System.String, System.String> val_22 = 0.PromotedGames;
            val_37 = null;
            val_35 = this.<promoPackageName>k__BackingField;
            val_37 = null;
            val_26 = GameOfTheDay.NON_INSTALLED;
            0.set_Item(key:  val_35, value:  val_26);
        }
        else
        {
                Player val_23 = App.Player;
            System.Collections.Generic.Dictionary<System.String, System.String> val_24 = 0.PromotedGames;
            val_38 = null;
            val_35 = this.<promoPackageName>k__BackingField;
            val_38 = null;
            val_26 = GameOfTheDay.NON_INSTALLED;
            0.Add(key:  val_35, value:  val_26);
        }
        
        this._isAvailable = true;
        Player val_25 = App.Player;
        0.SaveState();
    }
    private System.Collections.Generic.Dictionary<string, object> LoadCurrentPromo()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        val_5 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  GameOfTheDay.current_promo_key)) == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = 0;
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  GameOfTheDay.current_promo_key);
        object val_3 = MiniJSON.Json.Deserialize(json:  GameOfTheDay.current_promo_key);
        if(GameOfTheDay.current_promo_key == null)
        {
                return;
        }
    
    }
    private void PersistCurrentPromo(System.Collections.Generic.Dictionary<string, object> networkPromoData)
    {
        null = null;
        string val_1 = MiniJSON.Json.Serialize(obj:  networkPromoData);
        UnityEngine.PlayerPrefs.SetString(key:  GameOfTheDay.current_promo_key, value:  networkPromoData);
    }
    private void ClearCurrentPromo()
    {
        this.currentPromoData.PersistCurrentPromo(networkPromoData:  0);
        Player val_1 = App.Player;
        0.SaveState();
    }
    private void CheckPromoAndFlag()
    {
        string val_36;
        var val_37;
        var val_38;
        string val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        if(this.currentPromoData == 0)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = this.currentPromoData.LoadCurrentPromo();
            this.currentPromoData = this.currentPromoData;
            if(this.currentPromoData == 0)
        {
                return;
        }
        
        }
        
        object val_2 = this.currentPromoData.Item[-1830072288];
        if(this.currentPromoData == 0)
        {
            goto label_3;
        }
        
        val_36 = this.currentPromoData;
        if(null == null)
        {
            goto label_4;
        }
        
        label_3:
        val_36 = 0;
        val_37 = this;
        this.<promoPackageName>k__BackingField = val_36;
        goto label_5;
        label_4:
        val_37 = this;
        this.<promoPackageName>k__BackingField = val_36;
        label_5:
        string val_3 = val_36.Trim();
        mem[1152921512926886512] = val_36;
        if(val_36 == 0)
        {
                return;
        }
        
        bool val_36 = twelvegigs.plugins.InstalledAppsPlugin.IsInstalled(packageToCheck:  val_36);
        val_38 = null;
        val_38 = null;
        Player val_5 = App.Player;
        System.Collections.Generic.Dictionary<System.String, System.String> val_6 = 0.PromotedGames;
        val_39 = public System.Boolean System.Collections.Generic.Dictionary<System.String, System.String>::TryGetValue(System.String key, out System.String value);
        bool val_8 = 0.TryGetValue(key:  mem[1152921512926886512], value: out  UnityEngine.Material val_7 = -269907112);
        if(0 != 0)
        {
            goto label_15;
        }
        
        CompanyDevices val_10 = CompanyDevices.Instance;
        if(0 != 0)
        {
            goto label_19;
        }
        
        val_39 = GameOfTheDay.NON_INSTALLED;
        val_40 = "Last promoted game ";
        string val_12 = -269919488(-269919488) + mem[1152921512926886512] + -269919568(-269919568) + val_39;
        goto label_20;
        label_15:
        CompanyDevices val_13 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
            goto label_24;
        }
        
        val_39 = 0;
        val_40 = "Cannot load installation status of package ";
        string val_15 = -269919232(-269919232) + mem[1152921512926886512] + -269919376(-269919376);
        label_20:
        UnityEngine.Debug.Log(message:  -269919232);
        goto label_28;
        label_19:
        val_36 = val_36 & 0.CompanyDevice();
        goto label_28;
        label_24:
        val_36 = val_36 & mem[1152921512926886512];
        label_28:
        if(val_36 == true)
        {
            goto label_29;
        }
        
        label_63:
        val_41 = null;
        val_41 = null;
        val_42 = null;
        if((System.String.op_Equality(a:  GameOfTheDay.NON_INSTALLED, b:  GameOfTheDay.INSTALLED)) == false)
        {
            goto label_32;
        }
        
        goto label_71;
        label_32:
        Player val_18 = App.Player;
        val_43 = 2621448;
        if(val_43 == 0)
        {
            goto label_38;
        }
        
        val_44 = static_value_002800E0;
        goto label_39;
        label_29:
        val_45 = null;
        val_45 = null;
        if((System.String.op_Inequality(a:  GameOfTheDay.NON_INSTALLED, b:  GameOfTheDay.INSTALLED)) == false)
        {
            goto label_63;
        }
        
        Player val_20 = App.Player;
        System.Collections.Generic.Dictionary<System.String, System.String> val_21 = 0.PromotedGames;
        val_46 = null;
        val_46 = null;
        0.set_Item(key:  mem[1152921512926886512], value:  GameOfTheDay.INSTALLED);
        goto label_63;
        label_38:
        val_43 = 216;
        val_44 = 0;
        label_39:
        mem[216] = 1;
        Player val_22 = App.Player;
        CompanyDevices val_23 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                Player val_26 = App.Player;
            val_47 = 2621448;
            val_48 = 0;
            System.DateTime val_27 = DateTimeCheat.UtcNow;
        }
        else
        {
                Player val_28 = App.Player;
            val_47 = 2621448;
            val_48 = 0;
            System.DateTime val_29 = ServerHandler.ServerTime;
        }
        
        System.DateTime val_32 = AddDays(value:  null);
        val_42 = null;
        label_71:
        Player val_35 = App.Player;
        this.ClearCurrentPromo();
    }
    private object TryPickAPromo(System.Collections.Generic.List<object> networkPromos)
    {
        var val_7;
        var val_8;
        if(true == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = 0;
        if((0.ContainsKey(key:  -269798880)) != false)
        {
                string val_2 = 0.Item[-269798880];
            0.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(127 != 0)
        {
                val_7 = 1;
        }
        
        }
        
        AppConfigs val_3 = App.Configuration;
        val_8 = 0;
        string val_4 = 0.Key(key:  -269798800);
        if(1 != 0)
        {
                val_8 = 0;
            object val_5 = this.TryPickAPromo_Manual(networkPromos:  networkPromos, head:  0, currentGamePackage:  null);
            if(0 != 0)
        {
                return;
        }
        
        }
        
        object val_6 = this.TryPickAPromo_Dynamic(networkPromos:  networkPromos, head:  0, currentGamePackage:  null);
    }
    private object TryPickAPromo_Manual(System.Collections.Generic.List<object> networkPromos, System.Collections.Generic.Dictionary<string, object> head, string currentGamePackage)
    {
        string val_15;
        var val_16;
        string val_17;
        var val_18;
        val_15 = currentGamePackage;
        object val_1 = head.Item[-1830072288];
        val_16 = 0;
        val_17 = 0;
        if(head != 0)
        {
                if(null != null)
        {
                val_17 = 0;
        }
        else
        {
                val_17 = head;
        }
        
        }
        
        if((System.String.op_Equality(a:  val_17, b:  val_15)) == true)
        {
                return;
        }
        
        val_16 = 0;
        if((twelvegigs.plugins.InstalledAppsPlugin.IsInstalled(packageToCheck:  val_17)) == true)
        {
                return;
        }
        
        val_15 = 1152921504892043264;
        Player val_4 = App.Player;
        System.Collections.Generic.Dictionary<System.String, System.String> val_5 = 0.PromotedGames;
        if(0 != 0)
        {
                Player val_6 = App.Player;
            System.Collections.Generic.Dictionary<System.String, System.String> val_7 = 0.PromotedGames;
            if((0.ContainsKey(key:  val_17)) != false)
        {
                Player val_9 = App.Player;
            System.Collections.Generic.Dictionary<System.String, System.String> val_10 = 0.PromotedGames;
            string val_11 = 0.Item[val_17];
            val_18 = null;
            val_18 = null;
            val_16 = 0;
            bool val_12 = System.String.op_Equality(a:  null, b:  GameOfTheDay.INSTALLED);
            if(val_12 == true)
        {
                return;
        }
        
        }
        
            if(val_12 != true)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_16 = 2621443;
            return;
        }
        
        val_16 = 0;
        CompanyDevices val_13 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        val_16 = 0;
        UnityEngine.Debug.LogError(message:  -269670320);
    }
    private object TryPickAPromo_Dynamic(System.Collections.Generic.List<object> networkPromos, System.Collections.Generic.Dictionary<string, object> head, string currentGamePackage)
    {
        twelvegigs.sweepstakes.Distribution val_4;
        var val_18;
        var val_19;
        var val_20;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_34:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 != 0)
        {
                val_18 = val_4;
            val_18 = 0;
        }
        else
        {
                val_18 = 0;
        }
        
        string val_5 = val_18.Item[-1830072288];
        val_19 = 0;
        if(val_18 != 0)
        {
                if(1179403647 != null)
        {
            
        }
        else
        {
                val_19 = val_18;
        }
        
        }
        
        if(((System.String.op_Equality(a:  null, b:  currentGamePackage)) == true) || ((twelvegigs.plugins.InstalledAppsPlugin.IsInstalled(packageToCheck:  null)) == true))
        {
            goto label_34;
        }
        
        Player val_8 = App.Player;
        System.Collections.Generic.Dictionary<System.String, System.String> val_9 = 0.PromotedGames;
        if(0 == 0)
        {
            goto label_34;
        }
        
        Player val_10 = App.Player;
        System.Collections.Generic.Dictionary<System.String, System.String> val_11 = 0.PromotedGames;
        if((0.ContainsKey(key:  0)) == false)
        {
            goto label_25;
        }
        
        Player val_13 = App.Player;
        System.Collections.Generic.Dictionary<System.String, System.String> val_14 = 0.PromotedGames;
        string val_15 = 0.Item[null];
        val_20 = null;
        val_20 = null;
        if((System.String.op_Equality(a:  null, b:  GameOfTheDay.INSTALLED)) == true)
        {
            goto label_34;
        }
        
        label_25:
        Add(item:  val_4);
        goto label_34;
        label_2:
        Dispose();
        int val_17 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
    }
    public GameOfTheDay()
    {
    
    }
    private static GameOfTheDay()
    {
        GameOfTheDay.current_promo_key = "current_game_of_the_day";
        GameOfTheDay.INSTALLED = "INSTALLED";
        GameOfTheDay.NON_INSTALLED = "NON_INSTALLED";
        GameOfTheDay.currentStatus = "";
    }

}
