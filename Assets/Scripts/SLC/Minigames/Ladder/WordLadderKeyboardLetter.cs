using UnityEngine;

namespace SLC.Minigames.Ladder
{
    public class WordLadderKeyboardLetter : WordLadderLetter
    {
        // Methods
        public override void OnClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.Ladder.WordLadderController MonoSingleton<SLC.Minigames.Ladder.WordLadderController>::get_Instance().__il2cppRuntimeField_1C) != 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SubmitLetter(item:  R4);
        }
        public WordLadderKeyboardLetter()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
