using UnityEngine;
private sealed class RESAttackScreenMain.<ShowStartUI>d__56 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESAttackScreenMain <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESAttackScreenMain.<ShowStartUI>d__56(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_14;
        int val_15;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 10534996 + (10534996 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                10534996 + (this.<>1__state) << 2 = (10534996 + (this.<>1__state) << 2) & ((10534996 + (this.<>1__state) << 2) << (10534996 + (this.<>1__state) << 2));
            10534996 + (this.<>1__state) << 2 = (10534996 + (this.<>1__state) << 2) & (((int)IP) >> 32);
            10534996 + (this.<>1__state) << 2 = (10534996 + (this.<>1__state) << 2) & 2095332352;
            10534996 + (this.<>1__state) << 2 = (10534996 + (this.<>1__state) << 2) & 523833088;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_2 = null;
            val_14 = val_2;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_15 = 1;
            this.<>1__state = val_15;
        }
        else
        {
                val_15 = 0;
            return (bool);
        }
        
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
