using UnityEngine;
public class SoftSaved : Attribute
{
    // Fields
    public string serializedName;
    public bool highPrioritySave;
    
    // Methods
    public SoftSaved(string serializedName, bool highPrioSave = False)
    {
        this.serializedName = serializedName;
        this.highPrioritySave = highPrioSave;
    }

}
