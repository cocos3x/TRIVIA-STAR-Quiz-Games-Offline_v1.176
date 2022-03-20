using UnityEngine;
public class WGHowToPlayPopup : MonoBehaviour
{
    // Fields
    private UGUIPageDisplay pageDisplay;
    
    // Methods
    public void OpenToPageIndex(int index)
    {
        if(this.pageDisplay == 0)
        {
                return;
        }
        
        this.pageDisplay.SetToPage(index:  index, force:  false);
    }
    public void CloseWindow()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -21368512, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGHowToPlayPopup()
    {
    
    }

}
