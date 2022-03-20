using UnityEngine;
public class PurchasesHandler : DefaultHandler<PurchasesHandler>
{
    // Fields
    public static PostProcessPurchaseDelegate OnProcessPurchase;
    public static System.Action<PurchaseModel> OnPurchaseCompleted;
    public static System.Action<PurchaseModel> OnPurchaseFailure;
    private const string ON_RESTORE_TRANSACTIONS_SUCCESS = "OnRestoreTransactionsSuccess";
    private static bool initialized;
    
    // Methods
    private void OnPurchaseComplete(NativePurchase purchaseInfo)
    {
        PurchasesHandler val_26;
        var val_27;
        InAppPurchasesManager val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        string val_37;
        var val_38;
        var val_39;
        var val_40;
        val_26 = this;
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  purchaseInfo, formatting:  1);
        string val_2 = System.String.Format(format:  -1816759936, arg0:  purchaseInfo);
        SLCDebug.Log(logMessage:  -1816759936, colorHash:  -1816759776, isError:  false);
        val_27 = 1152921504892043264;
        AppConfigs val_3 = App.Configuration;
        string val_4 = 0.GetId(sku:  purchaseInfo.sku);
        val_28 = 0;
        val_29 = null;
        val_29 = null;
        if(App.inAppPurchasesManager.currentPurchase == 0)
        {
            goto label_14;
        }
        
        label_56:
        val_30 = 1152921504898486272;
        if((PurchasesHandler.DeterminePackageType(packageId:  null)) == false)
        {
                return;
        }
        
        if(App.inAppPurchasesManager.currentPurchase != 0)
        {
            goto label_18;
        }
        
        SLCDebug.Log(logMessage:  -1816755584, colorHash:  -1857862144, isError:  false);
        if(new PurchaseModel() == 0)
        {
            goto label_21;
        }
        
        typeof(PurchaseModel).__il2cppRuntimeField_8 = purchaseInfo + 16;
        typeof(PurchaseModel).__il2cppRuntimeField_C = val_28;
        goto label_22;
        label_14:
        val_31 = null;
        val_31 = null;
        PurchaseModel val_7 = App.inAppPurchasesManager.DeserializeCurrentPurchaseFromPrefs();
        if(App.inAppPurchasesManager == 0)
        {
            goto label_29;
        }
        
        if((System.String.op_Inequality(a:  App.inAppPurchasesManager.initialized, b:  null)) == false)
        {
            goto label_30;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = "PurchasesHandler.OnPurchaseComplete :: currentPurchase.InternalId (";
        typeof(System.String[]).__il2cppRuntimeField_14 = App.inAppPurchasesManager + 12;
        typeof(System.String[]).__il2cppRuntimeField_18 = ") != packagePurchased (";
        typeof(System.String[]).__il2cppRuntimeField_1C = val_28;
        typeof(System.String[]).__il2cppRuntimeField_20 = ")";
        string val_9 = +477709520;
        SLCDebug.Log(logMessage:  477709520, colorHash:  -1816755024, isError:  false);
        goto label_56;
        label_29:
        string val_10 = -1816754736(-1816754736) + null + -1816754928(-1816754928);
        SLCDebug.Log(logMessage:  -1816754736, colorHash:  -1816754512, isError:  false);
        goto label_56;
        label_30:
        SLCDebug.Log(logMessage:  -1816754320, colorHash:  -1816754416, isError:  false);
        goto label_56;
        label_21:
        typeof(PurchaseModel).__il2cppRuntimeField_8 = purchaseInfo + 16;
        typeof(PurchaseModel).__il2cppRuntimeField_C = val_28;
        label_22:
        AddInstruction(instruction:  0);
        var val_27 = 25927577;
        val_27 = 9698484 + val_27;
        if(val_27 == 0)
        {
                mem2[0] = 1;
        }
        
        val_32 = null;
        val_30 = 1152921504898486272;
        val_32 = null;
        PurchaseProxy.currentPurchasePoint = 0;
        if((PackagesManager.IsNonConsumable(purchase:  0)) != true)
        {
                this.PurchasedCredits(currentPurchase: ref  PurchaseModel val_12 = -1816737740);
        }
        
        UnityEngine.Debug.LogError(message:  -1816754048);
        label_18:
        val_33 = null;
        val_33 = null;
        if((App.inAppPurchasesManager.IsCashedIn(token:  purchaseInfo + 24)) != false)
        {
                val_34 = null;
            val_34 = null;
            val_28 = App.inAppPurchasesManager;
            if((val_28.IsTracked(token:  purchaseInfo + 24)) == true)
        {
                return;
        }
        
            WGBonusRewardsHandler val_15 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            val_28 = 0;
            ProcessPurchase(currentPurchase:  0, purchaseInfo:  purchaseInfo);
            return;
        }
        
        val_35 = 0;
        val_27 = val_30;
        Player val_16 = App.Player;
        mem[10] = 188;
        Player val_17 = App.Player;
        var val_18 = 2 + 12;
        val_36 = null;
        val_30 = val_26;
        val_26 = purchaseInfo;
        val_37 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        if(val_37 != null)
        {
                val_37 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
            if(val_37 == null)
        {
                val_37 = 0;
        }
        
            val_37.Invoke(purchase: ref  PurchaseModel val_19 = -1816737740);
            val_35 = 0;
        }
        
        RewardPlayerPurchase(purchase:  0);
        this.RegisterPurchase(purchase: ref  PurchaseModel val_20 = -1816737740);
        WGBonusRewardsHandler val_21 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        ProcessPurchase(currentPurchase:  0, purchaseInfo:  val_26);
        Player val_22 = Player;
        this.SaveState();
        WGBonusRewardsHandler val_23 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
        val_38 = null;
        val_38 = null;
        App.inAppPurchasesManager.ClearPurchaseFromPrefs();
        val_39 = null;
        val_39 = null;
        App.inAppPurchasesManager.AddCashedIn(token:  purchaseInfo + 24);
        AdsManager.HandlePurchase();
        val_28 = 1152921511025997392;
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandlePurchase();
        }
        
        val_40 = null;
        val_40 = null;
        if(PurchasesHandler.OnPurchaseCompleted == 0)
        {
                return;
        }
        
        PurchasesHandler.OnPurchaseCompleted.Invoke(obj:  0);
    }
    private void OnPurchaseFailed(NativePurchase purchase)
    {
        var val_4;
        var val_5;
        System.Action<PurchaseModel> val_6;
        var val_4 = 25923105;
        val_4 = 9702952 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(App.inAppPurchasesManager.currentPurchase == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_2 = System.String.Format(format:  -1816621312, arg0:  290787328, arg1:  purchase.errorString);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "Failed purchase: {0} Original Error Message: {1}";
        D.LogClientError(developer:  -1861586928, filter:  1788750208, context:  -1816580752, strings:  472754880);
        WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        TrackPurchaseFailed(model:  292597760, errorCode:  290787328, errorRaw:  purchase.errorString, errorString:  purchase.token);
        val_5 = null;
        val_5 = null;
        val_6 = PurchasesHandler.OnPurchaseFailure;
        if(val_6 == 0)
        {
                return;
        }
        
        val_6 = PurchasesHandler.OnPurchaseFailure;
        if(val_6 == 0)
        {
                val_6 = 0;
        }
        
        val_6.Invoke(obj:  292597760);
    }
    public static bool DeterminePackageType(string packageId)
    {
        if((packageId.Contains(value:  -1816464080)) != false)
        {
                return false;
        }
        
        bool val_2 = packageId.Contains(value:  -1816463984);
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    private void RegisterPurchase(ref PurchaseModel purchase)
    {
        var val_9;
        float val_32;
        float val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        Player val_1 = this.Player;
        Player val_2 = this.Player;
        if(purchase < 0)
        {
                Player val_3 = this.Player;
            mem[1152921511380461968] = purchase.id;
        }
        
        Player val_4 = this.Player;
        mem[1152921511380461972] = purchase.id;
        Player val_5 = this.Player;
        mem[1152921511380461976] = purchase.sale_price;
        Player val_6 = this.Player;
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        mem[1152921511380461960] = val_9;
        Player val_10 = this.Player;
        float val_31 = purchase.sale_price;
        val_31 = S16 + val_31;
        mem[1152921511380461988] = val_31;
        Player val_11 = this.Player;
        float val_32 = 100f;
        val_32 = purchase.sale_price * val_32;
        PurchaseModel val_33 = val_32;
        val_33 = purchase + val_33;
        mem[1152921511380461828] = val_33;
        Player val_12 = this.Player;
        Player val_13 = this.Player;
        if(this == 0)
        {
                mem[1152921511380462000] = purchase.sale_price;
        }
        else
        {
                Player val_14 = this.Player;
            Player val_15 = this.Player;
            Player val_16 = this.Player;
            val_32 = ???;
            val_33 = purchase.sale_price / (-1.81632E+09f);
            mem[1152921511380462000] = val_33;
        }
        
        Player val_17 = this.Player;
        if(this != 0)
        {
                val_34 = this;
        }
        else
        {
                val_34 = 200;
            val_35 = 188;
        }
        
        mem[200] = 189;
        Player val_18 = this.Player;
        Player val_19 = this.Player;
        float val_20 = System.Math.Max(val1:  val_33, val2:  null);
        mem[1152921511380462028] = S16;
        Player val_22 = this.Player;
        val_36 = this;
        val_37 = 1;
        if((System.String.IsNullOrEmpty(value:  val_32)) == true)
        {
            goto label_38;
        }
        
        val_37 = 0;
        if((System.String.op_Inequality(a:  val_32, b:  -1816751744)) == false)
        {
            goto label_37;
        }
        
        Player val_24 = this.Player;
        val_36 = this;
        label_38:
        mem[1152921511380462032] = val_37;
        label_37:
        GameEcon val_25 = App.getGameEcon;
        if(0 != 1)
        {
                GameBehavior val_26 = App.getBehavior;
            GameEcon val_27 = App.getGameEcon;
            val_36 = 0;
            if(0 >= 0)
        {
                Player val_28 = this.Player;
            mem[1152921511380461924] = 0;
        }
        
        }
        
        GameBehavior val_29 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        Player val_30 = this.Player;
        this.RemovedAds = true;
    }
    private void PurchasedCredits(ref PurchaseModel currentPurchase)
    {
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        twelvegigs.storage.JsonDictionary val_1 = this.GetPackage(id:  currentPurchase.id);
        decimal val_2 = GetTotalAmountByPackage(packageDictionary:  -1816197504, packageType:  -1816197504);
        currentPurchase.AddReward(rewardType:  2129282688, amount:  new System.Decimal() {flags = val_3, hi = val_4, lo = val_5, mid = val_6});
        float val_7 = this.getFloat(key:  -1816221696, defaultValue:  null);
        sale_price = 2478769792;
        string val_8 = currentPurchase.sale_price.ToString();
        string val_9 = this.getString(key:  -1816221600, defaultValue:  -1816209548);
        price = this;
    }
    protected override void AwakeLogic()
    {
        this.AwakeLogic();
        this.Initialize();
    }
    private void Initialize()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if(PurchasesHandler.initialized != false)
        {
                return;
        }
        
        var val_3 = 25921981;
        val_3 = 9704076 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1815965392, method:  new IntPtr(2478974832));
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1815965392, method:  new IntPtr(2478976880));
        App.inAppPurchasesManager.addPurchaseListener(successCallback:  7401472, errorCallback:  7401472);
        val_5 = null;
        val_5 = null;
        PurchasesHandler.initialized = true;
    }
    public PurchasesHandler()
    {
    
    }
    private static PurchasesHandler()
    {
    
    }

}
