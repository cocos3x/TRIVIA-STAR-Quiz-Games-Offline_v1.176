using UnityEngine;
public sealed class SROptions.DisplayColorAttribute : Attribute
{
    // Fields
    public readonly UnityEngine.Color Color;
    
    // Methods
    public SROptions.DisplayColorAttribute(float r, float g, float b)
    {
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  r, g:  g, b:  b);
    }

}
