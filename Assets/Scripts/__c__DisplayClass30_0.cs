using UnityEngine;
private sealed class BBLGameplayUIController.<>c__DisplayClass30_0
{
    // Fields
    public BlockPuzzleMagic.FtuxId stageToShow;
    public UnityEngine.GameObject target;
    
    // Methods
    public BBLGameplayUIController.<>c__DisplayClass30_0()
    {
    
    }
    internal void <CheckShowFTUXOnInputResolved>b__0()
    {
        var val_5;
        BlockPuzzleMagic.BBLGameplayUIHelper.CloseGameplayOverlay(immediate:  false, onOverlayClosed:  0);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 0;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                val_5 = 0;
        }
        
        ShowFTUXStep(stage:  this.stageToShow, targetGO:  this.target);
    }

}
