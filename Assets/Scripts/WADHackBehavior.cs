using UnityEngine;
public class WADHackBehavior : HackBehavior
{
    // Methods
    public override void Hack_RestartLevel()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        GameLevel val_2 = PlayingLevel.GetLevel(currentMode:  0, parameters:  0);
        val_7 = 1;
        goto label_3;
        label_14:
        System.Text.StringBuilder val_3 = null;
        val_8 = 0;
        val_3 = new System.Text.StringBuilder();
        goto label_4;
        label_9:
        System.Text.StringBuilder val_4 = Append(value:  '0');
        val_8 = 1;
        label_4:
        if(0 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = 0;
        val_7 = val_7 + 4;
        if(val_8 < ((0 + 4) + 16 + 8))
        {
            goto label_9;
        }
        
        val_9 = 0;
        val_10 = val_3;
        val_9.set_Item(index:  1, value:  24121344);
        val_7 = 2;
        label_3:
        if(val_7 < 0)
        {
            goto label_14;
        }
        
        SRDebugger.Services.IDebugService val_5 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_16;
        }
        
        val_9 = 0;
        label_18:
        val_10 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_17;
        }
        
        val_9 = val_9 + 1;
        val_10 = (uint)val_9 & 65535;
        if(val_10 < mem[1179403825])
        {
            goto label_18;
        }
        
        label_16:
        val_11 = 0;
        goto label_19;
        label_17:
        var val_6 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_11 = val_8 + 268;
        label_19:
        CUtils.ReloadScene(useScreenFader:  false);
    }
    public override void Hack_CompleteLevelBehavior()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_14 = 1152921504886931456;
        WordRegion val_1 = WordRegion.instance;
        val_15 = 1152921504765685760;
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
        
        val_16 = 0;
        WordRegion val_8 = WordRegion.instance;
        if(0 == 0)
        {
            goto label_17;
        }
        
        val_17 = null;
        val_17 = null;
        val_16 = 0;
        if(((mem[1179403747] + (WGDailyChallengeWordRegion.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_17)
        {
                0 = 0;
        }
        
        val_16 = 0;
        goto label_21;
        label_14:
        WordRegion val_9 = WordRegion.instance;
        WordRegion val_10 = WordRegion.instance;
        0.ClearLevelProgress();
        MainController val_11 = MainController.instance;
        if(0 != 0)
        {
            goto label_29;
        }
        
        goto label_29;
        label_17:
        label_21:
        val_16.Hack_CompleteLevel();
        label_29:
        SRDebugger.Services.IDebugService val_12 = SRDebug.Instance;
        var val_14 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_31;
        }
        
        val_15 = 0;
        label_33:
        val_14 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_32;
        }
        
        val_15 = val_15 + 1;
        val_14 = (uint)val_15 & 65535;
        if(val_14 < mem[1179403825])
        {
            goto label_33;
        }
        
        label_31:
        val_18 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_32:
        var val_13 = mem[1179403735] + 0;
        val_14 = val_14 + (((mem[1179403735] + 0) + 4) << 3);
        val_18 = val_14 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public override void Hack_CompleteChapterBehavior()
    {
        MainController val_1 = MainController.instance;
        0.Hack_SetLevelToLastLevelOfChapter();
        goto typeof(WADHackBehavior).__il2cppRuntimeField_EC;
    }
    public override void AppendGameLevelInfo(ref System.Text.StringBuilder builder)
    {
        var val_28;
        var val_29;
        var val_30;
        MainController val_1 = MainController.instance;
        if(0 == 0)
        {
                val_28 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_28 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_28 == 1)
        {
                val_28 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_28 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            System.Text.StringBuilder val_3 = builder.AppendFormat(format:  -731768576, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return;
        }
        
        MainController val_4 = MainController.instance;
        val_29 = 1;
        if(CategoryPacksManager.IsPlaying != false)
        {
                GameLevel val_6 = PlayingLevel.GetCategoryLevel(categoryPackId:  0);
            val_29 = 0;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_30 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
            string val_9 = GetWordFromPack(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        }
        else
        {
                val_30 = 100670464;
            string val_10 = val_30.Replace(oldValue:  -2100450224, newValue:  1098586544);
        }
        
        System.Text.StringBuilder val_11 = builder.AppendFormat(format:  -713473296, arg0:  100670464);
        System.Text.StringBuilder val_12 = builder.AppendFormat(format:  -731768448, arg0:  872415232);
        System.Text.StringBuilder val_13 = builder.AppendFormat(format:  -731768320, arg0:  100670464);
        System.Text.StringBuilder val_14 = builder.AppendFormat(format:  -731768176, arg0:  872415232);
        System.Text.StringBuilder val_15 = builder.AppendFormat(format:  -713473168, arg0:  872415232);
        string val_16 = MiniJSON.Json.Serialize(obj:  0);
        System.Text.StringBuilder val_17 = builder.AppendFormat(format:  -713473024, arg0:  0);
        string val_18 = MiniJSON.Json.Serialize(obj:  16777232);
        System.Text.StringBuilder val_19 = builder.AppendFormat(format:  -713472880, arg0:  16777232);
        string val_20 = MiniJSON.Json.Serialize(obj:  -268435456);
        System.Text.StringBuilder val_21 = builder.AppendFormat(format:  -713472736, arg0:  -268435456);
        string val_22 = MiniJSON.Json.Serialize(obj:  -268304795);
        System.Text.StringBuilder val_23 = builder.AppendFormat(format:  -713472592, arg0:  -268304795);
        string val_24 = MiniJSON.Json.Serialize(obj:  -268304779);
        System.Text.StringBuilder val_25 = builder.AppendFormat(format:  -713472448, arg0:  -268304779);
        System.Text.StringBuilder val_26 = builder.AppendFormat(format:  -713472304, arg0:  15282176);
        System.Text.StringBuilder val_27 = builder.AppendFormat(format:  -713472128, arg0:  8945664);
    }
    public WADHackBehavior()
    {
    
    }

}
