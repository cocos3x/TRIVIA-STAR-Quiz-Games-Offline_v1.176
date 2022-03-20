using UnityEngine;
public class WGGoldenMultiplierFlyout : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
    // Fields
    private UnityEngine.RectTransform completeFlyout;
    private UnityEngine.UI.Text completeText;
    private bool playingAnimation;
    private System.Action onStartAction;
    private UnityEngine.Camera canvasCamera;
    private UnityEngine.RectTransform uiButton;
    
    // Methods
    private void Awake()
    {
        MainController val_1 = MainController.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
        {
                return;
        }
        
        MainController val_3 = MainController.instance;
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1228182752, method:  new IntPtr(3066759520));
        4.AddListener(call:  162246656);
    }
    private void Start()
    {
        if(this.onStartAction == 0)
        {
                return;
        }
        
        this.onStartAction.Invoke();
    }
    private void Update()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(GetActiveAndQueuedWindowCount() < 2)
        {
                return;
        }
        
        R4.OnDisplayComplete();
    }
    private void OnDestroy()
    {
        this.StopAllCoroutines();
    }
    public void PlayCompleteFlyout()
    {
        System.Action val_1 = new System.Action(object:  -1227725536, method:  new IntPtr(3067216736));
        this.onStartAction = null;
    }
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.StopAllCoroutines();
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void DoCompleteFlyout()
    {
        if(this.playingAnimation == true)
        {
                return;
        }
        
        this.playingAnimation = true;
        UnityEngine.Transform val_1 = this.completeFlyout.transform;
        UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        this.completeFlyout.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.GameObject val_3 = this.completeFlyout.gameObject;
        this.completeFlyout.SetActive(value:  true);
        string val_4 = Localization.Localize(key:  -1227504912, defaultValue:  -1227505056, useSingularKey:  false);
        System.Collections.IEnumerator val_5 = this.CompleteFlyout();
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -1227480784);
        System.Collections.IEnumerator val_7 = this.SetCompleteFlyoutPlacement();
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  -1227480784);
    }
    private void OnBeforeLevelComplete()
    {
        MainController val_1 = MainController.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                MainController val_3 = MainController.instance;
            1152921504885600256 = null;
            1152921504885600256 = new UnityEngine.Events.UnityAction(object:  -1227356496, method:  new IntPtr(3066759520));
            4.RemoveListener(call:  162246656);
        }
        
        this.OnDisplayComplete();
    }
    private void OnDisplayComplete()
    {
        this.StopAllCoroutines();
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private System.Collections.IEnumerator CompleteFlyout()
    {
        object val_1 = new System.Object();
        typeof(WGGoldenMultiplierFlyout.<CompleteFlyout>d__15).__il2cppRuntimeField_8 = 0;
        typeof(WGGoldenMultiplierFlyout.<CompleteFlyout>d__15).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator SetCompleteFlyoutPlacement()
    {
        object val_1 = new System.Object();
        typeof(WGGoldenMultiplierFlyout.<SetCompleteFlyoutPlacement>d__16).__il2cppRuntimeField_8 = 0;
        typeof(WGGoldenMultiplierFlyout.<SetCompleteFlyoutPlacement>d__16).__il2cppRuntimeField_10 = this;
    }
    public WGGoldenMultiplierFlyout()
    {
    
    }

}
