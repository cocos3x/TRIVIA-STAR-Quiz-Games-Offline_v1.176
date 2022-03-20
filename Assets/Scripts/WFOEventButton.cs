using UnityEngine;
[Serializable]
public class WFOEventButton : WGEventButton
{
    // Fields
    private bool isInSneakPreviewMode;
    private System.Collections.Generic.List<WGEventHandler> sneakPreviewLockedEventList;
    private UnityEngine.UI.Image iconLocked;
    private UnityEngine.UI.Text lockedLabel;
    private UnityEngine.CanvasGroup buttonContentCanvasGroup;
    private UnityEngine.CanvasGroup sneakPreviewTooltip;
    private DG.Tweening.Tweener sneakTooltipTween;
    private DG.Tweening.Sequence eventDisplayLoop;
    private System.Collections.Generic.List<string> eventsToSkipProcessing;
    
    // Methods
    protected override void Awake()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -388301744, name:  -1383203024);
        this.Awake();
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        this.eventDisplayLoop = 0;
        object val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0, loopType:  0);
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.eventDisplayLoop, interval:  null);
        DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  -388301744, method:  new IntPtr(3906640528));
        object val_6 = DG.Tweening.TweenSettingsExtensions.OnStepComplete<System.Object>(t:  this.eventDisplayLoop, action:  190734336);
    }
    private void VisualLoop()
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.buttonContentCanvasGroup, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.buttonContentCanvasGroup);
        DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  R6 + 172, method:  new IntPtr(1249861984));
        DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.buttonContentCanvasGroup, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.buttonContentCanvasGroup);
    }
    private void OnDestroy()
    {
        var val_1;
        System.Collections.Generic.List<WGEventHandler> val_2;
        val_1 = 0;
        goto label_1;
        label_6:
        val_2 = this.sneakPreviewLockedEventList;
        if(val_2 == 0)
        {
                val_2 = 0;
        }
        
        if(val_1 >= mem[35639987])
        {
            goto label_3;
        }
        
        label_7:
        if(0 <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_1 = 0;
        val_1 = val_1 + 0;
        val_1 = 1;
        label_1:
        val_2 = this.sneakPreviewLockedEventList;
        if(val_2 == 0)
        {
            goto label_6;
        }
        
        if(val_1 < ((0 + 0) + 16))
        {
            goto label_7;
        }
        
        label_3:
        val_2.Clear();
        this.sneakPreviewLockedEventList = 0;
    }
    private void OnGameEventDataReceived()
    {
        this.UpdateDisplay();
    }
    protected override void PrevEvent()
    {
        DG.Tweening.TweenExtensions.Restart(t:  this.eventDisplayLoop, includeDelay:  true, changeDelayTo:  null);
        if(this.isInSneakPreviewMode != false)
        {
                float val_2 = UnityEngine.Mathf.Repeat(t:  (float)this.sneakPreviewLockedEventList, length:  null);
            mem[1152921512808978188] = (float)35639976 - 1;
            this.UpdateDisplay();
            return;
        }
        
        this.PrevEvent();
    }
    protected override void NextEvent()
    {
        DG.Tweening.TweenExtensions.Restart(t:  this.eventDisplayLoop, includeDelay:  true, changeDelayTo:  null);
        if(this.isInSneakPreviewMode != false)
        {
                float val_2 = UnityEngine.Mathf.Repeat(t:  (float)this.sneakPreviewLockedEventList, length:  null);
            mem[1152921512809106572] = (float)35639977 + 1;
            this.UpdateDisplay();
            return;
        }
        
        this.NextEvent();
    }
    protected override void OnClick(bool result)
    {
        if(this.isInSneakPreviewMode != false)
        {
                if(this.sneakTooltipTween != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.sneakTooltipTween, complete:  false);
        }
        
            UnityEngine.GameObject val_1 = this.sneakPreviewTooltip.gameObject;
            this.sneakPreviewTooltip.SetActive(value:  true);
            this.sneakPreviewTooltip.alpha = null;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.sneakPreviewTooltip, endValue:  null, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.sneakPreviewTooltip, delay:  null);
            this.sneakTooltipTween = this.sneakPreviewTooltip;
            return;
        }
        
        this.OnClick(result:  result);
    }
    protected override System.Collections.IEnumerator UpdateDisplayDelayed()
    {
        object val_1 = new System.Object();
        typeof(WFOEventButton.<UpdateDisplayDelayed>d__16).__il2cppRuntimeField_8 = 0;
        typeof(WFOEventButton.<UpdateDisplayDelayed>d__16).__il2cppRuntimeField_10 = this;
    }
    protected void RefineEventIconLook(WGEventHandler evtHandler)
    {
        if(evtHandler == 0)
        {
                return;
        }
        
        string val_1 = evtHandler.EventType;
    }
    public WFOEventButton()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.sneakPreviewLockedEventList = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.eventsToSkipProcessing = null;
    }
    private void <Awake>b__9_0()
    {
        this.VisualLoop();
    }
    private System.Collections.IEnumerator <>n__0()
    {
        return this.UpdateDisplayDelayed();
    }

}
