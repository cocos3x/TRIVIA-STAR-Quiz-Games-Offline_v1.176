using UnityEngine;
private sealed class WGChallengeFlyout.<ProgressFlyout>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGChallengeFlyout <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGChallengeFlyout.<ProgressFlyout>d__9(int <>1__state)
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
        
        var val_1 = 6727504 + (6727504 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                6727504 + (this.<>1__state) << 2 = (6727504 + (this.<>1__state) << 2) & ((6727504 + (this.<>1__state) << 2) << (6727504 + (this.<>1__state) << 2));
            6727504 + (this.<>1__state) << 2 = (6727504 + (this.<>1__state) << 2) & (((int)R8) >> 32);
            6727504 + (this.<>1__state) << 2 = (6727504 + (this.<>1__state) << 2) & 1348944400;
            6727504 + (this.<>1__state) << 2 = (6727504 + (this.<>1__state) << 2) & ((R8) >> 3);
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
