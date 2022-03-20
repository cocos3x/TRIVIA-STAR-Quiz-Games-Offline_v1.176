using UnityEngine;
public class AggregateEventCalculator
{
    // Fields
    private decimal aggregate;
    private string name;
    
    // Properties
    public decimal Aggregate { get; }
    private System.Collections.Generic.Dictionary<string, object> JSONDictionary { get; }
    
    // Methods
    public decimal get_Aggregate()
    {
        return new System.Decimal() {flags = -1991920592, hi = R1 + 8};
    }
    private System.Collections.Generic.Dictionary<string, object> get_JSONDictionary()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1679334848, value:  this.name);
        Add(key:  -1991828496, value:  10170368);
    }
    public AggregateEventCalculator(string name)
    {
        string val_1 = -1991708208(-1991708208) + name;
        this.name = "aggregate_event_calculator_";
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1991708208)) == false)
        {
                return;
        }
        
        this.Load();
    }
    private void Load()
    {
        var val_5;
        var val_6;
        val_5 = 0;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  this.name);
        object val_2 = MiniJSON.Json.Deserialize(json:  this.name);
        if(this.name != null)
        {
                if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                this.name = 0;
        }
        
            val_5 = this.name;
        }
        
        twelvegigs.storage.JsonDictionary val_3 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  0);
        val_6 = null;
        val_6 = null;
        decimal val_4 = getDecimal(key:  458731520, defaultValue:  new System.Decimal() {flags = -1991828496, hi = System.Decimal.Zero, lo = ???, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
    }
    public void Calculate(decimal valueToAggregate, bool autoFlush = False)
    {
        int val_6;
        decimal val_7;
        int val_8;
        int val_9;
        val_6 = valueToAggregate.mid;
        val_6 = val_6;
        val_7 = 0;
        decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1991447328, hi = this.aggregate, lo = R6, mid = R7}, d2:  new System.Decimal() {flags = ???, hi = valueToAggregate.flags, lo = valueToAggregate.hi, mid = valueToAggregate.lo});
        decimal val_2 = new System.Decimal(lo:  0, mid:  0, hi:  0, isNegative:  false, scale:  0);
        val_8 = val_2.hi;
        val_9 = val_2.flags;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_9, hi = val_8, lo = val_2.lo, mid = val_2.flags})) == true)
        {
            goto label_3;
        }
        
        if(autoFlush == false)
        {
            goto label_4;
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  this.name, value:  -1991435264);
        label_3:
        val_7 = this.aggregate;
        decimal val_4 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1991447328, hi = val_7, lo = val_9, mid = val_8}, d2:  new System.Decimal() {flags = this.name, hi = valueToAggregate.flags, lo = valueToAggregate.hi, mid = valueToAggregate.lo});
        UnityEngine.PlayerPrefs.SetString(key:  this.name, value:  -1991435264);
        return;
        label_4:
        string val_5 = System.String.Format(format:  -1991463600, arg0:  this.name);
        UnityEngine.Debug.LogError(message:  -1991463600);
    }
    public void Flush()
    {
        UnityEngine.PlayerPrefs.SetString(key:  this.name, value:  -1991306880);
    }
    public override string ToString()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = this.JSONDictionary;
        return MiniJSON.Json.Serialize(obj:  -1991190784);
    }

}
