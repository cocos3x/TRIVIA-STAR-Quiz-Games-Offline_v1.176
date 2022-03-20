using UnityEngine;

namespace LeTai.Asset.TranslucentImage
{
    public class TranslucentImageSource : MonoBehaviour
    {
        // Fields
        public float maxUpdateRate;
        public bool preview;
        private float size;
        private int iteration;
        private int maxDepth;
        private int downsample;
        private int lastDownsample;
        private float strength;
        private float lastUpdate;
        private UnityEngine.Camera camera;
        private UnityEngine.Shader shader;
        private UnityEngine.Material material;
        private UnityEngine.RenderTexture <BlurredScreen>k__BackingField;
        
        // Properties
        public UnityEngine.RenderTexture BlurredScreen { get; set; }
        public UnityEngine.Camera Cam { get; }
        public float Strength { get; set; }
        public float Size { get; set; }
        public int Iteration { get; set; }
        public int Downsample { get; set; }
        public int MaxDepth { get; set; }
        private float ScreenSize { get; }
        private float MinUpdateCycle { get; }
        
        // Methods
        public UnityEngine.RenderTexture get_BlurredScreen()
        {
        
        }
        private void set_BlurredScreen(UnityEngine.RenderTexture value)
        {
            this.<BlurredScreen>k__BackingField = value;
        }
        public UnityEngine.Camera get_Cam()
        {
            if(this.camera != 0)
            {
                    return;
            }
            
            object val_1 = R4.GetComponent<System.Object>();
            mem2[0] = R4;
        }
        public float get_Strength()
        {
            int val_1 = this.downsample + this.iteration;
            uint val_2 = 1065353216;
            val_2 = this.size * val_2;
            this.strength = val_2;
            return val_2;
        }
        public void set_Strength(float value)
        {
            float val_1 = UnityEngine.Mathf.Max(a:  value, b:  null);
            this.strength = 0f;
            goto typeof(LeTai.Asset.TranslucentImage.TranslucentImageSource).__il2cppRuntimeField_DC;
        }
        public float get_Size()
        {
            return (float)S0;
        }
        public void set_Size(float value)
        {
            float val_1 = UnityEngine.Mathf.Max(a:  value, b:  null);
            this.size = 0f;
        }
        public int get_Iteration()
        {
            return (int)this.iteration;
        }
        public void set_Iteration(int value)
        {
            this.iteration = UnityEngine.Mathf.Max(a:  0, b:  value);
        }
        public int get_Downsample()
        {
            return (int)this.downsample;
        }
        public void set_Downsample(int value)
        {
            this.downsample = UnityEngine.Mathf.Max(a:  0, b:  value);
        }
        public int get_MaxDepth()
        {
            return (int)this.maxDepth;
        }
        public void set_MaxDepth(int value)
        {
            this.maxDepth = UnityEngine.Mathf.Max(a:  1, b:  value);
        }
        private float get_ScreenSize()
        {
            UnityEngine.Camera val_1 = this.Cam;
            UnityEngine.Camera val_3 = this.Cam;
            float val_6 = (float)UnityEngine.Mathf.Min(a:  this.pixelWidth, b:  this.pixelHeight);
            val_6 = val_6 / 1080f;
            return (float)val_6;
        }
        private float get_MinUpdateCycle()
        {
            float val_1 = 1f;
            val_1 = val_1 / this.maxUpdateRate;
            if()
            {
                    val_1 = 2139095040;
            }
            
            return (float)val_1;
        }
        protected virtual void SetAdvancedFieldFromSimple()
        {
            int val_1 = this.downsample + this.iteration;
            uint val_5 = 1065353216;
            val_5 = this.strength / val_5;
            this.Size = val_5;
            if(this.downsample < 1)
            {
                goto label_4;
            }
            
            this.Downsample = this.downsample - 1;
            goto label_5;
            label_4:
            if(this.iteration < 1)
            {
                goto label_6;
            }
            
            this.Iteration = this.iteration - 1;
            label_5:
            float val_6 = this.size;
            val_6 = val_6 + val_6;
            this.Size = val_6;
            label_6:
            float val_7 = this.size;
            if(this.iteration <= 1)
            {
                    return;
            }
            
            do
            {
                val_7 = val_7 * 0.5f;
                this.Size = val_7;
                this.Iteration = this.iteration + 1;
            }
            while(this.iteration > 1);
        
        }
        protected virtual void Start()
        {
            UnityEngine.Camera val_1 = this.Cam;
            this.camera = this;
            UnityEngine.Shader val_2 = UnityEngine.Shader.Find(name:  1835935040);
            this.shader = "Hidden/EfficientBlur";
            if(isSupported != true)
            {
                    this.enabled = false;
            }
            
            this.material = new UnityEngine.Material(shader:  this.shader);
            UnityEngine.Camera val_5 = this.Cam;
            UnityEngine.Camera val_7 = this.Cam;
            UnityEngine.RenderTexture val_13 = new UnityEngine.RenderTexture(width:  this.pixelWidth >> (this.downsample & 31), height:  this.pixelHeight >> (this.downsample & 31), depth:  0);
            filterMode = 1;
            this.<BlurredScreen>k__BackingField = null;
            this.lastDownsample = this.downsample;
        }
        protected virtual void ProgressiveResampling(UnityEngine.RenderTexture source, int level, ref UnityEngine.RenderTexture target)
        {
            int val_6 = level;
            int val_1 = UnityEngine.Mathf.Min(a:  val_6, b:  this.maxDepth);
            int val_5 = this.downsample;
            val_5 = val_5 + val_1;
            val_5 = val_5 & 31;
            val_6 = source >> val_5;
            UnityEngine.RenderTextureFormat val_2 = source.format;
            int val_3 = this.downsample + val_1;
            val_3 = val_3 & 31;
            val_3 = source >> val_3;
            UnityEngine.RenderTexture val_4 = UnityEngine.RenderTexture.GetTemporary(width:  val_3, height:  val_6, depthBuffer:  0, format:  source);
            val_3.filterMode = 1;
            UnityEngine.Graphics.Blit(source:  target, dest:  val_3, mat:  this.material, pass:  0);
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  target);
            target = val_3;
        }
        protected virtual void ProgressiveBlur(UnityEngine.RenderTexture source)
        {
            UnityEngine.RenderTexture val_20;
            UnityEngine.RenderTexture val_21;
            UnityEngine.Material val_22;
            int val_23;
            if(this.downsample == this.lastDownsample)
            {
                    val_20 = this;
                val_21 = this.<BlurredScreen>k__BackingField;
            }
            else
            {
                    UnityEngine.Camera val_1 = this.Cam;
                UnityEngine.Camera val_3 = this.Cam;
                val_21 = null;
                val_21 = new UnityEngine.RenderTexture(width:  this.pixelWidth >> (this.downsample & 31), height:  this.pixelHeight >> (this.downsample & 31), depth:  0);
                this.<BlurredScreen>k__BackingField = val_21;
                val_20 = this.<BlurredScreen>k__BackingField;
                this.lastDownsample = this.downsample;
            }
            
            if(IsCreated() != false)
            {
                    mem[this.<BlurredScreen>k__BackingField].DiscardContents();
            }
            
            float val_11 = this.ScreenSize;
            this.material.SetFloat(name:  1288504208, value:  this.size * 1836240368);
            if(this.iteration <= 0)
            {
                    this.iteration = this.downsample;
                1 = this.iteration & 31;
            }
            
            UnityEngine.RenderTextureFormat val_14 = source.format;
            UnityEngine.RenderTexture val_15 = source >> 1;
            UnityEngine.RenderTexture val_16 = UnityEngine.RenderTexture.GetTemporary(width:  val_15, height:  source >> 1, depthBuffer:  0, format:  source);
            val_15.filterMode = 1;
            source.filterMode = 1;
            val_22 = this.material;
            UnityEngine.Graphics.Blit(source:  source, dest:  val_15, mat:  val_22, pass:  0);
            val_23 = this.iteration;
            if((val_23 + 1) >= 3)
            {
                    var val_20 = 2;
                do
            {
                val_23 = this.iteration;
                val_20 = val_20 + 1;
            }
            while(val_20 < (val_23 + 1));
            
            }
            
            int val_19 = val_23 - 1;
            if(val_19 >= 1)
            {
                    do
            {
                val_19 = val_19 - 1;
            }
            while(val_19 > 0);
            
            }
            
            UnityEngine.Graphics.Blit(source:  val_15, dest:  this.<BlurredScreen>k__BackingField, mat:  this.material, pass:  0);
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_15);
        }
        protected virtual void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
        {
            UnityEngine.RenderTexture val_3;
            var val_4;
            val_3 = source;
            float val_1 = UnityEngine.Time.unscaledTime;
            float val_4 = 1f;
            float val_3 = this.lastUpdate;
            val_3 = 0 - val_3;
            val_4 = val_4 / this.maxUpdateRate;
            if(static_value_021FDA47 <= false)
            {
                    val_4 = 2139095040;
            }
            
            float val_2 = UnityEngine.Time.unscaledTime;
            this.lastUpdate = 0f;
            if(this.preview != false)
            {
                    val_4 = 1152921504759189504;
                val_3 = this.<BlurredScreen>k__BackingField;
            }
            else
            {
                    val_4 = 1152921504759189504;
            }
            
            UnityEngine.Graphics.Blit(source:  val_3, dest:  destination);
        }
        public TranslucentImageSource()
        {
            this.maxUpdateRate = Infinityf;
            this.size = 5f;
            this.iteration = 4;
            this.maxDepth = 4;
        }
    
    }

}
