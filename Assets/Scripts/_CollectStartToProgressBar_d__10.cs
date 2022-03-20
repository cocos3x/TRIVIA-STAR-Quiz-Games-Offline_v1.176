using UnityEngine;
private sealed class RESShortTermRestaurantProgress.<CollectStartToProgressBar>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESShortTermRestaurantProgress <>4__this;
    public float dealy;
    private int <lastTotalNeeds>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESShortTermRestaurantProgress.<CollectStartToProgressBar>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_28;
        object val_34;
        if((this.<>1__state) > 4)
        {
            goto label_1;
        }
        
        var val_1 = 5885412 + (5885412 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                5885412 + (this.<>1__state) << 2 = (5885412 + (this.<>1__state) << 2) & (this << (5885412 + (this.<>1__state) << 2));
            5885412 + (this.<>1__state) << 2 = (5885412 + (this.<>1__state) << 2) & ((R8) >> (5885412 + (this.<>1__state) << 2 & (this) << 5885412 + (this.<>1__state) << 2));
            5885412 + (this.<>1__state) << 2 = (5885412 + (this.<>1__state) << 2) & (this >> (5885412 + (this.<>1__state) << 2));
            5885412 + (this.<>1__state) << 2 = (5885412 + (this.<>1__state) << 2) & (((this) << (32-(((5885412 + (this.<>1__state) << 2 & (this) << 5885412 + (this.<>1__state) << 2) & (R8) >> (5885412 + (this.<>1__state) << 2 & (this) << 5885412 + (this.<>1__state) << 2)) & ((int)this) >> ((5885412 )) | ((this) << (((5885412 + (this.<>1__state) << 2 & (this) << 5885412 + (this.<>1__state) << 2) & (R8) >> (5885412 + (this.<>1__state) << 2 & (this) << 5885412 + (this.<>1__state) << 2)) & ((int)this) >> ((5885412 ));
            mem2[0] = ((((5885412 + (this.<>1__state) << 2 & (this) << 5885412 + (this.<>1__state) << 2) & (R8) >> (5885412 + (this.<>1__state) << 2 & (this) << 5885412 + (this.<>1__state) << 2)) & ((int)this) >> ((5885412 + IP;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_2;
        }
        
        this.<lastTotalNeeds>5__2 = this.<>4__this.totalNeeds;
        goto label_3;
        label_1:
        val_28 = 0;
        return (bool);
        label_2:
        this.<lastTotalNeeds>5__2 = 83886592;
        label_3:
        this.<>4__this.GetProgressNumber();
        UnityEngine.WaitForSeconds val_4 = null;
        val_34 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_28 = 1;
        this.<>1__state = val_28;
        this.<>2__current = val_34;
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
