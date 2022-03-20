using UnityEngine;
public class FPHQOTDPhrase
{
    // Fields
    public RewardType rewardType;
    public int rewardAmount;
    public int tokensAmount;
    
    // Methods
    public FPHQOTDPhrase(RewardType rewardType, int rewardAmount, int tokens)
    {
        this.rewardType = rewardType;
        this.rewardAmount = rewardAmount;
        this.tokensAmount = tokens;
    }

}
