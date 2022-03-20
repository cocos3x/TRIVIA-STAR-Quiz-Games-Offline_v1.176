using UnityEngine;
private sealed class BingoEventPopup.<CollectBallsAnimation>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BingoEventPopup <>4__this;
    private BingoEventPopup.<>c__DisplayClass42_0 <>8__1;
    private System.Collections.Generic.List<UnityEngine.GameObject> <goBalls>5__2;
    private int <i>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BingoEventPopup.<CollectBallsAnimation>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_41;
        object val_42;
        val_41 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool);
        }
        
        var val_1 = 10325136 + (10325136 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                10325136 + (this.<>1__state) << 2 = (10325136 + (this.<>1__state) << 2) & (35634030 << (10325136 + (this.<>1__state) << 2));
            10325136 + (this.<>1__state) << 2 = (10325136 + (this.<>1__state) << 2) & (((IP) << (32-1)) | ((IP) << 1));
            10325136 + (this.<>1__state) << 2 = R8 * (10325136 + (this.<>1__state) << 2);
            mem2[0] = (R8 * ((10325136 + (this.<>1__state) << 2 & (35634030) << 10325136 + (this.<>1__state) << 2) & ((IP) << (32-1)) | ((IP) << 1))) + 35634030;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_2 = null;
        val_42 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_41 = 1;
        this.<>1__state = val_41;
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
