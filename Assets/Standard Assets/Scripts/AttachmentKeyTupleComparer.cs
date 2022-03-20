using UnityEngine;
private class Skin.AttachmentKeyTupleComparer : IEqualityComparer<Spine.Skin.AttachmentKeyTuple>
{
    // Fields
    internal static readonly Spine.Skin.AttachmentKeyTupleComparer Instance;
    
    // Methods
    private bool System.Collections.Generic.IEqualityComparer<Spine.Skin.AttachmentKeyTuple>.Equals(Spine.Skin.AttachmentKeyTuple o1, Spine.Skin.AttachmentKeyTuple o2)
    {
        if(o1.slotIndex == o2.slotIndex)
        {
                o2.slotIndex = o2.nameHashCode;
        }
        
        if(o1.nameHashCode == o2.slotIndex)
        {
                return System.String.op_Equality(a:  o1.name, b:  o2.name);
        }
        
        return false;
    }
    private int System.Collections.Generic.IEqualityComparer<Spine.Skin.AttachmentKeyTuple>.GetHashCode(Spine.Skin.AttachmentKeyTuple o)
    {
        return (int)o.slotIndex;
    }
    public Skin.AttachmentKeyTupleComparer()
    {
    
    }
    private static Skin.AttachmentKeyTupleComparer()
    {
        Skin.AttachmentKeyTupleComparer.Instance = new System.Object();
    }

}
