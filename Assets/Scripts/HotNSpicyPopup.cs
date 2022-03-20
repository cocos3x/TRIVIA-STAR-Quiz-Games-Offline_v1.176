using UnityEngine;
public class HotNSpicyPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button buttonClose;
    private UnityEngine.UI.Slider progressBar;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.UI.Image rewardIconImage;
    private UnityEngine.UI.Text rewardAmountText;
    private UnityEngine.UI.Text collectFireText;
    private UnityEngine.UI.Text attackAmountText;
    private UnityEngine.UI.Text attackBlockedAmountText;
    private UnityEngine.UI.Text raidAmountText;
    private UnityEngine.UI.Text perfectRaidAmountText;
    private UnityEngine.UI.Text threeSymbolsAmountText;
    private UnityEngine.UI.Button burningHotButton;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.Sprite iconCoins;
    private UnityEngine.Sprite iconSpins;
    private DG.Tweening.Sequence timerSequence;
    
    // Methods
    private void Start()
    {
        var val_14;
        UnityEngine.Sprite val_15;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1193691152, method:  new IntPtr(3101242800));
        this.buttonClose.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1193691152, method:  new IntPtr(3101242800));
        this.burningHotButton.m_OnClick.AddListener(call:  162246656);
        if((HotNSpicyEventHandler.<Instance>k__BackingField) != 0)
        {
                if(mem[1152921512003090448] != 0)
        {
            goto label_11;
        }
        
        }
        else
        {
                HotNSpicyEventHandler val_3 = (HotNSpicyEventHandler.<Instance>k__BackingField + 12) - (HotNSpicyEventHandler.<Instance>k__BackingField);
            string val_4 = System.String.Format(format:  -1193715280, arg0:  13152256);
        }
        
        label_11:
        float val_13 = (float)HotNSpicyEventHandler.<Instance>k__BackingField + 12;
        val_13 = ((float)HotNSpicyEventHandler.<Instance>k__BackingField) / val_13;
        string val_5 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        decimal val_6 = new System.Decimal(value:  1000);
        string val_7 = MetricSystem.Abbreviate(number:  new System.Decimal() {flags = 325025792, hi = 325079040, lo = HotNSpicyEventHandler.<Instance>k__BackingField.suppressRewardCollectionPopup, mid = HotNSpicyEventHandler.<Instance>k__BackingField + 28}, maxSigFigs:  3, round:  false, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid}, useRichText:  false, withSpaces:  false);
        if((HotNSpicyEventHandler.<Instance>k__BackingField + 8) == 2)
        {
            goto label_18;
        }
        
        if((HotNSpicyEventHandler.<Instance>k__BackingField + 8) != 1)
        {
            goto label_19;
        }
        
        val_14 = mem[1152921512003090440];
        val_15 = mem[1152921512003090480];
        goto label_20;
        label_18:
        val_14 = mem[1152921512003090440];
        val_15 = mem[1152921512003090484];
        label_20:
        val_14.sprite = val_15;
        label_19:
        string val_8 = HotNSpicyEventHandler.<Instance>k__BackingField.econ.pointsGainPerAttack.ToString();
        string val_9 = HotNSpicyEventHandler.<Instance>k__BackingField.econ.pointsGainPerAttackBlocked.ToString();
        string val_10 = HotNSpicyEventHandler.<Instance>k__BackingField.econ.pointsGainPerRaid.ToString();
        string val_11 = HotNSpicyEventHandler.<Instance>k__BackingField.econ.pointsGainPerRaidPerfect.ToString();
        string val_12 = HotNSpicyEventHandler.<Instance>k__BackingField.econ.pointsGainPerHit3Symbols.ToString();
        this.SetTimer();
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
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1193322384, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void SetTimer()
    {
        if(this.timerSequence != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
        }
        
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.timerSequence = 0;
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  -1193197072, method:  new IntPtr(3101737008));
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.timerSequence, interval:  null);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.timerSequence, loops:  0);
    }
    private string GetTimerText()
    {
        var val_2;
        var val_8 = 24191009;
        val_8 = 11434532 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        System.TimeSpan val_1 = GetTimeLeft();
        int val_4 = val_2.Hours;
        int val_5 = val_2.Minutes;
        int val_6 = val_2.Seconds;
        string val_7 = System.String.Format(format:  -1538678208, arg0:  13152256, arg1:  13152256, arg2:  13152256);
    }
    public HotNSpicyPopup()
    {
    
    }
    private void <SetTimer>b__20_0()
    {
        string val_1 = this.GetTimerText();
        if(this.timerText == 0)
        {
            
        }
    
    }

}
