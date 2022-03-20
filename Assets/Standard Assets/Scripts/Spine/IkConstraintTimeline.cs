using UnityEngine;

namespace Spine
{
    public class IkConstraintTimeline : CurveTimeline
    {
        // Fields
        public const int ENTRIES = 3;
        private const int PREV_TIME = -3;
        private const int PREV_MIX = -2;
        private const int PREV_BEND_DIRECTION = -1;
        private const int MIX = 1;
        private const int BEND_DIRECTION = 2;
        internal int ikConstraintIndex;
        internal float[] frames;
        
        // Properties
        public int IkConstraintIndex { get; set; }
        public float[] Frames { get; set; }
        public override int PropertyId { get; }
        
        // Methods
        public int get_IkConstraintIndex()
        {
            return (int)this.ikConstraintIndex;
        }
        public void set_IkConstraintIndex(int value)
        {
            this.ikConstraintIndex = value;
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
            int val_1 = this.ikConstraintIndex;
            val_1 = val_1 + 150994944;
            return (int)val_1;
        }
        public IkConstraintTimeline(int frameCount)
        {
            int val_1 = frameCount + (frameCount << 1);
            this.frames = null;
        }
        public void SetFrame(int frameIndex, float time, float mix, int bendDirection)
        {
            var val_3;
            int val_1 = frameIndex + (frameIndex << 1);
            this.frames[val_1] = bendDirection;
            this.frames[val_1 + 1] = R3;
            this.frames[val_1 + 2] = (float)val_3;
        }
        public override void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_2;
            var val_5;
            int val_17;
            var val_18;
            var val_19;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_17 = pose;
            var val_1 = R5 + (this.ikConstraintIndex << 2);
            float val_15 = this.frames[0];
            val_18 = val_2;
            if(val_1 <= 0)
            {
                goto label_6;
            }
            
            if(val_18 == 1)
            {
                goto label_7;
            }
            
            if(val_18 != 0)
            {
                    return;
            }
            
            if(((R5 + (this.ikConstraintIndex) << 2) + 16 + 8) == 0)
            {
                goto label_10;
            }
            
            mem2[0] = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 28;
            val_19 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8;
            goto label_11;
            label_6:
            var val_4 = val_1 - 3;
            if(val_1 <= 2)
            {
                goto label_13;
            }
            
            val_17 = Spine.Animation.BinarySearch(values:  this.frames, target:  this.frames[val_4], step:  val_17);
            val_4 = val_17 - 2;
            float val_17 = this.frames[val_4];
            float val_18 = this.frames[val_17];
            float val_19 = this.frames[val_17 - 3];
            val_19 = val_19 - val_18;
            val_19 = (val_17 - val_18) / val_19;
            val_19 = 1f - val_19;
            float val_9 = this.GetCurvePercent(frameIndex:  1431655765, percent:  val_19);
            if(val_18 == 0)
            {
                goto label_18;
            }
            
            int val_10 = val_17 + 1;
            val_21 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 20;
            if(this <= val_10)
            {
                    val_21 = mem[(R5 + (this.ikConstraintIndex) << 2) + 16 + 20];
                val_21 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 20;
            }
            
            float val_20 = this.frames[val_10];
            val_20 = val_20 - val_17;
            val_21 = val_17 - val_21;
            mem2[0] = (R5 + (this.ikConstraintIndex) << 2) + 16 + 20;
            if(val_5 != 0)
            {
                    return;
            }
            
            int val_11 = val_17 - 1;
            if(this.frames[val_10] > val_11)
            {
                goto label_27;
            }
            
            label_28:
            label_27:
            mem2[0] = this.frames[val_11];
            return;
            label_13:
            if(val_18 == 0)
            {
                goto label_24;
            }
            
            val_22 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 20;
            val_4 = this.frames[val_4] - 2;
            if(this.frames[val_4] <= 1)
            {
                    val_22 = mem[(R5 + (this.ikConstraintIndex) << 2) + 16 + 20];
                val_22 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 20;
            }
            
            val_22 = this.frames[val_4] - val_22;
            mem2[0] = (R5 + (this.ikConstraintIndex) << 2) + 16 + 20;
            if(val_5 != 0)
            {
                    return;
            }
            
            val_4 = this.frames[val_4] - 1;
            if(this.frames[val_4] != null)
            {
                goto label_27;
            }
            
            goto label_28;
            label_7:
            if(((R5 + (this.ikConstraintIndex) << 2) + 16) == 0)
            {
                goto label_29;
            }
            
            val_23 = ((R5 + (this.ikConstraintIndex) << 2) + 16) + 20;
            goto label_30;
            label_18:
            val_18 = val_17 + 1;
            float val_12 = this.frames[val_18] - val_17;
            var val_24 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 28;
            val_24 = val_17 - val_24;
            mem2[0] = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 28;
            if(val_5 == 1)
            {
                goto label_40;
            }
            
            int val_13 = val_17 - 1;
            if(this.frames[val_18] > val_13)
            {
                goto label_41;
            }
            
            label_42:
            label_41:
            val_24 = this.frames[val_13];
            goto label_44;
            label_24:
            System.Single[] val_14 = this.frames[val_4] - 2;
            val_17 = mem[(R5 + (this.ikConstraintIndex) << 2) + 16 + 8];
            val_17 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8;
            var val_27 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 28;
            val_27 = this.frames[val_14] - val_27;
            mem2[0] = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 28;
            if(val_5 == 1)
            {
                goto label_40;
            }
            
            val_14 = this.frames[val_14] - 1;
            if(this.frames[val_14] != null)
            {
                goto label_41;
            }
            
            goto label_42;
            label_10:
            val_19 = mem[(R5 + (this.ikConstraintIndex) << 2) + 16 + 8];
            val_19 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8;
            mem2[0] = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 28;
            if(val_19 == 0)
            {
                goto label_43;
            }
            
            label_11:
            val_24 = mem[(R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 24];
            val_24 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 24;
            goto label_44;
            label_29:
            val_23 = 20;
            label_30:
            val_23 = ((R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 28) - val_23;
            mem[20] = 1.401298E-45f;
            label_40:
            val_24 = mem[(R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 24];
            val_24 = (R5 + (this.ikConstraintIndex) << 2) + 16 + 8 + 24;
            label_44:
            mem2[0] = val_24;
            return;
            label_43:
        }
    
    }

}
