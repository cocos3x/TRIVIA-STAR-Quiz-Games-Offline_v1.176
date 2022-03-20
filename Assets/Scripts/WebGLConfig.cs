using UnityEngine;
[Serializable]
public class WebGLConfig : ProductConfig
{
    // Fields
    public string bundleVersion;
    public string supportUrl;
    
    // Methods
    public WebGLConfig()
    {
        this.bundleVersion = "1.0";
        this.supportUrl = "https://support.12gigs.com";
    }

}
