using UnityEngine;
public class LightningWordsEcon
{
    // Fields
    public static GameEventRewardType rewardType;
    public static int reward;
    public static int requiredNumWords;
    public static float appearingChance;
    public static int duration;
    public static int maxNumPerLvl;
    
    // Methods
    public LightningWordsEcon()
    {
    
    }
    private static LightningWordsEcon()
    {
        LightningWordsEcon.reward = 200;
        LightningWordsEcon.requiredNumWords = 25;
        LightningWordsEcon.appearingChance = 0.05f;
        LightningWordsEcon.duration = 59;
        LightningWordsEcon.maxNumPerLvl = 3;
    }

}
