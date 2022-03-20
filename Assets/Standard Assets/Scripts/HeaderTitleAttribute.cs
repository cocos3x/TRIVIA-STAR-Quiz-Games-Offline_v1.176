using UnityEngine;
public class HeaderTitleAttribute : PropertyAttribute
{
    // Fields
    public string headerText;
    public string text;
    
    // Methods
    public HeaderTitleAttribute(string header)
    {
        this.headerText = header;
    }
    public HeaderTitleAttribute(string header, string text)
    {
        this.headerText = header;
        this.text = text;
    }

}
