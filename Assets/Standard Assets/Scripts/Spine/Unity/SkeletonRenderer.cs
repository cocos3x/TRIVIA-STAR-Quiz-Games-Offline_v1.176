using UnityEngine;

namespace Spine.Unity
{
    public class SkeletonRenderer : MonoBehaviour, ISkeletonComponent
    {
        // Fields
        private Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate OnRebuild;
        private Spine.Unity.MeshGeneratorDelegate OnPostProcessVertices;
        public Spine.Unity.SkeletonDataAsset skeletonDataAsset;
        public string initialSkinName;
        public bool initialFlipX;
        public bool initialFlipY;
        public string[] separatorSlotNames;
        public readonly System.Collections.Generic.List<Spine.Slot> separatorSlots;
        public float zSpacing;
        public bool useClipping;
        public bool immutableTriangles;
        public bool pmaVertexColors;
        public bool clearStateOnDisable;
        public bool tintBlack;
        public bool singleSubmesh;
        public bool addNormals;
        public bool calculateTangents;
        public bool logErrors;
        public bool disableRenderingOnOverride;
        private Spine.Unity.SkeletonRenderer.InstructionDelegate generateMeshOverride;
        private readonly System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> customMaterialOverride;
        private readonly System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> customSlotMaterials;
        private UnityEngine.MeshRenderer meshRenderer;
        private UnityEngine.MeshFilter meshFilter;
        public bool valid;
        public Spine.Skeleton skeleton;
        private readonly Spine.Unity.SkeletonRendererInstruction currentInstructions;
        private readonly Spine.Unity.MeshGenerator meshGenerator;
        private readonly Spine.Unity.MeshRendererBuffers rendererBuffers;
        
        // Properties
        public Spine.Unity.SkeletonDataAsset SkeletonDataAsset { get; }
        public System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> CustomMaterialOverride { get; }
        public System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> CustomSlotMaterials { get; }
        public Spine.Skeleton Skeleton { get; }
        
        // Methods
        public void add_OnRebuild(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.OnRebuild, b:  value);
            if(this.OnRebuild == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OnRebuild;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OnRebuild != 1152921510909709916)
            {
                goto label_3;
            }
        
        }
        public void remove_OnRebuild(Spine.Unity.SkeletonRenderer.SkeletonRendererDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.OnRebuild, value:  value);
            if(this.OnRebuild == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OnRebuild;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OnRebuild != 1152921510909838300)
            {
                goto label_3;
            }
        
        }
        public void add_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.OnPostProcessVertices, b:  value);
            if(this.OnPostProcessVertices == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OnPostProcessVertices;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OnPostProcessVertices != 1152921510909966688)
            {
                goto label_3;
            }
        
        }
        public void remove_OnPostProcessVertices(Spine.Unity.MeshGeneratorDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.OnPostProcessVertices, value:  value);
            if(this.OnPostProcessVertices == 0)
            {
                goto label_1;
            }
            
            val_2 = this.OnPostProcessVertices;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.OnPostProcessVertices != 1152921510910095072)
            {
                goto label_3;
            }
        
        }
        public Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset()
        {
        
        }
        private void add_generateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.generateMeshOverride, b:  value);
            if(this.generateMeshOverride == 0)
            {
                goto label_1;
            }
            
            val_2 = this.generateMeshOverride;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.generateMeshOverride != 1152921510910343688)
            {
                goto label_3;
            }
        
        }
        private void remove_generateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.generateMeshOverride, value:  value);
            if(this.generateMeshOverride == 0)
            {
                goto label_1;
            }
            
            val_2 = this.generateMeshOverride;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.generateMeshOverride != 1152921510910472072)
            {
                goto label_3;
            }
        
        }
        public void add_GenerateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value)
        {
            this.add_generateMeshOverride(value:  value);
            if(this.disableRenderingOnOverride == true)
            {
                    this.disableRenderingOnOverride = this.generateMeshOverride;
            }
            
            if(this.disableRenderingOnOverride == 0)
            {
                    return;
            }
            
            this.meshRenderer.enabled = false;
        }
        public void remove_GenerateMeshOverride(Spine.Unity.SkeletonRenderer.InstructionDelegate value)
        {
            this.remove_generateMeshOverride(value:  value);
            if(this.disableRenderingOnOverride == false)
            {
                    return;
            }
            
            if(this.generateMeshOverride != 0)
            {
                    return;
            }
            
            R4 + 68.enabled = true;
        }
        public System.Collections.Generic.Dictionary<UnityEngine.Material, UnityEngine.Material> get_CustomMaterialOverride()
        {
        
        }
        public System.Collections.Generic.Dictionary<Spine.Slot, UnityEngine.Material> get_CustomSlotMaterials()
        {
        
        }
        public Spine.Skeleton get_Skeleton()
        {
        
        }
        public static T NewSpineGameObject<T>(Spine.Unity.SkeletonDataAsset skeletonDataAsset)
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  1990729008);
            goto __RuntimeMethodHiddenParam + 24;
        }
        public static T AddSpineComponent<T>(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset)
        {
            if(skeletonDataAsset == 0)
            {
                    return;
            }
            
            if(gameObject != 0)
            {
                    mem2[0] = skeletonDataAsset;
                return;
            }
            
            mem[20] = skeletonDataAsset;
        }
        public virtual void Awake()
        {
            goto typeof(Spine.Unity.SkeletonRenderer).__il2cppRuntimeField_FC;
        }
        private void OnDisable()
        {
            if(this.clearStateOnDisable == true)
            {
                    this.clearStateOnDisable = this.valid;
            }
            
            if(this.clearStateOnDisable == false)
            {
                    return;
            }
            
            goto typeof(Spine.Unity.SkeletonRenderer).__il2cppRuntimeField_F4;
        }
        private void OnDestroy()
        {
            this.rendererBuffers.Dispose();
        }
        protected virtual void ClearState()
        {
            this.meshFilter.sharedMesh = 0;
            this.currentInstructions.Clear();
            if(this.skeleton == 0)
            {
                    return;
            }
            
            this.skeleton.SetToSetupPose();
        }
        public virtual void Initialize(bool overwrite)
        {
            string val_12;
            Spine.Skeleton val_13;
            bool val_14;
            var val_15;
            if((this.valid != false) && (overwrite != true))
            {
                    return;
            }
            
            val_12 = 1152921504765685760;
            if(this.meshFilter != 0)
            {
                    this.meshFilter.sharedMesh = 0;
            }
            
            object val_2 = this.meshFilter.GetComponent<System.Object>();
            this.meshRenderer = this;
            if(2010284496 != 0)
            {
                    this.meshRenderer.sharedMaterial = 0;
            }
            
            this.currentInstructions.Clear();
            this.rendererBuffers.Clear();
            this.meshGenerator.Begin();
            this.valid = false;
            this.skeleton = false;
            if((UnityEngine.Object.op_Implicit(exists:  this.skeletonDataAsset)) == false)
            {
                goto label_16;
            }
            
            Spine.SkeletonData val_5 = this.skeletonDataAsset.GetSkeletonData(quiet:  false);
            if(this.skeletonDataAsset == 0)
            {
                    return;
            }
            
            this.valid = true;
            object val_6 = this.GetComponent<System.Object>();
            this.meshFilter = this;
            object val_7 = this.GetComponent<System.Object>();
            this.meshRenderer = this;
            this.rendererBuffers.Initialize();
            Spine.Skeleton val_8 = null;
            val_13 = val_8;
            val_8 = new Spine.Skeleton(data:  this.skeletonDataAsset);
            if(val_13 == 0)
            {
                goto label_20;
            }
            
            typeof(Spine.Skeleton).__il2cppRuntimeField_44 = this.initialFlipX;
            val_14 = this.initialFlipY;
            goto label_21;
            label_16:
            if(this.logErrors == false)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  2010147728, context:  2010284496);
            return;
            label_20:
            mem[68] = this.initialFlipX;
            val_14 = this.initialFlipY;
            label_21:
            typeof(Spine.Skeleton).__il2cppRuntimeField_45 = val_14;
            this.skeleton = val_13;
            if((System.String.IsNullOrEmpty(value:  this.initialSkinName)) != true)
            {
                    if((System.String.Equals(a:  this.initialSkinName, b:  1788750208, comparisonType:  4)) != true)
            {
                    val_13 = this.skeleton;
                val_13.SetSkin(skinName:  this.initialSkinName);
            }
            
            }
            
            this.separatorSlots.Clear();
            val_15 = 0;
            goto label_29;
            label_35:
            val_12 = this.separatorSlotNames[val_15];
            Spine.Slot val_11 = this.skeleton.FindSlot(slotName:  val_12);
            val_13 = this.skeleton;
            this.separatorSlots.Add(item:  val_13);
            val_15 = 1;
            label_29:
            if(val_15 < this.separatorSlots)
            {
                goto label_35;
            }
            
            if(this.OnRebuild == 0)
            {
                    return;
            }
            
            this.OnRebuild.Invoke(skeletonRenderer:  2010284496);
        }
        public virtual void LateUpdate()
        {
            Spine.Unity.SkeletonRendererInstruction val_12;
            Spine.Unity.MeshRendererBuffers val_13;
            bool val_14;
            Spine.Unity.MeshGenerator val_15;
            Spine.ExposedList<Spine.Unity.SubmeshInstruction> val_16;
            bool val_17;
            Spine.Skeleton val_18;
            int val_19;
            int val_20;
            int val_21;
            Spine.Unity.MeshRendererBuffers val_22;
            if(this.valid == false)
            {
                    return;
            }
            
            if(this.meshRenderer.enabled == false)
            {
                    return;
            }
            
            val_12 = this.currentInstructions;
            SmartMesh val_2 = this.rendererBuffers.GetNextMesh();
            val_13 = this.rendererBuffers;
            if(this.singleSubmesh == false)
            {
                goto label_6;
            }
            
            Spine.Unity.AtlasAsset val_12 = this.skeletonDataAsset.atlasAssets[0];
            Spine.Unity.MeshGenerator.GenerateSingleSubmeshInstruction(instructionOutput:  val_12, skeleton:  this.skeleton, material:  this.skeletonDataAsset.atlasAssets[0].materials[0]);
            if(this.customMaterialOverride.Count >= 1)
            {
                    Spine.Unity.MeshGenerator.TryReplaceMaterials(workingSubmeshInstructions:  this.currentInstructions.submeshInstructions, customMaterialOverride:  this.customMaterialOverride);
            }
            
            bool val_14 = this.tintBlack;
            val_14 = this.pmaVertexColors | (val_14 << 8);
            val_14 = val_14 | (this.calculateTangents << 16);
            this.meshGenerator.settings = this.useClipping;
            mem2[0] = this.zSpacing;
            mem2[0] = val_14 | (this.addNormals << 24);
            mem2[0] = 0;
            this.meshGenerator.Begin();
            val_14 = Spine.Unity.SkeletonRendererInstruction.GeometryNotEqual(a:  val_12, b:  this.rendererBuffers.submeshMaterials);
            val_15 = this.meshGenerator;
            val_16 = this.currentInstructions.submeshInstructions;
            if(this.currentInstructions.hasActiveClipping == false)
            {
                goto label_18;
            }
            
            if(val_16 == 0)
            {
                    val_15 = val_15;
            }
            
            if((this.currentInstructions.submeshInstructions + 8) == 0)
            {
                    val_15 = val_15;
            }
            
            if((this.currentInstructions.submeshInstructions + 8 + 12) == 0)
            {
                    val_15 = val_15;
            }
            
            var val_6 = (this.currentInstructions.submeshInstructions + 8) + 16;
            val_21 = mem[this.currentInstructions.submeshInstructions + 8 + 48];
            val_21 = this.currentInstructions.submeshInstructions + 8 + 48;
            if(val_15 == 0)
            {
                    val_17 = mem[(this.currentInstructions.submeshInstructions + 8 + 16) + (16)];
                val_21 = val_21;
                val_20 = mem[(this.currentInstructions.submeshInstructions + 8 + 16) + (8)];
                val_19 = mem[(this.currentInstructions.submeshInstructions + 8 + 16) + (4)];
                val_18 = mem[(this.currentInstructions.submeshInstructions + 8 + 16) + (0)];
            }
            
            val_14 = val_14;
            val_15.AddSubmesh(instruction:  new Spine.Unity.SubmeshInstruction() {skeleton = val_18, startSlot = val_19, endSlot = val_20, material = mem[(this.currentInstructions.submeshInstructions + 8 + 16) + (12)], forceSeparate = val_17, preActiveClippingSlotSource = this.currentInstructions.submeshInstructions + 8 + 36, rawTriangleCount = this.currentInstructions.submeshInstructions + 8 + 40, rawVertexCount = this.currentInstructions.submeshInstructions + 8 + 44, rawFirstVertexIndex = val_21, hasClipping = this.currentInstructions.submeshInstructions + 8 + 52}, updateTriangles:  this.currentInstructions.submeshInstructions + 8 + 52);
            val_12 = val_12;
            val_13 = val_13;
            goto label_36;
            label_6:
            if(this.generateMeshOverride != 0)
            {
                    this.generateMeshOverride = 1;
            }
            
            Spine.Unity.MeshGenerator.GenerateSkeletonRendererInstruction(instructionOutput:  val_12, skeleton:  this.skeleton, customSlotMaterials:  this.customSlotMaterials, separatorSlots:  this.separatorSlots, generateMeshOverride:  true, immutableTriangles:  this.immutableTriangles);
            if(this.customMaterialOverride.Count >= 1)
            {
                    Spine.Unity.MeshGenerator.TryReplaceMaterials(workingSubmeshInstructions:  this.currentInstructions.submeshInstructions, customMaterialOverride:  this.customMaterialOverride);
            }
            
            if(this.generateMeshOverride == 0)
            {
                goto label_28;
            }
            
            this.generateMeshOverride.Invoke(instruction:  val_12);
            if(this.disableRenderingOnOverride == false)
            {
                goto label_28;
            }
            
            return;
            label_18:
            val_15.BuildMeshWithArrays(instruction:  val_12, updateTriangles:  val_14);
            goto label_30;
            label_28:
            bool val_15 = this.tintBlack;
            val_15 = this.pmaVertexColors | (val_15 << 8);
            val_15 = val_15 | (this.calculateTangents << 16);
            this.meshGenerator.settings = this.useClipping;
            mem2[0] = this.zSpacing;
            mem2[0] = val_15 | (this.addNormals << 24);
            mem2[0] = 0;
            this.meshGenerator.Begin();
            val_14 = Spine.Unity.SkeletonRendererInstruction.GeometryNotEqual(a:  val_12, b:  this.rendererBuffers.submeshMaterials);
            if(this.currentInstructions.hasActiveClipping != false)
            {
                    this.meshGenerator.BuildMesh(instruction:  val_12, updateTriangles:  val_14);
            }
            else
            {
                    this.meshGenerator.BuildMeshWithArrays(instruction:  val_12, updateTriangles:  val_14);
            }
            
            label_36:
            val_16 = this.currentInstructions.submeshInstructions;
            label_30:
            if(this.OnPostProcessVertices != 0)
            {
                    this.OnPostProcessVertices.Invoke(meshGenerator:  this.meshGenerator);
            }
            
            this.meshGenerator.FillVertexData(mesh:  this.rendererBuffers.doubleBufferedMesh);
            val_22 = this.rendererBuffers;
            val_22.UpdateSharedMaterials(instructions:  val_16);
            if(val_14 == false)
            {
                goto label_40;
            }
            
            this.meshGenerator.FillTriangles(mesh:  this.rendererBuffers.doubleBufferedMesh);
            goto label_42;
            label_40:
            if(this.rendererBuffers.MaterialsChangedInLastUpdate() == false)
            {
                goto label_44;
            }
            
            label_42:
            val_22 = this.meshRenderer;
            UnityEngine.Material[] val_11 = this.rendererBuffers.GetUpdatedShaderdMaterialsArray();
            val_22.sharedMaterials = this.rendererBuffers;
            label_44:
            this.meshFilter.sharedMesh = this.rendererBuffers.doubleBufferedMesh;
            this.rendererBuffers.submeshMaterials.Set(other:  val_12);
        }
        public SkeletonRenderer()
        {
            this.separatorSlotNames = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.useClipping = true;
            this.separatorSlots = null;
            this.pmaVertexColors = true;
            this.disableRenderingOnOverride = true;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.customMaterialOverride = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.customSlotMaterials = null;
            this.currentInstructions = new Spine.Unity.SkeletonRendererInstruction();
            this.meshGenerator = new Spine.Unity.MeshGenerator();
            this.rendererBuffers = new Spine.Unity.MeshRendererBuffers();
        }
    
    }

}
