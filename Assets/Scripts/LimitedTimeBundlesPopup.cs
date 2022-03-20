using UnityEngine;
public class LimitedTimeBundlesPopup : MonoBehaviour
{
    // Fields
    private LimitedTimeBundlesHeader bundles_header;
    private UnityEngine.Transform xfm_pack_container;
    private LimitedTimeBundlesPackDisplayManager pack_display_manager;
    private UnityEngine.UI.Button button_close;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private WADPetFoodAnimationInstantiator foodAnimControl;
    private CurrencyCollectAnimationInstantiator goldenCurrencyAnimControl;
    private CurrencyCollectAnimationInstantiator gemCurrencyAnimControl;
    private DiceRollAnimationInstantiator diceAnimControl;
    public System.Action OnAnimationsComplete;
    
    // Methods
    private void Start()
    {
        ulong val_17;
        var val_19;
        System.Delegate val_20;
        var val_21;
        System.Action<twelvegigs.storage.JsonDictionary> val_22;
        System.Delegate val_23;
        var val_24;
        var val_25;
        val_19 = null;
        val_19 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1157040352, method:  new IntPtr(3137879392));
        val_20 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_20, b:  7401472);
        val_21 = null;
        val_22 = null;
        if(val_20 == 0)
        {
            goto label_3;
        }
        
        if(null == val_22)
        {
            goto label_4;
        }
        
        val_22 = null;
        val_21 = 1152921504898486364;
        label_3:
        val_20 = 0;
        label_4:
        PurchasesHandler.OnPurchaseCompleted = val_20;
        val_22 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1157040352, method:  new IntPtr(3137880416));
        val_23 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_23, b:  7401472);
        if(val_23 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_23 = 0;
        label_6:
        PurchasesHandler.OnPurchaseFailure = val_23;
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1157040352, method:  new IntPtr(3137889632));
        this.button_close.m_OnClick.AddListener(call:  162246656);
        this.pack_display_manager.CreatePackItems(packItemContainer:  this.xfm_pack_container, popupContainer:  -1157040352);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        LimitedTimeBundlesStatus val_7 = Status;
        public static LimitedTimeBundlesManager MonoSingleton<LimitedTimeBundlesManager>::get_Instance().__il2cppRuntimeField_10 = 0;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        LimitedTimeBundlesStatus val_9 = Status;
        if((public static LimitedTimeBundlesManager MonoSingleton<LimitedTimeBundlesManager>::get_Instance()) != 0)
        {
                val_24 = public static LimitedTimeBundlesManager MonoSingleton<LimitedTimeBundlesManager>::get_Instance();
        }
        else
        {
                val_24 = 20;
            val_25 = 1;
        }
        
        mem[20] = 2;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        LimitedTimeBundlesStatus val_11 = Status;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_14 = GetHighestExtraDisplay().ToString();
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_16 = GetCurrentOfferEndTime();
        this.bundles_header.Setup(freeAmount:  -1157052388, endTime:  new System.DateTime() {dateData = val_17});
    }
    private void OnEnable()
    {
        var val_1;
        var val_1 = 26194409;
        val_1 = 9431652 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        PurchaseProxy.currentPurchasePoint = 75;
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
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1156795872, method:  new IntPtr(3137879392));
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
        val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1156795872, method:  new IntPtr(3137880416));
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
    private void PurchasesHandler_OnPurchaseCompleted(PurchaseModel obj)
    {
        if((obj.ContainsInstruction(instruction:  2)) == true)
        {
                return;
        }
        
        R5.DisplayPurchaseSuccess(purchase:  R4);
    }
    private void PurchasesHandler_OnPurchaseFailure(PurchaseModel obj)
    {
        var val_9;
        System.Func<System.Boolean> val_11;
        var val_12;
        if((obj.ContainsInstruction(instruction:  2)) != false)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        string val_4 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_5 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_6 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
        val_9 = null;
        val_9 = null;
        val_11 = LimitedTimeBundlesPopup.<>c.<>9__14_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Func<System.Boolean>(object:  LimitedTimeBundlesPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3138383712));
            LimitedTimeBundlesPopup.<>c.<>9__14_0 = val_11;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_11;
        val_12 = null;
        val_12 = null;
        0.SetupMessage(titleTxt:  -1349324784, messageTxt:  -1349324672, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1156558560, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void DisplayPurchaseSuccess(PurchaseModel purchase)
    {
        int val_13;
        int val_42;
        int val_43;
        int val_44;
        int val_45;
        LimitedTimeBundlesPopup val_88;
        var val_89;
        float val_90;
        float val_91;
        var val_96;
        decimal val_98;
        int val_99;
        val_88 = this;
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeSelf == false)
        {
                return;
        }
        
        val_89 = 0;
        decimal val_3 = Credits;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                decimal val_5 = Gems;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
                1f = 1.5f;
        }
        
            decimal val_7 = GoldenCurrency;
            val_90 = 0.5f;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
                1f = 2f;
        }
        
            Player val_9 = App.Player;
            decimal val_10 = Credits;
            decimal val_11 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1156449416, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            Player val_12 = App.Player;
            this.AnimateCoins(fromAmount:  new System.Decimal() {mid = val_13}, toAmount:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, actionOnComplete:  0);
            System.Collections.IEnumerator val_15 = new System.Action(object:  -1156437344, method:  new IntPtr(3138504928)).CollectCoinsDelayComplete(waitTime:  val_90, onCompleteAction:  2f);
            UnityEngine.Coroutine val_16 = val_88.StartCoroutine(routine:  new System.Action(object:  -1156437344, method:  new IntPtr(3138504928)) = new System.Action(object:  -1156437344, method:  new IntPtr(3138504928)));
            val_89 = 1;
        }
        
        decimal val_17 = PetsFood;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                if(val_89 != 0)
        {
                Player val_20 = App.Player;
            decimal val_21 = PetsFood;
            Player val_23 = App.Player;
            int val_24 = 1 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
        }
        else
        {
                Player val_25 = App.Player;
            decimal val_26 = PetsFood;
            Player val_28 = App.Player;
            System.Action val_29 = new System.Action(object:  -1156437344, method:  new IntPtr(3138504928));
        }
        
            this.AnimateFood(fromAmount:  1 - (System.Decimal.op_Explicit(value:  new System.Decimal())), toAmount:  1, actionOnComplete:  7454720);
            val_89 = 1;
        }
        
        decimal val_31 = Gems;
        val_91 = 0f;
        if(((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false) && (mem[1152921512040344264] != 0))
        {
                if(val_89 != 0)
        {
                Player val_35 = App.Player;
            decimal val_36 = Gems;
            int val_38 = 0 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            decimal val_39 = System.Decimal.op_Implicit(value:  -1156449416);
            Player val_40 = App.Player;
            decimal val_41 = System.Decimal.op_Implicit(value:  -1156449432);
        }
        else
        {
                Player val_46 = App.Player;
            decimal val_47 = Gems;
            int val_49 = 0 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            decimal val_50 = System.Decimal.op_Implicit(value:  -1156449416);
            Player val_51 = App.Player;
            decimal val_52 = System.Decimal.op_Implicit(value:  -1156449432);
            System.Action val_53 = new System.Action(object:  -1156437344, method:  new IntPtr(3138504928));
        }
        
            this.AnimateGems(fromAmount:  new System.Decimal() {mid = val_13}, toAmount:  new System.Decimal() {flags = val_42, hi = val_43, lo = val_44, mid = val_45}, delay:  val_90, actionOnComplete:  1056964608);
            val_91 = 0.5f;
            val_89 = 1;
        }
        
        decimal val_54 = GoldenCurrency;
        if(((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false) && (mem[1152921512040344260] != 0))
        {
                val_90 = 0.5f;
            val_91 = 1f;
            if(val_89 != 0)
        {
                Player val_58 = App.Player;
            decimal val_59 = GoldenCurrency;
            int val_61 = 4 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            decimal val_62 = System.Decimal.op_Implicit(value:  -1156449416);
            Player val_63 = App.Player;
            decimal val_64 = System.Decimal.op_Implicit(value:  -1156449432);
        }
        else
        {
                Player val_65 = App.Player;
            decimal val_66 = GoldenCurrency;
            int val_68 = 4 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            decimal val_69 = System.Decimal.op_Implicit(value:  -1156449416);
            Player val_70 = App.Player;
            decimal val_71 = System.Decimal.op_Implicit(value:  -1156449432);
            System.Action val_72 = new System.Action(object:  -1156437344, method:  new IntPtr(3138504928));
        }
        
            this.AnimateGoldenCurrency(fromAmount:  new System.Decimal() {mid = val_13}, toAmount:  new System.Decimal() {flags = val_42, hi = val_43, lo = val_44, mid = val_45}, delay:  val_90, actionOnComplete:  val_91);
            val_89 = 1;
        }
        
        val_88 = 0;
        decimal val_73 = DiceRolls;
        val_96 = null;
        val_96 = null;
        val_98 = System.Decimal.Zero;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_98, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
                return;
        }
        
        if(mem[1152921512040344268] == 0)
        {
                return;
        }
        
        int val_76 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetDiceBalance();
        if(val_89 != 0)
        {
                val_88 = 0;
            decimal val_77 = DiceRolls;
            int val_79 = val_76 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
            decimal val_80 = System.Decimal.op_Implicit(value:  -1156449416);
            decimal val_81 = System.Decimal.op_Implicit(value:  -1156449432);
            val_99 = val_42;
            val_98 = val_43;
            this.AnimateDice(fromAmount:  new System.Decimal() {mid = val_13}, toAmount:  new System.Decimal() {flags = val_99, hi = val_98, lo = val_44, mid = val_45}, delay:  val_90, actionOnComplete:  1.5f);
            return;
        }
        
        decimal val_82 = DiceRolls;
        int val_84 = val_76 - (System.Decimal.op_Explicit(value:  new System.Decimal()));
        decimal val_85 = System.Decimal.op_Implicit(value:  -1156449416);
        decimal val_86 = System.Decimal.op_Implicit(value:  -1156449432);
        System.Action val_87 = new System.Action(object:  -1156437344, method:  new IntPtr(3138504928));
        val_99 = val_42;
        val_98 = val_43;
        this.AnimateGoldenCurrency(fromAmount:  new System.Decimal() {mid = val_13}, toAmount:  new System.Decimal() {flags = val_99, hi = val_98, lo = val_44, mid = val_45}, delay:  val_90, actionOnComplete:  1.5f);
    }
    private void OnAnimFinished()
    {
        if(this.OnAnimationsComplete != 0)
        {
                this.OnAnimationsComplete.Invoke();
        }
        
        this.OnAnimationsComplete = 0;
    }
    private void AnimateCoins(decimal fromAmount, decimal toAmount, System.Action actionOnComplete)
    {
        GridCoinCollectAnimationInstantiator val_1;
        int val_2;
        int val_3;
        int val_4;
        int val_5;
        val_1 = this.coinsAnimControl;
        if(val_1 == 0)
        {
                val_2 = fromAmount.hi;
        }
        
        val_3 = toAmount.mid;
        this.coinsAnimControl.OnCompleteCallback = 0;
        val_4 = toAmount.lo;
        val_5 = toAmount.hi;
        if(this.coinsAnimControl == 0)
        {
                val_1 = val_2;
            val_5 = toAmount.hi;
            val_2 = val_1;
            val_4 = toAmount.lo;
            val_3 = toAmount.mid;
        }
        
        this.coinsAnimControl.Play(fromValue:  new System.Decimal() {flags = fromAmount.flags, hi = val_2, lo = fromAmount.lo, mid = fromAmount.mid}, toValue:  new System.Decimal() {flags = toAmount.flags, hi = val_5, lo = val_4, mid = val_3}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void AnimateFood(int fromAmount, int toAmount, System.Action actionOnComplete)
    {
        mem2[0] = actionOnComplete;
        System.Collections.IEnumerator val_1 = this.StartFoodAnim(fromAmount:  fromAmount, toAmount:  toAmount);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1156056288);
    }
    private void AnimateGems(decimal fromAmount, decimal toAmount, float delay, System.Action actionOnComplete)
    {
        System.Action val_1;
        this.gemCurrencyAnimControl.OnCompleteCallback = val_1;
        int val_3 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = toAmount.flags, hi = toAmount.hi, lo = toAmount.lo, mid = toAmount.mid});
        System.Collections.IEnumerator val_4 = val_3.PlayCollectAnimWithDelay(anim:  this.gemCurrencyAnimControl, fromAmount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = fromAmount.flags, hi = fromAmount.hi, lo = fromAmount.lo, mid = fromAmount.mid}), toAmount:  val_3, delay:  delay);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  val_3);
    }
    private void AnimateGoldenCurrency(decimal fromAmount, decimal toAmount, float delay, System.Action actionOnComplete)
    {
        System.Action val_1;
        this.goldenCurrencyAnimControl.OnCompleteCallback = val_1;
        int val_3 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = toAmount.flags, hi = toAmount.hi, lo = toAmount.lo, mid = toAmount.mid});
        System.Collections.IEnumerator val_4 = val_3.PlayCollectAnimWithDelay(anim:  this.goldenCurrencyAnimControl, fromAmount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = fromAmount.flags, hi = fromAmount.hi, lo = fromAmount.lo, mid = fromAmount.mid}), toAmount:  val_3, delay:  delay);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  val_3);
    }
    private void AnimateDice(decimal fromAmount, decimal toAmount, float delay, System.Action actionOnComplete)
    {
        var val_1;
        mem2[0] = val_1;
        int val_3 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = toAmount.flags, hi = toAmount.hi, lo = toAmount.lo, mid = toAmount.mid});
        System.Collections.IEnumerator val_4 = val_3.PlayCollectAnimWithDelay(anim:  this.diceAnimControl, fromAmount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = fromAmount.flags, hi = fromAmount.hi, lo = fromAmount.lo, mid = fromAmount.mid}), toAmount:  val_3, delay:  delay);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  val_3);
    }
    private System.Collections.IEnumerator StartFoodAnim(int fromAmount, int toAmount)
    {
        typeof(LimitedTimeBundlesPopup.<StartFoodAnim>d__22).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(LimitedTimeBundlesPopup.<StartFoodAnim>d__22).__il2cppRuntimeField_10 = this;
            typeof(LimitedTimeBundlesPopup.<StartFoodAnim>d__22).__il2cppRuntimeField_14 = fromAmount;
        }
        else
        {
                mem[16] = this;
            mem[20] = fromAmount;
        }
        
        typeof(LimitedTimeBundlesPopup.<StartFoodAnim>d__22).__il2cppRuntimeField_18 = toAmount;
    }
    private System.Collections.IEnumerator CollectCoinsDelayComplete(float waitTime, System.Action onCompleteAction)
    {
        typeof(LimitedTimeBundlesPopup.<CollectCoinsDelayComplete>d__23).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(LimitedTimeBundlesPopup.<CollectCoinsDelayComplete>d__23).__il2cppRuntimeField_10 = onCompleteAction;
        }
        else
        {
                mem[16] = onCompleteAction;
        }
        
        typeof(LimitedTimeBundlesPopup.<CollectCoinsDelayComplete>d__23).__il2cppRuntimeField_14 = R2;
    }
    private System.Collections.IEnumerator PlayCollectAnimWithDelay(CurrencyCollectAnimationInstantiator anim, int fromAmount, int toAmount, float delay)
    {
        float val_1;
        typeof(LimitedTimeBundlesPopup.<PlayCollectAnimWithDelay>d__24).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(LimitedTimeBundlesPopup.<PlayCollectAnimWithDelay>d__24).__il2cppRuntimeField_14 = anim;
            typeof(LimitedTimeBundlesPopup.<PlayCollectAnimWithDelay>d__24).__il2cppRuntimeField_18 = fromAmount;
            typeof(LimitedTimeBundlesPopup.<PlayCollectAnimWithDelay>d__24).__il2cppRuntimeField_1C = toAmount;
        }
        else
        {
                mem[20] = anim;
            mem[24] = fromAmount;
            mem[28] = toAmount;
        }
        
        typeof(LimitedTimeBundlesPopup.<PlayCollectAnimWithDelay>d__24).__il2cppRuntimeField_10 = val_1;
    }
    private void OnCloseClicked()
    {
        if(this.OnAnimationsComplete != 0)
        {
                this.OnAnimationsComplete.Invoke();
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1155169888, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void CloseWindow()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1155053792, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public LimitedTimeBundlesPopup()
    {
    
    }

}
