using UnityEngine;
public class RaidMadnessPopup : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Button buttonClose;
    protected UnityEngine.UI.Text raidTimesText;
    protected UnityEngine.UI.Slider progressBar;
    protected UnityEngine.UI.Text progressText;
    protected UnityEngine.UI.Text rewardAmountText;
    protected UnityEngine.UI.Image rewardIconImage;
    protected UnityEngine.UI.Text finalPrizeText;
    protected UnityEngine.UI.Button raidNowButton;
    protected UnityEngine.UI.Text timerText;
    protected UnityEngine.Sprite iconCoins;
    protected UnityEngine.Sprite iconSpins;
    protected UnityEngine.Sprite iconGold;
    protected UnityEngine.Sprite iconGoldPrize;
    protected UnityEngine.Sprite iconFood;
    protected DG.Tweening.Sequence timerSequence;
    
    // Properties
    protected RaidMadnessEventHandler Handler { get; }
    
    // Methods
    protected RaidMadnessEventHandler get_Handler()
    {
    
    }
    private void Start()
    {
        var val_13;
        RaidMadnessEventHandler val_14;
        int val_15;
        UnityEngine.UI.Image val_16;
        UnityEngine.Sprite val_17;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1065239664, method:  new IntPtr(3229645120));
        this.buttonClose.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1065239664, method:  typeof(RaidMadnessPopup).__il2cppRuntimeField_E8);
        this.raidNowButton.m_OnClick.AddListener(call:  162246656);
        val_13 = 1152921504937144320;
        if((RaidMadnessEventHandler.<Instance>k__BackingField.HasCollectedAllRewards()) != false)
        {
                val_14 = RaidMadnessEventHandler.<Instance>k__BackingField;
            RESEventRewardData val_4 = val_14.GetFinalPrize();
        }
        else
        {
                val_14 = RaidMadnessEventHandler.<Instance>k__BackingField;
        }
        
        if(val_14 != 0)
        {
            
        }
        
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        if((RaidMadnessEventHandler.<Instance>k__BackingField.HasCollectedAllRewards()) == true)
        {
                val_15 = 0;
        }
        
        if(1152921504937144319 <= 3)
        {
                var val_6 = 8194224 + mem[1329383596];
            if(1152921504937144319 == 3)
        {
                mem[1329383596] = mem[1329383596] & (mem[1329383596] << mem[1329383596]);
            mem[1329383596] = mem[1329383596] & ((IP) << (mem[1329383596] & (mem[1329383596]) << mem[1329383596]));
            mem[1329383596] = mem[1329383596] & 36248552;
            mem2[0] = (((mem[1329383596] & (mem[1329383596]) << mem[1329383596]) & (IP) << (mem[1329383596] & (mem[1329383596]) << mem[1329383596])) & 36248552) + val_13;
        }
        
            val_16 = this.rewardIconImage;
            val_17 = this.iconCoins;
            sprite = ;
        }
        
        if((RaidMadnessEventHandler.<Instance>k__BackingField.HasCollectedAllRewards()) != false)
        {
                if(this.raidTimesText != 0)
        {
            goto label_33;
        }
        
        }
        else
        {
                val_15 = 0 - val_15;
            int val_9 = UnityEngine.Mathf.Max(a:  0, b:  val_15);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_13 = "Raid {0} time{1} to get {2} {3}";
            if(val_15 > 1)
        {
                "" = "s";
        }
        
            val_15 = 0f;
            typeof(System.Object[]).__il2cppRuntimeField_14 = "s";
            RaidMadnessEventHandler val_13 = val_14;
            val_13 = val_13 + 16;
            string val_10 = val_13.ToString(format:  -1539606768);
            typeof(System.Object[]).__il2cppRuntimeField_18 = val_13;
            typeof(System.Object[]).__il2cppRuntimeField_1C = 0;
            string val_11 = System.String.Format(format:  -1065276096, args:  472754880);
        }
        
        label_33:
        string val_12 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        RaidMadnessEventHandler val_14 = val_14;
        val_14 = val_14 + 16;
        this.SetTimer();
    }
    protected virtual void Initialize()
    {
        float val_6 = 5.973412E-38f;
        val_6 = 8195860 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        RESEventRewardData val_1 = RaidMadnessEventHandler.<Instance>k__BackingField.GetFinalPrize();
        RaidMadnessEventHandler.<Instance>k__BackingField.econ
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        string val_2 = ToUpper();
        string val_3 = System.String.Format(format:  1592589744, arg0:  -1065049840, arg1:  347549696);
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        if((RaidMadnessEventHandler.<Instance>k__BackingField.HasCollectedAllRewards()) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_5 = this.rewardIconImage.gameObject;
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
        SLCWindow.CloseWindow(window:  -1064685168, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected virtual void OnMainButtonClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1064573168, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void SetTimer()
    {
        if(this.timerSequence != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
        }
        
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.timerSequence = 0;
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  -1064447856, method:  new IntPtr(3230486224));
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.timerSequence, interval:  null);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.timerSequence, loops:  0);
    }
    protected virtual string GetTimerText()
    {
        var val_2;
        var val_10 = 27433368;
        val_10 = 8196632 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        System.TimeSpan val_1 = GetTimeLeft();
        int val_5 = val_2.Days;
        int val_6 = val_5 + (val_5 << 1);
        val_6 = val_2.Hours + (val_6 << 3);
        int val_7 = val_2.Minutes;
        int val_8 = val_2.Seconds;
        string val_9 = System.String.Format(format:  -1538678208, arg0:  13152256, arg1:  13152256, arg2:  13152256);
    }
    protected virtual string GetAmountString(decimal amount)
    {
        decimal val_1 = new System.Decimal(value:  1000);
        string val_2 = MetricSystem.Abbreviate(number:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid}, maxSigFigs:  3, round:  false, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, useRichText:  false, withSpaces:  false);
    }
    public RaidMadnessPopup()
    {
    
    }
    private void <SetTimer>b__23_0()
    {
        if(this.timerText == 0)
        {
            
        }
    
    }

}
