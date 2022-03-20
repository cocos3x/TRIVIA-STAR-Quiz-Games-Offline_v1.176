using UnityEngine;
private sealed class RESStatViewStarCurrency.<DoTextAnimation>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESStatViewStarCurrency <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESStatViewStarCurrency.<DoTextAnimation>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RestaurantRivals.RESStatViewStarCurrency val_6;
        int val_7;
        val_6 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            UnityEngine.Transform val_1 = this.<>4__this.text.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.text, endValue:  null, duration:  null);
            UnityEngine.WaitForSeconds val_3 = null;
            val_6 = val_3;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_7 = 1;
            this.<>1__state = val_7;
            this.<>2__current = val_6;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        val_7 = 0;
        UnityEngine.Transform val_4 = this.<>4__this.text.transform;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.text, endValue:  null, duration:  null);
        return (bool)val_7;
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
