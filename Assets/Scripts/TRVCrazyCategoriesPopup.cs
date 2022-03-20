using UnityEngine;
public class TRVCrazyCategoriesPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text descriptionText;
    private UnityEngine.UI.Text continueButtonText;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -425574064, method:  new IntPtr(3869351648));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -425574064, method:  new IntPtr(3869351648));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        string val_3 = Localization.Localize(key:  -433125216, defaultValue:  -433125392, useSingularKey:  false);
        string val_4 = System.String.Format(format:  -433125216, arg0:  13152256);
        string val_5 = Localization.Localize(key:  -425598160, defaultValue:  -425598240, useSingularKey:  false);
        if(this.continueButtonText != 0)
        {
                return;
        }
    
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -425437488, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnDisable()
    {
        if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
                return;
        }
        
        goto typeof(System.String).__il2cppRuntimeField_2C4;
    }
    public TRVCrazyCategoriesPopup()
    {
    
    }

}
