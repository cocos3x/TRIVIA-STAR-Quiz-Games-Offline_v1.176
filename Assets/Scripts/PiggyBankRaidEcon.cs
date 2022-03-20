using UnityEngine;
public class PiggyBankRaidEcon
{
    // Fields
    public const int MAX_BANK_LEVEL = 5;
    public int levelBuffer;
    public System.Collections.Generic.Dictionary<int, System.Decimal> bankMaxCoins;
    public System.Collections.Generic.Dictionary<int, System.Decimal> bankPriceTier;
    public System.Collections.Generic.List<float> raidOptionMultiplier;
    public decimal minimumRaidableCoins;
    public System.Collections.Generic.Dictionary<int, int> fakeOpponentBankLevelWeights;
    
    // Methods
    public PiggyBankRaidEcon()
    {
        var val_16;
        this.levelBuffer = 2;
        decimal val_2 = new System.Decimal(value:  600);
        Add(key:  1, value:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid});
        decimal val_3 = new System.Decimal(value:  1200);
        Add(key:  2, value:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid});
        decimal val_4 = new System.Decimal(value:  2400);
        Add(key:  3, value:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
        decimal val_5 = new System.Decimal(value:  4500);
        Add(key:  4, value:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid});
        decimal val_6 = new System.Decimal(value:  9000);
        Add(key:  5, value:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid});
        this.bankMaxCoins = new System.Collections.Generic.Dictionary<System.Int32, System.Decimal>();
        decimal val_8 = new System.Decimal(value:  199);
        Add(key:  1, value:  new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.mid});
        decimal val_9 = new System.Decimal(value:  399);
        Add(key:  2, value:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid});
        decimal val_10 = new System.Decimal(value:  799);
        Add(key:  3, value:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_10.lo, mid = val_10.mid});
        decimal val_11 = new System.Decimal(value:  1499);
        Add(key:  4, value:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_11.lo, mid = val_11.mid});
        decimal val_12 = new System.Decimal(value:  2999);
        Add(key:  5, value:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid});
        this.bankPriceTier = new System.Collections.Generic.Dictionary<System.Int32, System.Decimal>();
        System.Collections.Generic.List<System.Single> val_13 = new System.Collections.Generic.List<System.Single>();
        if(null != 0)
        {
                Add(item:  null);
            Add(item:  null);
        }
        else
        {
                Add(item:  null);
            Add(item:  null);
        }
        
        Add(item:  null);
        this.raidOptionMultiplier = null;
        decimal val_14 = new System.Decimal(value:  20);
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_15 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(null != 0)
        {
                val_16 = 1152921511111014784;
            Add(key:  1, value:  25);
            Add(key:  2, value:  25);
            Add(key:  3, value:  20);
            Add(key:  4, value:  15);
        }
        else
        {
                val_16 = 1152921511111014784;
            Add(key:  1, value:  25);
            Add(key:  2, value:  25);
            Add(key:  3, value:  20);
            Add(key:  4, value:  15);
        }
        
        Add(key:  5, value:  15);
        this.fakeOpponentBankLevelWeights = null;
    }
    public PiggyBankRaidEcon(System.Collections.Generic.Dictionary<string, object> eventDataDict)
    {
        int val_22;
        int val_23;
        int val_24;
        int val_25;
        int val_27;
        int val_28;
        int val_29;
        int val_30;
        object val_44;
        float val_45;
        string val_46;
        var val_47;
        int val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        System.Collections.Generic.List<System.Single> val_53;
        var val_54;
        val_44 = eventDataDict;
        this.levelBuffer = 2;
        val_45 = 1152921504685600768;
        decimal val_2 = new System.Decimal(value:  600);
        Add(key:  1, value:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid});
        decimal val_3 = new System.Decimal(value:  1200);
        Add(key:  2, value:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid});
        decimal val_4 = new System.Decimal(value:  2400);
        Add(key:  3, value:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
        decimal val_5 = new System.Decimal(value:  4500);
        Add(key:  4, value:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid});
        decimal val_6 = new System.Decimal(value:  9000);
        Add(key:  5, value:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid});
        this.bankMaxCoins = new System.Collections.Generic.Dictionary<System.Int32, System.Decimal>();
        decimal val_8 = new System.Decimal(value:  199);
        Add(key:  1, value:  new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.mid});
        decimal val_9 = new System.Decimal(value:  399);
        Add(key:  2, value:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid});
        decimal val_10 = new System.Decimal(value:  799);
        Add(key:  3, value:  new System.Decimal() {flags = val_10.flags, hi = val_10.hi, lo = val_10.lo, mid = val_10.mid});
        decimal val_11 = new System.Decimal(value:  1499);
        Add(key:  4, value:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_11.lo, mid = val_11.mid});
        decimal val_12 = new System.Decimal(value:  2999);
        val_46 = public System.Void System.Collections.Generic.Dictionary<System.Int32, System.Decimal>::Add(System.Int32 key, System.Decimal value);
        Add(key:  5, value:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid});
        this.bankPriceTier = new System.Collections.Generic.Dictionary<System.Int32, System.Decimal>();
        System.Collections.Generic.List<System.Single> val_13 = new System.Collections.Generic.List<System.Single>();
        if(null != 0)
        {
                Add(item:  null);
            Add(item:  null);
        }
        else
        {
                Add(item:  null);
            Add(item:  null);
        }
        
        Add(item:  null);
        this.raidOptionMultiplier = null;
        decimal val_14 = new System.Decimal(value:  20);
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_15 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        if(null != 0)
        {
                Add(key:  1, value:  25);
            Add(key:  2, value:  25);
            Add(key:  3, value:  20);
            Add(key:  4, value:  15);
        }
        else
        {
                Add(key:  1, value:  25);
            Add(key:  2, value:  25);
            Add(key:  3, value:  20);
            Add(key:  4, value:  15);
        }
        
        val_48 = public System.Void System.Collections.Generic.Dictionary<System.Int32, System.Int32>::Add(System.Int32 key, System.Int32 value);
        Add(key:  5, value:  15);
        this.fakeOpponentBankLevelWeights = null;
        val_44 = new System.Object();
        if(val_44 == 0)
        {
                return;
        }
        
        if((val_44.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_17 = val_44.Item[-1554533760];
        if(val_44 == 0)
        {
                return;
        }
        
        object val_18 = val_44.Item[-1554533760];
        if((0.ContainsKey(key:  -1630882544)) == false)
        {
            goto label_26;
        }
        
        string val_20 = 0.Item[-1630882544];
        int val_43 = 0;
        val_49 = 0;
        if(0 != 0)
        {
                val_49 = 0;
            if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_49 = 0;
        }
        
        label_42:
        if(val_43 >= 0)
        {
            goto label_26;
        }
        
        if(0 <= val_43)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_42 = 0;
        val_42 = val_42 + 0;
        if(((0 + 0) + 16) != 0)
        {
                val_48 = mem[(0 + 0) + 16 + 180];
            val_48 = (0 + 0) + 16 + 180;
        }
        
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_43 = val_43 + 1;
        if((System.Decimal.TryParse(s:  2621443, result: out  new System.Decimal() {flags = -1117547656, lo = val_48, mid = val_12.lo})) != false)
        {
                val_48 = val_23;
            EnumerableExtentions.SetOrAdd<System.Int32, System.Decimal>(dic:  this.bankPriceTier, key:  val_43, newValue:  new System.Decimal() {flags = val_22, hi = val_48, lo = val_24, mid = val_25});
        }
        
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((System.Decimal.TryParse(s:  1, result: out  new System.Decimal() {flags = -1117547672, lo = val_48, mid = val_24})) == false)
        {
            goto label_42;
        }
        
        EnumerableExtentions.SetOrAdd<System.Int32, System.Decimal>(dic:  this.bankMaxCoins, key:  val_43, newValue:  new System.Decimal() {flags = val_27, hi = val_28, lo = val_29, mid = val_30});
        goto label_42;
        label_26:
        val_50 = 1;
        val_44 = 0;
        val_51 = 1152921504687730688;
        val_46 = 1152921511057229328;
        if((val_44.ContainsKey(key:  -1117563936)) != false)
        {
                string val_32 = val_44.Item[-1117563936];
            bool val_33 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this.minimumRaidableCoins, lo = System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth, mid = val_29});
        }
        
        if((val_44.ContainsKey(key:  -1117563856)) == false)
        {
            goto label_51;
        }
        
        string val_35 = val_44.Item[-1117563856];
        val_52 = 0;
        if(val_44 != 0)
        {
                val_52 = 0;
            val_46 = 1152921511057229328;
            val_53 = 1152921504687730688;
            if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_44 = 0;
        }
        
            val_52 = val_44;
        }
        
        val_53 = new System.Collections.Generic.List<System.Single>();
        val_47 = 0;
        goto label_55;
        label_61:
        if(val_53 <= val_47)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_44 = 0;
        val_44 = val_44 + 0;
        val_46 = mem[(0 + 0) + 16];
        val_46 = (0 + 0) + 16;
        if((System.Single.TryParse(s:  val_46, result: out  float val_36 = -0.05556048f)) != false)
        {
                Add(item:  null);
        }
        
        val_47 = 1;
        label_55:
        if(val_47 < 0)
        {
            goto label_61;
        }
        
        val_44 = 0;
        val_50 = 1;
        this.raidOptionMultiplier = val_53;
        label_51:
        if((val_44.ContainsKey(key:  -1117563776)) == false)
        {
                return;
        }
        
        string val_39 = val_44.Item[-1117563776];
        val_44 = 0;
        val_54 = 0;
        if(val_44 != 0)
        {
                val_54 = 0;
            if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_44 = 0;
        }
        
            val_54 = val_44;
        }
        
        val_46 = 0;
        val_45 = 1152921511272982080;
        goto label_70;
        label_72:
        if(val_44 <= val_46)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_45 = 0;
        val_47 = 1;
        val_45 = val_45 + 0;
        val_46 = val_47;
        if((System.Int32.TryParse(s:  (0 + 0) + 16, result: out  int val_40 = -1117547680)) != false)
        {
                EnumerableExtentions.SetOrAdd<System.Int32, System.Int32>(dic:  this.fakeOpponentBankLevelWeights, key:  1, newValue:  0);
            val_46 = val_47;
        }
        
        label_70:
        if(val_46 < 0)
        {
            goto label_72;
        }
    
    }

}
