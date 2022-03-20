using UnityEngine;
public class MainController : MonoBehaviour
{
    // Fields
    public const string ON_BEFORE_LEVEL_START = "OnBeforeLevelStart";
    protected GameMode gameMode;
    protected bool isGameComplete;
    protected GameLevel gameLevel;
    private UGUIGenericCoinsGainedAnim coin_stat_view_anim;
    protected UnityEngine.GameObject extra_words_group;
    protected UnityEngine.UI.Text levelNameText;
    protected UnityEngine.GameObject levelNameGroup;
    protected UnityEngine.UI.Text topRightInfoText;
    protected UnityEngine.GameObject topRightInfoGroup;
    protected UnityEngine.GameObject goldenApplesGroup;
    protected UnityEngine.GameObject goldenMultiplierGroup;
    protected UnityEngine.UI.Image levelLabel_hard;
    protected UnityEngine.GameObject hintButton;
    protected ToggleEnabledByPlayerLevel howToPlayButton;
    protected EventButtonPanel eventButtonPanel;
    private float levelCompleteDelay;
    protected static WGDailyChallengeMainController _challengeInstance;
    private static MainController _mainInstance;
    public UnityEngine.Camera mainCamera;
    public UnityEngine.Events.UnityEvent onBeforeLevelComplete;
    public UnityEngine.Events.UnityEvent onLevelComplete;
    private const string prefs_tracking_key = "level_tracking";
    private int hintsUsed;
    private int extraWordsFound;
    private string wordsCompleted;
    private int shufflesUsed;
    private bool freeHintUsed;
    private int pickerHintsUsed;
    private int megarHintsUsed;
    private int trialHintsUsed;
    private int struggleHintsUsed;
    private bool struggleHintProvided;
    private const string extra_words_prefs_key = "xtra_word_levels";
    private string currentLanguage;
    private string currentLevelWord;
    private int <ExtraRequiredWordsUsed>k__BackingField;
    private bool <ExtraRequiredWordsPostPurchase>k__BackingField;
    
    // Properties
    public GameLevel GetCurrentGameLevel { get; }
    public UnityEngine.GameObject LevelNameGroup { get; }
    public EventButtonPanel EventButtonPanel { get; }
    public float GetLevelCompleteDelay { get; }
    public static MainController instance { get; }
    public bool IsChapterComplete { get; }
    public bool SpanishInfinityMode { get; }
    public bool IsLevelComplete { get; }
    public bool CompletedAllKnownLevels { get; }
    private MainController.GameModeForTracking CurrentGameModeForTracking { get; }
    private string CurrentLanguageForTracking { get; }
    public virtual int HintsUsed { get; set; }
    public virtual int HintsUsedPicker { get; set; }
    public int HintsUsedMega { get; set; }
    public int ExtraWordsFound { get; set; }
    public string WordsCompleted { get; set; }
    public int ShufflesUsed { get; set; }
    public bool FreeHintsUsed { get; set; }
    public virtual int TrialHintsUsed { get; set; }
    public int StruggleHintsUsed { get; set; }
    public bool StruggleHintProvided { set; }
    public int ExtraRequiredWordsUsed { get; set; }
    public bool ExtraRequiredWordsPostPurchase { get; set; }
    public UGUIGenericCoinsGainedAnim coinStatViewAnim { get; }
    
    // Methods
    public GameLevel get_GetCurrentGameLevel()
    {
    
    }
    public UnityEngine.GameObject get_LevelNameGroup()
    {
    
    }
    public EventButtonPanel get_EventButtonPanel()
    {
    
    }
    public float get_GetLevelCompleteDelay()
    {
        return (float)S0;
    }
    public static MainController get_instance()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_20;
        val_10 = 1152921511080275808;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge != false)
        {
                val_11 = null;
            val_11 = null;
            if(MainController.extra_words_prefs_key == 0)
        {
                object val_6 = UnityEngine.Object.FindObjectOfType<System.Object>();
            val_12 = null;
            val_12 = null;
            MainController.extra_words_prefs_key = public static WGDailyChallengeMainController UnityEngine.Object::FindObjectOfType<WGDailyChallengeMainController>();
        }
        
            val_13 = null;
            val_13 = null;
            return;
        }
        
        }
        
        val_15 = null;
        val_15 = null;
        if(MainController._mainInstance == 0)
        {
                T[] val_8 = UnityEngine.Resources.FindObjectsOfTypeAll<System.Object>();
            val_16 = 0;
        }
        
        val_20 = null;
        val_20 = null;
        val_14 = 1152921504885604356;
    }
    public void Hack_SetLevelToLastLevelOfChapter()
    {
        if(CategoryPacksManager.IsPlaying != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HACKSetPackLastLevelOfChapterProgress();
            return;
        }
        
        Player val_3 = App.Player;
        int val_4 = WADChapterManager.GetCurrentChapterLastLevel();
        if(0 == 0)
        {
            
        }
    
    }
    public bool get_IsChapterComplete()
    {
        var val_5;
        if(CategoryPacksManager.IsPlaying == false)
        {
                return WADChapterManager.ChapterComplete;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 1;
        if(IsCurrentLevelLastWithinChapter == true)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_2C) != 0)
        {
                val_5 = 1;
        }
        
        return true;
    }
    public bool get_SpanishInfinityMode()
    {
        var val_10;
        var val_11;
        var val_10 = 27750507;
        val_10 = 7875280 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        if(App.game != 1)
        {
                if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
            val_10 = null;
            val_10 = null;
            val_11 = 0;
            if(App.game != 4)
        {
                return true;
        }
        
        }
        
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        val_11 = 0;
        if((System.String.op_Equality(a:  null, b:  -2101987568)) == false)
        {
                return true;
        }
        
        GameBehavior val_4 = App.getBehavior;
        GameBehavior val_5 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            int val_7 = DefinedLevelCount;
        }
        else
        {
                WordPets.WPTDataParser val_8 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        }
        
        if(0 > MaxPredefinedLevels)
        {
                val_11 = 1;
        }
        
        return true;
    }
    public bool get_IsLevelComplete()
    {
        return (bool)this.isGameComplete;
    }
    public bool get_CompletedAllKnownLevels()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        GameBehavior val_2 = App.getBehavior;
        if((public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance()) != 0)
        {
                return FinishedContent(toCompare:  0);
        }
        
        return FinishedContent(toCompare:  0);
    }
    private MainController.GameModeForTracking get_CurrentGameModeForTracking()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED != 0)
        {
                if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.PlayingChallenge == true)
        {
                return;
        }
        
        }
        
        if(LevelChallengeHandler.InGame == true)
        {
                1 = 5;
        }
    
    }
    private string get_CurrentLanguageForTracking()
    {
        var val_2;
        var val_2 = 27748703;
        val_2 = 7877084 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(App.game != 1)
        {
                return;
        }
        
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return 0.GetCurrentLanguage();
        }
        
        return 0.GetCurrentLanguage();
    }
    private void Awake()
    {
        var val_9;
        var val_9 = 27752148;
        val_9 = 7877400 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        CPlayerPrefs._useRijndael = true;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        this.currentLanguage = 0;
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -2101400416, name:  1799422256);
        GameBehavior val_4 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if((public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance()) != 0)
        {
                return;
        }
        
            return;
        }
        
        WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_3C) != 0)
        {
                return;
        }
        
        WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        R6.ReInitialize();
    }
    private void Start()
    {
        CPlayerPrefs.Save();
        this.OnStartLogic();
    }
    public virtual void OnApplicationPause(bool pause)
    {
        CPlayerPrefs.Save();
    }
    private void OnStartLogic()
    {
        GameLevel val_48;
        var val_49;
        bool val_50;
        var val_51;
        UnityEngine.GameObject val_1 = this.levelLabel_hard.gameObject;
        this.levelLabel_hard.SetActive(value:  false);
        val_48 = 1152921511082729536;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.PlayRandomMusicTrack(type:  1);
        val_49 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(CategoryPacksManager.IsPlaying != false)
        {
                GameLevel val_7 = PlayingLevel.GetCategoryLevel(categoryPackId:  0);
            this.gameLevel = 0;
        }
        else
        {
                GameBehavior val_8 = App.getBehavior;
            val_50 = 1;
            if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_50 = IsPlayingChallengingLevels ^ 1;
        }
        
            GameLevel val_11 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  val_50);
            this.gameLevel = 0;
            string val_12 = Localization.Localize(key:  -2101083296, defaultValue:  -2101083200, useSingularKey:  false);
            GameBehavior val_13 = App.getBehavior;
            string val_14 = System.String.Format(format:  -2101083296, arg0:  13152256);
            this.SetLevelName(str:  -2101083296, isVisible:  true);
        }
        
        if(this.howToPlayButton != 0)
        {
                WordPets.WPTDataParser val_16 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if((-2101079008) != 0)
        {
                WordPets.WPTDataParser val_18 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_51 = public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_1C;
        }
        else
        {
                val_51 = 25;
        }
        
            this.howToPlayButton.SetLevelRequirement(level:  25);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
            goto label_53;
        }
        
        UnityEngine.GameObject val_21 = this.levelLabel_hard.gameObject;
        if(this.levelLabel_hard != 0)
        {
            goto label_66;
        }
        
        label_67:
        label_66:
        this.levelLabel_hard.SetActive(value:  false);
        goto label_65;
        label_53:
        GameBehavior val_22 = App.getBehavior;
        bool val_23 = this.CheckIfLevelIsHard(level:  0);
        UnityEngine.GameObject val_24 = this.levelLabel_hard.gameObject;
        if(val_23 == false)
        {
                0 = 0;
        }
        
        if(val_23 == true)
        {
                0 = 1;
        }
        
        this.levelLabel_hard.SetActive(value:  true);
        if((UnityEngine.Object.op_Implicit(exists:  this.topRightInfoGroup)) == false)
        {
            goto label_65;
        }
        
        if(this.topRightInfoGroup != 0)
        {
            goto label_66;
        }
        
        goto label_67;
        label_65:
        if((UnityEngine.Object.op_Implicit(exists:  this.goldenApplesGroup)) != false)
        {
                this.goldenApplesGroup.SetActive(value:  GoldenMultiplierManager.IsAvaialable ^ 1);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.goldenMultiplierGroup)) != false)
        {
                this.goldenMultiplierGroup.SetActive(value:  GoldenMultiplierManager.IsAvaialable);
        }
        
        this.GetLevelTrackingProgress();
        WordRegion val_31 = WordRegion.instance;
        val_49 = 1152921504614301696;
        System.Action val_32 = new System.Action(object:  Pan.tappingAllowed, method:  new IntPtr(2193926176));
        0.addOnLevelLoadCompleteAction(callback:  7454720);
        WordRegion val_33 = WordRegion.instance;
        twelvegigs.Autopilot.AutopilotManager val_34 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_35 = new System.Action(object:  -2101040096, method:  new IntPtr(2193928224));
        0.addOnLevelLoadCompleteAction(callback:  7454720);
        WordRegion val_36 = WordRegion.instance;
        twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean, System.String, LineWord, Cell> val_38 = new System.Action<System.Boolean, System.String, LineWord, Cell>(object:  -2101040096, method:  new IntPtr(2193929248));
        0.addOnPreprocessPlayerTurnAction(callback:  7614464);
        WordRegion val_39 = WordRegion.instance;
        twelvegigs.Autopilot.AutopilotManager val_40 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_41 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  -2101040096, method:  new IntPtr(2193931296));
        0.addOnValidWordSubmittedAction(callback:  7507968);
        WordRegion val_42 = WordRegion.instance;
        twelvegigs.Autopilot.AutopilotManager val_43 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_44 = new System.Action(object:  -2101040096, method:  new IntPtr(2193933344));
        0.addOnInvalidWordSubmittedAction(callback:  7454720);
        WordRegion val_45 = WordRegion.instance;
        val_48 = this.gameLevel;
        System.Action val_46 = new System.Action(object:  -2101004832, method:  typeof(MainController).__il2cppRuntimeField_E8);
    }
    protected virtual void OnWordRegionLoaded()
    {
        var val_20;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != true)
        {
                WordRegion val_3 = WordRegion.instance;
            string val_4 = 0.GetFirstIncompleteWord();
            WGGenericNotificationsManager.SendLevelAnwserNotification(nextWord:  null, QAHACK_Force:  false);
        }
        
        Pan.tappingAllowed.Load(gameLevel:  this.gameLevel);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Int32> val_6 = new System.Action<System.Int32>(object:  -2100818992, method:  new IntPtr(2194103712));
        public static WGFTUXManager MonoSingleton<WGFTUXManager>::get_Instance().__il2cppRuntimeField_14 = null;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_8 = new System.Action(object:  -2100818992, method:  new IntPtr(2194105760));
        public static WGFTUXManager MonoSingleton<WGFTUXManager>::get_Instance().__il2cppRuntimeField_18 = null;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnMainControllerLoaded();
        NotificationCenter val_10 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -2100818992, aName:  -2100860512);
        string val_11 = this.GetLevelWord();
        this.currentLevelWord = this;
        this.TrackLevelStart(levelWord:  -2100818992);
        WordPets.WPTDataParser val_12 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        TrackLevelSkipLevelStart(levelWord:  this.currentLevelWord);
        WGGenericNotificationsManager.SendEngagementNotifications(QAHACK_Force:  false);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnGameSceneInit();
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -2100856304)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnGameSceneBegan();
        }
        
        if(this.hintButton.activeInHierarchy != true)
        {
                if(WGFTUXManager.IsShowing == false)
        {
            goto label_37;
        }
        
        }
        
        if(WGFTUXManager.IsShowing == false)
        {
                return;
        }
        
        val_20 = 0;
        goto label_40;
        label_37:
        val_20 = 1;
        label_40:
        this.hintButton.SetActive(value:  true);
    }
    private void TrackLevelStart(string levelWord)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_25;
        var val_26;
        float val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        val_25 = null;
        val_25 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(CategoryPacksManager.IsPlaying != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_5 = GetPackProgress(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
            val_5 = val_5 + 1;
            Add(key:  -2100706416, value:  13152256);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Add(key:  -2100706320, value:  13152256);
            val_25 = val_25;
        }
        else
        {
                string val_7 = Player.GetLevelForTracking();
            Add(key:  -2100706208, value:  0);
        }
        
        val_26 = val_25;
        if(val_25 == 0)
        {
                val_26 = val_25;
        }
        
        Add(key:  -2100706112, value:  levelWord);
        Player val_8 = App.Player;
        var val_9 = 0 + 60;
        Add(key:  -2100706000, value:  10170368);
        WordRegion val_10 = WordRegion.instance;
        int val_11 = 0.GetTotalAcceptableWords();
        val_27 = 1152921504619999232;
        Add(key:  -2100705904, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_13 = PlayingChallenge;
        Add(key:  -2100705808, value:  8945664);
        if((this.<ExtraRequiredWordsUsed>k__BackingField) > 0)
        {
                0 = 1;
        }
        
        string val_14 = 1.ToString();
        val_28 = val_25;
        if(val_25 == 0)
        {
                val_28 = val_25;
        }
        
        Add(key:  -2100705696, value:  -2100686841);
        val_29 = val_28;
        if(val_28 == 0)
        {
                val_29 = val_25;
        }
        
        Add(key:  -2100705600, value:  13152256);
        if((this.<ExtraRequiredWordsPostPurchase>k__BackingField) != false)
        {
                if((this.<ExtraRequiredWordsUsed>k__BackingField) > 0)
        {
                val_30 = 1;
        }
        
        }
        else
        {
                val_30 = 0;
        }
        
        string val_15 = val_30.ToString();
        val_31 = val_29;
        if(val_29 == 0)
        {
                val_31 = val_25;
        }
        
        Add(key:  -2100705504, value:  -2100686841);
        Add(key:  -2100701280, value:  13152256);
        val_32 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_33 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  -2100701168)) != false)
        {
                val_27 = "Challenge Word";
            if(WGChallengeWordsManager.IsFeatureUnlocked != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
            val_32 = null;
            Add(key:  -2100700144, value:  8945664);
        }
        
        GameBehavior val_20 = App.getBehavior;
        if(0 != 0)
        {
                val_32 = 1152921511096081520;
            twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2100700048) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsCurrentLevelWithTile != false)
        {
                val_34 = 1152921504615792640;
        }
        else
        {
                val_34 = 1152921504615792640;
        }
        
            Add(key:  -2100699024, value:  8945664);
        }
        
        }
        
        GameBehavior val_25 = App.getBehavior;
        val_35 = null;
        val_35 = null;
        App.trackerManager.track(eventName:  -2100698896, data:  78753792);
    }
    protected void TrackLevelGenerationLevelStart(string levelWord)
    {
    
    }
    protected string GetLevelWord()
    {
        if(CategoryPacksManager.IsPlaying != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance()) != 0)
        {
                return GetWordFromPack(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        }
        
            return GetWordFromPack(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        }
        
        if(this.gameLevel.word != null)
        {
                return this.gameLevel.word.Replace(oldValue:  -2100450224, newValue:  1098586544);
        }
        
        return this.gameLevel.word.Replace(oldValue:  -2100450224, newValue:  1098586544);
    }
    public virtual void OnBeforeComplete()
    {
        if(this.onBeforeLevelComplete != 0)
        {
                this.onBeforeLevelComplete.Invoke();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnBeforeLevelComplete(levelsProgressed:  1);
    }
    public virtual void OnComplete()
    {
        var val_21;
        DG.Tweening.TweenCallback val_23;
        if(this.isGameComplete == true)
        {
                return;
        }
        
        this.isGameComplete = true;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        TrackLevelSkipLevelComplete(averageLevelWordCompletionTime:  null);
        this.TrackLevelComplete(levelWord:  this.currentLevelWord);
        GameplayMode val_2 = PlayingLevel.CurrentGameplayMode;
        if(0 == 4)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLevelComplete();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_6 = IsPackNewlyCompleted;
        }
        else
        {
                this.AdvanceLevelLogic();
            WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            LevelWasCompleted();
            GameBehavior val_8 = App.getBehavior;
            if(0 != 0)
        {
                Player val_9 = App.Player;
            bool val_10 = ChapterBookLogic.ShowBookComplete(playerLevel:  0);
        }
        else
        {
                bool val_11 = this.IsChapterComplete;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2100701168) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLevelComplete();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnLevelComplete(levelsProgressed:  1);
        this.onLevelComplete.Invoke();
        val_21 = null;
        val_21 = null;
        val_23 = MainController.<>c.<>9__69_0;
        if(val_23 == 0)
        {
                val_23 = null;
            val_23 = new DG.Tweening.TweenCallback(object:  MainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2194769824));
            MainController.<>c.<>9__69_0 = val_23;
        }
        
        DG.Tweening.Tween val_17 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  this.levelCompleteDelay, ignoreTimeScale:  false);
        this.levelCompleteDelay.ClearLevelTrackingProgress();
        WGGenericNotificationsManager.CancelLevelAnswerNotification();
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -2100856304)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static MysteryGiftManager MonoSingleton<MysteryGiftManager>::get_Instance().__il2cppRuntimeField_C = 1;
    }
    private void TrackLevelComplete(string levelWord)
    {
        MainController val_17;
        string val_18;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_19;
        val_17 = this;
        val_18 = levelWord;
        val_19 = null;
        val_19 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(CategoryPacksManager.IsPlaying != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CategoryPackWordBank val_9 = GetWordBank(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
            Add(key:  -2100706416, value:  13152256);
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Add(key:  -2100706320, value:  13152256);
            if(((GetPackProgress(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8)) + 1) >= Size)
        {
                0 = 1;
        }
        
            val_18 = val_18;
            Add(key:  -2100068064, value:  8945664);
            val_19 = val_19;
            val_17 = val_17;
        }
        else
        {
                string val_12 = Player.GetLevelForTracking();
            Add(key:  -2100706208, value:  0);
        }
        
        Add(key:  -2100706112, value:  val_18);
        Add(key:  -2100067936, value:  13152256);
        Add(key:  -2100067840, value:  13152256);
        Add(key:  -2100067728, value:  13152256);
        Add(key:  -2100067616, value:  8945664);
        Add(key:  -2100067504, value:  13152256);
        Add(key:  -2100063296, value:  this.wordsCompleted);
        Add(key:  -2100063184, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_14 = PlayingChallenge;
        Add(key:  -2100705808, value:  8945664);
        if(CategoryPacksManager.IsPlaying == true)
        {
                "Progression" = "Categories";
        }
        
        Add(key:  -2100062992, value:  -2100063088);
        if((this.<ExtraRequiredWordsUsed>k__BackingField) > 0)
        {
                0 = 1;
        }
        
        string val_16 = 1.ToString();
        Add(key:  -2100705696, value:  -2100050857);
        Add(key:  -2100705600, value:  13152256);
        if((this.<ExtraRequiredWordsPostPurchase>k__BackingField) != false)
        {
                if((this.<ExtraRequiredWordsUsed>k__BackingField) > 0)
        {
                0 = 1;
        }
        
        }
    
    }
    public static int GetHintsPerChapterThreshold()
    {
        var val_8;
        Player val_1 = App.Player;
        if(188 == 0)
        {
            goto label_4;
        }
        
        Player val_3 = App.Player;
        if(188 != 1)
        {
            goto label_8;
        }
        
        GameEcon val_5 = App.getGameEcon;
        val_8 = 492;
        return (int)val_8;
        label_4:
        GameEcon val_6 = App.getGameEcon;
        val_8 = 488;
        return (int)val_8;
        label_8:
        GameEcon val_7 = App.getGameEcon;
        val_8 = 496;
        return (int)val_8;
    }
    private void AdvanceLevelLogic()
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        val_19 = 1152921504892043264;
        Player val_1 = App.Player;
        if(35143896 >= 0)
        {
                Player val_2 = App.Player;
            val_20 = 2621448;
            if(val_20 != 0)
        {
                val_21 = 35143896;
        }
        else
        {
                val_20 = 132;
            val_21 = 2165608;
        }
        
            mem[132] = 2165609;
            Player val_3 = App.Player;
            2621448.Save(writePrefs:  true);
        }
        
        PlayingLevel.CompleteLevel(mode:  1, parameters:  0);
        GameBehavior val_4 = App.getBehavior;
        var val_5 = 0 + 1;
        if(this.IsChapterComplete != false)
        {
                GameEcon val_8 = App.getGameEcon;
            if(Prefs.currentChapter >= 5590599)
        {
                Player val_9 = App.Player;
            int val_10 = MainController.GetHintsPerChapterThreshold();
            Player val_11 = App.Player;
            val_22 = 2621448;
            if(val_22 != 0)
        {
                val_23 = 35143872;
        }
        else
        {
                val_22 = 84;
            val_23 = 1;
        }
        
            mem[84] = 2;
        }
        
            Player val_12 = App.Player;
            Player val_13 = App.Player;
            2621448.Save(writePrefs:  true);
            if((CPlayerPrefs.HasKey(key:  -2099830624)) != false)
        {
                CPlayerPrefs.DeleteKey(key:  -2099830624);
        }
        
        }
        
        GameBehavior val_15 = App.getBehavior;
        if(0 >= 10)
        {
                GameBehavior val_16 = App.getBehavior;
            if((-4294967290) != 0)
        {
                return;
        }
        
        }
        
        var val_20 = 27726418;
        val_20 = 7899120 + val_20;
        if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
        val_24 = null;
        val_24 = null;
        val_25 = null;
        val_25 = null;
        GameBehavior val_17 = App.getBehavior;
        val_19 = 0;
        string val_18 = val_19.ToString();
        string val_19 = Events.LEVEL_REACHED + 2144339952 + -2099818540(-2099818540);
        App.trackerManager.track(eventName:  Events.LEVEL_REACHED);
    }
    public virtual System.Collections.Generic.List<int> GetExtraWordLevels()
    {
        var val_17;
        System.Collections.Generic.List<System.Int32> val_18;
        val_17 = 1152921504892043264;
        GameEcon val_2 = App.getGameEcon;
        if(Prefs.currentChapter < 5590599)
        {
                val_18 = null;
            val_18 = new System.Collections.Generic.List<System.Int32>();
            return;
        }
        
        string val_4 = CPlayerPrefs.GetString(key:  -2099830624, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -2099830624)) == false)
        {
            goto label_8;
        }
        
        int val_6 = WADChapterManager.GetNumLevelsInCurrentChapter();
        GameEcon val_7 = App.getGameEcon;
        Player val_8 = App.Player;
        GameEcon val_9 = App.getGameEcon;
        GameEcon val_10 = App.getGameEcon;
        val_18 = null;
        val_18 = new System.Collections.Generic.List<System.Int32>();
        RandomSet val_13 = new RandomSet();
        if((UnityEngine.Mathf.Min(a:  155430912, b:  -437914887)) > val_6)
        {
                val_17 = val_6;
        }
        
        addIntRange(lowest:  1, highest:  val_6);
        if(val_6 >= 1)
        {
            goto label_19;
        }
        
        label_32:
        Sort();
        string val_14 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  80883712);
        CPlayerPrefs.SetString(key:  -2099830624, val:  80883712);
        return;
        label_8:
        object val_15 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -2099830624);
        val_18 = "xtra_word_levels";
        return;
        label_19:
        label_31:
        Add(item:  roll(unweighted:  false));
        if(1 >= val_17)
        {
            goto label_32;
        }
        
        var val_17 = 1 + 1;
        if(1 < val_6)
        {
            goto label_31;
        }
        
        goto label_32;
    }
    public virtual void OnLevelClearClosed()
    {
        GameBehavior val_1 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_3 = ShowInterstitial(context:  2);
        SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
        if(0 == 0)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
        0.UpdateMyProfileInfo(force:  false);
    }
    public void OnChapterClearClosed()
    {
        GameBehavior val_1 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_3 = ShowInterstitial(context:  2);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.PlayRandomMusicTrack(type:  1);
    }
    public void OnCategoryPackCompletedClosed()
    {
        var val_6;
        object val_1 = new System.Object();
        GameBehavior val_2 = App.getBehavior;
        typeof(MainController.<>c__DisplayClass76_0).__il2cppRuntimeField_8 = 0;
        System.Action<Result> val_3 = new System.Action<Result>(object:  278913024, method:  new IntPtr(2195586832));
        typeof(MainController.<>c__DisplayClass76_0).__il2cppRuntimeField_8 = null;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Delegate val_5 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_6 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_6 != 0)
        {
                if(val_6 == null)
        {
            goto label_12;
        }
        
        }
        
        val_6 = 0;
        label_12:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_6;
    }
    public void UpdateExtraWordProgress()
    {
        int val_2 = Prefs.extraTarget;
        val_2 = Prefs.extraProgress - val_2;
        Prefs.extraProgress = val_2;
        GameEcon val_3 = App.getGameEcon;
        GameEcon val_5 = App.getGameEcon;
        Prefs.extraTarget = System.Math.Min(val1:  28950032, val2:  1879048193 + Prefs.extraTarget);
        ExtraWord.GAMETYPE_CATEGORY_LEVELS.OnClaimed();
    }
    public void SetLevelName(string str, bool isVisible = True)
    {
        UnityEngine.UI.Text val_4 = 35629321;
        if((System.String.IsNullOrEmpty(value:  str)) != true)
        {
                val_4 = this.levelNameText;
            if(val_4 != 0)
        {
                val_4 = this.levelNameText;
        }
        
        }
        
        if(this.levelNameGroup == 0)
        {
                return;
        }
        
        this.levelNameGroup.SetActive(value:  isVisible);
    }
    private void OnLocalize()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        if((System.String.op_Equality(a:  this.currentLanguage, b:  null)) != false)
        {
                return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        string val_5 = 0.GetCurrentLanguage();
        this.currentLanguage = 0;
        MainController val_6 = MainController.instance;
        Invoke();
        GameLevel val_7 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
        Pan.tappingAllowed.Load(gameLevel:  0);
        GameBehavior val_8 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void SkipToLevel(int level)
    {
        MainController val_1 = MainController.instance;
        Invoke();
        GameBehavior val_2 = App.getBehavior;
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void SkipTutorial()
    {
    
    }
    private void SaveLevelTrackingProgress()
    {
        if(Prefs.IsCurrentLevel() == false)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        string val_3 = this.hintsUsed.ToString();
        Add(item:  this.hintsUsed);
        string val_4 = this.extraWordsFound.ToString();
        Add(item:  this.extraWordsFound);
        Add(item:  this.wordsCompleted);
        string val_5 = this.shufflesUsed.ToString();
        Add(item:  this.shufflesUsed);
        string val_6 = this.freeHintUsed.ToString();
        Add(item:  this.freeHintUsed);
        string val_7 = this.pickerHintsUsed.ToString();
        Add(item:  this.pickerHintsUsed);
        string val_8 = this.megarHintsUsed.ToString();
        Add(item:  this.megarHintsUsed);
        string val_9 = this.trialHintsUsed.ToString();
        Add(item:  this.trialHintsUsed);
        string val_10 = this.struggleHintsUsed.ToString();
        Add(item:  this.struggleHintsUsed);
        string val_11 = this.struggleHintProvided.ToString();
        Add(item:  this.struggleHintProvided);
        string val_12 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  80883712);
        UnityEngine.PlayerPrefs.SetString(key:  -2098652144, value:  80883712);
        bool val_13 = PrefsSerializationManager.SavePlayerPrefs();
    }
    protected void GetLevelTrackingProgress()
    {
        var val_25;
        var val_26;
        bool val_27;
        if(Prefs.IsCurrentLevel() == false)
        {
                return;
        }
        
        val_25 = "level_tracking";
        if((UnityEngine.PlayerPrefs.HasKey(key:  -2098652144)) != false)
        {
                string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -2098652144, defaultValue:  -2141227328);
            object val_4 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -2098652144);
            val_26 = "level_tracking";
        }
        else
        {
                val_27 = 1152921504882458624;
            if((CPlayerPrefs.HasKey(key:  -2098652144)) == false)
        {
                return;
        }
        
            System.String[] val_6 = CryptoPlayerPrefsX.GetStringArray(key:  -2098652144);
            val_26 = "level_tracking";
            CPlayerPrefs.DeleteKey(key:  -2098652144);
        }
        
        if(val_26 == 0)
        {
                return;
        }
        
        bool val_8 = System.Int32.TryParse(s:  "level_tracking".__il2cppRuntimeField_10, result: out  this.hintsUsed);
        bool val_10 = System.Int32.TryParse(s:  "level_tracking".__il2cppRuntimeField_14, result: out  this.extraWordsFound);
        this.wordsCompleted = null;
        bool val_12 = System.Int32.TryParse(s:  "level_tracking".__il2cppRuntimeField_1C, result: out  this.shufflesUsed);
        val_27 = this.freeHintUsed;
        bool val_14 = System.Boolean.TryParse(value:  "level_tracking".__il2cppRuntimeField_20, result: out  val_27);
        bool val_16 = System.Int32.TryParse(s:  "level_tracking".__il2cppRuntimeField_24, result: out  this.pickerHintsUsed);
        bool val_18 = System.Int32.TryParse(s:  "level_tracking".__il2cppRuntimeField_28, result: out  this.megarHintsUsed);
        bool val_20 = System.Int32.TryParse(s:  "level_tracking".__il2cppRuntimeField_2C, result: out  this.trialHintsUsed);
        bool val_22 = System.Int32.TryParse(s:  "level_tracking".__il2cppRuntimeField_30, result: out  this.struggleHintsUsed);
        bool val_24 = System.Boolean.TryParse(value:  "level_tracking".__il2cppRuntimeField_34, result: out  this.struggleHintProvided);
    }
    private void ClearLevelTrackingProgress()
    {
        if(Prefs.IsCurrentLevel() == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  -2098652144);
        if((CPlayerPrefs.HasKey(key:  -2098652144)) == false)
        {
                return;
        }
        
        CPlayerPrefs.DeleteKey(key:  R4);
    }
    private bool CheckIfLevelIsHard(int level)
    {
        GameEcon val_1 = App.getGameEcon;
        if(35671296 != 0)
        {
                return 35671296.Contains(item:  level);
        }
        
        return 35671296.Contains(item:  level);
    }
    public virtual int get_HintsUsed()
    {
        return (int)this.hintsUsed;
    }
    public virtual void set_HintsUsed(int value)
    {
        var val_6;
        var val_7;
        int val_8;
        val_6 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DailyChallengeGameLevel val_4 = CurrentLevel;
            if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) != 0)
        {
                val_7 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            val_8 = this.hintsUsed;
        }
        else
        {
                val_7 = 56;
            val_8 = this.hintsUsed;
            val_6 = 52;
        }
        
            int val_5 = value - val_8;
            val_5 = val_5 + val_6;
            mem[56] = val_5;
        }
        
        this.hintsUsed = value;
        this.SaveLevelTrackingProgress();
    }
    public virtual int get_HintsUsedPicker()
    {
        return (int)this.pickerHintsUsed;
    }
    public virtual void set_HintsUsedPicker(int value)
    {
        var val_7;
        var val_8;
        val_7 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DailyChallengeGameLevel val_4 = CurrentLevel;
            val_8 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            val_7 = this;
            public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_3C = ((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_3C + value) - this);
        }
        
        this.pickerHintsUsed = value;
        this.SaveLevelTrackingProgress();
    }
    public int get_HintsUsedMega()
    {
        return (int)this.megarHintsUsed;
    }
    public void set_HintsUsedMega(int value)
    {
        this.megarHintsUsed = value;
        this.SaveLevelTrackingProgress();
    }
    public int get_ExtraWordsFound()
    {
        return (int)this.extraWordsFound;
    }
    public void set_ExtraWordsFound(int value)
    {
        this.extraWordsFound = value;
        this.SaveLevelTrackingProgress();
    }
    public string get_WordsCompleted()
    {
    
    }
    public void set_WordsCompleted(string value)
    {
        this.wordsCompleted = value;
        this.SaveLevelTrackingProgress();
    }
    public int get_ShufflesUsed()
    {
        return (int)this.shufflesUsed;
    }
    public void set_ShufflesUsed(int value)
    {
        this.shufflesUsed = value;
        this.SaveLevelTrackingProgress();
    }
    public bool get_FreeHintsUsed()
    {
        return (bool)this.freeHintUsed;
    }
    public void set_FreeHintsUsed(bool value)
    {
        this.freeHintUsed = value;
        this.SaveLevelTrackingProgress();
        Player val_1 = App.Player;
        2621448.Save(writePrefs:  true);
    }
    public virtual int get_TrialHintsUsed()
    {
        return (int)this.trialHintsUsed;
    }
    public virtual void set_TrialHintsUsed(int value)
    {
        this.trialHintsUsed = value;
        this.SaveLevelTrackingProgress();
    }
    public int get_StruggleHintsUsed()
    {
        return (int)this.struggleHintsUsed;
    }
    public void set_StruggleHintsUsed(int value)
    {
        this.struggleHintsUsed = value;
        this.SaveLevelTrackingProgress();
    }
    public void set_StruggleHintProvided(bool value)
    {
        this.struggleHintProvided = value;
        this.SaveLevelTrackingProgress();
    }
    public int get_ExtraRequiredWordsUsed()
    {
        return (int)this.<ExtraRequiredWordsUsed>k__BackingField;
    }
    public void set_ExtraRequiredWordsUsed(int value)
    {
        this.<ExtraRequiredWordsUsed>k__BackingField = value;
    }
    public bool get_ExtraRequiredWordsPostPurchase()
    {
        return (bool)this.<ExtraRequiredWordsPostPurchase>k__BackingField;
    }
    public void set_ExtraRequiredWordsPostPurchase(bool value)
    {
        this.<ExtraRequiredWordsPostPurchase>k__BackingField = value;
    }
    public UGUIGenericCoinsGainedAnim get_coinStatViewAnim()
    {
    
    }
    public MainController()
    {
        this.levelCompleteDelay = 1.75f;
        this.onBeforeLevelComplete = new UnityEngine.Events.UnityEvent();
        this.onLevelComplete = new UnityEngine.Events.UnityEvent();
        this.wordsCompleted = "|";
        this.currentLevelWord = "";
    }
    private static MainController()
    {
    
    }

}
