using UnityEngine;

namespace BlockPuzzleMagic
{
    public class PowerupFillShapeInfo : GridPlaceableShapeInfo
    {
        // Fields
        public const int SHAPE_ID = -101;
        
        // Methods
        protected override void Awake()
        {
            mem[1152921514473633788] = 100;
            this.Awake();
        }
        public override void Init(UnityEngine.Transform parent, UnityEngine.Vector3 worldPos, float scale, float alpha, string source)
        {
            BlockPuzzleMagic.GameReferenceData val_1 = BlockPuzzleMagic.GameReferenceData.Instance;
            BlockPuzzleMagic.BlockColor val_4 = this.GetBlockColor(colorType:  1);
        }
        public override void Init(BlockPuzzleMagic.BlockColor color, UnityEngine.Transform parent, UnityEngine.Vector3 worldPos, float scale, float alpha, string source)
        {
            BlockPuzzleMagic.GameReferenceData val_1 = BlockPuzzleMagic.GameReferenceData.Instance;
            BlockPuzzleMagic.BlockColor val_4 = this.GetBlockColor(colorType:  1);
            this.Init(color:  1277104880, parent:  parent, worldPos:  new UnityEngine.Vector3() {x = worldPos.x, y = worldPos.y, z = worldPos.z}, scale:  scale, alpha:  alpha, source:  source);
        }
        public override void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_3;
            var val_4;
            this.OnDrag(eventData:  eventData);
            val_3 = 4;
            goto label_1;
            label_13:
            if((R6 + 12) <= eventData)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = 1;
            if((R6 + 8 + 16) != 0)
            {
                    if(50331648 <= eventData)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = 0;
                if(0 != 0)
            {
                    if(2621443.isFilled != true)
            {
                    if(static_value_0028001C == true)
            {
                    val_4 = 1;
            }
            
            }
            
            }
            
            }
            
            this.FadeShapeBlock(index:  eventData, visible:  true);
            val_3 = 5;
            label_1:
            if((val_3 - 4) < 50331648)
            {
                goto label_13;
            }
        
        }
        public override bool CanResolveAction()
        {
            var val_4;
            bool val_1 = System.String.op_Equality(a:  "shpsrc_shp_spwn", b:  1235593280);
            if("shpsrc_shp_spwn" > 0)
            {
                    val_4 = 1;
            }
            
            if("shpsrc_shp_spwn" < 1)
            {
                    0 = 1;
            }
            
            if("shpsrc_shp_spwn" != 1)
            {
                    return (bool)CanUsePowerup(powerupType:  2, showStoreIfOOC:  false, oocDelay:  null);
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            return (bool)CanUsePowerup(powerupType:  2, showStoreIfOOC:  false, oocDelay:  null);
        }
        public override void ResolveAction()
        {
            var val_4;
            if(35640182 == 0)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_2;
            label_8:
            if(mem[35640194] <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = mem[35640190];
            val_3 = val_3 + 0;
            (mem[35640190] + 0) + 16.AddBlockColorFill(blockColor:  R6 + 8);
            val_4 = 1;
            label_2:
            if(val_4 < ((mem[35640190] + 0) + 16 + 12))
            {
                goto label_8;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UsePowerup(powerupType:  2, freeUsage:  System.String.op_Equality(a:  "shpsrc_shp_spwn", b:  1235593280));
        }
        public override void SnapBackAndReset(System.Action onComplete)
        {
            var val_1;
            this.SnapBackAndReset(onComplete:  onComplete);
            val_1 = 0;
            goto label_1;
            label_3:
            this.FadeShapeBlock(index:  0, visible:  true);
            val_1 = 1;
            label_1:
            if(val_1 < mem[35640195])
            {
                goto label_3;
            }
        
        }
        private void FadeShapeBlock(int index, bool visible)
        {
            if(true <= index)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (index << 2);
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  (0 + (index) << 2) + 16 + 20, endValue:  0.35f = 1f, duration:  null);
        }
        public PowerupFillShapeInfo()
        {
        
        }
    
    }

}
