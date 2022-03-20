using UnityEngine;
public abstract class ProfileAvatarDisplayModifier : MonoBehaviour
{
    // Fields
    public int priority;
    public bool exclusive;
    
    // Methods
    public abstract bool IsActive(); // 0
    public abstract bool AppendAvatarDisplay(AvatarSlotUGUI avatarDisplay, SLC.Social.Profile profile); // 0
    protected ProfileAvatarDisplayModifier()
    {
    
    }

}
