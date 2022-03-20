using UnityEngine;

namespace BlockPuzzleMagic
{
    public class Level
    {
        // Fields
        public BlockPuzzleMagic.GameMode gameMode;
        public int levelId;
        public System.Collections.Generic.List<BlockPuzzleMagic.Goal> goals;
        public BlockPuzzleMagic.PlayerGridLayout gridLayout;
        public System.Collections.Generic.List<BlockPuzzleMagic.BlockColorType> colorsRemoved;
        public System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> usableShapeIds;
        public System.Collections.Generic.List<BlockPuzzleMagic.LevelMechanicMetadata> additionalMechanics;
        
        // Methods
        public Level()
        {
            this.gameMode = 2;
        }
        public void SetUsableShapeData(int containerId, int shapeId, BlockPuzzleMagic.BlockColorType shapeColor)
        {
            BlockPuzzleMagic.BlockColorType val_5;
            System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> val_6;
            val_5 = shapeColor;
            val_6 = this.usableShapeIds;
            if(val_6 != 0)
            {
                goto label_1;
            }
            
            val_6 = null;
            val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            BlockPuzzleMagic.ShapeInfoData val_2 = new BlockPuzzleMagic.ShapeInfoData();
            Add(item:  466718720);
            BlockPuzzleMagic.ShapeInfoData val_3 = new BlockPuzzleMagic.ShapeInfoData();
            Add(item:  466718720);
            BlockPuzzleMagic.ShapeInfoData val_4 = new BlockPuzzleMagic.ShapeInfoData();
            Add(item:  466718720);
            val_5 = val_5;
            this.usableShapeIds = val_6;
            if(val_6 == 0)
            {
                goto label_5;
            }
            
            label_1:
            var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_5 = val_5 + (containerId << 2);
            mem2[0] = shapeId;
            if(val_5 <= containerId)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (containerId << 2);
            mem2[0] = val_5;
            return;
            label_5:
        }
        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(value:  1268712000);
        }
        public static BlockPuzzleMagic.Level Parse(string _jsonString)
        {
            object val_1 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  _jsonString);
        }
    
    }

}
