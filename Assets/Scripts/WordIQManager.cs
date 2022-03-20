using UnityEngine;
public class WordIQManager : MonoSingleton<WordIQManager>
{
    // Fields
    public const bool display_feature_complexities = False;
    private const string pref_word_history = "wiq_hist";
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> _WordHistory;
    private const string KEY_IS_FTUX_SEEN = "word_iq_is_ftux_seen";
    private System.Collections.Generic.List<string> cachedWordsToSend;
    private System.Collections.Generic.List<string> wordsBeingSent;
    private bool sendingWords;
    private string debug_populatedHistoryFromLevel;
    private string debug_actualWordHistory;
    private static string _debugLogHistory;
    protected System.Collections.Generic.Dictionary<int, float> CompensatedIQScoreBelow2502;
    
    // Properties
    public float PlayerIQ { get; set; }
    public int PlayerMilestone { get; }
    public bool IsFtuxSeen { get; set; }
    public static float BaseIQ { get; }
    private string pref_played_words_key { get; }
    private int MaxPredefinedLevels { get; }
    private float MaxNEWWORDIQCompensation { get; }
    private float LevelClearIQCompensation_a { get; }
    private float LevelClearIQCompensation_b { get; }
    private float BaseNewWordPoint { get; }
    private float LetterPoint { get; }
    private float NEWWORDMultiplier { get; }
    private float BaseClearPoints_min { get; }
    private float BaseClearPoints_max { get; }
    private float HighestComplexity { get; }
    private float MaxAdditionalClearPoints { get; }
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> WordHistory { get; set; }
    protected float[] Milestones { get; }
    
    // Methods
    public float get_PlayerIQ()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    public void set_PlayerIQ(float value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    public int get_PlayerMilestone()
    {
        return this.GetMilestone(iqPoints:  this.PlayerIQ);
    }
    public bool get_IsFtuxSeen()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -926232096, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void set_IsFtuxSeen(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -926232096, value:  value);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static float get_BaseIQ()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private string get_pref_played_words_key()
    {
    
    }
    private int get_MaxPredefinedLevels()
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
        if((public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance()) != 0)
        {
                return MaxPredefinedLevels;
        }
        
        return MaxPredefinedLevels;
    }
    private float get_MaxNEWWORDIQCompensation()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_LevelClearIQCompensation_a()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_LevelClearIQCompensation_b()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_BaseNewWordPoint()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_LetterPoint()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_NEWWORDMultiplier()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_BaseClearPoints_min()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_BaseClearPoints_max()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_HighestComplexity()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private float get_MaxAdditionalClearPoints()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> get_WordHistory()
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_5 = this._WordHistory;
        if(val_5 != 0)
        {
                return;
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -924547792)) != false)
        {
                string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -924547792, defaultValue:  -2040381152);
            object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -924547792);
            val_5 = "wiq_hist";
        }
        else
        {
                val_5 = null;
            val_5 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        }
        
        this._WordHistory = val_5;
    }
    private void set_WordHistory(System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> value)
    {
        this._WordHistory = value;
    }
    public override void InitMonoSingleton()
    {
        this.InitMonoSingleton();
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if((public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance()) != 0)
        {
            goto label_9;
        }
        
        }
        else
        {
                WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        }
        
        label_9:
        this.ManagePlayerData();
    }
    public IQGains CalculateCompletedLevelPoints(System.Collections.Generic.List<string> allValidWords, System.Collections.Generic.List<string> requiredWords, int numLetters, int totalInput, int highestConsecutiveValidInput)
    {
        var val_62;
        float val_63;
        var val_64;
        float val_66;
        float val_67;
        val_62 = numLetters;
        System.Collections.Generic.List<ZooTile> val_1 = new System.Collections.Generic.List<ZooTile>(collection:  allValidWords);
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  -924160736, method:  new IntPtr(3370778128));
        int val_3 = RemoveAll(match:  8040448);
        val_63 = 0f;
        float val_7 = BaseClearPoints_min;
        float val_9 = UnityEngine.Random.Range(min:  BaseClearPoints_max, max:  null);
        float val_61 = 0f;
        val_64 = allValidWords;
        goto label_7;
        label_11:
        if(0 >= allValidWords)
        {
            goto label_8;
        }
        
        label_12:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_61 = val_61 + (4.068864E+08f);
        label_7:
        if(requiredWords == 0)
        {
            goto label_11;
        }
        
        if(1 < 2621443)
        {
            goto label_12;
        }
        
        val_66 = val_61 / 2621443f;
        goto label_13;
        label_8:
        val_66 = val_61 / (1.094062E+09f);
        label_13:
        float val_10 = HighestComplexity;
        float val_62 = 7f;
        float val_63 = 6.078123E+07f;
        val_62 = val_66 / val_62;
        val_63 = ((float)val_62 / val_62) * val_63;
        val_63 = val_62 * val_63;
        float val_12 = UnityEngine.Mathf.Min(a:  val_63, b:  null);
        float val_64 = val_63;
        float val_13 = val_63.HighestComplexity;
        val_64 = val_64 / val_63;
        val_67 = val_63;
        float val_14 = val_67 / (float)totalInput;
        if(val_64 == 0)
        {
                val_67 = val_67;
        }
        
        val_67 = (float)highestConsecutiveValidInput / val_67;
        float val_65 = 0.5f;
        val_62 = val_14 + val_67;
        val_65 = val_62 * val_65;
        val_64 = val_64 * val_65;
        float val_15 = highestConsecutiveValidInput.MaxAdditionalClearPoints;
        int val_66 = highestConsecutiveValidInput;
        val_66 = val_64 * val_66;
        val_65 = val_66 + 1094062064;
        val_62 = val_65 + val_63;
        string val_16 = val_62.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        string val_17 = val_63.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        string val_18 = val_65.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        string val_19 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  80883712);
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_20 = val_63.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_20 = ;
        float val_21 = System.Object[].__il2cppRuntimeField_namespaze.BaseNewWordPoint;
        string val_22 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_24 = ;
        float val_23 = System.Object[].__il2cppRuntimeField_namespaze.LetterPoint;
        string val_24 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_28 = ;
        float val_25 = System.Object[].__il2cppRuntimeField_namespaze.NEWWORDMultiplier;
        string val_26 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_2C = ;
        string val_27 = val_65.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_30 = ;
        string val_28 = System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_34 = ;
        string val_29 = val_66.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_38 = ;
        string val_30 = System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_3C = ;
        float val_31 = System.Object[].__il2cppRuntimeField_namespaze.BaseClearPoints_min;
        string val_32 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_40 = ;
        float val_33 = System.Object[].__il2cppRuntimeField_namespaze.BaseClearPoints_max;
        string val_34 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_44 = ;
        string val_35 = val_66.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_48 = ;
        string val_36 = val_64.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_4C = ;
        string val_37 = val_65.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_50 = ;
        float val_38 = System.Object[].__il2cppRuntimeField_namespaze.MaxAdditionalClearPoints;
        string val_39 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_54 = ;
        string val_40 = val_64.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_58 = ;
        string val_41 = val_63.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_5C = ;
        float val_42 = System.Object[].__il2cppRuntimeField_namespaze.HighestComplexity;
        string val_43 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_60 = ;
        string val_44 = val_63.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_64 = ;
        string val_45 = numLetters.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_68 = ;
        string val_46 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_6C = ;
        string val_47 = val_66.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_70 = ;
        string val_49 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_74 = ;
        string val_50 = val_65.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_78 = ;
        string val_51 = val_14.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_7C = ;
        string val_52 = val_67.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_80 = ;
        string val_53 = val_14.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_84 = ;
        string val_54 = val_67.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_88 = ;
        string val_55 = totalInput.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_8C = ;
        string val_56 = val_67.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_90 = ;
        string val_57 = highestConsecutiveValidInput.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_94 = ;
        string val_58 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_98 = ;
        string val_59 = System.String.Format(format:  -924187120, args:  472754880);
        WordIQManager.DebugLog(logString:  -924187120);
        IQGains val_60 = new IQGains(levelClearPts:  System.Object[].__il2cppRuntimeField_namespaze.HighestComplexity, newWordPts:  null);
    }
    public void HandleLevelCompleted(System.Collections.Generic.List<string> allValidWords)
    {
        System.Collections.Generic.List<ZooTile> val_1 = new System.Collections.Generic.List<ZooTile>(collection:  allValidWords);
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  -924035424, method:  new IntPtr(3370906848));
        if(null != 0)
        {
                int val_3 = RemoveAll(match:  8040448);
        }
        else
        {
                int val_4 = RemoveAll(match:  8040448);
        }
        
        this.AddWordsToHistory(words:  80883712);
    }
    public bool IsNewWord(string word)
    {
        int val_6;
        var val_7;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_1 = this.WordHistory;
        val_6 = this;
        val_7 = 1;
        if((this.ContainsKey(key:  word.m_stringLength)) == false)
        {
                return (bool)val_7;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_3 = this.WordHistory;
        val_6 = word.m_stringLength;
        System.TimeType val_4 = this.Item[val_6];
        val_7 = (this.Contains(item:  word)) ^ 1;
        return (bool)val_7;
    }
    public int GetMilestone(float iqPoints)
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = 0;
        val_5 = 16;
        goto label_0;
        label_5:
        var val_1 = R4 + val_5;
        if(this > val_4)
        {
            goto label_2;
        }
        
        val_5 = 20;
        val_4 = 1;
        label_0:
        System.Single[] val_2 = val_1.Milestones;
        System.Single[] val_3 = val_1.Milestones;
        val_6 = mem[(R4 + val_5) + 12];
        val_6 = (R4 + val_5) + 12;
        if(val_4 < ((R4 + val_5) + 12))
        {
            goto label_5;
        }
        
        goto label_6;
        label_2:
        val_6 = val_4;
        label_6:
        val_6 = val_6 - 1;
        return (int)val_6;
    }
    public float GetMilestoneAmount(int milestoneIndex)
    {
        System.Single[] val_1 = this.Milestones;
        WordIQManager val_2 = this + (milestoneIndex << 2);
        return (float)S0;
    }
    public void Hack_AddIQ(float points)
    {
        bool val_6 = static_value_021FCCCE;
        if(val_6 != true)
        {
                val_6 = true;
        }
        
        float val_1 = this.PlayerIQ;
        uint val_6 = 1;
        val_6 = val_6 + R1;
        this.PlayerIQ = val_6;
        string val_2 = ???.ToString();
        float val_3 = ???.PlayerIQ;
        string val_4 = ???.ToString();
        string val_5 = System.String.Format(format:  -923581728, arg0:  -923569524, arg1:  -923569528);
        WordIQManager.DebugLog(logString:  -923581728);
    }
    public void Hack_SetIQ(float points)
    {
        bool val_4 = static_value_021FCCCF;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        this.PlayerIQ = points;
        float val_1 = this.PlayerIQ;
        string val_2 = val_4.ToString();
        string val_3 = System.String.Format(format:  -923469504, arg0:  -923457348);
        WordIQManager.DebugLog(logString:  -923469504);
    }
    public int GetTotalFoundWordsCount()
    {
        var val_4;
        val_4 = 0;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_1 = this.WordHistory;
        Dictionary.Enumerator<TKey, TValue> val_2 = val_4.GetEnumerator();
        goto label_2;
        label_4:
        val_4 = 0 + val_4;
        label_2:
        if(val_4.MoveNext() == true)
        {
            goto label_4;
        }
        
        val_4.Dispose();
        return (int)val_4;
    }
    public System.Collections.Generic.List<string> GetFoundWords(int numLetters)
    {
        System.Collections.Generic.List<ZooTile> val_7;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_1 = this.WordHistory;
        if((this.ContainsKey(key:  numLetters)) != false)
        {
                System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_3 = this.WordHistory;
            System.TimeType val_4 = this.Item[numLetters];
            val_7 = null;
            val_7 = new System.Collections.Generic.List<ZooTile>(collection:  -923218256);
            return;
        }
        
        val_7 = null;
        val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }
    public int GetTotalPossibleFoundWordsCount()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if((public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance()) != 0)
        {
                return GetAllPossibleWordsCount();
        }
        
            return GetAllPossibleWordsCount();
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance()) != 0)
        {
                return GetAllPossibleWordsCount();
        }
        
        return GetAllPossibleWordsCount();
    }
    public int GetPossibleWordsCount(int numLetters)
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            int val_3 = GetPossibleWordsCount(numLetters:  numLetters);
        }
        else
        {
                WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        }
        
        if((GetPossibleWordsCount(numLetters:  numLetters)) < 11)
        {
                return (int)val_6;
        }
        
        val_6 = 0;
        return (int)val_6;
    }
    public string DebugLogic()
    {
        null = null;
    }
    private void OnLevelsInitialized()
    {
        this.ManagePlayerData();
    }
    private void ManagePlayerData()
    {
        Player val_1 = App.Player;
        if(0 <= 1)
        {
                PlayerIQ = WordIQManager.BaseIQ;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_3 = this.WordHistory;
        int val_4 = this.Count;
        if(0 < 2)
        {
                return;
        }
        
        if(val_4 > 0)
        {
                return;
        }
        
        float val_5 = val_4.PlayerIQ;
        float val_6 = WordIQManager.BaseIQ;
    }
    private void SendWordHistoryToServer()
    {
        var val_6;
        System.Func<System.Collections.Generic.List<System.String>, System.Collections.Generic.IEnumerable<System.String>> val_8;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_1 = this.WordHistory;
        Dictionary.ValueCollection<TKey, TValue> val_2 = this.Values;
        val_6 = null;
        val_6 = null;
        val_8 = WordIQManager.<>c.<>9__57_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Func<ZooTile, System.String>(object:  WordIQManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3372398064));
            WordIQManager.<>c.<>9__57_0 = val_8;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_4 = System.Linq.Enumerable.SelectMany<System.Object, System.Object>(source:  -922542160, selector:  7720960);
        System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<System.Object>(source:  -922542160);
        this.SendWordsToServer(newWords:  -922542160);
    }
    private void SendWordsToServer(System.Collections.Generic.List<string> newWords)
    {
        twelvegigs.net.JsonApiRequester val_5;
        var val_6;
        val_5 = 35638487;
        this.MergeLists(existingList: ref  this.cachedWordsToSend, wordsToAdd:  newWords);
        if(this.sendingWords == true)
        {
                return;
        }
        
        this.sendingWords.MergeLists(existingList: ref  this.wordsBeingSent, wordsToAdd:  this.cachedWordsToSend);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -922441872, value:  this.wordsBeingSent);
        var val_5 = 22992414;
        val_5 = 12633644 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = App.networkManager;
        System.Action<System.Threading.Tasks.Task, System.Object> val_4 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -922416656, method:  new IntPtr(3372525504));
        val_5.DoPut(path:  -922440768, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false);
    }
    private void SyncWordHistoryWithServer()
    {
        var val_4;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_2 = App.Player;
        Add(key:  1618311216, value:  1835037);
        val_4 = null;
        val_4 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_3 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -922291344, method:  new IntPtr(3372650928));
        App.networkManager.DoPut(path:  -922440768, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false);
    }
    private void MergeLists(ref System.Collections.Generic.List<string> existingList, System.Collections.Generic.List<string> wordsToAdd)
    {
        var val_2;
        System.Collections.Generic.List<System.String> val_3;
        var val_4;
        val_2 = 4;
        goto label_1;
        label_8:
        val_3 = existingList;
        if(true <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = 2621443;
        bool val_1 = val_3.Contains(item:  2621443);
        if(val_1 != true)
        {
                val_3 = existingList;
            if(val_1 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_4 = 2621443;
            val_3.Add(item:  2621443);
        }
        
        val_2 = 5;
        label_1:
        if((val_2 - 4) < val_3)
        {
            goto label_8;
        }
    
    }
    private void RemoveWordsFromList(ref System.Collections.Generic.List<string> existingList, System.Collections.Generic.List<string> wordsToRemove)
    {
        var val_3;
        System.Collections.Generic.List<System.String> val_4;
        var val_5;
        val_3 = 4;
        goto label_1;
        label_8:
        val_4 = existingList;
        if(true <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = 2621443;
        bool val_1 = val_4.Contains(item:  2621443);
        if(val_1 != false)
        {
                val_4 = existingList;
            if(val_1 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_5 = 2621443;
        }
        
        val_3 = 5;
        label_1:
        if((val_3 - 4) < (val_4.Remove(item:  2621443)))
        {
            goto label_8;
        }
    
    }
    private void PopulateWordHistoryFromLevel(int playerLevel)
    {
        int val_18;
        var val_19;
        System.Func<System.String, System.Int32> val_21;
        var val_22;
        System.Func<System.Linq.IGrouping<System.Int32, System.String>, System.Int32> val_24;
        System.Func<System.Linq.IGrouping<System.Int32, System.String>, System.Collections.Generic.List<System.String>> val_26;
        val_18 = playerLevel;
        int val_3 = UnityEngine.Mathf.Min(a:  val_18, b:  new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>().MaxPredefinedLevels);
        if(val_3 >= 2)
        {
                var val_18 = 1;
            do
        {
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            GameLevel val_5 = GetGameLevel(playerLevel:  1, language:  1800251696, bucket:  -1930531024);
            typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            System.String[] val_6 = public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance().__il2cppRuntimeField_34.Split(separator:  478563824);
            val_18 = public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance().__il2cppRuntimeField_34;
            System.Collections.Generic.List<ZooTile> val_7 = new System.Collections.Generic.List<ZooTile>(collection:  val_18);
            AddRange(collection:  80883712);
            val_18 = val_18 + 1;
        }
        while(val_3 != val_18);
        
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_8 = System.Linq.Enumerable.Distinct<System.Object>(source:  80883712);
        val_19 = null;
        val_19 = null;
        val_21 = WordIQManager.<>c.<>9__65_0;
        if(val_21 == 0)
        {
                val_21 = null;
            val_21 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WordIQManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3373021424));
            WordIQManager.<>c.<>9__65_0 = val_21;
        }
        
        System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> val_10 = System.Linq.Enumerable.GroupBy<System.Object, System.Int32>(source:  80883712, keySelector:  7720960);
        val_22 = null;
        val_22 = null;
        val_24 = WordIQManager.<>c.<>9__65_1;
        if(val_24 == 0)
        {
                val_24 = null;
            val_24 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WordIQManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3373023472));
            val_22 = null;
            WordIQManager.<>c.<>9__65_1 = val_24;
        }
        
        val_22 = null;
        val_26 = WordIQManager.<>c.<>9__65_2;
        if(val_26 == 0)
        {
                val_26 = null;
            val_26 = new System.Func<ZooTile, System.String>(object:  WordIQManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3373025520));
            WordIQManager.<>c.<>9__65_2 = val_26;
        }
        
        System.Collections.Generic.Dictionary<TKey, TElement> val_13 = System.Linq.Enumerable.ToDictionary<System.Object, System.Int32, System.Object>(source:  80883712, keySelector:  7720960, elementSelector:  7720960);
        mem[1152921512274867068] = null;
        typeof(System.Object[]).__il2cppRuntimeField_10 = "Bucket ";
        Player val_14 = App.Player;
        typeof(System.Object[]).__il2cppRuntimeField_14 = 33449456;
        typeof(System.Object[]).__il2cppRuntimeField_18 = " Level ";
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = " ";
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_15 = this.WordHistory;
        string val_16 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -921914512);
        typeof(System.Object[]).__il2cppRuntimeField_24 = this;
        string val_17 = +472754880;
        mem[1152921512274867084] = null;
    }
    private float CalculateCompensatedIQ(int playerLevel)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_23;
        float val_24;
        val_23 = 35638492;
        if(playerLevel >= 2)
        {
                if(this.MaxPredefinedLevels >= playerLevel)
        {
            goto label_2;
        }
        
        }
        
        float val_2 = WordIQManager.BaseIQ;
        uint val_23 = 338231296;
        float val_3 = MaxNEWWORDIQCompensation;
        int val_4 = playerLevel - 1;
        val_23 = val_23 + 338231296;
        float val_5 = val_4.LevelClearIQCompensation_a;
        float val_6 = val_4.LevelClearIQCompensation_b;
        float val_24 = val_4;
        val_24 = val_24 + val_23;
        float val_7 = WordIQManager.BaseIQ;
        string val_8 = null.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        float val_9 = System.Object[].__il2cppRuntimeField_namespaze.MaxNEWWORDIQCompensation;
        string val_10 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        float val_11 = System.Object[].__il2cppRuntimeField_namespaze.LevelClearIQCompensation_a;
        string val_12 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        string val_13 = playerLevel.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_1C = ;
        float val_14 = System.Object[].__il2cppRuntimeField_namespaze.LevelClearIQCompensation_b;
        string val_15 = System.Object[].__il2cppRuntimeField_namespaze.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_20 = ;
        string val_16 = val_24.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_24 = ;
        string val_17 = System.String.Format(format:  -921826512, args:  472754880);
        WordIQManager.DebugLog(logString:  -921826512);
        val_24 = val_24;
        return (float)val_24;
        label_2:
        string val_18 = playerLevel.ToString();
        val_23 = this.CompensatedIQScoreBelow2502;
        float val_19 = val_23.Item[playerLevel];
        string val_20 = val_23.ToString();
        string val_21 = System.String.Format(format:  -921822000, arg0:  -921805716, arg1:  -921805724);
        WordIQManager.DebugLog(logString:  -921822000);
        float val_22 = this.CompensatedIQScoreBelow2502.Item[playerLevel];
        val_24 = this.CompensatedIQScoreBelow2502;
        return (float)val_24;
    }
    private void AddWordsToHistory(System.Collections.Generic.List<string> words)
    {
        var val_1 = 0;
        goto label_1;
        label_4:
        if(true <= val_1)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + 0;
        this.AddWordToHistory(word:  (0 + 0) + 16);
        val_1 = 1;
        label_1:
        if(val_1 < this)
        {
            goto label_4;
        }
        
        this.SaveWordHistory();
    }
    private void AddWordToHistory(string word)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_1 = this.WordHistory;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_3 = this.WordHistory;
        if((this.ContainsKey(key:  word.m_stringLength)) == false)
        {
            goto label_3;
        }
        
        System.TimeType val_4 = this.Item[word.m_stringLength];
        if((this.Contains(item:  word)) == false)
        {
            goto label_6;
        }
        
        return;
        label_3:
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  word);
        this.Add(key:  word.m_stringLength, value:  80883712);
        return;
        label_6:
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_7 = this.WordHistory;
        System.TimeType val_8 = this.Item[word.m_stringLength];
        this.Add(item:  word);
    }
    private void SaveWordHistory()
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = "Level ";
        Player val_1 = App.Player;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = " ";
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_2 = this.WordHistory;
        string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -921432000, formatting:  1);
        typeof(System.Object[]).__il2cppRuntimeField_1C = this;
        string val_4 = +472754880;
        this.debug_actualWordHistory = null;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_5 = this.WordHistory;
        string val_6 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -921432000);
        UnityEngine.PlayerPrefs.SetString(key:  -924547792, value:  -921432000);
        bool val_7 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public string Debug_PopulatedHistoryFromLevel()
    {
    
    }
    public string Debug_ActualWordHistory()
    {
    
    }
    public static void DebugLog(string logString)
    {
        var val_4;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        string val_3 = WordIQManager._debugLogHistory + R4 + 1269544832;
        WordIQManager._debugLogHistory = WordIQManager._debugLogHistory;
    }
    protected float[] get_Milestones()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return;
        }
    
    }
    public WordIQManager()
    {
        this.cachedWordsToSend = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.wordsBeingSent = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.debug_populatedHistoryFromLevel = "";
        this.debug_actualWordHistory = "";
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_3 = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
        Add(key:  2, value:  null);
    }
    private static WordIQManager()
    {
        WordIQManager._debugLogHistory = "";
    }
    private bool <CalculateCompletedLevelPoints>b__43_0(string p)
    {
        bool val_1 = this.IsNewWord(word:  p);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    private bool <HandleLevelCompleted>b__44_0(string p)
    {
        bool val_1 = this.IsNewWord(word:  p);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    private void <SendWordsToServer>b__61_0(string apicall, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_5;
        var val_6;
        System.Collections.Generic.List<System.String> val_7;
        var val_8;
        val_5 = 35638500;
        if(response == 0)
        {
            goto label_2;
        }
        
        val_5 = "success";
        if((response.ContainsKey(key:  1616271776)) == false)
        {
            goto label_2;
        }
        
        object val_2 = response.Item[1616271776];
        val_5 = null;
        response.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        val_6 = this;
        val_7 = this.wordsBeingSent;
        val_8 = 1152921512276414928;
        if(null == 0)
        {
            goto label_5;
        }
        
        this.RemoveWordsFromList(existingList: ref  System.Collections.Generic.List<System.String> val_3 = -920366640, wordsToRemove:  val_7);
        goto label_6;
        label_2:
        val_6 = this;
        val_7 = this.wordsBeingSent;
        val_8 = 1152921512276414928;
        label_5:
        this.MergeLists(existingList: ref  System.Collections.Generic.List<System.String> val_4 = -920366640, wordsToAdd:  val_7);
        label_6:
        val_7.Clear();
        this.sendingWords = false;
    }
    private void <SyncWordHistoryWithServer>b__62_0(string apicall, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_12;
        var val_13;
        var val_14;
        System.Func<System.Collections.Generic.List<System.String>, System.Collections.Generic.IEnumerable<System.String>> val_16;
        val_12 = 35638501;
        if(response == 0)
        {
                return;
        }
        
        val_12 = "word_history";
        if((response.ContainsKey(key:  -920254080)) == false)
        {
                return;
        }
        
        object val_2 = response.Item[-920254080];
        string val_3 = response.ToString();
        val_13 = 0;
        object val_4 = MiniJSON.Json.Deserialize(json:  response);
        if(response != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                response = 0;
        }
        
            val_13 = response;
        }
        
        this.AddWordsToHistory(words:  0);
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_5 = this.WordHistory;
        Dictionary.ValueCollection<TKey, TValue> val_6 = this.Values;
        val_14 = null;
        val_14 = null;
        val_16 = WordIQManager.<>c.<>9__62_1;
        if(val_16 == 0)
        {
                val_16 = null;
            val_16 = new System.Func<ZooTile, System.String>(object:  WordIQManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3374713312));
            WordIQManager.<>c.<>9__62_1 = val_16;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_8 = System.Linq.Enumerable.SelectMany<System.Object, System.Object>(source:  -920224864, selector:  7720960);
        val_12 = 1152921510531751312;
        System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<System.Object>(source:  -920224864);
        System.Collections.Generic.IEnumerable<TSource> val_10 = System.Linq.Enumerable.Except<System.Object>(first:  -920224864, second:  0);
        System.Collections.Generic.List<TSource> val_11 = System.Linq.Enumerable.ToList<System.Object>(source:  -920224864);
        if(this._WordHistory < 1)
        {
                return;
        }
        
        this.SendWordsToServer(newWords:  -920224864);
    }

}
