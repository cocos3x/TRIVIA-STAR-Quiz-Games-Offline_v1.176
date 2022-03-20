using UnityEngine;
public class TRVQotdPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Button closeButton;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -459197344, method:  new IntPtr(3835735712));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -459197344, method:  new IntPtr(3835744928));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnClick_Play()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Play();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -459068960, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -458956960, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -458844960, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVQotdPopup()
    {
    
    }

}
