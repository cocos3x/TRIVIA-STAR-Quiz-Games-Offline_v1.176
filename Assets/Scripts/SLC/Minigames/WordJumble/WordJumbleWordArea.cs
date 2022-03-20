using UnityEngine;

namespace SLC.Minigames.WordJumble
{
    public class WordJumbleWordArea : MonoBehaviour
    {
        // Fields
        private UnityEngine.RectTransform answerArea;
        private UnityEngine.RectTransform inputArea;
        private bool <IsCompleted>k__BackingField;
        private System.Collections.Generic.List<SLC.Minigames.WordJumble.WordJumbleAnswerLetter> answerLetters;
        private System.Collections.Generic.List<SLC.Minigames.WordJumble.WordJumbleLetterTile> inputLetters;
        private string <correctAnswer>k__BackingField;
        private System.Action <onLetterSubmitted>k__BackingField;
        private System.Action <onWordComplete>k__BackingField;
        
        // Properties
        public bool IsCompleted { get; set; }
        public System.Collections.Generic.List<SLC.Minigames.WordJumble.WordJumbleLetterTile> getInputLetters { get; }
        public string correctAnswer { get; set; }
        public System.Action onLetterSubmitted { get; set; }
        public System.Action onWordComplete { get; set; }
        
        // Methods
        public bool get_IsCompleted()
        {
            return (bool)this.<IsCompleted>k__BackingField;
        }
        private void set_IsCompleted(bool value)
        {
            this.<IsCompleted>k__BackingField = value;
        }
        public System.Collections.Generic.List<SLC.Minigames.WordJumble.WordJumbleLetterTile> get_getInputLetters()
        {
        
        }
        public string get_correctAnswer()
        {
        
        }
        private void set_correctAnswer(string value)
        {
            this.<correctAnswer>k__BackingField = value;
        }
        public System.Action get_onLetterSubmitted()
        {
        
        }
        public void set_onLetterSubmitted(System.Action value)
        {
            this.<onLetterSubmitted>k__BackingField = value;
        }
        public System.Action get_onWordComplete()
        {
        
        }
        public void set_onWordComplete(System.Action value)
        {
            this.<onWordComplete>k__BackingField = value;
        }
        public void Init(string word, SLC.Minigames.WordJumble.WordJumbleAnswerLetter _answerLetter, SLC.Minigames.WordJumble.WordJumbleLetterTile _letterTile)
        {
            var val_8;
            SLC.Minigames.WordJumble.WordJumbleLetterTile val_9;
            var val_10;
            this.<correctAnswer>k__BackingField = word;
            val_8 = 0;
            goto label_1;
            label_9:
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  _answerLetter, parent:  this.answerArea);
            _answerLetter.Init(_wordAreaParent:  921833744);
            this.answerLetters.Add(item:  _answerLetter);
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  _letterTile, parent:  this.inputArea);
            val_9 = _letterTile;
            val_9.Init(_wordAreaParent:  921833744, _letter:  word.Chars[0]);
            this.inputLetters.Add(item:  val_9);
            val_8 = 1;
            label_1:
            if(val_8 < word.m_stringLength)
            {
                goto label_9;
            }
            
            val_10 = 0;
            goto label_10;
            label_15:
            UnityEngine.Transform val_4 = this.inputArea.GetChild(index:  0);
            val_9 = UnityEngine.Random.Range(min:  0, max:  this.inputArea.childCount);
            this.inputArea.SetSiblingIndex(index:  val_9);
            val_10 = 1;
            label_10:
            if(val_10 < this.inputArea.childCount)
            {
                goto label_15;
            }
        
        }
        public void LetterTileClicked(SLC.Minigames.WordJumble.WordJumbleLetterTile letterTile)
        {
            var val_5;
            System.Func<SLC.Minigames.WordJumble.WordJumbleAnswerLetter, System.Boolean> val_7;
            val_5 = null;
            val_5 = null;
            val_7 = WordJumbleWordArea.<>c.<>9__23_0;
            if(val_7 == 0)
            {
                    val_7 = null;
                val_7 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordJumbleWordArea.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(921970896));
                WordJumbleWordArea.<>c.<>9__23_0 = val_7;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_2 = System.Linq.Enumerable.Where<System.Object>(source:  this.answerLetters, predicate:  7720960);
            object val_3 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.answerLetters);
            this.answerLetters.SetLetter(_letterTile:  letterTile, confirm:  false);
            if((this.<onLetterSubmitted>k__BackingField) != 0)
            {
                    this.<onLetterSubmitted>k__BackingField.Invoke();
            }
            
            if(this.checkCanSubmit() == false)
            {
                    return;
            }
            
            this.SubmitWord();
        }
        public void AnswerLetterClicked(SLC.Minigames.WordJumble.WordJumbleAnswerLetter answerLetter)
        {
            this.ResetLetters(startIndex:  this.answerLetters.IndexOf(item:  answerLetter));
        }
        private void ResetLetters(int startIndex = 0)
        {
            int val_1 = startIndex;
            goto label_1;
            label_6:
            if(true <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (val_1 << 2);
            (0 + (startIndex) << 2) + 16.ResetLetter();
            val_1 = val_1 + 1;
            label_1:
            if(val_1 < ((0 + (startIndex) << 2) + 16))
            {
                goto label_6;
            }
        
        }
        private bool checkCanSubmit()
        {
            var val_4;
            System.Func<SLC.Minigames.WordJumble.WordJumbleAnswerLetter, System.Boolean> val_6;
            val_4 = null;
            val_4 = null;
            val_6 = WordJumbleWordArea.<>c.<>9__26_0;
            if(val_6 == 0)
            {
                    val_6 = null;
                val_6 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordJumbleWordArea.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(922365264));
                WordJumbleWordArea.<>c.<>9__26_0 = val_6;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_2 = System.Linq.Enumerable.Where<System.Object>(source:  this.answerLetters, predicate:  7720960);
            int val_3 = System.Linq.Enumerable.Count<WGEventHandler>(source:  this.answerLetters);
            val_3 = val_3 >> 5;
            return (bool)val_3;
        }
        private void SubmitWord()
        {
            var val_7;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Text.StringBuilder val_5 = Append(value:  val_4 + 20 + 16);
            goto label_6;
            label_2:
            Dispose();
            if((System.String.op_Equality(a:  this.<correctAnswer>k__BackingField, b:  24121344)) != false)
            {
                    this.<IsCompleted>k__BackingField = true;
                if((this.<onWordComplete>k__BackingField) != 0)
            {
                    this.<onWordComplete>k__BackingField.Invoke();
            }
            
                val_7 = "Correct Answer";
            }
            else
            {
                    val_7 = "Wrong Answer";
            }
            
            UnityEngine.Debug.LogError(message:  922498864);
        }
        public void Hint()
        {
            var val_12;
            System.Func<SLC.Minigames.WordJumble.WordJumbleAnswerLetter, System.Boolean> val_14;
            object val_1 = new System.Object();
            this.ResetLetters(startIndex:  0);
            val_12 = null;
            val_12 = null;
            val_14 = WordJumbleWordArea.<>c.<>9__28_0;
            if(val_14 == 0)
            {
                    val_14 = null;
                val_14 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WordJumbleWordArea.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(922627344));
                WordJumbleWordArea.<>c.<>9__28_0 = val_14;
            }
            
            System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Object>(source:  this.answerLetters, predicate:  7720960);
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Object>(source:  this.answerLetters);
            string val_5 = 922629392 + 13152256;
            UnityEngine.Debug.LogError(message:  922629392);
            int val_6 = UnityEngine.Random.Range(min:  0, max:  0);
            if(val_6 <= val_6)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (val_6 << 2);
            typeof(WordJumbleWordArea.<>c__DisplayClass28_0).__il2cppRuntimeField_8 = this.<correctAnswer>k__BackingField.Chars[this.answerLetters.IndexOf(item:  (0 + (val_6) << 2) + 16)];
            System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_9 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  448188416, method:  new IntPtr(922641776));
            object val_10 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.inputLetters, predicate:  7720960);
            (0 + (val_6) << 2) + 16.SetLetter(_letterTile:  this.inputLetters, confirm:  true);
            this.inputLetters.HideLetter();
            bool val_11 = this.checkCanSubmit();
            if(val_11 == true)
            {
                    val_11 = this;
                this.SubmitWord();
            }
        
        }
        public WordJumbleWordArea()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.answerLetters = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.inputLetters = null;
        }
    
    }

}
