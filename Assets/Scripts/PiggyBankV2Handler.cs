using UnityEngine;
public class PiggyBankV2Handler : WGEventHandler
{
    // Fields
    private static PiggyBankV2Handler _Instance;
    public const string PIGGY_BANK_V2_EVENT_ID = "PiggyBankV2";
    private const string piggyBankDataKey = "pbv2EventData";
    private const string pbNextReceiveKey = "pbv2NextReceive";
    private const string pbNextPiggyTierKey = "pbv2NextPiggyTier";
    private const string pbLastCollectedKey = "pbv2LastRewardCollected";
    private const string pbCurrencyGainedKey = "pbv2CurrencyGained";
    private const string pbCurrencyPendingKey = "pbv2CurrencyPending";
    private const string pbExpireTimeKey = "pbv2ExpireTime";
    private const string pbPackageTierKey = "pbv2PackageTier";
    private const string pbIsTriggeredKey = "pbv2IsTriggered";
    private const string pbLastProgressKey = "pbv2LastProgress";
    private const string eventLapse = "lapsed_duration_days";
    private const string eventLongTermNonPayer = "long_term_non_payer_days";
    private const string eventExpire = "event_duration_days";
    private const string eventpromptCooldown = "prompt_cool_seconds";
    private const string eventFeatureCooldown = "feature_cool_days";
    private int lapseDurationDays;
    private int longTermNonPayer;
    private int promptCooldownSeconds;
    private int featureCooldownDays;
    private int eventDurationDays;
    private int <GoldCurrencyGained>k__BackingField;
    private int goldCurrencyTarget;
    private int GoldCurrencyPending;
    private int packageTier;
    private decimal initialBankAmount;
    private System.DateTime piggyBankNextReceiveTime;
    private System.DateTime bundleExpireTime;
    private bool isTriggered;
    private string <PackageID>k__BackingField;
    private decimal <BankAmountMax>k__BackingField;
    private PurchaseModel purchaseModel;
    private bool <BankFull>k__BackingField;
    private int <GoldCurrencyGainedOld>k__BackingField;
    private bool <EventEnded>k__BackingField;
    private PiggyBankV2Econ econ;
    private System.DateTime promptCooldownTime;
    private TrackerPurchasePoints purchasePoint;
    public static bool hackIgnoreLastPurchase;
    private string lastPackageLogic;
    private const int minDowngradeTier = 1;
    public System.Action<bool> OnPurchaseAttemptResult;
    private bool shownApplicationLoadedAdvert;
    
    // Properties
    public static PiggyBankV2Handler Instance { get; }
    public int GoldCurrencyGained { get; set; }
    public int GoldCurrencyTarget { get; }
    public string PackageID { get; set; }
    public decimal BankAmountMax { get; set; }
    public bool BankFull { get; set; }
    public int GoldCurrencyGainedOld { get; set; }
    public bool EventEnded { get; set; }
    public string PricePurchaseString { get; }
    public decimal BankAmountCurrent { get; }
    public decimal BankAmountOld { get; }
    private static int LastProgressTimestampPref { get; set; }
    public override bool SupportsGoldenApples { get; }
    public override bool IsEventHidden { get; }
    public override bool OverrideEventButton { get; }
    
    // Methods
    public static PiggyBankV2Handler get_Instance()
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
    public string get_PackageID()
    {
    
    }
    private void set_PackageID(string value)
    {
        this.<PackageID>k__BackingField = value;
    }
    public decimal get_BankAmountMax()
    {
        return new System.Decimal() {flags = -1099162480, hi = R1 + 96};
    }
    private void set_BankAmountMax(decimal value)
    {
    
    }
    public bool get_BankFull()
    {
        return (bool)this.<BankFull>k__BackingField;
    }
    private void set_BankFull(bool value)
    {
        this.<BankFull>k__BackingField = value;
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
    public decimal get_BankAmountCurrent()
    {
        decimal val_1 = System.Decimal.op_Implicit(value:  -1098158336);
        var val_2 = R1 + 52;
        decimal val_3 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1098146288}, d2:  new System.Decimal() {flags = ???, hi = mem[(R1 + 52) + (0)], lo = mem[(R1 + 52) + (4)], mid = mem[(R1 + 52) + (8)]});
        return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
    }
    public decimal get_BankAmountOld()
    {
        decimal val_1 = System.Decimal.op_Implicit(value:  -1098046336);
        var val_2 = R1 + 52;
        decimal val_3 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1098034288}, d2:  new System.Decimal() {flags = ???, hi = mem[(R1 + 52) + (0)], lo = mem[(R1 + 52) + (4)], mid = mem[(R1 + 52) + (8)]});
        return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1097946288, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1097946288, value:  value);
    }
    public override bool get_SupportsGoldenApples()
    {
        return true;
    }
    public override bool get_IsEventHidden()
    {
        if(this.isTriggered == false)
        {
                this = 1;
            return (bool)this;
        }
        
        return this.HasExpired();
    }
    public override void Init(GameEventV2 eventV2)
    {
        System.DateTime val_3;
        System.DateTime val_12;
        System.DateTime val_14;
        var val_15;
        val_14 = 35633015;
        mem[1152921512099315592] = eventV2;
        PiggyBankV2Handler.minDowngradeTier = this;
        this.ParseEventData(eventData:  eventV2.eventData);
        if(this.IsEventAvailable() != false)
        {
                this.LoadData();
            System.DateTime val_2 = DateTimeCheat.UtcNow;
            this.promptCooldownTime = val_3;
            this.<GoldCurrencyGainedOld>k__BackingField = this.<GoldCurrencyGained>k__BackingField;
            if(val_3.HasExistingData() != false)
        {
                if(this.HasExpired() != true)
        {
                if(this.isTriggered == true)
        {
                return;
        }
        
        }
        
        }
        
            val_15 = eventV2;
            if(eventV2 == 0)
        {
                if(val_15 == 0)
        {
            goto label_9;
        }
        
        }
        
            val_14 = eventV2.timeEnd;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = eventV2.lastTimestamp}, t2:  new System.DateTime() {dateData = val_14})) != true)
        {
                if(this.HasExpired() == false)
        {
            goto label_13;
        }
        
        }
        
        }
        
        this.<EventEnded>k__BackingField = true;
        return;
        label_13:
        this.ResetSaveData();
        this.<GoldCurrencyGained>k__BackingField = 0;
        this.GoldCurrencyPending = 0;
        this.<GoldCurrencyGainedOld>k__BackingField = 0;
        this.<BankFull>k__BackingField = 0;
        System.DateTime val_9 = DateTimeCheat.UtcNow;
        System.DateTime val_10 = AddDays(value:  null);
        this.bundleExpireTime = val_12;
        this.isTriggered = 0;
        this.SaveData();
        GameBehavior val_13 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        return;
        label_9:
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
    public override void OnProcessPurchase(ref PurchaseModel purchase)
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
        val_11 = 1152921512099728560;
        if((purchase.id.Contains(value:  -1130514160)) == false)
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
        if((System.String.op_Equality(a:  -1716807968, b:  purchase.id)) == false)
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
        if((this.<BankFull>k__BackingField) == true)
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
        
        R4.DetermineBundle();
        R4.ShowPreviewPopup();
        mem2[0] = 1;
        R4.SaveData();
    }
    public override void OnMenuLoaded()
    {
        if((this.<BankFull>k__BackingField) == false)
        {
                return;
        }
        
        if(this.HasExpired() == true)
        {
                return;
        }
        
        if((R4 + 124) == 0)
        {
                R4 + 124 = mem[R4 + 156];
            R4 + 124 = R4 + 156;
            goto label_1;
        }
        
        return;
        label_1:
        mem2[0] = 51;
        R4.ShowMainPopup(endOfChapter:  false, flyout:  false);
        mem2[0] = 1;
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  -1096631968, method:  new IntPtr(3198310304));
        DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1069547520, ignoreTimeScale:  false);
    }
    public override void OnDailyChallengeLevelComplete()
    {
        DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  -1096518944, method:  new IntPtr(3198423328));
        DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1069547520, ignoreTimeScale:  false);
    }
    public override void OnDailyChallengeRewardGranted()
    {
        if(this.GoldCurrencyPending < 1)
        {
                return;
        }
        
        if((this.<EventEnded>k__BackingField) != false)
        {
                return;
        }
        
        this.purchasePoint = 52;
        this.ShowInterstitialPopup(endOfChapter:  false, flyout:  false);
    }
    public override void OnBonusGameGoldCurrencyRewardGranted()
    {
        if(this.GoldCurrencyPending < 1)
        {
                return;
        }
        
        if((this.<EventEnded>k__BackingField) != false)
        {
                return;
        }
        
        this.purchasePoint = 52;
        this.ShowInterstitialPopup(endOfChapter:  false, flyout:  false);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        if((this.<EventEnded>k__BackingField) == true)
        {
                return;
        }
        
        if((this.<BankFull>k__BackingField) == true)
        {
                this.<BankFull>k__BackingField = 51;
            this.purchasePoint = this.<BankFull>k__BackingField;
        }
        
        this.ShowMainPopup(endOfChapter:  false, flyout:  false);
    }
    public override bool get_OverrideEventButton()
    {
        return true;
    }
    public override void OnGameButtonPressed(bool connected)
    {
        if((this.<EventEnded>k__BackingField) == true)
        {
                return;
        }
        
        if((this.<BankFull>k__BackingField) == true)
        {
                this.<BankFull>k__BackingField = 53;
            this.purchasePoint = this.<BankFull>k__BackingField;
        }
        
        this.ShowMainPopup(endOfChapter:  false, flyout:  false);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        float val_5 = (float)this.goldCurrencyTarget;
        decimal val_1 = BankAmountCurrent;
        GameEcon val_2 = App.getGameEcon;
        string val_3 = ToString(format:  null);
        val_5 = ((float)this.<GoldCurrencyGained>k__BackingField) / val_5;
        TheLibraryMainScreen val_4 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        currentData.Add(key:  -1095745712, value:  13152256);
        currentData.Add(key:  -1095745600, value:  8945664);
    }
    public override void OnEventEnded()
    {
        this.ResetSaveData();
    }
    public override void UpdateProgress()
    {
        PiggyBankV2Handler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override int LastProgressTimestamp()
    {
        return PiggyBankV2Handler.LastProgressTimestampPref;
    }
    public override bool EventCompleted()
    {
        if((this.<EventEnded>k__BackingField) != false)
        {
                return true;
        }
        
        if((this.<BankFull>k__BackingField) == false)
        {
                return true;
        }
        
        return this.HasExpired();
    }
    public override bool IsRewardReadyToCollect()
    {
        return (bool)this.<BankFull>k__BackingField;
    }
    public override System.DateTime GetTimeEnd()
    {
        this = R1 + 80;
        return new System.DateTime() {dateData = 1152921512101736096};
    }
    public override string GetMainMenuButtonText()
    {
        bool val_1 = this.HasExpired();
        string val_2 = Localization.Localize(key:  -1128214688, defaultValue:  -1128214784, useSingularKey:  false);
        decimal val_3 = BankAmountCurrent;
        GameEcon val_4 = App.getGameEcon;
        string val_5 = ToString(format:  null);
        string val_6 = Localization.Localize(key:  -1528659216, defaultValue:  -1528659376, useSingularKey:  false);
        string val_7 = System.String.Format(format:  -1094957472, arg0:  -1128214688, arg1:  -1094945416, arg2:  -1528659216);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1128214688, defaultValue:  -1128214784, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        return Localization.Localize(key:  -1128214688, defaultValue:  -1128214784, useSingularKey:  false);
    }
    public override string GetCustomizedEventListItemTimerText()
    {
        var val_2;
        System.TimeSpan val_1 = GetTimeRemaining();
        int val_4 = val_2.Days;
        int val_5 = val_2.Hours;
        int val_6 = val_2.Minutes;
        string val_7 = System.String.Format(format:  -1410608784, arg0:  13152256, arg1:  13152256, arg2:  13152256);
    }
    public System.TimeSpan GetTimeRemaining()
    {
        var val_6;
        var val_7;
        System.TimeSpan val_9;
        ulong val_6 = R1;
        val_6 = 35633028;
        if(val_6.HasExpired() != false)
        {
                val_7 = null;
            val_7 = null;
            val_9 = System.TimeSpan.Zero;
            this = val_9;
            return new System.TimeSpan() {_ticks = val_5._ticks};
        }
        
        val_6 = val_6 + 80;
        val_6 = 0;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_5 = this.Subtract(value:  new System.DateTime() {dateData = val_6});
        return new System.TimeSpan() {_ticks = val_5._ticks};
    }
    public bool IsEventAvailable()
    {
        var val_3 = 1;
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
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        var val_9;
        var val_9 = 25792489;
        val_9 = 9833572 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        PurchaseProxy.currentPurchasePoint = this.purchasePoint;
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageById(packageId:  this.<PackageID>k__BackingField);
        PurchaseModel val_2 = new PurchaseModel(json:  this.<PackageID>k__BackingField);
        decimal val_3 = BankAmountCurrent;
        AddReward(rewardType:  2129282688, amount:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_7});
        bool val_8 = PurchaseProxy.Purchase(purchase:  292597760);
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
                val_1 = true;
            this.<BankFull>k__BackingField = val_1;
            this.<GoldCurrencyGained>k__BackingField = this.goldCurrencyTarget;
        }
        
        this.SaveData();
    }
    public void OnPurchaseSuccess()
    {
        long val_5;
        System.DateTime val_9;
        this.TrackPurchaseMade();
        UnityEngine.PlayerPrefs.DeleteKey(key:  -1093932992);
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_2 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_7 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512102864736}, t:  new System.TimeSpan() {_ticks = val_5});
        this.piggyBankNextReceiveTime = val_9;
        this.<EventEnded>k__BackingField = true;
        this.ResetSaveData();
        this.OnPurchaseAttemptResult.Invoke(obj:  true);
    }
    private void TrackPurchaseMade()
    {
        var val_2;
        string val_1 = this.<PackageID>k__BackingField.Replace(oldValue:  -1127289472, newValue:  -1127289584);
        var val_2 = 25791414;
        val_2 = 9834124 + val_2;
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
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1093572304, defaultValue:  1098586544);
        bool val_2 = System.String.IsNullOrEmpty(value:  -1093572304);
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    private bool HasPassedFeatureCooldown()
    {
        System.DateTime val_4;
        var val_8;
        System.DateTime val_9;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1093460208, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1093460208)) != false)
        {
                val_8 = null;
            val_8 = null;
            val_9 = System.DateTime.MinValue;
        }
        else
        {
                System.DateTime val_3 = SLCDateTime.Parse(dateTime:  -1093448128);
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
        if(((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = this.bundleExpireTime}, t2:  new System.DateTime() {dateData = val_2})) != false) && ((this.<EventEnded>k__BackingField) != true))
        {
                this.<EventEnded>k__BackingField = true;
            this.ResetSaveData();
        }
        
        System.DateTime val_5 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = this.bundleExpireTime}, t2:  new System.DateTime() {dateData = val_2});
    }
    private bool CanShowInterstitialPopup()
    {
        if(this.GoldCurrencyPending < 1)
        {
                this = 0;
        }
        
        if(this.GoldCurrencyPending >= 1)
        {
                this = 240;
        }
        
        if(this.GoldCurrencyPending >= 1)
        {
                this = 0;
        }
        
        return (bool)this;
    }
    private bool CanShowReadyPopup()
    {
        ulong val_3;
        if((this.<BankFull>k__BackingField) == false)
        {
                return (bool)0;
        }
        
        if(this.HasExpired() == true)
        {
                return (bool)0;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        bool val_5 = System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = this.promptCooldownTime});
        if(val_5 == true)
        {
                val_5 = this.<EventEnded>k__BackingField;
        }
        
        if(val_5 == true)
        {
                0 = val_5 >> 5;
        }
        
        return (bool)0;
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
        
        if(PiggyBankV2Handler.hackIgnoreLastPurchase == true)
        {
                return (bool)System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_8});
        }
        
        Player val_2 = App.Player;
        val_13 = 264;
        System.TimeSpan val_3 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_6 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512103781432}, t:  new System.TimeSpan() {_ticks = 264});
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = val_8});
    }
    private void SetPurchaseModel()
    {
        if((System.String.IsNullOrEmpty(value:  this.<PackageID>k__BackingField)) == true)
        {
                return;
        }
        
        twelvegigs.storage.JsonDictionary val_2 = PackagesManager.GetPackageById(packageId:  this.<PackageID>k__BackingField);
        this.purchaseModel = new PurchaseModel(json:  this.<PackageID>k__BackingField);
    }
    private void OnGoldCurrencyTargetMet()
    {
        this.<BankFull>k__BackingField = true;
    }
    private void SetPromptCooldownTime()
    {
        long val_5;
        System.DateTime val_9;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  null);
        System.DateTime val_7 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512104133808}, t:  new System.TimeSpan() {_ticks = val_5});
        this.promptCooldownTime = val_9;
    }
    private void ShowPreviewPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_68 = 1;
        SetupMain();
    }
    private void ShowMainPopup(bool endOfChapter = False, bool flyout = False)
    {
        var val_5;
        if(flyout != false)
        {
                GameBehavior val_1 = App.getBehavior;
            val_5 = 0;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        SetupMain();
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
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_69 = 1;
        this.SetPromptCooldownTime();
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = eventData;
        if((val_11.ContainsKey(key:  -1092205568)) != false)
        {
                object val_2 = val_11.Item[-1092205568];
            val_12 = val_11;
            val_13 = null;
            val_12.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.lapseDurationDays = null;
        }
        
        if((val_11.ContainsKey(key:  -1092205456)) != false)
        {
                object val_4 = val_11.Item[-1092205456];
            val_12 = val_11;
            val_13 = null;
            val_12.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.longTermNonPayer = null;
        }
        
        if((val_11.ContainsKey(key:  -1092205328)) != false)
        {
                object val_6 = val_11.Item[-1092205328];
            val_12 = val_11;
            val_13 = null;
            val_12.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.eventDurationDays = null;
        }
        
        val_14 = "prompt_cool_seconds";
        if((val_11.ContainsKey(key:  -1125332720)) != false)
        {
                object val_8 = val_11.Item[-1125332720];
            val_15 = val_11;
            val_13 = null;
            val_15.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.promptCooldownSeconds = null;
        }
        
        if((val_11.ContainsKey(key:  -1125332608)) == false)
        {
                return;
        }
        
        object val_10 = val_11.Item[-1125332608];
        val_11 = val_11;
        val_15 = null;
        val_11.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.featureCooldownDays = null;
    }
    private void DetermineBundle()
    {
        var val_10;
        var val_11;
        System.DateTime val_14;
        System.DateTime val_17;
        ulong val_22;
        var val_23;
        var val_28;
        string val_29;
        var val_30;
        if((UnityEngine.PlayerPrefs.GetInt(key:  -1093932992, defaultValue:  0)) < 0)
        {
            goto label_1;
        }
        
        this.packageTier = UnityEngine.Mathf.Max(a:  1, b:  UnityEngine.PlayerPrefs.GetInt(key:  -1093932992));
        val_28 = null;
        val_29 = "loaded saved = {0}";
        goto label_43;
        label_1:
        this.packageTier = 0;
        val_30 = 1152921504892043264;
        Player val_4 = App.Player;
        Player val_5 = App.Player;
        float val_28 = 188f;
        val_28 = (2.634441E-43f) / val_28;
        val_28 = val_28 * 100f;
        if(0 >= 0)
        {
            goto label_9;
        }
        
        if(0 >= 0)
        {
            goto label_10;
        }
        
        if(0 >= 0)
        {
            goto label_11;
        }
        
        if(0 <= 0)
        {
            goto label_12;
        }
        
        this.packageTier = 2;
        val_28 = null;
        val_29 = "non-zero avg = {0}";
        goto label_43;
        label_9:
        this.packageTier = 5;
        val_28 = null;
        val_29 = "high avg = {0}";
        goto label_43;
        label_10:
        this.packageTier = 4;
        val_28 = null;
        val_29 = "mid avg = {0}";
        goto label_43;
        label_11:
        this.packageTier = 3;
        val_28 = null;
        val_29 = "low avg = {0}";
        label_43:
        string val_6 = System.String.Format(format:  -1092088704, arg0:  13152256);
        label_42:
        this.lastPackageLogic = val_29;
        this.<PackageID>k__BackingField = this.econ.packageTierIDs[this.packageTier];
        this.goldCurrencyTarget = this.econ.goldCurrencyNeeded[this.packageTier];
        int val_31 = this.econ.minBankFund[this.packageTier];
        decimal val_7 = System.Decimal.op_Implicit(value:  -1091908520);
        int val_32 = this.econ.maxBankFund[this.packageTier];
        decimal val_8 = System.Decimal.op_Implicit(value:  -1091908536);
        int val_33 = this.packageTier;
        val_33 = val_33 - 1;
        UnityEngine.PlayerPrefs.SetInt(key:  -1093932992, value:  val_33);
        this.GoldCurrencyPending = 0;
        this.<GoldCurrencyGained>k__BackingField = 0;
        this.<GoldCurrencyGainedOld>k__BackingField = 0;
        this.<BankFull>k__BackingField = 0;
        System.DateTime val_9 = DateTimeCheat.UtcNow;
        System.DateTime val_12 = AddDays(value:  null);
        this.bundleExpireTime = val_14;
        System.DateTime val_15 = AddDays(value:  null);
        this.piggyBankNextReceiveTime = val_17;
        this.isTriggered = 0;
        this.SetPurchaseModel();
        this.SaveData();
        return;
        label_12:
        Player val_18 = App.Player;
        System.DateTime val_19 = DateTimeCheat.UtcNow;
        int val_34 = this.longTermNonPayer;
        val_34 = 0 - val_34;
        System.DateTime val_21 = AddDays(value:  null);
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = 4096}, t2:  new System.DateTime() {dateData = val_22})) < 1)
        {
            goto label_39;
        }
        
        this.packageTier = 1;
        val_14 = 1;
        System.DateTime val_25 = DateTimeCheat.UtcNow;
        int val_35 = this.longTermNonPayer;
        val_35 = 0 - val_35;
        System.DateTime val_26 = AddDays(value:  null);
        val_10 = val_22;
        val_11 = val_23;
        string val_27 = System.String.Format(format:  -1091920672, arg0:  13152256, arg1:  9904128);
        goto label_42;
        label_39:
        this.packageTier = 0;
        goto label_43;
    }
    private void SaveData()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1091640512, value:  13152256);
        Add(key:  -1091640400, value:  13152256);
        Add(key:  -1091640288, value:  9904128);
        Add(key:  -1091640192, value:  13152256);
        Add(key:  -1091640080, value:  8945664);
        string val_2 = this.piggyBankNextReceiveTime.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1093460208, value:  this.piggyBankNextReceiveTime);
        string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1093572304, value:  78753792);
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private void LoadData()
    {
        System.DateTime val_16;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        val_23 = "pbv2EventData";
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1093572304, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1093572304)) == true)
        {
                return;
        }
        
        val_24 = 0;
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -1093572304, defaultValue:  1098586544);
        object val_4 = MiniJSON.Json.Deserialize(json:  -1093572304);
        if("pbv2EventData" != 0)
        {
                if(null == null)
        {
            goto label_22;
        }
        
        }
        
        label_22:
        if((val_24.ContainsKey(key:  -1091640512)) != false)
        {
                string val_6 = val_24.Item[-1091640512];
            val_25 = val_24;
            val_26 = null;
            val_25.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.<GoldCurrencyGained>k__BackingField = 1179403647;
        }
        
        if((val_24.ContainsKey(key:  -1091640400)) != false)
        {
                string val_8 = val_24.Item[-1091640400];
            val_25 = val_24;
            val_26 = null;
            val_25.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.GoldCurrencyPending = 1179403647;
        }
        
        if((val_24.ContainsKey(key:  -1091640288)) != false)
        {
                string val_10 = val_24.Item[-1091640288];
            System.DateTime val_11 = System.DateTime.UtcNow;
            val_27 = 0;
            if(val_24 != 0)
        {
                if(1179403647 != null)
        {
                val_27 = 0;
        }
        else
        {
                val_27 = val_24;
        }
        
        }
        
            System.DateTime val_14 = SLCDateTime.Parse(dateTime:  -1091348096, defaultValue:  new System.DateTime());
            this.bundleExpireTime = val_16;
        }
        
        if((val_24.ContainsKey(key:  -1091640192)) != false)
        {
                string val_18 = val_24.Item[-1091640192];
            val_25 = val_24;
            val_26 = null;
            val_25.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.packageTier = 1179403647;
        }
        
        if((val_24.ContainsKey(key:  -1091640080)) != false)
        {
                string val_20 = val_24.Item[-1091640080];
            val_24 = val_24;
            val_25 = null;
            val_24.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.isTriggered = true;
        }
        
        this.<PackageID>k__BackingField = this.econ.packageTierIDs[this.packageTier];
        this.goldCurrencyTarget = this.econ.goldCurrencyNeeded[this.packageTier];
        int val_25 = this.econ.minBankFund[this.packageTier];
        decimal val_21 = System.Decimal.op_Implicit(value:  -1091348080);
        int val_26 = this.econ.maxBankFund[this.packageTier];
        decimal val_22 = System.Decimal.op_Implicit(value:  -1091348096);
        if((this.<GoldCurrencyGained>k__BackingField) >= this.goldCurrencyTarget)
        {
                val_23 = 1;
        }
        
        this.<BankFull>k__BackingField = true;
        this.SetPurchaseModel();
    }
    private void ResetSaveData()
    {
        null = null;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = this.piggyBankNextReceiveTime}, t2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                string val_2 = this.piggyBankNextReceiveTime.ToString();
            UnityEngine.PlayerPrefs.SetString(key:  -1093460208, value:  this.piggyBankNextReceiveTime);
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  -1093572304, value:  1098586544);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        goto typeof(PiggyBankV2Handler).__il2cppRuntimeField_17C;
    }
    public void HackReInit()
    {
        this.ResetSaveData();
        goto typeof(PiggyBankV2Handler).__il2cppRuntimeField_11C;
    }
    public void HackResetProgress()
    {
        this.<GoldCurrencyGained>k__BackingField = 0;
        this.<BankFull>k__BackingField = 0;
        this.GoldCurrencyPending = 0;
        this.<GoldCurrencyGainedOld>k__BackingField = 0;
        this.SaveData();
    }
    public void HackSetBankAlmostFull()
    {
        int val_1 = this.goldCurrencyTarget;
        this.<BankFull>k__BackingField = false;
        this.GoldCurrencyPending = false;
        val_1 = val_1 - 1;
        this.<GoldCurrencyGained>k__BackingField = val_1;
        this.<GoldCurrencyGainedOld>k__BackingField = val_1;
    }
    public void HackSetBundleReady()
    {
        int val_1 = this.<GoldCurrencyGained>k__BackingField;
        val_1 = this.goldCurrencyTarget - val_1;
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
        System.DateTime val_3 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512106385424}, t:  new System.TimeSpan());
        this.bundleExpireTime = val_5;
        System.TimeSpan val_6 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_9 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512106385408}, t:  new System.TimeSpan() {_ticks = val_5});
        this.piggyBankNextReceiveTime = val_11;
    }
    public System.DateTime HackLongTimePurchaseDate()
    {
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        var val_5 = R1 + 20;
        val_5 = 0 - val_5;
        System.DateTime val_4 = this.AddDays(value:  null);
        return new System.DateTime() {dateData = val_4.dateData};
    }
    public string HackLastPackageLogic()
    {
    
    }
    public static void HackResetFeatureCooldown()
    {
        var val_3 = null;
        string val_1 = System.DateTime.MinValue.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1093460208, value:  -1090051928);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static void HackIgnoreLastPurchaseDate()
    {
        bool val_1 = PiggyBankV2Handler.hackIgnoreLastPurchase;
        val_1 = val_1 ^ 1;
        PiggyBankV2Handler.hackIgnoreLastPurchase = val_1;
    }
    public static string HackNextAvailableDate()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1093460208, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1093460208)) == true)
        {
                "pbv2NextReceive" = "null";
        }
    
    }
    public PiggyBankV2Handler()
    {
        var val_2;
        this.eventDurationDays = 14;
        this.goldCurrencyTarget = 0;
        val_2 = null;
        val_2 = null;
        this.bundleExpireTime = System.DateTime.MaxValue;
        this.econ = new PiggyBankV2Econ();
        this.lastPackageLogic = "undetermined";
    }
    private void <OnLevelComplete>b__86_0()
    {
        if(this.isTriggered == false)
        {
                return;
        }
        
        if((this.<EventEnded>k__BackingField) == true)
        {
                return;
        }
        
        MainController val_1 = MainController.instance;
        if(0 != 0)
        {
                MainController val_3 = MainController.instance;
            bool val_4 = 0.IsChapterComplete;
        }
        
        if((R4 + 44) >= 1)
        {
                if((R4 + 124) == 0)
        {
            goto label_11;
        }
        
        }
        
        if(R4.CanShowReadyPopup() == false)
        {
                return;
        }
        
        mem2[0] = 52;
        R4.ShowMainPopup(endOfChapter:  false, flyout:  false);
        return;
        label_11:
        mem2[0] = 52;
        R4.ShowInterstitialPopup(endOfChapter:  false, flyout:  false);
    }
    private void <OnDailyChallengeLevelComplete>b__87_0()
    {
        if(this.GoldCurrencyPending < 1)
        {
                return;
        }
        
        if((this.<EventEnded>k__BackingField) != false)
        {
                return;
        }
        
        this.purchasePoint = 52;
        this.ShowInterstitialPopup(endOfChapter:  false, flyout:  false);
    }

}
