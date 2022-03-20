using UnityEngine;
public class TRVProgressiveIAPHandler : WGEventHandler
{
    // Fields
    private static TRVProgressiveIAPHandler _Instance;
    public const string EVENT_ID = "ProgressiveIapSale";
    public const string EVENT_TRACKING_ID = "TRVProgressiveIAP";
    public const string BONUS_MULTIPLIER = "BonusMulti";
    private string packagePrefix;
    private System.Collections.Generic.Dictionary<string, object> myEventData;
    public static TrackerPurchasePoints purchasePoint;
    protected int[] levelRq;
    protected int playerProgress;
    private bool purchased;
    private PurchaseModel currentModel;
    private int lastCheckedPurcahseModel;
    public System.Action<bool> OnPurchaseAttemptResult;
    
    // Properties
    public static TRVProgressiveIAPHandler Instance { get; }
    public GameEventV2 getEvent { get; }
    public int[] getLevelReq { get; }
    public int getPlayerProgress { get; }
    protected static int LastProgressTimestampPref { get; set; }
    public override bool IsEventHidden { get; }
    
    // Methods
    public static TRVProgressiveIAPHandler get_Instance()
    {
    
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    public int[] get_getLevelReq()
    {
    
    }
    public int get_getPlayerProgress()
    {
        return (int)this.playerProgress;
    }
    protected static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -593617824, defaultValue:  0);
    }
    protected static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -593617824, value:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921512603420040] = eventV2;
        bool val_1 = this.ParseEventData(eventData:  eventV2.eventData);
        TRVProgressiveIAPHandler.BONUS_MULTIPLIER = this;
        if((this.CheckNeedsNewData(eventData:  eventV2.eventData)) != false)
        {
                this.GenerateNewData();
            return;
        }
        
        this.LoadPersistantData();
    }
    private bool CheckNeedsNewData(GameEventV2 eventData)
    {
        if((CPlayerPrefs.HasKey(key:  -1648524352)) == false)
        {
                return true;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -1648524352);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1648524352);
        if("ProgressiveIapSale" == 0)
        {
                return true;
        }
        
        if(null != null)
        {
                "ProgressiveIapSale" = 0;
        }
        
        if(null != null)
        {
                return true;
        }
        
        if("ProgressiveIapSale".Count == 0)
        {
                return true;
        }
        
        if(("ProgressiveIapSale".ContainsKey(key:  1624646480)) == false)
        {
                return true;
        }
        
        string val_6 = "ProgressiveIapSale".Item[1624646480];
        string val_7 = ToString();
        return System.String.op_Inequality(a:  null, b:  -593237200);
    }
    private void GenerateNewData()
    {
        var val_3;
        var val_4;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_3 = null;
        if(null == 0)
        {
                val_3 = null;
        }
        
        Add(key:  1624646480, value:  13152256);
        val_4 = val_3;
        if(val_3 == 0)
        {
                val_4 = null;
        }
        
        Add(key:  -593145152, value:  13152256);
        Add(key:  -1700598896, value:  8945664);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        CPlayerPrefs.SetString(key:  -1648524352, val:  78753792);
        CPlayerPrefs.Save();
        this.LoadPersistantData();
    }
    protected virtual void GenerateExtraNewData(ref System.Collections.Generic.Dictionary<string, object> eventDataToSave)
    {
    
    }
    private void LoadPersistantData()
    {
        TRVProgressiveIAPHandler val_11;
        TRVProgressiveIAPHandler val_12;
        bool val_13;
        val_11 = this;
        val_12 = "ProgressiveIapSale";
        string val_1 = CPlayerPrefs.GetString(key:  -1648524352);
        object val_2 = MiniJSON.Json.Deserialize(json:  -1648524352);
        if(val_12 != 0)
        {
                if(null == null)
        {
            goto label_5;
        }
        
        }
        
        val_13 = val_11;
        this.myEventData = 0;
        label_15:
        if((0.ContainsKey(key:  -593145152)) != false)
        {
                string val_4 = this.myEventData.Item[-593145152];
            bool val_6 = System.Int32.TryParse(s:  null, result: out  this.playerProgress);
        }
        
        if((this.myEventData.ContainsKey(key:  -1700598896)) != false)
        {
                string val_8 = this.myEventData.Item[-1700598896];
            val_13 = this.purchased;
            bool val_10 = System.Boolean.TryParse(value:  null, result: out  val_13);
        }
        
        val_12 = val_11;
        goto typeof(TRVProgressiveIAPHandler).__il2cppRuntimeField_414;
        label_5:
        mem2[0] = val_12;
        goto label_15;
    }
    protected virtual void LoadExtraPersistentData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
    
    }
    protected void SaveData()
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -593145152, newValue:  13152256);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -1700598896, newValue:  8945664);
        string val_1 = MiniJSON.Json.Serialize(obj:  this.myEventData);
        CPlayerPrefs.SetString(key:  -1648524352, val:  this.myEventData);
        CPlayerPrefs.Save();
    }
    protected virtual void SaveExtraData(ref System.Collections.Generic.Dictionary<string, object> myEventData)
    {
    
    }
    private bool ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        var val_8;
        var val_9;
        var val_10;
        System.Int32[] val_11;
        val_8 = eventData;
        val_9 = 0;
        if(val_8 == 0)
        {
                return (bool)val_9;
        }
        
        if(val_8.Count == 0)
        {
                return (bool)val_9;
        }
        
        val_10 = 1152921510392296080;
        if((val_8.ContainsKey(key:  -1554533760)) == false)
        {
                return (bool)val_9;
        }
        
        val_11 = 1152921510385703632;
        object val_3 = val_8.Item[-1554533760];
        val_8 = 0;
        val_10 = "req_lvls";
        if((val_8.ContainsKey(key:  -592428320)) != false)
        {
                string val_5 = val_8.Item[-592428320];
            if(val_8 == 0)
        {
                return (bool)val_9;
        }
        
            val_8 = val_8;
            val_9 = 0;
            if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_8 = val_9;
        }
        
            if(0 == 0)
        {
                return (bool)val_9;
        }
        
            this.levelRq = null;
            if(0 >= 1)
        {
                val_10 = 4;
            do
        {
            if(0 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_9 = 0;
            if((System.Int32.TryParse(s:  2621443, result: out  int val_6 = -592379400)) == false)
        {
                return (bool)val_9;
        }
        
            val_11 = this.levelRq;
            val_11[0] = -2147483648;
            val_10 = val_10 + 1;
        }
        while((val_10 - 3) < 0);
        
        }
        
        }
        
        val_9 = 1;
        return (bool)val_9;
    }
    public override void OnPurchaseFailure(PurchaseModel purchase)
    {
        if((purchase.id.Contains(value:  -592230208)) == false)
        {
                return;
        }
        
        this.OnPurchaseFail();
    }
    public override void OnPurchaseCompleted(PurchaseModel purchase)
    {
        this.SaveData();
        if((purchase.id.Contains(value:  -592230208)) == false)
        {
                return;
        }
        
        this.OnPurchaseSuccess();
    }
    public override bool EventCompleted()
    {
        return (bool)this.purchased;
    }
    public override bool get_IsEventHidden()
    {
        PurchaseModel val_1 = this.GetCurrentPurchaseModel(tierOverride:  0);
        if(this == 0)
        {
                this = true;
        }
        
        if(this != 0)
        {
                this = this.purchased;
        }
        
        return this;
    }
    public override void OnCategoryComplete()
    {
        int val_2 = this.playerProgress;
        val_2 = val_2 + 1;
        this.playerProgress = val_2;
        this.SaveData();
        PurchaseModel val_1 = this.GetCurrentPurchaseModel(tierOverride:  0);
    }
    public override void OnLevelCompleteRewardAnimFinished()
    {
        if(this != 0)
        {
                return;
        }
        
        if(this.playerProgress > (System.Linq.Enumerable.Sum(source:  this.levelRq)))
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.countedAnswers) < (public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 12))
        {
                return;
        }
        
        if((R4 + 28) == 0)
        {
                return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        0.Init();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -591458656, defaultValue:  -591458768, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        twelvegigs.storage.JsonDictionary val_1 = this.GetCurrentJsonDictionary(tier:  0);
        float val_2 = this.getFloat(key:  -591346544, defaultValue:  null);
        float val_9 = 100f;
        val_9 = 3703645056 * val_9;
        int val_3 = UnityEngine.Mathf.FloorToInt(f:  val_9);
        string val_4 = Localization.Localize(key:  -591458656, defaultValue:  -591458768, useSingularKey:  false);
        string val_5 = Localization.Localize(key:  -591346448, defaultValue:  -591346336, useSingularKey:  false);
        string val_6 = System.String.Format(format:  -591346448, arg0:  13152256);
        string val_7 = System.Environment.NewLine;
        string val_8 = System.String.Format(format:  -1183154368, arg0:  -591458656, arg1:  0, arg2:  -591346448);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void UpdateProgress()
    {
        TRVProgressiveIAPHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
    }
    public override string GetMainMenuButtonText()
    {
        goto typeof(TRVProgressiveIAPHandler).__il2cppRuntimeField_1C4;
    }
    public override string EventContentItemButtonText()
    {
        return Localization.Localize(key:  -590663904, defaultValue:  -590664000, useSingularKey:  false);
    }
    public bool SupportsGems()
    {
        twelvegigs.storage.JsonDictionary val_1 = this.GetCurrentJsonDictionary(tier:  1);
        if(this != 0)
        {
                return this.Contains(key:  -1930648496);
        }
        
        return this.Contains(key:  -1930648496);
    }
    public twelvegigs.storage.JsonDictionary GetCurrentJsonDictionary(int tier = -1)
    {
        int val_4 = tier;
        if(val_4 <= 1)
        {
                val_4 = this.GetCurrentTier(calculatedProgress:  this.playerProgress);
        }
        
        if(val_4 == 0)
        {
                return;
        }
        
        string val_2 = System.String.Format(format:  -1671354896, arg0:  this.packagePrefix, arg1:  13152256);
        twelvegigs.storage.JsonDictionary val_3 = PackagesManager.GetPackageById(packageId:  -1671354896);
    }
    public PurchaseModel GetCurrentPurchaseModel(int tierOverride = -1)
    {
        PurchaseModel val_3;
        if(this.lastCheckedPurcahseModel == this.playerProgress)
        {
                val_3 = this.currentModel;
            return;
        }
        
        twelvegigs.storage.JsonDictionary val_1 = this.GetCurrentJsonDictionary(tier:  0);
        if(this != 0)
        {
                PurchaseModel val_2 = null;
            val_3 = val_2;
            val_2 = new PurchaseModel(json:  -590291504);
            this.currentModel = val_3;
            this.lastCheckedPurcahseModel = this.playerProgress;
            return;
        }
        
        val_3 = 0;
    }
    public int GetCurrentTierProgress(int calculatedProgress)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        val_2 = calculatedProgress;
        if((this.GetCurrentTier(calculatedProgress:  calculatedProgress)) == 0)
        {
                return (int)val_2;
        }
        
        val_3 = 0;
        val_4 = 4;
        val_5 = val_2;
        goto label_1;
        label_8:
        val_3 = this.levelRq[0] + val_3;
        if(val_3 <= val_2)
        {
                int val_4 = this.levelRq[0];
            val_5 = val_5 - val_4;
        }
        
        val_4 = 5;
        label_1:
        if((val_4 - 4) < val_4)
        {
            goto label_8;
        }
        
        val_2 = val_5;
        return (int)val_2;
    }
    public int GetCurrentTierRequirement(int calculatedProgress)
    {
        return (int)this.levelRq[System.Math.Min(val1:  this.GetCurrentTier(calculatedProgress:  calculatedProgress), val2:  13524991)];
    }
    public int GetCurrentTier(int calculatedProgress)
    {
        var val_1;
        var val_2;
        val_1 = 0;
        var val_2 = 0;
        val_2 = 0;
        goto label_0;
        label_4:
        val_1 = 1;
        int val_1 = this.levelRq[val_1];
        val_2 = val_1 + val_2;
        if(val_2 <= calculatedProgress)
        {
                val_2 = val_1;
        }
        
        label_0:
        if(val_1 < val_1)
        {
            goto label_4;
        }
        
        return (int)val_2;
    }
    public void TryPurchase()
    {
        var val_3;
        var val_3 = 23669885;
        val_3 = 11956176 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        PurchaseProxy.currentPurchasePoint = TRVProgressiveIAPHandler.purchasePoint;
        PurchaseModel val_1 = this.GetCurrentPurchaseModel(tierOverride:  PurchaseProxy.__il2cppRuntimeField_cctor_finished);
        bool val_2 = PurchaseProxy.Purchase(purchase:  -589323312);
    }
    public void OnPurchaseSuccess()
    {
        this.OnPurchaseAttemptResult.Invoke(obj:  true);
        this.purchased = true;
        this.SaveData();
    }
    private void TrackPurchaseMade()
    {
    
    }
    public void OnPurchaseFail()
    {
        this.OnPurchaseAttemptResult.Invoke(obj:  false);
    }
    public virtual void ShowSalePopup()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    protected virtual int GetCurrentTierIAPIndex(int tier)
    {
        return (int)tier;
    }
    public TRVProgressiveIAPHandler()
    {
        this.lastCheckedPurcahseModel = 0;
        this.packagePrefix = "progressive_sale_";
    }

}
