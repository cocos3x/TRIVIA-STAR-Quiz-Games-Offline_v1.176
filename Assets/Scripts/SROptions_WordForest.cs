using UnityEngine;
public class SROptions_WordForest : SuperLuckySROptionsParent<SROptions_WordForest>, INotifyPropertyChanged
{
    // Properties
    public string ChestHackStatus { get; }
    public bool PlayChallengeWords { get; set; }
    public int ChestForceIslandParadise { get; set; }
    public bool EnableChestFtux { get; set; }
    public int ForestLevel { get; set; }
    public bool Show { get; set; }
    public string ShowRaidPoolIds { get; }
    public string ShowAttackPoolIds { get; }
    
    // Methods
    public static void NotifyPropertyChanged(string propertyName)
    {
        if((SuperLuckySROptionsParent<T>._Instance) == 0)
        {
                return;
        }
        
        goto typeof(T).__il2cppRuntimeField_EC;
    }
    public void CopyErrors()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_6 = null;
        val_7 = "";
        val_6 = null;
        System.Collections.Generic.IEnumerator<T> val_1 = UnityLoggerListener._allConsoleEntries.GetEnumerator();
        label_15:
        val_7 = 0;
        val_8 = 0;
        val_7 = val_7 + 1;
        val_8 = (uint)val_7 & 65535;
        val_9 = UnityLoggerListener._allConsoleEntries;
        if(UnityLoggerListener._allConsoleEntries == 0)
        {
            goto label_9;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_10 = UnityLoggerListener._allConsoleEntries;
        string val_4 = 1098586544 + UnityLoggerListener._allConsoleEntries;
        goto label_15;
        label_9:
        if(UnityLoggerListener._allConsoleEntries != 0)
        {
                val_8 = 0;
            val_7 = 0;
            val_8 = val_8 + 1;
            val_7 = (uint)val_8 & 65535;
            val_11 = UnityLoggerListener._allConsoleEntries;
        }
        
        ClipboardHelper.clipBoard = 1098586544;
    }
    public void ShareErrors()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_6 = null;
        val_7 = "";
        val_6 = null;
        System.Collections.Generic.IEnumerator<T> val_1 = UnityLoggerListener._allConsoleEntries.GetEnumerator();
        label_15:
        val_7 = 0;
        val_8 = 0;
        val_7 = val_7 + 1;
        val_8 = (uint)val_7 & 65535;
        val_9 = UnityLoggerListener._allConsoleEntries;
        if(UnityLoggerListener._allConsoleEntries == 0)
        {
            goto label_9;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_10 = UnityLoggerListener._allConsoleEntries;
        string val_4 = 1098586544 + UnityLoggerListener._allConsoleEntries;
        goto label_15;
        label_9:
        if(UnityLoggerListener._allConsoleEntries != 0)
        {
                val_8 = 0;
            val_7 = 0;
            val_8 = val_8 + 1;
            val_7 = (uint)val_8 & 65535;
            val_11 = UnityLoggerListener._allConsoleEntries;
        }
        
        ClipboardHelper.clipBoard = 1098586544;
        twelvegigs.plugins.SharePlugin.Share(text:  1098586544, url:  1098586544, subject:  -840205360, emailBody:  1098586544, imgPath:  0);
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
    public void ShowEventHacks()
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
    public void RestartLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void GrantExtraWord()
    {
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        if(0 == 0)
        {
            
        }
    
    }
    public void CompleteLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void ExtraReqWordsHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3480434096));
        SLCHUDWindow.SetupHUD(name:  -814532176, callbackfunc:  7667712);
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
    public void CompleteChapter()
    {
        WordRegion val_1 = WordRegion.instance;
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
        if(PlayingChallenge == true)
        {
                return;
        }
        
        GameBehavior val_7 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void LevelsSkipped()
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
        
        string val_1 = System.String.Format(format:  -834374592, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3460592800));
        SLCHUDWindow.SetupHUD(name:  -834374592, callbackfunc:  7667712);
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
    public string get_ChestHackStatus()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance()) != 0)
        {
                return Hack_ChestRewardHackStatus();
        }
        
        return Hack_ChestRewardHackStatus();
    }
    public void MysteryChestUnlockInstantly()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_CollectMysteryChest();
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_5;
        }
        
        var val_4 = 0;
        label_7:
        if((mem[1179403735] + 0) == null)
        {
            goto label_6;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_7;
        }
        
        label_5:
        val_4 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_6:
        var val_3 = mem[1179403735] + 0;
        var val_5 = (mem[1179403735] + 0) + 4;
        val_5 = 1179403647 + (val_5 << 3);
        val_4 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public bool get_PlayChallengeWords()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance()) != 0)
        {
                return (bool)public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_11;
        }
        
        return (bool)public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_11;
    }
    public void set_PlayChallengeWords(bool value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_11 = value;
    }
    public void ChestForceRewardClear()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_ClearForcedReward();
        SROptions_WordForest.NotifyPropertyChanged(propertyName:  -813634000);
    }
    public void ChestForceRewardRaid()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_ForceRewardRaid();
        SROptions_WordForest.NotifyPropertyChanged(propertyName:  -813634000);
    }
    public void ChestForceRewardAttack()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_ForceRewardAttack();
        SROptions_WordForest.NotifyPropertyChanged(propertyName:  -813634000);
    }
    public int get_ChestForceIslandParadise()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance()) != 0)
        {
                return (int)public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_18;
        }
        
        return (int)public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance().__il2cppRuntimeField_18;
    }
    public void set_ChestForceIslandParadise(int value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_ForceIslandParadiseSymbolCount(value:  value);
        SROptions_WordForest.NotifyPropertyChanged(propertyName:  -813634000);
    }
    public bool get_EnableChestFtux()
    {
        var val_8;
        WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
        val_8 = 1;
        if((MonoExtensions.IsBitSet(value:  132, bit:  9)) == false)
        {
                return (bool)val_8;
        }
        
        WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
        if((MonoExtensions.IsBitSet(value:  132, bit:  10)) == false)
        {
                return (bool)val_8;
        }
        
        WordForest.WFOPlayer val_5 = WordForest.WFOPlayer.Instance;
        val_8 = (MonoExtensions.IsBitSet(value:  132, bit:  8)) ^ 1;
        return (bool)val_8;
    }
    public void set_EnableChestFtux(bool value)
    {
        var val_17;
        WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
        WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
        if(value != false)
        {
                mem[312] = MonoExtensions.UnsetBit(value:  132, bit:  9);
            WordForest.WFOPlayer val_4 = WordForest.WFOPlayer.Instance;
            WordForest.WFOPlayer val_5 = WordForest.WFOPlayer.Instance;
            mem[312] = MonoExtensions.UnsetBit(value:  mem[312], bit:  10);
            WordForest.WFOPlayer val_7 = WordForest.WFOPlayer.Instance;
            val_17 = 0;
            WordForest.WFOPlayer val_8 = WordForest.WFOPlayer.Instance;
            int val_9 = MonoExtensions.UnsetBit(value:  mem[312], bit:  8);
        }
        else
        {
                mem[312] = MonoExtensions.SetBit(value:  132, bit:  9);
            WordForest.WFOPlayer val_11 = WordForest.WFOPlayer.Instance;
            WordForest.WFOPlayer val_12 = WordForest.WFOPlayer.Instance;
            mem[312] = MonoExtensions.SetBit(value:  mem[312], bit:  10);
            WordForest.WFOPlayer val_14 = WordForest.WFOPlayer.Instance;
            val_17 = 0;
            WordForest.WFOPlayer val_15 = WordForest.WFOPlayer.Instance;
        }
        
        mem[312] = MonoExtensions.SetBit(value:  mem[312], bit:  8);
    }
    public void ResetShields()
    {
        WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
        mem[308] = 0;
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -812849888);
    }
    public int get_ForestLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WordForest.WFOForestManager MonoSingleton<WordForest.WFOForestManager>::get_Instance()) != 0)
        {
                return CurrentForestLevel;
        }
        
        return CurrentForestLevel;
    }
    public void set_ForestLevel(int value)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_SetForestLevel(level:  value);
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
    public string get_ShowRaidPoolIds()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14.QA_RaidPoolIds;
    }
    public string get_ShowAttackPoolIds()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14.QA_AttackPoolIds;
    }
    public void ShowMyselfHUD()
    {
        var val_4;
        System.Func<TRVQuizProgress> val_1 = new System.Func<TRVQuizProgress>(object:  -812039728, method:  new IntPtr(3482902544));
        SLCHUDWindow.SetupHUD(name:  -881043264, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_4 = 0;
        label_4:
        if((mem[1179403735] + 0) == null)
        {
            goto label_3;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_4 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_3:
        var val_3 = mem[1179403735] + 0;
        var val_5 = (mem[1179403735] + 0) + 4;
        val_5 = 1179403647 + (val_5 << 3);
        val_4 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    private string GetRaidAttackHud()
    {
        var val_30;
        WordForest.WFOPlayer val_1 = WordForest.WFOPlayer.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Text.StringBuilder val_3 = new System.Text.StringBuilder();
        string val_4 = -811951728(-811951728) + 13152256;
        System.Text.StringBuilder val_5 = AppendLine(value:  -811951728);
        string val_6 = -811951616(-811951616) + public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 52 + 16(public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 52 + 16);
        System.Text.StringBuilder val_7 = AppendLine(value:  -811951616);
        int val_8 = 0.acorns;
        string val_9 = -811951504(-811951504) + 13152256;
        System.Text.StringBuilder val_10 = AppendLine(value:  -811951504);
        string val_11 = -811951408(-811951408) + 13152256;
        System.Text.StringBuilder val_12 = AppendLine(value:  -811951408);
        string val_13 = -811951312(-811951312) + 13152256;
        System.Text.StringBuilder val_14 = AppendLine(value:  -811951312);
        string val_15 = -811951200(-811951200) + 13152256;
        System.Text.StringBuilder val_16 = AppendLine(value:  -811951200);
        string val_17 = -811951104(-811951104) + 13152256;
        if(val_3 != 0)
        {
                System.Text.StringBuilder val_18 = AppendLine(value:  -811951104);
        }
        else
        {
                System.Text.StringBuilder val_19 = AppendLine(value:  -811951104);
        }
        
        System.Text.StringBuilder val_20 = AppendLine();
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_22 = -811950992(-811950992) + 13152256;
        System.Text.StringBuilder val_23 = AppendLine(value:  -811950992);
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_25 = -811950880(-811950880) + 13152256;
        if(val_3 != 0)
        {
                System.Text.StringBuilder val_26 = AppendLine(value:  -811950880);
        }
        else
        {
                System.Text.StringBuilder val_27 = AppendLine(value:  -811950880);
        }
        
        System.Text.StringBuilder val_28 = AppendLine();
        UnityEngine.Vector2Int val_29 = WordForest.WFOGameEconHelper.GetRaidEligibleAcornsMinMax(forestLevel:  -811937808);
        System.Text.StringBuilder val_33 = AppendLine(value:  -811950768);
        if((public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 52 + 36) > 0)
        {
                0 = 1;
        }
        
        string val_34 = 1.ToString();
        string val_35 = -811950656(-811950656) + -811937761(-811937761);
        System.Text.StringBuilder val_36 = AppendLine(value:  -811950656);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "Min acorns attained: ";
        if(0.acorns > val_30.x)
        {
                0 = 1;
        }
        
        string val_38 = 1.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        typeof(System.Object[]).__il2cppRuntimeField_18 = " (Required: ";
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = ")";
        string val_39 = +472754880;
        System.Text.StringBuilder val_40 = AppendLine(value:  472754880);
        WordForest.WFOPlayer val_41 = WordForest.WFOPlayer.Instance;
        string val_43 = MonoExtensions.IsBitSet(value:  132, bit:  9).ToString();
        string val_44 = -811950336(-811950336) + -811937761(-811937761);
        if(val_3 != 0)
        {
                System.Text.StringBuilder val_45 = AppendLine(value:  -811950336);
            System.Text.StringBuilder val_46 = AppendLine();
        }
        else
        {
                System.Text.StringBuilder val_47 = AppendLine(value:  -811950336);
            System.Text.StringBuilder val_48 = AppendLine();
        }
        
        System.Text.StringBuilder val_49 = AppendLine(value:  -811950208);
        if((public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_14 + 52 + 44) > 0)
        {
                0 = 1;
        }
        
        string val_50 = 1.ToString();
        string val_51 = -811950080(-811950080) + -811937761(-811937761);
        System.Text.StringBuilder val_52 = AppendLine(value:  -811950080);
        WordForest.WFOPlayer val_53 = WordForest.WFOPlayer.Instance;
        string val_55 = MonoExtensions.IsBitSet(value:  132, bit:  10).ToString();
        string val_56 = -811949968(-811949968) + -811937761(-811937761);
        System.Text.StringBuilder val_57 = AppendLine(value:  -811949968);
        WordForest.WFOPlayer val_58 = WordForest.WFOPlayer.Instance;
        string val_60 = MonoExtensions.IsBitSet(value:  132, bit:  11).ToString();
        string val_61 = -811949840(-811949840) + -811937761(-811937761);
        if(val_3 != 0)
        {
                System.Text.StringBuilder val_62 = AppendLine(value:  -811949840);
            return;
        }
        
        System.Text.StringBuilder val_63 = AppendLine(value:  -811949840);
    }
    public void ShowServerLogTraceHUD()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  public static WordForest.RaidAttackManager MonoSingleton<WordForest.RaidAttackManager>::get_Instance().__il2cppRuntimeField_18, method:  new IntPtr(3483129584));
        SLCHUDWindow.SetupHUD(name:  -811836688, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_5;
        }
        
        var val_5 = 0;
        label_7:
        if((mem[1179403735] + 0) == null)
        {
            goto label_6;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < mem[1179403825])
        {
            goto label_7;
        }
        
        label_5:
        val_5 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_6:
        var val_4 = mem[1179403735] + 0;
        var val_6 = (mem[1179403735] + 0) + 4;
        val_6 = 1179403647 + (val_6 << 3);
        val_5 = val_6 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public SROptions_WordForest()
    {
    
    }

}
