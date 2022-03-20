using UnityEngine;
public class ForestFrenzyEventProgress : MonoBehaviour
{
    // Fields
    private const string PREFKEY_EVENT_ID = "ffe_id";
    private const string PREFKEY_CURRENCY = "ffe_c";
    private const string PREFKEY_FOREST_MAPDATA = "ffe_map";
    private const string PREFKEY_REWARDED = "ffe_rwd";
    private const int tropical_level_index = 1;
    private static int accumulatedCurrency;
    private static bool hasRewarded;
    public static WordForest.Map forestMapData;
    
    // Properties
    public static int currentForestID { get; }
    public static string forestMapDataJson { get; }
    public static int AccumulatedCurrency { get; }
    public static bool HasRewarded { get; set; }
    
    // Methods
    public static int get_currentForestID()
    {
        return 1;
    }
    public static string get_forestMapDataJson()
    {
        null = null;
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  ForestFrenzyEventProgress.forestMapData);
    }
    public static int get_AccumulatedCurrency()
    {
        null = null;
        return (int)ForestFrenzyEventProgress.accumulatedCurrency;
    }
    public static bool get_HasRewarded()
    {
        null = null;
        return (bool)ForestFrenzyEventProgress.hasRewarded;
    }
    public static void set_HasRewarded(bool value)
    {
        null = null;
        ForestFrenzyEventProgress.hasRewarded = value;
        UnityEngine.PlayerPrefs.SetInt(key:  -1397236384, value:  ForestFrenzyEventProgress.hasRewarded);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static void Init(GameEventV2 gameEventV2)
    {
        ForestFrenzyEventProgress.LoadFromLocal(gameEventV2:  gameEventV2);
    }
    public static void AddCurrency(int amount)
    {
        null = null;
        int val_2 = ForestFrenzyEventProgress.accumulatedCurrency;
        val_2 = val_2 + amount;
        ForestFrenzyEventProgress.accumulatedCurrency = val_2;
        UnityEngine.PlayerPrefs.SetInt(key:  -1397004096, value:  ForestFrenzyEventProgress.accumulatedCurrency);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static void DeductCurrency(int amount)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        int val_2 = ForestFrenzyEventProgress.accumulatedCurrency;
        val_2 = val_2 - amount;
        ForestFrenzyEventProgress.accumulatedCurrency = val_2;
        val_3 = null;
        if(ForestFrenzyEventProgress.accumulatedCurrency <= 1)
        {
                ForestFrenzyEventProgress.accumulatedCurrency = 0;
            val_3 = null;
        }
        
        val_3 = null;
        UnityEngine.PlayerPrefs.SetInt(key:  -1397004096, value:  0);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public static void UpdateForestMapData()
    {
        null = null;
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  ForestFrenzyEventProgress.forestMapData);
        UnityEngine.PlayerPrefs.SetString(key:  -1396780016, value:  ForestFrenzyEventProgress.forestMapData);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private static void LoadFromLocal(GameEventV2 gameEventV2)
    {
        var val_10;
        var val_11;
        var val_12;
        if(gameEventV2.id == (UnityEngine.PlayerPrefs.GetInt(key:  -1396663824, defaultValue:  0)))
        {
                string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1396780016, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  -1396780016)) != true)
        {
                object val_4 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1396780016);
            val_10 = null;
            val_10 = null;
            ForestFrenzyEventProgress.forestMapData = "ffe_map";
        }
        
            val_11 = null;
            val_11 = null;
            ForestFrenzyEventProgress.accumulatedCurrency = UnityEngine.PlayerPrefs.GetInt(key:  -1397004096, defaultValue:  0);
            int val_6 = UnityEngine.PlayerPrefs.GetInt(key:  -1397236384, defaultValue:  0);
            val_6 = val_6 - 1;
            val_6 = val_6 >> 5;
            ForestFrenzyEventProgress.hasRewarded = val_6;
            return;
        }
        
        WordForest.Map val_7 = ForestFrenzyEcon.CreateMap(forestLevel:  1, growthLevel:  0, growthPercent:  null);
        val_12 = null;
        val_12 = null;
        ForestFrenzyEventProgress.forestMapData = 1;
        ForestFrenzyEventProgress.accumulatedCurrency = 0;
        ForestFrenzyEventProgress.hasRewarded = 0;
        UnityEngine.PlayerPrefs.SetInt(key:  -1396663824, value:  gameEventV2.id);
        string val_8 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  1);
        UnityEngine.PlayerPrefs.SetString(key:  -1396780016, value:  1);
        UnityEngine.PlayerPrefs.SetInt(key:  -1397004096, value:  0);
        UnityEngine.PlayerPrefs.SetInt(key:  -1397236384, value:  0);
        bool val_9 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public ForestFrenzyEventProgress()
    {
    
    }
    private static ForestFrenzyEventProgress()
    {
    
    }

}
