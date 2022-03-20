using UnityEngine;
public class PiggyBankRaidEventHandler : WGEventHandler
{
    // Fields
    public const string PIGGY_BANK_RAID_EVENT_ID = "PiggyBankRaid";
    public const string EVENT_TRACKING_ID = "Piggy Bank Raid";
    public static bool isEventPopupQueued;
    public System.Action<bool, System.Decimal> OnPurchaseAttempt;
    public TrackerPurchasePoints currPurchasePoint;
    private PiggyBankRaidEcon econ;
    private PiggyBankRaidProgress progressData;
    private UnityEngine.GameObject currentTileObj;
    private System.Collections.Generic.List<PiggyBankRaidPlayerProfile> cachedOpponentPool;
    private PiggyBankRaidPlayerProfile currentOpponent;
    private System.Nullable<System.DateTime> lastProcessedNewsTimestamp;
    private DG.Tweening.Tweener collectTween;
    private static PiggyBankRaidEventHandler <Instance>k__BackingField;
    public System.Collections.Generic.Dictionary<string, object> debugLastPayLoad;
    private System.Collections.Generic.List<string> debugCoinChangeLog;
    private bool <QA_LevelBufferHack>k__BackingField;
    private bool <QA_NextPiggyCreditFillExactlyMax>k__BackingField;
    
    // Properties
    public PiggyBankRaidEcon Econ { get; }
    public PiggyBankRaidProgress ProgressData { get; }
    public PiggyBankRaidPlayerProfile CurrentOpponent { get; }
    public static PiggyBankRaidEventHandler Instance { get; set; }
    public decimal PiggyBankCoins { get; set; }
    public int PiggyBankLevel { get; set; }
    private UnityEngine.GameObject TilePrefab { get; }
    public bool IsTileCurrentlyInPlay { get; }
    public string QA_RaidPoolIds { get; }
    public bool QA_LevelBufferHack { get; set; }
    public bool QA_NextPiggyCreditFillExactlyMax { get; set; }
    
    // Methods
    public PiggyBankRaidEcon get_Econ()
    {
    
    }
    public PiggyBankRaidProgress get_ProgressData()
    {
    
    }
    public PiggyBankRaidPlayerProfile get_CurrentOpponent()
    {
    
    }
    public static PiggyBankRaidEventHandler get_Instance()
    {
        null = null;
    }
    private static void set_Instance(PiggyBankRaidEventHandler value)
    {
        null = null;
        PiggyBankRaidEventHandler.<Instance>k__BackingField = value;
    }
    public decimal get_PiggyBankCoins()
    {
        return new System.Decimal() {flags = (R1 + 28 + 20) + 24};
    }
    public void set_PiggyBankCoins(decimal value)
    {
        this.progressData.player.coins = value;
        mem2[0] = value.hi;
        mem2[0] = value.lo;
        mem2[0] = value.mid;
        if(this.progressData == 0)
        {
            
        }
    
    }
    public int get_PiggyBankLevel()
    {
        return UnityEngine.Mathf.Clamp(value:  this.progressData.player.bankLevel, min:  1, max:  5);
    }
    protected void set_PiggyBankLevel(int value)
    {
        this.progressData.player.bankLevel = value;
    }
    private UnityEngine.GameObject get_TilePrefab()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1535358816, prefabName:  -1115075296);
    }
    public bool get_IsTileCurrentlyInPlay()
    {
        var val_4;
        int val_5;
        PiggyBankRaidProgress val_7;
        val_4 = 0;
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return true;
        }
        
        val_5 = this.progressData.currentAssociatedLevel;
        val_4 = 0;
        if(val_5 != PlayingLevel.GetCurrentPlayerLevelNumber())
        {
                return true;
        }
        
        val_5 = this.progressData;
        if(this.progressData.currentLineWord < 0)
        {
                return true;
        }
        
        val_5 = 0;
        if(this.progressData.currentLineWord >= 0)
        {
                return true;
        }
        
        val_5 = this.progressData;
        if(this.progressData.currentCell < 0)
        {
                return true;
        }
        
        val_5 = this.progressData;
        val_7 = val_5;
        if(val_5 != 0)
        {
            goto label_18;
        }
        
        val_7 = this.progressData;
        if(val_7 == 0)
        {
            goto label_19;
        }
        
        label_18:
        if(0 <= this.progressData.currentLineWord)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = 0;
        val_4 = val_4 + (this.progressData.currentLineWord << 2);
        if(this.progressData.currentCell < ((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 12))
        {
                val_4 = 1;
        }
        
        return true;
        label_19:
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_1;
        mem[1152921512082007640] = eventV2;
        var val_1 = 25858011;
        val_1 = 9775168 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        PiggyBankRaidEventHandler.<Instance>k__BackingField = this;
        this.SetupEvent();
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        if((System.String.op_Inequality(a:  eventV2.type, b:  -1298907888)) != false)
        {
                return;
        }
        
        this.SetupEvent();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1114553344, defaultValue:  -1114553456, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1114553344, defaultValue:  -1114553456, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        return Localization.Localize(key:  -1114329152, defaultValue:  -1114329232, useSingularKey:  false);
    }
    public override bool EventCompleted()
    {
        if(this.progressData != 0)
        {
                return (bool)this.progressData.isMaxPiggyPurchased;
        }
        
        return (bool)this.progressData.isMaxPiggyPurchased;
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        int val_4;
        int val_5;
        int val_7;
        int val_8;
        decimal val_1 = PiggyBankCoins;
        int val_2 = this.PiggyBankLevel;
        decimal val_3 = Item[this.econ.bankMaxCoins];
        decimal val_9 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -1114062440}, d2:  new System.Decimal() {flags = val_5, hi = val_4, lo = val_8, mid = val_7});
        float val_10 = System.Decimal.op_Explicit(value:  new System.Decimal());
        decimal val_11 = PiggyBankCoins;
        GameEcon val_12 = App.getGameEcon;
        string val_13 = ToString(format:  null);
        int val_14 = this.PiggyBankLevel;
        decimal val_15 = Item[this.econ.bankMaxCoins];
        string val_16 = System.String.Format(format:  1629069648, arg0:  -1114062392, arg1:  10170368);
        TheLibraryMainScreen val_17 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override void OnProcessPurchase(ref PurchaseModel purchase)
    {
        this.OnProcessPurchase(purchase: ref  PurchaseModel val_1 = -1113881840);
    }
    public override void OnPurchaseFailure(PurchaseModel purchase)
    {
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        if((purchase.id.Contains(value:  -1113813632)) == true)
        {
                this = this.OnPurchaseAttempt;
        }
        
        if(this == 0)
        {
                return;
        }
        
        decimal val_2 = Credits;
        this.Invoke(arg1:  false, arg2:  new System.Decimal() {flags = val_3, hi = val_4, lo = val_5, mid = val_6});
    }
    public override void OnPurchaseCompleted(PurchaseModel purchase)
    {
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        string val_7;
        PiggyBankRaidPlayerProfile val_8;
        int val_9;
        val_7 = purchase.id;
        if((val_7.Contains(value:  -1113813632)) == false)
        {
                return;
        }
        
        val_8 = this.progressData.player;
        if(val_8 != 0)
        {
                val_9 = this.progressData.player.bankLevel;
        }
        else
        {
                val_8 = 20;
            val_9 = 1;
        }
        
        mem[20] = 2;
        if(this.progressData.player.bankLevel >= 6)
        {
                this.progressData.isMaxPiggyPurchased = true;
        }
        
        val_7 = this.progressData;
        this.UpdateProgressToServer();
        if(this.OnPurchaseAttempt == 0)
        {
                return;
        }
        
        decimal val_2 = Credits;
        val_9 = public System.Void System.Action<System.Boolean, System.Decimal>::Invoke(System.Boolean arg1, System.Decimal arg2);
        this.OnPurchaseAttempt.Invoke(arg1:  true, arg2:  new System.Decimal() {flags = val_3, hi = val_4, lo = val_5, mid = val_6});
    }
    public override void OnEventEnded()
    {
        this.progressData = new PiggyBankRaidProgress();
    }
    public override void OnMenuLoaded()
    {
        null = null;
        if(PiggyBankRaidEventHandler.isEventPopupQueued == false)
        {
                return;
        }
        
        PiggyBankRaidEventHandler.HandleDeeplinkShowRaid();
    }
    public override void OnGameSceneBegan()
    {
        null = null;
        if(PiggyBankRaidEventHandler.isEventPopupQueued == false)
        {
                return;
        }
        
        PiggyBankRaidEventHandler.HandleDeeplinkShowRaid();
    }
    public static void HandleDeeplinkShowRaid()
    {
        var val_5;
        bool val_7;
        var val_5 = 25854756;
        val_5 = 9778424 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField) == 0)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2119322896 != 0)
        {
            goto label_11;
        }
        
        val_5 = null;
        label_6:
        val_7 = 1;
        goto label_12;
        label_11:
        GameBehavior val_3 = App.getBehavior;
        val_5 = null;
        val_7 = false;
        label_12:
        val_5 = null;
        PiggyBankRaidEventHandler.isEventPopupQueued = val_7;
    }
    public override void OnWordRegionLoaded()
    {
        if(this.IsEventExpired() == true)
        {
                return;
        }
        
        if(this.IsCurrentEventInCycle() == false)
        {
                return;
        }
        
        if(this.progressData.isMaxPiggyPurchased == true)
        {
                return;
        }
        
        GameplayMode val_3 = PlayingLevel.CurrentGameplayMode;
        if(0 != 1)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(CategoryPacksManager.IsPlaying != false)
        {
                return;
        }
        
        WordRegion val_7 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  R4, method:  new IntPtr(3181945584));
        0.addOnWordFoundAction(callback:  7401472);
        R4.LoadGameData();
    }
    public void DiscardOverflowAmount()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        int val_11;
        int val_13;
        decimal val_1 = PiggyBankCoins;
        int val_2 = this.PiggyBankLevel;
        decimal val_3 = Item[this.econ.bankMaxCoins];
        val_13 = val_6;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_13, hi = val_5, lo = val_4, mid = val_7})) == false)
        {
                return;
        }
        
        val_13 = this.PiggyBankLevel;
        decimal val_10 = Item[this.econ.bankMaxCoins];
        this.PiggyBankCoins = new System.Decimal() {mid = val_11};
        this.UpdateProgressToServer();
    }
    public override void OnPreprocessPlayerTurn(bool hintUsage, string wordEntered, LineWord lineWord, Cell cell)
    {
        var val_5;
        PiggyBankRaidProgress val_6;
        val_5 = this;
        if(this.IsTileCurrentlyInPlay == false)
        {
                return;
        }
        
        WordRegion val_2 = WordRegion.instance;
        val_6 = this.progressData;
        if(this.progressData.currentLineWord < 0)
        {
                return;
        }
        
        val_6 = this.progressData.currentLineWord;
        if(val_6 >= 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  wordEntered)) == true)
        {
                return;
        }
        
        val_6 = this.progressData.currentLineWord;
        if(0 <= val_6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0;
        val_5 = val_5 + (val_6 << 2);
        val_5 = mem[(0 + (this.progressData.currentLineWord) << 2) + 16 + 12];
        val_5 = (0 + (this.progressData.currentLineWord) << 2) + 16 + 12;
        bool val_4 = val_5.Equals(value:  wordEntered);
        if(val_4 == true)
        {
                val_4 = 1;
            mem[20] = val_4;
        }
    
    }
    private void OnWordRegionWordFound(string wordCompleted)
    {
        var val_5;
        if(this.IsTileCurrentlyInPlay == false)
        {
                return;
        }
        
        WordRegion val_2 = WordRegion.instance;
        val_5 = 0;
        if(this.progressData.currentLineWord < 0)
        {
                return;
        }
        
        if(this.progressData.currentLineWord >= 0)
        {
                return;
        }
        
        if(0 <= this.progressData.currentLineWord)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0;
        val_5 = val_5 + (this.progressData.currentLineWord << 2);
        if(((0 + (this.progressData.currentLineWord) << 2) + 16 + 12.Equals(value:  wordCompleted)) == true)
        {
            goto label_15;
        }
        
        if(this.progressData.alternateLineWord == 1)
        {
            goto label_23;
        }
        
        if(0 <= this.progressData.alternateLineWord)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = 0;
        val_6 = val_6 + (this.progressData.alternateLineWord << 2);
        val_5 = mem[(0 + (this.progressData.alternateLineWord) << 2) + 16 + 12];
        val_5 = (0 + (this.progressData.alternateLineWord) << 2) + 16 + 12;
        if((val_5.Equals(value:  wordCompleted)) == false)
        {
            goto label_23;
        }
        
        label_15:
        this.CollectTileObject();
        return;
        label_23:
        this.ShiftTileObject();
    }
    public override void OnSubmitWordWithHints(string word)
    {
        var val_5;
        if(this.IsTileCurrentlyInPlay == false)
        {
                return;
        }
        
        WordRegion val_2 = WordRegion.instance;
        val_5 = 0;
        if(0 <= this.progressData.currentLineWord)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0;
        val_5 = val_5 + (this.progressData.currentLineWord << 2);
        if(((0 + (this.progressData.currentLineWord) << 2) + 16 + 12.Equals(value:  word)) != true)
        {
                if(this.progressData.alternateLineWord == 1)
        {
                return;
        }
        
            if(0 <= this.progressData.alternateLineWord)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_6 = 0;
            val_6 = val_6 + (this.progressData.alternateLineWord << 2);
            val_5 = mem[(0 + (this.progressData.alternateLineWord) << 2) + 16 + 12];
            val_5 = (0 + (this.progressData.alternateLineWord) << 2) + 16 + 12;
            if((val_5.Equals(value:  word)) == false)
        {
                return;
        }
        
        }
        
        this.CollectTileObject();
    }
    public override void OnHintIncompleteWord(string word, Cell hintedCell)
    {
        UnityEngine.Object val_4 = 35632948;
        if(this.IsTileCurrentlyInPlay == false)
        {
                return;
        }
        
        WordRegion val_2 = WordRegion.instance;
        if(0 <= this.progressData.currentLineWord)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = 0;
        val_4 = val_4 + (this.progressData.currentLineWord << 2);
        if(((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 12) <= this.progressData.currentCell)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = (0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8;
        val_5 = val_5 + (this.progressData.currentCell << 2);
        val_4 = mem[((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8 + (this.progressData.currentCell) << 2) + 16];
        val_4 = ((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8 + (this.progressData.currentCell) << 2) + 16;
        if(hintedCell != val_4)
        {
                return;
        }
        
        this.ShiftTileObject();
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        if(this != 0)
        {
                return;
        }
        
        mem2[0] = 101;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override void OnGameButtonPressed(bool connected)
    {
        this.currPurchasePoint = 102;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override int GetMovingWordIndex()
    {
        if(this.IsTileCurrentlyInPlay == false)
        {
                return this.GetMovingWordIndex();
        }
        
        if(this.progressData != 0)
        {
                return (int)this.progressData.currentLineWord;
        }
        
        return (int)this.progressData.currentLineWord;
    }
    public PurchaseModel GetPiggyPurchaseModel()
    {
        int val_2 = UnityEngine.Mathf.Clamp(value:  this.PiggyBankLevel, min:  1, max:  5);
        int val_3 = this.PiggyBankLevel;
        string val_4 = System.String.Format(format:  -1111803792, arg0:  13152256);
        twelvegigs.storage.JsonDictionary val_5 = PackagesManager.GetPackageById(packageId:  -1111803792);
        PurchaseModel val_6 = new PurchaseModel(json:  -1111803792);
    }
    public void DoPurchasePiggyBank()
    {
        int val_9;
        int val_10;
        int val_11;
        int val_12;
        var val_14;
        if(this.PiggyBankLevel < 1)
        {
                return;
        }
        
        if(this.PiggyBankLevel > 5)
        {
                return;
        }
        
        if(this.IsPiggyBankFull() == false)
        {
                return;
        }
        
        if(this.progressData.isMaxPiggyPurchased == true)
        {
                return;
        }
        
        int val_4 = this.PiggyBankLevel;
        string val_5 = System.String.Format(format:  -1111803792, arg0:  13152256);
        twelvegigs.storage.JsonDictionary val_6 = PackagesManager.GetPackageById(packageId:  -1111803792);
        PurchaseModel val_7 = new PurchaseModel(json:  -1111803792);
        decimal val_8 = PiggyBankCoins;
        AddReward(rewardType:  2129282688, amount:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_11, mid = val_12});
        var val_14 = 25839545;
        val_14 = 9786516 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        PurchaseProxy.currentPurchasePoint = this.currPurchasePoint;
        bool val_13 = PurchaseProxy.Purchase(purchase:  292597760);
    }
    public PiggyBankRaidPlayerProfile CreateRandomDummyOpponent()
    {
        int val_14;
        int val_15;
        int val_16;
        RandomSet val_2 = new RandomSet();
        int val_3 = this.PiggyBankLevel + 1;
        if(val_3 >= 1)
        {
                var val_21 = 1;
            do
        {
            if((this.econ.fakeOpponentBankLevelWeights.ContainsKey(key:  1)) != false)
        {
                int val_5 = this.econ.fakeOpponentBankLevelWeights.Item[1];
            add(item:  1, weight:  (float)val_5);
        }
        
            val_21 = val_21 + 1;
        }
        while(val_21 <= val_3);
        
        }
        
        decimal val_8 = Item[this.econ.bankMaxCoins];
        int val_11 = UnityEngine.Random.Range(min:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = this.econ.minimumRaidableCoins, hi = val_5, lo = 259637248, mid = 1152921511111016832}), max:  (System.Decimal.op_Explicit(value:  new System.Decimal())) + 1);
        decimal val_12 = System.Decimal.op_Implicit(value:  -1111522696);
        decimal val_17 = GenerateRandomRaidableCoins(coinUpperLimit:  new System.Decimal() {flags = -1111510624, hi = val_14, lo = val_15, mid = val_16});
        if(new PiggyBankRaidPlayerProfile() != 0)
        {
                typeof(PiggyBankRaidPlayerProfile).__il2cppRuntimeField_28 = 1;
        }
        else
        {
                mem[40] = 1;
        }
        
        typeof(PiggyBankRaidPlayerProfile).__il2cppRuntimeField_8 = "dummyId";
        typeof(PiggyBankRaidPlayerProfile).__il2cppRuntimeField_C = SLC.Social.SocialManager.GetRandomAvatarID();
        string val_20 = SLC.Social.SocialManager.GetRandomProfileName();
        typeof(PiggyBankRaidPlayerProfile).__il2cppRuntimeField_10 = 0;
        typeof(PiggyBankRaidPlayerProfile).__il2cppRuntimeField_14 = roll(unweighted:  false);
    }
    public decimal GetPiggyBankOverflowAmount()
    {
        int val_4;
        int val_6;
        var val_8;
        int val_9;
        var val_11;
        val_8 = this;
        int val_1 = R1.PiggyBankLevel;
        decimal val_2 = Item[R1 + 24 + 12];
        decimal val_3 = PiggyBankCoins;
        decimal val_5 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1111382036}, d2:  new System.Decimal() {flags = val_4});
        val_9 = R6;
        bool val_7 = System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = R5, hi = val_9, lo = R7, mid = val_6}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        if(val_7 != false)
        {
                val_11 = null;
            val_11 = null;
            return new System.Decimal() {flags = val_7, hi = val_9, lo = R7, mid = val_6};
        }
        
        mem[1152921512085411628] = val_6;
        return new System.Decimal() {flags = val_7, hi = val_9, lo = R7, mid = val_6};
    }
    public bool IsPiggyBankFull()
    {
        int val_4;
        decimal val_1 = PiggyBankCoins;
        int val_2 = this.PiggyBankLevel;
        decimal val_3 = Item[this.econ.bankMaxCoins];
        return (bool)System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_4});
    }
    public decimal GenerateRandomRaidableCoins(decimal coinUpperLimit)
    {
        int val_1;
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        int val_15;
        int val_16;
        val_15 = val_1;
        val_16 = coinUpperLimit.mid;
        val_16 = coinUpperLimit.mid;
        val_15 = val_15;
        decimal val_2 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1111141620, hi = coinUpperLimit.hi, lo = coinUpperLimit.lo, mid = val_16}, d2:  new System.Decimal() {flags = val_15, hi = coinUpperLimit.flags + 24 + 24, lo = coinUpperLimit.flags + 24 + 28, mid = coinUpperLimit.flags + 24 + 32});
        decimal val_3 = System.Decimal.op_Implicit(value:  -1111141636);
        decimal val_9 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -1111141652}, d2:  new System.Decimal() {flags = val_5, hi = val_4, lo = val_6, mid = val_7});
        int val_10 = System.Decimal.op_Explicit(value:  new System.Decimal());
        int val_12 = (val_10 + (val_10 << 2)) << 2;
        decimal val_13 = System.Decimal.op_Implicit(value:  -1111141668);
        decimal val_14 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1111129568, hi = coinUpperLimit.flags + 24 + 24, lo = coinUpperLimit.flags + 24 + 28, mid = coinUpperLimit.flags + 24 + 32}, d2:  new System.Decimal() {flags = coinUpperLimit.flags + 24 + 36});
        return new System.Decimal() {flags = val_14.flags, hi = val_14.hi, lo = val_14.lo, mid = val_14.mid};
    }
    public System.Collections.Generic.List<System.Decimal> GeneratePickerOptionsFromCoins(decimal coins)
    {
        System.MidpointRounding val_6;
        int val_8;
        System.MidpointRounding val_11;
        int val_13;
        System.MidpointRounding val_16;
        int val_18;
        int val_19;
        int val_20;
        int val_21;
        int val_22;
        var val_23;
        int val_24;
        System.Collections.Generic.List<System.Decimal> val_25;
        var val_26;
        int val_27;
        val_19 = coins.lo;
        val_20 = coins.hi;
        val_21 = coins.mid;
        val_22 = 1152921504617017344;
        val_21 = coins.mid;
        val_24 = val_21;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = coins.flags, hi = val_20, lo = val_19, mid = val_21}, d2:  new System.Decimal() {flags = this.econ.minimumRaidableCoins, lo = this, mid = this.econ})) != false)
        {
                val_25 = 0;
            string val_2 = -1111037472(-1111037472) + 10170368;
            UnityEngine.Debug.LogError(message:  -1111037472);
            return;
        }
        
        val_25 = null;
        val_25 = new System.Collections.Generic.List<System.Decimal>();
        val_26 = null;
        val_27 = val_19;
        Add(item:  new System.Decimal() {flags = System.Decimal.Zero, hi = R8, lo = SB, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        val_22 = ;
        val_19 = val_20;
        val_20 = coins.flags;
        if(this == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        decimal val_4 = System.Decimal.op_Explicit(value:  null);
        decimal val_5 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -1111012004, hi = val_20, lo = val_19, mid = val_22}, d2:  new System.Decimal() {flags = coins.mid, hi = coins.flags, lo = val_20, mid = val_19});
        decimal val_7 = System.Math.Round(d:  new System.Decimal() {flags = -1111012020}, mode:  val_6);
        Add(item:  new System.Decimal() {mid = val_8});
        if(val_25 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_24 = 0;
        decimal val_9 = System.Decimal.op_Explicit(value:  null);
        decimal val_10 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -1111012052, hi = val_20, lo = val_19, mid = val_22}, d2:  new System.Decimal() {flags = coins.mid});
        decimal val_12 = System.Math.Round(d:  new System.Decimal() {flags = -1111012068}, mode:  val_11);
        Add(item:  new System.Decimal() {mid = val_13});
        if(this <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        decimal val_14 = System.Decimal.op_Explicit(value:  null);
        decimal val_15 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -1111012100, hi = val_20, lo = val_19, mid = val_22}, d2:  new System.Decimal() {flags = coins.mid});
        decimal val_17 = System.Math.Round(d:  new System.Decimal() {flags = -1111012116}, mode:  val_16);
        val_23 = public System.Void System.Collections.Generic.List<System.Decimal>::Add(System.Decimal item);
        Add(item:  new System.Decimal() {mid = val_18});
        PluginExtension.Shuffle<System.Decimal>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    public void UpdateProgressToServer()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        int val_2 = this.PiggyBankLevel;
        Add(key:  -1988561632, value:  13152256);
        decimal val_3 = PiggyBankCoins;
        Add(key:  -1987496016, value:  10170368);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  this.lastProcessedNewsTimestamp, data:  78753792);
    }
    public System.Collections.Generic.List<PiggyBankRaidNewsArticle> GetRaidNews()
    {
        if(this.progressData != 0)
        {
                return;
        }
    
    }
    private bool IsEventExpired()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = R7 + 40})) == false)
        {
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = this.currentTileObj});
        }
        
        return true;
    }
    private bool IsCurrentEventInCycle()
    {
        var val_1 = R6 + 48;
        val_1 = this.progressData.eventId - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public bool IsEventCompleted()
    {
        if(this.progressData != 0)
        {
                return (bool)this.progressData.isMaxPiggyPurchased;
        }
        
        return (bool)this.progressData.isMaxPiggyPurchased;
    }
    private void ParsePlayerProgressFromServer(System.Collections.Generic.Dictionary<string, object> eventDataDict)
    {
        int val_13;
        int val_14;
        int val_15;
        int val_16;
        PiggyBankRaidEventHandler val_37;
        object val_38;
        decimal val_39;
        decimal val_40;
        var val_41;
        float val_42;
        PiggyBankRaidProgress val_43;
        int val_44;
        int val_45;
        var val_46;
        val_37 = this;
        val_38 = eventDataDict;
        if(val_38 == 0)
        {
                return;
        }
        
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.debugLastPayLoad = null;
            val_40 = "coins";
            if((val_38.ContainsKey(key:  -1987496016)) != false)
        {
                object val_5 = val_38.Item[-1987496016];
            val_41 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            this.debugLastPayLoad.Add(key:  -1987496016, value:  val_38);
            val_38 = val_38;
        }
        
            if((val_38.ContainsKey(key:  -1545439648)) != false)
        {
                val_40 = val_38;
            object val_7 = val_38.Item[-1545439648];
            val_41 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            this.debugLastPayLoad.Add(key:  -1545439648, value:  val_38);
            val_38 = val_40;
        }
        
        }
        
        val_42 = 1152921510392296080;
        if((val_38.ContainsKey(key:  -1987496016)) == false)
        {
            goto label_36;
        }
        
        val_40 = this.progressData.player.coins;
        object val_9 = val_38.Item[-1987496016];
        string val_10 = val_38.ToString();
        if((System.Decimal.TryParse(s:  val_38, result: out  new System.Decimal() {flags = -1110215592, lo = 1633188144})) == false)
        {
            goto label_36;
        }
        
        val_43 = this.progressData;
        if(this.progressData != 0)
        {
            goto label_17;
        }
        
        val_43 = this.progressData;
        if(val_43 == 0)
        {
            goto label_18;
        }
        
        label_17:
        PiggyBankRaidPlayerProfile val_12 = this.progressData.player + 28;
        val_45 = mem[(this.progressData.player + 28) + (4)];
        val_44 = mem[(this.progressData.player + 28) + (0)];
        decimal val_17 = System.Math.Min(val1:  new System.Decimal() {flags = -1110215616, hi = this.progressData.player.coins, lo = val_44, mid = val_45}, val2:  new System.Decimal() {flags = mem[(this.progressData.player + 28) + (8)], hi = val_13, lo = val_14, mid = val_15});
        val_37 = val_37;
        val_46 = null;
        val_46 = null;
        bool val_18 = System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = mem[this.progressData.player.coins + (0)], hi = mem[this.progressData.player.coins + (4)], lo = mem[this.progressData.player.coins + (8)], mid = val_16}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        val_42 = 1152921510392296080;
        val_38 = val_38;
        val_39 = val_40;
        CompanyDevices val_19 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                val_38 = val_38;
            if((System.Decimal.op_Inequality(d1:  new System.Decimal() {flags = val_39, hi = 1152921510385703632, lo = 1152921510385703632, mid = 1152921510385703632}, d2:  new System.Decimal())) != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = "Value \'";
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = "\' from server, final coins: ";
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = " (Was: ";
            val_40 = null;
            typeof(System.Object[]).__il2cppRuntimeField_24 = val_40;
            typeof(System.Object[]).__il2cppRuntimeField_28 = ")";
            string val_22 = +472754880;
            this.AddToCoinLog(logStr:  472754880);
            val_38 = val_38;
        }
        
        }
        
        label_36:
        if((val_38.ContainsKey(key:  -1545439648)) == false)
        {
                return;
        }
        
        val_39 = 1152921510385703632;
        string val_24 = val_38.Item[-1545439648];
        val_40 = 1;
        if((0.ContainsKey(key:  -1110236928)) != false)
        {
                string val_26 = 0.Item[-1110236928];
            string val_27 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  0);
            object val_28 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  null);
            this.ProcessRaidNews(news:  0);
        }
        
        if((0.ContainsKey(key:  -1988561632)) != false)
        {
                string val_30 = 0.Item[-1988561632];
            if((System.Int32.TryParse(s:  null, result: out  int val_31 = -1110215596)) != false)
        {
                val_38 = this.progressData.player;
            if(0 > this.progressData.player.bankLevel)
        {
                val_38 = 0;
            this.progressData.player.bankLevel = 0;
        }
        
        }
        
        }
        
        if((0.ContainsKey(key:  -1110227632)) == false)
        {
                return;
        }
        
        string val_34 = 0.Item[-1110227632];
        bool val_36 = System.Int32.TryParse(s:  null, result: out  int val_35 = -1110215600);
        return;
        label_18:
    }
    private void SetupEvent()
    {
        if(R1 != 0)
        {
                this.econ = new PiggyBankRaidEcon(eventDataDict:  R1 + 72);
        }
        
        if(this.IsEventExpired() != true)
        {
                if(this.IsCurrentEventInCycle() == true)
        {
            goto label_4;
        }
        
        }
        
        this.progressData = new PiggyBankRaidProgress();
        this.ClearTileObject();
        label_4:
        if(this.IsEventExpired() != false)
        {
                return;
        }
        
        this.ParsePlayerProgressFromServer(eventDataDict:  328826880);
        this.progressData.eventId = PiggyBankRaidEcon.__il2cppRuntimeField_generic_class;
        if(this.progressData == 0)
        {
            
        }
    
    }
    private void LoadGameData()
    {
        int val_12;
        int val_19;
        int val_20;
        bool val_21;
        int val_22;
        PiggyBankRaidEcon val_23;
        int val_24;
        var val_25;
        System.Predicate<LineWord> val_27;
        PiggyBankRaidProgress val_28;
        if(this.IsCurrentEventInCycle() == false)
        {
                return;
        }
        
        if(this.progressData.isMaxPiggyPurchased == true)
        {
                return;
        }
        
        WordRegion val_2 = WordRegion.instance;
        val_19 = 0;
        val_20 = PlayingLevel.GetCurrentPlayerLevelNumber();
        if(this.progressData.currentAssociatedLevel == 1)
        {
            goto label_9;
        }
        
        val_21 = this.<QA_LevelBufferHack>k__BackingField;
        val_22 = 1;
        if(val_21 != true)
        {
                val_23 = this.econ;
            val_22 = this.econ.levelBuffer;
        }
        
        if((val_20 - this.progressData.currentAssociatedLevel) < val_22)
        {
            goto label_13;
        }
        
        label_9:
        val_24 = 1152921504935866368;
        val_23 = 0;
        val_25 = null;
        val_25 = null;
        val_27 = PiggyBankRaidEventHandler.<>c.<>9__69_0;
        if(val_27 == 0)
        {
                val_27 = null;
            val_27 = new System.Predicate<ZooTile>(object:  PiggyBankRaidEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3185070256));
            val_20 = val_20;
            PiggyBankRaidEventHandler.<>c.<>9__69_0 = val_27;
        }
        
        if((val_23.Exists(match:  8040448)) == true)
        {
                return;
        }
        
        System.Collections.Generic.List<System.Int32> val_7 = val_19.getAvailableLineIndices;
        if(0 == 0)
        {
                return;
        }
        
        val_24 = val_20;
        RandomSet val_8 = null;
        val_23 = val_8;
        val_8 = new RandomSet();
        System.Collections.Generic.List<System.Int32> val_9 = val_19.getAvailableLineIndices;
        List.Enumerator<T> val_10 = GetEnumerator();
        val_20 = val_24;
        label_27:
        if(MoveNext() == false)
        {
            goto label_25;
        }
        
        add(item:  val_12, weight:  null);
        goto label_27;
        label_25:
        Dispose();
        label_64:
        this.progressData.currentAssociatedLevel = val_20;
        this.progressData.currentLineWord = roll(unweighted:  false);
        val_19 = val_19;
        this.progressData.currentCell = 0;
        label_13:
        if((this.progressData.currentAssociatedLevel == val_20) && (this.progressData.currentLineWord >= 0))
        {
                val_23 = 0;
            if((this.progressData.currentLineWord < 0) && (this.progressData.currentCell >= 0))
        {
                val_28 = this.progressData;
            if(this.progressData == 0)
        {
                val_28 = this.progressData;
            if(val_28 == 0)
        {
            goto label_61;
        }
        
        }
        
            val_24 = val_19;
            val_19 = 0;
            if(0 <= this.progressData.currentLineWord)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_18 = 0;
            val_18 = val_18 + (this.progressData.currentLineWord << 2);
            val_23 = mem[(0 + (this.progressData.currentLineWord) << 2) + 16 + 20];
            val_23 = (0 + (this.progressData.currentLineWord) << 2) + 16 + 20;
            if(this.progressData.currentCell < ((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 12))
        {
                UnityEngine.GameObject val_14 = (0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 12.TilePrefab;
            val_23 = (0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 12;
            if(0 <= this.progressData.currentLineWord)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_19 = 0;
            val_19 = val_19 + (this.progressData.currentLineWord << 2);
            val_19 = this.progressData.currentCell;
            if(((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 12) <= val_19)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_20 = (0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8;
            val_20 = val_20 + (val_19 << 2);
            UnityEngine.Transform val_15 = ((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8 + (this.progressData.currentCell) << 2) + 16.transform;
            object val_16 = UnityEngine.Object.Instantiate<System.Object>(original:  val_23, parent:  ((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8 + (this.progressData.currentCell) << 2) + 16);
            this.currentTileObj = val_23;
        }
        
        }
        
        }
        
        this.RetrieveRaidPool();
        this.progressData.alternateLineWord = this.FindAlternateLineWord();
        return;
        label_61:
        Dispose();
        if(null == 0)
        {
            goto label_64;
        }
        
        goto label_64;
    }
    private void CollectTileObject()
    {
        if(this.IsTileCurrentlyInPlay == false)
        {
                return;
        }
        
        if(this.currentTileObj == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        0.AddLevelCompleteBlocker(blocker:  1);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ToggleDarkener(state:  true, animated:  true, duration:  null);
        UnityEngine.Transform val_5 = this.currentTileObj.transform;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_7 = transform;
        this.currentTileObj.SetParent(p:  -1109657040);
        UnityEngine.Transform val_8 = this.currentTileObj.transform;
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  this.currentTileObj, duration:  null, strength:  new UnityEngine.Vector3() {x = 1.2f, y = val_9.x, z = val_9.y}, vibrato:  val_9.z, randomness:  null, fadeOut:  true);
        DG.Tweening.TweenCallback val_11 = new DG.Tweening.TweenCallback(object:  -1109618704, method:  new IntPtr(3185319472));
        object val_12 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.currentTileObj, action:  190734336);
        this.collectTween = this.currentTileObj;
    }
    private void ShiftTileObject()
    {
        object val_1 = new System.Object();
        typeof(PiggyBankRaidEventHandler.<>c__DisplayClass71_0).__il2cppRuntimeField_C = this;
        WordRegion val_2 = WordRegion.instance;
        if(1 == 0)
        {
                1 = this.collectTween;
        }
        
        if(1 != 0)
        {
                return;
        }
        
        if(0 <= this.progressData.currentLineWord)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_10 = 0;
        val_10 = val_10 + (this.progressData.currentLineWord << 2);
        typeof(PiggyBankRaidEventHandler.<>c__DisplayClass71_0).__il2cppRuntimeField_8 = (0 + (this.progressData.currentLineWord) << 2) + 16;
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  329072640, method:  new IntPtr(3185465264));
        this.progressData.currentCell = (0 + (this.progressData.currentLineWord) << 2) + 16 + 20.FindIndex(match:  8040448);
        if(this.progressData.currentCell > 1)
        {
                UnityEngine.Transform val_5 = this.currentTileObj.transform;
            if(((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 12) <= this.progressData.currentCell)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_11 = (0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8;
            val_11 = val_11 + (this.progressData.currentCell << 2);
            UnityEngine.Transform val_6 = ((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8 + (this.progressData.currentCell) << 2) + 16.transform;
            this.currentTileObj.SetParent(p:  ((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8 + (this.progressData.currentCell) << 2) + 16);
            UnityEngine.Transform val_7 = this.currentTileObj.transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.currentTileObj.localPosition = new UnityEngine.Vector3();
        }
        else
        {
                this.ClearTileObject();
        }
        
        this.progressData.alternateLineWord = this.FindAlternateLineWord();
        if(this.progressData != 0)
        {
                return;
        }
    
    }
    private void ClearTileObject()
    {
        if(this.progressData != 0)
        {
                this.progressData.alternateLineWord = 0;
            this.progressData.currentCell = 0;
        }
        else
        {
                mem[32] = 0;
            mem[36] = 0;
        }
        
        this.progressData.currentLineWord = 0;
        UnityEngine.Object.Destroy(obj:  this.currentTileObj);
        this.currentTileObj = 0;
    }
    private int FindAlternateLineWord()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_4 = 25829127;
        val_4 = 9796660 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        val_5 = 0;
        if(App.game != 4)
        {
                return (int)val_5;
        }
        
        if(this.IsTileCurrentlyInPlay == false)
        {
                return (int)val_5;
        }
        
        WordRegion val_2 = WordRegion.instance;
        if(0 <= this.progressData.currentLineWord)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0;
        val_5 = val_5 + (this.progressData.currentLineWord << 2);
        if(((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 12) <= this.progressData.currentCell)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = (0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8;
        val_6 = 0;
        val_6 = val_6 + (this.progressData.currentCell << 2);
        goto label_18;
        label_27:
        if(val_6 == this.progressData.currentLineWord)
        {
            goto label_20;
        }
        
        if(0 <= val_6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = 0;
        val_7 = val_7 + 0;
        if(((0 + 0) + 16 + 20.Contains(item:  ((0 + (this.progressData.currentLineWord) << 2) + 16 + 20 + 8 + (this.progressData.currentCell) << 2) + 16)) == true)
        {
            goto label_25;
        }
        
        label_20:
        val_6 = 1;
        label_18:
        if(val_6 < 0)
        {
            goto label_27;
        }
        
        return (int)val_5;
        label_25:
        val_5 = val_6;
        return (int)val_5;
    }
    private void OnRaidPickerPopupClose()
    {
        WordRegion val_1 = WordRegion.instance;
        0.RemoveLevelCompleteBlocker(blocker:  1);
    }
    public System.DateTime GetLastProcessedNewsTimestamp()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = R1;
        val_11 = val_10 + 48;
        if((R1 + 56) == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1108950608, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  -1108950608)) != false)
        {
                val_12 = mem[R1 + 56];
            val_12 = R1 + 56;
        }
        else
        {
                System.DateTime val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.DateTime>(value:  -1108937504);
            System.Nullable<System.DateTime> val_6 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = 1152921512087830960});
            val_12 = D17;
        }
        
            if(val_12 == 255)
        {
                val_13 = null;
            val_13 = null;
            System.Nullable<System.DateTime> val_7 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = System.DateTime.__il2cppRuntimeField_cctor_finished});
        }
        
        }
        
        System.DateTime val_8 = this.Value;
        return new System.DateTime() {dateData = val_8.dateData};
    }
    public void SetLastProcessedNewsTimestamp(System.DateTime date)
    {
        System.Nullable<System.DateTime> val_1 = new System.Nullable<System.DateTime>(value:  new System.DateTime() {dateData = date.dateData});
        string val_2 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  19755008);
        UnityEngine.PlayerPrefs.SetString(key:  -1108950608, value:  19755008);
    }
    private void ProcessRaidNews(System.Collections.Generic.List<PiggyBankRaidNewsArticle> news)
    {
        ulong val_3;
        var val_4;
        var val_16;
        System.Collections.Generic.List<PiggyBankRaidNewsArticle> val_17;
        var val_18;
        var val_19;
        System.Comparison<PiggyBankRaidNewsArticle> val_21;
        var val_22;
        var val_23;
        ulong val_24;
        var val_25;
        var val_26;
        val_16 = this;
        val_17 = news;
        if(val_17 == 0)
        {
                return;
        }
        
        if(true < 1)
        {
                return;
        }
        
        val_18 = 1152921504935866368;
        val_19 = null;
        val_19 = null;
        val_21 = PiggyBankRaidEventHandler.<>c.<>9__77_0;
        if(val_21 == 0)
        {
                val_21 = null;
            val_22 = public System.Void System.Comparison<PiggyBankRaidNewsArticle>::.ctor(object object, IntPtr method);
            val_21 = new System.Comparison<WordForest.NewsArticle>(object:  PiggyBankRaidEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3186245920));
            PiggyBankRaidEventHandler.<>c.<>9__77_0 = val_21;
        }
        
        val_17.Sort(comparison:  7933952);
        System.DateTime val_2 = GetLastProcessedNewsTimestamp();
        val_24 = val_2.dateData - 1;
        if(val_24 >= 0)
        {
                ulong val_5 = val_2.dateData + 3;
            do
        {
            val_21 = val_5 - 4;
            val_18 = val_5;
            if(val_2.dateData <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_22 = val_4;
            if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = 0 + ((val_2.dateData + 3)) << 2 + 40}, t2:  new System.DateTime() {dateData = val_3})) >= 1)
        {
                if((news + 12) <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_25 = 1;
            if((System.String.IsNullOrEmpty(value:  news + 8 + ((val_2.dateData + 3)) << 2 + 12)) != true)
        {
                val_25 = news + 8 + ((val_2.dateData + 3)) << 2 + 12.Contains(value:  -1108718304);
        }
        
            if(this.progressData.raidNewsList == 0)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.progressData.raidNewsList = null;
        }
        
            val_21 = this.progressData.raidNewsList;
            val_21.Add(item:  news + 8 + ((val_2.dateData + 3)) << 2);
            if(val_25 != true)
        {
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            var val_11 = (news + 8 + ((val_2.dateData + 3)) << 2) + 20;
            Add(key:  -1928141856, value:  10170368);
            Add(key:  -1108687504, value:  10170368);
            Add(key:  -1108687392, value:  news + 8 + ((val_2.dateData + 3)) << 2 + 12);
            var val_13 = 25830370;
            val_13 = 9795168 + val_13;
            val_26 = null;
            val_26 = null;
            val_21 = App.trackerManager;
            val_22 = 0;
            val_21.track(eventName:  -1108687296, data:  78753792);
            val_16 = val_16;
        }
        
        }
        
            val_17 = val_17;
            val_24 = val_18 - 1;
            val_23 = mem[news + 12];
            val_23 = news + 12;
        }
        while((val_18 - 5) > 1);
        
        }
        
        if(val_23 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.SetLastProcessedNewsTimestamp(date:  new System.DateTime() {dateData = val_24});
    }
    private string GetPlatformId()
    {
    
    }
    private void RetrieveRaidPool()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_2 = App.Player;
        Add(key:  -1824276800, value:  33449456);
        Player val_3 = App.Player;
        Add(key:  1618311216, value:  1835037);
        Add(key:  -1383323792, value:  -1953384624);
        decimal val_4 = PiggyBankCoins;
        Add(key:  -1987496016, value:  10170368);
        this.cachedOpponentPool.Clear();
        PiggyBankRaidPlayerProfile val_5 = this.CreateRandomDummyOpponent();
        this.cachedOpponentPool.Add(item:  -1108386896);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1108386896, method:  new IntPtr(3186555280));
        GetCustomData(eventId:  R7, urlSubPath:  -1108410992, data:  78753792, onResponse:  null);
    }
    public void SendRaidResultToServer(decimal amountStolen)
    {
        var val_7;
        string val_8;
        if(this.currentOpponent != 0)
        {
                if(this.currentOpponent.isDummyAccount == false)
        {
                this.currentOpponent.isDummyAccount = this.currentOpponent.<autoCreated>k__BackingField;
            goto label_2;
        }
        
        }
        
        label_8:
        val_7 = null;
        val_7 = null;
        if(Logger.GameEvents == false)
        {
                return;
        }
        
        string val_1 = -1108286608(-1108286608) + 10170368 + -1108286480(-1108286480);
        Logger.Warn(message:  -1108286608);
        return;
        label_2:
        if((System.String.IsNullOrEmpty(value:  this.currentOpponent.userId)) == true)
        {
            goto label_8;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_4 = App.Player;
        Add(key:  -1824276800, value:  33449456);
        Player val_5 = App.Player;
        Add(key:  1618311216, value:  1835037);
        Add(key:  -1383323792, value:  -1953384624);
        val_8 = this.currentOpponent.userId;
        if(null == 0)
        {
                val_8 = val_8;
        }
        
        Add(key:  -1108274032, value:  val_8);
        Add(key:  -1987496016, value:  10170368);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PostCustomData(eventId:  this.lastProcessedNewsTimestamp, urlSubPath:  -1202791792, data:  78753792, onResponse:  0);
    }
    public void AddToCoinLog(string logStr)
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_11;
        if(this.debugCoinChangeLog == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1108137360, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  -1108137360)) != false)
        {
                val_11 = null;
            val_11 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
        else
        {
                object val_4 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1108137360);
            val_11 = "pbr_db_coinlog";
        }
        
            this.debugCoinChangeLog = val_11;
            if(val_11 == 0)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.debugCoinChangeLog = null;
        }
        
        }
        
        System.DateTime val_6 = System.DateTime.Now;
        typeof(System.String[]).__il2cppRuntimeField_10 = "[";
        string val_7 = ???.ToShortDateString();
        typeof(System.String[]).__il2cppRuntimeField_14 = ;
        typeof(System.String[]).__il2cppRuntimeField_18 = " ";
        string val_8 = ???.ToShortTimeString();
        typeof(System.String[]).__il2cppRuntimeField_1C = ;
        typeof(System.String[]).__il2cppRuntimeField_20 = "] ";
        typeof(System.String[]).__il2cppRuntimeField_24 = logStr;
        string val_9 = +477709520;
        this.debugCoinChangeLog.Add(item:  477709520);
        if(this.debugCoinChangeLog >= 26)
        {
                this.debugCoinChangeLog.RemoveAt(index:  0);
        }
        
        string val_10 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.debugCoinChangeLog);
        UnityEngine.PlayerPrefs.SetString(key:  -1108137360, value:  this.debugCoinChangeLog);
    }
    public string GetCoinLog()
    {
        string val_9;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_11;
        if(this.debugCoinChangeLog == 0)
        {
                string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1108137360, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  -1108137360)) != false)
        {
                val_11 = null;
            val_11 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
        else
        {
                object val_4 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1108137360);
            val_11 = "pbr_db_coinlog";
        }
        
            this.debugCoinChangeLog = val_11;
            if(val_11 == 0)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.debugCoinChangeLog = null;
        }
        
        }
        
        List.Enumerator<T> val_7 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        System.Text.StringBuilder val_10 = AppendLine(value:  val_9);
        goto label_10;
        label_8:
        Dispose();
        if(new System.Text.StringBuilder() != 0)
        {
                return;
        }
    
    }
    public string get_QA_RaidPoolIds()
    {
        var val_5 = 0;
        label_21:
        if(val_5 >= "")
        {
                return;
        }
        
        if("" <= val_5)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        if(((0 + 0) + 16) == 0)
        {
            goto label_5;
        }
        
        if(((0 + 0) + 16 + 40) == 0)
        {
                (0 + 0) + 16 + 40 = mem[(0 + 0) + 16 + 41];
            (0 + 0) + 16 + 40 = (0 + 0) + 16 + 41;
            goto label_6;
        }
        
        label_22:
        label_23:
        typeof(System.Object[]).__il2cppRuntimeField_10 = "EE0000";
        typeof(System.Object[]).__il2cppRuntimeField_14 = (0 + 0) + 16 + 16;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        if(val_5 >= ((System.Object[].__il2cppRuntimeField_namespaze - 1)))
        {
                "\n" = 25475904;
            "\n" = 1152921504622235648;
            "\n" = null;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_1C = System.String.alignConst;
        string val_1 = System.String.Format(format:  -1107847648, args:  472754880);
        string val_2 = 1098586544 + -1107847648(-1107847648);
        label_5:
        val_5 = val_5 + 1;
        goto label_21;
        label_6:
        if((System.String.IsNullOrEmpty(value:  (0 + 0) + 16 + 8)) == true)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    public bool get_QA_LevelBufferHack()
    {
        return (bool)this.<QA_LevelBufferHack>k__BackingField;
    }
    public void set_QA_LevelBufferHack(bool value)
    {
        this.<QA_LevelBufferHack>k__BackingField = value;
    }
    public bool get_QA_NextPiggyCreditFillExactlyMax()
    {
        return (bool)this.<QA_NextPiggyCreditFillExactlyMax>k__BackingField;
    }
    public void set_QA_NextPiggyCreditFillExactlyMax(bool value)
    {
        this.<QA_NextPiggyCreditFillExactlyMax>k__BackingField = value;
    }
    public PiggyBankRaidEventHandler()
    {
        this.econ = new PiggyBankRaidEcon();
        this.progressData = new PiggyBankRaidProgress();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.cachedOpponentPool = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.debugLastPayLoad = null;
    }
    private static PiggyBankRaidEventHandler()
    {
    
    }
    private void <CollectTileObject>b__70_0()
    {
        var val_7;
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ToggleDarkener(state:  false, animated:  false, duration:  null);
        this.ClearTileObject();
        if(this.cachedOpponentPool != 0)
        {
                val_7 = this.cachedOpponentPool;
            val_8 = UnityEngine.Random.Range(min:  0, max:  typeof(PiggyBankRaidProgress).__il2cppRuntimeField_E8);
        }
        else
        {
                val_7 = 12;
            val_8 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        if(val_7 <= val_8)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + (val_8 << 2);
        this.currentOpponent = (0 + (val_3) << 2) + 16;
        GameBehavior val_4 = App.getBehavior;
        System.Action val_6 = new System.Action(object:  -1107007584, method:  new IntPtr(3187934688));
        0.Initialize(opponent:  this.currentOpponent, onClose:  7454720);
        this.collectTween = 0;
    }
    private void <RetrieveRaidPool>b__79_0(System.Collections.Generic.Dictionary<string, object> resp)
    {
        var val_5;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = resp;
        if((val_7.ContainsKey(key:  -1106903200)) == false)
        {
                return;
        }
        
        this.cachedOpponentPool.Clear();
        object val_2 = val_7.Item[-1106903200];
        val_7 = 0;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_16:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        PiggyBankRaidPlayerProfile val_6 = new PiggyBankRaidPlayerProfile();
        if(val_5 != 0)
        {
                if(((val_5 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_5 = 0;
        }
        
        }
        
        this.cachedOpponentPool.Add(item:  328859648);
        goto label_16;
        label_11:
        Dispose();
    }

}
