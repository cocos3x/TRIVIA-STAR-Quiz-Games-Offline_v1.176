using UnityEngine;
public class IslandParadiseProgressPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button buttonClose;
    private UnityEngine.UI.Slider progressBar;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.GameObject rewardGroup;
    private UnityEngine.UI.Image rewardIconImage;
    private UnityEngine.UI.Text rewardAmountText;
    private UnityEngine.UI.Text collectAmountText;
    private UnityEngine.UI.Image collectTextSymbol;
    private UnityEngine.UI.Text collectAmountText2;
    private UnityEngine.UI.Text rewardAmountText1;
    private UnityEngine.UI.Text rewardAmountText2;
    private UnityEngine.UI.Text rewardAmountText3;
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Button okButton;
    private UnityEngine.UI.Text buttonText;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.RectTransform centerTransform;
    private UnityEngine.Sprite iconCoins;
    private UnityEngine.Sprite iconGold;
    private UnityEngine.Sprite iconFood;
    private DG.Tweening.Sequence timerSequence;
    private int currentProgress;
    
    // Properties
    public UnityEngine.GameObject RewardGroup { get; }
    private IslandParadiseEventHandler handler { get; }
    
    // Methods
    public UnityEngine.GameObject get_RewardGroup()
    {
    
    }
    private IslandParadiseEventHandler get_handler()
    {
    
    }
    private void Start()
    {
        var val_19;
        UnityEngine.UI.Image val_20;
        UnityEngine.Sprite val_21;
        var val_22;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1367126896, method:  new IntPtr(2927695136));
        this.buttonClose.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1367126896, method:  new IntPtr(2927704352));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1367126896, method:  new IntPtr(2927695136));
        this.okButton.m_OnClick.AddListener(call:  162246656);
        val_19 = 1152921504924897280;
        if(IslandParadiseEventHandler._Instance.HasCollectedAllRewards() == false)
        {
            goto label_9;
        }
        
        UnityEngine.GameObject val_5 = this.collectTextSymbol.gameObject;
        this.collectTextSymbol.SetActive(value:  false);
        this.rewardGroup.SetActive(value:  false);
        UnityEngine.GameObject val_6 = this.okButton.gameObject;
        this.okButton.SetActive(value:  true);
        UnityEngine.GameObject val_7 = this.playButton.gameObject;
        this.playButton.SetActive(value:  false);
        goto label_41;
        label_9:
        UnityEngine.GameObject val_8 = this.okButton.gameObject;
        this.okButton.SetActive(value:  false);
        UnityEngine.GameObject val_9 = this.playButton.gameObject;
        this.playButton.SetActive(value:  true);
        int val_10 = UnityEngine.Mathf.Clamp(value:  IslandParadiseEventHandler._Instance, min:  0, max:  IslandParadiseEventHandler._Instance + 12);
        string val_11 = System.String.Format(format:  -1367208432, arg0:  13152256);
        UnityEngine.GameObject val_12 = this.collectTextSymbol.gameObject;
        this.collectTextSymbol.SetActive(value:  true);
        IslandParadiseEventHandler._Instance.OnKeyBalanceChanged
        string val_13 = IslandParadiseEventHandler._Instance.OnKeyBalanceChanged.ToString();
        float val_19 = (float)IslandParadiseEventHandler._Instance + 12;
        val_19 = (float)val_10 / val_19;
        this.SetProgressText(pointSoFar:  val_10, pointRequired:  IslandParadiseEventHandler._Instance + 12);
        if((IslandParadiseEventHandler._Instance + 8) == 1)
        {
            goto label_39;
        }
        
        val_19 = 1152921504924897280;
        if((IslandParadiseEventHandler._Instance + 8) == 3)
        {
            goto label_40;
        }
        
        if((IslandParadiseEventHandler._Instance + 8) != 4)
        {
            goto label_41;
        }
        
        val_20 = this.rewardIconImage;
        val_21 = this.iconFood;
        goto label_42;
        label_39:
        val_20 = this.rewardIconImage;
        val_21 = this.iconCoins;
        val_19 = 1152921504924897280;
        if(val_20 != 0)
        {
            goto label_45;
        }
        
        goto label_44;
        label_40:
        val_20 = this.rewardIconImage;
        val_21 = this.iconGold;
        label_42:
        if(val_20 != 0)
        {
            goto label_45;
        }
        
        label_44:
        label_45:
        val_20.sprite = val_21;
        label_41:
        val_22 = null;
        val_22 = null;
        string val_14 = ToString();
        string val_15 = ToString();
        string val_16 = ToString();
        Player val_17 = App.Player;
        string val_18 = System.String.Format(format:  2127161280, arg0:  13152256);
        this.SetTimer();
        if((IslandParadiseEventHandler._Instance.<NeedToShowProgress>k__BackingField) != false)
        {
                this.ShowProgress();
            return;
        }
        
        this.TryShowRewardFlow();
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
    public void ShowRewardGroup()
    {
        this.rewardGroup.SetActive(value:  true);
    }
    public void HideRewardGroup()
    {
        this.rewardGroup.SetActive(value:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1366407152, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnMainButtonClicked()
    {
        var val_4 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1366295152, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void SetTimer()
    {
        if(this.timerSequence != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.timerSequence, complete:  false);
        }
        
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.timerSequence = 0;
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  -1366169840, method:  new IntPtr(2928764240));
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.timerSequence, interval:  null);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.timerSequence, loops:  0);
    }
    private string GetTimerText()
    {
        ulong val_4;
        var val_7;
        var val_14 = 24124116;
        val_14 = 11504064 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511830724088}, d2:  new System.DateTime() {dateData = val_4});
        int val_9 = val_7.Days;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_10 = val_7.Hours;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_11 = val_7.Minutes;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_12 = val_7.Seconds;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_13 = System.String.Format(format:  -1366069552, args:  472754880);
    }
    private void SetProgressText(int pointSoFar, int pointRequired)
    {
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        if(this.progressText != 0)
        {
                return;
        }
    
    }
    private void SetProgressBar(int pointSoFar, int pointRequired)
    {
        float val_1 = (float)pointRequired;
        val_1 = (float)pointSoFar / val_1;
        goto typeof(UnityEngine.UI.Slider).__il2cppRuntimeField_234;
    }
    private void ShowProgress()
    {
        DG.Tweening.TweenCallback val_14;
        var val_15;
        object val_1 = new System.Object();
        typeof(IslandParadiseProgressPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_8 = this;
        val_14 = 11501924 + 24126256;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = 1152921504924897280;
        if((IslandParadiseEventHandler._Instance.<NeedToShowProgress>k__BackingField) == false)
        {
                return;
        }
        
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        typeof(IslandParadiseProgressPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_C = IslandParadiseEventHandler._Instance + 12;
        int val_2 = UnityEngine.Mathf.Clamp(value:  IslandParadiseEventHandler._Instance, min:  0, max:  IslandParadiseEventHandler._Instance + 12);
        string val_3 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        float val_14 = (float)typeof(IslandParadiseProgressPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_C;
        val_14 = (float)val_2 / val_14;
        float val_4 = val_14 + val_14;
        DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Core.DOGetter<System.Int32> val_6 = new DG.Tweening.Core.DOGetter<System.Int32>(object:  318636032, method:  new IntPtr(2929258448));
        DG.Tweening.Core.DOSetter<System.Int32> val_7 = new DG.Tweening.Core.DOSetter<System.Int32>(object:  318636032, method:  new IntPtr(2929259472));
        val_15 = 0;
        DG.Tweening.Tweener val_8 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  val_2, duration:  val_14);
        val_14 = null;
        val_14 = new DG.Tweening.TweenCallback(object:  -1365681776, method:  new IntPtr(2929260496));
        object val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198828032, action:  190734336);
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  198828032);
        float val_15 = (float)typeof(IslandParadiseProgressPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_C;
        val_15 = (float)val_2 / val_15;
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOValue(target:  this.progressBar, endValue:  val_15, duration:  null, snapping:  val_15);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.progressBar);
    }
    private void TryShowRewardFlow()
    {
        var val_6 = 24125220;
        val_6 = 11502960 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance.HasCollectedAllRewards() == false)
        {
            goto label_3;
        }
        
        if(val_6 != 0)
        {
            goto label_17;
        }
        
        label_18:
        mem2[0] = 1;
        label_17:
        IslandParadiseEventHandler._Instance.<NeedToShowProgress>k__BackingField = false;
        return;
        label_3:
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance != 0)
        {
                System.Action val_2 = new System.Action(object:  -1365560560, method:  new IntPtr(2929381712));
            this.PlayRewardSequence(onComplete:  7454720);
            return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        if(0 != 0)
        {
                WordRegion val_5 = WordRegion.instance;
            0.RemoveLevelCompleteBlocker(blocker:  3);
        }
        
        if(val_6 != 0)
        {
            goto label_17;
        }
        
        goto label_18;
    }
    private void PlayRewardSequence(System.Action onComplete)
    {
        var val_18;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_18 = val_1;
            typeof(IslandParadiseProgressPopup.<>c__DisplayClass39_0).__il2cppRuntimeField_8 = onComplete;
        }
        else
        {
                val_18 = 8;
            mem[8] = onComplete;
        }
        
        typeof(IslandParadiseProgressPopup.<>c__DisplayClass39_0).__il2cppRuntimeField_10 = this;
        UnityEngine.Transform val_2 = this.rewardGroup.transform;
        UnityEngine.Transform val_3 = this.rewardGroup.parent;
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.rewardGroup, parent:  this.rewardGroup);
        typeof(IslandParadiseProgressPopup.<>c__DisplayClass39_0).__il2cppRuntimeField_C = this.rewardGroup;
        UnityEngine.Transform val_5 = this.rewardGroup.transform;
        this.rewardGroup.SetParent(p:  this.centerTransform);
        this.HideRewardGroup();
        DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_7 = typeof(IslandParadiseProgressPopup.<>c__DisplayClass39_0).__il2cppRuntimeField_C.transform;
        UnityEngine.Vector3 val_8 = position;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOMove(target:  typeof(IslandParadiseProgressPopup.<>c__DisplayClass39_0).__il2cppRuntimeField_C, endValue:  new UnityEngine.Vector3(), duration:  val_8.x, snapping:  true);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  typeof(IslandParadiseProgressPopup.<>c__DisplayClass39_0).__il2cppRuntimeField_C);
        UnityEngine.Transform val_11 = typeof(IslandParadiseProgressPopup.<>c__DisplayClass39_0).__il2cppRuntimeField_C.transform;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -7.139075E-11f}, d:  val_12.x);
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScale(target:  typeof(IslandParadiseProgressPopup.<>c__DisplayClass39_0).__il2cppRuntimeField_C, endValue:  new UnityEngine.Vector3(), duration:  val_13.x);
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  typeof(IslandParadiseProgressPopup.<>c__DisplayClass39_0).__il2cppRuntimeField_C);
        if(val_18 == 0)
        {
                return;
        }
        
        DG.Tweening.TweenCallback val_16 = new DG.Tweening.TweenCallback(object:  318689280, method:  new IntPtr(2929511120));
        object val_17 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private void ShowRewardCollection()
    {
        IslandParadiseEventHandler._Instance.ShowRewardCollection();
    }
    public IslandParadiseProgressPopup()
    {
    
    }
    private void <SetTimer>b__33_0()
    {
        string val_1 = this.GetTimerText();
        if(this.timerText == 0)
        {
            
        }
    
    }
    private void <TryShowRewardFlow>b__38_0()
    {
        this.ShowRewardCollection();
    }

}
