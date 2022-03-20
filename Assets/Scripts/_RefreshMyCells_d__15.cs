using UnityEngine;
private sealed class TournamentsMembersListView.<RefreshMyCells>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public bool refill;
    public TournamentsMembersListView <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TournamentsMembersListView.<RefreshMyCells>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        object val_3;
        if((this.<>1__state) != 1)
        {
                val_2 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_1 = null;
            val_3 = val_1;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            val_2 = 1;
            this.<>1__state = val_2;
            this.<>2__current = val_3;
            return (bool)val_2;
        }
        
        val_3 = this.<>4__this;
        this.<>1__state = 0;
        if(this.refill != false)
        {
                val_2 = 0;
            this.<>4__this.loopScrollRect.RefillCells(offset:  0);
            return (bool)val_2;
        }
        
        val_2 = 0;
        this.<>4__this.loopScrollRect.RefreshCells();
        return (bool)val_2;
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
