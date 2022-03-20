using UnityEngine;

namespace SLC.Minigames.WordChain
{
    public class WordChainUIController : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject letterTilePrefab;
        private UnityEngine.UI.Text levelText;
        private SLC.Minigames.MinigamesCheckpointSlider minigamesCheckpointSlider;
        private UnityEngine.UI.Text word1;
        private UnityEngine.UI.Text word2;
        private UnityEngine.GameObject checkMarkCorrect;
        private UnityEngine.GameObject checkMarkWrong;
        private UnityEngine.GameObject answerGroup;
        private UnityEngine.GameObject tutorialText;
        private UnityEngine.UI.GridLayoutGroup keyboardArea;
        private UnityEngine.GameObject FTUXHand;
        private UnityEngine.Vector3 FTUXHandOffset;
        private UnityEngine.UI.Button hintBtn;
        private System.Collections.Generic.List<SLC.Minigames.WordChain.WordChainLetterTile> answerTiles;
        private System.Collections.Generic.List<SLC.Minigames.WordChain.WordChainLetterTile> keyboardTiles;
        
        // Properties
        private string CurrentAnswer { get; }
        
        // Methods
        private string get_CurrentAnswer()
        {
            List.Enumerator<T> val_1 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            string val_4 = 1098586544 + val_3 + 12(val_3 + 12);
            goto label_5;
            label_2:
            Dispose();
        }
        public void InitializeLevel(SLC.Minigames.WordChain.WordChainLevel level)
        {
            int val_25;
            var val_26;
            this.ClearUI();
            this.answerTiles.Clear();
            this.keyboardTiles.Clear();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_2 = GetRandomizedLetters(level:  level);
            System.Collections.Generic.List<T> val_3 = GetRange(index:  0, count:  level.answer.m_stringLength);
            PluginExtension.Shuffle<UnityEngine.Sprite>(list:  963441168, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            if((level.keyboardLetterNum - 8) < 9)
            {
                    if(1 != ((341) >> (uint)(ushort)(((level.keyboardLetterNum - 8)) & 0xFFFF)))
            {
                goto label_10;
            }
            
            }
            
            if(level.keyboardLetterNum == 18)
            {
                    val_25 = 6;
            }
            
            goto label_11;
            label_10:
            var val_25 = 18786268;
            val_25 = 13345924 + val_25;
            val_25 = mem[(13345924 + 18786268) + ((level.keyboardLetterNum - 8)) << 2];
            val_25 = (13345924 + 18786268) + ((level.keyboardLetterNum - 8)) << 2;
            label_11:
            val_26 = 0;
            this.keyboardArea.constraintCount = val_25;
            List.Enumerator<T> val_11 = GetEnumerator();
            label_45:
            if(MoveNext() == false)
            {
                goto label_33;
            }
            
            object val_13 = new System.Object();
            typeof(WordChainUIController.<>c__DisplayClass17_1).__il2cppRuntimeField_C = this;
            UnityEngine.Transform val_14 = this.answerGroup.transform;
            object val_15 = UnityEngine.Object.Instantiate<System.Object>(original:  this.letterTilePrefab, parent:  this.answerGroup);
            object val_16 = this.letterTilePrefab.GetComponent<System.Object>();
            typeof(WordChainUIController.<>c__DisplayClass17_1).__il2cppRuntimeField_8 = this.letterTilePrefab;
            UnityEngine.Events.UnityAction val_17 = new UnityEngine.Events.UnityAction(object:  450850816, method:  new IntPtr(967263504));
            this.letterTilePrefab.AddListener(call:  162246656);
            this.letterTilePrefab + 16.interactable = false;
            this.answerTiles.Add(item:  typeof(WordChainUIController.<>c__DisplayClass17_1).__il2cppRuntimeField_8);
            goto label_45;
            label_33:
            Dispose();
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_19 = ShouldShowFTUX();
            this.tutorialText.SetActive(value:  val_19);
            UnityEngine.GameObject val_20 = this.hintBtn.gameObject;
            if(val_19 != false)
            {
                    this.hintBtn.SetActive(value:  false);
                twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ShowFTUX();
            }
            else
            {
                    this.hintBtn.SetActive(value:  true);
            }
            
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_24 = -921456080(-921456080) + 13152256;
            this.minigamesCheckpointSlider.UpdateUI();
        }
        public void OnTileSelected(SLC.Minigames.WordChain.WordChainLetterTile tile)
        {
            var val_20;
            var val_21;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance()) != 0)
            {
                    val_20 = public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance();
            }
            else
            {
                    val_20 = 20;
                val_21 = ;
            }
            
            mem[20] = 3;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((UnityEngine.Object.op_Implicit(exists:  (MonoSingleton<T>.__il2cppRuntimeField_cctor_finished + ((public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntime + 16)) != false)
            {
                    (MonoSingleton<T>.__il2cppRuntimeField_cctor_finished + ((public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntime + 16 + 16.interactable = true;
                mem2[0] = tile.keyboardIndex;
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                mem2[0] = (public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntimeField_14 - 1);
                tile.canvasGroup.alpha = null;
                tile.btn.interactable = false;
                tile.submitted = true;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_11 = this.CurrentAnswer;
            CheckAnswerCorrect(answer:  967524432);
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(ShouldShowFTUX() != false)
            {
                    string val_14 = this.CurrentAnswer;
                twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ShowFTUX();
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StopAllCoroutines();
            this.HideFTUXHand();
        }
        public void OnTileDeselected(SLC.Minigames.WordChain.WordChainLetterTile tile)
        {
            int val_9;
            var val_10;
            val_9 = tile.answerIndex;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_10 = public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance();
            public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntimeField_14 = tile + 28;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(ShouldShowFTUX() != false)
            {
                    string val_5 = this.CurrentAnswer;
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ShowFTUX();
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StopAllCoroutines();
            this.HideFTUXHand();
        }
        public void ShowFTUXHand(SLC.Minigames.WordChain.WordChainLetterTile tile)
        {
            UnityEngine.Transform val_1 = this.FTUXHand.transform;
            UnityEngine.Transform val_2 = tile.transform;
            UnityEngine.Vector3 val_3 = position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0.0003345923f}, b:  new UnityEngine.Vector3() {y = this.FTUXHandOffset});
            this.FTUXHand.position = new UnityEngine.Vector3();
            this.FTUXHand.SetActive(value:  true);
        }
        public void HideFTUXHand()
        {
            this.FTUXHand.SetActive(value:  false);
        }
        public void DisableOtherLetterTiles(SLC.Minigames.WordChain.WordChainLetterTile currentFTUXLetterTile)
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
        public SLC.Minigames.WordChain.WordChainLetterTile GetNextLetterInFTUX(int index)
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
            string val_3 = public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntimeField_10 + 16.Chars[index].ToString();
            if((System.String.op_Equality(a:  968187082, b:  (index + 0) + 16 + 12)) != false)
            {
                    if(((index + 0) + 16 + 33) == 0)
            {
                    return;
            }
            
            }
            
            val_5 = 1;
            label_1:
            if(val_5 < ((index + 0) + 16 + 33))
            {
                goto label_14;
            }
            
            val_6 = 0;
        }
        public void UpdateFailedLevelUI()
        {
            this.checkMarkWrong.SetActive(value:  true);
        }
        public void UpdateSuccessLevelUI()
        {
            this.checkMarkCorrect.SetActive(value:  true);
        }
        public void ShowHint()
        {
            var val_9;
            object val_1 = new System.Object();
            if(val_1 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.OnTileDeselected(tile:  2621443);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(val_1 != 0)
            {
                    val_9 = val_1;
                typeof(WordChainUIController.<>c__DisplayClass26_0).__il2cppRuntimeField_8 = (0 + (public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 16) << 2) + 16;
            }
            else
            {
                    val_9 = 8;
                mem[8] = (0 + (public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 16) << 2) + 16;
            }
            
            mem2[0] = 1;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_5 = public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntimeField_10 + 16.Chars[public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntimeField_18 + 8 + 16].ToString();
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.WordChain.WordChainManager MonoSingleton<SLC.Minigames.WordChain.WordChainManager>::get_Instance().__il2cppRuntimeField_18.RemoveAt(index:  0);
            System.Predicate<ZooTile> val_7 = new System.Predicate<ZooTile>(object:  450904064, method:  new IntPtr(968547984));
            SLC.Minigames.WordChain.WordChainLetterTile val_8 = this.keyboardTiles.Find(match:  8040448);
            alpha = null;
            interactable = false;
            mem2[0] = 1;
        }
        private void OnEnable()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  968708560, method:  new IntPtr(968683536));
            this.hintBtn.m_OnClick.AddListener(call:  162246656);
        }
        private void OnClickHintBtn()
        {
            int val_5;
            int val_15;
            var val_20;
            var val_21;
            var val_22;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_2 = CurrencyController.GetBalance();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            decimal val_4 = hintCost;
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_5})) == false)
            {
                goto label_10;
            }
            
            Player val_7 = App.Player;
            val_20 = 2621448;
            if(val_20 == 0)
            {
                goto label_14;
            }
            
            val_21 = 35143856;
            goto label_15;
            label_10:
            var val_19 = 22269049;
            val_19 = 13357012 + val_19;
            if(val_19 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_22 = null;
            val_22 = null;
            PurchaseProxy.currentPurchasePoint = 28;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_9 = ShowUGUIMonolith<System.Object>(showNext:  true);
            Init(outOfCredits:  true, onCloseAction:  0);
            return;
            label_14:
            val_20 = 52;
            val_21 = 6;
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
            CheckAnswerCorrect(answer:  968828752);
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
            var val_2 = 18778016;
            val_2 = 13354176 + val_2;
            return (int)(13354176 + 18778016) + ((keyboardLetterNumber - 8)) << 2;
        }
        public WordChainUIController()
        {
            this.answerTiles = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.keyboardTiles = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        }
    
    }

}
