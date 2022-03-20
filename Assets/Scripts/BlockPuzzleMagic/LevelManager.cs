using UnityEngine;

namespace BlockPuzzleMagic
{
    public class LevelManager : MonoSingletonSelfGenerating<BlockPuzzleMagic.LevelManager>
    {
        // Fields
        public const int DEFAULT_NORMAL_GRIDLAYOUT_ID = 1;
        private const int MAX_SHAPE_PIECE_WIDTH = 5;
        private const int MAX_SHAPE_PIECE_HEIGHT = 5;
        private const string PREFKEY_CHAPTER_DATA = "bbl_chapterdata";
        private const string PREFKEY_UNUSED_NORMAL_LAYOUTS = "bbl_avail_normlayid";
        private const string PREFKEY_PREV_THEME_MECHANICS = "bbl_prev_tm";
        private const string PREFKEY_CHAPTER_GOAL_INST_COUNT = "bbl_ch_goli";
        private const string PREFKEY_CHAPTER_ALM_INST_COUNT = "bbl_ch_almi";
        private BlockPuzzleMagic.ChapterRef currentChapter;
        private System.Collections.Generic.List<int> unusedNormalGridLayoutIds;
        
        // Properties
        public BlockPuzzleMagic.ChapterRef CurrentChapter { get; }
        
        // Methods
        public BlockPuzzleMagic.ChapterRef get_CurrentChapter()
        {
        
        }
        public static int GetChapterIdFromPlayerLevel(int playerLevel)
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            BlockPuzzleMagic.BestBlocksGameEcon val_4 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            int val_7 = TotalPredefinedChapters;
            val_7 = (UnityEngine.Mathf.FloorToInt(f:  (float)(~(public static BlockPuzzleMagic.BBLDataParser MonoSingletonSelfGenerating<BlockPuzzleMagic.BBLDataParser>::get_Instance().__il2cppRuntimeField_C) + playerLevel))) + val_7;
            val_7 = val_7 + 1;
            return (int)val_7;
        }
        public static int GetLevelIdFromChapterId(int chapterNum)
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(TotalPredefinedChapters < chapterNum)
            {
                    WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
                WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
                BlockPuzzleMagic.BestBlocksGameEcon val_7 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
                var val_11 = ~TotalPredefinedChapters;
                val_11 = val_11 + chapterNum;
                return 349;
            }
            
            WordPets.WPTDataParser val_8 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            BlockPuzzleMagic.ChapterRef val_9 = GetPredefinedChapterFromChapterId(chapterId:  chapterNum);
            BlockPuzzleMagic.LevelRef val_10 = FirstLevel;
            if((public static BlockPuzzleMagic.BBLDataParser MonoSingletonSelfGenerating<BlockPuzzleMagic.BBLDataParser>::get_Instance()) != 0)
            {
                    return (int)public static BlockPuzzleMagic.BBLDataParser MonoSingletonSelfGenerating<BlockPuzzleMagic.BBLDataParser>::get_Instance().__il2cppRuntimeField_8;
            }
            
            return (int)public static BlockPuzzleMagic.BBLDataParser MonoSingletonSelfGenerating<BlockPuzzleMagic.BBLDataParser>::get_Instance().__il2cppRuntimeField_8;
        }
        private void Awake()
        {
            this.Initialize();
        }
        private void Initialize()
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Initialize();
            this.LoadChapterData();
            UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  1269401408);
        }
        private void LoadChapterData()
        {
            var val_11;
            BlockPuzzleMagic.ChapterRef val_12;
            GameBehavior val_1 = App.getBehavior;
            WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_11 = "bbl_chapterdata";
            string val_3 = UnityEngine.PlayerPrefs.GetString(key:  1269489408, defaultValue:  System.String.alignConst);
            if((System.String.IsNullOrEmpty(value:  1269489408)) != false)
            {
                    BlockPuzzleMagic.ChapterRef val_5 = this.GenerateDynamicChapter();
                this.currentChapter = this;
                string val_6 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  1269513520);
                UnityEngine.PlayerPrefs.SetString(key:  1269489408, value:  1269513520);
                return;
            }
            
            val_12 = "bbl_chapterdata";
            BlockPuzzleMagic.ChapterRef val_10 = BlockPuzzleMagic.ChapterRef.Parse(_jsonString:  1269489408);
            this.currentChapter = val_12;
        }
        public BlockPuzzleMagic.Level GetGameLevel(BlockPuzzleMagic.GameMode gameMode)
        {
            if(gameMode == 1)
            {
                    return this.GetGameLevelForZenMode();
            }
            
            if(gameMode == 2)
            {
                    return this.GetGameLevelForChallengeMode();
            }
            
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_1 = 1269605616 + 463843328 + 1269605744;
            UnityEngine.Debug.LogError(message:  1269605616);
        }
        private BlockPuzzleMagic.Level GetGameLevelForChallengeMode()
        {
            var val_10;
            var val_11;
            var val_12;
            System.Predicate<BlockPuzzleMagic.LevelRef> val_14;
            var val_16;
            System.Predicate<BlockPuzzleMagic.LevelRef> val_18;
            GameBehavior val_1 = App.getBehavior;
            if(this.currentChapter.chapterId != (BlockPuzzleMagic.LevelManager.GetChapterIdFromPlayerLevel(playerLevel:  0)))
            {
                    UnityEngine.PlayerPrefs.DeleteKey(key:  1269489408);
                this.LoadChapterData();
            }
            
            val_10 = 0;
            Player val_3 = App.Player;
            if(0 != 0)
            {
                    val_10 = 0;
            }
            
            val_11 = null;
            if(val_10.IsFTUXGameLevels() != false)
            {
                    val_12 = null;
                val_14 = LevelManager.<>c.<>9__18_0;
                if(val_14 == 0)
            {
                    val_14 = null;
                val_14 = new System.Predicate<ZooTile>(object:  LevelManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1269734240));
                LevelManager.<>c.<>9__18_0 = val_14;
            }
            
                BlockPuzzleMagic.LevelRef val_7 = this.currentChapter.levels.Find(match:  8040448);
                return BlockPuzzleMagic.BBLFtuxData.CreateFtuxLevel(ftuxLevelRef:  this.currentChapter.levels);
            }
            
            val_16 = null;
            val_18 = LevelManager.<>c.<>9__18_1;
            if(val_18 == 0)
            {
                    val_18 = null;
                val_18 = new System.Predicate<ZooTile>(object:  LevelManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1269735264));
                LevelManager.<>c.<>9__18_1 = val_18;
            }
            
            BlockPuzzleMagic.LevelRef val_9 = this.currentChapter.levels.Find(match:  8040448);
            return BlockPuzzleMagic.LevelManager.CreateLevel(levelRef:  this.currentChapter.levels);
        }
        private BlockPuzzleMagic.Level GetGameLevelForZenMode()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_8 = 2;
            if(new System.Object() != 0)
            {
                    typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_8 = 1;
            }
            else
            {
                    typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_8 = 1;
            }
            
            typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_C = 9;
            val_4 = null;
            val_4 = null;
            typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_14 = new BlockPuzzleMagic.PlayerGridLayout(target:  BlockPuzzleMagic.GridLayout.ZenGridLayout);
            System.Collections.Generic.List<WordPets.WordPetType> val_3 = new System.Collections.Generic.List<WordPets.WordPetType>();
            typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_18 = null;
            val_5 = 4;
            goto label_5;
            label_20:
            val_6 = null;
            val_6 = null;
            if((BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 16) != 2)
            {
                    val_7 = null;
                val_7 = null;
                Add(item:  BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 16);
            }
            
            val_5 = 5;
            label_5:
            val_8 = null;
            val_8 = null;
            if((val_5 - 4) < (BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 12))
            {
                goto label_20;
            }
        
        }
        public static BlockPuzzleMagic.Level CreateLevel(BlockPuzzleMagic.LevelRef levelRef)
        {
            BlockPuzzleMagic.GridLayout val_17;
            var val_18;
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            object val_2 = new System.Object();
            typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_8 = 2;
            typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_C = levelRef.levelId;
            BlockPuzzleMagic.GridLayoutDefinitions val_3 = 0.gridLayoutDefinitions;
            BlockPuzzleMagic.GridLayout[] val_4 = 0.GetGridLayoutsByType(layoutType:  1);
            var val_6 = 0 + ((levelRef.layoutId - 1) << 2);
            val_17 = mem[(0 + ((levelRef.layoutId - 1)) << 2) + 16];
            val_17 = (0 + ((levelRef.layoutId - 1)) << 2) + 16;
            BlockPuzzleMagic.PlayerGridLayout val_7 = null;
            val_18 = val_7;
            val_7 = new BlockPuzzleMagic.PlayerGridLayout(target:  val_17);
            typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_14 = val_18;
            if(levelRef.dotLayoutId >= 1)
            {
                    BlockPuzzleMagic.GridLayoutDefinitions val_8 = 0.gridLayoutDefinitions;
                BlockPuzzleMagic.GridLayout[] val_9 = 0.GetGridLayoutsByType(layoutType:  2);
                int val_17 = levelRef.dotLayoutId;
                val_17 = 0;
                val_17 = val_17 - 1;
                var val_10 = val_17 + (val_17 << 2);
                BlockPuzzleMagic.LevelManager.MergeSpecialLayoutToLevelLayout(baseLayout:  466132992, specialLayout:  (val_17 + ((levelRef.dotLayoutId - 1)) << 2) + 16, specialLayoutFlag:  2);
            }
            
            if(levelRef.stoneLayoutId >= 1)
            {
                    val_18 = typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_14;
                BlockPuzzleMagic.GridLayoutDefinitions val_11 = 0.gridLayoutDefinitions;
                BlockPuzzleMagic.GridLayout[] val_12 = 0.GetGridLayoutsByType(layoutType:  3);
                int val_18 = levelRef.stoneLayoutId;
                val_17 = 0;
                val_18 = val_18 - 1;
                var val_13 = val_17 + (val_18 << 2);
                BlockPuzzleMagic.LevelManager.MergeSpecialLayoutToLevelLayout(baseLayout:  466132992, specialLayout:  (val_17 + ((levelRef.stoneLayoutId - 1)) << 2) + 16, specialLayoutFlag:  4);
            }
            
            if(levelRef.loopLayoutId >= 1)
            {
                    val_18 = typeof(BlockPuzzleMagic.Level).__il2cppRuntimeField_14;
                BlockPuzzleMagic.GridLayoutDefinitions val_14 = 0.gridLayoutDefinitions;
                BlockPuzzleMagic.GridLayout[] val_15 = 0.GetGridLayoutsByType(layoutType:  4);
                int val_19 = levelRef.loopLayoutId;
                val_17 = 0;
                val_19 = val_19 - 1;
                var val_16 = val_17 + (val_19 << 2);
                BlockPuzzleMagic.LevelManager.MergeSpecialLayoutToLevelLayout(baseLayout:  466132992, specialLayout:  (val_17 + ((levelRef.loopLayoutId - 1)) << 2) + 16, specialLayoutFlag:  64);
            }
            
            BlockPuzzleMagic.LevelManager.AddGoalsRemoveColorsForLevel(currentLevel:  465494016, levelRef:  levelRef);
            BlockPuzzleMagic.LevelManager.SetupAdditionalMechanicsForLevel(currentLevel:  465494016, levelRef:  levelRef);
        }
        private int GetRandomNormalGridLayoutId()
        {
            System.Collections.Generic.List<System.Int32> val_13;
            var val_14;
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            val_13 = this.unusedNormalGridLayoutIds;
            if(val_13 != 0)
            {
                    if(R1 > 0)
            {
                goto label_2;
            }
            
            }
            
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  1270096864, defaultValue:  null);
            if((System.String.IsNullOrEmpty(value:  1270096864)) != false)
            {
                    val_13 = this.unusedNormalGridLayoutIds;
            }
            else
            {
                    val_13 = "bbl_avail_normlayid";
                object val_4 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  1270096864);
                this.unusedNormalGridLayoutIds = val_13;
            }
            
            if(val_13 != 0)
            {
                    label_2:
            }
            
            System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>();
            this.unusedNormalGridLayoutIds = null;
            val_14 = 2;
            goto label_9;
            label_14:
            this.unusedNormalGridLayoutIds.Add(item:  2);
            val_14 = 3;
            label_9:
            BlockPuzzleMagic.GridLayoutDefinitions val_6 = 0.gridLayoutDefinitions;
            BlockPuzzleMagic.GridLayout[] val_7 = 0.GetGridLayoutsByType(layoutType:  1);
            if(val_14 <= 0)
            {
                goto label_14;
            }
            
            if(new RandomSet() != 0)
            {
                    addIntRange(lowest:  0, highest:  this.unusedNormalGridLayoutIds - 1);
            }
            else
            {
                    addIntRange(lowest:  0, highest:  this.unusedNormalGridLayoutIds - 1);
            }
            
            int val_11 = roll(unweighted:  false);
            if(val_11 <= val_11)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + (val_11 << 2);
            this.unusedNormalGridLayoutIds.RemoveAt(index:  val_11);
            string val_12 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.unusedNormalGridLayoutIds);
            UnityEngine.PlayerPrefs.SetString(key:  1270096864, value:  this.unusedNormalGridLayoutIds);
            return (int)(0 + (val_11) << 2) + 16;
        }
        private BlockPuzzleMagic.ChapterRef GenerateDynamicChapter()
        {
            int val_44;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Initialize();
            BlockPuzzleMagic.BestBlocksGameEcon val_2 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            Player val_3 = App.Player;
            val_44 = BlockPuzzleMagic.LevelManager.GetChapterIdFromPlayerLevel(playerLevel:  0);
            if(new System.Object() != 0)
            {
                    typeof(BlockPuzzleMagic.ChapterRef).__il2cppRuntimeField_8 = val_44;
            }
            else
            {
                    mem[8] = val_44;
                val_44 = mem[8];
            }
            
            val_45 = null;
            val_45 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            typeof(BlockPuzzleMagic.ChapterRef).__il2cppRuntimeField_C = val_45;
            if(348 < 1)
            {
                goto label_14;
            }
            
            val_46 = 0;
            goto label_15;
            label_20:
            val_46 = 1;
            val_45 = typeof(BlockPuzzleMagic.ChapterRef).__il2cppRuntimeField_C;
            label_15:
            object val_9 = new System.Object();
            Add(item:  465653760);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            typeof(System.Collections.Generic.List<T>).__il2cppRuntimeField_8 = (BlockPuzzleMagic.LevelManager.GetLevelIdFromChapterId(chapterNum:  val_44)) + val_46;
            if((348 - 1) != val_46)
            {
                goto label_20;
            }
            
            label_14:
            mem[316] = 0;
            RandomSet val_11 = new RandomSet();
            val_47 = 0;
            addIntRange(lowest:  0, highest:  1094062063);
            goto label_24;
            label_30:
            int val_12 = roll(unweighted:  false);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_47 = 1;
            mem2[0] = 1;
            label_24:
            if(val_47 < 786450)
            {
                goto label_30;
            }
            
            int val_13 = count();
            if(val_13 >= 1)
            {
                    var val_46 = val_13;
                do
            {
                int val_14 = roll(unweighted:  false);
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_46 = val_46 - 1;
                mem2[0] = this.GetRandomNormalGridLayoutId();
            }
            while((((val_6 + val_46) + (val_14) << 2) + 16) != 0);
            
            }
            
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_16 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_17 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            string val_18 = UnityEngine.PlayerPrefs.GetString(key:  -774415088, defaultValue:  -2141227328);
            object val_19 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -774415088);
            RandomSet val_20 = new RandomSet();
            add(item:  0, weight:  0f);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_21 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_48 = 4;
            goto label_41;
            label_64:
            if(1948516352 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            object val_22 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  23, key:  1350676976, defaultValue:  0);
            if(23 != 0)
            {
                    System.Type val_23 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(464535552)});
                object val_24 = System.Enum.Parse(enumType:  464535552, value:  23);
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                System.Type val_25 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(464535552)});
                if((System.Enum.IsDefined(enumType:  464535552, value:  464535552)) != false)
            {
                    if(1948516352 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.Collections.Generic.Dictionary<System.String, System.Type> val_27 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  23);
                Add(item:  78753792);
                if((Contains(item:  null)) != true)
            {
                    if(1948516352 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                object val_29 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  23, key:  1229166816, defaultValue:  13152256);
                23.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                add(item:  1094062063, weight:  0f);
            }
            
            }
            
            }
            
            val_48 = 5;
            label_41:
            if((val_48 - 4) < 1948516352)
            {
                goto label_64;
            }
            
            if((roll(unweighted:  false)) != 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                object val_32 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  ((val_6 + val_46) + (val_31) << 2) + 16, key:  -576745552, defaultValue:  13152256);
                ((val_6 + val_46) + (val_31) << 2) + 16.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                var val_47 = 0;
                val_47 = val_47 * (((val_6 + val_46) + (val_31) << 2) + 16);
                EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  ((val_6 + val_46) + (val_31) << 2) + 16, key:  -576745552, newValue:  13152256);
                System.Type val_33 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(464535552)});
                string val_34 = ((val_6 + val_46) + (val_31) << 2) + 16.Item[1350676976];
                object val_35 = System.Enum.Parse(enumType:  464535552, value:  ((val_6 + val_46) + (val_31) << 2) + 16);
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                val_49 = ;
                val_50 = 1152921510720759024;
            }
            else
            {
                    val_49 = 0;
                val_50 = 1152921510720759024;
            }
            
            Add(item:  0);
            RemoveAt(index:  ("bbl_prev_tm".__il2cppRuntimeField_C - 3));
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_38 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_51 = 0;
            goto label_86;
            label_98:
            if(348 <= val_51)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            object val_39 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  105150508, key:  1350676976, defaultValue:  0);
            if(105150508 != 0)
            {
                    System.Type val_40 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(465973248)});
                object val_41 = System.Enum.Parse(enumType:  465973248, value:  105150508);
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                System.Type val_42 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(465973248)});
                bool val_43 = System.Enum.IsDefined(enumType:  465973248, value:  465973248);
            }
            
            val_51 = 1;
            label_86:
            if(val_51 < 348)
            {
                goto label_98;
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_44 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1350676976, value:  465973248);
            Add(key:  -576745552, value:  13152256);
            Add(key:  -1605531600, value:  13152256);
            Add(item:  78753792);
            val_52 = 0;
            goto label_109;
        }
        private void SetSpecialLayoutIdToLevelRef(BlockPuzzleMagic.LevelRef baseLevel, BlockPuzzleMagic.GridLayout.NodeType specialLayoutFlag)
        {
            int val_9;
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            BlockPuzzleMagic.GridLayoutDefinitions val_2 = 0.gridLayoutDefinitions;
            BlockPuzzleMagic.GridLayout[] val_3 = 0.GetGridLayoutsByType(nodeType:  specialLayoutFlag);
            val_9 = (UnityEngine.Random.Range(min:  0, max:  0)) + 1;
            if(specialLayoutFlag == 2)
            {
                goto label_4;
            }
            
            if(specialLayoutFlag != 4)
            {
                    return;
            }
            
            var val_8 = 0;
            label_10:
            if((BlockPuzzleMagic.LevelManager.CheckEntireRowColumnCompatible(baseLayoutId:  baseLevel.layoutId, specialLayoutId:  val_9, specialLayoutFlag:  specialLayoutFlag)) == true)
            {
                goto label_7;
            }
            
            val_8 = val_8 + 1;
            val_9 = (UnityEngine.Random.Range(min:  0, max:  0)) + 1;
            if(val_8 <= (UnityEngine.Mathf.Max(a:  0, b:  200)))
            {
                goto label_10;
            }
            
            return;
            label_7:
            if(val_9 < 1)
            {
                    return;
            }
            
            if(specialLayoutFlag == 64)
            {
                goto label_13;
            }
            
            if(specialLayoutFlag != 4)
            {
                    return;
            }
            
            baseLevel.stoneLayoutId = val_9;
            return;
            label_4:
            baseLevel.dotLayoutId = val_9;
            return;
            label_13:
            baseLevel.loopLayoutId = val_9;
        }
        public static bool CheckEntireRowColumnCompatible(int baseLayoutId, int specialLayoutId, BlockPuzzleMagic.GridLayout.NodeType specialLayoutFlag)
        {
            NodeType val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            int val_22 = baseLayoutId;
            val_21 = specialLayoutFlag;
            int val_23 = specialLayoutId;
            val_22 = 35640159;
            val_23 = 1;
            if(val_21 == 1)
            {
                    return (bool)val_23 & 1;
            }
            
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            val_24 = 0;
            val_23 = 0;
            BlockPuzzleMagic.GridLayoutDefinitions val_2 = val_24.gridLayoutDefinitions;
            val_22 = val_24;
            BlockPuzzleMagic.GridLayout[] val_3 = val_22.GetGridLayoutsByType(nodeType:  val_21);
            if(val_22 == 0)
            {
                    return (bool)val_23 & 1;
            }
            
            val_22 = val_22;
            BlockPuzzleMagic.GridLayoutDefinitions val_4 = val_24.gridLayoutDefinitions;
            BlockPuzzleMagic.GridLayout[] val_5 = val_24.GetGridLayoutsByType(layoutType:  1);
            val_24 = val_24;
            val_22 = val_22 - 1;
            var val_6 = val_24 + (val_22 << 2);
            val_23 = val_23 - 1;
            var val_7 = val_22 + (val_23 << 2);
            val_25 = mem[(val_22 + ((specialLayoutId - 1)) << 2) + 16];
            val_25 = (val_22 + ((specialLayoutId - 1)) << 2) + 16;
            label_25:
            val_26 = 0;
            if(0 >= ((val_24 + ((baseLayoutId - 1)) << 2) + 16.rowCount))
            {
                goto label_11;
            }
            
            val_21 = 0;
            goto label_12;
            label_24:
            bool val_9 = (val_24 + ((baseLayoutId - 1)) << 2) + 16.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  0);
            var val_10 = ((val_22 + ((specialLayoutId - 1)) << 2) + 16 + 12) + 0;
            var val_24 = ((val_22 + ((specialLayoutId - 1)) << 2) + 16 + 12 + 0) + 16;
            if(val_9 == false)
            {
                goto label_16;
            }
            
            val_25 = val_25;
            if(val_24 == 1)
            {
                goto label_48;
            }
            
            val_24 = val_24 - 1;
            val_24 = val_24 >> 5;
            val_24 = val_24 & val_9 ^ 1;
            bool val_25 = false;
            val_25 = val_25 + val_24;
            goto label_19;
            label_16:
            var val_26 = 0;
            val_24 = val_24 - 1;
            if(val_9 == true)
            {
                    val_24 = 1;
            }
            
            val_26 = val_26 + 1;
            val_25 = val_25;
            bool val_12 = val_9 ^ 1;
            val_12 = 0 & val_12;
            bool val_27 = val_25;
            val_27 = val_27 + val_12;
            if(val_9 == true)
            {
                goto label_19;
            }
            
            val_27 = ((val_24 + ((baseLayoutId - 1)) << 2) + 16 + 8) - 1;
            if(val_26 < val_27)
            {
                goto label_20;
            }
            
            label_19:
            val_22 = 0;
            val_21 = UnityEngine.Mathf.Max(a:  1, b:  0);
            val_27 = ((val_24 + ((baseLayoutId - 1)) << 2) + 16 + 8) - 1;
            label_20:
            var val_28 = 0;
            val_28 = 1;
            val_28 = val_28 + val_9;
            if(val_26 >= val_27)
            {
                    0 = 1;
            }
            
            if(val_21 > 4)
            {
                    0 = 1;
            }
            
            label_12:
            if(val_28 < ((val_24 + ((baseLayoutId - 1)) << 2) + 16 + 8))
            {
                goto label_24;
            }
            
            if(val_26 <= 0)
            {
                    val_23 = 0;
            }
            
            if(val_28 >= ((val_24 + ((baseLayoutId - 1)) << 2) + 16 + 8))
            {
                goto label_25;
            }
            
            return (bool)val_23 & 1;
            label_11:
            if(val_27 < true)
            {
                    0 = 1;
            }
            
            if(1 != 1)
            {
                    return (bool)val_23 & 1;
            }
            
            val_23 = 0;
            goto label_28;
            label_50:
            val_25 = 0;
            val_22 = 0;
            label_42:
            if(val_25 >= ((val_24 + ((baseLayoutId - 1)) << 2) + 16.rowCount))
            {
                goto label_30;
            }
            
            if(((val_24 + ((baseLayoutId - 1)) << 2) + 16) != 0)
            {
                    val_29 = mem[(val_24 + ((baseLayoutId - 1)) << 2) + 16 + 8];
                val_29 = (val_24 + ((baseLayoutId - 1)) << 2) + 16 + 8;
            }
            else
            {
                    val_29 = mem[(val_24 + ((baseLayoutId - 1)) << 2) + 16 + 8];
                val_29 = (val_24 + ((baseLayoutId - 1)) << 2) + 16 + 8;
            }
            
            bool val_15 = (val_24 + ((baseLayoutId - 1)) << 2) + 16.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  0);
            if(val_15 == false)
            {
                goto label_36;
            }
            
            val_30 = 0;
            goto label_37;
            label_36:
            var val_16 = ((val_22 + ((specialLayoutId - 1)) << 2) + 16 + 12) + 0;
            var val_29 = ((val_22 + ((specialLayoutId - 1)) << 2) + 16 + 12 + 0) + 16;
            val_29 = val_29 - 1;
            if(val_15 == true)
            {
                    val_29 = 1;
            }
            
            val_30 = 1;
            if(val_15 == true)
            {
                goto label_38;
            }
            
            label_37:
            float val_31 = val_23;
            var val_30 = 0;
            label_44:
            label_45:
            val_30 = val_30 + val_15;
            int val_18 = (val_24 + ((baseLayoutId - 1)) << 2) + 16.rowCount;
            val_18 = val_18 - 1;
            if(val_25 >= val_18)
            {
                    0 = 1;
            }
            
            if((UnityEngine.Mathf.Max(a:  1, b:  0)) > 4)
            {
                    0 = 1;
            }
            
            val_31 = val_31 | 1;
            val_25 = val_25 + 1;
            goto label_42;
            label_38:
            int val_19 = (val_24 + ((baseLayoutId - 1)) << 2) + 16.rowCount;
            val_19 = val_19 - 1;
            if(val_25 >= val_19)
            {
                goto label_44;
            }
            
            goto label_45;
            label_30:
            if(1 <= 0)
            {
                    if(0 < ((val_24 + ((baseLayoutId - 1)) << 2) + 16.rowCount))
            {
                goto label_48;
            }
            
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            label_28:
            if(val_32 < ((val_24 + ((baseLayoutId - 1)) << 2) + 16 + 8))
            {
                goto label_50;
            }
            
            return (bool)val_23 & 1;
            label_48:
            val_23 = 0;
            return (bool)val_23 & 1;
        }
        private static void MergeSpecialLayoutToLevelLayout(BlockPuzzleMagic.GridLayout baseLayout, BlockPuzzleMagic.GridLayout specialLayout, BlockPuzzleMagic.GridLayout.NodeType specialLayoutFlag)
        {
            var val_7;
            var val_8;
            var val_9;
            System.Collections.Generic.List<BlockPuzzleMagic.GridCellData> val_10;
            var val_11;
            val_7 = 0;
            goto label_1;
            label_22:
            if((val_7 >= true) || ((baseLayout.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  0)) == true))
            {
                goto label_19;
            }
            
            if(specialLayout.gridData[val_7] != 1)
            {
                goto label_19;
            }
            
            if(specialLayoutFlag > 15)
            {
                goto label_9;
            }
            
            if(specialLayoutFlag == 2)
            {
                goto label_14;
            }
            
            if((specialLayoutFlag != 4) || ((baseLayout.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  128)) == true))
            {
                goto label_19;
            }
            
            val_8 = val_7;
            val_9 = 256;
            goto label_13;
            label_9:
            if(specialLayoutFlag == 16)
            {
                goto label_14;
            }
            
            if(specialLayoutFlag != 64)
            {
                goto label_19;
            }
            
            if((baseLayout.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  2)) != false)
            {
                    baseLayout.RemoveFlagFromGridDataNode(_gridDataIndex:  0, _nodeType:  2);
            }
            
            if((baseLayout.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  16)) == false)
            {
                goto label_18;
            }
            
            baseLayout.RemoveFlagFromGridDataNode(_gridDataIndex:  0, _nodeType:  16);
            goto label_18;
            label_14:
            val_8 = val_7;
            val_9 = 64;
            label_13:
            if((baseLayout.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  64)) == true)
            {
                goto label_19;
            }
            
            label_18:
            baseLayout.SetFlagToGridDataNode(_gridDataIndex:  0, _nodeType:  specialLayoutFlag);
            label_19:
            val_7 = 1;
            label_1:
            if(val_7 < baseLayout)
            {
                goto label_22;
            }
            
            val_10 = specialLayout.extraGridData;
            if(val_10 == 0)
            {
                    return;
            }
            
            if(baseLayout < 1)
            {
                    return;
            }
            
            val_11 = 4;
            goto label_25;
            label_36:
            if(baseLayout <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(2621443 != 0)
            {
                    if(2621443 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                BlockPuzzleMagic.GridCellData val_6 = baseLayout.GetOrAddExtraGridCellData(cellId:  static_value_0028000B, dontAddIfNull:  false);
                if(specialLayoutFlag == 64)
            {
                    baseLayout.gridData = static_value_0028000F;
            }
            
            }
            
            val_10 = specialLayout.extraGridData;
            val_11 = 5;
            label_25:
            val_7 = 1;
            if(val_7 < baseLayout)
            {
                goto label_36;
            }
        
        }
        private void GenerateGoalsForLevelRef(BlockPuzzleMagic.LevelRef currentLevel, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> goalWeights, System.Collections.Generic.Dictionary<int, int> goalInstanceCount)
        {
            bool val_26;
            BlockPuzzleMagic.LevelRef val_27;
            var val_28;
            var val_29;
            var val_30;
            float val_31;
            System.Collections.Generic.List<System.Collections.Generic.Dictionary<System.String, System.Object>> val_32;
            System.Collections.Generic.Dictionary<T, U> val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            int val_38;
            var val_39;
            var val_40;
            var val_41;
            BlockPuzzleMagic.LevelRef val_42;
            var val_43;
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            Player val_2 = App.Player;
            if(0 != 0)
            {
                    val_26 = mem[1179403827];
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_27 = currentLevel;
            if(val_27 == 0)
            {
                    val_27 = currentLevel;
            }
            
            mem2[0] = null;
            if(0 != 0)
            {
                    val_28 = 0;
                val_29 = val_28;
            }
            else
            {
                    val_29 = 0;
                val_28 = 0;
            }
            
            int val_4 = UnityEngine.Random.Range(min:  0, max:  0);
            if(0 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_25 = 0;
            val_25 = val_25 + (val_4 << 2);
            RandomSet val_6 = new RandomSet();
            val_30 = 0;
            val_31 = 1152921504619999232;
            val_32 = goalWeights;
            goto label_12;
            label_25:
            if(val_6 <= val_30)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_26 = goalWeights + 8;
            val_26 = val_26 + 0;
            val_33 = mem[(goalWeights + 8 + 0) + 16];
            val_33 = (goalWeights + 8 + 0) + 16;
            object val_7 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  val_33, key:  -1605531600, defaultValue:  13152256);
            val_34 = null;
            val_35 = val_33;
            val_35.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if((EnumerableExtentions.GetOrDefault<System.Int32, System.Int32>(dic:  goalInstanceCount, key:  0, defaultValue:  0)) < val_35)
            {
                    object val_9 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  val_33, key:  -576745552, defaultValue:  13152256);
                val_36 = null;
                val_35 = val_33;
                val_35.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                object val_10 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  val_33, key:  1229166720, defaultValue:  8945664);
                val_33 = 1152921504615792640;
                val_35 = val_33;
                val_26 = (float)val_35;
                add(item:  0, weight:  (float)val_35);
                val_34 = null;
                val_32 = goalWeights;
                val_35.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                if(val_35 != 0)
            {
                    add(item:  0, weight:  (float)val_35);
            }
            
            }
            
            val_30 = 1;
            label_12:
            if(val_30 < (goalWeights + 12))
            {
                goto label_25;
            }
            
            val_37 = val_6;
            if(((0 + (val_4) << 2) + 16) < 1)
            {
                    return;
            }
            
            val_33 = 0;
            val_31 = ((0 + (val_4) << 2) + 16) - 1;
            label_59:
            if(val_33 == 0)
            {
                    val_37 = new RandomSet();
            }
            
            if(remainingCount() < 1)
            {
                    return;
            }
            
            int val_12 = roll(unweighted:  false);
            if((goalWeights + 12) <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_27 = goalWeights + 8;
            val_27 = val_27 + (val_12 << 2);
            EnumerableExtentions.SetOrAdd<System.Int32, System.Int32>(dic:  goalInstanceCount, key:  val_12, newValue:  (EnumerableExtentions.GetOrDefault<System.Int32, System.Int32>(dic:  goalInstanceCount, key:  val_12, defaultValue:  0)) + 1);
            use(item:  val_12);
            use(item:  val_12);
            System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(464535552)});
            string val_16 = (goalWeights + 8 + (val_12) << 2) + 16.Item[1350676976];
            object val_17 = System.Enum.Parse(enumType:  464535552, value:  (goalWeights + 8 + (val_12) << 2) + 16);
            val_35 = null;
            val_36 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_38 = 0;
            if(( & (~1)) == 4)
            {
                goto label_55;
            }
            
            val_39 = 0;
            if(val_39 == 0)
            {
                    val_39 = 0;
            }
            
            if((1296.ContainsKey(key:  null)) == false)
            {
                goto label_55;
            }
            
            object val_20 = 1296.Item[null];
            object val_21 = 1296.Item[null];
            if(((0 + (val_4) << 2) + 16) <= 786450)
            {
                goto label_49;
            }
            
            val_40 = 0;
            if(786450 != 0)
            {
                goto label_52;
            }
            
            val_40 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            goto label_52;
            label_49:
            val_40 = val_31;
            if(786450 <= val_31)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_40 = val_31;
            }
            
            label_52:
            var val_28 = 92;
            val_28 = val_28 + (val_40 << 2);
            val_38 = mem[(92 + (((0 + (val_4) << 2) + 16 - 1)) << 2) + 16];
            val_38 = (92 + (((0 + (val_4) << 2) + 16 - 1)) << 2) + 16;
            val_41 = 0;
            if(val_41 == 0)
            {
                    val_41 = 0;
            }
            
            if((0.ContainsKey(key:  null)) != false)
            {
                    val_38 = 0.Item[null] + val_38;
            }
            
            label_55:
            val_42 = currentLevel;
            if(val_42 == 0)
            {
                    val_42 = currentLevel;
            }
            
            val_26 = mem[currentLevel + 12];
            val_26 = currentLevel + 12;
            object val_24 = null;
            val_43 = val_24;
            val_24 = new System.Object();
            typeof(BlockPuzzleMagic.GoalRef).__il2cppRuntimeField_8 = ;
            typeof(BlockPuzzleMagic.GoalRef).__il2cppRuntimeField_C = val_38;
            val_26.Add(item:  465760256);
            val_33 = val_33 + 1;
            val_37 = val_6;
            if(val_33 < ((0 + (val_4) << 2) + 16))
            {
                goto label_59;
            }
        
        }
        private System.Collections.Generic.List<BlockPuzzleMagic.MechanicType> GenerateAdditionalLevelMechanicTypes(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> weights, System.Collections.Generic.Dictionary<int, int> instanceCount)
        {
            int val_14;
            System.Collections.Generic.Dictionary<T, U> val_15;
            var val_16;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_17;
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            Player val_2 = App.Player;
            RandomSet val_4 = new RandomSet();
            val_14 = 0;
            goto label_3;
            label_12:
            if(val_4 <= val_14)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + 0;
            val_15 = mem[(0 + 0) + 16];
            val_15 = (0 + 0) + 16;
            object val_5 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  val_15, key:  -1605531600, defaultValue:  13152256);
            val_16 = null;
            val_17 = val_15;
            val_17.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if((EnumerableExtentions.GetOrDefault<System.Int32, System.Int32>(dic:  instanceCount, key:  0, defaultValue:  0)) < val_17)
            {
                    object val_7 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  val_15, key:  -576745552, defaultValue:  13152256);
                val_16 = null;
                val_17 = val_15;
                val_17.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                add(item:  0, weight:  (float)val_17);
            }
            
            val_14 = 1;
            label_3:
            if(val_14 < val_4)
            {
                goto label_12;
            }
            
            if(val_4 < 1)
            {
                    return;
            }
            
            var val_16 = 0;
            val_15 = 1152921505072820224;
            do
            {
                var val_15 = 0;
                int val_8 = roll(unweighted:  false);
                val_14 = val_8;
                if(val_8 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_15 = val_15 + (val_14 << 2);
                System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(465973248)});
                string val_10 = (0 + (val_8) << 2) + 16.Item[1350676976];
                object val_11 = System.Enum.Parse(enumType:  465973248, value:  (0 + (val_8) << 2) + 16);
                val_17 = null;
                val_16 = null;
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                if( == 0)
            {
                    return;
            }
            
                val_17 = instanceCount;
                EnumerableExtentions.SetOrAdd<System.Int32, System.Int32>(dic:  val_17, key:  val_14, newValue:  (EnumerableExtentions.GetOrDefault<System.Int32, System.Int32>(dic:  val_17, key:  val_14, defaultValue:  0)) + 1);
                val_14 = new System.Collections.Generic.List<WordPets.WordPetType>();
                Add(item:  null);
                val_16 = val_16 + 1;
            }
            while(val_16 < val_14);
        
        }
        private static void AddGoalsRemoveColorsForLevel(BlockPuzzleMagic.Level currentLevel, BlockPuzzleMagic.LevelRef levelRef)
        {
            BlockPuzzleMagic.Level val_16;
            var val_17;
            System.Predicate<BlockPuzzleMagic.GoalRef> val_19;
            var val_20;
            var val_21;
            System.Predicate<BlockPuzzleMagic.GoalRef> val_23;
            var val_24;
            var val_25;
            var val_26;
            System.Collections.Generic.List<BlockPuzzleMagic.GoalRef> val_27;
            var val_28;
            var val_29;
            var val_30;
            val_16 = currentLevel;
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            Player val_2 = App.Player;
            if(levelRef.dotLayoutId >= 1)
            {
                    val_17 = null;
                val_17 = null;
                val_19 = LevelManager.<>c.<>9__28_0;
                if(val_19 == 0)
            {
                    val_19 = null;
                val_19 = new System.Predicate<ZooTile>(object:  LevelManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1271297744));
                LevelManager.<>c.<>9__28_0 = val_19;
            }
            
                BlockPuzzleMagic.GoalRef val_4 = levelRef.goals.Find(match:  8040448);
                if(levelRef.goals == 0)
            {
                    object val_5 = new System.Object();
                typeof(BlockPuzzleMagic.GoalRef).__il2cppRuntimeField_8 = 4;
                typeof(BlockPuzzleMagic.GoalRef).__il2cppRuntimeField_C = 0;
                levelRef.goals.Add(item:  465760256);
            }
            
            }
            
            if(levelRef.stoneLayoutId >= 1)
            {
                    val_21 = null;
                val_21 = null;
                val_23 = LevelManager.<>c.<>9__28_1;
                if(val_23 == 0)
            {
                    val_23 = null;
                val_23 = new System.Predicate<ZooTile>(object:  LevelManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1271309008));
                LevelManager.<>c.<>9__28_1 = val_23;
            }
            
                BlockPuzzleMagic.GoalRef val_7 = levelRef.goals.Find(match:  8040448);
                if(levelRef.goals == 0)
            {
                    object val_8 = new System.Object();
                typeof(BlockPuzzleMagic.GoalRef).__il2cppRuntimeField_8 = 5;
                typeof(BlockPuzzleMagic.GoalRef).__il2cppRuntimeField_C = 0;
                levelRef.goals.Add(item:  465760256);
            }
            
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_9 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            currentLevel.goals = null;
            val_24 = 0;
            null = new RandomSet();
            val_25 = 1152921505070051328;
            goto label_23;
            label_28:
            add(item:  0, weight:  null);
            val_24 = 1;
            label_23:
            val_26 = null;
            val_26 = null;
            if(val_24 < (BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 12))
            {
                goto label_28;
            }
            
            System.Collections.Generic.List<WordPets.WordPetType> val_11 = new System.Collections.Generic.List<WordPets.WordPetType>();
            currentLevel.colorsRemoved = null;
            val_27 = levelRef.goals;
            if(val_27 == 0)
            {
                    return;
            }
            
            if((levelRef.goals + 12) < 1)
            {
                    return;
            }
            
            label_52:
            if((levelRef.goals + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = mem[levelRef.goals + 8 + 16 + 8];
            val_16 = levelRef.goals + 8 + 16 + 8;
            val_20 = 0;
            if(val_16 == 5)
            {
                goto label_34;
            }
            
            if(val_16 == 4)
            {
                goto label_35;
            }
            
            if(val_16 != 3)
            {
                goto label_42;
            }
            
            val_28 = null;
            val_28 = null;
            BlockPuzzleMagic.BlockColorType[] val_13 = BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + ((roll(unweighted:  false)) << 2);
            val_20 = mem[(BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + (val_12) << 2) + 16];
            val_20 = (BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + (val_12) << 2) + 16;
            goto label_42;
            label_34:
            if((levelRef.goals + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_29 = mem[levelRef.goals + 8 + 16];
            val_29 = levelRef.goals + 8 + 16;
            val_30 = 4;
            goto label_45;
            label_35:
            if((levelRef.goals + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_29 = mem[levelRef.goals + 8 + 16];
            val_29 = levelRef.goals + 8 + 16;
            val_30 = 2;
            label_45:
            mem2[0] = currentLevel + 20.GetNodeTypeGridCount(_nodeType:  2);
            label_42:
            if((levelRef.goals + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            object val_15 = null;
            val_25 = val_15;
            val_15 = new System.Object();
            typeof(BlockPuzzleMagic.Goal).__il2cppRuntimeField_8 = val_16;
            typeof(BlockPuzzleMagic.Goal).__il2cppRuntimeField_C = levelRef.goals + 8 + 16 + 12;
            typeof(BlockPuzzleMagic.Goal).__il2cppRuntimeField_10 = 0;
            typeof(BlockPuzzleMagic.Goal).__il2cppRuntimeField_14 = val_20;
            currentLevel + 16.Add(item:  464482304);
            val_27 = levelRef.goals;
            var val_16 = 4 + 1;
            if((4 - 3) < (levelRef.goals + 12))
            {
                goto label_52;
            }
        
        }
        private static void SetupAdditionalMechanicsForLevel(BlockPuzzleMagic.Level currentLevel, BlockPuzzleMagic.LevelRef levelRef)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4;
            var val_5;
            if(levelRef.additionalMechanics == 0)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            currentLevel.additionalMechanics = val_4;
            val_5 = 0;
            goto label_4;
            label_14:
            if(val_4 <= val_5)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            if(((0 + 0) + 16 + 8) == 301)
            {
                    WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
                SetupLoops(gridLayout:  currentLevel.gridLayout, mechRef:  (0 + 0) + 16);
            }
            
            BlockPuzzleMagic.LevelMechanicMetadata val_3 = BlockPuzzleMagic.LevelMechanicMetadata.Clone(instance:  (0 + 0) + 16);
            val_4 = (0 + 0) + 16;
            currentLevel.additionalMechanics.Add(item:  val_4);
            val_5 = 1;
            label_4:
            if(val_5 < currentLevel.additionalMechanics)
            {
                goto label_14;
            }
        
        }
        public LevelManager()
        {
        
        }
    
    }

}
