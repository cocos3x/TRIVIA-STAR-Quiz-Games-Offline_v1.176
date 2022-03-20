using UnityEngine;
public class TRVDataParser : MonoSingleton<TRVDataParser>
{
    // Fields
    public static string hackedAdjustCampaign;
    public static System.Collections.Generic.List<string> categoryNames;
    public static System.Collections.Generic.List<string> excludedCateogries;
    private static System.Collections.Generic.List<FeatureCategorySelectFunction> featureCategorySelectFunctions;
    private TRVSubCategoryDictionary currentCategories;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> cachedSubCategories;
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> <getFinishedSubCategories>k__BackingField;
    private int lastUpdatedSubCategoryLevel;
    private bool <ForceUpdateSubCategories>k__BackingField;
    private System.Collections.Generic.List<string> hackCategories;
    private bool hasInit;
    private TRVPlayerPersistenceManager <playerPersistance>k__BackingField;
    private TRVSubCategoryData <currentSubCategoryData>k__BackingField;
    private TRVEcon.TRVCategoryEcon currentCategoryEcon;
    private static string desiredLocale;
    private string QAHACK_currentHackedLocale;
    private TRVSubCategoryData lastRetrievedSubCatData;
    
    // Properties
    private int ftuxLevelLimit { get; }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> getAllSubCategories { get; }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> getFinishedSubCategories { get; set; }
    public bool ForceUpdateSubCategories { get; set; }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> getAvailableSubCategories { get; }
    public System.Collections.Generic.List<string> HackCategories { get; }
    public TRVPlayerPersistenceManager playerPersistance { get; set; }
    public TRVSubCategoryData currentSubCategoryData { get; set; }
    public System.Collections.Generic.Dictionary<int, int[]> getQuizDifficultyOrders { get; }
    private int[] initialQuizLengthArray { get; }
    private int[] quizLengthArray { get; }
    public System.Collections.Generic.Dictionary<string, int> CategoryUnlockLevels { get; }
    public static string CurrentDesiredLocale { get; }
    public string QAHACK_getCurrentCagetoryEconLocale { get; }
    private static string currentPlatform { get; }
    public static string PathToGameResources { get; }
    
    // Methods
    public static void AddCategorySelectFunction(FeatureCategorySelectFunction newfunction)
    {
        var val_6;
        var val_7;
        System.Predicate<FeatureCategorySelectFunction> val_9;
        var val_11;
        var val_12;
        System.Func<FeatureCategorySelectFunction, System.Int32> val_14;
        var val_15;
        val_6 = null;
        val_6 = null;
        TRVDataParser.featureCategorySelectFunctions.Add(item:  newfunction);
        val_7 = null;
        val_7 = null;
        val_9 = TRVDataParser.<>c.<>9__4_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Predicate<ZooTile>(object:  TRVDataParser.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3752596768));
            TRVDataParser.<>c.<>9__4_0 = val_9;
        }
        
        int val_2 = TRVDataParser.featureCategorySelectFunctions.RemoveAll(match:  8040448);
        val_11 = null;
        val_11 = null;
        val_12 = null;
        val_12 = null;
        val_14 = TRVDataParser.<>c.<>9__4_1;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVDataParser.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3752599840));
            TRVDataParser.<>c.<>9__4_1 = val_14;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_4 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  TRVDataParser.featureCategorySelectFunctions, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<System.Object>(source:  TRVDataParser.featureCategorySelectFunctions);
        val_15 = null;
        val_15 = null;
        TRVDataParser.featureCategorySelectFunctions = TRVDataParser.featureCategorySelectFunctions;
    }
    private int get_ftuxLevelLimit()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return (int)mem[1152921512476916184];
        }
        
        return (int)mem[1152921512476916184];
    }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> get_getAllSubCategories()
    {
        string val_1 = this.GetFormattedLangaugeAndLocale();
        if(this.currentCategories != 0)
        {
                return this.currentCategories.GetSubCategories(currentLocale:  -542107168);
        }
        
        return this.currentCategories.GetSubCategories(currentLocale:  -542107168);
    }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> get_getFinishedSubCategories()
    {
    
    }
    private void set_getFinishedSubCategories(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> value)
    {
        this.<getFinishedSubCategories>k__BackingField = value;
    }
    public bool get_ForceUpdateSubCategories()
    {
        return (bool)this.<ForceUpdateSubCategories>k__BackingField;
    }
    public void set_ForceUpdateSubCategories(bool value)
    {
        this.<ForceUpdateSubCategories>k__BackingField = value;
    }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> get_getAvailableSubCategories()
    {
        string val_5;
        string val_12;
        var val_20;
        var val_21;
        Player val_1 = App.Player;
        if(false == this.lastUpdatedSubCategoryLevel)
        {
                false = this.<ForceUpdateSubCategories>k__BackingField;
        }
        
        if(false == false)
        {
            goto label_4;
        }
        
        label_35:
        val_20 = null;
        val_20 = null;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_25:
        label_12:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        val_21 = null;
        val_21 = null;
        if((TRVDataParser.excludedCateogries.Contains(item:  val_5)) == true)
        {
            goto label_12;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_8 = this.getAllSubCategories;
        string val_9 = this.Item[val_5];
        List.Enumerator<T> val_10 = GetEnumerator();
        label_20:
        if(MoveNext() == false)
        {
            goto label_15;
        }
        
        TRVSubCategoryProgress val_13 = this.<playerPersistance>k__BackingField.GetSubCatProgress(subCategory:  val_12);
        if((this.<playerPersistance>k__BackingField.currentAnswerRequrementIndex) != 0)
        {
            goto label_20;
        }
        
        Add(item:  val_12);
        goto label_20;
        label_15:
        var val_20 = 0;
        val_20 = val_20 + 1;
        mem2[0] = 179;
        Dispose();
        if(val_20 != 1)
        {
                var val_22 = val_20;
            var val_21 = -541522416 + ((0 + 1)) << 2;
            if(val_20 > 1)
        {
                0 = 1;
        }
        
            val_21 = val_21 - 179;
            val_21 = val_21 >> 5;
            val_21 = 1 & val_21;
            val_22 = val_22 - val_21;
        }
        
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_14 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  -541510304, method:  new IntPtr(3753421728));
        System.Collections.Generic.IEnumerable<TSource> val_15 = System.Linq.Enumerable.Where<System.Object>(source:  80883712, predicate:  7720960);
        System.Collections.Generic.List<TSource> val_16 = System.Linq.Enumerable.ToList<System.Object>(source:  80883712);
        System.Collections.Generic.List<ZooTile> val_17 = new System.Collections.Generic.List<ZooTile>(collection:  80883712);
        Add(key:  val_5, value:  80883712);
        goto label_25;
        label_8:
        Dispose();
        this.cachedSubCategories = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_18 = App.Player;
        this.lastUpdatedSubCategoryLevel = 0;
        this.<ForceUpdateSubCategories>k__BackingField = false;
        return;
        label_4:
        if(this.cachedSubCategories.Count < 1)
        {
            goto label_35;
        }
    
    }
    public bool IsValidSubCategory(string cat)
    {
        string val_5;
        string val_13;
        WADPets.WADPet val_15;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_15 = cat;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = this.CategoryUnlockLevels;
        if((this.ContainsKey(key:  val_15)) == false)
        {
            goto label_2;
        }
        
        val_17 = null;
        val_17 = null;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_27:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        if((System.String.op_Equality(a:  val_5, b:  -541405920)) == true)
        {
            goto label_27;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_7 = this.getAllSubCategories;
        if((this.ContainsKey(key:  val_5)) == true)
        {
            goto label_9;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_5;
        UnityEngine.Debug.LogErrorFormat(format:  -541405840, args:  472754880);
        goto label_27;
        label_9:
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_9 = this.getAllSubCategories;
        string val_10 = this.Item[val_5];
        List.Enumerator<T> val_11 = GetEnumerator();
        label_20:
        if(MoveNext() == false)
        {
            goto label_19;
        }
        
        if((System.String.op_Equality(a:  val_15, b:  val_13)) == false)
        {
            goto label_20;
        }
        
        val_18 = 0;
        val_19 = 1;
        goto label_30;
        label_19:
        val_18 = 0;
        val_19 = 0 + 1;
        mem2[0] = 173;
        label_30:
        Dispose();
        if(val_19 == 1)
        {
            goto label_27;
        }
        
        if((-541393432 + ((0 + 1)) << 2) == 173)
        {
            goto label_24;
        }
        
        if((-541393432 + ((0 + 1)) << 2) != 223)
        {
            goto label_27;
        }
        
        goto label_26;
        label_24:
        var val_15 = val_19 >> 31;
        var val_16 = ~(val_19 >> 31);
        val_16 = val_19 + val_16;
        goto label_27;
        label_2:
        val_20 = null;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_15;
        val_21 = "InValid SubCategory: Unlock Econ Not Contain {0}";
        goto label_37;
        label_6:
        val_15 = val_16 + 1;
        mem2[0] = 201;
        Dispose();
        val_22 = 1;
        if(val_15 != 1)
        {
                if((-541393432 + ((((0 + 1) + ~(((int)(0 + 1)) >> 31)) + 1)) << 2) == 223)
        {
                return false;
        }
        
        }
        
        val_20 = null;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_15;
        val_21 = "InValid SubCategory: getAllSubCategories Not Contain {0}";
        label_37:
        val_22 = 0;
        UnityEngine.Debug.LogErrorFormat(format:  -541405504, args:  472754880);
        return false;
        label_26:
        Dispose();
        return false;
    }
    public System.Collections.Generic.List<string> get_HackCategories()
    {
        System.Collections.Generic.List<System.String> val_2 = this.hackCategories;
        if(val_2 != 0)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.hackCategories = null;
        var val_2 = 3;
        do
        {
            Add(item:  1098586544);
            val_2 = this.hackCategories;
            val_2 = val_2 - 1;
        }
        while(null != 0);
    
    }
    public TRVPlayerPersistenceManager get_playerPersistance()
    {
    
    }
    private void set_playerPersistance(TRVPlayerPersistenceManager value)
    {
        this.<playerPersistance>k__BackingField = value;
    }
    public TRVSubCategoryData get_currentSubCategoryData()
    {
    
    }
    private void set_currentSubCategoryData(TRVSubCategoryData value)
    {
        this.<currentSubCategoryData>k__BackingField = value;
    }
    public System.Collections.Generic.Dictionary<int, int[]> get_getQuizDifficultyOrders()
    {
        var val_6;
        Player val_1 = App.Player;
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(0 > mem[1152921512476916188])
        {
                WordForest.WFOGameEcon val_4 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            val_6 = 1152921512476916352;
            return;
        }
        
        WordForest.WFOGameEcon val_5 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_6 = 1152921512476916356;
    }
    private int[] get_initialQuizLengthArray()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return;
        }
    
    }
    private int[] get_quizLengthArray()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return;
        }
    
    }
    public override void InitMonoSingleton()
    {
        this.Init();
    }
    private void Init()
    {
        if(this.hasInit == true)
        {
                return;
        }
        
        R4.LoadInitialCategoryData();
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  R4, name:  1799422256);
        mem2[0] = 1;
    }
    private void Start()
    {
        this.<playerPersistance>k__BackingField = new TRVPlayerPersistenceManager(parser:  -540096064);
    }
    private void OnLocalize()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        if((this.currentCategories.language.Equals(value:  null)) != false)
        {
                return;
        }
        
        this.<ForceUpdateSubCategories>k__BackingField = true;
        this.<playerPersistance>k__BackingField.LoadProgress();
    }
    private void LoadInitialCategoryData()
    {
        string val_1 = this.GetFormattedLangaugeAndLocale();
        this.currentCategories = new TRVSubCategoryDictionary(currentLocale:  -539847488);
    }
    public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> LoadCategoryInfo(string currentLanguage)
    {
        WordPets.WPTLetterTile val_4;
        var val_13;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_13 = null;
        val_13 = null;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_45:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        string val_5 = TRVDataParser.PathToGameResources;
        typeof(System.String[]).__il2cppRuntimeField_10 = null;
        typeof(System.String[]).__il2cppRuntimeField_14 = "Levels/";
        typeof(System.String[]).__il2cppRuntimeField_18 = "android";
        typeof(System.String[]).__il2cppRuntimeField_1C = "/";
        typeof(System.String[]).__il2cppRuntimeField_20 = currentLanguage;
        typeof(System.String[]).__il2cppRuntimeField_24 = "/";
        typeof(System.String[]).__il2cppRuntimeField_28 = val_4;
        typeof(System.String[]).__il2cppRuntimeField_2C = "/";
        string val_6 = +477709520;
        T[] val_7 = UnityEngine.Resources.LoadAll<System.Object>(path:  477709520);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        var val_13 = 0;
        if(357187584 != 0)
        {
                string val_10 = name;
            if((System.String.IsNullOrEmpty(value:  357187584)) != true)
        {
                string val_12 = name;
            Add(item:  357187584);
        }
        
        }
        
        val_13 = val_13 + 1;
        Add(key:  val_4, value:  80883712);
        goto label_45;
        label_4:
        Dispose();
    }
    public TRVSubCategoryData LoadSubCategoryData(string subcategory, string primaryCategory = "")
    {
        string val_6;
        string val_16;
        var val_17;
        val_16 = primaryCategory;
        if((System.String.op_Equality(a:  val_16, b:  1098586544)) == false)
        {
            goto label_1;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_2 = this.getAllSubCategories;
        Dictionary.KeyCollection<TKey, TValue> val_3 = this.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        val_16 = val_6;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_7 = this.getAllSubCategories;
        string val_8 = this.Item[val_16];
        if((this.Contains(item:  subcategory)) == false)
        {
            goto label_7;
        }
        
        goto label_8;
        label_4:
        val_16 = val_16;
        label_8:
        Dispose();
        label_1:
        string val_10 = TRVDataParser.PathToGameResources;
        typeof(System.String[]).__il2cppRuntimeField_10 = null;
        var val_16 = 23366129;
        typeof(System.String[]).__il2cppRuntimeField_14 = "Levels/";
        val_16 = 12271708 + val_16;
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_18 = "android";
        typeof(System.String[]).__il2cppRuntimeField_1C = "/";
        typeof(System.String[]).__il2cppRuntimeField_20 = this.currentCategories.language;
        typeof(System.String[]).__il2cppRuntimeField_24 = "/";
        typeof(System.String[]).__il2cppRuntimeField_28 = val_16;
        typeof(System.String[]).__il2cppRuntimeField_2C = "/";
        typeof(System.String[]).__il2cppRuntimeField_30 = subcategory;
        string val_11 = +477709520;
        object val_12 = UnityEngine.Resources.Load<System.Object>(path:  477709520);
        if(477709520 == 0)
        {
                string val_14 = -539618720(-539618720) + val_16 + 1297836560 + subcategory;
            val_17 = 0;
            UnityEngine.Debug.LogError(message:  -539618720);
            return;
        }
        
        TRVSubCategoryData val_15 = null;
        val_17 = val_15;
        val_15 = new TRVSubCategoryData(unparsedData:  477709520, subCategoryName:  subcategory);
    }
    public System.Collections.Generic.Dictionary<string, int> get_CategoryUnlockLevels()
    {
        TRVDataParser val_8;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_9;
        var val_10;
        if((this.currentCategoryEcon == 0) || (this.currentCategoryEcon.categoryUnlockLevels.Count == 0))
        {
            goto label_3;
        }
        
        string val_2 = this.GetFormattedLangaugeAndLocale();
        val_8 = this;
        if((this.currentCategoryEcon.locale.Equals(value:  -539437392)) == true)
        {
            goto label_6;
        }
        
        label_3:
        string val_4 = this.GetFormattedLangaugeAndLocale();
        val_8 = this;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_8;
        UnityEngine.Debug.LogErrorFormat(format:  -1654632064, args:  472754880);
        string val_5 = this.GetFormattedLangaugeAndLocale();
        this.LoadCategoryEconData(desiredLocale:  -539437392);
        label_6:
        if(this.currentCategoryEcon != 0)
        {
                if(this.currentCategoryEcon.categoryUnlockLevels.Count != 0)
        {
                val_9 = this.currentCategoryEcon.categoryUnlockLevels;
            return;
        }
        
        }
        
        string val_7 = this.GetFormattedLangaugeAndLocale();
        typeof(System.Object[]).__il2cppRuntimeField_10 = this;
        UnityEngine.Debug.LogErrorFormat(format:  -539461536, args:  472754880);
        val_10 = null;
        val_10 = null;
        val_9 = 1152921504964571144;
    }
    private void LoadCategoryEconData(string desiredLocale)
    {
        TRVCategoryEcon val_8;
        string val_1 = TRVDataParser.PathToGameResources;
        typeof(System.String[]).__il2cppRuntimeField_10 = null;
        var val_8 = 23364785;
        typeof(System.String[]).__il2cppRuntimeField_14 = "Levels/";
        val_8 = 12273052 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_18 = "android";
        val_8 = "/CategoryEcons/";
        typeof(System.String[]).__il2cppRuntimeField_1C = val_8;
        typeof(System.String[]).__il2cppRuntimeField_20 = desiredLocale;
        string val_2 = +477709520;
        object val_3 = UnityEngine.Resources.Load<System.Object>(path:  477709520);
        if(477709520 == 0)
        {
                return;
        }
        
        string val_5 = text;
        if((System.String.IsNullOrEmpty(value:  477709520)) == true)
        {
                return;
        }
        
        TRVEcon.TRVCategoryEcon val_7 = null;
        val_8 = val_7;
        val_7 = new TRVEcon.TRVCategoryEcon(categoryEconData:  477709520, localeName:  desiredLocale);
        this.currentCategoryEcon = val_8;
    }
    public static string get_CurrentDesiredLocale()
    {
        null = null;
    }
    private string GetFormattedLangaugeAndLocale()
    {
        var val_12;
        string val_13;
        var val_14;
        var val_15;
        if((System.String.IsNullOrEmpty(value:  this.QAHACK_currentHackedLocale)) == false)
        {
            goto label_1;
        }
        
        if(Localization.GAME_NAME == 0)
        {
            goto label_5;
        }
        
        if(Localization.GAME_NAME != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_1:
        val_13 = this.QAHACK_currentHackedLocale;
        return;
        label_5:
        val_12 = "en";
        label_8:
        string val_3 = DeviceProperties.LocaleFromDevice;
        if((0.Contains(value:  1359327184)) != false)
        {
                typeof(System.Char[]).__il2cppRuntimeField_10 = 45;
            System.String[] val_5 = 0.Split(separator:  478563824);
            val_14 = 0 + 20;
        }
        else
        {
                val_14 = "US";
        }
        
        string val_6 = System.String.Format(format:  -1655001648, arg0:  1800251696, arg1:  -1655001728);
        string val_7 = ToLower();
        val_13 = "{0}-{1}";
        System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(357240832)});
        string val_9 = Replace(oldValue:  1359327184, newValue:  2144339952);
        if((System.Enum.IsDefined(enumType:  357240832, value:  -1655001648)) != true)
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = val_13;
            UnityEngine.Debug.LogErrorFormat(format:  -1655001552, args:  472754880);
            if((StartsWith(value:  -2101987568)) == true)
        {
                "en-us" = "es-419";
        }
        
            val_13 = "es-419";
        }
        
        val_15 = null;
        val_15 = null;
        TRVDataParser.desiredLocale = val_13;
    }
    public string get_QAHACK_getCurrentCagetoryEconLocale()
    {
        if(this.currentCategoryEcon != 0)
        {
                "not set" = this.currentCategoryEcon.locale;
        }
    
    }
    public void QAHACK_setCurrentCategoryEcon(string formattedLanguageAndLocale)
    {
        this.currentCategoryEcon = 0;
        this.QAHACK_currentHackedLocale = formattedLanguageAndLocale;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.QAHACK_currentHackedLocale;
        UnityEngine.Debug.LogErrorFormat(format:  -1654632064, args:  472754880);
        this.LoadCategoryEconData(desiredLocale:  this.QAHACK_currentHackedLocale);
    }
    private static string get_currentPlatform()
    {
    
    }
    public static string get_PathToGameResources()
    {
        string val_1 = WordApp.GamePathName;
        return -1655690384(-1655690384) + null + 1115175264;
    }
    public int GetQuizLength()
    {
        var val_5;
        var val_6;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Boolean> val_8;
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = quizLength;
        val_6 = null;
        val_6 = null;
        val_8 = TRVDataParser.<>c.<>9__65_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Boolean>(object:  TRVDataParser.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3756488032));
            TRVDataParser.<>c.<>9__65_0 = val_8;
        }
        
        System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_4 = System.Linq.Enumerable.Last<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>(source:  -538464224, predicate:  -719866704);
        return (int)val_5;
    }
    public QuestionData GetQuestionFromID(string category, string subCategory, string questionID)
    {
        string val_9;
        TRVSubCategoryData val_10;
        var val_11;
        System.Func<System.Collections.Generic.List<QuestionData>, System.Collections.Generic.IEnumerable<QuestionData>> val_13;
        val_9 = questionID;
        object val_1 = new System.Object();
        typeof(TRVDataParser.<>c__DisplayClass67_0).__il2cppRuntimeField_8 = val_9;
        if(this.lastRetrievedSubCatData != 0)
        {
                if((System.String.op_Inequality(a:  this.lastRetrievedSubCatData.subCategory, b:  subCategory)) == false)
        {
            goto label_3;
        }
        
        }
        
        TRVSubCategoryData val_3 = this.LoadSubCategoryData(subcategory:  subCategory, primaryCategory:  1098586544);
        val_10 = this;
        this.lastRetrievedSubCatData = this;
        goto label_4;
        label_3:
        val_10 = this.lastRetrievedSubCatData;
        label_4:
        Dictionary.ValueCollection<TKey, TValue> val_4 = this.lastRetrievedSubCatData.questionData.Values;
        val_11 = null;
        val_11 = null;
        val_13 = TRVDataParser.<>c.<>9__67_0;
        if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new System.Func<ZooTile, System.String>(object:  TRVDataParser.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3756632800));
            TRVDataParser.<>c.<>9__67_0 = val_13;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_6 = System.Linq.Enumerable.SelectMany<System.Object, System.Object>(source:  this.lastRetrievedSubCatData.questionData, selector:  7720960);
        System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<System.Object>(source:  this.lastRetrievedSubCatData.questionData);
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_8 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  357400576, method:  new IntPtr(3756636896));
        return System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.lastRetrievedSubCatData.questionData, predicate:  7720960);
    }
    public UnityEngine.Sprite GetQuestionImageFromID(string subCategory, string questionID)
    {
        string val_11;
        var val_12;
        var val_13;
        val_11 = subCategory;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_2 = GetQuestionImageFromID(subCategory:  val_11, questionID:  questionID);
        val_12 = public static TRVSpecialCategoriesManager MonoSingleton<TRVSpecialCategoriesManager>::get_Instance();
        val_13 = 1152921504765685760;
        if((-607046320) != 0)
        {
                return;
        }
        
        val_12 = 0;
        if((questionID.StartsWith(value:  -580670944)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_6 = GetEnglishIconNameForCategory(cat:  val_11);
        val_11 = public static TRVUtils MonoSingleton<TRVUtils>::get_Instance();
        string val_7 = System.String.Format(format:  -538179488, arg0:  -612557856, arg1:  questionID);
        object val_8 = UnityEngine.Resources.Load<System.Object>(path:  -538179488);
        val_12 = "game/Trivia/UI/GameplayImages/{0}/{1}";
        if((-538179488) != 0)
        {
                return;
        }
        
        val_13 = null;
        string val_10 = System.String.Format(format:  -538178320, arg0:  -612557856, arg1:  questionID);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "Trivia/UI/GameplayImages/{0}/{1}";
        UnityEngine.Debug.LogErrorFormat(format:  -538178176, args:  472754880);
    }
    public ChestType GetChestType()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 2)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 3)
        {
                return;
        }
        
        WordForest.WFOGameEcon val_5 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        add(item:  0, weight:  (float)mem[1152921512476916348].Item[0]);
        WordForest.WFOGameEcon val_7 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        add(item:  1, weight:  (float)mem[1152921512476916348].Item[1]);
        WordForest.WFOGameEcon val_9 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        int val_10 = mem[1152921512476916348].Item[2];
        if(new RandomSet() != 0)
        {
                add(item:  2, weight:  (float)val_10);
            return roll(unweighted:  false);
        }
        
        add(item:  2, weight:  (float)val_10);
        return roll(unweighted:  false);
    }
    public System.Collections.Generic.List<string> GetNewCategories(System.Collections.Generic.List<string> currentlySelectedCategories)
    {
        string val_8;
        TRVDataParser val_24;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_26;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_27;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_28;
        var val_29;
        string val_30;
        float val_31;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_32;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_33;
        val_24 = this;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_26 = 1152921504685600768;
        val_27 = null;
        val_27 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_2 = val_27.FilterForAvailableCats(currentlySelectedCategories:  currentlySelectedCategories);
        if(val_27 == 0)
        {
            goto label_1;
        }
        
        val_28 = val_27;
        int val_3 = val_28.Count;
        if(val_3 > 2)
        {
            goto label_2;
        }
        
        label_1:
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_4 = val_3.FilterForAvailableCats(currentlySelectedCategories:  0);
        val_28 = val_3;
        if(val_3 == 0)
        {
            goto label_3;
        }
        
        label_2:
        val_29 = 1152921512655242144;
        if(val_28.Count < 1)
        {
            goto label_4;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_6 = val_28.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_7 = GetEnumerator();
        val_30 = 0;
        val_31 = 1152921512370649248;
        goto label_6;
        label_8:
        string val_9 = val_28.Item[val_8];
        val_30 = (val_3 + 12) + val_30;
        label_6:
        if(MoveNext() == true)
        {
            goto label_8;
        }
        
        Dispose();
        val_26 = 1152921504685600768;
        val_24 = val_24;
        val_29 = 1152921512655242144;
        goto label_9;
        label_4:
        val_30 = 0;
        label_9:
        if(val_28.Count > 2)
        {
            goto label_10;
        }
        
        label_3:
        this.<ForceUpdateSubCategories>k__BackingField = true;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_12 = this.getAvailableSubCategories;
        val_28 = val_26;
        val_32 = val_28;
        val_32 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  -537915344);
        label_10:
        System.Collections.Generic.List<System.String> val_13 = val_32.RollSelectedCateogries(availableCatData:  78753792);
        this.InsertFeatureCategories(selectedCategories: ref  System.Collections.Generic.List<System.String> val_14 = -537927384);
        val_33 = val_32;
        if((.ctor(dictionary:  -537915344) + 12) > 2)
        {
            goto label_12;
        }
        
        val_33.Clear();
        UnityEngine.Debug.LogError(message:  -537939712);
        Dictionary.KeyCollection<TKey, TValue> val_15 = Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_16 = GetEnumerator();
        val_31 = 1152921512657152608;
        val_24 = 1152921512370649248;
        label_22:
        if(MoveNext() == false)
        {
            goto label_17;
        }
        
        val_30 = val_8;
        string val_18 = Item[val_30];
        int val_19 = UnityEngine.Random.Range(min:  0, max:  1085059232);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_33.Add(item:  (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_name + (val_19) << 2) + 16);
        goto label_22;
        label_17:
        Dispose();
        label_12:
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.getCurrentAvailableCategories = val_33;
    }
    private void InsertFeatureCategories(ref System.Collections.Generic.List<string> selectedCategories)
    {
        bool val_15;
        var val_16;
        float val_17;
        var val_18;
        System.Collections.Generic.List<FeatureCategorySelectFunction> val_19;
        var val_20;
        var val_21;
        System.Collections.Generic.List<System.String> val_22;
        val_15 = static_value_021FCA54;
        if(val_15 != true)
        {
                val_15 = true;
        }
        
        string val_1 = this.GetAdjustCampaign();
        bool val_2 = System.String.IsNullOrEmpty(value:  1);
        if(val_2 == false)
        {
            goto label_1;
        }
        
        string val_3 = val_2.GetAdjustCampaign();
        if((System.String.IsNullOrEmpty(value:  val_2)) == true)
        {
            goto label_2;
        }
        
        label_1:
        val_16 = 1152921504882458624;
        val_17 = "adjustCatSeen";
        bool val_5 = CPlayerPrefs.GetBool(key:  -537819232, defaultValue:  false);
        if(val_5 == false)
        {
            goto label_5;
        }
        
        label_2:
        val_18 = null;
        val_18 = null;
        val_19 = TRVDataParser.featureCategorySelectFunctions;
        if(val_19 == 0)
        {
                return;
        }
        
        val_19 = TRVDataParser.featureCategorySelectFunctions;
        if(val_19 == 0)
        {
            goto label_11;
        }
        
        if((TRVDataParser.featureCategorySelectFunctions + 12) < 1)
        {
                return;
        }
        
        var val_16 = 0;
        val_17 = 12;
        val_16 = 1152921512658962432;
        label_24:
        val_20 = null;
        val_20 = null;
        if(val_16 >= (TRVDataParser.featureCategorySelectFunctions + 12))
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        if((TRVDataParser.featureCategorySelectFunctions + 12) <= val_16)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_15 = TRVDataParser.featureCategorySelectFunctions + 8;
        val_15 = val_15 + 0;
        System.Reflection.Assembly val_6 = (TRVDataParser.featureCategorySelectFunctions + 8 + 0) + 16 + 12.Invoke(arg:  selectedCategories);
        if(((TRVDataParser.featureCategorySelectFunctions + 8 + 0) + 16 + 12) != 0)
        {
            goto label_23;
        }
        
        val_16 = val_16 + 1;
        if(0 < 1)
        {
            goto label_24;
        }
        
        label_23:
        selectedCategories = (TRVDataParser.featureCategorySelectFunctions + 8 + 0) + 16 + 12;
        return;
        label_5:
        val_22 = selectedCategories;
        string val_7 = val_5.GetAdjustCampaign();
        string val_8 = this.TranslateAdjustCampaignToCategory(campaign:  val_5);
        bool val_9 = val_22.Contains(item:  -537794112);
        if(val_9 != true)
        {
                string val_10 = val_9.GetAdjustCampaign();
            string val_11 = this.TranslateAdjustCampaignToCategory(campaign:  val_9);
            if((System.String.IsNullOrEmpty(value:  -537794112)) != true)
        {
                val_22 = selectedCategories;
            val_22.RemoveAt(index:  0);
            string val_13 = val_22.GetAdjustCampaign();
            string val_14 = this.TranslateAdjustCampaignToCategory(campaign:  val_22);
            selectedCategories.Add(item:  -537794112);
        }
        
        }
        
        CPlayerPrefs.SetBool(key:  -537819232, value:  true);
        return;
        label_11:
    }
    private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> FilterForAvailableCats(System.Collections.Generic.List<string> currentlySelectedCategories)
    {
        string val_7;
        ZooTile val_19;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        val_30 = null;
        val_30 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_31 = 1152921511712487824;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_3 = getAvailableSubCategories;
        Dictionary.KeyCollection<TKey, TValue> val_4 = Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_5 = GetEnumerator();
        label_42:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_9 = getAvailableSubCategories;
        string val_10 = Item[val_7];
        System.Collections.Generic.List<ZooTile> val_11 = new System.Collections.Generic.List<ZooTile>(collection:  -1484293744);
        if((Contains(item:  System.String.alignConst)) != false)
        {
                bool val_13 = Remove(item:  System.String.alignConst);
        }
        
        if(currentlySelectedCategories == 0)
        {
            goto label_35;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Player val_15 = App.Player;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        List.Enumerator<T> val_17 = GetEnumerator();
        val_30 = val_30;
        label_31:
        if(MoveNext() == false)
        {
            goto label_27;
        }
        
        if((Contains(item:  val_19)) == false)
        {
            goto label_31;
        }
        
        bool val_21 = Remove(item:  val_19);
        goto label_31;
        label_27:
        var val_30 = 0;
        val_30 = val_30 + 1;
        mem2[0] = 237;
        Dispose();
        val_31 = 1152921511712487824;
        var val_32 = val_30;
        if(val_32 == 1)
        {
            goto label_34;
        }
        
        if((-537685944 + ((0 + 1)) << 2) != 237)
        {
            goto label_35;
        }
        
        var val_31 = val_32 >> 31;
        val_32 = val_32 + (~(val_32 >> 31));
        goto label_36;
        label_34:
        label_35:
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_23 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.getOmittedCateogries = 80883712;
        label_36:
        Add(key:  val_7, value:  80883712);
        goto label_42;
        label_6:
        var val_33 = 0;
        val_33 = val_33 + 1;
        mem2[0] = 274;
        Dispose();
        if(val_33 != 1)
        {
                if(val_33 > 1)
        {
                0 = 1;
        }
        
            var val_34 = -537685944 + ((0 + 1)) << 2;
            val_34 = val_34 - 274;
            val_34 = val_34 >> 5;
            val_34 = 1 & val_34;
            val_34 = val_33 - val_34;
            val_32 = val_34 + 1;
        }
        else
        {
                val_32 = 0;
        }
        
        if((val_30 == 0) || (Count <= 2))
        {
            goto label_51;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_25 = Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_26 = GetEnumerator();
        val_33 = 0;
        goto label_53;
        label_55:
        string val_27 = Item[val_7];
        val_33 = 1152921505691906208;
        label_53:
        if(MoveNext() == true)
        {
            goto label_55;
        }
        
        Dispose();
        if(val_33 <= 2)
        {
                val_34 = 0;
        }
        
        return;
        label_51:
        val_34 = 0;
        UnityEngine.Debug.LogError(message:  -537698000);
    }
    private System.Collections.Generic.List<string> RollSelectedCateogries(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> availableCatData)
    {
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        do
        {
            Player val_2 = App.Player;
            if(0 > TRVMainController.getRerollFTUXLEVEL)
        {
                RandomSet val_4 = new RandomSet();
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            System.Collections.Generic.List<System.String> val_5 = availableCatData.Item[357081088];
            if(availableCatData >= 1)
        {
                WordForest.WFOGameEcon val_6 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            add(item:  2, weight:  (float)mem[1152921512476916340].Item[2]);
        }
        
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            System.Collections.Generic.List<System.String> val_8 = availableCatData.Item[357081088];
            if(availableCatData >= 1)
        {
                WordForest.WFOGameEcon val_9 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            add(item:  1, weight:  (float)mem[1152921512476916340].Item[1]);
        }
        
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            System.Collections.Generic.List<System.String> val_11 = availableCatData.Item[357081088];
            if(availableCatData >= 1)
        {
                WordForest.WFOGameEcon val_12 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            add(item:  0, weight:  (float)mem[1152921512476916340].Item[0]);
        }
        
            val_28 = roll(unweighted:  false);
        }
        else
        {
                System.Collections.Generic.List<System.Int32> val_15 = new System.Collections.Generic.List<System.Int32>();
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            System.Collections.Generic.List<System.String> val_16 = availableCatData.Item[357081088];
            if(availableCatData >= 1)
        {
                Add(item:  2);
        }
        
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            System.Collections.Generic.List<System.String> val_17 = availableCatData.Item[357081088];
            if(availableCatData >= 1)
        {
                Add(item:  1);
        }
        
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            System.Collections.Generic.List<System.String> val_18 = availableCatData.Item[357081088];
            if(availableCatData >= 1)
        {
                Add(item:  0);
        }
        
            if(null != 0)
        {
                val_29 = null;
            val_30 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        }
        else
        {
                val_29 = 12;
            val_30 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
            if(val_29 <= val_30)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_28 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_20) << 2) + 16];
            val_28 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_20) << 2) + 16;
        }
        
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            System.Collections.Generic.List<System.String> val_21 = availableCatData.Item[357081088];
            if((availableCatData.Contains(item:  System.String.alignConst)) != false)
        {
                bool val_23 = availableCatData.Remove(item:  System.String.alignConst);
        }
        
            if(availableCatData != 0)
        {
                val_31 = availableCatData;
            val_32 = UnityEngine.Random.Range(min:  0, max:  System.String.alignConst);
        }
        else
        {
                val_31 = 12;
            var val_28 = 0;
            val_32 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
            if(val_31 <= val_32)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_28 = val_28 + (val_32 << 2);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            System.Collections.Generic.List<System.String> val_26 = availableCatData.Item[357081088];
            var val_29 = 3;
            bool val_27 = availableCatData.Remove(item:  (0 + (val_25) << 2) + 16);
            Add(item:  (0 + (val_25) << 2) + 16);
            val_29 = val_29 - 1;
        }
        while((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) != 0);
    
    }
    private string GetAdjustCampaign()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
            goto label_4;
        }
        
        val_4 = null;
        val_4 = null;
        if((System.String.IsNullOrEmpty(value:  TRVDataParser.hackedAdjustCampaign)) == false)
        {
            goto label_7;
        }
        
        label_4:
        var val_4 = 23351161;
        val_4 = 12284416 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        val_6 = 1152921504895189008;
        return;
        label_7:
        val_7 = null;
        val_7 = null;
    }
    private string GetAdjustAdGroup()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
            goto label_4;
        }
        
        val_4 = null;
        val_4 = null;
        if((System.String.IsNullOrEmpty(value:  TRVDataParser.hackedAdjustCampaign)) == false)
        {
            goto label_7;
        }
        
        label_4:
        var val_4 = 23349981;
        val_4 = 12285212 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        val_6 = 1152921504895189004;
        return;
        label_7:
        val_7 = null;
        val_7 = null;
    }
    private string TranslateAdjustCampaignToCategory(string campaign)
    {
        var val_10;
        if((System.String.IsNullOrEmpty(value:  campaign)) == true)
        {
            goto label_1;
        }
        
        string val_2 = campaign.ToLower();
        bool val_3 = campaign.Contains(value:  -537232416);
        if(val_3 == true)
        {
            goto label_4;
        }
        
        label_1:
        string val_4 = val_3.GetAdjustAdGroup();
        if(((System.String.IsNullOrEmpty(value:  val_3)) == true) || ((val_3.Contains(value:  -537232416)) == false))
        {
            goto label_7;
        }
        
        label_4:
        val_10 = "Pop Music";
        return;
        label_7:
        if((System.String.IsNullOrEmpty(value:  campaign)) == true)
        {
                return;
        }
        
        string val_8 = -537232320(-537232320) + campaign;
        UnityEngine.Debug.LogWarning(message:  -537232320);
    }
    public string NextAvailableCategory()
    {
    
    }
    public void UnlockCategoryEarly(string euCat)
    {
        this.<ForceUpdateSubCategories>k__BackingField = true;
        this.<playerPersistance>k__BackingField.UnlockCategoryEarly(cat:  euCat);
    }
    public TRVDataParser()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.lastUpdatedSubCategoryLevel = 0;
        this.cachedSubCategories = null;
        this.QAHACK_currentHackedLocale = "";
    }
    private static TRVDataParser()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_1 != 0)
        {
                Add(item:  -826136512);
        }
        else
        {
                Add(item:  -826136512);
        }
        
        Add(item:  -825669904);
        if(val_1 != 0)
        {
                Add(item:  -825902176);
        }
        else
        {
                Add(item:  -825902176);
        }
        
        Add(item:  -541405920);
        Add(item:  -1266461600);
        TRVDataParser.categoryNames = val_1;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_2 != 0)
        {
                Add(item:  -541405920);
        }
        else
        {
                Add(item:  -541405920);
        }
        
        Add(item:  -1266461600);
        TRVDataParser.excludedCateogries = val_2;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        TRVDataParser.featureCategorySelectFunctions = null;
        TRVDataParser.desiredLocale = "";
    }
    private bool <get_getAvailableSubCategories>b__21_0(string x)
    {
        var val_6;
        var val_7;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = this.CategoryUnlockLevels;
        val_6 = this;
        val_7 = 0;
        if((this.ContainsKey(key:  x)) == false)
        {
                return (bool)val_7;
        }
        
        Player val_3 = App.Player;
        val_6 = 0;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = this.CategoryUnlockLevels;
        val_7 = 1;
        if(val_6 >= this.Item[x])
        {
                return (bool)val_7;
        }
        
        if((this.<playerPersistance>k__BackingField._earlyUnlockedCategories) != 0)
        {
                return this.<playerPersistance>k__BackingField._earlyUnlockedCategories.Contains(item:  x);
        }
        
        return this.<playerPersistance>k__BackingField._earlyUnlockedCategories.Contains(item:  x);
    }

}
