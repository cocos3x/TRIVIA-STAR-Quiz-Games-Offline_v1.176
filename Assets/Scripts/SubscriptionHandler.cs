using UnityEngine;
public class SubscriptionHandler : DefaultHandler<SubscriptionHandler>
{
    // Fields
    private const string CURRENT_SUBSCRIPTIONS_KEY = "current_subscriptions";
    private PurchaseModel currentPurchase;
    private NativePurchase currentNativePurchase;
    private SubscriptionModel currentGoldenSub;
    private SubscriptionModel currentSilverSub;
    private System.DateTime lastUpdated;
    private bool subscriptionUpdated;
    private bool econUpdated;
    private bool pendingSubscription;
    private FrameSkipper frameSkipper;
    public System.Action<System.Collections.Generic.Dictionary<string, object>> onSubscriptionCollectAttempt;
    public System.Action<bool> onSubscriptionPurchaseComplete;
    public System.Action<bool> onSubscriptionTrialClaimComplete;
    private int _dailyCoinAmount;
    private int _dailyCoinAmountSilver;
    private int _dailyGemAmount;
    private int _silverTicketUnlockLevel;
    private float _pointMultiplier;
    private int _freeTrialDaysGolden;
    private int _freeTrialDaysSilver;
    private static System.DateTime lastServerCall;
    private static int secondsUntilNextRequest;
    private static bool initialized;
    
    // Properties
    private System.Collections.Generic.List<SubscriptionModel> eitherSubscription { get; }
    public int getDailyCoinAmount { get; }
    public int getDailyCoinAmountSilver { get; }
    public int getDailyGemAmount { get; }
    public int getSilverTicketUnlockLevel { get; }
    public float getPointMultiplier { get; }
    public bool freeTrialEnabledGolden { get; }
    public bool freeTrialEnabledSilver { get; }
    public int freeTrialDaysGolden { get; }
    public int freeTrialDaysSilver { get; }
    
    // Methods
    private System.Collections.Generic.List<SubscriptionModel> get_eitherSubscription()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(this.currentGoldenSub != 0)
        {
                Add(item:  this.currentGoldenSub);
        }
        
        if(this.currentSilverSub == 0)
        {
                return;
        }
        
        Add(item:  this.currentSilverSub);
    }
    public int get_getDailyCoinAmount()
    {
        return (int)this._dailyCoinAmount;
    }
    public int get_getDailyCoinAmountSilver()
    {
        return (int)this._dailyCoinAmountSilver;
    }
    public int get_getDailyGemAmount()
    {
        return (int)this._dailyGemAmount;
    }
    public int get_getSilverTicketUnlockLevel()
    {
        return (int)this._silverTicketUnlockLevel;
    }
    public float get_getPointMultiplier()
    {
        return (float)S0;
    }
    public bool get_freeTrialEnabledGolden()
    {
        if(this._freeTrialDaysGolden > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool get_freeTrialEnabledSilver()
    {
        if(this._freeTrialDaysSilver > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public int get_freeTrialDaysGolden()
    {
        return (int)this._freeTrialDaysGolden;
    }
    public int get_freeTrialDaysSilver()
    {
        return (int)this._freeTrialDaysSilver;
    }
    private SubscriptionModel GetSubByPackage(SubscriptionHandler.SubScriptionType subPackage)
    {
        SubscriptionModel val_1;
        if(subPackage != 1)
        {
                if(subPackage == 0)
        {
                val_1 = this.currentGoldenSub;
        }
        
            return;
        }
        
        val_1 = this.currentSilverSub;
    }
    public bool IsActive(SubscriptionHandler.SubScriptionType subPackage = 0)
    {
        SubscriptionModel val_1;
        if(subPackage != 1)
        {
                if(subPackage != 0)
        {
                return false;
        }
        
            val_1 = this.currentGoldenSub;
        }
        else
        {
                val_1 = this.currentSilverSub;
        }
        
        if(mem[this.currentSilverSub] == 0)
        {
                return false;
        }
        
        return mem[this.currentSilverSub].IsActive;
    }
    public bool CanCollect(SubscriptionHandler.SubScriptionType subPackage = 0)
    {
        SubscriptionModel val_1;
        if(subPackage != 1)
        {
                if(subPackage != 0)
        {
                return false;
        }
        
            val_1 = this.currentGoldenSub;
        }
        else
        {
                val_1 = this.currentSilverSub;
        }
        
        if(mem[this.currentSilverSub] == 0)
        {
                return false;
        }
        
        return mem[this.currentSilverSub].CanCollect;
    }
    public SubscriptionModel getCurrentModel(SubscriptionHandler.SubScriptionType subPackage = 0)
    {
        SubscriptionModel val_1;
        if(subPackage != 1)
        {
                if(subPackage == 0)
        {
                val_1 = this.currentGoldenSub;
        }
        
            return;
        }
        
        val_1 = this.currentSilverSub;
    }
    public void ProcessPurchase(NativePurchase subscriptionNativePurchase)
    {
        var val_9;
        var val_19;
        InAppPurchasesManager val_20;
        InAppPurchasesManager val_21;
        var val_22;
        var val_23;
        object val_1 = new System.Object();
        typeof(SubscriptionHandler.<>c__DisplayClass45_0).__il2cppRuntimeField_8 = subscriptionNativePurchase;
        typeof(System.Object[]).__il2cppRuntimeField_10 = subscriptionNativePurchase + 24;
        typeof(System.Object[]).__il2cppRuntimeField_14 = subscriptionNativePurchase + 12;
        val_19 = 1152921504758390784;
        UnityEngine.Debug.LogFormat(format:  -1813772304, args:  472754880);
        System.Collections.Generic.List<SubscriptionModel> val_2 = this.eitherSubscription;
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  291852288, method:  new IntPtr(2481195152));
        if((this.Exists(match:  8040448)) != false)
        {
                System.Collections.Generic.List<SubscriptionModel> val_5 = this.eitherSubscription;
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_6 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  291852288, method:  new IntPtr(2481198224));
            object val_7 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -1813717056, predicate:  7720960);
            val_20 = 0;
            System.DateTime val_8 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1813729112, hi = mem[this.subscriptionUpdated + (0)], lo = mem[this.subscriptionUpdated + (4)], mid = mem[this.subscriptionUpdated + (8)]});
            string val_11 = val_9.ToString();
            val_21;
            string val_13 = this.IsActive.ToString();
            string val_14 = -1813761904(-1813761904) + -1813729096(-1813729096) + -1813761760(-1813761760) + -1813729097(-1813729097);
            UnityEngine.Debug.Log(message:  -1813761904);
            if(this.onSubscriptionPurchaseComplete == 0)
        {
                return;
        }
        
            this.onSubscriptionPurchaseComplete.Invoke(obj:  false);
            return;
        }
        
        val_19 = 1152921504892043264;
        AppConfigs val_15 = App.Configuration;
        ProductDetails val_16 = 0.GetProductBySku(sku:  subscriptionNativePurchase + 16);
        if(0 != 0)
        {
                0 = 0;
        }
        
        if(0 == 0)
        {
                val_21 = 0;
        }
        
        val_22 = null;
        val_22 = null;
        val_20 = App.inAppPurchasesManager;
        this.currentPurchase = App.inAppPurchasesManager.currentPurchase;
        if(App.inAppPurchasesManager.currentPurchase != 0)
        {
                typeof(PurchaseModel).__il2cppRuntimeField_C = val_21;
            val_20 = this.currentPurchase.PrePurchaseUserInfo;
            Player val_17 = App.Player;
            this.currentPurchase.PrePurchaseUserInfo.total_purchase = 2.634441E-43f;
            bool val_18 = this.currentPurchase.id.Equals(value:  -1813741184);
            val_23 = null;
            val_23 = null;
            val_21 = App.inAppPurchasesManager;
            val_21.ClearPurchaseFromPrefs();
        }
        
        this.currentNativePurchase = typeof(SubscriptionHandler.<>c__DisplayClass45_0).__il2cppRuntimeField_8;
        this.ValidatePurchasedSubscription(nativePurchase:  typeof(SubscriptionHandler.<>c__DisplayClass45_0).__il2cppRuntimeField_8);
    }
    public void PurchaseFailed(NativePurchase nativePurchase)
    {
        if(this.onSubscriptionPurchaseComplete == 0)
        {
                return;
        }
        
        this.onSubscriptionPurchaseComplete.Invoke(obj:  false);
    }
    public void ValidatePurchasedSubscription(NativePurchase nativePurchase)
    {
        var val_13;
        var val_14;
        twelvegigs.net.JsonApiRequester val_15;
        var val_16;
        val_13 = nativePurchase;
        object val_1 = new System.Object();
        typeof(SubscriptionHandler.<>c__DisplayClass47_0).__il2cppRuntimeField_8 = this;
        var val_13 = 29436066;
        val_13 = 6189992 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = App.networkManager;
        if(val_15.Reachable() == false)
        {
            goto label_8;
        }
        
        Player val_3 = App.Player;
        val_15 = 0;
        if((System.String.IsNullOrEmpty(value:  1835037)) == false)
        {
            goto label_12;
        }
        
        CompanyDevices val_5 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.Debug.LogError(message:  -1813467904);
        }
        
        if(this.onSubscriptionPurchaseComplete != 0)
        {
                this.onSubscriptionPurchaseComplete.Invoke(obj:  false);
        }
        
        this.pendingSubscription = true;
        return;
        label_8:
        CompanyDevices val_7 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.Debug.LogError(message:  -1813463664);
        }
        
        if(this.onSubscriptionPurchaseComplete == 0)
        {
                return;
        }
        
        this.onSubscriptionPurchaseComplete.Invoke(obj:  false);
        return;
        label_12:
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_9 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        typeof(SubscriptionHandler.<>c__DisplayClass47_0).__il2cppRuntimeField_C = null;
        Player val_10 = App.Player;
        Add(key:  1618311216, value:  1835037);
        Add(key:  -1820667264, value:  nativePurchase.sku);
        val_13.AddStoreSpecificDataForValidation(postParams: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_11 = 291905548);
        val_13 = "/api/subscriptions";
        val_16 = null;
        val_16 = null;
        val_15 = typeof(SubscriptionHandler.<>c__DisplayClass47_0).__il2cppRuntimeField_C;
        System.Action<System.Threading.Tasks.Task, System.Object> val_12 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  291905536, method:  new IntPtr(2481512096));
        App.networkManager.DoPost(path:  -1813455312, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    public void UpdateOnSceneChanged()
    {
        var val_7;
        var val_8;
        System.Predicate<SubscriptionModel> val_10;
        val_7 = null;
        val_7 = null;
        if(SubscriptionHandler.initialized == false)
        {
                return;
        }
        
        System.Collections.Generic.List<SubscriptionModel> val_1 = this.eitherSubscription;
        val_8 = null;
        val_8 = null;
        val_10 = SubscriptionHandler.<>c.<>9__48_0;
        if(val_10 == 0)
        {
                val_10 = null;
            val_10 = new System.Predicate<ZooTile>(object:  SubscriptionHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2481641504));
            SubscriptionHandler.<>c.<>9__48_0 = val_10;
        }
        
        if((this.Exists(match:  8040448)) == false)
        {
                return;
        }
        
        Player val_4 = App.Player;
        if(23 == 0)
        {
                Player val_5 = App.Player;
            if(35143992 == 0)
        {
                return;
        }
        
        }
        
        System.DateTime val_6 = ServerHandler.ServerTime;
        this.lastUpdated = new System.DateTime();
        this.GetSubscription();
    }
    private System.Collections.IEnumerator RetryValidation(System.Collections.Generic.Dictionary<string, object> purchaseData)
    {
        typeof(SubscriptionHandler.<RetryValidation>d__49).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(SubscriptionHandler.<RetryValidation>d__49).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(SubscriptionHandler.<RetryValidation>d__49).__il2cppRuntimeField_14 = purchaseData;
    }
    private string SubscriptionsPostPath()
    {
    
    }
    private void OnPurchaseValidated(System.Collections.Generic.Dictionary<string, object> purchaseData, System.Collections.Generic.Dictionary<string, object> response)
    {
        System.DateTime val_3;
        System.Collections.IDictionary val_49;
        SubscriptionModel val_50;
        TrackerManager val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        int val_62;
        float val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        val_49 = response;
        System.DateTime val_1 = ServerHandler.ServerTime;
        this.lastUpdated = val_3;
        if((val_49 == 0) || ((val_49.ContainsKey(key:  -1820146016)) == false))
        {
            goto label_4;
        }
        
        this.subscriptionUpdated = true;
        this.pendingSubscription = false;
        twelvegigs.storage.JsonDictionary val_5 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  val_49);
        if((getBool(key:  -1820146016)) == false)
        {
            goto label_6;
        }
        
        SubscriptionModel val_7 = null;
        val_50 = val_7;
        val_7 = new SubscriptionModel();
        twelvegigs.storage.JsonDictionary val_8 = getJsonDictionary(key:  -1812972384);
        if(val_50 == 0)
        {
            goto label_8;
        }
        
        ParseJsonDic(jsonDic:  458731520);
        goto label_9;
        label_4:
        CompanyDevices val_9 = CompanyDevices.Instance;
        val_51 = 0;
        if(val_51.CompanyDevice() != false)
        {
                UnityEngine.Debug.LogError(message:  -1812972288);
        }
        
        if(this.onSubscriptionPurchaseComplete != 0)
        {
                this.onSubscriptionPurchaseComplete.Invoke(obj:  false);
        }
        
        System.Collections.IEnumerator val_11 = this.RetryValidation(purchaseData:  purchaseData);
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  -1812914832);
        return;
        label_6:
        var val_51 = 29432163;
        val_51 = 6193896 + val_51;
        if(val_51 == 0)
        {
                mem2[0] = 1;
        }
        
        val_52 = null;
        val_52 = null;
        GooglePurchasesBridge.trustUser = false;
        val_51 = 1152921504758390784;
        UnityEngine.Debug.LogError(message:  -1812968048);
        val_53 = null;
        val_53 = null;
        PluginObserverManager.isPurchaseValidationWorking = false;
        Player val_13 = App.Player;
        Player val_14 = App.Player;
        0.SaveState();
        CompanyDevices val_15 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.Debug.LogError(message:  -1812967888);
        }
        
        if(this.onSubscriptionPurchaseComplete == 0)
        {
                return;
        }
        
        val_54 = public System.Void System.Action<System.Boolean>::Invoke(System.Boolean obj);
        val_55 = 0;
        goto label_39;
        label_8:
        ParseJsonDic(jsonDic:  458731520);
        label_9:
        AppConfigs val_17 = App.Configuration;
        if((Equals(value:  null)) == false)
        {
            goto label_46;
        }
        
        if(this.currentGoldenSub == 0)
        {
            goto label_47;
        }
        
        twelvegigs.storage.JsonDictionary val_19 = getJsonDictionary(key:  -1812972384);
        this.currentGoldenSub.ParseJsonDic(jsonDic:  458731520);
        goto label_49;
        label_46:
        AppConfigs val_20 = App.Configuration;
        if((Equals(value:  null)) == false)
        {
            goto label_56;
        }
        
        if(this.currentSilverSub == 0)
        {
            goto label_57;
        }
        
        twelvegigs.storage.JsonDictionary val_22 = getJsonDictionary(key:  -1812972384);
        this.currentSilverSub.ParseJsonDic(jsonDic:  458731520);
        goto label_59;
        label_47:
        this.currentGoldenSub = val_50;
        label_49:
        Player val_23 = App.Player;
        Player val_25 = App.Player;
        val_56 = 2621448;
        if(val_56 == 0)
        {
            goto label_68;
        }
        
        val_57 = 35143988;
        goto label_74;
        label_68:
        val_56 = 316;
        goto label_75;
        label_57:
        this.currentSilverSub = val_50;
        label_59:
        Player val_27 = App.Player;
        Player val_29 = App.Player;
        val_58 = 2621448;
        if(val_58 == 0)
        {
            goto label_84;
        }
        
        val_59 = 23;
        goto label_90;
        label_75:
        label_74:
        mem[312] =  + 1;
        WordPets.WPTDataParser val_32 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_60 = public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance();
        WordPets.WPTDataParser val_33 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_49 = public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance();
        val_61 = 0;
        System.DateTime val_34 = AdsWatchedCooldownEnd;
        val_62 = this._freeTrialDaysGolden;
        goto label_94;
        label_84:
        val_58 = 328;
        label_90:
        mem[324] =  + 1;
        WordPets.WPTDataParser val_36 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_60 = public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance();
        WordPets.WPTDataParser val_37 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_49 = public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance();
        val_61 = 0;
        System.DateTime val_38 = AdsWatchedCooldownEnd;
        val_62 = this._freeTrialDaysSilver;
        label_94:
        System.DateTime val_39 = AddDays(value:  null);
        AdsWatchedCooldownEnd = new System.DateTime() {dateData = 1152921511383854688};
        label_56:
        val_51 = this;
        val_63 = 1152921504892043264;
        var val_52 = 29430027;
        val_52 = 6195760 + val_52;
        if(val_52 == 0)
        {
                mem2[0] = 1;
        }
        
        val_64 = null;
        val_64 = null;
        if(App.game == 17)
        {
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_42 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            var val_53 = 29430112;
            val_53 = 6195948 + val_53;
            if(val_53 == 0)
        {
                mem2[0] = 1;
        }
        
            val_65 = null;
            val_65 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            Add(key:  -1812951360, value:  292438016);
            var val_54 = 29429330;
            val_54 = 6196208 + val_54;
            if(val_54 == 0)
        {
                mem2[0] = 1;
        }
        
            val_66 = null;
            val_66 = null;
            val_67 = null;
            val_51 = App.trackerManager;
            val_67 = null;
            val_49 = Events.SUBSCRIPTION_TRIAL_START;
            val_51.track(eventName:  val_49, data:  78753792);
        }
        
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  19);
        Player val_50 = App.Player;
        0.RemovedAds = true;
        this.SaveSubscription();
        if(this.onSubscriptionPurchaseComplete == 0)
        {
                return;
        }
        
        val_54 = public System.Void System.Action<System.Boolean>::Invoke(System.Boolean obj);
        val_55 = 1;
        label_39:
        this.onSubscriptionPurchaseComplete.Invoke(obj:  true);
    }
    private void SaveSubscription()
    {
        if(this.currentGoldenSub != 0)
        {
                string val_1 = this.currentGoldenSub.Serialize(format:  0);
            UnityEngine.PlayerPrefs.SetString(key:  -1812780752, value:  this.currentGoldenSub);
        }
        else
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1812780752);
        }
        
        if(this.currentSilverSub != 0)
        {
                string val_2 = this.currentSilverSub.Serialize(format:  0);
            UnityEngine.PlayerPrefs.SetString(key:  -1812776528, value:  this.currentSilverSub);
            return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  -1812776400);
    }
    private void LoadCurrentSubscription()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1812780752)) != false)
        {
                string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1812780752);
            object val_3 = JsonSerializable<System.Object>.Deserialize(serialized:  -1812780752);
            this.currentGoldenSub = "current_subscriptions_gt";
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1812776528)) == false)
        {
                return;
        }
        
        string val_5 = UnityEngine.PlayerPrefs.GetString(key:  R5);
        object val_6 = JsonSerializable<System.Object>.Deserialize(serialized:  R5);
        mem2[0] = R5;
    }
    private void UpdateNextSubscription()
    {
        var val_11;
        System.Collections.Generic.List<SubscriptionModel> val_1 = this.eitherSubscription;
        if(this.currentPurchase == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<SubscriptionModel> val_2 = this.eitherSubscription;
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  -1812507648, method:  new IntPtr(2482428336));
        bool val_4 = this.Exists(match:  8040448);
        if(val_4 == true)
        {
                val_4 = this.subscriptionUpdated;
            goto label_4;
        }
        
        return;
        label_4:
        CompanyDevices val_5 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                System.Collections.Generic.List<SubscriptionModel> val_7 = this.eitherSubscription;
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_8 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  -1812507648, method:  new IntPtr(2482429360));
            object val_9 = System.Linq.Enumerable.First<System.Object>(source:  -1812507648, predicate:  7720960);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            System.DateTime val_10 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1812519704, hi = mem[this.subscriptionUpdated + (0)], lo = mem[this.subscriptionUpdated + (4)], mid = mem[this.subscriptionUpdated + (8)]});
            string val_13 = val_11.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_14 = ;
            bool val_14 = this.IsActive;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            UnityEngine.Debug.LogFormat(format:  -1812531792, args:  472754880);
        }
        
        this.subscriptionUpdated = false;
        System.DateTime val_15 = ServerHandler.ServerTime;
        this.lastUpdated = this.lastUpdated;
        this.GetSubscription();
        InAppPurchasesManager val_16 = InAppPurchasesManager.Instance;
        0.QueryHistory();
    }
    private void OnServerResponded()
    {
        var val_1;
        var val_1 = 29424444;
        val_1 = 6201344 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(TrackingComponent.lastIntent == 2)
        {
                return;
        }
        
        if(TrackingComponent.__il2cppRuntimeField_cctor_finished != 0)
        {
                this.pendingSubscription = this;
            this.ValidatePurchasedSubscription(nativePurchase:  TrackingComponent.__il2cppRuntimeField_cctor_finished = this.currentNativePurchase);
        }
        
        if(this.subscriptionUpdated == true)
        {
                this.subscriptionUpdated = this.econUpdated;
            return;
        }
        
        this.GetSubscription();
    }
    private void GetSubscription()
    {
        ulong val_5;
        var val_8;
        twelvegigs.net.JsonApiRequester val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_21;
        var val_22;
        val_16 = 1152921504892043264;
        val_17 = 6192148 + 29433910;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_18 = null;
        val_18 = null;
        if(App.networkManager.Reachable() == false)
        {
                return;
        }
        
        Player val_2 = App.Player;
        if((System.String.IsNullOrEmpty(value:  1835037)) == true)
        {
                return;
        }
        
        System.DateTime val_4 = System.DateTime.UtcNow;
        val_19 = null;
        val_19 = null;
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511384503384}, d2:  new System.DateTime() {dateData = val_5});
        double val_10 = val_8.TotalSeconds;
        System.DateTime val_11 = DateTimeCheat.UtcNow;
        val_21 = null;
        val_21 = null;
        SubscriptionHandler.lastServerCall = val_5;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1928946992, value:  1726392512);
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        val_16 = App.networkManager;
        Player val_13 = App.Player;
        string val_14 = -1812291264(-1812291264) + 1835037;
        val_17 = "/api/subscriptions/";
        System.Action<System.Threading.Tasks.Task, System.Object> val_15 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1812266128, method:  new IntPtr(2482676144));
        val_16.DoGet(path:  -1812291264, onCompleteFunction:  7507968, destroy:  false, immediate:  false, getParams:  null, timeout:  20);
    }
    private void OnGetSubscription(string method, System.Collections.Generic.Dictionary<string, object> response)
    {
        System.Collections.IDictionary val_33;
        var val_34;
        var val_35;
        val_33 = response;
        System.DateTime val_1 = ServerHandler.ServerTime;
        this.lastUpdated = new System.DateTime();
        if(val_33 == 0)
        {
                return;
        }
        
        val_34 = "success";
        if((val_33.ContainsKey(key:  1616271776)) == false)
        {
                return;
        }
        
        twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  val_33);
        if((getBool(key:  1616271776)) == false)
        {
                return;
        }
        
        if((Contains(key:  -1812169936)) != false)
        {
                twelvegigs.storage.JsonDictionary val_6 = getJsonDictionary(key:  -1812169936);
            val_33 = val_3;
            if(val_3 != 0)
        {
                this._dailyCoinAmount = getInt(key:  -1987496016, defaultValue:  this._dailyCoinAmount);
        }
        else
        {
                this._dailyCoinAmount = 0.getInt(key:  -1987496016, defaultValue:  this._dailyCoinAmount);
        }
        
            if((Contains(key:  -1930648496)) != false)
        {
                this._dailyGemAmount = getInt(key:  -1930648496, defaultValue:  this._dailyGemAmount);
        }
        
            string val_11 = getString(key:  -1812169856, defaultValue:  1098586544);
            System.Globalization.CultureInfo val_12 = System.Globalization.CultureInfo.InvariantCulture;
            float val_13 = System.Single.Parse(s:  458731520, provider:  0);
            this._pointMultiplier = val_33;
            val_34 = "trial";
            if((Contains(key:  -1812169776)) != false)
        {
                twelvegigs.storage.JsonDictionary val_15 = getJsonDictionary(key:  -1812169776);
            this.UpdateTrialData(trialData:  458731520, subPack:  0);
        }
        
            this.econUpdated = true;
        }
        
        if((Contains(key:  -1812169696)) != false)
        {
                twelvegigs.storage.JsonDictionary val_17 = getJsonDictionary(key:  -1812169696);
            val_33 = val_3;
            if(val_3 != 0)
        {
                this._dailyCoinAmountSilver = getInt(key:  -1987496016, defaultValue:  this._dailyCoinAmountSilver);
        }
        else
        {
                this._dailyCoinAmountSilver = 0.getInt(key:  -1987496016, defaultValue:  this._dailyCoinAmountSilver);
        }
        
            if((Contains(key:  -1930648496)) != false)
        {
                this._dailyGemAmount = getInt(key:  -1930648496, defaultValue:  this._dailyGemAmount);
        }
        
            if(val_33 != 0)
        {
                this._silverTicketUnlockLevel = getInt(key:  -1812169616, defaultValue:  this._silverTicketUnlockLevel);
        }
        else
        {
                this._silverTicketUnlockLevel = 0.getInt(key:  -1812169616, defaultValue:  this._silverTicketUnlockLevel);
        }
        
            val_34 = "trial";
            if((Contains(key:  -1812169776)) != false)
        {
                twelvegigs.storage.JsonDictionary val_25 = getJsonDictionary(key:  -1812169776);
            this.UpdateTrialData(trialData:  458731520, subPack:  1);
        }
        
            this.econUpdated = true;
        }
        
        if((Contains(key:  -1812169520)) == false)
        {
                return;
        }
        
        if(0 == 0)
        {
            goto label_35;
        }
        
        val_34 = 0;
        label_37:
        if(1179403647 == null)
        {
            goto label_36;
        }
        
        val_34 = val_34 + 1;
        if(((uint)val_34 & 65535) < 0)
        {
            goto label_37;
        }
        
        label_35:
        val_35 = twelvegigs.storage.JsonDictionary.__il2cppRuntimeField_name;
        goto label_38;
        label_36:
        var val_27 = 0 + 0;
        var val_33 = (0 + 0) + 4;
        val_33 = JsonDictionary + (val_33 << 3);
        val_35 = val_33 + 188;
        label_38:
        val_33 = "silver";
        twelvegigs.storage.JsonDictionary val_28 = getJsonDictionary(key:  -1812169520);
        if((Contains(key:  -1812169936)) != false)
        {
                twelvegigs.storage.JsonDictionary val_30 = getJsonDictionary(key:  -1812169936);
            this.UpdateSubData(gtData:  458731520, subPackage:  0);
        }
        
        if((Contains(key:  -1812169696)) == false)
        {
                return;
        }
        
        twelvegigs.storage.JsonDictionary val_32 = getJsonDictionary(key:  -1812169696);
        this.UpdateSubData(gtData:  458731520, subPackage:  1);
    }
    private void UpdateSubData(twelvegigs.storage.JsonDictionary gtData, SubscriptionHandler.SubScriptionType subPackage)
    {
        var val_15;
        var val_16;
        val_15 = subPackage;
        if(val_15 == 1)
        {
            goto label_1;
        }
        
        if(val_15 != 0)
        {
            goto label_26;
        }
        
        if((gtData.Contains(key:  -1812041040)) != false)
        {
                Player val_2 = App.Player;
            val_15 = gtData.getInt(key:  -1812041040, defaultValue:  0);
        }
        
        val_16 = "trial_count";
        if((gtData.Contains(key:  -1812040928)) == false)
        {
            goto label_26;
        }
        
        Player val_5 = App.Player;
        val_15 = gtData.getInt(key:  -1812040928, defaultValue:  0);
        if(2621448 != 0)
        {
            goto label_26;
        }
        
        goto label_26;
        label_1:
        if((gtData.Contains(key:  -1812041040)) != false)
        {
                Player val_8 = App.Player;
            val_15 = gtData.getInt(key:  -1812041040, defaultValue:  0);
        }
        
        val_16 = "trial_count";
        if((gtData.Contains(key:  -1812040928)) != false)
        {
                Player val_11 = App.Player;
            val_15 = gtData.getInt(key:  -1812040928, defaultValue:  0);
        }
        
        label_26:
        if((gtData.Contains(key:  -1812040832)) == false)
        {
                return;
        }
        
        twelvegigs.storage.JsonDictionary val_14 = gtData.getJsonDictionary(key:  -1812040832);
        this.UpdateSubscriptionModel(sub:  gtData);
    }
    private void UpdateSubscriptionModel(twelvegigs.storage.JsonDictionary sub)
    {
        SubscriptionModel val_1 = new SubscriptionModel();
        if(val_1 != 0)
        {
                ParseJsonDic(jsonDic:  sub);
        }
        else
        {
                ParseJsonDic(jsonDic:  sub);
        }
        
        AppConfigs val_2 = App.Configuration;
        if((Equals(value:  null)) == false)
        {
            goto label_9;
        }
        
        if(this.currentGoldenSub != 0)
        {
            goto label_10;
        }
        
        this.currentGoldenSub = val_1;
        goto label_20;
        label_9:
        AppConfigs val_4 = App.Configuration;
        if((Equals(value:  null)) == false)
        {
            goto label_20;
        }
        
        if(this.currentSilverSub == 0)
        {
            goto label_19;
        }
        
        label_10:
        this.currentSilverSub.ParseJsonDic(jsonDic:  sub);
        label_20:
        this.subscriptionUpdated = true;
        this.SaveSubscription();
        return;
        label_19:
        this.currentSilverSub = val_1;
        goto label_20;
    }
    private void UpdateTrialData(twelvegigs.storage.JsonDictionary trialData, SubscriptionHandler.SubScriptionType subPack)
    {
        var val_6;
        var val_7;
        val_6 = trialData;
        val_7 = "android";
        if((val_6.Contains(key:  1726392512)) == false)
        {
                return;
        }
        
        twelvegigs.storage.JsonDictionary val_2 = val_6.getJsonDictionary(key:  1726392512);
        val_6 = val_6;
        val_7 = "days";
        if((val_6.Contains(key:  -1811775792)) == false)
        {
                return;
        }
        
        if(subPack != 1)
        {
                if(subPack != 0)
        {
                return;
        }
        
            this._freeTrialDaysGolden = val_6.getInt(key:  -1811775792, defaultValue:  3);
            return;
        }
        
        this._freeTrialDaysSilver = val_6.getInt(key:  -1811775792, defaultValue:  3);
    }
    public void CollectSubscription(SubscriptionHandler.SubScriptionType subPackage = 0)
    {
        twelvegigs.net.JsonApiRequester val_6;
        SubscriptionModel val_7;
        var val_8;
        SubscriptionModel val_9;
        var val_10;
        SubscriptionModel val_11;
        var val_12;
        val_6 = subPackage;
        if(val_6 != 1)
        {
                if(val_6 != 0)
        {
                return;
        }
        
            val_7 = this.currentGoldenSub;
        }
        else
        {
                val_7 = this.currentSilverSub;
        }
        
        if(mem[this.currentSilverSub] == 0)
        {
                return;
        }
        
        if(mem[this.currentSilverSub].CanCollect == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1811651424, value:  8945664);
        if(val_6 == 1)
        {
            goto label_7;
        }
        
        val_8 = 0;
        if(val_6 != 0)
        {
            goto label_8;
        }
        
        val_9 = this.currentGoldenSub;
        goto label_9;
        label_7:
        val_9 = this.currentSilverSub;
        label_9:
        val_8 = mem[this.currentSilverSub];
        if(val_8 != 0)
        {
            goto label_10;
        }
        
        label_8:
        label_10:
        Add(key:  -1830072288, value:  mem[this.currentSilverSub] + 12);
        if(val_6 == 1)
        {
            goto label_12;
        }
        
        val_10 = 0;
        if(val_6 != 0)
        {
            goto label_13;
        }
        
        val_11 = this.currentGoldenSub;
        goto label_14;
        label_12:
        val_11 = this.currentSilverSub;
        label_14:
        val_10 = mem[this.currentSilverSub];
        if(val_10 != 0)
        {
            goto label_15;
        }
        
        label_13:
        label_15:
        Add(key:  -1820667264, value:  mem[this.currentSilverSub] + 12);
        var val_6 = 29420798;
        val_6 = 6205260 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        val_6 = App.networkManager;
        Player val_3 = App.Player;
        string val_4 = -1812291264(-1812291264) + 1835037;
        System.Action<System.Threading.Tasks.Task, System.Object> val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1811626304, method:  new IntPtr(2483315968));
        val_6.DoPut(path:  -1812291264, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false);
    }
    public void OnCollectSubscription(string method, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = 35625844;
        System.DateTime val_1 = ServerHandler.ServerTime;
        this.lastUpdated = new System.DateTime();
        if(response == 0)
        {
            goto label_15;
        }
        
        val_10 = "success";
        if((response.ContainsKey(key:  1616271776)) == false)
        {
            goto label_15;
        }
        
        twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  response);
        if((getBool(key:  1616271776)) == false)
        {
            goto label_15;
        }
        
        SubscriptionModel val_5 = new SubscriptionModel();
        val_9 = "subscription";
        if((Contains(key:  -1812972384)) == false)
        {
            goto label_15;
        }
        
        if(0 == 0)
        {
            goto label_11;
        }
        
        var val_9 = 0;
        label_13:
        val_10 = 0;
        if((R3 + 0) == null)
        {
            goto label_12;
        }
        
        val_9 = val_9 + 1;
        val_10 = (uint)val_9 & 65535;
        if(val_10 < 0)
        {
            goto label_13;
        }
        
        label_11:
        val_11 = twelvegigs.storage.JsonDictionary.__il2cppRuntimeField_name;
        goto label_14;
        label_12:
        var val_7 = R3 + 0;
        var val_10 = (R3 + 0) + 4;
        val_10 = JsonDictionary + (val_10 << 3);
        val_11 = val_10 + 188;
        label_14:
        val_9 = "subscription";
        twelvegigs.storage.JsonDictionary val_8 = getJsonDictionary(key:  -1812972384);
        this.UpdateSubscriptionModel(sub:  458731520);
        label_15:
        if(this.onSubscriptionCollectAttempt == 0)
        {
                return;
        }
        
        this.onSubscriptionCollectAttempt.Invoke(obj:  response);
    }
    private void RegisterPurchase(ref PurchaseModel purchase)
    {
        var val_9;
        float val_27;
        float val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        Player val_1 = this.Player;
        Player val_2 = this.Player;
        if(purchase < 0)
        {
                Player val_3 = this.Player;
            mem[1152921511385418272] = purchase.id;
        }
        
        Player val_4 = this.Player;
        mem[1152921511385418276] = purchase.id;
        Player val_5 = this.Player;
        mem[1152921511385418280] = purchase.sale_price;
        Player val_6 = this.Player;
        System.DateTime val_7 = ServerHandler.ServerTime;
        mem[1152921511385418264] = val_9;
        Player val_10 = this.Player;
        float val_26 = purchase.sale_price;
        val_26 = S16 + val_26;
        mem[1152921511385418292] = val_26;
        Player val_11 = this.Player;
        float val_27 = 100f;
        val_27 = purchase.sale_price * val_27;
        PurchaseModel val_28 = val_27;
        val_28 = purchase + val_28;
        mem[1152921511385418132] = val_28;
        Player val_12 = this.Player;
        Player val_13 = this.Player;
        if(this == 0)
        {
                mem[1152921511385418304] = purchase.sale_price;
        }
        else
        {
                Player val_14 = this.Player;
            Player val_15 = this.Player;
            Player val_16 = this.Player;
            val_27 = ???;
            val_28 = purchase.sale_price / (-1.811363E+09f);
            mem[1152921511385418304] = val_28;
        }
        
        Player val_17 = this.Player;
        if(this != 0)
        {
                val_29 = this;
        }
        else
        {
                val_29 = 200;
            val_30 = 188;
        }
        
        mem[200] = 189;
        Player val_18 = this.Player;
        Player val_19 = this.Player;
        float val_20 = System.Math.Max(val1:  val_28, val2:  null);
        mem[1152921511385418332] = S16;
        Player val_22 = this.Player;
        val_31 = this;
        val_32 = 1;
        if((System.String.IsNullOrEmpty(value:  val_27)) == true)
        {
            goto label_38;
        }
        
        val_32 = 0;
        if((System.String.op_Inequality(a:  val_27, b:  -1811392592)) == false)
        {
            goto label_37;
        }
        
        Player val_24 = this.Player;
        val_31 = this;
        label_38:
        mem[1152921511385418336] = val_32;
        label_37:
        Player val_25 = this.Player;
        mem2[0] = 0;
    }
    protected override void AwakeLogic()
    {
        this.AwakeLogic();
        this.Initialize();
    }
    private void Initialize()
    {
        var val_13;
        var val_14;
        FrameSkipper val_15;
        System.Action val_16;
        bool val_17;
        bool val_18;
        var val_19;
        val_13 = null;
        val_13 = null;
        if(SubscriptionHandler.initialized == true)
        {
                return;
        }
        
        var val_13 = 29419621;
        val_13 = 6206436 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1811105760, method:  new IntPtr(2483812960));
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1811105760, method:  new IntPtr(2483813984));
        App.inAppPurchasesManager.addSubscriptionListener(subscriptionSuccessCallback:  7401472, errorCallback:  7401472);
        this.LoadCurrentSubscription();
        if(this.frameSkipper == 0)
        {
                UnityEngine.GameObject val_4 = this.gameObject;
            object val_5 = this.AddComponent<System.Object>();
            val_15 = this;
            this.frameSkipper = this;
        }
        else
        {
                val_15 = this.frameSkipper;
        }
        
        System.Action val_6 = new System.Action(object:  -1811105760, method:  new IntPtr(2483828320));
        System.Delegate val_7 = System.Delegate.Combine(a:  this.frameSkipper.updateLogic, b:  7454720);
        val_16 = this.frameSkipper.updateLogic;
        if(val_16 != 0)
        {
                if(null == null)
        {
            goto label_18;
        }
        
        }
        
        val_16 = 0;
        label_18:
        this.frameSkipper.updateLogic = val_16;
        NotificationCenter val_8 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1811105760, name:  -1976323520);
        val_17 = 0;
        Player val_9 = App.Player;
        if(this.currentGoldenSub != 0)
        {
                val_17 = this.currentGoldenSub.IsActive;
        }
        
        val_18 = 0;
        Player val_11 = App.Player;
        if(this.currentSilverSub != 0)
        {
                val_18 = this.currentSilverSub.IsActive;
        }
        
        val_19 = null;
        val_19 = null;
        SubscriptionHandler.initialized = true;
    }
    public SubscriptionHandler()
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        this.lastUpdated = new System.DateTime();
        this._pointMultiplier = 2f;
        this._freeTrialDaysGolden = 3;
        this._freeTrialDaysSilver = 3;
    }
    private static SubscriptionHandler()
    {
        null = null;
        SubscriptionHandler.secondsUntilNextRequest = 30;
        SubscriptionHandler.initialized = false;
    }
    private bool <UpdateNextSubscription>b__54_0(SubscriptionModel x)
    {
        ulong val_3;
        System.DateTime val_6;
        var val_7;
        val_6 = 35625850;
        val_7 = 0;
        if(x.IsActive == true)
        {
                return (bool)val_7;
        }
        
        val_6 = this.lastUpdated;
        System.DateTime val_2 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1810756192, hi = mem[x.<expire_at>k__BackingField + (0)], lo = mem[x.<expire_at>k__BackingField + (4)], mid = mem[x.<expire_at>k__BackingField + (8)]});
        val_7 = (System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_6}, t2:  new System.DateTime() {dateData = val_3})) ^ 1;
        return (bool)val_7;
    }
    private bool <UpdateNextSubscription>b__54_1(SubscriptionModel x)
    {
        ulong val_3;
        System.DateTime val_6;
        var val_7;
        val_6 = 35625851;
        val_7 = 0;
        if(x.IsActive == true)
        {
                return (bool)val_7;
        }
        
        val_6 = this.lastUpdated;
        System.DateTime val_2 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1810636000, hi = mem[x.<expire_at>k__BackingField + (0)], lo = mem[x.<expire_at>k__BackingField + (4)], mid = mem[x.<expire_at>k__BackingField + (8)]});
        val_7 = (System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_6}, t2:  new System.DateTime() {dateData = val_3})) ^ 1;
        return (bool)val_7;
    }

}
