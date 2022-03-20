using UnityEngine;
public class ScreenFaderV2 : MonoSingleton<ScreenFaderV2>
{
    // Fields
    public static ScreenFaderV2 instance;
    public const float DURATION = 0.37;
    public bool isFading;
    public bool isLoadingScene;
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.GameObject backgroundCopy;
    private const float fadeOutTime = 0.2;
    private const float fadeInTime = 0.2;
    
    // Methods
    public override void InitMonoSingleton()
    {
        ScreenFaderV2.fadeInTime = this;
        object val_1 = this.GetComponent<System.Object>();
        this.canvasGroup = this;
        this.enabled = true;
    }
    public void FadeOut(System.Action onComplete)
    {
        if(new System.Object() != 0)
        {
                typeof(ScreenFaderV2.<>c__DisplayClass9_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(ScreenFaderV2.<>c__DisplayClass9_0).__il2cppRuntimeField_C = onComplete;
        if(this.isFading == true)
        {
                return;
        }
        
        mem2[0] = 1;
        R5 + 16.interactable = true;
        R5 + 16.blocksRaycasts = true;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R5 + 16, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  R4, method:  new IntPtr(2183770176));
        object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  R5 + 16, action:  190734336);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  R5 + 16, autoKillOnCompletion:  true);
    }
    public void FadeIn(System.Action onComplete)
    {
        if(new System.Object() != 0)
        {
                typeof(ScreenFaderV2.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(ScreenFaderV2.<>c__DisplayClass10_0).__il2cppRuntimeField_C = onComplete;
        if(this.isFading == true)
        {
                return;
        }
        
        mem2[0] = 1;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R5 + 16, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  R4, method:  new IntPtr(2183891392));
        object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  R5 + 16, action:  190734336);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  R5 + 16, autoKillOnCompletion:  true);
    }
    public void GotoScene(string sceneName)
    {
        if(new System.Object() != 0)
        {
                typeof(ScreenFaderV2.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(ScreenFaderV2.<>c__DisplayClass11_0).__il2cppRuntimeField_C = sceneName;
        if(this.isFading == false)
        {
                this.isFading = this.isLoadingScene;
        }
        
        if(this.isFading == true)
        {
                return;
        }
        
        R4.FindNewBackground();
        System.Action val_2 = new System.Action(object:  R5, method:  new IntPtr(2184012608));
        R4.FadeOut(onComplete:  7454720);
    }
    private System.Collections.IEnumerator LoadTheSceneAsync(string sceneName)
    {
        typeof(ScreenFaderV2.<LoadTheSceneAsync>d__12).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(ScreenFaderV2.<LoadTheSceneAsync>d__12).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(ScreenFaderV2.<LoadTheSceneAsync>d__12).__il2cppRuntimeField_14 = sceneName;
    }
    private void OnEnable()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -2110692352, method:  new IntPtr(2184249920));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
    }
    private void OnDisable()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -2110580352, method:  new IntPtr(2184249920));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  162459648);
    }
    private void OnLevelFinishedLoading(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        this.isLoadingScene = false;
        if((-2110460160) == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        if((-2110460160) == 0)
        {
                return;
        }
        
        if(this.canvasGroup == 0)
        {
                return;
        }
        
        this.FadeIn(onComplete:  0);
    }
    private void FindNewBackground()
    {
        if(this.backgroundCopy != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.backgroundCopy);
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.GameObject.FindWithTag(tag:  -2110355776);
        UnityEngine.Transform val_3 = this.transform;
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  -2110355776, parent:  -2110327472);
        this.backgroundCopy = "background_image";
        object val_5 = GetComponent<System.Object>();
        if((-2110355776) != 0)
        {
                UnityEngine.Object.Destroy(obj:  -2110355776);
        }
        
        this.backgroundCopy.tag = -2110351568;
    }
    public ScreenFaderV2()
    {
    
    }

}
