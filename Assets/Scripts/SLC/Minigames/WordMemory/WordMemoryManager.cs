using UnityEngine;

namespace SLC.Minigames.WordMemory
{
    public class WordMemoryManager : MonoSingleton<SLC.Minigames.WordMemory.WordMemoryManager>
    {
        // Fields
        private const string MINIGAME_NAME = "WordQUiz";
        private SLC.Minigames.WordMemory.WordMemoryUIController uiController;
        private SLC.Minigames.WordMemory.WordMemoryParser wordMemoryParser;
        private string usedCategoriesKey;
        private System.Collections.Generic.List<string> usedCategories;
        private bool <inMinigameFramework>k__BackingField;
        private int _playerLevel;
        private int maxLives;
        private int lives;
        private int pairs;
        private string[] levelWords;
        private System.Collections.Generic.List<string> categories;
        private int card1;
        private int card2;
        private int cardsRemaining;
        private bool canPlay;
        private bool <Locked>k__BackingField;
        
        // Properties
        public bool inMinigameFramework { get; set; }
        public bool Locked { get; set; }
        
        // Methods
        public bool get_inMinigameFramework()
        {
            return (bool)this.<inMinigameFramework>k__BackingField;
        }
        private void set_inMinigameFramework(bool value)
        {
            this.<inMinigameFramework>k__BackingField = value;
        }
        public bool get_Locked()
        {
            return (bool)this.<Locked>k__BackingField;
        }
        public void set_Locked(bool value)
        {
            this.<Locked>k__BackingField = value;
        }
        public bool CanPlay()
        {
            if((this.<Locked>k__BackingField) == true)
            {
                    return false;
            }
            
            if(this.canPlay == true)
            {
                    this.canPlay = 1;
            }
            
            return true;
        }
        public override void InitMonoSingleton()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6;
            this.wordMemoryParser = new SLC.Minigames.WordMemory.WordMemoryParser();
            if((UnityEngine.PlayerPrefs.HasKey(key:  this.usedCategoriesKey)) != false)
            {
                    string val_3 = UnityEngine.PlayerPrefs.GetString(key:  this.usedCategoriesKey);
                object val_4 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  this.usedCategoriesKey);
                val_6 = this.usedCategoriesKey;
            }
            else
            {
                    val_6 = null;
                val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            }
            
            this.usedCategories = val_6;
        }
        private void Start()
        {
            var val_13;
            var val_14;
            var val_15;
            val_13 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) != 0)
            {
                goto label_5;
            }
            
            val_14 = "WordMemory: No Minigame Manager";
            goto label_8;
            label_5:
            if((this.<inMinigameFramework>k__BackingField) == false)
            {
                goto label_29;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = CurrentMinigameId;
            if((Equals(value:  935319456)) == false)
            {
                goto label_14;
            }
            
            if((this.<inMinigameFramework>k__BackingField) == false)
            {
                goto label_29;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this._playerLevel = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_8 = new System.Action(object:  935345840, method:  new IntPtr(935319552));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
            val_15 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_15 != 0)
            {
                    if(val_15 == null)
            {
                goto label_22;
            }
            
            }
            
            val_15 = 0;
            label_22:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_15;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_11 = new System.Action(object:  935345840, method:  new IntPtr(935320576));
            System.Delegate val_12 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, b:  7454720);
            val_13 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
            if(val_13 != 0)
            {
                    if(val_13 == null)
            {
                goto label_26;
            }
            
            }
            
            val_13 = 0;
            label_26:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_13;
            UnityEngine.Debug.LogError(message:  935321600);
            goto label_29;
            label_14:
            val_14 = "WordMemory: Minigame Mismatch";
            label_8:
            UnityEngine.Debug.LogError(message:  935321712, context:  935345840);
            this.<inMinigameFramework>k__BackingField = false;
            label_29:
            this.StartGame();
        }
        private void StartGame()
        {
            int val_3;
            if((this.<inMinigameFramework>k__BackingField) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                this._playerLevel = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
            }
            else
            {
                    val_3 = this._playerLevel;
            }
            
            this.GenerateLevelData(level:  val_3);
            int val_2 = this.pairs << 1;
            this.<Locked>k__BackingField = true;
            this.card1 = 0;
            this.card2 = 0;
            this.cardsRemaining = val_2;
            this.uiController.LoadLevel(maxLives:  val_2, lives:  this.maxLives, pairs:  this.pairs, words:  this.levelWords);
            this.canPlay = true;
        }
        private void GenerateLevelData(int level)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            System.String[] val_16;
            SLC.Minigames.WordMemory.WordMemoryLevel val_1 = this.wordMemoryParser.GetWordMemoryLevelData(level:  level);
            if(this.wordMemoryParser != 0)
            {
                    this.maxLives = this.wordMemoryParser.levelDataSource;
                this.lives = this.wordMemoryParser.levelDataSource;
            }
            else
            {
                    this.maxLives = 0;
                this.lives = 0;
            }
            
            this.pairs = 0;
            Dictionary.KeyCollection<TKey, TValue> val_2 = this.wordMemoryParser.wordDataSource.Keys;
            System.Collections.Generic.List<ZooTile> val_3 = new System.Collections.Generic.List<ZooTile>(collection:  this.wordMemoryParser.wordDataSource);
            this.categories = null;
            System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Except<System.Object>(first:  80883712, second:  this.usedCategories);
            System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<System.Object>(source:  80883712);
            if(null != 0)
            {
                    val_12 = null;
                val_13 = UnityEngine.Random.Range(min:  0, max:  1094062064);
            }
            else
            {
                    val_12 = 12;
                val_13 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(val_12 <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.String[] val_8 = this.wordMemoryParser.wordDataSource.Item[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_7) << 2) + 16];
            this.Shuffle<System.String>(data:  this.wordMemoryParser.wordDataSource);
            if(this.pairs > this)
            {
                    string val_9 = 935691248 + 13152256 + 935691376;
                UnityEngine.Debug.LogError(message:  935691248);
                return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.String[]> val_10 = this.wordMemoryParser.wordDataSource + 16;
            val_14 = 1152921505084556512;
            val_15 = 0;
            int val_15 = this.pairs;
            val_15 = val_15 << 1;
            this.levelWords = null;
            val_16 = null;
            var val_16 = 0;
            val_14 = 0;
            typeof(System.String[]).__il2cppRuntimeField_10 = ;
            var val_11 = val_16 + 1;
            var val_13 = 4 - 3;
            val_16 = val_16 + 2;
            this.levelWords[val_16] = typeof(System.String[]).__il2cppRuntimeField_10;
            val_15 = 4 + 1;
            val_16 = this.levelWords;
            this.Shuffle<System.String>(data:  val_16);
            this.usedCategories.Add(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_7) << 2) + 16);
            goto label_35;
            label_38:
            this.usedCategories.RemoveAt(index:  0);
            label_35:
            if(this.usedCategories > 50)
            {
                goto label_38;
            }
            
            string val_14 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.usedCategories);
            UnityEngine.PlayerPrefs.SetString(key:  this.usedCategoriesKey, value:  this.usedCategories);
        }
        public void Shuffle<T>(T[] data)
        {
            var val_2;
            val_2 = 0;
            goto label_0;
            label_6:
            mem2[0] = data[UnityEngine.Random.Range(min:  0, max:  0)];
            val_2 = 1;
            mem2[0] = null;
            label_0:
            if(val_2 < 0)
            {
                goto label_6;
            }
        
        }
        private void OnRestartFromCheckpoint()
        {
        
        }
        private void HandleContinue()
        {
        
        }
        public void HandleFailed()
        {
            if((this.<inMinigameFramework>k__BackingField) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                bool val_2 = HandleLevelFailed();
                return;
            }
            
            this.StartGame();
        }
        private void Update()
        {
        
        }
        public void FaceUpCard(int index)
        {
            int val_7;
            int val_8;
            if(this.card1 <= 1)
            {
                goto label_1;
            }
            
            this.<Locked>k__BackingField = true;
            this.card2 = index;
            if((System.String.op_Equality(a:  this.levelWords[this.card1], b:  this.levelWords[this.card2])) == false)
            {
                goto label_6;
            }
            
            val_7 = this.card1;
            val_8 = this.card2;
            System.Collections.IEnumerator val_2 = this.uiController.DelayHidePair(card1:  val_7, card2:  val_8);
            UnityEngine.Coroutine val_3 = this.uiController.StartCoroutine(routine:  this.uiController);
            int val_8 = this.cardsRemaining;
            val_8 = val_8 - 2;
            this.cardsRemaining = val_8;
            if(val_8 > 0)
            {
                goto label_15;
            }
            
            UnityEngine.Debug.Log(message:  936773072);
            this.canPlay = false;
            goto label_15;
            label_1:
            this.card1 = index;
            return;
            label_6:
            val_7 = this.uiController;
            val_8 = this.lives - 1;
            this.lives = val_8;
            val_7.SetLives(lives:  val_8, maxLives:  this.maxLives);
            if(this.lives > 0)
            {
                    val_7 = this.card1;
                val_8 = this.card2;
                System.Collections.IEnumerator val_4 = this.uiController.DelayFaceDownPair(card1:  val_7, card2:  val_8);
                UnityEngine.Coroutine val_5 = this.uiController.StartCoroutine(routine:  this.uiController);
            }
            else
            {
                    this.HandleFailed();
            }
            
            label_15:
            this.card1 = 0;
            this.card2 = 0;
        }
        public WordMemoryManager()
        {
            this.usedCategoriesKey = "word_memory_category_key";
            this.card1 = 0;
            this.card2 = 0;
        }
    
    }

}
