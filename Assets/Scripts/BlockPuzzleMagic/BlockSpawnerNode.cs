using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BlockSpawnerNode : MonoBehaviour
    {
        // Fields
        private int spawnerId;
        private UnityEngine.BoxCollider2D spawnerCollider;
        
        // Properties
        public int SpawnerId { get; }
        
        // Methods
        public int get_SpawnerId()
        {
            return (int)this.spawnerId;
        }
        private void OnRectTransformDimensionsChange()
        {
            var val_4 = 0;
            UnityEngine.Transform val_1 = this.transform;
            if(this != 0)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            if(this != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            label_3:
            if(null != null)
            {
                    val_4 = 0;
            }
            else
            {
                    val_4 = this;
            }
            
            label_6:
            UnityEngine.Rect val_2 = rect;
            UnityEngine.Vector2 val_3 = size;
            this.spawnerCollider.size = new UnityEngine.Vector2();
        }
        public bool ContainsShape()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            return UnityEngine.Object.op_Inequality(x:  (public static BlockPuzzleMagic.BlockShapeSpawner MonoSingleton<BlockPuzzleMagic.BlockShapeSpawner>::get_Instance().__il2cppRuntimeField_14 + (this.spawnerId) << 2) + 16, y:  0);
        }
        public BlockPuzzleMagic.ShapeInfo GetShape()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        public BlockSpawnerNode()
        {
        
        }
    
    }

}
