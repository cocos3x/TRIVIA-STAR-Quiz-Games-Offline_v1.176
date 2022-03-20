using UnityEngine;
public class MeshRendererBuffers.SmartMesh : IDisposable
{
    // Fields
    public UnityEngine.Mesh mesh;
    public Spine.Unity.SkeletonRendererInstruction instructionUsed;
    
    // Methods
    public void Dispose()
    {
        if(this.mesh != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.mesh);
        }
        
        this.mesh = 0;
    }
    public MeshRendererBuffers.SmartMesh()
    {
        UnityEngine.Mesh val_1 = Spine.Unity.SpineMesh.NewMesh();
        this.mesh = 0;
        this.instructionUsed = new Spine.Unity.SkeletonRendererInstruction();
    }

}
