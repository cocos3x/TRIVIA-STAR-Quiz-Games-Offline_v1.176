using UnityEngine;

namespace WordForest
{
    public class WFOGameEcon : GameEcon
    {
        // Fields
        public const string ECON_JSON_KNOBS = "wfo_econ_json_knobs";
        public int InitialPlayerGoldenCurrency;
        private int wordForestUnlockLevel;
        private int wordForestPopupLevel;
        private int rewardWordChestUnlockLevel;
        private int mysteryChestUnlockLevel;
        private int wordStreakUnlockLevel;
        private int wordStreakTutorialLevel;
        private int rewardFuseCount;
        private System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, int> wordChestWeight;
        private System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, int> wordChestRequiredWords;
        private System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, int> wordChestRewardAmount;
        private System.Collections.Generic.Dictionary<int, int> initialPlayerChestRewardInventory;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<WordForest.WFORewardData>> mysteryRewards;
        private System.Collections.Generic.Dictionary<int, UnityEngine.Vector2Int> raidEligibleAcornsMinMax;
        private System.Collections.Generic.Dictionary<int, UnityEngine.Vector2Int> attackRewardAcorns;
        private System.Collections.Generic.List<WordForest.WFOForestData> forests;
        private System.Collections.Generic.Dictionary<WordForest.FtuxId, float> ftuxForestGrowthPercent;
        private System.Collections.Generic.Dictionary<WordForest.FtuxId, int> ftuxForestInitDestroyedTrees;
        private System.Collections.Generic.List<WordForest.WFOForestChestData> forestChests;
        public int mysteryGiftReward;
        public int offensiveActionsPerDay;
        public int daysOfOffensiveActionsPostSession;
        public float attackSuccessRate;
        public int maxUnblockAttacksReceived;
        public int maxRaidsReceived;
        
        // Properties
        public static WordForest.WFOGameEcon Instance { get; }
        public int MaxShields { get; }
        public int WordForestUnlockLevel { get; }
        public int WordForestPopupLevel { get; }
        public int RewardWordChestUnlockLevel { get; }
        public int MysteryChestUnlockLevel { get; }
        public int WordStreakUnlockLevel { get; }
        public int WordStreakTutorialLevel { get; }
        public int RewardFuseCount { get; }
        public System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, int> WordChestWeight { get; }
        public System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, int> WordChestRequiredWords { get; }
        public System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, int> WordChestRewardAmount { get; }
        public System.Collections.Generic.Dictionary<int, int> InitialPlayerChestRewardInventory { get; }
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<WordForest.WFORewardData>> MysteryRewards { get; }
        public System.Collections.Generic.Dictionary<int, UnityEngine.Vector2Int> RaidEligibleAcornsMinMax { get; }
        public System.Collections.Generic.Dictionary<int, UnityEngine.Vector2Int> AttackRewardAcorns { get; }
        public System.Collections.Generic.List<WordForest.WFOForestData> Forests { get; }
        public System.Collections.Generic.Dictionary<WordForest.FtuxId, float> FtuxForestGrowthPercent { get; }
        public System.Collections.Generic.Dictionary<WordForest.FtuxId, int> FtuxForestInitDestroyedTrees { get; }
        public System.Collections.Generic.List<WordForest.WFOForestChestData> ForestChests { get; }
        
        // Methods
        public static WordForest.WFOGameEcon get_Instance()
        {
            var val_2 = 0;
            GameEcon val_1 = App.getGameEcon;
            if(0 == 0)
            {
                    return;
            }
        
        }
        public int get_MaxShields()
        {
            return 3;
        }
        public int get_WordForestUnlockLevel()
        {
            return (int)this.wordForestUnlockLevel;
        }
        public int get_WordForestPopupLevel()
        {
            return (int)this.wordForestPopupLevel;
        }
        public int get_RewardWordChestUnlockLevel()
        {
            return (int)this.rewardWordChestUnlockLevel;
        }
        public int get_MysteryChestUnlockLevel()
        {
            return (int)this.mysteryChestUnlockLevel;
        }
        public int get_WordStreakUnlockLevel()
        {
            return (int)this.wordStreakUnlockLevel;
        }
        public int get_WordStreakTutorialLevel()
        {
            return (int)this.wordStreakTutorialLevel;
        }
        public int get_RewardFuseCount()
        {
            return (int)this.rewardFuseCount;
        }
        public System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, int> get_WordChestWeight()
        {
        
        }
        public System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, int> get_WordChestRequiredWords()
        {
        
        }
        public System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, int> get_WordChestRewardAmount()
        {
        
        }
        public System.Collections.Generic.Dictionary<int, int> get_InitialPlayerChestRewardInventory()
        {
        
        }
        public System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<WordForest.WFORewardData>> get_MysteryRewards()
        {
        
        }
        public System.Collections.Generic.Dictionary<int, UnityEngine.Vector2Int> get_RaidEligibleAcornsMinMax()
        {
        
        }
        public System.Collections.Generic.Dictionary<int, UnityEngine.Vector2Int> get_AttackRewardAcorns()
        {
        
        }
        public System.Collections.Generic.List<WordForest.WFOForestData> get_Forests()
        {
        
        }
        public System.Collections.Generic.Dictionary<WordForest.FtuxId, float> get_FtuxForestGrowthPercent()
        {
        
        }
        public System.Collections.Generic.Dictionary<WordForest.FtuxId, int> get_FtuxForestInitDestroyedTrees()
        {
        
        }
        public System.Collections.Generic.List<WordForest.WFOForestChestData> get_ForestChests()
        {
        
        }
        public override void ReadFromKnobs()
        {
            WordForest.WFOGameEcon val_17;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_18;
            var val_19;
            var val_20;
            val_17 = this;
            val_17.ReadFromKnobs();
            val_18 = null;
            val_18 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            var val_17 = 21594295;
            val_17 = 14033120 + val_17;
            if(val_17 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_19 = null;
            val_19 = null;
            val_20 = 0;
            twelvegigs.storage.JsonDictionary val_2 = getWordGameplayKnobs();
            if(App.storageManager.knobsModel == 0)
            {
                goto label_8;
            }
            
            if(null != null)
            {
                goto label_11;
            }
            
            val_20 = 0;
            goto label_13;
            label_8:
            if(val_18 != 0)
            {
                goto label_13;
            }
            
            label_11:
            val_18 = 0;
            val_20 = 1;
            label_13:
            if((val_18.ContainsKey(key:  308442640)) != false)
            {
                    val_17 = 1152921510385703632;
                string val_4 = val_18.Item[308442640];
                if((0.ContainsKey(key:  308442720)) != false)
            {
                    string val_6 = 0.Item[308442720];
                val_17 = val_17;
                bool val_8 = System.Single.TryParse(s:  null, result: out  float val_7 = 7.15825E-28f);
            }
            
            }
            
            if((val_18.ContainsKey(key:  308442800)) != false)
            {
                    string val_10 = val_18.Item[308442800];
                bool val_12 = System.Int32.TryParse(s:  null, result: out  int val_11 = 308468304);
            }
            
            if((UnityEngine.PlayerPrefs.HasKey(key:  308442880)) == false)
            {
                    return;
            }
            
            string val_14 = UnityEngine.PlayerPrefs.GetString(key:  308442880, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  308442880)) == true)
            {
                    return;
            }
            
            object val_16 = MiniJSON.Json.Deserialize(json:  308442880);
            if("wfo_econ_json_knobs" == 0)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            this.ParseServerJsonKnobs(jsonDict:  308442880);
        }
        public void CacheServerJsonKnobs(System.Collections.Generic.Dictionary<string, object> jsonDict)
        {
            string val_1 = MiniJSON.Json.Serialize(obj:  jsonDict);
            UnityEngine.PlayerPrefs.SetString(key:  308442880, value:  jsonDict);
            bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public void ParseServerJsonKnobs(System.Collections.Generic.Dictionary<string, object> jsonDict)
        {
            if((jsonDict.ContainsKey(key:  308679280)) != false)
            {
                    object val_2 = jsonDict.Item[308679280];
                string val_3 = jsonDict.ToString();
                bool val_5 = System.Int32.TryParse(s:  jsonDict, result: out  this.mysteryChestUnlockLevel);
            }
            
            if((jsonDict.ContainsKey(key:  308679424)) != false)
            {
                    object val_7 = jsonDict.Item[308679424];
                string val_8 = jsonDict.ToString();
                bool val_10 = System.Int32.TryParse(s:  jsonDict, result: out  this.wordStreakUnlockLevel);
            }
            
            if((jsonDict.ContainsKey(key:  308679568)) == false)
            {
                    return;
            }
            
            object val_12 = jsonDict.Item[308679568];
            string val_13 = jsonDict.ToString();
            bool val_15 = System.Int32.TryParse(s:  jsonDict, result: out  this.rewardWordChestUnlockLevel);
        }
        public WFOGameEcon()
        {
            System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_1 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            if(val_1 != 0)
            {
                    Add(key:  1, value:  50);
                Add(key:  2, value:  30);
            }
            else
            {
                    Add(key:  1, value:  50);
                Add(key:  2, value:  30);
            }
            
            Add(key:  3, value:  20);
            this.wordChestWeight = val_1;
            System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_2 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            if(val_2 != 0)
            {
                    Add(key:  1, value:  15);
                Add(key:  2, value:  20);
            }
            else
            {
                    Add(key:  1, value:  15);
                Add(key:  2, value:  20);
            }
            
            Add(key:  3, value:  25);
            this.wordChestRequiredWords = val_2;
            System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_3 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            if(val_3 != 0)
            {
                    Add(key:  1, value:  3);
                Add(key:  2, value:  5);
            }
            else
            {
                    Add(key:  1, value:  3);
                Add(key:  2, value:  5);
            }
            
            Add(key:  3, value:  7);
            this.wordChestRewardAmount = val_3;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            if(null != 0)
            {
                    Add(key:  0, value:  4);
                Add(key:  1, value:  4);
                Add(key:  2, value:  4);
                Add(key:  3, value:  4);
                Add(key:  4, value:  3);
                Add(key:  5, value:  3);
                Add(key:  6, value:  3);
                Add(key:  7, value:  2);
                Add(key:  8, value:  2);
                Add(key:  9, value:  2);
                Add(key:  10, value:  1);
                Add(key:  11, value:  1);
                Add(key:  24, value:  1);
                Add(key:  25, value:  1);
            }
        
        }
    
    }

}
