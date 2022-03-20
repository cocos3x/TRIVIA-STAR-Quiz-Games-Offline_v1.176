using UnityEngine;
public class TooltipAttribute : PropertyAttribute
{
    // Fields
    public string tooltip;
    
    // Methods
    public TooltipAttribute(string tooltip)
    {
        this.tooltip = tooltip;
    }

}
