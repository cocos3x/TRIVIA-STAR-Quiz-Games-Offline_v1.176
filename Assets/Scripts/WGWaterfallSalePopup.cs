using UnityEngine;
public class WGWaterfallSalePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text titleTxt;
    private UnityEngine.UI.Text buyBtnTxt;
    private UnityEngine.UI.Text valueTxt;
    private UnityEngine.UI.Text descriptionTxt;
    private UnityEngine.UI.Button CloseBtn;
    private UGUINetworkedButton BuyBtn;
    private TimerText timer;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    
    // Methods
    private void Start()
    {
        this.SetupPopup();
    }
    private void SetupPopup()
    {
        var val_20;
        var val_21;
        var val_22;
        System.Action val_23;
        var val_20 = 29577455;
        val_20 = 6048332 + val_20;
        if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
        val_20 = null;
        val_20 = null;
        if(App.game == 1)
        {
            goto label_12;
        }
        
        if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
        val_21 = null;
        val_21 = null;
        if(App.game == 4)
        {
            goto label_12;
        }
        
        if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        if(App.game != 18)
        {
            goto label_18;
        }
        
        label_12:
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_2 = GetCoins();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = GetPrice();
        label_45:
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_6 = GetValue();
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.timer.SetTime(value:  GetSecondsRemainingForOffer());
        this.timer.countUp = false;
        this.timer.Run();
        System.Action val_9 = new System.Action(object:  81521008, method:  new IntPtr(81472192));
        System.Delegate val_10 = System.Delegate.Combine(a:  this.timer.onCountDownComplete, b:  7454720);
        val_23 = this.timer.onCountDownComplete;
        if(val_23 != 0)
        {
                if(null == null)
        {
            goto label_36;
        }
        
        }
        
        val_23 = 0;
        label_36:
        this.timer.onCountDownComplete = val_23;
        UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  81521008, method:  new IntPtr(81481408));
        this.CloseBtn.m_OnClick.AddListener(call:  162246656);
        System.Action<System.Boolean> val_12 = new System.Action<System.Boolean>(object:  81521008, method:  new IntPtr(81486528));
        this.BuyBtn.OnConnectionClick = null;
        System.Action val_13 = new System.Action(object:  81521008, method:  new IntPtr(81491648));
        this.coinsAnimControl.OnCompleteCallback = null;
        return;
        label_18:
        string val_14 = Localization.Localize(key:  81492800, defaultValue:  81492672, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_16 = GetCoins();
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_18 = GetPrice();
        string val_19 = System.String.Format(format:  81492800, arg0:  -832344720, arg1:  -832344720);
        goto label_45;
    }
    public void AnimateCoins(int coinsPurchased)
    {
        int val_5;
        Player val_1 = App.Player;
        decimal val_2 = System.Decimal.op_Implicit(value:  81678300);
        decimal val_3 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 81678284, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_4 = App.Player;
        this.coinsAnimControl.Play(fromValue:  new System.Decimal() {mid = val_5}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void OnCoinsAnimFinished()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  81806448, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  81918448, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGWaterfallSalePopup()
    {
    
    }
    private void <SetupPopup>b__9_2()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  82142448, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void <SetupPopup>b__9_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  82254448, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void <SetupPopup>b__9_1(bool success)
    {
        var val_9;
        System.Func<System.Boolean> val_11;
        var val_12;
        if(success != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BuyWaterfallSpecial();
            this.BuyBtn.interactable = false;
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        string val_4 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_5 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_6 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_9 = null;
        val_9 = null;
        val_11 = WGWaterfallSalePopup.<>c.<>9__9_3;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Func<System.Boolean>(object:  WGWaterfallSalePopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(82346544));
            WGWaterfallSalePopup.<>c.<>9__9_3 = val_11;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_11;
        val_12 = null;
        val_12 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  82371568, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
