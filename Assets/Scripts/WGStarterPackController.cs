using UnityEngine;
public class WGStarterPackController : MonoSingleton<WGStarterPackController>
{
    // Fields
    private const string lastShownKey = "starterPackLastShownAt";
    public const string sawPromptedPopup = "starterPackPrompted";
    private TrackerPurchasePoints _ap;
    private bool setListener;
    public System.Action<bool, System.Decimal> purchaseResult;
    private WGStarterPackStoreItem _prefab_starter_pack_store_item;
    private WGStarterPackStoreItem storeItemInstance;
    
    // Properties
    public static bool featureRelavent { get; }
    public static bool HasSeenExpiredStarterPack { get; }
    public static bool IsInStarterPackDelay { get; }
    public static bool StarterPackActive { get; }
    private static System.DateTime starterPackShownAt { get; }
    public static bool starterPackTimerStarted { get; }
    public static System.DateTime starterPackEndedAt { get; }
    public System.TimeSpan timeRemaining { get; }
    public TrackerPurchasePoints setAccessPoint { set; }
    public TrackerPurchasePoints getAccessPoint { get; }
    private WGStarterPackStoreItem Prefab_starter_pack_store_item { get; }
    
    // Methods
    public static bool get_featureRelavent()
    {
        var val_20;
        var val_27;
        Player val_1 = App.Player;
        if(188 < 1)
        {
            goto label_4;
        }
        
        val_27 = 0;
        CompanyDevices val_2 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_27;
        }
        
        label_59:
        val_27 = 0;
        label_66:
        UnityEngine.Debug.Log(message:  61567776);
        return (bool)val_27;
        label_4:
        GameEcon val_4 = App.getGameEcon;
        if(84 == 0)
        {
            goto label_14;
        }
        
        Player val_5 = App.Player;
        GameEcon val_6 = App.getGameEcon;
        if(0 >= 786450)
        {
            goto label_19;
        }
        
        CompanyDevices val_7 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_27;
        }
        
        goto label_59;
        label_14:
        CompanyDevices val_9 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_27;
        }
        
        goto label_59;
        label_19:
        if(WGStarterPackController.starterPackTimerStarted == true)
        {
            goto label_39;
        }
        
        Player val_12 = App.Player;
        GameEcon val_13 = App.getGameEcon;
        if(0 <= 786450)
        {
            goto label_39;
        }
        
        CompanyDevices val_14 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_27;
        }
        
        goto label_59;
        label_39:
        if(WGStarterPackController.starterPackTimerStarted == false)
        {
            goto label_52;
        }
        
        System.DateTime val_17 = WGStarterPackController.starterPackShownAt;
        System.DateTime val_18 = DateTimeCheat.UtcNow;
        System.TimeSpan val_19 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513258362568}, d2:  new System.DateTime());
        double val_22 = val_20.TotalMinutes;
        CompanyDevices val_23 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_27;
        }
        
        goto label_59;
        label_52:
        CompanyDevices val_25 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_27;
        }
        
        goto label_66;
    }
    public static bool get_HasSeenExpiredStarterPack()
    {
        ulong val_6;
        var val_9;
        if(WGStarterPackController.starterPackTimerStarted == false)
        {
                return true;
        }
        
        System.DateTime val_2 = WGStarterPackController.starterPackShownAt;
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513258474576}, d2:  new System.DateTime() {dateData = val_6});
        double val_11 = val_9.TotalMinutes;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished < 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static bool get_IsInStarterPackDelay()
    {
        var val_5;
        if(WGStarterPackController.starterPackTimerStarted == false)
        {
                return true;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.DateTime val_3 = WGStarterPackController.starterPackEndedAt;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513258586576}, d2:  new System.DateTime());
        double val_7 = val_5.TotalMinutes;
        GameEcon val_8 = App.getGameEcon;
        double val_9 = 952.TotalMinutes;
        if(0 < 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static bool get_StarterPackActive()
    {
        ulong val_3;
        ulong val_5;
        var val_11;
        System.DateTime val_1 = WGStarterPackController.starterPackShownAt;
        val_11 = 0;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_5}, t2:  new System.DateTime() {dateData = val_3})) == false)
        {
                return (bool)val_11;
        }
        
        System.DateTime val_8 = WGStarterPackController.starterPackEndedAt;
        System.DateTime val_9 = DateTimeCheat.UtcNow;
        val_11 = System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_5}, t2:  new System.DateTime() {dateData = val_3});
        return (bool)val_11;
    }
    private static System.DateTime get_starterPackShownAt()
    {
        if((CPlayerPrefs.HasKey(key:  62017056)) != false)
        {
                string val_2 = CPlayerPrefs.GetString(key:  62017056);
            System.DateTime val_3 = DateTimeCheat.UtcNow;
            System.DateTime val_6 = SLCDateTime.Parse(dateTime:  null, defaultValue:  new System.DateTime() {dateData = 1152921513258798624});
            return new System.DateTime() {dateData = val_6.dateData};
        }
        
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        return new System.DateTime() {dateData = val_7.dateData};
    }
    public static bool get_starterPackTimerStarted()
    {
        return CPlayerPrefs.HasKey(key:  62017056);
    }
    public static System.DateTime get_starterPackEndedAt()
    {
        if((CPlayerPrefs.HasKey(key:  62017056)) != false)
        {
                System.DateTime val_2 = WGStarterPackController.starterPackShownAt;
            GameEcon val_5 = App.getGameEcon;
            System.DateTime val_6 = 0.Add(value:  new System.TimeSpan() {_ticks = 1152921513259034704});
            return new System.DateTime() {dateData = val_7.dateData};
        }
        
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        return new System.DateTime() {dateData = val_7.dateData};
    }
    public System.TimeSpan get_timeRemaining()
    {
        ulong val_5;
        var val_10;
        if((CPlayerPrefs.HasKey(key:  62017056)) != false)
        {
                System.DateTime val_2 = WGStarterPackController.starterPackShownAt;
            System.DateTime val_3 = DateTimeCheat.UtcNow;
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513259158736}, d2:  new System.DateTime() {dateData = val_5});
            return new System.TimeSpan() {_ticks = 682};
        }
        
        GameEcon val_9 = App.getGameEcon;
        val_10 = 682;
        this = 143682324091896490;
        return new System.TimeSpan() {_ticks = 682};
    }
    public void set_setAccessPoint(TrackerPurchasePoints value)
    {
        this._ap = value;
    }
    public TrackerPurchasePoints get_getAccessPoint()
    {
    
    }
    private WGStarterPackStoreItem get_Prefab_starter_pack_store_item()
    {
        if(this._prefab_starter_pack_store_item != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1262000640);
        this._prefab_starter_pack_store_item = "Store";
    }
    public static void SetTimeShown()
    {
        var val_7;
        if((CPlayerPrefs.HasKey(key:  62017056)) == true)
        {
                return;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        GameEcon val_5 = App.getGameEcon;
        System.DateTime val_6 = Add(value:  new System.TimeSpan() {_ticks = 1152921513259628496});
        string val_9 = val_7.ToString();
        CPlayerPrefs.SetString(key:  62017056, val:  62846928);
        CPlayerPrefs.Save();
    }
    public void TryMakePurchase()
    {
        PurchaseModel val_4;
        var val_5;
        bool val_1 = WGStarterPackController.featureRelavent;
        val_4 = 0;
        if(val_1 != false)
        {
                PurchaseModel val_2 = WGStarterPackController.GetStarterPack();
            val_4 = val_1;
        }
        
        var val_4 = 25590181;
        val_4 = 10035880 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        PurchaseProxy.currentPurchasePoint = this._ap;
        bool val_3 = PurchaseProxy.Purchase(purchase:  val_4);
    }
    public void OnPurchaseSuccess(PurchaseModel purchase)
    {
        int val_2;
        int val_3;
        int val_4;
        int val_5;
        if(this.purchaseResult == 0)
        {
                return;
        }
        
        decimal val_1 = Credits;
        35633491 = public System.Void System.Action<System.Boolean, System.Decimal>::Invoke(System.Boolean arg1, System.Decimal arg2);
        this.purchaseResult.Invoke(arg1:  true, arg2:  new System.Decimal() {flags = val_2, hi = val_3, lo = val_4, mid = val_5});
    }
    public void OnPurchaseFail()
    {
        var val_1;
        if(this.purchaseResult == 0)
        {
                return;
        }
        
        val_1 = null;
        val_1 = null;
        this.purchaseResult.Invoke(arg1:  false, arg2:  new System.Decimal() {flags = System.Decimal.Zero, lo = ???, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
    }
    public bool TryShowPopup()
    {
        var val_11;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.Debug.Log(message:  63315728);
        }
        
        val_11 = 0;
        if((CPlayerPrefs.GetInt(key:  63315856, defaultValue:  0)) > 0)
        {
                return (bool)val_11;
        }
        
        if(WGStarterPackController.featureRelavent == false)
        {
                return (bool)val_11;
        }
        
        Player val_5 = App.Player;
        val_11 = 0;
        GameEcon val_6 = App.getGameEcon;
        if(0 != 786450)
        {
                return (bool)val_11;
        }
        
        CompanyDevices val_7 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.Debug.Log(message:  63315968);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_10 = ShowUGUIMonolith<System.Object>(showNext:  false);
        val_11 = 1;
        this._ap = 46;
        return (bool)val_11;
    }
    public override void InitMonoSingleton()
    {
        var val_15;
        System.Delegate val_16;
        var val_17;
        System.Action val_18;
        System.Delegate val_19;
        var val_20;
        string val_21;
        System.Delegate val_22;
        var val_23;
        System.Action<twelvegigs.storage.JsonDictionary> val_24;
        System.Delegate val_25;
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        if(0 == 786450)
        {
                if(WGStarterPackController.starterPackTimerStarted != true)
        {
                GameBehavior val_4 = App.getBehavior;
            if(0 == 2)
        {
                WGStarterPackController.SetTimeShown();
        }
        
        }
        
        }
        
        this.InitMonoSingleton();
        val_15 = null;
        val_15 = null;
        System.Action val_5 = new System.Action(object:  63458240, method:  new IntPtr(63429120));
        val_16 = GameStoreUI.OnCreatePackItems;
        System.Delegate val_6 = System.Delegate.Combine(a:  val_16, b:  7454720);
        val_17 = null;
        val_18 = null;
        if(val_16 == 0)
        {
            goto label_13;
        }
        
        if(null == val_18)
        {
            goto label_14;
        }
        
        val_18 = null;
        val_17 = 1152921504929316956;
        label_13:
        val_16 = 0;
        label_14:
        GameStoreUI.OnCreatePackItems = val_16;
        val_18 = new System.Action(object:  63458240, method:  new IntPtr(63430144));
        val_19 = GameStoreUI.OnRefreshDisplay;
        System.Delegate val_8 = System.Delegate.Combine(a:  val_19, b:  7454720);
        if(val_19 != 0)
        {
                if(null == null)
        {
            goto label_16;
        }
        
        }
        
        val_19 = 0;
        label_16:
        GameStoreUI.OnRefreshDisplay = val_19;
        val_20 = null;
        val_20 = null;
        PostProcessPurchaseDelegate val_9 = new PostProcessPurchaseDelegate(object:  63458240, method:  new IntPtr(63431168));
        System.Delegate val_10 = System.Delegate.Combine(a:  PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS, b:  291586048);
        val_21 = 0;
        if(PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS != null)
        {
                if(null != null)
        {
                val_21 = 0;
        }
        else
        {
                val_21 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        }
        
        }
        
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_21;
        System.Action<twelvegigs.storage.JsonDictionary> val_11 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  63458240, method:  new IntPtr(63432192));
        val_22 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_12 = System.Delegate.Combine(a:  val_22, b:  7401472);
        val_23 = null;
        val_24 = null;
        if(val_22 == 0)
        {
            goto label_22;
        }
        
        if(null == val_24)
        {
            goto label_23;
        }
        
        val_24 = null;
        val_23 = 1152921504898486364;
        label_22:
        val_22 = 0;
        label_23:
        PurchasesHandler.OnPurchaseCompleted = val_22;
        val_24 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  63458240, method:  new IntPtr(63433216));
        val_25 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_14 = System.Delegate.Combine(a:  val_25, b:  7401472);
        if(val_25 != 0)
        {
                if(null == null)
        {
            goto label_25;
        }
        
        }
        
        val_25 = 0;
        label_25:
        PurchasesHandler.OnPurchaseFailure = val_25;
    }
    private void Store_OnRefreshDisplay()
    {
        var val_23;
        WGStarterPackStoreItem val_24;
        UnityEngine.Object val_25;
        if(WGStarterPackController.featureRelavent != true)
        {
                val_23 = 1152921504765685760;
            if(this.storeItemInstance != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = Localization.Localize(key:  -1261409664, defaultValue:  -1261409552, useSingularKey:  false);
            GameStoreCategory val_5 = GetOrCreateCategory(categoryTitle:  -1261409664, showTitle:  true, siblingIndex:  0);
            val_24 = 0;
            UnityEngine.GameObject val_6 = this.storeItemInstance.gameObject;
            val_25 = this.storeItemInstance;
            UnityEngine.Object.Destroy(obj:  val_25);
            this.storeItemInstance = val_24;
            UnityEngine.Transform val_7 = XfmPackageContents;
            if(childCount > 0)
        {
                return;
        }
        
            UnityEngine.GameObject val_9 = gameObject;
            UnityEngine.Object.Destroy(obj:  -1261410688);
            return;
        }
        
        }
        
        bool val_10 = WGStarterPackController.featureRelavent;
        if(val_10 == false)
        {
                return;
        }
        
        PurchaseModel val_11 = WGStarterPackController.GetStarterPack();
        if(val_10 == false)
        {
                return;
        }
        
        val_23 = val_10;
        if(this.storeItemInstance == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_14 = Localization.Localize(key:  -1261409664, defaultValue:  -1261409552, useSingularKey:  false);
            GameStoreCategory val_15 = GetOrCreateCategory(categoryTitle:  -1261409664, showTitle:  true, siblingIndex:  0);
            val_25 = public static GameStoreUI MonoSingleton<GameStoreUI>::get_Instance();
            WGStarterPackStoreItem val_16 = this.Prefab_starter_pack_store_item;
            UnityEngine.Transform val_17 = XfmPackageContents;
            object val_18 = UnityEngine.Object.Instantiate<System.Object>(original:  63591744, parent:  -1261410688);
            this.storeItemInstance = this;
            UnityEngine.Transform val_19 = this.transform;
            this.SetSiblingIndex(index:  GetFirstAvailableSiblingIndex());
        }
        
        UnityEngine.GameObject val_21 = this.storeItemInstance.gameObject;
        this.storeItemInstance.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    private void Store_OnCreatePackItems()
    {
        bool val_1 = WGStarterPackController.featureRelavent;
        if(val_1 == false)
        {
                return;
        }
        
        PurchaseModel val_2 = WGStarterPackController.GetStarterPack();
        if(val_1 == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = Localization.Localize(key:  -1261409664, defaultValue:  -1261409552, useSingularKey:  false);
        GameStoreCategory val_5 = GetOrCreateCategory(categoryTitle:  -1261409664, showTitle:  true, siblingIndex:  0);
        WGStarterPackStoreItem val_6 = this.Prefab_starter_pack_store_item;
        UnityEngine.Transform val_7 = XfmPackageContents;
        object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  63728320, parent:  -1261410688);
        this.storeItemInstance = this;
        UnityEngine.Transform val_9 = this.transform;
        this.SetSiblingIndex(index:  GetFirstAvailableSiblingIndex());
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    private PurchaseModel Store_DetermineStarterPack()
    {
        bool val_1 = WGStarterPackController.featureRelavent;
        if(val_1 == false)
        {
                val_1 = 0;
            return;
        }
        
        return WGStarterPackController.GetStarterPack();
    }
    public static PurchaseModel GetStarterPack()
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        var val_12;
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageById(packageId:  63932416);
        PurchaseModel val_2 = new PurchaseModel(json:  63932416);
        string val_3 = getString(key:  -1403597104, defaultValue:  1098586544);
        twelvegigs.storage.JsonDictionary val_4 = PackagesManager.GetPackageById(packageId:  63932416);
        val_12 = null;
        val_12 = null;
        decimal val_5 = getDecimal(key:  63932416, defaultValue:  new System.Decimal() {flags = 2129282688, hi = System.Decimal.Zero, lo = ???});
        AddReward(rewardType:  2129282688, amount:  new System.Decimal() {flags = val_6, hi = val_7, lo = val_8, mid = val_9});
        typeof(PurchaseModel).__il2cppRuntimeField_5C = 63932416;
        float val_11 = getFloat(key:  -1816221696, defaultValue:  getFloat(key:  -1816221696, defaultValue:  null));
        typeof(PurchaseModel).__il2cppRuntimeField_60 = "id_starter_pack";
    }
    private void PurchasesHandler_OnProcessPurchase(ref PurchaseModel purchase)
    {
    
    }
    private void PurchasesHandler_OnPurchaseCompleted(PurchaseModel purchased)
    {
        if((purchased.id.Contains(value:  64172752)) == false)
        {
                return;
        }
        
        this.OnPurchaseSuccess(purchase:  purchased);
    }
    private void PurchasesHandler_OnPurchaseFailure(PurchaseModel purchase)
    {
        if((purchase.id.Contains(value:  64172752)) == false)
        {
                return;
        }
        
        this.OnPurchaseFail();
    }
    public WGStarterPackController()
    {
    
    }

}
