using UnityEngine;
private struct AnimationStateData.AnimationPair
{
    // Fields
    public readonly Spine.Animation a1;
    public readonly Spine.Animation a2;
    
    // Methods
    public AnimationStateData.AnimationPair(Spine.Animation a1, Spine.Animation a2)
    {
    
    }
    public override string ToString()
    {
        if(this.a2 != 0)
        {
                return AnimationStateData.AnimationPair.__il2cppRuntimeField_byval_arg + 1883404176 + this.a2.name;
        }
        
        return AnimationStateData.AnimationPair.__il2cppRuntimeField_byval_arg + 1883404176 + this.a2.name;
    }

}
