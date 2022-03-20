using UnityEngine;

namespace Spine
{
    public class AttachmentTimeline : Timeline
    {
        // Fields
        internal int slotIndex;
        internal float[] frames;
        private string[] attachmentNames;
        
        // Properties
        public int SlotIndex { get; set; }
        public float[] Frames { get; set; }
        public string[] AttachmentNames { get; set; }
        public int FrameCount { get; }
        public int PropertyId { get; }
        
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
        public string[] get_AttachmentNames()
        {
        
        }
        public void set_AttachmentNames(string[] value)
        {
            this.attachmentNames = value;
        }
        public int get_FrameCount()
        {
            if(this.frames != null)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        public int get_PropertyId()
        {
            int val_1 = this.slotIndex;
            val_1 = val_1 + 67108864;
            return (int)val_1;
        }
        public AttachmentTimeline(int frameCount)
        {
            this.frames = null;
            this.attachmentNames = null;
        }
        public void SetFrame(int frameIndex, float time, string attachmentName)
        {
            this.frames[frameIndex] = attachmentName;
            this.attachmentNames[frameIndex] = R3;
        }
        public void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_1;
            var val_2;
            System.Single[] val_8;
            var val_9;
            var val_11;
            Spine.ExposedList<Spine.Slot> val_10 = skeleton.slots;
            Spine.ExposedList<Spine.Slot> val_3 = val_10 + (this.slotIndex << 2);
            if(val_1 == 1)
            {
                goto label_8;
            }
            
            val_8 = this.frames;
            float val_8 = val_8[0];
            if(val_3 <= 0)
            {
                goto label_7;
            }
            
            if(val_2 != 0)
            {
                    return;
            }
            
            label_8:
            if((this.slotIndex + 8 + 52) == 0)
            {
                goto label_11;
            }
            
            Spine.Attachment val_4 = skeleton.GetAttachment(slotIndex:  this.slotIndex, attachmentName:  this.slotIndex + 8 + 52);
            val_9 = skeleton;
            goto label_16;
            label_7:
            if(val_3 <= 0)
            {
                goto label_14;
            }
            
            int val_6 = Spine.Animation.BinarySearch(values:  val_8, target:  val_8[val_3 - 1], step:  pose);
            goto label_15;
            label_11:
            val_9 = 0;
            goto label_16;
            label_14:
            label_15:
            val_10 = (val_8[val_3 - 1]) - 1;
            string val_11 = this.attachmentNames[val_10];
            if(val_11 != null)
            {
                    Spine.Attachment val_7 = skeleton.GetAttachment(slotIndex:  this.slotIndex, attachmentName:  val_11);
                val_11 = skeleton;
            }
            else
            {
                    val_11 = 0;
            }
            
            val_9 = val_11;
            label_16:
            this.slotIndex.Attachment = 0;
        }
    
    }

}
