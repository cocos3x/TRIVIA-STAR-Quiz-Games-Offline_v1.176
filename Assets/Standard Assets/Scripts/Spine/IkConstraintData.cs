using UnityEngine;

namespace Spine
{
    public class IkConstraintData
    {
        // Fields
        internal string name;
        internal int order;
        internal System.Collections.Generic.List<Spine.BoneData> bones;
        internal Spine.BoneData target;
        internal int bendDirection;
        internal float mix;
        
        // Properties
        public string Name { get; }
        public int Order { get; set; }
        public System.Collections.Generic.List<Spine.BoneData> Bones { get; }
        public Spine.BoneData Target { get; set; }
        public int BendDirection { get; set; }
        public float Mix { get; set; }
        
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
        public System.Collections.Generic.List<Spine.BoneData> get_Bones()
        {
        
        }
        public Spine.BoneData get_Target()
        {
        
        }
        public void set_Target(Spine.BoneData value)
        {
            this.target = value;
        }
        public int get_BendDirection()
        {
            return (int)this.bendDirection;
        }
        public void set_BendDirection(int value)
        {
            this.bendDirection = value;
        }
        public float get_Mix()
        {
            return (float)S0;
        }
        public void set_Mix(float value)
        {
            this.mix = ;
        }
        public IkConstraintData(string name)
        {
            string val_2 = name;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.bones = null;
            this.bendDirection = 1;
            this.mix = 1f;
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
