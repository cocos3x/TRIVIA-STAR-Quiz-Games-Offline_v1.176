using UnityEngine;
public class ObserveAttribute : PropertyAttribute
{
    // Fields
    public string[] callbackNames;
    
    // Methods
    public ObserveAttribute(string[] callbackNames)
    {
        this.callbackNames = callbackNames;
    }

}
