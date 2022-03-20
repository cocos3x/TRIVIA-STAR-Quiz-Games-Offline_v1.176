using UnityEngine;

namespace SLC.Minigames.Ladder
{
    public class WordLadderUIController : MonoSingleton<SLC.Minigames.Ladder.WordLadderUIController>
    {
        // Fields
        private UnityEngine.GameObject container;
        private UnityEngine.GameObject chosenWord;
        private UnityEngine.Transform chosenWordRoot;
        private UnityEngine.UI.Text levelTitle;
        private UnityEngine.GameObject keyboardLetter;
        private UnityEngine.Transform[] keyboardContainers;
        private UnityEngine.Transform Arrow;
        private UnityEngine.UI.Text[] foundWords;
        private UnityEngine.GameObject checkMark;
        private UnityEngine.GameObject crossMark;
        private SLC.Minigames.Ladder.FlyKeyBoardLetter FlyKeyBoardLetter;
        private UnityEngine.Sprite chosenLetterSprite;
        private UnityEngine.Sprite unChosenLetterSprite;
        private System.Collections.Generic.List<SLC.Minigames.Ladder.WordLadderKeyboardLetter> keyboardLetters;
        private System.Collections.Generic.List<SLC.Minigames.Ladder.WordLadderLetter> chosenLetters;
        private SLC.Minigames.Ladder.WordLadderLetter chosenLetter;
        private SLC.Minigames.Ladder.WordLadderKeyboardLetter itemClicked;
        private bool initialized;
        
        // Methods
        public override void InitMonoSingleton()
        {
            this.InitMonoSingleton();
            this.Initialize();
        }
        private void Initialize()
        {
            var val_12 = 0;
            if(this.initialized == true)
            {
                    return;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.keyboardLetters = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.chosenLetters = null;
            do
            {
                object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.keyboardLetter, parent:  this.keyboardContainers[0]);
                object val_5 = this.keyboardLetter.GetComponent<System.Object>();
                string val_6 = val_12 + 65.ToString();
                if(this.keyboardLetter != 0)
            {
                    this.keyboardLetter.Setup(letter:  947322538, myIndex:  0);
            }
            else
            {
                    0.Setup(letter:  947322538, myIndex:  0);
            }
            
                UnityEngine.GameObject val_7 = this.keyboardLetter.gameObject;
                this.keyboardLetter.SetActive(value:  false);
                this.keyboardLetters.Add(item:  this.keyboardLetter);
                val_12 = val_12 + 1;
            }
            while(val_12 != 26);
            
            var val_13 = 0;
            do
            {
                object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  this.chosenWord, parent:  this.chosenWordRoot);
                object val_9 = this.chosenWord.GetComponent<System.Object>();
                if(this.chosenWord != 0)
            {
                    this.chosenWord.Setup(letter:  -1930531024, myIndex:  0);
            }
            else
            {
                    this.chosenWord.Setup(letter:  -1930531024, myIndex:  0);
            }
            
                UnityEngine.GameObject val_10 = this.chosenWord.gameObject;
                this.chosenWord.SetActive(value:  false);
                this.chosenLetters.Add(item:  this.chosenWord);
                val_13 = val_13 + 1;
            }
            while(val_13 != 5);
            
            this.initialized = true;
        }
        public void StartLevel(SLC.Minigames.Ladder.WordLadderLevel currentLevel)
        {
            string val_3;
            if(this.initialized == false)
            {
                    this.initialized = this;
                this.Initialize();
            }
            
            this.SetupChosenLetters(currentLevel:  currentLevel);
            UnityEngine.GameObject val_1 = this.Arrow.gameObject;
            this.Arrow.SetActive(value:  false);
            this.RestChosenLetters();
            this.checkMark.SetActive(value:  false);
            this.crossMark.SetActive(value:  false);
            this.RestFoundWord();
            this.HideKeyboard();
            if(currentLevel != 0)
            {
                    val_3 = currentLevel.startingWord;
            }
            else
            {
                    val_3 = 0;
            }
            
            string val_2 = System.String.Format(format:  947508592, arg0:  0, arg1:  currentLevel.requiredWord);
            this.container.SetActive(value:  true);
        }
        private void RestFoundWord()
        {
            var val_1 = 0;
            goto label_1;
            label_6:
            val_1 = 1;
            label_1:
            if(val_1 < this.foundWords[val_1])
            {
                goto label_6;
            }
        
        }
        public void RestChosenLetters()
        {
            var val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_3.SetSpriteAndText(s:  this.unChosenLetterSprite, textSize:  100);
            goto label_4;
            label_2:
            Dispose();
        }
        public void LetterChosen(int clickedIndex)
        {
            var val_10;
            UnityEngine.Sprite val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = 0;
            goto label_1;
            label_9:
            if(true <= val_10)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + 0;
            if(clickedIndex == val_10)
            {
                    val_11 = this.chosenLetterSprite;
                val_12 = 90;
            }
            else
            {
                    val_11 = this.unChosenLetterSprite;
                val_12 = 100;
            }
            
            (0 + 0) + 16.SetSpriteAndText(s:  val_11, textSize:  100);
            val_10 = 1;
            label_1:
            if(val_10 < ((0 + 0) + 16))
            {
                goto label_9;
            }
            
            if(((0 + 0) + 16) <= clickedIndex)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (clickedIndex << 2);
            this.chosenLetter = (0 + (clickedIndex) << 2) + 16;
            UnityEngine.Transform val_1 = (0 + (clickedIndex) << 2) + 16.transform;
            UnityEngine.Vector3 val_2 = position;
            System.Collections.IEnumerator val_4 = this.MoveArrow(x:  val_2.x);
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  948117744);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = public static SLC.Minigames.Ladder.WordLadderController MonoSingleton<SLC.Minigames.Ladder.WordLadderController>::get_Instance();
            System.Collections.Generic.List<System.String> val_7 = GenerateLettersForTappedLetter(index:  clickedIndex);
            val_14 = 4;
            goto label_17;
            label_27:
            if(val_13 <= this.unChosenLetterSprite)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_8 = Contains(item:  406888448);
            val_13 = val_8;
            if(val_8 <= this.unChosenLetterSprite)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.GameObject val_9 = 2621443.gameObject;
            if(val_13 == false)
            {
                    0 = 0;
            }
            
            if(val_13 == true)
            {
                    0 = 1;
            }
            
            2621443.SetActive(value:  true);
            val_14 = 5;
            label_17:
            if((val_14 - 4) < 2621443)
            {
                goto label_27;
            }
        
        }
        private System.Collections.IEnumerator MoveArrow(float x)
        {
            typeof(WordLadderUIController.<MoveArrow>d__24).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(WordLadderUIController.<MoveArrow>d__24).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(WordLadderUIController.<MoveArrow>d__24).__il2cppRuntimeField_14 = R1;
        }
        public void SubmitLetter(SLC.Minigames.Ladder.WordLadderKeyboardLetter item)
        {
            this.itemClicked = item;
            UnityEngine.GameObject val_1 = this.Arrow.gameObject;
            this.Arrow.SetActive(value:  false);
            string val_2 = this.CalculateWord(toCalculate:  this.itemClicked);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SubmitWord(chosenWord:  948386800);
        }
        private System.Collections.IEnumerator FlydLadderKeyboardLetter(SLC.Minigames.Ladder.WordLadderKeyboardLetter itemClicked)
        {
            object val_1 = new System.Object();
            typeof(WordLadderUIController.<FlydLadderKeyboardLetter>d__26).__il2cppRuntimeField_8 = 0;
        }
        private string CalculateWord(SLC.Minigames.Ladder.WordLadderKeyboardLetter toCalculate)
        {
            var val_6;
            var val_7;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_6 = 4;
            goto label_1;
            label_19:
            if(val_1 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.GameObject val_2 = 2621443.gameObject;
            bool val_3 = 2621443.activeSelf;
            if(val_3 == false)
            {
                goto label_6;
            }
            
            if(val_3 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_4 = UnityEngine.Object.op_Equality(x:  2621443, y:  this.chosenLetter);
            if(val_4 == false)
            {
                goto label_11;
            }
            
            if(toCalculate != 0)
            {
                goto label_13;
            }
            
            goto label_13;
            label_11:
            if(val_4 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = 406888448;
            label_13:
            System.Text.StringBuilder val_5 = Append(value:  406888448);
            label_6:
            val_6 = 5;
            label_1:
            if((val_6 - 4) < val_1)
            {
                goto label_19;
            }
            
            if(val_1 == 0)
            {
                
            }
        
        }
        public void ToggleUI(bool state)
        {
            this.container.SetActive(value:  state);
        }
        public void ValidWord(SLC.Minigames.Ladder.WordLadderLevel currentLevel)
        {
            float val_5;
            float val_6;
            float val_11;
            float val_12;
            SLC.Minigames.Ladder.WordLadderLevel val_13;
            SLC.Minigames.Ladder.WordLadderKeyboardLetter val_14;
            val_13 = currentLevel;
            if(new System.Object() != 0)
            {
                    typeof(WordLadderUIController.<>c__DisplayClass29_0).__il2cppRuntimeField_8 = this;
                typeof(WordLadderUIController.<>c__DisplayClass29_0).__il2cppRuntimeField_C = val_13;
            }
            else
            {
                    mem[8] = this;
                mem[12] = val_13;
                val_13 = mem[12];
            }
            
            this.UpdateFoundWords(currentLevel:  val_13);
            this.HideKeyboard();
            UnityEngine.Transform val_2 = this.chosenLetter.transform;
            UnityEngine.Vector3 val_3 = position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 6.837928E-05f});
            val_14 = this.itemClicked;
            if(val_14 != 0)
            {
                
            }
            else
            {
                    val_14 = this.itemClicked;
                if(val_14 == 0)
            {
                    val_14 = 0;
            }
            
            }
            
            UnityEngine.Transform val_7 = val_14.transform;
            UnityEngine.Vector3 val_8 = position;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 6.837913E-05f});
            System.Action val_10 = new System.Action(object:  449785856, method:  new IntPtr(948909104));
            this.FlyKeyBoardLetter.setUp(letter:  R8, posStart:  new UnityEngine.Vector2() {x = val_11, y = val_12}, posStop:  new UnityEngine.Vector2() {x = val_6, y = val_5}, callback:  null);
            this.chosenLetter = 0;
            this.itemClicked = 0;
        }
        public void LevelComplete(bool victory)
        {
            this.HideKeyboard();
            this.checkMark.SetActive(value:  victory);
            this.crossMark.SetActive(value:  victory ^ 1);
        }
        public void WordAlreadyUsed(string usedWord)
        {
        
        }
        private void UpdateFoundWords(SLC.Minigames.Ladder.WordLadderLevel currentLevel)
        {
            System.Collections.Generic.Queue<System.String> val_1 = new System.Collections.Generic.Queue<System.String>(collection:  currentLevel.ladder = currentLevel.ladder);
            UnityEngine.UI.Text[] val_3 =  - 4;
            if(null != 0)
            {
                    return;
            }
        
        }
        private void HideKeyboard()
        {
            goto label_1;
            label_12:
            if(true <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.GameObject val_1 = 2621443.gameObject;
            bool val_2 = 2621443.activeSelf;
            if(val_2 != false)
            {
                    if(val_2 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.GameObject val_3 = 2621443.gameObject;
                2621443.SetActive(value:  false);
            }
            
            4 = 5;
            label_1:
            if((4 - 4) < 2621443)
            {
                goto label_12;
            }
        
        }
        private void SetupChosenLetters(SLC.Minigames.Ladder.WordLadderLevel currentLevel)
        {
            UnityEngine.Sprite val_6;
            var val_7 = 4;
            do
            {
                int val_1 = val_7 - 4;
                if(0 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = 2621443;
                if(val_1 > (currentLevel.startingWord.m_stringLength - 1))
            {
                    UnityEngine.GameObject val_3 = val_6.gameObject;
                val_6.SetActive(value:  false);
            }
            else
            {
                    string val_5 = currentLevel.chosenWord.Chars[val_1].ToString();
                val_6.Setup(letter:  949744234, myIndex:  val_1);
                if(val_6 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.GameObject val_6 = 2621443.gameObject;
                2621443.SetActive(value:  true);
                if(2621443 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = this.unChosenLetterSprite;
                2621443.SetSpriteAndText(s:  val_6, textSize:  100);
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 != 9);
        
        }
        public WordLadderUIController()
        {
        
        }
    
    }

}
