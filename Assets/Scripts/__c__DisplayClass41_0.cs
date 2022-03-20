using UnityEngine;
private sealed class AutopilotManager.<>c__DisplayClass41_0
{
    // Fields
    public int cameraInstanceID;
    
    // Methods
    public AutopilotManager.<>c__DisplayClass41_0()
    {
    
    }
    internal bool <ExecuteSelectableAction>b__1(twelvegigs.Autopilot.AutopilotButton aButton)
    {
        if(aButton == 0)
        {
                return (bool)0;
        }
        
        int val_2 = this.cameraInstanceID;
        val_2 = (aButton.<CameraId>k__BackingField) - val_2;
        0 = val_2 >> 5;
        return (bool)0;
    }

}
