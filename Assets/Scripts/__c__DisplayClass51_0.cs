using UnityEngine;
private sealed class LeaguesDataController.<>c__DisplayClass51_0
{
    // Fields
    public SLC.Social.Profile toRemove;
    public SLC.Social.Leagues.LeaguesDataController <>4__this;
    public int guild_id;
    
    // Methods
    public LeaguesDataController.<>c__DisplayClass51_0()
    {
    
    }
    internal void <RemoveGuildMember>b__0(System.Collections.Generic.Dictionary<string, object> responseObject)
    {
        int val_4 = this.toRemove.ServerId;
        SLC.Social.Profile val_1 = this.<>4__this.MyProfile;
        if(val_4 != (this.<>4__this))
        {
                return;
        }
        
        val_4 = this.<>4__this.knownGuilds;
        bool val_2 = val_4.Remove(key:  this.guild_id);
        this.<>4__this.UpdateEligibleGuildsToJoin();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnGuildStatusChanged(state:  1, source:  816062720, leftGuildId:  this.guild_id, forDisplayOnly:  false);
    }

}
