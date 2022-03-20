using UnityEngine;
public class OnTheTrailEventProgress : EventProgression
{
    // Fields
    private const string PREF_EVENT_PROG = "ott_evt_prg";
    private const string KEY_IS_WAGON_BROKEN = "is_wagon_broken";
    private const string KEY_DAYS_REWARDED = "days_rewarded";
    private const string KEY_SAVED_DAY_PROGRESS = "saved_day_progress";
    private const string KEY_TIMESTAMP = "timestamp";
    private const string KEY_LAST_PROG_TIMESTAMP = "last_prog_timestamp";
    private const string KEY_IS_FTUX_SEEN = "is_ftux_seen";
    private const string KEY_IS_INITIALIZED = "is_initialized";
    public bool IsWagonBroken;
    public System.Collections.Generic.List<bool> DaysRewarded;
    public OnTheTrailDayProgress SavedDayProgress;
    public OnTheTrailDayProgress WagonBrokenDayProgress;
    public int Timestamp;
    public int LastProgressTimestamp;
    public bool IsFtuxSeen;
    public bool IsInitialized;
    public bool IsEventCompleted;
    
    // Methods
    public OnTheTrailEventProgress()
    {
        this.IsWagonBroken = false;
        System.Collections.Generic.List<System.Boolean> val_1 = new System.Collections.Generic.List<System.Boolean>(collection:  1054454320);
        this.DaysRewarded = null;
        this.SavedDayProgress = new System.Object();
        this.IsEventCompleted = false;
        this.IsFtuxSeen = false;
        this.IsInitialized = false;
        this.WagonBrokenDayProgress = new System.Object();
        this.Timestamp = false;
        this.LastProgressTimestamp = false;
    }
    public override void LoadFromJSON()
    {
        var val_29;
        var val_30;
        float val_31;
        float val_32;
        var val_33;
        bool val_34;
        var val_35;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1145156064, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1145156064)) == true)
        {
                return;
        }
        
        val_29 = 0;
        object val_3 = MiniJSON.Json.Deserialize(json:  -1145156064);
        if("ott_evt_prg" != 0)
        {
                if(null == null)
        {
            goto label_53;
        }
        
        }
        
        val_31 = 1;
        label_53:
        val_32 = 1152921510392296080;
        if((val_29.ContainsKey(key:  -1145155968)) != false)
        {
                string val_5 = val_29.Item[-1145155968];
            mem[1152921512051650232] = System.Boolean.Parse(value:  null);
        }
        
        if((val_29.ContainsKey(key:  -1145155856)) == false)
        {
            goto label_58;
        }
        
        string val_8 = val_29.Item[-1145155856];
        object val_9 = MiniJSON.Json.Deserialize(json:  null);
        System.Collections.Generic.List<System.Boolean> val_10 = new System.Collections.Generic.List<System.Boolean>();
        mem[1152921512051650236] = null;
        val_30 = 0;
        List.Enumerator<T> val_11 = GetEnumerator();
        val_33 = 1152921510382894416;
        label_25:
        if(MoveNext() == false)
        {
            goto label_20;
        }
        
        val_34 = 0;
        Add(item:  null);
        goto label_25;
        label_20:
        Dispose();
        val_29 = val_29;
        val_31 = val_31;
        val_32 = 1152921510392296080;
        label_58:
        if((val_29.ContainsKey(key:  1470901296)) != false)
        {
                string val_15 = val_29.Item[1470901296];
            mem[1152921512051650248] = System.Int32.Parse(s:  null);
        }
        
        if((val_29.ContainsKey(key:  -1145155760)) != false)
        {
                string val_18 = val_29.Item[-1145155760];
            mem[1152921512051650252] = System.Int32.Parse(s:  null);
        }
        
        if((val_29.ContainsKey(key:  -1145155648)) != false)
        {
                val_33 = mem[1152921512051650240];
            string val_21 = val_29.Item[-1145155648];
            val_35 = 0;
            object val_22 = MiniJSON.Json.Deserialize(json:  null);
            val_30 = val_29;
            if(val_30 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_30 = 0;
        }
        
            val_35 = val_30;
        }
        
            val_33.FromJSON(json:  0);
        }
        
        if((val_29.ContainsKey(key:  -1145155536)) != false)
        {
                string val_24 = val_29.Item[-1145155536];
            mem[1152921512051650256] = System.Boolean.Parse(value:  null);
        }
        
        if((val_29.ContainsKey(key:  -1145155440)) == false)
        {
                return;
        }
        
        string val_27 = val_29.Item[-1145155440];
        mem[1152921512051650257] = System.Boolean.Parse(value:  null);
    }
    public override void SaveToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1145155968, value:  8945664);
        string val_2 = MiniJSON.Json.Serialize(obj:  this.DaysRewarded);
        Add(key:  -1145155856, value:  this.DaysRewarded);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = this.SavedDayProgress.ToJSON();
        string val_4 = MiniJSON.Json.Serialize(obj:  this.SavedDayProgress);
        Add(key:  -1145155648, value:  this.SavedDayProgress);
        Add(key:  1470901296, value:  13152256);
        Add(key:  -1145155760, value:  13152256);
        Add(key:  -1145155536, value:  8945664);
        Add(key:  -1145155440, value:  8945664);
        string val_5 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1145156064, value:  78753792);
        bool val_6 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        this.DeleteKey(key:  -1145156064);
    }

}
