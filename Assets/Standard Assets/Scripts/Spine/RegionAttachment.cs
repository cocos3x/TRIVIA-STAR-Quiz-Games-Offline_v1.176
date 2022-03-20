using UnityEngine;

namespace Spine
{
    public class RegionAttachment : Attachment
    {
        // Fields
        public const int BLX = 0;
        public const int BLY = 1;
        public const int ULX = 2;
        public const int ULY = 3;
        public const int URX = 4;
        public const int URY = 5;
        public const int BRX = 6;
        public const int BRY = 7;
        internal float x;
        internal float y;
        internal float rotation;
        internal float scaleX;
        internal float scaleY;
        internal float width;
        internal float height;
        internal float regionOffsetX;
        internal float regionOffsetY;
        internal float regionWidth;
        internal float regionHeight;
        internal float regionOriginalWidth;
        internal float regionOriginalHeight;
        internal float[] offset;
        internal float[] uvs;
        internal float r;
        internal float g;
        internal float b;
        internal float a;
        private string <Path>k__BackingField;
        public object RendererObject;
        
        // Properties
        public float X { get; set; }
        public float Y { get; set; }
        public float Rotation { get; set; }
        public float ScaleX { get; set; }
        public float ScaleY { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float R { get; set; }
        public float G { get; set; }
        public float B { get; set; }
        public float A { get; set; }
        public string Path { get; set; }
        public float RegionOffsetX { get; set; }
        public float RegionOffsetY { get; set; }
        public float RegionWidth { get; set; }
        public float RegionHeight { get; set; }
        public float RegionOriginalWidth { get; set; }
        public float RegionOriginalHeight { get; set; }
        public float[] Offset { get; }
        public float[] UVs { get; }
        
        // Methods
        public float get_X()
        {
            return (float)S0;
        }
        public void set_X(float value)
        {
            this.x = ;
        }
        public float get_Y()
        {
            return (float)S0;
        }
        public void set_Y(float value)
        {
            this.y = ;
        }
        public float get_Rotation()
        {
            return (float)S0;
        }
        public void set_Rotation(float value)
        {
            this.rotation = ;
        }
        public float get_ScaleX()
        {
            return (float)S0;
        }
        public void set_ScaleX(float value)
        {
            this.scaleX = ;
        }
        public float get_ScaleY()
        {
            return (float)S0;
        }
        public void set_ScaleY(float value)
        {
            this.scaleY = ;
        }
        public float get_Width()
        {
            return (float)S0;
        }
        public void set_Width(float value)
        {
            this.width = ;
        }
        public float get_Height()
        {
            return (float)S0;
        }
        public void set_Height(float value)
        {
            this.height = ;
        }
        public float get_R()
        {
            return (float)S0;
        }
        public void set_R(float value)
        {
            this.r = ;
        }
        public float get_G()
        {
            return (float)S0;
        }
        public void set_G(float value)
        {
            this.g = ;
        }
        public float get_B()
        {
            return (float)S0;
        }
        public void set_B(float value)
        {
            this.b = ;
        }
        public float get_A()
        {
            return (float)S0;
        }
        public void set_A(float value)
        {
            this.a = ;
        }
        public string get_Path()
        {
        
        }
        public void set_Path(string value)
        {
            this.<Path>k__BackingField = value;
        }
        public float get_RegionOffsetX()
        {
            return (float)S0;
        }
        public void set_RegionOffsetX(float value)
        {
            this.regionOffsetX = ;
        }
        public float get_RegionOffsetY()
        {
            return (float)S0;
        }
        public void set_RegionOffsetY(float value)
        {
            this.regionOffsetY = ;
        }
        public float get_RegionWidth()
        {
            return (float)S0;
        }
        public void set_RegionWidth(float value)
        {
            this.regionWidth = ;
        }
        public float get_RegionHeight()
        {
            return (float)S0;
        }
        public void set_RegionHeight(float value)
        {
            this.regionHeight = ;
        }
        public float get_RegionOriginalWidth()
        {
            return (float)S0;
        }
        public void set_RegionOriginalWidth(float value)
        {
            this.regionOriginalWidth = ;
        }
        public float get_RegionOriginalHeight()
        {
            return (float)S0;
        }
        public void set_RegionOriginalHeight(float value)
        {
            this.regionOriginalHeight = ;
        }
        public float[] get_Offset()
        {
        
        }
        public float[] get_UVs()
        {
        
        }
        public RegionAttachment(string name)
        {
            this.scaleX = 1f;
            this.scaleY = 1f;
            this.offset = null;
            this.uvs = null;
        }
        public void UpdateOffset()
        {
            float val_15 = this.regionOriginalHeight;
            float val_17 = this.width;
            float val_16 = this.regionOriginalWidth;
            val_15 = this.height / val_15;
            val_16 = val_17 / val_16;
            val_17 = val_17 * (-0.5f);
            float val_1 = this.scaleX * val_16;
            float val_4 = this.regionOffsetX * val_1;
            float val_5 = this.regionOffsetY * (this.scaleY * val_15);
            float val_7 = Spine.MathUtils.SinDeg(degrees:  Spine.MathUtils.CosDeg(degrees:  this.height * (-0.5f)));
            float val_19 = this.x;
            float val_18 = this.y;
            float val_8 = val_5 * this.rotation;
            float val_20 = val_18;
            float val_10 = val_4 * this.rotation;
            float val_11 = val_5 * this.rotation;
            this.offset[0] = val_19 - val_8;
            this.offset[1] = val_10 + val_20;
            val_1 = val_10 + val_18;
            this.offset[2] = val_19 - val_11;
            val_4 = val_4 * this.rotation;
            this.offset[3] = val_1;
            val_18 = val_4 + val_18;
            this.offset[4] = val_19 - val_11;
            val_19 = val_19 - val_8;
            this.offset[5] = val_18;
            val_20 = val_4 + val_20;
            this.offset[6] = val_19;
            this.offset[7] = val_20;
        }
        public void SetUVs(float u, float v, float u2, float v2, bool rotate)
        {
            var val_1;
            float val_2;
            if(val_1 == 0)
            {
                goto label_1;
            }
            
            this.uvs[4] = rotate;
            this.uvs[5] = val_2;
            this.uvs[6] = rotate;
            if(this < 8)
            {
                goto label_5;
            }
            
            this.uvs[7] = R2;
            this.uvs[0] = R3;
            this.uvs[1] = R2;
            this.uvs[2] = R3;
            goto label_17;
            label_1:
            this.uvs[2] = rotate;
            this.uvs[3] = val_2;
            this.uvs[4] = rotate;
            this.uvs[5] = R2;
            this.uvs[6] = R3;
            if(this < 8)
            {
                goto label_12;
            }
            
            this.uvs[0] = R3;
            this.uvs[7] = R2;
            goto label_20;
            label_5:
            this.uvs[7] = R2;
            this.uvs[0] = R3;
            this.uvs[1] = R2;
            this.uvs[2] = R3;
            label_17:
            goto label_18;
            label_12:
            this.uvs[7] = R2;
            this.uvs[0] = R3;
            label_20:
            label_18:
            mem2[0] = val_2;
        }
        public void ComputeWorldVertices(Spine.Bone bone, float[] worldVertices, int offset, int stride = 2)
        {
            float val_18;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            int val_20 = offset;
            if(bone != 0)
            {
                    val_18 = bone.a;
                val_19 = bone.b;
                val_20 = bone.worldX;
                val_21 = bone.c;
                val_22 = bone.worldY;
            }
            else
            {
                    val_20 = 0f;
                val_22 = 9.343217E-38f;
                val_18 = 1.401298E-45f;
                val_19 = 0f;
                val_21 = 0f;
            }
            
            float val_18 = this.offset[6];
            float val_19 = this.offset[7];
            worldVertices[val_20] = val_20 + (val_19 * val_19);
            worldVertices[val_20 + 1] = val_22 + (bone.d * val_19);
            val_20 = stride + val_20;
            float val_21 = this.offset[0];
            float val_22 = this.offset[1];
            worldVertices[val_20] = val_20 + (val_19 * val_22);
            worldVertices[val_20 + 1] = val_22 + (bone.d * val_22);
            val_20 = val_20 + stride;
            float val_23 = this.offset[2];
            float val_24 = this.offset[3];
            worldVertices[val_20] = val_20 + (val_19 * val_24);
            worldVertices[val_20 + 1] = val_22 + (bone.d * val_24);
            val_20 = val_20 + stride;
            float val_25 = this.offset[4];
            float val_26 = this.offset[5];
            val_20 = val_20 + (val_19 * val_26);
            val_20 = val_20 + 1;
            worldVertices[val_20] = val_20;
            val_22 = val_22 + (bone.d * val_26);
            worldVertices[val_20] = val_22;
        }
    
    }

}
