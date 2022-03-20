using UnityEngine;
public class UnlockableUIStoreButton : WGUnlockableUIElement
{
    // Properties
    protected override bool FeatureHidden { get; }
    
    // Methods
    protected override bool get_FeatureHidden()
    {
        GameBehavior val_1 = App.getBehavior;
        GameEcon val_2 = App.getGameEcon;
        bool val_3 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  786466);
        val_3 = val_3 ^ 1;
        return (bool)val_3;
    }
    protected override void SetNewState(WGUnlockableUIElement.UiLockedState newState)
    {
        UnityEngine.GameObject val_1 = R5.gameObject;
        if(R5 != 0)
        {
                newState - 1 = 1;
        }
        
        R5.SetActive(value:  true);
    }
    public UnlockableUIStoreButton()
    {
    
    }

}
