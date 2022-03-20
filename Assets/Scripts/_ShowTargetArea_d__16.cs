using UnityEngine;
private sealed class WGSnakesAndLaddersBoardUI.<ShowTargetArea>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SnakesAndLaddersEvent.WGSnakesAndLaddersBoardUI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGSnakesAndLaddersBoardUI.<ShowTargetArea>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        SnakesAndLaddersEvent.Board val_6;
        object val_7;
        val_5 = 0;
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
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        val_6 = this.<>4__this.currentBoard;
        if(val_6 == 0)
        {
            goto label_5;
        }
        
        if((this.<>4__this.currentBoard.IsSeen) == false)
        {
            goto label_6;
        }
        
        label_18:
        this.<>4__this.SnapToPosition(spaceNum:  this.<>4__this.currentBoard.CurrentNumberSpace);
        goto label_7;
        label_2:
        this.<>1__state = 0;
        System.Collections.IEnumerator val_1 = this.<>4__this.ScrollToPosition(startSpace:  this.<>4__this.currentBoard.Definition.MaxSpaceCount, endSpace:  1);
        UnityEngine.Coroutine val_2 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        label_7:
        val_6 = this.<>4__this.currentBoard;
        if((this.<>4__this.currentBoard.CurrentNumberSpace) == 0)
        {
                return (bool)val_5;
        }
        
        this.<>4__this.SpawnPawn(num:  this.<>4__this.currentBoard.CurrentNumberSpace);
        UnityEngine.WaitForEndOfFrame val_3 = null;
        val_7 = val_3;
        val_3 = new UnityEngine.WaitForEndOfFrame();
        val_5 = 1;
        this.<>1__state = 2;
        goto label_14;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.SetPawnOnTop();
        return (bool)val_5;
        label_5:
        if((this.<>4__this.currentBoard) == 0)
        {
            goto label_17;
        }
        
        val_6 = this.<>4__this.currentBoard;
        if((this.<>4__this.currentBoard.IsSeen) == true)
        {
            goto label_18;
        }
        
        label_6:
        var val_5 = 19723400;
        this.<>4__this.currentBoard.IsSeen = true;
        val_5 = 15902392 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = true;
        }
        
        this.<>4__this.SnapToPosition(spaceNum:  this.<>4__this.currentBoard.Definition.MaxSpaceCount);
        UnityEngine.WaitForSeconds val_4 = null;
        val_7 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_5 = 1;
        this.<>1__state = val_5;
        label_14:
        this.<>2__current = val_7;
        return (bool)val_5;
        label_17:
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
