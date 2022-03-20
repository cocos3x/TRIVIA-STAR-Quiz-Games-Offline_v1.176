using UnityEngine;
public abstract class Tracker
{
    // Fields
    protected System.Collections.Generic.List<string> events;
    protected System.Collections.Generic.List<System.Text.RegularExpressions.Regex> regexEvents;
    protected System.Collections.Generic.Dictionary<string, string> eventProperties;
    protected System.Collections.Generic.Dictionary<System.Text.RegularExpressions.Regex, string> regexProperties;
    private System.Collections.Generic.Dictionary<string, int> eventCounter;
    public bool logging;
    public string tag;
    private bool isEventTrackingWorking;
    
    // Properties
    public bool IsEventTrackingWorking { get; set; }
    public System.Collections.Generic.List<string> StaticEvents { get; }
    public System.Collections.Generic.List<System.Text.RegularExpressions.Regex> DynamicEvents { get; }
    public System.Collections.Generic.Dictionary<string, int> EventCounter { get; }
    
    // Methods
    public void set_IsEventTrackingWorking(bool value)
    {
        this.isEventTrackingWorking = value;
    }
    public bool get_IsEventTrackingWorking()
    {
        return (bool)this.isEventTrackingWorking;
    }
    public System.Collections.Generic.List<string> get_StaticEvents()
    {
    
    }
    public System.Collections.Generic.List<System.Text.RegularExpressions.Regex> get_DynamicEvents()
    {
    
    }
    public System.Collections.Generic.Dictionary<string, int> get_EventCounter()
    {
    
    }
    public Tracker()
    {
        this.tag = "Tracker [info]: ";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.events = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.regexEvents = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.eventProperties = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.regexProperties = null;
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_5 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        this.eventCounter = null;
    }
    public void AddEvent(string eventName, string propertyName)
    {
        System.Collections.Generic.List<System.String> val_2 = this.events;
        if((val_2.Contains(item:  eventName)) == true)
        {
                return;
        }
        
        this.events.Add(item:  eventName);
        val_2 = this.eventCounter;
        val_2.Add(key:  eventName, value:  0);
        if(propertyName == null)
        {
                return;
        }
        
        this.eventProperties.Add(key:  eventName, value:  propertyName);
    }
    public void AddEvent(System.Text.RegularExpressions.Regex regex, string propertyName)
    {
        if((this.regexEvents.Contains(item:  regex)) == true)
        {
                return;
        }
        
        this.regexEvents.Add(item:  regex);
        this.eventCounter.Add(key:  regex, value:  0);
        if(propertyName == null)
        {
                return;
        }
        
        this.regexProperties.Add(key:  regex, value:  propertyName);
    }
    private bool listens(string eventName)
    {
        var val_4;
        var val_6;
        val_6 = 1;
        if((this.events.Contains(item:  eventName)) == true)
        {
                return (bool)val_6;
        }
        
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        if((val_4.IsMatch(input:  eventName)) == false)
        {
            goto label_6;
        }
        
        val_6 = 1;
        goto label_7;
        label_4:
        val_6 = 0;
        label_7:
        Dispose();
        return (bool)val_6;
    }
    public void stash(string trackerName, string eventName, System.Collections.Generic.Dictionary<string, object> data)
    {
        if((this.listens(eventName:  eventName)) == false)
        {
                return;
        }
        
        LogStash.Stash(stash:  trackerName, eventToTrack:  eventName, properties:  data);
    }
    public void track(string eventName, System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_15;
        string val_16;
        var val_17;
        string val_19;
        val_15 = data;
        val_16 = 35633923;
        if((this.listens(eventName:  eventName)) == false)
        {
                return;
        }
        
        if((this.eventProperties.ContainsKey(key:  eventName)) == false)
        {
            goto label_3;
        }
        
        val_17 = 1152921510375908896;
        string val_3 = this.eventProperties.Item[eventName];
        object val_4 = val_15.Item[this.eventProperties];
        string val_5 = val_15.ToString();
        val_15 = val_15;
        string val_6 = this.eventProperties.Item[eventName];
        goto label_8;
        label_3:
        System.Text.RegularExpressions.Regex val_7 = this.getRegex(eventName:  eventName);
        if(this == 0)
        {
            goto label_9;
        }
        
        val_17 = this;
        string val_8 = this.regexProperties.Item[-1985009488];
        val_16 = this.regexProperties;
        if((val_15.ContainsKey(key:  val_16)) == false)
        {
                return;
        }
        
        string val_10 = this.regexProperties.Item[-1985009488];
        object val_11 = val_15.Item[this.regexProperties];
        string val_12 = val_15.ToString();
        val_15 = val_15;
        string val_13 = this.regexProperties.Item[-1985009488];
        string val_14 = val_17.ToString();
        val_19 = val_17;
        goto label_17;
        label_9:
        label_8:
        val_19 = eventName;
        label_17:
        this.CountEvent(eventToCount:  val_19);
    }
    private System.Text.RegularExpressions.Regex getRegex(string eventName)
    {
        var val_3;
        var val_5;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_5 = val_3;
        if((val_5.IsMatch(input:  eventName)) == false)
        {
            goto label_4;
        }
        
        goto label_5;
        label_2:
        val_5 = 0;
        label_5:
        Dispose();
    }
    protected void Log(string message)
    {
        if(this.logging == false)
        {
                return;
        }
        
        string val_1 = this.tag + message;
        UnityEngine.Debug.Log(message:  this.tag);
    }
    public void ClearCounters()
    {
        string val_5;
        Dictionary.KeyCollection<TKey, TValue> val_1 = this.eventCounter.Keys;
        System.Collections.Generic.List<ZooTile> val_2 = new System.Collections.Generic.List<ZooTile>(collection:  this.eventCounter);
        List.Enumerator<T> val_3 = GetEnumerator();
        label_5:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        this.eventCounter.set_Item(key:  val_5, value:  0);
        goto label_5;
        label_3:
        Dispose();
    }
    private void CountEvent(string eventToCount)
    {
        System.Collections.Generic.Dictionary<System.String, System.Int32> val_6;
        var val_7;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        val_6 = this.eventCounter;
        if(val_6 != 0)
        {
                val_7 = val_6.Item[eventToCount];
        }
        else
        {
                val_6 = 0;
            val_7 = 0.Item[eventToCount];
        }
        
        val_6.set_Item(key:  eventToCount, value:  val_7 + 1);
    }
    public abstract void identify(string id); // 0
    public abstract void trackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> data); // 0
    public abstract void trackEvent(string eventName, string propertyName, string propertyValue); // 0
    public abstract void increment(string eventName, string eventValue); // 0
    public abstract void peopleIncrement(string eventName, string eventValue); // 0
    public abstract void peopleProperty(string propertyName, string propertyValue); // 0
    public abstract void superProperty(string propertyName, string propertyValue); // 0
    public abstract void trackCharge(string quantity, System.Collections.Generic.Dictionary<string, object> data); // 0

}
