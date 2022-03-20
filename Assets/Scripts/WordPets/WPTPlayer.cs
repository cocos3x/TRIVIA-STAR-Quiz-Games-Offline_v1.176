using UnityEngine;

namespace WordPets
{
    public class WPTPlayer : Player
    {
        // Fields
        private const string PREFKEY_PLAYER_LIVES = "wpt_plives";
        private const string PREFKEY_PLAYER_LIVES_SERVER = "experience";
        private const string PREFKEY_LAST_LIFE_TOPUP_TIME = "wpt_life_topuptime";
        private const string PREFKEY_TUTORIAL_COMPLETED = "wpt_tuts";
        private const string PREFKEY_TUTORIAL_COMPLETED_SERVER = "keys";
        private const string PREFKEY_POWERUPUSAGE_LIFETIME = "wpt_pwup_ult";
        private const string PREFKEY_POWERUPUSAGE_COLUMN = "wpt_pwup_ucl";
        private const string PREFKEY_POWERUPUSAGE_SHUFFLE = "wpt_pwup_ulr";
        private const string PREFKEY_POWERUPUSAGE_HINT = "wpt_pwup_hnt";
        private const string PREFKEY_POWERUPUSAGE_COLUMN_CURRENT_LVL = "wpt_pwup_ucl_lvl";
        private const string PREFKEY_POWERUPUSAGE_SHUFFLE_CURRENT_LVL = "wpt_pwup_ulr_lvl";
        private const string PREFKEY_POWERUPUSAGE_HINT_CURRENT_LVL = "wpt_pwup_hnt_lvl";
        public int tutorialCompleted;
        public int livesBalance;
        public System.DateTime lastLifeTopupTime;
        public int powerupUsageLifetime;
        public int powerupUsageNewColumn;
        public int powerupUsageShuffle;
        public int powerupUsageHint;
        public int powerupUsageNewColumnCurrentLevel;
        public int powerupUsageShuffleCurrentLevel;
        public int powerupUsageHintCurrentLevel;
        private EasySaver<WordPets.WPTPlayer> mySaver;
        
        // Properties
        public static WordPets.WPTPlayer Instance { get; }
        public string lastLifeTopupTimeJson { get; }
        public System.TimeSpan LivesMaxTimeLeft { get; }
        
        // Methods
        public static WordPets.WPTPlayer get_Instance()
        {
            Player val_1 = App.Player;
            if(0 == 0)
            {
                    return;
            }
            
            if(((mem[1179403747] + (WordPets.WPTPlayer.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    0 = 0;
            }
            
            0 = 0;
        }
        public string get_lastLifeTopupTimeJson()
        {
            string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  9904128);
        }
        public System.TimeSpan get_LivesMaxTimeLeft()
        {
            var val_12;
            var val_14;
            var val_15;
            var val_16;
            var val_18;
            var val_19;
            WordPets.WPTGameEcon val_1 = WordPets.WPTGameEcon.Instance;
            if(0 != 0)
            {
                    val_14 = 18;
                val_15 = mem[R1 + 280];
                val_15 = R1 + 280;
                val_16 = val_14;
            }
            else
            {
                    val_15 = mem[R1 + 280];
                val_15 = R1 + 280;
                val_16 = 18;
                val_14 = 18;
            }
            
            var val_4 = R1 + 288;
            System.DateTime val_5 = ToLocalTime();
            float val_15 = (float)UnityEngine.Mathf.Clamp(value:  val_16 - val_15, min:  1, max:  18);
            val_15 = (0 + 1376) * val_15;
            System.DateTime val_9 = AddMinutes(value:  null);
            System.DateTime val_10 = System.DateTime.Now;
            System.TimeSpan val_11 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513351831056}, d2:  new System.DateTime());
            val_18 = 0;
            double val_14 = val_12.TotalSeconds;
            val_19 = null;
            val_19 = null;
            this = System.TimeSpan.__il2cppRuntimeField_static_fields;
            return new System.TimeSpan() {_ticks = System.TimeSpan.__il2cppRuntimeField_static_fields};
        }
        public override void BuildReflectedLists()
        {
            EasySaver<WordPlayer> val_1 = new EasySaver<WordPlayer>(incInstance:  155174592);
            this.mySaver = null;
        }
        public override void AddHardSaves(ref System.Collections.Generic.Dictionary<string, object> incDic)
        {
            this.mySaver.AddHardSavesToDictionary(refdic: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = 155327728);
        }
        public override void SoftSave()
        {
            this.mySaver.SoftSaveLite();
            bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public int CreditLife(int amount = 1, string source)
        {
            var val_8;
            string val_9;
            val_8 = amount;
            WordPets.WPTGameEcon val_1 = WordPets.WPTGameEcon.Instance;
            val_9 = 18;
            this.livesBalance = UnityEngine.Mathf.Clamp(value:  this.livesBalance + val_8, min:  0, max:  18);
            if((System.String.IsNullOrEmpty(value:  source)) != true)
            {
                    Player val_5 = App.Player;
                val_8 = 0;
                string val_6 = amount.ToString();
                val_9;
                val_8.TrackNonCoinReward(source:  source, subSource:  null, rewardType:  -771665344, rewardAmount:  amount, additionalParams:  0);
            }
            
            WGBonusRewardsHandler val_7 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            RequestDataFlush(immediate:  false, reset:  false);
            return (int)this.livesBalance;
        }
        public int DebitLife(int amount = 1)
        {
            System.DateTime val_3;
            var val_4;
            if(this.IsLivesMaxed() != false)
            {
                    System.DateTime val_2 = DateTimeCheat.UtcNow;
                this.lastLifeTopupTime = val_3;
                mem[1152921513352439108] = val_4;
            }
            
            int val_5 = 0 - amount;
            this.SendLivesFullNotification(timeFromNow:  new System.Nullable<System.TimeSpan>() {HasValue = val_5});
            return (int)this.CreditLife(amount:  val_5, source:  null);
        }
        public void SendLivesFullNotification(System.Nullable<System.TimeSpan> timeFromNow)
        {
            var val_2;
            twelvegigs.plugins.NotificationInterval val_11;
            twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  21);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1953384384, value:  -339293904);
            if((val_2 & 255) == 0)
            {
                    System.TimeSpan val_4 = Value;
            }
            else
            {
                    System.TimeSpan val_5 = LivesMaxTimeLeft;
            }
            
            System.DateTime val_8 = System.DateTime.UtcNow;
            System.DateTime val_9 = Add(value:  new System.TimeSpan() {_ticks = 1152921513352538760});
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  21, when:  new System.DateTime() {dateData = 1}, interval:  val_11, optTitle:  0, optMessage:  0, extraData:  "Lives are full! Time to keep playing!", priority:  null, useTimeModifier:  false);
        }
        public bool IsLivesMaxed()
        {
            WordPets.WPTGameEcon val_1 = WordPets.WPTGameEcon.Instance;
            if(this.livesBalance >= 18)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool RefreshPlayerLives()
        {
            ulong val_3;
            var val_6;
            var val_14;
            var val_15;
            System.DateTime val_16;
            val_14 = 0;
            if(this.IsLivesMaxed() == true)
            {
                    return (bool)val_14;
            }
            
            val_15 = 0;
            System.DateTime val_2 = DateTimeCheat.UtcNow;
            val_16 = this.lastLifeTopupTime;
            System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513352762752}, d2:  new System.DateTime() {dateData = val_3});
            double val_8 = val_6.TotalMinutes;
            WordPets.WPTGameEcon val_9 = WordPets.WPTGameEcon.Instance;
            val_14 = 0;
            float val_15 = 1.824491E-42f;
            if(0 < 0)
            {
                    return (bool)val_14;
            }
            
            double val_10 = val_6.TotalMinutes;
            val_15;
            WordPets.WPTGameEcon val_11 = WordPets.WPTGameEcon.Instance;
            val_16 = 0;
            val_15 = val_15 / (val_16 + 1376);
            int val_14 = this.CreditLife(amount:  UnityEngine.Mathf.FloorToInt(f:  val_15), source:  null);
            val_14 = 1;
            return (bool)val_14;
        }
        protected override void CreateNewPlayer(string id = " ")
        {
            this.CreateNewPlayer(id:  id);
            WordPets.WPTGameEcon val_1 = WordPets.WPTGameEcon.Instance;
            this.livesBalance = 18;
            System.DateTime val_2 = DateTimeCheat.UtcNow;
            this.lastLifeTopupTime = new System.DateTime();
            mem[1152921513352891204] = ???;
            this.tutorialCompleted = 0;
        }
        protected override void TrustServerData(System.Collections.IDictionary diff)
        {
            var val_4;
            var val_5;
            string val_6;
            var val_7;
            var val_8;
            val_4 = "experience";
            val_5 = 0;
            val_5 = val_5 + 1;
            val_7 = diff;
            if(diff != 0)
            {
                    val_4 = "experience";
                val_5 = 0;
                val_5 = val_5 + 1;
                val_8 = diff;
                val_6 = diff;
                mem[1152921513353011384] = System.Int32.Parse(s:  val_6);
            }
            
            this.TrustServerData(diff:  diff);
        }
        protected override void LoadFromLocal()
        {
            this.LoadFromLocal();
            this.livesBalance = UnityEngine.PlayerPrefs.GetInt(key:  156321632, defaultValue:  0);
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  156321728);
            if((System.String.IsNullOrEmpty(value:  156321728)) != true)
            {
                    System.DateTime val_4 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.DateTime>(value:  156334632);
                this.lastLifeTopupTime = new System.DateTime();
                mem[1152921513353128516] = ???;
            }
            
            this.tutorialCompleted = UnityEngine.PlayerPrefs.GetInt(key:  156321840, defaultValue:  this.tutorialCompleted);
            this.powerupUsageLifetime = UnityEngine.PlayerPrefs.GetInt(key:  156321936, defaultValue:  0);
            this.powerupUsageNewColumn = UnityEngine.PlayerPrefs.GetInt(key:  156322032, defaultValue:  0);
            this.powerupUsageShuffle = UnityEngine.PlayerPrefs.GetInt(key:  156322128, defaultValue:  0);
            this.powerupUsageHint = UnityEngine.PlayerPrefs.GetInt(key:  156322224, defaultValue:  0);
            this.powerupUsageNewColumnCurrentLevel = UnityEngine.PlayerPrefs.GetInt(key:  156322320, defaultValue:  0);
            this.powerupUsageShuffleCurrentLevel = UnityEngine.PlayerPrefs.GetInt(key:  156322432, defaultValue:  0);
            this.powerupUsageHintCurrentLevel = UnityEngine.PlayerPrefs.GetInt(key:  156322544, defaultValue:  0);
            bool val_13 = this.RefreshPlayerLives();
        }
        protected override void Save()
        {
            this.mySaver.SoftSaveFull();
            bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public void QAHACK_EmptyLives()
        {
            if(this.livesBalance < 1)
            {
                    return;
            }
            
            do
            {
                int val_1 = this.DebitLife(amount:  1);
            }
            while(this.livesBalance > 0);
        
        }
        public void QAHACK_MaxLives()
        {
            goto label_0;
            label_2:
            int val_1 = this.CreditLife(amount:  1, source:  null);
            label_0:
            WordPets.WPTGameEcon val_2 = WordPets.WPTGameEcon.Instance;
            if(this.livesBalance < 18)
            {
                goto label_2;
            }
        
        }
        public WPTPlayer()
        {
            var val_1 = null;
            this.lastLifeTopupTime = System.DateTime.MinValue;
            mem[1152921513353585732] = System.DateTime.__il2cppRuntimeField_cctor_finished;
        }
    
    }

}
