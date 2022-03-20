using UnityEngine;

namespace SRF
{
    public static class SRFFloatExtensions
    {
        // Methods
        public static float Sqr(float f)
        {
            uint val_1 = 0;
            val_1 = val_1 * val_1;
            return (float)val_1;
        }
        public static float SqrRt(float f)
        {
            return (float)f;
        }
        public static bool ApproxZero(float f)
        {
            return UnityEngine.Mathf.Approximately(a:  f, b:  null);
        }
        public static bool Approx(float f, float f2)
        {
            return UnityEngine.Mathf.Approximately(a:  f, b:  f2);
        }
    
    }

}
