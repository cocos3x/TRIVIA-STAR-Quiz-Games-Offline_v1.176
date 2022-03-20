using UnityEngine;
public class SubscriptionModel : JsonSerializable<SubscriptionModel>
{
    // Fields
    private string <InternalId>k__BackingField;
    private string <packageName>k__BackingField;
    private string <token>k__BackingField;
    private string <purchaseId>k__BackingField;
    private decimal <collected_at>k__BackingField;
    private decimal <expire_at>k__BackingField;
    private decimal <start_at>k__BackingField;
    private bool <trial>k__BackingField;
    
    // Properties
    public string InternalId { get; set; }
    public string packageName { get; set; }
    public string token { get; set; }
    public string purchaseId { get; set; }
    public decimal collected_at { get; set; }
    public decimal expire_at { get; set; }
    public decimal start_at { get; set; }
    public bool trial { get; set; }
    public System.DateTime expireTime { get; }
    public System.DateTime startTime { get; }
    public System.DateTime collectedTime { get; }
    public bool IsActive { get; }
    public bool CanCollect { get; }
    
    // Methods
    public string get_InternalId()
    {
    
    }
    public void set_InternalId(string value)
    {
        this.<InternalId>k__BackingField = value;
    }
    public string get_packageName()
    {
    
    }
    public void set_packageName(string value)
    {
        this.<packageName>k__BackingField = value;
    }
    public string get_token()
    {
    
    }
    public void set_token(string value)
    {
        this.<token>k__BackingField = value;
    }
    public string get_purchaseId()
    {
    
    }
    public void set_purchaseId(string value)
    {
        this.<purchaseId>k__BackingField = value;
    }
    public decimal get_collected_at()
    {
        return new System.Decimal() {flags = -1807563872, hi = R1 + 24};
    }
    public void set_collected_at(decimal value)
    {
    
    }
    public decimal get_expire_at()
    {
        return new System.Decimal() {flags = -1807339872, hi = R1 + 40};
    }
    public void set_expire_at(decimal value)
    {
    
    }
    public decimal get_start_at()
    {
        return new System.Decimal() {flags = -1807115872, hi = R1 + 56};
    }
    public void set_start_at(decimal value)
    {
    
    }
    public bool get_trial()
    {
        return (bool)this.<trial>k__BackingField;
    }
    public void set_trial(bool value)
    {
        this.<trial>k__BackingField = value;
    }
    public System.DateTime get_expireTime()
    {
        System.DateTime val_1 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1806667872, hi = R1 + 40, lo = R1 + 44, mid = R1 + 48});
        return new System.DateTime() {dateData = val_1.dateData};
    }
    public System.DateTime get_startTime()
    {
        System.DateTime val_1 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1806555872, hi = R1 + 56, lo = R1 + 60, mid = R1 + 64});
        return new System.DateTime() {dateData = val_1.dateData};
    }
    public System.DateTime get_collectedTime()
    {
        System.DateTime val_1 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1806443872, hi = R1 + 24, lo = R1 + 28, mid = R1 + 32});
        return new System.DateTime() {dateData = val_1.dateData};
    }
    public void ParseJsonDic(twelvegigs.storage.JsonDictionary jsonDic)
    {
        var val_10;
        SubscriptionModel val_12;
        val_10 = null;
        val_10 = null;
        decimal val_1 = getDecimal(key:  jsonDic, defaultValue:  new System.Decimal() {flags = -1806351776, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_8, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
        decimal val_2 = getDecimal(key:  jsonDic, defaultValue:  new System.Decimal() {flags = -1806351680, hi = System.Decimal.Zero});
        decimal val_3 = getDecimal(key:  jsonDic, defaultValue:  new System.Decimal() {flags = -1806351584, hi = System.Decimal.Zero, lo = ???, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
        decimal val_4 = System.Math.Max(val1:  new System.Decimal() {flags = -1806339600, hi = mem[1152921511390454104], lo = 10174464, mid = 10174464}, val2:  new System.Decimal() {flags = ???});
        if(jsonDic != 0)
        {
                string val_5 = jsonDic.getString(key:  -1876049584, defaultValue:  1098586544);
            val_12 = this;
            mem[1152921511390454100] = jsonDic;
        }
        else
        {
                string val_6 = 0.getString(key:  -1876049584, defaultValue:  1098586544);
            val_12 = this;
            mem[1152921511390454100] = 0;
        }
        
        string val_7 = jsonDic.getString(key:  -1830072288, defaultValue:  1098586544);
        mem[1152921511390454092] = jsonDic;
        if((jsonDic.Contains(key:  -1812169776)) == false)
        {
                return;
        }
        
        mem[1152921511390454152] = jsonDic.getBool(key:  -1812169776);
    }
    public bool get_IsActive()
    {
        ulong val_3;
        ulong val_5;
        System.DateTime val_1 = ServerHandler.ServerTime;
        System.DateTime val_2 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1806223424, hi = mem[this.<expire_at>k__BackingField + (0)], lo = mem[this.<expire_at>k__BackingField + (4)], mid = mem[this.<expire_at>k__BackingField + (8)]});
        return (bool)System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_5}, t2:  new System.DateTime() {dateData = val_3});
    }
    public bool get_CanCollect()
    {
        ulong val_10;
        ulong val_12;
        if(this.IsActive == false)
        {
                return true;
        }
        
        System.DateTime val_2 = ServerHandler.ServerTime;
        System.DateTime val_5 = Date;
        System.DateTime val_6 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1806111448, hi = mem[this.<collected_at>k__BackingField + (0)], lo = mem[this.<collected_at>k__BackingField + (4)], mid = mem[this.<collected_at>k__BackingField + (8)]});
        System.DateTime val_9 = Date;
        if((System.DateTime.Compare(t1:  new System.DateTime() {dateData = val_12}, t2:  new System.DateTime() {dateData = val_10})) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool isEqual(NativePurchase purchase)
    {
        if(purchase != 0)
        {
                return System.String.op_Equality(a:  this.<token>k__BackingField, b:  purchase.token);
        }
        
        return System.String.op_Equality(a:  this.<token>k__BackingField, b:  purchase.token);
    }
    public override string ToString()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  -1805850816, formatting:  1);
    }
    public SubscriptionModel()
    {
    
    }

}
