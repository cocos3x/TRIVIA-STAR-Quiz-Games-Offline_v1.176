using UnityEngine;
public class WGFOMOSalePopup : MonoBehaviour
{
    // Fields
    private bool madePurchase;
    private UGUINetworkedButton button;
    private UnityEngine.UI.Button CloseBtn;
    private UnityEngine.UI.Text timeRemaining;
    private UnityEngine.UI.Text text_coins_amount;
    private UnityEngine.UI.Text text_purchase_price;
    private GridCoinCollectAnimationInstantiator coinAnimator;
    private CurrencyCollectAnimationInstantiator gemAnimator;
    private bool isOOC;
    private float remainingTime;
    
    // Methods
    public void Setup(bool outOfCurrency)
    {
        this.isOOC = outOfCurrency;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-717217552) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StopTimer();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_5 = public static TRVGameplayUI MonoSingleton<TRVGameplayUI>::get_Instance().__il2cppRuntimeField_10.TimeRemaining();
        this.remainingTime = public static TRVGameplayUI MonoSingleton<TRVGameplayUI>::get_Instance().__il2cppRuntimeField_10;
    }
    private void Start()
    {
        UnityEngine.UI.Text val_19;
        bool val_20;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -44479648);
        System.Action val_3 = new System.Action(object:  -44479648, method:  new IntPtr(4250423712));
        System.Delegate val_4 = System.Delegate.Combine(a:  this.timeRemaining, b:  7454720);
        val_19 = this.timeRemaining;
        if(val_19 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_19 = 0;
        label_4:
        this.timeRemaining = val_19;
        System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  -44479648, method:  new IntPtr(4250428832));
        var val_19 = 28350886;
        this.button.OnConnectionClick = null;
        val_19 = 7274904 + val_19;
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        FOMOPackEventHandler.<Instance>k__BackingField.SetTimeShown();
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        System.TimeSpan val_6 = timeRemaining;
        double val_7 = ???.TotalSeconds;
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -44479648, method:  new IntPtr(4250438048));
        this.CloseBtn.m_OnClick.AddListener(call:  162246656);
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_9 = FOMOPackEventHandler.<Instance>k__BackingField.GetAmount;
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_10 = FOMOPackEventHandler.<Instance>k__BackingField.GetPrice;
        val_20 = FOMOPackEventHandler.<Instance>k__BackingField;
        if(this.coinAnimator != 0)
        {
                UnityEngine.GameObject val_12 = this.coinAnimator.gameObject;
            GameBehavior val_13 = App.getBehavior;
            val_20 = System.String.op_Equality(a:  null, b:  2129282688);
            this.coinAnimator.SetActive(value:  val_20);
        }
        
        if(this.gemAnimator == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_16 = this.gemAnimator.gameObject;
        GameBehavior val_17 = App.getBehavior;
        this.gemAnimator.SetActive(value:  System.String.op_Equality(a:  null, b:  -1930648496));
    }
    private void OnPurchaseClicked(bool success)
    {
        var val_9;
        var val_10;
        if(success != false)
        {
                this.button.interactable = false;
            System.Action<System.Boolean, System.Decimal> val_1 = new System.Action<System.Boolean, System.Decimal>(object:  -44320544, method:  new IntPtr(4250620704));
            FOMOPackEventHandler.<Instance>k__BackingField.purchaseResult = null;
            FOMOPackEventHandler.<Instance>k__BackingField.TryMakePurchase();
            return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  false);
        GameBehavior val_3 = App.getBehavior;
        string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        System.Func<System.Boolean> val_8 = new System.Func<System.Boolean>(object:  -44320544, method:  new IntPtr(4250621728));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_9 = null;
        val_10 = 0;
        val_10.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void UpdateTimeRemaining()
    {
        long val_2;
        var val_3;
        var val_14;
        float val_14 = 6.485675E-38f;
        val_14 = 7277744 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        System.TimeSpan val_1 = timeRemaining;
        double val_4 = val_2.TotalSeconds;
        string val_5 = Localization.Localize(key:  -44224256, defaultValue:  -44224352, useSingularKey:  false);
        val_14 = "limited_time_upper";
        if((FOMOPackEventHandler.<Instance>k__BackingField) > 0)
        {
                if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
            System.TimeSpan val_6 = timeRemaining;
            string val_7 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_2}, formatted:  true);
            string val_8 = System.String.Format(format:  -1026374368, arg0:  -44224256, arg1:  val_2);
            if(this.timeRemaining != 0)
        {
                return;
        }
        
            return;
        }
        
        val_3 = 0;
        val_2 = 0;
        System.TimeSpan val_9 = new System.TimeSpan(hours:  0, minutes:  0, seconds:  0);
        string val_10 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_9._ticks}, formatted:  true);
        string val_11 = System.String.Format(format:  -1026374368, arg0:  -44224256, arg1:  val_9._ticks);
        val_14 = "{0}: {1}";
        UnityEngine.GameObject val_12 = this.gameObject;
        object val_13 = this.GetComponent<System.Object>();
        this.enabled = false;
        this.Close();
    }
    private void OnPurchaseResponse(bool result, decimal amount)
    {
        int val_10;
        int val_30;
        int val_31;
        int val_32;
        WGFOMOSalePopup val_33;
        int val_34;
        int val_35;
        int val_36;
        GridCoinCollectAnimationInstantiator val_37;
        var val_38;
        var val_39;
        val_33 = this;
        val_34 = amount.mid;
        val_35 = amount.hi;
        val_36 = amount.flags;
        if(result == false)
        {
            goto label_1;
        }
        
        this.madePurchase = true;
        GameBehavior val_1 = App.getBehavior;
        if(((System.String.op_Equality(a:  null, b:  2129282688)) == false) || (this.coinAnimator == 0))
        {
            goto label_9;
        }
        
        UnityEngine.GameObject val_4 = this.coinAnimator.gameObject;
        this.coinAnimator.SetActive(value:  true);
        System.Action val_5 = new System.Action(object:  -44048208, method:  new IntPtr(4250872560));
        this.coinAnimator.OnCompleteCallback = null;
        Player val_6 = App.Player;
        var val_7 = 0 + 60;
        decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -44060260, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256, hi = val_36, lo = val_35, mid = amount.lo});
        Player val_9 = App.Player;
        val_37 = this.coinAnimator;
        val_35 = 7.286752E-44f;
        val_33 = 52;
        val_36 = 256;
        val_37.Play(fromValue:  new System.Decimal() {mid = val_10}, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
        return;
        label_1:
        GameBehavior val_11 = App.getBehavior;
        string val_13 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_14 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        val_35 = null;
        string val_15 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_34 = null;
        System.Func<System.Boolean> val_16 = new System.Func<System.Boolean>(object:  -44048208, method:  new IntPtr(4250877680));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_36 = "purchase_failed_upper";
        val_38 = null;
        val_38 = null;
        val_39 = 0;
        if(val_39 == 0)
        {
                val_39 = 0;
        }
        
        val_39.SetupMessage(titleTxt:  -1349324784, messageTxt:  -1349324672, shownButtons:  1054454320, buttonTexts:  val_35, showClose:  false, buttonCallbacks:  val_34, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        val_37 = 1152921504765685760;
        if((-44048208) == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_18 = this.gameObject;
        if((-44048208) == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_20 = this.gameObject;
        this.SetActive(value:  false);
        return;
        label_9:
        GameBehavior val_21 = App.getBehavior;
        val_37 = 0;
        if((System.String.op_Equality(a:  null, b:  -1930648496)) == false)
        {
                return;
        }
        
        val_37 = this.gemAnimator;
        if(val_37 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_24 = this.gemAnimator.gameObject;
        this.gemAnimator.SetActive(value:  true);
        System.Action val_25 = new System.Action(object:  -44048208, method:  new IntPtr(4250872560));
        this.gemAnimator.OnCompleteCallback = null;
        val_33 = this.gemAnimator;
        Player val_26 = App.Player;
        Player val_28 = App.Player;
        val_37 = 0;
        decimal val_29 = System.Decimal.op_Implicit(value:  -44060260);
        val_33.Play(fromValue:  0 - (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_36, hi = val_35, mid = val_34})), toValue:  new System.Decimal() {flags = val_31, hi = val_32, lo = val_30, mid = val_10}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void OnFailure()
    {
        System.TimeSpan val_1 = timeRemaining;
        double val_2 = ???.TotalSeconds;
        if((FOMOPackEventHandler.<Instance>k__BackingField) <= 0)
        {
                return;
        }
        
        if(this.isOOC == true)
        {
                this.isOOC = 1;
        }
        
        bool val_3 = FOMOPackEventHandler.<Instance>k__BackingField.TryShowPopup(isOOC:  true);
    }
    private void Close()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-717217552) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ContinueTimer(duration:  null);
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGFOMOSalePopup()
    {
    
    }
    private void <Start>b__11_0()
    {
        this.Close();
    }
    private bool <OnPurchaseClicked>b__12_0()
    {
        this.OnFailure();
        return true;
    }
    private bool <OnPurchaseResponse>b__14_0()
    {
        this.OnFailure();
        return true;
    }

}
