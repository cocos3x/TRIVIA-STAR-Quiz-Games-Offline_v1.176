using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GameReferenceData : ScriptableObject
    {
        // Fields
        private BlockPuzzleMagic.ShapeBlockList shapeBlockList;
        private BlockPuzzleMagic.ShapeInfo powerupBombShapeInfoPrefab;
        private BlockPuzzleMagic.ShapeInfo powerupFillShapeInfoPrefab;
        private BlockPuzzleMagic.ShapeInfo powerupTrashShapeInfoPrefab;
        private UnityEngine.GameObject emptyGridCellTemplate;
        private UnityEngine.GameObject emptyBlockTemplate;
        private System.Collections.Generic.List<BlockPuzzleMagic.BlockColor> blockColors;
        
        // Properties
        public static BlockPuzzleMagic.GameReferenceData Instance { get; }
        public BlockPuzzleMagic.ShapeBlockList ShapeBlockList { get; }
        public BlockPuzzleMagic.ShapeInfo PowerupBombShapeInfoPrefab { get; }
        public BlockPuzzleMagic.ShapeInfo PowerupFillShapeInfoPrefab { get; }
        public BlockPuzzleMagic.ShapeInfo PowerupTrashShapeInfoPrefab { get; }
        public UnityEngine.GameObject EmptyGridCellTemplate { get; }
        public UnityEngine.GameObject EmptyBlockTemplate { get; }
        
        // Methods
        public static BlockPuzzleMagic.GameReferenceData get_Instance()
        {
            var val_2;
            var val_3;
            AppConfigs val_1 = App.Configuration;
            val_2 = 1152921505069891584;
            val_3 = 52;
            if(((328190 + (BlockPuzzleMagic.BestBlocksEconConfig.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) == null)
            {
                    (328190 + (BlockPuzzleMagic.BestBlocksEconConfig.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4 = 3748210;
                return;
            }
        
        }
        public BlockPuzzleMagic.ShapeBlockList get_ShapeBlockList()
        {
        
        }
        public BlockPuzzleMagic.ShapeInfo get_PowerupBombShapeInfoPrefab()
        {
        
        }
        public BlockPuzzleMagic.ShapeInfo get_PowerupFillShapeInfoPrefab()
        {
        
        }
        public BlockPuzzleMagic.ShapeInfo get_PowerupTrashShapeInfoPrefab()
        {
        
        }
        public BlockPuzzleMagic.ShapeInfo GetShapePrefabForPowerup(BlockPuzzleMagic.PowerUpType powerupType)
        {
            var val_1;
            BlockPuzzleMagic.ShapeInfo val_2;
            if(powerupType == 0)
            {
                goto label_0;
            }
            
            if(powerupType == 2)
            {
                goto label_1;
            }
            
            val_1 = 0;
            if(powerupType != 1)
            {
                    return;
            }
            
            val_2 = this.powerupBombShapeInfoPrefab;
            goto label_4;
            label_0:
            val_2 = this.powerupTrashShapeInfoPrefab;
            goto label_4;
            label_1:
            val_2 = this.powerupFillShapeInfoPrefab;
            label_4:
            val_1 = mem[this.powerupFillShapeInfoPrefab];
        }
        public UnityEngine.GameObject get_EmptyGridCellTemplate()
        {
        
        }
        public UnityEngine.GameObject get_EmptyBlockTemplate()
        {
        
        }
        public BlockPuzzleMagic.BlockColor GetBlockColor(BlockPuzzleMagic.BlockColorType colorType)
        {
            BlockPuzzleMagic.BlockColorType val_7;
            var val_8;
            var val_9;
            val_7 = colorType;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_8 = val_1;
                typeof(GameReferenceData.<>c__DisplayClass22_0).__il2cppRuntimeField_8 = val_7;
            }
            else
            {
                    val_8 = 8;
                mem[8] = val_7;
                val_7 = mem[8];
            }
            
            if(val_7 == 0)
            {
                goto label_3;
            }
            
            if(val_8 != 1)
            {
                goto label_5;
            }
            
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            object val_3 = null;
            val_9 = val_3;
            val_3 = new System.Object();
            typeof(BlockPuzzleMagic.BlockColor).__il2cppRuntimeField_8 = 1;
            return;
            label_3:
            val_7 = 0;
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            object val_5 = null;
            val_9 = val_5;
            val_5 = new System.Object();
            typeof(BlockPuzzleMagic.BlockColor).__il2cppRuntimeField_8 = val_7;
            return;
            label_5:
            System.Predicate<ZooTile> val_6 = new System.Predicate<ZooTile>(object:  464429056, method:  new IntPtr(1250917840));
            if(this.blockColors != 0)
            {
                    return this.blockColors.Find(match:  8040448);
            }
            
            return this.blockColors.Find(match:  8040448);
        }
        public GameReferenceData()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.blockColors = null;
        }
    
    }

}
