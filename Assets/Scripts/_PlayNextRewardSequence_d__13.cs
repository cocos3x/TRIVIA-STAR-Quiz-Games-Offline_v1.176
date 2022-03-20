using UnityEngine;
private sealed class NextRewardPopup.<PlayNextRewardSequence>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public NextRewardPopup <>4__this;
    public WGEventButtonV2 eventButton;
    private DG.Tweening.Sequence <seq>5__2;
    private UnityEngine.WaitForSeconds <wait>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NextRewardPopup.<PlayNextRewardSequence>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_28;
        float val_29;
        float val_35;
        float val_36;
        float val_39;
        float val_40;
        float val_41;
        int val_55;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if((DG.Tweening.TweenExtensions.IsPlaying(t:  this.<seq>5__2)) == false)
        {
            goto label_2;
        }
        
        this.<>1__state = 2;
        val_55 = 1;
        this.<>2__current = this.<wait>5__3;
        return (bool)val_55;
        label_1:
        val_55 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_55;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_5;
        }
        
        this.<>4__this.UpdateReward();
        goto label_6;
        label_2:
        val_55 = 0;
        UnityEngine.GameObject val_3 = this.<>4__this.gameObject;
        SLCWindow.CloseWindow(window:  this.<>4__this, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return (bool)val_55;
        label_5:
        0.UpdateReward();
        label_6:
        UnityEngine.Transform val_4 = this.<>4__this.rewardGroup.transform;
        this.<>4__this.rewardGroup.localPosition = new UnityEngine.Vector3() {x = this.<>4__this.initialPos, y = R7, z = this.<>4__this.rewardGroup};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.<>4__this.titleTransform.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_6 = this.<>4__this.rewardGroup.transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.<>4__this.rewardGroup.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_8 = this.<>4__this.glow.transform;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        this.<>4__this.glow.localScale = new UnityEngine.Vector3();
        DG.Tweening.Sequence val_10 = DG.Tweening.DOTween.Sequence();
        this.<seq>5__2 = 0;
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.titleTransform, endValue:  val_9.x, duration:  val_9.y);
        object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.titleTransform, ease:  6);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.<>4__this.titleTransform);
        UnityEngine.Transform val_14 = this.<>4__this.rewardGroup.transform;
        DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.rewardGroup, endValue:  val_9.x, duration:  val_9.y);
        object val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.rewardGroup, ease:  27);
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.<seq>5__2, t:  this.<>4__this.rewardGroup);
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.<seq>5__2, interval:  val_9.x);
        UnityEngine.Transform val_19 = this.<>4__this.glow.transform;
        DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.glow, endValue:  val_9.x, duration:  val_9.y);
        object val_21 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.glow, ease:  3);
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.<seq>5__2, t:  this.<>4__this.glow);
        UnityEngine.Transform val_23 = this.eventButton.transform;
        UnityEngine.Vector3 val_24 = position;
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_26 = transform;
        UnityEngine.Vector3 val_27 = position;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -8.631454E-11f}, b:  new UnityEngine.Vector3() {y = val_29, z = val_28});
        twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_33 = transform;
        UnityEngine.Vector3 val_34 = position;
        UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -8.631437E-11f}, b:  new UnityEngine.Vector3() {y = val_36, z = val_35});
        UnityEngine.Transform val_42 = this.<>4__this.rewardGroup.transform;
        DG.Tweening.Tweener val_43 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.<>4__this.rewardGroup, endValue:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41}, duration:  val_38.x, snapping:  true);
        object val_44 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.rewardGroup, ease:  6);
        DG.Tweening.Sequence val_45 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.<seq>5__2, t:  this.<>4__this.rewardGroup);
        UnityEngine.Transform val_46 = this.<>4__this.rewardGroup.transform;
        DG.Tweening.Tweener val_47 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.rewardGroup, endValue:  val_38.x, duration:  val_38.y);
        object val_48 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.rewardGroup, ease:  9);
        DG.Tweening.Sequence val_49 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.<seq>5__2, t:  this.<>4__this.rewardGroup);
        DG.Tweening.Tweener val_50 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.titleTransform, endValue:  val_38.x, duration:  val_38.y);
        object val_51 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.titleTransform, ease:  9);
        DG.Tweening.Sequence val_52 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.<seq>5__2, t:  this.<>4__this.titleTransform);
        this.<wait>5__3 = new UnityEngine.WaitForSeconds(seconds:  val_38.x);
        val_55 = 1;
        this.<>1__state = val_55;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_38.x);
        return (bool)val_55;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
