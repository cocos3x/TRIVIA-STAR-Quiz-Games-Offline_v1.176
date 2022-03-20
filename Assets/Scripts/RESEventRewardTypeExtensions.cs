using UnityEngine;
public static class RESEventRewardTypeExtensions
{
    // Methods
    public static GameEventRewardType ToGameEventRewardType(RESEventRewardType rewardType)
    {
        rewardType = rewardType - 1;
        if(rewardType > 3)
        {
                rewardType = 0;
            return;
        }
    
    }

}
