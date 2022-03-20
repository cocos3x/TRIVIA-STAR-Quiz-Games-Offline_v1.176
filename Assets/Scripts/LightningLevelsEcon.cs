using UnityEngine;
public class LightningLevelsEcon
{
    // Fields
    public int Reward;
    public GameEventRewardType RewardType;
    public int RequiredLevels;
    public int IntervalMin;
    public int IntervalMax;
    public int SecondsPerWord;
    
    // Methods
    public LightningLevelsEcon()
    {
        this.IntervalMax = 7;
        this.SecondsPerWord = 15;
    }

}
