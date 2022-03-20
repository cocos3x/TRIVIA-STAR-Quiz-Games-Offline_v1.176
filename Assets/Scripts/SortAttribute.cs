using UnityEngine;
public sealed class SROptions.SortAttribute : Attribute
{
    // Fields
    public readonly int SortPriority;
    
    // Methods
    public SROptions.SortAttribute(int priority)
    {
        this.SortPriority = priority;
    }

}
