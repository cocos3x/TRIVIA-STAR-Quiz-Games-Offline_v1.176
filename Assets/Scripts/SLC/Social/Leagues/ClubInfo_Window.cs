using UnityEngine;

namespace SLC.Social.Leagues
{
    public class ClubInfo_Window : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text leaguePoints;
        private UnityEngine.UI.Text activeMembers;
        private UnityEngine.UI.Text vipRequirement;
        private UnityEngine.UI.Image requirementMetByYou;
        private UGUINetworkedButton joinButton;
        private UnityEngine.UI.Text joinButtonText;
        private UnityEngine.GameObject errorTooltip;
        private UnityEngine.UI.Text errorTooltipMessage;
        private UnityEngine.UI.Image errorTooltipCurrencyImage;
        private SLC.Social.Leagues.LeaguesUIMembersView membersView;
        private SLC.Social.Leagues.LeaguesUIGuildDisplay infoDisplay;
        private int currentGuildId;
        private int guildIdToDisplay;
        private System.Action onDisable_callback;
        private float nextSlowRefresh;
        
        // Properties
        private SLC.Social.Leagues.Guild CurrentGuild { get; }
        public System.Action OnDisable_callback { set; }
        
        // Methods
        private SLC.Social.Leagues.Guild get_CurrentGuild()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0 != 0)
            {
                    return 0.GetGuild(guildId:  this.currentGuildId);
            }
            
            return 0.GetGuild(guildId:  this.currentGuildId);
        }
        public void set_OnDisable_callback(System.Action value)
        {
            this.onDisable_callback = value;
        }
        private void Start()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  873310048, name:  442544128);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  873310048, name:  442544128);
            System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  873310048, method:  new IntPtr(873285024));
            this.joinButton.OnConnectionClick = null;
        }
        private void OnEnable()
        {
            this.RequestGuildUpdate();
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.time;
            if()
            {
                    return;
            }
            
            R4.RequestGuildUpdate();
        }
        private void RequestGuildUpdate()
        {
            var val_4;
            if(this.guildIdToDisplay == 1)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.time;
            val_4 = null;
            val_4 = null;
            float val_4 = SLC.Social.Leagues.LeaguesManager.SlowRefreshRequestInterval;
            val_4 = 0 + val_4;
            this.nextSlowRefresh = val_4;
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_3 = 0.GetGuildAndMembers(guildId:  this.guildIdToDisplay);
        }
        public void OnMyGuildUpdate()
        {
            this.RefreshInfoAndMembers();
        }
        public void OnGuildListUpdate()
        {
            this.RefreshInfoAndMembers();
        }
        public void ShowGuild(int guildId)
        {
            this.guildIdToDisplay = guildId;
            this.RequestGuildUpdate();
            this.RefreshInfoAndMembers();
        }
        private void RefreshInfoAndMembers()
        {
            this.Refresh();
            this.infoDisplay.Refresh(guildId:  this.guildIdToDisplay);
            this.membersView.Refresh(guildId:  this.guildIdToDisplay);
        }
        private void Refresh()
        {
            UnityEngine.UI.Image val_31;
            var val_32;
            var val_33;
            this.currentGuildId = this.guildIdToDisplay;
            SLC.Social.Leagues.Guild val_1 = this.CurrentGuild;
            if(this == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.Guild val_2 = this.CurrentGuild;
            decimal val_3 = LeaguePointsFinal;
            GameEcon val_4 = App.getGameEcon;
            string val_5 = ToString(format:  null);
            SLC.Social.Leagues.Guild val_6 = this.CurrentGuild;
            SLC.Social.Leagues.Guild val_7 = this.CurrentGuild;
            string val_8 = Localization.Localize(key:  874218912, defaultValue:  874219008, useSingularKey:  false);
            string val_9 = System.String.Format(format:  -1630882640, arg0:  13152256, arg1:  13152256, arg2:  874218912);
            GameBehavior val_10 = App.getBehavior;
            SLC.Social.Leagues.Guild val_11 = this.CurrentGuild;
            UnityEngine.GameObject val_12 = this.joinButton.gameObject;
            this.joinButton.SetActive(value:  false);
            SLC.Social.Leagues.Guild val_13 = this.CurrentGuild;
            SLC.Social.Leagues.LeaguesDataController val_14 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_15 = 0.MyProfile;
            GameBehavior val_16 = App.getBehavior;
            if(0 == 0)
            {
                goto label_21;
            }
            
            if(this.errorTooltipMessage <= (5.739719E-42f))
            {
                goto label_24;
            }
            
            UnityEngine.Color val_17 = UnityEngine.Color.red;
            this.vipRequirement.color = new UnityEngine.Color() {a = ???};
            goto label_24;
            label_21:
            this.joinButton.interactable = true;
            label_24:
            SLC.Social.Leagues.Guild val_18 = this.CurrentGuild;
            GameEcon val_19 = App.getGameEcon;
            val_31 = 0;
            string val_20 = this.errorTooltipMessage.ToString(format:  null);
            SLC.Social.Leagues.Guild val_21 = this.CurrentGuild;
            val_32 = this;
            UnityEngine.GameObject val_22 = this.requirementMetByYou.gameObject;
            if(this.errorTooltipMessage == 0)
            {
                goto label_34;
            }
            
            this.requirementMetByYou.SetActive(value:  true);
            GameBehavior val_23 = App.getBehavior;
            if(0 == 0)
            {
                goto label_39;
            }
            
            val_33 = 1;
            goto label_41;
            label_34:
            this.requirementMetByYou.SetActive(value:  false);
            goto label_42;
            label_39:
            if(this.errorTooltipMessage <= (5.739719E-42f))
            {
                    val_33 = 1;
            }
            
            label_41:
            this.joinButton.interactable = true;
            label_42:
            SLC.Social.Leagues.Guild val_24 = this.CurrentGuild;
            if(this.errorTooltip == 0)
            {
                goto label_45;
            }
            
            SLC.Social.Leagues.Guild val_25 = this.CurrentGuild;
            val_31 = this.errorTooltipCurrencyImage;
            SLC.Social.Leagues.LeaguesDataController val_26 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_27 = 0.MyProfile;
            val_32 = 0;
            if(val_31 != 0)
            {
                goto label_51;
            }
            
            string val_28 = Localization.Localize(key:  874264256, defaultValue:  874264160, useSingularKey:  false);
            val_32 = "requested_upper";
            this.joinButton.interactable = false;
            return;
            label_45:
            string val_29 = Localization.Localize(key:  825670240, defaultValue:  825670032, useSingularKey:  false);
            if(this.joinButtonText != 0)
            {
                    return;
            }
            
            return;
            label_51:
            string val_30 = Localization.Localize(key:  874272656, defaultValue:  874272560, useSingularKey:  false);
        }
        private void OnJoinGuildClick(bool result)
        {
            var val_27;
            UnityEngine.UI.Text val_28;
            UnityEngine.UI.Image val_29;
            float val_30;
            UnityEngine.UI.Text val_31;
            UnityEngine.UI.Text val_32;
            var val_33;
            var val_34;
            var val_35;
            val_27 = this;
            if(result == false)
            {
                goto label_1;
            }
            
            SLC.Social.Leagues.Guild val_1 = this.CurrentGuild;
            val_28 = this.errorTooltipMessage;
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_3 = 0.MyProfile;
            val_29 = 4096;
            SLC.Social.Leagues.Guild val_4 = this.CurrentGuild;
            SLC.Social.Leagues.Guild val_5 = this.CurrentGuild;
            val_30 = 1152921504892043264;
            val_31 = this.joinButtonText;
            GameBehavior val_6 = App.getBehavior;
            if(0 != 0)
            {
                    if(this.errorTooltipCurrencyImage != 0)
            {
                    UnityEngine.GameObject val_8 = this.errorTooltipCurrencyImage.gameObject;
                this.errorTooltipCurrencyImage.SetActive(value:  false);
            }
            
            }
            
            if(val_28 <= val_29)
            {
                goto label_19;
            }
            
            GameBehavior val_9 = App.getBehavior;
            if(0 != 0)
            {
                    if(this.errorTooltipCurrencyImage != 0)
            {
                    UnityEngine.GameObject val_11 = this.errorTooltipCurrencyImage.gameObject;
                this.errorTooltipCurrencyImage.SetActive(value:  true);
            }
            
            }
            
            this.errorTooltip.SetActive(value:  true);
            val_32 = this.errorTooltipMessage;
            string val_12 = Localization.Localize(key:  874491376, defaultValue:  874491248, useSingularKey:  false);
            GameBehavior val_13 = App.getBehavior;
            val_29 = 0;
            val_33 = "clubs_item_requirement_not_met";
            string val_14 = System.String.Format(format:  874491376, arg0:  0);
            goto label_35;
            label_1:
            UnityEngine.GameObject val_15 = this.gameObject;
            SLCWindow.CloseWindow(window:  874540496, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowConnectionRequired();
            return;
            label_19:
            if(this.membersView >= val_31)
            {
                goto label_39;
            }
            
            SLC.Social.Leagues.Guild val_17 = this.CurrentGuild;
            if(this.errorTooltip == 0)
            {
                goto label_47;
            }
            
            SLC.Social.Leagues.Guild val_18 = this.CurrentGuild;
            val_29 = this.errorTooltipCurrencyImage;
            SLC.Social.Leagues.LeaguesDataController val_19 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_20 = 0.MyProfile;
            if(val_29 != 0)
            {
                goto label_47;
            }
            
            this.errorTooltip.SetActive(value:  true);
            val_32 = this.errorTooltipMessage;
            val_34 = "Request already sent!";
            val_35 = "request_already_sent";
            goto label_49;
            label_39:
            this.errorTooltip.SetActive(value:  true);
            val_32 = this.errorTooltipMessage;
            val_34 = "Club is full!";
            val_35 = "club_full";
            label_49:
            string val_21 = Localization.Localize(key:  874516400, defaultValue:  874516304, useSingularKey:  false);
            label_35:
            if(val_32 != 0)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            }
            
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            label_47:
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Social.Leagues.Guild val_23 = R4.CurrentGuild;
            if((R4 + 36) != 0)
            {
                    R4 + 36 = 1;
            }
            
            OnLeaveGuildClicked(newGuildIdToJoin:  R4 + 56, inviteRequired:  true);
            UnityEngine.GameObject val_24 = R4.gameObject;
            var val_25 = FP - 28;
        }
        private void OnDisable()
        {
            if(this.onDisable_callback != 0)
            {
                    this.onDisable_callback.Invoke();
            }
            
            this.onDisable_callback = 0;
            this.errorTooltip.SetActive(value:  false);
        }
        public ClubInfo_Window()
        {
            this.nextSlowRefresh = 30f;
            this.guildIdToDisplay = 0;
        }
    
    }

}
