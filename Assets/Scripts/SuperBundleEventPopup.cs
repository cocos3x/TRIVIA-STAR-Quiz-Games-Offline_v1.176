using UnityEngine;
public class SuperBundleEventPopup : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.UI.Text> coinTexts;
    private System.Collections.Generic.List<UnityEngine.UI.Text> appleTexts;
    private UnityEngine.UI.Text percentageFreeText;
    private UnityEngine.UI.Text valueText;
    private UnityEngine.UI.Text openButtonText;
    private UnityEngine.UI.Text timerText;
    private UGUINetworkedButton openButton;
    private UnityEngine.UI.Button closeButton;
    private GridCoinCollectAnimationInstantiator coinAnimation;
    private GoldenCurrencyCollectAnimationInstantiator goldAnimation;
    private GemsCollectAnimationInstantiator gemAnimation;
    private decimal coinRewardAmount;
    private int appleRewardAmount;
    private System.DateTime dealEndTime;
    
    // Methods
    private void OnEnable()
    {
        var val_6;
        System.DateTime val_7;
        this.SetRewardAmounts();
        val_6 = null;
        val_7 = this.dealEndTime;
        val_6 = null;
        if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = val_7}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                System.Collections.IEnumerator val_2 = this.UpdateTimer();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -996969456);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.closeButton)) != false)
        {
                this.closeButton.m_OnClick.RemoveAllListeners();
            val_7 = null;
            val_7 = new UnityEngine.Events.UnityAction(object:  -996969456, method:  new IntPtr(3297972816));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        
        this.SetupReady();
    }
    private void SetupReady()
    {
        System.Action<System.Boolean> val_12;
        var val_12 = 29399202;
        val_12 = 6226860 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_1 = System.String.Format(format:  2124591920, arg0:  15282176);
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_2 = Localization.Localize(key:  -1122475424, defaultValue:  -1122475504, useSingularKey:  false);
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_3 = LocalPrice;
        string val_4 = System.String.Format(format:  1592589744, arg0:  -1122475424, arg1:  292597760);
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        System.DateTime val_5 = GetBundleExpireTime;
        this.dealEndTime = new System.DateTime();
        System.Action<System.Boolean> val_6 = new System.Action<System.Boolean>(object:  -996815472, method:  new IntPtr(3298126800));
        System.Delegate val_7 = System.Delegate.Combine(a:  this.openButton.OnConnectionClick, b:  7401472);
        val_12 = this.openButton.OnConnectionClick;
        if(val_12 != 0)
        {
                if(null == null)
        {
            goto label_16;
        }
        
        }
        
        val_12 = 0;
        label_16:
        this.openButton.OnConnectionClick = val_12;
        UnityEngine.GameObject val_8 = this.gameObject;
        if(this.activeInHierarchy == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_10 = this.UpdateTimer();
        UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  -996815472);
    }
    private void OnOpenButtonClick(bool result)
    {
        System.Action<System.Boolean> val_11;
        var val_12;
        System.Func<System.Boolean> val_14;
        var val_15;
        if(result == false)
        {
            goto label_1;
        }
        
        this.openButton.interactable = false;
        UnityEngine.GameObject val_1 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -996672752, method:  new IntPtr(3298268496));
        System.Delegate val_3 = System.Delegate.Combine(a:  7401472, b:  7401472);
        val_11 = SuperBundleEventHandler._Instance.OnPurchaseAttemptResult;
        if(val_11 != 0)
        {
                if(null == null)
        {
            goto label_9;
        }
        
        }
        
        val_11 = 0;
        label_9:
        SuperBundleEventHandler._Instance.OnPurchaseAttemptResult = val_11;
        SuperBundleEventHandler._Instance.TryPurchase();
        return;
        label_1:
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_6 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_7 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_8 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_12 = null;
        val_12 = null;
        val_14 = SuperBundleEventPopup.<>c.<>9__16_0;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<System.Boolean>(object:  SuperBundleEventPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3298269520));
            SuperBundleEventPopup.<>c.<>9__16_0 = val_14;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_14;
        val_15 = null;
        val_15 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_10 = this.gameObject;
        SLCWindow.CloseWindow(window:  -996672752, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnPurchaseAttemptResult(bool result)
    {
        int val_12;
        int val_13;
        int val_14;
        int val_15;
        int val_26;
        int val_30;
        int val_31;
        int val_32;
        SuperBundleEventPopup val_35;
        System.Action<System.Boolean> val_36;
        var val_37;
        System.Func<System.Boolean> val_39;
        var val_40;
        float val_41;
        var val_42;
        val_35 = this;
        var val_35 = 29396774;
        val_35 = 6229288 + val_35;
        if(val_35 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -996534128, method:  new IntPtr(3298268496));
        System.Delegate val_2 = System.Delegate.Remove(source:  7401472, value:  7401472);
        val_36 = SuperBundleEventHandler._Instance.OnPurchaseAttemptResult;
        if(val_36 != 0)
        {
                if(null == null)
        {
            goto label_5;
        }
        
        }
        
        val_36 = 0;
        label_5:
        SuperBundleEventHandler._Instance.OnPurchaseAttemptResult = val_36;
        if(result == false)
        {
            goto label_6;
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 == 0)
        {
            goto label_11;
        }
        
        System.Action val_5 = new System.Action(object:  -996534128, method:  new IntPtr(3298394832));
        mem2[0] = null;
        Player val_6 = App.Player;
        decimal val_7 = System.Decimal.op_Implicit(value:  -996546180);
        decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -996546196}, d2:  new System.Decimal() {flags = ???, hi = this.coinRewardAmount, lo = SuperBundleEventHandler._Instance});
        Player val_10 = App.Player;
        decimal val_11 = System.Decimal.op_Implicit(value:  -996546212);
        this.gemAnimation.Play(fromValue:  System.Decimal.op_Explicit(value:  new System.Decimal()), toValue:  new System.Decimal() {flags = val_13, hi = val_14, lo = val_15, mid = val_12}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  1069547520);
        goto label_20;
        label_6:
        GameBehavior val_16 = App.getBehavior;
        string val_18 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_19 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_20 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NO";
        val_37 = null;
        val_37 = null;
        val_39 = SuperBundleEventPopup.<>c.<>9__17_0;
        if(val_39 == 0)
        {
                val_39 = null;
            val_39 = new System.Func<System.Boolean>(object:  SuperBundleEventPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3298399952));
            SuperBundleEventPopup.<>c.<>9__17_0 = val_39;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_39;
        val_40 = null;
        val_41 = "purchase_failed_upper";
        goto label_60;
        label_11:
        System.Action val_22 = new System.Action(object:  -996534128, method:  new IntPtr(3298394832));
        this.coinAnimation.OnCompleteCallback = null;
        Player val_23 = App.Player;
        val_42 = 256;
        val_42 = val_42;
        decimal val_24 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -996546180, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = this.coinRewardAmount, lo = result, mid = ???});
        Player val_25 = App.Player;
        val_35 = val_35;
        this.coinAnimation.Play(fromValue:  new System.Decimal() {mid = val_26}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
        label_20:
        Player val_27 = App.Player;
        Player val_28 = App.Player;
        decimal val_29 = System.Decimal.op_Implicit(value:  -996546180);
        mem[1152921512200247488].Play(fromValue:  (5.605194E-45f) - mem[1152921512200247512], toValue:  new System.Decimal() {flags = val_31, hi = val_32, lo = val_30, mid = val_26}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  1069547520);
        return;
        label_60:
        0.SetupMessage(titleTxt:  -1349324784, messageTxt:  256, shownButtons:  1054454320, buttonTexts:  this.coinAnimation, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_34 = this.gameObject;
        SLCWindow.CloseWindow(window:  -996534128, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnCollectAnimationComplete()
    {
        this.Close();
    }
    private void SetRewardAmounts()
    {
        var val_4;
        var val_5;
        var val_4 = 29399846;
        val_4 = 6226216 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        decimal val_1 = System.Decimal.op_Implicit(value:  -996289408);
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        this.appleRewardAmount = SuperBundleEventHandler._Instance.goldReward;
        val_4 = 0;
        goto label_7;
        label_12:
        if(SuperBundleEventHandler._Instance.goldReward <= val_4)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + 0;
        string val_2 = new System.Decimal().ToString();
        val_4 = 1;
        label_7:
        if(val_4 < ((0 + 0) + 16))
        {
            goto label_12;
        }
        
        val_5 = 0;
        goto label_13;
        label_18:
        if(((0 + 0) + 16) <= val_5)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + 0;
        val_4 = mem[(0 + 0) + 16];
        val_4 = (0 + 0) + 16;
        string val_3 = this.appleRewardAmount.ToString();
        val_5 = 1;
        label_13:
        if(val_5 < val_4)
        {
            goto label_18;
        }
    
    }
    private void StartTimer()
    {
        System.Collections.IEnumerator val_1 = this.UpdateTimer();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -996148976);
    }
    private System.Collections.IEnumerator UpdateTimer()
    {
        object val_1 = new System.Object();
        typeof(SuperBundleEventPopup.<UpdateTimer>d__21).__il2cppRuntimeField_8 = 0;
        typeof(SuperBundleEventPopup.<UpdateTimer>d__21).__il2cppRuntimeField_10 = this;
    }
    private string GetDateString()
    {
        int val_3;
        long val_5;
        var val_22;
        var val_23;
        var val_25;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512200844536}, d2:  new System.DateTime() {dateData = this.dealEndTime});
        val_22 = null;
        val_22 = null;
        if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_5}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                val_23 = null;
            val_23 = null;
        }
        
        if(System.TimeSpan.Zero.Days >= 1)
        {
                val_25 = 1152921504619999232;
            val_3 = System.TimeSpan.Zero.Days;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_5 = System.TimeSpan.Zero.Hours;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            int val_11 = System.TimeSpan.Zero.Minutes;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            int val_12 = System.TimeSpan.Zero.Seconds;
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            string val_13 = System.String.Format(format:  -1366069552, args:  472754880);
            return;
        }
        
        if(System.TimeSpan.Zero.Hours >= 1)
        {
                val_3 = System.TimeSpan.Zero.Hours;
            val_5 = System.TimeSpan.Zero.Minutes;
            val_25 = null;
            int val_17 = System.TimeSpan.Zero.Seconds;
            string val_18 = System.String.Format(format:  -1662255760, arg0:  13152256, arg1:  13152256, arg2:  13152256);
            return;
        }
        
        val_25 = 1152921504619999232;
        val_3 = System.TimeSpan.Zero.Minutes;
        val_5 = System.TimeSpan.Zero.Seconds;
        string val_21 = System.String.Format(format:  -1120761280, arg0:  13152256, arg1:  13152256);
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -995812976, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public SuperBundleEventPopup()
    {
        this.coinTexts = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.appleTexts = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }

}
