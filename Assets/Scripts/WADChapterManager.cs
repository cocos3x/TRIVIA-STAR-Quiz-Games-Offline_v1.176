using UnityEngine;
public class WADChapterManager : MonoSingletonSelfGenerating<WADChapterManager>
{
    // Fields
    public const int LEVEL_SKIP_LEVEL_LIMIT = 300;
    private const string PP_INVALID_LEVELS = "skipped_levels";
    private const string PP_SKIP_CURRENT_LEVEL_INFO = "skip_current_level_info";
    public System.Action OnLevelCompleted;
    protected string levelWord;
    private System.DateTime levelStartStamp;
    private bool levelCompletedInLessThanAverage;
    private int levelCompletionInMillis;
    private string debugFetchFromLevelSkipStatus;
    private System.Collections.Generic.List<SkippedLevel> levelsToSkip;
    private System.Collections.Generic.Dictionary<string, object> currentSkipLevelStatus;
    private const string pref_pl_vars_key = "wadwut_pl_vars";
    public const string pref_played_words_key = "wadwut_pw_vars";
    public const string pref_chapter_levels_curve_v = "pp_chapter_level_curve_v";
    private const int LevelCurveVersion = 3;
    private System.Collections.Generic.List<int> plv_chapterWordLengths;
    private System.Collections.Generic.List<string> plv_playedWords;
    
    // Properties
    public int MaxPredefinedLevels { get; }
    public static bool ChapterComplete { get; }
    public System.Collections.Generic.List<SkippedLevel> DebugLevelsToSkip { get; }
    public System.Collections.Generic.Dictionary<string, object> DebugCurrentLevelSkipStatus { get; }
    public string DebugFetchFromLevelSkipStatus { get; set; }
    public bool LevelCompletedInLessThanAverage { get; }
    private string CurrentLaguage { get; }
    private int BeginDynamicLevels { get; }
    private System.Collections.Generic.List<SkippedLevel> LevelsToSkip { get; set; }
    private System.Collections.Generic.Dictionary<string, object> CurrentLevelSkipStatus { get; set; }
    
    // Methods
    public int get_MaxPredefinedLevels()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if((public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance()) != 0)
        {
                return DefinedLevelCount;
        }
        
            return DefinedLevelCount;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<GameLevel> val_4 = CurrentLevelCurveGameLevels;
        if((public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance()) != 0)
        {
                return (int)public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_C;
        }
        
        return (int)public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_C;
    }
    public static bool get_ChapterComplete()
    {
        Player val_1 = App.Player;
        return ChapterBookLogic.ShowChapterComplete(playerLevel:  0);
    }
    public System.Collections.Generic.List<SkippedLevel> get_DebugLevelsToSkip()
    {
        return this.LevelsToSkip;
    }
    public System.Collections.Generic.Dictionary<string, object> get_DebugCurrentLevelSkipStatus()
    {
        return this.CurrentLevelSkipStatus;
    }
    public string get_DebugFetchFromLevelSkipStatus()
    {
    
    }
    public void set_DebugFetchFromLevelSkipStatus(string value)
    {
        this.debugFetchFromLevelSkipStatus = value;
    }
    public bool get_LevelCompletedInLessThanAverage()
    {
        return (bool)this.levelCompletedInLessThanAverage;
    }
    private string get_CurrentLaguage()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return 0.GetCurrentLanguage();
        }
        
        return 0.GetCurrentLanguage();
    }
    private int get_BeginDynamicLevels()
    {
        return System.Math.Max(val1:  3, val2:  this.MaxPredefinedLevels);
    }
    private System.Collections.Generic.List<SkippedLevel> get_LevelsToSkip()
    {
        string val_6;
        var val_9;
        string val_10;
        var val_11;
        if(this.levelsToSkip != 0)
        {
                return;
        }
        
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  131304960, defaultValue:  -2141227328);
        object val_2 = MiniJSON.Json.Deserialize(json:  131304960);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.levelsToSkip = null;
        if("skipped_levels" != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        if("skipped_levels" == 0)
        {
            goto label_5;
        }
        
        label_17:
        label_5:
        val_9 = 0;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_16:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        val_10 = 0;
        if(val_6 != 0)
        {
                if(val_6 != null)
        {
            
        }
        else
        {
                val_10 = val_6;
        }
        
        }
        
        SkippedLevel val_7 = new SkippedLevel();
        object val_8 = MiniJSON.Json.Deserialize(json:  val_10);
        val_11 = 0;
        if(val_10 != 0)
        {
                if(((val_6 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_10 = 0;
        }
        
            val_11 = val_10;
        }
        
        Decode(encoded:  0);
        this.levelsToSkip.Add(item:  279924736);
        goto label_16;
        label_8:
        Dispose();
        return;
        label_4:
        goto label_17;
    }
    private void set_LevelsToSkip(System.Collections.Generic.List<SkippedLevel> value)
    {
        this.levelsToSkip = value;
        string val_1 = MiniJSON.Json.Serialize(obj:  value);
        UnityEngine.PlayerPrefs.SetString(key:  131304960, value:  value);
    }
    private System.Collections.Generic.Dictionary<string, object> get_CurrentLevelSkipStatus()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = this.currentSkipLevelStatus;
        if(val_3 != 0)
        {
                return;
        }
        
        val_3 = 0;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  131563872, defaultValue:  -2040381152);
        object val_2 = MiniJSON.Json.Deserialize(json:  131563872);
        if("skip_current_level_info" != 0)
        {
                if(((1152921504685600768 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                "skip_current_level_info" = 0;
        }
        
            val_3 = "skip_current_level_info";
        }
        
        this.currentSkipLevelStatus = val_3;
    }
    private void set_CurrentLevelSkipStatus(System.Collections.Generic.Dictionary<string, object> value)
    {
        this.currentSkipLevelStatus = value;
        string val_1 = MiniJSON.Json.Serialize(obj:  value);
        UnityEngine.PlayerPrefs.SetString(key:  131563872, value:  value);
    }
    public static int GetCurrentChapter()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return WADChapterManager.GetChapter(level:  0);
        }
        
        return WADChapterManager.GetChapter(level:  0);
    }
    public static int GetChapter(int level)
    {
        return ChapterBookLogic.GetCurrentCumulativeChapter(playerLevel:  level);
    }
    public static int GetChapterWithinBook(int level)
    {
        return ChapterBookLogic.GetCurrentChapter(playerLevel:  level);
    }
    public static int GetNumLevelsInCurrentChapter()
    {
        Player val_1 = App.Player;
        return ChapterBookLogic.GetLevelsPerChapter(playerLevel:  0);
    }
    public static int GetCurrentLevelWithinChapter(int level = -1)
    {
        Player val_1 = App.Player;
        return ChapterBookLogic.GetLevelWithinChapter(playerLevel:  0);
    }
    public static int GetCurrentChapterFirstLevel()
    {
        Player val_1 = App.Player;
        return ChapterBookLogic.GetFirstLevelOfChapter(playerLevel:  0);
    }
    public static int GetCurrentChapterLastLevel()
    {
        Player val_1 = App.Player;
        return ChapterBookLogic.GetLastLevelOfChapter(playerLevel:  0);
    }
    public bool FinishedContent(int toCompare)
    {
        if(this.MaxPredefinedLevels < toCompare)
        {
                0 = 1;
        }
        
        return true;
    }
    public GameLevel GetGameLevelForPlayerLevelFromChapter(int playerLevel = -1, bool checkLevelSkip = False)
    {
        var val_75;
        int val_76;
        float val_77;
        var val_78;
        var val_79;
        var val_80;
        int val_81;
        var val_82;
        var val_83;
        System.Predicate<GameLevel> val_85;
        var val_86;
        System.Func<GameLevel, System.Single> val_88;
        var val_89;
        var val_90;
        var val_91;
        val_75 = playerLevel;
        int val_77 = WADChapterManager.GetCurrentLevelWithinChapter(level:  WADChapterManager.GetCurrentChapter());
        if(val_75 <= 1)
        {
                Player val_3 = App.Player;
            val_75 = 0;
        }
        
        int val_4 = this.BeginDynamicLevels;
        if(val_75 <= val_4)
        {
            goto label_5;
        }
        
        DynamicLevelBuildParams val_5 = new DynamicLevelBuildParams();
        val_77 = val_77 - 1;
        if(val_5 <= val_77)
        {
                var val_78 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_78 = val_78 + (val_77 << 2);
        if(val_5 == 0)
        {
            goto label_8;
        }
        
        val_76 = val_5;
        typeof(DynamicLevelBuildParams).__il2cppRuntimeField_20 = (0 + ((val_2 - 1)) << 2) + 16;
        goto label_9;
        label_5:
        int val_6 = val_4.MaxPredefinedLevels;
        if(val_75 > val_6)
        {
            goto label_10;
        }
        
        string val_7 = val_6.CurrentLaguage;
        val_77 = 0;
        System.Text.StringBuilder val_9 = new System.Text.StringBuilder();
        if(val_75 < 300)
        {
                0 = 1;
        }
        
        if(val_75 > 5)
        {
                0 = 1;
        }
        
        if((val_6.Equals(value:  1800251696)) != false)
        {
                var val_10 = val_75 - 6;
            val_10 = val_10 >> 1;
            if(val_10 <= 146)
        {
                GameEcon val_11 = App.getGameEcon;
            val_77 = 1.471363E-43f;
        }
        
        }
        
        System.Text.StringBuilder val_12 = AppendFormat(format:  132700384, arg0:  8945664);
        System.Text.StringBuilder val_13 = AppendFormat(format:  132700512, arg0:  13152256, arg1:  13152256, arg2:  null);
        System.Text.StringBuilder val_14 = AppendFormat(format:  132700672, arg0:  8945664);
        val_78 = 1152921504892043264;
        Player val_15 = App.Player;
        GameEcon val_16 = App.getGameEcon;
        System.Text.StringBuilder val_17 = AppendFormat(format:  132700800, arg0:  33449456, arg1:  8945664);
        if(val_9 == 0)
        {
            goto label_25;
        }
        
        System.Text.StringBuilder val_18 = AppendFormat(format:  132700944, arg0:  8945664);
        goto label_26;
        label_8:
        val_76 = 32;
        mem[32] = (0 + ((val_2 - 1)) << 2) + 16;
        label_9:
        typeof(DynamicLevelBuildParams).__il2cppRuntimeField_8 = 0;
        GameBehavior val_19 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_20 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_79 = public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance();
            GameLevel val_21 = BuildDynamicLevel(wordLength:  val_76, wordCount:  3, maxWordCount:  0, dailyChallenge:  false);
        }
        else
        {
                WordPets.WPTDataParser val_22 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_79 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance();
            GameLevel val_23 = BuildDynamicLevel(param:  384184320);
        }
        
        string val_24 = 0.ToString();
        if(val_79 != 0)
        {
            goto label_39;
        }
        
        goto label_40;
        label_25:
        System.Text.StringBuilder val_25 = AppendFormat(format:  132700944, arg0:  8945664);
        label_26:
        mem[1152921513329521128] = val_9;
        if(val_77 != 0)
        {
                if(mem[1152921513329521120] == true)
        {
                val_80 = 1;
        }
        
        }
        else
        {
                val_80 = 0;
        }
        
        GameBehavior val_26 = App.getBehavior;
        val_80 = val_80 & checkLevelSkip;
        if(val_77 != 0)
        {
                val_77 = 1;
        }
        
        if(val_80 == true)
        {
                WordPets.WPTDataParser val_28 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Player val_29 = App.Player;
            var val_79 = 27972804;
            val_79 = 7656048 + val_79;
            if(val_79 == 0)
        {
                mem2[0] = 1;
        }
        
            System.Collections.Generic.List<GameLevel> val_30 = GetFeatureLevelCurve(bucket:  -1513226352);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_31 = this.CurrentLevelSkipStatus;
            if((this.ContainsKey(key:  1348647200)) != false)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_33 = this.CurrentLevelSkipStatus;
            string val_34 = this.Item[1348647200];
            object val_35 = this.Item[1348647200];
            val_81 = (System.Int32.Parse(s:  132739520, style:  511)) + 1;
        }
        else
        {
                val_81 = 0 - 1;
        }
        
            if((public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance()) != 0)
        {
            
        }
        else
        {
                val_82 = 0;
        }
        
            System.Collections.Generic.List<T> val_38 = GetRange(index:  val_81, count:  val_82 - val_81);
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_39 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  132739520, method:  new IntPtr(132702112));
            System.Collections.Generic.IEnumerable<TSource> val_40 = System.Linq.Enumerable.Where<System.Object>(source:  -2101986464, predicate:  7720960);
            System.Collections.Generic.List<TSource> val_41 = System.Linq.Enumerable.ToList<System.Object>(source:  -2101986464);
            val_83 = null;
            val_83 = null;
            val_85 = WADChapterManager.<>c.<>9__42_1;
            if(val_85 == 0)
        {
                val_85 = null;
            val_85 = new System.Predicate<ZooTile>(object:  WADChapterManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(132705184));
            WADChapterManager.<>c.<>9__42_1 = val_85;
        }
        
            System.Collections.Generic.List<T> val_43 = FindAll(match:  8040448);
            val_86 = null;
            val_86 = null;
            val_88 = WADChapterManager.<>c.<>9__42_2;
            if(val_88 == 0)
        {
                val_88 = null;
            val_88 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Single>(object:  WADChapterManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(132708256));
            WADChapterManager.<>c.<>9__42_2 = val_88;
        }
        
            object val_45 = MoreLinq.MinBy<System.Object, System.Single>(source:  -2101986464, selector:  7720960);
            val_78 = 1152921504892043264;
            if((public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance()) != 0)
        {
                System.Collections.Generic.List<SkippedLevel> val_46 = this.LevelsToSkip;
            float val_80 = 1000f;
            val_80 = (public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_84) * val_80;
            SkippedLevel val_47 = new SkippedLevel(word:  public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_30, index:  public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_40, avgCompletionTime:  S16, skipTriggerCompletionTime:  mem[1152921513329521124]);
            this.Insert(index:  0, item:  279924736);
            System.Collections.Generic.List<SkippedLevel> val_48 = this.LevelsToSkip;
            this.LevelsToSkip = 132739520;
            val_78 = 1152921504892043264;
            Player val_49 = App.Player;
            if(0 != 0)
        {
                val_89 = 0;
            val_90 = 308;
        }
        else
        {
                val_89 = 188;
            val_90 = 308;
        }
        
            mem[188] = 309;
        }
        
        }
        
        if(1 == 0)
        {
            goto label_79;
        }
        
        object val_50 = new System.Object();
        WordPets.WPTDataParser val_51 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        Player val_52 = App.Player;
        var val_81 = 27971548;
        val_81 = 7657304 + val_81;
        if(val_81 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Collections.Generic.List<GameLevel> val_53 = GetFeatureLevelCurve(bucket:  -1513226352);
        typeof(WADChapterManager.<>c__DisplayClass42_1).__il2cppRuntimeField_8 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance();
        System.Collections.Generic.Dictionary<System.String, System.Object> val_54 = this.CurrentLevelSkipStatus;
        bool val_55 = this.ContainsKey(key:  1348647200);
        if(val_55 == false)
        {
            goto label_89;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_56 = this.CurrentLevelSkipStatus;
        string val_57 = this.Item[1348647200];
        object val_58 = this.Item[1348647200];
        int val_59 = System.Int32.Parse(s:  132739520, style:  511);
        goto label_92;
        label_79:
        GameBehavior val_60 = App.getBehavior;
        if(0 == 0)
        {
            goto label_97;
        }
        
        WordPets.WPTDataParser val_61 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        GameLevel val_62 = GetDefinedLevel(index:  -1);
        goto label_115;
        label_89:
        val_91 = 0 - 1;
        label_92:
        typeof(WADChapterManager.<>c__DisplayClass42_1).__il2cppRuntimeField_C = val_91;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_63 = this.CurrentLevelSkipStatus;
        bool val_64 = this.ContainsKey(key:  1658601040);
        val_64 = val_55 & val_64;
        if(val_64 == true)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_65 = this.CurrentLevelSkipStatus;
            string val_66 = this.Item[1658601040];
            object val_67 = this.Item[1658601040];
            if((this.Equals(value:  -2085442816)) != false)
        {
                do
        {
            typeof(WADChapterManager.<>c__DisplayClass42_1).__il2cppRuntimeField_C = ((0 - 1) + 1);
            System.Collections.Generic.List<SkippedLevel> val_70 = this.LevelsToSkip;
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_71 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  397602816, method:  new IntPtr(132712352));
        }
        while((System.Linq.Enumerable.Any<MessageTypeSubscribers>(source:  132739520, predicate:  7720960)) == true);
        
        }
        
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.Collections.Generic.Dictionary<System.String, System.Object> val_74 = this.CurrentLevelSkipStatus;
        this.set_Item(key:  1348647200, value:  13152256);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_75 = this.CurrentLevelSkipStatus;
        this.set_Item(key:  1658601040, value:  132715424);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_76 = this.CurrentLevelSkipStatus;
        this.CurrentLevelSkipStatus = 132739520;
        goto label_115;
    }
    public GameLevel GetGameLevel(int playerLevel)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            return GetDefinedLevel(index:  playerLevel - 1);
        }
        
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<GameLevel> val_5 = CurrentLevelCurveGameLevels;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
    }
    public GameLevel GetGameLevel(int playerLevel, string language, string bucket)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            return GetDefinedLevel(index:  playerLevel - 1);
        }
        
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        LevelCurve val_5 = GetLevelCurve(lang:  language, bucket:  bucket);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
    }
    public void LevelWasCompleted()
    {
        GameBehavior val_1 = App.getBehavior;
        int val_2 = this.MaxPredefinedLevels;
        if(0 >= val_2)
        {
                val_2 = this;
            this.PrepPlayerVarsForNewChapter();
        }
        
        this.SaveData();
        if(this.OnLevelCompleted == 0)
        {
                return;
        }
        
        this.OnLevelCompleted.Invoke();
    }
    public void SaveData()
    {
        this.StorePlayerVars();
        Player val_1 = App.Player;
        0.SaveState();
        CPlayerPrefs.Save();
    }
    public void TrackLevelSkipLevelStart(string levelWord)
    {
        this.levelWord = levelWord;
        System.DateTime val_1 = System.DateTime.Now;
        this.levelStartStamp = new System.DateTime();
        this.levelCompletedInLessThanAverage = false;
    }
    public void TrackLevelSkipLevelComplete(float averageLevelWordCompletionTime)
    {
        var val_5;
        var val_10 = R1;
        System.DateTime val_1 = System.DateTime.Now;
        System.TimeSpan val_4 = Subtract(value:  new System.DateTime() {dateData = 1152921513330217920});
        val_10 = val_10 * 1000f;
        double val_7 = val_5.TotalMilliseconds;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
        {
                133436344 = 133436344;
        }
        
        this.levelCompletionInMillis = ;
        if(S4 < 2139095040)
        {
                0 = 1;
        }
        
        if(2139095040 > 0)
        {
                0 = 1;
        }
        
        this.levelCompletedInLessThanAverage = true;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_8 = this.CurrentLevelSkipStatus;
        this.set_Item(key:  1658601040, value:  -2085442816);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = this.CurrentLevelSkipStatus;
        this.CurrentLevelSkipStatus = 133448384;
    }
    private string GetCurveForBucket(string bucket)
    {
    
    }
    private void LoadPlayerVars()
    {
        string val_17;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_18;
        var val_20;
        System.Collections.Generic.List<System.Int32> val_21;
        var val_22;
        var val_23;
        val_18 = 1152921504882458624;
        if(((CPlayerPrefs.HasKey(key:  -133643152)) == false) || ((UnityEngine.PlayerPrefs.GetInt(key:  133656576, defaultValue:  1)) != 3))
        {
            goto label_4;
        }
        
        string val_3 = CPlayerPrefs.GetString(key:  -133643152, defaultValue:  1098586544);
        if("wadwut_pl_vars" == 0)
        {
            goto label_9;
        }
        
        val_20 = "wadwut_pl_vars";
        if((System.String.op_Inequality(a:  -133643152, b:  1098586544)) == false)
        {
            goto label_9;
        }
        
        this.DeserializePlayerVars(data:  -133643152);
        goto label_9;
        label_4:
        val_21 = null;
        val_21 = new System.Collections.Generic.List<System.Int32>();
        if(val_21 != 0)
        {
                Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
        }
        else
        {
                Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
        }
        
        Add(item:  7);
        this.plv_chapterWordLengths = val_21;
        val_22 = 1152921504906526720;
        goto label_12;
        label_20:
        int val_6 = System.Linq.Enumerable.LastOrDefault<System.Int32>(source:  this.plv_chapterWordLengths);
        this.plv_chapterWordLengths.Add(item:  val_6);
        val_21 = this.plv_chapterWordLengths;
        label_12:
        Player val_7 = App.Player;
        val_20 = 0;
        if(val_6 < (ChapterBookLogic.GetLevelsPerChapter(playerLevel:  0)))
        {
            goto label_20;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  133656576, value:  3);
        bool val_9 = PrefsSerializationManager.SavePlayerPrefs();
        val_18 = 1152921504882458624;
        label_9:
        if((CPlayerPrefs.HasKey(key:  -925895984)) == false)
        {
            goto label_25;
        }
        
        string val_11 = CPlayerPrefs.GetString(key:  -925895984, defaultValue:  1098586544);
        val_22 = 1152921504687730688;
        val_18 = null;
        val_18 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.plv_playedWords = val_18;
        object val_13 = MiniJSON.Json.Deserialize(json:  -925895984);
        if("wadwut_pw_vars" != 0)
        {
                if(null == null)
        {
            goto label_30;
        }
        
        }
        
        if("wadwut_pw_vars" == 0)
        {
            goto label_31;
        }
        
        label_40:
        label_31:
        val_20 = 0;
        goto label_33;
        label_25:
        label_52:
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_14 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.plv_playedWords = null;
        return;
        label_33:
        List.Enumerator<T> val_15 = GetEnumerator();
        label_38:
        if(MoveNext() == false)
        {
            goto label_35;
        }
        
        this.plv_playedWords.Add(item:  val_17);
        goto label_38;
        label_35:
        Dispose();
        if(0 == 0)
        {
                return;
        }
        
        return;
        label_30:
        goto label_40;
        label_53:
        val_23 = null;
        if(null != 1)
        {
            goto label_50;
        }
        
        if(null == 0)
        {
            goto label_51;
        }
        
        goto label_52;
        label_51:
        mem[4] = null;
        goto label_53;
        label_50:
    }
    private void StorePlayerVars()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 >= this.MaxPredefinedLevels)
        {
                string val_3 = this.SerializePlayerVars();
            CPlayerPrefs.SetString(key:  -133643152, val:  133821376);
        }
        
        string val_4 = MiniJSON.Json.Serialize(obj:  this.plv_playedWords);
        CPlayerPrefs.SetString(key:  -925895984, val:  this.plv_playedWords);
    }
    private string SerializePlayerVars()
    {
        var val_6 = 0;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        do
        {
            if(val_6 != 0)
        {
                System.Text.StringBuilder val_2 = Append(value:  -2100450224);
        }
        
            if(val_1 <= val_6)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_5 = val_5 + 0;
            string val_3 = (0 + 0) + 16.ToString();
            System.Text.StringBuilder val_4 = Append(value:  133929532);
            val_6 = val_6 + 1;
        }
        while(val_6 != 20);
        
        if(val_1 != 0)
        {
                return;
        }
    
    }
    private void DeserializePlayerVars(string data)
    {
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        var val_4 = 0;
        System.String[] val_1 = data.Split(separator:  478563824);
        string val_2 = data + 16;
        do
        {
            this.plv_chapterWordLengths.set_Item(index:  0, value:  System.Int32.Parse(s:  15388672));
            val_4 = val_4 + 1;
        }
        while(val_4 != 20);
    
    }
    private void PrepPlayerVarsForNewChapter()
    {
        PluginExtension.Shuffle<System.Int32>(list:  this.plv_chapterWordLengths, seed:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    public void Debug_PrintPlayerVars()
    {
        string val_1 = PrettyPrint.printJSON(obj:  this.plv_chapterWordLengths, types:  false, singleLineOutput:  true);
        string val_2 = -133012288(-133012288) + this.plv_chapterWordLengths;
        UnityEngine.Debug.LogError(message:  -133012288);
    }
    public WADChapterManager()
    {
        var val_3;
        this.levelWord = System.String.alignConst;
        this.debugFetchFromLevelSkipStatus = System.String.alignConst;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if(null != 0)
        {
                val_3 = 1152921510720759024;
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
        }
        else
        {
                val_3 = 1152921510720759024;
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
        }
        
        Add(item:  7);
        this.plv_chapterWordLengths = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.plv_playedWords = null;
    }
    private bool <GetGameLevelForPlayerLevelFromChapter>b__42_0(GameLevel lvl)
    {
        object val_1 = new System.Object();
        typeof(WADChapterManager.<>c__DisplayClass42_0).__il2cppRuntimeField_8 = lvl;
        System.Collections.Generic.List<SkippedLevel> val_2 = this.LevelsToSkip;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_3 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  397549568, method:  new IntPtr(134519552));
        bool val_4 = System.Linq.Enumerable.Any<MessageTypeSubscribers>(source:  134544576, predicate:  7720960);
        val_4 = val_4 ^ 1;
        return (bool)val_4;
    }

}
