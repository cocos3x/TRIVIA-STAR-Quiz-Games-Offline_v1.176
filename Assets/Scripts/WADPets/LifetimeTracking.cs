using UnityEngine;

namespace WADPets
{
    public class LifetimeTracking : EventProgression
    {
        // Fields
        private const string PREF_LIFETIME_TRACKING = "wadpet_lifetime_tracking";
        private const string KEY_FOOD = "food";
        public int Food;
        
        // Methods
        public LifetimeTracking()
        {
            this.Food = 10;
        }
        public override void LoadFromJSON()
        {
            var val_7;
            string val_1 = UnityEngine.PlayerPrefs.GetString(key:  677669920, defaultValue:  1098586544);
            val_7 = "wadpet_lifetime_tracking";
            if((System.String.IsNullOrEmpty(value:  677669920)) == true)
            {
                    return;
            }
            
            object val_3 = MiniJSON.Json.Deserialize(json:  677669920);
            if(val_7 != 0)
            {
                    if(null == null)
            {
                goto label_8;
            }
            
            }
            
            val_7 = 1;
            label_8:
            if((0.ContainsKey(key:  -960166544)) == false)
            {
                    return;
            }
            
            string val_5 = 0.Item[-960166544];
            this.Food = System.Int32.Parse(s:  null);
        }
        public override void SaveToJSON()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -960166544, value:  13152256);
            string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  677669920, value:  78753792);
            bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        }
    
    }

}
