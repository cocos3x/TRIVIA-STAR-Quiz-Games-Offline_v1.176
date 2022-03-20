using UnityEngine;
public class StarChampionshipEventProgress : TRVEventProgression
{
    // Fields
    private const string KEY_STARS = "stars";
    private const string KEY_REWARDED = "rewarded";
    public int Stars;
    public bool Rewarded;
    
    // Properties
    protected override string PREF_EVENT_PROG { get; }
    
    // Methods
    protected override string get_PREF_EVENT_PROG()
    {
    
    }
    public override void LoadFromJSON()
    {
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -411860816)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -411860816);
        object val_3 = MiniJSON.Json.Deserialize(json:  -411860816);
        val_30 = "eventID";
        if((0.ContainsKey(key:  -411885008)) == false)
        {
            goto label_5;
        }
        
        val_31 = 1152921510385703632;
        string val_5 = 0.Item[-411885008];
        val_30 = 0;
        val_32 = mem[TRVStarChampionshipEventHandler.<Instance>k__BackingField + 8];
        val_32 = TRVStarChampionshipEventHandler.<Instance>k__BackingField + 8;
        string val_6 = val_32 + 48;
        string val_7 = val_6.ToString();
        if((System.String.op_Inequality(a:  null, b:  val_6)) == false)
        {
            goto label_11;
        }
        
        label_5:
        UnityEngine.PlayerPrefs.DeleteKey(key:  -411860816);
        return;
        label_11:
        if((0.ContainsKey(key:  1470901296)) != false)
        {
                string val_10 = 0.Item[1470901296];
            bool val_12 = System.Int32.TryParse(s:  null, result: out  int val_11 = -411860808);
        }
        
        if((0.ContainsKey(key:  -1145155760)) != false)
        {
                string val_14 = 0.Item[-1145155760];
            bool val_16 = System.Int32.TryParse(s:  null, result: out  int val_15 = -411860804);
        }
        
        if((0.ContainsKey(key:  -1930648688)) != false)
        {
                string val_18 = 0.Item[-1930648688];
            bool val_20 = System.Int32.TryParse(s:  null, result: out  this.Stars);
        }
        
        if((0.ContainsKey(key:  -1472372400)) != false)
        {
                val_33 = val_31;
            string val_22 = 0.Item[-1472372400];
            bool val_24 = System.Boolean.TryParse(value:  null, result: out  this.Rewarded);
            val_31 = val_33;
        }
        
        if((0.ContainsKey(key:  -411884912)) == false)
        {
                return;
        }
        
        string val_26 = 0.Item[-411884912];
        bool val_28 = System.Boolean.TryParse(value:  null, result: out  bool val_27 = true);
    }
    public override void SaveToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1470901296, value:  13152256);
        Add(key:  -1145155760, value:  13152256);
        Add(key:  -1930648688, value:  13152256);
        Add(key:  -1472372400, value:  8945664);
        Add(key:  -411884912, value:  8945664);
        Add(key:  -411885008, value:  13152256);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -411748816, value:  78753792);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -411636816)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    public StarChampionshipEventProgress()
    {
    
    }

}
