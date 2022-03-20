using UnityEngine;
private sealed class WGHintButton.<WaitThenShow>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGHintButton <>4__this;
    private UnityEngine.CanvasGroup <cg>5__2;
    private float <secondsPassed>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGHintButton.<WaitThenShow>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_15;
        int val_21;
        float val_22;
        float val_24;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_21 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool);
        }
        
        val_21 = 1;
        this.<>1__state = val_21;
        this.<>2__current = 0;
        return (bool);
        label_1:
        this.<>1__state = 0;
        float val_1 = UnityEngine.Time.deltaTime;
        uint val_21 = 0;
        val_22 = this.<secondsPassed>5__3;
        val_21 = (this.<secondsPassed>5__3) + val_21;
        this.<secondsPassed>5__3 = val_21;
        if(UnityEngine.Input.touchCount > 0)
        {
            goto label_5;
        }
        
        bool val_3 = UnityEngine.Input.GetMouseButtonDown(button:  0);
        if(val_3 == false)
        {
            goto label_14;
        }
        
        label_5:
        if(val_3 <= false)
        {
            goto label_7;
        }
        
        goto label_8;
        label_2:
        this.<>1__state = 0;
        val_24 = 0f;
        this.<>4__this.popUp.SetActive(value:  true);
        UnityEngine.UI.LayoutElement val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.popUp);
        this.<cg>5__2 = this.<>4__this.popUp;
        this.<>4__this.popUp.alpha = null;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<cg>5__2, endValue:  null, duration:  null);
        val_22 = this;
        this.<secondsPassed>5__3 = val_24;
        if((this.<>4__this.hintImage) != 0)
        {
                UnityEngine.Transform val_7 = this.<>4__this.hintImage.transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            DG.Tweening.Sequence val_9 = DG.Tweening.ShortcutExtensions.DOLocalJump(target:  this.<>4__this.hintImage, endValue:  new UnityEngine.Vector3(), jumpPower:  val_8.x, numJumps:  1112014848, duration:  val_8.y, snapping:  true);
            val_24 = null;
            val_24 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  new IntPtr(4267494784));
            object val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.<>4__this.hintImage, action:  190734336);
        }
        
        label_14:
        label_7:
        label_8:
        val_21 = 0;
        if((this.<>4__this.hintImage) != 0)
        {
                UnityEngine.Transform val_13 = this.<>4__this.hintImage.transform;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -7.350757E+37f, y = val_15});
            this.<>4__this.hintImage.localPosition = new UnityEngine.Vector3();
        }
        
        DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<cg>5__2, endValue:  val_17.x, duration:  val_17.y);
        val_24 = null;
        val_24 = new DG.Tweening.TweenCallback(object:  this.<>4__this, method:  new IntPtr(4267508096));
        object val_20 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.<cg>5__2, action:  190734336);
        return (bool);
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
