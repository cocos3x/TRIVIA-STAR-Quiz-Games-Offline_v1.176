using UnityEngine;
public class TriviaPursuitEventProgress : TRVEventProgression
{
    // Fields
    private const string KEY_SELECTED_CATEGORIES = "categories";
    private const string KEY_NEXT_TP_LEVEL = "nextTPLevel";
    public System.Collections.Generic.List<TriviaPursuitCategory> SelectedCategories;
    public int NextTPLevel;
    
    // Properties
    protected override string PREF_EVENT_PROG { get; }
    
    // Methods
    protected override string get_PREF_EVENT_PROG()
    {
    
    }
    public override void LoadFromJSON()
    {
        string val_27;
        var val_29;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_30;
        float val_31;
        var val_32;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -398175280)) == false)
        {
                return;
        }
        
        val_29 = 0;
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -398175280);
        object val_3 = MiniJSON.Json.Deserialize(json:  -398175280);
        val_31 = 1152921510392296080;
        if((val_29.ContainsKey(key:  1470901296)) != false)
        {
                string val_5 = val_29.Item[1470901296];
            bool val_7 = System.Int32.TryParse(s:  null, result: out  int val_6 = -398175272);
        }
        
        if((val_29.ContainsKey(key:  -1145155760)) != false)
        {
                string val_9 = val_29.Item[-1145155760];
            bool val_11 = System.Int32.TryParse(s:  null, result: out  int val_10 = -398175268);
        }
        
        if((val_29.ContainsKey(key:  -411884912)) != false)
        {
                string val_13 = val_29.Item[-411884912];
            val_30 = 1152921512798606304;
            bool val_15 = System.Boolean.TryParse(value:  null, result: out  bool val_14 = true);
        }
        
        if((val_29.ContainsKey(key:  -398199376)) != false)
        {
                string val_17 = val_29.Item[-398199376];
            bool val_19 = System.Int32.TryParse(s:  null, result: out  this.NextTPLevel);
        }
        
        if((val_29.ContainsKey(key:  -1924037472)) == false)
        {
                return;
        }
        
        val_32 = 1152921510385703632;
        string val_21 = val_29.Item[-1924037472];
        if(val_29 == 0)
        {
                return;
        }
        
        val_30 = null;
        val_30 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        string val_23 = val_29.Item[-1924037472];
        object val_24 = MiniJSON.Json.Deserialize(json:  null);
        val_29 = 0;
        List.Enumerator<T> val_25 = GetEnumerator();
        val_31 = 1152921504973033472;
        val_32 = 1152921512794565232;
        label_39:
        if(MoveNext() == false)
        {
            goto label_35;
        }
        
        object val_28 = new System.Object();
        Parse(data:  val_27);
        Add(item:  366186496);
        goto label_39;
        label_35:
        Dispose();
        this.SelectedCategories = val_30;
    }
    public override void SaveToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1470901296, value:  13152256);
        Add(key:  -1145155760, value:  13152256);
        Add(key:  -411884912, value:  8945664);
        Add(key:  -398199376, value:  13152256);
        string val_2 = MiniJSON.Json.Serialize(obj:  this.SelectedCategories);
        Add(key:  -1924037472, value:  this.SelectedCategories);
        string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -398059184, value:  78753792);
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public TriviaPursuitEventProgress()
    {
        Player val_1 = App.Player;
        this.NextTPLevel = 0;
    }

}
