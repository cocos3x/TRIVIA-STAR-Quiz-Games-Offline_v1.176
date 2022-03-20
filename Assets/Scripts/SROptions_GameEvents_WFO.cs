using UnityEngine;
public class SROptions_GameEvents_WFO : SuperLuckySROptionsParent<SROptions_GameEvents_WFO>, INotifyPropertyChanged
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
    public string IslandParadiseSymbolsRewardsCollected { get; }
    public string IslandParadiseSymbolsPtsCollected { get; }
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
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -887880896);
    }
    public void CurrentEventInfoHud()
    {
        var val_4;
        var val_5;
        System.Func<System.String> val_7;
        var val_8;
        val_4 = 1152921504946888704;
        val_5 = null;
        val_5 = null;
        val_7 = SROptions_GameEvents_WFO.<>c.<>9__7_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<TRVQuizProgress>(object:  SROptions_GameEvents_WFO.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3427323296));
            SROptions_GameEvents_WFO.<>c.<>9__7_0 = val_7;
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
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelUp10()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  5);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelUp100()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  100);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelDown1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  0);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelDown10()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  4);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelDown100()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  99);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public string get_AtkMadnessCurrentRewData()
    {
        var val_2 = 21764487;
        val_2 = 13863692 + val_2;
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
        var val_4 = 21764071;
        val_4 = 13864108 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        if((AttackMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_2 = AttackMadnessEventHandler.<Instance>k__BackingField.ProgressLevel.ToString();
        string val_3 = -874847024(-874847024) + -866622996(-866622996) + 1113431872;
    }
    private void ModifyAttackMadnessEventLevel(int val, bool isAbsoluteValue = False)
    {
        var val_3 = 21763823;
        val_3 = 13864356 + val_3;
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
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -874734912);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -874734800);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -874734672);
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
        var val_3 = 21763211;
        val_3 = 13864968 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((AttackMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_1 = AttackMadnessEventHandler.<Instance>k__BackingField.ToString();
        string val_2 = -874847024(-874847024) + -865950996(-865950996) + 1113431872;
    }
    private void ModifyAttackMadnessPointsCollected(int val, bool isAbsoluteValue = False)
    {
        bool val_3 = isAbsoluteValue;
        var val_3 = 21762955;
        val_3 = 13865224 + val_3;
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
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -874734912);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -874734800);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -874734672);
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
        var val_1 = 21761983;
        val_1 = 13866196 + val_1;
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
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -874734912);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -874734800);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -874734672);
    }
    public string get_RaidMadnessCurrentRewData()
    {
        var val_2 = 21763504;
        val_2 = 13866496 + val_2;
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
        var val_4 = 21763088;
        val_4 = 13866912 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        if((RaidMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_2 = RaidMadnessEventHandler.<Instance>k__BackingField.ProgressLevel.ToString();
        string val_3 = -874847024(-874847024) + -864606996(-864606996) + 1113431872;
    }
    private void ModifyRaidMadnessEventLevel(int val, bool isAbsoluteValue = False)
    {
        var val_3 = 21762840;
        val_3 = 13867160 + val_3;
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
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -872718544);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -872718416);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -872718288);
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
        var val_3 = 21762228;
        val_3 = 13867772 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((RaidMadnessEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_1 = RaidMadnessEventHandler.<Instance>k__BackingField.ToString();
        string val_2 = -874847024(-874847024) + -863934996(-863934996) + 1113431872;
    }
    private void ModifyRaidMadnessPointsCollected(int val, bool isAbsoluteValue = False)
    {
        bool val_3 = isAbsoluteValue;
        var val_3 = 21761972;
        val_3 = 13868028 + val_3;
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
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -872718544);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -872718416);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -872718288);
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
        var val_1 = 21761000;
        val_1 = 13869000 + val_1;
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
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -872718544);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -872718416);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -872718288);
    }
    public string get_IslandParadiseSymbolsRewardsCollected()
    {
        var val_3 = 21758872;
        val_3 = 13869308 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        string val_2 = IslandParadiseEventHandler._Instance.ProgressLevel.ToString();
    }
    public void IslandParadiseSymbolsRewardsCollectUp1()
    {
        var val_3 = 21758676;
        val_3 = 13869504 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        IslandParadiseEventHandler._Instance.HackProgressLevel(progress:  IslandParadiseEventHandler._Instance.ProgressLevel + 1);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862602976);
    }
    public void IslandParadiseSymbolsRewardsCollectUp10()
    {
        var val_3 = 21758412;
        val_3 = 13869768 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        IslandParadiseEventHandler._Instance.HackProgressLevel(progress:  IslandParadiseEventHandler._Instance.ProgressLevel + 10);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862602976);
    }
    public void IslandParadiseSymbolsRewardsCollectDown1()
    {
        var val_3 = 21758148;
        val_3 = 13870032 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        IslandParadiseEventHandler._Instance.HackProgressLevel(progress:  IslandParadiseEventHandler._Instance.ProgressLevel - 1);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862602976);
    }
    public void IslandParadiseSymbolsRewardsCollectDown10()
    {
        var val_3 = 21757884;
        val_3 = 13870296 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        IslandParadiseEventHandler._Instance.HackProgressLevel(progress:  IslandParadiseEventHandler._Instance.ProgressLevel - 10);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862602976);
    }
    public string get_IslandParadiseSymbolsPtsCollected()
    {
        var val_2 = 21757608;
        val_2 = 13870572 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        string val_1 = IslandParadiseEventHandler._Instance.ToString();
    }
    public void IslandParadiseSymbolsPtsCollectUp1()
    {
        var val_1 = 21757404;
        val_1 = 13870776 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        IslandParadiseEventHandler._Instance.HackPointsCollected(points:  typeof(IslandParadiseEventHandler).__il2cppRuntimeField_3C0);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862042832);
    }
    public void IslandParadiseSymbolsPtsCollectUp10()
    {
        var val_1 = 21757132;
        val_1 = 13871048 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        IslandParadiseEventHandler._Instance.HackPointsCollected(points:  typeof(IslandParadiseEventHandler).__il2cppRuntimeField_3C0);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862042832);
    }
    public void IslandParadiseSymbolsPtsCollectUp100()
    {
        var val_1 = 21756860;
        val_1 = 13871320 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        IslandParadiseEventHandler._Instance.HackPointsCollected(points:  typeof(IslandParadiseEventHandler).__il2cppRuntimeField_3C0);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862042832);
    }
    public void IslandParadiseSymbolsPtsCollectDown1()
    {
        var val_2 = 21756588;
        val_2 = 13871592 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        IslandParadiseEventHandler._Instance.HackPointsCollected(points:  IslandParadiseEventHandler._Instance - 1);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862042832);
    }
    public void IslandParadiseSymbolsPtsCollectDown10()
    {
        var val_2 = 21756316;
        val_2 = 13871864 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        IslandParadiseEventHandler._Instance.HackPointsCollected(points:  IslandParadiseEventHandler._Instance - 10);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862042832);
    }
    public void IslandParadiseSymbolsPtsCollectDown100()
    {
        var val_2 = 21756044;
        val_2 = 13872136 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        IslandParadiseEventHandler._Instance.HackPointsCollected(points:  IslandParadiseEventHandler._Instance - 100);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862042832);
    }
    public void ResetIslandParadiseSymbols()
    {
        var val_1 = 21755772;
        val_1 = 13872408 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(IslandParadiseEventHandler._Instance == 0)
        {
                return;
        }
        
        IslandParadiseEventHandler._Instance.ResetEventProgress();
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862602976);
        SROptions_GameEvents_WFO.NotifyPropertyChanged(propertyName:  -862042832);
    }
    public void SetWordHuntWords()
    {
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP == null)
        {
                return;
        }
        
        WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP.SetRequiredWordsAsCurrentExtraWords();
    }
    public void CollectWordHuntWord()
    {
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP == null)
        {
                return;
        }
        
        WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP.HackCollectSmallestWord();
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
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512335758824}, d2:  new System.DateTime());
        this.eventSpan = val_5;
        mem[1152921512335770908] = val_6;
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
            string val_5 = System.String.Format(format:  -877006288, arg0:  -860886400);
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
    public SROptions_GameEvents_WFO()
    {
        this.lastCachedInfo = "";
    }

}
