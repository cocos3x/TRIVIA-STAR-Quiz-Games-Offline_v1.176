using UnityEngine;

namespace Spine
{
    public class Slot
    {
        // Fields
        internal Spine.SlotData data;
        internal Spine.Bone bone;
        internal float r;
        internal float g;
        internal float b;
        internal float a;
        internal float r2;
        internal float g2;
        internal float b2;
        internal bool hasSecondColor;
        internal Spine.Attachment attachment;
        internal float attachmentTime;
        internal Spine.ExposedList<float> attachmentVertices;
        
        // Properties
        public Spine.SlotData Data { get; }
        public Spine.Bone Bone { get; }
        public Spine.Skeleton Skeleton { get; }
        public float R { get; set; }
        public float G { get; set; }
        public float B { get; set; }
        public float A { get; set; }
        public float R2 { get; set; }
        public float G2 { get; set; }
        public float B2 { get; set; }
        public bool HasSecondColor { get; set; }
        public Spine.Attachment Attachment { get; set; }
        public float AttachmentTime { get; set; }
        public Spine.ExposedList<float> AttachmentVertices { get; set; }
        
        // Methods
        public Spine.SlotData get_Data()
        {
        
        }
        public Spine.Bone get_Bone()
        {
        
        }
        public Spine.Skeleton get_Skeleton()
        {
            if(this.bone != 0)
            {
                    return;
            }
        
        }
        public float get_R()
        {
            return (float)S0;
        }
        public void set_R(float value)
        {
            this.r = ;
        }
        public float get_G()
        {
            return (float)S0;
        }
        public void set_G(float value)
        {
            this.g = ;
        }
        public float get_B()
        {
            return (float)S0;
        }
        public void set_B(float value)
        {
            this.b = ;
        }
        public float get_A()
        {
            return (float)S0;
        }
        public void set_A(float value)
        {
            this.a = ;
        }
        public float get_R2()
        {
            return (float)S0;
        }
        public void set_R2(float value)
        {
            this.r2 = ;
        }
        public float get_G2()
        {
            return (float)S0;
        }
        public void set_G2(float value)
        {
            this.g2 = ;
        }
        public float get_B2()
        {
            return (float)S0;
        }
        public void set_B2(float value)
        {
            this.b2 = ;
        }
        public bool get_HasSecondColor()
        {
            if(this.data != 0)
            {
                    return (bool)this.data.hasSecondColor;
            }
            
            return (bool)this.data.hasSecondColor;
        }
        public void set_HasSecondColor(bool value)
        {
            this.data.hasSecondColor = value;
        }
        public Spine.Attachment get_Attachment()
        {
        
        }
        public void set_Attachment(Spine.Attachment value)
        {
            if(this.attachment == value)
            {
                    return;
            }
            
            this.attachment = value;
            this.attachmentTime = this.bone.skeleton.time;
            this.attachmentVertices.Clear(clearArray:  false);
        }
        public float get_AttachmentTime()
        {
            float val_1 = this.attachmentTime;
            val_1 = this.bone.skeleton.time - val_1;
            return (float)val_1;
        }
        public void set_AttachmentTime(float value)
        {
            float val_1 = this.bone.skeleton.time;
            val_1 = val_1 - R1;
            this.attachmentTime = val_1;
        }
        public Spine.ExposedList<float> get_AttachmentVertices()
        {
        
        }
        public void set_AttachmentVertices(Spine.ExposedList<float> value)
        {
            this.attachmentVertices = value;
        }
        public Slot(Spine.SlotData data, Spine.Bone bone)
        {
            System.ArgumentNullException val_4;
            var val_5;
            var val_6;
            Spine.ExposedList<System.Single> val_1 = new Spine.ExposedList<System.Single>();
            this.attachmentVertices = null;
            val_2 = new System.Object();
            if(data == 0)
            {
                goto label_1;
            }
            
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            this.data = data;
            this.bone = val_2;
            this.SetToSetupPose();
            return;
            label_1:
            val_4 = null;
            val_5 = "data";
            val_6 = "data cannot be null.";
            goto label_3;
            label_2:
            val_4 = null;
            val_5 = "bone";
            val_6 = "bone cannot be null.";
            label_3:
            val_4 = new System.ArgumentNullException(paramName:  1956389680, message:  1962794368);
        }
        public void SetToSetupPose()
        {
            Spine.SlotData val_2;
            Spine.SlotData val_3;
            val_2 = this.data;
            if(val_2 == 0)
            {
                goto label_0;
            }
            
            this.r = this.data.r;
            goto label_1;
            label_0:
            this.r = this.data.r;
            if(this.data == 0)
            {
                goto label_2;
            }
            
            val_2 = this.data;
            label_1:
            this.g = this.data.g;
            label_8:
            this.b = this.data.b;
            label_10:
            this.a = this.data.a;
            label_11:
            if(this.data.attachmentName == null)
            {
                goto label_3;
            }
            
            this.attachment = 0;
            val_3 = this.data;
            if(this.data != 0)
            {
                goto label_5;
            }
            
            val_3 = this.data;
            if(val_3 == 0)
            {
                goto label_6;
            }
            
            label_5:
            Spine.Attachment val_1 = this.bone.skeleton.GetAttachment(slotIndex:  this.data.index, attachmentName:  this.data.attachmentName);
            this.Attachment = this.bone.skeleton;
            return;
            label_3:
            this.Attachment = 0;
            return;
            label_2:
            this.g = this.data.g;
            if(this.data != 0)
            {
                goto label_8;
            }
            
            this.b = this.data.b;
            if(this.data == 0)
            {
                goto label_9;
            }
            
            goto label_10;
            label_9:
            this.a = this.data.a;
            if(this.data != 0)
            {
                goto label_11;
            }
            
            label_6:
        }
        public override string ToString()
        {
            if(this.data != 0)
            {
                    return;
            }
        
        }
    
    }

}
