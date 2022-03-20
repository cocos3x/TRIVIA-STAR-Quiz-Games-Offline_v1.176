using UnityEngine;

namespace Spine.Unity
{
    public struct SubmeshInstruction
    {
        // Fields
        public Spine.Skeleton skeleton;
        public int startSlot;
        public int endSlot;
        public UnityEngine.Material material;
        public bool forceSeparate;
        public int preActiveClippingSlotSource;
        public int rawTriangleCount;
        public int rawVertexCount;
        public int rawFirstVertexIndex;
        public bool hasClipping;
        
        // Properties
        public int SlotCount { get; }
        
        // Methods
        public int get_SlotCount()
        {
            int val_1 = this.endSlot;
            val_1 = val_1 - this.startSlot;
            return (int)val_1;
        }
    
    }

}
