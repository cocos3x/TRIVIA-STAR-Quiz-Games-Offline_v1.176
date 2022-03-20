using UnityEngine;
public class RESMetaGameBehavior : MetaGameBehavior
{
    // Fields
    private SceneType <LastSceneType>k__BackingField;
    
    // Properties
    public override System.Collections.Generic.Dictionary<string, System.Type> EventHandlerTypeLookup { get; }
    public override int PlayerStructureLevel { get; }
    public override int HighestAvailableUniqueStructureLevel { get; }
    public override decimal PlayerInitialCoins { get; }
    public override int PlayerInitialGoldenCurrency { get; }
    public SceneType LastSceneType { get; set; }
    public override bool supportsSpins { get; }
    public override bool supportsFBConnect { get; }
    public override bool supportsFBShare { get; }
    public override bool supportsSubscriptions { get; }
    public override bool canShowGoldenTicketStoreItem { get; }
    public override bool supportsEvents { get; }
    public override bool supportAdsControl { get; }
    public override bool supportsFriendInviter { get; }
    public override bool supportsExtraWordsList { get; }
    public override bool supportsChallengeFLyout { get; }
    public override bool supportsCategoryLevelPacks { get; }
    public override bool supportsFeatureMenu { get; }
    public override bool supportsNotificationLifecylce { get; }
    public override bool supportsPets { get; }
    public override bool supportsDifficultySetting { get; }
    public override bool supportsLocalization { get; }
    public override bool supportsAlphabet { get; }
    public override bool supportsChallenges { get; }
    public override bool IsDailyBonusAvailable { get; }
    public override bool IsDailyBonusFtuxAvailable { get; }
    
    // Methods
    public override System.Collections.Generic.Dictionary<string, System.Type> get_EventHandlerTypeLookup()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(308944896)});
        Add(key:  -1549997168, value:  308944896);
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(330084352)});
        Add(key:  -1298907488, value:  330084352);
    }
    public override int get_PlayerStructureLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static RestaurantRivals.RESRestaurantManager MonoSingleton<RestaurantRivals.RESRestaurantManager>::get_Instance()) != 0)
        {
                return CurrentRestaurantID;
        }
        
        return CurrentRestaurantID;
    }
    public override int get_HighestAvailableUniqueStructureLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return (int)public static RestaurantRivals.RESRestaurantManager MonoSingleton<RestaurantRivals.RESRestaurantManager>::get_Instance().__il2cppRuntimeField_1C + 12;
    }
    public override decimal get_PlayerInitialCoins()
    {
        val_1 = new System.Decimal(value:  75000);
        return new System.Decimal() {flags = val_1, hi = 75000};
    }
    public override int get_PlayerInitialGoldenCurrency()
    {
        return 0;
    }
    public SceneType get_LastSceneType()
    {
    
    }
    public void set_LastSceneType(SceneType value)
    {
        this.<LastSceneType>k__BackingField = value;
    }
    public RESMetaGameBehavior()
    {
        this.<LastSceneType>k__BackingField = 0;
    }
    public override bool get_supportsSpins()
    {
        return true;
    }
    public override bool get_supportsFBConnect()
    {
        return false;
    }
    public override bool get_supportsFBShare()
    {
        return false;
    }
    public override bool get_supportsSubscriptions()
    {
        return false;
    }
    public override System.Type getDefinitions<T>()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(422363136)});
    }
    public override bool get_canShowGoldenTicketStoreItem()
    {
        return false;
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
    public override System.Collections.Generic.List<PurchaseModel> FilterStoreCreditPacksPerGame(System.Collections.Generic.List<PurchaseModel> unfiltered)
    {
        var val_2;
        System.Predicate<PurchaseModel> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = RESMetaGameBehavior.<>c.<>9__27_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Predicate<ZooTile>(object:  RESMetaGameBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3565240352));
            RESMetaGameBehavior.<>c.<>9__27_0 = val_4;
        }
        
        if(unfiltered != 0)
        {
                return unfiltered.FindAll(match:  8040448);
        }
        
        return unfiltered.FindAll(match:  8040448);
    }
    public override void WildWeekedOnContinue()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override string GetUrlSharePrefix()
    {
    
    }
    public override SceneType GetSceneTypeFromSceneName(string sceneName)
    {
        if((sceneName.Contains(value:  -729381728)) == true)
        {
                return;
        }
        
        if((sceneName.Contains(value:  -729381616)) == false)
        {
                return this.GetSceneTypeFromSceneName(sceneName:  sceneName);
        }
    
    }
    public override string GetSceneNameFromSceneType(SceneType sceneType)
    {
        var val_3;
        var val_4;
        SceneType val_1 = sceneType - 1;
        if(val_1 <= 10)
        {
                var val_2 = 8149060 + (8149060 + ((sceneType - 1)) << 2);
            if(val_1 == 10)
        {
                8149060 + ((sceneType - 1)) << 2 = (8149060 + ((sceneType - 1)) << 2) & ((IP) >> 32);
            8149060 + ((sceneType - 1)) << 2 = (8149060 + ((sceneType - 1)) << 2) & ((IP) >> 32);
            8149060 + ((sceneType - 1)) << 2 = (8149060 + ((sceneType - 1)) << 2) & ((R8) >> ((8149060 + ((sceneType - 1)) << 2 & (IP) >> 32) & (IP) >> 32));
            8149060 + ((sceneType - 1)) << 2 = (8149060 + ((sceneType - 1)) << 2) & (sceneType >> 32);
            8149060 + ((sceneType - 1)) << 2 = (8149060 + ((sceneType - 1)) << 2) & ((8149060 + ((sceneType - 1)) << 2) >> 1);
            8149060 + ((sceneType - 1)) << 2 = (8149060 + ((sceneType - 1)) << 2) & ((IP) >> 1);
            8149060 + ((sceneType - 1)) << 2 = (8149060 + ((sceneType - 1)) << 2) & (sceneType >> 32);
            8149060 + ((sceneType - 1)) << 2 = (8149060 + ((sceneType - 1)) << 2) & (sceneType >> 32);
            8149060 + ((sceneType - 1)) << 2 = (8149060 + ((sceneType - 1)) << 2) & (sceneType >> 32);
            8149060 + ((sceneType - 1)) << 2 = (8149060 + ((sceneType - 1)) << 2) & (sceneType >> 32);
            mem2[0] = ((((((((((8149060 + ((sceneType - 1)) << 2 & (IP) >> 32) & (IP) >> 32) & (R8) >> ((8149060 + ((sceneType - 1)) << 2 & (IP) >> 32) & (IP) >> 32)) & ((int)sceneType) >> 32) & (((((8149060 + ((sceneType  + R8;
        }
        
            val_3 = "Game";
            return;
        }
        
        val_4 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    }
    public override void LoadScene(SceneType sceneToLoad, bool immediate = False)
    {
        this.<LastSceneType>k__BackingField = this;
        this.LoadScene(sceneToLoad:  sceneToLoad, immediate:  immediate);
    }
    public override bool DailyChallengeSupported()
    {
        return false;
    }
    public override bool StoryModeSupported()
    {
        return false;
    }
    public override void OnClickHome()
    {
        if(this == 2)
        {
                return;
        }
        
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override void SaveAllLevelsForCurrentGame(System.Collections.Generic.List<object> response)
    {
    
    }
    public override SceneType getActiveSceneType()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_2 = val_1.m_Handle.name;
    }
    public override string GetTitleFormat()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(static_value_0028000F == 1)
        {
                "{0}" = "•{0}•";
        }
    
    }
    public override bool get_supportsEvents()
    {
        return true;
    }
    public override bool GemsUnlocked()
    {
        return false;
    }
    public override bool get_supportAdsControl()
    {
        return true;
    }
    public override bool get_supportsFriendInviter()
    {
        return false;
    }
    public override bool get_supportsExtraWordsList()
    {
        return false;
    }
    public override bool get_supportsChallengeFLyout()
    {
        return false;
    }
    public override bool get_supportsCategoryLevelPacks()
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
    public override bool get_supportsPets()
    {
        return false;
    }
    public override bool get_supportsDifficultySetting()
    {
        return false;
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
    public override bool get_supportsLocalization()
    {
        return false;
    }
    public override bool get_supportsAlphabet()
    {
        return false;
    }
    public override void DoStoreCloseVideoLogic(bool purchased, bool ooc)
    {
    
    }
    public override bool get_supportsChallenges()
    {
        return false;
    }
    public override bool get_IsDailyBonusAvailable()
    {
        RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
        GameEcon val_2 = App.getGameEcon;
        if(1030672 >= 1092)
        {
                0 = 1;
        }
        
        return true;
    }
    public override bool get_IsDailyBonusFtuxAvailable()
    {
        return false;
    }
    public override string GetDailyBonusNotificationTitle()
    {
    
    }
    public override string GetDailyBonusNotificationMessage()
    {
    
    }
    public override string GetCoinStoreBannerText()
    {
        return Localization.Localize(key:  -1528659216, defaultValue:  -1528659376, useSingularKey:  false);
    }
    public override void AppendUserProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> userProperties)
    {
        Player val_1 = App.Player;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = CurrentRestaurantStage.ToString(format:  -725984464);
        string val_5 = System.String.Format(format:  -1671354896, arg0:  13152256, arg1:  -725972312);
        if((System.Int32.TryParse(s:  -1671354896, result: out  int val_6 = -725972308)) == false)
        {
                return;
        }
        
        userProperties.Add(key:  -725984384, value:  13152256);
    }

}
