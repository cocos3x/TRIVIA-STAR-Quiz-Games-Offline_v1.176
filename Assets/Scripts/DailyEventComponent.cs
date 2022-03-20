using UnityEngine;
public class DailyEventComponent
{
    // Fields
    private System.DateTime updatedAt;
    public string name;
    
    // Properties
    private System.Collections.Generic.Dictionary<string, object> JSONDictionary { get; }
    
    // Methods
    private System.Collections.Generic.Dictionary<string, object> get_JSONDictionary()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1679334848, value:  this.name);
        Add(key:  -1990281616, value:  9904128);
    }
    public DailyEventComponent(string name)
    {
        string val_1 = -1990161328(-1990161328) + name;
        this.name = "daily_event_component_";
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1990161328)) != false)
        {
                this.Load();
            return;
        }
        
        this.Reset();
    }
    private void Load()
    {
        System.DateTime val_10;
        var val_11;
        var val_12;
        val_11 = 0;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  this.name);
        object val_2 = MiniJSON.Json.Deserialize(json:  this.name);
        val_12 = this.name;
        if(val_12 != null)
        {
                if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_12 = 0;
        }
        
            val_11 = val_12;
        }
        
        twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  0);
        string val_4 = getString(key:  -1990281616, defaultValue:  1098586544);
        System.DateTime val_5 = System.DateTime.UtcNow;
        System.DateTime val_8 = SLCDateTime.Parse(dateTime:  -1990029064, defaultValue:  new System.DateTime() {dateData = 1152921505065578496});
        this.updatedAt = val_10;
    }
    public bool IsTracked()
    {
        ulong val_3;
        var val_6;
        var val_9;
        var val_10;
        val_9 = 0;
        val_10 = null;
        val_10 = null;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = this.updatedAt}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) == true)
        {
                return true;
        }
        
        System.DateTime val_2 = System.DateTime.UtcNow;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511206868584}, d2:  new System.DateTime() {dateData = val_3});
        double val_8 = val_6.TotalDays;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished < 0)
        {
                val_9 = 1;
        }
        
        return true;
    }
    public void Reset()
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        this.updatedAt = new System.DateTime();
        UnityEngine.PlayerPrefs.SetString(key:  this.name, value:  -1989784832);
    }
    public override string ToString()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = this.JSONDictionary;
        return MiniJSON.Json.Serialize(obj:  -1989668736);
    }

}
