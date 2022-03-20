using UnityEngine;
public class AdsUIController_HideBannerComponent : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_18 = (public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_18 + 1);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowOrHideBanner();
    }
    private void OnDisable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_18 = (public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_18 - 1);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowOrHideBanner();
    }
    public AdsUIController_HideBannerComponent()
    {
    
    }

}
