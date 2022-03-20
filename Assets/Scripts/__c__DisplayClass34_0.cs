using UnityEngine;
private sealed class BlockShapeSpawner.<>c__DisplayClass34_0
{
    // Fields
    public int shapeID;
    
    // Methods
    public BlockShapeSpawner.<>c__DisplayClass34_0()
    {
    
    }
    internal bool <CreateShapeWithID>b__0(BlockPuzzleMagic.ShapeBlockSpawn o)
    {
        int val_1 = this.shapeID;
        val_1 = o.BlockID - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
