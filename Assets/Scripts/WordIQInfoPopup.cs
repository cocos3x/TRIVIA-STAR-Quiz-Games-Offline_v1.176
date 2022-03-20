using UnityEngine;
public class WordIQInfoPopup : MonoBehaviour
{
    // Fields
    private const string info_1 = "Studies have shown that playing Word Collect can help improve Your Word IQ";
    private const string info_2 = "Learn New Words, complete your collection and advance your intellectual prowess";
    private const string info_3 = "Gain more Word IQ by clearing levels accurately";
    private UnityEngine.UI.Text info;
    private UnityEngine.UI.Button closeButton;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -931089168, method:  new IntPtr(3363853104));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        string val_1 = Localization.Localize(key:  -930988880, defaultValue:  -930988752, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "word_iq_info_popup_text_1";
        typeof(System.String[]).__il2cppRuntimeField_14 = "\n\n";
        string val_2 = Localization.Localize(key:  -930988288, defaultValue:  -930988528, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_18 = "word_iq_info_popup_text_2";
        typeof(System.String[]).__il2cppRuntimeField_1C = "\n\n";
        string val_3 = Localization.Localize(key:  -930987984, defaultValue:  -930988160, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_20 = "word_iq_info_popup_text_3";
        string val_4 = +477709520;
        if(this.info == 0)
        {
            
        }
    
    }
    public WordIQInfoPopup()
    {
    
    }
    private void <Start>b__5_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -930735760, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
