using UnityEngine;
public class MetaGameBehavior
{
    // Properties
    public virtual System.Collections.Generic.Dictionary<string, System.Type> DefaultEventTypes { get; }
    public virtual System.Collections.Generic.Dictionary<string, System.Type> EventHandlerTypeLookup { get; }
    public virtual int PlayerLevel { get; set; }
    public virtual int PlayerLevelHighest { get; }
    public virtual float AdsDisplayValueMultiplier { get; }
    public virtual int FTUXLevel { get; }
    public virtual int DailyChallengeVersion { get; }
    public virtual int RewardedVideoGemReward { get; }
    public virtual int PlayerStructureLevel { get; }
    public virtual int HighestAvailableUniqueStructureLevel { get; }
    public virtual decimal FOMOCurrency { get; }
    public virtual string FOMOCurrencyType { get; }
    public virtual string NotifImgUrlDailyBonus { get; }
    public virtual string NotifImgUrlPostAd { get; }
    public virtual bool supportsAdaptiveRewardedVideoReward { get; }
    public virtual bool supportsMiniSettingsPopupSoundButtons { get; }
    public virtual bool supportsSales { get; }
    public virtual bool supportsSeparatePlayerLevels { get; }
    public virtual bool supportsEvents { get; }
    public virtual bool isEventsDisplayable { get; }
    public virtual bool supportsGOTDPopup { get; }
    public virtual bool supportsDailyLoginRewardPopup { get; }
    public virtual bool supportsEmailCollectPopup { get; }
    public virtual bool supportsRecommendPopup { get; }
    public virtual bool supportsFriendInviter { get; }
    public virtual bool supportsFBConnect { get; }
    public virtual bool supportsExtraWordsList { get; }
    public virtual bool supportsChallenges { get; }
    public virtual bool supportsChallengeFLyout { get; }
    public virtual bool supportsSubscriptions { get; }
    public virtual bool supportsCategoryLevelPacks { get; }
    public virtual bool supportsRecaptureNotifications { get; }
    public virtual bool supportsFeatureMenu { get; }
    public virtual bool supportsNotificationLifecylce { get; }
    public virtual bool supportsPets { get; }
    public virtual bool supportsSpins { get; }
    public virtual bool supportsDifficultySetting { get; }
    public virtual bool supportsLocalization { get; }
    public virtual bool supportsAlphabet { get; }
    public virtual bool supportsWordIQ { get; }
    public virtual bool supportsLibrary { get; }
    public virtual bool supportsFBShare { get; }
    public virtual bool supportsRestoreProgression { get; }
    public virtual bool purchasesAlwaysRemoveAds { get; }
    public virtual bool leaguesRewardsCoins { get; }
    public virtual bool playMusicInLeaugues { get; }
    public virtual bool leaguesContributeCostCoins { get; }
    public virtual bool leaguesMultiplierCostCoins { get; }
    public virtual bool supportExtraRequiredWords { get; }
    public virtual bool supportsDailyChallengeTutorial { get; }
    public virtual bool supportsTournaments { get; }
    public virtual bool supportsBonusRewards { get; }
    public virtual bool supportsDiceRolls { get; }
    public virtual bool canShowGameSceneEventUpdates { get; }
    public virtual bool supportsLeaguesUnlockingAnimation { get; }
    public virtual bool alwaysForceReviewTracking { get; }
    public virtual bool supportAdsControl { get; }
    public virtual bool supportAdsControlV2 { get; }
    public virtual bool isWordGame { get; }
    public virtual bool supportsLeaguesLowPointJoinLock { get; }
    public virtual bool supportsSilverTicketDisplay { get; }
    public virtual bool canShowGoldenTicketStoreItem { get; }
    public virtual bool subscriptionGrantsGems { get; }
    public virtual bool IsDailyBonusAvailable { get; }
    public virtual bool IsDailyBonusFtuxAvailable { get; }
    protected virtual bool AdoptNewCurrencySourcePropKey { get; }
    public virtual decimal PlayerInitialCoins { get; }
    public virtual int PlayerInitialGems { get; }
    public virtual int PlayerInitialGoldenCurrency { get; }
    public virtual bool PiggyBankUsesGems { get; }
    public virtual bool SuperBundleUsesGems { get; }
    public virtual bool CanShowUnPauseInterstitial { get; }
    public virtual float WindowManagerBackgroundAlpha { get; }
    public virtual int PickerHintUnlockLevel { get; }
    public virtual int PickerHintTutorialLevel { get; }
    public virtual bool ShowV2PickerHintTutorial { get; }
    public virtual bool ShowV2HintTutorial { get; }
    public virtual int HintTutorialLevel { get; }
    public virtual bool SupportsFreeHints { get; }
    public virtual bool InNormalGameMode { get; }
    public virtual bool SkipTutorialEligible { get; }
    public virtual bool ExtraWordGameplayUpdate { get; }
    public virtual int WordStreakStartCount { get; }
    
    // Methods
    public virtual System.Collections.Generic.Dictionary<string, System.Type> get_DefaultEventTypes()
    {
    
    }
    public virtual System.Collections.Generic.Dictionary<string, System.Type> get_EventHandlerTypeLookup()
    {
    
    }
    public virtual System.Type getDefinitions<T>()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
    }
    public virtual bool AdsAllowedByScene()
    {
        return false;
    }
    public virtual bool BannerAdsSkipPlayerLevelCheck()
    {
        return false;
    }
    public virtual bool levelClearShown()
    {
        return false;
    }
    public virtual void WildWeekedOnContinue()
    {
        UnityEngine.Debug.LogError(message:  -751310560);
    }
    public virtual void SaveLevelsFromChaptersCurrentGame(System.Collections.Generic.List<object> chapters, string language = "")
    {
        UnityEngine.Debug.LogWarning(message:  -751190176);
    }
    public virtual bool UsesSingleScene()
    {
        return false;
    }
    public virtual void LoadSingleSceneGameplayScene()
    {
    
    }
    public virtual string GetUrlSharePrefix()
    {
        UnityEngine.Debug.LogError(message:  -750845712);
    }
    public virtual string GetShareTextScreenShot()
    {
    
    }
    public virtual string GetLevelNameForTracking()
    {
    
    }
    public virtual string GetLevelForTracking()
    {
    
    }
    public virtual bool DailyChallengeSupported()
    {
        return false;
    }
    public virtual bool DailyChallengeRevamped()
    {
        return false;
    }
    public virtual bool StoryModeSupported()
    {
        return false;
    }
    public virtual void OnClickHome()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                App.Quit();
            return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public virtual void SaveAllLevelsForCurrentGame(System.Collections.Generic.List<object> response)
    {
        var val_2;
        var val_2 = 27700079;
        val_2 = 7925708 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        string val_1 = -749945024(-749945024) + 295313408;
        UnityEngine.Debug.LogError(message:  -749945024);
    }
    public virtual void ShowFTUXWindow()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public virtual SceneType getActiveSceneType()
    {
        var val_2;
        var val_2 = 27699751;
        val_2 = 7926036 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        string val_1 = -749715728(-749715728) + 295313408 + -749715600(-749715600);
        UnityEngine.Debug.LogError(message:  -749715728);
    }
    public virtual SceneType getOverlayedSceneType()
    {
        var val_1;
        var val_1 = 27703169;
        val_1 = 7926380 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
    }
    public virtual bool overlaySceneShowing()
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_2 = 27702965;
        val_2 = 7926584 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = 0;
        if(SceneDictator.lastOverlayedScene == 0)
        {
                return true;
        }
        
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(SceneDictator.lastOverlayedScene == 1)
        {
                return true;
        }
        
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        SceneType val_1 = SceneDictator.lastOverlayedScene - 2;
        if(SceneDictator.__il2cppRuntimeField_cctor_finished != 0)
        {
                val_3 = 1;
        }
        
        return true;
    }
    public virtual string GetTitleFormat()
    {
    
    }
    public virtual int get_PlayerLevel()
    {
        Player val_1 = App.Player;
        if(0 == 0)
        {
            
        }
    
    }
    public virtual void set_PlayerLevel(int value)
    {
        Player val_1 = App.Player;
        if(0 == 0)
        {
            
        }
    
    }
    public virtual int get_PlayerLevelHighest()
    {
        Player val_1 = App.Player;
        if(0 == 0)
        {
            
        }
    
    }
    public virtual float get_AdsDisplayValueMultiplier()
    {
        return (float)S0;
    }
    public virtual int get_FTUXLevel()
    {
        return 2;
    }
    public virtual int get_DailyChallengeVersion()
    {
        return 6;
    }
    public virtual int get_RewardedVideoGemReward()
    {
        UnityEngine.Debug.LogError(message:  -748595344);
        return 0;
    }
    public virtual int get_PlayerStructureLevel()
    {
        Player val_1 = App.Player;
        if(0 == 0)
        {
            
        }
    
    }
    public virtual int get_HighestAvailableUniqueStructureLevel()
    {
        return 999999;
    }
    public virtual decimal get_FOMOCurrency()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return new System.Decimal() {flags = 60, hi = App.__il2cppRuntimeField_cctor_finished};
        }
        
        return new System.Decimal() {flags = 60, hi = App.__il2cppRuntimeField_cctor_finished};
    }
    public virtual string get_FOMOCurrencyType()
    {
    
    }
    public virtual System.Collections.Generic.List<PurchaseModel> FilterStoreCreditPacksPerGame(System.Collections.Generic.List<PurchaseModel> unfiltered)
    {
        var val_2;
        System.Predicate<PurchaseModel> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = MetaGameBehavior.<>c.<>9__47_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Predicate<ZooTile>(object:  MetaGameBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3546936288));
            MetaGameBehavior.<>c.<>9__47_0 = val_4;
        }
        
        if(unfiltered != 0)
        {
                return unfiltered.FindAll(match:  8040448);
        }
        
        return unfiltered.FindAll(match:  8040448);
    }
    public virtual System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> CustomGemCreditPacks()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  -747913888);
        Add(key:  -1930648496, value:  13152256);
        Add(key:  -1816221696, value:  15282176);
        Add(item:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  -747913792);
        Add(key:  -1930648496, value:  13152256);
        Add(key:  -1816221696, value:  15282176);
        Add(item:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  -747913696);
        Add(key:  -1930648496, value:  13152256);
        Add(key:  -1816221696, value:  15282176);
        Add(item:  78753792);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  -747913600);
        Add(key:  -1930648496, value:  13152256);
        Add(key:  -1816221696, value:  15282176);
        Add(item:  78753792);
    }
    public virtual void ReloadScene(bool fadeOut)
    {
        CUtils.ReloadScene(useScreenFader:  fadeOut);
    }
    public virtual void LoadScene(SceneType sceneToLoad, bool immediate = False)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1261410688) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ForceClose();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-747685408) != 0)
        {
                SLC.Social.Leagues.LeaguesUIManager.LeaveLeaguesScene();
        }
        
        if((sceneToLoad != 3) && (immediate != true))
        {
                ThemesHandler val_6 = App.ThemesHandler;
            string val_7 = 0.CurrentThemeName;
            string val_8 = -747660384(-747660384) + 2144339952 + null;
            CUtils.FadeAndLoadScene(sceneName:  -747660384);
            return;
        }
        
        ThemesHandler val_9 = App.ThemesHandler;
        string val_10 = 0.CurrentThemeName;
        string val_11 = 379232256 + 2144339952 + 0;
        CUtils.LoadSceneImmediate(sceneName:  379232256);
    }
    public bool IsLoadingScene()
    {
        return CUtils.IsLoadingScene();
    }
    public virtual string GetSceneNameFromSceneType(SceneType sceneType)
    {
        var val_3;
        var val_4;
        SceneType val_1 = sceneType - 1;
        if(val_1 <= 11)
        {
                var val_2 = 7930808 + (7930808 + ((sceneType - 1)) << 2);
            if(val_1 == 11)
        {
                7930808 + ((sceneType - 1)) << 2 = (7930808 + ((sceneType - 1)) << 2) & ((7930808 + ((sceneType - 1)) << 2) >> (7930808 + ((sceneType - 1)) << 2));
            7930808 + ((sceneType - 1)) << 2 = (7930808 + ((sceneType - 1)) << 2) & ((IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2));
            7930808 + ((sceneType - 1)) << 2 = (7930808 + ((sceneType - 1)) << 2) & (((int)R8) >> 32);
            7930808 + ((sceneType - 1)) << 2 = (7930808 + ((sceneType - 1)) << 2) & (sceneType >> (7930808 + ((sceneType - 1)) << 2));
            7930808 + ((sceneType - 1)) << 2 = (7930808 + ((sceneType - 1)) << 2) & (((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 79308) << (32-as. 
            
        
        
        
        
        
           
        )) | ((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 79308) << as. 
            
        
        
        
        
        
           
        ));
            mem2[0] = (((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930 + IP;
            ((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930 + IP) & (((int)R8) >> 1) = (((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930 + IP) & (((int)R8) >> 1)) & (((((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 793) << (32-as. 
            
        
        
        
        
        
           
        )) | ((((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 793) << as. 
            
        
        
        
        
        
           
        ));
            ((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930 + IP) & (((int)R8) >> 1) = (((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930 + IP) & (((int)R8) >> 1)) & ((((((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 79) << (32-1)) | (((((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 79) << 1));
            ((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930 + IP) & (((int)R8) >> 1) = (((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930 + IP) & (((int)R8) >> 1)) & (((((((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7) << (32-as. 
            
        
        
        
        
        
           
        )) | ((((((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7) << as. 
            
        
        
        
        
        
           
        ));
            ((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930 + IP) & (((int)R8) >> 1) = (((((((7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930808 + ((sceneType - 1)) << 2) & (IP) >> (7930808 + ((sceneType - 1)) << 2 & (7930808 + ((sceneType - 1)) << 2) >> 7930 + IP) & (((int)R8) >> 1)) & (((IP) << (32-1)) | ((IP) << 1));
        }
        
            val_3 = "LaunchScene";
            return;
        }
        
        val_4 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    }
    public virtual SceneType GetSceneTypeFromSceneName(string sceneName)
    {
        var val_11 = 6;
        if((sceneName.Contains(value:  -1262000640)) == true)
        {
                return;
        }
        
        val_11 = 0;
        if((sceneName.Contains(value:  -747331360)) == true)
        {
                return;
        }
        
        val_11 = 1;
        if((sceneName.Contains(value:  -747331280)) == true)
        {
                return;
        }
        
        val_11 = 3;
        if((sceneName.Contains(value:  -747331200)) == true)
        {
                return;
        }
        
        val_11 = 2;
        if((sceneName.Contains(value:  -800141568)) == true)
        {
                return;
        }
        
        val_11 = 4;
        if((sceneName.Contains(value:  -747331120)) == true)
        {
                return;
        }
        
        val_11 = 7;
        if((sceneName.Contains(value:  -1430477984)) == true)
        {
                return;
        }
        
        val_11 = 8;
        if((sceneName.Contains(value:  -747331040)) == true)
        {
                return;
        }
        
        val_11 = 10;
        if((sceneName.Contains(value:  -747330944)) != false)
        {
                return;
        }
        
        if((sceneName.Contains(value:  -1401622144)) == true)
        {
                3 = 12;
        }
    
    }
    public virtual bool ArePopupsAllowedForSceneType(SceneType type)
    {
        type = type - 1;
        if(type < 2)
        {
                0 = 1;
        }
        
        return true;
    }
    public virtual void PlayGame()
    {
        goto typeof(MetaGameBehavior).__il2cppRuntimeField_20C;
    }
    public virtual int GetHintsUsed()
    {
        var val_6 = 1152921504885600256;
        MainController val_1 = MainController.instance;
        if(278753280 != 0)
        {
                MainController val_3 = MainController.instance;
            if(null != 0)
        {
            goto mem[null + 268];
        }
        
        }
        else
        {
                System.NotImplementedException val_4 = new System.NotImplementedException();
        }
    
    }
    public virtual string get_NotifImgUrlDailyBonus()
    {
    
    }
    public virtual string get_NotifImgUrlPostAd()
    {
    
    }
    public virtual bool get_supportsAdaptiveRewardedVideoReward()
    {
        return true;
    }
    public virtual bool get_supportsMiniSettingsPopupSoundButtons()
    {
        return true;
    }
    public virtual bool get_supportsSales()
    {
        return true;
    }
    public virtual bool get_supportsSeparatePlayerLevels()
    {
        return false;
    }
    public virtual bool get_supportsEvents()
    {
        return false;
    }
    public virtual bool get_isEventsDisplayable()
    {
        GameBehavior val_1 = App.getBehavior;
        GameEcon val_2 = App.getGameEcon;
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  983057);
    }
    public virtual bool get_supportsGOTDPopup()
    {
        return true;
    }
    public virtual bool get_supportsDailyLoginRewardPopup()
    {
        return true;
    }
    public virtual bool get_supportsEmailCollectPopup()
    {
        return true;
    }
    public virtual bool get_supportsRecommendPopup()
    {
        return true;
    }
    public virtual bool get_supportsFriendInviter()
    {
        return false;
    }
    public virtual bool get_supportsFBConnect()
    {
        return false;
    }
    public virtual bool get_supportsExtraWordsList()
    {
        return false;
    }
    public virtual bool get_supportsChallenges()
    {
        return true;
    }
    public virtual bool get_supportsChallengeFLyout()
    {
        return false;
    }
    public virtual bool get_supportsSubscriptions()
    {
        return true;
    }
    public virtual bool get_supportsCategoryLevelPacks()
    {
        return false;
    }
    public virtual bool get_supportsRecaptureNotifications()
    {
        return true;
    }
    public virtual bool get_supportsFeatureMenu()
    {
        return false;
    }
    public virtual bool get_supportsNotificationLifecylce()
    {
        return false;
    }
    public virtual bool get_supportsPets()
    {
        return false;
    }
    public virtual bool get_supportsSpins()
    {
        return false;
    }
    public virtual bool get_supportsDifficultySetting()
    {
        return false;
    }
    public virtual bool get_supportsLocalization()
    {
        return false;
    }
    public virtual bool get_supportsAlphabet()
    {
        return false;
    }
    public virtual bool get_supportsWordIQ()
    {
        return true;
    }
    public virtual bool get_supportsLibrary()
    {
        return true;
    }
    public virtual bool get_supportsFBShare()
    {
        return true;
    }
    public virtual bool get_supportsRestoreProgression()
    {
        return false;
    }
    public virtual bool get_purchasesAlwaysRemoveAds()
    {
        return true;
    }
    public virtual bool get_leaguesRewardsCoins()
    {
        return true;
    }
    public virtual bool get_playMusicInLeaugues()
    {
        return true;
    }
    public virtual bool get_leaguesContributeCostCoins()
    {
        return true;
    }
    public virtual bool get_leaguesMultiplierCostCoins()
    {
        return true;
    }
    public virtual bool get_supportExtraRequiredWords()
    {
        return true;
    }
    public virtual bool get_supportsDailyChallengeTutorial()
    {
        return false;
    }
    public virtual bool get_supportsTournaments()
    {
        return false;
    }
    public virtual bool get_supportsBonusRewards()
    {
        return false;
    }
    public virtual bool get_supportsDiceRolls()
    {
        return false;
    }
    public virtual bool get_canShowGameSceneEventUpdates()
    {
        return true;
    }
    public virtual void AppendUserProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> userProperties)
    {
    
    }
    public virtual bool get_supportsLeaguesUnlockingAnimation()
    {
        return false;
    }
    public virtual bool get_alwaysForceReviewTracking()
    {
        return false;
    }
    public virtual bool get_supportAdsControl()
    {
        return true;
    }
    public virtual bool get_supportAdsControlV2()
    {
        return false;
    }
    public virtual bool get_isWordGame()
    {
        return false;
    }
    public virtual bool get_supportsLeaguesLowPointJoinLock()
    {
        return false;
    }
    public virtual bool get_supportsSilverTicketDisplay()
    {
        return true;
    }
    public virtual bool get_canShowGoldenTicketStoreItem()
    {
        return true;
    }
    public virtual void AppendCommonEventProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> eventProperties)
    {
    
    }
    public virtual bool AlwaysShowOOCVideoPostStore(bool OOCloop)
    {
        return true;
    }
    public virtual bool get_subscriptionGrantsGems()
    {
        return false;
    }
    public virtual bool get_IsDailyBonusAvailable()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        if(0 >= 1092)
        {
                0 = 1;
        }
        
        return true;
    }
    public virtual bool get_IsDailyBonusFtuxAvailable()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        var val_3 = 1092;
        val_3 = 0 - val_3;
        val_3 = val_3 >> 5;
        return (bool)val_3;
    }
    public virtual void DoStoreCloseVideoLogic(bool purchased, bool ooc)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        if(purchased != false)
        {
                return;
        }
        
        var val_14 = 27692410;
        val_14 = 7933380 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        if((FOMOPackEventHandler.<Instance>k__BackingField) != 0)
        {
                bool val_1 = FOMOPackEventHandler.<Instance>k__BackingField.TryShowPopup(isOOC:  true);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            var val_15 = 27692388;
            val_15 = 7933672 + val_15;
            if(val_15 == 0)
        {
                mem2[0] = 1;
        }
        
            val_14 = null;
            val_14 = null;
            TryShowPromptVideo(entryPoint:  PurchaseProxy.currentPurchasePoint, showAsFlyout:  false);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-740564656) == 0)
        {
                return;
        }
        
        var val_16 = 27693469;
        val_16 = 7933956 + val_16;
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
        {
                return;
        }
        
        WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(rewardVideoCapReached == true)
        {
                return;
        }
        
        GameBehavior val_9 = App.getBehavior;
        var val_17 = 27691740;
        val_17 = 7934320 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_16 = null;
        val_16 = null;
        HeyZapAdTag val_11 = AdsUIController.GetTagForPurchasePoint(entryPoint:  PurchaseProxy.currentPurchasePoint);
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_17 = null;
        val_17 = null;
        string val_12 = AdsUIController.GetFreeCoinsEventForPurchasePoint(entryPoint:  PurchaseProxy.currentPurchasePoint);
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_18 = null;
        val_18 = null;
        CurrencyRewardType val_13 = AdsUIController.GetCurrencyRewardForPurchasePoint(entryPoint:  PurchaseProxy.currentPurchasePoint);
        if(0 != 0)
        {
                return;
        }
    
    }
    protected virtual bool get_AdoptNewCurrencySourcePropKey()
    {
        var val_2;
        var val_1 = 27690939;
        val_1 = 7934848 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(App.game <= 21)
        {
                if(2613246 != (1 << App.game))
        {
                return false;
        }
        
        }
        
        if(App.game != 99)
        {
                return true;
        }
        
        return false;
    }
    public virtual void TrackCreditsSpent(decimal amount, string source, decimal previousBalance, System.Collections.Generic.Dictionary<string, object> extraParams)
    {
        float val_27;
        string val_28;
        int val_29;
        int val_30;
        var val_31;
        val_27 = this;
        val_28 = source;
        val_29 = amount.lo;
        val_30 = amount.hi;
        if((System.String.op_Equality(a:  val_28, b:  -1927262672)) == true)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_27 != 0)
        {
                "Source" = "Sink";
        }
        
        Add(key:  -740331440, value:  source);
        Add(key:  -1942303456, value:  10170368);
        Player val_3 = App.Player;
        val_28 = previousBalance.hi;
        val_30 = previousBalance.flags;
        val_29 = 1152921510535002416;
        Add(key:  -1927748000, value:  10170368);
        Add(key:  -1927747904, value:  10170368);
        Add(key:  -2100706208, value:  -740306560);
        Add(key:  -2100706112, value:  -740306560);
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE != 0)
        {
                bool val_4 = LightningWordsHandler.DEFAULT_REWARD_VALUE.IsCoinSpentDuringLightningWord();
            Add(key:  -1319127232, value:  8945664);
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) != 0)
        {
                bool val_5 = LightningLevelsEventHandler.<Instance>k__BackingField.IsLightningStrikenLevel();
            Add(key:  -740331360, value:  8945664);
        }
        
        GameBehavior val_6 = App.getBehavior;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_8 = PlayingChallenge;
            Add(key:  -2100705808, value:  8945664);
        }
        
        GameBehavior val_9 = App.getBehavior;
        if(0 != 0)
        {
                string val_11 = CategoryPacksManager.IsPlaying.ToString();
            Add(key:  -2100063088, value:  -740318597);
        }
        
        GameBehavior val_12 = App.getBehavior;
        if(0 != 0)
        {
                if(Alphabet2Manager.IsAvailable != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_15 = GetCurrentCollectionLetter;
            bool val_16 = System.String.IsNullOrEmpty(value:  -2100700048);
            val_16 = val_16 ^ 1;
            Add(key:  -740331248, value:  8945664);
        }
        
        }
        
        GameBehavior val_17 = App.getBehavior;
        if(0 != 0)
        {
                if((System.String.op_Equality(a:  source, b:  -2100706320)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Add(key:  -740331120, value:  13152256);
        }
        
        }
        
        var val_27 = 27692458;
        val_27 = 7937092 + val_27;
        if(val_27 == 0)
        {
                mem2[0] = 1;
        }
        
        if(KeyToRichesEventHandler._Instance != 0)
        {
                bool val_20 = KeyToRichesEventHandler._Instance.IsKeyLevel;
            Add(key:  -740330992, value:  8945664);
        }
        
        var val_28 = 27692307;
        val_28 = 7937244 + val_28;
        if(val_28 == 0)
        {
                mem2[0] = 1;
        }
        
        if((BingoEventHandler.<Instance>k__BackingField) != 0)
        {
                bool val_21 = BingoEventHandler.<Instance>k__BackingField.HasMovingItem;
            Add(key:  -740330896, value:  8945664);
        }
        
        var val_29 = 27690278;
        val_29 = 7937396 + val_29;
        if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY != null)
        {
                bool val_22 = SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.isActive;
            Add(key:  -740330784, value:  8945664);
        }
        
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP != null)
        {
                bool val_23 = WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP.IsLevelContainEventWord();
            Add(key:  -740330672, value:  8945664);
        }
        
        if(extraParams == 0)
        {
            goto label_67;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_24 = 0.GetEnumerator();
        val_28 = 1152921510367989680;
        val_27 = 1152921510392296080;
        label_72:
        if(0.MoveNext() == false)
        {
            goto label_68;
        }
        
        if((ContainsKey(key:  R5)) == true)
        {
            goto label_72;
        }
        
        Add(key:  R5, value:  0);
        goto label_72;
        label_68:
        0.Dispose();
        label_67:
        var val_30 = 27687670;
        val_30 = 7937868 + val_30;
        if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
        val_31 = null;
        val_31 = null;
        App.trackerManager.track(eventName:  -1942303456, data:  78753792);
    }
    public virtual void TrackGemsSpent(int amount, string source, int previousBalance)
    {
        string val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = source;
        val_9 = 35629410;
        if((System.String.op_Equality(a:  val_8, b:  -1927262672)) == true)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(this != 0)
        {
                "Source" = "Sink";
        }
        
        Add(key:  -740331440, value:  val_8);
        val_10 = null;
        if(null == 0)
        {
                val_10 = null;
        }
        
        Add(key:  -740206272, value:  13152256);
        val_9 = 1152921504892043264;
        Player val_3 = App.Player;
        Add(key:  -763995120, value:  13152256);
        Add(key:  -1927747904, value:  13152256);
        val_8 = 1152921511095741472;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            InjectGemSpentTrackingInfo(trackingData: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = -740194216);
        }
        
        var val_8 = 27685970;
        val_8 = 7939568 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        App.trackerManager.track(eventName:  -740206272, data:  78753792);
    }
    public virtual void TrackGoldenCurrencySpent(int amount, string source, System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        var val_6;
        int val_7;
        var val_8;
        val_6 = additionalParams;
        val_7 = amount;
        if((System.String.op_Equality(a:  source, b:  -1927262672)) == true)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(null != 0)
        {
                Add(key:  -1928004976, value:  13152256);
        }
        else
        {
                Add(key:  -1928004976, value:  13152256);
        }
        
        Add(key:  -1928142032, value:  source);
        if(val_6 == 0)
        {
            goto label_21;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_3 = 0.GetEnumerator();
        val_6 = 1152921510367989680;
        label_9:
        if(0.MoveNext() == false)
        {
            goto label_5;
        }
        
        if((ContainsKey(key:  R6)) == true)
        {
            goto label_9;
        }
        
        Add(key:  R6, value:  0);
        goto label_9;
        label_5:
        0.Dispose();
        label_21:
        val_7 = 7940316 + 27685222;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        App.trackerManager.track(eventName:  -740081888, data:  78753792);
    }
    public virtual T ShowUGUIMonolith<T>(bool showNext = False)
    {
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        val_32 = __RuntimeMethodHiddenParam;
        val_33 = showNext;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_34 = 1152921504765685760;
        if((-739961584) == 0)
        {
            goto label_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_35 = public static SLC.Minigames.MinigamesWindowManager MonoSingleton<SLC.Minigames.MinigamesWindowManager>::get_Instance();
        val_36 = mem[__RuntimeMethodHiddenParam + 24];
        val_36 = __RuntimeMethodHiddenParam + 24;
        goto __RuntimeMethodHiddenParam + 24 + 28;
        label_5:
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1436925536) == 0)
        {
            goto label_14;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_35 = public static SLC.Social.Leagues.LeaguesWindowManager MonoSingleton<SLC.Social.Leagues.LeaguesWindowManager>::get_Instance();
        val_36 = mem[__RuntimeMethodHiddenParam + 24 + 4];
        val_36 = __RuntimeMethodHiddenParam + 24 + 4;
        goto __RuntimeMethodHiddenParam + 24 + 28;
        label_14:
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1258856224) == 0)
        {
            goto label_27;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_35 = public static GameStoreWindowManager MonoSingleton<GameStoreWindowManager>::get_Instance();
        val_36 = mem[__RuntimeMethodHiddenParam + 24 + 8];
        val_36 = __RuntimeMethodHiddenParam + 24 + 8;
        goto __RuntimeMethodHiddenParam + 24 + 28;
        label_27:
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1685569840) == 0)
        {
            goto label_45;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1689626000) == 0)
        {
            goto label_45;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_35 = public static LibraryWindowManager MonoSingleton<LibraryWindowManager>::get_Instance();
        val_36 = mem[__RuntimeMethodHiddenParam + 24 + 12];
        val_36 = __RuntimeMethodHiddenParam + 24 + 12;
        goto __RuntimeMethodHiddenParam + 24 + 28;
        label_45:
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1507758960) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_35 = public static CategoriesWindowManager MonoSingleton<CategoriesWindowManager>::get_Instance();
            val_36 = mem[__RuntimeMethodHiddenParam + 24 + 16];
            val_36 = __RuntimeMethodHiddenParam + 24 + 16;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1173834192) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_35 = public static WADPetsWindowManager MonoSingleton<WADPetsWindowManager>::get_Instance();
            val_36 = mem[__RuntimeMethodHiddenParam + 24 + 20];
            val_36 = __RuntimeMethodHiddenParam + 24 + 20;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-739960560) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_35 = public static RaidAttackWindowManager MonoSingleton<RaidAttackWindowManager>::get_Instance();
            val_36 = mem[__RuntimeMethodHiddenParam + 24 + 24];
            val_36 = __RuntimeMethodHiddenParam + 24 + 24;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_37 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            if(2119322896 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_35 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            val_36 = mem[__RuntimeMethodHiddenParam + 24 + 28];
            val_36 = __RuntimeMethodHiddenParam + 24 + 28;
        }
        else
        {
                System.Type val_29 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = SB + 24 + 32});
            string val_30 = -739959536(-739959536) + SB + 24 + 32(SB + 24 + 32) + -739959392(-739959392);
            UnityEngine.Debug.LogError(message:  -739959536);
        }
        
        }
        
        }
        
        }
    
    }
    public virtual T ShowUGUIFlyOut<T>()
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-739961584) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = public static SLC.Minigames.MinigamesWindowManager MonoSingleton<SLC.Minigames.MinigamesWindowManager>::get_Instance();
            val_10 = mem[__RuntimeMethodHiddenParam + 24];
            val_10 = __RuntimeMethodHiddenParam + 24;
        }
        else
        {
                val_8 = 1152921512456934304;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-739847264) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = public static SLC.Social.Leagues.LeaguesFlyoutManager MonoSingleton<SLC.Social.Leagues.LeaguesFlyoutManager>::get_Instance();
            val_10 = mem[__RuntimeMethodHiddenParam + 24 + 4];
            val_10 = __RuntimeMethodHiddenParam + 24 + 4;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = public static WGFlyoutManager MonoSingleton<WGFlyoutManager>::get_Instance();
            val_10 = mem[__RuntimeMethodHiddenParam + 24 + 8];
            val_10 = __RuntimeMethodHiddenParam + 24 + 8;
        }
        
        }
    
    }
    public virtual string GetGoldenAppleNameForGame()
    {
    
    }
    public virtual string GetGoldenAppleNameForGameUpper()
    {
    
    }
    public virtual void AddSessionEndProperties(ref System.Collections.Generic.Dictionary<string, object> eventProperties)
    {
        TheLibraryLogic.TrackSessionEnd(eventProperties: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = -739450032);
    }
    public virtual bool GemsUnlocked()
    {
        if((ChapterBookLogic.GetCurrentCumulativeChapter(playerLevel:  0)) > 1)
        {
                0 = 1;
        }
        
        return true;
    }
    public virtual bool WADPetsUnlocked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1929661328) == 0)
        {
                return false;
        }
        
        return WADPetsManager.IsFeatureUnlocked();
    }
    public virtual UnityEngine.GameObject OpenPauseMenu()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return 0.gameObject;
        }
        
        return 0.gameObject;
    }
    public virtual bool SupportsGoldenMultiplierManager()
    {
        return false;
    }
    public virtual bool CanAccessLimitedTimeBundles()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return false;
        }
        
        if(Alphabet2Manager.IsAvailable == false)
        {
                return false;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public virtual bool ShouldShowLTBPopup(int levelSincePopup, int Interval)
    {
        if(levelSincePopup >= Interval)
        {
                0 = 1;
        }
        
        return true;
    }
    public virtual bool LTB_V2()
    {
        return true;
    }
    public string GetCurrentLanguage()
    {
        string val_3 = "en";
        if(this == 0)
        {
                return;
        }
        
        if(Localization.GAME_NAME == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  Localization.GAME_NAME + 40)) == true)
        {
                return;
        }
    
    }
    public virtual System.Collections.Generic.List<string> GetSupportedLanguageNames()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  1800251696);
    }
    public virtual UnityEngine.GameObject OnLeaguesEntryButtonClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                return gameObject;
        }
        
        return gameObject;
    }
    public virtual void ShowAdditionalSceneChangePopups(SceneType scene)
    {
    
    }
    public virtual string LeaguesBenefitsDescription()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return System.String.Format(format:  -738147776, arg0:  0);
        }
        
        return System.String.Format(format:  -738147776, arg0:  0);
    }
    public virtual System.Collections.Generic.List<string[]> LeagueHints()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(System.String[]).__il2cppRuntimeField_10 = "league_loading_hint_1";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Earn Golden Apples by making word streaks";
        Add(item:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "league_loading_hint_2";
        typeof(System.String[]).__il2cppRuntimeField_14 = "The top 2 clubs in a group move up in the League!";
        Add(item:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "league_loading_hint_3";
        typeof(System.String[]).__il2cppRuntimeField_14 = "The bottom 4 clubs in a group move down in the League";
        Add(item:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "league_loading_hint_4";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Increase club level to increase maximum members";
        Add(item:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "league_loading_hint_5";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Join a club to earn rewards each week!";
        Add(item:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "league_loading_hint_6";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Each season lasts for one week";
        Add(item:  477709520);
    }
    public virtual bool CanShowLeaguesJoinLeagueButton(SLC.Social.Leagues.Guild CurrentGuild)
    {
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
        if(0 == 0)
        {
                return true;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_4 = 0.MyGuild;
        var val_5 = 2621448;
        val_5 = CurrentGuild.ServerId - val_5;
        if(0 != 0)
        {
                val_5 = 1;
        }
        
        return true;
    }
    public virtual System.Collections.Generic.Dictionary<string, object> FilterSubscriptionDictionary(System.Collections.Generic.Dictionary<string, object> dic)
    {
    
    }
    public virtual decimal get_PlayerInitialCoins()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return new System.Decimal() {flags = 148, hi = App.__il2cppRuntimeField_cctor_finished};
        }
        
        return new System.Decimal() {flags = 148, hi = App.__il2cppRuntimeField_cctor_finished};
    }
    public virtual int get_PlayerInitialGems()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 264;
        }
        
        return 264;
    }
    public virtual int get_PlayerInitialGoldenCurrency()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 264;
        }
        
        return 264;
    }
    public virtual bool get_PiggyBankUsesGems()
    {
        return false;
    }
    public virtual bool get_SuperBundleUsesGems()
    {
        return false;
    }
    public virtual bool get_CanShowUnPauseInterstitial()
    {
        return true;
    }
    public virtual void AppendPurchaseTracking(ref System.Collections.Generic.Dictionary<string, object> tracking, PurchaseModel pm)
    {
    
    }
    public virtual void SetToCreditsStatViewPos(UnityEngine.RectTransform rectTransform)
    {
    
    }
    public virtual void SetToGemsStatViewPos(UnityEngine.RectTransform rectTransform)
    {
    
    }
    public virtual void SetToGoldenStatViewPos(UnityEngine.RectTransform rectTransform)
    {
    
    }
    public virtual void SetToSpinsStatViewPos(UnityEngine.RectTransform rectTransform)
    {
    
    }
    public virtual void ShowDailyBonusPopup()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public virtual string GetDailyBonusNotificationTitle()
    {
    
    }
    public virtual string GetDailyBonusNotificationMessage()
    {
    
    }
    public virtual string GetSpecialCurrencyLocalizationKey()
    {
    
    }
    public virtual string GetCoinStoreBannerText()
    {
        return Localization.Localize(key:  -1261409664, defaultValue:  -1261409552, useSingularKey:  false);
    }
    public virtual void OnLevelAwarded()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public virtual float get_WindowManagerBackgroundAlpha()
    {
        return (float)S0;
    }
    public virtual int get_PickerHintUnlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 8;
        }
        
        return 8;
    }
    public virtual int get_PickerHintTutorialLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 0;
        }
        
        return 0;
    }
    public virtual bool get_ShowV2PickerHintTutorial()
    {
        return false;
    }
    public virtual bool get_ShowV2HintTutorial()
    {
        return false;
    }
    public virtual int get_HintTutorialLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 18;
        }
        
        return 18;
    }
    public virtual bool get_SupportsFreeHints()
    {
        return true;
    }
    public virtual bool get_InNormalGameMode()
    {
        var val_8 = 0;
        if(SceneDictator.IsInGameScene() == false)
        {
                return (bool)val_8;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = 1;
        if((-2116505760) == 0)
        {
                return (bool)val_8;
        }
        
        val_8 = 0;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return (bool)val_8;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = PlayingChallenge ^ 1;
        return (bool)val_8;
    }
    public virtual bool get_SkipTutorialEligible()
    {
        return true;
    }
    public virtual void InjectGameSpecificGlobals(ref System.Collections.Generic.Dictionary<string, object> globals)
    {
    
    }
    public virtual void InjectAdditionalLevelStartTrackings(ref System.Collections.Generic.Dictionary<string, object> eventData)
    {
    
    }
    public virtual void ShowGameSpecificPopup()
    {
    
    }
    public virtual void TrackAdditionalNonCoinAwardParams(System.Collections.Generic.Dictionary<string, object> data)
    {
    
    }
    public virtual bool get_ExtraWordGameplayUpdate()
    {
        return false;
    }
    public virtual int get_WordStreakStartCount()
    {
        return 2;
    }
    public MetaGameBehavior()
    {
    
    }

}
