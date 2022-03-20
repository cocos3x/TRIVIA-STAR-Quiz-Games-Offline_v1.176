using UnityEngine;
public class GiftRewardTypeChance
{
    // Fields
    public GiftRewardType RewardType;
    public int Chance;
    
    // Methods
    public GiftRewardTypeChance(GiftRewardType rewardType, int chance)
    {
        this.RewardType = rewardType;
        this.Chance = chance;
    }

}
