using UnityEngine;
public class WordBubblesBubbleSelect : WordBubblesBubble
{
    // Methods
    public override void OnClick()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static SLC.Minigames.Bubbles.WordBubblesController MonoSingleton<SLC.Minigames.Bubbles.WordBubblesController>::get_Instance().__il2cppRuntimeField_22) != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TurnBackWordElement(select:  R4);
    }
    public WordBubblesBubbleSelect()
    {
    
    }

}
