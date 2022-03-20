using UnityEngine;
private sealed class WGStore_WADPets.<WaitPlayFoodAnim>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGStore_WADPets <>4__this;
    public PurchaseModel purchase;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGStore_WADPets.<WaitPlayFoodAnim>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        int val_8;
        int val_9;
        int val_10;
        int val_13;
        object val_14;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_13 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_13;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_14 = val_1;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        val_13 = 1;
        this.<>1__state = val_13;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        Player val_2 = App.Player;
        decimal val_3 = PetsFood;
        Player val_5 = App.Player;
        val_13 = 0;
        decimal val_6 = System.Decimal.op_Implicit(value:  -958065632);
        this.<>4__this.foodAnim.Play(fromValue:  1 - (System.Decimal.op_Explicit(value:  new System.Decimal())), toValue:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_8, mid = val_7}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        return (bool)val_13;
        label_2:
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_12 = null;
        val_14 = val_12;
        val_12 = new UnityEngine.WaitForEndOfFrame();
        val_13 = 1;
        this.<>1__state = 2;
        label_4:
        this.<>2__current = val_14;
        return (bool)val_13;
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
