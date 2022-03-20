using UnityEngine;

namespace Spine
{
    public class PathConstraintSpacingTimeline : PathConstraintPositionTimeline
    {
        // Properties
        public override int PropertyId { get; }
        
        // Methods
        public override int get_PropertyId()
        {
            return (int)1152921510966575120;
        }
        public PathConstraintSpacingTimeline(int frameCount)
        {
        
        }
        public override void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_2;
            int val_19;
            Spine.ExposedList<Spine.Bone> val_20;
            Spine.ExposedList<Spine.Slot> val_21;
            var val_22;
            var val_23;
            var val_24;
            val_19 = pose;
            Spine.ExposedList<Spine.PathConstraint> val_1 = skeleton.pathConstraints + ((R7) << 2);
            if(skeleton.bones <= 0)
            {
                goto label_6;
            }
            
            if(val_2 == 1)
            {
                goto label_7;
            }
            
            if(val_2 != 0)
            {
                    return;
            }
            
            mem2[0] = R7 + 8 + 44;
            return;
            label_6:
            Spine.ExposedList<Spine.Bone> val_18 = skeleton.bones;
            val_18 = skeleton + ((val_18 - 2) << 2);
            if(val_18 > 1)
            {
                    val_19 = Spine.Animation.BinarySearch(values:  skeleton, target:  (skeleton + ((skeleton.bones - 2)) << 2).slots, step:  val_19);
                val_20 = skeleton.bones;
                int val_6 = val_19 - 1;
                if(val_20 <= val_6)
            {
                    val_20 = skeleton.bones;
            }
            
                Spine.Skeleton val_7 = skeleton + (val_6 << 2);
                if(val_20 <= val_19)
            {
                    val_20 = skeleton.bones;
            }
            
                Spine.Skeleton val_8 = skeleton + (val_19 << 2);
                Spine.Skeleton val_10 = skeleton + ((val_19 - 2) << 2);
                int val_20 = 0;
                Spine.ExposedList<Spine.Slot> val_19 = (skeleton + ((val_5 - 2)) << 2).slots;
                val_19 = val_19 - ((skeleton + (val_5) << 2).slots);
                val_20 = val_20 + ((val_19 + (val_19 >> 31)) >> 1);
                val_19 = (val_19 - ((skeleton + (val_5) << 2).slots)) / val_19;
                val_19 = 1f - val_19;
                float val_13 = this.GetCurvePercent(frameIndex:  val_20, percent:  val_19);
                Spine.Skeleton val_15 = skeleton + ((val_19 + 1) << 2);
                Spine.ExposedList<Spine.Slot> val_21 = (skeleton + ((val_5 + 1)) << 2).slots;
                val_21 = val_21 - ((skeleton + ((val_5 - 1)) << 2).slots);
            }
            else
            {
                    Spine.ExposedList<Spine.Bone> val_22 = skeleton.bones;
                val_22 = skeleton + ((val_22 - 1) << 2);
                val_21 = (skeleton + ((skeleton.bones - 1)) << 2).slots;
            }
            
            if(val_2 != 0)
            {
                    val_22 = R7 + 24;
                if(R7 == 0)
            {
                    val_22 = mem[R7 + 24];
                val_22 = R7 + 24;
            }
            
                Spine.ExposedList<Spine.Slot> val_17 = val_21 - val_22;
                mem2[0] = R7 + 24;
                return;
            }
            
            val_23 = R7 + 8;
            if((R7 + 8) != 0)
            {
                goto label_24;
            }
            
            val_23 = mem[R7 + 8];
            val_23 = R7 + 8;
            if(val_23 == 0)
            {
                goto label_25;
            }
            
            label_24:
            var val_23 = R7 + 8 + 44;
            val_23 = val_21 - val_23;
            mem2[0] = R7 + 8 + 44;
            return;
            label_7:
            if(R7 != 0)
            {
                    val_24 = R7 + 24;
            }
            else
            {
                    val_24 = 24;
            }
            
            val_24 = (R7 + 8 + 44) - val_24;
            mem[24] = 0f;
            return;
            label_25:
        }
    
    }

}
