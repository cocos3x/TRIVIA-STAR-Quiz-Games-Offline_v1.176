using UnityEngine;
public class PlayerPrefsX
{
    // Fields
    private static int endianDiff1;
    private static int endianDiff2;
    private static int idx;
    private static byte[] byteBlock;
    
    // Methods
    public static bool SetBool(string name, bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  name, value:  value);
        return true;
    }
    public static bool GetBool(string name)
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  name);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public static bool GetBool(string name, bool defaultValue)
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  name, defaultValue:  defaultValue);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public static long GetLong(string key, long defaultValue)
    {
        string val_1 = key + -2027810176(-2027810176);
        string val_3 = key + -2027810080(-2027810080);
        int val_4 = UnityEngine.PlayerPrefs.GetInt(key:  key, defaultValue:  R3);
        return (long)UnityEngine.PlayerPrefs.GetInt(key:  key, defaultValue:  R2);
    }
    public static long GetLong(string key)
    {
        string val_1 = key + -2027810176(-2027810176);
        string val_3 = key + -2027810080(-2027810080);
        int val_4 = UnityEngine.PlayerPrefs.GetInt(key:  key);
        return (long)UnityEngine.PlayerPrefs.GetInt(key:  key);
    }
    private static void SplitLong(long input, out int lowBits, out int highBits)
    {
        lowBits = input;
        highBits = ;
    }
    public static void SetLong(string key, long value)
    {
        string val_1 = key + -2027810176(-2027810176);
        UnityEngine.PlayerPrefs.SetInt(key:  key, value:  R2);
        string val_2 = key + -2027810080(-2027810080);
        UnityEngine.PlayerPrefs.SetInt(key:  key, value:  R3);
    }
    public static bool SetVector2(string key, UnityEngine.Vector2 vector)
    {
        typeof(System.Single[]).__il2cppRuntimeField_10 = vector.x;
        typeof(System.Single[]).__il2cppRuntimeField_14 = vector.y;
        return PlayerPrefsX.SetFloatArray(key:  key, floatArray:  533895840);
    }
    private static UnityEngine.Vector2 GetVector2(string key)
    {
        System.Single[] val_1 = PlayerPrefsX.GetFloatArray(key:  R1);
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
        if((UnityEngine.PlayerPrefs.HasKey(key:  defaultValue.x)) != false)
        {
                UnityEngine.Vector2 val_2 = PlayerPrefsX.GetVector2(key:  key);
            return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        
        mem2[0] = defaultValue.y;
        mem2[0] = R3;
        return new UnityEngine.Vector2();
    }
    public static bool SetVector3(string key, UnityEngine.Vector3 vector)
    {
        typeof(System.Single[]).__il2cppRuntimeField_10 = vector.x;
        typeof(System.Single[]).__il2cppRuntimeField_14 = vector.y;
        typeof(System.Single[]).__il2cppRuntimeField_18 = vector.z;
        return PlayerPrefsX.SetFloatArray(key:  key, floatArray:  533895840);
    }
    public static UnityEngine.Vector3 GetVector3(string key)
    {
        System.Single[] val_1 = PlayerPrefsX.GetFloatArray(key:  R1);
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
        if((UnityEngine.PlayerPrefs.HasKey(key:  defaultValue.x)) != false)
        {
                UnityEngine.Vector3 val_2 = PlayerPrefsX.GetVector3(key:  key);
            return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        
        mem2[0] = defaultValue.y;
        mem2[0] = defaultValue.z;
        key.m_stringLength = val_3;
        return new UnityEngine.Vector3();
    }
    public static bool SetQuaternion(string key, UnityEngine.Quaternion vector)
    {
        typeof(System.Single[]).__il2cppRuntimeField_10 = vector.x;
        typeof(System.Single[]).__il2cppRuntimeField_14 = vector.y;
        typeof(System.Single[]).__il2cppRuntimeField_18 = vector.z;
        typeof(System.Single[]).__il2cppRuntimeField_1C = vector.w;
        return PlayerPrefsX.SetFloatArray(key:  key, floatArray:  533895840);
    }
    public static UnityEngine.Quaternion GetQuaternion(string key)
    {
        System.Single[] val_1 = PlayerPrefsX.GetFloatArray(key:  R1);
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
        if((UnityEngine.PlayerPrefs.HasKey(key:  defaultValue.x)) != false)
        {
                UnityEngine.Quaternion val_2 = PlayerPrefsX.GetQuaternion(key:  key);
            return new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        }
        
        mem2[0] = defaultValue.y;
        mem2[0] = defaultValue.z;
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
        return PlayerPrefsX.SetFloatArray(key:  key, floatArray:  533895840);
    }
    public static UnityEngine.Color GetColor(string key)
    {
        System.Single[] val_1 = PlayerPrefsX.GetFloatArray(key:  R1);
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
        if((UnityEngine.PlayerPrefs.HasKey(key:  defaultValue.r)) != false)
        {
                UnityEngine.Color val_2 = PlayerPrefsX.GetColor(key:  key);
            return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
        
        mem2[0] = defaultValue.g;
        mem2[0] = defaultValue.b;
        key.m_stringLength = defaultValue.a;
        key.m_firstChar = val_3;
        return new UnityEngine.Color();
    }
    public static bool SetBoolArray(string key, bool[] boolArray)
    {
        boolArray[7][(boolArray[7] >> 31) >> 29] = 5 + ((boolArray[7][(boolArray[7] >> 31) >> 29]) >> 3);
        typeof(System.Byte[]).__il2cppRuntimeField_10 = System.Convert.ToByte(value:  282001408);
        System.Collections.BitArray val_3 = new System.Collections.BitArray(values:  boolArray);
        CopyTo(array:  475101376, index:  5);
        PlayerPrefsX.Initialize();
        PlayerPrefsX.ConvertInt32ToBytes(i:  75399168, bytes:  475101376);
        return (bool)PlayerPrefsX.SaveBytes(key:  key, bytes:  475101376);
    }
    private static System.Array CopyTo(System.Collections.BitArray bits, System.Array bytes, int index)
    {
    
    }
    private static byte getByte(System.Collections.BitArray array, int byteIndex)
    {
        int val_1 = byteIndex >> 31;
        val_1 = byteIndex + (val_1 >> 30);
        val_1 = val_1 & (~3758096387);
        val_1 = byteIndex - val_1;
        bool val_4 = array.Item[val_1 >> 2];
        int val_5 = (val_1 << 3) & 24;
        val_4 = val_4 & (255 << val_5);
        val_4 = val_4 >> val_5;
        return (byte)(int)val_4 & 255;
    }
    public static bool[] GetBoolArray(string key)
    {
        var val_9;
        var val_10;
        int val_11;
        var val_12;
        string val_13;
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
            goto label_1;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  key);
        System.Byte[] val_3 = System.Convert.FromBase64String(s:  key);
        if(key.m_firstChar <= '')
        {
            goto label_5;
        }
        
        if(key.m_firstChar != '')
        {
            goto label_6;
        }
        
        PlayerPrefsX.Initialize();
        char val_8 = key.m_firstChar;
        val_8 = val_8 - 5;
        val_9 = null;
        System.Array.Copy(sourceArray:  key, sourceIndex:  5, destinationArray:  475101376, destinationIndex:  0, length:  System.Byte[].__il2cppRuntimeField_namespaze);
        System.Collections.BitArray val_4 = null;
        val_10 = val_4;
        val_4 = new System.Collections.BitArray(bytes:  475101376);
        val_11 = PlayerPrefsX.ConvertBytesToInt32(bytes:  key);
        if(val_10 == 0)
        {
            goto label_8;
        }
        
        Length = val_11;
        goto label_9;
        label_5:
        val_12 = key;
        val_13 = "Corrupt preference file for ";
        goto label_10;
        label_6:
        val_12 = " is not a boolean array";
        val_13 = key;
        label_10:
        string val_6 = val_13 + -2141661760(-2141661760);
        UnityEngine.Debug.LogError(message:  val_13);
        label_1:
        label_8:
        R4.Length = R5;
        label_9:
        R4.CopyTo(array:  1054454320, index:  0);
        var val_7 = FP - 16;
    }
    public static bool[] GetBoolArray(string key, bool defaultValue, int defaultSize)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
        {
                return PlayerPrefsX.GetBoolArray(key:  key);
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
        byte val_8;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_8 = System.Convert.ToByte(value:  282001408);
        typeof(System.Byte[]).__il2cppRuntimeField_10 = val_8;
        PlayerPrefsX.Initialize();
        var val_8 = 0;
        label_15:
        if(null == null)
        {
            goto label_8;
        }
        
        if(0 <= val_8)
        {
                val_10 = 0;
            if(null == null)
        {
            goto label_24;
        }
        
        }
        
        PlayerPrefsX.idx = PlayerPrefsX.idx + 1;
        val_8 = val_8 + 1;
        (null + PlayerPrefsX.idx).__unknownFiledOffset_10 = System.String[].__il2cppRuntimeField_name;
        if(val_8 < (null + PlayerPrefsX.idx))
        {
            goto label_15;
        }
        
        string val_4 = System.Convert.ToBase64String(inArray:  475101376);
        string val_5 = System.String.Join(separator:  1098586544, value:  stringArray);
        string val_6 = 475101376 + -2100450224(-2100450224) + 1098586544;
        val_11 = 1;
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  475101376);
        return (bool)val_11;
        label_8:
        val_12 = "Can\'t save null entries in the string array when setting ";
        val_11 = 0;
        string val_7 = -2025159040(-2025159040) + key;
        UnityEngine.Debug.LogError(message:  -2025159040);
        return (bool)val_11;
        label_24:
        val_13 = 1152921505084556496;
        if(val_10 == 1)
        {
                if(null != 0)
        {
                return (bool)val_11;
        }
        
            mem[4] = null;
            val_10 = 33453568;
            val_13 = 4;
        }
    
    }
    public static string[] GetStringArray(string key)
    {
        string val_14;
        var val_15;
        var val_16;
        string val_17;
        val_14 = key;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_14)) == false)
        {
            goto label_1;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  val_14);
        int val_4 = val_14.IndexOf(value:  Chars[0]);
        if(val_4 <= 3)
        {
            goto label_4;
        }
        
        string val_5 = val_14.Substring(startIndex:  0, length:  val_4);
        System.Byte[] val_6 = System.Convert.FromBase64String(s:  val_14);
        if(key.m_firstChar != '')
        {
            goto label_10;
        }
        
        PlayerPrefsX.Initialize();
        char val_7 = key.m_firstChar - 1;
        val_15 = null;
        if(val_7 < '')
        {
                return;
        }
        
        int val_8 = val_4 + 1;
        var val_14 = 0;
        do
        {
            PlayerPrefsX.idx = PlayerPrefsX.idx + 1;
            string val_10 = val_14 + PlayerPrefsX.idx;
            if((val_8 + PlayerPrefsX.idx) > key.m_stringLength)
        {
            goto label_24;
        }
        
            string val_12 = val_14.Substring(startIndex:  val_8, length:  PlayerPrefsX.idx);
            System.String[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = val_14;
            val_14 = val_14 + 1;
        }
        while(val_14 < val_7);
        
        return;
        label_4:
        val_16 = val_14;
        label_24:
        val_17 = "Corrupt preference file for ";
        goto label_21;
        label_10:
        val_16 = " is not a string array";
        val_17 = val_14;
        label_21:
        string val_13 = val_17 + -2025001792(-2025001792);
        UnityEngine.Debug.LogError(message:  val_17);
        label_1:
        val_15 = null;
    }
    public static string[] GetStringArray(string key, string defaultValue, int defaultSize)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
        {
                return PlayerPrefsX.GetStringArray(key:  key);
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
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2270251056));
        return (bool)PlayerPrefsX.SetValue<System.Int32[]>(key:  key, array:  intArray, arrayType:  1, vectorNumber:  1, convert:  null);
    }
    public static bool SetFloatArray(string key, float[] floatArray)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2270447024));
        return (bool)PlayerPrefsX.SetValue<System.Single[]>(key:  key, array:  floatArray, arrayType:  0, vectorNumber:  1, convert:  null);
    }
    public static bool SetVector2Array(string key, UnityEngine.Vector2[] vector2Array)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2270642992));
        return (bool)PlayerPrefsX.SetValue<UnityEngine.Vector2[]>(key:  key, array:  vector2Array, arrayType:  4, vectorNumber:  2, convert:  null);
    }
    public static bool SetVector3Array(string key, UnityEngine.Vector3[] vector3Array)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2270838960));
        return (bool)PlayerPrefsX.SetValue<UnityEngine.Vector3[]>(key:  key, array:  vector3Array, arrayType:  5, vectorNumber:  3, convert:  null);
    }
    public static bool SetQuaternionArray(string key, UnityEngine.Quaternion[] quaternionArray)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2271034928));
        return (bool)PlayerPrefsX.SetValue<UnityEngine.Quaternion[]>(key:  key, array:  quaternionArray, arrayType:  6, vectorNumber:  4, convert:  null);
    }
    public static bool SetColorArray(string key, UnityEngine.Color[] colorArray)
    {
        System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32> val_1 = new System.Action<UnityEngine.Vector3[], System.Byte[], System.Int32>(object:  0, method:  new IntPtr(2271230896));
        return (bool)PlayerPrefsX.SetValue<UnityEngine.Color[]>(key:  key, array:  colorArray, arrayType:  7, vectorNumber:  4, convert:  null);
    }
    private static bool SetValue<T>(string key, T array, PlayerPrefsX.ArrayType arrayType, int vectorNumber, System.Action<T, byte[], int> convert)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_8 = 35653254;
        val_8 = 0;
        val_8 = val_8 + 1;
        val_10 = array;
        int val_3 = vectorNumber * array;
        val_3 = 1 | (val_3 << 2);
        typeof(System.Byte[]).__il2cppRuntimeField_10 = System.Convert.ToByte(value:  282001408);
        val_11 = 0;
        PlayerPrefsX.Initialize();
        goto label_10;
        label_17:
        val_11 = 1;
        label_10:
        val_9 = 0;
        val_8 = 0;
        val_9 = val_9 + 1;
        val_8 = (uint)val_9 & 65535;
        val_12 = array;
        if(val_11 < array)
        {
            goto label_17;
        }
        
        return (bool)PlayerPrefsX.SaveBytes(key:  key, bytes:  475101376);
    }
    private static void ConvertFromInt(int[] array, byte[] bytes, int i)
    {
        PlayerPrefsX.ConvertInt32ToBytes(i:  array[i], bytes:  bytes);
    }
    private static void ConvertFromFloat(float[] array, byte[] bytes, int i)
    {
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i]);
    }
    private static void ConvertFromVector2(UnityEngine.Vector2[] array, byte[] bytes, int i)
    {
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 3]);
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 3]);
    }
    private static void ConvertFromVector3(UnityEngine.Vector3[] array, byte[] bytes, int i)
    {
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i + (i << 1)]);
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i + (i << 1)]);
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i + (i << 1)]);
    }
    private static void ConvertFromQuaternion(UnityEngine.Quaternion[] array, byte[] bytes, int i)
    {
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
    }
    private static void ConvertFromColor(UnityEngine.Color[] array, byte[] bytes, int i)
    {
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
        PlayerPrefsX.ConvertFloatToBytes(f:  null, bytes:  array[i << 4]);
    }
    public static int[] GetIntArray(string key)
    {
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2273157040));
        PlayerPrefsX.GetValue<System.Collections.Generic.List<System.Int32>>(key:  key, list:  80883712, arrayType:  1, vectorNumber:  1, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static int[] GetIntArray(string key, int defaultValue, int defaultSize)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
        {
                return PlayerPrefsX.GetIntArray(key:  key);
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
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2273399472));
        PlayerPrefsX.GetValue<System.Collections.Generic.List<System.Single>>(key:  key, list:  80883712, arrayType:  0, vectorNumber:  1, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static float[] GetFloatArray(string key, float defaultValue, int defaultSize)
    {
        var val_2;
        var val_3;
        val_2 = defaultSize;
        val_3 = 35633155;
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
        {
                return PlayerPrefsX.GetFloatArray(key:  key);
        }
        
        if(R2 < 1)
        {
                return;
        }
        
        do
        {
            val_3 = 0 + 1;
        }
        while(R2 != val_3);
    
    }
    public static UnityEngine.Vector2[] GetVector2Array(string key)
    {
        System.Collections.Generic.List<UnityEngine.Vector2> val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2273641904));
        PlayerPrefsX.GetValue<System.Collections.Generic.List<UnityEngine.Vector2>>(key:  key, list:  80883712, arrayType:  4, vectorNumber:  2, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static UnityEngine.Vector2[] GetVector2Array(string key, UnityEngine.Vector2 defaultValue, int defaultSize)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
        {
                return PlayerPrefsX.GetVector2Array(key:  key);
        }
        
        if(defaultSize < 1)
        {
                return;
        }
        
        do
        {
            35633157 = 0 + 1;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_10 = defaultValue.x;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_14 = defaultValue.y;
        }
        while(defaultSize != 35633157);
    
    }
    public static UnityEngine.Vector3[] GetVector3Array(string key)
    {
        System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2273884336));
        PlayerPrefsX.GetValue<System.Collections.Generic.List<UnityEngine.Vector3>>(key:  key, list:  80883712, arrayType:  5, vectorNumber:  3, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static UnityEngine.Vector3[] GetVector3Array(string key, UnityEngine.Vector3 defaultValue, int defaultSize)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
        {
                return PlayerPrefsX.GetVector3Array(key:  key);
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
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2274126768));
        PlayerPrefsX.GetValue<System.Collections.Generic.List<UnityEngine.Quaternion>>(key:  key, list:  80883712, arrayType:  6, vectorNumber:  4, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static UnityEngine.Quaternion[] GetQuaternionArray(string key, UnityEngine.Quaternion defaultValue, int defaultSize)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
        {
                return PlayerPrefsX.GetQuaternionArray(key:  key);
        }
        
        if(defaultSize < 1)
        {
                return;
        }
        
        do
        {
            35633161 = 0 + 1;
            typeof(UnityEngine.Quaternion[]).__il2cppRuntimeField_10 = defaultValue.x;
            typeof(UnityEngine.Quaternion[]).__il2cppRuntimeField_14 = defaultValue.y;
            typeof(UnityEngine.Quaternion[]).__il2cppRuntimeField_18 = defaultValue.z;
            typeof(UnityEngine.Quaternion[]).__il2cppRuntimeField_1C = defaultValue.w;
        }
        while(defaultSize != 35633161);
    
    }
    public static UnityEngine.Color[] GetColorArray(string key)
    {
        System.Collections.Generic.List<UnityEngine.Color> val_1 = new System.Collections.Generic.List<UnityEngine.Color>();
        System.Action<System.Threading.Tasks.Task, System.Object> val_2 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(2274369200));
        PlayerPrefsX.GetValue<System.Collections.Generic.List<UnityEngine.Color>>(key:  key, list:  80883712, arrayType:  7, vectorNumber:  4, convert:  null);
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static UnityEngine.Color[] GetColorArray(string key, UnityEngine.Color defaultValue, int defaultSize)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) != false)
        {
                return PlayerPrefsX.GetColorArray(key:  key);
        }
        
        if(defaultSize < 1)
        {
                return;
        }
        
        do
        {
            35633163 = 0 + 1;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_10 = defaultValue.r;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_14 = defaultValue.g;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_18 = defaultValue.b;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_1C = defaultValue.a;
        }
        while(defaultSize != 35633163);
    
    }
    private static void GetValue<T>(string key, T list, PlayerPrefsX.ArrayType arrayType, int vectorNumber, System.Action<T, byte[]> convert)
    {
        string val_9;
        var val_10;
        ArrayType val_11;
        val_9 = key;
        val_10 = __RuntimeMethodHiddenParam;
        val_11 = arrayType;
        if((UnityEngine.PlayerPrefs.HasKey(key:  val_9)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  val_9);
        System.Byte[] val_3 = System.Convert.FromBase64String(s:  val_9);
        val_10 = val_9;
        if((vectorNumber << 2) != 0)
        {
                string val_6 = -2141661888(-2141661888) + val_9;
            UnityEngine.Debug.LogError(message:  -2141661888);
            return;
        }
        
        val_9 = val_9;
        val_11 = list;
        if((key.m_firstChar - 1) == val_11)
        {
                PlayerPrefsX.Initialize();
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
        string val_8 = val_9 + -2136547200(-2136547200) + -2020331424(-2020331424) + -2136547104(-2136547104);
        UnityEngine.Debug.LogError(message:  val_9);
    }
    private static void ConvertToInt(System.Collections.Generic.List<int> list, byte[] bytes)
    {
        list.Add(item:  PlayerPrefsX.ConvertBytesToInt32(bytes:  bytes));
    }
    private static void ConvertToFloat(System.Collections.Generic.List<float> list, byte[] bytes)
    {
        list.Add(item:  PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes));
    }
    private static void ConvertToVector2(System.Collections.Generic.List<UnityEngine.Vector2> list, byte[] bytes)
    {
        float val_1 = PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes), y:  null);
        list.Add(item:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
    }
    private static void ConvertToVector3(System.Collections.Generic.List<UnityEngine.Vector3> list, byte[] bytes)
    {
        float val_1 = PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        float val_2 = PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes), y:  null, z:  null);
        list.Add(item:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    private static void ConvertToQuaternion(System.Collections.Generic.List<UnityEngine.Quaternion> list, byte[] bytes)
    {
        float val_1 = PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        float val_2 = PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        float val_3 = PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        UnityEngine.Quaternion val_5 = new UnityEngine.Quaternion(x:  PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes), y:  null, z:  null, w:  null);
        list.Add(item:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
    }
    private static void ConvertToColor(System.Collections.Generic.List<UnityEngine.Color> list, byte[] bytes)
    {
        float val_1 = PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        float val_2 = PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        float val_3 = PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes);
        UnityEngine.Color val_5 = new UnityEngine.Color(r:  PlayerPrefsX.ConvertBytesToFloat(bytes:  bytes), g:  null, b:  null, a:  null);
        list.Add(item:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
    }
    public static void ShowArrayType(string key)
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  key);
        System.Byte[] val_2 = System.Convert.FromBase64String(s:  key);
        if(key.m_firstChar == ' ')
        {
                return;
        }
        
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_3 = key + -2135246928(-2135246928) + 282001408 + -2136547104(-2136547104);
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
        PlayerPrefsX.endianDiff1 = 3;
        PlayerPrefsX.endianDiff2 = val_1;
        if(PlayerPrefsX.byteBlock == null)
        {
                PlayerPrefsX.byteBlock = null;
        }
        
        PlayerPrefsX.idx = 1;
    }
    private static bool SaveBytes(string key, byte[] bytes)
    {
        string val_1 = System.Convert.ToBase64String(inArray:  bytes);
        UnityEngine.PlayerPrefs.SetString(key:  key, value:  bytes);
        return true;
    }
    private static void ConvertFloatToBytes(float f, byte[] bytes)
    {
        System.Byte[] val_1 = System.BitConverter.GetBytes(value:  f);
        PlayerPrefsX.byteBlock = bytes;
        PlayerPrefsX.ConvertTo4Bytes(bytes:  R1);
    }
    private static float ConvertBytesToFloat(byte[] bytes)
    {
        PlayerPrefsX.ConvertFrom4Bytes(bytes:  bytes);
        return System.BitConverter.ToSingle(value:  PlayerPrefsX.byteBlock, startIndex:  0);
    }
    private static void ConvertInt32ToBytes(int i, byte[] bytes)
    {
        System.Byte[] val_1 = System.BitConverter.GetBytes(value:  i);
        PlayerPrefsX.byteBlock = i;
        PlayerPrefsX.ConvertTo4Bytes(bytes:  bytes);
    }
    private static int ConvertBytesToInt32(byte[] bytes)
    {
        PlayerPrefsX.ConvertFrom4Bytes(bytes:  bytes);
        return System.BitConverter.ToInt32(value:  PlayerPrefsX.byteBlock, startIndex:  0);
    }
    private static void ConvertTo4Bytes(byte[] bytes)
    {
        System.Byte[] val_1 = PlayerPrefsX.byteBlock + PlayerPrefsX.endianDiff1;
        bytes[PlayerPrefsX.idx] = (PlayerPrefsX.byteBlock + PlayerPrefsX.endianDiff1) + 16;
        val_5 = val_5 + 1;
        System.Byte[] val_2 = PlayerPrefsX.byteBlock + val_5;
        val_6 = val_6 + 1;
        bytes[val_6] = (PlayerPrefsX.byteBlock + (PlayerPrefsX.endianDiff2 + 1)) + 16;
        val_7 = 2 - val_7;
        System.Byte[] val_3 = PlayerPrefsX.byteBlock + val_7;
        val_8 = val_8 + 2;
        bytes[val_8] = (PlayerPrefsX.byteBlock + (2 - PlayerPrefsX.endianDiff2)) + 16;
        int val_9 = PlayerPrefsX.endianDiff1;
        int val_10 = PlayerPrefsX.idx;
        val_9 = 3 - val_9;
        System.Byte[] val_4 = PlayerPrefsX.byteBlock + val_9;
        val_10 = val_10 + 3;
        bytes[val_10] = (PlayerPrefsX.byteBlock + (3 - PlayerPrefsX.endianDiff1)) + 16;
        int val_11 = PlayerPrefsX.idx;
        val_11 = val_11 + 4;
        PlayerPrefsX.idx = val_11;
    }
    private static void ConvertFrom4Bytes(byte[] bytes)
    {
        System.Byte[] val_1 = PlayerPrefsX.byteBlock + PlayerPrefsX.endianDiff1;
        (PlayerPrefsX.byteBlock + PlayerPrefsX.endianDiff1).__unknownFiledOffset_10 = bytes[PlayerPrefsX.idx];
        int val_11 = PlayerPrefsX.endianDiff2;
        val_11 = val_11 + 1;
        System.Byte[] val_3 = PlayerPrefsX.byteBlock + val_11;
        (PlayerPrefsX.byteBlock + (PlayerPrefsX.endianDiff2 + 1)).__unknownFiledOffset_10 = bytes[PlayerPrefsX.idx + 1];
        int val_13 = PlayerPrefsX.endianDiff2;
        val_13 = 2 - val_13;
        System.Byte[] val_5 = PlayerPrefsX.byteBlock + val_13;
        (PlayerPrefsX.byteBlock + (2 - PlayerPrefsX.endianDiff2)).__unknownFiledOffset_10 = bytes[PlayerPrefsX.idx + 2];
        System.Byte[] val_8 = PlayerPrefsX.byteBlock + (3 - PlayerPrefsX.endianDiff1);
        (PlayerPrefsX.byteBlock + (3 - PlayerPrefsX.endianDiff1)).__unknownFiledOffset_10 = bytes[PlayerPrefsX.idx + 3];
        int val_15 = PlayerPrefsX.idx;
        val_15 = val_15 + 4;
        PlayerPrefsX.idx = val_15;
    }
    public PlayerPrefsX()
    {
    
    }

}
