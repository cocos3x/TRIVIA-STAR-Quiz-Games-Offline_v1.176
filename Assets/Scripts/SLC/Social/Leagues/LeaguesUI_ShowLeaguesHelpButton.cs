using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_ShowLeaguesHelpButton : LeaguesUI_OnClickButton
    {
        // Fields
        private bool showLeaguesHelp;
        
        // Methods
        protected override void OnClickAction()
        {
            var val_6;
            var val_7;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            if(0 != 0)
            {
                    if(this.showLeaguesHelp == false)
            {
                goto label_5;
            }
            
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = public static SLC.Social.Leagues.LeaguesWindowManager MonoSingleton<SLC.Social.Leagues.LeaguesWindowManager>::get_Instance();
            val_7 = 1152921514067363968;
            goto label_9;
            label_5:
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = public static SLC.Social.Leagues.LeaguesWindowManager MonoSingleton<SLC.Social.Leagues.LeaguesWindowManager>::get_Instance();
            val_7 = 1152921514067364992;
            label_9:
            object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public LeaguesUI_ShowLeaguesHelpButton()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
