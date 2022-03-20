using UnityEngine;
public class PiggyBankHandler : WGEventHandler
{
    // Fields
    private static PiggyBankHandler _Instance;
    public const string PIGGY_BANK_EVENT_ID = "PiggyBank";
    private const string piggyBankDataKey = "pbEventData";
    private const string pbNextReceiveKey = "pbNextReceive";
    private const string pbLastCollectedKey = "pbLastRewardCollected";
    private const string pbCurrencyGainedKey = "pbCurrencyGained";
    private const string pbCurrencyPendingKey = "pbCurrencyPending";
    private const string pbCurrencyTargetKey = "pbCurrencyTarget";
    private const string pbExpireTimeKey = "pbExpireTime";
    private const string pbPackageIDKey = "pbPackageID";
    private const string pbPackageNameKey = "pbPackageName";
    private const string pbCoinRewardKey = "pbCoinReward";
    private const string pbGoldRewardKey = "pbGoldReward";
    private const string pbIsTriggeredKey = "pbIsTriggered";
    private const string pbLastProgressKey = "pbLastProgress";
    private const string eventEconomy = "economy";
    private const string eventSpend = "spend_cents";
    private const string eventLevels = "levels";
    private const string eventObjective = "objective_golden";
    private const string eventCriteria = "criteria";
    private const string eventCoinBalance = "coins_balance";
    private const string eventDailySpent = "coins_spent";
    private const string eventLapse = "lapse_purchase_days";
    private const string eventExpire = "bundle_expire_minutes";
    private const string eventpromptCooldown = "prompt_cool_seconds";
    private const string eventFeatureCooldown = "feature_cool_days";
    private const string eventLow = "low";
    private const string eventMid = "mid";
    private const string eventHigh = "high";
    private const string packageNonBuyer = "id_piggy_bank_nonbuyer";
    private const string packageLapse1 = "id_piggy_bank_lapse1";
    private const string packageLapse2 = "id_piggy_bank_lapse2";
    private const string packageLapse3 = "id_piggy_bank_lapse3";
    private const string iapKey = "pb_iap";
    private const string iapNonBuyer = "non";
    private const string iapLapse1 = "l1";
    private const string iapLapse2 = "l2";
    private const string iapLapse3 = "l3";
    private const string iapCoin = "c";
    private const string iapGold = "g";
    private const string iapUsualPrice = "u_p";
    private const string iapDiscount = "d_pc";
    private const string iapLow = "l";
    private const string iapMid = "m";
    private const string iapHigh = "h";
    private int playerSpendLow;
    private int playerSpendHigh;
    private int playerLevelLow;
    private int playerLevelHigh;
    private int goldCurrencyTargetLow;
    private int goldCurrencyTargetMid;
    private int goldCurrencyTargetHigh;
    private double lapseDurationDays;
    private decimal coinBalanceCriterion;
    private decimal dailyCoinSpentCriterion;
    private double bundleDurationMinutes;
    private double promptCooldownSeconds;
    private double featureCooldownDays;
    private int <GoldCurrencyGained>k__BackingField;
    private int goldCurrencyTarget;
    private int GoldCurrencyPending;
    private System.DateTime piggyBankNextReceiveTime;
    private System.DateTime bundleExpireTime;
    private bool isTriggered;
    private string <PackageName>k__BackingField;
    private string <PackageID>k__BackingField;
    private decimal <CoinReward>k__BackingField;
    private int <GoldReward>k__BackingField;
    private string PriceUsual;
    private int <Discount>k__BackingField;
    private PurchaseModel purchaseModel;
    private bool <BundleReady>k__BackingField;
    private int <GoldCurrencyGainedOld>k__BackingField;
    private bool <EventEnded>k__BackingField;
    private System.DateTime promptCooldownTime;
    private System.TimeSpan lastCoinSpentDuration;
    private TrackerPurchasePoints purchasePoint;
    private int priceUsualLocalized;
    public static bool hackIgnoreLastPurchase;
    private int unlockLevel;
    public System.Action<bool> OnPurchaseAttemptResult;
    private bool shownApplicationLoadedAdvert;
    
    // Properties
    public static PiggyBankHandler Instance { get; }
    public int GoldCurrencyGained { get; set; }
    public int GoldCurrencyTarget { get; }
    public System.DateTime BundleExpireTime { get; }
    public string PackageName { get; set; }
    public string PackageID { get; set; }
    public decimal CoinReward { get; set; }
    public int GoldReward { get; set; }
    public int Discount { get; set; }
    public bool BundleReady { get; set; }
    public int GoldCurrencyGainedOld { get; set; }
    public bool EventEnded { get; set; }
    public string PricePurchaseString { get; }
    public string PriceUsualString { get; }
    private static int LastProgressTimestampPref { get; set; }
    public override bool SupportsGoldenApples { get; }
    public override bool IsEventHidden { get; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static PiggyBankHandler get_Instance()
    {
    
    }
    public int get_GoldCurrencyGained()
    {
        return (int)this.<GoldCurrencyGained>k__BackingField;
    }
    private void set_GoldCurrencyGained(int value)
    {
        this.<GoldCurrencyGained>k__BackingField = value;
    }
    public int get_GoldCurrencyTarget()
    {
        return (int)this.goldCurrencyTarget;
    }
    public System.DateTime get_BundleExpireTime()
    {
        this = R1 + 136;
        return new System.DateTime() {dateData = 1152921512063417584};
    }
    public string get_PackageName()
    {
    
    }
    private void set_PackageName(string value)
    {
        this.<PackageName>k__BackingField = value;
    }
    public string get_PackageID()
    {
    
    }
    private void set_PackageID(string value)
    {
        this.<PackageID>k__BackingField = value;
    }
    public decimal get_CoinReward()
    {
        return new System.Decimal() {flags = -1132771216, hi = R1 + 156};
    }
    private void set_CoinReward(decimal value)
    {
    
    }
    public int get_GoldReward()
    {
        return (int)this.<GoldReward>k__BackingField;
    }
    private void set_GoldReward(int value)
    {
        this.<GoldReward>k__BackingField = value;
    }
    public int get_Discount()
    {
        return (int)this.<Discount>k__BackingField;
    }
    private void set_Discount(int value)
    {
        this.<Discount>k__BackingField = value;
    }
    public bool get_BundleReady()
    {
        return (bool)this.<BundleReady>k__BackingField;
    }
    private void set_BundleReady(bool value)
    {
        this.<BundleReady>k__BackingField = value;
    }
    public int get_GoldCurrencyGainedOld()
    {
        return (int)this.<GoldCurrencyGainedOld>k__BackingField;
    }
    private void set_GoldCurrencyGainedOld(int value)
    {
        this.<GoldCurrencyGainedOld>k__BackingField = value;
    }
    public bool get_EventEnded()
    {
        return (bool)this.<EventEnded>k__BackingField;
    }
    private void set_EventEnded(bool value)
    {
        this.<EventEnded>k__BackingField = value;
    }
    public string get_PricePurchaseString()
    {
        if(this.purchaseModel != 0)
        {
                return this.purchaseModel.LocalPrice;
        }
        
        return this.purchaseModel.LocalPrice;
    }
    public string get_PriceUsualString()
    {
    
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1131210832, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1131210832, value:  value);
    }
    public override bool get_SupportsGoldenApples()
    {
        return true;
    }
    public override bool get_IsEventHidden()
    {
        bool val_1 = this.isTriggered;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public override bool get_IsEventValid()
    {
        Player val_1 = App.Player;
        if(0 >= this.unlockLevel)
        {
                0 = 1;
        }
        
        return true;
    }
    public override void Init(GameEventV2 eventV2)
    {
        System.DateTime val_3;
        System.DateTime val_10;
        var val_11;
        var val_12;
        val_10 = 35638686;
        mem[1152921512066163032] = eventV2;
        PiggyBankHandler.iapHigh = this;
        this.ParseEventData(eventData:  eventV2.eventData);
        if(this.IsEventAvailable() == false)
        {
            goto label_2;
        }
        
        this.LoadData();
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        this.promptCooldownTime = val_3;
        this.<GoldCurrencyGainedOld>k__BackingField = this.<GoldCurrencyGained>k__BackingField;
        if(val_3.HasExistingData() != false)
        {
                if((this.HasExpired() != true) && (this.isTriggered != false))
        {
                GameBehavior val_7 = App.getBehavior;
            if(0 != 1)
        {
                return;
        }
        
            return;
        }
        
        }
        
        this.ResetSaveData();
        val_11 = eventV2;
        if(eventV2 == 0)
        {
                if(val_11 == 0)
        {
            goto label_15;
        }
        
        }
        
        val_10 = eventV2.timeEnd;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = eventV2.lastTimestamp}, t2:  new System.DateTime() {dateData = val_10})) == false)
        {
            goto label_18;
        }
        
        label_2:
        this.<EventEnded>k__BackingField = true;
        return;
        label_18:
        this.GoldCurrencyPending = 0;
        this.<GoldCurrencyGained>k__BackingField = 0;
        this.<GoldCurrencyGainedOld>k__BackingField = 0;
        this.<BundleReady>k__BackingField = 0;
        val_12 = null;
        val_12 = null;
        this.bundleExpireTime = System.DateTime.MaxValue;
        this.isTriggered = false;
        this.SaveData();
        GameBehavior val_9 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        return;
        label_15:
    }
    public override void OnPurchaseFailure(PurchaseModel purchase)
    {
        if((purchase.id.Contains(value:  -1130514160)) == false)
        {
                return;
        }
        
        this.OnPurchaseFail();
    }
    public override void OnPurchaseCompleted(PurchaseModel purchase)
    {
        if((purchase.id.Contains(value:  -1130514160)) == false)
        {
                return;
        }
        
        this.OnPurchaseSuccess();
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
        val_11 = 1152921512066576096;
        if((purchased.id.Contains(value:  -1130514160)) == false)
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
    public override void OnAppleAwarded(int appleAwarded)
    {
        if((this.<BundleReady>k__BackingField) == true)
        {
                return;
        }
        
        if(this.isTriggered == false)
        {
                return;
        }
        
        if((this.<EventEnded>k__BackingField) != false)
        {
                return;
        }
        
        appleAwarded = this.GoldCurrencyPending + appleAwarded;
        this.GoldCurrencyPending = appleAwarded;
        this.SaveData();
    }
    public override void OnGameSceneBegan()
    {
        if(this.isTriggered == false)
        {
                this.isTriggered = this.<EventEnded>k__BackingField;
            goto label_0;
        }
        
        return;
        label_0:
        if(this.HasLapsedPurchase() == false)
        {
                return;
        }
        
        if(this.HasPassedCoinCriteria() == false)
        {
                return;
        }
        
        if(this == 0)
        {
                return;
        }
        
        R4.DetermineBundle(eventData:  typeof(PiggyBankHandler).__il2cppRuntimeField_F0);
        R4.ShowPreviewPopup();
        mem2[0] = 1;
        R4.SaveData();
    }
    public override void OnMenuLoaded()
    {
        var val_2;
        var val_3;
        var val_2 = 22735631;
        val_2 = 12890156 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(App.game != 17)
        {
                if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
            val_3 = null;
            val_3 = null;
            if(App.game != 19)
        {
                return;
        }
        
        }
        
        if((this.<BundleReady>k__BackingField) == false)
        {
                return;
        }
        
        bool val_1 = this.HasExpired();
        if(val_1 == false)
        {
                val_1 = this.<EventEnded>k__BackingField;
            goto label_14;
        }
        
        return;
        label_14:
        if(this == 0)
        {
                return;
        }
        
        if(this.shownApplicationLoadedAdvert == true)
        {
                return;
        }
        
        mem2[0] = 51;
        R4.ShowReadyPopup(endOfChapter:  false, flyout:  false);
        mem2[0] = 1;
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        var val_3;
        var val_3 = 22734779;
        val_3 = 12891008 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        if(App.game == 17)
        {
                return;
        }
        
        DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  -1129784432, method:  new IntPtr(3165157840));
        DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1069547520, ignoreTimeScale:  false);
    }
    public override void OnLevelCompleteRewardAnimFinished()
    {
        if(this.isTriggered == false)
        {
                return;
        }
        
        if((this.<EventEnded>k__BackingField) == true)
        {
                return;
        }
        
        if(this == 0)
        {
                return;
        }
        
        if((R4 != 0) && ((R4 + 120) >= 1))
        {
                if((R4 + 196) == 0)
        {
            goto label_4;
        }
        
        }
        
        if(R4.CanShowReadyPopup() == false)
        {
                return;
        }
        
        mem2[0] = 52;
        R4.ShowReadyPopup(endOfChapter:  false, flyout:  true);
        return;
        label_4:
        mem2[0] = 52;
        R4.ShowInterstitialPopup(endOfChapter:  false, flyout:  true);
    }
    public override void OnDailyChallengeRewardGranted()
    {
        if(this == 0)
        {
                return;
        }
        
        if((R4 + 120) < 1)
        {
                return;
        }
        
        if((R4 + 196) != 0)
        {
                return;
        }
        
        mem2[0] = 52;
        R4.ShowInterstitialPopup(endOfChapter:  false, flyout:  false);
    }
    public override void OnBonusGameGoldCurrencyRewardGranted()
    {
        if(this == 0)
        {
                return;
        }
        
        if((R4 + 120) < 1)
        {
                return;
        }
        
        if((R4 + 196) != 0)
        {
                return;
        }
        
        mem2[0] = 52;
        R4.ShowInterstitialPopup(endOfChapter:  false, flyout:  false);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        if((this.<EventEnded>k__BackingField) == true)
        {
                return;
        }
        
        if((this.<BundleReady>k__BackingField) != false)
        {
                this.purchasePoint = 51;
            this.ShowReadyPopup(endOfChapter:  false, flyout:  false);
            return;
        }
        
        this.ShowNotReadyPopup();
    }
    public override void OnGameButtonPressed(bool connected)
    {
        if((this.<EventEnded>k__BackingField) == true)
        {
                return;
        }
        
        if((this.<BundleReady>k__BackingField) != false)
        {
                this.purchasePoint = 53;
            this.ShowReadyPopup(endOfChapter:  false, flyout:  false);
            return;
        }
        
        this.ShowNotReadyPopup();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        float val_3 = (float)this.goldCurrencyTarget;
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        val_3 = ((float)this.<GoldCurrencyGained>k__BackingField) / val_3;
        TheLibraryMainScreen val_2 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        currentData.Add(key:  -1648557216, value:  this.<PackageName>k__BackingField);
        currentData.Add(key:  -1129007104, value:  8945664);
    }
    public override void OnEventEnded()
    {
        this.ResetSaveData();
    }
    public override void UpdateProgress()
    {
        PiggyBankHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override int LastProgressTimestamp()
    {
        return PiggyBankHandler.LastProgressTimestampPref;
    }
    public override bool EventCompleted()
    {
        if((this.<EventEnded>k__BackingField) != false)
        {
                return true;
        }
        
        if((this.<BundleReady>k__BackingField) == false)
        {
                return true;
        }
        
        return this.HasExpired();
    }
    public override bool IsRewardReadyToCollect()
    {
        return (bool)this.<BundleReady>k__BackingField;
    }
    public override System.DateTime GetTimeEnd()
    {
        PiggyBankHandler val_2;
        var val_3;
        if((R1 + 188) != 0)
        {
                val_2 = R1 + 136;
        }
        else
        {
                val_3 = null;
            val_3 = null;
            val_2 = 1152921504616755216;
        }
        
        this = val_2;
        return new System.DateTime() {dateData = val_2};
    }
    public override string GetMainMenuButtonText()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_4 = 12893596 + 22732191;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if(App.game == 17)
        {
            goto label_6;
        }
        
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(App.game != 19)
        {
            goto label_12;
        }
        
        label_6:
        if((this.<BundleReady>k__BackingField) != false)
        {
                return;
        }
        
        val_7 = 0;
        string val_1 = Localization.Localize(key:  -1128214688, defaultValue:  -1128214784, useSingularKey:  false);
        val_8 = "piggy_bank_upper";
        val_9 = 1152921504619999232;
        val_4 = null;
        val_10 = null;
        val_11 = "{0}\n{1}/{2}";
        goto label_15;
        label_12:
        if((this.<BundleReady>k__BackingField) != false)
        {
                return Localization.Localize(key:  -1128214368, defaultValue:  -1128214480, useSingularKey:  false);
        }
        
        val_7 = 0;
        string val_2 = Localization.Localize(key:  -1128214688, defaultValue:  -1128214784, useSingularKey:  false);
        val_8 = "piggy_bank_upper";
        val_9 = 1152921504619999232;
        val_4 = null;
        val_10 = null;
        val_11 = "{0} {1}/{2}";
        label_15:
        string val_3 = System.String.Format(format:  -1694782544, arg0:  -1128214688, arg1:  13152256, arg2:  13152256);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1128214688, defaultValue:  -1128214784, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    public bool IsEventAvailable()
    {
        var val_3 = 0;
        if(this == 0)
        {
                return (bool)val_3;
        }
        
        val_3 = 1;
        if(this.HasExistingData() == true)
        {
                return (bool)val_3;
        }
        
        val_3 = 0;
        if(this.HasPassedFeatureCooldown() == false)
        {
                return (bool)val_3;
        }
        
        return this.HasLapsedPurchase();
    }
    public void TryPurchase()
    {
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        var val_10;
        var val_11;
        var val_10 = 22731113;
        val_10 = 12894948 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        PurchaseProxy.currentPurchasePoint = this.purchasePoint;
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageById(packageId:  this.<PackageID>k__BackingField);
        PurchaseModel val_2 = new PurchaseModel(json:  this.<PackageID>k__BackingField);
        GameBehavior val_3 = App.getBehavior;
        if(0 != 0)
        {
                val_11 = "gems";
        }
        else
        {
                val_11 = "credits";
        }
        
        AddReward(rewardType:  2129282688, amount:  new System.Decimal() {flags = this.<CoinReward>k__BackingField, hi = SL, mid = this.<PackageID>k__BackingField});
        decimal val_4 = System.Decimal.op_Implicit(value:  -1127746116);
        AddReward(rewardType:  -1825935328, amount:  new System.Decimal() {flags = val_5, hi = val_6, lo = val_7, mid = val_8});
        bool val_9 = PurchaseProxy.Purchase(purchase:  292597760);
    }
    public void ResetGoldGainedOld()
    {
        this.<GoldCurrencyGainedOld>k__BackingField = this.<GoldCurrencyGained>k__BackingField;
    }
    public void AddGoldGained()
    {
        int val_1 = this.<GoldCurrencyGained>k__BackingField;
        val_1 = this.GoldCurrencyPending + val_1;
        this.GoldCurrencyPending = 0;
        this.<GoldCurrencyGained>k__BackingField = val_1;
        if(val_1 >= this.goldCurrencyTarget)
        {
                this.<BundleReady>k__BackingField = true;
            this.<GoldCurrencyGained>k__BackingField = this.goldCurrencyTarget;
            this.SetBundleExpirationTime();
        }
        
        this.SaveData();
    }
    public void OnPurchaseSuccess()
    {
        long val_4;
        System.DateTime val_6;
        SLC.Social.Leagues.LeaguesManager.OnAppleAwarded(appleAwarded:  this.<GoldReward>k__BackingField);
        this.TrackPurchaseMade();
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_2 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_5 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512069383752}, t:  new System.TimeSpan() {_ticks = val_4});
        this.piggyBankNextReceiveTime = val_6;
        val_6.CancelNotification();
        this.<EventEnded>k__BackingField = true;
        this.ResetSaveData();
        this.OnPurchaseAttemptResult.Invoke(obj:  true);
    }
    private void TrackPurchaseMade()
    {
        var val_2;
        string val_1 = this.<PackageID>k__BackingField.Replace(oldValue:  -1127289472, newValue:  -1127289584);
        var val_2 = 22729726;
        val_2 = 12895812 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        App.trackerManager.track(eventName:  this.<PackageID>k__BackingField);
    }
    public void OnPurchaseFail()
    {
        this.OnPurchaseAttemptResult.Invoke(obj:  false);
    }
    private bool HasExistingData()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1127053088, defaultValue:  1098586544);
        bool val_2 = System.String.IsNullOrEmpty(value:  -1127053088);
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    private bool HasPassedFeatureCooldown()
    {
        System.DateTime val_4;
        var val_8;
        System.DateTime val_9;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1126940992, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1126940992)) != false)
        {
                val_8 = null;
            val_8 = null;
            val_9 = System.DateTime.MinValue;
        }
        else
        {
                System.DateTime val_3 = SLCDateTime.Parse(dateTime:  -1126928928);
            val_9 = val_4;
        }
        
        this.piggyBankNextReceiveTime = val_9;
        System.DateTime val_6 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_9}, t2:  new System.DateTime() {dateData = val_4});
    }
    private bool HasExpired()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        bool val_4 = System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = this.bundleExpireTime}, t2:  new System.DateTime() {dateData = val_2});
        if(val_4 == true)
        {
                val_4 = this;
            this.ResetSaveData();
        }
        
        System.DateTime val_5 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = this.bundleExpireTime}, t2:  new System.DateTime() {dateData = val_2});
    }
    private bool CanShowInterstitialPopup()
    {
        bool val_1 = false;
        if(this == 0)
        {
                return (bool)val_1;
        }
        
        if(this.GoldCurrencyPending >= 1)
        {
                val_1 = this.<EventEnded>k__BackingField;
        }
        
        if(this.GoldCurrencyPending >= 1)
        {
                val_1 = val_1 >> 5;
        }
        
        return (bool)val_1;
    }
    private bool CanShowReadyPopup()
    {
        ulong val_3;
        if(this != 0)
        {
                this = this.<BundleReady>k__BackingField;
        }
        
        if(this != true)
        {
                return false;
        }
        
        if(this.HasExpired() == true)
        {
                return false;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        bool val_5 = System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = this.promptCooldownTime});
        if(val_5 == true)
        {
                val_5 = this.<EventEnded>k__BackingField;
        }
        
        if(val_5 == true)
        {
                false = val_5 >> 5;
        }
        
        return false;
    }
    private bool HasLapsedPurchase()
    {
        ulong val_8;
        ulong val_10;
        var val_13;
        var val_14;
        val_13 = 1152921504892043264;
        Player val_1 = App.Player;
        val_14 = 1;
        if(188 < 1)
        {
                return (bool)System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_8});
        }
        
        if(PiggyBankHandler.hackIgnoreLastPurchase == true)
        {
                return (bool)System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_8});
        }
        
        Player val_2 = App.Player;
        val_13 = 264;
        System.TimeSpan val_3 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_6 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512070300632}, t:  new System.TimeSpan() {_ticks = 264});
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_8});
    }
    private bool HasPassedCoinCriteria()
    {
        ulong val_10;
        ulong val_12;
        PiggyBankHandler val_22;
        int val_23;
        var val_24;
        decimal val_25;
        PiggyBankHandler val_26;
        var val_27;
        var val_28;
        val_22 = this;
        val_23 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            goto label_5;
        }
        
        Player val_3 = App.Player;
        if(188 < 1)
        {
            goto label_27;
        }
        
        Player val_4 = App.Player;
        val_24 = 0;
        decimal val_5 = System.Decimal.op_Implicit(value:  -1126368952);
        val_25 = this.coinBalanceCriterion;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_25, hi = ???, mid = ???})) == true)
        {
                return (bool)val_24;
        }
        
        Player val_7 = App.Player;
        System.DateTime val_8 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512070412616}, t:  new System.TimeSpan() {_ticks = 23});
        System.DateTime val_9 = DateTimeCheat.UtcNow;
        bool val_14 = System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_12}, t2:  new System.DateTime() {dateData = val_10});
        val_14 = val_14 ^ 1;
        return (bool)val_14;
        label_5:
        Player val_15 = App.Player;
        if(188 >= 1)
        {
                Player val_16 = App.Player;
            val_27 = 52;
            val_25 = 52;
            val_28 = 256;
            val_22 = 3.587324E-43f;
            val_27 = val_27;
            val_28 = val_28;
            val_24 = 0;
            val_26 = val_22;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = this.coinBalanceCriterion, hi = val_23, mid = ???})) == false)
        {
                return (bool)val_24;
        }
        
            Player val_18 = App.Player;
            val_23 = this.lastCoinSpentDuration;
            val_25 = mem[1152921512070424884];
            val_26 = 0;
            System.DateTime val_19 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512070412616}, t:  new System.TimeSpan() {_ticks = 23});
            System.DateTime val_20 = DateTimeCheat.UtcNow;
            val_24 = System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_12}, t2:  new System.DateTime() {dateData = val_10});
            return (bool)val_24;
        }
        
        label_27:
        val_24 = 1;
        return (bool)val_24;
    }
    private void SetPurchaseModel()
    {
        twelvegigs.storage.JsonDictionary val_11;
        var val_12;
        if((System.String.IsNullOrEmpty(value:  this.<PackageID>k__BackingField)) == true)
        {
                return;
        }
        
        twelvegigs.storage.JsonDictionary val_2 = PackagesManager.GetPackageById(packageId:  this.<PackageID>k__BackingField);
        if((this.<PackageID>k__BackingField) != null)
        {
                this.purchaseModel = new PurchaseModel(json:  this.<PackageID>k__BackingField);
            string val_4 = this.<PackageID>k__BackingField.getString(key:  -1403597104, defaultValue:  1098586544);
            twelvegigs.storage.JsonDictionary val_5 = PackagesManager.GetPackageById(packageId:  this.<PackageID>k__BackingField);
            val_11 = this.<PackageID>k__BackingField;
            string val_7 = LocalPrice;
            this.PriceUsual = new PurchaseModel(json:  val_11);
            if((this.<Discount>k__BackingField) > 0)
        {
                return;
        }
        
            val_11 = this.purchaseModel;
            val_12 = 292601856;
            void* val_8 = PurchaseModel.__il2cppRuntimeField_static_fields - this.purchaseModel.sale_price;
            val_8 = val_8 / PurchaseModel.__il2cppRuntimeField_static_fields;
            val_8 = val_8 * 100f;
            this.<Discount>k__BackingField = UnityEngine.Mathf.RoundToInt(f:  val_8);
            return;
        }
        
        string val_10 = -1126256608(-1126256608) + this.<PackageID>k__BackingField(this.<PackageID>k__BackingField);
        UnityEngine.Debug.LogError(message:  -1126256608);
    }
    private void OnGoldCurrencyTargetMet()
    {
        this.<BundleReady>k__BackingField = true;
        this.SetBundleExpirationTime();
    }
    private void SetBundleExpirationTime()
    {
        long val_4;
        System.DateTime val_7;
        System.DateTime val_12;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_2 = System.TimeSpan.FromMinutes(value:  null);
        System.DateTime val_5 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512070781616}, t:  new System.TimeSpan() {_ticks = val_4});
        this.bundleExpireTime = val_7;
        System.TimeSpan val_8 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_11 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512070781600}, t:  new System.TimeSpan() {_ticks = val_7});
        this.piggyBankNextReceiveTime = val_12;
        val_12.CancelNotification();
        this.SetNotification();
    }
    private void SetPromptCooldownTime()
    {
        long val_4;
        System.DateTime val_7;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  null);
        System.DateTime val_5 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512070893624}, t:  new System.TimeSpan() {_ticks = val_4});
        this.promptCooldownTime = val_7;
    }
    private void ShowPreviewPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) == 0)
        {
            
        }
    
    }
    private void ShowNotReadyPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        SetupNotReady();
    }
    private void ShowReadyPopup(bool endOfChapter = False, bool flyout = False)
    {
        var val_5;
        var val_6;
        bool val_7;
        if(flyout != false)
        {
                GameBehavior val_1 = App.getBehavior;
            val_5 = 0;
            val_6 = endOfChapter;
            val_7 = 0;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_5 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            val_6 = 0;
            val_7 = endOfChapter;
        }
        
        SetupReady(fromInterstitial:  false, endOfChapter:  val_7);
        this.SetPromptCooldownTime();
    }
    private void ShowInterstitialPopup(bool endOfChapter = False, bool flyout = False)
    {
        var val_5;
        this.AddGoldGained();
        if(flyout != false)
        {
                GameBehavior val_1 = App.getBehavior;
            val_5 = 0;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        }
        
        SetupInterstitial(endOfChapter:  endOfChapter);
        this.SetPromptCooldownTime();
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        bool val_33;
        var val_34;
        var val_35;
        float val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        val_33 = 0;
        string val_1 = PrettyPrint.printJSON(obj:  eventData, types:  false, singleLineOutput:  false);
        UnityEngine.Debug.LogError(message:  eventData);
        val_34 = 1152921510392296080;
        if((eventData.ContainsKey(key:  -1125333760)) != false)
        {
                this.ParseV1SplitEcon(eventData:  eventData);
            return;
        }
        
        if((eventData.ContainsKey(key:  -1125333760)) != false)
        {
                this.ParseAlternateEcon(eventData:  eventData);
            return;
        }
        
        val_35 = "economy";
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        val_36 = 1152921510385703632;
        object val_5 = eventData.Item[-1554533760];
        val_37 = 1;
        if((0.ContainsKey(key:  -1125333680)) != false)
        {
                string val_7 = 0.Item[-1125333680];
            if(0 != 0)
        {
                val_33 = mem[1179403827];
        }
        
            val_38 = 0;
            val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_8 = val_38.Item[-1125333584];
            val_37 = val_38;
            val_36 = 1152921504619999232;
            val_40 = null;
            val_37.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.playerSpendLow = 1179403647;
            val_36 = 1152921510385703632;
            val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_9 = val_38.Item[-1125333504];
            val_40 = null;
            val_41 = val_38;
            val_37 = val_37;
            val_41.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.playerSpendHigh = 1179403647;
        }
        
        if((0.ContainsKey(key:  -1630882544)) != false)
        {
                string val_11 = 0.Item[-1630882544];
            if(0 != 0)
        {
                val_33 = mem[1179403827];
        }
        
            val_38 = 0;
            val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_12 = val_38.Item[-1125333584];
            val_37 = val_38;
            val_36 = 1152921504619999232;
            val_40 = null;
            val_37.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.playerLevelLow = 1179403647;
            val_36 = 1152921510385703632;
            val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_13 = val_38.Item[-1125333504];
            val_40 = null;
            val_41 = val_38;
            val_37 = val_37;
            val_41.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.playerLevelHigh = 1179403647;
        }
        
        if((0.ContainsKey(key:  -1125333424)) != false)
        {
                string val_15 = 0.Item[-1125333424];
            if(0 != 0)
        {
                val_33 = mem[1179403827];
        }
        
            val_38 = 0;
            val_34 = 1;
            val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_16 = val_38.Item[-1125333584];
            val_37 = val_38;
            val_36 = 1152921504619999232;
            val_40 = null;
            val_37.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.goldCurrencyTargetLow = 1179403647;
            val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_17 = val_38.Item[-1125333312];
            val_40 = null;
            val_37 = val_38;
            val_37.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.goldCurrencyTargetMid = 1179403647;
            val_36 = 1152921510385703632;
            val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_18 = val_38.Item[-1125333504];
            val_40 = null;
            val_41 = val_38;
            val_37 = val_37;
            val_34 = 1152921510392296080;
            val_41.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.goldCurrencyTargetHigh = 1179403647;
        }
        
        if((0.ContainsKey(key:  -1125333232)) != false)
        {
                string val_20 = 0.Item[-1125333232];
            if(0 != 0)
        {
                val_33 = mem[1179403827];
        }
        
            val_38 = 0;
            val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_21 = val_38.Item[-1125333136];
            val_37 = val_38;
            val_40 = null;
            val_37.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            decimal val_22 = System.Decimal.op_Implicit(value:  -1125320560);
            val_36 = 1152921510385703632;
            val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_23 = val_38.Item[-1125333040];
            val_41 = val_38;
            val_37 = val_37;
            val_40 = null;
            val_41.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            decimal val_24 = System.Decimal.op_Implicit(value:  -1125320576);
        }
        
        if((0.ContainsKey(key:  -1125332944)) != false)
        {
                string val_26 = 0.Item[-1125332944];
            val_41 = 0;
            val_40 = null;
            val_41.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.lapseDurationDays = ;
        }
        
        if((0.ContainsKey(key:  -1125332832)) != false)
        {
                val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_28 = 0.Item[-1125332832];
            val_41 = 0;
            val_40 = null;
            val_41.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.bundleDurationMinutes = ;
        }
        
        if((0.ContainsKey(key:  -1125332720)) != false)
        {
                val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_30 = 0.Item[-1125332720];
            val_41 = 0;
            val_40 = null;
            val_41.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.promptCooldownSeconds = ;
        }
        
        if((0.ContainsKey(key:  -1125332608)) == false)
        {
                return;
        }
        
        val_39 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        string val_32 = 0.Item[-1125332608];
        val_40 = 0;
        val_41 = null;
        val_40.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.featureCooldownDays = ;
    }
    private void ParseAlternateEcon(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        var val_44;
        float val_45;
        bool val_46;
        var val_47;
        val_44 = 1152921510385703632;
        object val_1 = eventData.Item[-1125333760];
        val_45 = 1152921504685600768;
        if((0.ContainsKey(key:  -1125212304)) != false)
        {
                string val_3 = 0.Item[-1125212304];
            if(0 != 0)
        {
                val_47 = 0;
            val_46 = mem[1179403827];
        }
        
            val_47 = 0;
            if(0 >= 2)
        {
                bool val_5 = System.Int32.TryParse(s:  2621443, result: out  this.playerSpendLow);
            if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            bool val_7 = System.Int32.TryParse(s:  1, result: out  this.playerSpendHigh);
        }
        
        }
        
        if((0.ContainsKey(key:  -1163066496)) != false)
        {
                string val_9 = 0.Item[-1163066496];
            if(0 != 0)
        {
                val_47 = 0;
            val_46 = mem[1179403827];
        }
        
            val_47 = 0;
            if(0 >= 2)
        {
                bool val_11 = System.Int32.TryParse(s:  2621443, result: out  this.playerLevelLow);
            if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            bool val_13 = System.Int32.TryParse(s:  1, result: out  this.playerLevelHigh);
        }
        
        }
        
        if((0.ContainsKey(key:  -1125212224)) != false)
        {
                string val_15 = 0.Item[-1125212224];
            if(0 != 0)
        {
                val_47 = 0;
            val_46 = mem[1179403827];
        }
        
            val_47 = 0;
            if(0 >= 3)
        {
                bool val_17 = System.Int32.TryParse(s:  2621443, result: out  this.goldCurrencyTargetLow);
            if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            bool val_19 = System.Int32.TryParse(s:  1, result: out  this.goldCurrencyTargetMid);
            if(0 <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            bool val_21 = System.Int32.TryParse(s:  null, result: out  this.goldCurrencyTargetHigh);
        }
        
        }
        
        if((0.ContainsKey(key:  -1125212144)) != false)
        {
                string val_23 = 0.Item[-1125212144];
            if(0 != 0)
        {
                val_46 = mem[1179403827];
        }
        
            val_47 = 0;
            val_45 = 1;
            string val_24 = val_47.Item[-1125212064];
            bool val_25 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this.coinBalanceCriterion, lo = val_46});
            val_44 = 1152921510385703632;
            string val_26 = val_47.Item[-1125211984];
            bool val_27 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this.dailyCoinSpentCriterion, lo = val_46});
        }
        
        if((0.ContainsKey(key:  -1125211904)) != false)
        {
                string val_29 = 0.Item[-1125211904];
            val_47 = 0;
            bool val_31 = System.Double.TryParse(s:  null, result: out  this.lapseDurationDays);
        }
        
        if((0.ContainsKey(key:  -1125211824)) != false)
        {
                string val_33 = 0.Item[-1125211824];
            val_47 = 0;
            bool val_35 = System.Double.TryParse(s:  null, result: out  this.bundleDurationMinutes);
        }
        
        if((0.ContainsKey(key:  -1125211744)) != false)
        {
                string val_37 = 0.Item[-1125211744];
            val_47 = 0;
            bool val_39 = System.Double.TryParse(s:  null, result: out  this.promptCooldownSeconds);
        }
        
        if((0.ContainsKey(key:  -1125211664)) == false)
        {
                return;
        }
        
        string val_41 = 0.Item[-1125211664];
        bool val_43 = System.Double.TryParse(s:  null, result: out  this.featureCooldownDays);
    }
    private void DetermineBundle(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        var val_28;
        var val_29;
        bool val_30;
        var val_31;
        string val_32;
        string val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        int val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = null;
        val_28 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        GameEcon val_2 = App.getGameEcon;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = 0.GetGameplayKnobs();
        val_29 = 1152921510392296080;
        if((0.ContainsKey(key:  -1125091392)) != false)
        {
                GameEcon val_5 = App.getGameEcon;
            val_28 = 0;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = 0.GetGameplayKnobs();
            string val_7 = 0.Item[-1125091392];
            if(0 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_28 = 0;
        }
        
        }
        
        val_31 = "non";
        this.<PackageName>k__BackingField = "Non-Buyer ";
        this.<PackageID>k__BackingField = "id_piggy_bank_nonbuyer";
        Player val_8 = App.Player;
        float val_28 = 100f;
        val_28 = (4.315999E-43f) * val_28;
        if(0 <= 0)
        {
            goto label_15;
        }
        
        val_32 = "Lapsed3 ";
        val_33 = "id_piggy_bank_lapse3";
        val_34 = "l3";
        goto label_19;
        label_15:
        if(0 >= 0)
        {
            goto label_17;
        }
        
        if(0 <= 0)
        {
            goto label_18;
        }
        
        val_32 = "Lapsed1 ";
        val_33 = "id_piggy_bank_lapse1";
        val_34 = "l1";
        goto label_19;
        label_17:
        val_32 = "Lapsed2 ";
        val_33 = "id_piggy_bank_lapse2";
        val_34 = "l2";
        label_19:
        this.<PackageID>k__BackingField = val_33;
        this.<PackageName>k__BackingField = val_32;
        label_18:
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_9 = null;
        val_35 = val_9;
        val_9 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if((val_28.ContainsKey(key:  -1125090240)) == false)
        {
            goto label_21;
        }
        
        string val_11 = val_28.Item[-1125090240];
        if(val_28 != 0)
        {
                val_35 = val_28;
            val_30 = mem[1179403827];
        }
        
        label_27:
        val_35 = 0;
        val_36 = 1;
        goto label_26;
        label_21:
        if(val_35 == 0)
        {
            goto label_27;
        }
        
        val_36 = 0;
        label_26:
        if((ContainsKey(key:  -1785508240)) != false)
        {
                val_37 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_13 = Item[-1785508240];
            val_38 = val_35;
            val_39 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            decimal val_14 = System.Decimal.op_Implicit(value:  -1125073568);
        }
        
        if((ContainsKey(key:  -1125090160)) != false)
        {
                string val_16 = Item[-1125090160];
            string val_17 = ToString();
            bool val_19 = System.Int32.TryParse(s:  78753792, result: out  int val_18 = -1125073544);
            if(val_19 == true)
        {
                val_19 = 0;
            this.<Discount>k__BackingField = 0;
        }
        
        }
        
        Player val_20 = App.Player;
        if(0 >= this.playerLevelHigh)
        {
            goto label_41;
        }
        
        if(0 >= this.playerLevelLow)
        {
            goto label_42;
        }
        
        val_40 = this.goldCurrencyTargetLow;
        val_41 = "l";
        val_42 = "Low";
        goto label_44;
        label_41:
        val_40 = this.goldCurrencyTargetHigh;
        val_41 = "h";
        val_42 = "High";
        goto label_44;
        label_42:
        val_40 = this.goldCurrencyTargetMid;
        val_41 = "m";
        val_42 = "Mid";
        label_44:
        this.goldCurrencyTarget = val_40;
        string val_21 = this.<PackageName>k__BackingField(this.<PackageName>k__BackingField) + -1125089680(-1125089680);
        this.<PackageName>k__BackingField = this.<PackageName>k__BackingField;
        val_43 = "g";
        if((ContainsKey(key:  -1968282976)) != false)
        {
                string val_23 = Item[-1968282976];
            if(val_35 != 0)
        {
                val_30 = mem[null + 180];
        }
        
            val_43 = 0;
            val_29 = 1;
            if((val_43.ContainsKey(key:  -1125089760)) != false)
        {
                val_37 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_25 = val_43.Item[-1125089760];
            val_38 = val_43;
            val_44 = null;
            val_38.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.<GoldReward>k__BackingField = 1179403647;
        }
        
        }
        
        if((ContainsKey(key:  1357768992)) != false)
        {
                val_37 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_27 = Item[1357768992];
            val_35 = val_35;
            val_38 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.<GoldReward>k__BackingField = null;
        }
        
        this.GoldCurrencyPending = 0;
        this.<GoldCurrencyGained>k__BackingField = 0;
        this.<GoldCurrencyGainedOld>k__BackingField = 0;
        this.<BundleReady>k__BackingField = 0;
        val_45 = null;
        val_45 = null;
        this.bundleExpireTime = System.DateTime.MaxValue;
        this.isTriggered = 0;
        this.SetPurchaseModel();
        this.SaveData();
    }
    private void ParseV1SplitEcon(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        var val_29;
        var val_30;
        var val_31;
        val_29 = 1152921510385703632;
        object val_1 = eventData.Item[-1125333760];
        if((0.ContainsKey(key:  -1649936592)) != false)
        {
                string val_3 = 0.Item[-1649936592];
            bool val_5 = System.Int32.TryParse(s:  null, result: out  int val_4 = -1124949096);
            if(val_5 == true)
        {
                val_5 = 0;
            this.unlockLevel = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -1125212304)) != false)
        {
                string val_7 = 0.Item[-1125212304];
            if(0 != 0)
        {
                val_30 = 0;
        }
        
            val_30 = 0;
            if(0 >= 2)
        {
                val_31 = null;
            2621443.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.playerSpendLow = 406885376;
            if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_30 = 1;
            val_31 = null;
            val_29 = 1152921510385703632;
            val_30.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.playerSpendHigh = 21384261;
        }
        
        }
        
        if((0.ContainsKey(key:  -1124961216)) != false)
        {
                string val_9 = 0.Item[-1124961216];
            if((System.Int32.TryParse(s:  null, result: out  int val_10 = -1124949096)) != false)
        {
                this.goldCurrencyTarget = 0;
            this.goldCurrencyTargetLow = 0;
            this.goldCurrencyTargetMid = 0;
            this.goldCurrencyTargetHigh = 0;
        }
        
        }
        
        if((0.ContainsKey(key:  -1125212144)) != false)
        {
                string val_13 = 0.Item[-1125212144];
            if(0 != 0)
        {
                val_30 = 0;
            if((val_30.ContainsKey(key:  -1124961136)) != false)
        {
                string val_15 = val_30.Item[-1124961136];
            val_30 = val_30;
            bool val_16 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this.coinBalanceCriterion, lo = mem[1179403827]});
        }
        
        }
        
        }
        
        if((0.ContainsKey(key:  -1125211904)) != false)
        {
                string val_18 = 0.Item[-1125211904];
            if((System.Int32.TryParse(s:  null, result: out  int val_19 = -1124949096)) != false)
        {
                this.lapseDurationDays = ;
        }
        
        }
        
        if((0.ContainsKey(key:  -1125211824)) != false)
        {
                string val_22 = 0.Item[-1125211824];
            if((System.Int32.TryParse(s:  null, result: out  int val_23 = -1124949096)) != false)
        {
                this.bundleDurationMinutes = ;
        }
        
        }
        
        if((0.ContainsKey(key:  -1125211744)) == false)
        {
                return;
        }
        
        string val_26 = 0.Item[-1125211744];
        if((System.Int32.TryParse(s:  null, result: out  int val_27 = -1124949096)) == false)
        {
                return;
        }
        
        this.promptCooldownSeconds = ;
    }
    private void SetNotification()
    {
        string val_6;
        System.TimeSpan val_1 = System.TimeSpan.FromHours(value:  null);
        System.DateTime val_4 = System.DateTime.op_Subtraction(d:  new System.DateTime() {dateData = 1152921512071948744}, t:  new System.TimeSpan() {_ticks = this.bundleExpireTime});
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  18, when:  new System.DateTime(), optMessage:  val_6, extraData:  "Your Piggy Bank is bursting with Coins! Collect Now!");
    }
    private void CancelNotification()
    {
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  18);
    }
    private void SaveData()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1124620784, value:  13152256);
        Add(key:  -1124620672, value:  13152256);
        Add(key:  -1124620560, value:  13152256);
        Add(key:  -1124620448, value:  9904128);
        Add(key:  -1124616256, value:  this.<PackageID>k__BackingField);
        Add(key:  -1124616160, value:  10170368);
        Add(key:  -1124616064, value:  13152256);
        Add(key:  -1124611872, value:  this.<PackageName>k__BackingField);
        Add(key:  -1124611776, value:  8945664);
        string val_2 = this.piggyBankNextReceiveTime.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1126940992, value:  this.piggyBankNextReceiveTime);
        string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1127053088, value:  78753792);
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private void LoadData()
    {
        System.DateTime val_18;
        string val_30;
        var val_31;
        var val_32;
        var val_33;
        string val_34;
        string val_35;
        var val_36;
        var val_37;
        var val_38;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1127053088, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1127053088)) == true)
        {
                return;
        }
        
        val_30 = 0;
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -1127053088, defaultValue:  1098586544);
        object val_4 = MiniJSON.Json.Deserialize(json:  -1127053088);
        if("pbEventData" != 0)
        {
                if(null == null)
        {
            goto label_27;
        }
        
        }
        
        label_27:
        if((val_30.ContainsKey(key:  -1124620784)) != false)
        {
                string val_6 = val_30.Item[-1124620784];
            val_32 = val_30;
            val_31 = null;
            val_32.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.<GoldCurrencyGained>k__BackingField = 1179403647;
        }
        
        if((val_30.ContainsKey(key:  -1124620672)) != false)
        {
                string val_8 = val_30.Item[-1124620672];
            val_32 = val_30;
            val_31 = null;
            val_32.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.GoldCurrencyPending = 1179403647;
        }
        
        if((val_30.ContainsKey(key:  -1124620560)) != false)
        {
                string val_10 = val_30.Item[-1124620560];
            val_32 = val_30;
            val_31 = null;
            val_32.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.goldCurrencyTarget = 1179403647;
        }
        
        if((val_30.ContainsKey(key:  -1124620448)) != false)
        {
                string val_12 = val_30.Item[-1124620448];
            val_31 = 0;
            System.DateTime val_13 = System.DateTime.UtcNow;
            val_33 = 0;
            if(val_30 != 0)
        {
                if(1179403647 != null)
        {
                val_33 = 0;
        }
        else
        {
                val_33 = val_30;
        }
        
        }
        
            System.DateTime val_16 = SLCDateTime.Parse(dateTime:  -1124479528, defaultValue:  new System.DateTime());
            this.bundleExpireTime = val_18;
        }
        
        if((val_30.ContainsKey(key:  -1124616256)) != false)
        {
                string val_20 = val_30.Item[-1124616256];
            val_34 = 0;
            if(val_30 != 0)
        {
                if(1179403647 != null)
        {
            
        }
        else
        {
                val_34 = val_30;
        }
        
        }
        
            this.<PackageID>k__BackingField = val_34;
        }
        
        if((val_30.ContainsKey(key:  -1124616160)) != false)
        {
                string val_22 = val_30.Item[-1124616160];
            val_32 = val_30;
            val_31 = null;
            val_32.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            decimal val_23 = System.Decimal.op_Implicit(value:  -1124479552);
        }
        
        if((val_30.ContainsKey(key:  -1124616064)) != false)
        {
                string val_25 = val_30.Item[-1124616064];
            val_32 = val_30;
            val_31 = null;
            val_32.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.<GoldReward>k__BackingField = 1179403647;
        }
        
        if((val_30.ContainsKey(key:  -1124611872)) != false)
        {
                string val_27 = val_30.Item[-1124611872];
            val_35 = 0;
            if(val_30 != 0)
        {
                if(1179403647 != null)
        {
            
        }
        else
        {
                val_35 = val_30;
        }
        
        }
        
            this.<PackageName>k__BackingField = val_35;
        }
        
        val_36 = "pbIsTriggered";
        val_37 = "pbIsTriggered";
        if((val_30.ContainsKey(key:  -1124611776)) != false)
        {
                string val_29 = val_30.Item[-1124611776];
            val_30 = val_30;
            val_38 = null;
            val_30.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.isTriggered = true;
        }
        
        if((this.<GoldCurrencyGained>k__BackingField) >= System.Boolean.__il2cppRuntimeField_element_class)
        {
                0 = 1;
        }
        
        this.<BundleReady>k__BackingField = true;
        this.SetPurchaseModel();
    }
    private void ResetSaveData()
    {
        string val_1 = this.piggyBankNextReceiveTime.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1126940992, value:  this.piggyBankNextReceiveTime);
        UnityEngine.PlayerPrefs.SetString(key:  -1127053088, value:  1098586544);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public void HackReInit()
    {
        this.ResetSaveData();
        goto typeof(PiggyBankHandler).__il2cppRuntimeField_11C;
    }
    public void HackResetProgress()
    {
        this.<GoldCurrencyGained>k__BackingField = 0;
        this.<BundleReady>k__BackingField = 0;
        this.GoldCurrencyPending = 0;
        this.<GoldCurrencyGainedOld>k__BackingField = 0;
        this.SaveData();
    }
    public void HackSetBundleAlmostReady()
    {
        int val_1 = this.goldCurrencyTarget;
        this.<BundleReady>k__BackingField = false;
        this.GoldCurrencyPending = false;
        val_1 = val_1 - 1;
        this.<GoldCurrencyGained>k__BackingField = val_1;
        this.<GoldCurrencyGainedOld>k__BackingField = val_1;
    }
    public void HackSetBundleReady()
    {
        int val_1 = R7 - (this.<GoldCurrencyGained>k__BackingField);
        this.AddGoldGained();
        this.<GoldCurrencyGainedOld>k__BackingField = this.<GoldCurrencyGained>k__BackingField;
    }
    public void HackResetPromptCooldown()
    {
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        this.promptCooldownTime = new System.DateTime();
    }
    public void HackSetExpire1Minute()
    {
        System.DateTime val_5;
        System.DateTime val_11;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_2 = System.TimeSpan.FromMinutes(value:  null);
        System.DateTime val_3 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512073086032}, t:  new System.TimeSpan());
        this.bundleExpireTime = val_5;
        System.TimeSpan val_6 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_9 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512073086016}, t:  new System.TimeSpan() {_ticks = val_5});
        this.piggyBankNextReceiveTime = val_11;
    }
    public static void HackResetFeatureCooldown()
    {
        var val_3 = null;
        string val_1 = System.DateTime.MinValue.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1126940992, value:  -1123583512);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static void HackIgnoreLastPurchaseDate()
    {
        bool val_1 = PiggyBankHandler.hackIgnoreLastPurchase;
        val_1 = val_1 ^ 1;
        PiggyBankHandler.hackIgnoreLastPurchase = val_1;
    }
    public static string HackNextAvailableDate()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1126940992, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1126940992)) == true)
        {
                "pbNextReceive" = "null";
        }
    
    }
    public PiggyBankHandler()
    {
        System.TimeSpan val_5;
        var val_6;
        this.lapseDurationDays = 14;
        decimal val_1 = new System.Decimal(value:  3500);
        decimal val_2 = new System.Decimal(value:  120);
        this.bundleDurationMinutes = 0;
        mem[1152921512073546172] = 1080950784;
        this.promptCooldownSeconds = 0;
        mem[1152921512073546180] = 1079902208;
        mem[1152921512073546188] = 1075576832;
        this.featureCooldownDays = 0;
        this.goldCurrencyTarget = 0;
        val_6 = null;
        val_6 = null;
        this.bundleExpireTime = System.DateTime.MaxValue;
        System.TimeSpan val_3 = System.TimeSpan.FromDays(value:  null);
        this.lastCoinSpentDuration = val_5;
        this.unlockLevel = 0;
    }
    private void <OnLevelComplete>b__135_0()
    {
        var val_7;
        var val_8;
        bool val_9;
        if(this.isTriggered == false)
        {
                return;
        }
        
        if((this.<EventEnded>k__BackingField) == true)
        {
                return;
        }
        
        if(R4 == 0)
        {
                return;
        }
        
        val_8 = 1152921504885600256;
        val_9 = 0;
        MainController val_1 = MainController.instance;
        val_7 = 0;
        if(0 != 0)
        {
                MainController val_3 = MainController.instance;
            val_9 = 0.IsChapterComplete;
        }
        
        if((R4 != 0) && ((R4 + 120) >= 1))
        {
                if((R4 + 196) == 0)
        {
            goto label_13;
        }
        
        }
        
        if(R4.CanShowReadyPopup() == false)
        {
                return;
        }
        
        mem2[0] = 52;
        R4.ShowReadyPopup(endOfChapter:  val_9, flyout:  false);
        return;
        label_13:
        mem2[0] = 52;
        R4.ShowInterstitialPopup(endOfChapter:  val_9, flyout:  false);
    }

}
