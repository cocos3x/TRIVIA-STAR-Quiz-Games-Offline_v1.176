using UnityEngine;
public class WUTMetaGameBehavior : MetaGameBehavior
{
    // Properties
    public override System.Collections.Generic.Dictionary<string, System.Type> EventHandlerTypeLookup { get; }
    public override bool supportsEvents { get; }
    public override bool supportAdsControlV2 { get; }
    public override bool supportAdsControl { get; }
    public override bool supportsFriendInviter { get; }
    public override bool supportsExtraWordsList { get; }
    public override bool supportsChallengeFLyout { get; }
    public override bool supportsDifficultySetting { get; }
    public override bool supportsCategoryLevelPacks { get; }
    public override bool supportsFeatureMenu { get; }
    public override bool supportsNotificationLifecylce { get; }
    public override bool supportsPets { get; }
    public override bool supportsRestoreProgression { get; }
    public override bool supportsLocalization { get; }
    public override bool supportsDailyChallengeTutorial { get; }
    public override bool supportsDiceRolls { get; }
    public override bool supportsTournaments { get; }
    public override int HintTutorialLevel { get; }
    public override int PickerHintTutorialLevel { get; }
    public override bool ShowV2PickerHintTutorial { get; }
    public override bool ShowV2HintTutorial { get; }
    public override bool SkipTutorialEligible { get; }
    public override int FTUXLevel { get; }
    public override bool SupportsFreeHints { get; }
    
    // Methods
    public override System.Collections.Generic.Dictionary<string, System.Type> get_EventHandlerTypeLookup()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(354152448)});
        Add(key:  -1648524352, value:  354152448);
    }
    public override bool AdsAllowedByScene()
    {
        return false;
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
    public override string GetLevelNameForTracking()
    {
        var val_12;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) != 0)
        {
                return CurrentMinigameName;
        }
        
            return CurrentMinigameName;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) != 0)
        {
                return GetLevelForTracking();
        }
        
            return GetLevelForTracking();
        }
        
        GameLevel val_7 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
        if(0 != 0)
        {
                val_12 = 0;
            GameLevel val_8 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
        }
        else
        {
                WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Player val_10 = App.Player;
            val_12 = public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance();
            GameLevel val_11 = GetGameLevel(playerLevel:  0);
        }
        
        if(val_12 != 0)
        {
                return;
        }
    
    }
    public override string GetLevelForTracking()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) == 0)
        {
            goto label_9;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SLC.Minigames.MinigameLevelRank val_4 = GetCurrentRank;
        if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) == 0)
        {
            goto label_9;
        }
        
        SLC.Minigames.MinigameLevelRank val_5 = GetCurrentRank;
        if((System.String.IsNullOrEmpty(value:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C)) == false)
        {
            goto label_12;
        }
        
        label_9:
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) != 0)
        {
                return GetStageForTracking();
        }
        
            return GetStageForTracking();
        }
        
        }
        
        int val_12 = Prefs.currentChapter;
        int val_13 = Prefs.currentLevel;
        val_13 = val_13 + 1;
        string val_14 = System.String.Format(format:  -1655001648, arg0:  13152256, arg1:  13152256);
        return;
        label_12:
        SLC.Minigames.MinigameLevelRank val_15 = GetCurrentRank;
        SLC.Minigames.MinigameLevelRank val_16 = GetCurrentRank;
        string val_17 = ToString();
        return System.String.Format(format:  -1655001648, arg0:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_1C, arg1:  -1745297768);
    }
    public override bool DailyChallengeSupported()
    {
        return true;
    }
    public override bool StoryModeSupported()
    {
        return true;
    }
    public override void OnClickHome()
    {
        var val_6;
        FeatureAccessPoints val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                var val_6 = 29507911;
            val_6 = 6117880 + val_6;
            if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
            val_6 = null;
            val_7 = 2;
        }
        else
        {
                var val_7 = 29507831;
            val_7 = 6117960 + val_7;
            if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
            val_6 = null;
            val_7 = 70;
        }
        
        val_6 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = val_7;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CheckHomeClick();
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PlayingChallenge = false;
        this.OnClickHome();
    }
    public override void SaveAllLevelsForCurrentGame(System.Collections.Generic.List<object> response)
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        SaveWorldData(data:  response);
    }
    public override SceneType getActiveSceneType()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_2 = val_1.m_Handle.name;
        SceneType val_3 = this.GetSceneTypeFromSceneName(sceneName:  -695502068);
    }
    public override string GetTitleFormat()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(static_value_0028000F == 1)
        {
                "{0}" = "•{0}•";
        }
    
    }
    public override void SaveLevelsFromChaptersCurrentGame(System.Collections.Generic.List<object> chapters, string language = "")
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        SaveLevelsFromChaptersDict(fromLoadedData:  chapters, language:  language);
    }
    public override bool get_supportsEvents()
    {
        return true;
    }
    public override bool get_supportAdsControlV2()
    {
        return true;
    }
    public override bool get_supportAdsControl()
    {
        return true;
    }
    public override bool get_supportsFriendInviter()
    {
        return true;
    }
    public override bool get_supportsExtraWordsList()
    {
        return true;
    }
    public override bool get_supportsChallengeFLyout()
    {
        return true;
    }
    public override string GetGoldenAppleNameForGame()
    {
        return Localization.Localize(key:  -702174016, defaultValue:  -702174096, useSingularKey:  false);
    }
    public override string GetGoldenAppleNameForGameUpper()
    {
        return Localization.Localize(key:  -702061856, defaultValue:  -702061936, useSingularKey:  false);
    }
    public override bool get_supportsDifficultySetting()
    {
        return true;
    }
    public override bool get_supportsCategoryLevelPacks()
    {
        return false;
    }
    public override bool get_supportsFeatureMenu()
    {
        return true;
    }
    public override bool get_supportsNotificationLifecylce()
    {
        return true;
    }
    public override bool get_supportsPets()
    {
        return true;
    }
    public override bool get_supportsRestoreProgression()
    {
        return true;
    }
    public override bool get_supportsLocalization()
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
    public override bool CanAccessLimitedTimeBundles()
    {
        return true;
    }
    public override string GetSpecialCurrencyLocalizationKey()
    {
    
    }
    public override bool get_supportsDailyChallengeTutorial()
    {
        return true;
    }
    public override bool get_supportsDiceRolls()
    {
        SnakesAndLaddersEventHandler val_1 = SnakesAndLaddersEventHandler.<Instance>k__BackingField;
        if(val_1 == 0)
        {
                return false;
        }
        
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public override bool get_supportsTournaments()
    {
        return true;
    }
    public override string GetSceneNameFromSceneType(SceneType sceneType)
    {
        if(sceneType != 12)
        {
                return this.GetSceneNameFromSceneType(sceneType:  sceneType);
        }
    
    }
    public override int get_HintTutorialLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 40;
        }
        
        return 40;
    }
    public override int get_PickerHintTutorialLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 0;
        }
        
        return 0;
    }
    public override bool get_ShowV2PickerHintTutorial()
    {
        return true;
    }
    public override bool get_ShowV2HintTutorial()
    {
        return true;
    }
    public override bool get_SkipTutorialEligible()
    {
        return false;
    }
    public override int get_FTUXLevel()
    {
        return 1;
    }
    public override bool get_SupportsFreeHints()
    {
        return false;
    }
    public WUTMetaGameBehavior()
    {
    
    }

}
