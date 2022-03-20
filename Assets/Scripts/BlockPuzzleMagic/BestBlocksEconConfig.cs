using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BestBlocksEconConfig : EconConfig
    {
        // Fields
        public BlockPuzzleMagic.GridLayoutDefinitions gridLayoutDefinitions;
        public BlockPuzzleMagic.GameReferenceData gameReferenceData;
        
        // Methods
        private void Awake()
        {
            mem[1152921514420650536] = 0;
        }
        public BestBlocksEconConfig()
        {
        
        }
    
    }

}
