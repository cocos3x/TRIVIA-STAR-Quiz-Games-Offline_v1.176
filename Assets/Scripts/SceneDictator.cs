using UnityEngine;
public class SceneDictator : MonoSingletonSelfGenerating<SceneDictator>
{
    // Fields
    public System.Action<SceneType> OnSceneLoaded;
    public System.Action<SceneType> OnSceneUnloaded;
    private static SceneType lastOverlayedScene;
    private readonly System.Collections.Generic.List<SceneType> acceptableActiveSceneTypes;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -203852352, method:  new IntPtr(4091088896));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>(object:  -203852352, method:  new IntPtr(4091089920));
        UnityEngine.SceneManagement.SceneManager.add_sceneUnloaded(value:  162353152);
    }
    private void HandleUnitySceneUnloaded(UnityEngine.SceneManagement.Scene arg0)
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = arg0.m_Handle.name;
        if(this.OnSceneUnloaded != 0)
        {
                this.OnSceneUnloaded.Invoke(obj:  0);
        }
        
        GameBehavior val_3 = App.getBehavior;
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_5 = val_4.m_Handle.name;
        val_6 = null;
        val_6 = null;
        SceneDictator.lastOverlayedScene = 0;
    }
    private void HandleUnitySceneLoaded(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode arg1)
    {
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = arg0.m_Handle.name;
        if((this.acceptableActiveSceneTypes.Contains(item:  0)) != false)
        {
                bool val_4 = UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = arg0.m_Handle});
        }
        
        val_5 = null;
        val_5 = null;
        SceneDictator.lastOverlayedScene = 0;
        if(this.OnSceneLoaded == 0)
        {
                return;
        }
        
        this.OnSceneLoaded.Invoke(obj:  0);
    }
    public static bool IsInGameScene()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return false;
        }
        
        return false;
    }
    public static SceneType GetActiveSceneType()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public static SceneType GetOverlayedSceneType()
    {
        null = null;
    }
    public SceneDictator()
    {
        var val_2;
        System.Collections.Generic.List<WordPets.WordPetType> val_1 = new System.Collections.Generic.List<WordPets.WordPetType>();
        if(null != 0)
        {
                val_2 = 1152921512993613056;
            Add(item:  1);
            Add(item:  2);
            Add(item:  4);
            Add(item:  3);
        }
        else
        {
                val_2 = 1152921512993613056;
            Add(item:  1);
            Add(item:  2);
            Add(item:  4);
            Add(item:  3);
        }
        
        Add(item:  5);
        this.acceptableActiveSceneTypes = null;
    }
    private static SceneDictator()
    {
    
    }

}
