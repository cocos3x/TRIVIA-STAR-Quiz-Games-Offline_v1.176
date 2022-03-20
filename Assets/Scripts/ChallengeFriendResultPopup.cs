using UnityEngine;
public class ChallengeFriendResultPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text text_message;
    private UnityEngine.UI.Text text_reward;
    private UnityEngine.UI.Button button_lose;
    private UnityEngine.UI.Button button_collect;
    private CoinCurrencyCollectAnimationInstantiator coinsAnim;
    private System.Action callback_window_conclusion;
    private decimal playerReward;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1480783296, method:  new IntPtr(2814150784));
        this.button_collect.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1480783296, method:  new IntPtr(2814150784));
        this.button_lose.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(decimal reward, string message, System.Action windowConclusionCallback)
    {
        var val_6;
        this.playerReward = reward;
        mem[1152921511716151272] = reward.hi;
        mem[1152921511716151276] = reward.lo;
        mem[1152921511716151280] = reward.mid;
        string val_1 = this.playerReward.ToString();
        this.callback_window_conclusion = windowConclusionCallback;
        val_6 = null;
        val_6 = null;
        bool val_2 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = reward.flags, hi = reward.hi, lo = reward.lo, mid = reward.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        UnityEngine.GameObject val_3 = this.button_lose.gameObject;
        this.button_lose.SetActive(value:  val_2 ^ 1);
        UnityEngine.GameObject val_5 = this.button_collect.gameObject;
        this.button_collect.SetActive(value:  val_2);
    }
    private void OnClick()
    {
        decimal val_10;
        var val_11;
        CoinCurrencyCollectAnimationInstantiator val_12;
        CoinCurrencyCollectAnimationInstantiator val_13;
        int val_14;
        var val_15;
        val_10 = this.playerReward;
        val_11 = null;
        val_11 = null;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_10, hi = R6, lo = R7, mid = R8}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  -1480472256, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            if(this.callback_window_conclusion == 0)
        {
                return;
        }
        
            this.callback_window_conclusion.Invoke();
            return;
        }
        
        val_12 = 1152921504765685760;
        if(this.coinsAnim != 0)
        {
                val_13 = this.coinsAnim;
            System.Action val_4 = new System.Action(object:  -1480472256, method:  new IntPtr(2814461824));
            mem2[0] = null;
        }
        
        if(this.coinsAnim == 0)
        {
                return;
        }
        
        Player val_6 = App.Player;
        val_15 = 52;
        val_15 = val_15;
        decimal val_7 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1480484308, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = mem[this.playerReward + (0)], lo = mem[this.playerReward + (4)], mid = mem[this.playerReward + (8)]});
        val_14 = System.Decimal.op_Explicit(value:  new System.Decimal());
        Player val_9 = App.Player;
        val_12 = this.coinsAnim;
        val_10 = 7.286752E-44f;
        val_13 = 52;
        val_12.Play(fromValue:  val_14, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void OnCoinsAnimFinished()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1480335680, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(this.callback_window_conclusion == 0)
        {
                return;
        }
        
        this.callback_window_conclusion.Invoke();
    }
    public ChallengeFriendResultPopup()
    {
    
    }

}
