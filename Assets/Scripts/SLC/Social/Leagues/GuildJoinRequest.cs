using UnityEngine;

namespace SLC.Social.Leagues
{
    public class GuildJoinRequest
    {
        // Fields
        public SLC.Social.Profile sender;
        public SLC.Social.Leagues.Guild requestedGuild;
        public int ServerId;
        
        // Methods
        public GuildJoinRequest(SLC.Social.Profile requestingMember, SLC.Social.Leagues.Guild requestingGuild)
        {
            val_1 = new System.Object();
            this.sender = requestingMember;
            this.requestedGuild = val_1;
        }
        public void AcceptRequest()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            0.AcceptGuildRequest(inviteRequest:  833183200);
            this.requestedGuild.AddMember(toAdd:  this.sender);
            this.requestedGuild.RemoveInvite(toRemove:  833183200);
        }
        public void RejectRequest()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            0.RejectGuildRequest(inviteRequest:  833311584);
            this.requestedGuild.RemoveInvite(toRemove:  833311584);
        }
    
    }

}
