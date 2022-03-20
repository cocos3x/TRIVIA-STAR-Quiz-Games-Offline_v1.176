using UnityEngine;
public class RESBuildErrorPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button okayButton;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -658800352, method:  new IntPtr(3636141920));
        this.okayButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnButtonClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -658680160, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public RESBuildErrorPopup()
    {
    
    }

}
