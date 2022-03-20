using UnityEngine;
public class WGSubscriptionPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.Texture goldenTicket;
    private UnityEngine.Texture silverTicket;
    protected WGMessagePopup localMessagePopup;
    protected UnityEngine.GameObject goldenTicketPromoObject;
    protected UnityEngine.UI.Text goldenTicketPromoPurchaseCostText;
    protected UnityEngine.UI.Text goldenTicketPromoTrialText1;
    protected UnityEngine.UI.Text goldenTicketPromoTrialText2;
    private UnityEngine.UI.Text goldenTicketSecondaryDescText;
    protected UnityEngine.UI.Text goldenTicketPromoDailyCoins;
    protected UnityEngine.UI.Text goldenTicketPromoAppleMulti;
    private UnityEngine.UI.Text goldenTicketPromoValueText;
    protected UnityEngine.GameObject goldenTicketValueTagObject;
    protected UnityEngine.GameObject goldenTicketTrialDescsObject;
    protected UGUINetworkedButton goldenTicketPromoPurchaseButton;
    private UnityEngine.UI.Button goldenTicketPromoCloseButton;
    private UnityEngine.UI.Button goldenTicketPrivacyPolicy;
    private UnityEngine.UI.Button goldenTicketTermsOfUse;
    protected UnityEngine.GameObject silverTicketPromoObject;
    protected UnityEngine.UI.Text silverTicketPromoPurchaseCostText;
    protected UnityEngine.UI.Text silverTicketPromoTrialText1;
    protected UnityEngine.UI.Text silverTicketPromoTrialText2;
    private UnityEngine.UI.Text silverTicketSecondaryDescText;
    private UnityEngine.UI.Text promoDescText;
    private UnityEngine.UI.Text silverTicketPromoDailyCoins;
    private UnityEngine.UI.Text silverTicketPromoAppleMulti;
    private UnityEngine.UI.Text silverTicketPromoValueText;
    protected UnityEngine.GameObject silverTicketValueTagObject;
    protected UnityEngine.GameObject silverTicketTrialDescsObject;
    protected UGUINetworkedButton silverTicketPromoPurchaseButton;
    private UnityEngine.UI.Button silverTicketPromoCloseButton;
    private UnityEngine.GameObject appleRewardGroup;
    private UnityEngine.RectTransform bonusGrid;
    private UnityEngine.UI.Button silverTicketPrivacyPolicy;
    private UnityEngine.UI.Button silverTicketTermsOfUse;
    protected UnityEngine.GameObject collectObject;
    private UnityEngine.UI.Text coinCollectAmountText;
    private UGUINetworkedButton collectButton;
    private GridCoinCollectAnimationInstantiator collectCoinCollector;
    private UnityEngine.UI.RawImage collectImage;
    protected UnityEngine.GameObject statusObject;
    protected UnityEngine.UI.Text statusText;
    protected UnityEngine.UI.Button statusInfoButton;
    private UnityEngine.UI.Text statusCoinTimer;
    private UnityEngine.UI.RawImage statusImage;
    protected UnityEngine.GameObject infoObject;
    protected UnityEngine.UI.Button infoCloseButton;
    protected UnityEngine.UI.Text[] infoLines;
    private UnityEngine.UI.RawImage infoImage;
    public System.Action onCloseAction;
    public bool forcePromo;
    public SubscriptionHandler.SubScriptionType subPackage;
    protected UnityEngine.GameObject promoObject;
    
    // Methods
    private void Start()
    {
        goto typeof(WGSubscriptionPopup).__il2cppRuntimeField_DC;
    }
    public virtual void Init()
    {
        var val_8;
        var val_9;
        UnityEngine.GameObject val_10;
        var val_11;
        var val_12;
        val_8 = this;
        var val_7 = 25513295;
        val_7 = 10112492 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if(App.game != 17)
        {
            goto label_6;
        }
        
        this.subPackage = 0;
        goto label_8;
        label_6:
        if(this.subPackage == 0)
        {
            goto label_8;
        }
        
        val_10 = this.silverTicketPromoObject;
        goto label_9;
        label_8:
        val_10 = this.goldenTicketPromoObject;
        label_9:
        this.promoObject = mem[this.goldenTicketPromoObject];
        UnityEngine.GameObject val_1 = this.localMessagePopup.gameObject;
        this.localMessagePopup.SetActive(value:  false);
        this.promoObject.SetActive(value:  false);
        this.collectObject.SetActive(value:  false);
        this.statusObject.SetActive(value:  false);
        if(this.subPackage == 0)
        {
                16 = 12;
        }
        
        this.infoImage.texture = this.goldenTicket;
        this.statusImage.texture = this.goldenTicket;
        this.collectImage.texture = this.goldenTicket;
        val_11 = 1152921504897900544;
        val_12 = 1152921511219894560;
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((IsActive(subPackage:  this.subPackage)) != false)
        {
                if(this.forcePromo != false)
        {
            
        }
        else
        {
                if((R4 + 216.activeSelf) != false)
        {
                R4 + 216.SetActive(value:  false);
        }
        
            WGBonusRewardsHandler val_5 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if((R7.CanCollect(subPackage:  R4 + 212)) != false)
        {
                R4.InitCollectPopup();
        }
        
        }
        
        }
    
    }
    public virtual void InitPromoPopup()
    {
        var val_68;
        SubscriptionHandler.SubScriptionType val_69;
        UGUINetworkedButton val_70;
        UnityEngine.UI.Text val_71;
        this.goldenTicketPromoPurchaseButton.OnConnectionClick = new System.Action<System.Boolean>(object:  -1216759392, method:  new IntPtr(3077939200));
        this.silverTicketPromoPurchaseButton.OnConnectionClick = new System.Action<System.Boolean>(object:  -1216759392, method:  new IntPtr(3077939200));
        val_68 = 1152921504769093632;
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1216759392, method:  new IntPtr(3077952512));
        this.goldenTicketPrivacyPolicy.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1216759392, method:  new IntPtr(3077961728));
        this.goldenTicketTermsOfUse.m_OnClick.AddListener(call:  162246656);
        if((UnityEngine.Object.op_Implicit(exists:  this.silverTicketPrivacyPolicy)) != false)
        {
                UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1216759392, method:  new IntPtr(3077952512));
            this.silverTicketPrivacyPolicy.m_OnClick.AddListener(call:  162246656);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.silverTicketTermsOfUse)) != false)
        {
                UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -1216759392, method:  new IntPtr(3077961728));
            this.silverTicketTermsOfUse.m_OnClick.AddListener(call:  162246656);
        }
        
        UnityEngine.GameObject val_9 = this.promoObject.gameObject;
        this.promoObject.SetActive(value:  true);
        val_69 = 1152921511979813888;
        null = new UnityEngine.Events.UnityAction(object:  -1216759392, method:  new IntPtr(3077999616));
        this.goldenTicketPromoCloseButton.m_OnClick.AddListener(call:  162246656);
        if((UnityEngine.Object.op_Implicit(exists:  this.silverTicketPromoCloseButton)) != false)
        {
                UnityEngine.Events.UnityAction val_12 = new UnityEngine.Events.UnityAction(object:  -1216759392, method:  new IntPtr(3077999616));
            this.silverTicketPromoCloseButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.subPackage == 1)
        {
            goto label_26;
        }
        
        if(this.subPackage != 0)
        {
            goto label_27;
        }
        
        val_68 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_14 = GetPromoCostForPackage(subPack:  this.subPackage);
        string val_15 = Localization.Localize(key:  -1222347792, defaultValue:  -1222347696, useSingularKey:  false);
        string val_16 = System.String.Format(format:  -1222347616, arg0:  -1897280256, arg1:  -1222347792);
        string val_17 = Localization.Localize(key:  -1216933696, defaultValue:  -1216933808, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameEcon val_20 = App.getGameEcon;
        val_69 = 0;
        string val_21 = promoDailyCoinsAmount(subPackage:  this.subPackage).ToString(format:  null);
        string val_22 = System.String.Format(format:  -1216933696, arg0:  -1216771432);
        string val_23 = Localization.Localize(key:  -1216925264, defaultValue:  -1216925392, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_25 = pointXMoreMultiplier;
        string val_26 = System.String.Format(format:  -1216925264, arg0:  -1897280256);
        this.goldenTicketPromoCloseButton.interactable = true;
        val_70 = this.goldenTicketPromoPurchaseButton;
        goto label_41;
        label_26:
        UnityEngine.Debug.LogError(message:  -1216916944);
        this.appleRewardGroup.SetActive(value:  false);
        string val_27 = Localization.Localize(key:  -1216904448, defaultValue:  -1216904320, useSingularKey:  false);
        val_68 = "silver_ticket_promo_popup_text";
        twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameEcon val_30 = App.getGameEcon;
        string val_31 = promoDailyCoinsAmount(subPackage:  this.subPackage).ToString(format:  null);
        twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_33 = GetPromoCostForPackage(subPack:  this.subPackage);
        string val_34 = System.String.Format(format:  -1216904448, arg0:  -1216771432, arg1:  -1897280256);
        twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_36 = GetPromoCostForPackage(subPack:  this.subPackage);
        string val_37 = Localization.Localize(key:  -1222347792, defaultValue:  -1222347696, useSingularKey:  false);
        string val_38 = System.String.Format(format:  -1222347616, arg0:  -1897280256, arg1:  -1222347792);
        string val_39 = Localization.Localize(key:  -1216883408, defaultValue:  -1216883520, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_40 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameEcon val_42 = App.getGameEcon;
        val_69 = 0;
        string val_43 = promoDailyCoinsAmount(subPackage:  this.subPackage).ToString(format:  null);
        string val_44 = System.String.Format(format:  -1216883408, arg0:  -1216771432);
        string val_45 = Localization.Localize(key:  -1223398896, defaultValue:  -1223398992, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_46 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_47 = pointMultiplier;
        string val_48 = System.String.Format(format:  -1223398896, arg0:  -1897280256);
        this.silverTicketPromoCloseButton.interactable = true;
        val_70 = this.silverTicketPromoPurchaseButton;
        label_41:
        val_70.interactable = true;
        label_27:
        bool val_49 = WGSubscriptionManager.WillGetFreeTrial;
        this.goldenTicketTrialDescsObject.SetActive(value:  val_49);
        this.silverTicketTrialDescsObject.SetActive(value:  val_49);
        if(val_49 == false)
        {
            goto label_67;
        }
        
        if(this.subPackage == 1)
        {
            goto label_66;
        }
        
        if(this.subPackage != 0)
        {
            goto label_67;
        }
        
        this.goldenTicketValueTagObject.SetActive(value:  false);
        this.goldenTicketTrialDescsObject.SetActive(value:  true);
        string val_50 = Localization.Localize(key:  -1216842320, defaultValue:  -1222356192, useSingularKey:  false);
        string val_51 = Localization.Localize(key:  -1216837984, defaultValue:  -1216838112, useSingularKey:  false);
        string val_52 = ToUpper();
        val_68 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_53 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_54 = freeTrialDaysCount(subPackage:  this.subPackage);
        string val_55 = System.String.Format(format:  -1216837984, arg0:  13152256);
        val_71 = this.goldenTicketPromoTrialText2;
        goto label_76;
        label_66:
        this.silverTicketValueTagObject.SetActive(value:  false);
        this.silverTicketTrialDescsObject.SetActive(value:  true);
        string val_56 = Localization.Localize(key:  -1216842320, defaultValue:  -1222356192, useSingularKey:  false);
        string val_57 = Localization.Localize(key:  -1216837984, defaultValue:  -1216813296, useSingularKey:  false);
        val_68 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_58 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_59 = freeTrialDaysCount(subPackage:  this.subPackage);
        string val_60 = System.String.Format(format:  -1216837984, arg0:  13152256);
        val_71 = this.silverTicketPromoTrialText2;
        label_76:
        string val_61 = Localization.Localize(key:  -1216804864, defaultValue:  -1216804976, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_62 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_69 = this.subPackage;
        string val_63 = GetPromoCostForPackage(subPack:  val_69);
        string val_64 = System.String.Format(format:  -1216804864, arg0:  -1897280256);
        label_67:
        string val_65 = Localization.Localize(key:  -1216800560, defaultValue:  -1216800656, useSingularKey:  false);
        string val_66 = Localization.Localize(key:  -1216796352, defaultValue:  -1216796224, useSingularKey:  false);
        string val_67 = System.String.Format(format:  -1216796352, arg0:  -1216800560);
        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot:  this.bonusGrid);
        this.forcePromo = false;
    }
    protected void tryClickPurchase(bool connected, SubscriptionHandler.SubScriptionType subType)
    {
        var val_5;
        if(connected == false)
        {
            goto label_1;
        }
        
        this.goldenTicketPromoPurchaseButton.interactable = false;
        this.silverTicketPromoPurchaseButton.interactable = false;
        this.promoObject.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1216388320, method:  new IntPtr(3078553952));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_5 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_10;
        }
        
        }
        
        val_5 = 0;
        label_10:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_5;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TryPurchase(subPackage:  subType);
        return;
        label_1:
        this.ShowInternetRequired(shouldReturn:  true);
    }
    private void tryClickPurchase(bool connected)
    {
        var val_5;
        if(connected == false)
        {
            goto label_1;
        }
        
        this.goldenTicketPromoPurchaseButton.interactable = false;
        this.silverTicketPromoPurchaseButton.interactable = false;
        this.promoObject.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1216243552, method:  new IntPtr(3078553952));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_5 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_10;
        }
        
        }
        
        val_5 = 0;
        label_10:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_5;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TryPurchase(subPackage:  this.subPackage);
        return;
        label_1:
        this.ShowInternetRequired(shouldReturn:  true);
    }
    private void OnPurchaseAttemptResult(bool result)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = this;
        val_11 = result;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance();
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1216111072, method:  new IntPtr(3078553952));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_13 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_13 != 0)
        {
                if(val_13 == null)
        {
            goto label_6;
        }
        
        }
        
        val_13 = 0;
        label_6:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_13;
        if(val_11 != false)
        {
                WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -1983121040)) == false)
        {
                return;
        }
        
            WGBonusRewardsHandler val_6 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            RequestDataFlush(immediate:  false, reset:  false);
            this.promoObject.SetActive(value:  false);
        }
        else
        {
                SB + 68.interactable = true;
            SB + 128.interactable = true;
            SB + 64.interactable = true;
            SB + 124.interactable = true;
            string val_7 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
            string val_8 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
            SB.ShowPurchaseFailed(title:  -1349324784, message:  -1349324672);
        }
    
    }
    protected void InitCollectPopup()
    {
        System.Action<System.Boolean> val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameEcon val_3 = App.getGameEcon;
        string val_4 = promoDailyCoinsAmount(subPackage:  this.subPackage).ToString(format:  null);
        System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  -1215973472, method:  new IntPtr(3078964704));
        System.Delegate val_6 = System.Delegate.Combine(a:  this.collectButton.OnConnectionClick, b:  7401472);
        val_7 = this.collectButton.OnConnectionClick;
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_7 = 0;
        label_11:
        this.collectButton.OnConnectionClick = val_7;
        this.collectObject.SetActive(value:  true);
    }
    private void DoCollect(bool connected)
    {
        System.Delegate val_5;
        if(connected == false)
        {
            goto typeof(WGSubscriptionPopup).__il2cppRuntimeField_EC;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean, collectResultStatus> val_2 = new System.Action<System.Boolean, collectResultStatus>(object:  -1215831776, method:  typeof(WGSubscriptionPopup).__il2cppRuntimeField_F0);
        val_5 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_10;
        System.Delegate val_3 = System.Delegate.Combine(a:  val_5, b:  7507968);
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_7;
        }
        
        }
        
        val_5 = 0;
        label_7:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_10 = val_5;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UITryCollect(subPackage:  this.subPackage);
        this.collectButton.interactable = false;
    }
    protected virtual void CollectAttemptResult(bool result, WGSubscriptionManager.collectResultStatus status)
    {
        int val_11;
        int val_12;
        int val_13;
        int val_14;
        System.Delegate val_16;
        System.Action val_17;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean, collectResultStatus> val_2 = new System.Action<System.Boolean, collectResultStatus>(object:  -1215687008, method:  typeof(WGSubscriptionPopup).__il2cppRuntimeField_F0);
        val_16 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_10;
        System.Delegate val_3 = System.Delegate.Remove(source:  val_16, value:  7507968);
        if(val_16 != 0)
        {
                if(val_16 == null)
        {
            goto label_6;
        }
        
        }
        
        val_16 = 0;
        label_6:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_10 = val_16;
        if(result == false)
        {
            goto label_7;
        }
        
        System.Action val_4 = new System.Action(object:  -1215687008, method:  new IntPtr(3077999616));
        System.Delegate val_5 = System.Delegate.Combine(a:  this.collectCoinCollector.OnCompleteCallback, b:  7454720);
        val_17 = this.collectCoinCollector.OnCompleteCallback;
        if(val_17 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_17 = 0;
        label_11:
        this.collectCoinCollector.OnCompleteCallback = val_17;
        Player val_6 = App.Player;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_8 = promoDailyCoinsAmount(subPackage:  this.subPackage);
        decimal val_9 = System.Decimal.op_Implicit(value:  -1215699060);
        decimal val_10 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1215699076, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        this.collectCoinCollector.Set(instantValue:  new System.Decimal() {flags = val_11, hi = val_12, lo = val_13, mid = val_14});
        Player val_15 = App.Player;
        this.collectCoinCollector.Play(fromValue:  new System.Decimal() {flags = val_11, hi = val_12, lo = val_13, mid = val_14}, toValue:  new System.Decimal() {mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
        return;
        label_7:
        if(status == 1)
        {
                this.ShowInternetRequired(shouldReturn:  false);
            return;
        }
        
        this.ClosePopup();
    }
    protected virtual void InitStatusPopup()
    {
        var val_12;
        var val_13;
        var val_14;
        if(this.subPackage == 1)
        {
            goto label_1;
        }
        
        if(this.subPackage != 0)
        {
            goto label_2;
        }
        
        val_12 = "golden_ticket_status_popup_text";
        val_13 = "Your next {0} free daily coins are coming soon! Don\'t forget you are earning double {1}";
        goto label_4;
        label_1:
        val_12 = "silver_ticket_status_popup_text";
        val_13 = "Your next {0} free daily coins are coming soon!";
        goto label_4;
        label_2:
        val_12 = "";
        val_14 = val_12;
        label_4:
        string val_1 = Localization.Localize(key:  1098586544, defaultValue:  1098586544, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameEcon val_4 = App.getGameEcon;
        string val_5 = promoDailyCoinsAmount(subPackage:  this.subPackage).ToString(format:  null);
        GameBehavior val_6 = App.getBehavior;
        string val_7 = System.String.Format(format:  1098586544, arg0:  -1215528980, arg1:  0);
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -1215516944, method:  typeof(WGSubscriptionPopup).__il2cppRuntimeField_100);
        this.statusInfoButton.m_OnClick.AddListener(call:  162246656);
        System.Collections.IEnumerator val_9 = this.updateStatusTime();
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -1215516944);
        this.statusObject.SetActive(value:  true);
        if(this.promoObject.activeSelf == false)
        {
                return;
        }
        
        this.promoObject.SetActive(value:  false);
    }
    protected System.Collections.IEnumerator updateStatusTime()
    {
        object val_1 = new System.Object();
        typeof(WGSubscriptionPopup.<updateStatusTime>d__62).__il2cppRuntimeField_8 = 0;
        typeof(WGSubscriptionPopup.<updateStatusTime>d__62).__il2cppRuntimeField_10 = this;
    }
    public virtual void InitInfoPopup()
    {
        var val_11;
        float val_12;
        var val_13;
        var val_14;
        if(this.subPackage == 1)
        {
            goto label_1;
        }
        
        if(this.subPackage != 0)
        {
            goto label_2;
        }
        
        val_11 = "While you have a Golden Ticket, you earn double {0} and collect free coins every day";
        val_12 = "Golden";
        val_13 = "golden";
        goto label_4;
        label_1:
        val_11 = "While you have a Silver Ticket, you\'re awarded a number of free coins every day";
        val_12 = "Silver";
        val_13 = "silver";
        goto label_4;
        label_2:
        val_11 = "";
        val_12 = val_11;
        val_14 = val_11;
        label_4:
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1215073040, method:  new IntPtr(3079696048));
        this.infoCloseButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.UI.Text val_11 = this.infoLines[0];
        string val_2 = 1098586544 + -1215233360(-1215233360);
        string val_3 = 1098586544 + -1215229168(-1215229168);
        string val_4 = Localization.Localize(key:  1098586544, defaultValue:  1098586544, useSingularKey:  false);
        UnityEngine.UI.Text val_12 = this.infoLines[1];
        string val_5 = 1098586544 + -1215192112(-1215192112);
        string val_6 = Localization.Localize(key:  1098586544, defaultValue:  1098586544, useSingularKey:  false);
        GameBehavior val_7 = App.getBehavior;
        string val_8 = System.String.Format(format:  1098586544, arg0:  0);
        UnityEngine.UI.Text val_13 = this.infoLines[2];
        string val_9 = Localization.Localize(key:  -1215150864, defaultValue:  -1215151056, useSingularKey:  false);
        UnityEngine.UI.Text val_14 = this.infoLines[3];
        string val_10 = Localization.Localize(key:  -1215109440, defaultValue:  -1215109792, useSingularKey:  false);
        this.infoObject.SetActive(value:  true);
        this.statusObject.SetActive(value:  false);
    }
    protected void CloseInfo()
    {
        this.statusObject.SetActive(value:  true);
        this.infoObject.SetActive(value:  false);
        this.infoCloseButton.m_OnClick.RemoveAllListeners();
    }
    public void ClosePopup()
    {
        if(this.onCloseAction != 0)
        {
                this.onCloseAction.Invoke();
        }
        
        this.onCloseAction = 0;
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1214627856, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected void ShowInternetRequired(bool shouldReturn = True)
    {
        var val_7;
        var val_8;
        if(new System.Object() != 0)
        {
                typeof(WGSubscriptionPopup.<>c__DisplayClass66_0).__il2cppRuntimeField_8 = shouldReturn;
        }
        else
        {
                mem[8] = shouldReturn;
        }
        
        typeof(WGSubscriptionPopup.<>c__DisplayClass66_0).__il2cppRuntimeField_C = this;
        this.promoObject.SetActive(value:  false);
        this.statusObject.SetActive(value:  false);
        this.collectObject.SetActive(value:  false);
        this.infoObject.SetActive(value:  false);
        string val_2 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_3 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_4 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        System.Func<System.Boolean> val_5 = new System.Func<System.Boolean>(object:  324493312, method:  new IntPtr(3080452016));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_7 = null;
        val_8 = this.localMessagePopup;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_6 = this.localMessagePopup.gameObject;
        this.localMessagePopup.SetActive(value:  true);
    }
    public void ShowPurchaseFailed(string title, string message)
    {
        string val_10;
        string val_11;
        var val_12;
        var val_13;
        System.String[] val_14;
        WGMessagePopup val_15;
        val_10 = message;
        val_11 = title;
        val_12 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  this.promoObject)) != false)
        {
                this.promoObject.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.statusObject)) != false)
        {
                this.statusObject.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.collectObject)) != false)
        {
                this.collectObject.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.infoObject)) != false)
        {
                this.infoObject.SetActive(value:  false);
        }
        
        if(this.localMessagePopup != 0)
        {
                typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_6 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
            System.Func<System.Boolean> val_7 = new System.Func<System.Boolean>(object:  -1214299408, method:  new IntPtr(3080634672));
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
            val_13 = null;
            val_14 = null;
            val_15 = this.localMessagePopup;
            if( == 0)
        {
                val_15 = this.localMessagePopup;
        }
        
            val_15.SetupMessage(titleTxt:  val_11, messageTxt:  val_10, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
            val_12 = 1152921504765685760;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.localMessagePopup)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_9 = this.localMessagePopup.gameObject;
        this.localMessagePopup.SetActive(value:  true);
    }
    private void ClickPrivacyPolicy()
    {
        AppConfigs val_1 = App.Configuration;
        twelvegigs.plugins.SharePlugin.OpenURL(url:  null);
    }
    private void ClickTermsOfUse()
    {
        AppConfigs val_1 = App.Configuration;
        twelvegigs.plugins.SharePlugin.OpenURL(url:  16787456);
    }
    private void OnDestroy()
    {
        var val_9;
        var val_10;
        System.Delegate val_11;
        var val_12;
        val_9 = 1152921504901095424;
        val_10 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean, collectResultStatus> val_4 = new System.Action<System.Boolean, collectResultStatus>(object:  -1213906064, method:  typeof(WGSubscriptionPopup).__il2cppRuntimeField_F0);
        val_11 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_10;
        System.Delegate val_5 = System.Delegate.Remove(source:  val_11, value:  7507968);
        if(val_11 != 0)
        {
                if(val_11 == null)
        {
            goto label_11;
        }
        
        }
        
        val_11 = 0;
        label_11:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_10 = val_11;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = 1152921504614248448;
        System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  -1213906064, method:  new IntPtr(3078553952));
        System.Delegate val_8 = System.Delegate.Remove(source:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_12 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_12 != 0)
        {
                if(val_12 == null)
        {
            goto label_15;
        }
        
        }
        
        val_12 = 0;
        label_15:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_12;
    }
    public WGSubscriptionPopup()
    {
    
    }
    private bool <ShowPurchaseFailed>b__67_0()
    {
        return true;
    }

}
