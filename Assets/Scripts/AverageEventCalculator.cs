using UnityEngine;
public class AverageEventCalculator
{
    // Fields
    private float average;
    private int total;
    private string name;
    
    // Properties
    public float Average { get; }
    private System.Collections.Generic.Dictionary<string, object> JSONDictionary { get; }
    
    // Methods
    public float get_Average()
    {
        return (float)S0;
    }
    private System.Collections.Generic.Dictionary<string, object> get_JSONDictionary()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1679334848, value:  this.name);
        Add(key:  -1990986688, value:  15282176);
        Add(key:  -1990986592, value:  13152256);
    }
    public AverageEventCalculator(string name)
    {
        string val_1 = -1990866320(-1990866320) + name;
        this.name = "average_event_calculator_";
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1990866320)) == false)
        {
                return;
        }
        
        this.Load();
    }
    private void Load()
    {
        var val_7;
        var val_8;
        val_7 = 0;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  this.name);
        object val_2 = MiniJSON.Json.Deserialize(json:  this.name);
        val_8 = this.name;
        if(val_8 != null)
        {
                if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_8 = 0;
        }
        
            val_7 = val_8;
        }
        
        twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  0);
        if(null != 0)
        {
                this.total = getInt(key:  -1990986592, defaultValue:  0);
        }
        else
        {
                this.total = getInt(key:  -1990986592, defaultValue:  0);
        }
        
        float val_6 = getFloat(key:  -1990986688, defaultValue:  null);
        this.average = null;
    }
    public void Calculate(float valueToAdd)
    {
        float val_1 = R1;
        if(this.total == (-2147483647))
        {
                this.total = 1;
            this.total = this.total;
        }
        
        this.total = 2;
        val_1 = val_1 / 2f;
        this.average = val_1;
        UnityEngine.PlayerPrefs.SetString(key:  this.name, value:  -1990601808);
    }
    public float CalculateCurrent(float valueToAdd)
    {
        var val_1 = R1;
        if(this.total == (-2147483647))
        {
                this.total = 1;
        }
        
        if(this.total == (-2147483647))
        {
                this.total = this.total;
        }
        
        val_1 = val_1 / 2f;
        return (float)val_1;
    }
    public override string ToString()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = this.JSONDictionary;
        return MiniJSON.Json.Serialize(obj:  -1990373712);
    }

}
