using UnityEngine;
private class AnimationStateData.AnimationPairComparer : IEqualityComparer<Spine.AnimationStateData.AnimationPair>
{
    // Fields
    internal static readonly Spine.AnimationStateData.AnimationPairComparer Instance;
    
    // Methods
    private bool System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.Equals(Spine.AnimationStateData.AnimationPair x, Spine.AnimationStateData.AnimationPair y)
    {
        Spine.Animation val_1 = y.a2;
        x.a1 = x.a1 ^ y.a1;
        val_1 = x.a2 ^ val_1;
        val_1 = x.a1 | val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    private int System.Collections.Generic.IEqualityComparer<Spine.AnimationStateData.AnimationPair>.GetHashCode(Spine.AnimationStateData.AnimationPair obj)
    {
        Spine.Animation val_2 = obj.a2;
        val_2 = val_2 ^ (obj.a1 + (obj.a1 << 5));
        return (int)val_2;
    }
    public AnimationStateData.AnimationPairComparer()
    {
    
    }
    private static AnimationStateData.AnimationPairComparer()
    {
        AnimationStateData.AnimationPairComparer.Instance = new System.Object();
    }

}
