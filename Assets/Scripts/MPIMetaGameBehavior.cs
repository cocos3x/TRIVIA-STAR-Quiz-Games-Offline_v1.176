using UnityEngine;
public class MPIMetaGameBehavior : MetaGameBehavior
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
    public override bool supportsDailyLoginRewardPopup { get; }
    public override bool alwaysForceReviewTracking { get; }
    
    // Methods
    public override System.Type getDefinitions<T>()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(343982080)});
    }
    public override bool AdsAllowedByScene()
    {
        return false;
    }
    public override SceneType getActiveSceneType()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_2 = val_1.m_Handle.name;
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
    public override bool get_supportsDailyLoginRewardPopup()
    {
        return true;
    }
    public override bool get_alwaysForceReviewTracking()
    {
        return true;
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
        val_4 = MPIMetaGameBehavior.<>c.<>9__26_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Predicate<ZooTile>(object:  MPIMetaGameBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3541593328));
            MPIMetaGameBehavior.<>c.<>9__26_0 = val_4;
        }
        
        if(unfiltered != 0)
        {
                return unfiltered.FindAll(match:  8040448);
        }
        
        return unfiltered.FindAll(match:  8040448);
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
    public override bool ArePopupsAllowedForSceneType(SceneType type)
    {
        type = type - 1;
        if(type < 2)
        {
                0 = 1;
        }
        
        return true;
    }
    public override string GetUrlSharePrefix()
    {
    
    }
    public override string GetTitleFormat()
    {
    
    }
    public override void AppendUserProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> userProperties)
    {
        var val_6;
        var val_7;
        Player val_1 = App.Player;
        userProperties.Add(key:  -752792336, value:  13152256);
        val_6 = 2621448;
        if(val_6 == 0)
        {
            goto label_6;
        }
        
        val_7 = 23;
        goto label_7;
        label_6:
        val_7 = 23;
        val_6 = 2621448;
        if(val_6 == 0)
        {
            goto label_8;
        }
        
        label_7:
        label_23:
        var val_6 = static_value_00280050;
        val_6 = val_6 + val_7;
        val_6 = val_6 + static_value_00280054;
        userProperties.Add(key:  -752792224, value:  13152256);
        userProperties.Add(key:  -752792112, value:  13152256);
        userProperties.Add(key:  -752791984, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -851040240)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_5 = CompletedCollections();
        userProperties.Add(key:  -752791856, value:  13152256);
        return;
        label_8:
        if(2621448 != 0)
        {
            goto label_23;
        }
    
    }
    public MPIMetaGameBehavior()
    {
        val_1 = new System.Object();
    }

}
