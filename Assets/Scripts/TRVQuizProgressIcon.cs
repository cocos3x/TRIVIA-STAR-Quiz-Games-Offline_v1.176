using UnityEngine;
public class TRVQuizProgressIcon : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image checkMarkOverlay;
    private UnityEngine.UI.Image highlight;
    private UnityEngine.UI.Image incorrectOverlay;
    
    // Methods
    public void SetupIcon(TRVQuestionHistory history, bool firstQuestion, bool highlightMe = False)
    {
        bool val_7;
        var val_8;
        val_7 = firstQuestion;
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.enabled = val_7;
        UnityEngine.GameObject val_3 = this.highlight.gameObject;
        this.highlight.SetActive(value:  highlightMe);
        UnityEngine.GameObject val_4 = this.checkMarkOverlay.gameObject;
        if(history != 0)
        {
                val_7 = history.pointsGained;
            if(val_7 > 0)
        {
                0 = 1;
        }
        
            this.checkMarkOverlay.SetActive(value:  true);
            UnityEngine.GameObject val_5 = this.incorrectOverlay.gameObject;
            if(history.pointsGained < 1)
        {
                val_8 = 1;
        }
        
        }
        else
        {
                this.checkMarkOverlay.SetActive(value:  false);
            UnityEngine.GameObject val_6 = this.incorrectOverlay.gameObject;
            val_8 = 0;
        }
        
        this.incorrectOverlay.SetActive(value:  false);
    }
    public TRVQuizProgressIcon()
    {
    
    }

}
