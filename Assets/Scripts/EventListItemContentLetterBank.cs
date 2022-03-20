using UnityEngine;
public class EventListItemContentLetterBank : EventListItemContentProgressbar
{
    // Fields
    private LetterBankProgressBar letterBankProgressBar;
    
    // Methods
    public override void SetupSlider(string sliderText, float sliderValue)
    {
        this.SetupSlider(sliderText:  sliderText, sliderValue:  sliderValue);
        this.letterBankProgressBar.UpdateSlider(sliderValue:  sliderValue);
    }
    public EventListItemContentLetterBank()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
