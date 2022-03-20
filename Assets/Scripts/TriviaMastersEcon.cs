using UnityEngine;
public class TriviaMastersEcon
{
    // Fields
    public int requirement;
    public TRVReward reward;
    public int minInterval;
    public int maxInterval;
    
    // Methods
    public TriviaMastersEcon()
    {
        this.requirement = 15;
        this.reward = new TRVReward(rewardType:  1, rewardAmount:  150);
        this.minInterval = 2;
        this.maxInterval = 4;
    }

}
