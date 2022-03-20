using UnityEngine;
public static class MoreLinq
{
    // Methods
    public static TSource MaxBy<TSource, TKey>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> selector)
    {
        goto __RuntimeMethodHiddenParam + 24 + 8;
    }
    public static TSource MaxBy<TSource, TKey>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> selector, System.Collections.Generic.IComparer<TKey> comparer)
    {
        var val_5;
        var val_6;
        var val_13;
        var val_14;
        var val_15;
        System.Func<TSource, TKey> val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        System.ArgumentNullException val_25;
        var val_26;
        if(selector == 0)
        {
            goto label_1;
        }
        
        if(comparer == 0)
        {
            goto label_2;
        }
        
        if(__RuntimeMethodHiddenParam == 0)
        {
            goto label_3;
        }
        
        var val_13 = 0;
        val_13 = 0;
        val_13 = val_13 + 1;
        val_13 = (uint)val_13 & 65535;
        val_15 = selector;
        val_16 = selector;
        val_13 = 0;
        val_14 = 0;
        val_13 = val_13 + 1;
        val_14 = (uint)val_13 & 65535;
        val_17 = val_16;
        if(val_16 == 0)
        {
            goto label_14;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_18 = val_16;
        val_19 = val_5;
        goto label_21;
        label_38:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_21 = val_16;
        var val_17 = __RuntimeMethodHiddenParam;
        if((__RuntimeMethodHiddenParam + 178) == 0)
        {
            goto label_29;
        }
        
        var val_16 = 0;
        label_31:
        val_14 = mem[__RuntimeMethodHiddenParam + 88 + 0];
        val_14 = __RuntimeMethodHiddenParam + 88 + 0;
        if(val_14 == (val_1 + 24 + 12))
        {
            goto label_30;
        }
        
        val_16 = val_16 + 1;
        if(((uint)val_16 & 65535) < (__RuntimeMethodHiddenParam + 178))
        {
            goto label_31;
        }
        
        label_29:
        val_22 = __RuntimeMethodHiddenParam;
        goto label_32;
        label_30:
        var val_8 = (__RuntimeMethodHiddenParam + 88) + 0;
        val_17 = val_17 + (((__RuntimeMethodHiddenParam + 88 + 0) + 4) << 3);
        val_22 = val_17 + 188;
        label_32:
        if(__RuntimeMethodHiddenParam >= 1)
        {
                val_6 = val_6;
        }
        
        if(__RuntimeMethodHiddenParam >= 1)
        {
                val_19 = val_5;
        }
        
        val_16 = val_16;
        if(__RuntimeMethodHiddenParam >= 1)
        {
                comparer = comparer;
        }
        
        label_21:
        var val_19 = val_16;
        if((selector + 178) == 0)
        {
            goto label_34;
        }
        
        var val_18 = 0;
        label_36:
        val_20 = 0;
        val_14 = mem[selector + 88 + 0];
        val_14 = selector + 88 + 0;
        if(val_14 == null)
        {
            goto label_35;
        }
        
        val_18 = val_18 + 1;
        val_20 = (uint)val_18 & 65535;
        if(val_20 < (selector + 178))
        {
            goto label_36;
        }
        
        label_34:
        val_23 = val_16;
        goto label_37;
        label_35:
        var val_9 = (selector + 88) + 0;
        val_19 = val_19 + (((selector + 88 + 0) + 4) << 3);
        val_23 = val_19 + 188;
        label_37:
        if(val_16 != 0)
        {
            goto label_38;
        }
        
        label_59:
        if(val_16 == 0)
        {
            goto label_39;
        }
        
        var val_21 = val_16;
        if((selector + 178) == 0)
        {
            goto label_40;
        }
        
        var val_20 = 0;
        label_42:
        val_20 = 0;
        val_14 = mem[selector + 88 + 0];
        val_14 = selector + 88 + 0;
        if(val_14 == null)
        {
            goto label_41;
        }
        
        val_20 = val_20 + 1;
        val_20 = (uint)val_20 & 65535;
        if(val_20 < (selector + 178))
        {
            goto label_42;
        }
        
        label_40:
        val_24 = val_16;
        goto label_43;
        label_41:
        var val_10 = (selector + 88) + 0;
        val_21 = val_21 + (((selector + 88 + 0) + 4) << 3);
        val_24 = val_21 + 188;
        label_43:
        label_39:
        mem2[0] = val_19;
        mem2[0] = val_6;
        return (System.Collections.Generic.KeyValuePair<System.Object, System.Int32>)source;
        label_1:
        val_25 = null;
        val_26 = "source";
        goto label_46;
        label_2:
        val_25 = null;
        val_26 = "selector";
        goto label_46;
        label_3:
        val_25 = null;
        val_26 = "comparer";
        label_46:
        val_25 = new System.ArgumentNullException(paramName:  -2125332928);
        label_14:
        System.InvalidOperationException val_12 = new System.InvalidOperationException(message:  -2125331808);
        if((public static System.Collections.Generic.KeyValuePair<System.Object, System.Int32> MoreLinq::MaxBy<System.Collections.Generic.KeyValuePair<System.Object, System.Int32>, System.Int32>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> selector, System.Collections.Generic.IComparer<TKey> comparer)) != 1)
        {
            goto label_58;
        }
        
        goto label_59;
        label_58:
    }
    public static TSource MinBy<TSource, TKey>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> selector)
    {
        goto __RuntimeMethodHiddenParam + 24 + 8;
    }
    public static TSource MinBy<TSource, TKey>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> selector, System.Collections.Generic.IComparer<TKey> comparer)
    {
        var val_5;
        var val_6;
        var val_13;
        var val_14;
        System.Func<TSource, TKey> val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        System.ArgumentNullException val_24;
        var val_25;
        if(selector == 0)
        {
            goto label_1;
        }
        
        if(comparer == 0)
        {
            goto label_2;
        }
        
        if(__RuntimeMethodHiddenParam == 0)
        {
            goto label_3;
        }
        
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_14 = selector;
        val_15 = selector;
        var val_14 = 0;
        val_13 = 0;
        val_14 = val_14 + 1;
        val_13 = (uint)val_14 & 65535;
        val_16 = val_15;
        if(val_15 == 0)
        {
            goto label_14;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_17 = val_15;
        val_18 = val_5;
        goto label_21;
        label_38:
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_20 = val_15;
        var val_18 = __RuntimeMethodHiddenParam;
        if((__RuntimeMethodHiddenParam + 178) == 0)
        {
            goto label_29;
        }
        
        var val_17 = 0;
        label_31:
        val_13 = mem[__RuntimeMethodHiddenParam + 88 + 0];
        val_13 = __RuntimeMethodHiddenParam + 88 + 0;
        if(val_13 == (val_1 + 24 + 12))
        {
            goto label_30;
        }
        
        val_17 = val_17 + 1;
        if(((uint)val_17 & 65535) < (__RuntimeMethodHiddenParam + 178))
        {
            goto label_31;
        }
        
        label_29:
        val_21 = __RuntimeMethodHiddenParam;
        goto label_32;
        label_30:
        var val_8 = (__RuntimeMethodHiddenParam + 88) + 0;
        val_18 = val_18 + (((__RuntimeMethodHiddenParam + 88 + 0) + 4) << 3);
        val_21 = val_18 + 188;
        label_32:
        if(__RuntimeMethodHiddenParam <= 1)
        {
                val_6 = val_6;
        }
        
        if(__RuntimeMethodHiddenParam <= 1)
        {
                val_18 = val_5;
        }
        
        val_15 = val_15;
        if(__RuntimeMethodHiddenParam <= 1)
        {
                comparer = comparer;
        }
        
        label_21:
        var val_20 = val_15;
        if((selector + 178) == 0)
        {
            goto label_34;
        }
        
        var val_19 = 0;
        label_36:
        val_19 = 0;
        val_13 = mem[selector + 88 + 0];
        val_13 = selector + 88 + 0;
        if(val_13 == null)
        {
            goto label_35;
        }
        
        val_19 = val_19 + 1;
        val_19 = (uint)val_19 & 65535;
        if(val_19 < (selector + 178))
        {
            goto label_36;
        }
        
        label_34:
        val_22 = val_15;
        goto label_37;
        label_35:
        var val_9 = (selector + 88) + 0;
        val_20 = val_20 + (((selector + 88 + 0) + 4) << 3);
        val_22 = val_20 + 188;
        label_37:
        if(val_15 != 0)
        {
            goto label_38;
        }
        
        label_59:
        if(val_15 == 0)
        {
            goto label_39;
        }
        
        var val_22 = val_15;
        if((selector + 178) == 0)
        {
            goto label_40;
        }
        
        var val_21 = 0;
        label_42:
        val_19 = 0;
        val_13 = mem[selector + 88 + 0];
        val_13 = selector + 88 + 0;
        if(val_13 == null)
        {
            goto label_41;
        }
        
        val_21 = val_21 + 1;
        val_19 = (uint)val_21 & 65535;
        if(val_19 < (selector + 178))
        {
            goto label_42;
        }
        
        label_40:
        val_23 = val_15;
        goto label_43;
        label_41:
        var val_10 = (selector + 88) + 0;
        val_22 = val_22 + (((selector + 88 + 0) + 4) << 3);
        val_23 = val_22 + 188;
        label_43:
        label_39:
        mem2[0] = val_18;
        mem2[0] = val_6;
        return (System.Collections.Generic.KeyValuePair<System.Object, System.Int32>)source;
        label_1:
        val_24 = null;
        val_25 = "source";
        goto label_46;
        label_2:
        val_24 = null;
        val_25 = "selector";
        goto label_46;
        label_3:
        val_24 = null;
        val_25 = "comparer";
        label_46:
        val_24 = new System.ArgumentNullException(paramName:  -2125332928);
        label_14:
        System.InvalidOperationException val_12 = new System.InvalidOperationException(message:  -2125331808);
        if((public static System.Collections.Generic.KeyValuePair<System.Object, System.Int32> MoreLinq::MinBy<System.Collections.Generic.KeyValuePair<System.Object, System.Int32>, System.Int32>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, TKey> selector, System.Collections.Generic.IComparer<TKey> comparer)) != 1)
        {
            goto label_58;
        }
        
        goto label_59;
        label_58:
    }

}
