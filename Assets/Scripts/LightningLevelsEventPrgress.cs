using UnityEngine;
public class LightningLevelsEventPrgress : LightingEventProgress
{
    // Fields
    private const string key_current_interval = "current_interval";
    private const string key_defined_interval = "defined_interval";
    public int CurrentInterval;
    public int DefinedInterval;
    
    // Properties
    protected override string pref_event_prg { get; }
    
    // Methods
    protected override string get_pref_event_prg()
    {
    
    }
    public LightningLevelsEventPrgress()
    {
        this = new EventProgression();
        mem[1152921512020122652] = 0;
        mem[1152921512020122648] = 1;
        mem[1152921512020122656] = 0;
    }
    public override void LoadFromJSON()
    {
        var val_25;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1176546384, defaultValue:  1098586544);
        val_25 = this;
        if((System.String.IsNullOrEmpty(value:  -1176546384)) == true)
        {
                return;
        }
        
        object val_3 = MiniJSON.Json.Deserialize(json:  -1176546384);
        if((0.ContainsKey(key:  -1176570928)) != false)
        {
                string val_5 = 0.Item[-1176570928];
            mem[1152921512020235192] = System.Boolean.Parse(value:  null);
        }
        
        if((0.ContainsKey(key:  -1176570832)) != false)
        {
                string val_8 = 0.Item[-1176570832];
            mem[1152921512020235196] = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -1472372400)) != false)
        {
                string val_11 = 0.Item[-1472372400];
            mem[1152921512020235200] = System.Boolean.Parse(value:  null);
        }
        
        if((0.ContainsKey(key:  -1176570720)) != false)
        {
                string val_14 = 0.Item[-1176570720];
            mem[1152921512020235204] = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  1470901296)) != false)
        {
                string val_17 = 0.Item[1470901296];
            mem[1152921512020235208] = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -1176570608)) != false)
        {
                string val_20 = 0.Item[-1176570608];
            this.CurrentInterval = System.Int32.Parse(s:  null);
        }
        
        val_25 = "defined_interval";
        if((0.ContainsKey(key:  -1176570496)) == false)
        {
                return;
        }
        
        string val_23 = 0.Item[-1176570496];
        this.DefinedInterval = System.Int32.Parse(s:  null);
    }
    public override void SaveToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1176570928, value:  8945664);
        Add(key:  -1176570832, value:  13152256);
        Add(key:  -1472372400, value:  8945664);
        Add(key:  -1176570720, value:  13152256);
        Add(key:  1470901296, value:  13152256);
        Add(key:  -1176570608, value:  13152256);
        Add(key:  -1176570496, value:  13152256);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1176434384, value:  78753792);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        this.DeleteKey(key:  -1176322384);
    }

}
