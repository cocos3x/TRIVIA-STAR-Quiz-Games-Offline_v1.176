using UnityEngine;
public class SLCWindowSetting : MonoBehaviour
{
    // Fields
    public WGWindowBackgroundHandler.WGWindowBackgroundType backgroundType;
    public bool backButtonCanClose;
    
    // Methods
    public SLCWindowSetting()
    {
        this.backButtonCanClose = true;
        this.backgroundType = true;
    }

}
