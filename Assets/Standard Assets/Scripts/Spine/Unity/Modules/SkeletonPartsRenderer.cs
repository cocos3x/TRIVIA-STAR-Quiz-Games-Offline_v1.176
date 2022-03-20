using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SkeletonPartsRenderer : MonoBehaviour
    {
        // Fields
        private Spine.Unity.MeshGenerator meshGenerator;
        private UnityEngine.MeshRenderer meshRenderer;
        private UnityEngine.MeshFilter meshFilter;
        private Spine.Unity.MeshRendererBuffers buffers;
        private Spine.Unity.SkeletonRendererInstruction currentInstructions;
        
        // Properties
        public Spine.Unity.MeshGenerator MeshGenerator { get; }
        public UnityEngine.MeshRenderer MeshRenderer { get; }
        public UnityEngine.MeshFilter MeshFilter { get; }
        
        // Methods
        public Spine.Unity.MeshGenerator get_MeshGenerator()
        {
            this.LazyIntialize();
        }
        public UnityEngine.MeshRenderer get_MeshRenderer()
        {
            this.LazyIntialize();
        }
        public UnityEngine.MeshFilter get_MeshFilter()
        {
            this.LazyIntialize();
        }
        private void LazyIntialize()
        {
            if(this.buffers != 0)
            {
                    return;
            }
            
            this.buffers = new Spine.Unity.MeshRendererBuffers();
            Initialize();
            if(this.meshGenerator != 0)
            {
                    return;
            }
            
            mem2[0] = new Spine.Unity.MeshGenerator();
            object val_3 = R4.GetComponent<System.Object>();
            mem2[0] = R4;
            object val_4 = R4.GetComponent<System.Object>();
            mem2[0] = R4;
            R4 + 28.Clear();
        }
        public void ClearMesh()
        {
            this.LazyIntialize();
            this.meshFilter.sharedMesh = 0;
        }
        public void RenderParts(Spine.ExposedList<Spine.Unity.SubmeshInstruction> instructions, int startSubmesh, int endSubmesh)
        {
            int val_9;
            Spine.Unity.Modules.SkeletonPartsRenderer val_10;
            var val_11;
            Spine.Unity.MeshGenerator val_12;
            Spine.Skeleton val_13;
            int val_14;
            int val_15;
            int val_16;
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_17;
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_18;
            val_9 = startSubmesh;
            val_10 = this;
            this.LazyIntialize();
            SmartMesh val_1 = this.buffers.GetNextMesh();
            this.currentInstructions.SetWithSubset(instructions:  instructions, startSubmesh:  val_9, endSubmesh:  endSubmesh);
            bool val_2 = Spine.Unity.SkeletonRendererInstruction.GeometryNotEqual(a:  this.currentInstructions, b:  this.buffers.submeshMaterials);
            this.meshGenerator.Begin();
            if(this.currentInstructions.hasActiveClipping == false)
            {
                goto label_7;
            }
            
            val_9 = this.currentInstructions.submeshInstructions + 52;
            val_11 = 0;
            goto label_8;
            label_14:
            val_12 = this.meshGenerator;
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_3 = val_9 - 36;
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_4 = val_9 - 20;
            if(val_12 == 0)
            {
                    val_16 = mem[((this.currentInstructions.submeshInstructions + 52) - 20) + (12)];
                val_15 = mem[((this.currentInstructions.submeshInstructions + 52) - 36) + (8)];
                val_17 = null;
                val_18 = null;
                val_14 = mem[((this.currentInstructions.submeshInstructions + 52) - 36) + (4)];
                val_13 = mem[((this.currentInstructions.submeshInstructions + 52) - 36) + (0)];
                val_12 = val_12;
            }
            
            val_12.AddSubmesh(instruction:  new Spine.Unity.SubmeshInstruction() {skeleton = val_13, startSlot = val_14, endSlot = val_15, material = mem[((this.currentInstructions.submeshInstructions + 52) - 36) + (12)], forceSeparate = mem[((this.currentInstructions.submeshInstructions + 52) - 20) + (0)], preActiveClippingSlotSource = mem[((this.currentInstructions.submeshInstructions + 52) - 20) + (4)], rawTriangleCount = mem[((this.currentInstructions.submeshInstructions + 52) - 20) + (8)], rawVertexCount = val_16, rawFirstVertexIndex = 265015296, hasClipping = false}, updateTriangles:  true);
            val_9 = val_9 + 40;
            val_10 = val_10;
            val_11 = 1;
            label_8:
            if(val_11 < val_12)
            {
                goto label_14;
            }
            
            goto label_15;
            label_7:
            this.meshGenerator.BuildMeshWithArrays(instruction:  this.currentInstructions, updateTriangles:  val_2);
            label_15:
            this.buffers.UpdateSharedMaterials(instructions:  this.currentInstructions.submeshInstructions);
            if(this.meshGenerator.VertexCount <= 0)
            {
                goto label_21;
            }
            
            this.meshGenerator.FillVertexData(mesh:  this.buffers + 8);
            if(val_2 == false)
            {
                goto label_23;
            }
            
            this.meshGenerator.FillTriangles(mesh:  this.buffers + 8);
            goto label_25;
            label_21:
            this.buffers + 8.Clear();
            goto label_29;
            label_23:
            if(this.buffers.MaterialsChangedInLastUpdate() == false)
            {
                goto label_29;
            }
            
            label_25:
            UnityEngine.Material[] val_7 = this.buffers.GetUpdatedShaderdMaterialsArray();
            this.meshRenderer.sharedMaterials = this.buffers;
            label_29:
            this.meshFilter.sharedMesh = this.buffers + 8;
            this.buffers + 12.Set(other:  this.currentInstructions);
        }
        public void SetPropertyBlock(UnityEngine.MaterialPropertyBlock block)
        {
            this.LazyIntialize();
            this.meshRenderer.SetPropertyBlock(properties:  block);
        }
        public static Spine.Unity.Modules.SkeletonPartsRenderer NewPartsRendererGameObject(UnityEngine.Transform parent, string name)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(152981504)});
            typeof(System.Type[]).__il2cppRuntimeField_10 = null;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(154046464)});
            typeof(System.Type[]).__il2cppRuntimeField_14 = null;
            UnityEngine.Transform val_4 = transform;
            SetParent(parent:  parent, worldPositionStays:  false);
            if((new UnityEngine.GameObject(name:  name, components:  473824320)) != 0)
            {
                    return AddComponent<System.Object>();
            }
            
            return AddComponent<System.Object>();
        }
        public SkeletonPartsRenderer()
        {
            this.currentInstructions = new Spine.Unity.SkeletonRendererInstruction();
        }
    
    }

}
