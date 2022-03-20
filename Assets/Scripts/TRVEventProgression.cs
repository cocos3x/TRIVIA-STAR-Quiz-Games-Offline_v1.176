using UnityEngine;
public class TRVEventProgression : EventProgression
{
    // Fields
    protected const string KEY_TIMESTAMP = "timestamp";
    protected const string KEY_LAST_PROG_TIMESTAMP = "last_prog_timestamp";
    protected const string KEY_EVENT_SHOWN = "isEventShown";
    protected const string KEY_EVENT_ID = "eventID";
    public int Timestamp;
    public int LastProgressTimestamp;
    public bool IsEventShown;
    
    // Properties
    protected virtual string PREF_EVENT_PROG { get; }
    
    // Methods
    protected virtual string get_PREF_EVENT_PROG()
    {
    
    }
    public TRVEventProgression()
    {
    
    }

}
