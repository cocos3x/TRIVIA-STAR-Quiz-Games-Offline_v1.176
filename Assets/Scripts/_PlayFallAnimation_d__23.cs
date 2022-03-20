using UnityEngine;
private sealed class WGEventProgressFlyInAwayPopup.<PlayFallAnimation>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventProgressFlyInAwayPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGEventProgressFlyInAwayPopup.<PlayFallAnimation>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_15;
        UnityEngine.RectTransform val_16;
        object val_17;
        val_15 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 7252176 + (7252176 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                val_15 = 0;
            val_15 = val_15 & ((IP) >> 1);
            val_15 = val_15 & 4240695248;
            val_15 = val_15 * 7252176;
        }
        
        this.<>1__state = 0;
        val_16 = this.<>4__this.flyoutRectTransform;
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  null, y:  null);
        val_16.pivot = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOPivotY(target:  this.<>4__this.flyoutRectTransform, endValue:  null, duration:  null);
        UnityEngine.WaitForSeconds val_4 = null;
        val_17 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_15 = 1;
        this.<>1__state = val_15;
        this.<>2__current = ;
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
