using UnityEngine;
public class LeaderboardTierGridItem : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text tierRank;
    private UnityEngine.UI.Text tierReward;
    
    // Methods
    public void UpdateTier(LeaderboardTier tier)
    {
        var val_5;
        int val_6;
        UnityEngine.UI.Text val_7;
        UnityEngine.UI.Text val_8;
        var val_9;
        if(tier != 0)
        {
                val_5 = tier;
            val_6 = tier.upperLevel;
        }
        else
        {
                val_5 = 8;
            val_6 = 0;
        }
        
        if(0 != tier.lowerLevel)
        {
            goto label_3;
        }
        
        val_7 = this.tierRank;
        string val_1 = val_5.ToString();
        val_8 = val_5;
        if(val_7 != 0)
        {
            goto label_5;
        }
        
        goto label_5;
        label_3:
        val_8 = this.tierRank;
        if(tier.lowerLevel != 1)
        {
                val_9 = null;
            string val_2 = 13152256 + 1359327184 + 13152256;
        }
        else
        {
                val_9 = null;
            string val_3 = 13152256 + -1467947360(-1467947360);
        }
        
        val_7 = val_9;
        label_5:
        string val_4 = tier.reward.ToString();
        if(this.tierReward != 0)
        {
                return;
        }
    
    }
    public LeaderboardTierGridItem()
    {
    
    }

}
