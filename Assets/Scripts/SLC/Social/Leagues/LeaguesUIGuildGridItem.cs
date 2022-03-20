using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIGuildGridItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image bgImage;
        private UnityEngine.UI.Image bgTileImage;
        private UnityEngine.UI.Image GuildImage;
        private UnityEngine.UI.Text GuildNameText;
        private UnityEngine.UI.Text GuildMemberCountText;
        private UnityEngine.UI.Text LeaguePointsAmount;
        private UnityEngine.GameObject league_points_section;
        private UnityEngine.GameObject member_count_section;
        private UnityEngine.UI.Text GuildTierText;
        private TMPro.TextMeshProUGUI GuildTierTextMesh;
        private UnityEngine.UI.Text Rank;
        private UnityEngine.GameObject RankGameObject;
        private UnityEngine.GameObject YourClubObject;
        private UnityEngine.Sprite notYou;
        private UnityEngine.Sprite you;
        private UnityEngine.Sprite notYouBG;
        private UnityEngine.Sprite youBG;
        private UnityEngine.Color normalColor;
        private UnityEngine.Color promotionColor;
        private UnityEngine.Color demotionColor;
        private UnityEngine.GameObject up_arrow_promotion;
        private UnityEngine.GameObject down_arrow_demotion;
        private UnityEngine.UI.Text seasonRewardPointsText;
        private int guildDisplaying;
        private SLC.Social.Leagues.Guild guild;
        private bool clickable;
        
        // Methods
        public void SetClickable(bool clickable)
        {
            this.clickable = clickable;
        }
        public void UpdateUIFromGuild(int guildId, bool rankingView = False, bool showMemberCount = False, int finalSeasonRank = -1)
        {
            if(guildId != 1)
            {
                    this.guildDisplaying = guildId;
                SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_2 = GetGuild(guildId:  guildId);
                this.guild = null;
                this.UpdateUIFromGuild(guild:  441638912, rankingView:  rankingView, showMemberCount:  showMemberCount, finalSeasonRank:  finalSeasonRank);
                return;
            }
            
            UnityEngine.GameObject val_3 = this.gameObject;
            this.SetActive(value:  false);
        }
        public void UpdateUIFromGuild(SLC.Social.Leagues.Guild guild, bool rankingView = False, bool showMemberCount = False, int finalSeasonRank = -1)
        {
            var val_48;
            UnityEngine.UI.Text val_49;
            int val_50;
            int val_51;
            var val_52;
            var val_53;
            int val_54;
            TMPro.TextMeshProUGUI val_55;
            var val_56;
            var val_57;
            var val_58;
            UnityEngine.UI.Image val_59;
            UnityEngine.Sprite val_60;
            val_48 = rankingView;
            UnityEngine.GameObject val_1 = this.gameObject;
            val_50 = this;
            if(guild == 0)
            {
                goto label_2;
            }
            
            this.SetActive(value:  true);
            this.guildDisplaying = guild.ServerId;
            if(this.GuildImage != 0)
            {
                    SLC.Social.AvatarConfig val_3 = SLC.Social.Leagues.LeaguesUIManager.guildAvatarHandler;
                UnityEngine.Sprite val_4 = GetAvatarSpriteByID(id:  guild.AvatarId);
                this.GuildImage.sprite = 442916864;
            }
            
            UnityEngine.GameObject val_5 = this.GuildMemberCountText.gameObject;
            val_50 = this.GuildMemberCountText;
            if(showMemberCount == false)
            {
                goto label_13;
            }
            
            val_50.SetActive(value:  true);
            string val_6 = System.String.Format(format:  -1225078832, arg0:  13152256);
            val_50 = "{0}";
            if(this.GuildMemberCountText != 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_2:
            this.SetActive(value:  false);
            return;
            label_13:
            val_50.SetActive(value:  false);
            label_15:
            this.RankGameObject.SetActive(value:  false);
            if(val_48 == false)
            {
                goto label_18;
            }
            
            UnityEngine.GameObject val_7 = this.GuildTierText.gameObject;
            this.GuildTierText.SetActive(value:  false);
            UnityEngine.GameObject val_8 = this.GuildTierTextMesh.gameObject;
            this.GuildTierTextMesh.SetActive(value:  false);
            this.league_points_section.SetActive(value:  true);
            decimal val_9 = guild.MemberCount.LeaguePointsFinal;
            GameEcon val_10 = App.getGameEcon;
            val_50 = finalSeasonRank;
            string val_11 = ToString(format:  null);
            val_49;
            if(val_50 < 0)
            {
                goto label_28;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(null != 0)
            {
                goto label_32;
            }
            
            goto label_32;
            label_18:
            val_48 = 1152921504765685760;
            this.league_points_section.SetActive(value:  false);
            if(guild.tier == 1)
            {
                goto label_34;
            }
            
            if(guild.tier != 0)
            {
                goto label_35;
            }
            
            UnityEngine.Debug.LogError(message:  854530576);
            goto label_69;
            label_28:
            val_51 = guild.tier;
            label_32:
            val_52 = 0;
            val_53 = 0;
            this.member_count_section.SetActive(value:  false);
            if(val_50 <= 1)
            {
                goto label_40;
            }
            
            if(this.seasonRewardPointsText == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.SeasonReward val_14 = SLC.Social.Leagues.LeaguesEconomy.GetSeasonRewardForTier(tier:  val_51);
            decimal val_15 = guild.MemberCount.GetCategory4Reward;
            val_54 = guild;
            if(guild.rank <= 2)
            {
                goto label_47;
            }
            
            if(guild.rank <= 5)
            {
                goto label_48;
            }
            
            if(guild.rank > 11)
            {
                goto label_49;
            }
            
            decimal val_16 = guild.MemberCount.GetCategory3Reward;
            goto label_71;
            label_40:
            val_54 = guild.rank;
            val_48 = 1152921504765685760;
            goto label_52;
            label_34:
            UnityEngine.GameObject val_17 = this.GuildTierText.gameObject;
            this.GuildTierText.SetActive(value:  false);
            UnityEngine.GameObject val_18 = this.GuildTierTextMesh.gameObject;
            this.GuildTierTextMesh.SetActive(value:  true);
            val_55 = this.GuildTierTextMesh;
            string val_19 = SLC.Social.Leagues.GuildTierLoc.GetLocalizedTier(tier:  guild.tier);
            val_49 = guild.tier;
            if(val_55 != 0)
            {
                goto label_69;
            }
            
            goto label_69;
            label_35:
            UnityEngine.GameObject val_20 = this.GuildTierTextMesh.gameObject;
            this.GuildTierTextMesh.SetActive(value:  false);
            UnityEngine.GameObject val_21 = this.GuildTierText.gameObject;
            this.GuildTierText.SetActive(value:  true);
            val_55 = this.GuildTierText;
            val_56 = null;
            val_56 = null;
            val_50 = SLC.Social.Leagues.LeaguesUIGuildTierDisplay.TierTextHexColors;
            int val_22 = SLC.Social.Leagues.LeaguesUIGuildTierDisplay.GuildTierToSimpleType.Item[guild.tier];
            if((SLC.Social.Leagues.LeaguesUIGuildTierDisplay.TierTextHexColors + 12) <= val_22)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_48 = SLC.Social.Leagues.LeaguesUIGuildTierDisplay.TierTextHexColors + 8;
            val_48 = val_48 + (val_22 << 2);
            string val_23 = SLC.Social.Leagues.GuildTierLoc.GetLocalizedTier(tier:  guild.tier);
            string val_24 = System.String.Format(format:  -1670416656, arg0:  (SLC.Social.Leagues.LeaguesUIGuildTierDisplay.TierTextHexColors + 8 + (val_22) << 2) + 16, arg1:  guild.tier);
            val_49 = "<color=#{0}>{1}</color>";
            goto label_69;
            label_47:
            decimal val_25 = guild.MemberCount.GetCategory1Reward;
            goto label_71;
            label_48:
            decimal val_26 = guild.MemberCount.GetCategory2Reward;
            label_71:
            label_49:
            GameEcon val_27 = App.getGameEcon;
            val_48 = 1152921504765685760;
            string val_28 = ToString(format:  null);
            val_52 = ;
            label_52:
            if((val_51 == 1) || ((guild + 28) > 2))
            {
                goto label_78;
            }
            
            val_49 = this.Rank;
            val_50 = 0;
            string val_29 = UnityEngine.ColorUtility.ToHtmlStringRGB(color:  new UnityEngine.Color() {r = mem[this.promotionColor + (0)], g = mem[this.promotionColor + (4)], b = mem[this.promotionColor + (8)], a = mem[this.promotionColor + (12)]});
            string val_30 = guild + 28.ToString();
            string val_31 = System.String.Format(format:  -1670416656, arg0:  mem[this.promotionColor + (0)], arg1:  guild + 28);
            if((UnityEngine.Object.op_Implicit(exists:  this.up_arrow_promotion)) == false)
            {
                goto label_100;
            }
            
            val_57 = 1;
            goto label_84;
            label_78:
            val_49 = this.Rank;
            if((val_51 == 15) || ((guild + 28) < 12))
            {
                goto label_86;
            }
            
            val_50 = 0;
            string val_33 = UnityEngine.ColorUtility.ToHtmlStringRGB(color:  new UnityEngine.Color() {r = mem[this.demotionColor + (0)], g = mem[this.demotionColor + (4)], b = mem[this.demotionColor + (8)], a = mem[this.demotionColor + (12)]});
            string val_34 = guild + 28.ToString();
            string val_35 = System.String.Format(format:  -1670416656, arg0:  mem[this.demotionColor + (0)], arg1:  guild + 28);
            if((UnityEngine.Object.op_Implicit(exists:  this.up_arrow_promotion)) != false)
            {
                    this.up_arrow_promotion.SetActive(value:  false);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  this.down_arrow_demotion)) == false)
            {
                goto label_104;
            }
            
            val_58 = 1;
            goto label_96;
            label_86:
            val_50 = 0;
            string val_38 = UnityEngine.ColorUtility.ToHtmlStringRGB(color:  new UnityEngine.Color() {r = mem[this.normalColor + (0)], g = mem[this.normalColor + (4)], b = mem[this.normalColor + (8)], a = mem[this.normalColor + (12)]});
            string val_39 = guild + 28.ToString();
            string val_40 = System.String.Format(format:  -1670416656, arg0:  mem[this.normalColor + (0)], arg1:  guild + 28);
            if((UnityEngine.Object.op_Implicit(exists:  this.up_arrow_promotion)) == false)
            {
                goto label_100;
            }
            
            val_57 = 0;
            label_84:
            this.up_arrow_promotion.SetActive(value:  false);
            label_100:
            if((UnityEngine.Object.op_Implicit(exists:  this.down_arrow_demotion)) == false)
            {
                goto label_104;
            }
            
            val_58 = 0;
            label_96:
            this.down_arrow_demotion.SetActive(value:  false);
            label_104:
            this.RankGameObject.SetActive(value:  true);
            label_69:
            if(this.YourClubObject == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_44 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_45 = MyGuild;
            if(null != 0)
            {
                    SLC.Social.Leagues.LeaguesDataController val_46 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_47 = MyGuild;
                val_49 = true;
                this.YourClubObject.SetActive(value:  true);
                this.clickable = val_49;
                this.bgImage.sprite = this.you;
                val_59 = this.bgTileImage;
                val_60 = this.youBG;
            }
            else
            {
                    this.YourClubObject.SetActive(value:  false);
                this.bgImage.sprite = this.notYou;
                val_59 = this.bgTileImage;
                val_60 = this.notYouBG;
            }
            
            val_59.sprite = val_60;
        }
        public void OnClickGuildItem()
        {
            if(this.clickable == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGuildInfoPopup(guildId:  this.guildDisplaying);
        }
        public void OnClick_JoinButton()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            RespondToClubInvite(clubID:  this.guildDisplaying, accepted:  true);
        }
        public void OnClick_IgnoreButton()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            RespondToClubInvite(clubID:  this.guildDisplaying, accepted:  false);
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            RemoveGuildInviteById(guildId:  this.guildDisplaying);
            UnityEngine.GameObject val_3 = this.gameObject;
            this.SetActive(value:  false);
        }
        public LeaguesUIGuildGridItem()
        {
            UnityEngine.Color32 val_1 = new UnityEngine.Color32(r:  255, g:  255, b:  255, a:  255);
            UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 16, g = 15, b = 251, a = 50});
            UnityEngine.Color32 val_3 = new UnityEngine.Color32(r:  0, g:  255, b:  1, a:  255);
            UnityEngine.Color val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 240, g = 14, b = 251, a = 50});
            UnityEngine.Color32 val_5 = new UnityEngine.Color32(r:  253, g:  0, b:  0, a:  255);
            UnityEngine.Color val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 208, g = 14, b = 251, a = 50});
            this.guildDisplaying = 0;
            this.clickable = true;
        }
    
    }

}
