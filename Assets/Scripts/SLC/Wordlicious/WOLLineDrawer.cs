using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLLineDrawer : MonoSingleton<SLC.Wordlicious.WOLLineDrawer>
    {
        // Fields
        public System.Collections.Generic.List<UnityEngine.Vector3> letterPositions;
        public System.Collections.Generic.List<bool> allowedPositions;
        public System.Collections.Generic.List<int> currentIndexes;
        public System.Collections.Generic.List<UnityEngine.Vector3> points;
        public System.Collections.Generic.List<UnityEngine.Vector3> positions;
        public SLC.Wordlicious.WOLTextPreview textPreview;
        private UnityEngine.LineRenderer lineRenderer;
        private UnityEngine.Vector2 mousePoint;
        private bool isDragging;
        private int downOnIndex;
        
        // Methods
        private void Start()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.lineRenderer = this;
            this.sortingLayerName = -2084533408;
        }
        public void BeginDrag()
        {
            this.isDragging = true;
        }
        public void DoDrag(UnityEngine.Vector2 mousePos)
        {
            float val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_10 = mousePos.x;
            this.mousePoint = mousePos;
            mem[1152921513909471388] = mousePos.y;
            val_11 = 1152921511437609888;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_12 = public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance();
            int val_2 = IsInRectofAnyTile(mousePos:  new UnityEngine.Vector2() {x = val_10, y = mousePos.y});
            if(val_2 == 1)
            {
                goto label_32;
            }
            
            if(val_2 < 2)
            {
                goto label_10;
            }
            
            if(this.currentIndexes != 0)
            {
                    val_14 = val_2;
            }
            else
            {
                    val_14 = 0;
                val_13 = 0;
            }
            
            val_12 = -2;
            if(val_13 <= val_12)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + 4294967288;
            if(((0 + 4294967288) + 16) != val_2)
            {
                goto label_10;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(this.currentIndexes == 0)
            {
                goto label_13;
            }
            
            val_16 = public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance();
            goto label_14;
            label_10:
            if(((this.currentIndexes.Contains(item:  val_2)) == true) || ((this.ValidTile(index:  val_2)) == false))
            {
                goto label_17;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HighlightLetter(i:  val_2, state:  true);
            this.currentIndexes.Add(item:  val_2);
            goto label_22;
            label_13:
            val_11 = 12;
            val_16 = 0;
            val_15 = 0;
            label_14:
            val_12 = -1;
            if(val_15 <= val_12)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + 4294967292;
            HighlightLetter(i:  (0 + 4294967292) + 16, state:  false);
            if(this.currentIndexes != 0)
            {
                
            }
            else
            {
                    val_17 = 0;
            }
            
            this.currentIndexes.RemoveAt(index:  val_17 - 1);
            label_22:
            this.textPreview.SetIndexes(indexes:  this.currentIndexes);
            label_17:
            if(this.currentIndexes >= 1)
            {
                    this.textPreview.SetActive(isActive:  true, useButtons:  false);
                this.textPreview.FadeIn();
            }
            else
            {
                    this.textPreview.SetActive(isActive:  false, useButtons:  false);
            }
            
            label_32:
            this.BuildPoints(includeMousePoint:  false);
            if(this < 2)
            {
                    return;
            }
            
            if(this.isDragging == false)
            {
                    return;
            }
            
            T[] val_8 = this.points.ToArray();
            System.Collections.Generic.List<UnityEngine.Vector3> val_9 = iTween.GetSmoothPoints(points:  this.points, smooth:  8);
            this.positions = this.points;
            this.lineRenderer.positionCount = this.points;
            T[] val_10 = this.positions.ToArray();
            this.lineRenderer.SetPositions(positions:  this.positions);
        }
        public void EndDrag(bool checkAnswer = True)
        {
            SLC.Wordlicious.WOLTextPreview val_7 = this.textPreview;
            if(val_7.IsInvisibleOrFading() != false)
            {
                    return;
            }
            
            if(checkAnswer != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                System.Collections.Generic.List<SLC.Wordlicious.Tile> val_3 = GetTiles(indexes:  this.currentIndexes);
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_7 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance();
                string val_5 = this.textPreview.GetText();
                CheckAnswer(word:  this.textPreview, gridPath:  -1759171680);
            }
            else
            {
                    this.textPreview.FadeOut();
            }
            
            this.isDragging = false;
            this.currentIndexes.Clear();
            this.lineRenderer.positionCount = 0;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnhighlightAllLetters();
        }
        public void DoPointerDown(UnityEngine.Vector2 mousePos)
        {
            float val_7;
            SLC.Wordlicious.WOLTextPreview val_8;
            val_7 = mousePos.x;
            if(this.isDragging != false)
            {
                    return;
            }
            
            this.downOnIndex = 0;
            this.mousePoint = mousePos;
            mem[1152921513909863324] = mousePos.y;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance();
            int val_2 = IsInRectofAnyTile(mousePos:  new UnityEngine.Vector2() {x = val_7, y = mousePos.y});
            if(val_2 != 1)
            {
                    if(val_2 == 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                HighlightLetter(i:  val_2, state:  true);
                this.currentIndexes.Add(item:  val_2);
                val_8 = this.textPreview;
                val_8.SetIndexes(indexes:  this.currentIndexes);
                this.downOnIndex = val_2;
            }
            
                if(this.currentIndexes >= 1)
            {
                    this.textPreview.SetActive(isActive:  true, useButtons:  false);
                this.textPreview.FadeIn();
            }
            else
            {
                    this.textPreview.SetActive(isActive:  false, useButtons:  false);
            }
            
            }
            
            this.BuildPoints(includeMousePoint:  false);
            if(this < 2)
            {
                    this.lineRenderer.positionCount = 0;
                return;
            }
            
            T[] val_4 = this.points.ToArray();
            System.Collections.Generic.List<UnityEngine.Vector3> val_5 = iTween.GetSmoothPoints(points:  this.points, smooth:  8);
            this.positions = this.points;
            this.lineRenderer.positionCount = this.points;
            T[] val_6 = this.positions.ToArray();
            this.lineRenderer.SetPositions(positions:  this.positions);
        }
        public void DoPointerUp(UnityEngine.Vector2 mousePos)
        {
            float val_15;
            var val_16;
            int val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            val_15 = mousePos.x;
            if(this.isDragging != false)
            {
                    return;
            }
            
            this.mousePoint = mousePos;
            mem[1152921513910122780] = mousePos.y;
            val_16 = 1152921511437609888;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance();
            int val_2 = IsInRectofAnyTile(mousePos:  new UnityEngine.Vector2() {x = val_15, y = mousePos.y});
            if(val_2 == 1)
            {
                goto label_50;
            }
            
            if(val_2 >= 1)
            {
                    if(this.currentIndexes != 0)
            {
                    val_19 = val_2;
            }
            else
            {
                    val_20 = 12;
                val_19 = 0;
                val_18 = 0;
            }
            
                val_17 = -1;
                if(val_18 <= val_17)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_16 = val_16 + 4294967292;
                if(((0 + 4294967292) + 16) == val_2)
            {
                    if(this.downOnIndex != val_2)
            {
                goto label_12;
            }
            
            }
            
            }
            
            if((this.downOnIndex < 2) || ((this.currentIndexes.Contains(item:  val_2)) == false))
            {
                goto label_16;
            }
            
            val_20 = this.currentIndexes.IndexOf(item:  val_2);
            val_21 = 0;
            goto label_18;
            label_25:
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance()) <= val_21)
            {
                    var val_17 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = val_17 + 0;
            val_17 = mem[(0 + 0) + 16];
            val_17 = (0 + 0) + 16;
            if(val_21 <= val_20)
            {
                    0 = 1;
            }
            
            HighlightLetter(i:  val_17, state:  true);
            val_21 = 1;
            label_18:
            if(val_21 < (public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance()))
            {
                goto label_25;
            }
            
            if(this.currentIndexes == 0)
            {
                goto label_26;
            }
            
            goto label_27;
            label_16:
            if(((this.currentIndexes.Contains(item:  val_2)) == true) || ((this.ValidTile(index:  val_2)) == false))
            {
                goto label_30;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HighlightLetter(i:  val_2, state:  true);
            this.currentIndexes.Add(item:  val_2);
            goto label_40;
            label_12:
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(this.currentIndexes == 0)
            {
                goto label_38;
            }
            
            val_24 = public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance();
            goto label_39;
            label_26:
            val_22 = 0;
            label_27:
            this.currentIndexes.RemoveRange(index:  val_20 + 1, count:  val_22 + (~val_20));
            goto label_40;
            label_38:
            val_16 = 12;
            val_24 = 0;
            val_23 = 0;
            label_39:
            val_17 = -1;
            if(val_23 <= val_17)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + 4294967292;
            HighlightLetter(i:  (0 + 4294967292) + 16, state:  false);
            if(this.currentIndexes != 0)
            {
                
            }
            else
            {
                    val_25 = 0;
            }
            
            this.currentIndexes.RemoveAt(index:  val_25 - 1);
            label_40:
            this.textPreview.SetIndexes(indexes:  this.currentIndexes);
            label_30:
            if(this.currentIndexes >= 1)
            {
                    this.textPreview.SetActive(isActive:  true, useButtons:  true);
                this.textPreview.FadeIn();
            }
            else
            {
                    this.textPreview.SetActive(isActive:  false, useButtons:  false);
            }
            
            label_50:
            this.BuildPoints(includeMousePoint:  false);
            if(this < 2)
            {
                    this.lineRenderer.positionCount = 0;
                return;
            }
            
            T[] val_13 = this.points.ToArray();
            System.Collections.Generic.List<UnityEngine.Vector3> val_14 = iTween.GetSmoothPoints(points:  this.points, smooth:  8);
            this.positions = this.points;
            this.lineRenderer.positionCount = this.points;
            T[] val_15 = this.positions.ToArray();
            this.lineRenderer.SetPositions(positions:  this.positions);
        }
        private bool ValidTile(int index)
        {
            var val_2;
            var val_3;
            if(true == 0)
            {
                    return true;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(this.currentIndexes != 0)
            {
                    val_3 = public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance();
            }
            else
            {
                    val_3 = 0;
                val_2 = 0;
            }
            
            if(val_2 <= (-1))
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 4294967292;
            if((public static SLC.Wordlicious.WOLUIGrid MonoSingleton<SLC.Wordlicious.WOLUIGrid>::get_Instance()) != 0)
            {
                    return ValidNeighbors(indexA:  index, indexB:  (0 + 4294967292) + 16);
            }
            
            return ValidNeighbors(indexA:  index, indexB:  (0 + 4294967292) + 16);
        }
        private void BuildPoints(bool includeMousePoint = True)
        {
            var val_3;
            float val_8;
            float val_9;
            float val_11;
            float val_12;
            var val_15;
            System.Collections.Generic.List<UnityEngine.Vector3> val_16;
            this.points.Clear();
            List.Enumerator<T> val_1 = GetEnumerator();
            label_7:
            bool val_2 = MoveNext();
            if(val_2 == false)
            {
                goto label_3;
            }
            
            if(val_2 <= val_3)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + ((val_3 + (val_3 << 1)) << 2);
            this.points.Add(item:  new UnityEngine.Vector3() {x = (0 + ((val_3 + (val_3) << 1)) << 2) + 16, y = (0 + ((val_3 + (val_3) << 1)) << 2) + 20, z = (0 + ((val_3 + (val_3) << 1)) << 2) + 24});
            goto label_7;
            label_3:
            Dispose();
            if(includeMousePoint == false)
            {
                    return;
            }
            
            if(includeMousePoint != true)
            {
                goto label_10;
            }
            
            label_21:
            UnityEngine.Camera val_5 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 2.452814E-13f, y = mem[this.mousePoint + (0)]});
            UnityEngine.Vector3 val_10 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_8, z = val_9});
            val_16 = this.points;
            val_16.Add(item:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = 90f});
            return;
            label_10:
            if(includeMousePoint < true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_15 = this;
            if((IsInRectofAnyTile(mousePos:  new UnityEngine.Vector2() {x = this.mousePoint, y = R6})) == 1)
            {
                goto label_21;
            }
        
        }
        public void MakeParticles()
        {
            var val_2 = 0;
            goto label_1;
            label_8:
            if((new System.Collections.Generic.List<UnityEngine.Vector3>()) <= val_2)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            if(val_3 <= ((0 + 0) + 16))
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + ((((0 + 0) + 16) + (((0 + 0) + 16) << 1)) << 2);
            Add(item:  new UnityEngine.Vector3() {x = (0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16, y = (0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 20, z = (0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 24});
            val_2 = 1;
            label_1:
            if(val_2 < null)
            {
                goto label_8;
            }
        
        }
        public bool IsDragging()
        {
            return (bool)this.isDragging;
        }
        public void OnWordFound()
        {
            if(true == 0)
            {
                    return;
            }
            
            this.MakeParticles();
        }
        public WOLLineDrawer()
        {
            this.letterPositions = new System.Collections.Generic.List<UnityEngine.Vector3>();
            System.Collections.Generic.List<System.Boolean> val_2 = new System.Collections.Generic.List<System.Boolean>();
            this.allowedPositions = null;
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            this.currentIndexes = null;
            this.points = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.downOnIndex = 0;
            this.positions = new System.Collections.Generic.List<UnityEngine.Vector3>();
        }
    
    }

}
