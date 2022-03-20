using UnityEngine;
private sealed class WindowTransitionTween.<EnableLate>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WindowTransitionTween <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WindowTransitionTween.<EnableLate>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_12;
        float val_13;
        object val_18;
        int val_19;
        Direction val_20;
        DG.Tweening.TweenCallback val_21;
        val_18 = this;
        val_19 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_19;
        }
        
        val_19 = 1;
        this.<>1__state = val_19;
        this.<>2__current = 0;
        return (bool)val_19;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.SetInteractable();
        return (bool)val_19;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_7;
        }
        
        this.<>4__this.SetInitialPosition();
        val_20 = this.<>4__this.enterDirection;
        if(val_20 == 4)
        {
            goto label_8;
        }
        
        goto label_9;
        label_7:
        0.SetInitialPosition();
        val_21 = 2621443;
        if(val_21 != 4)
        {
            goto label_10;
        }
        
        label_8:
        val_19 = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 6.94342E-35f}, d:  val_1.x);
        this.<>4__this.rectTransform.localScale = new UnityEngine.Vector3();
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.rectTransform, endValue:  new UnityEngine.Vector3(), duration:  this.<>4__this.tweenDuration);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.rectTransform, ease:  this.<>4__this.easeType);
        val_18 = this.<>4__this.rectTransform;
        val_21 = null;
        val_21 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  new IntPtr(112731088));
        object val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_18, action:  190734336);
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.windowCanvasGroup, endValue:  this.<>4__this.tweenDuration, duration:  val_3.y);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.windowCanvasGroup, ease:  this.<>4__this.easeType);
        return (bool)val_19;
        label_10:
        val_20 = 2621443;
        label_9:
        if(val_20 == 99)
        {
                val_19 = 1;
            this.<>1__state = 2;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_19;
        }
        
        val_19 = 0;
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.<>4__this.rectTransform, endValue:  new UnityEngine.Vector2() {x = val_12, y = val_13}, duration:  val_11.x, snapping:  this.<>4__this.tweenDuration);
        object val_15 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.rectTransform, ease:  this.<>4__this.easeType);
        val_18 = this.<>4__this.rectTransform;
        val_21 = null;
        val_21 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  new IntPtr(112731088));
        object val_17 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_18, action:  190734336);
        return (bool)val_19;
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
