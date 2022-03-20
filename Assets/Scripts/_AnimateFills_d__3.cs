using UnityEngine;
private sealed class HintMeterGameplayUI.<AnimateFills>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public HintMeterGameplayUI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HintMeterGameplayUI.<AnimateFills>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_17;
        float val_18;
        float val_19;
        HintMeterGameplayUI.<AnimateFills>d__3 val_22;
        int val_23;
        var val_24;
        val_22 = this;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        val_23 = 0;
        UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
        val_24 = this.<>4__this;
        if(val_24.activeInHierarchy == false)
        {
                return (bool)val_23;
        }
        
        if((this.<>4__this) == 0)
        {
            goto label_5;
        }
        
        UnityEngine.Transform val_4 = this.<>4__this.transform;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  this.<>4__this, duration:  null, strength:  null, vibrato:  1036831949, randomness:  null, snapping:  false, fadeOut:  true);
        goto label_6;
        label_1:
        val_23 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_23;
        }
        
        val_23 = 1;
        this.<>1__state = val_23;
        this.<>2__current = 0;
        return (bool)val_23;
        label_5:
        UnityEngine.Transform val_6 = this.<>4__this.transform;
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  this.<>4__this, duration:  null, strength:  null, vibrato:  1036831949, randomness:  null, snapping:  false, fadeOut:  true);
        label_6:
        UnityEngine.Transform val_8 = this.<>4__this.transform;
        val_24 = 15820;
        val_24 = 1036831949;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOShakeScale(target:  this.<>4__this, duration:  null, strength:  null, vibrato:  1036831949, randomness:  null, fadeOut:  true);
        val_22 = 4;
        goto label_9;
        label_23:
        UnityEngine.UI.Image val_23 = this.<>4__this.fillImages[0];
        UnityEngine.Transform val_10 = val_23.transform;
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  val_23, duration:  null, strength:  null, vibrato:  1036831949, randomness:  null, snapping:  false, fadeOut:  true);
        UnityEngine.UI.Image val_24 = this.<>4__this.fillImages[0];
        UnityEngine.Transform val_12 = val_24.transform;
        DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOShakeScale(target:  val_24, duration:  null, strength:  null, vibrato:  1036831949, randomness:  null, fadeOut:  true);
        UnityEngine.UI.Image val_25 = this.<>4__this.fillImages[0];
        UnityEngine.Transform val_14 = val_25.transform;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -3.879647E-05f}, d:  val_15.x);
        DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  val_25, duration:  val_16.x, strength:  new UnityEngine.Vector3() {x = 0.1f, y = val_18, z = val_19}, vibrato:  val_17, randomness:  val_16.y, fadeOut:  true);
        val_22 = 5;
        label_9:
        if((val_22 - 4) < val_25)
        {
            goto label_23;
        }
        
        UnityEngine.WaitForSeconds val_22 = null;
        val_22 = new UnityEngine.WaitForSeconds(seconds:  val_16.x);
        this.<>1__state = 2;
        mem[1152921511991109772] = val_22;
        val_23 = 1;
        return (bool)val_23;
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
