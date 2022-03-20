using UnityEngine;
public class RestoreProgressManager.Progression : JsonSerializable<RestoreProgressManager.Progression>
{
    // Fields
    private System.DateTime <lastPlayed>k__BackingField;
    private int <level>k__BackingField;
    private decimal <coins>k__BackingField;
    private decimal <goldenCurrency>k__BackingField;
    
    // Properties
    public System.DateTime lastPlayed { get; set; }
    public int level { get; set; }
    public decimal coins { get; set; }
    public decimal goldenCurrency { get; set; }
    
    // Methods
    public System.DateTime get_lastPlayed()
    {
        this = R1 + 8;
        return new System.DateTime() {dateData = 1152921512977282752};
    }
    public void set_lastPlayed(System.DateTime value)
    {
        this.<lastPlayed>k__BackingField = new System.DateTime();
        mem[1152921512977394764] = R3;
    }
    public int get_level()
    {
        return (int)this.<level>k__BackingField;
    }
    public void set_level(int value)
    {
        this.<level>k__BackingField = value;
    }
    public decimal get_coins()
    {
        return new System.Decimal() {flags = -219050816, hi = R1 + 20};
    }
    public void set_coins(decimal value)
    {
    
    }
    public decimal get_goldenCurrency()
    {
        return new System.Decimal() {flags = -218826816, hi = R1 + 36};
    }
    public void set_goldenCurrency(decimal value)
    {
    
    }
    public void ParseDic(System.Collections.Generic.Dictionary<string, object> obj)
    {
        System.DateTime val_7;
        object val_1 = obj.Item[-218622720];
        string val_2 = obj.ToString();
        decimal val_3 = System.Decimal.Parse(s:  -218610672);
        System.DateTime val_5 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -218610680});
        this.<lastPlayed>k__BackingField = val_7;
        object val_8 = obj.Item[-1988561632];
        string val_9 = obj.ToString();
        this.<level>k__BackingField = System.Int32.Parse(s:  obj);
        object val_11 = obj.Item[-1987496016];
        string val_12 = obj.ToString();
        decimal val_13 = System.Decimal.Parse(s:  -218610704);
        object val_14 = obj.Item[-1825935328];
        string val_15 = obj.ToString();
        decimal val_16 = System.Decimal.Parse(s:  -218610720);
    }
    public RestoreProgressManager.Progression()
    {
    
    }

}
