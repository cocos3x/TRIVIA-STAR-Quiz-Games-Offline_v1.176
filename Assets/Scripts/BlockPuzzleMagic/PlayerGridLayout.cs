using UnityEngine;

namespace BlockPuzzleMagic
{
    public class PlayerGridLayout : GridLayout
    {
        // Fields
        public BlockPuzzleMagic.BlockData[] gridBlockData;
        
        // Methods
        public PlayerGridLayout(int ColumnCount, int[] GridData)
        {
            int val_2;
            BlockPuzzleMagic.BlockData[] val_3;
            var val_4;
            val_2 = ColumnCount;
            this.gridBlockData = null;
            val_3 = null;
            val_4 = 0;
            goto label_4;
            label_10:
            object val_1 = null;
            val_2 = this.gridBlockData;
            val_1 = new System.Object();
            typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_8 = 0;
            typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_C = 0;
            val_4 = 1;
            val_2[val_4] = val_1;
            val_3 = this.gridBlockData;
            label_4:
            if(val_4 < val_2[val_4])
            {
                goto label_10;
            }
        
        }
        public PlayerGridLayout(BlockPuzzleMagic.GridLayout target)
        {
            BlockPuzzleMagic.BlockData[] val_3;
            BlockPuzzleMagic.BlockData[] val_4;
            var val_5;
            val_3 = 35640177;
            BlockPuzzleMagic.GridLayout val_1 = target;
            val_1 = new BlockPuzzleMagic.GridLayout(target:  val_1);
            this.gridBlockData = null;
            val_4 = null;
            val_5 = 0;
            goto label_4;
            label_10:
            object val_2 = null;
            val_3 = this.gridBlockData;
            val_2 = new System.Object();
            typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_8 = 0;
            typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_C = 0;
            val_5 = 1;
            val_3[val_5] = val_2;
            val_4 = this.gridBlockData;
            label_4:
            if(val_5 < val_3[val_5])
            {
                goto label_10;
            }
        
        }
    
    }

}
