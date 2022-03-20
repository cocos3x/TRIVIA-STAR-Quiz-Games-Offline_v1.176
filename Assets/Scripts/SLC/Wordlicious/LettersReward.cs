using UnityEngine;

namespace SLC.Wordlicious
{
    public class LettersReward
    {
        // Fields
        public static System.Collections.Generic.Dictionary<int, int> GetRewardByWordLength;
        
        // Methods
        public LettersReward()
        {
        
        }
        private static LettersReward()
        {
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            if(null != 0)
            {
                    Add(key:  3, value:  1);
                Add(key:  4, value:  1);
                Add(key:  5, value:  1);
                Add(key:  6, value:  2);
            }
            else
            {
                    Add(key:  3, value:  1);
                Add(key:  4, value:  1);
                Add(key:  5, value:  1);
                Add(key:  6, value:  2);
            }
            
            Add(key:  7, value:  2);
            SLC.Wordlicious.LettersReward.GetRewardByWordLength = null;
        }
    
    }

}
