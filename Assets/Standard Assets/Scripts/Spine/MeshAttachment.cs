using UnityEngine;

namespace Spine
{
    public class MeshAttachment : VertexAttachment
    {
        // Fields
        internal float regionOffsetX;
        internal float regionOffsetY;
        internal float regionWidth;
        internal float regionHeight;
        internal float regionOriginalWidth;
        internal float regionOriginalHeight;
        private Spine.MeshAttachment parentMesh;
        internal float[] uvs;
        internal float[] regionUVs;
        internal int[] triangles;
        internal float r;
        internal float g;
        internal float b;
        internal float a;
        internal int hulllength;
        internal bool inheritDeform;
        private string <Path>k__BackingField;
        public object RendererObject;
        private float <RegionU>k__BackingField;
        private float <RegionV>k__BackingField;
        private float <RegionU2>k__BackingField;
        private float <RegionV2>k__BackingField;
        private bool <RegionRotate>k__BackingField;
        private int[] <Edges>k__BackingField;
        private float <Width>k__BackingField;
        private float <Height>k__BackingField;
        
        // Properties
        public int HullLength { get; set; }
        public float[] RegionUVs { get; set; }
        public float[] UVs { get; set; }
        public int[] Triangles { get; set; }
        public float R { get; set; }
        public float G { get; set; }
        public float B { get; set; }
        public float A { get; set; }
        public string Path { get; set; }
        public float RegionU { get; set; }
        public float RegionV { get; set; }
        public float RegionU2 { get; set; }
        public float RegionV2 { get; set; }
        public bool RegionRotate { get; set; }
        public float RegionOffsetX { get; set; }
        public float RegionOffsetY { get; set; }
        public float RegionWidth { get; set; }
        public float RegionHeight { get; set; }
        public float RegionOriginalWidth { get; set; }
        public float RegionOriginalHeight { get; set; }
        public bool InheritDeform { get; set; }
        public Spine.MeshAttachment ParentMesh { get; set; }
        public int[] Edges { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        
        // Methods
        public int get_HullLength()
        {
            return (int)this.hulllength;
        }
        public void set_HullLength(int value)
        {
            this.hulllength = value;
        }
        public float[] get_RegionUVs()
        {
        
        }
        public void set_RegionUVs(float[] value)
        {
            this.regionUVs = value;
        }
        public float[] get_UVs()
        {
        
        }
        public void set_UVs(float[] value)
        {
            this.uvs = value;
        }
        public int[] get_Triangles()
        {
        
        }
        public void set_Triangles(int[] value)
        {
            this.triangles = value;
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
        public float get_RegionU()
        {
            return (float)S0;
        }
        public void set_RegionU(float value)
        {
            this.<RegionU>k__BackingField = ;
        }
        public float get_RegionV()
        {
            return (float)S0;
        }
        public void set_RegionV(float value)
        {
            this.<RegionV>k__BackingField = ;
        }
        public float get_RegionU2()
        {
            return (float)S0;
        }
        public void set_RegionU2(float value)
        {
            this.<RegionU2>k__BackingField = ;
        }
        public float get_RegionV2()
        {
            return (float)S0;
        }
        public void set_RegionV2(float value)
        {
            this.<RegionV2>k__BackingField = ;
        }
        public bool get_RegionRotate()
        {
            return (bool)this.<RegionRotate>k__BackingField;
        }
        public void set_RegionRotate(bool value)
        {
            this.<RegionRotate>k__BackingField = value;
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
        public bool get_InheritDeform()
        {
            return (bool)this.inheritDeform;
        }
        public void set_InheritDeform(bool value)
        {
            this.inheritDeform = value;
        }
        public Spine.MeshAttachment get_ParentMesh()
        {
        
        }
        public void set_ParentMesh(Spine.MeshAttachment value)
        {
            this.parentMesh = value;
            if(value == 0)
            {
                    return;
            }
            
            mem[1152921510794920368] = ???;
            mem[1152921510794920372] = ???;
            mem[1152921510794920376] = ???;
            this.regionUVs = value.regionUVs;
            this.triangles = value.triangles;
            this.hulllength = value.hulllength;
            this.<Edges>k__BackingField = value.<Edges>k__BackingField;
            this.<Width>k__BackingField = value.<Width>k__BackingField;
            this.<Height>k__BackingField = value.<Height>k__BackingField;
        }
        public int[] get_Edges()
        {
        
        }
        public void set_Edges(int[] value)
        {
            this.<Edges>k__BackingField = value;
        }
        public float get_Width()
        {
            return (float)S0;
        }
        public void set_Width(float value)
        {
            this.<Width>k__BackingField = ;
        }
        public float get_Height()
        {
            return (float)S0;
        }
        public void set_Height(float value)
        {
            this.<Height>k__BackingField = ;
        }
        public MeshAttachment(string name)
        {
        
        }
        public void UpdateUVs()
        {
            System.Single[] val_1;
            var val_2;
            float val_4 = this.<RegionV>k__BackingField;
            float val_3 = this.<RegionU2>k__BackingField;
            float val_2 = this.<RegionV2>k__BackingField;
            if(this.uvs == null)
            {
                goto label_1;
            }
            
            if(R1 != true)
            {
                goto label_5;
            }
            
            val_1 = this.uvs;
            goto label_4;
            label_1:
            label_5:
            val_1 = null;
            this.uvs = null;
            label_4:
            val_2 = val_2 - val_4;
            val_3 = val_3 - (this.<RegionU>k__BackingField);
            if((this.<RegionRotate>k__BackingField) != false)
            {
                    val_4 = val_4 + val_2;
                var val_5 = 0;
                var val_1 = val_5 + 1;
                System.Single[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = this.<RegionU>k__BackingField;
                System.Single[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_4 = val_4;
                val_5 = val_5 + 2;
                val_2 = 1152921505140742840;
                return;
            }
            
            var val_6 = 0;
            System.Single[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = this.<RegionU>k__BackingField;
            val_6 = val_6 + 1;
            System.Single[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_4 = val_4;
            val_6 = val_6 + 1;
        }
        public override bool ApplyDeform(Spine.VertexAttachment sourceAttachment)
        {
            if(this == sourceAttachment)
            {
                    this = 1;
                return (bool)this;
            }
            
            if(0 == 0)
            {
                    this = 0;
            }
            
            if(0 != 0)
            {
                    this = 6;
                this = this - sourceAttachment;
            }
            
            if(0 != 0)
            {
                    this = this >> 5;
            }
            
            return (bool)this;
        }
    
    }

}
