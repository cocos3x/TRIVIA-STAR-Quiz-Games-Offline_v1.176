using UnityEngine;
public class SettingsScene : MonoBehaviour
{
    // Fields
    private static string URL_PREFIX_KEY;
    public UnityEngine.UI.InputField urlPrefixInput;
    public UnityEngine.UI.Text sdkVersionText;
    private string urlPrefix;
    
    // Methods
    public static void InitializeSettings()
    {
        null = null;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  SettingsScene.URL_PREFIX_KEY, defaultValue:  1098586544);
        AudienceNetwork.AdSettings.SetUrlPrefix(urlPrefix:  SettingsScene.URL_PREFIX_KEY);
    }
    private void Start()
    {
        null = null;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  SettingsScene.URL_PREFIX_KEY, defaultValue:  1098586544);
        this.urlPrefix = SettingsScene.URL_PREFIX_KEY;
        this.urlPrefixInput.text = SettingsScene.URL_PREFIX_KEY;
        string val_2 = AudienceNetwork.SdkVersion.Build;
        if(this.sdkVersionText == 0)
        {
            
        }
    
    }
    public void OnEditEnd(string prefix)
    {
        this.urlPrefix = prefix;
        this.SaveSettings();
    }
    public void SaveSettings()
    {
        null = null;
        UnityEngine.PlayerPrefs.SetString(key:  SettingsScene.URL_PREFIX_KEY, value:  this.urlPrefix);
        AudienceNetwork.AdSettings.SetUrlPrefix(urlPrefix:  this.urlPrefix);
    }
    public void AdViewScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  2114011904);
    }
    public void InterstitialAdScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  2115745728);
    }
    public void RewardedVideoAdScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  2112003456);
    }
    public SettingsScene()
    {
    
    }
    private static SettingsScene()
    {
        SettingsScene.URL_PREFIX_KEY = "URL_PREFIX";
    }

}
