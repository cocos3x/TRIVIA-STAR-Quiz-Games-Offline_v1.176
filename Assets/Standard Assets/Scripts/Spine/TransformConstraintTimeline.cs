using UnityEngine;

namespace Spine
{
    public class TransformConstraintTimeline : CurveTimeline
    {
        // Fields
        public const int ENTRIES = 5;
        private const int PREV_TIME = -5;
        private const int PREV_ROTATE = -4;
        private const int PREV_TRANSLATE = -3;
        private const int PREV_SCALE = -2;
        private const int PREV_SHEAR = -1;
        private const int ROTATE = 1;
        private const int TRANSLATE = 2;
        private const int SCALE = 3;
        private const int SHEAR = 4;
        internal int transformConstraintIndex;
        internal float[] frames;
        
        // Properties
        public int TransformConstraintIndex { get; set; }
        public float[] Frames { get; set; }
        public override int PropertyId { get; }
        
        // Methods
        public int get_TransformConstraintIndex()
        {
            return (int)this.transformConstraintIndex;
        }
        public void set_TransformConstraintIndex(int value)
        {
            this.transformConstraintIndex = value;
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
            int val_1 = this.transformConstraintIndex;
            val_1 = val_1 + 167772160;
            return (int)val_1;
        }
        public TransformConstraintTimeline(int frameCount)
        {
            int val_1 = frameCount + (frameCount << 2);
            this.frames = null;
        }
        public void SetFrame(int frameIndex, float time, float rotateMix, float translateMix, float scaleMix, float shearMix)
        {
            float val_4;
            float val_6;
            float val_8;
            int val_1 = frameIndex + (frameIndex << 2);
            this.frames[val_1] = R2;
            this.frames[val_1 + 1] = R3;
            this.frames[val_1 + 2] = val_4;
            this.frames[val_1 + 3] = val_6;
            this.frames[val_1 + 4] = val_8;
        }
        public override void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_2;
            int val_30;
            var val_31;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            var val_38;
            var val_39;
            float val_40;
            float val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            val_30 = pose;
            val_31 = this;
            var val_1 = R5 + (this.transformConstraintIndex << 2);
            float val_28 = this.frames[0];
            if(val_1 <= 0)
            {
                goto label_6;
            }
            
            if(val_2 == 1)
            {
                goto label_8;
            }
            
            if(val_2 != 0)
            {
                    return;
            }
            
            if(((R5 + (this.transformConstraintIndex) << 2) + 16 + 8) == 0)
            {
                goto label_10;
            }
            
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 24;
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 28;
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 32;
            goto label_11;
            label_6:
            var val_4 = val_1 - 5;
            if(val_1 > 4)
            {
                    val_30 = Spine.Animation.BinarySearch(values:  this.frames, target:  this.frames[val_4], step:  val_30);
                val_4 = val_30 - 4;
                float val_34 = this.frames[val_30];
                float val_35 = this.frames[val_30 - 5];
                val_35 = val_35 - val_34;
                val_35 = (val_30 - val_34) / val_35;
                val_35 = 1f - val_35;
                float val_11 = this.GetCurvePercent(frameIndex:  858993458, percent:  val_35);
                val_31 = val_31;
                float val_15 = (this.frames[val_30 + 1]) - this.frames[val_4];
                float val_16 = (this.frames[val_30 + 2]) - (this.frames[val_30 - 3]);
                float val_18 = (this.frames[val_30 + 3]) - (this.frames[val_30 - 2]);
                float val_39 = this.frames[val_30 + 4];
                val_39 = val_39 - (this.frames[val_30 - 1]);
            }
            else
            {
                    val_38 = val_4;
                val_34 = this.frames[val_4 - 4];
                val_30 = val_4 - 2;
                val_35 = this.frames[val_4 - 3];
                val_4 = val_4 - 1;
                val_36 = this.frames[val_30];
                val_37 = this.frames[val_4];
            }
            
            if(val_2 == 0)
            {
                goto label_30;
            }
            
            if(((R5 + (this.transformConstraintIndex) << 2) + 16) == 0)
            {
                goto label_31;
            }
            
            float val_21 = val_34 - ((R5 + (this.transformConstraintIndex) << 2) + 16 + 20);
            val_39 = ((R5 + (this.transformConstraintIndex) << 2) + 16) + 32;
            float val_22 = val_35 - ((R5 + (this.transformConstraintIndex) << 2) + 16 + 24);
            val_40 = mem[(R5 + (this.transformConstraintIndex) << 2) + 16 + 32];
            val_40 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 32;
            float val_23 = val_36 - ((R5 + (this.transformConstraintIndex) << 2) + 16 + 28);
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 20;
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 24;
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 28;
            goto label_32;
            label_30:
            if(((R5 + (this.transformConstraintIndex) << 2) + 16 + 8) == 0)
            {
                goto label_33;
            }
            
            float val_24 = val_34 - ((R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 24);
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 24;
            float val_25 = val_35 - ((R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 28);
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 28;
            float val_26 = val_36 - ((R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 32);
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 32;
            val_41 = mem[(R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 36];
            val_41 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 36;
            goto label_34;
            label_8:
            val_42 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 20;
            if(((R5 + (this.transformConstraintIndex) << 2) + 16 + 8) == 0)
            {
                    val_42 = mem[(R5 + (this.transformConstraintIndex) << 2) + 16 + 20];
                val_42 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 20;
            }
            
            val_42 = ((R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 24) - val_42;
            val_43 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 24;
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 20;
            if(((R5 + (this.transformConstraintIndex) << 2) + 16 + 8) == 0)
            {
                    val_43 = mem[(R5 + (this.transformConstraintIndex) << 2) + 16 + 24];
                val_43 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 24;
            }
            
            val_43 = ((R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 28) - val_43;
            val_44 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 28;
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 24;
            if(((R5 + (this.transformConstraintIndex) << 2) + 16 + 8) == 0)
            {
                    val_44 = mem[(R5 + (this.transformConstraintIndex) << 2) + 16 + 28];
                val_44 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 28;
            }
            
            val_44 = ((R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 32) - val_44;
            val_45 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 32;
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 28;
            if(((R5 + (this.transformConstraintIndex) << 2) + 16 + 8) == 0)
            {
                    val_45 = mem[(R5 + (this.transformConstraintIndex) << 2) + 16 + 32];
                val_45 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 32;
            }
            
            val_45 = ((R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 36) - val_45;
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 32;
            return;
            label_31:
            var val_40 = (R5 + (this.transformConstraintIndex) << 2) + 16 + 20;
            val_40 = val_34 - val_40;
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 20;
            float val_41 = 0f;
            val_41 = val_35 - val_41;
            mem[24] = 0f;
            float val_42 = 7.286752E-44f;
            val_42 = val_36 - val_42;
            mem[28] = 7.286752E-44f;
            val_39 = 32;
            val_40 = 1.171481E-37f;
            label_32:
            float val_27 = val_37 - val_40;
            mem[32] = 1.171481E-37f;
            return;
            label_10:
            mem2[0] = mem[24];
            mem2[0] = mem[28];
            mem2[0] = mem[32];
            label_11:
            mem2[0] = (R5 + (this.transformConstraintIndex) << 2) + 16 + 8 + 36;
            return;
            label_33:
            float val_43 = mem[24];
            val_43 = val_34 - val_43;
            mem2[0] = mem[24];
            float val_44 = mem[28];
            val_44 = val_35 - val_44;
            mem2[0] = mem[28];
            float val_45 = mem[32];
            val_45 = val_36 - val_45;
            mem2[0] = mem[32];
            val_41 = 6.018898E-36f;
            label_34:
            val_41 = val_37 - val_41;
            mem2[0] = 6.018898E-36f;
        }
    
    }

}
