using UnityEngine;
private sealed class GameReferenceData.<>c__DisplayClass22_0
{
    // Fields
    public BlockPuzzleMagic.BlockColorType colorType;
    
    // Methods
    public GameReferenceData.<>c__DisplayClass22_0()
    {
    
    }
    internal bool <GetBlockColor>b__0(BlockPuzzleMagic.BlockColor obj)
    {
        BlockPuzzleMagic.BlockColorType val_1 = this.colorType;
        val_1 = obj.blockColor - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
