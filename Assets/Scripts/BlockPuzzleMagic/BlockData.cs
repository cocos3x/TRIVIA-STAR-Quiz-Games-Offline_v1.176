using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BlockData
    {
        // Fields
        public BlockPuzzleMagic.BlockColorType fillColorType;
        public int breaksRequired;
        
        // Methods
        public BlockData()
        {
            this.fillColorType = 0;
            this.breaksRequired = 0;
        }
    
    }

}
