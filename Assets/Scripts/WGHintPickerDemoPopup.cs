using UnityEngine;
public class WGHintPickerDemoPopup : WGHintButtonDemoPopup
{
    // Fields
    private WGHintPickerButton pickerButton;
    
    // Properties
    public static bool IsShowing { get; }
    
    // Methods
    public static bool get_IsShowing()
    {
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(389722112)});
        return WGHintButtonDemoPopup.IsShowingByType(_type:  389722112);
    }
    protected override void Start()
    {
        var val_4;
        this.Start();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -22185280, method:  new IntPtr(4272756992));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_3C, b:  7401472);
        val_4 = public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_3C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_3C = val_4;
    }
    protected override void OnDestroy()
    {
        var val_5;
        this.OnDestroy();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -22065088, method:  new IntPtr(4272756992));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_3C, value:  7401472);
        val_5 = public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_3C;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_6;
        }
        
        }
        
        val_5 = 0;
        label_6:
        public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_3C = val_5;
        if(this.pickerButton == 0)
        {
                return;
        }
        
        this.pickerButton.UpdateDisplay();
    }
    protected override void SetupButton()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_2 = PickerHintButtonGroup;
        mem[1152921513174836700] = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C.GetComponent<System.Object>();
        this.pickerButton = public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C;
        if((public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C) == 0)
        {
                return;
        }
        
        R4 + 36.UpdateDisplay();
    }
    protected override void OnKeyBoardPress()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void OnPickOverlayStateChanged(bool isOverlayVisible)
    {
        if(isOverlayVisible == true)
        {
                1f = 0;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Alpha = 0f;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = isOverlayVisible ^ 1;
    }
    public WGHintPickerDemoPopup()
    {
        this = new UnityEngine.MonoBehaviour();
    }

}
