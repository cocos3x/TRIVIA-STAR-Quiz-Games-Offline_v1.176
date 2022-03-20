using UnityEngine;
public class UGUIClickableMask : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button;
    public System.Action OnClickAction;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -2002010256, method:  new IntPtr(2292932016));
        this.button.m_OnClick.AddListener(call:  162246656);
    }
    private void OnButtonClick()
    {
        if(this.OnClickAction == 0)
        {
                return;
        }
        
        this.OnClickAction.Invoke();
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -2001885968, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -2001769872, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public UGUIClickableMask()
    {
    
    }

}
