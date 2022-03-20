using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPITreasureChestController : MonoSingleton<SLC.MatchyPics.MPITreasureChestController>
    {
        // Fields
        public const string TREASURE_CHEST_KEY = "mpi_treasure_chest_key";
        public const string TREASURE_CHEST_FTUX_KEY = "mpi_treasure_chest_ftux_key";
        private int <CurrentStars>k__BackingField;
        private int <TotalRewards>k__BackingField;
        private SLC.MatchyPics.MPIEcon econ;
        
        // Properties
        public int CurrentStars { get; set; }
        public int TotalRewards { get; set; }
        public float Progress { get; }
        public bool IsCompleted { get; }
        
        // Methods
        public int get_CurrentStars()
        {
            return (int)this.<CurrentStars>k__BackingField;
        }
        private void set_CurrentStars(int value)
        {
            this.<CurrentStars>k__BackingField = value;
        }
        public int get_TotalRewards()
        {
            return (int)this.<TotalRewards>k__BackingField;
        }
        private void set_TotalRewards(int value)
        {
            this.<TotalRewards>k__BackingField = value;
        }
        public float get_Progress()
        {
            float val_1;
            if(this.econ != 0)
            {
                    val_1 = ((float)this.<CurrentStars>k__BackingField) / (float)this.econ.ChestStarReq;
                return val_1;
            }
            
            val_1 = 0f;
            return val_1;
        }
        public bool get_IsCompleted()
        {
            if(this.econ == 0)
            {
                    this = 0;
                return (bool)this;
            }
            
            if(0 >= this.econ.ChestStarReq)
            {
                    0 = 1;
            }
            
            return true;
        }
        public override void InitMonoSingleton()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  796297040, name:  -1898880160);
        }
        public void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.econ = public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12;
            this.LoadFromJson();
        }
        public void OnServerSync()
        {
            if((UnityEngine.PlayerPrefs.HasKey(key:  796497040)) == true)
            {
                    return;
            }
            
            Player val_2 = App.Player;
            if((System.String.IsNullOrEmpty(value:  35144028)) != false)
            {
                    return;
            }
            
            Player val_4 = App.Player;
            UnityEngine.PlayerPrefs.SetString(key:  796497040, value:  35144028);
            this.LoadFromJson();
        }
        public void LoadFromJson()
        {
            int val_11;
            if((UnityEngine.PlayerPrefs.HasKey(key:  796497040)) == false)
            {
                goto label_1;
            }
            
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  796497040);
            object val_3 = MiniJSON.Json.Deserialize(json:  796497040);
            if("mpi_treasure_chest_key" != 0)
            {
                    if(null == null)
            {
                goto label_15;
            }
            
            }
            
            label_15:
            if((0.ContainsKey(key:  796609152)) != false)
            {
                    string val_5 = 0.Item[796609152];
                this.<CurrentStars>k__BackingField = System.Int32.Parse(s:  null);
            }
            
            if((0.ContainsKey(key:  796609248)) == false)
            {
                goto label_9;
            }
            
            string val_8 = 0.Item[796609248];
            int val_9 = System.Int32.Parse(s:  null);
            this.<TotalRewards>k__BackingField = val_9;
            val_11 = val_9;
            goto label_12;
            label_1:
            this.<CurrentStars>k__BackingField = 0;
            this.<TotalRewards>k__BackingField = 1;
            return;
            label_9:
            val_11 = this.<TotalRewards>k__BackingField;
            label_12:
            this.<TotalRewards>k__BackingField = UnityEngine.Mathf.Max(a:  1, b:  val_11);
        }
        public void SaveToJson()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  796609152, value:  13152256);
            Add(key:  796609248, value:  13152256);
            string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  796497040, value:  78753792);
            Player val_3 = App.Player;
            if(2621448 != 0)
            {
                    return;
            }
        
        }
        public void AddStarProgress(int stars, bool incentiveVideoReward = False)
        {
            string val_6;
            int val_7;
            int val_8;
            val_6 = incentiveVideoReward;
            val_7 = stars;
            if(val_6 != false)
            {
                    val_7 = this.econ.StarsPerVideo + stars;
            }
            
            val_8 = val_7 + (this.<CurrentStars>k__BackingField);
            this.<CurrentStars>k__BackingField = val_8;
            this.<CurrentStars>k__BackingField = UnityEngine.Mathf.Max(a:  0, b:  val_8);
            if(stars >= 1)
            {
                    val_8 = null;
                val_8 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                if(val_6 != false)
            {
                    Add(key:  -1229110368, value:  13152256);
            }
            
                Player val_3 = App.Player;
                string val_4 = val_7.ToString();
                val_6;
                0.TrackNonCoinReward(source:  -1644596640, subSource:  null, rewardType:  -1238435648, rewardAmount:  val_7, additionalParams:  val_8);
            }
            
            this.SaveToJson();
        }
        public void AddChestReward(int rewards)
        {
            rewards = (this.<TotalRewards>k__BackingField) + rewards;
            this.<TotalRewards>k__BackingField = rewards;
            this.SaveToJson();
        }
        public System.Collections.Generic.List<GiftReward> LevelRewards()
        {
            int val_18;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_19;
            System.Collections.Generic.List<ZooTile> val_20;
            var val_21;
            System.Predicate<SLC.MatchyPics.MPIChestRewards> val_23;
            var val_24;
            val_18 = this;
            val_19 = 0;
            if(this.econ == 0)
            {
                    return;
            }
            
            if((this.<CurrentStars>k__BackingField) < this.econ.ChestStarReq)
            {
                    return;
            }
            
            val_20 = null;
            val_20 = new System.Collections.Generic.List<ZooTile>(collection:  this.econ.ChestRewards);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(Unlocked != true)
            {
                    val_21 = null;
                val_21 = null;
                val_23 = MPITreasureChestController.<>c.<>9__22_0;
                if(val_23 == 0)
            {
                    val_23 = null;
                val_23 = new System.Predicate<ZooTile>(object:  MPITreasureChestController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(797074752));
                MPITreasureChestController.<>c.<>9__22_0 = val_23;
            }
            
                System.Collections.Generic.List<T> val_5 = FindAll(match:  8040448);
                val_20 = val_20;
            }
            
            PluginExtension.Shuffle<UnityEngine.Sprite>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            val_18 = this.<TotalRewards>k__BackingField;
            System.Collections.Generic.List<T> val_7 = GetRange(index:  0, count:  UnityEngine.Mathf.Min(a:  val_18, b:  1094062063));
            val_19 = null;
            val_19 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_9 = GetEnumerator();
            label_33:
            if(MoveNext() == false)
            {
                goto label_17;
            }
            
            if((val_11 + 8) == 0)
            {
                goto label_19;
            }
            
            if((val_11 + 8) != 1)
            {
                goto label_33;
            }
            
            GiftReward val_12 = new GiftReward();
            typeof(GiftReward).__il2cppRuntimeField_8 = 6;
            val_24 = null;
            val_24 = null;
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GiftCollection val_14 = GetRandomItem();
            typeof(GiftReward).__il2cppRuntimeField_C = public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance();
            Add(item:  372842496);
            goto label_33;
            label_19:
            GiftReward val_15 = new GiftReward();
            typeof(GiftReward).__il2cppRuntimeField_8 = 0;
            decimal val_16 = System.Decimal.op_Implicit(value:  797097936);
            Add(item:  372842496);
            goto label_33;
            label_17:
            Dispose();
            System.Comparison<WordForest.NewsArticle> val_17 = new System.Comparison<WordForest.NewsArticle>(object:  0, method:  new IntPtr(797082944));
            Sort(comparison:  7933952);
        }
        public void CollectRewards(System.Collections.Generic.List<GiftReward> rewards)
        {
            var val_2;
            int val_8;
            var val_9;
            int val_10;
            int val_11;
            var val_18;
            var val_19;
            int val_20;
            var val_21;
            val_18 = public List.Enumerator<T> System.Collections.Generic.List<GiftReward>::GetEnumerator();
            List.Enumerator<T> val_1 = GetEnumerator();
            goto label_17;
            label_20:
            if((val_2 + 8) == 6)
            {
                goto label_4;
            }
            
            if((val_2 + 8) != 0)
            {
                goto label_17;
            }
            
            var val_3 = val_2 + 20;
            decimal val_4 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 797222568}, d2:  new System.Decimal() {hi = mem[(val_2 + 20) + (0)], lo = mem[(val_2 + 20) + (4)], mid = mem[(val_2 + 20) + (8)]});
            goto label_8;
            label_4:
            if((val_2 + 12 + 16) != 0)
            {
                goto label_10;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_19 = mem[val_2 + 12];
            val_19 = val_2 + 12;
            if(val_19 != 0)
            {
                    val_20 = mem[val_2 + 12 + 8];
                val_20 = val_2 + 12 + 8;
            }
            else
            {
                    val_20 = mem[val_2 + 12 + 8];
                val_20 = val_2 + 12 + 8;
                val_19 = mem[val_2 + 12];
                val_19 = val_2 + 12;
                if(val_19 == 0)
            {
                    val_19 = 0;
            }
            
            }
            
            val_18 = 0;
            CollectItem(setIndex:  val_20, spriteIndex:  0);
            goto label_17;
            label_10:
            var val_6 = val_2 + 20;
            decimal val_7 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 797222568}, d2:  new System.Decimal() {hi = mem[(val_2 + 20) + (0)], lo = mem[(val_2 + 20) + (4)], mid = mem[(val_2 + 20) + (8)]});
            label_8:
            label_17:
            if(MoveNext() == true)
            {
                goto label_20;
            }
            
            Dispose();
            val_21 = null;
            val_21 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_8, hi = val_9, lo = val_10, mid = val_11}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_14 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                val_8 = rewards + 12;
                Add(key:  797210304, value:  13152256);
                Player val_15 = App.Player;
                0.AddCredits(amount:  new System.Decimal() {flags = val_8, hi = val_9, lo = val_10, mid = val_11}, source:  "Treasure Chest Reward", subSource:  0, externalParams:  null, doTrack:  true);
            }
            
            if((UnityEngine.PlayerPrefs.HasKey(key:  797210512)) != true)
            {
                    Player val_17 = App.Player;
                UnityEngine.PlayerPrefs.SetInt(key:  797210512, value:  0);
            }
            
            mem[1152921513994016220] = 0;
            mem[1152921513994016224] = 1;
            this.SaveToJson();
        }
        public static int SortGifts(GiftReward a, GiftReward b)
        {
            var val_3;
            var val_4;
            val_3 = a;
            if(a.Type == b.Type)
            {
                    val_4 = 0;
                if((a + 8) != 6)
            {
                    return (int)val_4;
            }
            
                val_4 = 0;
                if(a.collectionItem.isCompleted == true)
            {
                    return (int)val_4;
            }
            
                if(b.collectionItem != 0)
            {
                    return (int)b.collectionItem.isCompleted;
            }
            
                return (int)b.collectionItem.isCompleted;
            }
            
            val_3 = null;
            if(null != 0)
            {
                    val_4 = CompareTo(target:  372789248);
            }
            else
            {
                    val_4 = CompareTo(target:  372789248);
            }
            
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            return (int)val_4;
        }
        public bool ShowFtux()
        {
            var val_8;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = 0;
            if((-852051584) == 0)
            {
                    return true;
            }
            
            val_8 = 0;
            if((UnityEngine.PlayerPrefs.HasKey(key:  797210512)) == false)
            {
                    return true;
            }
            
            val_8 = 0;
            int val_4 = UnityEngine.PlayerPrefs.GetInt(key:  797210512, defaultValue:  0);
            if(val_4 == 1)
            {
                    return true;
            }
            
            val_8 = 0;
            Player val_5 = App.Player;
            if(0 < val_4)
            {
                    return true;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 24) > 0)
            {
                    val_8 = 1;
            }
            
            return true;
        }
        public void CompletedFtux()
        {
            UnityEngine.PlayerPrefs.SetInt(key:  797210512, value:  0);
        }
        private void ResetProgress()
        {
            this.<CurrentStars>k__BackingField = 0;
            this.<TotalRewards>k__BackingField = 1;
        }
        public MPITreasureChestController()
        {
        
        }
    
    }

}
