using UnityEngine;
public static class MetricSystem
{
    // Fields
    private static string[] affix;
    private static string[] richTextAffix;
    private static string[] uncoloredAffix;
    private static string[] affixColor;
    
    // Methods
    public static string Abbreviate(decimal number, int maxSigFigs = 3, bool round = True, bool useColor = True, decimal maxValueWithoutAbbr, bool useRichText = False, bool withSpaces = False)
    {
        var val_9;
        int val_36;
        int val_37;
        int val_38;
        int val_39;
        int val_40;
        var val_41;
        var val_42;
        int val_43;
        int val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_50;
        bool val_51;
        int val_53;
        int val_54;
        int val_55;
        var val_56;
        var val_57;
        var val_58;
        int val_59;
        float val_60;
        var val_62;
        int val_63;
        int val_64;
        int val_65;
        var val_68;
        int val_69;
        var val_70;
        System.String[] val_71;
        val_36 = number.flags;
        val_37 = number.mid;
        val_38 = 35629450;
        val_39 = number.lo;
        val_40 = number.hi;
        val_41 = null;
        val_41 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_36, hi = val_40, lo = val_39, mid = val_37}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                val_42 = "0";
            return;
        }
        
        val_43 = maxValueWithoutAbbr.mid;
        val_44 = maxValueWithoutAbbr.hi;
        val_38 = maxValueWithoutAbbr.flags;
        val_43 = maxValueWithoutAbbr.mid;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_36, hi = val_40, lo = val_39, mid = val_37}, d2:  new System.Decimal() {flags = val_38, hi = val_44, lo = maxValueWithoutAbbr.lo, mid = val_43})) == false)
        {
            goto label_7;
        }
        
        string val_3 = val_36.ToString(format:  -1777242576);
        goto label_8;
        label_7:
        val_46 = 0;
        val_47 = 0;
        goto label_9;
        label_16:
        decimal val_4 = new System.Decimal(value:  10);
        decimal val_5 = System.Decimal.op_Modulus(d1:  new System.Decimal() {flags = -1777230504, hi = val_36, lo = number.hi, mid = number.lo}, d2:  new System.Decimal() {flags = number.mid, hi = val_4.flags, lo = val_4.hi, mid = val_4.lo});
        val_46 = 0;
        bool val_36 = System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        decimal val_7 = new System.Decimal(value:  10);
        val_50 = 0;
        val_51 = false;
        val_36 = 0 & val_36;
        val_51 = false;
        val_50 = 0;
        val_51 = val_51 + val_36;
        val_50 = val_50 + 1;
        decimal val_8 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -1777230504, hi = val_4.flags, lo = val_4.hi, mid = val_4.lo}, d2:  new System.Decimal() {flags = val_4.mid, hi = val_7.flags, lo = val_7.hi, mid = val_7.lo});
        val_55 = val_7.flags;
        val_47 = val_9 - 1;
        label_9:
        val_9 = val_47;
        val_56 = null;
        val_56 = null;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_36, hi = val_53, lo = val_54, mid = val_55}, d2:  new System.Decimal() {flags = System.Decimal.One, mid = System.Decimal.Powers10.__il2cppRuntimeField_20})) == true)
        {
            goto label_16;
        }
        
        val_57 = val_50;
        val_58 = null;
        if((val_57 - val_51) > maxSigFigs)
        {
                val_59 = maxSigFigs;
        }
        
        val_57 = val_50;
        val_58 = null;
        if(MetricSystem.affix == null)
        {
                val_57 = val_50;
        }
        
        val_60 = 1152921504620371968;
        val_57 = val_50;
        int val_12 = val_57 - 1;
        int val_37 = MetricSystem.affix + 12;
        val_37 = val_37 - 1;
        val_12 = val_12 + (val_12 >> 31);
        int val_14 = System.Math.Max(val1:  System.Math.Min(val1:  val_12, val2:  val_37), val2:  0);
        int val_15 = val_14 - (val_14 << 2);
        int val_16 = val_15 + val_50;
        if(round == false)
        {
            goto label_22;
        }
        
        if(val_16 >= 1)
        {
                val_15 = val_15 + val_50;
            int val_17 = val_15 + 1;
            val_14 = val_14 + (val_14 << 1);
            do
        {
            decimal val_18 = new System.Decimal(value:  10);
            decimal val_19 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -1777230504, hi = val_7.flags, lo = val_7.hi, mid = val_7.lo}, d2:  new System.Decimal() {flags = val_7.mid, hi = val_18.flags, lo = val_18.hi, mid = val_18.lo});
            val_17 = val_17 - 1;
        }
        while(val_17 > 1);
        
            var val_38 = val_9;
            val_38 = val_51 + val_38;
            if(val_38 > (~maxSigFigs))
        {
                ~maxSigFigs = val_38;
        }
        
            int val_39 = val_14;
            val_39 = val_39 - (~maxSigFigs);
            val_39 = val_39 - 1;
            val_59 = val_39 - val_50;
            val_60 = 1152921504620371968;
        }
        
        if(val_59 < 1)
        {
            goto label_27;
        }
        
        var val_40 = val_59;
        val_62 = "###.";
        do
        {
            string val_20 = -1777242496(-1777242496) + 1726048032;
            val_40 = val_40 - 1;
        }
        while(val_59 != 1);
        
        goto label_29;
        label_22:
        val_44 = val_18.flags;
        val_38 = val_18.hi;
        val_64 = val_18.lo;
        val_65 = val_18.mid;
        if(val_16 >= 1)
        {
                bool val_41 = val_51;
            val_41 = val_41 - 1;
            val_41 = val_41 - val_50;
            if(val_41 > (~maxSigFigs))
        {
                ~maxSigFigs = val_41;
        }
        
            bool val_21 = 1 - (~maxSigFigs);
            do
        {
            decimal val_22 = new System.Decimal(value:  10);
            decimal val_23 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -1777230504, hi = val_44, lo = val_38, mid = val_64}, d2:  new System.Decimal() {flags = val_65, hi = val_22.flags, lo = val_22.hi, mid = val_22.lo});
            val_63 = val_16 - 1;
            bool val_24 = val_21 - 1;
            val_44 = val_22.flags;
            val_38 = val_22.hi;
            val_64 = val_22.lo;
            val_65 = val_22.flags;
        }
        while((val_21 > false) || (val_63 > 0));
        
        }
        
        decimal val_25 = System.Math.Truncate(d:  new System.Decimal() {flags = -1777230488, hi = val_44, lo = val_38, mid = val_64});
        if(val_63 > 1)
        {
            goto label_41;
        }
        
        val_38 = 0;
        val_65 = "#";
        val_44 = val_22.flags;
        decimal val_26 = new System.Decimal(value:  10);
        decimal val_27 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -1777230504, hi = val_44, lo = val_22.hi, mid = val_22.lo}, d2:  new System.Decimal() {flags = val_22.mid, hi = val_26.flags, lo = val_26.hi, mid = val_26.lo});
        string val_28 = -1777242496(-1777242496) + 1726048032;
        val_63 = val_63 + 1;
        goto label_41;
        label_27:
        val_62 = "###.";
        label_29:
        val_38 = val_26.flags;
        val_65 = val_26.hi;
        int val_29 = val_59 & (~(val_59 >> 31));
        val_63 = val_26.mid;
        decimal val_30 = System.Math.Round(d:  new System.Decimal() {flags = -1777230488, hi = val_38, lo = val_65, mid = val_26.lo}, decimals:  val_63);
        label_41:
        string val_31 = val_26.flags.ToString(format:  -1777242496);
        val_68 = null;
        if(useColor == false)
        {
            goto label_44;
        }
        
        if(useRichText == false)
        {
            goto label_45;
        }
        
        val_69 = val_14;
        goto label_53;
        label_44:
        val_70 = null;
        val_69 = val_14;
        val_71 = MetricSystem.uncoloredAffix;
        goto label_54;
        label_45:
        val_69 = val_14;
        goto label_55;
        label_53:
        val_71 = MetricSystem.richTextAffix;
        goto label_54;
        label_55:
        val_71 = MetricSystem.affix;
        label_54:
        System.String[] val_33 = val_71 + ( << 2);
        string val_34 = -1777230488(-1777230488) + (MetricSystem.affix + (val_14) << 2) + 16((MetricSystem.affix + (val_14) << 2) + 16);
        val_42 = ;
        if(withSpaces == true)
        {
                return;
        }
        
        val_45 = val_42;
        string val_35 = val_26.flags.Replace(oldValue:  1297836560, newValue:  System.String.alignConst);
        label_8:
        val_42 = val_45;
    }
    public static UnityEngine.Color GetMetricColor(decimal number, int maxSigFigs = 3, bool round = True)
    {
        int val_8;
        int val_14;
        int val_15;
        int val_16;
        int val_17;
        var val_18;
        System.String[] val_19;
        int val_20;
        var val_25;
        var val_28;
        var val_29;
        val_14 = number.mid;
        val_15 = number.lo;
        val_16 = number.hi;
        val_17 = maxSigFigs;
        val_18 = null;
        val_18 = null;
        val_19 = 0;
        val_20 = val_14;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_16, hi = val_15, lo = val_20, mid = val_17}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                UnityEngine.Color val_2 = UnityEngine.Color.white;
            return new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
        }
        
        val_25 = 0;
        goto label_5;
        label_12:
        decimal val_3 = new System.Decimal(value:  10);
        decimal val_4 = System.Decimal.op_Modulus(d1:  new System.Decimal() {flags = -1777118488, hi = val_16, lo = val_15, mid = val_14}, d2:  new System.Decimal() {flags = val_17, hi = val_3.flags, lo = val_3.hi, mid = val_3.lo});
        bool val_5 = System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        decimal val_6 = new System.Decimal(value:  10);
        decimal val_7 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -1777118488, hi = val_16, lo = val_15, mid = val_14}, d2:  new System.Decimal() {flags = val_17, hi = val_6.flags, lo = val_6.hi, mid = val_6.lo});
        val_17 = val_8;
        val_25 = 1;
        label_5:
        val_28 = null;
        val_28 = null;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = R7, hi = R8, lo = SB, mid = val_17}, d2:  new System.Decimal() {flags = System.Decimal.One, mid = System.Decimal.Powers10.__il2cppRuntimeField_20})) == true)
        {
            goto label_12;
        }
        
        val_29 = null;
        val_29 = null;
        val_19 = MetricSystem.affix;
        int val_14 = MetricSystem.affix + 12;
        val_14 = val_14 - 1;
        System.String[] val_12 = MetricSystem.affixColor + ((System.Math.Max(val1:  System.Math.Min(val1:  1431655766, val2:  val_14), val2:  0)) << 2);
        UnityEngine.Color val_13 = MetricSystem.HexToColor(hex:  number.flags);
        return new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
    }
    public static UnityEngine.Color HexToColor(string hex)
    {
        string val_1 = R1.Substring(startIndex:  0, length:  2);
        string val_3 = R1.Substring(startIndex:  2, length:  2);
        string val_5 = R1.Substring(startIndex:  4, length:  2);
        UnityEngine.Color32 val_7 = new UnityEngine.Color32(r:  System.Byte.Parse(s:  R1, style:  515), g:  System.Byte.Parse(s:  R1, style:  515), b:  System.Byte.Parse(s:  R1, style:  515), a:  255);
        UnityEngine.Color val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = hex, g = hex, b = hex, a = hex});
        return new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
    }
    public static string ColorToHex(UnityEngine.Color32 color)
    {
        string val_1 = color.r.ToString(format:  -1776898224);
        string val_2 = color.g.ToString(format:  -1776898224);
        string val_3 = color.b.ToString(format:  -1776898224);
        string val_4 = -1776886172(-1776886172) + -1776886171(-1776886171) + -1776886170(-1776886170);
    }
    private static MetricSystem()
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = "";
        typeof(System.String[]).__il2cppRuntimeField_14 = "[aca4f4] K[-]";
        typeof(System.String[]).__il2cppRuntimeField_18 = "[7bdaff] M[-]";
        typeof(System.String[]).__il2cppRuntimeField_1C = "[b6ffac] B[-]";
        typeof(System.String[]).__il2cppRuntimeField_20 = "[ebff43] T[-]";
        typeof(System.String[]).__il2cppRuntimeField_24 = "[ff9854] q[-]";
        typeof(System.String[]).__il2cppRuntimeField_28 = "[fe615e] Q[-]";
        typeof(System.String[]).__il2cppRuntimeField_2C = "[ff9cc7] s[-]";
        typeof(System.String[]).__il2cppRuntimeField_30 = "[c6c6c6] S[-]";
        MetricSystem.affix = null;
        typeof(System.String[]).__il2cppRuntimeField_10 = "";
        typeof(System.String[]).__il2cppRuntimeField_14 = "<color=#aca4f4> K</color>";
        typeof(System.String[]).__il2cppRuntimeField_18 = "<color=#7bdaff> M</color>";
        typeof(System.String[]).__il2cppRuntimeField_1C = "<color=#b6ffac> B</color>";
        typeof(System.String[]).__il2cppRuntimeField_20 = "<color=#ebff43> T</color>";
        typeof(System.String[]).__il2cppRuntimeField_24 = "<color=#ff9854> q</color>";
        typeof(System.String[]).__il2cppRuntimeField_28 = "<color=#fe615e> Q</color>";
        typeof(System.String[]).__il2cppRuntimeField_2C = "<color=#ff9cc7> s</color>";
        typeof(System.String[]).__il2cppRuntimeField_30 = "<color=#c6c6c6> S</color>";
        MetricSystem.richTextAffix = null;
        typeof(System.String[]).__il2cppRuntimeField_10 = "";
        typeof(System.String[]).__il2cppRuntimeField_14 = " K";
        typeof(System.String[]).__il2cppRuntimeField_18 = " M";
        typeof(System.String[]).__il2cppRuntimeField_1C = " B";
        typeof(System.String[]).__il2cppRuntimeField_20 = " T";
        typeof(System.String[]).__il2cppRuntimeField_24 = " q";
        typeof(System.String[]).__il2cppRuntimeField_28 = " Q";
        typeof(System.String[]).__il2cppRuntimeField_2C = " s";
        typeof(System.String[]).__il2cppRuntimeField_30 = " S";
        MetricSystem.uncoloredAffix = null;
        typeof(System.String[]).__il2cppRuntimeField_10 = "000000";
        typeof(System.String[]).__il2cppRuntimeField_14 = "aca4f4";
        typeof(System.String[]).__il2cppRuntimeField_18 = "7bdaff";
        typeof(System.String[]).__il2cppRuntimeField_1C = "b6ffac";
        typeof(System.String[]).__il2cppRuntimeField_20 = "ebff43";
        typeof(System.String[]).__il2cppRuntimeField_24 = "ff9854";
        typeof(System.String[]).__il2cppRuntimeField_28 = "fe615e";
        typeof(System.String[]).__il2cppRuntimeField_2C = "ff9cc7";
        typeof(System.String[]).__il2cppRuntimeField_30 = "c6c6c6";
        MetricSystem.affixColor = null;
    }

}
