using UnityEngine;
public class WGExtraWordsInfoPopup : MonoBehaviour
{
    // Fields
    private System.Action onClosePopup;
    
    // Methods
    public void Init(System.Action onClose)
    {
        this.onClosePopup = onClose;
    }
    private void OnDisable()
    {
        if(this.onClosePopup != 0)
        {
                this.onClosePopup.Invoke();
        }
        
        this.onClosePopup = 0;
    }
    public WGExtraWordsInfoPopup()
    {
    
    }

}
