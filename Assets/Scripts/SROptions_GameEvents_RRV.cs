using UnityEngine;
public class SROptions_GameEvents_RRV : SuperLuckySROptionsParent<SROptions_GameEvents_RRV>, INotifyPropertyChanged
{
    // Fields
    private WGEventHandler activeEvent;
    private System.TimeSpan eventSpan;
    private float calcTime;
    private string lastCachedInfo;
    
    // Properties
    public string CurrentEventType { get; }
    public string CurrentSingleEvent { get; }
    public string Level { get; }
    public string AtkMadnessCurrentRewData { get; }
    public string AtkMadnessRewardsCollected { get; }
    public string AtkMadnessPtsCollected { get; }
    public string RaidMadnessCurrentRewData { get; }
    public string RaidMadnessRewardsCollected { get; }
    public string RaidMadnessPtsCollected { get; }
    public string HotNSpicyCurrentRewData { get; }
    public string HotNSpicyRewardsCollected { get; }
    public string HotNSpicyPtsCollected { get; }
    private string EventExpireCountdown { get; }
    
    // Methods
    public static void NotifyPropertyChanged(string propertyName)
    {
        if((SuperLuckySROptionsParent<T>._Instance) == 0)
        {
                return;
        }
        
        goto typeof(T).__il2cppRuntimeField_EC;
    }
    public void Back()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        var val_6 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_5 = 0;
        label_4:
        val_5 = 0;
        val_6 = mem[mem[1179403735] + 0];
        val_6 = mem[1179403735] + 0;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_5 = val_5 + 1;
        val_5 = (uint)val_5 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_7 = 0;
        goto label_5;
        label_3:
        var val_2 = mem[1179403735] + 0;
        val_6 = val_6 + (((mem[1179403735] + 0) + 4) << 3);
        val_7 = val_6 + 332;
        label_5:
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_5 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_5 = (uint)val_6 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_8 = 0;
        goto label_10;
        label_8:
        var val_4 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 292;
        label_10:
        SuperLuckySROptionsController.OpenGameSpecificOptionsController();
    }
    public string get_CurrentEventType()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGEventHandler val_2 = GetOrderedEventHandlersByIndex(index:  0);
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) == 0)
        {
                return;
        }
        
        return EventType;
    }
    public string get_CurrentSingleEvent()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) != 0)
        {
                return QAHACK_CurrentSingleEventTypeKey;
        }
        
        return QAHACK_CurrentSingleEventTypeKey;
    }
    public void ToggleHackedSingleEvent()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHACK_ToggleSingleEvent();
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -887880896);
    }
    public void CurrentEventInfoHud()
    {
        var val_4;
        var val_5;
        System.Func<System.String> val_7;
        var val_8;
        val_4 = 1152921504946782208;
        val_5 = null;
        val_5 = null;
        val_7 = SROptions_GameEvents_RRV.<>c.<>9__7_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<TRVQuizProgress>(object:  SROptions_GameEvents_RRV.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3419111088));
            SROptions_GameEvents_RRV.<>c.<>9__7_0 = val_7;
        }
        
        SLCHUDWindow.SetupHUD(name:  -887767760, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_4 = 0;
        label_9:
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_8 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_8:
        var val_3 = mem[1179403735] + 0;
        var val_4 = (mem[1179403735] + 0) + 4;
        val_4 = 1179403647 + (val_4 << 3);
        val_8 = val_4 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public string get_Level()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) != 0)
        {
                return DebugGetLevel();
        }
        
        return DebugGetLevel();
    }
    public void PlayerLevelUp1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  1);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelUp10()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  5);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelUp100()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  100);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelDown1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  0);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelDown10()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  4);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelDown100()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  99);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public string get_AtkMadnessCurrentRewData()
    {
        var val_2 = 21777843;
        val_2 = 13850336 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if(((AttackMadnessEventHandler.<Instance>k__BackingField) == 0) || ((AttackMadnessEventHandler.<Instance>k__BackingField) == 0))
        {
                return;
        }
        
        AttackMadnessEventHandler.<Instance>k__BackingField.econ
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        AttackMadnessEventHandler.<Instance>k__BackingField.__unknownFiledOffset_8 = ;
        string val_1 = System.String.Format(format:  -874959184, arg0:  10170368, arg1:  347549696, arg2:  13152256);
    }
    public string get_AtkMadnessRewardsCollected()
    {
        var val_4 = 21777427;
        val_4 = 13850752 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        if((AttackMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_2 = AttackMadnessEventHandler.<Instance>k__BackingField.ProgressLevel.ToString();
        string val_3 = -874847024(-874847024) + -874834932(-874834932) + 1113431872;
    }
    private void ModifyAttackMadnessEventLevel(int val, bool isAbsoluteValue = False)
    {
        var val_3 = 21777179;
        val_3 = 13851000 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((AttackMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(isAbsoluteValue != true)
        {
                if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val = UnityEngine.Mathf.Max(a:  0, b:  (typeof(AttackMadnessProgress).__il2cppRuntimeField_14 + val));
        }
        
        typeof(AttackMadnessProgress).__il2cppRuntimeField_14 = val;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        typeof(AttackMadnessProgress).__il2cppRuntimeField_1C = 0;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        AttackMadnessEventHandler.<Instance>k__BackingField.UpdateProgressToServer();
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -874734912);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -874734800);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -874734672);
    }
    public void AttackMadnessRewardsCollectUp1()
    {
        this.ModifyAttackMadnessEventLevel(val:  1, isAbsoluteValue:  false);
    }
    public void AttackMadnessRewardsCollectUp10()
    {
        this.ModifyAttackMadnessEventLevel(val:  10, isAbsoluteValue:  false);
    }
    public void AttackMadnessRewardsCollectDown1()
    {
        this.ModifyAttackMadnessEventLevel(val:  0, isAbsoluteValue:  false);
    }
    public void AttackMadnessRewardsCollectDown10()
    {
        this.ModifyAttackMadnessEventLevel(val:  9, isAbsoluteValue:  false);
    }
    public string get_AtkMadnessPtsCollected()
    {
        var val_3 = 21776567;
        val_3 = 13851612 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((AttackMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_1 = AttackMadnessEventHandler.<Instance>k__BackingField.ToString();
        string val_2 = -874847024(-874847024) + -874162564(-874162564) + 1113431872;
    }
    private void ModifyAttackMadnessPointsCollected(int val, bool isAbsoluteValue = False)
    {
        bool val_3 = isAbsoluteValue;
        var val_3 = 21776311;
        val_3 = 13851868 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((AttackMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(val_3 != false)
        {
            
        }
        else
        {
                val_3 = AttackMadnessEventHandler.<Instance>k__BackingField;
            int val_2 = UnityEngine.Mathf.Max(a:  0, b:  val_3 + val);
        }
        
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        AttackMadnessEventHandler.<Instance>k__BackingField.UpdateProgressToServer();
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -874734912);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -874734800);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -874734672);
    }
    public void AtkMadnessPtsCollectUp1()
    {
        this.ModifyAttackMadnessPointsCollected(val:  1, isAbsoluteValue:  false);
    }
    public void AtkMadnessPtsCollectUp10()
    {
        this.ModifyAttackMadnessPointsCollected(val:  10, isAbsoluteValue:  false);
    }
    public void AtkMadnessPtsCollectUp100()
    {
        this.ModifyAttackMadnessPointsCollected(val:  100, isAbsoluteValue:  false);
    }
    public void AtkMadnessPtsCollectDown1()
    {
        this.ModifyAttackMadnessPointsCollected(val:  0, isAbsoluteValue:  false);
    }
    public void AtkMadnessPtsCollectDown10()
    {
        this.ModifyAttackMadnessPointsCollected(val:  9, isAbsoluteValue:  false);
    }
    public void AtkMadnessPtsCollectDown100()
    {
        this.ModifyAttackMadnessPointsCollected(val:  99, isAbsoluteValue:  false);
    }
    public void SkipToAlmostCurrentRewardPtsReq()
    {
        if((AttackMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        AttackMadnessEventHandler.<Instance>k__BackingField + 12.ModifyAttackMadnessPointsCollected(val:  (AttackMadnessEventHandler.<Instance>k__BackingField + 12) - 1, isAbsoluteValue:  true);
    }
    public void SkipToAlmostFinalRewardPtsReq()
    {
        AttackMadnessEcon val_5;
        if((AttackMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        RESEventRewardData val_1 = AttackMadnessEventHandler.<Instance>k__BackingField.GetFinalPrize();
        if((AttackMadnessEventHandler.<Instance>k__BackingField) != 0)
        {
                val_5 = mem[AttackMadnessEventHandler.<Instance>k__BackingField + 16];
            val_5 = AttackMadnessEventHandler.<Instance>k__BackingField.econ;
        }
        else
        {
                val_5 = mem[AttackMadnessEventHandler.<Instance>k__BackingField + 16];
            val_5 = AttackMadnessEventHandler.<Instance>k__BackingField.econ;
        }
        
        int val_5 = AttackMadnessEventHandler.<Instance>k__BackingField.PlayerTier;
        int val_3 = GetTotalCollectableRewards(playerTier:  val_5);
        val_5 = val_3 - 1;
        val_3.ModifyAttackMadnessEventLevel(val:  val_5, isAbsoluteValue:  true);
        AttackMadnessEventHandler.<Instance>k__BackingField + 12.ModifyAttackMadnessPointsCollected(val:  (AttackMadnessEventHandler.<Instance>k__BackingField + 12) - 1, isAbsoluteValue:  true);
    }
    public void ResetAtkMadness()
    {
        var val_1 = 21775339;
        val_1 = 13852840 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if((AttackMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        AttackMadnessEventHandler.<Instance>k__BackingField.ResetEventProgress();
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        AttackMadnessEventHandler.<Instance>k__BackingField.UpdateProgressToServer();
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -874734912);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -874734800);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -874734672);
    }
    public string get_RaidMadnessCurrentRewData()
    {
        var val_2 = 21776860;
        val_2 = 13853140 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if(((RaidMadnessEventHandler.<Instance>k__BackingField) == 0) || ((RaidMadnessEventHandler.<Instance>k__BackingField) == 0))
        {
                return;
        }
        
        RaidMadnessEventHandler.<Instance>k__BackingField.econ
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        RaidMadnessEventHandler.<Instance>k__BackingField.__unknownFiledOffset_8 = ;
        string val_1 = System.String.Format(format:  -874959184, arg0:  10170368, arg1:  347549696, arg2:  13152256);
    }
    public string get_RaidMadnessRewardsCollected()
    {
        var val_4 = 21776444;
        val_4 = 13853556 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        if((RaidMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_2 = RaidMadnessEventHandler.<Instance>k__BackingField.ProgressLevel.ToString();
        string val_3 = -874847024(-874847024) + -872818564(-872818564) + 1113431872;
    }
    private void ModifyRaidMadnessEventLevel(int val, bool isAbsoluteValue = False)
    {
        var val_3 = 21776196;
        val_3 = 13853804 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((RaidMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(isAbsoluteValue != true)
        {
                if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val = UnityEngine.Mathf.Max(a:  0, b:  (typeof(RaidMadnessProgress).__il2cppRuntimeField_14 + val));
        }
        
        typeof(RaidMadnessProgress).__il2cppRuntimeField_14 = val;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        typeof(RaidMadnessProgress).__il2cppRuntimeField_1C = 0;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        RaidMadnessEventHandler.<Instance>k__BackingField.UpdateProgressToServer();
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -872718544);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -872718416);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -872718288);
    }
    public void RaidMadnessRewardsCollectUp1()
    {
        this.ModifyRaidMadnessEventLevel(val:  1, isAbsoluteValue:  false);
    }
    public void RaidMadnessRewardsCollectUp10()
    {
        this.ModifyRaidMadnessEventLevel(val:  10, isAbsoluteValue:  false);
    }
    public void RaidMadnessRewardsCollectDown1()
    {
        this.ModifyRaidMadnessEventLevel(val:  0, isAbsoluteValue:  false);
    }
    public void RaidMadnessRewardsCollectDown10()
    {
        this.ModifyRaidMadnessEventLevel(val:  9, isAbsoluteValue:  false);
    }
    public string get_RaidMadnessPtsCollected()
    {
        var val_3 = 21775584;
        val_3 = 13854416 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((RaidMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_1 = RaidMadnessEventHandler.<Instance>k__BackingField.ToString();
        string val_2 = -874847024(-874847024) + -872146180(-872146180) + 1113431872;
    }
    private void ModifyRaidMadnessPointsCollected(int val, bool isAbsoluteValue = False)
    {
        bool val_3 = isAbsoluteValue;
        var val_3 = 21775328;
        val_3 = 13854672 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((RaidMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(val_3 != false)
        {
            
        }
        else
        {
                val_3 = RaidMadnessEventHandler.<Instance>k__BackingField;
            int val_2 = UnityEngine.Mathf.Max(a:  0, b:  val_3 + val);
        }
        
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        RaidMadnessEventHandler.<Instance>k__BackingField.UpdateProgressToServer();
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -872718544);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -872718416);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -872718288);
    }
    public void RaidMadnessPtsCollectUp1()
    {
        this.ModifyRaidMadnessPointsCollected(val:  1, isAbsoluteValue:  false);
    }
    public void RaidMadnessPtsCollectUp10()
    {
        this.ModifyRaidMadnessPointsCollected(val:  10, isAbsoluteValue:  false);
    }
    public void RaidMadnessPtsCollectUp100()
    {
        this.ModifyRaidMadnessPointsCollected(val:  100, isAbsoluteValue:  false);
    }
    public void RaidMadnessPtsCollectDown1()
    {
        this.ModifyRaidMadnessPointsCollected(val:  0, isAbsoluteValue:  false);
    }
    public void RaidMadnessPtsCollectDown10()
    {
        this.ModifyRaidMadnessPointsCollected(val:  9, isAbsoluteValue:  false);
    }
    public void RaidMadnessPtsCollectDown100()
    {
        this.ModifyRaidMadnessPointsCollected(val:  99, isAbsoluteValue:  false);
    }
    public void RaidSkipToAlmostCurrentRewardPtsReq()
    {
        if((RaidMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        RaidMadnessEventHandler.<Instance>k__BackingField + 12.ModifyRaidMadnessPointsCollected(val:  (RaidMadnessEventHandler.<Instance>k__BackingField + 12) - 1, isAbsoluteValue:  true);
    }
    public void RaidSkipToAlmostFinalRewardPtsReq()
    {
        RaidMadnessEcon val_5;
        if((RaidMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        RESEventRewardData val_1 = RaidMadnessEventHandler.<Instance>k__BackingField.GetFinalPrize();
        if((RaidMadnessEventHandler.<Instance>k__BackingField) != 0)
        {
                val_5 = mem[RaidMadnessEventHandler.<Instance>k__BackingField + 16];
            val_5 = RaidMadnessEventHandler.<Instance>k__BackingField.econ;
        }
        else
        {
                val_5 = mem[RaidMadnessEventHandler.<Instance>k__BackingField + 16];
            val_5 = RaidMadnessEventHandler.<Instance>k__BackingField.econ;
        }
        
        int val_5 = RaidMadnessEventHandler.<Instance>k__BackingField.PlayerTier;
        int val_3 = GetTotalCollectableRewards(playerTier:  val_5);
        val_5 = val_3 - 1;
        val_3.ModifyRaidMadnessEventLevel(val:  val_5, isAbsoluteValue:  true);
        RaidMadnessEventHandler.<Instance>k__BackingField + 12.ModifyRaidMadnessPointsCollected(val:  (RaidMadnessEventHandler.<Instance>k__BackingField + 12) - 1, isAbsoluteValue:  true);
    }
    public void ResetRaidMadness()
    {
        var val_1 = 21774356;
        val_1 = 13855644 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if((RaidMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        RaidMadnessEventHandler.<Instance>k__BackingField.ResetEventProgress();
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        RaidMadnessEventHandler.<Instance>k__BackingField.UpdateProgressToServer();
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -872718544);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -872718416);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -872718288);
    }
    public string get_HotNSpicyCurrentRewData()
    {
        var val_2 = 21769597;
        val_2 = 13855944 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if(((HotNSpicyEventHandler.<Instance>k__BackingField) == 0) || ((HotNSpicyEventHandler.<Instance>k__BackingField) == 0))
        {
                return;
        }
        
        HotNSpicyEventHandler.<Instance>k__BackingField.econ
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        HotNSpicyEventHandler.<Instance>k__BackingField.__unknownFiledOffset_8 = ;
        string val_1 = System.String.Format(format:  -874959184, arg0:  10170368, arg1:  347549696, arg2:  13152256);
    }
    public string get_HotNSpicyRewardsCollected()
    {
        var val_4 = 21769181;
        val_4 = 13856360 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        if((HotNSpicyEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_2 = HotNSpicyEventHandler.<Instance>k__BackingField.ProgressLevel.ToString();
        string val_3 = -874847024(-874847024) + -870802180(-870802180) + 1113431872;
    }
    private void ModifyHotNSpicyEventLevel(int val, bool isAbsoluteValue = False)
    {
        var val_3 = 21768933;
        val_3 = 13856608 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((HotNSpicyEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(isAbsoluteValue != true)
        {
                if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val = UnityEngine.Mathf.Max(a:  0, b:  (typeof(HotNSpicyProgress).__il2cppRuntimeField_14 + val));
        }
        
        typeof(HotNSpicyProgress).__il2cppRuntimeField_14 = val;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        typeof(HotNSpicyProgress).__il2cppRuntimeField_1C = 0;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        HotNSpicyEventHandler.<Instance>k__BackingField.UpdateProgressToServer();
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -870702160);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -870702048);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -870701920);
    }
    public void HotNSpicyRewardsCollectUp1()
    {
        this.ModifyHotNSpicyEventLevel(val:  1, isAbsoluteValue:  false);
    }
    public void HotNSpicyRewardsCollectUp10()
    {
        this.ModifyHotNSpicyEventLevel(val:  10, isAbsoluteValue:  false);
    }
    public void HotNSpicyRewardsCollectDown1()
    {
        this.ModifyHotNSpicyEventLevel(val:  0, isAbsoluteValue:  false);
    }
    public void HotNSpicyRewardsCollectDown10()
    {
        this.ModifyHotNSpicyEventLevel(val:  9, isAbsoluteValue:  false);
    }
    public string get_HotNSpicyPtsCollected()
    {
        var val_3 = 21768321;
        val_3 = 13857220 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((HotNSpicyEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_1 = HotNSpicyEventHandler.<Instance>k__BackingField.ToString();
        string val_2 = -874847024(-874847024) + -870129812(-870129812) + 1113431872;
    }
    private void ModifyHotNSpicyPointsCollected(int val, bool isAbsoluteValue = False)
    {
        bool val_3 = isAbsoluteValue;
        var val_3 = 21768065;
        val_3 = 13857476 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((HotNSpicyEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(val_3 != false)
        {
            
        }
        else
        {
                val_3 = HotNSpicyEventHandler.<Instance>k__BackingField;
            int val_2 = UnityEngine.Mathf.Max(a:  0, b:  val_3 + val);
        }
        
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        HotNSpicyEventHandler.<Instance>k__BackingField.UpdateProgressToServer();
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -870702160);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -870702048);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -870701920);
    }
    public void HotNSpicyPtsCollectUp1()
    {
        this.ModifyHotNSpicyPointsCollected(val:  1, isAbsoluteValue:  false);
    }
    public void HotNSpicyPtsCollectUp10()
    {
        this.ModifyHotNSpicyPointsCollected(val:  10, isAbsoluteValue:  false);
    }
    public void HotNSpicyPtsCollectUp100()
    {
        this.ModifyHotNSpicyPointsCollected(val:  100, isAbsoluteValue:  false);
    }
    public void HotNSpicyPtsCollectDown1()
    {
        this.ModifyHotNSpicyPointsCollected(val:  0, isAbsoluteValue:  false);
    }
    public void HotNSpicyPtsCollectDown10()
    {
        this.ModifyHotNSpicyPointsCollected(val:  9, isAbsoluteValue:  false);
    }
    public void HotNSpicyPtsCollectDown100()
    {
        this.ModifyHotNSpicyPointsCollected(val:  99, isAbsoluteValue:  false);
    }
    public void HotNSpicySkipToAlmostCurrentRewardPtsReq()
    {
        if((HotNSpicyEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        HotNSpicyEventHandler.<Instance>k__BackingField + 12.ModifyHotNSpicyPointsCollected(val:  (HotNSpicyEventHandler.<Instance>k__BackingField + 12) - 1, isAbsoluteValue:  true);
    }
    public void HotNSpicySkipToAlmostFinalRewardPtsReq()
    {
        HotNSpicyEcon val_5;
        if((HotNSpicyEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        RESEventRewardData val_1 = HotNSpicyEventHandler.<Instance>k__BackingField.GetFinalPrize();
        if((HotNSpicyEventHandler.<Instance>k__BackingField) != 0)
        {
                val_5 = mem[HotNSpicyEventHandler.<Instance>k__BackingField + 16];
            val_5 = HotNSpicyEventHandler.<Instance>k__BackingField.econ;
        }
        else
        {
                val_5 = mem[HotNSpicyEventHandler.<Instance>k__BackingField + 16];
            val_5 = HotNSpicyEventHandler.<Instance>k__BackingField.econ;
        }
        
        int val_5 = HotNSpicyEventHandler.<Instance>k__BackingField.PlayerTier;
        int val_3 = GetTotalCollectableRewards(playerTier:  val_5);
        val_5 = val_3 - 1;
        val_3.ModifyHotNSpicyEventLevel(val:  val_5, isAbsoluteValue:  true);
        HotNSpicyEventHandler.<Instance>k__BackingField + 12.ModifyHotNSpicyPointsCollected(val:  (HotNSpicyEventHandler.<Instance>k__BackingField + 12) - 1, isAbsoluteValue:  true);
    }
    public void ResetHotNSpicy()
    {
        var val_1 = 21767093;
        val_1 = 13858448 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if((HotNSpicyEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        HotNSpicyEventHandler.<Instance>k__BackingField.ResetEventProgress();
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        HotNSpicyEventHandler.<Instance>k__BackingField.UpdateProgressToServer();
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -870702160);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -870702048);
        SROptions_GameEvents_RRV.NotifyPropertyChanged(propertyName:  -870701920);
    }
    private string get_EventExpireCountdown()
    {
        System.TimeSpan val_5;
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGEventHandler val_2 = GetOrderedEventHandlersByIndex(index:  0);
        this.activeEvent = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        if((public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance()) == 0)
        {
                return;
        }
        
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512327883720}, d2:  new System.DateTime());
        this.eventSpan = val_5;
        mem[1152921512327895804] = val_6;
        string val_8 = this.eventSpan.Days.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        string val_10 = this.eventSpan.Hours.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        string val_12 = this.eventSpan.Minutes.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        string val_14 = this.eventSpan.Seconds.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_1C = ;
        string val_15 = System.String.Format(format:  -877122512, args:  472754880);
    }
    public string GetCurrentEventInfo()
    {
        var val_11;
        string val_12;
        float val_1 = UnityEngine.Time.deltaTime;
        uint val_11 = 0;
        val_11 = this.calcTime + val_11;
        this.calcTime = val_11;
        if((System.String.IsNullOrEmpty(value:  this.lastCachedInfo)) != false)
        {
                this.lastCachedInfo = "";
            System.Text.StringBuilder val_3 = new System.Text.StringBuilder();
            string val_4 = this.EventExpireCountdown;
            string val_5 = System.String.Format(format:  -877006288, arg0:  -868761504);
            System.Text.StringBuilder val_6 = Append(value:  -877006288);
            if(this.activeEvent != 0)
        {
                string val_7 = this.activeEvent.EventType;
            val_11 = this.activeEvent;
        }
        else
        {
                val_11 = "null";
        }
        
            string val_8 = System.String.Format(format:  -877006128, arg0:  1295406352);
            if(val_3 != 0)
        {
                System.Text.StringBuilder val_9 = Append(value:  -877006128);
        }
        else
        {
                System.Text.StringBuilder val_10 = Append(value:  -877006128);
        }
        
            val_12 = val_3;
            this.calcTime = 0f;
            return;
        }
        
        val_12 = this.lastCachedInfo;
    }
    public SROptions_GameEvents_RRV()
    {
        this.lastCachedInfo = "";
    }

}
