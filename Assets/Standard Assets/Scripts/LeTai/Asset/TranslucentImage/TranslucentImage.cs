using UnityEngine;

namespace LeTai.Asset.TranslucentImage
{
    public class TranslucentImage : Image, IMeshModifier
    {
        // Fields
        public LeTai.Asset.TranslucentImage.TranslucentImageSource source;
        public float vibrancy;
        public float brightness;
        public float flatten;
        private UnityEngine.Shader correctShader;
        private int vibrancyPropId;
        private int brightnessPropId;
        private int flattenPropId;
        private float oldVibrancy;
        private float oldBrightness;
        private float oldFlatten;
        public float spriteBlending;
        
        // Methods
        protected override void Start()
        {
            LeTai.Asset.TranslucentImage.TranslucentImageSource val_6;
            var val_7;
            this.Start();
            this.PrepShader();
            if((mem[this.source + (0)]) == 0)
            {
                    val_6 = public static LeTai.Asset.TranslucentImage.TranslucentImageSource UnityEngine.Object::FindObjectOfType<LeTai.Asset.TranslucentImage.TranslucentImageSource>();
                object val_1 = UnityEngine.Object.FindObjectOfType<System.Object>();
            }
            
            this.source = val_6;
            UnityEngine.Material val_2 = this.material;
            this.SetTexture(name:  1832793600, value:  this.source.<BlurredScreen>k__BackingField);
            UnityEngine.Canvas val_3 = this.canvas;
            if(this != 0)
            {
                    UnityEngine.AdditionalCanvasShaderChannels val_4 = this.additionalShaderChannels;
                val_7 = this;
            }
            else
            {
                    UnityEngine.AdditionalCanvasShaderChannels val_5 = 0.additionalShaderChannels;
                val_7 = 0;
            }
            
            this.additionalShaderChannels = 1;
        }
        private void PrepShader()
        {
            UnityEngine.Shader val_1 = UnityEngine.Shader.Find(name:  1832913888);
            this.correctShader = "UI/TranslucentImage";
            this.vibrancyPropId = UnityEngine.Shader.PropertyToID(name:  1832914000);
            this.brightnessPropId = UnityEngine.Shader.PropertyToID(name:  1832914096);
            this.flattenPropId = UnityEngine.Shader.PropertyToID(name:  1832914192);
        }
        protected void LateUpdate()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.source)) == false)
            {
                goto label_3;
            }
            
            if(this.IsActive() == false)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.source.<BlurredScreen>k__BackingField)) == false)
            {
                    return;
            }
            
            UnityEngine.Material val_4 = this.material;
            if((UnityEngine.Object.op_Implicit(exists:  1833075328)) == false)
            {
                goto label_11;
            }
            
            UnityEngine.Material val_6 = this.material;
            UnityEngine.Shader val_7 = this.shader;
            1152921504765685760 = this.correctShader;
            if(1833075328 == 1152921504765685760)
            {
                goto label_15;
            }
            
            label_11:
            UnityEngine.Debug.LogError(message:  1833042672);
            label_15:
            UnityEngine.Material val_9 = this.materialForRendering;
            this.SetTexture(name:  1832793600, value:  this.source.<BlurredScreen>k__BackingField);
            return;
            label_3:
            UnityEngine.Debug.LogError(message:  1833051040);
        }
        private void Update()
        {
            if(this.vibrancyPropId == 0)
            {
                    return;
            }
            
            if(this.brightnessPropId != 0)
            {
                    this.brightnessPropId = this.flattenPropId;
            }
            
            if(this.brightnessPropId == 0)
            {
                    return;
            }
            
            this.SyncMaterialProperty(propId:  this.vibrancyPropId, value: ref  this.vibrancy, oldValue: ref  this.oldVibrancy);
            this.SyncMaterialProperty(propId:  this.brightnessPropId, value: ref  this.brightness, oldValue: ref  this.oldBrightness);
            this.SyncMaterialProperty(propId:  this.flattenPropId, value: ref  this.flatten, oldValue: ref  this.oldFlatten);
        }
        private void SyncMaterialProperty(int propId, ref float value, ref float oldValue)
        {
            UnityEngine.Material val_1 = this.materialForRendering;
            float val_2 = this.GetFloat(nameID:  propId);
            if((UnityEngine.Mathf.Approximately(a:  val_2, b:  null)) != true)
            {
                    if((UnityEngine.Mathf.Approximately(a:  val_2, b:  null)) != false)
            {
                    value = 1833331968;
            }
            else
            {
                    UnityEngine.Material val_5 = this.material;
                this.SetFloat(nameID:  propId, value:  val_2);
                UnityEngine.Material val_6 = this.materialForRendering;
                this.SetFloat(nameID:  propId, value:  val_2);
                this.SetMaterialDirty();
            }
            
            }
            
            oldValue = value;
        }
        public virtual void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            System.Collections.Generic.List<UnityEngine.UIVertex> val_6;
            var val_7;
            val_6 = null;
            val_6 = new System.Collections.Generic.List<UnityEngine.UIVertex>();
            vh.GetUIVertexStream(stream:  80883712);
            val_7 = 0;
            if(vh != 0)
            {
                    vh.Clear();
            }
            else
            {
                    0.Clear();
            }
            
            vh.AddUIVertexTriangleStream(verts:  80883712);
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.SetVerticesDirty();
        }
        protected override void OnDisable()
        {
            this.SetVerticesDirty();
            this.OnDisable();
        }
        protected override void OnDidApplyAnimationProperties()
        {
            this.SetVerticesDirty();
            this.OnDidApplyAnimationProperties();
        }
        public virtual void ModifyMesh(UnityEngine.Mesh mesh)
        {
            UnityEngine.Mesh val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = mesh;
            UnityEngine.UI.VertexHelper val_1 = new UnityEngine.UI.VertexHelper(m:  val_4);
            val_5 = 0;
            FillMesh(mesh:  val_4);
            if(val_1 == 0)
            {
                goto label_2;
            }
            
            UnityEngine.UI.VertexHelper val_3 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_3;
            }
            
            val_4 = 0;
            label_5:
            val_6 = mem[mem[null + 88] + 0];
            val_6 = mem[null + 88] + 0;
            if(val_6 == null)
            {
                goto label_4;
            }
            
            val_4 = val_4 + 1;
            if(((uint)val_4 & 65535) < (mem[null + 178]))
            {
                goto label_5;
            }
            
            label_3:
            val_7 = val_1;
            goto label_6;
            label_4:
            var val_2 = (mem[null + 88]) + 0;
            val_3 = val_3 + (((mem[null + 88] + 0) + 4) << 3);
            label_6:
            label_2:
            if(val_5 == 0)
            {
                    return;
            }
        
        }
        public TranslucentImage()
        {
            this.flatten = 0.1f;
            this.vibrancy = 1f;
            this.spriteBlending = 0.65f;
        }
    
    }

}
