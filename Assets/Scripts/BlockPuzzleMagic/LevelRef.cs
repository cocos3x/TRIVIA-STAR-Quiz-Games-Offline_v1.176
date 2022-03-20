using UnityEngine;

namespace BlockPuzzleMagic
{
    public class LevelRef
    {
        // Fields
        public int levelId;
        public System.Collections.Generic.List<BlockPuzzleMagic.GoalRef> goals;
        public int layoutId;
        public int dotLayoutId;
        public int stoneLayoutId;
        public int loopLayoutId;
        public int colorsToRemove;
        public System.Collections.Generic.List<BlockPuzzleMagic.LevelMechanicMetadata> additionalMechanics;
        
        // Properties
        public bool HasDot { get; }
        public bool HasStone { get; }
        public bool HasLoop { get; }
        
        // Methods
        public bool get_HasDot()
        {
            if(this.dotLayoutId > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool get_HasStone()
        {
            if(this.stoneLayoutId > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool get_HasLoop()
        {
            if(this.loopLayoutId > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public LevelRef()
        {
        
        }
    
    }

}
