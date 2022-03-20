using UnityEngine;
public class NextRewardPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform titleTransform;
    private UnityEngine.Transform rewardGroup;
    private UnityEngine.UI.Image rewardImage;
    private UnityEngine.UI.Text rewardAmount;
    private UnityEngine.GameObject glow;
    private UnityEngine.Sprite rewIconCoins;
    private UnityEngine.Sprite rewIconGoldenCurrency;
    private UnityEngine.Sprite rewIconFood;
    private UnityEngine.Vector3 initialPos;
    private WGEventHandler eventHandler;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.rewardGroup.transform;
        UnityEngine.Vector3 val_2 = localPosition;
        this.UpdateReward();
    }
    public void SetUp(WGEventHandler handler)
    {
        this.eventHandler = handler;
    }
    public void UpdateReward()
    {
        UnityEngine.UI.Image val_2;
        UnityEngine.Sprite val_3;
        WGEventHandler val_2 = this.eventHandler;
        val_2 = val_2 + 16;
        string val_1 = ToString();
        if(this.eventHandler.myEvent == 4)
        {
            goto label_3;
        }
        
        if(this.eventHandler.myEvent == 3)
        {
            goto label_4;
        }
        
        if(this.eventHandler.myEvent != 1)
        {
                return;
        }
        
        val_2 = this.rewardImage;
        val_3 = this.rewIconCoins;
        goto label_7;
        label_3:
        val_2 = this.rewardImage;
        val_3 = this.rewIconFood;
        goto label_7;
        label_4:
        val_2 = this.rewardImage;
        val_3 = this.rewIconGoldenCurrency;
        label_7:
        val_2.sprite = val_3;
    }
    public System.Collections.IEnumerator PlayNextRewardSequence(WGEventButtonV2 eventButton)
    {
        typeof(NextRewardPopup.<PlayNextRewardSequence>d__13).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(NextRewardPopup.<PlayNextRewardSequence>d__13).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(NextRewardPopup.<PlayNextRewardSequence>d__13).__il2cppRuntimeField_14 = eventButton;
    }
    public NextRewardPopup()
    {
    
    }

}
