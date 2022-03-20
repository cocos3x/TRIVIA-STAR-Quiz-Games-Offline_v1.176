using UnityEngine;

namespace Spine
{
    public class PathConstraintData
    {
        // Fields
        internal string name;
        internal int order;
        internal Spine.ExposedList<Spine.BoneData> bones;
        internal Spine.SlotData target;
        internal Spine.PositionMode positionMode;
        internal Spine.SpacingMode spacingMode;
        internal Spine.RotateMode rotateMode;
        internal float offsetRotation;
        internal float position;
        internal float spacing;
        internal float rotateMix;
        internal float translateMix;
        
        // Properties
        public string Name { get; }
        public int Order { get; set; }
        public Spine.ExposedList<Spine.BoneData> Bones { get; }
        public Spine.SlotData Target { get; set; }
        public Spine.PositionMode PositionMode { get; set; }
        public Spine.SpacingMode SpacingMode { get; set; }
        public Spine.RotateMode RotateMode { get; set; }
        public float OffsetRotation { get; set; }
        public float Position { get; set; }
        public float Spacing { get; set; }
        public float RotateMix { get; set; }
        public float TranslateMix { get; set; }
        
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
        public Spine.SlotData get_Target()
        {
        
        }
        public void set_Target(Spine.SlotData value)
        {
            this.target = value;
        }
        public Spine.PositionMode get_PositionMode()
        {
        
        }
        public void set_PositionMode(Spine.PositionMode value)
        {
            this.positionMode = value;
        }
        public Spine.SpacingMode get_SpacingMode()
        {
        
        }
        public void set_SpacingMode(Spine.SpacingMode value)
        {
            this.spacingMode = value;
        }
        public Spine.RotateMode get_RotateMode()
        {
        
        }
        public void set_RotateMode(Spine.RotateMode value)
        {
            this.rotateMode = value;
        }
        public float get_OffsetRotation()
        {
            return (float)S0;
        }
        public void set_OffsetRotation(float value)
        {
            this.offsetRotation = ;
        }
        public float get_Position()
        {
            return (float)S0;
        }
        public void set_Position(float value)
        {
            this.position = ;
        }
        public float get_Spacing()
        {
            return (float)S0;
        }
        public void set_Spacing(float value)
        {
            this.spacing = ;
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
        public PathConstraintData(string name)
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
