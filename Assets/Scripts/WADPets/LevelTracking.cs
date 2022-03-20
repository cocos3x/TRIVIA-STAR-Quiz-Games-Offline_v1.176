using UnityEngine;

namespace WADPets
{
    public class LevelTracking : EventProgression
    {
        // Fields
        private const string PREF_PET_LEVEL_TRACKING = "wadpet_level";
        private const string KEY_HAS_BONUS_ALPHABET_TILE = "has_bonus_alphabet_tile";
        private const string KEY_GAINED_ALPHABET_TILE = "gained_alphabet_tile";
        private const string KEY_HAS_ALPHABET_TILE_IN_LEVEL = "has_alphabet_tile_in_level";
        public bool HasBonusAlphabetTile;
        public bool GainedBonusAlphabetTile;
        public bool HasAlphabetTileInLevel;
        
        // Methods
        public void ResetLevelCompleteEvent()
        {
            this.HasAlphabetTileInLevel = false;
            this.HasBonusAlphabetTile = false;
            this.GainedBonusAlphabetTile = false;
            goto typeof(WADPets.LevelTracking).__il2cppRuntimeField_E4;
        }
        public override void LoadFromJSON()
        {
            var val_13;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  678006048, defaultValue:  1098586544);
            val_13 = "wadpet_level";
            if((System.String.IsNullOrEmpty(value:  678006048)) == true)
            {
                    return;
            }
            
            object val_3 = MiniJSON.Json.Deserialize(json:  678006048);
            if(val_13 != 0)
            {
                    if(null == null)
            {
                goto label_22;
            }
            
            }
            
            label_22:
            if((0.ContainsKey(key:  678006144)) != false)
            {
                    string val_5 = 0.Item[678006144];
                this.HasBonusAlphabetTile = System.Boolean.Parse(value:  null);
            }
            
            val_13 = "gained_alphabet_tile";
            if((0.ContainsKey(key:  678006272)) != false)
            {
                    string val_8 = 0.Item[678006272];
                val_13 = 0;
                this.GainedBonusAlphabetTile = System.Boolean.Parse(value:  null);
            }
            
            if((0.ContainsKey(key:  678006384)) == false)
            {
                    return;
            }
            
            string val_11 = 0.Item[678006384];
            this.HasAlphabetTileInLevel = System.Boolean.Parse(value:  null);
        }
        public override void SaveToJSON()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  678006144, value:  8945664);
            Add(key:  678006272, value:  8945664);
            Add(key:  678006384, value:  8945664);
            string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  678006048, value:  78753792);
            bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public override void Delete()
        {
            UnityEngine.PlayerPrefs.DeleteKey(key:  678006048);
        }
        public LevelTracking()
        {
        
        }
    
    }

}
