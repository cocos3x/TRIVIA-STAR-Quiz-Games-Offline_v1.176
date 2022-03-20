using UnityEngine;

namespace Spine
{
    public class ShearTimeline : TranslateTimeline
    {
        // Properties
        public override int PropertyId { get; }
        
        // Methods
        public override int get_PropertyId()
        {
            return (int)1152921510800198432;
        }
        public ShearTimeline(int frameCount)
        {
        
        }
        public override void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_2;
            int val_22;
            var val_23;
            var val_24;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_22 = pose;
            val_23 = this;
            var val_1 = R5 + ((R7) << 2);
            if(val_1 <= 0)
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
            
            if(((R5 + (R7) << 2) + 16 + 8) == 0)
            {
                goto label_10;
            }
            
            mem2[0] = (R5 + (R7) << 2) + 16 + 8 + 44;
            val_24 = (R5 + (R7) << 2) + 16 + 8;
            goto label_11;
            label_6:
            var val_4 = val_1 - 3;
            val_1 = skeleton.bones + (val_4 << 2);
            if(val_1 <= 2)
            {
                goto label_13;
            }
            
            int val_5 = Spine.Animation.BinarySearch(values:  skeleton.bones, target:  lastTime, step:  val_22);
            val_22 = val_5;
            Spine.ExposedList<Spine.Bone> val_7 = skeleton.bones + ((val_22 - 2) << 2);
            Spine.ExposedList<Spine.Bone> val_9 = skeleton.bones + ((val_22 - 1) << 2);
            Spine.ExposedList<Spine.Bone> val_10 = skeleton.bones + (val_22 << 2);
            val_5 = skeleton.bones + ((val_22 - 3) << 2);
            lastTime = lastTime - S24;
            lastTime = (val_22 - S24) / lastTime;
            lastTime = 1f - lastTime;
            float val_13 = this.GetCurvePercent(frameIndex:  1431655765, percent:  lastTime);
            val_23 = val_23;
            Spine.ExposedList<Spine.Bone> val_15 = skeleton.bones + ((val_22 + 1) << 2);
            float val_17 = val_13 - S18;
            Spine.ExposedList<Spine.Bone> val_18 = skeleton.bones + ((val_22 + 2) << 2);
            val_13 = val_13 - S20;
            goto label_20;
            label_13:
            val_4 = val_1 - 2;
            if(val_1 < 2)
            {
                goto label_21;
            }
            
            Spine.ExposedList<Spine.Bone> val_19 = skeleton.bones + (val_4 << 2);
            goto label_22;
            label_7:
            if(((R5 + (R7) << 2) + 16) == 0)
            {
                goto label_23;
            }
            
            val_30 = ((R5 + (R7) << 2) + 16) + 44;
            goto label_24;
            label_21:
            Spine.ExposedList<Spine.Bone> val_20 = skeleton.bones + (val_4 << 2);
            if(val_1 == 0)
            {
                goto label_39;
            }
            
            label_22:
            val_1 = val_1 - 1;
            label_39:
            val_1 = skeleton.bones + (val_1 << 2);
            label_20:
            if(val_2 == 0)
            {
                goto label_27;
            }
            
            val_31 = (R5 + (R7) << 2) + 16 + 8;
            if(((R5 + (R7) << 2) + 16 + 8) == 0)
            {
                    val_31 = mem[(R5 + (R7) << 2) + 16 + 8];
                val_31 = (R5 + (R7) << 2) + 16 + 8;
            }
            
            var val_21 = (R5 + (R7) << 2) + 16 + 8 + 44;
            val_21 = S18 + val_21;
            val_21 = val_21 - ((R5 + (R7) << 2) + 16 + 44);
            val_32 = (R5 + (R7) << 2) + 16 + 48;
            mem2[0] = (R5 + (R7) << 2) + 16 + 44;
            if(val_31 == 0)
            {
                    val_32 = mem[(R5 + (R7) << 2) + 16 + 48];
                val_32 = (R5 + (R7) << 2) + 16 + 48;
            }
            
            val_33 = S20 + ((R5 + (R7) << 2) + 16 + 8 + 48);
            goto label_31;
            label_27:
            val_34 = (R5 + (R7) << 2) + 16 + 8;
            if(((R5 + (R7) << 2) + 16 + 8) == 0)
            {
                    val_34 = mem[(R5 + (R7) << 2) + 16 + 8];
                val_34 = (R5 + (R7) << 2) + 16 + 8;
            }
            
            mem2[0] = (R5 + (R7) << 2) + 16 + 8 + 44;
            mem2[0] = (R5 + (R7) << 2) + 16 + 8 + 48;
            return;
            label_10:
            val_24 = mem[(R5 + (R7) << 2) + 16 + 8];
            val_24 = (R5 + (R7) << 2) + 16 + 8;
            mem2[0] = (R5 + (R7) << 2) + 16 + 8 + 44;
            if(val_24 == 0)
            {
                goto label_35;
            }
            
            label_11:
            mem2[0] = (R5 + (R7) << 2) + 16 + 8 + 48;
            return;
            label_23:
            val_30 = 44;
            label_24:
            val_30 = ((R5 + (R7) << 2) + 16 + 8 + 44) - val_30;
            mem[44] = 3.673431E-39f;
            val_32 = (R5 + (R7) << 2) + 16 + 48;
            if(((R5 + (R7) << 2) + 16 + 8) == 0)
            {
                    val_32 = mem[(R5 + (R7) << 2) + 16 + 48];
                val_32 = (R5 + (R7) << 2) + 16 + 48;
            }
            
            val_33 = mem[(R5 + (R7) << 2) + 16 + 8 + 48];
            val_33 = (R5 + (R7) << 2) + 16 + 8 + 48;
            label_31:
            val_32 = val_33 - val_32;
            mem2[0] = (R5 + (R7) << 2) + 16 + 48;
            return;
            label_35:
        }
    
    }

}
