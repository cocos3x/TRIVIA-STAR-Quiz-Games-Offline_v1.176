using UnityEngine;
public class AlphabetLobbyButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button button;
    private UnityEngine.UI.Button lockedButton;
    private UnityEngine.GameObject lockIcon;
    private UnityEngine.UI.Text lockText;
    private UnityEngine.GameObject lockedTooltip;
    
    // Methods
    private void Start()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1573355856, name:  -2037002944);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1573355856, method:  new IntPtr(2721586416));
        this.button.m_OnClick.AddListener(call:  162246656);
    }
    private void onClick_Button()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void OnDeferredReady()
    {
        var val_8;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            goto label_14;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2100700048) == 0)
        {
            goto label_14;
        }
        
        GameEcon val_4 = App.getGameEcon;
        if(786450 == 1)
        {
            goto label_14;
        }
        
        if(Alphabet2Manager.IsAvailable == false)
        {
            goto label_17;
        }
        
        UnityEngine.GameObject val_6 = this.gameObject;
        this.SetActive(value:  true);
        val_8 = 1;
        goto label_20;
        label_14:
        UnityEngine.GameObject val_7 = this.gameObject;
        this.SetActive(value:  false);
        return;
        label_17:
        val_8 = 0;
        label_20:
        this.button.interactable = false;
    }
    private void OnEnable()
    {
        this.OnDeferredReady();
    }
    public AlphabetLobbyButton()
    {
    
    }

}
