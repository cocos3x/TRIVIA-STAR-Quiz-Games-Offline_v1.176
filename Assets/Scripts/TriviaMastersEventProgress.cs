using UnityEngine;
public class TriviaMastersEventProgress : TRVEventProgression
{
    // Fields
    private const string KEY_TOKENS = "tokens";
    private const string KEY_NEXT_LEVEL = "nextTMLevel";
    public int Tokens;
    public int NextTMLevel;
    public string SelectedCategory;
    public bool IsPlayingTMQuiz;
    
    // Properties
    protected override string PREF_EVENT_PROG { get; }
    
    // Methods
    protected override string get_PREF_EVENT_PROG()
    {
    
    }
    public override void LoadFromJSON()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -391683888)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -391683888);
        object val_3 = MiniJSON.Json.Deserialize(json:  -391683888);
        if((0.ContainsKey(key:  1470901296)) != false)
        {
                string val_5 = 0.Item[1470901296];
            bool val_7 = System.Int32.TryParse(s:  null, result: out  int val_6 = -391683880);
        }
        
        if((0.ContainsKey(key:  -1145155760)) != false)
        {
                string val_9 = 0.Item[-1145155760];
            bool val_11 = System.Int32.TryParse(s:  null, result: out  int val_10 = -391683876);
        }
        
        if((0.ContainsKey(key:  -391708064)) != false)
        {
                string val_13 = 0.Item[-391708064];
            bool val_15 = System.Int32.TryParse(s:  null, result: out  this.Tokens);
        }
        
        if((0.ContainsKey(key:  -391707984)) != false)
        {
                string val_17 = 0.Item[-391707984];
            bool val_19 = System.Int32.TryParse(s:  null, result: out  this.NextTMLevel);
        }
        
        if((0.ContainsKey(key:  -411884912)) == false)
        {
                return;
        }
        
        string val_21 = 0.Item[-411884912];
        bool val_23 = System.Boolean.TryParse(value:  null, result: out  bool val_22 = true);
    }
    public override void SaveToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1470901296, value:  13152256);
        Add(key:  -1145155760, value:  13152256);
        Add(key:  -391708064, value:  13152256);
        Add(key:  -391707984, value:  13152256);
        Add(key:  -411884912, value:  8945664);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -391571888, value:  78753792);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        UnityEngine.PlayerPrefs.DeleteKey(key:  -391459888);
    }
    public TriviaMastersEventProgress()
    {
        Player val_1 = App.Player;
        this.NextTMLevel = 0;
    }

}
