using UnityEngine;
public class WFOMetaGameBehavior : MetaGameBehavior
{
    // Properties
    public override System.Collections.Generic.Dictionary<string, System.Type> EventHandlerTypeLookup { get; }
    public override int PlayerStructureLevel { get; }
    public override int HighestAvailableUniqueStructureLevel { get; }
    public override int PlayerInitialGoldenCurrency { get; }
    public override int FTUXLevel { get; }
    public override int DailyChallengeVersion { get; }
    public override bool supportAdsControlV2 { get; }
    public override bool supportsEvents { get; }
    public override bool supportAdsControl { get; }
    public override bool supportsFriendInviter { get; }
    public override bool supportsExtraWordsList { get; }
    public override bool supportsChallengeFLyout { get; }
    public override bool supportsCategoryLevelPacks { get; }
    public override bool supportsFeatureMenu { get; }
    public override bool supportsNotificationLifecylce { get; }
    public override bool supportsPets { get; }
    public override bool supportsLocalization { get; }
    public override bool supportsAlphabet { get; }
    public override bool supportsWordIQ { get; }
    public override bool supportsLibrary { get; }
    public override bool supportExtraRequiredWords { get; }
    public override bool isEventsDisplayable { get; }
    public override int PickerHintTutorialLevel { get; }
    public override bool ShowV2PickerHintTutorial { get; }
    public override bool ShowV2HintTutorial { get; }
    public override int HintTutorialLevel { get; }
    public override int PickerHintUnlockLevel { get; }
    public override bool SupportsFreeHints { get; }
    public override bool SkipTutorialEligible { get; }
    public override bool ExtraWordGameplayUpdate { get; }
    
    // Methods
    public override System.Collections.Generic.Dictionary<string, System.Type> get_EventHandlerTypeLookup()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(326090752)});
        Add(key:  -1266462304, value:  326090752);
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(321351680)});
        Add(key:  -1280644912, value:  321351680);
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(336687104)});
        Add(key:  -1298909328, value:  336687104);
    }
    public override int get_PlayerStructureLevel()
    {
        WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
        if(0 != 0)
        {
                return 19;
        }
        
        return 19;
    }
    public override int get_HighestAvailableUniqueStructureLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return (int)public static WordForest.WFOForestManager MonoSingleton<WordForest.WFOForestManager>::get_Instance().__il2cppRuntimeField_18 + 12;
    }
    public override int get_PlayerInitialGoldenCurrency()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static WordForest.WFOGameEcon App::GetGameSepeciticEcon<WordForest.WFOGameEcon>()) != 0)
        {
                return (int)mem[1152921512491413400];
        }
        
        return (int)mem[1152921512491413400];
    }
    public override int get_FTUXLevel()
    {
        return 1;
    }
    public override int get_DailyChallengeVersion()
    {
        return 7;
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
        var val_15;
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
        
        if(CategoryPacksManager.IsPlaying != false)
        {
                val_15 = 0;
            GameLevel val_9 = PlayingLevel.GetCategoryLevel(categoryPackId:  0);
        }
        else
        {
                GameLevel val_10 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
            if(0 != 0)
        {
                val_15 = 0;
            GameLevel val_11 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
        }
        else
        {
                WordPets.WPTDataParser val_12 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Player val_13 = App.Player;
            val_15 = public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance();
            GameLevel val_14 = GetGameLevel(playerLevel:  0);
        }
        
        }
        
        if(val_15 != 0)
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
    public override bool DailyChallengeRevamped()
    {
        return true;
    }
    public override bool StoryModeSupported()
    {
        return false;
    }
    public override void LoadScene(SceneType sceneToLoad, bool immediate = False)
    {
        var val_2;
        if(sceneToLoad == 5)
        {
                if(WordForest.WFOForestManager.IsFeatureUnlocked == false)
        {
            goto label_1;
        }
        
        }
        
        val_2 = sceneToLoad;
        goto label_2;
        label_1:
        val_2 = 2;
        label_2:
        this.LoadScene(sceneToLoad:  2, immediate:  immediate);
    }
    public override void OnClickHome()
    {
        var val_5;
        FeatureAccessPoints val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                var val_5 = 27242075;
            val_5 = 8383716 + val_5;
            if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 2;
        }
        else
        {
                var val_6 = 27241995;
            val_6 = 8383796 + val_6;
            if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 70;
        }
        
        val_5 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = val_6;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PlayingChallenge = false;
        this.OnClickHome();
    }
    public override void SaveAllLevelsForCurrentGame(System.Collections.Generic.List<object> response)
    {
    
    }
    public override SceneType getActiveSceneType()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_2 = val_1.m_Handle.name;
    }
    public override bool overlaySceneShowing()
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_2 = 27245265;
        val_2 = 8384284 + val_2;
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
        if(SceneDictator.lastOverlayedScene == 2)
        {
                return true;
        }
        
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        SceneType val_1 = SceneDictator.lastOverlayedScene - 5;
        if(SceneDictator.__il2cppRuntimeField_cctor_finished != 0)
        {
                val_3 = 1;
        }
        
        return true;
    }
    public override string GetTitleFormat()
    {
        ThemesHandler val_1 = App.ThemesHandler;
        if(static_value_0028000F == 1)
        {
                "{0}" = "•{0}•";
        }
    
    }
    public override string GetSceneNameFromSceneType(SceneType sceneType)
    {
        var val_3;
        var val_4;
        SceneType val_1 = sceneType - 1;
        if(val_1 <= 10)
        {
                var val_2 = 8385036 + (8385036 + ((sceneType - 1)) << 2);
            if(val_1 == 10)
        {
                8385036 + ((sceneType - 1)) << 2 = (8385036 + ((sceneType - 1)) << 2) & ((IP) >> 32);
            8385036 + ((sceneType - 1)) << 2 = (8385036 + ((sceneType - 1)) << 2) & ((R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32));
            8385036 + ((sceneType - 1)) << 2 = (8385036 + ((sceneType - 1)) << 2) & (sceneType >> 32);
            8385036 + ((sceneType - 1)) << 2 = (8385036 + ((sceneType - 1)) << 2) & ((8385036 + ((sceneType - 1)) << 2) >> (8385036 + ((sceneType - 1)) << 2));
            8385036 + ((sceneType - 1)) << 2 = (8385036 + ((sceneType - 1)) << 2) & ((IP) >> 1);
            mem2[0] = (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8;
            ((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) = (((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8)) & ((((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8)) >> (((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8)));
            ((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) = (((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8)) & ((((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8)) >> (((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8)));
            ((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) = (((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8)) & ((((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8)) >> (((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8)));
            ((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) = (((((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) & (((int)(((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8) >> (((((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8) >> (8385036 + ((sceneType - 1)) << 2 & (IP) >> 32)) & ((int)sceneType) >> 32) & ((int)(((8385036 + ((sceneType - 1)) << 2 & (IP) >> 32) & (R8 + R8)) & (sceneType >> 1);
        }
        
            val_3 = "LaunchScene";
            return;
        }
        
        val_4 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    }
    public override System.Collections.Generic.List<string[]> LeagueHints()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(System.String[]).__il2cppRuntimeField_10 = "WFOleague_loading_hint_1";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Earn Acorns by making word streaks";
        Add(item:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "WFOleague_loading_hint_2";
        typeof(System.String[]).__il2cppRuntimeField_14 = "The top 2 clubs in a group move up in the League!";
        Add(item:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "WFOleague_loading_hint_3";
        typeof(System.String[]).__il2cppRuntimeField_14 = "The bottom 4 clubs in a group move down in the League";
        Add(item:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "WFOleague_loading_hint_4";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Increase club level to increase maximum members";
        Add(item:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "WFOleague_loading_hint_5";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Join a club to earn rewards each week!";
        Add(item:  477709520);
        typeof(System.String[]).__il2cppRuntimeField_10 = "WFOleague_loading_hint_6";
        typeof(System.String[]).__il2cppRuntimeField_14 = "Each season lasts for one week";
        Add(item:  477709520);
    }
    public override SceneType GetSceneTypeFromSceneName(string sceneName)
    {
        if((sceneName.Contains(value:  -703443968)) == true)
        {
                return;
        }
        
        if((sceneName.Contains(value:  -729381616)) == false)
        {
                return this.GetSceneTypeFromSceneName(sceneName:  sceneName);
        }
    
    }
    public override bool ArePopupsAllowedForSceneType(SceneType type)
    {
        if(type == 2)
        {
                this = 1;
            return (bool)this;
        }
        
        SceneType val_1 = type | 4;
        val_1 = val_1 - 5;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public override void SaveLevelsFromChaptersCurrentGame(System.Collections.Generic.List<object> chapters, string language = "")
    {
    
    }
    public override bool get_supportAdsControlV2()
    {
        return true;
    }
    public override bool get_supportsEvents()
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
        return false;
    }
    public override UnityEngine.GameObject OpenPauseMenu()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 2)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CloseCurrentWindow();
            GameBehavior val_3 = App.getBehavior;
            if(0 != 0)
        {
                return;
        }
        
            return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 != 0)
        {
                return 0.gameObject;
        }
        
        return 0.gameObject;
    }
    public override bool get_supportsLocalization()
    {
        return true;
    }
    public override System.Collections.Generic.List<string> GetSupportedLanguageNames()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                Add(item:  1800251696);
        }
        else
        {
                Add(item:  1800251696);
        }
        
        Add(item:  -2101987568);
    }
    public override bool get_supportsAlphabet()
    {
        return false;
    }
    public override bool get_supportsWordIQ()
    {
        return false;
    }
    public override bool get_supportsLibrary()
    {
        return false;
    }
    public override bool get_supportExtraRequiredWords()
    {
        return true;
    }
    public override bool get_isEventsDisplayable()
    {
        WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
        GameEcon val_2 = App.getGameEcon;
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  19, knobValue:  983057);
    }
    public override bool GemsUnlocked()
    {
        return false;
    }
    public override void AppendUserProperties(string eventName, ref System.Collections.Generic.Dictionary<string, object> userProperties)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1425082880) == 0)
        {
                return;
        }
        
        int val_3 = CurrentForestLevel;
        string val_5 = CurrentForestGrowth.ToString(format:  -725984464);
        string val_6 = System.String.Format(format:  -1671354896, arg0:  13152256, arg1:  -700473576);
        if((System.Int32.TryParse(s:  -1671354896, result: out  int val_7 = -700473572)) == false)
        {
                return;
        }
        
        userProperties.Add(key:  -700485648, value:  13152256);
    }
    public override void InjectAdditionalLevelStartTrackings(ref System.Collections.Generic.Dictionary<string, object> eventData)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-814084048) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(GetChestCount > 0)
        {
                1152921504901095424 = 1;
        }
        
        eventData.Add(key:  -700361408, value:  8945664);
    }
    public override string GetSpecialCurrencyLocalizationKey()
    {
    
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
    public override int get_HintTutorialLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 40;
        }
        
        return 40;
    }
    public override int get_PickerHintUnlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 1507361;
        }
        
        return 1507361;
    }
    public override bool get_SupportsFreeHints()
    {
        return false;
    }
    public override bool get_SkipTutorialEligible()
    {
        return false;
    }
    public override void InjectGameSpecificGlobals(ref System.Collections.Generic.Dictionary<string, object> globals)
    {
        WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
        bool val_2 = MonoExtensions.IsBitSet(value:  132, bit:  10);
        globals.Add(key:  -699345168, value:  8945664);
        WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
        bool val_4 = MonoExtensions.IsBitSet(value:  132, bit:  9);
        globals.Add(key:  -699345056, value:  8945664);
        WordForest.WFOPlayer val_5 = WordForest.WFOPlayer.Instance;
        bool val_6 = MonoExtensions.IsBitSet(value:  132, bit:  8);
        globals.Add(key:  -699344944, value:  8945664);
    }
    public override bool get_ExtraWordGameplayUpdate()
    {
        return false;
    }
    public WFOMetaGameBehavior()
    {
    
    }

}
