using UnityEngine;
public class EventListItemContentAttackMadness : EventListItemContentProgressbar
{
    // Fields
    private UnityEngine.UI.Image rewardIcon;
    private UnityEngine.UI.Text rewardAmountText;
    private UnityEngine.Sprite rewIconCoins;
    private UnityEngine.Sprite rewIconGoldenCurrency;
    private UnityEngine.Sprite rewIconFood;
    
    // Methods
    public void SetupSlider(string sliderText, float sliderValue, bool eventCompleted, RESEventRewardData rewardData)
    {
        var val_1;
        UnityEngine.UI.Image val_6;
        UnityEngine.Sprite val_7;
        if(rewardData != 0)
        {
                UnityEngine.GameObject val_2 = this.rewardIcon.gameObject;
            this.rewardIcon.SetActive(value:  false);
            return;
        }
        
        if((val_1 + 8) == 4)
        {
            goto label_5;
        }
        
        if((val_1 + 8) == 3)
        {
            goto label_6;
        }
        
        if((val_1 + 8) != 1)
        {
            goto label_7;
        }
        
        val_6 = this.rewardIcon;
        val_7 = this.rewIconCoins;
        goto label_9;
        label_5:
        val_6 = this.rewardIcon;
        val_7 = this.rewIconFood;
        goto label_9;
        label_6:
        val_6 = this.rewardIcon;
        val_7 = this.rewIconGoldenCurrency;
        label_9:
        val_6.sprite = val_7;
        label_7:
        GameEcon val_4 = App.getGameEcon;
        string val_5 = val_1 + 16.ToString(format:  null);
        if(this.rewardAmountText == 0)
        {
            
        }
    
    }
    public EventListItemContentAttackMadness()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
