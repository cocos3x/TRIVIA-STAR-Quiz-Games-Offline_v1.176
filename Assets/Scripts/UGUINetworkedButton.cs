using UnityEngine;
public class UGUINetworkedButton : MultiGraphicButton
{
    // Fields
    protected bool behaveAsNormalButton;
    protected UnityEngine.GameObject waitingDisplay;
    protected UnityEngine.GameObject[] hiddenWhileWaiting;
    protected UnityEngine.UI.Button[] subButtonsToControl;
    public System.Action<bool> OnConnectionClick;
    private bool awaitingPing;
    private string myName;
    
    // Methods
    protected virtual void OnStart()
    {
    
    }
    protected override void Start()
    {
        this.Start();
        if(this.behaveAsNormalButton != true)
        {
                UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1910482144, method:  new IntPtr(2384460128));
            static_value_021FA529.AddListener(call:  162246656);
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        string val_3 = NGUITools.GetHierarchy(obj:  -1910482144);
        this.myName = this;
    }
    public void OnOtherButtonClick()
    {
        this.CheckConnectivity();
    }
    protected override void DoStateTransition(UnityEngine.UI.Selectable.SelectionState state, bool instant)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        if(state == 4)
        {
                if(val_4 != 0)
        {
                val_4 = 1;
        }
        
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        bool val_2 = this.activeInHierarchy;
        if(val_2 == false)
        {
                return;
        }
        
        if(val_2 == false)
        {
            goto label_3;
        }
        
        val_5 = 0;
        bool val_3 = instant + 16;
        goto label_4;
        label_8:
        (instant + 16) + 0.enabled = true;
        val_5 = 1;
        label_4:
        if(val_5 < (instant + 12))
        {
            goto label_8;
        }
        
        label_3:
        this.DoStateTransition(state:  state, instant:  instant);
    }
    public void WaitingStatus(bool waiting)
    {
        bool val_1 = waiting ^ 1;
        this.interactable = val_1;
        this.SetWaitingDisplay(visible:  waiting);
        this.SetSubButtonsInteractable(_interactable:  val_1);
        this.SetHidden(show:  val_1);
    }
    private void CheckConnectivity()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static NetworkConnectivityPinger MonoSingleton<NetworkConnectivityPinger>::get_Instance().__il2cppRuntimeField_C) != 0)
        {
                return;
        }
        
        R4.interactable = false;
        R4.SetSubButtonsInteractable(_interactable:  false);
        R4.SetWaitingDisplay(visible:  true);
        R4.SetHidden(show:  false);
        mem2[0] = 1;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  R4, method:  new IntPtr(2384918368));
        mem2[0] = null;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        R7.PingGoogle();
    }
    private void SetWaitingDisplay(bool visible)
    {
        if(this.waitingDisplay == 0)
        {
                return;
        }
        
        this.waitingDisplay.SetActive(value:  visible);
    }
    private void SetSubButtonsInteractable(bool _interactable)
    {
        goto label_1;
        label_11:
        if(this.subButtonsToControl[0] != 0)
        {
                UnityEngine.UI.Button val_4 = this.subButtonsToControl[0];
            val_4.interactable = _interactable;
        }
        
        4 = 5;
        label_1:
        if((4 - 4) < val_4)
        {
            goto label_11;
        }
    
    }
    private void SetHidden(bool show)
    {
        goto label_1;
        label_11:
        if(this.hiddenWhileWaiting[0] != 0)
        {
                UnityEngine.GameObject val_4 = this.hiddenWhileWaiting[0];
            val_4.SetActive(value:  show);
        }
        
        4 = 5;
        label_1:
        if((4 - 4) < val_4)
        {
            goto label_11;
        }
    
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        this.interactable = true;
        this.SetSubButtonsInteractable(_interactable:  true);
        this.SetWaitingDisplay(visible:  false);
        this.SetHidden(show:  true);
        if(this.awaitingPing == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static NetworkConnectivityPinger MonoSingleton<NetworkConnectivityPinger>::get_Instance().__il2cppRuntimeField_C = false;
        this.awaitingPing = false;
    }
    public UGUINetworkedButton()
    {
        this.hiddenWhileWaiting = null;
        this.myName = "unknown";
    }
    private void <CheckConnectivity>b__12_0(bool result)
    {
        if((-1908851824) == 0)
        {
                string val_2 = this.myName + -1908884384(-1908884384);
            UnityEngine.Debug.LogError(message:  this.myName);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static NetworkConnectivityPinger MonoSingleton<NetworkConnectivityPinger>::get_Instance().__il2cppRuntimeField_C = 0;
            return;
        }
        
        this.interactable = true;
        this.SetSubButtonsInteractable(_interactable:  true);
        this.SetWaitingDisplay(visible:  false);
        this.SetHidden(show:  true);
        if(this.OnConnectionClick != 0)
        {
                this.OnConnectionClick.Invoke(obj:  result);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static NetworkConnectivityPinger MonoSingleton<NetworkConnectivityPinger>::get_Instance().__il2cppRuntimeField_C = false;
        this.awaitingPing = false;
    }

}
