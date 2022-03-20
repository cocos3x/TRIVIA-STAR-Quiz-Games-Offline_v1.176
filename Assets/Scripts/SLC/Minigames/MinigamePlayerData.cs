using UnityEngine;

namespace SLC.Minigames
{
    [Serializable]
    public class MinigamePlayerData : EncodableModel
    {
        // Fields
        public int rankIndex;
        public int checkpointLevel;
        public int checkpointsReached;
        private System.Collections.Generic.List<int> rankCheckpoints;
        
        // Methods
        public float LevelsForNextRank()
        {
            float val_2 = (float)S0;
            val_2 = (float)this.GetCheckpointsCompletedInRank() / val_2;
            return (float)val_2;
        }
        public int GetCheckpointsCompletedInRank()
        {
            var val_1;
            System.Collections.Generic.List<System.Int32> val_2;
            val_1 = 0;
            goto label_1;
            label_9:
            val_1 = 1;
            label_1:
            val_2 = this.rankCheckpoints;
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            if(val_1 < true)
            {
                goto label_3;
            }
            
            return (int)true;
            label_2:
            val_2 = this.rankCheckpoints;
            if(val_2 != 0)
            {
                
            }
            else
            {
                    val_2 = 0;
            }
            
            if(val_1 >= R7)
            {
                    return (int)true;
            }
            
            label_3:
            if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = 0;
            val_1 = val_1 + 4;
            if(((0 + 4) + 16) <= this.checkpointLevel)
            {
                goto label_9;
            }
            
            return (int)val_1;
        }
        public MinigamePlayerData()
        {
            var val_2;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            if(null != 0)
            {
                    val_2 = 1152921510720759024;
                Add(item:  5);
                Add(item:  15);
                Add(item:  25);
                Add(item:  35);
                Add(item:  50);
                Add(item:  75);
            }
            else
            {
                    val_2 = 1152921510720759024;
                Add(item:  5);
                Add(item:  15);
                Add(item:  25);
                Add(item:  35);
                Add(item:  50);
                Add(item:  75);
            }
            
            Add(item:  100);
            this.rankCheckpoints = null;
        }
    
    }

}
