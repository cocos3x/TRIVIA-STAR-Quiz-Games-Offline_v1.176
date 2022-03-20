using UnityEngine;
public class TrackingHandler : DefaultHandler<TrackingHandler>
{
    // Fields
    private const int RETRY_VALIDATION_SECS = 5;
    private PurchaseModel currentPurchase;
    private NativePurchase currentNativePurchase;
    private bool serverValidCurrentPurchase;
    
    // Methods
    public void ProcessPurchase(PurchaseModel currentPurchase, NativePurchase purchaseInfo)
    {
        var val_1;
        this.serverValidCurrentPurchase = false;
        if(purchaseInfo.isPending == true)
        {
                return;
        }
        
        R6.ServerValidatePurchase(currentPurchase:  R5, currentNativePurchase:  R4);
        var val_1 = 28276237;
        val_1 = 7349820 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        App.inAppPurchasesManager.AddTracked(token:  R4 + 24);
    }
    private void ServerValidatePurchase(PurchaseModel currentPurchase, NativePurchase currentNativePurchase)
    {
        object val_17;
        twelvegigs.net.JsonApiRequester val_18;
        System.Action<System.Threading.Tasks.Task, System.Object> val_19;
        var val_20;
        var val_21;
        val_17 = currentNativePurchase;
        object val_1 = null;
        val_18 = val_1;
        val_1 = new System.Object();
        typeof(TrackingHandler.<>c__DisplayClass5_0).__il2cppRuntimeField_8 = this;
        string val_2 = currentPurchase.ToShortString();
        string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  val_17, formatting:  1);
        string val_4 = -1820671712(-1820671712) + currentPurchase + 1269544832 + val_17;
        SLCDebug.Log(logMessage:  -1820671712, colorHash:  -1820671552, isError:  false);
        this.currentPurchase = currentPurchase;
        this.currentNativePurchase = val_17;
        val_19 = 1152921504892043264;
        var val_18 = 28275722;
        val_18 = 7350336 + val_18;
        if(val_18 == 0)
        {
                mem2[0] = 1;
        }
        
        val_20 = null;
        val_20 = null;
        if(App.networkManager.Reachable() == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        typeof(TrackingHandler.<>c__DisplayClass5_0).__il2cppRuntimeField_C = null;
        decimal val_7 = ChooseQuantity();
        Player val_8 = App.Player;
        var val_9 = 0 + 60;
        val_19 = 1152921510535002416;
        Add(key:  -1820671456, value:  10170368);
        GameBehavior val_10 = App.getBehavior;
        val_18 = val_17;
        Add(key:  -1988561632, value:  13152256);
        Add(key:  -1820667264, value:  currentPurchase.<Sku>k__BackingField);
        Player val_11 = App.Player;
        Add(key:  -1820667168, value:  13152256);
        float val_19 = 100f;
        val_19 = currentPurchase.sale_price * val_19;
        Add(key:  1610240448, value:  13152256);
        val_17 = val_18;
        Add(key:  -1820667088, value:  10170368);
        Player val_12 = App.Player;
        Add(key:  -1820666992, value:  1835037);
        if(currentPurchase.PrePurchaseUserInfo == 0)
        {
                0 = 1;
        }
        
        Add(key:  -1820662800, value:  8945664);
        CompanyDevices val_13 = CompanyDevices.Instance;
        bool val_14 = 0.CompanyDevice();
        if(val_14 == true)
        {
                return;
        }
        
        val_14.InjectAdditionalTrackingParams(postParams: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_15 = 291373068, purchase:  currentPurchase);
        if(val_18 != 0)
        {
                val_18.AddStoreSpecificDataForValidation(postParams: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_16 = 291373068);
        }
        
        val_21 = null;
        val_21 = null;
        val_18 = App.networkManager;
        val_19 = null;
        val_19 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  291373056, method:  new IntPtr(2474304592));
        val_18.DoPost(path:  -1820661680, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    private System.Collections.IEnumerator RetryValidation(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        typeof(TrackingHandler.<RetryValidation>d__6).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TrackingHandler.<RetryValidation>d__6).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(TrackingHandler.<RetryValidation>d__6).__il2cppRuntimeField_14 = eventData;
    }
    private void InjectAdditionalTrackingParams(ref System.Collections.Generic.Dictionary<string, object> postParams, PurchaseModel purchase)
    {
        var val_16;
        WordPets.WPTPetTile val_18;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        int val_24;
        var val_25;
        var val_26;
        decimal val_2 = Credits;
        val_16 = null;
        val_16 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                decimal val_4 = Credits;
            string val_5 = ToString(format:  -1946611488);
            val_18 = ;
            Add(key:  -1987496016, value:  -1820382808);
        }
        
        if((System.String.IsNullOrEmpty(value:  purchase.ltoModifier)) != true)
        {
                val_18 = purchase.ltoModifier;
            Add(key:  -1820396704, value:  val_18);
        }
        
        if(purchase.vipApplied != false)
        {
                val_20 = null;
            val_20 = null;
            val_22 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = purchase.vipAddedCredits, hi = R7, lo = 78753792, mid = -1820382832}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                string val_8 = ToString(format:  -1946611488);
            val_21 = 1152921510535002416;
            Add(key:  -1820396624, value:  -1820382808);
            val_22 = null;
            Add(key:  -1820396496, value:  13152256);
        }
        
            if(purchase.vipApplied != false)
        {
                val_23 = null;
            val_23 = null;
            val_24 = mem[purchase.vipAddedGems + (8)];
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = mem[purchase.vipAddedGems + (0)], hi = mem[purchase.vipAddedGems + (4)], lo = val_24, mid = mem[purchase.vipAddedGems + (12)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                string val_10 = ToString(format:  -1946611488);
            Add(key:  -1820396400, value:  -1820382808);
            val_24 = null;
            EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  78753792, key:  -1820396496, newValue:  13152256);
        }
        
            if(purchase.vipApplied != false)
        {
                val_25 = null;
            val_25 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = mem[purchase.vipAddedGoldenCurrency + (0)], hi = mem[purchase.vipAddedGoldenCurrency + (4)], lo = mem[purchase.vipAddedGoldenCurrency + (8)], mid = mem[purchase.vipAddedGoldenCurrency + (12)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                string val_12 = ToString(format:  -1946611488);
            Add(key:  -1820395248, value:  -1820382808);
            EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  78753792, key:  -1820395120, newValue:  13152256);
        }
        
            if((purchase.vipApplied != false) && (purchase.vipContribution >= 1))
        {
                Add(key:  -1820395024, value:  13152256);
        }
        
        }
        
        }
        
        }
        
        if((ContainsKey(key:  -1820394928)) != true)
        {
                var val_15 = 28271992;
            val_15 = 7354068 + val_15;
            if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
            val_26 = null;
            val_26 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            Add(key:  -1820394928, value:  292438016);
        }
        
        string val_14 = MiniJSON.Json.Serialize(obj:  78753792);
        postParams.Add(key:  -1820394832, value:  78753792);
    }
    private decimal ChooseQuantity()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_14;
        var val_15;
        var val_20;
        var val_22;
        var val_24;
        val_10 = this;
        val_11 = 0;
        decimal val_1 = Credits;
        val_12 = null;
        val_12 = null;
        val_14 = mem[R1 + 12];
        val_14 = R1 + 12;
        val_15 = System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        if(val_15 != false)
        {
                decimal val_3 = this.Credits;
            return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
        }
        
        val_11 = 0;
        decimal val_4 = Gems;
        val_20 = null;
        val_20 = null;
        val_14 = mem[R1 + 12];
        val_14 = R1 + 12;
        val_15 = System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        if(val_15 != false)
        {
                decimal val_6 = this.Gems;
            return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
        }
        
        val_11 = 0;
        decimal val_7 = PetsFood;
        val_22 = null;
        val_22 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                decimal val_9 = this.PetsFood;
            return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
        }
        
        val_24 = null;
        val_24 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
    }
    private void ServerCallback(System.Collections.Generic.Dictionary<string, object> eventData, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  response, formatting:  1);
        string val_2 = -1820146256(-1820146256) + response;
        val_10 = "TrackingHandler.ServerCallback ::\n";
        SLCDebug.Log(logMessage:  -1820146256, colorHash:  -1820146112, isError:  false);
        if(response == 0)
        {
            goto label_6;
        }
        
        val_10 = "validated";
        if((response.ContainsKey(key:  -1820146016)) == false)
        {
            goto label_6;
        }
        
        twelvegigs.storage.JsonDictionary val_4 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  response);
        if((getBool(key:  -1820146016)) == false)
        {
            goto label_8;
        }
        
        this.CheckPurchaseForAnomalies();
        this.serverValidCurrentPurchase = true;
        val_11 = null;
        val_11 = null;
        PluginObserverManager.isPurchaseValidationWorking = true;
        this.DoTrackPurchase();
        return;
        label_6:
        System.Collections.IEnumerator val_6 = this.RetryValidation(eventData:  eventData);
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  -1820121760);
        return;
        label_8:
        var val_10 = 28270839;
        val_10 = 7355220 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        GooglePurchasesBridge.trustUser = false;
        UnityEngine.Debug.LogError(message:  -1820145920);
        val_13 = null;
        val_13 = null;
        PluginObserverManager.isPurchaseValidationWorking = false;
        Player val_8 = App.Player;
        Player val_9 = App.Player;
        0.SaveState();
    }
    private void CheckPurchaseForAnomalies()
    {
        int val_12;
        TrackingHandler val_13;
        var val_14;
        var val_15;
        decimal val_17;
        string val_18;
        var val_19;
        var val_20;
        float val_21;
        var val_22;
        var val_23;
        var val_24;
        val_13 = this;
        if(this.currentPurchase == 0)
        {
                return;
        }
        
        val_14 = 0;
        decimal val_1 = Credits;
        val_15 = null;
        val_15 = null;
        val_17 = System.Decimal.Zero;
        if((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_17, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
                return;
        }
        
        Player val_3 = App.Player;
        val_19 = 52;
        val_18 = 52;
        val_20 = 256;
        val_21 = 3.587324E-43f;
        if(this.currentPurchase == 0)
        {
                val_20 = val_20;
            val_19 = val_19;
        }
        
        val_17 = val_13;
        if(this.currentPurchase.PrePurchaseUserInfo == 0)
        {
                val_22 = val_18;
            val_20 = val_20;
            val_18 = val_22;
            val_19 = val_19;
        }
        
        val_20 = val_20;
        val_18 = val_18;
        val_19 = val_19;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = mem[this.currentPurchase.PrePurchaseUserInfo.total_credits + (0)], hi = mem[this.currentPurchase.PrePurchaseUserInfo.total_credits + (4)], lo = mem[this.currentPurchase.PrePurchaseUserInfo.total_credits + (8)], mid = this.currentPurchase.PrePurchaseUserInfo})) == false)
        {
                return;
        }
        
        val_21 = null;
        val_21 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_6 = App.Player;
        Add(key:  -1820013280, value:  10170368);
        Add(key:  -1820004976, value:  10170368);
        decimal val_7 = Credits;
        Add(key:  -1820000752, value:  10170368);
        Player val_8 = App.Player;
        val_24 = null;
        val_24 = null;
        0.SetCredits(amount:  new System.Decimal() {flags = System.Decimal.Zero, hi = R7, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        Player val_9 = App.Player;
        val_13 = 0;
        decimal val_10 = Credits;
        val_23 = 0;
        decimal val_11 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1819984552, hi = this.currentPurchase.PrePurchaseUserInfo.total_credits, lo = R7, mid = System.Decimal.Zero}, d2:  new System.Decimal());
        val_18 = "Purchase Anomaly Correction";
        val_17 = "";
        val_13.AddCredits(amount:  new System.Decimal() {mid = val_12}, source:  val_18, subSource:  val_17, externalParams:  val_21, doTrack:  true);
    }
    public void TrackSubscriptionPurchase(PurchaseModel model, NativePurchase native)
    {
        this.currentPurchase = model;
        this.currentNativePurchase = native;
        this.DoTrackPurchase();
    }
    public void TrackPurchaseFailed(PurchaseModel model, string errorCode, string errorRaw, string errorString)
    {
        string val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = model;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                val_5 = null;
            val_5 = null;
            if(CompanyDevices.TrackingAllowed == false)
        {
                return;
        }
        
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_4 != 0)
        {
                Add(key:  -1819706880, value:  model.<Sku>k__BackingField);
            Add(key:  1611840256, value:  15282176);
        }
        
        val_4 = errorString;
        if(null != 0)
        {
                Add(key:  -1819706784, value:  errorCode);
        }
        else
        {
                Add(key:  -1819706784, value:  errorCode);
        }
        
        Add(key:  -1819706688, value:  val_4);
        Add(key:  1622567488, value:  errorRaw);
        var val_4 = 28259254;
        val_4 = 7366284 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = null;
        val_7 = null;
        App.trackerManager.track(eventName:  Events.TRANSACTION_FAILED, data:  78753792);
    }
    private void DoTrackPurchase()
    {
        if(mem[35628231] != true)
        {
            
        }
    
    }
    protected virtual void TrackSpecificGameLogic(PurchaseModel currentPurchase)
    {
    
    }
    private void TrackAdjustPurchaseEvents(PurchaseModel currentPurchase)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        string val_13;
        var val_14;
        Player val_1 = App.Player;
        if(currentPurchase.PrePurchaseUserInfo == 0)
        {
                var val_9 = 28258790;
            val_9 = 7366748 + val_9;
            if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
            val_9 = null;
            val_9 = null;
            val_10 = null;
            val_10 = null;
            App.trackerManager.track(eventName:  Events.FIRST_PURCHASE);
        }
        
        if(188 == 2)
        {
                var val_10 = 28258566;
            val_10 = 7366972 + val_10;
            if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
            val_11 = null;
            val_11 = null;
            val_12 = null;
            val_12 = null;
            App.trackerManager.track(eventName:  Events.REPEAT_PURCHASER);
        }
        
        string val_2 = currentPurchase.sale_price.ToString();
        string val_3 = currentPurchase.sale_price.Replace(oldValue:  1297836480, newValue:  1098586544);
        val_13 = "";
        val_14 = 0;
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(294727680)});
        System.Reflection.FieldInfo[] val_5 = GetFields();
        if((System.String.IsNullOrEmpty(value:  null)) != false)
        {
                string val_8 = -1819333728(-1819333728) + -1819321580(-1819321580);
            UnityEngine.Debug.LogError(message:  -1819333728);
        }
    
    }
    public TrackingHandler()
    {
    
    }

}
