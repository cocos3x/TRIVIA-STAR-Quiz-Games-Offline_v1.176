using UnityEngine;
public struct Skin.AttachmentKeyTuple
{
    // Fields
    public readonly int slotIndex;
    public readonly string name;
    internal readonly int nameHashCode;
    
    // Methods
    public Skin.AttachmentKeyTuple(int slotIndex, string name)
    {
        this.nameHashCode = name;
    }

}
