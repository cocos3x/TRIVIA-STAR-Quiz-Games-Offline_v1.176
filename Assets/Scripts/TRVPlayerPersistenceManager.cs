using UnityEngine;
public class TRVPlayerPersistenceManager
{
    // Fields
    private const string triviaPersistanceKey = "triviaCatProgress";
    private const string triviaAvailCategoriesKey = "trivialAvailCategories";
    private const string currentAnsReqIndexKey = "carqI";
    private const string currentAnsReqProgKey = "cqrP";
    private const string lastFreeLifeUsedKey = "lflu";
    private const string lastLevelRerollKey = "llrr";
    private const string currentOmmittedCategoriesKey = "coc";
    private const string earlyUnlockedCatsKey = "euc";
    private const string totalSeenQuestionsKey = "tots";
    private const string totalCorrectQuestionsKey = "totc";
    private const string streakKey = "trvStreak";
    private const string extraFreeLivesKey = "efl";
    private System.Collections.Generic.Dictionary<string, TRVSubCategoryProgress> catProgress;
    private TRVDataParser myParser;
    private System.Collections.Generic.List<string> availableCategories;
    private System.Collections.Generic.List<string> omittedCategories;
    private System.Collections.Generic.List<string> _earlyUnlockedCategories;
    private int lastRerollLevel;
    public int currentAnswerRequrementIndex;
    public int currentAnswerRequrementProgress;
    private System.DateTime lastFreeLifeUsed;
    private int totalSeenQuestions;
    private int totalCorrectQuestions;
    private int <currentStreak>k__BackingField;
    private int <extraFreeLives>k__BackingField;
    
    // Properties
    public System.Collections.Generic.List<string> getCurrentAvailableCategories { get; set; }
    public System.Collections.Generic.List<string> getOmittedCateogries { get; set; }
    public System.Collections.Generic.List<string> earlyUnlockedCategories { get; }
    public int getLastRerollLevel { get; set; }
    public System.DateTime freeLifeAvailableAt { get; }
    private int freeLifeCoolDownMinutes { get; }
    public int freeLifeCooldown { get; }
    public bool freeLifeAvailable { get; }
    public int TotalSeenQuestions { get; set; }
    public int TotalCorrectQuestions { get; set; }
    public int currentStreak { get; set; }
    public int extraFreeLives { get; set; }
    
    // Methods
    public System.Collections.Generic.List<string> get_getCurrentAvailableCategories()
    {
    
    }
    public void set_getCurrentAvailableCategories(System.Collections.Generic.List<string> value)
    {
        this.availableCategories = value;
        this.SaveProgress();
    }
    public System.Collections.Generic.List<string> get_getOmittedCateogries()
    {
    
    }
    public void set_getOmittedCateogries(System.Collections.Generic.List<string> value)
    {
        this.omittedCategories = value;
        this.SaveProgress();
    }
    public System.Collections.Generic.List<string> get_earlyUnlockedCategories()
    {
    
    }
    public int get_getLastRerollLevel()
    {
        return (int)this.lastRerollLevel;
    }
    public void set_getLastRerollLevel(int value)
    {
        this.lastRerollLevel = value;
        this.SaveProgress();
    }
    public System.DateTime get_freeLifeAvailableAt()
    {
        int val_1 = this.freeLifeCoolDownMinutes;
        var val_2 = R1 + 40;
        System.DateTime val_3 = this.AddMinutes(value:  null);
        return new System.DateTime() {dateData = val_3.dateData};
    }
    private int get_freeLifeCoolDownMinutes()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return (int)mem[1152921512476916176];
        }
        
        return (int)mem[1152921512476916176];
    }
    public int get_freeLifeCooldown()
    {
        return this.freeLifeCoolDownMinutes;
    }
    public bool get_freeLifeAvailable()
    {
        ulong val_4;
        ulong val_6;
        var val_9 = 1;
        if((this.<extraFreeLives>k__BackingField) > 0)
        {
                return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_6}, t2:  new System.DateTime() {dateData = val_4});
        }
        
        System.DateTime val_1 = ServerHandler.ServerTime;
        int val_2 = val_1.dateData.freeLifeCoolDownMinutes;
        System.DateTime val_3 = AddMinutes(value:  null);
        return (bool)System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_6}, t2:  new System.DateTime() {dateData = val_4});
    }
    public int get_TotalSeenQuestions()
    {
        return (int)this.totalSeenQuestions;
    }
    public void set_TotalSeenQuestions(int value)
    {
        this.totalSeenQuestions = value;
    }
    public int get_TotalCorrectQuestions()
    {
        return (int)this.totalCorrectQuestions;
    }
    public void set_TotalCorrectQuestions(int value)
    {
        this.totalCorrectQuestions = value;
    }
    public int get_currentStreak()
    {
        return (int)this.<currentStreak>k__BackingField;
    }
    private void set_currentStreak(int value)
    {
        this.<currentStreak>k__BackingField = value;
    }
    public int get_extraFreeLives()
    {
        return (int)this.<extraFreeLives>k__BackingField;
    }
    public void set_extraFreeLives(int value)
    {
        this.<extraFreeLives>k__BackingField = value;
    }
    public TRVPlayerPersistenceManager(TRVDataParser parser)
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.lastRerollLevel = 0;
        this.omittedCategories = null;
        this.myParser = parser;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.catProgress = null;
        this.LoadProgress();
    }
    public void LoadProgress()
    {
        string val_12;
        UnityEngine.Material val_17;
        twelvegigs.sweepstakes.Distribution val_66;
        TRVPlayerPersistenceManager val_89;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_90;
        float val_92;
        var val_93;
        var val_95;
        var val_96;
        twelvegigs.sweepstakes.Distribution val_97;
        twelvegigs.sweepstakes.Distribution val_98;
        var val_99;
        val_89 = this;
        string val_1 = GetTriviaPersistanceKey();
        bool val_2 = CPlayerPrefs.HasKey(key:  -470604184);
        if(val_2 == false)
        {
            goto label_3;
        }
        
        string val_3 = val_2.GetTriviaPersistanceKey();
        string val_4 = CPlayerPrefs.GetString(key:  val_2, defaultValue:  1297836560);
        object val_5 = MiniJSON.Json.Deserialize(json:  val_2);
        if(val_2 == false)
        {
            goto label_8;
        }
        
        val_90 = val_2;
        goto label_10;
        label_3:
        val_90 = null;
        val_90 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_90 != 0)
        {
            goto label_10;
        }
        
        label_8:
        val_90 = null;
        val_90 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        label_10:
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_8 = this.myParser.getAllSubCategories;
        Dictionary.KeyCollection<TKey, TValue> val_9 = this.myParser.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_10 = GetEnumerator();
        var val_90 = 0;
        label_30:
        if(MoveNext() == false)
        {
            goto label_14;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_13 = this.myParser.getAllSubCategories;
        string val_14 = this.myParser.Item[val_12];
        List.Enumerator<T> val_15 = GetEnumerator();
        label_27:
        if(MoveNext() == false)
        {
            goto label_18;
        }
        
        TRVSubCategoryProgress val_18 = new TRVSubCategoryProgress();
        if((ContainsKey(key:  val_17)) != false)
        {
                string val_20 = Item[val_17];
            val_89 = val_89;
            string val_21 = ToString();
            bool val_22 = decode(data:  78753792);
        }
        
        if((mem[1152921512726189544].ContainsKey(key:  val_17)) == true)
        {
            goto label_27;
        }
        
        mem[1152921512726189544].Add(key:  val_17, value:  361766912);
        goto label_27;
        label_18:
        var val_24 = val_90 + 1;
        mem2[0] = 222;
        Dispose();
        if(val_24 == 1)
        {
            goto label_30;
        }
        
        if((-470604184 + ((0 + 1)) << 2) == 222)
        {
                -470604184 + ((0 + 1)) << 2 = val_24 >> 31;
            -470604184 + ((0 + 1)) << 2 = ~(val_24 >> 31);
            val_24 = val_24 + (-470604184 + ((0 + 1)) << 2);
        }
        
        goto label_30;
        label_14:
        val_90 = val_90 + 1;
        mem2[0] = 250;
        Dispose();
        if(val_90 != 1)
        {
                if(val_90 > 1)
        {
                0 = 1;
        }
        
            var val_91 = -470604184 + ((0 + 1)) << 2;
            val_91 = val_91 - 250;
            val_91 = val_91 >> 5;
            val_91 = 1 & val_91;
            val_92 = val_90 - val_91;
        }
        else
        {
                val_92 = 0;
        }
        
        System.Collections.Generic.List<System.String> val_25 = TRVPromoCategoriesHandler.GetSpecialCategoriesWithProgress();
        if((0 == 0) || (0 < 1))
        {
            goto label_59;
        }
        
        List.Enumerator<T> val_26 = GetEnumerator();
        label_57:
        if(MoveNext() == false)
        {
            goto label_48;
        }
        
        TRVSubCategoryProgress val_28 = new TRVSubCategoryProgress();
        if((ContainsKey(key:  val_17)) != false)
        {
                string val_30 = Item[val_17];
            string val_31 = ToString();
            bool val_32 = decode(data:  78753792);
        }
        
        if((mem[1152921512726189544].ContainsKey(key:  val_17)) == true)
        {
            goto label_57;
        }
        
        mem[1152921512726189544].Add(key:  val_17, value:  361766912);
        goto label_57;
        label_48:
        float val_92 = val_92;
        val_92 = val_92 + 1;
        mem2[0] = 382;
        Dispose();
        if(val_92 != 1)
        {
                if(val_92 > 1)
        {
                0 = 1;
        }
        
            var val_93 = -470604184 + ((val_92 + 1)) << 2;
            val_93 = val_93 - 382;
            val_93 = val_93 >> 5;
            val_93 = 1 & val_93;
            val_92 = val_92 - val_93;
        }
        else
        {
                val_92 = 0;
        }
        
        label_59:
        if((ContainsKey(key:  -470616784)) != false)
        {
                string val_35 = Item[-470616784];
            string val_36 = ToString();
            object val_37 = MiniJSON.Json.Deserialize(json:  78753792);
        }
        
        label_128:
        if(mem[1152921512726189552] != 0)
        {
                mem[1152921512726189552] = mem[mem[1152921512726189552] + 12];
            mem[1152921512726189552] = mem[1152921512726189552] + 12;
            goto label_67;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_38 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem[1152921512726189552] = null;
        label_67:
        if((ContainsKey(key:  -470616672)) != false)
        {
                string val_40 = Item[-470616672];
            string val_41 = ToString();
            bool val_43 = System.Int32.TryParse(s:  78753792, result: out  int val_42 = -470592000);
        }
        
        if((ContainsKey(key:  -470616592)) != false)
        {
                string val_45 = Item[-470616592];
            string val_46 = ToString();
            bool val_48 = System.Int32.TryParse(s:  78753792, result: out  int val_47 = -470591996);
        }
        
        if((ContainsKey(key:  -470616512)) != false)
        {
                string val_50 = Item[-470616512];
            string val_51 = ToString();
            if((System.DateTime.TryParse(s:  78753792, result: out  new System.DateTime() {dateData = 1152921512726189576})) != true)
        {
                val_93 = null;
            val_93 = null;
            mem[1152921512726189576] = System.DateTime.MinValue;
        }
        
        }
        
        if((ContainsKey(key:  -470616432)) != false)
        {
                string val_54 = Item[-470616432];
            string val_55 = ToString();
            bool val_57 = System.Int32.TryParse(s:  78753792, result: out  int val_56 = -470592004);
            if(val_57 == false)
        {
                val_57 = 0;
            mem[1152921512726189564] = val_57;
        }
        
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_58 = null;
        val_95 = 1152921510046811088;
        val_58 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem[1152921512726189556] = val_58;
        mem[1152921512726189560] = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if((ContainsKey(key:  -470616352)) == false)
        {
            goto label_141;
        }
        
        string val_61 = Item[-470616352];
        string val_62 = ToString();
        object val_63 = MiniJSON.Json.Deserialize(json:  78753792);
        if(val_90 == 0)
        {
            goto label_141;
        }
        
        val_95 = mem[null + 180];
        List.Enumerator<T> val_64 = GetEnumerator();
        val_96 = 1152921510382894416;
        val_92 = 1152921504622235648;
        label_102:
        if(MoveNext() == false)
        {
            goto label_97;
        }
        
        val_97 = 0;
        if(val_66 != 0)
        {
                if(val_66 != null)
        {
            
        }
        else
        {
                val_97 = val_66;
        }
        
        }
        
        Add(item:  val_97);
        goto label_102;
        label_109:
        if(MoveNext() == false)
        {
            goto label_104;
        }
        
        val_98 = 0;
        if(val_66 != 0)
        {
                if(val_66 != null)
        {
            
        }
        else
        {
                val_98 = val_66;
        }
        
        }
        
        Add(item:  val_98);
        goto label_109;
        label_97:
        Dispose();
        label_141:
        if((ContainsKey(key:  -470616272)) != false)
        {
                string val_71 = Item[-470616272];
            string val_72 = ToString();
            bool val_74 = System.Int32.TryParse(s:  78753792, result: out  int val_73 = -470591984);
        }
        
        if((ContainsKey(key:  -470616192)) != false)
        {
                string val_76 = Item[-470616192];
            string val_77 = ToString();
            bool val_79 = System.Int32.TryParse(s:  78753792, result: out  int val_78 = -470591980);
        }
        
        val_99 = 0;
        if((ContainsKey(key:  -564123776)) != false)
        {
                string val_81 = Item[-564123776];
            string val_82 = ToString();
            bool val_84 = System.Int32.TryParse(s:  78753792, result: out  int val_83 = -470604124);
            val_99 = 0;
        }
        
        mem[1152921512726189592] = val_99;
        if((ContainsKey(key:  -470616112)) != false)
        {
                string val_86 = Item[-470616112];
            string val_87 = ToString();
            bool val_89 = System.Int32.TryParse(s:  78753792, result: out  int val_88 = -470604128);
            mem[1152921512726189596] = 0;
        }
        
        this.SaveProgress();
        return;
        label_104:
        float val_94 = val_92;
        val_94 = val_94 + 1;
        mem2[0] = 511;
        Dispose();
        if(val_94 == 1)
        {
            goto label_128;
        }
        
        if(val_94 > 1)
        {
                0 = 1;
        }
        
        var val_95 = -470604184 + ((val_92 + 1)) << 2;
        val_95 = val_95 - 511;
        val_95 = val_95 >> 5;
        val_95 = 1 & val_95;
        val_94 = val_94 - val_95;
        goto label_128;
    }
    public void SaveProgress()
    {
        string val_6;
        string val_11;
        ulong val_35;
        ulong val_37;
        var val_41;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_2 = this.myParser.getAllSubCategories;
        Dictionary.KeyCollection<TKey, TValue> val_3 = this.myParser.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        label_18:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_7 = this.myParser.getAllSubCategories;
        string val_8 = this.myParser.Item[val_6];
        List.Enumerator<T> val_9 = GetEnumerator();
        label_15:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((this.catProgress.ContainsKey(key:  val_11)) != true)
        {
                TRVSubCategoryProgress val_13 = new TRVSubCategoryProgress();
            this.catProgress.Add(key:  val_11, value:  361766912);
        }
        
        TRVSubCategoryProgress val_14 = this.catProgress.Item[val_11];
        string val_15 = this.catProgress.encode();
        Add(key:  val_11, value:  this.catProgress);
        goto label_15;
        label_8:
        var val_16 = 0 + 1;
        mem2[0] = 168;
        Dispose();
        if(val_16 == 1)
        {
            goto label_18;
        }
        
        if((-470442016 + ((0 + 1)) << 2) == 168)
        {
                val_16 = val_16 >> 31;
            val_16 = ~(val_16 >> 31);
            val_16 = val_16 + val_16;
        }
        
        goto label_18;
        label_4:
        var val_41 = 0;
        val_41 = val_41 + 1;
        mem2[0] = 196;
        Dispose();
        if(val_41 != 1)
        {
                if(val_41 > 1)
        {
                0 = 1;
        }
        
            var val_42 = -470442016 + ((0 + 1)) << 2;
            val_42 = val_42 - 196;
            val_42 = val_42 >> 5;
            val_42 = 1 & val_42;
            val_41 = val_41 - val_42;
        }
        else
        {
                val_41 = 0;
        }
        
        System.Collections.Generic.List<System.String> val_17 = TRVPromoCategoriesHandler.GetSpecialCategoriesWithProgress();
        if((0 == 0) || (0 < 1))
        {
            goto label_74;
        }
        
        List.Enumerator<T> val_18 = GetEnumerator();
        label_42:
        if(MoveNext() == false)
        {
            goto label_35;
        }
        
        if((this.catProgress.ContainsKey(key:  val_11)) != true)
        {
                TRVSubCategoryProgress val_21 = new TRVSubCategoryProgress();
            this.catProgress.Add(key:  val_11, value:  361766912);
        }
        
        TRVSubCategoryProgress val_22 = this.catProgress.Item[val_11];
        string val_23 = this.catProgress.encode();
        Add(key:  val_11, value:  this.catProgress);
        goto label_42;
        label_35:
        Dispose();
        label_74:
        Add(key:  -470616432, value:  13152256);
        string val_24 = MiniJSON.Json.Serialize(obj:  this.availableCategories);
        Add(key:  -470616784, value:  this.availableCategories);
        string val_25 = this.lastFreeLifeUsed.ToString();
        Add(key:  -470616512, value:  this.lastFreeLifeUsed);
        string val_26 = MiniJSON.Json.Serialize(obj:  this._earlyUnlockedCategories);
        Add(key:  -470616352, value:  this._earlyUnlockedCategories);
        Add(key:  -470616112, value:  13152256);
        Add(key:  -470616272, value:  13152256);
        Add(key:  -470616192, value:  13152256);
        Add(key:  -564123776, value:  13152256);
        string val_27 = GetTriviaPersistanceKey();
        string val_28 = MiniJSON.Json.Serialize(obj:  78753792);
        CPlayerPrefs.SetString(key:  78753792, val:  78753792);
        CPlayerPrefs.Save();
        System.DateTime val_29 = ServerHandler.ServerTime;
        System.DateTime val_32 = AddMinutes(value:  null);
        int val_33 = val_32.dateData.freeLifeCoolDownMinutes;
        System.DateTime val_34 = AddMinutes(value:  null);
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_37}, t2:  new System.DateTime() {dateData = val_35})) == false)
        {
                return;
        }
        
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  25);
    }
    public void AddFreeLife(bool addExtraLife = False)
    {
        var val_2;
        bool val_1 = this.freeLifeAvailable;
        if(addExtraLife != false)
        {
                int val_2 = this.<extraFreeLives>k__BackingField;
            val_2 = val_2 + 1;
            this.<extraFreeLives>k__BackingField = val_2;
        }
        else
        {
                val_2 = null;
            val_2 = null;
            this.lastFreeLifeUsed = System.DateTime.MinValue;
            System.DateTime.MinValue.UpdateExtraLifeNotification(newUsedAt:  new System.DateTime() {dateData = 1152921504616755200});
        }
        
        this.SaveProgress();
    }
    public void UseFreeLife(System.DateTime usedAtTime)
    {
        int val_1 = this.<extraFreeLives>k__BackingField;
        if(val_1 >= 1)
        {
                val_1 = val_1 - 1;
            this.<extraFreeLives>k__BackingField = val_1;
        }
        else
        {
                this.lastFreeLifeUsed = new System.DateTime();
            mem[1152921512726616716] = R3;
            val_1.UpdateExtraLifeNotification(newUsedAt:  new System.DateTime() {dateData = R3});
        }
        
        this.SaveProgress();
    }
    public int TotalFreeLivesAvailable()
    {
        bool val_1 = this.freeLifeAvailable;
        val_1 = (this.<extraFreeLives>k__BackingField) + val_1;
        return (int)val_1;
    }
    public void UnlockCategoryEarly(string cat)
    {
        System.Collections.Generic.List<System.String> val_3 = this._earlyUnlockedCategories;
        if(val_3 == 0)
        {
                val_3 = null;
            val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._earlyUnlockedCategories = val_3;
            if(val_3 == 0)
        {
                val_3 = 0;
        }
        
        }
        
        if((val_3.Contains(item:  cat)) != false)
        {
                UnityEngine.Debug.LogError(message:  -469956704);
            return;
        }
        
        this._earlyUnlockedCategories.Add(item:  cat);
        this.SaveProgress();
    }
    public TRVSubCategoryProgress GetSubCatProgress(string subCategory)
    {
        var val_4;
        TRVSubCategoryProgress val_1 = null;
        val_4 = val_1;
        val_1 = new TRVSubCategoryProgress();
        if((this.catProgress.ContainsKey(key:  subCategory)) != false)
        {
                TRVSubCategoryProgress val_3 = this.catProgress.Item[subCategory];
            val_4 = this.catProgress;
            return;
        }
        
        this.catProgress.Add(key:  subCategory, value:  361766912);
    }
    public QuestionData GetQuestion(TRVSubCategoryData myData, string subCat, int desiredDifficulty, ref bool completedThisDifficulty)
    {
        int val_27;
        string val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        val_27 = desiredDifficulty;
        val_28 = subCat;
        val_29 = myData;
        TRVSubCategoryProgress val_1 = this.GetSubCatProgress(subCategory:  val_28);
        int val_2 = this.SeenQuestionsPerDifficulty(diff:  val_27);
        if((myData.questionData.ContainsKey(key:  val_27)) == false)
        {
            goto label_7;
        }
        
        System.Collections.Generic.List<QuestionData> val_4 = myData.questionData.Item[val_27];
        if(val_2 >= myData.questionData)
        {
            goto label_7;
        }
        
        System.Collections.Generic.List<QuestionData> val_5 = myData.questionData.Item[val_27];
        if(myData.questionData <= val_2)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_27 = val_27 + (val_2 << 2);
        val_30 = mem[(0 + (val_2) << 2) + 16];
        val_30 = (0 + (val_2) << 2) + 16;
        TRVSubCategoryProgress val_6 = this.GetSubCatProgress(subCategory:  val_28);
        if(this.catProgress == 0)
        {
            goto label_13;
        }
        
        val_31 = this.catProgress.Item[(0 + (val_2) << 2) + 16 + 16];
        goto label_14;
        label_7:
        Dictionary.KeyCollection<TKey, TValue> val_8 = myData.questionData.Keys;
        if((myData.questionData.Count > val_27) && ((myData.questionData.ContainsKey(key:  val_27 + 1)) != false))
        {
                CompanyDevices val_12 = CompanyDevices.Instance;
            if(0.CompanyDevice() != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = myData.subCategory;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            UnityEngine.Debug.LogErrorFormat(format:  -469648640, args:  472754880);
            val_28 = val_28;
        }
        
            val_32 = this;
        }
        else
        {
                CompanyDevices val_14 = CompanyDevices.Instance;
            if(0.CompanyDevice() != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = myData.subCategory;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            UnityEngine.Debug.LogErrorFormat(format:  -469644336, args:  472754880);
        }
        
            this.ResetSubCat(subcat:  val_28);
            val_32 = this;
        }
        
        val_30 = val_32;
        goto label_48;
        label_13:
        val_31 = 0.Item[(0 + (val_2) << 2) + 16 + 16];
        label_14:
        this.catProgress.set_Item(key:  (0 + (val_2) << 2) + 16 + 16, value:  val_31 + 1);
        TRVSubCategoryProgress val_18 = this.GetSubCatProgress(subCategory:  val_28);
        System.Collections.Generic.List<QuestionData> val_20 = myData.questionData.Item[val_27];
        if((this.catProgress.Item[(0 + (val_2) << 2) + 16 + 16]) == myData.questionData)
        {
                val_27 = completedThisDifficulty;
            myData.questionData = true;
            completedThisDifficulty = myData.questionData;
        }
        
        CompanyDevices val_21 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                val_27 = 1152921511111016832;
            typeof(System.Object[]).__il2cppRuntimeField_10 = myData.subCategory;
            val_29 = 1152921504619999232;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            TRVSubCategoryProgress val_23 = this.GetSubCatProgress(subCategory:  val_28);
            int val_24 = this.catProgress.Item[(0 + (val_2) << 2) + 16 + 16];
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            UnityEngine.Debug.LogErrorFormat(format:  -469627760, args:  472754880);
        }
        
        int val_28 = this.totalSeenQuestions;
        val_28 = val_28 + 1;
        this.totalSeenQuestions = val_28;
        this.SaveProgress();
        label_48:
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(val_30 != 0)
        {
                val_33 = mem[(0 + (val_2) << 2) + 16 + 12];
            val_33 = (0 + (val_2) << 2) + 16 + 12;
        }
        else
        {
                val_33 = 0;
        }
        
        UnityEngine.Sprite val_26 = GetQuestionImageFromID(subCategory:  null, questionID:  (0 + (val_2) << 2) + 16 + 8);
        mem2[0] = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
    }
    public void ResetSubCat(string subcat)
    {
        if((System.String.IsNullOrEmpty(value:  subcat)) == true)
        {
                return;
        }
        
        TRVSubCategoryProgress val_2 = R4.GetSubCatProgress(subCategory:  R5);
        if(R4 == 0)
        {
                return;
        }
        
        R4.ResetCat();
        R4.SaveProgress();
    }
    public int GetCrownsCollected()
    {
        var val_3;
        System.Func<TRVSubCategoryProgress, System.Int32> val_5;
        Dictionary.ValueCollection<TKey, TValue> val_1 = this.catProgress.Values;
        val_3 = null;
        val_3 = null;
        val_5 = TRVPlayerPersistenceManager.<>c.<>9__66_0;
        if(val_5 != 0)
        {
                return System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.catProgress, selector:  7720960);
        }
        
        val_5 = null;
        val_5 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVPlayerPersistenceManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3825638432));
        TRVPlayerPersistenceManager.<>c.<>9__66_0 = val_5;
        return System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.catProgress, selector:  7720960);
    }
    private void UpdateExtraLifeNotification(System.DateTime newUsedAt)
    {
        string val_5;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1953384384, value:  -469209696);
        int val_2 = freeLifeCoolDownMinutes;
        System.DateTime val_3 = AddMinutes(value:  null);
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  25, when:  new System.DateTime() {dateData = twelvegigs.plugins.LocalNotificationsPlugin.__il2cppRuntimeField_cctor_finished}, optMessage:  val_5, extraData:  "EXTRA LIFE AVAILABLE!");
    }
    public void Hack_SendExtraLifeNotif()
    {
        var val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        int val_4 = val_2.freeLifeCoolDownMinutes;
        val_4 = 0 - val_4;
        System.DateTime val_5 = AddMinutes(value:  null);
        System.DateTime val_8 = AddSeconds(value:  null);
        val_8.dateData.UpdateExtraLifeNotification(newUsedAt:  new System.DateTime() {dateData = 1152921512727696056});
    }
    private string GetTriviaPersistanceKey()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        if((0.Equals(value:  1800251696)) == false)
        {
                return System.String.Format(format:  -1645101696, arg0:  -468985488, arg1:  0);
        }
    
    }

}
