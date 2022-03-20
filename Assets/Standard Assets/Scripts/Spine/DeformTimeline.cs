using UnityEngine;

namespace Spine
{
    public class DeformTimeline : CurveTimeline
    {
        // Fields
        internal int slotIndex;
        internal float[] frames;
        internal float[][] frameVertices;
        internal Spine.VertexAttachment attachment;
        
        // Properties
        public int SlotIndex { get; set; }
        public float[] Frames { get; set; }
        public float[][] Vertices { get; set; }
        public Spine.VertexAttachment Attachment { get; set; }
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
        public float[][] get_Vertices()
        {
        
        }
        public void set_Vertices(float[][] value)
        {
            this.frameVertices = value;
        }
        public Spine.VertexAttachment get_Attachment()
        {
        
        }
        public void set_Attachment(Spine.VertexAttachment value)
        {
            this.attachment = value;
        }
        public override int get_PropertyId()
        {
            int val_1 = this.slotIndex;
            val_1 = this.attachment.id + val_1;
            val_1 = val_1 + 100663296;
            return (int)val_1;
        }
        public DeformTimeline(int frameCount)
        {
            this.frames = null;
            this.frameVertices = null;
        }
        public void SetFrame(int frameIndex, float time, float[] vertices)
        {
            this.frames[frameIndex] = vertices;
            this.frameVertices[frameIndex] = R3;
        }
        public override void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_1;
            var val_2;
            System.Single[] val_35;
            System.Single[] val_36;
            var val_37;
            var val_38;
            System.Array val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            val_35 = this;
            val_36 = val_1;
            val_37 = pose;
            Spine.ExposedList<Spine.Slot> val_3 = skeleton.slots + (this.slotIndex << 2);
            val_38 = mem[this.slotIndex + 48];
            val_38 = this.slotIndex + 48;
            if(val_38 == 0)
            {
                    return;
            }
            
            if(((this.slotIndex + 48 + 100 + (Spine.VertexAttachment.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_38 = 0;
            }
            
            if(val_38 == 0)
            {
                    return;
            }
            
            val_39 = mem[this.slotIndex + 56];
            val_39 = this.slotIndex + 56;
            System.Single[] val_35 = this.frameVertices[0];
            if(val_39 != 0)
            {
                    val_40 = val_39;
                var val_36 = this.slotIndex + 56 + 12;
                if(val_36 == val_35)
            {
                    1f = val_2;
            }
            
                val_36 = val_36 >> 5;
                if(val_36 == 0)
            {
                    val_41 = val_2;
            }
            
            }
            else
            {
                    val_40 = 12;
                if(0 == val_35)
            {
                    1f = val_2;
            }
            
                if(val_36 == 0)
            {
                    val_41 = val_2;
            }
            
            }
            
            if(val_39.Capacity < val_35)
            {
                    val_39.Capacity = val_35;
            }
            
            if(val_39 != 0)
            {
                    mem[12] = val_35;
            }
            else
            {
                    mem[12] = val_35;
            }
            
            float val_37 = this.frames[0];
            if((this.slotIndex + 56 + 8) <= 0)
            {
                goto label_22;
            }
            
            if(0 == 0)
            {
                goto label_23;
            }
            
            val_39.Clear(clearArray:  true);
            return;
            label_22:
            var val_5 = (this.slotIndex + 56 + 8) - 1;
            val_36 = val_35;
            if((this.slotIndex + 56 + 8) <= 0)
            {
                goto label_25;
            }
            
            int val_6 = Spine.Animation.BinarySearch(values:  this.frames, target:  this.frames[val_5]);
            int val_7 = val_6 - 1;
            val_42 = mem[this.frameVertices + 12];
            val_42 = this.frameVertices + 12;
            if(val_42 <= val_7)
            {
                    val_42 = mem[this.frameVertices + 12];
                val_42 = this.frameVertices + 12;
            }
            
            System.Single[][] val_8 = this.frameVertices + (val_7 << 2);
            val_37 = mem[(this.frameVertices + ((val_6 - 1)) << 2) + 16];
            val_37 = (this.frameVertices + ((val_6 - 1)) << 2) + 16;
            System.Single[][] val_39 = this.frameVertices;
            val_39 = val_39 + (val_6 << 2);
            val_39 = mem[(this.frameVertices + (val_6) << 2) + 16];
            val_39 = (this.frameVertices + (val_6) << 2) + 16;
            float val_40 = this.frames[val_6];
            float val_41 = this.frames[val_7];
            val_41 = val_41 - val_40;
            val_41 = (val_37 - val_40) / val_41;
            val_41 = 1f - val_41;
            float val_10 = val_35.GetCurvePercent(frameIndex:  val_7, percent:  val_41);
            val_36 = val_35;
            if(val_42 != val_7)
            {
                goto label_30;
            }
            
            if(val_36 < 1)
            {
                    return;
            }
            
            var val_11 = val_39 + 16;
            var val_12 = val_37 + 16;
            var val_13 = (this.slotIndex + 56 + 8) + 16;
            do
            {
                val_44 = this.slotIndex + 56 + 8;
                if(val_44 == 0)
            {
                    val_44 = this.slotIndex + 56 + 8;
            }
            
                float val_14 = val_11 - val_12;
                val_38 = 0 + 1;
                val_11 = val_11 + 4;
                val_35 = val_12 + 4;
            }
            while(val_36 != val_38);
            
            return;
            label_23:
            val_35 = val_35;
            if(val_36 != 1)
            {
                    return;
            }
            
            if(val_35 < 1)
            {
                    return;
            }
            
            var val_42 = 0;
            val_41 = 1f - val_41;
            do
            {
                val_45 = this.slotIndex + 56 + 8;
                if(val_45 == 0)
            {
                    val_45 = this.slotIndex + 56 + 8;
            }
            
                var val_43 = (this.slotIndex + 56 + 8) + 16;
                val_42 = val_42 + 1;
                val_43 = val_41 * val_43;
            }
            while(val_35 != val_42);
            
            return;
            label_25:
            val_5 = this.frames[val_5] - 1;
            this.frames[val_5] = this.frameVertices + (val_5 << 2);
            val_39 = mem[(this.frameVertices + ((this.frames[(this.slotIndex + 56 + 8 - 1)] - 1)) << 2) + 16];
            val_39 = (this.frameVertices + ((this.frames[(this.slotIndex + 56 + 8 - 1)] - 1)) << 2) + 16;
            if((this.frameVertices + 12) != val_5)
            {
                goto label_47;
            }
            
            System.Array.Copy(sourceArray:  val_39, sourceIndex:  0, destinationArray:  this.slotIndex + 56 + 8, destinationIndex:  0, length:  val_36);
            return;
            label_30:
            if(0 == 0)
            {
                goto label_48;
            }
            
            if(2621443 == 0)
            {
                goto label_49;
            }
            
            if(val_36 < 1)
            {
                    return;
            }
            
            float val_16 = val_37 + 16;
            var val_17 = val_39 + 16;
            var val_45 = 0;
            var val_18 = (this.slotIndex + 56 + 8) + 16;
            do
            {
                float val_44 = val_16;
                val_46 = this.slotIndex + 56 + 8;
                if(val_46 == 0)
            {
                    val_46 = this.slotIndex + 56 + 8;
            }
            
                float val_19 = val_17 - val_44;
                val_44 = val_41 * val_44;
                mem2[0] = val_44;
                val_45 = val_45 + 1;
                val_16 = val_16 + 4;
                val_17 = val_17 + 4;
                val_18 = val_18 + 4;
            }
            while(val_36 != val_45);
            
            return;
            label_47:
            if(0 == 0)
            {
                goto label_59;
            }
            
            if(2621443 == 0)
            {
                goto label_60;
            }
            
            if(val_36 < 1)
            {
                    return;
            }
            
            var val_20 = val_39 + 16;
            var val_47 = 0;
            var val_21 = (this.slotIndex + 56 + 8) + 16;
            do
            {
                val_47 = this.slotIndex + 56 + 8;
                var val_46 = val_20;
                if(val_47 == 0)
            {
                    val_47 = this.slotIndex + 56 + 8;
            }
            
                val_46 = val_41 * val_46;
                val_47 = val_47 + 1;
                val_20 = val_20 + 4;
            }
            while(val_36 != val_47);
            
            return;
            label_48:
            if(val_36 < 1)
            {
                    return;
            }
            
            var val_22 = val_37 + 16;
            var val_23 = val_39 + 16;
            var val_48 = 0;
            float val_24 = (this.slotIndex + 56 + 8) + 16;
            do
            {
                val_48 = this.slotIndex + 56 + 8;
                if(val_48 == 0)
            {
                    val_48 = this.slotIndex + 56 + 8;
            }
            
                float val_25 = val_23 - val_22;
                val_48 = val_48 + 1;
                val_22 = val_22 + 4;
                val_23 = val_23 + 4;
                var val_49 = val_24;
                val_49 = val_22 - val_49;
                mem2[0] = val_24;
                val_24 = val_24 + 4;
            }
            while(val_36 != val_48);
            
            return;
            label_59:
            if(val_36 < 1)
            {
                    return;
            }
            
            var val_26 = val_39 + 16;
            var val_50 = 0;
            float val_27 = (this.slotIndex + 56 + 8) + 16;
            do
            {
                val_49 = this.slotIndex + 56 + 8;
                if(val_49 == 0)
            {
                    val_49 = this.slotIndex + 56 + 8;
            }
            
                var val_51 = val_27;
                val_50 = val_50 + 1;
                val_26 = val_26 + 4;
                val_51 = val_26 - val_51;
                mem2[0] = val_27;
                val_27 = val_27 + 4;
            }
            while(val_36 != val_50);
            
            return;
            label_49:
            if(val_36 < 1)
            {
                    return;
            }
            
            var val_28 = val_39 + 16;
            var val_52 = this.slotIndex + 56 + 8;
            var val_29 = val_37 + 16;
            var val_54 = 17;
            var val_53 = 0;
            val_52 = val_52 + 16;
            do
            {
                val_50 = 1;
                if(val_50 == 0)
            {
                    val_50 = 1;
            }
            
                val_51 = this.slotIndex + 56 + 8;
                if(val_51 == 0)
            {
                    val_51 = this.slotIndex + 56 + 8;
            }
            
                float val_30 = val_28 - val_29;
                float val_31 = val_29 - (2.353859E-38f);
                val_53 = val_53 + 1;
                val_28 = val_28 + 4;
                val_54 = val_54 + 4;
                val_29 = val_29 + 4;
            }
            while(val_36 != val_53);
            
            return;
            label_60:
            if(val_36 < 1)
            {
                    return;
            }
            
            var val_32 = val_39 + 16;
            var val_55 = 0;
            var val_56 = 17;
            var val_33 = (this.slotIndex + 56 + 8) + 16;
            do
            {
                val_52 = this.slotIndex + 56 + 8;
                if(val_52 == 0)
            {
                    val_52 = this.slotIndex + 56 + 8;
            }
            
                float val_34 = val_32 - (2.353859E-38f);
                val_55 = val_55 + 1;
                val_32 = val_32 + 4;
                val_56 = val_56 + 4;
            }
            while(val_36 != val_55);
        
        }
    
    }

}
