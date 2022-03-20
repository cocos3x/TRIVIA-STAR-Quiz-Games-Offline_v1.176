using UnityEngine;

namespace Spine
{
    public class PathAttachment : VertexAttachment
    {
        // Fields
        internal float[] lengths;
        internal bool closed;
        internal bool constantSpeed;
        
        // Properties
        public float[] Lengths { get; set; }
        public bool Closed { get; set; }
        public bool ConstantSpeed { get; set; }
        
        // Methods
        public float[] get_Lengths()
        {
        
        }
        public void set_Lengths(float[] value)
        {
            this.lengths = value;
        }
        public bool get_Closed()
        {
            return (bool)this.closed;
        }
        public void set_Closed(bool value)
        {
            this.closed = value;
        }
        public bool get_ConstantSpeed()
        {
            return (bool)this.constantSpeed;
        }
        public void set_ConstantSpeed(bool value)
        {
            this.constantSpeed = value;
        }
        public PathAttachment(string name)
        {
        
        }
    
    }

}
