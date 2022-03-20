using UnityEngine;
public class TRVExpertReadyPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button closeButton;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -612092384, method:  new IntPtr(3682840672));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -612092384, method:  new IntPtr(3682849888));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void Continue()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        if((UnityEngine.Object.op_Implicit(exists:  -611961952)) != false)
        {
                GameBehavior val_5 = App.getBehavior;
            if(0 != 0)
        {
            goto label_9;
        }
        
        }
        else
        {
                GameBehavior val_7 = App.getBehavior;
        }
        
        label_9:
        UnityEngine.GameObject val_9 = this.gameObject;
        SLCWindow.CloseWindow(window:  -611961952, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -611849952, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVExpertReadyPopup()
    {
    
    }

}
