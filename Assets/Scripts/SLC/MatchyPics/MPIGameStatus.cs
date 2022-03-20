using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIGameStatus : EventProgression
    {
        // Fields
        public System.Collections.Generic.List<int> SeenImageSets;
        private const string PREF_MPI_GAME_STATUS = "mpi_game_status";
        private const string SEEN_IMG_SETS_KEY = "seen_img_sets";
        
        // Methods
        public override void LoadFromJSON()
        {
        
        }
        public override void SaveToJSON()
        {
        
        }
        public MPIGameStatus()
        {
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            this.SeenImageSets = null;
        }
    
    }

}
