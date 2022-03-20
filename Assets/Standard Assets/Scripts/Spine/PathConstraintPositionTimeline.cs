using UnityEngine;

namespace Spine
{
    public class PathConstraintPositionTimeline : CurveTimeline
    {
        // Fields
        public const int ENTRIES = 2;
        protected const int PREV_TIME = -2;
        protected const int PREV_VALUE = -1;
        protected const int VALUE = 1;
        internal int pathConstraintIndex;
        internal float[] frames;
        
        // Properties
        public override int PropertyId { get; }
        public int PathConstraintIndex { get; set; }
        public float[] Frames { get; set; }
        
        // Methods
        public override int get_PropertyId()
        {
            int val_1 = this.pathConstraintIndex;
            val_1 = val_1 + 184549376;
            return (int)val_1;
        }
        public PathConstraintPositionTimeline(int frameCount)
        {
            int val_1 = frameCount << 1;
            this.frames = null;
        }
        public int get_PathConstraintIndex()
        {
            return (int)this.pathConstraintIndex;
        }
        public void set_PathConstraintIndex(int value)
        {
            this.pathConstraintIndex = value;
        }
        public float[] get_Frames()
        {
        
        }
        public void set_Frames(float[] value)
        {
            this.frames = value;
        }
        public void SetFrame(int frameIndex, float time, float value)
        {
            int val_1 = frameIndex << 1;
            this.frames[val_1] = R2;
            this.frames[val_1 | 1] = R3;
        }
        public override void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction)
        {
            var val_2;
            int val_12;
            float val_14;
            var val_15;
            var val_16;
            var val_17;
            val_12 = pose;
            Spine.ExposedList<Spine.PathConstraint> val_12 = skeleton.pathConstraints;
            Spine.ExposedList<Spine.PathConstraint> val_1 = val_12 + (this.pathConstraintIndex << 2);
            float val_11 = this.frames[0];
            if(val_1 <= 0)
            {
                goto label_6;
            }
            
            if(val_2 == 1)
            {
                goto label_7;
            }
            
            if(val_2 != 0)
            {
                    return;
            }
            
            mem2[0] = this.pathConstraintIndex + 8 + 40;
            return;
            label_6:
            val_12 = val_1 - 2;
            if(val_1 > 1)
            {
                    val_12 = Spine.Animation.BinarySearch(values:  this.frames, target:  this.frames[val_12], step:  val_12);
                val_12 = val_12 - 1;
                float val_15 = this.frames[val_12];
                int val_17 = 0;
                float val_16 = this.frames[val_12 - 2];
                val_16 = val_16 - val_15;
                val_17 = val_17 + ((val_12 + (val_12 >> 31)) >> 1);
                val_16 = (val_12 - val_15) / val_16;
                val_16 = 1f - val_16;
                float val_8 = this.GetCurvePercent(frameIndex:  val_17, percent:  val_16);
                float val_18 = this.frames[val_12 + 1];
                val_18 = val_18 - this.frames[val_12];
            }
            else
            {
                    val_12 = this.frames[val_12] - 1;
                val_14 = this.frames[val_12];
            }
            
            if(val_2 != 0)
            {
                    val_15 = this.pathConstraintIndex + 20;
                if(this.pathConstraintIndex == 0)
            {
                    val_15 = mem[this.pathConstraintIndex + 20];
                val_15 = this.pathConstraintIndex + 20;
            }
            
                float val_10 = val_14 - val_15;
                mem2[0] = this.pathConstraintIndex + 20;
                return;
            }
            
            val_16 = this.pathConstraintIndex + 8;
            if((this.pathConstraintIndex + 8) != 0)
            {
                goto label_24;
            }
            
            val_16 = mem[this.pathConstraintIndex + 8];
            val_16 = this.pathConstraintIndex + 8;
            if(val_16 == 0)
            {
                goto label_25;
            }
            
            label_24:
            var val_19 = this.pathConstraintIndex + 8 + 40;
            val_19 = val_14 - val_19;
            mem2[0] = this.pathConstraintIndex + 8 + 40;
            return;
            label_7:
            if(this.pathConstraintIndex != 0)
            {
                    val_17 = this.pathConstraintIndex + 20;
            }
            else
            {
                    val_17 = 20;
            }
            
            val_17 = (this.pathConstraintIndex + 8 + 40) - val_17;
            mem[20] = 1.401298E-45f;
            return;
            label_25:
        }
    
    }

}
