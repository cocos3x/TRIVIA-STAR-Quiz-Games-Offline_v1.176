using UnityEngine;
public class LibraryWindowManager : SLCWindowManager<LibraryWindowManager>
{
    // Fields
    private bool canShowWindows;
    
    // Properties
    public bool CanShowWindows { get; set; }
    protected override System.Type myWindowType { get; }
    
    // Methods
    public bool get_CanShowWindows()
    {
        return (bool)this.canShowWindows;
    }
    public void set_CanShowWindows(bool value)
    {
        this.canShowWindows = value;
    }
    protected override System.Type get_myWindowType()
    {
        return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(300638208)});
    }
    public LibraryWindowManager()
    {
        this.canShowWindows = true;
    }

}
