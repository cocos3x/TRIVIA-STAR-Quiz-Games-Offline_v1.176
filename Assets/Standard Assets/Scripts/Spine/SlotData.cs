using UnityEngine;

namespace Spine
{
    public class SlotData
    {
        // Fields
        internal int index;
        internal string name;
        internal Spine.BoneData boneData;
        internal float r;
        internal float g;
        internal float b;
        internal float a;
        internal float r2;
        internal float g2;
        internal float b2;
        internal bool hasSecondColor;
        internal string attachmentName;
        internal Spine.BlendMode blendMode;
        
        // Properties
        public int Index { get; }
        public string Name { get; }
        public Spine.BoneData BoneData { get; }
        public float R { get; set; }
        public float G { get; set; }
        public float B { get; set; }
        public float A { get; set; }
        public float R2 { get; set; }
        public float G2 { get; set; }
        public float B2 { get; set; }
        public bool HasSecondColor { get; set; }
        public string AttachmentName { get; set; }
        public Spine.BlendMode BlendMode { get; set; }
        
        // Methods
        public int get_Index()
        {
            return (int)this.index;
        }
        public string get_Name()
        {
        
        }
        public Spine.BoneData get_BoneData()
        {
        
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
        public float get_R2()
        {
            return (float)S0;
        }
        public void set_R2(float value)
        {
            this.r2 = ;
        }
        public float get_G2()
        {
            return (float)S0;
        }
        public void set_G2(float value)
        {
            this.g2 = ;
        }
        public float get_B2()
        {
            return (float)S0;
        }
        public void set_B2(float value)
        {
            this.b2 = ;
        }
        public bool get_HasSecondColor()
        {
            return (bool)this.hasSecondColor;
        }
        public void set_HasSecondColor(bool value)
        {
            this.hasSecondColor = value;
        }
        public string get_AttachmentName()
        {
        
        }
        public void set_AttachmentName(string value)
        {
            this.attachmentName = value;
        }
        public Spine.BlendMode get_BlendMode()
        {
        
        }
        public void set_BlendMode(Spine.BlendMode value)
        {
            this.blendMode = value;
        }
        public SlotData(int index, string name, Spine.BoneData boneData)
        {
            val_1 = new System.Object();
            if(index <= 1)
            {
                goto label_1;
            }
            
            if(val_1 != null)
            {
                    if(boneData != 0)
            {
                    this.index = index;
                this.name = val_1;
                this.boneData = boneData;
                return;
            }
            
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1965879536, message:  1965879632);
            label_3:
            label_1:
            System.ArgumentException val_3 = new System.ArgumentException(message:  1850229984, paramName:  1348647200);
            goto label_3;
        }
        public override string ToString()
        {
        
        }
    
    }

}
