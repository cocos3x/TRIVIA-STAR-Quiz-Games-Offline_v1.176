using UnityEngine;
public class LocalGameEventSpawner<T> : MonoSingleton<T>
{
    // Fields
    private static readonly System.Collections.Generic.Dictionary<System.Type, System.Type> ProxyEventHandlerTypeLookup;
    
    // Methods
    public virtual void Start()
    {
        var val_9;
        var val_10;
        var val_11;
        WordGameEventsController.ProxyEventTrackingDelegate val_12;
        ProxyEventTrackingDelegate val_13;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = 0;
        WordGameEventsController.ProxyEventHandlerDelegate val_2 = new WordGameEventsController.ProxyEventHandlerDelegate(object:  -1313349856, method:  typeof(LocalGameEventSpawner<T>).__il2cppRuntimeField_120);
        System.Delegate val_3 = System.Delegate.Combine(a:  public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance().__il2cppRuntimeField_18, b:  321724416);
        val_9 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance().__il2cppRuntimeField_18;
        val_9 = 0;
        public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance().__il2cppRuntimeField_18 = val_9;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = 0;
        WordGameEventsController.ProxyEventHandlerDelegate val_5 = new WordGameEventsController.ProxyEventHandlerDelegate(object:  -1313349856, method:  typeof(LocalGameEventSpawner<T>).__il2cppRuntimeField_128);
        System.Delegate val_6 = System.Delegate.Combine(a:  public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance().__il2cppRuntimeField_1C, b:  321724416);
        val_10 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance().__il2cppRuntimeField_1C;
        val_10 = 0;
        public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance().__il2cppRuntimeField_1C = val_10;
        val_11 = null;
        val_11 = null;
        val_12 = null;
        val_13 = 0;
        val_12 = new WordGameEventsController.ProxyEventTrackingDelegate(object:  -1313349856, method:  typeof(LocalGameEventSpawner<T>).__il2cppRuntimeField_130);
        System.Delegate val_8 = System.Delegate.Combine(a:  WordGameEventsController.AddTrackingEventData, b:  321777664);
        if(WordGameEventsController.AddTrackingEventData != 0)
        {
                val_12 = null;
            val_13 = WordGameEventsController.AddTrackingEventData;
            if(WordGameEventsController.AddTrackingEventData == 0)
        {
                val_13 = 0;
        }
        
        }
        
        WordGameEventsController.AddTrackingEventData = val_13;
        goto typeof(LocalGameEventSpawner<T>).__il2cppRuntimeField_F4;
    }
    public virtual void InitSpwaner()
    {
    
    }
    protected virtual bool CanAddProxyEvent()
    {
        UnityEngine.Debug.LogError(message:  -1313149856);
        return false;
    }
    protected virtual bool ShouldRemoveProxyEvent(WGEventHandler handler)
    {
        UnityEngine.Debug.LogError(message:  -1313033488);
        return false;
    }
    private System.Type GetMyProxyEventHandlerType()
    {
        var val_2;
        var val_3;
        val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 16];
        val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 16;
        val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 16 + 186];
        val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 16 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 16 + 186];
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 16 + 186;
        }
        
        if((val_3 & 512) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 16];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 16;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 16 + 116) == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 16];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 16;
        }
        
        }
        
        System.Type val_1 = this.GetType();
        if((__RuntimeMethodHiddenParam + 12 + 96 + 16 + 92) != 0)
        {
                return __RuntimeMethodHiddenParam + 12 + 96 + 16 + 92.Item[-1312892064];
        }
        
        return __RuntimeMethodHiddenParam + 12 + 96 + 16 + 92.Item[-1312892064];
    }
    protected virtual void PopulateProxyEvent(ref GameEventV2 proxyEvent)
    {
    
    }
    protected virtual void UpdateProxyEventHandler(ref WGEventHandler proxyEventHandler)
    {
    
    }
    protected virtual object AddProxyEventHandler(ref System.Collections.Generic.List<WGEventHandler> existingEventHandlers)
    {
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_8;
        if(this == 0)
        {
                return;
        }
        
        GameEventV2 val_1 = new GameEventV2();
        typeof(GameEventV2).__il2cppRuntimeField_38 = this;
        val_8 = null;
        val_8 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  -1312532656, method:  __RuntimeMethodHiddenParam + 12 + 96 + 36);
        object val_3 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  existingEventHandlers, predicate:  7720960);
        if(existingEventHandlers != 0)
        {
                return;
        }
        
        val_8 = this;
        object val_4 = System.Activator.CreateInstance(type:  -1312532656);
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(321138688)});
        if(val_8 == 0)
        {
            goto label_9;
        }
        
        if(this == 0)
        {
            goto label_10;
        }
        
        if(this == 0)
        {
            goto label_11;
        }
        
        val_8 = this;
        if(val_8 == 0)
        {
            goto label_12;
        }
        
        existingEventHandlers.Add(item:  -1312532656);
        return;
        label_9:
        string val_6 = -1312556912(-1312556912) + -1312532656(-1312532656);
        UnityEngine.Debug.LogError(message:  -1312556912);
        return;
        label_12:
        string val_7 = -1312556784(-1312556784) + -1312532656(-1312532656);
        UnityEngine.Debug.LogWarning(message:  -1312556784);
        return;
        label_11:
        label_10:
    }
    protected virtual object RemoveExpiredProxyEventHandler(ref System.Collections.Generic.List<WGEventHandler> existingEventHandlers)
    {
        com.adjust.sdk.JSONNode val_9;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_11 = this;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_12 = 4;
        goto label_1;
        label_22:
        if((existingEventHandlers + 12) <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Type val_2 = existingEventHandlers + 8 + 16.GetType();
        val_13 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 16 + 186];
        val_13 = __RuntimeMethodHiddenParam + 12 + 96 + 16 + 186;
        if(val_13 == 1)
        {
                val_13 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 16 + 186];
            val_13 = __RuntimeMethodHiddenParam + 12 + 96 + 16 + 186;
        }
        
        System.Type val_3 = this.GetType();
        string val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 16 + 92.Item[-1312408528];
        if((System.Type.op_Inequality(left:  existingEventHandlers + 8 + 16, right:  __RuntimeMethodHiddenParam + 12 + 96 + 16 + 92)) != true)
        {
                if((existingEventHandlers + 12) <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(val_11 != 0)
        {
                Add(item:  existingEventHandlers + 8 + 16);
        }
        
        }
        
        val_12 = 5;
        label_1:
        if((val_12 - 4) < (existingEventHandlers + 12))
        {
            goto label_22;
        }
        
        List.Enumerator<T> val_7 = GetEnumerator();
        val_14 = 1152921511884346992;
        label_26:
        if(MoveNext() == false)
        {
            goto label_24;
        }
        
        bool val_10 = existingEventHandlers.Remove(item:  val_9);
        goto label_26;
        label_24:
        val_14 = 0;
        val_14 = val_14 + 1;
        if(0 == 0)
        {
                return;
        }
    
    }
    protected virtual object AddProxyEventTrackingData(ref System.Collections.Generic.Dictionary<string, object> trackingData)
    {
        LocalGameEventSpawner<T> val_7;
        LocalGameEventSpawner<T> val_8;
        val_7 = this;
        if((__RuntimeMethodHiddenParam + 12 + 96 + 52) != 0)
        {
                val_8 = __RuntimeMethodHiddenParam + 12 + 96 + 52;
            mem2[0] = val_7;
        }
        else
        {
                val_8 = 8;
            mem[8] = val_7;
            val_7 = mem[8];
        }
        
        string val_1 = System.String.Format(format:  -1312312496, arg0:  -1312286128);
        if((trackingData.ContainsKey(key:  -1312312496)) != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = val_8;
            UnityEngine.Debug.LogErrorFormat(format:  -1312312416, args:  472754880);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<WGEventHandler> val_4 = GetOrderedEventHandlers();
        val_8 = null;
        val_8 = new System.Predicate<ZooTile>(object:  __RuntimeMethodHiddenParam + 12 + 96 + 52, method:  __RuntimeMethodHiddenParam + 12 + 96 + 60);
        bool val_6 = Exists(match:  8040448);
        trackingData.Add(key:  -1312312496, value:  8945664);
    }
    protected virtual string GetProxyEventTrackingName()
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = this;
        UnityEngine.Debug.LogErrorFormat(format:  -1312194112, args:  472754880);
    }
    public LocalGameEventSpawner<T>()
    {
        var val_1;
        var val_2;
        val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 20];
        val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 20;
        val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 20 + 186];
        val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 20 + 186;
        if(val_2 == 1)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 20 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 20 + 186;
        }
        
        if((val_2 & 512) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 20];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 20;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 20 + 116) == 0)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 20];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 20;
        }
        
        }
    
    }
    private static LocalGameEventSpawner<T>()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(320712704)});
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(320659456)});
        Add(key:  320712704, value:  320659456);
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(354525184)});
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(355164160)});
        Add(key:  354525184, value:  355164160);
        System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(316506112)});
        System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(316612608)});
        Add(key:  316506112, value:  316612608);
        mem2[0] = null;
    }
    private bool <AddProxyEventHandler>b__8_0(WGEventHandler p)
    {
        System.Type val_1 = p.GetType();
        return System.Type.op_Equality(left:  p, right:  -1311827536);
    }

}
