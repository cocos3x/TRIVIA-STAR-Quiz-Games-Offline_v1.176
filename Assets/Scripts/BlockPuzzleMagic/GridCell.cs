using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GridCell : MonoBehaviour
    {
        // Fields
        public int rowId;
        public int columnId;
        private int <cellId>k__BackingField;
        private bool <isOn>k__BackingField;
        public bool isInteractable;
        private BlockPuzzleMagic.Block <ChildBlock>k__BackingField;
        private BlockPuzzleMagic.GridCellData <cellData>k__BackingField;
        private BlockPuzzleMagic.BlockData <blockData>k__BackingField;
        private UnityEngine.CanvasGroup cellCanvasGroup;
        private UnityEngine.UI.Image backgroundImage;
        private UnityEngine.RectTransform blockContainer;
        private UnityEngine.RectTransform cellOverlayContainer;
        private UnityEngine.UI.Image overlayImage;
        private UnityEngine.UI.Image highlightImage;
        private UnityEngine.BoxCollider2D blockCollider;
        private UnityEngine.Sprite dotSprite;
        private UnityEngine.Color dotUnfilledColor;
        private UnityEngine.Color dotFilledPlainColor;
        private UnityEngine.Color dotFilledSpecialColor;
        private UnityEngine.GameObject loopPrefabStraight;
        private UnityEngine.GameObject loopPrefabCorner;
        private UnityEngine.Color bgColor;
        private DG.Tweening.Sequence highlightSeq;
        private DG.Tweening.Sequence blockSeq;
        private UnityEngine.GameObject loopPathObject;
        
        // Properties
        public int cellId { get; set; }
        public bool isOn { get; set; }
        public bool isFilled { get; }
        public bool CanBeFilled { get; }
        public bool hasDot { get; }
        public bool hasLoop { get; }
        public BlockPuzzleMagic.Block ChildBlock { get; set; }
        public BlockPuzzleMagic.GridCellData cellData { get; set; }
        public BlockPuzzleMagic.BlockData blockData { get; set; }
        public UnityEngine.CanvasGroup CellCanvasGroup { get; }
        public UnityEngine.UI.Image BackgroundImage { get; }
        public UnityEngine.UI.Image OverlayImage { get; }
        
        // Methods
        public int get_cellId()
        {
            return (int)this.<cellId>k__BackingField;
        }
        private void set_cellId(int value)
        {
            this.<cellId>k__BackingField = value;
        }
        public bool get_isOn()
        {
            return (bool)this.<isOn>k__BackingField;
        }
        private void set_isOn(bool value)
        {
            this.<isOn>k__BackingField = value;
        }
        public bool get_isFilled()
        {
            return UnityEngine.Object.op_Inequality(x:  this.<ChildBlock>k__BackingField, y:  0);
        }
        public bool get_CanBeFilled()
        {
            if((this.<isOn>k__BackingField) == false)
            {
                    return true;
            }
            
            if(this.isFilled == true)
            {
                    return true;
            }
            
            if(this.isInteractable == true)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool get_hasDot()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            return public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 20.IsFlagSetOnGridDataNode(_gridDataIndex:  this.<cellId>k__BackingField, _nodeType:  2);
        }
        public bool get_hasLoop()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            return public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 20.IsFlagSetOnGridDataNode(_gridDataIndex:  this.<cellId>k__BackingField, _nodeType:  64);
        }
        public BlockPuzzleMagic.Block get_ChildBlock()
        {
        
        }
        private void set_ChildBlock(BlockPuzzleMagic.Block value)
        {
            this.<ChildBlock>k__BackingField = value;
        }
        public BlockPuzzleMagic.GridCellData get_cellData()
        {
        
        }
        private void set_cellData(BlockPuzzleMagic.GridCellData value)
        {
            this.<cellData>k__BackingField = value;
        }
        public BlockPuzzleMagic.BlockData get_blockData()
        {
        
        }
        private void set_blockData(BlockPuzzleMagic.BlockData value)
        {
            this.<blockData>k__BackingField = value;
        }
        public UnityEngine.CanvasGroup get_CellCanvasGroup()
        {
        
        }
        public UnityEngine.UI.Image get_BackgroundImage()
        {
        
        }
        public UnityEngine.UI.Image get_OverlayImage()
        {
        
        }
        public void Initialize(int _cellId, int _rowId, int _colId, bool _isOn, UnityEngine.Color _bgColor, ref BlockPuzzleMagic.GridCellData _cellData, ref BlockPuzzleMagic.BlockData _blockData)
        {
            this.rowId = _rowId;
            this.columnId = _colId;
            this.<cellId>k__BackingField = _cellId;
            this.<isOn>k__BackingField = _isOn;
            this.bgColor = _bgColor;
            mem[1152921514454245876] = _bgColor.g;
            mem[1152921514454245880] = _bgColor.b;
            mem[1152921514454245884] = _bgColor.a;
            this.<cellData>k__BackingField = _cellData;
            this.<blockData>k__BackingField = _blockData;
            this.RefreshVisualState();
        }
        public void RefreshVisualState()
        {
            UnityEngine.Color val_8;
            bool val_11;
            var val_12;
            UnityEngine.UI.Image val_13;
            UnityEngine.GameObject val_1 = this.gameObject;
            if((this.<isOn>k__BackingField) == true)
            {
                    this.<isOn>k__BackingField = 1;
            }
            
            this.SetActive(value:  true);
            val_8 = this.bgColor;
            this.backgroundImage.color = new UnityEngine.Color() {r = val_8, g = SL, b = R8, a = 1.401298E-45f};
            if((this.<isOn>k__BackingField) == false)
            {
                    return;
            }
            
            val_11 = this.hasDot;
            if(this.hasDot == true)
            {
                    0 = this.dotSprite;
            }
            
            bool val_4 = this.hasLoop;
            if(val_4 == true)
            {
                    val_4 = this;
                this.RefreshLoopPathDisplay();
            }
            
            UnityEngine.GameObject val_5 = this.overlayImage.gameObject;
            val_12 = this.overlayImage;
            val_12.SetActive(value:  val_11);
            if(val_11 == false)
            {
                goto label_5;
            }
            
            this.overlayImage.sprite = 0;
            if(this.isFilled == false)
            {
                goto label_7;
            }
            
            val_13 = this.overlayImage;
            if((this.<ChildBlock>k__BackingField.<blockType>k__BackingField) != 4)
            {
                goto label_9;
            }
            
            val_8 = this.dotFilledSpecialColor;
            goto label_11;
            label_7:
            val_13 = this.overlayImage;
            val_8 = this.dotUnfilledColor;
            goto label_11;
            label_9:
            val_8 = this.dotFilledPlainColor;
            label_11:
            val_13.color = new UnityEngine.Color() {r = val_8, g = SL, b = R8, a = this.<ChildBlock>k__BackingField};
            label_5:
            if(this.isFilled == false)
            {
                    return;
            }
            
            this.<ChildBlock>k__BackingField.RefreshVisualState();
        }
        private void OnRectTransformDimensionsChange()
        {
            var val_5;
            UnityEngine.GameObject val_1 = this.gameObject;
            val_5 = 0;
            UnityEngine.Transform val_2 = this.transform;
            if(this != 0)
            {
                    if(null == null)
            {
                goto label_3;
            }
            
            }
            
            if(this != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            label_4:
            if(null != null)
            {
                    val_5 = 0;
            }
            else
            {
                    val_5 = this;
            }
            
            label_7:
            UnityEngine.Rect val_3 = rect;
            UnityEngine.Vector2 val_4 = size;
            this.blockCollider.size = new UnityEngine.Vector2();
        }
        public void AddBlockColorFill(BlockPuzzleMagic.BlockColorType blockColor)
        {
            BlockPuzzleMagic.Block val_1 = BlockPuzzleMagic.Block.CreateColorFillBlock(_colorType:  blockColor);
            this.<blockData>k__BackingField.fillColorType = blockColor;
            this.LinkCellWithBlock(someblock:  blockColor, recenterBlock:  true);
            this.RefreshVisualState();
            this.StopHighlighting();
        }
        public void AddBlockStone()
        {
            int val_2;
            BlockPuzzleMagic.Block val_1 = BlockPuzzleMagic.Block.CreateStoneBlock();
            if((this.<blockData>k__BackingField.breaksRequired) >= 1)
            {
                    val_2 = this.<blockData>k__BackingField.breaksRequired;
            }
            else
            {
                    val_2 = 2;
            }
            
            this.<blockData>k__BackingField.breaksRequired = val_2;
            this.<blockData>k__BackingField.fillColorType = 0;
            this.LinkCellWithBlock(someblock:  463310848, recenterBlock:  true);
            this.RefreshVisualState();
            this.StopHighlighting();
        }
        public void LinkCellWithBlock(BlockPuzzleMagic.Block someblock, bool recenterBlock = False)
        {
            float val_14;
            float val_15;
            UnityEngine.RectTransform val_16;
            BlockPuzzleMagic.Block val_17;
            var val_18;
            this.<ChildBlock>k__BackingField = someblock;
            UnityEngine.GameObject val_1 = someblock.gameObject;
            UnityEngine.GameObject val_2 = someblock.gameObject;
            UnityEngine.Transform val_3 = someblock.transform;
            val_16 = this.blockContainer;
            someblock.SetParent(p:  val_16);
            val_17 = this.<ChildBlock>k__BackingField;
            this.<ChildBlock>k__BackingField.<ParentCell>k__BackingField = this;
            if(recenterBlock == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = this.<ChildBlock>k__BackingField.gameObject;
            UnityEngine.Transform val_5 = this.<ChildBlock>k__BackingField.transform;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            this.<ChildBlock>k__BackingField.localScale = new UnityEngine.Vector3();
            UnityEngine.GameObject val_7 = this.<ChildBlock>k__BackingField.gameObject;
            UnityEngine.Transform val_8 = this.<ChildBlock>k__BackingField.transform;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.<ChildBlock>k__BackingField.localPosition = new UnityEngine.Vector3();
            UnityEngine.GameObject val_10 = this.<ChildBlock>k__BackingField.gameObject;
            val_17 = 0;
            UnityEngine.Transform val_11 = this.<ChildBlock>k__BackingField.transform;
            UnityEngine.Transform val_12 = val_16.transform;
            val_16 = 1152921504767283200;
            if(this != 0)
            {
                    if(null == null)
            {
                goto label_18;
            }
            
            }
            
            if(this != 0)
            {
                    label_18:
                if(null != null)
            {
                    val_17 = 0;
            }
            else
            {
                    val_17 = this;
            }
            
            }
            
            val_18 = 0;
            UnityEngine.Vector2 val_13 = sizeDelta;
            if((this.<ChildBlock>k__BackingField) != 0)
            {
                    if(null != null)
            {
                    val_18 = 0;
            }
            else
            {
                    val_18 = this.<ChildBlock>k__BackingField;
            }
            
            }
            
            val_18.sizeDelta = new UnityEngine.Vector2() {x = val_14, y = val_15};
        }
        public void ClearCell(bool doAnimation = True, float animationDelay = 0, bool ignoreBreaksRequired = False)
        {
            var val_29;
            float val_30;
            var val_31;
            BlockPuzzleMagic.Block val_32;
            BlockPuzzleMagic.BlockData val_33;
            int val_34;
            var val_35;
            var val_36;
            object val_37;
            val_29 = ignoreBreaksRequired;
            val_30 = doAnimation;
            this.RemoveAttributeDot();
            val_31 = 1;
            if(this.isFilled != false)
            {
                    if((this.<blockData>k__BackingField.breaksRequired) < 2)
            {
                    val_31 = 1;
            }
            
            }
            
            if((this.<blockData>k__BackingField.breaksRequired) == 2)
            {
                goto label_3;
            }
            
            if(new System.Object() == 0)
            {
                goto label_4;
            }
            
            typeof(GridCell.<>c__DisplayClass60_0).__il2cppRuntimeField_C = this;
            val_32 = this.<ChildBlock>k__BackingField;
            goto label_5;
            label_3:
            val_33 = this.<blockData>k__BackingField;
            if(val_33 == 0)
            {
                goto label_6;
            }
            
            val_32 = val_33;
            val_34 = this.<blockData>k__BackingField.breaksRequired;
            goto label_7;
            label_4:
            mem[12] = this;
            val_32 = this.<ChildBlock>k__BackingField;
            label_5:
            typeof(GridCell.<>c__DisplayClass60_0).__il2cppRuntimeField_8 = val_32;
            this.EmptyCell();
            if(val_30 == false)
            {
                goto label_8;
            }
            
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            this.blockSeq = 0;
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  animationDelay);
            val_30 = 1152921504797581312;
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  1258393168, method:  new IntPtr(1258321040));
            DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.blockSeq, callback:  190734336);
            val_29 = 16051;
            val_29 = 1051931443;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundImage, endValue:  animationDelay, duration:  null);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.backgroundImage, delay:  animationDelay);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.blockSeq, t:  this.backgroundImage);
            if((typeof(GridCell.<>c__DisplayClass60_0).__il2cppRuntimeField_8) != 0)
            {
                    DG.Tweening.Sequence val_11 = typeof(GridCell.<>c__DisplayClass60_0).__il2cppRuntimeField_8.ClearBlock(isLastBlockBreak:  true, animationDelay:  animationDelay);
                DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.blockSeq, t:  typeof(GridCell.<>c__DisplayClass60_0).__il2cppRuntimeField_8);
            }
            
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.overlayImage, endValue:  animationDelay, duration:  null);
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.blockSeq, t:  this.overlayImage);
            UnityEngine.Transform val_15 = this.overlayImage.transform;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.overlayImage, endValue:  new UnityEngine.Vector3(), duration:  val_16.x);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.blockSeq, t:  this.overlayImage);
            val_32 = this.blockSeq;
            val_33 = null;
            val_33 = new DG.Tweening.TweenCallback(object:  464855040, method:  new IntPtr(1258354832));
            val_35 = val_33;
            val_36 = public static DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::OnComplete<DG.Tweening.Sequence>(DG.Tweening.Sequence t, DG.Tweening.TweenCallback action);
            val_37 = val_32;
            goto label_18;
            label_8:
            UnityEngine.GameObject val_20 = typeof(GridCell.<>c__DisplayClass60_0).__il2cppRuntimeField_8.gameObject;
            UnityEngine.Object.Destroy(obj:  typeof(GridCell.<>c__DisplayClass60_0).__il2cppRuntimeField_8);
            goto label_27;
            label_6:
            val_32 = 12;
            val_34 = mem[12];
            label_7:
            mem[12] = 1152921514455174735;
            mem[12] = UnityEngine.Mathf.Max(a:  1258393167, b:  0);
            if((val_30 == false) || (this.isFilled == false))
            {
                goto label_27;
            }
            
            DG.Tweening.Sequence val_23 = DG.Tweening.DOTween.Sequence();
            this.blockSeq = 0;
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  animationDelay);
            DG.Tweening.Sequence val_25 = this.<ChildBlock>k__BackingField.ClearBlock(isLastBlockBreak:  false, animationDelay:  animationDelay);
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.blockSeq, t:  this.<ChildBlock>k__BackingField);
            val_32 = null;
            val_32 = new DG.Tweening.TweenCallback(object:  1258393168, method:  new IntPtr(1258368144));
            val_35 = val_32;
            val_36 = public static DG.Tweening.Sequence DG.Tweening.TweenSettingsExtensions::OnComplete<DG.Tweening.Sequence>(DG.Tweening.Sequence t, DG.Tweening.TweenCallback action);
            val_37 = this.blockSeq;
            label_18:
            object val_28 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_37, action:  190734336);
            goto label_31;
            label_27:
            this.RefreshVisualState();
            label_31:
            this.StopHighlighting();
        }
        public void EmptyCell()
        {
            var val_3;
            var val_4;
            var val_5;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_3 = 0;
            goto label_4;
            label_14:
            val_4 = null;
            val_4 = null;
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 20.RemoveFlagFromGridDataNode(_gridDataIndex:  this.<cellId>k__BackingField, _nodeType:  BlockPuzzleMagic.Block.BLOCK_TYPES + 12 + 16);
            val_3 = 1;
            label_4:
            val_5 = null;
            val_5 = null;
            if(val_3 < (BlockPuzzleMagic.Block.BLOCK_TYPES + 12))
            {
                goto label_14;
            }
            
            this.RemoveAttributeDot();
            this.<blockData>k__BackingField.fillColorType = 0;
            this.<blockData>k__BackingField.breaksRequired = 0;
            if((this.<ChildBlock>k__BackingField) == 0)
            {
                    return;
            }
            
            this.<ChildBlock>k__BackingField.<ParentCell>k__BackingField = 0;
            this.<ChildBlock>k__BackingField = 0;
        }
        private void RemoveAttributeDot()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 20.RemoveFlagFromGridDataNode(_gridDataIndex:  this.<cellId>k__BackingField, _nodeType:  2);
        }
        public void SetHighlight(BlockPuzzleMagic.BlockColor _colorData)
        {
            UnityEngine.Color val_2;
            float val_3;
            if(this.highlightSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.highlightSeq, complete:  false);
            }
            
            if(_colorData != 0)
            {
                    val_2 = _colorData.colorValue;
            }
            else
            {
                    val_2 = 0f;
                val_3 = 3.673424E-39f;
            }
            
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            this.highlightImage.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        }
        public void StopHighlighting()
        {
            if(this.highlightSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.highlightSeq, complete:  false);
            }
            
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.highlightSeq = 0;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.highlightImage, endValue:  null, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.highlightImage, ease:  1);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.highlightImage);
        }
        public void PlayInitialAnimation(float animationDelay = 0)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.blockSeq = 0;
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  animationDelay);
            UnityEngine.Color val_3 = new UnityEngine.Color(r:  animationDelay, g:  null, b:  null, a:  null);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.highlightImage, endValue:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.r}, duration:  animationDelay);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.blockSeq, t:  this.highlightImage);
            UnityEngine.Color val_6 = new UnityEngine.Color(r:  animationDelay, g:  null, b:  null, a:  null);
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOColor(target:  this.highlightImage, endValue:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.r}, duration:  animationDelay);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.blockSeq, t:  this.highlightImage);
            DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  1259112912, method:  new IntPtr(1258368144));
            object val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.blockSeq, action:  190734336);
        }
        public void PlayLevelClearAnimation(float animationDelay = 0)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.blockSeq = 0;
            DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  animationDelay);
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundImage, endValue:  animationDelay, duration:  null);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.blockSeq, t:  this.backgroundImage);
            if(this.isFilled != false)
            {
                    DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<ChildBlock>k__BackingField.blockCanvasGroup, endValue:  animationDelay, duration:  null);
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.blockSeq, t:  this.<ChildBlock>k__BackingField.blockCanvasGroup);
                UnityEngine.Transform val_8 = this.<ChildBlock>k__BackingField.transform;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
                DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<ChildBlock>k__BackingField, endValue:  new UnityEngine.Vector3(), duration:  val_9.x);
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.blockSeq, t:  this.<ChildBlock>k__BackingField);
            }
            
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.overlayImage, endValue:  val_9.x, duration:  val_9.y);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.blockSeq, t:  this.overlayImage);
            UnityEngine.Transform val_14 = this.overlayImage.transform;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.overlayImage, endValue:  new UnityEngine.Vector3(), duration:  val_15.x);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.blockSeq, t:  this.overlayImage);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.blockSeq, interval:  val_15.x);
            DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundImage, endValue:  val_15.x, duration:  val_15.y);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.blockSeq, t:  this.backgroundImage);
            DG.Tweening.TweenCallback val_21 = new DG.Tweening.TweenCallback(object:  1259307856, method:  new IntPtr(1259282832));
            object val_22 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.blockSeq, action:  190734336);
        }
        private void RefreshLoopPathDisplay()
        {
            float val_13;
            float val_14;
            float val_29;
            float val_30;
            System.Predicate<ZooTile> val_35;
            float val_36;
            UnityEngine.GameObject val_37;
            UnityEngine.GameObject val_38;
            var val_40;
            var val_42;
            if((this.<cellData>k__BackingField) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_35 = null;
            val_35 = new System.Predicate<ZooTile>(object:  1259519184, method:  new IntPtr(1259461392));
            object val_3 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C.Find(match:  8040448);
            val_36 = 1152921504765685760;
            if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C) == 0)
            {
                    return;
            }
            
            Direction val_5 = BlockPuzzleMagic.GridLayout.GetDirectionBetweenCells(originCellId:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 20, nextCellId:  this.<cellId>k__BackingField);
            Direction val_6 = BlockPuzzleMagic.GridLayout.GetDirectionBetweenCells(originCellId:  this.<cellId>k__BackingField, nextCellId:  this.<cellData>k__BackingField.loopNextCell);
            val_37 = this.loopPathObject;
            if(val_37 == 0)
            {
                    val_37 = this.loopPrefabStraight;
                object val_9 = UnityEngine.Object.Instantiate<System.Object>(original:  val_37, parent:  this.cellOverlayContainer);
                val_38 = val_37;
                this.loopPathObject = val_37;
            }
            else
            {
                    val_38 = this.loopPathObject;
            }
            
            UnityEngine.Transform val_25 = val_38.transform;
            if(val_38 == 0)
            {
                goto label_38;
            }
            
            val_40 = val_38;
            if(null == null)
            {
                goto label_39;
            }
            
            label_38:
            val_40 = 0;
            label_39:
            val_14 = 0;
            val_13 = 0;
            UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  null, y:  null);
            val_40.anchorMin = new UnityEngine.Vector2() {x = val_26.x, y = val_26.y};
            UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  null, y:  null);
            val_40.anchorMax = new UnityEngine.Vector2() {x = val_27.x, y = val_27.y};
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.zero;
            val_35 = val_29;
            if(val_40 != 0)
            {
                    val_40.offsetMax = new UnityEngine.Vector2() {x = val_35, y = val_30};
                val_40.offsetMin = new UnityEngine.Vector2() {x = val_35, y = val_30};
            }
            else
            {
                    val_40.offsetMax = new UnityEngine.Vector2() {x = val_35, y = val_30};
                val_40.offsetMin = new UnityEngine.Vector2() {x = val_35, y = val_30};
            }
            
            val_42 = 1;
            val_40.SetSizeWithCurrentAnchors(axis:  0, size:  val_33.x);
        }
        public GridCell()
        {
            this.isInteractable = true;
        }
        private void <ClearCell>b__60_0()
        {
            float val_2;
            float val_3;
            float val_4;
            UnityEngine.Color val_1 = color;
            this.backgroundImage.color = new UnityEngine.Color() {r = val_2, g = val_3, b = val_4, a = 0f};
        }
        private void <PlayLevelClearAnimation>b__66_0()
        {
            this.EmptyCell();
            this.RefreshVisualState();
        }
        private bool <RefreshLoopPathDisplay>b__67_0(BlockPuzzleMagic.GridCell c)
        {
            if(c.hasLoop == false)
            {
                    return (bool)0;
            }
            
            if((c.<cellData>k__BackingField) != 0)
            {
                    c = this.<cellId>k__BackingField;
                c.<cellData>k__BackingField = c.<cellData>k__BackingField.loopNextCell;
                c.<cellData>k__BackingField = (c.<cellData>k__BackingField) - c;
            }
            
            if((c.<cellData>k__BackingField) != 0)
            {
                    0 = (c.<cellData>k__BackingField) >> 5;
            }
            
            return (bool)0;
        }
    
    }

}
