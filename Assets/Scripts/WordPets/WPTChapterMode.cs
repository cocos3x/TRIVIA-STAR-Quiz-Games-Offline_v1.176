using UnityEngine;

namespace WordPets
{
    public class WPTChapterMode : WPTGameMode
    {
        // Methods
        public override void StartLevel()
        {
            this.StartLevel();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Init(incData:  135630400);
        }
        public override void EndLevel()
        {
            this.EndLevel();
            Player val_1 = App.Player;
            var val_2 = 0 + 1;
            Player val_3 = App.Player;
            if(0 == 0)
            {
                
            }
        
        }
        public override void NextLevel()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = ShowInterstitial(context:  2);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LoadGame(mode:  0);
        }
        public override void RestartLevel()
        {
            this.RestartLevel();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LoadGame(mode:  0);
        }
        public WPTChapterMode()
        {
        
        }
    
    }

}
