using UnityEngine;
public class WPTMetaGameBehavior : MetaGameBehavior
{
    // Properties
    public override int FTUXLevel { get; }
    public override bool supportsEmailCollectPopup { get; }
    public override bool supportsEvents { get; }
    public override bool supportsGOTDPopup { get; }
    public override bool supportsChallenges { get; }
    public override bool supportsSubscriptions { get; }
    public override bool supportsFriendInviter { get; }
    public override bool supportsExtraWordsList { get; }
    
    // Methods
    public override bool AdsAllowedByScene()
    {
        return false;
    }
    public override string GetSceneNameFromSceneType(SceneType sceneType)
    {
        var val_3;
        var val_4;
        SceneType val_1 = sceneType - 1;
        if(val_1 <= 5)
        {
                var val_2 = 6101948 + (6101948 + ((sceneType - 1)) << 2);
            if(val_1 == 5)
        {
                6101948 + ((sceneType - 1)) << 2 = (6101948 + ((sceneType - 1)) << 2) & ((R8) << 6101948 + ((sceneType - 1)) << 2);
            6101948 + ((sceneType - 1)) << 2 = (6101948 + ((sceneType - 1)) << 2) & (sceneType >> 32);
            6101948 + ((sceneType - 1)) << 2 = (6101948 + ((sceneType - 1)) << 2) & ((6101948 + ((sceneType - 1)) << 2) >> (6101948 + ((sceneType - 1)) << 2));
            6101948 + ((sceneType - 1)) << 2 = (6101948 + ((sceneType - 1)) << 2) & ((IP) >> (((6101948 + ((sceneType - 1)) << 2 & (R8) << 6101948 + ((sceneType - 1)) << 2) & (sceneType) >> 32) & (((6101948 + ((sceneType - 1)) << 2 & (R8) << 6101948 + ((sceneType - 1)) << 2) & (sceneType) >> );
            6101948 + ((sceneType - 1)) << 2 = R8 * (6101948 + ((sceneType - 1)) << 2);
            6101948 + ((sceneType - 1)) << 2 = (6101948 + ((sceneType - 1)) << 2) & (sceneType >> 1);
        }
        
            val_3 = "LaunchScene";
            return;
        }
        
        val_4 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    }
    public override SceneType getActiveSceneType()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if(val_1.m_Handle.buildIndex <= 4)
        {
                3 = 25973952;
            3 = 32076272;
            3 = mem[3 + (val_2) << 2];
            3 = 3 + (val_2) << 2;
        }
    
    }
    public override void OnClickHome()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override void ShowFTUXWindow()
    {
        this.ShowFTUXWindow();
    }
    public override int get_FTUXLevel()
    {
        return 1;
    }
    public override bool get_supportsEmailCollectPopup()
    {
        return false;
    }
    public override bool get_supportsEvents()
    {
        return false;
    }
    public override bool get_supportsGOTDPopup()
    {
        return false;
    }
    public override bool get_supportsChallenges()
    {
        return false;
    }
    public override bool get_supportsSubscriptions()
    {
        return false;
    }
    public override bool get_supportsFriendInviter()
    {
        return false;
    }
    public override bool get_supportsExtraWordsList()
    {
        return false;
    }
    public override bool GemsUnlocked()
    {
        return false;
    }
    public override System.Collections.Generic.List<PurchaseModel> FilterStoreCreditPacksPerGame(System.Collections.Generic.List<PurchaseModel> unfiltered)
    {
        var val_2;
        System.Predicate<PurchaseModel> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = WPTMetaGameBehavior.<>c.<>9__22_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Predicate<ZooTile>(object:  WPTMetaGameBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3605548336));
            WPTMetaGameBehavior.<>c.<>9__22_0 = val_4;
        }
        
        if(unfiltered != 0)
        {
                return unfiltered.FindAll(match:  8040448);
        }
        
        return unfiltered.FindAll(match:  8040448);
    }
    public override void AppendUserProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> userProperties)
    {
        WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
        userProperties.Add(key:  -689293728, value:  13152256);
        userProperties.Add(key:  -689293600, value:  13152256);
        userProperties.Add(key:  -752792336, value:  13152256);
        userProperties.Add(key:  -752792224, value:  13152256);
    }
    public override void AppendCommonEventProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> eventProperties)
    {
        WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
        eventProperties.Add(key:  -689165264, value:  13152256);
    }
    public override string GetUrlSharePrefix()
    {
    
    }
    public WPTMetaGameBehavior()
    {
    
    }

}
