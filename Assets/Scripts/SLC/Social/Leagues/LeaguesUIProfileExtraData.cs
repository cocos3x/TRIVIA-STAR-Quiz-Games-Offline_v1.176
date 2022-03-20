using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIProfileExtraData : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text rankText;
        private UnityEngine.UI.Text pointsText;
        private UnityEngine.UI.Text inactiveText;
        private UnityEngine.UI.Text ordinalText;
        private UnityEngine.GameObject extraDataCategory;
        private UnityEngine.GameObject activePlayerBox;
        private UnityEngine.GameObject inactivePlayerBox;
        
        // Methods
        public void Setup(SLC.Social.Profile profile)
        {
            int val_15;
            UnityEngine.GameObject val_16;
            int val_17;
            UnityEngine.UI.Text val_18;
            val_15 = profile.ServerId;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_2 = 0.MyProfile;
            val_16 = 0;
            if(val_15 == 0)
            {
                    if(SLC.Social.Leagues.LeaguesManager.IsAvailableAndInGuild() == false)
            {
                goto label_16;
            }
            
            }
            
            if(profile.isMemberActive == true)
            {
                    profile.isMemberActive = 1;
            }
            
            this.activePlayerBox.SetActive(value:  true);
            val_16 = this.inactivePlayerBox;
            val_15 = profile.isMemberActive;
            val_16.SetActive(value:  this.activePlayerBox >> 5);
            if(profile.isMemberActive == false)
            {
                goto label_12;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_15 = profile.GuildServerId;
            val_16 = 0;
            SLC.Social.Leagues.Guild val_6 = val_16.GetGuild(guildId:  val_15);
            if(val_16 != 0)
            {
                    int val_7 = val_16.GetRankInGuildById(id:  profile.ServerId);
                string val_8 = val_7.ToString();
                val_15;
                val_16 = this.pointsText;
                string val_9 = profile.leaguePoints.ToString();
                val_17 = val_7;
                val_18 = this.ordinalText;
                string val_10 = Ordinal.AddOrdinal(num:  val_17);
                return;
            }
            
            label_16:
            this.extraDataCategory.SetActive(value:  false);
            return;
            label_12:
            val_18 = this.inactiveText;
            if(profile.GuildMaster != false)
            {
                    string val_11 = Localization.Localize(key:  863386064, defaultValue:  -1331168096, useSingularKey:  false);
                string val_12 = Localization.Localize(key:  863386160, defaultValue:  863386256, useSingularKey:  false);
                val_17 = "{0} - {1}";
                string val_13 = System.String.Format(format:  -1704297152, arg0:  863386064, arg1:  863386160);
                return;
            }
            
            val_17 = "inactive_upper";
            string val_14 = Localization.Localize(key:  863386160, defaultValue:  863386256, useSingularKey:  false);
        }
        public LeaguesUIProfileExtraData()
        {
        
        }
    
    }

}
