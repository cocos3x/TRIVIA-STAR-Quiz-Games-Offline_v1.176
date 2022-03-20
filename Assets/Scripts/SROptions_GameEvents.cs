using UnityEngine;
public class SROptions_GameEvents : SuperLuckySROptionsParent<SROptions_GameEvents>, INotifyPropertyChanged
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
    public string KeyToRichesKeyWord { get; }
    public int KeyToRichesKeyCount { get; set; }
    public bool KeyToRichesShowKeyEveryLevel { get; set; }
    public bool KeyToRichesShowChestContent { get; set; }
    public int KeyToRichesLevelsCounter { get; set; }
    public bool GuaranteeNumber { get; set; }
    public string ShowPiggyRaidPool { get; }
    public bool ShowPiggyRaidTileEveryLevel { get; set; }
    public bool MakeNextAddPiggyAmountExact { get; set; }
    public string DiceRolls { get; }
    public string YouBetchaConsecutiveDismissial { get; }
    public string lbMultiplier { get; }
    public bool FreeSpins { get; set; }
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
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -887880896);
    }
    public void CurrentEventInfoHud()
    {
        var val_4;
        var val_5;
        System.Func<System.String> val_7;
        var val_8;
        val_4 = 1152921504946675712;
        val_5 = null;
        val_5 = null;
        val_7 = SROptions_GameEvents.<>c.<>9__7_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<TRVQuizProgress>(object:  SROptions_GameEvents.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3407198512));
            SROptions_GameEvents.<>c.<>9__7_0 = val_7;
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
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelUp10()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  5);
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelUp100()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  100);
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelDown1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  0);
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelDown10()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  4);
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void PlayerLevelDown100()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  99);
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public void CompletePuzzle()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1306771664) == 0)
        {
                return;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_3 = System.Linq.Enumerable.Repeat<System.Int32>(element:  1, count:  16);
        TSource[] val_4 = System.Linq.Enumerable.ToArray<System.Int32>(source:  1);
        PuzzleCollectionHandler.CurrentPuzzleProgress = 1;
        PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.HackPuzzleSolution();
    }
    public void CheckPuzzlePoolHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3408207648));
        SLCHUDWindow.SetupHUD(name:  -886758624, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_4;
        }
        
        var val_5 = 0;
        label_6:
        if((mem[1179403735] + 0) == null)
        {
            goto label_5;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < mem[1179403825])
        {
            goto label_6;
        }
        
        label_4:
        val_5 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_5:
        var val_4 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_5 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void AddCrowns5000()
    {
        if(ClubClashEvent.LAST_PROGRESS_STAMP_KEY != null)
        {
                ClubClashEvent.LAST_PROGRESS_STAMP_KEY.AddHackedCrowns(crowns:  5000);
        }
        
        var val_1 = 24869423;
        val_1 = 10760576 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY == null)
        {
                return;
        }
        
        PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.AddHackedCrowns(crowns:  5000);
    }
    public void AddCrowns50k()
    {
        if(ClubClashEvent.LAST_PROGRESS_STAMP_KEY != null)
        {
                ClubClashEvent.LAST_PROGRESS_STAMP_KEY.AddHackedCrowns(crowns:  50000);
        }
        
        var val_1 = 24869215;
        val_1 = 10760784 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY == null)
        {
                return;
        }
        
        PvpCrownClashEvent.LAST_PROGRESS_STAMP_KEY.AddHackedCrowns(crowns:  50000);
    }
    public void AddOneGoldenApple()
    {
        this.AddGoldenApples(amount:  1);
    }
    public void SubtractOneGoldenApple()
    {
        this.AddGoldenApples(amount:  0);
    }
    public void AddTenGoldenApples()
    {
        this.AddGoldenApples(amount:  10);
    }
    public void SubtractTenGoldenApples()
    {
        this.AddGoldenApples(amount:  9);
    }
    private void AddGoldenApples(int amount)
    {
        var val_1;
        var val_1 = 24866420;
        val_1 = 10761004 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        LeaderboardEventHandler.instance.UpdateProgressionToServer(progress:  amount, rewarded:  false);
    }
    public void PiggyBankInfoHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3409104784));
        SLCHUDWindow.SetupHUD(name:  -885861488, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_4;
        }
        
        var val_5 = 0;
        label_6:
        if((mem[1179403735] + 0) == null)
        {
            goto label_5;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < mem[1179403825])
        {
            goto label_6;
        }
        
        label_4:
        val_5 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_5:
        var val_4 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_5 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void ReInitPiggyBank()
    {
        var val_1 = 24866356;
        val_1 = 10761596 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankHandler.iapHigh != null)
        {
                PiggyBankHandler.iapHigh.HackReInit();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void ResetPiggyBankEvent()
    {
        var val_1 = 24866128;
        val_1 = 10761824 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankHandler.iapHigh != null)
        {
                PiggyBankHandler.iapHigh.HackResetProgress();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void SetPiggyBankAlmostReady()
    {
        var val_1 = 24865900;
        val_1 = 10762052 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankHandler.iapHigh != null)
        {
                PiggyBankHandler.iapHigh.HackSetBundleAlmostReady();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void SetPiggyBankReady()
    {
        var val_1 = 24865672;
        val_1 = 10762280 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankHandler.iapHigh != null)
        {
                PiggyBankHandler.iapHigh.HackSetBundleReady();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void ResetPiggyBankPromptCooldown()
    {
        var val_1 = 24865444;
        val_1 = 10762508 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankHandler.iapHigh != null)
        {
                PiggyBankHandler.iapHigh.HackResetPromptCooldown();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void SetPiggyBankExpire1Minute()
    {
        var val_1 = 24865216;
        val_1 = 10762736 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankHandler.iapHigh != null)
        {
                PiggyBankHandler.iapHigh.HackSetExpire1Minute();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void ResetPiggyBankFeatureCooldown()
    {
        PiggyBankHandler.HackResetFeatureCooldown();
    }
    public void ResetLastPurchaseCooldown()
    {
        PiggyBankHandler.HackIgnoreLastPurchaseDate();
    }
    public void PiggyBankV2InfoHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3410114096));
        SLCHUDWindow.SetupHUD(name:  -885861488, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_4;
        }
        
        var val_5 = 0;
        label_6:
        if((mem[1179403735] + 0) == null)
        {
            goto label_5;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < mem[1179403825])
        {
            goto label_6;
        }
        
        label_4:
        val_5 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_5:
        var val_4 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_5 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void ReInitPiggyBankV2()
    {
        var val_1 = 24867825;
        val_1 = 10763352 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankV2Handler.minDowngradeTier != 0)
        {
                PiggyBankV2Handler.minDowngradeTier.HackReInit();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void ResetPiggyBankV2Event()
    {
        var val_1 = 24867597;
        val_1 = 10763580 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankV2Handler.minDowngradeTier != 0)
        {
                PiggyBankV2Handler.minDowngradeTier.HackResetProgress();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void SetPiggyBankV2AlmostFull()
    {
        var val_1 = 24867369;
        val_1 = 10763808 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankV2Handler.minDowngradeTier != 0)
        {
                PiggyBankV2Handler.minDowngradeTier.HackSetBankAlmostFull();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void SetPiggyBankV2Ready()
    {
        var val_1 = 24867141;
        val_1 = 10764036 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankV2Handler.minDowngradeTier != 0)
        {
                PiggyBankV2Handler.minDowngradeTier.HackSetBundleReady();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void ResetPiggyBankV2PromptCooldown()
    {
        var val_1 = 24866913;
        val_1 = 10764264 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankV2Handler.minDowngradeTier != 0)
        {
                PiggyBankV2Handler.minDowngradeTier.HackResetPromptCooldown();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void SetPiggyBankV2Expire1Minute()
    {
        var val_1 = 24866685;
        val_1 = 10764492 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PiggyBankV2Handler.minDowngradeTier != 0)
        {
                PiggyBankV2Handler.minDowngradeTier.HackSetExpire1Minute();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -885749376);
    }
    public void ResetPiggyBankV2FeatureCooldown()
    {
        PiggyBankV2Handler.HackResetFeatureCooldown();
    }
    public void ResetLastPurchaseCooldownV2()
    {
        PiggyBankV2Handler.HackIgnoreLastPurchaseDate();
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
    public void ResetLightningWordsEventProgress()
    {
        if(LightningWordsHandler.DEFAULT_REWARD_VALUE == 0)
        {
                return;
        }
        
        LightningWordsHandler.DEFAULT_REWARD_VALUE.Hack_ResetLightningWordsEventProgress();
    }
    public string get_KeyToRichesKeyWord()
    {
        var val_1 = 24864490;
        val_1 = 10765060 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return;
        }
        
        return KeyToRichesEventHandler._Instance.KeyWord;
    }
    public void KeyToRichesGrantKeyWord()
    {
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return;
        }
        
        KeyToRichesEventHandler._Instance.GrantKeyWord();
    }
    public int get_KeyToRichesKeyCount()
    {
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return 0;
        }
        
        return KeyToRichesEventHandler._Instance.HackKeyCount;
    }
    public void set_KeyToRichesKeyCount(int value)
    {
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return;
        }
        
        KeyToRichesEventHandler._Instance.HackKeyCount = value;
    }
    public bool get_KeyToRichesShowKeyEveryLevel()
    {
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return false;
        }
        
        if((KeyToRichesEventHandler._Instance.<HackShowKeyEveryLevel>k__BackingField) == true)
        {
                KeyToRichesEventHandler._Instance.<HackShowKeyEveryLevel>k__BackingField = 1;
        }
        
        return true;
    }
    public void set_KeyToRichesShowKeyEveryLevel(bool value)
    {
        if(KeyToRichesEventHandler._Instance != 0)
        {
                KeyToRichesEventHandler._Instance.<HackShowKeyEveryLevel>k__BackingField = value;
        }
    
    }
    public bool get_KeyToRichesShowChestContent()
    {
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return false;
        }
        
        if(KeyToRichesEventHandler._Instance.showChestContent == true)
        {
                KeyToRichesEventHandler._Instance.showChestContent = 1;
        }
        
        return true;
    }
    public void set_KeyToRichesShowChestContent(bool value)
    {
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return;
        }
        
        KeyToRichesEventHandler._Instance.ShowChestContent = value;
    }
    public int get_KeyToRichesLevelsCounter()
    {
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return 0;
        }
        
        return KeyToRichesEventHandler._Instance.HackLevelsCounter;
    }
    public void set_KeyToRichesLevelsCounter(int value)
    {
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return;
        }
        
        KeyToRichesEventHandler._Instance.HackLevelsCounter = value;
    }
    public void KeyToRichesLevelMinus10()
    {
        var val_1 = 24863302;
        val_1 = 10766248 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return;
        }
        
        KeyToRichesEventHandler._Instance.LevelsCounterMinus10();
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -882388176);
    }
    public void KeyToRichesComplete10Levels()
    {
        var val_1 = 24863122;
        val_1 = 10766428 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(KeyToRichesEventHandler._Instance == 0)
        {
                return;
        }
        
        KeyToRichesEventHandler._Instance.LevelsCounterPlus10();
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -882388176);
    }
    public bool get_GuaranteeNumber()
    {
        if((BingoEventHandler.<Instance>k__BackingField) == 0)
        {
                return false;
        }
        
        if((BingoEventHandler.<Instance>k__BackingField.<HackGuaranteeNumber>k__BackingField) == true)
        {
                BingoEventHandler.<Instance>k__BackingField.<HackGuaranteeNumber>k__BackingField = 1;
        }
        
        return true;
    }
    public void set_GuaranteeNumber(bool value)
    {
        if((BingoEventHandler.<Instance>k__BackingField) != 0)
        {
                BingoEventHandler.<Instance>k__BackingField.<HackGuaranteeNumber>k__BackingField = value;
        }
    
    }
    public void GrantBingo()
    {
        if((BingoEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        BingoEventHandler.<Instance>k__BackingField.HACKGrantBingo();
    }
    public void GrantAllBalls()
    {
        if((BingoEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        BingoEventHandler.<Instance>k__BackingField.HACKGrantAllBalls();
    }
    public string get_ShowPiggyRaidPool()
    {
        var val_1;
        var val_2;
        var val_1 = 24866100;
        val_1 = 10767080 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField) != 0)
        {
                return PiggyBankRaidEventHandler.<Instance>k__BackingField.QA_RaidPoolIds;
        }
        
        return PiggyBankRaidEventHandler.<Instance>k__BackingField.QA_RaidPoolIds;
    }
    public bool get_ShowPiggyRaidTileEveryLevel()
    {
        var val_1;
        var val_2;
        var val_1 = 24865724;
        val_1 = 10767456 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField) == 0)
        {
                return false;
        }
        
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField.<QA_LevelBufferHack>k__BackingField) == true)
        {
                PiggyBankRaidEventHandler.<Instance>k__BackingField.<QA_LevelBufferHack>k__BackingField = 1;
        }
        
        return true;
    }
    public void set_ShowPiggyRaidTileEveryLevel(bool value)
    {
        var val_1;
        var val_2;
        var val_1 = 24865364;
        val_1 = 10767816 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        PiggyBankRaidEventHandler.<Instance>k__BackingField.<QA_LevelBufferHack>k__BackingField = value;
    }
    public void SetPiggyBankAlmostFull()
    {
        int val_4;
        var val_5;
        decimal val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_5 = 1152921504935813120;
        val_6 = 10768160 + 24865020;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        int val_1 = PiggyBankRaidEventHandler.<Instance>k__BackingField.PiggyBankLevel;
        decimal val_2 = Item[-1406235440];
        val_10 = null;
        val_10 = null;
        val_6 = System.Decimal.One;
        decimal val_3 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -881368112}, d2:  new System.Decimal() {hi = val_6, lo = System.Decimal.Powers10.__il2cppRuntimeField_18, mid = System.Decimal.Powers10.__il2cppRuntimeField_1C});
        PiggyBankRaidEventHandler.<Instance>k__BackingField.PiggyBankCoins = new System.Decimal() {mid = val_4};
    }
    public bool get_MakeNextAddPiggyAmountExact()
    {
        var val_1;
        var val_2;
        var val_1 = public System.IAsyncResult System.Func<System.Object, System.DateTime>::BeginInvoke(System.Object arg, System.AsyncCallback callback, object object);
        val_1 = 10768916 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField) == 0)
        {
                return false;
        }
        
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField.<QA_NextPiggyCreditFillExactlyMax>k__BackingField) == true)
        {
                PiggyBankRaidEventHandler.<Instance>k__BackingField.<QA_NextPiggyCreditFillExactlyMax>k__BackingField = 1;
        }
        
        return true;
    }
    public void set_MakeNextAddPiggyAmountExact(bool value)
    {
        var val_1;
        var val_2;
        var val_1 = 24863904;
        val_1 = 10769276 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        PiggyBankRaidEventHandler.<Instance>k__BackingField.<QA_NextPiggyCreditFillExactlyMax>k__BackingField = value;
    }
    public void ShowMyselfHUD()
    {
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_34 = 24863552;
        val_34 = 10769628 + val_34;
        if(val_34 == 0)
        {
                mem2[0] = 1;
        }
        
        val_34 = null;
        val_34 = null;
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if(val_34 == 0)
        {
                mem2[0] = 1;
        }
        
        val_35 = null;
        val_35 = null;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_3 = 0.MyProfile;
        string val_4 = -881044048(-881044048) + null;
        System.Text.StringBuilder val_5 = AppendLine(value:  -881044048);
        int val_6 = PiggyBankRaidEventHandler.<Instance>k__BackingField.PiggyBankLevel;
        string val_7 = -881043952(-881043952) + 13152256;
        System.Text.StringBuilder val_8 = AppendLine(value:  -881043952);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "Piggy Bank Coins: ";
        decimal val_9 = PiggyBankCoins;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = "/";
        int val_10 = PiggyBankRaidEventHandler.<Instance>k__BackingField.PiggyBankLevel;
        decimal val_11 = Item[-1406235440];
        val_36 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = val_36;
        string val_12 = +472754880;
        System.Text.StringBuilder val_13 = AppendLine(value:  472754880);
        string val_14 = -881043728(-881043728) + 10170368;
        System.Text.StringBuilder val_15 = AppendLine(value:  -881043728);
        string val_17 = PiggyBankRaidEventHandler.<Instance>k__BackingField.IsEventCompleted().ToString();
        string val_18 = -881043616(-881043616) + -881031205(-881031205);
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_19 = AppendLine(value:  -881043616);
        }
        else
        {
                System.Text.StringBuilder val_20 = AppendLine(value:  -881043616);
        }
        
        System.Text.StringBuilder val_21 = AppendLine();
        string val_22 = PrettyPrint.printJSON(obj:  78753792, types:  false, singleLineOutput:  false);
        string val_23 = -881043504(-881043504) + 78753792;
        val_37 = "<b>Last Server Payload:</b>\n";
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_24 = AppendLine(value:  -881043504);
            System.Text.StringBuilder val_25 = AppendLine();
        }
        else
        {
                System.Text.StringBuilder val_26 = AppendLine(value:  -881043504);
            System.Text.StringBuilder val_27 = AppendLine();
        }
        
        System.Text.StringBuilder val_28 = AppendLine(value:  -881043376);
        string val_29 = PiggyBankRaidEventHandler.<Instance>k__BackingField.GetCoinLog();
        System.Text.StringBuilder val_30 = AppendLine(value:  PiggyBankRaidEventHandler.<Instance>k__BackingField);
        System.Func<TRVQuizProgress> val_31 = new System.Func<TRVQuizProgress>(object:  24121344, method:  mem[null + 216]);
        SLCHUDWindow.SetupHUD(name:  -881043264, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_32 = SRDebug.Instance;
        var val_35 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_48;
        }
        
        val_36 = 0;
        label_50:
        val_37 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_49;
        }
        
        val_36 = val_36 + 1;
        val_37 = (uint)val_36 & 65535;
        if(val_37 < mem[1179403825])
        {
            goto label_50;
        }
        
        label_48:
        val_38 = 0;
        return;
        label_49:
        var val_33 = mem[1179403735] + 0;
        val_35 = val_35 + (((mem[1179403735] + 0) + 4) << 3);
        val_38 = val_35 + 268;
    }
    public string get_DiceRolls()
    {
        var val_3 = 24854248;
        val_3 = 10771544 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        string val_2 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetDiceBalance().ToString();
    }
    public void DiceRollsUp1()
    {
        var val_1 = 24854052;
        val_1 = 10771740 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.RewardDiceRolls(amount:  1, source:  null);
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -880819168);
    }
    public void DiceRollsUp10()
    {
        var val_1 = 24853864;
        val_1 = 10771928 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.RewardDiceRolls(amount:  10, source:  null);
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -880819168);
    }
    public void DiceRollsDown1()
    {
        var val_1 = 24853676;
        val_1 = 10772116 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.RewardDiceRolls(amount:  0, source:  null);
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -880819168);
    }
    public void DiceRollsDown10()
    {
        var val_1 = 24853488;
        val_1 = 10772304 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.RewardDiceRolls(amount:  9, source:  null);
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -880819168);
    }
    public void SetBoard1()
    {
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.Hack_ShowBoard(boardIndex:  0);
    }
    public void SetBoard2()
    {
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.Hack_ShowBoard(boardIndex:  1);
    }
    public void SetBoard3()
    {
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.Hack_ShowBoard(boardIndex:  2);
    }
    public void SetBoard4()
    {
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.Hack_ShowBoard(boardIndex:  3);
    }
    public void SetBoard5()
    {
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.Hack_ShowBoard(boardIndex:  4);
    }
    public void SetBoardProgress80Percent()
    {
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SnakesAndLaddersEvent.Board val_1 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetCurrentBoard();
        float val_2 = (float)SnakesAndLaddersEventHandler.<Instance>k__BackingField + 8 + 8;
        val_2 = val_2 * 0.8f;
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.__unknownFiledOffset_C = val_2;
    }
    public void SeasonEventResetProgress()
    {
        if((SeasonPassEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        SeasonPassEventHandler.<Instance>k__BackingField.Hack_ResetProgress();
    }
    public string get_YouBetchaConsecutiveDismissial()
    {
        var val_4 = 24856376;
        val_4 = 10773364 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        if(TRVYouBetchaEventHandler.EVENT_TRACKING_ID == null)
        {
                return;
        }
        
        Player val_1 = App.Player;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        var val_5 = TRVYouBetchaEventHandler.EVENT_TRACKING_ID + 36;
        val_5 = 0 - val_5;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        string val_2 = TRVYouBetchaEventHandler.EVENT_TRACKING_ID + 32.ToString();
        string val_3 = System.String.Format(format:  -879587072, arg0:  13152256, arg1:  -879574812);
    }
    public void ResetYouBetcha()
    {
        var val_1 = 24855892;
        val_1 = 10773848 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        if(TRVYouBetchaEventHandler.EVENT_TRACKING_ID == null)
        {
                return;
        }
        
        TRVYouBetchaEventHandler.EVENT_TRACKING_ID.ResetEventProgress();
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -879474784);
    }
    public string get_lbMultiplier()
    {
        null = null;
        string val_1 = ToString();
        return System.String.Format(format:  -879362688, arg0:  320131080);
    }
    public void lbSet2x()
    {
        null = null;
        LetterBankEventHandler.hack_multiplier = 2;
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -879250608);
    }
    public void lbSet3x()
    {
        null = null;
        LetterBankEventHandler.hack_multiplier = 3;
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -879250608);
    }
    public void lbSet4x()
    {
        null = null;
        LetterBankEventHandler.hack_multiplier = 4;
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -879250608);
    }
    public void lbSet5x()
    {
        null = null;
        LetterBankEventHandler.hack_multiplier = 5;
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -879250608);
    }
    public void lbSet10x()
    {
        null = null;
        LetterBankEventHandler.hack_multiplier = 10;
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -879250608);
    }
    public void lbSet25x()
    {
        null = null;
        LetterBankEventHandler.hack_multiplier = 25;
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -879250608);
    }
    public void lbSet50x()
    {
        null = null;
        LetterBankEventHandler.hack_multiplier = 50;
        SROptions_GameEvents.NotifyPropertyChanged(propertyName:  -879250608);
    }
    public void None()
    {
        null = null;
        SpinKingSlotMachine.hackSpinType = 0;
    }
    public void Attack()
    {
        null = null;
        SpinKingSlotMachine.hackSpinType = 1;
    }
    public void AttackSuccess()
    {
        null = null;
        SpinKingSlotMachine.hackSpinType = 2;
    }
    public void AttackFailed()
    {
        null = null;
        SpinKingSlotMachine.hackSpinType = 3;
    }
    public void Raid()
    {
        null = null;
        SpinKingSlotMachine.hackSpinType = 4;
    }
    public void Shield()
    {
        null = null;
        SpinKingSlotMachine.hackSpinType = 5;
    }
    public void Spins()
    {
        null = null;
        SpinKingSlotMachine.hackSpinType = 6;
    }
    public void Bag3()
    {
        null = null;
        SpinKingSlotMachine.hackSpinType = 7;
    }
    public void Bag2()
    {
        null = null;
        SpinKingSlotMachine.hackSpinType = 8;
    }
    public void Bag1()
    {
        null = null;
        SpinKingSlotMachine.hackSpinType = 9;
    }
    public bool get_FreeSpins()
    {
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY != null)
        {
                return (bool)SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 24;
        }
        
        return (bool)SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 24;
    }
    public void set_FreeSpins(bool value)
    {
        SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.__unknownFiledOffset_18 = value;
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
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512319671128}, d2:  new System.DateTime());
        this.eventSpan = val_5;
        mem[1152921512319683212] = val_6;
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
            string val_5 = System.String.Format(format:  -877006288, arg0:  -876973824);
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
    public SROptions_GameEvents()
    {
        this.lastCachedInfo = "";
    }

}
