using UnityEngine;

namespace PrizeBalloon
{
    public class Progress : EventProgression
    {
        // Fields
        private const string pref_prize_balloon = "prize_balloon";
        private const string key_levels_completed = "lvls_completed";
        private const string key_last_balloon_shown_time = "last_time";
        private const string key_daily_shown_times = "daily_shown_times";
        private const string key_track_balloon_appearance_in_level = "appearance_in_lvl";
        public int levelsCompletedThisSession;
        public System.DateTime lastBalloonShownTime;
        public int dailyShownTimes;
        public int balloonAppearedWithinLevel;
        
        // Methods
        public Progress()
        {
            this.levelsCompletedThisSession = 0;
        }
        public override void LoadFromJSON()
        {
            System.DateTime val_19;
            if((UnityEngine.PlayerPrefs.HasKey(key:  687349824)) == false)
            {
                    return;
            }
            
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  687349824);
            object val_3 = MiniJSON.Json.Deserialize(json:  687349824);
            if("prize_balloon" != 0)
            {
                    if(null == null)
            {
                goto label_22;
            }
            
            }
            
            label_22:
            if((0.ContainsKey(key:  687349920)) != false)
            {
                    string val_5 = 0.Item[687349920];
                bool val_7 = System.Int32.TryParse(s:  null, result: out  this.levelsCompletedThisSession);
            }
            
            if((0.ContainsKey(key:  687350016)) != false)
            {
                    string val_9 = 0.Item[687350016];
                val_19 = this.lastBalloonShownTime;
                bool val_10 = System.DateTime.TryParse(s:  null, result: out  new System.DateTime() {dateData = val_19});
            }
            
            if((0.ContainsKey(key:  687350112)) != false)
            {
                    string val_12 = 0.Item[687350112];
                bool val_14 = System.Int32.TryParse(s:  null, result: out  this.dailyShownTimes);
            }
            
            if((0.ContainsKey(key:  687350224)) == false)
            {
                    return;
            }
            
            string val_16 = 0.Item[687350224];
            bool val_18 = System.Int32.TryParse(s:  null, result: out  this.balloonAppearedWithinLevel);
        }
        public override void SaveToJSON()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  687349920, value:  13152256);
            string val_2 = this.lastBalloonShownTime.ToString();
            Add(key:  687350016, value:  this.lastBalloonShownTime);
            Add(key:  687350112, value:  13152256);
            Add(key:  687350224, value:  13152256);
            string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  687349824, value:  78753792);
            bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
        }
    
    }

}
