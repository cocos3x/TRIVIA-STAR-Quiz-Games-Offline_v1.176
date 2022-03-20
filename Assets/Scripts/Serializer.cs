using UnityEngine;
private sealed class Json.Serializer
{
    // Fields
    private System.Text.StringBuilder builder;
    
    // Methods
    private Json.Serializer()
    {
        this.builder = new System.Text.StringBuilder();
    }
    public static string Serialize(object obj)
    {
        if(new Json.Serializer() != 0)
        {
                SerializeValue(value:  obj);
        }
        else
        {
                SerializeValue(value:  obj);
        }
    
    }
    private void SerializeValue(object value)
    {
        string val_3;
        if(value == 0)
        {
            goto label_1;
        }
        
        if(null == null)
        {
            goto label_2;
        }
        
        if(null == null)
        {
            goto label_3;
        }
        
        if(value == 0)
        {
            goto label_4;
        }
        
        this.SerializeArray(anArray:  value);
        return;
        label_1:
        val_3 = "null";
        goto label_6;
        label_2:
        this.SerializeString(str:  value);
        return;
        label_3:
        string val_1 = value.ToLower();
        val_3 = value;
        label_6:
        System.Text.StringBuilder val_2 = this.builder.Append(value:  val_3);
        return;
        label_4:
        if(value != 0)
        {
                this.SerializeObject(obj:  value);
            return;
        }
        
        if(null != null)
        {
                this.SerializeOther(value:  value);
            return;
        }
        
        this.SerializeString(str:  value);
    }
    private void SerializeObject(System.Collections.IDictionary obj)
    {
        var val_11;
        var val_12;
        string val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '{');
        val_11 = 0;
        val_11 = val_11 + 1;
        val_12 = obj;
        val_13 = obj;
        val_11 = 0;
        val_11 = val_11 + 1;
        val_14 = val_13;
        label_32:
        val_11 = 0;
        val_11 = val_11 + 1;
        val_13 = (uint)val_11 & 65535;
        val_15 = val_13;
        if(val_13 == 0)
        {
            goto label_17;
        }
        
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_16 = val_13;
        if(1 == 1)
        {
                System.Text.StringBuilder val_6 = this.builder.Append(value:  ',');
        }
        
        this.SerializeString(str:  val_13);
        System.Text.StringBuilder val_7 = this.builder.Append(value:  ':');
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_17 = obj;
        this.SerializeValue(value:  obj);
        goto label_32;
        label_17:
        if(val_13 != 0)
        {
                val_13 = val_13;
            val_11 = 0;
            val_11 = val_11 + 1;
            val_18 = val_13;
        }
        
        System.Text.StringBuilder val_10 = this.builder.Append(value:  '}');
    }
    private void SerializeArray(System.Collections.IList anArray)
    {
        System.Text.StringBuilder val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_8 = this.builder;
        System.Text.StringBuilder val_1 = val_8.Append(value:  '[');
        val_9 = 0;
        val_8 = 0;
        val_9 = val_9 + 1;
        val_8 = (uint)val_9 & 65535;
        val_10 = anArray;
        label_20:
        val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = (uint)val_8 & 65535;
        val_11 = anArray;
        if(anArray == 0)
        {
            goto label_12;
        }
        
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_12 = anArray;
        if(1 == 1)
        {
                System.Text.StringBuilder val_5 = this.builder.Append(value:  ',');
        }
        
        this.SerializeValue(value:  anArray);
        goto label_20;
        label_12:
        if(anArray != 0)
        {
                val_9 = 0;
            val_9 = val_9 + 1;
            val_13 = anArray;
        }
        
        System.Text.StringBuilder val_7 = this.builder.Append(value:  ']');
    }
    private void SerializeString(string str)
    {
        System.Text.StringBuilder val_7;
        var val_8;
        var val_9;
        string val_8 = str;
        val_7 = this.builder;
        val_8 = 0;
        System.Text.StringBuilder val_1 = val_7.Append(value:  '"');
        System.Char[] val_2 = val_8.ToCharArray();
        val_8 = val_8 + 16;
        goto label_3;
        label_24:
        string val_3 = 1152921504622235648 - 8;
        if(val_3 > 5)
        {
            goto label_5;
        }
        
        var val_4 = 7964948 + (7964948 + ((1152921504622235648 - 8)) << 2);
        if(val_3 == 5)
        {
                7964948 + ((1152921504622235648 - 8)) << 2 = (7964948 + ((1152921504622235648 - 8)) << 2) & (this << (7964948 + ((1152921504622235648 - 8)) << 2));
            7964948 + ((1152921504622235648 - 8)) << 2 = (7964948 + ((1152921504622235648 - 8)) << 2) & 0;
            7964948 + ((1152921504622235648 - 8)) << 2 = (7964948 + ((1152921504622235648 - 8)) << 2) & ((7964948 + ((1152921504622235648 - 8)) << 2) >> 1);
            7964948 + ((1152921504622235648 - 8)) << 2 = (7964948 + ((1152921504622235648 - 8)) << 2) & ((((((7964948 + ((1152921504622235648 - 8)) << 2 & (this) << 7964948 + ((1152921504622235648 - 8)) << 2) & 0) & (((7964948 + ((1152921504622235648 - 8)) << 2 & (this) << 7964948 + ((1152921504622235648 -) << (32-as. 
            
        
        
        
        
        
           
        )) | (((((7964948 + ((1152921504622235648 - 8)) << 2 & (this) << 7964948 + ((1152921504622235648 - 8)) << 2) & 0) & (((7964948 + ((1152921504622235648 - 8)) << 2 & (this) << 7964948 + ((1152921504622235648 -) << as. 
            
        
        
        
        
        
           
        ));
            mem2[0] = ((((7964948 + ((1152921504622235648 - 8)) << 2 & (this) << 7964948 + ((1152921504622235648 - 8)) << 2) & 0) & (((7964948 + ((1152921504622235648 - 8)) << 2 & (this) << 7964948 + ((1152921504622235648  + IP;
        }
        
        val_7 = this.builder;
        val_9 = "\\b";
        goto label_19;
        label_5:
        if(null == 92)
        {
            goto label_8;
        }
        
        if(null != 34)
        {
            goto label_9;
        }
        
        val_7 = this.builder;
        val_9 = "\\\"";
        goto label_19;
        label_9:
        System.Text.StringBuilder val_5 = this.builder.Append(value:  '퀀');
        goto label_13;
        label_8:
        val_7 = this.builder;
        val_9 = "\\\\";
        label_19:
        System.Text.StringBuilder val_6 = val_7.Append(value:  1372268864);
        label_13:
        val_8 = val_8 + 2;
        val_8 = 1;
        label_3:
        if(val_8 < str.m_firstChar)
        {
            goto label_24;
        }
        
        System.Text.StringBuilder val_7 = this.builder.Append(value:  '"');
    }
    private void SerializeOther(object value)
    {
        var val_8;
        System.Text.StringBuilder val_9;
        if(value == 0)
        {
            goto label_1;
        }
        
        if(null == null)
        {
            goto label_2;
        }
        
        if(null == null)
        {
            goto label_3;
        }
        
        if(null != null)
        {
                null = 27346500;
            null = 1152921504623620096;
            null = null;
        }
        
        if(null != null)
        {
                if(null != null)
        {
                null = 27315364;
            null = 1152921504617336832;
            null = null;
        }
        
            if(null != null)
        {
                if(null != null)
        {
                null = 27346436;
            null = 1152921504615899136;
            null = null;
        }
        
            if(null != null)
        {
                if(null != null)
        {
                null = 27346408;
            null = 1152921504623566848;
            null = null;
            goto label_7;
        }
        
        }
        
        }
        
        }
        
        label_17:
        val_8 = value;
        val_9 = this.builder;
        goto label_12;
        label_1:
        label_16:
        this.SerializeString(str:  value);
        return;
        label_2:
        val_9 = this.builder;
        value.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
        string val_2 = null.ToString(provider:  0);
        goto label_12;
        label_3:
        val_9 = this.builder;
        value.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        System.Globalization.CultureInfo val_3 = System.Globalization.CultureInfo.InvariantCulture;
        val_8;
        string val_4 = ToString(provider:  0);
        label_12:
        System.Text.StringBuilder val_5 = val_9.Append(value:  1163797280);
        return;
        label_7:
        if(null != null)
        {
            goto label_16;
        }
        
        goto label_17;
    }

}
