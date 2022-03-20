using UnityEngine;
public class ButtonOpenHelpShift : MyButton
{
    // Fields
    private bool isFeedbackPrompt;
    
    // Methods
    protected override void Start()
    {
        this.Start();
        Player val_1 = App.Player;
        if(16 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnEnable()
    {
        Player val_1 = App.Player;
        if(16 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  false);
    }
    public override void OnButtonClick()
    {
        Player val_1 = App.Player;
        if(16 != 0)
        {
                return;
        }
        
        R4.OnButtonClick();
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        ShowFAQs();
    }
    public ButtonOpenHelpShift()
    {
    
    }

}
