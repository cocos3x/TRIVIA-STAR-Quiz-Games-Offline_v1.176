using UnityEngine;

namespace SLC.Minigames.Just2Emojis
{
    public class Just2EmojisUIController : MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisUIController>
    {
        // Fields
        private UnityEngine.Canvas canvas;
        private UnityEngine.Canvas pauseCanvas;
        private EmojiDisplay emojiDisplay_1;
        private EmojiDisplay emojiDisplay_2;
        private UnityEngine.UI.Image markRight;
        private UnityEngine.UI.Image markWrong;
        private UnityEngine.Transform answersTransform;
        private UnityEngine.GameObject answerLetterBlock;
        private UnityEngine.GameObject answerDisplayLine;
        private UnityEngine.Sprite answerEmptySprite;
        private UnityEngine.Sprite answerFilledSprite;
        private UnityEngine.GameObject blankSpace;
        private UnityEngine.UI.HorizontalLayoutGroup answerLayout1;
        private UnityEngine.UI.HorizontalLayoutGroup answerLayout2;
        private UnityEngine.GameObject letterlayout_8;
        private UnityEngine.GameObject letterLayout_10;
        private UnityEngine.GameObject letterlayout_12;
        private UnityEngine.GameObject letterlayout_14;
        private UnityEngine.GameObject letterlayout_16;
        private UnityEngine.GameObject letterlayout_18;
        private UnityEngine.GameObject letterlayout_21;
        private UnityEngine.UI.Button hintButton;
        private UnityEngine.UI.Text hintButton_hintCostText;
        private UnityEngine.UI.Button quitButton;
        private UnityEngine.UI.Button resumeButton;
        private System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> spriteLookup;
        private System.Collections.Generic.Dictionary<string, object> emojiLookup;
        private System.Collections.Generic.List<SLC.Minigames.Just2Emojis.Just2EmojisItem> progressBlocks;
        private System.Collections.Generic.List<SLC.Minigames.Just2Emojis.Just2EmojisAnswer> answerBlocks;
        private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> layoutDictionary;
        private SLC.Minigames.Just2Emojis.Just2EmojisItem[] letters;
        private bool init;
        private string answer;
        private float answerLetterFontSize;
        private float answerLayout1StartWidth;
        private float answerLayout2StartWidth;
        private SLC.Minigames.Just2Emojis.J2ELevel currentLevel;
        private bool shouldDisable;
        
        // Properties
        private decimal hintCost { get; }
        public bool ShouldDisable { get; }
        
        // Methods
        private decimal get_hintCost()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) != 0)
            {
                    return new System.Decimal() {flags = -1745297728, hi = MonoSingleton<T>.__il2cppRuntimeField_cctor_finished};
            }
            
            return new System.Decimal() {flags = -1745297728, hi = MonoSingleton<T>.__il2cppRuntimeField_cctor_finished};
        }
        public bool get_ShouldDisable()
        {
            return (bool)this.shouldDisable;
        }
        public override void InitMonoSingleton()
        {
            System.Action val_8;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1044084736, method:  new IntPtr(1044040256));
            this.hintButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  1044084736, method:  new IntPtr(1044049472));
            this.quitButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  1044084736, method:  new IntPtr(1044058688));
            this.resumeButton.m_OnClick.AddListener(call:  162246656);
            val_8 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = null;
            val_8 = new System.Action(object:  1044084736, method:  new IntPtr(1044059712));
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70 = val_8;
        }
        public void Initialize()
        {
            if(this.init == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BuildEmojiLookup();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StartMusic(clipIndex:  0);
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_3 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            this.layoutDictionary = null;
            Add(key:  8, value:  this.letterlayout_8);
            this.layoutDictionary.Add(key:  10, value:  this.letterLayout_10);
            this.layoutDictionary.Add(key:  12, value:  this.letterlayout_12);
            this.layoutDictionary.Add(key:  14, value:  this.letterlayout_14);
            this.layoutDictionary.Add(key:  16, value:  this.letterlayout_16);
            this.layoutDictionary.Add(key:  18, value:  this.letterlayout_18);
            this.layoutDictionary.Add(key:  21, value:  this.letterlayout_21);
            object val_4 = this.answerLayout1.GetComponent<System.Object>();
            UnityEngine.Rect val_5 = rect;
            float val_6 = width;
            this.answerLayout1StartWidth = ;
            object val_7 = this.answerLayout2.GetComponent<System.Object>();
            UnityEngine.Rect val_8 = rect;
            float val_9 = width;
            this.answerLayout2StartWidth = ;
            this.init = true;
        }
        public void StartLevel(SLC.Minigames.Just2Emojis.J2ELevel currentLevel)
        {
            var val_32;
            var val_33;
            var val_34;
            string val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            if(this.init == false)
            {
                    this.init = this;
                this.Initialize();
            }
            
            this.pauseCanvas.enabled = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUI();
            this.currentLevel = currentLevel;
            decimal val_2 = hintCost;
            GameEcon val_3 = App.getGameEcon;
            string val_4 = 0.ToString(format:  null);
            this.markWrong.enabled = false;
            this.markRight.enabled = false;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.progressBlocks = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.shouldDisable = false;
            this.answerBlocks = null;
            UnityEngine.Transform val_7 = this.answerLayout1.transform;
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.answerLayout1);
            UnityEngine.Transform val_8 = this.answerLayout2.transform;
            MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.answerLayout2);
            object val_9 = this.answerLayout1.GetComponent<System.Object>();
            this.answerLayout1.SetSizeWithCurrentAnchors(axis:  0, size:  null);
            object val_10 = this.answerLayout2.GetComponent<System.Object>();
            this.answerLayout2.SetSizeWithCurrentAnchors(axis:  0, size:  null);
            if(currentLevel != 0)
            {
                    val_32 = this;
                this.answer = currentLevel + 20;
                mem[1152921514241501072] = 0;
            }
            else
            {
                    val_32 = this;
                this.answer = 1;
                mem[1152921514241501072] = 0;
            }
            
            val_33 = mem[currentLevel + 16 + 12];
            val_33 = currentLevel + 16 + 12;
            val_34 = 8;
            if(val_33 < 9)
            {
                goto label_98;
            }
            
            if(val_33 >= 11)
            {
                    val_34 = 12;
            }
            
            if(val_33 >= 13)
            {
                goto label_21;
            }
            
            label_98:
            val_35 = this.answer;
            if(this.answer == null)
            {
                    val_35 = this.answer;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_10 = 32;
            System.String[] val_11 = val_35.Split(separator:  478563824);
            if(50331648 != 1)
            {
                goto label_27;
            }
            
            label_30:
            this.SingleLineAnswerDisplay(a:  this.answer);
            goto label_29;
            label_27:
            if(50331648 < 2)
            {
                goto label_29;
            }
            
            if(0 <= 10)
            {
                goto label_30;
            }
            
            this.DoubleLineAnswerDisplay(a:  478563824, words:  1);
            label_29:
            Dictionary.Enumerator<TKey, TValue> val_12 = GetEnumerator();
            label_37:
            if(0.MoveNext() == false)
            {
                goto label_32;
            }
            
            if(val_34 != 0)
            {
                goto label_33;
            }
            
            R5.SetActive(value:  true);
            goto label_37;
            label_33:
            R5.SetActive(value:  false);
            goto label_37;
            label_32:
            0.Dispose();
            UnityEngine.GameObject val_15 = this.layoutDictionary.Item[12];
            val_36 = 0;
            UnityEngine.Transform val_16 = this.layoutDictionary.transform;
            T[] val_17 = this.layoutDictionary.GetComponentsInChildren<System.Object>();
            this.letters = this.layoutDictionary;
            goto label_41;
            label_44:
            add(item:  0, weight:  null);
            val_36 = 1;
            label_41:
            if(val_36 < new RandomSet())
            {
                goto label_44;
            }
            
            val_37 = 4;
            val_38 = 16;
            goto label_45;
            label_63:
            this.letters[0].Show();
            if(0 < val_33)
            {
                    SLC.Minigames.Just2Emojis.Just2EmojisItem val_34 = this.letters[roll(unweighted:  false)];
                if((currentLevel + 16 + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_35 = currentLevel + 16 + 8;
                val_35 = val_35 + val_38;
                string val_20 = val_35.ToString();
                val_39 = ;
            }
            else
            {
                    SLC.Minigames.Just2Emojis.Just2EmojisItem val_36 = this.letters[roll(unweighted:  false)];
                string val_23 = SLC.Minigames.Just2Emojis.Just2EmojisUIController.GetLetter().ToString();
                val_39 = ;
            }
            
            val_36.SetUp(letter:  1044707276);
            val_38 = 18;
            val_37 = 5;
            label_45:
            if((val_37 - 4) < val_36)
            {
                goto label_63;
            }
            
            if((currentLevel + 12 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.emojiDisplay_1.DisplayEmoji(emojiID:  currentLevel + 12 + 8 + 16 + 8, addOutline:  false);
            if((currentLevel + 12 + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.emojiDisplay_2.DisplayEmoji(emojiID:  currentLevel + 12 + 8 + 20 + 8, addOutline:  false);
            twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_41 = public static Just2EmojisFTUXManager MonoSingleton<Just2EmojisFTUXManager>::get_Instance();
            twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_42 = val_41;
            val_40 = 0;
            public static Just2EmojisFTUXManager MonoSingleton<Just2EmojisFTUXManager>::get_Instance().__il2cppRuntimeField_28 = ;
            twelvegigs.Autopilot.AutopilotManager val_30 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            StartFTUX();
            return;
            label_21:
            if(val_33 >= 15)
            {
                    14 = 16;
            }
            
            if(val_33 < 17)
            {
                goto label_98;
            }
            
            if(val_33 < 19)
            {
                    21 = 18;
            }
            
            goto label_98;
        }
        private void SingleLineAnswerDisplay(string a)
        {
            var val_9;
            float val_10;
            UnityEngine.GameObject val_11;
            var val_12;
            val_9 = 0;
            UnityEngine.GameObject val_1 = this.answerLayout2.gameObject;
            this.answerLayout2.SetActive(value:  false);
            val_10 = 1152921511032642464;
            goto label_3;
            label_21:
            if(a.Chars[0] == ' ')
            {
                    val_11 = this.blankSpace;
                UnityEngine.Transform val_3 = this.answerLayout1.transform;
                object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  val_11, parent:  this.answerLayout1);
            }
            else
            {
                    UnityEngine.Transform val_5 = this.answerLayout1.transform;
                object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  this.answerLetterBlock, parent:  this.answerLayout1);
                object val_7 = this.answerLetterBlock.GetComponent<System.Object>();
                if(this.answerLetterBlock != 0)
            {
                
            }
            else
            {
                    val_12 = 0;
            }
            
                this.EmptyAnswerBlock(blockImage:  0, letter:  2130828192);
                object val_8 = this.answerLetterBlock.GetComponent<System.Object>();
                val_11 = this.answerLetterBlock;
                this.answerBlocks.Add(item:  val_11);
                val_10 = 1152921511032642464;
                var val_10 = 0;
                if(this.answerBlocks <= val_10)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = val_9 + 0;
                mem2[0] = val_10;
                val_10 = val_10 + 1;
            }
            
            val_9 = 1;
            label_3:
            if(val_9 < a.m_stringLength)
            {
                goto label_21;
            }
        
        }
        private void SetUpAnswerDisplay(string a, int number)
        {
            var val_15;
            var val_16;
            UnityEngine.GameObject val_17;
            var val_18;
            var val_19;
            if(number == 1)
            {
                goto label_1;
            }
            
            if(number != 2)
            {
                    return;
            }
            
            val_15 = 0;
            val_16 = 0;
            goto label_3;
            label_21:
            if(a.Chars[0] == ' ')
            {
                    val_17 = this.blankSpace;
                UnityEngine.Transform val_2 = this.answerLayout2.transform;
                object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  val_17, parent:  this.answerLayout2);
            }
            else
            {
                    UnityEngine.Transform val_4 = this.answerLayout2.transform;
                object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  this.answerLetterBlock, parent:  this.answerLayout2);
                object val_6 = this.answerLetterBlock.GetComponent<System.Object>();
                if(this.answerLetterBlock != 0)
            {
                
            }
            else
            {
                    val_18 = 0;
            }
            
                this.EmptyAnswerBlock(blockImage:  0, letter:  2130828192);
                object val_7 = this.answerLetterBlock.GetComponent<System.Object>();
                val_17 = this.answerLetterBlock;
                this.answerBlocks.Add(item:  val_17);
                if(this.answerBlocks <= val_16)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_15 = val_15 + 0;
                mem2[0] = val_16;
                val_16 = 1;
            }
            
            val_15 = 1;
            label_3:
            if(val_15 < a.m_stringLength)
            {
                goto label_21;
            }
            
            return;
            label_1:
            val_15 = 0;
            val_16 = 0;
            goto label_23;
            label_41:
            if(a.Chars[0] == ' ')
            {
                    val_17 = this.blankSpace;
                UnityEngine.Transform val_9 = this.answerLayout1.transform;
                object val_10 = UnityEngine.Object.Instantiate<System.Object>(original:  val_17, parent:  this.answerLayout1);
            }
            else
            {
                    UnityEngine.Transform val_11 = this.answerLayout1.transform;
                object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  this.answerLetterBlock, parent:  this.answerLayout1);
                object val_13 = this.answerLetterBlock.GetComponent<System.Object>();
                if(this.answerLetterBlock != 0)
            {
                
            }
            else
            {
                    val_19 = 0;
            }
            
                this.EmptyAnswerBlock(blockImage:  0, letter:  2130828192);
                object val_14 = this.answerLetterBlock.GetComponent<System.Object>();
                val_17 = this.answerLetterBlock;
                this.answerBlocks.Add(item:  val_17);
                if(this.answerBlocks <= val_16)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_16 = val_16 + 0;
                mem2[0] = val_16;
                val_16 = 1;
            }
            
            val_15 = 1;
            label_23:
            if(val_15 < a.m_stringLength)
            {
                goto label_41;
            }
        
        }
        private void DoubleLineAnswerDisplay(string a, string[] words)
        {
            string val_5;
            string val_6;
            string val_7;
            int val_10;
            string val_12;
            var val_13;
            string val_14;
            int val_16;
            var val_17;
            int val_18;
            var val_19;
            var val_20;
            var val_21;
            int val_22;
            val_5 = "";
            UnityEngine.GameObject val_1 = this.answerLayout2.gameObject;
            val_6 = this.answerLayout2;
            val_6.SetActive(value:  true);
            if(35640387 == 4)
            {
                goto label_4;
            }
            
            if(35640387 == 3)
            {
                goto label_5;
            }
            
            val_7 = val_5;
            if(35640387 != 2)
            {
                goto label_6;
            }
            
            val_7 = words[0];
            val_5 = words[1];
            goto label_23;
            label_4:
            val_6 = words[0];
            val_10 = " ";
            string val_2 = val_6 + 1297836560 + words[1];
            val_7 = val_6;
            val_12 = words[2];
            val_13 = " ";
            val_14 = words[3];
            goto label_14;
            label_5:
            string val_6 = words[0];
            val_6 = words[0].m_stringLength;
            string val_7 = words[1];
            int val_8 = words[1].m_stringLength;
            val_7 = words[0];
            val_8 = val_8 + val_6;
            val_12 = words[1];
            if(val_8 >= 11)
            {
                goto label_21;
            }
            
            string val_3 = val_7 + 1297836560 + val_12;
            val_7 = val_7;
            val_5 = words[2];
            goto label_23;
            label_21:
            val_14 = words[2];
            val_13 = " ";
            label_14:
            string val_4 = val_12 + 1297836560 + val_14;
            val_5 = val_12;
            label_23:
            this.SetUpAnswerDisplay(a:  val_7, number:  1);
            this.SetUpAnswerDisplay(a:  val_5, number:  2);
            label_6:
            val_16 = words[0].m_stringLength;
            if(val_5 == null)
            {
                goto label_26;
            }
            
            val_17 = val_5;
            val_18 = words[1].m_stringLength;
            if(val_16 <= val_18)
            {
                goto label_27;
            }
            
            label_29:
            val_19 = 2;
            val_20 = val_16;
            goto label_28;
            label_26:
            val_17 = 8;
            val_10 = words[0].m_stringLength;
            val_6 = 0;
            val_21 = 0;
            val_16 = val_10;
            if(val_16 > 0)
            {
                goto label_29;
            }
            
            label_27:
            if(val_16 >= 0)
            {
                    return;
            }
            
            val_5 = words[0].m_stringLength;
            val_20 = val_17;
            val_19 = 1;
            val_22 = val_5;
            label_28:
            this.ResizeAnswerBlocks(number:  1, otherLettersCount:  0, currAnswerCount:  val_22);
        }
        private void ResizeAnswerBlocks(int number, int otherLettersCount, int currAnswerCount)
        {
            float val_15;
            var val_16;
            float val_17;
            float val_18;
            UnityEngine.UI.HorizontalLayoutGroup val_19;
            if(number != 2)
            {
                    if(number != 1)
            {
                    return;
            }
            
                val_15 = 1152921510188612944;
                object val_1 = this.answerLayout2.GetComponent<System.Object>();
                UnityEngine.Rect val_2 = rect;
                float val_3 = width;
                int val_4 = otherLettersCount + (otherLettersCount << 2);
                int val_5 = currAnswerCount + (currAnswerCount << 2);
                val_4 = 9 + (val_4 << 1);
                val_5 = 9 + (val_5 << 1);
                float val_12 = (float)val_4;
                val_12 = 1045788136 - val_12;
                val_16 = val_12 / (float)otherLettersCount;
                val_17 = (float)currAnswerCount;
                val_18 = val_5;
                val_19 = this.answerLayout1;
            }
            else
            {
                    val_15 = 1152921510188612944;
                object val_6 = this.answerLayout1.GetComponent<System.Object>();
                UnityEngine.Rect val_7 = rect;
                float val_8 = width;
                int val_9 = otherLettersCount + (otherLettersCount << 2);
                int val_10 = currAnswerCount + (currAnswerCount << 2);
                val_9 = 9 + (val_9 << 1);
                val_10 = 9 + (val_10 << 1);
                float val_13 = (float)val_9;
                val_13 = 1045788136 - val_13;
                val_16 = val_13 / (float)otherLettersCount;
                val_17 = (float)currAnswerCount;
                val_18 = val_10;
                val_19 = this.answerLayout2;
            }
            
            object val_11 = val_19.GetComponent<System.Object>();
            val_19.SetSizeWithCurrentAnchors(axis:  0, size:  val_18);
        }
        public void OnLetterBlockClicked(string letter, int index, SLC.Minigames.Just2Emojis.Just2EmojisItem item)
        {
            var val_11;
            var val_12;
            val_11 = index;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = GetAnswerNextLetter();
            if((public static SLC.Minigames.Just2Emojis.Just2EmojisManager MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisManager>::get_Instance()) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                string val_6 = GetAnswerNextLetter();
                bool val_7 = System.String.op_Equality(a:  letter, b:  -847999344);
                if(val_7 != false)
            {
                    if(val_7 <= val_11)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_11 = val_11 + (val_11 << 2);
                (0 + (index) << 2) + 16.Fill(letter:  letter);
                if(((0 + (index) << 2) + 16) <= val_11)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = val_12 + (val_11 << 2);
                (0 + (index) << 2) + 16 + 24.sprite = this.answerFilledSprite;
                item.Hide();
                this.progressBlocks.Add(item:  item);
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if((public static SLC.Minigames.Just2Emojis.Just2EmojisManager MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisManager>::get_Instance()) != 0)
            {
                    val_12 = public static SLC.Minigames.Just2Emojis.Just2EmojisManager MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisManager>::get_Instance();
            }
            else
            {
                    val_12 = 40;
                val_11 = 2097204;
            }
            
                mem[40] = 2097205;
                this.FTUXHighlight();
            }
            
            }
            
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ResetFTUXTimer();
        }
        public void OnAnswerBlockClicked(int index)
        {
            System.Collections.IEnumerator val_1 = this.DelayedReturn(index:  index);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1046123520);
        }
        private System.Collections.IEnumerator DelayedReturn(int index)
        {
            typeof(Just2EmojisUIController.<DelayedReturn>d__51).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(Just2EmojisUIController.<DelayedReturn>d__51).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(Just2EmojisUIController.<DelayedReturn>d__51).__il2cppRuntimeField_14 = index;
        }
        public void AnswerClicked(SLC.Minigames.Just2Emojis.Just2EmojisAnswer answer)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AnswerClick(answer:  answer, answerBlocks:  this.answerBlocks);
        }
        public void MarkCorrectAnswer()
        {
            this.markRight.enabled = true;
            this.SetLettersInteractable(on:  false);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  928911072, clipIndex:  0, volumeScale:  null);
        }
        public void MarkWrongAnswer()
        {
            this.markWrong.enabled = true;
            this.SetLettersInteractable(on:  false);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayGameSpecificSound(id:  928916272, clipIndex:  0, volumeScale:  null);
        }
        public void SetLettersInteractable(bool on)
        {
            UnityEngine.Object val_6;
            SLC.Minigames.Just2Emojis.Just2EmojisUIController val_10;
            var val_11;
            val_10 = this;
            val_11 = 0;
            this.hintButton.interactable = on;
            goto label_2;
            label_11:
            object val_1 = 1152921508475946752.GetComponent<System.Object>();
            val_10 = 1152921508475946752;
            if((-425867520) != 0)
            {
                    object val_3 = 1152921508475946752.GetComponent<System.Object>();
                1152921508475946752.interactable = on;
            }
            
            val_11 = 1;
            label_2:
            if(val_11 < 1152921508475946752)
            {
                goto label_11;
            }
            
            List.Enumerator<T> val_4 = GetEnumerator();
            label_20:
            if(MoveNext() == false)
            {
                goto label_13;
            }
            
            object val_7 = val_6.GetComponent<System.Object>();
            if(val_6 == 0)
            {
                goto label_20;
            }
            
            object val_9 = val_6.GetComponent<System.Object>();
            val_6.interactable = on;
            goto label_20;
            label_13:
            Dispose();
        }
        public void SetAnswersInteractable(bool on)
        {
            var val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            object val_4 = val_3.GetComponent<System.Object>();
            val_3.interactable = on;
            goto label_5;
            label_2:
            Dispose();
        }
        public void EmptyAnswerBlock(UnityEngine.UI.Image blockImage, TMPro.TMP_Text letter)
        {
            blockImage.sprite = this.answerEmptySprite;
            if(letter == 0)
            {
                
            }
        
        }
        public void Hinted(int index)
        {
            var val_9;
            var val_10;
            if(0 <= index)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + (index << 2);
            string val_1 = this.currentLevel.StrippedAnswer;
            string val_3 = this.currentLevel.Chars[index].ToString();
            if(((0 + (index) << 2) + 16 + 20) <= index)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (index << 2);
            (0 + (index) << 2) + 16 + 20.enableAutoSizing = false;
            if(this <= index)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (index << 2);
            (0 + (index) << 2) + 16 + 20.fontSize = this.FindBestAnswerFontSize();
            if(((0 + (index) << 2) + 16 + 20) <= index)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (index << 2);
            mem2[0] = 1;
            if(1 <= index)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + (index << 2);
            UnityEngine.Color val_5 = UnityEngine.Color.black;
            if(((0 + (index) << 2) + 16 + 20) <= index)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + (index << 2);
            val_9 = mem[(0 + (index) << 2) + 16 + 24];
            val_9 = (0 + (index) << 2) + 16 + 24;
            val_9.enabled = false;
            if(val_9 <= index)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + (index << 2);
            val_10 = 0;
            goto label_30;
            label_36:
            bool val_6 = System.String.op_Equality(a:  SLC.Minigames.Just2Emojis.Just2EmojisItem[].__il2cppRuntimeField_byval_arg, b:  (0 + (index) << 2) + 16 + 20);
            if(val_6 == true)
            {
                goto label_34;
            }
            
            val_10 = 1;
            label_30:
            if(val_10 < val_6)
            {
                goto label_36;
            }
            
            goto label_37;
            label_34:
            1152921508475946752.Hide();
            typeof(SLC.Minigames.Just2Emojis.Just2EmojisItem[]).__il2cppRuntimeField_D = 1;
            label_37:
            System.Collections.IEnumerator val_7 = this.DelayedReturn(index:  0);
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  1047239680);
        }
        public void DisplayAnswer()
        {
            var val_5 = 0;
            this.markWrong.enabled = false;
            goto label_2;
            label_11:
            if(this.markWrong <= val_5)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            string val_1 = this.currentLevel.StrippedAnswer;
            string val_3 = this.currentLevel.Chars[0].ToString();
            val_5 = 1;
            label_2:
            string val_4 = this.currentLevel.StrippedAnswer;
            if(val_5 < this.currentLevel.levelIndex)
            {
                goto label_11;
            }
        
        }
        public static char GetLetter()
        {
            if("ABCDEFGHIJKLMNOPQRSTUVWXYZ" != 0)
            {
                    return Chars[UnityEngine.Random.Range(min:  0, max:  ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".__il2cppRuntimeField_8 - 1))];
            }
            
            return Chars[UnityEngine.Random.Range(min:  0, max:  ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".__il2cppRuntimeField_8 - 1))];
        }
        public void ToggleUI(bool show)
        {
            this.canvas.enabled = show;
        }
        public float FindBestAnswerFontSize()
        {
            float val_3;
            var val_4;
            float val_5;
            if(true == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(2621443 != 0)
            {
                goto label_4;
            }
            
            if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = static_value_00280017;
            if(val_4 == 0)
            {
                goto label_9;
            }
            
            val_4.enabled = true;
            val_4.enableAutoSizing = true;
            goto label_10;
            label_4:
            val_4 = static_value_00280017;
            goto label_11;
            label_9:
            0.enabled = true;
            0.enableAutoSizing = true;
            label_10:
            if(val_4 != 0)
            {
                    val_5 = 0.85f;
                val_3 = (static_value_00280017 + 308) * val_5;
                this.answerLetterFontSize = val_3;
            }
            else
            {
                    val_5 = 0.85f;
                val_3 = (1.121039E-44f) * val_5;
                this.answerLetterFontSize = val_3;
            }
            
            val_4.enableAutoSizing = false;
            label_11:
            val_4.fontSize = val_5;
            return val_5;
        }
        private void OnClick_Pause()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            this.pauseCanvas.enabled = true;
        }
        private void OnClick_Quit()
        {
            this.pauseCanvas.enabled = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((UnityEngine.Object.op_Implicit(exists:  899829136)) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGameOver();
        }
        private void OnClick_Resume()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            this.pauseCanvas.enabled = false;
        }
        private void OnClick_Hint()
        {
            int val_14;
            var val_17;
            var val_18;
            var val_19;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Player val_3 = App.Player;
            var val_16 = 0;
            val_16 = val_16 + 64;
            decimal val_4 = hintCost;
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = mem[(0 + 64) + (0)], lo = mem[(0 + 64) + (4)], mid = mem[(0 + 64) + (8)]}, d2:  new System.Decimal())) == false)
            {
                goto label_12;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Hint();
            Player val_7 = App.Player;
            val_17 = 2621448;
            if(val_17 == 0)
            {
                goto label_19;
            }
            
            val_18 = 35143856;
            goto label_20;
            label_12:
            var val_17 = 21792233;
            val_17 = 13833828 + val_17;
            if(val_17 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_19 = null;
            val_19 = null;
            PurchaseProxy.currentPurchasePoint = 25;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_9 = ShowUGUIMonolith<System.Object>(showNext:  true);
            Init(outOfCredits:  true, onCloseAction:  0);
            return;
            label_19:
            val_17 = 52;
            val_18 = 6;
            label_20:
            mem[52] = 7;
            decimal val_10 = hintCost;
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_12 = CurrentMinigameName;
            string val_13 = System.String.Format(format:  932569136, arg0:  -1745297776);
            bool val_15 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_14}, source:  "MG {0} HINT", externalParams:  0, animated:  false);
        }
        public void StartFTUX()
        {
            this.FTUXHighlight();
        }
        public void FTUXHighlight()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HideHand();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_3 = GetAnswerNextLetter();
            if((public static SLC.Minigames.Just2Emojis.Just2EmojisManager MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisManager>::get_Instance()) == 0)
            {
                    return;
            }
            
            var val_9 = 4;
            label_21:
            if((val_9 - 4) >= (public static SLC.Minigames.Just2Emojis.Just2EmojisManager MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisManager>::get_Instance()))
            {
                    return;
            }
            
            SLC.Minigames.Just2Emojis.Just2EmojisItem val_6 = this.letters[0];
            if((System.String.op_Equality(a:  this.letters[0].letter, b:  -847999344)) == false)
            {
                goto label_13;
            }
            
            SLC.Minigames.Just2Emojis.Just2EmojisItem val_7 = this.letters[0];
            if(this.letters[0].isHidden == false)
            {
                goto label_17;
            }
            
            label_13:
            this.letters[0].Unhighlight();
            label_26:
            val_9 = val_9 + 1;
            goto label_21;
            label_17:
            if(0 != 1)
            {
                goto label_26;
            }
            
            this.letters[0].FTUXHighlight();
            goto label_26;
        }
        public void FTUXUnhighlight()
        {
            goto label_1;
            label_8:
            if((-425867520) != 0)
            {
                    1152921508475946752.Unhighlight();
            }
            
            0 = 1;
            label_1:
            if(0 < 1152921508475946752)
            {
                goto label_8;
            }
        
        }
        public UnityEngine.Transform FTUXNewLetterPosition()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_2 = GetAnswerNextLetter();
            if((public static SLC.Minigames.Just2Emojis.Just2EmojisManager MonoSingleton<SLC.Minigames.Just2Emojis.Just2EmojisManager>::get_Instance()) == 0)
            {
                    return;
            }
            
            val_4 = 0;
        }
        public Just2EmojisUIController()
        {
        
        }
    
    }

}
