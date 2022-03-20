using UnityEngine;

namespace AudienceNetwork.Utility
{
    internal class AdUtilityBridgeAndroid : AdUtilityBridge
    {
        // Methods
        private T GetPropertyOfDisplayMetrics<T>(string property)
        {
            var val_6;
            var val_7;
            var val_8;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1282230784);
            object val_2 = GetStatic<System.Object>(fieldName:  1282231936);
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_6 == 1)
            {
                    val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  1289746816, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_7 == 1)
            {
                    val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_4 = Call<UnityEngine.AndroidJavaObject>(methodName:  1300018448, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_8 == 1)
            {
                    val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_5 = Call<UnityEngine.AndroidJavaObject>(methodName:  1300018544, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            if(null == 0)
            {
                
            }
        
        }
        private double Density()
        {
            float val_1 = this.GetPropertyOfDisplayMetrics<System.Single>(property:  1300019680);
            return (double)D0;
        }
        public override double DeviceWidth()
        {
            int val_1 = this.GetPropertyOfDisplayMetrics<System.Int32>(property:  1339569952);
            return (double)D0;
        }
        public override double DeviceHeight()
        {
            int val_1 = this.GetPropertyOfDisplayMetrics<System.Int32>(property:  1339682048);
            return (double)D0;
        }
        public override double Width()
        {
            int val_1 = UnityEngine.Screen.width;
            return (double)D0;
        }
        public override double Height()
        {
            int val_1 = UnityEngine.Screen.height;
            return (double)D0;
        }
        public override double Convert(double deviceSize)
        {
            long val_2 = 1340042144;
            val_2 = R2 / val_2;
            return (double)this.Density();
        }
        public override void Prepare()
        {
            var val_2;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1340130144);
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            CallStatic(methodName:  1340130256, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public AdUtilityBridgeAndroid()
        {
            this = new System.Object();
        }
    
    }

}
