using UnityEngine;

namespace Spine.Unity
{
    public class MeshRendererBuffers : IDisposable
    {
        // Fields
        private Spine.Unity.DoubleBuffered<Spine.Unity.MeshRendererBuffers.SmartMesh> doubleBufferedMesh;
        internal readonly Spine.ExposedList<UnityEngine.Material> submeshMaterials;
        internal UnityEngine.Material[] sharedMaterials;
        
        // Methods
        public void Initialize()
        {
            Spine.Unity.DoubleBuffered<System.Object> val_1 = new Spine.Unity.DoubleBuffered<System.Object>();
            this.doubleBufferedMesh = null;
        }
        public UnityEngine.Material[] GetUpdatedShaderdMaterialsArray()
        {
            if(R6 == true)
            {
                    this.submeshMaterials.CopyTo(array:  this.sharedMaterials);
                return;
            }
            
            T[] val_1 = this.submeshMaterials.ToArray();
            this.sharedMaterials = this.submeshMaterials;
        }
        public bool MaterialsChangedInLastUpdate()
        {
            var val_1 = 1;
            if(R7 != R1)
            {
                    return (bool)val_1;
            }
            
            if(R7 < 1)
            {
                goto label_4;
            }
            
            var val_1 = 0;
            label_9:
            if((mem[this.sharedMaterials + 0]) != null)
            {
                goto label_8;
            }
            
            val_1 = val_1 + 1;
            if(val_1 < R7)
            {
                goto label_9;
            }
            
            label_4:
            val_1 = 0;
            return (bool)val_1;
            label_8:
            val_1 = 1;
            return (bool)val_1;
        }
        public void UpdateSharedMaterials(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions)
        {
            if(R8 > true)
            {
                    System.Array.Resize<UnityEngine.Texture2D>(array: ref  this.submeshMaterials + 8, newSize:  R8);
            }
            
            mem2[0] = ???;
            if(R8 < 1)
            {
                    return;
            }
            
            var val_2 = R7 + 16;
            var val_3 = SL + 28;
            do
            {
                mem2[0] = val_3;
                this = 0 + 1;
                val_3 = val_3 + 40;
            }
            while(R8 != this);
        
        }
        public Spine.Unity.MeshRendererBuffers.SmartMesh GetNextMesh()
        {
            if(this.doubleBufferedMesh != 0)
            {
                    return this.doubleBufferedMesh.GetNext();
            }
            
            return this.doubleBufferedMesh.GetNext();
        }
        public void Clear()
        {
            this.sharedMaterials = null;
            this.submeshMaterials.Clear(clearArray:  true);
        }
        public void Dispose()
        {
            if(this.doubleBufferedMesh == 0)
            {
                    return;
            }
            
            SmartMesh val_1 = this.doubleBufferedMesh.GetNext();
            this.doubleBufferedMesh.Dispose();
            SmartMesh val_2 = this.doubleBufferedMesh.GetNext();
            this.doubleBufferedMesh.Dispose();
            this.doubleBufferedMesh = 0;
        }
        public MeshRendererBuffers()
        {
            Spine.ExposedList<UnityEngine.Material> val_1 = new Spine.ExposedList<UnityEngine.Material>();
            this.submeshMaterials = null;
            this.sharedMaterials = null;
        }
    
    }

}
