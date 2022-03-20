using UnityEngine;
public class TRVProgressiveIAPPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text coinText;
    private UnityEngine.UI.Text gemText;
    private UnityEngine.UI.Text priceText;
    private UnityEngine.UI.Text freeText;
    private UnityEngine.UI.Text valueText;
    private UnityEngine.UI.Text timeRemainingText;
    private UnityEngine.UI.Text nextTierText;
    private UnityEngine.UI.Image coinImage;
    private UnityEngine.UI.Image gemImage;
    private UnityEngine.GameObject gemGroup;
    private UnityEngine.GameObject maxValueGroup;
    private UnityEngine.Sprite coinLowSprite;
    private UnityEngine.Sprite coinMedSprite;
    private UnityEngine.Sprite coinMaxSprite;
    private UnityEngine.Sprite gemLowSprite;
    private UnityEngine.Sprite gemMedSprite;
    private UnityEngine.Sprite gemMaxSprite;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button purchaseButton;
    private CoinCurrencyCollectAnimationInstantiator coinAnimation;
    private GemsCollectAnimationInstantiator gemAnimation;
    private PurchaseModel currentModel;
    private bool supportsGems;
    
    // Methods
    private void Start()
    {
        this.SetupUI();
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -588502336);
        System.Action val_3 = new System.Action(object:  -588502336, method:  new IntPtr(3706421504));
        this.freeText = null;
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -588502336, method:  new IntPtr(3706430720));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -588502336, method:  new IntPtr(3706439936));
        this.purchaseButton.m_OnClick.AddListener(call:  162246656);
    }
    private void SetupUI()
    {
        float val_33;
        UnityEngine.UI.Image val_34;
        UnityEngine.Sprite val_35;
        UnityEngine.Sprite val_36;
        int val_37;
        var val_38;
        UnityEngine.GameObject val_39;
        UnityEngine.UI.Text val_40;
        var val_41;
        var val_42;
        System.Func<System.Int32, System.Int32> val_44;
        var val_45;
        var val_46;
        var val_32 = 23674090;
        val_32 = 11957088 + val_32;
        if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
        this.supportsGems = TRVProgressiveIAPHandler.BONUS_MULTIPLIER.SupportsGems();
        if((UnityEngine.Object.op_Implicit(exists:  this.gemGroup)) != false)
        {
                if(this.supportsGems == true)
        {
                this.supportsGems = 1;
        }
        
            this.gemGroup.SetActive(value:  true);
        }
        
        UnityEngine.GameObject val_3 = this.gemAnimation.gameObject;
        if(this.supportsGems == true)
        {
                this.supportsGems = 1;
        }
        
        this.gemAnimation.SetActive(value:  true);
        if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
        int val_4 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER.GetCurrentTier(calculatedProgress:  TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 28);
        val_33 = val_4;
        if(val_4 == 3)
        {
            goto label_12;
        }
        
        if(val_33 == 2)
        {
            goto label_13;
        }
        
        if(val_33 != 1)
        {
            goto label_14;
        }
        
        this.coinImage.sprite = this.coinLowSprite;
        val_34 = this.gemImage;
        val_35 = this.gemLowSprite;
        goto label_18;
        label_12:
        this.coinImage.sprite = this.coinMaxSprite;
        val_34 = this.gemImage;
        val_35 = this.gemMaxSprite;
        goto label_18;
        label_13:
        this.coinImage.sprite = this.coinMedSprite;
        val_34 = this.gemImage;
        val_35 = this.gemMedSprite;
        label_18:
        val_36 = val_35;
        val_34.sprite = val_36;
        goto label_21;
        label_14:
        val_36 = 0;
        UnityEngine.Debug.LogError(message:  -588336512);
        label_21:
        this.currentModel = 0;
        PurchaseModel val_5 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER.GetCurrentPurchaseModel(tierOverride:  0);
        this.currentModel = TRVProgressiveIAPHandler.BONUS_MULTIPLIER;
        decimal val_6 = Credits;
        string val_7 = ToString();
        string val_8 = System.String.Format(format:  -588332288, arg0:  -588267264);
        decimal val_9 = Gems;
        string val_10 = ToString();
        string val_11 = System.String.Format(format:  -588332288, arg0:  -588267264);
        string val_12 = this.currentModel.LocalPrice;
        twelvegigs.storage.JsonDictionary val_13 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER.GetCurrentJsonDictionary(tier:  0);
        val_37 = "BonusMulti";
        float val_14 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER.getFloat(key:  -591346544, defaultValue:  null);
        float val_33 = 1f;
        val_33 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER + val_33;
        val_33 = val_33 * this.currentModel.sale_price;
        float val_34 = (float)UnityEngine.Mathf.CeilToInt(f:  val_33);
        val_34 = val_34 + (-0.01f);
        string val_16 = val_34.ToString(format:  -1797462704);
        string val_17 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER * 100f;
        string val_18 = val_17.ToString();
        string val_19 = System.String.Format(format:  2124591920, arg0:  -588267268);
        val_38 = "{0}%";
        val_39 = this.maxValueGroup;
        if(val_33 == 3)
        {
                if((UnityEngine.Object.op_Implicit(exists:  val_39)) != false)
        {
                this.maxValueGroup.SetActive(value:  true);
        }
        
            val_40 = this.nextTierText;
            val_41 = "get_more_popup_body_max";
            string val_22 = Localization.Localize(key:  -588295232, defaultValue:  -588295344, useSingularKey:  false);
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  val_39)) != false)
        {
                this.maxValueGroup.SetActive(value:  false);
        }
        
            twelvegigs.storage.JsonDictionary val_24 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER.GetCurrentJsonDictionary(tier:  3);
            float val_25 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER.getFloat(key:  -591346544, defaultValue:  val_17);
            val_37 = UnityEngine.Mathf.FloorToInt(f:  TRVProgressiveIAPHandler.BONUS_MULTIPLIER * 100f);
            val_42 = null;
            val_42 = null;
            val_44 = TRVProgressiveIAPPopup.<>c.<>9__24_0;
            if(val_44 == 0)
        {
                val_44 = null;
            val_44 = new System.Func<System.Int32, System.Int32>(object:  TRVProgressiveIAPPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3706680384));
            TRVProgressiveIAPPopup.<>c.<>9__24_0 = val_44;
        }
        
            val_40 = this.nextTierText;
            val_39 = (System.Linq.Enumerable.Sum<System.Int32>(source:  TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 24, selector:  7720960)) - (TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 28);
            if(val_39 > 1)
        {
                val_45 = "Get up to {0}% by finishing {1} levels!";
            val_46 = "get_more_popup_body";
        }
        else
        {
                val_45 = "Get up to {0}% by finishing {1} level!";
            val_46 = "get_more_popup_body_singular";
        }
        
            string val_30 = Localization.Localize(key:  -588279328, defaultValue:  -588279472, useSingularKey:  false);
            val_33 = 1152921504619999232;
            val_38 = null;
            val_41 = val_46;
            string val_31 = System.String.Format(format:  -588279328, arg0:  13152256, arg1:  13152256);
        }
        
        if(val_40 != 0)
        {
                return;
        }
    
    }
    private void SetBaseText()
    {
    
    }
    private void OnClickPurchase()
    {
        var val_4;
        var val_4 = 23671606;
        val_4 = 11959572 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -587911392, method:  new IntPtr(3707026784));
        TRVProgressiveIAPHandler.BONUS_MULTIPLIER.__unknownFiledOffset_2C = null;
        this.purchaseButton.interactable = false;
        GameBehavior val_2 = App.getBehavior;
        if(0 == 1)
        {
                val_4 = null;
            TRVProgressiveIAPHandler.purchasePoint = 118;
        }
        else
        {
                bool val_3 = this.IsDuringLevelComplete();
            val_4 = null;
            if(val_3 == false)
        {
                val_3 = 120;
        }
        
            if(val_3 == true)
        {
                val_3 = 119;
        }
        
            TRVProgressiveIAPHandler.purchasePoint = val_3;
        }
        
        if(val_4 == 0)
        {
                val_4 = null;
            mem2[0] = 1;
        }
        
        TRVProgressiveIAPHandler.BONUS_MULTIPLIER.TryPurchase();
    }
    private void OnPurchaseResult(bool purchased)
    {
        int val_10;
        int val_11;
        int val_16;
        int val_17;
        int val_18;
        int val_19;
        CoinCurrencyCollectAnimationInstantiator val_27;
        int val_29;
        var val_30;
        UnityEngine.GameObject val_31;
        var val_32;
        System.Func<System.Boolean> val_34;
        var val_35;
        float val_36;
        if(purchased != false)
        {
                System.Action val_1 = new System.Action(object:  -587781984, method:  new IntPtr(3706430720));
            mem2[0] = null;
            val_27 = this.coinAnimation;
            Player val_2 = App.Player;
            decimal val_3 = Credits;
            decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -587794052, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            val_29 = System.Decimal.op_Explicit(value:  new System.Decimal());
            Player val_6 = App.Player;
            val_30 = 52;
            val_31 = 52;
            val_27.Play(fromValue:  val_29, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  1069547520);
            if(mem[1152921512608999684] == false)
        {
                return;
        }
        
            val_27 = mem[1152921512608999676];
            Player val_7 = App.Player;
            val_29 = 0;
            decimal val_8 = System.Decimal.op_Implicit(value:  -587794036);
            decimal val_9 = Gems;
            decimal val_12 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -587794068}, d2:  new System.Decimal() {flags = val_10, hi = val_11});
            Player val_14 = App.Player;
            val_30 = 0;
            decimal val_15 = System.Decimal.op_Implicit(value:  -587794084);
            val_31 = 1069547520;
            val_27.Play(fromValue:  System.Decimal.op_Explicit(value:  new System.Decimal()), toValue:  new System.Decimal() {flags = val_18, hi = val_19, lo = val_17, mid = val_16}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  val_31);
            return;
        }
        
        GameBehavior val_20 = App.getBehavior;
        string val_22 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_23 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_24 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
        val_32 = null;
        val_32 = null;
        val_34 = TRVProgressiveIAPPopup.<>c.<>9__27_0;
        if(val_34 == 0)
        {
                val_34 = null;
            val_34 = new System.Func<System.Boolean>(object:  TRVProgressiveIAPPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3707160288));
            TRVProgressiveIAPPopup.<>c.<>9__27_0 = val_34;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_34;
        val_35 = null;
        val_36 = "purchase_failed_upper";
        0.SetupMessage(titleTxt:  -1349324784, messageTxt:  -1349324672, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_26 = this.gameObject;
        SLCWindow.CloseWindow(window:  -587781984, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        mem[1152921512608999668].interactable = true;
    }
    private void UpdateTimerText()
    {
        var val_9 = 23668470;
        val_9 = 11962708 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        if(TRVProgressiveIAPHandler.BONUS_MULTIPLIER == null)
        {
                return;
        }
        
        string val_2 = ???.Days.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        string val_4 = ???.Hours.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        string val_6 = ???.Minutes.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        string val_7 = Localization.Localize(key:  -1118401280, defaultValue:  -1118401376, useSingularKey:  false);
        typeof(System.Object[]).__il2cppRuntimeField_1C = "deal_ends_in";
        string val_8 = System.String.Format(format:  -587677600, args:  472754880);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -587537392, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private bool IsDuringLevelComplete()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_7 = 23665687;
        val_7 = 11960100 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        if(App.game == 17)
        {
                val_8 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = 0;
            if(2119322896 == 0)
        {
                return true;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                return ShowingWindow<WordHuntPopup>();
        }
        
            return ShowingWindow<WordHuntPopup>();
        }
        
        val_8 = 1152921504885600256;
        val_9 = 0;
        MainController val_4 = MainController.instance;
        if(0 == 0)
        {
                return true;
        }
        
        MainController val_6 = MainController.instance;
        if(3 != 0)
        {
                val_9 = 1;
        }
        
        return true;
    }
    public TRVProgressiveIAPPopup()
    {
        this.supportsGems = true;
    }

}
