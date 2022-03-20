using UnityEngine;

namespace SLC.Social.Leagues
{
    public class SeasonBegin_Window : MonoBehaviour
    {
        // Fields
        private SLC.Social.Leagues.LeaguesUIGuildTierDisplay tierDisplay;
        private UnityEngine.GameObject promotionGroup;
        private UnityEngine.GameObject demotionGroup;
        private bool wasPromoted;
        private bool wasDemoted;
        
        // Methods
        private void OnEnable()
        {
            this.Show();
        }
        private void Show()
        {
            var val_13;
            var val_14;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            this.wasPromoted = false;
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            this.wasDemoted = false;
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(52 > 1)
            {
                    SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
                val_13 = 60;
            }
            else
            {
                    SLC.Social.Leagues.LeaguesDataController val_6 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_7 = 0.MyGuild;
                val_13 = 28;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(52 > 1)
            {
                    SLC.Social.Leagues.LeaguesDataController val_10 = SLC.Social.Leagues.LeaguesManager.DAO;
                val_14 = 64;
            }
            else
            {
                    SLC.Social.Leagues.LeaguesDataController val_11 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_12 = 0.MyGuild;
                val_14 = 20;
            }
            
            this.tierDisplay.UpdateRankUI(guildRank:  52, tier:  1, showRank:  false);
            this.tierDisplay.UpdateTierUI(guildTier:  1);
            this.promotionGroup.SetActive(value:  false);
            this.demotionGroup.SetActive(value:  false);
            this.CancelInvoke();
            this.Invoke(methodName:  887891328, time:  null);
        }
        private void NextPhase()
        {
            if(this.wasPromoted == false)
            {
                    true = this.wasDemoted;
            }
            
            if(true != false)
            {
                    if(this.wasPromoted == true)
            {
                    this.wasPromoted = 1;
            }
            
                this.promotionGroup.SetActive(value:  true);
                if(this.wasDemoted == true)
            {
                    this.wasDemoted = 1;
            }
            
                this.demotionGroup.SetActive(value:  true);
                this.Invoke(methodName:  888028000, time:  null);
                return;
            }
            
            this.ShowNewRank();
        }
        private void ShowNewRank()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            this.tierDisplay.UpdateTierUI(guildTier:  1);
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_4 = 0.MyGuild;
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_6 = 0.MyGuild;
            this.tierDisplay.UpdateRankUI(guildRank:  52, tier:  1, showRank:  false);
        }
        private void OnDisable()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            mem[56] = 0;
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            mem[57] = 0;
        }
        public SeasonBegin_Window()
        {
        
        }
    
    }

}
