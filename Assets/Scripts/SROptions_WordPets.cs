using UnityEngine;
public class SROptions_WordPets : SuperLuckySROptionsParent<SROptions_WordPets>, INotifyPropertyChanged
{
    // Properties
    public string LivesMod { get; }
    public string InstantFail { get; }
    public bool Show { get; set; }
    
    // Methods
    public static void NotifyPropertyChanged(string propertyName)
    {
        if((SuperLuckySROptionsParent<T>._Instance) == 0)
        {
                return;
        }
        
        goto typeof(T).__il2cppRuntimeField_EC;
    }
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
    public void CompleteLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHACK_ClearLevel();
    }
    public void CompleteChapter()
    {
        var val_8;
        int val_9;
        val_8 = 0;
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                if(((mem[1179403747] + (WordPets.WPTGameEcon.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_8 = 0;
        }
        
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        if(val_8 != 0)
        {
                val_9 = val_8.GetCurrentChapter(level:  0);
        }
        else
        {
                val_9 = val_8.GetCurrentChapter(level:  0);
        }
        
        int val_6 = val_8.GetLastLevelInChapter(chapter:  val_9);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHACK_ClearLevel();
    }
    public void FailLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHACK_FailLevel();
    }
    public void RestartLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void GiveRandomPetInGame()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHACK_GiveRandomPet();
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
    public void MinusPetTimer()
    {
        null = null;
        int val_1 = WordPets.WPTShelterController.HACK_PetTimerModifier;
        val_1 = val_1 - 1;
        WordPets.WPTShelterController.HACK_PetTimerModifier = val_1;
        SROptions_WordPets.NotifyPropertyChanged(propertyName:  -802722896);
    }
    public string get_LivesMod()
    {
        null = null;
        return ToString();
    }
    public void PlusPetTimer()
    {
        null = null;
        int val_1 = WordPets.WPTShelterController.HACK_PetTimerModifier;
        val_1 = val_1 + 1;
        WordPets.WPTShelterController.HACK_PetTimerModifier = val_1;
        SROptions_WordPets.NotifyPropertyChanged(propertyName:  -802722896);
    }
    public string get_InstantFail()
    {
        null = null;
        return ToString();
    }
    public void ToggleInstantFail()
    {
        null = null;
        bool val_1 = WordPets.WPTGameUIController.HACK_InstantFailEscape;
        val_1 = val_1 ^ 1;
        WordPets.WPTGameUIController.HACK_InstantFailEscape = val_1;
        SROptions_WordPets.NotifyPropertyChanged(propertyName:  -802274800);
    }
    public void MaxPlayerLives()
    {
        WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
        0.QAHACK_MaxLives();
    }
    public void EmptyPlayerLives()
    {
        WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
        0.QAHACK_EmptyLives();
    }
    public void GoToLevelEditMode()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHack_ToggleEditMode();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        Player val_4 = App.Player;
        WordPets.WPTLevelData val_5 = GetLevelData(level:  0);
        Init(incData:  -801937664);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        LoadGame(mode:  0);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QAHack_ToggleEditMode();
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
    public SROptions_WordPets()
    {
    
    }

}
