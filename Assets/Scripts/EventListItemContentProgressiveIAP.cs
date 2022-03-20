using UnityEngine;
public class EventListItemContentProgressiveIAP : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image fillBar;
    private UnityEngine.UI.Text fillText;
    private UnityEngine.UI.Slider sliderProgressBar;
    
    // Methods
    public void OnEnable()
    {
        var val_8;
        string val_9;
        int val_10;
        UnityEngine.UI.Text val_11;
        int val_12;
        val_8 = this;
        var val_7 = 26747302;
        val_7 = 8883876 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER;
        if(val_9 == null)
        {
            goto label_2;
        }
        
        if((TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 28) >= (System.Linq.Enumerable.Sum(source:  TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 24)))
        {
            goto label_3;
        }
        
        val_10 = val_9.GetCurrentTierProgress(calculatedProgress:  TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 28);
        val_11 = this.fillText;
        val_12 = val_9.GetCurrentTierRequirement(calculatedProgress:  TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 28);
        string val_4 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        val_9 = "{0}/{1}";
        if(val_10 == 0)
        {
            goto label_5;
        }
        
        float val_8 = (float)val_12;
        val_8 = (float)val_10 / val_8;
        goto label_6;
        label_3:
        this.SetBarProgress(progressAmount:  null);
        string val_5 = Localization.Localize(key:  -594516624, defaultValue:  -594516720, useSingularKey:  false);
        if(this.fillText != 0)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        }
        
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        label_5:
        label_6:
        R4.SetBarProgress(progressAmount:  null);
        label_2:
        var val_6 = FP - 24;
    }
    private void SetBarProgress(float progressAmount)
    {
        var val_4;
        UnityEngine.UI.Slider val_5;
        val_4 = 1152921504765685760;
        if(this.fillBar != 0)
        {
                this.fillBar.fillAmount = progressAmount;
        }
        
        val_5 = this.sliderProgressBar;
        if(val_5 == 0)
        {
                return;
        }
        
        if(this.sliderProgressBar == 0)
        {
            
        }
    
    }
    public EventListItemContentProgressiveIAP()
    {
    
    }

}
