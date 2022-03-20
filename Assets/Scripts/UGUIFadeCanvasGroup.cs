using UnityEngine;
public class UGUIFadeCanvasGroup : MonoBehaviour
{
    // Fields
    public float fadeFrom;
    public float fadeTo;
    public float duration;
    public float delay;
    public bool runOnce;
    public bool runOnEnable;
    public bool doOnDeferredDataReady;
    public bool alwaysRunOnSceneLoad;
    public bool setInterativeOnComplete;
    public bool setBlockRayCastOnComplete;
    private bool ranAlready;
    private UnityEngine.CanvasGroup canvasGroup;
    private DG.Tweening.Tweener fadeTweener;
    
    // Methods
    private void Awake()
    {
        var val_8;
        var val_9;
        System.Action<Result> val_10;
        System.Delegate val_11;
        object val_1 = this.GetComponent<System.Object>();
        this.canvasGroup = this;
        if(this.doOnDeferredDataReady != false)
        {
                val_8 = null;
            val_8 = null;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -2000991648, method:  new IntPtr(2293950624));
            WordApp.DeferredGameUIReadyEvent.AddListener(call:  162246656);
        }
        
        val_9 = 1152921504901201920;
        val_10 = 1152921511097403152;
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2099378416) == 0)
        {
                return;
        }
        
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_10 = null;
        val_10 = new System.Action<Result>(object:  -2000991648, method:  typeof(UGUIFadeCanvasGroup).__il2cppRuntimeField_E0);
        val_11 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        System.Delegate val_7 = System.Delegate.Combine(a:  val_11, b:  7401472);
        if(val_11 != 0)
        {
                if(val_11 == null)
        {
            goto label_14;
        }
        
        }
        
        val_11 = 0;
        label_14:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_11;
    }
    private void WordAppStartedEvent()
    {
        this.Execute();
    }
    public virtual void SceneLoaded(SceneType sceneType)
    {
        var val_1;
        if(this.alwaysRunOnSceneLoad == false)
        {
            goto label_1;
        }
        
        label_8:
        this.Execute();
        return;
        label_1:
        if(this.doOnDeferredDataReady == false)
        {
                return;
        }
        
        var val_1 = 28228745;
        val_1 = 7397044 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(WordApp.deferredEventHasFired == true)
        {
            goto label_8;
        }
    
    }
    private void OnEnable()
    {
        if(this.runOnEnable == false)
        {
                return;
        }
        
        this.Execute();
    }
    public void Execute()
    {
        if(this.runOnce == true)
        {
                this.runOnce = this.ranAlready;
            return;
        }
        
        this.ranAlready = true;
        if(this.runOnce != true)
        {
                this.TweenIt();
            return;
        }
        
        this.canvasGroup.alpha = this.delay;
        this.CancelInvoke();
        this.Invoke(methodName:  -2000555360, time:  this.delay);
    }
    private void TweenIt()
    {
        this.canvasGroup.alpha = null;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  null, duration:  null);
        object val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.canvasGroup, ease:  1);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  -2000406976, method:  typeof(UGUIFadeCanvasGroup).__il2cppRuntimeField_E8);
        object val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.canvasGroup, action:  190734336);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  this.canvasGroup, autoKillOnCompletion:  true);
        this.fadeTweener = this.canvasGroup;
    }
    protected virtual void OnCompletedTween()
    {
        if(this.setInterativeOnComplete != false)
        {
                this.canvasGroup.interactable = true;
        }
        
        if(this.setBlockRayCastOnComplete == false)
        {
                return;
        }
        
        this.canvasGroup.blocksRaycasts = true;
    }
    private void OnDestroy()
    {
        System.Action<Result> val_7;
        System.Delegate val_8;
        var val_9;
        if(this.fadeTweener != 0)
        {
                DG.Tweening.TweenExtensions.Complete(t:  this.fadeTweener, withCallbacks:  true);
        }
        
        val_7 = 1152921511097403152;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2099378416) == 0)
        {
            goto label_6;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_7 = null;
        val_7 = new System.Action<Result>(object:  -2000154304, method:  typeof(UGUIFadeCanvasGroup).__il2cppRuntimeField_E0);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        System.Delegate val_5 = System.Delegate.Remove(source:  val_8, value:  7401472);
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
        label_6:
        val_9 = null;
        val_9 = null;
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -2000154304, method:  new IntPtr(2293950624));
        WordApp.DeferredGameUIReadyEvent.RemoveListener(call:  162246656);
    }
    public UGUIFadeCanvasGroup()
    {
        this.fadeTo = 1f;
        this.duration = 1f;
        this.runOnEnable = true;
    }

}
