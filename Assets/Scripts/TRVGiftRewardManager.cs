using UnityEngine;
public class TRVGiftRewardManager : WGGiftRewardManager<TRVGiftRewardManager>
{
    // Methods
    public System.Collections.Generic.List<GiftReward> GetRewards(GiftRewardSource rewardsSource, out bool expertLeveledUp, int cardsGranted = 0)
    {
        var val_10;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        expertLeveledUp = false;
        if(rewardsSource != 3)
        {
            goto label_1;
        }
        
        int val_3 = new TRVDailyBonusRewardContainer().GetCoinReward();
        decimal val_4 = System.Decimal.op_Implicit(value:  -600519088);
        Add(item:  353034240);
        label_15:
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<TRVExpert> val_7 = DetermineExpertCards(source:  rewardsSource, expertNowReadyToUpgrade: out  bool val_6 = true, cardsToPull:  cardsGranted);
        List.Enumerator<T> val_8 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_10;
        }
        
        if(new TRVDailyBonusRewardContainer() != 0)
        {
                typeof(TRVDailyBonusRewardContainer).__il2cppRuntimeField_8 = 3;
        }
        else
        {
                mem[8] = 3;
        }
        
        typeof(TRVDailyBonusRewardContainer).__il2cppRuntimeField_24 = val_10;
        Add(item:  353034240);
        goto label_14;
        label_10:
        Dispose();
        return;
        label_1:
        if(rewardsSource != 2)
        {
            goto label_15;
        }
        
        typeof(TRVDailyBonusRewardContainer).__il2cppRuntimeField_8 = 0;
        GameEcon val_13 = App.getGameEcon;
        decimal val_14 = System.Decimal.op_Implicit(value:  -600519088);
        Add(item:  353034240);
    }
    public void CollectRewards(System.Collections.Generic.List<TRVDailyBonusRewardContainer> rewards, GiftRewardSource rewardSource)
    {
        int val_7;
        bool val_11;
        float val_12;
        var val_13;
        System.Predicate<TRVDailyBonusRewardContainer> val_15;
        System.Func<TSource, System.Decimal> val_16;
        var val_17;
        System.Func<TRVDailyBonusRewardContainer, System.Decimal> val_19;
        var val_20;
        System.Predicate<TRVDailyBonusRewardContainer> val_22;
        val_11 = static_value_021FAA4D;
        if(val_11 != true)
        {
                val_11 = true;
        }
        
        string val_1 = this.GetRewardSourceTracking(rewardSource:  rewardSource);
        val_12 = 1152921504960040960;
        val_13 = null;
        val_13 = null;
        val_15 = TRVGiftRewardManager.<>c.<>9__1_0;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Predicate<ZooTile>(object:  TRVGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3694564608));
            TRVGiftRewardManager.<>c.<>9__1_0 = val_15;
        }
        
        System.Collections.Generic.List<T> val_3 = rewards.FindAll(match:  8040448);
        val_16 = rewards;
        if(rewards >= 1)
        {
                Player val_4 = App.Player;
            val_17 = null;
            val_17 = null;
            val_19 = TRVGiftRewardManager.<>c.<>9__1_1;
            if(val_19 == 0)
        {
                val_19 = null;
            val_12 = 1152921504960040960;
            val_19 = new System.Func<TRVDailyBonusRewardContainer, System.Decimal>(object:  TRVGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3694567680));
            TRVGiftRewardManager.<>c.<>9__1_1 = val_19;
        }
        
            decimal val_6 = System.Linq.Enumerable.Sum<TRVDailyBonusRewardContainer>(source:  -600383572, selector:  val_16);
            val_16 = 0;
            0.AddCredits(amount:  new System.Decimal() {mid = val_7}, source:  val_11, subSource:  val_16, externalParams:  val_16, doTrack:  true);
        }
        
        val_20 = null;
        val_22 = TRVGiftRewardManager.<>c.<>9__1_2;
        if(val_22 == 0)
        {
                val_22 = null;
            val_22 = new System.Predicate<ZooTile>(object:  TRVGiftRewardManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3694570752));
            TRVGiftRewardManager.<>c.<>9__1_2 = val_22;
        }
        
        System.Collections.Generic.List<T> val_9 = rewards.FindAll(match:  8040448);
        if(rewardSource > 2)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleCollected();
    }
    private int GetCoinReward()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        System.Collections.Generic.List<GiftRewardTier> val_2 = DailyBonusTiersV2;
        do
        {
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            int val_3 = System.Convert.ToInt32(value:  public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>().__il2cppRuntimeField_8 + 16 + 16);
            decimal val_4 = System.Decimal.op_Implicit(value:  -600263380);
            Player val_5 = App.Player;
            var val_7 = 4 + 1;
        }
        while((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256})) == true);
        
        var val_8 = 4 - 5;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        int val_10 = UnityEngine.Random.Range(min:  0, max:  (public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>().__il2cppRuntimeField_8 + ((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>().__il2cppRuntimeField_C - 1)) << 2) + 16 + 20 + 12);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        return (int)System.Convert.ToInt32(value:  ((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>().__il2cppRuntimeField_8 + ((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>().__il2cppRuntimeField_C - 1)) << 2) + 16 + 20 + 8 + (v + 16);
    }
    private string GetRewardSourceTracking(GiftRewardSource rewardSource)
    {
        if(rewardSource <= 12)
        {
                var val_1 = 8058080 + (8058080 + (rewardSource) << 2);
            if(rewardSource == 12)
        {
                8058080 = 8058080 & ((IP) >> 8058080);
            8058080 = 8058080 & (rewardSource >> 32);
            8058080 = 8058080 & (((IP) << (32-((8058080 & (IP) >> 8058080) & ((int)rewardSource) >> 32))) | ((IP) << ((8058080 & (IP) >> 8058080) & ((int)rewardSource) >> 32)));
            8058080 = 8058080 & ((R8) << 1);
            8058080 = rewardSource * 8058080;
            8058080 = 8058080 & (rewardSource >> 8058080);
            8058080 = 8058080 & (rewardSource >> 8058080);
            8058080 = 8058080 & (rewardSource >> 8058080);
            8058080 = 8058080 & (rewardSource >> 8058080);
            8058080 = 8058080 & (rewardSource >> 8058080);
            8058080 = 8058080 & (((((((((rewardSource * ((((8058080 & (IP) >> 8058080) & ((int)rewardSource) >> 32) & ((IP) << (32-((8058080 & (IP) >> 8058080) & ((int)rewardSource) >> 32))) | ((IP) << ((8058080 & (IP) >> 8058080) & (() << (32-1)) | ((((((((rewardSource * ((((8058080 & (IP) >> 8058080) & ((int)rewardSource) >> 32) & ((IP) << (32-((8058080 & (IP) >> 8058080) & ((int)rewardSource) >> 32))) | ((IP) << ((8058080 & (IP) >> 8058080) & (() << 1));
            8058080 = 8058080 & (((IP) << (32-1)) | ((IP) << 1));
            mem2[0] = ((((((((rewardSource * ((((8058080 & (IP) >> 8058080) & ((int)rewardSource) >> 32) & ((IP) << (32-((8058080 & (IP) >> 8058080) & ((int)rewardSource) >> 32))) | ((IP) << ((8058080 & (IP) >> 8058080) &  + R8;
        }
        
            return;
        }
        
        if(CategoryPacksManager.IsPlaying == true)
        {
                "unknown source gift reward" = "Category Chapter Complete";
        }
    
    }
    public TRVGiftRewardManager()
    {
    
    }

}
