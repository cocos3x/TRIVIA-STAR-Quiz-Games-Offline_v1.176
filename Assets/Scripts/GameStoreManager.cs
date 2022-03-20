using UnityEngine;
public class GameStoreManager : MonoSingletonSelfGenerating<GameStoreManager>
{
    // Fields
    private System.Action<bool, bool> currentStoreCloseCallback;
    private System.Action onStoreSceneLoadedAction;
    public static string StoreCategoryFocus;
    
    // Methods
    public void ShowStore(string categoryFocus, System.Action<bool, bool> storeCloseCallback)
    {
        if((System.String.IsNullOrEmpty(value:  categoryFocus)) != true)
        {
                GameStoreManager.StoreCategoryFocus = categoryFocus;
        }
        
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        TakeCameraStateSnapshot();
        System.Collections.IEnumerator val_3 = this.LoadStoreScene(storeCloseCallback:  storeCloseCallback);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -1259072608);
    }
    private System.Collections.IEnumerator LoadStoreScene(System.Action<bool, bool> storeCloseCallback)
    {
        typeof(GameStoreManager.<LoadStoreScene>d__4).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(GameStoreManager.<LoadStoreScene>d__4).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(GameStoreManager.<LoadStoreScene>d__4).__il2cppRuntimeField_14 = storeCloseCallback;
    }
    public void HandleStoreClose(bool purchased, bool runCallbacks = True, bool forceClose = False)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1258856224) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static GameStoreWindowManager MonoSingleton<GameStoreWindowManager>::get_Instance().__il2cppRuntimeField_40 = 0;
        }
        
        if(runCallbacks == false)
        {
            goto label_9;
        }
        
        if(this.currentStoreCloseCallback == 0)
        {
            goto label_11;
        }
        
        this.currentStoreCloseCallback.Invoke(arg1:  purchased, arg2:  forceClose);
        goto label_11;
        label_9:
        this.currentStoreCloseCallback = 0;
        label_11:
        this.currentStoreCloseCallback = 0;
        GameBehavior val_4 = App.getBehavior;
        UnityEngine.AsyncOperation val_5 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
        WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        RestoreCameraStateSnapshot();
    }
    public GameStoreManager()
    {
    
    }

}
