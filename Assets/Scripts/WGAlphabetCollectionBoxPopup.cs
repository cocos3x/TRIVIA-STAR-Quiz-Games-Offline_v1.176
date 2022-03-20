using UnityEngine;
public class WGAlphabetCollectionBoxPopup : MonoBehaviour
{
    // Fields
    private AlphabetBoxItem alphabetBoxItemPrefab;
    private UnityEngine.GameObject greenTileGlowObject;
    private UnityEngine.RectTransform[] boxItemsParentRows;
    private int boxItemsPerRow;
    private AlphabetWordRegion wordRegion;
    private UnityEngine.GameObject coinRewardGroup;
    private UnityEngine.UI.Text rewardAmount;
    private UnityEngine.UI.Text redrawCost;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button redrawButton;
    private UnityEngine.GameObject ftuxTooltip;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private UnityEngine.UI.Button skipButton;
    private System.Collections.Generic.List<AlphabetBoxItem> alphabetBoxItems;
    private System.Collections.Generic.List<WGAlphabetCollectionBoxPopup.Word_Index> currentCollectedLetters;
    private decimal currentCollectionRewardAmount;
    private System.Collections.Generic.List<string> CurrentCollectionBoxLetters;
    private bool hasDrawn;
    private bool skip;
    private readonly UnityEngine.Color[] rarityColors;
    private readonly UnityEngine.Color duplicateColor;
    private bool setupForPurchase;
    private bool setupForKeyToRiches;
    
    // Properties
    private AlphabetBoxItem alphabetBoxItemPrefabLoaded { get; }
    private UnityEngine.GameObject alphabetCoinParticle { get; }
    
    // Methods
    private AlphabetBoxItem get_alphabetBoxItemPrefabLoaded()
    {
        if(this.alphabetBoxItemPrefab != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1567762720);
        this.alphabetBoxItemPrefab = "AlphabetBoxItem";
    }
    private UnityEngine.GameObject get_alphabetCoinParticle()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1752778768, prefabName:  -1567638320);
    }
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1567474576, method:  new IntPtr(2727449264));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1567474576, method:  new IntPtr(2727458480));
        this.redrawButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1567474576, method:  new IntPtr(2727467696));
        this.skipButton.m_OnClick.AddListener(call:  162246656);
        System.Collections.IEnumerator val_4 = this.SetupUI();
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -1567474576);
    }
    private void onClick_SkipButton()
    {
        this.skip = true;
    }
    public void SetupUIForPurchase(System.Collections.Generic.List<string> purchasedTiles)
    {
        this.setupForPurchase = true;
        UnityEngine.GameObject val_1 = this.redrawButton.gameObject;
        this.redrawButton.SetActive(value:  false);
        this.CurrentCollectionBoxLetters = purchasedTiles;
    }
    public void SetupUIForKeyToRiches(System.Collections.Generic.List<string> rewardedTiles)
    {
        this.setupForKeyToRiches = true;
        UnityEngine.GameObject val_1 = this.redrawButton.gameObject;
        this.redrawButton.SetActive(value:  false);
        this.CurrentCollectionBoxLetters = rewardedTiles;
    }
    private System.Collections.IEnumerator SetupUI()
    {
        object val_1 = new System.Object();
        typeof(WGAlphabetCollectionBoxPopup.<SetupUI>d__32).__il2cppRuntimeField_8 = 0;
        typeof(WGAlphabetCollectionBoxPopup.<SetupUI>d__32).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator ShowTooltipBeforeAnimating()
    {
        object val_1 = new System.Object();
        typeof(WGAlphabetCollectionBoxPopup.<ShowTooltipBeforeAnimating>d__33).__il2cppRuntimeField_8 = 0;
        typeof(WGAlphabetCollectionBoxPopup.<ShowTooltipBeforeAnimating>d__33).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator AnimateCollecting()
    {
        object val_1 = new System.Object();
        typeof(WGAlphabetCollectionBoxPopup.<AnimateCollecting>d__34).__il2cppRuntimeField_8 = 0;
        typeof(WGAlphabetCollectionBoxPopup.<AnimateCollecting>d__34).__il2cppRuntimeField_10 = this;
    }
    private void onClick_RedrawButton()
    {
        int val_3;
        WGAlphabetCollectionBoxPopup val_22;
        int val_23;
        var val_24;
        WGAlphabetCollectionBoxPopup val_25;
        var val_26;
        var val_27;
        var val_28;
        System.Action val_30;
        var val_31;
        var val_32;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_2 = GetRedrawCost;
        Player val_4 = App.Player;
        var val_5 = 0 + 60;
        val_24 = 256;
        val_23 = mem[(0 + 60) + (0)];
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_23, hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = 256}, d2:  new System.Decimal() {mid = val_3})) != false)
        {
                var val_23 = 27198545;
            val_25 = this;
            val_23 = 8427516 + val_23;
            if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
            val_26 = null;
            val_26 = null;
            PurchaseProxy.currentPurchasePoint = 50;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  true);
            val_27 = 1152921504914407424;
            val_28 = null;
            val_28 = null;
            val_30 = WGAlphabetCollectionBoxPopup.<>c.<>9__35_0;
            if(val_30 == 0)
        {
                val_30 = null;
            val_30 = new System.Action(object:  WGAlphabetCollectionBoxPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2728310064));
            WGAlphabetCollectionBoxPopup.<>c.<>9__35_0 = val_30;
        }
        
            Init(outOfCredits:  true, onCloseAction:  7454720);
            UnityEngine.GameObject val_10 = this.gameObject;
            SLCWindow.CloseWindow(window:  -1566631072, setDestroyOnDisableState:  true, dontDestroyOnDisable:  true);
            return;
        }
        
        bool val_11 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = R7, hi = SB, lo = SL, mid = val_3}, source:  "Alphabet Tile Redraw", externalParams:  0, animated:  false);
        val_22 = this;
        val_25 = mem[1152921511630150552];
        Player val_12 = App.Player;
        val_25.Set(instantValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256});
        if(mem[1152921511630150613] == false)
        {
            goto label_29;
        }
        
        val_24 = 1152921504901095424;
        val_27 = 1152921511096081520;
        val_31 = KeyToRichesEventHandler._Instance;
        System.Collections.Generic.List<System.String> val_13 = val_31.RerollLetters();
        goto label_32;
        label_29:
        if(mem[1152921511630150612] == false)
        {
            goto label_33;
        }
        
        val_24 = 1152921504901095424;
        val_27 = 1152921511096081520;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_31 = public static LimitedTimeBundlesManager MonoSingleton<LimitedTimeBundlesManager>::get_Instance();
        System.Collections.Generic.List<System.String> val_15 = RerollLettersForLastBundlePurchase();
        label_32:
        mem[1152921511630150584] = val_31;
        label_45:
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(val_27 != 0)
        {
                val_32 = LifetimeRedrawsUsed;
        }
        else
        {
                val_32 = LifetimeRedrawsUsed;
        }
        
        LifetimeRedrawsUsed = val_32 + 1;
        System.Collections.IEnumerator val_20 = this.SetupUI();
        UnityEngine.Coroutine val_21 = this.StartCoroutine(routine:  -1566631072);
        return;
        label_33:
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ClearAndFillCollectionBox(tileCount:  mem[1152921511630150564] + 12);
        goto label_45;
    }
    private void SaveCollection()
    {
        int val_5;
        if(this.setupForPurchase == false)
        {
                this.setupForPurchase = this.setupForKeyToRiches;
            goto label_1;
        }
        
        label_18:
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CollectFTUXBox();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_10:
        if(0.MoveNext() == false)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CollectTileFromBox(word:  null, letterIndex:  val_5);
        goto label_10;
        label_6:
        0.Dispose();
        Player val_7 = App.Player;
        0.SaveState();
        return;
        label_1:
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_9 = GetCurrentCollectionBox;
        Clear();
        goto label_18;
    }
    private void onClick_ContinueButton()
    {
        this.SaveCollection();
        if(this.setupForKeyToRiches == false)
        {
                this.setupForKeyToRiches = this.setupForPurchase;
            goto label_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsCurrentCollectionComplete() != false)
        {
                GameBehavior val_3 = App.getBehavior;
            if(0 != 0)
        {
            goto label_10;
        }
        
        }
        else
        {
                label_5:
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = ShowUGUIMonolith<System.Object>(showNext:  true);
        }
        
        label_10:
        UnityEngine.GameObject val_7 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1566394784, setDestroyOnDisableState:  true, dontDestroyOnDisable:  false);
    }
    public WGAlphabetCollectionBoxPopup()
    {
        this.boxItemsPerRow = 5;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.alphabetBoxItems = null;
        System.Collections.Generic.List<Word_Index> val_2 = new System.Collections.Generic.List<Word_Index>();
        this.currentCollectedLetters = null;
        UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        UnityEngine.Color val_4 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        UnityEngine.Color val_5 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        UnityEngine.Color val_6 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        this.rarityColors = null;
        UnityEngine.Color val_7 = new UnityEngine.Color(r:  null, g:  null, b:  null);
    }

}
