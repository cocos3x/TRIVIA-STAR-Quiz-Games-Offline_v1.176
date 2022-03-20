using UnityEngine;
public class FadeToBGTag : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -172578960, method:  new IntPtr(4122363312));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
    }
    private void OnLevelFinishedLoading(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.FindWithTag(tag:  -2110355776);
        if((-2110355776) == 0)
        {
                return;
        }
        
        object val_3 = R4.GetComponent<System.Object>();
        object val_4 = R5.GetComponent<System.Object>();
        R4.sprite = R5 + 108;
    }
    private void OnDestroy()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -172346768, method:  new IntPtr(4122363312));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  162459648);
    }
    public FadeToBGTag()
    {
    
    }

}
