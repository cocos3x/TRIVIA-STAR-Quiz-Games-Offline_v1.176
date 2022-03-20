using UnityEngine;
public class PlatformGameVersion
{
    // Fields
    private PlatformGameVersion.Platform <PlatformType>k__BackingField;
    private string <Version>k__BackingField;
    private string <StoreUrl>k__BackingField;
    private bool <ForceUpdate>k__BackingField;
    private string <Message>k__BackingField;
    
    // Properties
    public PlatformGameVersion.Platform PlatformType { get; set; }
    public string Version { get; set; }
    public string StoreUrl { get; set; }
    public bool ForceUpdate { get; set; }
    public string Message { get; set; }
    
    // Methods
    public PlatformGameVersion.Platform get_PlatformType()
    {
    
    }
    public void set_PlatformType(PlatformGameVersion.Platform value)
    {
        this.<PlatformType>k__BackingField = value;
    }
    public string get_Version()
    {
    
    }
    public void set_Version(string value)
    {
        this.<Version>k__BackingField = value;
    }
    public string get_StoreUrl()
    {
    
    }
    public void set_StoreUrl(string value)
    {
        this.<StoreUrl>k__BackingField = value;
    }
    public bool get_ForceUpdate()
    {
        return (bool)this.<ForceUpdate>k__BackingField;
    }
    public void set_ForceUpdate(bool value)
    {
        this.<ForceUpdate>k__BackingField = value;
    }
    public string get_Message()
    {
    
    }
    public void set_Message(string value)
    {
        this.<Message>k__BackingField = value;
    }
    public PlatformGameVersion()
    {
    
    }

}
