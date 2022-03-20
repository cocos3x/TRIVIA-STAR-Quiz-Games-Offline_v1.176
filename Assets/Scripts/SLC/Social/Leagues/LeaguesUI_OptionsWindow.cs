using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_OptionsWindow : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button leagueInfoButton;
        private UnityEngine.UI.Button contributeButton;
        private UnityEngine.UI.Button leaveClubButton;
        private UnityEngine.UI.Button editClubButton;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  884605616, method:  new IntPtr(884552944));
            this.leagueInfoButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  884605616, method:  new IntPtr(884562160));
            this.contributeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  884605616, method:  new IntPtr(884571376));
            this.leaveClubButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  884605616, method:  new IntPtr(884580592));
            this.editClubButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnEnable()
        {
            UnityEngine.GameObject val_1 = this.editClubButton.gameObject;
            SLC.Social.Leagues.LeaguesDataController val_2 = SLC.Social.Leagues.LeaguesManager.DAO;
            this.editClubButton.SetActive(value:  0.IsMaster);
        }
        private void OnLeagueInfoClick()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        private void OnContributeClick()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        private void OnLeaveClubClick()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLeaveGuildClicked(newGuildIdToJoin:  0, inviteRequired:  false);
        }
        private void OnEditClubClick()
        {
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            if(0.IsMaster != false)
            {
                    UnityEngine.GameObject val_3 = this.gameObject;
                this.SetActive(value:  false);
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
                return;
            }
            
            UnityEngine.GameObject val_6 = this.editClubButton.gameObject;
            this.editClubButton.SetActive(value:  false);
        }
        public LeaguesUI_OptionsWindow()
        {
        
        }
    
    }

}
