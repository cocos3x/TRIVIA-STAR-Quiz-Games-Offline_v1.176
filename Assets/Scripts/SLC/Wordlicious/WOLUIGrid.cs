using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLUIGrid : MonoSingleton<SLC.Wordlicious.WOLUIGrid>, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
    {
        // Fields
        private SLC.Wordlicious.WOLLetterTile letterTile;
        public UnityEngine.Transform centerPoint;
        private UnityEngine.Vector3 cellSize;
        private UGUIFadeCanvasGroup myFader;
        private UnityEngine.CanvasGroup canvasGroup;
        public System.Collections.Generic.List<SLC.Wordlicious.WOLLetterTile> tiles;
        private System.Collections.Generic.List<UnityEngine.Vector3> letterPositions;
        private System.Collections.Generic.List<UnityEngine.Vector3> letterLocalPositions;
        private bool levelLoaded;
        private bool didDrag;
        
        // Methods
        public override void InitMonoSingleton()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  725219648);
            this.canvasGroup = this;
            this.interactable = false;
            this.canvasGroup.blocksRaycasts = false;
        }
        public void Start()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  725336768, method:  new IntPtr(725311744));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_48, b:  7401472);
            val_4 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_48;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_48 = val_4;
        }
        public void HighlightLetter(int i, bool state)
        {
            if(true <= i)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (i << 2);
            if(((0 + (i) << 2) + 16) == 0)
            {
                
            }
        
        }
        public void UnhighlightAllLetters()
        {
            var val_1 = 0;
            goto label_1;
            label_6:
            if(true <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            val_1 = 1;
            label_1:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_6;
            }
        
        }
        public int IsInRectofAnyTile(UnityEngine.Vector2 mousePos)
        {
            goto label_1;
            label_13:
            if(true <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            bool val_2 = UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(rect:  static_value_00280017, screenPoint:  new UnityEngine.Vector2() {x = mousePos.x, y = mousePos.y}, cam:  0);
            if(val_2 == true)
            {
                    return 0;
            }
            
            4 = 5;
            label_1:
            if((4 - 4) < val_2)
            {
                goto label_13;
            }
            
            return 0;
        }
        public bool ValidNeighbors(int indexA, int indexB)
        {
            UnityEngine.Object val_3;
            if(true <= indexA)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            indexA = indexA + (indexA << 2);
            val_3 = mem[(indexA + (indexA) << 2) + 16];
            val_3 = (indexA + (indexA) << 2) + 16;
            var val_4 = 0;
            bool val_1 = UnityEngine.Object.op_Equality(x:  val_3, y:  0);
            if(val_1 == true)
            {
                    return false;
            }
            
            if(val_1 <= indexA)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (indexA << 2);
            val_3 = mem[(0 + (indexA) << 2) + 16];
            val_3 = (0 + (indexA) << 2) + 16;
            if(((0 + (indexA) << 2) + 16 + 28) == 0)
            {
                    return false;
            }
            
            if(((0 + (indexA) << 2) + 16 + 28) <= indexB)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (indexB << 2);
            val_3 = mem[(0 + (indexB) << 2) + 16];
            val_3 = (0 + (indexB) << 2) + 16;
            bool val_2 = UnityEngine.Object.op_Equality(x:  val_3, y:  0);
            if(val_2 == true)
            {
                    return false;
            }
            
            if(val_2 <= indexB)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (indexB << 2);
            if(((0 + (indexB) << 2) + 16 + 28) == 0)
            {
                    return false;
            }
            
            if(((0 + (indexB) << 2) + 16 + 28) <= indexA)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (indexA << 2);
            if(val_6 <= indexB)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (indexB << 2);
            if(((0 + (indexA) << 2) + 16 + 28) != 0)
            {
                    return (0 + (indexA) << 2) + 16 + 28.IsNeighbor(tile:  (0 + (indexB) << 2) + 16 + 28);
            }
            
            return (0 + (indexA) << 2) + 16 + 28.IsNeighbor(tile:  (0 + (indexB) << 2) + 16 + 28);
        }
        public System.Collections.Generic.List<SLC.Wordlicious.Tile> GetTiles(System.Collections.Generic.List<int> indexes)
        {
            var val_2 = 0;
            goto label_1;
            label_8:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_2)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            if(val_2 <= ((0 + 0) + 16))
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (((0 + 0) + 16) << 2);
            Add(item:  (0 + ((0 + 0) + 16) << 2) + 16 + 28);
            val_2 = 1;
            label_1:
            if(val_2 < null)
            {
                goto label_8;
            }
        
        }
        public void LoadLevel(SLC.Wordlicious.WOLLevel level)
        {
            var val_9;
            SLC.Wordlicious.WOLLevel val_10;
            var val_11;
            var val_12;
            var val_13;
            val_9 = this;
            val_10 = level;
            this.CalculatePosition(level:  val_10);
            goto label_1;
            label_21:
            val_11 = 0;
            goto label_2;
            label_19:
            SLC.Wordlicious.Tile val_1 = val_10.GetTile(x:  0, y:  0);
            if(val_10 == 0)
            {
                goto label_4;
            }
            
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.letterTile);
            UnityEngine.Transform val_3 = this.letterTile.transform;
            this.letterTile.SetParent(p:  this.centerPoint);
            string val_4 = level.<level>k__BackingField.ToString();
            if(this.letterTile == 0)
            {
                goto label_9;
            }
            
            this.letterTile.letter = level.<level>k__BackingField;
            this.letterTile.<tile>k__BackingField = val_10;
            val_9 = val_9;
            if(this.letterTile >= 1)
            {
                    if(this.letterTile <= 0)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = 0 + 1;
                val_9 = val_9 + 0;
                this.letterTile.Deserialize(savedInfo:  (0 + 0) + 16);
            }
            else
            {
                    val_12 = 0;
            }
            
            this.tiles.Add(item:  this.letterTile);
            val_10 = val_10;
            label_4:
            val_11 = 1;
            label_2:
            if(val_11 < (level + 20))
            {
                goto label_19;
            }
            
            label_1:
            if(1 < (level + 24))
            {
                goto label_21;
            }
            
            System.Collections.IEnumerator val_5 = this.SetLettersPositions();
            val_13 = 0;
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  726166464);
            goto label_22;
            label_28:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_13)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + 0;
            Add(item:  (0 + 0) + 16);
            val_13 = 1;
            label_22:
            if(val_13 < null)
            {
                goto label_28;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Wordlicious.WOLTextPreview MonoSingleton<SLC.Wordlicious.WOLTextPreview>::get_Instance().__il2cppRuntimeField_1C = null;
            this.levelLoaded = true;
            return;
            label_9:
        }
        public void Save(SLC.Wordlicious.WOLLevel level)
        {
            string val_3;
            level.<progress>k__BackingField.ResetGridTiles();
            List.Enumerator<T> val_1 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            string val_4 = val_3.Serialize();
            level.<progress>k__BackingField.SaveGridTile(tileInfo:  val_3);
            goto label_7;
            label_4:
            Dispose();
        }
        public void EnableGrid()
        {
            this.canvasGroup.interactable = true;
            this.canvasGroup.blocksRaycasts = true;
            this.myFader.Execute();
        }
        public void AddHint(int x, int y)
        {
            goto label_1;
            label_13:
            if(true <= 35636084)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(1179648 != x)
            {
                goto label_6;
            }
            
            if(1179648 <= 35636084)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(548077568 == y)
            {
                goto label_11;
            }
            
            label_6:
            4 = 5;
            label_1:
            if((4 - 4) < 548077568)
            {
                goto label_13;
            }
            
            return;
            label_11:
            if(548077568 <= 35636084)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            2621443.SetStatus(status:  1);
        }
        public void ClearHints()
        {
            goto label_1;
            label_13:
            if(true <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            2621443.SetStatus(status:  0);
            if(2621443 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            4 = 5;
            label_1:
            if((4 - 4) < 2621443)
            {
                goto label_13;
            }
        
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BeginDrag();
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.didDrag = true;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DoDrag(mousePos:  new UnityEngine.Vector2() {x = eventData.<position>k__BackingField, y = eventData});
        }
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.didDrag = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            EndDrag(checkAnswer:  true);
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DoPointerDown(mousePos:  new UnityEngine.Vector2() {x = eventData.<position>k__BackingField, y = eventData});
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DoPointerUp(mousePos:  new UnityEngine.Vector2() {x = eventData.<position>k__BackingField, y = eventData});
        }
        public void OnWordSubmited(string word)
        {
            goto label_1;
            label_19:
            if(true <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 < 1)
            {
                goto label_6;
            }
            
            if(0 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 == 0)
            {
                goto label_11;
            }
            
            label_6:
            if(0 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            2621443.SetStatus(status:  2);
            label_11:
            if(2621443 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            2621443.UpdateTile();
            4 = 5;
            label_1:
            if((4 - 4) < 2621443)
            {
                goto label_19;
            }
        
        }
        private void OnRectTransformDimensionsChange()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = UnityEngine.Object.op_Implicit(exists:  722363712);
            if(val_2 == true)
            {
                    val_2 = this.levelLoaded;
            }
            
            if(val_2 == false)
            {
                    return;
            }
            
            R4.Invoke(methodName:  727631488, time:  null);
        }
        private void RecalculatePanPositions()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(this.activeInHierarchy == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = this.gameObject;
            if(this.activeSelf == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.letterLocalPositions.Clear();
            this.letterPositions.Clear();
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.CalculatePosition(level:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_38);
            System.Collections.IEnumerator val_7 = this.SetLettersPositions();
            UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  727775808);
        }
        private void CalculatePosition(SLC.Wordlicious.WOLLevel level)
        {
            float val_12;
            float val_13;
            float val_14;
            SLC.Wordlicious.WOLLevel val_17;
            int val_18;
            int val_19;
            var val_20;
            var val_21;
            var val_22;
            float val_23;
            var val_24;
            var val_25;
            val_17 = level;
            if(val_17 != 0)
            {
                    val_18 = level.<width>k__BackingField;
            }
            else
            {
                    val_18 = 1.401298E-45f;
            }
            
            val_19 = level.<height>k__BackingField;
            val_20 = 0;
            val_21 = 0;
            goto label_3;
            label_14:
            val_22 = 0;
            goto label_4;
            label_12:
            SLC.Wordlicious.Tile val_1 = val_17.GetTile(x:  0, y:  0);
            val_23 = val_17;
            if(val_17 != 0)
            {
                    float val_18 = 0f;
                var val_17 = mem[1152921513924681688];
                val_17 = val_17 * 0f;
                val_18 = mem[1152921513924681684] * val_18;
                float val_2 = val_17 ^ 2147483648;
                UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  val_18, y:  null);
                val_23 = val_3.z;
                mem[1152921513924681712].Add(item:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_23});
                val_18 = System.Math.Min(val1:  0, val2:  1);
                val_21 = System.Math.Max(val1:  0, val2:  0);
                val_17 = val_17;
                val_19 = System.Math.Min(val1:  0, val2:  val_19);
            }
            
            val_22 = 1;
            label_4:
            if(val_22 < 1)
            {
                goto label_12;
            }
            
            val_20 = val_20 + 1;
            label_3:
            if(val_20 < (level + 24))
            {
                goto label_14;
            }
            
            int val_19 = System.Math.Max(val1:  0, val2:  0);
            float val_21 = 0.5f;
            float val_20 = -0.5f;
            val_19 = val_19 - val_18;
            val_20 = (float)val_19 * val_20;
            val_21 = ((float)val_21 - val_19) * val_21;
            val_20 = val_20 * mem[1152921513924681684];
            val_21 = val_21 * mem[1152921513924681688];
            UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_21, y:  null);
            val_24 = 0;
            goto label_15;
            label_29:
            if((mem[1152921513924681712] + 12) <= val_24)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_22 = mem[1152921513924681712] + 8;
            val_22 = val_22 + 0;
            var val_10 = val_22 + 16;
            val_22 = 0;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 8.053634E-13f, y = mem[((mem[1152921513924681712] + 8 + 0) + 16) + (0)], z = mem[((mem[1152921513924681712] + 8 + 0) + 16) + (4)]}, b:  new UnityEngine.Vector3() {x = mem[((mem[1152921513924681712] + 8 + 0) + 16) + (8)], y = val_9.x, z = val_9.y});
            mem[1152921513924681712].set_Item(index:  0, value:  new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_14});
            val_25 = mem[1152921513924681680];
            if((mem[1152921513924681712] + 12) <= val_24)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_23 = mem[1152921513924681712] + 8;
            val_23 = val_23 + 0;
            val_18 = mem[(mem[1152921513924681712] + 8 + 0) + 16];
            val_18 = (mem[1152921513924681712] + 8 + 0) + 16;
            val_19 = mem[(mem[1152921513924681712] + 8 + 0) + 20];
            val_19 = (mem[1152921513924681712] + 8 + 0) + 20;
            val_23 = mem[(mem[1152921513924681712] + 8 + 0) + 24];
            val_23 = (mem[1152921513924681712] + 8 + 0) + 24;
            if(val_25 == 0)
            {
                goto label_22;
            }
            
            if(val_25 != null)
            {
                    if(val_25 == 0)
            {
                goto label_26;
            }
            
            }
            
            if(val_25 == null)
            {
                goto label_25;
            }
            
            goto label_26;
            label_22:
            label_26:
            val_25 = 0;
            label_25:
            UnityEngine.Vector3 val_15 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_18, z = val_19});
            mem[1152921513924681708].Add(item:  new UnityEngine.Vector3());
            val_24 = val_24 + 1;
            label_15:
            if(val_24 < (mem[1152921513924681712] + 12))
            {
                goto label_29;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Wordlicious.WOLLineDrawer MonoSingleton<SLC.Wordlicious.WOLLineDrawer>::get_Instance().__il2cppRuntimeField_C = mem[1152921513924681708];
        }
        private System.Collections.IEnumerator SetLettersPositions()
        {
            object val_1 = new System.Object();
            typeof(WOLUIGrid.<SetLettersPositions>d__31).__il2cppRuntimeField_8 = 0;
            typeof(WOLUIGrid.<SetLettersPositions>d__31).__il2cppRuntimeField_10 = this;
        }
        private void Clear()
        {
            this.tiles.Clear();
            this.letterPositions.Clear();
        }
        public WOLUIGrid()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.tiles = null;
            this.letterPositions = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.letterLocalPositions = new System.Collections.Generic.List<UnityEngine.Vector3>();
        }
    
    }

}
