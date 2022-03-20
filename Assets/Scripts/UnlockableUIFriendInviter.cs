using UnityEngine;
public class UnlockableUIFriendInviter : WGUnlockableUIElement
{
    // Properties
    protected override bool FeatureHidden { get; }
    
    // Methods
    protected override bool get_FeatureHidden()
    {
        var val_4;
        GameEcon val_1 = App.getGameEcon;
        if(1098 >= 0)
        {
                Player val_2 = App.Player;
            GameEcon val_3 = App.getGameEcon;
            if(0 < 1098)
        {
                val_4 = 1;
        }
        
            return (bool)val_4;
        }
        
        val_4 = 1;
        return (bool)val_4;
    }
    public UnlockableUIFriendInviter()
    {
    
    }

}
