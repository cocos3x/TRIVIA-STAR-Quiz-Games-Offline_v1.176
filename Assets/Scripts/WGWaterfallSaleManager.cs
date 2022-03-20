using UnityEngine;
public class WGWaterfallSaleManager : MonoSingleton<WGWaterfallSaleManager>
{
    // Fields
    public const string WATERFALL_HINT_NOTIF = "OnHintUsed";
    public const string pref_waterfall_started = "waterfall_started";
    public const string pref_waterfall_last_seen = "waterfall_last_seen";
    private bool waterfallEnabled;
    private int PriceReductionInterval;
    private int LevelLock;
    private int MinutesToDisplay;
    private bool waterfallOOC;
    private bool hintUsed;
    private bool waterFallSeen;
    private int PriceReductionLevels;
    private PurchaseModel purchaseModel;
    private PurchaseModel valueModel;
    private bool canPurchase;
    private WGWaterfallSalePopup currentPopup;
    private System.Action<bool> WGStoreProxyAction;
    private bool qahack_useMinutes;
    private readonly int[] packageMapping;
    
    // Properties
    public bool CanPurchaseSale { get; set; }
    public bool QAHACK_UseMinutes { get; set; }
    public int QAHACK_Interval { get; }
    public int QAHACK_LevelReq { get; }
    public bool QAHACK_Enabled { get; }
    public int QAHACK_CurrentInterval { get; }
    public bool QAHACK_SeenThisSession { get; }
    public bool QAHACK_OOC_Enabled { get; }
    public string QAHACK_CurrentShowLogic { get; }
    private bool IsFeatureEnabled { get; }
    public bool IsSaleWaterfallEnabled { get; }
    
    // Methods
    public bool get_CanPurchaseSale()
    {
        return (bool)this.canPurchase;
    }
    public void set_CanPurchaseSale(bool value)
    {
        this.canPurchase = value;
    }
    public bool get_QAHACK_UseMinutes()
    {
        return (bool)this.qahack_useMinutes;
    }
    public void set_QAHACK_UseMinutes(bool value)
    {
        this.qahack_useMinutes = value;
    }
    public int get_QAHACK_Interval()
    {
        return (int)this.PriceReductionInterval;
    }
    public int get_QAHACK_LevelReq()
    {
        return (int)this.LevelLock;
    }
    public bool get_QAHACK_Enabled()
    {
        return (bool)this.waterfallEnabled;
    }
    public int get_QAHACK_CurrentInterval()
    {
        return this.GetSaleInterval();
    }
    public bool get_QAHACK_SeenThisSession()
    {
        return (bool)this.waterFallSeen;
    }
    public bool get_QAHACK_OOC_Enabled()
    {
        return (bool)this.waterfallOOC;
    }
    public string get_QAHACK_CurrentShowLogic()
    {
        long val_6;
        long val_7;
        var val_17;
        var val_28;
        int val_29;
        int val_30;
        int val_31;
        var val_32;
        var val_33;
        var val_35;
        var val_36;
        if(this.IsFeatureEnabled == false)
        {
            goto label_1;
        }
        
        var val_28 = 25475677;
        val_28 = 10151748 + val_28;
        if(val_28 == 0)
        {
                mem2[0] = 1;
        }
        
        val_28 = null;
        val_28 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
        {
            goto label_7;
        }
        
        if(this.hintUsed == false)
        {
            goto label_8;
        }
        
        val_29 = this.PriceReductionInterval;
        if(this.qahack_useMinutes == false)
        {
            goto label_9;
        }
        
        val_30 = 0;
        val_31 = 0;
        val_32 = 0;
        goto label_10;
        label_1:
        val_33 = "Feature Disabled";
        return;
        label_7:
        val_33 = "No Network Connection";
        return;
        label_8:
        val_33 = "Hint not used";
        return;
        label_9:
        val_30 = 0;
        val_31 = val_29;
        val_32 = 0;
        val_29 = 0;
        label_10:
        System.TimeSpan val_2 = new System.TimeSpan(days:  val_31, hours:  0, minutes:  0, seconds:  val_30);
        System.DateTime val_3 = ServerHandler.ServerTime;
        Player val_4 = App.Player;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512894005672}, d2:  new System.DateTime() {dateData = val_2._ticks});
        if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_6}, t2:  new System.TimeSpan() {_ticks = val_2._ticks})) == false)
        {
            goto label_23;
        }
        
        Player val_9 = App.Player;
        if(0 != 0)
        {
            goto label_27;
        }
        
        label_23:
        System.DateTime val_10 = ServerHandler.ServerTime;
        string val_12 = 0.ToBinary().ToString();
        string val_13 = UnityEngine.PlayerPrefs.GetString(key:  -796068800, defaultValue:  -302775880);
        long val_14 = System.Int64.Parse(s:  -796068800);
        System.DateTime val_15 = System.DateTime.FromBinary(dateData:  1152921512894005672);
        System.TimeSpan val_16 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512894005664}, d2:  new System.DateTime() {dateData = val_2._ticks});
        bool val_18 = System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_2._ticks}, t2:  new System.TimeSpan() {_ticks = val_2._ticks});
        if(val_18 == true)
        {
                val_18 = this.waterFallSeen;
            goto label_34;
        }
        
        val_33 = "Ready To Show";
        return;
        label_34:
        string val_20 = 0.ToBinary().ToString();
        string val_21 = UnityEngine.PlayerPrefs.GetString(key:  -796068800, defaultValue:  -302775880);
        long val_22 = System.Int64.Parse(s:  -796068800);
        System.DateTime val_23 = System.DateTime.FromBinary(dateData:  1152921512894005680);
        System.DateTime val_24 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512894005672}, t:  new System.TimeSpan() {_ticks = val_2._ticks});
        val_17 = val_7;
        val_35 = null;
        val_36 = "Already seen, next showing {0}";
        goto label_37;
        label_27:
        Player val_25 = App.Player;
        System.DateTime val_26 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 1152921512894005680}, t:  new System.TimeSpan() {_ticks = 264});
        val_6 = val_2._ticks;
        val_7 = val_2._ticks;
        val_35 = null;
        val_36 = "Blocked by purchase until {0}";
        label_37:
        string val_27 = System.String.Format(format:  -302787952, arg0:  9904128);
    }
    private bool get_IsFeatureEnabled()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        val_2 = 0;
        if(0 < this.LevelLock)
        {
                return true;
        }
        
        if(this.waterfallEnabled == true)
        {
                val_2 = 1;
        }
        
        return true;
    }
    public bool get_IsSaleWaterfallEnabled()
    {
        return this.IsFeatureEnabled;
    }
    public override void InitMonoSingleton()
    {
        var val_12;
        string val_13;
        System.Delegate val_14;
        var val_15;
        System.Action<twelvegigs.storage.JsonDictionary> val_16;
        System.Delegate val_17;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -302424656, name:  -1898880160);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -302424656, name:  -302451824);
        AppConfigs val_3 = App.Configuration;
        this.waterfallEnabled = false;
        AppConfigs val_4 = App.Configuration;
        this.PriceReductionInterval = 33453552;
        AppConfigs val_5 = App.Configuration;
        this.MinutesToDisplay = 1030672;
        val_12 = null;
        val_12 = null;
        PostProcessPurchaseDelegate val_6 = new PostProcessPurchaseDelegate(object:  -302424656, method:  new IntPtr(3992515568));
        System.Delegate val_7 = System.Delegate.Combine(a:  PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS, b:  291586048);
        val_13 = 0;
        if(PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS != null)
        {
                if(null != null)
        {
                val_13 = 0;
        }
        else
        {
                val_13 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        }
        
        }
        
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_13;
        System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -302424656, method:  new IntPtr(3992516592));
        val_14 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_9 = System.Delegate.Combine(a:  val_14, b:  7401472);
        val_15 = null;
        val_16 = null;
        if(val_14 == 0)
        {
            goto label_18;
        }
        
        if(null == val_16)
        {
            goto label_19;
        }
        
        val_16 = null;
        val_15 = 1152921504898486364;
        label_18:
        val_14 = 0;
        label_19:
        PurchasesHandler.OnPurchaseCompleted = val_14;
        val_16 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -302424656, method:  new IntPtr(3992517616));
        val_17 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_11 = System.Delegate.Combine(a:  val_17, b:  7401472);
        if(val_17 != 0)
        {
                if(null == null)
        {
            goto label_21;
        }
        
        }
        
        val_17 = 0;
        label_21:
        PurchasesHandler.OnPurchaseFailure = val_17;
    }
    private void PurchasesHandler_OnPurchaseFailure(PurchaseModel purchased)
    {
        if((purchased.id.Contains(value:  -302328464)) == false)
        {
                return;
        }
        
        this.HandlePurchaseFailure();
    }
    private void PurchasesHandler_OnPurchaseCompleted(PurchaseModel purchased)
    {
        string val_4 = purchased.id;
        if((val_4.Contains(value:  -302328464)) == false)
        {
                return;
        }
        
        val_4 = 0;
        decimal val_2 = Credits;
        this.HandlePurchaseSuccess(coinsToReceive:  System.Decimal.ToInt32(d:  new System.Decimal()));
    }
    private void PurchasesHandler_OnProcessPurchase(ref PurchaseModel purchased)
    {
        int val_8;
        int val_9;
        int val_10;
        int val_11;
        if((purchased.id.Contains(value:  -302328464)) == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  purchased.id)) != false)
        {
                UnityEngine.Debug.LogError(message:  -302075776);
            return;
        }
        
        twelvegigs.storage.JsonDictionary val_3 = PackagesManager.GetPackageById(packageId:  purchased.id);
        string val_4 = purchased.id.getString(key:  -1403597104, defaultValue:  1098586544);
        twelvegigs.storage.JsonDictionary val_5 = PackagesManager.GetPackageById(packageId:  purchased.id);
        int val_6 = purchased.id.getInt(key:  2129282688, defaultValue:  0);
        decimal val_7 = System.Decimal.op_Implicit(value:  -302063708);
        purchased.AddReward(rewardType:  2129282688, amount:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_11, mid = val_8});
        sale_price = purchased.id;
        float val_13 = purchased.id.getFloat(key:  -1816221696, defaultValue:  purchased.id.getFloat(key:  -1816221696, defaultValue:  null));
        targetSalePrice = purchased.id;
        string val_14 = purchased.sale_price.ToString();
        string val_15 = purchased.id.getString(key:  -1816221600, defaultValue:  -302063692);
        price = purchased.id;
    }
    private void OnServerSync()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_12 = 10157400 + 25470015;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        System.Collections.IDictionary val_1 = getSalesLogic();
        if(App.storageManager.knobsModel == 0)
        {
                return;
        }
        
        if(((mem[null + 100] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_14 = 0;
        }
        
        if((val_14.ContainsKey(key:  -301959632)) != false)
        {
                val_15 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_3 = val_14.Item[-301959632];
            val_16 = val_14;
            val_17 = null;
            val_16.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.waterfallEnabled = true;
        }
        
        if((val_14.ContainsKey(key:  -301959536)) != false)
        {
                val_15 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_5 = val_14.Item[-301959536];
            val_16 = val_14;
            val_17 = null;
            val_16.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.PriceReductionInterval = 1179403647;
        }
        
        if((val_14.ContainsKey(key:  -301959424)) != false)
        {
                val_15 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_7 = val_14.Item[-301959424];
            val_16 = val_14;
            val_17 = null;
            val_16.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.MinutesToDisplay = 1179403647;
        }
        
        if((val_14.ContainsKey(key:  -301959312)) != false)
        {
                val_15 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
            string val_9 = val_14.Item[-301959312];
            val_16 = val_14;
            val_17 = null;
            val_16.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.LevelLock = 1179403647;
        }
        
        val_12 = "wgwaterfall_ooc";
        if((val_14.ContainsKey(key:  -301959200)) == false)
        {
                return;
        }
        
        val_15 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        string val_11 = val_14.Item[-301959200];
        val_14 = val_14;
        val_18 = null;
        val_14.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.waterfallOOC = true;
    }
    private void OnHintUsed()
    {
        this.hintUsed = true;
    }
    private void GeneratePackages()
    {
        int val_1 = this.GetSaleInterval();
        string val_2 = val_1.ToString();
        string val_3 = -301735088(-301735088) + -301722916(-301722916);
        twelvegigs.storage.JsonDictionary val_4 = PackagesManager.GetPackageById(packageId:  -301735088);
        string val_5 = getString(key:  -1403597104, defaultValue:  1098586544);
        twelvegigs.storage.JsonDictionary val_6 = PackagesManager.GetPackageById(packageId:  -301735088);
        this.valueModel = new PurchaseModel(json:  -301735088);
        this.purchaseModel = new PurchaseModel(json:  -301735088);
        string val_9 = val_1.ToString();
        string val_10 = System.String.Format(format:  -301734992, arg0:  -301722916);
        typeof(PurchaseModel).__il2cppRuntimeField_68 = "sale_waterfall_{0}";
    }
    private int GetSaleInterval()
    {
        ulong val_8;
        var val_11;
        var val_25;
        var val_27;
        val_25 = 0;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -796069696)) != false)
        {
                string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -796069696);
            long val_3 = System.Int64.Parse(s:  -796069696);
            System.DateTime val_4 = System.DateTime.FromBinary(dateData:  1152921512895207504);
            System.DateTime val_7 = ServerHandler.ServerTime;
            System.TimeSpan val_10 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512895207488}, d2:  new System.DateTime() {dateData = val_8});
            if(this.PriceReductionInterval <= 1)
        {
                this.PriceReductionInterval = 1;
        }
        
            if(this.qahack_useMinutes != false)
        {
                int val_13 = val_11.Minutes;
        }
        
            val_25 = System.Math.Min(val1:  val_11.Days, val2:  this.PriceReductionLevels - 1);
        }
        
        val_27 = 0;
        Player val_17 = App.Player;
        if(0 < 0)
        {
                Player val_18 = App.Player;
            val_27 = 1;
            if(0 < 0)
        {
                Player val_19 = App.Player;
            val_27 = 2;
            if(0 < 0)
        {
                Player val_20 = App.Player;
            val_27 = 3;
            if(188 == 0)
        {
                if(WGStarterPackController.HasSeenExpiredStarterPack == true)
        {
                val_27 = 4;
        }
        
        }
        
        }
        
        }
        
        }
        
        return (int)this.packageMapping[System.Math.Min(val1:  4 + val_25, val2:  this.PriceReductionLevels - 1)];
    }
    public void HandlePurchaseSuccess(int coinsToReceive)
    {
        WGWaterfallSalePopup val_5;
        UnityEngine.PlayerPrefs.DeleteKey(key:  -796069696);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGWaterfallSaleManager MonoSingleton<WGWaterfallSaleManager>::get_Instance().__il2cppRuntimeField_2C = 1;
        val_5 = this.currentPopup;
        if(val_5 == 0)
        {
                return;
        }
        
        if(this.WGStoreProxyAction != 0)
        {
                object val_3 = this.currentPopup.GetComponent<System.Object>();
            val_5 = this.currentPopup;
            System.Action val_4 = new System.Action(object:  -301395744, method:  new IntPtr(3993542432));
            this.currentPopup.valueTxt = null;
        }
        
        this.currentPopup.AnimateCoins(coinsPurchased:  coinsToReceive);
    }
    public void HandlePurchaseFailure()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        WGWaterfallSaleManager.<>c__DisplayClass51_0 val_1 = new WGWaterfallSaleManager.<>c__DisplayClass51_0();
        typeof(WGWaterfallSaleManager.<>c__DisplayClass51_0).__il2cppRuntimeField_C = this;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGWaterfallSaleManager MonoSingleton<WGWaterfallSaleManager>::get_Instance().__il2cppRuntimeField_2C = 1;
        UnityEngine.GameObject val_3 = this.currentPopup.gameObject;
        object val_4 = this.currentPopup.GetComponent<System.Object>();
        bool val_5 = UnityEngine.Object.op_Inequality(x:  this.currentPopup, y:  0);
        typeof(WGWaterfallSaleManager.<>c__DisplayClass51_0).__il2cppRuntimeField_8 = val_5;
        if(val_5 != false)
        {
                UnityEngine.GameObject val_6 = this.currentPopup.gameObject;
            object val_7 = this.currentPopup.GetComponent<System.Object>();
            this.currentPopup.valueTxt = 0;
            val_16 = public static WGFlyoutManager MonoSingleton<WGFlyoutManager>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = val_16;
            val_18 = 1152921512895498400;
        }
        else
        {
                val_16 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = val_16;
            val_18 = 1152921511472608448;
        }
        
        object val_10 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_11 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_12 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_13 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
        System.Func<System.Boolean> val_14 = new System.Func<System.Boolean>(object:  373481472, method:  new IntPtr(3993685152));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_19 = null;
        val_20 = this;
        val_21 = val_17;
        if( == 0)
        {
                val_21 = val_17;
        }
        
        SetupMessage(titleTxt:  -1349324784, messageTxt:  -1349324672, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        if(this.currentPopup == 0)
        {
                return;
        }
        
        this.currentPopup.Close();
    }
    public bool CanDisplayWaterfallSale(bool oocFlow = False)
    {
        long val_8;
        long val_19;
        var val_22;
        int val_23;
        int val_24;
        int val_25;
        var val_26;
        if(this.IsFeatureEnabled == false)
        {
                return false;
        }
        
        var val_22 = 25555905;
        val_22 = 10071520 + val_22;
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE != null)
        {
                NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE = this.hintUsed;
        }
        
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE != true)
        {
                return false;
        }
        
        if(WGStarterPackController.IsInStarterPackDelay == true)
        {
                return false;
        }
        
        if((FOMOPackEventHandler.<Instance>k__BackingField) != 0)
        {
                if((FOMOPackEventHandler.<Instance>k__BackingField.AvailableShow) == true)
        {
                return false;
        }
        
        }
        
        val_23 = this.PriceReductionInterval;
        if(this.qahack_useMinutes != false)
        {
                val_24 = 0;
            val_25 = 0;
            val_26 = 0;
        }
        else
        {
                val_24 = 0;
            val_25 = val_23;
            val_26 = 0;
            val_23 = 0;
        }
        
        System.TimeSpan val_4 = new System.TimeSpan(days:  val_25, hours:  0, minutes:  0, seconds:  val_24);
        System.DateTime val_5 = ServerHandler.ServerTime;
        Player val_6 = App.Player;
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512895648952}, d2:  new System.DateTime() {dateData = val_4._ticks});
        if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_8}, t2:  new System.TimeSpan() {_ticks = val_4._ticks})) != false)
        {
                Player val_11 = App.Player;
            if(0 != 0)
        {
                return false;
        }
        
        }
        
        System.DateTime val_12 = ServerHandler.ServerTime;
        string val_14 = 0.ToBinary().ToString();
        string val_15 = UnityEngine.PlayerPrefs.GetString(key:  -796068800, defaultValue:  -301132600);
        long val_16 = System.Int64.Parse(s:  -796068800);
        System.DateTime val_17 = System.DateTime.FromBinary(dateData:  1152921512895648952);
        System.TimeSpan val_18 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512895648944}, d2:  new System.DateTime() {dateData = val_4._ticks});
        bool val_21 = System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_19}, t2:  new System.TimeSpan() {_ticks = val_4._ticks});
        if(val_21 == true)
        {
                val_21 = this.waterFallSeen;
            goto label_34;
        }
        
        label_39:
        if(oocFlow == false)
        {
                return false;
        }
        
        if(this.waterfallOOC == false)
        {
                return false;
        }
        
        return false;
        label_34:
        if(oocFlow == false)
        {
                return false;
        }
        
        goto label_39;
    }
    public void ShowPopup(bool oocFlow = False, System.Action<bool> storeCloseCallback)
    {
        var val_2;
        var val_25;
        WGWaterfallSalePopup val_27;
        var val_28;
        var val_29;
        var val_30;
        System.DateTime val_1 = ServerHandler.ServerTime;
        string val_5 = val_2.ToBinary().ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -796068800, value:  -301013432);
        this.waterFallSeen = true;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -796069696)) == false)
        {
            goto label_3;
        }
        
        string val_7 = UnityEngine.PlayerPrefs.GetString(key:  -796069696);
        val_25 = System.Int64.Parse(s:  -796069696);
        System.DateTime val_9 = System.DateTime.FromBinary(dateData:  1152921512895768120);
        Player val_10 = App.Player;
        if((val_2.CompareTo(value:  new System.DateTime() {dateData = App.__il2cppRuntimeField_cctor_finished})) > 1)
        {
            goto label_9;
        }
        
        label_3:
        System.DateTime val_12 = ServerHandler.ServerTime;
        string val_14 = val_2.ToBinary().ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -796069696, value:  -301013432);
        label_9:
        bool val_15 = PrefsSerializationManager.SavePlayerPrefs();
        this.GeneratePackages();
        if(oocFlow != false)
        {
                GameBehavior val_17 = App.getBehavior;
            val_27 = 0;
        }
        else
        {
                GameBehavior val_19 = App.getBehavior;
            val_27 = 0;
        }
        
        this.currentPopup = val_27;
        this.WGStoreProxyAction = storeCloseCallback;
        if(storeCloseCallback == 0)
        {
            goto label_24;
        }
        
        object val_21 = val_27.GetComponent<System.Object>();
        System.Action val_22 = new System.Action(object:  -301001376, method:  new IntPtr(3993940896));
        System.Delegate val_23 = System.Delegate.Combine(a:  1, b:  7454720);
        val_25 = 1;
        if(val_25 != 0)
        {
                if(21384261 == null)
        {
            goto label_29;
        }
        
        }
        
        val_25 = 0;
        label_29:
        mem[20] = val_25;
        label_24:
        if(oocFlow != false)
        {
                val_28 = 1152921504899551232;
            var val_25 = 25552337;
            val_25 = 10073724 + val_25;
            if(val_25 == 0)
        {
                mem2[0] = 1;
        }
        
            val_29 = null;
            val_30 = 97;
        }
        else
        {
                if(SceneDictator.IsInGameScene() == true)
        {
                val_30 = 5;
        }
        
            val_28 = 1152921504899551232;
            var val_26 = 25552177;
            val_26 = 10073884 + val_26;
            if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
            val_29 = null;
        }
        
        PurchaseProxy.currentPurchasePoint = 5;
        this.canPurchase = true;
    }
    public int GetSecondsRemainingForOffer()
    {
        int val_1 = this.MinutesToDisplay;
        val_1 = (val_1 << 4) - val_1;
        val_1 = val_1 << 2;
        return (int)val_1;
    }
    public void BuyWaterfallSpecial()
    {
        if(this.canPurchase == false)
        {
                return;
        }
        
        this.canPurchase = false;
        bool val_1 = PurchaseProxy.Purchase(purchase:  this.purchaseModel);
    }
    public string GetValue()
    {
        if(this.valueModel != 0)
        {
                return this.valueModel.LocalPrice;
        }
        
        return this.valueModel.LocalPrice;
    }
    public string GetCoins()
    {
        decimal val_1 = Credits;
        GameEcon val_2 = App.getGameEcon;
        string val_3 = ToString(format:  null);
    }
    public string GetPrice()
    {
        if(this.purchaseModel != 0)
        {
                return this.purchaseModel.LocalPrice;
        }
        
        return this.purchaseModel.LocalPrice;
    }
    public WGWaterfallSaleManager()
    {
        this.PriceReductionInterval = 5;
        this.LevelLock = 10;
        this.MinutesToDisplay = 10;
        this.PriceReductionLevels = 8;
        this.canPurchase = true;
        this.packageMapping = null;
    }
    private void <HandlePurchaseSuccess>b__50_0()
    {
        this.WGStoreProxyAction.Invoke(obj:  true);
        this.WGStoreProxyAction = 0;
    }
    private void <ShowPopup>b__53_0()
    {
        this.WGStoreProxyAction.Invoke(obj:  false);
        this.WGStoreProxyAction = 0;
    }

}
