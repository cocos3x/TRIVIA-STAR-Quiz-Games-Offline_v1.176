using UnityEngine;
public struct LoadTimer.LoadTimerData
{
    // Fields
    public float startTime;
    public bool stopOnLevelLoaded;
    
    // Methods
    public LoadTimer.LoadTimerData(bool stopOnLevelWasLoaded)
    {
        float val_1 = UnityEngine.Time.realtimeSinceStartup;
        this = 0;
        this.stopOnLevelLoaded = stopOnLevelWasLoaded;
    }

}
