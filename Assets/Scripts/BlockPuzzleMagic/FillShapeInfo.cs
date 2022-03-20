using UnityEngine;

namespace BlockPuzzleMagic
{
    public class FillShapeInfo : GridPlaceableShapeInfo
    {
        // Methods
        public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.RotateShape(isClockwise:  true, skipAnimate:  false);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            NotifyShapeRotated(shape:  1241786352);
        }
        public override void ResolveAction()
        {
            BlockPuzzleMagic.BlockColorType val_1;
            var val_2;
            var val_3;
            if(true != 0)
            {
                    return;
            }
            
            val_3 = mem[R4 + 160];
            val_3 = R4 + 160;
            if(val_3 == 0)
            {
                    return;
            }
            
            val_2 = 0;
            goto label_2;
            label_8:
            if((R4 + 160 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = R4 + 160 + 8;
            val_1 = val_1 + 0;
            val_1 = mem[R4 + 52 + 8];
            val_1 = R4 + 52 + 8;
            (R4 + 160 + 8 + 0) + 16.AddBlockColorFill(blockColor:  val_1);
            val_3 = mem[R4 + 160];
            val_3 = R4 + 160;
            val_2 = 1;
            label_2:
            if(val_2 < (R4 + 160 + 12))
            {
                goto label_8;
            }
        
        }
        public FillShapeInfo()
        {
        
        }
    
    }

}
