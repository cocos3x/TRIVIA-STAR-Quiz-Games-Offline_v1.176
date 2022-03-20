using UnityEngine;
private sealed class WGSnakesAndLaddersBoardUI.<MovePawnAndScrollCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SnakesAndLaddersEvent.WGSnakesAndLaddersBoardUI <>4__this;
    public int start;
    public int end;
    public int final;
    public System.Action onPawnLanded;
    private UnityEngine.Coroutine <scrollCoroutine>5__2;
    private int <i>5__3;
    private SnakesAndLaddersBoardSpace <space>5__4;
    private bool <isDifferentRow>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGSnakesAndLaddersBoardUI.<MovePawnAndScrollCoroutine>d__24(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_44;
        object val_45;
        val_44 = 0;
        if((this.<>1__state) > 6)
        {
                return (bool);
        }
        
        var val_1 = 15899380 + (15899380 + (this.<>1__state) << 2);
        if((this.<>1__state) == 6)
        {
                15899380 + (this.<>1__state) << 2 = (15899380 + (this.<>1__state) << 2) & ((IP) << 15899380 + (this.<>1__state) << 2);
            15899380 + (this.<>1__state) << 2 = (15899380 + (this.<>1__state) << 2) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            15899380 + (this.<>1__state) << 2 = (15899380 + (this.<>1__state) << 2) & ((IP) << 2);
            15899380 + (this.<>1__state) << 2 = (15899380 + (this.<>1__state) << 2) & ((15899380 + (this.<>1__state) << 2) >> 2);
            15899380 + (this.<>1__state) << 2 = this * R2;
            15899380 + (this.<>1__state) << 2 = (15899380 + (this.<>1__state) << 2) & (((IP) << (32-7)) | ((IP) << 7));
            15899380 + (this.<>1__state) << 2 = (15899380 + (this.<>1__state) << 2) & (((((this * R2) & ((IP) << (32-7)) | ((IP) << 7))) << (32-this.<>4__this)) | ((((this * R2) & ((IP) << (32-7)) | ((IP) << 7))) << this.<>4__this));
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_2 = null;
        val_45 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_44 = 1;
        this.<>1__state = val_44;
        this.<>2__current = val_45;
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
