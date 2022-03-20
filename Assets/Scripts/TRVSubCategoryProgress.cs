using UnityEngine;
public class TRVSubCategoryProgress
{
    // Fields
    public System.Collections.Generic.Dictionary<int, int> seenQuestions;
    public int incorrectQuestions;
    public int quizzesComplete;
    public int crownsCollected;
    public int rank;
    public int rankProgress;
    public bool isFinished;
    
    // Properties
    public int totalQuestionsSeen { get; }
    
    // Methods
    public int get_totalQuestionsSeen()
    {
        var val_2;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = TRVSubCategoryProgress.<>c.<>9__8_0;
        if(val_4 != 0)
        {
                return System.Linq.Enumerable.Sum<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>(source:  this.seenQuestions, selector:  7720960);
        }
        
        val_4 = null;
        val_4 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Int32>(object:  TRVSubCategoryProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3826442208));
        TRVSubCategoryProgress.<>c.<>9__8_0 = val_4;
        return System.Linq.Enumerable.Sum<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>(source:  this.seenQuestions, selector:  7720960);
    }
    public int SeenQuestionsPerDifficulty(int diff)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = this.seenQuestions;
        if((val_2.ContainsKey(key:  diff)) != true)
        {
                val_2 = this.seenQuestions;
            val_2.Add(key:  diff, value:  0);
        }
        
        if(this.seenQuestions != 0)
        {
                return this.seenQuestions.Item[diff];
        }
        
        return this.seenQuestions.Item[diff];
    }
    public void ResetCat()
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        this.seenQuestions = null;
        mem[1152921512728536253] = 0;
        mem[1152921512728536249] = 0;
    }
    public string encode()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -468157344, value:  13152256);
        Add(key:  -1545439648, value:  this.seenQuestions);
        Add(key:  -468153152, value:  13152256);
        Add(key:  -1471390128, value:  13152256);
        Add(key:  -468153056, value:  13152256);
        Add(key:  -468152976, value:  13152256);
        Add(key:  -468152880, value:  8945664);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
    }
    public bool decode(string data)
    {
        string val_10;
        TRVSubCategoryProgress val_33;
        float val_34;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_35;
        float val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        val_33 = this;
        val_34 = 0;
        object val_1 = MiniJSON.Json.Deserialize(json:  data);
        val_36 = 1;
        val_37 = "progress";
        val_38 = 0;
        if((val_34.ContainsKey(key:  -1545439648)) == false)
        {
                return (bool)val_38;
        }
        
        string val_3 = val_34.Item[-1545439648];
        val_39 = 0;
        if(val_34 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_34 = 0;
        }
        
            val_39 = val_34;
        }
        
        val_35 = null;
        val_35 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(val_39 == 0)
        {
            goto label_53;
        }
        
        val_37 = 1152921510385698512;
        Dictionary.KeyCollection<TKey, TValue> val_5 = val_39.Keys;
        if(val_39.Count < 1)
        {
            goto label_53;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_7 = val_39.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_8 = GetEnumerator();
        label_17:
        if(MoveNext() == false)
        {
            goto label_12;
        }
        
        string val_12 = val_39.Item[val_10];
        val_40 = 0;
        Add(key:  System.Int32.Parse(s:  val_10), value:  1179403647);
        goto label_17;
        label_12:
        Dispose();
        val_33 = val_33;
        val_34 = val_34;
        val_36 = val_36;
        label_53:
        if(val_35 != 0)
        {
                mem[1152921512728773112] = val_35;
            val_35 = 1152921510392296080;
            val_38 = 0;
            if((val_34.ContainsKey(key:  -468157344)) == false)
        {
                return (bool)val_38;
        }
        
            string val_14 = val_34.Item[-468157344];
            val_38 = 0;
            if((System.Int32.TryParse(s:  null, result: out  int val_15 = -468008452)) == false)
        {
                return (bool)val_38;
        }
        
            if((val_34.ContainsKey(key:  -468153152)) == false)
        {
                return (bool)val_38;
        }
        
            string val_18 = val_34.Item[-468153152];
            val_38 = 0;
            if((System.Int32.TryParse(s:  null, result: out  int val_19 = -468008448)) == false)
        {
                return (bool)val_38;
        }
        
            if((val_34.ContainsKey(key:  -468152880)) == false)
        {
                return (bool)val_38;
        }
        
            string val_22 = val_34.Item[-468152880];
            val_37 = 1152921512728773136;
            val_38 = 0;
            if((System.Boolean.TryParse(value:  null, result: out  bool val_23 = true)) == false)
        {
                return (bool)val_38;
        }
        
            if((val_34.ContainsKey(key:  -468153056)) == false)
        {
                return (bool)val_38;
        }
        
            string val_26 = val_34.Item[-468153056];
            val_38 = 0;
            if((System.Int32.TryParse(s:  null, result: out  int val_27 = -468008440)) == false)
        {
                return (bool)val_38;
        }
        
            if((val_34.ContainsKey(key:  -468152976)) == false)
        {
                return (bool)val_38;
        }
        
            string val_30 = val_34.Item[-468152976];
            val_38 = System.Int32.TryParse(s:  null, result: out  int val_31 = -468008436);
            return (bool)val_38;
        }
        
        val_38 = 0;
        UnityEngine.Debug.LogError(message:  -468032592);
        return (bool)val_38;
    }
    public TRVSubCategoryProgress()
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        this.seenQuestions = null;
    }

}
