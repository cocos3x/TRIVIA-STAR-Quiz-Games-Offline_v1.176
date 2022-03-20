using UnityEngine;
private sealed class WFOMysteryChestDisplay.<>c__DisplayClass89_1
{
    // Fields
    public WordForest.WFOWordChestItemIcon itemIcon;
    public WordForest.WFORewardData rewardData;
    public WordForest.WFOMysteryChestDisplay.<>c__DisplayClass89_0 CS$<>8__locals1;
    
    // Methods
    public WFOMysteryChestDisplay.<>c__DisplayClass89_1()
    {
    
    }
    internal void <CreateMiniSeqSegmentShowItemOuttro>b__1()
    {
        var val_14;
        WFOMysteryChestDisplay.<>c__DisplayClass89_0 val_15;
        WFOMysteryChestDisplay.<>c__DisplayClass89_0 val_16;
        WordForest.WFOMysteryChestDisplay val_17;
        var val_19;
        WFOMysteryChestDisplay.<>c__DisplayClass89_0 val_20;
        WordForest.WFOMysteryChestDisplay val_21;
        WFOMysteryChestDisplay.<>c__DisplayClass89_0 val_22;
        int val_23;
        int val_24;
        int val_25;
        WFOMysteryChestDisplay.<>c__DisplayClass89_0 val_26;
        UnityEngine.GameObject val_1 = this.itemIcon.gameObject;
        UnityEngine.Object.Destroy(obj:  this.itemIcon);
        if(this.itemIcon > 6)
        {
            goto label_5;
        }
        
        val_14 = 98;
        if((val_14 & (1 << this.itemIcon)) != 0)
        {
            goto label_5;
        }
        
        val_15 = this.CS$<>8__locals1;
        val_16 = val_15;
        if(val_15 != 0)
        {
            goto label_6;
        }
        
        val_16 = this.CS$<>8__locals1;
        if(val_16 == 0)
        {
            goto label_47;
        }
        
        label_6:
        val_17 = this.CS$<>8__locals1.<>4__this;
        int val_2 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = SL, hi = R6, lo = R7, mid = val_15});
        val_2 = val_2 + (this.CS$<>8__locals1.<>4__this.statViewCurrentValueAcorns);
        this.CS$<>8__locals1.<>4__this.statViewCurrentValueAcorns = val_2;
        val_20 = this.CS$<>8__locals1;
        decimal val_3 = System.Decimal.op_Implicit(value:  327245232);
        WordForest.WFOGameAcornStatView val_4 = (this.CS$<>8__locals1.<>4__this.acornStatViewObj) + 36;
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        val_21 = this.CS$<>8__locals1.<>4__this;
        val_14 = "OnAcornLevelBalanceUpdated";
        0.PostNotification(aSender:  val_21, aName:  282309120);
        label_5:
        if(0 != 2)
        {
            goto label_21;
        }
        
        val_15 = this.CS$<>8__locals1;
        val_22 = val_15;
        if(val_15 != 0)
        {
            goto label_22;
        }
        
        val_22 = this.CS$<>8__locals1;
        if(val_22 == 0)
        {
            goto label_47;
        }
        
        label_22:
        val_25 = mem[this.CS$<>8__locals1.<>4__this.statViewCurrentValueCoins + (8)];
        val_24 = mem[this.CS$<>8__locals1.<>4__this.statViewCurrentValueCoins + (4)];
        val_23 = mem[this.CS$<>8__locals1.<>4__this.statViewCurrentValueCoins + (0)];
        decimal val_6 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 327245232, hi = val_23, lo = val_24, mid = val_25}, d2:  new System.Decimal() {flags = mem[this.CS$<>8__locals1.<>4__this.statViewCurrentValueCoins + (12)]});
        WordForest.WFOMysteryChestDisplay val_7 = (this.CS$<>8__locals1.<>4__this) + 260;
        CoinCurrencyStatView val_8 = (this.CS$<>8__locals1.<>4__this.coinStatViewAnimObj) + 36;
        mem2[0] = 1;
        NotificationCenter val_9 = NotificationCenter.DefaultCenter;
        val_21 = 0;
        val_20 = this.CS$<>8__locals1.<>4__this;
        val_19 = 0;
        System.Collections.Hashtable val_10 = CurrencyStatView.GetAnimHT(shouldAnimate:  true);
        val_21.PostNotification(aSender:  val_20, aName:  -2144143840, aData:  1);
        mem2[0] = 0;
        label_21:
        if(0 != 4)
        {
                return;
        }
        
        val_15 = this.CS$<>8__locals1;
        val_26 = val_15;
        if(val_15 != 0)
        {
            goto label_46;
        }
        
        val_26 = this.CS$<>8__locals1;
        if(val_26 == 0)
        {
            goto label_47;
        }
        
        label_46:
        val_17 = this.CS$<>8__locals1.<>4__this;
        int val_11 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_15, hi = mem[this.CS$<>8__locals1.<>4__this.statViewCurrentValueCoins + (12)], lo = val_20});
        val_11 = val_11 + (this.CS$<>8__locals1.<>4__this.statViewCurrentValueShields);
        this.CS$<>8__locals1.<>4__this.statViewCurrentValueShields = val_11;
        this.CS$<>8__locals1.<>4__this.shieldStatViewObj.artificalTargetBalance = this.CS$<>8__locals1.<>4__this.statViewCurrentValueShields;
        NotificationCenter val_12 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  this.CS$<>8__locals1.<>4__this, aName:  -812849888);
        return;
        label_47:
    }

}
