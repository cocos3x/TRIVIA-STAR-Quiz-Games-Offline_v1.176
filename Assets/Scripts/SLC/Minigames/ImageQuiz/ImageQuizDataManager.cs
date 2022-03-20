using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizDataManager : MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>
    {
        // Fields
        private const string IMAGE_CDN_URL = "https://cdn.12gigs.com/mg/iq/";
        private const int INITIAL_LEVELS_TO_BATCH_LOAD = 2;
        private const int MINIMUM_IMAGE_COUNT_IN_CACHE = 5;
        private const int MAX_PER_IMAGE_DOWNLOAD_RETRIES = 1;
        private const int MAX_IMAGE_FAIL_ATTEMPTS_BEFORE_ABORT = 3;
        private System.Collections.Generic.List<SLC.Minigames.ImageQuiz.QuizLevelData> rawLevelDatas;
        private System.Collections.Generic.Queue<SLC.Minigames.ImageQuiz.ImageQuizLevelInfo> stageQuizLevels;
        private SLC.Minigames.ImageQuiz.QuizUserData userImageQuiz;
        private SLC.Minigames.ImageQuiz.DataLoaderState <DataLoaderState>k__BackingField;
        private bool isInitialized;
        private System.Collections.Generic.List<int> levelsLoadedButUnconsumed;
        private System.Collections.IEnumerator loadingCoroutine;
        public System.Action OnDataBegin;
        public System.Action<bool> OnDataLoaded;
        
        // Properties
        private static string LocalImageStoragePath { get; }
        public System.Collections.Generic.Queue<SLC.Minigames.ImageQuiz.ImageQuizLevelInfo> QuizLevels { get; }
        public SLC.Minigames.ImageQuiz.DataLoaderState DataLoaderState { get; set; }
        
        // Methods
        private static string get_LocalImageStoragePath()
        {
            string val_1 = UnityEngine.Application.temporaryCachePath;
            return null + 1051505216;
        }
        public System.Collections.Generic.Queue<SLC.Minigames.ImageQuiz.ImageQuizLevelInfo> get_QuizLevels()
        {
        
        }
        public SLC.Minigames.ImageQuiz.DataLoaderState get_DataLoaderState()
        {
        
        }
        private void set_DataLoaderState(SLC.Minigames.ImageQuiz.DataLoaderState value)
        {
            this.<DataLoaderState>k__BackingField = value;
        }
        public void Init()
        {
            if(this.isInitialized == true)
            {
                    return;
            }
            
            object val_1 = new System.Object();
            Init();
            R4.LoadUserData();
            mem2[0] = 1;
        }
        public void SaveUserData()
        {
            T[] val_1 = this.userImageQuiz.usedLevels.ToArray();
            bool val_2 = PlayerPrefsX.SetIntArray(key:  1052098080, intArray:  this.userImageQuiz.usedLevels);
            bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
        }
        private void LoadUserData()
        {
            System.Int32[] val_1 = PlayerPrefsX.GetIntArray(key:  1052098080);
            this.userImageQuiz.usedLevels.AddRange(collection:  1052098080);
        }
        public void StopLoading()
        {
            if(this.loadingCoroutine != 0)
            {
                    this.StopCoroutine(routine:  this.loadingCoroutine);
                this.loadingCoroutine = 0;
            }
            
            this.<DataLoaderState>k__BackingField = 0;
        }
        public void LoadQuizLevels()
        {
            var val_6;
            if((this.<DataLoaderState>k__BackingField) == 1)
            {
                    return;
            }
            
            this.Init();
            this.<DataLoaderState>k__BackingField = 1;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = UnityEngine.Mathf.Max(a:  1, b:  5 - this.stageQuizLevels);
            this.OnDataBegin.Invoke();
            System.Collections.IEnumerator val_4 = this.LoadQuizLevelsCoroutine(levelCount:  2);
            this.loadingCoroutine = this;
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  1052503248);
        }
        private System.Collections.IEnumerator LoadQuizLevelsCoroutine(int levelCount)
        {
            typeof(ImageQuizDataManager.<LoadQuizLevelsCoroutine>d__26).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(ImageQuizDataManager.<LoadQuizLevelsCoroutine>d__26).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(ImageQuizDataManager.<LoadQuizLevelsCoroutine>d__26).__il2cppRuntimeField_1C = levelCount;
        }
        public void AddLevel(SLC.Minigames.ImageQuiz.QuizLevelData level)
        {
            this.rawLevelDatas.Add(item:  level);
        }
        private SLC.Minigames.ImageQuiz.QuizUserData GetUserQuizData()
        {
        
        }
        private int FindLevelIndexOfWord(string word)
        {
            object val_1 = new System.Object();
            typeof(ImageQuizDataManager.<>c__DisplayClass29_0).__il2cppRuntimeField_8 = word;
            System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  455163904, method:  new IntPtr(1052973328));
            if(this.rawLevelDatas != 0)
            {
                    return this.rawLevelDatas.FindIndex(match:  8040448);
            }
            
            return this.rawLevelDatas.FindIndex(match:  8040448);
        }
        private SLC.Minigames.ImageQuiz.ImageQuizLevelInfo GenerateLevelInfo(string word, UnityEngine.Texture2D img)
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 8;
            if((public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_C) >= 76)
            {
                    val_4 = 12;
            }
            
            string val_3 = word.ToUpper();
            if(new System.Object() != 0)
            {
                    typeof(SLC.Minigames.ImageQuiz.ImageQuizLevelInfo).__il2cppRuntimeField_10 = img;
                typeof(SLC.Minigames.ImageQuiz.ImageQuizLevelInfo).__il2cppRuntimeField_8 = word;
            }
            else
            {
                    mem[8] = word;
                mem[16] = img;
            }
            
            typeof(SLC.Minigames.ImageQuiz.ImageQuizLevelInfo).__il2cppRuntimeField_C = val_4;
        }
        public void ConsumeCurrentLevel()
        {
            SLC.Minigames.ImageQuiz.ImageQuizLevelInfo val_1 = this.stageQuizLevels.Dequeue();
            typeof(System.String[]).__il2cppRuntimeField_10 = this.stageQuizLevels;
            this.MarkWordsAsConsumed(words:  477709520, saveData:  true);
            this.LoadQuizLevels();
        }
        public void ClearAllQuizLevels()
        {
            this.stageQuizLevels.Clear();
        }
        private void MarkWordsAsConsumed(string[] words, bool saveData = True)
        {
            var val_4;
            val_4 = 0;
            goto label_1;
            label_9:
            int val_1 = this.FindLevelIndexOfWord(word:  477709520);
            this.userImageQuiz.usedLevels.Add(item:  val_1);
            val_4 = 1;
            label_1:
            if(val_4 < (this.levelsLoadedButUnconsumed.Remove(item:  val_1)))
            {
                goto label_9;
            }
            
            if(saveData == false)
            {
                    return;
            }
            
            this.SaveUserData();
        }
        private void ResetLevelsPool(bool saveData = True)
        {
            this.userImageQuiz.usedLevels.Clear();
            if(saveData == false)
            {
                    return;
            }
            
            this.SaveUserData();
        }
        private SLC.Minigames.ImageQuiz.QuizLevelData[] GetUniqueLevelDatas(int amountOfLevels, System.Collections.Generic.List<int> filters)
        {
            var val_6;
            var val_7;
            if((0 + this.userImageQuiz.usedLevels) >= true)
            {
                    this.ResetLevelsPool(saveData:  true);
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_6 = 0;
            goto label_6;
            label_10:
            if((new System.Collections.Generic.List<System.Int32>()) <= val_6)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            Add(item:  (0 + 0) + 16);
            val_6 = 1;
            label_6:
            if(val_6 < null)
            {
                goto label_10;
            }
            
            if((filters != 0) && ((filters + 12) >= 1))
            {
                    var val_8 = 0;
                do
            {
                if((filters + 12) <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_7 = filters + 8;
                val_7 = val_7 + 0;
                Add(item:  (filters + 8 + 0) + 16);
                val_8 = val_8 + 1;
            }
            while(val_8 < (filters + 12));
            
            }
            
            val_7 = 0;
            System.Collections.Generic.List<System.Int32> val_5 = filters + 12.GetUniqueRandomValues(first:  0, last:  (filters + 12) - 1, excludedFilter:  80883712, amount:  amountOfLevels);
            goto label_17;
            label_23:
            if((filters + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = filters + 12 + 8;
            val_9 = val_9 + 0;
            if(val_9 <= ((filters + 12 + 8 + 0) + 16))
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (((filters + 12 + 8 + 0) + 16) << 2);
            Add(item:  (0 + ((filters + 12 + 8 + 0) + 16) << 2) + 16);
            val_7 = 1;
            label_17:
            if(val_7 < (filters + 12 + 12))
            {
                goto label_23;
            }
            
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        private System.Collections.Generic.List<int> GetUniqueRandomValues(int first, int last, System.Collections.Generic.List<int> excludedFilter, int amount)
        {
            int val_4;
            var val_5;
            int val_6;
            val_4 = first;
            RandomSet val_1 = null;
            val_5 = 0;
            val_1 = new RandomSet();
            val_6 = amount;
            addIntRange(lowest:  val_4, highest:  last);
            goto label_2;
            label_6:
            if(val_1 <= val_5)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            val_4 = mem[(0 + 0) + 16];
            val_4 = (0 + 0) + 16;
            use(item:  val_4);
            val_5 = 1;
            label_2:
            if(val_5 < val_1)
            {
                goto label_6;
            }
            
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            if(val_6 < 1)
            {
                    return;
            }
            
            do
            {
                val_4 = roll(unweighted:  false);
                Add(item:  val_4);
                val_6 = val_6 - 1;
            }
            while(null != 0);
        
        }
        public ImageQuizDataManager()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.rawLevelDatas = null;
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_2 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            this.stageQuizLevels = null;
            this.userImageQuiz = new SLC.Minigames.ImageQuiz.QuizUserData();
            System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
            this.levelsLoadedButUnconsumed = null;
        }
    
    }

}
