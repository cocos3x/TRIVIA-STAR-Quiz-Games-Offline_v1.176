using UnityEngine;
public class HardSaved : Attribute
{
    // Fields
    public string serializedName;
    
    // Methods
    public HardSaved(string serializedName)
    {
        this.serializedName = serializedName;
    }

}
