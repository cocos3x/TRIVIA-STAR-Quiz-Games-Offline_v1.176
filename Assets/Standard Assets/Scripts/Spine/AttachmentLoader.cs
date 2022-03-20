using UnityEngine;

namespace Spine
{
    public interface AttachmentLoader
    {
        // Methods
        public abstract Spine.RegionAttachment NewRegionAttachment(Spine.Skin skin, string name, string path); // 0
        public abstract Spine.MeshAttachment NewMeshAttachment(Spine.Skin skin, string name, string path); // 0
        public abstract Spine.BoundingBoxAttachment NewBoundingBoxAttachment(Spine.Skin skin, string name); // 0
        public abstract Spine.PathAttachment NewPathAttachment(Spine.Skin skin, string name); // 0
        public abstract Spine.PointAttachment NewPointAttachment(Spine.Skin skin, string name); // 0
        public abstract Spine.ClippingAttachment NewClippingAttachment(Spine.Skin skin, string name); // 0
    
    }

}
