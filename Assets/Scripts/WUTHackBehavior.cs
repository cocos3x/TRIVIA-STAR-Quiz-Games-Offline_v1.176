using UnityEngine;
public class WUTHackBehavior : HackBehavior
{
    // Methods
    public override void Hack_RestartLevel()
    {
        CUtils.ReloadScene(useScreenFader:  false);
    }
    public override SROptions GetGameSpecificSROptions()
    {
        return SuperLuckySROptionsParent<System.Object>.Instance;
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
        goto typeof(WUTHackBehavior).__il2cppRuntimeField_EC;
    }
    public override void AppendGameLevelInfo(ref System.Text.StringBuilder builder)
    {
        var val_32;
        var val_33;
        var val_34;
        MainController val_1 = MainController.instance;
        if(0 == 0)
        {
                val_32 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_32 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_32 == 1)
        {
                val_32 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_32 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            System.Text.StringBuilder val_3 = builder.AppendFormat(format:  -731768576, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return;
        }
        
        MainController val_4 = MainController.instance;
        val_33 = 1;
        if(CategoryPacksManager.IsPlaying != false)
        {
                GameLevel val_6 = PlayingLevel.GetCategoryLevel(categoryPackId:  0);
            val_33 = 0;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_34 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
            string val_9 = GetWordFromPack(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        }
        else
        {
                val_34 = 100670464;
            string val_10 = val_34.Replace(oldValue:  -2100450224, newValue:  1098586544);
        }
        
        System.Text.StringBuilder val_11 = builder.AppendFormat(format:  -713473296, arg0:  100670464);
        System.Text.StringBuilder val_12 = builder.AppendFormat(format:  -731768448, arg0:  872415232);
        System.Text.StringBuilder val_13 = builder.AppendFormat(format:  -731768320, arg0:  100670464);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_14 = 872415232.Split(separator:  478563824);
        string val_15 = MiniJSON.Json.Serialize(obj:  872415232);
        System.Text.StringBuilder val_16 = builder.AppendFormat(format:  -731768176, arg0:  872415232);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_17 = 67108864.Split(separator:  478563824);
        string val_18 = MiniJSON.Json.Serialize(obj:  67108864);
        System.Text.StringBuilder val_19 = builder.AppendFormat(format:  -696871440, arg0:  67108864);
        System.Text.StringBuilder val_20 = builder.AppendFormat(format:  -696871296, arg0:  16777216);
        System.Text.StringBuilder val_21 = builder.AppendFormat(format:  -731768032, arg0:  872415232);
        System.Text.StringBuilder val_22 = builder.AppendFormat(format:  -696871136, arg0:  0);
        System.Text.StringBuilder val_23 = builder.AppendFormat(format:  -696870960, arg0:  13152256, arg1:  0);
        string val_24 = MiniJSON.Json.Serialize(obj:  -1207959552);
        System.Text.StringBuilder val_25 = builder.AppendFormat(format:  -696870704, arg0:  -1207959552);
        string val_26 = MiniJSON.Json.Serialize(obj:  -1207828904);
        System.Text.StringBuilder val_27 = builder.AppendFormat(format:  -696870560, arg0:  -1207828904);
        string val_28 = MiniJSON.Json.Serialize(obj:  84016728);
        System.Text.StringBuilder val_29 = builder.AppendFormat(format:  -696870400, arg0:  84016728);
        System.Text.StringBuilder val_30 = builder.AppendFormat(format:  -731767712, arg0:  15282176);
        System.Text.StringBuilder val_31 = builder.AppendFormat(format:  -713472128, arg0:  8945664);
    }
    public WUTHackBehavior()
    {
    
    }

}
