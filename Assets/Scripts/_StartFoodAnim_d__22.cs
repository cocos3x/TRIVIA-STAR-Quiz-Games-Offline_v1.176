using UnityEngine;
private sealed class LimitedTimeBundlesPopup.<StartFoodAnim>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LimitedTimeBundlesPopup <>4__this;
    public int fromAmount;
    public int toAmount;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LimitedTimeBundlesPopup.<StartFoodAnim>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            val_7 = 1;
            this.<>1__state = val_7;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        val_7 = 0;
        decimal val_2 = System.Decimal.op_Implicit(value:  -1154272616);
        this.<>4__this.foodAnimControl.Play(fromValue:  this.fromAmount, toValue:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_3}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
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
