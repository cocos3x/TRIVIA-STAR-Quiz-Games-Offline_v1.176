using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUIMemberGridItem : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button mainButton;
        private UnityEngine.UI.Text rankText;
        private UnityEngine.UI.Outline rankTextOutline;
        private AvatarSlotUGUI memberAvatarSlot;
        private UnityEngine.UI.Text memberNameText;
        private UnityEngine.GameObject memberPointsContributionGroup;
        private UnityEngine.UI.Text memberContributionText;
        private UnityEngine.UI.Text memberPointsText;
        private UnityEngine.GameObject leaderImage;
        private UnityEngine.GameObject coLeaderImage;
        private UnityEngine.GameObject inactiveImage;
        private UnityEngine.UI.Button acceptInviteButton;
        private UnityEngine.UI.Button rejectInviteButton;
        private UnityEngine.UI.Text acceptInviteButtonText;
        private UnityEngine.GameObject yourProfileObject;
        private UnityEngine.UI.Image goldenTicketImage;
        private UnityEngine.Sprite hasGT;
        private UnityEngine.Sprite noGT;
        private SLC.Social.Profile member;
        private SLC.Social.Leagues.GuildJoinRequest request;
        private System.Action<int> onClickAction;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  860230288, method:  new IntPtr(860205264));
            this.mainButton.m_OnClick.AddListener(call:  162246656);
        }
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  860368912, method:  new IntPtr(860334672));
            this.acceptInviteButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  860368912, method:  new IntPtr(860343888));
            this.rejectInviteButton.m_OnClick.AddListener(call:  162246656);
        }
        public void UpdateUIFromMember(SLC.Social.Profile member, int rank, bool showLeadersOptions, SLC.Social.Leagues.GuildJoinRequest request, bool showMVP = True, bool specialMVPMode = False, System.Action<int> clickOutAction)
        {
            float val_5;
            float val_6;
            float val_7;
            var val_42;
            SLC.Social.Profile val_43;
            bool val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            UnityEngine.GameObject val_1 = this.gameObject;
            if(member == 0)
            {
                goto label_2;
            }
            
            this.SetActive(value:  true);
            this.onClickAction = clickOutAction;
            this.member = member;
            if(rank < 1)
            {
                goto label_3;
            }
            
            string val_2 = +13152256;
            val_42 = null;
            goto label_4;
            label_2:
            this.SetActive(value:  false);
            return;
            label_3:
            val_42 = "<color=#FF0000FF>!</color>";
            label_4:
            if(rank < 1)
            {
                    0 = 1;
            }
            
            this.rankTextOutline.enabled = true;
            if(rank >= 1)
            {
                    UnityEngine.Color val_3 = UnityEngine.Color.black;
            }
            else
            {
                    UnityEngine.Color val_4 = UnityEngine.Color.white;
            }
            
            this.rankTextOutline.effectColor = new UnityEngine.Color() {r = rank, g = val_5, b = val_6, a = val_7};
            val_43 = member;
            if(specialMVPMode != true)
            {
                    decimal val_8 = rank.GetLeagueCoins;
                decimal val_9 = new System.Decimal(value:  1000);
                string val_10 = MetricSystem.Abbreviate(number:  new System.Decimal() {flags = rank}, maxSigFigs:  3, round:  true, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_9.flags, hi = val_9.hi, lo = val_9.lo, mid = val_9.mid}, useRichText:  false, withSpaces:  false);
                val_43 = member;
            }
            
            decimal val_11 = new System.Decimal(value:  1000);
            string val_12 = MetricSystem.Abbreviate(number:  new System.Decimal() {flags = member + 60, hi = member + 64, lo = member + 68, mid = member + 72}, maxSigFigs:  3, round:  true, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_11.flags, hi = val_11.hi, lo = val_11.lo, mid = val_11.mid}, useRichText:  false, withSpaces:  false);
            val_46 = showLeadersOptions;
            if(((member + 117) != 0) || (val_46 == false))
            {
                goto label_20;
            }
            
            mem[1152921514057320276].SetActive(value:  true);
            val_47 = 0;
            goto label_23;
            label_20:
            if(val_46 == true)
            {
                goto label_24;
            }
            
            if(val_46 == true)
            {
                goto label_25;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  mem[1152921514057320268])) != false)
            {
                    mem[1152921514057320268].SetActive(value:  false);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  mem[1152921514057320272])) != false)
            {
                    mem[1152921514057320272].SetActive(value:  false);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  mem[1152921514057320276])) == false)
            {
                goto label_36;
            }
            
            val_48 = mem[1152921514057320276];
            goto label_37;
            label_24:
            mem[1152921514057320276].SetActive(value:  false);
            val_47 = 1;
            label_23:
            mem[1152921514057320268].SetActive(value:  true);
            val_48 = mem[1152921514057320272];
            label_37:
            label_106:
            val_48.SetActive(value:  false);
            label_36:
            SLC.Social.Leagues.LeaguesDataController val_16 = SLC.Social.Leagues.LeaguesManager.DAO;
            mem[1152921514057320292].SetActive(value:  ((member + 8) - 0) >> 5);
            if(mem[1152921514057320296] != 0)
            {
                    if((member + 116) == 0)
            {
                    mem[1152921514057320292] = mem[1152921514057320304];
            }
            
                if((member + 116) != 0)
            {
                    mem[1152921514057320292] = mem[1152921514057320300];
            }
            
                mem[1152921514057320296].sprite = mem[1152921514057320292];
                UnityEngine.GameObject val_20 = mem[1152921514057320296].gameObject;
                GameBehavior val_21 = App.getBehavior;
                mem[1152921514057320296].SetActive(value:  false);
            }
            
            SLC.Social.Leagues.LeaguesDataController val_22 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_23 = 0.MyProfile;
            if(4 != 0)
            {
                goto label_59;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_24 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_49 = 0;
            SLC.Social.Profile val_25 = 0.MyProfile;
            if(0 == 0)
            {
                goto label_64;
            }
            
            label_59:
            SLC.Social.Leagues.LeaguesDataController val_26 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_27 = 0.MyProfile;
            if((member + 8) != 0)
            {
                    0 = member;
                0 = mem[member + 76];
                0 = member + 76;
                val_49 = 0 ^ 1;
            }
            
            label_64:
            if((val_49 & val_46) != 0)
            {
                goto label_69;
            }
            
            mem[1152921514057320312] = request;
            if((rank > 0) || (request == 0))
            {
                goto label_71;
            }
            
            UnityEngine.GameObject val_28 = mem[1152921514057320280].gameObject;
            mem[1152921514057320280].SetActive(value:  true);
            UnityEngine.GameObject val_29 = mem[1152921514057320284].gameObject;
            mem[1152921514057320284].SetActive(value:  true);
            UnityEngine.GameObject val_30 = mem[1152921514057320256].gameObject;
            val_50 = 0;
            goto label_79;
            label_69:
            UnityEngine.GameObject val_31 = mem[1152921514057320280].gameObject;
            mem[1152921514057320280].SetActive(value:  false);
            UnityEngine.GameObject val_32 = mem[1152921514057320284].gameObject;
            mem[1152921514057320284].SetActive(value:  false);
            UnityEngine.GameObject val_33 = mem[1152921514057320256].gameObject;
            mem[1152921514057320256].SetActive(value:  true);
            return;
            label_71:
            UnityEngine.GameObject val_34 = mem[1152921514057320280].gameObject;
            mem[1152921514057320280].SetActive(value:  false);
            UnityEngine.GameObject val_35 = mem[1152921514057320284].gameObject;
            mem[1152921514057320284].SetActive(value:  false);
            UnityEngine.GameObject val_36 = mem[1152921514057320256].gameObject;
            val_50 = 1;
            label_79:
            mem[1152921514057320256].SetActive(value:  true);
            SLC.Social.Leagues.LeaguesDataController val_37 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_38 = 0.MyGuild;
            val_49 = 1835037;
            SLC.Social.Leagues.LeaguesDataController val_39 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_40 = 0.MyGuild;
            if(val_49 == 35615780)
            {
                    mem[1152921514057320280].interactable = false;
                val_51 = mem[1152921514057320288];
                val_52 = "FULL";
                val_53 = "full_upper";
            }
            else
            {
                    mem[1152921514057320280].interactable = true;
                val_51 = mem[1152921514057320288];
                val_52 = "ACCEPT";
                val_53 = "accept_upper";
            }
            
            string val_41 = Localization.Localize(key:  860514560, defaultValue:  860514480, useSingularKey:  false);
            return;
            label_25:
            mem[1152921514057320276].SetActive(value:  false);
            mem[1152921514057320268].SetActive(value:  false);
            if(mem[1152921514057320272] != 0)
            {
                goto label_106;
            }
            
            goto label_106;
        }
        private void AcceptRequest_button()
        {
            this.request.AcceptRequest();
        }
        private void RejectRequest_button()
        {
            this.request.RejectRequest();
        }
        private void ToggleCoLeader_button()
        {
            if(this.member.Officer != false)
            {
                    SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
                0.DemoteMember(toDemote:  this.member, responseCallback:  0);
                return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            0.PromoteMember(toPromote:  this.member, responseCallback:  0);
        }
        private void RemovePlayer_button()
        {
        
        }
        private void OnClick()
        {
            if(this.onClickAction != 0)
            {
                    this.onClickAction.Invoke(obj:  this.member.ServerId);
                return;
            }
            
            UnityEngine.GameObject val_1 = this.gameObject;
            SLC.Social.Leagues.LeaguesUIManager.ShowPlayerProfile(serverId:  this.member.ServerId, gridItem:  861188768);
        }
        private void OnClick_ProMembership()
        {
            if(this.onClickAction == 0)
            {
                    return;
            }
            
            this.onClickAction.Invoke(obj:  0);
        }
        public LeaguesUIMemberGridItem()
        {
        
        }
    
    }

}
