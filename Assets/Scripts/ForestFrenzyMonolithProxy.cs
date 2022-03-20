using UnityEngine;
public class ForestFrenzyMonolithProxy : MonoBehaviour
{
    // Fields
    public static ForestFrenzyMonolithProxy Instance;
    
    // Methods
    private void Awake()
    {
        ForestFrenzyMonolithProxy.Instance = this;
    }
    private void OnEnable()
    {
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  null, mode:  1);
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1390872352, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public ForestFrenzyMonolithProxy()
    {
    
    }

}
