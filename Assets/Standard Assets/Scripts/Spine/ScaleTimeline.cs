using UnityEngine;

namespace Spine
{
    public class ScaleTimeline : TranslateTimeline
    {
        // Properties
        public override int PropertyId { get; }
        
        // Methods
        public override int get_PropertyId()
        {
            return (int)1152921510783044256;
        }
        public ScaleTimeline(int frameCount)
        {
        
        }
        public override void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_2;
            var val_20;
            var val_33;
            int val_34;
            var val_35;
            float val_37;
            float val_39;
            float val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            float val_45;
            val_33 = this;
            val_34 = pose;
            var val_28 = 35650782;
            var val_1 = val_28 + ((R7) << 2);
            if(val_1 <= 0)
            {
                goto label_7;
            }
            
            if(val_2 == 1)
            {
                goto label_8;
            }
            
            if(val_2 != 0)
            {
                    return;
            }
            
            if(((35650782 + (R7) << 2) + 16 + 8) == 0)
            {
                goto label_11;
            }
            
            mem2[0] = (35650782 + (R7) << 2) + 16 + 8 + 36;
            val_35 = (35650782 + (R7) << 2) + 16 + 8;
            goto label_12;
            label_7:
            val_28 = val_1 - 3;
            val_1 = skeleton.bones + (val_28 << 2);
            if(val_1 > 2)
            {
                    int val_4 = Spine.Animation.BinarySearch(values:  skeleton.bones, target:  lastTime, step:  val_34);
                Spine.ExposedList<Spine.Bone> val_6 = skeleton.bones + ((val_4 - 2) << 2);
                Spine.ExposedList<Spine.Bone> val_8 = skeleton.bones + ((val_4 - 1) << 2);
                Spine.ExposedList<Spine.Bone> val_9 = skeleton.bones + (val_4 << 2);
                val_4 = skeleton.bones + ((val_4 - 3) << 2);
                lastTime = lastTime - S24;
                lastTime = (val_34 - S24) / lastTime;
                lastTime = 1f - lastTime;
                float val_12 = this.GetCurvePercent(frameIndex:  1431655765, percent:  lastTime);
                val_33 = val_33;
                Spine.ExposedList<Spine.Bone> val_14 = skeleton.bones + ((val_4 + 1) << 2);
                Spine.ExposedList<Spine.Bone> val_17 = skeleton.bones + ((val_4 + 2) << 2);
                val_34 = mem[(35650782 + (R7) << 2) + 16 + 8];
                val_34 = (35650782 + (R7) << 2) + 16 + 8;
                float val_18 = (S24 - S18) - S22;
                val_37 = S18 * ((35650782 + (R7) << 2) + 16 + 8 + 36);
            }
            else
            {
                    val_28 = val_1 - 2;
                val_1 = skeleton.bones + (val_28 << 2);
                val_1 = skeleton.bones + ((val_1 - 1) << 2);
                val_34 = mem[(35650782 + (R7) << 2) + 16 + 8];
                val_34 = (35650782 + (R7) << 2) + 16 + 8;
                val_37 = S18 * ((35650782 + (R7) << 2) + 16 + 8 + 36);
            }
            
            val_39 = S22 * ((35650782 + (R7) << 2) + 16 + 8 + 40);
            if(val_34 == 0)
            {
                    mem2[0] = val_37;
                mem2[0] = val_39;
                return;
            }
            
            if(val_2 == 0)
            {
                goto label_32;
            }
            
            val_40 = mem[(35650782 + (R7) << 2) + 16 + 36];
            val_40 = (35650782 + (R7) << 2) + 16 + 36;
            val_41 = ((35650782 + (R7) << 2) + 16) + 40;
            goto label_33;
            label_8:
            if(((35650782 + (R7) << 2) + 16) == 0)
            {
                goto label_34;
            }
            
            val_42 = ((35650782 + (R7) << 2) + 16) + 36;
            goto label_35;
            label_32:
            val_43 = mem[(35650782 + (R7) << 2) + 16 + 8];
            val_43 = (35650782 + (R7) << 2) + 16 + 8;
            if(val_43 == 0)
            {
                goto label_36;
            }
            
            val_40 = mem[(35650782 + (R7) << 2) + 16 + 8 + 36];
            val_40 = (35650782 + (R7) << 2) + 16 + 8 + 36;
            goto label_43;
            label_11:
            val_35 = mem[(35650782 + (R7) << 2) + 16 + 8];
            val_35 = (35650782 + (R7) << 2) + 16 + 8;
            mem2[0] = (35650782 + (R7) << 2) + 16 + 8 + 36;
            if(val_35 == 0)
            {
                goto label_38;
            }
            
            label_12:
            mem2[0] = (35650782 + (R7) << 2) + 16 + 8 + 40;
            return;
            label_34:
            val_42 = 36;
            label_35:
            val_42 = ((35650782 + (R7) << 2) + 16 + 8 + 36) - val_42;
            mem[36] = 6.018898E-36f;
            val_44 = (35650782 + (R7) << 2) + 16 + 40;
            if(((35650782 + (R7) << 2) + 16 + 8) == 0)
            {
                    val_44 = mem[(35650782 + (R7) << 2) + 16 + 40];
                val_44 = (35650782 + (R7) << 2) + 16 + 40;
            }
            
            val_44 = ((35650782 + (R7) << 2) + 16 + 8 + 40) - val_44;
            mem2[0] = (35650782 + (R7) << 2) + 16 + 40;
            return;
            label_36:
            val_40 = mem[(35650782 + (R7) << 2) + 16 + 8 + 36];
            val_40 = (35650782 + (R7) << 2) + 16 + 8 + 36;
            val_43 = mem[(35650782 + (R7) << 2) + 16 + 8];
            val_43 = (35650782 + (R7) << 2) + 16 + 8;
            if(val_43 == 0)
            {
                    val_43 = 0;
            }
            
            label_43:
            val_41 = val_43 + 40;
            label_33:
            val_45 = mem[(val_43 + 40)];
            val_45 = val_41;
            if(val_20 == 1)
            {
                    int val_22 = System.Math.Sign(value:  1f);
                val_37 = System.Math.Abs(val_37) * (float)val_22;
                val_39 = System.Math.Abs(val_39) * ((float)System.Math.Sign(value:  val_22));
            }
            else
            {
                    int val_24 = System.Math.Sign(value:  1f);
                val_40 = System.Math.Abs(val_40) * (float)val_24;
                val_45 = System.Math.Abs(val_45) * ((float)System.Math.Sign(value:  val_24));
            }
            
            float val_26 = val_39 - val_45;
            float val_27 = val_37 - val_40;
            mem2[0] = val_40;
            mem2[0] = val_45;
            return;
            label_38:
        }
    
    }

}
