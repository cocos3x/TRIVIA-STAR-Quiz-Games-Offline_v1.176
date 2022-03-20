using UnityEngine;

namespace SLC.Minigames.WordQuiz
{
    public class WordQuizUIController : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject letterTilePrefab;
        private SLC.Minigames.MinigamesCheckpointSlider minigamesCheckpointSlider;
        private TMPro.TMP_Text description;
        private UnityEngine.GameObject checkMarkCorrect;
        private UnityEngine.GameObject checkMarkWrong;
        private UnityEngine.GameObject answerGroup;
        private UnityEngine.GameObject tutorialText;
        private UnityEngine.UI.GridLayoutGroup keyboardArea;
        private UnityEngine.GameObject FTUXHand;
        private UnityEngine.Vector3 FTUXHandOffset;
        private UnityEngine.UI.Button hintBtn;
        private TMPro.TMP_Text hintCostText;
        private UnityEngine.GameObject pauseCanvas;
        private UnityEngine.CanvasGroup mainCanvasGroup;
        private System.Collections.Generic.List<SLC.Minigames.WordQuiz.WordQuizLetterTile> answerTiles;
        private System.Collections.Generic.List<SLC.Minigames.WordQuiz.WordQuizLetterTile> keyboardTiles;
        
        // Properties
        private string CurrentAnswer { get; }
        
        // Methods
        private string get_CurrentAnswer()
        {
            List.Enumerator<T> val_2 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_5 = Append(value:  val_4 + 12);
            goto label_6;
            label_2:
            Dispose();
            if(new System.Text.StringBuilder() != 0)
            {
                    return;
            }
        
        }
        private void Start()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  930323952, method:  new IntPtr(930298928));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70, b:  7454720);
            val_4 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70 = val_4;
        }
        private void OnDestroy()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  930435952, method:  new IntPtr(930298928));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70, value:  7454720);
            val_4 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70 = val_4;
        }
        public void HideUIForPopup(bool showingPopup)
        {
            if(showingPopup == true)
            {
                    1f = 0;
            }
            
            this.mainCanvasGroup.alpha = 0f;
        }
        public void InitializeLevel(SLC.Minigames.WordQuiz.WordQuizLevel level)
        {
            int val_37;
            UnityEngine.UI.GridLayoutGroup val_38;
            var val_39;
            UnityEngine.UI.GridLayoutGroup val_40;
            UnityEngine.UI.GridLayoutGroup val_41;
            this.ClearUI();
            this.answerTiles.Clear();
            this.keyboardTiles.Clear();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_2 = hintCost;
            string val_3 = ToString();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_5 = GetRandomizedLetters(level:  level);
            System.Collections.Generic.List<T> val_6 = GetRange(index:  0, count:  level.word.m_stringLength);
            PluginExtension.Shuffle<UnityEngine.Sprite>(list:  -848339584, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            if((level.keyboardLetterNum - 8) < 9)
            {
                    if(1 != ((341) >> (uint)(ushort)(((level.keyboardLetterNum - 8)) & 0xFFFF)))
            {
                goto label_12;
            }
            
            }
            
            if(level.keyboardLetterNum == 18)
            {
                    val_37 = 6;
            }
            
            goto label_13;
            label_12:
            var val_37 = 22983092;
            val_37 = 9148988 + val_37;
            val_37 = mem[(9148988 + 22983092) + ((level.keyboardLetterNum - 8)) << 2];
            val_37 = (9148988 + 22983092) + ((level.keyboardLetterNum - 8)) << 2;
            label_13:
            this.keyboardArea.constraintCount = val_37;
            val_38 = this.keyboardArea;
            if(this.keyboardArea == 0)
            {
                    val_38 = this.keyboardArea;
            }
            
            if(this.keyboardArea.m_ConstraintCount >= 8)
            {
                    1124401152 = 17126;
                1124401152 = 1122369536;
            }
            
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  null, y:  null);
            val_38.cellSize = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            UnityEngine.Transform val_9 = this.keyboardArea.transform;
            val_39 = 0;
            float val_38 = (float)this.keyboardArea.m_ConstraintCount;
            val_38 = ((float)public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_C) / val_38;
            int val_10 = UnityEngine.Mathf.CeilToInt(f:  val_38);
            if(this.keyboardArea != 0)
            {
                    if(null == null)
            {
                goto label_23;
            }
            
            }
            
            if(this.keyboardArea != 0)
            {
                    label_23:
                if(null != null)
            {
                    val_39 = 0;
            }
            else
            {
                    val_39 = this.keyboardArea;
            }
            
            }
            
            UnityEngine.Rect val_11 = val_8.x.rect;
            float val_12 = height;
            val_40 = this.keyboardArea;
            if(this.keyboardArea == 0)
            {
                    val_40 = this.keyboardArea;
                if(val_40 == 0)
            {
                goto label_93;
            }
            
            }
            
            val_41 = this.keyboardArea;
            int val_14 = val_10 - 1;
            var val_39 = top;
            val_39 = 930768712 - (float)val_39;
            float val_40 = (float)bottom;
            val_40 = val_39 - val_40;
            float val_16 = val_40 / (float)val_10;
            if(this.keyboardArea > 0)
            {
                    UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_40, y:  val_11.m_YMin);
                this.keyboardArea.cellSize = new UnityEngine.Vector2() {x = val_17.x, y = val_17.y};
            }
            
            var val_41 = 0;
            object val_18 = new System.Object();
            typeof(WordQuizUIController.<>c__DisplayClass21_0).__il2cppRuntimeField_C = this;
            UnityEngine.Transform val_19 = this.keyboardArea.transform;
            object val_20 = UnityEngine.Object.Instantiate<System.Object>(original:  this.letterTilePrefab, parent:  this.keyboardArea);
            object val_21 = this.letterTilePrefab.GetComponent<System.Object>();
            typeof(WordQuizUIController.<>c__DisplayClass21_0).__il2cppRuntimeField_8 = this.letterTilePrefab;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_41 = null;
            val_41 = new UnityEngine.Events.UnityAction(object:  448667648, method:  new IntPtr(930716848));
            this.letterTilePrefab + 16 + 172.AddListener(call:  162246656);
            mem2[0] = val_41;
            this.keyboardTiles.Add(item:  typeof(WordQuizUIController.<>c__DisplayClass21_0).__il2cppRuntimeField_8);
            val_41 = val_41 + 1;
            List.Enumerator<T> val_24 = val_17.x.GetEnumerator();
            label_66:
            if(MoveNext() == false)
            {
                goto label_53;
            }
            
            object val_26 = new System.Object();
            typeof(WordQuizUIController.<>c__DisplayClass21_1).__il2cppRuntimeField_C = this;
            UnityEngine.Transform val_27 = this.answerGroup.transform;
            object val_28 = UnityEngine.Object.Instantiate<System.Object>(original:  this.letterTilePrefab, parent:  this.answerGroup);
            object val_29 = this.letterTilePrefab.GetComponent<System.Object>();
            typeof(WordQuizUIController.<>c__DisplayClass21_1).__il2cppRuntimeField_8 = this.letterTilePrefab;
            UnityEngine.Events.UnityAction val_30 = new UnityEngine.Events.UnityAction(object:  448720896, method:  new IntPtr(930726064));
            this.letterTilePrefab.AddListener(call:  162246656);
            typeof(WordQuizUIController.<>c__DisplayClass21_1).__il2cppRuntimeField_8.SetHiddenState(hidden:  true);
            this.letterTilePrefab + 16.interactable = false;
            this.answerTiles.Add(item:  typeof(WordQuizUIController.<>c__DisplayClass21_1).__il2cppRuntimeField_8);
            goto label_66;
            label_53:
            Dispose();
            label_96:
            twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.tutorialText.SetActive(value:  ShouldShowFTUX());
            twelvegigs.Autopilot.AutopilotManager val_33 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_34 = ShouldShowFTUX();
            this.tutorialText.SetActive(value:  val_34);
            UnityEngine.GameObject val_35 = this.hintBtn.gameObject;
            if(val_34 != false)
            {
                    this.hintBtn.SetActive(value:  false);
                twelvegigs.Autopilot.AutopilotManager val_36 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ShowFTUX();
            }
            else
            {
                    this.hintBtn.SetActive(value:  true);
            }
            
            this.minigamesCheckpointSlider.UpdateUI();
            return;
            label_93:
            if(0 != 1)
            {
                goto label_94;
            }
            
            Dispose();
            if(null == 0)
            {
                goto label_96;
            }
            
            goto label_96;
            label_94:
        }
        public void OnTileSelected(SLC.Minigames.WordQuiz.WordQuizLetterTile tile)
        {
            var val_25;
            var val_26;
            var val_27;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(((MonoSingleton<T>.__il2cppRuntimeField_cctor_finished + (public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField + 16) == 0)
            {
                
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance()) != 0)
            {
                    val_25 = public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance();
            }
            else
            {
                    val_25 = 20;
                val_26 = ;
            }
            
            mem[20] = 3;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(((MonoSingleton<T>.__il2cppRuntimeField_cctor_finished + ((public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeFiel + 16) != 0)
            {
                    (MonoSingleton<T>.__il2cppRuntimeField_cctor_finished + ((public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeFiel + 16 + 16.interactable = true;
                mem2[0] = tile.keyboardIndex;
                twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                mem2[0] = (public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_14 - 1);
                (MonoSingleton<T>.__il2cppRuntimeField_cctor_finished + ((public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeFiel + 16.SetHiddenState(hidden:  false);
                tile.canvasGroup.alpha = null;
                tile.btn.interactable = false;
                tile.submitted = true;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_15 = this.CurrentAnswer;
            val_27 = this;
            CheckAnswerCorrect(answer:  931036144);
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(ShouldShowFTUX() != false)
            {
                    string val_18 = this.CurrentAnswer;
                twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ShowFTUX();
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                StopAllCoroutines();
                this.HideFTUXHand();
            }
            
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
        }
        public void OnTileDeselected(SLC.Minigames.WordQuiz.WordQuizLetterTile tile, bool fromHint = False)
        {
            int val_10;
            var val_11;
            val_10 = tile.answerIndex;
            val_11 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_14 = tile + 56;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(ShouldShowFTUX() != false)
            {
                    string val_5 = this.CurrentAnswer;
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ShowFTUX();
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                StopAllCoroutines();
                this.HideFTUXHand();
            }
            
            if(fromHint != false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  1, volumeScale:  null);
        }
        public void ShowFTUXHand(SLC.Minigames.WordQuiz.WordQuizLetterTile tile)
        {
            UnityEngine.Transform val_1 = this.FTUXHand.transform;
            UnityEngine.Transform val_2 = tile.transform;
            UnityEngine.Vector3 val_3 = position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 1.559772E-05f}, b:  new UnityEngine.Vector3() {y = this.FTUXHandOffset});
            this.FTUXHand.position = new UnityEngine.Vector3();
            this.FTUXHand.SetActive(value:  true);
        }
        public void HideFTUXHand()
        {
            this.FTUXHand.SetActive(value:  false);
        }
        public void DisableOtherLetterTiles(SLC.Minigames.WordQuiz.WordQuizLetterTile currentFTUXLetterTile)
        {
            var val_2 = 0;
            goto label_1;
            label_9:
            if(true <= val_2)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            (0 + 0) + 16 + 16.interactable = UnityEngine.Object.op_Equality(x:  (0 + 0) + 16, y:  currentFTUXLetterTile);
            val_2 = 1;
            label_1:
            if(val_2 < ((0 + 0) + 16 + 16))
            {
                goto label_9;
            }
        
        }
        public SLC.Minigames.WordQuiz.WordQuizLetterTile GetNextLetterInFTUX(int index)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            goto label_1;
            label_14:
            if(true <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            index = index + 0;
            val_6 = mem[(index + 0) + 16];
            val_6 = (index + 0) + 16;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_3 = public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_10 + 8.Chars[index].ToString();
            if((System.String.op_Equality(a:  931711082, b:  (index + 0) + 16 + 12)) != false)
            {
                    if(((index + 0) + 16 + 61) == 0)
            {
                    return;
            }
            
            }
            
            val_5 = 1;
            label_1:
            if(val_5 < ((index + 0) + 16 + 61))
            {
                goto label_14;
            }
            
            val_6 = 0;
        }
        public void UpdateFailedLevelUI(bool on)
        {
            this.checkMarkWrong.SetActive(value:  on);
        }
        public void UpdateSuccessLevelUI()
        {
            this.checkMarkCorrect.SetActive(value:  true);
        }
        public void ShowHint()
        {
            int val_10;
            var val_11;
            object val_1 = new System.Object();
            if(val_1 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.OnTileDeselected(tile:  2621443, fromHint:  true);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_10 = mem[public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 16];
            val_10 = public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 16;
            if(val_10 == 1)
            {
                    return;
            }
            
            var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_10 = val_10 + (val_10 << 2);
            if(val_1 != 0)
            {
                    val_11 = val_1;
                typeof(WordQuizUIController.<>c__DisplayClass30_0).__il2cppRuntimeField_8 = (0 + (public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 16) << 2) + 16;
            }
            else
            {
                    val_11 = 8;
                mem[8] = (0 + (public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 16) << 2) + 16;
            }
            
            mem2[0] = 1;
            mem[8].SetHiddenState(hidden:  false);
            mem[8].SetHinted();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_6 = public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_10 + 8.Chars[val_10].ToString();
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance().__il2cppRuntimeField_18.RemoveAt(index:  0);
            val_10 = null;
            val_10 = new System.Predicate<ZooTile>(object:  448774144, method:  new IntPtr(932071984));
            SLC.Minigames.WordQuiz.WordQuizLetterTile val_9 = this.keyboardTiles.Find(match:  8040448);
            alpha = null;
            interactable = false;
            mem2[0] = 1;
        }
        private void OnEnable()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  932232560, method:  new IntPtr(932207536));
            this.hintBtn.m_OnClick.AddListener(call:  162246656);
        }
        public void OnClickPause()
        {
            this.pauseCanvas.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
        }
        public void OnClickQuit()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            this.pauseCanvas.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            QuitGame();
        }
        private void OnClickHintBtn()
        {
            int val_5;
            int val_15;
            var val_21;
            var val_22;
            var val_23;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_2 = CurrencyController.GetBalance();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_4 = hintCost;
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_5})) == false)
            {
                goto label_10;
            }
            
            Player val_7 = App.Player;
            val_21 = 2621448;
            if(val_21 == 0)
            {
                goto label_14;
            }
            
            val_22 = 35143856;
            goto label_15;
            label_10:
            var val_20 = 26462181;
            val_20 = 9163880 + val_20;
            if(val_20 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_23 = null;
            val_23 = null;
            PurchaseProxy.currentPurchasePoint = 23;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_9 = ShowUGUIMonolith<System.Object>(showNext:  true);
            Init(outOfCredits:  true, onCloseAction:  0);
            return;
            label_14:
            val_21 = 52;
            val_22 = 6;
            label_15:
            mem[52] = 7;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_11 = hintCost;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_13 = CurrentMinigameName;
            string val_14 = System.String.Format(format:  932569136, arg0:  -1745297776);
            bool val_16 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_15}, source:  "MG {0} HINT", externalParams:  0, animated:  false);
            this.ShowHint();
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_18 = this.CurrentAnswer;
            CheckAnswerCorrect(answer:  932593232);
            twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
        }
        private void ClearUI()
        {
            UnityEngine.Transform val_1 = this.keyboardArea.transform;
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.keyboardArea);
            UnityEngine.Transform val_2 = this.answerGroup.transform;
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.answerGroup);
            this.tutorialText.SetActive(value:  false);
            this.checkMarkWrong.SetActive(value:  false);
            this.checkMarkCorrect.SetActive(value:  false);
        }
        private int GetKeyboardAreaCol(int keyboardLetterNumber)
        {
            if((keyboardLetterNumber - 8) < 9)
            {
                    if(1 != ((341) >> (uint)(ushort)(((keyboardLetterNumber - 8)) & 0xFFFF)))
            {
                goto label_1;
            }
            
            }
            
            if(keyboardLetterNumber == 18)
            {
                    7 = 6;
            }
            
            return 6;
            label_1:
            var val_2 = 22972120;
            val_2 = 9159960 + val_2;
            return (int)(9159960 + 22972120) + ((keyboardLetterNumber - 8)) << 2;
        }
        public WordQuizUIController()
        {
            this.answerTiles = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.keyboardTiles = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
    
    }

}
