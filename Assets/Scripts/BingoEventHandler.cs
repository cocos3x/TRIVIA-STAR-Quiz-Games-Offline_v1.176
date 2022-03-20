using UnityEngine;
public class BingoEventHandler : WGEventHandler
{
    // Fields
    public const string EVENT_ID = "WordBingo";
    public const string EVENT_TRACKING_ID = "Bingo";
    public const int CardSize = 5;
    public const int AvailableBalls = 75;
    public const int MAX_BALL_PER_LVL_ALLOWED = 4;
    private static BingoEventHandler <Instance>k__BackingField;
    public BingoEventHandler.BingoEcon econ;
    private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2Int>> <combinations>k__BackingField;
    private BingoEventProgression <progression>k__BackingField;
    private bool <HackGuaranteeNumber>k__BackingField;
    private UnityEngine.GameObject eventButtonGO;
    private UnityEngine.GameObject bingoBallPrefab;
    private GenericMovingObject currentBingoBall;
    private string lastValidWord;
    private int previousWordIndex;
    
    // Properties
    public static BingoEventHandler Instance { get; set; }
    public static bool IsPlaying { get; }
    public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2Int>> combinations { get; set; }
    public BingoEventProgression progression { get; set; }
    public bool HasMovingItem { get; }
    public bool HackGuaranteeNumber { get; set; }
    
    // Methods
    public static BingoEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(BingoEventHandler value)
    {
        BingoEventHandler.<Instance>k__BackingField = value;
    }
    public static bool get_IsPlaying()
    {
        if((BingoEventHandler.<Instance>k__BackingField) == 0)
        {
                return (bool)0;
        }
        
        if((BingoEventHandler.<Instance>k__BackingField.InExpireInterval()) == true)
        {
                return (bool)0;
        }
        
        0 = (BingoEventHandler.<Instance>k__BackingField) ^ 1;
        return (bool)0;
    }
    public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2Int>> get_combinations()
    {
    
    }
    private void set_combinations(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2Int>> value)
    {
        this.<combinations>k__BackingField = value;
    }
    public BingoEventProgression get_progression()
    {
    
    }
    private void set_progression(BingoEventProgression value)
    {
        this.<progression>k__BackingField = value;
    }
    public bool get_HasMovingItem()
    {
        return UnityEngine.Object.op_Inequality(x:  this.currentBingoBall, y:  0);
    }
    public bool get_HackGuaranteeNumber()
    {
        return (bool)this.<HackGuaranteeNumber>k__BackingField;
    }
    public void set_HackGuaranteeNumber(bool value)
    {
        this.<HackGuaranteeNumber>k__BackingField = value;
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921511661475512] = eventV2;
        UnityEngine.GameObject val_1 = PrefabLoader.LoadPrefab(featureName:  -1535358816, prefabName:  -1535358928);
        this.bingoBallPrefab = "Events";
        BingoEventHandler.<Instance>k__BackingField = this;
        this.ParseEventData(eventData:  eventV2.eventData);
        System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2Int>> val_2 = this.GetBingoCombinations();
        this.<combinations>k__BackingField = this;
        typeof(BingoEventProgression).__il2cppRuntimeField_10 = 0;
        typeof(BingoEventProgression).__il2cppRuntimeField_14 = 0;
        EventProgression val_3 = new EventProgression();
        this.<progression>k__BackingField = null;
        if(eventV2.id == (this.<progression>k__BackingField.currentEventId))
        {
                return;
        }
        
        this.<progression>k__BackingField.currentEventId = eventV2.id;
        System.Int32[,] val_4 = this.<progression>k__BackingField.currentEventId.GenerateCard();
        this.<progression>k__BackingField.currentCard = this.<progression>k__BackingField.currentEventId;
        System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>();
        this.<progression>k__BackingField.balls = null;
        this.<progression>k__BackingField.bingoCalls = 0;
        if((this.<progression>k__BackingField) == 0)
        {
            
        }
    
    }
    public override void OnWordRegionLoaded()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        if(this.InExpireInterval() == true)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        object val_5 = UnityEngine.Object.FindObjectOfType<System.Object>();
        if((-1535185296) == 0)
        {
                return;
        }
        
        object val_7 = UnityEngine.Object.FindObjectOfType<System.Object>();
        UnityEngine.GameObject val_8 = public static WGEventButton_Game UnityEngine.Object::FindObjectOfType<WGEventButton_Game>().__il2cppRuntimeField_14.gameObject;
        this.eventButtonGO = public static WGEventButton_Game UnityEngine.Object::FindObjectOfType<WGEventButton_Game>().__il2cppRuntimeField_14;
        this.lastValidWord = 0;
        this.previousWordIndex = 0;
        this.TryPlaceBall();
    }
    public override void OnValidWordSubmitted(string word)
    {
        var val_5;
        BingoEventProgression val_6;
        val_5 = 35633985;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        if(this.HasMovingItem == false)
        {
                return;
        }
        
        this.lastValidWord = word;
        WordRegion val_3 = WordRegion.instance;
        val_6 = this.<progression>k__BackingField;
        val_5 = 0;
        if((this.<progression>k__BackingField.keyWordIndex) < 0)
        {
                return;
        }
        
        val_6 = this.<progression>k__BackingField.keyWordIndex;
        if(val_6 >= 0)
        {
                return;
        }
        
        if(0 <= (this.<progression>k__BackingField.keyWordIndex))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0;
        val_5 = val_5 + ((this.<progression>k__BackingField.keyWordIndex) << 2);
        if(((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 12.Equals(value:  word)) != false)
        {
                this.CollectBall();
            return;
        }
        
        this.MoveOrRemoveKey();
    }
    public override void OnPreprocessPlayerTurn(bool hintUsage, string wordEntered, LineWord lineWord, Cell cell)
    {
        var val_6;
        BingoEventProgression val_7;
        val_6 = 35633986;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        if(this.HasMovingItem == false)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        val_7 = this.<progression>k__BackingField;
        if((this.<progression>k__BackingField.keyWordIndex) < 0)
        {
                return;
        }
        
        val_7 = this.<progression>k__BackingField.keyWordIndex;
        val_6 = 0;
        if(val_7 >= 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  wordEntered)) == true)
        {
                return;
        }
        
        val_7 = this.<progression>k__BackingField.keyWordIndex;
        if(0 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = 0;
        val_6 = val_6 + (val_7 << 2);
        bool val_5 = (0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 12.Equals(value:  wordEntered);
        if(val_5 == true)
        {
                val_5 = 1;
            mem[20] = val_5;
        }
    
    }
    public override void OnHintIncompleteWord(string word, Cell hintedCell)
    {
        int val_6;
        UnityEngine.Object val_7;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        if(this.HasMovingItem == false)
        {
                return;
        }
        
        this.lastValidWord = word;
        WordRegion val_3 = WordRegion.instance;
        val_6 = 0;
        if((this.<progression>k__BackingField.keyWordIndex) < 0)
        {
                return;
        }
        
        val_7 = 0;
        if((this.<progression>k__BackingField.keyWordIndex) >= 0)
        {
                return;
        }
        
        if(0 <= (this.<progression>k__BackingField.keyWordIndex))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = 0;
        val_6 = val_6 + ((this.<progression>k__BackingField.keyWordIndex) << 2);
        val_6 = mem[(0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16];
        val_6 = (0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16;
        if((System.String.op_Inequality(a:  word, b:  (0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 12)) == true)
        {
                return;
        }
        
        val_6 = this.<progression>k__BackingField.cellIndex;
        if(((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 12) <= val_6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = (0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8;
        val_7 = val_7 + (val_6 << 2);
        val_7 = mem[((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8 + (this.<progression>k__BackingField.cellIndex) << 2) + 16];
        val_7 = ((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8 + (this.<progression>k__BackingField.cellIndex) << 2) + 16;
        if(hintedCell != val_7)
        {
                return;
        }
        
        this.MoveOrRemoveKey();
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        BingoEventProgression val_5;
        if(this != 0)
        {
                return;
        }
        
        this.<progression>k__BackingField.keyWordIndex = 0;
        val_5 = this.<progression>k__BackingField;
        this.<progression>k__BackingField.cellIndex = 0;
        if((this.<progression>k__BackingField.ballsCount) <= 0)
        {
                if((this.<progression>k__BackingField.ballsCount) < 75)
        {
            goto label_8;
        }
        
        }
        
        System.Collections.Generic.List<System.Int32> val_1 = this.GetCollectedBalls(n:  this.<progression>k__BackingField.ballsCount);
        this.<progression>k__BackingField.balls.AddRange(collection:  -1534539216);
        this.<progression>k__BackingField.ballsCount = 0;
        System.Collections.Generic.List<System.Int32> val_2 = this.BingoCombinationCompleted();
        val_5 = this;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        LoadCollectedBalls(balls:  -1534539216, bingoCombination:  -1534539216);
        label_8:
        if((this.<progression>k__BackingField) == 0)
        {
            
        }
    
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        currentData.Add(key:  -1534402144, value:  13152256);
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
    public override bool EventCompleted()
    {
        ulong val_3;
        var val_6;
        BingoEcon val_7;
        if(this.econ.purchasersOnly != false)
        {
                Player val_1 = App.Player;
            val_6 = 1;
            if(0 <= 0)
        {
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = this.eventButtonGO});
        }
        
        }
        
        val_7 = this.econ;
        if(this.econ.maxBingoCalls != 0)
        {
                val_7 = this.<progression>k__BackingField.bingoCalls;
            val_6 = 1;
            if(val_7 >= this.econ.maxBingoCalls)
        {
                return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = this.eventButtonGO});
        }
        
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_3}, t2:  new System.DateTime() {dateData = this.eventButtonGO});
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1533904880, defaultValue:  -1533904960, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1533904880, defaultValue:  -1533904960, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        ulong val_4;
        var val_7;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_6 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511663112832}, d2:  new System.DateTime() {dateData = val_4});
        double val_10 = System.Math.Truncate(d:  val_7.TotalHours);
        int val_11 = val_7.Minutes;
        string val_12 = System.String.Format(format:  -1533680784, arg0:  10489856, arg1:  13152256);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        GameEcon val_3 = App.getGameEcon;
        string val_4 = this.GetCurrentReward().ToString(format:  null);
        if(loader.disableByDefault == true)
        {
                return;
        }
    
    }
    public override void OnEventEnded()
    {
        BingoEventHandler.<Instance>k__BackingField = 0;
        if((this.<progression>k__BackingField) == 0)
        {
            
        }
    
    }
    public override int GetMovingWordIndex()
    {
        if((this.<progression>k__BackingField) != 0)
        {
                return (int)this.<progression>k__BackingField.keyWordIndex;
        }
        
        return (int)this.<progression>k__BackingField.keyWordIndex;
    }
    public bool InExpireInterval()
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
            bool val_6 = System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = this.eventButtonGO});
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
        
        val_14 = System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = this.currentBingoBall});
        return (bool)val_14;
        label_2:
    }
    public System.Collections.Generic.List<int> BingoCombinationCompleted()
    {
        int val_5;
        var val_11;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        System.Collections.Generic.HashSet<System.Int32> val_2 = new System.Collections.Generic.HashSet<System.Int32>();
        List.Enumerator<T> val_3 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        bool val_6 = Add(item:  val_5);
        goto label_5;
        label_3:
        Dispose();
        List.Enumerator<T> val_7 = GetEnumerator();
        val_16 = 0;
        label_22:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        Clear();
        List.Enumerator<T> val_10 = GetEnumerator();
        var val_17 = 1;
        label_18:
        if(val_11.MoveNext() == false)
        {
            goto label_10;
        }
        
        int val_14 = ???.y;
        val_17 = mem[mem[1152921511663734056] + 28 + 8];
        val_17 = mem[1152921511663734056] + 28 + 8;
        if(val_17 <= (???.x))
        {
                val_17 = mem[mem[1152921511663734056] + 28 + 8];
            val_17 = mem[1152921511663734056] + 28 + 8;
        }
        
        val_17 = (mem[1152921511663734056] + 28) + (val_17 << 2);
        int val_16 = (mem[1152921511663734056] + 28 + (mem[1152921511663734056] + 28 + 8) << 2) + 16;
        bool val_15 = Contains(item:  val_16);
        val_16 = val_16 >> 5;
        val_15 = val_16 | val_15;
        val_17 = val_17 & val_15;
        if(((mem[1152921511663734056] + 28 + (mem[1152921511663734056] + 28 + 8) << 2) + 16) == 0)
        {
            goto label_18;
        }
        
        Add(item:  (mem[1152921511663734056] + 28 + (mem[1152921511663734056] + 28 + 8) << 2) + 16);
        goto label_18;
        label_10:
        var val_18 = val_16;
        val_18 = val_18 + 1;
        mem2[0] = 216;
        val_11.Dispose();
        if(val_18 != 1)
        {
                if(val_18 > 1)
        {
                0 = 1;
        }
        
            var val_19 = -1533059704 + ((val_16 + 1)) << 2;
            val_19 = val_19 - 216;
            val_19 = val_19 >> 5;
            val_19 = 1 & val_19;
            val_16 = val_18 - val_19;
        }
        else
        {
                val_16 = 0;
        }
        
        if((val_17 & 1) != 0)
        {
            goto label_22;
        }
        
        goto label_23;
        label_7:
        val_18 = 253;
        goto label_33;
        label_23:
        val_18 = 255;
        label_33:
        val_16 = val_16 + 1;
        mem2[0] = val_18;
        Dispose();
        if(val_16 != 1)
        {
                if((-1533059704 + ((val_16 + 1)) << 2) != 255)
        {
                val_19 = 0;
        }
        
            return;
        }
        
        val_19 = 0;
    }
    public int GetRewardPerBalls(int n)
    {
        if(this.econ != 0)
        {
                return (int)this.econ.prizePerBall;
        }
        
        this.econ = this.econ;
        if(this.econ != 0)
        {
                return (int)this.econ.prizePerBall;
        }
    
    }
    public int GetCurrentReward()
    {
        if((this.<progression>k__BackingField.balls) != 0)
        {
                return this.GetRewardPerBalls(n:  0);
        }
        
        return this.GetRewardPerBalls(n:  0);
    }
    public void CollectRewardAndNewCard()
    {
        BingoEventProgression val_5;
        int val_6;
        int val_1 = this.GetCurrentReward();
        decimal val_2 = System.Decimal.op_Implicit(value:  -1532670232);
        CurrencyController.CreditBalance(value:  new System.Decimal(), source:  "Bingo Event", externalParams:  0, animated:  false);
        System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
        this.<progression>k__BackingField.balls = null;
        this.<progression>k__BackingField.ballsCount = 0;
        System.Int32[,] val_4 = this.GenerateCard();
        this.<progression>k__BackingField.currentCard = 0;
        val_5 = this.<progression>k__BackingField;
        if(val_5 != 0)
        {
                val_6 = this.<progression>k__BackingField.bingoCalls;
        }
        else
        {
                val_5 = 36;
            val_6 = 83886592;
        }
        
        mem[36] = 83886593;
        if((this.<progression>k__BackingField) != 0)
        {
                return;
        }
    
    }
    public override bool ShouldShowInDailyChallenge(bool dailyChallengeState)
    {
        if(CategoryPacksManager.IsPlaying == false)
        {
                return this.ShouldShowInDailyChallenge(dailyChallengeState:  dailyChallengeState);
        }
        
        return false;
    }
    public override int LastProgressTimestamp()
    {
        if((this.<progression>k__BackingField) != 0)
        {
                return (int)this.<progression>k__BackingField.lastProgressTimestamp;
        }
        
        return (int)this.<progression>k__BackingField.lastProgressTimestamp;
    }
    public override void UpdateProgress()
    {
        this.<progression>k__BackingField.lastProgressTimestamp = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public void HACKGrantBingo()
    {
        var val_13;
        var val_14;
        if(this != 0)
        {
                return;
        }
        
        if((this.<combinations>k__BackingField) != 0)
        {
                val_13 = this.<combinations>k__BackingField;
            val_14 = UnityEngine.Random.Range(min:  0, max:  typeof(BingoEventHandler).__il2cppRuntimeField_2A0);
        }
        else
        {
                val_13 = 12;
            var val_13 = 0;
            val_14 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        if(val_13 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + (val_14 << 2);
        System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
        List.Enumerator<T> val_4 = GetEnumerator();
        label_15:
        if(0.MoveNext() == false)
        {
            goto label_6;
        }
        
        int val_7 = 0.x;
        int val_14 = this.<progression>k__BackingField.currentCard[0.y];
        int val_15 = val_14;
        bool val_9 = this.<progression>k__BackingField.balls.Contains(item:  val_15);
        val_15 = val_15 >> 5;
        if((this.<progression>k__BackingField.balls) != 0)
        {
            goto label_15;
        }
        
        Add(item:  val_14);
        goto label_15;
        label_6:
        0.Dispose();
        this.<progression>k__BackingField.balls.AddRange(collection:  80883712);
        RemoveRange(index:  0, count:  1094062060);
        System.Collections.Generic.List<System.Int32> val_10 = this.BingoCombinationCompleted();
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_12 = ShowUGUIMonolith<System.Object>(showNext:  false);
        LoadCollectedBalls(balls:  80883712, bingoCombination:  -1532115984);
    }
    public void HACKGrantAllBalls()
    {
        if(this != 0)
        {
                return;
        }
        
        System.Collections.Generic.List<System.Int32> val_1 = this.GetCollectedBalls(n:  75);
        this.<progression>k__BackingField.balls.AddRange(collection:  -1531934352);
        this.<progression>k__BackingField.ballsCount = 0;
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        int val_25;
        if(eventData == 0)
        {
                return;
        }
        
        if(eventData.Count == 0)
        {
                return;
        }
        
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_3 = eventData.Item[-1554533760];
        if((0.ContainsKey(key:  -1531829968)) != false)
        {
                string val_5 = 0.Item[-1531829968];
            val_25 = 0;
            bool val_7 = System.Int32.TryParse(s:  null, result: out  this.econ.basePrize);
        }
        
        if((0.ContainsKey(key:  -1531825792)) != false)
        {
                string val_9 = 0.Item[-1531825792];
            val_25 = 0;
            bool val_11 = System.Int32.TryParse(s:  null, result: out  this.econ.maxBingoCalls);
        }
        
        if((0.ContainsKey(key:  -1531821616)) != false)
        {
                string val_13 = 0.Item[-1531821616];
            val_25 = 0;
            bool val_15 = System.Int32.TryParse(s:  null, result: out  this.econ.ballLevelIntervall);
        }
        
        if((0.ContainsKey(key:  -1531817440)) != false)
        {
                string val_17 = 0.Item[-1531817440];
            bool val_19 = System.Int32.TryParse(s:  null, result: out  this.econ.maxBallsPerLevel);
            val_25 = this.econ.maxBallsPerLevel;
            this.econ.maxBallsPerLevel = UnityEngine.Mathf.Min(a:  val_25, b:  4);
        }
        
        if((0.ContainsKey(key:  -1531809152)) == false)
        {
                return;
        }
        
        string val_22 = 0.Item[-1531809152];
        bool val_24 = System.Boolean.TryParse(value:  null, result: out  this.econ.purchasersOnly);
    }
    private System.Collections.Generic.List<int> GetCollectedBalls(int n)
    {
        var val_7;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        do
        {
            Add(item:  1);
            val_7 = 1 + 1;
        }
        while(val_7 != 76);
        
        System.Collections.Generic.IEnumerable<TSource> val_2 = System.Linq.Enumerable.Except<System.Int32>(first:  80883712, second:  this.<progression>k__BackingField.balls);
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Int32>(source:  80883712);
        PluginExtension.Shuffle<System.Int32>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        if((this.<HackGuaranteeNumber>k__BackingField) == false)
        {
                return GetRange(index:  0, count:  UnityEngine.Mathf.Min(a:  n, b:  1094062064));
        }
        
        CompanyDevices val_4 = CompanyDevices.Instance;
        val_7 = 0;
        if(val_7.CompanyDevice() == false)
        {
                return GetRange(index:  0, count:  UnityEngine.Mathf.Min(a:  n, b:  1094062064));
        }
        
        return this.GuaranteeNumber(remainBalls:  80883712, n:  n);
    }
    private System.Collections.Generic.List<int> GuaranteeNumber(System.Collections.Generic.List<int> remainBalls, int n)
    {
        var val_9 = 0;
        do
        {
            var val_8 = 0;
            do
        {
            Add(item:  this.<progression>k__BackingField.currentCard[new System.Collections.Generic.List<System.Int32>()]);
            val_8 = val_8 + 1;
        }
        while(val_8 != 5);
        
            val_9 = val_9 + 1;
        }
        while(val_9 != 5);
        
        System.Collections.Generic.IEnumerable<TSource> val_2 = System.Linq.Enumerable.Except<System.Int32>(first:  80883712, second:  this.<progression>k__BackingField.balls);
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Int32>(source:  80883712);
        System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Except<System.Int32>(first:  remainBalls, second:  80883712);
        System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<System.Int32>(source:  remainBalls);
        PluginExtension.Shuffle<System.Int32>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        if(null != 0)
        {
                AddRange(collection:  remainBalls);
            return GetRange(index:  0, count:  UnityEngine.Mathf.Min(a:  n, b:  1094062064));
        }
        
        0.AddRange(collection:  remainBalls);
        return GetRange(index:  0, count:  UnityEngine.Mathf.Min(a:  n, b:  1094062064));
    }
    private void TryPlaceBall()
    {
        BingoEcon val_21;
        int val_22;
        var val_23;
        BingoEventProgression val_25;
        var val_26;
        var val_27;
        object val_1 = new System.Object();
        typeof(BingoEventHandler.<>c__DisplayClass61_0).__il2cppRuntimeField_C = this;
        val_21 = this.econ;
        val_22 = this.<progression>k__BackingField.ballsCount;
        if(val_22 >= this.econ.maxBallsPerLevel)
        {
                return;
        }
        
        val_21 = this.<progression>k__BackingField;
        int val_21 = this.<progression>k__BackingField.ballsCount;
        val_21 = val_21 + (this.<progression>k__BackingField.balls);
        if(val_21 > 74)
        {
                return;
        }
        
        val_23 = 1152921504892043264;
        Player val_2 = App.Player;
        val_21 = this.econ;
        val_22 = 0;
        if(this.econ.ballLevelIntervall > 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        typeof(BingoEventHandler.<>c__DisplayClass61_0).__il2cppRuntimeField_8 = 0;
        if((((this.<progression>k__BackingField.keyWordIndex) == 1) || ((this.<progression>k__BackingField.cellIndex) == 1)) || ((this.<progression>k__BackingField.keyWordIndex) >= 0))
        {
            goto label_35;
        }
        
        if(0 <= (this.<progression>k__BackingField.keyWordIndex))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_22 = 0;
        val_22 = val_22 + ((this.<progression>k__BackingField.keyWordIndex) << 2);
        if(((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 32) != 0)
        {
            goto label_35;
        }
        
        val_25 = this.<progression>k__BackingField;
        if((this.<progression>k__BackingField) != 0)
        {
            goto label_29;
        }
        
        val_25 = this.<progression>k__BackingField;
        if(val_25 == 0)
        {
            goto label_30;
        }
        
        label_29:
        if(0 <= (this.<progression>k__BackingField.keyWordIndex))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_23 = 0;
        val_23 = val_23 + ((this.<progression>k__BackingField.keyWordIndex) << 2);
        if((this.<progression>k__BackingField.cellIndex) < ((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 12))
        {
                if(0 <= (this.<progression>k__BackingField.keyWordIndex))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_24 = 0;
            val_24 = val_24 + ((this.<progression>k__BackingField.keyWordIndex) << 2);
            if(((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 12) <= (this.<progression>k__BackingField.cellIndex))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_25 = (0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8;
            val_25 = val_25 + ((this.<progression>k__BackingField.cellIndex) << 2);
            UnityEngine.Transform val_4 = ((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8 + (this.<progression>k__BackingField.cellIndex) << 2) + 16.transform;
            object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.bingoBallPrefab, parent:  ((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8 + (this.<progression>k__BackingField.cellIndex) << 2) + 16);
            object val_6 = this.bingoBallPrefab.GetComponent<System.Object>();
            this.currentBingoBall = this.bingoBallPrefab;
            mem2[0] = this.eventButtonGO;
            return;
        }
        
        label_35:
        WordRegion val_7 = WordRegion.instance;
        System.Collections.Generic.List<System.Int32> val_8 = 0.getAvailableLineIndices;
        System.Predicate<System.Int32> val_9 = new System.Predicate<System.Int32>(object:  309211136, method:  new IntPtr(2763718480));
        System.Collections.Generic.List<T> val_10 = 0.FindAll(match:  8040448);
        System.Collections.Generic.List<TSource> val_11 = System.Linq.Enumerable.ToList<System.Int32>(source:  0);
        if(0 == 0)
        {
                return;
        }
        
        int val_12 = UnityEngine.Random.Range(min:  0, max:  0);
        if(0 <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_26 = 0;
        val_26 = val_26 + (val_12 << 2);
        this.<progression>k__BackingField.keyWordIndex = (0 + (val_12) << 2) + 16;
        if(0 <= (this.<progression>k__BackingField.keyWordIndex))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_27 = 0;
        val_27 = val_27 + ((this.<progression>k__BackingField.keyWordIndex) << 2);
        typeof(BingoEventHandler.<>c__DisplayClass61_0).__il2cppRuntimeField_10 = 0;
        var val_28 = 25321063;
        val_28 = 10304724 + val_28;
        if(val_28 == 0)
        {
                mem2[0] = 1;
        }
        
        val_26 = null;
        val_26 = null;
        if((App.game == 4) && (this.lastValidWord != null))
        {
                WordRegion val_13 = WordRegion.instance;
            val_27 = 0;
            System.Predicate<ZooTile> val_14 = new System.Predicate<ZooTile>(object:  309211136, method:  new IntPtr(2763733840));
            object val_15 = val_27.Find(match:  8040448);
            typeof(BingoEventHandler.<>c__DisplayClass61_0).__il2cppRuntimeField_10 = val_27;
        }
        
        System.Predicate<ZooTile> val_16 = new System.Predicate<ZooTile>(object:  309211136, method:  new IntPtr(2763738960));
        this.<progression>k__BackingField.cellIndex = (0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20.FindIndex(startIndex:  0, match:  8040448);
        if((this.<progression>k__BackingField.cellIndex) == 1)
        {
                return;
        }
        
        if(((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 12) <= (this.<progression>k__BackingField.cellIndex))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_29 = (0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8;
        val_29 = val_29 + ((this.<progression>k__BackingField.cellIndex) << 2);
        UnityEngine.Transform val_18 = ((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8 + (this.<progression>k__BackingField.cellIndex) << 2) + 16.transform;
        object val_19 = UnityEngine.Object.Instantiate<System.Object>(original:  this.bingoBallPrefab, parent:  ((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8 + (this.<progression>k__BackingField.cellIndex) << 2) + 16);
        object val_20 = this.bingoBallPrefab.GetComponent<System.Object>();
        this.currentBingoBall = this.bingoBallPrefab;
        mem2[0] = this.eventButtonGO;
        if((this.<progression>k__BackingField) != 0)
        {
            goto typeof(BingoEventProgression).__il2cppRuntimeField_E4;
        }
        
        goto typeof(BingoEventProgression).__il2cppRuntimeField_E4;
        label_30:
    }
    private void MoveOrRemoveKey()
    {
        int val_12;
        var val_13;
        var val_14;
        BingoEventProgression val_15;
        object val_1 = new System.Object();
        typeof(BingoEventHandler.<>c__DisplayClass62_0).__il2cppRuntimeField_8 = this;
        WordRegion val_2 = WordRegion.instance;
        if(1 != 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        if(0 <= (this.<progression>k__BackingField.keyWordIndex))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_12 = 0;
        val_12 = val_12 + ((this.<progression>k__BackingField.keyWordIndex) << 2);
        typeof(BingoEventHandler.<>c__DisplayClass62_0).__il2cppRuntimeField_C = 0;
        val_12 = 10306532 + 25319255;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        if(App.game == 4)
        {
                WordRegion val_4 = WordRegion.instance;
            val_12 = 0;
            System.Predicate<ZooTile> val_5 = new System.Predicate<ZooTile>(object:  309264384, method:  new IntPtr(2763979984));
            val_14 = public LineWord System.Collections.Generic.List<LineWord>::Find(System.Predicate<T> match);
            object val_6 = val_12.Find(match:  8040448);
            typeof(BingoEventHandler.<>c__DisplayClass62_0).__il2cppRuntimeField_C = val_12;
        }
        
        if(((this.<progression>k__BackingField.cellIndex) + 1) < ((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 12))
        {
                val_12 = this.<progression>k__BackingField.cellIndex;
            System.Predicate<ZooTile> val_8 = new System.Predicate<ZooTile>(object:  309264384, method:  new IntPtr(2763989200));
            val_14 = null;
            int val_10 = (0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20.FindIndex(startIndex:  val_12 + 1, match:  8040448);
            if(val_10 >= 0)
        {
                if(((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 12) <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_13 = (0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8;
            val_13 = val_13 + (val_10 << 2);
            if(this.currentBingoBall == 0)
        {
                return;
        }
        
            this.currentBingoBall.ShiftToCell(newParent:  ((0 + (this.<progression>k__BackingField.keyWordIndex) << 2) + 16 + 20 + 8 + (val_10) << 2) + 16);
            this.<progression>k__BackingField.cellIndex = val_10;
            return;
        }
        
        }
        
        this.currentBingoBall.Remove();
        if((this.<progression>k__BackingField) == 0)
        {
            goto label_37;
        }
        
        this.previousWordIndex = this.<progression>k__BackingField.keyWordIndex;
        val_15 = this.<progression>k__BackingField;
        goto label_38;
        label_37:
        val_15 = this.<progression>k__BackingField;
        this.previousWordIndex = this.<progression>k__BackingField.keyWordIndex;
        if(val_15 == 0)
        {
            goto label_39;
        }
        
        label_38:
        this.<progression>k__BackingField.keyWordIndex = 0;
        this.<progression>k__BackingField.cellIndex = 0;
        this.TryPlaceBall();
        return;
        label_39:
    }
    private void CollectBall()
    {
        BingoEventProgression val_1;
        int val_2;
        this.currentBingoBall.Collect();
        this.previousWordIndex = 0;
        this.<progression>k__BackingField.keyWordIndex = 0;
        this.<progression>k__BackingField.cellIndex = 0;
        val_1 = this.<progression>k__BackingField;
        if(val_1 != 0)
        {
                val_2 = this.<progression>k__BackingField.ballsCount;
        }
        else
        {
                val_1 = 12;
            val_2 = 0;
        }
        
        mem[12] = 1;
        this.TryPlaceBall();
    }
    private int[,] GenerateCard()
    {
        var val_8 = 0;
        do
        {
            RandomSet val_1 = new RandomSet();
            var val_5 = 1;
            do
        {
            add(item:  1, weight:  null);
            val_5 = val_5 + 1;
        }
        while(val_5 != 16);
        
            var val_7 = 0;
            do
        {
            int val_6 = roll(unweighted:  false);
            val_6 = val_6 + (0 - val_8);
            val_7 = val_7 + 1;
            mem2[0] = val_6;
        }
        while(val_7 != 5);
        
            val_8 = val_8 + 1;
        }
        while(val_8 != 5);
        
        mem2[0] = 0;
    }
    private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2Int>> GetBingoCombinations()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        var val_16 = 0;
        do
        {
            System.Collections.Generic.List<UnityEngine.Vector2Int> val_2 = new System.Collections.Generic.List<UnityEngine.Vector2Int>();
            var val_15 = 0;
            do
        {
            UnityEngine.Vector2Int val_3 = new UnityEngine.Vector2Int(x:  0, y:  0);
            Add(item:  new UnityEngine.Vector2Int() {m_X = val_3.m_X, m_Y = val_3.m_Y});
            val_15 = val_15 + 1;
        }
        while(val_15 != 5);
        
            Add(item:  80883712);
            val_16 = val_16 + 1;
        }
        while(val_16 != 5);
        
        System.Collections.Generic.List<UnityEngine.Vector2Int> val_4 = new System.Collections.Generic.List<UnityEngine.Vector2Int>();
        var val_18 = 0;
        do
        {
            var val_17 = 0;
            do
        {
            UnityEngine.Vector2Int val_5 = new UnityEngine.Vector2Int(x:  0, y:  0);
            Add(item:  new UnityEngine.Vector2Int() {m_X = val_5.m_X, m_Y = val_5.m_Y});
            val_17 = val_17 + 1;
        }
        while(val_17 != 5);
        
            Add(item:  80883712);
            System.Collections.Generic.List<UnityEngine.Vector2Int> val_6 = new System.Collections.Generic.List<UnityEngine.Vector2Int>();
            val_18 = val_18 + 1;
        }
        while(val_18 != 5);
        
        var val_19 = 0;
        do
        {
            UnityEngine.Vector2Int val_7 = new UnityEngine.Vector2Int(x:  0, y:  0);
            Add(item:  new UnityEngine.Vector2Int() {m_X = val_7.m_X, m_Y = val_7.m_Y});
            val_19 = val_19 + 1;
        }
        while(val_19 != 5);
        
        Add(item:  80883712);
        System.Collections.Generic.List<UnityEngine.Vector2Int> val_8 = new System.Collections.Generic.List<UnityEngine.Vector2Int>();
        var val_21 = 4;
        var val_20 = 0;
        do
        {
            UnityEngine.Vector2Int val_9 = new UnityEngine.Vector2Int(x:  0, y:  4);
            Add(item:  new UnityEngine.Vector2Int() {m_X = val_9.m_X, m_Y = val_9.m_Y});
            val_20 = val_20 + 1;
            val_21 = val_21 - 1;
        }
        while(val_20 != 5);
        
        Add(item:  80883712);
        System.Collections.Generic.List<UnityEngine.Vector2Int> val_10 = new System.Collections.Generic.List<UnityEngine.Vector2Int>();
        UnityEngine.Vector2Int val_11 = new UnityEngine.Vector2Int(x:  0, y:  0);
        Add(item:  new UnityEngine.Vector2Int() {m_X = val_11.m_X, m_Y = val_11.m_Y});
        UnityEngine.Vector2Int val_12 = new UnityEngine.Vector2Int(x:  4, y:  4);
        Add(item:  new UnityEngine.Vector2Int() {m_X = val_12.m_X, m_Y = val_12.m_Y});
        UnityEngine.Vector2Int val_13 = new UnityEngine.Vector2Int(x:  4, y:  0);
        Add(item:  new UnityEngine.Vector2Int() {m_X = val_13.m_X, m_Y = val_13.m_Y});
        UnityEngine.Vector2Int val_14 = new UnityEngine.Vector2Int(x:  0, y:  4);
        Add(item:  new UnityEngine.Vector2Int() {m_X = val_14.m_X, m_Y = val_14.m_Y});
        Add(item:  80883712);
    }
    public BingoEventHandler()
    {
        typeof(BingoEventHandler.BingoEcon).__il2cppRuntimeField_18 = 5;
        typeof(BingoEventHandler.BingoEcon).__il2cppRuntimeField_1C = 1;
        null = new System.Object();
        this.previousWordIndex = 0;
        this.econ = null;
    }

}
