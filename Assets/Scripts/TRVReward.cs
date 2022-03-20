using UnityEngine;
public class TRVReward
{
    // Fields
    public RewardType rewardType;
    public int rewardAmount;
    
    // Methods
    public TRVReward(RewardType rewardType, int rewardAmount)
    {
        this.rewardType = rewardType;
        this.rewardAmount = rewardAmount;
    }

}
