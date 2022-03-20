using UnityEngine;

namespace Spine
{
    public class BoneData
    {
        // Fields
        internal int index;
        internal string name;
        internal Spine.BoneData parent;
        internal float length;
        internal float x;
        internal float y;
        internal float rotation;
        internal float scaleX;
        internal float scaleY;
        internal float shearX;
        internal float shearY;
        internal Spine.TransformMode transformMode;
        
        // Properties
        public int Index { get; }
        public string Name { get; }
        public Spine.BoneData Parent { get; }
        public float Length { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Rotation { get; set; }
        public float ScaleX { get; set; }
        public float ScaleY { get; set; }
        public float ShearX { get; set; }
        public float ShearY { get; set; }
        public Spine.TransformMode TransformMode { get; set; }
        
        // Methods
        public int get_Index()
        {
            return (int)this.index;
        }
        public string get_Name()
        {
        
        }
        public Spine.BoneData get_Parent()
        {
        
        }
        public float get_Length()
        {
            return (float)S0;
        }
        public void set_Length(float value)
        {
            this.length = ;
        }
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
        public float get_ShearX()
        {
            return (float)S0;
        }
        public void set_ShearX(float value)
        {
            this.shearX = ;
        }
        public float get_ShearY()
        {
            return (float)S0;
        }
        public void set_ShearY(float value)
        {
            this.shearY = ;
        }
        public Spine.TransformMode get_TransformMode()
        {
        
        }
        public void set_TransformMode(Spine.TransformMode value)
        {
            this.transformMode = value;
        }
        public BoneData(int index, string name, Spine.BoneData parent)
        {
            Spine.BoneData val_1 = parent;
            this.scaleX = 1f;
            this.scaleY = 1f;
            val_1 = new System.Object();
            if(index <= 1)
            {
                goto label_1;
            }
            
            if(name != null)
            {
                    this.index = index;
                this.name = name;
                this.parent = val_1;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1679334848, message:  1842907312);
            label_2:
            label_1:
            System.ArgumentException val_3 = new System.ArgumentException(message:  1912724576, paramName:  1348647200);
            goto label_2;
        }
        public override string ToString()
        {
        
        }
    
    }

}
