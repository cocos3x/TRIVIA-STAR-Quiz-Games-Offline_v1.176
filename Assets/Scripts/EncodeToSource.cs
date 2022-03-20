using UnityEngine;
public class EncodeToSource : Attribute
{
    // Fields
    public string serverName;
    public string prefsName;
    
    // Methods
    public EncodeToSource(string serverName, string prefsName)
    {
        this.serverName = serverName;
        this.prefsName = prefsName;
    }

}
