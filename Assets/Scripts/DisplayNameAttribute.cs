using UnityEngine;
public sealed class SROptions.DisplayNameAttribute : Attribute
{
    // Fields
    public readonly string Name;
    
    // Methods
    public SROptions.DisplayNameAttribute(string name)
    {
        this.Name = name;
    }

}
