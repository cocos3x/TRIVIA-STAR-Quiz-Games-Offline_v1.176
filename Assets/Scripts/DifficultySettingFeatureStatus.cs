using UnityEngine;
public class DifficultySettingFeatureStatus
{
    // Fields
    public const string KEY_FEATURE_PROMPTED = "feature_prompted";
    public const string KEY_FTUX_SEEN = "feature_isFtuxSeen";
    public bool Prompted;
    public bool IsFtuxSeen;
    public bool IsFtuxLevel;
    
    // Methods
    public DifficultySettingFeatureStatus()
    {
        this.IsFtuxLevel = false;
        this.Prompted = false;
        this.IsFtuxSeen = false;
    }

}
