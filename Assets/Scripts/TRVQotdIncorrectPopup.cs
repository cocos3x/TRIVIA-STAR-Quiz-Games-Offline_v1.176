using UnityEngine;
public class TRVQotdIncorrectPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button okButton;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -459671968, method:  new IntPtr(3835270304));
        this.okButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnClick_OK()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Complete();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -459551776, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -459439776, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVQotdIncorrectPopup()
    {
    
    }

}
