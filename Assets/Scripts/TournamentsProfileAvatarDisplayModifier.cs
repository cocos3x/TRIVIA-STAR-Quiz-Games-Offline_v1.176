using UnityEngine;
public class TournamentsProfileAvatarDisplayModifier : ProfileAvatarDisplayModifier
{
    // Fields
    private UnityEngine.GameObject stupidCrownPrefab;
    
    // Methods
    public override bool IsActive()
    {
        return false;
    }
    public override bool AppendAvatarDisplay(AvatarSlotUGUI avatarDisplay, SLC.Social.Profile profile)
    {
        string val_1 = profile.Name.ToLower();
        if((profile.Name.Contains(value:  1357768992)) == false)
        {
                return (bool)0;
        }
        
        UnityEngine.Transform val_3 = avatarDisplay.transform;
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.stupidCrownPrefab, parent:  avatarDisplay);
        0 = 1;
        this.stupidCrownPrefab = this.stupidCrownPrefab;
        return (bool)0;
    }
    public TournamentsProfileAvatarDisplayModifier()
    {
    
    }

}
