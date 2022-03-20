using UnityEngine;
[Serializable]
public class IosConfig : ProductConfig
{
    // Fields
    public string KEYCHAIN_ACCESS_GROUP;
    public string adjustUniversalLinkUrl;
    public string supportUrl;
    public bool firebaseAnalyticsEnabled;
    
    // Methods
    public IosConfig()
    {
    
    }

}
