using UnityEngine;
public class FOMOPackEventHandler : WGEventHandler
{
    // Fields
    public const string FOMO_PACK_EVENT_ID = "FOMO pack";
    public const string EVENT_TRACKING_ID = "FOMO pack";
    private static FOMOPackEventHandler <Instance>k__BackingField;
    private FOMOPackProgress progressData;
    private TrackerPurchasePoints <AccessPoint>k__BackingField;
    public System.Action<bool, System.Decimal> purchaseResult;
    private PurchaseModel purchaseModel;
    protected bool isEventInitialized;
    
    // Properties
    public static bool IsEventActive { get; }
    public static FOMOPackEventHandler Instance { get; set; }
    public FOMOPackProgress ProgressData { get; }
    private int PlayerLevel { get; }
    public TrackerPurchasePoints AccessPoint { get; set; }
    public override bool IsEventHidden { get; }
    public override int UnlockLevel { get; }
    public System.DateTime PackShownAt { get; }
    public bool PackTimerStarted { get; }
    public System.DateTime PackEndedAt { get; }
    public System.TimeSpan timeRemaining { get; }
    public int ShowedLevel { get; set; }
    public string GetAmount { get; }
    public string GetPrice { get; }
    public bool AvailableShow { get; }
    public bool CanLevelShow { get; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static bool get_IsEventActive()
    {
        if((FOMOPackEventHandler.<Instance>k__BackingField) == 0)
        {
                return false;
        }
        
        goto typeof(FOMOPackEventHandler).__il2cppRuntimeField_274;
    }
    public static FOMOPackEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(FOMOPackEventHandler value)
    {
        FOMOPackEventHandler.<Instance>k__BackingField = value;
    }
    public FOMOPackProgress get_ProgressData()
    {
    
    }
    private int get_PlayerLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public TrackerPurchasePoints get_AccessPoint()
    {
    
    }
    public void set_AccessPoint(TrackerPurchasePoints value)
    {
        this.<AccessPoint>k__BackingField = value;
    }
    public override bool get_IsEventHidden()
    {
        return true;
    }
    public override int get_UnlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 763;
        }
        
        return 763;
    }
    public System.DateTime get_PackShownAt()
    {
        if((System.String.IsNullOrEmpty(value:  R1 + 16 + 16)) != false)
        {
                System.DateTime val_2 = DateTimeCheat.UtcNow;
            return new System.DateTime() {dateData = val_2.dateData};
        }
        
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        System.DateTime val_6 = SLCDateTime.Parse(dateTime:  -1406231760, defaultValue:  new System.DateTime() {dateData = R1 + 16 + 16});
        return new System.DateTime() {dateData = val_6.dateData};
    }
    public bool get_PackTimerStarted()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.progressData.LastShownAt);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public System.DateTime get_PackEndedAt()
    {
        if(R1.PackTimerStarted != false)
        {
                System.DateTime val_2 = PackShownAt;
            35639160 = 0;
            GameEcon val_5 = App.getGameEcon;
            System.DateTime val_6 = this.Add(value:  new System.TimeSpan() {_ticks = 1152921511790778160});
            return new System.DateTime() {dateData = val_7.dateData};
        }
        
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        return new System.DateTime() {dateData = val_7.dateData};
    }
    public System.TimeSpan get_timeRemaining()
    {
        var val_7;
        if(R1.PackTimerStarted != false)
        {
                System.DateTime val_2 = PackEndedAt;
            System.DateTime val_3 = DateTimeCheat.UtcNow;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511790902192}, d2:  new System.DateTime());
            return new System.TimeSpan() {_ticks = 8};
        }
        
        GameEcon val_5 = App.getGameEcon;
        val_7 = 8;
        this = 5066622595235848;
        return new System.TimeSpan() {_ticks = 8};
    }
    public int get_ShowedLevel()
    {
        if(this.progressData != 0)
        {
                return (int)this.progressData.ShowedLevel;
        }
        
        return (int)this.progressData.ShowedLevel;
    }
    public void set_ShowedLevel(int value)
    {
        this.progressData.ShowedLevel = value;
        if(this.progressData == 0)
        {
            
        }
    
    }
    public string get_GetAmount()
    {
        GameBehavior val_1 = App.getBehavior;
        decimal val_2 = GetReward(rewardType:  this.purchaseModel);
        GameEcon val_3 = App.getGameEcon;
        string val_4 = ToString(format:  null);
    }
    public string get_GetPrice()
    {
        if(this.purchaseModel != 0)
        {
                return this.purchaseModel.LocalPrice;
        }
        
        return this.purchaseModel.LocalPrice;
    }
    public bool get_AvailableShow()
    {
        if(this == 0)
        {
                return (bool)0;
        }
        
        0 = 1152921511791503153;
        return (bool)0;
    }
    public bool get_CanLevelShow()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        if((0 - this.progressData.ShowedLevel) >= 34479772)
        {
                0 = 1;
        }
        
        return true;
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921511791739448] = eventV2;
        FOMOPackEventHandler.<Instance>k__BackingField = this;
        this.SetupEvent();
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        if((System.String.op_Inequality(a:  eventV2.type, b:  -1408082768)) != false)
        {
                return;
        }
        
        this.SetupEvent();
    }
    public override bool get_IsEventValid()
    {
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  this.PlayerLevel, knobValue:  -1404797648)) == false)
        {
                return (bool)0;
        }
        
        GameBehavior val_3 = App.getBehavior;
        GameEcon val_4 = App.getGameEcon;
        var val_5 = 0 + 964;
        0 = System.Decimal.op_LessThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = mem[(0 + 964) + (0)], hi = mem[(0 + 964) + (4)], lo = mem[(0 + 964) + (8)], mid = 779});
        return (bool)0;
    }
    public override bool EventCompleted()
    {
        var val_7;
        var val_8;
        val_7 = 0;
        if(this.PackTimerStarted != false)
        {
                System.TimeSpan val_2 = timeRemaining;
            val_8 = 1;
            if(val_7 != ((???.Seconds) >> 31))
        {
                return (bool)val_8;
        }
        
        }
        
        val_8 = 0;
        Player val_4 = App.Player;
        val_7 = 0;
        if(188 < 1)
        {
                return (bool)val_8;
        }
        
        val_8 = this.PackTimerStarted ^ 1;
        return (bool)val_8;
    }
    public void SetupSomeStuffFromFeature(string whateverFeatureInfo = "")
    {
    
    }
    private void SetupEvent()
    {
        var val_9;
        string val_10;
        System.Delegate val_11;
        var val_12;
        System.Action<twelvegigs.storage.JsonDictionary> val_13;
        System.Action<twelvegigs.storage.JsonDictionary> val_14;
        System.Delegate val_15;
        if(this.isEventInitialized == true)
        {
            goto label_1;
        }
        
        val_9 = null;
        val_9 = null;
        PostProcessPurchaseDelegate val_1 = new PostProcessPurchaseDelegate(object:  -1404432976, method:  new IntPtr(2890493936));
        System.Delegate val_2 = System.Delegate.Combine(a:  PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS, b:  291586048);
        val_10 = 0;
        if(PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS != null)
        {
                if(null != null)
        {
                val_10 = 0;
        }
        else
        {
                val_10 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        }
        
        }
        
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_10;
        System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1404432976, method:  new IntPtr(2890494960));
        val_11 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_11, b:  7401472);
        val_12 = null;
        val_13 = null;
        if(val_11 == 0)
        {
            goto label_8;
        }
        
        if(null == val_13)
        {
            goto label_9;
        }
        
        val_13 = null;
        val_12 = 1152921504898486364;
        label_8:
        val_11 = 0;
        label_9:
        PurchasesHandler.OnPurchaseCompleted = val_11;
        val_14 = val_13;
        val_14 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1404432976, method:  new IntPtr(2890497008));
        val_15 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_6 = System.Delegate.Combine(a:  val_15, b:  7401472);
        if(val_15 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_15 = 0;
        label_11:
        PurchasesHandler.OnPurchaseFailure = val_15;
        label_1:
        if(this != 0)
        {
                if(this.IsCurrentEventInCycle() != true)
        {
                this.progressData = new FOMOPackProgress();
        }
        
        }
        
        if(this != 0)
        {
                return;
        }
        
        this.progressData.eventId = System.Action<T>.__il2cppRuntimeField_generic_class;
        this.isEventInitialized = true;
    }
    public void SetTimeShown()
    {
        if(this.PackTimerStarted == true)
        {
                return;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        string val_3 = ???.ToString();
        this.progressData.LastShownAt = ;
    }
    public void TryMakePurchase()
    {
        var val_2;
        var val_2 = 22451185;
        val_2 = 13174876 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        PurchaseProxy.currentPurchasePoint = this.<AccessPoint>k__BackingField;
        bool val_1 = PurchaseProxy.Purchase(purchase:  this.purchaseModel);
    }
    public void OnPurchaseSuccess(PurchaseModel purchase)
    {
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        if(this.purchaseResult == 0)
        {
                return;
        }
        
        GameBehavior val_1 = App.getBehavior;
        decimal val_2 = GetReward(rewardType:  purchase);
        35639170 = public System.Void System.Action<System.Boolean, System.Decimal>::Invoke(System.Boolean arg1, System.Decimal arg2);
        this.purchaseResult.Invoke(arg1:  true, arg2:  new System.Decimal() {flags = val_3, hi = val_4, lo = val_5, mid = val_6});
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
    public void SetShowedLevel()
    {
        Player val_1 = App.Player;
        this.ShowedLevel = 0;
    }
    public bool TryShowPopup(bool isOOC = False)
    {
        var val_6 = 0;
        if(this == 0)
        {
                return (bool)val_6;
        }
        
        if(this != 0)
        {
                return (bool)val_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = 0;
        if((-2060913200) != 0)
        {
                if(WGStarterPackController.StarterPackActive == true)
        {
                return (bool)val_6;
        }
        
        }
        
        this.GeneratePackages();
        GameBehavior val_4 = App.getBehavior;
        0.Setup(outOfCurrency:  isOOC);
        val_6 = 1;
        this.<AccessPoint>k__BackingField = 128;
        return (bool)val_6;
    }
    private void GeneratePackages()
    {
        int val_8;
        int val_9;
        int val_10;
        int val_11;
        var val_14;
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageById(packageId:  -1403597200);
        this.purchaseModel = new PurchaseModel(json:  -1403597200);
        string val_3 = getString(key:  -1403597104, defaultValue:  1098586544);
        twelvegigs.storage.JsonDictionary val_4 = PackagesManager.GetPackageById(packageId:  -1403597200);
        GameBehavior val_5 = App.getBehavior;
        GameBehavior val_6 = App.getBehavior;
        val_14 = null;
        val_14 = null;
        decimal val_7 = getDecimal(key:  -1403597200, defaultValue:  new System.Decimal() {hi = System.Decimal.Zero});
        this.purchaseModel.AddReward(rewardType:  null, amount:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_9, mid = val_8});
        typeof(PurchaseModel).__il2cppRuntimeField_5C = 2891370096;
        float val_13 = getFloat(key:  -1816221696, defaultValue:  getFloat(key:  -1816221696, defaultValue:  null));
        typeof(PurchaseModel).__il2cppRuntimeField_60 = 2891370096;
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
    private bool IsCurrentEventInCycle()
    {
        var val_1 = R6 + 48;
        val_1 = this.progressData.eventId - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public FOMOPackEventHandler()
    {
        this.progressData = new FOMOPackProgress();
    }

}
