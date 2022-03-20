using UnityEngine;

namespace WordForest
{
    public class WFOPlayer : Player
    {
        // Fields
        private const string PREFKEY_STARS_BAL_TEMP = "wfo_acnbal_tmp";
        private const string PREFKEY_STARS_BAL_TEMP_WGS = "wfo_acnbal_tmp_wgs";
        private const string PREFKEY_STARS_BAL_TEMP_WMC = "wfo_acnbal_tmp_wmc";
        private const string PREFKEY_STARS_BAL_TEMP_WFC = "wfo_acnbal_tmp_wfc";
        private const string PREFKEY_STARS_BAL_TEMP_WRA = "wfo_acnbal_tmp_wra";
        private const string PREFKEY_STARS_BAL_TEMP_DAILY_CHALLENGE = "wfo_acnbal_tmp_dc";
        private const string PREFKEY_SHIELDS = "wfo_shields";
        private const string PREFKEY_TUTORIAL_COMPLETED = "wfo_tuts";
        private const string PREFKEY_WORDCHEST_CURRTYPE = "wfo_wrdcht_type";
        private const string PREFKEY_WORDCHEST_CURRREQ = "wfo_wrdcht_req";
        private const string PREFKEY_WORDCHEST_CURRCOMP = "wfo_wrdcht_comp";
        private const string PREFKEY_CHESTREWARDS = "wfo_cht_rews";
        private const string PREFKEY_CURR_FOREST = "wfo_curr_forest";
        private const string PREFKEY_CURR_CHEST = "wfo_curr_chest";
        private const string PREFKEY_CURR_GROWTH = "wfo_curr_growth";
        private const string PREKEY_FOREST_SERVER_ID = "wfo_frst_serv_id";
        private const string PREFKEY_LAST_SERVER_ACORNS = "wfo_lst_serv_acorns";
        private const string PREFKEY_LAST_SERVER_SHIELDS = "wfo_lst_serv_shields";
        private const string PREFKEY_FOREST_MAPDATA = "wfo_frst_mapdata";
        private const string PREFKEY_RAIDS_SENT = "wfo_raids_sent";
        private const string PREFKEY_RAIDS_RECEIVED = "wfo_raids_rec";
        private const string PREFKEY_ATTACKS_SENT = "wfo_attacks_sent";
        private const string PREFKEY_ATTACKS_RECEIVED = "wfo_attacks_rec";
        private const string PREFKEY_FOREST_VERSION = "wfo_forest_ver";
        private const int CURRENT_FOREST_VERSION = 1;
        public int ForestVersion;
        private EasySaver<WordForest.WFOPlayer> mySaver;
        private int starsLevelBalanceNormal;
        public int playingStarsFromGameplay;
        public int playingStarsFromMC;
        public int playingStarsFromFC;
        public int playingStarsFromRaid;
        private int starsLevelBalanceDailyChallenge;
        public int shields;
        public int tutorialCompleted;
        private int currentWordChestType;
        public int currentWordChestWordRequired;
        public int currentWordChestWordCompleted;
        public int currentForestID;
        public int forestServerId;
        public int currentChestID;
        private int currentForestGrowth;
        public WordForest.Map forestMapData;
        private int lastKnownServerAcorns;
        private int lastKnownServerShields;
        public int raidsSent;
        public int raidsReceived;
        public int attacksSent;
        public int attacksReceived;
        
        // Properties
        public static WordForest.WFOPlayer Instance { get; }
        public bool UpgradePlayer { get; }
        public int starsLevelBalance { get; set; }
        public int acorns { get; set; }
        public WordForest.WFOWordChestType CurrentWordChestType { get; set; }
        public string forestMapDataJson { get; }
        public int LastKnownServerAcorns { get; set; }
        public int LastKnownServerShields { get; set; }
        
        // Methods
        public static WordForest.WFOPlayer get_Instance()
        {
            var val_2 = 0;
            Player val_1 = App.Player;
            if(0 == 0)
            {
                    return;
            }
        
        }
        public bool get_UpgradePlayer()
        {
            if(this.ForestVersion < 1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public int get_starsLevelBalance()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(PlayingChallenge == true)
            {
                    284 = 304;
            }
            
            return (int)this.starsLevelBalanceDailyChallenge;
        }
        public void set_starsLevelBalance(int value)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = PlayingChallenge;
            if(val_2 == false)
            {
                    this.starsLevelBalanceNormal = value;
            }
            
            if(val_2 == true)
            {
                    this.starsLevelBalanceDailyChallenge = value;
            }
        
        }
        public int get_acorns()
        {
            return (int)this;
        }
        public void set_acorns(int value)
        {
            this.stars = value;
        }
        public WordForest.WFOWordChestType get_CurrentWordChestType()
        {
        
        }
        public void set_CurrentWordChestType(WordForest.WFOWordChestType value)
        {
            this.currentWordChestType = value;
        }
        public string get_forestMapDataJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.forestMapData);
        }
        public int get_LastKnownServerAcorns()
        {
            return (int)this.lastKnownServerAcorns;
        }
        public void set_LastKnownServerAcorns(int value)
        {
            this.lastKnownServerAcorns = value;
        }
        public int get_LastKnownServerShields()
        {
            return (int)this.lastKnownServerShields;
        }
        public void set_LastKnownServerShields(int value)
        {
            this.lastKnownServerShields = value;
        }
        public override void BuildReflectedLists()
        {
            EasySaver<WordPlayer> val_1 = new EasySaver<WordPlayer>(incInstance:  338172336);
            this.mySaver = null;
        }
        public override void AddHardSaves(ref System.Collections.Generic.Dictionary<string, object> incDic)
        {
            this.mySaver.AddHardSavesToDictionary(refdic: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = 338325472);
        }
        protected override void TrustServerData(System.Collections.IDictionary diff)
        {
            this.TrustServerData(diff:  diff);
        }
        protected override void LoadFromLocal()
        {
            this.LoadFromLocal();
            this.starsLevelBalanceNormal = UnityEngine.PlayerPrefs.GetInt(key:  338509776, defaultValue:  0);
            this.starsLevelBalanceDailyChallenge = UnityEngine.PlayerPrefs.GetInt(key:  338509872, defaultValue:  0);
            this.shields = UnityEngine.PlayerPrefs.GetInt(key:  338509984);
            this.tutorialCompleted = UnityEngine.PlayerPrefs.GetInt(key:  338510080, defaultValue:  this.tutorialCompleted);
            this.currentWordChestType = UnityEngine.PlayerPrefs.GetInt(key:  338510176, defaultValue:  0);
            this.currentWordChestWordRequired = UnityEngine.PlayerPrefs.GetInt(key:  338510288, defaultValue:  0);
            this.currentWordChestWordCompleted = UnityEngine.PlayerPrefs.GetInt(key:  338510384, defaultValue:  0);
            this.currentForestID = UnityEngine.PlayerPrefs.GetInt(key:  338510496, defaultValue:  1);
            this.currentForestGrowth = UnityEngine.PlayerPrefs.GetInt(key:  338510608, defaultValue:  0);
            this.currentChestID = UnityEngine.PlayerPrefs.GetInt(key:  338510720, defaultValue:  1);
            string val_11 = UnityEngine.PlayerPrefs.GetString(key:  338510816, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  338510816)) != true)
            {
                    object val_13 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  338510816);
                this.forestMapData = "wfo_frst_mapdata";
            }
            
            this.lastKnownServerAcorns = UnityEngine.PlayerPrefs.GetInt(key:  338510928, defaultValue:  0);
            this.lastKnownServerShields = UnityEngine.PlayerPrefs.GetInt(key:  338511040, defaultValue:  0);
            this.raidsSent = UnityEngine.PlayerPrefs.GetInt(key:  338511152, defaultValue:  0);
            this.raidsReceived = UnityEngine.PlayerPrefs.GetInt(key:  338511248, defaultValue:  0);
            this.attacksSent = UnityEngine.PlayerPrefs.GetInt(key:  338511344, defaultValue:  0);
            this.attacksReceived = UnityEngine.PlayerPrefs.GetInt(key:  338511456, defaultValue:  0);
            this.forestServerId = UnityEngine.PlayerPrefs.GetInt(key:  338511568, defaultValue:  0);
            this.ForestVersion = UnityEngine.PlayerPrefs.GetInt(key:  338511680, defaultValue:  0);
            this.playingStarsFromGameplay = UnityEngine.PlayerPrefs.GetInt(key:  338511776, defaultValue:  0);
            this.playingStarsFromMC = UnityEngine.PlayerPrefs.GetInt(key:  338511888, defaultValue:  0);
            this.playingStarsFromFC = UnityEngine.PlayerPrefs.GetInt(key:  338512000, defaultValue:  0);
            this.playingStarsFromRaid = UnityEngine.PlayerPrefs.GetInt(key:  338512112, defaultValue:  0);
            this.LocalDataIntegrityCheck();
        }
        protected override void CreateNewPlayer(string id = " ")
        {
            this.CreateNewPlayer(id:  id);
            GameBehavior val_1 = App.getBehavior;
            mem[1152921513535433964] = 0;
            this.starsLevelBalanceNormal = 0;
            this.currentWordChestWordRequired = 0;
            this.currentWordChestWordCompleted = 0;
            this.currentForestID = 1;
            this.forestServerId = 0;
            this.currentChestID = 1;
            WordForest.Map val_2 = WordForest.WFOGameEconHelper.CreateStartingMap();
            this.forestMapData = 0;
            this.ForestVersion = 1;
        }
        public override void SoftSave()
        {
            this.mySaver.SoftSaveLite();
            bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        }
        protected override void Save()
        {
            this.mySaver.SoftSaveFull();
            bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        }
        private void LocalDataIntegrityCheck()
        {
            if(this.forestMapData != 0)
            {
                    return;
            }
            
            if(this.currentForestGrowth >= 1)
            {
                    WordForest.Map val_1 = WordForest.WFOGameEconHelper.MapDataV1ToV2Migration(oldForestId:  this.currentForestID, oldForestGrowth:  this.currentForestGrowth);
                this.forestMapData = this.currentForestID;
                int val_2 = this.currentForestID + 1;
                this.currentForestID = val_2;
                this.currentChestID = val_2;
                CompanyDevices val_3 = CompanyDevices.Instance;
                if(0.CompanyDevice() == false)
            {
                    return;
            }
            
                UnityEngine.Debug.LogError(message:  338990944);
                return;
            }
            
            WordForest.Map val_5 = WordForest.WFOGameEconHelper.CreateStartingMap();
            this.forestMapData = 0;
        }
        public WFOPlayer()
        {
        
        }
    
    }

}
