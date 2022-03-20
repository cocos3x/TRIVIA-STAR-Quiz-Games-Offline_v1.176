using UnityEngine;

namespace SLC.Minigames.WordQuiz
{
    public class WordQuizManager : MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>
    {
        // Fields
        private SLC.Minigames.WordQuiz.WordQuizUIController wordQuizUIController;
        public SLC.Minigames.WordQuiz.WordQuizLevel currentLevel;
        public int answerProgress;
        public System.Collections.Generic.List<int> hintOrder;
        private bool isPaused;
        private readonly string[] vocabulary;
        private System.Collections.Generic.List<SLC.Minigames.WordQuiz.WordQuizLevel> allLevels;
        private RandomSet randomSet;
        private System.Collections.Generic.List<SLC.Minigames.WordQuiz.WordQuizLevel> removedLevels;
        private System.Collections.Generic.List<SLC.Minigames.WordQuiz.WordQuizLevel> trackedLevels;
        private bool hasAdded;
        private int _continuesUsed;
        
        // Properties
        public decimal hintCost { get; }
        public bool IsPaused { get; }
        
        // Methods
        public decimal get_hintCost()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) != 0)
            {
                    return new System.Decimal() {flags = -1745297728, hi = MonoSingleton<T>.__il2cppRuntimeField_cctor_finished};
            }
            
            return new System.Decimal() {flags = -1745297728, hi = MonoSingleton<T>.__il2cppRuntimeField_cctor_finished};
        }
        public bool get_IsPaused()
        {
            return (bool)this.isPaused;
        }
        private void Start()
        {
            var val_6;
            SLC.Minigames.WordQuiz.WordQuizManager val_33;
            float val_34;
            var val_35;
            float val_36;
            System.Action<twelvegigs.storage.JsonDictionary> val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            val_33 = this;
            this.hasAdded = false;
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  927291376);
            string val_2 = text;
            object val_3 = MiniJSON.Json.Deserialize(json:  927291376);
            val_34 = 1152921504687730688;
            if(("minigames/WordQuiz/word_data") != 0)
            {
                    if(null == null)
            {
                goto label_85;
            }
            
            }
            
            if(("minigames/WordQuiz/word_data") != 0)
            {
                    label_85:
            }
            
            val_35 = 0;
            List.Enumerator<T> val_4 = GetEnumerator();
            val_37 = 1152921505055408128;
            label_54:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            object val_7 = new System.Object();
            if(val_6 != 0)
            {
                    val_38 = val_6;
                val_38 = 0;
            }
            else
            {
                    val_38 = 0;
            }
            
            if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_8 = 2621443.ToUpper();
            val_39 = val_7;
            if(val_39 == 0)
            {
                    val_39 = val_7;
            }
            
            typeof(SLC.Minigames.WordQuiz.WordQuizLevel).__il2cppRuntimeField_8 = 2621443;
            val_40 = val_6;
            val_40 = 0;
            if(0 < 4)
            {
                goto label_25;
            }
            
            val_41 = 6;
            goto label_26;
            label_37:
            if(val_41 == 6)
            {
                    "," = "";
            }
            
            val_42 = val_6;
            val_42 = 0;
            if(0 <= val_37)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_9 = null + 1098586544 + null;
            val_41 = 7;
            val_34 = val_34;
            SLC.Minigames.WordQuiz.WordQuizLevel.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = val_40;
            label_26:
            val_43 = val_6;
            val_43 = 0;
            if((val_41 - 4) < 0)
            {
                goto label_37;
            }
            
            val_33 = val_33;
            string val_11 = SLC.Minigames.WordQuiz.WordQuizLevel.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFF.Replace(oldValue:  1377638992, newValue:  1098586544);
            val_44 = SLC.Minigames.WordQuiz.WordQuizLevel.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFF;
            SLC.Minigames.WordQuiz.WordQuizLevel.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = val_44;
            goto label_39;
            label_25:
            if(0 <= 2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_44 = 0;
            typeof(SLC.Minigames.WordQuiz.WordQuizLevel).__il2cppRuntimeField_C = val_44;
            label_39:
            if((val_44.Contains(value:  1488600160)) != false)
            {
                    string val_13 = 1179403647.Replace(oldValue:  1488600160, newValue:  System.String.alignConst);
            }
            
            if((1179403647.Contains(value:  1269544832)) != false)
            {
                    string val_15 = 1179403647.Replace(oldValue:  1269544832, newValue:  System.String.alignConst);
            }
            
            string val_16 = 1179403647.Trim();
            mem2[0] = 1179403647;
            this.allLevels.Add(item:  448561152);
            goto label_54;
            label_8:
            Dispose();
            this.randomSet.addIntRange(lowest:  0, highest:  this.allLevels - 1);
            this.trackedLevels.AddRange(collection:  this.allLevels);
            val_45 = 1152921511451483792;
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -1745297776)) == false)
            {
                goto label_63;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_21 = new System.Action(object:  927342128, method:  new IntPtr(927314032));
            System.Delegate val_22 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
            val_46 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_46 != 0)
            {
                    if(val_46 == null)
            {
                goto label_69;
            }
            
            }
            
            val_46 = 0;
            label_69:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_46;
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_24 = new System.Action(object:  927342128, method:  new IntPtr(927315056));
            System.Delegate val_25 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, b:  7454720);
            val_47 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
            if(val_47 != 0)
            {
                    if(val_47 == null)
            {
                goto label_73;
            }
            
            }
            
            val_47 = 0;
            label_73:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_47;
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_36 = 1152921504614248448;
            System.Action<System.Boolean> val_27 = new System.Action<System.Boolean>(object:  927342128, method:  new IntPtr(927316080));
            System.Delegate val_28 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78, b:  7401472);
            val_48 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78;
            if(val_48 != 0)
            {
                    if(val_48 == null)
            {
                goto label_77;
            }
            
            }
            
            val_48 = 0;
            label_77:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78 = val_48;
            twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_45 = 1152921504614248448;
            val_37 = null;
            val_37 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  927342128, method:  new IntPtr(927317104));
            System.Delegate val_31 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74, b:  7401472);
            val_49 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74;
            if(val_49 != 0)
            {
                    if(val_49 == null)
            {
                goto label_81;
            }
            
            }
            
            val_49 = 0;
            label_81:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74 = val_49;
            label_63:
            SLC.Minigames.WordQuiz.WordQuizLevel val_32 = this.GetNewLevel();
            this.currentLevel = val_33;
            this.InitializeLevel(level:  927342128);
            twelvegigs.Autopilot.AutopilotManager val_33 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StartMusic(clipIndex:  0);
        }
        private void Instance_OnInjectTracking(System.Collections.Generic.Dictionary<string, object> obj)
        {
            obj.Add(key:  927454704, value:  13152256);
        }
        private void TogglePopupWindow(bool showing)
        {
            this.wordQuizUIController.HideUIForPopup(showingPopup:  showing);
        }
        private void InitializeLevel(SLC.Minigames.WordQuiz.WordQuizLevel level)
        {
            int val_3;
            this.answerProgress = 0;
            this.isPaused = 0;
            this.hintOrder.Clear();
            System.Collections.Generic.IEnumerable<System.Int32> val_1 = System.Linq.Enumerable.Range(start:  0, count:  level.word.m_stringLength);
            this.hintOrder.AddRange(collection:  0);
            PluginExtension.Shuffle<System.Int32>(list:  this.hintOrder, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_3 = 8;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60) >= 76)
            {
                    val_3 = 12;
            }
            
            level.keyboardLetterNum = val_3;
            this.hasAdded = true;
            this.currentLevel = level;
            this.wordQuizUIController.InitializeLevel(level:  level);
        }
        private SLC.Minigames.WordQuiz.WordQuizLevel GetNewLevel()
        {
            if(this.randomSet.remainingCount() == 0)
            {
                    this.randomSet.reset();
                this.removedLevels.Clear();
                this.trackedLevels.Clear();
                this.trackedLevels.AddRange(collection:  this.allLevels);
            }
            
            int val_2 = this.randomSet.roll(unweighted:  false);
            if(val_2 <= val_2)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (val_2 << 2);
        }
        private void TrackRemovedLevel(SLC.Minigames.WordQuiz.WordQuizLevel lvl)
        {
            System.Collections.Generic.List<SLC.Minigames.WordQuiz.WordQuizLevel> val_3 = this.trackedLevels;
            if((val_3.Contains(item:  lvl)) != false)
            {
                    val_3 = this.trackedLevels;
                bool val_2 = val_3.Remove(item:  lvl);
            }
            
            this.removedLevels.Add(item:  lvl);
        }
        private int GetKeyboardLetterNumByLevel(int levelIndex)
        {
            if(levelIndex < 26)
            {
                    return 8;
            }
            
            if(levelIndex >= 76)
            {
                    10 = 12;
            }
            
            if(levelIndex < 126)
            {
                    return (int)10;
            }
            
            if(levelIndex >= 201)
            {
                    14 = 16;
            }
            
            if(levelIndex <= 300)
            {
                    return (int)10;
            }
            
            if(levelIndex <= 400)
            {
                    21 = 18;
            }
            
            return 18;
        }
        private void HandleContinue()
        {
            SLC.Minigames.WordQuiz.WordQuizLevel val_1 = this.GetNewLevel();
            this.InitializeLevel(level:  928321824);
        }
        private void OnRestartFromCheckpoint()
        {
            this._continuesUsed = 0;
            SLC.Minigames.WordQuiz.WordQuizLevel val_1 = this.GetNewLevel();
            this.InitializeLevel(level:  928433824);
        }
        public void QuitGame()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  899829136)) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGameOver();
        }
        public bool ShouldShowFTUX()
        {
            var val_5;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  -1745297776)) == false)
            {
                    return (bool)val_5;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = (public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60) >> 5;
            return (bool)val_5;
        }
        public System.Collections.Generic.List<string> GetRandomizedLetters(SLC.Minigames.WordQuiz.WordQuizLevel level)
        {
            var val_8;
            var val_9;
            var val_10;
            val_8 = 0;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            goto label_1;
            label_6:
            string val_3 = level.word.Chars[0].ToString();
            Add(item:  928774170);
            val_8 = 1;
            label_1:
            if(val_8 < level.word.m_stringLength)
            {
                goto label_6;
            }
            
            val_9 = level.keyboardLetterNum - level.word.m_stringLength;
            if(val_9 < 1)
            {
                    return;
            }
            
            do
            {
                if(mem[1152921514125567808] != 0)
            {
                    val_8 = mem[1152921514125567808];
                val_10 = UnityEngine.Random.Range(min:  0, max:  mem[1152921514125567808] + 12);
            }
            else
            {
                    val_8 = 12;
                val_10 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
                var val_6 = mem[1152921514125567808] + (val_10 << 2);
                Add(item:  (mem[1152921514125567808] + (val_5) << 2) + 16);
                val_9 = val_9 - 1;
            }
            while(null != 0);
        
        }
        public void CheckAnswerCorrect(string answer)
        {
            SLC.Minigames.WordQuiz.WordQuizLevel val_10;
            DG.Tweening.TweenCallback val_11;
            var val_12;
            if(answer.m_stringLength != this.currentLevel.word.m_stringLength)
            {
                    return;
            }
            
            val_10 = this.currentLevel;
            this.isPaused = true;
            if((answer.Equals(value:  this.currentLevel.word)) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                PlayGameSpecificSound(id:  928911072, clipIndex:  0, volumeScale:  null);
                this.wordQuizUIController.UpdateSuccessLevelUI();
                val_11 = null;
                val_11 = new DG.Tweening.TweenCallback(object:  928950592, method:  new IntPtr(928915248));
                val_12 = 1056964608;
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                PlayGameSpecificSound(id:  928916272, clipIndex:  0, volumeScale:  null);
                this.wordQuizUIController.checkMarkWrong.SetActive(value:  true);
                val_10 = 1152921504797581312;
                DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  928950592, method:  new IntPtr(928924544));
                DG.Tweening.Tween val_7 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1056964608, ignoreTimeScale:  false);
                val_11 = null;
                val_11 = new DG.Tweening.TweenCallback(object:  928950592, method:  new IntPtr(928925568));
                val_12 = 1069547520;
            }
            
            DG.Tweening.Tween val_9 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1069547520, ignoreTimeScale:  false);
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyUp(key:  32)) == false)
            {
                    return;
            }
            
            string val_2 = R4.ReturnWordPool();
        }
        public string ReturnWordPool()
        {
            string val_1 = System.Environment.NewLine;
            string val_2 = 929183360 + null;
            List.Enumerator<T> val_3 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            string val_6 = System.String.Format(format:  929189616, arg0:  val_5 + 8);
            string val_7 = System.Environment.NewLine;
            string val_8 = 929183360 + 929189616 + null;
            goto label_4;
            label_2:
            Dispose();
            string val_9 = System.Environment.NewLine;
            string val_10 = 929183360 + 929190784 + null;
            List.Enumerator<T> val_11 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_6;
            }
            
            string val_13 = System.String.Format(format:  929194976, arg0:  val_5 + 8);
            string val_14 = System.Environment.NewLine;
            string val_15 = 929183360 + 929194976 + null;
            goto label_8;
            label_6:
            Dispose();
        }
        public string ReturnCurrentAnswer()
        {
            if(this.currentLevel != 0)
            {
                    return;
            }
        
        }
        public WordQuizManager()
        {
            this.currentLevel = new System.Object();
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            this.hintOrder = null;
            typeof(System.String[]).__il2cppRuntimeField_10 = "A";
            typeof(System.String[]).__il2cppRuntimeField_14 = "B";
            typeof(System.String[]).__il2cppRuntimeField_18 = "C";
            typeof(System.String[]).__il2cppRuntimeField_1C = "D";
            typeof(System.String[]).__il2cppRuntimeField_20 = "E";
            typeof(System.String[]).__il2cppRuntimeField_24 = "F";
            typeof(System.String[]).__il2cppRuntimeField_28 = "G";
            typeof(System.String[]).__il2cppRuntimeField_2C = "H";
            typeof(System.String[]).__il2cppRuntimeField_30 = "I";
            typeof(System.String[]).__il2cppRuntimeField_34 = "J";
            typeof(System.String[]).__il2cppRuntimeField_38 = "K";
            typeof(System.String[]).__il2cppRuntimeField_3C = "L";
            typeof(System.String[]).__il2cppRuntimeField_40 = "M";
            typeof(System.String[]).__il2cppRuntimeField_44 = "N";
            typeof(System.String[]).__il2cppRuntimeField_48 = "O";
            typeof(System.String[]).__il2cppRuntimeField_4C = "P";
            typeof(System.String[]).__il2cppRuntimeField_50 = "Q";
            typeof(System.String[]).__il2cppRuntimeField_54 = "R";
            typeof(System.String[]).__il2cppRuntimeField_58 = "S";
            typeof(System.String[]).__il2cppRuntimeField_5C = "T";
            typeof(System.String[]).__il2cppRuntimeField_60 = "U";
            typeof(System.String[]).__il2cppRuntimeField_64 = "V";
            typeof(System.String[]).__il2cppRuntimeField_68 = "W";
            typeof(System.String[]).__il2cppRuntimeField_6C = "X";
            typeof(System.String[]).__il2cppRuntimeField_70 = "Y";
            typeof(System.String[]).__il2cppRuntimeField_74 = "Z";
            this.vocabulary = null;
            this.allLevels = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.randomSet = new RandomSet();
            this.removedLevels = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.trackedLevels = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
        private void <CheckAnswerCorrect>b__28_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -1745297776)) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = HandleLevelComplete();
            SLC.Minigames.WordQuiz.WordQuizLevel val_5 = this.GetNewLevel();
            this.InitializeLevel(level:  929582144);
        }
        private void <CheckAnswerCorrect>b__28_1()
        {
            this.wordQuizUIController.checkMarkWrong.SetActive(value:  false);
            goto label_2;
            label_6:
            this.wordQuizUIController.ShowHint();
            0 = 1;
            label_2:
            if(0 < this.currentLevel.word.m_stringLength)
            {
                goto label_6;
            }
        
        }
        private void <CheckAnswerCorrect>b__28_2()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -1745297776)) == false)
            {
                    return;
            }
            
            int val_5 = this._continuesUsed;
            val_5 = val_5 + 1;
            this._continuesUsed = val_5;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = HandleLevelFailed();
        }
    
    }

}
