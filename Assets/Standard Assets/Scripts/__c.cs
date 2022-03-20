using UnityEngine;
[Serializable]
private sealed class JsonMapper.<>c
{
    // Fields
    public static readonly LitJson.JsonMapper.<>c <>9;
    public static LitJson.WrapperFactory <>9__23_0;
    public static LitJson.ExporterFunc <>9__24_0;
    public static LitJson.ExporterFunc <>9__24_1;
    public static LitJson.ExporterFunc <>9__24_2;
    public static LitJson.ExporterFunc <>9__24_3;
    public static LitJson.ExporterFunc <>9__24_4;
    public static LitJson.ExporterFunc <>9__24_5;
    public static LitJson.ExporterFunc <>9__24_6;
    public static LitJson.ExporterFunc <>9__24_7;
    public static LitJson.ExporterFunc <>9__24_8;
    public static LitJson.ImporterFunc <>9__25_0;
    public static LitJson.ImporterFunc <>9__25_1;
    public static LitJson.ImporterFunc <>9__25_2;
    public static LitJson.ImporterFunc <>9__25_3;
    public static LitJson.ImporterFunc <>9__25_4;
    public static LitJson.ImporterFunc <>9__25_5;
    public static LitJson.ImporterFunc <>9__25_6;
    public static LitJson.ImporterFunc <>9__25_7;
    public static LitJson.ImporterFunc <>9__25_8;
    public static LitJson.ImporterFunc <>9__25_9;
    public static LitJson.ImporterFunc <>9__25_10;
    public static LitJson.ImporterFunc <>9__25_11;
    public static LitJson.WrapperFactory <>9__30_0;
    public static LitJson.WrapperFactory <>9__31_0;
    public static LitJson.WrapperFactory <>9__32_0;
    
    // Methods
    private static JsonMapper.<>c()
    {
        JsonMapper.<>c.<>9 = new System.Object();
    }
    public JsonMapper.<>c()
    {
    
    }
    internal LitJson.IJsonWrapper <ReadSkip>b__23_0()
    {
        object val_1 = new System.Object();
    }
    internal void <RegisterBaseExporters>b__24_0(object obj, LitJson.JsonWriter writer)
    {
        obj.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        writer.Write(number:  System.Convert.ToInt32(value:  0));
    }
    internal void <RegisterBaseExporters>b__24_1(object obj, LitJson.JsonWriter writer)
    {
        obj.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_1 = System.Convert.ToString(value:  '');
        writer.Write(str:  19914752);
    }
    internal void <RegisterBaseExporters>b__24_2(object obj, LitJson.JsonWriter writer)
    {
        null = null;
        obj.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_1 = System.Convert.ToString(value:  new System.DateTime() {dateData = 1152921504626761728}, provider:  LitJson.JsonMapper.datetime_format);
        writer.Write(str:  19914752);
    }
    internal void <RegisterBaseExporters>b__24_3(object obj, LitJson.JsonWriter writer)
    {
        obj.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        writer.Write(number:  new System.Decimal() {flags = mem[obj + (0)], hi = mem[obj + (4)], lo = mem[obj + (8)], mid = obj});
    }
    internal void <RegisterBaseExporters>b__24_4(object obj, LitJson.JsonWriter writer)
    {
        obj.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        writer.Write(number:  System.Convert.ToInt32(value:  0));
    }
    internal void <RegisterBaseExporters>b__24_5(object obj, LitJson.JsonWriter writer)
    {
        obj.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        writer.Write(number:  System.Convert.ToInt32(value:  57344));
    }
    internal void <RegisterBaseExporters>b__24_6(object obj, LitJson.JsonWriter writer)
    {
        obj.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        writer.Write(number:  System.Convert.ToInt32(value:  57344));
    }
    internal void <RegisterBaseExporters>b__24_7(object obj, LitJson.JsonWriter writer)
    {
        obj.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        ulong val_1 = System.Convert.ToUInt64(value:  19914752);
        writer.Write(number:  0);
    }
    internal void <RegisterBaseExporters>b__24_8(object obj, LitJson.JsonWriter writer)
    {
        obj.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        writer.Write(number:  System.UInt64.__il2cppRuntimeField_element_class);
    }
    internal object <RegisterBaseImporters>b__25_0(object input)
    {
        input.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        byte val_1 = System.Convert.ToByte(value:  19914752);
    }
    internal object <RegisterBaseImporters>b__25_1(object input)
    {
        input.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        ulong val_1 = System.Convert.ToUInt64(value:  19914752);
    }
    internal object <RegisterBaseImporters>b__25_2(object input)
    {
        input.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        sbyte val_1 = System.Convert.ToSByte(value:  19914752);
    }
    internal object <RegisterBaseImporters>b__25_3(object input)
    {
        input.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        short val_1 = System.Convert.ToInt16(value:  19914752);
    }
    internal object <RegisterBaseImporters>b__25_4(object input)
    {
        input.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        ushort val_1 = System.Convert.ToUInt16(value:  19914752);
    }
    internal object <RegisterBaseImporters>b__25_5(object input)
    {
        input.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        uint val_1 = System.Convert.ToUInt32(value:  19914752);
    }
    internal object <RegisterBaseImporters>b__25_6(object input)
    {
        input.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        float val_1 = System.Convert.ToSingle(value:  19914752);
    }
    internal object <RegisterBaseImporters>b__25_7(object input)
    {
        input.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        double val_1 = System.Convert.ToDouble(value:  19914752);
    }
    internal object <RegisterBaseImporters>b__25_8(object input)
    {
        input.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        decimal val_1 = System.Convert.ToDecimal(value:  null);
    }
    internal object <RegisterBaseImporters>b__25_9(object input)
    {
        input.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        uint val_1 = System.Convert.ToUInt32(value:  1152921504626761728);
    }
    internal object <RegisterBaseImporters>b__25_10(object input)
    {
        if(input != 0)
        {
                if(null != null)
        {
            
        }
        else
        {
                0 = input;
        }
        
        }
        
        char val_1 = System.Convert.ToChar(value:  0);
    }
    internal object <RegisterBaseImporters>b__25_11(object input)
    {
        var val_4;
        System.IFormatProvider val_5;
        val_4 = null;
        val_4 = null;
        val_5 = 0;
        if(input != 0)
        {
                if(null != null)
        {
            
        }
        else
        {
                val_5 = input;
        }
        
        }
        
        System.DateTime val_1 = System.Convert.ToDateTime(value:  2075237536, provider:  val_5);
    }
    internal LitJson.IJsonWrapper <ToObject>b__30_0()
    {
        object val_1 = new System.Object();
    }
    internal LitJson.IJsonWrapper <ToObject>b__31_0()
    {
        object val_1 = new System.Object();
    }
    internal LitJson.IJsonWrapper <ToObject>b__32_0()
    {
        object val_1 = new System.Object();
    }

}
