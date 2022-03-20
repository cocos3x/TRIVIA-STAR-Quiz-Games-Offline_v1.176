using UnityEngine;
public class UserConsentManager : MonoBehaviour
{
    // Fields
    public const string UnlockSceneLoading = "UnlockSceneLoading";
    private UnityEngine.GameObject userConsentPopup;
    
    // Methods
    private void Start()
    {
        Player val_1 = App.Player;
        if(2621448.ShouldShowGdprConsent() != false)
        {
                NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -151478256, name:  -1919894256);
            this.userConsentPopup.SetActive(value:  true);
            return;
        }
        
        this.GDPRConsented();
    }
    private void GDPRConsented()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -151362160, aName:  -2043945328);
    }
    public UserConsentManager()
    {
    
    }

}
