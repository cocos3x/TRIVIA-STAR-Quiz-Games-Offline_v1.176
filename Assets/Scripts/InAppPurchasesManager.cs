using UnityEngine;
public class InAppPurchasesManager
{
    // Fields
    private const string PURCHASE_PREF_KEY = "iap_unresolved";
    private const string ANDROID_PROCESSED_TOKENS = "iap_android_tokens";
    private const int MAX_SAVED_TOKENS = 30;
    private static InAppPurchasesManager instance;
    private PurchasesBridge purchasesBridge;
    private bool initialized;
    private bool inPurchase;
    private bool logging;
    private System.Collections.Generic.List<System.Action<NativePurchase>> successCallbacks;
    private System.Collections.Generic.List<System.Action<NativePurchase>> subscriptionsSuccessCallbacks;
    private System.Collections.Generic.List<System.Action<NativePurchase>> errorCallbacks;
    private System.Collections.Generic.List<System.Action<NativePurchase>> subscriptionsErrorCallbacks;
    private static bool <inPurchaseIntent>k__BackingField;
    private System.Collections.Generic.HashSet<string> cashedIn;
    private System.Collections.Generic.HashSet<string> tracked;
    private PurchaseModel currentPurchase;
    private System.Collections.Generic.List<string> validTrackPoints;
    
    // Properties
    public static bool inPurchaseIntent { get; set; }
    public bool Logging { get; set; }
    public bool Initialized { get; set; }
    public PurchaseModel CurrentPurchase { get; }
    public static InAppPurchasesManager Instance { get; }
    
    // Methods
    public static bool get_inPurchaseIntent()
    {
        return (bool)InAppPurchasesManager.<inPurchaseIntent>k__BackingField;
    }
    private static void set_inPurchaseIntent(bool value)
    {
        InAppPurchasesManager.<inPurchaseIntent>k__BackingField = value;
    }
    public bool get_Logging()
    {
        return (bool)this.logging;
    }
    public void set_Logging(bool value)
    {
        this.logging = value;
        if(this.purchasesBridge == 0)
        {
            
        }
    
    }
    public bool get_Initialized()
    {
        return (bool)this.initialized;
    }
    public void set_Initialized(bool value)
    {
        if(this.initialized == false)
        {
                this.initialized = value;
        }
    
    }
    public PurchaseModel DeserializeCurrentPurchaseFromPrefs()
    {
        var val_5;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1837138736, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1837138736)) != true)
        {
                object val_3 = JsonSerializable<System.Object>.Deserialize(serialized:  -1837138736);
            val_5 = "iap_unresolved";
            if("iap_unresolved" != 0)
        {
                return;
        }
        
        }
        
        val_5 = 0;
        string val_4 = -1837137536(-1837137536) + -1837138736(-1837138736) + -1837137616(-1837137616);
        UnityEngine.Debug.LogWarning(message:  -1837137536);
    }
    public void ClearPurchaseFromPrefs()
    {
        this.currentPurchase = 0;
        UnityEngine.PlayerPrefs.SetString(key:  -1837138736, value:  1098586544);
    }
    public PurchaseModel get_CurrentPurchase()
    {
    
    }
    public void AddCashedIn(string token)
    {
        System.Collections.Generic.HashSet<System.String> val_3 = this.cashedIn;
        if((val_3.Contains(item:  token)) != true)
        {
                val_3 = this.cashedIn;
            bool val_2 = val_3.Add(item:  token);
        }
        
        this.SaveCashedInAndTracked();
    }
    public bool IsCashedIn(string token)
    {
        if(this.cashedIn != 0)
        {
                return this.cashedIn.Contains(item:  token);
        }
        
        return this.cashedIn.Contains(item:  token);
    }
    public void AddTracked(string token)
    {
        System.Collections.Generic.HashSet<System.String> val_3 = this.tracked;
        if((val_3.Contains(item:  token)) != true)
        {
                val_3 = this.tracked;
            bool val_2 = val_3.Add(item:  token);
        }
        
        this.SaveCashedInAndTracked();
    }
    public bool IsTracked(string token)
    {
        if(this.tracked != 0)
        {
                return this.tracked.Contains(item:  token);
        }
        
        return this.tracked.Contains(item:  token);
    }
    private void SaveCashedInAndTracked()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Collections.Generic.List<ZooTile> val_2 = new System.Collections.Generic.List<ZooTile>(collection:  this.cashedIn);
        System.Collections.Generic.List<ZooTile> val_3 = new System.Collections.Generic.List<ZooTile>(collection:  this.tracked);
        RemoveRange(index:  0, count:  1094062034);
        RemoveRange(index:  0, count:  1094062034);
        if(null != 0)
        {
                Add(key:  -1836253008, value:  80883712);
        }
        else
        {
                Add(key:  -1836253008, value:  80883712);
        }
        
        Add(key:  -1836252912, value:  80883712);
        string val_4 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1836252816, value:  78753792);
    }
    private void LoadCashedInAndTrecked()
    {
        string val_7;
        var val_14;
        var val_15;
        var val_16;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1836252816)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1836252816, defaultValue:  -2040381152);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1836252816);
        if("iap_android_tokens" != 0)
        {
                if(null == null)
        {
            goto label_26;
        }
        
        }
        
        label_26:
        string val_4 = 0.Item[-1836253008];
        val_14 = 0;
        List.Enumerator<T> val_5 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        bool val_8 = this.cashedIn.Add(item:  val_7);
        goto label_14;
        label_11:
        Dispose();
        string val_9 = 0.Item[-1836252912];
        if(0 != 0)
        {
                val_15 = null;
        }
        
        if(0 != 0)
        {
                val_15 = null;
        }
        
        val_16 = 0;
        List.Enumerator<T> val_10 = GetEnumerator();
        label_25:
        if(MoveNext() == false)
        {
            goto label_22;
        }
        
        bool val_12 = this.tracked.Add(item:  val_7);
        goto label_25;
        label_22:
        Dispose();
    }
    private InAppPurchasesManager()
    {
        this.cashedIn = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
        this.tracked = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  -1836003104);
        this.validTrackPoints = null;
        this.successCallbacks = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.errorCallbacks = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.subscriptionsSuccessCallbacks = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.subscriptionsErrorCallbacks = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.purchasesBridge = new GooglePurchasesBridge(manager:  -1835977984);
    }
    public void RemovePurchaseListeners(System.Action<NativePurchase> successCallback, System.Action<NativePurchase> errorCallback)
    {
        System.Collections.Generic.List<System.Action<NativePurchase>> val_9;
        if((this.successCallbacks.Contains(item:  successCallback)) != false)
        {
                bool val_2 = this.successCallbacks.Remove(item:  successCallback);
        }
        
        if((this.errorCallbacks.Contains(item:  errorCallback)) != false)
        {
                bool val_4 = this.errorCallbacks.Remove(item:  errorCallback);
        }
        
        val_9 = this.subscriptionsSuccessCallbacks;
        if((val_9.Contains(item:  successCallback)) != false)
        {
                val_9 = this.subscriptionsSuccessCallbacks;
            bool val_6 = val_9.Remove(item:  successCallback);
        }
        
        if((this.subscriptionsErrorCallbacks.Contains(item:  errorCallback)) == false)
        {
                return;
        }
        
        bool val_8 = this.errorCallbacks.Remove(item:  errorCallback);
    }
    public void RestorePreviousPurchases()
    {
        UnityEngine.Debug.LogError(message:  -1835694016);
        if(this.purchasesBridge == 0)
        {
            
        }
    
    }
    public void SetPurchaseables(string[] packs)
    {
        if(this.purchasesBridge == 0)
        {
                return;
        }
        
        goto typeof(PurchasesBridge).__il2cppRuntimeField_124;
    }
    public static InAppPurchasesManager get_Instance()
    {
        InAppPurchasesManager val_2;
        InAppPurchasesManager val_1 = null;
        val_2 = InAppPurchasesManager.instance;
        if(val_2 != 0)
        {
                return;
        }
        
        val_1 = new InAppPurchasesManager();
        InAppPurchasesManager.instance = val_1;
        val_2 = InAppPurchasesManager.instance;
    }
    public void Init(string key)
    {
        if(this.initialized == true)
        {
                return;
        }
        
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  R4, method:  new IntPtr(2459703648));
        SLC.Billing.GoogleIAPManager.add_queryInventorySucceededEvent(value:  7401472);
    }
    private void HandleGooglequeryInventorySucceededEvent(System.Collections.Generic.List<SLC.Billing.GoogleSkuInfo> skus)
    {
        var val_5;
        var val_10;
        var val_11;
        AppConfigs val_1 = App.Configuration;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        List.Enumerator<T> val_3 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        if(val_5 != 0)
        {
                val_10 = val_5;
            val_11 = mem[val_5 + 24];
            val_11 = val_5 + 24;
        }
        else
        {
                val_10 = 24;
            val_11 = 0;
        }
        
        string val_6 = -1835139280(-1835139280) + null + -1835139360(-1835139360) + val_5 + 12(val_5 + 12);
        SLCDebug.Log(logMessage:  -1835139280, colorHash:  -1835139200, isError:  false);
        string val_7 = 0.GetId(sku:  null);
        if((System.String.IsNullOrEmpty(value:  null)) == true)
        {
            goto label_14;
        }
        
        string val_9 = 0.GetId(sku:  null);
        Add(key:  0, value:  val_5 + 12);
        goto label_14;
        label_5:
        Dispose();
        PackagesManager.UpdateCreditsFromStore(items:  78753792);
    }
    public void QueryHistory()
    {
        if(this.purchasesBridge == 0)
        {
            
        }
    
    }
    public void QueryInventory(string[] prodSkus, string[] subSkus)
    {
        if(this.purchasesBridge == 0)
        {
            
        }
    
    }
    public bool Purchase(PurchaseModel purchase)
    {
        var val_9;
        bool val_10;
        var val_11;
        PurchasesBridge val_12;
        var val_13;
        var val_14;
        string val_1 = purchase.ToShortString();
        string val_2 = System.String.Format(format:  -1834630048, arg0:  purchase);
        val_9 = 0;
        SLCDebug.Log(logMessage:  -1834630048, colorHash:  -1834629904, isError:  false);
        string val_3 = UnityEngine.StackTraceUtility.ExtractStackTrace();
        val_10 = 0;
        val_11 = 0;
        goto label_6;
        label_11:
        if(0 <= val_9)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + 0;
        bool val_4 = val_10.Contains(value:  (0 + 0) + 16);
        val_11 = val_11 | val_4;
        val_9 = 1;
        label_6:
        if(val_9 < val_4)
        {
            goto label_11;
        }
        
        if((val_11 & true) != 0)
        {
            goto label_12;
        }
        
        InAppPurchasesManager.<inPurchaseIntent>k__BackingField = true;
        if(this.initialized == false)
        {
            goto label_14;
        }
        
        this.currentPurchase = new PurchaseModel(purchaseToClone:  purchase);
        string val_6 = Serialize(format:  1);
        UnityEngine.PlayerPrefs.SetString(key:  -1837138736, value:  292597760);
        bool val_7 = PrefsSerializationManager.SavePlayerPrefs();
        if(purchase == 0)
        {
            goto label_18;
        }
        
        val_12 = this.purchasesBridge;
        val_10 = purchase.isSubscription;
        goto label_19;
        label_12:
        val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_13 == 1)
        {
                val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        val_14 = 0;
        D.LogClientError(developer:  -1834616496, filter:  1788750208, context:  0, strings:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        return (bool)val_14;
        label_14:
        NativePurchase val_8 = null;
        val_10 = val_8;
        val_14 = 0;
        val_8 = new NativePurchase(errorCode:  8, errorString:  null);
        this.notify(success:  false, purchaseInfo:  290840576);
        UnityEngine.Debug.LogError(message:  -1834616096);
        return (bool)val_14;
        label_18:
        val_12 = this.purchasesBridge;
        val_10 = 240;
        label_19:
        if(val_10 != 0)
        {
            
        }
        
        val_14 = 1;
        return (bool)val_14;
    }
    public void addPurchaseListener(System.Action<NativePurchase> successCallback, System.Action<NativePurchase> errorCallback)
    {
        System.Collections.Generic.List<System.Action<NativePurchase>> val_3 = this.successCallbacks;
        if((val_3.Contains(item:  successCallback)) != true)
        {
                val_3 = this.successCallbacks;
            val_3.Add(item:  successCallback);
        }
        
        if((this.errorCallbacks.Contains(item:  errorCallback)) != false)
        {
                return;
        }
        
        this.errorCallbacks.Add(item:  errorCallback);
    }
    public void addSubscriptionListener(System.Action<NativePurchase> subscriptionSuccessCallback, System.Action<NativePurchase> errorCallback)
    {
        System.Collections.Generic.List<System.Action<NativePurchase>> val_3 = this.subscriptionsSuccessCallbacks;
        if((val_3.Contains(item:  subscriptionSuccessCallback)) != true)
        {
                val_3 = this.subscriptionsSuccessCallbacks;
            val_3.Add(item:  subscriptionSuccessCallback);
        }
        
        if((this.subscriptionsErrorCallbacks.Contains(item:  errorCallback)) != false)
        {
                return;
        }
        
        this.subscriptionsErrorCallbacks.Add(item:  errorCallback);
    }
    public void notify(bool success, NativePurchase purchaseInfo)
    {
        var val_3;
        if(success == true)
        {
                24 = 16;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_3.Invoke(obj:  purchaseInfo);
        goto label_4;
        label_2:
        Dispose();
        var val_4 = 24178238;
        val_4 = 11458300 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        InAppPurchasesManager.<inPurchaseIntent>k__BackingField = false;
    }
    public void notifySubscription(bool success, NativePurchase purchaseInfo)
    {
        var val_3;
        if(success == true)
        {
                28 = 20;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_3.Invoke(obj:  purchaseInfo);
        goto label_4;
        label_2:
        Dispose();
        var val_4 = 24177114;
        val_4 = 11459424 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        InAppPurchasesManager.<inPurchaseIntent>k__BackingField = false;
    }
    private void Log(string message)
    {
        if(this.logging == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  message);
    }

}
