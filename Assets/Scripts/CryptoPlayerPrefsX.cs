using UnityEngine;
public class CryptoPlayerPrefsX
{
    // Fields
    private static int endianDiff1;
    private static int endianDiff2;
    private static int idx;
    private static byte[] byteBlock;
    
    // Methods
    public static bool SetBool(string name, bool value)
    {
        CPlayerPrefs.SetInt(key:  name, val:  value);
        return true;
    }
    public static bool GetBool(string name)
    {
        int val_1 = CPlayerPrefs.GetInt(key:  name);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public static bool GetBool(string name, bool defaultValue)
    {
        if((CPlayerPrefs.HasKey(key:  name)) == false)
        {
                return (bool)defaultValue;
        }
        
        return CryptoPlayerPrefsX.GetBool(name:  name);
    }
    public static bool SetVector2(string key, UnityEngine.Vector2 vector)
    {
        typeof(System.Single[]).__il2cppRuntimeField_10 = vector.x;
        typeof(System.Single[]).__il2cppRuntimeField_14 = vector.y;
        return CryptoPlayerPrefsX.SetFloatArray(key:  key, floatArray:  533895840);
    }
    private static UnityEngine.Vector2 GetVector2(string key)
    {
        System.Single[] val_1 = CryptoPlayerPrefsX.GetFloatArray(key:  R1);
        if((R1 + 12) > 1)
        {
                mem2[0] = 0;
            mem2[0] = 0;
            key = new UnityEngine.Vector2(x:  null, y:  null);
            return new UnityEngine.Vector2();
        }
        
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
        return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
    }
    public static UnityEngine.Vector2 GetVector2(string key, UnityEngine.Vector2 defaultValue)
    {
        if((CPlayerPrefs.HasKey(key:  defaultValue.x)) == false)
        {
                return new UnityEngine.Vector2();
        }
        
        UnityEngine.Vector2 val_2 = CryptoPlayerPrefsX.GetVector2(key:  key);
        return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
    }
    public static bool SetVector3(string key, UnityEngine.Vector3 vector)
    {
        typeof(System.Single[]).__il2cppRuntimeField_10 = vector.x;
        typeof(System.Single[]).__il2cppRuntimeField_14 = vector.y;
        typeof(System.Single[]).__il2cppRuntimeField_18 = vector.z;
        return CryptoPlayerPrefsX.SetFloatArray(key:  key, floatArray:  533895840);
    }
    public static UnityEngine.Vector3 GetVector3(string key)
    {
        System.Single[] val_1 = CryptoPlayerPrefsX.GetFloatArray(key:  R1);
        if((R1 + 12) > 2)
        {
                var val_2 = R1 + 16;
            mem2[0] = 0;
            mem2[0] = 0;
            key.m_stringLength = 0;
            key = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            return new UnityEngine.Vector3();
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
    }
    public static UnityEngine.Vector3 GetVector3(string key, UnityEngine.Vector3 defaultValue)
    {
        int val_3;
        if((CPlayerPrefs.HasKey(key:  defaultValue.x)) != false)
        {
                UnityEngine.Vector3 val_2 = CryptoPlayerPrefsX.GetVector3(key:  key);
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        
        key.m_stringLength = val_3;
        return new UnityEngine.Vector3();
    }
    public static bool SetQuaternion(string key, UnityEngine.Quaternion vector)
    {
        typeof(System.Single[]).__il2cppRuntimeField_10 = vector.x;
        typeof(System.Single[]).__il2cppRuntimeField_14 = vector.y;
        typeof(System.Single[]).__il2cppRuntimeField_18 = vector.z;
        typeof(System.Single[]).__il2cppRuntimeField_1C = vector.w;
        return CryptoPlayerPrefsX.SetFloatArray(key:  key, floatArray:  533895840);
    }
    public static UnityEngine.Quaternion GetQuaternion(string key)
    {
        System.Single[] val_1 = CryptoPlayerPrefsX.GetFloatArray(key:  R1);
        if((R1 + 12) > 3)
        {
                var val_2 = R1 + 16;
            key = new UnityEngine.Quaternion(x:  R1 + 28, y:  null, z:  null, w:  null);
            return new UnityEngine.Quaternion() {x = R1 + 28};
        }
        
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
        return new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
    }
    public static UnityEngine.Quaternion GetQuaternion(string key, UnityEngine.Quaternion defaultValue)
    {
        char val_3;
        if((CPlayerPrefs.HasKey(key:  defaultValue.x)) != false)
        {
                UnityEngine.Quaternion val_2 = CryptoPlayerPrefsX.GetQuaternion(key:  key);
            return new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        }
        
        key.m_stringLength = defaultValue.w;
        key.m_firstChar = val_3;
        return new UnityEngine.Quaternion();
    }
    public static bool SetColor(string key, UnityEngine.Color color)
    {
        typeof(System.Single[]).__il2cppRuntimeField_10 = color.r;
        typeof(System.Single[]).__il2cppRuntimeField_14 = color.g;
        typeof(System.Single[]).__il2cppRuntimeField_18 = color.b;
        typeof(System.Single[]).__il2cppRuntimeField_1C = color.a;
        return CryptoPlayerPrefsX.SetFloatArray(key:  key, floatArray:  533895840);
    }
    public static UnityEngine.Color GetColor(string key)
    {
        System.Single[] val_1 = CryptoPlayerPrefsX.GetFloatArray(key:  R1);
        if((R1 + 12) > 3)
        {
                var val_2 = R1 + 16;
        }
        
        key = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        return new UnityEngine.Color();
    }
    public static UnityEngine.Color GetColor(string key, UnityEngine.Color defaultValue)
    {
        char val_3;
        if((CPlayerPrefs.HasKey(key:  defaultValue.r)) != false)
        {
                UnityEngine.Color val_2 = CryptoPlayerPrefsX.GetColor(key:  key);
            return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
        
        key.m_stringLength = defaultValue.a;
        key.m_firstChar = val_3;
        return new UnityEngine.Color();
    }
    public static bool SetBoolArray(string key, bool[] boolArray)
    {
        var val_7;
        var val_8;
        if(boolArray == null)
        {
            goto label_2;
        }
        
        boolArray[7][(boolArray[7] >> 31) >> 29] = 5 + ((boolArray[7][(boolArray[7] >> 31) >> 29]) >> 3);
        typeof(System.Byte[]).__il2cppRuntimeField_10 = System.Convert.ToByte(value:  276144128);
        System.Collections.BitArray val_8 = null;
        if((mem[null + 178]) == 0)
        {
            goto label_8;
        }
        
        var val_7 = 0;
        label_10:
        if((mem[null + 88] + 0) == null)
        {
            goto label_9;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < (mem[null + 178]))
        {
            goto label_10;
        }
        
        label_8:
        val_7 = new System.Collections.BitArray(values:  boolArray);
        goto label_11;
        label_2:
        val_8 = 0;
        string val_4 = -2141819120(-2141819120) + key;
        UnityEngine.Debug.LogError(message:  -2141819120);
        return (bool)val_8;
        label_9:
        var val_5 = (mem[null + 88]) + 0;
        val_8 = val_8 + (((mem[null + 88] + 0) + 4) << 3);
        label_11:
        CryptoPlayerPrefsX.Initialize();
        CryptoPlayerPrefsX.ConvertInt32ToBytes(i:  75399168, bytes:  475101376);
        val_8 = CryptoPlayerPrefsX.SaveBytes(key:  key, bytes:  475101376);
        return (bool)val_8;
    }
    public static bool[] GetBoolArray(string key)
    {
        var val_11;
        var val_12;
        int val_13;
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        if((CPlayerPrefs.HasKey(key:  key)) == false)
        {
            goto label_3;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  key);
        System.Byte[] val_3 = System.Convert.FromBase64String(s:  key);
        if(key.m_firstChar <= '')
        {
            goto label_9;
        }
        
        if(key.m_firstChar != '')
        {
            goto label_10;
        }
        
        CryptoPlayerPrefsX.Initialize();
        char val_10 = key.m_firstChar;
        val_10 = val_10 - 5;
        val_11 = null;
        System.Array.Copy(sourceArray:  key, sourceIndex:  5, destinationArray:  475101376, destinationIndex:  0, length:  System.Byte[].__il2cppRuntimeField_namespaze);
        System.Collections.BitArray val_4 = null;
        val_12 = val_4;
        val_4 = new System.Collections.BitArray(bytes:  475101376);
        val_13 = CryptoPlayerPrefsX.ConvertBytesToInt32(bytes:  key);
        if(val_12 == 0)
        {
            goto label_12;
        }
        
        Length = val_13;
        goto label_13;
        label_9:
        val_14 = key;
        val_15 = "Corrupt preference file for ";
        goto label_14;
        label_10:
        val_14 = " is not a boolean array";
        val_15 = key;
        label_14:
        string val_6 = val_15 + -2141661760(-2141661760);
        UnityEngine.Debug.LogError(message:  val_15);
        label_3:
        label_12:
        R4.Length = R5;
        label_13:
        var val_12 = R4;
        if((R4 + 178) == 0)
        {
            goto label_17;
        }
        
        var val_11 = 0;
        label_19:
        val_11 = 0;
        if((R4 + 88 + 0) == null)
        {
            goto label_18;
        }
        
        val_11 = val_11 + 1;
        val_11 = (uint)val_11 & 65535;
        if(val_11 < (R4 + 178))
        {
            goto label_19;
        }
        
        label_17:
        val_16 = R4;
        goto label_20;
        label_18:
        var val_7 = (R4 + 88) + 0;
        val_12 = val_12 + (((R4 + 88 + 0) + 4) << 3);
        val_16 = val_12 + 196;
        label_20:
        var val_13 = R4;
        if((R4 + 178) == 0)
        {
            goto label_22;
        }
        
        val_11 = 0;
        label_24:
        if((R4 + 88 + 0) == null)
        {
            goto label_23;
        }
        
        val_11 = val_11 + 1;
        if(((uint)val_11 & 65535) < (R4 + 178))
        {
            goto label_24;
        }
        
        label_22:
        val_17 = R4;
        goto label_25;
        label_23:
        var val_8 = (R4 + 88) + 0;
        val_13 = val_13 + (((R4 + 88 + 0) + 4) << 3);
        val_17 = val_13 + 188;
        label_25:
        var val_9 = FP - 24;
    }
    public static bool[] GetBoolArray(string key, bool defaultValue, int defaultSize)
    {
        if((CPlayerPrefs.HasKey(key:  key)) != false)
        {
                return CryptoPlayerPrefsX.GetBoolArray(key:  key);
        }
        
        if(defaultSize < 1)
        {
                return;
        }
        
        var val_2 = 0;
        do
        {
            System.Boolean[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = defaultValue;
            val_2 = val_2 + 1;
        }
        while(defaultSize != val_2);
    
    }
    public static bool SetStringArray(string key, string[] stringArray)
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  stringArray);
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  stringArray);
        return true;
    }
    public static string[] GetStringArray(string key)
    {
        twelvegigs.sweepstakes.Distribution val_7;
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  key, defaultValue:  -2141227328);
        object val_4 = MiniJSON.Json.Deserialize(json:  key);
        return;
        label_8:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        if(val_7 == 0)
        {
            goto label_8;
        }
        
        Add(item:  val_7);
        goto label_8;
        label_5:
        Dispose();
        T[] val_8 = ToArray();
    }
    public static string[] GetStringArray(string key, string defaultValue, int defaultSize)
    {
        if((CPlayerPrefs.HasKey(key:  key)) != false)
        {
                return CryptoPlayerPrefsX.GetStringArray(key:  key);
        }
        
        if(defaultSize < 1)
        {
                return;
        }
        
        var val_2 = 0;
        do
        {
            System.String[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = defaultValue;
            val_2 = val_2 + 1;
        }
        while(defaultSize != val_2);
    
    }
    public static bool SetIntArray(string key, int[] intArray)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2154025488));
        return (bool)CryptoPlayerPrefsX.SetValue<System.Int32[]>(key:  key, array:  intArray, arrayType:  1, vectorNumber:  1, convert:  null);
    }
    public static bool SetFloatArray(string key, float[] floatArray)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2154222480));
        return (bool)CryptoPlayerPrefsX.SetValue<System.Single[]>(key:  key, array:  floatArray, arrayType:  0, vectorNumber:  1, convert:  null);
    }
    public static bool SetVector2Array(string key, UnityEngine.Vector2[] vector2Array)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2154419472));
        return (bool)CryptoPlayerPrefsX.SetValue<UnityEngine.Vector2[]>(key:  key, array:  vector2Array, arrayType:  4, vectorNumber:  2, convert:  null);
    }
    public static bool SetVector3Array(string key, UnityEngine.Vector3[] vector3Array)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2154616464));
        return (bool)CryptoPlayerPrefsX.SetValue<UnityEngine.Vector3[]>(key:  key, array:  vector3Array, arrayType:  5, vectorNumber:  3, convert:  null);
    }
    public static bool SetQuaternionArray(string key, UnityEngine.Quaternion[] quaternionArray)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2154813456));
        return (bool)CryptoPlayerPrefsX.SetValue<UnityEngine.Quaternion[]>(key:  key, array:  quaternionArray, arrayType:  6, vectorNumber:  4, convert:  null);
    }
    public static bool SetColorArray(string key, UnityEngine.Color[] colorArray)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2155010448));
        return (bool)CryptoPlayerPrefsX.SetValue<UnityEngine.Color[]>(key:  key, array:  colorArray, arrayType:  7, vectorNumber:  4, convert:  null);
    }
    public static int[] GetIntArray(string key)
    {
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2155170576));
        CryptoPlayerPrefsX.GetValue<System.Collections.Generic.List<System.Int32>>(key:  key, list:  80883712, arrayType:  1, vectorNumber:  1, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static int[] GetIntArray(string key, int defaultValue, int defaultSize)
    {
        if((CPlayerPrefs.HasKey(key:  key)) != false)
        {
                return CryptoPlayerPrefsX.GetIntArray(key:  key);
        }
        
        if(defaultSize < 1)
        {
                return;
        }
        
        var val_2 = 0;
        do
        {
            System.Int32[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = defaultValue;
            val_2 = val_2 + 1;
        }
        while(defaultSize != val_2);
    
    }
    public static float[] GetFloatArray(string key)
    {
        System.Collections.Generic.List<System.Single> val_1 = new System.Collections.Generic.List<System.Single>();
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2155416080));
        CryptoPlayerPrefsX.GetValue<System.Collections.Generic.List<System.Single>>(key:  key, list:  80883712, arrayType:  0, vectorNumber:  1, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static float[] GetFloatArray(string key, float defaultValue, int defaultSize)
    {
        if((CPlayerPrefs.HasKey(key:  key)) != false)
        {
                return CryptoPlayerPrefsX.GetFloatArray(key:  key);
        }
        
        if(R2 < 1)
        {
                return;
        }
        
        do
        {
            35641111 = 0 + 1;
        }
        while(R2 != 35641111);
    
    }
    public static UnityEngine.Vector2[] GetVector2Array(string key)
    {
        System.Collections.Generic.List<UnityEngine.Vector2> val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2155661584));
        CryptoPlayerPrefsX.GetValue<System.Collections.Generic.List<UnityEngine.Vector2>>(key:  key, list:  80883712, arrayType:  4, vectorNumber:  2, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static UnityEngine.Vector2[] GetVector2Array(string key, UnityEngine.Vector2 defaultValue, int defaultSize)
    {
        if((CPlayerPrefs.HasKey(key:  key)) != false)
        {
                return CryptoPlayerPrefsX.GetVector2Array(key:  key);
        }
        
        if(defaultSize < 1)
        {
                return;
        }
        
        do
        {
            35641113 = 0 + 1;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_10 = defaultValue.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_14 = defaultValue.y;
        }
        while(defaultSize != 35641113);
    
    }
    public static UnityEngine.Vector3[] GetVector3Array(string key)
    {
        System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2155906064));
        CryptoPlayerPrefsX.GetValue<System.Collections.Generic.List<UnityEngine.Vector3>>(key:  key, list:  80883712, arrayType:  5, vectorNumber:  3, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static UnityEngine.Vector3[] GetVector3Array(string key, UnityEngine.Vector3 defaultValue, int defaultSize)
    {
        if((CPlayerPrefs.HasKey(key:  key)) != false)
        {
                return CryptoPlayerPrefsX.GetVector3Array(key:  key);
        }
        
        if(defaultSize < 1)
        {
                return;
        }
        
        var val_2 = 0;
        do
        {
            UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = defaultValue.x;
            val_2 = val_2 + 1;
            UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_4 = defaultValue.y;
            UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_8 = defaultValue.z;
        }
        while(defaultSize != val_2);
    
    }
    public static UnityEngine.Quaternion[] GetQuaternionArray(string key)
    {
        System.Collections.Generic.List<UnityEngine.Quaternion> val_1 = new System.Collections.Generic.List<UnityEngine.Quaternion>();
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2156150544));
        CryptoPlayerPrefsX.GetValue<System.Collections.Generic.List<UnityEngine.Quaternion>>(key:  key, list:  80883712, arrayType:  6, vectorNumber:  4, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static UnityEngine.Quaternion[] GetQuaternionArray(string key, UnityEngine.Quaternion defaultValue, int defaultSize)
    {
        if((CPlayerPrefs.HasKey(key:  key)) != false)
        {
                return CryptoPlayerPrefsX.GetQuaternionArray(key:  key);
        }
        
        if(defaultSize < 1)
        {
                return;
        }
        
        do
        {
            35641117 = 0 + 1;
            typeof(UnityEngine.Quaternion[]).__il2cppRuntimeField_10 = defaultValue.x;
            typeof(UnityEngine.Quaternion[]).__il2cppRuntimeField_14 = defaultValue.y;
            typeof(UnityEngine.Quaternion[]).__il2cppRuntimeField_18 = defaultValue.z;
            typeof(UnityEngine.Quaternion[]).__il2cppRuntimeField_1C = defaultValue.w;
        }
        while(defaultSize != 35641117);
    
    }
    public static UnityEngine.Color[] GetColorArray(string key)
    {
        System.Collections.Generic.List<UnityEngine.Color> val_1 = new System.Collections.Generic.List<UnityEngine.Color>();
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2156396048));
        CryptoPlayerPrefsX.GetValue<System.Collections.Generic.List<UnityEngine.Color>>(key:  key, list:  80883712, arrayType:  7, vectorNumber:  4, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static UnityEngine.Color[] GetColorArray(string key, UnityEngine.Color defaultValue, int defaultSize)
    {
        if((CPlayerPrefs.HasKey(key:  key)) != false)
        {
                return CryptoPlayerPrefsX.GetColorArray(key:  key);
        }
        
        if(defaultSize < 1)
        {
                return;
        }
        
        do
        {
            35641119 = 0 + 1;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_10 = defaultValue.r;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_14 = defaultValue.g;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_18 = defaultValue.b;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_1C = defaultValue.a;
        }
        while(defaultSize != 35641119);
    
    }
    private static bool SetValue<T>(string key, T array, CryptoPlayerPrefsX.ArrayType arrayType, int vectorNumber, System.Action<T, byte[], int> convert)
    {
        var val_12;
        ArrayType val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_12 = vectorNumber;
        val_13 = arrayType;
        var val_12 = 0;
        val_14 = 0;
        val_12 = val_12 + 1;
        val_14 = (uint)val_12 & 65535;
        val_16 = array;
        if(array != null)
        {
                var val_13 = 0;
            val_14 = 0;
            val_13 = val_13 + 1;
            val_15 = (uint)val_13 & 65535;
            val_17 = array;
        }
        else
        {
                string val_3 = null.ToString();
            val_18 = 0;
            string val_4 = -2138281712(-2138281712) + -2138269520(-2138269520) + -2138281632(-2138281632) + key;
            UnityEngine.Debug.LogError(message:  -2138281712);
            return (bool)val_18;
        }
        
        int val_7 = val_12 * array;
        val_7 = 1 | (val_7 << 2);
        val_12 = null;
        typeof(System.Byte[]).__il2cppRuntimeField_10 = System.Convert.ToByte(value:  276144128);
        val_13 = convert;
        val_19 = 0;
        CryptoPlayerPrefsX.Initialize();
        goto label_19;
        label_26:
        val_19 = 1;
        label_19:
        val_14 = 0;
        val_15 = 0;
        val_14 = val_14 + 1;
        val_15 = (uint)val_14 & 65535;
        val_20 = array;
        if(val_19 < array)
        {
            goto label_26;
        }
        
        val_18 = CryptoPlayerPrefsX.SaveBytes(key:  key, bytes:  475101376);
        return (bool)val_18;
    }
    private static void ConvertFromInt(int[] array, byte[] bytes, int i)
    {
        CryptoPlayerPrefsX.ConvertInt32ToBytes(i:  array[i], bytes:  bytes);
    }
    private static void ConvertFromFloat(float[] array, byte[] bytes, int i)
    {
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i]);
    }
    private static void ConvertFromVector2(UnityEngine.Vector2[] array, byte[] bytes, int i)
    {
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 3]);
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 3]);
    }
    private static void ConvertFromVector3(UnityEngine.Vector3[] array, byte[] bytes, int i)
    {
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i + (i << 1)]);
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i + (i << 1)]);
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i + (i << 1)]);
    }
    private static void ConvertFromQuaternion(UnityEngine.Quaternion[] array, byte[] bytes, int i)
    {
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
    }
    private static void ConvertFromColor(UnityEngine.Color[] array, byte[] bytes, int i)
    {
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        CryptoPlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
    }
    private static void GetValue<T>(string key, T list, CryptoPlayerPrefsX.ArrayType arrayType, int vectorNumber, System.Action<T, byte[]> convert)
    {
        string val_9;
        ArrayType val_10;
        val_9 = key;
        val_10 = arrayType;
        if((CPlayerPrefs.HasKey(key:  val_9)) == false)
        {
                return;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  val_9);
        System.Byte[] val_3 = System.Convert.FromBase64String(s:  val_9);
        val_10 = key.m_firstChar;
        if((vectorNumber << 2) != 0)
        {
                string val_6 = -2141661888(-2141661888) + val_9;
            UnityEngine.Debug.LogError(message:  -2141661888);
            return;
        }
        
        if((val_10 - 1) == val_10)
        {
                CryptoPlayerPrefsX.Initialize();
            char val_9 = key.m_firstChar;
            val_9 = val_9 - 1;
            if(val_9 < '')
        {
                return;
        }
        
            var val_10 = val_9;
            do
        {
            val_10 = val_10 - 1;
        }
        while(convert != 0);
        
            return;
        }
        
        string val_7 = null.ToString();
        string val_8 = val_9 + -2136547200(-2136547200) + -2136535072(-2136535072) + -2136547104(-2136547104);
        UnityEngine.Debug.LogError(message:  val_9);
    }
    private static void ConvertToInt(System.Collections.Generic.List<int> list, byte[] bytes)
    {
        list.Add(item:  CryptoPlayerPrefsX.ConvertBytesToInt32(bytes:  bytes));
    }
    private static void ConvertToFloat(System.Collections.Generic.List<float> list, byte[] bytes)
    {
        list.Add(item:  CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes));
    }
    private static void ConvertToVector2(System.Collections.Generic.List<UnityEngine.Vector2> list, byte[] bytes)
    {
        float val_1 = CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes), y:  null);
        list.Add(item:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
    }
    private static void ConvertToVector3(System.Collections.Generic.List<UnityEngine.Vector3> list, byte[] bytes)
    {
        float val_1 = CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        float val_2 = CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes), y:  null, z:  null);
        list.Add(item:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    private static void ConvertToQuaternion(System.Collections.Generic.List<UnityEngine.Quaternion> list, byte[] bytes)
    {
        float val_1 = CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        float val_2 = CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        float val_3 = CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        UnityEngine.Quaternion val_5 = new UnityEngine.Quaternion(x:  CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes), y:  null, z:  null, w:  null);
        list.Add(item:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
    }
    private static void ConvertToColor(System.Collections.Generic.List<UnityEngine.Color> list, byte[] bytes)
    {
        float val_1 = CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        float val_2 = CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        float val_3 = CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        UnityEngine.Color val_5 = new UnityEngine.Color(r:  CryptoPlayerPrefsX.ConvertBytesToFloat(bytes:  bytes), g:  null, b:  null, a:  null);
        list.Add(item:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
    }
    public static void ShowArrayType(string key)
    {
        string val_1 = CPlayerPrefs.GetString(key:  key);
        System.Byte[] val_2 = System.Convert.FromBase64String(s:  key);
        if(key.m_firstChar == ' ')
        {
                return;
        }
        
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_3 = key + -2135246928(-2135246928) + 276144128 + -2136547104(-2136547104);
        UnityEngine.Debug.Log(message:  key);
    }
    private static void Initialize()
    {
        var val_1 = null;
        bool val_1 = System.BitConverter.IsLittleEndian;
        if(val_1 == false)
        {
                0 = 3;
        }
        
        val_1 = val_1 ^ 1;
        CryptoPlayerPrefsX.endianDiff1 = 3;
        CryptoPlayerPrefsX.endianDiff2 = val_1;
        if(CryptoPlayerPrefsX.byteBlock == null)
        {
                CryptoPlayerPrefsX.byteBlock = null;
        }
        
        CryptoPlayerPrefsX.idx = 1;
    }
    private static bool SaveBytes(string key, byte[] bytes)
    {
        string val_1 = System.Convert.ToBase64String(inArray:  bytes);
        CPlayerPrefs.SetString(key:  key, val:  bytes);
        return true;
    }
    private static void ConvertFloatToBytes(float f, byte[] bytes)
    {
        System.Byte[] val_1 = System.BitConverter.GetBytes(value:  f);
        CryptoPlayerPrefsX.byteBlock = bytes;
        CryptoPlayerPrefsX.ConvertTo4Bytes(bytes:  R1);
    }
    private static float ConvertBytesToFloat(byte[] bytes)
    {
        CryptoPlayerPrefsX.ConvertFrom4Bytes(bytes:  bytes);
        return System.BitConverter.ToSingle(value:  CryptoPlayerPrefsX.byteBlock, startIndex:  0);
    }
    private static void ConvertInt32ToBytes(int i, byte[] bytes)
    {
        System.Byte[] val_1 = System.BitConverter.GetBytes(value:  i);
        CryptoPlayerPrefsX.byteBlock = i;
        CryptoPlayerPrefsX.ConvertTo4Bytes(bytes:  bytes);
    }
    private static int ConvertBytesToInt32(byte[] bytes)
    {
        CryptoPlayerPrefsX.ConvertFrom4Bytes(bytes:  bytes);
        return System.BitConverter.ToInt32(value:  CryptoPlayerPrefsX.byteBlock, startIndex:  0);
    }
    private static void ConvertTo4Bytes(byte[] bytes)
    {
        System.Byte[] val_1 = CryptoPlayerPrefsX.byteBlock + CryptoPlayerPrefsX.endianDiff1;
        bytes[CryptoPlayerPrefsX.idx] = (CryptoPlayerPrefsX.byteBlock + CryptoPlayerPrefsX.endianDiff1) + 16;
        val_5 = val_5 + 1;
        System.Byte[] val_2 = CryptoPlayerPrefsX.byteBlock + val_5;
        val_6 = val_6 + 1;
        bytes[val_6] = (CryptoPlayerPrefsX.byteBlock + (CryptoPlayerPrefsX.endianDiff2 + 1)) + 16;
        val_7 = 2 - val_7;
        System.Byte[] val_3 = CryptoPlayerPrefsX.byteBlock + val_7;
        val_8 = val_8 + 2;
        bytes[val_8] = (CryptoPlayerPrefsX.byteBlock + (2 - CryptoPlayerPrefsX.endianDiff2)) + 16;
        int val_9 = CryptoPlayerPrefsX.endianDiff1;
        int val_10 = CryptoPlayerPrefsX.idx;
        val_9 = 3 - val_9;
        System.Byte[] val_4 = CryptoPlayerPrefsX.byteBlock + val_9;
        val_10 = val_10 + 3;
        bytes[val_10] = (CryptoPlayerPrefsX.byteBlock + (3 - CryptoPlayerPrefsX.endianDiff1)) + 16;
        int val_11 = CryptoPlayerPrefsX.idx;
        val_11 = val_11 + 4;
        CryptoPlayerPrefsX.idx = val_11;
    }
    private static void ConvertFrom4Bytes(byte[] bytes)
    {
        System.Byte[] val_1 = CryptoPlayerPrefsX.byteBlock + CryptoPlayerPrefsX.endianDiff1;
        (CryptoPlayerPrefsX.byteBlock + CryptoPlayerPrefsX.endianDiff1).__unknownFiledOffset_10 = bytes[CryptoPlayerPrefsX.idx];
        int val_11 = CryptoPlayerPrefsX.endianDiff2;
        val_11 = val_11 + 1;
        System.Byte[] val_3 = CryptoPlayerPrefsX.byteBlock + val_11;
        (CryptoPlayerPrefsX.byteBlock + (CryptoPlayerPrefsX.endianDiff2 + 1)).__unknownFiledOffset_10 = bytes[CryptoPlayerPrefsX.idx + 1];
        int val_13 = CryptoPlayerPrefsX.endianDiff2;
        val_13 = 2 - val_13;
        System.Byte[] val_5 = CryptoPlayerPrefsX.byteBlock + val_13;
        (CryptoPlayerPrefsX.byteBlock + (2 - CryptoPlayerPrefsX.endianDiff2)).__unknownFiledOffset_10 = bytes[CryptoPlayerPrefsX.idx + 2];
        System.Byte[] val_8 = CryptoPlayerPrefsX.byteBlock + (3 - CryptoPlayerPrefsX.endianDiff1);
        (CryptoPlayerPrefsX.byteBlock + (3 - CryptoPlayerPrefsX.endianDiff1)).__unknownFiledOffset_10 = bytes[CryptoPlayerPrefsX.idx + 3];
        int val_15 = CryptoPlayerPrefsX.idx;
        val_15 = val_15 + 4;
        CryptoPlayerPrefsX.idx = val_15;
    }
    public CryptoPlayerPrefsX()
    {
    
    }

}
