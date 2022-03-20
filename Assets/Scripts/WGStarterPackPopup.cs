using UnityEngine;
public class WGStarterPackPopup : MonoBehaviour
{
    // Fields
    private bool madePurchase;
    private UGUINetworkedButton button;
    private UnityEngine.UI.Text timeRemaining;
    private UnityEngine.UI.Text text_coins_amount;
    private UnityEngine.UI.Text text_purchase_price;
    private UnityEngine.UI.Text text_dollar_value;
    private GridCoinCollectAnimationInstantiator coinAnimator;
    
    // Methods
    private void Start()
    {
        UnityEngine.UI.Text val_15;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  64576880);
        System.Action val_3 = new System.Action(object:  64576880, method:  new IntPtr(64538544));
        System.Delegate val_4 = System.Delegate.Combine(a:  this.text_coins_amount, b:  7454720);
        val_15 = this.text_coins_amount;
        if(val_15 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_15 = 0;
        label_4:
        this.text_coins_amount = val_15;
        System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  64576880, method:  new IntPtr(64543664));
        this.button.OnConnectionClick = null;
        CPlayerPrefs.SetInt(key:  63315856, val:  1);
        WGStarterPackController.SetTimeShown();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.TimeSpan val_7 = timeRemaining;
        double val_8 = ???.TotalSeconds;
        PurchaseModel val_9 = WGStarterPackController.GetStarterPack();
        decimal val_10 = Credits;
        string val_11 = ToString(format:  -1774412176);
        string val_12 = Localization.Localize(key:  -1528659216, defaultValue:  -1528659376, useSingularKey:  false);
        string val_13 = System.String.Format(format:  1592589744, arg0:  64564824, arg1:  -1528659216);
        string val_14 = this.LocalPrice;
        if(this.text_purchase_price != 0)
        {
                return;
        }
    
    }
    private void OnPurchaseClicked(bool success)
    {
        var val_12;
        var val_13;
        if(success != false)
        {
                this.button.interactable = false;
            Player val_1 = App.Player;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean, System.Decimal> val_3 = new System.Action<System.Boolean, System.Decimal>(object:  64711408, method:  new IntPtr(64685360));
            public static WGStarterPackController MonoSingleton<WGStarterPackController>::get_Instance().__il2cppRuntimeField_14 = null;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TryMakePurchase();
            return;
        }
        
        UnityEngine.GameObject val_5 = this.gameObject;
        this.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
        string val_8 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_9 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_10 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        System.Func<System.Boolean> val_11 = new System.Func<System.Boolean>(object:  64711408, method:  new IntPtr(64686384));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_12 = null;
        val_13 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void UpdateTimeRemaining()
    {
        long val_3;
        var val_4;
        var val_13;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.TimeSpan val_2 = timeRemaining;
        val_13 = 0;
        double val_5 = val_3.TotalSeconds;
        if((public static WGStarterPackController MonoSingleton<WGStarterPackController>::get_Instance()) > 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.TimeSpan val_7 = timeRemaining;
            string val_8 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_3}, formatted:  true);
            if(this.timeRemaining != 0)
        {
                return;
        }
        
            return;
        }
        
        val_4 = val_13;
        val_3 = val_13;
        System.TimeSpan val_9 = new System.TimeSpan(hours:  0, minutes:  0, seconds:  0);
        string val_10 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_9._ticks}, formatted:  true);
        val_13 = val_9._ticks;
        UnityEngine.GameObject val_11 = this.gameObject;
        object val_12 = this.GetComponent<System.Object>();
        this.enabled = false;
        this.Close();
    }
    private void OnPurchaseResponse(bool result, decimal coins)
    {
        int val_8;
        int val_19;
        int val_20;
        int val_21;
        int val_22;
        int val_23;
        var val_24;
        var val_25;
        val_19 = coins.mid;
        val_20 = coins.hi;
        val_21 = coins.lo;
        val_22 = coins.flags;
        if(result != false)
        {
                this.madePurchase = true;
            val_23 = 1152921504892043264;
            Player val_1 = App.Player;
            0.RemovedAds = true;
            if(this.coinAnimator == 0)
        {
                return;
        }
        
            UnityEngine.GameObject val_3 = this.coinAnimator.gameObject;
            this.coinAnimator.SetActive(value:  true);
            System.Action val_4 = new System.Action(object:  64966128, method:  new IntPtr(64935984));
            this.coinAnimator.OnCompleteCallback = null;
            val_20 = this.coinAnimator;
            Player val_5 = App.Player;
            decimal val_6 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 64954076, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = val_22, lo = val_20, mid = val_21});
            Player val_7 = App.Player;
            val_20.Play(fromValue:  new System.Decimal() {mid = val_8}, toValue:  new System.Decimal() {hi = val_23, lo = val_19, mid = val_21}, textTickTime:  null, delayBeforeComplete:  null);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_10 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_11 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_12 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        val_20 = null;
        string val_13 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_22 = null;
        System.Func<System.Boolean> val_14 = new System.Func<System.Boolean>(object:  64966128, method:  new IntPtr(64941104));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_21 = "purchase_failed_upper";
        val_24 = null;
        val_24 = null;
        val_25 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        if(val_25 == 0)
        {
                val_25 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        }
        
        SetupMessage(titleTxt:  -1349324784, messageTxt:  -1349324672, shownButtons:  1054454320, buttonTexts:  val_20, showClose:  false, buttonCallbacks:  val_22, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        val_23 = 1152921504765685760;
        if(64966128 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_16 = this.gameObject;
        if(64966128 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_18 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnFailure()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.TimeSpan val_2 = timeRemaining;
        double val_3 = ???.TotalSeconds;
        if((public static WGStarterPackController MonoSingleton<WGStarterPackController>::get_Instance()) > 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_8 = ShowUGUIMonolith<System.Object>(showNext:  true);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_18 = 0;
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_20 = 0;
    }
    private void Close()
    {
        if(this.madePurchase != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  true);
            public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_18 = 0;
            public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_20 = 0;
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGStarterPackPopup()
    {
    
    }
    private bool <OnPurchaseClicked>b__8_0()
    {
        this.OnFailure();
        return true;
    }
    private bool <OnPurchaseResponse>b__10_0()
    {
        this.OnFailure();
        return true;
    }

}
