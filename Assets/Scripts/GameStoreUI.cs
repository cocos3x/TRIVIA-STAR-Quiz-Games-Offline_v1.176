using UnityEngine;
public class GameStoreUI : MonoSingleton<GameStoreUI>, IStoreUI
{
    // Fields
    private UnityEngine.UI.Button button_back;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private CurrencyCollectAnimationInstantiator gemAnimControl;
    private CurrencyCollectAnimationInstantiator goldCurrencyAnimControl;
    private CurrencyCollectAnimationInstantiator spinAnimControl;
    private WADPetFoodAnimationInstantiator foodAnimControl;
    private DiceRollAnimationInstantiator diceAnimControl;
    private UnityEngine.Transform xfm_category_content;
    private UnityEngine.UI.ScrollRect _scroll_category_content;
    private UnityEngine.CanvasGroup _canvas_category_content;
    private bool canPurchase;
    private bool didPurchase;
    private System.Collections.Generic.List<PurchaseModel> _Packages;
    private System.Collections.Generic.List<PurchaseModel> _PetsFoodPackages;
    private System.Collections.Generic.List<PurchaseModel> _GemPackages;
    private System.Collections.Generic.List<PurchaseModel> _SpinPackages;
    private System.Collections.Generic.Dictionary<string, GameStoreCategory> storeCategories;
    private System.Collections.Generic.Dictionary<string, float> normalishCategoryPositions;
    private System.Collections.Generic.List<WGStoreItem> packItems;
    private System.Collections.Generic.List<WGStoreItem_pet> foodPackItems;
    private System.Collections.Generic.List<WGStoreItem_gems> gemPackItems;
    private System.Collections.Generic.List<WGStoreItem_spins> spinPackItems;
    private WGStoreItem_NoAds noAdsItem;
    private System.Collections.Generic.Dictionary<string, WGStoreItem> standardPackItems;
    private float lastScrollPosition;
    public static TrackerPurchasePoints windowEntryPoint;
    public static System.Action OnRefreshDisplay;
    public static System.Action OnCreatePackItems;
    public static System.Action OnRewardAnimationsComplete;
    
    // Properties
    private UnityEngine.GameObject Prefab_PackItem { get; }
    private UnityEngine.GameObject Prefab_PackFoodItem { get; }
    private UnityEngine.GameObject Prefab_PackGemItem { get; }
    private UnityEngine.GameObject Prefab_goldenTicketItem { get; }
    private UnityEngine.GameObject Prefab_silverTicketItem { get; }
    private UnityEngine.GameObject Prefab_PackSpinItem { get; }
    private UnityEngine.GameObject Prefab_BonusRewardHeader { get; }
    private UnityEngine.GameObject Prefab_PackNoAdsItem { get; }
    public UnityEngine.GameObject Prefab_storePetFoodItem { get; }
    private GameStoreCategory Prefab_StoreCategory { get; }
    private UnityEngine.UI.ScrollRect scroll_category_content { get; }
    private UnityEngine.CanvasGroup canvas_category_content { get; }
    private System.Collections.Generic.List<PurchaseModel> Packages { get; }
    private System.Collections.Generic.List<PurchaseModel> PetsFoodPackages { get; }
    private System.Collections.Generic.List<PurchaseModel> GemPackages { get; }
    private System.Collections.Generic.List<PurchaseModel> SpinPackages { get; }
    public int CoinPackItemsCount { get; }
    
    // Methods
    private UnityEngine.GameObject get_Prefab_PackItem()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1262000640, prefabName:  -1257898784);
    }
    private UnityEngine.GameObject get_Prefab_PackFoodItem()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1262000640, prefabName:  -1257786688);
    }
    private UnityEngine.GameObject get_Prefab_PackGemItem()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1262000640, prefabName:  -1257674576);
    }
    private UnityEngine.GameObject get_Prefab_goldenTicketItem()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1262000640, prefabName:  -1257562464);
    }
    private UnityEngine.GameObject get_Prefab_silverTicketItem()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1262000640, prefabName:  -1257450352);
    }
    private UnityEngine.GameObject get_Prefab_PackSpinItem()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1262000640, prefabName:  -1257338240);
    }
    private UnityEngine.GameObject get_Prefab_BonusRewardHeader()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1262000640, prefabName:  -1257226128);
    }
    private UnityEngine.GameObject get_Prefab_PackNoAdsItem()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1262000640, prefabName:  -1257114000);
    }
    public UnityEngine.GameObject get_Prefab_storePetFoodItem()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1262000640, prefabName:  -1257786688);
    }
    private GameStoreCategory get_Prefab_StoreCategory()
    {
        return PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1262000640);
    }
    private UnityEngine.UI.ScrollRect get_scroll_category_content()
    {
        if(this._scroll_category_content != 0)
        {
                return;
        }
        
        object val_2 = this.xfm_category_content.GetComponent<System.Object>();
        this._scroll_category_content = this.xfm_category_content;
    }
    private UnityEngine.CanvasGroup get_canvas_category_content()
    {
        if(this._canvas_category_content != 0)
        {
                return;
        }
        
        object val_2 = this.xfm_category_content.GetComponent<System.Object>();
        this._canvas_category_content = this.xfm_category_content;
    }
    private System.Collections.Generic.List<PurchaseModel> get_Packages()
    {
        if(this._Packages != 0)
        {
                CompanyDevices val_1 = CompanyDevices.Instance;
            if(0.CompanyDevice() == false)
        {
                return;
        }
        
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<PurchaseModel> val_4 = RetrievePurchasePacks();
        this._Packages = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance();
    }
    private System.Collections.Generic.List<PurchaseModel> get_PetsFoodPackages()
    {
        if(this._PetsFoodPackages != 0)
        {
                CompanyDevices val_1 = CompanyDevices.Instance;
            if(0.CompanyDevice() == false)
        {
                return;
        }
        
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<PurchaseModel> val_4 = RetrievePetsFoodPurchasePacks();
        this._PetsFoodPackages = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance();
    }
    private System.Collections.Generic.List<PurchaseModel> get_GemPackages()
    {
        if(this._GemPackages != 0)
        {
                CompanyDevices val_1 = CompanyDevices.Instance;
            if(0.CompanyDevice() == false)
        {
                return;
        }
        
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<PurchaseModel> val_4 = RetrieveGemPurchasePacks();
        this._GemPackages = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance();
    }
    private System.Collections.Generic.List<PurchaseModel> get_SpinPackages()
    {
        if(this._SpinPackages != 0)
        {
                CompanyDevices val_1 = CompanyDevices.Instance;
            if(0.CompanyDevice() == false)
        {
                return;
        }
        
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<PurchaseModel> val_4 = RetrieveSpinPurchasePacks();
        this._SpinPackages = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance();
    }
    public int get_CoinPackItemsCount()
    {
        if(this.packItems == 0)
        {
                this.packItems = 0;
        }
        
        return (int)this.packItems;
    }
    public override void InitMonoSingleton()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.button_back)) != false)
        {
                UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1255832544, method:  typeof(GameStoreUI).__il2cppRuntimeField_118);
            this.button_back.m_OnClick.AddListener(call:  162246656);
        }
        
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1255832544, name:  -1255856672);
    }
    private void Start()
    {
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        System.Action val_1 = new System.Action(object:  -1255632480, method:  new IntPtr(3039235040));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
        val_28 = 1152921504901201920;
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2009665664) != 0)
        {
                WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            DisableSnapshottedCameras();
        }
        
        this.AdjustLowerRowStatViews();
        if(this.coinsAnimControl != 0)
        {
                if(this.coinsAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(this.gemAnimControl != 0)
        {
                if(this.gemAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(this.goldCurrencyAnimControl != 0)
        {
                if(this.goldCurrencyAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(this.foodAnimControl != 0)
        {
                if(this.foodAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(this.spinAnimControl != 0)
        {
                if(this.spinAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        if(this.diceAnimControl != 0)
        {
                if(this.diceAnimControl != 0)
        {
                mem2[0] = 0;
        }
        
        }
        
        val_29 = 6461924 + 29163863;
        if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
        val_30 = null;
        val_30 = null;
        if(App.game != 20)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1537803328) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_18.Hide();
        }
        
        val_28 = 1152921511941124064;
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1255657504) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRestaurantUI MonoSingleton<RestaurantRivals.RESRestaurantUI>::get_Instance().__il2cppRuntimeField_24.Hide();
        }
        
        UnityEngine.Transform val_23 = this.transform;
        UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  null, y:  null);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -6.272828E-07f, y = val_24.x});
        if(this != 0)
        {
                if(null != null)
        {
                val_31 = 0;
        }
        
        }
        else
        {
                val_31 = 0;
        }
        
        val_29 = 0;
        val_31.localPosition = new UnityEngine.Vector3();
        UnityEngine.Transform val_26 = this.transform;
        val_32 = 0;
        if(this != 0)
        {
                if(null != null)
        {
                this = 0;
        }
        
            val_32 = this;
        }
        
        DG.Tweening.Tweener val_27 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  0, endValue:  val_25.x, duration:  val_25.y, snapping:  false);
    }
    private void OnEnable()
    {
        this.didPurchase = false;
        SLCDebug.Log(logMessage:  -1255470656, colorHash:  -1255470752, isError:  false);
        this.canPurchase = true;
        this.button_back.enabled = true;
        this.RefreshPackItemDisplays();
        Player val_1 = App.Player;
        this.coinsAnimControl.Set(instantValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256});
    }
    private void AdjustFoodStatView()
    {
        var val_6;
        var val_7;
        if(this.foodAnimControl == 0)
        {
                return;
        }
        
        object val_2 = this.foodAnimControl.GetComponent<System.Object>();
        UnityEngine.Vector2 val_3 = 0.anchoredPosition;
        var val_6 = 29159179;
        val_6 = 6466608 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(App.game != 1)
        {
            goto label_11;
        }
        
        goto label_12;
        label_11:
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        if(App.game != 4)
        {
            goto label_18;
        }
        
        label_12:
        UnityEngine.Vector2 val_4;
        val_4 = new UnityEngine.Vector2(x:  val_3.x, y:  val_3.y);
        label_18:
        object val_5 = this.foodAnimControl.GetComponent<System.Object>();
        this.foodAnimControl.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
    }
    private void AdjustLowerRowStatViews()
    {
        float val_12;
        var val_13;
        float val_14;
        var val_15;
        float val_16;
        val_12 = 1152921504765685760;
        if(this.foodAnimControl == 0)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        object val_3 = this.foodAnimControl.GetComponent<System.Object>();
        val_13 = 0;
        UnityEngine.Vector2 val_4 = 0.anchoredPosition;
        if(this.diceAnimControl != 0)
        {
                GameBehavior val_6 = App.getBehavior;
            val_13 = 0;
        }
        
        var val_12 = 29162495;
        val_12 = 6463292 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        if(App.game == 1)
        {
                UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_14 = 3283025920, y:  val_4.y);
        }
        
        object val_8 = this.foodAnimControl.GetComponent<System.Object>();
        val_12 = val_7.x;
        val_16 = this.foodAnimControl;
        val_16.anchoredPosition = new UnityEngine.Vector2() {x = val_12, y = val_7.y};
        UnityEngine.GameObject val_9 = this.diceAnimControl.gameObject;
        this.diceAnimControl.SetActive(value:  false);
        if(val_13 == 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_14, y:  val_4.y);
        object val_11 = this.diceAnimControl.GetComponent<System.Object>();
        this.diceAnimControl.anchoredPosition = new UnityEngine.Vector2() {x = val_10.x, y = val_16};
    }
    public void RefreshPackItemDisplays()
    {
        var val_18;
        System.Func<PurchaseModel, System.Boolean> val_20;
        var val_21;
        var val_22;
        System.Func<PurchaseModel, System.Boolean> val_24;
        var val_25;
        float val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        System.Action val_32;
        var val_33;
        if(this.packItems != 0)
        {
                if(this.packItems > 0)
        {
            goto label_2;
        }
        
        }
        
        this.CreatePackItems();
        label_2:
        if(this.noAdsItem != 0)
        {
                System.Collections.Generic.List<PurchaseModel> val_2 = this.Packages;
            val_18 = null;
            val_18 = null;
            val_20 = GameStoreUI.<>c.<>9__68_0;
            if(val_20 == 0)
        {
                val_20 = null;
            val_20 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  GameStoreUI.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3039931104));
            GameStoreUI.<>c.<>9__68_0 = val_20;
        }
        
            object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -1254938368, predicate:  7720960);
            val_21 = this;
            if(this == 0)
        {
                System.Collections.Generic.List<PurchaseModel> val_5 = this.GemPackages;
            val_22 = null;
            val_22 = null;
            val_24 = GameStoreUI.<>c.<>9__68_1;
            if(val_24 == 0)
        {
                val_24 = null;
            val_24 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  GameStoreUI.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3039934176));
            GameStoreUI.<>c.<>9__68_1 = val_24;
        }
        
            object val_7 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -1254938368, predicate:  7720960);
            val_21 = this;
        }
        
            if(val_21 != 0)
        {
            
        }
        else
        {
                UnityEngine.GameObject val_8 = this.noAdsItem.gameObject;
            this.noAdsItem.SetActive(value:  false);
        }
        
        }
        
        val_25 = 4;
        goto label_21;
        label_29:
        if(this.noAdsItem <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.List<PurchaseModel> val_9 = this.Packages;
        if(this.button_back <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_26 = 3.673424E-39f;
        val_25 = 5;
        label_21:
        var val_10 = val_25 - 4;
        if(val_10 < 2621443)
        {
            goto label_29;
        }
        
        val_27 = 4;
        goto label_30;
        label_38:
        if(2621443 <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.List<PurchaseModel> val_11 = this.PetsFoodPackages;
        if(this.button_back <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_26 = 3.673424E-39f;
        val_27 = 5;
        label_30:
        var val_12 = val_27 - 4;
        if(val_12 < 2621443)
        {
            goto label_38;
        }
        
        val_28 = 4;
        goto label_39;
        label_47:
        if(2621443 <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.List<PurchaseModel> val_13 = this.GemPackages;
        if(this.button_back <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_26 = 3.673424E-39f;
        val_28 = 5;
        label_39:
        var val_14 = val_28 - 4;
        if(val_14 < 2621443)
        {
            goto label_47;
        }
        
        val_29 = 4;
        goto label_48;
        label_56:
        if(2621443 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.List<PurchaseModel> val_15 = this.SpinPackages;
        if(this.button_back <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_26 = 3.673424E-39f;
        val_29 = 5;
        label_48:
        if((val_29 - 4) < 2621443)
        {
            goto label_56;
        }
        
        var val_23 = 29160151;
        val_23 = 6465636 + val_23;
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        val_30 = null;
        val_30 = null;
        if(App.game != 20)
        {
                Player val_17 = App.Player;
            GameEcon val_18 = App.getGameEcon;
            if(0 < 0)
        {
                0 = 1;
        }
        
            this.ShowOrHidePackItem(packId:  -1254962464, show:  true);
        }
        
        val_31 = null;
        val_31 = null;
        val_32 = GameStoreUI.OnRefreshDisplay;
        if(val_32 != 0)
        {
                val_32 = GameStoreUI.OnRefreshDisplay;
            if(val_32 == 0)
        {
                val_32 = 0;
        }
        
            val_32.Invoke();
        }
        
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        val_33 = null;
        val_33 = null;
        if(App.game == 20)
        {
                return;
        }
        
        UnityEngine.CanvasGroup val_20 = this.canvas_category_content;
        this.alpha = 0 + 1204;
        System.Collections.IEnumerator val_21 = this.WaitAndScroll();
        UnityEngine.Coroutine val_22 = this.StartCoroutine(routine:  -1254938368);
    }
    public GameStoreCategory GetOrCreateCategory(string categoryTitle, bool showTitle = True, int siblingIndex = -1)
    {
        System.Collections.Generic.Dictionary<System.String, GameStoreCategory> val_11;
        var val_13;
        GameStoreCategory val_14;
        val_11 = this;
        bool val_1 = this.storeCategories.ContainsKey(key:  categoryTitle);
        if(val_1 != false)
        {
                val_13 = 1152921511942022336;
            GameStoreCategory val_2 = this.storeCategories.Item[categoryTitle];
            if(this.storeCategories != 0)
        {
                if(siblingIndex >= 0)
        {
                GameStoreCategory val_4 = this.storeCategories.Item[categoryTitle];
            UnityEngine.Transform val_5 = this.storeCategories.transform;
            this.storeCategories.SetSiblingIndex(index:  siblingIndex);
        }
        
            GameStoreCategory val_6 = this.storeCategories.Item[categoryTitle];
            val_14 = this.storeCategories;
            return;
        }
        
        }
        
        GameStoreCategory val_7 = val_1.Prefab_StoreCategory;
        object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  val_1, parent:  this.xfm_category_content);
        val_14 = val_1;
        UnityEngine.Transform val_9 = val_14.transform;
        val_13 = val_14;
        val_13.name = categoryTitle;
        val_14.Setup(categoryTitle:  categoryTitle, showTitle:  showTitle);
        val_11 = this.storeCategories;
        val_11.Add(key:  categoryTitle, value:  val_14);
        if(siblingIndex < 0)
        {
                return;
        }
        
        UnityEngine.Transform val_10 = val_14.transform;
        val_14.SetSiblingIndex(index:  siblingIndex);
    }
    public void ShowOrHidePackItem(string packId, bool show)
    {
        if((this.standardPackItems.ContainsKey(key:  packId)) == false)
        {
                return;
        }
        
        WGStoreItem val_2 = this.standardPackItems.Item[packId];
        UnityEngine.GameObject val_3 = this.standardPackItems.gameObject;
        this.standardPackItems.SetActive(value:  show);
    }
    public int GetStoreItemIndex(string packId)
    {
        System.Collections.Generic.List<WGStoreItem> val_3;
        var val_4;
        val_3 = this.packItems;
        if(val_3 == 0)
        {
                return 0;
        }
        
        val_4 = 0;
        goto label_2;
        label_8:
        if(true <= val_4)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 0;
        val_3 = mem[(0 + 0) + 16];
        val_3 = (0 + 0) + 16;
        string val_1 = val_3.PackID;
        bool val_2 = System.String.op_Equality(a:  val_3, b:  packId);
        if(val_2 == true)
        {
                return 0;
        }
        
        val_3 = this.packItems;
        val_4 = 1;
        label_2:
        if(val_4 < val_2)
        {
            goto label_8;
        }
        
        return 0;
    }
    private System.Collections.IEnumerator WaitAndScroll()
    {
        object val_1 = new System.Object();
        typeof(GameStoreUI.<WaitAndScroll>d__72).__il2cppRuntimeField_8 = 0;
        typeof(GameStoreUI.<WaitAndScroll>d__72).__il2cppRuntimeField_10 = this;
    }
    public void CreatePackItems()
    {
        WGStoreItem_NoAds val_52;
        var val_53;
        System.Action val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        val_52 = this;
        val_53 = null;
        val_53 = null;
        val_54 = GameStoreUI.OnCreatePackItems;
        if(val_54 != 0)
        {
                val_54 = GameStoreUI.OnCreatePackItems;
            if(val_54 == 0)
        {
                val_54 = 0;
        }
        
            val_54.Invoke();
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.packItems = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.foodPackItems = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.gemPackItems = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.spinPackItems = null;
        var val_52 = 29158371;
        val_52 = 6467416 + val_52;
        if(val_52 == 0)
        {
                mem2[0] = 1;
        }
        
        val_55 = null;
        val_55 = null;
        if(App.game == 16)
        {
                val_56 = 0;
        }
        else
        {
                if(val_52 == 0)
        {
                mem2[0] = 1;
        }
        
            val_55 = null;
            val_55 = null;
            if(App.game == 12)
        {
                val_56 = 0;
        }
        
        }
        
        GameBehavior val_5 = App.getBehavior;
        if(0 == 0)
        {
            goto label_23;
        }
        
        GameStoreCategory val_6 = this.GetOrCreateCategory(categoryTitle:  -1254199616, showTitle:  false, siblingIndex:  0);
        val_57 = 0;
        goto label_24;
        label_28:
        UnityEngine.Transform val_7 = this.gemAnimControl.transform;
        this.MakeSpinItem(index:  0, parentXfm:  this.gemAnimControl);
        val_57 = 1;
        label_24:
        System.Collections.Generic.List<PurchaseModel> val_8 = this.SpinPackages;
        if(val_57 < this.button_back)
        {
            goto label_28;
        }
        
        label_23:
        GameBehavior val_9 = App.getBehavior;
        if(0 != 0)
        {
                WGBonusRewardsHandler val_10 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if((-1254191344) != 0)
        {
                GameStoreCategory val_12 = this.GetOrCreateCategory(categoryTitle:  -1254190320, showTitle:  false, siblingIndex:  0);
            UnityEngine.GameObject val_13 = this.Prefab_BonusRewardHeader;
            UnityEngine.Transform val_14 = this.gemAnimControl.transform;
            object val_15 = UnityEngine.Object.Instantiate<System.Object>(original:  -1254136272, parent:  this.gemAnimControl);
        }
        
        }
        
        GameBehavior val_16 = App.getBehavior;
        val_58 = 35625787;
        if(0 == 0)
        {
            goto label_61;
        }
        
        GameStoreCategory val_17 = this.GetOrCreateCategory(categoryTitle:  -1254186128, showTitle:  false, siblingIndex:  1);
        UnityEngine.GameObject val_18 = this.Prefab_PackNoAdsItem;
        UnityEngine.Transform val_19 = this.gemAnimControl.transform;
        object val_20 = UnityEngine.Object.Instantiate<System.Object>(original:  -1254136272, parent:  this.gemAnimControl);
        if((-1254136272) == 0)
        {
            goto label_56;
        }
        
        object val_22 = this.GetComponent<System.Object>();
        if((UnityEngine.Object.op_Implicit(exists:  -1254136272)) == false)
        {
            goto label_56;
        }
        
        val_58 = 35625787;
        object val_24 = this.GetComponent<System.Object>();
        this.noAdsItem = val_52;
        goto label_61;
        label_56:
        val_58 = 35625787;
        if((-1254136272) != 0)
        {
                this.SetActive(value:  false);
        }
        
        label_61:
        GameBehavior val_26 = App.getBehavior;
        GameStoreCategory val_27 = this.GetOrCreateCategory(categoryTitle:  null, showTitle:  false, siblingIndex:  0);
        twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_59 = 0;
        if((-1897280256) != 0)
        {
                GameBehavior val_30 = App.getBehavior;
            val_59 = 0;
            if(0 != 0)
        {
                GameBehavior val_31 = App.getBehavior;
            val_59 = 0;
            if(0 == 0)
        {
                var val_53 = 0;
            int val_32 = PackagesManager.GetAdPackageCount(packageType:  2129282688);
            if(val_32 >= 1)
        {
                do
        {
            UnityEngine.Transform val_33 = this.gemAnimControl.transform;
            this.MakeStoreItem(index:  0, parentXfm:  this.gemAnimControl);
            val_53 = val_53 + 1;
        }
        while(val_32 != val_53);
        
        }
        
            GameBehavior val_34 = App.getBehavior;
            if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((hasSubscription(subPackage:  1)) != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_38 = silverTicketUnlocked;
            if(val_38 != false)
        {
                UnityEngine.GameObject val_39 = val_38.Prefab_silverTicketItem;
            UnityEngine.Transform val_40 = this.gemAnimControl.transform;
            object val_41 = UnityEngine.Object.Instantiate<System.Object>(original:  val_38, parent:  this.gemAnimControl);
        }
        
        }
        
        }
        
            twelvegigs.Autopilot.AutopilotManager val_42 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_43 = hasSubscription(subPackage:  0);
            val_59 = 4;
            if(val_43 != true)
        {
                UnityEngine.GameObject val_44 = val_43.Prefab_goldenTicketItem;
            UnityEngine.Transform val_45 = this.gemAnimControl.transform;
            object val_46 = UnityEngine.Object.Instantiate<System.Object>(original:  val_43, parent:  this.gemAnimControl);
            val_52 = val_52;
        }
        
            val_58 = 6469960 + 29155827;
        }
        
        }
        
        }
        
        System.Collections.Generic.List<PurchaseModel> val_47 = this.Packages;
        if(val_58 == 0)
        {
                mem2[0] = 1;
        }
        
        val_60 = null;
        val_60 = null;
        if(App.game == 16)
        {
                this.button_back = this.button_back - 1;
        }
        
        if(val_59 < this.button_back)
        {
                do
        {
            UnityEngine.Transform val_48 = this.gemAnimControl.transform;
            this.MakeStoreItem(index:  4, parentXfm:  this.gemAnimControl);
            val_59 = val_59 + 1;
        }
        while(this.button_back != val_59);
        
            val_60 = null;
        }
        
        GameBehavior val_49 = App.getBehavior;
        if(0 != 0)
        {
                string val_50 = Localization.Localize(key:  -1254160368, defaultValue:  -1254160448, useSingularKey:  false);
            GameStoreCategory val_51 = this.GetOrCreateCategory(categoryTitle:  -1254160368, showTitle:  false, siblingIndex:  0);
        }
    
    }
    public void ScrollToCategory(string categoryName)
    {
        System.Collections.Generic.Dictionary<System.String, System.Single> val_8;
        var val_9;
        val_8 = 0;
        if((System.String.IsNullOrEmpty(value:  categoryName)) == false)
        {
            goto label_1;
        }
        
        UnityEngine.UI.ScrollRect val_2 = this.scroll_category_content;
        val_9 = this;
        goto label_2;
        label_1:
        if((this.storeCategories.ContainsKey(key:  categoryName)) == false)
        {
            goto label_4;
        }
        
        val_8 = this.normalishCategoryPositions;
        this.lastScrollPosition = val_8;
        UnityEngine.UI.ScrollRect val_5 = this.scroll_category_content;
        val_9 = this;
        label_2:
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_8.Item[categoryName], y:  null);
        this.normalizedPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        return;
        label_4:
        typeof(System.String[]).__il2cppRuntimeField_10 = "Store could not scroll to ";
        typeof(System.String[]).__il2cppRuntimeField_14 = categoryName;
        typeof(System.String[]).__il2cppRuntimeField_18 = " : ";
        typeof(System.String[]).__il2cppRuntimeField_1C = categoryName;
        typeof(System.String[]).__il2cppRuntimeField_20 = " is not a category key.";
        string val_7 = +477709520;
        UnityEngine.Debug.LogError(message:  477709520);
    }
    public void MakeStoreItem(int index, UnityEngine.Transform parentXfm)
    {
        bool val_8 = static_value_021F9D8D;
        if(val_8 != true)
        {
                val_8 = true;
        }
        
        UnityEngine.GameObject val_1 = this.Prefab_PackItem;
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  1, parent:  parentXfm);
        System.Collections.Generic.List<PurchaseModel> val_3 = this.Packages;
        if(this.button_back <= index)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (index << 2);
        decimal val_4 = Credits;
        string val_5 = -1253866384(-1253866384) + 10170368;
        if(val_8 != 0)
        {
                val_8.name = -1253866384;
        }
        else
        {
                0.name = -1253866384;
        }
        
        object val_6 = val_8.GetComponent<System.Object>();
        this.packItems.Add(item:  1);
        System.Collections.Generic.List<PurchaseModel> val_7 = this.Packages;
        if(this.button_back <= index)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + (index << 2);
        this.standardPackItems.Add(key:  (0 + (index) << 2) + 16 + 12, value:  1);
    }
    private void MakePetsFoodItem(int index, UnityEngine.Transform parentXfm)
    {
        bool val_8 = static_value_021F9D8E;
        if(val_8 != true)
        {
                val_8 = true;
        }
        
        UnityEngine.GameObject val_1 = this.Prefab_PackFoodItem;
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  1, parent:  parentXfm);
        System.Collections.Generic.List<PurchaseModel> val_3 = this.PetsFoodPackages;
        if(this.button_back <= index)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (index << 2);
        decimal val_4 = PetsFood;
        string val_5 = -1253866384(-1253866384) + 10170368;
        if(val_8 != 0)
        {
                val_8.name = -1253866384;
        }
        else
        {
                0.name = -1253866384;
        }
        
        object val_6 = val_8.GetComponent<System.Object>();
        object val_7 = val_8.GetComponent<System.Object>();
        this.foodPackItems.Add(item:  1);
    }
    private void MakeGemItem(int index, UnityEngine.Transform parentXfm)
    {
        bool val_7;
        var val_8;
        var val_9;
        val_7 = static_value_021F9D8F;
        if(val_7 != true)
        {
                val_7 = true;
        }
        
        UnityEngine.GameObject val_1 = this.Prefab_PackGemItem;
        val_8 = val_7;
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  1, parent:  parentXfm);
        if(index > 1)
        {
                System.Collections.Generic.List<PurchaseModel> val_3 = this.GemPackages;
            if(this.button_back <= index)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_7 = val_7 + (index << 2);
            decimal val_4 = Gems;
            string val_5 = -1253570608(-1253570608) + 10170368;
            val_9 = "GemPackItem_";
        }
        else
        {
                val_9 = "subscription";
        }
        
        if(val_8 != 0)
        {
                val_8.name = -1812972384;
        }
        else
        {
                0.name = -1812972384;
        }
        
        object val_6 = val_8.GetComponent<System.Object>();
        this.gemPackItems.Add(item:  1);
    }
    private void MakeSpinItem(int index, UnityEngine.Transform parentXfm)
    {
        bool val_7 = static_value_021F9D90;
        if(val_7 != true)
        {
                val_7 = true;
        }
        
        UnityEngine.GameObject val_1 = this.Prefab_PackSpinItem;
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  1, parent:  parentXfm);
        System.Collections.Generic.List<PurchaseModel> val_3 = this.SpinPackages;
        if(this.button_back <= index)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + (index << 2);
        decimal val_4 = Spins;
        string val_5 = -1253431888(-1253431888) + 10170368;
        if(val_7 != 0)
        {
                val_7.name = -1253431888;
        }
        else
        {
                0.name = -1253431888;
        }
        
        object val_6 = val_7.GetComponent<System.Object>();
        this.spinPackItems.Add(item:  1);
    }
    public virtual void PurchaseItemModel(PurchaseModel pack)
    {
        float val_3;
        if(this.canPurchase == false)
        {
                return;
        }
        
        SLCDebug.Log(logMessage:  -1253297168, colorHash:  -1253297264, isError:  false);
        this.canPurchase = true;
        this.didPurchase = true;
        this.button_back.enabled = false;
        UnityEngine.UI.ScrollRect val_1 = this.scroll_category_content;
        35626385 = this;
        UnityEngine.Vector2 val_2 = normalizedPosition;
        this.lastScrollPosition = val_3;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        Purchase(purchase:  pack);
    }
    public void ShowConnectionRequired()
    {
        var val_7;
        System.Func<System.Boolean> val_9;
        var val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_7 = null;
        val_7 = null;
        val_9 = GameStoreUI.<>c.<>9__80_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Func<System.Boolean>(object:  GameStoreUI.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3041795616));
            GameStoreUI.<>c.<>9__80_0 = val_9;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_9;
        val_10 = null;
        val_10 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    public void UpdateCoins(decimal amount)
    {
        this.coinsAnimControl.Set(instantValue:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid});
    }
    private void OnPurchaseNoAdsPackSuccess()
    {
        Player val_1 = App.Player;
        0.RemovedAds = true;
        this.RefreshPackItemDisplays();
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
    }
    public void DisplayPurchaseFail(string title, string message)
    {
        var val_7;
        string val_8;
        string val_9;
        var val_10;
        var val_11;
        System.Func<System.Boolean> val_13;
        var val_14;
        val_7 = this;
        val_8 = message;
        val_9 = title;
        val_10 = 1152921511937925344;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1258856224) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
            val_9 = val_7;
            val_11 = null;
            val_11 = null;
            val_13 = GameStoreUI.<>c.<>9__83_0;
            if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new System.Func<System.Boolean>(object:  GameStoreUI.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3042149024));
            GameStoreUI.<>c.<>9__83_0 = val_13;
        }
        
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_13;
            val_8 = null;
            val_14 = null;
            val_14 = null;
            SetupMessage(titleTxt:  val_9, messageTxt:  val_8, shownButtons:  1054454320, buttonTexts:  val_8, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
            val_7 = val_9;
        }
        
        SLCDebug.Log(logMessage:  -1252817248, colorHash:  -1255470752, isError:  false);
        this.canPurchase = true;
        this.button_back.enabled = true;
        this.didPurchase = false;
    }
    public void DisplayPurchaseSuccess(PurchaseModel purchase)
    {
        int val_19;
        var val_83;
        float val_84;
        var val_86;
        int val_87;
        CurrencyCollectAnimationInstantiator val_88;
        var val_90;
        var val_92;
        var val_94;
        int val_95;
        CurrencyCollectAnimationInstantiator val_96;
        var val_98;
        var val_101;
        int val_102;
        CurrencyCollectAnimationInstantiator val_103;
        var val_105;
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeSelf == false)
        {
            goto label_2;
        }
        
        val_83 = 0;
        bool val_3 = purchase.id.Contains(value:  -1252680496);
        decimal val_4 = Credits;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                decimal val_6 = Gems;
            decimal val_8 = GoldenCurrency;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
                1.8f = 1076677836;
        }
        
            decimal val_10 = PetsFood;
            float val_77 = 0.9f;
            float val_11 = 1.8f + val_77;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) == true)
        {
                1.8f = val_11;
        }
        
            decimal val_13 = Spins;
            val_11 = 1.8f + val_77;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
                1.8f = val_11;
        }
        
            val_77 = 1.8f + val_77;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) == true)
        {
                1.8f = val_77;
        }
        
            Player val_15 = App.Player;
            decimal val_16 = Credits;
            decimal val_17 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1252663368, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            Player val_18 = App.Player;
            this.AnimateCoins(fromAmount:  new System.Decimal() {mid = val_19}, toAmount:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, actionOnComplete:  0);
            System.Collections.IEnumerator val_21 = new System.Action(object:  -1252651296, method:  new IntPtr(3042286880)).PurchaseDelayComplete(waitTime:  val_11, onCompleteAction:  1.8f);
            UnityEngine.Coroutine val_22 = this.StartCoroutine(routine:  new System.Action(object:  -1252651296, method:  new IntPtr(3042286880)) = new System.Action(object:  -1252651296, method:  new IntPtr(3042286880)));
            val_83 = 1;
        }
        
        decimal val_23 = Gems;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_25;
        }
        
        if(val_3 == true)
        {
                val_84 = 1072064102;
        }
        
        if(val_83 == 0)
        {
            goto label_26;
        }
        
        Player val_26 = App.Player;
        decimal val_27 = Gems;
        Player val_29 = App.Player;
        int val_30 = 0 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
        goto label_33;
        label_25:
        val_84 = 0.9f;
        goto label_34;
        label_26:
        Player val_31 = App.Player;
        decimal val_32 = Gems;
        Player val_34 = App.Player;
        System.Action val_35 = new System.Action(object:  -1252651296, method:  new IntPtr(3042287904));
        label_33:
        this.AnimatePurchase(animControl:  mem[1152921511944130292], fromAmount:  0 - (System.Decimal.op_Explicit(value:  new System.Decimal())), toAmount:  0, actionOnComplete:  null, delay:  1.8f);
        val_83 = 1;
        label_34:
        decimal val_37 = PetsFood;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                val_84 = 0f + val_84;
            if(val_83 != 0)
        {
                Player val_40 = App.Player;
            decimal val_41 = PetsFood;
            Player val_43 = App.Player;
            val_86 = 1;
            val_87 = 1 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            val_88 = mem[1152921511944130304];
        }
        else
        {
                Player val_44 = App.Player;
            decimal val_45 = PetsFood;
            Player val_47 = App.Player;
            System.Action val_48 = new System.Action(object:  -1252651296, method:  new IntPtr(3042288928));
            val_87 = 1 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            val_88 = mem[1152921511944130304];
            val_86 = 1;
        }
        
            this.AnimatePurchase(animControl:  val_88, fromAmount:  val_87, toAmount:  1, actionOnComplete:  null, delay:  0f = 1063675494);
            val_83 = 1;
        }
        
        decimal val_49 = GoldenCurrency;
        val_90 = null;
        val_90 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                val_92 = null;
            val_84 = 0f + val_84;
            if(val_83 != 0)
        {
                Player val_52 = App.Player;
            decimal val_53 = GoldenCurrency;
            Player val_55 = App.Player;
            val_94 = 4;
            val_95 = 4 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            val_96 = mem[1152921511944130296];
        }
        else
        {
                Player val_56 = App.Player;
            decimal val_57 = GoldenCurrency;
            Player val_59 = App.Player;
            System.Action val_60 = new System.Action(object:  -1252651296, method:  new IntPtr(3042289952));
            val_95 = 4 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            val_96 = mem[1152921511944130296];
            val_94 = 4;
        }
        
            this.AnimatePurchase(animControl:  val_96, fromAmount:  val_95, toAmount:  4, actionOnComplete:  null, delay:  0f = 1063675494);
            val_83 = 1;
        }
        
        decimal val_61 = Spins;
        val_98 = null;
        val_98 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                if(val_3 == true)
        {
                0f = 1063675494;
        }
        
            RestaurantRivals.RESPlayer val_63 = RestaurantRivals.RESPlayer.Instance;
            val_84 = 0f + val_84;
            if(val_83 != 0)
        {
                decimal val_64 = Spins;
            RestaurantRivals.RESPlayer val_66 = RestaurantRivals.RESPlayer.Instance;
            val_101 = 33453552;
            val_102 = (9.34741E-38f) - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            val_103 = mem[1152921511944130300];
        }
        else
        {
                decimal val_67 = Spins;
            RestaurantRivals.RESPlayer val_69 = RestaurantRivals.RESPlayer.Instance;
            System.Action val_70 = new System.Action(object:  -1252651296, method:  new IntPtr(3042290976));
            val_102 = (9.34741E-38f) - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            val_103 = mem[1152921511944130300];
            val_101 = 33453552;
        }
        
            this.AnimatePurchase(animControl:  val_103, fromAmount:  val_102, toAmount:  33453552, actionOnComplete:  null, delay:  0.9f);
            val_83 = 1;
        }
        
        decimal val_71 = DiceRolls;
        val_105 = null;
        val_105 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                if(val_3 == true)
        {
                0f = 1063675494;
        }
        
            val_84 = 0f + val_84;
            if(val_83 != 0)
        {
                decimal val_74 = DiceRolls;
            int val_76 = (SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetDiceBalance()) - (System.Decimal.op_Explicit(value:  new System.Decimal()));
        }
        
        }
    
    }
    private System.Collections.IEnumerator PurchaseDelayComplete(float waitTime, System.Action onCompleteAction)
    {
        typeof(GameStoreUI.<PurchaseDelayComplete>d__85).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(GameStoreUI.<PurchaseDelayComplete>d__85).__il2cppRuntimeField_10 = onCompleteAction;
        }
        else
        {
                mem[16] = onCompleteAction;
        }
        
        typeof(GameStoreUI.<PurchaseDelayComplete>d__85).__il2cppRuntimeField_14 = R2;
    }
    private void AnimateCoins(decimal fromAmount, decimal toAmount, System.Action actionOnComplete)
    {
        GridCoinCollectAnimationInstantiator val_1;
        System.Action val_2;
        int val_3;
        int val_4;
        int val_5;
        val_1 = this.coinsAnimControl;
        val_2 = actionOnComplete;
        if(val_1 == 0)
        {
                val_2 = val_2;
        }
        
        this.coinsAnimControl.OnCompleteCallback = val_2;
        val_3 = toAmount.mid;
        val_4 = toAmount.lo;
        val_5 = toAmount.flags;
        if(this.coinsAnimControl == 0)
        {
                val_1 = val_5;
            val_4 = toAmount.lo;
            val_5 = val_1;
            val_3 = toAmount.mid;
        }
        
        this.coinsAnimControl.Play(fromValue:  new System.Decimal() {flags = fromAmount.flags, hi = fromAmount.hi, lo = fromAmount.lo, mid = fromAmount.mid}, toValue:  new System.Decimal() {flags = val_5, hi = toAmount.hi, lo = val_4, mid = val_3}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void AnimatePurchase(CurrencyCollectAnimationInstantiator animControl, int fromAmount, int toAmount, System.Action actionOnComplete, float delay = 0)
    {
        animControl.OnCompleteCallback = actionOnComplete;
        System.Collections.IEnumerator val_2 = this.StartAnimating(animControl:  animControl, fromAmount:  fromAmount, toAmount:  toAmount, delay:  delay);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -1252266144);
    }
    private System.Collections.IEnumerator StartAnimating(CurrencyCollectAnimationInstantiator animControl, int fromAmount, int toAmount, float delay)
    {
        float val_1;
        typeof(GameStoreUI.<StartAnimating>d__88).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(GameStoreUI.<StartAnimating>d__88).__il2cppRuntimeField_14 = animControl;
            typeof(GameStoreUI.<StartAnimating>d__88).__il2cppRuntimeField_18 = fromAmount;
            typeof(GameStoreUI.<StartAnimating>d__88).__il2cppRuntimeField_1C = toAmount;
        }
        else
        {
                mem[20] = animControl;
            mem[24] = fromAmount;
            mem[28] = toAmount;
        }
        
        typeof(GameStoreUI.<StartAnimating>d__88).__il2cppRuntimeField_10 = val_1;
    }
    public void SetVisible(bool visible)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1252025760);
        if(visible == true)
        {
                public static UnityEngine.CanvasGroup MethodExtensionForMonoBehaviourTransform::GetOrAddComponent<UnityEngine.CanvasGroup>(UnityEngine.GameObject gameObject) = 1065353216;
        }
        
        if(visible == false)
        {
                public static UnityEngine.CanvasGroup MethodExtensionForMonoBehaviourTransform::GetOrAddComponent<UnityEngine.CanvasGroup>(UnityEngine.GameObject gameObject) = 0;
        }
        
        this.alpha = null;
    }
    private void OnAnimFinished()
    {
        var val_6;
        System.Action val_7;
        SLCDebug.Log(logMessage:  -1251937760, colorHash:  -1255470752, isError:  false);
        this.canPurchase = true;
        this.button_back.enabled = true;
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        MainController val_2 = MainController.instance;
        if(0 != 0)
        {
                MainController val_4 = MainController.instance;
            if((0.IsChapterComplete != false) && (VIPPartyEventHandler.instance != 0))
        {
                VIPPartyEventHandler.instance.OnAnimFinished_StorePurchaseOnChapterComplete();
        }
        
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = GameStoreUI.OnRewardAnimationsComplete;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = GameStoreUI.OnRewardAnimationsComplete;
        if(val_7 == 0)
        {
                val_7 = 0;
        }
        
        val_7.Invoke();
    }
    private void HandleBackButtonClose()
    {
        this.Close();
    }
    public void Close()
    {
        DG.Tweening.TweenCallback val_13;
        var val_14;
        var val_15;
        val_13 = 6486168 + 29139619;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        if(App.game == 20)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1537803328) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_18.Show();
        }
        
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_15 = 0;
            if((-1255657504) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESRestaurantUI MonoSingleton<RestaurantRivals.RESRestaurantUI>::get_Instance().__il2cppRuntimeField_24.Show();
        }
        
            UnityEngine.Transform val_7 = this.transform;
            if(this != 0)
        {
                if(null != null)
        {
                this = 0;
        }
        
            val_15 = this;
        }
        
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  0, endValue:  null, duration:  null, snapping:  false);
            val_13 = null;
            val_13 = new DG.Tweening.TweenCallback(object:  -1251680368, method:  new IntPtr(3043261904));
            object val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        }
        
        System.Action val_11 = new System.Action(object:  -1251680368, method:  new IntPtr(3039235040));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        GameStoreManager.StoreCategoryFocus = "";
        WordPets.WPTDataParser val_12 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(this.didPurchase == true)
        {
                this.didPurchase = 1;
        }
        
        HandleStoreClose(purchased:  true, runCallbacks:  true, forceClose:  false);
    }
    public void ForceClose()
    {
        System.Action val_1 = new System.Action(object:  -1251568368, method:  new IntPtr(3039235040));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
        GameStoreManager.StoreCategoryFocus = "";
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        HandleStoreClose(purchased:  false, runCallbacks:  true, forceClose:  true);
    }
    public GameStoreUI()
    {
        this.canPurchase = true;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.storeCategories = null;
        System.Collections.Generic.Dictionary<System.String, System.Single> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Single>();
        this.normalishCategoryPositions = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.standardPackItems = null;
        this.lastScrollPosition = 1f;
    }
    private static GameStoreUI()
    {
    
    }
    private void <DisplayPurchaseSuccess>b__84_4()
    {
        this.OnAnimFinished();
        this.RefreshPackItemDisplays();
    }
    private void <DisplayPurchaseSuccess>b__84_0()
    {
        this.OnAnimFinished();
        this.RefreshPackItemDisplays();
    }
    private void <DisplayPurchaseSuccess>b__84_1()
    {
        this.OnAnimFinished();
        this.RefreshPackItemDisplays();
    }
    private void <DisplayPurchaseSuccess>b__84_2()
    {
        this.OnAnimFinished();
        this.RefreshPackItemDisplays();
    }
    private void <DisplayPurchaseSuccess>b__84_3()
    {
        this.OnAnimFinished();
        this.RefreshPackItemDisplays();
    }
    private void <DisplayPurchaseSuccess>b__84_5()
    {
        this.OnAnimFinished();
        this.RefreshPackItemDisplays();
    }
    private void <Close>b__92_0()
    {
        this.Close();
    }

}
