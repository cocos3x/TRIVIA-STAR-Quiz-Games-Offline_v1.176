using UnityEngine;
[Serializable]
public class UIThemeTemplate
{
    // Fields
    public UnityEngine.GameObject gameObject;
    public ApplyDimensionStyle widthApplication;
    public ApplyDimensionStyle heightApplication;
    public bool applyXPosition;
    public bool applyYPosition;
    public bool applyImageType;
    public bool applyPreserveAspect;
    public bool applyPivot;
    public bool applyMatchingChildrenXfms;
    
    // Properties
    public bool applyWidth { get; }
    public bool applyHeight { get; }
    
    // Methods
    public bool get_applyWidth()
    {
        ApplyDimensionStyle val_1 = this.widthApplication;
        val_1 = val_1 - 1;
        if()
        {
                val_1 = 1;
        }
        
        return true;
    }
    public bool get_applyHeight()
    {
        ApplyDimensionStyle val_1 = this.heightApplication;
        val_1 = val_1 - 1;
        if()
        {
                val_1 = 1;
        }
        
        return true;
    }
    public UIThemeTemplate()
    {
        this.applyPivot = true;
        this.applyMatchingChildrenXfms = true;
        this.applyXPosition = true;
        this.applyYPosition = true;
        this.applyImageType = true;
        this.applyPreserveAspect = true;
    }

}
