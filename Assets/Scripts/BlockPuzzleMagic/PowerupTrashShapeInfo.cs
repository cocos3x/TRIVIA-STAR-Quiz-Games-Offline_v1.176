using UnityEngine;

namespace BlockPuzzleMagic
{
    public class PowerupTrashShapeInfo : ShapeInfo
    {
        // Fields
        public const int SHAPE_ID = -102;
        protected BlockPuzzleMagic.BlockSpawnerNode highlightedSpawnerNode;
        private DG.Tweening.Sequence activeHoverSeq;
        
        // Methods
        protected override void Awake()
        {
            mem[1152921514474699132] = 101;
            this.Awake();
        }
        public override void Init(UnityEngine.Transform parent, UnityEngine.Vector3 worldPos, float scale, float alpha, string source)
        {
            BlockPuzzleMagic.GameReferenceData val_1 = BlockPuzzleMagic.GameReferenceData.Instance;
            BlockPuzzleMagic.BlockColor val_4 = this.GetBlockColor(colorType:  0);
        }
        public override void Init(BlockPuzzleMagic.BlockColor color, UnityEngine.Transform parent, UnityEngine.Vector3 worldPos, float scale, float alpha, string source)
        {
            BlockPuzzleMagic.GameReferenceData val_1 = BlockPuzzleMagic.GameReferenceData.Instance;
            BlockPuzzleMagic.BlockColor val_4 = this.GetBlockColor(colorType:  0);
            this.Init(color:  1278170224, parent:  parent, worldPos:  new UnityEngine.Vector3() {x = worldPos.x, y = worldPos.y, z = worldPos.z}, scale:  scale, alpha:  alpha, source:  source);
        }
        public override void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnDrag(eventData:  eventData);
            if(this == 0)
            {
                    return;
            }
            
            this.SearchForShapeInfo();
        }
        public override bool CanResolveAction()
        {
            if(this.highlightedSpawnerNode == 0)
            {
                    return false;
            }
            
            if(this.highlightedSpawnerNode.ContainsShape() == false)
            {
                    return false;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            return (bool)CanUsePowerup(powerupType:  0, showStoreIfOOC:  false, oocDelay:  null);
        }
        public override void SnapBackAndReset(System.Action onComplete)
        {
            this.SnapBackAndReset(onComplete:  onComplete);
            if(this.highlightedSpawnerNode == 0)
            {
                    return;
            }
            
            if(this.highlightedSpawnerNode.ContainsShape() == false)
            {
                    return;
            }
            
            BlockPuzzleMagic.ShapeInfo val_3 = this.highlightedSpawnerNode.GetShape();
            this.SetUsableShapeHighlight(shape:  this.highlightedSpawnerNode, highlight:  false);
        }
        public override void ResolveAction()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UsePowerup(powerupType:  0, freeUsage:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DestroyShape(containerIndex:  this.highlightedSpawnerNode.spawnerId);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            FillShapeContainer(skipAutosave:  true);
        }
        private void SearchForShapeInfo()
        {
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            BlockPuzzleMagic.BlockSpawnerNode val_25;
            var val_26;
            BlockPuzzleMagic.BlockSpawnerNode val_27;
            var val_28;
            var val_29;
            UnityEngine.Object val_30;
            BlockPuzzleMagic.BlockSpawnerNode val_31;
            val_25 = 0;
            val_26 = 0;
            val_27 = 0;
            goto label_1;
            label_27:
            if((R6 + 12) <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_27 = R6 + 8;
            val_27 = val_27 + 0;
            UnityEngine.Vector3 val_1 = position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 4.855075E+07f});
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            int val_8 = UnityEngine.Physics2D.RaycastNonAlloc(origin:  new UnityEngine.Vector2() {x = val_6, y = val_7}, direction:  new UnityEngine.Vector2() {x = val_4, y = val_5}, results:  (R6 + 8 + 0) + 16 + 8, distance:  val_3.x);
            if(val_8 < 1)
            {
                goto label_10;
            }
            
            val_28 = 0;
            val_29 = 16;
            val_30 = val_27;
            label_24:
            UnityEngine.Object val_9 = 1065353216 + val_29;
            UnityEngine.Collider2D val_10 = val_9.collider;
            UnityEngine.GameObject val_11 = val_9.gameObject;
            UnityEngine.GameObject val_12 = this.gameObject;
            if(val_9 == 1278829552)
            {
                goto label_16;
            }
            
            UnityEngine.Object val_14 = val_30 + val_29;
            UnityEngine.Collider2D val_15 = val_14.collider;
            UnityEngine.GameObject val_16 = val_14.gameObject;
            object val_17 = val_14.GetComponentInChildren<System.Object>();
            val_30 = val_14;
            if(val_30 != 0)
            {
                goto label_25;
            }
            
            label_16:
            val_28 = val_28 + 1;
            val_29 = val_29 + 36;
            if(val_28 < val_8)
            {
                goto label_24;
            }
            
            goto label_25;
            label_10:
            val_30 = val_27;
            label_25:
            val_27 = val_30;
            val_25 = 0;
            val_26 = 1;
            label_1:
            if(val_26 < mem[1065353228])
            {
                goto label_27;
            }
            
            if(0 != 0)
            {
                    if(this.highlightedSpawnerNode != 0)
            {
                    val_25 = this.highlightedSpawnerNode;
                val_31 = 0;
                if(0 == this.highlightedSpawnerNode.spawnerId)
            {
                    return;
            }
            
            }
            
            }
            
            val_31 = this.highlightedSpawnerNode;
            if(val_31 != 0)
            {
                    val_31 = this.highlightedSpawnerNode;
                if(val_31.ContainsShape() != false)
            {
                    val_31 = this.highlightedSpawnerNode;
                BlockPuzzleMagic.ShapeInfo val_23 = val_31.GetShape();
                this.SetUsableShapeHighlight(shape:  val_31, highlight:  false);
            }
            
            }
            
            if(0 != 0)
            {
                    if(val_27.ContainsShape() != false)
            {
                    BlockPuzzleMagic.ShapeInfo val_26 = val_27.GetShape();
                this.SetUsableShapeHighlight(shape:  0, highlight:  true);
            }
            
            }
            
            this.highlightedSpawnerNode = val_27;
        }
        private void SetUsableShapeHighlight(BlockPuzzleMagic.ShapeInfo shape, bool highlight)
        {
            if(highlight != false)
            {
                    UnityEngine.Transform val_1 = shape.transform;
                UnityEngine.Vector3 val_2 = position;
                UnityEngine.Transform val_3 = shape.transform;
                UnityEngine.Vector3 val_4 = localScale;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 4.909701E+07f}, d:  val_4.x);
                this.ToggleSortingOrder(bringToFront:  true);
            }
        
        }
        public PowerupTrashShapeInfo()
        {
        
        }
    
    }

}
