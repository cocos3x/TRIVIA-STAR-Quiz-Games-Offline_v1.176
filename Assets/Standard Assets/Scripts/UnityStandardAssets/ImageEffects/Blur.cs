using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
    public class Blur : MonoBehaviour
    {
        // Fields
        public int iterations;
        public float blurSpread;
        public UnityEngine.Shader blurShader;
        private static UnityEngine.Material m_Material;
        
        // Properties
        protected UnityEngine.Material material { get; }
        
        // Methods
        protected UnityEngine.Material get_material()
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            if(UnityStandardAssets.ImageEffects.Blur.m_Material == 0)
            {
                    val_4 = null;
                val_4 = null;
                UnityStandardAssets.ImageEffects.Blur.m_Material = new UnityEngine.Material(shader:  this.blurShader);
                hideFlags = 52;
            }
            
            val_5 = null;
            val_5 = null;
        }
        protected void OnDisable()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((UnityEngine.Object.op_Implicit(exists:  UnityStandardAssets.ImageEffects.Blur.m_Material)) == false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            UnityEngine.Object.DestroyImmediate(obj:  UnityStandardAssets.ImageEffects.Blur.m_Material);
        }
        protected void Start()
        {
            var val_7 = this;
            if(UnityEngine.SystemInfo.supportsImageEffects != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  this.blurShader)) != false)
            {
                    UnityEngine.Material val_3 = this.material;
                UnityEngine.Shader val_4 = this.shader;
                if(this.isSupported == true)
            {
                    return;
            }
            
            }
            
            }
            
            R4.enabled = false;
        }
        public void FourTapCone(UnityEngine.RenderTexture source, UnityEngine.RenderTexture dest, int iteration)
        {
            UnityEngine.Material val_1 = this.material;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  (float)iteration, y:  null);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_10 = val_2.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_14 = val_2.y;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  (float)iteration, y:  null);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_18 = val_3.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_1C = val_3.y;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  (float)iteration, y:  null);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_4.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24 = val_4.y;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  (float)iteration, y:  null);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_5.x;
            UnityEngine.Graphics.BlitMultiTap(source:  source, dest:  dest, mat:  2097328384, offsets:  533908128);
        }
        private void DownSample4x(UnityEngine.RenderTexture source, UnityEngine.RenderTexture dest)
        {
            UnityEngine.Material val_1 = this.material;
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  null, y:  null);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_10 = val_2.x;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  null, y:  null);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_18 = val_3.x;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  null, y:  null);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_4.x;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  null, y:  null);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_5.x;
            UnityEngine.Graphics.BlitMultiTap(source:  source, dest:  dest, mat:  2097456768, offsets:  533908128);
        }
        private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
        {
            var val_7;
            UnityEngine.RenderTexture val_8;
            UnityEngine.RenderTexture val_9;
            UnityEngine.RenderTexture val_7 = source;
            val_7 = val_7 + ((val_7 >> 31) >> 29);
            UnityEngine.RenderTexture val_2 = val_7 >> 3;
            UnityEngine.RenderTexture val_8 = source;
            val_8 = val_8 + ((val_8 >> 31) >> 29);
            val_7 = 0;
            UnityEngine.RenderTexture val_4 = val_8 >> 3;
            UnityEngine.RenderTexture val_5 = UnityEngine.RenderTexture.GetTemporary(width:  val_2, height:  val_4, depthBuffer:  0);
            val_8 = val_2;
            this.DownSample4x(source:  source, dest:  val_8);
            if(this.iterations >= 1)
            {
                    do
            {
                UnityEngine.RenderTexture val_6 = UnityEngine.RenderTexture.GetTemporary(width:  val_2, height:  val_4, depthBuffer:  0);
                val_9 = val_2;
                this.FourTapCone(source:  val_8, dest:  val_9, iteration:  0);
                UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_8);
                val_7 = val_7 + 1;
                val_8 = val_9;
            }
            while(val_7 < this.iterations);
            
            }
            else
            {
                    val_9 = val_8;
            }
            
            UnityEngine.Graphics.Blit(source:  val_9, dest:  destination);
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  val_9);
        }
        public Blur()
        {
            this.iterations = 3;
            this.blurSpread = 0.6f;
        }
        private static Blur()
        {
        
        }
    
    }

}
