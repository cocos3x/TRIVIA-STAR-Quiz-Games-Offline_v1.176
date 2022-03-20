using UnityEngine;

namespace AudienceNetwork
{
    internal class AdSettingsBridgeAndroid : AdSettingsBridge
    {
        // Methods
        public override void AddTestDevice(string deviceID)
        {
            bool val_2 = static_value_021FDAF1;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            UnityEngine.AndroidJavaClass val_1 = this.GetAdSettingsObject();
            typeof(System.Object[]).__il2cppRuntimeField_10 = deviceID;
            val_2.CallStatic(methodName:  1289026640, args:  472754880);
        }
        public override void SetUrlPrefix(string urlPrefix)
        {
            bool val_2 = static_value_021FDAF2;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            UnityEngine.AndroidJavaClass val_1 = this.GetAdSettingsObject();
            typeof(System.Object[]).__il2cppRuntimeField_10 = urlPrefix;
            val_2.CallStatic(methodName:  1289146928, args:  472754880);
        }
        public override void SetMixedAudience(bool mixedAudience)
        {
            bool val_2 = static_value_021FDAF3;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            UnityEngine.AndroidJavaClass val_1 = this.GetAdSettingsObject();
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_2.CallStatic(methodName:  1289263120, args:  472754880);
        }
        public override void SetDataProcessingOptions(string[] dataProcessingOptions)
        {
            bool val_2 = static_value_021FDAF4;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            UnityEngine.AndroidJavaClass val_1 = this.GetAdSettingsObject();
            typeof(System.Object[]).__il2cppRuntimeField_10 = dataProcessingOptions;
            val_2.CallStatic(methodName:  1289412096, args:  472754880);
        }
        public override void SetDataProcessingOptions(string[] dataProcessingOptions, int country, int state)
        {
            bool val_2 = static_value_021FDAF5;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            UnityEngine.AndroidJavaClass val_1 = this.GetAdSettingsObject();
            typeof(System.Object[]).__il2cppRuntimeField_10 = dataProcessingOptions;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            val_2.CallStatic(methodName:  1289412096, args:  472754880);
        }
        public override string GetBidderToken()
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
            UnityEngine.AndroidJavaClass val_4 = new UnityEngine.AndroidJavaClass(className:  1289746928);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            if(null != 0)
            {
                    return CallStatic<UnityEngine.AndroidJavaObject>(methodName:  1289747072, args:  472754880);
            }
            
            return CallStatic<UnityEngine.AndroidJavaObject>(methodName:  1289747072, args:  472754880);
        }
        private UnityEngine.AndroidJavaClass GetAdSettingsObject()
        {
            UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  1289859168);
        }
        public AdSettingsBridgeAndroid()
        {
            this = new System.Object();
        }
    
    }

}
