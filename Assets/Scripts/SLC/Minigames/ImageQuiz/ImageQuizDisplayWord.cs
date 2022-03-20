using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizDisplayWord : MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup containerCanvasGroup;
        private UnityEngine.UI.LayoutElement containerLayoutElement;
        private SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter letterTilePrefab;
        private UnityEngine.UI.GridLayoutGroup lettersGridLayoutGroup;
        private float preferredCellSize;
        private UnityEngine.RectTransform currentInputIndicator;
        private DG.Tweening.DOTweenAnimation[] currentInputIndicatorTween;
        private SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter[] letterTiles;
        private SLC.Minigames.ImageQuiz.ImageQuizLetterButton[] sourceLetterButton;
        private string[] currentInput;
        private string[] givenLetters;
        private int numberOfLetters;
        private int caretPosition;
        private const float BACK_TRACK_DELAY = 0.033;
        public System.Action OnInputProcessed;
        private bool <AllowInput>k__BackingField;
        private bool <AllowErase>k__BackingField;
        
        // Properties
        public int CaretPosition { get; }
        public bool AllowInput { get; set; }
        public bool AllowErase { get; set; }
        public int FilledLettersCount { get; }
        
        // Methods
        public int get_CaretPosition()
        {
            return (int)this.caretPosition;
        }
        public bool get_AllowInput()
        {
            return (bool)this.<AllowInput>k__BackingField;
        }
        public void set_AllowInput(bool value)
        {
            this.<AllowInput>k__BackingField = value;
        }
        public bool get_AllowErase()
        {
            return (bool)this.<AllowErase>k__BackingField;
        }
        public void set_AllowErase(bool value)
        {
            this.<AllowErase>k__BackingField = value;
        }
        public int get_FilledLettersCount()
        {
            var val_2;
            var val_3;
            val_2 = 0;
            val_3 = 0;
            goto label_0;
            label_4:
            bool val_1 = System.String.IsNullOrEmpty(value:  this.currentInput[val_2]);
            val_1 = val_1 ^ 1;
            val_2 = 1;
            val_3 = val_3 + val_1;
            label_0:
            if(val_2 < val_1)
            {
                goto label_4;
            }
            
            return (int)val_3;
        }
        private void Awake()
        {
            T[] val_1 = this.currentInputIndicator.GetComponentsInChildren<System.Object>();
            this.currentInputIndicatorTween = this.currentInputIndicator;
        }
        public void Initialize(int _numberOfLetters)
        {
            float val_4;
            UnityEngine.Transform val_16;
            var val_17;
            var val_18;
            UnityEngine.Object val_19;
            SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter[] val_20;
            var val_21;
            var val_22;
            UnityEngine.Transform val_1 = this.currentInputIndicator.transform;
            UnityEngine.Transform val_2 = this.currentInputIndicator.parent;
            this.currentInputIndicator.SetParent(p:  1060851328);
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            this.currentInputIndicator.rotation = new UnityEngine.Quaternion() {w = val_4};
            UnityEngine.Transform val_5 = this.lettersGridLayoutGroup.transform;
            System.Collections.IEnumerator val_6 = this.lettersGridLayoutGroup.GetEnumerator();
            label_29:
            val_16 = 0;
            val_16 = val_16 + 1;
            val_17 = this.lettersGridLayoutGroup;
            if(this.lettersGridLayoutGroup == 0)
            {
                goto label_13;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = this.lettersGridLayoutGroup;
            if(this.lettersGridLayoutGroup != 0)
            {
                    val_19 = 0;
            }
            else
            {
                    val_19 = 0;
            }
            
            UnityEngine.GameObject val_9 = gameObject;
            UnityEngine.Object.Destroy(obj:  null);
            goto label_29;
            label_13:
            val_20 = 0;
            if(this.lettersGridLayoutGroup != 0)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_21 = this.lettersGridLayoutGroup;
            }
            
            this.numberOfLetters = _numberOfLetters;
            this.givenLetters = null;
            this.letterTiles = null;
            this.sourceLetterButton = null;
            val_22 = 4;
            goto label_36;
            label_48:
            val_20 = this.letterTiles;
            UnityEngine.Transform val_11 = this.lettersGridLayoutGroup.transform;
            val_16 = this.lettersGridLayoutGroup;
            object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  this.letterTilePrefab, parent:  val_16);
            val_20[0] = this.letterTilePrefab;
            SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter val_19 = this.letterTiles[0];
            val_19.Initialize(indexInWord:  0);
            val_22 = 5;
            label_36:
            if((val_22 - 4) < val_19)
            {
                goto label_48;
            }
            
            this.currentInput = null;
            this.<AllowInput>k__BackingField = true;
            this.<AllowErase>k__BackingField = true;
            this.caretPosition = 0;
            System.Collections.IEnumerator val_14 = this.RepositionMoveIndicator();
            UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  1060851328);
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.containerCanvasGroup, endValue:  val_3.x, duration:  val_3.y);
        }
        private System.Collections.IEnumerator RepositionMoveIndicator()
        {
            object val_1 = new System.Object();
            typeof(ImageQuizDisplayWord.<RepositionMoveIndicator>d__29).__il2cppRuntimeField_8 = 0;
            typeof(ImageQuizDisplayWord.<RepositionMoveIndicator>d__29).__il2cppRuntimeField_10 = this;
        }
        protected void OnRectTransformDimensionsChange()
        {
            UnityEngine.Vector2 val_1 = DetermineCellSize();
            this.lettersGridLayoutGroup.cellSize = new UnityEngine.Vector2() {x = R4, y = R5};
        }
        public void ShowAnswer()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.ImageQuiz.ImageQuizLevelInfo val_2 = GetCurrentQuizLevel();
            if((System.String.IsNullOrEmpty(value:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_8)) == true)
            {
                    return;
            }
            
            val_6 = 4;
            goto label_6;
            label_16:
            string val_5 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_8.Chars[R7].ToString();
            this.letterTiles[0].SetLetter(letterString:  1061441526);
            SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter val_8 = this.letterTiles[0];
            float val_9 = (float)R7;
            val_9 = val_9 * 0.05f;
            val_8.PlayAnimation(anim:  3, animationDelay:  val_9);
            val_6 = 5;
            label_6:
            if((val_6 - 4) < val_8)
            {
                goto label_16;
            }
        
        }
        public void AddInput(string inputLetter, SLC.Minigames.ImageQuiz.ImageQuizLetterButton originatingButton)
        {
            int val_2 = 35640287;
            if((this.<AllowInput>k__BackingField) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_2 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance();
            val_2 = this.caretPosition;
            if(val_2 < 0)
            {
                    return;
            }
            
            this.currentInput[this.caretPosition] = inputLetter;
            this.sourceLetterButton[this.caretPosition] = originatingButton;
            this.letterTiles[this.caretPosition].SetLetter(letterString:  inputLetter);
            this.letterTiles[this.caretPosition].PlayAnimation(anim:  0, animationDelay:  null);
            this.IncrementInputCursor();
            if(this.OnInputProcessed != 0)
            {
                    this.OnInputProcessed.Invoke();
            }
            
            this.RefreshUI();
        }
        private System.Collections.IEnumerator RefreshUIAfterAnimation()
        {
            object val_1 = new System.Object();
            typeof(ImageQuizDisplayWord.<RefreshUIAfterAnimation>d__33).__il2cppRuntimeField_8 = 0;
            typeof(ImageQuizDisplayWord.<RefreshUIAfterAnimation>d__33).__il2cppRuntimeField_10 = this;
        }
        private bool IsTilesAnimating()
        {
            var val_2 = 0;
            do
            {
                if(val_2 >= this)
            {
                    return false;
            }
            
                SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter val_1 = this.letterTiles[val_2];
                val_2 = val_2 + 1;
            }
            while((this.letterTiles[0x0][0].<IsAnimating>k__BackingField) == false);
            
            return true;
        }
        private void RefreshUI()
        {
            this.MoveIndicator(inputPos:  this.caretPosition);
            if(this.FilledLettersCount != this.numberOfLetters)
            {
                    return;
            }
            
            R4.SubmitCurrentWord();
        }
        public string GetCurrentInput()
        {
            var val_2;
            int val_3;
            val_2 = 0;
            val_3 = System.String.alignConst;
            goto label_1;
            label_5:
            string val_1 = val_3 + this.currentInput[val_2];
            val_2 = 1;
            val_3 = val_3;
            label_1:
            if(val_2 < val_3)
            {
                goto label_5;
            }
        
        }
        public bool IsInputOnGivenLetter(string letter)
        {
            if(this.caretPosition < 0)
            {
                    return false;
            }
            
            if(this.caretPosition >= this)
            {
                    return false;
            }
            
            return System.String.op_Equality(a:  this.givenLetters[this.caretPosition], b:  letter);
        }
        private void SubmitCurrentWord()
        {
            if((this.<AllowInput>k__BackingField) == false)
            {
                    return;
            }
            
            this.<AllowInput>k__BackingField = false;
            UnityEngine.GameObject val_1 = this.currentInputIndicator.gameObject;
            this.currentInputIndicator.SetActive(value:  false);
            System.Collections.IEnumerator val_2 = this.SubmittingWord();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  1063245184);
        }
        private System.Collections.IEnumerator SubmittingWord()
        {
            object val_1 = new System.Object();
            typeof(ImageQuizDisplayWord.<SubmittingWord>d__39).__il2cppRuntimeField_8 = 0;
            typeof(ImageQuizDisplayWord.<SubmittingWord>d__39).__il2cppRuntimeField_10 = this;
        }
        private void IncrementInputCursor()
        {
            int val_3;
            if((this.caretPosition + 1) >= this.caretPosition)
            {
                    val_3 = 0;
            }
            
            label_3:
            bool val_2 = this.IsLetterOccupied(letterIndex:  0, includeGivens:  true);
            if(val_2 == false)
            {
                goto label_1;
            }
            
            val_3 = val_3 + 1;
            if(val_3 >= val_2)
            {
                    val_3 = 0;
            }
            
            if(val_3 != this.caretPosition)
            {
                goto label_3;
            }
            
            label_1:
            this.caretPosition = val_3;
        }
        private void MoveIndicator(int inputPos)
        {
            float val_5;
            float val_7;
            float val_8;
            float val_10;
            float val_11;
            float val_13;
            float val_14;
            float val_16;
            float val_17;
            float val_19;
            float val_20;
            SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter[] val_21;
            var val_22;
            val_21 = 35640291;
            if(inputPos < 0)
            {
                goto label_1;
            }
            
            val_21 = this.letterTiles;
            if(true >= inputPos)
            {
                goto label_3;
            }
            
            label_1:
            UnityEngine.GameObject val_1 = this.currentInputIndicator.gameObject;
            this.currentInputIndicator.SetActive(value:  false);
            return;
            label_3:
            val_22 = 0;
            goto label_6;
            label_11:
            val_22 = 1;
            label_6:
            if(val_22 < this.currentInputIndicatorTween[val_22])
            {
                goto label_11;
            }
            
            UnityEngine.GameObject val_2 = this.currentInputIndicator.gameObject;
            this.currentInputIndicator.SetActive(value:  true);
            SLC.Minigames.ImageQuiz.ImageQuizDisplayLetter val_22 = this.letterTiles[inputPos];
            UnityEngine.Transform val_3 = val_22.transform;
            this.currentInputIndicator.SetParent(p:  val_22);
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            this.currentInputIndicator.rotation = new UnityEngine.Quaternion() {w = val_5};
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            this.currentInputIndicator.anchoredPosition = new UnityEngine.Vector2() {x = val_7, y = val_8};
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
            this.currentInputIndicator.anchorMin = new UnityEngine.Vector2() {x = val_10, y = val_11};
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.one;
            this.currentInputIndicator.anchorMax = new UnityEngine.Vector2() {x = val_13, y = val_14};
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.zero;
            this.currentInputIndicator.offsetMin = new UnityEngine.Vector2() {x = val_16, y = val_17};
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.zero;
            this.currentInputIndicator.offsetMax = new UnityEngine.Vector2() {x = val_19, y = val_20};
        }
        private UnityEngine.Vector2 DetermineCellSize()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_10 = 35640292;
            if((R1 + 40) != 0)
            {
                    R1 + 40 = mem[R1 + 40 + 12];
                R1 + 40 = R1 + 40 + 12;
                goto label_1;
            }
            
            val_12 = mem[R1 + 28];
            val_12 = R1 + 28;
            this = 0;
            mem[1152921514261011332] = 0;
            goto label_2;
            label_1:
            UnityEngine.GameObject val_1 = R1 + 16.gameObject;
            val_13 = 0;
            UnityEngine.Transform val_2 = R1 + 16.transform;
            if((R1 + 16) != 0)
            {
                    if((R1 + 16) == null)
            {
                goto label_6;
            }
            
            }
            
            if((R1 + 16) != 0)
            {
                goto label_7;
            }
            
            goto label_10;
            label_6:
            label_7:
            if((R1 + 16) != null)
            {
                    val_13 = 0;
            }
            else
            {
                    val_13 = R1 + 16;
            }
            
            label_10:
            UnityEngine.Rect val_3 = rect;
            float val_4 = width;
            val_11 = mem[R1 + 24];
            val_11 = R1 + 24;
            val_10 = mem[R1 + 40];
            val_10 = R1 + 40;
            float val_11 = (float)R1 + 24 + 12.left;
            var val_10 = R1 + 40 + 12;
            val_10 = val_10 - 1;
            val_11 = 1064217704 - val_11;
            val_11 = val_11 - ((float)R1 + 24 + 12.right);
            float val_7 = val_11 / ((float)R1 + 40 + 12);
            float val_8 = UnityEngine.Mathf.Min(a:  val_11, b:  val_3.m_YMin);
            val_12 = R1 + 28;
            this = 0;
            mem[1152921514261011332] = 0;
            label_2:
            this = new UnityEngine.Vector2(x:  val_8, y:  val_3.m_YMin);
            return new UnityEngine.Vector2() {x = val_8, y = val_3.m_YMin};
        }
        private void SetLetterTileSize(UnityEngine.Vector2 letterTileSize)
        {
            this.lettersGridLayoutGroup.cellSize = new UnityEngine.Vector2() {x = letterTileSize.x, y = letterTileSize.y};
        }
        public void EraseLetter(int letterIndex)
        {
            int val_10;
            var val_11;
            val_10 = letterIndex;
            val_11 = 35640293;
            if((this.<AllowErase>k__BackingField) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance();
            string val_2 = this.GetCurrentInput();
            val_11 = 1152921514261517951 - val_10;
            goto label_7;
            label_31:
            if((System.String.IsNullOrEmpty(value:  this.currentInput[val_10])) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  this.givenLetters[val_10])) != false)
            {
                    float val_12 = (float)val_11;
                val_12 = val_12 * 0.033f;
                val_12 = val_12 / (1.064736E+09f);
                this.letterTiles[val_10].PlayAnimation(anim:  2, animationDelay:  val_12);
                this.sourceLetterButton[val_10].ToggleButtonVisibility(isVisible:  true);
                this.givenLetters[val_10] = System.String.alignConst;
                this.currentInput[val_10] = System.String.alignConst;
            }
            
            }
            
            val_11 = val_11 - 1;
            val_10 = val_10 + 1;
            label_7:
            if(val_10 < (new System.Nullable<System.Int32>(value:  val_10)))
            {
                goto label_31;
            }
            
            this.caretPosition = val_6.HasValue;
            System.Collections.IEnumerator val_7 = this.RefreshUIAfterAnimation();
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  1064736384);
        }
        public void GiveLetterHint()
        {
            var val_4;
            RandomSet val_1 = null;
            val_4 = 0;
            val_1 = new RandomSet();
            goto label_1;
            label_7:
            if((System.String.IsNullOrEmpty(value:  this.givenLetters[val_4])) != false)
            {
                    add(item:  0, weight:  null);
            }
            
            val_4 = 1;
            label_1:
            if(val_4 < val_1)
            {
                goto label_7;
            }
            
            this.GiveLetterHint(letterIndex:  roll(unweighted:  false));
        }
        public void GiveLetterHint(int letterIndex)
        {
            var val_9;
            SLC.Minigames.ImageQuiz.ImageQuizLetterButton val_10;
            val_9 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.ImageQuiz.ImageQuizLevelInfo val_2 = GetCurrentQuizLevel();
            val_10 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance();
            if((this.<AllowInput>k__BackingField) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance();
            if(letterIndex < 0)
            {
                    return;
            }
            
            this.EraseLetter(letterIndex:  0);
            string val_5 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_8.Chars[letterIndex].ToString();
            this.currentInput[letterIndex] = ;
            this.givenLetters[letterIndex] = ;
            this.letterTiles[letterIndex].SetLetter(letterString:  1065652858);
            this.letterTiles[letterIndex].PlayAnimation(anim:  1, animationDelay:  null);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.ImageQuiz.ImageQuizLetterButton val_7 = public static SLC.Minigames.ImageQuiz.ImageQuizUIController MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizUIController>::get_Instance().__il2cppRuntimeField_18.GetButton(letter:  1065652858, getOnlyUnusedButtons:  true);
            this.sourceLetterButton[letterIndex] = public static SLC.Minigames.ImageQuiz.ImageQuizUIController MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizUIController>::get_Instance().__il2cppRuntimeField_18;
            val_10 = this.sourceLetterButton[letterIndex];
            if(val_10 != 0)
            {
                    val_10 = this.sourceLetterButton[letterIndex];
                val_10.ToggleButtonVisibility(isVisible:  false);
            }
            
            if(this.caretPosition == letterIndex)
            {
                    this.caretPosition = this;
                this.IncrementInputCursor();
            }
            
            this.RefreshUI();
        }
        public bool IsLetterGiven(int letterIndex)
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.givenLetters[letterIndex]);
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        public bool IsLetterOccupied(int letterIndex, bool includeGivens = True)
        {
            var val_2;
            bool val_1 = System.String.IsNullOrEmpty(value:  this.currentInput[letterIndex]);
            if(includeGivens != false)
            {
                    val_2 = 1;
                if(val_1 == false)
            {
                    return (bool)val_2;
            }
            
                return this.IsLetterGiven(letterIndex:  letterIndex);
            }
            
            val_2 = val_1 ^ 1;
            return (bool)val_2;
        }
        public void FadeVisible(bool state)
        {
            if(state == false)
            {
                    state = 0;
            }
            
            if(state == true)
            {
                    state = 1065353216;
            }
            
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.containerCanvasGroup, endValue:  null, duration:  null);
        }
        public void SetVisible(bool state)
        {
            if(state == true)
            {
                    state = 1065353216;
            }
            
            if(state == false)
            {
                    state = 0;
            }
            
            this.containerCanvasGroup.alpha = null;
        }
        public ImageQuizDisplayWord()
        {
            this.preferredCellSize = 160f;
        }
    
    }

}
