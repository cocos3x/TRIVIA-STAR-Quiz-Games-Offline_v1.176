using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_ShowTierRewardsButton : LeaguesUI_OnClickButton
    {
        // Methods
        protected override void OnClickAction()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public LeaguesUI_ShowTierRewardsButton()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
