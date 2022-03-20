using UnityEngine;

namespace Spine
{
    public class ColorTimeline : CurveTimeline
    {
        // Fields
        public const int ENTRIES = 5;
        protected const int PREV_TIME = -5;
        protected const int PREV_R = -4;
        protected const int PREV_G = -3;
        protected const int PREV_B = -2;
        protected const int PREV_A = -1;
        protected const int R = 1;
        protected const int G = 2;
        protected const int B = 3;
        protected const int A = 4;
        internal int slotIndex;
        internal float[] frames;
        
        // Properties
        public int SlotIndex { get; set; }
        public float[] Frames { get; set; }
        public override int PropertyId { get; }
        
        // Methods
        public int get_SlotIndex()
        {
            return (int)this.slotIndex;
        }
        public void set_SlotIndex(int value)
        {
            this.slotIndex = value;
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
            int val_1 = this.slotIndex;
            val_1 = val_1 + 83886080;
            return (int)val_1;
        }
        public ColorTimeline(int frameCount)
        {
            int val_1 = frameCount + (frameCount << 2);
            this.frames = null;
        }
        public void SetFrame(int frameIndex, float time, float r, float g, float b, float a)
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
            int val_28;
            var val_29;
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            var val_36;
            float val_37;
            float val_38;
            float val_39;
            var val_40;
            float val_41;
            val_28 = pose;
            val_29 = this;
            var val_1 = R5 + (this.slotIndex << 2);
            float val_25 = this.frames[0];
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
            
            if(((R5 + (this.slotIndex) << 2) + 16 + 8) == 0)
            {
                goto label_10;
            }
            
            mem2[0] = (R5 + (this.slotIndex) << 2) + 16 + 8 + 20;
            mem2[0] = (R5 + (this.slotIndex) << 2) + 16 + 8 + 24;
            mem2[0] = (R5 + (this.slotIndex) << 2) + 16 + 8 + 28;
            goto label_11;
            label_6:
            var val_4 = val_1 - 5;
            if(val_1 > 4)
            {
                    val_28 = Spine.Animation.BinarySearch(values:  this.frames, target:  this.frames[val_4], step:  val_28);
                val_4 = val_28 - 4;
                float val_31 = this.frames[val_28];
                float val_32 = this.frames[val_28 - 5];
                val_32 = val_32 - val_31;
                val_32 = (val_28 - val_31) / val_32;
                val_32 = 1f - val_32;
                float val_11 = this.GetCurvePercent(frameIndex:  858993458, percent:  val_32);
                val_29 = val_29;
                float val_15 = (this.frames[val_28 + 1]) - this.frames[val_4];
                float val_16 = (this.frames[val_28 + 2]) - (this.frames[val_28 - 3]);
                float val_18 = (this.frames[val_28 + 3]) - (this.frames[val_28 - 2]);
                float val_36 = this.frames[val_28 + 4];
                val_36 = val_36 - (this.frames[val_28 - 1]);
            }
            else
            {
                    val_36 = val_4;
                val_32 = this.frames[val_4 - 4];
                val_28 = val_4 - 2;
                val_33 = this.frames[val_4 - 3];
                val_4 = val_4 - 1;
                val_34 = this.frames[val_28];
                val_35 = this.frames[val_4];
            }
            
            if(val_36 != val_4)
            {
                goto label_29;
            }
            
            if(((R5 + (this.slotIndex) << 2) + 16) == 0)
            {
                goto label_30;
            }
            
            mem2[0] = val_32;
            mem2[0] = val_33;
            mem2[0] = val_34;
            goto label_31;
            label_29:
            if(val_2 == 0)
            {
                goto label_33;
            }
            
            val_37 = mem[(R5 + (this.slotIndex) << 2) + 16 + 16];
            val_37 = (R5 + (this.slotIndex) << 2) + 16 + 16;
            if(((R5 + (this.slotIndex) << 2) + 16) == 0)
            {
                goto label_34;
            }
            
            val_38 = mem[(R5 + (this.slotIndex) << 2) + 16 + 20];
            val_38 = (R5 + (this.slotIndex) << 2) + 16 + 20;
            val_39 = mem[(R5 + (this.slotIndex) << 2) + 16 + 24];
            val_39 = (R5 + (this.slotIndex) << 2) + 16 + 24;
            goto label_35;
            label_8:
            var val_37 = (R5 + (this.slotIndex) << 2) + 16 + 8 + 20;
            val_37 = ((R5 + (this.slotIndex) << 2) + 16 + 16) - val_37;
            mem2[0] = (R5 + (this.slotIndex) << 2) + 16 + 16;
            var val_38 = (R5 + (this.slotIndex) << 2) + 16 + 8 + 24;
            val_38 = ((R5 + (this.slotIndex) << 2) + 16 + 20) - val_38;
            mem2[0] = (R5 + (this.slotIndex) << 2) + 16 + 20;
            var val_39 = (R5 + (this.slotIndex) << 2) + 16 + 8 + 28;
            val_39 = ((R5 + (this.slotIndex) << 2) + 16 + 24) - val_39;
            mem2[0] = (R5 + (this.slotIndex) << 2) + 16 + 24;
            var val_40 = (R5 + (this.slotIndex) << 2) + 16 + 8 + 32;
            val_40 = ((R5 + (this.slotIndex) << 2) + 16 + 28) - val_40;
            mem2[0] = (R5 + (this.slotIndex) << 2) + 16 + 28;
            return;
            label_30:
            mem[16] = val_32;
            mem[20] = val_33;
            mem[24] = val_34;
            label_31:
            mem2[0] = val_35;
            return;
            label_33:
            val_40 = mem[(R5 + (this.slotIndex) << 2) + 16 + 8];
            val_40 = (R5 + (this.slotIndex) << 2) + 16 + 8;
            if(val_40 == 0)
            {
                goto label_42;
            }
            
            val_37 = mem[(R5 + (this.slotIndex) << 2) + 16 + 8 + 20];
            val_37 = (R5 + (this.slotIndex) << 2) + 16 + 8 + 20;
            goto label_43;
            label_10:
            mem2[0] = mem[20];
            mem2[0] = mem[24];
            mem2[0] = 52;
            label_11:
            mem2[0] = (R5 + (this.slotIndex) << 2) + 16 + 8 + 32;
            return;
            label_34:
            val_38 = mem[20];
            val_39 = mem[24];
            label_35:
            val_41 = ((R5 + (this.slotIndex) << 2) + 16) + 28;
            goto label_45;
            label_42:
            val_37 = mem[(R5 + (this.slotIndex) << 2) + 16 + 8 + 20];
            val_37 = (R5 + (this.slotIndex) << 2) + 16 + 8 + 20;
            val_40 = mem[(R5 + (this.slotIndex) << 2) + 16 + 8];
            val_40 = (R5 + (this.slotIndex) << 2) + 16 + 8;
            if(val_40 == 0)
            {
                goto label_46;
            }
            
            label_43:
            val_38 = mem[(R5 + (this.slotIndex) << 2) + 16 + 8 + 24];
            val_38 = (R5 + (this.slotIndex) << 2) + 16 + 8 + 24;
            label_47:
            val_39 = mem[(R5 + (this.slotIndex) << 2) + 16 + 8 + 28];
            val_39 = (R5 + (this.slotIndex) << 2) + 16 + 8 + 28;
            label_49:
            val_41 = val_40 + 32;
            label_45:
            float val_21 = val_33 - val_38;
            float val_22 = val_32 - val_37;
            float val_23 = val_34 - val_39;
            float val_24 = val_35 - val_41;
            mem2[0] = val_37;
            mem2[0] = val_38;
            mem2[0] = val_39;
            mem2[0] = val_41;
            return;
            label_46:
            if(((R5 + (this.slotIndex) << 2) + 16 + 8) != 0)
            {
                goto label_47;
            }
            
            if(((R5 + (this.slotIndex) << 2) + 16 + 8) != 0)
            {
                goto label_49;
            }
            
            goto label_49;
        }
    
    }

}
