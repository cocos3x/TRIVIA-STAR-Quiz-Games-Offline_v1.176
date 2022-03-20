using UnityEngine;
public class WGSubscriptionManager : MonoSingleton<WGSubscriptionManager>
{
    // Fields
    private const string golden_ticket_purchased = "gt_purchased";
    private const string silver_ticket_purchased = "st_purchased";
    private static TrackerPurchasePoints _subEntryPoint;
    public System.Action<bool> purchaseResult;
    public System.Action<bool, WGSubscriptionManager.collectResultStatus> onCollectAttemptResult;
    
    // Properties
    public static bool HasSubscribedGoldenTicket { get; set; }
    public static bool HasSubscribedSilverTicket { get; set; }
    public static TrackerPurchasePoints subEntryPoint { get; set; }
    public static bool WillGetFreeTrial_Golden { get; }
    public static bool WillGetFreeTrial_Silver { get; }
    public static bool WillGetFreeTrial { get; }
    public string pointMultiplier { get; }
    public string pointXMoreMultiplier { get; }
    public bool silverTicketUnlocked { get; }
    
    // Methods
    public static bool get_HasSubscribedGoldenTicket()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1221669760, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public static void set_HasSubscribedGoldenTicket(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1221669760, value:  value);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static bool get_HasSubscribedSilverTicket()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1221445664, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public static void set_HasSubscribedSilverTicket(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1221445664, value:  value);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static TrackerPurchasePoints get_subEntryPoint()
    {
    
    }
    public static void set_subEntryPoint(TrackerPurchasePoints value)
    {
        WGSubscriptionManager._subEntryPoint = value;
    }
    public static int GetAdditionalPoints(int basePoints)
    {
        var val_11;
        var val_12;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_11 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance();
        val_12 = 0;
        if((-1897280256) == 0)
        {
                return (int)val_12;
        }
        
        GameBehavior val_3 = App.getBehavior;
        val_12 = 0;
        if(0 == 0)
        {
                return (int)val_12;
        }
        
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        val_11 = public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance();
        val_12 = 0;
        if((-1976887008) == 0)
        {
                return (int)val_12;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = 0;
        if((hasSubscription(subPackage:  0)) == false)
        {
                return (int)val_12;
        }
        
        WGBonusRewardsHandler val_8 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        float val_10 = (float)basePoints;
        val_10 = (public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_4C) * val_10;
        val_12 = (UnityEngine.Mathf.RoundToInt(f:  val_10)) - basePoints;
        return (int)val_12;
    }
    public static float GetPointMultiplier()
    {
        float val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = 0f;
        if((-1897280256) == 0)
        {
                return (float)S0;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
                return (float)S0;
        }
        
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((-1976887008) == 0)
        {
                return (float)S0;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((hasSubscription(subPackage:  0)) == false)
        {
                return (float)S0;
        }
        
        WGBonusRewardsHandler val_8 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        return (float)S0;
    }
    public static bool get_WillGetFreeTrial_Golden()
    {
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((-1976887008) == 0)
        {
                return false;
        }
        
        WGBonusRewardsHandler val_6 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance()) != 0)
        {
                return freeTrialEnabledGolden;
        }
        
        return freeTrialEnabledGolden;
    }
    public static bool get_WillGetFreeTrial_Silver()
    {
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((-1976887008) == 0)
        {
                return false;
        }
        
        WGBonusRewardsHandler val_6 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance()) != 0)
        {
                return freeTrialEnabledSilver;
        }
        
        return freeTrialEnabledSilver;
    }
    public static bool get_WillGetFreeTrial()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return false;
        }
        
        if(WGSubscriptionManager.WillGetFreeTrial_Golden == false)
        {
                return false;
        }
        
        return WGSubscriptionManager.WillGetFreeTrial_Silver;
    }
    public bool hasSubscription(SubscriptionHandler.SubScriptionType subPackage = 0)
    {
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance()) != 0)
        {
                return IsActive(subPackage:  subPackage);
        }
        
        return IsActive(subPackage:  subPackage);
    }
    public bool canCollectSubscription(SubscriptionHandler.SubScriptionType subPackage = 0)
    {
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance()) != 0)
        {
                return CanCollect(subPackage:  subPackage);
        }
        
        return CanCollect(subPackage:  subPackage);
    }
    public bool hasAnySubscription()
    {
        bool val_1 = this.hasSubscription(subPackage:  0);
        if(val_1 == true)
        {
                val_1 = 1;
            return (bool)val_1;
        }
        
        return this.hasSubscription(subPackage:  1);
    }
    public int promoDailyCoinsAmount(SubscriptionHandler.SubScriptionType subPackage)
    {
        var val_7;
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        val_7 = 0;
        if((-1976887008) == 0)
        {
                return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_40;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 != 0)
        {
                WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if((public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance()) != 0)
        {
                return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_40;
        }
        
            return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_40;
        }
        
        if(subPackage != 1)
        {
                val_7 = 0;
            if(subPackage != 0)
        {
                return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_40;
        }
        
            WGBonusRewardsHandler val_5 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if((public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance()) != 0)
        {
                return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_40;
        }
        
            return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_40;
        }
        
        WGBonusRewardsHandler val_6 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_40;
    }
    public string get_pointMultiplier()
    {
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        string val_2 = public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_4C.ToString();
    }
    public string get_pointXMoreMultiplier()
    {
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        float val_4 = -1f;
        val_4 = (public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_4C) + val_4;
        val_4 = val_4 * 100f;
        GameEcon val_2 = App.getGameEcon;
        string val_3 = val_4.ToString(format:  null);
    }
    public bool get_silverTicketUnlocked()
    {
        var val_7 = 1;
        if((this.hasSubscription(subPackage:  1)) == true)
        {
                return (bool)val_7;
        }
        
        GameBehavior val_2 = App.getBehavior;
        WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        val_7 = 0;
        bool val_4 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_48);
        if(val_4 == false)
        {
                return (bool)val_7;
        }
        
        val_7 = (val_4.hasSubscription(subPackage:  0)) ^ 1;
        return (bool)val_7;
    }
    public int freeTrialDaysCount(SubscriptionHandler.SubScriptionType subPackage)
    {
        var val_5;
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        val_5 = 0;
        if((-1976887008) == 0)
        {
                return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_54;
        }
        
        if(subPackage != 1)
        {
                if(subPackage != 0)
        {
                return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_54;
        }
        
            WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if((public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance()) != 0)
        {
                return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_54;
        }
        
            return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_54;
        }
        
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        return (int)public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_54;
    }
    public override void InitMonoSingleton()
    {
        var val_12;
        var val_13;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1219474560, method:  new IntPtr(3075466688));
        System.Delegate val_4 = System.Delegate.Combine(a:  public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_30, b:  7401472);
        val_12 = public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_30;
        if(val_12 != 0)
        {
                if(val_12 == null)
        {
            goto label_11;
        }
        
        }
        
        val_12 = 0;
        label_11:
        public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_30 = val_12;
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_6 = new System.Action<Result>(object:  -1219474560, method:  new IntPtr(3075467712));
        System.Delegate val_7 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_13 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_13 != 0)
        {
                if(val_13 == null)
        {
            goto label_17;
        }
        
        }
        
        val_13 = 0;
        label_17:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_13;
        if((val_13.hasSubscription(subPackage:  0)) != false)
        {
                bool val_9 = WGSubscriptionManager.HasSubscribedGoldenTicket;
            if(val_9 == false)
        {
                val_9 = 1;
            WGSubscriptionManager.HasSubscribedGoldenTicket = true;
        }
        
        }
        
        if((this.hasSubscription(subPackage:  1)) == false)
        {
                return;
        }
        
        if(WGSubscriptionManager.HasSubscribedSilverTicket != false)
        {
                return;
        }
        
        WGSubscriptionManager.HasSubscribedSilverTicket = true;
    }
    public static float GetInitialPriceForPackage(SubscriptionHandler.SubScriptionType subPack)
    {
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageBySubscriptionID(packageType:  -1804579328, instruction:  subPack);
        if((Contains(key:  1350423184)) == false)
        {
                return (float)S0;
        }
        
        if("special" != 0)
        {
                return getFloat(key:  1350423184, defaultValue:  null);
        }
        
        return getFloat(key:  1350423184, defaultValue:  null);
    }
    public string GetInitialCostForPackage(SubscriptionHandler.SubScriptionType subPack)
    {
        float val_1 = WGSubscriptionManager.GetInitialPriceForPackage(subPack:  subPack);
        string val_2 = subPack.ToString(format:  -1797462704);
    }
    public string GetPromoCostForPackage(SubscriptionHandler.SubScriptionType subPack)
    {
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageBySubscriptionID(packageType:  -1804579328, instruction:  subPack);
        float val_2 = getFloat(key:  -1816221696, defaultValue:  null);
        string val_3 = "special".ToString(format:  -1797462704);
        string val_4 = getString(key:  -1816221600, defaultValue:  -1219130100);
    }
    public void TryPurchase(SubscriptionHandler.SubScriptionType subPackage)
    {
        SubScriptionType val_25;
        var val_26;
        float val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_33;
        var val_34;
        var val_35;
        val_25 = subPackage;
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1218995616, method:  new IntPtr(3075945408));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_34, b:  7401472);
        val_26 = public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_34;
        if(val_26 != 0)
        {
                if(val_26 == null)
        {
            goto label_6;
        }
        
        }
        
        val_26 = 0;
        label_6:
        var val_25 = 25527470;
        public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_34 = val_26;
        val_25 = 10106244 + val_25;
        if(val_25 == 0)
        {
                mem2[0] = 1;
        }
        
        val_27 = 1152921504899551232;
        var val_26 = 25519713;
        val_26 = 10106348 + val_26;
        if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
        val_28 = null;
        val_28 = null;
        PurchaseProxy.currentPurchasePoint = WGSubscriptionManager._subEntryPoint;
        twelvegigs.storage.JsonDictionary val_4 = PackagesManager.GetPackageBySubscriptionID(packageType:  -1804579328, instruction:  val_25);
        PurchaseModel val_5 = new PurchaseModel(json:  -1804579328);
        bool val_27 = false;
        val_27 = val_27 & WGSubscriptionManager.HasSubscribedGoldenTicket ^ 1;
        AddTrackingInfo(infoKey:  -1219020864, infoValue:  8945664);
        val_29 = "1st ST Subscription";
        bool val_9 = WGSubscriptionManager.HasSubscribedSilverTicket ^ 1;
        val_9 = ((val_25 - 1) >> 5) & val_9;
        val_30 = null;
        AddTrackingInfo(infoKey:  -1219020752, infoValue:  8945664);
        if(val_25 == 0)
        {
                if(WGSubscriptionManager.HasSubscribedGoldenTicket != false)
        {
                twelvegigs.storage.JsonDictionary val_13 = PackagesManager.GetPackageBySubscriptionID(packageType:  -1804579328, instruction:  0);
            val_29 = "special";
            val_31 = val_29;
            float val_14 = getFloat(key:  -1816221696, defaultValue:  null);
        }
        else
        {
                val_31 = 0;
        }
        
            typeof(PurchaseModel).__il2cppRuntimeField_5C = 0;
        }
        
        if(val_25 == 1)
        {
                if(WGSubscriptionManager.HasSubscribedSilverTicket != false)
        {
                twelvegigs.storage.JsonDictionary val_17 = PackagesManager.GetPackageBySubscriptionID(packageType:  -1804579328, instruction:  1);
            val_29 = "special";
            val_33 = val_29;
            float val_18 = getFloat(key:  -1816221696, defaultValue:  WGSubscriptionManager.GetInitialPriceForPackage(subPack:  0));
        }
        else
        {
                val_33 = 1;
            float val_19 = WGSubscriptionManager.GetInitialPriceForPackage(subPack:  1);
        }
        
            typeof(PurchaseModel).__il2cppRuntimeField_5C = 1;
        }
        
        if((PurchaseProxy.Purchase(purchase:  292597760)) == false)
        {
            goto label_33;
        }
        
        if(val_25 == 0)
        {
            goto label_34;
        }
        
        if(val_25 != 1)
        {
                return;
        }
        
        WGSubscriptionManager.HasSubscribedSilverTicket = true;
        return;
        label_33:
        WordPets.WPTDataParser val_21 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        string val_22 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        val_25 = "purchase_failed_upper";
        val_34 = 0;
        string val_23 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        val_29 = "purchase_failed_explanation";
        val_27 = 1152921504931180544;
        val_35 = null;
        val_35 = null;
        if((WGSubscriptionManager.<>c.<>9__38_0) == 0)
        {
                val_34 = 0;
            System.Action val_24 = new System.Action(object:  WGSubscriptionManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3075946656));
            WGSubscriptionManager.<>c.<>9__38_0 = null;
        }
        
        HandlePurchaseFailed(title:  -1349324784, message:  -1349324672, onCloseMessageAction:  0);
        return;
        label_34:
        WGSubscriptionManager.HasSubscribedGoldenTicket = true;
    }
    public void UITryCollect(SubscriptionHandler.SubScriptionType subPackage)
    {
        if((this.canCollectSubscription(subPackage:  subPackage)) != false)
        {
                WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            CollectSubscription(subPackage:  subPackage);
            return;
        }
        
        if(this.onCollectAttemptResult == 0)
        {
                return;
        }
        
        this.onCollectAttemptResult.Invoke(arg1:  false, arg2:  3);
    }
    private void HandleCollectionResponse(System.Collections.Generic.Dictionary<string, object> response)
    {
        System.Collections.IDictionary val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_12 = response;
        if(val_12 == 0)
        {
            goto label_1;
        }
        
        val_13 = "success";
        if((val_12.ContainsKey(key:  1616271776)) == false)
        {
            goto label_4;
        }
        
        twelvegigs.storage.JsonDictionary val_2 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  val_12);
        if((getBool(key:  1616271776)) == false)
        {
            goto label_4;
        }
        
        if((Contains(key:  -1812972384)) == false)
        {
            goto label_33;
        }
        
        if(0 == 0)
        {
            goto label_9;
        }
        
        val_13 = 0;
        label_11:
        val_12 = mem[R3 + 0];
        val_12 = R3 + 0;
        if(val_12 == null)
        {
            goto label_10;
        }
        
        val_13 = val_13 + 1;
        if(((uint)val_13 & 65535) < 0)
        {
            goto label_11;
        }
        
        label_9:
        val_14 = twelvegigs.storage.JsonDictionary.__il2cppRuntimeField_name;
        goto label_12;
        label_4:
        if(this.onCollectAttemptResult == 0)
        {
                return;
        }
        
        val_15 = 2;
        val_16 = 1152921511977886240;
        goto label_16;
        label_1:
        if(this.onCollectAttemptResult == 0)
        {
                return;
        }
        
        val_15 = 1;
        val_16 = 1152921511977886240;
        goto label_16;
        label_10:
        var val_5 = R3 + 0;
        var val_12 = (R3 + 0) + 4;
        val_12 = JsonDictionary + (val_12 << 3);
        val_14 = val_12 + 188;
        label_12:
        twelvegigs.storage.JsonDictionary val_6 = getJsonDictionary(key:  -1812972384);
        string val_7 = getString(key:  -1830072288, defaultValue:  1098586544);
        val_13 = 1152921504892043264;
        AppConfigs val_8 = App.Configuration;
        if((Equals(value:  null)) != false)
        {
                this.CollectSub_Gold();
            return;
        }
        
        AppConfigs val_10 = App.Configuration;
        val_12 = 0;
        if((Equals(value:  null)) != false)
        {
                this.CollectSub_Silver();
            return;
        }
        
        label_33:
        if(this.onCollectAttemptResult == 0)
        {
                return;
        }
        
        val_15 = 4;
        val_16 = 1152921511977886240;
        label_16:
        this.onCollectAttemptResult.Invoke(arg1:  false, arg2:  4);
    }
    private void CollectSub_Gold()
    {
        int val_11;
        string val_12;
        string val_13;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                val_12 = 0;
            Player val_3 = App.Player;
            0.AddGems(amount:  this.promoDailyCoinsAmount(subPackage:  0), source:  -1218629344, subsource:  null);
            Player val_5 = App.Player;
            int val_6 = this.promoDailyCoinsAmount(subPackage:  0);
            string val_7 = val_6.ToString();
            val_13;
            0.TrackNonCoinReward(source:  -1218629216, subSource:  null, rewardType:  -1668821072, rewardAmount:  val_6, additionalParams:  0);
        }
        else
        {
                Player val_8 = App.Player;
            int val_9 = this.promoDailyCoinsAmount(subPackage:  0);
            val_12 = 0;
            decimal val_10 = System.Decimal.op_Implicit(value:  -1218612900);
            val_13 = "Golden Ticket Daily Coins";
            0.AddCredits(amount:  new System.Decimal() {mid = val_11}, source:  val_13, subSource:  val_12, externalParams:  val_12, doTrack:  true);
        }
        
        if(this.onCollectAttemptResult == 0)
        {
                return;
        }
        
        this.onCollectAttemptResult.Invoke(arg1:  true, arg2:  0);
    }
    private void CollectSub_Silver()
    {
        int val_11;
        string val_12;
        string val_13;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                val_12 = 0;
            Player val_3 = App.Player;
            0.AddGems(amount:  this.promoDailyCoinsAmount(subPackage:  1), source:  -1218629344, subsource:  null);
            Player val_5 = App.Player;
            int val_6 = this.promoDailyCoinsAmount(subPackage:  0);
            string val_7 = val_6.ToString();
            val_13;
            0.TrackNonCoinReward(source:  -1218508752, subSource:  null, rewardType:  -1668821072, rewardAmount:  val_6, additionalParams:  0);
        }
        else
        {
                Player val_8 = App.Player;
            int val_9 = this.promoDailyCoinsAmount(subPackage:  1);
            val_12 = 0;
            decimal val_10 = System.Decimal.op_Implicit(value:  -1218492436);
            val_13 = "Silver Ticket Daily Coins";
            0.AddCredits(amount:  new System.Decimal() {mid = val_11}, source:  val_13, subSource:  val_12, externalParams:  val_12, doTrack:  true);
        }
        
        if(this.onCollectAttemptResult == 0)
        {
                return;
        }
        
        this.onCollectAttemptResult.Invoke(arg1:  true, arg2:  0);
    }
    private void OnSubscriptionPurchaseAttempt(bool result)
    {
        var val_4;
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1218360192, method:  new IntPtr(3075945408));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_34, value:  7401472);
        val_4 = public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_34;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_34 = val_4;
        if(this.purchaseResult == 0)
        {
                return;
        }
        
        this.purchaseResult.Invoke(obj:  result);
    }
    private void OnSceneChanged(SceneType type)
    {
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        UpdateOnSceneChanged();
    }
    public System.DateTime getNextCollectTime(SubscriptionHandler.SubScriptionType subPackage)
    {
        var val_10;
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        val_10 = public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance();
        if((IsActive(subPackage:  R2)) != false)
        {
                WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            val_10 = public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance();
            SubscriptionModel val_4 = getCurrentModel(subPackage:  R2);
            System.DateTime val_5 = collectedTime;
            System.DateTime val_8 = this.AddDays(value:  null);
            return new System.DateTime() {dateData = val_9.dateData};
        }
        
        UnityEngine.Debug.LogError(message:  -1218143808);
        System.DateTime val_9 = DateTimeCheat.UtcNow;
        return new System.DateTime() {dateData = val_9.dateData};
    }
    public System.DateTime getSubscriptionStartTime(SubscriptionHandler.SubScriptionType subPackage)
    {
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((IsActive(subPackage:  R2)) != false)
        {
                WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            SubscriptionModel val_4 = getCurrentModel(subPackage:  R2);
            System.DateTime val_5 = this.startTime;
            return new System.DateTime() {dateData = val_5.dateData};
        }
        
        UnityEngine.Debug.LogError(message:  -1218143808);
        System.DateTime val_6 = DateTimeCheat.UtcNow;
        return new System.DateTime() {dateData = val_6.dateData};
    }
    private void OnDestroy()
    {
        var val_7;
        var val_8;
        WGBonusRewardsHandler val_1 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1217883328, method:  new IntPtr(3075466688));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_30, value:  7401472);
        val_7 = public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_30;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_6;
        }
        
        }
        
        val_7 = 0;
        label_6:
        public static SubscriptionHandler DefaultHandler<SubscriptionHandler>::get_Instance().__il2cppRuntimeField_30 = val_7;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -1217883328, method:  new IntPtr(3075467712));
        System.Delegate val_6 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_12;
        }
        
        }
        
        val_8 = 0;
        label_12:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
    }
    public WGSubscriptionManager()
    {
    
    }

}
