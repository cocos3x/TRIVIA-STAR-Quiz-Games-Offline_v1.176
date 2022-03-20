using UnityEngine;
public class TRVStreakPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text streakText;
    
    // Methods
    private void OnEnable()
    {
        this.closeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -562610704, method:  new IntPtr(3732327472));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = currentStreak.ToString();
        if(this.streakText != 0)
        {
                return;
        }
    
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -562478224, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVStreakPopup()
    {
    
    }

}
