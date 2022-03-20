using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SkeletonRenderSeparator : MonoBehaviour
    {
        // Fields
        public const int DefaultSortingOrderIncrement = 5;
        protected Spine.Unity.SkeletonRenderer skeletonRenderer;
        private UnityEngine.MeshRenderer mainMeshRenderer;
        public bool copyPropertyBlock;
        public bool copyMeshRendererFlags;
        public System.Collections.Generic.List<Spine.Unity.Modules.SkeletonPartsRenderer> partsRenderers;
        private UnityEngine.MaterialPropertyBlock copiedBlock;
        
        // Properties
        public Spine.Unity.SkeletonRenderer SkeletonRenderer { get; set; }
        
        // Methods
        public Spine.Unity.SkeletonRenderer get_SkeletonRenderer()
        {
        
        }
        public void set_SkeletonRenderer(Spine.Unity.SkeletonRenderer value)
        {
            Spine.Unity.SkeletonRenderer val_2 = this.skeletonRenderer;
            if(val_2 != 0)
            {
                    val_2 = this.skeletonRenderer;
                typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.Modules.SkeletonRenderSeparator::HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
                typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_10 = this;
                typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.Modules.SkeletonRenderSeparator::HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
                val_2.remove_GenerateMeshOverride(value:  268210176);
            }
            
            this.skeletonRenderer = value;
            this.enabled = false;
        }
        public static Spine.Unity.Modules.SkeletonRenderSeparator AddToSkeletonRenderer(Spine.Unity.SkeletonRenderer skeletonRenderer, int sortingLayerID = 0, int extraPartsRenderers = 0, int sortingOrderIncrement = 5, int baseSortingOrder = 0, bool addMinimumPartsRenderers = True)
        {
            UnityEngine.Object val_7;
            var val_8;
            Spine.Unity.SkeletonRenderer val_9;
            twelvegigs.sweepstakes.Distribution val_10;
            Spine.Unity.MeshGeneratorDelegate val_11;
            var val_12;
            val_7 = skeletonRenderer;
            val_8 = extraPartsRenderers;
            if(val_7 == 0)
            {
                    val_9 = 0;
                UnityEngine.Debug.Log(message:  2036186288);
                return;
            }
            
            UnityEngine.GameObject val_2 = val_7.gameObject;
            object val_3 = val_7.AddComponent<System.Object>();
            val_9 = val_7;
            skeletonRenderer.OnRebuild = val_7;
            val_10 = 0;
            var val_7 = val_7;
            if(addMinimumPartsRenderers != false)
            {
                    val_7 = val_8 + val_7;
                val_8 = val_7 + 1;
            }
            
            UnityEngine.Transform val_4 = val_7.transform;
            if(val_8 < 1)
            {
                    return;
            }
            
            val_7 = val_7;
            do
            {
                string val_5 = val_10.ToString();
                Spine.Unity.Modules.SkeletonPartsRenderer val_6 = Spine.Unity.Modules.SkeletonPartsRenderer.NewPartsRendererGameObject(parent:  val_7, name:  2036212808);
                val_10 = val_7;
                val_10.LazyIntialize();
                val_11 = skeletonRenderer.OnPostProcessVertices;
                if(val_11 != 0)
            {
                    val_11.sortingLayerID = sortingLayerID;
                val_12 = val_10;
            }
            else
            {
                    val_11 = 0;
                0.sortingLayerID = sortingLayerID;
                val_12 = val_10;
            }
            
                val_11.sortingOrder = baseSortingOrder;
                skeletonRenderer.initialSkinName.Add(item:  val_10);
            }
            while(1 < val_8);
            
            val_9 = val_9;
        }
        private void OnEnable()
        {
            var val_11;
            UnityEngine.Transform val_12;
            var val_13;
            var val_14;
            if(this.skeletonRenderer == 0)
            {
                    return;
            }
            
            if(this.copiedBlock == 0)
            {
                    this.copiedBlock = new UnityEngine.MaterialPropertyBlock();
            }
            
            object val_3 = this.skeletonRenderer.GetComponent<System.Object>();
            this.mainMeshRenderer = this.skeletonRenderer;
            val_11 = 1152921504875057152;
            val_12 = 1152921510937871152;
            typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.Modules.SkeletonRenderSeparator::HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
            typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_10 = this;
            typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.Modules.SkeletonRenderSeparator::HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
            this.skeletonRenderer.remove_GenerateMeshOverride(value:  268210176);
            typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.Modules.SkeletonRenderSeparator::HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
            typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_10 = this;
            typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.Modules.SkeletonRenderSeparator::HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
            this.skeletonRenderer.add_GenerateMeshOverride(value:  268210176);
            val_13 = 1152921504765685760;
            if(this.copyMeshRendererFlags == false)
            {
                    return;
            }
            
            UnityEngine.Rendering.LightProbeUsage val_4 = this.mainMeshRenderer.lightProbeUsage;
            bool val_5 = this.mainMeshRenderer.receiveShadows;
            UnityEngine.Rendering.ReflectionProbeUsage val_6 = this.mainMeshRenderer.reflectionProbeUsage;
            UnityEngine.Rendering.ShadowCastingMode val_7 = this.mainMeshRenderer.shadowCastingMode;
            val_14 = 0;
            UnityEngine.MotionVectorGenerationMode val_8 = this.mainMeshRenderer.motionVectorGenerationMode;
            var val_11 = 0;
            UnityEngine.Transform val_9 = this.mainMeshRenderer.probeAnchor;
            val_12 = this.mainMeshRenderer;
            goto label_15;
            label_25:
            if(this.mainMeshRenderer <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + 0;
            if(((0 + 0) + 16) != 0)
            {
                    (0 + 0) + 16.LazyIntialize();
                val_11 = mem[(0 + 0) + 16 + 16];
                val_11 = (0 + 0) + 16 + 16;
                if(val_11 != 0)
            {
                    val_11.lightProbeUsage = this.mainMeshRenderer;
                val_11.receiveShadows = val_5;
                val_11.reflectionProbeUsage = this.mainMeshRenderer;
                val_11.shadowCastingMode = this.mainMeshRenderer;
                val_11.motionVectorGenerationMode = this.mainMeshRenderer;
            }
            else
            {
                    val_11 = 0;
                0.lightProbeUsage = this.mainMeshRenderer;
                0.receiveShadows = val_5;
                0.reflectionProbeUsage = this.mainMeshRenderer;
                0.shadowCastingMode = this.mainMeshRenderer;
                0.motionVectorGenerationMode = this.mainMeshRenderer;
            }
            
                val_11.probeAnchor = val_12;
                val_13 = 1152921504765685760;
            }
            
            val_14 = 1;
            label_15:
            if(val_14 < val_11)
            {
                goto label_25;
            }
        
        }
        private void OnDisable()
        {
            var val_4;
            if(this.skeletonRenderer == 0)
            {
                    return;
            }
            
            typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_8 = System.Void Spine.Unity.Modules.SkeletonRenderSeparator::HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
            typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_10 = this;
            typeof(SkeletonRenderer.InstructionDelegate).__il2cppRuntimeField_14 = System.Void Spine.Unity.Modules.SkeletonRenderSeparator::HandleRender(Spine.Unity.SkeletonRendererInstruction instruction);
            this.skeletonRenderer.remove_GenerateMeshOverride(value:  268210176);
            List.Enumerator<T> val_2 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_6;
            }
            
            val_4.ClearMesh();
            goto label_8;
            label_6:
            Dispose();
        }
        private void HandleRender(Spine.Unity.SkeletonRendererInstruction instruction)
        {
            var val_2;
            var val_3;
            var val_4;
            Spine.Unity.SkeletonRendererInstruction val_5;
            var val_6;
            Spine.Unity.Modules.SkeletonRenderSeparator val_7;
            var val_8;
            int val_9;
            Spine.Unity.SkeletonRendererInstruction val_10;
            if(R7 < 1)
            {
                    return;
            }
            
            if(mem[1152921510938533860] != false)
            {
                    mem[1152921510938533856].GetPropertyBlock(properties:  mem[1152921510938533868]);
            }
            
            val_3 = mem[1152921510938533852];
            if(val_3 == 0)
            {
                goto label_5;
            }
            
            val_4 = mem[mem[1152921510938533852] + 50];
            val_4 = mem[1152921510938533852] + 50;
            goto label_6;
            label_5:
            val_4 = mem[mem[1152921510938533852] + 50];
            val_4 = mem[1152921510938533852] + 50;
            val_3 = mem[1152921510938533852];
            if(val_3 == 0)
            {
                goto label_7;
            }
            
            label_6:
            label_32:
            label_33:
            label_34:
            val_5 = instruction;
            if(val_5 == 0)
            {
                    val_5 = instruction;
            }
            
            val_2 = val_4;
            if((instruction + 12) != 0)
            {
                    val_6 = mem[instruction + 12 + 8];
                val_6 = instruction + 12 + 8;
            }
            else
            {
                    val_6 = 0;
            }
            
            var val_1 = (instruction + 12 + 12) - 1;
            if(this == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = this;
            if(val_1 < 0)
            {
                goto label_13;
            }
            
            var val_3 = mem[1152921510938533852] + 51;
            val_3 = val_3 << 16;
            val_3 = val_3 | (val_2 << 24);
            val_3 = val_3 | (mem[1152921510938533852] + 46);
            val_3 = val_3 | ((mem[1152921510938533852] + 48) << 8);
            val_8 = 0;
            val_2 = mem[((((mem[1152921510938533852] + 51 << 16) | (mem[1152921510938533852] + 50) << 24) | mem[1152921510938533852] + 46) | (mem[1152921510938533852] + 48) << 8) + 16];
            val_2 = ((((mem[1152921510938533852] + 51 << 16) | (mem[1152921510938533852] + 50) << 24) | mem[1152921510938533852] + 46) | (mem[1152921510938533852] + 48) << 8) + 16;
            label_25:
            if(0 == val_1)
            {
                goto label_17;
            }
            
            var val_2 = 0 + 0;
            val_2 = val_6 + (val_2 << 3);
            if(((val_6 + ((0 + 0)) << 3) + 32) != 0)
            {
                goto label_17;
            }
            
            val_9 = 0 + 1;
            goto label_18;
            label_17:
            val_2.LazyIntialize();
            mem2[0] = 1;
            mem2[0] = mem[1152921510938533852] + 40;
            mem2[0] = val_3;
            mem2[0] = 0;
            val_7 = this;
            val_10 = instruction;
            if(val_10 == 0)
            {
                    val_10 = instruction;
            }
            
            val_9 = 0 + 1;
            val_2.RenderParts(instructions:  instruction + 12, startSubmesh:  0, endSubmesh:  val_9);
            val_8 = val_8 + 1;
            if(val_8 >= (???))
            {
                goto label_26;
            }
            
            if((???) <= val_8)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (val_8 << 2);
            val_2 = mem[(0 + ((val_8 + 1)) << 2) + 16];
            val_2 = (0 + ((val_8 + 1)) << 2) + 16;
            label_18:
            if(val_9 <= val_1)
            {
                goto label_25;
            }
            
            goto label_26;
            label_13:
            val_8 = 0;
            label_26:
            if(val_8 >= (???))
            {
                    return;
            }
            
            do
            {
                if(0 <= val_8)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_5 + 0;
                (0 + 0) + 16.ClearMesh();
                val_8 = val_8 + 1;
            }
            while((???) != val_8);
            
            return;
            label_7:
            if(mem[1152921510938533852] != 0)
            {
                goto label_32;
            }
            
            if(mem[1152921510938533852] != 0)
            {
                goto label_33;
            }
            
            if(mem[1152921510938533852] != 0)
            {
                goto label_34;
            }
        
        }
        public SkeletonRenderSeparator()
        {
            this.copyPropertyBlock = true;
            this.copyMeshRendererFlags = true;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.partsRenderers = null;
        }
    
    }

}
