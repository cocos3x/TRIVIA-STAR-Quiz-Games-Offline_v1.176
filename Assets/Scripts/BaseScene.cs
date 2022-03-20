using UnityEngine;
public class BaseScene : MonoBehaviour
{
    // Methods
    private void Update()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        if((UnityEngine.Input.GetKey(key:  27)) == false)
        {
                return;
        }
        
        UnityEngine.Application.Quit();
    }
    public void LoadSettingsScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  2113243120);
    }
    public BaseScene()
    {
    
    }

}
