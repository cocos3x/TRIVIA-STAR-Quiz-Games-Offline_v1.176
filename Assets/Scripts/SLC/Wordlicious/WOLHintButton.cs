using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLHintButton : MyButton
    {
        // Fields
        private UnityEngine.UI.Text hintCostText;
        
        // Properties
        public static bool isFree { get; }
        
        // Methods
        public static bool get_isFree()
        {
            var val_4;
            var val_5;
            val_4 = 1152921504892043264;
            val_5 = 0;
            GameEcon val_1 = App.getGameEcon;
            if(812 < 0)
            {
                    return true;
            }
            
            Player val_2 = App.Player;
            GameEcon val_3 = App.getGameEcon;
            val_4 = 0;
            if(0 < 812)
            {
                    val_5 = 1;
            }
            
            return true;
        }
        public void Start()
        {
            this.Start();
            if(SLC.Wordlicious.WOLHintButton.isFree != false)
            {
                    if(this.hintCostText != 0)
            {
                    return;
            }
            
                return;
            }
            
            GameEcon val_2 = App.getGameEcon;
            GameEcon val_3 = App.getGameEcon;
            string val_4 = ToString(format:  null);
        }
        public override void OnButtonClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HintClick(free:  SLC.Wordlicious.WOLHintButton.isFree);
        }
        public WOLHintButton()
        {
        
        }
    
    }

}
