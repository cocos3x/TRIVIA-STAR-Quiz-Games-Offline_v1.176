using UnityEngine;
private sealed class BingoEventHandler.<>c__DisplayClass61_0
{
    // Fields
    public System.Collections.Generic.List<LineWord> words;
    public BingoEventHandler <>4__this;
    public LineWord answer;
    
    // Methods
    public BingoEventHandler.<>c__DisplayClass61_0()
    {
    
    }
    internal bool <TryPlaceBall>b__0(int x)
    {
        var val_3;
        if(true <= x)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (x << 2);
        val_3 = 0;
        if(((0 + (x) << 2) + 16 + 32) != 0)
        {
                return true;
        }
        
        if(((0 + (x) << 2) + 16 + 32) <= x)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + (x << 2);
        val_3 = 0;
        if((System.String.op_Inequality(a:  (0 + (x) << 2) + 16 + 12, b:  this.<>4__this.lastValidWord)) == false)
        {
                return true;
        }
        
        int val_2 = (this.<>4__this.previousWordIndex) - x;
        if((this.<>4__this) != 0)
        {
                val_3 = 1;
        }
        
        return true;
    }
    internal bool <TryPlaceBall>b__1(LineWord x)
    {
        if((this.<>4__this) != 0)
        {
                return System.String.op_Equality(a:  x.answer, b:  this.<>4__this.lastValidWord);
        }
        
        return System.String.op_Equality(a:  x.answer, b:  this.<>4__this.lastValidWord);
    }
    internal bool <TryPlaceBall>b__2(Cell x)
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
