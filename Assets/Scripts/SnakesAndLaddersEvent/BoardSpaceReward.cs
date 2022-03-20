using UnityEngine;

namespace SnakesAndLaddersEvent
{
    public class BoardSpaceReward
    {
        // Fields
        public GiftRewardType RewardType;
        public int RewardValue;
        
        // Methods
        public BoardSpaceReward(GiftRewardType type, int reward)
        {
            this.RewardType = type;
            this.RewardValue = reward;
        }
    
    }

}
