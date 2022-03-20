using UnityEngine;

namespace Spine
{
    public class Animation
    {
        // Fields
        internal Spine.ExposedList<Spine.Timeline> timelines;
        internal float duration;
        internal string name;
        
        // Properties
        public string Name { get; }
        public Spine.ExposedList<Spine.Timeline> Timelines { get; set; }
        public float Duration { get; set; }
        
        // Methods
        public string get_Name()
        {
        
        }
        public Spine.ExposedList<Spine.Timeline> get_Timelines()
        {
        
        }
        public void set_Timelines(Spine.ExposedList<Spine.Timeline> value)
        {
            this.timelines = value;
        }
        public float get_Duration()
        {
            return (float)S0;
        }
        public void set_Duration(float value)
        {
            this.duration = ;
        }
        public Animation(string name, Spine.ExposedList<Spine.Timeline> timelines, float duration)
        {
            val_1 = new System.Object();
            if(name != null)
            {
                    if(val_1 != 0)
            {
                    duration = R3;
                this.timelines = val_1;
                this.name = name;
                this.duration = duration;
                return;
            }
            
            }
            
            label_2:
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1842906064, message:  1842906160);
            goto label_2;
        }
        public void Apply(Spine.Skeleton skeleton, float lastTime, float time, bool loop, Spine.ExposedList<Spine.Event> events, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_5;
            var val_6;
            val_5 = this;
            if(skeleton == 0)
            {
                goto label_1;
            }
            
            if(SB < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            label_15:
            if(0 == 0)
            {
                goto label_11;
            }
            
            var val_7 = 0;
            label_13:
            if(1179403647 == null)
            {
                goto label_12;
            }
            
            val_7 = val_7 + 1;
            if(((uint)val_7 & 65535) < 0)
            {
                goto label_13;
            }
            
            label_11:
            val_6 = Spine.Animation.__il2cppRuntimeField_byval_arg;
            goto label_14;
            label_12:
            var val_2 = 0 + 0;
            label_14:
            val_8 = val_8 + 1;
            if(val_8 != SB)
            {
                goto label_15;
            }
            
            return;
            label_1:
            System.ArgumentNullException val_6 = new System.ArgumentNullException(paramName:  1843048096, message:  1843048192);
        }
        internal static int BinarySearch(float[] values, float target, int step)
        {
            var val_5;
            var val_7;
            var val_8;
            var val_9;
            val_5 = step;
            val_7 = R6 - 2;
            if(values == null)
            {
                goto label_1;
            }
            
            val_8 = ???;
            goto label_2;
            label_4:
            val_7 = val_7 + 0;
            label_2:
            var val_1 = 1 + (val_7 >> 1);
            var val_2 = val_1 * val_8;
            if(R6 <= val_2)
            {
                    val_8 = ???;
            }
            
            float val_4 = values[val_2];
            if(R6 <= val_2)
            {
                    val_5 = val_1;
            }
            
            if(R6 > val_2)
            {
                    val_7 = val_7 >> 1;
            }
            
            if(val_5 != val_7)
            {
                goto label_4;
            }
            
            val_9 = (val_7 + 1) * val_8;
            return (int)val_9;
            label_1:
            val_9 = ???;
            return (int)val_9;
        }
        internal static int BinarySearch(float[] values, float target)
        {
            var val_4;
            var val_5;
            val_4 = values - 2;
            if(values == null)
            {
                goto label_1;
            }
            
            goto label_2;
            label_4:
            label_2:
            var val_1 = 1 + (val_4[0] >> 1);
            float val_2 = values[val_1];
            if(values <= val_1)
            {
                    0 = val_1;
            }
            
            if(values > val_1)
            {
                    val_4 = val_4[0] >> 1;
            }
            
            if(0 != val_4)
            {
                goto label_4;
            }
            
            return (int)val_5;
            label_1:
            val_5 = 1;
            return (int)val_5;
        }
        internal static int LinearSearch(float[] values, float target, int step)
        {
            var val_3;
            var val_5;
            var val_6;
            val_3 = step;
            val_5 = 0;
            System.Single[] val_1 = values - R2;
            if(val_1 < null)
            {
                    return (int)val_5;
            }
            
            val_6 = 0;
            goto label_2;
            label_5:
            val_6 = val_6 + R2;
            if(val_6 > val_1)
            {
                    return (int)val_5;
            }
            
            label_2:
            if(values <= val_6)
            {
                goto label_5;
            }
            
            val_5 = val_6;
            return (int)val_5;
        }
    
    }

}
