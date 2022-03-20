using UnityEngine;
public class SROptions_GameOfTheDay : SuperLuckySROptionsParent<SROptions_GameOfTheDay>, INotifyPropertyChanged
{
    // Properties
    public string LastAdClicked { get; }
    public string GOTDLastShown { get; }
    public string GOTDDaysSeenWoInstallation { get; }
    public string DontShowUntil { get; }
    public string LastResponse { get; }
    public string PromotedGames { get; }
    
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
    public void Refresh()
    {
        SROptions_GameOfTheDay.NotifyPropertyChanged(propertyName:  -860104896);
    }
    public void SimulateAdClick()
    {
        Player val_1 = App.Player;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        Player val_5 = App.Player;
        2621448.Save(writePrefs:  true);
        System.DateTime val_6 = DateTimeCheat.UtcNow;
        System.DateTime val_9 = ToLocalTime();
        string val_12 = System.String.Format(format:  -859992800, arg0:  9904128);
        DebugMessageDisplay.DisplayMessage(msgTxt:  -859992800, displayTime:  null);
        SROptions_GameOfTheDay.NotifyPropertyChanged(propertyName:  -859992672);
        Refresh();
    }
    public string get_LastAdClicked()
    {
        Player val_1 = App.Player;
        var val_2 = 2621448 + 200;
        System.DateTime val_3 = ToLocalTime();
        string val_4 = ???.ToString();
    }
    public string get_GOTDLastShown()
    {
        Player val_1 = App.Player;
        var val_2 = 2621448 + 208;
        System.DateTime val_3 = ToLocalTime();
        string val_4 = ???.ToString();
    }
    public string get_GOTDDaysSeenWoInstallation()
    {
        Player val_1 = App.Player;
        return 2621448 + 216.ToString();
    }
    public string get_DontShowUntil()
    {
        Player val_1 = App.Player;
        var val_2 = 2621448 + 224;
        System.DateTime val_3 = ToLocalTime();
        string val_4 = ???.ToString();
    }
    public string get_LastResponse()
    {
        var val_1;
        var val_1 = 21763993;
        val_1 = 13876932 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
    }
    public string get_PromotedGames()
    {
        Player val_1 = App.Player;
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = 0.PromotedGames;
        return PrettyPrint.printJSON(obj:  0, types:  false, singleLineOutput:  false);
    }
    public SROptions_GameOfTheDay()
    {
    
    }

}
