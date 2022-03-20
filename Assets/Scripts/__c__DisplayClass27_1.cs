using UnityEngine;
private sealed class GamePlay.<>c__DisplayClass27_1
{
    // Fields
    public int columnIndex;
    public BlockPuzzleMagic.GamePlay.<>c__DisplayClass27_0 CS$<>8__locals1;
    
    // Methods
    public GamePlay.<>c__DisplayClass27_1()
    {
    
    }
    internal bool <IsRowCompletelyFilled>b__0(BlockPuzzleMagic.GridCell o)
    {
        if(o.rowId != (this.CS$<>8__locals1.rowID))
        {
                return (bool)0;
        }
        
        int val_1 = this.columnIndex;
        val_1 = o.columnId - val_1;
        0 = val_1 >> 5;
        return (bool)0;
    }

}
