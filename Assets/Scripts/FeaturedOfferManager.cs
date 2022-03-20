using UnityEngine;
public class FeaturedOfferManager : MonoSingleton<FeaturedOfferManager>
{
    // Fields
    private const string pref_last_offer_purchase = "fo_l_p";
    public static int MinimumPurchases;
    public static int PostPurchaseDelayDays;
    public static int PurchasePercent;
    public static int BonusCoinsPercent;
    private FeaturedOfferStoreItem _prefab_featured_store_item;
    private FeaturedOfferStoreItem storeItemInstance;
    private string debugLog;
    private System.DateTime _LastOfferPurchaseTime;
    
    // Properties
    public static int PostPurchaseDelayHours { get; }
    public static float PurchasePercentage { get; }
    public static decimal BonusCoinPercentage { get; }
    private FeaturedOfferStoreItem Prefab_featured_store_item { get; }
    public System.DateTime LastOfferPurchaseTime { get; set; }
    
    // Methods
    public static int get_PostPurchaseDelayHours()
    {
        null = null;
        int val_1 = FeaturedOfferManager.PostPurchaseDelayDays;
        val_1 = val_1 + (val_1 << 1);
        val_1 = val_1 << 3;
        return (int)val_1;
    }
    public static float get_PurchasePercentage()
    {
        null = null;
        float val_1 = (float)FeaturedOfferManager.PurchasePercent;
        val_1 = val_1 / 100f;
        return (float)val_1;
    }
    public static decimal get_BonusCoinPercentage()
    {
        int val_3;
        null = null;
        decimal val_1 = System.Decimal.op_Implicit(value:  -1262105808);
        decimal val_2 = new System.Decimal(value:  100);
        decimal val_4 = System.Decimal.op_Division(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_3, hi = val_2.flags, lo = val_2.hi, mid = val_2.lo});
        return new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid};
    }
    private FeaturedOfferStoreItem get_Prefab_featured_store_item()
    {
        if(this._prefab_featured_store_item != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1262000640);
        this._prefab_featured_store_item = "Store";
    }
    public System.DateTime get_LastOfferPurchaseTime()
    {
        var val_6;
        var val_7;
        ulong val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = mem[R1 + 24];
        val_8 = R1 + 24;
        val_9 = null;
        val_9 = null;
        val_10 = R1 + 24 + 4;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_8}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                val_10 = 0;
            val_8 = "fo_l_p";
            if((UnityEngine.PlayerPrefs.HasKey(key:  -1261876272)) != false)
        {
                val_11 = null;
            val_11 = null;
            string val_3 = System.DateTime.MinValue.ToString();
            string val_4 = UnityEngine.PlayerPrefs.GetString(key:  -1261876272, defaultValue:  -1261864232);
            System.DateTime val_5 = SLCDateTime.Parse(dateTime:  -1261864240);
            val_10 = val_6;
            mem2[0] = val_7;
        }
        
        }
        
        this = R1 + 24;
        return new System.DateTime() {dateData = R1 + 24};
    }
    public void set_LastOfferPurchaseTime(System.DateTime value)
    {
        this._LastOfferPurchaseTime = R2;
        mem[1152921511935041404] = R3;
        string val_1 = this._LastOfferPurchaseTime.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1261876272, value:  -1261740168);
    }
    public override void InitMonoSingleton()
    {
        var val_9;
        System.Delegate val_10;
        var val_11;
        System.Action val_12;
        System.Delegate val_13;
        var val_14;
        string val_15;
        System.Delegate val_16;
        this.InitMonoSingleton();
        val_9 = null;
        val_9 = null;
        System.Action val_1 = new System.Action(object:  -1261622976, method:  new IntPtr(3033316128));
        val_10 = GameStoreUI.OnCreatePackItems;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_10, b:  7454720);
        val_11 = null;
        val_12 = null;
        if(val_10 == 0)
        {
            goto label_3;
        }
        
        if(null == val_12)
        {
            goto label_4;
        }
        
        val_12 = null;
        val_11 = 1152921504929316956;
        label_3:
        val_10 = 0;
        label_4:
        GameStoreUI.OnCreatePackItems = val_10;
        val_12 = new System.Action(object:  -1261622976, method:  new IntPtr(3033317152));
        val_13 = GameStoreUI.OnRefreshDisplay;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_13, b:  7454720);
        if(val_13 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_13 = 0;
        label_6:
        GameStoreUI.OnRefreshDisplay = val_13;
        val_14 = null;
        val_14 = null;
        PostProcessPurchaseDelegate val_5 = new PostProcessPurchaseDelegate(object:  -1261622976, method:  new IntPtr(3033318176));
        System.Delegate val_6 = System.Delegate.Combine(a:  PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS, b:  291586048);
        val_15 = 0;
        if(PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS != null)
        {
                if(null != null)
        {
                val_15 = 0;
        }
        else
        {
                val_15 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        }
        
        }
        
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_15;
        System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1261622976, method:  new IntPtr(3033319200));
        val_16 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_8 = System.Delegate.Combine(a:  val_16, b:  7401472);
        if(val_16 != 0)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        val_16 = 0;
        label_13:
        PurchasesHandler.OnPurchaseCompleted = val_16;
        this.LogDebug(text:  -1261647072, color:  -1835139200);
    }
    public string GetDebugLog()
    {
    
    }
    private void OnRefreshDisplay()
    {
        PurchaseModel val_1 = this.DetermineFeaturedOfferPack();
        if(this == 0)
        {
                return;
        }
        
        if(this.storeItemInstance == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = Localization.Localize(key:  -1261409664, defaultValue:  -1261409552, useSingularKey:  false);
            GameStoreCategory val_5 = GetOrCreateCategory(categoryTitle:  -1261409664, showTitle:  true, siblingIndex:  0);
            FeaturedOfferStoreItem val_6 = this.Prefab_featured_store_item;
            UnityEngine.Transform val_7 = XfmPackageContents;
            object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  -1261372144, parent:  -1261410688);
            this.storeItemInstance = this;
            UnityEngine.Transform val_9 = this.transform;
            this.SetSiblingIndex(index:  GetFirstAvailableSiblingIndex());
        }
        
        UnityEngine.GameObject val_11 = this.storeItemInstance.gameObject;
        this.storeItemInstance.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_13 = GetStoreItemIndex(packId:  this._prefab_featured_store_item);
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_15 = CoinPackItemsCount;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    private void OnCreatePackItems()
    {
        PurchaseModel val_1 = this.DetermineFeaturedOfferPack();
        if(this == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_3 = Localization.Localize(key:  -1261409664, defaultValue:  -1261409552, useSingularKey:  false);
        GameStoreCategory val_4 = GetOrCreateCategory(categoryTitle:  -1261409664, showTitle:  true, siblingIndex:  0);
        FeaturedOfferStoreItem val_5 = this.Prefab_featured_store_item;
        UnityEngine.Transform val_6 = XfmPackageContents;
        object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  -1261239664, parent:  -1261410688);
        this.storeItemInstance = this;
        UnityEngine.Transform val_8 = this.transform;
        this.SetSiblingIndex(index:  GetFirstAvailableSiblingIndex());
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    private PurchaseModel DetermineFeaturedOfferPack()
    {
        int val_5;
        float val_6;
        ulong val_7;
        float val_8;
        float val_10;
        int val_11;
        int val_40;
        int val_43;
        int val_44;
        int val_44;
        var val_45;
        var val_46;
        var val_47;
        System.Predicate<PurchaseModel> val_49;
        var val_50;
        var val_51;
        var val_52;
        val_44 = 1152921504892043264;
        Player val_1 = App.Player;
        val_45 = 1152921504928997376;
        val_46 = 0;
        if(188 < FeaturedOfferManager.MinimumPurchases)
        {
                return;
        }
        
        val_46 = 0;
        Player val_2 = App.Player;
        if(0 <= 0)
        {
                return;
        }
        
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        System.DateTime val_4 = LastOfferPurchaseTime;
        System.TimeSpan val_9 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511935652320}, d2:  new System.DateTime() {dateData = val_7});
        double val_12 = val_10.TotalHours;
        int val_13 = FeaturedOfferManager.PostPurchaseDelayHours;
        val_46 = 0;
        Player val_14 = App.Player;
        Player val_15 = App.Player;
        this.LogDebug(text:  -1261147472, color:  -1261147568);
        float val_17 = (System.Math.Abs((5.605194E-45f) - (4.315999E-43f))) / (4.315999E-43f);
        val_7 = val_17;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        val_6 = 5.605194E-45f;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        val_10 = 4.315999E-43f;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        val_8 = 4.315999E-43f;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_18 = System.String.Format(format:  -1261147328, args:  472754880);
        this.LogDebug(text:  -1261147328, color:  -1261147056);
        WordPets.WPTDataParser val_19 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<PurchaseModel> val_20 = RetrievePurchasePacks();
        val_47 = null;
        val_47 = null;
        val_49 = FeaturedOfferManager.<>c.<>9__24_0;
        if(val_49 == 0)
        {
                val_49 = null;
            val_49 = new System.Predicate<ZooTile>(object:  FeaturedOfferManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3033821360));
            FeaturedOfferManager.<>c.<>9__24_0 = val_49;
        }
        
        System.Collections.Generic.List<T> val_22 = FindAll(match:  8040448);
        float val_23 = FeaturedOfferManager.PurchasePercentage;
        val_7 = val_17;
        float val_24 = FeaturedOfferManager.PurchasePercentage;
        val_6 = null;
        string val_25 = System.String.Format(format:  -1261142864, arg0:  15282176, arg1:  15282176);
        this.LogDebug(text:  -1261142864, color:  -1261142672);
        val_10 = 4.315999E-43f;
        string val_26 = System.String.Format(format:  -1261142576, arg0:  15282176);
        this.LogDebug(text:  -1261142576, color:  -1261142672);
        val_50 = 4;
        var val_28 =  - 4;
        val_51 = 1152921504622129152;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_46 = mem[(public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_8 + ((public static WGStoreController MonoSingletonSelfGenerating<WGStoreController + 16];
        val_46 = (public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_8 + ((public static WGStoreController MonoSingletonSelfGenerating<WGStoreController + 16;
        if(val_46 == 0)
        {
                val_46 = 0;
            0.AddTrackingInfo(infoKey:  -1261142304, infoValue:  -1261142400);
        }
        else
        {
                AddTrackingInfo(infoKey:  -1261142304, infoValue:  -1261142400);
        }
        
        val_7 = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_8 + 16 + 92;
        val_52 = 0;
        string val_37 = System.String.Format(format:  -1261141264, arg0:  15282176);
        this.LogDebug(text:  -1261141264, color:  -1261141360);
        if( == 0)
        {
                val_46 = 0;
            val_52 = 1;
        }
        
        decimal val_38 = val_7.Credits;
        decimal val_39 = FeaturedOfferManager.BonusCoinPercentage;
        val_45 = 0;
        decimal val_42 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -1261129248, hi = val_7, mid = val_10}, d2:  new System.Decimal() {flags = val_11, lo = val_5, mid = val_40});
        val_44 = val_44;
        val_46.AddReward(rewardType:  2129282688, amount:  new System.Decimal() {hi = val_11, lo = val_43, mid = val_44});
        val_46.AddInstruction(instruction:  1);
    }
    private void OnProcessPurchase(ref PurchaseModel purchase)
    {
    
    }
    private void OnPurchaseCompleted(PurchaseModel purchased)
    {
        if((purchased.ContainsInstruction(instruction:  1)) == false)
        {
                return;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        this.LastOfferPurchaseTime = new System.DateTime();
        bool val_5 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private PurchaseModel GetPackageNearestToPrice(float priceToCompare, System.Collections.Generic.List<PurchaseModel> availablePacks)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = 0;
        goto label_1;
        label_10:
        if(true <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = R2 + 8;
        val_4 = val_4 + 0;
        val_4 = mem[(R2 + 8 + 0) + 16];
        val_4 = (R2 + 8 + 0) + 16;
        val_5 = mem[R2 + 12];
        val_5 = R2 + 12;
        float val_5 = System.Math.Abs(availablePacks - ((R2 + 8 + 0) + 16 + 92));
        if(val_5 <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = R2 + 8;
        val_6 = val_6 + 0;
        val_4 = mem[(R2 + 8 + 0) + 16];
        val_4 = (R2 + 8 + 0) + 16;
        val_3 = 1;
        System.Collections.Generic.List<PurchaseModel> val_2 = availablePacks - ((R2 + 8 + 0) + 16 + 92);
        label_1:
        val_5 = mem[R2 + 12];
        val_5 = R2 + 12;
        if(val_3 < val_5)
        {
            goto label_10;
        }
        
        if(val_5 <= (val_3 - 1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = R2 + 8;
        val_7 = val_7 + 4;
    }
    private void LogDebug(string text, string color = "#FFFFFF")
    {
        float val_1 = UnityEngine.Time.time;
        string val_2 = 0.ToString(format:  -1773242864);
        string val_3 = System.String.Format(format:  -1773242768, arg0:  -1260644468, arg1:  color, arg2:  text);
        string val_4 = this.debugLog + -1773242768(-1773242768);
        this.debugLog = this.debugLog;
    }
    public FeaturedOfferManager()
    {
        var val_1;
        this.debugLog = "<b>~Featured Offer Log Begin~</b>\n";
        val_1 = null;
        val_1 = null;
        this._LastOfferPurchaseTime = System.DateTime.MinValue;
    }
    private static FeaturedOfferManager()
    {
        FeaturedOfferManager.MinimumPurchases = 2;
        FeaturedOfferManager.PostPurchaseDelayDays = 3;
        FeaturedOfferManager.PurchasePercent = 20;
        FeaturedOfferManager.BonusCoinsPercent = 10;
    }

}
