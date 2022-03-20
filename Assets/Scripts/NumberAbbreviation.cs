using UnityEngine;
public static class NumberAbbreviation
{
    // Methods
    public static string GetNumber(decimal num)
    {
        int val_24;
        int val_25;
        var val_26;
        int val_29;
        int val_30;
        var val_33;
        var val_37;
        int val_38;
        int val_39;
        var val_42;
        val_24 = num.mid;
        val_25 = num.lo;
        val_26 = 0;
        decimal val_1 = new System.Decimal(value:  1000);
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = val_25, mid = val_24}, d2:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid})) != false)
        {
                string val_3 = num.flags.ToString();
            return;
        }
        
        decimal val_4 = new System.Decimal(value:  1000);
        val_33 = 15;
        val_33 = 1000000;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = num.flags, hi = val_29, lo = val_30, mid = num.mid}, d2:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid})) == false)
        {
            goto label_10;
        }
        
        decimal val_6;
        val_30 = num.mid;
        val_6 = new System.Decimal(value:  1000000);
        val_33 = 15;
        val_33 = 1000000;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = num.flags, hi = val_29, lo = num.lo, mid = val_30}, d2:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid})) == false)
        {
            goto label_10;
        }
        
        decimal val_8;
        val_26 = 0;
        val_8 = new System.Decimal(value:  1000);
        decimal val_9 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -233694552, hi = num.flags, lo = num.hi, mid = val_24}, d2:  new System.Decimal() {flags = num.mid, hi = val_8.flags, lo = val_8.hi, mid = val_8.lo});
        string val_10 = ToString(format:  -233706688);
        val_37 = "K";
        goto label_22;
        label_10:
        decimal val_11 = new System.Decimal(value:  1000000);
        val_42 = 15258;
        val_42 = 1000000000;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = num.flags, hi = val_38, lo = val_39, mid = num.mid}, d2:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_11.lo, mid = val_11.mid})) == false)
        {
            goto label_19;
        }
        
        decimal val_13 = new System.Decimal(value:  1000000000);
        val_42 = 15258;
        val_42 = 1000000000;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = num.flags, hi = val_38, lo = val_39, mid = num.mid}, d2:  new System.Decimal() {flags = val_13.flags, hi = val_13.hi, lo = val_13.lo, mid = val_13.mid})) == false)
        {
            goto label_19;
        }
        
        decimal val_15;
        val_26 = 0;
        val_15 = new System.Decimal(value:  1000000);
        decimal val_16 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -233694552, hi = num.flags, lo = num.hi, mid = val_25}, d2:  new System.Decimal() {flags = num.mid, hi = val_15.flags, lo = val_15.hi, mid = val_15.lo});
        string val_17 = ToString(format:  -233706688);
        val_37 = "M";
        goto label_22;
        label_19:
        decimal val_18;
        val_26 = val_42;
        val_18 = new System.Decimal(value:  1000000000);
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = num.flags, hi = num.hi, lo = val_24, mid = val_25}, d2:  new System.Decimal() {flags = val_18.flags, hi = val_18.hi, lo = val_18.lo, mid = val_18.mid})) == false)
        {
                return;
        }
        
        decimal val_20 = new System.Decimal(value:  1000000000);
        decimal val_21 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -233694552, hi = num.flags, lo = num.hi, mid = val_24}, d2:  new System.Decimal() {flags = num.mid, hi = val_20.flags, lo = val_20.hi, mid = val_20.lo});
        string val_22 = ToString(format:  -233706688);
        val_37 = "B";
        label_22:
        string val_23 = -233694520(-233694520) + -1930530848(-1930530848);
    }

}
