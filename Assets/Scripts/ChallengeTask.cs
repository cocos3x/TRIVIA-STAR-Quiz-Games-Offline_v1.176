using UnityEngine;
public class ChallengeTask
{
    // Fields
    public int id;
    public ChallengeType subject;
    public decimal progress;
    public decimal target;
    public System.DateTime lastCompletedAt;
    
    // Methods
    public void reset()
    {
    
    }
    public bool gainProgress(decimal amt)
    {
        int val_3;
        int val_4;
        val_3 = amt.lo;
        val_4 = amt.mid;
        val_4 = amt.mid;
        val_3 = val_3;
        decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1600946148, hi = mem[this.progress + (0)], lo = mem[this.progress + (4)], mid = mem[this.progress + (8)]}, d2:  new System.Decimal() {flags = mem[this.progress + (12)], hi = amt.flags, lo = amt.hi, mid = val_3});
        return (bool)System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = this.target, hi = mem[this.progress + (4)], lo = mem[this.progress + (0)], mid = ???});
    }
    public bool setProgress(decimal amt)
    {
        int val_3;
        int val_4;
        val_3 = amt.lo;
        val_4 = amt.mid;
        val_4 = amt.mid;
        val_3 = val_3;
        decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1600834148, hi = mem[this.progress + (0)], lo = mem[this.progress + (4)], mid = mem[this.progress + (8)]}, d2:  new System.Decimal() {flags = mem[this.progress + (12)], hi = amt.flags, lo = amt.hi, mid = val_3});
        return (bool)System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = this.target, hi = mem[this.progress + (4)], lo = mem[this.progress + (0)], mid = ???});
    }
    public float getPercent()
    {
        int val_3;
        decimal val_7;
        int val_8;
        int val_9;
        var val_10;
        decimal val_11;
        var val_13;
        float val_14;
        int val_15;
        val_7 = this.progress;
        val_9 = ???;
        val_8 = ???;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_7, hi = val_8, lo = val_9, mid = R8}, d2:  new System.Decimal() {flags = this.target, lo = ???, mid = ???})) != false)
        {
                val_14 = 1f;
            return (float)S0;
        }
        
        val_11 = this.progress;
        val_15 = ???;
        val_10 = 0;
        decimal val_2 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -1600722148, hi = val_11, lo = val_7, mid = val_15}, d2:  new System.Decimal() {hi = this.target, mid = ???});
        decimal val_4 = System.Math.Max(val1:  new System.Decimal() {flags = -1600722164}, val2:  new System.Decimal() {flags = val_3, hi = System.Decimal.Zero});
        decimal val_5 = System.Math.Min(val1:  new System.Decimal() {flags = -1600722180}, val2:  new System.Decimal() {hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_18, mid = System.Decimal.Powers10.__il2cppRuntimeField_1C});
        val_13 = 0;
        double val_6 = System.Convert.ToDouble(value:  new System.Decimal());
        return (float)S0;
    }
    public bool isComplete()
    {
        return (bool)System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = mem[this.progress + (0)], hi = mem[this.progress + (4)], lo = mem[this.progress + (8)], mid = ???}, d2:  new System.Decimal() {mid = this});
    }
    public void Complete(decimal currentIncrement, decimal currentMax)
    {
        int val_4;
        int val_7;
        int val_8;
        decimal val_11;
        int val_12;
        if(this.isComplete() == false)
        {
                return;
        }
        
        goto label_2;
        label_9:
        val_11 = this.progress;
        val_12 = ???;
        val_11 = val_11;
        decimal val_2 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1600498160, hi = val_11, lo = mem[this.target + (12)], mid = val_12}, d2:  new System.Decimal() {});
        decimal val_3 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1600498176, hi = mem[this.target + (0)], lo = mem[this.target + (4)], mid = mem[this.target + (8)]}, d2:  new System.Decimal() {flags = this.progress, hi = currentIncrement.flags, lo = currentIncrement.hi, mid = currentIncrement.lo});
        decimal val_5 = System.Math.Min(val1:  new System.Decimal() {flags = -1600498192}, val2:  new System.Decimal() {flags = val_4, hi = currentMax.flags, lo = currentMax.hi, mid = currentMax.lo});
        label_2:
        val_8 = ???;
        val_7 = ???;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = this.progress, hi = R6, mid = R8}, d2:  new System.Decimal() {flags = val_7, hi = val_8})) == true)
        {
            goto label_9;
        }
    
    }
    public System.Collections.Generic.Dictionary<string, object> serialize()
    {
        var val_6;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  13152256);
        string val_2 = this.progress.ToString();
        Add(key:  -1600398096, value:  this.progress);
        string val_3 = this.target.ToString();
        Add(key:  1383185776, value:  this.target);
        val_6 = null;
        val_6 = null;
        if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = this.lastCompletedAt}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) == false)
        {
                return;
        }
        
        string val_5 = this.lastCompletedAt.ToString();
        Add(key:  -1600398016, value:  this.lastCompletedAt);
    }
    public void deserialize(System.Collections.IDictionary data)
    {
        System.DateTime val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_12 = data;
        int val_2 = System.Int32.Parse(s:  data);
        this.id = val_2;
        this.subject = val_2;
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_13 = data;
        decimal val_4 = System.Decimal.Parse(s:  -1600269904);
        val_14 = 0;
        val_14 = val_14 + 1;
        val_15 = data;
        val_16;
        decimal val_6 = System.Decimal.Parse(s:  -1600269920);
        val_17 = "lc";
        var val_14 = 0;
        val_14 = 0;
        val_14 = val_14 + 1;
        val_14 = (uint)val_14 & 65535;
        val_18 = data;
        if(data == 0)
        {
                return;
        }
        
        val_17 = "lc";
        val_14 = 0;
        val_14 = val_14 + 1;
        val_19 = data;
        System.DateTime val_9 = SLCDateTime.Parse(dateTime:  -1600269904);
        this.lastCompletedAt = val_11;
    }
    public ChallengeTask()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = null;
        val_2 = null;
        this.lastCompletedAt = System.DateTime.MinValue;
    }

}
