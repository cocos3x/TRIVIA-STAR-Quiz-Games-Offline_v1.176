using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizEcon
    {
        // Properties
        public static decimal HintCost { get; }
        
        // Methods
        public static decimal get_HintCost()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance()) != 0)
            {
                    return new System.Decimal() {flags = -1745297728, hi = MonoSingleton<T>.__il2cppRuntimeField_cctor_finished};
            }
            
            return new System.Decimal() {flags = -1745297728, hi = MonoSingleton<T>.__il2cppRuntimeField_cctor_finished};
        }
        public static int GetAmountOfLetterButtons(int gameLevel)
        {
            if(gameLevel < 26)
            {
                    return (int)8;
            }
            
            if(gameLevel >= 76)
            {
                    8 = 12;
            }
            
            if(gameLevel < 126)
            {
                    return (int)8;
            }
            
            if(gameLevel >= 201)
            {
                    14 = 16;
            }
            
            if(gameLevel <= 300)
            {
                    return (int)8;
            }
            
            if(gameLevel > 400)
            {
                    18 = 21;
            }
            
            return (int)8;
        }
        public ImageQuizEcon()
        {
        
        }
    
    }

}
