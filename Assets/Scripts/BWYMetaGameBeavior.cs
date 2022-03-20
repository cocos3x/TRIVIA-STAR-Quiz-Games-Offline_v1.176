using UnityEngine;
public class BWYMetaGameBeavior : MetaGameBehavior
{
    // Properties
    public override string NotifImgUrlDailyBonus { get; }
    public override string NotifImgUrlPostAd { get; }
    public override bool supportsDailyLoginRewardPopup { get; }
    public override bool supportsEvents { get; }
    public override bool supportsChallenges { get; }
    public override bool supportsGOTDPopup { get; }
    public override bool supportsSubscriptions { get; }
    public override bool supportsFriendInviter { get; }
    public override bool supportsRecaptureNotifications { get; }
    
    // Methods
    public override string GetShareTextScreenShot()
    {
    
    }
    public override string GetUrlSharePrefix()
    {
    
    }
    public override bool AdsAllowedByScene()
    {
        if(this == 2)
        {
                return (bool)1;
        }
        
        1 = 0;
        return (bool)1;
    }
    public override bool BannerAdsSkipPlayerLevelCheck()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2118293440 == 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockPuzzleMagic.GameMode val_4 = CurrentGameMode;
        if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance()) != 1)
        {
                1 = 0;
        }
        
        return (bool)1;
    }
    public override bool UsesSingleScene()
    {
        return false;
    }
    public override void OnClickHome()
    {
        goto typeof(BWYMetaGameBeavior).__il2cppRuntimeField_20C;
    }
    public override string GetSceneNameFromSceneType(SceneType sceneType)
    {
        var val_1;
        var val_2;
        if(sceneType > 2)
        {
            goto label_1;
        }
        
        if(sceneType == 1)
        {
            goto label_2;
        }
        
        if(sceneType != 2)
        {
            goto label_6;
        }
        
        val_1 = "BlockBuilder_Game";
        return;
        label_1:
        if(sceneType == 6)
        {
            goto label_5;
        }
        
        if(sceneType == 9)
        {
                val_1 = "BlockBuilder_Zen";
            return;
        }
        
        label_6:
        val_2 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        return;
        label_2:
        val_1 = "BlockBuilder_Main";
        return;
        label_5:
        val_1 = "GameStoreScene";
    }
    public override SceneType getActiveSceneType()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if(val_1.m_Handle.buildIndex < 4)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  -773042880);
    }
    public override string get_NotifImgUrlDailyBonus()
    {
    
    }
    public override string get_NotifImgUrlPostAd()
    {
    
    }
    public override bool get_supportsDailyLoginRewardPopup()
    {
        GameBehavior val_1 = App.getBehavior;
        BlockPuzzleMagic.BestBlocksGameEcon val_2 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        if(0 >= 786450)
        {
                0 = 1;
        }
        
        return true;
    }
    public override bool get_supportsEvents()
    {
        return false;
    }
    public override bool get_supportsChallenges()
    {
        return false;
    }
    public override bool get_supportsGOTDPopup()
    {
        return false;
    }
    public override bool get_supportsSubscriptions()
    {
        return false;
    }
    public override bool get_supportsFriendInviter()
    {
        return true;
    }
    public override bool get_supportsRecaptureNotifications()
    {
        return false;
    }
    public override void LoadScene(SceneType sceneToLoad, bool immediate = False)
    {
        CUtils.LoadSceneImmediate(sceneName:  -771894320);
    }
    public override void AppendUserProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> userProperties)
    {
        var val_3;
        if((System.String.IsNullOrEmpty(value:  -771794112)) != true)
        {
                val_3 = userProperties;
            val_3.Add(key:  -771794016, value:  -771794112);
        }
        
        BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
        userProperties.Add(key:  -771793904, value:  13152256);
        userProperties.Add(key:  -771793792, value:  13152256);
        userProperties.Add(key:  -771793696, value:  13152256);
    }
    public override void AppendCommonEventProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> eventProperties)
    {
        bool val_2 = static_value_021FBB14;
        if(val_2 != true)
        {
                val_2 = true;
        }
        
        BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
        eventProperties.Add(key:  -771665344, value:  13152256);
    }
    public override bool GemsUnlocked()
    {
        return false;
    }
    public BWYMetaGameBeavior()
    {
    
    }

}
