using UnityEngine;
private sealed class BingoEventHandler.<>c__DisplayClass62_0
{
    // Fields
    public BingoEventHandler <>4__this;
    public LineWord answer;
    
    // Methods
    public BingoEventHandler.<>c__DisplayClass62_0()
    {
    
    }
    internal bool <MoveOrRemoveKey>b__0(LineWord x)
    {
        if((this.<>4__this) != 0)
        {
                return System.String.op_Equality(a:  x.answer, b:  this.<>4__this.lastValidWord);
        }
        
        return System.String.op_Equality(a:  x.answer, b:  this.<>4__this.lastValidWord);
    }
    internal bool <MoveOrRemoveKey>b__1(Cell x)
    {
        var val_3;
        if(this.answer != 0)
        {
                val_3 = 0;
            if((this.answer.cells.Contains(item:  x)) == true)
        {
                return (bool)val_3;
        }
        
        }
        
        val_3 = x.isShown >> 5;
        return (bool)val_3;
    }

}
