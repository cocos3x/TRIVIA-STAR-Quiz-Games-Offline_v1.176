using UnityEngine;

namespace AudienceNetwork
{
    [Serializable]
    public class ExtraHints
    {
        // Fields
        private const int KEYWORDS_MAX_COUNT = 5;
        public System.Collections.Generic.List<string> keywords;
        public string extraData;
        public string contentURL;
        
        // Methods
        internal UnityEngine.AndroidJavaObject GetAndroidObject()
        {
            string val_6;
            var val_16;
            var val_17;
            System.Object[] val_18;
            UnityEngine.AndroidJavaObject val_19;
            string val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            val_16 = this;
            val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_17 == 1)
            {
                    val_17 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_17 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            val_18 = 1152921504786026496;
            val_19 = null;
            val_19 = new UnityEngine.AndroidJavaObject(className:  1304056688, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            if(val_19 == 0)
            {
                goto label_53;
            }
            
            if(this.keywords == 0)
            {
                goto label_8;
            }
            
            UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  1304060928);
            val_20 = public static T[] System.Array::Empty<System.Object>();
            val_21 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_21 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_21 == 1)
            {
                    val_21 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_21 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  1304062096, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_22 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_22 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_22 == 1)
            {
                    val_22 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_22 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            List.Enumerator<T> val_5 = GetEnumerator();
            goto label_41;
            label_42:
            val_23 = 0;
            do
            {
                val_24 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_24 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
                if(val_24 == 1)
            {
                    val_24 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_24 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
                val_18 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92];
                val_18 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92;
                UnityEngine.AndroidJavaObject val_7 = UnityEngine.AndroidJavaClass.__il2cppRuntimeField_byval_arg.Call<UnityEngine.AndroidJavaObject>(methodName:  1288748368, args:  val_18);
                val_20 = UnityEngine.AndroidJavaClass.__il2cppRuntimeField_byval_arg;
                string val_8 = val_20.ToLower();
                val_23 = val_23 + 1;
            }
            while((System.String.op_Equality(a:  val_20, b:  val_6)) == false);
            
            var val_16 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_10 = UnityEngine.AndroidJavaClass.__il2cppRuntimeField_byval_arg;
            bool val_10 = Call<System.Boolean>(methodName:  1304066384, args:  472754880);
            val_16 = val_16 + 1;
            label_41:
            bool val_11 = MoveNext();
            if(0 != 5)
            {
                goto label_42;
            }
            
            Dispose();
            typeof(System.Object[]).__il2cppRuntimeField_10 = new UnityEngine.AndroidJavaObject(className:  1304062176, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            UnityEngine.AndroidJavaObject val_12 = Call<UnityEngine.AndroidJavaObject>(methodName:  1304066464, args:  472754880);
            val_19 = val_19;
            label_8:
            if(this.extraData != null)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = this.extraData;
                UnityEngine.AndroidJavaObject val_13 = Call<UnityEngine.AndroidJavaObject>(methodName:  1146961040, args:  472754880);
                val_19 = val_19;
            }
            
            if(this.contentURL != null)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_10 = this.contentURL;
                UnityEngine.AndroidJavaObject val_14 = Call<UnityEngine.AndroidJavaObject>(methodName:  1304082944, args:  472754880);
                val_19 = val_19;
            }
            
            label_53:
            val_25 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_25 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_25 == 1)
            {
                    val_25 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
                val_25 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            }
            
            UnityEngine.AndroidJavaObject val_15 = Call<UnityEngine.AndroidJavaObject>(methodName:  1302251424, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        public ExtraHints()
        {
        
        }
    
    }

}
