using UnityEngine;
public class WGStoreItem_gems : WGStoreItem
{
    // Methods
    public override void UpdateUI(PurchaseModel pack, int packIndex, int totalPackItems, IStoreUI storeUI)
    {
        int val_10;
        int val_27;
        int val_29;
        int val_44;
        int val_45;
        int val_50;
        int val_52;
        int val_53;
        int val_54;
        int val_57;
        int val_59;
        int val_61;
        UnityEngine.Sprite val_78;
        float val_79;
        var val_80;
        PurchaseModel val_81;
        var val_82;
        var val_83;
        var val_84;
        var val_85;
        val_78 = 35633533;
        mem[1152921513266175176] = pack;
        mem[1152921513266175180] = storeUI;
        val_80 = 1152921504765685760;
        if(storeUI != 0)
        {
                storeUI.sprite = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  storeUI)) != false)
        {
                storeUI.alignment = 4;
            storeUI.spacing = null;
            decimal val_3 = Gems;
            GameEcon val_4 = App.getGameEcon;
            string val_5 = ToString(format:  null);
            val_78;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  storeUI)) != false)
        {
                string val_7 = pack.LocalPrice;
            val_78 = pack;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  storeUI)) != false)
        {
                if(storeUI == 0)
        {
                if(totalPackItems >= 1)
        {
                int val_77 = packIndex;
            int val_78 = val_10;
            val_77 = val_77 - totalPackItems;
            val_78 = val_77 + val_78;
            var val_12 = 1152921513266162992 + ((UnityEngine.Mathf.Max(a:  val_78, b:  0)) << 2);
        }
        else
        {
                var val_13 = 1152921513266162992 + (packIndex << 2);
        }
        
            val_78 = mem[(1152921513266162992 + (packIndex) << 2) + 16];
            val_78 = (1152921513266162992 + (packIndex) << 2) + 16;
            storeUI.sprite = val_78;
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  storeUI)) != false)
        {
                UnityEngine.GameObject val_15 = storeUI.gameObject;
            storeUI.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  storeUI)) != false)
        {
                GameBehavior val_17 = App.getBehavior;
            if(0 != 0)
        {
                val_78 = 1152921504897900544;
            val_79 = 1152921511942590224;
            WGBonusRewardsHandler val_18 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            if((-1254191344) != 0)
        {
                alignment = 1;
            spacing = null;
            UnityEngine.GameObject val_20 = gameObject;
            SetActive(value:  true);
            WGBonusRewardsHandler val_21 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            GameEcon val_23 = App.getGameEcon;
            string val_24 = GetPointsForPurchase(pack:  pack).ToString(format:  null);
            WGBonusRewardsHandler val_25 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            decimal val_26 = GetBonusGems(pack:  -1254191344);
            decimal val_28 = Gems;
            decimal val_30 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 69381368}, d2:  new System.Decimal() {flags = val_29, hi = val_27});
            GameEcon val_31 = App.getGameEcon;
            string val_32 = ToString(format:  null);
            val_78;
            val_80 = 1152921504765685760;
        }
        
        }
        
        }
        
        val_81 = pack;
        if((pack + 12.Contains(value:  -1801681824)) == false)
        {
            goto label_76;
        }
        
        val_78 = 1152921504892043264;
        GameEcon val_34 = App.getGameEcon;
        val_82 = 0;
        if((pack + 92.Equals(obj:  null)) == false)
        {
            goto label_85;
        }
        
        GameBehavior val_36 = App.getBehavior;
        val_82 = 0;
        if(val_82 != 0)
        {
            goto label_85;
        }
        
        Player val_37 = App.Player;
        val_82 = 0;
        if(val_82.RemovedAds == false)
        {
            goto label_89;
        }
        
        label_85:
        UnityEngine.GameObject val_39 = this.gameObject;
        val_83 = 0;
        goto label_91;
        label_76:
        val_79 = 1152921504892043264;
        UnityEngine.Object val_79 = 25562915;
        val_79 = 10062872 + val_79;
        if(val_79 == 0)
        {
                mem2[0] = 1;
        }
        
        val_84 = null;
        val_84 = null;
        if(App.game == 17)
        {
            goto label_97;
        }
        
        if(val_79 == 0)
        {
                mem2[0] = 1;
        }
        
        val_85 = null;
        val_85 = null;
        if(App.game != 19)
        {
            goto label_152;
        }
        
        label_97:
        if((UnityEngine.Object.op_Implicit(exists:  val_79)) == false)
        {
            goto label_152;
        }
        
        GameBehavior val_41 = App.getBehavior;
        if(0 != 0)
        {
            goto label_152;
        }
        
        decimal val_42 = Gems;
        if(0 > 0)
        {
                1 = 2;
        }
        
        decimal val_43 = System.Decimal.op_Explicit(value:  99.99f);
        decimal val_46 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 69381368}, d2:  new System.Decimal() {flags = val_44, hi = val_45});
        GameEcon val_47 = App.getGameEcon;
        decimal val_48 = base099GemPackSize;
        decimal val_49 = new System.Decimal(lo:  99, mid:  0, hi:  0, isNegative:  false, scale:  2);
        decimal val_51 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 69381336}, d2:  new System.Decimal() {flags = val_50, hi = val_49.flags, lo = val_49.hi, mid = val_49.lo});
        decimal val_56 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 69381320}, d2:  new System.Decimal() {flags = val_50, hi = val_52, lo = val_53, mid = val_54});
        decimal val_58 = System.Decimal.Round(d:  new System.Decimal() {flags = 69381304}, decimals:  val_57);
        decimal val_60 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 69381288}, d2:  new System.Decimal() {flags = val_59, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_18, mid = System.Decimal.Powers10.__il2cppRuntimeField_1C});
        val_79 = val_61;
        UnityEngine.GameObject val_62 = System.Decimal.Powers10.__il2cppRuntimeField_18.gameObject;
        System.Decimal.Powers10.__il2cppRuntimeField_18.SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_79, hi = R4, lo = R5, mid = R8}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
        GameBehavior val_64 = App.getBehavior;
        goto label_152;
        label_89:
        if(0 != 0)
        {
                pack + 12.left = 0;
            val_78 = mem[pack + 12];
            val_78 = pack + 12;
            val_78.bottom = 0;
            val_82.spacing = null;
        }
        
        if(0 != 0)
        {
                UnityEngine.GameObject val_67 = val_82.gameObject;
            val_82.SetActive(value:  true);
            val_82.fontSize = 26;
            string val_68 = Localization.Localize(key:  -652536416, defaultValue:  -652536528, useSingularKey:  false);
            val_78 = "no_ads_forever_upper";
        }
        
        if(0 != 0)
        {
                val_82.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                val_82.SetActive(value:  false);
        }
        
        if(0 != 0)
        {
                val_82.SetActive(value:  true);
        }
        
        if(0 != 0)
        {
                val_82.sprite = -652536416;
        }
        
        label_152:
        val_81 = pack;
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                AppConfigs val_74 = App.Configuration;
            val_78 = 0;
            if(val_82 == 0)
        {
                0 = 1;
        }
        
            val_82.SetActive(value:  true);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
        {
                return;
        }
        
        float val_76 = PackagesManager.GetBestValuePackPrice(unfiltered:  0);
        if(1152921504765685760 == 0)
        {
                val_83 = 1;
        }
        
        label_91:
        SetActive(value:  true);
    }
    public WGStoreItem_gems()
    {
        mem[1152921513266295320] = 1;
        val_1 = new MyButton();
    }

}
