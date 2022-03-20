using UnityEngine;
public class TRVMoreCategoriesPopup : MonoBehaviour
{
    // Fields
    public const string POPUP_SHOWN_KEY = "moreCatShown";
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button closeButton;
    private System.Collections.Generic.List<UnityEngine.UI.Text> categoryText;
    private System.Collections.Generic.List<UnityEngine.UI.Image> categoryImage;
    private System.Collections.Generic.List<string> categoriesToShow;
    
    // Methods
    private void OnEnable()
    {
        var val_6;
        var val_7;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -477700992, method:  new IntPtr(3817204256));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = null;
        val_6 = val_2;
        val_2 = new UnityEngine.Events.UnityAction(object:  -477700992, method:  new IntPtr(3817204256));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        val_7 = 4;
        var val_5 =  - 4;
        CPlayerPrefs.SetBool(key:  -717330672, value:  true);
        CPlayerPrefs.Save();
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -477543936, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVMoreCategoriesPopup()
    {
    
    }

}
