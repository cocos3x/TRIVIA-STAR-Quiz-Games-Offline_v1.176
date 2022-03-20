using UnityEngine;
public class SLCDateTime
{
    // Methods
    public static System.DateTime Parse(string dateTime)
    {
        ulong val_3;
        System.DateTime val_1 = System.DateTime.Parse(s:  -2011855072);
        mem2[0] = val_3;
        return new System.DateTime() {dateData = val_3};
    }
    public static System.DateTime Parse(string dateTime, System.DateTime defaultValue)
    {
        bool val_1 = System.DateTime.TryParse(s:  defaultValue.dateData, result: out  new System.DateTime() {dateData = 1152921511185046680});
        mem2[0] = R2;
        return new System.DateTime() {dateData = R2};
    }
    public static string SerializeInvariant(System.DateTime dateTime)
    {
        System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
        string val_2 = dateTime.dateData.ToString(provider:  0);
    }
    public static System.DateTime ParseInvariant(string dateTime, System.DateTime defaultValue)
    {
        System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
        bool val_2 = System.DateTime.TryParse(s:  defaultValue.dateData, provider:  0, styles:  0, result: out  new System.DateTime() {dateData = 1152921511185278872});
        mem2[0] = R2;
        return new System.DateTime() {dateData = R2};
    }
    public SLCDateTime()
    {
    
    }

}
