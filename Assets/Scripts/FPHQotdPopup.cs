using UnityEngine;
public class FPHQotdPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Button closeButton;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1608407248, method:  new IntPtr(2686525808));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1608407248, method:  new IntPtr(2686535024));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnClick_Play()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Play();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1608278864, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1608166864, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1608054864, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public FPHQotdPopup()
    {
    
    }

}
