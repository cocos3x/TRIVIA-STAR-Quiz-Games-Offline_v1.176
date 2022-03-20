using UnityEngine;
public class SelectableLabelAttribute : PropertyAttribute
{
    // Fields
    public string text;
    
    // Methods
    public SelectableLabelAttribute(string text)
    {
        this.text = text;
    }

}
