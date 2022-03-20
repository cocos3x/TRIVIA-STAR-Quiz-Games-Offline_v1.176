using UnityEngine;
public class WADPetsUIController : MonoSingleton<WADPetsUIController>
{
    // Methods
    public override void InitMonoSingleton()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -961750096, name:  -961774208);
    }
    public void UpdateHintButtonUI()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.UpdateDisplay();
    }
    public void ShowFTUX(System.Collections.Generic.List<WADPets.WADPet> pets)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        SetupFtux(pets:  R4);
    }
    public WADPetsUIController()
    {
    
    }

}
