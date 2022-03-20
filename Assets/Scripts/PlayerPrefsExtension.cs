using UnityEngine;
public class PlayerPrefsExtension
{
    // Fields
    private const string COMMA = ",";
    
    // Methods
    public static void SetStringArray(string key, System.Collections.Generic.List<string> stringArray)
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  stringArray);
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  stringArray);
    }
    public static System.Collections.Generic.List<string> GetStringArray(string key, string defaultValue, int defaultSize)
    {
        twelvegigs.sweepstakes.Distribution val_6;
        var val_7;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  key, defaultValue:  -2141227328);
        object val_3 = MiniJSON.Json.Deserialize(json:  key);
        val_7 = 0;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        Add(item:  val_6);
        goto label_10;
        label_7:
        Dispose();
    }
    public static void SetIntArray(string key, System.Collections.Generic.List<int> intArray)
    {
        var val_6 = 0;
        goto label_1;
        label_5:
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_6)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + 0;
        string val_2 = (0 + 0) + 16.ToString();
        Add(item:  -2028515272);
        val_6 = 1;
        label_1:
        if(val_6 < null)
        {
            goto label_5;
        }
        
        T[] val_3 = ToArray();
        string val_4 = System.String.Join(separator:  1492657312, value:  80883712);
        string val_5 = 1492657312 + 1492657312;
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  1492657312);
    }
    public static System.Collections.Generic.List<int> GetIntArray(string key, int defaultValue, int defaultSize)
    {
        string val_8;
        int val_9;
        var val_10;
        val_8 = key;
        int val_7 = defaultSize;
        val_9 = defaultValue;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_8)) == false)
        {
            goto label_1;
        }
        
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  val_8);
        val_8 = ",";
        typeof(System.String[]).__il2cppRuntimeField_10 = val_8;
        System.String[] val_4 = val_8.Split(separator:  477709520, options:  1);
        val_9 = val_8 + 16;
        val_10 = 0;
        goto label_7;
        label_12:
        if((System.Int32.TryParse(s:  15388672, result: out  int val_5 = -2028390984)) != false)
        {
                val_8 = 0;
            Add(item:  0);
        }
        
        val_10 = 1;
        label_7:
        if(val_10 < key.m_firstChar)
        {
            goto label_12;
        }
        
        return;
        label_1:
        if(val_7 < 1)
        {
                return;
        }
        
        val_8 = 1152921510720759024;
        do
        {
            Add(item:  val_9);
            val_7 = val_7 - 1;
        }
        while(null != 0);
    
    }
    public PlayerPrefsExtension()
    {
    
    }

}
