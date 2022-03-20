using UnityEngine;
public class DynamicLevelBuildParams : LevelBuildParams
{
    // Fields
    public int levelWordLength;
    public bool includeAvailableExtra;
    
    // Methods
    public DynamicLevelBuildParams()
    {
        this.includeAvailableExtra = true;
    }

}
