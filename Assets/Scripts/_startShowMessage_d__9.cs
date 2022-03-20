using UnityEngine;
private sealed class RESFTUXManager.<startShowMessage>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESFTUXManager.RESFTUXType ftuxType;
    public RestaurantRivals.RESFTUXManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESFTUXManager.<startShowMessage>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        object val_5;
        val_4 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_1 = null;
        val_5 = val_1;
        val_1 = new UnityEngine.WaitForEndOfFrame();
        val_4 = 1;
        this.<>1__state = val_4;
        this.<>2__current = val_5;
        return (bool)val_4;
        label_1:
        val_5 = this.<>4__this;
        this.<>1__state = 0;
        if((RestaurantRivals.RESFTUXManager.IsCompleteFTUX(FTUXType:  this.ftuxType)) == true)
        {
                return (bool)val_4;
        }
        
        val_4 = 0;
        val_5.ShowFTUX(FTUXType:  this.ftuxType, onComplete:  0);
        return (bool)val_4;
        label_2:
        this.<>1__state = 0;
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        val_4 = 1;
        return (bool)val_4;
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
