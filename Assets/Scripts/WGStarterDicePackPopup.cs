using UnityEngine;
public class WGStarterDicePackPopup : MonoBehaviour
{
    // Fields
    private UGUINetworkedButton purchaseButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text timeRemaining;
    private UnityEngine.UI.Text text_coins_amount;
    private UnityEngine.UI.Text text_dice_amount;
    private UnityEngine.UI.Text text_purchase_price;
    private UnityEngine.UI.Text text_dollar_value;
    private GridCoinCollectAnimationInstantiator coinAnim;
    private DiceRollAnimationInstantiator diceAnim;
    private PurchaseModel starterPack;
    private FrameSkipper frameSkipper;
    
    // Methods
    private void Awake()
    {
        System.Action<System.Boolean> val_4;
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  59186176, method:  new IntPtr(59151936));
        System.Delegate val_2 = System.Delegate.Combine(a:  this.purchaseButton.OnConnectionClick, b:  7401472);
        val_4 = this.purchaseButton.OnConnectionClick;
        if(val_4 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        label_4:
        this.purchaseButton.OnConnectionClick = val_4;
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  59186176, method:  new IntPtr(59161152));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        var val_10 = 25600312;
        val_10 = 10025480 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        PurchaseModel val_1 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetStarterDicePack();
        this.starterPack = SnakesAndLaddersEventHandler.<Instance>k__BackingField;
        decimal val_2 = Credits;
        string val_3 = ToString();
        decimal val_4 = DiceRolls;
        string val_5 = ToString();
        string val_6 = this.starterPack.LocalPrice;
        UnityEngine.GameObject val_7 = this.gameObject;
        UnityEngine.UI.LayoutElement val_8 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  59336064);
        this.frameSkipper = this;
        System.Action val_9 = new System.Action(object:  59336064, method:  new IntPtr(59311040));
        this.text_coins_amount = null;
    }
    private void OnPurchaseClicked(bool success)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Func<System.Boolean> val_15;
        var val_16;
        val_10 = this;
        GameBehavior val_1 = App.getBehavior;
        val_11 = 0;
        if(val_11 == 0)
        {
            goto label_5;
        }
        
        if(success == false)
        {
            goto label_6;
        }
        
        this.purchaseButton.interactable = false;
        System.Action<System.Boolean, TRVQuizProgress> val_2 = new System.Action<System.Boolean, TRVQuizProgress>(object:  59479808, method:  new IntPtr(59448640));
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.AddPurchaseCompleteListener(purchaseCompleteAction:  7507968);
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.TryPurchase(purchase:  this.starterPack);
        return;
        label_5:
        val_12 = val_10;
        goto label_12;
        label_6:
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_13 = null;
        val_13 = null;
        val_15 = WGStarterDicePackPopup.<>c.<>9__13_0;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Func<System.Boolean>(object:  WGStarterDicePackPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(59454784));
            WGStarterDicePackPopup.<>c.<>9__13_0 = val_15;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_15;
        val_16 = null;
        val_16 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        val_12 = val_10;
        label_12:
        UnityEngine.GameObject val_9 = this.gameObject;
        SLCWindow.CloseWindow(window:  59479808, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnPurchaseComplete(bool success, PurchaseModel purchase)
    {
        if((System.String.op_Inequality(a:  purchase.id, b:  this.starterPack.id)) != false)
        {
                return;
        }
        
        if(success != false)
        {
                this.OnPurchaseSuccess();
            return;
        }
        
        this.purchaseButton.interactable = true;
    }
    private void OnPurchaseSuccess()
    {
        int val_7;
        int val_8;
        int val_9;
        int val_10;
        var val_14;
        System.Action val_16;
        float val_14 = public System.Int32 System.Comparison<UnityEngine.Playables.Playable>::Invoke(UnityEngine.Playables.Playable x, UnityEngine.Playables.Playable y);
        val_14 = 10027748 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.MarkStarterPackPurchased();
        System.Action val_1 = new System.Action(object:  59774464, method:  new IntPtr(59733056));
        System.Delegate val_2 = System.Delegate.Combine(a:  SnakesAndLaddersEventHandler.<Instance>k__BackingField, b:  7454720);
        val_14 = SnakesAndLaddersEventHandler.<Instance>k__BackingField;
        if(val_14 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_14 = 0;
        label_6:
        mem2[0] = val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        decimal val_4 = DiceRolls;
        decimal val_6 = System.Decimal.op_Implicit(value:  59762396);
        this.diceAnim.Play(fromValue:  (SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetDiceBalance()) - (System.Decimal.op_Explicit(value:  new System.Decimal())), toValue:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_8, mid = val_7}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        System.Action val_12 = new System.Action(object:  59774464, method:  new IntPtr(59161152));
        System.Delegate val_13 = System.Delegate.Combine(a:  this.coinAnim.OnCompleteCallback, b:  7454720);
        val_16 = this.coinAnim.OnCompleteCallback;
        if(val_16 != 0)
        {
                if(null == null)
        {
            goto label_16;
        }
        
        }
        
        val_16 = 0;
        label_16:
        this.coinAnim.OnCompleteCallback = val_16;
    }
    private void UpdateTimeLeft()
    {
        var val_2;
        var val_13;
        var val_14;
        var val_15;
        val_13 = this;
        var val_13 = 25597268;
        val_13 = 10028524 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        System.TimeSpan val_1 = GetStarterPackTimeLeft();
        double val_4 = val_2.TotalSeconds;
        val_14;
        string val_5 = Localization.Localize(key:  -44224256, defaultValue:  -44224352, useSingularKey:  false);
        val_15 = "limited_time_upper";
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) > 0)
        {
                string val_7 = val_2.Minutes.ToString(format:  -1827641632);
            string val_9 = val_2.Seconds.ToString(format:  -1827641632);
            string val_10 = System.String.Format(format:  59887040, arg0:  -44224256, arg1:  59907276, arg2:  59907276);
            if(this.timeRemaining != 0)
        {
                return;
        }
        
            return;
        }
        
        string val_11 = System.String.Format(format:  -1026374368, arg0:  -44224256, arg1:  -52158368);
        val_15 = "{0}: {1}";
        this.frameSkipper.updateLogic = 0;
        this.frameSkipper.enabled = false;
        UnityEngine.GameObject val_12 = this.gameObject;
        SLCWindow.CloseWindow(window:  59919328, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  60043616, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGStarterDicePackPopup()
    {
    
    }
    private void <OnPurchaseSuccess>b__15_0()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        Player val_1 = App.Player;
        decimal val_2 = Credits;
        decimal val_3 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 60267836, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        this.coinAnim.Set(instantValue:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_7});
        Player val_8 = App.Player;
        this.coinAnim.Play(fromValue:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_7}, toValue:  new System.Decimal() {mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
    }

}
