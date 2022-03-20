using UnityEngine;
public class LightningLevelsLevelProgress : LightningLevelProgress
{
    // Properties
    protected override string pref_lvl_prg { get; }
    
    // Methods
    protected override string get_pref_lvl_prg()
    {
    
    }
    public override void LoadFromJSON()
    {
        var val_21;
        var val_22;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1176097776, defaultValue:  1098586544);
        val_21 = this;
        if((System.String.IsNullOrEmpty(value:  -1176097776)) == true)
        {
                return;
        }
        
        object val_3 = MiniJSON.Json.Deserialize(json:  -1176097776);
        val_22 = "game_mode";
        if((0.ContainsKey(key:  -1176122288)) != false)
        {
                System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(375291904)});
            string val_6 = 0.Item[-1176122288];
            object val_7 = System.Enum.Parse(enumType:  375291904, value:  null);
            val_22 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921512020683800] = ;
        }
        
        if((0.ContainsKey(key:  -1176122192)) != false)
        {
                string val_9 = 0.Item[-1176122192];
            mem[1152921512020683812] = System.Int32.Parse(s:  null);
        }
        
        if((0.ContainsKey(key:  -1176122096)) != false)
        {
                string val_12 = 0.Item[-1176122096];
            mem[1152921512020683824] = System.Boolean.Parse(value:  null);
        }
        
        if((0.ContainsKey(key:  -1176121984)) != false)
        {
                string val_15 = 0.Item[-1176121984];
            val_22 = 1152921512020683825;
            bool val_17 = System.Boolean.TryParse(value:  null, result: out  bool val_16 = true);
        }
        
        val_21 = "category_level";
        if((0.ContainsKey(key:  -1176121872)) == false)
        {
                return;
        }
        
        string val_19 = 0.Item[-1176121872];
        mem[1152921512020683808] = System.Int32.Parse(s:  null);
    }
    public override void SaveToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem[1152921512020795800] = ;
        Add(key:  -1176122288, value:  375291904);
        Add(key:  -1176122192, value:  13152256);
        Add(key:  -1176122096, value:  8945664);
        Add(key:  -1176121984, value:  8945664);
        Add(key:  -1176121872, value:  13152256);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  -1175985776, value:  78753792);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        this.DeleteKey(key:  -1175873776);
    }
    public LightningLevelsLevelProgress()
    {
    
    }

}
