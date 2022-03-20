using UnityEngine;
public class WGMessageFlyout : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
    // Fields
    private UnityEngine.RectTransform flyoutParent;
    private UnityEngine.UI.Text flyoutText;
    private float displayDuration;
    private bool playingAnimation;
    private bool showing;
    private System.Action onStartAction;
    
    // Methods
    private void Awake()
    {
        MainController val_1 = MainController.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
        {
                return;
        }
        
        MainController val_3 = MainController.instance;
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  18315440, method:  new IntPtr(18290416));
        4.AddListener(call:  162246656);
    }
    private void Start()
    {
        if(this.onStartAction != 0)
        {
                this.onStartAction.Invoke();
        }
        
        this.ProgressAnim();
    }
    public void SetupMessage(string message, float displaySeconds = 3, System.Action startAction)
    {
        this.onStartAction = null;
        this.displayDuration = startAction;
    }
    private void ProgressAnim()
    {
        if(this.playingAnimation == true)
        {
                return;
        }
        
        mem2[0] = 1;
        UnityEngine.GameObject val_1 = R4 + 12.gameObject;
        R4 + 12.SetActive(value:  true);
        System.Collections.IEnumerator val_2 = R4.ProgressFlyout();
        UnityEngine.Coroutine val_3 = R4.StartCoroutine(routine:  R4);
    }
    private System.Collections.IEnumerator ProgressFlyout()
    {
        object val_1 = new System.Object();
        typeof(WGMessageFlyout.<ProgressFlyout>d__10).__il2cppRuntimeField_8 = 0;
        typeof(WGMessageFlyout.<ProgressFlyout>d__10).__il2cppRuntimeField_10 = this;
    }
    private void OnBeforeLevelComplete()
    {
        MainController val_1 = MainController.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                MainController val_3 = MainController.instance;
            1152921504885600256 = null;
            1152921504885600256 = new UnityEngine.Events.UnityAction(object:  18908208, method:  new IntPtr(18290416));
            4.RemoveListener(call:  162246656);
        }
        
        this.OnDisplayComplete();
    }
    private void Update()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(GetActiveAndQueuedWindowCount() <= 1)
        {
                if(this.showing == false)
        {
                return;
        }
        
            if(UnityEngine.Input.touchCount < 1)
        {
                return;
        }
        
        }
        
        this.OnDisplayComplete();
    }
    private void OnDisplayComplete()
    {
        this.StopAllCoroutines();
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnDestroy()
    {
        this.StopAllCoroutines();
    }
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.StopAllCoroutines();
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGMessageFlyout()
    {
        this.displayDuration = 3f;
    }

}
