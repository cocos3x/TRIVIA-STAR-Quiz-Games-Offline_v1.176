using UnityEngine;

namespace WordPets
{
    public class WPTLivesDisplayUI : FixedIntervalUpdater
    {
        // Fields
        private UnityEngine.UI.Text livesCounter;
        private UnityEngine.UI.Text livesCooldownTimer;
        private System.TimeSpan timerCooldownInterval;
        
        // Methods
        private void Awake()
        {
            System.TimeSpan val_5;
            WordPets.WPTGameEcon val_1 = WordPets.WPTGameEcon.Instance;
            var val_2 = 0 + 1376;
            System.TimeSpan val_3 = System.TimeSpan.FromMinutes(value:  null);
            this.timerCooldownInterval = val_5;
        }
        protected override void UpdateLogic()
        {
            ulong val_10;
            long val_16;
            var val_22;
            bool val_23;
            var val_24;
            val_22 = this;
            val_23 = static_value_021FCE55;
            if(val_23 != true)
            {
                    val_23 = true;
            }
            
            WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            string val_2 = 281.ToString();
            WordPets.WPTPlayer val_3 = WordPets.WPTPlayer.Instance;
            if(this.livesCounter.IsLivesMaxed() != false)
            {
                    string val_5 = Localization.Localize(key:  2128646960, defaultValue:  2128646880, useSingularKey:  false);
                val_24 = this.livesCooldownTimer;
            }
            else
            {
                    WordPets.WPTPlayer val_6 = WordPets.WPTPlayer.Instance;
                bool val_7 = val_24.RefreshPlayerLives();
                System.DateTime val_8 = DateTimeCheat.UtcNow;
                WordPets.WPTPlayer val_9 = WordPets.WPTPlayer.Instance;
                System.TimeSpan val_12 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513406611320}, d2:  new System.DateTime() {dateData = val_10});
                System.TimeSpan val_15 = System.TimeSpan.op_Subtraction(t1:  new System.TimeSpan() {_ticks = 1152921513406611312}, t2:  new System.TimeSpan() {_ticks = R4 + 32});
                string val_18 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_16}, formatted:  true);
                var val_19 = FP - 24;
            }
        
        }
        public WPTLivesDisplayUI()
        {
        
        }
    
    }

}
