using UnityEngine;
public class SuperBundleEventHandler : WGEventHandler
{
    // Fields
    public const string EVENT_ID = "SuperBundle";
    private const string packageLapse1 = "id_super_bundle_lapse1";
    private const string packageLapse2 = "id_super_bundle_lapse2";
    private const string packageLapse3 = "id_super_bundle_lapse3";
    private const string iapKey = "sb_iap";
    private const string iapLapse1 = "l1";
    private const string iapLapse2 = "l2";
    private const string iapLapse3 = "l3";
    private const string iapCoin = "c";
    private const string iapGold = "g";
    private const string expirePref = "sb_expire";
    private const string nextPref = "sb_next";
    private const string bundlePref = "sb_bundleID";
    private const string seenPref = "sb_seenB";
    private static SuperBundleEventHandler _Instance;
    public System.Action<bool> OnPurchaseAttemptResult;
    private int lapseDurationDays;
    private int bundleDurationMinutes;
    private int playerSpendLow;
    private int featureCooldownDays;
    private int promptCooldownSecs;
    private decimal coinBalanceCriterion;
    private PurchaseModel purchaseModel;
    private string priceUsual;
    private float discount;
    private int coinReward;
    private int goldReward;
    private bool isShowing;
    private System.DateTime nextPrompt;
    private TrackerPurchasePoints purchasePoint;
    
    // Properties
    public static SuperBundleEventHandler Instance { get; }
    private System.DateTime expireTime { get; set; }
    private System.DateTime nextTime { get; set; }
    private string currentBundleId { get; set; }
    private bool seenCurrentBundlePopup { get; set; }
    public PurchaseModel GetPurchaseModel { get; }
    public string GetUsualPrice { get; }
    public float GetDiscountPercent { get; }
    public int GetCoinReward { get; }
    public int GetGoldReward { get; }
    public System.DateTime GetBundleExpireTime { get; }
    public override bool OverrideEventButton { get; }
    public override bool IsEventHidden { get; }
    
    // Methods
    public static SuperBundleEventHandler get_Instance()
    {
    
    }
    private System.DateTime get_expireTime()
    {
        var val_4 = null;
        string val_1 = System.DateTime.MinValue.ToString();
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1003075328, defaultValue:  -1003063264);
        System.DateTime val_3 = SLCDateTime.Parse(dateTime:  -1003051232, defaultValue:  new System.DateTime() {dateData = 1152921512193706240});
        return new System.DateTime() {dateData = val_3.dateData};
    }
    private void set_expireTime(System.DateTime value)
    {
        string val_1 = ???.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1003075328, value:  -1002951256);
    }
    private System.DateTime get_nextTime()
    {
        var val_4 = null;
        string val_1 = System.DateTime.MinValue.ToString();
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1002851232, defaultValue:  -1002839168);
        System.DateTime val_3 = SLCDateTime.Parse(dateTime:  -1002827136, defaultValue:  new System.DateTime() {dateData = 1152921512193930336});
        return new System.DateTime() {dateData = val_3.dateData};
    }
    private void set_nextTime(System.DateTime value)
    {
        string val_1 = ???.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1002851232, value:  -1002727160);
    }
    private string get_currentBundleId()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1002627136, defaultValue:  1098586544);
    }
    private void set_currentBundleId(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1002627136, value:  value);
    }
    private bool get_seenCurrentBundlePopup()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1002394848, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    private void set_seenCurrentBundlePopup(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1002394848, value:  value);
    }
    public PurchaseModel get_GetPurchaseModel()
    {
    
    }
    public string get_GetUsualPrice()
    {
    
    }
    public float get_GetDiscountPercent()
    {
        return (float)S0;
    }
    public int get_GetCoinReward()
    {
        return (int)this.coinReward;
    }
    public int get_GetGoldReward()
    {
        return (int)this.goldReward;
    }
    public System.DateTime get_GetBundleExpireTime()
    {
        ulong val_2;
        SuperBundleEventHandler val_6;
        System.DateTime val_1 = expireTime;
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R1 + 8 + 40})) >= 0)
        {
                val_6 = mem[R1 + 8 + 40];
            val_6 = R1 + 8 + 40;
            this = val_6;
            return new System.DateTime() {dateData = val_5.dateData};
        }
        
        System.DateTime val_5 = this.expireTime;
        return new System.DateTime() {dateData = val_5.dateData};
    }
    public void TryPurchase()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        int val_10;
        int val_11;
        int val_12;
        int val_13;
        var val_15;
        var val_16;
        int val_17;
        int val_18;
        int val_19;
        int val_20;
        var val_21;
        var val_15 = 29414641;
        val_15 = 6211420 + val_15;
        if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        PurchaseProxy.currentPurchasePoint = this.purchasePoint;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                val_16 = 0;
            decimal val_3 = System.Decimal.op_Implicit(value:  -1001454032);
            val_17 = val_4;
            val_18 = val_5;
            val_19 = val_6;
            val_20 = val_7;
            val_21 = "gems";
        }
        else
        {
                val_16 = 0;
            decimal val_8 = System.Decimal.op_Implicit(value:  -1001454032);
            val_17 = val_4;
            val_18 = val_5;
            val_19 = val_6;
            val_20 = val_7;
            val_21 = "credits";
        }
        
        this.purchaseModel.AddReward(rewardType:  2129282688, amount:  new System.Decimal() {flags = val_17, hi = val_18, lo = val_19, mid = val_20});
        decimal val_9 = System.Decimal.op_Implicit(value:  -1001454048);
        this.purchaseModel.AddReward(rewardType:  -1825935328, amount:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_12, mid = val_13});
        bool val_14 = PurchaseProxy.Purchase(purchase:  this.purchaseModel);
    }
    public bool CanShowSuperBundleOnStoreOOCFlow()
    {
        this.UpdateStateLogic();
        if((this.CheckAndShowPopup(flyout:  true)) == true)
        {
                0 = 122;
            this.purchasePoint = 0;
            0 = 1;
        }
        
        return (bool)0;
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        mem[1152921512195588392] = eventV2;
        SuperBundleEventHandler._Instance = this;
        val_17 = "economy";
        if((eventV2.eventData.ContainsKey(key:  -1554533760)) != false)
        {
                object val_2 = eventV2.eventData.Item[-1554533760];
            val_18 = 0;
            val_19 = "rew";
            if((val_18.ContainsKey(key:  -1605526400)) != false)
        {
                val_20 = val_18;
            string val_4 = val_20.Item[-1605526400];
            val_20 = 0;
            string val_5 = val_20.Item[-1125333584];
            val_21 = val_20;
            val_19 = null;
            val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.playerSpendLow = 1179403647;
        }
        
            if((val_18.ContainsKey(key:  -1001217408)) != false)
        {
                string val_7 = val_18.Item[-1001217408];
            val_21 = val_18;
            val_19 = null;
            val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.lapseDurationDays = 1179403647;
        }
        
            if((val_18.ContainsKey(key:  -1125332832)) != false)
        {
                string val_9 = val_18.Item[-1125332832];
            val_21 = val_18;
            val_19 = null;
            val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.bundleDurationMinutes = 1179403647;
        }
        
            if((val_18.ContainsKey(key:  -1125332608)) != false)
        {
                string val_11 = val_18.Item[-1125332608];
            val_21 = val_18;
            val_19 = null;
            val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.featureCooldownDays = 1179403647;
        }
        
            if((val_18.ContainsKey(key:  -1125332720)) != false)
        {
                string val_13 = val_18.Item[-1125332720];
            val_21 = val_18;
            val_19 = null;
            val_21.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.promptCooldownSecs = 1179403647;
        }
        
            val_17 = "coin_balance_criteria";
            if((val_18.ContainsKey(key:  -1001217296)) != false)
        {
                string val_15 = val_18.Item[-1001217296];
            val_18 = val_18;
            val_22 = null;
            val_18.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            decimal val_16 = System.Decimal.op_Implicit(value:  -1001205248);
        }
        
        }
        
        this.UpdateStateLogic();
    }
    public override void OnPurchaseFailure(PurchaseModel purchase)
    {
        if((purchase.id.Contains(value:  -1001088800)) == false)
        {
                return;
        }
        
        this.OnPurchaseFail();
    }
    public override void OnPurchaseCompleted(PurchaseModel purchase)
    {
        if((purchase.id.Contains(value:  -1001088800)) != false)
        {
                this.OnPurchaseSuccess();
            return;
        }
        
        this.UpdateStateLogic();
    }
    public override void OnProcessPurchase(ref PurchaseModel purchased)
    {
        var val_11;
        var val_12;
        var val_13;
        float val_14;
        float val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_11 = 1152921512196001456;
        if((purchased.id.Contains(value:  -1001088800)) == false)
        {
            goto label_36;
        }
        
        System.Collections.IList val_2 = PackagesManager.GetPackages(packageType:  2129282688);
        string val_10 = "credits";
        if(0 == 0)
        {
            goto label_7;
        }
        
        val_12 = 0;
        label_9:
        if((R3 + 0) == null)
        {
            goto label_8;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < 0)
        {
            goto label_9;
        }
        
        label_7:
        val_13 = "credits";
        goto label_10;
        label_8:
        var val_3 = R3 + 0;
        val_10 = val_10 + (((R3 + 0) + 4) << 3);
        val_13 = val_10 + 188;
        label_10:
        val_14 = 1152921504683417600;
        val_15 = 1152921504899444736;
        label_29:
        string val_11 = "credits";
        if(null == null)
        {
            goto label_12;
        }
        
        val_12 = 0;
        label_14:
        if((R3 + 0) == null)
        {
            goto label_13;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < null)
        {
            goto label_14;
        }
        
        label_12:
        val_16 = "credits";
        goto label_15;
        label_13:
        var val_4 = R3 + 0;
        val_11 = val_11 + (((R3 + 0) + 4) << 3);
        val_16 = val_11 + 188;
        label_15:
        if("credits" == 0)
        {
            goto label_16;
        }
        
        string val_13 = "credits";
        if(null == null)
        {
            goto label_18;
        }
        
        var val_12 = 0;
        label_20:
        if((R3 + 0) == null)
        {
            goto label_19;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < null)
        {
            goto label_20;
        }
        
        label_18:
        val_17 = "credits";
        goto label_21;
        label_19:
        var val_5 = R3 + 0;
        val_13 = val_13 + (((R3 + 0) + 4) << 3);
        val_17 = val_13 + 196;
        label_21:
        if("credits" != 0)
        {
                if(null == null)
        {
            goto label_30;
        }
        
        }
        
        label_30:
        PurchaseModel val_6 = new PurchaseModel(json:  0);
        if((System.String.op_Equality(a:  -1716807968, b:  purchased.id)) == false)
        {
            goto label_29;
        }
        
        sale_price = PurchaseModel.__il2cppRuntimeField_static_fields;
        goto label_29;
        label_16:
        val_11 = 0;
        val_18 = 1152921504619679744;
        if("credits" == 0)
        {
            goto label_31;
        }
        
        string val_14 = "credits";
        if(null == null)
        {
            goto label_32;
        }
        
        val_12 = 0;
        label_34:
        val_18 = 0;
        if((R3 + 0) == null)
        {
            goto label_33;
        }
        
        val_12 = val_12 + 1;
        val_18 = (uint)val_12 & 65535;
        if(val_18 < null)
        {
            goto label_34;
        }
        
        label_32:
        val_19 = "credits";
        goto label_35;
        label_33:
        var val_8 = R3 + 0;
        val_14 = val_14 + (((R3 + 0) + 4) << 3);
        val_19 = val_14 + 188;
        label_35:
        label_31:
        label_36:
        var val_9 = FP - 28;
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = Localization.Localize(key:  -1001088800, defaultValue:  -1000720096, useSingularKey:  false);
        string val_2 = this.purchaseModel.LocalPrice;
        return System.String.Format(format:  -1826949520, arg0:  -1001088800, arg1:  this.purchaseModel);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1001088800, defaultValue:  -1000720096, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        ulong val_2;
        var val_3;
        long val_8;
        var val_9;
        var val_15;
        decimal val_16;
        var val_17;
        var val_18;
        var val_20;
        System.DateTime val_1 = expireTime;
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R6 + 40})) >= 0)
        {
                val_16 = this.coinBalanceCriterion;
        }
        else
        {
                System.DateTime val_5 = expireTime;
            val_16 = val_2;
            val_15 = val_3;
        }
        
        System.DateTime val_6 = DateTimeCheat.UtcNow;
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512196305704}, d2:  new System.DateTime() {dateData = val_16});
        val_17 = null;
        val_17 = null;
        val_18 = val_9;
        if((System.TimeSpan.Compare(t1:  new System.TimeSpan() {_ticks = val_8}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) > 1)
        {
            
        }
        else
        {
                val_20 = null;
            val_20 = null;
        }
        
        val_2 = System.TimeSpan.__il2cppRuntimeField_static_fields.Days;
        val_8 = System.TimeSpan.__il2cppRuntimeField_static_fields.Hours;
        int val_13 = System.TimeSpan.__il2cppRuntimeField_static_fields.Minutes;
        string val_14 = System.String.Format(format:  -1662255760, arg0:  13152256, arg1:  13152256, arg2:  13152256);
    }
    public override System.DateTime GetTimeEnd()
    {
        ulong val_2;
        SuperBundleEventHandler val_6;
        System.DateTime val_1 = expireTime;
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R1 + 8 + 40})) >= 0)
        {
                val_6 = mem[R1 + 8 + 40];
            val_6 = R1 + 8 + 40;
            this = val_6;
            return new System.DateTime() {dateData = val_5.dateData};
        }
        
        System.DateTime val_5 = this.expireTime;
        return new System.DateTime() {dateData = val_5.dateData};
    }
    public override void OnGameSceneBegan()
    {
        this.UpdateStateLogic();
        bool val_1 = this.CheckAndShowPopup(flyout:  false);
        if(val_1 == true)
        {
                val_1 = 106;
            this.purchasePoint = val_1;
        }
    
    }
    public override void OnMenuLoaded()
    {
        this.UpdateStateLogic();
        bool val_1 = this.CheckAndShowPopup(flyout:  false);
        if(val_1 == true)
        {
                val_1 = 105;
            this.purchasePoint = val_1;
        }
    
    }
    public override void OnGameButtonPressed(bool connected)
    {
        this.purchasePoint = 107;
        this.ShowPopup(flyout:  false);
    }
    public override bool get_OverrideEventButton()
    {
        return true;
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        this.purchasePoint = 105;
        this.ShowPopup(flyout:  false);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader == 0)
        {
            
        }
    
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        if(this.purchaseModel == 0)
        {
                return;
        }
        
        AppConfigs val_1 = App.Configuration;
        ProductDetails val_2 = 0.GetProductByInternalId(internalId:  this.purchaseModel.id);
        if(0 != 0)
        {
                0 = 0;
        }
        
        if(0 == 0)
        {
                0 = 0;
        }
        
        currentData.Add(key:  -1266461696, value:  0);
    }
    public override bool get_IsEventHidden()
    {
        bool val_1 = this.isShowing;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public override void OnMyEventPopupClosed()
    {
        this.UpdateStateLogic();
        this.OnMyEventPopupClosed();
        this.UpdateProgress();
    }
    public override string GetHackPanelEventData()
    {
        float val_3;
        bool val_13;
        object val_89;
        object val_90;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        string val_5 = val_3.ToString();
        string val_6 = System.String.Format(format:  -999213984, arg0:  -999199400);
        System.Text.StringBuilder val_7 = AppendLine(value:  -999213984);
        string val_9 = seenCurrentBundlePopup.ToString();
        string val_10 = System.String.Format(format:  -999213888, arg0:  -999199401);
        System.Text.StringBuilder val_11 = AppendLine(value:  -999213888);
        System.DateTime val_12 = expireTime;
        string val_15 = val_13.ToString();
        string val_16 = System.String.Format(format:  -999213760, arg0:  -999199400);
        System.Text.StringBuilder val_17 = AppendLine(value:  -999213760);
        object val_18 = R5 + 40;
        string val_19 = val_18.ToString();
        string val_20 = System.String.Format(format:  -999213632, arg0:  val_18);
        System.Text.StringBuilder val_21 = AppendLine(value:  -999213632);
        System.DateTime val_22 = nextTime;
        string val_23 = ???.ToString();
        string val_24 = System.String.Format(format:  -999213520, arg0:  -999199400);
        System.Text.StringBuilder val_25 = AppendLine(value:  -999213520);
        string val_26 = this.isShowing.ToString();
        string val_27 = System.String.Format(format:  -999213408, arg0:  this.isShowing);
        System.Text.StringBuilder val_28 = AppendLine(value:  -999213408);
        string val_29 = this.nextPrompt.ToString();
        string val_30 = System.String.Format(format:  -999213296, arg0:  this.nextPrompt);
        System.Text.StringBuilder val_31 = AppendLine(value:  -999213296);
        string val_33 = BeforeExpire().ToString();
        string val_34 = System.String.Format(format:  -999213184, arg0:  -999199401);
        System.Text.StringBuilder val_35 = AppendLine(value:  -999213184);
        string val_37 = isReadyForNext().ToString();
        string val_38 = System.String.Format(format:  -999213072, arg0:  -999199401);
        System.Text.StringBuilder val_39 = AppendLine(value:  -999213072);
        string val_40 = this.ToString();
        string val_41 = System.String.Format(format:  -999212944, arg0:  -999199401);
        System.Text.StringBuilder val_42 = AppendLine(value:  -999212944);
        string val_44 = this.readyToShowPopup().ToString();
        string val_45 = System.String.Format(format:  -999212848, arg0:  -999199401);
        System.Text.StringBuilder val_46 = AppendLine(value:  -999212848);
        string val_47 = currentBundleId;
        bool val_48 = System.String.IsNullOrEmpty(value:  24121344);
        if(val_48 != false)
        {
                val_89 = "not set";
        }
        else
        {
                string val_49 = val_48.currentBundleId;
            val_89 = val_48;
        }
        
        string val_50 = System.String.Format(format:  -999212736, arg0:  val_89);
        System.Text.StringBuilder val_51 = AppendLine(value:  -999212736);
        string val_52 = currentBundleId;
        if((System.String.IsNullOrEmpty(value:  24121344)) != false)
        {
                val_90 = "not set";
        }
        else
        {
                AppConfigs val_54 = App.Configuration;
            string val_55 = this.currentBundleId;
            ProductDetails val_56 = 0.GetProductByInternalId(internalId:  null);
            if(0 == 0)
        {
            goto label_40;
        }
        
            val_90 = 0 + 12;
        }
        
        label_40:
        string val_57 = System.String.Format(format:  -999212608, arg0:  val_90);
        System.Text.StringBuilder val_58 = AppendLine(value:  -999212608);
        val_13 = this.isLapsedOrNonPurchaser();
        string val_60 = System.String.Format(format:  -999212480, arg0:  8945664);
        System.Text.StringBuilder val_61 = AppendLine(value:  -999212480);
        bool val_62 = this.isUnderCoinLimit();
        string val_63 = System.String.Format(format:  -999212368, arg0:  8945664);
        System.Text.StringBuilder val_64 = AppendLine(value:  -999212368);
        Player val_65 = App.Player;
        float val_89 = 100f;
        val_89 = (5.605194E-45f) * val_89;
        val_3 = val_89;
        string val_66 = System.String.Format(format:  -999212240, arg0:  15282176);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_67 = AppendLine(value:  -999212240);
        }
        else
        {
                System.Text.StringBuilder val_68 = AppendLine(value:  -999212240);
        }
        
        System.Text.StringBuilder val_69 = AppendLine(value:  -999212112);
        string val_70 = this.lapseDurationDays.ToString();
        string val_71 = System.String.Format(format:  -999212000, arg0:  this.lapseDurationDays);
        System.Text.StringBuilder val_72 = AppendLine(value:  -999212000);
        string val_73 = this.bundleDurationMinutes.ToString();
        string val_74 = System.String.Format(format:  -999211904, arg0:  this.bundleDurationMinutes);
        System.Text.StringBuilder val_75 = AppendLine(value:  -999211904);
        string val_76 = this.playerSpendLow.ToString();
        string val_77 = System.String.Format(format:  -999211792, arg0:  this.playerSpendLow);
        System.Text.StringBuilder val_78 = AppendLine(value:  -999211792);
        string val_79 = this.featureCooldownDays.ToString();
        string val_80 = System.String.Format(format:  -999211696, arg0:  this.featureCooldownDays);
        System.Text.StringBuilder val_81 = AppendLine(value:  -999211696);
        string val_82 = this.promptCooldownSecs.ToString();
        string val_83 = System.String.Format(format:  -999211584, arg0:  this.promptCooldownSecs);
        System.Text.StringBuilder val_84 = AppendLine(value:  -999211584);
        string val_85 = this.coinBalanceCriterion.ToString();
        string val_86 = System.String.Format(format:  -999211472, arg0:  this.coinBalanceCriterion);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_87 = AppendLine(value:  -999211472);
            return;
        }
        
        System.Text.StringBuilder val_88 = AppendLine(value:  -999211472);
    }
    private bool CheckAndShowPopup(bool flyout = False)
    {
        long val_6;
        System.DateTime val_10;
        if(this.isShowing == false)
        {
                return (bool)0;
        }
        
        bool val_1 = this.readyToShowPopup();
        if(flyout == false)
        {
                return (bool)0;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_3 = System.TimeSpan.FromSeconds(value:  null);
        System.DateTime val_8 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512197694160}, t:  new System.TimeSpan() {_ticks = val_6});
        this.nextPrompt = val_10;
        this.ShowPopup(flyout:  flyout);
        0 = 1;
        return (bool)0;
    }
    private void ShowPopup(bool flyout = False)
    {
        ulong val_4;
        long val_6;
        bool val_1 = this.seenCurrentBundlePopup;
        if(val_1 != true)
        {
                val_1.seenCurrentBundlePopup = true;
            System.DateTime val_2 = DateTimeCheat.UtcNow;
            System.TimeSpan val_3 = System.TimeSpan.FromMinutes(value:  null);
            35625883 = 0;
            System.DateTime val_8 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512197808208}, t:  new System.TimeSpan() {_ticks = val_6});
            val_8.dateData.expireTime = new System.DateTime() {dateData = val_4};
        }
        
        if(flyout != false)
        {
                GameBehavior val_11 = App.getBehavior;
            if(0 != 0)
        {
                return;
        }
        
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_14 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void UpdateStateLogic()
    {
        ulong val_9;
        long val_11;
        var val_18;
        bool val_1 = this.BeforeExpire();
        if(val_1 == true)
        {
            goto label_1;
        }
        
        bool val_2 = val_1.isReadyForNext();
        if(val_2 == false)
        {
            goto label_6;
        }
        
        label_1:
        bool val_3 = val_2.BeforeExpire();
        if((val_3 == true) || (val_3.isReadyForNext() == false))
        {
            goto label_4;
        }
        
        if(this.isLapsedOrNonPurchaser() == false)
        {
            goto label_6;
        }
        
        bool val_6 = this.isUnderCoinLimit();
        if(val_6 == false)
        {
            goto label_6;
        }
        
        val_6.seenCurrentBundlePopup = false;
        val_18 = null;
        val_18 = null;
        System.DateTime.MaxValue.expireTime = new System.DateTime() {dateData = System.DateTime.__il2cppRuntimeField_cctor_finished};
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        System.TimeSpan val_8 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_13 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512197924304}, t:  new System.TimeSpan() {_ticks = val_11});
        val_13.dateData.nextTime = new System.DateTime() {dateData = val_9};
        this.DetermineBundle();
        this.SetNotification();
        goto label_13;
        label_4:
        bool val_16 = val_3.BeforeExpire();
        if(val_16 == false)
        {
                return;
        }
        
        string val_17 = val_16.currentBundleId;
        this.SetPurchaseModel(PackageID:  val_16);
        if(this.purchaseModel == 0)
        {
                this.purchaseModel = this;
            this.DetermineBundle();
        }
        
        label_13:
        this.isShowing = true;
        return;
        label_6:
        this.KillBundle();
    }
    private void KillBundle()
    {
        this.isShowing = false;
        currentBundleId = 1098586544;
        CancelNotification();
    }
    private bool BeforeExpire()
    {
        ulong val_3;
        ulong val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.DateTime val_2 = expireTime;
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_5}, t2:  new System.DateTime() {dateData = val_3})) < 1)
        {
                0 = 1;
        }
        
        return true;
    }
    private bool isReadyForNext()
    {
        ulong val_3;
        ulong val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.DateTime val_2 = nextTime;
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_5}, t2:  new System.DateTime() {dateData = val_3})) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    private bool readyToShowPopup()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = this.nextPrompt})) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    private bool isLapsedOrNonPurchaser()
    {
        ulong val_8;
        ulong val_10;
        var val_13;
        var val_14;
        val_13 = 1152921504892043264;
        Player val_1 = App.Player;
        if(188 >= 1)
        {
                Player val_2 = App.Player;
            val_13 = 264;
            System.TimeSpan val_3 = System.TimeSpan.FromDays(value:  null);
            System.DateTime val_6 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512198488408}, t:  new System.TimeSpan() {_ticks = 264});
            System.DateTime val_7 = DateTimeCheat.UtcNow;
            if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_8})) < 1)
        {
                val_14 = 1;
        }
        
            return (bool)val_14;
        }
        
        val_14 = 1;
        return (bool)val_14;
    }
    private bool isUnderCoinLimit()
    {
        var val_7;
        decimal val_8;
        int val_10;
        int val_11;
        int val_12;
        var val_13;
        int val_14;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                Player val_3 = App.Player;
            val_7 = 0;
            decimal val_4 = System.Decimal.op_Implicit(value:  -998181172);
            val_8 = this.coinBalanceCriterion;
            return (bool)System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_12, mid = 256}, d2:  new System.Decimal() {flags = mem[this.coinBalanceCriterion + (0)], hi = mem[this.coinBalanceCriterion + (4)], lo = mem[this.coinBalanceCriterion + (8)], mid = this});
        }
        
        Player val_5 = App.Player;
        var val_6 = 0 + 60;
        val_8 = 256;
        val_14 = mem[(0 + 60) + (0)];
        val_11 = mem[(0 + 60) + (4)];
        val_10 = val_14;
        val_12 = mem[(0 + 60) + (8)];
        val_13 = val_8;
        return (bool)System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_12, mid = 256}, d2:  new System.Decimal() {flags = mem[this.coinBalanceCriterion + (0)], hi = mem[this.coinBalanceCriterion + (4)], lo = mem[this.coinBalanceCriterion + (8)], mid = this});
    }
    private void SetPurchaseModel(string PackageID)
    {
        var val_10;
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageById(packageId:  PackageID);
        if(PackageID == null)
        {
                return;
        }
        
        this.purchaseModel = new PurchaseModel(json:  PackageID);
        string val_3 = PackageID.getString(key:  -1403597104, defaultValue:  1098586544);
        twelvegigs.storage.JsonDictionary val_4 = PackagesManager.GetPackageById(packageId:  PackageID);
        PurchaseModel val_5 = new PurchaseModel(json:  PackageID);
        if(val_5 != 0)
        {
                string val_6 = LocalPrice;
            this.priceUsual = val_5;
        }
        else
        {
                string val_7 = LocalPrice;
            this.priceUsual = val_5;
        }
        
        val_10 = 292601856;
        void* val_8 = PurchaseModel.__il2cppRuntimeField_static_fields - this.purchaseModel.sale_price;
        val_8 = val_8 / PurchaseModel.__il2cppRuntimeField_static_fields;
        val_8 = val_8 * 100f;
        this.discount = (float)UnityEngine.Mathf.RoundToInt(f:  val_8);
        this.SetRewards(PackageID:  PackageID);
    }
    private void SetRewards(string PackageID)
    {
        var val_17;
        var val_18;
        var val_19;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_20;
        var val_21;
        var val_22;
        var val_23;
        if((System.String.op_Equality(a:  PackageID, b:  -997948640)) != false)
        {
                val_17 = "l3";
        }
        else
        {
                if((System.String.op_Equality(a:  PackageID, b:  -997948528)) == true)
        {
                val_17 = "l2";
        }
        
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = null;
        val_18 = val_3;
        val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        GameEcon val_4 = App.getGameEcon;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = 0.GetGameplayKnobs();
        if((0.ContainsKey(key:  -997948416)) != false)
        {
                GameEcon val_7 = App.getGameEcon;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = 0.GetGameplayKnobs();
            val_19 = 1152921504685600768;
            string val_9 = 0.Item[-997948416];
            val_20 = null;
            val_18 = 0;
        }
        else
        {
                val_19 = 1152921504685600768;
            val_20 = null;
        }
        
        val_21 = val_20;
        val_20 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if((val_18.ContainsKey(key:  -1125090240)) == false)
        {
            goto label_17;
        }
        
        string val_11 = val_18.Item[-1125090240];
        if(val_18 != 0)
        {
                val_21 = val_18;
        }
        
        label_23:
        val_21 = 0;
        val_22 = 1;
        goto label_22;
        label_17:
        if(val_21 == 0)
        {
            goto label_23;
        }
        
        val_22 = 0;
        label_22:
        if((ContainsKey(key:  -1785508240)) != false)
        {
                string val_13 = Item[-1785508240];
            val_23 = val_21;
            val_18 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921512198857300] = null;
        }
        
        if((ContainsKey(key:  -1968282976)) == false)
        {
                return;
        }
        
        string val_15 = Item[-1968282976];
        val_23 = val_21;
        val_21 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem[1152921512198857304] = null;
    }
    private void DetermineBundle()
    {
        var val_2;
        var val_3;
        val_2 = "id_super_bundle_lapse1";
        Player val_1 = App.Player;
        float val_2 = 100f;
        val_2 = (5.605194E-45f) * val_2;
        if(0 >= 0)
        {
            goto label_4;
        }
        
        if(0 <= 0)
        {
            goto label_5;
        }
        
        val_3 = "id_super_bundle_lapse2";
        goto label_6;
        label_4:
        val_3 = "id_super_bundle_lapse3";
        label_6:
        label_5:
        currentBundleId = -997948640;
        this.SetPurchaseModel(PackageID:  -997948640);
    }
    private void OnPurchaseSuccess()
    {
        SLC.Social.Leagues.LeaguesManager.OnAppleAwarded(appleAwarded:  this.goldReward);
        this.TrackPurchaseMade();
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_2 = System.TimeSpan.FromMinutes(value:  null);
        System.DateTime val_3 = System.DateTime.op_Subtraction(d:  new System.DateTime() {dateData = 1152921512199077496}, t:  new System.TimeSpan());
        val_3.dateData.expireTime = new System.DateTime();
        System.DateTime val_6 = DateTimeCheat.UtcNow;
        System.TimeSpan val_7 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_8 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512199077472}, t:  new System.TimeSpan());
        val_8.dateData.nextTime = new System.DateTime();
        this.KillBundle();
        this.UpdateStateLogic();
        this.OnPurchaseAttemptResult.Invoke(obj:  true);
        this.UpdateProgress();
    }
    private void TrackPurchaseMade()
    {
        var val_2;
        string val_1 = this.purchaseModel.id.Replace(oldValue:  -997591648, newValue:  -997591744);
        var val_2 = 29400198;
        val_2 = 6225340 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        App.trackerManager.track(eventName:  this.purchaseModel.id);
    }
    private void OnPurchaseFail()
    {
        this.OnPurchaseAttemptResult.Invoke(obj:  false);
    }
    private void SetNotification()
    {
        ulong val_2;
        var val_3;
        string val_12;
        var val_13;
        decimal val_14;
        System.DateTime val_1 = expireTime;
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R6 + 40})) >= 0)
        {
                val_14 = this.coinBalanceCriterion;
        }
        else
        {
                System.DateTime val_5 = expireTime;
            val_14 = val_2;
            val_13 = val_3;
        }
        
        System.TimeSpan val_6 = System.TimeSpan.FromHours(value:  null);
        System.DateTime val_7 = System.DateTime.op_Subtraction(d:  new System.DateTime() {dateData = 1152921512199442560}, t:  new System.TimeSpan() {_ticks = val_14});
        System.DateTime val_10 = ToLocalTime();
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  27, when:  new System.DateTime(), optMessage:  val_12, extraData:  "Your Super Bundle Offer is bursting with Coins! Collect Now!");
    }
    private void CancelNotification()
    {
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  27);
    }
    public SuperBundleEventHandler()
    {
        var val_2;
        this.promptCooldownSecs = 120;
         = new System.Decimal(value:  3500);
        val_2 = null;
        val_2 = null;
        this.nextPrompt = System.DateTime.MinValue;
    }

}
