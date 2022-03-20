using UnityEngine;
public class LimitedTimeBundlesStatus : EventProgression
{
    // Fields
    private const string PREF_STATUS = "ltb_status";
    private const string PREF_LEGACY_POPUP_LVL = "ltb_popup_lvl";
    private const string KEY_CURRENT_OFFER_END_TIME = "end";
    private const string KEY_POPUP_LVL = "lvl";
    private const string KEY_SHOWN_TIMES = "shown";
    public System.DateTime CurrentOfferEndTime;
    public int LevelsSincePopupShown;
    public int TimesPopupShown;
    
    // Methods
    public override void LoadFromJSON()
    {
        ulong val_10;
        System.DateTime val_21;
        var val_22;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1159100336, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1159100336)) != false)
        {
                if((UnityEngine.PlayerPrefs.HasKey(key:  -1159100240)) != false)
        {
                this.LevelsSincePopupShown = UnityEngine.PlayerPrefs.GetInt(key:  -1159100240, defaultValue:  0);
        }
        
            UnityEngine.PlayerPrefs.DeleteKey(key:  -1159100240);
            return;
        }
        
        object val_5 = MiniJSON.Json.Deserialize(json:  -1159100336);
        if("ltb_status" != 0)
        {
                if(null == null)
        {
            goto label_22;
        }
        
        }
        
        label_22:
        if((0.ContainsKey(key:  1956545360)) != false)
        {
                string val_7 = 0.Item[1956545360];
            val_22 = 0;
            val_21 = this.CurrentOfferEndTime;
            bool val_8 = System.DateTime.TryParse(s:  null, result: out  new System.DateTime() {dateData = val_21});
            System.DateTime val_9 = DateTimeCheat.Now;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_10}, t2:  new System.DateTime() {dateData = this.CurrentOfferEndTime})) == true)
        {
                return;
        }
        
        }
        
        if((0.ContainsKey(key:  -1640018224)) != false)
        {
                string val_14 = 0.Item[-1640018224];
            bool val_16 = System.Int32.TryParse(s:  null, result: out  this.LevelsSincePopupShown);
        }
        
        val_22 = "shown";
        if((0.ContainsKey(key:  -1159100144)) == false)
        {
                return;
        }
        
        string val_18 = 0.Item[-1159100144];
        bool val_20 = System.Int32.TryParse(s:  null, result: out  this.TimesPopupShown);
    }
    public override void SaveToJSON()
    {
        int val_6;
        var val_7;
        var val_11;
        System.DateTime val_12;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_11 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  -1566656096)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.DateTime val_5 = GetCurrentOfferEndTime();
            val_12 = val_6;
            val_11 = val_7;
        }
        else
        {
                val_12 = this.CurrentOfferEndTime;
        }
        
        string val_8 = val_12.ToString();
        Add(key:  1956545360, value:  -1158976104);
        val_6 = this.LevelsSincePopupShown;
        Add(key:  -1640018224, value:  13152256);
        Add(key:  -1159100144, value:  13152256);
        string val_9 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1159100336, value:  78753792);
        bool val_10 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public LimitedTimeBundlesStatus()
    {
    
    }

}
