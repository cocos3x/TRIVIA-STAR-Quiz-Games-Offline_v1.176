using UnityEngine;
public class WindowTransitionTween : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup windowCanvasGroup;
    private WindowTransitionTween.Direction enterDirection;
    private UnityEngine.RectTransform rectTransform;
    private bool postWindowCloseNotification;
    private float tweenDuration;
    private WGWindow wgWindow;
    private DG.Tweening.Ease easeType;
    
    // Methods
    private UnityEngine.Vector2 GetPosition(WindowTransitionTween.Direction direction)
    {
        WindowTransitionTween val_14;
        WindowTransitionTween val_15;
        float val_17;
        val_14 = R2;
        val_15 = 35625728;
        if(val_14 <= 4)
        {
                var val_1 = 6142192 + (6142192 + (R2) << 2);
            if(val_14 == 4)
        {
                6142192 = 6142192 & 111229568;
            6142192 = 6142192 * 6142192;
            6142192 = 6142192 & 55614784;
            6142192 = 6142192 & 27807392;
            6142192 = 6142192 & (((int)R8) >> ((((6142192 & 111229568) * (6142192 & 111229568)) & 55614784) & 27807392));
        }
        
            val_15 = 0;
            val_14 = UnityEngine.Screen.width;
            UnityEngine.Vector2 val_3 = anchoredPosition;
            val_17 = (float)val_14 * (-2f);
        }
        else
        {
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            return new UnityEngine.Vector2() {y = val_11.y};
        }
        
        this = ;
        mem[1152921513308011140] = ;
        this = new UnityEngine.Vector2(x:  null, y:  val_11.y);
        return new UnityEngine.Vector2() {y = val_11.y};
    }
    private void Awake()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.rectTransform = this;
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.UI.LayoutElement val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  111350032);
        this.windowCanvasGroup = this;
        if(this.postWindowCloseNotification == false)
        {
                return;
        }
        
        object val_4 = this.GetComponent<System.Object>();
        this.wgWindow = this;
        if((UnityEngine.Object.op_Implicit(exists:  111350032)) != false)
        {
                mem2[0] = 0;
            return;
        }
        
        UnityEngine.GameObject val_6 = this.gameObject;
        string val_7 = this.name;
        string val_8 = 111325760 + 111350032 + 111325888;
        UnityEngine.Debug.LogWarning(message:  111325760);
    }
    private void OnEnable()
    {
        this.windowCanvasGroup.interactable = false;
        this.SetInitialPosition();
        System.Collections.IEnumerator val_1 = this.EnableLate();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  111470224);
    }
    private void Start()
    {
        this.SetInitialPosition();
    }
    private void SetInitialPosition()
    {
        float val_2;
        float val_3;
        if(this.enterDirection == 99)
        {
                return;
        }
        
        if(this.enterDirection == 4)
        {
                UnityEngine.Vector2 val_1 = GetPosition(direction:  111718800);
            this.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_2, y = val_3};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            this.rectTransform.localScale = new UnityEngine.Vector3();
            this.windowCanvasGroup.alpha = val_4.x;
            return;
        }
        
        UnityEngine.Vector2 val_5 = GetPosition(direction:  111718800);
        this.rectTransform.anchoredPosition = new UnityEngine.Vector2();
    }
    private System.Collections.IEnumerator EnableLate()
    {
        object val_1 = new System.Object();
        typeof(WindowTransitionTween.<EnableLate>d__13).__il2cppRuntimeField_8 = 0;
        typeof(WindowTransitionTween.<EnableLate>d__13).__il2cppRuntimeField_10 = this;
    }
    public void TweenOffScreenAndDisable()
    {
        float val_5;
        float val_6;
        var val_22;
        var val_23;
        var val_24;
        string val_25;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(GetActiveAndQueuedWindowCount() > 1)
        {
                if(this.enterDirection > 3)
        {
            goto label_23;
        }
        
            var val_3 = 6143756 + (6143756 + (this.enterDirection) << 2);
            if(this.enterDirection == 3)
        {
                6143756 = 6143756;
            6143756 = 6143756 & (((IP) << (32-5)) | ((IP) << 5));
            mem2[0] = (6143756 & ((IP) << (32-5)) | ((IP) << 5)) + IP;
        }
        
            val_22 = this;
        }
        else
        {
                val_22 = this;
        }
        
        UnityEngine.Vector2 val_4 = GetPosition(direction:  112009360);
        label_23:
        if((UnityEngine.Object.op_Implicit(exists:  this.wgWindow)) != false)
        {
                NotificationCenter val_8 = NotificationCenter.DefaultCenter;
            val_23 = 0;
            val_24 = null;
            val_24 = null;
            val_25 = SLCWindowManager<T>.color_show_available_popups;
            val_23.PostNotification(aSender:  this.wgWindow, aName:  val_25);
        }
        
        if(this.enterDirection == 99)
        {
            goto label_15;
        }
        
        if(this.enterDirection != 4)
        {
            goto label_16;
        }
        
        UnityEngine.Transform val_9 = this.rectTransform.transform;
        UnityEngine.Vector3 val_10 = localScale;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 6.505399E-35f}, d:  val_10.x);
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.rectTransform, endValue:  new UnityEngine.Vector3(), duration:  this.tweenDuration);
        val_23 = 1152921509932985248;
        object val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.rectTransform, ease:  this.easeType);
        val_25 = null;
        val_25 = new DG.Tweening.TweenCallback(object:  112009360, method:  new IntPtr(111963856));
        object val_15 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.rectTransform, action:  190734336);
        DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.windowCanvasGroup, endValue:  this.tweenDuration, duration:  val_11.y);
        object val_17 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.windowCanvasGroup, ease:  this.easeType);
        goto label_21;
        label_15:
        this.TweenOffScreenComplete();
        goto label_21;
        label_16:
        DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.rectTransform, endValue:  new UnityEngine.Vector2() {x = val_5, y = val_6}, duration:  val_4.x, snapping:  this.tweenDuration);
        object val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.rectTransform, ease:  this.easeType);
        val_25 = null;
        val_25 = new DG.Tweening.TweenCallback(object:  112009360, method:  new IntPtr(111963856));
        object val_21 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.rectTransform, action:  190734336);
        label_21:
        this.windowCanvasGroup.interactable = false;
    }
    private void TweenOffScreenComplete()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void SetInteractable()
    {
        this.windowCanvasGroup.interactable = true;
    }
    public WindowTransitionTween()
    {
        this.postWindowCloseNotification = true;
        this.enterDirection = 4;
        this.tweenDuration = 0.3f;
        this.easeType = 6;
    }

}
