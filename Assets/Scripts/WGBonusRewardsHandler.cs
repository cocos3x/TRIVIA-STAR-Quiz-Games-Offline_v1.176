using UnityEngine;
public class WGBonusRewardsHandler : DefaultHandler<WGBonusRewardsHandler>
{
    // Fields
    private decimal lastPointsCalculated;
    private BonusRewardsContainer myContainer;
    
    // Properties
    private int currentRewardPoints { get; set; }
    
    // Methods
    private int get_currentRewardPoints()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return 4;
        }
        
        return 4;
    }
    private void set_currentRewardPoints(int value)
    {
        Player val_1 = App.Player;
        mem[80] = value;
    }
    protected override void AwakeLogic()
    {
        var val_5;
        System.Delegate val_6;
        this.AwakeLogic();
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        PostProcessPurchaseDelegate val_2 = new PostProcessPurchaseDelegate(object:  -364662224, method:  new IntPtr(3930280048));
        val_6 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        System.Delegate val_3 = System.Delegate.Combine(a:  val_6, b:  291586048);
        if(val_6 != null)
        {
                if(null == null)
        {
            goto label_9;
        }
        
        }
        
        val_6 = 0;
        label_9:
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_6;
        BonusRewardsContainer val_4 = this.GetCurrentRewards();
    }
    private void OnDestroy()
    {
        var val_3;
        System.Delegate val_4;
        val_3 = null;
        val_3 = null;
        PostProcessPurchaseDelegate val_1 = new PostProcessPurchaseDelegate(object:  -364550224, method:  new IntPtr(3930280048));
        val_4 = PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS;
        System.Delegate val_2 = System.Delegate.Remove(source:  val_4, value:  291586048);
        if(val_4 != null)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        label_4:
        PurchasesHandler.ON_RESTORE_TRANSACTIONS_SUCCESS = val_4;
    }
    private void ProcessPurchase(ref PurchaseModel purchaseInfo)
    {
        int val_10;
        int val_11;
        int val_12;
        int val_13;
        WGBonusRewardsHandler val_31;
        var val_32;
        int val_34;
        var val_35;
        int val_37;
        var val_38;
        int val_40;
        var val_41;
        int val_42;
        int val_43;
        int val_44;
        var val_46;
        int val_47;
        var val_48;
        var val_49;
        var val_50;
        val_31 = this;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        int val_2 = this.GetPointsForPurchase(pack:  purchaseInfo);
        BonusRewardsContainer val_3 = this.GetCurrentRewards();
        decimal val_4 = Credits;
        val_32 = null;
        val_32 = null;
        val_34 = 0;
        val_35 = 1152921504617017344;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                decimal val_6 = Credits;
            float val_7 = System.Decimal.op_Explicit(value:  new System.Decimal());
            float val_31 = (float)R0;
            val_31 = val_31 * 0.01f;
            val_31 = R0 * val_31;
            int val_8 = UnityEngine.Mathf.CeilToInt(f:  val_31);
            decimal val_9 = System.Decimal.op_Implicit(value:  -364446056);
            val_34 = val_10;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_12, hi = val_10, lo = val_11, mid = val_13}, d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
        {
                Player val_15 = App.Player;
            val_35 = 1152921504617017344;
            0.AddCredits(amount:  new System.Decimal() {flags = val_12, hi = val_34, lo = val_11, mid = val_13}, source:  "BonusRewardCredits", subSource:  0, externalParams:  0, doTrack:  false);
        }
        else
        {
                val_35 = 1152921504617017344;
        }
        
        }
        
        val_37 = 0;
        decimal val_16 = Gems;
        val_38 = null;
        val_41 = 1152921512832379584;
        val_42 = 0;
        val_43 = 0;
        val_44 = 0;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                decimal val_18 = Gems;
            float val_19 = System.Decimal.op_Explicit(value:  new System.Decimal());
            float val_32 = (float)mem[1152921512832347604];
            val_32 = val_32 * 0.01f;
            val_32 = R0 * val_32;
            int val_20 = UnityEngine.Mathf.CeilToInt(f:  val_32);
            decimal val_21 = System.Decimal.op_Implicit(value:  -364446056);
            val_37 = val_12;
            val_42 = val_10;
            val_43 = val_11;
            val_44 = val_13;
            val_40 = val_43;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_37, hi = val_42, lo = val_40, mid = val_44}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                Player val_23 = App.Player;
            val_41 = 1152921512832379584;
            val_40 = "BonusRewardGems";
            0.AddGems(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_37, hi = val_42, lo = val_43, mid = val_44}), source:  -364458096, subsource:  null);
        }
        else
        {
                val_41 = 1152921512832379584;
        }
        
        }
        
        val_46 = null;
        val_46 = null;
        val_47 = val_34;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_12, hi = val_47, lo = val_11, mid = val_13}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
            goto label_40;
        }
        
        val_48 = null;
        val_48 = null;
        val_47 = val_34;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_37, hi = val_42, lo = val_43, mid = val_44}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_43;
        }
        
        label_40:
        vipAddedCredits = val_12;
        mem2[0] = val_47;
        mem2[0] = val_11;
        mem2[0] = val_13;
        vipAddedGems = val_37;
        mem2[0] = val_42;
        mem2[0] = val_43;
        mem2[0] = val_44;
        label_43:
        val_31 = val_31;
        vipApplied = true;
        BonusRewardsContainer val_27 = this.GetCurrentRewards();
        vipLevel = mem[1152921512832347592];
        vipContribution = val_2;
        Player val_28 = App.Player;
        if(0 != 0)
        {
                val_49 = 0;
            val_50 = 4;
        }
        else
        {
                val_49 = 80;
            val_50 = 4;
        }
        
        mem[80] = val_50 + val_2;
        BonusRewardsContainer val_30 = this.GetCurrentRewards();
    }
    public BonusRewardsContainer GetCurrentRewards()
    {
        BonusRewardsContainer val_7;
        decimal val_11;
        var val_12;
        val_11 = this.lastPointsCalculated;
        Player val_1 = App.Player;
        decimal val_2 = System.Decimal.op_Implicit(value:  -364318784);
        bool val_3 = System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_11, hi = R7, lo = SL, mid = R6}, d2:  new System.Decimal());
        if(val_3 == true)
        {
                val_3 = this.myContainer;
        }
        
        if(val_3 != 0)
        {
                return;
        }
        
        val_11 = 1152921504892043264;
        GameEcon val_4 = App.getGameEcon;
        var val_11 = this.currentRewardPoints;
        List.Enumerator<T> val_6 = GetEnumerator();
        val_12 = 1152921512832444720;
        goto label_11;
        label_14:
        if(val_11 < (val_7 + 12))
        {
            goto label_13;
        }
        
        this.myContainer = val_7;
        val_11 = val_11 - (val_7 + 12);
        label_11:
        if(MoveNext() == true)
        {
            goto label_14;
        }
        
        label_13:
        Dispose();
        Player val_9 = App.Player;
        decimal val_10 = System.Decimal.op_Implicit(value:  -364318784);
    }
    public BonusRewardsContainer GetNextRewards()
    {
        var val_5;
        var val_6;
        BonusRewardsContainer val_1 = this.GetCurrentRewards();
        GameEcon val_2 = App.getGameEcon;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_8:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        val_6 = val_5;
        if((val_5 + 8) <= R6)
        {
            goto label_8;
        }
        
        goto label_9;
        label_6:
        val_6 = 0;
        label_9:
        Dispose();
    }
    public int GetProgressThroughCurrentTier()
    {
        var val_6;
        GameEcon val_1 = App.getGameEcon;
        val_6 = this.currentRewardPoints;
        List.Enumerator<T> val_3 = GetEnumerator();
        goto label_5;
        label_8:
        if(val_6 < (val_4 + 12))
        {
            goto label_7;
        }
        
        val_6 = val_6 - (val_4 + 12);
        label_5:
        if(MoveNext() == true)
        {
            goto label_8;
        }
        
        label_7:
        Dispose();
        return (int)val_6;
    }
    public bool MaxPointsGained()
    {
        var val_5;
        System.Func<BonusRewardsContainer, System.Int32> val_7;
        GameEcon val_1 = App.getGameEcon;
        val_5 = null;
        val_5 = null;
        val_7 = WGBonusRewardsHandler.<>c.<>9__11_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WGBonusRewardsHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3930980784));
            WGBonusRewardsHandler.<>c.<>9__11_0 = val_7;
        }
        
        object val_3 = MoreLinq.MaxBy<System.Object, System.Int32>(source:  0, selector:  7720960);
        BonusRewardsContainer val_4 = this.GetCurrentRewards();
        if(0 != 0)
        {
                return false;
        }
        
        return false;
    }
    public int GetPointsForPurchase(PurchaseModel pack)
    {
        GameEcon val_2 = App.getGameEcon;
        var val_3 = 0;
        val_3 = val_3 * (UnityEngine.Mathf.CeilToInt(f:  null));
        return (int)val_3;
    }
    public decimal GetBonusCoins(PurchaseModel pack)
    {
        decimal val_1 = Credits;
        float val_2 = System.Decimal.op_Explicit(value:  new System.Decimal());
        BonusRewardsContainer val_3 = pack.GetCurrentRewards();
        float val_6 = (float)pack;
        val_6 = val_6 * 0.01f;
        val_6 = R0 * val_6;
        int val_4 = UnityEngine.Mathf.CeilToInt(f:  val_6);
        decimal val_5 = System.Decimal.op_Implicit(value:  -363723152);
        return new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid};
    }
    public decimal GetBonusGems(PurchaseModel pack)
    {
        decimal val_1 = Gems;
        float val_2 = System.Decimal.op_Explicit(value:  new System.Decimal());
        BonusRewardsContainer val_3 = pack.GetCurrentRewards();
        float val_6 = (float)pack.vipAddedCredits;
        val_6 = val_6 * 0.01f;
        val_6 = R0 * val_6;
        int val_4 = UnityEngine.Mathf.CeilToInt(f:  val_6);
        decimal val_5 = System.Decimal.op_Implicit(value:  -363602960);
        return new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid};
    }
    public decimal GetBonusStars(int starsBeingRewarded)
    {
        BonusRewardsContainer val_1 = starsBeingRewarded.GetCurrentRewards();
        float val_4 = (float)starsBeingRewarded + 16;
        val_4 = val_4 * 0.01f;
        val_4 = val_4 * (float)R2;
        int val_2 = UnityEngine.Mathf.CeilToInt(f:  val_4);
        decimal val_3 = System.Decimal.op_Implicit(value:  -363486864);
        return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
    }
    public WGBonusRewardsHandler()
    {
        null = null;
    }

}
