using UnityEngine;
public class WGStore_DicePacksPopup : MonoBehaviour, IStoreUI
{
    // Fields
    private UnityEngine.GameObject storeDicePackItemPrefab;
    private UnityEngine.Transform packParentXfm;
    private LimitedTimeBundlePackDisplay ltbPackDisplay;
    private UnityEngine.UI.Button closeButton;
    private GridCoinCollectAnimationInstantiator coinAnim;
    private WADPetFoodAnimationInstantiator foodAnim;
    private DiceRollAnimationInstantiator diceAnim;
    private System.Collections.Generic.List<WGStore_DicePackItem> packItems;
    private System.Collections.Generic.List<PurchaseModel> packages;
    
    // Properties
    private System.Collections.Generic.List<PurchaseModel> Packages { get; }
    
    // Methods
    private System.Collections.Generic.List<PurchaseModel> get_Packages()
    {
        if(this.packages != 0)
        {
                CompanyDevices val_1 = CompanyDevices.Instance;
            if(0.CompanyDevice() == false)
        {
                return;
        }
        
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<PurchaseModel> val_4 = RetrieveDiceRollsPurchasePacks();
        this.packages = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance();
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1017914992, method:  typeof(WGStore_DicePacksPopup).__il2cppRuntimeField_108);
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        this.SetupPuchaseCallbacks();
        this.RefreshPackItemDisplays();
        this.SetupLimitedTimeDiceBundle();
    }
    private void OnDestroy()
    {
        this.ResetPurchaseCallbacks();
    }
    public void RefreshPackItemDisplays()
    {
        var val_2;
        if(this.packItems != 0)
        {
                if(this.packItems > 0)
        {
            goto label_2;
        }
        
        }
        
        this.CreatePackItems();
        label_2:
        val_2 = 4;
        goto label_3;
        label_11:
        if(this <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.List<PurchaseModel> val_1 = this.Packages;
        if(this.storeDicePackItemPrefab <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = 5;
        label_3:
        if((val_2 - 4) < 2621443)
        {
            goto label_11;
        }
    
    }
    public void CreatePackItems()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.packItems = null;
        System.Collections.Generic.List<PurchaseModel> val_2 = this.Packages;
        if(this.storeDicePackItemPrefab < 1)
        {
                return;
        }
        
        var val_3 = 0;
        do
        {
            this.MakeStoreItem(index:  0, parentXfm:  this.packParentXfm);
            val_3 = val_3 + 1;
        }
        while(this.storeDicePackItemPrefab != val_3);
    
    }
    public void PurchaseItemModel(PurchaseModel pack)
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        Purchase(purchase:  pack);
    }
    public void MakeStoreItem(int index, UnityEngine.Transform parentXfm)
    {
        object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.storeDicePackItemPrefab, parent:  parentXfm);
        System.Collections.Generic.List<PurchaseModel> val_2 = this.Packages;
        if(this.storeDicePackItemPrefab <= index)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + (index << 2);
        decimal val_3 = DiceRolls;
        string val_4 = -1253866384(-1253866384) + 10170368;
        if(this.storeDicePackItemPrefab != 0)
        {
                this.storeDicePackItemPrefab.name = -1253866384;
        }
        else
        {
                0.name = -1253866384;
        }
        
        object val_5 = this.storeDicePackItemPrefab.GetComponent<System.Object>();
        this.packItems.Add(item:  this.storeDicePackItemPrefab);
    }
    public void ShowConnectionRequired()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_6 = null;
        val_6 = null;
        0.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "dice");
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1016909344, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void SetupPuchaseCallbacks()
    {
        var val_5;
        System.Delegate val_6;
        var val_7;
        System.Action<twelvegigs.storage.JsonDictionary> val_8;
        System.Delegate val_9;
        val_5 = null;
        val_5 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1016795296, method:  new IntPtr(3278145952));
        val_6 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_6, b:  7401472);
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
        val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1016795296, method:  new IntPtr(3278146976));
        val_9 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_9, b:  7401472);
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
    private void ResetPurchaseCallbacks()
    {
        var val_5;
        System.Delegate val_6;
        var val_7;
        System.Action<twelvegigs.storage.JsonDictionary> val_8;
        System.Delegate val_9;
        val_5 = null;
        val_5 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1016683296, method:  new IntPtr(3278145952));
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
        val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1016683296, method:  new IntPtr(3278146976));
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
    private void OnPurchaseCompleted(PurchaseModel purchase)
    {
        var val_7;
        string val_9;
        decimal val_1 = DiceRolls;
        val_7 = null;
        val_7 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
                return;
        }
        
        val_9 = purchase.id;
        if((val_9.Contains(value:  -1017045424)) != true)
        {
                val_9 = purchase.id;
            if((val_9.Contains(value:  -1252680496)) == false)
        {
                return;
        }
        
        }
        
        System.Collections.IEnumerator val_5 = this.DisplayPurchaseSuccess(purchase:  purchase);
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -1016559008);
    }
    private void OnPurchaseFailure(PurchaseModel purchase)
    {
        if((purchase.id.Contains(value:  -1252680496)) != true)
        {
                if((purchase.id.Contains(value:  -1017045424)) == false)
        {
                return;
        }
        
        }
        
        string val_3 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        DisplayPurchaseFail(title:  -1349324784, message:  -1349324672);
    }
    private void AnimateCoins(decimal fromAmount, decimal toAmount, System.Action actionOnComplete)
    {
        GridCoinCollectAnimationInstantiator val_1;
        System.Action val_2;
        int val_3;
        int val_4;
        int val_5;
        val_1 = this.coinAnim;
        val_2 = actionOnComplete;
        if(val_1 == 0)
        {
                val_2 = val_2;
        }
        
        this.coinAnim.OnCompleteCallback = val_2;
        val_3 = toAmount.mid;
        val_4 = toAmount.lo;
        val_5 = toAmount.flags;
        if(this.coinAnim == 0)
        {
                val_1 = val_5;
            val_4 = toAmount.lo;
            val_5 = val_1;
            val_3 = toAmount.mid;
        }
        
        this.coinAnim.Play(fromValue:  new System.Decimal() {flags = fromAmount.flags, hi = fromAmount.hi, lo = fromAmount.lo, mid = fromAmount.mid}, toValue:  new System.Decimal() {flags = val_5, hi = toAmount.hi, lo = val_4, mid = val_3}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void AnimatePurchase(CurrencyCollectAnimationInstantiator animControl, int fromAmount, int toAmount, System.Action actionOnComplete, float delay = 0)
    {
        animControl.OnCompleteCallback = actionOnComplete;
        System.Collections.IEnumerator val_2 = this.StartAnimating(animControl:  animControl, fromAmount:  fromAmount, toAmount:  toAmount, delay:  delay);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -1016153376);
    }
    private System.Collections.IEnumerator StartAnimating(CurrencyCollectAnimationInstantiator animControl, int fromAmount, int toAmount, float delay)
    {
        float val_1;
        typeof(WGStore_DicePacksPopup.<StartAnimating>d__26).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGStore_DicePacksPopup.<StartAnimating>d__26).__il2cppRuntimeField_14 = animControl;
            typeof(WGStore_DicePacksPopup.<StartAnimating>d__26).__il2cppRuntimeField_18 = fromAmount;
            typeof(WGStore_DicePacksPopup.<StartAnimating>d__26).__il2cppRuntimeField_1C = toAmount;
        }
        else
        {
                mem[20] = animControl;
            mem[24] = fromAmount;
            mem[28] = toAmount;
        }
        
        typeof(WGStore_DicePacksPopup.<StartAnimating>d__26).__il2cppRuntimeField_10 = val_1;
    }
    private System.Collections.IEnumerator DisplayPurchaseSuccess(PurchaseModel purchase)
    {
        typeof(WGStore_DicePacksPopup.<DisplayPurchaseSuccess>d__27).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGStore_DicePacksPopup.<DisplayPurchaseSuccess>d__27).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(WGStore_DicePacksPopup.<DisplayPurchaseSuccess>d__27).__il2cppRuntimeField_10 = purchase;
    }
    private void DisplayPurchaseFail(string title, string message)
    {
        var val_4;
        GameBehavior val_1 = App.getBehavior;
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_3 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
        val_4 = null;
        val_4 = null;
        0.SetupMessage(titleTxt:  title, messageTxt:  message, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "dice");
    }
    private void SetupLimitedTimeDiceBundle()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.ltbPackDisplay)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_3 = GetAvailableBundles();
        string val_4 = Item[-1164149280];
        PurchaseModel val_5 = new PurchaseModel(packageDefinition:  -1566656096);
        string val_6 = Item[-1403597104];
        twelvegigs.storage.JsonDictionary val_7 = PackagesManager.GetPackageById(packageId:  -1566656096);
        PurchaseModel val_8 = new PurchaseModel(json:  -1566656096);
        this.ltbPackDisplay.Setup(purchase:  292597760, valueModel:  292597760, bundlePack:  -1566656096, timesPurchased:  0, isHot:  false, isBest:  true);
    }
    public WGStore_DicePacksPopup()
    {
    
    }

}
