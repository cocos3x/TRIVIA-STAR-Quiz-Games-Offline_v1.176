using UnityEngine;
public class EventButtonPanel : MonoBehaviour
{
    // Fields
    private const int MAX_EVENT_DISPLAY = 2;
    private const string BUTTON_ORDER_PREFKEY = "evtpnl_btn_order";
    protected EventButtonPanel.LayoutType layout;
    protected EventButtonPanel.DisplayContext displayContext;
    protected UnityEngine.CanvasGroup rootCanvasGroup;
    protected UnityEngine.GameObject rootContainer;
    protected System.Collections.Generic.List<UnityEngine.Transform> slot;
    protected bool dontAnimateIntro;
    protected float onEnableDelay;
    protected System.Collections.Generic.List<string> btnPlacementOrder;
    protected System.Collections.Generic.List<WGEventButtonV2> btnList;
    private bool isInitialized;
    private DG.Tweening.Tween panelOuttroTween;
    
    // Properties
    public System.Collections.Generic.List<WGEventButtonV2> ButtonList { get; }
    public UnityEngine.CanvasGroup RootCanvasGroup { get; }
    
    // Methods
    public System.Collections.Generic.List<WGEventButtonV2> get_ButtonList()
    {
    
    }
    public UnityEngine.CanvasGroup get_RootCanvasGroup()
    {
    
    }
    protected void Awake()
    {
        System.Collections.Generic.List<System.String> val_5;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -326711456, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -326711456)) != false)
        {
                val_5 = this.btnPlacementOrder;
        }
        else
        {
                val_5 = "evtpnl_btn_order";
            object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -326711456);
            this.btnPlacementOrder = val_5;
        }
        
        if(val_5 != 0)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem2[0] = null;
    }
    protected void Start()
    {
        System.Action val_9;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -326566128, name:  -1649709888);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -326566128, name:  -1649709760);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -326566128, name:  -1383203024);
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        0.AddObserver(observer:  -326566128, name:  442544128);
        val_9 = 1152921504886931456;
        WordRegion val_5 = WordRegion.instance;
        if(0 != 0)
        {
                WordRegion val_7 = WordRegion.instance;
            val_9 = null;
            val_9 = new System.Action(object:  -326566128, method:  new IntPtr(3968376144));
            0.addOnLevelLoadCompleteAction(callback:  7454720);
        }
        
        this.UpdateDisplay();
    }
    protected void OnDestroy()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -326450032, name:  -1649709888);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -326450032, name:  -1649709760);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -326450032, name:  -1383203024);
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        0.RemoveObserver(observer:  -326450032, name:  442544128);
        if(this.panelOuttroTween == 0)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.panelOuttroTween, complete:  false);
    }
    protected void OnEnable()
    {
        this.UpdateDisplay();
    }
    protected void OnGameEventDataReceived()
    {
        this.UpdateDisplay();
    }
    protected void OnGameEventControllerUpdate()
    {
        this.UpdateDisplay();
    }
    protected void OnGameEventHandlerProgress()
    {
        this.UpdateDisplay();
    }
    protected void OnMyProfileUpdate()
    {
        this.UpdateDisplay();
    }
    public WGEventButtonV2 GetEventButton(string eventId)
    {
        object val_1 = new System.Object();
        typeof(EventButtonPanel.<>c__DisplayClass27_0).__il2cppRuntimeField_8 = eventId;
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  371937280, method:  new IntPtr(3969177552));
        if(this.btnList != 0)
        {
                return this.btnList.Find(match:  8040448);
        }
        
        return this.btnList.Find(match:  8040448);
    }
    public WGEventButtonV2 GetEventButton(int slotIndex)
    {
        var val_1 = 0;
        if(slotIndex < 0)
        {
                return;
        }
        
        if(true <= slotIndex)
        {
                return;
        }
        
        if(true <= slotIndex)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (slotIndex << 2);
        val_1 = mem[(0 + (slotIndex) << 2) + 16];
        val_1 = (0 + (slotIndex) << 2) + 16;
    }
    protected string GetEventIdForSlotIndex(int slotIndex)
    {
        var val_1;
        bool val_1 = true;
        val_1 = 0;
        if(slotIndex < 0)
        {
                return;
        }
        
        val_1 = val_1 - 1;
        if(val_1 < slotIndex)
        {
                return;
        }
        
        if(val_1 <= slotIndex)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (slotIndex << 2);
        val_1 = mem[(0 + (slotIndex) << 2) + 16];
        val_1 = (0 + (slotIndex) << 2) + 16;
    }
    protected void SetEventIdForSlotIndex(int slotIndex, string eventId)
    {
        System.Collections.Generic.List<System.String> val_1;
        System.Collections.Generic.List<System.String> val_2;
        var val_3;
        var val_1 = 35631113;
        val_1 = this.btnPlacementOrder;
        if(val_1 == 0)
        {
            goto label_1;
        }
        
        if(true <= slotIndex)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(this.btnPlacementOrder == 0)
        {
            goto label_4;
        }
        
        val_1 = this.btnPlacementOrder;
        if(slotIndex > slotIndex)
        {
            goto label_5;
        }
        
        label_2:
        if(val_1 > slotIndex)
        {
                return;
        }
        
        do
        {
            val_2 = this.btnPlacementOrder;
            if(slotIndex != val_1)
        {
                slotIndex = 0;
        }
        
            val_2.Add(item:  slotIndex = eventId);
            val_1 = val_1 + 1;
        }
        while(val_1 <= slotIndex);
        
        return;
        label_4:
        val_3 = 0;
        label_5:
        val_3.set_Item(index:  slotIndex, value:  eventId);
    }
    protected int GetEmptySlotIndex()
    {
        var val_2;
        var val_3;
        if(true > 1)
        {
            goto label_2;
        }
        
        val_2 = 0;
        goto label_3;
        label_6:
        System.Collections.Generic.List<System.String> val_2 = this.btnPlacementOrder;
        val_2.Add(item:  null);
        val_2 = 1;
        label_3:
        val_2 = 2 - val_2;
        if(val_2 < val_2)
        {
            goto label_6;
        }
        
        label_2:
        val_3 = 0;
        goto label_7;
        label_13:
        val_3 = 1;
        label_7:
        if(val_3 > 1)
        {
                return 0;
        }
        
        if(val_3 >= 0)
        {
                return 0;
        }
        
        if(0 <= val_3)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 4;
        if((System.String.IsNullOrEmpty(value:  (0 + 4) + 16)) == false)
        {
            goto label_13;
        }
        
        return (int)val_3;
    }
    protected bool IsSlotAvailable(int slotIndex)
    {
        if(slotIndex > 1)
        {
                this = 0;
            return (bool)this;
        }
        
        string val_1 = this.GetEventIdForSlotIndex(slotIndex:  slotIndex);
        return System.String.IsNullOrEmpty(value:  null);
    }
    protected int GetSlotIndexForEvent(string eventId)
    {
        object val_1 = new System.Object();
        typeof(EventButtonPanel.<>c__DisplayClass33_0).__il2cppRuntimeField_8 = eventId;
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  371990528, method:  new IntPtr(3969975504));
        if(this.btnPlacementOrder != 0)
        {
                return this.btnPlacementOrder.FindIndex(match:  8040448);
        }
        
        return this.btnPlacementOrder.FindIndex(match:  8040448);
    }
    protected WGEventButtonV2 GetPrefab(string eventId)
    {
        if(this.layout == 1)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            EventPrefabsConfig val_3 = EventPrefabsConfig;
            if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) != 0)
        {
                return GetEventProgressPrefab(eventId:  eventId);
        }
        
            return GetEventProgressPrefab(eventId:  eventId);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        EventPrefabsConfig val_5 = EventPrefabsConfig;
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) != 0)
        {
                return GetEventButtonPrefab(eventId:  eventId);
        }
        
        return GetEventButtonPrefab(eventId:  eventId);
    }
    protected void ResyncEventSlotStatus()
    {
        string val_13;
        char* val_14;
        var val_15;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<WGEventHandler> val_2 = GetOrderedEventHandlers();
        object val_3 = null;
        val_13 = val_3;
        val_3 = new System.Object();
        if(val_13 != 0)
        {
                typeof(EventButtonPanel.<>c__DisplayClass35_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        val_14 = 0;
        typeof(EventButtonPanel.<>c__DisplayClass35_0).__il2cppRuntimeField_8 = ;
        val_15 = 4;
        var val_11 =  - 4;
        string val_12 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.btnPlacementOrder);
        UnityEngine.PlayerPrefs.SetString(key:  -326711456, value:  this.btnPlacementOrder);
        bool val_13 = PrefsSerializationManager.SavePlayerPrefs();
    }
    protected void UpdateDisplay()
    {
        EventButtonPanel val_44;
        int val_45;
        var val_46;
        var val_47;
        var val_48;
        val_44 = this;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(isAvailable == false)
        {
                return;
        }
        
        if(this.isInitialized != true)
        {
                this.isInitialized = true;
            if(this.isInitialized > false)
        {
                DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  -324550624, method:  new IntPtr(3968376144));
            DG.Tweening.Tween val_4 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  this.onEnableDelay, ignoreTimeScale:  false);
            return;
        }
        
        }
        
        if(WordGameEventsController.EventsEnabled != true)
        {
                if(this.rootContainer.activeSelf == false)
        {
                return;
        }
        
        }
        
        UnityEngine.GameObject val_7 = this.rootContainer.gameObject;
        this.rootContainer.SetActive(value:  true);
        this.ResyncEventSlotStatus();
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<WGEventHandler> val_9 = GetOrderedEventHandlers();
        if(1152921511095741471 >= 0)
        {
                val_45 = 1152921504978944000;
            do
        {
            object val_10 = null;
            val_46 = val_10;
            val_10 = new System.Object();
            if(val_10 <= 1152921511095741471)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            bool val_11 = UnityEngine.Object.op_Equality(x:  mem[185774220], y:  0);
            if(val_11 != true)
        {
                if(val_11 <= 1152921511095741471)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_12 = mem[185774220].EventType;
            typeof(EventButtonPanel.<>c__DisplayClass36_0).__il2cppRuntimeField_8 = mem[185774220];
            System.Predicate<ZooTile> val_13 = new System.Predicate<ZooTile>(object:  372097024, method:  new IntPtr(3970387280));
            string val_14 = this.btnPlacementOrder.Find(match:  8040448);
            bool val_15 = System.String.IsNullOrEmpty(value:  this.btnPlacementOrder);
            val_44 = val_44;
            if(val_15 != false)
        {
                if(val_15 <= 1152921511095741471)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            this.btnList.set_Item(index:  -2101040097, value:  0);
        }
        
        }
        
        }
        while(1152921511095741470 > 1);
        
        }
        
        val_47 = 0;
        val_48 = 1152921504765685760;
        bool val_40 = WordGameEventsController.EventsEnabled;
        if(val_40 == true)
        {
                return;
        }
        
        if(val_40 >= true)
        {
                DG.Tweening.TweenCallback val_41 = new DG.Tweening.TweenCallback(object:  -324550624, method:  new IntPtr(3970391648));
            DG.Tweening.Tween val_42 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1077936128, ignoreTimeScale:  false);
            mem[1152921512872230996] = 1077936128;
            return;
        }
        
        UnityEngine.GameObject val_43 = this.rootContainer.gameObject;
        this.rootContainer.SetActive(value:  false);
    }
    public EventButtonPanel()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.btnPlacementOrder = null;
        System.Collections.Generic.List<WGEventButtonV2> val_2 = new System.Collections.Generic.List<WGEventButtonV2>(capacity:  2);
        this.btnList = null;
    }
    private void <UpdateDisplay>b__36_0()
    {
        if(this.rootContainer == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = R4 + 24.gameObject;
        R4 + 24.SetActive(value:  false);
    }

}
