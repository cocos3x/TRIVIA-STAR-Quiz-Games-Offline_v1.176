using UnityEngine;

namespace BlockPuzzleMagic
{
    public class ShapeInfo : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler, IPointerClickHandler
    {
        // Fields
        public const int NULL_SHAPE_ID = -1;
        public const string SHAPE_SRC_SHAPE_SPAWNER = "shpsrc_shp_spwn";
        public const string SHAPE_SRC_POWERUP_BUTTON = "shpsrc_pwr_but";
        protected const float ALPHA_UNPLAYABLE = 0.3;
        private const float DRAG_OFFSET_Y = 0.55;
        protected int shapeId;
        private BlockPuzzleMagic.ShapeBlock <FirstBlock>k__BackingField;
        public bool allowPartialFit;
        public bool ignoreFilled;
        protected UnityEngine.Vector2Int blockGridCount;
        protected UnityEngine.Vector2Int blockGridCountUnrotated;
        protected int rotationHeading;
        protected int rotationHeadingNeededToPlace;
        private System.Collections.Generic.List<BlockPuzzleMagic.ShapeBlock> <ShapeBlocks>k__BackingField;
        protected BlockPuzzleMagic.BlockColor colorData;
        private bool isDragged;
        protected bool draggable;
        protected UnityEngine.Vector3 neutralWorldPosition;
        protected UnityEngine.Vector3 neutralScale;
        protected float neutralAlpha;
        protected UnityEngine.Vector3 activeScale;
        protected UnityEngine.RaycastHit2D[] raycastHit;
        protected DG.Tweening.Sequence shapeAnimSeq;
        protected UnityEngine.CanvasGroup shapeCanvas;
        private UnityEngine.Transform originalParentTransform;
        private int originalSiblingIndex;
        private bool prevInteractableState;
        private float dragOffsetY;
        private DG.Tweening.Tween shapeSpawnTween;
        private bool isInputInterrupted;
        private DG.Tweening.Tween initiateDragModeTween;
        private DG.Tweening.Tweener shapeRotationSeq;
        private string <initSource>k__BackingField;
        private UnityEngine.Vector2 <Size>k__BackingField;
        private bool <Placeable>k__BackingField;
        
        // Properties
        public static bool IsRotationAllowed { get; }
        public int ShapeId { get; }
        public BlockPuzzleMagic.ShapeBlock FirstBlock { get; set; }
        public int RotationHeading { get; }
        public System.Collections.Generic.List<BlockPuzzleMagic.ShapeBlock> ShapeBlocks { get; set; }
        public BlockPuzzleMagic.BlockColor ColorData { get; }
        public bool IsDragged { get; }
        public bool Draggable { get; set; }
        public UnityEngine.Vector3 NeutralWorldPosition { get; set; }
        public string initSource { get; set; }
        public UnityEngine.Vector2 Size { get; set; }
        public bool Interactable { get; set; }
        public float Alpha { get; set; }
        public bool Placeable { get; set; }
        public bool PlaceableWithRotation { get; }
        
        // Methods
        public static bool get_IsRotationAllowed()
        {
            return true;
        }
        public int get_ShapeId()
        {
            return (int)this.shapeId;
        }
        public BlockPuzzleMagic.ShapeBlock get_FirstBlock()
        {
        
        }
        protected void set_FirstBlock(BlockPuzzleMagic.ShapeBlock value)
        {
            this.<FirstBlock>k__BackingField = value;
        }
        public int get_RotationHeading()
        {
            return (int)this.rotationHeading;
        }
        public System.Collections.Generic.List<BlockPuzzleMagic.ShapeBlock> get_ShapeBlocks()
        {
        
        }
        private void set_ShapeBlocks(System.Collections.Generic.List<BlockPuzzleMagic.ShapeBlock> value)
        {
            this.<ShapeBlocks>k__BackingField = value;
        }
        public BlockPuzzleMagic.BlockColor get_ColorData()
        {
        
        }
        public bool get_IsDragged()
        {
            return (bool)this.isDragged;
        }
        public bool get_Draggable()
        {
            return (bool)this.draggable;
        }
        public void set_Draggable(bool value)
        {
            this.draggable = value;
        }
        public void set_NeutralWorldPosition(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_NeutralWorldPosition()
        {
            mem[1152921514477696760] = R1 + 68;
            this = R1 + 60;
            return new UnityEngine.Vector3();
        }
        public string get_initSource()
        {
        
        }
        private void set_initSource(string value)
        {
            this.<initSource>k__BackingField = value;
        }
        public UnityEngine.Vector2 get_Size()
        {
            this = R1 + 148;
            mem[1152921514478049140] = R1 + 152;
            return new UnityEngine.Vector2();
        }
        private void set_Size(UnityEngine.Vector2 value)
        {
            this.<Size>k__BackingField = value;
            mem[1152921514478161288] = value.y;
        }
        public bool get_Interactable()
        {
            if(this.shapeCanvas != 0)
            {
                    return this.shapeCanvas.blocksRaycasts;
            }
            
            return this.shapeCanvas.blocksRaycasts;
        }
        public void set_Interactable(bool value)
        {
            this.shapeCanvas.blocksRaycasts = value;
        }
        public float get_Alpha()
        {
            if(this.shapeCanvas != 0)
            {
                    return this.shapeCanvas.alpha;
            }
            
            return this.shapeCanvas.alpha;
        }
        public void set_Alpha(float value)
        {
            this.shapeCanvas.alpha = value;
        }
        public bool get_Placeable()
        {
            return (bool)this.<Placeable>k__BackingField;
        }
        protected void set_Placeable(bool value)
        {
            this.<Placeable>k__BackingField = value;
        }
        public bool get_PlaceableWithRotation()
        {
            if(this.rotationHeadingNeededToPlace < 4)
            {
                    0 = 1;
            }
            
            return true;
        }
        protected virtual void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.GetComponent<System.Object>();
            this.shapeCanvas = this;
        }
        public virtual void Init(UnityEngine.Transform parent, UnityEngine.Vector3 worldPos, float scale, float alpha, string source)
        {
            BlockPuzzleMagic.GameReferenceData val_1 = BlockPuzzleMagic.GameReferenceData.Instance;
            BlockPuzzleMagic.BlockColor val_4 = this.GetBlockColor(colorType:  0);
        }
        public virtual void Init(BlockPuzzleMagic.BlockColor color, UnityEngine.Transform parent, UnityEngine.Vector3 worldPos, float scale, float alpha, string source)
        {
            float val_8;
            string val_12;
            BlockPuzzleMagic.BlockColorType val_19;
            if(color != 0)
            {
                    val_19 = color.blockColor;
            }
            else
            {
                    val_19 = 0;
            }
            
            typeof(BlockPuzzleMagic.BlockColor).__il2cppRuntimeField_8 = val_19;
            this.colorData = new System.Object();
            UnityEngine.GameObject val_2 = parent.gameObject;
            UnityEngine.Transform val_3 = this.transform;
            parent.SetParent(p:  parent);
            UnityEngine.GameObject val_4 = parent.gameObject;
            UnityEngine.Transform val_5 = this.transform;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            parent.localScale = new UnityEngine.Vector3();
            UnityEngine.GameObject val_7 = parent.gameObject;
            UnityEngine.Transform val_9 = this.transform;
            this.neutralWorldPosition = worldPos;
            mem[1152921514479350832] = worldPos.y;
            mem[1152921514479350836] = worldPos.z;
            parent.position = new UnityEngine.Vector3() {x = worldPos.x, y = worldPos.y, z = worldPos.z};
            UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  val_6.x, y:  val_6.y, z:  val_6.z);
            this.neutralAlpha = val_8;
            this.shapeCanvas.alpha = val_6.x;
            this.originalParentTransform = parent;
            UnityEngine.GameObject val_11 = parent.gameObject;
            UnityEngine.Transform val_13 = this.transform;
            this.originalSiblingIndex = parent.GetSiblingIndex();
            this.<initSource>k__BackingField = val_12;
            this.ToggleSortingOrder(bringToFront:  false);
            UnityEngine.GameObject val_15 = parent.gameObject;
            UnityEngine.Transform val_16 = this.transform;
            DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  1282569200, endValue:  new UnityEngine.Vector3() {x = mem[this.neutralScale + (0)], y = mem[this.neutralScale + (4)], z = mem[this.neutralScale + (8)]}, duration:  val_6.x);
            object val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  1282569200, ease:  27);
            this.shapeSpawnTween = this;
        }
        public virtual void InitBlockList()
        {
            BlockPuzzleMagic.ShapeInfo val_21;
            BlockPuzzleMagic.ShapeInfo val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            val_21 = this;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.<ShapeBlocks>k__BackingField = null;
            UnityEngine.Transform val_2 = this.transform;
            T[] val_3 = this.GetComponentsInChildren<System.Object>();
            val_22 = val_21;
            val_23 = 0;
            goto label_2;
            label_26:
            val_24 = mem[this.<FirstBlock>k__BackingField + 0];
            val_24 = this.<FirstBlock>k__BackingField + 0;
            UnityEngine.Transform val_5 = this.transform;
            val_25 = val_21;
            if(val_24.GetInstanceID() == this.GetInstanceID())
            {
                goto label_23;
            }
            
            string val_7 = val_24.name;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 45;
            System.String[] val_8 = val_24.Split(separator:  478563824);
            val_25 = val_24;
            if((this.<FirstBlock>k__BackingField + 0 + 12) != 3)
            {
                goto label_23;
            }
            
            bool val_10 = System.Int32.TryParse(s:  this.<FirstBlock>k__BackingField + 0 + 20, result: out  int val_9 = 1282694760);
            bool val_12 = System.Int32.TryParse(s:  this.<FirstBlock>k__BackingField + 0 + 24, result: out  int val_11 = 1282694756);
            object val_13 = val_24.GetComponent<System.Object>();
            val_25 = val_24;
            this.blockGridCountUnrotated.x = UnityEngine.Mathf.Max(a:  this.blockGridCountUnrotated.x, b:  1);
            this.blockGridCountUnrotated.y = UnityEngine.Mathf.Max(a:  this.blockGridCountUnrotated.y, b:  1);
            object val_18 = val_24.GetComponent<System.Object>();
            typeof(BlockPuzzleMagic.ShapeBlock).__il2cppRuntimeField_8 = val_24;
            typeof(BlockPuzzleMagic.ShapeBlock).__il2cppRuntimeField_C = 0;
            typeof(BlockPuzzleMagic.ShapeBlock).__il2cppRuntimeField_10 = 0;
            typeof(BlockPuzzleMagic.ShapeBlock).__il2cppRuntimeField_14 = val_25;
            typeof(BlockPuzzleMagic.ShapeBlock).__il2cppRuntimeField_18 = val_24;
            typeof(BlockPuzzleMagic.ShapeBlock).__il2cppRuntimeField_1C = 0;
            val_21 = val_21;
            typeof(BlockPuzzleMagic.ShapeBlock).__il2cppRuntimeField_20 = 0;
            val_26 = mem[1152921514479488420];
            if(val_26 != 0)
            {
                    0 = mem[mem[1152921514479488420] + 8];
                0 = mem[1152921514479488420] + 8;
            }
            
            if(0 == 0)
            {
                goto label_18;
            }
            
            if(new System.Object() != 0)
            {
                goto label_19;
            }
            
            val_26 = mem[1152921514479488420];
            if(val_26 == 0)
            {
                goto label_20;
            }
            
            val_25 = typeof(BlockPuzzleMagic.ShapeBlock).__il2cppRuntimeField_14;
            label_19:
            val_24 = mem[mem[1152921514479488420] + 16];
            val_24 = mem[1152921514479488420] + 16;
            val_21 = val_21;
            label_18:
            val_22 = val_22;
            if((Contains(item:  466771968)) != true)
            {
                    Add(item:  466771968);
            }
            
            label_23:
            val_23 = 1;
            label_2:
            if(val_23 < mem[1152921514479488380])
            {
                goto label_26;
            }
            
            this.SetRotation(rotationId:  0);
            return;
            label_20:
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_6 = 1.5f;
            UnityEngine.Vector3 val_5 = this.neutralScale;
            val_5 = val_5 * val_6;
            val_6 = S4 * val_6;
            UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  val_6, y:  null, z:  val_5);
            this.DoSimpleScale(scale:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, duration:  val_6);
            if(this.draggable == false)
            {
                    return;
            }
            
            ShapeInfo.<>c__DisplayClass78_0 val_2 = null;
            35640193 = val_2;
            val_2 = new ShapeInfo.<>c__DisplayClass78_0();
            typeof(ShapeInfo.<>c__DisplayClass78_0).__il2cppRuntimeField_C = this;
            if(this.initiateDragModeTween != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.initiateDragModeTween, complete:  false);
            }
            
            typeof(ShapeInfo.<>c__DisplayClass78_0).__il2cppRuntimeField_8 = eventData;
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  466612224, method:  new IntPtr(1282802992));
            DG.Tweening.Tween val_4 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_6, callback:  1052938076, ignoreTimeScale:  false);
            this.initiateDragModeTween = 1052938076;
        }
        protected void InitiateDragMode(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_4;
            float val_5;
            var val_23;
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 6.505786E+07f, y = eventData.<position>k__BackingField});
            UnityEngine.Vector3 val_6 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_5});
            UnityEngine.GameObject val_9 = this.gameObject;
            UnityEngine.Transform val_10 = this.transform;
            UnityEngine.Vector3 val_11 = localScale;
            if(this != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if((public static BlockPuzzleMagic.GameBoardGenerator MonoSingleton<BlockPuzzleMagic.GameBoardGenerator>::get_Instance()) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_23 = 0;
                UnityEngine.Transform val_15 = static_value_0028000B.transform;
                val_23 = 0;
                UnityEngine.Rect val_16 = rect;
                float val_17 = height;
                uint val_23 = 1282944312;
                val_23 = (public static BlockPuzzleMagic.GameBoardGenerator MonoSingleton<BlockPuzzleMagic.GameBoardGenerator>::get_Instance().__il2cppRuntimeField_54) / val_23;
                UnityEngine.Vector3 val_18 = new UnityEngine.Vector3(x:  val_23, y:  val_16.m_YMin, z:  val_16.m_Width);
            }
            
            UnityEngine.GameObject val_19 = this.gameObject;
            UnityEngine.Transform val_20 = this.transform;
            UnityEngine.Vector3 val_21 = position;
            UnityEngine.Vector3 val_22 = new UnityEngine.Vector3(x:  val_21.x, y:  val_21.y, z:  val_21.z);
            mem2[0] = 0;
            this.isDragged = true;
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.initiateDragModeTween != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.initiateDragModeTween, complete:  false);
            }
            
            if(this.isDragged == false)
            {
                goto label_2;
            }
            
            if(this == 0)
            {
                goto label_3;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            NotifyShapePlaced(shape:  1283084784);
            goto label_8;
            label_2:
            this.DoSimpleScale(scale:  new UnityEngine.Vector3() {x = mem[this.neutralScale + (0)], y = mem[this.neutralScale + (4)], z = mem[this.neutralScale + (8)]}, duration:  null);
            goto label_8;
            label_3:
            label_8:
            this.isDragged = false;
        }
        public virtual void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_4;
            float val_5;
            float val_7;
            float val_8;
            float val_12;
            if(this.initiateDragModeTween != 0)
            {
                    DG.Tweening.TweenExtensions.Complete(t:  this.initiateDragModeTween, withCallbacks:  true);
            }
            
            if(this.shapeRotationSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Complete(t:  this.shapeRotationSeq);
            }
            
            if(this.isDragged == false)
            {
                    return;
            }
            
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 6.658242E+07f, y = eventData.<position>k__BackingField});
            UnityEngine.Vector3 val_6 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_5});
            35640196 = val_8;
            UnityEngine.GameObject val_9 = this.gameObject;
            UnityEngine.Transform val_10 = this.transform;
            UnityEngine.Vector3 val_11 = localPosition;
            UnityEngine.GameObject val_13 = this.gameObject;
            UnityEngine.Transform val_14 = this.transform;
            this.localPosition = new UnityEngine.Vector3() {x = val_7, y = 35640196, z = val_12};
        }
        public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_4;
            float val_5;
            var val_8;
            if(this.isDragged == false)
            {
                    return;
            }
            
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 6.709595E+07f, y = eventData.<position>k__BackingField});
            UnityEngine.Vector3 val_6 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_5});
            UnityEngine.GameObject val_9 = this.gameObject;
            UnityEngine.Transform val_10 = this.transform;
            UnityEngine.GameObject val_11 = this.gameObject;
            eventData = 0;
            UnityEngine.Transform val_12 = this.transform;
            UnityEngine.Vector3 val_13 = position;
            UnityEngine.Vector3 val_16 = new UnityEngine.Vector3(x:  val_8 + this.dragOffsetY, y:  val_13.y, z:  val_13.z);
            this.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        protected virtual void OnApplicationFocus(bool hasFocus)
        {
            if(hasFocus != false)
            {
                    if(this.isInputInterrupted == false)
            {
                    return;
            }
            
                this.isInputInterrupted = false;
                this.isDragged = false;
                return;
            }
            
            if(this.isDragged == true)
            {
                    this.isDragged = true;
                this.isInputInterrupted = this.isDragged;
                return;
            }
        
        }
        public virtual bool CanResolveAction()
        {
            return false;
        }
        public virtual void ResolveAction()
        {
        
        }
        public virtual void Consume()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  1283917936);
        }
        public virtual void SetPlaceableStatus(bool _isPlayable, int validRotationId = -1)
        {
            this.rotationHeadingNeededToPlace = validRotationId;
            this.<Placeable>k__BackingField = _isPlayable;
            if(_isPlayable == false)
            {
                    this.neutralAlpha = 0.3f;
            }
            
            this.shapeCanvas.alpha = null;
        }
        public virtual void SnapAndScaleToWorldPos(UnityEngine.Vector3 posTo, UnityEngine.Vector3 scaleTo, float duration = 0.05, bool applyDragOffset = False)
        {
            var val_5;
            var val_7;
            var val_10;
            this.prevInteractableState = this.shapeCanvas.blocksRaycasts;
            this.shapeCanvas.blocksRaycasts = false;
            this.activeScale = scaleTo;
            mem[1152921514480960460] = scaleTo.y;
            mem[1152921514480960464] = scaleTo.z;
            UnityEngine.GameObject val_2 = this.shapeCanvas.gameObject;
            UnityEngine.Transform val_3 = this.transform;
            UnityEngine.Vector3 val_4 = lossyScale;
            UnityEngine.GameObject val_6 = this.gameObject;
            UnityEngine.Transform val_8 = this.transform;
            UnityEngine.Vector3 val_9 = localScale;
            var val_23 = val_10;
            float val_24 = 0.5f;
            val_23 = scaleTo.y / val_23;
            float val_11 = val_5 * val_23;
            val_24 = S16 * val_24;
            if(val_7 != 0)
            {
                    val_24 = posTo.y;
            }
            
            this.dragOffsetY = 0.55f;
            if(val_7 != 0)
            {
                    posTo.y = 0.55f;
            }
            
            if(this.shapeSpawnTween != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.shapeSpawnTween, complete:  false);
            }
            
            if(this.shapeAnimSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.shapeAnimSeq, complete:  false);
            }
            
            DG.Tweening.Sequence val_12 = DG.Tweening.DOTween.Sequence();
            this.shapeAnimSeq = 0;
            UnityEngine.GameObject val_13 = this.gameObject;
            UnityEngine.Transform val_14 = this.transform;
            DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DOMove(target:  1284178800, endValue:  new UnityEngine.Vector3() {x = posTo.x, y = posTo.y, z = posTo.z}, duration:  0.55f = 0.55f + val_24, snapping:  applyDragOffset);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  1284178800);
            UnityEngine.GameObject val_17 = this.gameObject;
            UnityEngine.Transform val_18 = this.transform;
            DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions.DOScale(target:  1284178800, endValue:  new UnityEngine.Vector3() {x = scaleTo.x, y = scaleTo.y, z = scaleTo.z}, duration:  0.55f);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.shapeAnimSeq, t:  1284178800);
            DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.shapeCanvas, endValue:  0.55f, duration:  val_9.y);
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.shapeAnimSeq, t:  this.shapeCanvas);
            this.ToggleSortingOrder(bringToFront:  true);
        }
        public virtual void SnapBackAndReset(System.Action onComplete)
        {
            var val_15;
            if((new ShapeInfo.<>c__DisplayClass90_0()) != 0)
            {
                    typeof(ShapeInfo.<>c__DisplayClass90_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(ShapeInfo.<>c__DisplayClass90_0).__il2cppRuntimeField_C = onComplete;
            if(this.prevInteractableState == true)
            {
                    this.prevInteractableState = 1;
            }
            
            val_15 = 0;
            this.shapeCanvas.blocksRaycasts = true;
            if(this.shapeSpawnTween != 0)
            {
                    val_15 = 0;
                DG.Tweening.TweenExtensions.Kill(t:  this.shapeSpawnTween, complete:  false);
            }
            
            if(this.shapeAnimSeq != 0)
            {
                    val_15 = 0;
                DG.Tweening.TweenExtensions.Kill(t:  this.shapeAnimSeq, complete:  false);
            }
            
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            this.shapeAnimSeq = 0;
            UnityEngine.GameObject val_3 = this.gameObject;
            UnityEngine.Transform val_4 = this.transform;
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOMove(target:  1284353264, endValue:  new UnityEngine.Vector3() {x = mem[this.neutralWorldPosition + (0)], y = mem[this.neutralWorldPosition + (4)], z = mem[this.neutralWorldPosition + (8)]}, duration:  null, snapping:  false);
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  1284353264);
            UnityEngine.GameObject val_7 = this.gameObject;
            UnityEngine.Transform val_8 = this.transform;
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  1284353264, endValue:  new UnityEngine.Vector3() {x = mem[this.neutralScale + (0)], y = mem[this.neutralScale + (4)], z = mem[this.neutralScale + (8)]}, duration:  null);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.shapeAnimSeq, t:  1284353264);
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.shapeCanvas, endValue:  this.neutralAlpha = 0.3f, duration:  null);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.shapeAnimSeq, t:  this.shapeCanvas);
            DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  466665472, method:  new IntPtr(1284328240));
            object val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.shapeAnimSeq, action:  190734336);
        }
        protected void DoSimpleScale(UnityEngine.Vector3 scale, float duration)
        {
            if(this.shapeSpawnTween != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.shapeSpawnTween, complete:  false);
            }
            
            if(this.shapeAnimSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.shapeAnimSeq, complete:  false);
            }
            
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            this.shapeAnimSeq = 0;
            UnityEngine.GameObject val_3 = this.gameObject;
            UnityEngine.Transform val_4 = this.transform;
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  1284506224, endValue:  new UnityEngine.Vector3() {x = scale.x, y = scale.y, z = scale.z}, duration:  duration);
            object val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  1284506224, ease:  1);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  1284506224);
        }
        public void RotateShape(bool isClockwise = True, bool skipAnimate = False)
        {
            DG.Tweening.RotateMode val_8;
            var val_9;
            int val_10;
            val_8 = skipAnimate;
            if(isClockwise == true)
            {
                    val_9 = 1;
            }
            
            int val_1 = this.rotationHeading + 1;
            val_10 = 0;
            this.rotationHeading = val_1;
            if(val_1 > 3)
            {
                goto label_2;
            }
            
            if(val_1 <= 1)
            {
                goto label_3;
            }
            
            val_10 = val_1;
            goto label_4;
            label_3:
            val_10 = val_1 + 4;
            label_2:
            this.rotationHeading = val_10;
            label_4:
            this.SetRotation(rotationId:  val_10);
            if(val_8 == true)
            {
                    return;
            }
            
            if(this.shapeRotationSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Complete(t:  this.shapeRotationSeq);
            }
            
            val_9 = 0;
            UnityEngine.GameObject val_2 = this.gameObject;
            if(isClockwise == true)
            {
                    90f = 3266576384;
            }
            
            UnityEngine.Transform val_3 = this.transform;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  -90f, y:  null, z:  null);
            val_8 = 15820;
            val_8 = 1036831949;
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  1284630512, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  -90f, mode:  val_8);
            object val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  1284630512, ease:  1);
            this.shapeRotationSeq = this;
        }
        public void SetRotation(int rotationId)
        {
            var val_2;
            var val_3;
            var val_6;
            var val_7;
            var val_41;
            var val_43;
            BlockPuzzleMagic.ShapeBlock val_50;
            this.rotationHeading = rotationId;
            val_41 = 0;
            UnityEngine.Vector2Int val_1 = UnityEngine.Vector2Int.zero;
            UnityEngine.Vector2Int val_4 = new UnityEngine.Vector2Int(x:  99, y:  99);
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            goto label_5;
            label_36:
            if(this.blockGridCountUnrotated <= val_41)
            {
                    var val_40 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_40 = val_40 + 0;
            if(this.rotationHeading <= 3)
            {
                    var val_8 = 13644616 + (13644616 + (this.rotationHeading) << 2);
                if(this.rotationHeading == 3)
            {
                    13644616 + (this.rotationHeading) << 2 = (13644616 + (this.rotationHeading) << 2) & ((13644616 + (this.rotationHeading) << 2) << (13644616 + (this.rotationHeading) << 2));
                13644616 + (this.rotationHeading) << 2 = (13644616 + (this.rotationHeading) << 2) & ((((13644616 + (this.rotationHeading) << 2 & (13644616 + (this.rotationHeading) << 2) << 13644616 + (this.rotationHeading) << 2)) << (32-(13644616 + (this.rotationHeading) << 2 & (13644616 + (this.rotationHeading) << 2) << 13644616 + (this.rotationHeading) << 2))) | (((13644616 + (this.rotationHeading) << 2 & (13644616 + (this.rotationHeading) << 2) << 13644616 + (this.rotationHeading) << 2)) << (13644616 + (this.rotationHeading) << 2 & (13644616 + (this.rotationHeading) << 2) << 13644616 + (this.rotationHeading) << 2)));
                13644616 + (this.rotationHeading) << 2 = (13644616 + (this.rotationHeading) << 2) & 1284755016;
                13644616 + (this.rotationHeading) << 2 = (13644616 + (this.rotationHeading) << 2) & 0;
            }
            
                if(((0 + 0) + 16) != 0)
            {
                    val_43 = mem[(0 + 0) + 16 + 12];
                val_43 = (0 + 0) + 16 + 12;
                mem2[0] = (0 + 0) + 16 + 16;
            }
            else
            {
                    mem[32] = 2621443;
                val_43 = 0;
            }
            
                mem2[0] = val_43;
            }
            
            val_50 = this.<FirstBlock>k__BackingField;
            if(val_50 == 0)
            {
                goto label_22;
            }
            
            if(((0 + 0) + 16) != 0)
            {
                goto label_23;
            }
            
            val_50 = this.<FirstBlock>k__BackingField;
            if(val_50 == 0)
            {
                goto label_24;
            }
            
            label_23:
            if(((0 + 0) + 16 + 28) > (this.<FirstBlock>k__BackingField.rowIDOrientated))
            {
                goto label_25;
            }
            
            if(((0 + 0) + 16 + 32) >= (this.<FirstBlock>k__BackingField.columnIDOrientated))
            {
                goto label_28;
            }
            
            label_22:
            this.<FirstBlock>k__BackingField = (0 + 0) + 16;
            label_25:
            label_28:
            if(((0 + 0) + 16 + 20) > 0)
            {
                    val_2.x = UnityEngine.Mathf.Max(a:  val_2.x, b:  (0 + 0) + 16 + 32);
                val_2.y = UnityEngine.Mathf.Max(a:  val_2.y, b:  (0 + 0) + 16 + 28);
                val_4.m_X.x = UnityEngine.Mathf.Min(a:  val_4.m_X.x, b:  (0 + 0) + 16 + 32);
                val_4.m_X.y = UnityEngine.Mathf.Min(a:  val_4.m_X.y, b:  (0 + 0) + 16 + 28);
                UnityEngine.RectTransform val_24 = (0 + 0) + 16 + 20.rectTransform;
                UnityEngine.Rect val_25 = rect;
                UnityEngine.Vector2 val_26 = size;
            }
            
            val_41 = 1;
            label_5:
            if(val_41 < val_7)
            {
                goto label_36;
            }
            
            int val_32 = val_4.m_X.y;
            val_32 = val_2.y - val_32;
            val_3 = 0;
            val_2 = 0;
            UnityEngine.Vector2Int val_36 = new UnityEngine.Vector2Int(x:  (UnityEngine.Mathf.Abs(value:  val_2.x - val_4.m_X.x)) + 1, y:  (UnityEngine.Mathf.Abs(value:  val_32)) + 1);
            this.blockGridCount = val_36.m_X;
            mem[1152921514481548684] = val_36.m_Y;
            float val_44 = (float)this.blockGridCount.x;
            float val_45 = (float)this.blockGridCount.y;
            val_7 = 0;
            val_6 = 0;
            val_44 = val_6 * val_44;
            val_45 = val_7 * val_45;
            UnityEngine.Vector2 val_39 = new UnityEngine.Vector2(x:  val_44, y:  val_26.y);
            mem[1152921514481548804] = val_39.x;
            mem[1152921514481548808] = val_39.y;
            return;
            label_24:
        }
        protected void ToggleSortingOrder(bool bringToFront)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Transform val_2 = this.transform;
            if(bringToFront != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                this.SetParent(p:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_10);
                UnityEngine.GameObject val_4 = this.gameObject;
                UnityEngine.Transform val_5 = this.transform;
                this.SetAsLastSibling();
                return;
            }
            
            this.originalParentTransform.SetParent(p:  this.originalParentTransform);
            UnityEngine.GameObject val_6 = this.originalParentTransform.gameObject;
            UnityEngine.Transform val_7 = this.transform;
            this.SetSiblingIndex(index:  this.originalSiblingIndex);
        }
        public ShapeInfo()
        {
            UnityEngine.Vector2Int val_2;
            var val_3;
            UnityEngine.Vector2Int val_5;
            var val_6;
            UnityEngine.Vector2Int val_1 = UnityEngine.Vector2Int.zero;
            this.blockGridCount = val_2;
            mem[1152921514481801356] = val_3;
            UnityEngine.Vector2Int val_4 = UnityEngine.Vector2Int.zero;
            this.blockGridCountUnrotated = val_5;
            mem[1152921514481801364] = val_6;
            this.rotationHeadingNeededToPlace = 0;
            this.draggable = true;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            this.raycastHit = null;
            this.dragOffsetY = 0.55f;
        }
    
    }

}
