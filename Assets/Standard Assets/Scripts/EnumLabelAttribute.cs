using UnityEngine;
public class EnumLabelAttribute : PropertyAttribute
{
    // Fields
    public string label;
    
    // Methods
    public EnumLabelAttribute(string label)
    {
        this.label = label;
    }

}
