using UnityEngine;

namespace AudienceNetwork.Utility
{
    public static class AdUtility
    {
        // Methods
        internal static double Width()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_2 = AudienceNetwork.Utility.AdUtilityBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal static double Height()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_2 = AudienceNetwork.Utility.AdUtilityBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal static double Convert(double deviceSize)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            var val_2 = 0;
            val_3 = 0;
            val_2 = val_2 + 1;
            val_3 = (uint)val_2 & 65535;
            val_4 = AudienceNetwork.Utility.AdUtilityBridge.Instance;
            return (double)deviceSize;
        }
        internal static void Prepare()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_2 = AudienceNetwork.Utility.AdUtilityBridge.Instance;
            goto mem[(Instance + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        internal static bool IsLandscape()
        {
            var val_4;
            UnityEngine.ScreenOrientation val_1 = UnityEngine.Screen.orientation;
            val_4 = 1;
            if(0 == 3)
            {
                    return (bool)val_4;
            }
            
            UnityEngine.ScreenOrientation val_2 = UnityEngine.Screen.orientation;
            if(0 == 3)
            {
                    return (bool)val_4;
            }
            
            UnityEngine.ScreenOrientation val_3 = UnityEngine.Screen.orientation;
            val_4 = 0;
            return (bool)val_4;
        }
    
    }

}
