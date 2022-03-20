using UnityEngine;
public class WGPetsScreenProxy : MonoBehaviour
{
    // Methods
    public void ShowPetsMainScreen()
    {
        WADPetsScreenUI.ShowMainScreen();
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  27401568, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGPetsScreenProxy()
    {
    
    }

}
