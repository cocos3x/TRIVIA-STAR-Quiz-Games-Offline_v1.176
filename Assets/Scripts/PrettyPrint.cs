using UnityEngine;
public class PrettyPrint
{
    // Fields
    private static System.Text.StringBuilder builder;
    private static bool dispTypes;
    private static string separator;
    private static string tab;
    
    // Methods
    public static string printJSON(object obj, bool types = False, bool singleLineOutput = False)
    {
        var val_2;
        var val_3;
        var val_4;
        string val_5;
        val_2 = null;
        val_2 = null;
        PrettyPrint.builder = new System.Text.StringBuilder();
        val_3 = null;
        val_4 = val_3;
        PrettyPrint.dispTypes = types;
        val_5 = " ";
        if(singleLineOutput == true)
        {
                "\n" = val_5;
        }
        
        val_3 = null;
        val_5 = " ";
        val_4 = 1152921504901361756;
        PrettyPrint.separator = "\n";
        if(singleLineOutput == true)
        {
                "\t" = val_5;
        }
        
        val_4 = 1152921504901361756;
        PrettyPrint.tab = "\t";
        PrettyPrint.append(obj:  obj, level:  0);
        PrettyPrint.builder = 0;
    }
    private static void append(object obj, int level = 0)
    {
        var val_7;
        var val_9;
        var val_10;
        if(obj == 0)
        {
            goto label_1;
        }
        
        if(obj == 0)
        {
            goto label_2;
        }
        
        PrettyPrint.appendList(list:  obj, level:  level);
        return;
        label_1:
        val_7 = null;
        val_7 = null;
        label_22:
        System.Text.StringBuilder val_1 = PrettyPrint.builder.Append(value:  1295406352);
        return;
        label_2:
        if(obj != 0)
        {
                PrettyPrint.appendObject(dict:  obj, level:  level);
            return;
        }
        
        val_9 = null;
        if(null != null)
        {
                "\"" = "";
        }
        
        if(null != null)
        {
                "\'" = "\"";
        }
        
        val_9 = null;
        string val_2 = 1098586544 + obj + 1098586544;
        System.Text.StringBuilder val_3 = PrettyPrint.builder.Append(value:  1098586544);
        if(PrettyPrint.dispTypes == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  1098586544, b:  1098586544)) == false)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        System.Type val_5 = obj.GetType();
        string val_6 = -1774063808(-1774063808) + obj + 1009293344;
        if(PrettyPrint.builder != 0)
        {
            goto label_22;
        }
        
        goto label_22;
    }
    private static void appendList(System.Collections.IList list, int level)
    {
        var val_17;
        var val_18;
        System.Collections.IList val_19;
        var val_20;
        System.Collections.IList val_21;
        var val_22;
        var val_23;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        string val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        int val_21 = level;
        val_17 = null;
        val_17 = null;
        System.Text.StringBuilder val_1 = PrettyPrint.builder.Append(value:  1466574320);
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_18 = list;
        label_30:
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_19 = list;
        val_20 = val_19;
        if( == 0)
        {
            goto label_14;
        }
        
        var val_18 = ;
        if((list + 178) == 0)
        {
            goto label_16;
        }
        
        var val_17 = 0;
        label_18:
        if((list + 88 + 0) == null)
        {
            goto label_17;
        }
        
        val_17 = val_17 + 1;
        if(((uint)val_17 & 65535) < (list + 178))
        {
            goto label_18;
        }
        
        label_16:
        val_21 = list;
        goto label_19;
        label_17:
        var val_4 = (list + 88) + 0;
        val_18 = val_18 + (((list + 88 + 0) + 4) << 3);
        val_21 = val_18 + 196;
        label_19:
        val_22 = null;
        val_22 = null;
        string val_5 = 1098586544 + PrettyPrint.separator;
        System.Text.StringBuilder val_6 = PrettyPrint.builder.Append(value:  1098586544);
        val_23 = null;
        if(val_21 >= 0)
        {
                var val_19 = 0;
            do
        {
            System.Text.StringBuilder val_8 = PrettyPrint.builder.Append(value:  PrettyPrint.tab);
            val_26 = null;
            val_19 = val_19 + 1;
        }
        while(val_19 <= val_21);
        
        }
        
        PrettyPrint.append(obj:  list, level:  val_21 + 1);
        goto label_30;
        label_14:
        val_27 = 1152921504619679744;
        if( == 0)
        {
            goto label_32;
        }
        
        if((list + 178) == 0)
        {
            goto label_33;
        }
        
        val_27 = 0;
        label_35:
        if((list + 88 + 0) == null)
        {
            goto label_34;
        }
        
        val_27 = val_27 + 1;
        if(((uint)val_27 & 65535) < (list + 178))
        {
            goto label_35;
        }
        
        label_33:
        val_28 = ;
        goto label_36;
        label_34:
        var val_10 = (list + 88) + 0;
        var val_20 = (list + 88 + 0) + 4;
        val_20 =  + (val_20 << 3);
        val_28 = val_20 + 188;
        label_36:
        label_32:
        val_29 = null;
        val_29 = null;
        val_30 = PrettyPrint.separator;
        System.Text.StringBuilder val_11 = PrettyPrint.builder.Append(value:  val_30);
        val_31 = null;
        val_32 = (uint)(((uint)((PrettyPrint.__il2cppRuntimeField_BB>>1) & 0x1)) >> 1) & 1;
        if(val_21 >= 1)
        {
                do
        {
            if((val_32 & 1) == 0)
        {
                val_33 = null;
        }
        
            val_30 = PrettyPrint.tab;
            System.Text.StringBuilder val_12 = PrettyPrint.builder.Append(value:  val_30);
            val_34 = null;
            val_21 = val_21 - 1;
            val_32 = (uint)(((uint)((PrettyPrint.__il2cppRuntimeField_BB>>1) & 0x1)) >> 1) & 1;
        }
        while(PrettyPrint.builder != 0);
        
        }
        
        if(val_32 != 0)
        {
                val_34 = null;
        }
        
        System.Text.StringBuilder val_13 = PrettyPrint.builder.Append(value:  1487188992);
    }
    private static void appendObject(System.Collections.IDictionary dict, int level)
    {
        var val_20;
        var val_21;
        System.Collections.IDictionary val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        string val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        val_20 = level;
        val_21 = null;
        val_21 = null;
        System.Text.StringBuilder val_1 = PrettyPrint.builder.Append(value:  1466574400);
        if((dict + 178) == 0)
        {
            goto label_5;
        }
        
        var val_18 = 0;
        label_7:
        if((dict + 88 + 0) == null)
        {
            goto label_6;
        }
        
        val_18 = val_18 + 1;
        if(((uint)val_18 & 65535) < (dict + 178))
        {
            goto label_7;
        }
        
        label_5:
        val_22 = dict;
        val_23 = val_22;
        goto label_8;
        label_6:
        var val_2 = (dict + 88) + 0;
        val_22 = dict;
        var val_19 = (dict + 88 + 0) + 4;
        val_19 = dict + (val_19 << 3);
        val_23 = val_19 + 204;
        label_8:
        if((dict + 178) == 0)
        {
            goto label_10;
        }
        
        var val_20 = 0;
        label_12:
        if((dict + 88 + 0) == null)
        {
            goto label_11;
        }
        
        val_20 = val_20 + 1;
        if(((uint)val_20 & 65535) < (dict + 178))
        {
            goto label_12;
        }
        
        label_10:
        val_24 = val_22;
        goto label_13;
        label_11:
        var val_3 = (dict + 88) + 0;
        var val_21 = (dict + 88 + 0) + 4;
        val_21 = val_22 + (val_21 << 3);
        val_24 = val_21 + 188;
        label_13:
        int val_4 = val_20 + 1;
        label_41:
        var val_23 = val_22;
        if((dict + 178) == 0)
        {
            goto label_15;
        }
        
        var val_22 = 0;
        label_17:
        if((dict + 88 + 0) == null)
        {
            goto label_16;
        }
        
        val_22 = val_22 + 1;
        if(((uint)val_22 & 65535) < (dict + 178))
        {
            goto label_17;
        }
        
        label_15:
        val_25 = val_22;
        val_26 = 1152921504901361664;
        goto label_18;
        label_16:
        var val_5 = (dict + 88) + 0;
        val_23 = val_23 + (((dict + 88 + 0) + 4) << 3);
        val_25 = val_23 + 188;
        val_26 = 1152921504901361664;
        label_18:
        if(val_22 == 0)
        {
            goto label_19;
        }
        
        var val_25 = val_22;
        if((dict + 178) == 0)
        {
            goto label_21;
        }
        
        var val_24 = 0;
        label_23:
        if((dict + 88 + 0) == null)
        {
            goto label_22;
        }
        
        val_24 = val_24 + 1;
        if(((uint)val_24 & 65535) < (dict + 178))
        {
            goto label_23;
        }
        
        label_21:
        val_27 = val_22;
        val_28 = 1152921504901361664;
        goto label_24;
        label_22:
        var val_6 = (dict + 88) + 0;
        val_25 = val_25 + (((dict + 88 + 0) + 4) << 3);
        val_27 = val_25 + 196;
        val_28 = 1152921504901361664;
        label_24:
        val_29 = null;
        string val_7 = 1098586544 + PrettyPrint.separator;
        System.Text.StringBuilder val_8 = PrettyPrint.builder.Append(value:  1098586544);
        val_30 = null;
        if(val_20 >= 0)
        {
                var val_26 = 0;
            do
        {
            System.Text.StringBuilder val_10 = PrettyPrint.builder.Append(value:  PrettyPrint.tab);
            val_33 = null;
            val_26 = val_26 + 1;
        }
        while(val_26 <= val_20);
        
        }
        
        PrettyPrint.append(obj:  val_22, level:  val_4);
        System.Text.StringBuilder val_12 = PrettyPrint.builder.Append(value:  1788552112);
        System.Collections.IDictionary val_28 = dict;
        if((dict + 178) == 0)
        {
            goto label_37;
        }
        
        var val_27 = 0;
        label_39:
        if((dict + 88 + 0) == null)
        {
            goto label_38;
        }
        
        val_27 = val_27 + 1;
        if(((uint)val_27 & 65535) < (dict + 178))
        {
            goto label_39;
        }
        
        label_37:
        val_34 = dict;
        goto label_40;
        label_38:
        var val_13 = (dict + 88) + 0;
        val_28 = val_28 + (((dict + 88 + 0) + 4) << 3);
        val_34 = val_28 + 188;
        label_40:
        PrettyPrint.append(obj:  dict, level:  val_4);
        goto label_41;
        label_19:
        val_35 = 1152921504619679744;
        if(val_22 == 0)
        {
            goto label_43;
        }
        
        if((dict + 178) == 0)
        {
            goto label_44;
        }
        
        val_35 = 0;
        label_46:
        if((dict + 88 + 0) == null)
        {
            goto label_45;
        }
        
        val_35 = val_35 + 1;
        if(((uint)val_35 & 65535) < (dict + 178))
        {
            goto label_46;
        }
        
        label_44:
        val_36 = val_22;
        goto label_47;
        label_45:
        var val_14 = (dict + 88) + 0;
        var val_29 = (dict + 88 + 0) + 4;
        val_29 = val_22 + (val_29 << 3);
        val_36 = val_29 + 188;
        label_47:
        val_26 = 1152921504901361664;
        label_43:
        val_37 = null;
        val_38 = PrettyPrint.separator;
        System.Text.StringBuilder val_15 = PrettyPrint.builder.Append(value:  val_38);
        val_39 = 1152921504901361664;
        val_40 = null;
        val_41 = (uint)(((uint)((PrettyPrint.__il2cppRuntimeField_BB>>1) & 0x1)) >> 1) & 1;
        if(val_20 >= 1)
        {
                do
        {
            if((val_41 & 1) == 0)
        {
                val_42 = null;
        }
        
            val_38 = PrettyPrint.tab;
            System.Text.StringBuilder val_16 = PrettyPrint.builder.Append(value:  val_38);
            val_20 = val_20 - 1;
            val_39 = 1152921504901361664;
            val_43 = null;
            val_41 = (uint)(((uint)((PrettyPrint.__il2cppRuntimeField_BB>>1) & 0x1)) >> 1) & 1;
        }
        while(PrettyPrint.builder != 0);
        
        }
        
        System.Text.StringBuilder val_17 = PrettyPrint.builder.Append(value:  1487337936);
    }
    private static void appendArray(System.Array array, int level)
    {
        var val_18;
        System.Array val_19;
        var val_20;
        System.Array val_21;
        var val_22;
        var val_23;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        string val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        int val_21 = level;
        val_18 = null;
        val_18 = null;
        System.Text.StringBuilder val_1 = PrettyPrint.builder.Append(value:  1466574320);
        System.Collections.IEnumerator val_2 = array.GetEnumerator();
        label_26:
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_19 = array;
        val_20 = val_19;
        if( == 0)
        {
            goto label_10;
        }
        
        var val_18 = ;
        if((array + 178) == 0)
        {
            goto label_12;
        }
        
        var val_17 = 0;
        label_14:
        if((array + 88 + 0) == null)
        {
            goto label_13;
        }
        
        val_17 = val_17 + 1;
        if(((uint)val_17 & 65535) < (array + 178))
        {
            goto label_14;
        }
        
        label_12:
        val_21 = array;
        goto label_15;
        label_13:
        var val_5 = (array + 88) + 0;
        val_18 = val_18 + (((array + 88 + 0) + 4) << 3);
        val_21 = val_18 + 196;
        label_15:
        val_22 = null;
        val_22 = null;
        string val_6 = 1098586544 + PrettyPrint.separator;
        System.Text.StringBuilder val_7 = PrettyPrint.builder.Append(value:  1098586544);
        val_23 = null;
        if(val_21 >= 0)
        {
                var val_19 = 0;
            do
        {
            System.Text.StringBuilder val_9 = PrettyPrint.builder.Append(value:  PrettyPrint.tab);
            val_26 = null;
            val_19 = val_19 + 1;
        }
        while(val_19 <= val_21);
        
        }
        
        PrettyPrint.append(obj:  array, level:  val_21 + 1);
        goto label_26;
        label_10:
        val_27 = 1152921504619679744;
        if( == 0)
        {
            goto label_28;
        }
        
        if((array + 178) == 0)
        {
            goto label_29;
        }
        
        val_27 = 0;
        label_31:
        if((array + 88 + 0) == null)
        {
            goto label_30;
        }
        
        val_27 = val_27 + 1;
        if(((uint)val_27 & 65535) < (array + 178))
        {
            goto label_31;
        }
        
        label_29:
        val_28 = ;
        goto label_32;
        label_30:
        var val_11 = (array + 88) + 0;
        var val_20 = (array + 88 + 0) + 4;
        val_20 =  + (val_20 << 3);
        val_28 = val_20 + 188;
        label_32:
        label_28:
        val_29 = null;
        val_29 = null;
        val_30 = PrettyPrint.separator;
        System.Text.StringBuilder val_12 = PrettyPrint.builder.Append(value:  val_30);
        val_31 = null;
        val_32 = (uint)(((uint)((PrettyPrint.__il2cppRuntimeField_BB>>1) & 0x1)) >> 1) & 1;
        if(val_21 >= 1)
        {
                do
        {
            if((val_32 & 1) == 0)
        {
                val_33 = null;
        }
        
            val_30 = PrettyPrint.tab;
            System.Text.StringBuilder val_13 = PrettyPrint.builder.Append(value:  val_30);
            val_34 = null;
            val_21 = val_21 - 1;
            val_32 = (uint)(((uint)((PrettyPrint.__il2cppRuntimeField_BB>>1) & 0x1)) >> 1) & 1;
        }
        while(PrettyPrint.builder != 0);
        
        }
        
        if(val_32 != 0)
        {
                val_34 = null;
        }
        
        System.Text.StringBuilder val_14 = PrettyPrint.builder.Append(value:  1487188992);
    }
    public PrettyPrint()
    {
    
    }
    private static PrettyPrint()
    {
        PrettyPrint.separator = "\n";
        PrettyPrint.tab = "\t";
    }

}
