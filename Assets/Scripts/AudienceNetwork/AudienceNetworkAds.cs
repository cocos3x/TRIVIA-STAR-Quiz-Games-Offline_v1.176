using UnityEngine;

namespace AudienceNetwork
{
    public static class AudienceNetworkAds
    {
        // Fields
        private static bool isInitialized;
        
        // Methods
        internal static void Initialize()
        {
            var val_6;
            if(AudienceNetwork.AudienceNetworkAds.IsInitialized() == true)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.SetString(key:  1303832368, value:  1303832464);
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  1282230784);
            object val_3 = GetStatic<System.Object>(fieldName:  1282231936);
            val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_6 == 1)
            {
                    val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_4 = Call<UnityEngine.AndroidJavaObject>(methodName:  1289746816, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            UnityEngine.AndroidJavaClass val_5 = new UnityEngine.AndroidJavaClass(className:  1303832544);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            CallStatic(methodName:  1129588848, args:  472754880);
            AudienceNetwork.AudienceNetworkAds.isInitialized = true;
        }
        internal static bool IsInitialized()
        {
            var val_5;
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1282230784);
            object val_2 = GetStatic<System.Object>(fieldName:  1282231936);
            val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_5 == 1)
            {
                    val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  1289746816, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            UnityEngine.AndroidJavaClass val_4 = new UnityEngine.AndroidJavaClass(className:  1303832544);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            if(null != 0)
            {
                    return CallStatic<System.Boolean>(methodName:  1692789312, args:  472754880);
            }
            
            return CallStatic<System.Boolean>(methodName:  1692789312, args:  472754880);
        }
    
    }

}
