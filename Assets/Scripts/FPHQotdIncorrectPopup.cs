using UnityEngine;
public class FPHQotdIncorrectPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button okButton;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1608881872, method:  new IntPtr(2686060400));
        this.okButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnClick_OK()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Complete();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1608761680, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1608649680, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public FPHQotdIncorrectPopup()
    {
    
    }

}
