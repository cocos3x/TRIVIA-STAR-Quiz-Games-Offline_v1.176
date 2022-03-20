using UnityEngine;
public class TRVPromoCategoriesSliderTick : TRVDynamicSliderTick
{
    // Fields
    private UnityEngine.UI.Text rewardText;
    private UnityEngine.GameObject rewardGroup;
    
    // Methods
    public override string FormatMyText(int myDisplayAmount)
    {
        string val_1 = myDisplayAmount.ToString();
    }
    public void ShowRewardAmount(bool showReward, int rewardAmount = 0)
    {
        UnityEngine.GameObject val_1 = this.rewardGroup.gameObject;
        this.rewardGroup.SetActive(value:  showReward);
        string val_2 = rewardAmount.ToString();
        string val_3 = System.String.Format(format:  -588332288, arg0:  -567349996);
        if(this.rewardText != 0)
        {
                return;
        }
    
    }
    public TRVPromoCategoriesSliderTick()
    {
    
    }

}
