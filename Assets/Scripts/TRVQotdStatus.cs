using UnityEngine;
public class TRVQotdStatus : EventProgression
{
    // Fields
    private const string PREF_TRV_QOTD_STATUS = "trv_qotd_status";
    private const string KEY_LAST_FINISHED_TIME = "last_finished_time";
    private const string KEY_LAST_LPN_SETUP_TIME = "last_lpn_setup_time";
    private bool playing;
    public System.DateTime LastFinishedTime;
    
    // Properties
    public bool IsPlaying { get; set; }
    
    // Methods
    public bool get_IsPlaying()
    {
        return (bool)this.playing;
    }
    public void set_IsPlaying(bool value)
    {
        this.playing = value;
    }
    public override void LoadFromJSON()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1612934944)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1612934944);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1612934944);
        if("trv_qotd_status" != 0)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        label_10:
        if((0.ContainsKey(key:  -1612934832)) == false)
        {
                return;
        }
        
        string val_5 = 0.Item[-1612934832];
        bool val_6 = System.DateTime.TryParse(s:  null, result: out  new System.DateTime() {dateData = this.LastFinishedTime});
    }
    public override void SaveToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_2 = this.LastFinishedTime.ToString();
        Add(key:  -1612934832, value:  this.LastFinishedTime);
        string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1612934944, value:  78753792);
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public TRVQotdStatus()
    {
    
    }

}
