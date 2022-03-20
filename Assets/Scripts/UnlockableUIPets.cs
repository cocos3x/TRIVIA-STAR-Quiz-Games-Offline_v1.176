using UnityEngine;
public class UnlockableUIPets : WGUnlockableUIElement
{
    // Fields
    private UnityEngine.GameObject upgradeIcon;
    
    // Properties
    protected override bool FeatureHidden { get; }
    protected override bool FeatureLocked { get; }
    
    // Methods
    protected override bool get_FeatureHidden()
    {
        return false;
    }
    protected override bool get_FeatureLocked()
    {
        bool val_1 = WADPetsManager.IsFeatureUnlocked();
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    protected override void OnClickLocked()
    {
    
    }
    protected override void OnClickUnlocked()
    {
        var val_1;
        var val_1 = 28005183;
        val_1 = 7620608 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 95;
        WADPetsScreenUI.ShowMainScreen();
    }
    protected override void UpdateButton()
    {
        if(this.upgradeIcon == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        R4 + 100.SetActive(value:  IsAnyUpgradeAvailable());
    }
    public UnlockableUIPets()
    {
    
    }

}
