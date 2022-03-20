using UnityEngine;
private sealed class RESEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESEventPointsGainAnimator <>4__this;
    public int qty;
    public System.Action onAnimationComplete;
    private RestaurantRivals.RESEventPointsGainAnimator.<>c__DisplayClass7_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RESEventPointsGainAnimator.<ShowPointGainAnimationCoroutine>d__7 val_59;
        int val_60;
        RestaurantRivals.RESEventPointsGainAnimator val_61;
        int val_62;
        RESEventPointsGainAnimator.<>c__DisplayClass7_0 val_63;
        var val_64;
        val_59 = this;
        if((this.<>1__state) != 1)
        {
                val_60 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_60;
        }
        
            this.<>1__state = 0;
            this.<>8__1 = new System.Object();
            typeof(RESEventPointsGainAnimator.<>c__DisplayClass7_0).__il2cppRuntimeField_8 = this.<>4__this;
            this.<>8__1.qty = this.qty;
            this.<>8__1.onAnimationComplete = this.onAnimationComplete;
            val_60 = 1;
            this.<>1__state = val_60;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_60;
        }
        
        val_61 = this.<>4__this;
        this.<>1__state = 0;
        if((this.<>8__1) != 0)
        {
                val_62 = this.<>8__1.qty;
        }
        else
        {
                val_62 = 0;
        }
        
        this.<>8__1.desiredQty = 0;
        this.<>8__1.qty = UnityEngine.Mathf.Min(a:  10, b:  this.<>8__1.qty);
        val_63 = this.<>8__1;
        if((this.<>8__1) != 0)
        {
            goto label_12;
        }
        
        val_63 = this.<>8__1;
        if(val_63 == 0)
        {
            goto label_13;
        }
        
        label_12:
        UnityEngine.GameObject val_4 = this.<>4__this.radialRayTransform.gameObject;
        this.<>4__this.radialRayTransform.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.<>4__this.pointsIconRootTransform.gameObject;
        this.<>4__this.pointsIconRootTransform.SetActive(value:  true);
        RestaurantRivals.RESEventProgressBar val_6 = this.<>4__this.pointsIconRootTransform.EventProgressBar;
        UnityEngine.Transform val_7 = this.<>8__1.transform;
        UnityEngine.Vector3 val_8 = position;
        val_64 = 0;
        val_60 = 0;
        return (bool)val_60;
        label_13:
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
