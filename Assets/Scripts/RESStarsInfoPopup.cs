using UnityEngine;
public class RESStarsInfoPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button okayButton;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -654863856, method:  new IntPtr(3640078416));
        this.okayButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnButtonClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -654743664, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public RESStarsInfoPopup()
    {
    
    }

}
