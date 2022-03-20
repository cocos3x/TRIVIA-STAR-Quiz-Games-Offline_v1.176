using UnityEngine;
public class WGFreeAdsControlPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text title;
    private UnityEngine.UI.Text description;
    private UnityEngine.UI.Text continueText;
    private UnityEngine.UI.Button continueButton;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction val_11;
        if(this.title != 0)
        {
                string val_2 = Localization.Localize(key:  -39464832, defaultValue:  -39464928, useSingularKey:  false);
            val_11 = "thank_you_e_upper";
        }
        
        if(this.description != 0)
        {
                string val_4 = Localization.Localize(key:  -39456320, defaultValue:  -39456528, useSingularKey:  false);
            GameEcon val_5 = App.getGameEcon;
            string val_6 = System.String.Format(format:  -39456320, arg0:  13152256);
            val_11 = "free_ads_control_success_description";
        }
        
        if(this.continueText != 0)
        {
                string val_8 = Localization.Localize(key:  -1468908784, defaultValue:  -1621736080, useSingularKey:  false);
            val_11 = "continue_upper";
        }
        
        if(this.continueButton == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = new UnityEngine.Events.UnityAction(object:  -39406576, method:  new IntPtr(4255535696));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnContinueButtonClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGFreeAdsControlPopup()
    {
    
    }

}
