using UnityEngine;
public class LimitedTimeBundlesManager : MonoSingleton<LimitedTimeBundlesManager>
{
    // Fields
    private const string pref_purchases = "ltb_purchases";
    private const string pref_popup_shown = "ltb_popup_lvl";
    public const string DICE_BUNDLE = "id_bundles6";
    public const string CAP = "sb_pc";
    public const string DISPLAY_EXTRA = "xtra";
    public const string TOTAL_VALUE = "total";
    private static string _LastBundlePurchase;
    private static int Interval;
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> _BundlesPackages;
    private static System.Collections.Generic.List<string> _BundlePackagesKeys;
    public static System.Collections.Generic.Dictionary<string, string> BundleLocKeys;
    public static System.Collections.Generic.Dictionary<string, string> BundleTitles;
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> _BundlePurchaseCountsPerTimeFrame;
    private static System.Collections.Generic.List<LimitedTimeframe> LimitedTimeframes;
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<LimitedTimeframe>> BundleTimeframes;
    public LimitedTimeBundlesPackDisplayManager CurrentPackDisplay;
    private LimitedTimeBundlesHeader _prefab_limited_time_bundle_header;
    private LimitedTimeBundlePackDisplay _prefab_limited_time_bundle;
    private GameStoreCategory gameStoreCategory;
    private bool isLevelCompleteListenerAdded;
    private LimitedTimeBundlesStatus status;
    public System.Action OnStoreRefreshPackItems;
    
    // Properties
    public static string MEDIUM { get; }
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> BundlesPackages { get; }
    public static System.Collections.Generic.List<string> BundlePackagesKeys { get; }
    public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> BundlePurchaseCountsPerTimeFrame { get; }
    public LimitedTimeBundlesHeader prefab_limited_time_bundle_header { get; }
    public LimitedTimeBundlePackDisplay prefab_limited_time_bundle { get; }
    public LimitedTimeBundlesStatus Status { get; }
    
    // Methods
    public static string get_MEDIUM()
    {
        var val_1;
        var val_1 = 26221919;
        val_1 = 9403868 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(App.game == 17)
        {
                "id_bundles5" = "trivia_star_bundle1";
        }
    
    }
    private static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> get_BundlesPackages()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if(LimitedTimeBundlesManager._BundlesPackages == 0)
        {
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_6 = null;
            val_6 = null;
            LimitedTimeBundlesManager._BundlesPackages = null;
            LimitedTimeBundlesManager.PopulateBundlesPackages(key:  -1164149280, bundlesPackagesRef: ref  System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_2 = 326520840);
            string val_3 = LimitedTimeBundlesManager.MEDIUM;
            LimitedTimeBundlesManager.PopulateBundlesPackages(key:  -1164149280, bundlesPackagesRef: ref  System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_4 = 326520840);
            val_5 = null;
        }
        
        val_5 = null;
    }
    private static void PopulateBundlesPackages(string key, ref System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> bundlesPackagesRef)
    {
        object val_1 = new System.Object();
        typeof(LimitedTimeBundlesManager.<>c__DisplayClass13_0).__il2cppRuntimeField_8 = key;
        PackageDefinitions val_2 = PackagesManager.getDef;
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  326569984, method:  new IntPtr(3130938224));
        object val_4 = 0.Find(match:  8040448);
        if(0 == 0)
        {
                return;
        }
        
        bundlesPackagesRef.Add(key:  typeof(LimitedTimeBundlesManager.<>c__DisplayClass13_0).__il2cppRuntimeField_8, value:  0);
    }
    public static System.Collections.Generic.List<string> get_BundlePackagesKeys()
    {
        System.Collections.Generic.List<System.String> val_4 = null;
        if(LimitedTimeBundlesManager._BundlePackagesKeys == 0)
        {
                System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = LimitedTimeBundlesManager.BundlesPackages;
            Dictionary.KeyCollection<TKey, TValue> val_2 = Keys;
            System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Object>(source:  326516736);
            val_4 = null;
            LimitedTimeBundlesManager._BundlePackagesKeys = val_4;
        }
        
        val_4 = null;
    }
    public static System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, int>> get_BundlePurchaseCountsPerTimeFrame()
    {
        var val_3 = null;
        if(LimitedTimeBundlesManager._BundlePurchaseCountsPerTimeFrame == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1163792864, defaultValue:  -2040381152);
            object val_2 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1163792864);
            val_3 = null;
            val_3 = null;
            LimitedTimeBundlesManager._BundlePurchaseCountsPerTimeFrame = "ltb_purchases";
        }
        
        val_3 = null;
    }
    public LimitedTimeBundlesHeader get_prefab_limited_time_bundle_header()
    {
        if(this._prefab_limited_time_bundle_header != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1262000640);
        this._prefab_limited_time_bundle_header = "Store";
    }
    public LimitedTimeBundlePackDisplay get_prefab_limited_time_bundle()
    {
        if(this._prefab_limited_time_bundle != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1262000640);
        this._prefab_limited_time_bundle = "Store";
    }
    public LimitedTimeBundlesStatus get_Status()
    {
        if(this.status != 0)
        {
                return;
        }
        
        EventProgression val_1 = new EventProgression();
        mem2[0] = val_1;
        if(val_1 != 0)
        {
                return;
        }
    
    }
    private void OnDestroy()
    {
        var val_7;
        var val_8;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1163274688, method:  new IntPtr(3131666560));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_7 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_6;
        }
        
        }
        
        val_7 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_7;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -1163274688, method:  new IntPtr(3131667584));
        System.Delegate val_6 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, value:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_10;
        }
        
        }
        
        val_8 = 0;
        label_10:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_8;
    }
    public override void InitMonoSingleton()
    {
        var val_11;
        var val_12;
        System.Delegate val_13;
        var val_14;
        System.Action val_15;
        System.Delegate val_16;
        var val_17;
        System.Delegate val_18;
        var val_19;
        this.InitMonoSingleton();
        GameEcon val_1 = App.getGameEcon;
        val_11 = null;
        val_11 = null;
        LimitedTimeBundlesManager.Interval = 0;
        val_12 = null;
        val_12 = null;
        System.Action val_2 = new System.Action(object:  -1163158592, method:  new IntPtr(3131781632));
        val_13 = GameStoreUI.OnCreatePackItems;
        System.Delegate val_3 = System.Delegate.Combine(a:  val_13, b:  7454720);
        val_14 = null;
        val_15 = null;
        if(val_13 == 0)
        {
            goto label_8;
        }
        
        if(null == val_15)
        {
            goto label_9;
        }
        
        val_15 = null;
        val_14 = 1152921504929316956;
        label_8:
        val_13 = 0;
        label_9:
        GameStoreUI.OnCreatePackItems = val_13;
        val_15 = new System.Action(object:  -1163158592, method:  new IntPtr(3131782656));
        val_16 = GameStoreUI.OnRefreshDisplay;
        System.Delegate val_5 = System.Delegate.Combine(a:  val_16, b:  7454720);
        if(val_16 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_16 = 0;
        label_11:
        GameStoreUI.OnRefreshDisplay = val_16;
        val_17 = null;
        val_17 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1163158592, method:  new IntPtr(3131783680));
        val_18 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_7 = System.Delegate.Combine(a:  val_18, b:  7401472);
        if(val_18 != 0)
        {
                if(null == null)
        {
            goto label_15;
        }
        
        }
        
        val_18 = 0;
        label_15:
        PurchasesHandler.OnPurchaseCompleted = val_18;
        WordPets.WPTDataParser val_8 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_9 = new System.Action<Result>(object:  -1163158592, method:  new IntPtr(3131666560));
        System.Delegate val_10 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_19 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_19 != 0)
        {
                if(val_19 == null)
        {
            goto label_21;
        }
        
        }
        
        val_19 = 0;
        label_21:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_19;
    }
    public static void DigestBundleKnobs(System.Collections.Generic.Dictionary<string, object> knobs)
    {
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        val_29 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                return;
        }
        
        GameEcon val_3 = App.getGameEcon;
        val_30 = 1152921510392296080;
        if((knobs.ContainsKey(key:  -1163066496)) != false)
        {
                object val_5 = knobs.Item[-1163066496];
            string val_6 = knobs.ToString();
            val_31 = null;
            val_31 = null;
            bool val_8 = System.Int32.TryParse(s:  knobs, result: out  int val_7 = 326520836);
        }
        
        if((knobs.ContainsKey(key:  -1163066416)) != false)
        {
                object val_10 = knobs.Item[-1163066416];
            string val_11 = knobs.ToString();
            bool val_13 = System.Int32.TryParse(s:  knobs, result: out  int val_12 = -1163051148);
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_14 = LimitedTimeBundlesManager.BundlesPackages;
            string val_15 = LimitedTimeBundlesManager.MEDIUM;
            string val_16 = Item[326516736];
            set_Item(key:  -1166039264, value:  13152256);
        }
        
        if((knobs.ContainsKey(key:  -1649936592)) != false)
        {
                object val_18 = knobs.Item[-1649936592];
            string val_19 = knobs.ToString();
            bool val_21 = System.Int32.TryParse(s:  knobs, result: out  int val_20 = -1163051144);
        }
        
        GameEcon val_22 = App.getGameEcon;
        val_32 = "sch";
        if((knobs.ContainsKey(key:  -1163065312)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_24 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_33 = null;
        val_33 = null;
        LimitedTimeBundlesManager.LimitedTimeframes = null;
        object val_25 = knobs.Item[-1163065312];
        val_34 = 0;
        if(knobs != 0)
        {
                val_34 = 0;
            if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                knobs = 0;
        }
        
            val_34 = knobs;
        }
        
        val_30 = 4;
        goto label_42;
        label_56:
        if(knobs <= knobs)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_35 = 2621443;
        if(val_35 == 0)
        {
            goto label_44;
        }
        
        if(0 > knobs)
        {
            goto label_45;
        }
        
        val_36 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_35 = 2621443;
        if(val_35 == 0)
        {
            goto label_47;
        }
        
        label_45:
        val_36 = 0;
        if(((mem[406885476] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_35 = 0;
        }
        
        val_36 = val_35;
        label_47:
        val_37 = null;
        val_37 = null;
        string val_26 = val_36.Item[-1605007504];
        val_32 = val_36;
        string val_27 = val_36.Item[-1163064208];
        val_29 = val_36;
        LimitedTimeframe val_28 = new LimitedTimeframe(date:  null, duration:  null);
        Add(item:  327208960);
        label_44:
        val_30 = 5;
        label_42:
        if((val_30 - 4) < 0)
        {
            goto label_56;
        }
    
    }
    public static void DigestBundleKnobsV2(System.Collections.Generic.Dictionary<string, object> knobs)
    {
        var val_32;
        var val_33;
        float val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        val_32 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        val_33 = 1152921510392296080;
        if((knobs.ContainsKey(key:  -1162942912)) != false)
        {
                object val_3 = knobs.Item[-1162942912];
            string val_4 = knobs.ToString();
            GameEcon val_5 = App.getGameEcon;
            bool val_7 = System.Int32.TryParse(s:  knobs, result: out  0 + 8);
        }
        
        if((knobs.ContainsKey(key:  -1162942832)) != false)
        {
                object val_9 = knobs.Item[-1162942832];
            string val_10 = knobs.ToString();
            GameEcon val_11 = App.getGameEcon;
            bool val_13 = System.Int32.TryParse(s:  knobs, result: out  0 + 12);
        }
        
        val_34 = "sb_pc";
        if((knobs.ContainsKey(key:  -1166039264)) != false)
        {
                object val_15 = knobs.Item[-1166039264];
            string val_16 = knobs.ToString();
            GameEcon val_17 = App.getGameEcon;
            bool val_19 = System.Int32.TryParse(s:  knobs, result: out  0 + 16);
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_20 = LimitedTimeBundlesManager.BundlesPackages;
            string val_21 = LimitedTimeBundlesManager.MEDIUM;
            string val_22 = Item[326516736];
            GameEcon val_23 = App.getGameEcon;
            set_Item(key:  -1166039264, value:  13152256);
        }
        
        if((knobs.ContainsKey(key:  -1163065312)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_25 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_35 = null;
        val_35 = null;
        LimitedTimeBundlesManager.LimitedTimeframes = null;
        val_34 = 1152921510385703632;
        object val_26 = knobs.Item[-1163065312];
        val_36 = 0;
        if(knobs != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                knobs = 0;
        }
        
            val_36 = knobs;
        }
        
        val_32 = 4;
        val_33 = 1152921512033717440;
        label_57:
        if(0 >= 0)
        {
            goto label_44;
        }
        
        if(0 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_37 = 2621443;
        if(val_37 == 0)
        {
            goto label_46;
        }
        
        if(0 > 0)
        {
            goto label_47;
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_37 = 2621443;
        if(val_37 == 0)
        {
            goto label_49;
        }
        
        label_47:
        label_49:
        string val_27 = 0.Item[-1605007504];
        string val_28 = 0.Item[-1163064208];
        LimitedTimeframe val_29 = new LimitedTimeframe(date:  null, duration:  null);
        val_38 = null;
        val_38 = null;
        Add(item:  327208960);
        label_46:
        val_32 = val_32 + 1;
        goto label_57;
        label_44:
        val_39 = null;
        val_39 = null;
        string val_30 = LimitedTimeBundlesManager.MEDIUM;
        object val_31 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  LimitedTimeBundlesManager.BundleTimeframes, key:  326520832, defaultValue:  80883712);
    }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> GetAllBundles()
    {
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = LimitedTimeBundlesManager.BundlesPackages;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  326516736);
    }
    public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, object>> GetAvailableBundles()
    {
        ulong val_8;
        var val_11;
        var val_18;
        System.Collections.Generic.List<LimitedTimeframe> val_28;
        float val_41;
        var val_42;
        var val_43;
        float val_44;
        val_41 = this;
        val_42 = 1152921504933363712;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = LimitedTimeBundlesManager.BundlesPackages;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  326516736);
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            goto label_7;
        }
        
        System.DateTime val_4 = GetTimeEnd();
        System.DateTime val_5 = GetTimeStart();
        System.TimeSpan val_10 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512034085960}, d2:  new System.DateTime() {dateData = val_8});
        double val_13 = val_11.TotalDays;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
        {
                3132271760 = 3132271760;
        }
        
        System.DateTime val_14 = GetTimeStart();
        System.DateTime val_17 = ToLocalTime();
        string val_20 = val_18.ToString();
        string val_21 = ToString();
        LimitedTimeframe val_22 = new LimitedTimeframe(date:  -1162695544, duration:  -1162695528);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_23 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  327208960);
        LimitedTimeframe val_24 = GetValidLimitedTimeframe(limitedTimeframes:  80883712);
        val_41 = val_41;
        val_42 = 1152921504933363712;
        if(null != 0)
        {
            goto label_17;
        }
        
        label_7:
        bool val_25 = Remove(key:  -1164149280);
        label_17:
        val_43 = null;
        Dictionary.Enumerator<TKey, TValue> val_26 = GetEnumerator();
        label_25:
        bool val_27 = 0.MoveNext();
        if(val_27 == false)
        {
            goto label_22;
        }
        
        LimitedTimeframe val_29 = val_27.GetValidLimitedTimeframe(limitedTimeframes:  val_28);
        if(val_27 == true)
        {
            goto label_25;
        }
        
        bool val_30 = Remove(key:  0);
        goto label_25;
        label_22:
        0.Dispose();
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_31 = this.GetCurrentBundlePurchaseCounts();
        if(val_41 == 0)
        {
                return;
        }
        
        if(this.Count < 1)
        {
                return;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_33 = GetEnumerator();
        val_41 = 1152921511156413904;
        val_44 = 1152921512034073056;
        label_36:
        if(0.MoveNext() == false)
        {
            goto label_28;
        }
        
        if((ContainsKey(key:  0)) == false)
        {
            goto label_36;
        }
        
        string val_36 = Item[null];
        string val_37 = Item[-1166039264];
        string val_38 = ToString();
        if((System.Int32.Parse(s:  78753792)) > R8)
        {
            goto label_36;
        }
        
        bool val_40 = Remove(key:  0);
        goto label_36;
        label_28:
        0.Dispose();
    }
    public bool HaveBundlesToShow()
    {
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        val_5 = 0;
        if(0 == 0)
        {
                return true;
        }
        
        LimitedTimeframe val_2 = this.GetCurrentLimitedTimeframe();
        if(0 == 0)
        {
                return true;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_3 = this.GetAvailableBundles();
        if(this.Count > 0)
        {
                val_5 = 1;
        }
        
        return true;
    }
    public bool ShouldShowBundlesPopup()
    {
        var val_18;
        LimitedTimeBundlePackDisplay val_19;
        var val_20;
        var val_21;
        LimitedTimeBundlesHeader val_22;
        int val_23;
        var val_24;
        val_18 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                Player val_2 = App.Player;
            val_19 = 0;
            GameEcon val_3 = App.getGameEcon;
            val_20 = 0;
            if(val_19 <= 0)
        {
                return (bool)R5;
        }
        
            System.Collections.Generic.List<System.String> val_4 = LimitedTimeBundlesManager.BundlePackagesKeys;
            val_19 = null;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((this.GetCurrentCountOfBundlePurchase(bundleId:  LimitedTimeBundlesManager.__il2cppRuntimeField_10)) > 0)
        {
                return (bool)R5;
        }
        
            LimitedTimeBundlesStatus val_6 = this.Status;
            val_19 = this._prefab_limited_time_bundle;
            GameEcon val_7 = App.getGameEcon;
            val_20 = 0;
            if(val_19 >= 1)
        {
                return (bool)R5;
        }
        
            if(this.HaveBundlesToShow() == false)
        {
                return (bool)R5;
        }
        
            Player val_9 = App.Player;
            val_19 = 0;
            GameEcon val_10 = App.getGameEcon;
            var val_17 = 0;
            val_20 = 1;
            val_17 = val_17 + 1;
            if(val_19 == val_17)
        {
                return (bool)R5;
        }
        
            GameBehavior val_11 = App.getBehavior;
            val_21 = 0;
            LimitedTimeBundlesStatus val_12 = this.Status;
            val_22 = this._prefab_limited_time_bundle_header;
            GameEcon val_13 = App.getGameEcon;
            val_23 = 0;
        }
        else
        {
                val_20 = 0;
            if(this.HaveBundlesToShow() == false)
        {
                return (bool)R5;
        }
        
            GameBehavior val_15 = App.getBehavior;
            val_21 = 0;
            LimitedTimeBundlesStatus val_16 = this.Status;
            val_22 = this._prefab_limited_time_bundle_header;
            val_24 = null;
            val_24 = null;
            val_23 = LimitedTimeBundlesManager.Interval;
        }
        
        if(val_21 == 0)
        {
            
        }
    
    }
    public int GetCurrentCountOfBundlePurchase(string bundleId)
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = this.GetCurrentBundlePurchaseCounts();
        if(this == 0)
        {
                return 0;
        }
        
        if(this.Count < 1)
        {
                return 0;
        }
        
        if((this.ContainsKey(key:  bundleId)) == false)
        {
                return 0;
        }
        
        return this.Item[bundleId];
    }
    public System.Collections.Generic.List<string> RerollLettersForLastBundlePurchase()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((System.String.IsNullOrEmpty(value:  LimitedTimeBundlesManager._LastBundlePurchase)) != false)
        {
                UnityEngine.Debug.LogError(message:  -1162225696);
            return;
        }
        
        val_3 = null;
        val_3 = null;
        return RollLetters(bundleID:  LimitedTimeBundlesManager._LastBundlePurchase);
    }
    private void Instance_OnSceneLoaded(SceneType obj)
    {
        UnityEngine.Events.UnityAction val_5 = 35632229;
        if(obj != 2)
        {
                return;
        }
        
        val_5 = 1152921504885600256;
        MainController val_1 = MainController.instance;
        if(0 == 0)
        {
                return;
        }
        
        MainController val_3 = MainController.instance;
        val_5 = null;
        val_5 = new UnityEngine.Events.UnityAction(object:  -1162084304, method:  new IntPtr(3132857968));
        1.AddListener(call:  162246656);
        this.isLevelCompleteListenerAdded = true;
    }
    private void Instance_OnSceneUnloaded(SceneType obj)
    {
        if(this.isLevelCompleteListenerAdded == false)
        {
                return;
        }
        
        MainController val_1 = MainController.instance;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1161964112, method:  new IntPtr(3132857968));
        1.RemoveListener(call:  162246656);
        this.isLevelCompleteListenerAdded = false;
    }
    public void OnLevelComplete()
    {
        var val_2;
        LimitedTimeBundlesHeader val_3;
        LimitedTimeBundlesStatus val_1 = this.Status;
        if(this != 0)
        {
                val_2 = this;
            val_3 = this._prefab_limited_time_bundle_header;
        }
        else
        {
                val_2 = 16;
            val_3 = 2621443;
        }
        
        mem[16] = 2621444;
    }
    private System.Collections.Generic.Dictionary<string, int> GetCurrentBundlePurchaseCounts()
    {
        bool val_7;
        var val_8;
        val_7 = static_value_021FB467;
        if(val_7 != true)
        {
                val_7 = true;
        }
        
        LimitedTimeframe val_1 = this.GetCurrentLimitedTimeframe();
        val_8 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        LimitedTimeframe val_2 = this.GetCurrentLimitedTimeframe();
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_3 = LimitedTimeBundlesManager.BundlePurchaseCountsPerTimeFrame;
        if((ContainsKey(key:  1)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_5 = LimitedTimeBundlesManager.BundlePurchaseCountsPerTimeFrame;
        string val_6 = Item[1];
        val_8 = null;
    }
    private void AddBundlePurchaseCountForTimeFrame(string bundleId)
    {
        bool val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_18 = static_value_021FB468;
        if(val_18 != true)
        {
                val_18 = true;
        }
        
        LimitedTimeframe val_1 = this.GetCurrentLimitedTimeframe();
        if(val_18 == 0)
        {
            goto label_1;
        }
        
        LimitedTimeframe val_2 = this.GetCurrentLimitedTimeframe();
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_3 = LimitedTimeBundlesManager.BundlePurchaseCountsPerTimeFrame;
        if((ContainsKey(key:  1)) == false)
        {
            goto label_6;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_6 = LimitedTimeBundlesManager.BundlePurchaseCountsPerTimeFrame;
        val_19 = null;
        string val_7 = Item[1];
        if(val_19 == 0)
        {
            goto label_10;
        }
        
        val_20 = val_19;
        if((ContainsKey(key:  bundleId)) == false)
        {
            goto label_20;
        }
        
        val_19 = Item[bundleId];
        goto label_12;
        label_1:
        UnityEngine.Debug.LogError(message:  -1161633680);
        return;
        label_6:
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_10 = LimitedTimeBundlesManager.BundlePurchaseCountsPerTimeFrame;
        val_19 = null;
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_11 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        Add(key:  bundleId, value:  1);
        Add(key:  1, value:  78753792);
        goto label_21;
        label_10:
        val_21 = 0;
        val_19 = 0.ContainsKey(key:  bundleId);
        if(val_19 == false)
        {
            goto label_20;
        }
        
        val_22 = 0;
        val_19 = 0.Item[bundleId];
        label_12:
        val_22.set_Item(key:  bundleId, value:  val_19 + 1);
        goto label_21;
        label_20:
        Add(key:  bundleId, value:  1);
        label_21:
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Int32>> val_15 = LimitedTimeBundlesManager.BundlePurchaseCountsPerTimeFrame;
        string val_16 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  326516736);
        UnityEngine.PlayerPrefs.SetString(key:  -1163792864, value:  326516736);
        bool val_17 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private LimitedTimeframe GetCurrentLimitedTimeframe()
    {
        var val_6;
        var val_13;
        var val_20;
        var val_22;
        var val_23;
        var val_24;
        System.Func<LimitedTimeframe, System.Boolean> val_26;
        val_20 = null;
        val_20 = null;
        System.Collections.Generic.List<ZooTile> val_1 = new System.Collections.Generic.List<ZooTile>(collection:  LimitedTimeBundlesManager.LimitedTimeframes);
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                System.DateTime val_3 = GetTimeEnd();
            System.DateTime val_4 = GetTimeStart();
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512035281256}, d2:  new System.DateTime());
            double val_8 = val_6.TotalDays;
            if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
        {
                3133467016 = 3133467016;
        }
        
            System.DateTime val_9 = GetTimeStart();
            System.DateTime val_12 = ToLocalTime();
            string val_15 = val_13.ToString();
            val_22 = ;
            string val_16 = ToString();
            val_23;
            LimitedTimeframe val_17 = new LimitedTimeframe(date:  -1161500288, duration:  -1161500268);
            Add(item:  327208960);
        }
        
        if(null == 0)
        {
                return;
        }
        
        val_23 = 1152921504933470208;
        val_24 = null;
        val_24 = null;
        val_26 = LimitedTimeBundlesManager.<>c.<>9__52_0;
        if(val_26 == 0)
        {
                val_26 = null;
            val_26 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  LimitedTimeBundlesManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3133451984));
            LimitedTimeBundlesManager.<>c.<>9__52_0 = val_26;
        }
        
        object val_19 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  80883712, predicate:  7720960);
    }
    private LimitedTimeframe GetValidLimitedTimeframe(System.Collections.Generic.List<LimitedTimeframe> limitedTimeframes)
    {
        var val_3;
        System.Func<LimitedTimeframe, System.Boolean> val_5;
        if(limitedTimeframes == 0)
        {
                return;
        }
        
        if(limitedTimeframes < 1)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        val_5 = LimitedTimeBundlesManager.<>c.<>9__53_0;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  LimitedTimeBundlesManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3133571152));
            LimitedTimeBundlesManager.<>c.<>9__53_0 = val_5;
        }
        
        object val_2 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  limitedTimeframes, predicate:  7720960);
    }
    public System.DateTime GetCurrentOfferEndTime()
    {
        LimitedTimeframe val_1 = this.GetCurrentLimitedTimeframe();
        System.DateTime val_2 = this.AddDays(value:  null);
        return new System.DateTime() {dateData = val_2.dateData};
    }
    public int GetHighestExtraDisplay()
    {
        var val_8;
        var val_9;
        var val_10;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_1 = this.GetAvailableBundles();
        string val_2 = LimitedTimeBundlesManager.MEDIUM;
        if((this.ContainsKey(key:  326516736)) != false)
        {
                string val_4 = LimitedTimeBundlesManager.MEDIUM;
            val_8 = null;
            val_9 = 1152921512033715232;
        }
        else
        {
                val_10 = 0;
            if((this.ContainsKey(key:  -1164149280)) == false)
        {
                return (int)null;
        }
        
            val_9 = 1152921512033715232;
            val_8 = "id_bundles6";
        }
        
        string val_6 = this.Item[-1164149280];
        string val_7 = this.Item[-1166030768];
        this.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        return (int)null;
    }
    private void OnStoreCreatePackItems()
    {
        ulong val_11;
        if(this.HaveBundlesToShow() == false)
        {
                return;
        }
        
        if(this.gameStoreCategory == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameStoreCategory val_4 = GetOrCreateCategory(categoryTitle:  -1161042736, showTitle:  false, siblingIndex:  0);
            this.gameStoreCategory = public static GameStoreUI MonoSingleton<GameStoreUI>::get_Instance();
        }
        
        LimitedTimeBundlesHeader val_5 = this.prefab_limited_time_bundle_header;
        UnityEngine.Transform val_6 = this.gameStoreCategory.XfmPackageContents;
        object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  -1161004304, parent:  this.gameStoreCategory);
        string val_9 = this.GetHighestExtraDisplay().ToString();
        System.DateTime val_10 = GetCurrentOfferEndTime();
        this.Setup(freeAmount:  -1161016332, endTime:  new System.DateTime() {dateData = val_11});
        UnityEngine.GameObject val_13 = this.gameStoreCategory.gameObject;
        object val_14 = this.gameStoreCategory.AddComponent<System.Object>();
        UnityEngine.Transform val_15 = this.gameStoreCategory.XfmPackageContents;
        this.gameStoreCategory.CreatePackItems(packItemContainer:  this.gameStoreCategory, popupContainer:  0);
    }
    private void OnStoreRefreshDisplay()
    {
        if(this.CurrentPackDisplay == 0)
        {
                return;
        }
        
        R4 + 12.RefreshPackItems();
    }
    private void OnPurchaseCompleted(PurchaseModel purchased)
    {
        PurchaseModel val_10;
        var val_11;
        LimitedTimeBundlesPackDisplayManager val_12;
        var val_13;
        val_10 = purchased;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_11 = val_1;
            typeof(LimitedTimeBundlesManager.<>c__DisplayClass58_0).__il2cppRuntimeField_8 = val_10;
        }
        else
        {
                val_11 = 8;
            mem[8] = val_10;
            val_10 = mem[8];
        }
        
        val_12 = mem[purchased + 12];
        val_12 = purchased + 12;
        if((val_12.Contains(value:  -1252680496)) == false)
        {
                return;
        }
        
        val_12 = this.CurrentPackDisplay;
        if(val_12 == 0)
        {
                return;
        }
        
        PackageDefinitions val_4 = PackagesManager.getDef;
        System.Predicate<ZooTile> val_5 = new System.Predicate<ZooTile>(object:  326676480, method:  new IntPtr(3134195760));
        object val_6 = 0.Find(match:  8040448);
        if(0 != 0)
        {
                val_13 = null;
            val_13 = null;
            LimitedTimeBundlesManager._LastBundlePurchase = purchased + 12;
            System.Collections.Generic.List<System.String> val_7 = LimitedTimeBundlesManager._LastBundlePurchase.RollLetters(bundleID:  purchased + 12);
            this.CurrentPackDisplay.PrepareBundlePurchaseSuccess(alphabetLettersPurchased:  326520832);
            string val_8 = 0.Item[1624646480];
            this.AddBundlePurchaseCountForTimeFrame(bundleId:  null);
            return;
        }
        
        string val_9 = -1160766288(-1160766288) + purchased + 12(purchased + 12) + -1160766416(-1160766416);
        UnityEngine.Debug.LogError(message:  -1160766288);
    }
    private System.Collections.Generic.List<string> RollLetters(string bundleID)
    {
        System.Predicate<ZooTile> val_27;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_28;
        var val_29;
        object val_1 = new System.Object();
        typeof(LimitedTimeBundlesManager.<>c__DisplayClass59_0).__il2cppRuntimeField_8 = bundleID;
        PackageDefinitions val_2 = PackagesManager.getDef;
        val_27 = null;
        val_27 = new System.Predicate<ZooTile>(object:  326729728, method:  new IntPtr(3134329520));
        object val_4 = 0.Find(match:  8040448);
        if(0 != 0)
        {
                val_28 = null;
            val_28 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_29 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if((0.ContainsKey(key:  306335744)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_29 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_8 = 0.Item[306335744];
            System.Collections.Generic.List<System.String> val_10 = RollLettersForRarity(rarity:  0, count:  System.Int32.Parse(s:  null));
            AddRange(collection:  -2100700048);
        }
        
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if((0.ContainsKey(key:  306335744)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_29 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_13 = 0.Item[306335744];
            System.Collections.Generic.List<System.String> val_15 = RollLettersForRarity(rarity:  1, count:  System.Int32.Parse(s:  null));
            AddRange(collection:  -2100700048);
        }
        
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if((0.ContainsKey(key:  306335744)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_29 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_18 = 0.Item[306335744];
            System.Collections.Generic.List<System.String> val_20 = RollLettersForRarity(rarity:  2, count:  System.Int32.Parse(s:  null));
            AddRange(collection:  -2100700048);
        }
        
            val_27 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if((0.ContainsKey(key:  306335744)) == false)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_27 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
            val_29 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_23 = 0.Item[306335744];
            System.Collections.Generic.List<System.String> val_25 = RollLettersForRarity(rarity:  3, count:  System.Int32.Parse(s:  null));
            AddRange(collection:  -2100700048);
            return;
        }
        
        val_28 = 0;
        string val_26 = -1160766288(-1160766288) + typeof(LimitedTimeBundlesManager.<>c__DisplayClass59_0).__il2cppRuntimeField_8(typeof(LimitedTimeBundlesManager.<>c__DisplayClass59_0).__il2cppRuntimeField_8) + -1160766416(-1160766416);
        UnityEngine.Debug.LogError(message:  -1160766288);
    }
    public LimitedTimeBundlesManager()
    {
    
    }
    private static LimitedTimeBundlesManager()
    {
        LimitedTimeBundlesManager._LastBundlePurchase = "";
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_1 != 0)
        {
                Add(key:  -1164262400, value:  -1160407632);
        }
        else
        {
                Add(key:  -1164262400, value:  -1160407632);
        }
        
        Add(key:  -1164149280, value:  -1160407504);
        Add(key:  -1164262512, value:  -1160407408);
        LimitedTimeBundlesManager.BundleLocKeys = val_1;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(val_2 != 0)
        {
                Add(key:  -1164262400, value:  -1160407312);
        }
        else
        {
                Add(key:  -1164262400, value:  -1160407312);
        }
        
        Add(key:  -1164149280, value:  -1160407216);
        Add(key:  -1164262512, value:  -1160407312);
        LimitedTimeBundlesManager.BundleTitles = val_2;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        LimitedTimeBundlesManager.LimitedTimeframes = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        LimitedTimeBundlesManager.BundleTimeframes = null;
    }

}
