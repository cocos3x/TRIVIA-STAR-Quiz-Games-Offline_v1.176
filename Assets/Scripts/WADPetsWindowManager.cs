using UnityEngine;
public class WADPetsWindowManager : SLCWindowManager<WADPetsWindowManager>
{
    // Properties
    protected override System.Type myWindowType { get; }
    
    // Methods
    protected override System.Type get_myWindowType()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(335994880)});
    }
    public WADPetsWindowManager()
    {
    
    }

}
