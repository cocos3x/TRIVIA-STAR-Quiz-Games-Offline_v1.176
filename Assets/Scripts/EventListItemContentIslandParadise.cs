using UnityEngine;
public class EventListItemContentIslandParadise : EventListItemContentProgressbar
{
    // Fields
    private UnityEngine.UI.Text rewardAmountText;
    private UnityEngine.UI.Image rewardIcon;
    private UnityEngine.Sprite rewIconCoins;
    private UnityEngine.Sprite rewIconGoldenCurrency;
    private UnityEngine.Sprite rewIconFood;
    
    // Methods
    public void SetupSlider(bool hasCollectedAllRewards, string sliderText, float sliderValue, RESEventRewardData currentReward)
    {
        var val_1;
        UnityEngine.UI.Image val_6;
        UnityEngine.Sprite val_7;
        if((val_1 == 0) || (hasCollectedAllRewards == true))
        {
            goto label_2;
        }
        
        this.SetupSlider(sliderText:  sliderText, sliderValue:  sliderValue);
        if((val_1 + 8) == 4)
        {
            goto label_3;
        }
        
        if((val_1 + 8) == 3)
        {
            goto label_4;
        }
        
        if((val_1 + 8) != 1)
        {
            goto label_5;
        }
        
        val_6 = this.rewardIcon;
        val_7 = this.rewIconCoins;
        goto label_9;
        label_2:
        this.SetupSlider(sliderText:  -1548952960, sliderValue:  sliderValue);
        UnityEngine.GameObject val_2 = this.rewardIcon.gameObject;
        this.rewardIcon.SetActive(value:  false);
        return;
        label_3:
        val_6 = this.rewardIcon;
        val_7 = this.rewIconFood;
        goto label_9;
        label_4:
        val_6 = this.rewardIcon;
        val_7 = this.rewIconGoldenCurrency;
        label_9:
        val_6.sprite = val_7;
        label_5:
        GameEcon val_4 = App.getGameEcon;
        string val_5 = val_1 + 16.ToString(format:  null);
        if(this.rewardAmountText == 0)
        {
            
        }
    
    }
    public EventListItemContentIslandParadise()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
