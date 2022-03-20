using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLWordRegion : MonoSingleton<SLC.Wordlicious.WOLWordRegion>, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
    {
        // Fields
        public const int MaxWordsPerPage = 12;
        private UnityEngine.UI.Text levelText;
        private LineWord lineWordPrefab;
        private Cell cell;
        private SLC.Wordlicious.WordRegionPage page;
        private UGUIPageDisplay pageDisplay;
        protected UnityEngine.RectTransform safeAreaWithinParent;
        protected SLC.Wordlicious.WOLLevel level;
        private System.Collections.Generic.List<string> wordList;
        private System.Collections.Generic.HashSet<string> foundWords;
        private System.Collections.Generic.List<SLC.Wordlicious.WordRegionPage> pages;
        private int numPages;
        
        // Methods
        public override void InitMonoSingleton()
        {
        
        }
        public void Load(SLC.Wordlicious.WOLLevel level)
        {
            this.level = level;
            System.Collections.IEnumerator val_1 = this.LoadCoroutine();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  729226304);
        }
        public void Save(SLC.Wordlicious.WOLLevel level)
        {
            SLC.Wordlicious.WOLWordRegion val_9;
            var val_10;
            var val_12;
            var val_13;
            var val_14;
            SLC.Wordlicious.WOLWordRegion val_15;
            var val_16;
            var val_17;
            val_9 = this;
            level.<progress>k__BackingField.ResetWordRegionLetters();
            val_10 = 0;
            if(this.numPages < 1)
            {
                    return;
            }
            
            val_12 = 1152921511116727136;
            val_13 = "1";
            label_43:
            if(this.pages == 0)
            {
                    val_10 = val_10;
            }
            
            if(this.numPages <= val_10)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_10 = val_10;
            }
            
            val_9 = val_9 + 0;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_36:
            if(MoveNext() == false)
            {
                goto label_22;
            }
            
            System.Text.StringBuilder val_4 = new System.Text.StringBuilder();
            val_16 = mem[val_3 + 20];
            val_16 = val_3 + 20;
            if(val_16 == 0)
            {
                    val_16 = val_16;
            }
            
            List.Enumerator<T> val_5 = GetEnumerator();
            var val_10 = 0;
            label_28:
            if(MoveNext() == false)
            {
                goto label_25;
            }
            
            if((val_7 + 36) == 0)
            {
                    val_13 = "0";
            }
            
            System.Text.StringBuilder val_8 = Append(value:  1254115712);
            goto label_28;
            label_25:
            val_10 = val_10 + 1;
            mem2[0] = 131;
            Dispose();
            if(val_10 != 1)
            {
                    if(val_10 > 1)
            {
                    0 = 1;
            }
            
                var val_11 = 729342576 + ((0 + 1)) << 2;
                val_11 = val_11 - 131;
                val_11 = val_11 >> 5;
                val_11 = 1 & val_11;
                val_10 = val_10 - val_11;
            }
            
            level + 36 + 12.Add(item:  24121344);
            goto label_36;
            label_22:
            val_14 = 0 + 1;
            mem2[0] = 178;
            Dispose();
            val_15 = val_9;
            if(val_14 != 1)
            {
                    if(val_14 > 1)
            {
                    0 = 1;
            }
            
                var val_12 = 729342576 + ((0 + 1)) << 2;
                val_12 = val_12 - 178;
                val_12 = val_12 >> 5;
                val_12 = 1 & val_12;
                val_17 = val_14 - val_12;
            }
            else
            {
                    val_17 = 0;
            }
            
            var val_13 = val_10;
            val_13 = val_13 + 1;
            if(val_13 < this.numPages)
            {
                goto label_43;
            }
        
        }
        public void ShowAnswer(string answer)
        {
            var val_3;
            float val_4;
            System.Collections.Generic.List<SLC.Wordlicious.WordRegionPage> val_5;
            if(this.numPages >= 1)
            {
                    val_3 = 0;
                val_4 = 0;
                do
            {
                var val_1 = 4 - 4;
                if(this.numPages <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = 2621443;
                bool val_2 = val_5.ContainsLine(answer:  answer);
                if(val_2 != false)
            {
                    val_5 = this.pages;
                if(val_2 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_1;
                val_4 = 3.673424E-39f;
            }
            
                var val_3 = 4 + 1;
            }
            while((4 - 3) < this.numPages);
            
            }
            else
            {
                    val_4 = 0;
                val_3 = 0;
            }
            
            if(0 == 0)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = answer;
                UnityEngine.Debug.LogErrorFormat(format:  729467264, args:  472754880);
                return;
            }
            
            this.pageDisplay.SetToPage(index:  0, force:  false);
            val_4.ShowAnwer(answer:  answer);
        }
        public void ShowHint(bool free = False, LineWord line, Cell cell)
        {
            Cell val_12;
            UnityEngine.Object val_13;
            var val_14;
            var val_15;
            System.Func<LineWord, System.Int32> val_17;
            var val_18;
            var val_19;
            System.Func<LineWord, System.Boolean> val_21;
            var val_22;
            val_12 = cell;
            val_13 = line;
            bool val_1 = UnityEngine.Object.op_Equality(x:  val_13, y:  0);
            if(val_1 == false)
            {
                goto label_3;
            }
            
            if(this.numPages < 1)
            {
                goto label_4;
            }
            
            val_14 = 0;
            label_21:
            if(val_1 <= val_14)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + 0;
            val_15 = null;
            val_15 = null;
            val_17 = WOLWordRegion.<>c.<>9__16_0;
            if(val_17 == 0)
            {
                    val_17 = null;
                val_17 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WOLWordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(729612208));
                WOLWordRegion.<>c.<>9__16_0 = val_17;
            }
            
            System.Linq.IOrderedEnumerable<TSource> val_3 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  (0 + 0) + 16 + 24, keySelector:  7720960);
            val_19 = null;
            val_19 = null;
            val_21 = WOLWordRegion.<>c.<>9__16_1;
            if(val_21 == 0)
            {
                    val_21 = null;
                val_21 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  WOLWordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(729613232));
                WOLWordRegion.<>c.<>9__16_1 = val_21;
            }
            
            object val_5 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  (0 + 0) + 16 + 24, predicate:  7720960);
            if(((0 + 0) + 16 + 24) != 0)
            {
                goto label_20;
            }
            
            val_14 = val_14 + 1;
            if(val_14 < this.numPages)
            {
                goto label_21;
            }
            
            val_14 = 0;
            goto label_22;
            label_3:
            if(this.numPages < 1)
            {
                goto label_30;
            }
            
            var val_14 = 0;
            val_18 = 1152921513926395824;
            label_29:
            if(val_1 <= val_14)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + 0;
            if(((0 + 0) + 16 + 24.Contains(item:  val_13)) == true)
            {
                goto label_28;
            }
            
            val_14 = val_14 + 1;
            if(val_14 < this.numPages)
            {
                goto label_29;
            }
            
            goto label_30;
            label_4:
            val_14 = 0;
            goto label_31;
            label_20:
            val_13 = (0 + 0) + 16 + 24;
            label_22:
            val_12 = val_12;
            label_31:
            val_22 = val_14;
            goto label_33;
            label_28:
            val_22 = val_14;
            label_33:
            this.pageDisplay.SetToPage(index:  0, force:  false);
            label_30:
            if(val_13 == 0)
            {
                    return;
            }
            
            if(val_13 != 0)
            {
                    UnityEngine.Vector3 val_9 = ShowHint(cell:  val_13);
            }
            else
            {
                    UnityEngine.Vector3 val_10 = ShowHint(cell:  0);
            }
            
            if(line.isShown == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CheckAnswer(word:  line.answer, gridPath:  0);
        }
        public LineWord GetLineWord(string answer)
        {
            var val_3;
            UnityEngine.Object val_4;
            if(this.numPages >= 1)
            {
                    val_3 = 0;
                do
            {
                if(this.numPages <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 0;
                LineWord val_1 = (0 + 0) + 16.FindLine(answer:  answer);
                val_4 = (0 + 0) + 16;
                if(val_4 != 0)
            {
                    return;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < this.numPages);
            
            }
            
            val_4 = 0;
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_3;
            var val_6;
            var val_7;
            UnityEngine.Vector2 val_8;
            var val_9;
            if(eventData != 0)
            {
                    val_8 = eventData.<position>k__BackingField;
            }
            else
            {
                    val_9 = 4;
                val_8 = 4;
            }
            
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 9.476976E-13f, y = 5.605194E-45f}, b:  new UnityEngine.Vector2() {x = 5.605194E-45f, y = eventData.<pressPosition>k__BackingField});
            UnityEngine.Vector2 val_2 = normalized;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 9.476955E-13f, y = val_3});
            float val_8 = System.Math.Abs(val_7);
            float val_9 = System.Math.Abs(val_6);
            if(this.pageDisplay > 0)
            {
                    this.pageDisplay.PageLeft();
                return;
            }
            
            this.pageDisplay.PageRight();
        }
        private System.Collections.IEnumerator LoadCoroutine()
        {
            object val_1 = new System.Object();
            typeof(WOLWordRegion.<LoadCoroutine>d__21).__il2cppRuntimeField_8 = 0;
            typeof(WOLWordRegion.<LoadCoroutine>d__21).__il2cppRuntimeField_10 = this;
        }
        private int CompareWords(string x, string y)
        {
            var val_3;
            if(x == null)
            {
                goto label_0;
            }
            
            if(y == null)
            {
                goto label_1;
            }
            
            if((x.m_stringLength.CompareTo(value:  y.m_stringLength)) != 0)
            {
                    return (int)val_3;
            }
            
            int val_2 = x.CompareTo(strB:  y);
            return (int)val_3;
            label_0:
            if(y != null)
            {
                    y = 0;
            }
            
            val_3 = y;
            return (int)val_3;
            label_1:
            val_3 = 1;
            return (int)val_3;
        }
        public WOLWordRegion()
        {
            System.Collections.Generic.HashSet<UnityEngine.UI.Text> val_1 = new System.Collections.Generic.HashSet<UnityEngine.UI.Text>();
            this.foundWords = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.pages = null;
        }
    
    }

}
