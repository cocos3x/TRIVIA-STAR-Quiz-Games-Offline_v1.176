using UnityEngine;

namespace SLC.Wordlicious
{
    public class WordRegionPage : WordRegionBase
    {
        // Fields
        private LineWord lineWord;
        private Cell cell;
        private System.Collections.Generic.HashSet<string> answers;
        
        // Methods
        public void OnEnable()
        {
            this.RestoreAnswers();
        }
        public void Init(LineWord lineWord, Cell cell, UnityEngine.RectTransform safeAreaWithinParent)
        {
            this.lineWord = lineWord;
            this.cell = cell;
            mem[1152921513928874492] = safeAreaWithinParent;
            System.Collections.Generic.HashSet<UnityEngine.UI.Text> val_1 = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            this.answers = null;
        }
        public void Load(System.Collections.Generic.List<string> wordList, System.Collections.Generic.List<string> wordListLevelProgress)
        {
            System.Collections.Generic.List<System.String> val_13;
            twelvegigs.sweepstakes.Distribution val_15;
            var val_16;
            System.Collections.Generic.List<System.String> val_17;
            var val_18;
            val_13 = wordListLevelProgress;
            mem[1152921513929023372] = ???;
            if(R6 < 11)
            {
                    3 = 2;
            }
            
            mem[1152921513929023376] = 2;
            val_15 = R6;
            val_15 = R6;
            float val_17 = 2f;
            val_17 = (float)R6 / val_17;
            val_16 = 0;
            mem[1152921513929023384] = val_16;
            val_17 = 2139095040;
            mem[1152921513929023380] = val_17;
            if(val_15 >= val_17)
            {
                    var val_1 = val_17 - 1;
                if(val_17 <= val_1)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_18 = val_18 + (val_1 << 2);
                val_16 = ((0 + ((val_17 - 1)) << 2) + 16 + 8) + 0;
                mem[1152921513929023384] = val_16;
            }
            
            var val_2 = ((0 + ((val_17 - 1)) << 2) + 16) - 1;
            if(((0 + ((val_17 - 1)) << 2) + 16) <= val_2)
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + (val_2 << 2);
            val_17 = mem[(0 + (((0 + ((val_17 - 1)) << 2) + 16 - 1)) << 2) + 16];
            val_17 = (0 + (((0 + ((val_17 - 1)) << 2) + 16 - 1)) << 2) + 16;
            var val_20 = (0 + (((0 + ((val_17 - 1)) << 2) + 16 - 1)) << 2) + 16 + 8;
            val_20 = val_20 + val_16;
            mem[1152921513929023384] = val_20;
            this.RecalculateCellSize();
            if(this >= 1)
            {
                    do
            {
                var val_3 = 4 - 4;
                object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  this.lineWord);
                val_15 = this.lineWord;
                if(this.lineWord <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                string val_5 = 2621443.ToUpper();
                if(val_15 != 0)
            {
                    val_18 = val_15;
                this.lineWord.answer = 2621443;
                this.lineWord.cellSize = 3.673424E-39f;
                val_15.SetLineWidth();
                val_15.Build(cellType:  this.cell, clickable:  true);
            }
            else
            {
                    val_18 = 12;
                mem[12] = 2621443;
                mem[16] = 2621443;
                val_15.SetLineWidth();
                val_15.Build(cellType:  this.cell, clickable:  true);
            }
            
                UnityEngine.Transform val_6 = val_15.transform;
                UnityEngine.Transform val_7 = this.transform;
                val_13 = this;
                val_15.SetParent(p:  732241776);
                UnityEngine.Transform val_8 = val_15.transform;
                val_17 = val_13;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
                val_15.localScale = new UnityEngine.Vector3();
                UnityEngine.Transform val_10 = val_15.transform;
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
                val_15.localPosition = new UnityEngine.Vector3();
                if((val_17 != 0) && ((wordListLevelProgress + 12) >= 1))
            {
                    if((wordListLevelProgress + 12) <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(val_15 != 0)
            {
                    val_15.SetProgress(progress:  wordListLevelProgress + 8 + 16);
            }
            else
            {
                    val_15.SetProgress(progress:  wordListLevelProgress + 8 + 16);
            }
            
                if(this.lineWord.isShown != false)
            {
                    val_17 = this.answers;
                bool val_12 = val_17.Add(item:  2621443);
            }
            
            }
            
                val_18.Add(item:  val_15);
                var val_13 = 4 + 1;
            }
            while((4 - 3) < (wordList + 12));
            
            }
            
            System.Collections.IEnumerator val_15 = val_13.ScaleToPositionAndFitLate();
            UnityEngine.Coroutine val_16 = val_13.StartCoroutine(routine:  732241776);
        }
        public void ShowAnwer(string answer)
        {
            System.Collections.Generic.HashSet<System.String> val_5 = this.answers;
            if((val_5.Contains(item:  answer)) == true)
            {
                    return;
            }
            
            val_5 = this.answers;
            bool val_2 = val_5.Add(item:  answer);
            LineWord val_3 = this.FindLine(answer:  answer);
            bool val_4 = UnityEngine.Object.op_Equality(x:  732390640, y:  0);
            if(val_4 != false)
            {
                    return;
            }
            
            if(val_4 == true)
            {
                    return;
            }
            
            R4.ShowAnswer(waitTime:  null);
        }
        public void RestoreAnswers()
        {
            var val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            if((this.answers.Contains(item:  val_3 + 12)) == false)
            {
                goto label_6;
            }
            
            val_3.SetAnswer();
            goto label_6;
            label_2:
            Dispose();
        }
        public LineWord FindLine(string answer)
        {
            object val_1 = new System.Object();
            typeof(WordRegionPage.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = answer;
            System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  436260864, method:  new IntPtr(732615216));
            if(this != 0)
            {
                    return this.Find(match:  8040448);
            }
            
            return this.Find(match:  8040448);
        }
        public bool ContainsLine(string answer)
        {
            LineWord val_1 = this.FindLine(answer:  answer);
            return UnityEngine.Object.op_Inequality(x:  732760432, y:  0);
        }
        public WordRegionPage()
        {
        
        }
    
    }

}
