using UnityEngine;
public class FTUXDemoWindow : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  2120738704)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGFTUXManager MonoSingleton<WGFTUXManager>::get_Instance().__il2cppRuntimeField_10 = this;
    }
    private void OnDisable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  2120738704)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGFTUXManager MonoSingleton<WGFTUXManager>::get_Instance().__il2cppRuntimeField_10 = 0;
    }
    public FTUXDemoWindow()
    {
    
    }

}
