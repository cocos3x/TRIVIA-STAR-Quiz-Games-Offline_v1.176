using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizMinigameManager : MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>
    {
        // Fields
        private const string MINIGAME_NAME = "ImageQuiz";
        private int <currentPlayerLevel>k__BackingField;
        private SLC.Minigames.ImageQuiz.GameState <MinigameState>k__BackingField;
        public System.Action OnMinigameBegin;
        public System.Action OnMinigameEnd;
        public System.Action OnLevelComplete;
        private int _continuesUsed;
        
        // Properties
        public int currentPlayerLevel { get; set; }
        public SLC.Minigames.ImageQuiz.GameState MinigameState { get; set; }
        
        // Methods
        public int get_currentPlayerLevel()
        {
            return (int)this.<currentPlayerLevel>k__BackingField;
        }
        private void set_currentPlayerLevel(int value)
        {
            this.<currentPlayerLevel>k__BackingField = value;
        }
        public SLC.Minigames.ImageQuiz.GameState get_MinigameState()
        {
        
        }
        private void set_MinigameState(SLC.Minigames.ImageQuiz.GameState value)
        {
            this.<MinigameState>k__BackingField = value;
        }
        private void Start()
        {
            var val_7;
            var val_8;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  1075243088, method:  new IntPtr(1075217040));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
            val_7 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_7 != 0)
            {
                    if(val_7 == null)
            {
                goto label_6;
            }
            
            }
            
            val_7 = 0;
            label_6:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_7;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1075243088, method:  new IntPtr(1075218064));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74, b:  7401472);
            val_8 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_10;
            }
            
            }
            
            val_8 = 0;
            label_10:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74 = val_8;
            this.StartNewGame();
        }
        private void Instance_OnInjectTracking(System.Collections.Generic.Dictionary<string, object> obj)
        {
            obj.Add(key:  927454704, value:  13152256);
        }
        private void OnDestroy()
        {
            var val_6;
            System.Action val_7;
            var val_8;
            val_6 = 1152921504901095424;
            val_7 = 1152921511451483792;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = null;
            val_7 = new System.Action(object:  1075475280, method:  new IntPtr(1075217040));
            System.Delegate val_5 = System.Delegate.Remove(source:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, value:  7454720);
            val_8 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_11;
            }
            
            }
            
            val_8 = 0;
            label_11:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_8;
        }
        private void StartNewGame()
        {
            this.InitializeNewGameAttributes();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StopCoroutine(routine:  public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_24);
            public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_24 = 0;
            public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_18 = 0;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LoadQuizLevels();
        }
        private void InitializeNewGameAttributes()
        {
            var val_9;
            var val_10;
            this.<MinigameState>k__BackingField = 0;
            this._continuesUsed = 0;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ClearAllQuizLevels();
            val_9 = 1152921504901095424;
            val_10 = 1152921511451483792;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_5 = CurrentMinigameId;
            if((System.String.Compare(strA:  -1745297776, strB:  907413760)) != 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            mem2[0] = R7 + 20 + 12;
        }
        public bool HasLevelData()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_10 + 20) > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool IsFTUX()
        {
            if((this.<currentPlayerLevel>k__BackingField) < 1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public void BeginGame()
        {
            this.<MinigameState>k__BackingField = 1;
            this.OnMinigameBegin.Invoke();
        }
        public SLC.Minigames.ImageQuiz.ImageQuizLevelInfo GetCurrentQuizLevel()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            return public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_10.Peek();
        }
        public UnityEngine.Texture2D GetCurrentQuizImage()
        {
            SLC.Minigames.ImageQuiz.ImageQuizLevelInfo val_1 = this.GetCurrentQuizLevel();
            if(this != 0)
            {
                    return;
            }
        
        }
        public void SubmitWord(string word)
        {
            bool val_4 = static_value_021FD402;
            if(val_4 != true)
            {
                    val_4 = true;
            }
            
            SLC.Minigames.ImageQuiz.ImageQuizLevelInfo val_1 = this.GetCurrentQuizLevel();
            if((System.String.op_Equality(a:  word, b:  null)) != false)
            {
                    int val_4 = this.<currentPlayerLevel>k__BackingField;
                val_4 = val_4 + 1;
                this.<currentPlayerLevel>k__BackingField = val_4;
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ConsumeCurrentLevel();
                if(this.OnLevelComplete != 0)
            {
                goto label_7;
            }
            
            }
            else
            {
                    int val_5 = this._continuesUsed;
                this.<MinigameState>k__BackingField = 2;
                val_5 = val_5 + 1;
                this._continuesUsed = val_5;
            }
            
            label_7:
            this.OnMinigameEnd.Invoke();
        }
        public ImageQuizMinigameManager()
        {
        
        }
    
    }

}
