using UnityEngine;
public class SceneNameAttribute : PropertyAttribute
{
    // Fields
    public int selectedValue;
    public bool enableOnly;
    
    // Methods
    public SceneNameAttribute(bool enableOnly = True)
    {
        this.enableOnly = true;
        this.enableOnly = enableOnly;
    }

}
