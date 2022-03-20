using UnityEngine;
public class BonusGameSlotMachinePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button mainButton;
    private UnityEngine.UI.Text mainButtonText;
    private UnityEngine.UI.Text amountText;
    private UnityEngine.GameObject coinIcon;
    private UnityEngine.GameObject appleIcon;
    private SlotMachineReel amountReel1;
    private SlotMachineReel amountReel2;
    private SlotMachineReel typeReel;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private GoldenCurrencyCollectAnimationInstantiator starsAnim;
    private bool hasPrize;
    private int prizeAmount;
    private BonusGameSlotMachineRewardType rewardType;
    public string trackEventSource;
    public System.Action OnRewarded;
    private static GameEventRewardType qaHackFlagAwardType;
    
    // Properties
    public static GameEventRewardType QAHACK_ForceAwardType { get; set; }
    
    // Methods
    public void SetOnClose(System.Action onClose)
    {
        UnityEngine.UI.Text val_5;
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        if(this != 0)
        {
                System.Delegate val_3 = System.Delegate.Combine(a:  this.amountText, b:  onClose);
            val_5 = this.amountText;
        }
        else
        {
                System.Delegate val_4 = System.Delegate.Combine(a:  this.amountText, b:  onClose);
            val_5 = this.amountText;
        }
        
        if(val_5 != 0)
        {
                if(null == null)
        {
            goto label_5;
        }
        
        }
        
        val_5 = 0;
        label_5:
        this.amountText = val_5;
    }
    public void OnButtonPressed()
    {
        if(this.hasPrize != false)
        {
                this.OnCollectPressed();
            return;
        }
        
        this.SpinReels();
    }
    private void OnEnable()
    {
        string val_1 = Localization.Localize(key:  -1523150864, defaultValue:  -1523150944, useSingularKey:  false);
        if(this.mainButtonText == 0)
        {
            
        }
    
    }
    private void SpinReels()
    {
        var val_15;
        DG.Tweening.TweenCallback val_17;
        var val_18;
        object val_1 = new System.Object();
        typeof(BonusGameSlotMachinePopup.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = this;
        this.mainButton.interactable = false;
        SlotMachineEconomy val_2 = new SlotMachineEconomy();
        float val_3 = UnityEngine.Random.Range(min:  null, max:  null);
        if(this.mainButton >= 0)
        {
                0 = 1;
        }
        
        this.rewardType = 1;
        CompanyDevices val_4 = CompanyDevices.Instance;
        val_15 = 0;
        if(0.CompanyDevice() == false)
        {
            goto label_16;
        }
        
        GameEventRewardType val_6 = BonusGameSlotMachinePopup.QAHACK_ForceAwardType;
        if(null == 0)
        {
            goto label_16;
        }
        
        GameEventRewardType val_7 = BonusGameSlotMachinePopup.QAHACK_ForceAwardType;
        if(null != 1)
        {
            goto label_12;
        }
        
        this.rewardType = 0;
        goto label_18;
        label_12:
        GameEventRewardType val_8 = BonusGameSlotMachinePopup.QAHACK_ForceAwardType;
        if(null != 2)
        {
            goto label_16;
        }
        
        this.rewardType = 1;
        goto label_17;
        label_16:
        if(this.rewardType == 0)
        {
            goto label_18;
        }
        
        if(this.rewardType != 1)
        {
            goto label_19;
        }
        
        label_17:
        val_15 = 0;
        int val_9 = GetStarReward();
        goto label_21;
        label_18:
        val_15 = 0;
        label_21:
        this.prizeAmount = GetCoinReward();
        label_19:
        typeof(BonusGameSlotMachinePopup.<>c__DisplayClass18_0).__il2cppRuntimeField_14 = 8;
        typeof(BonusGameSlotMachinePopup.<>c__DisplayClass18_0).__il2cppRuntimeField_C = 2;
        if(this.prizeAmount < 100)
        {
                this.amountReel1.SpinToIndex(targetIndex:  429496728, extraRounds:  1, callBack:  0);
            val_17 = null;
            val_18 = 1152921511673763280;
        }
        else
        {
                this.amountReel1.SpinToIndex(targetIndex:  0 + 0, extraRounds:  1, callBack:  0);
            val_17 = null;
            val_18 = 1152921511673764304;
        }
        
        val_17 = new DG.Tweening.TweenCallback(object:  309903360, method:  new IntPtr(2771950032));
        DG.Tweening.Tween val_13 = DG.Tweening.DOVirtual.DelayedCall(delay:  50f, callback:  1041865114, ignoreTimeScale:  false);
        typeof(BonusGameSlotMachinePopup.<>c__DisplayClass18_0).__il2cppRuntimeField_10 = 0;
        BonusGameSlotMachineRewardType val_16 = this.rewardType;
        val_16 = val_16 >> 5;
        typeof(BonusGameSlotMachinePopup.<>c__DisplayClass18_0).__il2cppRuntimeField_10 = val_16;
        DG.Tweening.TweenCallback val_14 = new DG.Tweening.TweenCallback(object:  309903360, method:  new IntPtr(2771955152));
        DG.Tweening.Tween val_15 = DG.Tweening.DOVirtual.DelayedCall(delay:  50f, callback:  1050253722, ignoreTimeScale:  false);
        this.hasPrize = true;
    }
    private void OnSpinPressed()
    {
        this.SpinReels();
    }
    private void OnCollectPressed()
    {
        int val_3;
        int val_10;
        int val_23;
        int val_24;
        int val_25;
        GridCoinCollectAnimationInstantiator val_26;
        int val_27;
        int val_28;
        int val_29;
        System.Delegate val_30;
        this.mainButton.interactable = false;
        if(this.rewardType != 1)
        {
                if(this.rewardType != 0)
        {
                return;
        }
        
            Player val_1 = App.Player;
            decimal val_2 = System.Decimal.op_Implicit(value:  -1522711556);
            0.AddCredits(amount:  new System.Decimal() {mid = val_3}, source:  this.trackEventSource, subSource:  "Bonus Game Slot Machine", externalParams:  0, doTrack:  true);
            if(this.OnRewarded != 0)
        {
                this.OnRewarded.Invoke();
        }
        
            System.Action val_4 = new System.Action(object:  -1522699504, method:  new IntPtr(2772217168));
            this.coinsAnim.OnCompleteCallback = null;
            val_26 = this.coinsAnim;
            Player val_5 = App.Player;
            var val_6 = 0 + 60;
            decimal val_7 = System.Decimal.op_Implicit(value:  -1522711556);
            decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1522711572, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256});
            Player val_9 = App.Player;
            val_26.Play(fromValue:  new System.Decimal() {mid = val_10}, toValue:  new System.Decimal() {hi = val_27, lo = val_28, mid = val_29}, textTickTime:  null, delayBeforeComplete:  null);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_12 = this.gameObject;
        object val_13 = this.GetComponent<System.Object>();
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_29 = 1152921504614301696;
        System.Action val_15 = new System.Action(object:  -2101040096, method:  new IntPtr(2772230480));
        val_30 = this.amountText;
        System.Delegate val_16 = System.Delegate.Combine(a:  val_30, b:  7454720);
        if(val_30 != 0)
        {
                if(null == null)
        {
            goto label_27;
        }
        
        }
        
        val_30 = 0;
        label_27:
        this.amountText = val_30;
        if(this.OnRewarded != 0)
        {
                this.OnRewarded.Invoke();
        }
        
        DG.Tweening.TweenCallback val_17 = new DG.Tweening.TweenCallback(object:  -1522699504, method:  new IntPtr(2772217168));
        DG.Tweening.Tween val_18 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1073741824, ignoreTimeScale:  false);
        mem2[0] = new System.Action(object:  -1522699504, method:  new IntPtr(2772217168));
        Player val_20 = App.Player;
        val_26 = this.prizeAmount;
        val_27 = 4;
        Player val_21 = App.Player;
        val_28 = 0;
        decimal val_22 = System.Decimal.op_Implicit(value:  -1522711556);
        this.starsAnim.Play(fromValue:  val_27 - val_26, toValue:  new System.Decimal() {flags = val_24, hi = val_25, lo = val_23, mid = val_3}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void OnRewardAnimationComplete()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1522542448, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public static GameEventRewardType get_QAHACK_ForceAwardType()
    {
        GameEventRewardType val_3;
        var val_4;
        val_3 = 0;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = BonusGameSlotMachinePopup.qaHackFlagAwardType;
    }
    public static void set_QAHACK_ForceAwardType(GameEventRewardType value)
    {
        var val_3;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        BonusGameSlotMachinePopup.qaHackFlagAwardType = ;
    }
    public BonusGameSlotMachinePopup()
    {
        this.trackEventSource = "Bonus Game Slot Machine";
    }
    private static BonusGameSlotMachinePopup()
    {
    
    }

}
