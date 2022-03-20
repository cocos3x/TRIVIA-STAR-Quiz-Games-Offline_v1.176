using UnityEngine;
private sealed class WGSnakesAndLaddersBoardUI.<ScrollToPosition>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SnakesAndLaddersEvent.WGSnakesAndLaddersBoardUI <>4__this;
    public int startSpace;
    public int endSpace;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGSnakesAndLaddersBoardUI.<ScrollToPosition>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SnakesAndLaddersEvent.WGSnakesAndLaddersBoardUI val_4;
        SnakesAndLaddersEvent.WGSnakesAndLaddersBoardUI val_5;
        int val_6;
        System.Collections.Generic.List<System.Single> val_7;
        if((this.<>1__state) != 0)
        {
                return false;
        }
        
        val_4 = this.<>4__this;
        this.<>1__state = 0;
        object val_1 = new System.Object();
        val_5 = this.<>4__this;
        typeof(WGSnakesAndLaddersBoardUI.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = val_5;
        if(this.startSpace == this.endSpace)
        {
                return false;
        }
        
        if(this.startSpace < this.endSpace)
        {
                15901804 = 15901808;
        }
        
        if(this.startSpace < this.endSpace)
        {
                0 = 1;
        }
        
        typeof(WGSnakesAndLaddersBoardUI.<>c__DisplayClass20_0).__il2cppRuntimeField_C = 1;
        typeof(WGSnakesAndLaddersBoardUI.<>c__DisplayClass20_0).__il2cppRuntimeField_14 = 0.02f;
        if(val_4 != 0)
        {
                val_6 = this.endSpace;
            val_7 = this.<>4__this.scrollPositions;
        }
        else
        {
                val_6 = this.endSpace;
            val_7 = 2621448;
        }
        
        int val_2 = val_6 - 1;
        val_5 = val_2 + (val_2 >> 31);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        var val_4 = 23;
        val_4 = val_4 + (val_5 << 2);
        typeof(WGSnakesAndLaddersBoardUI.<>c__DisplayClass20_0).__il2cppRuntimeField_10 = (23 + (((this.endSpace - 1) + ((this.endSpace - 1)) >> 31)) << 2) + 16;
        this.<>4__this.frameSkipper._framesToSkip = 2;
        val_4 = this.<>4__this.frameSkipper;
        System.Action val_3 = new System.Action(object:  432852992, method:  new IntPtr(685552064));
        this.<>4__this.frameSkipper.updateLogic = null;
        return false;
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
