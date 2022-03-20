using UnityEngine;

namespace WordForest
{
    public class WFOMysteryChestManager : MonoSingleton<WordForest.WFOMysteryChestManager>
    {
        // Fields
        private const string MysteryChestFTUXKey = "WFOMysteryChestFTUX";
        public const string ON_MYSTERY_CHEST_COLLECTED = "OnMysteryChestCollected";
        private RandomSet chestCountRandomSet;
        private System.Collections.Generic.Dictionary<string, WordForest.ChestLocData> currentChestLocData;
        private bool hack_isForcedRewardAttack;
        private bool hack_isForcedRewardRaid;
        private int hack_islandParadiseSymbolCount;
        
        // Properties
        public static bool IsFeatureUnlocked { get; }
        public int GetLevelIndex { get; }
        public int GetChestCount { get; }
        public int GetCollectedChestCount { get; }
        public int LastMysteryChestCollectedPlayerLvel { get; set; }
        public int Hack_IslandParadiseSymbolCount { get; }
        
        // Methods
        public static bool get_IsFeatureUnlocked()
        {
            WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
            WordForest.WFOGameEcon val_2 = WordForest.WFOGameEcon.Instance;
            if(19 >= 348)
            {
                    0 = 1;
            }
            
            return true;
        }
        public override void InitMonoSingleton()
        {
            this.chestCountRandomSet.replacement = true;
            this.chestCountRandomSet.add(item:  1, weight:  null);
            this.chestCountRandomSet.add(item:  2, weight:  null);
            this.chestCountRandomSet.add(item:  3, weight:  null);
        }
        public int GetRandomChestCount()
        {
            if(this.IsFTUXCompleted() == false)
            {
                    return 1;
            }
            
            if(this.chestCountRandomSet != 0)
            {
                    return this.chestCountRandomSet.roll(unweighted:  false);
            }
            
            return this.chestCountRandomSet.roll(unweighted:  false);
        }
        public int get_GetLevelIndex()
        {
            WordForest.ChestLocData val_1 = this.GetCurrentChestPlacementData(mode:  1);
            if(this == 0)
            {
                    this = 0;
            }
            
            return (int)this;
        }
        public int get_GetChestCount()
        {
            WordForest.ChestLocData val_1 = this.GetCurrentChestPlacementData(mode:  1);
            if(this == 0)
            {
                    return 0;
            }
            
            if(this.chestCountRandomSet != 0)
            {
                    return (int)this.chestCountRandomSet.items;
            }
            
            return (int)this.chestCountRandomSet.items;
        }
        public int get_GetCollectedChestCount()
        {
            var val_3;
            var val_4;
            WordForest.ChestLocData val_1 = this.GetCurrentChestPlacementData(mode:  1);
            if(this == 0)
            {
                goto label_1;
            }
            
            val_3 = 0;
            val_4 = 0;
            goto label_2;
            label_7:
            if(this.chestCountRandomSet.items <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_3 = this.chestCountRandomSet.replacement;
            val_3 = val_3 + 0;
            val_4 = val_4 + ((this.chestCountRandomSet.replacement + 0) + 16.Collected);
            val_3 = 1;
            label_2:
            if(val_3 < this.chestCountRandomSet.items)
            {
                goto label_7;
            }
            
            return (int)val_4;
            label_1:
            val_4 = 0;
            return (int)val_4;
        }
        public int GetWordIndex(int chestIndex)
        {
            var val_2;
            var val_3;
            val_2 = 35628483;
            WordForest.ChestLocData val_1 = this.GetCurrentChestPlacementData(mode:  1);
            val_3 = 0;
            if(this == 0)
            {
                    return (int)val_3;
            }
            
            val_2 = this;
            if(this.chestCountRandomSet.items <= chestIndex)
            {
                    return (int)val_3;
            }
            
            if(this.chestCountRandomSet.items <= chestIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_2 = this.chestCountRandomSet.replacement;
            val_2 = val_2 + (chestIndex << 2);
            val_3 = mem[(this.chestCountRandomSet.replacement + (chestIndex) << 2) + 16 + 8];
            val_3 = (this.chestCountRandomSet.replacement + (chestIndex) << 2) + 16 + 8;
            return (int)val_3;
        }
        public int GetCellIndex(int chestIndex)
        {
            var val_2;
            var val_3;
            val_2 = 35628484;
            WordForest.ChestLocData val_1 = this.GetCurrentChestPlacementData(mode:  1);
            val_3 = 0;
            if(this == 0)
            {
                    return (int)val_3;
            }
            
            val_2 = this;
            if(this.chestCountRandomSet.items <= chestIndex)
            {
                    return (int)val_3;
            }
            
            if(this.chestCountRandomSet.items <= chestIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_2 = this.chestCountRandomSet.replacement;
            val_2 = val_2 + (chestIndex << 2);
            val_3 = mem[(this.chestCountRandomSet.replacement + (chestIndex) << 2) + 16 + 12];
            val_3 = (this.chestCountRandomSet.replacement + (chestIndex) << 2) + 16 + 12;
            return (int)val_3;
        }
        public int get_LastMysteryChestCollectedPlayerLvel()
        {
            return UnityEngine.PlayerPrefs.GetInt(key:  330978288, defaultValue:  0);
        }
        private void set_LastMysteryChestCollectedPlayerLvel(int value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  330978288, value:  value);
        }
        public System.Collections.Generic.List<int> GetChestsWordIndexes()
        {
            var val_3;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            WordForest.ChestLocData val_2 = this.GetCurrentChestPlacementData(mode:  1);
            if(this == 0)
            {
                    return;
            }
            
            val_3 = 0;
            goto label_2;
            label_8:
            if(this.chestCountRandomSet.items <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_3 = this.chestCountRandomSet.replacement;
            val_3 = val_3 + 0;
            Add(item:  (this.chestCountRandomSet.replacement + 0) + 16 + 8);
            val_3 = 1;
            label_2:
            if(val_3 < this.chestCountRandomSet.items)
            {
                goto label_8;
            }
        
        }
        public WordForest.ChestLocData GetCurrentChestPlacementData(GameplayMode mode = 1)
        {
            string val_10;
            var val_12;
            var val_13;
            var val_14;
            if(mem[1152921513528162304].Count <= 0)
            {
                goto label_2;
            }
            
            label_33:
            val_12 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_13 = 0;
            if((mem[1152921513528162304].ContainsKey(key:  375291904)) == false)
            {
                    return;
            }
            
            val_12 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_3 = mem[1152921513528162304].Item[375291904];
            val_13 = mem[1152921513528162304];
            return;
            label_2:
            val_13 = 0;
            string val_4 = UnityEngine.PlayerPrefs.GetString(key:  331354336, defaultValue:  null);
            val_12 = "myschst_curr_chstsloc";
            if((System.String.IsNullOrEmpty(value:  331354336)) != false)
            {
                    return;
            }
            
            object val_6 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  331354336);
            Dictionary.Enumerator<TKey, TValue> val_7 = GetEnumerator();
            label_17:
            if(0.MoveNext() == false)
            {
                goto label_15;
            }
            
            WordForest.ChestLocData val_11 = new WordForest.ChestLocData(serialized:  val_10);
            mem[1152921513528162304].set_Item(key:  0, value:  408891392);
            goto label_17;
            label_15:
            0.Dispose();
            if(0 == 0)
            {
                goto label_33;
            }
            
            goto label_33;
            label_34:
            val_14 = 0;
            if(0 != 1)
            {
                goto label_28;
            }
            
            if(null == 0)
            {
                goto label_29;
            }
            
            UnityEngine.Debug.LogWarning(message:  331355472);
            mem[1152921513528162304].Clear();
            goto label_33;
            label_29:
            mem[4] = 1179403647;
            goto label_34;
            label_28:
        }
        public void SetCurrentChestLocData(GameplayMode mode, int gameLevel, int lineWordIndex, int cellIndex, bool collected, int chestIndex)
        {
            var val_10;
            var val_11;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if((this.currentChestLocData.ContainsKey(key:  375291904)) != false)
            {
                    UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                WordForest.ChestLocData val_2 = this.currentChestLocData.Item[375291904];
                val_10 = this.currentChestLocData;
            }
            else
            {
                    WordForest.ChestLocData val_3 = null;
                val_10 = val_3;
                val_3 = new WordForest.ChestLocData();
            }
            
            if(val_10 != 0)
            {
                    typeof(WordForest.ChestLocData).__il2cppRuntimeField_8 = gameLevel;
            }
            else
            {
                    mem[8] = gameLevel;
            }
            
            val_11 = WordForest.ChestLocData.__il2cppRuntimeField_namespaze;
            WordForest.ChestData val_4 = new WordForest.ChestData(wordIndex:  lineWordIndex, cellIndex:  cellIndex, isCollected:  collected);
            set_Item(index:  chestIndex, value:  408838144);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.currentChestLocData.set_Item(key:  375291904, value:  408891392);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Dictionary.Enumerator<TKey, TValue> val_6 = 0.GetEnumerator();
            label_23:
            if(0.MoveNext() == false)
            {
                goto label_19;
            }
            
            string val_8 = 0.Serialize();
            Add(key:  R5, value:  0);
            goto label_23;
            label_19:
            0.Dispose();
            string val_9 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  331354336, value:  78753792);
        }
        public void ClearChestLocData(GameplayMode mode)
        {
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            bool val_1 = this.currentChestLocData.Remove(key:  375291904);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Dictionary.Enumerator<TKey, TValue> val_3 = 0.GetEnumerator();
            label_9:
            if(0.MoveNext() == false)
            {
                goto label_5;
            }
            
            string val_5 = 0.Serialize();
            Add(key:  R6, value:  0);
            goto label_9;
            label_5:
            0.Dispose();
            string val_6 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  331354336, value:  78753792);
        }
        public System.Collections.Generic.List<System.Collections.Generic.List<WordForest.WFORewardData>> OpenMysteryChest(int chestCount, out System.Collections.Generic.List<WordForest.WFOWordChestType> chestTypeSet)
        {
            int val_8;
            WordForest.WFOMysteryChestManager val_13;
            var val_14;
            float val_15;
            var val_16;
            WordPets.WordPetType val_17;
            val_13 = this;
            val_14 = chestCount;
            System.Collections.Generic.List<WordPets.WordPetType> val_1 = new System.Collections.Generic.List<WordPets.WordPetType>();
            chestTypeSet = null;
            if(WordForest.WFOMysteryChestManager.IsFeatureUnlocked == false)
            {
                goto label_1;
            }
            
            RandomSet val_3 = null;
            val_13 = val_3;
            val_3 = new RandomSet();
            typeof(RandomSet).__il2cppRuntimeField_8 = 1;
            WordForest.WFOGameEcon val_4 = WordForest.WFOGameEcon.Instance;
            Dictionary.Enumerator<TKey, TValue> val_5 = 0.GetEnumerator();
            label_7:
            if(0.MoveNext() == false)
            {
                goto label_5;
            }
            
            add(item:  R4, weight:  0f);
            goto label_7;
            label_1:
            val_16 = 0;
            Add(item:  0);
            return;
            label_5:
            0.Dispose();
            if(val_14 >= 1)
            {
                    val_15 = 1152921513514614800;
                do
            {
                WordForest.WFOPlayer val_7 = WordForest.WFOPlayer.Instance;
                val_17 = 1;
                if((MonoExtensions.IsBitSet(value:  val_8, bit:  9)) != false)
            {
                    val_17 = roll(unweighted:  false);
            }
            
                Add(item:  val_17);
                val_14 = val_14 - 1;
            }
            while(chestTypeSet != 0);
            
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<WordForest.WFORewardData>> val_11 = this.GetRandomRewardForChest(chestTypeSet:  80883712, isMystery:  true);
            val_16 = val_13;
            int val_12 = PlayingLevel.GetCurrentPlayerLevelNumber();
            val_12.LastMysteryChestCollectedPlayerLvel = val_12;
        }
        public System.Collections.Generic.List<System.Collections.Generic.List<WordForest.WFORewardData>> GetRandomRewardForChest(System.Collections.Generic.List<WordForest.WFOWordChestType> chestTypeSet, bool isMystery)
        {
            int val_11;
            var val_58;
            int val_59;
            var val_60;
            System.Collections.Generic.List<WordForest.WFORewardData> val_61;
            var val_62;
            var val_63;
            var val_65;
            var val_66;
            var val_68;
            System.Predicate<WordForest.WFORewardData> val_69;
            if(35628492 == 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(35628492 > 0)
            {
                    WordForest.WFOGameEcon val_20 = WordForest.WFOGameEcon.Instance;
                val_58 = 0;
                if((chestTypeSet + 12) <= val_58)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_58 = 0;
            }
            
                var val_55 = chestTypeSet + 8;
                val_55 = val_55 + 0;
                int val_21 = 1289.Item[(chestTypeSet + 8 + 0) + 16];
                val_59 = val_21;
                WordForest.WFOPlayer val_22 = WordForest.WFOPlayer.Instance;
                WordForest.WFOPlayer val_23 = WordForest.WFOPlayer.Instance;
                WordForest.WFOGameEcon val_24 = WordForest.WFOGameEcon.Instance;
                WordForest.WFOGameEcon val_26 = WordForest.WFOGameEcon.Instance;
                val_60 = 0;
                if((0.ContainsKey(key:  val_21 + 328)) != false)
            {
                    System.TimeType val_27 = val_60.Item[val_21 + 328];
                val_61 = null;
                val_61 = new System.Collections.Generic.List<WordForest.WFORewardData>(collection:  0);
            }
            else
            {
                    Dictionary.KeyCollection<TKey, TValue> val_29 = val_60.Keys;
                int val_30 = System.Linq.Enumerable.Last<System.Int32>(source:  0);
                WordForest.WFOGameEcon val_31 = WordForest.WFOGameEcon.Instance;
                System.TimeType val_33 = 0.Item[UnityEngine.Mathf.Min(a:  val_30, b:  val_21 + 328)];
                val_61 = null;
                val_61 = new System.Collections.Generic.List<WordForest.WFORewardData>(collection:  0);
                val_60 = null;
                typeof(System.Object[]).__il2cppRuntimeField_10 = "[MysteryChest] Cannot find reward data for forest ";
                typeof(System.Object[]).__il2cppRuntimeField_14 = null;
                typeof(System.Object[]).__il2cppRuntimeField_18 = " defaulting to ";
                int val_35 = UnityEngine.Mathf.Min(a:  val_30, b:  val_21 + 328);
                typeof(System.Object[]).__il2cppRuntimeField_1C = null;
                string val_36 = +472754880;
                UnityEngine.Debug.LogWarning(message:  472754880);
            }
            
                if(IslandParadiseEventHandler.IsEventActive != false)
            {
                    if(IslandParadiseEventHandler._Instance.HasCollectedAllRewards() != true)
            {
                    val_11 = val_21;
                WordForest.WFORewardData val_39 = new WordForest.WFORewardData(rType:  7, rAmt:  1);
                Add(item:  new WordForest.WFORewardData() {id = val_39.id, rewardType = val_39.rewardType, amount = new System.Decimal() {flags = val_39.amount.flags, hi = val_39.amount.hi, lo = val_39.amount.lo, mid = val_39.amount.mid}, transformToId = val_39.transformToId});
                WordForest.WFORewardData val_40 = new WordForest.WFORewardData(rType:  7, rAmt:  1);
                Add(item:  new WordForest.WFORewardData() {id = val_40.id, rewardType = val_40.rewardType, amount = new System.Decimal() {flags = val_40.amount.flags, hi = val_40.amount.hi, lo = val_40.amount.lo, mid = val_40.amount.mid}, transformToId = val_40.transformToId});
                WordForest.WFORewardData val_41 = new WordForest.WFORewardData(rType:  7, rAmt:  1);
                val_60 = public System.Void System.Collections.Generic.List<WordForest.WFORewardData>::Add(WordForest.WFORewardData item);
                Add(item:  new WordForest.WFORewardData() {id = val_41.id, rewardType = val_41.rewardType, amount = new System.Decimal() {flags = val_41.amount.flags, hi = val_41.amount.hi, lo = val_41.amount.lo, mid = val_41.amount.mid}, transformToId = val_41.transformToId});
                val_59 = val_59;
            }
            
            }
            
                val_62 = 0;
                PluginExtension.Shuffle<WordForest.WFORewardData>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
                RandomSet val_42 = null;
                val_63 = val_42;
                val_42 = new RandomSet();
                val_11 = null;
                System.Collections.Generic.List<WordForest.WFORewardData> val_47 = new System.Collections.Generic.List<WordForest.WFORewardData>();
                if(val_59 >= 1)
            {
                    do
            {
                int val_48 = roll(unweighted:  false);
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                int val_49 = (val_48 << 3) - val_48;
                val_65 = val_11;
                if(val_65 == 0)
            {
                    val_65 = val_11;
            }
            
                Add(item:  new WordForest.WFORewardData() {id = mem[((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (((val_48) << 3 - val_48)) << 2) + 16) + (0)], rewardType = mem[((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (((val_48) << 3 - val_48)) << 2) + 16) + (4)], amount = new System.Decimal() {flags = mem[((System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (((val_48) << 3 - val_48)) << 2) + 16) + (8)], hi = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (((val_48) << 3 - val_48)) << 2) + 28, lo = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (((val_48) << 3 - val_48)) << 2) + 32, mid = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (((val_48) << 3 - val_48)) << 2) + 36}, transformToId = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (((val_48) << 3 - val_48)) << 2) + 40});
                int val_56 = val_59;
                val_56 = val_56 - 1;
            }
            while(val_65 != 0);
            
            }
            
                if(mem[1152921513528706692] != false)
            {
                    val_66 = null;
                val_66 = null;
                val_68 = val_11;
                val_69 = WFOMysteryChestManager.<>c.<>9__24_0;
                if(val_69 == 0)
            {
                    val_69 = null;
                val_69 = new System.Predicate<WordForest.WFORewardData>(object:  WFOMysteryChestManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(331900080));
                val_68 = val_11;
                WFOMysteryChestManager.<>c.<>9__24_0 = val_69;
            }
            
                if(val_68 == 0)
            {
                    val_68 = val_11;
            }
            
                if((FindIndex(match:  8040448)) == 1)
            {
                
            }
            
            }
            
            }
        
        }
        public bool IsFTUXCompleted()
        {
            int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  332017200, defaultValue:  0);
            if(val_1 != 1)
            {
                    val_1 + 1 = 1;
            }
            
            return true;
        }
        public void CompleteFTUX()
        {
            UnityEngine.PlayerPrefs.SetInt(key:  332017200, value:  1);
        }
        public void Hack_ForceRewardAttack()
        {
            this.hack_isForcedRewardAttack = true;
        }
        public void Hack_ForceRewardRaid()
        {
            this.hack_isForcedRewardRaid = true;
        }
        public int get_Hack_IslandParadiseSymbolCount()
        {
            return (int)this.hack_islandParadiseSymbolCount;
        }
        public void Hack_ForceIslandParadiseSymbolCount(int value)
        {
            this.hack_islandParadiseSymbolCount = UnityEngine.Mathf.Clamp(value:  value, min:  0, max:  3);
        }
        public void Hack_ClearForcedReward()
        {
            this.hack_islandParadiseSymbolCount = 0;
            this.hack_isForcedRewardAttack = false;
            this.hack_isForcedRewardRaid = false;
        }
        public string Hack_ChestRewardHackStatus()
        {
            if(this.hack_isForcedRewardAttack != true)
            {
                    if(this.hack_isForcedRewardRaid == false)
            {
                    this.hack_isForcedRewardRaid = this.hack_islandParadiseSymbolCount;
            }
            
                if(this.hack_isForcedRewardRaid == 1)
            {
                    return;
            }
            
            }
            
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(this.hack_isForcedRewardRaid != false)
            {
                    System.Text.StringBuilder val_2 = Append(value:  332801312);
            }
            
            if(this.hack_isForcedRewardAttack != false)
            {
                    System.Text.StringBuilder val_3 = Append(value:  332801408);
            }
            
            if(this.hack_islandParadiseSymbolCount == 1)
            {
                    return;
            }
            
            string val_4 = 332801488 + 13152256 + 332801584;
            System.Text.StringBuilder val_5 = Append(value:  332801488);
        }
        public WFOMysteryChestManager()
        {
            this.chestCountRandomSet = new RandomSet();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.hack_islandParadiseSymbolCount = 0;
            this.currentChestLocData = null;
        }
    
    }

}
