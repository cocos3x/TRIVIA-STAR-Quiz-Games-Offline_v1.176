using UnityEngine;

namespace WADPets
{
    [Serializable]
    public class WADPet : EventProgression
    {
        // Fields
        private const string PREF_PET = "wadpet";
        private const string KEY_LEVEL = "level";
        private const string KEY_UNLOCKED = "unlocked";
        private const string KEY_CARDS = "cards";
        private const string KEY_FTUX_SHOWN = "ftux_shown";
        public WADPets.WADPetInfo Info;
        public int LevelIndex;
        public bool IsUnlocked;
        public int Cards;
        public bool IsFtuxShown;
        public float CachedValueModifier;
        
        // Methods
        public WADPet(WADPets.WADPetInfo info)
        {
            this.Info = info;
            this.LevelIndex = 0;
            this.IsUnlocked = 0;
            this.Cards = 0;
            this.CachedValueModifier = 0;
            this.IsFtuxShown = 0;
        }
        public bool IsActive()
        {
            if(this.IsUnlocked == false)
            {
                    return true;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.TimeSpan val_2 = GetTimeCountdownToNextFeed();
            double val_3 = ???.TotalSeconds;
            if((public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance()) > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public WADPets.PetStatus GetStatus()
        {
            if(this.IsUnlocked == false)
            {
                    this = 0;
                return;
            }
            
            if(this.IsActive() == true)
            {
                    2 = 1;
            }
        
        }
        public void Upgrade(int hackLevel = -1)
        {
            int val_8;
            int val_11;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_12;
            string val_13;
            var val_14;
            int val_15;
            val_11 = hackLevel;
            val_12 = 35628948;
            if(val_11 == 1)
            {
                goto label_1;
            }
            
            if(this != 0)
            {
                goto label_3;
            }
            
            goto label_3;
            label_1:
            WADPets.WADPetUpgradeRequirement val_1 = WADPetsManager.GetUpgradeRequirement(levelIndex:  this.LevelIndex);
            val_13 = this.LevelIndex;
            val_14 = 0;
            if(this.LevelIndex == 0)
            {
                    val_14 = 1;
            }
            
            val_15 = mem[this.LevelIndex + 8];
            val_15 = this.LevelIndex + 8;
            int val_10 = this.Cards;
            val_10 = val_10 - val_15;
            if(this.LevelIndex > 0)
            {
                    val_12 = 1;
            }
            
            this.Cards = val_10;
            this.Tracking_CardsSpent(amount:  val_15, prevCardsBalance:  WADPetsManager.GetCardsBalance(), isUpgrade:  true);
            if((this.LevelIndex + 12) >= 1)
            {
                    val_12 = null;
                val_12 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                string val_4 = this.GetPrettyName();
                Add(key:  675503200, value:  675527296);
                Player val_5 = App.Player;
                val_15 = 0;
                var val_6 = 0 - (this.LevelIndex + 12);
                val_13 = 0;
                decimal val_7 = System.Decimal.op_Implicit(value:  675515248);
                val_15.AddCredits(amount:  new System.Decimal() {mid = val_8}, source:  "Pet Upgraded", subSource:  val_13, externalParams:  val_12, doTrack:  true);
                NotificationCenter val_9 = NotificationCenter.DefaultCenter;
                0.PostNotification(aSender:  0, aName:  -2144143840);
            }
            
            val_11 = this.LevelIndex + 1;
            label_3:
            this.IsUnlocked = true;
            this.LevelIndex = val_11;
        }
        public string GetPrettyName()
        {
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            string val_1 = ToUpper();
            char val_2 = Chars[0];
            string val_3 = ToLower();
            string val_4 = Substring(startIndex:  1);
            string val_5 = System.String.Format(format:  -1671354896, arg0:  9158656, arg1:  431575040);
        }
        public override void LoadFromJSON()
        {
            var val_24;
            bool val_25;
            string val_1 = this.GetPetPlayerprefKey();
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  675759760, defaultValue:  1098586544);
            val_24 = this;
            if((System.String.IsNullOrEmpty(value:  675759760)) == true)
            {
                    return;
            }
            
            object val_4 = MiniJSON.Json.Deserialize(json:  675759760);
            val_25 = "level";
            if((0.ContainsKey(key:  -1988561632)) != false)
            {
                    string val_7 = 0.Item[-1988561632];
                val_25 = 0;
                if((0.ContainsKey(key:  675735488)) != false)
            {
                    bool val_9 = System.Int32.TryParse(s:  null, result: out  this.LevelIndex);
            }
            else
            {
                    bool val_11 = System.Int32.TryParse(s:  null, result: out  int val_10 = 675747724);
                this.LevelIndex = 1;
            }
            
            }
            
            if((0.ContainsKey(key:  675735568)) != false)
            {
                    string val_13 = 0.Item[675735568];
                val_25 = this.IsUnlocked;
                bool val_15 = System.Boolean.TryParse(value:  null, result: out  val_25);
            }
            
            if((0.ContainsKey(key:  675735488)) != false)
            {
                    string val_17 = 0.Item[675735488];
                bool val_19 = System.Int32.TryParse(s:  null, result: out  this.Cards);
            }
            
            val_24 = "ftux_shown";
            if((0.ContainsKey(key:  675735664)) == false)
            {
                    return;
            }
            
            string val_21 = 0.Item[675735664];
            bool val_23 = System.Boolean.TryParse(value:  null, result: out  this.IsFtuxShown);
        }
        public override void SaveToJSON()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1988561632, value:  13152256);
            Add(key:  675735568, value:  8945664);
            Add(key:  675735488, value:  13152256);
            Add(key:  675735664, value:  8945664);
            string val_2 = this.GetPetPlayerprefKey();
            string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  675871760, value:  78753792);
            bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public override void Delete()
        {
            string val_1 = this.GetPetPlayerprefKey();
            this.DeleteKey(key:  675983760);
        }
        private void SpendCards(int amount, int prevCardsBalance, bool isUpgrade)
        {
            int val_1 = this.Cards;
            val_1 = val_1 - amount;
            this.Cards = val_1;
            this.Tracking_CardsSpent(amount:  amount, prevCardsBalance:  prevCardsBalance, isUpgrade:  isUpgrade);
        }
        private void Tracking_CardsSpent(int amount, int prevCardsBalance, bool isUpgrade)
        {
            var val_5;
            var val_6;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1988575600, value:  13152256);
            int val_2 = WADPetsManager.GetCardsBalance();
            Add(key:  -607679056, value:  13152256);
            Add(key:  -607678944, value:  13152256);
            string val_3 = this.GetPrettyName();
            Add(key:  173213344, value:  676207952);
            Add(key:  676183760, value:  13152256);
            bool val_4 = isUpgrade ^ 1;
            Add(key:  676183856, value:  8945664);
            Add(key:  675503200, value:  8945664);
            var val_5 = 27904330;
            val_5 = 7721208 + val_5;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            App.trackerManager.track(eventName:  Events.CARDS_SPENT, data:  78753792);
        }
        private string GetPetPlayerprefKey()
        {
            string val_1 = System.String.Format(format:  -1645101696, arg0:  676304144, arg1:  431575040);
        }
    
    }

}
