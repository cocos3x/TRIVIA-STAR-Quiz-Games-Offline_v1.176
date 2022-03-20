using UnityEngine;
public class RestaurantMasterPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject viewGroup;
    private UnityEngine.GameObject collectGroup;
    private UnityEngine.UI.Button buttonClose;
    private UnityEngine.UI.Text coinsViewText;
    private UnityEngine.UI.Text spinsViewText;
    private UnityEngine.UI.Text coinsCollectText;
    private UnityEngine.UI.Text spinsCollectText;
    private UnityEngine.UI.Button gotItButton;
    private UnityEngine.UI.Button collectButton;
    private UnityEngine.UI.Text timerText;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private SpinsCollectAnimationInstantiator spinsAnim;
    private DG.Tweening.Sequence timerSequence;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1057601312, method:  new IntPtr(3237319456));
        this.buttonClose.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1057601312, method:  new IntPtr(3237319456));
        this.gotItButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1057601312, method:  new IntPtr(3237336864));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        decimal val_4 = GetCoinReward(showNextLevel:  RestaurantMasterEventHandler.<Instance>k__BackingField);
        decimal val_5 = new System.Decimal(value:  1000);
        string val_6 = MetricSystem.Abbreviate(number:  new System.Decimal(), maxSigFigs:  3, round:  false, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid}, useRichText:  false, withSpaces:  false);
        decimal val_7 = GetCoinReward(showNextLevel:  RestaurantMasterEventHandler.<Instance>k__BackingField);
        decimal val_8 = new System.Decimal(value:  1000);
        string val_9 = MetricSystem.Abbreviate(number:  new System.Decimal(), maxSigFigs:  3, round:  false, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.flags}, useRichText:  false, withSpaces:  false);
        string val_11 = RestaurantMasterEventHandler.<Instance>k__BackingField.GetSpinReward(showNextLevel:  true).ToString();
        string val_13 = RestaurantMasterEventHandler.<Instance>k__BackingField.GetSpinReward(showNextLevel:  false).ToString();
        if(mem[1152921512139180292] != 0)
        {
                return;
        }
    
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
    public void SetupView()
    {
        this.viewGroup.SetActive(value:  true);
        this.collectGroup.SetActive(value:  false);
        this.SetTimer();
    }
    public void SetupCollect()
    {
        this.viewGroup.SetActive(value:  false);
        this.collectGroup.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  0, oneshot:  true, pitch:  null, vol:  null);
    }
    private void SetTimer()
    {
        if(this.timerSequence != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
        }
        
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.timerSequence = 0;
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  -1056950176, method:  new IntPtr(3237983904));
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.timerSequence, interval:  null);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.timerSequence, loops:  0);
    }
    private string GetTimerText()
    {
        var val_5;
        var val_11 = 27406447;
        val_11 = 8223556 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        System.DateTime val_1 = DateTimeCheat.Now;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512139943624}, d2:  new System.DateTime() {dateData = RestaurantMasterEventHandler.<Instance>k__BackingField + 8 + 40});
        int val_7 = val_5.Hours;
        int val_8 = val_5.Minutes;
        int val_9 = val_5.Seconds;
        string val_10 = System.String.Format(format:  -1538678208, arg0:  13152256, arg1:  13152256, arg2:  13152256);
    }
    private void OnCollectClicked()
    {
        int val_10;
        int val_11;
        int val_12;
        int val_13;
        var val_19;
        var val_20;
        var val_21;
        object val_1 = new System.Object();
        var val_19 = 27405907;
        typeof(RestaurantMasterPopup.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = this;
        val_19 = 8224096 + val_19;
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        decimal val_2 = GetCoinReward(showNextLevel:  RestaurantMasterEventHandler.<Instance>k__BackingField);
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        int val_3 = RestaurantMasterEventHandler.<Instance>k__BackingField.GetSpinReward(showNextLevel:  false);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Player val_5 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = -1379214896, hi = RestaurantMasterPopup.<>c__DisplayClass20_0.__il2cppRuntimeField_byval_arg, lo = typeof(RestaurantMasterPopup.<>c__DisplayClass20_0).__il2cppRuntimeField_14, mid = RestaurantMasterPopup.<>c__DisplayClass20_0.__il2cppRuntimeField_this_arg}, source:  "Restaurant Master Event", subSource:  0, externalParams:  0, doTrack:  true);
        AwardSpins(amount:  val_3, source:  1098586544, notify:  true);
        if((public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance()) != 0)
        {
                val_19 = Spins;
        }
        else
        {
                val_19 = Spins;
        }
        
        int val_8 = Spins;
        decimal val_9 = System.Decimal.op_Implicit(value:  -1056724816);
        mem[1152921512140068888].Play(fromValue:  val_19 - val_3, toValue:  new System.Decimal() {flags = val_12, hi = val_13, lo = val_11, mid = val_10}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        System.Action val_15 = new System.Action(object:  331096064, method:  new IntPtr(3238229536));
        System.Delegate val_16 = System.Delegate.Combine(a:  mem[1152921512140068888] + 68, b:  7454720);
        val_20 = mem[1152921512140068888] + 68;
        if(val_20 != 0)
        {
                if(val_20 == null)
        {
            goto label_20;
        }
        
        }
        
        val_20 = 0;
        label_20:
        mem2[0] = val_20;
        System.Action val_17 = new System.Action(object:  -1056712736, method:  new IntPtr(3237319456));
        System.Delegate val_18 = System.Delegate.Combine(a:  mem[1152921512140068884] + 100, b:  7454720);
        val_21 = mem[1152921512140068884] + 100;
        if(val_21 != 0)
        {
                if(val_21 == null)
        {
            goto label_24;
        }
        
        }
        
        val_21 = 0;
        label_24:
        mem2[0] = val_21;
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1056600736, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public RestaurantMasterPopup()
    {
    
    }
    private void <SetTimer>b__18_0()
    {
        string val_1 = this.GetTimerText();
        if(this.timerText == 0)
        {
            
        }
    
    }

}
