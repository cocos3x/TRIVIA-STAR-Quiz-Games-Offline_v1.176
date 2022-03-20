using UnityEngine;

namespace Spine
{
    public class EventTimeline : Timeline
    {
        // Fields
        internal float[] frames;
        private Spine.Event[] events;
        
        // Properties
        public float[] Frames { get; set; }
        public Spine.Event[] Events { get; set; }
        public int FrameCount { get; }
        public int PropertyId { get; }
        
        // Methods
        public float[] get_Frames()
        {
        
        }
        public void set_Frames(float[] value)
        {
            this.frames = value;
        }
        public Spine.Event[] get_Events()
        {
        
        }
        public void set_Events(Spine.Event[] value)
        {
            this.events = value;
        }
        public int get_FrameCount()
        {
            if(this.frames != null)
            {
                    return (int)this;
            }
            
            return (int)this;
        }
        public int get_PropertyId()
        {
            return 117440512;
        }
        public EventTimeline(int frameCount)
        {
            this.frames = null;
            this.events = null;
        }
        public void SetFrame(int frameIndex, Spine.Event e)
        {
            this.frames[frameIndex] = e.time;
            this.events[frameIndex] = e;
        }
        public void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            System.Single[] val_6;
            var val_7;
            float val_8;
            val_6 = pose;
            val_7 = firedEvents;
            if(direction == 0)
            {
                    return;
            }
            
            val_6 = this.frames;
            if(val_6 > null)
            {
                
            }
            else
            {
                    float val_6 = val_6[SB - 1];
                if(SB <= 0)
            {
                    return;
            }
            
            }
            
            float val_7 = val_6[0];
            if((val_6[SB - 1]) > null)
            {
                    return;
            }
            
            if((val_6[SB - 1]) == null)
            {
                    val_8 = val_6[0];
            }
            
            val_7 = 0;
            if((val_6[SB - 1]) < 0)
            {
                goto label_13;
            }
            
            int val_9 = Spine.Animation.BinarySearch(values:  val_6, target:  val_8);
            float val_8 = val_6[val_9];
            label_15:
            val_7 = val_9;
            if(val_9 <= 0)
            {
                goto label_13;
            }
            
            val_9 = val_7 - 1;
            val_6[val_9][12] = val_6[val_9][12] - 4;
            if(val_6[val_9] == val_9)
            {
                goto label_15;
            }
            
            label_13:
            if(val_7 >= SB)
            {
                    return;
            }
            
            do
            {
                if(val_6[val_7] > val_7)
            {
                    return;
            }
            
                direction.Add(item:  this.events[val_7]);
                val_7 = val_7 + 1;
            }
            while(val_7 < SB);
        
        }
    
    }

}
