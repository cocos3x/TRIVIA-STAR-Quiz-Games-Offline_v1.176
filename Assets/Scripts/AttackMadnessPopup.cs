using UnityEngine;
public class AttackMadnessPopup : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Button buttonClose;
    protected UnityEngine.UI.Text attackTimesText;
    protected UnityEngine.UI.Slider progressBar;
    protected UnityEngine.UI.Text progressText;
    protected UnityEngine.UI.Text rewardAmountText;
    protected UnityEngine.UI.Image rewardIconImage;
    protected UnityEngine.UI.Text grandPrizeText;
    protected UnityEngine.UI.Button attackNowButton;
    protected UnityEngine.UI.Text timerText;
    protected UnityEngine.Sprite iconCoins;
    protected UnityEngine.Sprite iconSpins;
    protected UnityEngine.Sprite iconGold;
    protected UnityEngine.Sprite iconGoldPrize;
    protected UnityEngine.Sprite iconFood;
    protected DG.Tweening.Sequence timerSequence;
    
    // Properties
    protected AttackMadnessEventHandler Handler { get; }
    
    // Methods
    protected AttackMadnessEventHandler get_Handler()
    {
    
    }
    private void Start()
    {
        var val_11;
        var val_12;
        UnityEngine.UI.Image val_13;
        UnityEngine.Sprite val_14;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1539570400, method:  new IntPtr(2755314128));
        this.buttonClose.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1539570400, method:  typeof(AttackMadnessPopup).__il2cppRuntimeField_E8);
        this.attackNowButton.m_OnClick.AddListener(call:  162246656);
        if((AttackMadnessEventHandler.<Instance>k__BackingField) != 0)
        {
                val_11 = mem[AttackMadnessEventHandler.<Instance>k__BackingField + 12];
            val_11 = AttackMadnessEventHandler.<Instance>k__BackingField + 12;
        }
        else
        {
                val_11 = 0;
        }
        
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        UnityEngine.Events.UnityAction.__error = ;
        if((AttackMadnessEventHandler.<Instance>k__BackingField.HasCollectedAllRewards()) == true)
        {
                val_12 = val_11;
        }
        
        RESEventRewardType val_4 = UnityEngine.Events.UnityAction.__error - 1;
        if(val_4 <= 3)
        {
                var val_5 = 9350764 + (9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2);
            if(val_4 == 3)
        {
                9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2 = (9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2) & ((9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2) << (9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2));
            9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2 = (9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2) & ((IP) << (9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2 & (9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2) << 9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2));
            9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2 = (9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2) & 0;
            mem2[0] = (((9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2 & (9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2) << 9350764 + ((UnityEngine.Events.UnityAction.__error - 1)) << 2) & ( + val_11;
        }
        
            val_13 = this.rewardIconImage;
            val_14 = this.iconCoins;
            sprite = ;
        }
        
        if((AttackMadnessEventHandler.<Instance>k__BackingField.HasCollectedAllRewards()) != false)
        {
                if(this.attackTimesText != 0)
        {
            goto label_29;
        }
        
        }
        else
        {
                val_12 = val_11 - val_12;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            if(val_12 > 1)
        {
                "" = "s";
        }
        
            val_11 = val_11;
            typeof(System.Object[]).__il2cppRuntimeField_14 = "s";
            AttackMadnessEventHandler val_11 = AttackMadnessEventHandler.<Instance>k__BackingField;
            val_11 = val_11 + 16;
            string val_8 = val_11.ToString(format:  -1539606768);
            typeof(System.Object[]).__il2cppRuntimeField_18 = val_11;
            typeof(System.Object[]).__il2cppRuntimeField_1C = App.__il2cppRuntimeField_namespaze;
            string val_9 = System.String.Format(format:  -1539606912, args:  472754880);
        }
        
        label_29:
        string val_10 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        AttackMadnessEventHandler val_12 = AttackMadnessEventHandler.<Instance>k__BackingField;
        val_12 = val_12 + 16;
        this.SetTimer();
    }
    protected virtual void Initialize()
    {
        float val_5 = 5.324167E-38f;
        val_5 = 9352332 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        decimal val_1 = GetGrandPrizeSpinAmount();
        string val_2 = System.String.Format(format:  -1539412768, arg0:  -1539380480);
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        if((AttackMadnessEventHandler.<Instance>k__BackingField.HasCollectedAllRewards()) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = this.rewardIconImage.gameObject;
        this.rewardIconImage.SetActive(value:  false);
    }
    private void OnDisable()
    {
        if(this.timerSequence == 0)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
    }
    private void OnDestroy()
    {
        if(this.timerSequence == 0)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1539015808, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected virtual void OnMainButtonClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1538903808, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected void SetTimer()
    {
        if(this.timerSequence != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
        }
        
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.timerSequence = 0;
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  -1538778496, method:  new IntPtr(2756155584));
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.timerSequence, interval:  null);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.timerSequence, loops:  0);
    }
    protected virtual string GetTimerText()
    {
        var val_1;
        var val_9 = 26275239;
        val_9 = 9352940 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        int val_4 = val_1.Days;
        int val_5 = val_4 + (val_4 << 1);
        val_5 = val_1.Hours + (val_5 << 3);
        int val_6 = val_1.Minutes;
        int val_7 = val_1.Seconds;
        string val_8 = System.String.Format(format:  -1538678208, arg0:  13152256, arg1:  13152256, arg2:  13152256);
    }
    protected virtual string GetAmountString(decimal amount)
    {
        decimal val_1 = new System.Decimal(value:  1000);
        string val_2 = MetricSystem.Abbreviate(number:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid}, maxSigFigs:  3, round:  false, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, useRichText:  false, withSpaces:  false);
    }
    public AttackMadnessPopup()
    {
    
    }
    private void <SetTimer>b__23_0()
    {
        if(this.timerText == 0)
        {
            
        }
    
    }

}
