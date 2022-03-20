using UnityEngine;
public class WADPetsInfoPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text description_4;
    private UnityEngine.UI.Button closeButton;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -141198976, method:  new IntPtr(4153743296));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        var val_3;
        string val_1 = Localization.Localize(key:  -141102624, defaultValue:  -141102784, useSingularKey:  false);
        val_3 = null;
        val_3 = null;
        string val_2 = System.String.Format(format:  -141102624, arg0:  13152256);
        if(this.description_4 != 0)
        {
                return;
        }
    
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -140958320, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WADPetsInfoPopup()
    {
    
    }

}
