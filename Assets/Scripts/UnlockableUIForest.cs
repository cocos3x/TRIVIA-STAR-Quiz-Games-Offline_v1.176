using UnityEngine;
public class UnlockableUIForest : WGUnlockableUIElement
{
    // Fields
    private UnityEngine.GameObject badgeGrow;
    private UnityEngine.UI.Text LabelGrow;
    
    // Properties
    protected override int UnlockLevel { get; }
    
    // Methods
    protected override int get_UnlockLevel()
    {
        WordForest.WFOGameEcon val_1 = WordForest.WFOGameEcon.Instance;
        if(0 != 0)
        {
                return 786450;
        }
        
        return 786450;
    }
    protected override void SetNewState(WGUnlockableUIElement.UiLockedState newState)
    {
        if(newState == 3)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_2 = AffordableGrowthStages;
            35628758 = val_2;
            if(35628758 > 0)
        {
                0 = 1;
        }
        
            this.badgeGrow.SetActive(value:  true);
            string val_3 = val_2.ToString();
            if(this.LabelGrow != 0)
        {
                return;
        }
        
            return;
        }
        
        this.badgeGrow.SetActive(value:  false);
    }
    public UnlockableUIForest()
    {
    
    }

}
