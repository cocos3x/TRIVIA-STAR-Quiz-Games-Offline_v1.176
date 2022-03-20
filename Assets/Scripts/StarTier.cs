using UnityEngine;
public class StarTier
{
    // Fields
    public int MaximumIndex;
    public System.Collections.Generic.Dictionary<int, float> Probabilities;
    
    // Methods
    public void Decode(System.Collections.Generic.Dictionary<string, object> sourceData)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Single>();
        this.Probabilities = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = 0.GetEnumerator();
        label_7:
        if(0.MoveNext() == false)
        {
            goto label_2;
        }
        
        System.Globalization.CultureInfo val_5 = System.Globalization.CultureInfo.InvariantCulture;
        this.Probabilities.Add(key:  System.Int32.Parse(s:  null, style:  511), value:  System.Single.Parse(s:  null, provider:  0));
        goto label_7;
        label_2:
        0.Dispose();
    }
    public string ToJSON()
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  this.Probabilities);
        string val_2 = System.String.Format(format:  -345569728, arg0:  13152256, arg1:  this.Probabilities);
    }
    public void FromJSON(string json)
    {
        var val_7;
        bool val_8;
        System.Collections.Generic.Dictionary<System.Int32, System.Single> val_9;
        object val_1 = MiniJSON.Json.Deserialize(json:  json);
        val_7 = 1;
        val_8 = "tier max words";
        if((0.ContainsKey(key:  -345449376)) != false)
        {
                string val_3 = 0.Item[-345449376];
            val_8 = 0;
            this.MaximumIndex = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -345449280)) == false)
        {
                return;
        }
        
        string val_6 = 0.Item[-345449280];
        val_9 = 0;
        if(0 != 0)
        {
                val_8 = mem[1179403827];
            if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_9 = 0;
        }
        
        this.Probabilities = val_9;
    }
    public StarTier()
    {
    
    }

}
