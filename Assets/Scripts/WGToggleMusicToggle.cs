using UnityEngine;
public class WGToggleMusicToggle : WGMyToggle
{
    // Methods
    protected override void Start()
    {
        this.Start();
        if(static_value_021FBA08 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        static_value_021FBA08.isOn = IsMusicEnabled() ^ 1;
        this.UpdateVisual(state:  static_value_021FBAC4);
        mem[1152921513043697336] = 1;
    }
    public override void OnToggleChange(bool state)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.SetEnabled(enabled:  state ^ 1, updateMusic:  true);
        this.OnToggleChange(state:  state);
    }
    public WGToggleMusicToggle()
    {
    
    }

}
