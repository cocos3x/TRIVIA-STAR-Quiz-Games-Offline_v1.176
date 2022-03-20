using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_MyClubLevelDetails : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text clubLevelText;
        private UnityEngine.UI.Slider clubLevelSlider;
        private UnityEngine.UI.Text clubMemberCountText;
        private UnityEngine.UI.Button contributeButton;
        
        // Properties
        private SLC.Social.Leagues.Guild CurrentGuild { get; }
        
        // Methods
        private SLC.Social.Leagues.Guild get_CurrentGuild()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0 != 0)
            {
                    return 0.MyGuild;
            }
            
            return 0.MyGuild;
        }
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  868387040, method:  new IntPtr(868362016));
            this.contributeButton.m_OnClick.AddListener(call:  162246656);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  868387040, name:  442544128);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  868387040, name:  442544128);
        }
        private void OnMyProfileUpdate()
        {
            this.Refresh();
        }
        private void OnGuildMembersUpdate()
        {
            this.Refresh();
        }
        public void Refresh()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(this.activeInHierarchy == false)
            {
                    return;
            }
            
            R4.DoRefresh();
        }
        private void OnEnable()
        {
            this.DoRefresh();
        }
        private void DoRefresh()
        {
            int val_22;
            int val_23;
            int val_33;
            int val_34;
            var val_35;
            int val_36;
            int val_37;
            int val_39;
            bool val_42;
            var val_43;
            var val_44;
            int val_45;
            UnityEngine.UI.Slider val_46;
            val_42 = static_value_021FC295;
            if(val_42 != true)
            {
                    val_42 = true;
            }
            
            SLC.Social.Leagues.Guild val_1 = this.CurrentGuild;
            if(val_42 == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.Guild val_2 = this.CurrentGuild;
            SLC.Social.Leagues.Guild val_3 = CurrentGuild;
            string val_4 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            if((UnityEngine.Object.op_Implicit(exists:  this.clubMemberCountText)) != false)
            {
                    val_43 = this.clubMemberCountText;
            }
            
            SLC.Social.Leagues.Guild val_6 = val_43.CurrentGuild;
            string val_7 = this.clubMemberCountText.m_TextCache.ToString();
            val_44 = 1152921505048485888;
            SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_9 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_10 = 0.Level;
            SLC.Social.Leagues.LeaguesDataController val_11 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_12 = 0.MyGuild;
            val_45 = 0;
            SLC.Social.Leagues.GuildLevel val_13 = val_45.NextLevel;
            if(0 != val_45)
            {
                    SLC.Social.Leagues.LeaguesDataController val_14 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_15 = 0.MyGuild;
                SLC.Social.Leagues.GuildLevel val_16 = 0.Level;
                decimal val_17 = 100670464.CoinSupportRequired;
                SLC.Social.Leagues.LeaguesDataController val_18 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_19 = 0.MyGuild;
                SLC.Social.Leagues.GuildLevel val_20 = 0.NextLevel;
                decimal val_21 = 100670464.CoinSupportRequired;
                SLC.Social.Leagues.LeaguesDataController val_25 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_26 = 0.MyGuild;
                decimal val_27 = System.Int32.__il2cppRuntimeField_element_class.GetLeagueContributedCoins;
                SLC.Social.Leagues.LeaguesDataController val_28 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_29 = 0.MyGuild;
                SLC.Social.Leagues.LeaguesDataController val_30 = SLC.Social.Leagues.LeaguesManager.DAO;
                SLC.Social.Leagues.Guild val_31 = 0.MyGuild;
                decimal val_32 = ProgressThisLevel(currentLevel:  0);
                val_45 = val_33;
                val_44 = val_35;
                decimal val_38 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 868963612, hi = System.Int32.__il2cppRuntimeField_element_class}, d2:  new System.Decimal() {flags = val_34, hi = val_45, lo = val_37, mid = val_36});
                val_46 = this.clubLevelSlider;
                decimal val_40 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 868963596}, d2:  new System.Decimal() {flags = val_39, hi = 100670464, lo = val_22, mid = val_23});
                float val_41 = System.Decimal.op_Explicit(value:  new System.Decimal());
                if(val_46 != 0)
            {
                    return;
            }
            
                return;
            }
            
            val_46 = this.clubLevelSlider;
        }
        private void OnContributeButtonPressed()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-747685408) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnShowContributePopup();
        }
        public LeaguesUI_MyClubLevelDetails()
        {
        
        }
    
    }

}
