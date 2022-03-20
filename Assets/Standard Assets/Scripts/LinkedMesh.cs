using UnityEngine;
internal class SkeletonJson.LinkedMesh
{
    // Fields
    internal string parent;
    internal string skin;
    internal int slotIndex;
    internal Spine.MeshAttachment mesh;
    
    // Methods
    public SkeletonJson.LinkedMesh(Spine.MeshAttachment mesh, string skin, int slotIndex, string parent)
    {
        val_1 = new System.Object();
        this.parent = parent;
        this.skin = val_1;
        this.slotIndex = slotIndex;
        this.mesh = mesh;
    }

}
