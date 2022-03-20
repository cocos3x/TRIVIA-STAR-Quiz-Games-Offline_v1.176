using UnityEngine;
public class GooglePurchasesBridge : PurchasesBridge, PluginObserver
{
    // Fields
    private const int PURCHASE_DAYS_LIMIT = 4;
    private bool initialized;
    private string key;
    private string[] currentSKUs;
    private System.Collections.Generic.Queue<SLC.Billing.GooglePurchase> pendingPurchases;
    private static bool trustUser;
    private NativePurchase cachedPurchase;
    
    // Properties
    public static bool TrustUser { get; set; }
    
    // Methods
    public PluginObserverManager.ObserverType getType()
    {
    
    }
    public string pluginName()
    {
    
    }
    public string errorMessage()
    {
        var val_1;
        if(this.initialized != false)
        {
                if(R1 == 0)
        {
                val_1 = "Failed to query the inventory, service not working.";
        }
        
            return;
        }
        
        val_1 = "Not initialized!";
    }
    public bool isWorking()
    {
        if(R4 != 0)
        {
                return (bool)R4 + 12;
        }
        
        return (bool)R4 + 12;
    }
    public bool isInitialized()
    {
        return (bool)this.initialized;
    }
    public static bool get_TrustUser()
    {
        null = null;
        return (bool)GooglePurchasesBridge.trustUser;
    }
    public static void set_TrustUser(bool value)
    {
        null = null;
        GooglePurchasesBridge.trustUser = value;
    }
    public GooglePurchasesBridge(InAppPurchasesManager manager)
    {
        var val_13;
        System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
        this.pendingPurchases = null;
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        AddObserver(observer:  -1841046480);
        System.Action val_3 = new System.Action(object:  -1841046480, method:  new IntPtr(2453887600));
        SLC.Billing.GoogleIAPManager.add_billingSupportedEvent(value:  7454720);
        System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1841046480, method:  new IntPtr(2453888624));
        SLC.Billing.GoogleIAPManager.add_queryInventoryFailedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1841046480, method:  new IntPtr(2453889648));
        SLC.Billing.GoogleIAPManager.add_purchaseSucceededEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1841046480, method:  new IntPtr(2453891696));
        SLC.Billing.GoogleIAPManager.add_purchaseFailedEvent(value:  7401472);
        System.Action<System.Threading.Tasks.Task, System.Object> val_7 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1841046480, method:  new IntPtr(2453892720));
        SLC.Billing.GoogleIAPManager.add_consumePurchaseSucceededEvent(value:  7507968);
        System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1841046480, method:  new IntPtr(2453893744));
        SLC.Billing.GoogleIAPManager.add_consumePurchaseFailedEvent(value:  7401472);
        System.Action<System.Threading.Tasks.Task, System.Object> val_9 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1841046480, method:  new IntPtr(2453894768));
        SLC.Billing.GoogleIAPManager.add_acknowledgePurchaseSucceededEvent(value:  7507968);
        System.Action<twelvegigs.storage.JsonDictionary> val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1841046480, method:  new IntPtr(2453895792));
        SLC.Billing.GoogleIAPManager.add_AcknowledgePurchaseFailedEvent(value:  7401472);
        CompanyDevices val_11 = CompanyDevices.Instance;
        SLC.Billing.GoogleIAPManager.<logEnabled>k__BackingField = 0.CompanyDevice();
        var val_13 = 29073139;
        val_13 = 6552920 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        GooglePurchasesBridge.trustUser = true;
    }
    public override void init(string key)
    {
        if(this.initialized == true)
        {
                return;
        }
        
        mem2[0] = ???;
        if(R5 == 0)
        {
                return;
        }
        
        SLC.Billing.GoogleIAP.init(publicKey:  R5);
        mem2[0] = 1;
    }
    public override void queryInventory(string[] productSkus, string[] subSkus)
    {
        var val_3;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                val_3 = 1152921511111011712;
            AddRange(collection:  productSkus);
            AddRange(collection:  subSkus);
        }
        else
        {
                val_3 = 1152921511111011712;
            AddRange(collection:  productSkus);
            AddRange(collection:  subSkus);
        }
        
        T[] val_2 = ToArray();
        this.currentSKUs = null;
        SLC.Billing.GoogleIAP.queryInventory(products:  productSkus, subscriptions:  subSkus);
    }
    public override void queryHistory()
    {
        SLC.Billing.GoogleIAP.queryHistory();
    }
    public override void Purchase(string sku)
    {
        SLC.Billing.GoogleIAP.purchaseProduct(sku:  sku);
    }
    public override void Subscribe(string sku)
    {
        SLC.Billing.GoogleIAP.subscribe(sku:  sku);
    }
    public override void Consume(NativePurchase purchase)
    {
        bool val_2;
        if(purchase != 0)
        {
                val_2 = purchase.isConsumable;
        }
        else
        {
                val_2 = 0;
        }
        
        if(val_2 != 0)
        {
                SLC.Billing.GoogleIAP.consumeProduct(purchaseToken:  purchase.token);
            return;
        }
        
        SLC.Billing.GoogleIAP.AcknowledgeProduct(purchaseToken:  purchase.token);
    }
    private void queryInventoryFailedEvent(string error)
    {
        string val_1 = -1840089872(-1840089872) + error;
        UnityEngine.Debug.Log(message:  -1840089872);
    }
    private void purchaseSucceededEvent(SLC.Billing.GooglePurchase purchase)
    {
        var val_2;
        if((purchase.<purchaseState>k__BackingField) == 0)
        {
                return;
        }
        
        if(this.cachedPurchase != 0)
        {
                this.pendingPurchases.Enqueue(item:  purchase);
            return;
        }
        
        this.cachedPurchase = this;
        if((this.IsAValidPurchaseDate(purchase:  purchase, nativePurchase:  -1839923984)) == false)
        {
            goto label_5;
        }
        
        var val_2 = 29071800;
        val_2 = 6554776 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(GooglePurchasesBridge.trustUser == false)
        {
            goto label_11;
        }
        
        label_14:
        this.NotifyManagers(success:  true, purchase:  this.cachedPurchase);
        goto label_12;
        label_11:
        if(GooglePurchasesBridge.trustUser == false)
        {
            goto label_14;
        }
        
        label_12:
        if((purchase.<isAcknowledged>k__BackingField) == false)
        {
                purchase.<isAcknowledged>k__BackingField = purchase.<purchaseState>k__BackingField;
        }
        
        if((purchase.<isAcknowledged>k__BackingField) == 1)
        {
            goto typeof(GooglePurchasesBridge).__il2cppRuntimeField_10C;
        }
        
        label_5:
        this.cachedPurchase = 0;
        this.consumePendings();
    }
    private bool IsAValidPurchaseDate(SLC.Billing.GooglePurchase purchase, NativePurchase nativePurchase)
    {
        ulong val_4;
        var val_11;
        decimal val_1 = System.Decimal.op_Implicit(value:  1152921511356990304);
        System.DateTime val_3 = twelvegigs.storage.JsonDictionary.ConvertToUTCMilliseconds(timestamp:  new System.Decimal() {flags = -1839791272});
        if(nativePurchase.isConsumable != false)
        {
                System.DateTime val_6 = ServerHandler.ServerTime;
            System.DateTime val_9 = AddDays(value:  null);
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = val_4})) == false)
        {
                val_11 = 1;
        }
        
            return (bool)val_11;
        }
        
        val_11 = 1;
        return (bool)val_11;
    }
    private void purchaseFailedEvent(string error)
    {
        var val_5;
        NativePurchaseErrorCode val_1 = NativePurchase.setNavitePurchaseErrorCode(error:  error);
        NativePurchase val_2 = new NativePurchase(errorCode:  error, errorString:  error);
        R6.notify(success:  false, purchaseInfo:  290840576);
        NativePurchaseErrorCode val_3 = NativePurchase.setNavitePurchaseErrorCode(error:  error);
        NativePurchase val_4 = new NativePurchase(errorCode:  error, errorString:  error);
        R6.notifySubscription(success:  false, purchaseInfo:  290840576);
        var val_5 = 29070139;
        val_5 = 6555920 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        GooglePurchasesBridge.trustUser = false;
        this.consumePendings();
    }
    private void consumePurchaseSucceededEvent(string responseCode, string purchaseToken)
    {
        NativePurchase val_2;
        var val_3;
        val_2 = 1152921504897527808;
        var val_2 = 29070428;
        val_2 = 6556148 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        if(GooglePurchasesBridge.trustUser != true)
        {
                val_2 = this.cachedPurchase;
            if((System.String.op_Equality(a:  this.cachedPurchase.token, b:  purchaseToken)) != false)
        {
                this.NotifyManagers(success:  true, purchase:  this.cachedPurchase);
        }
        
        }
        
        this.cachedPurchase = 0;
        this.consumePendings();
    }
    private void acknowledgePurchaseSucceededEvent(string responseCode, string purchaseToken)
    {
        this.cachedPurchase = 0;
        this.consumePendings();
    }
    private void acknowledgePurchaseFailedEvent(string responseCode)
    {
        this.cachedPurchase = 0;
        this.consumePendings();
    }
    private void NotifyManagers(bool success, NativePurchase purchase)
    {
        if(purchase.isSubscription != false)
        {
                this.notifySubscription(success:  success, purchaseInfo:  purchase);
            return;
        }
        
        this.notify(success:  success, purchaseInfo:  purchase);
    }
    private bool AlreadyCashedIn(SLC.Billing.GooglePurchase purchaseToConsume)
    {
        var val_1;
        var val_1 = 29070112;
        val_1 = 6556464 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(GooglePurchasesBridge.trustUser == true)
        {
                GooglePurchasesBridge.trustUser = this.cachedPurchase;
        }
        
        if(GooglePurchasesBridge.trustUser == 0)
        {
                return false;
        }
        
        if(purchaseToConsume != 0)
        {
                return System.String.op_Equality(a:  this.cachedPurchase.originalJson, b:  purchaseToConsume.<originalJson>k__BackingField);
        }
        
        return System.String.op_Equality(a:  this.cachedPurchase.originalJson, b:  purchaseToConsume.<originalJson>k__BackingField);
    }
    private void consumePurchaseFailedEvent(string error)
    {
        this.cachedPurchase = 0;
        this.consumePendings();
    }
    private void consumePendings()
    {
        if(this.pendingPurchases == 0)
        {
                return;
        }
        
        if(R1 < 1)
        {
                return;
        }
        
        SLC.Billing.GooglePurchase val_1 = this.pendingPurchases.Dequeue();
        this.purchaseSucceededEvent(purchase:  this.pendingPurchases);
    }
    protected override NativePurchase BuildPurchase(object parameters)
    {
        var val_7;
        var val_8;
        var val_9;
        SLC.Billing.GooglePurchase val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Type val_1 = parameters.GetType();
        val_7 = 0;
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15388672)});
        if((System.Type.op_Equality(left:  parameters, right:  15388672)) != false)
        {
                if(parameters != 0)
        {
                if(null != null)
        {
                val_8 = 0;
        }
        
        }
        
            val_9 = 0;
            object val_4 = MiniJSON.Json.Deserialize(json:  null);
            val_10 = null;
            if(val_8 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_8 = 0;
        }
        
            val_9 = val_8;
        }
        
            val_11 = 0;
            val_10 = new SLC.Billing.GooglePurchase(dict:  0);
            if(parameters != 0)
        {
                if(null != null)
        {
                parameters = 0;
        }
        
            val_11 = parameters;
        }
        
            typeof(SLC.Billing.GooglePurchase).__il2cppRuntimeField_3C = val_11;
        }
        else
        {
                val_10 = 0;
        }
        
        val_12 = 2621443;
        NativePurchase val_6 = new NativePurchase(sku:  2621443);
        if(val_6 != 0)
        {
                typeof(NativePurchase).__il2cppRuntimeField_C = NativePurchase.__il2cppRuntimeField_byval_arg;
            typeof(NativePurchase).__il2cppRuntimeField_14 = 0;
            typeof(NativePurchase).__il2cppRuntimeField_1C = 52;
            typeof(NativePurchase).__il2cppRuntimeField_18 = 6;
            typeof(NativePurchase).__il2cppRuntimeField_2C = 52;
            val_13 = 2097204;
        }
        else
        {
                mem[12] = 2621443;
            mem[20] = 0;
            mem[28] = 52;
            mem[24] = 6;
            val_12 = 52;
            mem[44] = val_12;
            val_13 = 2097204;
        }
        
        if(val_6 != 0)
        {
                2097203 = 1;
        }
        
        typeof(NativePurchase).__il2cppRuntimeField_32 = 1;
    }
    private void billingSupportedEvent()
    {
        var val_1;
        UnityEngine.Debug.Log(message:  -1838534736);
        SLC.Billing.GoogleIAP.queryHistory();
        this.Initialized = true;
        var val_1 = 29068461;
        val_1 = 6557596 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        App.inAppPurchasesManager.Initialized = true;
    }
    private void billingNotSupportedEvent(string error)
    {
    
    }
    public override void setPurchasePackages(string[] purchasePackages)
    {
        if(this.currentSKUs == null)
        {
                this.currentSKUs = purchasePackages;
        }
    
    }
    public override void setLogging(bool isLogging)
    {
        mem[1152921511358762652] = isLogging;
    }
    private static GooglePurchasesBridge()
    {
    
    }

}
