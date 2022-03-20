using UnityEngine;
public static class EnumerableExtentions
{
    // Methods
    public static U GetOrDefault<T, U>(System.Collections.Generic.Dictionary<T, U> dic, T key, U defaultValue)
    {
        var val_1;
        var val_2;
        val_1 = dic;
        val_2 = mem[__RuntimeMethodHiddenParam + 24];
        val_2 = __RuntimeMethodHiddenParam + 24;
        if(val_1 == 0)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 24];
            val_2 = __RuntimeMethodHiddenParam + 24;
        }
    
    }
    public static void SetOrAdd<T, U>(System.Collections.Generic.Dictionary<T, U> dic, T key, U newValue)
    {
        if(dic != 0)
        {
                __RuntimeMethodHiddenParam + 24 = mem[__RuntimeMethodHiddenParam + 24 + 4];
            __RuntimeMethodHiddenParam + 24 = __RuntimeMethodHiddenParam + 24 + 4;
        }
        
        if(dic == 0)
        {
                __RuntimeMethodHiddenParam + 24 = mem[__RuntimeMethodHiddenParam + 24 + 8];
            __RuntimeMethodHiddenParam + 24 = __RuntimeMethodHiddenParam + 24 + 8;
        }
        
        goto __RuntimeMethodHiddenParam + 24 + 8;
    }

}
