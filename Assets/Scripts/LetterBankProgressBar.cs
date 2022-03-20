using UnityEngine;
public class LetterBankProgressBar : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject gift_1_group;
    private UnityEngine.UI.Text text_gift_1_requirement;
    private UnityEngine.GameObject gift_1_rewarded_group;
    private UnityEngine.GameObject gift_2_group;
    private UnityEngine.UI.Text text_gift_2_requirement;
    private UnityEngine.GameObject gift_2_rewarded_group;
    private UnityEngine.GameObject gift_3_group;
    private UnityEngine.UI.Text text_gift_3_requirement;
    private UnityEngine.GameObject gift_3_rewarded_group;
    private UnityEngine.UI.Slider slider;
    private UnityEngine.UI.Text text_current_bank_value;
    private float gift_1_percent;
    private float gift_2_percent;
    private float gift_3_percent;
    
    // Methods
    public void UpdateSlider()
    {
        var val_1 = 23758292;
        val_1 = 11879004 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        var val_2 = 23758230;
        val_2 = 11879080 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        this.UpdateSlider(sliderValue:  null);
    }
    public void UpdateSlider(float sliderValue)
    {
        var val_10;
        float val_13;
        float val_16;
        float val_19;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        float val_32 = 4.305727E-38f;
        val_32 = 11885340 + val_32;
        if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
        val_32 = null;
        val_32 = null;
        string val_1 = LetterBankEventHandler._CurrentBankValue.ToString();
        val_33 = null;
        val_33 = null;
        string val_2 = LetterBankEventHandler._Tier1RequiredPoints.ToString();
        val_34 = null;
        val_34 = null;
        string val_3 = LetterBankEventHandler._Tier2RequiredPoints.ToString();
        val_35 = null;
        val_35 = null;
        string val_4 = LetterBankEventHandler._Tier3RequiredPoints.ToString();
        if((UnityEngine.Object.op_Implicit(exists:  this.gift_1_rewarded_group)) != false)
        {
                var val_33 = 23751270;
            val_33 = 11886028 + val_33;
            if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
            val_36 = null;
            val_36 = null;
            if(LetterBankEventHandler._RewardedTier1 == true)
        {
                LetterBankEventHandler._RewardedTier1 = 1;
        }
        
            this.gift_1_rewarded_group.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.gift_2_rewarded_group)) != false)
        {
                var val_34 = 23751055;
            val_34 = 11886244 + val_34;
            if(val_34 == 0)
        {
                mem2[0] = 1;
        }
        
            val_37 = null;
            val_37 = null;
            if(LetterBankEventHandler._RewardedTier2 == true)
        {
                LetterBankEventHandler._RewardedTier2 = 1;
        }
        
            this.gift_2_rewarded_group.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.gift_3_rewarded_group)) != false)
        {
                var val_35 = 23750840;
            val_35 = 11886460 + val_35;
            if(val_35 == 0)
        {
                mem2[0] = 1;
        }
        
            val_38 = null;
            val_38 = null;
            if(LetterBankEventHandler._RewardedTier3 == true)
        {
                LetterBankEventHandler._RewardedTier3 = 1;
        }
        
            this.gift_3_rewarded_group.SetActive(value:  true);
        }
        
        UnityEngine.Transform val_8 = this.slider.transform;
        if(this.slider != 0)
        {
                if(null != null)
        {
                val_39 = 0;
        }
        
        }
        else
        {
                val_39 = 0;
        }
        
        UnityEngine.Vector2 val_9 = sizeDelta;
        UnityEngine.Transform val_11 = this.gift_1_group.transform;
        UnityEngine.Vector3 val_12 = localPosition;
        float val_36 = val_13;
        val_36 = val_36 / val_10;
        this.gift_1_percent = val_36;
        UnityEngine.Transform val_14 = this.gift_2_group.transform;
        UnityEngine.Vector3 val_15 = localPosition;
        float val_37 = val_16;
        val_37 = val_37 / val_10;
        this.gift_2_percent = val_37;
        UnityEngine.Transform val_17 = this.gift_3_group.transform;
        UnityEngine.Vector3 val_18 = localPosition;
        float val_38 = val_19;
        val_38 = val_38 / val_10;
        this.gift_3_percent = val_38;
        if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
        val_40 = null;
        val_40 = null;
        var val_39 = 23750275;
        val_39 = 11887028 + val_39;
        if(val_39 == 0)
        {
                val_40 = null;
            mem2[0] = 1;
        }
        
        val_40 = null;
        val_40 = null;
        val_40 = null;
        val_40 = null;
        val_40 = null;
        float val_21 = UnityEngine.Mathf.Min(a:  (float)LetterBankEventHandler._CurrentBankValue / (float)LetterBankEventHandler._Tier1RequiredPoints, b:  val_18.y);
        float val_23 = UnityEngine.Mathf.Max(a:  (float)LetterBankEventHandler._CurrentBankValue - (float)LetterBankEventHandler._Tier1RequiredPoints, b:  val_18.y);
        float val_24 = (float)LetterBankEventHandler._Tier2RequiredPoints - (float)LetterBankEventHandler._Tier1RequiredPoints;
        val_24 = 0 / val_24;
        float val_25 = UnityEngine.Mathf.Min(a:  val_24, b:  val_18.y);
        float val_27 = UnityEngine.Mathf.Max(a:  (float)LetterBankEventHandler._CurrentBankValue - (float)LetterBankEventHandler._Tier2RequiredPoints, b:  val_18.y);
        float val_28 = (float)LetterBankEventHandler._Tier3RequiredPoints - (float)LetterBankEventHandler._Tier2RequiredPoints;
        val_28 = 0 / val_28;
        float val_29 = UnityEngine.Mathf.Min(a:  val_28, b:  val_18.y);
        float val_40 = this.gift_2_percent;
        val_40 = this.gift_3_percent - val_40;
        float val_31 = 1065353216 * (val_40 - this.gift_1_percent);
        if(this.slider != 0)
        {
                return;
        }
    
    }
    public LetterBankProgressBar()
    {
    
    }

}
