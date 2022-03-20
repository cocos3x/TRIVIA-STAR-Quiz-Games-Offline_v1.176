using UnityEngine;
private sealed class MPIGiftRewardUI.<StartRevealingReward>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    private MPIGiftRewardUI.<>c__DisplayClass21_0 <>8__1;
    public MPIGiftRewardUI.GiftRewardRevealInfo reward;
    public MPIGiftRewardUI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MPIGiftRewardUI.<StartRevealingReward>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_9;
        int val_10;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 7866304 + (7866304 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                7866304 + (this.<>1__state) << 2 = (7866304 + (this.<>1__state) << 2) & ((7866304 + (this.<>1__state) << 2) << (7866304 + (this.<>1__state) << 2));
            7866304 + (this.<>1__state) << 2 = (7866304 + (this.<>1__state) << 2) & (this >> (7866304 + (this.<>1__state) << 2));
            7866304 + (this.<>1__state) << 2 = (7866304 + (this.<>1__state) << 2) & 3247047168;
            7866304 + (this.<>1__state) << 2 = (7866304 + (this.<>1__state) << 2) & (this << R2);
        }
        
            this.<>1__state = 0;
            object val_2 = null;
            val_9 = 0;
            val_2 = new System.Object();
            val_10 = 1;
            this.<>1__state = val_10;
            this.<>2__current = val_9;
            this.<>8__1 = val_2;
            return (bool);
        }
        
        val_10 = 0;
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
