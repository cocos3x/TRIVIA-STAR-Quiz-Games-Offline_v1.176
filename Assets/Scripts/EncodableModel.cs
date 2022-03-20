using UnityEngine;
public class EncodableModel
{
    // Methods
    public virtual System.Collections.Generic.Dictionary<string, object> Encode(EncodableModel.TemplateModel destination = 0)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
    }
    public virtual void EncodeIntoDictionary(ref System.Collections.Generic.Dictionary<string, object> source, EncodableModel.TemplateModel destination = 0)
    {
        var val_13;
        var val_14;
        var val_15;
        System.Func<System.Reflection.FieldInfo, System.Boolean> val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        val_13 = this;
        val_14 = 1152921511405039840;
        System.Type val_1 = this.GetType();
        val_15 = null;
        val_15 = null;
        val_17 = EncodableModel.<>c.<>9__2_0;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  EncodableModel.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2503168544));
            EncodableModel.<>c.<>9__2_0 = val_17;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Object>(source:  -1791773728, predicate:  7720960);
        var val_12 = 0;
        val_18 = 0;
        val_12 = val_12 + 1;
        val_18 = (uint)val_12 & 65535;
        val_19 = val_13;
        val_20 = val_13;
        label_42:
        val_18 = 0;
        val_18 = val_18 + 1;
        val_21 = val_20;
        if(val_20 == 0)
        {
            goto label_17;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_22 = val_20;
        if(destination != 0)
        {
                System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(292757504)});
            if(val_20 != 0)
        {
                val_23 = null;
        }
        
            val_23 = null;
            if((((EncodableModel.__il2cppRuntimeField_typeHierarchy + (EncodeToSource.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4 + 100 + (EncodeToSource.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_23)
        {
                val_24 = 12;
        }
        
        }
        else
        {
                System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(292757504)});
            if(val_20 != 0)
        {
                val_25 = null;
        }
        
            val_25 = null;
            if((((EncodableModel.__il2cppRuntimeField_typeHierarchy + (EncodeToSource.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4 + 100 + (EncodeToSource.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_25)
        {
                val_24 = 8;
        }
        
        }
        
        source.Add(key:  null, value:  -1791773728);
        goto label_42;
        label_17:
        val_26 = 0;
        if(val_20 != 0)
        {
                val_18 = 0;
            val_18 = val_18 + 1;
            val_27 = val_20;
        }
        
        var val_11 = FP - 28;
    }
    public virtual void Decode(System.Collections.Generic.Dictionary<string, object> jasonObject, EncodableModel.TemplateModel sourceModel = 0)
    {
        var val_35;
        var val_36;
        System.Func<System.Reflection.FieldInfo, System.Boolean> val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_49;
        System.Type val_1 = this.GetType();
        val_35 = 1152921504899764224;
        val_36 = null;
        val_36 = null;
        val_38 = EncodableModel.<>c.<>9__3_0;
        if(val_38 == 0)
        {
                val_38 = null;
            val_38 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  EncodableModel.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2503297872));
            EncodableModel.<>c.<>9__3_0 = val_38;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Object>(source:  -1791643744, predicate:  7720960);
        if((public static System.Collections.Generic.IEnumerable<TSource> System.Linq.Enumerable::Where<System.Reflection.FieldInfo>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate)) == 0)
        {
            goto label_8;
        }
        
        val_35 = 0;
        label_10:
        val_39 = 0;
        if(as. 
           
           
          
        
        
        
         == null)
        {
            goto label_9;
        }
        
        val_35 = val_35 + 1;
        val_39 = (uint)val_35 & 65535;
        if(val_39 < (public static System.Collections.Generic.IEnumerable<TSource> System.Linq.Enumerable::Where<System.Reflection.FieldInfo>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate)))
        {
            goto label_10;
        }
        
        label_8:
        val_40 = this;
        goto label_11;
        label_9:
        label_11:
        label_128:
        if(null == 0)
        {
            goto label_13;
        }
        
        val_35 = 0;
        label_15:
        val_39 = 0;
        if(as. 
           
           
          
        
        
        
         == null)
        {
            goto label_14;
        }
        
        val_35 = val_35 + 1;
        val_39 = (uint)val_35 & 65535;
        if(val_39 < null)
        {
            goto label_15;
        }
        
        label_13:
        val_41 = this;
        goto label_16;
        label_14:
        label_16:
        if(this == 0)
        {
            goto label_17;
        }
        
        if(null == 0)
        {
            goto label_19;
        }
        
        var val_31 = 0;
        label_21:
        if(as. 
           
           
          
        
        
        
         == null)
        {
            goto label_20;
        }
        
        val_31 = val_31 + 1;
        if(((uint)val_31 & 65535) < null)
        {
            goto label_21;
        }
        
        label_19:
        val_42 = this;
        goto label_22;
        label_20:
        label_22:
        if(sourceModel != 0)
        {
                System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(292757504)});
            if(mem[1152921511405137840] != 0)
        {
                val_43 = null;
        }
        
            val_43 = null;
            if(((mem[1152921511405137840] + 100 + (EncodeToSource.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_43)
        {
                val_44 = 12;
        }
        
        }
        else
        {
                System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(292757504)});
            if(mem[1152921511405137840] != 0)
        {
                val_45 = null;
        }
        
            val_45 = null;
            if(((mem[1152921511405137840] + 100 + (EncodeToSource.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_45)
        {
                val_44 = 8;
        }
        
        }
        
        if((jasonObject.ContainsKey(key:  null)) == false)
        {
            goto label_42;
        }
        
        System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(76410880)});
        if((System.Type.op_Equality(left:  this.ContainsKey(key:  null), right:  76410880)) == false)
        {
            goto label_45;
        }
        
        object val_11 = jasonObject.Item[null];
        this.SetValue(obj:  -1791643744, value:  jasonObject);
        goto label_128;
        label_42:
        val_46 = null;
        val_46 = null;
        if(Logger.EncodableModel == false)
        {
            goto label_128;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = "DECODE WARNING: ";
        typeof(System.String[]).__il2cppRuntimeField_14 = val_44;
        typeof(System.String[]).__il2cppRuntimeField_18 = " doesn\'t exist in ";
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        typeof(System.String[]).__il2cppRuntimeField_1C = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = " JsonObject: ";
        string val_12 = PrettyPrint.printJSON(obj:  jasonObject, types:  false, singleLineOutput:  false);
        typeof(System.String[]).__il2cppRuntimeField_24 = jasonObject;
        string val_13 = +477709520;
        UnityEngine.Debug.LogWarning(message:  477709520);
        goto label_128;
        label_45:
        System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(10170368)});
        if((System.Type.op_Equality(left:  -1791643744, right:  10170368)) == false)
        {
            goto label_78;
        }
        
        object val_16 = jasonObject.Item[null];
        string val_17 = jasonObject.ToString();
        if((jasonObject.IndexOf(value:  '.')) < 0)
        {
            goto label_82;
        }
        
        System.Globalization.CultureInfo val_19 = System.Globalization.CultureInfo.InvariantCulture;
        float val_20 = System.Single.Parse(s:  jasonObject, provider:  0);
        System.Globalization.CultureInfo val_21 = System.Globalization.CultureInfo.InvariantCulture;
        decimal val_22 = System.Convert.ToDecimal(value:  -1791655808, provider:  15282176);
        this.SetValue(obj:  -1791643744, value:  10170368);
        goto label_128;
        label_78:
        object val_23 = jasonObject.Item[null];
        this.SetValue(obj:  -1791643744, value:  jasonObject);
        goto label_128;
        label_82:
        object val_24 = jasonObject.Item[null];
        string val_25 = jasonObject.ToString();
        System.Globalization.CultureInfo val_26 = System.Globalization.CultureInfo.InvariantCulture;
        decimal val_27 = System.Decimal.Parse(s:  -1791655808, provider:  jasonObject);
        this.SetValue(obj:  -1791643744, value:  10170368);
        goto label_128;
        label_17:
        if(this == 0)
        {
            goto label_129;
        }
        
        if(null == 0)
        {
            goto label_130;
        }
        
        val_35 = 0;
        label_132:
        val_39 = 0;
        if(as. 
           
           
          
        
        
        
         == null)
        {
            goto label_131;
        }
        
        val_35 = val_35 + 1;
        val_39 = (uint)val_35 & 65535;
        if(val_39 < null)
        {
            goto label_132;
        }
        
        label_130:
        val_49 = this;
        goto label_133;
        label_131:
        label_133:
        label_129:
        if(0 == 0)
        {
                return;
        }
    
    }
    public virtual void Merge(EncodableModel model)
    {
        var val_16;
        object val_17;
        var val_18;
        var val_19;
        System.Func<System.Reflection.FieldInfo, System.Boolean> val_21;
        var val_22;
        var val_23;
        float val_24;
        var val_25;
        var val_26;
        var val_27;
        val_16 = this;
        val_17 = model;
        System.Type val_1 = val_16.GetType();
        System.Type val_2 = val_17.GetType();
        if(val_16 == 0)
        {
            goto label_39;
        }
        
        System.Type val_3 = val_17.GetType();
        System.Type val_4 = val_16.GetType();
        if(val_17 == 0)
        {
            goto label_39;
        }
        
        System.Type val_5 = val_16.GetType();
        val_18 = 1152921504899764224;
        val_19 = null;
        val_19 = null;
        val_21 = EncodableModel.<>c.<>9__4_0;
        if(val_21 == 0)
        {
                val_21 = null;
            val_21 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  EncodableModel.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2503423840));
            EncodableModel.<>c.<>9__4_0 = val_21;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Where<System.Object>(source:  -1791518432, predicate:  7720960);
        val_18 = 0;
        val_18 = val_18 + 1;
        val_22 = val_16;
        val_23 = val_16;
        val_24 = 1152921504683417600;
        label_33:
        val_18 = 0;
        val_18 = val_18 + 1;
        val_25 = val_23;
        if(val_23 == 0)
        {
            goto label_23;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_26 = val_23;
        System.Type val_11 = val_17.GetType();
        System.Reflection.FieldInfo val_12 = val_17.GetField(name:  -1791518432);
        this.SetValue(obj:  -1791518432, value:  val_17);
        goto label_33;
        label_23:
        val_16 = 0;
        if(val_23 != 0)
        {
                val_18 = 0;
            val_18 = val_18 + 1;
            val_27 = val_23;
        }
        
        label_39:
        var val_14 = FP - 28;
    }
    public EncodableModel()
    {
    
    }

}
