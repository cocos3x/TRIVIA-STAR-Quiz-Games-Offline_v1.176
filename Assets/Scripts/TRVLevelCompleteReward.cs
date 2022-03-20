using UnityEngine;
public class TRVLevelCompleteReward : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text rewardDescText;
    private UnityEngine.UI.Text rewardValueText;
    private UnityEngine.UI.Image rewardCurrencyImage;
    private UnityEngine.UI.Image cardMultiImage;
    private UnityEngine.Sprite coinSprite;
    private UnityEngine.Sprite starSprite;
    private UnityEngine.Sprite gemSprite;
    private System.Collections.Generic.List<UnityEngine.Sprite> cardSpecificSprites;
    
    // Properties
    public UnityEngine.Transform rewardCurrencyLocation { get; }
    
    // Methods
    public UnityEngine.Transform get_rewardCurrencyLocation()
    {
        if(this.rewardCurrencyImage != 0)
        {
                return this.rewardCurrencyImage.transform;
        }
        
        return this.rewardCurrencyImage.transform;
    }
    public void Init(TRVLevelReward myRew)
    {
        System.Collections.Generic.List<UnityEngine.Sprite> val_4;
        string val_1 = myRew.<value>k__BackingField.ToString();
        this.SetCurrencyImage(rw:  myRew);
        UnityEngine.GameObject val_2 = this.cardMultiImage.gameObject;
        val_4 = this.cardMultiImage;
        if((myRew.<cardMulti>k__BackingField) >= 1)
        {
                val_4.SetActive(value:  true);
            val_4 = this.cardSpecificSprites;
            if(val_4 < 1)
        {
                return;
        }
        
            val_4 = (myRew.<cardMulti>k__BackingField) - 1;
            if(val_4 >= val_4)
        {
                return;
        }
        
            if(val_4 <= val_4)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_3 = val_3 + (val_4 << 2);
            this.cardMultiImage.sprite = (0 + ((myRew.<cardMulti>k__BackingField - 1)) << 2) + 16;
            return;
        }
        
        val_4.SetActive(value:  false);
    }
    private void SetCurrencyImage(TRVLevelReward rw)
    {
        UnityEngine.UI.Image val_2;
        UnityEngine.Sprite val_3;
        if((rw.<rewardType>k__BackingField) == 2)
        {
            goto label_1;
        }
        
        if((rw.<rewardType>k__BackingField) == 1)
        {
            goto label_2;
        }
        
        if((rw.<rewardType>k__BackingField) != 0)
        {
                return;
        }
        
        val_2 = mem[R4 + 20];
        val_2 = R4 + 20;
        val_3 = mem[R4 + 28];
        val_3 = R4 + 28;
        goto label_4;
        label_1:
        val_2 = this.rewardCurrencyImage;
        val_3 = this.gemSprite;
        goto label_4;
        label_2:
        val_2 = this.rewardCurrencyImage;
        val_3 = this.starSprite;
        label_4:
        val_2.sprite = val_3;
    }
    public TRVLevelCompleteReward()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.cardSpecificSprites = null;
    }

}
