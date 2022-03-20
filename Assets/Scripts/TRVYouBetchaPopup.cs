using UnityEngine;
public class TRVYouBetchaPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button okayButton;
    private UnityEngine.UI.Text topText;
    private UnityEngine.UI.Text descText;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -433578064, method:  new IntPtr(3861347280));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -433578064, method:  new IntPtr(3861347280));
        this.okayButton.m_OnClick.AddListener(call:  162246656);
        string val_3 = Localization.Localize(key:  -433606608, defaultValue:  -433606704, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -433602176, defaultValue:  -433602384, useSingularKey:  false);
        float val_6 = 1f;
        val_6 = (TRVYouBetchaEventHandler.EVENT_TRACKING_ID + 28) + val_6;
        string val_5 = System.String.Format(format:  -433602176, arg0:  15282176);
        if(this.descText != 0)
        {
                return;
        }
    
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -433441488, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(TRVYouBetchaEventHandler.EVENT_TRACKING_ID == null)
        {
            
        }
    
    }
    public TRVYouBetchaPopup()
    {
    
    }

}
