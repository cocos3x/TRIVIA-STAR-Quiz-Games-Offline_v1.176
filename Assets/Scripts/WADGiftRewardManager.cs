using UnityEngine;
public class WADGiftRewardManager : WGGiftRewardManager<WADGiftRewardManager>
{
    // Methods
    public System.Collections.Generic.List<GiftReward> MakeRewards(GiftRewardType rewardType, int rewardAmount)
    {
        GiftRewardType val_16;
        float val_17;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_18;
        var val_19;
        SnakesAndLaddersEventHandler val_20;
        var val_21;
        var val_22;
        var val_23;
        System.Predicate<ZooTile> val_25;
        var val_26;
        val_16 = rewardType;
        object val_1 = null;
        val_17 = val_1;
        val_1 = new System.Object();
        val_18 = null;
        val_18 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        GiftReward val_3 = new GiftReward();
        if(val_17 != 0)
        {
                val_19 = val_17;
            typeof(WADGiftRewardManager.<>c__DisplayClass0_0).__il2cppRuntimeField_8 = val_3;
        }
        else
        {
                val_19 = 8;
            mem[8] = val_3;
        }
        
        typeof(GiftReward).__il2cppRuntimeField_8 = val_16;
        if(val_16 > 5)
        {
                return;
        }
        
        var val_4 = 7670828 + (7670828 + (rewardType) << 2);
        if(val_16 == 5)
        {
                7670828 = 7670828 & 728208;
            7670828 = 7670828 & (val_18 << 7670828);
            7670828 = 7670828 & (val_18 << 7670828);
            7670828 = 7670828 & (7670828 << 1);
            7670828 = 7670828 & (((int)IP) >> val_19);
            7670828 = 7670828 & 728208;
        }
        
        GameBehavior val_5 = App.getBehavior;
        val_20 = 0;
        goto label_9;
        label_44:
        GameBehavior val_6 = App.getBehavior;
        if(0 == 0)
        {
            goto label_15;
        }
        
        GiftReward val_7 = null;
        val_21 = val_7;
        val_7 = new GiftReward();
        if(val_17 != 0)
        {
                mem[8] = val_21;
        }
        else
        {
                mem[8] = val_21;
            val_21 = mem[8];
        }
        
        typeof(GiftReward).__il2cppRuntimeField_8 = 3;
        val_22 = mem[8];
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WADPets.WADPet val_9 = GetRandomPet();
        typeof(GiftReward).__il2cppRuntimeField_10 = public static WADPetsManager MonoSingleton<WADPetsManager>::get_Instance();
        val_23 = null;
        val_23 = null;
        val_16 = WADGiftRewardManager.<>c.<>9__0_0;
        if(val_16 == 0)
        {
                val_16 = null;
            val_16 = new System.Predicate<ZooTile>(object:  WADGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4143809232));
            WADGiftRewardManager.<>c.<>9__0_0 = val_16;
        }
        
        System.Collections.Generic.List<T> val_11 = FindAll(match:  8040448);
        if(val_18 == 0)
        {
            goto label_34;
        }
        
        val_16 = val_18;
        val_25 = null;
        val_25 = new System.Predicate<ZooTile>(object:  383225856, method:  new IntPtr(4143812304));
        typeof(WADGiftRewardManager.<>c__DisplayClass0_0).__il2cppRuntimeField_C = val_25;
        object val_13 = Find(match:  8040448);
        if(val_16 == 0)
        {
            goto label_34;
        }
        
        decimal val_14 = System.Decimal.op_Increment(d:  new System.Decimal() {flags = -151140784, hi = typeof(System.Collections.Generic.List<T>).__il2cppRuntimeField_14, lo = System.Collections.Generic.List<T>.__il2cppRuntimeField_this_arg, mid = R8});
        val_18 = val_18;
        val_17 = val_17;
        goto label_37;
        label_34:
        val_26 = null;
        val_26 = null;
        Add(item:  372842496);
        label_37:
         =  + 1;
        if( < rewardAmount)
        {
            goto label_44;
        }
        
        return;
        label_9:
        if( == 0)
        {
                return;
        }
        
        val_22 = mem[8];
        decimal val_15 = System.Decimal.op_Implicit(value:  -151140784);
        Add(item:  372842496);
        return;
        label_15:
        UnityEngine.Debug.LogError(message:  -151152944);
    }
    public System.Collections.Generic.List<GiftReward> GetRewards(GiftRewardSource rewardSource)
    {
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        System.Predicate<GiftRewardTypeChance> val_47;
        var val_48;
        var val_49;
        System.Predicate<GiftRewardTypeChance> val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_59;
        if(rewardSource != 2)
        {
            goto label_1;
        }
        
        val_41 = null;
        val_42 = 0;
        goto label_2;
        label_1:
        System.Collections.Generic.List<GiftRewardTypeChance> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>().GetRewardTypeChances(rewardSource:  rewardSource);
        val_43 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
                val_44 = 1152921504990126080;
            val_45 = null;
            val_45 = null;
            val_47 = WADGiftRewardManager.<>c.<>9__1_0;
            if(val_47 == 0)
        {
                val_47 = null;
            val_47 = new System.Predicate<ZooTile>(object:  WADGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4143934768));
            WADGiftRewardManager.<>c.<>9__1_0 = val_47;
        }
        
            int val_5 = val_43.RemoveAll(match:  8040448);
        }
        
        var val_41 = 27952896;
        val_41 = 7672896 + val_41;
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                val_44 = 1152921504990126080;
            val_49 = null;
            val_49 = null;
            val_51 = WADGiftRewardManager.<>c.<>9__1_1;
            if(val_51 == 0)
        {
                val_51 = null;
            val_51 = new System.Predicate<ZooTile>(object:  WADGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4143937840));
            WADGiftRewardManager.<>c.<>9__1_1 = val_51;
        }
        
            int val_7 = val_43.RemoveAll(match:  8040448);
        }
        
        if((mem[.ctor() + 12]) == 0)
        {
            goto label_23;
        }
        
        List.Enumerator<T> val_8 = GetEnumerator();
        label_94:
        if(MoveNext() == false)
        {
            goto label_24;
        }
        
        object val_11 = new System.Object();
        val_52 = 0;
        if((UnityEngine.Random.Range(min:  0, max:  100)) >= (val_10 + 12))
        {
            goto label_94;
        }
        
        GiftReward val_13 = new GiftReward();
        if(val_11 != 0)
        {
                val_53 = val_11;
            typeof(WADGiftRewardManager.<>c__DisplayClass1_0).__il2cppRuntimeField_8 = val_13;
        }
        else
        {
                val_53 = 8;
            mem[8] = val_13;
        }
        
        typeof(GiftReward).__il2cppRuntimeField_8 = val_10 + 8;
        if((val_10 + 8) <= 5)
        {
                var val_14 = 7673476 + (7673476 + (val_10 + 8) << 2);
            if((val_10 + 8) == 5)
        {
                7673476 + (val_10 + 8) << 2 = (7673476 + (val_10 + 8) << 2) & (val_53 << (7673476 + (val_10 + 8) << 2));
            7673476 + (val_10 + 8) << 2 = (7673476 + (val_10 + 8) << 2) * (val_10 + 8);
            mem2[0] = ((7673476 + (val_10 + 8) << 2 & (val_53) << 7673476 + (val_10 + 8) << 2) * val_10 + 8) + val_53;
            mem2[0] = ((7673476 + (val_10 + 8) << 2 & (val_53) << 7673476 + (val_10 + 8) << 2) * val_10 + 8) + val_53 + ((7673476 + (val_10 + 8) << 2 & (val_53) << 7673476 + (val_10 + 8) << 2) * val_10 + 8) + val_53;
            (((7673476 + (val_10 + 8) << 2 & (val_53) << 7673476 + (val_10 + 8) << 2) * val_10 + 8) + val_53 + ((7673476 + (val_10 + 8) << 2 & (val_53) << 7673476 + (val_10 + 8) << 2) * val_10 + 8) + val_53) & 0 = ((((7673476 + (val_10 + 8) << 2 & (val_53) << 7673476 + (val_10 + 8) << 2) * val_10 + 8) + val_53 + ((7673476 + (val_10 + 8) << 2 & (val_53) << 7673476 + (val_10 + 8) << 2) * val_10 + 8) + val_53) & 0) & (((val_10 + 8) << (32-10)) | ((val_10 + 8) << 10));
        }
        
            val_54 = mem[8];
            decimal val_15 = GetCoinReward(rewardSource:  -151002000);
        }
        
        val_59 = null;
        val_59 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = typeof(GiftReward).__il2cppRuntimeField_14, hi = GiftReward.__il2cppRuntimeField_this_arg, lo = R6, mid = GiftReward.__il2cppRuntimeField_element_class}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
            goto label_94;
        }
        
        Add(item:  372842496);
        goto label_94;
        label_24:
        Dispose();
        val_48 = null;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        UnityEngine.Debug.LogErrorFormat(format:  -151026384, args:  472754880);
        GiftReward val_35 = null;
        val_41 = val_35;
        val_35 = new GiftReward();
        typeof(GiftReward).__il2cppRuntimeField_8 = 0;
        GameEcon val_36 = App.getGameEcon;
        decimal val_37 = System.Decimal.op_Implicit(value:  -151014080);
        goto label_128;
        label_23:
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        val_42 = 0;
        UnityEngine.Debug.LogErrorFormat(format:  -151026208, args:  472754880);
        GiftReward val_38 = null;
        val_41 = val_38;
        label_2:
        val_38 = new GiftReward();
        typeof(GiftReward).__il2cppRuntimeField_8 = val_42;
        GameEcon val_39 = App.getGameEcon;
        decimal val_40 = System.Decimal.op_Implicit(value:  -151014080);
        label_128:
        Add(item:  372842496);
    }
    public void CollectRewards(System.Collections.Generic.List<GiftReward> rewards, GiftRewardSource rewardSource)
    {
        var val_10;
        int val_26;
        var val_37;
        System.Collections.Generic.List<GiftReward> val_38;
        System.Predicate<GiftReward> val_39;
        var val_40;
        System.Func<GiftReward, System.Int32> val_42;
        var val_43;
        System.Predicate<GiftReward> val_45;
        var val_46;
        System.Func<GiftReward, System.Decimal> val_48;
        var val_49;
        System.Predicate<GiftReward> val_51;
        var val_52;
        System.Func<GiftReward, System.Int32> val_54;
        var val_55;
        System.Predicate<GiftReward> val_57;
        var val_58;
        System.Func<GiftReward, System.Int32> val_60;
        string val_1 = this.GetRewardSourceTracking(rewardSource:  rewardSource);
        if((WADGiftRewardManager.<>c.<>9__2_0) == 0)
        {
                System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  WADGiftRewardManager.<>c.<>9, method:  new IntPtr(4144065584));
            WADGiftRewardManager.<>c.<>9__2_0 = null;
        }
        
        System.Collections.Generic.List<T> val_3 = rewards.FindAll(match:  8040448);
        if(rewards >= 1)
        {
                if((WADGiftRewardManager.<>c.<>9__2_1) == 0)
        {
                System.Func<TRVDailyBonusRewardContainer, System.Decimal> val_4 = new System.Func<TRVDailyBonusRewardContainer, System.Decimal>(object:  WADGiftRewardManager.<>c.<>9, method:  new IntPtr(4144066608));
            WADGiftRewardManager.<>c.<>9__2_1 = null;
        }
        
            decimal val_5 = System.Linq.Enumerable.Sum<TRVDailyBonusRewardContainer>(source:  -150874336, selector:  rewards);
            CurrencyController.CreditBalance(value:  new System.Decimal(), source:  0, externalParams:  0, animated:  false);
        }
        
        if((WADGiftRewardManager.<>c.<>9__2_2) == 0)
        {
                System.Predicate<ZooTile> val_6 = new System.Predicate<ZooTile>(object:  WADGiftRewardManager.<>c.<>9, method:  new IntPtr(4144069680));
            WADGiftRewardManager.<>c.<>9__2_2 = null;
        }
        
        System.Collections.Generic.List<T> val_7 = rewards.FindAll(match:  8040448);
        List.Enumerator<T> val_8 = GetEnumerator();
        label_28:
        if(MoveNext() == false)
        {
            goto label_21;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        var val_12 = val_10 + 20;
        RewardPetCards(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[(val_10 + 20) + (0)], hi = mem[(val_10 + 20) + (4)], lo = mem[(val_10 + 20) + (8)], mid = mem[(val_10 + 20) + (12)]}), pet:  val_10 + 16, source:  null, subsource:  0, additionalParam:  0);
        goto label_28;
        label_21:
        Dispose();
        val_37 = 1152921504990126080;
        val_38 = rewards;
        if((rewards + 12) >= 1)
        {
                Player val_14 = App.Player;
            string val_15 = rewards + 12.ToString();
            0.TrackNonCoinReward(source:  null, subSource:  null, rewardType:  -1050421024, rewardAmount:  rewards + 12, additionalParams:  0);
            val_38 = rewards;
        }
        
        val_39 = WADGiftRewardManager.<>c.<>9__2_3;
        if(val_39 == 0)
        {
                val_39 = null;
            val_39 = new System.Predicate<ZooTile>(object:  WADGiftRewardManager.<>c.<>9, method:  new IntPtr(4144070704));
            WADGiftRewardManager.<>c.<>9__2_3 = val_39;
        }
        
        System.Collections.Generic.List<T> val_17 = val_38.FindAll(match:  8040448);
        if((rewards + 12) >= 1)
        {
                Player val_18 = App.Player;
            val_40 = null;
            val_40 = null;
            val_42 = WADGiftRewardManager.<>c.<>9__2_4;
            if(val_42 == 0)
        {
                val_42 = null;
            val_42 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WADGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4144071728));
            val_38 = rewards;
            WADGiftRewardManager.<>c.<>9__2_4 = val_42;
        }
        
            0.AddPetsFood(amount:  System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  val_38, selector:  7720960), source:  null, subSource:  null, FoodSpentParams:  0, additionalParam:  0);
            val_37 = 1152921504990126080;
        }
        
        val_43 = null;
        val_45 = WADGiftRewardManager.<>c.<>9__2_5;
        if(val_45 == 0)
        {
                val_45 = null;
            val_45 = new System.Predicate<ZooTile>(object:  WADGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4144074800));
            WADGiftRewardManager.<>c.<>9__2_5 = val_45;
        }
        
        System.Collections.Generic.List<T> val_22 = val_38.FindAll(match:  8040448);
        if((rewards + 12) >= 1)
        {
                val_46 = null;
            val_46 = null;
            val_48 = WADGiftRewardManager.<>c.<>9__2_6;
            if(val_48 == 0)
        {
                val_48 = null;
            val_48 = new System.Func<TRVDailyBonusRewardContainer, System.Decimal>(object:  WADGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4144075824));
            val_38 = rewards;
            WADGiftRewardManager.<>c.<>9__2_6 = val_48;
        }
        
            decimal val_24 = System.Linq.Enumerable.Sum<TRVDailyBonusRewardContainer>(source:  -150874336, selector:  val_38);
            string val_25 = System.String.Format(format:  -150890448, arg0:  0);
            val_37 = 1152921504990126080;
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = val_26}, source:  "{0} Pet Coins", externalParams:  0, animated:  false);
        }
        
        val_49 = null;
        val_51 = WADGiftRewardManager.<>c.<>9__2_7;
        if(val_51 == 0)
        {
                val_51 = null;
            val_51 = new System.Predicate<ZooTile>(object:  WADGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4144076944));
            WADGiftRewardManager.<>c.<>9__2_7 = val_51;
        }
        
        System.Collections.Generic.List<T> val_28 = val_38.FindAll(match:  8040448);
        if((rewards + 12) >= 1)
        {
                val_52 = null;
            val_52 = null;
            val_54 = WADGiftRewardManager.<>c.<>9__2_8;
            if(val_54 == 0)
        {
                val_54 = null;
            val_54 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WADGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4144077968));
            val_38 = rewards;
            WADGiftRewardManager.<>c.<>9__2_8 = val_54;
        }
        
            SnakesAndLaddersEventHandler.<Instance>k__BackingField.RewardDiceRolls(amount:  System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  val_38, selector:  7720960), source:  null);
            val_37 = 1152921504990126080;
        }
        
        val_55 = null;
        val_57 = WADGiftRewardManager.<>c.<>9__2_9;
        if(val_57 == 0)
        {
                val_57 = null;
            val_57 = new System.Predicate<ZooTile>(object:  WADGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4144078992));
            WADGiftRewardManager.<>c.<>9__2_9 = val_57;
        }
        
        System.Collections.Generic.List<T> val_32 = val_38.FindAll(match:  8040448);
        if((rewards + 12) >= 1)
        {
                twelvegigs.Autopilot.AutopilotManager val_33 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_38 = public static GoldenApplesManager MonoSingleton<GoldenApplesManager>::get_Instance();
            val_58 = null;
            val_58 = null;
            val_60 = WADGiftRewardManager.<>c.<>9__2_10;
            if(val_60 == 0)
        {
                val_60 = null;
            val_60 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WADGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4144080016));
            WADGiftRewardManager.<>c.<>9__2_10 = val_60;
        }
        
            int val_35 = System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  val_38, selector:  7720960);
        }
        
        if(rewardSource > 2)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_36 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleCollected();
    }
    private System.Collections.Generic.List<GiftRewardTypeChance> GetRewardTypeChances(GiftRewardSource rewardSource)
    {
        GameEcon val_1 = App.getGameEcon;
        if((0.ContainsKey(key:  rewardSource)) != false)
        {
                GameEcon val_3 = App.getGameEcon;
            if(0 != 0)
        {
                return 0.Item[rewardSource];
        }
        
            return 0.Item[rewardSource];
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }
    private decimal GetCoinReward(GiftRewardSource rewardSource)
    {
        WADGiftRewardManager val_20;
        var val_21;
        var val_24;
        float val_27;
        var val_28;
        var val_29;
        val_20 = this;
        var val_22 = 27948531;
        val_22 = 7677256 + val_22;
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_21 = null;
        val_21 = null;
        if(App.game == 20)
        {
                decimal val_1 = RestaurantRivals.RESGameEconHelper.GetDailyBonusRewardAmount();
            return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -150637680};
        }
        
        GameEcon val_2 = App.getGameEcon;
        if((0.ContainsKey(key:  R2)) == false)
        {
            goto label_12;
        }
        
        GameEcon val_5 = App.getGameEcon;
        object val_6 = 0.Item[R2];
        label_28:
        if(0 >= 0)
        {
            goto label_18;
        }
        
        if(0 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_7 = System.Convert.ToInt32(value:  static_value_00280013);
        decimal val_8 = System.Decimal.op_Implicit(value:  -150623688);
        Player val_9 = App.Player;
        var val_11 = 4 + 1;
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256})) == true)
        {
            goto label_28;
        }
        
        label_18:
        if(4 == 4)
        {
                4 - 5 = 0 - 1;
        }
        
        if(0 <= (4 - 5))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_23 = 0;
        val_23 = val_23 + ((4 - 5) << 2);
        val_20 = R2;
        int val_13 = UnityEngine.Random.Range(min:  0, max:  (0 + ((0 - 1)) << 2) + 16 + 20 + 12);
        if(val_20 != 3)
        {
            goto label_32;
        }
        
        GameEcon val_14 = App.getGameEcon;
        val_27 = 0f;
        goto label_36;
        label_12:
        GameEcon val_15 = App.getGameEcon;
        val_24 = public System.Boolean System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardAmountChance>>::ContainsKey(GiftRewardSource key);
        if((0.ContainsKey(key:  R2)) == false)
        {
            goto label_41;
        }
        
        GameEcon val_17 = App.getGameEcon;
        object val_18 = 0.Item[R2];
        int val_19 = this.GetRewardByAmountChance(rewards:  0);
        val_28 = val_20;
        goto label_48;
        label_32:
        val_27 = 1f;
        label_36:
        if(0 <= (4 - 5))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_24 = 0;
        val_24 = val_24 + ((4 - 5) << 2);
        if(((0 + ((0 - 1)) << 2) + 16 + 20 + 12) <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_25 = (0 + ((0 - 1)) << 2) + 16 + 20 + 8;
        val_25 = val_25 + (val_13 << 2);
        val_28 = val_20;
        float val_26 = (float)System.Convert.ToInt32(value:  ((0 + ((0 - 1)) << 2) + 16 + 20 + 8 + (val_13) << 2) + 16);
        val_26 = val_27 * val_26;
        label_48:
        decimal val_21 = System.Decimal.op_Implicit(value:  -150611632);
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -150637680};
        label_41:
        val_29 = null;
        val_29 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished, lo = -150637680};
    }
    private int GetPetFoodReward(GiftRewardSource rewardSource)
    {
        GameEcon val_1 = App.getGameEcon;
        object val_2 = 0.Item[rewardSource];
        return this.GetRewardByAmountChance(rewards:  0);
    }
    private int GetPetCoinReward()
    {
        float val_1 = WADPetsManager.GetLevelCurveModifier(ability:  5);
        return (int)5;
    }
    private int GetDiceRollReward(GiftRewardSource rewardSource)
    {
        GameEcon val_1 = App.getGameEcon;
        object val_2 = 0.Item[rewardSource];
        return this.GetRewardByAmountChance(rewards:  0);
    }
    private int GetGoldenCurrencyReward(GiftRewardSource rewardSource)
    {
        GameEcon val_1 = App.getGameEcon;
        object val_2 = 0.Item[rewardSource];
        return this.GetRewardByAmountChance(rewards:  0);
    }
    private int GetRewardByAmountChance(System.Collections.Generic.List<GiftRewardAmountChance> rewards)
    {
        var val_4;
        var val_6;
        RandomSet val_1 = new RandomSet();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 != 0)
        {
                val_6 = mem[val_4 + 8];
            val_6 = val_4 + 8;
        }
        else
        {
                val_6 = 0;
        }
        
        add(item:  0, weight:  null);
        goto label_6;
        label_2:
        Dispose();
        return (int)roll(unweighted:  false);
    }
    private string GetRewardSourceTracking(GiftRewardSource rewardSource)
    {
        var val_3;
        var val_4;
        if(rewardSource <= 12)
        {
                var val_1 = 7683524 + (7683524 + (rewardSource) << 2);
            if(rewardSource == 12)
        {
                7683524 = 7683524 & ((IP) >> 2);
            7683524 = 7683524 & (rewardSource >> 7683524);
            7683524 = 7683524 & (((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ));
            7683524 = 7683524 & (((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )))) | ((R8) << (((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        ))));
            7683524 = 7683524 & (rewardSource << 1);
            7683524 = 7683524 & (((R8) << (32-1)) | ((R8) << 1));
            mem2[0] = ((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource;
            (((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) & ((((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) << 2) = ((((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) & ((((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) << 2)) & ((IP) << 2);
            (((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) & ((((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) << 2) = ((((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) & ((((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) << 2)) & ((R8) << "Daily Bonus Reward");
            (((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) & ((((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) << 2) = ((((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) & ((((((((7683524 & (IP) >> 2) & (rewardSource) >> (7683524 & (IP) >> 2)) & ((IP) << (32-as. 
            
        
        
        
        
        
           
        )) | ((IP) << as. 
            
        
        
        
        
        
           
        )) & ((R8) << (32-(((7683524 & (IP) >> 2) & (rewardSource) >> ( + rewardSource) << 2)) & (rewardSource >> 2);
        }
        
            val_3 = null;
            val_3 = null;
            val_4 = 1152921504891461956;
            return;
        }
        
        if(CategoryPacksManager.IsPlaying == true)
        {
                val_4 = "Category Chapter Complete";
        }
    
    }
    private string PrintRewards(System.Collections.Generic.List<GiftReward> giftRewards)
    {
        var val_2;
        string val_6 = "";
        List.Enumerator<T> val_1 = GetEnumerator();
        goto label_2;
        label_22:
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_6;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = ": ";
        var val_3 = val_2 + 20;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "\n";
        string val_4 = +472754880;
        val_6 = null;
        label_2:
        if(MoveNext() == true)
        {
            goto label_22;
        }
        
        Dispose();
    }
    public WADGiftRewardManager()
    {
    
    }

}
