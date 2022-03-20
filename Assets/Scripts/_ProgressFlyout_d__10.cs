using UnityEngine;
private sealed class WGMessageFlyout.<ProgressFlyout>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGMessageFlyout <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGMessageFlyout.<ProgressFlyout>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        object val_11;
        val_10 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 8517352 + (8517352 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                8517352 + (this.<>1__state) << 2 = (8517352 + (this.<>1__state) << 2) & ((8517352 + (this.<>1__state) << 2) << (8517352 + (this.<>1__state) << 2));
            8517352 + (this.<>1__state) << 2 = (8517352 + (this.<>1__state) << 2) & (((int)R8) >> 32);
            mem2[0] = ((8517352 + (this.<>1__state) << 2 & (8517352 + (this.<>1__state) << 2) << 8517352 + (this.<>1__state) << 2) & ((int)R8) >> 32) + this;
            mem2[0] = ((8517352 + (this.<>1__state) << 2 & (8517352 + (this.<>1__state) << 2) << 8517352 + (this.<>1__state) << 2) & ((int)R8) >> 32) + this + R8;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_2 = null;
        val_11 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_10 = 1;
        this.<>1__state = val_10;
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
