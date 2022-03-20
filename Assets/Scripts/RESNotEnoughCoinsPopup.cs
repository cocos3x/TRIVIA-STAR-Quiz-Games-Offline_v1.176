using UnityEngine;
public class RESNotEnoughCoinsPopup : MonoBehaviour
{
    // Fields
    private const string ID_OOC = "restaurant_rivals_ooc_bundle";
    private UGUINetworkedButtonMultiGraphic purchaseButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text coinsAmount;
    private UnityEngine.UI.Text priceLabel;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private twelvegigs.storage.JsonDictionary package;
    private decimal initialCoins;
    
    // Methods
    private void OnPurchaseOOC(bool connected)
    {
        var val_9;
        var val_10;
        if(connected != false)
        {
                var val_9 = 27474381;
            val_9 = 8151680 + val_9;
            if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
            val_9 = null;
            val_9 = null;
            PurchaseProxy.currentPurchasePoint = 113;
            PurchaseModel val_1 = new PurchaseModel(json:  this.package);
            bool val_2 = PurchaseProxy.Purchase(purchase:  292597760);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_10 = null;
        val_10 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  -656327792, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnPurchaseCompleted(PurchaseModel purchase)
    {
        int val_6;
        if((System.String.op_Inequality(a:  purchase.id, b:  -656231600)) == true)
        {
                return;
        }
        
        Player val_2 = App.Player;
        decimal val_3 = Credits;
        decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -656206228, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_5 = App.Player;
        this.coinsAnimControl.Play(fromValue:  new System.Decimal() {mid = val_6}, toValue:  new System.Decimal() {hi = purchase}, textTickTime:  null, delayBeforeComplete:  null);
        System.Action val_7 = new System.Action(object:  -656194160, method:  new IntPtr(3638748112));
        this.coinsAnimControl.OnCompleteCallback = null;
    }
    private void OnPurchaseFailure(PurchaseModel purchase)
    {
        RESNotEnoughCoinsPopup val_9;
        var val_10;
        var val_11;
        var val_12;
        decimal val_14;
        decimal val_15;
        var val_16;
        val_9 = this;
        val_10 = 0;
        decimal val_1 = Keys;
        val_11 = 1152921504617017344;
        val_12 = null;
        val_12 = null;
        val_14 = System.Decimal.Zero;
        if((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_14})) == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_10 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        string val_5 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        val_9 = null;
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        val_14 = null;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_16 = null;
        val_16 = null;
        val_15 = System.Decimal.MinusOne;
        SetupMessage(titleTxt:  -1349324784, messageTxt:  -1349324672, shownButtons:  1054454320, buttonTexts:  val_14, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = val_15, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  -656061680, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClose()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        Player val_1 = App.Player;
        val_13 = 52;
        val_14 = 256;
        val_13 = val_13;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = this.initialCoins, lo = ???, mid = this})) != false)
        {
                Player val_3 = App.Player;
            RestaurantRivals.RESGameEcon val_4 = RestaurantRivals.RESGameEcon.Instance;
            if(0 >= 786466)
        {
                val_12 = 1152921511026388688;
            WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(VideoEnabledAndUnlocked() != false)
        {
                WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(rewardVideoCapReached != true)
        {
                GameBehavior val_9 = App.getBehavior;
            val_15 = null;
            val_15 = null;
        }
        
        }
        
        }
        
        }
        
        UnityEngine.GameObject val_11 = this.gameObject;
        SLCWindow.CloseWindow(window:  -655945584, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Awake()
    {
        var val_7;
        System.Delegate val_8;
        var val_9;
        System.Action<twelvegigs.storage.JsonDictionary> val_10;
        System.Delegate val_11;
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -655818224, method:  new IntPtr(3639113808));
        mem2[0] = null;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -655818224, method:  new IntPtr(3638748112));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        val_7 = null;
        val_7 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -655818224, method:  new IntPtr(3639123024));
        val_8 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_8, b:  7401472);
        val_9 = null;
        val_10 = null;
        if(val_8 == 0)
        {
            goto label_6;
        }
        
        if(null == val_10)
        {
            goto label_7;
        }
        
        val_10 = null;
        val_9 = 1152921504898486364;
        label_6:
        val_8 = 0;
        label_7:
        PurchasesHandler.OnPurchaseCompleted = val_8;
        val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -655818224, method:  new IntPtr(3639124048));
        val_11 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_6 = System.Delegate.Combine(a:  val_11, b:  7401472);
        if(val_11 != 0)
        {
                if(null == null)
        {
            goto label_9;
        }
        
        }
        
        val_11 = 0;
        label_9:
        PurchasesHandler.OnPurchaseFailure = val_11;
    }
    private void OnEnable()
    {
        bool val_7;
        var val_8;
        val_7 = static_value_021FAB0C;
        if(val_7 != true)
        {
                val_7 = true;
        }
        
        twelvegigs.storage.JsonDictionary val_1 = this.GetOOCPack();
        this.package = val_7;
        val_8 = null;
        val_8 = null;
        decimal val_2 = getDecimal(key:  1, defaultValue:  new System.Decimal() {flags = 2129282688, hi = System.Decimal.Zero});
        decimal val_3 = new System.Decimal(value:  999999999);
        string val_4 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal(), numLimit:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.flags});
        string val_5 = PackagesManager.GetPackagePrice(package:  this.package);
        Player val_6 = App.Player;
        if(0 != 0)
        {
                return;
        }
    
    }
    private void OnDestroy()
    {
        var val_5;
        System.Delegate val_6;
        var val_7;
        System.Action<twelvegigs.storage.JsonDictionary> val_8;
        System.Delegate val_9;
        val_5 = null;
        val_5 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -655557360, method:  new IntPtr(3639123024));
        val_6 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_2 = System.Delegate.Remove(source:  val_6, value:  7401472);
        val_7 = null;
        val_8 = null;
        if(val_6 == 0)
        {
            goto label_3;
        }
        
        if(null == val_8)
        {
            goto label_4;
        }
        
        val_8 = null;
        val_7 = 1152921504898486364;
        label_3:
        val_6 = 0;
        label_4:
        PurchasesHandler.OnPurchaseCompleted = val_6;
        val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -655557360, method:  new IntPtr(3639124048));
        val_9 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_4 = System.Delegate.Remove(source:  val_9, value:  7401472);
        if(val_9 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_9 = 0;
        label_6:
        PurchasesHandler.OnPurchaseFailure = val_9;
    }
    private twelvegigs.storage.JsonDictionary GetOOCPack()
    {
        return PackagesManager.GetPackageById(packageId:  -656231600);
    }
    public RESNotEnoughCoinsPopup()
    {
    
    }

}
