using UnityEngine;
public class FPHHowToPlayPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text constantCostText;
    private UnityEngine.UI.Text vowelCostText;
    
    // Methods
    public void Start()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_2 = Localization.Localize(key:  -1635886752, defaultValue:  -1635886640, useSingularKey:  false);
        string val_3 = System.String.Format(format:  -1635886752, arg0:  13152256);
        string val_4 = Localization.Localize(key:  -1635882304, defaultValue:  -1635882416, useSingularKey:  false);
        string val_5 = System.String.Format(format:  -1635882304, arg0:  13152256);
        if(this.vowelCostText != 0)
        {
                return;
        }
    
    }
    public FPHHowToPlayPopup()
    {
    
    }

}
