using UnityEngine;
public class SkippedLevel
{
    // Fields
    public string word;
    public int index;
    public int avgCompletionTime;
    public int skipTriggerCompletionTime;
    
    // Methods
    public SkippedLevel()
    {
    
    }
    public SkippedLevel(string word, int index, int avgCompletionTime, int skipTriggerCompletionTime)
    {
        string val_1 = word;
        val_1 = new System.Object();
        this.word = val_1;
        this.index = index;
        this.avgCompletionTime = avgCompletionTime;
        this.skipTriggerCompletionTime = skipTriggerCompletionTime;
    }
    public string ToDebugString()
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = this.word;
        float val_4 = (float)this.avgCompletionTime;
        val_4 = val_4 / 1000f;
        string val_1 = val_4.ToString(format:  -2069762048);
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        float val_5 = (float)this.skipTriggerCompletionTime;
        val_5 = val_5 / 1000f;
        string val_2 = val_5.ToString(format:  -2069762048);
        typeof(System.Object[]).__il2cppRuntimeField_1C = ;
        string val_3 = System.String.Format(format:  -2069761952, args:  472754880);
    }
    public override string ToString()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -2085463936, value:  this.word);
        Add(key:  1348647200, value:  13152256);
        Add(key:  -2085438528, value:  13152256);
        Add(key:  -2069641600, value:  13152256);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
    }
    public void Decode(System.Collections.Generic.Dictionary<string, object> encoded)
    {
        object val_1 = encoded.Item[-2085463936];
        string val_2 = encoded.ToString();
        this.word = encoded;
        object val_3 = encoded.Item[1348647200];
        string val_4 = encoded.ToString();
        this.index = System.Int32.Parse(s:  encoded);
        object val_6 = encoded.Item[-2085438528];
        string val_7 = encoded.ToString();
        this.avgCompletionTime = System.Int32.Parse(s:  encoded);
        object val_9 = encoded.Item[-2069641600];
        string val_10 = encoded.ToString();
        this.skipTriggerCompletionTime = System.Int32.Parse(s:  encoded);
    }

}
