using UnityEngine;
public class BBLOutOfLivesPopup : FrameSkipper
{
    // Fields
    private const int LIVES_CREDITED_PER_ADVIEW = 1;
    private const int LIVES_CREDITED_PER_PURCHASE = 5;
    private UnityEngine.UI.Text headerLabel;
    private UnityEngine.UI.Button buttonClose;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private UnityEngine.GameObject lifeCountDisplay;
    private UnityEngine.UI.Text lifeCountLabel;
    private UnityEngine.UI.Text lifeTimerHeaderLabel;
    private UnityEngine.UI.Text lifeTimerValueLabel;
    private UGUINetworkedButton buttonWatchAd;
    private UnityEngine.UI.Text buttonWatchAdLifeQtyLabel;
    private UnityEngine.UI.Text buttonWatchAdLabel;
    private UnityEngine.UI.Button buttonPurchaseLives;
    private UnityEngine.UI.Text buttonPurchaseLivesQtyLabel;
    private UnityEngine.UI.Text buttonPurchaseLivesCostLabel;
    private System.Action onPopupClosed;
    private System.TimeSpan timerCooldownInterval;
    private int prevLifeCount;
    
    // Methods
    private void Start()
    {
        System.TimeSpan val_5;
        BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        var val_2 = 0 + 1404;
        System.TimeSpan val_3 = System.TimeSpan.FromMinutes(value:  null);
        this.timerCooldownInterval = val_5;
        mem[1152921511029959268] = 10;
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  2128144976, method:  new IntPtr(2128105504));
        this.buttonClose.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  2128144976, method:  new IntPtr(2128114720));
        this.buttonPurchaseLives.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  2128144976, method:  new IntPtr(2128119840));
        this.buttonWatchAd.AddListener(call:  162246656);
        NotificationCenter val_9 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  2128144976, name:  2128120864);
        this.UpdateView();
    }
    private void OnDisable()
    {
        if(this.onPopupClosed != 0)
        {
                this.onPopupClosed.Invoke();
        }
        
        this.onPopupClosed = 0;
    }
    public void Init(System.Action onCloseAction)
    {
        System.Action val_2 = this.onPopupClosed;
        System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.onPopupClosed, b:  onCloseAction);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.onPopupClosed = val_2;
    }
    private void UpdateView()
    {
        BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
        string val_2 = 284.ToString();
        string val_3 = System.String.Format(format:  2128510224, arg0:  13152256);
        string val_4 = System.String.Format(format:  2128510224, arg0:  13152256);
        BlockPuzzleMagic.BestBlocksGameEcon val_5 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        string val_6 = ToString();
        if(this.buttonPurchaseLivesCostLabel != 0)
        {
                return;
        }
    
    }
    protected override void UpdateLogic()
    {
        ulong val_6;
        long val_12;
        UnityEngine.UI.Text val_17;
        long val_18;
        BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
        if(0.IsLivesMaxed() != false)
        {
                val_17 = this.lifeTimerValueLabel;
            val_18 = "max_upper";
            string val_3 = Localization.Localize(key:  2128646960, defaultValue:  2128646880, useSingularKey:  false);
        }
        else
        {
                System.DateTime val_4 = DateTimeCheat.UtcNow;
            BestBlocksPlayer val_5 = BestBlocksPlayer.Instance;
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511030481472}, d2:  new System.DateTime() {dateData = val_6});
            System.TimeSpan val_11 = System.TimeSpan.op_Subtraction(t1:  new System.TimeSpan() {_ticks = 1152921511030481464}, t2:  new System.TimeSpan() {_ticks = this.timerCooldownInterval});
            val_18 = val_12;
            val_17 = this.lifeTimerValueLabel;
            string val_14 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_18}, formatted:  true);
        }
        
        BestBlocksPlayer val_15 = BestBlocksPlayer.Instance;
        if(this.prevLifeCount == 33453552)
        {
                return;
        }
        
        this.UpdateView();
        BestBlocksPlayer val_16 = BestBlocksPlayer.Instance;
        this.prevLifeCount = 33453552;
    }
    private void CreditLife(int amt, string source)
    {
        BBLOutOfLivesPopup val_24;
        UnityEngine.Transform val_25;
        var val_26;
        var val_27;
        val_24 = this;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                typeof(BBLOutOfLivesPopup.<>c__DisplayClass23_0).__il2cppRuntimeField_8 = val_24;
        }
        else
        {
                mem[8] = val_24;
        }
        
        typeof(BBLOutOfLivesPopup.<>c__DisplayClass23_0).__il2cppRuntimeField_C = amt;
        this.ToggleAllButtonsInteractable(isInteractable:  false);
        BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
        val_25 = 0;
        int val_3 = val_25.CreditLife(amount:  typeof(BBLOutOfLivesPopup.<>c__DisplayClass23_0).__il2cppRuntimeField_C, source:  source);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_26 = public static BlockPuzzleMagic.GameProgressManager MonoSingleton<BlockPuzzleMagic.GameProgressManager>::get_Instance();
        SaveGame();
        DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
        val_27 = 0;
        var val_24 = 0;
        if(new System.Object() != 0)
        {
                typeof(BBLOutOfLivesPopup.<>c__DisplayClass23_1).__il2cppRuntimeField_C = val_1;
        }
        else
        {
                mem[12] = val_1;
        }
        
        val_26 = val_24;
        typeof(BBLOutOfLivesPopup.<>c__DisplayClass23_1).__il2cppRuntimeField_8 = val_24;
        float val_7 = 0f * 0.15f;
        UnityEngine.Transform val_8 = this.lifeCountDisplay.transform;
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  0f, y:  null, z:  null);
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.lifeCountDisplay, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  0f);
        object val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.lifeCountDisplay, ease:  1);
        val_27 = val_27;
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  0f, t:  val_7);
        DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  275079168, method:  new IntPtr(2128783632));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.InsertCallback(s:  0, atPosition:  0f, callback:  val_7);
        val_24 = val_26;
        UnityEngine.Transform val_15 = this.lifeCountDisplay.transform;
        val_25 = this.lifeCountDisplay;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_25, endValue:  new UnityEngine.Vector3(), duration:  val_16.x);
        object val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_25, ease:  1);
        float val_19 = val_7 + 0.01f;
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_19, t:  val_19);
        val_24 = val_24 + 1;
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_19);
        DG.Tweening.TweenCallback val_22 = new DG.Tweening.TweenCallback(object:  2128812752, method:  new IntPtr(2128105504));
        object val_23 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private void ToggleAllButtonsInteractable(bool isInteractable)
    {
        this.buttonPurchaseLives.interactable = isInteractable;
        this.buttonWatchAd.interactable = isInteractable;
        this.buttonClose.interactable = isInteractable;
    }
    private void CloseWindow()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  2129073616, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnPurchaseClicked()
    {
        var val_12;
        System.Action val_14;
        Player val_1 = App.Player;
        var val_2 = 0 + 64;
        BlockPuzzleMagic.BestBlocksGameEcon val_3 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = mem[(0 + 64) + (0)], lo = mem[(0 + 64) + (4)], mid = mem[(0 + 64) + (8)]}, d2:  new System.Decimal() {flags = 1314, mid = 18})) != false)
        {
                GameBehavior val_5 = App.getBehavior;
            val_12 = null;
            val_12 = null;
            val_14 = BBLOutOfLivesPopup.<>c.<>9__26_0;
            if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Action(object:  BBLOutOfLivesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2129162640));
            BBLOutOfLivesPopup.<>c.<>9__26_0 = val_14;
        }
        
            0.Init(outOfCredits:  true, onCloseAction:  7454720);
            UnityEngine.GameObject val_8 = this.gameObject;
            SLCWindow.CloseWindow(window:  2129187760, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
        }
        
        BlockPuzzleMagic.BestBlocksGameEcon val_9 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        var val_10 = 0 + 1408;
        bool val_11 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = mem[(0 + 1408) + (0)], hi = mem[(0 + 1408) + (4)], lo = mem[(0 + 1408) + (8)], mid = mem[(0 + 1408) + (12)]}, source:  "Max Lives", externalParams:  0, animated:  false);
        this.CreditLife(amt:  5, source:  null);
        Player val_12 = App.Player;
        mem[1152921511031002068].Set(instantValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256});
    }
    private void OnWatchAdClicked()
    {
        var val_10;
        System.Func<System.Boolean> val_12;
        var val_13;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowIncentivizedVideo(tag:  0, adCapExempt:  false)) != false)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        string val_5 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_later_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_10 = null;
        val_10 = null;
        val_12 = BBLOutOfLivesPopup.<>c.<>9__27_0;
        if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Func<System.Boolean>(object:  BBLOutOfLivesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2129281664));
            BBLOutOfLivesPopup.<>c.<>9__27_0 = val_12;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_12;
        val_13 = null;
        val_13 = null;
        0.SetupMessage(titleTxt:  2129276784, messageTxt:  2129276992, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_9 = this.gameObject;
        SLCWindow.CloseWindow(window:  2129306784, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnVideoResponse(Notification notif)
    {
        string val_1 = notif.data.ToString();
        if((System.Boolean.Parse(value:  notif.data)) == false)
        {
                return;
        }
        
        this.CreditLife(amt:  1, source:  2129402976);
    }
    public BBLOutOfLivesPopup()
    {
    
    }

}
