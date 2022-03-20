using UnityEngine;
public class WGPushNotificationPrompt : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button yesButton;
    private UnityEngine.UI.Button noThanksButton;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  27645024, method:  new IntPtr(27609760));
        this.yesButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  27645024, method:  new IntPtr(27618976));
        this.noThanksButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetPromptSeen();
    }
    private void OnClickYes()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetNotifVisibility(enabled:  true);
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnClickNoThanks()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        var val_3 = 27043462;
        val_3 = 8587184 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGPushNotificationPrompt()
    {
    
    }

}
