using UnityEngine;

namespace SLC.Minigames.TwistyArrow
{
    public class TwistyGameManager : MonoSingleton<SLC.Minigames.TwistyArrow.TwistyGameManager>
    {
        // Fields
        private const int ExpectedWordCount = 5;
        private UnityEngine.TextAsset word_level_list;
        public bool inMinigameFramework;
        public System.Action<bool> OnPlayingStateChanged;
        private const string MINIGAME_NAME = "TwistyArrow";
        private const string usedLevelsKey = "twisty_arrow_used_levels";
        private bool _IsPlaying;
        private string[] levels;
        private int currentLevel;
        private const int MaxHearts = 3;
        private int _Hearts;
        private System.Collections.Generic.List<int> usedLevels;
        private int _livesUsed;
        private int consecutiveFailures;
        
        // Properties
        public int Hearts { get; }
        public bool IsPlaying { get; set; }
        public float LevelRotation { get; }
        public float AdjustedRotation { get; }
        public string[] Levels { get; }
        public string[] LevelWords { get; }
        public string LevelWordsString { get; }
        public System.Collections.Generic.List<int> UsedLevels { get; }
        public string UsedLevelsString { get; }
        public bool IsCurrentLevelUsed { get; }
        
        // Methods
        public int get_Hearts()
        {
            return (int)this._Hearts;
        }
        public bool get_IsPlaying()
        {
            return (bool)this._IsPlaying;
        }
        public void set_IsPlaying(bool value)
        {
            if(this._IsPlaying == true)
            {
                    this._IsPlaying = 1;
            }
            
            if((1 ^ value == true) && (this.OnPlayingStateChanged != 0))
            {
                    this.OnPlayingStateChanged.Invoke(obj:  value);
            }
            
            this._IsPlaying = value;
        }
        public float get_LevelRotation()
        {
            float val_2;
            if(this.inMinigameFramework != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_2 = (float)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
            }
            else
            {
                    val_2 = 0f;
            }
            
            float val_2 = 8f;
            val_2 = 1065297029 * val_2;
            return (float)val_2;
        }
        public float get_AdjustedRotation()
        {
            float val_1 = this.LevelRotation;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            var val_3 = public static SLC.Minigames.TwistyArrow.TwistyArrowLogic MonoSingleton<SLC.Minigames.TwistyArrow.TwistyArrowLogic>::get_Instance().__il2cppRuntimeField_C + 24;
            val_3 = 1013987088 / val_3;
            return (float)val_3;
        }
        public string[] get_Levels()
        {
            if(R1 != 0)
            {
                    return;
            }
            
            string val_1 = this.word_level_list.text;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 13;
            typeof(System.Char[]).__il2cppRuntimeField_12 = 10;
            System.String[] val_2 = this.word_level_list.Split(separator:  478563824, options:  1);
            this.levels = this.word_level_list;
        }
        public string[] get_LevelWords()
        {
            System.String[] val_1 = this.Levels;
            if(this == 0)
            {
                    return;
            }
            
            System.String[] val_2 = this.Levels;
            if(this.word_level_list != 0)
            {
                    this.word_level_list = this.currentLevel;
            }
            
            if(this.word_level_list == 1)
            {
                    return;
            }
            
            System.String[] val_3 = this.Levels;
            SLC.Minigames.TwistyArrow.TwistyGameManager val_4 = this + (this.currentLevel << 2);
            typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
            if(((this + (this.currentLevel) << 2).inMinigameFramework) == true)
            {
                    return (this + (this.currentLevel) << 2).inMinigameFramework.Split(separator:  478563824);
            }
            
            return (this + (this.currentLevel) << 2).inMinigameFramework.Split(separator:  478563824);
        }
        public string get_LevelWordsString()
        {
            var val_12;
            System.String[] val_1 = this.LevelWords;
            if(this.word_level_list <= 4)
            {
                    return;
            }
            
            System.Text.StringBuilder val_2 = new System.Text.StringBuilder();
            System.String[] val_3 = this.LevelWords;
            if(val_2 != 0)
            {
                    System.Text.StringBuilder val_4 = AppendFormat(format:  1014405584, arg0:  this.inMinigameFramework);
            }
            else
            {
                    System.Text.StringBuilder val_5 = AppendFormat(format:  1014405584, arg0:  this.inMinigameFramework);
            }
            
            System.Text.StringBuilder val_6 = Append(value:  1370307136);
            val_12 = 5;
            goto label_7;
            label_13:
            System.String[] val_7 = this.LevelWords;
            if(val_2 != 0)
            {
                    System.Text.StringBuilder val_8 = AppendFormat(format:  1014405728, arg0:  this.OnPlayingStateChanged);
            }
            else
            {
                    System.Text.StringBuilder val_9 = AppendFormat(format:  1014405728, arg0:  this.OnPlayingStateChanged);
            }
            
            System.Text.StringBuilder val_10 = Append(value:  1370307136);
            val_12 = 6;
            label_7:
            System.String[] val_11 = this.LevelWords;
            if((val_12 - 4) < this.word_level_list)
            {
                goto label_13;
            }
            
            if(val_2 == 0)
            {
                
            }
        
        }
        public System.Collections.Generic.List<int> get_UsedLevels()
        {
            System.Collections.Generic.List<System.Int32> val_5 = this.usedLevels;
            if(val_5 != 0)
            {
                    return;
            }
            
            if((UnityEngine.PlayerPrefs.HasKey(key:  1014554736)) != false)
            {
                    string val_2 = UnityEngine.PlayerPrefs.GetString(key:  1014554736);
                object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  1014554736);
                val_5 = "twisty_arrow_used_levels";
                this.usedLevels = "twisty_arrow_used_levels";
                return;
            }
            
            val_5 = null;
            val_5 = new System.Collections.Generic.List<System.Int32>();
            this.usedLevels = val_5;
        }
        public string get_UsedLevelsString()
        {
            var val_7;
            System.Text.StringBuilder val_1 = null;
            val_7 = 0;
            val_1 = new System.Text.StringBuilder();
            goto label_1;
            label_7:
            System.Collections.Generic.List<System.Int32> val_2 = this.UsedLevels;
            if(this.word_level_list <= val_7)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 0;
            if(val_1 != 0)
            {
                    System.Text.StringBuilder val_3 = Append(value:  (0 + 0) + 16);
            }
            else
            {
                    System.Text.StringBuilder val_4 = Append(value:  (0 + 0) + 16);
            }
            
            System.Text.StringBuilder val_5 = Append(value:  1492657312);
            val_7 = 1;
            label_1:
            System.Collections.Generic.List<System.Int32> val_6 = this.UsedLevels;
            if(val_7 < this.word_level_list)
            {
                goto label_7;
            }
            
            if(val_1 == 0)
            {
                
            }
        
        }
        public bool get_IsCurrentLevelUsed()
        {
            System.Collections.Generic.List<System.Int32> val_1 = this.UsedLevels;
            System.Func<System.Int32, System.Boolean> val_2 = new System.Func<System.Int32, System.Boolean>(object:  1014824368, method:  new IntPtr(1014799344));
            System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Int32>(source:  1014824368, predicate:  7720960);
            if((System.Linq.Enumerable.Count<System.Int32>(source:  1014824368)) > 1)
            {
                    0 = 1;
            }
            
            return true;
        }
        private void Start()
        {
            bool val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            this.inMinigameFramework = true;
            val_21 = 1152921504901095424;
            val_22 = 1152921511451483792;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) != 0)
            {
                goto label_5;
            }
            
            UnityEngine.Debug.LogError(message:  1014912368, context:  1014940848);
            this.inMinigameFramework = false;
            goto label_34;
            label_5:
            if(this.inMinigameFramework == false)
            {
                goto label_34;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = CurrentMinigameId;
            if((Equals(value:  907413952)) == false)
            {
                goto label_14;
            }
            
            if(this.inMinigameFramework == false)
            {
                goto label_34;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_7 = new System.Action(object:  1014940848, method:  new IntPtr(1014912512));
            System.Delegate val_8 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, b:  7454720);
            val_23 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
            if(val_23 != 0)
            {
                    if(val_23 == null)
            {
                goto label_21;
            }
            
            }
            
            val_23 = 0;
            label_21:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_23;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_10 = new System.Action(object:  1014940848, method:  new IntPtr(1014913536));
            System.Delegate val_11 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
            val_24 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_24 != 0)
            {
                    if(val_24 == null)
            {
                goto label_25;
            }
            
            }
            
            val_24 = 0;
            label_25:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_24;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_13 = new System.Action(object:  1014940848, method:  new IntPtr(1014914560));
            System.Delegate val_14 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C, b:  7454720);
            val_25 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C;
            if(val_25 != 0)
            {
                    if(val_25 == null)
            {
                goto label_29;
            }
            
            }
            
            val_25 = 0;
            label_29:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C = val_25;
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_22 = 1152921504614248448;
            System.Action<twelvegigs.storage.JsonDictionary> val_16 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1014940848, method:  new IntPtr(1014915584));
            System.Delegate val_17 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74, b:  7401472);
            val_21 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74;
            if(val_21 != 0)
            {
                    if(val_21 == null)
            {
                goto label_33;
            }
            
            }
            
            val_21 = 0;
            label_33:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74 = val_21;
            goto label_34;
            label_14:
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_19 = CurrentMinigameId;
            val_21 = false;
            string val_20 = -1745297776(-1745297776) + 1014916608;
            UnityEngine.Debug.LogError(message:  -1745297776);
            UnityEngine.Debug.LogError(message:  1014916720, context:  1014940848);
            this.inMinigameFramework = val_21;
            label_34:
            this._Hearts = 3;
            this.StartNewLevel();
        }
        private void Instance_OnInjectTracking(System.Collections.Generic.Dictionary<string, object> obj)
        {
            obj.Add(key:  -487709536, value:  13152256);
        }
        public void StartNewLevel()
        {
            System.Func<System.Boolean>[] val_24;
            int val_25;
            var val_26;
            var val_27;
            float val_29;
            System.Func<System.Boolean> val_30;
            float val_31;
            var val_32;
            var val_33;
            var val_34;
            if(this.consecutiveFailures >= 4)
            {
                goto label_1;
            }
            
            int val_1 = this.GetRandomLevel();
            this.currentLevel = val_1;
            if(val_1 == 1)
            {
                goto label_5;
            }
            
            System.String[] val_2 = this.LevelWords;
            if(this == 0)
            {
                goto label_5;
            }
            
            System.String[] val_3 = this.LevelWords;
            if(this.word_level_list != 5)
            {
                goto label_5;
            }
            
            this.consecutiveFailures = 0;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUI();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.String[] val_6 = this.LevelWords;
            Setup(words:  1015195200, secondsPerRotation:  this.LevelRotation);
            val_24 = 1152921514208635376;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_25 = this._Hearts;
            UpdateUIHearts(currentHearts:  val_25);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SetActiveInfoText(active:  true);
            this.IsPlaying = true;
            return;
            label_1:
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_26 = public static SLC.Minigames.MinigamesUIController MonoSingleton<SLC.Minigames.MinigamesUIController>::get_Instance();
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            val_25 = null;
            typeof(System.String[]).__il2cppRuntimeField_10 = "HOME";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_24 = null;
            val_27 = null;
            val_27 = null;
            val_29 = "ERROR";
            val_30 = TwistyGameManager.<>c.<>9__37_0;
            val_31 = "Failed to load new level.";
            if(val_30 == 0)
            {
                    val_30 = null;
                val_30 = new System.Func<System.Boolean>(object:  TwistyGameManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1015153264));
                val_26 = val_26;
                TwistyGameManager.<>c.<>9__37_0 = val_30;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_30;
            0.ShowMessage(titleTxt:  -1598955408, messageTxt:  1015153136, shownButtons:  1054454320, buttonTexts:  val_25, showClose:  false, buttonCallbacks:  val_24);
            return;
            label_5:
            val_32 = 0;
            val_26 = 44;
            val_33 = "";
            val_29 = " : ";
            val_31 = "\n";
            goto label_39;
            label_66:
            System.String[] val_12 = this.Levels;
            typeof(System.Char[]).__il2cppRuntimeField_10 = val_26;
            System.String[] val_13 = SLC.Minigames.TwistyArrow.TwistyGameManager.__il2cppRuntimeField_byval_arg.Split(separator:  478563824);
            typeof(System.String[]).__il2cppRuntimeField_10 = val_33;
            string val_14 = 0.ToString();
            typeof(System.String[]).__il2cppRuntimeField_14 = ;
            typeof(System.String[]).__il2cppRuntimeField_18 = " : ";
            System.String[] val_15 = this.Levels;
            typeof(System.String[]).__il2cppRuntimeField_1C = SLC.Minigames.TwistyArrow.TwistyGameManager.__il2cppRuntimeField_byval_arg;
            typeof(System.String[]).__il2cppRuntimeField_20 = "\n";
            string val_16 = +477709520;
            val_33 = null;
            val_32 = 0 + 1;
            label_39:
            System.String[] val_17 = this.Levels;
            if(val_32 < this.word_level_list)
            {
                goto label_66;
            }
            
            System.String[] val_18 = this.LevelWords;
            val_24 = this;
            string val_19 = this.currentLevel.ToString();
            val_25 = this.currentLevel;
            if(val_24 != 0)
            {
                    System.String[] val_20 = this.LevelWords;
                val_24 = 0;
                string val_21 = this.word_level_list.ToString();
                val_34 = "TwistyGameManager.StartNewLevel() error: currentLevel:{0}, LevelWords.Length:{1}, BrokenLevels:\n{2}";
                string val_22 = System.String.Format(format:  1015170672, arg0:  val_25, arg1:  1015183156, arg2:  477709520);
            }
            else
            {
                    val_34 = "TwistyGameManager.StartNewLevel() error: currentLevel:{0}, LevelWords:null, BrokenLevels:\n{1}";
                string val_23 = System.String.Format(format:  1015170944, arg0:  val_25, arg1:  477709520);
            }
            
            UnityEngine.Debug.LogError(message:  1015170944);
            int val_24 = this.consecutiveFailures;
            this.levels = 0;
            val_24 = val_24 + 1;
            this.consecutiveFailures = val_24;
        }
        public void RestartNewLevelFreshLives()
        {
            this._Hearts = 3;
            this._livesUsed = 0;
            this.StartNewLevel();
        }
        public void StartNewLevelFreshLives()
        {
            this._Hearts = 3;
            this.StartNewLevel();
        }
        public void InvokedNewLevel()
        {
            this.StartNewLevel();
        }
        public void HandleLevelComplete()
        {
            if(this.inMinigameFramework != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if(HandleLevelComplete() != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UpdateUI();
            }
            else
            {
                    this.Invoke(methodName:  1015639680, time:  null);
            }
            
            }
            
            this.IsPlaying = false;
        }
        public void HandleFailure()
        {
            this.IsPlaying = false;
            int val_4 = this._Hearts;
            int val_5 = this._livesUsed;
            val_4 = val_4 - 1;
            val_5 = val_5 + 1;
            this._livesUsed = val_5;
            this._Hearts = val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUIHearts(currentHearts:  this._Hearts);
            if(this._Hearts > 0)
            {
                    this.Invoke(methodName:  1015639680, time:  null);
                return;
            }
            
            System.Collections.IEnumerator val_2 = this.DelayShowLevelFailed();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  1015775792);
        }
        public void HandleSoftFailure()
        {
            int val_4 = this._Hearts;
            int val_5 = this._livesUsed;
            val_4 = val_4 - 1;
            val_5 = val_5 + 1;
            this._livesUsed = val_5;
            this._Hearts = val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUIHearts(currentHearts:  this._Hearts);
            if(this._Hearts > 0)
            {
                    return;
            }
            
            R4.IsPlaying = false;
            System.Collections.IEnumerator val_2 = R4.DelayShowLevelFailed();
            UnityEngine.Coroutine val_3 = R4.StartCoroutine(routine:  R4);
        }
        public string CurrentLevelInfo()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -848113392)) == false)
            {
                    return;
            }
            
            string val_4 = this.LevelWordsString;
            System.Text.StringBuilder val_5 = AppendFormat(format:  1015975792, arg0:  13152256, arg1:  1016001088);
            string val_7 = this.IsCurrentLevelUsed.ToString();
            System.Text.StringBuilder val_8 = AppendFormat(format:  1015976000, arg0:  1015989055);
            float val_9 = this.LevelRotation;
            string val_10 = this.ToString(format:  1015976224);
            System.Text.StringBuilder val_11 = AppendFormat(format:  1015976304, arg0:  1015989048);
            float val_12 = this.AdjustedRotation;
            string val_13 = this.ToString(format:  1015976224);
            System.Text.StringBuilder val_14 = AppendFormat(format:  1015976528, arg0:  1015989048);
            string val_15 = this.UsedLevelsString;
            if(new System.Text.StringBuilder() != 0)
            {
                    System.Text.StringBuilder val_16 = AppendFormat(format:  1015976768, arg0:  1016001088);
                return;
            }
            
            System.Text.StringBuilder val_17 = AppendFormat(format:  1015976768, arg0:  1016001088);
        }
        private System.Collections.IEnumerator DelayShowLevelFailed()
        {
            object val_1 = new System.Object();
            typeof(TwistyGameManager.<DelayShowLevelFailed>d__45).__il2cppRuntimeField_8 = 0;
            typeof(TwistyGameManager.<DelayShowLevelFailed>d__45).__il2cppRuntimeField_10 = this;
        }
        private int GetRandomLevel()
        {
            var val_11;
            var val_12;
            System.Collections.Generic.List<System.Int32> val_13;
            System.String[] val_1 = this.Levels;
            System.Collections.Generic.IEnumerable<System.Int32> val_3 = System.Linq.Enumerable.Range(start:  1, count:  this.word_level_list - 1);
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Int32>(source:  1);
            System.Collections.Generic.List<System.Int32> val_5 = this.UsedLevels;
            System.Collections.Generic.IEnumerable<TSource> val_6 = System.Linq.Enumerable.Except<System.Int32>(first:  1, second:  1016241472);
            System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<System.Int32>(source:  1);
            if(1 != 0)
            {
                    val_11 = 1;
                val_12 = UnityEngine.Random.Range(min:  0, max:  50331648);
            }
            else
            {
                    val_11 = 12;
                val_12 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(val_11 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_11 = 0;
            val_11 = val_11 + (val_12 << 2);
            this.usedLevels.Add(item:  (0 + (val_9) << 2) + 16);
            goto label_6;
            label_9:
            1.RemoveAt(index:  0);
            label_6:
            val_13 = this.usedLevels;
            if(this.usedLevels == 0)
            {
                    val_13 = this.usedLevels;
            }
            
            if(1 > 100)
            {
                goto label_9;
            }
            
            string val_10 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  val_13);
            UnityEngine.PlayerPrefs.SetString(key:  1014554736, value:  val_13);
            return (int)(0 + (val_9) << 2) + 16;
        }
        public TwistyGameManager()
        {
            this.currentLevel = 0;
        }
        private bool <get_IsCurrentLevelUsed>b__24_0(int x)
        {
            return (bool)x.Equals(obj:  this.currentLevel);
        }
    
    }

}
