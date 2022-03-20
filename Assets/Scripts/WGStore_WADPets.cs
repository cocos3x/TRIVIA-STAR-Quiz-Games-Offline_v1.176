using UnityEngine;
public class WGStore_WADPets : MonoBehaviour, IStoreUI
{
    // Fields
    private UnityEngine.UI.Text bannerText;
    private UnityEngine.GameObject storePetFoodItemPrefab;
    private UnityEngine.Transform packParentXfm;
    private UnityEngine.UI.Button closeButton;
    private WADPetFoodAnimationInstantiator foodAnim;
    private static WADPets.StoreType storeType;
    private System.Collections.Generic.List<WGStoreItem_pet> packItems;
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
        
        if(WGStore_WADPets.storeType != 0)
        {
                return;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<PurchaseModel> val_4 = RetrievePetsFoodPurchasePacks();
        this.packages = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance();
    }
    public void Init(WADPets.StoreType type)
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -960815184, method:  typeof(WGStore_WADPets).__il2cppRuntimeField_108);
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        WGStore_WADPets.storeType = type;
        this.SetupPuchaseCallbacks();
        this.SetupBannerText();
        this.RefreshPackItemDisplays();
        this.SetupCurrencyAnim();
    }
    public void PurchaseItemModel(PurchaseModel pack)
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        Purchase(purchase:  pack);
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
        if(this.bannerText <= R5)
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
        if(this.bannerText < 1)
        {
                return;
        }
        
        var val_3 = 0;
        do
        {
            this.MakeStoreItem(index:  0, parentXfm:  this.packParentXfm);
            val_3 = val_3 + 1;
        }
        while(this.bannerText != val_3);
    
    }
    public void MakeStoreItem(int index, UnityEngine.Transform parentXfm)
    {
        object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.storePetFoodItemPrefab, parent:  parentXfm);
        System.Collections.Generic.List<PurchaseModel> val_2 = this.Packages;
        if(this.bannerText <= index)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + (index << 2);
        decimal val_3 = PetsFood;
        string val_4 = -1253866384(-1253866384) + 10170368;
        if(this.storePetFoodItemPrefab != 0)
        {
                this.storePetFoodItemPrefab.name = -1253866384;
        }
        else
        {
                0.name = -1253866384;
        }
        
        object val_5 = this.storePetFoodItemPrefab.GetComponent<System.Object>();
        this.packItems.Add(item:  this.storePetFoodItemPrefab);
    }
    public void ShowConnectionRequired()
    {
        var val_7;
        WGStore_WADPets val_8;
        System.Func<System.Boolean> val_10;
        var val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_7 = null;
        val_8 = this;
        val_10 = WGStore_WADPets.<>c.<>9__15_0;
        if(val_10 == 0)
        {
                val_10 = null;
            val_10 = new System.Func<System.Boolean>(object:  WGStore_WADPets.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3334799728));
            WGStore_WADPets.<>c.<>9__15_0 = val_10;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_10;
        val_11 = null;
        val_11 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "food");
        this.Close();
    }
    public void Close()
    {
        if((-960030464) == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = R4.gameObject;
        SLCWindow.CloseWindow(window:  R4, setDestroyOnDisableState:  true, dontDestroyOnDisable:  true);
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
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -959916416, method:  new IntPtr(3335024832));
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
        val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -959916416, method:  new IntPtr(3335025856));
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
    private void OnDestroy()
    {
        this.ResetPurchaseCallbacks();
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
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -959692416, method:  new IntPtr(3335024832));
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
        val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -959692416, method:  new IntPtr(3335025856));
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
    private void OnFoodPurchaseCompleted(PurchaseModel purchase)
    {
        var val_5;
        decimal val_1 = PetsFood;
        val_5 = null;
        val_5 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) == true)
        {
                return;
        }
        
        System.Collections.IEnumerator val_3 = this.WaitPlayFoodAnim(purchase:  purchase);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -959576320);
    }
    private System.Collections.IEnumerator WaitPlayFoodAnim(PurchaseModel purchase)
    {
        typeof(WGStore_WADPets.<WaitPlayFoodAnim>d__21).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGStore_WADPets.<WaitPlayFoodAnim>d__21).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(WGStore_WADPets.<WaitPlayFoodAnim>d__21).__il2cppRuntimeField_14 = purchase;
    }
    private void OnPurchaseFailure(PurchaseModel model)
    {
        string val_1 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_2 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        DisplayPurchaseFail(title:  -1349324784, message:  -1349324672);
        this.Close();
    }
    public void DisplayPurchaseFail(string title, string message)
    {
        var val_5;
        System.Func<System.Boolean> val_7;
        var val_8;
        GameBehavior val_1 = App.getBehavior;
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_3 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
        val_5 = null;
        val_5 = null;
        val_7 = WGStore_WADPets.<>c.<>9__23_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<System.Boolean>(object:  WGStore_WADPets.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3335731648));
            WGStore_WADPets.<>c.<>9__23_0 = val_7;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_7;
        val_8 = null;
        val_8 = null;
        0.SetupMessage(titleTxt:  title, messageTxt:  message, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "food");
    }
    private void SetupBannerText()
    {
        string val_1 = Localization.Localize(key:  -959114336, defaultValue:  -959114432, useSingularKey:  false);
        if(this.bannerText == 0)
        {
            
        }
    
    }
    private void SetupCurrencyAnim()
    {
        UnityEngine.GameObject val_1 = this.foodAnim.gameObject;
        this.foodAnim.SetActive(value:  true);
    }
    public WGStore_WADPets()
    {
    
    }

}
