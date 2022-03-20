using UnityEngine;
public class WGUserConsentPopup : MonoBehaviour
{
    // Fields
    public const string GDPRConsented = "GDPRConsented";
    private UnityEngine.UI.Button Button_Continue;
    private UnityEngine.UI.Button Button_TermsOfService;
    private UnityEngine.UI.Button Button_PrivacyPolicy;
    
    // Properties
    private string url_tos { get; }
    private string url_privacy { get; }
    
    // Methods
    private string get_url_tos()
    {
        AppConfigs val_1 = App.Configuration;
        if(1 != 0)
        {
                return;
        }
    
    }
    private string get_url_privacy()
    {
        AppConfigs val_1 = App.Configuration;
        if(1 != 0)
        {
                return;
        }
    
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  80766848, method:  new IntPtr(80723392));
        this.Button_Continue.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  80766848, method:  new IntPtr(80732608));
        this.Button_TermsOfService.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  80766848, method:  new IntPtr(80741824));
        this.Button_PrivacyPolicy.m_OnClick.AddListener(call:  162246656);
    }
    private void OnClick_Continue()
    {
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        2621448.Save(writePrefs:  true);
        WGBonusRewardsHandler val_3 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  true, reset:  false);
        UnityEngine.GameObject val_4 = this.gameObject;
        this.SetActive(value:  false);
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  80903424, aName:  -1919894256);
    }
    private void OnClick_TermsOfService()
    {
        string val_1 = this.url_tos;
        twelvegigs.plugins.SharePlugin.OpenURL(url:  81015424);
    }
    private void OnClick_PrivacyPolicy()
    {
        string val_1 = this.url_privacy;
        twelvegigs.plugins.SharePlugin.OpenURL(url:  81127424);
    }
    public WGUserConsentPopup()
    {
    
    }

}
