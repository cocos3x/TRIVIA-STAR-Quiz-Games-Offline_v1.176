using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIPlayButton : ButtonPlayGame
    {
        // Fields
        private bool restartButton;
        private bool previousProgression;
        
        // Methods
        protected override void Start()
        {
            var val_5;
            var val_6;
            this.previousProgression = UnityEngine.PlayerPrefs.HasKey(key:  775997600);
            this.Start();
            if(this.previousProgression == false)
            {
                goto label_1;
            }
            
            if(this.restartButton == false)
            {
                goto label_2;
            }
            
            val_5 = "RESTART";
            val_6 = "restart_upper";
            goto label_3;
            label_1:
            if(this.restartButton == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            this.SetActive(value:  false);
            return;
            label_2:
            val_5 = "RESUME";
            val_6 = "resume_upper";
            label_3:
            string val_3 = Localization.Localize(key:  793725360, defaultValue:  793725280, useSingularKey:  false);
            if(this == 0)
            {
                
            }
        
        }
        public override void OnButtonClick()
        {
            if(this.restartButton != false)
            {
                    SLC.MatchyPics.MPILevel.Restart();
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                bool val_2 = ShowInterstitial(context:  2);
            }
            
            this.OnButtonClick();
        }
        public MPIPlayButton()
        {
        
        }
    
    }

}
