using UnityEngine;
private sealed class WGSnakesAndLaddersBoardPopup.<ShowRewardOnPawnLanded>d__40 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SnakesAndLaddersEvent.BoardSpaceReward reward;
    public WGSnakesAndLaddersBoardPopup <>4__this;
    public SnakesAndLaddersBoardSpace space;
    private string <source>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGSnakesAndLaddersBoardPopup.<ShowRewardOnPawnLanded>d__40(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_31;
        WGSnakesAndLaddersBoardPopup val_32;
        object val_33;
        val_31 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool);
        }
        
        val_32 = this.<>4__this;
        var val_1 = 7055304 + (7055304 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                7055304 + (this.<>1__state) << 2 = (7055304 + (this.<>1__state) << 2) & (this << (7055304 + (this.<>1__state) << 2));
            7055304 + (this.<>1__state) << 2 = (7055304 + (this.<>1__state) << 2) & (val_32 >> 32);
            mem2[0] = ((7055304 + (this.<>1__state) << 2 & (this) << 7055304 + (this.<>1__state) << 2) & ((int)this.<>4__this) >> 32) + this;
            (((7055304 + (this.<>1__state) << 2 & (this) << 7055304 + (this.<>1__state) << 2) & ((int)this.<>4__this) >> 32) + this) & (((this.<>4__this) << (32-5)) | ((this.<>4__this) << 5)) = ((((7055304 + (this.<>1__state) << 2 & (this) << 7055304 + (this.<>1__state) << 2) & ((int)this.<>4__this) >> 32) + this) & (((this.<>4__this) << (32-5)) | ((this.<>4__this) << 5))) & (val_32 >> 9);
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_2 = null;
        val_33 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_31 = 1;
        this.<>1__state = val_31;
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
