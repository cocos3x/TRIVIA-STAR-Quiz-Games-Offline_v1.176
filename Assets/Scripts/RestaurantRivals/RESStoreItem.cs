using UnityEngine;

namespace RestaurantRivals
{
    public class RESStoreItem : WGStoreItem
    {
        // Methods
        public override void UpdateUI(PurchaseModel pack, int packIndex, int totalPackItems, IStoreUI storeUI)
        {
            int val_8;
            int val_30;
            int val_32;
            int val_33;
            int val_34;
            int val_37;
            int val_40;
            int val_41;
            int val_42;
            int val_43;
            PurchaseModel val_63;
            var val_66;
            float val_67;
            var val_68;
            var val_69;
            bool val_70;
            var val_71;
            var val_72;
            int val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            val_63 = pack;
            mem[1152921513865493864] = val_63;
            mem[1152921513865493868] = storeUI;
            if(storeUI != 0)
            {
                    storeUI.sprite = 0;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  storeUI)) != false)
            {
                    decimal val_3 = Credits;
                decimal val_4 = new System.Decimal(value:  1000000000);
                if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid})) != false)
            {
                    decimal val_6 = Credits;
                decimal val_7;
                val_7 = new System.Decimal(value:  1000000000);
                decimal val_9 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 668700064}, d2:  new System.Decimal() {flags = val_8, hi = val_7.flags, lo = val_7.hi, mid = val_7.lo});
                string val_10 = ToString(format:  668688096);
                val_66 = "B";
            }
            else
            {
                    decimal val_11 = Credits;
                decimal val_12 = new System.Decimal(value:  1000000);
                if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_12.flags, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid})) != false)
            {
                    decimal val_14 = Credits;
                decimal val_15;
                val_15 = new System.Decimal(value:  1000000);
                decimal val_16 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 668700064}, d2:  new System.Decimal() {flags = val_8, hi = val_15.flags, lo = val_15.hi, mid = val_15.lo});
                string val_17 = ToString(format:  668688096);
                val_66 = "M";
            }
            else
            {
                    decimal val_18 = Credits;
                decimal val_19 = new System.Decimal(value:  1000);
                decimal val_20 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 668700064}, d2:  new System.Decimal() {flags = val_8, hi = val_19.flags, lo = val_19.hi, mid = val_19.lo});
                string val_21 = ToString(format:  668688096);
                val_66 = "K";
            }
            
            }
            
                string val_22 = 668700112 + -233706608(-233706608);
                val_63 = val_63;
            }
            
            if(val_63 != 0)
            {
                    decimal val_23 = Credits;
                val_67 = 99.99f;
                val_68 = val_63 + 92;
                if(val_63 > 0)
            {
                    val_69 = 2;
            }
            
            }
            else
            {
                    val_68 = 92;
                decimal val_24 = Credits;
                val_67 = 99.99f;
                if(val_63 > 0)
            {
                    val_69 = 2;
            }
            
            }
            
            decimal val_25 = System.Decimal.op_Explicit(value:  val_67);
            decimal val_26 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 668700064}, d2:  new System.Decimal() {flags = val_8, hi = val_19.flags, lo = val_19.hi, mid = val_19.lo});
            Player val_27 = App.Player;
            decimal val_28 = RestaurantRivals.RESGameEconHelper.Get199CoinPackAmount(level:  668700064);
            decimal val_29 = new System.Decimal(lo:  199, mid:  0, hi:  0, isNegative:  false, scale:  2);
            decimal val_31 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 668700032}, d2:  new System.Decimal() {flags = val_30, hi = val_29.flags, lo = val_29.hi, mid = val_29.lo});
            decimal val_36 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 668700016}, d2:  new System.Decimal() {flags = val_30, hi = val_32, lo = val_33, mid = val_34});
            decimal val_38 = System.Decimal.Round(d:  new System.Decimal() {flags = 668700000}, decimals:  val_37);
            decimal val_39 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 668699984}, d2:  new System.Decimal() {hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_18, mid = System.Decimal.Powers10.__il2cppRuntimeField_1C});
            val_72 = 1152921504765685760;
            val_73 = val_42;
            if((UnityEngine.Object.op_Implicit(exists:  System.Decimal.Powers10.__il2cppRuntimeField_1C)) != false)
            {
                    UnityEngine.GameObject val_45 = System.Decimal.Powers10.__il2cppRuntimeField_1C.gameObject;
                val_74 = null;
                val_74 = null;
                val_70 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_41, hi = val_73, lo = val_40, mid = val_43}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
                val_71 = 0;
                System.Decimal.Powers10.__il2cppRuntimeField_1C.SetActive(value:  val_70);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  System.Decimal.Powers10.__il2cppRuntimeField_1C)) != false)
            {
                    UnityEngine.GameObject val_48 = System.Decimal.Powers10.__il2cppRuntimeField_1C.gameObject;
                val_75 = null;
                val_75 = null;
                System.Decimal.Powers10.__il2cppRuntimeField_1C.SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_41, hi = val_73, lo = val_40, mid = val_43}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
                GameBehavior val_50 = App.getBehavior;
                val_72 = 1152921504765685760;
            }
            
            val_76 = val_68;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    string val_52 = val_63.LocalPrice;
                val_70 = val_63;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    if(5 == 0)
            {
                    if(totalPackItems >= 1)
            {
                    int val_62 = packIndex;
                int val_63 = 33446072;
                val_62 = val_62 - totalPackItems;
                val_63 = val_62 + val_63;
                val_77 = val_76 + ((UnityEngine.Mathf.Max(a:  val_63, b:  0)) << 2);
            }
            else
            {
                    val_77 = val_76 + (packIndex << 2);
            }
            
                val_70 = mem[(val_76 + (packIndex) << 2) + 16];
                val_70 = (val_76 + (packIndex) << 2) + 16;
                5.sprite = val_70;
                val_76 = val_68;
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  5)) != false)
            {
                    AppConfigs val_57 = App.Configuration;
                val_70 = 0;
                if(5 == 0)
            {
                    0 = 1;
            }
            
                5.SetActive(value:  true);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  5)) != false)
            {
                    float val_59 = PackagesManager.GetBestValuePackPrice(unfiltered:  0);
                if(5 == 0)
            {
                    0 = 1;
            }
            
                5.SetActive(value:  true);
            }
            
            if(5 == 0)
            {
                    return;
            }
            
            if(5 == 0)
            {
                    return;
            }
            
            if(val_63 != 0)
            {
                    if(val_63 != 0)
            {
                    return;
            }
            
            }
            
            val_70.sprite = 5;
            sprite = 5;
        }
        public RESStoreItem()
        {
        
        }
    
    }

}
