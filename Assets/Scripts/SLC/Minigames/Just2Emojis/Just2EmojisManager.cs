using UnityEngine;

namespace SLC.Minigames.Just2Emojis
{
    public class Just2EmojisManager : MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisManager>
    {
        // Fields
        private System.Collections.Generic.List<SLC.Minigames.Just2Emojis.J2ELevel> levels;
        private System.Collections.Generic.List<SLC.Minigames.Just2Emojis.J2ELevel> trackedLevels;
        private System.Collections.Generic.List<SLC.Minigames.Just2Emojis.J2ELevel> removedLevels;
        private bool hasAdded;
        private bool init;
        private SLC.Minigames.Just2Emojis.J2ELevel currentLevel;
        private string currentAnswer;
        private char[] currentAnswerCharacters;
        public int ftuxIndex;
        private int _continuesUsed;
        
        // Methods
        public override void InitMonoSingleton()
        {
            this.Initialize();
        }
        private void Initialize()
        {
            var val_14;
            var val_15;
            var val_16;
            if(this.init != false)
            {
                    return;
            }
            
            this.ftuxIndex = 0;
            this.LoadData();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  1039157744, method:  new IntPtr(1039119408));
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = null;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_4 = new System.Action(object:  1039157744, method:  new IntPtr(1039120432));
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = null;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_6 = new System.Action(object:  1039157744, method:  new IntPtr(1039121456));
            System.Delegate val_7 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C, b:  7454720);
            val_14 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C;
            if(val_14 != 0)
            {
                    if(val_14 == null)
            {
                goto label_9;
            }
            
            }
            
            val_14 = 0;
            label_9:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C = val_14;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_9 = new System.Action<System.Boolean>(object:  1039157744, method:  new IntPtr(1039122480));
            System.Delegate val_10 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78, b:  7401472);
            val_15 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78;
            if(val_15 != 0)
            {
                    if(val_15 == null)
            {
                goto label_13;
            }
            
            }
            
            val_15 = 0;
            label_13:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78 = val_15;
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_12 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1039157744, method:  new IntPtr(1039123504));
            System.Delegate val_13 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74, b:  7401472);
            val_16 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74;
            if(val_16 != 0)
            {
                    if(val_16 == null)
            {
                goto label_17;
            }
            
            }
            
            val_16 = 0;
            label_17:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74 = val_16;
            this.trackedLevels.Clear();
            this.removedLevels.Clear();
            this.init = true;
        }
        private void Instance_OnInjectTracking(System.Collections.Generic.Dictionary<string, object> obj)
        {
            obj.Add(key:  927454704, value:  13152256);
        }
        private void Start()
        {
            this._continuesUsed = 0;
            this.LoadLevel();
            this.hasAdded = true;
        }
        private void TogglePopupWindow(bool showUI)
        {
            bool val_2 = showUI;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_2 = val_2 ^ 1;
            public static SLC.Minigames.Just2Emojis.Just2EmojisUIController MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisUIController>::get_Instance().__il2cppRuntimeField_C.enabled = val_2;
        }
        private void LoadData()
        {
            var val_11;
            var val_12;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.levels = null;
            object val_2 = UnityEngine.Resources.Load<System.Object>(path:  1039599152);
            string val_3 = text;
            object val_4 = MiniJSON.Json.Deserialize(json:  1039599152);
            if(("minigames/Just2Emojis/emojis_levels") != 0)
            {
                    if(null == null)
            {
                goto label_20;
            }
            
            }
            
            if(("minigames/Just2Emojis/emojis_levels") != 0)
            {
                    label_20:
            }
            
            val_11 = 0;
            List.Enumerator<T> val_5 = GetEnumerator();
            var val_11 = 0;
            label_18:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            string val_8 = 0.Item[1039600320];
            string val_9 = 0.Item[-490661280];
            val_12 = 0;
            if(0 != 0)
            {
                    if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    0 = 0;
            }
            
                val_12 = 0;
            }
            
            SLC.Minigames.Just2Emojis.J2ELevel val_10 = new SLC.Minigames.Just2Emojis.J2ELevel(index:  0, emojiSet:  0, answer:  null);
            this.levels.Add(item:  454471680);
            this.trackedLevels.Add(item:  454471680);
            val_11 = val_11 + 1;
            goto label_18;
            label_8:
            Dispose();
        }
        private void ContinueLevels()
        {
            this.LoadLevel();
        }
        private void ResetLevel()
        {
            this._continuesUsed = 0;
            this.LoadLevel();
        }
        private void LoadLevel()
        {
            int val_8;
            SLC.Minigames.Just2Emojis.J2ELevel val_9;
            var val_10;
            System.Char[] val_11;
            var val_12;
            var val_13;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  0);
            val_8 = val_1;
            if(val_1 <= val_8)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (val_8 << 2);
            this.currentLevel = (0 + (val_1) << 2) + 16;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = this.currentLevel;
            var val_9 = 0;
            label_18:
            int val_3 = public static Just2EmojisFTUXManager MonoSingleton<Just2EmojisFTUXManager>::get_Instance().__il2cppRuntimeField_28.GetPlayerCurrentLevel();
            val_10 = 8;
            if(val_3 < 26)
            {
                goto label_20;
            }
            
            if(val_3 >= 76)
            {
                    val_10 = 12;
            }
            
            if(val_3 >= 126)
            {
                goto label_11;
            }
            
            label_20:
            if((this.currentLevel.lettersSet <= val_10) || (val_9 >= val_3))
            {
                goto label_14;
            }
            
            int val_4 = UnityEngine.Random.Range(min:  0, max:  12);
            if(val_4 <= val_4)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + 1;
            val_10 = val_10 + (val_4 << 2);
            this.currentLevel = (0 + (val_4) << 2) + 16;
            goto label_18;
            label_11:
            if(val_3 >= 201)
            {
                    14 = 16;
            }
            
            if(val_3 <= 300)
            {
                goto label_20;
            }
            
            if(val_3 <= 400)
            {
                    21 = 18;
            }
            
            goto label_20;
            label_14:
            this.currentAnswer = "";
            if(this.hasAdded != false)
            {
                    if("" <= val_8)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = val_12 + (val_8 << 2);
                this.TrackRemovedLevel(lvl:  (0 + (val_5) << 2) + 16);
            }
            
            this.levels.RemoveAt(index:  val_8 = val_5);
            string val_6 = this.currentLevel.StrippedAnswer;
            val_11 = null;
            this.currentAnswerCharacters = null;
            val_12 = 0;
            val_13 = 16;
            goto label_33;
            label_37:
            val_13 = 18;
            val_12 = 1;
            mem2[0] = 45;
            val_11 = this.currentAnswerCharacters;
            label_33:
            if(val_12 < this.currentAnswerCharacters[val_13])
            {
                goto label_37;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StartLevel(currentLevel:  this.currentLevel);
            if((public static SLC.Minigames.Just2Emojis.Just2EmojisUIController MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisUIController>::get_Instance()) > 9)
            {
                    return;
            }
            
            this.LoadData();
        }
        private void TrackRemovedLevel(SLC.Minigames.Just2Emojis.J2ELevel lvl)
        {
            System.Collections.Generic.List<SLC.Minigames.Just2Emojis.J2ELevel> val_3 = this.trackedLevels;
            if((val_3.Contains(item:  lvl)) != false)
            {
                    val_3 = this.trackedLevels;
                bool val_2 = val_3.Remove(item:  lvl);
            }
            
            this.removedLevels.Add(item:  lvl);
        }
        public void LetterClick(SLC.Minigames.Just2Emojis.Just2EmojisItem item)
        {
            float val_8;
            var val_9;
            val_8 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            return;
            label_16:
            if(null == 45)
            {
                goto label_14;
            }
            
            val_9 = 1;
            if(val_9 < null)
            {
                goto label_16;
            }
            
            goto label_17;
            label_14:
            mem2[0] = System.Char.Parse(s:  item.letter);
            val_8 = 1152921504901095424;
            label_17:
            string val_6 = 0.CreateString(val:  this.currentAnswerCharacters);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLetterBlockClicked(letter:  item.letter, index:  0, item:  item);
            this.CheckForAnswer();
        }
        public void ClearCurrentAnswerChar(int index)
        {
            this.currentAnswerCharacters[index << 1] = 45;
            string val_1 = 0.CreateString(val:  this.currentAnswerCharacters);
        }
        public void AnswerClick(SLC.Minigames.Just2Emojis.Just2EmojisAnswer answer, System.Collections.Generic.List<SLC.Minigames.Just2Emojis.Just2EmojisAnswer> answerBlocks)
        {
            int val_6 = answer.index;
            if((this.currentAnswerCharacters[val_6 << 1]) == ('-'))
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = public static SLC.Minigames.Just2Emojis.Just2EmojisUIController MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisUIController>::get_Instance();
        }
        public void Hint()
        {
            var val_7;
            int val_8;
            val_7 = 0;
            val_8 = UnityEngine.Random.Range(min:  0, max:  0);
            goto label_2;
            label_7:
            val_7 = 1;
            val_8 = UnityEngine.Random.Range(min:  0, max:  0);
            label_2:
            if(val_7 > 99)
            {
                goto label_6;
            }
            
            char val_7 = this.currentAnswerCharacters[val_8 << 1];
            if(val_7 != ('-'))
            {
                goto label_7;
            }
            
            label_6:
            if(val_7 == 100)
            {
                    val_7 = this;
                this.CheckForAnswer();
            }
            
            string val_3 = this.currentLevel.StrippedAnswer;
            this.currentAnswerCharacters[val_8 << 1] = this.currentLevel.Chars[val_8];
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Hinted(index:  val_8);
            if((System.Linq.Enumerable.Contains<System.Char>(source:  this.currentAnswerCharacters, value:  '-')) != false)
            {
                    return;
            }
            
            this.CheckForAnswer();
        }
        public string GetAnswerNextLetter()
        {
            string val_1 = this.currentLevel.StrippedAnswer;
            if(this.ftuxIndex >= this.currentLevel.levelIndex)
            {
                    return;
            }
            
            string val_2 = this.currentLevel.StrippedAnswer;
            string val_4 = this.currentLevel.Chars[this.ftuxIndex].ToString();
        }
        private void CheckForAnswer()
        {
            string val_11;
            string val_1 = this.currentLevel.StrippedAnswer;
            val_11 = this.currentLevel;
            string val_2 = 0.CreateString(val:  this.currentAnswerCharacters);
            if((System.String.op_Equality(a:  null, b:  val_11)) != false)
            {
                    System.Collections.IEnumerator val_4 = this.AnswerFeedback(correct:  true);
                UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  1042280400);
                val_11 = 1152921514236742544;
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                EndFTUX();
                return;
            }
            
            if((System.Linq.Enumerable.Contains<System.Char>(source:  0, value:  '-')) != false)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_9 = this.AnswerFeedback(correct:  false);
            UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  1042280400);
        }
        private System.Collections.IEnumerator AnswerFeedback(bool correct)
        {
            typeof(Just2EmojisManager.<AnswerFeedback>d__26).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(Just2EmojisManager.<AnswerFeedback>d__26).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            typeof(Just2EmojisManager.<AnswerFeedback>d__26).__il2cppRuntimeField_10 = correct;
        }
        public int GetPlayerCurrentLevel()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) != 0)
            {
                    return (int)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
            }
            
            return (int)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
        }
        private void ContinueToggleUI()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.Just2Emojis.Just2EmojisUIController MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisUIController>::get_Instance().__il2cppRuntimeField_C.enabled = true;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SetLettersInteractable(on:  true);
        }
        public string CurrentLevelInfo()
        {
            if(this.currentLevel == 0)
            {
                
            }
        
        }
        public string ReturnWordPool()
        {
            string val_1 = System.Environment.NewLine;
            string val_2 = 1042865552 + null;
            List.Enumerator<T> val_3 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            string val_6 = System.String.Format(format:  1042871808, arg0:  val_5 + 20);
            string val_7 = System.Environment.NewLine;
            string val_8 = 1042865552 + 1042871808 + null;
            goto label_4;
            label_2:
            Dispose();
            string val_9 = System.Environment.NewLine;
            string val_10 = System.Environment.NewLine;
            string val_11 = 1042865552 + null + 1042872928 + null;
            List.Enumerator<T> val_12 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_6;
            }
            
            string val_14 = System.String.Format(format:  1042877136, arg0:  val_5 + 20);
            string val_15 = System.Environment.NewLine;
            string val_16 = 1042865552 + 1042877136 + null;
            goto label_8;
            label_6:
            Dispose();
        }
        public Just2EmojisManager()
        {
            this.trackedLevels = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.removedLevels = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
    
    }

}
