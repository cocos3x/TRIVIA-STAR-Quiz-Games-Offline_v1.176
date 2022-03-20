using UnityEngine;

namespace SLC.Minigames.Ladder
{
    public class WordLadderController : MonoSingleton<SLC.Minigames.Ladder.WordLadderController>
    {
        // Fields
        public const int MIN_LETTER_UNICODE = 65;
        public const int MAX_LETTER_UNICODE = 91;
        public const int MAX_WORD_LENGTH = 5;
        public const int MAX_FOUND_WORDS = 5;
        private System.Collections.Generic.List<SLC.Minigames.Ladder.WordLadderLevel> levels;
        private bool initialized;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.HashSet<string>> validWords;
        private SLC.Minigames.Ladder.WordLadderLevel currentLevel;
        public bool IsGameOver;
        
        // Methods
        private void Initialize()
        {
            if(this.initialized != false)
            {
                    return;
            }
            
            this.LoadLevelDefinitions();
            this.LoadWordsLists();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = new System.Action(object:  942641536, method:  new IntPtr(942616368));
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = new System.Action(object:  942641536, method:  new IntPtr(942616368));
            this.StartLevel();
            this.initialized = true;
            UnityEngine.Debug.LogError(message:  942617392);
        }
        private void StartLevel()
        {
            var val_3;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  0);
            if(val_1 <= val_1)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (val_1 << 2);
            this.currentLevel = (0 + (val_1) << 2) + 16;
            if(((0 + (val_1) << 2) + 16) != 0)
            {
                    val_3 = mem[(0 + (val_1) << 2) + 16 + 8];
                val_3 = (0 + (val_1) << 2) + 16 + 8;
            }
            else
            {
                    val_3 = 0;
            }
            
            mem2[0] = val_3;
            this.levels.RemoveAt(index:  val_1);
            if(this.levels <= 0)
            {
                    this.levels = this;
                this.LoadLevelDefinitions();
            }
            
            this.IsGameOver = false;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StartLevel(currentLevel:  this.currentLevel);
        }
        private void LoadLevelDefinitions()
        {
            var val_7;
            var val_8;
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  942884544);
            string val_2 = text;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.levels = null;
            val_7 = null;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
            System.String[] val_4 = Split(separator:  478563824);
            val_8 = 5;
            if(("minigames/WordLadder/word_ladder_levels") != 0)
            {
                    return;
            }
        
        }
        public void SubmitWord(string chosenWord)
        {
            SLC.Minigames.Ladder.WordLadderLevel val_5;
            bool val_1 = this.currentLevel.ladder.Contains(item:  chosenWord);
            if(val_1 != false)
            {
                    val_1.ShowWordAlreadyUsed(chosenWord:  chosenWord);
                return;
            }
            
            if((System.String.op_Equality(a:  this.currentLevel.requiredWord, b:  chosenWord)) != false)
            {
                    this.LevelComplete();
                return;
            }
            
            val_5 = this.currentLevel;
            if(this.currentLevel != 0)
            {
                goto label_6;
            }
            
            val_5 = this.currentLevel;
            if(val_5 == 0)
            {
                goto label_7;
            }
            
            label_6:
            this.currentLevel.ladder.Enqueue(item:  this.currentLevel.chosenWord);
            if(this.currentLevel.ladder >= 6)
            {
                    string val_3 = this.currentLevel.ladder.Dequeue();
            }
            
            this.currentLevel.chosenWord = chosenWord;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ValidWord(currentLevel:  this.currentLevel);
            return;
            label_7:
        }
        private void LevelComplete()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LevelComplete(victory:  true);
            System.Collections.IEnumerator val_2 = this.LevelCompleteDelay(delay:  null, wincondition:  false);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  943266848);
        }
        private void GameOver()
        {
            this.IsGameOver = true;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LevelComplete(victory:  false);
            System.Collections.IEnumerator val_2 = this.LevelCompleteDelay(delay:  null, wincondition:  false);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  943378848);
        }
        private System.Collections.IEnumerator LevelCompleteDelay(float delay, bool wincondition)
        {
            typeof(WordLadderController.<LevelCompleteDelay>d__15).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WordLadderController.<LevelCompleteDelay>d__15).__il2cppRuntimeField_10 = wincondition;
                typeof(WordLadderController.<LevelCompleteDelay>d__15).__il2cppRuntimeField_18 = this;
            }
            else
            {
                    mem[24] = this;
                mem[16] = wincondition;
            }
            
            typeof(WordLadderController.<LevelCompleteDelay>d__15).__il2cppRuntimeField_14 = R2;
        }
        private void ShowWordAlreadyUsed(string chosenWord)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordAlreadyUsed(usedWord:  chosenWord);
        }
        public System.Collections.Generic.List<string> GenerateLettersForTappedLetter(int index)
        {
            SLC.Minigames.Ladder.WordLadderLevel val_9;
            System.Char[] val_10;
            var val_11;
            val_9 = this.currentLevel;
            if(val_9 == 0)
            {
                    val_9 = this.currentLevel;
            }
            
            var val_9 = 65;
            do
            {
                System.Char[] val_2 = this.currentLevel.chosenWord.ToCharArray();
                val_10 = this.currentLevel.chosenWord;
                string val_3 = val_10 + (index << 1);
                if(this.currentLevel.chosenWord.m_firstChar != 65)
            {
                    mem2[0] = val_9;
                val_11 = val_9;
                if(this.currentLevel.chosenWord.m_firstChar <= index)
            {
                    val_11 = mem[(this.currentLevel.chosenWord + (index) << 1) + 16];
                val_11 = (this.currentLevel.chosenWord + (index) << 1) + 16;
            }
            
                string val_4 = 0.CreateString(val:  val_10);
                System.Collections.Generic.HashSet<System.String> val_5 = this.validWords.Item[this.currentLevel.chosenWord.m_firstChar];
                val_10 = this.validWords;
                if((val_10.Contains(item:  0)) != false)
            {
                    val_10 = this.currentLevel.ladder;
                if((val_10.Contains(item:  null)) != true)
            {
                    string val_8 = val_11.ToString();
                val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                Add(item:  943736602);
            }
            
            }
            
            }
            
                val_9 = val_9 + 1;
            }
            while(val_9 != 91);
            
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) == 0)
            {
                    System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze = this;
                this.GameOver();
            }
        
        }
        private void LoadWordsLists()
        {
            UnityEngine.UI.Text val_16;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            System.Collections.Generic.HashSet<UnityEngine.UI.Text> val_2 = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            Add(key:  3, value:  146378752);
            System.Collections.Generic.HashSet<UnityEngine.UI.Text> val_3 = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            Add(key:  4, value:  146378752);
            System.Collections.Generic.HashSet<UnityEngine.UI.Text> val_4 = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            Add(key:  5, value:  146378752);
            this.validWords = null;
            object val_5 = UnityEngine.Resources.Load<System.Object>(path:  943863264);
            string val_6 = text;
            object val_7 = MiniJSON.Json.Deserialize(json:  943863264);
            object val_8 = UnityEngine.Resources.Load<System.Object>(path:  943863408);
            string val_9 = text;
            object val_10 = MiniJSON.Json.Deserialize(json:  943863408);
            if(("minigames/WordLadder/common_words/4") != 0)
            {
                    if(null != null)
            {
                    "minigames/WordLadder/common_words/4" = 0;
            }
            
            }
            
            object val_11 = UnityEngine.Resources.Load<System.Object>(path:  943863552);
            string val_12 = text;
            object val_13 = MiniJSON.Json.Deserialize(json:  943863552);
            if(("minigames/WordLadder/common_words/5") != 0)
            {
                    if(null != null)
            {
                    "minigames/WordLadder/common_words/5" = 0;
            }
            
            }
            
            if(("minigames/WordLadder/common_words/3") != 0)
            {
                    if(null == null)
            {
                goto label_76;
            }
            
            }
            
            if(("minigames/WordLadder/common_words/3") != 0)
            {
                    label_76:
            }
            
            val_54 = 0;
            List.Enumerator<T> val_14 = GetEnumerator();
            label_22:
            if(MoveNext() == false)
            {
                goto label_17;
            }
            
            System.Collections.Generic.HashSet<System.String> val_17 = this.validWords.Item[3];
            string val_18 = val_16.ToUpper();
            bool val_19 = this.validWords.Add(item:  val_16);
            goto label_22;
            label_17:
            Dispose();
            List.Enumerator<T> val_20 = GetEnumerator();
            label_29:
            if(MoveNext() == false)
            {
                goto label_24;
            }
            
            System.Collections.Generic.HashSet<System.String> val_22 = this.validWords.Item[4];
            string val_23 = val_16.ToUpper();
            bool val_24 = this.validWords.Add(item:  val_16);
            goto label_29;
            label_24:
            Dispose();
            List.Enumerator<T> val_25 = GetEnumerator();
            label_36:
            if(MoveNext() == false)
            {
                goto label_31;
            }
            
            System.Collections.Generic.HashSet<System.String> val_27 = this.validWords.Item[5];
            string val_28 = val_16.ToUpper();
            bool val_29 = this.validWords.Add(item:  val_16);
            goto label_36;
            label_31:
            Dispose();
            if(0 != 1)
            {
                    if(0 > 1)
            {
                    0 = 1;
            }
            
                val_55 = 0 - 0;
            }
            else
            {
                    val_55 = 0;
            }
            
            object val_30 = UnityEngine.Resources.Load<System.Object>(path:  943875984);
            string val_31 = text;
            object val_32 = MiniJSON.Json.Deserialize(json:  943875984);
            object val_33 = UnityEngine.Resources.Load<System.Object>(path:  943876128);
            string val_34 = text;
            object val_35 = MiniJSON.Json.Deserialize(json:  943876128);
            if(("minigames/WordLadder/uncommon_words/4") != 0)
            {
                    if(null != null)
            {
                    "minigames/WordLadder/uncommon_words/4" = 0;
            }
            
            }
            
            object val_36 = UnityEngine.Resources.Load<System.Object>(path:  943876272);
            val_56 = 0;
            string val_37 = text;
            object val_38 = MiniJSON.Json.Deserialize(json:  943876272);
            val_57 = null;
            if(("minigames/WordLadder/uncommon_words/5") != 0)
            {
                    if(null != val_57)
            {
                    "minigames/WordLadder/uncommon_words/5" = 0;
            }
            
                val_56 = "minigames/WordLadder/uncommon_words/5";
            }
            
            if(("minigames/WordLadder/uncommon_words/3") != 0)
            {
                    if(null == val_57)
            {
                goto label_48;
            }
            
            }
            
            if(("minigames/WordLadder/uncommon_words/3") == 0)
            {
                goto label_49;
            }
            
            val_57 = null;
            label_48:
            label_49:
            val_58 = 0;
            List.Enumerator<T> val_39 = GetEnumerator();
            label_57:
            if(MoveNext() == false)
            {
                goto label_52;
            }
            
            System.Collections.Generic.HashSet<System.String> val_41 = this.validWords.Item[3];
            string val_42 = val_16.ToUpper();
            bool val_43 = this.validWords.Add(item:  val_16);
            goto label_57;
            label_52:
            var val_54 = val_55;
            val_54 = val_54 + 1;
            mem2[0] = 489;
            Dispose();
            if(val_54 != 1)
            {
                    if(val_54 > 1)
            {
                    0 = 1;
            }
            
                var val_55 = 943900584 + ((val_55 + 1)) << 2;
                val_55 = val_55 - 489;
                val_55 = val_55 >> 5;
                val_55 = 1 & val_55;
                val_59 = val_54 - val_55;
            }
            else
            {
                    val_59 = 0;
            }
            
            val_60 = "minigames/WordLadder/uncommon_words/4";
            if(val_60 == 0)
            {
                    val_60 = "minigames/WordLadder/uncommon_words/4";
            }
            
            List.Enumerator<T> val_44 = GetEnumerator();
            label_66:
            if(MoveNext() == false)
            {
                goto label_61;
            }
            
            System.Collections.Generic.HashSet<System.String> val_46 = this.validWords.Item[4];
            string val_47 = val_16.ToUpper();
            bool val_48 = this.validWords.Add(item:  val_16);
            goto label_66;
            label_61:
            var val_56 = val_59;
            val_56 = val_56 + 1;
            mem2[0] = 562;
            Dispose();
            if(val_56 != 1)
            {
                    if(val_56 > 1)
            {
                    0 = 1;
            }
            
                var val_57 = 943900584 + ((val_59 + 1)) << 2;
                val_57 = val_57 - 562;
                val_57 = val_57 >> 5;
                val_57 = 1 & val_57;
                val_57 = val_56 - val_57;
                val_61 = val_57 + 1;
            }
            else
            {
                    val_61 = 0;
            }
            
            List.Enumerator<T> val_49 = GetEnumerator();
            label_75:
            if(MoveNext() == false)
            {
                goto label_70;
            }
            
            System.Collections.Generic.HashSet<System.String> val_51 = this.validWords.Item[5];
            string val_52 = val_16.ToUpper();
            bool val_53 = this.validWords.Add(item:  val_16);
            goto label_75;
            label_70:
            Dispose();
        }
        public override void InitMonoSingleton()
        {
            this.InitMonoSingleton();
            this.Initialize();
        }
        public WordLadderController()
        {
        
        }
    
    }

}
