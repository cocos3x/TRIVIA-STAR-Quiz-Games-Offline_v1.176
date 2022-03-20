using UnityEngine;
public class RESRaidMadnessEventHandler : RaidMadnessEventHandler
{
    // Methods
    public override void OnAllReelsStopped()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        float val_20;
        var val_22;
        val_14 = 8156568 + 27469219;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        if(App.game != 20)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(R7 != 0)
        {
                val_17 = mem[R7 + 40];
            val_17 = R7 + 40;
        }
        else
        {
                val_16 = 40;
            val_17 = 2097204;
        }
        
        mem[40] = (val_17 + public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 8);
        val_18 = 34776364;
        if(val_18 == 3)
        {
            goto label_19;
        }
        
        if(val_18 == 2)
        {
            goto label_16;
        }
        
        if(val_18 != 1)
        {
            goto label_17;
        }
        
        goto label_19;
        label_16:
        label_19:
        val_20 = mem[(public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 8 + 24)];
        val_20 = (public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 8 + 24);
        goto label_20;
        label_17:
        val_20 = -1f;
        label_20:
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_18 = 1152921504622129152;
        string val_5 = System.String.Format(format:  -1537915968, arg0:  15282176, arg1:  15282176);
        val_14 = "<color=#EE5000>=> AvgPtPerSpin ({0}) fell below threshold \'{1}\' <=</color>";
        HackAddSlotResultLog(str:  -1537915968);
        val_22 = 0;
        RestaurantRivals.RESSpin.SwapSlotOutcomeResults(resultsId:  2);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RecalcSession();
        mem[1152921512117671484] = ((float)public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 8 + 36) / ((float)public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 8 + 40);
    }
    protected override void OnRaidCompleted(bool isRaidPerfect)
    {
        var val_16;
        var val_17;
        System.Action val_18;
        var val_19;
        var val_20;
        if(this != 0)
        {
                return;
        }
        
        if(this.HasCollectedAllRewards() == true)
        {
                return;
        }
        
        if(this == 0)
        {
                return;
        }
        
        if(mem[35629856] < 1)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((R6 + 32) == 0)
        {
                System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_4 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            mem2[0] = null;
        }
        
        int val_5 = SpinBet * mem[35629856];
        GameplayMode val_6 = PlayingLevel.CurrentGameplayMode;
        int val_7 = EnumerableExtentions.GetOrDefault<System.Int32Enum, System.Int32>(dic:  System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_element_class, key:  0, defaultValue:  0);
        GameplayMode val_8 = PlayingLevel.CurrentGameplayMode;
        EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Int32>(dic:  System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_element_class + 32, key:  0, newValue:  val_7 + val_5);
        if(val_7 != 0)
        {
                val_17 = mem[val_7 + 36];
            val_17 = val_7 + 36;
        }
        else
        {
                val_16 = 36;
            val_17 = 83886592;
        }
        
        mem[36] = val_17 + val_5;
        RESRaidMadnessEventHandler val_11 = this + val_5;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        IncrementInterruptCounterPostSpin1();
        if(this < this)
        {
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_18 = null;
            val_19 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance();
            val_20 = 1152921511659091264;
        }
        else
        {
                mem[1152921512117785512] = 1;
            val_18 = null;
            val_19 = this;
            val_20 = 1152921512117759440;
        }
        
        val_18 = new System.Action(object:  -1078996080, method:  new IntPtr(3215945168));
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20.QueuePointGainAnimation(qty:  -1079021104, onAnimationComplete:  7454720, onlyAnimateProgressBar:  false);
        this.UpdateProgressToServer();
    }
    protected override UnityEngine.GameObject ShowRewardCollection()
    {
        var val_8;
        if(true != 0)
        {
                return;
        }
        
        GameBehavior val_1 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_4 = new System.Action(object:  -1537803328, method:  new IntPtr(2757276992));
        val_8 = 0;
        System.Delegate val_5 = System.Delegate.Combine(a:  0, b:  7454720);
        if(val_8 != 0)
        {
                if(1179403647 == null)
        {
            goto label_10;
        }
        
        }
        
        val_8 = 0;
        label_10:
        mem[12] = val_8;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  -1078883968);
        System.Action val_7 = new System.Action(object:  -1078883968, method:  typeof(RESRaidMadnessEventHandler).__il2cppRuntimeField_420);
        0.InitReward(_rewardDataList:  80883712, onCollectClicked:  7454720, source:  -1078908080);
        return 0.gameObject;
    }
    public RESRaidMadnessEventHandler()
    {
    
    }
    private void <OnRaidCompleted>b__1_0()
    {
        mem[1152921512118121624] = 0;
        goto typeof(RESRaidMadnessEventHandler).__il2cppRuntimeField_414;
    }

}
