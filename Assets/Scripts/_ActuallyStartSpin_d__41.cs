using UnityEngine;
private sealed class Scroller.<ActuallyStartSpin>d__41 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Scroller <>4__this;
    public DG.Tweening.TweenCallback callback;
    public int scrollCount;
    private Scroller.<>c__DisplayClass41_0 <>8__1;
    public float duration;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Scroller.<ActuallyStartSpin>d__41(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_26;
        object val_27;
        int val_28;
        float val_29;
        var val_30;
        DG.Tweening.TweenCallback val_32;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_26 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_26;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        typeof(Scroller.<>c__DisplayClass41_0).__il2cppRuntimeField_8 = this.<>4__this;
        this.<>8__1.callback = this.callback;
        UnityEngine.WaitForEndOfFrame val_2 = null;
        val_27 = val_2;
        val_2 = new UnityEngine.WaitForEndOfFrame();
        val_26 = 1;
        this.<>1__state = val_26;
        goto label_6;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_7;
        }
        
        this.<>4__this.movedDistance = 0f;
        this.<>4__this.moveNeed = 0f;
        this.<>4__this.<isScrolling>k__BackingField = true;
        val_28 = this.scrollCount;
        goto label_8;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.layoutGroup.enabled = false;
        UnityEngine.WaitForEndOfFrame val_3 = null;
        val_27 = val_3;
        val_3 = new UnityEngine.WaitForEndOfFrame();
        val_26 = 1;
        this.<>1__state = 2;
        label_6:
        this.<>2__current = val_27;
        return (bool)val_26;
        label_7:
        mem[60] = 0;
        mem[64] = 0;
        mem[52] = 1;
        val_28 = this.scrollCount;
        label_8:
        float val_26 = (float)val_28;
        DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  0, autoKillOnCompletion:  false);
        val_29 = 0;
        if((this.<>4__this.isWindStart) != false)
        {
                if((this.<>4__this.isWindStart) != true)
        {
                val_29 = this.<>4__this.windStart;
        }
        else
        {
                DG.Tweening.Core.DOSetter<System.Single> val_6 = new DG.Tweening.Core.DOSetter<System.Single>(object:  this.<>8__1, method:  new IntPtr(3657846080));
            float val_7 = (this.<>4__this.windStart) * (this.<>4__this.<itemSpace>k__BackingField);
            float val_8 = val_7 ^ 2147483648;
            DG.Tweening.Tweener val_9 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  val_7, endValue:  null, duration:  null);
            object val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  7);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  198881280);
            if((this.<>4__this.isWindStart) == true)
        {
                val_29 = this.<>4__this.windStart;
        }
        
        }
        
        }
        
        val_26 = (this.<>4__this.<itemSpace>k__BackingField) * val_26;
        if((this.<>4__this.isWindEnd) == true)
        {
                0f = this.<>4__this.windEnd;
        }
        
        DG.Tweening.Core.DOSetter<System.Single> val_12 = new DG.Tweening.Core.DOSetter<System.Single>(object:  this.<>8__1, method:  new IntPtr(3657851200));
        float val_13 = val_29 * (this.<>4__this.<itemSpace>k__BackingField);
        float val_14 = val_13 ^ 2147483648;
        DG.Tweening.Tweener val_15 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  val_13, endValue:  null, duration:  val_26);
        object val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  7);
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  198881280);
        val_30 = null;
        val_30 = null;
        val_32 = Scroller.<>c.<>9__41_2;
        if(val_32 == 0)
        {
                val_32 = null;
            val_32 = new DG.Tweening.TweenCallback(object:  Scroller.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3657852224));
            Scroller.<>c.<>9__41_2 = val_32;
        }
        
        val_26 = 0;
        DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        if((this.<>4__this.isWindEnd) == true)
        {
            goto label_26;
        }
        
        label_29:
        DG.Tweening.TweenCallback val_20 = new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  new IntPtr(3657857344));
        object val_21 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        DG.Tweening.TweenExtensions.PlayForward(t:  0);
        return (bool)val_26;
        label_26:
        DG.Tweening.Core.DOSetter<System.Single> val_22 = new DG.Tweening.Core.DOSetter<System.Single>(object:  this.<>8__1, method:  new IntPtr(3657862464));
        DG.Tweening.Tweener val_23 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  val_13 = this.<>4__this.windEnd, endValue:  null, duration:  val_26);
        object val_24 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  7);
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  198881280);
        goto label_29;
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
