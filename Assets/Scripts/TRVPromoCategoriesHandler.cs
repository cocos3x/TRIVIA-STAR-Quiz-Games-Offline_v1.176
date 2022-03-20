using UnityEngine;
public class TRVPromoCategoriesHandler : LocalGameEventSpawner<TRVPromoCategoriesHandler>
{
    // Fields
    public static bool QAHACK_OnlyShowPicQuestions;
    private static System.Collections.Generic.List<string> supportLangs;
    private const string prefs_seen_promos_key = "seen_promos";
    private System.Collections.Generic.List<int> _SeenPromos;
    private const string prefs_promo_quiz_completed_key = "promo_prgss";
    private static System.Collections.Generic.Dictionary<string, int> _PromoQuizzesCompleted;
    private System.Collections.Generic.List<TRVPromoCategory> currentPromos;
    private UnityEngine.Sprite genericIcon;
    private System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> cachedLoadedSprites;
    public static TRVPromoCategory CurrentlyShownPromo;
    private bool isRequesting;
    private System.DateTime lastSuccessfulResponse;
    private static bool logPromoLogic;
    private static string log;
    
    // Properties
    private System.Collections.Generic.List<int> SeenPromos { get; }
    private static System.Collections.Generic.Dictionary<string, int> PromoQuizzesCompleted { get; }
    
    // Methods
    private System.Collections.Generic.List<int> get_SeenPromos()
    {
        if(this._SeenPromos != 0)
        {
                return;
        }
        
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -580418176, defaultValue:  -2141227328);
        object val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -580418176);
        mem2[0] = "seen_promos";
    }
    private static System.Collections.Generic.Dictionary<string, int> get_PromoQuizzesCompleted()
    {
        var val_3 = null;
        if(TRVPromoCategoriesHandler._PromoQuizzesCompleted == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -580301984, defaultValue:  -2040381152);
            object val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -580301984);
            val_3 = null;
            val_3 = null;
            TRVPromoCategoriesHandler._PromoQuizzesCompleted = "promo_prgss";
        }
        
        val_3 = null;
    }
    public override void InitSpwaner()
    {
        System.Func<ZooTile, System.String> val_1 = new System.Func<ZooTile, System.String>(object:  -580163840, method:  new IntPtr(3714777408));
        FeatureCategorySelectFunction val_2 = new FeatureCategorySelectFunction(highPriority:  0, functionToDo:  7720960, owner:  -580163840);
        TRVDataParser.AddCategorySelectFunction(newfunction:  357134336);
        this.RequestPromos();
    }
    public bool EventShouldShow()
    {
        null = null;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        if(TRVPromoCategoriesHandler.supportLangs != 0)
        {
                return TRVPromoCategoriesHandler.supportLangs.Contains(item:  null);
        }
        
        return TRVPromoCategoriesHandler.supportLangs.Contains(item:  null);
    }
    public TRVCategorySelectionInfo GetCurrentlyShownSubCategory()
    {
        var val_2;
        TRVCategorySelectionInfo val_1 = new TRVCategorySelectionInfo();
        val_2 = null;
        val_2 = null;
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_8 = TRVPromoCategoriesHandler.CurrentlyShownPromo.subCategoryName;
    }
    public string GetPrimaryCategory()
    {
    
    }
    public bool IsActivePromo(string subCategoryName)
    {
        typeof(TRVPromoCategoriesHandler.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = subCategoryName;
        if(this.currentPromos == 0)
        {
                return false;
        }
        
        if(new System.Object() < 1)
        {
                return false;
        }
        
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  354578432, method:  new IntPtr(3715235744));
        return this.currentPromos.Exists(match:  8040448);
    }
    public TRVQuizProgress LoadQuiz(string subCategory, string primaryCategory)
    {
        string val_8;
        TRVPromoCategoriesQuiz val_9;
        val_8 = subCategory;
        val_9 = 0;
        if((this.IsActivePromo(subCategoryName:  val_8)) == false)
        {
                return;
        }
        
        TRVPromoCategory val_2 = this.GetPromoCategory(subCategoryName:  val_8);
        TRVSubCategoryData val_3 = new TRVSubCategoryData(textBlock:  static_value_021FC893, subCategoryName:  val_8);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
        ChestType val_6 = GetChestType();
        val_9 = null;
        val_9 = new TRVPromoCategoriesQuiz(quizCategoryData:  357560320, quizLength:  this.GetQuizLength(promoCategory:  -579576096), quizLevel:  0, chestType:  val_8, isPromo:  true);
    }
    public TRVPromoCategory GetPromoCategory(string subCategoryName)
    {
        object val_1 = new System.Object();
        typeof(TRVPromoCategoriesHandler.<>c__DisplayClass22_0).__il2cppRuntimeField_8 = subCategoryName;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_2 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  354631680, method:  new IntPtr(3715495584));
        return System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.currentPromos, predicate:  7720960);
    }
    private int GetQuizLength(TRVPromoCategory promoCategory)
    {
        int val_4;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_8;
        int val_9;
        if(promoCategory != 0)
        {
                val_8 = promoCategory.quizLenngthLevelUnlocks;
        }
        else
        {
                val_8 = 52;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_2 = val_8.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        val_9 = 3;
        goto label_5;
        label_7:
        if((this.GetActivePromoProgress(subcategory:  promoCategory.subCategoryName)) >= val_8.Item[val_4])
        {
                val_9 = val_4;
        }
        
        label_5:
        if(MoveNext() == true)
        {
            goto label_7;
        }
        
        Dispose();
        return (int)UnityEngine.Mathf.Max(a:  3, b:  val_9);
    }
    public int GetActivePromoProgress(string subcategory)
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = TRVPromoCategoriesHandler.PromoQuizzesCompleted;
        if((ContainsKey(key:  subcategory)) == false)
        {
                return 0;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_3 = TRVPromoCategoriesHandler.PromoQuizzesCompleted;
        if(null != 0)
        {
                return Item[subcategory];
        }
        
        return Item[subcategory];
    }
    public System.Collections.Generic.Dictionary<int, int> GetPromoRewards(string promoCategory)
    {
        var val_4 = 0;
        if((System.String.IsNullOrEmpty(value:  promoCategory)) == true)
        {
                return;
        }
        
        if((this.IsActivePromo(subCategoryName:  promoCategory)) == false)
        {
                return;
        }
        
        TRVPromoCategory val_3 = this.GetPromoCategory(subCategoryName:  promoCategory);
    }
    public int[] GetQuizDifficultyArray(string quizCategory)
    {
        var val_5;
        var val_11;
        TRVPromoCategory val_1 = this.GetPromoCategory(subCategoryName:  quizCategory);
        int val_2 = this.GetQuizLength(promoCategory:  -578938272);
        Dictionary.KeyCollection<TKey, TValue> val_3 = this.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        val_11 = 0;
        goto label_5;
        label_7:
        if(val_5 == val_2)
        {
                System.TimeType val_6 = this.Item[val_2];
            val_11 = this;
        }
        
        label_5:
        if(MoveNext() == true)
        {
            goto label_7;
        }
        
        Dispose();
        if(val_11 != 0)
        {
                return;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_8 = this.Keys;
        System.TimeType val_10 = this.Item[System.Linq.Enumerable.Max(source:  -578938272)];
        val_11 = this;
    }
    public int GetNextQuestionDifficulty(int quizProgress, TRVPromoCategoriesQuiz quiz)
    {
        if(true > quizProgress)
        {
                return (int)quiz + (quizProgress << 2);
        }
        
        TRVPromoCategoriesHandler.LogLogic(logic:  -578842080, color:  -1544804720);
        return 0;
    }
    public void HandleCategorySelected(string categoryName)
    {
        var val_6;
        if((this.IsActivePromo(subCategoryName:  categoryName)) == false)
        {
            goto label_1;
        }
        
        TRVPromoCategory val_2 = this.GetPromoCategory(subCategoryName:  categoryName);
        if(this == 0)
        {
            goto label_2;
        }
        
        GameBehavior val_3 = App.getBehavior;
        0.SetupWithPromo(promo:  -578696192, hidePaidEntry:  true, returnToCategorySelectOnButtonClose:  true, continueToNextLevel:  true);
        return;
        label_1:
        val_6 = "HandleCategorySelected Error: No active promo found for ";
        goto label_8;
        label_2:
        val_6 = "HandleCategorySelected Error: No promo found for ";
        label_8:
        string val_5 = -578720368(-578720368) + categoryName;
        TRVPromoCategoriesHandler.LogError(error:  -578720368);
    }
    public void OnCategoryQuizComplete(TRVQuizProgress quiz)
    {
        string val_12;
        var val_13;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = TRVPromoCategoriesHandler.PromoQuizzesCompleted;
        val_12 = quiz.quizCategory;
        if((ContainsKey(key:  val_12)) == false)
        {
            goto label_5;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_4 = TRVPromoCategoriesHandler.PromoQuizzesCompleted;
        if(null == 0)
        {
            goto label_8;
        }
        
        val_13 = null;
        val_12 = Item[quiz.quizCategory];
        goto label_9;
        label_5:
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_6 = TRVPromoCategoriesHandler.PromoQuizzesCompleted;
        Add(key:  quiz.quizCategory, value:  1);
        goto label_13;
        label_8:
        val_13 = 0;
        val_12 = 0.Item[quiz.quizCategory];
        label_9:
        val_13.set_Item(key:  quiz.quizCategory, value:  val_12 + 1);
        label_13:
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_9 = TRVPromoCategoriesHandler.PromoQuizzesCompleted;
        string val_10 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  354525184);
        UnityEngine.PlayerPrefs.SetString(key:  -580301984, value:  354525184);
        bool val_11 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public UnityEngine.Sprite GetIcon(TRVPromoCategory promoCategory)
    {
        if((System.String.IsNullOrEmpty(value:  promoCategory.iconSpriteName)) == true)
        {
                return;
        }
        
        35637403 = promoCategory.iconSpriteName;
        string val_2 = 35637403.ToLower();
        if((System.String.op_Equality(a:  35637403, b:  -578447040)) == true)
        {
                return;
        }
        
        if(this.cachedLoadedSprites == 0)
        {
                return;
        }
        
        if((this.cachedLoadedSprites.ContainsKey(key:  promoCategory.iconSpriteName)) == false)
        {
                return;
        }
        
        UnityEngine.Sprite val_5 = this.cachedLoadedSprites.Item[promoCategory.iconSpriteName];
    }
    public UnityEngine.Sprite GetIcon(string subCategoryName)
    {
        TRVPromoCategory val_1 = this.GetPromoCategory(subCategoryName:  subCategoryName);
        return this.GetIcon(promoCategory:  -578251552);
    }
    public UnityEngine.Sprite GetQuestionImageFromID(string subCategory, string questionID)
    {
        var val_6;
        string val_1 = -578151264(-578151264) + subCategory + 1297836560 + questionID;
        TRVPromoCategoriesHandler.LogLogic(logic:  -578151264, color:  -1544804720);
        val_6 = 0;
        string val_2 = PrettyPrint.printJSON(obj:  this.cachedLoadedSprites, types:  false, singleLineOutput:  false);
        string val_3 = -578147040(-578147040) + this.cachedLoadedSprites;
        TRVPromoCategoriesHandler.LogLogic(logic:  -578147040, color:  -1544804720);
        if(this.cachedLoadedSprites == 0)
        {
                return;
        }
        
        if((this.cachedLoadedSprites.ContainsKey(key:  questionID)) == false)
        {
                return;
        }
        
        UnityEngine.Sprite val_5 = this.cachedLoadedSprites.Item[questionID];
        val_6 = this.cachedLoadedSprites;
    }
    public bool ShouldShowEndOfQuiz(TRVQuizProgress progress)
    {
        if((this.GetCurrentQuizReward(progress:  progress)) > 0)
        {
                return true;
        }
        
        if((R5.GetRemainingLevels(progress:  R4)) < 1)
        {
                0 = 1;
        }
        
        return true;
    }
    public int GetRemainingLevels(TRVQuizProgress progress)
    {
        TRVPromoCategory val_1 = this.GetPromoCategory(subCategoryName:  progress.quizCategory);
        return this.GetRemainingLevelsForPromo(currentPromo:  -577853872);
    }
    public int GetRemainingLevelsForPromo(TRVPromoCategory currentPromo)
    {
        System.Func<System.Int32, System.Boolean> val_7;
        var val_8;
        var val_9;
        var val_10;
        object val_1 = new System.Object();
        Dictionary.KeyCollection<TKey, TValue> val_2 = currentPromo.rewards.Keys;
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Int32>(source:  currentPromo.rewards);
        typeof(TRVPromoCategoriesHandler.<>c__DisplayClass35_0).__il2cppRuntimeField_8 = currentPromo.rewards.GetActivePromoProgress(subcategory:  currentPromo.subCategoryName);
        val_7 = null;
        val_7 = new System.Func<System.Int32, System.Boolean>(object:  354684928, method:  new IntPtr(3717221904));
        int val_6 = System.Linq.Enumerable.FirstOrDefault<System.Int32>(source:  currentPromo.rewards, predicate:  7720960);
        if(val_6 != 0)
        {
                return (int)((0 + 4294967292) + 16 - val_4);
        }
        
        if(currentPromo.rewards != 0)
        {
                val_10 = val_6;
        }
        else
        {
                val_10 = 0;
            val_9 = 0;
        }
        
        val_7 = -1;
        if(val_9 <= val_7)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + 4294967292;
        val_8 = mem[(0 + 4294967292) + 16];
        val_8 = (0 + 4294967292) + 16;
        return (int)((0 + 4294967292) + 16 - val_4);
    }
    public bool IsRewardReadyToCollect(TRVQuizProgress progress)
    {
        if((this.GetCurrentQuizReward(progress:  progress)) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public int GetCurrentQuizReward(TRVQuizProgress progress)
    {
        int val_5;
        var val_6;
        val_5 = progress;
        if(val_5 != 0)
        {
                TRVPromoCategory val_1 = this.GetPromoCategory(subCategoryName:  progress.quizCategory);
            val_6 = this;
        }
        else
        {
                val_5 = 8;
            TRVPromoCategory val_2 = this.GetPromoCategory(subCategoryName:  null);
            val_6 = this;
        }
        
        int val_3 = this.GetActivePromoProgress(subcategory:  null);
        if(val_6 != 0)
        {
                val_5 = val_3;
        }
        
        if(val_3 == 0)
        {
                return 0;
        }
        
        if((val_3.ContainsKey(key:  val_5)) == false)
        {
                return 0;
        }
        
        if(val_6 != 0)
        {
                return this.Item[val_5];
        }
        
        return this.Item[val_5];
    }
    public void CollectReward(TRVQuizProgress progress)
    {
        int val_16;
        var val_17;
        var val_18;
        int val_19;
        val_16 = progress;
        if(val_16 != 0)
        {
                TRVPromoCategory val_1 = this.GetPromoCategory(subCategoryName:  progress.quizCategory);
            val_17 = this;
        }
        else
        {
                val_16 = 8;
            TRVPromoCategory val_2 = this.GetPromoCategory(subCategoryName:  null);
            val_17 = this;
        }
        
        int val_3 = this.GetActivePromoProgress(subcategory:  null);
        if(val_17 != 0)
        {
                val_16 = val_3;
        }
        
        if(val_3 == 0)
        {
                return;
        }
        
        bool val_4 = val_3.ContainsKey(key:  val_16);
        if(val_4 != false)
        {
                if(val_4 != false)
        {
                Dictionary.KeyCollection<TKey, TValue> val_5 = R7.Keys;
            System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.Int32>(source:  R7);
            int val_7 = R7.IndexOf(item:  val_16);
            val_7 = val_7 + 1;
            val_18 = "Special Category \'{0}\' Tier {1}";
            string val_8 = System.String.Format(format:  -577358192, arg0:  this.cachedLoadedSprites, arg1:  13152256);
        }
        else
        {
                val_18 = "Promotional Special Category \'{0}\'";
            string val_9 = System.String.Format(format:  -577358048, arg0:  this.cachedLoadedSprites);
        }
        
            val_19 = R7.Item[val_16];
            val_19 = val_19;
            Player val_11 = App.Player;
            0.AddGems(amount:  val_19, source:  -577358048, subsource:  null);
            Player val_12 = App.Player;
            string val_13 = val_19.ToString();
            0.TrackNonCoinReward(source:  -577358048, subSource:  null, rewardType:  -1687442624, rewardAmount:  val_19, additionalParams:  0);
        }
        
        bool val_14 = this.IsPromoComplete(currentPromo:  -577324688);
        if(val_14 == false)
        {
                return;
        }
        
        if(val_14 != true)
        {
                return;
        }
        
        this.PutCategoryComplete(categoryId:  this.isRequesting);
        bool val_15 = this.currentPromos.Remove(item:  -577324688);
    }
    public string GetExpertForSpecialCategory(string subCategory)
    {
        TRVPromoCategory val_1 = this.GetPromoCategory(subCategoryName:  subCategory);
        string val_2 = -577212032(-577212032) + subCategory + -577212112(-577212112) + null;
        TRVPromoCategoriesHandler.LogLogic(logic:  -577212032, color:  -577211904);
    }
    public void RequestPromosFromServer()
    {
        this.RequestPromos();
    }
    public static System.Collections.Generic.List<string> GetSpecialCategoriesWithProgress()
    {
        var val_4;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.String> val_6;
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = TRVPromoCategoriesHandler.PromoQuizzesCompleted;
        val_4 = null;
        val_4 = null;
        val_6 = TRVPromoCategoriesHandler.<>c.<>9__41_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.String>(object:  TRVPromoCategoriesHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3717983568));
            TRVPromoCategoriesHandler.<>c.<>9__41_0 = val_6;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_3 = System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Object, System.Int32>, System.Object>(source:  354525184, selector:  7720960);
        return System.Linq.Enumerable.ToList<System.Object>(source:  354525184);
    }
    private void RequestPromos()
    {
        ulong val_2;
        var val_5;
        var val_14;
        System.DateTime val_1 = System.DateTime.Now;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512619926008}, d2:  new System.DateTime() {dateData = val_2});
        double val_7 = val_5.TotalSeconds;
        if(this.isRequesting == true)
        {
                return;
        }
        
        this.isRequesting = true;
        string val_9 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>().GetPlatform();
        Add(key:  -1928946992, value:  new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>() = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>());
        Player val_10 = App.Player;
        Add(key:  -1824276800, value:  33449456);
        val_14 = null;
        val_14 = null;
        Player val_11 = App.Player;
        string val_12 = System.String.Format(format:  -576868656, arg0:  1835037);
        System.Action<System.Threading.Tasks.Task, System.Object> val_13 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -576843504, method:  new IntPtr(3718098768));
        App.networkManager.DoGet(path:  -576868656, onCompleteFunction:  7507968, destroy:  false, immediate:  false, getParams:  null, timeout:  20);
    }
    private void OnRequestPromoResponse(string url, System.Collections.Generic.Dictionary<string, object> response)
    {
        float val_26;
        var val_58;
        object val_61;
        var val_63;
        var val_64;
        this.isRequesting = false;
        if((this.CheckResponse(url:  url, response:  response)) == false)
        {
                return;
        }
        
        string val_2 = PrettyPrint.printJSON(obj:  response, types:  false, singleLineOutput:  false);
        string val_3 = url + 1269544832 + response;
        TRVPromoCategoriesHandler.LogLogic(logic:  url, color:  -576747312);
        val_58 = 1152921510392296080;
        if((response.ContainsKey(key:  -576747232)) == false)
        {
                return;
        }
        
        object val_5 = response.Item[-576747232];
        if(response == 0)
        {
                return;
        }
        
        object val_6 = response.Item[-576747232];
        object val_7 = response.Item[-576747232];
        string val_8 = PrettyPrint.printJSON(obj:  response, types:  false, singleLineOutput:  false);
        string val_9 = -576747120(-576747120) + response;
        TRVPromoCategoriesHandler.LogError(error:  -576747120);
        return;
        label_69:
        if(val_26.MoveNext() == false)
        {
            goto label_64;
        }
        
        val_63 = 0;
        if(false != 0)
        {
                val_63 = false;
            if(val_63 == 0)
        {
                val_63 = 0;
        }
        
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_46 = System.Linq.Enumerable.Cast<System.Int32>(source:  0);
        TSource[] val_47 = System.Linq.Enumerable.ToArray<System.Int32>(source:  0);
        Add(key:  System.Int32.Parse(s:  R6), value:  0);
        goto label_69;
        label_64:
        var val_58 = 0;
        val_58 = val_58 + 1;
        mem2[0] = 646;
        val_26.Dispose();
        var val_60 = val_58;
        if(val_60 != 1)
        {
                if(val_60 > 1)
        {
                0 = 1;
        }
        
            var val_59 = -576731048 + ((0 + 1)) << 2;
            val_59 = val_59 - 646;
            val_59 = val_59 >> 5;
            val_59 = 1 & val_59;
            val_60 = val_60 - val_59;
        }
        
        val_58 = 1152921510392296080;
        string val_48 = PrettyPrint.printJSON(obj:  78753792, types:  false, singleLineOutput:  true);
        string val_49 = PrettyPrint.printJSON(obj:  0, types:  false, singleLineOutput:  true);
        string val_50 = System.String.Format(format:  -576743312, arg0:  0, arg1:  78753792, arg2:  0);
        val_61 = ;
        TRVPromoCategoriesHandler.LogLogic(logic:  -576743312, color:  -576743072);
        if((val_60.ContainsKey(key:  -576742992)) == false)
        {
            goto label_78;
        }
        
        string val_52 = val_60.Item[-576742992];
        val_64 = 0;
        if( != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                 = 0;
        }
        
            val_64 = ;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_53 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        typeof(TRVPromoCategory).__il2cppRuntimeField_3C = null;
        Dictionary.Enumerator<TKey, TValue> val_54 = GetEnumerator();
        label_87:
        if(val_26.MoveNext() == false)
        {
            goto label_83;
        }
        
        Add(key:  System.Int32.Parse(s:  R6), value:  System.Int32.Parse(s:  null));
        goto label_87;
        label_83:
        var val_61 = 0;
        val_61 = val_61 + 1;
        mem2[0] = 829;
        val_26.Dispose();
        var val_63 = val_61;
        if(val_63 != 1)
        {
                if(val_63 > 1)
        {
                0 = 1;
        }
        
            var val_62 = -576731048 + ((0 + 1)) << 2;
            val_62 = val_62 - 829;
            val_62 = val_62 >> 5;
            val_62 = 1 & val_62;
            val_63 = val_63 - val_62;
        }
    
    }
    private void PutCategoryComplete(int categoryId)
    {
        var val_8;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -576622704, value:  13152256);
        Add(key:  -1472372400, value:  8945664);
        string val_2 = GetPlatform();
        Add(key:  -1928946992, value:  78753792);
        Player val_3 = App.Player;
        Add(key:  -1824276800, value:  33449456);
        string val_4 = System.String.Format(format:  -576622592, arg0:  13152256);
        TRVPromoCategoriesHandler.LogLogic(logic:  -576622592, color:  -576622336);
        val_8 = null;
        val_8 = null;
        Player val_5 = App.Player;
        string val_6 = System.String.Format(format:  -576868656, arg0:  1835037);
        System.Action<System.Threading.Tasks.Task, System.Object> val_7 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -576597232, method:  new IntPtr(3718345040));
        App.networkManager.DoPut(path:  -576868656, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false);
    }
    private void OnGenericResponse(string url, System.Collections.Generic.Dictionary<string, object> response)
    {
        bool val_1 = this.CheckResponse(url:  url, response:  response);
    }
    private bool CheckResponse(string url, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_10;
        string val_11;
        var val_12;
        var val_13;
        if((response == 0) || (response.Count <= 0))
        {
            goto label_2;
        }
        
        if((response.ContainsKey(key:  1616271776)) == false)
        {
            goto label_3;
        }
        
        object val_3 = response.Item[1616271776];
        string val_4 = response.ToString();
        val_10 = 1;
        if((System.Boolean.Parse(value:  response)) == true)
        {
                return (bool)val_10;
        }
        
        val_10 = 0;
        string val_6 = PrettyPrint.printJSON(obj:  response, types:  false, singleLineOutput:  false);
        val_11 = response;
        val_12 = "PROMO RESPONSE FAILURE: ";
        goto label_10;
        label_2:
        val_10 = 0;
        val_13 = "PROMO RESPONSE ERROR: ";
        string val_7 = -576372400(-576372400) + url + -576372528(-576372528);
        goto label_11;
        label_3:
        val_10 = 0;
        string val_8 = PrettyPrint.printJSON(obj:  response, types:  false, singleLineOutput:  false);
        val_11 = response;
        val_12 = "PROMO RESPONSE ERROR: ";
        label_10:
        string val_9 = -576372400(-576372400) + url + 1269544832 + val_11;
        label_11:
        TRVPromoCategoriesHandler.LogError(error:  -576372400);
        return (bool)val_10;
    }
    private string GetPlatform()
    {
        string val_1 = DeviceProperties.Platform;
        if(UnityEngine.Application.isEditor == true)
        {
                0 = "android";
        }
    
    }
    private System.Collections.Generic.List<string> TryAddingPromoCategories(System.Collections.Generic.List<string> selectedCategories)
    {
        var val_6;
        var val_20;
        var val_27;
        float val_28;
        var val_29;
        System.Collections.Generic.List<System.String> val_30;
        var val_31;
        var val_32;
        twelvegigs.sweepstakes.Distribution val_33;
        string val_1 = PrettyPrint.printJSON(obj:  selectedCategories, types:  false, singleLineOutput:  true);
        string val_2 = System.String.Format(format:  -576136000, arg0:  selectedCategories);
        TRVPromoCategoriesHandler.LogLogic(logic:  -576136000, color:  -576135728);
        bool val_3 = EventShouldShow();
        if(val_3 == false)
        {
            goto label_5;
        }
        
        if((this.currentPromos == 0) || (val_3 <= false))
        {
            goto label_7;
        }
        
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        val_27 = val_6;
        System.Collections.Generic.List<System.Int32> val_7 = this.SeenPromos;
        if((this.Contains(item:  val_6 + 28)) == true)
        {
            goto label_11;
        }
        
        val_28 = "56BB46";
        string val_9 = -576129504(-576129504) + val_6 + 24(val_6 + 24);
        val_29 = 1;
        TRVPromoCategoriesHandler.LogLogic(logic:  -576129504, color:  -576135728);
        val_30 = selectedCategories;
        goto label_14;
        label_5:
        val_31 = "56BB46";
        val_32 = "... Event should not show for some reason. Aborting and won\'t show a promo category for this roll.";
        goto label_62;
        label_7:
        val_31 = "56BB46";
        val_32 = "... No current promos. Aborting and won\'t show a promo category for this roll.";
        label_62:
        TRVPromoCategoriesHandler.LogLogic(logic:  -576129104, color:  -576135728);
        return;
        label_8:
        val_30 = selectedCategories;
        val_29 = 0;
        val_27 = 0;
        val_28 = "56BB46";
        label_14:
        Dispose();
        if(val_27 == 0)
        {
                System.Collections.Generic.List<ZooTile> val_10 = new System.Collections.Generic.List<ZooTile>(collection:  this.currentPromos);
            System.Predicate<ZooTile> val_11 = new System.Predicate<ZooTile>(object:  -576092608, method:  new IntPtr(3718844576));
            if(null != 0)
        {
                int val_12 = RemoveAll(match:  8040448);
        }
        else
        {
                int val_13 = RemoveAll(match:  8040448);
        }
        
            int val_14 = UnityEngine.Random.Range(min:  0, max:  1094062064);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_27 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16];
            val_27 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16;
            string val_15 = -576120672(-576120672) + (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 24((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 24);
            TRVPromoCategoriesHandler.LogLogic(logic:  -576120672, color:  -576135728);
        }
        
        System.Collections.Generic.List<ZooTile> val_16 = new System.Collections.Generic.List<ZooTile>(collection:  val_30);
        if(val_29 != 0)
        {
                RemoveAt(index:  0);
            Add(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 24);
            this.AddSeenPromo(promoId:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 28);
            return;
        }
        
        WordForest.WFOGameEcon val_17 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        Dictionary.Enumerator<TKey, TValue> val_18 = GetEnumerator();
        goto label_36;
        label_37:
        var val_27 = 0;
        val_27 = val_27 + val_20;
        label_36:
        if(0.MoveNext() == true)
        {
            goto label_37;
        }
        
        0.Dispose();
        add(item:  0, weight:  (float)val_27);
        if(new RandomSet() != 0)
        {
                add(item:  1, weight:  (float)(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 52);
        }
        else
        {
                add(item:  1, weight:  (float)(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 52);
        }
        
        int val_23 = roll(unweighted:  false);
        string val_24 = val_27.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        typeof(System.Object[]).__il2cppRuntimeField_14 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 24;
        string val_25 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 52.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_18 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 52;
        if(val_23 == 1)
        {
                "Keep existing categories." = "Add promo category.";
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_1C = "Add promo category.";
        string val_26 = System.String.Format(format:  -576117424, args:  472754880);
        TRVPromoCategoriesHandler.LogLogic(logic:  -576117424, color:  -576135728);
        if(val_23 != 1)
        {
                return;
        }
        
        if(null != 0)
        {
                RemoveAt(index:  0);
            val_33 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 24];
            val_33 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 24;
        }
        else
        {
                RemoveAt(index:  0);
            val_33 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 24];
            val_33 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_14) << 2) + 16 + 24;
        }
        
        Add(item:  val_33);
    }
    private bool IsPromoComplete(TRVPromoCategory currentPromo)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_9;
        System.Func<System.Int32, System.Boolean> val_10;
        var val_11;
        var val_12;
        var val_13;
        object val_1 = new System.Object();
        if(currentPromo != 0)
        {
                int val_2 = currentPromo.RequiredQuizzesToComplete;
            val_9 = currentPromo.rewards;
        }
        else
        {
                int val_3 = 0.RequiredQuizzesToComplete;
            val_9 = 52;
        }
        
        typeof(TRVPromoCategoriesHandler.<>c__DisplayClass49_0).__il2cppRuntimeField_8 = this.GetActivePromoProgress(subcategory:  currentPromo.subCategoryName);
        Dictionary.KeyCollection<TKey, TValue> val_5 = val_9.Keys;
        System.Collections.Generic.List<TSource> val_6 = System.Linq.Enumerable.ToList<System.Int32>(source:  52);
        val_10 = null;
        val_10 = new System.Func<System.Int32, System.Boolean>(object:  354791424, method:  new IntPtr(3718987264));
        if((System.Linq.Enumerable.FirstOrDefault<System.Int32>(source:  52, predicate:  7720960)) == 0)
        {
                if(val_9 != 0)
        {
                val_12 = 52;
            val_13 = val_12;
        }
        else
        {
                val_13 = 0;
            val_12 = 0;
        }
        
            val_10 = -1;
            if(val_12 <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_9 = 52;
            val_9 = val_9 + 4294967292;
            val_11 = mem[(52 + 4294967292) + 16];
            val_11 = (52 + 4294967292) + 16;
        }
        
        if((((52 + 4294967292) + 16 - val_4)) < 1)
        {
                0 = 1;
        }
        
        return true;
    }
    private void AddSeenPromo(int promoId)
    {
        System.Collections.Generic.List<System.Int32> val_1 = this.SeenPromos;
        this.Add(item:  promoId);
        System.Collections.Generic.List<System.Int32> val_2 = this.SeenPromos;
        string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -575830720);
        UnityEngine.PlayerPrefs.SetString(key:  -580418176, value:  -575830720);
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
    }
    protected override object AddProxyEventHandler(ref System.Collections.Generic.List<WGEventHandler> existingEventHandlers)
    {
        var val_4;
        TRVPromoCategoriesHandler.LogLogic(logic:  -575738704, color:  -1544804720);
        if(this.currentPromos == 0)
        {
                return;
        }
        
        if(("AddProxyEventHandler! ...") < 1)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        label_26:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        object val_3 = new System.Object();
        typeof(TRVPromoCategoriesHandler.<>c__DisplayClass51_0).__il2cppRuntimeField_8 = val_4;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_5 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  354844672, method:  new IntPtr(3719232816));
        object val_6 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  existingEventHandlers, predicate:  7720960);
        GameEventV2 val_8 = new GameEventV2();
        typeof(GameEventV2).__il2cppRuntimeField_20 = val_4 + 16;
        typeof(GameEventV2).__il2cppRuntimeField_24 = val_4 + 20;
        typeof(GameEventV2).__il2cppRuntimeField_28 = val_4 + 16;
        typeof(GameEventV2).__il2cppRuntimeField_38 = this;
        if(new WGEventHandler() != 0)
        {
                typeof(TRVPromoCategoriesProxyEventHandler).__il2cppRuntimeField_10 = typeof(TRVPromoCategoriesHandler.<>c__DisplayClass51_0).__il2cppRuntimeField_8;
        }
        else
        {
                mem[16] = typeof(TRVPromoCategoriesHandler.<>c__DisplayClass51_0).__il2cppRuntimeField_8;
        }
        
        PreInit(eventV2:  317624320);
        Init(eventV2:  317624320);
        existingEventHandlers.Add(item:  355164160);
        string val_9 = -575733456(-575733456) + val_4 + 24(val_4 + 24);
        TRVPromoCategoriesHandler.LogLogic(logic:  -575733456, color:  -1544804720);
        goto label_26;
        label_5:
        Dispose();
    }
    protected override object RemoveExpiredProxyEventHandler(ref System.Collections.Generic.List<WGEventHandler> existingEventHandlers)
    {
        var val_10;
        string val_16;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17;
        var val_18;
        var val_19;
        var val_20;
        TRVPromoCategoriesHandler.LogLogic(logic:  -575609040, color:  -1544804720);
        val_17 = null;
        val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_18 = 4;
        goto label_3;
        label_24:
        object val_2 = new System.Object();
        if((mem[existingEventHandlers + 12]) <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[existingEventHandlers + 8] + 16) != 0)
        {
                if((mem[existingEventHandlers + 12]) <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_19 = 0;
            if((mem[existingEventHandlers + 8] + 16) != 0)
        {
                if(((mem[existingEventHandlers + 8] + 16 + 100 + (TRVPromoCategoriesProxyEventHandler.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                mem[existingEventHandlers + 8] + 16 = 0;
        }
        
            val_19 = mem[existingEventHandlers + 8] + 16;
        }
        
            typeof(TRVPromoCategoriesHandler.<>c__DisplayClass52_0).__il2cppRuntimeField_8 = val_19;
            System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  354897920, method:  new IntPtr(3719358400));
            val_20 = typeof(TRVPromoCategoriesHandler.<>c__DisplayClass52_0).__il2cppRuntimeField_8;
            if((mem[1152921512621197856].Exists(match:  8040448)) != false)
        {
                val_17 = val_17;
            System.DateTime val_6 = DateTimeCheat.UtcNow;
            System.TimeSpan val_9 = Subtract(value:  new System.DateTime() {dateData = 2621443 + 16});
            double val_12 = val_10.TotalSeconds;
            val_20 = typeof(TRVPromoCategoriesHandler.<>c__DisplayClass52_0).__il2cppRuntimeField_8;
        }
        else
        {
                val_17 = val_17;
        }
        
            Add(item:  0);
        }
        
        val_18 = 5;
        label_3:
        if((val_18 - 4) < (mem[existingEventHandlers + 12]))
        {
            goto label_24;
        }
        
        List.Enumerator<T> val_14 = GetEnumerator();
        label_31:
        if(MoveNext() == false)
        {
            goto label_26;
        }
        
        string val_17 = -575607872(-575607872) + val_16;
        TRVPromoCategoriesHandler.LogLogic(logic:  -575607872, color:  -1544804720);
        bool val_18 = existingEventHandlers.Remove(item:  val_16);
        goto label_31;
        label_26:
        Dispose();
    }
    protected override string GetProxyEventTrackingName()
    {
    
    }
    private void LoadIcon(TRVPromoCategory promoCategory)
    {
        if(promoCategory == 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  promoCategory.iconSpriteName)) == true)
        {
                return;
        }
        
        R4.LoadImage(urlPath:  R5 + 36, filename:  R5 + 40);
    }
    private void LoadQuestionImage(TRVPromoCategory promoCategory, string imageName)
    {
        string val_1 = System.String.Format(format:  -575243024, arg0:  promoCategory.subCategoryName, arg1:  imageName);
        this.LoadImage(urlPath:  -575243024, filename:  imageName);
    }
    private void LoadImage(string urlPath, string filename)
    {
        object val_13;
        float val_14;
        string val_15;
        var val_16;
        string val_17;
        string val_18;
        string val_19;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_13 = val_1;
            typeof(TRVPromoCategoriesHandler.<>c__DisplayClass56_0).__il2cppRuntimeField_8 = filename;
        }
        else
        {
                val_13 = 8;
            mem[8] = filename;
        }
        
        typeof(TRVPromoCategoriesHandler.<>c__DisplayClass56_0).__il2cppRuntimeField_C = this;
        string val_2 = -575106304(-575106304) + urlPath;
        string val_3 = System.String.Format(format:  -575106176, arg0:  -575106304, arg1:  val_13);
        val_14 = 1152921504961372160;
        TRVPromoCategoriesHandler.LogLogic(logic:  -575106176, color:  -1544804720);
        val_15 = twelvegigs.net.ImageRequest.LoadFromPreCache(filename:  mem[8], textureToSet: out  UnityEngine.Texture2D val_4 = -575091832);
        if(val_15 == false)
        {
            goto label_10;
        }
        
        string val_6 = -575106048(-575106048) + mem[8];
        TRVPromoCategoriesHandler.LogLogic(logic:  -575106048, color:  -1544804720);
        val_16 = 0;
        val_17 = mem[8];
        goto label_14;
        label_10:
        val_15 = mem[8];
        if((twelvegigs.net.ImageRequest.ImageInLocal(imgPath:  mem[8])) == false)
        {
            goto label_18;
        }
        
        string val_8 = -575105936(-575105936) + val_15;
        TRVPromoCategoriesHandler.LogLogic(logic:  -575105936, color:  -1544804720);
        if(val_1 == 0)
        {
            goto label_21;
        }
        
        val_18 = mem[8];
        val_19 = val_18;
        goto label_22;
        label_18:
        val_14 = null;
        val_14 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -575079792, method:  new IntPtr(3719861456));
        val_13 = null;
        val_13 = new System.Action(object:  354951168, method:  new IntPtr(3719862480));
        twelvegigs.net.ImageRequest val_11 = new twelvegigs.net.ImageRequest(url:  -575106304, filename:  val_15, imgComplete:  7507968, imgError:  val_13, showErrors:  false, destroy:  false, cached:  true, save:  true);
        return;
        label_21:
        val_19 = mem[8];
        val_18 = mem[8];
        label_22:
        UnityEngine.Texture2D val_12 = twelvegigs.net.ImageRequest.LoadLocally(remoteURL:  -575106304, fileName:  val_18);
        val_16 = "https://cdn.12gigs.com/";
        val_17 = val_19;
        label_14:
        this.OnImageLoaded(filename:  val_17, texture:  -575106304);
    }
    private void OnImageLoaded(string filename, UnityEngine.Texture2D texture)
    {
        UnityEngine.Object val_11;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_12;
        val_11 = texture;
        if(val_11 == 0)
        {
                string val_2 = -574975408(-574975408) + filename;
            TRVPromoCategoriesHandler.LogError(error:  -574975408);
            return;
        }
        
        int val_3 = val_11.width;
        UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  (float)val_11.height, y:  null, width:  null, height:  null);
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  (float)val_11.height, y:  null);
        UnityEngine.Sprite val_7 = UnityEngine.Sprite.Create(texture:  val_11, rect:  new UnityEngine.Rect() {m_XMin = val_5.m_XMin, m_YMin = val_5.m_YMin, m_Width = val_5.m_Width, m_Height = val_5.m_Height}, pivot:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, pixelsPerUnit:  (float)val_11.height);
        val_11 = val_11;
        val_12 = mem[1152921512621832472];
        if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            mem[1152921512621832472] = val_12;
            if(val_12 == 0)
        {
                val_12 = 0;
        }
        
        }
        
        if((val_12.ContainsKey(key:  filename)) != false)
        {
                set_Item(key:  filename, value:  val_11);
        }
        else
        {
                Add(key:  filename, value:  val_11);
        }
        
        string val_10 = -574973232(-574973232) + filename;
        TRVPromoCategoriesHandler.LogLogic(logic:  -574973232, color:  -1544804720);
    }
    private void OnImageLoaded(string filename, UnityEngine.Sprite sprite)
    {
        System.Collections.Generic.Dictionary<System.String, UnityEngine.Sprite> val_4;
        if(sprite == 0)
        {
                return;
        }
        
        val_4 = this.cachedLoadedSprites;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.cachedLoadedSprites = val_4;
            if(val_4 == 0)
        {
                val_4 = 0;
        }
        
        }
        
        if((val_4.ContainsKey(key:  filename)) != false)
        {
                this.cachedLoadedSprites.set_Item(key:  filename, value:  sprite);
            return;
        }
        
        this.cachedLoadedSprites.Add(key:  filename, value:  sprite);
    }
    private static void LogError(string error)
    {
        var val_6;
        string val_1 = -574704064(-574704064) + error;
        UnityEngine.Debug.LogError(message:  -574704064);
        CompanyDevices val_2 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        string val_4 = System.String.Format(format:  -574703952, arg0:  -577211904, arg1:  error);
        string val_5 = TRVPromoCategoriesHandler.log + -574703952(-574703952);
        TRVPromoCategoriesHandler.log = TRVPromoCategoriesHandler.log;
    }
    private static void LogLogic(string logic, string color = "ffffff")
    {
        string val_6;
        var val_7;
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_6 = 0;
        if(val_6.CompanyDevice() == false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(TRVPromoCategoriesHandler.logPromoLogic != false)
        {
                string val_3 = -574704064(-574704064) + logic;
            UnityEngine.Debug.Log(message:  -574704064);
            val_7 = null;
        }
        
        val_7 = null;
        val_6 = TRVPromoCategoriesHandler.log;
        string val_4 = System.String.Format(format:  -574703952, arg0:  color, arg1:  logic);
        string val_5 = val_6 + -574703952(-574703952);
        TRVPromoCategoriesHandler.log = val_6;
    }
    public static string GetLogicLog()
    {
        null = null;
    }
    public TRVPromoCategoriesHandler()
    {
        var val_2;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.currentPromos = null;
        val_2 = null;
        val_2 = null;
        this.lastSuccessfulResponse = System.DateTime.MinValue;
    }
    private static TRVPromoCategoriesHandler()
    {
        TRVPromoCategoriesHandler.prefs_promo_quiz_completed_key = 0;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  1800251696);
        TRVPromoCategoriesHandler.supportLangs = null;
        TRVPromoCategoriesHandler.CurrentlyShownPromo = 0;
        TRVPromoCategoriesHandler.logPromoLogic = true;
    }
    private bool <TryAddingPromoCategories>b__48_0(TRVPromoCategory p)
    {
        var val_6;
        if((this.IsPromoComplete(currentPromo:  p)) == true)
        {
                return true;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = p.timeEnd});
        double val_8 = val_6.TotalSeconds;
        if(DateTimeCheat.__il2cppRuntimeField_cctor_finished <= 0)
        {
                1 = 1;
        }
        
        return true;
    }

}
