using UnityEngine;

namespace Spine
{
    public class TwoColorTimeline : CurveTimeline
    {
        // Fields
        public const int ENTRIES = 8;
        protected const int PREV_TIME = -8;
        protected const int PREV_R = -7;
        protected const int PREV_G = -6;
        protected const int PREV_B = -5;
        protected const int PREV_A = -4;
        protected const int PREV_R2 = -3;
        protected const int PREV_G2 = -2;
        protected const int PREV_B2 = -1;
        protected const int R = 1;
        protected const int G = 2;
        protected const int B = 3;
        protected const int A = 4;
        protected const int R2 = 5;
        protected const int G2 = 6;
        protected const int B2 = 7;
        internal float[] frames;
        internal int slotIndex;
        
        // Properties
        public float[] Frames { get; }
        public int SlotIndex { get; set; }
        public override int PropertyId { get; }
        
        // Methods
        public float[] get_Frames()
        {
        
        }
        public int get_SlotIndex()
        {
            return (int)this.slotIndex;
        }
        public void set_SlotIndex(int value)
        {
            if(value > 1)
            {
                    this.slotIndex = value;
                return;
            }
            
            System.ArgumentOutOfRangeException val_1 = new System.ArgumentOutOfRangeException(paramName:  1850229984);
        }
        public override int get_PropertyId()
        {
            int val_1 = this.slotIndex;
            val_1 = val_1 + 234881024;
            return (int)val_1;
        }
        public TwoColorTimeline(int frameCount)
        {
            int val_1 = frameCount << 3;
            this.frames = null;
        }
        public void SetFrame(int frameIndex, float time, float r, float g, float b, float a, float r2, float g2, float b2)
        {
            float val_4;
            float val_6;
            float val_8;
            float val_10;
            float val_12;
            float val_14;
            int val_1 = frameIndex << 3;
            this.frames[val_1] = R2;
            this.frames[val_1 | 1] = R3;
            this.frames[val_1 | 2] = val_4;
            this.frames[val_1 | 3] = val_6;
            this.frames[val_1 | 4] = val_8;
            this.frames[val_1 | 5] = val_10;
            this.frames[val_1 | 6] = val_12;
            this.frames[val_1 | 7] = val_14;
        }
        public override void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_2;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            float val_46;
            float val_47;
            float val_48;
            float val_49;
            float val_50;
            float val_51;
            float val_52;
            var val_53;
            float val_54;
            float val_55;
            float val_56;
            float val_57;
            float val_58;
            float val_59;
            var val_60;
            float val_61;
            val_42 = this;
            float val_38 = this.frames[0];
            if((R6 + (this.slotIndex << 2)) <= 0)
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
            
            if(((R6 + (this.slotIndex) << 2) + 16 + 8) == 0)
            {
                goto label_10;
            }
            
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 8 + 20;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 8 + 24;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 8 + 28;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 8 + 32;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 8 + 36;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 8 + 40;
            goto label_11;
            label_6:
            var val_4 = (this.frames + 12) - 8;
            if((this.frames + 12) > 7)
            {
                    int val_5 = Spine.Animation.BinarySearch(values:  this.frames, target:  this.frames[val_4], step:  pose);
                var val_56 = val_5;
                val_4 = val_56 - 7;
                if(val_5 <= val_4)
            {
                    val_44 = mem[this.frames + 12];
                val_44 = this.frames + 12;
            }
            
                int val_6 = val_56 - 6;
                float val_40 = this.frames[val_4];
                if(val_44 <= val_6)
            {
                    val_44 = mem[this.frames + 12];
                val_44 = this.frames + 12;
            }
            
                int val_7 = val_56 - 5;
                if(val_44 <= val_7)
            {
                    val_44 = mem[this.frames + 12];
                val_44 = this.frames + 12;
            }
            
                int val_8 = val_56 - 4;
                if(val_44 <= val_8)
            {
                    val_44 = mem[this.frames + 12];
                val_44 = this.frames + 12;
            }
            
                int val_9 = val_56 - 3;
                if(val_44 <= val_9)
            {
                    val_44 = mem[this.frames + 12];
                val_44 = this.frames + 12;
            }
            
                int val_10 = val_56 - 2;
                if(val_44 <= val_10)
            {
                    val_44 = mem[this.frames + 12];
                val_44 = this.frames + 12;
            }
            
                int val_11 = val_56 - 1;
                if(val_44 <= val_11)
            {
                    val_44 = mem[this.frames + 12];
                val_44 = this.frames + 12;
            }
            
                if(val_44 <= val_56)
            {
                    val_44 = mem[this.frames + 12];
                val_44 = this.frames + 12;
            }
            
                float val_47 = this.frames[val_56];
                int val_49 = 0;
                float val_48 = this.frames[val_56 - 8];
                int val_14 = val_56 >> 31;
                val_14 = val_56 + (val_14 >> 29);
                val_48 = val_48 - val_47;
                val_49 = val_49 + (val_14 >> 3);
                val_48 = (pose - val_47) / val_48;
                val_48 = 1f - val_48;
                float val_15 = this.GetCurvePercent(frameIndex:  val_49, percent:  val_48);
                val_42 = val_42;
                int val_16 = val_56 + 1;
                if(val_42 <= val_16)
            {
                    val_45 = mem[this.frames + 12];
                val_45 = this.frames + 12;
            }
            
                var val_55 = val_40;
                int val_17 = val_56 + 2;
                if(val_45 <= val_17)
            {
                    val_45 = mem[this.frames + 12];
                val_45 = this.frames + 12;
            }
            
                int val_18 = val_56 + 3;
                if(val_45 <= val_18)
            {
                    val_45 = mem[this.frames + 12];
                val_45 = this.frames + 12;
            }
            
                int val_19 = val_56 + 4;
                if(val_45 <= val_19)
            {
                    val_45 = mem[this.frames + 12];
                val_45 = this.frames + 12;
            }
            
                int val_20 = val_56 + 5;
                if(val_45 <= val_20)
            {
                    val_45 = mem[this.frames + 12];
                val_45 = this.frames + 12;
            }
            
                val_43 = val_56 + 6;
                if(val_45 <= val_43)
            {
                    val_45 = mem[this.frames + 12];
                val_45 = this.frames + 12;
            }
            
                val_55 = this.frames[val_16] - val_55;
                val_56 = val_56 + 7;
                float val_21 = this.frames[val_17] - this.frames[val_6];
                float val_22 = this.frames[val_18] - this.frames[val_7];
                float val_23 = this.frames[val_19] - this.frames[val_8];
                float val_24 = this.frames[val_20] - this.frames[val_9];
                float val_25 = this.frames[val_43] - this.frames[val_10];
                float val_58 = this.frames[val_56];
                val_50 = val_40;
                val_58 = val_58 - this.frames[val_11];
            }
            else
            {
                    var val_59 = this.frames + 12;
                val_53 = val_59;
                if(val_59 <= 6)
            {
                    val_53 = mem[this.frames + 12];
                val_53 = this.frames + 12;
            }
            
                var val_27 = val_59 - 6;
                val_50 = this.frames[val_59 - 7];
                if(val_53 <= val_27)
            {
                    val_53 = mem[this.frames + 12];
                val_53 = this.frames + 12;
            }
            
                var val_28 = val_59 - 5;
                val_51 = this.frames[val_27];
                if(val_53 <= val_28)
            {
                    val_53 = mem[this.frames + 12];
                val_53 = this.frames + 12;
            }
            
                var val_29 = val_59 - 4;
                val_46 = this.frames[val_28];
                if(val_53 <= val_29)
            {
                    val_53 = mem[this.frames + 12];
                val_53 = this.frames + 12;
            }
            
                var val_30 = val_59 - 3;
                val_47 = this.frames[val_29];
                if(val_53 <= val_30)
            {
                    val_53 = mem[this.frames + 12];
                val_53 = this.frames + 12;
            }
            
                val_43 = val_59 - 2;
                val_48 = this.frames[val_30];
                if(val_53 <= val_43)
            {
                    val_53 = mem[this.frames + 12];
                val_53 = this.frames + 12;
            }
            
                val_59 = val_59 - 1;
                val_49 = this.frames[val_43];
                val_52 = this.frames[val_59];
            }
            
            if(val_53 != val_59)
            {
                goto label_38;
            }
            
            if(((R6 + (this.slotIndex) << 2) + 16) == 0)
            {
                goto label_39;
            }
            
            mem2[0] = val_50;
            mem2[0] = val_51;
            mem2[0] = val_46;
            mem2[0] = val_47;
            mem2[0] = val_48;
            mem2[0] = val_49;
            goto label_40;
            label_38:
            if(val_2 == 0)
            {
                goto label_42;
            }
            
            val_54 = mem[(R6 + (this.slotIndex) << 2) + 16 + 16];
            val_54 = (R6 + (this.slotIndex) << 2) + 16 + 16;
            if(((R6 + (this.slotIndex) << 2) + 16) == 0)
            {
                goto label_43;
            }
            
            val_55 = mem[(R6 + (this.slotIndex) << 2) + 16 + 20];
            val_55 = (R6 + (this.slotIndex) << 2) + 16 + 20;
            val_56 = mem[(R6 + (this.slotIndex) << 2) + 16 + 24];
            val_56 = (R6 + (this.slotIndex) << 2) + 16 + 24;
            val_57 = mem[(R6 + (this.slotIndex) << 2) + 16 + 28];
            val_57 = (R6 + (this.slotIndex) << 2) + 16 + 28;
            val_58 = mem[(R6 + (this.slotIndex) << 2) + 16 + 32];
            val_58 = (R6 + (this.slotIndex) << 2) + 16 + 32;
            val_59 = mem[(R6 + (this.slotIndex) << 2) + 16 + 36];
            val_59 = (R6 + (this.slotIndex) << 2) + 16 + 36;
            goto label_44;
            label_8:
            var val_60 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 20;
            val_60 = ((R6 + (this.slotIndex) << 2) + 16 + 16) - val_60;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 16;
            var val_61 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 24;
            val_61 = ((R6 + (this.slotIndex) << 2) + 16 + 20) - val_61;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 20;
            var val_62 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 28;
            val_62 = ((R6 + (this.slotIndex) << 2) + 16 + 24) - val_62;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 24;
            var val_63 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 32;
            val_63 = ((R6 + (this.slotIndex) << 2) + 16 + 28) - val_63;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 28;
            var val_64 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 36;
            val_64 = ((R6 + (this.slotIndex) << 2) + 16 + 32) - val_64;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 32;
            var val_65 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 40;
            val_65 = ((R6 + (this.slotIndex) << 2) + 16 + 36) - val_65;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 36;
            var val_66 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 44;
            val_66 = ((R6 + (this.slotIndex) << 2) + 16 + 40) - val_66;
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 40;
            return;
            label_39:
            mem[16] = val_50;
            mem[20] = val_51;
            mem[24] = val_46;
            mem[28] = val_47;
            mem[32] = val_48;
            mem[36] = val_49;
            label_40:
            mem2[0] = val_52;
            return;
            label_42:
            val_60 = mem[(R6 + (this.slotIndex) << 2) + 16 + 8];
            val_60 = (R6 + (this.slotIndex) << 2) + 16 + 8;
            if(val_60 == 0)
            {
                goto label_54;
            }
            
            val_54 = mem[(R6 + (this.slotIndex) << 2) + 16 + 8 + 20];
            val_54 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 20;
            goto label_55;
            label_10:
            mem2[0] = mem[20];
            mem2[0] = mem[24];
            mem2[0] = mem[28];
            mem2[0] = mem[32];
            mem2[0] = mem[36];
            mem2[0] = 2097204;
            label_11:
            mem2[0] = (R6 + (this.slotIndex) << 2) + 16 + 8 + 44;
            return;
            label_43:
            val_55 = mem[20];
            val_56 = mem[24];
            val_57 = mem[28];
            val_58 = mem[32];
            val_59 = mem[36];
            label_44:
            val_61 = ((R6 + (this.slotIndex) << 2) + 16) + 40;
            goto label_57;
            label_54:
            val_54 = mem[(R6 + (this.slotIndex) << 2) + 16 + 8 + 20];
            val_54 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 20;
            val_60 = mem[(R6 + (this.slotIndex) << 2) + 16 + 8];
            val_60 = (R6 + (this.slotIndex) << 2) + 16 + 8;
            if(val_60 == 0)
            {
                goto label_58;
            }
            
            label_55:
            val_55 = mem[(R6 + (this.slotIndex) << 2) + 16 + 8 + 24];
            val_55 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 24;
            label_59:
            val_56 = mem[(R6 + (this.slotIndex) << 2) + 16 + 8 + 28];
            val_56 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 28;
            label_60:
            val_57 = mem[(R6 + (this.slotIndex) << 2) + 16 + 8 + 32];
            val_57 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 32;
            label_61:
            val_58 = mem[(R6 + (this.slotIndex) << 2) + 16 + 8 + 36];
            val_58 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 36;
            label_62:
            val_59 = mem[(R6 + (this.slotIndex) << 2) + 16 + 8 + 40];
            val_59 = (R6 + (this.slotIndex) << 2) + 16 + 8 + 40;
            label_64:
            val_61 = val_60 + 44;
            label_57:
            float val_31 = val_51 - val_55;
            float val_32 = val_50 - val_54;
            float val_33 = val_46 - val_56;
            float val_34 = val_47 - val_57;
            float val_35 = val_48 - val_58;
            float val_36 = val_49 - val_59;
            float val_37 = val_52 - val_61;
            mem2[0] = val_54;
            mem2[0] = val_55;
            mem2[0] = val_56;
            mem2[0] = val_57;
            mem2[0] = val_58;
            mem2[0] = val_59;
            mem2[0] = val_61;
            return;
            label_58:
            if(((R6 + (this.slotIndex) << 2) + 16 + 8) != 0)
            {
                goto label_59;
            }
            
            if(((R6 + (this.slotIndex) << 2) + 16 + 8) != 0)
            {
                goto label_60;
            }
            
            if(((R6 + (this.slotIndex) << 2) + 16 + 8) != 0)
            {
                goto label_61;
            }
            
            if(((R6 + (this.slotIndex) << 2) + 16 + 8) != 0)
            {
                goto label_62;
            }
            
            if(((R6 + (this.slotIndex) << 2) + 16 + 8) != 0)
            {
                goto label_64;
            }
            
            goto label_64;
        }
    
    }

}
