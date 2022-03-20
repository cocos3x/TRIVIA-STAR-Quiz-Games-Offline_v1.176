using UnityEngine;
public class SnakesAndLaddersEventHandler : WGEventHandler
{
    // Fields
    public const string SNAKES_AND_LADDERS_EVENT_ID = "SnakesAndLadders";
    private static SnakesAndLaddersEventHandler <Instance>k__BackingField;
    private SnakesAndLaddersEvent.EventProgress eventProgress;
    private UnityEngine.GameObject diceRoll;
    private UnityEngine.GameObject eventButtonGO;
    private System.Action<bool, PurchaseModel> onPurchaseComplete;
    
    // Properties
    public static SnakesAndLaddersEventHandler Instance { get; set; }
    public static int CurrentDiceRollsOnEvent { get; }
    public bool IsDiceRollShownThisLevel { get; }
    public bool IsDiceRollCollectedThisLevel { get; }
    private UnityEngine.GameObject DiceRollPrefab { get; }
    private LineWord CurrentDiceRollWord { get; }
    private Cell CurrentDiceRollCell { get; }
    public override bool OverrideEventButton { get; }
    
    // Methods
    public static SnakesAndLaddersEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(SnakesAndLaddersEventHandler value)
    {
        SnakesAndLaddersEventHandler.<Instance>k__BackingField = value;
    }
    public static int get_CurrentDiceRollsOnEvent()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        val_2 = 0;
        if(0 == 0)
        {
                return (int)SnakesAndLaddersEvent.EventProgress.__il2cppRuntimeField_namespaze;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return (int)SnakesAndLaddersEvent.EventProgress.__il2cppRuntimeField_namespaze;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) != 0)
        {
                return (int)SnakesAndLaddersEvent.EventProgress.__il2cppRuntimeField_namespaze;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField.eventProgress) == 0)
        {
                return (int)SnakesAndLaddersEvent.EventProgress.__il2cppRuntimeField_namespaze;
        }
        
        return (int)SnakesAndLaddersEvent.EventProgress.__il2cppRuntimeField_namespaze;
    }
    public bool get_IsDiceRollShownThisLevel()
    {
        Player val_1 = App.Player;
        var val_2 = 0;
        val_2 = this.eventProgress.DiceRollProgress.LastLevel - val_2;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    public bool get_IsDiceRollCollectedThisLevel()
    {
        if(this.eventProgress.DiceRollProgress != 0)
        {
                return (bool)this.eventProgress.DiceRollProgress.IsCollected;
        }
        
        return (bool)this.eventProgress.DiceRollProgress.IsCollected;
    }
    private UnityEngine.GameObject get_DiceRollPrefab()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1535358816, prefabName:  -1035894560);
    }
    private LineWord get_CurrentDiceRollWord()
    {
        WordRegion val_1 = WordRegion.instance;
        if(0 <= this.eventProgress.DiceRollProgress.LinewordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = 0;
        val_2 = val_2 + (this.eventProgress.DiceRollProgress.LinewordIndex << 2);
    }
    private Cell get_CurrentDiceRollCell()
    {
        LineWord val_1 = this.CurrentDiceRollWord;
        if(this <= this.eventProgress.DiceRollProgress.CellIndex)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (this.eventProgress.DiceRollProgress.CellIndex << 2);
    }
    public override void Init(GameEventV2 eventV2)
    {
        SnakesAndLaddersEventHandler.<Instance>k__BackingField = this;
        mem[1152921512161296264] = eventV2;
        this.RefreshEventData(data:  eventV2.eventData);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        this.RefreshEventData(data:  eventV2.eventData);
    }
    public override bool IsEventEndedOffline()
    {
        System.TimeSpan val_1 = GetTimeLeft();
        double val_2 = ???.TotalSeconds;
        if()
        {
                0 = 1;
        }
        
        return true;
    }
    public override void OnWordRegionLoaded()
    {
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        object val_4 = UnityEngine.Object.FindObjectOfType<System.Object>();
        UnityEngine.GameObject val_5 = public static WGEventButton_Game UnityEngine.Object::FindObjectOfType<WGEventButton_Game>().__il2cppRuntimeField_14.gameObject;
        mem2[0] = public static WGEventButton_Game UnityEngine.Object::FindObjectOfType<WGEventButton_Game>().__il2cppRuntimeField_14;
        R4.ShowDiceRoll();
    }
    public override void OnValidWordSubmitted(string word)
    {
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        35644696 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(this.IsReadyToCollectDiceRoll() == false)
        {
                return;
        }
        
        this.OnWordSubmitted(word:  word);
    }
    public override void OnHintIncompleteWord(string word, Cell hintedCell)
    {
        string val_9;
        var val_10;
        val_9 = word;
        val_10 = 35644697;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(this.IsReadyToCollectDiceRoll() == false)
        {
                return;
        }
        
        LineWord val_5 = this.CurrentDiceRollWord;
        val_10 = this;
        if((System.String.op_Inequality(a:  val_9, b:  null)) == true)
        {
                return;
        }
        
        Cell val_7 = this.CurrentDiceRollCell;
        val_9 = this;
        if((System.String.op_Inequality(a:  hintedCell.letter, b:  null)) != false)
        {
                return;
        }
        
        this.ShiftDiceRoll();
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        if(CategoryPacksManager.IsPlaying != false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        if((R4 + 16) == 0)
        {
            
        }
    
    }
    public override int LastProgressTimestamp()
    {
        if(this.eventProgress != 0)
        {
                return (int)this.eventProgress.LastProgressTimestamp;
        }
        
        return (int)this.eventProgress.LastProgressTimestamp;
    }
    public override void UpdateProgress()
    {
        this.eventProgress.LastProgressTimestamp = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override bool EventCompleted()
    {
        ulong val_4;
        var val_11;
        ulong val_12;
        var val_14;
        val_11 = R6;
        if(R6 == 0)
        {
                if(val_11 == 0)
        {
            goto label_2;
        }
        
        }
        
        val_12 = mem[R6 + 40];
        val_12 = R6 + 40;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = R6 + 32}, d2:  new System.DateTime() {dateData = val_12})) != false)
        {
                System.DateTime val_3 = DateTimeCheat.UtcNow;
            bool val_6 = System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = 1152921512162377984});
        }
        else
        {
                System.DateTime val_7 = DateTimeCheat.UtcNow;
            val_12 = mem[R6 + 44 + 32];
            val_12 = R6 + 44 + 32;
            val_14 = 0;
            if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = val_12})) == false)
        {
                return (bool)val_14;
        }
        
            System.DateTime val_9 = DateTimeCheat.UtcNow;
        }
        
        val_14 = System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = 1152921512162377984});
        return (bool)val_14;
        label_2:
    }
    public override string GetMainMenuButtonText()
    {
        goto typeof(SnakesAndLaddersEventHandler).__il2cppRuntimeField_1CC;
    }
    public override string GetGameButtonText()
    {
        string val_1 = this.eventProgress.DiceBalance.ToString();
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1034083280, defaultValue:  -1034083392, useSingularKey:  false);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        if(this != 0)
        {
            
        }
        else
        {
                this.ShowBoardPopup();
        }
    
    }
    public override bool get_OverrideEventButton()
    {
        return true;
    }
    public override void OnGameButtonPressed(bool connected)
    {
        if(this != 0)
        {
            
        }
        else
        {
                this.ShowBoardPopup();
        }
    
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        var val_5 = 35644702;
        if(this != 0)
        {
                return;
        }
        
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        loader.SetupDiceBalance(balance:  this.eventProgress.DiceBalance);
        SnakesAndLaddersEvent.Board val_2 = this.GetCurrentBoard();
        float val_5 = 100f;
        val_5 = ((-1.033602E+09f) / ((float)this.eventProgress.DiceBalance + 8)) * val_5;
        string val_4 = System.String.Format(format:  2124591920, arg0:  13152256);
    }
    public override void OnPurchaseCompleted(PurchaseModel purchase)
    {
        var val_4;
        decimal val_6;
        decimal val_1 = DiceRolls;
        val_4 = null;
        val_4 = null;
        val_6 = System.Decimal.Zero;
        if((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_6})) == true)
        {
                return;
        }
        
        val_6 = purchase.id;
        if((val_6.Contains(value:  -1033497552)) == false)
        {
                return;
        }
        
        this.OnPurchaseSuccess(purchase:  purchase);
    }
    public override void OnPurchaseFailure(PurchaseModel purchase)
    {
        if((purchase.id.Contains(value:  -1033497552)) == false)
        {
                return;
        }
        
        this.OnPurchaseFail(purchase:  purchase);
    }
    public override int GetMovingWordIndex()
    {
        Player val_1 = App.Player;
        if(this.eventProgress.DiceRollProgress.LastLevel != 0)
        {
                return this.GetMovingWordIndex();
        }
        
        if(this.eventProgress.DiceRollProgress.IsCollected != false)
        {
                return this.GetMovingWordIndex();
        }
        
        if(this.eventProgress.DiceRollProgress != 0)
        {
                return (int)this.eventProgress.DiceRollProgress.LinewordIndex;
        }
        
        return (int)this.eventProgress.DiceRollProgress.LinewordIndex;
    }
    public SnakesAndLaddersEvent.BoardSpaceReward GetBoardSpaceReward()
    {
        var val_4;
        var val_11;
        var val_12;
        int val_13;
        var val_14;
        System.Collections.Generic.List<GiftRewardAmountChance> val_15;
        var val_16;
        var val_17;
        RandomSet val_1 = new RandomSet();
        val_11 = null;
        val_11 = null;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_8:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        if(val_4 != 0)
        {
                val_12 = mem[val_4 + 8];
            val_12 = val_4 + 8;
        }
        else
        {
                val_12 = 0;
        }
        
        add(item:  0, weight:  (float)val_4 + 12);
        goto label_8;
        label_4:
        Dispose();
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(372789248)});
        string val_7 = roll(unweighted:  false).ToString();
        object val_8 = System.Enum.Parse(enumType:  372789248, value:  -1033072700);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if( == 0)
        {
            goto label_16;
        }
        
        if( == 4)
        {
            goto label_17;
        }
        
        val_13 = 0;
        if( != 5)
        {
            goto label_18;
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = 1152921505039065112;
        goto label_24;
        label_17:
        val_16 = null;
        val_16 = null;
        val_15 = 1152921505039065108;
        goto label_24;
        label_16:
        val_17 = null;
        val_17 = null;
        val_15 = 1152921505039065104;
        label_24:
        val_13 = GetRewardByAmountChance(rewards:  val_15);
        label_18:
        object val_10 = new System.Object();
        typeof(SnakesAndLaddersEvent.BoardSpaceReward).__il2cppRuntimeField_8 = ;
        typeof(SnakesAndLaddersEvent.BoardSpaceReward).__il2cppRuntimeField_C = val_13;
    }
    public int GetDiceBalance()
    {
        if(this.eventProgress != 0)
        {
                return (int)this.eventProgress.DiceBalance;
        }
        
        return (int)this.eventProgress.DiceBalance;
    }
    public SnakesAndLaddersEvent.DiceRollResult GetDiceRollResult()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        int val_14;
        var val_15;
        object val_1 = new System.Object();
        object val_2 = new System.Object();
        if(val_1 != 0)
        {
                val_9 = val_1;
            typeof(SnakesAndLaddersEventHandler.<>c__DisplayClass44_0).__il2cppRuntimeField_8 = val_2;
        }
        else
        {
                val_9 = 8;
            mem[8] = val_2;
        }
        
        typeof(SnakesAndLaddersEvent.DiceRollResult).__il2cppRuntimeField_8 = UnityEngine.Random.Range(min:  1, max:  7);
        SnakesAndLaddersEvent.Board val_4 = this.GetCurrentBoard();
        typeof(SnakesAndLaddersEvent.DiceRollResult).__il2cppRuntimeField_C = this;
        if(val_1 != 0)
        {
                val_10 = mem[8];
            val_11 = val_10;
        }
        else
        {
                val_11 = mem[8];
            val_10 = mem[8];
        }
        
        typeof(SnakesAndLaddersEvent.DiceRollResult).__il2cppRuntimeField_10 = mem[1152921512163960300];
        if(val_1 != 0)
        {
                val_12 = mem[8];
            val_13 = val_12;
        }
        else
        {
                val_13 = mem[8];
            val_12 = mem[8];
        }
        
        typeof(SnakesAndLaddersEvent.DiceRollResult).__il2cppRuntimeField_14 = UnityEngine.Mathf.Min(a:  (val_3 + mem[1152921512163960300]), b:  mem[1152921512163960296] + 8);
        System.Predicate<ZooTile> val_7 = new System.Predicate<ZooTile>(object:  332480512, method:  new IntPtr(3262114848));
        object val_8 = mem[1152921512163960296] + 12.Find(match:  8040448);
        val_14 = mem[mem[1152921512163960296] + 12 + 12];
        val_14 = mem[1152921512163960296] + 12 + 12;
        if(val_14 == 1)
        {
                val_15 = mem[8];
            if(val_1 == 0)
        {
                val_15 = mem[8];
        }
        
            val_14 = typeof(SnakesAndLaddersEvent.DiceRollResult).__il2cppRuntimeField_14;
        }
        
        typeof(SnakesAndLaddersEvent.DiceRollResult).__il2cppRuntimeField_18 = val_14;
        mem[1152921512163960300] = typeof(SnakesAndLaddersEvent.DiceRollResult).__il2cppRuntimeField_18;
        if(val_1 != 0)
        {
                return;
        }
    
    }
    public System.Collections.Generic.List<SnakesAndLaddersEvent.Board> GetAllBoards()
    {
        if(this.eventProgress != 0)
        {
                return;
        }
    
    }
    public SnakesAndLaddersEvent.Board GetCurrentBoard()
    {
        var val_3;
        System.Predicate<SnakesAndLaddersEvent.Board> val_5;
        val_3 = null;
        val_3 = null;
        val_5 = SnakesAndLaddersEventHandler.<>c.<>9__46_0;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Predicate<ZooTile>(object:  SnakesAndLaddersEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3262374688));
            SnakesAndLaddersEventHandler.<>c.<>9__46_0 = val_5;
        }
        
        SnakesAndLaddersEvent.Board val_2 = this.eventProgress.Boards.Find(match:  8040448);
        if(this.eventProgress.Boards != 0)
        {
                return;
        }
        
        if(this.eventProgress.Boards != 0)
        {
                return;
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
    }
    public int GetCurrentBoardIndex()
    {
        System.Predicate<ZooTile> val_1 = new System.Predicate<ZooTile>(object:  -1032418720, method:  new IntPtr(3262522528));
        if(this.eventProgress.Boards != 0)
        {
                return this.eventProgress.Boards.FindIndex(match:  8040448);
        }
        
        return this.eventProgress.Boards.FindIndex(match:  8040448);
    }
    public PurchaseModel GetStarterDicePack()
    {
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageById(packageId:  -1032322528);
        PurchaseModel val_2 = new PurchaseModel(json:  -1032322528);
        string val_3 = getString(key:  -1403597104, defaultValue:  1098586544);
        twelvegigs.storage.JsonDictionary val_4 = PackagesManager.GetPackageById(packageId:  -1032322528);
        string val_6 = LocalPrice;
        typeof(PurchaseModel).__il2cppRuntimeField_58 = new PurchaseModel(json:  -1032322528);
        if("id_starter_dice_pack" != 0)
        {
                float val_7 = getFloat(key:  -1816221696, defaultValue:  null);
            typeof(PurchaseModel).__il2cppRuntimeField_5C = "id_starter_dice_pack";
        }
        else
        {
                typeof(PurchaseModel).__il2cppRuntimeField_5C = 0;
        }
        
        float val_9 = getFloat(key:  -1816221696, defaultValue:  0.getFloat(key:  -1816221696, defaultValue:  null));
        typeof(PurchaseModel).__il2cppRuntimeField_60 = "id_starter_dice_pack";
    }
    public bool IsOutOfDice()
    {
        int val_1 = this.eventProgress.DiceBalance;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void OnDiceRollUsed()
    {
        SnakesAndLaddersEvent.EventProgress val_1;
        int val_2;
        SnakesAndLaddersEvent.EventProgress val_3;
        int val_4;
        val_1 = this.eventProgress;
        if(val_1 != 0)
        {
                val_2 = this.eventProgress.DiceBalance;
        }
        else
        {
                val_1 = 8;
            val_2 = 0;
        }
        
        mem[8] = -1;
        val_3 = this.eventProgress;
        if(val_3 != 0)
        {
                val_4 = this.eventProgress.DiceRolled;
        }
        else
        {
                val_3 = 12;
            val_4 = 0;
        }
        
        mem[12] = 1;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public void RewardDiceRolls(int amount, string source)
    {
        string val_6;
        SnakesAndLaddersEvent.EventProgress val_7;
        val_6 = amount;
        val_7 = this.eventProgress;
        this.eventProgress.DiceBalance = UnityEngine.Mathf.Max(a:  0, b:  this.eventProgress.DiceBalance + val_6);
        if((System.String.IsNullOrEmpty(value:  source)) == true)
        {
                return;
        }
        
        val_7 = 0;
        Player val_4 = App.Player;
        string val_5 = amount.ToString();
        val_6;
        0.TrackNonCoinReward(source:  source, subSource:  null, rewardType:  -1875190224, rewardAmount:  amount, additionalParams:  val_7);
    }
    public void ResetBoardProgress()
    {
        this.eventProgress.ResetBoardProgress();
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public bool IsStarterPackActive()
    {
        if(this.eventProgress.StarterPackStatus.IsShown == false)
        {
                return (bool)0;
        }
        
        if(this.eventProgress.StarterPackStatus.IsPurchased == true)
        {
                return (bool)0;
        }
        
        0 = this.eventProgress.StarterPackStatus.IsOutOfTime() ^ 1;
        return (bool)0;
    }
    public System.TimeSpan GetStarterPackTimeLeft()
    {
        System.TimeSpan val_1 = this.GetTimeLeft();
        return new System.TimeSpan() {_ticks = val_1._ticks};
    }
    public void TryPurchase(PurchaseModel purchase)
    {
        bool val_1 = PurchaseProxy.Purchase(purchase:  purchase);
    }
    public void MarkStarterPackPurchased()
    {
        this.eventProgress.StarterPackStatus.IsPurchased = true;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public void ShowStarterDicePackPopup()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void AddPurchaseCompleteListener(System.Action<bool, PurchaseModel> purchaseCompleteAction)
    {
        System.Action<System.Boolean, PurchaseModel> val_2 = this.onPurchaseComplete;
        System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.onPurchaseComplete, b:  purchaseCompleteAction);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.onPurchaseComplete = val_2;
    }
    public void SaveState()
    {
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public bool IsEligibleToShowStarterPack()
    {
        if(this.eventProgress.StarterPackStatus.IsShown == true)
        {
                return false;
        }
        
        this.eventProgress.StarterPackStatus.IsShown = true;
        System.DateTime val_1 = DateTimeCheat.Now;
        this.eventProgress.StarterPackStatus.StartTime = new System.DateTime();
        if(this.eventProgress.StarterPackStatus.IsPurchased != false)
        {
                return false;
        }
        
        bool val_2 = this.eventProgress.StarterPackStatus.IsOutOfTime();
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    public void OnDiceRollEndingAnimationFinished()
    {
        this.DestroyDiceRoll();
        goto typeof(SnakesAndLaddersEventHandler).__il2cppRuntimeField_17C;
    }
    public void ShowBoardPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
    }
    public void ShowDicePacksPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
    }
    private void RefreshEventData(System.Collections.Generic.Dictionary<string, object> data)
    {
        int val_6;
        bool val_1 = System.String.op_Inequality(a:  mem[35644774], b:  -1266461808);
        if(val_1 != false)
        {
                string val_2 = -1322383584(-1322383584) + -1266461808(-1266461808);
            UnityEngine.Debug.LogError(message:  -1322383584);
            return;
        }
        
        val_1.ParseEcon(data:  data);
        val_6 = 1152921505039486976;
        this.eventProgress = new SnakesAndLaddersEvent.EventProgress();
        Initialize();
        if(this.IsEventNewCycle() != false)
        {
                this.eventProgress = new SnakesAndLaddersEvent.EventProgress();
            Initialize();
            val_6 = null;
            this.eventProgress.Timestamp = val_6;
        }
        
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    private void ParseEcon(System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_11;
        var val_12;
        if(data == 0)
        {
                return;
        }
        
        if((data.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_2 = data.Item[-1554533760];
        if((0.ContainsKey(key:  -1030108144)) != false)
        {
                string val_4 = 0.Item[-1030108144];
            val_11 = null;
            val_11 = null;
            bool val_6 = System.Int32.TryParse(s:  null, result: out  int val_5 = 432218112);
        }
        
        if((0.ContainsKey(key:  -1030108048)) == false)
        {
                return;
        }
        
        string val_8 = 0.Item[-1030108048];
        val_12 = null;
        val_12 = null;
        bool val_10 = System.Int32.TryParse(s:  null, result: out  int val_9 = 432218116);
    }
    private bool IsEventNewCycle()
    {
        var val_1 = R6 + 8;
        val_1 = this.eventProgress.Timestamp - val_1;
        if(R6 != 0)
        {
                val_1 = 1;
        }
        
        return true;
    }
    private bool IsReadyToCollectDiceRoll()
    {
        var val_3;
        SnakesAndLaddersEvent.MovingDiceRollProgress val_4;
        val_3 = 0;
        Player val_1 = App.Player;
        val_4 = 0;
        if(this.eventProgress.DiceRollProgress.LastLevel != val_4)
        {
                return (bool)val_3;
        }
        
        val_4 = this.eventProgress.DiceRollProgress;
        if(this.eventProgress.DiceRollProgress.LinewordIndex == 1)
        {
                return (bool)val_3;
        }
        
        val_3 = this.eventProgress.DiceRollProgress.IsCollected >> 5;
        return (bool)val_3;
    }
    private bool IsEligibleToSpawnNewDiceRoll()
    {
        var val_3;
        if(this.eventProgress.DiceRollProgress.LinewordIndex == 1)
        {
                return true;
        }
        
        Player val_1 = App.Player;
        val_3 = null;
        val_3 = null;
        if((0 - this.eventProgress.DiceRollProgress.LastLevel) >= SnakesAndLaddersEvent.Econ.DiceRollLevelInterval)
        {
                0 = 1;
        }
        
        return true;
    }
    private void ShowDiceRoll()
    {
        int val_12;
        var val_13;
        var val_14;
        if(this.eventProgress.DiceRollProgress.IsCollected == true)
        {
                return;
        }
        
        if(this.eventProgress.DiceRollProgress.IsMissed != false)
        {
                return;
        }
        
        val_12 = 1152921504892043264;
        Player val_1 = App.Player;
        if(0 == this.eventProgress.DiceRollProgress.LastLevel)
        {
                if(this.eventProgress.DiceRollProgress.LinewordIndex != 1)
        {
            goto label_15;
        }
        
        }
        
        if(this.IsEligibleToSpawnNewDiceRoll() == false)
        {
                return;
        }
        
        Player val_3 = App.Player;
        this.eventProgress.DiceRollProgress.LastLevel = 0;
        RandomSet val_4 = new RandomSet();
        WordRegion val_5 = WordRegion.instance;
        System.Collections.Generic.List<System.Int32> val_6 = 0.getAvailableLineIndices;
        val_13 = 4;
        goto label_25;
        label_37:
        WordRegion val_7 = WordRegion.instance;
        if(0 <= this.eventProgress.DiceRollProgress)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_13 = 0;
        val_13 = val_13 + 10485772;
        val_14 = mem[(0 + 10485772) + 16];
        val_14 = (0 + 10485772) + 16;
        if(((0 + 10485772) + 16 + 32) == 0)
        {
                if(0 <= this.eventProgress.DiceRollProgress)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_14 = 2621443;
            add(item:  2621443, weight:  null);
        }
        
        val_13 = 5;
        label_25:
        if((val_13 - 4) < 0)
        {
            goto label_37;
        }
        
        if(count() == 0)
        {
                return;
        }
        
        val_12 = 0;
        this.eventProgress.DiceRollProgress.LinewordIndex = roll(unweighted:  false);
        goto label_43;
        label_51:
        LineWord val_11 = this.CurrentDiceRollWord;
        if(this <= val_12)
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + 0;
        if(((0 + 0) + 16 + 36) == 0)
        {
            goto label_48;
        }
        
        val_12 = 1;
        label_43:
        LineWord val_12 = this.CurrentDiceRollWord;
        if(val_12 < this)
        {
            goto label_51;
        }
        
        goto label_52;
        label_48:
        this.eventProgress.DiceRollProgress.CellIndex = val_12;
        label_52:
        label_15:
        this.SpawnDiceRoll();
    }
    private void OnWordSubmitted(string word)
    {
        LineWord val_1 = this.CurrentDiceRollWord;
        if((word.Equals(value:  word)) != false)
        {
                this.CollectDiceRoll();
            return;
        }
        
        this.ShiftDiceRoll();
    }
    private void ShiftDiceRoll()
    {
        WordRegion val_1 = WordRegion.instance;
        if(1 != 0)
        {
                return;
        }
        
        var val_2 = (R4 + 16 + 32 + 12) + 5;
        label_13:
        LineWord val_3 = R4.CurrentDiceRollWord;
        var val_4 = val_2 - 4;
        if(val_4 >= (R4 + 20 + 12))
        {
            goto label_8;
        }
        
        LineWord val_5 = R4.CurrentDiceRollWord;
        if((R4 + 20 + 12) <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + 1;
        if((R4 + 20 + 8 + ((R4 + 16 + 32 + 12 + 5)) << 2 + 36) != 0)
        {
            goto label_13;
        }
        
        label_8:
        LineWord val_6 = R4.CurrentDiceRollWord;
        if(val_4 < (R4 + 20 + 12))
        {
                mem2[0] = val_4;
            R4.DestroyDiceRoll();
            R4.SpawnDiceRoll();
            return;
        }
        
        mem2[0] = 1;
        R4.DestroyDiceRoll();
    }
    private void DestroyDiceRoll()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.diceRoll)) == false)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  this.diceRoll);
    }
    private void CollectDiceRoll()
    {
        if(this.diceRoll == 0)
        {
                return;
        }
        
        WordRegion val_2 = WordRegion.instance;
        mem[20] = 1;
        this.eventProgress.DiceRollProgress.IsCollected = true;
        this.RewardDiceRolls(amount:  1, source:  -1825935024);
        object val_3 = this.diceRoll.GetComponent<System.Object>();
        mem2[0] = this.eventButtonGO;
        object val_4 = this.diceRoll.GetComponent<System.Object>();
        this.diceRoll.PlayEndingAnimation();
    }
    private void SpawnDiceRoll()
    {
        bool val_15 = static_value_021FE536;
        if(val_15 != true)
        {
                val_15 = true;
        }
        
        UnityEngine.GameObject val_1 = this.DiceRollPrefab;
        Cell val_2 = this.CurrentDiceRollCell;
        UnityEngine.Transform val_3 = this.transform;
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  1, parent:  -1028755440);
        this.diceRoll = val_15;
        UnityEngine.Transform val_5 = val_15.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_15.localPosition = new UnityEngine.Vector3();
        Cell val_7 = this.CurrentDiceRollCell;
        object val_8 = this.GetComponent<System.Object>();
        object val_9 = this.diceRoll.GetComponent<System.Object>();
        UnityEngine.Vector2 val_10 = sizeDelta;
        UnityEngine.Vector2 val_12 = sizeDelta;
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_12.x, y:  val_12.y);
        this.diceRoll.sizeDelta = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
    }
    private int GetRandomDiceRoll()
    {
        return UnityEngine.Random.Range(min:  1, max:  7);
    }
    private void OnPurchaseSuccess(PurchaseModel purchase)
    {
        this.onPurchaseComplete.Invoke(arg1:  true, arg2:  purchase);
    }
    private void OnPurchaseFail(PurchaseModel purchase)
    {
        this.onPurchaseComplete.Invoke(arg1:  false, arg2:  purchase);
    }
    private int GetRewardByAmountChance(System.Collections.Generic.List<GiftRewardAmountChance> rewards)
    {
        var val_4;
        var val_6;
        RandomSet val_1 = new RandomSet();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 != 0)
        {
                val_6 = mem[val_4 + 8];
            val_6 = val_4 + 8;
        }
        else
        {
                val_6 = 0;
        }
        
        add(item:  0, weight:  null);
        goto label_6;
        label_2:
        Dispose();
        return (int)roll(unweighted:  false);
    }
    public void Hack_ShowBoard(int boardIndex)
    {
        var val_1;
        var val_2;
        this.ResetBoardProgress();
        val_1 = 4;
        goto label_1;
        label_18:
        if((R6 + 24 + 12) <= 35644730)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = 0;
        if(35644730 < boardIndex)
        {
                if((R6 + 24 + 8) <= 35644730)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_2 = mem[406886408];
        }
        
        mem2[0] = val_2;
        if(0 <= 35644730)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = 5;
        if(35644730 < boardIndex)
        {
                0 = 1;
        }
        
        label_1:
        if((val_1 - 4) < 1)
        {
            goto label_18;
        }
        
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public SnakesAndLaddersEventHandler()
    {
    
    }
    private bool <GetCurrentBoardIndex>b__47_0(SnakesAndLaddersEvent.Board x)
    {
        var val_2 = this;
        SnakesAndLaddersEvent.Board val_1 = this.GetCurrentBoard();
        val_2 = x.Definition.MaxSpaceCount - val_2;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }

}
