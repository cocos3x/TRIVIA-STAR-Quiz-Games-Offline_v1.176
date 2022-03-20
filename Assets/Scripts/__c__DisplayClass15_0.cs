using UnityEngine;
private sealed class GridLayout.<>c__DisplayClass15_0
{
    // Fields
    public int cellId;
    
    // Methods
    public GridLayout.<>c__DisplayClass15_0()
    {
    
    }
    internal bool <GetOrAddExtraGridCellData>b__0(BlockPuzzleMagic.GridCellData cell)
    {
        int val_1 = this.cellId;
        val_1 = cell.cellId - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
