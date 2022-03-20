using UnityEngine;

namespace WordPets
{
    public class WPTDataParser : MonoSingletonSelfGenerating<WordPets.WPTDataParser>
    {
        // Fields
        public const char generatedCharacterSpace = '\x2d';
        public const string PETS_REQ_KEY = "prq";
        public const string PETS_SPARE_KEY = "spr";
        public const string COL_KEY = "c";
        public const string INITIAL_PET = "ip";
        public const string TOTAL_INITIAL_PETS = "tip";
        public const string COL_PET_ID = "cpid";
        public const string COL_PET_TIMER = "cptm";
        public const string INITAL_LETTERS = "il";
        public const string LETTER_DATA = "ldt";
        public const string MAX_COL_HEIGHT = "mch";
        public const string LEVEL_ID_KEY = "lvl";
        public const string CHAPTER_NUM_ID_KEY = "ch";
        public const string LEVELS_ID_KEY = "lvls";
        public const string CRATE_CHANCE_KEY = "cratc";
        public const string SPIDER_CHANCE_KEY = "spdrc";
        public const string BALLOON_CHANCE_KEY = "blonc";
        public const string BUTTERFLY_AMOUNT = "bfamt";
        public const string TILE_BUTTERFLY_KEY = "tlbf";
        public const string TILE_CRATE_KEY = "tlcr";
        public const string TILE_SPIDERWEB_KEY = "tlsw";
        public const string TILE_BALLOON_KEY = "tlbl";
        private const int BUILT_IN_CHAPTERS = 10;
        private const int LEVELS_PER_CHAPTERS = 12;
        private const string PP_SAVED = "PP_SavedDataOnce";
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>> chapterData;
        private bool initd;
        private string predefinedLevelBucket;
        
        // Properties
        public static int PREDETERMINED_LEVELS { get; }
        
        // Methods
        public static int get_PREDETERMINED_LEVELS()
        {
            Player val_1 = App.Player;
            bool val_2 = System.String.op_Equality(a:  33449456, b:  -1930531024);
            return 100;
        }
        public string GetChapterFilePath(int chapter)
        {
            string val_1 = UnityEngine.Application.persistentDataPath;
            string val_2 = chapter.ToString();
            string val_3 = null + 136390400 + 136402476 + -663337856(-663337856);
        }
        public System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> getLevelChapterData(int level)
        {
            if(this.chapterData != 0)
            {
                    return this.chapterData.Item[this.GetChapterForPlayerLevel(level:  level)];
            }
            
            return this.chapterData.Item[this.GetChapterForPlayerLevel(level:  level)];
        }
        private void Start()
        {
            if(this.initd == true)
            {
                    return;
            }
            
            this.initd = true;
            this.LoadAllData();
        }
        public void Init(bool forceInit = False)
        {
            if(this.initd != false)
            {
                    if(forceInit == false)
            {
                    return;
            }
            
            }
            
            this.initd = true;
            this.LoadAllData();
        }
        public WordPets.WPTLevelData GetLevelData(int level)
        {
            var val_6;
            if(this.initd != true)
            {
                    this.initd = true;
                this.LoadAllData();
            }
            
            int val_1 = WordPets.WPTDataParser.PREDETERMINED_LEVELS;
            if(level > 100)
            {
                goto label_2;
            }
            
            WordPets.WPTLevelData val_2 = this.GetPredefinedLevel(level:  level);
            val_6 = this;
            if(this != 0)
            {
                goto label_3;
            }
            
            string val_3 = System.String.Format(format:  136847712, arg0:  13152256);
            UnityEngine.Debug.LogError(message:  136847712);
            label_2:
            WordPets.WPTLevelData val_4 = WordPets.WPTLevelData.CreateRandom(levelId:  level);
            val_6 = level;
            label_3:
            val_6.InitializeLetterData(useEasyLetters:  WordPets.WPTGameUIController.UseEasyLetters);
        }
        private WordPets.WPTLevelData GetPredefinedLevel(int level)
        {
            string val_9;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            Player val_1 = App.Player;
            string val_2 = 33449456.ToUpperInvariant();
            if((System.String.op_Inequality(a:  this.predefinedLevelBucket, b:  33449456)) != false)
            {
                    this.initd = true;
                this.LoadAllData();
            }
            
            Dictionary.Enumerator<TKey, TValue> val_4 = GetEnumerator();
            label_18:
            if(0.MoveNext() == false)
            {
                goto label_7;
            }
            
            List.Enumerator<T> val_7 = GetEnumerator();
            label_14:
            if(MoveNext() == false)
            {
                goto label_9;
            }
            
            if((val_9.ContainsKey(key:  -1640018224)) == false)
            {
                goto label_14;
            }
            
            string val_11 = val_9.Item[-1640018224];
            var val_16 = 0;
            val_16 = val_16 - level;
            val_16 = val_16 >> 5;
            if(((System.Int32.TryParse(s:  val_9, result: out  int val_12 = 136983052)) & val_16) != 0)
            {
                goto label_14;
            }
            
            val_15 = 0;
            val_16 = 161;
            val_17 = 0;
            goto label_15;
            label_9:
            val_15 = 0;
            val_16 = 161;
            val_17 = 0;
            label_15:
            var val_14 = val_15 + 1;
            mem2[0] = val_16;
            Dispose();
            if(val_14 == 1)
            {
                goto label_18;
            }
            
            if((136982984 + ((val_15 + 1)) << 2) == 161)
            {
                    136982984 + ((val_15 + 1)) << 2 = val_14 >> 31;
                136982984 + ((val_15 + 1)) << 2 = ~(val_14 >> 31);
                val_14 = val_14 + (136982984 + ((val_15 + 1)) << 2);
            }
            
            goto label_18;
            label_7:
            0.Dispose();
            if(val_9 != 0)
            {
                    WordPets.WPTLevelData val_15 = null;
                val_18 = val_15;
                val_15 = new WordPets.WPTLevelData(data:  val_9);
                return;
            }
            
            val_18 = 0;
        }
        public int GetChapterForPlayerLevel(int level)
        {
            int val_4;
            string val_8;
            var val_15;
            int val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_21;
            Dictionary.KeyCollection<TKey, TValue> val_1 = mem[1152921513333901004].Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            val_15 = 1152921510392296080;
            label_18:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            val_16 = val_4;
            if(mem[1152921513333901004] == 0)
            {
                    val_16 = val_16;
                val_17 = ;
                val_15 = val_15;
            }
            
            System.TimeType val_5 = mem[1152921513333901004].Item[val_16];
            List.Enumerator<T> val_6 = GetEnumerator();
            label_11:
            if(MoveNext() == false)
            {
                goto label_6;
            }
            
            if((val_8.ContainsKey(key:  -1640018224)) == false)
            {
                goto label_11;
            }
            
            string val_10 = val_8.Item[-1640018224];
            var val_13 = 0;
            val_13 = val_13 - level;
            val_13 = val_13 >> 5;
            if(((System.Int32.TryParse(s:  val_8, result: out  int val_11 = 137107348)) & val_13) != 0)
            {
                goto label_11;
            }
            
            val_18 = 0;
            val_19 = 1;
            goto label_26;
            label_6:
            val_18 = 0;
            val_19 = 0 + 1;
            mem2[0] = 131;
            label_26:
            Dispose();
            if(val_19 == 1)
            {
                goto label_18;
            }
            
            if((137107288 + ((0 + 1)) << 2) == 131)
            {
                goto label_15;
            }
            
            if((137107288 + ((0 + 1)) << 2) != 158)
            {
                goto label_18;
            }
            
            goto label_17;
            label_15:
            var val_14 = val_19 >> 31;
            var val_15 = ~(val_19 >> 31);
            val_15 = val_19 + val_15;
            goto label_18;
            label_3:
            val_19 = 0 + 1;
            mem2[0] = 156;
            label_17:
            Dispose();
            if(val_19 != 1)
            {
                    if((137107288 + ((0 + 1)) << 2) != 158)
            {
                    val_21 = 0;
            }
            
                return (int)val_21;
            }
            
            val_21 = 0;
            return (int)val_21;
        }
        private void LoadAllData()
        {
            var val_14;
            var val_15;
            float val_16;
            var val_17;
            var val_18;
            var val_19;
            val_14 = 11644676 + 23981111;
            if(val_14 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_15 = null;
            val_15 = null;
            val_16 = 1152921504902160384;
            val_17 = null;
            val_18 = val_17;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_2 = System.String.Format(format:  137207536, arg0:  295313408);
            if((UnityEngine.PlayerPrefs.HasKey(key:  137207424)) != false)
            {
                    string val_3 = UnityEngine.Application.persistentDataPath;
            }
            else
            {
                    string val_4 = UnityEngine.Application.dataPath;
                if(val_14 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_19 = null;
                val_19 = null;
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                string val_5 = -1655690384(-1655690384) + 295313408 + 137207664;
                System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(158519296)});
                UnityEngine.Object[] val_7 = UnityEngine.Resources.LoadAll(path:  -1655690384, systemTypeInstance:  158519296);
                val_14 = "game/";
                val_17 = null;
                val_16 = 0;
                UnityEngine.PlayerPrefs.SetInt(key:  137207424, value:  1);
                bool val_13 = PrefsSerializationManager.SavePlayerPrefs();
            }
            
            this.LoadLevelsInMemory();
        }
        private void LoadLevelsInMemory()
        {
            WordPets.WPTDataParser val_19;
            var val_20;
            float val_21;
            var val_22;
            float val_23;
            var val_24;
            WordPets.WPTDataParser val_25;
            bool val_26;
            var val_27;
            var val_28;
            var val_29;
            val_19 = this;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            this.chapterData = null;
            Player val_2 = App.Player;
            val_20 = 0;
            string val_3 = 33449456.ToUpperInvariant();
            this.predefinedLevelBucket = 33449456;
            string val_4 = UnityEngine.Application.persistentDataPath;
            val_21 = "B";
            val_22 = "{0}/{1}";
            val_23 = "Chapter0_b.txt";
            if((System.String.op_Equality(a:  this.predefinedLevelBucket, b:  -1930530848)) == true)
            {
                    "Chapter0.txt" = val_23;
            }
            
            string val_6 = System.String.Format(format:  1629069648, arg0:  0, arg1:  137324880);
            val_24 = "{0}/{1}";
            if((System.IO.File.Exists(path:  1629069648)) == true)
            {
                goto label_5;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_24;
            UnityEngine.Debug.LogErrorFormat(format:  137325072, args:  472754880);
            string val_8 = UnityEngine.Application.persistentDataPath;
            val_25 = val_19;
            if((System.String.op_Inequality(a:  this.predefinedLevelBucket, b:  -1930530848)) == true)
            {
                    val_26 = val_23;
            }
            
            string val_10 = System.String.Format(format:  1629069648, arg0:  0, arg1:  137324880);
            val_24 = "{0}/{1}";
            if((System.IO.File.Exists(path:  1629069648)) == false)
            {
                goto label_12;
            }
            
            val_20 = 0;
            label_5:
            string val_12 = System.IO.File.ReadAllText(path:  1629069648);
            object val_13 = MiniJSON.Json.Deserialize(json:  1629069648);
            if(val_24 != 0)
            {
                    if(null == null)
            {
                goto label_35;
            }
            
            }
            
            label_35:
            val_26 = 1152921510385703632;
            string val_14 = 0.Item[-1340671904];
            val_27 = 0;
            bool val_16 = System.Int32.TryParse(s:  null, result: out  int val_15 = 137342520);
            string val_17 = 0.Item[-1640018224];
            if(0 != 0)
            {
                    val_26 = mem[1179403827];
                if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    0 = 0;
            }
            
                val_27 = 0;
            }
            
            val_21 = 0;
            val_28 = 0;
            val_22 = 1152921511374773456;
            goto label_20;
            label_26:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_28)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = 0;
            val_19 = val_19 + 0;
            val_23 = mem[(0 + 0) + 16];
            val_23 = (0 + 0) + 16;
            val_29 = 0;
            if(val_23 != 0)
            {
                    val_26 = mem[(0 + 0) + 16 + 180];
                val_26 = (0 + 0) + 16 + 180;
                if((((0 + 0) + 16 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_23 = val_21;
            }
            
                val_29 = val_23;
            }
            
            Add(item:  0);
            val_28 = 1;
            label_20:
            if(val_28 < 0)
            {
                goto label_26;
            }
            
            Add(key:  0, value:  80883712);
            return;
            label_12:
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_24;
            UnityEngine.Debug.LogErrorFormat(format:  137330368, args:  472754880);
        }
        public WPTDataParser()
        {
        
        }
    
    }

}
