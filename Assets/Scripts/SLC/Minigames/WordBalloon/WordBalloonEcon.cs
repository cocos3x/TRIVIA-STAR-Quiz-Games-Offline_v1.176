using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordBalloonEcon
    {
        // Fields
        public const int USED_CATEGORIES_HISTORY_SIZE = 50;
        
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
        public static int GetAmountOfWords(int gameLevel)
        {
            if(gameLevel < 6)
            {
                    return (int)3;
            }
            
            if(gameLevel >= 11)
            {
                    3 = 5;
            }
            
            if(gameLevel < 26)
            {
                    return (int)3;
            }
            
            if(gameLevel >= 51)
            {
                    6 = 7;
            }
            
            if(gameLevel < 101)
            {
                    return (int)3;
            }
            
            if(gameLevel >= 176)
            {
                    8 = 9;
            }
            
            if(gameLevel < 251)
            {
                    return (int)3;
            }
            
            if(gameLevel < 351)
            {
                    return (int)3;
            }
            
            if(gameLevel > 425)
            {
                    11 = 12;
            }
            
            return (int)3;
        }
        public WordBalloonEcon()
        {
        
        }
    
    }

}
