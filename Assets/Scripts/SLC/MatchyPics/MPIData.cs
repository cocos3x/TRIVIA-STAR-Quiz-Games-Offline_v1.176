using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIData : ScriptableObject
    {
        // Fields
        public SLC.MatchyPics.MPIEcon Econ;
        public System.Collections.Generic.List<SLC.MatchyPics.MPILevelDefinition> LevelDefinitions;
        public System.Collections.Generic.List<SLC.MatchyPics.MPIImageSet> ImageSets;
        
        // Methods
        public MPIData()
        {
        
        }
    
    }

}
