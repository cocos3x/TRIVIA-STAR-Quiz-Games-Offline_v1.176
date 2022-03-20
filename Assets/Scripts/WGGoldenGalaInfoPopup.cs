using UnityEngine;
public class WGGoldenGalaInfoPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text timerText;
    private UnityEngine.GameObject subscriberGroup;
    private UnityEngine.GameObject nonSubscriberGroup;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button goldenTicketButton;
    private System.Action onDisableCallback;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1234467904, method:  new IntPtr(3060465152));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1234467904, method:  new IntPtr(3060474368));
        this.goldenTicketButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        bool val_1 = GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive;
        this.subscriberGroup.SetActive(value:  val_1);
        this.nonSubscriberGroup.SetActive(value:  val_1 ^ 1);
        this.StopAllCoroutines();
        System.Collections.IEnumerator val_3 = this.SetTimer();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -1234331328);
    }
    private void OnDisable()
    {
        if(this.onDisableCallback == 0)
        {
                return;
        }
        
        this.onDisableCallback.Invoke();
    }
    public void SetOnDisableCallback(System.Action callback)
    {
        this.onDisableCallback = callback;
    }
    private void OnCloseButtonClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1233970752, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnGoldenTicketButtonClicked()
    {
        var val_4 = 28792680;
        val_4 = 6834444 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        WGSubscriptionManager._subEntryPoint = 60;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1233857728, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private System.Collections.IEnumerator SetTimer()
    {
        object val_1 = new System.Object();
        typeof(WGGoldenGalaInfoPopup.<SetTimer>d__12).__il2cppRuntimeField_8 = 0;
        typeof(WGGoldenGalaInfoPopup.<SetTimer>d__12).__il2cppRuntimeField_10 = this;
    }
    public WGGoldenGalaInfoPopup()
    {
    
    }

}
