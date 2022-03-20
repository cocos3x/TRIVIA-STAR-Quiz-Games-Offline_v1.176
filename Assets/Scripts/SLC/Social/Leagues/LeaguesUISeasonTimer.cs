using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeaguesUISeasonTimer : FrameSkipper
    {
        // Fields
        private const string timeFormat_dhms = "{0:00}:{1:00}:{2:00}:{3:00}";
        private const string timeFormat_dhm = "{0:00}:{1:00}:{2:00}";
        private UnityEngine.UI.Text timerText;
        private bool showSeconds;
        
        // Methods
        protected override void UpdateLogic()
        {
            long val_2;
            var val_3;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_11 = 0;
            System.TimeSpan val_1 = SLC.Social.Leagues.LeaguesManager.GetSeasonTimeRemaining();
            val_12 = val_3;
            val_13 = 1152921504622821376;
            val_14 = null;
            val_14 = null;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_2}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
            {
                    if(this.showSeconds == false)
            {
                    "{0:00}:{1:00}:{2:00}:{3:00}" = "{0:00}:{1:00}:{2:00}";
            }
            
                val_11 = "{0:00}:{1:00}:{2:00}";
                val_12 = null;
                val_2 = val_2.Days;
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
                int val_6 = val_2.Hours;
                typeof(System.Object[]).__il2cppRuntimeField_14 = null;
                int val_7 = val_2.Minutes;
                typeof(System.Object[]).__il2cppRuntimeField_18 = null;
                int val_8 = val_2.Seconds;
                val_13 = null;
                val_15 = val_11;
                typeof(System.Object[]).__il2cppRuntimeField_1C = val_13;
                string val_9 = System.String.Format(format:  -1662255760, args:  472754880);
            }
            else
            {
                    val_15 = "league_calculating_rewards";
                string val_10 = Localization.Localize(key:  863647328, defaultValue:  863647216, useSingularKey:  false);
            }
            
            if(this.timerText != 0)
            {
                    return;
            }
        
        }
        public LeaguesUISeasonTimer()
        {
            this.showSeconds = true;
        }
    
    }

}
