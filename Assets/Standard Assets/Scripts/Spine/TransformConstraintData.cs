using UnityEngine;

namespace Spine
{
    public class TransformConstraintData
    {
        // Fields
        internal string name;
        internal int order;
        internal Spine.ExposedList<Spine.BoneData> bones;
        internal Spine.BoneData target;
        internal float rotateMix;
        internal float translateMix;
        internal float scaleMix;
        internal float shearMix;
        internal float offsetRotation;
        internal float offsetX;
        internal float offsetY;
        internal float offsetScaleX;
        internal float offsetScaleY;
        internal float offsetShearY;
        internal bool relative;
        internal bool local;
        
        // Properties
        public string Name { get; }
        public int Order { get; set; }
        public Spine.ExposedList<Spine.BoneData> Bones { get; }
        public Spine.BoneData Target { get; set; }
        public float RotateMix { get; set; }
        public float TranslateMix { get; set; }
        public float ScaleMix { get; set; }
        public float ShearMix { get; set; }
        public float OffsetRotation { get; set; }
        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
        public float OffsetScaleX { get; set; }
        public float OffsetScaleY { get; set; }
        public float OffsetShearY { get; set; }
        public bool Relative { get; set; }
        public bool Local { get; set; }
        
        // Methods
        public string get_Name()
        {
        
        }
        public int get_Order()
        {
            return (int)this.order;
        }
        public void set_Order(int value)
        {
            this.order = value;
        }
        public Spine.ExposedList<Spine.BoneData> get_Bones()
        {
        
        }
        public Spine.BoneData get_Target()
        {
        
        }
        public void set_Target(Spine.BoneData value)
        {
            this.target = value;
        }
        public float get_RotateMix()
        {
            return (float)S0;
        }
        public void set_RotateMix(float value)
        {
            this.rotateMix = ;
        }
        public float get_TranslateMix()
        {
            return (float)S0;
        }
        public void set_TranslateMix(float value)
        {
            this.translateMix = ;
        }
        public float get_ScaleMix()
        {
            return (float)S0;
        }
        public void set_ScaleMix(float value)
        {
            this.scaleMix = ;
        }
        public float get_ShearMix()
        {
            return (float)S0;
        }
        public void set_ShearMix(float value)
        {
            this.shearMix = ;
        }
        public float get_OffsetRotation()
        {
            return (float)S0;
        }
        public void set_OffsetRotation(float value)
        {
            this.offsetRotation = ;
        }
        public float get_OffsetX()
        {
            return (float)S0;
        }
        public void set_OffsetX(float value)
        {
            this.offsetX = ;
        }
        public float get_OffsetY()
        {
            return (float)S0;
        }
        public void set_OffsetY(float value)
        {
            this.offsetY = ;
        }
        public float get_OffsetScaleX()
        {
            return (float)S0;
        }
        public void set_OffsetScaleX(float value)
        {
            this.offsetScaleX = ;
        }
        public float get_OffsetScaleY()
        {
            return (float)S0;
        }
        public void set_OffsetScaleY(float value)
        {
            this.offsetScaleY = ;
        }
        public float get_OffsetShearY()
        {
            return (float)S0;
        }
        public void set_OffsetShearY(float value)
        {
            this.offsetShearY = ;
        }
        public bool get_Relative()
        {
            return (bool)this.relative;
        }
        public void set_Relative(bool value)
        {
            this.relative = value;
        }
        public bool get_Local()
        {
            return (bool)this.local;
        }
        public void set_Local(bool value)
        {
            this.local = value;
        }
        public TransformConstraintData(string name)
        {
            string val_2 = name;
            Spine.ExposedList<UnityEngine.Material> val_1 = new Spine.ExposedList<UnityEngine.Material>();
            this.bones = null;
            val_2 = new System.Object();
            if(val_2 != null)
            {
                    this.name = val_2;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1679334848, message:  1842907312);
        }
        public override string ToString()
        {
        
        }
    
    }

}
