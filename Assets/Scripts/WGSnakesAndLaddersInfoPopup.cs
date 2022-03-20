using UnityEngine;
public class WGSnakesAndLaddersInfoPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1018772720, method:  new IntPtr(3276169552));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1018652528, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGSnakesAndLaddersInfoPopup()
    {
    
    }

}
