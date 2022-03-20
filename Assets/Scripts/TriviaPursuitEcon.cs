using UnityEngine;
public class TriviaPursuitEcon
{
    // Fields
    public int requirement;
    public TRVReward reward;
    public int rerollCost;
    public int minInterval;
    public int maxInterval;
    
    // Methods
    public TriviaPursuitEcon()
    {
        this.requirement = 3;
        this.reward = new TRVReward(rewardType:  1, rewardAmount:  120);
    }

}
