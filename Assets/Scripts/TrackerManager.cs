using UnityEngine;
public class TrackerManager
{
    // Fields
    private static TrackerManager instance;
    private System.Collections.Generic.List<Tracker> trackers;
    private System.Collections.Generic.Queue<System.Collections.Generic.Dictionary<string, object>> cachedEvents;
    public bool logging;
    public bool queueing;
    private System.Collections.Generic.List<string> trackOnceEventsFired;
    
    // Properties
    public static TrackerManager Instance { get; }
    public System.Collections.Generic.List<Tracker> Trackers { get; }
    
    // Methods
    private TrackerManager()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.trackOnceEventsFired = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.trackers = null;
        System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_3 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
        this.cachedEvents = null;
    }
    public static TrackerManager get_Instance()
    {
        TrackerManager val_2;
        TrackerManager val_1 = null;
        val_2 = TrackerManager.instance;
        if(val_2 != 0)
        {
                return;
        }
        
        val_1 = new TrackerManager();
        TrackerManager.instance = val_1;
        val_2 = TrackerManager.instance;
    }
    public System.Collections.Generic.List<Tracker> get_Trackers()
    {
    
    }
    public void addTracker(Tracker t)
    {
        if((this.trackers.Contains(item:  t)) != false)
        {
                return;
        }
        
        this.trackers.Add(item:  t);
    }
    public void removeTracker(Tracker t)
    {
        if((this.trackers.Contains(item:  t)) == false)
        {
                return;
        }
        
        bool val_2 = this.trackers.Remove(item:  t);
    }
    public void flush()
    {
        if(this.cachedEvents != 0)
        {
                return;
        }
    
    }
    public void clearCache()
    {
        this.cachedEvents.Clear();
    }
    public void identify(string id)
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_3 != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        Dispose();
    }
    public bool find(string id)
    {
        System.Collections.Generic.List<Tracker> val_6;
        var val_7;
        val_6 = this.trackers;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((val_3 + 24.ContainsKey(key:  id)) == false)
        {
            goto label_7;
        }
        
        val_6 = mem[val_3 + 24];
        val_6 = val_3 + 24;
        if(val_6.Item[id] < 1)
        {
            goto label_7;
        }
        
        val_7 = 1;
        goto label_8;
        label_2:
        val_7 = 0;
        label_8:
        Dispose();
        return (bool)val_7;
    }
    public void track(string eventName)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.track(eventName:  eventName, data:  78753792);
    }
    public void track(string eventName, System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_11;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_16;
        string val_18;
        var val_19;
        var val_20;
        var val_21;
        TrackerManager val_22;
        var val_23;
        System.Delegate val_24;
        val_16 = data;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_18 = val_1;
            typeof(TrackerManager.<>c__DisplayClass17_0).__il2cppRuntimeField_C = eventName;
            TrackerManager.<>c__DisplayClass17_0.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = this;
        }
        else
        {
                mem[8] = this;
            val_18 = 12;
            mem[12] = eventName;
        }
        
        typeof(TrackerManager.<>c__DisplayClass17_0).__il2cppRuntimeField_10 = val_16;
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        val_19 = public static ServerHandler DefaultHandler<ServerHandler>::get_Instance();
        if((-1983121040) != 0)
        {
                WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        }
        
        CompanyDevices val_5 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
            goto label_15;
        }
        
        val_20 = null;
        val_20 = null;
        if(CompanyDevices.TrackingAllowed == false)
        {
            goto label_18;
        }
        
        label_15:
        val_19 = 1152921504893001728;
        var val_16 = 28302642;
        val_16 = 7325832 + val_16;
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        val_21 = null;
        val_22 = this;
        if(TrackingComponent.hasFinishedInitializing == true)
        {
            goto label_25;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_18;
        UnityEngine.Debug.LogWarningFormat(format:  -1983120016, args:  472754880);
        val_23 = null;
        val_23 = null;
        val_19 = 1152921504614301696;
        System.Action val_7 = new System.Action(object:  284823552, method:  new IntPtr(2311847472));
        val_24 = TrackingComponent.finishedInitializingCallback;
        System.Delegate val_8 = System.Delegate.Combine(a:  val_24, b:  7454720);
        if(val_24 == 0)
        {
            goto label_34;
        }
        
        val_22 = this;
        if(null == null)
        {
            goto label_36;
        }
        
        val_24 = 0;
        goto label_36;
        label_18:
        List.Enumerator<T> val_9 = GetEnumerator();
        label_43:
        if(MoveNext() == false)
        {
            goto label_45;
        }
        
        System.Type val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(284717056)});
        string val_13 = ToString();
        val_11.stash(trackerName:  284717056, eventName:  mem[12], data:  typeof(TrackerManager.<>c__DisplayClass17_0).__il2cppRuntimeField_10);
        goto label_43;
        label_34:
        val_24 = 0;
        val_22 = this;
        label_36:
        TrackingComponent.finishedInitializingCallback = val_24;
        label_25:
        List.Enumerator<T> val_14 = GetEnumerator();
        val_16 = 1152921511213281520;
        label_47:
        if(MoveNext() == false)
        {
            goto label_45;
        }
        
        val_11.track(eventName:  mem[12], data:  typeof(TrackerManager.<>c__DisplayClass17_0).__il2cppRuntimeField_10);
        goto label_47;
        label_45:
        Dispose();
    }
    private void trackEvent(object[] _params)
    {
        string val_6;
        if((-1982936184) == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = this.cachedEvents.Dequeue();
        string val_2 = this.cachedEvents.Item[-1982952528];
        string val_3 = this.cachedEvents.ToString();
        List.Enumerator<T> val_4 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        string val_7 = -1982948224(-1982948224) + val_6;
        UnityEngine.Debug.Log(message:  -1982948224);
        string val_8 = -1982948336(-1982948336) + this.cachedEvents;
        UnityEngine.Debug.Log(message:  -1982948336);
        val_6.track(eventName:  this.cachedEvents, data:  this.cachedEvents);
        goto label_11;
        label_7:
        Dispose();
        this.flush();
    }
    public void track(string eventName, string propertyName, object propertyValue)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  propertyName, value:  propertyValue);
        this.track(eventName:  eventName, data:  78753792);
    }
    public void trackOnce(string eventName)
    {
        if((this.trackOnceEventsFired.Contains(item:  eventName)) != false)
        {
                return;
        }
        
        this.track(eventName:  eventName);
        this.trackOnceEventsFired.Add(item:  eventName);
    }
    public void trackOnce(string eventName, string propertyName, object propertyValue)
    {
        if((this.trackOnceEventsFired.Contains(item:  eventName)) != false)
        {
                return;
        }
        
        this.track(eventName:  eventName, propertyName:  propertyName, propertyValue:  propertyValue);
        this.trackOnceEventsFired.Add(item:  eventName);
    }
    public void peopleProperty(string propertyName, string propertyValue)
    {
        var val_4;
        string val_1 = -1982352672(-1982352672) + propertyName;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        Dispose();
    }
    public void superProperty(string propertyName, string propertyValue)
    {
        var val_4;
        string val_1 = -1982215952(-1982215952) + propertyName;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        Dispose();
    }
    public void increment(string eventName, string eventValue)
    {
        var val_4;
        string val_1 = -1982079232(-1982079232) + eventName;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        Dispose();
    }
    public void peopleIncrement(string eventName, string eventValue)
    {
        var val_4;
        string val_1 = -1981942528(-1981942528) + eventName;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        Dispose();
    }
    public void trackCharge(string quantity, System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_6;
        var val_7;
        System.Collections.Generic.List<Tracker> val_8;
        var val_9;
        val_7 = 1152921504892309504;
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_8 = 0;
        if(val_8.CompanyDevice() != false)
        {
                val_9 = null;
            val_9 = null;
            if(CompanyDevices.TrackingAllowed == false)
        {
                return;
        }
        
        }
        
        string val_3 = -1981805808(-1981805808) + quantity;
        val_8 = this.trackers;
        val_7;
        List.Enumerator<T> val_4 = GetEnumerator();
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
    private void Log(string message)
    {
    
    }

}
