using UnityEngine;
public class WGStoreItem_spins : WGStoreItem
{
    // Methods
    public override void UpdateUI(PurchaseModel pack, int packIndex, int totalPackItems, IStoreUI storeUI)
    {
        int val_9;
        int val_10;
        int val_11;
        int val_12;
        int val_19;
        int val_21;
        int val_22;
        int val_23;
        int val_26;
        int val_29;
        int val_30;
        int val_31;
        int val_32;
        float val_65;
        float val_66;
        var val_67;
        bool val_68;
        var val_69;
        float val_70;
        var val_71;
        var val_72;
        PurchaseModel val_73;
        var val_74;
        var val_75;
        int val_76;
        mem[1152921512544269368] = pack;
        mem[1152921512544269372] = storeUI;
        if(storeUI != 0)
        {
                storeUI.sprite = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  storeUI)) != false)
        {
                decimal val_3 = Spins;
            GameEcon val_4 = App.getGameEcon;
            string val_5 = ToString(format:  null);
        }
        
        if(pack != 0)
        {
                decimal val_6 = Spins;
            val_65 = 99.99f;
            val_66 = pack.sale_price;
            if(pack > 0)
        {
                val_67 = 2;
        }
        
        }
        else
        {
                val_66 = 92;
            decimal val_7 = Spins;
            val_65 = 99.99f;
            if(pack > 0)
        {
                val_67 = 2;
        }
        
        }
        
        decimal val_8 = System.Decimal.op_Explicit(value:  val_65);
        decimal val_14 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -652524440}, d2:  new System.Decimal() {flags = val_10, hi = val_9, lo = val_11, mid = val_12});
        Player val_15 = App.Player;
        int val_16 = RestaurantRivals.RESGameEconHelper.Get199SpinPackAmount(level:  0);
        decimal val_17 = System.Decimal.op_Implicit(value:  -652524440);
        decimal val_18 = new System.Decimal(lo:  199, mid:  0, hi:  0, isNegative:  false, scale:  2);
        decimal val_20 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -652524472}, d2:  new System.Decimal() {flags = val_19, hi = val_18.flags, lo = val_18.hi, mid = val_18.lo});
        decimal val_25 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -652524488}, d2:  new System.Decimal() {flags = val_19, hi = val_21, lo = val_22, mid = val_23});
        decimal val_27 = System.Decimal.Round(d:  new System.Decimal() {flags = -652524504}, decimals:  val_26);
        decimal val_28 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -652524520}, d2:  new System.Decimal() {hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_18, mid = System.Decimal.Powers10.__il2cppRuntimeField_1C});
        val_70 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  System.Decimal.Powers10.__il2cppRuntimeField_1C)) != false)
        {
                UnityEngine.GameObject val_34 = System.Decimal.Powers10.__il2cppRuntimeField_1C.gameObject;
            val_71 = null;
            val_71 = null;
            val_68 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_30, hi = val_29, lo = val_31, mid = val_32}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
            val_69 = 0;
            System.Decimal.Powers10.__il2cppRuntimeField_1C.SetActive(value:  val_68);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  System.Decimal.Powers10.__il2cppRuntimeField_1C)) != false)
        {
                UnityEngine.GameObject val_37 = System.Decimal.Powers10.__il2cppRuntimeField_1C.gameObject;
            val_72 = null;
            val_72 = null;
            System.Decimal.Powers10.__il2cppRuntimeField_1C.SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_30, hi = val_29, lo = val_31, mid = val_32}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
            GameBehavior val_39 = App.getBehavior;
            val_70 = 1152921504765685760;
        }
        
        val_73 = pack;
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                0.SetActive(value:  false);
        }
        
        if((pack + 12.Contains(value:  -1801681824)) == false)
        {
            goto label_81;
        }
        
        GameEcon val_42 = App.getGameEcon;
        if((0.Equals(obj:  val_65)) == false)
        {
            goto label_49;
        }
        
        Player val_44 = App.Player;
        if(0.RemovedAds == false)
        {
            goto label_53;
        }
        
        label_49:
        UnityEngine.GameObject val_46 = this.gameObject;
        val_74 = 0;
        goto label_55;
        label_53:
        if(0 != 0)
        {
                mem[1179404043] + 12.left = 0;
            val_68 = mem[mem[1179404043] + 12 + 12];
            val_68 = mem[1179404043] + 12 + 12;
            val_68.bottom = 0;
            0.spacing = val_65;
        }
        
        if(0 != 0)
        {
                UnityEngine.GameObject val_49 = 0.gameObject;
            0.SetActive(value:  true);
            0.fontSize = 26;
            string val_50 = Localization.Localize(key:  -652536416, defaultValue:  -652536528, useSingularKey:  false);
            val_68 = "no_ads_forever_upper";
        }
        
        if(0 != 0)
        {
                0.SetActive(value:  true);
        }
        
        if(0 != 0)
        {
                0.SetActive(value:  true);
        }
        
        if(0 != 0)
        {
                0.sprite = -652536416;
        }
        
        label_81:
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                string val_55 = val_73.LocalPrice;
            val_68 = val_73;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                if(5 == 0)
        {
                if(totalPackItems >= 1)
        {
                int val_63 = packIndex;
            int val_64 = pack + 12;
            val_63 = val_63 - totalPackItems;
            val_64 = val_63 + val_64;
            val_75 = val_73 + ((UnityEngine.Mathf.Max(a:  val_64, b:  0)) << 2);
        }
        else
        {
                val_76 = packIndex;
            if((pack + 12) <= val_76)
        {
                val_76 = packIndex;
        }
        
            val_75 = val_73 + (val_76 << 2);
        }
        
            val_68 = mem[(pack + (packIndex) << 2) + 16];
            val_68 = (pack + (packIndex) << 2) + 16;
            5.sprite = val_68;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  5)) != false)
        {
                AppConfigs val_60 = App.Configuration;
            val_68 = 0;
            if(5 == 0)
        {
                0 = 1;
        }
        
            5.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  5)) == false)
        {
                return;
        }
        
        float val_62 = PackagesManager.GetBestValuePackPrice(unfiltered:  0);
        if(val_66 == 0)
        {
                val_74 = 1;
        }
        
        label_55:
        val_66.SetActive(value:  true);
    }
    public WGStoreItem_spins()
    {
        mem[1152921512544389512] = 1;
        val_1 = new MyButton();
    }

}
