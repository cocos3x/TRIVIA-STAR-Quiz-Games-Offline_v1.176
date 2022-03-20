using UnityEngine;
private sealed class RESEventPointsGainAnimator.<ShowProgressBarAnimationCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action onAnimationComplete;
    public RestaurantRivals.RESEventPointsGainAnimator <>4__this;
    private RestaurantRivals.RESEventPointsGainAnimator.<>c__DisplayClass6_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESEventPointsGainAnimator.<ShowProgressBarAnimationCoroutine>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        object val_7;
        if((this.<>1__state) != 1)
        {
                val_6 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            this.<>8__1 = new System.Object();
            typeof(RESEventPointsGainAnimator.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = this.onAnimationComplete;
            UnityEngine.WaitForSeconds val_2 = null;
            val_7 = val_2;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_6 = 1;
            this.<>1__state = val_6;
            this.<>2__current = val_7;
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        RestaurantRivals.RESEventProgressBar val_3 = this.<>4__this.EventProgressBar;
        this.<>4__this.UpdateValue(animated:  true);
        val_7 = null;
        val_6 = 0;
        val_7 = new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  new IntPtr(534654048));
        DG.Tweening.Tween val_5 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1074161254, ignoreTimeScale:  false);
        return (bool)val_6;
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
