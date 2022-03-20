using UnityEngine;
public class CategoriesWindowManager : SLCWindowManager<CategoriesWindowManager>
{
    // Properties
    protected override System.Type myWindowType { get; }
    
    // Methods
    protected override System.Type get_myWindowType()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(310808576)});
    }
    public CategoriesWindowManager()
    {
    
    }

}
