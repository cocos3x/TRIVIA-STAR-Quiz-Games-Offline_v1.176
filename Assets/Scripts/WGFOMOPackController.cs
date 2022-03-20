using UnityEngine;
public class WGFOMOPackController : MonoSingleton<WGFOMOPackController>
{
    // Fields
    private const string lastShownKey = "FOMOPackLastShownAt";
    private TrackerPurchasePoints _ap;
    public System.Action<bool, System.Decimal> purchaseResult;
    private PurchaseModel purchaseModel;
    private PurchaseModel valueModel;
    
    // Properties
    public static bool featureRelavent { get; }
    private static System.DateTime FOMOPackShownAt { get; }
    public static bool FOMOPackTimerStarted { get; }
    public static System.DateTime FOMOPackEndedAt { get; }
    public System.TimeSpan timeRemaining { get; }
    public TrackerPurchasePoints setAccessPoint { set; }
    public TrackerPurchasePoints getAccessPoint { get; }
    public int showedLevel { get; set; }
    
    // Methods
    public static bool get_featureRelavent()
    {
        var val_19;
        var val_25;
        var val_26;
        var val_27;
        val_25 = 1152921504892043264;
        Player val_1 = App.Player;
        if(188 >= 1)
        {
                if(WGFOMOPackController.FOMOPackTimerStarted == false)
        {
            goto label_5;
        }
        
        }
        
        Player val_3 = App.Player;
        GameEcon val_4 = App.getGameEcon;
        if(0 >= 763)
        {
            goto label_10;
        }
        
        val_26 = 0;
        CompanyDevices val_5 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_26;
        }
        
        val_27 = "Not Showing FOMO pack because the user is too low level";
        goto label_50;
        label_10:
        Player val_7 = App.Player;
        GameEcon val_8 = App.getGameEcon;
        var val_9 = 0 + 964;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = mem[(0 + 964) + (0)], hi = mem[(0 + 964) + (4)], lo = mem[(0 + 964) + (8)], mid = 779})) == false)
        {
            goto label_24;
        }
        
        val_26 = 0;
        CompanyDevices val_11 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_26;
        }
        
        val_27 = "Not Showing FOMO pack because the user is not too low credits";
        goto label_50;
        label_5:
        val_26 = 0;
        CompanyDevices val_13 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_26;
        }
        
        val_27 = "Not Showing FOMO pack because this user is flagged as a purchaser";
        label_50:
        val_26 = 0;
        label_57:
        UnityEngine.Debug.Log(message:  -47373856);
        return (bool)val_26;
        label_24:
        if(WGFOMOPackController.FOMOPackTimerStarted == false)
        {
            goto label_43;
        }
        
        System.DateTime val_16 = WGFOMOPackController.FOMOPackEndedAt;
        System.DateTime val_17 = DateTimeCheat.UtcNow;
        System.TimeSpan val_18 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513149420280}, d2:  new System.DateTime());
        double val_21 = val_19.TotalMinutes;
        CompanyDevices val_22 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_26;
        }
        
        goto label_50;
        label_43:
        CompanyDevices val_24 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return (bool)val_26;
        }
        
        goto label_57;
    }
    private static System.DateTime get_FOMOPackShownAt()
    {
        if((CPlayerPrefs.HasKey(key:  -47261216)) != false)
        {
                string val_2 = CPlayerPrefs.GetString(key:  -47261216);
            System.DateTime val_3 = DateTimeCheat.UtcNow;
            System.DateTime val_6 = SLCDateTime.Parse(dateTime:  null, defaultValue:  new System.DateTime() {dateData = 1152921513149520352});
            return new System.DateTime() {dateData = val_6.dateData};
        }
        
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        return new System.DateTime() {dateData = val_7.dateData};
    }
    public static bool get_FOMOPackTimerStarted()
    {
        return CPlayerPrefs.HasKey(key:  -47261216);
    }
    public static System.DateTime get_FOMOPackEndedAt()
    {
        if((CPlayerPrefs.HasKey(key:  -47261216)) != false)
        {
                System.DateTime val_2 = WGFOMOPackController.FOMOPackShownAt;
            GameEcon val_5 = App.getGameEcon;
            System.DateTime val_6 = 0.Add(value:  new System.TimeSpan() {_ticks = 1152921513149756432});
            return new System.DateTime() {dateData = val_7.dateData};
        }
        
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        return new System.DateTime() {dateData = val_7.dateData};
    }
    public System.TimeSpan get_timeRemaining()
    {
        ulong val_5;
        var val_10;
        if((CPlayerPrefs.HasKey(key:  -47261216)) != false)
        {
                System.DateTime val_2 = WGFOMOPackController.FOMOPackShownAt;
            System.DateTime val_3 = DateTimeCheat.UtcNow;
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513149880464}, d2:  new System.DateTime() {dateData = val_5});
            return new System.TimeSpan() {_ticks = 8};
        }
        
        GameEcon val_9 = App.getGameEcon;
        val_10 = 8;
        this = 5066622595235848;
        return new System.TimeSpan() {_ticks = 8};
    }
    public void set_setAccessPoint(TrackerPurchasePoints value)
    {
        this._ap = value;
    }
    public TrackerPurchasePoints get_getAccessPoint()
    {
    
    }
    public int get_showedLevel()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -46572720, defaultValue:  0);
    }
    public void set_showedLevel(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -46572720, value:  value);
    }
    public static void SetTimeShown()
    {
        var val_7;
        if((CPlayerPrefs.HasKey(key:  -47261216)) == true)
        {
                return;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        GameEcon val_5 = App.getGameEcon;
        System.DateTime val_6 = Add(value:  new System.TimeSpan() {_ticks = 1152921513150444928});
        string val_9 = val_7.ToString();
        CPlayerPrefs.SetString(key:  -47261216, val:  -46336640);
        CPlayerPrefs.Save();
    }
    public void TryMakePurchase()
    {
        var val_2;
        var val_2 = 28355133;
        val_2 = 7270928 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        PurchaseProxy.currentPurchasePoint = this._ap;
        bool val_1 = PurchaseProxy.Purchase(purchase:  this.purchaseModel);
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
        35628082 = public System.Void System.Action<System.Boolean, System.Decimal>::Invoke(System.Boolean arg1, System.Decimal arg2);
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
        var val_9;
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_9 = 0;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.Debug.Log(message:  -45859648);
        }
        
        if(WGFOMOPackController.featureRelavent == false)
        {
                return (bool)val_9;
        }
        
        CompanyDevices val_4 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.Debug.Log(message:  -45859520);
        }
        
        this.GeneratePackages();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
        this._ap = 128;
        Player val_8 = App.Player;
        this.showedLevel = 0;
        val_9 = 1;
        return (bool)val_9;
    }
    public override void InitMonoSingleton()
    {
        var val_11;
        string val_12;
        System.Delegate val_13;
        var val_14;
        System.Action<twelvegigs.storage.JsonDictionary> val_15;
        System.Delegate val_16;
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        if(0 == 763)
        {
                if(WGFOMOPackController.FOMOPackTimerStarted != true)
        {
                GameBehavior val_4 = App.getBehavior;
            if(0 == 2)
        {
                WGFOMOPackController.SetTimeShown();
        }
        
        }
        
        }
        
        this.InitMonoSingleton();
        val_11 = null;
        val_11 = null;
        PostProcessPurchaseDelegate val_5 = new PostProcessPurchaseDelegate(object:  -45718272, method:  new IntPtr(4249221952));
        System.Delegate val_6 = System.Delegate.Combine(a:  PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS, b:  291586048);
        val_12 = 0;
        if(PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS != null)
        {
                if(null != null)
        {
                val_12 = 0;
        }
        else
        {
                val_12 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        }
        
        }
        
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_12;
        System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -45718272, method:  new IntPtr(4249222976));
        val_13 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_8 = System.Delegate.Combine(a:  val_13, b:  7401472);
        val_14 = null;
        val_15 = null;
        if(val_13 == 0)
        {
            goto label_16;
        }
        
        if(null == val_15)
        {
            goto label_17;
        }
        
        val_15 = null;
        val_14 = 1152921504898486364;
        label_16:
        val_13 = 0;
        label_17:
        PurchasesHandler.OnPurchaseCompleted = val_13;
        val_15 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -45718272, method:  new IntPtr(4249224000));
        val_16 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_10 = System.Delegate.Combine(a:  val_16, b:  7401472);
        if(val_16 != 0)
        {
                if(null == null)
        {
            goto label_19;
        }
        
        }
        
        val_16 = 0;
        label_19:
        PurchasesHandler.OnPurchaseFailure = val_16;
    }
    private void GeneratePackages()
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        var val_15;
        var val_16;
        var val_17;
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageById(packageId:  -1403597200);
        this.purchaseModel = new PurchaseModel(json:  -1403597200);
        string val_3 = getString(key:  -1403597104, defaultValue:  1098586544);
        twelvegigs.storage.JsonDictionary val_4 = PackagesManager.GetPackageById(packageId:  -1403597200);
        val_15 = "id_fomo_pack";
        val_16 = null;
        val_16 = null;
        val_15 = val_15;
        if(val_15 == 0)
        {
                val_15 = val_15;
        }
        
        decimal val_5 = getDecimal(key:  -1403597200, defaultValue:  new System.Decimal() {flags = 2129282688, hi = System.Decimal.Zero, lo = ???, mid = ???});
        this.purchaseModel.AddReward(rewardType:  2129282688, amount:  new System.Decimal() {flags = val_6, hi = val_7, lo = val_8, mid = val_9});
        typeof(PurchaseModel).__il2cppRuntimeField_5C = 2891370096;
        val_17 = val_15;
        if(val_15 == 0)
        {
                val_17 = val_15;
        }
        
        float val_11 = getFloat(key:  -1816221696, defaultValue:  getFloat(key:  -1816221696, defaultValue:  null));
        typeof(PurchaseModel).__il2cppRuntimeField_60 = 2891370096;
        string val_12 = getString(key:  -1403597104, defaultValue:  1098586544);
        twelvegigs.storage.JsonDictionary val_13 = PackagesManager.GetPackageById(packageId:  -1403597200);
        mem[1152921513151179416] = new PurchaseModel(json:  -1403597200);
    }
    private void PurchasesHandler_OnProcessPurchase(ref PurchaseModel purchase)
    {
    
    }
    private void PurchasesHandler_OnPurchaseCompleted(PurchaseModel purchased)
    {
        if((purchased.id.Contains(value:  -1403348592)) == false)
        {
                return;
        }
        
        this.OnPurchaseSuccess(purchase:  purchased);
    }
    private void PurchasesHandler_OnPurchaseFailure(PurchaseModel purchase)
    {
        if((purchase.id.Contains(value:  -1403348592)) == false)
        {
                return;
        }
        
        this.OnPurchaseFail();
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
    public WGFOMOPackController()
    {
    
    }

}
