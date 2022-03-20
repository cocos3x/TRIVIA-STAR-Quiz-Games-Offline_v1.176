using UnityEngine;
public class SROptions_Minigames : SuperLuckySROptionsParent<SROptions_Minigames>, INotifyPropertyChanged
{
    // Properties
    public string CheckPoint { get; }
    public string Rank { get; }
    public bool FreeContinues { get; set; }
    public string WordQuizShowAnswer { get; }
    
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
    public void CompleteLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = HandleLevelComplete();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1735991568) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateUI();
    }
    public void FailLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = HandleLevelFailed();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1735991568) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateUI();
    }
    public void RestartLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleGameRestart();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1735991568) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateUI();
    }
    public string get_CheckPoint()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60.ToString();
    }
    public void PlayerLevelUp1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            QAHACK_IncrementCheckpoint();
        }
        
        SROptions_Minigames.NotifyPropertyChanged(propertyName:  -849797904);
    }
    public void PlayerLevelDown1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            QAHACK_DecrementCheckpoint();
        }
        
        SROptions_Minigames.NotifyPropertyChanged(propertyName:  -849797904);
    }
    public string get_Rank()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.MinigameLevelRank val_4 = GetCurrentRank;
            val_5 = 1152921511451483820;
            return;
        }
        
        val_5 = "0";
    }
    public void PlayerRankUp1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            QAHACK_IncrementRank();
        }
        
        SROptions_Minigames.NotifyPropertyChanged(propertyName:  -849461808);
    }
    public void PlayerRankDown1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745297776) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            QAHACK_DecrementRank();
        }
        
        SROptions_Minigames.NotifyPropertyChanged(propertyName:  -849461808);
    }
    public bool get_FreeContinues()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = 0;
        if((-1745297776) == 0)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_98) != 0)
        {
                val_4 = 1;
        }
        
        return true;
    }
    public void set_FreeContinues(bool value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_98 = (public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_98 ^ 1);
        SROptions_Minigames.NotifyPropertyChanged(propertyName:  -849125728);
    }
    public void Pause15Seconds()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-849013632) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PauseHack();
    }
    public void StopTimer()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-849013632) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StopTimerHack();
    }
    public void ResumeTimer()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-849013632) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ResumeTimerHack();
    }
    public void EmojiMatchSlowDownTimer()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-848676608) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PauseHack();
    }
    public void EmojiMatchStopTimer()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-848676608) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StopTimerHack();
    }
    public void EmojiMatchResumeTimer()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-848676608) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ResumeTimerHack();
    }
    public void WordQuizShowCurrentLevelPool()
    {
        var val_8;
        var val_9;
        System.Func<TRVQuizProgress> val_10;
        var val_11;
        var val_12;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-848339584) == 0)
        {
                return;
        }
        
        val_8 = public static T[] System.Array::Empty<System.Object>();
        val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_9 == 1)
        {
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_3 = System.String.Format(format:  -848338560, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = null;
        val_11 = public System.Void System.Func<System.String>::.ctor(object object, IntPtr method);
        val_10 = new System.Func<TRVQuizProgress>(object:  -848339584, method:  new IntPtr(3446628880));
        SLCHUDWindow.SetupHUD(name:  -848338560, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_6 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_15;
        }
        
        val_11 = mem[1179403735];
        val_8 = 0;
        label_17:
        val_10 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_16;
        }
        
        val_8 = val_8 + 1;
        val_10 = (uint)val_8 & 65535;
        if(val_10 < mem[1179403825])
        {
            goto label_17;
        }
        
        label_15:
        val_12 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_16:
        var val_7 = val_11 + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_12 = val_8 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public string get_WordQuizShowAnswer()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-848339584) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static SLC.Minigames.WordQuiz.WordQuizManager MonoSingleton<SLC.Minigames.WordQuiz.WordQuizManager>::get_Instance()) != 0)
        {
                return ReturnCurrentAnswer();
        }
        
        return ReturnCurrentAnswer();
    }
    public void WordArrowsDisplayLevelInfo()
    {
        var val_8;
        var val_9;
        System.Func<TRVQuizProgress> val_10;
        var val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-848113392) == 0)
        {
                return;
        }
        
        val_8 = public static T[] System.Array::Empty<System.Object>();
        val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_9 == 1)
        {
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_3 = System.String.Format(format:  -902550224, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = null;
        val_10 = new System.Func<TRVQuizProgress>(object:  -848113392, method:  new IntPtr(3446854928));
        SLCHUDWindow.SetupHUD(name:  -902550224, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_6 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_15;
        }
        
        val_8 = 0;
        label_17:
        val_10 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_16;
        }
        
        val_8 = val_8 + 1;
        val_10 = (uint)val_8 & 65535;
        if(val_10 < mem[1179403825])
        {
            goto label_17;
        }
        
        label_15:
        val_11 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_16:
        var val_7 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_11 = val_8 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void Just2EmojisDisplayLevelInfo()
    {
        var val_8;
        var val_9;
        System.Func<TRVQuizProgress> val_10;
        var val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-847999344) == 0)
        {
                return;
        }
        
        val_8 = public static T[] System.Array::Empty<System.Object>();
        val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_9 == 1)
        {
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_3 = System.String.Format(format:  -902550224, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = null;
        val_10 = new System.Func<TRVQuizProgress>(object:  -847999344, method:  new IntPtr(3446968976));
        SLCHUDWindow.SetupHUD(name:  -902550224, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_6 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_15;
        }
        
        val_8 = 0;
        label_17:
        val_10 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_16;
        }
        
        val_8 = val_8 + 1;
        val_10 = (uint)val_8 & 65535;
        if(val_10 < mem[1179403825])
        {
            goto label_17;
        }
        
        label_15:
        val_11 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_16:
        var val_7 = mem[1179403735] + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_11 = val_8 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void Just2EmojisDisplayLevelPool()
    {
        var val_8;
        var val_9;
        System.Func<TRVQuizProgress> val_10;
        var val_11;
        var val_12;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-847999344) == 0)
        {
                return;
        }
        
        val_8 = public static T[] System.Array::Empty<System.Object>();
        val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_9 == 1)
        {
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_3 = System.String.Format(format:  -848338560, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = null;
        val_11 = public System.Void System.Func<System.String>::.ctor(object object, IntPtr method);
        val_10 = new System.Func<TRVQuizProgress>(object:  -847999344, method:  new IntPtr(3447082000));
        SLCHUDWindow.SetupHUD(name:  -848338560, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_6 = SRDebug.Instance;
        var val_8 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_15;
        }
        
        val_11 = mem[1179403735];
        val_8 = 0;
        label_17:
        val_10 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_16;
        }
        
        val_8 = val_8 + 1;
        val_10 = (uint)val_8 & 65535;
        if(val_10 < mem[1179403825])
        {
            goto label_17;
        }
        
        label_15:
        val_12 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_16:
        var val_7 = val_11 + 0;
        val_8 = val_8 + (((mem[1179403735] + 0) + 4) << 3);
        val_12 = val_8 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public SROptions_Minigames()
    {
    
    }

}
