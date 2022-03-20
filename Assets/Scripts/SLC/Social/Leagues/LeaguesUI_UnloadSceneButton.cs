using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUI_UnloadSceneButton : LeaguesUI_OnClickButton
    {
        // Methods
        protected override void OnClickAction()
        {
            SLC.Social.Leagues.LeaguesUIManager.LeaveLeaguesScene();
        }
        public LeaguesUI_UnloadSceneButton()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
