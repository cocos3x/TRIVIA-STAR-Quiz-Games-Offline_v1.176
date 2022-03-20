using UnityEngine;
public class ScreenFader : MonoBehaviour
{
    // Fields
    public static ScreenFader instance;
    public const float DURATION = 0.37;
    public bool isFading;
    public bool isLoadingScene;
    private UnityEngine.UI.Image bgImage;
    private const float fadeOutTime = 0.2;
    private const float fadeInTime = 0.2;
    
    // Methods
    private void Awake()
    {
        ScreenFader.fadeInTime = this;
        object val_1 = this.GetComponent<System.Object>();
        this.bgImage = this;
    }
    public void FadeOut(System.Action onComplete)
    {
        if(new System.Object() != 0)
        {
                typeof(ScreenFader.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(ScreenFader.<>c__DisplayClass8_0).__il2cppRuntimeField_C = onComplete;
        if(this.isFading == true)
        {
                return;
        }
        
        mem2[0] = 1;
        R5 + 16.enabled = true;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R5 + 16, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  R4, method:  new IntPtr(2181256384));
        object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  R5 + 16, action:  190734336);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  R5 + 16, autoKillOnCompletion:  true);
    }
    public void FadeIn(System.Action onComplete)
    {
        if(new System.Object() != 0)
        {
                typeof(ScreenFader.<>c__DisplayClass9_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(ScreenFader.<>c__DisplayClass9_0).__il2cppRuntimeField_C = onComplete;
        if(this.isFading == true)
        {
                return;
        }
        
        mem2[0] = 1;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R4 + 16, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  R5, method:  new IntPtr(2181377600));
        object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  R4 + 16, action:  190734336);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  R4 + 16, autoKillOnCompletion:  true);
        R4 + 16.sprite = 0;
    }
    public void GotoScene(string sceneName)
    {
        if(new System.Object() != 0)
        {
                typeof(ScreenFader.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(ScreenFader.<>c__DisplayClass10_0).__il2cppRuntimeField_C = sceneName;
        if(this.isFading == false)
        {
                this.isFading = this.isLoadingScene;
        }
        
        if(this.isFading == true)
        {
                return;
        }
        
        System.Action val_2 = new System.Action(object:  R5, method:  new IntPtr(2181498816));
        R4.FadeOut(onComplete:  7454720);
    }
    private System.Collections.IEnumerator LoadTheSceneAsync(string sceneName)
    {
        typeof(ScreenFader.<LoadTheSceneAsync>d__11).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(ScreenFader.<LoadTheSceneAsync>d__11).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(ScreenFader.<LoadTheSceneAsync>d__11).__il2cppRuntimeField_14 = sceneName;
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -2113206144, method:  new IntPtr(2181736128));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
    }
    private void OnDisable()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -2113094144, method:  new IntPtr(2181736128));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  162459648);
    }
    private void OnLevelFinishedLoading(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        this.isLoadingScene = false;
        if((-2112973952) == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        if((-2112973952) == 0)
        {
                return;
        }
        
        if(this.bgImage == 0)
        {
                return;
        }
        
        this.FadeIn(onComplete:  0);
    }
    public ScreenFader()
    {
    
    }

}
