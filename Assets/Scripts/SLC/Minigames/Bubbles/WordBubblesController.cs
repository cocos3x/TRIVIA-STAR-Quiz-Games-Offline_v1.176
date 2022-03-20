using UnityEngine;

namespace SLC.Minigames.Bubbles
{
    public class WordBubblesController : MonoSingleton<SLC.Minigames.Bubbles.WordBubblesController>
    {
        // Fields
        private System.Collections.Generic.List<SLC.Minigames.Bubbles.WordBubblesCategory> categoryWords;
        private System.Collections.Generic.List<SLC.Minigames.Bubbles.WordBubblesLevelData> levelDatas;
        private System.Collections.Generic.Queue<SLC.Minigames.Bubbles.WordBubblesCategory> playedLevel;
        private int <CurrentLevelIndex>k__BackingField;
        private SLC.Minigames.Bubbles.WordBubblesLevel <CurrentLevel>k__BackingField;
        private bool initialized;
        private bool <toturalLevel>k__BackingField;
        public bool IsGameOver;
        public bool IsLevelFinish;
        private float <totalTime>k__BackingField;
        private float timer;
        private int remainLives;
        private int <FirstLevelCurrentIndex>k__BackingField;
        
        // Properties
        public int CurrentLevelIndex { get; set; }
        public SLC.Minigames.Bubbles.WordBubblesLevel CurrentLevel { get; set; }
        public bool toturalLevel { get; set; }
        private float totalTime { get; set; }
        public int FirstLevelCurrentIndex { get; set; }
        
        // Methods
        public int get_CurrentLevelIndex()
        {
            return (int)this.<CurrentLevelIndex>k__BackingField;
        }
        private void set_CurrentLevelIndex(int value)
        {
            this.<CurrentLevelIndex>k__BackingField = value;
        }
        public SLC.Minigames.Bubbles.WordBubblesLevel get_CurrentLevel()
        {
        
        }
        private void set_CurrentLevel(SLC.Minigames.Bubbles.WordBubblesLevel value)
        {
            this.<CurrentLevel>k__BackingField = value;
        }
        public bool get_toturalLevel()
        {
            return (bool)this.<toturalLevel>k__BackingField;
        }
        private void set_toturalLevel(bool value)
        {
            this.<toturalLevel>k__BackingField = value;
        }
        private float get_totalTime()
        {
            return (float)S0;
        }
        private void set_totalTime(float value)
        {
            this.<totalTime>k__BackingField = ;
        }
        public int get_FirstLevelCurrentIndex()
        {
            return (int)this.<FirstLevelCurrentIndex>k__BackingField;
        }
        private void set_FirstLevelCurrentIndex(int value)
        {
            this.<FirstLevelCurrentIndex>k__BackingField = value;
        }
        private void Update()
        {
            if(this.IsGameOver == false)
            {
                    this.IsGameOver = this.IsLevelFinish;
                goto label_1;
            }
            
            return;
            label_1:
            float val_1 = UnityEngine.Time.deltaTime;
            uint val_4 = 0;
            val_4 = this.timer - val_4;
            this.timer = val_4;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_5 = this.<totalTime>k__BackingField;
            val_5 = 1f - (this.timer / val_5);
            this.GameOver();
        }
        private void Initialize()
        {
            if(this.initialized != false)
            {
                    return;
            }
            
            this.LoadCategoryData();
            this.LoadLevelData();
            this.<toturalLevel>k__BackingField = true;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = new System.Action(object:  972996736, method:  new IntPtr(972971712));
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = new System.Action(object:  972996736, method:  new IntPtr(972971712));
            this.StartLevel();
            this.initialized = true;
            UnityEngine.Debug.LogError(message:  942617392);
        }
        private void StartLevel()
        {
            if((this.<toturalLevel>k__BackingField) != false)
            {
                    if((this.<toturalLevel>k__BackingField) <= (this.<CurrentLevelIndex>k__BackingField))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_1 = R1 + ((this.<CurrentLevelIndex>k__BackingField) << 2);
                typeof(System.String[]).__il2cppRuntimeField_10 = "GREEN";
                typeof(System.String[]).__il2cppRuntimeField_14 = "BLUE";
                this.<FirstLevelCurrentIndex>k__BackingField = 0;
                this.<CurrentLevel>k__BackingField = new SLC.Minigames.Bubbles.WordBubblesLevel(levelData:  (R1 + (this.<CurrentLevelIndex>k__BackingField) << 2) + 16, words:  477709520);
            }
            else
            {
                    if((this.<toturalLevel>k__BackingField) >= true)
            {
                    SLC.Minigames.Bubbles.WordBubblesCategory val_3 = this.playedLevel.Dequeue();
            }
            
                do
            {
                int val_4 = UnityEngine.Random.Range(min:  0, max:  973097024);
                if(val_4 <= val_4)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_10 = val_10 + (val_4 << 2);
                SLC.Minigames.Bubbles.WordBubblesCategory val_12 = (0 + (val_4) << 2) + 16;
                bool val_5 = this.playedLevel.Contains(item:  val_12);
            }
            while(val_5 == true);
            
                if(val_5 <= (this.<CurrentLevelIndex>k__BackingField))
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_11 = val_11 + ((this.<CurrentLevelIndex>k__BackingField) << 2);
                if(val_11 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = val_12 + (val_4 << 2);
                SLC.Minigames.Bubbles.WordBubblesLevel val_6 = new SLC.Minigames.Bubbles.WordBubblesLevel(levelData:  (0 + (this.<CurrentLevelIndex>k__BackingField) << 2) + 16, category:  ((0 + (val_4) << 2) + 16 + (val_4) << 2) + 16);
                this.<CurrentLevel>k__BackingField = val_6;
                if(val_6 <= val_4)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_13 = val_13 + (val_4 << 2);
                this.playedLevel.Enqueue(item:  (0 + (val_4) << 2) + 16);
            }
            
            this.IsGameOver = false;
            this.IsLevelFinish = false;
            if(false <= (this.<CurrentLevelIndex>k__BackingField))
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + ((this.<CurrentLevelIndex>k__BackingField) << 2);
            this.<totalTime>k__BackingField = (0 + (this.<CurrentLevelIndex>k__BackingField) << 2) + 16 + 12;
            this.timer = (0 + (this.<CurrentLevelIndex>k__BackingField) << 2) + 16 + 12;
            this.<CurrentLevelIndex>k__BackingField = (this.<CurrentLevelIndex>k__BackingField) + 1;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StartLevel(currentLevel:  this.<CurrentLevel>k__BackingField);
            if((this.<toturalLevel>k__BackingField) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PointTo(bubbleIndex:  this.<FirstLevelCurrentIndex>k__BackingField);
        }
        private void LoadCategoryData()
        {
            var val_15;
            var val_16;
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  973298112);
            string val_2 = text;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            mem[1152921514170105916] = null;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
            System.String[] val_4 = Split(separator:  478563824);
            val_15 = "minigames/WordBubbles/WordGameCategoriesCategories";
            val_16 = 1;
            if( != 0)
            {
                    return;
            }
        
        }
        public void LoadLevelData()
        {
            System.Collections.Generic.List<SLC.Minigames.Bubbles.WordBubblesLevelData> val_11;
            var val_12;
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  973412336);
            string val_2 = text;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.levelDatas = null;
            val_11 = null;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
            System.String[] val_4 = Split(separator:  478563824);
            val_12 = 5;
            if(("minigames/WordBubbles/WordBubblesLevelData") != 0)
            {
                    return;
            }
        
        }
        public void CheckTotural()
        {
            if((this.<toturalLevel>k__BackingField) == false)
            {
                    return;
            }
            
            int val_2 = this.<FirstLevelCurrentIndex>k__BackingField;
            val_2 = val_2 + 1;
            this.<FirstLevelCurrentIndex>k__BackingField = val_2;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PointTo(bubbleIndex:  this.<FirstLevelCurrentIndex>k__BackingField);
        }
        public bool SubmitWords(string word)
        {
            bool val_2 = this.<CurrentLevel>k__BackingField.IsComplete();
            if(val_2 == true)
            {
                    val_2 = this;
                this.LevelComplete();
            }
            
            return (bool)this.<CurrentLevel>k__BackingField.IsQulify(word:  word);
        }
        private void LevelComplete()
        {
            if((this.<toturalLevel>k__BackingField) == true)
            {
                    this.<toturalLevel>k__BackingField = false;
                this.<toturalLevel>k__BackingField = this.<toturalLevel>k__BackingField;
            }
            
            this.IsLevelFinish = true;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LevelComplete(victory:  true);
            System.Collections.IEnumerator val_2 = this.LevelCompleteDelay(delay:  null, wincondition:  false);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  973807312);
        }
        private void GameOver()
        {
            this.IsGameOver = true;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LevelComplete(victory:  false);
            System.Collections.IEnumerator val_2 = this.LevelCompleteDelay(delay:  null, wincondition:  false);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  973919312);
        }
        private System.Collections.IEnumerator LevelCompleteDelay(float delay, bool wincondition)
        {
            typeof(WordBubblesController.<LevelCompleteDelay>d__37).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WordBubblesController.<LevelCompleteDelay>d__37).__il2cppRuntimeField_10 = wincondition;
                typeof(WordBubblesController.<LevelCompleteDelay>d__37).__il2cppRuntimeField_18 = this;
            }
            else
            {
                    mem[24] = this;
                mem[16] = wincondition;
            }
            
            typeof(WordBubblesController.<LevelCompleteDelay>d__37).__il2cppRuntimeField_14 = R2;
        }
        public override void InitMonoSingleton()
        {
            this.InitMonoSingleton();
            this.Initialize();
        }
        public WordBubblesController()
        {
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            this.remainLives = 2;
            this.playedLevel = null;
        }
    
    }

}
