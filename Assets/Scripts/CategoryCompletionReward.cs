using UnityEngine;
public class CategoryCompletionReward
{
    // Fields
    public string bundleId;
    public System.Collections.Generic.Dictionary<GameEventRewardType, System.Decimal> rewards;
    
    // Methods
    public CategoryCompletionReward(string id, System.Collections.Generic.Dictionary<GameEventRewardType, System.Decimal> allRewards)
    {
        val_1 = new System.Object();
        this.bundleId = id;
        this.rewards = val_1;
    }

}
