using UnityEngine;

namespace WordForest
{
    public class WFOWordStreakFeedback : GoldenApplesFeedbackWord
    {
        // Properties
        protected override bool extraWordsAllowed { get; }
        
        // Methods
        protected override bool get_extraWordsAllowed()
        {
            return true;
        }
        protected override void UpdateText()
        {
            var val_9;
            object val_1 = static_value_021FA653.Dequeue();
            int val_2 = R6.Dequeue();
            bool val_3 = UnityEngine.Object.op_Implicit(exists:  R6);
            bool val_4 = UnityEngine.Object.op_Implicit(exists:  R6);
            string val_5 = Localization.Localize(key:  -1240110144, defaultValue:  -1240110240, useSingularKey:  false);
            if((static_value_021FA653.Equals(value:  -1240110144)) != false)
            {
                    val_9 = "+1 STREAK";
            }
            else
            {
                    int val_7 = WordStreak.CurrentStreak;
                string val_8 = System.String.Format(format:  358296832, arg0:  13152256);
                val_9 = "x{0} STREAK";
            }
            
            if(this != 0)
            {
                    return;
            }
        
        }
        protected override void PlayParticles()
        {
        
        }
        public WFOWordStreakFeedback()
        {
        
        }
    
    }

}
