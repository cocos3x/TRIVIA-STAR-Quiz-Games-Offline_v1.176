using UnityEngine;
public class WGToggleSoundToggle : WGMyToggle
{
    // Fields
    private UnityEngine.UI.Toggle musicToggle;
    
    // Methods
    protected override void Start()
    {
        this.Start();
        if(static_value_021FBA0E != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            static_value_021FBA0E.isOn = IsSoundEnabled() ^ 1;
            this.UpdateVisual(state:  static_value_021FBACA);
            mem[1152921513044370360] = 1;
        }
        
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Transform val_6 = this.parent;
        object val_7 = this.GetComponentInChildren<System.Object>();
        object val_8 = this.GetComponent<System.Object>();
        this.musicToggle = this;
    }
    public override void OnToggleChange(bool state)
    {
        UnityEngine.UI.Toggle val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = state ^ 1;
        if(R6 != 0)
        {
                val_4 = 1;
        }
        
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.SetEnabled(enabled:  val_2, isTracking:  true);
        if(val_2 != true)
        {
                val_4 = this.musicToggle;
            if(val_4 != 0)
        {
                val_4 = this.musicToggle;
            val_4.isOn = true;
        }
        
        }
        
        this.OnToggleChange(state:  state);
    }
    public WGToggleSoundToggle()
    {
    
    }

}
