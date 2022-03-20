using UnityEngine;

namespace Spine.Unity
{
    public class SkeletonGraphic : MaskableGraphic, ISkeletonComponent, IAnimationStateComponent, ISkeletonAnimation
    {
        // Fields
        public Spine.Unity.SkeletonDataAsset skeletonDataAsset;
        public string initialSkinName;
        public bool initialFlipX;
        public bool initialFlipY;
        public string startingAnimation;
        public bool startingLoop;
        public float timeScale;
        public bool freeze;
        public bool unscaledTime;
        private UnityEngine.Texture <OverrideTexture>k__BackingField;
        protected Spine.Skeleton skeleton;
        protected Spine.AnimationState state;
        protected Spine.Unity.MeshGenerator meshGenerator;
        private Spine.Unity.DoubleBuffered<Spine.Unity.MeshRendererBuffers.SmartMesh> meshBuffers;
        private Spine.Unity.SkeletonRendererInstruction currentInstructions;
        private Spine.Unity.UpdateBonesDelegate UpdateLocal;
        private Spine.Unity.UpdateBonesDelegate UpdateWorld;
        private Spine.Unity.UpdateBonesDelegate UpdateComplete;
        private Spine.Unity.MeshGeneratorDelegate OnPostProcessVertices;
        
        // Properties
        public Spine.Unity.SkeletonDataAsset SkeletonDataAsset { get; }
        public UnityEngine.Texture OverrideTexture { get; set; }
        public override UnityEngine.Texture mainTexture { get; }
        public Spine.Skeleton Skeleton { get; }
        public Spine.SkeletonData SkeletonData { get; }
        public bool IsValid { get; }
        public Spine.AnimationState AnimationState { get; }
        public Spine.Unity.MeshGenerator MeshGenerator { get; }
        
        // Methods
        public Spine.Unity.SkeletonDataAsset get_SkeletonDataAsset()
        {
        
        }
        public static Spine.Unity.SkeletonGraphic NewSkeletonGraphicGameObject(Spine.Unity.SkeletonDataAsset skeletonDataAsset, UnityEngine.Transform parent)
        {
            UnityEngine.GameObject val_5 = null;
            val_5 = new UnityEngine.GameObject(name:  1990729008);
            Spine.Unity.SkeletonGraphic val_2 = Spine.Unity.SkeletonGraphic.AddSkeletonGraphicComponent(gameObject:  157720576, skeletonDataAsset:  skeletonDataAsset);
            if(parent == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_4 = transform;
            val_5 = val_5;
            SetParent(parent:  parent, worldPositionStays:  false);
        }
        public static Spine.Unity.SkeletonGraphic AddSkeletonGraphicComponent(UnityEngine.GameObject gameObject, Spine.Unity.SkeletonDataAsset skeletonDataAsset)
        {
            object val_1 = gameObject.AddComponent<System.Object>();
            if(skeletonDataAsset == 0)
            {
                    return;
            }
            
            if(gameObject != 0)
            {
                    mem2[0] = skeletonDataAsset;
            }
            else
            {
                    mem[108] = skeletonDataAsset;
            }
            
            gameObject.Initialize(overwrite:  false);
        }
        public UnityEngine.Texture get_OverrideTexture()
        {
        
        }
        public void set_OverrideTexture(UnityEngine.Texture value)
        {
            this.<OverrideTexture>k__BackingField = value;
        }
        public override UnityEngine.Texture get_mainTexture()
        {
            UnityEngine.Texture val_3;
            if((this.<OverrideTexture>k__BackingField) != 0)
            {
                    val_3 = this.<OverrideTexture>k__BackingField;
                return;
            }
            
            val_3 = 0;
            if(this.skeletonDataAsset == 0)
            {
                    return;
            }
            
            Spine.Unity.AtlasAsset val_3 = this.skeletonDataAsset.atlasAssets[0];
            UnityEngine.Material val_4 = this.skeletonDataAsset.atlasAssets[0].materials[0];
            if(val_4 != 0)
            {
                    return val_4.mainTexture;
            }
            
            return val_4.mainTexture;
        }
        protected override void Awake()
        {
            this.Awake();
            if(this.skeleton != 0)
            {
                    return;
            }
            
            R4.Initialize(overwrite:  false);
            goto R4 + 484;
        }
        public override void Rebuild(UnityEngine.UI.CanvasUpdate update)
        {
            this.Rebuild(update:  update);
            UnityEngine.CanvasRenderer val_1 = this.canvasRenderer;
            if(this.cull != false)
            {
                    return;
            }
            
            this.UpdateMesh();
        }
        public virtual void Update()
        {
            var val_3;
            if(this.freeze == true)
            {
                    return;
            }
            
            if((R4 + 133) != 0)
            {
                    val_3 = 0;
                float val_1 = UnityEngine.Time.unscaledDeltaTime;
            }
            else
            {
                    val_3 = 0;
                float val_2 = UnityEngine.Time.deltaTime;
            }
        
        }
        public virtual void Update(float deltaTime)
        {
            if(this.skeleton == 0)
            {
                    return;
            }
            
            float val_2 = R1;
            val_2 = this.timeScale * val_2;
            this.skeleton.Update(delta:  val_2);
            this.state.Update(delta:  val_2);
            bool val_1 = this.state.Apply(skeleton:  this.skeleton);
            if(this.UpdateLocal != 0)
            {
                    this.skeleton = this;
                this.UpdateLocal.Invoke(animated:  1991940960);
            }
            
            this.skeleton.UpdateWorldTransform();
            if(this.UpdateWorld != 0)
            {
                    this.UpdateWorld.Invoke(animated:  1991940960);
                this.skeleton.UpdateWorldTransform();
            }
            
            if(this.UpdateComplete == 0)
            {
                    return;
            }
            
            this.UpdateComplete.Invoke(animated:  1991940960);
        }
        public void LateUpdate()
        {
            if(this.freeze == true)
            {
                    return;
            }
            
            this.UpdateMesh();
        }
        public Spine.Skeleton get_Skeleton()
        {
        
        }
        public Spine.SkeletonData get_SkeletonData()
        {
            if(this.skeleton != 0)
            {
                    this.skeleton = this.skeleton.data;
            }
            
            if(this.skeleton == 0)
            {
                    this.skeleton = 0;
            }
        
        }
        public bool get_IsValid()
        {
            if(this.skeleton != 0)
            {
                    this.skeleton = 1;
            }
            
            return true;
        }
        public Spine.AnimationState get_AnimationState()
        {
        
        }
        public Spine.Unity.MeshGenerator get_MeshGenerator()
        {
        
        }
        public UnityEngine.Mesh GetLastMesh()
        {
            SmartMesh val_1 = this.meshBuffers.GetCurrent();
            if(this.meshBuffers != 0)
            {
                    return;
            }
        
        }
        public void add_UpdateLocal(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.UpdateLocal, b:  value);
            if(this.UpdateLocal == 0)
            {
                goto label_1;
            }
            
            val_2 = this.UpdateLocal;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.UpdateLocal != 1152921510894754816)
            {
                goto label_3;
            }
        
        }
        public void remove_UpdateLocal(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.UpdateLocal, value:  value);
            if(this.UpdateLocal == 0)
            {
                goto label_1;
            }
            
            val_2 = this.UpdateLocal;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.UpdateLocal != 1152921510894883200)
            {
                goto label_3;
            }
        
        }
        public void add_UpdateWorld(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.UpdateWorld, b:  value);
            if(this.UpdateWorld == 0)
            {
                goto label_1;
            }
            
            val_2 = this.UpdateWorld;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.UpdateWorld != 1152921510895011588)
            {
                goto label_3;
            }
        
        }
        public void remove_UpdateWorld(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.UpdateWorld, value:  value);
            if(this.UpdateWorld == 0)
            {
                goto label_1;
            }
            
            val_2 = this.UpdateWorld;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.UpdateWorld != 1152921510895139972)
            {
                goto label_3;
            }
        
        }
        public void add_UpdateComplete(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.UpdateComplete, b:  value);
            if(this.UpdateComplete == 0)
            {
                goto label_1;
            }
            
            val_2 = this.UpdateComplete;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.UpdateComplete != 1152921510895268360)
            {
                goto label_3;
            }
        
        }
        public void remove_UpdateComplete(Spine.Unity.UpdateBonesDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.UpdateComplete, value:  value);
            if(this.UpdateComplete == 0)
            {
                goto label_1;
            }
            
            val_2 = this.UpdateComplete;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.UpdateComplete != 1152921510895396744)
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
            if(this.OnPostProcessVertices != 1152921510895525132)
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
            if(this.OnPostProcessVertices != 1152921510895653516)
            {
                goto label_3;
            }
        
        }
        public void Clear()
        {
            this.skeleton = 0;
            UnityEngine.CanvasRenderer val_1 = this.canvasRenderer;
            this.Clear();
        }
        public void Initialize(bool overwrite)
        {
            Spine.Unity.AtlasAsset[] val_10;
            Spine.AnimationStateData val_11;
            bool val_12;
            val_10 = 35647736;
            if(this.skeleton != 0)
            {
                    if(overwrite == false)
            {
                    return;
            }
            
            }
            
            if(this.skeletonDataAsset == 0)
            {
                    return;
            }
            
            Spine.SkeletonData val_2 = this.skeletonDataAsset.GetSkeletonData(quiet:  false);
            if(this.skeletonDataAsset == 0)
            {
                    return;
            }
            
            val_10 = this.skeletonDataAsset.atlasAssets;
            if(this.skeletonDataAsset == 0)
            {
                    return;
            }
            
            Spine.Unity.AtlasAsset val_10 = this.skeletonDataAsset.atlasAssets[0];
            val_10 = this.skeletonDataAsset.atlasAssets[0].materials;
            if(this.skeletonDataAsset == 0)
            {
                    return;
            }
            
            val_11 = this.skeletonDataAsset.stateData;
            if(val_11 == 0)
            {
                    Spine.SkeletonData val_3 = this.skeletonDataAsset.GetSkeletonData(quiet:  false);
                val_11 = this.skeletonDataAsset.stateData;
            }
            
            Spine.AnimationState val_4 = new Spine.AnimationState(data:  val_11);
            this.state = val_4;
            if(val_4 == 0)
            {
                goto label_19;
            }
            
            Spine.Skeleton val_5 = null;
            val_10 = val_5;
            val_5 = new Spine.Skeleton(data:  this.skeletonDataAsset);
            if(val_10 == 0)
            {
                goto label_20;
            }
            
            typeof(Spine.Skeleton).__il2cppRuntimeField_44 = this.initialFlipX;
            val_12 = this.initialFlipY;
            goto label_21;
            label_19:
            this.Clear();
            return;
            label_20:
            mem[68] = this.initialFlipX;
            val_12 = this.initialFlipY;
            label_21:
            typeof(Spine.Skeleton).__il2cppRuntimeField_45 = val_12;
            this.skeleton = val_10;
            Spine.Unity.DoubleBuffered<System.Object> val_6 = new Spine.Unity.DoubleBuffered<System.Object>();
            this.meshBuffers = null;
            if((System.String.IsNullOrEmpty(value:  this.initialSkinName)) != true)
            {
                    val_10 = this.skeleton;
                val_10.SetSkin(skinName:  this.initialSkinName);
            }
            
            if((System.String.IsNullOrEmpty(value:  this.startingAnimation)) != false)
            {
                    return;
            }
            
            if(this.startingLoop == true)
            {
                    this.startingLoop = 1;
            }
            
            Spine.TrackEntry val_9 = this.state.SetAnimation(trackIndex:  0, animationName:  this.startingAnimation, loop:  true);
            goto typeof(Spine.Unity.SkeletonGraphic).__il2cppRuntimeField_324;
        }
        public void UpdateMesh()
        {
            float val_2;
            Spine.Unity.DoubleBuffered<SmartMesh> val_13;
            Spine.Unity.SkeletonRendererInstruction val_14;
            bool val_15;
            Spine.Skeleton val_16;
            int val_17;
            int val_18;
            int val_19;
            bool val_20;
            int val_21;
            if(this.skeleton == 0)
            {
                    return;
            }
            
            UnityEngine.Color val_1 = color;
            Spine.Unity.SkeletonExtensions.SetColor(skeleton:  this.skeleton, color:  new UnityEngine.Color() {a = val_2});
            SmartMesh val_3 = this.meshBuffers.GetNext();
            val_13 = this.meshBuffers;
            val_14 = this.currentInstructions;
            UnityEngine.Material val_4 = this.material;
            Spine.Unity.MeshGenerator.GenerateSingleSubmeshInstruction(instructionOutput:  val_14, skeleton:  this.skeleton, material:  1994576480);
            val_15 = Spine.Unity.SkeletonRendererInstruction.GeometryNotEqual(a:  val_14, b:  this.skeleton);
            this.meshGenerator.Begin();
            if(this.currentInstructions.hasActiveClipping != false)
            {
                    bool val_6 = val_15 + 16;
                bool val_7 = val_15 + 32;
                if(this.meshGenerator == 0)
            {
                    val_21 = mem[(val_5 + 32) + (12)];
                val_19 = mem[(val_5 + 32) + (8)];
                val_20 = mem[(val_5 + 32) + (0)];
                val_18 = mem[(val_5 + 16) + (8)];
                val_17 = mem[(val_5 + 16) + (4)];
                val_16 = mem[(val_5 + 16) + (0)];
            }
            
                val_15 = val_15;
                this.meshGenerator.AddSubmesh(instruction:  new Spine.Unity.SubmeshInstruction() {skeleton = val_16, startSlot = val_17, endSlot = val_18, material = mem[(val_5 + 16) + (12)], forceSeparate = val_20, preActiveClippingSlotSource = mem[(val_5 + 32) + (4)], rawTriangleCount = val_19, rawVertexCount = val_21, rawFirstVertexIndex = val_5 + 48, hasClipping = val_5 + 52}, updateTriangles:  val_5 + 52);
                val_14 = val_14;
                val_13 = val_13;
            }
            else
            {
                    this.meshGenerator.BuildMeshWithArrays(instruction:  val_14, updateTriangles:  val_15);
            }
            
            UnityEngine.Canvas val_8 = this.canvas;
            if(1994576480 != 0)
            {
                    UnityEngine.Canvas val_10 = this.canvas;
                this.meshGenerator.ScaleVertexData(scale:  this.referencePixelsPerUnit);
            }
            
            if(this.OnPostProcessVertices != 0)
            {
                    this.OnPostProcessVertices.Invoke(meshGenerator:  this.meshGenerator);
            }
            
            this.meshGenerator.FillVertexData(mesh:  this.meshGenerator);
            if(val_15 != false)
            {
                    this.meshGenerator.FillTrianglesSingle(mesh:  this.meshGenerator);
            }
            
            UnityEngine.CanvasRenderer val_12 = this.canvasRenderer;
            this.SetMesh(mesh:  this.meshGenerator);
            val_14.Set(other:  val_14);
        }
        public SkeletonGraphic()
        {
            this.timeScale = 1f;
            this.initialSkinName = "default";
            this.meshGenerator = new Spine.Unity.MeshGenerator();
            this.currentInstructions = new Spine.Unity.SkeletonRendererInstruction();
        }
    
    }

}
