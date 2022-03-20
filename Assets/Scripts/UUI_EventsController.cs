using UnityEngine;
public class UUI_EventsController : MonoSingleton<UUI_EventsController>
{
    // Fields
    private UnityEngine.EventSystems.EventSystem eventSystem;
    
    // Methods
    public static void EnableInputs()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static UUI_EventsController MonoSingleton<UUI_EventsController>::get_Instance().__il2cppRuntimeField_C.enabled = true;
    }
    public static void DisableInputs()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static UUI_EventsController MonoSingleton<UUI_EventsController>::get_Instance().__il2cppRuntimeField_C.enabled = false;
    }
    private void Start()
    {
        UnityEngine.EventSystems.EventSystem val_5;
        if(this.eventSystem == 0)
        {
                object val_2 = this.GetComponent<System.Object>();
            val_5 = this;
            this.eventSystem = this;
        }
        else
        {
                val_5 = this.eventSystem;
        }
        
        if(val_5 != 0)
        {
                UnityEngine.EventSystems.EventSystem.current = this.eventSystem;
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -1994699632);
        this.SetDragThresholdByDPI();
        this.DisallowNavigationEvents();
        UnityEngine.Input.multiTouchEnabled = false;
    }
    private void SetDragThresholdByDPI()
    {
        UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
        UnityEngine.EventSystems.EventSystem val_2 = UnityEngine.EventSystems.EventSystem.current;
        float val_3 = UnityEngine.Screen.dpi;
        float val_5 = 52f;
        val_5 = 0 * val_5;
        val_5 = val_5 / 160f;
        mem[28] = UnityEngine.Mathf.Max(a:  52, b:  val_5);
    }
    private void DisallowNavigationEvents()
    {
        UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
        mem[24] = 0;
    }
    private void DisallowInputMultiTouch()
    {
        UnityEngine.Input.multiTouchEnabled = false;
    }
    public UUI_EventsController()
    {
    
    }

}
