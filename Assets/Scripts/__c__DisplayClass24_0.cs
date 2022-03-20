using UnityEngine;
private sealed class SRServiceManager.<>c__DisplayClass24_0
{
    // Fields
    public SRF.Service.ServiceSelectorAttribute attrib;
    
    // Methods
    public SRServiceManager.<>c__DisplayClass24_0()
    {
    
    }
    internal bool <ScanTypeForSelectors>b__0(SRF.Service.SRServiceManager.ServiceStub p)
    {
        return System.Type.op_Equality(left:  p.InterfaceType, right:  this.attrib.<ServiceType>k__BackingField);
    }

}
