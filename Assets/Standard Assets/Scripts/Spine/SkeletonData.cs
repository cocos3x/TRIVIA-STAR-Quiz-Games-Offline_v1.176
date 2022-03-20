using UnityEngine;

namespace Spine
{
    public class SkeletonData
    {
        // Fields
        internal string name;
        internal Spine.ExposedList<Spine.BoneData> bones;
        internal Spine.ExposedList<Spine.SlotData> slots;
        internal Spine.ExposedList<Spine.Skin> skins;
        internal Spine.Skin defaultSkin;
        internal Spine.ExposedList<Spine.EventData> events;
        internal Spine.ExposedList<Spine.Animation> animations;
        internal Spine.ExposedList<Spine.IkConstraintData> ikConstraints;
        internal Spine.ExposedList<Spine.TransformConstraintData> transformConstraints;
        internal Spine.ExposedList<Spine.PathConstraintData> pathConstraints;
        internal float width;
        internal float height;
        internal string version;
        internal string hash;
        internal float fps;
        internal string imagesPath;
        
        // Properties
        public string Name { get; set; }
        public Spine.ExposedList<Spine.BoneData> Bones { get; }
        public Spine.ExposedList<Spine.SlotData> Slots { get; }
        public Spine.ExposedList<Spine.Skin> Skins { get; set; }
        public Spine.Skin DefaultSkin { get; set; }
        public Spine.ExposedList<Spine.EventData> Events { get; set; }
        public Spine.ExposedList<Spine.Animation> Animations { get; set; }
        public Spine.ExposedList<Spine.IkConstraintData> IkConstraints { get; set; }
        public Spine.ExposedList<Spine.TransformConstraintData> TransformConstraints { get; set; }
        public Spine.ExposedList<Spine.PathConstraintData> PathConstraints { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public string Version { get; set; }
        public string Hash { get; set; }
        public string ImagesPath { get; set; }
        public float Fps { get; set; }
        
        // Methods
        public string get_Name()
        {
        
        }
        public void set_Name(string value)
        {
            this.name = value;
        }
        public Spine.ExposedList<Spine.BoneData> get_Bones()
        {
        
        }
        public Spine.ExposedList<Spine.SlotData> get_Slots()
        {
        
        }
        public Spine.ExposedList<Spine.Skin> get_Skins()
        {
        
        }
        public void set_Skins(Spine.ExposedList<Spine.Skin> value)
        {
            this.skins = value;
        }
        public Spine.Skin get_DefaultSkin()
        {
        
        }
        public void set_DefaultSkin(Spine.Skin value)
        {
            this.defaultSkin = value;
        }
        public Spine.ExposedList<Spine.EventData> get_Events()
        {
        
        }
        public void set_Events(Spine.ExposedList<Spine.EventData> value)
        {
            this.events = value;
        }
        public Spine.ExposedList<Spine.Animation> get_Animations()
        {
        
        }
        public void set_Animations(Spine.ExposedList<Spine.Animation> value)
        {
            this.animations = value;
        }
        public Spine.ExposedList<Spine.IkConstraintData> get_IkConstraints()
        {
        
        }
        public void set_IkConstraints(Spine.ExposedList<Spine.IkConstraintData> value)
        {
            this.ikConstraints = value;
        }
        public Spine.ExposedList<Spine.TransformConstraintData> get_TransformConstraints()
        {
        
        }
        public void set_TransformConstraints(Spine.ExposedList<Spine.TransformConstraintData> value)
        {
            this.transformConstraints = value;
        }
        public Spine.ExposedList<Spine.PathConstraintData> get_PathConstraints()
        {
        
        }
        public void set_PathConstraints(Spine.ExposedList<Spine.PathConstraintData> value)
        {
            this.pathConstraints = value;
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
        public string get_Version()
        {
        
        }
        public void set_Version(string value)
        {
            this.version = value;
        }
        public string get_Hash()
        {
        
        }
        public void set_Hash(string value)
        {
            this.hash = value;
        }
        public string get_ImagesPath()
        {
        
        }
        public void set_ImagesPath(string value)
        {
            this.imagesPath = value;
        }
        public float get_Fps()
        {
            return (float)S0;
        }
        public void set_Fps(float value)
        {
            this.fps = ;
        }
        public Spine.BoneData FindBone(string boneName)
        {
            var val_3;
            var val_4;
            if(boneName != null)
            {
                    if(this.bones != 0)
            {
                
            }
            else
            {
                    val_3 = 0;
            }
            
                if(R7 >= 1)
            {
                    var val_1 = val_3 + 16;
                var val_4 = 0;
                do
            {
                val_4 = mem[(val_3 + 16) + 0];
                val_4 = (val_3 + 16) + 0;
                if((System.String.op_Equality(a:  (val_3 + 16) + 0 + 12, b:  boneName)) == true)
            {
                    return;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < R7);
            
            }
            
                val_4 = 0;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1939633216, message:  1939633312);
        }
        public int FindBoneIndex(string boneName)
        {
            var val_3;
            var val_4;
            if(boneName == null)
            {
                goto label_1;
            }
            
            if(this.bones != 0)
            {
                
            }
            else
            {
                    val_3 = 0;
            }
            
            val_4 = 0;
            if(R7 < 1)
            {
                    return (int)val_4;
            }
            
            var val_1 = val_3 + 16;
            var val_4 = 0;
            label_9:
            if((System.String.op_Equality(a:  (val_3 + 16) + 0 + 12, b:  boneName)) == true)
            {
                goto label_8;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < R7)
            {
                goto label_9;
            }
            
            return (int)val_4;
            label_8:
            val_4 = val_4;
            return (int)val_4;
            label_1:
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1939633216, message:  1939633312);
        }
        public Spine.SlotData FindSlot(string slotName)
        {
            var val_3;
            if(slotName != null)
            {
                    if(R7 >= 1)
            {
                    var val_3 = 0;
                do
            {
                if((System.String.op_Equality(a:  Spine.SkeletonData.__il2cppRuntimeField_byval_arg + 12, b:  slotName)) == true)
            {
                    return;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < R7);
            
            }
            
                val_3 = 0;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1939892256, message:  1939892352);
        }
        public int FindSlotIndex(string slotName)
        {
            var val_3;
            if(slotName == null)
            {
                goto label_1;
            }
            
            val_3 = 0;
            if(R7 < 1)
            {
                    return (int)val_3;
            }
            
            var val_4 = 0;
            label_8:
            var val_1 = 35650832 + 0;
            if((System.String.op_Equality(a:  (35650832 + 0) + 16 + 12, b:  slotName)) == true)
            {
                goto label_7;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < R7)
            {
                goto label_8;
            }
            
            return (int)val_3;
            label_7:
            val_3 = val_4;
            return (int)val_3;
            label_1:
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1939892256, message:  1939892352);
        }
        public Spine.Skin FindSkin(string skinName)
        {
            var val_3;
            var val_6;
            if(skinName == null)
            {
                goto label_1;
            }
            
            ExposedList.Enumerator<T> val_1 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            val_6 = val_3;
            if((System.String.op_Equality(a:  val_3 + 8, b:  skinName)) == false)
            {
                goto label_5;
            }
            
            goto label_6;
            label_3:
            val_6 = 0;
            label_6:
            Dispose();
            return;
            label_1:
            System.ArgumentNullException val_5 = new System.ArgumentNullException(paramName:  1940151408, message:  1954559552);
            if((public Spine.Skin Spine.SkeletonData::FindSkin(string skinName)) == 1)
            {
                    Dispose();
                if(null == 0)
            {
                    return;
            }
            
                return;
            }
        
        }
        public Spine.EventData FindEvent(string eventDataName)
        {
            var val_3;
            var val_6;
            if(eventDataName == null)
            {
                goto label_1;
            }
            
            ExposedList.Enumerator<T> val_1 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            val_6 = val_3;
            if((System.String.op_Equality(a:  val_3 + 8, b:  eventDataName)) == false)
            {
                goto label_5;
            }
            
            goto label_6;
            label_3:
            val_6 = 0;
            label_6:
            Dispose();
            return;
            label_1:
            System.ArgumentNullException val_5 = new System.ArgumentNullException(paramName:  1954692160, message:  1954692256);
            if((public Spine.EventData Spine.SkeletonData::FindEvent(string eventDataName)) == 1)
            {
                    Dispose();
                if(null == 0)
            {
                    return;
            }
            
                return;
            }
        
        }
        public Spine.Animation FindAnimation(string animationName)
        {
            var val_3;
            if(animationName != null)
            {
                    if(R7 >= 1)
            {
                    var val_3 = 0;
                do
            {
                if((System.String.op_Equality(a:  Spine.SkeletonData.__il2cppRuntimeField_byval_arg + 16, b:  animationName)) == true)
            {
                    return;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < R7);
            
            }
            
                val_3 = 0;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1869090864, message:  1954825888);
        }
        public Spine.IkConstraintData FindIkConstraint(string constraintName)
        {
            var val_3;
            if(constraintName != null)
            {
                    if(R7 >= 1)
            {
                    var val_3 = 0;
                do
            {
                if((System.String.op_Equality(a:  Spine.SkeletonData.__il2cppRuntimeField_byval_arg + 8, b:  constraintName)) == true)
            {
                    return;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < R7);
            
            }
            
                val_3 = 0;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1940858480, message:  1940858576);
        }
        public Spine.TransformConstraintData FindTransformConstraint(string constraintName)
        {
            var val_3;
            if(constraintName != null)
            {
                    if(R7 >= 1)
            {
                    var val_3 = 0;
                do
            {
                if((System.String.op_Equality(a:  Spine.SkeletonData.__il2cppRuntimeField_byval_arg + 8, b:  constraintName)) == true)
            {
                    return;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < R7);
            
            }
            
                val_3 = 0;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1940858480, message:  1940858576);
        }
        public Spine.PathConstraintData FindPathConstraint(string constraintName)
        {
            var val_3;
            if(constraintName != null)
            {
                    if(SB >= 1)
            {
                    var val_3 = 0;
                do
            {
                if((Spine.SkeletonData.__il2cppRuntimeField_byval_arg + 8.Equals(value:  constraintName)) == true)
            {
                    return;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < SB);
            
            }
            
                val_3 = 0;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1940858480, message:  1940858576);
        }
        public int FindPathConstraintIndex(string pathConstraintName)
        {
            var val_4;
            if(pathConstraintName == null)
            {
                goto label_1;
            }
            
            val_4 = 0;
            if(this < 1)
            {
                    return (int)val_4;
            }
            
            var val_4 = 0;
            label_9:
            var val_1 = R6 + 0;
            if(((R6 + 0) + 16 + 8.Equals(value:  pathConstraintName)) == true)
            {
                goto label_8;
            }
            
            val_4 = val_4 + 1;
            if(val_4 < this)
            {
                goto label_9;
            }
            
            return (int)val_4;
            label_8:
            val_4 = val_4;
            return (int)val_4;
            label_1:
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1955372320, message:  1955372432);
        }
        public override string ToString()
        {
            if(this.name != null)
            {
                    this = this.name;
                return;
            }
            
            return this.ToString();
        }
        public SkeletonData()
        {
            Spine.ExposedList<UnityEngine.Material> val_1 = new Spine.ExposedList<UnityEngine.Material>();
            this.bones = null;
            Spine.ExposedList<UnityEngine.Material> val_2 = new Spine.ExposedList<UnityEngine.Material>();
            this.slots = null;
            Spine.ExposedList<UnityEngine.Material> val_3 = new Spine.ExposedList<UnityEngine.Material>();
            this.skins = null;
            Spine.ExposedList<UnityEngine.Material> val_4 = new Spine.ExposedList<UnityEngine.Material>();
            this.events = null;
            Spine.ExposedList<UnityEngine.Material> val_5 = new Spine.ExposedList<UnityEngine.Material>();
            this.animations = null;
            Spine.ExposedList<UnityEngine.Material> val_6 = new Spine.ExposedList<UnityEngine.Material>();
            this.ikConstraints = null;
            Spine.ExposedList<UnityEngine.Material> val_7 = new Spine.ExposedList<UnityEngine.Material>();
            this.transformConstraints = null;
            Spine.ExposedList<UnityEngine.Material> val_8 = new Spine.ExposedList<UnityEngine.Material>();
            this.pathConstraints = null;
        }
    
    }

}
