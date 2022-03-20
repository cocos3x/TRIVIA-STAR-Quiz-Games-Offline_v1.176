using UnityEngine;

namespace Spine
{
    public class ClippingAttachment : VertexAttachment
    {
        // Fields
        internal Spine.SlotData endSlot;
        
        // Properties
        public Spine.SlotData EndSlot { get; set; }
        
        // Methods
        public Spine.SlotData get_EndSlot()
        {
        
        }
        public void set_EndSlot(Spine.SlotData value)
        {
            this.endSlot = value;
        }
        public ClippingAttachment(string name)
        {
        
        }
    
    }

}
