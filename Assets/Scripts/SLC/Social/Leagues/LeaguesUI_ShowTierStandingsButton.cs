using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_ShowTierStandingsButton : LeaguesUI_OnClickButton
    {
        // Methods
        protected override void OnClickAction()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowTierStandingsContainer();
        }
        public LeaguesUI_ShowTierStandingsButton()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
