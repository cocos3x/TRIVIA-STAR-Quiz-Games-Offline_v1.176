using UnityEngine;
public class WFOEventRewardPopup : MonoBehaviour
{
    // Fields
    public System.Action OnCollectCallback;
    public System.Action OnCloseCallback;
    private UnityEngine.UI.Text eventNameText;
    private UnityEngine.UI.Image rewardIconBig;
    private UnityEngine.UI.Image rewardIconSmall;
    private UnityEngine.UI.Text rewardAmountText;
    private UnityEngine.UI.Button collectButton;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private GoldenCurrencyCollectAnimationInstantiator goldAnim;
    private WADPetFoodAnimationInstantiator foodAnim;
    private UnityEngine.Sprite rewIconCoins;
    private UnityEngine.Sprite rewIconGoldenCurrency;
    private UnityEngine.Sprite rewIconFood;
    private UnityEngine.Sprite rewIconCoinsBig;
    private UnityEngine.Sprite rewIconGoldenCurrencyBig;
    private UnityEngine.Sprite rewIconFoodBig;
    private RESEventRewardData rewardData;
    private string rewardSource;
    
    // Properties
    public UnityEngine.Transform rewardIconBigTransform { get; }
    
    // Methods
    public UnityEngine.Transform get_rewardIconBigTransform()
    {
        if(this.rewardIconBig != 0)
        {
                return this.rewardIconBig.transform;
        }
        
        return this.rewardIconBig.transform;
    }
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -374971536, method:  new IntPtr(3919970736));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -374875344, clipIndex:  0);
    }
    public void InitReward(string title, RESEventRewardData reward, string source = "", System.Action onCollectClicked, System.Action onClose)
    {
        System.Action val_5;
        System.Action val_6;
        UnityEngine.UI.Image val_7;
        UnityEngine.Sprite val_8;
        this.rewardData = reward;
        this.rewardSource = source;
        System.Delegate val_1 = System.Delegate.Combine(a:  this.OnCollectCallback, b:  onCollectClicked);
        val_5 = 0;
        if(this.OnCollectCallback != 0)
        {
                if(null != null)
        {
                val_5 = 0;
        }
        else
        {
                val_5 = this.OnCollectCallback;
        }
        
        }
        
        val_6 = this.OnCloseCallback;
        this.OnCollectCallback = val_5;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_6, b:  onClose);
        if(val_6 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_6 = 0;
        label_6:
        this.OnCloseCallback = val_6;
        if(this.rewardData.rewardType == 4)
        {
            goto label_8;
        }
        
        if(this.rewardData.rewardType == 3)
        {
            goto label_9;
        }
        
        if(this.rewardData.rewardType != 1)
        {
            goto label_10;
        }
        
        this.rewardIconBig.sprite = this.rewIconCoinsBig;
        val_7 = this.rewardIconSmall;
        val_8 = this.rewIconCoins;
        goto label_14;
        label_8:
        this.rewardIconBig.sprite = this.rewIconFoodBig;
        val_7 = this.rewardIconSmall;
        val_8 = this.rewIconFood;
        goto label_14;
        label_9:
        this.rewardIconBig.sprite = this.rewIconGoldenCurrencyBig;
        val_7 = this.rewardIconSmall;
        val_8 = this.rewIconGoldenCurrency;
        label_14:
        val_7.sprite = val_8;
        label_10:
        GameEcon val_3 = App.getGameEcon;
        string val_4 = reward.rewardQty.ToString(format:  null);
        if(this.rewardAmountText == 0)
        {
            
        }
    
    }
    private void OnCollectButtonClicked()
    {
        int val_5;
        int val_14;
        int val_15;
        int val_16;
        var val_27;
        int val_28;
        int val_29;
        GridCoinCollectAnimationInstantiator val_30;
        var val_31;
        System.Action val_32;
        System.Action val_33;
        var val_35;
        this.collectButton.interactable = false;
        if(this.rewardData.rewardType == 4)
        {
            goto label_3;
        }
        
        if(this.rewardData.rewardType == 3)
        {
            goto label_4;
        }
        
        if(this.rewardData.rewardType != 1)
        {
                return;
        }
        
        Player val_1 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = this.rewardData.rewardQty, hi = R7, lo = R8, mid = this.rewardData}, source:  this.rewardSource, subSource:  0, externalParams:  0, doTrack:  true);
        Player val_2 = App.Player;
        if(this.rewardData == 0)
        {
                val_28 = val_28;
            val_27 = val_27;
        }
        
        val_28 = val_28;
        val_27 = val_27;
        decimal val_3 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -374372036, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = this.rewardData.rewardQty, mid = val_28});
        Player val_4 = App.Player;
        this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_5}, toValue:  new System.Decimal() {flags = 52, mid = val_29}, textTickTime:  null, delayBeforeComplete:  null);
        val_30 = this.coinsAnim;
        val_31 = 1152921504614301696;
        val_32 = null;
        val_32 = new System.Action(object:  -374359984, method:  new IntPtr(3920541328));
        System.Delegate val_7 = System.Delegate.Combine(a:  this.coinsAnim.OnCompleteCallback, b:  7454720);
        val_33 = this.coinsAnim.OnCompleteCallback;
        if(val_33 != 0)
        {
                if(null == null)
        {
            goto label_19;
        }
        
        }
        
        val_33 = 0;
        label_19:
        this.coinsAnim.OnCompleteCallback = val_33;
        return;
        label_3:
        Player val_8 = App.Player;
        0.AddPetsFood(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = this.rewardData.rewardQty, hi = R7, lo = this.collectButton, mid = SB}), source:  this.rewardSource, subSource:  null, FoodSpentParams:  0, additionalParam:  0);
        Player val_10 = App.Player;
        Player val_12 = App.Player;
        decimal val_13 = System.Decimal.op_Implicit(value:  -374372036);
        this.foodAnim.Play(fromValue:  1 - (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.rewardData.rewardQty + (0)], hi = mem[this.rewardData.rewardQty + (4)], lo = mem[this.rewardData.rewardQty + (8)], mid = mem[this.rewardData.rewardQty + (12)]})), toValue:  new System.Decimal() {flags = val_15, hi = val_16, lo = val_14, mid = val_5}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        val_30 = this.foodAnim;
        goto label_31;
        label_4:
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_19 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.rewardData.rewardQty + (0)], hi = mem[this.rewardData.rewardQty + (4)], lo = mem[this.rewardData.rewardQty + (8)], mid = mem[this.rewardData.rewardQty + (12)]});
        Player val_20 = App.Player;
        Player val_22 = App.Player;
        decimal val_23 = System.Decimal.op_Implicit(value:  -374372036);
        this.goldAnim.Play(fromValue:  4 - (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.rewardData.rewardQty + (0)], hi = mem[this.rewardData.rewardQty + (4)], lo = mem[this.rewardData.rewardQty + (8)], mid = mem[this.rewardData.rewardQty + (12)]})), toValue:  new System.Decimal() {flags = val_15, hi = val_16, lo = val_14, mid = val_5}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        val_30 = this.goldAnim;
        label_31:
        val_31 = 1152921504614301696;
        val_32 = null;
        val_32 = new System.Action(object:  -374359984, method:  new IntPtr(3920541328));
        System.Delegate val_26 = System.Delegate.Combine(a:  this.goldAnim, b:  7454720);
        val_35 = this.goldAnim;
        if(val_35 != 0)
        {
                if(null == null)
        {
            goto label_47;
        }
        
        }
        
        val_35 = 0;
        label_47:
        mem2[0] = val_35;
    }
    private void CollectAndClose()
    {
        if(this.OnCollectCallback != 0)
        {
                this.OnCollectCallback.Invoke();
        }
        
        this.Close();
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -374045872, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(this.OnCloseCallback == 0)
        {
                return;
        }
        
        this.OnCloseCallback.Invoke();
    }
    public WFOEventRewardPopup()
    {
    
    }

}
