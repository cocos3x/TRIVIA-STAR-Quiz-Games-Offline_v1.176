using UnityEngine;
public class SROptions_RestaurantRivals : SuperLuckySROptionsParent<SROptions_RestaurantRivals>, INotifyPropertyChanged
{
    // Properties
    public string SpinAmount { get; }
    public string TotalSpinned { get; }
    public string PlayerCanBeAttacked { get; }
    public string PlayerCanBeRaided { get; }
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
    public void Store()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 3)
        {
                return;
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
    public void CurrentEventInfoHud()
    {
        var val_4;
        var val_5;
        System.Func<System.String> val_7;
        var val_8;
        val_4 = 1152921504947740672;
        val_5 = null;
        val_5 = null;
        val_7 = SROptions_RestaurantRivals.<>c.<>9__11_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<TRVQuizProgress>(object:  SROptions_RestaurantRivals.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3455771072));
            SROptions_RestaurantRivals.<>c.<>9__11_0 = val_7;
        }
        
        SLCHUDWindow.SetupHUD(name:  -839195200, callbackfunc:  7667712);
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
    public void ClearHack()
    {
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = false};
    }
    public void NoReward()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  0);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
    }
    public void Attack()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  7);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
        RestaurantRivals.RESManager.HackAttackResult = 0;
    }
    public void AttackSuccess()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  7);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
        RestaurantRivals.RESManager.HackAttackResult = 1;
    }
    public void AttackFailed()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  7);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
        RestaurantRivals.RESManager.HackAttackResult = 2;
    }
    public void Raid()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  8);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
    }
    public void Shield()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  9);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
    }
    public void Spins()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  10);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
    }
    public void Bag3()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  6);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
    }
    public void Bag2()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  5);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
    }
    public void Bag1()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  4);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
    }
    public void Coin3()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  3);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
    }
    public void Coin2()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  2);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
    }
    public void Coin1()
    {
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_1 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  1);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_1.HasValue};
    }
    public void EventSymbol()
    {
        if(HotNSpicyEventHandler.IsEventActive == false)
        {
                return;
        }
        
        System.Nullable<com.adjust.sdk.AdjustLogLevel> val_2 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  11);
        RestaurantRivals.RESSlotMachine.HackType = new System.Nullable<RestaurantRivals.RESPayout>() {HasValue = val_2.HasValue};
    }
    public string get_SpinAmount()
    {
        RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
        if(0 != 0)
        {
                return 288.ToString();
        }
        
        return 288.ToString();
    }
    public void Credit1Spins()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AwardSpins(amount:  1, source:  1098586544, notify:  true);
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -837290080);
    }
    public void Credit10Spins()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AwardSpins(amount:  10, source:  1098586544, notify:  true);
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -837290080);
    }
    public void Credit100Spins()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AwardSpins(amount:  100, source:  1098586544, notify:  true);
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -837290080);
    }
    public void DoubleSpins()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AwardSpins(amount:  Spins, source:  1098586544, notify:  true);
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -837290080);
    }
    public void Debit1Spins()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DebitSpins(amount:  1, notify:  true);
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -837290080);
    }
    public void Debit10Spins()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DebitSpins(amount:  10, notify:  true);
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -837290080);
    }
    public void Debit100Spins()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DebitSpins(amount:  100, notify:  true);
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -837290080);
    }
    public void HalfSpins()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_3 = Spins;
        val_3 = val_3 + (val_3 >> 31);
        DebitSpins(amount:  val_3 >> 1, notify:  true);
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -837290080);
    }
    public void SkipFTUX()
    {
        if(RestaurantRivals.RESManager.IsGameStartFtuxFinished == true)
        {
                return;
        }
        
        RestaurantRivals.RESManager.SkipFTUX();
    }
    public string get_TotalSpinned()
    {
        RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
        if(0 != 0)
        {
                return 292.ToString();
        }
        
        return 292.ToString();
    }
    public void Credit1TotalSpinned()
    {
        var val_5;
        var val_6;
        var val_7;
        RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
        if(0 != 0)
        {
                val_5 = 0;
            val_6 = 1030672;
        }
        else
        {
                val_5 = 292;
            val_6 = 1030672;
        }
        
        mem[292] = 1030673;
        RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
        val_7 = null;
        val_7 = null;
        if(mem[292] < (RestaurantRivals.RESGameEcon.FTUXScripts + 12))
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ResetRaidOpponent();
        }
        
        Player val_4 = App.Player;
        0.SaveState();
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -836170000);
    }
    public void Credit10TotalSpinned()
    {
        var val_5;
        var val_6;
        var val_7;
        RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
        if(0 != 0)
        {
                val_5 = 0;
            val_6 = 1030672;
        }
        else
        {
                val_5 = 292;
            val_6 = 1030672;
        }
        
        mem[292] = 1030682;
        RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
        val_7 = null;
        val_7 = null;
        if(mem[292] < (RestaurantRivals.RESGameEcon.FTUXScripts + 12))
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ResetRaidOpponent();
        }
        
        Player val_4 = App.Player;
        0.SaveState();
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -836170000);
    }
    public void DoubleTotalSpinned()
    {
        var val_6;
        RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
        RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
        var val_6 = 1030672;
        val_6 = val_6 + 1030672;
        mem[292] = val_6;
        RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
        val_6 = null;
        val_6 = null;
        if(mem[292] < (RestaurantRivals.RESGameEcon.FTUXScripts + 12))
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ResetRaidOpponent();
        }
        
        Player val_5 = App.Player;
        0.SaveState();
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -836170000);
    }
    public void Debit1TotalSpinned()
    {
        var val_7;
        RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
        RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
        mem[292] = UnityEngine.Mathf.Max(a:  0, b:  1030671);
        RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
        val_7 = null;
        val_7 = null;
        if(mem[292] < (RestaurantRivals.RESGameEcon.FTUXScripts + 12))
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ResetRaidOpponent();
        }
        
        Player val_6 = App.Player;
        0.SaveState();
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -836170000);
    }
    public void Debit10TotalSpinned()
    {
        var val_7;
        RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
        RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
        mem[292] = UnityEngine.Mathf.Max(a:  0, b:  1030662);
        RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
        val_7 = null;
        val_7 = null;
        if(mem[292] < (RestaurantRivals.RESGameEcon.FTUXScripts + 12))
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ResetRaidOpponent();
        }
        
        Player val_6 = App.Player;
        0.SaveState();
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -836170000);
    }
    public void HalfTotalSpinned()
    {
        var val_7;
        RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
        RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
        mem[292] = UnityEngine.Mathf.Max(a:  0, b:  515336);
        RestaurantRivals.RESPlayer val_4 = RestaurantRivals.RESPlayer.Instance;
        val_7 = null;
        val_7 = null;
        if(mem[292] < (RestaurantRivals.RESGameEcon.FTUXScripts + 12))
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ResetRaidOpponent();
        }
        
        Player val_6 = App.Player;
        0.SaveState();
        SROptions_RestaurantRivals.NotifyPropertyChanged(propertyName:  -836170000);
    }
    public void AttackOnPlayer()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_TriggerAttack();
    }
    public void RaidOnPlayer()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_TriggerRaid();
    }
    public string get_PlayerCanBeAttacked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_3 = PlayerCanBeAttacked().ToString();
    }
    public string get_PlayerCanBeRaided()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_3 = PlayerCanBeRaided().ToString();
    }
    public void RaidAttackProtectionInfo()
    {
        var val_5;
        var val_6;
        var val_7;
        System.Func<System.String> val_9;
        var val_10;
        var val_11;
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        string val_1 = System.String.Format(format:  -835048880, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_6 = 1152921504947740672;
        val_7 = null;
        val_7 = null;
        val_9 = SROptions_RestaurantRivals.<>c.<>9__52_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Func<TRVQuizProgress>(object:  SROptions_RestaurantRivals.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3459918544));
            SROptions_RestaurantRivals.<>c.<>9__52_0 = val_9;
        }
        
        SLCHUDWindow.SetupHUD(name:  -835048880, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        var val_5 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_13;
        }
        
        val_6 = 0;
        label_15:
        val_10 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_14;
        }
        
        val_6 = val_6 + 1;
        val_10 = (uint)val_6 & 65535;
        if(val_10 < mem[1179403825])
        {
            goto label_15;
        }
        
        label_13:
        val_11 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_14:
        var val_4 = mem[1179403735] + 0;
        val_5 = val_5 + (((mem[1179403735] + 0) + 4) << 3);
        val_11 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void CompleteLevel()
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
    public void DisplayLevelTracking()
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
        
        string val_1 = System.String.Format(format:  -834599728, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3460367680));
        SLCHUDWindow.SetupHUD(name:  -834599728, callbackfunc:  7667712);
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
    public void LastServerResponse()
    {
        var val_4;
        var val_5;
        System.Func<System.String> val_7;
        var val_8;
        var val_9;
        val_4 = 1152921504947740672;
        val_5 = null;
        val_5 = null;
        val_7 = SROptions_RestaurantRivals.<>c.<>9__62_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<TRVQuizProgress>(object:  SROptions_RestaurantRivals.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3460929952));
            SROptions_RestaurantRivals.<>c.<>9__62_0 = val_7;
        }
        
        SLCHUDWindow.SetupHUD(name:  -834037472, callbackfunc:  7667712);
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        var val_4 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_4 = 0;
        label_9:
        val_8 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_4 = val_4 + 1;
        val_8 = (uint)val_4 & 65535;
        if(val_8 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_9 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_8:
        var val_3 = mem[1179403735] + 0;
        val_4 = val_4 + (((mem[1179403735] + 0) + 4) << 3);
        val_9 = val_4 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public void TestReturnGameGiftNotifications()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-833924320) == 0)
        {
                DebugMessageDisplay.DisplayMessage(msgTxt:  -833923296, displayTime:  null);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TestReturnGameGiftNotifications();
    }
    public void TestReturnGameGiftNotifications2()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-833924320) == 0)
        {
                DebugMessageDisplay.DisplayMessage(msgTxt:  -833923296, displayTime:  null);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TestReturnGameGiftNotifications2();
    }
    public void TestReturnGameGiftNotifications3()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-833924320) == 0)
        {
                DebugMessageDisplay.DisplayMessage(msgTxt:  -833923296, displayTime:  null);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TestReturnGameGiftNotifications3();
    }
    public void ClearReturnGameGiftNotifications()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-833924320) == 0)
        {
                val_4 = "Return Game Gift Manager doesn\'t exist.";
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ClearHacks();
            val_4 = "Hacked Return Game Gift Notifications are cleared.";
        }
        
        DebugMessageDisplay.DisplayMessage(msgTxt:  -833587136, displayTime:  null);
    }
    public SROptions_RestaurantRivals()
    {
    
    }

}
