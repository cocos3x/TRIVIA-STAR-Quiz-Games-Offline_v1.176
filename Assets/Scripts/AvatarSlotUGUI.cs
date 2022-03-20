using UnityEngine;
public class AvatarSlotUGUI : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Image avatarImage;
    protected UnityEngine.UI.RawImage facebookImage;
    protected bool alwaysMe;
    
    // Methods
    private void OnEnable()
    {
        if(this.alwaysMe == false)
        {
                return;
        }
        
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        0.AddObserver(observer:  -365585872, name:  442544128);
        SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_3 = 0.MyProfile;
    }
    public virtual void Setup(SLC.Social.Profile profile)
    {
        UnityEngine.GameObject val_1 = this.facebookImage.gameObject;
        this.facebookImage.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SLC.Social.AvatarConfig val_3 = ProfileAvatarConfig;
        UnityEngine.Sprite val_4 = GetAvatarSpriteByID(id:  profile.AvatarId);
        this.avatarImage.sprite = -365485584;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AppendAvatarDisplay(avatarDisplay:  -365460560, profile:  profile);
    }
    private void OnMyProfileUpdate()
    {
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_2 = 0.MyProfile;
        goto typeof(AvatarSlotUGUI).__il2cppRuntimeField_DC;
    }
    public AvatarSlotUGUI()
    {
    
    }

}
