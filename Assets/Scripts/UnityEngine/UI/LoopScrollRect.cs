using UnityEngine;

namespace UnityEngine.UI
{
    public abstract class LoopScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
    {
        // Fields
        public UnityEngine.UI.LoopScrollPrefabSource prefabSource;
        public int totalCount;
        public UnityEngine.UI.LoopScrollDataSource dataSource;
        protected float threshold;
        public bool reverseDirection;
        public float rubberScale;
        protected int itemTypeStart;
        protected int itemTypeEnd;
        protected int directionSign;
        private float m_ContentSpacing;
        protected UnityEngine.UI.GridLayoutGroup m_GridLayout;
        private int m_ContentConstraintCount;
        private UnityEngine.RectTransform m_Content;
        private bool m_Horizontal;
        private bool m_Vertical;
        private UnityEngine.UI.LoopScrollRect.MovementType m_MovementType;
        private float m_Elasticity;
        private bool m_Inertia;
        private float m_DecelerationRate;
        private float m_ScrollSensitivity;
        private UnityEngine.RectTransform m_Viewport;
        private UnityEngine.UI.Scrollbar m_HorizontalScrollbar;
        private UnityEngine.UI.Scrollbar m_VerticalScrollbar;
        private UnityEngine.UI.LoopScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;
        private UnityEngine.UI.LoopScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;
        private float m_HorizontalScrollbarSpacing;
        private float m_VerticalScrollbarSpacing;
        private UnityEngine.UI.LoopScrollRect.ScrollRectEvent m_OnValueChanged;
        private UnityEngine.Vector2 m_PointerStartLocalCursor;
        private UnityEngine.Vector2 m_ContentStartPosition;
        private UnityEngine.RectTransform m_ViewRect;
        private UnityEngine.Bounds m_ContentBounds;
        private UnityEngine.Bounds m_ViewBounds;
        private UnityEngine.Vector2 m_Velocity;
        private bool m_Dragging;
        private UnityEngine.Vector2 m_PrevPosition;
        private UnityEngine.Bounds m_PrevContentBounds;
        private UnityEngine.Bounds m_PrevViewBounds;
        private bool m_HasRebuiltLayout;
        private bool m_HSliderExpand;
        private bool m_VSliderExpand;
        private float m_HSliderHeight;
        private float m_VSliderWidth;
        private UnityEngine.RectTransform m_Rect;
        private UnityEngine.RectTransform m_HorizontalScrollbarRect;
        private UnityEngine.RectTransform m_VerticalScrollbarRect;
        private UnityEngine.DrivenRectTransformTracker m_Tracker;
        private float <flexibleWidth>k__BackingField;
        private readonly UnityEngine.Vector3[] m_Corners;
        
        // Properties
        set; }
        protected float contentSpacing { get; }
        protected int contentConstraintCount { get; }
        private int StartLine { get; }
        private int CurrentLines { get; }
        private int TotalLines { get; }
        public UnityEngine.RectTransform content { get; set; }
        public bool horizontal { get; set; }
        public bool vertical { get; set; }
        public UnityEngine.UI.LoopScrollRect.MovementType movementType { get; set; }
        public float elasticity { get; set; }
        public bool inertia { get; set; }
        public float decelerationRate { get; set; }
        public float scrollSensitivity { get; set; }
        public UnityEngine.RectTransform viewport { get; set; }
        public UnityEngine.UI.Scrollbar horizontalScrollbar { get; set; }
        public UnityEngine.UI.Scrollbar verticalScrollbar { get; set; }
        public UnityEngine.UI.LoopScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
        public UnityEngine.UI.LoopScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
        public float horizontalScrollbarSpacing { get; set; }
        public float verticalScrollbarSpacing { get; set; }
        public UnityEngine.UI.LoopScrollRect.ScrollRectEvent onValueChanged { get; set; }
        protected UnityEngine.RectTransform viewRect { get; }
        public UnityEngine.Vector2 velocity { get; set; }
        private UnityEngine.RectTransform rectTransform { get; }
        public UnityEngine.Vector2 normalizedPosition { get; set; }
        public float horizontalNormalizedPosition { get; set; }
        public float verticalNormalizedPosition { get; set; }
        private bool hScrollingNeeded { get; }
        private bool vScrollingNeeded { get; }
        public virtual float minWidth { get; }
        public virtual float preferredWidth { get; }
        public virtual float flexibleWidth { get; set; }
        public virtual float minHeight { get; }
        public virtual float preferredHeight { get; }
        public virtual float flexibleHeight { get; }
        public virtual int layoutPriority { get; }
        
        // Methods
        public void set_objectsToFill(object[] value)
        {
            var val_2;
            if(value != null)
            {
                    UnityEngine.UI.LoopScrollArraySource<System.Object> val_1 = new UnityEngine.UI.LoopScrollArraySource<System.Object>(objectsToFill:  value);
                this.dataSource = null;
                return;
            }
            
            val_2 = null;
            val_2 = null;
            this.dataSource = UnityEngine.UI.LoopScrollSendIndexSource.Instance;
        }
        protected abstract float GetSize(UnityEngine.RectTransform item); // 0
        protected abstract float GetDimension(UnityEngine.Vector2 vector); // 0
        protected abstract UnityEngine.Vector2 GetVector(float value); // 0
        protected float get_contentSpacing()
        {
            float val_6;
            var val_7;
            this.m_ContentSpacing = 0f;
            val_7 = 1152921504765685760;
            if(this.m_Content != 0)
            {
                    object val_2 = this.m_Content.GetComponent<System.Object>();
                bool val_3 = UnityEngine.Object.op_Inequality(x:  this.m_Content, y:  0);
                if(val_3 != false)
            {
                    this.m_ContentSpacing = val_3;
            }
            
                object val_4 = this.m_Content.GetComponent<System.Object>();
                this.m_GridLayout = this.m_Content;
                if(this.m_Content != 0)
            {
                    this.m_ContentSpacing = System.Math.Abs(1167255424);
            }
            
            }
            
            val_6 = this.m_ContentSpacing;
            return val_6;
        }
        protected int get_contentConstraintCount()
        {
            if(this.m_ContentConstraintCount > 0)
            {
                    return (int)this.m_ContentConstraintCount;
            }
            
            this.m_ContentConstraintCount = 1;
            if(this.m_Content == 0)
            {
                    return (int)this.m_ContentConstraintCount;
            }
            
            object val_2 = this.m_Content.GetComponent<System.Object>();
            bool val_3 = UnityEngine.Object.op_Inequality(x:  this.m_Content, y:  0);
            if(val_3 == false)
            {
                    return (int)this.m_ContentConstraintCount;
            }
            
            if(val_3 != true)
            {
                    UnityEngine.Debug.LogWarning(message:  1167368000);
            }
            
            this.m_ContentConstraintCount = "[LoopScrollRect] Flexible not supported yet";
            return (int)this.m_ContentConstraintCount;
        }
        private int get_StartLine()
        {
            float val_2 = (float)this.contentConstraintCount;
            val_2 = (float)this.itemTypeStart / val_2;
            return UnityEngine.Mathf.CeilToInt(f:  val_2);
        }
        private int get_CurrentLines()
        {
            float val_3 = (float)this.contentConstraintCount;
            val_3 = ((float)this.itemTypeEnd - this.itemTypeStart) / val_3;
            return UnityEngine.Mathf.CeilToInt(f:  val_3);
        }
        private int get_TotalLines()
        {
            float val_2 = (float)this.contentConstraintCount;
            val_2 = (float)this.totalCount / val_2;
            return UnityEngine.Mathf.CeilToInt(f:  val_2);
        }
        protected virtual bool UpdateItems(UnityEngine.Bounds viewBounds, UnityEngine.Bounds contentBounds)
        {
            return false;
        }
        public UnityEngine.RectTransform get_content()
        {
        
        }
        public void set_content(UnityEngine.RectTransform value)
        {
            this.m_Content = value;
        }
        public bool get_horizontal()
        {
            return (bool)this.m_Horizontal;
        }
        public void set_horizontal(bool value)
        {
            this.m_Horizontal = value;
        }
        public bool get_vertical()
        {
            return (bool)this.m_Vertical;
        }
        public void set_vertical(bool value)
        {
            this.m_Vertical = value;
        }
        public UnityEngine.UI.LoopScrollRect.MovementType get_movementType()
        {
        
        }
        public void set_movementType(UnityEngine.UI.LoopScrollRect.MovementType value)
        {
            this.m_MovementType = value;
        }
        public float get_elasticity()
        {
            return (float)S0;
        }
        public void set_elasticity(float value)
        {
            this.m_Elasticity = ;
        }
        public bool get_inertia()
        {
            return (bool)this.m_Inertia;
        }
        public void set_inertia(bool value)
        {
            this.m_Inertia = value;
        }
        public float get_decelerationRate()
        {
            return (float)S0;
        }
        public void set_decelerationRate(float value)
        {
            this.m_DecelerationRate = ;
        }
        public float get_scrollSensitivity()
        {
            return (float)S0;
        }
        public void set_scrollSensitivity(float value)
        {
            this.m_ScrollSensitivity = ;
        }
        public UnityEngine.RectTransform get_viewport()
        {
        
        }
        public void set_viewport(UnityEngine.RectTransform value)
        {
            this.m_Viewport = value;
            this.SetDirtyCaching();
        }
        public UnityEngine.UI.Scrollbar get_horizontalScrollbar()
        {
        
        }
        public void set_horizontalScrollbar(UnityEngine.UI.Scrollbar value)
        {
            UnityEngine.UI.Scrollbar val_5 = this.m_HorizontalScrollbar;
            if((UnityEngine.Object.op_Implicit(exists:  val_5 = this.m_HorizontalScrollbar)) != false)
            {
                    val_5 = this.m_HorizontalScrollbar.m_OnValueChanged;
                UnityEngine.Events.UnityAction<System.Single> val_2 = new UnityEngine.Events.UnityAction<System.Single>(object:  1170174368, method:  new IntPtr(1170138080));
                val_5.RemoveListener(call:  162353152);
            }
            
            this.m_HorizontalScrollbar = value;
            if((UnityEngine.Object.op_Implicit(exists:  value)) != false)
            {
                    val_5 = null;
                val_5 = new UnityEngine.Events.UnityAction<System.Single>(object:  1170174368, method:  new IntPtr(1170138080));
                this.m_HorizontalScrollbar.m_OnValueChanged.AddListener(call:  162353152);
            }
            
            this.SetDirtyCaching();
        }
        public UnityEngine.UI.Scrollbar get_verticalScrollbar()
        {
        
        }
        public void set_verticalScrollbar(UnityEngine.UI.Scrollbar value)
        {
            UnityEngine.UI.Scrollbar val_5 = this.m_VerticalScrollbar;
            if((UnityEngine.Object.op_Implicit(exists:  val_5 = this.m_VerticalScrollbar)) != false)
            {
                    val_5 = this.m_VerticalScrollbar.m_OnValueChanged;
                UnityEngine.Events.UnityAction<System.Single> val_2 = new UnityEngine.Events.UnityAction<System.Single>(object:  1170456736, method:  new IntPtr(1170423520));
                val_5.RemoveListener(call:  162353152);
            }
            
            this.m_VerticalScrollbar = value;
            if((UnityEngine.Object.op_Implicit(exists:  value)) != false)
            {
                    val_5 = null;
                val_5 = new UnityEngine.Events.UnityAction<System.Single>(object:  1170456736, method:  new IntPtr(1170423520));
                this.m_VerticalScrollbar.m_OnValueChanged.AddListener(call:  162353152);
            }
            
            this.SetDirtyCaching();
        }
        public UnityEngine.UI.LoopScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility()
        {
        
        }
        public void set_horizontalScrollbarVisibility(UnityEngine.UI.LoopScrollRect.ScrollbarVisibility value)
        {
            this.m_HorizontalScrollbarVisibility = value;
            this.SetDirtyCaching();
        }
        public UnityEngine.UI.LoopScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility()
        {
        
        }
        public void set_verticalScrollbarVisibility(UnityEngine.UI.LoopScrollRect.ScrollbarVisibility value)
        {
            this.m_VerticalScrollbarVisibility = value;
            this.SetDirtyCaching();
        }
        public float get_horizontalScrollbarSpacing()
        {
            return (float)S0;
        }
        public void set_horizontalScrollbarSpacing(float value)
        {
            this.m_HorizontalScrollbarSpacing = ;
            this.SetDirty();
        }
        public float get_verticalScrollbarSpacing()
        {
            return (float)S0;
        }
        public void set_verticalScrollbarSpacing(float value)
        {
            this.m_VerticalScrollbarSpacing = ;
            this.SetDirty();
        }
        public UnityEngine.UI.LoopScrollRect.ScrollRectEvent get_onValueChanged()
        {
        
        }
        public void set_onValueChanged(UnityEngine.UI.LoopScrollRect.ScrollRectEvent value)
        {
            this.m_OnValueChanged = value;
        }
        protected UnityEngine.RectTransform get_viewRect()
        {
            UnityEngine.RectTransform val_4;
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.m_ViewRect, y:  0);
            if(val_1 == true)
            {
                    this.m_ViewRect = this.m_Viewport;
                this.m_ViewRect = this.m_ViewRect;
            }
            
            if(val_1 == false)
            {
                    this.m_ViewRect = this.m_ViewRect;
            }
            
            if(this.m_ViewRect != 0)
            {
                    return;
            }
            
            val_4 = this;
            UnityEngine.Transform val_3 = this.m_ViewRect.transform;
            if(val_4 != 0)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
            val_4 = 0;
            label_7:
            this.m_ViewRect = val_4;
        }
        public UnityEngine.Vector2 get_velocity()
        {
            this = R1 + 188;
            mem[1152921514368688804] = R1 + 192;
            return new UnityEngine.Vector2();
        }
        public void set_velocity(UnityEngine.Vector2 value)
        {
            this.m_Velocity = value;
            mem[1152921514368800992] = value.y;
        }
        private UnityEngine.RectTransform get_rectTransform()
        {
            if(this.m_Rect != 0)
            {
                    return;
            }
            
            object val_2 = this.m_Rect.GetComponent<System.Object>();
            this.m_Rect = this;
        }
        protected LoopScrollRect()
        {
            UnityEngine.Vector2 val_3;
            var val_4;
            UnityEngine.Vector2 val_6;
            var val_7;
            null = null;
            this.rubberScale = 1f;
            this.dataSource = UnityEngine.UI.LoopScrollSendIndexSource.Instance;
            this.m_ContentSpacing = -1f;
            this.m_Horizontal = true;
            this.m_Vertical = true;
            this.m_MovementType = 1;
            this.m_Elasticity = 0.1f;
            this.m_Inertia = 1;
            this.m_DecelerationRate = 0.135f;
            this.m_ScrollSensitivity = 1f;
            this.m_OnValueChanged = new LoopScrollRect.ScrollRectEvent();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.m_PointerStartLocalCursor = val_3;
            mem[1152921514369041308] = val_4;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            this.m_ContentStartPosition = val_6;
            mem[1152921514369041316] = val_7;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
            this.m_PrevPosition = new UnityEngine.Vector2();
            mem[1152921514369041388] = ???;
            this.m_Corners = null;
            this.<flexibleWidth>k__BackingField = -1f;
        }
        public void ClearCells()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.itemTypeStart = 0;
            this.itemTypeEnd = 0;
            this.totalCount = 0;
            this.objectsToFill = null;
            UnityEngine.RectTransform val_4 = this.m_Content;
            val_4 = val_4.childCount - 1;
            if(val_4 < 0)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Transform val_3 = this.m_Content.GetChild(index:  val_4);
                val_4 = val_4 - 1;
            }
            while(val_4 > 1);
        
        }
        public void ScrollToCell(int index, float speed)
        {
            var val_3;
            var val_4;
            if((this.totalCount >= 0) && (this.totalCount <= index))
            {
                    val_3 = null;
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                val_4 = "invalid index {0}";
            }
            else
            {
                    if(this.totalCount > 0)
            {
                    this.StopAllCoroutines();
                System.Collections.IEnumerator val_1 = this.ScrollToCellCoroutine(index:  index, speed:  speed);
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1172508416);
                return;
            }
            
                val_3 = null;
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                val_4 = "invalid speed {0}";
            }
            
            UnityEngine.Debug.LogWarningFormat(format:  1172484304, args:  472754880);
        }
        private System.Collections.IEnumerator ScrollToCellCoroutine(int index, float speed)
        {
            if((new LoopScrollRect.<ScrollToCellCoroutine>d__124(<>1__state:  0)) != 0)
            {
                    typeof(LoopScrollRect.<ScrollToCellCoroutine>d__124).__il2cppRuntimeField_10 = this;
                typeof(LoopScrollRect.<ScrollToCellCoroutine>d__124).__il2cppRuntimeField_14 = index;
            }
            else
            {
                    mem[16] = this;
                mem[20] = index;
            }
            
            typeof(LoopScrollRect.<ScrollToCellCoroutine>d__124).__il2cppRuntimeField_18 = R2;
        }
        public void RefreshCells()
        {
            var val_6;
            var val_7;
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_6 = 0;
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            this.itemTypeEnd = this.itemTypeStart;
            goto label_2;
            label_10:
            if(this.itemTypeEnd < this.totalCount)
            {
                    UnityEngine.Transform val_3 = this.m_Content.GetChild(index:  0);
                int val_6 = this.itemTypeEnd;
                val_6 = val_6 + 1;
                this.itemTypeEnd = val_6;
            }
            else
            {
                    UnityEngine.Transform val_4 = this.m_Content.GetChild(index:  0);
                val_7 = this.m_Content;
            }
            
            val_6 = 0;
            label_2:
            if(val_6 < this.m_Content.childCount)
            {
                goto label_10;
            }
        
        }
        public void RefillCellsFromEnd(int offset = 0)
        {
            var val_12;
            var val_16;
            float val_17;
            float val_20;
            var val_22;
            float val_23;
            float val_24;
            bool val_1 = UnityEngine.Application.isPlaying;
            if(val_1 == true)
            {
                    val_1 = this.prefabSource;
            }
            
            if(val_1 == 0)
            {
                    return;
            }
            
            if(this.reverseDirection == false)
            {
                    this.reverseDirection = this.totalCount;
                offset = this.reverseDirection - offset;
            }
            
            this.itemTypeStart = offset;
            this.itemTypeEnd = offset;
            if(this.totalCount >= 0)
            {
                    if(this.contentConstraintCount != 0)
            {
                    UnityEngine.Debug.LogWarning(message:  1172865472);
            }
            
            }
            
            int val_4 = this.m_Content.childCount - 1;
            if(val_4 >= 0)
            {
                    do
            {
                UnityEngine.Transform val_5 = this.m_Content.GetChild(index:  val_4);
                val_4 = val_4 - 1;
            }
            while(val_4 > 1);
            
            }
            
            UnityEngine.RectTransform val_6 = this.viewRect;
            if(this.directionSign != 1)
            {
                    UnityEngine.Rect val_7 = rect;
                UnityEngine.Vector2 val_8 = size;
            }
            else
            {
                    UnityEngine.Rect val_10 = rect;
                UnityEngine.Vector2 val_11 = size;
            }
            
            val_20 = 0f;
            goto label_14;
            label_18:
            if(this.reverseDirection != false)
            {
                    val_22 = this;
                float val_13 = this.NewItemAtEnd();
            }
            else
            {
                    val_22 = this;
                float val_14 = this.NewItemAtStart();
            }
            
            if(this.reverseDirection <= false)
            {
                goto label_17;
            }
            
            val_20 = val_20 + 1172910160;
            label_14:
            if(this.reverseDirection > false)
            {
                goto label_18;
            }
            
            label_17:
            UnityEngine.Vector2 val_15 = anchoredPosition;
            val_23 = val_16;
            val_24 = val_17;
            float val_19 = UnityEngine.Mathf.Max(a:  val_20 - val_12, b:  val_15.y);
            if(this.reverseDirection == false)
            {
                    -0 = 0;
            }
            
            if(this.directionSign != 1)
            {
                    if(this.directionSign == 1)
            {
                    val_24 = 0;
            }
            
            }
            else
            {
                    val_23 = 0 ^ 2147483648;
            }
            
            this.m_Content.anchoredPosition = new UnityEngine.Vector2() {x = val_23, y = val_24};
        }
        public void RefillCells(int offset = 0)
        {
            var val_16;
            float val_17;
            var val_18;
            float val_19;
            var val_20;
            bool val_1 = UnityEngine.Application.isPlaying;
            if(val_1 == true)
            {
                    val_1 = this.prefabSource;
            }
            
            if(val_1 == 0)
            {
                    return;
            }
            
            if(this.reverseDirection == true)
            {
                    this.reverseDirection = this.totalCount;
                offset = this.reverseDirection - offset;
            }
            
            this.itemTypeStart = offset;
            this.itemTypeEnd = offset;
            if(this.totalCount >= 0)
            {
                    if(this.contentConstraintCount != 0)
            {
                    UnityEngine.Debug.LogWarning(message:  1173026832);
            }
            
            }
            
            int val_4 = this.m_Content.childCount - 1;
            if(val_4 >= 0)
            {
                    do
            {
                UnityEngine.Transform val_5 = this.m_Content.GetChild(index:  val_4);
                val_4 = val_4 - 1;
            }
            while(val_4 > 1);
            
            }
            
            UnityEngine.RectTransform val_6 = this.viewRect;
            if(this.directionSign != 1)
            {
                    UnityEngine.Rect val_7 = rect;
                UnityEngine.Vector2 val_8 = size;
            }
            else
            {
                    UnityEngine.Rect val_10 = rect;
                UnityEngine.Vector2 val_11 = size;
            }
            
            if(this.directionSign <= 1)
            {
                goto label_17;
            }
            
            float val_18 = 0f;
            label_18:
            if(this.reverseDirection != false)
            {
                    val_18 = this;
                float val_13 = this.NewItemAtStart();
            }
            else
            {
                    val_18 = this;
                float val_14 = this.NewItemAtEnd();
            }
            
            if(this.reverseDirection <= false)
            {
                goto label_17;
            }
            
            val_18 = val_18 + 1173071520;
            if(this.reverseDirection > false)
            {
                goto label_18;
            }
            
            label_17:
            val_19 = 0;
            UnityEngine.Vector2 val_15 = anchoredPosition;
            val_20 = val_16;
            if(this.directionSign != 1)
            {
                    val_19 = val_17;
                if(this.directionSign == 1)
            {
                    val_20 = 0;
            }
            
            }
            
            this.m_Content.anchoredPosition = new UnityEngine.Vector2() {x = 0f, y = val_19};
        }
        protected float NewItemAtStart()
        {
            float val_8;
            var val_9;
            float val_11;
            float val_12;
            float val_14;
            float val_15;
            UnityEngine.Vector2 val_17;
            var val_18;
            UnityEngine.Vector2 val_20;
            var val_21;
            float val_22;
            var val_23;
            UnityEngine.RectTransform val_24;
            if(this.totalCount < 0)
            {
                goto label_1;
            }
            
            int val_1 = this.contentConstraintCount;
            val_1 = this.itemTypeStart - val_1;
            if(val_1 < 0)
            {
                goto label_2;
            }
            
            label_1:
            val_22 = 0f;
            if(this.contentConstraintCount >= 1)
            {
                    val_23 = 1152921504762277888;
                do
            {
                int val_3 = this.itemTypeStart - 1;
                this.itemTypeStart = val_3;
                UnityEngine.RectTransform val_4 = this.InstantiateNextItem(itemIdx:  val_3);
                this.SetAsFirstSibling();
                float val_5 = UnityEngine.Mathf.Max(a:  null, b:  null);
                val_22 = 1173212192;
                val_24 = 0 + 1;
            }
            while(val_24 < this.contentConstraintCount);
            
            }
            
            float val_22 = 1.5f;
            val_22 = val_22 * val_22;
            float val_7 = UnityEngine.Mathf.Max(a:  val_22, b:  null);
            this.threshold = this.threshold;
            if(this.reverseDirection == true)
            {
                    return (float)S0;
            }
            
            val_24 = this.m_Content;
            val_23 = val_9;
            UnityEngine.Vector2 val_10 = anchoredPosition;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 7603.629f, y = val_11}, b:  new UnityEngine.Vector2() {x = val_12, y = val_8});
            val_24.anchoredPosition = new UnityEngine.Vector2() {x = val_14, y = val_15};
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 7603.625f, y = this.m_PrevPosition}, b:  new UnityEngine.Vector2() {x = val_15, y = val_8});
            this.m_PrevPosition = val_17;
            mem[1152921514369993964] = val_18;
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 7603.621f, y = this.m_ContentStartPosition}, b:  new UnityEngine.Vector2() {x = val_15, y = val_8});
            this.m_ContentStartPosition = val_20;
            mem[1152921514369993892] = val_21;
            return (float)S0;
            label_2:
            val_22 = 0f;
            return (float)S0;
        }
        protected float DeleteItemAtStart()
        {
            float val_2;
            float val_3;
            float val_12;
            float val_13;
            float val_15;
            float val_16;
            UnityEngine.Vector2 val_18;
            var val_19;
            UnityEngine.Vector2 val_21;
            var val_22;
            UnityEngine.RectTransform val_23;
            UnityEngine.UI.LoopScrollPrefabSource val_24;
            float val_26;
            var val_27;
            var val_28;
            if(this.m_Dragging == true)
            {
                goto label_1;
            }
            
            val_24 = 0;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.m_Velocity, y = R6}, rhs:  new UnityEngine.Vector2() {x = val_2, y = val_3})) == false)
            {
                goto label_4;
            }
            
            label_1:
            if(this.totalCount >= 0)
            {
                    R6 = this.itemTypeEnd;
                this.totalCount = this.totalCount - 1;
            }
            
            if(R6 >= this.totalCount)
            {
                goto label_7;
            }
            
            label_4:
            if(this.m_Content.childCount == 0)
            {
                goto label_7;
            }
            
            val_26 = 0f;
            if(this.contentConstraintCount < 1)
            {
                goto label_15;
            }
            
            val_27 = 0;
            label_16:
            val_28 = 0;
            UnityEngine.Transform val_7 = this.m_Content.GetChild(index:  0);
            if(this.m_Content != 0)
            {
                    if(null != null)
            {
                    this.m_Content = 0;
            }
            
                val_28 = this.m_Content;
            }
            
            float val_8 = UnityEngine.Mathf.Max(a:  val_1.x, b:  val_1.y);
            val_24 = this.prefabSource;
            val_23 = this;
            int val_23 = this.itemTypeStart;
            val_23 = val_23 + 1;
            this.itemTypeStart = val_23;
            val_26 = 1173348768;
            if(this.m_Content.childCount == 0)
            {
                goto label_15;
            }
            
            val_27 = val_27 + 1;
            if(val_27 < this.contentConstraintCount)
            {
                goto label_16;
            }
            
            label_15:
            if(this.reverseDirection == true)
            {
                    return (float)val_1.x;
            }
            
            val_23 = this.m_Content;
            val_24 = val_3;
            UnityEngine.Vector2 val_11 = anchoredPosition;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 7670.313f, y = val_12}, b:  new UnityEngine.Vector2() {x = val_13, y = val_2});
            val_27 = 0;
            val_23.anchoredPosition = new UnityEngine.Vector2() {x = val_15, y = val_16};
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 7670.309f, y = this.m_PrevPosition}, b:  new UnityEngine.Vector2() {x = val_16, y = val_2});
            this.m_PrevPosition = val_18;
            mem[1152921514370130540] = val_19;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 7670.305f, y = this.m_ContentStartPosition}, b:  new UnityEngine.Vector2() {x = val_16, y = val_2});
            this.m_ContentStartPosition = val_21;
            mem[1152921514370130468] = val_22;
            return (float)val_1.x;
            label_7:
            val_26 = 0f;
            return (float)val_1.x;
        }
        protected float NewItemAtEnd()
        {
            float val_8;
            var val_9;
            float val_11;
            float val_12;
            float val_14;
            float val_15;
            UnityEngine.Vector2 val_17;
            var val_18;
            UnityEngine.Vector2 val_20;
            var val_21;
            UnityEngine.RectTransform val_22;
            float val_23;
            var val_24;
            var val_25;
            if(this.itemTypeEnd >= this.totalCount)
            {
                goto label_1;
            }
            
            int val_2 = this.m_Content.childCount;
            val_22 = this.contentConstraintCount - this.contentConstraintCount;
            val_23 = 0f;
            if(val_22 < 1)
            {
                goto label_6;
            }
            
            val_24 = 1;
            val_25 = 1152921504762277888;
            label_7:
            UnityEngine.RectTransform val_4 = this.InstantiateNextItem(itemIdx:  this.itemTypeEnd);
            float val_5 = UnityEngine.Mathf.Max(a:  null, b:  null);
            int val_22 = this.itemTypeEnd;
            val_23 = 1173489440;
            val_22 = val_22 + 1;
            this.itemTypeEnd = val_22;
            if(val_22 < this.totalCount)
            {
                    0 = 1;
            }
            
            if(this.totalCount < 0)
            {
                    0 = 1;
            }
            
            if(1 != 1)
            {
                goto label_6;
            }
            
            val_24 = val_24 + 1;
            if(val_24 < val_22)
            {
                goto label_7;
            }
            
            label_6:
            float val_23 = 1.5f;
            val_23 = val_23 * val_23;
            float val_7 = UnityEngine.Mathf.Max(a:  val_23, b:  null);
            this.threshold = this.threshold;
            if(this.reverseDirection == false)
            {
                    return (float)S0;
            }
            
            val_22 = this.m_Content;
            val_24 = val_9;
            UnityEngine.Vector2 val_10 = anchoredPosition;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 7739.004f, y = val_11}, b:  new UnityEngine.Vector2() {x = val_12, y = val_8});
            val_25 = 0;
            val_22.anchoredPosition = new UnityEngine.Vector2() {x = val_14, y = val_15};
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 7739f, y = this.m_PrevPosition}, b:  new UnityEngine.Vector2() {x = val_15, y = val_8});
            this.m_PrevPosition = val_17;
            mem[1152921514370271212] = val_18;
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 7738.996f, y = this.m_ContentStartPosition}, b:  new UnityEngine.Vector2() {x = val_15, y = val_8});
            this.m_ContentStartPosition = val_20;
            mem[1152921514370271140] = val_21;
            return (float)S0;
            label_1:
            val_23 = 0f;
            return (float)S0;
        }
        protected float DeleteItemAtEnd()
        {
            float val_2;
            float val_3;
            float val_18;
            float val_19;
            float val_21;
            float val_22;
            UnityEngine.Vector2 val_24;
            var val_25;
            UnityEngine.Vector2 val_27;
            var val_28;
            UnityEngine.UI.LoopScrollPrefabSource val_29;
            var val_30;
            float val_32;
            var val_33;
            UnityEngine.RectTransform val_34;
            var val_35;
            var val_36;
            if(this.m_Dragging == true)
            {
                goto label_1;
            }
            
            val_30 = 0;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.m_Velocity, y = R6}, rhs:  new UnityEngine.Vector2() {x = val_2, y = val_3})) == false)
            {
                goto label_5;
            }
            
            label_1:
            if(this.totalCount >= 0)
            {
                    if(this.itemTypeStart < this.contentConstraintCount)
            {
                goto label_8;
            }
            
            }
            
            label_5:
            if(this.m_Content.childCount == 0)
            {
                goto label_8;
            }
            
            val_32 = 0f;
            if(this.contentConstraintCount < 1)
            {
                goto label_18;
            }
            
            val_33 = 0;
            label_19:
            val_34 = this.m_Content;
            if(val_34 != 0)
            {
                    val_35 = val_34.childCount;
            }
            else
            {
                    val_34 = 0;
                val_35 = 0.childCount;
            }
            
            val_36 = 0;
            UnityEngine.Transform val_11 = val_34.GetChild(index:  val_35 - 1);
            if(val_34 != 0)
            {
                    if(1179403647 != null)
            {
                    val_34 = 0;
            }
            
                val_36 = val_34;
            }
            
            float val_12 = UnityEngine.Mathf.Max(a:  val_1.x, b:  val_1.y);
            val_29 = this.prefabSource;
            val_30 = this;
            val_32 = 1173630112;
            this.itemTypeEnd = this.itemTypeEnd - 1;
            if((this.contentConstraintCount == 0) || (this.m_Content.childCount == 0))
            {
                goto label_18;
            }
            
            val_33 = val_33 + 1;
            if(val_33 < this.contentConstraintCount)
            {
                goto label_19;
            }
            
            label_18:
            if(this.reverseDirection == false)
            {
                    return (float)val_1.x;
            }
            
            val_29 = this.m_Content;
            val_30 = val_3;
            UnityEngine.Vector2 val_17 = anchoredPosition;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 7807.688f, y = val_18}, b:  new UnityEngine.Vector2() {x = val_19, y = val_2});
            val_33 = 0;
            val_29.anchoredPosition = new UnityEngine.Vector2() {x = val_21, y = val_22};
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 7807.684f, y = this.m_PrevPosition}, b:  new UnityEngine.Vector2() {x = val_22, y = val_2});
            this.m_PrevPosition = val_24;
            mem[1152921514370411884] = val_25;
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 7807.68f, y = this.m_ContentStartPosition}, b:  new UnityEngine.Vector2() {x = val_22, y = val_2});
            this.m_ContentStartPosition = val_27;
            mem[1152921514370411812] = val_28;
            return (float)val_1.x;
            label_8:
            val_32 = 0f;
            return (float)val_1.x;
        }
        private UnityEngine.RectTransform InstantiateNextItem(int itemIdx)
        {
            var val_4;
            var val_5;
            val_4 = 0;
            UnityEngine.Transform val_1 = this.prefabSource.transform;
            if(this.prefabSource != 0)
            {
                    if(null == null)
            {
                goto label_4;
            }
            
            }
            
            val_5 = 1;
            goto label_5;
            label_4:
            val_5 = 0;
            val_4 = this.prefabSource;
            label_5:
            UnityEngine.Transform val_2 = val_4.transform;
            val_4.SetParent(parent:  this.m_Content, worldPositionStays:  false);
            UnityEngine.GameObject val_3 = val_4.gameObject;
            val_4.SetActive(value:  true);
            if(this.dataSource != 0)
            {
                    return;
            }
        
        }
        public virtual void Rebuild(UnityEngine.UI.CanvasUpdate executing)
        {
            if(executing != 2)
            {
                    if(executing != 0)
            {
                    return;
            }
            
                this.UpdateCachedData();
                return;
            }
            
            this.UpdateBounds(updateItems:  false);
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.UpdateScrollbars(offset:  new UnityEngine.Vector2());
            this.UpdatePrevData();
            this.m_HasRebuiltLayout = true;
        }
        public virtual void LayoutComplete()
        {
        
        }
        public virtual void GraphicUpdateComplete()
        {
        
        }
        private void UpdateCachedData()
        {
            UnityEngine.RectTransform val_24;
            UnityEngine.RectTransform val_26;
            var val_27;
            var val_28;
            bool val_29;
            float val_30;
            float val_31;
            val_24 = 0;
            UnityEngine.Transform val_1 = this.transform;
            if(this.m_HorizontalScrollbar != 0)
            {
                    val_24 = 0;
                UnityEngine.Transform val_3 = this.m_HorizontalScrollbar.transform;
                if(this.m_HorizontalScrollbar != 0)
            {
                    if(null != null)
            {
                    this.m_HorizontalScrollbar = 0;
            }
            
                val_24 = this.m_HorizontalScrollbar;
            }
            
            }
            
            this.m_HorizontalScrollbarRect = val_24;
            val_26 = 0;
            if(this.m_VerticalScrollbar != 0)
            {
                    val_26 = 0;
                UnityEngine.Transform val_5 = this.m_VerticalScrollbar.transform;
                if(this.m_VerticalScrollbar != 0)
            {
                    if(null != null)
            {
                    this.m_VerticalScrollbar = 0;
            }
            
                val_26 = this.m_VerticalScrollbar;
            }
            
            }
            
            this.m_VerticalScrollbarRect = val_26;
            UnityEngine.RectTransform val_6 = this.viewRect;
            UnityEngine.Transform val_7 = this.parent;
            val_27 = 1;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_HorizontalScrollbarRect)) != false)
            {
                    UnityEngine.Transform val_10 = this.m_HorizontalScrollbarRect.parent;
                val_27 = UnityEngine.Object.op_Equality(x:  this.m_HorizontalScrollbarRect, y:  1174308896);
            }
            
            val_28 = 1;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_VerticalScrollbarRect)) != false)
            {
                    UnityEngine.Transform val_13 = this.m_VerticalScrollbarRect.parent;
            }
            
            if(((val_27 & (UnityEngine.Object.op_Equality(x:  1174308896, y:  1174308896))) & (UnityEngine.Object.op_Equality(x:  this.m_VerticalScrollbarRect, y:  1174308896))) == 0)
            {
                    bool val_16 = UnityEngine.Object.op_Implicit(exists:  this.m_HorizontalScrollbarRect);
                if(val_16 == true)
            {
                    val_16 = this.m_HorizontalScrollbarVisibility;
                val_16 = val_16 - 2;
            }
            
                if(val_16 == true)
            {
                    0 = val_16 >> 5;
            }
            
                this.m_HSliderExpand = 0;
                bool val_17 = UnityEngine.Object.op_Implicit(exists:  this.m_VerticalScrollbarRect);
                if(val_17 == true)
            {
                    val_17 = this.m_VerticalScrollbarVisibility;
                val_17 = val_17 - 2;
            }
            
                if(val_17 == true)
            {
                    val_29 = val_17 >> 5;
            }
            
            }
            else
            {
                    val_29 = false;
                this.m_HSliderExpand = val_29;
            }
            
            this.m_VSliderExpand = val_29;
            if(this.m_HorizontalScrollbarRect == 0)
            {
                    val_30 = 0f;
            }
            else
            {
                    UnityEngine.Rect val_19 = rect;
                float val_20 = height;
                val_30 = 1174296840;
            }
            
            this.m_HSliderHeight = val_30;
            if(this.m_VerticalScrollbarRect == 0)
            {
                    val_31 = 0f;
            }
            else
            {
                    UnityEngine.Rect val_22 = rect;
                float val_23 = width;
                val_31 = 1174296840;
            }
            
            this.m_VSliderWidth = val_31;
        }
        protected override void OnEnable()
        {
            UnityEngine.Events.UnityAction<System.Single> val_5;
            this.OnEnable();
            if((UnityEngine.Object.op_Implicit(exists:  this.m_HorizontalScrollbar)) != false)
            {
                    val_5 = null;
                val_5 = new UnityEngine.Events.UnityAction<System.Single>(object:  1174511008, method:  new IntPtr(1170138080));
                this.m_HorizontalScrollbar.m_OnValueChanged.AddListener(call:  162353152);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_VerticalScrollbar)) != false)
            {
                    val_5 = null;
                val_5 = new UnityEngine.Events.UnityAction<System.Single>(object:  1174511008, method:  new IntPtr(1170423520));
                this.m_VerticalScrollbar.m_OnValueChanged.AddListener(call:  162353152);
            }
            
            UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(element:  1174511008);
        }
        protected override void OnDisable()
        {
            UnityEngine.Events.UnityAction<System.Single> val_7;
            UnityEngine.UI.CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(element:  1174672160);
            if((UnityEngine.Object.op_Implicit(exists:  this.m_HorizontalScrollbar)) != false)
            {
                    val_7 = null;
                val_7 = new UnityEngine.Events.UnityAction<System.Single>(object:  1174672160, method:  new IntPtr(1170138080));
                this.m_HorizontalScrollbar.m_OnValueChanged.RemoveListener(call:  162353152);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.m_VerticalScrollbar)) != false)
            {
                    val_7 = null;
                val_7 = new UnityEngine.Events.UnityAction<System.Single>(object:  1174672160, method:  new IntPtr(1170423520));
                this.m_VerticalScrollbar.m_OnValueChanged.RemoveListener(call:  162353152);
            }
            
            this.m_HasRebuiltLayout = false;
            this.m_Tracker.Clear();
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            this.m_Velocity = new UnityEngine.Vector2();
            mem[1152921514371453920] = ???;
            UnityEngine.RectTransform val_6 = this.rectTransform;
            UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(rect:  1174672160);
            this.OnDisable();
        }
        public override bool IsActive()
        {
            if(this.IsActive() == false)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  this.m_Content, y:  0);
        }
        private void EnsureLayoutHasRebuilt()
        {
            if(this.m_HasRebuiltLayout == true)
            {
                    return;
            }
            
            if(UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingLayout() != false)
            {
                    return;
            }
            
            UnityEngine.Canvas.ForceUpdateCanvases();
        }
        public virtual void StopMovement()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.m_Velocity = new UnityEngine.Vector2();
            mem[1152921514371822688] = ???;
        }
        public virtual void OnScroll(UnityEngine.EventSystems.PointerEventData data)
        {
            float val_3;
            float val_4;
            float val_7;
            float val_9;
            float val_10;
            var val_15;
            var val_16;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            val_16 = 35628454;
            if(this == 0)
            {
                    return;
            }
            
            this.EnsureLayoutHasRebuilt();
            this.UpdateBounds(updateItems:  false);
            val_17 = 1152921516519434528;
            if(this.m_Vertical == false)
            {
                goto label_3;
            }
            
            if(this.m_Horizontal == false)
            {
                goto label_4;
            }
            
            val_18 = data.<scrollDelta>k__BackingField;
            goto label_5;
            label_3:
            val_18 = data.<scrollDelta>k__BackingField;
            goto label_6;
            label_4:
            float val_17 = System.Math.Abs(3322652960);
            val_18 = 0;
            float val_18 = System.Math.Abs(data.<scrollDelta>k__BackingField);
            if(UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished > 0)
            {
                    val_17 = data.<scrollDelta>k__BackingField;
            }
            
            label_6:
            if(this.m_Horizontal == false)
            {
                goto label_10;
            }
            
            label_5:
            if(this.m_Vertical != true)
            {
                    float val_19 = System.Math.Abs(val_17);
                var val_1 = val_18 & (~2147483648);
                if(UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished > 0)
            {
                    val_18 = val_17;
            }
            
                val_17 = 0;
            }
            
            label_10:
            UnityEngine.Vector2 val_2 = anchoredPosition;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = 8926.508f, y = val_18}, d:  val_2.x);
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 8926.5f, y = val_3}, b:  new UnityEngine.Vector2() {x = val_4, y = val_7});
            val_19 = val_9;
            val_16 = val_10;
            if(this.m_MovementType == 2)
            {
                    val_18 = 0;
                UnityEngine.Vector2 val_11 = anchoredPosition;
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 8926.508f, y = val_19}, b:  new UnityEngine.Vector2() {x = val_16, y = val_3});
                UnityEngine.Vector2 val_13 = CalculateOffset(delta:  new UnityEngine.Vector2() {x = 8938.281f, y = val_7});
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 8926.492f, y = val_19}, b:  new UnityEngine.Vector2() {x = val_16, y = val_9});
                val_19 = val_15;
                val_16 = val_16;
            }
            
            this.UpdateBounds(updateItems:  false);
        }
        public virtual void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.m_Velocity = new UnityEngine.Vector2();
            mem[1152921514372087648] = ???;
        }
        public virtual void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_2;
            UnityEngine.Vector2 val_3;
            UnityEngine.Vector2 val_8;
            var val_9;
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            if(this == 0)
            {
                    return;
            }
            
            this.UpdateBounds(updateItems:  false);
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            35628456 = this;
            mem[1152921514372220060] = val_2;
            this.m_PointerStartLocalCursor = val_3;
            UnityEngine.RectTransform val_4 = this.viewRect;
            UnityEngine.Camera val_5 = eventData.pressEventCamera;
            bool val_6 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  1175438368, screenPoint:  new UnityEngine.Vector2() {x = eventData.<position>k__BackingField, y = R8}, cam:  eventData, localPoint: out  new UnityEngine.Vector2() {x = 9201.148f, y = 0f});
            UnityEngine.Vector2 val_7 = anchoredPosition;
            this.m_ContentStartPosition = val_8;
            mem[1152921514372220068] = val_9;
            this.m_Dragging = true;
        }
        public virtual void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if((eventData.<button>k__BackingField) == 0)
            {
                    eventData.<button>k__BackingField = false;
                this.m_Dragging = eventData.<button>k__BackingField;
            }
        
        }
        public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_6;
            float val_8;
            float val_9;
            float val_12;
            float val_14;
            float val_17;
            var val_18;
            var val_20;
            var val_21;
            var val_26;
            UnityEngine.Vector2 val_27;
            var val_28;
            float val_29;
            var val_30;
            val_26 = 35628457;
            if((eventData.<button>k__BackingField) != 0)
            {
                    return;
            }
            
            if(this == 0)
            {
                    return;
            }
            
            UnityEngine.RectTransform val_1 = this.viewRect;
            val_26 = this;
            val_27 = eventData.<position>k__BackingField;
            val_29 = 0f;
            UnityEngine.Camera val_2 = eventData.pressEventCamera;
            if((UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  1175707424, screenPoint:  new UnityEngine.Vector2() {x = val_27, y = R8}, cam:  eventData, localPoint: out  new UnityEngine.Vector2() {x = 9452.023f, y = val_29})) == false)
            {
                    return;
            }
            
            this.UpdateBounds(updateItems:  false);
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 9451.973f, y = 0f}, b:  new UnityEngine.Vector2() {x = 0f, y = this.m_PointerStartLocalCursor});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 9452.016f, y = this.m_ContentStartPosition}, b:  new UnityEngine.Vector2() {x = 0f, y = val_6});
            val_29 = 0;
            UnityEngine.Vector2 val_10 = anchoredPosition;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 9452f, y = val_8}, b:  new UnityEngine.Vector2() {x = val_9, y = val_12});
            UnityEngine.Vector2 val_16 = CalculateOffset(delta:  new UnityEngine.Vector2() {x = 9463.781f, y = val_14});
            val_28 = val_18;
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 9451.984f, y = val_8}, b:  new UnityEngine.Vector2() {x = val_9, y = val_17});
            val_30 = val_20;
            val_26 = val_21;
            if(this.m_MovementType != 1)
            {
                    return;
            }
            
            if(this.m_MovementType != 1)
            {
                    UnityEngine.Vector3 val_22 = size;
                float val_23 = UnityEngine.UI.LoopScrollRect.RubberDelta(overStretching:  val_22.x, viewSize:  val_22.y);
                val_30 = val_30;
            }
            
            if(this.m_MovementType == 1)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_24 = size;
            float val_25 = UnityEngine.UI.LoopScrollRect.RubberDelta(overStretching:  val_24.x, viewSize:  val_24.y);
            val_26 = val_26;
        }
        protected virtual void SetContentAnchoredPosition(UnityEngine.Vector2 position)
        {
            float val_2;
            float val_4;
            float val_7;
            float val_8;
            UnityEngine.RectTransform val_9;
            val_7 = position.y;
            val_8 = position.x;
            if(this.m_Horizontal != true)
            {
                    UnityEngine.Vector2 val_1 = anchoredPosition;
                val_8 = val_2;
            }
            
            if(this.m_Vertical != true)
            {
                    UnityEngine.Vector2 val_3 = anchoredPosition;
                val_7 = val_4;
            }
            
            val_9 = this.m_Content;
            UnityEngine.Vector2 val_5 = anchoredPosition;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_8, y = val_7}, rhs:  new UnityEngine.Vector2() {x = val_2, y = val_4})) == false)
            {
                    return;
            }
            
            val_9 = this.m_Content;
            val_9.anchoredPosition = new UnityEngine.Vector2() {x = val_8, y = val_7};
            this.UpdateBounds(updateItems:  true);
        }
        protected virtual void LateUpdate()
        {
            float val_5;
            float val_6;
            float val_31;
            float val_32;
            float val_34;
            float val_35;
            UnityEngine.Vector2 val_44;
            var val_45;
            float val_51;
            float val_52;
            float val_53;
            float val_54;
            var val_55;
            var val_56;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_Content)) == false)
            {
                    return;
            }
            
            this.EnsureLayoutHasRebuilt();
            this.UpdateScrollbarVisibility();
            this.UpdateBounds(updateItems:  false);
            float val_2 = UnityEngine.Time.unscaledDeltaTime;
            val_51 = 1152921504762331136;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            val_52 = 0;
            val_53 = 0;
            UnityEngine.Vector2 val_4 = CalculateOffset(delta:  new UnityEngine.Vector2() {x = 9771.531f, y = 0f});
            if(this.m_Dragging == true)
            {
                goto label_6;
            }
            
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_5, y = val_6}, rhs:  new UnityEngine.Vector2() {x = 0f, y = 0f})) == true)
            {
                goto label_9;
            }
            
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
            val_52 = 0;
            val_53 = 0;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.m_Velocity, y = val_6}, rhs:  new UnityEngine.Vector2() {x = 0f, y = 0f})) == false)
            {
                goto label_29;
            }
            
            label_9:
            UnityEngine.Vector2 val_11 = 0.anchoredPosition;
            label_26:
            if(this.m_MovementType != 1)
            {
                goto label_14;
            }
            
            float val_12 = val_5.Item[0];
            if(this.m_MovementType != 1)
            {
                goto label_15;
            }
            
            label_14:
            if(this.m_Inertia == false)
            {
                goto label_21;
            }
            
            float val_13 = this.m_Velocity.Item[0];
            float val_51 = this.m_DecelerationRate;
            val_51 = this.m_Velocity * val_51;
            this.m_Velocity.set_Item(index:  0, value:  val_51);
            UnityEngine.Vector2 val_52 = this.m_Velocity;
            float val_14 = val_52.Item[0];
            val_52 = val_52 & (~2147483648);
            this.m_Velocity.set_Item(index:  0, value:  val_52);
            float val_15 = 0.Item[0];
            float val_16 = this.m_Velocity.Item[0];
            goto label_20;
            label_15:
            float val_17 = this.m_Velocity.Item[0];
            UnityEngine.Vector2 val_18 = 0.anchoredPosition;
            float val_19 = 0.Item[0];
            UnityEngine.Vector2 val_20 = anchoredPosition;
            float val_21 = val_5.Item[0];
            float val_22 = val_5.Item[0];
            float val_25 = UnityEngine.Mathf.SmoothDamp(current:  1176010448 + 1176010472, target:  val_20.y, currentVelocity: ref  float val_24 = 9759.703f, smoothTime:  null, maxSpeed:  null, deltaTime:  null);
            0.set_Item(index:  0, value:  val_25);
            label_20:
            label_21:
            this.m_Velocity.set_Item(index:  0, value:  val_25);
            if(1 != 2)
            {
                goto label_26;
            }
            
            val_51 = 1152921504762331136;
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.zero;
            val_52 = val_5;
            val_53 = val_6;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = mem[this.m_Velocity + (0)], y = mem[this.m_Velocity + (4)]}, rhs:  new UnityEngine.Vector2() {x = val_52, y = val_53})) != false)
            {
                    val_54 = 0;
                val_55 = 0;
                if(this.m_MovementType == 2)
            {
                    UnityEngine.Vector2 val_28 = val_5.anchoredPosition;
                UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 9759.688f, y = 0f}, b:  new UnityEngine.Vector2() {x = 0f, y = val_5});
                UnityEngine.Vector2 val_30 = CalculateOffset(delta:  new UnityEngine.Vector2() {x = 9771.531f, y = val_5});
                UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 9759.734f, y = 0f}, b:  new UnityEngine.Vector2() {x = 0f, y = val_32});
                val_54 = val_34;
                val_55 = val_35;
            }
            
                val_52 = val_55;
            }
            
            label_29:
            if(this.m_Dragging == false)
            {
                goto label_35;
            }
            
            label_6:
            if(this.m_Inertia != false)
            {
                    UnityEngine.Vector2 val_36 = anchoredPosition;
                UnityEngine.Vector2 val_37 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 9759.727f, y = val_34}, b:  new UnityEngine.Vector2() {x = val_35, y = this.m_PrevPosition});
                UnityEngine.Vector2 val_38 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = 9759.719f, y = val_32}, d:  val_37.x);
                UnityEngine.Vector3 val_39 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 9759.703f, y = val_54});
                UnityEngine.Vector3 val_41 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 9759.688f, y = this.m_Velocity});
                float val_53 = 10f;
                val_53 = 0 * val_53;
                UnityEngine.Vector3 val_42 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 9759.672f}, b:  new UnityEngine.Vector3() {y = val_5, z = val_6}, t:  val_53);
                UnityEngine.Vector2 val_43 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 9759.664f});
                this.m_Velocity = val_44;
                mem[1152921514372804320] = val_45;
            }
            
            label_35:
            if((UnityEngine.Bounds.op_Inequality(lhs:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.m_ViewBounds}, m_Extents = new UnityEngine.Vector3() {y = ???, z = val_6}}, rhs:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.m_PrevViewBounds, y = this.m_ViewBounds, z = ???}, m_Extents = new UnityEngine.Vector3() {x = val_51, z = val_5}})) != true)
            {
                    if((UnityEngine.Bounds.op_Inequality(lhs:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.m_ContentBounds}, m_Extents = new UnityEngine.Vector3() {y = ???, z = val_6}}, rhs:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = this.m_PrevContentBounds, y = this.m_ContentBounds, z = ???}, m_Extents = new UnityEngine.Vector3()})) != true)
            {
                    val_56 = 0;
                UnityEngine.Vector2 val_48 = val_5.anchoredPosition;
                if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_5, y = val_6}, rhs:  new UnityEngine.Vector2() {x = this.m_PrevPosition, y = val_6})) == false)
            {
                    return;
            }
            
            }
            
            }
            
            this.UpdateScrollbars(offset:  new UnityEngine.Vector2() {x = val_32, y = val_31});
            UnityEngine.Vector2 val_50 = val_5.normalizedPosition;
            this.m_OnValueChanged.Invoke(arg0:  new UnityEngine.Vector2() {x = val_5, y = val_6});
            this.UpdatePrevData();
        }
        private void UpdatePrevData()
        {
            UnityEngine.Vector2 val_4;
            var val_5;
            if(this.m_Content == 0)
            {
                    UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            }
            else
            {
                    UnityEngine.Vector2 val_3 = anchoredPosition;
            }
            
            this.m_PrevPosition = val_4;
            mem[1152921514372965484] = val_5;
        }
        private void UpdateScrollbars(UnityEngine.Vector2 offset)
        {
            float val_3;
            var val_6;
            float val_13;
            var val_16;
            float val_21 = offset.x;
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  this.m_HorizontalScrollbar);
            if(val_1 == false)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_2 = size;
            if((val_1 > false) && (this.totalCount >= 1))
            {
                    UnityEngine.Vector3 val_4 = size;
                UnityEngine.Vector3 val_5 = size;
                float val_21 = System.Math.Abs(val_21 = offset.x);
                val_21 = val_3 - val_21;
                val_21 = val_21 / val_6;
                val_21 = val_21 * (float)this.CurrentLines;
                val_21 = val_21 / (float)this.TotalLines;
                float val_9 = UnityEngine.Mathf.Clamp01(value:  val_21);
                if(this.m_HorizontalScrollbar != 0)
            {
                goto label_9;
            }
            
            }
            
            label_9:
            this.m_HorizontalScrollbar.size = val_3;
            val_21 = this;
            this.m_HorizontalScrollbar.value = this.horizontalNormalizedPosition;
            label_3:
            bool val_11 = UnityEngine.Object.op_Implicit(exists:  this.m_VerticalScrollbar);
            if(val_11 == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_12 = size;
            if((val_11 > false) && (this.totalCount >= 1))
            {
                    val_21 = this.m_VerticalScrollbar;
                UnityEngine.Vector3 val_14 = size;
                UnityEngine.Vector3 val_15 = size;
                float val_22 = System.Math.Abs(offset.y);
                val_22 = val_13 - val_22;
                val_22 = val_22 / val_16;
                val_22 = val_22 * (float)this.CurrentLines;
                val_22 = val_22 / (float)this.TotalLines;
                float val_19 = UnityEngine.Mathf.Clamp01(value:  val_22);
                if(val_21 != 0)
            {
                goto label_20;
            }
            
            }
            
            label_20:
            this.m_VerticalScrollbar.size = val_13;
            this.m_VerticalScrollbar.value = this.verticalNormalizedPosition;
        }
        public UnityEngine.Vector2 get_normalizedPosition()
        {
            float val_1 = R1.horizontalNormalizedPosition;
            float val_2 = R1.verticalNormalizedPosition;
            this = 0;
            mem[1152921514373263012] = 0;
            this = new UnityEngine.Vector2(x:  val_2, y:  null);
            return new UnityEngine.Vector2() {x = val_2};
        }
        public void set_normalizedPosition(UnityEngine.Vector2 value)
        {
            this.SetNormalizedPosition(value:  null, axis:  value.x);
            this.SetNormalizedPosition(value:  null, axis:  value.y);
        }
        public float get_horizontalNormalizedPosition()
        {
            var val_2;
            var val_6;
            this.UpdateBounds(updateItems:  false);
            if(this.totalCount >= 1)
            {
                    this.totalCount = this.itemTypeStart;
                0 = this.itemTypeEnd;
            }
            
            if(0 <= this.totalCount)
            {
                    return 0.5f;
            }
            
            UnityEngine.Vector3 val_1 = size;
            var val_15 = val_2;
            UnityEngine.Vector3 val_5 = min;
            int val_7 = this.StartLine;
            UnityEngine.Vector3 val_8 = size;
            float val_14 = (float)this.CurrentLines;
            val_14 = val_15 / val_14;
            val_15 = val_14 * (float)this.TotalLines;
            if(0 > this.totalCount)
            {
                    UnityEngine.Vector3 val_10 = min;
                UnityEngine.Vector3 val_11 = size;
                var val_16 = val_6;
                val_16 = val_15 - val_16;
                val_16 = (val_2 - val_6) / val_16;
                return 0.5f;
            }
            
            UnityEngine.Vector3 val_13 = min;
            if(0 > this.totalCount)
            {
                    0f = 1f;
            }
            
            return 0.5f;
        }
        public void set_horizontalNormalizedPosition(float value)
        {
            this.SetNormalizedPosition(value:  value, axis:  0);
        }
        public float get_verticalNormalizedPosition()
        {
            var val_2;
            var val_6;
            this.UpdateBounds(updateItems:  false);
            if(this.totalCount >= 1)
            {
                    this.totalCount = this.itemTypeStart;
                0 = this.itemTypeEnd;
            }
            
            if(0 <= this.totalCount)
            {
                    return 0.5f;
            }
            
            UnityEngine.Vector3 val_1 = size;
            var val_15 = val_2;
            UnityEngine.Vector3 val_5 = max;
            int val_7 = this.StartLine;
            UnityEngine.Vector3 val_8 = size;
            float val_14 = (float)this.CurrentLines;
            val_14 = val_15 / val_14;
            val_15 = val_14 * (float)this.TotalLines;
            if(0 > this.totalCount)
            {
                    UnityEngine.Vector3 val_10 = max;
                UnityEngine.Vector3 val_11 = size;
                var val_16 = val_6;
                val_16 = val_15 - val_16;
                val_16 = (val_6 - val_2) / val_16;
                return 0.5f;
            }
            
            UnityEngine.Vector3 val_13 = max;
            if(0 > this.totalCount)
            {
                    0f = 1f;
            }
            
            return 0.5f;
        }
        public void set_verticalNormalizedPosition(float value)
        {
            this.SetNormalizedPosition(value:  value, axis:  0);
        }
        private void SetHorizontalNormalizedPosition(float value)
        {
            this.SetNormalizedPosition(value:  value, axis:  0);
        }
        private void SetVerticalNormalizedPosition(float value)
        {
            this.SetNormalizedPosition(value:  value, axis:  0);
        }
        private void SetNormalizedPosition(float value, int axis)
        {
            float val_2;
            float val_3;
            var val_9;
            var val_12;
            float val_14;
            var val_19;
            var val_23;
            var val_28;
            var val_31;
            var val_32;
            if(this.totalCount >= 1)
            {
                    this.totalCount = this.itemTypeStart;
                axis = this.itemTypeEnd;
            }
            
            if(axis <= this.totalCount)
            {
                    return;
            }
            
            this.EnsureLayoutHasRebuilt();
            this.UpdateBounds(updateItems:  false);
            UnityEngine.Vector3 val_1 = localPosition;
            float val_4 = val_3.Item[R2];
            val_31 = 1177373576;
            if(R2 == 1)
            {
                goto label_3;
            }
            
            if(R2 != 0)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_5 = size;
            var val_31 = val_3;
            val_32 = this.TotalLines;
            UnityEngine.Vector3 val_8 = min;
            int val_10 = this.StartLine;
            UnityEngine.Vector3 val_11 = min;
            UnityEngine.Vector3 val_13 = size;
            val_31 = val_31 / (float)this.CurrentLines;
            float val_16 = val_14.Item[0];
            val_31 = val_31 + (val_12 - val_9);
            goto label_5;
            label_3:
            UnityEngine.Vector3 val_18 = size;
            val_32 = this.TotalLines;
            UnityEngine.Vector3 val_22 = max;
            int val_24 = this.StartLine;
            UnityEngine.Vector3 val_25 = size;
            UnityEngine.Vector3 val_27 = max;
            float val_32 = (float)this.CurrentLines;
            val_32 = val_19 / val_32;
            var val_33 = val_28;
            val_33 = val_23 - val_33;
            val_31 = val_31 - val_33;
            label_5:
            float val_29 = val_3.Item[R2];
            float val_34 = System.Math.Abs(1177373576 - val_31);
            val_3.set_Item(index:  R2, value:  val_34);
            this.m_Content.localPosition = new UnityEngine.Vector3() {x = val_3, y = 0f, z = val_2};
            this.m_Velocity.set_Item(index:  R2, value:  val_34);
            this.UpdateBounds(updateItems:  true);
        }
        private static float RubberDelta(float overStretching, float viewSize)
        {
            float val_1 = UnityEngine.Mathf.Sign(f:  overStretching);
            float val_2 = System.Math.Abs(0);
            val_2 = val_2 * 0.55f;
            val_2 = val_2 / R1;
            val_2 = val_2 + 1f;
            val_2 = 1f / val_2;
            val_2 = 1f - val_2;
            val_2 = val_2 * R1;
            val_2 = val_2 * 0;
            return (float)val_2;
        }
        protected override void OnRectTransformDimensionsChange()
        {
            this.SetDirty();
        }
        private bool get_hScrollingNeeded()
        {
            var val_5;
            var val_6;
            bool val_1 = UnityEngine.Application.isPlaying;
            val_6 = 1;
            if(val_1 == false)
            {
                    return (bool)val_6;
            }
            
            UnityEngine.Vector3 val_2 = size;
            UnityEngine.Vector3 val_4 = size;
            float val_6 = 0.01f;
            val_6 = val_5 + val_6;
            if(val_1 > false)
            {
                    0 = 1;
            }
            
            val_6 = 1;
            return (bool)val_6;
        }
        private bool get_vScrollingNeeded()
        {
            var val_5;
            var val_6;
            bool val_1 = UnityEngine.Application.isPlaying;
            val_6 = 1;
            if(val_1 == false)
            {
                    return (bool)val_6;
            }
            
            UnityEngine.Vector3 val_2 = size;
            UnityEngine.Vector3 val_4 = size;
            float val_6 = 0.01f;
            val_6 = val_5 + val_6;
            if(val_1 > false)
            {
                    0 = 1;
            }
            
            val_6 = 1;
            return (bool)val_6;
        }
        public virtual void CalculateLayoutInputHorizontal()
        {
        
        }
        public virtual void CalculateLayoutInputVertical()
        {
        
        }
        public virtual float get_minWidth()
        {
            return (float)S0;
        }
        public virtual float get_preferredWidth()
        {
            return (float)S0;
        }
        public virtual float get_flexibleWidth()
        {
            return (float)S0;
        }
        private void set_flexibleWidth(float value)
        {
            this.<flexibleWidth>k__BackingField = ;
        }
        public virtual float get_minHeight()
        {
            return (float)S0;
        }
        public virtual float get_preferredHeight()
        {
            return (float)S0;
        }
        public virtual float get_flexibleHeight()
        {
            return (float)S0;
        }
        public virtual int get_layoutPriority()
        {
            return 0;
        }
        public virtual void SetLayoutHorizontal()
        {
            float val_4;
            float val_5;
            float val_8;
            float val_9;
            float val_12;
            float val_13;
            float val_16;
            float val_17;
            float val_21;
            float val_27;
            float val_30;
            float val_31;
            float val_32;
            var val_35;
            var val_36;
            float val_81;
            var val_83;
            var val_84;
            var val_85;
            val_81 = 0;
            this.m_Tracker.Clear();
            if(this.m_HSliderExpand == true)
            {
                goto label_1;
            }
            
            val_83 = this;
            if(this.m_VSliderExpand == false)
            {
                goto label_23;
            }
            
            label_1:
            UnityEngine.RectTransform val_1 = this.viewRect;
            this.m_Tracker.Add(driver:  1179082016, rectTransform:  1179082016, drivenProperties:  16134);
            UnityEngine.RectTransform val_2 = this.viewRect;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this.anchorMin = new UnityEngine.Vector2() {x = val_4, y = val_5};
            UnityEngine.RectTransform val_6 = this.viewRect;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.one;
            this.anchorMax = new UnityEngine.Vector2() {x = val_8, y = val_9};
            UnityEngine.RectTransform val_10 = this.viewRect;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.zero;
            this.sizeDelta = new UnityEngine.Vector2() {x = val_12, y = val_13};
            UnityEngine.RectTransform val_14 = this.viewRect;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.zero;
            this.anchoredPosition = new UnityEngine.Vector2() {x = val_16, y = val_17};
            UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot:  this.m_Content);
            UnityEngine.RectTransform val_18 = this.viewRect;
            val_84 = 0;
            UnityEngine.Rect val_19 = rect;
            UnityEngine.Vector2 val_20 = center;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 12747.43f, y = val_21});
            UnityEngine.RectTransform val_24 = this.viewRect;
            UnityEngine.Rect val_25 = rect;
            UnityEngine.Vector2 val_26 = size;
            UnityEngine.Vector3 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 12747.39f, y = val_27});
            UnityEngine.Bounds val_33 = new UnityEngine.Bounds(center:  new UnityEngine.Vector3(), size:  new UnityEngine.Vector3() {x = val_31, y = val_30, z = val_32});
            mem[1152921514375863764] = val_33.m_Extents.y;
            mem[1152921514375863768] = val_33.m_Center.x;
            UnityEngine.Bounds val_34 = GetBounds();
            val_83 = this;
            mem[1152921514375863740] = val_36;
            mem[1152921514375863744] = val_35;
            if((this.m_VSliderExpand != false) && (this.vScrollingNeeded != false))
            {
                    UnityEngine.RectTransform val_38 = this.viewRect;
                UnityEngine.RectTransform val_39 = this.viewRect;
                UnityEngine.Vector2 val_40 = sizeDelta;
                float val_41 = this.m_VSliderWidth + this.m_VerticalScrollbarSpacing;
                val_9 = 0;
                val_8 = 0;
                float val_42 = val_41 ^ 2147483648;
                UnityEngine.Vector2 val_43 = new UnityEngine.Vector2(x:  val_41, y:  val_40.y);
                this.sizeDelta = new UnityEngine.Vector2() {x = val_43.x, y = val_43.y};
                UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot:  this.m_Content);
                UnityEngine.RectTransform val_44 = this.viewRect;
                UnityEngine.Rect val_45 = rect;
                UnityEngine.Vector2 val_46 = center;
                UnityEngine.Vector3 val_47 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 12747.43f, y = val_12});
                UnityEngine.RectTransform val_48 = this.viewRect;
                UnityEngine.Rect val_49 = rect;
                UnityEngine.Vector2 val_50 = size;
                UnityEngine.Vector3 val_51 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 12747.39f, y = val_16});
                val_81 = val_32;
                mem2[0] = 0;
                val_34.m_Extents.z = new UnityEngine.Bounds(center:  new UnityEngine.Vector3(), size:  new UnityEngine.Vector3() {x = val_31, y = val_30, z = val_81});
                mem[1152921514375863764] = 0;
                mem[1152921514375863768] = val_34.m_Extents.z;
                UnityEngine.Bounds val_53 = GetBounds();
                val_83 = this.m_VSliderExpand;
                mem[1152921514375863740] = val_36;
                mem[1152921514375863744] = val_35;
            }
            
            label_23:
            if(this.m_HSliderExpand != false)
            {
                    if(this.hScrollingNeeded != false)
            {
                    UnityEngine.RectTransform val_55 = this.viewRect;
                UnityEngine.RectTransform val_56 = this.viewRect;
                UnityEngine.Vector2 val_57 = sizeDelta;
                float val_81 = this.m_HorizontalScrollbarSpacing;
                val_81 = this.m_HSliderHeight + val_81;
                val_9 = 0;
                val_8 = 0;
                float val_58 = val_81 ^ 2147483648;
                UnityEngine.Vector2 val_59 = new UnityEngine.Vector2(x:  val_81, y:  val_57.y);
                this.sizeDelta = new UnityEngine.Vector2() {x = val_59.x, y = val_59.y};
                UnityEngine.RectTransform val_60 = this.viewRect;
                UnityEngine.Rect val_61 = rect;
                UnityEngine.Vector2 val_62 = center;
                val_84 = 0;
                UnityEngine.Vector3 val_63 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 12747.43f, y = val_12});
                UnityEngine.RectTransform val_64 = this.viewRect;
                UnityEngine.Rect val_65 = rect;
                UnityEngine.Vector2 val_66 = size;
                UnityEngine.Vector3 val_67 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 12747.39f, y = val_16});
                val_85 = 20;
                UnityEngine.Bounds val_68 = new UnityEngine.Bounds(center:  new UnityEngine.Vector3(), size:  new UnityEngine.Vector3());
                mem[1152921514375863764] = val_68.m_Extents.y;
                mem[1152921514375863768] = val_68.m_Center.x;
                UnityEngine.Bounds val_69 = GetBounds();
                mem[1152921514375863740] = val_69.m_Extents.z;
                mem[1152921514375863744] = val_35;
            }
            
            }
            
            if(val_69.m_Extents.y == 0f)
            {
                    return;
            }
            
            if(this.vScrollingNeeded == false)
            {
                    return;
            }
            
            UnityEngine.RectTransform val_71 = this.viewRect;
            UnityEngine.Vector2 val_72 = val_68.m_Center.x.sizeDelta;
            if(this != 0)
            {
                    return;
            }
            
            UnityEngine.RectTransform val_73 = this.viewRect;
            UnityEngine.Vector2 val_74 = val_68.m_Center.x.sizeDelta;
            if(this >= 0)
            {
                    return;
            }
            
            UnityEngine.RectTransform val_75 = this.viewRect;
            UnityEngine.RectTransform val_76 = this.viewRect;
            val_81 = 0;
            UnityEngine.Vector2 val_77 = val_68.m_Center.x.sizeDelta;
            float val_78 = this.m_VSliderWidth + this.m_VerticalScrollbarSpacing;
            val_36 = val_81;
            float val_79 = val_78 ^ 2147483648;
            UnityEngine.Vector2 val_80 = new UnityEngine.Vector2(x:  val_78, y:  val_77.y);
            this.sizeDelta = new UnityEngine.Vector2() {x = val_80.x, y = val_80.y};
        }
        public virtual void SetLayoutVertical()
        {
            float val_4;
            float val_10;
            var val_16;
            this.UpdateScrollbarLayout();
            UnityEngine.RectTransform val_1 = this.viewRect;
            UnityEngine.Rect val_2 = rect;
            UnityEngine.Vector2 val_3 = center;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 12864.86f, y = val_4});
            UnityEngine.RectTransform val_7 = this.viewRect;
            UnityEngine.Rect val_8 = rect;
            UnityEngine.Vector2 val_9 = size;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 12864.82f, y = val_10});
            UnityEngine.Bounds val_13 = new UnityEngine.Bounds(center:  new UnityEngine.Vector3(), size:  new UnityEngine.Vector3());
            mem[1152921514375983956] = val_13.m_Extents.y;
            mem[1152921514375983960] = val_13.m_Center.x;
            UnityEngine.Bounds val_14 = GetBounds();
            float val_15 = val_14.m_Extents.y + 140;
            mem2[0] = val_14.m_Extents.z;
            mem2[0] = val_16;
        }
        private void UpdateScrollbarVisibility()
        {
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  this.m_VerticalScrollbar);
            if(val_1 == true)
            {
                    val_1 = this.m_VerticalScrollbarVisibility;
            }
            
            if(val_1 != 0)
            {
                goto label_3;
            }
            
            label_12:
            bool val_2 = UnityEngine.Object.op_Implicit(exists:  this.m_HorizontalScrollbar);
            if(val_2 == true)
            {
                    val_2 = this.m_HorizontalScrollbarVisibility;
            }
            
            if(val_2 != 0)
            {
                goto label_6;
            }
            
            return;
            label_3:
            UnityEngine.GameObject val_3 = this.m_VerticalScrollbar.gameObject;
            bool val_5 = this.vScrollingNeeded;
            val_5 = this.m_VerticalScrollbar.activeSelf ^ val_5;
            if(val_5 != true)
            {
                goto label_12;
            }
            
            UnityEngine.GameObject val_6 = this.m_VerticalScrollbar.gameObject;
            this.m_VerticalScrollbar.SetActive(value:  this.vScrollingNeeded);
            goto label_12;
            label_6:
            UnityEngine.GameObject val_8 = this.m_HorizontalScrollbar.gameObject;
            bool val_10 = this.hScrollingNeeded;
            val_10 = this.m_HorizontalScrollbar.activeSelf ^ val_10;
            if(val_10 != true)
            {
                    return;
            }
            
            UnityEngine.GameObject val_11 = this.m_HorizontalScrollbar.gameObject;
            this.m_HorizontalScrollbar.SetActive(value:  this.hScrollingNeeded);
        }
        private void UpdateScrollbarLayout()
        {
            var val_30;
            var val_32;
            var val_34;
            if(this.m_VSliderExpand != false)
            {
                    val_30 = 0;
                if((UnityEngine.Object.op_Implicit(exists:  this.m_HorizontalScrollbar)) != false)
            {
                    this.m_Tracker.Add(driver:  1179540896, rectTransform:  this.m_HorizontalScrollbarRect, drivenProperties:  5378);
                UnityEngine.Vector2 val_2 = anchorMin;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_2.x, y:  val_2.y);
                this.m_HorizontalScrollbarRect.anchorMin = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
                UnityEngine.Vector2 val_5 = anchorMax;
                UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5.x, y:  val_5.y);
                this.m_HorizontalScrollbarRect.anchorMax = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
                UnityEngine.Vector2 val_7 = anchoredPosition;
                UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_7.x, y:  val_7.y);
                this.m_HorizontalScrollbarRect.anchoredPosition = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
                if(this.vScrollingNeeded != false)
            {
                    val_30 = 0;
                UnityEngine.Vector2 val_11 = sizeDelta;
                val_32 = this.m_VSliderWidth + this.m_VerticalScrollbarSpacing;
                float val_12 = val_32 ^ 2147483648;
            }
            else
            {
                    val_30 = 0;
                UnityEngine.Vector2 val_13 = sizeDelta;
            }
            
                UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_13.x, y:  val_13.y);
                this.m_HorizontalScrollbarRect.sizeDelta = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
            }
            
            }
            
            if(this.m_HSliderExpand == false)
            {
                    return;
            }
            
            val_30 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this.m_VerticalScrollbar)) == false)
            {
                    return;
            }
            
            this.m_Tracker.Add(driver:  1179540896, rectTransform:  this.m_VerticalScrollbarRect, drivenProperties:  10756);
            UnityEngine.Vector2 val_16 = anchorMin;
            UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  val_16.x, y:  val_16.y);
            this.m_VerticalScrollbarRect.anchorMin = new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
            UnityEngine.Vector2 val_19 = anchorMax;
            UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  val_19.x, y:  val_19.y);
            this.m_VerticalScrollbarRect.anchorMax = new UnityEngine.Vector2() {x = val_20.x, y = val_20.y};
            UnityEngine.Vector2 val_21 = anchoredPosition;
            UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_21.x, y:  val_21.y);
            this.m_VerticalScrollbarRect.anchoredPosition = new UnityEngine.Vector2() {x = val_23.x, y = val_23.y};
            val_30 = this.hScrollingNeeded;
            if(val_30 != false)
            {
                    val_30 = 0;
                UnityEngine.Vector2 val_25 = sizeDelta;
                val_34 = this.m_HSliderHeight + this.m_HorizontalScrollbarSpacing;
                float val_26 = val_34 ^ 2147483648;
            }
            else
            {
                    UnityEngine.Vector2 val_27 = sizeDelta;
            }
            
            UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  val_27.x, y:  val_27.y);
            this.m_VerticalScrollbarRect.sizeDelta = new UnityEngine.Vector2() {x = val_28.x, y = val_28.y};
        }
        private void UpdateBounds(bool updateItems = False)
        {
            float val_4;
            float val_10;
            var val_16;
            float val_21;
            float val_22;
            float val_23;
            float val_31;
            float val_32;
            UnityEngine.Object val_33;
            float val_34;
            UnityEngine.RectTransform val_1 = this.viewRect;
            UnityEngine.Rect val_2 = rect;
            UnityEngine.Vector2 val_3 = center;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 13352.93f, y = val_4});
            UnityEngine.RectTransform val_7 = this.viewRect;
            UnityEngine.Rect val_8 = rect;
            UnityEngine.Vector2 val_9 = size;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 13352.93f, y = val_10});
            UnityEngine.Bounds val_13 = new UnityEngine.Bounds(center:  new UnityEngine.Vector3(), size:  new UnityEngine.Vector3());
            mem[1152921514376483796] = val_13.m_Extents.y;
            mem[1152921514376483800] = val_13.m_Center.x;
            UnityEngine.Bounds val_14 = GetBounds();
            float val_15 = val_14.m_Extents.y + 140;
            mem2[0] = val_14.m_Extents.z;
            mem2[0] = val_16;
            val_33 = mem[val_14.m_Extents.y + 60];
            val_33 = val_14.m_Extents.y + 60;
            if(val_33 == 0)
            {
                    return;
            }
            
            bool val_18 = UnityEngine.Application.isPlaying;
            if(val_18 == true)
            {
                    val_18 = updateItems;
                goto label_8;
            }
            
            label_16:
            UnityEngine.Vector3 val_19 = val_13.m_Center.x.size;
            val_31 = val_13.m_Center.x;
            val_34 = val_13.m_Center.y;
            UnityEngine.Vector3 val_20 = center;
            val_32 = val_23;
            UnityEngine.Vector3 val_24 = size;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 13352.95f}, b:  new UnityEngine.Vector3() {y = val_31, z = val_34});
            UnityEngine.Vector2 val_26 = pivot;
            UnityEngine.Vector3 val_27 = val_13.m_Center.x.size;
            float val_31 = -0.5f;
            val_31 = val_13.m_Center.x;
            val_31 = val_23 + val_31;
            val_32 = val_32;
            val_33 = val_21;
            if((val_14.m_Extents.y + 60) > 0)
            {
                    UnityEngine.Vector2 val_28 = pivot;
                UnityEngine.Vector3 val_29 = val_13.m_Center.x.size;
                float val_32 = -0.5f;
                val_34 = val_13.m_Center.y;
                val_32 = val_21 + val_32;
                val_33 = val_33;
            }
            
            val_15.size = new UnityEngine.Vector3() {x = val_31, y = val_34, z = val_13.m_Center.z};
            val_15.center = new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_22};
            return;
            label_8:
            if(val_14.m_Extents.y == 0f)
            {
                goto label_16;
            }
            
            UnityEngine.Canvas.ForceUpdateCanvases();
            UnityEngine.Bounds val_30 = val_13.m_Center.x.GetBounds();
            mem2[0] = val_13.m_Center.x;
            mem2[0] = val_13.m_Extents.z;
            goto label_16;
        }
        private UnityEngine.Bounds GetBounds()
        {
            var val_20;
            UnityEngine.Object val_23;
            var val_24;
            var val_25;
            int val_26;
            var val_27;
            var val_29;
            val_20 = R1;
            val_23 = mem[R1 + 60];
            val_23 = R1 + 60;
            val_24 = 0;
            val_25 = 0;
            val_26 = 0;
            if(val_23 == 0)
            {
                    val_27 = 20;
                this.totalCount = val_26;
                this = val_26;
            }
            else
            {
                    UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
                UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
                UnityEngine.RectTransform val_4 = val_20.viewRect;
                UnityEngine.Matrix4x4 val_5 = worldToLocalMatrix;
                var val_20 = 0;
                var val_19 = 0;
                mem2[0] = val_5.m12;
                do
            {
                var val_6 = (val_5.m12 + 288) + val_20;
                float val_7 = val_5.m32 - 128;
                mem2[0] = (val_5.m12 + 288 + 0) + 24;
                mem2[0] = 0;
                float val_8 = val_5.m13 + 64;
                float val_9 = val_5.m13 + 64;
                val_29 = val_5.m32 + -40;
                mem2[0] = val_29;
                val_29 = mem[val_5.m13 + 24];
                val_29 = val_5.m13 + 24;
                float val_10 = val_5.m13 + 48;
                mem2[0] = val_5.m32 + -44;
                mem2[0] = val_29;
                mem2[0] = val_5.m32 + -48;
                mem2[0] = 0;
                float val_11 = val_5.m32 - 64;
                mem2[0] = val_5.m13 + 56;
                float val_12 = val_5.m13 + 32;
                mem2[0] = val_5.m13 + 48;
                val_20 = mem[val_5.m13 + 28];
                val_20 = val_5.m13 + 28;
                val_19 = val_19 + 1;
                val_20 = val_20 + 12;
                mem2[0] = val_5.m13 + 40;
                mem2[0] = val_5.m13 + 32;
            }
            while(val_19 != 4);
            
                float val_13 = val_5.m32 - 48;
                float val_14 = val_5.m13 + 64;
                float val_15 = val_5.m13 + 64;
                float val_17 = val_5.m32 - 64;
                mem2[0] = 0;
                mem2[0] = val_5.m13 + 128;
            }
            
            float val_18 = val_5.m32 - 28;
            return new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_5.m13 + 20, y = mem[(val_5.m32 - 64) + (0)], z = mem[(val_5.m32 - 64) + (4)]}, m_Extents = new UnityEngine.Vector3() {x = mem[(val_5.m32 - 64) + (8)], y = mem[(val_5.m32 - 28) + (0)], z = mem[(val_5.m32 - 28) + (4)]}};
        }
        private UnityEngine.Bounds GetBounds4Item(int index)
        {
            var val_21;
            var val_22;
            var val_24;
            UnityEngine.Object val_25;
            var val_26;
            var val_27;
            int val_28;
            var val_29;
            var val_30;
            var val_31;
            val_21 = R2;
            val_22 = index;
            val_25 = mem[index + 60];
            val_25 = index + 60;
            val_26 = 0;
            val_27 = 0;
            val_28 = 0;
            if(val_25 != 0)
            {
                goto label_3;
            }
            
            val_29 = 20;
            this.totalCount = val_28;
            this = val_28;
            goto label_23;
            label_3:
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            UnityEngine.RectTransform val_4 = val_22.viewRect;
            UnityEngine.Matrix4x4 val_5 = worldToLocalMatrix;
            val_28 = val_5.m02 - (val_5.m22 + 36);
            if(val_28 < 0f)
            {
                goto label_8;
            }
            
            val_25 = mem[val_5.m22 + 60];
            val_25 = val_5.m22 + 60;
            mem2[0] = val_5.m22;
            val_26 = 0;
            val_30 = mem[val_5.m13 + 28];
            val_30 = val_5.m13 + 28;
            if(val_28 >= val_25)
            {
                goto label_8;
            }
            
            val_21 = 0;
            val_24 = 1152921504765685760;
            if((val_5.m13 + 28 + 60) != 0)
            {
                    if((val_5.m13 + 28 + 60) != null)
            {
                    val_5.m13 + 28 + 60 = 0;
            }
            
                val_21 = val_5.m13 + 28 + 60;
            }
            
            val_26 = 0;
            val_27 = 0;
            val_25 = 0;
            if(val_21 == 0)
            {
                goto label_13;
            }
            
            val_29 = 20;
            mem2[0] = val_25;
            mem2[0] = val_25;
            goto label_23;
            label_8:
            val_29 = 20;
            mem2[0] = val_5.m12;
            mem2[0] = val_5.m12;
            label_23:
            float val_6 = val_5.m32 - 28;
            return new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = 2.802597E-44f, y = mem[val_5.m31 + (20) + (20) + (4)], z = mem[val_5.m31 + (20) + (20) + (8)]}, m_Extents = new UnityEngine.Vector3() {x = mem[val_5.m31 + (20) + (20) + (12)], y = mem[(val_5.m32 - 28) + (0)], z = mem[(val_5.m32 - 28) + (4)]}};
            label_13:
            var val_20 = 0;
            var val_19 = 0;
            do
            {
                var val_7 = (val_5.m13 + 28 + 288) + val_20;
                float val_8 = val_5.m32 - 128;
                float val_9 = val_5.m13 + 64;
                float val_10 = val_5.m13 + 64;
                val_31 = val_5.m32 + -40;
                mem2[0] = val_31;
                val_31 = mem[val_5.m13 + 20];
                val_31 = val_5.m13 + 20;
                float val_11 = val_5.m13 + 48;
                mem2[0] = val_31;
                mem2[0] = 0;
                float val_12 = val_5.m32 - 64;
                mem2[0] = val_5.m13 + 56;
                float val_13 = val_5.m13 + 32;
                mem2[0] = val_5.m13 + 48;
                val_19 = val_19 + 1;
                val_20 = val_20 + 12;
                mem2[0] = val_5.m13 + 40;
                mem2[0] = val_5.m13 + 32;
            }
            while(val_19 != 4);
            
            float val_14 = val_5.m32 - 48;
            float val_15 = val_5.m13 + 64;
            float val_16 = val_5.m13 + 64;
            float val_18 = val_5.m32 - 64;
            mem2[0] = 0;
            mem2[0] = val_5.m13 + 128;
            goto label_23;
        }
        private UnityEngine.Vector2 CalculateOffset(UnityEngine.Vector2 delta)
        {
            var val_2;
            float val_3;
            var val_7;
            var val_8;
            var val_11;
            var val_12;
            UnityEngine.UI.LoopScrollRect val_24;
            var val_25;
            UnityEngine.UI.LoopScrollRect val_26;
            UnityEngine.UI.LoopScrollRect val_28;
            var val_29;
            val_24 = this;
            val_25 = R3;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            val_28 = val_2;
            val_29 = val_3;
            if((delta.x + 68) == 0)
            {
                goto label_15;
            }
            
            float val_4 = delta.x + 140;
            val_25 = 0;
            UnityEngine.Vector3 val_5 = min;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 13681.13f});
            var val_23 = val_7;
            var val_25 = val_8;
            UnityEngine.Vector3 val_9 = max;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 13681.1f});
            var val_24 = val_11;
            if((delta.x + 64) == 0)
            {
                goto label_9;
            }
            
            val_25 = delta.x + 164;
            UnityEngine.Vector3 val_13 = min;
            val_23 = val_23 + delta.y;
            if((delta.x + 64) <= 0)
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_14 = min;
            goto label_8;
            label_7:
            UnityEngine.Vector3 val_16 = max;
            val_26 = val_2;
            if((delta.x + 64) >= 0)
            {
                goto label_9;
            }
            
            UnityEngine.Vector3 val_17 = max;
            label_8:
            val_26 = val_2 - (val_12 + delta.y);
            val_28 = val_26;
            label_9:
            if((delta.x + 65) == 0)
            {
                goto label_10;
            }
            
            float val_18 = delta.x + 164;
            UnityEngine.Vector3 val_19 = max;
            val_24 = val_24;
            val_24 = val_24 + val_25;
            if((delta.x + 65) >= 0)
            {
                goto label_11;
            }
            
            UnityEngine.Vector3 val_20 = max;
            val_26 = val_3 - val_24;
            goto label_12;
            label_10:
            val_29 = val_29;
            val_24 = val_24;
            goto label_15;
            label_11:
            val_25 = val_25 + val_25;
            UnityEngine.Vector3 val_21 = min;
            val_26 = val_3;
            if((delta.x + 65) <= 0)
            {
                goto label_14;
            }
            
            UnityEngine.Vector3 val_22 = min;
            val_26 = val_3 - val_25;
            label_12:
            val_29 = val_26;
            goto label_15;
            label_14:
            val_29 = val_29;
            label_15:
            this = val_28;
            mem[1152921514376819620] = val_29;
            return new UnityEngine.Vector2() {x = val_26, y = val_21.y};
        }
        protected void SetDirty()
        {
            if(this == 0)
            {
                    return;
            }
            
            UnityEngine.RectTransform val_1 = R4.rectTransform;
            UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(rect:  R4);
        }
        protected void SetDirtyCaching()
        {
            if(this == 0)
            {
                    return;
            }
            
            UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(element:  R4);
            UnityEngine.RectTransform val_1 = R4.rectTransform;
            UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(rect:  R4);
        }
        private UnityEngine.Transform UnityEngine.UI.ICanvasElement.get_transform()
        {
            return this.transform;
        }
    
    }

}
