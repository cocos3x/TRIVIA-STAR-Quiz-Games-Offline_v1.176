using UnityEngine;
public class TRVSubscriptionPopup : WGSubscriptionPopup
{
    // Fields
    private UnityEngine.UI.Text silverTicketButtonHeader;
    private UnityEngine.UI.Text goldenTicketButtonHeader;
    private UnityEngine.UI.Text silverTicketCostText;
    private UnityEngine.UI.Text goldenTicketCostText;
    private GemsCollectAnimationInstantiator collectGemCollector;
    
    // Methods
    public override void Init()
    {
        var val_14;
        var val_15;
        var val_14 = 27347319;
        val_14 = 8278468 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        if(App.game != 17)
        {
            goto label_6;
        }
        
        mem[1152921512751833348] = 0;
        goto label_8;
        label_6:
        if(App.game == 0)
        {
            goto label_8;
        }
        
        val_15 = 1152921512751833216;
        goto label_9;
        label_8:
        val_15 = 1152921512751833160;
        label_9:
        mem[1152921512751833352] = null;
        UnityEngine.GameObject val_1 = gameObject;
        SetActive(value:  false);
        SetActive(value:  false);
        SetActive(value:  false);
        SetActive(value:  false);
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((IsActive(subPackage:  0)) != true)
        {
                WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if((IsActive(subPackage:  1)) == false)
        {
            goto typeof(TRVSubscriptionPopup).__il2cppRuntimeField_F4;
        }
        
        }
        
        if(activeSelf != false)
        {
                SetActive(value:  false);
        }
        
        WGBonusRewardsHandler val_7 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((CanCollect(subPackage:  0)) == true)
        {
            goto label_29;
        }
        
        WGBonusRewardsHandler val_9 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        if((CanCollect(subPackage:  1)) == false)
        {
            goto label_33;
        }
        
        label_29:
        WGBonusRewardsHandler val_11 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        bool val_12 = CanCollect(subPackage:  0);
        val_12 = val_12 ^ 1;
        mem[1152921512751833348] = val_12;
        this.InitCollectPopup();
        return;
        label_33:
        bool val_13 = WGSubscriptionManager.HasSubscribedGoldenTicket;
        val_13 = val_13 ^ 1;
        mem[1152921512751833348] = val_13;
        goto typeof(TRVSubscriptionPopup).__il2cppRuntimeField_F4;
    }
    public override void InitPromoPopup()
    {
        float val_49;
        var val_50;
        var val_51;
        UnityEngine.UI.Text val_52;
        var val_53;
        var val_54;
        this.InitPromoPopup();
        string val_1 = Localization.Localize(key:  -444860320, defaultValue:  -444860432, useSingularKey:  false);
        val_49 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_50 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance();
        GameEcon val_4 = App.getGameEcon;
        string val_5 = promoDailyCoinsAmount(subPackage:  static_value_021FAC1B).ToString(format:  null);
        string val_6 = System.String.Format(format:  -444860320, arg0:  -444818104);
        0.SetActive(value:  false);
        0.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(hasAnySubscription() != false)
        {
                UnityEngine.GameObject val_9 = gameObject;
            SetActive(value:  false);
            UnityEngine.GameObject val_10 = gameObject;
            SetActive(value:  false);
            UnityEngine.GameObject val_11 = this.silverTicketButtonHeader.gameObject;
            this.silverTicketButtonHeader.SetActive(value:  false);
            this.silverTicketButtonHeader.interactable = false;
            UnityEngine.GameObject val_12 = this.silverTicketButtonHeader.gameObject;
            this.silverTicketButtonHeader.SetActive(value:  false);
            string val_13 = Localization.Localize(key:  -444852016, defaultValue:  -1222659120, useSingularKey:  false);
            UnityEngine.Color val_14 = UnityEngine.Color.gray;
            this.silverTicketCostText.color = new UnityEngine.Color() {a = ???};
        }
        else
        {
                bool val_15 = WGSubscriptionManager.WillGetFreeTrial;
            SetActive(value:  val_15);
            SetActive(value:  val_15);
            UnityEngine.GameObject val_17 = this.silverTicketCostText.gameObject;
            if(WGSubscriptionManager.WillGetFreeTrial_Silver != false)
        {
                this.silverTicketCostText.SetActive(value:  false);
            UnityEngine.GameObject val_18 = this.silverTicketButtonHeader.gameObject;
            this.silverTicketButtonHeader.SetActive(value:  true);
            UnityEngine.GameObject val_19 = this.silverTicketButtonHeader.gameObject;
            this.silverTicketButtonHeader.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_21 = freeTrialDaysCount(subPackage:  1);
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_23 = GetPromoCostForPackage(subPack:  1);
            string val_24 = System.String.Format(format:  -444839632, arg0:  13152256, arg1:  -1897280256);
            string val_25 = Localization.Localize(key:  -1216837984, defaultValue:  -1216838112, useSingularKey:  false);
            string val_26 = ToUpper();
            twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_28 = freeTrialDaysCount(subPackage:  1);
            string val_29 = System.String.Format(format:  -1216837984, arg0:  13152256);
            val_49 = "ticket_promo_popup2";
            string val_30 = Localization.Localize(key:  -1216804864, defaultValue:  -1216804976, useSingularKey:  false);
            twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_32 = GetPromoCostForPackage(subPack:  1);
            string val_33 = System.String.Format(format:  -1216804864, arg0:  -1897280256);
            string val_34 = Localization.Localize(key:  -1216837984, defaultValue:  -1216813296, useSingularKey:  false);
            twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_36 = freeTrialDaysCount(subPackage:  1);
            string val_37 = System.String.Format(format:  -1216837984, arg0:  13152256);
            string val_38 = Localization.Localize(key:  -1216804864, defaultValue:  -1216804976, useSingularKey:  false);
            val_53 = "ticket_promo_popup2";
            twelvegigs.Autopilot.AutopilotManager val_39 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_50 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance();
            val_54 = val_50;
        }
        else
        {
                this.silverTicketCostText.SetActive(value:  true);
            UnityEngine.GameObject val_40 = this.silverTicketButtonHeader.gameObject;
            this.silverTicketButtonHeader.SetActive(value:  false);
            UnityEngine.GameObject val_41 = this.silverTicketButtonHeader.gameObject;
            this.silverTicketButtonHeader.SetActive(value:  false);
            val_52 = this.silverTicketCostText;
            string val_42 = Localization.Localize(key:  -444831200, defaultValue:  -444831296, useSingularKey:  false);
            val_53 = "trv_vip_x_per_week";
            twelvegigs.Autopilot.AutopilotManager val_43 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_54 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance();
        }
        
            string val_44 = GetPromoCostForPackage(subPack:  1);
            string val_45 = System.String.Format(format:  -444831200, arg0:  -1897280256);
            val_51 = val_53;
        }
        
        if(val_52 != 0)
        {
                UnityEngine.GameObject val_47 = gameObject;
            SetActive(value:  false);
        }
        
        System.Action<System.Boolean> val_48 = new System.Action<System.Boolean>(object:  -444806064, method:  new IntPtr(3850136208));
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_12C = null;
    }
    protected override void InitStatusPopup()
    {
        mem[1152921512752116388] = 0;
        goto typeof(TRVSubscriptionPopup).__il2cppRuntimeField_E4;
    }
    public override void InitInfoPopup()
    {
        var val_10;
        float val_11;
        var val_12;
        var val_13;
        if(true == 1)
        {
            goto label_1;
        }
        
        if(true != 0)
        {
            goto label_2;
        }
        
        val_10 = "While you have a Golden Ticket, you earn double {0} and collect free gems every day";
        val_11 = "Golden";
        val_12 = "golden";
        goto label_4;
        label_1:
        val_10 = "While you have a Silver Ticket, you\'re awarded a number of free gems every day";
        val_11 = "Silver";
        val_12 = "silver";
        goto label_4;
        label_2:
        val_10 = "";
        val_11 = val_10;
        val_13 = val_10;
        label_4:
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -444552720, method:  new IntPtr(3079696048));
        static_value_021FACC8.AddListener(call:  162246656);
        string val_2 = 1098586544 + -1215233360(-1215233360);
        string val_3 = 1098586544 + -1215229168(-1215229168);
        string val_4 = Localization.Localize(key:  1098586544, defaultValue:  1098586544, useSingularKey:  false);
        string val_5 = 1098586544 + -1215192112(-1215192112);
        string val_6 = Localization.Localize(key:  1098586544, defaultValue:  1098586544, useSingularKey:  false);
        GameBehavior val_7 = App.getBehavior;
        string val_8 = System.String.Format(format:  1098586544, arg0:  0);
        string val_9 = Localization.Localize(key:  -1215109440, defaultValue:  -1215109792, useSingularKey:  false);
        "".__il2cppRuntimeField_18 + 28.SetActive(value:  true);
        this.SetActive(value:  false);
    }
    protected override void CollectAttemptResult(bool result, WGSubscriptionManager.collectResultStatus status)
    {
        int val_11;
        int val_16;
        int val_17;
        int val_18;
        int val_19;
        System.Delegate val_20;
        var val_21;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean, collectResultStatus> val_2 = new System.Action<System.Boolean, collectResultStatus>(object:  -444424336, method:  typeof(TRVSubscriptionPopup).__il2cppRuntimeField_F0);
        val_20 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_10;
        System.Delegate val_3 = System.Delegate.Remove(source:  val_20, value:  7507968);
        if(val_20 != 0)
        {
                if(val_20 == null)
        {
            goto label_6;
        }
        
        }
        
        val_20 = 0;
        label_6:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_10 = val_20;
        if(result == false)
        {
            goto label_7;
        }
        
        System.Action val_4 = new System.Action(object:  -444424336, method:  new IntPtr(3077999616));
        System.Delegate val_5 = System.Delegate.Combine(a:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_10, b:  7454720);
        val_21 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_10;
        if(val_21 != 0)
        {
                if(val_21 == null)
        {
            goto label_11;
        }
        
        }
        
        val_21 = 0;
        label_11:
        mem2[0] = val_21;
        Player val_6 = App.Player;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_9 = 0 - (promoDailyCoinsAmount(subPackage:  1152921504901095424));
        decimal val_10 = System.Decimal.op_Implicit(value:  -444436388);
        this.collectGemCollector.SetStatViewValue(instantValue:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_11, hi = R6, lo = R7, mid = SB}));
        Player val_14 = App.Player;
        decimal val_15 = System.Decimal.op_Implicit(value:  -444436404);
        this.collectGemCollector.Play(fromValue:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_11, hi = R6, lo = R7, mid = SB}), toValue:  new System.Decimal() {flags = val_17, hi = val_18, lo = val_19, mid = val_16}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        return;
        label_7:
        if(status == 1)
        {
                this.ShowInternetRequired(shouldReturn:  false);
            return;
        }
        
        this.ClosePopup();
    }
    public TRVSubscriptionPopup()
    {
    
    }
    private void <InitPromoPopup>b__6_0(bool result)
    {
        this.tryClickPurchase(connected:  result, subType:  1);
    }

}
