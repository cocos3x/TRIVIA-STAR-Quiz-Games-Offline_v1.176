using UnityEngine;

namespace Spine
{
    public abstract class CurveTimeline : Timeline
    {
        // Fields
        protected const float LINEAR = 0;
        protected const float STEPPED = 1;
        protected const float BEZIER = 2;
        protected const int BEZIER_SIZE = 19;
        private float[] curves;
        
        // Properties
        public int FrameCount { get; }
        public abstract int PropertyId { get; }
        
        // Methods
        public int get_FrameCount()
        {
            return (int)null;
        }
        public CurveTimeline(int frameCount)
        {
            if(frameCount > 0)
            {
                    int val_1 = frameCount * 19;
                val_1 = val_1 - 19;
                this.curves = null;
                return;
            }
            
            string val_2 = 1843924736 + 13152256;
            System.ArgumentException val_3 = new System.ArgumentException(message:  1843924736, paramName:  1843924864);
        }
        public abstract void Apply(Spine.Skeleton skeleton, float lastTime, float time, Spine.ExposedList<Spine.Event> firedEvents, float alpha, Spine.MixPose pose, Spine.MixDirection direction); // 0
        public abstract int get_PropertyId(); // 0
        public void SetLinear(int frameIndex)
        {
            int val_1 = frameIndex;
            val_1 = val_1 * 19;
            this.curves[val_1] = 0f;
        }
        public void SetStepped(int frameIndex)
        {
            int val_1 = frameIndex;
            val_1 = val_1 * 19;
            this.curves[val_1] = 1f;
        }
        public void SetCurve(int frameIndex, float cx1, float cy1, float cx2, float cy2)
        {
            var val_3;
            var val_4;
            int val_1 = frameIndex * 19;
            int val_2 = val_1 + 1;
            val_1 = val_1 + 19;
            this.curves[val_1] = 2f;
            if(val_2 >= val_1)
            {
                    return;
            }
            
            float val_5 = R3 + R3;
            float val_7 = R3 - val_3;
            float val_8 = R2 - val_4;
            var val_18 = 96;
            val_5 = val_3 - val_5;
            float val_9 = val_4 - (R2 + R2);
            val_5 = val_5 * 0.03f;
            val_9 = val_9 * 0.03f;
            float val_16 = val_5;
            float val_17 = val_9;
            float val_12 = val_5 + val_5;
            float val_13 = val_9 + val_9;
            float val_19 = val_17;
            do
            {
                val_12 = (1f * 0.006f) + val_12;
                mem[96] = val_19;
                val_13 = (1f * 0.006f) + val_13;
                int val_14 = val_2 + 1;
                val_16 = val_16 + val_12;
                mem[100] = val_16;
                val_17 = val_17 + val_13;
                val_2 = val_2 + 2;
                val_18 = val_18 + 8;
                float val_15 = val_16 + val_16;
                val_19 = val_19 + val_17;
            }
            while(val_2 < val_1);
        
        }
        public float GetCurvePercent(int frameIndex, float percent)
        {
            var val_15;
            float val_16;
            float val_17;
            var val_18;
            float val_19;
            float val_21;
            float val_22;
            int val_16 = frameIndex;
            float val_1 = Spine.MathUtils.Clamp(value:  percent, min:  null, max:  null);
            val_15 = R2;
            int val_2 = val_16 * 19;
            val_16 = val_15;
            float val_13 = this.curves[val_2];
            if(19 == val_2)
            {
                    return (float)val_17;
            }
            
            if(19 == val_2)
            {
                goto label_6;
            }
            
            int val_3 = val_2 + 19;
            val_18 = val_2 + 1;
            if(val_18 >= val_3)
            {
                goto label_7;
            }
            
            var val_14 = 0;
            var val_15 = 88;
            label_10:
            val_15 = val_2 + val_14;
            if(76 >= (val_15 + 1))
            {
                goto label_9;
            }
            
            val_14 = val_14 + 2;
            val_15 = val_15 + 8;
            val_18 = (val_2 + val_14) + 1;
            if(val_18 < val_3)
            {
                goto label_10;
            }
            
            goto label_11;
            label_6:
            val_16 = 0f;
            return (float)val_17;
            label_7:
            val_19 = 0f;
            label_11:
            val_16 = val_18 - 1;
            float val_6 = val_16 - val_19;
            val_17 = this.curves[val_16];
            val_6 = val_6 * (1f - val_17);
            val_6 = val_6 / (1f - val_19);
            val_16 = val_17 + val_6;
            return (float)val_17;
            label_9:
            if(val_14 != 0)
            {
                    int val_9 = val_15 - 1;
                val_21 = 0f;
                val_22 = 0f;
            }
            else
            {
                    val_22 = 0f;
                val_21 = 0;
            }
            
            int val_10 = val_15 + 2;
            float val_17 = 9.343217E-38f;
            val_17 = val_17 - val_22;
            val_17 = (val_16 - val_21) * val_17;
            val_17 = val_17 / (0f - val_21);
            val_16 = val_22 + val_17;
            return (float)val_17;
        }
        public float GetCurveType(int frameIndex)
        {
            int val_1 = frameIndex;
            val_1 = val_1 * 19;
            float val_2 = this.curves[val_1];
            return (float)S0;
        }
    
    }

}
