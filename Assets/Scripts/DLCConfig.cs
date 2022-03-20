using UnityEngine;
public class DLCConfig : ScriptableObject
{
    // Fields
    public int version;
    public System.Collections.Generic.List<string> packing_tags;
    public System.Collections.Generic.List<string> folders;
    
    // Methods
    public DLCConfig()
    {
        this.version = 130;
    }

}
