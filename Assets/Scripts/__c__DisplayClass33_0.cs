using UnityEngine;
private sealed class GamePlay.<>c__DisplayClass33_0
{
    // Fields
    public int adjustedRowIdForBlock;
    public int adjustedColIdForBlock;
    
    // Methods
    public GamePlay.<>c__DisplayClass33_0()
    {
    
    }
    internal bool <CheckShapeCanPlace>b__0(BlockPuzzleMagic.GridCell o)
    {
        if(o.rowId != this.adjustedRowIdForBlock)
        {
                return (bool)0;
        }
        
        int val_1 = this.adjustedColIdForBlock;
        val_1 = o.columnId - val_1;
        0 = val_1 >> 5;
        return (bool)0;
    }

}
