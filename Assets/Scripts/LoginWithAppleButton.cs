using UnityEngine;
public class LoginWithAppleButton : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject overlayButton;
    
    // Methods
    private void Awake()
    {
    
    }
    private void OnEnable()
    {
        this.UpdateState();
    }
    public void OnClick()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        LogIn();
    }
    public void UpdateState()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        NGUITools.SetActive(go:  this.overlayButton, state:  IsSignInAvailable() ^ 1);
    }
    public LoginWithAppleButton()
    {
    
    }

}
