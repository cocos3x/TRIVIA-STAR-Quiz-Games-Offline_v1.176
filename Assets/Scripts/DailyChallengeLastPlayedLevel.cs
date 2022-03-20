using UnityEngine;
public class DailyChallengeLastPlayedLevel : DailyChallengeBasicLevel
{
    // Fields
    private const string pref_last_played_lvl = "DC_last_played_lvl";
    public int day;
    public string levelId;
    public float progress;
    public bool done;
    public bool isPersistentLevel;
    
    // Methods
    public DailyChallengeLastPlayedLevel(bool isMorning)
    {
        this = new Progression();
        System.DateTime val_2 = DateTimeCheat.Now;
        int val_3 = ???.Day;
        mem[1152921512847877340] = isMorning;
        mem[1152921512847877336] = 0;
        this.done = true;
        this.isPersistentLevel = true;
    }
    public DailyChallengeLastPlayedLevel(int day, bool isMorning, string levelId, int stars, float progress, bool done, bool isPersistentLevel)
    {
        bool val_2;
        this = new Progression();
        mem[1152921512847993436] = isMorning;
        this.day = day;
        this.levelId = levelId;
        mem[1152921512847993432] = stars;
        this.progress = done;
        this.done = isPersistentLevel;
        this.isPersistentLevel = val_2;
    }
    public override void Save()
    {
        if(this.isPersistentLevel == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1144798864, value:  13152256);
        Add(key:  -348696048, value:  8945664);
        Add(key:  -348691856, value:  this.levelId);
        Add(key:  -1930648688, value:  13152256);
        string val_2 = this.progress.ToString();
        Add(key:  -1545439648, value:  this.progress);
        string val_3 = this.done.ToString();
        Add(key:  -348691760, value:  this.done);
        string val_4 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -348691680, value:  78753792);
        bool val_5 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Load()
    {
        var val_22;
        if(this.isPersistentLevel == false)
        {
                return;
        }
        
        val_22 = "DC_last_played_lvl";
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -348691680, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -348691680)) == true)
        {
                return;
        }
        
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -348691680, defaultValue:  1098586544);
        object val_4 = MiniJSON.Json.Deserialize(json:  -348691680);
        if("DC_last_played_lvl" != 0)
        {
                if(null == null)
        {
            goto label_33;
        }
        
        }
        
        label_33:
        if((0.ContainsKey(key:  -1144798864)) != false)
        {
                string val_6 = 0.Item[-1144798864];
            this.day = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -348696048)) != false)
        {
                string val_9 = 0.Item[-348696048];
            mem[1152921512848230108] = System.Boolean.Parse(value:  null);
        }
        
        if((0.ContainsKey(key:  -348691856)) != false)
        {
                string val_12 = 0.Item[-348691856];
            this.levelId = 0;
        }
        
        if((0.ContainsKey(key:  -1930648688)) != false)
        {
                string val_14 = 0.Item[-1930648688];
            mem[1152921512848230104] = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -1545439648)) != false)
        {
                string val_17 = 0.Item[-1545439648];
            float val_18 = System.Single.Parse(s:  null);
            this.progress = 0;
        }
        
        val_22 = "done";
        if((0.ContainsKey(key:  -348691760)) == false)
        {
                return;
        }
        
        string val_20 = 0.Item[-348691760];
        this.done = System.Boolean.Parse(value:  null);
    }

}
