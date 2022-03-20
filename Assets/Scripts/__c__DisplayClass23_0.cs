using UnityEngine;
private sealed class BlockShapeSpawner.<>c__DisplayClass23_0
{
    // Fields
    public System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> shapesData;
    public BlockPuzzleMagic.BlockShapeSpawner <>4__this;
    
    // Methods
    public BlockShapeSpawner.<>c__DisplayClass23_0()
    {
    
    }
    internal void <Init>b__0()
    {
        var val_9;
        var val_10;
        BlockPuzzleMagic.BlockColor val_11;
        var val_12;
        var val_13;
        var val_14;
        BlockPuzzleMagic.BlockShapeSpawner val_15;
        BlockPuzzleMagic.ShapeInfo[] val_16;
        val_9 = this;
        val_10 = 4;
        goto label_1;
        label_34:
        if(35640045 < true)
        {
                if(true <= 35640045)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            BlockPuzzleMagic.GameReferenceData val_1 = BlockPuzzleMagic.GameReferenceData.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            BlockPuzzleMagic.BlockColor val_2 = static_value_0028000B.GetBlockColor(colorType:  static_value_0028000F);
            val_11 = static_value_0028000B;
            BlockPuzzleMagic.GameReferenceData val_3 = BlockPuzzleMagic.GameReferenceData.Instance;
            val_12 = null;
            val_12 = null;
            if(BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS != null)
        {
                val_13 = BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS;
            val_14 = UnityEngine.Random.Range(min:  0, max:  BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 12);
        }
        else
        {
                val_13 = 12;
            val_14 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
            BlockPuzzleMagic.BlockColorType[] val_6 = BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + (val_14 << 2);
            BlockPuzzleMagic.BlockColor val_7 = static_value_0028000B.GetBlockColor(colorType:  (BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + (val_5) << 2) + 16);
            val_11 = static_value_0028000B;
            val_15 = this.<>4__this;
            if(val_15 != 0)
        {
                val_16 = this.<>4__this.spawnedShapes;
        }
        else
        {
                val_16 = this.<>4__this.spawnedShapes;
            val_15 = this.<>4__this;
            if(val_15 == 0)
        {
                val_15 = 0;
        }
        
        }
        
            var val_9 = val_10;
            if(0 <= 35640045)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            BlockPuzzleMagic.ShapeInfo val_8 = val_15.CreateShapeWithID(shapeContainer:  2621443, shapeID:  static_value_0028000B, shapeColor:  val_11);
            val_9 = val_9;
            val_16[0] = val_15;
        }
        
        val_10 = val_9 + 1;
        label_1:
        val_9 = val_10 - 4;
        if(val_9 < val_15)
        {
            goto label_34;
        }
        
        this.<>4__this.CheckIfAvailableShapesArePlaceable();
    }

}
