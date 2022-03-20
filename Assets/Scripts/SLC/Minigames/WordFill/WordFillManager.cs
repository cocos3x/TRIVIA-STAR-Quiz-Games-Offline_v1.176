using UnityEngine;

namespace SLC.Minigames.WordFill
{
    public class WordFillManager : MonoSingleton<SLC.Minigames.WordFill.WordFillManager>
    {
        // Fields
        private System.Collections.Generic.List<int> levelSizes;
        private System.Collections.Generic.List<float> levelTimers;
        private System.Collections.Generic.List<string> categoryNames;
        private System.Collections.Generic.Dictionary<string, SLC.Minigames.WordFill.WFCategory> categories;
        private System.Collections.Generic.Dictionary<string, SLC.Minigames.WordFill.WFLShapeDef> shapeDefs;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<SLC.Minigames.WordFill.WFLComb>> levelConfigs;
        private bool init;
        private int <playerLevel>k__BackingField;
        private int <playerLevelSize>k__BackingField;
        private float <playerLevelTime>k__BackingField;
        private string <playerLevelCategory>k__BackingField;
        private int <playerLives>k__BackingField;
        private SLC.Minigames.WordFill.WordFillLevel currentLevel;
        private System.Collections.Generic.Queue<string> categoryHist;
        private System.Collections.Generic.HashSet<string> commonAndUncommonWords;
        
        // Properties
        public int playerLevel { get; set; }
        public int playerLevelSize { get; set; }
        public float playerLevelTime { get; set; }
        public string playerLevelCategory { get; set; }
        public int playerLives { get; set; }
        
        // Methods
        public int get_playerLevel()
        {
            return (int)this.<playerLevel>k__BackingField;
        }
        protected void set_playerLevel(int value)
        {
            this.<playerLevel>k__BackingField = value;
        }
        public int get_playerLevelSize()
        {
            return (int)this.<playerLevelSize>k__BackingField;
        }
        protected void set_playerLevelSize(int value)
        {
            this.<playerLevelSize>k__BackingField = value;
        }
        public float get_playerLevelTime()
        {
            return (float)S0;
        }
        protected void set_playerLevelTime(float value)
        {
            this.<playerLevelTime>k__BackingField = ;
        }
        public string get_playerLevelCategory()
        {
        
        }
        protected void set_playerLevelCategory(string value)
        {
            this.<playerLevelCategory>k__BackingField = value;
        }
        public int get_playerLives()
        {
            return (int)this.<playerLives>k__BackingField;
        }
        protected void set_playerLives(int value)
        {
            this.<playerLives>k__BackingField = value;
        }
        public override void InitMonoSingleton()
        {
            this.Initialize();
        }
        private void Initialize()
        {
            if(this.init != false)
            {
                    return;
            }
            
            this.LoadData();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = new System.Action(object:  956453792, method:  new IntPtr(956427744));
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = new System.Action(object:  956453792, method:  new IntPtr(956427744));
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_6 = new System.Action(object:  956453792, method:  new IntPtr(956428768));
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C = null;
            this.init = true;
        }
        private void Start()
        {
            this.<playerLevel>k__BackingField = 0;
            this.<playerLevelSize>k__BackingField = 6;
            this.<playerLevelTime>k__BackingField = 30f;
            this.<playerLives>k__BackingField = 3;
            this.ResetLevel();
        }
        private void LoadData()
        {
            string val_10;
            string val_24;
            SLC.Minigames.WordFill.WordFillManager val_38;
            var val_39;
            var val_40;
            int val_41;
            var val_42;
            var val_43;
            var val_44;
            string val_45;
            var val_46;
            SLC.Minigames.WordFill.WordFillManager val_47;
            var val_48;
            string val_49;
            var val_50;
            var val_51;
            UnityEngine.UI.Text val_52;
            val_38 = this;
            this.levelSizes.Clear();
            this.levelTimers.Clear();
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  956663008);
            val_39 = 0;
            string val_2 = text;
            object val_3 = MiniJSON.Json.Deserialize(json:  956663008);
            val_40 = 0;
            if(("minigames/WordFill/word_fill_levels") == 0)
            {
                goto label_6;
            }
            
            val_40 = 0;
            if(null != null)
            {
                    "minigames/WordFill/word_fill_levels" = 0;
            }
            
            val_40 = "minigames/WordFill/word_fill_levels";
            goto label_6;
            label_16:
            if(("minigames/WordFill/word_fill_levels") <= val_39)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_40 = 0;
            val_40 = val_40 + 0;
            val_41 = mem[(0 + 0) + 16];
            val_41 = (0 + 0) + 16;
            val_42 = null;
            val_41.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.levelTimers.Add(item:  null);
            if(0 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_41 = 0;
            val_41 = val_41 + 0;
            val_41 = mem[(0 + 0) + 20];
            val_41 = (0 + 0) + 20;
            val_42 = null;
            val_41.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.levelSizes.Add(item:  val_41);
            val_39 = 1 + 1;
            val_38 = val_38;
            label_6:
            if(val_39 < (0 - 1))
            {
                goto label_16;
            }
            
            mem[1152921514153486744].Clear();
            mem[1152921514153486740].Clear();
            object val_5 = UnityEngine.Resources.Load<System.Object>(path:  956672368);
            string val_6 = text;
            object val_7 = MiniJSON.Json.Deserialize(json:  956672368);
            if(("minigames/WordFill/word_fill_categories") != 0)
            {
                    if(null == null)
            {
                goto label_97;
            }
            
            }
            
            if(("minigames/WordFill/word_fill_categories") != 0)
            {
                    label_97:
            }
            
            val_43 = 0;
            List.Enumerator<T> val_8 = GetEnumerator();
            label_33:
            if(MoveNext() == false)
            {
                goto label_26;
            }
            
            SLC.Minigames.WordFill.WFCategory val_11 = new SLC.Minigames.WordFill.WFCategory(data:  0);
            mem[1152921514153486744].Add(key:  -465901760, value:  449839104);
            mem[1152921514153486740].Add(item:  -465901760);
            goto label_33;
            label_26:
            Dispose();
            mem[1152921514153486748].Clear();
            object val_12 = UnityEngine.Resources.Load<System.Object>(path:  956674576);
            string val_13 = text;
            object val_14 = MiniJSON.Json.Deserialize(json:  956674576);
            if(("minigames/WordFill/shape_def") != 0)
            {
                    if(null == null)
            {
                goto label_98;
            }
            
            }
            
            if(("minigames/WordFill/shape_def") != 0)
            {
                    label_98:
            }
            
            val_44 = 0;
            List.Enumerator<T> val_15 = GetEnumerator();
            label_49:
            if(MoveNext() == false)
            {
                goto label_43;
            }
            
            val_45 = 0;
            if(val_10 != 0)
            {
                    if(val_10 != null)
            {
                
            }
            else
            {
                    val_45 = val_10;
            }
            
            }
            
            SLC.Minigames.WordFill.WFLShapeDef val_17 = new SLC.Minigames.WordFill.WFLShapeDef(data:  val_45);
            mem[1152921514153486748].Add(key:  SLC.Minigames.WordFill.WFLShapeDef.__il2cppRuntimeField_byval_arg, value:  449892352);
            goto label_49;
            label_43:
            Dispose();
            mem[1152921514153486752].Clear();
            object val_18 = UnityEngine.Resources.Load<System.Object>(path:  956676752);
            string val_19 = text;
            object val_20 = MiniJSON.Json.Deserialize(json:  956676752);
            if(("minigames/WordFill/word_fill_configurations") != 0)
            {
                    if(null == null)
            {
                goto label_99;
            }
            
            }
            
            label_99:
            Dictionary.KeyCollection<TKey, TValue> val_21 = 0.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_22 = GetEnumerator();
            var val_42 = 0;
            label_74:
            if(MoveNext() == false)
            {
                goto label_56;
            }
            
            string val_25 = 0.Item[val_24];
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_27 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            mem[1152921514153486752].Add(key:  System.Int32.Parse(s:  val_24), value:  80883712);
            if(0 != 0)
            {
                    val_46 = null;
            }
            
            if(0 != 0)
            {
                    val_46 = null;
                val_47 = val_38;
                val_48 = 0;
                if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_46)
            {
                    0 = 0;
            }
            
                val_48 = 0;
            }
            else
            {
                    val_47 = val_38;
                val_48 = 0;
            }
            
            List.Enumerator<T> val_28 = GetEnumerator();
            label_71:
            if(MoveNext() == false)
            {
                goto label_65;
            }
            
            val_49 = 0;
            if(val_10 != 0)
            {
                    if(val_10 != null)
            {
                
            }
            else
            {
                    val_49 = val_10;
            }
            
            }
            
            System.TimeType val_31 = mem[1152921514153486752].Item[System.Int32.Parse(s:  val_24)];
            SLC.Minigames.WordFill.WFLComb val_32 = new SLC.Minigames.WordFill.WFLComb(data:  val_49);
            mem[1152921514153486752].Add(item:  450052096);
            goto label_71;
            label_65:
            var val_33 = val_42 + 1;
            mem2[0] = 534;
            Dispose();
            if(val_33 == 1)
            {
                goto label_74;
            }
            
            if((956693016 + ((0 + 1)) << 2) == 534)
            {
                    956693016 + ((0 + 1)) << 2 = val_33 >> 31;
                956693016 + ((0 + 1)) << 2 = ~(val_33 >> 31);
                val_33 = val_33 + (956693016 + ((0 + 1)) << 2);
            }
            
            goto label_74;
            label_56:
            val_42 = val_42 + 1;
            mem2[0] = 562;
            Dispose();
            if(val_42 != 1)
            {
                    if(val_42 > 1)
            {
                    0 = 1;
            }
            
                var val_43 = 956693016 + ((0 + 1)) << 2;
                val_43 = val_43 - 562;
                val_43 = val_43 >> 5;
                val_43 = 1 & val_43;
                val_43 = val_42 - val_43;
                val_50 = val_43 + 1;
            }
            else
            {
                    val_50 = 0;
            }
            
            mem[1152921514153486788].Clear();
            object val_34 = UnityEngine.Resources.Load<System.Object>(path:  956681008);
            string val_35 = text;
            object val_36 = MiniJSON.Json.Deserialize(json:  956681008);
            if(("minigames/WordFill/word_fill_words") != 0)
            {
                    if(null == null)
            {
                goto label_100;
            }
            
            }
            
            if(("minigames/WordFill/word_fill_words") != 0)
            {
                    label_100:
            }
            
            val_51 = 0;
            List.Enumerator<T> val_37 = GetEnumerator();
            label_96:
            if(MoveNext() == false)
            {
                goto label_91;
            }
            
            val_52 = 0;
            if(val_10 != 0)
            {
                    if(val_10 != null)
            {
                
            }
            else
            {
                    val_52 = val_10;
            }
            
            }
            
            bool val_39 = mem[1152921514153486788].Add(item:  val_52);
            goto label_96;
            label_91:
            Dispose();
        }
        private void ResetLevel()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.WordFill.WordFillUIController MonoSingleton<SLC.Minigames.WordFill.WordFillUIController>::get_Instance().__il2cppRuntimeField_C.enabled = true;
            this.<playerLives>k__BackingField = 3;
            this.CreateLevel();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SetLevel(lev:  this.<playerLevel>k__BackingField);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StartLevel(level:  this.currentLevel);
        }
        private void CreateLevel()
        {
            SLC.Minigames.WordFill.WFCategory val_23;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.<playerLevel>k__BackingField = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_3 = IsFtuxLevel(lev:  this.<playerLevel>k__BackingField);
            if(val_3 != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                this.<playerLevelSize>k__BackingField = GetFtuxLevelSize(lev:  this.<playerLevel>k__BackingField);
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                float val_7 = GetFtuxLevelTime(lev:  this.<playerLevel>k__BackingField);
                this.<playerLevelTime>k__BackingField = public static WordFillFTUXManager MonoSingleton<WordFillFTUXManager>::get_Instance();
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                SLC.Minigames.WordFill.WordFillLevel val_9 = GetFtuxLevel(lev:  this.<playerLevel>k__BackingField);
                this.currentLevel = public static WordFillFTUXManager MonoSingleton<WordFillFTUXManager>::get_Instance();
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                string val_11 = GetFtuxLevelCategory(lev:  this.<playerLevel>k__BackingField);
                this.<playerLevelCategory>k__BackingField = public static WordFillFTUXManager MonoSingleton<WordFillFTUXManager>::get_Instance();
                this.categoryHist.Enqueue(item:  956809536);
                return;
            }
            
            if(val_3 <= (this.<playerLevel>k__BackingField))
            {
                    var val_23 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_23 = val_23 + ((this.<playerLevel>k__BackingField) << 2);
            this.<playerLevelSize>k__BackingField = (0 + (this.<playerLevel>k__BackingField) << 2) + 16;
            if(((0 + (this.<playerLevel>k__BackingField) << 2) + 16) <= (this.<playerLevel>k__BackingField))
            {
                    var val_24 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = val_24 + ((this.<playerLevel>k__BackingField) << 2);
            this.<playerLevelTime>k__BackingField = (0 + (this.<playerLevel>k__BackingField) << 2) + 16;
            System.Collections.Generic.List<SLC.Minigames.WordFill.WFLComb> val_12 = this.levelConfigs.Item[this.<playerLevelSize>k__BackingField];
            val_23 = 0;
            int val_14 = RandomSet.singleInRange(lowest:  0, highest:  this.levelConfigs - 1);
            if(val_14 <= val_14)
            {
                    var val_25 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_25 = val_25 + (val_14 << 2);
            if(val_23 != 0)
            {
                    this.categoryHist.Enqueue(item:  (0 + (val_16) << 2) + 16);
                if(this.categoryHist >= 51)
            {
                    string val_21 = this.categoryHist.Dequeue();
            }
            
                SLC.Minigames.WordFill.WordFillLevel val_22 = (0 + (val_14) << 2) + 16.CreateLevel(cat:  val_23 = this.categories, shapeDefs:  this.shapeDefs);
                this.currentLevel = (0 + (val_14) << 2) + 16;
                this.<playerLevelCategory>k__BackingField = (0 + (val_14) << 2) + 16;
            }
        
        }
        public void LostLife()
        {
            int val_4 = this.<playerLives>k__BackingField;
            if(val_4 < 1)
            {
                    return;
            }
            
            val_4 = val_4 - 1;
            this.<playerLives>k__BackingField = val_4;
            if(val_4 > 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = HandleLevelFailed();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.WordFill.WordFillUIController MonoSingleton<SLC.Minigames.WordFill.WordFillUIController>::get_Instance().__il2cppRuntimeField_5E = 1;
        }
        public void BeatLevel()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(HandleLevelComplete() != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static SLC.Minigames.WordFill.WordFillUIController MonoSingleton<SLC.Minigames.WordFill.WordFillUIController>::get_Instance().__il2cppRuntimeField_5E = 1;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUI();
        }
        public void StartNextLevel()
        {
            System.Collections.IEnumerator val_1 = this.OnStartNextLevel();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  957390080);
        }
        private System.Collections.IEnumerator OnStartNextLevel()
        {
            object val_1 = new System.Object();
            typeof(WordFillManager.<OnStartNextLevel>d__39).__il2cppRuntimeField_8 = 0;
            typeof(WordFillManager.<OnStartNextLevel>d__39).__il2cppRuntimeField_10 = this;
        }
        public bool IsValidWord(string word)
        {
            if(this.commonAndUncommonWords != 0)
            {
                    return this.commonAndUncommonWords.Contains(item:  word);
            }
            
            return this.commonAndUncommonWords.Contains(item:  word);
        }
        private void ContinueToggleUI()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.WordFill.WordFillUIController MonoSingleton<SLC.Minigames.WordFill.WordFillUIController>::get_Instance().__il2cppRuntimeField_5E = 0;
        }
        public WordFillManager()
        {
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            this.levelSizes = null;
            System.Collections.Generic.List<System.Single> val_2 = new System.Collections.Generic.List<System.Single>();
            this.levelTimers = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.categoryNames = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.categories = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.shapeDefs = null;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_6 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            this.levelConfigs = null;
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_7 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            this.categoryHist = null;
            System.Collections.Generic.HashSet<UnityEngine.UI.Text> val_8 = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            this.commonAndUncommonWords = null;
        }
    
    }

}
