using UnityEngine;
[Serializable]
public class WindowsConfig : ProductConfig
{
    // Fields
    public string supportUrl;
    
    // Methods
    public WindowsConfig()
    {
        this.supportUrl = "Support url for help";
    }

}
