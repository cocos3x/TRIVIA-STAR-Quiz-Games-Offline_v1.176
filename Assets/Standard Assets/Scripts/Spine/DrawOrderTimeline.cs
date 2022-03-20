using UnityEngine;

namespace Spine
{
    public class DrawOrderTimeline : Timeline
    {
        // Fields
        internal float[] frames;
        private int[][] drawOrders;
        
        // Properties
        public float[] Frames { get; set; }
        public int[][] DrawOrders { get; set; }
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
        public int[][] get_DrawOrders()
        {
        
        }
        public void set_DrawOrders(int[][] value)
        {
            this.drawOrders = value;
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
            return 134217728;
        }
        public DrawOrderTimeline(int frameCount)
        {
            this.frames = null;
            this.drawOrders = null;
        }
        public void SetFrame(int frameIndex, float time, int[] drawOrder)
        {
            this.frames[frameIndex] = drawOrder;
            this.drawOrders[frameIndex] = R3;
        }
        public void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            System.Array val_1;
            int val_2;
            var val_8;
            var val_9;
            System.Single[] val_10;
            Spine.ExposedList<Spine.Slot> val_11;
            Spine.ExposedList<Spine.Slot> val_12;
            var val_14;
            var val_15;
            val_8 = this;
            val_9 = pose;
            val_10 = skeleton;
            if(val_10 != 0)
            {
                    val_11 = skeleton.drawOrder;
            }
            else
            {
                    val_11 = 1;
            }
            
            val_12 = skeleton.slots;
            if(20 == 1)
            {
                goto label_3;
            }
            
            val_10 = this.frames;
            float val_6 = val_10[0];
            if(20 <= 0)
            {
                goto label_6;
            }
            
            if(val_1 != 0)
            {
                    return;
            }
            
            label_3:
            System.Array.Copy(sourceArray:  val_1, sourceIndex:  0, destinationArray:  0, destinationIndex:  0, length:  20 = val_2);
            return;
            label_6:
            if(20 > 0)
            {
                    int val_4 = Spine.Animation.BinarySearch(values:  val_10, target:  val_10[20 - 1]);
            }
            
            val_14 = (val_10[20 - 1]) - 1;
            System.Int32[] val_8 = this.drawOrders[val_14];
            if(val_8 == null)
            {
                goto label_17;
            }
            
            val_10 = 0;
            if(this.drawOrders[val_14] < 1)
            {
                    return;
            }
            
            val_8 = this.drawOrders[val_14] - 1;
            var val_5 = val_10 + 16;
            val_12 = val_8 + 16;
            val_9 = 0;
            goto label_20;
            label_28:
            val_9 = 1;
            val_15 = mem[this.drawOrders[(this.frames[(val_2 - 1)] - 1)][0] + 12];
            val_15 = this.drawOrders[(this.frames[(val_2 - 1)] - 1)][0] + 12;
            label_20:
            mem2[0] = val_14[(this.drawOrders[(this.frames[(val_2 - 1)] - 1)][0] + 16) + 4];
            if(val_8 != val_9)
            {
                goto label_28;
            }
            
            return;
            label_17:
            val_11.Clear(clearArray:  true);
            if(val_10 < 1)
            {
                    return;
            }
            
            val_9 = 1152921510760764624;
            do
            {
                val_11.Add(item:  val_8[0]);
                val_14 = 0 + 1;
            }
            while(val_10 != val_14);
        
        }
    
    }

}
