using UnityEngine;
public class FPHQotdStatus : EventProgression
{
    // Fields
    private const string PREF_TRV_QOTD_STATUS = "trv_qotd_status";
    private const string KEY_LAST_FINISHED_TIME = "last_finished_time";
    private const string KEY_LAST_LPN_SETUP_TIME = "last_lpn_setup_time";
    private const string LEVEL_DATA = "level_data";
    private const string KEY_PROGRESS = "qotd_prog";
    public bool IsPlaying;
    public System.DateTime LastPlayedTime;
    public System.DateTime LastLPNSetupTime;
    public int qotdProgress;
    public string savedLevelData;
    
    // Methods
    public override void LoadFromJSON()
    {
        System.DateTime val_16;
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
            goto label_24;
        }
        
        }
        
        label_24:
        if((0.ContainsKey(key:  -1612934832)) != false)
        {
                string val_5 = 0.Item[-1612934832];
            val_16 = this.LastPlayedTime;
            bool val_6 = System.DateTime.TryParse(s:  null, result: out  new System.DateTime() {dateData = val_16});
        }
        
        if((0.ContainsKey(key:  -1612934720)) != false)
        {
                string val_8 = 0.Item[-1612934720];
            val_16 = this.LastLPNSetupTime;
            bool val_9 = System.DateTime.TryParse(s:  null, result: out  new System.DateTime() {dateData = val_16});
        }
        
        if((0.ContainsKey(key:  -1612934608)) != false)
        {
                string val_11 = 0.Item[-1612934608];
            this.savedLevelData = 0;
        }
        
        if((0.ContainsKey(key:  -1612934512)) == false)
        {
                return;
        }
        
        string val_13 = 0.Item[-1612934512];
        bool val_15 = System.Int32.TryParse(s:  null, result: out  this.qotdProgress);
    }
    public override void SaveToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_2 = this.LastPlayedTime.ToString();
        Add(key:  -1612934832, value:  this.LastPlayedTime);
        string val_3 = this.LastLPNSetupTime.ToString();
        Add(key:  -1612934720, value:  this.LastLPNSetupTime);
        Add(key:  -1612934608, value:  this.savedLevelData);
        Add(key:  -1612934512, value:  13152256);
        string val_4 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1612934944, value:  78753792);
        bool val_5 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public FPHQotdStatus()
    {
    
    }

}
