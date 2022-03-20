using UnityEngine;
public class WGEventButtonV2_IslandParadise : WGEventButtonV2
{
    // Fields
    private UnityEngine.UI.Image rewardImage;
    private UnityEngine.UI.Text rewardAmount;
    private UnityEngine.Sprite rewIconCoins;
    private UnityEngine.Sprite rewIconGoldenCurrency;
    private UnityEngine.Sprite rewIconFood;
    
    // Properties
    public UnityEngine.UI.Image RewardImage { get; }
    public UnityEngine.UI.Text RewardAmount { get; }
    
    // Methods
    public UnityEngine.UI.Image get_RewardImage()
    {
    
    }
    public UnityEngine.UI.Text get_RewardAmount()
    {
    
    }
    public void UpdateReward()
    {
        UnityEngine.UI.Image val_2;
        UnityEngine.Sprite val_3;
        IslandParadiseEventHandler._Instance.OnKeyBalanceChanged
        string val_1 = ToString();
        if((IslandParadiseEventHandler._Instance + 8) == 4)
        {
            goto label_4;
        }
        
        if((IslandParadiseEventHandler._Instance + 8) == 3)
        {
            goto label_5;
        }
        
        if((IslandParadiseEventHandler._Instance + 8) != 1)
        {
                return;
        }
        
        val_2 = this.rewardImage;
        val_3 = this.rewIconCoins;
        goto label_8;
        label_4:
        val_2 = this.rewardImage;
        val_3 = this.rewIconFood;
        goto label_8;
        label_5:
        val_2 = this.rewardImage;
        val_3 = this.rewIconGoldenCurrency;
        label_8:
        val_2.sprite = val_3;
    }
    public WGEventButtonV2_IslandParadise()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
