using UnityEngine;

namespace BlockPuzzleMagic
{
    [Serializable]
    public class ShapeBlockSpawn
    {
        // Fields
        public int BlockID;
        public UnityEngine.GameObject shapeBlock;
        public int spawnProbability;
        
        // Methods
        public ShapeBlockSpawn()
        {
            this.spawnProbability = 1;
        }
    
    }

}
