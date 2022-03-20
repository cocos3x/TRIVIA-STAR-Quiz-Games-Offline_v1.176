using UnityEngine;
private sealed class WFOWordChestDisplay.<DoNewChestAnimationSequence>d__60 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordForest.WFOWordChestDisplay <>4__this;
    public bool isFtux;
    private WordForest.WFOWordChestDisplay.<>c__DisplayClass60_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOWordChestDisplay.<DoNewChestAnimationSequence>d__60(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_14;
        int val_28;
        var val_29;
        if((this.<>1__state) != 1)
        {
                val_28 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_28;
        }
        
            this.<>1__state = 0;
            this.<>8__1 = new System.Object();
            typeof(WFOWordChestDisplay.<>c__DisplayClass60_0).__il2cppRuntimeField_8 = this.<>4__this;
            this.<>8__1.showFtux = this.isFtux;
            this.<>4__this.isAnimationActive = true;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            System.Nullable<UnityEngine.Color> val_4 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.r});
            SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_4.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_8 = this.<>4__this.gameObject;
            UnityEngine.Transform val_9 = this.<>4__this.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = this.<>4__this;
            ShowOverlay(contentToOverlay:  -2028557104);
            this.<>4__this.UpdateChestLabels(skipAnimation:  false);
            this.<>4__this.chestLabelsCanvasGroup.alpha = null;
            val_29 = 0;
            this.<>4__this.parentCanvasGroup.alpha = null;
            this.<>4__this.parentCanvasGroup.blocksRaycasts = false;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  null, y:  null);
            this.<>4__this.chestRootTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
            UnityEngine.WaitForSeconds val_11 = null;
            val_11 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_28 = 1;
            this.<>1__state = val_28;
            this.<>2__current = val_11;
            return (bool)val_28;
        }
        
        this.<>1__state = 0;
        DG.Tweening.Sequence val_12 = DG.Tweening.DOTween.Sequence();
        val_29 = 0;
        val_28 = 0;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.zero;
        DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.<>4__this.chestRootTransform, endValue:  new UnityEngine.Vector2() {x = val_4.HasValue, y = val_14}, duration:  val_13.x, snapping:  false);
        object val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.chestRootTransform, ease:  30);
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.<>4__this.chestRootTransform);
        DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.parentCanvasGroup, endValue:  val_13.x, duration:  val_13.y);
        object val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.parentCanvasGroup, ease:  1);
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.<>4__this.parentCanvasGroup);
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_13.x);
        DG.Tweening.Tweener val_22 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.chestLabelsCanvasGroup, endValue:  val_13.x, duration:  val_13.y);
        object val_23 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.chestLabelsCanvasGroup, ease:  1);
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.<>4__this.chestLabelsCanvasGroup);
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_13.x);
        DG.Tweening.TweenCallback val_26 = new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  new IntPtr(351023024));
        object val_27 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        return (bool)val_28;
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
