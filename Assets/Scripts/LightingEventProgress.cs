using UnityEngine;
public class LightingEventProgress : EventProgression
{
    // Fields
    protected const string key_is_ftux = "is_ftux";
    protected const string key_completed_levels = "completed_levels";
    protected const string key_rewarded = "rewarded";
    protected const string key_last_prg_timestamp = "last_prg_timestamp";
    protected const string key_timestamp = "timestamp";
    public bool IsFTUX;
    public int CompletedCount;
    public bool Rewarded;
    public int LastProgressTimeStamp;
    public int Timestamp;
    
    // Properties
    protected virtual string pref_event_prg { get; }
    
    // Methods
    protected virtual string get_pref_event_prg()
    {
    
    }
    public LightingEventProgress()
    {
    
    }

}
