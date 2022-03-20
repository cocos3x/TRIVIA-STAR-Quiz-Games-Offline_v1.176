using UnityEngine;
public class WordLevelGen : MonoSingletonSelfGenerating<WordLevelGen>
{
    // Fields
    private System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<string>>> RequiredDictionary;
    private const int NEVER_UNLOCK = 10000000;
    private System.Collections.Generic.List<int> DictionaryUnlockLevels;
    private System.Collections.Generic.List<string> DictionaryLoadPaths;
    private System.Collections.Generic.List<System.Collections.Generic.List<string>> CurrentRequiredDictionary;
    private const string CRD_PREFKEY = "wlg_crd";
    private System.Collections.Generic.List<int> UnlocksAdded;
    private const string UNLOCKS_ADDED_PREFKEY = "wlg_ula";
    private System.Collections.Generic.List<string> DefinedWords;
    private System.Collections.Generic.List<GameLevel> DefinedLevels;
    private bool initialized;
    private bool initializing;
    private bool knobsLoaded;
    public const int MIN_WORD_LENGTH = 3;
    public const int MAX_WORD_LENGTH = 7;
    public const int LEVEL_WORD_MINIMUM = 3;
    public static int LEVEL_WORD_MAXIMUM_KNOB;
    public System.Collections.Generic.List<int> LevelWordMaximums;
    public const int CHAPTERS_PER_BOOK = 4;
    public const int LEVEL_GEN_VERSION = 2;
    public static int[] chapter_lengths;
    public System.Action OnWordLevelGenInit;
    private int allPossibleWords;
    
    // Properties
    public bool HasInitialized { get; }
    public int DefinedLevelCount { get; }
    public string PathToGameResources { get; }
    
    // Methods
    public bool get_HasInitialized()
    {
        return (bool)this.initialized;
    }
    public int CurrentLevelWordMaximum()
    {
        null = null;
        return (int)WordLevelGen.LEVEL_GEN_VERSION;
    }
    public static int GetCurrentChapter(int playerLevel = -1)
    {
        int val_1 = WordLevelGen.GetCurrentCumulativeChapter(playerLevel:  playerLevel);
        val_1 = val_1 - 1;
        int val_2 = val_1 >> 31;
        val_2 = val_1 + (val_2 >> 30);
        val_2 = val_2 & (~3);
        val_1 = val_1 - val_2;
        val_1 = val_1 + 1;
        return (int)val_1;
    }
    public static int GetCurrentCumulativeChapter(int playerLevel = -1)
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = playerLevel;
        if(val_5 <= 0)
        {
                val_6 = 0;
            Player val_1 = App.Player;
            val_5 = 0;
            if(0 < 1)
        {
                return (int)val_6;
        }
        
        }
        
        do
        {
            val_7 = null;
            val_7 = null;
            System.Int32[] val_4 = WordLevelGen.chapter_lengths + ((System.Math.Min(val1:  0, val2:  (WordLevelGen.chapter_lengths + 12) - 1)) << 2);
            val_6 = 0 + 1;
            val_5 = val_5 - ((WordLevelGen.chapter_lengths + (val_3) << 2) + 16);
        }
        while(val_5 > 0);
        
        return (int)val_6;
    }
    public static int GetFirstLevelOfChapter(int playerLevel = -1)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_8 = playerLevel;
        if(val_8 <= 0)
        {
                Player val_1 = App.Player;
            val_8 = 0;
            if(0 < 1)
        {
                return (int)val_8;
        }
        
        }
        
        var val_9 = 0;
        val_9 = val_8;
        label_21:
        val_10 = null;
        val_10 = null;
        val_11 = System.Math.Min(val1:  0, val2:  (WordLevelGen.chapter_lengths + 12) - 1);
        System.Int32[] val_4 = WordLevelGen.chapter_lengths + (val_11 << 2);
        if(((WordLevelGen.chapter_lengths + (val_3) << 2) + 16) >= val_9)
        {
            goto label_13;
        }
        
        val_12 = null;
        val_12 = null;
        val_11 = System.Math.Min(val1:  0, val2:  (WordLevelGen.chapter_lengths + 12) - 1);
        System.Int32[] val_7 = WordLevelGen.chapter_lengths + (val_11 << 2);
        val_9 = val_9 + 1;
        val_9 = val_9 - ((WordLevelGen.chapter_lengths + (val_6) << 2) + 16);
        if(val_9 > 0)
        {
            goto label_21;
        }
        
        return (int)val_8;
        label_13:
        val_8 = (val_8 + 1) - val_9;
        return (int)val_8;
    }
    public static int GetLastLevelOfChapter(int playerLevel = -1)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_13 = playerLevel;
        if(val_13 <= 0)
        {
                Player val_1 = App.Player;
            val_13 = 0;
            if(0 < 1)
        {
                return (int)val_13;
        }
        
        }
        
        var val_12 = 0;
        val_14 = val_13;
        label_21:
        val_15 = null;
        val_15 = null;
        val_16 = System.Math.Min(val1:  0, val2:  (WordLevelGen.chapter_lengths + 12) - 1);
        val_17 = null;
        System.Int32[] val_4 = WordLevelGen.chapter_lengths + (val_16 << 2);
        if(((WordLevelGen.chapter_lengths + (val_3) << 2) + 16) >= val_14)
        {
            goto label_13;
        }
        
        val_18 = null;
        val_16 = System.Math.Min(val1:  0, val2:  (WordLevelGen.chapter_lengths + 12) - 1);
        System.Int32[] val_8 = WordLevelGen.chapter_lengths + (val_16 << 2);
        val_12 = val_12 + 1;
        val_14 = val_14 - ((WordLevelGen.chapter_lengths + (val_7) << 2) + 16);
        if(val_14 > 0)
        {
            goto label_21;
        }
        
        return (int)val_13;
        label_13:
        val_19 = null;
        System.Int32[] val_11 = WordLevelGen.chapter_lengths + ((System.Math.Min(val1:  0, val2:  (WordLevelGen.chapter_lengths + 12) - 1)) << 2);
        var val_13 = val_14;
        val_13 = val_13 + val_13;
        val_13 = val_13 + ((WordLevelGen.chapter_lengths + (val_10) << 2) + 16);
        return (int)val_13;
    }
    public static int GetLevelWithinChapter(int playerLevel = -1)
    {
        var val_8;
        var val_9;
        System.Int32[] val_10;
        var val_11;
        var val_12;
        val_8 = playerLevel;
        if(val_8 <= 0)
        {
                Player val_1 = App.Player;
            val_8 = 0;
            if(0 < 1)
        {
                return (int)val_8;
        }
        
        }
        
        var val_8 = 0;
        var val_9 = val_8;
        label_21:
        val_9 = null;
        val_9 = null;
        val_10 = WordLevelGen.chapter_lengths;
        val_11 = System.Math.Min(val1:  0, val2:  (WordLevelGen.chapter_lengths + 12) - 1);
        System.Int32[] val_4 = val_10 + (val_11 << 2);
        if(((WordLevelGen.chapter_lengths + (val_3) << 2) + 16) >= val_9)
        {
            goto label_13;
        }
        
        val_12 = null;
        val_12 = null;
        val_10 = WordLevelGen.chapter_lengths;
        val_11 = System.Math.Min(val1:  0, val2:  (WordLevelGen.chapter_lengths + 12) - 1);
        System.Int32[] val_7 = val_10 + (val_11 << 2);
        val_8 = val_8 + 1;
        val_9 = val_9 - ((WordLevelGen.chapter_lengths + (val_6) << 2) + 16);
        if(val_9 > 0)
        {
            goto label_21;
        }
        
        return (int)val_8;
        label_13:
        val_8 = val_9;
        return (int)val_8;
    }
    public static int GetLevelsPerChapter(int playerLevel = -1)
    {
        null = null;
        int val_4 = System.Math.Min(val1:  WordLevelGen.GetCurrentCumulativeChapter(playerLevel:  playerLevel), val2:  WordLevelGen.chapter_lengths + 12);
        val_4 = val_4 - 1;
        System.Int32[] val_3 = WordLevelGen.chapter_lengths + (val_4 << 2);
        return (int)(WordLevelGen.chapter_lengths + ((val_2 - 1)) << 2) + 16;
    }
    public static int GetLevelsForChapter(int chapter)
    {
        null = null;
        int val_5 = WordLevelGen.chapter_lengths + 12;
        val_5 = val_5 - 1;
        System.Int32[] val_4 = WordLevelGen.chapter_lengths + ((System.Math.Max(val1:  System.Math.Min(val1:  chapter - 1, val2:  val_5), val2:  0)) << 2);
        return (int)(WordLevelGen.chapter_lengths + (val_3) << 2) + 16;
    }
    public static int GetLevelsThroughChapter(int chapter)
    {
        var val_2;
        if(chapter >= 1)
        {
                var val_2 = 1;
            do
        {
            val_2 = val_2 + 1;
            val_2 = (WordLevelGen.GetLevelsForChapter(chapter:  1)) + 0;
        }
        while(val_2 <= chapter);
        
            return (int)val_2;
        }
        
        val_2 = 0;
        return (int)val_2;
    }
    public static int GetFirstLevelOfBook(int playerLevel = -1)
    {
        var val_5;
        var val_6;
        val_5 = playerLevel;
        if(val_5 <= 0)
        {
                Player val_1 = App.Player;
            val_5 = 0;
            if(0 < 1)
        {
                return (int)val_7;
        }
        
        }
        
        var val_8 = 0;
        var val_7 = 1;
        do
        {
            var val_6 = 0;
            do
        {
            val_6 = null;
            val_6 = null;
            System.Int32[] val_5 = WordLevelGen.chapter_lengths + ((System.Math.Min(val1:  val_8 + val_6, val2:  (WordLevelGen.chapter_lengths + 12) - 1)) << 2);
            val_6 = val_6 + 1;
            val_7 = ((WordLevelGen.chapter_lengths + (val_4) << 2) + 16) + val_7;
        }
        while(val_6 != 4);
        
            val_8 = val_8 + 4;
        }
        while(val_7 <= val_5);
        
        return (int)val_7;
    }
    public static int GetFirstLevelOfSecondBook()
    {
        var val_4;
        var val_4 = 0;
        var val_5 = 1;
        do
        {
            val_4 = null;
            val_4 = null;
            System.Int32[] val_3 = WordLevelGen.chapter_lengths + ((System.Math.Min(val1:  0, val2:  (WordLevelGen.chapter_lengths + 12) - 1)) << 2);
            val_4 = val_4 + 1;
            val_5 = ((WordLevelGen.chapter_lengths + (val_2) << 2) + 16) + val_5;
        }
        while(val_4 != 4);
        
        return (int)val_5;
    }
    public static int GetCurrentBook(int playerLevel = -1)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = playerLevel;
        if(val_5 <= 0)
        {
                val_6 = 0;
            Player val_1 = App.Player;
            val_7 = 0;
            if(0 < 1)
        {
                return (int)val_6;
        }
        
        }
        
        var val_8 = 1;
        var val_6 = 0;
        var val_9 = 0;
        do
        {
            var val_7 = 0;
            val_6 = val_6 + 1;
            do
        {
            val_8 = null;
            val_8 = null;
            System.Int32[] val_5 = WordLevelGen.chapter_lengths + ((System.Math.Min(val1:  val_9 + val_7, val2:  (WordLevelGen.chapter_lengths + 12) - 1)) << 2);
            val_7 = val_7 + 1;
            val_8 = ((WordLevelGen.chapter_lengths + (val_4) << 2) + 16) + val_8;
        }
        while(val_7 != 4);
        
            val_9 = val_7;
            val_9 = val_9 + 4;
            val_6 = val_6;
        }
        while(val_8 <= val_9);
        
        return (int)val_6;
    }
    public GameLevel GetDefinedLevel(int index)
    {
        System.Collections.Generic.List<GameLevel> val_4 = this.DefinedLevels;
        if(0 <= index)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + (index << 2);
        if(((0 + (index) << 2) + 16) == 0)
        {
                if(((0 + (index) << 2) + 16) <= index)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_5 = val_5 + (index << 2);
            GameLevel val_1 = this.BuildLevelBasedOnWord(daWord:  (0 + (index) << 2) + 16, maxWordCount:  0, keepWord:  null);
            this.DefinedLevels.set_Item(index:  index, value:  99206784);
            if(this.DefinedLevels <= index)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_6 = val_6 + (index << 2);
            val_4 = mem[(0 + (index) << 2) + 16];
            val_4 = (0 + (index) << 2) + 16;
            string val_3 = index + 1.ToString();
            val_4.levelName = 99194756;
        }
        
        if(val_4 <= index)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + (index << 2);
    }
    public int get_DefinedLevelCount()
    {
        if(this.DefinedLevels != 0)
        {
                return (int)true;
        }
        
        return (int)true;
    }
    private void Start()
    {
        this.Initialize();
    }
    public void ReInitialize()
    {
        if(this.initialized == false)
        {
                return;
        }
        
        if(this.initializing != false)
        {
                return;
        }
        
        this.initialized = false;
        this.Initialize();
    }
    private void Initialize()
    {
        var val_1;
        if(this.initialized == false)
        {
                this.initialized = this.initializing;
            goto label_1;
        }
        
        return;
        label_1:
        this.initializing = true;
        this.ReadFromKnobs();
        this.LoadLengthsInMemoryFromResources();
        this.LoadDefinedLevelsIntoMemoryFromResources(lang:  1800251696);
        this.LoadCurrentDictionary();
        this.initialized = true;
        this.initializing = false;
        val_1 = null;
        val_1 = null;
        WordApp.CurrentlyLoadedLevelGenVersion = 2;
        if(this.OnWordLevelGenInit == 0)
        {
                return;
        }
        
        this.OnWordLevelGenInit.Invoke();
    }
    public void Unload()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  99803648);
    }
    private void ReadFromKnobs()
    {
        float val_22;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_23;
        var val_24;
        System.Collections.Generic.List<System.Int32> val_25;
        var val_26;
        var val_27;
        if(this.knobsLoaded == true)
        {
                return;
        }
        
        this.knobsLoaded = true;
        val_22 = 1152921504685600768;
        val_23 = null;
        val_23 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        var val_22 = 24044267;
        val_22 = 11583148 + val_22;
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_24 = null;
        val_24 = null;
        val_25 = 0;
        twelvegigs.storage.JsonDictionary val_2 = getWordGameplayKnobs();
        if(App.storageManager.knobsModel == 0)
        {
            goto label_9;
        }
        
        if(null != null)
        {
            goto label_12;
        }
        
        val_25 = 0;
        goto label_14;
        label_9:
        if(val_23 != 0)
        {
            goto label_14;
        }
        
        label_12:
        val_23 = 0;
        val_25 = 1;
        label_14:
        val_26 = "rwd";
        if((val_23.ContainsKey(key:  -992667952)) != false)
        {
                string val_4 = val_23.Item[-992667952];
            val_22 = 1;
            if((0.ContainsKey(key:  99891648)) != false)
        {
                string val_6 = 0.Item[99891648];
            bool val_8 = System.Int32.TryParse(s:  null, result: out  int val_7 = 99920312);
            if(0 <= 1)
        {
                0 = 38528;
        }
        
            val_25 = this.DictionaryUnlockLevels;
            val_25.set_Item(index:  1, value:  10000000);
        }
        
            if((0.ContainsKey(key:  99895824)) != false)
        {
                string val_10 = 0.Item[99895824];
            bool val_12 = System.Int32.TryParse(s:  null, result: out  int val_11 = 99920312);
            if(10000000 <= 1)
        {
                10000000 = 38528;
        }
        
            val_25 = this.DictionaryUnlockLevels;
            val_25.set_Item(index:  2, value:  10000000);
        }
        
            if((0.ContainsKey(key:  99900000)) != false)
        {
                string val_14 = 0.Item[99900000];
            bool val_16 = System.Int32.TryParse(s:  null, result: out  int val_15 = 99920312);
            if(10000000 <= 1)
        {
                10000000 = 38528;
        }
        
            val_25 = this.DictionaryUnlockLevels;
            val_25.set_Item(index:  3, value:  10000000);
        }
        
            val_26 = "e4_lu";
            if((0.ContainsKey(key:  99904176)) != false)
        {
                string val_18 = 0.Item[99904176];
            bool val_20 = System.Int32.TryParse(s:  null, result: out  int val_19 = 99920312);
            if(10000000 <= 1)
        {
                10000000 = 38528;
        }
        
            this.DictionaryUnlockLevels.set_Item(index:  4, value:  10000000);
        }
        
        }
        
        GameEcon val_21 = App.getGameEcon;
        val_27 = null;
        val_27 = null;
        WordLevelGen.LEVEL_GEN_VERSION = 0;
    }
    public void CallEmptyMethod()
    {
    
    }
    public GameLevel BuildLevelBasedOnWord(string daWord, int maxWordCount = -1, string keepWord)
    {
        twelvegigs.sweepstakes.Distribution val_23;
        twelvegigs.sweepstakes.Distribution val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        float val_41;
        var val_42;
        var val_43;
        val_35 = daWord;
        if(maxWordCount <= 2)
        {
                val_36 = null;
            val_36 = null;
        }
        
        GameLevel val_1 = new GameLevel();
        val_37 = 1152921511095697248;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101084320) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_5 = IsPlayingChallengingLevels;
        }
        
        string val_7 = val_35.Chars[0].ToString();
        typeof(GameLevel).__il2cppRuntimeField_30 = ;
        val_38 = 1;
        goto label_15;
        label_17:
        val_37 = typeof(GameLevel).__il2cppRuntimeField_30;
        string val_9 = val_35.Chars[1].ToString();
        string val_10 = 100189370 + -2100450224(-2100450224) + 100189370;
        val_38 = 2;
        typeof(GameLevel).__il2cppRuntimeField_30 = val_37;
        label_15:
        if(val_38 < daWord.m_stringLength)
        {
            goto label_17;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_13 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_14 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  val_35);
        val_39 = 4;
        goto label_19;
        label_46:
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.List<System.String> val_15 = this.GetAvailableWordsFromList(word:  val_35, listToUse:  2621443, startingLength:  3, endingLength:  daWord.m_stringLength);
        PluginExtension.Shuffle<UnityEngine.Sprite>(list:  100201408, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        Player val_16 = App.Player;
        if(0 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_37 = val_13;
        if(0 >= 2621443)
        {
            goto label_31;
        }
        
        if(val_5 == false)
        {
            goto label_28;
        }
        
        if(val_5 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443 <= 9999999)
        {
            goto label_31;
        }
        
        label_28:
        AddRange(collection:  100201408);
        val_40 = null;
        goto label_42;
        label_31:
        AddRange(collection:  100201408);
        if(val_37 != 0)
        {
                Clear();
        }
        else
        {
                Clear();
        }
        
        AddRange(collection:  100201408);
        if(val_37 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        var val_40 = 406886400;
        val_40 = val_40 + (daWord.m_stringLength << 2);
        val_40 = null;
        if(((406886400 + (daWord.m_stringLength) << 2) + 16.Contains(item:  val_35)) != false)
        {
                Add(item:  val_35);
        }
        
        label_42:
        Add(item:  100201408);
        val_39 = 5;
        val_35 = val_35;
        label_19:
        if((val_39 - 4) < val_40)
        {
            goto label_46;
        }
        
        val_41 = "|";
        System.Collections.Generic.List<ZooTile> val_19 = new System.Collections.Generic.List<ZooTile>(collection:  80883712);
        Clear();
        Add(item:  val_35);
        bool val_20 = Remove(item:  val_35);
        if(keepWord != null)
        {
                Add(item:  keepWord);
            bool val_21 = Remove(item:  keepWord);
        }
        
        PluginExtension.Shuffle<UnityEngine.Sprite>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        List.Enumerator<T> val_22 = GetEnumerator();
        goto label_54;
        label_64:
        if(2305843011401818080 > WordLevelGen.LEVEL_GEN_VERSION)
        {
                if((val_23 + 8) < 4)
        {
            goto label_58;
        }
        
        }
        
        Add(item:  val_23);
        goto label_62;
        label_58:
        Add(item:  val_23);
        val_41 = "|";
        if((Contains(item:  val_23)) != false)
        {
                bool val_25 = Remove(item:  val_23);
        }
        
        label_62:
        label_54:
        if(MoveNext() == true)
        {
            goto label_64;
        }
        
        Dispose();
        val_35 = val_35;
        typeof(GameLevel).__il2cppRuntimeField_48 = System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        typeof(GameLevel).__il2cppRuntimeField_34 = List<T>.__il2cppRuntimeField_10;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        string val_27 = List<T>.__il2cppRuntimeField_10(List<T>.__il2cppRuntimeField_10) + -2100450224(-2100450224) + List<T>.__il2cppRuntimeField_14(List<T>.__il2cppRuntimeField_14);
        typeof(GameLevel).__il2cppRuntimeField_34 = List<T>.__il2cppRuntimeField_10;
        var val_28 = 5 + 1;
        var val_29 = 5 - 3;
        typeof(GameLevel).__il2cppRuntimeField_38 = "";
        typeof(GameLevel).__il2cppRuntimeField_38 = List<T>.__il2cppRuntimeField_10;
        val_37 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        string val_30 = List<T>.__il2cppRuntimeField_10(List<T>.__il2cppRuntimeField_10) + -2100450224(-2100450224) + List<T>.__il2cppRuntimeField_14(List<T>.__il2cppRuntimeField_14);
        typeof(GameLevel).__il2cppRuntimeField_38 = List<T>.__il2cppRuntimeField_10;
        var val_31 = 5 + 1;
        var val_32 = 5 - 3;
        levelName = val_35;
        GameBehavior val_33 = App.getBehavior;
        string val_34 = 0.GetCurrentLanguage();
        typeof(GameLevel).__il2cppRuntimeField_44 = 0;
        typeof(GameLevel).__il2cppRuntimeField_10 = val_5;
        val_42 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_43 = 1152921504687730696;
        typeof(GameLevel).__il2cppRuntimeField_80 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_37) << 2);
        CompanyDevices val_38 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        typeof(GameLevel).__il2cppRuntimeField_6C = List<T>.__il2cppRuntimeField_10;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        typeof(GameLevel).__il2cppRuntimeField_70 = List<T>.__il2cppRuntimeField_14;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        typeof(GameLevel).__il2cppRuntimeField_74 = List<T>.__il2cppRuntimeField_18;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        typeof(GameLevel).__il2cppRuntimeField_78 = List<T>.__il2cppRuntimeField_1C;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        typeof(GameLevel).__il2cppRuntimeField_7C = List<T>.__il2cppRuntimeField_20;
    }
    public System.Collections.Generic.List<string> GetAvailableWordsFromList(string word, System.Collections.Generic.List<System.Collections.Generic.List<string>> listToUse, int startingLength, int endingLength)
    {
        string val_4;
        var val_8;
        var val_10;
        val_8 = startingLength;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_8 > endingLength)
        {
                return;
        }
        
        label_15:
        if(val_8 >= endingLength)
        {
                return;
        }
        
        if(endingLength <= val_8)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (val_8 << 2);
        val_10 = mem[(0 + (startingLength) << 2) + 16];
        val_10 = (0 + (startingLength) << 2) + 16;
        if(val_10 == 0)
        {
            goto label_5;
        }
        
        if(val_8 <= val_8)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_9 = val_9 + (val_8 << 2);
            val_10 = mem[(0 + (startingLength) << 2) + 16];
            val_10 = (0 + (startingLength) << 2) + 16;
            if(val_10 == 0)
        {
                val_10 = 0;
        }
        
        }
        
        List.Enumerator<T> val_2 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        bool val_5 = System.String.op_Inequality(a:  word, b:  val_4);
        if(((val_5 == false) || ((val_5.CanSpell(letters:  word, word:  val_4)) == false)) || ((Contains(item:  val_4)) == true))
        {
            goto label_14;
        }
        
        Add(item:  val_4);
        goto label_14;
        label_8:
        Dispose();
        if(1 != 1)
        {
                 = 0;
            1 = 1 + ;
        }
        
        if(1 == 1)
        {
                1 = 0;
        }
        
        label_5:
        val_8 = val_8 + 1;
        if(val_8 <= endingLength)
        {
            goto label_15;
        }
    
    }
    private bool CanSpell(string letters, string word)
    {
        var val_4;
        var val_5;
        var val_6;
        System.Collections.Generic.List<System.Boolean> val_1 = new System.Collections.Generic.List<System.Boolean>();
        val_4 = 0;
        goto label_1;
        label_4:
        Add(item:  false);
        val_4 = 1;
        label_1:
        if(val_4 < letters.m_stringLength)
        {
            goto label_4;
        }
        
        val_5 = 0;
        goto label_5;
        label_14:
        val_6 = 0;
        if(letters.m_stringLength < 1)
        {
                return (bool)val_6;
        }
        
        var val_4 = 0;
        label_11:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        if(letters.Chars[0] == word.Chars[0])
        {
            goto label_10;
        }
        
        val_4 = val_4 + 1;
        if(val_4 < letters.m_stringLength)
        {
            goto label_11;
        }
        
        goto label_12;
        label_10:
        set_Item(index:  0, value:  true);
        val_5 = 1;
        label_5:
        if(val_5 < word.m_stringLength)
        {
            goto label_14;
        }
        
        val_6 = 1;
        return (bool)val_6;
        label_12:
        val_6 = 0;
        return (bool)val_6;
    }
    public GameLevel BuildChallengingLevelForNormalProgression()
    {
        GameLevel val_2 = this.BuildDynamicLevel(wordLength:  UnityEngine.Random.Range(min:  3, max:  7), wordCount:  3, maxWordCount:  0, dailyChallenge:  false);
    }
    public GameLevel GetDynamicDailyChallengeLevel(int wordLength, int wordCount = 3, int maxWordCount = -1)
    {
        GameLevel val_1 = this.BuildDynamicLevel(wordLength:  wordLength, wordCount:  wordCount, maxWordCount:  maxWordCount, dailyChallenge:  true);
    }
    public GameLevel BuildDynamicLevel(int wordLength, int wordCount = 3, int maxWordCount = -1, bool dailyChallenge = False)
    {
        var val_28;
        int val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        ZooTile val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        ZooTile val_41;
        var val_42;
        var val_43;
        val_28 = this;
        val_29 = wordLength;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                var val_30 = 24045962;
            val_30 = 11590792 + val_30;
            if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
            val_30 = null;
            val_30 = null;
            if((System.String.op_Inequality(a:  WADataParser.QAhackedWord, b:  System.String.alignConst)) != false)
        {
                if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
            val_31 = null;
            val_31 = null;
            val_29 = mem[WADataParser.QAhackedWord + 8];
            val_29 = WADataParser.QAhackedWord.m_stringLength;
        }
        
        }
        
        val_32 = 0;
        val_33 = System.Math.Min(val1:  System.Math.Max(val1:  val_29, val2:  3), val2:  7);
        if(dailyChallenge == true)
        {
            goto label_35;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101084320) == 0)
        {
            goto label_24;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_32 = 0;
        if(IsPlayingChallengingLevels == false)
        {
            goto label_35;
        }
        
        Player val_10 = App.Player;
        val_33 = val_33;
        if(0 <= this.DefinedLevelCount)
        {
            goto label_35;
        }
        
        val_33 = RandomSet.singleInRange(lowest:  6, highest:  7);
        goto label_35;
        label_24:
        val_32 = 0;
        label_35:
        this.AddNewUnlocks();
        label_89:
        val_34 = val_33;
        if(val_32 != 0)
        {
                if(256 >= wordCount)
        {
            goto label_37;
        }
        
        }
        
        if(256 <= val_34)
        {
                var val_31 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_31 = val_31 + (val_34 << 2);
        if(((0 + (val_5) << 2) + 16 + 12) != 0)
        {
            goto label_51;
        }
        
        val_35 = 4;
        goto label_42;
        label_57:
        if(((0 + (val_5) << 2) + 16 + 12) <= val_34)
        {
                var val_32 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_32 = val_32 + (val_34 << 2);
        if(val_32 <= (public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance()))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        var val_33 = 406886400;
        val_33 = val_33 + (val_34 << 2);
        (0 + (val_5) << 2) + 16.AddRange(collection:  (406886400 + (val_5) << 2) + 16);
        val_35 = 5;
        label_42:
        var val_13 = val_35 - 4;
        if(val_13 >= ((0 + (val_5) << 2) + 16))
        {
            goto label_51;
        }
        
        Player val_14 = App.Player;
        if(0 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 >= 1)
        {
            goto label_57;
        }
        
        label_51:
        int val_16 = RandomSet.singleInRange(lowest:  0, highest:  ((0 + (val_5) << 2) + 16 + 12) - 1);
        if(((0 + (val_5) << 2) + 16 + 12) <= val_16)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_34 = (0 + (val_5) << 2) + 16 + 8;
        val_34 = val_34 + (val_16 << 2);
        val_36 = mem[((0 + (val_5) << 2) + 16 + 8 + (val_16) << 2) + 16];
        val_36 = ((0 + (val_5) << 2) + 16 + 8 + (val_16) << 2) + 16;
        CompanyDevices val_17 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                var val_35 = 24044502;
            val_35 = 11592252 + val_35;
            val_37 = null;
            val_37 = null;
            if((System.String.op_Inequality(a:  WADataParser.QAhackedWord, b:  System.String.alignConst)) != false)
        {
                var val_36 = 24044322;
            val_36 = 11592432 + val_36;
            val_38 = null;
            val_38 = null;
            string val_20 = WADataParser.QAhackedWord.ToUpper();
            val_36 = WADataParser.QAhackedWord;
        }
        
        }
        
        if(WADataParser.QAhackedWord <= val_34)
        {
                var val_37 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_37 = val_37 + (val_34 << 2);
        bool val_21 = (0 + (val_5) << 2) + 16.Contains(item:  val_36);
        val_32 = val_32;
        if(val_21 != false)
        {
                if(val_21 <= val_34)
        {
                var val_38 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_38 = val_38 + (val_34 << 2);
            bool val_22 = (0 + (val_5) << 2) + 16.Remove(item:  val_36);
            val_32 = val_32;
        }
        
        GameLevel val_23 = this.BuildLevelBasedOnWord(daWord:  val_36, maxWordCount:  maxWordCount, keepWord:  null);
        if(val_32 != 0)
        {
                if(val_36 <= 256)
        {
            goto label_87;
        }
        
        }
        
        val_39 = 0;
        val_32 = val_28;
        goto label_88;
        label_87:
        val_39 = 0 + 1;
        label_88:
        var val_24 = val_39 - 50;
        val_24 = val_24 >> 5;
        val_24 = val_24 & dailyChallenge;
        if(val_34 < 7)
        {
                0 = 1;
        }
        
        if(val_24 == true)
        {
                val_39 = 0;
        }
        
        if(val_39 <= 49)
        {
            goto label_89;
        }
        
        if(val_32 == 0)
        {
                val_32 = 0;
        }
        
        val_40 = val_34 + val_24;
        goto label_91;
        label_37:
        val_40 = val_34;
        label_91:
        var val_39 = 6;
        val_41 = null;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        val_42 = 0;
        System.String[] val_27 = 6.Split(separator:  478563824);
        val_43 = val_39;
        val_39 = val_39 + 16;
        goto label_95;
        label_107:
        val_41 = mem[(6 + 16) + 0];
        val_41 = (6 + 16) + 0;
        if(((6 + 16) + 0 + 8) == val_40)
        {
                val_34 = val_40;
            if(((6 + 16) + 0 + 8) <= val_34)
        {
                var val_40 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_40 = val_40 + (val_34 << 2);
            bool val_28 = (0 + (val_5) << 2) + 16.Contains(item:  val_41);
            val_43 = val_39;
            val_40 = val_34;
            if(val_28 != false)
        {
                if(val_28 <= val_34)
        {
                var val_41 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_41 = val_41 + (val_34 << 2);
            bool val_29 = (0 + (val_5) << 2) + 16.Remove(item:  val_41);
            val_40 = val_34;
        }
        
        }
        
        val_42 = 1;
        label_95:
        if(val_42 < 65576)
        {
            goto label_107;
        }
        
        this.SaveCurrentDictionary();
    }
    public GameLevel BuildLevelContainingWordOfLength(string word, int desiredLength, int desiredAnswers, int lengthFlexibility = 0)
    {
        var val_1;
        string val_7;
        int val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_14;
        var val_15;
        val_8 = desiredLength;
        val_9;
        if(lengthFlexibility >= 0)
        {
            
        }
        else
        {
                val_10 = 0;
            return;
        }
        
        label_37:
        val_1 = 0;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_12 = 4;
        goto label_10;
        label_22:
        this.FindLargerWordContainingWord(smallWord:  word, desiredLevelLength:  val_8, dictIndex:  R8, wordsListReturn:  null);
        val_12 = 5;
        label_10:
        var val_3 = val_12 - 4;
        if(val_3 >= this)
        {
            goto label_18;
        }
        
        Player val_4 = App.Player;
        if(0 <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8;
        if(0 < 1)
        {
            goto label_18;
        }
        
        if(1 <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(val_8 < 50331648)
        {
            goto label_22;
        }
        
        label_18:
        List.Enumerator<T> val_5 = GetEnumerator();
        label_30:
        if(MoveNext() == false)
        {
            goto label_25;
        }
        
        GameLevel val_8 = this.BuildLevelBasedOnWord(daWord:  val_7, maxWordCount:  desiredAnswers, keepWord:  word);
        val_10 = this;
        if(0 != 0)
        {
                if(val_7 <= 256)
        {
                val_10 = 0;
        }
        
        }
        else
        {
                if(val_10 == 0)
        {
                val_10 = 0;
        }
        
        }
        
        if(256 < desiredAnswers)
        {
            goto label_30;
        }
        
        goto label_31;
        label_25:
        val_10 = 0;
        label_31:
        val_11 = val_1 + 1;
        mem2[0] = 188;
        Dispose();
        val_15 = 0;
        if(val_11 != 1)
        {
                if(val_11 > 1)
        {
                0 = 1;
        }
        
            var val_9 = 101012856 + ((val_1 + 1)) << 2;
            val_9 = val_9 - 188;
            val_9 = val_9 >> 5;
            val_9 = 1 & val_9;
            val_14 = val_11 - val_9;
        }
        else
        {
                val_14 = 0;
        }
        
        if(val_10 != 0)
        {
                if(256 >= desiredAnswers)
        {
                return;
        }
        
        }
        
        val_15 = val_15 + 1;
        val_8 = val_8 + 1;
        if(val_15 <= lengthFlexibility)
        {
            goto label_37;
        }
    
    }
    public void FindLargerWordContainingWord(string smallWord, int desiredLevelLength, int dictIndex, System.Collections.Generic.List<string> wordsListReturn)
    {
        string val_3;
        var val_5;
        System.Collections.Generic.List<System.String> val_6;
        var val_7;
        val_5 = this;
        val_6 = dictIndex;
        val_7 = 35636605;
        if(smallWord.m_stringLength >= desiredLevelLength)
        {
                return;
        }
        
        if(smallWord.m_stringLength <= val_6)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + (val_6 << 2);
        if(((0 + (dictIndex) << 2) + 16 + 12) <= desiredLevelLength)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = (0 + (dictIndex) << 2) + 16 + 8;
        val_6 = val_6 + (desiredLevelLength << 2);
        val_5 = mem[((0 + (dictIndex) << 2) + 16 + 8 + (desiredLevelLength) << 2) + 16];
        val_5 = ((0 + (dictIndex) << 2) + 16 + 8 + (desiredLevelLength) << 2) + 16;
        val_7;
        val_6 = wordsListReturn;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_11:
        bool val_2 = MoveNext();
        if(val_2 == false)
        {
            goto label_8;
        }
        
        if((val_2.CanSpell(letters:  val_3, word:  smallWord)) == false)
        {
            goto label_11;
        }
        
        val_6.Add(item:  val_3);
        goto label_11;
        label_8:
        Dispose();
    }
    public string get_PathToGameResources()
    {
        string val_1 = WordApp.GamePathName;
        return -1655690384(-1655690384) + null + 1115175264;
    }
    private string GetPlayerBucket()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return;
        }
    
    }
    private void LoadLengthsInMemoryFromResources()
    {
        var val_7;
        twelvegigs.sweepstakes.Distribution val_16;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        twelvegigs.sweepstakes.Distribution val_26;
        var val_18 = 24041151;
        val_18 = 11584636 + val_18;
        if(val_18 == 0)
        {
                mem2[0] = 1;
        }
        
        val_18 = null;
        val_18 = null;
        if(App.game == 1)
        {
                string val_1 = App.game.GetPlayerBucket();
            string val_2 = System.String.Format(format:  -135132576, arg0:  App.game);
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem[1152921513298297548] = null;
        val_19 = 0;
        goto label_7;
        label_46:
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  80883712);
        var val_19 = 0;
        do
        {
            if(val_19 > 2)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_20 = null;
            val_21 = 1152921511481194736;
        }
        else
        {
                val_20 = 0;
            val_21 = 1152921511481194736;
        }
        
            Add(item:  0);
            val_19 = val_19 + 1;
        }
        while(val_19 != 8);
        
        string val_6 = PathToGameResources;
        if((mem[1152921513298297556] + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_20 = mem[1152921513298297556] + 8;
        val_22 = "{0}{1}{2}";
        val_20 = val_20 + (val_7 << 2);
        string val_8 = System.String.Format(format:  -1183154368, arg0:  80883712, arg1:  -135132576, arg2:  (mem[1152921513298297556] + 8 + (val_7) << 2) + 16);
        T[] val_9 = UnityEngine.Resources.LoadAll<System.Object>(path:  -1183154368);
        val_23 = 0;
        label_36:
        if(val_22 == 0)
        {
                val_22 = val_22;
            val_23 = val_23;
        }
        
        val_22 = val_22;
        val_23 = val_23;
        string val_10 = "{0}{1}{2}".__il2cppRuntimeField_10.name;
        int val_11 = System.Int32.Parse(s:  "{0}{1}{2}".__il2cppRuntimeField_10);
        string val_12 = "{0}{1}{2}".__il2cppRuntimeField_10.text;
        object val_13 = MiniJSON.Json.Deserialize(json:  "{0}{1}{2}".__il2cppRuntimeField_10);
        val_24 = null;
        val_24 = null;
        val_25 = 0;
        if((("{0}{1}{2}".__il2cppRuntimeField_10 + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_24)
        {
                "{0}{1}{2}".__il2cppRuntimeField_10 = 0;
        }
        
        val_25 = "{0}{1}{2}".__il2cppRuntimeField_10;
        List.Enumerator<T> val_14 = GetEnumerator();
        label_35:
        if(MoveNext() == false)
        {
            goto label_27;
        }
        
        val_26 = 0;
        if(val_16 != 0)
        {
                if(val_16 != null)
        {
            
        }
        else
        {
                val_26 = val_16;
        }
        
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        string val_17 = val_26.ToUpper();
        (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_11) << 2) + 16.Add(item:  val_26);
        goto label_35;
        label_27:
        Dispose();
        var val_21 = val_23;
        if(1 != 1)
        {
                public List.Enumerator<T> System.Collections.Generic.List<System.Object>::GetEnumerator() = 0;
            1 = 1 + (public List.Enumerator<T> System.Collections.Generic.List<System.Object>::GetEnumerator());
        }
        
        val_21 = val_21 + 1;
        if(1 == 1)
        {
                1 = 0;
        }
        
        goto label_36;
        label_7:
        val_7 = ;
        if(val_7 < (mem[1152921513298297556] + 12))
        {
            goto label_46;
        }
    
    }
    private void LoadDefinedLevelsIntoMemoryFromResources(string lang)
    {
        string val_13;
        string val_14;
        UnityEngine.Object val_15;
        string val_16;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.DefinedLevels = null;
        this.DefinedWords = null;
        string val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>().PathToGameResources;
        val_14 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        string val_4 = GetLevelCurveSubPath(lang:  lang, bucket:  -1930531024);
        string val_5 = val_14 + -539755392(-539755392) + "A";
        string val_6 = val_14 + 101608064;
        object val_7 = UnityEngine.Resources.Load<System.Object>(path:  val_14);
        val_15 = val_14;
        if(val_15 == 0)
        {
                return;
        }
        
        string val_9 = val_15.text;
        object val_10 = MiniJSON.Json.Deserialize(json:  val_15);
        val_14 = 1152921504687730688;
        val_15 = 0;
        List.Enumerator<T> val_11 = GetEnumerator();
        label_17:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        val_16 = 0;
        if(val_13 != 0)
        {
                if(val_13 != null)
        {
            
        }
        else
        {
                val_16 = val_13;
        }
        
        }
        
        this.DefinedWords.Add(item:  val_16);
        this.DefinedLevels.Add(item:  0);
        goto label_17;
        label_11:
        Dispose();
    }
    private string GetLevelCurveSubPath(string lang, string bucket = "A")
    {
        var val_5;
        if((System.String.op_Inequality(a:  lang, b:  1800251696)) != false)
        {
                return System.String.Format(format:  1629069648, arg0:  1726392512, arg1:  lang);
        }
        
        if((System.String.op_Equality(a:  bucket, b:  -1930531024)) != false)
        {
                val_5 = "";
        }
        else
        {
                string val_3 = System.String.Format(format:  -132887888, arg0:  bucket);
            val_5 = "_{0}";
        }
        
        string val_4 = System.String.Format(format:  -132887808, arg0:  1726392512, arg1:  lang, arg2:  -132887888);
    }
    private void LoadCurrentDictionary()
    {
        int val_8;
        twelvegigs.sweepstakes.Distribution val_11;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_18;
        var val_19;
        var val_20;
        float val_21;
        float val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        int val_30;
        val_18 = null;
        val_18 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.CurrentRequiredDictionary = val_18;
        val_19 = 7;
        val_20 = 1152921504687730688;
        val_21 = 1152921510046811088;
        val_22 = 1152921511481194736;
        goto label_1;
        label_3:
        val_18 = this.CurrentRequiredDictionary;
        val_19 = 6;
        label_1:
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_18.Add(item:  80883712);
        if(val_19 != 0)
        {
            goto label_3;
        }
        
        val_23 = 1152921504882458624;
        if((CPlayerPrefs.HasKey(key:  101873136)) == false)
        {
            goto label_91;
        }
        
        string val_4 = CPlayerPrefs.GetString(key:  101873136, defaultValue:  1098586544);
        object val_5 = MiniJSON.Json.Deserialize(json:  101873136);
        if("wlg_crd" != 0)
        {
                if(null == null)
        {
            goto label_62;
        }
        
        }
        
        if("wlg_crd" != 0)
        {
                label_62:
        }
        
        val_24 = 0;
        List.Enumerator<T> val_6 = GetEnumerator();
        val_22 = 0;
        var val_21 = 0;
        val_20 = 1152921510382894416;
        val_21 = 1152921510046813136;
        label_33:
        if(MoveNext() == false)
        {
            goto label_15;
        }
        
        if(val_8 != 0)
        {
                val_25 = 0;
            val_26;
        }
        else
        {
                val_25 = 0;
            val_26;
        }
        
        List.Enumerator<T> val_9 = GetEnumerator();
        label_29:
        bool val_10 = MoveNext();
        if(val_10 == false)
        {
            goto label_24;
        }
        
        if(val_10 <= val_22)
        {
                var val_18 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_18 = val_18 + 0;
        (0 + 0) + 16.Add(item:  val_11);
        goto label_29;
        label_24:
        var val_19 = val_21;
        val_19 = val_19 + 1;
        mem2[0] = 170;
        Dispose();
        if(val_19 != 1)
        {
                if(val_19 > 1)
        {
                0 = 1;
        }
        
            var val_20 = 101897480 + ((0 + 1)) << 2;
            val_20 = val_20 - 170;
            val_20 = val_20 >> 5;
            val_20 = 1 & val_20;
            val_19 = val_19 - val_20;
        }
        
        val_22 = val_22 + 1;
        goto label_33;
        label_15:
        val_21 = val_21 + 1;
        mem2[0] = 199;
        val_23 = 1152921504882458624;
        Dispose();
        if(val_21 != 1)
        {
                if(val_21 > 1)
        {
                0 = 1;
        }
        
            var val_22 = 101897480 + ((0 + 1)) << 2;
            val_22 = val_22 - 199;
            val_22 = val_22 >> 5;
            val_22 = 1 & val_22;
            val_21 = val_21 - val_22;
        }
        
        label_91:
        val_28 = "wlg_ula";
        if((CPlayerPrefs.HasKey(key:  101877328)) == false)
        {
                return;
        }
        
        this.UnlocksAdded.Clear();
        string val_13 = CPlayerPrefs.GetString(key:  101877328, defaultValue:  1098586544);
        object val_14 = MiniJSON.Json.Deserialize(json:  101877328);
        val_28 = 1152921504687730688;
        if("wlg_ula" != 0)
        {
                if(null == null)
        {
            goto label_63;
        }
        
        }
        
        if("wlg_ula" != 0)
        {
                label_63:
        }
        
        val_29 = 0;
        List.Enumerator<T> val_15 = GetEnumerator();
        val_20 = 1152921510382894416;
        val_21 = 1152921504619999232;
        val_22 = 1152921510720759024;
        label_60:
        if(MoveNext() == false)
        {
            goto label_55;
        }
        
        val_30 = 0;
        this.UnlocksAdded.Add(item:  null);
        goto label_60;
        label_55:
        Dispose();
        if(0 == 0)
        {
                return;
        }
        
        return;
        label_92:
        val_27 = ;
        if(null != 1)
        {
            goto label_89;
        }
        
        if(null == 0)
        {
            goto label_90;
        }
        
        goto label_91;
        label_90:
        mem[4] = null;
        goto label_92;
        label_89:
    }
    private void SaveCurrentDictionary()
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  this.CurrentRequiredDictionary);
        CPlayerPrefs.SetString(key:  101873136, val:  this.CurrentRequiredDictionary);
        string val_2 = MiniJSON.Json.Serialize(obj:  this.UnlocksAdded);
        CPlayerPrefs.SetString(key:  101877328, val:  this.UnlocksAdded);
    }
    private void AddNewUnlocks()
    {
        var val_3;
        var val_4;
        var val_5;
        System.Collections.Generic.List<System.Int32> val_6;
        val_3 = 0;
        val_4 = 1152921504892043264;
        val_5 = 1152921511098470640;
        goto label_1;
        label_20:
        Player val_1 = App.Player;
        val_6 = 0;
        if(0 <= val_3)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        if(val_6 < ((0 + 0) + 16))
        {
                return;
        }
        
        val_6 = this.UnlocksAdded;
        bool val_2 = val_6.Contains(item:  0);
        if(val_2 != true)
        {
                var val_6 = 7;
            do
        {
            var val_3 = val_6 - 4;
            if(val_2 <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= val_3)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_5 = val_5 + 0;
            if(((0 + 0) + 16 + 12) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            52.AddRange(collection:  (0 + 0) + 16 + 8 + 28);
            val_6 = val_6 + 1;
        }
        while(val_6 != 12);
        
            val_6 = this.UnlocksAdded;
            val_6.Add(item:  0);
            val_4 = 1152921504892043264;
            val_5 = 1152921511098470640;
        }
        
        val_3 = 1;
        label_1:
        if(val_3 < val_6)
        {
            goto label_20;
        }
    
    }
    public int GetAllPossibleWordsCount()
    {
        var val_5;
        WordLevelGen val_7;
        int val_9;
        val_7 = this;
        val_9 = this.allPossibleWords;
        if(val_9 > 0)
        {
                return (int)val_9;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        List.Enumerator<T> val_4 = GetEnumerator();
        goto label_6;
        label_7:
        if(val_5 != 0)
        {
                int val_8 = 0;
            val_8 = (val_5 + 12) + val_8;
        }
        
        label_6:
        if(MoveNext() == true)
        {
            goto label_7;
        }
        
        var val_7 = 0 + 1;
        mem2[0] = 92;
        Dispose();
        if(val_7 == 1)
        {
            goto label_10;
        }
        
        if((1152921513299107240 + ((0 + 1)) << 2) == 92)
        {
                1152921513299107240 + ((0 + 1)) << 2 = val_7 >> 31;
            1152921513299107240 + ((0 + 1)) << 2 = ~(val_7 >> 31);
            val_7 = val_7 + (1152921513299107240 + ((0 + 1)) << 2);
        }
        
        goto label_10;
        label_3:
        Dispose();
        this.allPossibleWords = val_8;
        val_9 = val_8;
        return (int)val_9;
    }
    public int GetPossibleWordsCount(int numLetters)
    {
        var val_2;
        var val_4;
        var val_5;
        val_4 = 35636615;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_5 = 0;
        goto label_5;
        label_8:
        if(val_2 != 0)
        {
                if((val_2 + 12) <= numLetters)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_4 = val_2 + 8;
            val_4 = val_4 + (numLetters << 2);
            val_4 = mem[(val_2 + 8 + (numLetters) << 2) + 16];
            val_4 = (val_2 + 8 + (numLetters) << 2) + 16;
            if(val_4 != 0)
        {
                if((val_2 + 12) <= numLetters)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_5 = val_2 + 8;
            val_5 = val_5 + (numLetters << 2);
            val_4 = mem[(val_2 + 8 + (numLetters) << 2) + 16];
            val_4 = (val_2 + 8 + (numLetters) << 2) + 16;
            if(val_4 == 0)
        {
                val_4 = 0;
        }
        
        }
        
            val_5 = 0 + val_5;
        }
        
        }
        
        label_5:
        if(MoveNext() == true)
        {
            goto label_8;
        }
        
        Dispose();
        return (int)val_5;
    }
    public System.Collections.Generic.List<bool> GetAllowedLetters(int level, int lettersSize, System.Collections.Generic.List<string> lettersArray, System.Collections.Generic.List<int> indexes)
    {
        int val_21;
        var val_22;
        var val_23;
        System.Collections.Generic.List<System.Int32> val_24;
        var val_25;
        System.Collections.Generic.List<System.Int32> val_26;
        var val_27;
        System.Collections.Generic.List<System.Int32> val_28;
        var val_29;
        System.Collections.Generic.List<System.Int32> val_30;
        val_21 = lettersSize;
        System.Collections.Generic.List<System.Boolean> val_1 = new System.Collections.Generic.List<System.Boolean>();
        if(val_1 != 0)
        {
                Add(item:  false);
            Add(item:  false);
        }
        else
        {
                Add(item:  false);
            Add(item:  false);
        }
        
        Add(item:  false);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_22 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        if(ActivelyPlayingEventGameMode() == true)
        {
            goto label_42;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_22 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if((PlayingChallenge == true) || (WGFTUXManager.CanShow == false))
        {
            goto label_42;
        }
        
        WordRegion val_7 = WordRegion.instance;
        System.Collections.Generic.List<System.String> val_8 = 0.GetCompletedWords();
        val_22 = 0;
        if(0 == 0)
        {
            goto label_16;
        }
        
        label_42:
        if(val_21 < 1)
        {
                return;
        }
        
        do
        {
            Add(item:  true);
            val_21 = val_21 - 1;
        }
        while((new System.Collections.Generic.List<System.Boolean>()) != 0);
        
        return;
        label_16:
        GameBehavior val_10 = App.getBehavior;
        string val_11 = 0.GetCurrentLanguage();
        if((System.String.op_Equality(a:  null, b:  -2101987568)) == false)
        {
            goto label_24;
        }
        
        if(level <= 1)
        {
            goto label_25;
        }
        
        if(level != 2)
        {
            goto label_42;
        }
        
        val_23 = 4;
        val_24 = indexes;
        goto label_27;
        label_39:
        if(level <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_25 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_25 = val_25 + 10485772;
        bool val_13 = (0 + 10485772) + 16.Equals(value:  -1513226192);
        val_24 = indexes;
        if(val_13 == true)
        {
            goto label_32;
        }
        
        if(val_13 <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_26 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_26 = val_26 + 10485772;
        val_24 = indexes;
        if(((0 + 10485772) + 16.Equals(value:  -1439668112)) == false)
        {
            goto label_36;
        }
        
        label_32:
        set_Item(index:  val_21, value:  true);
        label_36:
        val_23 = 5;
        label_27:
        if((val_23 - 4) < val_1)
        {
            goto label_39;
        }
        
        return;
        label_24:
        if(level <= 1)
        {
            goto label_41;
        }
        
        if(level != 2)
        {
            goto label_42;
        }
        
        val_25 = 4;
        val_26 = indexes;
        goto label_43;
        label_55:
        if(level <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_27 = val_27 + 10485772;
        bool val_16 = (0 + 10485772) + 16.Equals(value:  -1513226272);
        val_26 = indexes;
        if(val_16 == true)
        {
            goto label_48;
        }
        
        if(val_16 <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_28 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28 + 10485772;
        val_26 = indexes;
        if(((0 + 10485772) + 16.Equals(value:  102558256)) == false)
        {
            goto label_52;
        }
        
        label_48:
        set_Item(index:  val_21, value:  true);
        label_52:
        val_25 = 5;
        label_43:
        if((val_25 - 4) < val_1)
        {
            goto label_55;
        }
        
        return;
        label_25:
        val_27 = 4;
        val_28 = indexes;
        goto label_57;
        label_69:
        if(level <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_29 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_29 = val_29 + 10485772;
        bool val_19 = (0 + 10485772) + 16.Equals(value:  -140077968);
        val_28 = indexes;
        if(val_19 == true)
        {
            goto label_62;
        }
        
        if(val_19 <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_30 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_30 = val_30 + 10485772;
        val_28 = indexes;
        if(((0 + 10485772) + 16.Equals(value:  -1513226272)) == false)
        {
            goto label_66;
        }
        
        label_62:
        set_Item(index:  val_21, value:  true);
        label_66:
        val_27 = 5;
        label_57:
        if((val_27 - 4) < val_1)
        {
            goto label_69;
        }
        
        return;
        label_41:
        val_29 = 4;
        val_30 = indexes;
        goto label_71;
        label_83:
        if(level <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_31 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_31 = val_31 + 10485772;
        bool val_22 = (0 + 10485772) + 16.Equals(value:  -1930531024);
        val_30 = indexes;
        if(val_22 == true)
        {
            goto label_76;
        }
        
        if(val_22 <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                var val_32 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_32 = val_32 + 10485772;
        val_30 = indexes;
        if(((0 + 10485772) + 16.Equals(value:  -366896400)) == false)
        {
            goto label_80;
        }
        
        label_76:
        set_Item(index:  val_21, value:  true);
        label_80:
        val_29 = 5;
        label_71:
        if((val_29 - 4) < val_1)
        {
            goto label_83;
        }
    
    }
    public System.Collections.Generic.List<int> GetIndexesForTutorialLevel(int level, int lettersSize, System.Collections.Generic.List<string> lettersArray)
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        int val_18;
        var val_19;
        var val_20;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if(null != 0)
        {
                Add(item:  0);
            Add(item:  1);
        }
        else
        {
                Add(item:  0);
            Add(item:  1);
        }
        
        Add(item:  2);
        GameBehavior val_2 = App.getBehavior;
        string val_3 = 0.GetCurrentLanguage();
        if((System.String.op_Equality(a:  null, b:  -2101987568)) == false)
        {
            goto label_7;
        }
        
        if(level <= 1)
        {
            goto label_8;
        }
        
        if(level != 2)
        {
            goto label_15;
        }
        
        val_14 = 1152921513056828048;
        val_15 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -1439668112));
        val_16 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_17 = "U";
        goto label_13;
        label_7:
        if(level <= 1)
        {
            goto label_14;
        }
        
        if(level != 2)
        {
            goto label_15;
        }
        
        val_15 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  102558256));
        val_18 = lettersArray.IndexOf(item:  -1513226272);
        set_Item(index:  1, value:  val_18);
        val_19 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_20 = "N";
        goto label_27;
        label_8:
        val_15 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -1513226272));
        val_18 = lettersArray.IndexOf(item:  -140077968);
        set_Item(index:  1, value:  val_18);
        val_19 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_20 = "S";
        goto label_27;
        label_14:
        val_14 = 1152921513056828048;
        val_15 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -366896400));
        val_16 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_17 = "T";
        label_13:
        val_18 = lettersArray.IndexOf(item:  -1439668192);
        set_Item(index:  1, value:  val_18);
        val_20 = "A";
        label_27:
        set_Item(index:  2, value:  lettersArray.IndexOf(item:  -1930531024));
        return;
        label_15:
        System.Collections.Generic.List<System.Int32> val_13 = new System.Collections.Generic.List<System.Int32>();
        if(lettersSize < 1)
        {
                return;
        }
        
        var val_14 = 0;
        do
        {
            Add(item:  0);
            val_14 = val_14 + 1;
        }
        while(lettersSize != val_14);
    
    }
    public WordLevelGen()
    {
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if(val_1 != 0)
        {
                Add(item:  0);
            Add(item:  151);
            Add(item:  1001);
            Add(item:  6001);
        }
        else
        {
                Add(item:  0);
            Add(item:  151);
            Add(item:  1001);
            Add(item:  6001);
        }
        
        Add(item:  10000000);
        this.DictionaryUnlockLevels = val_1;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                Add(item:  102798720);
        }
        else
        {
                Add(item:  102798720);
        }
        
        Add(item:  102798816);
        if(null != 0)
        {
                Add(item:  102798912);
        }
        else
        {
                Add(item:  102798912);
        }
        
        Add(item:  102799008);
        Add(item:  102799104);
        this.DictionaryLoadPaths = null;
        this.UnlocksAdded = new System.Collections.Generic.List<System.Int32>();
        System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
        if(val_4 != 0)
        {
                Add(item:  8);
        }
        else
        {
                Add(item:  8);
        }
        
        Add(item:  15);
        this.LevelWordMaximums = val_4;
    }
    private static WordLevelGen()
    {
        WordLevelGen.LEVEL_GEN_VERSION = 18;
        WordLevelGen.chapter_lengths = null;
    }

}
