using UnityEngine;

namespace SRF.UI.Layout
{
    public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler, IEventSystemHandler
    {
        // Fields
        private readonly SRF.SRList<object> _itemList;
        private readonly SRF.SRList<int> _visibleItemList;
        private bool _isDirty;
        private SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row> _rowCache;
        private UnityEngine.UI.ScrollRect _scrollRect;
        private int _selectedIndex;
        private object _selectedItem;
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent _selectedItemChanged;
        private int _visibleItemCount;
        private SRF.SRList<SRF.UI.Layout.VirtualVerticalLayoutGroup.Row> _visibleRows;
        public SRF.UI.StyleSheet AltRowStyleSheet;
        public bool EnableSelection;
        public UnityEngine.RectTransform ItemPrefab;
        public int RowPadding;
        public SRF.UI.StyleSheet RowStyleSheet;
        public SRF.UI.StyleSheet SelectedRowStyleSheet;
        public float Spacing;
        public bool StickToBottom;
        private float _itemHeight;
        
        // Properties
        public SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent SelectedItemChanged { get; set; }
        public object SelectedItem { get; set; }
        public override float minHeight { get; }
        private UnityEngine.UI.ScrollRect ScrollRect { get; }
        private bool AlignBottom { get; }
        private bool AlignTop { get; }
        private float ItemHeight { get; }
        
        // Methods
        public SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent get_SelectedItemChanged()
        {
        
        }
        public void set_SelectedItemChanged(SRF.UI.Layout.VirtualVerticalLayoutGroup.SelectedItemChangedEvent value)
        {
            this._selectedItemChanged = value;
        }
        public object get_SelectedItem()
        {
        
        }
        public void set_SelectedItem(object value)
        {
            object val_4;
            int val_5;
            val_4 = this._selectedItem;
            if(val_4 != value)
            {
                    value = this.EnableSelection;
            }
            
            if(value != true)
            {
                    return;
            }
            
            if(value == 0)
            {
                goto label_2;
            }
            
            int val_1 = this._itemList.IndexOf(item:  value);
            if(val_1 < 0)
            {
                goto label_4;
            }
            
            val_5 = val_1;
            val_4 = this._selectedItem;
            goto label_5;
            label_2:
            val_5 = 0;
            label_5:
            this._selectedIndex = val_5;
            if(value != 0)
            {
                    val_4 = this;
                value = val_5;
            }
            
            this._selectedItem = value;
            if(value != 0)
            {
                    this.InvalidateItem(itemIndex:  0);
            }
            
            this.SetDirty();
            bool val_2 = this.IsActive();
            if(val_2 == true)
            {
                    val_2 = true;
                this._isDirty = val_2;
            }
            
            if(this._selectedItemChanged == 0)
            {
                    return;
            }
            
            this._selectedItemChanged.Invoke(arg0:  this._selectedItem);
            return;
            label_4:
            System.InvalidOperationException val_3 = new System.InvalidOperationException(message:  394858096);
        }
        public override float get_minHeight()
        {
            float val_1 = this.ItemHeight;
            float val_4 = (float)this._itemList.top;
            val_4 = val_4 + (float)R7.bottom;
            return (float)(float)(float)R8;
        }
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_4;
            float val_5;
            var val_9;
            float val_13;
            var val_14;
            val_13 = 35634680;
            if(this.EnableSelection == false)
            {
                    return;
            }
            
            if((eventData.<pointerPressRaycast>k__BackingField) == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = eventData.<pointerPressRaycast>k__BackingField.transform;
            UnityEngine.Vector3 val_3 = position;
            val_13 = val_5;
            UnityEngine.RectTransform val_7 = this.rectTransform;
            UnityEngine.Vector3 val_8 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 9.155283E-25f, y = val_4, z = val_13});
            float val_10 = this.ItemHeight;
            float val_13 = System.Math.Abs(val_9);
            val_13 = val_13 / 395160528;
            int val_11 = UnityEngine.Mathf.FloorToInt(f:  val_13);
            if(val_11 < 0)
            {
                goto label_13;
            }
            
            val_13 = this._itemList;
            if(val_11 >= val_11)
            {
                goto label_13;
            }
            
            val_13 = this._itemList;
            object val_12 = val_13.Item[val_11];
            val_14 = val_13;
            goto label_15;
            label_13:
            val_14 = 0;
            label_15:
            this.SelectedItem = 0;
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.UI.ScrollRect val_1 = this.ScrollRect;
            UnityEngine.Events.UnityAction<UnityEngine.Vector2> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  395294352, method:  new IntPtr(395264912));
            this._rowCache.AddListener(call:  162353152);
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(413364224)});
            UnityEngine.Component val_4 = this.ItemPrefab.GetComponent(type:  413364224);
            if(this.ItemPrefab != 0)
            {
                    return;
            }
            
            UnityEngine.Debug.LogWarning(message:  395270032);
        }
        private void OnScrollRectValueChanged(UnityEngine.Vector2 d)
        {
            35634682 = this._scrollRect;
            35634682.verticalNormalizedPosition = UnityEngine.Mathf.Clamp01(value:  d.y);
            this.SetDirty();
            bool val_2 = this.IsActive();
            if(val_2 == true)
            {
                    val_2 = true;
                this._isDirty = val_2;
            }
        
        }
        protected override void Start()
        {
            this.Start();
            this.ScrollUpdate();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.SetDirty();
            bool val_1 = this.IsActive();
            if(val_1 == true)
            {
                    val_1 = true;
                this._isDirty = val_1;
            }
        
        }
        protected void Update()
        {
            if((true > 8) || ((455 & 1) != 0))
            {
                goto label_2;
            }
            
            label_9:
            if(this._selectedItem != 0)
            {
                    if((this._itemList.Contains(item:  this._selectedItem)) != true)
            {
                    this.SelectedItem = 0;
            }
            
            }
            
            if(this._isDirty == false)
            {
                    return;
            }
            
            this._isDirty = false;
            this.ScrollUpdate();
            return;
            label_2:
            UnityEngine.Debug.LogWarning(message:  395743952, context:  395768176);
            this.childAlignment = 0;
            goto label_9;
        }
        protected void InvalidateItem(int itemIndex)
        {
            SRF.SRList<System.Int32> val_5 = this._visibleItemList;
            if((val_5.Contains(item:  itemIndex)) == false)
            {
                    return;
            }
            
            bool val_2 = this._visibleItemList.Remove(item:  itemIndex);
            val_5 = 0;
            goto label_4;
            label_9:
            Row val_3 = this._visibleRows.Item[0];
            if(this._visibleRows == itemIndex)
            {
                goto label_7;
            }
            
            val_5 = 1;
            label_4:
            if(val_5 < this._visibleRows)
            {
                goto label_9;
            }
            
            return;
            label_7:
            Row val_4 = this._visibleRows.Item[0];
            this.RecycleRow(row:  this._visibleRows);
            this._visibleRows.RemoveAt(index:  0);
        }
        protected void RefreshIndexCache()
        {
            goto label_1;
            label_8:
            Row val_1 = this._visibleRows.Item[0];
            Row val_2 = this._visibleRows.Item[0];
            int val_3 = this._itemList.IndexOf(item:  this._visibleRows);
            0 = 1;
            mem2[0] = val_3;
            label_1:
            if(0 < val_3)
            {
                goto label_8;
            }
        
        }
        protected void ScrollUpdate()
        {
            var val_4;
            var val_24;
            var val_25;
            SRF.SRList<System.Object> val_26;
            int val_27;
            var val_28;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.RectTransform val_2 = this.rectTransform;
            UnityEngine.Vector2 val_3 = anchoredPosition;
            UnityEngine.UI.ScrollRect val_5 = this.ScrollRect;
            val_24 = 0;
            UnityEngine.Transform val_6 = this.transform;
            if(this != 0)
            {
                    if(null == null)
            {
                goto label_5;
            }
            
            }
            
            if(this != 0)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            label_6:
            if(null != null)
            {
                    val_24 = 0;
            }
            else
            {
                    val_24 = this;
            }
            
            label_9:
            UnityEngine.Rect val_7 = rect;
            float val_8 = height;
            float val_9 = this.ItemHeight;
            float val_10 = 396246512 + this.Spacing;
            val_25 = 0;
            val_10 = val_4 / val_10;
            float val_12 = this.ItemHeight;
            uint val_24 = 396246512;
            val_24 = val_24 + this.Spacing;
            val_24 = (val_4 + 396234456) / val_24;
            int val_25 = this.RowPadding;
            int val_16 = UnityEngine.Mathf.Max(a:  0, b:  (UnityEngine.Mathf.FloorToInt(f:  val_10)) - val_25);
            val_26 = this._itemList;
            val_25 = val_25 + (UnityEngine.Mathf.CeilToInt(f:  val_24));
            val_27 = val_16;
            int val_17 = UnityEngine.Mathf.Min(a:  val_16, b:  val_25);
            val_28 = 0;
            goto label_13;
            label_21:
            Row val_18 = this._visibleRows.Item[0];
            val_26 = this._visibleRows;
            if(this._visibleRows >= val_27)
            {
                    if(this._visibleRows <= val_17)
            {
                goto label_17;
            }
            
            }
            
            bool val_19 = this._visibleItemList.Remove(item:  this._visibleRows);
            bool val_20 = this._visibleRows.Remove(item:  val_26);
            this.RecycleRow(row:  val_26);
            val_28 = 1;
            label_17:
            val_25 = 1;
            label_13:
            if(val_25 < this)
            {
                goto label_21;
            }
            
            if(val_27 >= val_17)
            {
                goto label_24;
            }
            
            val_25 = 1152921513592650032;
            label_29:
            if(val_27 >= this)
            {
                goto label_24;
            }
            
            if((this._visibleItemList.Contains(item:  val_27)) != true)
            {
                    Row val_22 = this.GetRow(forIndex:  val_27);
                val_26 = this._visibleRows;
                val_26.Add(item:  396246512);
                this._visibleItemList.Add(item:  val_27);
                val_28 = 1;
            }
            
            val_27 = val_27 + 1;
            if(val_27 < val_17)
            {
                goto label_29;
            }
            
            label_24:
            if(val_28 == 1)
            {
                    if(this._visibleItemCount == this._visibleItemList)
            {
                goto label_32;
            }
            
            }
            
            UnityEngine.RectTransform val_23 = this.rectTransform;
            UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(rect:  396246512);
            label_32:
            this._visibleItemCount = this;
        }
        public override void CalculateLayoutInputVertical()
        {
            this.SetLayoutInputForAxis(totalMin:  null, totalPreferred:  null, totalFlexible:  null, axis:  396403568);
        }
        public override void SetLayoutHorizontal()
        {
            var val_11;
            var val_12;
            UnityEngine.RectTransform val_1 = this.rectTransform;
            UnityEngine.Rect val_2 = rect;
            float val_3 = width;
            uint val_11 = 396519904;
            val_11 = 0;
            float val_10 = (float)left;
            val_10 = val_11 - val_10;
            val_11 = val_10 - (float)right;
            goto label_4;
            label_9:
            Row val_6 = this._visibleRows.Item[0];
            this.SetChildAlongAxis(rect:  this._visibleRows, axis:  0, pos:  (float)left, size:  val_2.m_YMin);
            val_11 = 1;
            label_4:
            if(val_11 < this)
            {
                goto label_9;
            }
            
            val_12 = 0;
            goto label_10;
            label_15:
            Row val_8 = this._rowCache.Item[0];
            float val_12 = (float)left;
            val_12 = (-val_11) - val_12;
            this.SetChildAlongAxis(rect:  this._rowCache, axis:  0, pos:  val_12, size:  val_2.m_YMin);
            val_12 = 1;
            label_10:
            if(val_12 < this)
            {
                goto label_15;
            }
        
        }
        public override void SetLayoutVertical()
        {
            var val_6;
            var val_7;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_6 = 0;
            goto label_2;
            label_8:
            Row val_2 = this._visibleRows.Item[0];
            if(this._visibleRows != 0)
            {
                
            }
            else
            {
                    val_7 = 2621443;
            }
            
            float val_3 = this.ItemHeight;
            int val_4 = this._visibleRows.top;
            float val_5 = this.ItemHeight;
            this.SetChildAlongAxis(rect:  2621443, axis:  1, pos:  (float)SB, size:  null);
            val_6 = 1;
            label_2:
            if(val_6 < this)
            {
                goto label_8;
            }
        
        }
        private void SetDirty()
        {
            this.SetDirty();
            bool val_1 = this.IsActive();
            if(val_1 == true)
            {
                    val_1 = true;
                this._isDirty = val_1;
            }
        
        }
        public void AddItem(object item)
        {
            SRF.SRList<System.Object> val_7 = this._itemList;
            val_7.Add(item:  item);
            this.SetDirty();
            bool val_1 = this.IsActive();
            if(val_1 == true)
            {
                    val_1 = true;
                this._isDirty = val_1;
            }
            
            if(this.StickToBottom == false)
            {
                    return;
            }
            
            UnityEngine.UI.ScrollRect val_2 = this.ScrollRect;
            float val_3 = this.verticalNormalizedPosition;
            val_7 = 0;
            if((UnityEngine.Mathf.Approximately(a:  val_3, b:  null)) == false)
            {
                    return;
            }
            
            UnityEngine.UI.ScrollRect val_5 = this.ScrollRect;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_3, y:  null);
            this.normalizedPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        public void RemoveItem(object item)
        {
            if(this._selectedItem == item)
            {
                    this.SelectedItem = 0;
            }
            
            this.InvalidateItem(itemIndex:  this._itemList.IndexOf(item:  item));
            bool val_2 = this._itemList.Remove(item:  item);
            this.RefreshIndexCache();
            this.SetDirty();
            bool val_3 = this.IsActive();
            if(val_3 == true)
            {
                    val_3 = true;
                this._isDirty = val_3;
            }
        
        }
        public void ClearItems()
        {
            int val_1 = true - 1;
            if(val_1 >= 0)
            {
                    do
            {
                Row val_2 = this._visibleRows.Item[val_1];
                this.InvalidateItem(itemIndex:  val_1);
                val_1 = val_1 - 1;
            }
            while(val_1 > 1);
            
            }
            
            this._itemList.Clear();
            this.SetDirty();
            bool val_3 = this.IsActive();
            if(val_3 == true)
            {
                    val_3 = true;
                this._isDirty = val_3;
            }
        
        }
        private UnityEngine.UI.ScrollRect get_ScrollRect()
        {
            if(this._scrollRect != 0)
            {
                    return;
            }
            
            object val_2 = this.GetComponentInParent<System.Object>();
            this._scrollRect = this;
        }
        private bool get_AlignBottom()
        {
            if(this == 8)
            {
                    this = 1;
                return (bool)this;
            }
            
            return false;
        }
        private bool get_AlignTop()
        {
            if(this == 0)
            {
                    this = 1;
                return (bool)this;
            }
            
            if(0 < 2)
            {
                    0 = 1;
            }
            
            return true;
        }
        private float get_ItemHeight()
        {
            var val_8;
            UnityEngine.RectTransform val_9;
            var val_10;
            float val_11;
            float val_13;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(206123008)});
            UnityEngine.Component val_2 = this.ItemPrefab.GetComponent(type:  206123008);
            val_8 = 1152921504812969984;
            if(this.ItemPrefab == 0)
            {
                goto label_5;
            }
            
            val_9 = this.ItemPrefab;
            val_8 = 0;
            val_8 = val_8 + 1;
            val_10 = val_9;
            goto label_9;
            label_5:
            val_9 = this.ItemPrefab;
            UnityEngine.Rect val_3 = rect;
            val_11;
            float val_4 = height;
            goto label_11;
            label_9:
            val_11 = val_9;
            label_11:
            this._itemHeight = val_11;
            if((SRF.SRFFloatExtensions.ApproxZero(f:  this._itemHeight)) != false)
            {
                    UnityEngine.Debug.LogWarning(message:  397651120);
                val_13 = 10f;
                this._itemHeight = 10f;
                return val_13;
            }
            
            val_13 = this._itemHeight;
            return val_13;
        }
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.Row GetRow(int forIndex)
        {
            int val_9;
            var val_10;
            Row val_11;
            int val_12;
            val_9 = forIndex;
            if(true == 0)
            {
                goto label_2;
            }
            
            object val_1 = this._itemList.Item[val_9];
            int val_2 = val_9 + (val_9 >> 31);
            val_2 = val_2 & (~1);
            val_10 = 0;
            val_11 = 0;
            goto label_4;
            label_9:
            SRF.SRList<Row> val_9 = this._rowCache;
            Row val_4 = val_9.Item[0];
            val_9 = val_9;
            if(val_9 == this._itemList)
            {
                goto label_7;
            }
            
            val_10 = 1;
            SRF.SRList<Row> val_5 = val_9 + (val_9 >> 31);
            val_5 = val_5 & (~1);
            val_9 = val_9 - val_5;
            if(val_9 == (val_9 - val_2))
            {
                    val_11 = val_9;
            }
            
            label_4:
            if(val_10 < val_9)
            {
                goto label_9;
            }
            
            val_9 = this._rowCache;
            if(val_11 == 0)
            {
                goto label_10;
            }
            
            bool val_6 = val_9.Remove(item:  val_11);
            goto label_12;
            label_2:
            Row val_7 = this.CreateRow();
            val_11 = this;
            val_12 = val_9;
            goto label_13;
            label_7:
            this._rowCache.RemoveAt(index:  0);
            this.PopulateRow(index:  val_9, row:  val_9);
            val_11 = val_9;
            return;
            label_10:
            object val_8 = SRF.SRFIListExtensions.PopLast<System.Object>(list:  val_9);
            val_11 = val_9;
            label_12:
            val_12 = val_9;
            label_13:
            this.PopulateRow(index:  val_12, row:  val_11);
        }
        private void RecycleRow(SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row)
        {
            this._rowCache.Add(item:  row);
        }
        private void PopulateRow(int index, SRF.UI.Layout.VirtualVerticalLayoutGroup.Row row)
        {
            var val_8;
            SRF.UI.StyleSheet val_9;
            SRF.UI.StyleSheet val_10;
            row.Index = index;
            object val_1 = this._itemList.Item[index];
            row.Data = this._itemList;
            object val_2 = this._itemList.Item[index];
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = row.View;
            val_9 = this;
            if(this.RowStyleSheet == 0)
            {
                    if(this.AltRowStyleSheet == 0)
            {
                    val_10 = this.SelectedRowStyleSheet;
                if(val_10 == 0)
            {
                    return;
            }
            
            }
            
            }
            
            val_10 = this.SelectedRowStyleSheet;
            if(val_10 != 0)
            {
                    if(this._selectedItem == row.Data)
            {
                goto label_25;
            }
            
            }
            
            if(index != 1)
            {
                    val_9 = this.AltRowStyleSheet;
            }
            
            label_25:
            row.Root.StyleSheet = mem[this.AltRowStyleSheet];
        }
        private SRF.UI.Layout.VirtualVerticalLayoutGroup.Row CreateRow()
        {
            SRF.UI.StyleSheet val_11;
            object val_1 = new System.Object();
            UnityEngine.RectTransform val_2 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  this.ItemPrefab);
            typeof(VirtualVerticalLayoutGroup.Row).__il2cppRuntimeField_10 = this.ItemPrefab;
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(413364224)});
            UnityEngine.Component val_4 = this.ItemPrefab.GetComponent(type:  413364224);
            typeof(VirtualVerticalLayoutGroup.Row).__il2cppRuntimeField_18 = this.ItemPrefab;
            if((this.RowStyleSheet != 0) || (this.AltRowStyleSheet != 0))
            {
                goto label_10;
            }
            
            val_11 = this.SelectedRowStyleSheet;
            if(val_11 == 0)
            {
                goto label_13;
            }
            
            label_10:
            UnityEngine.GameObject val_8 = this.ItemPrefab.gameObject;
            UnityEngine.RectTransform val_9 = SRF.SRFGameObjectExtensions.GetComponentOrAdd<UnityEngine.RectTransform>(obj:  this.ItemPrefab);
            typeof(VirtualVerticalLayoutGroup.Row).__il2cppRuntimeField_14 = this.ItemPrefab;
            val_11 = this.ItemPrefab;
            mem2[0] = this.RowStyleSheet;
            label_13:
            UnityEngine.RectTransform val_10 = this.rectTransform;
            this.ItemPrefab.SetParent(parent:  398327136, worldPositionStays:  false);
        }
        public VirtualVerticalLayoutGroup()
        {
            SRF.SRList<System.Object> val_1 = new SRF.SRList<System.Object>();
            this._itemList = null;
            SRF.SRList<System.Int32> val_2 = new SRF.SRList<System.Int32>();
            this._visibleItemList = null;
            this._rowCache = new SRF.SRList<System.Object>();
            this.EnableSelection = true;
            this._visibleRows = new SRF.SRList<System.Object>();
            this.RowPadding = 2;
            this.StickToBottom = true;
            this._itemHeight = -1f;
        }
    
    }

}
