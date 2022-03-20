using UnityEngine;
public class BWYHackBehavior : HackBehavior
{
    // Methods
    public override SROptions GetGameSpecificSROptions()
    {
        return SuperLuckySROptionsParent<System.Object>.Instance;
    }
    public override void Hack_CompleteLevelBehavior()
    {
        var val_7;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
            goto label_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockPuzzleMagic.GameMode val_3 = CurrentGameMode;
        if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance()) != 2)
        {
            goto label_11;
        }
        
        BestBlocksPlayer val_4 = BestBlocksPlayer.Instance;
        if(0.IsFTUXGameLevels() == false)
        {
            goto label_11;
        }
        
        val_7 = "Hack usable only after completing FTUX levels.";
        goto label_14;
        label_5:
        val_7 = "Option works only in-game.";
        label_14:
        UnityEngine.Debug.Log(message:  -903446352);
        return;
        label_11:
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackGameOver(success:  true);
    }
    public override void Hack_CompleteChapterBehavior()
    {
        var val_12;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
            goto label_9;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockPuzzleMagic.GameMode val_3 = CurrentGameMode;
        if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance()) != 2)
        {
            goto label_9;
        }
        
        BestBlocksPlayer val_4 = BestBlocksPlayer.Instance;
        if(0.IsFTUXGameLevels() == false)
        {
            goto label_11;
        }
        
        val_12 = "Hack usable only after completing FTUX levels.";
        goto label_14;
        label_9:
        val_12 = "Option works only in-game for Challenge Mode.";
        label_14:
        UnityEngine.Debug.Log(message:  -774643264);
        return;
        label_11:
        GameBehavior val_6 = App.getBehavior;
        int val_7 = BlockPuzzleMagic.LevelManager.GetChapterIdFromPlayerLevel(playerLevel:  0);
        val_7 = val_7 + 1;
        GameBehavior val_9 = App.getBehavior;
        int val_10 = (BlockPuzzleMagic.LevelManager.GetLevelIdFromChapterId(chapterNum:  val_7)) - 1;
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackRefreshCurrentLevel();
        goto typeof(BWYHackBehavior).__il2cppRuntimeField_EC;
    }
    public override void Hack_RestartLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 2)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Restart();
            return;
        }
        
        UnityEngine.Debug.Log(message:  -903446352);
    }
    public override void AppendGameLevelInfo(ref System.Text.StringBuilder builder)
    {
        var val_38;
        var val_40;
        var val_41;
        var val_42;
        System.Predicate<BlockPuzzleMagic.LevelRef> val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        GameEcon val_1 = App.getGameEcon;
        Player val_2 = App.Player;
        if(0 != 0)
        {
                val_38 = 1261;
        }
        else
        {
                val_38 = 1261;
        }
        
        var val_3 = 0 + 1324;
        int val_4 = UnityEngine.Mathf.RoundToInt(f:  0f);
        var val_5 = 0 + 1316;
        var val_6 = 0 + 1328;
        int val_7 = UnityEngine.Mathf.RoundToInt(f:  0f);
        string val_8 = UnityEngine.PlayerPrefs.GetString(key:  -774415088, defaultValue:  -2141227328);
        object val_9 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -774415088);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        GameBehavior val_13 = App.getBehavior;
        WordPets.WPTDataParser val_14 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Text.StringBuilder val_15 = builder.AppendFormat(format:  -774413968, arg0:  13152256, arg1:  13152256);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        System.Text.StringBuilder val_16 = builder.AppendFormat(format:  -774413760, arg0:  464535552);
        BlockPuzzleMagic.BestBlocksGameEcon val_17 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        bool val_18 = 0.IsEasyMode();
        System.Text.StringBuilder val_19 = builder.AppendFormat(format:  -774413600, arg0:  8945664);
        val_40 = null;
        val_40 = null;
        System.Text.StringBuilder val_20 = builder.AppendFormat(format:  -774413472, arg0:  13152256);
        WordPets.WPTDataParser val_21 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_41 = 0;
        val_42 = null;
        val_42 = null;
        val_44 = BWYHackBehavior.<>c.<>9__4_0;
        if(val_44 == 0)
        {
                val_44 = null;
            val_44 = new System.Predicate<ZooTile>(object:  BWYHackBehavior.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3520553968));
            BWYHackBehavior.<>c.<>9__4_0 = val_44;
        }
        
        object val_23 = public static BlockPuzzleMagic.LevelManager MonoSingletonSelfGenerating<BlockPuzzleMagic.LevelManager>::get_Instance().__il2cppRuntimeField_C + 12.Find(match:  8040448);
        System.Text.StringBuilder val_24 = builder.AppendFormat(format:  -774410256, arg0:  13152256);
        System.Text.StringBuilder val_25 = builder.AppendLine();
        val_45 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_45 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_45 == 1)
        {
                val_45 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_45 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        System.Text.StringBuilder val_26 = builder.AppendFormat(format:  -774410128, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        System.Text.StringBuilder val_27 = builder.AppendFormat(format:  -774409920, arg0:  13152256, arg1:  13152256, arg2:  null);
        val_41 = 0;
        val_46 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_46 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_46 == 1)
        {
                val_46 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_46 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        System.Text.StringBuilder val_28 = builder.AppendFormat(format:  -774409696, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        System.Text.StringBuilder val_29 = builder.AppendFormat(format:  -774409552, args:  472754880);
        System.Text.StringBuilder val_30 = builder.AppendLine();
        val_47 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_47 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_47 == 1)
        {
                val_47 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_47 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        System.Text.StringBuilder val_31 = builder.AppendFormat(format:  -774409184, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        System.Text.StringBuilder val_32 = builder.AppendFormat(format:  -774409040, args:  472754880);
        System.Text.StringBuilder val_33 = builder.AppendLine();
        val_48 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_48 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_48 == 1)
        {
                val_48 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_48 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        System.Text.StringBuilder val_34 = builder.AppendFormat(format:  -774408672, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        string val_35 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  0);
        System.Text.StringBuilder val_36 = builder.AppendFormat(format:  -774408528, arg0:  0);
        string val_37 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  1296, formatting:  1);
        System.Text.StringBuilder val_38 = builder.AppendFormat(format:  -774408320, arg0:  1296);
        string val_39 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  0, formatting:  1);
        System.Text.StringBuilder val_40 = builder.AppendFormat(format:  -774408128, arg0:  0);
    }
    public BWYHackBehavior()
    {
    
    }

}
