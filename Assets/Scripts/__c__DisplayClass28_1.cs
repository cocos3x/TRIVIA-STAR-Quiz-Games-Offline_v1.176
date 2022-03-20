using UnityEngine;
private sealed class GamePlay.<>c__DisplayClass28_1
{
    // Fields
    public int rowIndex;
    public BlockPuzzleMagic.GamePlay.<>c__DisplayClass28_0 CS$<>8__locals1;
    
    // Methods
    public GamePlay.<>c__DisplayClass28_1()
    {
    
    }
    internal bool <IsColumnCompletelyFilled>b__0(BlockPuzzleMagic.GridCell o)
    {
        if(o.rowId != this.rowIndex)
        {
                return (bool)0;
        }
        
        int val_1 = this.CS$<>8__locals1.columnID;
        val_1 = o.columnId - val_1;
        0 = val_1 >> 5;
        return (bool)0;
    }

}
