using UnityEngine;
public static class GenericStringExtentions
{
    // Methods
    public static string ToString(System.TimeSpan span, bool formatted = True)
    {
        int val_14;
        if(formatted == false)
        {
            goto label_1;
        }
        
        if(span._ticks.Hours < 1)
        {
            goto label_2;
        }
        
        val_14 = span._ticks.Hours;
        if(span._ticks.Days >= 1)
        {
                int val_4 = span._ticks.Days;
            val_4 = val_4 + (val_4 << 1);
            val_14 = val_14 + (val_4 << 3);
        }
        
        int val_5 = span._ticks.Minutes;
        int val_6 = span._ticks.Seconds;
        string val_7 = System.String.Format(format:  -2117547664, arg0:  13152256, arg1:  13152256, arg2:  13152256);
        return;
        label_1:
        string val_8 = span._ticks.ToString();
        return;
        label_2:
        int val_10 = UnityEngine.Mathf.Max(a:  0, b:  span._ticks.Minutes);
        int val_12 = UnityEngine.Mathf.Max(a:  0, b:  span._ticks.Seconds);
        string val_13 = System.String.Format(format:  2133722016, arg0:  13152256, arg1:  13152256);
    }

}
