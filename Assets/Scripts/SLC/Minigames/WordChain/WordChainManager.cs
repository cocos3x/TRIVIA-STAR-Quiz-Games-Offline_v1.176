using UnityEngine;

namespace SLC.Minigames.WordChain
{
    public class WordChainManager : MonoSingleton<SLC.Minigames.WordChain.WordChainManager>
    {
        // Fields
        private SLC.Minigames.WordChain.WordChainUIController wordChainUIController;
        public SLC.Minigames.WordChain.WordChainLevel currentLevel;
        public int answerProgress;
        public System.Collections.Generic.List<int> hintOrder;
        private bool isPaused;
        private readonly string[] vocabulary;
        private System.Collections.Generic.List<SLC.Minigames.WordChain.WordChainLevel> allLevels;
        private RandomSet randomSet;
        
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
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  964961680);
            string val_2 = text;
            object val_3 = MiniJSON.Json.Deserialize(json:  964961680);
            if(("minigames/WordChain/word_data") != 0)
            {
                    if(null == null)
            {
                goto label_4;
            }
            
            }
            
            if(("minigames/WordChain/word_data") == 0)
            {
                goto label_5;
            }
            
            label_62:
            label_5:
            val_21 = 0;
            List.Enumerator<T> val_4 = GetEnumerator();
            val_22 = 1152921514161743376;
            label_42:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            object val_7 = new System.Object();
            if(val_6 != 0)
            {
                    val_23 = val_6;
                val_23 = 0;
            }
            else
            {
                    val_23 = 0;
            }
            
            if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_8 = 2621443.ToUpper();
            typeof(SLC.Minigames.WordChain.WordChainLevel).__il2cppRuntimeField_8 = 2621443;
            if(val_6 != 0)
            {
                    val_24 = val_6;
                val_24 = 0;
            }
            else
            {
                    val_24 = 0;
            }
            
            if(0 <= 2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_9 = 0.ToUpper();
            typeof(SLC.Minigames.WordChain.WordChainLevel).__il2cppRuntimeField_C = 0;
            if(val_6 != 0)
            {
                    val_25 = 0;
            }
            else
            {
                    val_25 = 0;
            }
            
            if((val_6 + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_10 = val_6 + 8 + 20.ToUpper();
            typeof(SLC.Minigames.WordChain.WordChainLevel).__il2cppRuntimeField_10 = val_6 + 8 + 20;
            this.allLevels.Add(item:  450691072);
            goto label_42;
            label_8:
            Dispose();
            this.randomSet.addIntRange(lowest:  0, highest:  this.allLevels - 1);
            val_26 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -1745297776)) == false)
            {
                goto label_49;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_22 = 1152921504614301696;
            System.Action val_15 = new System.Action(object:  965001168, method:  new IntPtr(964975120));
            System.Delegate val_16 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
            val_27 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_27 != 0)
            {
                    if(val_27 == null)
            {
                goto label_55;
            }
            
            }
            
            val_27 = 0;
            label_55:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_27;
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_18 = new System.Action(object:  965001168, method:  new IntPtr(964976144));
            System.Delegate val_19 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, b:  7454720);
            val_26 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
            if(val_26 != 0)
            {
                    if(val_26 == null)
            {
                goto label_59;
            }
            
            }
            
            val_26 = 0;
            label_59:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_26;
            UnityEngine.Debug.LogError(message:  935321600);
            label_49:
            SLC.Minigames.WordChain.WordChainLevel val_20 = this.GetNewLevel();
            this.currentLevel = this;
            this.InitializeLevel(level:  965001168);
            return;
            label_4:
            goto label_62;
        }
        private void InitializeLevel(SLC.Minigames.WordChain.WordChainLevel level)
        {
            int val_3;
            this.answerProgress = 0;
            this.isPaused = 0;
            this.hintOrder.Clear();
            System.Collections.Generic.IEnumerable<System.Int32> val_1 = System.Linq.Enumerable.Range(start:  0, count:  level.answer.m_stringLength);
            this.hintOrder.AddRange(collection:  0);
            PluginExtension.Shuffle<System.Int32>(list:  this.hintOrder, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_3 = 8;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60) >= 76)
            {
                    val_3 = 12;
            }
            
            level.keyboardLetterNum = val_3;
            this.currentLevel = level;
            this.wordChainUIController.InitializeLevel(level:  level);
        }
        private SLC.Minigames.WordChain.WordChainLevel GetNewLevel()
        {
            if(this.randomSet.remainingCount() == 0)
            {
                    this.randomSet.addIntRange(lowest:  0, highest:  this.allLevels - 1);
            }
            
            int val_3 = this.randomSet.roll(unweighted:  false);
            if(val_3 <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (val_3 << 2);
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
            SLC.Minigames.WordChain.WordChainLevel val_1 = this.GetNewLevel();
            this.InitializeLevel(level:  965551568);
        }
        private void OnRestartFromCheckpoint()
        {
            SLC.Minigames.WordChain.WordChainLevel val_1 = this.GetNewLevel();
            this.InitializeLevel(level:  965663568);
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
        public void QuitGame()
        {
            App.Quit();
        }
        public System.Collections.Generic.List<string> GetRandomizedLetters(SLC.Minigames.WordChain.WordChainLevel level)
        {
            var val_8;
            var val_9;
            var val_10;
            val_8 = 0;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            goto label_1;
            label_6:
            string val_3 = level.answer.Chars[0].ToString();
            Add(item:  966003914);
            val_8 = 1;
            label_1:
            if(val_8 < level.answer.m_stringLength)
            {
                goto label_6;
            }
            
            val_9 = level.keyboardLetterNum - level.answer.m_stringLength;
            if(val_9 < 1)
            {
                    return;
            }
            
            do
            {
                if(mem[1152921514162797552] != 0)
            {
                    val_8 = mem[1152921514162797552];
                val_10 = UnityEngine.Random.Range(min:  0, max:  mem[1152921514162797552] + 12);
            }
            else
            {
                    val_8 = 12;
                val_10 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
                var val_6 = mem[1152921514162797552] + (val_10 << 2);
                Add(item:  (mem[1152921514162797552] + (val_5) << 2) + 16);
                val_9 = val_9 - 1;
            }
            while(null != 0);
        
        }
        public void CheckAnswerCorrect(string answer)
        {
            string val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            DG.Tweening.TweenCallback val_13;
            val_7 = this.currentLevel.answer;
            if(answer.m_stringLength != this.currentLevel.answer.m_stringLength)
            {
                    return;
            }
            
            this.isPaused = true;
            val_8 = answer.Equals(value:  this.currentLevel.answer);
            if(val_8 != false)
            {
                    this.wordChainUIController.UpdateSuccessLevelUI();
                DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  966171984, method:  new IntPtr(966144912));
                val_9 = 1056964608;
                val_10 = null;
            }
            else
            {
                    this.wordChainUIController.UpdateFailedLevelUI();
                val_8 = 1152921504797581312;
                DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  966171984, method:  new IntPtr(966145936));
                DG.Tweening.Tween val_4 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1056964608, ignoreTimeScale:  false);
                val_7 = 1152921505057484800;
                val_11 = null;
                val_11 = null;
                val_13 = WordChainManager.<>c.<>9__21_2;
                if(val_13 == 0)
            {
                    val_13 = null;
                val_13 = new DG.Tweening.TweenCallback(object:  WordChainManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(966146960));
                WordChainManager.<>c.<>9__21_2 = val_13;
            }
            
                val_9 = 1069547520;
                val_10 = val_13;
            }
            
            DG.Tweening.Tween val_6 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1069547520, ignoreTimeScale:  false);
        }
        public WordChainManager()
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
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.allLevels = null;
            this.randomSet = new RandomSet();
        }
        private void <CheckAnswerCorrect>b__21_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  -1745297776)) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = HandleLevelComplete();
            SLC.Minigames.WordChain.WordChainLevel val_5 = this.GetNewLevel();
            this.InitializeLevel(level:  966422608);
        }
        private void <CheckAnswerCorrect>b__21_1()
        {
            goto label_0;
            label_4:
            this.wordChainUIController.ShowHint();
            0 = 1;
            label_0:
            if(0 < this.currentLevel.answer.m_stringLength)
            {
                goto label_4;
            }
        
        }
    
    }

}
