using UnityEngine;
public class UnlockableUIAlphabet : WGUnlockableUIElement
{
    // Properties
    protected override int UnlockLevel { get; }
    protected override bool FeatureHidden { get; }
    
    // Methods
    protected override int get_UnlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 786450;
        }
        
        return 786450;
    }
    protected override bool get_FeatureHidden()
    {
        var val_9;
        var val_10;
        GameEcon val_1 = App.getGameEcon;
        val_9 = 1;
        if(0 < 0)
        {
                return true;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2100700048) == 0)
        {
                return true;
        }
        
        Player val_5 = App.Player;
        val_9 = 0;
        GameEcon val_6 = App.getGameEcon;
        val_10 = 0;
        if(0 >= 786450)
        {
                return true;
        }
        
        Player val_7 = App.Player;
        GameEcon val_8 = App.getGameEcon;
        val_10 = 0;
        if(0 < 0)
        {
                val_9 = 1;
        }
        
        return true;
    }
    protected override void OnClickUnlocked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public UnlockableUIAlphabet()
    {
    
    }

}
