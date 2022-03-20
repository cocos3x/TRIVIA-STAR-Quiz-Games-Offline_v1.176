using UnityEngine;
public class RaidAttackWindowManager : SLCWindowManager<RaidAttackWindowManager>
{
    // Properties
    protected override System.Type myWindowType { get; }
    
    // Methods
    protected override System.Type get_myWindowType()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(366878720)});
    }
    public RaidAttackWindowManager()
    {
    
    }

}
