using UnityEngine;
public class EasySaver<T>
{
    // Fields
    private System.Collections.Generic.Dictionary<HardSaved, System.Reflection.MemberInfo> hardSave;
    private System.Collections.Generic.Dictionary<SoftSaved, System.Reflection.MemberInfo> softSaveLite;
    private System.Collections.Generic.Dictionary<SoftSaved, System.Reflection.MemberInfo> softSaveFull;
    private T instance;
    
    // Methods
    public EasySaver<T>(T incInstance)
    {
        BestBlocksPlayer val_28;
        var val_29;
        EasySaver<T> val_30;
        var val_31;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        WordPets.WPTPetTile val_42;
        var val_43;
        var val_44;
        BestBlocksPlayer val_45;
        var val_46;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        val_28 = incInstance;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        mem[1152921511255718248] = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = null;
        val_29 = 1152921511255689952;
        val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        mem[1152921511255718252] = val_2;
        val_30 = this;
        mem[1152921511255718256] = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(this == 0)
        {
                val_30 = this;
        }
        
        mem[1152921511255718260] = val_28;
        if(val_28 == 0)
        {
                val_28 = mem[1152921511255718260];
        }
        
        System.Type val_4 = val_28.GetType();
        val_31 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
        val_31 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
        if(val_31 == 1)
        {
                val_31 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_31 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
        }
        
        val_32 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 92 + 4];
        val_32 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 92 + 4;
        if(val_32 == 0)
        {
                val_33 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_33 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            if(val_33 == 1)
        {
                val_33 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_33 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
        }
        
            val_29 = __RuntimeMethodHiddenParam;
            val_32 = null;
            val_32 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  __RuntimeMethodHiddenParam + 12 + 96 + 4 + 92, method:  __RuntimeMethodHiddenParam + 12 + 96 + 8);
            mem2[0] = val_32;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_6 = System.Linq.Enumerable.Where<System.Object>(source:  val_28, predicate:  7720960);
        var val_25 = val_28;
        if((incInstance + 178) == 0)
        {
            goto label_19;
        }
        
        val_29 = 0;
        label_21:
        if((incInstance + 88 + 0) == null)
        {
            goto label_20;
        }
        
        val_29 = val_29 + 1;
        if(((uint)val_29 & 65535) < (incInstance + 178))
        {
            goto label_21;
        }
        
        label_19:
        val_34 = val_28;
        goto label_23;
        label_20:
        var val_7 = (incInstance + 88) + 0;
        val_25 = val_25 + (((incInstance + 88 + 0) + 4) << 3);
        val_34 = val_25 + 188;
        goto label_23;
        label_59:
        var val_26 = incInstance + 88 + 0;
        if((incInstance + 88 + 0 + 178) == 0)
        {
            goto label_25;
        }
        
        val_29 = 0;
        label_27:
        if((incInstance + 88 + 0 + 88 + 0) == null)
        {
            goto label_26;
        }
        
        val_29 = val_29 + 1;
        if(((uint)val_29 & 65535) < (incInstance + 88 + 0 + 178))
        {
            goto label_27;
        }
        
        label_25:
        val_35 = incInstance + 88 + 0;
        goto label_28;
        label_26:
        var val_8 = (incInstance + 88 + 0 + 88) + 0;
        val_26 = val_26 + (((incInstance + 88 + 0 + 88 + 0) + 4) << 3);
        val_35 = val_26 + 188;
        label_28:
        val_36 = (incInstance + 88 + 0) + 16;
        val_37 = 0;
        goto label_30;
        label_53:
        System.Type val_9 = (incInstance + 88 + 0 + 16) + 0.GetType();
        if((System.String.op_Equality(a:  (incInstance + 88 + 0 + 16) + 0, b:  -1941090592)) != false)
        {
                val_38 = 0;
            if(((incInstance + 88 + 0 + 16) + 0) != 0)
        {
                val_38 = (incInstance + 88 + 0 + 16) + 0;
            if(val_38 == 0)
        {
                val_38 = 0;
        }
        
        }
        
            Add(key:  0, value:  incInstance + 88 + 0);
        }
        else
        {
                if((System.String.op_Equality(a:  (incInstance + 88 + 0 + 16) + 0, b:  -1941089472)) != false)
        {
                if(((incInstance + 88 + 0 + 16) + 0 + 12) != 0)
        {
                val_39 = 0;
            if(((incInstance + 88 + 0 + 16) + 0) != 0)
        {
                val_29 = null;
            val_39 = (incInstance + 88 + 0 + 16) + 0;
            if(val_39 == 0)
        {
                val_39 = 0;
        }
        
        }
        
            Add(key:  0, value:  incInstance + 88 + 0);
        }
        
            val_40 = 0;
            if(((incInstance + 88 + 0 + 16) + 0) != 0)
        {
                val_29 = null;
            val_40 = (incInstance + 88 + 0 + 16) + 0;
            if(val_40 == 0)
        {
                val_40 = 0;
        }
        
        }
        
            Add(key:  0, value:  incInstance + 88 + 0);
        }
        
        }
        
        val_37 = 1;
        label_30:
        if(val_37 < (incInstance + 88 + 0 + 12))
        {
            goto label_53;
        }
        
        label_23:
        var val_27 = val_28;
        if((incInstance + 178) == 0)
        {
            goto label_55;
        }
        
        val_29 = 0;
        label_57:
        if((incInstance + 88 + 0) == null)
        {
            goto label_56;
        }
        
        val_29 = val_29 + 1;
        if(((uint)val_29 & 65535) < (incInstance + 178))
        {
            goto label_57;
        }
        
        label_55:
        val_41 = val_28;
        goto label_58;
        label_56:
        var val_12 = (incInstance + 88) + 0;
        val_27 = val_27 + (((incInstance + 88 + 0) + 4) << 3);
        val_41 = val_27 + 188;
        label_58:
        if(val_28 != 0)
        {
            goto label_59;
        }
        
        val_42 = 0;
        if(val_28 == 0)
        {
            goto label_60;
        }
        
        var val_28 = val_28;
        if((incInstance + 178) == 0)
        {
            goto label_61;
        }
        
        val_29 = 0;
        label_63:
        if((incInstance + 88 + 0) == null)
        {
            goto label_62;
        }
        
        val_29 = val_29 + 1;
        if(((uint)val_29 & 65535) < (incInstance + 178))
        {
            goto label_63;
        }
        
        label_61:
        val_43 = val_28;
        goto label_64;
        label_62:
        var val_13 = (incInstance + 88) + 0;
        val_28 = val_28 + (((incInstance + 88 + 0) + 4) << 3);
        val_43 = val_28 + 188;
        label_64:
        label_60:
        if(val_42 != 1)
        {
                if(val_42 > 1)
        {
                0 = 1;
        }
        
            var val_29 = 0;
            val_29 = val_42 - val_29;
            val_44 = val_29 + 1;
        }
        else
        {
                val_44 = 0;
        }
        
        val_45 = mem[1152921511255718260];
        if(val_45 == 0)
        {
                val_45 = mem[1152921511255718260];
        }
        
        System.Type val_14 = val_45.GetType();
        val_46 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
        val_46 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
        if(val_46 == 1)
        {
                val_46 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_46 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
        }
        
        val_47 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 92 + 8];
        val_47 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 92 + 8;
        if(val_47 == 0)
        {
                val_48 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_48 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            if(val_48 == 1)
        {
                val_48 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_48 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
        }
        
            val_29 = __RuntimeMethodHiddenParam;
            val_47 = null;
            val_47 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  __RuntimeMethodHiddenParam + 12 + 96 + 4 + 92, method:  __RuntimeMethodHiddenParam + 12 + 96 + 12);
            mem2[0] = val_47;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_16 = System.Linq.Enumerable.Where<System.Object>(source:  val_45, predicate:  7720960);
        var val_30 = val_45;
        if((incInstance + 178) == 0)
        {
            goto label_85;
        }
        
        val_29 = 0;
        label_87:
        val_47 = 0;
        if((incInstance + 88 + 0) == null)
        {
            goto label_86;
        }
        
        val_29 = val_29 + 1;
        val_47 = (uint)val_29 & 65535;
        if(val_47 < (incInstance + 178))
        {
            goto label_87;
        }
        
        label_85:
        val_49 = val_45;
        goto label_89;
        label_86:
        var val_17 = (incInstance + 88) + 0;
        val_30 = val_30 + (((incInstance + 88 + 0) + 4) << 3);
        val_49 = val_30 + 188;
        goto label_89;
        label_125:
        var val_32 = incInstance + 88 + 0;
        if((incInstance + 88 + 0 + 178) == 0)
        {
            goto label_91;
        }
        
        var val_31 = 0;
        label_93:
        val_47 = 0;
        if((incInstance + 88 + 0 + 88 + 0) == null)
        {
            goto label_92;
        }
        
        val_31 = val_31 + 1;
        val_47 = (uint)val_31 & 65535;
        if(val_47 < (incInstance + 88 + 0 + 178))
        {
            goto label_93;
        }
        
        label_91:
        val_50 = incInstance + 88 + 0;
        goto label_94;
        label_92:
        var val_18 = (incInstance + 88 + 0 + 88) + 0;
        val_32 = val_32 + (((incInstance + 88 + 0 + 88 + 0) + 4) << 3);
        val_50 = val_32 + 188;
        label_94:
        val_42 = incInstance + 88 + 0;
        val_36 = val_42 + 16;
        val_29 = val_42;
        val_51 = 0;
        goto label_96;
        label_119:
        System.Type val_19 = (incInstance + 88 + 0 + 16) + 0.GetType();
        if((System.String.op_Equality(a:  (incInstance + 88 + 0 + 16) + 0, b:  -1941090592)) != false)
        {
                val_52 = 0;
            if(((incInstance + 88 + 0 + 16) + 0) != 0)
        {
                val_47 = null;
            val_52 = (incInstance + 88 + 0 + 16) + 0;
            if(val_52 == 0)
        {
                val_52 = 0;
        }
        
        }
        
            Add(key:  0, value:  val_42);
        }
        else
        {
                if((System.String.op_Equality(a:  (incInstance + 88 + 0 + 16) + 0, b:  -1941089472)) != false)
        {
                if(((incInstance + 88 + 0 + 16) + 0 + 12) != 0)
        {
                val_53 = 0;
            if(((incInstance + 88 + 0 + 16) + 0) != 0)
        {
                val_47 = null;
            val_53 = (incInstance + 88 + 0 + 16) + 0;
            if(val_53 == 0)
        {
                val_53 = 0;
        }
        
        }
        
            Add(key:  0, value:  val_42);
        }
        
            val_54 = 0;
            if(((incInstance + 88 + 0 + 16) + 0) != 0)
        {
                val_47 = null;
            val_54 = (incInstance + 88 + 0 + 16) + 0;
            if(val_54 == 0)
        {
                val_54 = 0;
        }
        
        }
        
            Add(key:  0, value:  val_42);
        }
        
        }
        
        val_51 = 1;
        label_96:
        if(val_51 < (incInstance + 88 + 0 + 12))
        {
            goto label_119;
        }
        
        label_89:
        var val_33 = val_45;
        if((incInstance + 178) == 0)
        {
            goto label_121;
        }
        
        val_29 = 0;
        label_123:
        val_47 = 0;
        if((incInstance + 88 + 0) == null)
        {
            goto label_122;
        }
        
        val_29 = val_29 + 1;
        val_47 = (uint)val_29 & 65535;
        if(val_47 < (incInstance + 178))
        {
            goto label_123;
        }
        
        label_121:
        val_55 = val_45;
        goto label_124;
        label_122:
        var val_22 = (incInstance + 88) + 0;
        val_33 = val_33 + (((incInstance + 88 + 0) + 4) << 3);
        val_55 = val_33 + 188;
        label_124:
        if(val_45 != 0)
        {
            goto label_125;
        }
        
        val_56 = 0;
        if(val_45 == 0)
        {
            goto label_126;
        }
        
        var val_34 = val_45;
        if((incInstance + 178) == 0)
        {
            goto label_127;
        }
        
        val_29 = 0;
        label_129:
        val_47 = 0;
        if((incInstance + 88 + 0) == null)
        {
            goto label_128;
        }
        
        val_29 = val_29 + 1;
        val_47 = (uint)val_29 & 65535;
        if(val_47 < (incInstance + 178))
        {
            goto label_129;
        }
        
        label_127:
        val_57 = val_45;
        goto label_130;
        label_128:
        var val_23 = (incInstance + 88) + 0;
        val_34 = val_34 + (((incInstance + 88 + 0) + 4) << 3);
        val_57 = val_34 + 188;
        label_130:
        label_126:
        var val_24 = FP - 28;
    }
    public void AddHardSavesToDictionary(ref System.Collections.Generic.Dictionary<string, object> refdic)
    {
        string val_4;
        var val_12;
        var val_13;
        Dictionary.KeyCollection<TKey, TValue> val_1 = static_value_022028BE.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        label_18:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        string val_5 = Item[val_4];
        System.Type val_6 = this.GetType();
        System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(76304384)});
        if((System.Linq.Enumerable.Contains<System.Type>(source:  -1940938096, value:  76304384)) == false)
        {
            goto label_9;
        }
        
        string val_9 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1940938096);
        refdic.Add(key:  val_4 + 8, value:  -1940938096);
        goto label_18;
        label_9:
        string val_10 = this.ToString();
        refdic.Add(key:  val_4 + 8, value:  -1940938096);
        goto label_18;
        label_3:
        val_12 = 0;
        val_13 = 0;
        val_12 = val_12 + 1;
        val_13 = (uint)val_12 & 65535;
        if(0 == 0)
        {
                return;
        }
    
    }
    public void SoftSaveLite()
    {
        if(this == 0)
        {
            
        }
    
    }
    public void SoftSaveFull()
    {
        if(this == 0)
        {
            
        }
    
    }
    private void DoSoftSave(System.Collections.Generic.Dictionary<SoftSaved, System.Reflection.MemberInfo> softSavedItems)
    {
        SoftSaved val_4;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        Dictionary.KeyCollection<TKey, TValue> val_1 = softSavedItems.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        label_35:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        System.Reflection.MemberInfo val_5 = softSavedItems.Item[val_4];
        System.Type val_6 = this.GetType();
        System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
        if((System.Type.op_Equality(left:  -1940589888, right:  13152256)) == false)
        {
            goto label_9;
        }
        
        val_18 = 0;
        goto label_13;
        label_9:
        System.Type val_9 = this.GetType();
        System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15282176)});
        if((System.Type.op_Equality(left:  -1940589888, right:  15282176)) == false)
        {
            goto label_17;
        }
        
        val_19 = 0;
        goto label_21;
        label_17:
        System.Type val_12 = this.GetType();
        System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(76304384)});
        if((System.Linq.Enumerable.Contains<System.Type>(source:  -1940589888, value:  76304384)) == false)
        {
            goto label_26;
        }
        
        string val_15 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1940589888);
        UnityEngine.PlayerPrefs.SetString(key:  val_4 + 8, value:  -1940589888);
        goto label_35;
        label_13:
        UnityEngine.PlayerPrefs.SetInt(key:  val_4 + 8, value:  286633984);
        goto label_35;
        label_26:
        string val_16 = this.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  val_4 + 8, value:  -1940589888);
        goto label_35;
        label_21:
        UnityEngine.PlayerPrefs.SetFloat(key:  val_4 + 8, value:  null);
        goto label_35;
        label_3:
        val_20 = 0;
        val_21 = 0;
        val_20 = val_20 + 1;
        val_21 = (uint)val_20 & 65535;
        if(0 == 0)
        {
                return;
        }
    
    }
    public object GetMemberValue(System.Reflection.MemberInfo memberInfo, T instance)
    {
        var val_4;
        System.Reflection.FieldInfo val_5;
        var val_6;
        val_4 = instance;
        val_5 = memberInfo;
        val_6 = val_5;
        if((System.Reflection.FieldInfo.op_Inequality(left:  val_5, right:  0)) != false)
        {
                if(val_6 != 0)
        {
            goto typeof(System.Reflection.MemberInfo).__il2cppRuntimeField_15C;
        }
        
        }
        else
        {
                if((System.Reflection.PropertyInfo.op_Inequality(left:  R5, right:  0)) == false)
        {
                return;
        }
        
            if(R5 != 0)
        {
            goto R5 + 404;
        }
        
        }
    
    }

}
