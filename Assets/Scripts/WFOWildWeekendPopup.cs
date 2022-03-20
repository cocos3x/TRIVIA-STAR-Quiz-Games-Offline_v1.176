using UnityEngine;
public class WFOWildWeekendPopup : WildWeekendPopup
{
    // Methods
    public override void Setup(int levelsCompleted, int totalLevels, bool hasCollected, GameEventRewardType RewardType, System.DateTime eventEndDate, System.Action collectCallback, System.Action firstSeenCallback, WildWeekendHandler handler)
    {
        var val_1;
        System.Action val_4;
        var val_5;
        val_4 = collectCallback;
        RewardType = RewardType;
        val_5 = val_1;
        this.Setup(levelsCompleted:  levelsCompleted, totalLevels:  totalLevels, hasCollected:  hasCollected, RewardType:  RewardType, eventEndDate:  new System.DateTime(), collectCallback:  val_4, firstSeenCallback:  firstSeenCallback, handler:  handler);
        if(totalLevels <= levelsCompleted)
        {
                return;
        }
        
        string val_2 = totalLevels.ToString();
        string val_3 = System.String.Format(format:  -1283475344, arg0:  -1283463208);
    }
    public WFOWildWeekendPopup()
    {
    
    }

}
