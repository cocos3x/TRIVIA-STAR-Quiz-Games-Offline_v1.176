using UnityEngine;
private sealed class RESRaidAttackFlyout.<SlideInAndOut>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESRaidAttackFlyout <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESRaidAttackFlyout.<SlideInAndOut>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        var val_7;
        int val_8;
        val_6 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_0;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        System.Collections.IEnumerator val_1 = this.<>4__this.SlideIn();
        val_7 = this.<>4__this;
        goto label_4;
        label_0:
        val_8 = 0;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_6;
        }
        
        System.Collections.IEnumerator val_2 = this.<>4__this.SlideOut();
        val_7 = this.<>4__this;
        goto label_7;
        label_3:
        System.Collections.IEnumerator val_3 = 0.SlideIn();
        val_7 = 0;
        label_4:
        val_8 = 1;
        goto label_8;
        label_6:
        System.Collections.IEnumerator val_4 = 0.SlideOut();
        val_7 = 0;
        label_7:
        val_8 = 2;
        label_8:
        UnityEngine.Coroutine val_5 = this.<>4__this.StartCoroutine(routine:  0);
        this.<>2__current = this.<>4__this;
        val_6 = 1;
        label_5:
        this.<>1__state = val_8;
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
