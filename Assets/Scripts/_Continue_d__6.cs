using UnityEngine;
private sealed class TRVExtraLifeAwarded.<Continue>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVExtraLifeAwarded <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVExtraLifeAwarded.<Continue>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        object val_13;
        val_12 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 8033556 + (8033556 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                8033556 + (this.<>1__state) << 2 = (8033556 + (this.<>1__state) << 2) & ((8033556 + (this.<>1__state) << 2) << (8033556 + (this.<>1__state) << 2));
            8033556 + (this.<>1__state) << 2 = (8033556 + (this.<>1__state) << 2) & (((int)R8) >> (8033556 + (this.<>1__state) << 2 & (8033556 + (this.<>1__state) << 2) << 8033556 + (this.<>1__state) << 2));
            mem2[0] = ((8033556 + (this.<>1__state) << 2 & (8033556 + (this.<>1__state) << 2) << 8033556 + (this.<>1__state) << 2) & ((int)R8) >> (8033556 + (this.<>1__state) << 2 & (8033556 + (this.<>1__state) << 2) << 80 + R8;
        }
        
        this.<>1__state = 0;
        val_13 = 0;
        this.<>4__this.continueButton.interactable = false;
        val_12 = 1;
        this.<>1__state = val_12;
        this.<>2__current = val_13;
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
