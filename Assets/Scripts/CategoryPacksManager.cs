using UnityEngine;
public class CategoryPacksManager : MonoSingleton<CategoryPacksManager>
{
    // Fields
    public const int TOTAL_CHAPTERS_PER_PACK = 5;
    public const int DEFAULT_LEVELS_PER_PACK = 100;
    private const int DEFAULT_PACK_LEVEL_WHEN_UNOWNED = -1;
    public const string EVENT_CHAPTER_COMPLETE = "Category Chapter Complete";
    public const string EVENT_PACK_COMPLETE = "Category Pack Complete";
    public const string EVENT_PROPERTY_CATEGORY_PACK = "Category Level Pack";
    private const string PREFKEY_PACKLVLSEQ = "catpak_paklvlseq";
    private const string PREFKEY_DISCOVEREDPACKS = "catpak_discovered";
    private const string PREFKEY_PACK_LVL_PROGRESS = "catpak_lvlprog_{0}";
    private const string PREFKEY_PACK_LVL_PROGRESS_EXTRAWORDS = "catpak_lvlprog_ew_{0}";
    private static bool featureEnabled;
    private static bool isPlaying;
    public static System.Collections.Generic.List<CategoryCompletionReward> RewardBundleEcon;
    private CategoryPackData packData;
    private System.Collections.Generic.Dictionary<int, CategoryPackWordBank> wordBankDict;
    private bool categoryLevelQueued;
    public System.Action<bool, int> OnPackPurchaseComplete;
    public System.Action OnNetworkFailed;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> packLevelWordIndexSequence;
    private int packsDiscovered;
    private CategoryPackInfo <CurrentCategoryPackInfo>k__BackingField;
    private bool <IsChapterCompleted>k__BackingField;
    private int totalCompletedPacks;
    private int totalPurchasedPacks;
    private bool hasNewlyDiscoveredPacks;
    private int <PackNewlyPurchased>k__BackingField;
    private System.Action<bool> onPingResponse;
    
    // Properties
    private System.Collections.Generic.Dictionary<int, int> packLevelProgress { get; }
    public int RewardTargetPacks { get; set; }
    public int RewardCurrentPacks { get; set; }
    public static bool FeatureAvailable { get; set; }
    public static bool IsPlaying { get; }
    public CategoryPackInfo CurrentCategoryPackInfo { get; set; }
    public CategoryPackWordBank CurrentCategoryPackWordBank { get; }
    public bool IsChapterCompleted { get; set; }
    public bool IsCurrentLevelLastWithinChapter { get; }
    public int TotalCompletedPacks { get; }
    public int TotalPurchasedPacks { get; }
    public bool HasNewlyDiscoveredPacks { get; }
    public int PackNewlyPurchased { get; set; }
    public int PackNewlyCompleted { get; set; }
    public bool IsPackNewlyCompleted { get; }
    public CategoryPackData PackData { get; }
    public string LevelProgressPrefKey { get; }
    public string LevelExtraRequiredWordsProgressPrefKey { get; }
    
    // Methods
    private System.Collections.Generic.Dictionary<int, int> get_packLevelProgress()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    public int get_RewardTargetPacks()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return 2621448.CategoryRewardTargetPacks;
        }
        
        return 2621448.CategoryRewardTargetPacks;
    }
    public void set_RewardTargetPacks(int value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    public int get_RewardCurrentPacks()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return 23;
        }
        
        return 23;
    }
    public void set_RewardCurrentPacks(int value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    public static bool get_FeatureAvailable()
    {
        null = null;
        if(CategoryPacksManager.featureEnabled == false)
        {
                return false;
        }
        
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        return System.String.op_Equality(a:  null, b:  1800251696);
    }
    public static void set_FeatureAvailable(bool value)
    {
        null = null;
        CategoryPacksManager.featureEnabled = value;
    }
    public static bool get_IsPlaying()
    {
        var val_4;
        if(CategoryPacksManager.FeatureAvailable == false)
        {
                return false;
        }
        
        val_4 = null;
        val_4 = null;
        if(CategoryPacksManager.isPlaying == false)
        {
                return false;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public CategoryPackInfo get_CurrentCategoryPackInfo()
    {
    
    }
    private void set_CurrentCategoryPackInfo(CategoryPackInfo value)
    {
        this.<CurrentCategoryPackInfo>k__BackingField = value;
    }
    public CategoryPackWordBank get_CurrentCategoryPackWordBank()
    {
        if((this.<CurrentCategoryPackInfo>k__BackingField) == 0)
        {
                this = 0;
            return;
        }
        
        return this.GetWordBank(packId:  this.<CurrentCategoryPackInfo>k__BackingField.packId);
    }
    public bool get_IsChapterCompleted()
    {
        return (bool)this.<IsChapterCompleted>k__BackingField;
    }
    private void set_IsChapterCompleted(bool value)
    {
        this.<IsChapterCompleted>k__BackingField = value;
    }
    public bool get_IsCurrentLevelLastWithinChapter()
    {
        if((this.<CurrentCategoryPackInfo>k__BackingField) == 0)
        {
                this = 0;
            return (bool)this;
        }
        
        int val_4 = this.<CurrentCategoryPackInfo>k__BackingField.packId;
        int val_2 = (this.GetPackProgress(packId:  val_4)) + 1;
        val_4 = (val_4 >> 3) + (val_4 >> 31);
        if(214748364 > val_4)
        {
                0 = 1;
        }
        
        return true;
    }
    public int get_TotalCompletedPacks()
    {
        return (int)this.totalCompletedPacks;
    }
    public int get_TotalPurchasedPacks()
    {
        return (int)this.totalPurchasedPacks;
    }
    public bool get_HasNewlyDiscoveredPacks()
    {
        return (bool)this.hasNewlyDiscoveredPacks;
    }
    public int get_PackNewlyPurchased()
    {
        return (int)this.<PackNewlyPurchased>k__BackingField;
    }
    private void set_PackNewlyPurchased(int value)
    {
        this.<PackNewlyPurchased>k__BackingField = value;
    }
    public int get_PackNewlyCompleted()
    {
        return CPlayerPrefs.GetInt(key:  -1497900096, defaultValue:  0);
    }
    public void set_PackNewlyCompleted(int value)
    {
        CPlayerPrefs.SetInt(key:  -1497900096, val:  value);
    }
    public bool get_IsPackNewlyCompleted()
    {
        var val_2 = ~this.PackNewlyCompleted;
        val_2 = val_2 >> 31;
        return (bool)val_2;
    }
    public CategoryPackData get_PackData()
    {
    
    }
    public string get_LevelProgressPrefKey()
    {
        var val_2;
        if((this.<CurrentCategoryPackInfo>k__BackingField) != 0)
        {
                string val_1 = this.<CurrentCategoryPackInfo>k__BackingField.packId.ToString();
            val_2 = this.<CurrentCategoryPackInfo>k__BackingField.packId;
            return System.String.Format(format:  -1497443824, arg0:  -1497439616);
        }
        
        val_2 = "XX";
        return System.String.Format(format:  -1497443824, arg0:  -1497439616);
    }
    public string get_LevelExtraRequiredWordsProgressPrefKey()
    {
        var val_2;
        if((this.<CurrentCategoryPackInfo>k__BackingField) != 0)
        {
                string val_1 = this.<CurrentCategoryPackInfo>k__BackingField.packId.ToString();
            val_2 = this.<CurrentCategoryPackInfo>k__BackingField.packId;
            return System.String.Format(format:  -1497323440, arg0:  -1497439616);
        }
        
        val_2 = "XX";
        return System.String.Format(format:  -1497323440, arg0:  -1497439616);
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        if(CategoryPacksManager.IsPlaying == false)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        string val_3 = scene.m_Handle.name;
        35626843;
        if(0 == 2)
        {
                this.<IsChapterCompleted>k__BackingField = false;
        }
        else
        {
                this.ExitMode();
        }
        
        this.RefreshHasNewlyDiscoveredPacks();
        this.categoryLevelQueued = false;
    }
    private void OnSceneUnloaded(UnityEngine.SceneManagement.Scene scene)
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = scene.m_Handle.name;
        if(false == 2)
        {
                false = this.categoryLevelQueued;
        }
        
        if(false == false)
        {
                false = this;
            this.ExitMode();
        }
        
        this.RefreshHasNewlyDiscoveredPacks();
    }
    public void OnLevelComplete()
    {
        int val_11;
        if(CategoryPacksManager.IsPlaying == false)
        {
                return;
        }
        
        if((this.<CurrentCategoryPackInfo>k__BackingField) == 0)
        {
            goto label_5;
        }
        
        CategoryPackWordBank val_3 = this.GetWordBank(packId:  this.<CurrentCategoryPackInfo>k__BackingField.packId);
        if(this != 0)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        int val_6 = UnityEngine.Mathf.Min(a:  (this.GetPackProgress(packId:  this.<CurrentCategoryPackInfo>k__BackingField.packId)) + 1, b:  0.Size);
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_7 = val_6.packLevelProgress;
        int val_11 = this.<CurrentCategoryPackInfo>k__BackingField.packId;
        EnumerableExtentions.SetOrAdd<System.Int32, System.Int32>(dic:  val_6, key:  val_11, newValue:  val_6);
        this.RefreshTotalCompletedPacks();
        val_11 = (val_11 >> 3) + (val_11 >> 31);
        if(214748364 > val_11)
        {
                0 = 1;
        }
        
        this.<IsChapterCompleted>k__BackingField = true;
        bool val_9 = this.IsPackCompleted(packId:  this.<CurrentCategoryPackInfo>k__BackingField.packId);
        val_11 = 0;
        if(val_9 != false)
        {
                val_11 = this.<CurrentCategoryPackInfo>k__BackingField.packId;
        }
        
        val_9.PackNewlyCompleted = val_11;
        this.categoryLevelQueued = true;
        Player val_10 = App.Player;
        0.SaveState();
    }
    public override void InitMonoSingleton()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1496790912, method:  new IntPtr(2798149312));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>(object:  -1496790912, method:  new IntPtr(2798150336));
        UnityEngine.SceneManagement.SceneManager.add_sceneUnloaded(value:  162353152);
    }
    private void Start()
    {
        this.Initialize();
    }
    private void OnDestroy()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1496566912, method:  new IntPtr(2798149312));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  162459648);
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>(object:  -1496566912, method:  new IntPtr(2798150336));
        UnityEngine.SceneManagement.SceneManager.remove_sceneUnloaded(value:  162353152);
    }
    public void OpenAndPlayPack(int packId)
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PlayingChallenge = false;
        CategoryPackInfo val_2 = GetPackInfo(packId:  packId);
        this.<CurrentCategoryPackInfo>k__BackingField = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        this.categoryLevelQueued = true;
        val_4 = null;
        val_4 = null;
        CategoryPacksManager.isPlaying = true;
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void PurchasePack(int packToPurchase)
    {
        int val_2;
        int val_3;
        int val_4;
        int val_5;
        int val_10;
        int val_11;
        var val_12;
        CategoryPacksManager val_13;
        int val_14;
        decimal val_1 = GetPackUnlockCost(packId:  -1496341888);
        Player val_6 = App.Player;
        var val_7 = 0 + 64;
        val_11 = mem[(0 + 64) + (4)];
        val_10 = mem[(0 + 64) + (0)];
        val_12 = 0;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = val_10, lo = val_11, mid = mem[(0 + 64) + (8)]}, d2:  new System.Decimal() {flags = val_2, hi = val_3, lo = val_4, mid = val_5})) != false)
        {
                val_13 = this;
            val_14 = packToPurchase;
            mem[1152921511700439740] = val_14;
            bool val_9 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_2, hi = val_3, lo = val_4, mid = val_5}, source:  "Category Level Pack", externalParams:  0, animated:  false);
            this.SetPackOwned(packId:  val_14);
            Player val_10 = App.Player;
            0.SaveState();
            val_12 = 1;
        }
        else
        {
                val_13 = this;
            val_14 = packToPurchase;
            mem[1152921511700439740] = 0;
        }
        
        if(mem[1152921511700439704] == 0)
        {
                return;
        }
        
        mem[1152921511700439704].Invoke(arg1:  false, arg2:  val_14);
    }
    public bool IsPackNewlyDiscovered(int packId)
    {
        var val_6;
        var val_7;
        if((this.IsPackOwned(packId:  packId)) != false)
        {
                if((MonoExtensions.IsBitSet(value:  this.packsDiscovered, bit:  packId)) != true)
        {
                val_6 = this;
            this.SetPackDiscovered(packId:  packId);
        }
        
        }
        
        CategoryPackInfo val_3 = this.GetPackInfo(packId:  packId);
        val_7 = 0;
        if(this.IsAvailable == false)
        {
                return (bool)val_7;
        }
        
        val_7 = (MonoExtensions.IsBitSet(value:  this.packsDiscovered, bit:  packId)) ^ 1;
        return (bool)val_7;
    }
    public void SetPackDiscovered(int packId)
    {
        int val_1 = MonoExtensions.SetBit(value:  this.packsDiscovered, bit:  packId);
        this.packsDiscovered = val_1;
        UnityEngine.PlayerPrefs.SetInt(key:  -1496141888, value:  val_1);
    }
    public bool IsPackOwned(int packId)
    {
        bool val_5;
        var val_6;
        val_5 = static_value_021F9F63;
        if(val_5 != true)
        {
                val_5 = true;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = this.packLevelProgress;
        val_6 = 0;
        if((val_5.ContainsKey(key:  packId)) == false)
        {
                return true;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_3 = this.packLevelProgress;
        if(val_6.Item[packId] > 1)
        {
                val_6 = 1;
        }
        
        return true;
    }
    private void SetPackOwned(int packId)
    {
        bool val_6;
        var val_7;
        val_6 = static_value_021F9F64;
        if(val_6 != true)
        {
                val_6 = true;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = this.packLevelProgress;
        bool val_2 = val_6.ContainsKey(key:  packId);
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_3 = val_2.packLevelProgress;
        val_7 = val_2;
        if(val_2 == false)
        {
            goto label_3;
        }
        
        int val_4 = val_7.Item[packId];
        if(val_4 > 1)
        {
            goto label_6;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_5 = val_4.packLevelProgress;
        val_7 = val_4;
        val_7.set_Item(key:  packId, value:  0);
        goto label_6;
        label_3:
        val_7.Add(key:  packId, value:  0);
        label_6:
        this.RefreshTotalPurchasedPacks();
    }
    public bool IsPackCompleted(int packId = -1)
    {
        int val_5;
        var val_6;
        val_5 = packId;
        if(packId == 1)
        {
                if((this.<CurrentCategoryPackInfo>k__BackingField) != 0)
        {
                val_5 = this.<CurrentCategoryPackInfo>k__BackingField.packId;
        }
        
            if((this.<CurrentCategoryPackInfo>k__BackingField) == 0)
        {
                val_5 = 0;
        }
        
        }
        
        val_6 = 0;
        if((this.IsPackOwned(packId:  0)) == false)
        {
                return true;
        }
        
        CategoryPackWordBank val_3 = this.GetWordBank(packId:  0);
        if((this.GetPackProgress(packId:  0)) >= this.Size)
        {
                val_6 = 1;
        }
        
        return true;
    }
    public decimal GetPackUnlockCost(int packId)
    {
        CategoryPackInfo val_1 = this.GetPackInfo(packId:  R2);
        if(this != 0)
        {
                return new System.Decimal() {flags = this.packsDiscovered, hi = R2};
        }
        
        this = new System.Decimal(value:  2000);
        return new System.Decimal() {flags = this, hi = 2000};
    }
    public CategoryPackInfo GetPackInfo(int packId)
    {
        var val_3;
        object val_1 = new System.Object();
        typeof(CategoryPacksManager.<>c__DisplayClass83_0).__il2cppRuntimeField_8 = packId;
        val_3 = null;
        val_3 = null;
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  311767040, method:  new IntPtr(2799393712));
        if(CategoryPackData.packList != 0)
        {
                return CategoryPackData.packList.Find(match:  8040448);
        }
        
        return CategoryPackData.packList.Find(match:  8040448);
    }
    public CategoryPackWordBank GetWordBank(int packId)
    {
        if((this.wordBankDict.ContainsKey(key:  packId)) == false)
        {
                return;
        }
        
        CategoryPackWordBank val_2 = this.wordBankDict.Item[packId];
    }
    public CategoryColor GetColor(CategoryColorCode colorCode)
    {
        object val_1 = new System.Object();
        typeof(CategoryPacksManager.<>c__DisplayClass85_0).__il2cppRuntimeField_8 = colorCode;
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  311820288, method:  new IntPtr(2799651504));
        if(this.packData.colorList != 0)
        {
                return this.packData.colorList.Find(match:  8040448);
        }
        
        return this.packData.colorList.Find(match:  8040448);
    }
    public int GetPackProgress(int packId)
    {
        bool val_4 = static_value_021F9F68;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = this.packLevelProgress;
        bool val_2 = val_4.ContainsKey(key:  packId);
        if(val_2 == false)
        {
                return 0;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_3 = val_2.packLevelProgress;
        if(val_2 == true)
        {
                return val_2.Item[packId];
        }
        
        return val_2.Item[packId];
    }
    public int CalculateChapterFromLevel(int playerLevel, bool ignoreRangeLimitClamp = False)
    {
        if(ignoreRangeLimitClamp == false)
        {
                return UnityEngine.Mathf.Clamp(value:  214748364, min:  0, max:  4);
        }
        
        return 214748364;
    }
    public int CalculateLevelFromChapter(int chapterId)
    {
        int val_1 = chapterId + (chapterId << 2);
        val_1 = val_1 << 2;
        return UnityEngine.Mathf.Max(a:  val_1, b:  0);
    }
    public int GetCurrentChapterForPack(int packId = -1)
    {
        int val_1 = this.GetPackProgress(packId:  this.<CurrentCategoryPackInfo>k__BackingField.packId);
        return val_1.CalculateChapterFromLevel(playerLevel:  val_1, ignoreRangeLimitClamp:  false);
    }
    public string GetWordFromPack(int packId)
    {
        var val_13 = 0;
        if((this.IsPackCompleted(packId:  packId)) == true)
        {
                return;
        }
        
        CategoryPackWordBank val_2 = this.GetWordBank(packId:  packId);
        if(this == 0)
        {
                return;
        }
        
        if((this.packLevelWordIndexSequence.ContainsKey(key:  packId)) == false)
        {
            goto label_6;
        }
        
        System.Collections.Generic.List<System.Int32> val_4 = this.packLevelWordIndexSequence.Item[packId];
        if(this.packLevelWordIndexSequence == 0)
        {
            goto label_6;
        }
        
        System.Collections.Generic.List<System.Int32> val_5 = this.packLevelWordIndexSequence.Item[packId];
        if(this.packLevelWordIndexSequence >= this.Size)
        {
            goto label_9;
        }
        
        label_6:
        System.Collections.Generic.List<System.Int32> val_7 = new System.Collections.Generic.List<System.Int32>();
        if(this.Size >= 1)
        {
                var val_13 = 0;
            do
        {
            Add(item:  0);
            val_13 = val_13 + 1;
        }
        while(val_13 < this.Size);
        
        }
        
        PluginExtension.Shuffle<System.Int32>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        EnumerableExtentions.SetOrAdd<System.Int32, System.Object>(dic:  this.packLevelWordIndexSequence, key:  packId, newValue:  80883712);
        string val_10 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.packLevelWordIndexSequence);
        UnityEngine.PlayerPrefs.SetString(key:  -1494708688, value:  this.packLevelWordIndexSequence);
        label_9:
        int val_11 = this.GetPackProgress(packId:  packId);
        System.Collections.Generic.List<System.Int32> val_12 = this.packLevelWordIndexSequence.Item[packId];
        if(this.packLevelWordIndexSequence <= val_11)
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + (val_11 << 2);
        if(((0 + (val_11) << 2) + 16) >= this.packData.colorList)
        {
                return;
        }
        
        if(this.packData.colorList <= ((0 + (val_11) << 2) + 16))
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 + (((0 + (val_11) << 2) + 16) << 2);
        val_13 = mem[(0 + ((0 + (val_11) << 2) + 16) << 2) + 16];
        val_13 = (0 + ((0 + (val_11) << 2) + 16) << 2) + 16;
    }
    public CategoryCompletionReward ResolveNewlyCompletedPack()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        int val_1 = this.PackNewlyCompleted;
        if(val_1 < 0)
        {
            goto label_1;
        }
        
        int val_2 = val_1.RewardCurrentPacks;
        val_2.RewardCurrentPacks = val_2 + 1;
        val_2.PackNewlyCompleted = 0;
        int val_4 = val_2.RewardCurrentPacks;
        int val_5 = val_4.RewardTargetPacks;
        val_14 = 0;
        if(val_4 < val_5)
        {
            goto label_2;
        }
        
        val_5.RewardCurrentPacks = 0;
        GameEcon val_7 = App.getGameEcon;
        GameEcon val_8 = App.getGameEcon;
        int val_10 = UnityEngine.Mathf.Min(a:  786466 + val_5.RewardTargetPacks, b:  1079);
        val_10.RewardTargetPacks = val_10;
        val_15 = null;
        val_15 = null;
        if(CategoryPacksManager.RewardBundleEcon == 0)
        {
            goto label_11;
        }
        
        val_16 = CategoryPacksManager.RewardBundleEcon;
        val_17 = UnityEngine.Random.Range(min:  0, max:  CategoryPacksManager.RewardBundleEcon + 12);
        goto label_12;
        label_1:
        val_14 = 0;
        return;
        label_11:
        val_16 = 12;
        val_17 = UnityEngine.Random.Range(min:  0, max:  0);
        label_12:
        if(val_16 <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_14 = CategoryPacksManager.RewardBundleEcon + 8;
        val_14 = val_14 + (val_17 << 2);
        val_14 = mem[(CategoryPacksManager.RewardBundleEcon + 8 + (val_12) << 2) + 16];
        val_14 = (CategoryPacksManager.RewardBundleEcon + 8 + (val_12) << 2) + 16;
        label_2:
        Player val_13 = App.Player;
    }
    public void CreditGoalReward(CategoryCompletionReward chosenReward)
    {
        var val_3;
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
        label_22:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        var val_14 = val_3;
        val_14 = val_14 - 1;
        if(val_14 > 3)
        {
            goto label_22;
        }
        
        var val_8 = 6670904 + (6670904 + ((val_3 - 1)) << 2);
        if(val_14 == 3)
        {
                6670904 + ((val_3 - 1)) << 2 = (6670904 + ((val_3 - 1)) << 2) & ((6670904 + ((val_3 - 1)) << 2) << (6670904 + ((val_3 - 1)) << 2));
            6670904 + ((val_3 - 1)) << 2 = (6670904 + ((val_3 - 1)) << 2) & (((val_7) << (32-6670904)) | ((val_7) << 6670904));
            6670904 + ((val_3 - 1)) << 2 = (6670904 + ((val_3 - 1)) << 2) & ((IP) << 1);
            6670904 + ((val_3 - 1)) << 2 = (6670904 + ((val_3 - 1)) << 2) & ((6670904 + ((val_3 - 1)) << 2) << 2);
        }
        
        Player val_9 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_7}, source:  "Category Pack Complete", subSource:  0, externalParams:  0, doTrack:  true);
        goto label_22;
        label_3:
        Dispose();
    }
    public void HACKSetPackLastLevelOfChapterProgress()
    {
        int val_1 = this.GetCurrentChapterForPack(packId:  0);
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = val_1.packLevelProgress;
        EnumerableExtentions.SetOrAdd<System.Int32, System.Int32>(dic:  val_1, key:  this.<CurrentCategoryPackInfo>k__BackingField.packId, newValue:  (val_1.CalculateLevelFromChapter(chapterId:  val_1 + 1)) - 1);
        this.RefreshTotalCompletedPacks();
    }
    private void Initialize()
    {
        this.LoadDataIntoMemoryFromResources();
        this.LoadLocalPlayerPrefs();
        this.RefreshTotalCompletedPacks();
        this.RefreshTotalPurchasedPacks();
        this.RefreshHasNewlyDiscoveredPacks();
    }
    private void ExitMode()
    {
        null = null;
        CategoryPacksManager.isPlaying = false;
        this.<CurrentCategoryPackInfo>k__BackingField = false;
    }
    private void RefreshTotalCompletedPacks()
    {
        int val_6 = 0;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = this.packLevelProgress;
        Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        goto label_2;
        label_3:
        val_6 = val_6 + (this.IsPackCompleted(packId:  0));
        label_2:
        if(val_6.MoveNext() == true)
        {
            goto label_3;
        }
        
        val_6.Dispose();
        this.totalCompletedPacks = val_6;
    }
    private void RefreshTotalPurchasedPacks()
    {
        int val_6 = 0;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = this.packLevelProgress;
        Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        goto label_2;
        label_3:
        val_6 = val_6 + (this.IsPackOwned(packId:  0));
        label_2:
        if(val_6.MoveNext() == true)
        {
            goto label_3;
        }
        
        val_6.Dispose();
        this.totalPurchasedPacks = val_6;
    }
    private void RefreshHasNewlyDiscoveredPacks()
    {
        var val_2;
        System.Collections.Generic.List<CategoryPackInfo> val_3;
        var val_4;
        bool val_5;
        var val_3 = 0;
        label_10:
        val_2 = null;
        val_2 = null;
        val_3 = CategoryPackData.packList;
        if(val_3 >= (CategoryPackData.packList + 12))
        {
            goto label_4;
        }
        
        val_4 = null;
        val_4 = null;
        if((CategoryPackData.packList + 12) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = CategoryPackData.packList + 8;
        val_2 = val_2 + 0;
        val_3 = mem[(CategoryPackData.packList + 8 + 0) + 16];
        val_3 = (CategoryPackData.packList + 8 + 0) + 16;
        val_3 = val_3 + 1;
        if((this.IsPackNewlyDiscovered(packId:  (CategoryPackData.packList + 8 + 0) + 16 + 8)) == false)
        {
            goto label_10;
        }
        
        val_5 = 1;
        goto label_11;
        label_4:
        val_5 = false;
        label_11:
        this.hasNewlyDiscoveredPacks = val_5;
    }
    private void LoadDataIntoMemoryFromResources()
    {
        var val_24;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_25;
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_26;
        var val_27;
        var val_29;
        var val_30;
        var val_31;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_24 = public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance();
            string val_3 = PathToGameResources;
        }
        else
        {
                WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_24 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance();
            string val_5 = PathToGameResources;
        }
        
        string val_6 = -2101986464(-2101986464) + -1493608416(-1493608416);
        val_25 = "categories_packwords";
        UnityEngine.TextAsset[] val_7 = LoadAssetsFromFolder(path:  -2101986464);
        val_26 = mem[1152921511703200448];
        if(val_26 == 0)
        {
                val_26 = null;
            val_26 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            mem[1152921511703200448] = val_26;
            if(val_26 == 0)
        {
                val_26 = 0;
        }
        
        }
        
        val_26.Clear();
        val_27 = 0;
        string val_9 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_10.name;
        if((public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_10.Contains(value:  -1493608320)) != true)
        {
                val_27 = val_27 + 1;
            val_27 = 0;
        }
        
        string val_11 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_10.text;
        string val_12 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_10.Replace(oldValue:  1975550000, newValue:  1098586544);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
        System.String[] val_13 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_10.Split(separator:  478563824);
        val_25 = null;
        val_25 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
        System.String[] val_15 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_10 + 16.Split(separator:  478563824);
        val_29 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_10 + 16;
        val_30 = 5;
        var val_19 =  - 4;
        val_31 = 2;
    }
    private void LoadLocalPlayerPrefs()
    {
        this.packsDiscovered = UnityEngine.PlayerPrefs.GetInt(key:  -1496141888, defaultValue:  0);
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1494708688, defaultValue:  -2040381152);
        object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1494708688);
        this.packLevelWordIndexSequence = "catpak_paklvlseq";
    }
    private UnityEngine.TextAsset[] LoadAssetsFromFolder(string path)
    {
        return UnityEngine.Resources.LoadAll<System.Object>(path:  path);
    }
    private void WaitUntilNetwork(System.Action<bool> onResponse)
    {
        var val_5;
        this.onPingResponse = onResponse;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1493230800, method:  new IntPtr(2801711472));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static NetworkConnectivityPinger MonoSingleton<NetworkConnectivityPinger>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_5 = public static NetworkConnectivityPinger MonoSingleton<NetworkConnectivityPinger>::get_Instance().__il2cppRuntimeField_C;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_6;
        }
        
        }
        
        val_5 = 0;
        label_6:
        public static NetworkConnectivityPinger MonoSingleton<NetworkConnectivityPinger>::get_Instance().__il2cppRuntimeField_C = val_5;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PingGoogle();
    }
    private void OnNetworkReponse(bool networkAvailable)
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1493106512, method:  new IntPtr(2801711472));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static NetworkConnectivityPinger MonoSingleton<NetworkConnectivityPinger>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_4 = public static NetworkConnectivityPinger MonoSingleton<NetworkConnectivityPinger>::get_Instance().__il2cppRuntimeField_C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static NetworkConnectivityPinger MonoSingleton<NetworkConnectivityPinger>::get_Instance().__il2cppRuntimeField_C = val_4;
        this.onPingResponse.Invoke(obj:  networkAvailable);
        this.onPingResponse = 0;
        if(networkAvailable == true)
        {
                return;
        }
        
        if(this.OnNetworkFailed == 0)
        {
                return;
        }
        
        this.OnNetworkFailed.Invoke();
    }
    public CategoryPacksManager()
    {
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.packLevelWordIndexSequence = null;
    }
    private static CategoryPacksManager()
    {
        var val_16;
        System.Collections.Generic.Dictionary<WordPets.WordPetType, System.Decimal> val_17;
        CategoryPacksManager.featureEnabled = true;
        CategoryPacksManager.isPlaying = false;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        decimal val_3 = new System.Decimal(value:  250);
        Add(key:  1, value:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid});
        object val_4 = new System.Object();
        typeof(CategoryCompletionReward).__il2cppRuntimeField_8 = "Bundle1";
        typeof(CategoryCompletionReward).__il2cppRuntimeField_C = new System.Collections.Generic.Dictionary<WordPets.WordPetType, System.Decimal>();
        Add(item:  311980032);
        decimal val_6 = new System.Decimal(value:  75);
        Add(key:  2, value:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid});
        object val_7 = new System.Object();
        typeof(CategoryCompletionReward).__il2cppRuntimeField_8 = "Bundle2";
        typeof(CategoryCompletionReward).__il2cppRuntimeField_C = new System.Collections.Generic.Dictionary<WordPets.WordPetType, System.Decimal>();
        Add(item:  311980032);
        decimal val_9 = new System.Decimal(value:  150);
        Add(key:  1, value:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid});
        decimal val_10 = new System.Decimal(value:  50);
        Add(key:  2, value:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_10.lo, mid = val_10.mid});
        object val_11 = new System.Object();
        typeof(CategoryCompletionReward).__il2cppRuntimeField_8 = "Bundle3";
        typeof(CategoryCompletionReward).__il2cppRuntimeField_C = new System.Collections.Generic.Dictionary<WordPets.WordPetType, System.Decimal>();
        Add(item:  311980032);
        val_16 = null;
        val_17 = 1152921504685600768;
        Add(key:  3, value:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
        object val_13 = new System.Object();
        typeof(CategoryCompletionReward).__il2cppRuntimeField_8 = "Bundle4";
        typeof(CategoryCompletionReward).__il2cppRuntimeField_C = new System.Collections.Generic.Dictionary<WordPets.WordPetType, System.Decimal>();
        Add(item:  311980032);
         = new System.Collections.Generic.Dictionary<WordPets.WordPetType, System.Decimal>();
        Add(key:  4, value:  new System.Decimal() {flags = System.Decimal.One, hi = System.Decimal.Powers10.__il2cppRuntimeField_18, lo = System.Decimal.Powers10.__il2cppRuntimeField_1C, mid = System.Decimal.Powers10.__il2cppRuntimeField_20});
        object val_15 = new System.Object();
        typeof(CategoryCompletionReward).__il2cppRuntimeField_8 = "Bundle5";
        typeof(CategoryCompletionReward).__il2cppRuntimeField_C = ;
        Add(item:  311980032);
        CategoryPacksManager.RewardBundleEcon = null;
    }

}
