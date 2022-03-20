using UnityEngine;
public class SROptions_BestBlocks : SuperLuckySROptionsParent<SROptions_BestBlocks>, INotifyPropertyChanged
{
    // Properties
    public bool EasyMode { get; set; }
    public string LifeTimer { get; }
    public int Lives { get; set; }
    public bool Show { get; set; }
    
    // Methods
    public void General()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void PlayerCheats()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void DateTime()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void Store()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void Ads()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void GameOfTheDayMenu()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            goto label_5;
        }
        
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        object val_3 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        var val_7 = 0;
        label_9:
        val_7 = 0;
        val_8 = mem[mem[1179403735] + 0];
        val_8 = mem[1179403735] + 0;
        if(val_8 == null)
        {
            goto label_8;
        }
        
        val_7 = val_7 + 1;
        val_7 = (uint)val_7 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto label_10;
        label_5:
        DebugMessageDisplay.DisplayMessage(msgTxt:  -904233872, displayTime:  null);
        return;
        label_8:
        var val_4 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 284;
        label_10:
        SRDebugger.Services.IDebugService val_5 = SRDebug.Instance;
        var val_9 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_12;
        }
        
        val_7 = 0;
        label_14:
        val_8 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_13;
        }
        
        val_7 = val_7 + 1;
        val_8 = (uint)val_7 & 65535;
        if(val_8 < mem[1179403825])
        {
            goto label_14;
        }
        
        label_12:
        val_10 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_13:
        var val_6 = mem[1179403735] + 0;
        val_9 = val_9 + (((mem[1179403735] + 0) + 4) << 3);
        val_10 = val_9 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void GenericUIs()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void DailyChallenge()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            goto label_5;
        }
        
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        object val_3 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        var val_7 = 0;
        label_9:
        val_7 = 0;
        val_8 = mem[mem[1179403735] + 0];
        val_8 = mem[1179403735] + 0;
        if(val_8 == null)
        {
            goto label_8;
        }
        
        val_7 = val_7 + 1;
        val_7 = (uint)val_7 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto label_10;
        label_5:
        DebugMessageDisplay.DisplayMessage(msgTxt:  -904007680, displayTime:  null);
        return;
        label_8:
        var val_4 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 284;
        label_10:
        SRDebugger.Services.IDebugService val_5 = SRDebug.Instance;
        var val_9 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_12;
        }
        
        val_7 = 0;
        label_14:
        val_8 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_13;
        }
        
        val_7 = val_7 + 1;
        val_8 = (uint)val_7 & 65535;
        if(val_8 < mem[1179403825])
        {
            goto label_14;
        }
        
        label_12:
        val_10 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_13:
        var val_6 = mem[1179403735] + 0;
        val_9 = val_9 + (((mem[1179403735] + 0) + 4) << 3);
        val_10 = val_9 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void DailyBonus()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        object val_2 = SuperLuckySROptionsParent<System.Object>.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_6 = 0;
        label_4:
        val_6 = 0;
        val_7 = mem[mem[1179403735] + 0];
        val_7 = mem[1179403735] + 0;
        if(val_7 == null)
        {
            goto label_3;
        }
        
        val_6 = val_6 + 1;
        val_6 = (uint)val_6 & 65535;
        if(val_6 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_8 = 0;
        goto label_5;
        label_3:
        var val_3 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 284;
        label_5:
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_7 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
        label_8:
        var val_5 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_8 + 292;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 292);
    }
    public void CompleteLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void CompleteChapter()
    {
        GameBehavior val_1 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void RestartLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void FailLevel()
    {
        var val_9;
        var val_10;
        var val_11;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
            goto label_5;
        }
        
        val_9 = 1152921511020107712;
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
        
        val_10 = "Hack usable only after completing FTUX levels.";
        goto label_14;
        label_5:
        val_10 = "Option works only in-game.";
        label_14:
        UnityEngine.Debug.Log(message:  -903446352);
        return;
        label_11:
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackGameOver(success:  false);
        SRDebugger.Services.IDebugService val_7 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_21;
        }
        
        val_9 = 0;
        label_23:
        if((mem[1179403735] + 0) == null)
        {
            goto label_22;
        }
        
        val_9 = val_9 + 1;
        if(((uint)val_9 & 65535) < mem[1179403825])
        {
            goto label_23;
        }
        
        label_21:
        val_11 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_22:
        var val_8 = mem[1179403735] + 0;
        var val_9 = (mem[1179403735] + 0) + 4;
        val_9 = 1179403647 + (val_9 << 3);
        val_11 = val_9 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void GoNextLevelQuick()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackQuickGoNextLevel();
    }
    public bool get_EasyMode()
    {
        BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        if(0 != 0)
        {
                return 0.IsEasyMode();
        }
        
        return 0.IsEasyMode();
    }
    public void set_EasyMode(bool value)
    {
        var val_3;
        var val_4;
        val_3 = 0;
        Player val_1 = App.Player;
        val_4 = 0;
        if(0 != 0)
        {
                val_4 = 0;
        }
        
        if(value != false)
        {
                val_4 = 0;
            BlockPuzzleMagic.BestBlocksGameEcon val_2 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            val_3 = 3572208;
        }
        
        mem[340] = val_3;
    }
    public string get_LifeTimer()
    {
        ulong val_6;
        long val_12;
        BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        var val_2 = 0 + 1404;
        System.TimeSpan val_3 = System.TimeSpan.FromMinutes(value:  null);
        System.DateTime val_4 = DateTimeCheat.UtcNow;
        BestBlocksPlayer val_5 = BestBlocksPlayer.Instance;
        System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512293795288}, d2:  new System.DateTime() {dateData = val_6});
        System.TimeSpan val_11 = System.TimeSpan.op_Subtraction(t1:  new System.TimeSpan() {_ticks = 1152921512293795280}, t2:  new System.TimeSpan());
        double val_14 = val_12.TotalSeconds;
        string val_15 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_12}, formatted:  true);
    }
    public int get_Lives()
    {
        BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
        if(0 != 0)
        {
                return 33453552;
        }
        
        return 33453552;
    }
    public void set_Lives(int value)
    {
        BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
        mem[284] = value;
    }
    public void RefreshAllShapes()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RegenerateNewShapes();
    }
    public void DisplayLevelInfo()
    {
        var val_6;
        System.Func<TRVQuizProgress> val_7;
        var val_8;
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_6 == 1)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_1 = System.String.Format(format:  -902550224, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3392418208));
        SLCHUDWindow.SetupHUD(name:  -902550224, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_4 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_10;
        }
        
        val_7 = 0;
        label_12:
        if((mem[1179403735] + 0) == null)
        {
            goto label_11;
        }
        
        val_7 = val_7 + 1;
        if(((uint)val_7 & 65535) < mem[1179403825])
        {
            goto label_12;
        }
        
        label_10:
        val_8 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_11:
        var val_5 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_8 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void ResetFtuxGoals()
    {
        BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  10, completed:  false);
        BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  11, completed:  false);
        BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  12, completed:  false);
    }
    public void ResetFtuxBlocks()
    {
        BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  7, completed:  false);
        BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  8, completed:  false);
        BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  9, completed:  false);
    }
    public void ResetFtuxPowerups()
    {
        BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  4, completed:  false);
        BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  5, completed:  false);
        BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  6, completed:  false);
    }
    public void ResetFtuxGameplay()
    {
        BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  1, completed:  false);
        BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  2, completed:  false);
        BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  3, completed:  false);
        BestBlocksPlayer val_4 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  13, completed:  false);
        BestBlocksPlayer val_5 = BestBlocksPlayer.Instance;
        0.SetFtuxStatus(ftuxId:  14, completed:  false);
    }
    public bool get_Show()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -901988064, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void set_Show(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -901988064, value:  value);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -901875952);
    }
    public SROptions_BestBlocks()
    {
    
    }

}
