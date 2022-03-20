using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_ShowHasClubButton : LeaguesUI_OnClickButton
    {
        // Methods
        protected override void OnClickAction()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowHasGuildContainer();
        }
        public LeaguesUI_ShowHasClubButton()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
