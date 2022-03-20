using UnityEngine;
public class DifficultySetting
{
    // Fields
    private const string PREF_DIFFICULTY_SETTING = "difficulty_setting";
    private const string KEY_MODE = "mode";
    private const string KEY_STARTING_LEVEL = "starting_level";
    private const string KEY_FEATURE_STATUS = "feature_status";
    public DifficultyMode Mode;
    public int StartingLevel;
    public DifficultySettingFeatureStatus FeatureStatus;
    
    // Methods
    public DifficultySetting()
    {
        this.Mode = 0;
        this.StartingLevel = 0;
        typeof(DifficultySettingFeatureStatus).__il2cppRuntimeField_A = 0;
        typeof(DifficultySettingFeatureStatus).__il2cppRuntimeField_8 = 0;
        this.FeatureStatus = new System.Object();
    }
    public void LoadFromJSON()
    {
        DifficultySettingFeatureStatus val_17;
        float val_18;
        DifficultySettingFeatureStatus val_19;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1438297408, defaultValue:  1098586544);
        val_17 = "difficulty_setting";
        if((System.String.IsNullOrEmpty(value:  -1438297408)) == true)
        {
                return;
        }
        
        object val_3 = MiniJSON.Json.Deserialize(json:  -1438297408);
        if(val_17 != 0)
        {
                if(null == null)
        {
            goto label_31;
        }
        
        }
        
        label_31:
        val_18 = 1152921510392296080;
        val_19 = "mode";
        if((0.ContainsKey(key:  -1438297296)) != false)
        {
                System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(314429440)});
            string val_6 = 0.Item[-1438297296];
            object val_7 = System.Enum.Parse(enumType:  314429440, value:  null);
            val_19 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.Mode = ;
        }
        
        if((0.ContainsKey(key:  -1438297216)) != false)
        {
                string val_9 = 0.Item[-1438297216];
            this.StartingLevel = System.Int32.Parse(s:  null);
        }
        
        val_17 = "feature_status";
        if((0.ContainsKey(key:  -1438297120)) == false)
        {
                return;
        }
        
        val_18 = 1152921510385703632;
        string val_12 = 0.Item[-1438297120];
        val_19 = this.FeatureStatus;
        string val_13 = 0.Item[-1438292928];
        this.FeatureStatus.Prompted = System.Boolean.Parse(value:  null);
        val_17 = val_19;
        string val_15 = 0.Item[-1438292816];
        this.FeatureStatus.IsFtuxSeen = System.Boolean.Parse(value:  null);
    }
    public void SaveToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        Add(key:  -1438297296, value:  314429440);
        Add(key:  -1438297216, value:  13152256);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1438292928, value:  8945664);
        Add(key:  -1438292816, value:  8945664);
        Add(key:  -1438297120, value:  78753792);
        string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1438297408, value:  78753792);
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public void Update(DifficultyMode mode, int startingLevel)
    {
        this.Mode = mode;
        this.StartingLevel = startingLevel;
        this.SaveToJSON();
    }

}
