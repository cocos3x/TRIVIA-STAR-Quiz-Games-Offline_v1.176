using UnityEngine;
public class WFOHackBehavior : HackBehavior
{
    // Methods
    public override SROptions GetGameSpecificSROptions()
    {
        return SuperLuckySROptionsParent<System.Object>.Instance;
    }
    public override void Hack_RestartLevel()
    {
        var val_13;
        var val_14;
        var val_15;
        int val_16;
        var val_17;
        var val_18;
        var val_19;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        GameLevel val_2 = PlayingLevel.GetLevel(currentMode:  0, parameters:  0);
        val_13 = 1;
        goto label_3;
        label_14:
        System.Text.StringBuilder val_3 = null;
        val_14 = 0;
        val_3 = new System.Text.StringBuilder();
        goto label_4;
        label_9:
        System.Text.StringBuilder val_4 = Append(value:  '0');
        val_14 = 1;
        label_4:
        if(0 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_13 = 0;
        val_13 = val_13 + 4;
        if(val_14 < ((0 + 4) + 16 + 8))
        {
            goto label_9;
        }
        
        val_15 = 0;
        val_16 = val_3;
        val_15.set_Item(index:  1, value:  24121344);
        val_13 = 2;
        label_3:
        if(val_13 < 0)
        {
            goto label_14;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
            goto label_18;
        }
        
        val_17 = null;
        val_18 = "dailychallenge";
        goto label_19;
        label_18:
        val_15 = 0;
        if(CategoryPacksManager.IsPlaying == false)
        {
            goto label_22;
        }
        
        val_17 = null;
        val_18 = "categorylevels";
        label_19:
        Prefs.SetExtraWordsEvents(gameType:  -2094123824, extraWords:  477709520);
        goto label_23;
        label_22:
        val_16 = Prefs.currentLevel;
        Prefs.SetExtraWords(world:  Prefs.currentWorld, subWorld:  Prefs.currentChapter, level:  val_16, extraWords:  477709520);
        label_23:
        SRDebugger.Services.IDebugService val_11 = SRDebug.Instance;
        var val_14 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_25;
        }
        
        val_15 = 0;
        label_27:
        val_16 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_26;
        }
        
        val_15 = val_15 + 1;
        val_16 = (uint)val_15 & 65535;
        if(val_16 < mem[1179403825])
        {
            goto label_27;
        }
        
        label_25:
        val_19 = 0;
        goto label_28;
        label_26:
        var val_12 = mem[1179403735] + 0;
        val_14 = val_14 + (((mem[1179403735] + 0) + 4) << 3);
        val_19 = val_14 + 268;
        label_28:
        CUtils.ReloadScene(useScreenFader:  false);
    }
    public override void Hack_CompleteLevelBehavior()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        WordRegion val_1 = WordRegion.instance;
        val_12 = 1152921504765685760;
        if(0 == 0)
        {
                return;
        }
        
        MainController val_3 = MainController.instance;
        if(0 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
            goto label_14;
        }
        
        val_13 = 0;
        WordRegion val_8 = WordRegion.instance;
        if(0 == 0)
        {
            goto label_17;
        }
        
        val_14 = null;
        val_14 = null;
        val_13 = 0;
        if(((mem[1179403747] + (WGDailyChallengeWordRegion.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_14)
        {
                0 = 0;
        }
        
        val_13 = 0;
        goto label_21;
        label_14:
        WordRegion val_9 = WordRegion.instance;
        if(0 != 0)
        {
            goto label_25;
        }
        
        goto label_25;
        label_17:
        label_21:
        val_13.Hack_CompleteLevel();
        label_25:
        SRDebugger.Services.IDebugService val_10 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_27;
        }
        
        val_12 = 0;
        label_29:
        if((mem[1179403735] + 0) == null)
        {
            goto label_28;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < mem[1179403825])
        {
            goto label_29;
        }
        
        label_27:
        val_15 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_28:
        var val_11 = mem[1179403735] + 0;
        var val_12 = (mem[1179403735] + 0) + 4;
        val_12 = 1179403647 + (val_12 << 3);
        val_15 = val_12 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public override void Hack_CompleteChapterBehavior()
    {
        MainController val_1 = MainController.instance;
        0.Hack_SetLevelToLastLevelOfChapter();
        goto typeof(WFOHackBehavior).__il2cppRuntimeField_EC;
    }
    public override void AppendGameLevelInfo(ref System.Text.StringBuilder builder)
    {
        var val_19;
        MainController val_1 = MainController.instance;
        if(0 == 0)
        {
                val_19 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_19 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_19 == 1)
        {
                val_19 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_19 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            System.Text.StringBuilder val_3 = builder.AppendFormat(format:  -731768576, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return;
        }
        
        GameLevel val_4 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
        System.Text.StringBuilder val_5 = builder.AppendFormat(format:  -731768448, arg0:  52);
        System.Text.StringBuilder val_6 = builder.AppendFormat(format:  -731768320, arg0:  1835037);
        System.Text.StringBuilder val_7 = builder.AppendFormat(format:  -731768176, arg0:  6);
        System.Text.StringBuilder val_8 = builder.AppendFormat(format:  -713473168, arg0:  52);
        string val_9 = MiniJSON.Json.Serialize(obj:  5);
        System.Text.StringBuilder val_10 = builder.AppendFormat(format:  -713473024, arg0:  5);
        string val_11 = MiniJSON.Json.Serialize(obj:  4096);
        System.Text.StringBuilder val_12 = builder.AppendFormat(format:  -713472880, arg0:  4096);
        string val_13 = MiniJSON.Json.Serialize(obj:  1);
        System.Text.StringBuilder val_14 = builder.AppendFormat(format:  -713472736, arg0:  1);
        string val_15 = MiniJSON.Json.Serialize(obj:  33449456);
        System.Text.StringBuilder val_16 = builder.AppendFormat(format:  -713472592, arg0:  33449456);
        string val_17 = MiniJSON.Json.Serialize(obj:  33453552);
        System.Text.StringBuilder val_18 = builder.AppendFormat(format:  -706045632, arg0:  33453552);
    }
    public override void ResetPlayer()
    {
        var val_15;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_18.ResetForest();
        WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
        if(0 != 0)
        {
                val_15 = 0;
            mem[328] = 1;
        }
        else
        {
                val_15 = 328;
            mem[328] = 1;
        }
        
        mem[308] = 0;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem[344] = new WordForest.Map(initialAreaItems:  80883712);
        GameBehavior val_5 = App.getBehavior;
        0.acorns = 0;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Nullable<System.Int32> val_7 = new System.Nullable<System.Int32>(value:  1);
        System.Nullable<System.Int32> val_9 = new System.Nullable<System.Int32>(value:  0.acorns);
        System.Nullable<System.Int32> val_10 = new System.Nullable<System.Int32>(value:  0);
        public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_18.SetForestProfile(forestLevel:  new System.Nullable<System.Int32>() {HasValue = val_7.HasValue}, map:  0, acorns:  new System.Nullable<System.Int32>() {HasValue = false}, shields:  new System.Nullable<System.Int32>() {HasValue = val_9.HasValue}, fbid:  val_9.HasValue, responseCallback:  0);
        NotificationCenter val_11 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2092882624);
        SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
        if(0 == 0)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_14 = SLC.Social.Leagues.LeaguesManager.DAO;
        0.UpdateLocalProfile();
    }
    public WFOHackBehavior()
    {
    
    }

}
