using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_ShowNoClubButton : LeaguesUI_OnClickButton
    {
        // Methods
        protected override void OnClickAction()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowNoGuildContainer();
        }
        public LeaguesUI_ShowNoClubButton()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
