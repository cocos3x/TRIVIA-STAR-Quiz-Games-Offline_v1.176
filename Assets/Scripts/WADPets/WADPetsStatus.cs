using UnityEngine;

namespace WADPets
{
    public class WADPetsStatus : EventProgression
    {
        // Fields
        private const string PREF_WADPETS_STATUS = "wadpets_status";
        private const string KEY_LAST_FED_TIME = "lastFed";
        public System.DateTime LastFedUtcTime;
        
        // Methods
        public override void LoadFromJSON()
        {
            System.DateTime val_14;
            var val_15;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  677221728, defaultValue:  1098586544);
            val_15 = "wadpets_status";
            if((System.String.IsNullOrEmpty(value:  677221728)) == true)
            {
                    return;
            }
            
            object val_3 = MiniJSON.Json.Deserialize(json:  677221728);
            if(val_15 != 0)
            {
                    if(null == null)
            {
                goto label_10;
            }
            
            }
            
            val_15 = 1;
            label_10:
            if((0.ContainsKey(key:  677221824)) == false)
            {
                    return;
            }
            
            string val_5 = 0.Item[677221824];
            val_15 = 0;
            System.DateTime val_6 = System.DateTime.UtcNow;
            System.DateTime val_9 = AddDays(value:  null);
            System.DateTime val_12 = SLCDateTime.Parse(dateTime:  677233864, defaultValue:  new System.DateTime());
            this.LastFedUtcTime = val_14;
        }
        public override void SaveToJSON()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            string val_2 = this.LastFedUtcTime.ToString();
            Add(key:  677221824, value:  this.LastFedUtcTime);
            string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  677221728, value:  78753792);
            bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public WADPetsStatus()
        {
        
        }
    
    }

}
