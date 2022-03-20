using UnityEngine;
private sealed class RESAttackScreenMain.<ShowAttackSpots>d__57 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public RestaurantRivals.RESAttackScreenMain <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESAttackScreenMain.<ShowAttackSpots>d__57(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Transform val_4;
        int val_12 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_12;
        }
        
            this.<>1__state = 0;
            val_12 = 1;
            this.<>1__state = val_12;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_12;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.buttonAttackSpots) == 0)
        {
                return (bool)val_12;
        }
        
        if(0 < 1)
        {
                return (bool)val_12;
        }
        
        List.Enumerator<T> val_2 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        UnityEngine.GameObject val_5 = val_4.gameObject;
        val_4.SetActive(value:  true);
        DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_7 = val_4.transform;
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_4, endValue:  null, duration:  null);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_4, ease:  4);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_4);
        object val_11 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0, loopType:  1);
        this.<>4__this.buttonAttackSpotsIdleSeq.Add(item:  0);
        goto label_14;
        label_7:
        Dispose();
        val_12 = 0;
        return (bool)val_12;
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
