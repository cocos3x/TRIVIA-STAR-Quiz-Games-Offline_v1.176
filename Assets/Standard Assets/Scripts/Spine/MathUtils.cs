using UnityEngine;

namespace Spine
{
    public static class MathUtils
    {
        // Fields
        public const float PI = 3.141593;
        public const float PI2 = 6.283185;
        public const float RadDeg = 57.29578;
        public const float DegRad = 0.01745329;
        private const int SIN_BITS = 14;
        private const int SIN_MASK = 16383;
        private const int SIN_COUNT = 16384;
        private const float RadFull = 6.283185;
        private const float DegFull = 360;
        private const float RadToIndex = 2607.594;
        private const float DegToIndex = 45.51111;
        private static float[] sin;
        
        // Methods
        private static MathUtils()
        {
            var val_5 = 0;
            var val_6 = 16;
            Spine.MathUtils.sin = null;
            do
            {
                float val_4 = 0.5f;
                val_4 = val_4 * (6.103516E-05f);
                val_4 = val_4 * 6.283185f;
                val_5 = val_5 + 1;
                val_6 = val_6 + 4;
                mem2[0] = ;
            }
            while(val_5 != 16384);
            
            var val_7 = 0;
            do
            {
                float val_1 = 0f * 0.01745329f;
                System.Single[] val_3 = Spine.MathUtils.sin + ((0f * 45.51111f) << 2);
                val_7 = val_7 + 90;
                mem2[0] = 0f;
            }
            while(val_7 < 360);
        
        }
        public static float Sin(float radians)
        {
            null = null;
            float val_2 = 2607.594f;
            val_2 = 0 * val_2;
            System.Single[] val_1 = Spine.MathUtils.sin + (val_2 << 2);
            return (float)val_2;
        }
        public static float Cos(float radians)
        {
            null = null;
            float val_2 = 1.570796f;
            val_2 = 0 + val_2;
            val_2 = val_2 * 2607.594f;
            System.Single[] val_1 = Spine.MathUtils.sin + (val_2 << 2);
            return (float)val_2;
        }
        public static float SinDeg(float degrees)
        {
            null = null;
            float val_2 = 45.51111f;
            val_2 = 0 * val_2;
            System.Single[] val_1 = Spine.MathUtils.sin + (val_2 << 2);
            return (float)val_2;
        }
        public static float CosDeg(float degrees)
        {
            null = null;
            float val_2 = 90f;
            val_2 = 0 + val_2;
            val_2 = val_2 * 45.51111f;
            System.Single[] val_1 = Spine.MathUtils.sin + (val_2 << 2);
            return (float)val_2;
        }
        public static float Atan2(float y, float x)
        {
            if(static_value_021FFCCC == true)
            {
                    18677688 = 18677692;
            }
            
            return (float)y;
        }
        public static float Clamp(float value, float min, float max)
        {
            if()
            {
                    0 = R2;
            }
            
            return (float)0;
        }
    
    }

}
