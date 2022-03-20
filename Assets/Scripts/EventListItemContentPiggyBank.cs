using UnityEngine;
public class EventListItemContentPiggyBank : EventListItemContentProgressbar
{
    // Fields
    private UnityEngine.GameObject bankFullGlow;
    
    // Methods
    public override void SetupSlider(string sliderText, float sliderValue)
    {
        var val_3;
        string val_4;
        val_3 = 35631141;
        val_4 = sliderText;
        this.SetupSlider(sliderText:  val_4, sliderValue:  sliderValue);
        if(this.bankFullGlow != 0)
        {
                if(this.bankFullGlow >= 0)
        {
                0 = 1;
        }
        
            this.bankFullGlow.SetActive(value:  true);
        }
        
        var val_2 = 26747661;
        val_2 = 8883516 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankV2Handler.minDowngradeTier == 0)
        {
                return;
        }
        
        if(this == 0)
        {
            
        }
    
    }
    public EventListItemContentPiggyBank()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
