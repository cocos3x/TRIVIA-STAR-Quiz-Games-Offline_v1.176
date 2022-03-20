using UnityEngine;
public class AnimatedTransitionUIElement : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup canvasGroup;
    private bool spineAnimation;
    public float outDelay;
    private bool TransitionIn;
    private UnityEngine.Events.UnityAction actionToExecute;
    private Spine.Unity.SkeletonGraphic spineObject;
    
    // Methods
    private void Awake()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.canvasGroup = this;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -174223760, method:  new IntPtr(4120717488));
        this.actionToExecute = null;
        if(this.spineAnimation == false)
        {
                return;
        }
        
        object val_3 = this.GetComponent<System.Object>();
        this.spineObject = this;
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -174223760, method:  new IntPtr(4120718512));
        this.actionToExecute = null;
    }
    private void Start()
    {
        UnityEngine.Events.UnityAction val_18;
        MainController val_1 = MainController.instance;
        if(0 != 0)
        {
                MainController val_3 = MainController.instance;
            val_18 = 4;
            val_18.AddListener(call:  this.actionToExecute);
            MainController val_4 = MainController.instance;
            float val_5 = UnityEngine.Mathf.Min(a:  null, b:  null);
            this.outDelay = this.outDelay;
            if(this.TransitionIn != false)
        {
                UnityEngine.GameObject val_6 = this.gameObject;
            if(this.activeInHierarchy != false)
        {
                System.Collections.IEnumerator val_8 = this.StartLate();
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  -174106640);
        }
        
        }
        
        }
        
        WordRegion val_10 = WordRegion.instance;
        if(0 != 0)
        {
                WordRegion val_12 = WordRegion.instance;
            val_18 = null;
            val_18 = new UnityEngine.Events.UnityAction(object:  -174106640, method:  new IntPtr(4120835632));
            4.AddListener(call:  162246656);
        }
        
        MainController val_14 = MainController.instance;
        if(0 != 0)
        {
                return;
        }
        
        WordRegion val_16 = WordRegion.instance;
        if(0 != 0)
        {
                return;
        }
        
        this.enabled = false;
    }
    private System.Collections.IEnumerator StartLate()
    {
        object val_1 = new System.Object();
        typeof(AnimatedTransitionUIElement.<StartLate>d__8).__il2cppRuntimeField_8 = 0;
        typeof(AnimatedTransitionUIElement.<StartLate>d__8).__il2cppRuntimeField_10 = this;
    }
    private void OnWordRegionLevelComplete()
    {
        object val_1 = this.GetComponent<System.Object>();
        if((-173878544) == 0)
        {
                return;
        }
        
        object val_3 = this.GetComponent<System.Object>();
        this.interactable = false;
    }
    private void OnLevelComplete()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeInHierarchy == false)
        {
                return;
        }
        
        this.FadeTo(duration:  this.canvasGroup.alpha, from:  null, to:  null, doDelay:  false);
    }
    private void FadeTo(float duration, float from, float to, bool doDelay)
    {
        var val_1;
        var val_7;
        object val_2 = this.GetComponent<System.Object>();
        val_7 = this;
        if((-173642256) != 0)
        {
                object val_4 = this.GetComponent<System.Object>();
            val_7 = this;
            if(this > 0)
        {
                0 = 1;
        }
        
            this.interactable = true;
        }
        
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  duration, duration:  from);
        if(val_1 != 0)
        {
                duration = this.outDelay;
        }
        
        object val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.canvasGroup, delay:  duration = 0f);
    }
    private void SpineOnLevelComplete()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.spineObject)) == false)
        {
                return;
        }
        
        UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.spineObject, endValue:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.r}, duration:  null);
    }
    public AnimatedTransitionUIElement()
    {
    
    }

}
