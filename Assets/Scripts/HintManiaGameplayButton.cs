using UnityEngine;
public class HintManiaGameplayButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button hintManiaButton;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.GameObject val_1 = this.hintManiaButton.gameObject;
        this.hintManiaButton.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1207392352, method:  new IntPtr(3087549920));
        this.hintManiaButton.m_OnClick.AddListener(call:  162246656);
        if(HintManiaEventHandler.HINT_MANIA_ID == null)
        {
                return;
        }
        
        this.CheckShowButton();
    }
    private void OnButtonClicked()
    {
        var val_3 = 21199873;
        val_3 = 14441948 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(HintManiaEventHandler.HINT_MANIA_ID == null)
        {
                return;
        }
        
        if(HintManiaEventHandler.HINT_MANIA_ID == null)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public void CheckShowButton()
    {
        if(HintManiaEventHandler.HINT_MANIA_ID == null)
        {
                return;
        }
        
        if(HintManiaEventHandler.HINT_MANIA_ID == null)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.hintManiaButton.gameObject;
        this.hintManiaButton.SetActive(value:  HintManiaEventHandler.HINT_MANIA_ID);
    }
    public HintManiaGameplayButton()
    {
    
    }

}
