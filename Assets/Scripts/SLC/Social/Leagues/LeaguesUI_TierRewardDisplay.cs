using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_TierRewardDisplay : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text rankText;
        private UnityEngine.UI.Text rewardText;
        private SLC.Social.Leagues.LeaguesUIGuildTierDisplay leagueText;
        private UnityEngine.GameObject[] upArrows;
        private UnityEngine.GameObject[] downArrows;
        
        // Methods
        public void UpdateFromLeagueTier(int rank, int tier)
        {
            SLC.Social.Leagues.GuildTier val_21;
            int val_22;
            SLC.Social.Leagues.LeaguesUIGuildTierDisplay val_23;
            float val_24;
            UnityEngine.GameObject[] val_25;
            val_21 = tier;
            val_22 = rank;
            SLC.Social.Leagues.SeasonReward val_1 = SLC.Social.Leagues.LeaguesEconomy.GetSeasonRewardForTier(tier:  val_21);
            val_23 = val_21;
            val_24 = 1152921504765685760;
            bool val_2 = UnityEngine.Object.op_Implicit(exists:  this.rankText);
            this.rankText.ShowArrows(arrows:  this.upArrows, active:  false);
            this.rankText.ShowArrows(arrows:  this.downArrows, active:  false);
            int val_3 = val_22 - 1;
            if(val_3 > 6)
            {
                goto label_39;
            }
            
            var val_4 = 11207824 + (11207824 + ((rank - 1)) << 2);
            if(val_3 == 6)
            {
                    11207824 + ((rank - 1)) << 2 = (11207824 + ((rank - 1)) << 2) & ((IP) << 11207824 + ((rank - 1)) << 2);
                11207824 + ((rank - 1)) << 2 = (11207824 + ((rank - 1)) << 2) & ((IP) << (11207824 + ((rank - 1)) << 2 & (IP) << 11207824 + ((rank - 1)) << 2));
                11207824 + ((rank - 1)) << 2 = (11207824 + ((rank - 1)) << 2) & ((11207824 + ((rank - 1)) << 2) >> 2);
                mem2[0] = (((11207824 + ((rank - 1)) << 2 & (IP) << 11207824 + ((rank - 1)) << 2) & (IP) << (11207824 + ((rank - 1)) << 2 & (IP) << 11207824 + ((rank - 1)) << 2)) & ((int)((11207824 + ((rank - 1)) << 2 & (IP) < + (((11207824 + ((rank - 1)) << 2 & (IP) << 11207824 + ((rank - 1)) << 2) & (IP) << (11207824 + ((rank - 1)) << 2 & (IP) << 11207824 + ((rank - 1)) << 2)) & ((int)((11207824 + ((rank - 1)) << 2 & (IP) <;
            }
            
            decimal val_5 = GetCategory1Reward;
            if((UnityEngine.Object.op_Implicit(exists:  this.rankText)) != false)
            {
                    string val_7 = rank.ToString();
            }
            
            val_23 = this.leagueText;
            if(val_21 < 2)
            {
                goto label_14;
            }
            
            val_23.UpdateTierUI(guildTier:  val_21 - 1);
            val_25 = this.upArrows;
            goto label_15;
            label_14:
            UpdateTierUI(guildTier:  val_21);
            goto label_39;
            label_15:
            ShowArrows(arrows:  null, active:  true);
            label_39:
            if((UnityEngine.Object.op_Implicit(exists:  this.rewardText)) == false)
            {
                    return;
            }
            
            val_24 = this.rewardText;
            val_21 = 0;
            decimal val_19 = new System.Decimal(value:  1000);
            val_22 = val_19.flags;
            val_23 = val_19.hi;
            string val_20 = MetricSystem.Abbreviate(number:  new System.Decimal() {flags = D8, hi = D8, lo = D9, mid = D9}, maxSigFigs:  3, round:  true, useColor:  true, maxValueWithoutAbbr:  new System.Decimal() {flags = val_22, hi = val_23, lo = val_19.lo, mid = val_19.mid}, useRichText:  true, withSpaces:  false);
        }
        public void ShowArrows(UnityEngine.GameObject[] arrows, bool active)
        {
            if(arrows == null)
            {
                    return;
            }
            
            if(this < 1)
            {
                    return;
            }
            
            var val_1 = 0;
            do
            {
                1152921506252527328.SetActive(value:  active);
                val_1 = val_1 + 1;
            }
            while(val_1 < 1152921506252527328);
        
        }
        public LeaguesUI_TierRewardDisplay()
        {
        
        }
    
    }

}
