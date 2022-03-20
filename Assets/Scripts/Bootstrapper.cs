using UnityEngine;
public class Bootstrapper : MonoSingleton<Bootstrapper>
{
    // Fields
    private System.Action SceneLoadQueued;
    private System.Action unloadAfterAsyncLoad;
    private bool hasHandled;
    private bool canLoadScenes;
    private const string pref_saved_minigame = "slc_mini";
    private string currentMinigameString;
    private int _CurrentMinigame;
    private const string pref_saved_from_deeplink = "slc_mini_dplnk";
    private const string pref_deeplinked_minigame = "slc_mini_which_dplnk";
    private const string pref_deeplink_consumed = "slc_deeplink_consumed";
    public bool IsLoadingScene;
    
    // Properties
    public int CurrentMinigame { get; set; }
    public bool HasEnteredMainGame { get; set; }
    public int DeeplinkedWhichMinigame { get; set; }
    public bool DeeplinkConsumed { get; set; }
    
    // Methods
    public int get_CurrentMinigame()
    {
        if(this._CurrentMinigame != 1)
        {
                return (int)this._CurrentMinigame;
        }
        
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -2044841840, defaultValue:  0);
        mem2[0] = val_1;
        return val_1;
    }
    public void set_CurrentMinigame(int value)
    {
        this._CurrentMinigame = value;
        UnityEngine.PlayerPrefs.SetInt(key:  -2044841840, value:  value);
    }
    public bool get_HasEnteredMainGame()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -2044617744, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void set_HasEnteredMainGame(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -2044617744, value:  value);
    }
    public int get_DeeplinkedWhichMinigame()
    {
        return CPlayerPrefs.GetInt(key:  -2044393648, defaultValue:  0);
    }
    public void set_DeeplinkedWhichMinigame(int value)
    {
        CPlayerPrefs.SetInt(key:  -2044393648, val:  value);
    }
    public bool get_DeeplinkConsumed()
    {
        return UnityEngine.PlayerPrefs.HasKey(key:  -2044169536);
    }
    public void set_DeeplinkConsumed(bool value)
    {
        if(value != false)
        {
                UnityEngine.PlayerPrefs.SetString(key:  -2044169536, value:  -2044057424);
            return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  -2044169536);
    }
    public override void InitMonoSingleton()
    {
        var val_7;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -2043920192);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -2043920192, name:  -2043945328);
        if(this.HasEnteredMainGame == true)
        {
                return;
        }
        
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -2043920192, method:  new IntPtr(2251022080));
        System.Delegate val_6 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_7 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_12;
        }
        
        }
        
        val_7 = 0;
        label_12:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_7;
    }
    private void SceneManager_sceneLoaded(SceneType sceneType)
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 1)
        {
                return;
        }
        
        this.HasEnteredMainGame = true;
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_4 = new System.Action<Result>(object:  -2043804096, method:  new IntPtr(2251022080));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_6 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_6 != 0)
        {
                if(val_6 == null)
        {
            goto label_13;
        }
        
        }
        
        val_6 = 0;
        label_13:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_6;
    }
    private void UnlockSceneLoading()
    {
        this.canLoadScenes = true;
        if(this.SceneLoadQueued != 0)
        {
                this.SceneLoadQueued.Invoke();
        }
        
        this.SceneLoadQueued = 0;
    }
    public void HandleDeeplinkIntoMinigame(int minigame)
    {
        AppConfigs val_1 = App.Configuration;
        if((mem[83886604] + 12) == 0)
        {
            goto label_6;
        }
        
        Player val_2 = App.Player;
        this.HasEnteredMainGame = false;
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        this.CurrentMinigame = minigame;
        this.DeeplinkedWhichMinigame = minigame;
        if(this.canLoadScenes == false)
        {
            goto label_13;
        }
        
        this.LoadScene(sceneToLoad:  3, redirectToGameplay:  false);
        this.hasHandled = true;
        return;
        label_6:
        this.HandleNoDeeplinkMinigame();
        return;
        label_13:
        System.Action val_4 = new System.Action(object:  -2043566784, method:  new IntPtr(2251375488));
        this.SceneLoadQueued = null;
    }
    public void HandleNoDeeplinkMinigame()
    {
        if(this.hasHandled == false)
        {
            goto label_1;
        }
        
        label_2:
        System.Action val_1 = new System.Action(object:  -2043453760, method:  new IntPtr(2251488512));
        this.SceneLoadQueued = null;
        return;
        label_1:
        if(this.canLoadScenes == false)
        {
            goto label_2;
        }
        
        this.NoDeeplinkContinue();
    }
    public void HandleDeeplinkMainGame()
    {
        if(this.hasHandled == false)
        {
            goto label_1;
        }
        
        label_2:
        System.Action val_1 = new System.Action(object:  -2043340736, method:  new IntPtr(2251601536));
        this.SceneLoadQueued = null;
        return;
        label_1:
        if(this.canLoadScenes == false)
        {
            goto label_2;
        }
        
        this.DeeplinkMainGameContinue();
    }
    private void NoDeeplinkContinue()
    {
        var val_3;
        int val_1 = this.CurrentMinigame;
        if(val_1 >= 1)
        {
                if(val_1.HasEnteredMainGame == false)
        {
            goto label_1;
        }
        
        }
        
        val_3 = 1;
        goto label_2;
        label_1:
        val_3 = 3;
        label_2:
        this.LoadScene(sceneToLoad:  3, redirectToGameplay:  false);
        this.hasHandled = true;
    }
    private void DeeplinkContinue()
    {
        this.LoadScene(sceneToLoad:  3, redirectToGameplay:  false);
        this.hasHandled = true;
    }
    private void DeeplinkMainGameContinue()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_11 = 29046587;
        val_11 = 6579200 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        if(App.game == 16)
        {
            goto label_30;
        }
        
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        if(App.game == 17)
        {
            goto label_30;
        }
        
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        if(App.game == 12)
        {
            goto label_30;
        }
        
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        if(App.game == 19)
        {
            goto label_30;
        }
        
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        if(App.game == 20)
        {
            goto label_30;
        }
        
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if((public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance()) != 0)
        {
            goto label_39;
        }
        
        }
        else
        {
                WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        }
        
        label_39:
        label_30:
        this.LoadScene(sceneToLoad:  2, redirectToGameplay:  false);
        this.hasHandled = true;
    }
    private void DeeplinkMainGameCallback()
    {
        var val_6;
        var val_7;
        float val_8;
        var val_10;
        this.LoadScene(sceneToLoad:  2, redirectToGameplay:  false);
        this.hasHandled = true;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_6 = public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance();
            val_7 = val_6;
            val_8 = 1152921504614301696;
        }
        else
        {
                WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_6 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance();
            val_7 = val_6;
            val_8 = 1152921504614301696;
        }
        
        val_8 = new System.Action(object:  -2042891712, method:  new IntPtr(2251938560));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_48, value:  7454720);
        val_10 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_48;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_15;
        }
        
        }
        
        val_10 = 0;
        label_15:
        mem[1152921511094795176] = val_10;
    }
    public void HandlePlayMinigame(int minigame)
    {
        this.unloadAfterAsyncLoad = 0;
        this.CurrentMinigame = minigame;
        this.LoadScene(sceneToLoad:  3, redirectToGameplay:  false);
    }
    public void HandleLeaveMinigame(bool redirectToGameplay, string currentGame)
    {
        this.currentMinigameString = currentGame;
        this.LoadScene(sceneToLoad:  1, redirectToGameplay:  redirectToGameplay);
        if(this.unloadAfterAsyncLoad != 0)
        {
                return;
        }
        
        System.Action val_1 = new System.Action(object:  R4, method:  new IntPtr(2252283776));
        mem2[0] = null;
    }
    private void UnloadMinigameScene()
    {
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.AsyncOperation val_2 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
        this.unloadAfterAsyncLoad = 0;
        this.currentMinigameString = "";
    }
    private void LoadScene(SceneType sceneToLoad, bool redirectToGameplay = False)
    {
        var val_17;
        var val_18;
        var val_19;
        val_17 = 35626626;
        if(this.IsLoadingScene == true)
        {
                return;
        }
        
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_2 = val_1.m_Handle.name;
        GameBehavior val_3 = App.getBehavior;
        val_17 = 0;
        val_18 = val_17;
        if(sceneToLoad == 3)
        {
            goto label_8;
        }
        
        ThemesHandler val_4 = App.ThemesHandler;
        val_17 = 0;
        if(0 == 0)
        {
            goto label_13;
        }
        
        ThemesHandler val_6 = App.ThemesHandler;
        val_17 = 0;
        string val_7 = val_17.CurrentThemeName;
        if((System.String.IsNullOrEmpty(value:  null)) == false)
        {
            goto label_17;
        }
        
        label_13:
        val_19 = "";
        goto label_18;
        label_17:
        ThemesHandler val_9 = App.ThemesHandler;
        val_17 = 0;
        string val_10 = val_17.CurrentThemeName;
        string val_11 = 2144339952 + null;
        val_19 = "_";
        label_18:
        string val_12 = null + 2144339952;
        val_18 = val_18;
        label_8:
        System.Collections.IEnumerator val_15 = this.LoadSceneAsync(sceneName:  null, lastScene:  -2042434248, killManagers:  (sceneToLoad - 3) >> 5, redirectToGameplay:  redirectToGameplay);
        UnityEngine.Coroutine val_16 = this.StartCoroutine(routine:  -2042422208);
    }
    private System.Collections.IEnumerator LoadSceneAsync(string sceneName, string lastScene, bool killManagers, bool redirectToGameplay)
    {
        typeof(Bootstrapper.<LoadSceneAsync>d__37).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(Bootstrapper.<LoadSceneAsync>d__37).__il2cppRuntimeField_1C = killManagers;
        }
        else
        {
                mem[16] = this;
            mem[20] = sceneName;
            mem[24] = lastScene;
            mem[28] = killManagers;
        }
        
        typeof(Bootstrapper.<LoadSceneAsync>d__37).__il2cppRuntimeField_1D = redirectToGameplay;
    }
    public Bootstrapper()
    {
        this.currentMinigameString = "";
        this._CurrentMinigame = 0;
    }

}
