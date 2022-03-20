using UnityEngine;
public class TheLibraryAcquireBooksPopup : FrameSkipper
{
    // Fields
    private LibraryBookDisplay_AcquireBookPack prefab_bookpack_display;
    private UnityEngine.UI.ScrollRect scrollRect;
    private UnityEngine.Transform xfm_content_group;
    private UnityEngine.Transform xfm_content_packs_group;
    private UnityEngine.UI.Button button_close;
    private GoldenCurrencyCollectAnimationInstantiator gold_currency_instantiator;
    private UnityEngine.UI.Text text_time;
    private UnityEngine.CanvasGroup canvas_not_enough_apples;
    private UnityEngine.UI.Button button_info;
    private UnityEngine.GameObject gems_stat_view;
    private UnityEngine.UI.Button button_gems_store;
    private System.Collections.Generic.List<LibraryBookDisplay_AcquireBooks> bookInstances;
    private LibraryBookDisplay_AcquireBookPack newPackDisplay;
    private bool showingNotEnoughApples;
    private LibraryBookDisplay_AcquireBooks _prefab_book_display;
    
    // Properties
    private LibraryBookDisplay_AcquireBooks prefab_book_display { get; }
    
    // Methods
    private LibraryBookDisplay_AcquireBooks get_prefab_book_display()
    {
        if(this._prefab_book_display != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1688466064);
        this._prefab_book_display = "TheLibrary";
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1688290032, method:  new IntPtr(2606633808));
        this.button_close.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1688290032, method:  new IntPtr(2606643024));
        this.button_info.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1688290032, method:  new IntPtr(2606652240));
        this.button_gems_store.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        System.Collections.Generic.List<BookInfo> val_1 = TheLibraryLogic.PurchasableBooks;
        this.Setup(bookInfos:  0);
    }
    public void Setup(System.Collections.Generic.List<BookInfo> bookInfos)
    {
        UnityEngine.GameObject val_1 = this.xfm_content_group.gameObject;
        this.xfm_content_group.SetActive(value:  false);
        this.RefreshItems(bookInfos:  bookInfos);
        this.Invoke(methodName:  -1688057264, time:  null);
        GameBehavior val_2 = App.getBehavior;
        this.gems_stat_view.SetActive(value:  false);
    }
    private void ShowScroll()
    {
        UnityEngine.GameObject val_1 = this.xfm_content_group.gameObject;
        this.xfm_content_group.SetActive(value:  true);
        MonoExtensions.ScrollToTop(scrollRect:  this.scrollRect);
    }
    private void RefreshItems(System.Collections.Generic.List<BookInfo> bookInfos)
    {
        LibraryBookDisplay_AcquireBookPack val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        float val_22;
        bool val_23;
        if(this.newPackDisplay == 0)
        {
                object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefab_bookpack_display, parent:  this.xfm_content_packs_group);
            val_17 = this.prefab_bookpack_display;
            this.newPackDisplay = this.prefab_bookpack_display;
        }
        else
        {
                val_17 = this.newPackDisplay;
        }
        
        string val_3 = Localization.Localize(key:  -1687778800, defaultValue:  -1687778896, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1687778688, defaultValue:  -1687778592, useSingularKey:  false);
        val_18 = null;
        val_18 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1687718624, method:  new IntPtr(2607188832));
        val_17.Setup(bookpack:  -1687778800, packdescription:  -1687778688, packcost:  TheLibraryLogic.BookPackGemCost, packSize:  TheLibraryLogic.BookPackBookCount, onBookClicked:  null);
        val_19 = this;
        val_20 = mem[bookInfos + 12];
        val_20 = bookInfos + 12;
        if(this.bookInstances < val_20)
        {
                if(this.bookInstances == 0)
        {
                val_20 = mem[bookInfos + 12];
            val_20 = bookInfos + 12;
        }
        
            if(null < val_20)
        {
                do
        {
            LibraryBookDisplay_AcquireBooks val_6 = this.prefab_book_display;
            object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  -1687718624, parent:  this.xfm_content_group);
            val_17 = this.bookInstances;
            val_17.Add(item:  -1687718624);
        }
        while(1152921504614248449 < (bookInfos + 12));
        
        }
        
        }
        
        val_21 = 4;
        val_22 = 1152921504906846208;
        goto label_19;
        label_45:
        if((bookInfos + 12) <= 1152921504614248449)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_8 = 2621443.gameObject;
        val_17 = mem[bookInfos + 12];
        val_17 = bookInfos + 12;
        if(1152921504614248449 < val_17)
        {
                0 = 1;
        }
        
        2621443.SetActive(value:  true);
        if(1152921504614248449 < (bookInfos + 12))
        {
                System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_9 = TheLibraryLogic.PlayerBooksByCollection;
            if((bookInfos + 12) <= 1152921504614248449)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_23 = 1;
            if((0.ContainsKey(key:  bookInfos + 8 + 16 + 24)) != false)
        {
                System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_11 = TheLibraryLogic.PlayerBooksByCollection;
            if((bookInfos + 12) <= 1152921504614248449)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_12 = 0.Item[bookInfos + 8 + 16 + 24];
            if((bookInfos + 12) <= 1152921504614248449)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_23 = (TheLibraryLogic.ListContainsBook(bookInfos:  0, bookToCheck:  bookInfos + 8 + 16)) ^ 1;
        }
        
            if((bookInfos + 12) <= 1152921504614248449)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            bool val_14 = TheLibraryLogic.BookAlreadyPurchased(bookInfo:  bookInfos + 8 + 16);
            if(val_14 <= 1152921504614248449)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_17 = val_19;
            if((bookInfos + 12) <= 1152921504614248449)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            System.Action<System.Threading.Tasks.Task, System.Object> val_15 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1687718624, method:  new IntPtr(2607217504));
            val_19 = val_17;
            System.Action<System.Threading.Tasks.Task, System.Object> val_16 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -1687718624, method:  new IntPtr(2607219552));
            2621443.Setup(info:  bookInfos + 8 + 16, isNew:  val_23, isPurchased:  val_14, onBookClicked:  null, onBookAlreadyPurchasedClicked:  null);
            val_22 = 1152921504906846208;
        }
        
        val_21 = 5;
        label_19:
        if((val_21 - 4) < 2621443)
        {
            goto label_45;
        }
    
    }
    private void OnBookDisplayClicked(BookInfo info, LibraryBookDisplay_AcquireBooks display)
    {
        if((TheLibraryLogic.BuyBook(bookToBuy:  info)) != false)
        {
                System.Collections.Generic.List<BookInfo> val_2 = TheLibraryLogic.PurchasableBooks;
            this.RefreshItems(bookInfos:  0);
            return;
        }
        
        if(this.showingNotEnoughApples == true)
        {
                return;
        }
        
        mem2[0] = 1;
        UnityEngine.GameObject val_3 = R4 + 56.gameObject;
        R4 + 56.SetActive(value:  true);
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R4 + 56, endValue:  null, duration:  null);
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R4 + 56, endValue:  null, duration:  null);
        object val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  R4 + 56, delay:  null);
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  R4, method:  new IntPtr(2607394016));
        mem2[0] = null;
    }
    private void OnBookPackDisplayClicked(LibraryBookDisplay_AcquireBookPack display)
    {
        System.Action val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.List<BookInfo> val_1 = TheLibraryLogic.BuyBookPack(packSize:  display._packSize);
        if(display._packSize == 0)
        {
            goto label_4;
        }
        
        if((display._packSize + 12) == 0)
        {
            goto label_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_11 = public static LibraryWindowManager MonoSingleton<LibraryWindowManager>::get_Instance();
        Setup(packPurchased:  display._packSize);
        goto label_10;
        label_4:
        UnityEngine.Debug.LogError(message:  -1687446944, context:  -1687416400);
        return;
        label_5:
        if(display.GetInstanceID() == this.newPackDisplay.GetInstanceID())
        {
                string val_6 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
            GameStoreManager.StoreCategoryFocus = "gems_upper";
        }
        
        var val_11 = 27290241;
        val_11 = 8335820 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        PurchaseProxy.currentPurchasePoint = 76;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
        val_13 = null;
        val_13 = null;
        val_11 = TheLibraryAcquireBooksPopup.<>c.<>9__23_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Action(object:  TheLibraryAcquireBooksPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2607525872));
            TheLibraryAcquireBooksPopup.<>c.<>9__23_0 = val_11;
        }
        
        Init(outOfCredits:  true, onCloseAction:  7454720);
        label_10:
        UnityEngine.GameObject val_10 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1687416400, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnPurchasedBookDisplayClicked(BookInfo info, LibraryBookDisplay_AcquireBooks display)
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_1 = TheLibraryLogic.PlayerBooksByCollection;
        if((0.ContainsKey(key:  info.Collection)) == false)
        {
                return;
        }
        
        TheLibraryUI.ShowTheLibraryCollection(collectionName:  info.Collection, trackLibraryAccessed:  false);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1687279824, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_GemsStore()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        string val_2 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        ShowStore(categoryFocus:  -1687442544, storeCloseCallback:  0);
    }
    protected override void UpdateLogic()
    {
        long val_7;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        this.UpdateLogic();
        System.DateTime val_1 = TheLibraryLogic.LastPurchasableRefreshDate;
        System.DateTime val_4 = AddHours(value:  null);
        System.DateTime val_5 = DateTimeCheat.UtcNow;
        System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511509735240}, d2:  new System.DateTime());
        val_22 = null;
        val_22 = null;
        if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_7}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                double val_11 = System.Math.Truncate(d:  val_7.TotalHours);
            string val_12 = 1.28823172845244E-231.ToString(format:  -1827641632);
            val_24;
            string val_14 = val_7.Minutes.ToString(format:  -1827641632);
            string val_16 = val_7.Seconds.ToString(format:  -1827641632);
            val_26 = ;
            val_27 = val_24;
            val_28 = ;
            val_29 = "{0}:{1}:{2}";
        }
        else
        {
                val_23 = "00";
            string val_17 = 0.ToString(format:  -1827641632);
            val_24 = ;
            string val_18 = 0.ToString(format:  -1827641632);
            val_25 = ;
            string val_19 = 0.ToString(format:  -1827641632);
            val_26 = ;
            val_27 = val_24;
            val_28 = val_25;
            val_29 = "{0}:{1}:{2}";
        }
        
        string val_20 = System.String.Format(format:  -1687058320, arg0:  -1687046292, arg1:  -1687046292, arg2:  -1687046292);
        if(this.text_time != 0)
        {
                return;
        }
    
    }
    public TheLibraryAcquireBooksPopup()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.bookInstances = null;
    }
    private void <Awake>b__17_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1686805104, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void <Awake>b__17_1()
    {
        var val_6;
        System.Action val_8;
        GameBehavior val_1 = App.getBehavior;
        object val_3 = 0.GetComponent<System.Object>();
        val_6 = null;
        val_6 = null;
        val_8 = TheLibraryAcquireBooksPopup.<>c.<>9__17_2;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  TheLibraryAcquireBooksPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2608251216));
            TheLibraryAcquireBooksPopup.<>c.<>9__17_2 = val_8;
        }
        
        mem[20] = val_8;
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1686691056, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void <OnBookDisplayClicked>b__22_0()
    {
        UnityEngine.GameObject val_1 = this.canvas_not_enough_apples.gameObject;
        this.canvas_not_enough_apples.SetActive(value:  false);
        this.showingNotEnoughApples = false;
    }

}
