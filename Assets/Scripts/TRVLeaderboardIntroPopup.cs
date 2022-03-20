using UnityEngine;
public class TRVLeaderboardIntroPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button continueButton;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -595078320, method:  new IntPtr(3699854736));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -595078320, method:  new IntPtr(3699863952));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnContinueClick()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -594948912, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -594836912, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVLeaderboardIntroPopup()
    {
    
    }

}
