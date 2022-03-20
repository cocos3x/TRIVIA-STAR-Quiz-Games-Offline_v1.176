using UnityEngine;

namespace Spine
{
    public class PointAttachment : Attachment
    {
        // Fields
        internal float x;
        internal float y;
        internal float rotation;
        
        // Properties
        public float X { get; set; }
        public float Y { get; set; }
        public float Rotation { get; set; }
        
        // Methods
        public float get_X()
        {
            return (float)S0;
        }
        public void set_X(float value)
        {
            this.x = ;
        }
        public float get_Y()
        {
            return (float)S0;
        }
        public void set_Y(float value)
        {
            this.y = ;
        }
        public float get_Rotation()
        {
            return (float)S0;
        }
        public void set_Rotation(float value)
        {
            this.rotation = ;
        }
        public PointAttachment(string name)
        {
        
        }
        public void ComputeWorldPosition(Spine.Bone bone, out float ox, out float oy)
        {
            bone.LocalToWorld(localX:  null, localY:  null, worldX: out  this.x, worldY: out  this.y);
        }
        public float ComputeWorldRotation(Spine.Bone bone)
        {
            float val_6;
            float val_2 = Spine.MathUtils.SinDeg(degrees:  Spine.MathUtils.CosDeg(degrees:  null));
            if(bone != 0)
            {
                    float val_3 = this.rotation * bone.b;
                val_6 = bone.c;
            }
            else
            {
                    float val_4 = this.rotation * 0f;
                val_6 = 0f;
            }
            
            float val_6 = bone.d;
            val_6 = this.rotation * val_6;
            float val_5 = Spine.MathUtils.Atan2(y:  val_6, x:  null);
            float val_7 = 57.29578f;
            val_7 = val_6 * val_7;
            return (float)val_7;
        }
    
    }

}
