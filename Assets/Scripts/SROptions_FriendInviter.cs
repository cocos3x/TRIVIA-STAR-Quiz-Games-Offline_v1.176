using UnityEngine;
public class SROptions_FriendInviter : SuperLuckySROptionsParent<SROptions_FriendInviter>, INotifyPropertyChanged
{
    // Properties
    public int InvitesCollected { get; }
    public int PendingInvitesCollected { get; }
    public string LastResponse { get; }
    public string Progression { get; }
    
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
    public int get_InvitesCollected()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance()) != 0)
        {
                return InvitesCollected;
        }
        
        return InvitesCollected;
    }
    public int get_PendingInvitesCollected()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance()) != 0)
        {
                return PendingInvites;
        }
        
        return PendingInvites;
    }
    public void AddInvite()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1606351552) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HACKAddFakeInvites(invites:  1);
        goto typeof(SROptions_FriendInviter).__il2cppRuntimeField_EC;
    }
    public void AddInvite10()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1606351552) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HACKAddFakeInvites(invites:  10);
        goto typeof(SROptions_FriendInviter).__il2cppRuntimeField_EC;
    }
    public string get_LastResponse()
    {
    
    }
    public string get_Progression()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -888562224)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -888562224, defaultValue:  -2040381152);
        object val_3 = MiniJSON.Json.Deserialize(json:  -888562224);
        return PrettyPrint.printJSON(obj:  -888562224, types:  false, singleLineOutput:  false);
    }
    public SROptions_FriendInviter()
    {
    
    }

}
