using UnityEngine;
public class PopupAttribute : PropertyAttribute
{
    // Fields
    public object[] list;
    
    // Methods
    public PopupAttribute(object[] list)
    {
        this.list = list;
    }

}
