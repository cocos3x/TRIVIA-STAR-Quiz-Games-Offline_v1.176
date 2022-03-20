using UnityEngine;

namespace Spine
{
    public class RotateTimeline : CurveTimeline
    {
        // Fields
        public const int ENTRIES = 2;
        internal const int PREV_TIME = -2;
        internal const int PREV_ROTATION = -1;
        internal const int ROTATION = 1;
        internal int boneIndex;
        internal float[] frames;
        
        // Properties
        public int BoneIndex { get; set; }
        public float[] Frames { get; set; }
        public override int PropertyId { get; }
        
        // Methods
        public int get_BoneIndex()
        {
            return (int)this.boneIndex;
        }
        public void set_BoneIndex(int value)
        {
            this.boneIndex = value;
        }
        public float[] get_Frames()
        {
        
        }
        public void set_Frames(float[] value)
        {
            this.frames = value;
        }
        public override int get_PropertyId()
        {
            return (int)this.boneIndex;
        }
        public RotateTimeline(int frameCount)
        {
            int val_1 = frameCount << 1;
            this.frames = null;
        }
        public void SetFrame(int frameIndex, float time, float degrees)
        {
            int val_1 = frameIndex << 1;
            this.frames[val_1] = R2;
            this.frames[val_1 | 1] = R3;
        }
        public override void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_2;
            int val_19;
            var val_21;
            double val_22;
            val_19 = pose;
            var val_1 = R5 + (this.boneIndex << 2);
            float val_19 = this.frames[0];
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
            
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 8 + 32;
            return;
            label_6:
            var val_4 = val_1 - 2;
            if(val_1 <= 1)
            {
                goto label_13;
            }
            
            val_19 = Spine.Animation.BinarySearch(values:  this.frames, target:  this.frames[val_4], step:  val_19);
            val_4 = val_19 - 1;
            float val_21 = this.frames[val_4];
            float val_22 = this.frames[val_19];
            float val_23 = this.frames[val_19 - 2];
            val_23 = val_23 - val_22;
            val_23 = (val_19 - val_22) / val_23;
            val_23 = 1f - val_23;
            float val_9 = this.GetCurvePercent(frameIndex:  0 + (val_19 >> 1), percent:  val_23);
            int val_10 = val_19 + 1;
            float val_24 = this.frames[val_10];
            val_24 = val_24 - val_21;
            double val_12 = D16 + (2.12199579047121E-314);
            if(this == val_10)
            {
                    val_12 = -val_12;
            }
            
            float val_13 = 16384 - (val_24 / (-360f));
            var val_33 = 360;
            val_13 = val_13 * val_33;
            val_24 = val_24 - (float)val_13;
            if(val_2 == 0)
            {
                goto label_18;
            }
            
            var val_25 = (R5 + (this.boneIndex) << 2) + 16 + 8 + 32;
            val_25 = val_21 + val_25;
            val_21 = val_25 - ((R5 + (this.boneIndex) << 2) + 16 + 32);
            float val_14 = val_21 / (-360f);
            val_12 = val_12 + (2.12199579047121E-314);
            val_22 = -val_12;
            goto label_21;
            label_13:
            float val_26 = this.frames[this.frames[val_4] - 1];
            if(val_2 == 0)
            {
                goto label_25;
            }
            
            val_26 = ((R5 + (this.boneIndex) << 2) + 16 + 8 + 32) + val_26;
            float val_27 = -360f;
            val_21 = val_26 - ((R5 + (this.boneIndex) << 2) + 16 + 32);
            val_27 = val_21 / val_27;
            double val_16 = D16 + (2.12199579047121E-314);
            val_22 = -val_16;
            label_21:
            if(val_2 == 0)
            {
                    val_16 = val_22;
            }
            
            var val_28 = val_27;
            val_28 = 16384 - val_28;
            val_28 = val_28 * 360;
            val_21 = val_21 - (float)val_28;
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 32;
            return;
            label_7:
            var val_29 = (R5 + (this.boneIndex) << 2) + 16 + 8 + 32;
            float val_30 = -360f;
            val_29 = val_29 - ((R5 + (this.boneIndex) << 2) + 16 + 32);
            val_30 = val_29 / val_30;
            double val_17 = D16 + (2.12199579047121E-314);
            if(((R5 + (this.boneIndex) << 2) + 16 + 8) == 0)
            {
                    val_17 = -val_17;
            }
            
            var val_31 = val_30;
            val_31 = 16384 - val_31;
            val_31 = val_31 * 360;
            val_29 = val_29 - (float)val_31;
            goto label_29;
            label_18:
            val_12 = val_12 + (2.12199579047121E-314);
            if(val_2 == 0)
            {
                    val_12 = -val_12;
            }
            
            var val_32 = val_21 / (-360f);
            val_32 = 16384 - val_32;
            val_33 = val_32 * val_33;
            val_21 = val_21 - (float)val_33;
            label_29:
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 8 + 32;
            return;
            label_25:
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 8 + 32;
        }
    
    }

}
