using UnityEngine;
private sealed class WGStore_DicePacksPopup.<StartAnimating>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public CurrencyCollectAnimationInstantiator animControl;
    public int fromAmount;
    public int toAmount;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGStore_DicePacksPopup.<StartAnimating>d__26(int <>1__state)
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
        object val_8;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_8 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_7 = 1;
            this.<>1__state = val_7;
            this.<>2__current = val_8;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        val_8 = this.fromAmount;
        val_7 = 0;
        decimal val_2 = System.Decimal.op_Implicit(value:  -1015207976);
        this.animControl.Play(fromValue:  val_8, toValue:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_3}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
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
