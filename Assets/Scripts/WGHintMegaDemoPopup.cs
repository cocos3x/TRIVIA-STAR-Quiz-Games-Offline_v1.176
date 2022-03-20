using UnityEngine;
public class WGHintMegaDemoPopup : WGHintButtonDemoPopup
{
    // Properties
    public static bool IsShowing { get; }
    
    // Methods
    public static bool get_IsShowing()
    {
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(389668864)});
        return WGHintButtonDemoPopup.IsShowingByType(_type:  389668864);
    }
    protected override void SetupButton()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_2 = MegaHintButtonGroup;
        mem[1152921513174035292] = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
    }
    protected override void OnKeyBoardPress()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    protected override void OnClick_UseHint()
    {
        this.OnClick_UseHint();
    }
    public WGHintMegaDemoPopup()
    {
        this = new UnityEngine.MonoBehaviour();
    }

}
