using UnityEngine;
private sealed class ReturnGameGiftManager.<CheckReturnGameGiftAvailable>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ReturnGameGiftManager.<CheckReturnGameGiftAvailable>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 9943332 + (9943332 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                9943332 + (this.<>1__state) << 2 = (9943332 + (this.<>1__state) << 2) & ((9943332 + (this.<>1__state) << 2) << (9943332 + (this.<>1__state) << 2));
            9943332 + (this.<>1__state) << 2 = (9943332 + (this.<>1__state) << 2) & (-1);
            9943332 + (this.<>1__state) << 2 = (9943332 + (this.<>1__state) << 2) & (((((9943332 + (this.<>1__state) << 2 & (9943332 + (this.<>1__state) << 2) << 9943332 + (this.<>1__state) << 2) & -1)) << (32-((9943332 + (this.<>1__state) << 2 & (9943332 + (this.<>1__state) << 2) << 9943332 + (this.<>1__state) << 2) & -1))) | ((((9943332 + (this.<>1__state) << 2 & (9943332 + (this.<>1__state) << 2) << 9943332 + (this.<>1__state) << 2) & -1)) << ((9943332 + (this.<>1__state) << 2 & (9943332 + (this.<>1__state) << 2) << 9943332 + (this.<>1__state) << 2) & -1)));
            mem2[0] = (((9943332 + (this.<>1__state) << 2 & (9943332 + (this.<>1__state) << 2) << 9943332 + (this.<>1__state) << 2) & -1) & ((((9943332 + (this.<>1__state) << 2 & (9943332 + (this.<>1__state) << 2) << 99433 + this;
        }
        
        this.<>1__state = 0;
        0 = 1;
        this.<>1__state = 0;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
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
