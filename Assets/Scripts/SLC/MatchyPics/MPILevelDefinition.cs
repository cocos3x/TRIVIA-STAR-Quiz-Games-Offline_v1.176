using UnityEngine;

namespace SLC.MatchyPics
{
    [Serializable]
    public class MPILevelDefinition
    {
        // Fields
        public int Height;
        public int Width;
        public int SelectionWeight;
        public int Time;
        
        // Properties
        public int ExtraTime { get; }
        
        // Methods
        public int get_ExtraTime()
        {
            int val_1 = this.Time;
            val_1 = val_1 + (val_1 >> 31);
            val_1 = val_1 >> 1;
            return (int)val_1;
        }
        public MPILevelDefinition()
        {
        
        }
    
    }

}
