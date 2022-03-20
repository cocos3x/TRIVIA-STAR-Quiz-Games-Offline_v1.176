using UnityEngine;
private sealed class RESSpinInfoController.<ActuralShowHighstakesReadyTip>d__41 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESSpinInfoController <>4__this;
    private UnityEngine.CanvasGroup <cg>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESSpinInfoController.<ActuralShowHighstakesReadyTip>d__41(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RestaurantRivals.RESSpinInfoController val_10;
        int val_11;
        val_10 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_11 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
        this.<>1__state = 0;
        object val_1 = this.<>4__this.HighstakesReadyTip.GetComponent<System.Object>();
        this.<cg>5__2 = this.<>4__this.HighstakesReadyTip;
        this.<>4__this.HighstakesReadyTip.alpha = null;
        UnityEngine.Transform val_2 = this.<>4__this.HighstakesReadyTip.transform;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.HighstakesReadyTip, endValue:  null, duration:  null);
        object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.HighstakesReadyTip, ease:  26);
        UnityEngine.WaitForSeconds val_5 = null;
        val_10 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_11 = 1;
        this.<>1__state = val_11;
        this.<>2__current = val_10;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Transform val_6 = this.<>4__this.HighstakesReadyTip.transform;
        val_11 = 0;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.<>4__this.HighstakesReadyTip.localScale = new UnityEngine.Vector3();
        return (bool)val_11;
        label_2:
        this.<>1__state = 0;
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<cg>5__2, endValue:  null, duration:  null);
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        val_11 = 1;
        return (bool)val_11;
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
