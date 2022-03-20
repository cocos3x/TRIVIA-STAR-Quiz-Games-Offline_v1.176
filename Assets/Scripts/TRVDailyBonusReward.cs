using UnityEngine;
public class TRVDailyBonusReward : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject coinRewardParent;
    private UnityEngine.GameObject expertRewardParent;
    private UnityEngine.UI.Text rewardText;
    private TRVExpertDisplay expertDisplay;
    
    // Methods
    public void InitCoinReward(int coins)
    {
        this.coinRewardParent.SetActive(value:  true);
        this.expertRewardParent.SetActive(value:  false);
        string val_1 = coins.ToString();
        if(this.rewardText != 0)
        {
                return;
        }
    
    }
    public void InitExpertReward(TRVExpert expert, TRVExpertProgressData pData)
    {
        this.coinRewardParent.SetActive(value:  false);
        this.expertRewardParent.SetActive(value:  true);
        this.expertDisplay.Init(me:  expert, progress:  pData, upgraded:  false, showName:  true);
    }
    public TRVDailyBonusReward()
    {
    
    }

}
