using UnityEngine;
public class RESAttackMadnessEventHandler : AttackMadnessEventHandler
{
    // Methods
    public override void OnAllReelsStopped()
    {
        var val_13;
        var val_14;
        var val_16;
        var val_17;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(R6 != 0)
        {
                val_14 = mem[R6 + 40];
            val_14 = R6 + 40;
        }
        else
        {
                val_13 = 40;
            val_14 = 2097204;
        }
        
        mem[40] = (val_14 + public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 8);
        float val_4 = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 8.GetAveragePointPerSpinThreshold(playerTier:  this.PlayerTier);
        float val_5 = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 8.AveragePointPerSpin;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_14 = 1152921504622129152;
        string val_7 = System.String.Format(format:  -1537915968, arg0:  15282176, arg1:  15282176);
        val_16 = "<color=#EE5000>=> AvgPtPerSpin ({0}) fell below threshold \'{1}\' <=</color>";
        HackAddSlotResultLog(str:  -1537915968);
        val_17 = 0;
        RestaurantRivals.RESSpin.SwapSlotOutcomeResults(resultsId:  1);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RecalcSession();
        mem[1152921511658890284] = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 8;
    }
    protected override void OnAttackCompleted(bool isSuccess)
    {
        var val_16;
        var val_17;
        if(this.EventCompleted() == true)
        {
                return;
        }
        
        if(this.HasCollectedAllRewards() == true)
        {
                return;
        }
        
        if(this.IsEventValid == false)
        {
                return;
        }
        
        if(mem[35629805] < 1)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        var val_16 = SpinBet;
        if((R6 + 32) == 0)
        {
                System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_6 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            mem2[0] = null;
        }
        
        val_16 = val_16 * mem[35629805];
        GameplayMode val_7 = PlayingLevel.CurrentGameplayMode;
        int val_8 = EnumerableExtentions.GetOrDefault<System.Int32Enum, System.Int32>(dic:  System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_element_class, key:  0, defaultValue:  0);
        GameplayMode val_9 = PlayingLevel.CurrentGameplayMode;
        EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Int32>(dic:  R7 + 32, key:  0, newValue:  val_8 + val_16);
        if(val_8 != 0)
        {
                val_17 = mem[val_8 + 36];
            val_17 = val_8 + 36;
        }
        else
        {
                val_16 = 36;
            val_17 = 83886592;
        }
        
        mem[36] = val_17 + val_16;
        this.PointsCollected = this.PointsCollected + val_16;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        IncrementInterruptCounterPostSpin1();
        int val_15 = this.PointsRequired;
        this.UpdateProgressToServer();
    }
    protected override void UpdatePointsFlow(int ptsToAdd, int ptsMaxLimit, bool onlyAnimateProgressBar)
    {
        var val_4;
        System.Action val_5;
        var val_6;
        val_4 = this;
        if(ptsToAdd < ptsMaxLimit)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance();
            val_5 = null;
            val_6 = 1152921511659091264;
        }
        else
        {
                mem[1152921511659117336] = 1;
            val_5 = null;
            val_6 = 1152921511659092288;
        }
        
        val_5 = new System.Action(object:  -1537664256, method:  new IntPtr(2757278016));
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_20.QueuePointGainAnimation(qty:  ptsToAdd, onAnimationComplete:  7454720, onlyAnimateProgressBar:  onlyAnimateProgressBar);
    }
    protected override void ShowRewardCollection(System.Action onCollectionClose)
    {
        var val_9;
        GameBehavior val_1 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_4 = new System.Action(object:  -1537803328, method:  new IntPtr(2757276992));
        val_9 = 0;
        System.Delegate val_5 = System.Delegate.Combine(a:  0, b:  7454720);
        if(val_9 != 0)
        {
                if(1179403647 == null)
        {
            goto label_9;
        }
        
        }
        
        val_9 = 0;
        label_9:
        mem[12] = val_9;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        RESEventRewardData val_7 = this.GetCurrentReward();
        Add(item:  -1537544976);
        System.Action val_8 = new System.Action(object:  -1537544976, method:  System.Void AttackMadnessEventHandler::OnCurrentRewardCollected());
        0.InitReward(_rewardDataList:  80883712, onCollectClicked:  7454720, source:  -1537569088);
    }
    public RESAttackMadnessEventHandler()
    {
    
    }
    private void <UpdatePointsFlow>b__2_0()
    {
        mem[1152921511659464712] = 0;
        goto typeof(RESAttackMadnessEventHandler).__il2cppRuntimeField_40C;
    }

}
