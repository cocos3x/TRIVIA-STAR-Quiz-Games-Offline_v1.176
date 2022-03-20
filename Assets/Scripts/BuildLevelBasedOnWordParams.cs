using UnityEngine;
public class BuildLevelBasedOnWordParams : LevelBuildParams
{
    // Fields
    public string levelWord;
    public bool includeUncommonAsRequiredWords;
    public int requiredExtraWords;
    public bool ignoreRetries;
    
    // Methods
    public BuildLevelBasedOnWordParams()
    {
        this.levelWord = "";
    }

}
