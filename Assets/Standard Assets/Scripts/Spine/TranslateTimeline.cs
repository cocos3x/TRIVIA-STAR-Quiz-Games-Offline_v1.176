using UnityEngine;

namespace Spine
{
    public class TranslateTimeline : CurveTimeline
    {
        // Fields
        public const int ENTRIES = 3;
        protected const int PREV_TIME = -3;
        protected const int PREV_X = -2;
        protected const int PREV_Y = -1;
        protected const int X = 1;
        protected const int Y = 2;
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
            int val_1 = this.boneIndex;
            val_1 = val_1 + 16777216;
            return (int)val_1;
        }
        public TranslateTimeline(int frameCount)
        {
            int val_1 = frameCount + (frameCount << 1);
            this.frames = null;
        }
        public void SetFrame(int frameIndex, float time, float x, float y)
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
            int val_14;
            var val_15;
            var val_16;
            float val_19;
            float val_20;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            val_14 = pose;
            val_15 = this;
            var val_1 = R5 + (this.boneIndex << 2);
            float val_13 = this.frames[0];
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
            
            if(((R5 + (this.boneIndex) << 2) + 16 + 8) == 0)
            {
                goto label_10;
            }
            
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 8 + 24;
            val_16 = (R5 + (this.boneIndex) << 2) + 16 + 8;
            goto label_11;
            label_6:
            var val_4 = val_1 - 3;
            if(val_1 <= 2)
            {
                goto label_13;
            }
            
            val_14 = Spine.Animation.BinarySearch(values:  this.frames, target:  this.frames[val_4], step:  val_14);
            val_4 = val_14 - 2;
            float val_17 = this.frames[val_14];
            float val_18 = this.frames[val_14 - 3];
            val_18 = val_18 - val_17;
            val_18 = (val_14 - val_17) / val_18;
            val_18 = 1f - val_18;
            float val_9 = this.GetCurvePercent(frameIndex:  1431655765, percent:  val_18);
            val_15 = val_15;
            float val_12 = (this.frames[val_14 + 1]) - this.frames[val_4];
            float val_20 = this.frames[val_14 + 2];
            val_20 = val_20 - (this.frames[val_14 - 1]);
            goto label_20;
            label_13:
            val_4 = this.frames[val_4] - 2;
            if(val_1 < 2)
            {
                goto label_21;
            }
            
            val_19 = this.frames[val_4];
            goto label_22;
            label_7:
            if(((R5 + (this.boneIndex) << 2) + 16) == 0)
            {
                goto label_23;
            }
            
            val_22 = ((R5 + (this.boneIndex) << 2) + 16) + 24;
            goto label_24;
            label_21:
            val_19 = this.frames[val_4];
            if(this.frames[val_4] == null)
            {
                goto label_39;
            }
            
            label_22:
            this.frames[val_4] = this.frames[val_4] - 1;
            label_39:
            val_20 = this.frames[this.frames[val_4]];
            label_20:
            if(val_2 == 0)
            {
                goto label_27;
            }
            
            val_23 = (R5 + (this.boneIndex) << 2) + 16 + 8;
            if(((R5 + (this.boneIndex) << 2) + 16 + 8) == 0)
            {
                    val_23 = mem[(R5 + (this.boneIndex) << 2) + 16 + 8];
                val_23 = (R5 + (this.boneIndex) << 2) + 16 + 8;
            }
            
            var val_21 = (R5 + (this.boneIndex) << 2) + 16 + 8 + 24;
            val_21 = val_19 + val_21;
            val_21 = val_21 - ((R5 + (this.boneIndex) << 2) + 16 + 24);
            val_24 = (R5 + (this.boneIndex) << 2) + 16 + 28;
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 24;
            if(val_23 == 0)
            {
                    val_24 = mem[(R5 + (this.boneIndex) << 2) + 16 + 28];
                val_24 = (R5 + (this.boneIndex) << 2) + 16 + 28;
            }
            
            val_25 = val_20 + ((R5 + (this.boneIndex) << 2) + 16 + 8 + 28);
            goto label_31;
            label_27:
            val_26 = (R5 + (this.boneIndex) << 2) + 16 + 8;
            if(((R5 + (this.boneIndex) << 2) + 16 + 8) == 0)
            {
                    val_26 = mem[(R5 + (this.boneIndex) << 2) + 16 + 8];
                val_26 = (R5 + (this.boneIndex) << 2) + 16 + 8;
            }
            
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 8 + 24;
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 8 + 28;
            return;
            label_10:
            val_16 = mem[(R5 + (this.boneIndex) << 2) + 16 + 8];
            val_16 = (R5 + (this.boneIndex) << 2) + 16 + 8;
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 8 + 24;
            if(val_16 == 0)
            {
                goto label_35;
            }
            
            label_11:
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 8 + 28;
            return;
            label_23:
            val_22 = 24;
            label_24:
            val_22 = ((R5 + (this.boneIndex) << 2) + 16 + 8 + 24) - val_22;
            mem[24] = 0f;
            val_24 = (R5 + (this.boneIndex) << 2) + 16 + 28;
            if(((R5 + (this.boneIndex) << 2) + 16 + 8) == 0)
            {
                    val_24 = mem[(R5 + (this.boneIndex) << 2) + 16 + 28];
                val_24 = (R5 + (this.boneIndex) << 2) + 16 + 28;
            }
            
            val_25 = mem[(R5 + (this.boneIndex) << 2) + 16 + 8 + 28];
            val_25 = (R5 + (this.boneIndex) << 2) + 16 + 8 + 28;
            label_31:
            val_24 = val_25 - val_24;
            mem2[0] = (R5 + (this.boneIndex) << 2) + 16 + 28;
            return;
            label_35:
        }
    
    }

}
