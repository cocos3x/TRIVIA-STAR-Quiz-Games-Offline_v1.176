using UnityEngine;
public class WordGameEventsController : MonoSingleton<WordGameEventsController>
{
    // Fields
    public const string NOTIFICATION_GAME_EVENT_CONTROLLER_UPDATE = "OnGameEventControllerUpdate";
    public const string NOTIFICATION_GAME_EVENT_HANDLER_PROGRESS = "OnGameEventHandlerProgress";
    private const string NOTIFICATION_PROFILE_UPDATE = "OnMyProfileUpdate";
    public bool isWordRegionLoaded;
    protected EventPrefabsConfig eventPrefabsConfig;
    private static readonly System.Collections.Generic.Dictionary<string, System.Type> DefaultTypeLookup;
    private static System.Collections.Generic.Dictionary<string, System.Type> compiledTypeLookup;
    private System.Collections.Generic.List<WGEventHandler> _currentEventHandlers;
    public WordGameEventsController.ProxyEventHandlerDelegate AddProxyEventHandlers;
    public WordGameEventsController.ProxyEventHandlerDelegate RemoveExpiredProxyEventHandlers;
    public static WordGameEventsController.ProxyEventTrackingDelegate AddTrackingEventData;
    private int QAHACK_SingleEventKeyIndex;
    
    // Properties
    public static bool EventsEnabled { get; }
    public EventPrefabsConfig EventPrefabsConfig { get; }
    private int unlockLevel { get; }
    private bool eventsDisplayable { get; }
    private static System.Collections.Generic.Dictionary<string, System.Type> TypeLookup { get; }
    public int GetCurrentEventsCount { get; }
    private System.Collections.Generic.List<WGEventHandler> currentEventHandlers { get; }
    public string QAHACK_CurrentSingleEventTypeKey { get; }
    
    // Methods
    public static bool get_EventsEnabled()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) == 0)
        {
                return false;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(eventsDisplayable == false)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_7 = GetCurrentEventsCount;
        if(val_7 != 0)
        {
                val_7 = 1;
        }
        
        return true;
    }
    public EventPrefabsConfig get_EventPrefabsConfig()
    {
        if(this.eventPrefabsConfig != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1535358816);
        UnityEngine.Transform val_3 = this.transform;
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  -1535358816, parent:  -1275848160);
        this.eventPrefabsConfig = "Events";
    }
    private int get_unlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 983057;
        }
        
        return 983057;
    }
    private bool get_eventsDisplayable()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private static System.Collections.Generic.Dictionary<string, System.Type> get_TypeLookup()
    {
        var val_8;
        var val_9;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_10;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_8 = null;
        val_8 = null;
        if(WordGameEventsController.compiledTypeLookup != 0)
        {
            goto label_33;
        }
        
        val_9 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                GameBehavior val_2 = App.getBehavior;
            val_10 = 0;
            val_11 = null;
            val_11 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  0);
            val_12 = null;
        }
        else
        {
                val_13 = null;
            val_13 = null;
            val_10 = WordGameEventsController.DefaultTypeLookup;
            val_11 = null;
            val_11 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  val_10);
        }
        
        val_12 = null;
        WordGameEventsController.compiledTypeLookup = val_11;
        GameBehavior val_5 = App.getBehavior;
        if(0 == 0)
        {
            goto label_33;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_6 = 0.GetEnumerator();
        val_9 = 1152921511921256672;
        label_26:
        if(0.MoveNext() == false)
        {
            goto label_23;
        }
        
        val_14 = null;
        val_14 = null;
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  78753792, key:  R5, newValue:  0);
        goto label_26;
        label_23:
        0.Dispose();
        label_33:
        val_15 = null;
        val_15 = null;
    }
    public override void InitMonoSingleton()
    {
        System.Delegate val_25;
        System.Delegate val_26;
        var val_27;
        var val_28;
        System.Delegate val_29;
        var val_30;
        System.Action<twelvegigs.storage.JsonDictionary> val_31;
        System.Delegate val_32;
        var val_33;
        System.Delegate val_34;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        this.InitMonoSingleton();
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1275380976, name:  -1383203024);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1275380976, name:  -1382557696);
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1275380976, name:  2128120864);
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1275380976, name:  -2005054624);
        NotificationCenter val_6 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1275380976, name:  -1664295744);
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1275380976, name:  -1275409824);
        System.Action<System.Int32> val_8 = new System.Action<System.Int32>(object:  -1275380976, method:  new IntPtr(3019557600));
        val_25 = GoldenApplesManager.OnAppleAwarded;
        System.Delegate val_9 = System.Delegate.Combine(a:  val_25, b:  7401472);
        if(val_25 != 0)
        {
                if(null == null)
        {
            goto label_15;
        }
        
        }
        
        val_25 = 0;
        label_15:
        GoldenApplesManager.OnAppleAwarded = val_25;
        System.Action<System.Int32> val_10 = new System.Action<System.Int32>(object:  -1275380976, method:  new IntPtr(3019557600));
        val_26 = TRVStarsManager.OnStarAwarded;
        System.Delegate val_11 = System.Delegate.Combine(a:  val_26, b:  7401472);
        if(val_26 == 0)
        {
            goto label_16;
        }
        
        val_27 = 1152921504892043264;
        if(null == null)
        {
            goto label_18;
        }
        
        val_26 = 0;
        goto label_18;
        label_16:
        val_26 = 0;
        val_27 = 1152921504892043264;
        label_18:
        TRVStarsManager.OnStarAwarded = val_26;
        GameBehavior val_12 = App.getBehavior;
        if(0 != 0)
        {
                NotificationCenter val_13 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -1275380976, name:  -1275408672);
            NotificationCenter val_14 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -1275380976, name:  -1275408576);
            NotificationCenter val_15 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -1275380976, name:  -1275408480);
            NotificationCenter val_16 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -1275380976, name:  -1275408384);
            NotificationCenter val_17 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -1275380976, name:  -1275408272);
            NotificationCenter val_18 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -1275380976, name:  -1275408160);
        }
        
        val_28 = null;
        val_28 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_19 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1275380976, method:  new IntPtr(3019559248));
        val_29 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_20 = System.Delegate.Combine(a:  val_29, b:  7401472);
        val_30 = null;
        val_31 = null;
        if(val_29 == 0)
        {
            goto label_34;
        }
        
        if(null == val_31)
        {
            goto label_35;
        }
        
        val_31 = null;
        val_30 = 1152921504898486364;
        label_34:
        val_29 = 0;
        label_35:
        PurchasesHandler.OnPurchaseCompleted = val_29;
        val_31 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1275380976, method:  new IntPtr(3019560272));
        val_32 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_22 = System.Delegate.Combine(a:  val_32, b:  7401472);
        val_33 = null;
        if(val_32 == 0)
        {
            goto label_36;
        }
        
        if(null == null)
        {
            goto label_37;
        }
        
        val_33 = 1152921504898486364;
        label_36:
        val_32 = 0;
        label_37:
        PurchasesHandler.OnPurchaseFailure = val_32;
        PostProcessPurchaseDelegate val_23 = new PostProcessPurchaseDelegate(object:  -1275380976, method:  new IntPtr(3019561296));
        val_34 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        System.Delegate val_24 = System.Delegate.Combine(a:  val_34, b:  291586048);
        if(val_34 != null)
        {
                if(null == null)
        {
            goto label_39;
        }
        
        }
        
        val_34 = 0;
        label_39:
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_34;
    }
    private void OnProcessPurchase(ref PurchaseModel purchase)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    private void OnPurchaseFailure(PurchaseModel obj)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    private void OnPurchaseCompleted(PurchaseModel obj)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public WGEventHandler GetGameSceneOrderedEventHandler(bool dailyChallengeState)
    {
        var val_15;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_16;
        var val_17;
        System.Func<WGEventHandler, System.Int32> val_19;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_20;
        var val_21;
        System.Func<WGEventHandler, System.DateTime> val_23;
        WordGameEventsController.<>c__DisplayClass21_0 val_1 = new WordGameEventsController.<>c__DisplayClass21_0();
        typeof(WordGameEventsController.<>c__DisplayClass21_0).__il2cppRuntimeField_8 = dailyChallengeState;
        System.Collections.Generic.List<WGEventHandler> val_2 = this.currentEventHandlers;
        val_15 = this;
        val_16 = null;
        val_16 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  321830912, method:  new IntPtr(3020034736));
        object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -1274897296, predicate:  7720960);
        if(val_15 != 0)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_5 = this.currentEventHandlers;
        val_17 = null;
        val_17 = null;
        val_19 = WordGameEventsController.<>c.<>9__21_1;
        if(val_19 == 0)
        {
                val_19 = null;
            val_19 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WordGameEventsController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3020035760));
            WordGameEventsController.<>c.<>9__21_1 = val_19;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_7 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Int32>(source:  -1274897296, keySelector:  7720960);
        val_15 = this;
        val_16 = null;
        val_16 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  321830912, method:  new IntPtr(3020038832));
        object val_9 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -1274897296, predicate:  7720960);
        if(val_15 != 0)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_10 = this.currentEventHandlers;
        val_20 = null;
        val_20 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  321830912, method:  new IntPtr(3020039856));
        System.Collections.Generic.IEnumerable<TSource> val_12 = System.Linq.Enumerable.Where<System.Object>(source:  -1274897296, predicate:  7720960);
        val_21 = null;
        val_21 = null;
        val_23 = WordGameEventsController.<>c.<>9__21_4;
        if(val_23 == 0)
        {
                val_23 = null;
            val_23 = new System.Func<WGEventHandler, System.DateTime>(object:  WordGameEventsController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3020041904));
            WordGameEventsController.<>c.<>9__21_4 = val_23;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_14 = System.Linq.Enumerable.OrderBy<System.Object, System.DateTime>(source:  -1274897296, keySelector:  7720960);
        return System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  -1274897296);
    }
    public WGEventHandler GetOrderedEventHandlersByIndex(int index)
    {
        var val_3;
        var val_4;
        val_3 = this;
        System.Collections.Generic.List<WGEventHandler> val_1 = this.GetOrderedEventHandlers();
        val_4 = 0;
        if(val_3 == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_2 = this.GetOrderedEventHandlers();
        val_3 = val_3;
        if(this.isWordRegionLoaded <= index)
        {
                return;
        }
        
        if(this.isWordRegionLoaded <= index)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (index << 2);
        val_4 = mem[(0 + (index) << 2) + 16];
        val_4 = (0 + (index) << 2) + 16;
    }
    public System.Collections.Generic.List<WGEventHandler> GetOrderedEventHandlers()
    {
        var val_8;
        System.Func<WGEventHandler, System.Boolean> val_10;
        var val_12;
        System.Func<WGEventHandler, System.Int32> val_14;
        var val_15;
        System.Func<WGEventHandler, System.DateTime> val_17;
        System.Collections.Generic.List<WGEventHandler> val_1 = this.currentEventHandlers;
        val_8 = null;
        val_8 = null;
        val_10 = WordGameEventsController.<>c.<>9__23_0;
        if(val_10 == 0)
        {
                val_10 = null;
            val_10 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordGameEventsController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3020270000));
            WordGameEventsController.<>c.<>9__23_0 = val_10;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Object>(source:  -1274668176, predicate:  7720960);
        val_12 = null;
        val_12 = null;
        val_14 = WordGameEventsController.<>c.<>9__23_1;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WordGameEventsController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3020271024));
            WordGameEventsController.<>c.<>9__23_1 = val_14;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_5 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Int32>(source:  -1274668176, keySelector:  7720960);
        val_15 = null;
        val_15 = null;
        val_17 = WordGameEventsController.<>c.<>9__23_2;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Func<WGEventHandler, System.DateTime>(object:  WordGameEventsController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3020272048));
            WordGameEventsController.<>c.<>9__23_2 = val_17;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_7 = System.Linq.Enumerable.ThenBy<System.Object, System.DateTime>(source:  -1274668176, keySelector:  7720960);
        return System.Linq.Enumerable.ToList<System.Object>(source:  -1274668176);
    }
    public bool IsEventButtonPositionOccupied()
    {
        var val_3;
        var val_4;
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE != 0)
        {
                val_3 = LightningWordsHandler.DEFAULT_REWARD_VALUE.IsLightningWordPeriod();
        }
        else
        {
                val_3 = 0;
        }
        
        var val_3 = 28063591;
        val_3 = 7564592 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((LightningLevelsEventHandler.<Instance>k__BackingField) != 0)
        {
                bool val_2 = LightningLevelsEventHandler.<Instance>k__BackingField.IsLightningPeriod();
        }
        else
        {
                val_4 = 0;
        }
        
        val_4 = val_4 & val_3;
        return (bool)val_4;
    }
    public static void InjectEventsTrackingData(System.Collections.Generic.Dictionary<string, object> data, bool onlyTrackEnabledEvents = False)
    {
        var val_6;
        string val_18;
        var val_19;
        ProxyEventTrackingDelegate val_20;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_1 = WordGameEventsController.TypeLookup;
        Dictionary.KeyCollection<TKey, TValue> val_2 = Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        label_31:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        WordGameEventsController.<>c__DisplayClass25_0 val_5 = new WordGameEventsController.<>c__DisplayClass25_0();
        if(val_5 != 0)
        {
                val_18 = val_5;
            typeof(WordGameEventsController.<>c__DisplayClass25_0).__il2cppRuntimeField_8 = val_6;
        }
        else
        {
                val_18 = 8;
            mem[8] = val_6;
        }
        
        string val_7 = WGEventHandler.UnFuckTrackingName(eventName:  val_18);
        string val_8 = System.String.Format(format:  -1312312496, arg0:  val_18);
        if((data.ContainsKey(key:  -1312312496)) == false)
        {
            goto label_9;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_18;
        UnityEngine.Debug.LogErrorFormat(format:  -1274461008, args:  472754880);
        goto label_31;
        label_9:
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Predicate<ZooTile> val_11 = new System.Predicate<ZooTile>(object:  321937408, method:  new IntPtr(3020507552));
        object val_12 = public static GameEventsManager MonoSingleton<GameEventsManager>::get_Instance().__il2cppRuntimeField_2C.Find(match:  8040448);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Predicate<ZooTile> val_14 = new System.Predicate<ZooTile>(object:  321937408, method:  new IntPtr(3020509600));
        object val_15 = public static GameEventsManager MonoSingleton<GameEventsManager>::get_Instance().__il2cppRuntimeField_2C.Find(match:  8040448);
        data.Add(key:  -1312312496, value:  8945664);
        goto label_31;
        label_5:
        Dispose();
        val_19 = null;
        val_19 = null;
        val_20 = WordGameEventsController.AddTrackingEventData;
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = WordGameEventsController.AddTrackingEventData;
        if(val_20 == 0)
        {
                val_20 = 0;
        }
        
        object val_17 = val_20.Invoke(trackingData: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_16 = -1274443688);
    }
    public static string GameEventActiveForTracking()
    {
        string val_6;
        var val_9;
        var val_10;
        val_9 = null;
        val_9 = null;
        if((MonoSingleton<T>.searchedFailed) == 0)
        {
                val_10 = "None";
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<WGEventHandler> val_3 = currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_14:
        val_10 = "";
        label_13:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        if(val_6 != 0)
        {
            goto label_13;
        }
        
        string val_7 = val_6.EventType;
        string val_8 = 1098586544 + val_6;
        goto label_14;
        label_11:
        Dispose();
    }
    public int get_GetCurrentEventsCount()
    {
        var val_4;
        System.Func<WGEventHandler, System.Boolean> val_6;
        System.Collections.Generic.List<WGEventHandler> val_1 = this.currentEventHandlers;
        val_4 = null;
        val_4 = null;
        val_6 = WordGameEventsController.<>c.<>9__28_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordGameEventsController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3020739744));
            WordGameEventsController.<>c.<>9__28_0 = val_6;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Object>(source:  -1274201504, predicate:  7720960);
        return System.Linq.Enumerable.Count<WGEventHandler>(source:  -1274201504);
    }
    private System.Collections.Generic.List<WGEventHandler> get_currentEventHandlers()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2;
        if(this.QAHACK_SingleEventKeyIndex != 1)
        {
                val_2 = null;
            val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(val_2 <= this.QAHACK_SingleEventKeyIndex)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_2 = val_2 + (this.QAHACK_SingleEventKeyIndex << 2);
            Add(item:  (0 + (this.QAHACK_SingleEventKeyIndex) << 2) + 16);
            return;
        }
        
        val_2 = this._currentEventHandlers;
    }
    private WGEventHandler getHandlerForEvent(string eventName)
    {
        WordGameEventsController.<>c__DisplayClass32_0 val_1 = new WordGameEventsController.<>c__DisplayClass32_0();
        typeof(WordGameEventsController.<>c__DisplayClass32_0).__il2cppRuntimeField_8 = eventName;
        System.Collections.Generic.List<WGEventHandler> val_2 = this.currentEventHandlers;
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  321990656, method:  new IntPtr(3020986272));
        if(this != 0)
        {
                return this.Find(match:  8040448);
        }
        
        return this.Find(match:  8040448);
    }
    public WGEventHandler ForceInitNewHandlerForEvent(GameEventV2 eventV2)
    {
        var val_7;
        string val_8;
        var val_9;
        val_7 = 1152921504928518144;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_1 = WordGameEventsController.TypeLookup;
        val_8 = eventV2.type;
        val_9 = 0;
        if((ContainsKey(key:  val_8)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Type> val_3 = WordGameEventsController.TypeLookup;
        string val_4 = Item[eventV2.type];
        val_8 = null;
        object val_5 = System.Activator.CreateInstance(type:  321671168);
        val_7 = null;
        val_9 = 0;
        System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(321138688)});
        if(val_8 == 0)
        {
                return;
        }
        
        if(val_7 != 0)
        {
                val_9 = val_7;
            return;
        }
    
    }
    private void OnGameEventDataReceived()
    {
        GameEventV2 val_7;
        var val_15;
        GameBehavior val_1 = App.getBehavior;
        val_15 = 0;
        if(val_15 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        WordGameEventsController.InjectEventsTrackingData(data:  78753792, onlyTrackEnabledEvents:  false);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        List.Enumerator<T> val_5 = GetEnumerator();
        label_17:
        if(MoveNext() == false)
        {
            goto label_13;
        }
        
        WGEventHandler val_8 = this.getHandlerForEvent(eventName:  val_7 + 56);
        if(this == 0)
        {
            goto label_15;
        }
        
        goto label_17;
        label_15:
        this.CreateAndInitHandlerForEvent(eventV2:  val_7);
        goto label_17;
        label_13:
        Dispose();
        this.RemoveExpiredHandlers();
        if(this.AddProxyEventHandlers != 0)
        {
                object val_10 = this.AddProxyEventHandlers.Invoke(existingEventHandlers: ref  this._currentEventHandlers);
        }
        
        if(this.RemoveExpiredProxyEventHandlers != 0)
        {
                object val_12 = this.RemoveExpiredProxyEventHandlers.Invoke(existingEventHandlers: ref  this._currentEventHandlers);
        }
        
        System.Collections.Generic.List<WGEventHandler> val_13 = this.currentEventHandlers;
        if(this.isWordRegionLoaded < true)
        {
                return;
        }
        
        NotificationCenter val_14 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1273692064, aName:  -1649709888);
    }
    private void OnGameEventDataPutResponse()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        WGEventHandler val_7 = this.getHandlerForEvent(eventName:  val_6 + 56);
        if(this == 0)
        {
            goto label_14;
        }
        
        goto label_14;
        label_11:
        Dispose();
    }
    private void OnMyProfileUpdate()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        WGEventHandler val_7 = this.getHandlerForEvent(eventName:  val_6 + 56);
        if(this == 0)
        {
            goto label_14;
        }
        
        goto label_14;
        label_11:
        Dispose();
    }
    private void CreateAndInitHandlerForEvent(GameEventV2 eventV2)
    {
        var val_13;
        var val_14;
        var val_15;
        System.Collections.Generic.Dictionary<System.String, System.Type> val_1 = WordGameEventsController.TypeLookup;
        val_13 = null;
        if((ContainsKey(key:  eventV2.type)) == false)
        {
            goto label_5;
        }
        
        GameBehavior val_3 = App.getBehavior;
        val_13 = 0;
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  eventV2.minPlayerLevel)) == false)
        {
            goto label_12;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Type> val_5 = WordGameEventsController.TypeLookup;
        string val_6 = Item[eventV2.type];
        object val_7 = System.Activator.CreateInstance(type:  321671168);
        System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(321138688)});
        if(null == 0)
        {
            goto label_19;
        }
        
        if(1 == 0)
        {
            goto label_23;
        }
        
        goto label_24;
        label_5:
        val_14 = "no type declared for event of ";
        goto label_39;
        label_12:
        val_14 = "player level not met for event: ";
        label_39:
        string val_9 = -1273359456(-1273359456) + eventV2.type;
        UnityEngine.Debug.LogWarning(message:  -1273359456);
        return;
        label_19:
        string val_10 = -1312556912(-1312556912) + eventV2.type;
        UnityEngine.Debug.LogError(message:  -1312556912);
        return;
        label_23:
        label_24:
        if(0 == 0)
        {
            goto label_39;
        }
        
        this._currentEventHandlers.Add(item:  0);
        var val_13 = 28057868;
        val_13 = 7569556 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        if(0 != LeaderboardEventHandler.instance)
        {
                return;
        }
        
        System.Collections.IEnumerator val_11 = this.UpdateLeaderboardData(seconds:  30);
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  -1273323024);
    }
    private void RemoveExpiredHandlers()
    {
        char* val_6;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if((new WordGameEventsController.<>c__DisplayClass43_0()) != 0)
        {
                typeof(WordGameEventsController.<>c__DisplayClass43_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        val_6 = 0;
        typeof(WordGameEventsController.<>c__DisplayClass43_0).__il2cppRuntimeField_8 = ;
        this._currentEventHandlers = null;
    }
    private System.Collections.IEnumerator UpdateLeaderboardData(int seconds = 30)
    {
        if((new WordGameEventsController.<UpdateLeaderboardData>d__44(<>1__state:  0)) != 0)
        {
                typeof(WordGameEventsController.<UpdateLeaderboardData>d__44).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(WordGameEventsController.<UpdateLeaderboardData>d__44).__il2cppRuntimeField_14 = seconds;
    }
    public string get_QAHACK_CurrentSingleEventTypeKey()
    {
        if(this.QAHACK_SingleEventKeyIndex == 1)
        {
                return;
        }
        
        if(true <= this.QAHACK_SingleEventKeyIndex)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (this.QAHACK_SingleEventKeyIndex << 2);
        if(((0 + (this.QAHACK_SingleEventKeyIndex) << 2) + 16) != 0)
        {
                return (0 + (this.QAHACK_SingleEventKeyIndex) << 2) + 16.EventType;
        }
        
        return (0 + (this.QAHACK_SingleEventKeyIndex) << 2) + 16.EventType;
    }
    public void QAHACK_ToggleSingleEvent()
    {
        System.Collections.Generic.List<WGEventHandler> val_2 = this._currentEventHandlers + 1;
        float val_3 = UnityEngine.Mathf.Repeat(t:  (float)this.QAHACK_SingleEventKeyIndex + 1, length:  null);
        this.QAHACK_SingleEventKeyIndex = (float)this.QAHACK_SingleEventKeyIndex + 1;
        if(((float)this.QAHACK_SingleEventKeyIndex + 1) == 2139095040)
        {
                (float)this.QAHACK_SingleEventKeyIndex + 1 = 0;
            this.QAHACK_SingleEventKeyIndex = (float)this.QAHACK_SingleEventKeyIndex + 1;
        }
        
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1272789936, aName:  -1649709888);
    }
    public System.Collections.Generic.List<WGEventHandler> QAHACK_GetAllEventHandlers()
    {
        return this.currentEventHandlers;
    }
    public void HackAddLevels(int levelsHacked)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 != 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public string DebugGetLevel()
    {
        var val_6;
        var val_7;
        var val_8;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            goto label_5;
        }
        
        if(this.eventsDisplayable == false)
        {
            goto label_6;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_9;
        }
        
        val_7 = val_6;
        Dispose();
        return;
        label_5:
        val_8 = "not supported for this game";
        return;
        label_6:
        val_8 = "too much of a wee baby to do events";
        return;
        label_8:
        Dispose();
        val_8 = "no current event!";
    }
    public void OnGameSceneBegan()
    {
        var val_7;
        var val_8;
        val_8 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_4 = this.currentEventHandlers;
        List.Enumerator<T> val_5 = GetEnumerator();
        val_8 = 1152921511884346992;
        label_16:
        if(MoveNext() == false)
        {
            goto label_13;
        }
        
        if((val_7 == 0) || (val_7 != 0))
        {
            goto label_16;
        }
        
        goto label_16;
        label_13:
        Dispose();
    }
    public void OnBeforeLevelComplete(int levelsProgressed = 1)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnLevelComplete(int levelsProgressed = 1)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnForestComplete(int levelsProgressed = 1)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnNewForestShown()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnForestUpdated()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnMysteryChestCollected()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnCategoryComplete()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnEventCategorySelected(TRVCategorySelectionInfo category)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 != 0)
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public System.Collections.Generic.List<TRVCategorySelectionInfo> GetEventsRegisteredCategories(System.Collections.Generic.List<TRVCategorySelectionInfo> categories)
    {
        var val_6;
        var val_7;
        var val_8;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if((val_7 == 0) || (this.eventsDisplayable == false))
        {
            goto label_6;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        val_8 = categories;
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_10;
        }
        
        goto label_11;
        label_6:
        val_8 = categories;
        return;
        label_8:
        Dispose();
    }
    public void OnLevelCompletedRewarded()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnLevelCompleteRewardAnimFinished()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnDailyChallengeLevelComplete()
    {
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_2 = this.currentEventHandlers;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        if((val_5 == 0) || (val_5 != 0))
        {
            goto label_10;
        }
        
        goto label_10;
        label_7:
        Dispose();
    }
    public void OnDailyChallengeRewardGranted()
    {
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_2 = this.currentEventHandlers;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        if((val_5 == 0) || (val_5 != 0))
        {
            goto label_10;
        }
        
        goto label_10;
        label_7:
        Dispose();
    }
    public void OnBonusGameGoldCurrencyRewardGranted()
    {
        var val_5;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_2 = this.currentEventHandlers;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        if((val_5 == 0) || (val_5 != 0))
        {
            goto label_10;
        }
        
        goto label_10;
        label_7:
        Dispose();
    }
    public void OnAppleAwarded(int appleAwarded)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 == 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnMenuLoaded()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        this.isWordRegionLoaded = false;
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnWordRegionLoaded()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        this.isWordRegionLoaded = true;
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 != 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void OnGameSceneInit()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnDailyChallengeInit()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnWindowStateChanged(bool anyActiveWindows)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_7 = 1152921511884346992;
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public bool ActivelyPlayingEventGameMode()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(0 == 0)
        {
                return (bool)val_7;
        }
        
        if(this.eventsDisplayable == false)
        {
                return (bool)val_7;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_8 = 0;
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        val_9 = 1;
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        val_8 = val_6;
        goto label_10;
        label_8:
        val_9 = 0;
        label_10:
        Dispose();
        val_7 = val_9 & val_8;
        return (bool)val_7;
    }
    public void OnVideoResponse(Notification notif)
    {
        var val_8;
        var val_9;
        GameBehavior val_1 = App.getBehavior;
        val_9 = 0;
        if(val_9 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        string val_3 = notif.data.ToString();
        bool val_4 = System.Boolean.Parse(value:  notif.data);
        System.Collections.Generic.List<WGEventHandler> val_5 = this.currentEventHandlers;
        List.Enumerator<T> val_6 = GetEnumerator();
        val_9 = 1152921511884346992;
        label_15:
        if(MoveNext() == false)
        {
            goto label_13;
        }
        
        if(val_8 == 0)
        {
            goto label_15;
        }
        
        goto label_15;
        label_13:
        Dispose();
    }
    public void OnEventHandlerProgress()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -1649709760);
    }
    public void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> curData)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_7 = 1152921511884346992;
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void AppendDailyChallengeCompleteData(ref System.Collections.Generic.Dictionary<string, object> curData)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 == 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public void AppendLeaguesRolloverData(ref System.Collections.Generic.Dictionary<string, object> curData)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_7 = 1152921511884346992;
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void ResetDCProgress()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 == 0))
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        Dispose();
    }
    public bool TryShowFtux()
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(0 == 0)
        {
                return (bool)val_7;
        }
        
        if(this.eventsDisplayable == false)
        {
                return (bool)val_7;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 == 0))
        {
            goto label_10;
        }
        
        val_7 = 1;
        goto label_11;
        label_8:
        val_7 = 0;
        label_11:
        Dispose();
        return (bool)val_7;
    }
    public void OnSubmitWordWithHints(string word)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 != 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnHintIncompleteWord(string word, Cell hintedCell)
    {
        var val_6;
        var val_7;
        var val_8;
        val_7 = this;
        GameBehavior val_1 = App.getBehavior;
        val_8 = 0;
        if(val_8 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_8 = val_7;
        val_7;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 != 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnHintForceEventLineWord(System.Collections.Generic.List<LineWord> lines, ref LineWord word, bool isPickerHint)
    {
        var val_6;
        var val_7 = this;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 != 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public GameLevel checkEventForGameLevel(GameLevel refLevel)
    {
        var val_6;
        var val_7;
        var val_8;
        val_7 = this;
        GameBehavior val_1 = App.getBehavior;
        val_8 = 0;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 == 0))
        {
            goto label_10;
        }
        
        val_8 = val_6;
        goto label_11;
        label_8:
        val_8 = 0;
        label_11:
        Dispose();
    }
    public void OnPreprocessPlayerTurn(bool hintUsage, string wordEntered, LineWord lineWord, Cell cell)
    {
        var val_6;
        var val_7 = this;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 != 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnValidWordSubmitted(string word, bool extra)
    {
        var val_6;
        var val_7;
        var val_8;
        val_7 = extra;
        GameBehavior val_1 = App.getBehavior;
        val_8 = 0;
        if(val_8 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        if(val_7 == true)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7 = this;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_8 = 1152921511884346992;
        label_11:
        if(MoveNext() == false)
        {
            goto label_9;
        }
        
        if(val_6 != 0)
        {
            goto label_11;
        }
        
        goto label_11;
        label_9:
        Dispose();
    }
    public void OnInvalidWordSubmitted()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 != 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void BreakWordStreak()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 != 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnFacebookPluginUpdate()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 != 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnAnyHintUsed(bool wasFree)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_7 = 1152921511884346992;
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public WGWindow OnTRVQuestionStart(TRVQuizProgress progress)
    {
        UnityEngine.Object val_6;
        UnityEngine.Object val_8;
        GameBehavior val_1 = App.getBehavior;
        val_8 = 0;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        val_8 = val_6;
        if(val_8 == 0)
        {
            goto label_12;
        }
        
        goto label_13;
        label_8:
        val_8 = 0;
        label_13:
        Dispose();
    }
    public System.Collections.Generic.List<int> GetMovingItemsIndices()
    {
        int val_7;
        var val_8;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        GameBehavior val_2 = App.getBehavior;
        val_8 = 0;
        if(val_8 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_4 = this.currentEventHandlers;
        val_8 = this;
        List.Enumerator<T> val_5 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_7 == 0) || (val_7 < 0))
        {
            goto label_12;
        }
        
        Add(item:  val_7);
        goto label_12;
        label_8:
        Dispose();
    }
    public TRVQuizProgress GetEventQuiz(TRVSubCategoryData data)
    {
        var val_6;
        var val_7;
        var val_8;
        val_7 = this;
        GameBehavior val_1 = App.getBehavior;
        val_8 = 0;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        val_7;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if((val_6 == 0) || (val_6 == 0))
        {
            goto label_10;
        }
        
        val_8 = val_6;
        goto label_11;
        label_8:
        val_8 = 0;
        label_11:
        Dispose();
    }
    public void InjectGemSpentTrackingInfo(ref System.Collections.Generic.Dictionary<string, object> trackingData)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_7 = 1152921511884346992;
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void AppendAmplitudeUserProperties(ref System.Collections.Generic.Dictionary<string, object> globals)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_7 = 1152921511884346992;
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnSpinStarted()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnSpinEnded()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnReelStopped(Notification notif)
    {
        var val_6;
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        if(val_7 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        val_7 = 1152921511884346992;
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnAllReelsStopped()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnSpinAmountUpdate()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public void OnSpinBetUpdate()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        if(this.eventsDisplayable == false)
        {
                return;
        }
        
        System.Collections.Generic.List<WGEventHandler> val_3 = this.currentEventHandlers;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        if(val_6 == 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_8:
        Dispose();
    }
    public WordGameEventsController()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.QAHACK_SingleEventKeyIndex = 0;
        this._currentEventHandlers = null;
    }
    private static WordGameEventsController()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(321511424)});
        Add(key:  -1280644912, value:  321511424);
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(320499712)});
        Add(key:  -1322387776, value:  320499712);
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(316452864)});
        Add(key:  -1266462992, value:  316452864);
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(320872448)});
        Add(key:  -1306784064, value:  320872448);
        System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(312832000)});
        Add(key:  -1298908160, value:  312832000);
        System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(376356864)});
        Add(key:  -1266462880, value:  376356864);
        System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(313204736)});
        Add(key:  -1298907104, value:  313204736);
        System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(334557184)});
        Add(key:  -1266462784, value:  334557184);
        System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(328380416)});
        Add(key:  -1648557216, value:  328380416);
        System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(329392128)});
        Add(key:  -1266462688, value:  329392128);
        System.Type val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(323481600)});
        Add(key:  -1266462592, value:  323481600);
        System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(320606208)});
        Add(key:  -1321166448, value:  320606208);
        System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(336953344)});
        Add(key:  -1298909328, value:  336953344);
        System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(334290944)});
        Add(key:  -1266462496, value:  334290944);
        System.Type val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(325292032)});
        Add(key:  -1266462400, value:  325292032);
        System.Type val_17 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(325451776)});
        Add(key:  -1266462304, value:  325451776);
        System.Type val_18 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(324599808)});
        Add(key:  -1266462192, value:  324599808);
        System.Type val_19 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(327954432)});
        Add(key:  -1266462096, value:  327954432);
        System.Type val_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(366559232)});
        Add(key:  -1298909536, value:  366559232);
        System.Type val_21 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(364376064)});
        Add(key:  -1648577792, value:  364376064);
        System.Type val_22 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(364908544)});
        Add(key:  -1298908624, value:  364908544);
        System.Type val_23 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(364482560)});
        Add(key:  -1298909136, value:  364482560);
        System.Type val_24 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(365867008)});
        Add(key:  -1298907008, value:  365867008);
        System.Type val_25 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(319062016)});
        Add(key:  -1266462000, value:  319062016);
        System.Type val_26 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(309104640)});
        Add(key:  -1298908064, value:  309104640);
        System.Type val_27 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(310329344)});
        Add(key:  -1266461904, value:  310329344);
        System.Type val_28 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(332427264)});
        Add(key:  -1266461808, value:  332427264);
        System.Type val_29 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(334077952)});
        Add(key:  -1266461696, value:  334077952);
        System.Type val_30 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(328966144)});
        Add(key:  -1298907888, value:  328966144);
        System.Type val_31 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(331415552)});
        Add(key:  -1298908816, value:  331415552);
        System.Type val_32 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(364589056)});
        Add(key:  -1266461600, value:  364589056);
        System.Type val_33 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(363950080)});
        Add(key:  -1266461488, value:  363950080);
        System.Type val_34 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(308412416)});
        Add(key:  -1549997168, value:  308412416);
        System.Type val_35 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(330297344)});
        Add(key:  -1298907488, value:  330297344);
        System.Type val_36 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(325132288)});
        Add(key:  -1298907680, value:  325132288);
        System.Type val_37 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(330936320)});
        Add(key:  -1298908384, value:  330936320);
        System.Type val_38 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(379604992)});
        Add(key:  -1266461392, value:  379604992);
        System.Type val_39 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(318050304)});
        Add(key:  -1266461296, value:  318050304);
        System.Type val_40 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(315228160)});
        Add(key:  -1425319472, value:  315228160);
        System.Type val_41 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(320126976)});
        Add(key:  -1342036480, value:  320126976);
        System.Type val_42 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(316932096)});
        Add(key:  -1401622144, value:  316932096);
        System.Type val_43 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(353779712)});
        Add(key:  -1648524352, value:  353779712);
        System.Type val_44 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(316612608)});
        Add(key:  -1408082768, value:  316612608);
        WordGameEventsController.DefaultTypeLookup = null;
        WordGameEventsController.compiledTypeLookup = 0;
    }

}
