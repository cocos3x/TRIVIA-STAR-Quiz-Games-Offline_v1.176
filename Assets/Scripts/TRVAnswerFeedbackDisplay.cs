using UnityEngine;
public class TRVAnswerFeedbackDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.Sprite correctSprite;
    private UnityEngine.Sprite incorrectSprite;
    private UnityEngine.UI.Image resultImage;
    private UnityEngine.UI.Text resultText;
    
    // Methods
    public void DisplayResult(bool correct)
    {
        twelvegigs.Autopilot.WUTAutopilotGameplay val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  -561198624);
        this.alpha = null;
        if(correct == true)
        {
                16 = 12;
        }
        
        this.resultImage.sprite = this.correctSprite;
        if(correct == true)
        {
                "INCORRECT" = "CORRECT";
        }
        
        if(correct == true)
        {
                "incorrect_upper" = "correct_upper";
        }
        
        string val_2 = Localization.Localize(key:  -561226928, defaultValue:  -561227120, useSingularKey:  false);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  true);
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  -561198624, endValue:  null, duration:  null);
    }
    public void Hide()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public TRVAnswerFeedbackDisplay()
    {
    
    }

}
