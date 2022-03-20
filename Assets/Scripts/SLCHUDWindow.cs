using UnityEngine;
public class SLCHUDWindow : MonoSingleton<SLCHUDWindow>
{
    // Fields
    private UnityEngine.GameObject uiobject;
    private UnityEngine.UI.Text nfo;
    private UnityEngine.UI.Text title;
    private UnityEngine.UI.Button copyButton;
    private System.Func<string> callback;
    
    // Methods
    private void Start()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.copyButton)) != false)
        {
                UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -908456848, method:  new IntPtr(3386481328));
            this.copyButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.callback != 0)
        {
                return;
        }
        
        R4 + 12.SetActive(value:  false);
    }
    private void Update()
    {
        if(this.callback == 0)
        {
                return;
        }
        
        if(this.nfo == 0)
        {
                return;
        }
        
        System.Security.Cryptography.HashAlgorithm val_2 = R4 + 28.Invoke();
        if((R4 + 16) == 0)
        {
            
        }
    
    }
    public void CloseWindow()
    {
        this.callback = 0;
        this.uiobject.SetActive(value:  false);
    }
    public static void SetupHUD(string name, System.Func<string> callbackfunc)
    {
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = public static SLCHUDWindow MonoSingleton<SLCHUDWindow>::get_Instance();
        if(callbackfunc == 0)
        {
                return;
        }
        
        if((-908087504) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static SLCHUDWindow MonoSingleton<SLCHUDWindow>::get_Instance().__il2cppRuntimeField_C.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static SLCHUDWindow MonoSingleton<SLCHUDWindow>::get_Instance().__il2cppRuntimeField_14) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static SLCHUDWindow MonoSingleton<SLCHUDWindow>::get_Instance().__il2cppRuntimeField_1C = callbackfunc;
    }
    private void OnCopyButtonClicked()
    {
        ClipboardHelper.clipBoard = this.nfo;
    }
    public SLCHUDWindow()
    {
    
    }

}
