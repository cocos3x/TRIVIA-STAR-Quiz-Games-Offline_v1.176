using UnityEngine;
public class WGUpdatePromptPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button update_button;
    private UnityEngine.UI.Button close_button;
    private string current_url;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  79466240, method:  new IntPtr(79432000));
        this.update_button.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  79466240, method:  new IntPtr(79441216));
        this.close_button.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(string url, bool mustUpdate)
    {
        UnityEngine.GameObject val_1 = this.close_button.gameObject;
        this.close_button.SetActive(value:  mustUpdate ^ 1);
        this.current_url = url;
    }
    private void OnEnable()
    {
    
    }
    private void OnClick_update()
    {
        twelvegigs.plugins.SharePlugin.OpenURL(url:  this.current_url);
    }
    private void OnClick_close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  79955200, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGUpdatePromptPopup()
    {
        this.current_url = "";
    }

}
