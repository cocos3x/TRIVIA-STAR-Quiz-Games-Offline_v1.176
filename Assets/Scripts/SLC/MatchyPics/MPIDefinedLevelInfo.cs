using UnityEngine;

namespace SLC.MatchyPics
{
    [Serializable]
    public class MPIDefinedLevelInfo
    {
        // Fields
        public int Height;
        public int Width;
        public int Time;
        public SLC.MatchyPics.MPIMovementMechanic MovementMechanic;
        public SLC.MatchyPics.MPIBombMechanic BombMechanic;
        
        // Methods
        public MPIDefinedLevelInfo()
        {
        
        }
    
    }

}
