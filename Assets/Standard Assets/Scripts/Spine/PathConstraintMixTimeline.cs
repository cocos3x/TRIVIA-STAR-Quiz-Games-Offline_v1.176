using UnityEngine;

namespace Spine
{
    public class PathConstraintMixTimeline : CurveTimeline
    {
        // Fields
        public const int ENTRIES = 3;
        private const int PREV_TIME = -3;
        private const int PREV_ROTATE = -2;
        private const int PREV_TRANSLATE = -1;
        private const int ROTATE = 1;
        private const int TRANSLATE = 2;
        internal int pathConstraintIndex;
        internal float[] frames;
        
        // Properties
        public int PathConstraintIndex { get; set; }
        public float[] Frames { get; set; }
        public override int PropertyId { get; }
        
        // Methods
        public int get_PathConstraintIndex()
        {
            return (int)this.pathConstraintIndex;
        }
        public void set_PathConstraintIndex(int value)
        {
            this.pathConstraintIndex = value;
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
            int val_1 = this.pathConstraintIndex;
            val_1 = val_1 + 218103808;
            return (int)val_1;
        }
        public PathConstraintMixTimeline(int frameCount)
        {
            int val_1 = frameCount + (frameCount << 1);
            this.frames = null;
        }
        public void SetFrame(int frameIndex, float time, float rotateMix, float translateMix)
        {
            float val_4;
            int val_1 = frameIndex + (frameIndex << 1);
            this.frames[val_1] = R2;
            this.frames[val_1 + 1] = R3;
            this.frames[val_1 + 2] = val_4;
        }
        public override void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_2;
            int val_17;
            var val_18;
            var val_19;
            float val_22;
            float val_23;
            var val_25;
            float val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            val_17 = pose;
            val_18 = this;
            var val_1 = R5 + (this.pathConstraintIndex << 2);
            float val_15 = this.frames[0];
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
            
            if(((R5 + (this.pathConstraintIndex) << 2) + 16 + 8) == 0)
            {
                goto label_10;
            }
            
            mem2[0] = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8 + 48;
            val_19 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8;
            goto label_11;
            label_6:
            var val_4 = val_1 - 3;
            if(val_1 <= 2)
            {
                goto label_13;
            }
            
            val_17 = Spine.Animation.BinarySearch(values:  this.frames, target:  this.frames[val_4], step:  val_17);
            val_4 = val_17 - 2;
            float val_19 = this.frames[val_17];
            float val_20 = this.frames[val_17 - 3];
            val_20 = val_20 - val_19;
            val_20 = (val_17 - val_19) / val_20;
            val_20 = 1f - val_20;
            float val_9 = this.GetCurvePercent(frameIndex:  1431655765, percent:  val_20);
            val_18 = val_18;
            float val_12 = (this.frames[val_17 + 1]) - this.frames[val_4];
            float val_22 = this.frames[val_17 + 2];
            val_22 = val_22 - (this.frames[val_17 - 1]);
            goto label_20;
            label_13:
            val_4 = this.frames[val_4] - 2;
            if(val_1 < 2)
            {
                goto label_21;
            }
            
            val_22 = this.frames[val_4];
            goto label_22;
            label_7:
            if(((R5 + (this.pathConstraintIndex) << 2) + 16) == 0)
            {
                goto label_23;
            }
            
            val_25 = ((R5 + (this.pathConstraintIndex) << 2) + 16) + 28;
            goto label_24;
            label_21:
            val_22 = this.frames[val_4];
            if(this.frames[val_4] == null)
            {
                goto label_40;
            }
            
            label_22:
            this.frames[val_4] = this.frames[val_4] - 1;
            label_40:
            val_23 = this.frames[this.frames[val_4]];
            label_20:
            if(val_2 == 0)
            {
                goto label_27;
            }
            
            if(((R5 + (this.pathConstraintIndex) << 2) + 16) == 0)
            {
                goto label_28;
            }
            
            float val_13 = val_22 - ((R5 + (this.pathConstraintIndex) << 2) + 16 + 28);
            val_26 = mem[(R5 + (this.pathConstraintIndex) << 2) + 16 + 32];
            val_26 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 32;
            val_27 = ((R5 + (this.pathConstraintIndex) << 2) + 16) + 32;
            mem2[0] = (R5 + (this.pathConstraintIndex) << 2) + 16 + 28;
            goto label_29;
            label_27:
            val_28 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8;
            if(((R5 + (this.pathConstraintIndex) << 2) + 16 + 8) != 0)
            {
                goto label_30;
            }
            
            val_28 = mem[(R5 + (this.pathConstraintIndex) << 2) + 16 + 8];
            val_28 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8;
            if(val_28 == 0)
            {
                goto label_36;
            }
            
            label_30:
            var val_23 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8 + 48;
            val_29 = val_28;
            val_23 = val_22 - val_23;
            mem2[0] = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8 + 48;
            if(val_28 != 0)
            {
                goto label_32;
            }
            
            val_29 = mem[(R5 + (this.pathConstraintIndex) << 2) + 16 + 8];
            val_29 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8;
            if(val_29 == 0)
            {
                goto label_36;
            }
            
            label_32:
            var val_24 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8 + 52;
            val_24 = val_23 - val_24;
            mem2[0] = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8 + 52;
            return;
            label_28:
            var val_25 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 28;
            val_25 = val_22 - val_25;
            mem2[0] = (R5 + (this.pathConstraintIndex) << 2) + 16 + 28;
            val_27 = 32;
            val_26 = 1.171481E-37f;
            label_29:
            float val_14 = val_23 - val_26;
            mem[32] = 1.171481E-37f;
            return;
            label_10:
            val_19 = mem[(R5 + (this.pathConstraintIndex) << 2) + 16 + 8];
            val_19 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8;
            mem2[0] = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8 + 48;
            if(val_19 == 0)
            {
                goto label_36;
            }
            
            label_11:
            mem2[0] = (R5 + (this.pathConstraintIndex) << 2) + 16 + 8 + 52;
            return;
            label_23:
            val_25 = 28;
            label_24:
            val_25 = ((R5 + (this.pathConstraintIndex) << 2) + 16 + 8 + 48) - val_25;
            mem[28] = 7.286752E-44f;
            val_30 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 32;
            if(((R5 + (this.pathConstraintIndex) << 2) + 16 + 8) == 0)
            {
                    val_30 = mem[(R5 + (this.pathConstraintIndex) << 2) + 16 + 32];
                val_30 = (R5 + (this.pathConstraintIndex) << 2) + 16 + 32;
            }
            
            val_30 = ((R5 + (this.pathConstraintIndex) << 2) + 16 + 8 + 52) - val_30;
            mem2[0] = (R5 + (this.pathConstraintIndex) << 2) + 16 + 32;
            return;
            label_36:
        }
    
    }

}
