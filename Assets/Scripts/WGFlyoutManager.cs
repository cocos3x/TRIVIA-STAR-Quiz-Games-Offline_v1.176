using UnityEngine;
public class WGFlyoutManager : SLCWindowManager<WGFlyoutManager>
{
    // Properties
    protected override System.Type myWindowType { get; }
    
    // Methods
    protected override System.Type get_myWindowType()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(388603904)});
    }
    public WGFlyoutManager()
    {
    
    }

}
