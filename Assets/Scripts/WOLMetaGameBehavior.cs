using UnityEngine;
public class WOLMetaGameBehavior : MetaGameBehavior
{
    // Properties
    public override int PlayerLevel { get; set; }
    public override bool supportsEvents { get; }
    public override bool supportsChallenges { get; }
    public override bool supportsSales { get; }
    public override bool supportsGOTDPopup { get; }
    public override bool supportsDailyLoginRewardPopup { get; }
    public override bool supportsEmailCollectPopup { get; }
    public override bool supportsRecommendPopup { get; }
    public override bool supportsFriendInviter { get; }
    public override bool supportsFBConnect { get; }
    public override bool supportsSubscriptions { get; }
    public override bool supportsSilverTicketDisplay { get; }
    public override bool canShowGoldenTicketStoreItem { get; }
    public override bool supportsRecaptureNotifications { get; }
    public override bool supportsFeatureMenu { get; }
    public override bool supportsNotificationLifecylce { get; }
    public override bool supportAdsControl { get; }
    public override bool isWordGame { get; }
    
    // Methods
    public override int get_PlayerLevel()
    {
        Player val_1 = App.Player;
        if(0 == 0)
        {
            
        }
    
    }
    public override void set_PlayerLevel(int value)
    {
        this.PlayerLevel = value;
    }
    public override bool AdsAllowedByScene()
    {
        return false;
    }
    public override SceneType getActiveSceneType()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_2 = val_1.m_Handle.name;
        SceneType val_3 = this.GetSceneTypeFromSceneName(sceneName:  -687443460);
    }
    public override UnityEngine.GameObject OpenPauseMenu()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return 0.gameObject;
        }
        
        return 0.gameObject;
    }
    public override void OnClickHome()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override bool get_supportsEvents()
    {
        return false;
    }
    public override bool get_supportsChallenges()
    {
        return false;
    }
    public override bool get_supportsSales()
    {
        return false;
    }
    public override bool get_supportsGOTDPopup()
    {
        return false;
    }
    public override bool get_supportsDailyLoginRewardPopup()
    {
        return true;
    }
    public override bool get_supportsEmailCollectPopup()
    {
        return false;
    }
    public override bool get_supportsRecommendPopup()
    {
        return false;
    }
    public override bool get_supportsFriendInviter()
    {
        return false;
    }
    public override bool get_supportsFBConnect()
    {
        return false;
    }
    public override bool get_supportsSubscriptions()
    {
        return false;
    }
    public override bool get_supportsSilverTicketDisplay()
    {
        return false;
    }
    public override bool get_canShowGoldenTicketStoreItem()
    {
        return false;
    }
    public override bool get_supportsRecaptureNotifications()
    {
        return false;
    }
    public override bool get_supportsFeatureMenu()
    {
        return false;
    }
    public override bool get_supportsNotificationLifecylce()
    {
        return false;
    }
    public override bool get_supportAdsControl()
    {
        return true;
    }
    public override bool get_isWordGame()
    {
        return true;
    }
    public override bool GemsUnlocked()
    {
        return false;
    }
    public override bool WADPetsUnlocked()
    {
        return false;
    }
    public override System.Type getDefinitions<T>()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(345473024)});
    }
    public WOLMetaGameBehavior()
    {
    
    }

}
