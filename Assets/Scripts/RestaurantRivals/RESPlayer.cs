using UnityEngine;

namespace RestaurantRivals
{
    public class RESPlayer : Player
    {
        // Fields
        private const string PREFKEY_SPINS = "res_spins";
        private const string PREFKEY_SPINS_SERVER = "spins";
        private const string PREFKEY_AVATARID = "res_avatarId";
        private const string PREFKEY_PLAYER_NAME = "res_player_name";
        private const string PREFKEY_TOTAL_SPINNED = "res_total_spinned";
        private const string PREFKEY_TOTAL_SPINNED_SERVER = "total_spinned";
        private const string PREFKEY_SHIELDS = "res_shields";
        private const string PREFKEY_TUTORIAL_COMPLETED = "res_tutorial_completed";
        private const string PREFKEY_TUTORIAL_COMPLETED_SERVER = "tutorial_completed";
        private const string PREFKEY_AUTO_SPINED_TUTORIAL_COMPLETED = "res_auto_spin_tuts";
        private const string PREFKEY_REVENGE_TUTORIAL_COMPLETED = "res_revenge_tuts";
        private const string PREFKEY_WATCH_ADS_SPIN_TUTORIAL_COMPLETED = "res_watch_ads_spin_tuts";
        private const string PREFKEY_BET_MULTIPLIER_TUTORIAL_COMPLETED = "res_bet_multiplier_tuts";
        private const string PREFKEY_EXTRA_SHIELD_4TH_TUTORIAL_COMPLETED = "res_extra_4th_shield_tuts";
        private const string PREFKEY_EXTRA_SHIELD_5TH_TUTORIAL_COMPLETED = "res_extra_5th_shield_tuts";
        private const string PREFKEY_INCREASE_RECHARGEABLE_SPIN_TUTORIAL_COMPLETED = "res_increase_rechargeable_spin_tuts";
        private const string PREFKEY_CURR_RESTAURANT = "res_curr_restaurant";
        private const string PREFKEY_CURR_CHEST = "res_curr_chest";
        private const string PREFKEY_CURR_GROWTH = "res_curr_growth";
        public const string PREFKEY_LAST_RECHARGE_COLLECTED = "res_last_recharge_collected";
        private const string PREKEY_MAP_SERVER_ID = "res_map_serv_id";
        private const string PREFKEY_LAST_SERVER_ACORNS = "res_lst_serv_acorns";
        private const string PREFKEY_LAST_SERVER_SHIELDS = "res_lst_serv_shields";
        private const string PREFKEY_RESTAURANT_MAPDATA = "res_frst_mapdata";
        private const string PREFKEY_RAIDS_RECEIVED = "res_raids_rec";
        private const string PREFKEY_ATTACKS_RECEIVED = "res_attacks_rec";
        private const string PREFKEY_ATTACK_RESULTS = "res_attack_results";
        private const string PREFKEY_RAID_OPPONENT = "res_raid_opponent";
        private const string PREFKEY_MAP_VERSION = "res_map_ver";
        private const int CURRENT_MAP_VERSION = 0;
        private EasySaver<RestaurantRivals.RESPlayer> mySaver;
        public int MapVersion;
        private bool isGotDataFromServer;
        public int spins;
        public int totalSpinned;
        public int shields;
        public int tutorialCompleted;
        public int auto_spin_tutorial_completed;
        public int revenge_tutorial_completed;
        public int watch_ads_spin_tutorial_completed;
        public int bet_multiplier_tutorial_completed;
        public int extra_shield_4th_tutorial_completed;
        public int extra_shield_5th_tutorial_completed;
        public int increase_rechargeable_spin_tutorial_completed;
        public int mapServerId;
        public int avatarId;
        public string playerName;
        public int currentChestID;
        public RestaurantRivals.Map restaurantMapData;
        public System.DateTime lastRechargeCollected;
        public int raidsReceived;
        public int attacksReceived;
        public int lastFiveAttackResults;
        
        // Properties
        public static RestaurantRivals.RESPlayer Instance { get; }
        public bool UpgradePlayer { get; }
        public string restaurantMapDataJson { get; }
        public string lastRechargeCollectedString { get; }
        
        // Methods
        public static RestaurantRivals.RESPlayer get_Instance()
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
            int val_1 = this.MapVersion;
            val_1 = val_1 >> 31;
            return (bool)val_1;
        }
        public string get_restaurantMapDataJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.restaurantMapData);
        }
        public string get_lastRechargeCollectedString()
        {
            return SLCDateTime.SerializeInvariant(dateTime:  new System.DateTime() {dateData = this.lastRechargeCollected});
        }
        public override void BuildReflectedLists()
        {
            EasySaver<WordPlayer> val_1 = new EasySaver<WordPlayer>(incInstance:  582083664);
            this.mySaver = null;
        }
        public override void AddHardSaves(ref System.Collections.Generic.Dictionary<string, object> incDic)
        {
            this.mySaver.AddHardSavesToDictionary(refdic: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = 582236800);
        }
        public bool ShouldUseHighAttackSuccessRate()
        {
            int val_1 = this.lastFiveAttackResults;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public void SetAttackResult(bool success)
        {
            if(success == true)
            {
                    (uint)(this.lastFiveAttackResults >> 1) & 31 = ((uint)(this.lastFiveAttackResults >> 1) & 31) | 16;
            }
            
            this.lastFiveAttackResults = (uint)(this.lastFiveAttackResults >> 1) & 31;
        }
        public bool IsMostRecentAttackSuccessful()
        {
            return (bool)(uint)(this.lastFiveAttackResults >> 4) & 1;
        }
        protected override void TrustServerData(System.Collections.IDictionary diff)
        {
            string val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_11 = 35636871;
            if(this.isGotDataFromServer != false)
            {
                    return;
            }
            
            val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = diff;
            if(diff != 0)
            {
                    val_12 = 0;
                val_12 = val_12 + 1;
                val_14 = diff;
                val_11 = diff;
                this.spins = System.Int32.Parse(s:  val_11);
            }
            
            val_12 = 0;
            val_12 = val_12 + 1;
            val_15 = diff;
            if(diff != 0)
            {
                    val_12 = 0;
                val_12 = val_12 + 1;
                val_16 = diff;
                val_11 = diff;
                this.totalSpinned = System.Int32.Parse(s:  val_11);
            }
            
            val_17 = "tutorial_completed";
            val_12 = 0;
            val_12 = val_12 + 1;
            val_18 = diff;
            if(diff != 0)
            {
                    val_17 = "tutorial_completed";
                val_12 = 0;
                val_12 = val_12 + 1;
                val_19 = diff;
                val_11 = diff;
                this.tutorialCompleted = System.Int32.Parse(s:  val_11);
                this.isGotDataFromServer = true;
            }
            
            this.TrustServerData(diff:  diff);
            Player val_10 = App.Player;
            0.SaveState();
        }
        protected override void ProcessRemainingAttributes(System.Collections.IDictionary diff)
        {
            var val_5;
            var val_10;
            string val_11;
            float val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_19;
            var val_20;
            val_10 = this;
            val_11 = 35636872;
            val_12 = "level";
            val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = diff;
            if(diff == 0)
            {
                goto label_31;
            }
            
            val_12 = "override_user_data";
            val_15 = "override_user_data";
            val_13 = 0;
            val_13 = val_13 + 1;
            val_16 = diff;
            if(diff == 0)
            {
                goto label_21;
            }
            
            val_15 = "override_user_data";
            val_13 = 0;
            val_13 = val_13 + 1;
            val_17 = diff;
            val_11 = diff;
            if((System.Boolean.Parse(value:  val_11)) == false)
            {
                goto label_21;
            }
            
            goto typeof(RestaurantRivals.RESPlayer).__il2cppRuntimeField_10C;
            label_21:
            if(diff == 0)
            {
                goto label_23;
            }
            
            mem[1152921513779566989] = 0;
            goto typeof(RestaurantRivals.RESPlayer).__il2cppRuntimeField_10C;
            label_23:
            if(SL == 0)
            {
                goto label_24;
            }
            
            val_19 = mem[SL];
            val_19 = SL;
            goto label_25;
            label_24:
            var val_8 = val_5;
            val_15 = "tutorial_completed";
            if((val_5 + 178) == 0)
            {
                goto label_27;
            }
            
            val_13 = 0;
            label_29:
            val_11 = mem[val_5 + 88 + 0];
            val_11 = val_5 + 88 + 0;
            if(val_11 == null)
            {
                goto label_28;
            }
            
            val_13 = val_13 + 1;
            if(((uint)val_13 & 65535) < (val_5 + 178))
            {
                goto label_29;
            }
            
            label_27:
            val_20 = val_5;
            goto label_30;
            label_28:
            var val_6 = (val_5 + 88) + 0;
            val_8 = val_8 + (((val_5 + 88 + 0) + 4) << 3);
            val_20 = val_8 + 220;
            label_30:
            if(val_5 == 0)
            {
                goto label_31;
            }
            
            val_19 = mem[SL];
            val_19 = SL;
            label_25:
            label_31:
            var val_7 = FP - 28;
        }
        protected override void LoadFromLocal()
        {
            System.DateTime val_12;
            var val_13;
            this.LoadFromLocal();
            this.shields = UnityEngine.PlayerPrefs.GetInt(key:  582877504);
            this.currentChestID = UnityEngine.PlayerPrefs.GetInt(key:  582877600, defaultValue:  1);
            string val_3 = UnityEngine.PlayerPrefs.GetString(key:  582877696, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  582877696)) != true)
            {
                    object val_5 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  582877696);
                this.restaurantMapData = "res_frst_mapdata";
            }
            
            string val_6 = UnityEngine.PlayerPrefs.GetString(key:  571046688, defaultValue:  1098586544);
            if((System.String.IsNullOrEmpty(value:  571046688)) != true)
            {
                    System.DateTime val_8 = DateTimeCheat.UtcNow;
                System.DateTime val_11 = SLCDateTime.ParseInvariant(dateTime:  582896824, defaultValue:  new System.DateTime() {dateData = 1152921513767828256});
                this.lastRechargeCollected = val_12;
                mem[1152921513779690788] = val_13;
            }
            
            this.raidsReceived = UnityEngine.PlayerPrefs.GetInt(key:  582878832, defaultValue:  0);
            this.attacksReceived = UnityEngine.PlayerPrefs.GetInt(key:  582878928, defaultValue:  0);
            this.lastFiveAttackResults = UnityEngine.PlayerPrefs.GetInt(key:  582879040, defaultValue:  0);
            this.mapServerId = UnityEngine.PlayerPrefs.GetInt(key:  582879152, defaultValue:  0);
            this.MapVersion = UnityEngine.PlayerPrefs.GetInt(key:  582879264, defaultValue:  0);
            this.spins = UnityEngine.PlayerPrefs.GetInt(key:  582879360, defaultValue:  8);
            this.totalSpinned = UnityEngine.PlayerPrefs.GetInt(key:  582879456, defaultValue:  0);
            this.avatarId = UnityEngine.PlayerPrefs.GetInt(key:  582879568, defaultValue:  0);
            string val_22 = UnityEngine.PlayerPrefs.GetString(key:  582879664, defaultValue:  1098586544);
            this.playerName = "res_player_name";
            this.tutorialCompleted = UnityEngine.PlayerPrefs.GetInt(key:  582879776, defaultValue:  this.tutorialCompleted);
            this.auto_spin_tutorial_completed = UnityEngine.PlayerPrefs.GetInt(key:  582879888, defaultValue:  0);
            this.revenge_tutorial_completed = UnityEngine.PlayerPrefs.GetInt(key:  582880000, defaultValue:  0);
            this.watch_ads_spin_tutorial_completed = UnityEngine.PlayerPrefs.GetInt(key:  582880112, defaultValue:  0);
            this.bet_multiplier_tutorial_completed = UnityEngine.PlayerPrefs.GetInt(key:  582880240, defaultValue:  0);
            this.extra_shield_4th_tutorial_completed = UnityEngine.PlayerPrefs.GetInt(key:  582880368, defaultValue:  0);
            this.extra_shield_5th_tutorial_completed = UnityEngine.PlayerPrefs.GetInt(key:  582880496, defaultValue:  0);
            this.increase_rechargeable_spin_tutorial_completed = UnityEngine.PlayerPrefs.GetInt(key:  582880624, defaultValue:  0);
            if(this.restaurantMapData != 0)
            {
                    return;
            }
            
            RestaurantRivals.Map val_31 = RestaurantRivals.RESGameEconHelper.CreateStartingMap();
            this.restaurantMapData = 0;
        }
        protected override void CreateNewPlayer(string id = " ")
        {
            var val_3;
            this.CreateNewPlayer(id:  id);
            GameBehavior val_1 = App.getBehavior;
            mem[1152921513779810700] = 0;
            this.shields = 0;
            this.tutorialCompleted = 0;
            this.mapServerId = 0;
            this.currentChestID = 1;
            RestaurantRivals.Map val_2 = RestaurantRivals.RESGameEconHelper.CreateStartingMap();
            this.restaurantMapData = 0;
            val_3 = null;
            val_3 = null;
            this.lastRechargeCollected = System.DateTime.MaxValue;
            mem[1152921513779810980] = System.DateTime.__il2cppRuntimeField_cctor_finished;
            this.MapVersion = 0;
            this.spins = 8;
            this.totalSpinned = 0;
            this.avatarId = 0;
            this.playerName = "";
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
            if(this.restaurantMapData != 0)
            {
                    return;
            }
            
            RestaurantRivals.Map val_1 = RestaurantRivals.RESGameEconHelper.CreateStartingMap();
            mem2[0] = 0;
        }
        public RESPlayer()
        {
            var val_1;
            this.spins = 8;
            this.totalSpinned = 0;
            val_1 = null;
            val_1 = null;
            this.lastRechargeCollected = System.DateTime.MaxValue;
            mem[1152921513780289700] = System.DateTime.__il2cppRuntimeField_cctor_finished;
        }
    
    }

}
