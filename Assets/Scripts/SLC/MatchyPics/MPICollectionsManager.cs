using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPICollectionsManager : MonoSingleton<SLC.MatchyPics.MPICollectionsManager>
    {
        // Fields
        private UnityEngine.Texture defaultBackground;
        private System.Collections.Generic.List<UnityEngine.Sprite> bgRewards;
        public const string COLLECTIONS_KEY = "mpi_collections_key";
        public const string DEFAUL_BG_NAME = "BLUE ZEN";
        public const string BACKGROUND_CHANGED = "OnBackgroundChanged";
        public const int DEFAULT_BG_INDEX = -1;
        public const int COIN_REWARD_PER_ITEM = 1;
        private System.Collections.Generic.List<SLC.MatchyPics.MPICollection> <collections>k__BackingField;
        private SLC.MatchyPics.MPIEcon econ;
        private int backgroundIndex;
        private bool ftuxShown;
        
        // Properties
        public System.Collections.Generic.List<SLC.MatchyPics.MPICollection> collections { get; set; }
        public int CurrentBckgIndex { get; }
        public int UnlockLevel { get; }
        public bool Unlocked { get; }
        
        // Methods
        public System.Collections.Generic.List<SLC.MatchyPics.MPICollection> get_collections()
        {
        
        }
        private void set_collections(System.Collections.Generic.List<SLC.MatchyPics.MPICollection> value)
        {
            this.<collections>k__BackingField = value;
        }
        public int get_CurrentBckgIndex()
        {
            return (int)this.backgroundIndex;
        }
        public int get_UnlockLevel()
        {
            if(this.econ != 0)
            {
                    return (int)this.econ.UnlockLevelCollections;
            }
            
            return (int)this.econ.UnlockLevelCollections;
        }
        public bool get_Unlocked()
        {
            GameBehavior val_1 = App.getBehavior;
            if(0 >= this.econ.UnlockLevelCollections)
            {
                    0 = 1;
            }
            
            return true;
        }
        public override void InitMonoSingleton()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.MatchyPics.MPIEcon val_2 = Econ;
            this.econ = public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance();
        }
        public void Start()
        {
            this.InitCollections();
            this.LoadFromJson();
        }
        public SLC.MatchyPics.MPICollection GetCollection(int imageSetIndex)
        {
            MPICollectionsManager.<>c__DisplayClass22_0 val_1 = new MPICollectionsManager.<>c__DisplayClass22_0();
            typeof(MPICollectionsManager.<>c__DisplayClass22_0).__il2cppRuntimeField_8 = imageSetIndex;
            System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  436846592, method:  new IntPtr(742715008));
            if((this.<collections>k__BackingField) != 0)
            {
                    return this.<collections>k__BackingField.Find(match:  8040448);
            }
            
            return this.<collections>k__BackingField.Find(match:  8040448);
        }
        public int ItemsPerLevel(int levelIndex)
        {
            int val_1;
            int val_1 = this.econ.UnlockLevelCollections;
            val_1 = 0;
            val_1 = val_1 - 1;
            if(val_1 > levelIndex)
            {
                    return val_1;
            }
            
            if(this.econ.LevelPerCollection != 0)
            {
                    return val_1;
            }
            
            val_1 = this.econ.CollectionItemPerLevel;
            return val_1;
        }
        public System.Collections.Generic.List<int> GetRandomItems(int count, int setIndex)
        {
            if(true <= setIndex)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (setIndex << 2);
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>(collection:  (0 + (setIndex) << 2) + 16 + 16);
            PluginExtension.Shuffle<System.Int32>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            if(null != 0)
            {
                    return GetRange(index:  0, count:  count);
            }
            
            return GetRange(index:  0, count:  count);
        }
        public void CollectItem(int setIndex, int spriteIndex)
        {
            var val_3;
            System.Collections.Generic.List<SLC.MatchyPics.MPICollection> val_4;
            val_3 = setIndex;
            val_4 = this.<collections>k__BackingField;
            if(true <= val_3)
            {
                    return;
            }
            
            val_4 = this.<collections>k__BackingField;
            if(true <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (val_3 << 2);
            val_3 = mem[(0 + (setIndex) << 2) + 16];
            val_3 = (0 + (setIndex) << 2) + 16;
            if((System.Array.IndexOf<System.Int32>(array:  (0 + (setIndex) << 2) + 16 + 16, value:  spriteIndex)) < 0)
            {
                    return;
            }
            
            if(((0 + (setIndex) << 2) + 16 + 24) != 0)
            {
                    return;
            }
            
            var val_2 = (R6 + 20) + ((R5) << 2);
            var val_4 = (R6 + 20 + (R5) << 2) + 16;
            val_4 = val_4 + 1;
            mem2[0] = val_4;
            R4.SaveToJson();
        }
        public bool ShowLossProgress(int setIndex)
        {
            System.Collections.Generic.List<SLC.MatchyPics.MPICollection> val_3;
            var val_4;
            val_3 = this;
            val_4 = 0;
            if(true <= setIndex)
            {
                    return true;
            }
            
            val_3 = this.<collections>k__BackingField;
            if(true <= setIndex)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (setIndex << 2);
            if(((0 + (setIndex) << 2) + 16.CollectedItems()) == 16)
            {
                    return true;
            }
            
            if(((0 + (setIndex) << 2) + 16.CollectedItems()) > 0)
            {
                    val_4 = 1;
            }
            
            return true;
        }
        public void ResetProgress(int setIndex)
        {
            if(true <= setIndex)
            {
                    return;
            }
            
            if(true <= setIndex)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = 0;
            val_2 = val_2 + (setIndex << 2);
            do
            {
                var val_1 = ((0 + (setIndex) << 2) + 16 + 20) + 0;
                val_3 = val_3 + 1;
                mem2[0] = 0;
            }
            while(val_3 != 16);
            
            this.SaveToJson();
        }
        public void SetBackground(int CollectionIndex)
        {
            System.Collections.Generic.List<SLC.MatchyPics.MPICollection> val_3 = this.<collections>k__BackingField;
            if(true <= CollectionIndex)
            {
                    return;
            }
            
            if(CollectionIndex != 1)
            {
                    if(true <= CollectionIndex)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + (CollectionIndex << 2);
                val_3 = mem[(0 + (CollectionIndex) << 2) + 16];
                val_3 = (0 + (CollectionIndex) << 2) + 16;
                if(val_3.CollectedItems() != 16)
            {
                    return;
            }
            
            }
            
            this.backgroundIndex = CollectionIndex;
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  743508288, aName:  734635664);
            this.SaveToJson();
        }
        public int GetCompletedCollectionIndex()
        {
            var val_2;
            System.Collections.Generic.List<SLC.MatchyPics.MPICollection> val_3;
            val_2 = 4;
            goto label_1;
            label_11:
            if(true <= 35633452)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_1 = 2621443.CollectedItems();
            if(val_1 == 16)
            {
                    if(val_1 <= 35633452)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = 2621443;
                if(0 == 0)
            {
                    return 0;
            }
            
            }
            
            val_2 = 5;
            label_1:
            val_3 = this.<collections>k__BackingField;
            if((val_2 - 4) < 0)
            {
                goto label_11;
            }
            
            return 0;
        }
        public void CollectCollectionCompleted(int CollectionIndex)
        {
            int val_5;
            System.Collections.Generic.List<SLC.MatchyPics.MPICollection> val_6 = this.<collections>k__BackingField;
            if(true <= CollectionIndex)
            {
                    return;
            }
            
            val_6 = this.<collections>k__BackingField;
            if(true <= CollectionIndex)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (CollectionIndex << 2);
            if(((0 + (CollectionIndex) << 2) + 16.CoinReward()) >= 1)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                Add(key:  743749248, value:  (0 + (CollectionIndex) << 2) + 16 + 12);
                Player val_3 = App.Player;
                decimal val_4 = System.Decimal.op_Implicit(value:  743761420);
                val_6 = "Collection Reward";
                0.AddCredits(amount:  new System.Decimal() {mid = val_5}, source:  val_6, subSource:  0, externalParams:  null, doTrack:  true);
            }
            
            mem2[0] = 1;
            this.SaveToJson();
        }
        public int CompletedCollections()
        {
            var val_1;
            var val_2;
            val_1 = 0;
            val_2 = 0;
            goto label_1;
            label_6:
            if(true <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            val_1 = 1;
            val_2 = val_2 + ((0 + 0) + 16 + 24);
            label_1:
            if(val_1 < ((0 + 0) + 16 + 24))
            {
                goto label_6;
            }
            
            return (int)val_2;
        }
        public GiftCollection GetRandomItem()
        {
            int val_6;
            var val_7;
            System.Collections.Generic.List<SLC.MatchyPics.MPICollection> val_8;
            System.Collections.Generic.List<SLC.MatchyPics.MPICollection> val_9;
            GiftCollection val_1 = new GiftCollection();
            int val_3 = UnityEngine.Random.Range(min:  0, max:  val_1 - 1);
            val_6 = val_3;
            if(val_1 != 0)
            {
                    val_7 = val_1;
                typeof(GiftCollection).__il2cppRuntimeField_8 = val_6;
                val_8 = this.<collections>k__BackingField;
            }
            else
            {
                    val_7 = 8;
                mem[8] = val_6;
                val_8 = this.<collections>k__BackingField;
                val_6 = mem[8];
            }
            
            if(val_3 <= val_6)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (val_6 << 2);
            int val_4 = (0 + (val_3) << 2) + 16.GetRandomItemIndex();
            if(val_1 != 0)
            {
                    typeof(GiftCollection).__il2cppRuntimeField_C = val_4;
                val_9 = this.<collections>k__BackingField;
            }
            else
            {
                    mem[12] = val_4;
                val_9 = this.<collections>k__BackingField;
            }
            
            if(12 <= val_7)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (val_7 << 2);
            int val_5 = (0 + (val_3) << 2) + 16.CollectedItems();
            val_5 = val_5 - 16;
            val_5 = val_5 >> 5;
            typeof(GiftCollection).__il2cppRuntimeField_10 = val_5;
        }
        public UnityEngine.Texture GetBackground(int collectionIndex)
        {
            UnityEngine.Texture val_5;
            if(collectionIndex != 1)
            {
                    collectionIndex = collectionIndex + 1;
                string val_1 = System.String.Format(format:  744151008, arg0:  13152256);
                string val_2 = 744151120 + 744151008;
                UnityEngine.Texture val_3 = WGResources.Load<UnityEngine.Texture>(fileName:  744151120, extension:  1975550080, errorLog:  true);
                val_5 = "Collections_bg/";
                if(744151120 != 0)
            {
                    return;
            }
            
                UnityEngine.Debug.LogError(message:  744152256);
                return;
            }
            
            val_5 = this.defaultBackground;
        }
        public UnityEngine.Sprite GetMaskedBackground(int collectionIndex)
        {
            int val_1 = collectionIndex;
            val_1 = val_1 + 1;
            if(val_1 >= collectionIndex)
            {
                    return;
            }
            
            if(0 <= val_1)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (val_1 << 2);
        }
        public void LoadFromJson()
        {
            System.Collections.Generic.List<SLC.MatchyPics.MPICollection> val_13;
            bool val_14;
            var val_15;
            var val_16;
            var val_17;
            val_13 = 0;
            if((UnityEngine.PlayerPrefs.HasKey(key:  744401040)) == false)
            {
                    return;
            }
            
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  744401040);
            object val_3 = MiniJSON.Json.Deserialize(json:  744401040);
            if("mpi_collections_key" != 0)
            {
                    if(null != null)
            {
                    "mpi_collections_key" = 0;
            }
            
                val_13 = "mpi_collections_key";
            }
            
            string val_4 = PrettyPrint.printJSON(obj:  0, types:  false, singleLineOutput:  false);
            string val_5 = 744401152 + null;
            UnityEngine.Debug.Log(message:  744401152);
            string val_6 = val_13.Item[744401280];
            bool val_8 = System.Int32.TryParse(s:  null, result: out  this.backgroundIndex);
            string val_9 = val_13.Item[-1463122928];
            val_15 = 0;
            bool val_11 = System.Boolean.TryParse(value:  null, result: out  this.ftuxShown);
            string val_12 = val_13.Item[744401392];
            if(val_13 != 0)
            {
                    if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_13 = 0;
            }
            
                val_15 = val_13;
            }
            
            val_16 = 4;
            goto label_17;
            label_25:
            if(val_13 <= mem[1179403827])
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = 0;
            if(2621443 != 0)
            {
                    val_14 = mem[406885556];
                if(((mem[406885476] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    2621443 = 0;
            }
            
                val_17 = 2621443;
            }
            
            val_13 = this.<collections>k__BackingField;
            if(2621443 <= mem[1179403827])
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            2621443.Deserialize(obj:  0);
            val_16 = 5;
            label_17:
            if((val_16 - 4) < 0)
            {
                goto label_25;
            }
        
        }
        public void SaveToJson()
        {
            twelvegigs.sweepstakes.Distribution val_4;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = val_4.Serialize();
            Add(item:  val_4);
            goto label_5;
            label_2:
            Dispose();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  744401392, value:  80883712);
            Add(key:  744401280, value:  13152256);
            Add(key:  -1463122928, value:  8945664);
            string val_7 = MiniJSON.Json.Serialize(obj:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  744401040, value:  78753792);
            bool val_8 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public bool ShowFtux()
        {
            var val_6;
            var val_7;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance();
            val_7 = 0;
            if((-852051584) == 0)
            {
                    return true;
            }
            
            if(this.Unlocked == false)
            {
                    return true;
            }
            
            if(this.ftuxShown == true)
            {
                    return true;
            }
            
            Player val_4 = App.Player;
            val_6 = 0;
            if((this.ItemsPerLevel(levelIndex:  -1)) > 0)
            {
                    val_7 = 1;
            }
            
            return true;
        }
        public void CompletedFtux()
        {
            this.ftuxShown = true;
            this.SaveToJson();
        }
        public void HACK_CompleteCollection(int setIndex)
        {
            var val_2;
            if(true <= setIndex)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = 0;
            val_2 = val_2 + (setIndex << 2);
            goto label_3;
            label_8:
            var val_1 = ((0 + (setIndex) << 2) + 16 + 20) + 0;
            val_2 = 1;
            var val_3 = ((0 + (setIndex) << 2) + 16 + 20 + 0) + 16;
            val_3 = val_3 + 1;
            mem2[0] = val_3;
            label_3:
            if(val_2 < ((0 + (setIndex) << 2) + 16 + 20 + 12))
            {
                goto label_8;
            }
            
            this.SaveToJson();
        }
        public static bool ShowCompletedCollection()
        {
            var val_7;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = 0;
            if((-851040240) == 0)
            {
                    return true;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(Unlocked == false)
            {
                    return true;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(GetCompletedCollectionIndex() > 1)
            {
                    val_7 = 1;
            }
            
            return true;
        }
        public void InitCollections()
        {
            SLC.MatchyPics.MPIImageSet val_6;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.<collections>k__BackingField = null;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<SLC.MatchyPics.MPIImageSet> val_3 = ImageSets;
            List.Enumerator<T> val_4 = GetEnumerator();
            label_10:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            object val_7 = new System.Object();
            typeof(SLC.MatchyPics.MPICollection).__il2cppRuntimeField_8 = val_6 + 8;
            string val_8 = val_6 + 12.ToUpper();
            typeof(SLC.MatchyPics.MPICollection).__il2cppRuntimeField_C = val_6 + 12;
            System.Int32[] val_9 = val_6 + 12.GetRandomItems(imageSet:  val_6);
            typeof(SLC.MatchyPics.MPICollection).__il2cppRuntimeField_10 = val_6 + 12;
            typeof(SLC.MatchyPics.MPICollection).__il2cppRuntimeField_14 = null;
            this.<collections>k__BackingField.Add(item:  436740096);
            goto label_10;
            label_5:
            Dispose();
        }
        private int[] GetRandomItems(SLC.MatchyPics.MPIImageSet imageSet)
        {
            var val_5;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            val_5 = 0;
            goto label_1;
            label_5:
            Add(item:  0);
            val_5 = 1;
            label_1:
            if(val_5 < null)
            {
                goto label_5;
            }
            
            System.Nullable<System.Int32> val_2 = new System.Nullable<System.Int32>(value:  imageSet.Index);
            PluginExtension.Shuffle<System.Int32>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = val_2.HasValue});
            System.Collections.Generic.List<T> val_3 = GetRange(index:  0, count:  16);
            T[] val_4 = ToArray();
        }
        public MPICollectionsManager()
        {
            this.backgroundIndex = 0;
        }
    
    }

}
