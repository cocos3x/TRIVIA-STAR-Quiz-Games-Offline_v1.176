using UnityEngine;

namespace BlockPuzzleMagic
{
    public class Block : MonoBehaviour
    {
        // Fields
        public const int STONE_BLOCK_BREAK_LIMIT = 2;
        public static readonly BlockPuzzleMagic.GridLayout.NodeType[] BLOCK_TYPES;
        private BlockPuzzleMagic.GridLayout.NodeType <blockType>k__BackingField;
        private BlockPuzzleMagic.GridCell <ParentCell>k__BackingField;
        private UnityEngine.CanvasGroup blockCanvasGroup;
        public UnityEngine.UI.Image blockImage;
        private UnityEngine.ParticleSystem particleStoneChipped;
        private UnityEngine.Sprite normalBlockSprite;
        private UnityEngine.Sprite stoneBlockSprite;
        private System.Collections.Generic.List<UnityEngine.Sprite> crackedStoneBlockSprite;
        private UnityEngine.Sprite rainbowBlockSprite;
        private DG.Tweening.Sequence blockSeq;
        private UnityEngine.Sprite activeCrackedStoneSprite;
        private UnityEngine.ParticleSystem particleStoneChippedInstance;
        
        // Properties
        public BlockPuzzleMagic.GridLayout.NodeType blockType { get; set; }
        public BlockPuzzleMagic.BlockColorType fillColorType { get; }
        public int breaksRequired { get; }
        public bool hasStone { get; }
        public BlockPuzzleMagic.GridCell ParentCell { get; set; }
        public UnityEngine.CanvasGroup BlockCanvasGroup { get; }
        
        // Methods
        public static bool IsNodeTypeValidAsBlock(BlockPuzzleMagic.GridLayout.NodeType nodeType)
        {
            var val_1;
            var val_2;
            var val_1 = 0;
            do
            {
                val_1 = null;
                val_1 = null;
                if(val_1 >= (BlockPuzzleMagic.Block.BLOCK_TYPES + 12))
            {
                    return false;
            }
            
                val_2 = null;
                val_2 = null;
                val_1 = val_1 + 1;
            }
            while((BlockPuzzleMagic.Block.BLOCK_TYPES + 12 + 16) != nodeType);
            
            return true;
        }
        public BlockPuzzleMagic.GridLayout.NodeType get_blockType()
        {
        
        }
        private void set_blockType(BlockPuzzleMagic.GridLayout.NodeType value)
        {
            this.<blockType>k__BackingField = value;
        }
        public BlockPuzzleMagic.BlockColorType get_fillColorType()
        {
            if((this.<ParentCell>k__BackingField.<blockData>k__BackingField) != 0)
            {
                    return;
            }
        
        }
        public int get_breaksRequired()
        {
            if((this.<ParentCell>k__BackingField.<blockData>k__BackingField) != 0)
            {
                    return (int)this.<ParentCell>k__BackingField.<blockData>k__BackingField.breaksRequired;
            }
            
            return (int)this.<ParentCell>k__BackingField.<blockData>k__BackingField.breaksRequired;
        }
        public bool get_hasStone()
        {
            NodeType val_1 = this.<blockType>k__BackingField;
            val_1 = val_1 - 4;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public BlockPuzzleMagic.GridCell get_ParentCell()
        {
        
        }
        public void set_ParentCell(BlockPuzzleMagic.GridCell value)
        {
            this.<ParentCell>k__BackingField = value;
        }
        public UnityEngine.CanvasGroup get_BlockCanvasGroup()
        {
        
        }
        private static BlockPuzzleMagic.Block CreateBlock(BlockPuzzleMagic.GridLayout.NodeType blockType)
        {
            bool val_10 = static_value_021FD2D2;
            if(val_10 != true)
            {
                    val_10 = true;
            }
            
            BlockPuzzleMagic.GameReferenceData val_1 = BlockPuzzleMagic.GameReferenceData.Instance;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  139124);
            object val_3 = 139124.GetComponent<System.Object>();
            UnityEngine.Transform val_4 = 139124.transform;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            139124.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_6 = 139124.transform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            139124.localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_8 = 139124.transform;
            139124.SetAsLastSibling();
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_9 = 1230744800 + 465174528;
            139124.name = 1230744800;
        }
        public static BlockPuzzleMagic.Block CreateColorFillBlock(BlockPuzzleMagic.BlockColorType _colorType)
        {
            BlockPuzzleMagic.Block val_1 = BlockPuzzleMagic.Block.CreateBlock(blockType:  1);
            BlockPuzzleMagic.GameReferenceData val_2 = BlockPuzzleMagic.GameReferenceData.Instance;
            BlockPuzzleMagic.BlockColor val_3 = 1.GetBlockColor(colorType:  _colorType);
            if(_colorType == 1)
            {
                    32 = 44;
            }
            
            872415232.sprite = 486549504;
            if(872415232 != 0)
            {
                    return;
            }
        
        }
        public static BlockPuzzleMagic.Block CreateStoneBlock()
        {
            var val_9;
            var val_10;
            var val_11;
            BlockPuzzleMagic.Block val_1 = BlockPuzzleMagic.Block.CreateBlock(blockType:  4);
            if(4 != 0)
            {
                    val_9 = 4;
                val_10 = 52;
            }
            else
            {
                    val_9 = 24;
                val_10 = 0;
            }
            
            val_10.sprite = 2097204;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            if(52 != 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_4 = 4.transform;
            object val_5 = UnityEngine.Object.Instantiate<System.Object>(original:  35615780, parent:  4);
            mem[60] = 35615780;
            UnityEngine.GameObject val_6 = 35615780.gameObject;
            UnityEngine.Transform val_7 = 35615780.transform;
            val_11 = 0;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            35615780.localPosition = new UnityEngine.Vector3();
        }
        public void RefreshVisualState()
        {
            UnityEngine.Sprite val_8;
            var val_9;
            var val_10;
            UnityEngine.GameObject val_1 = this.blockImage.gameObject;
            UnityEngine.Transform val_2 = this.blockImage.transform;
            val_8 = 0;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.blockImage.localScale = new UnityEngine.Vector3();
            if((this.<blockType>k__BackingField) != 4)
            {
                    return;
            }
            
            if(this.breaksRequired > 1)
            {
                    return;
            }
            
            if(this.activeCrackedStoneSprite != 0)
            {
                    return;
            }
            
            if(this.crackedStoneBlockSprite != 0)
            {
                    val_9 = this.crackedStoneBlockSprite;
                val_10 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            else
            {
                    val_9 = 12;
                val_10 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            if(val_9 <= val_10)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (val_10 << 2);
            val_8 = mem[(0 + (val_7) << 2) + 16];
            val_8 = (0 + (val_7) << 2) + 16;
            this.activeCrackedStoneSprite = val_8;
            this.blockImage.sprite = val_8;
        }
        public DG.Tweening.Sequence ClearBlock(bool isLastBlockBreak, float animationDelay = 0)
        {
            UnityEngine.UI.Image val_13;
            DG.Tweening.Sequence val_14;
            if((this.<blockType>k__BackingField) == 4)
            {
                    if(this.particleStoneChippedInstance != 0)
            {
                    this.particleStoneChippedInstance.Play();
            }
            
            }
            
            if(this.blockSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.blockSeq, complete:  false);
            }
            
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            this.blockSeq = 0;
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  animationDelay);
            val_13 = this.blockImage;
            val_14 = this.blockSeq;
            if(isLastBlockBreak != false)
            {
                    DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_13, endValue:  animationDelay, duration:  null);
                DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_14, t:  val_13);
                val_13 = 0;
                UnityEngine.Transform val_6 = this.blockImage.transform;
                val_14 = this.blockImage;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
                DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_14, endValue:  new UnityEngine.Vector3(), duration:  val_7.x);
                DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.blockSeq, t:  val_14);
                return;
            }
            
            UnityEngine.Transform val_10 = val_13.transform;
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  val_13, duration:  animationDelay, strength:  null, vibrato:  1050253722, randomness:  null, snapping:  false, fadeOut:  true);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_14, t:  val_13);
        }
        public Block()
        {
        
        }
        private static Block()
        {
            BlockPuzzleMagic.Block.BLOCK_TYPES = null;
        }
    
    }

}
