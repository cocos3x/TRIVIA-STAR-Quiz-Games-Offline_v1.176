using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIDataController : MonoSingleton<SLC.MatchyPics.MPIDataController>
    {
        // Fields
        private const int DEFAULT_TILES_PER_PAIR = 4;
        private SLC.MatchyPics.MPIData staticMPIData;
        private SLC.MatchyPics.MPIGameStatus gameStatus;
        
        // Properties
        public SLC.MatchyPics.MPIEcon Econ { get; }
        public System.Collections.Generic.List<SLC.MatchyPics.MPIImageSet> ImageSets { get; }
        
        // Methods
        public SLC.MatchyPics.MPIEcon get_Econ()
        {
            if(this.staticMPIData != 0)
            {
                    return;
            }
        
        }
        public System.Collections.Generic.List<SLC.MatchyPics.MPIImageSet> get_ImageSets()
        {
            if(this.staticMPIData != 0)
            {
                    return;
            }
        
        }
        public override void InitMonoSingleton()
        {
            if(this.gameStatus == 0)
            {
                
            }
        
        }
        public SLC.MatchyPics.MPILevel GetNewLevel(int levelIndex)
        {
            int val_17;
            var val_18;
            var val_19;
            var val_20;
            SLC.MatchyPics.MPIDataController val_21;
            int val_22;
            var val_23;
            var val_24;
            var val_25;
            val_17 = levelIndex;
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_24 = 0;
            var val_17 = 0;
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_28 = 0;
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_34 = 0;
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_8 = val_17;
            if(new EventProgression() <= val_17)
            {
                goto label_5;
            }
            
            if(new EventProgression() <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = val_17 + (val_17 << 2);
            object val_2 = null;
            val_18 = val_2;
            val_2 = new System.Object();
            if(val_18 == 0)
            {
                goto label_11;
            }
            
            typeof(SLC.MatchyPics.MPILevelDefinition).__il2cppRuntimeField_C = (0 + (levelIndex) << 2) + 16 + 12;
            typeof(SLC.MatchyPics.MPILevelDefinition).__il2cppRuntimeField_8 = (0 + (levelIndex) << 2) + 16 + 8;
            val_19 = mem[(0 + (levelIndex) << 2) + 16 + 16];
            val_19 = (0 + (levelIndex) << 2) + 16 + 16;
            goto label_12;
            label_5:
            RandomSet val_3 = null;
            val_20 = 0;
            val_3 = new RandomSet();
            goto label_13;
            label_21:
            if(val_3 <= val_20)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + 0;
            add(item:  0, weight:  (float)(0 + 0) + 16 + 16);
            val_20 = 1;
            label_13:
            if(val_20 < val_3)
            {
                goto label_21;
            }
            
            int val_4 = roll(unweighted:  false);
            if(val_4 <= val_4)
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + (val_4 << 2);
            val_18 = mem[(0 + (val_4) << 2) + 16];
            val_18 = (0 + (val_4) << 2) + 16;
            SLC.MatchyPics.MPIMovementMechanic val_5 = this.GetMovementMechanic();
            if(null == 0)
            {
                goto label_26;
            }
            
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_10 = this;
            SLC.MatchyPics.MPIBombMechanic val_6 = this.GetBombMechanic();
            val_21 = this;
            goto label_38;
            label_11:
            mem[12] = (0 + (levelIndex) << 2) + 16 + 12;
            mem[8] = (0 + (levelIndex) << 2) + 16 + 8;
            val_19 = mem[(0 + (levelIndex) << 2) + 16 + 16];
            val_19 = (0 + (levelIndex) << 2) + 16 + 16;
            label_12:
            typeof(SLC.MatchyPics.MPILevelDefinition).__il2cppRuntimeField_14 = val_19;
            if(8 <= val_17)
            {
                    var val_20 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_20 = val_20 + (val_17 << 2);
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_10 = (0 + (levelIndex) << 2) + 16 + 20;
            if(((0 + (levelIndex) << 2) + 16 + 20) <= val_17)
            {
                    var val_21 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_21 = val_21 + (val_17 << 2);
            val_21 = mem[(0 + (levelIndex) << 2) + 16 + 24];
            val_21 = (0 + (levelIndex) << 2) + 16 + 24;
            goto label_38;
            label_26:
            mem[16] = this;
            SLC.MatchyPics.MPIBombMechanic val_7 = this.GetBombMechanic();
            val_21 = this;
            label_38:
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_14 = val_21;
            val_22 = 0;
            if(this.staticMPIData.Econ.LevelPerChestReward == 0)
            {
                    val_22 = this.staticMPIData.Econ.ChestPerLevel;
            }
            
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_18 = val_22;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_4C = ItemsPerLevel(levelIndex:  val_17);
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_C = val_18;
            object val_10 = new System.Object();
            SLC.MatchyPics.MPIImageSet val_11 = this.GetNewImageSet();
            val_23 = this;
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_1C = null;
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_38 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(val_18 != 0)
            {
                    val_24 = mem[(0 + (val_4) << 2) + 16 + 12];
                val_24 = (0 + (val_4) << 2) + 16 + 12;
            }
            else
            {
                    val_24 = mem[12];
            }
            
            var val_22 = (0 + (val_4) << 2) + 16 + 8;
            val_24 = val_22 * val_24;
            val_22 = val_24 >> 31;
            val_22 = val_24 + (val_22 >> 30);
            int val_13 = val_22 & (~3);
            val_13 = val_24 - val_13;
            var val_15 = val_22 >> 2;
            System.Collections.Generic.List<System.Int32> val_16 = val_22.GetRandomSprites(levelIndex:  val_17, imageSet:  762697840, count:  1 + (val_22 >> 2));
            if(val_24 >= 4)
            {
                    do
            {
                if(((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) + ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) >> 31)) >> 30) + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_23 = (((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) + ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) >> 31)) >> 30) + 8;
                val_23 = val_23 + 0;
                ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) + ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) >> 31)) >> 30) + 8 + 0) + 16.AddLevelTiles(levelTiles:  80883712, tilesPerPair:  4, imageSet:  80883712, spriteIndex:  ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) + ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) >> 31)) >> 30) + 8 + 0) + 16);
                val_17 = 0 + 1;
            }
            while(val_15 != val_17);
            
            }
            
            if(val_13 >= 1)
            {
                    if(((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) + ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) >> 31)) >> 30) + 12) <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_24 = (((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) + ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) >> 31)) >> 30) + 8;
                val_24 = val_24 + (val_15 << 2);
                ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) + ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) >> 31)) >> 30) + 8 + (((((0 + (val_4) << 2) + 16 + 8 * (0 + (l + 16.AddLevelTiles(levelTiles:  80883712, tilesPerPair:  val_13, imageSet:  762697840, spriteIndex:  ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) + ((((0 + (val_4) << 2) + 16 + 8 * (0 + (levelIndex) << 2) + 16 + 12) >> 31)) >> 30) + 8 + (((((0 + (val_4) << 2) + 16 + 8 * (0 + (l + 16);
            }
            
            val_25 = val_18;
            if(val_25 != 0)
            {
                    typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_24 = (0 + (val_4) << 2) + 16 + 20;
            }
            else
            {
                    val_25 = 20;
                typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_24 = 1;
            }
            
            typeof(SLC.MatchyPics.MPILevel).__il2cppRuntimeField_28 = val_25;
            PluginExtension.Shuffle<UnityEngine.Sprite>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        public UnityEngine.Sprite GetSprite(int imageSetIndex, int spriteIndex)
        {
            if(true <= imageSetIndex)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (imageSetIndex << 2);
            if(((0 + (imageSetIndex) << 2) + 16 + 16 + 12) <= spriteIndex)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = (0 + (imageSetIndex) << 2) + 16 + 16 + 8;
            val_2 = val_2 + (spriteIndex << 2);
        }
        public void ChangeImageSet(SLC.MatchyPics.MPILevel level)
        {
            var val_16;
            var val_19;
            System.Predicate<SLC.MatchyPics.MPITileData> val_21;
            var val_22;
            System.Func<SLC.MatchyPics.MPITileData, System.Int32> val_24;
            var val_25;
            float val_26;
            SLC.MatchyPics.MPIDataController val_27;
            int val_28;
            SLC.MatchyPics.MPIImageSet val_1 = this.GetNewImageSet();
            level.imageSetIndex = this;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            val_19 = null;
            val_19 = null;
            val_21 = MPIDataController.<>c.<>9__10_0;
            if(val_21 == 0)
            {
                    val_21 = null;
                val_21 = new System.Predicate<ZooTile>(object:  MPIDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(763012528));
                MPIDataController.<>c.<>9__10_0 = val_21;
            }
            
            System.Collections.Generic.List<T> val_4 = level.LevelTiles.FindAll(match:  8040448);
            if(level.LevelTiles >= 1)
            {
                    val_22 = null;
                val_22 = null;
                val_24 = MPIDataController.<>c.<>9__10_1;
                if(val_24 == 0)
            {
                    val_24 = null;
                val_24 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  MPIDataController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(763015600));
                MPIDataController.<>c.<>9__10_1 = val_24;
            }
            
                System.Collections.Generic.IEnumerable<TResult> val_6 = System.Linq.Enumerable.Select<System.Object, System.Int32>(source:  level.LevelTiles, selector:  7720960);
                System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Distinct<System.Int32>(source:  level.LevelTiles);
                System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<System.Int32>(source:  level.LevelTiles);
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                System.Collections.Generic.List<System.Int32> val_10 = GetRandomItems(count:  level.LevelTiles, setIndex:  mem[1152921513959829368]);
                if((public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance()) >= 1)
            {
                    do
            {
                if((public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance()) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                Add(key:  2621443, value:  public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance().__il2cppRuntimeField_8 + 16);
                var val_11 = 4 + 1;
            }
            while((4 - 3) < null);
            
            }
            
            }
            
            val_25 = 0;
            null = new RandomSet();
            val_26 = 1152921513959801264;
            val_27 = this;
            goto label_27;
            label_33:
            if((ContainsValue(value:  0)) != true)
            {
                    add(item:  0, weight:  null);
            }
            
            val_25 = 1;
            label_27:
            if(val_25 < (mem[1152921513959829376] + 12))
            {
                goto label_33;
            }
            
            List.Enumerator<T> val_15 = GetEnumerator();
            goto label_36;
            label_45:
            val_26 = val_16;
            if(val_26 != 0)
            {
                    mem2[0] = mem[1152921513959829368];
            }
            else
            {
                    mem[8] = mem[1152921513959829368];
            }
            
            if((ContainsKey(key:  val_16 + 12)) != false)
            {
                    val_28 = Item[val_16 + 12];
            }
            else
            {
                    val_28 = roll(unweighted:  false);
                Add(key:  val_16 + 12, value:  val_28);
            }
            
            val_27 = this;
            mem2[0] = val_28;
            label_36:
            if(MoveNext() == true)
            {
                goto label_45;
            }
            
            Dispose();
        }
        private System.Collections.Generic.List<int> GetRandomSprites(int levelIndex, SLC.MatchyPics.MPIImageSet imageSet, int count)
        {
            int val_13;
            var val_14;
            var val_15;
            int val_16;
            val_13 = imageSet;
            System.Collections.Generic.List<System.Int32> val_2 = null;
            val_14 = val_2;
            val_2 = new System.Collections.Generic.List<System.Int32>();
            val_15 = 0;
            goto label_1;
            label_5:
            Add(item:  0);
            val_15 = 1;
            label_1:
            if(val_15 < val_14)
            {
                goto label_5;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-851040240) == 0)
            {
                goto label_16;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_7 = UnityEngine.Mathf.Min(a:  ItemsPerLevel(levelIndex:  levelIndex), b:  count);
            if(val_7 < 1)
            {
                goto label_16;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = imageSet.Index;
            System.Collections.Generic.List<System.Int32> val_9 = GetRandomItems(count:  val_7, setIndex:  val_13);
            AddRange(collection:  -851040240);
            System.Collections.Generic.IEnumerable<TSource> val_10 = System.Linq.Enumerable.Except<System.Int32>(first:  80883712, second:  80883712);
            System.Collections.Generic.List<TSource> val_11 = System.Linq.Enumerable.ToList<System.Int32>(source:  80883712);
            val_14 = val_14;
            if((new System.Collections.Generic.List<System.Int32>()) != 0)
            {
                goto label_22;
            }
            
            goto label_22;
            label_16:
            val_16 = count;
            label_22:
            PluginExtension.Shuffle<System.Int32>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            System.Collections.Generic.List<T> val_12 = GetRange(index:  0, count:  val_16);
            AddRange(collection:  80883712);
        }
        private SLC.MatchyPics.MPIImageSet GetNewImageSet()
        {
            int val_5;
            var val_6;
            var val_7;
            if(true != 0)
            {
                    if(this.gameStatus.SeenImageSets != true)
            {
                goto label_8;
            }
            
            }
            
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            this.gameStatus.SeenImageSets = null;
            int val_2 = UnityEngine.Random.Range(min:  0, max:  typeof(SLC.MatchyPics.MPIGameStatus).__il2cppRuntimeField_E8);
            val_5 = 1;
            goto label_13;
            label_8:
            this.gameStatus.SeenImageSets.Sort();
            val_6 = 0;
            val_7 = 0;
            goto label_16;
            label_27:
            if(this.gameStatus.SeenImageSets <= val_7)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            var val_6 = (0 + 0) + 16;
            if(val_6 == val_6)
            {
                    val_6 = val_6 - 1;
                if(val_7 < val_6)
            {
                    val_7 = 1;
            }
            
            }
            else
            {
                    add(item:  0, weight:  null);
            }
            
            val_6 = 1;
            label_16:
            if(val_6 < new RandomSet())
            {
                goto label_27;
            }
            
            val_5 = roll(unweighted:  false);
            label_13:
            this.gameStatus.SeenImageSets.Add(item:  val_5);
            if(this.gameStatus <= val_5)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (val_5 << 2);
            mem2[0] = val_5;
            if(val_7 <= val_5)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (val_5 << 2);
        }
        private void AddLevelTiles(System.Collections.Generic.List<SLC.MatchyPics.MPITileData> levelTiles, int tilesPerPair, int imageSet, int spriteIndex)
        {
            var val_2;
            int val_2 = tilesPerPair;
            val_2 = 35638168;
            if(val_2 < 1)
            {
                    return;
            }
            
            do
            {
                SLC.MatchyPics.MPITileData val_1 = null;
                val_2 = val_1;
                val_1 = new SLC.MatchyPics.MPITileData();
                if(val_2 != 0)
            {
                    typeof(SLC.MatchyPics.MPITileData).__il2cppRuntimeField_8 = imageSet;
            }
            else
            {
                    mem[8] = imageSet;
            }
            
                typeof(SLC.MatchyPics.MPITileData).__il2cppRuntimeField_C = spriteIndex;
                levelTiles.Add(item:  438976512);
                val_2 = val_2 - 1;
            }
            while(levelTiles != 0);
        
        }
        private SLC.MatchyPics.MPIMovementMechanic GetMovementMechanic()
        {
            var val_4;
            var val_7;
            RandomSet val_1 = new RandomSet();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            if(val_4 != 0)
            {
                    val_7 = mem[val_4 + 8];
                val_7 = val_4 + 8;
            }
            else
            {
                    val_7 = 0;
            }
            
            add(item:  0, weight:  (float)(val_4 + 12) * 100f);
            goto label_8;
            label_4:
            Dispose();
            int val_6 = roll(unweighted:  false);
        }
        private SLC.MatchyPics.MPIBombMechanic GetBombMechanic()
        {
            var val_4;
            var val_7;
            RandomSet val_1 = new RandomSet();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            if(val_4 != 0)
            {
                    val_7 = mem[val_4 + 8];
                val_7 = val_4 + 8;
            }
            else
            {
                    val_7 = 0;
            }
            
            add(item:  0, weight:  (float)(val_4 + 12) * 100f);
            goto label_8;
            label_4:
            Dispose();
            int val_6 = roll(unweighted:  false);
        }
        public MPIDataController()
        {
            this.gameStatus = new SLC.MatchyPics.MPIGameStatus();
        }
    
    }

}
