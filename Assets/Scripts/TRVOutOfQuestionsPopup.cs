using UnityEngine;
public class TRVOutOfQuestionsPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button okButton;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -476974720, method:  new IntPtr(3817967552));
        this.okButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnClick_OK()
    {
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -476854528, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -476742528, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVOutOfQuestionsPopup()
    {
    
    }

}
